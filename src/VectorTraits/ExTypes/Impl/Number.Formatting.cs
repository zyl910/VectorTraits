#undef THIS_HIDE
#define TARGET_64BIT
#if NET5_0_OR_GREATER
#define BCL_TYPE_HALF
#endif // NET5_0_OR_GREATER
#if NET7_0_OR_GREATER
#define BCL_TYPE_INT128
#define GENERICS_MATH
#endif // NET7_0_OR_GREATER

using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Zyl.VectorTraits.Impl.Util;
using Zyl.VectorTraits.Numerics;

namespace Zyl.VectorTraits.ExTypes.Impl {
    using BitConverter = MathBitConverter;
    //using IBinaryFloatParseAndFormatInfo = IComparable;
    //using IUtfChar = IEquatable;

    internal static partial class Number {
        internal const int DecimalPrecision = 29; // Decimal.DecCalc also uses this value

        /// <summary>The non-inclusive upper bound of <see cref="s_smallNumberCache"/>.</summary>
        /// <remarks>
        /// This is a semi-arbitrary bound. For mono, which is often used for more size-constrained workloads,
        /// we keep the size really small, supporting only single digit values.  For coreclr, we use a larger
        /// value, still relatively small but large enough to accommodate common sources of numbers to strings, e.g. HTTP success status codes.
        /// By being >= 255, it also accommodates all byte.ToString()s.  If no small numbers are ever formatted, we incur
        /// the ~2400 bytes on 64-bit for the array itself.  If all small numbers are formatted, we incur ~11,500 bytes
        /// on 64-bit for the array and all the strings.
        /// </remarks>
        private const int SmallNumberCacheLength =
#if MONO
            10;
#else
            300;
#endif
        /// <summary>Lazily-populated cache of strings for uint values in the range [0, <see cref="SmallNumberCacheLength"/>).</summary>
        private static readonly string[] s_smallNumberCache = new string[SmallNumberCacheLength];

        // Optimizations using "TwoDigits" inspired by:
        // https://engineering.fb.com/2013/03/15/developer-tools/three-optimization-tips-for-c/
        private static readonly byte[] TwoDigitsCharsAsBytes =
            MemoryMarshal.AsBytes<char>(("00010203040506070809" +
                                        "10111213141516171819" +
                                        "20212223242526272829" +
                                        "30313233343536373839" +
                                        "40414243444546474849" +
                                        "50515253545556575859" +
                                        "60616263646566676869" +
                                        "70717273747576777879" +
                                        "80818283848586878889" +
                                        "90919293949596979899").AsSpan()).ToArray();
        private static readonly byte[] TwoDigitsBytes =
                                       ("00010203040506070809"u8 +
                                        "10111213141516171819"u8 +
                                        "20212223242526272829"u8 +
                                        "30313233343536373839"u8 +
                                        "40414243444546474849"u8 +
                                        "50515253545556575859"u8 +
                                        "60616263646566676869"u8 +
                                        "70717273747576777879"u8 +
                                        "80818283848586878889"u8 +
                                        "90919293949596979899"u8).ToArray();

        public static string FormatDecimal(decimal value, ReadOnlySpan<char> format, NumberFormatInfo info) {
            char fmt = ParseFormatSpecifier(format, out int digits);

            Span<byte> pDigits = stackalloc byte[DecimalNumberBufferLength];
            NumberBuffer number = new NumberBuffer(NumberBufferKind.Decimal, pDigits);

            DecimalToNumber(ref value, ref number);

            Span<char> stackPtr = stackalloc char[CharStackBufferSize];
            var vlb = new ValueListBuilder<char>(stackPtr);

            if (fmt != 0) {
                NumberToString(ref vlb, ref number, fmt, digits, info);
            } else {
                NumberToStringFormat(ref vlb, ref number, format, info);
            }

            string result = vlb.AsSpan().ToString();
            vlb.Dispose();
            return result;
        }

        public static bool TryFormatDecimal<TChar>(decimal value, ReadOnlySpan<char> format, NumberFormatInfo info, Span<TChar> destination, out int charsWritten) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));

            char fmt = ParseFormatSpecifier(format, out int digits);

            Span<byte> pDigits = stackalloc byte[DecimalNumberBufferLength];
            NumberBuffer number = new NumberBuffer(NumberBufferKind.Decimal, pDigits);

            DecimalToNumber(ref value, ref number);

            Span<TChar> stackPtr = stackalloc TChar[CharStackBufferSize];
            var vlb = new ValueListBuilder<TChar>(stackPtr);

            if (fmt != 0) {
                NumberToString(ref vlb, ref number, fmt, digits, info);
            } else {
                NumberToStringFormat(ref vlb, ref number, format, info);
            }

            bool success = vlb.TryCopyTo(destination, out charsWritten);
            vlb.Dispose();
            return success;
        }

        internal static void DecimalToNumber(scoped ref decimal d, ref NumberBuffer number) {
            ref byte buffer = ref number.DigitsPtr;
            number.DigitsCount = DecimalPrecision;
            number.IsNegative = MathINumberBase.IsNegative(d);

            ref byte pEnd = ref Unsafe.Add(ref buffer, DecimalPrecision);
            ref byte p = ref pEnd;
            while (DecimalGetMidOrHigh(d) != 0) { // while ((d.Mid | d.High) != 0)
                p = UInt32ToDecChars(ref p, DecDivMod1E9(ref d), 9);
            }
            p = UInt32ToDecChars(ref p, DecimalGetLow(d), 0);

            int i = (int)(Unsafe.ByteOffset(ref p, ref pEnd));

            number.DigitsCount = i;
            number.Scale = i - DecimalGetScale(d);

            ref byte dst = ref number.DigitsPtr;
            while (--i >= 0) {
                // *dst++ = *p++;
                dst = p;
                dst = ref Unsafe.Add(ref dst, 1);
                p = ref Unsafe.Add(ref p, 1);
            }
            dst = (byte)'\0';

            number.CheckConsistency();
        }

        private static int GetFloatingPointMaxDigitsAndPrecision(char fmt, ref int precision, NumberFormatInfo info, out bool isSignificantDigits) {
            if (fmt == 0) {
                isSignificantDigits = true;
                return precision;
            }

            int maxDigits = precision;

            switch (fmt) {
                case 'C':
                case 'c': {
                        // The currency format uses the precision specifier to indicate the number of
                        // decimal digits to format. This defaults to NumberFormatInfo.CurrencyDecimalDigits.

                        if (precision == -1) {
                            precision = info.CurrencyDecimalDigits;
                        }
                        isSignificantDigits = false;

                        break;
                    }

                case 'E':
                case 'e': {
                        // The exponential format uses the precision specifier to indicate the number of
                        // decimal digits to format. This defaults to 6. However, the exponential format
                        // also always formats a single integral digit, so we need to increase the precision
                        // specifier and treat it as the number of significant digits to account for this.

                        if (precision == -1) {
                            precision = DefaultPrecisionExponentialFormat;
                        }

                        precision++;
                        isSignificantDigits = true;

                        break;
                    }

                case 'F':
                case 'f':
                case 'N':
                case 'n': {
                        // The fixed-point and number formats use the precision specifier to indicate the number
                        // of decimal digits to format. This defaults to NumberFormatInfo.NumberDecimalDigits.

                        if (precision == -1) {
                            precision = info.NumberDecimalDigits;
                        }
                        isSignificantDigits = false;

                        break;
                    }

                case 'G':
                case 'g': {
                        // The general format uses the precision specifier to indicate the number of significant
                        // digits to format. This defaults to the shortest roundtrippable string. Additionally,
                        // given that we can't return zero significant digits, we treat 0 as returning the shortest
                        // roundtrippable string as well.

                        if (precision == 0) {
                            precision = -1;
                        }
                        isSignificantDigits = true;

                        break;
                    }

                case 'P':
                case 'p': {
                        // The percent format uses the precision specifier to indicate the number of
                        // decimal digits to format. This defaults to NumberFormatInfo.PercentDecimalDigits.
                        // However, the percent format also always multiplies the number by 100, so we need
                        // to increase the precision specifier to ensure we get the appropriate number of digits.

                        if (precision == -1) {
                            precision = info.PercentDecimalDigits;
                        }

                        precision += 2;
                        isSignificantDigits = false;

                        break;
                    }

                case 'R':
                case 'r': {
                        // The roundtrip format ignores the precision specifier and always returns the shortest
                        // roundtrippable string.

                        precision = -1;
                        isSignificantDigits = true;

                        break;
                    }

                default: {
                        ThrowHelper.ThrowFormatException_BadFormatSpecifier();
                        goto case 'r'; // unreachable
                    }
            }

            return maxDigits;
        }
/*
        public static string FormatFloat<TNumber>(TNumber value, string? format, NumberFormatInfo info)
            where TNumber : unmanaged, IComparable<TNumber>
#if GENERICS_MATH
            , IBinaryFloatingPointIeee754<TNumber>
#endif
            {
            var vlb = new ValueListBuilder<char>(stackalloc char[CharStackBufferSize]);
            string result = FormatFloat(ref vlb, value, format.AsSpan(), info) ?? vlb.AsSpan().ToString();
            vlb.Dispose();
            return result;
        }

        public static bool TryFormatFloat<TNumber, TChar>(TNumber value, ReadOnlySpan<char> format, NumberFormatInfo info, Span<TChar> destination, out int charsWritten)
            where TNumber : unmanaged, IComparable<TNumber>
#if GENERICS_MATH
            , IBinaryFloatingPointIeee754<TNumber>
#endif
            where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));

            var vlb = new ValueListBuilder<TChar>(stackalloc TChar[CharStackBufferSize]);
            string? s = FormatFloat(ref vlb, value, format, info);

            Debug.Assert(s is null || typeof(TChar) == typeof(char));
            bool success = s != null ?
                TryCopyTo(s, destination, out charsWritten) :
                vlb.TryCopyTo(destination, out charsWritten);

            vlb.Dispose();
            return success;
        }

        /// <summary>Formats the specified value according to the specified format and info.</summary>
        /// <returns>
        /// Non-null if an existing string can be returned, in which case the builder will be unmodified.
        /// Null if no existing string was returned, in which case the formatted output is in the builder.
        /// </returns>
        private static string? FormatFloat<TNumber, TChar>(scoped ref ValueListBuilder<TChar> vlb, TNumber value, ReadOnlySpan<char> format, NumberFormatInfo info)
            where TNumber : unmanaged, IComparable<TNumber>
#if GENERICS_MATH
            , IBinaryFloatingPointIeee754<TNumber>
#endif
            where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));

            if (!IsFinite(value)) {
                if (IsNaN(value)) {
                    if (typeof(TChar) == typeof(char)) {
                        return info.NaNSymbol;
                    } else {
                        vlb.Append(info.NaNSymbolTChar<TChar>());
                        return null;
                    }
                }

                if (typeof(TChar) == typeof(char)) {
                    return IsNegative(value) ? info.NegativeInfinitySymbol : info.PositiveInfinitySymbol;
                } else {
                    vlb.Append(IsNegative(value) ? info.NegativeInfinitySymbolTChar<TChar>() : info.PositiveInfinitySymbolTChar<TChar>());
                    return null;
                }
            }

            char fmt = ParseFormatSpecifier(format, out int precision);
            Span<byte> pDigits = stackalloc byte[FloatFormatInfo<TNumber>.NumberBufferLength];

            if (fmt == '\0') {
                precision = FloatFormatInfo<TNumber>.MaxPrecisionCustomFormat;
            }

            NumberBuffer number = new NumberBuffer(NumberBufferKind.FloatingPoint, pDigits);
            number.IsNegative = IsNegative(value);

            // We need to track the original precision requested since some formats
            // accept values like 0 and others may require additional fixups.
            int nMaxDigits = GetFloatingPointMaxDigitsAndPrecision(fmt, ref precision, info, out bool isSignificantDigits);

#if THIS_HIDE
            if ((value != default) && (!isSignificantDigits || !Grisu3.TryRun(value, precision, ref number))) {
                Dragon4(value, precision, isSignificantDigits, ref number);
            }
#endif

            number.CheckConsistency();

            // When the number is known to be roundtrippable (either because we requested it be, or
            // because we know we have enough digits to satisfy roundtrippability), we should validate
            // that the number actually roundtrips back to the original result.

            Debug.Assert(((precision != -1) && (precision < FloatFormatInfo<TNumber>.MaxRoundTripDigits)) || (FloatFormatInfo<TNumber>.FloatToBits(value) == FloatFormatInfo<TNumber>.FloatToBits(NumberToFloat<TNumber>(ref number))));

            if (fmt != 0) {
                if (precision == -1) {
                    Debug.Assert((fmt == 'G') || (fmt == 'g') || (fmt == 'R') || (fmt == 'r'));

                    // For the roundtrip and general format specifiers, when returning the shortest roundtrippable
                    // string, we need to update the maximum number of digits to be the greater of number.DigitsCount
                    // or SinglePrecision. This ensures that we continue returning "pretty" strings for values with
                    // less digits. One example this fixes is "-60", which would otherwise be formatted as "-6E+01"
                    // since DigitsCount would be 1 and the formatter would almost immediately switch to scientific notation.

                    nMaxDigits = Math.Max(number.DigitsCount, FloatFormatInfo<TNumber>.MaxRoundTripDigits);
                }
                NumberToString(ref vlb, ref number, fmt, nMaxDigits, info);
            } else {
                Debug.Assert(precision == FloatFormatInfo<TNumber>.MaxPrecisionCustomFormat);
                NumberToStringFormat(ref vlb, ref number, format, info);
            }
            return null;
        }
*/
        private static bool TryCopyTo<TChar>(string source, Span<TChar> destination, out int charsWritten) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));
            Debug.Assert(source != null);

            if (typeof(TChar) == typeof(char)) {
                if (source.AsSpan().TryCopyTo(MemoryMarshal.Cast<TChar, char>(destination))) {
                    charsWritten = source!.Length;
                    return true;
                }

                charsWritten = 0;
                return false;
            } else {
                return Encoding.UTF8.TryGetBytes(source.AsSpan(), MemoryMarshal.Cast<TChar, byte>(destination), out charsWritten);
            }
        }

        internal static char GetHexBase(char fmt) {
            // The fmt-(X-A+10) hack has the effect of dictating whether we produce uppercase or lowercase
            // hex numbers for a-f. 'X' as the fmt code produces uppercase. 'x' as the format code produces lowercase.
            return (char)(fmt - ('X' - 'A' + 10));
        }

        public static string FormatInt32(int value, int hexMask, string? format, IFormatProvider? provider) {
            // Fast path for default format
            if (string.IsNullOrEmpty(format)) {
                return value >= 0 ?
                    UInt32ToDecStr((uint)value) :
                    NegativeInt32ToDecStr(value, digits: -1, NumberFormatInfo.GetInstance(provider).NegativeSign);
            }

            return FormatInt32Slow(value, hexMask, format, provider);

            static string FormatInt32Slow(int value, int hexMask, string? format, IFormatProvider? provider) {
                ReadOnlySpan<char> formatSpan = format.AsSpan();
                char fmt = ParseFormatSpecifier(formatSpan, out int digits);
                char fmtUpper = (char)(fmt & 0xFFDF); // ensure fmt is upper-cased for purposes of comparison
                if (fmtUpper == 'G' ? digits < 1 : fmtUpper == 'D') {
                    return value >= 0 ?
                        UInt32ToDecStr((uint)value, digits) :
                        NegativeInt32ToDecStr(value, digits, NumberFormatInfo.GetInstance(provider).NegativeSign);
                } else if (fmtUpper == 'X') {
                    return Int32ToHexStr(value & hexMask, GetHexBase(fmt), digits);
                } else if (fmtUpper == 'B') {
                    return UInt32ToBinaryStr((uint)(value & hexMask), digits);
                } else {
                    NumberFormatInfo info = NumberFormatInfo.GetInstance(provider);

                    Span<byte> pDigits = stackalloc byte[Int32NumberBufferLength];
                    NumberBuffer number = new NumberBuffer(NumberBufferKind.Integer, pDigits);

                    Int32ToNumber(value, ref number);

                    Span<char> stackPtr = stackalloc char[CharStackBufferSize];
                    var vlb = new ValueListBuilder<char>(stackPtr);

                    if (fmt != 0) {
                        NumberToString(ref vlb, ref number, fmt, digits, info);
                    } else {
                        NumberToStringFormat(ref vlb, ref number, formatSpan, info);
                    }

                    string result = vlb.AsSpan().ToString();
                    vlb.Dispose();
                    return result;
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] // expose to caller's likely-const format to trim away slow path
        public static bool TryFormatInt32<TChar>(int value, int hexMask, ReadOnlySpan<char> format, IFormatProvider? provider, Span<TChar> destination, out int charsWritten) where TChar : unmanaged, IEquatable<TChar> {
            // Fast path for default format
            if (format.Length == 0) {
                return value >= 0 ?
                    TryUInt32ToDecStr((uint)value, destination, out charsWritten) :
                    TryNegativeInt32ToDecStr(value, digits: -1, NumberFormatInfo.GetInstance(provider).NegativeSignTChar<TChar>(), destination, out charsWritten);
            }

            return TryFormatInt32Slow(value, hexMask, format, provider, destination, out charsWritten);

            static bool TryFormatInt32Slow(int value, int hexMask, ReadOnlySpan<char> format, IFormatProvider? provider, Span<TChar> destination, out int charsWritten) {
                char fmt = ParseFormatSpecifier(format, out int digits);
                char fmtUpper = (char)(fmt & 0xFFDF); // ensure fmt is upper-cased for purposes of comparison
                if (fmtUpper == 'G' ? digits < 1 : fmtUpper == 'D') {
                    return value >= 0 ?
                        TryUInt32ToDecStr((uint)value, digits, destination, out charsWritten) :
                        TryNegativeInt32ToDecStr(value, digits, NumberFormatInfo.GetInstance(provider).NegativeSignTChar<TChar>(), destination, out charsWritten);
                } else if (fmtUpper == 'X') {
                    return TryInt32ToHexStr(value & hexMask, GetHexBase(fmt), digits, destination, out charsWritten);
                } else if (fmtUpper == 'B') {
                    return TryUInt32ToBinaryStr((uint)(value & hexMask), digits, destination, out charsWritten);
                } else {
                    NumberFormatInfo info = NumberFormatInfo.GetInstance(provider);

                    Span<byte> pDigits = stackalloc byte[Int32NumberBufferLength];
                    NumberBuffer number = new NumberBuffer(NumberBufferKind.Integer, pDigits);

                    Int32ToNumber(value, ref number);

                    Span<TChar> stackPtr = stackalloc TChar[CharStackBufferSize];
                    var vlb = new ValueListBuilder<TChar>(stackPtr);

                    if (fmt != 0) {
                        NumberToString(ref vlb, ref number, fmt, digits, info);
                    } else {
                        NumberToStringFormat(ref vlb, ref number, format, info);
                    }

                    bool success = vlb.TryCopyTo(destination, out charsWritten);
                    vlb.Dispose();
                    return success;
                }
            }
        }

        public static string FormatUInt32(uint value, string? format, IFormatProvider? provider) {
            // Fast path for default format
            if (string.IsNullOrEmpty(format)) {
                return UInt32ToDecStr(value);
            }

            return FormatUInt32Slow(value, format, provider);

            static string FormatUInt32Slow(uint value, string? format, IFormatProvider? provider) {
                ReadOnlySpan<char> formatSpan = format.AsSpan();
                char fmt = ParseFormatSpecifier(formatSpan, out int digits);
                char fmtUpper = (char)(fmt & 0xFFDF); // ensure fmt is upper-cased for purposes of comparison
                if (fmtUpper == 'G' ? digits < 1 : fmtUpper == 'D') {
                    return UInt32ToDecStr(value, digits);
                } else if (fmtUpper == 'X') {
                    return Int32ToHexStr((int)value, GetHexBase(fmt), digits);
                } else if (fmtUpper == 'B') {
                    return UInt32ToBinaryStr(value, digits);
                } else {
                    NumberFormatInfo info = NumberFormatInfo.GetInstance(provider);

                    Span<byte> pDigits = stackalloc byte[UInt32NumberBufferLength];
                    NumberBuffer number = new NumberBuffer(NumberBufferKind.Integer, pDigits);

                    UInt32ToNumber(value, ref number);

                    Span<char> stackPtr = stackalloc char[CharStackBufferSize];
                    var vlb = new ValueListBuilder<char>(stackPtr);

                    if (fmt != 0) {
                        NumberToString(ref vlb, ref number, fmt, digits, info);
                    } else {
                        NumberToStringFormat(ref vlb, ref number, formatSpan, info);
                    }

                    string result = vlb.AsSpan().ToString();
                    vlb.Dispose();
                    return result;
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] // expose to caller's likely-const format to trim away slow path
        public static bool TryFormatUInt32<TChar>(uint value, ReadOnlySpan<char> format, IFormatProvider? provider, Span<TChar> destination, out int charsWritten) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));

            // Fast path for default format
            if (format.Length == 0) {
                return TryUInt32ToDecStr(value, destination, out charsWritten);
            }

            return TryFormatUInt32Slow(value, format, provider, destination, out charsWritten);

            static bool TryFormatUInt32Slow(uint value, ReadOnlySpan<char> format, IFormatProvider? provider, Span<TChar> destination, out int charsWritten) {
                char fmt = ParseFormatSpecifier(format, out int digits);
                char fmtUpper = (char)(fmt & 0xFFDF); // ensure fmt is upper-cased for purposes of comparison
                if (fmtUpper == 'G' ? digits < 1 : fmtUpper == 'D') {
                    return TryUInt32ToDecStr(value, digits, destination, out charsWritten);
                } else if (fmtUpper == 'X') {
                    return TryInt32ToHexStr((int)value, GetHexBase(fmt), digits, destination, out charsWritten);
                } else if (fmtUpper == 'B') {
                    return TryUInt32ToBinaryStr(value, digits, destination, out charsWritten);
                } else {
                    NumberFormatInfo info = NumberFormatInfo.GetInstance(provider);

                    Span<byte> pDigits = stackalloc byte[UInt32NumberBufferLength];
                    NumberBuffer number = new NumberBuffer(NumberBufferKind.Integer, pDigits);

                    UInt32ToNumber(value, ref number);

                    Span<TChar> stackPtr = stackalloc TChar[CharStackBufferSize];
                    var vlb = new ValueListBuilder<TChar>(stackPtr);

                    if (fmt != 0) {
                        NumberToString(ref vlb, ref number, fmt, digits, info);
                    } else {
                        NumberToStringFormat(ref vlb, ref number, format, info);
                    }

                    bool success = vlb.TryCopyTo(destination, out charsWritten);
                    vlb.Dispose();
                    return success;
                }
            }
        }

        public static string FormatInt64(long value, string? format, IFormatProvider? provider) {
            // Fast path for default format
            if (string.IsNullOrEmpty(format)) {
                return value >= 0 ?
                    UInt64ToDecStr((ulong)value) :
                    NegativeInt64ToDecStr(value, digits: -1, NumberFormatInfo.GetInstance(provider).NegativeSign);
            }

            return FormatInt64Slow(value, format, provider);

            static string FormatInt64Slow(long value, string? format, IFormatProvider? provider) {
                ReadOnlySpan<char> formatSpan = format.AsSpan();
                char fmt = ParseFormatSpecifier(formatSpan, out int digits);
                char fmtUpper = (char)(fmt & 0xFFDF); // ensure fmt is upper-cased for purposes of comparison
                if (fmtUpper == 'G' ? digits < 1 : fmtUpper == 'D') {
                    return value >= 0 ?
                        UInt64ToDecStr((ulong)value, digits) :
                        NegativeInt64ToDecStr(value, digits, NumberFormatInfo.GetInstance(provider).NegativeSign);
                } else if (fmtUpper == 'X') {
                    return Int64ToHexStr(value, GetHexBase(fmt), digits);
                } else if (fmtUpper == 'B') {
                    return UInt64ToBinaryStr((ulong)value, digits);
                } else {
                    NumberFormatInfo info = NumberFormatInfo.GetInstance(provider);

                    Span<byte> pDigits = stackalloc byte[Int64NumberBufferLength];
                    NumberBuffer number = new NumberBuffer(NumberBufferKind.Integer, pDigits);

                    Int64ToNumber(value, ref number);

                    Span<char> stackPtr = stackalloc char[CharStackBufferSize];
                    var vlb = new ValueListBuilder<char>(stackPtr);

                    if (fmt != 0) {
                        NumberToString(ref vlb, ref number, fmt, digits, info);
                    } else {
                        NumberToStringFormat(ref vlb, ref number, formatSpan, info);
                    }

                    string result = vlb.AsSpan().ToString();
                    vlb.Dispose();
                    return result;
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] // expose to caller's likely-const format to trim away slow path
        public static bool TryFormatInt64<TChar>(long value, ReadOnlySpan<char> format, IFormatProvider? provider, Span<TChar> destination, out int charsWritten) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));

            // Fast path for default format
            if (format.Length == 0) {
                return value >= 0 ?
                    TryUInt64ToDecStr((ulong)value, destination, out charsWritten) :
                    TryNegativeInt64ToDecStr(value, digits: -1, NumberFormatInfo.GetInstance(provider).NegativeSignTChar<TChar>(), destination, out charsWritten);
            }

            return TryFormatInt64Slow(value, format, provider, destination, out charsWritten);

            static bool TryFormatInt64Slow(long value, ReadOnlySpan<char> format, IFormatProvider? provider, Span<TChar> destination, out int charsWritten) {
                char fmt = ParseFormatSpecifier(format, out int digits);
                char fmtUpper = (char)(fmt & 0xFFDF); // ensure fmt is upper-cased for purposes of comparison
                if (fmtUpper == 'G' ? digits < 1 : fmtUpper == 'D') {
                    return value >= 0 ?
                        TryUInt64ToDecStr((ulong)value, digits, destination, out charsWritten) :
                        TryNegativeInt64ToDecStr(value, digits, NumberFormatInfo.GetInstance(provider).NegativeSignTChar<TChar>(), destination, out charsWritten);
                } else if (fmtUpper == 'X') {
                    return TryInt64ToHexStr(value, GetHexBase(fmt), digits, destination, out charsWritten);
                } else if (fmtUpper == 'B') {
                    return TryUInt64ToBinaryStr((ulong)value, digits, destination, out charsWritten);
                } else {
                    NumberFormatInfo info = NumberFormatInfo.GetInstance(provider);

                    Span<byte> pDigits = stackalloc byte[Int64NumberBufferLength];
                    NumberBuffer number = new NumberBuffer(NumberBufferKind.Integer, pDigits);

                    Int64ToNumber(value, ref number);

                    Span<TChar> stackPtr = stackalloc TChar[CharStackBufferSize];
                    var vlb = new ValueListBuilder<TChar>(stackPtr);

                    if (fmt != 0) {
                        NumberToString(ref vlb, ref number, fmt, digits, info);
                    } else {
                        NumberToStringFormat(ref vlb, ref number, format, info);
                    }

                    bool success = vlb.TryCopyTo(destination, out charsWritten);
                    vlb.Dispose();
                    return success;
                }
            }
        }

        public static string FormatUInt64(ulong value, string? format, IFormatProvider? provider) {
            // Fast path for default format
            if (string.IsNullOrEmpty(format)) {
                return UInt64ToDecStr(value);
            }

            return FormatUInt64Slow(value, format, provider);

            static string FormatUInt64Slow(ulong value, string? format, IFormatProvider? provider) {
                ReadOnlySpan<char> formatSpan = format.AsSpan();
                char fmt = ParseFormatSpecifier(formatSpan, out int digits);
                char fmtUpper = (char)(fmt & 0xFFDF); // ensure fmt is upper-cased for purposes of comparison
                if (fmtUpper == 'G' ? digits < 1 : fmtUpper == 'D') {
                    return UInt64ToDecStr(value, digits);
                } else if (fmtUpper == 'X') {
                    return Int64ToHexStr((long)value, GetHexBase(fmt), digits);
                } else if (fmtUpper == 'B') {
                    return UInt64ToBinaryStr(value, digits);
                } else {
                    NumberFormatInfo info = NumberFormatInfo.GetInstance(provider);

                    Span<byte> pDigits = stackalloc byte[UInt64NumberBufferLength];
                    NumberBuffer number = new NumberBuffer(NumberBufferKind.Integer, pDigits);

                    UInt64ToNumber(value, ref number);

                    Span<char> stackPtr = stackalloc char[CharStackBufferSize];
                    var vlb = new ValueListBuilder<char>(stackPtr);

                    if (fmt != 0) {
                        NumberToString(ref vlb, ref number, fmt, digits, info);
                    } else {
                        NumberToStringFormat(ref vlb, ref number, formatSpan, info);
                    }

                    string result = vlb.AsSpan().ToString();
                    vlb.Dispose();
                    return result;
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] // expose to caller's likely-const format to trim away slow path
        public static bool TryFormatUInt64<TChar>(ulong value, ReadOnlySpan<char> format, IFormatProvider? provider, Span<TChar> destination, out int charsWritten) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));

            // Fast path for default format
            if (format.Length == 0) {
                return TryUInt64ToDecStr(value, destination, out charsWritten);
            }

            return TryFormatUInt64Slow(value, format, provider, destination, out charsWritten);

            static bool TryFormatUInt64Slow(ulong value, ReadOnlySpan<char> format, IFormatProvider? provider, Span<TChar> destination, out int charsWritten) {
                char fmt = ParseFormatSpecifier(format, out int digits);
                char fmtUpper = (char)(fmt & 0xFFDF); // ensure fmt is upper-cased for purposes of comparison
                if (fmtUpper == 'G' ? digits < 1 : fmtUpper == 'D') {
                    return TryUInt64ToDecStr(value, digits, destination, out charsWritten);
                } else if (fmtUpper == 'X') {
                    return TryInt64ToHexStr((long)value, GetHexBase(fmt), digits, destination, out charsWritten);
                } else if (fmtUpper == 'B') {
                    return TryUInt64ToBinaryStr(value, digits, destination, out charsWritten);
                } else {
                    NumberFormatInfo info = NumberFormatInfo.GetInstance(provider);

                    Span<byte> pDigits = stackalloc byte[UInt64NumberBufferLength];
                    NumberBuffer number = new NumberBuffer(NumberBufferKind.Integer, pDigits);

                    UInt64ToNumber(value, ref number);

                    Span<TChar> stackPtr = stackalloc TChar[CharStackBufferSize];
                    var vlb = new ValueListBuilder<TChar>(stackPtr);

                    if (fmt != 0) {
                        NumberToString(ref vlb, ref number, fmt, digits, info);
                    } else {
                        NumberToStringFormat(ref vlb, ref number, format, info);
                    }

                    bool success = vlb.TryCopyTo(destination, out charsWritten);
                    vlb.Dispose();
                    return success;
                }
            }
        }

        public static string FormatExInt128(ExInt128 value, string? format, IFormatProvider? provider) {
            // Fast path for default format
            if (string.IsNullOrEmpty(format)) {
                return ExInt128.IsPositive(value)
                     ? ExUInt128ToDecStr((ExUInt128)value, digits: -1)
                     : NegativeExInt128ToDecStr(value, digits: -1, NumberFormatInfo.GetInstance(provider).NegativeSign);
            }

            return FormatExInt128Slow(value, format, provider);

            static string FormatExInt128Slow(ExInt128 value, string? format, IFormatProvider? provider) {
                ReadOnlySpan<char> formatSpan = format.AsSpan();

                char fmt = ParseFormatSpecifier(formatSpan, out int digits);
                char fmtUpper = (char)(fmt & 0xFFDF); // ensure fmt is upper-cased for purposes of comparison

                if (fmtUpper == 'G' ? digits < 1 : fmtUpper == 'D') {
                    return ExInt128.IsPositive(value)
                        ? ExUInt128ToDecStr((ExUInt128)value, digits)
                        : NegativeExInt128ToDecStr(value, digits, NumberFormatInfo.GetInstance(provider).NegativeSign);
                } else if (fmtUpper == 'X') {
                    return ExInt128ToHexStr(value, GetHexBase(fmt), digits);
                } else if (fmtUpper == 'B') {
                    return ExUInt128ToBinaryStr(value, digits);
                } else {
                    NumberFormatInfo info = NumberFormatInfo.GetInstance(provider);

                    Span<byte> pDigits = stackalloc byte[ExInt128NumberBufferLength];
                    NumberBuffer number = new NumberBuffer(NumberBufferKind.Integer, pDigits);

                    ExInt128ToNumber(value, ref number);

                    Span<char> stackPtr = stackalloc char[CharStackBufferSize];
                    var vlb = new ValueListBuilder<char>(stackPtr);

                    if (fmt != 0) {
                        NumberToString(ref vlb, ref number, fmt, digits, info);
                    } else {
                        NumberToStringFormat(ref vlb, ref number, formatSpan, info);
                    }

                    string result = vlb.AsSpan().ToString();
                    vlb.Dispose();
                    return result;
                }
            }
        }

        public static bool TryFormatExInt128<TChar>(ExInt128 value, ReadOnlySpan<char> format, IFormatProvider? provider, Span<TChar> destination, out int charsWritten) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));

            // Fast path for default format
            if (format.Length == 0) {
                return ExInt128.IsPositive(value)
                     ? TryExUInt128ToDecStr((ExUInt128)value, digits: -1, destination, out charsWritten)
                     : TryNegativeExInt128ToDecStr(value, digits: -1, NumberFormatInfo.GetInstance(provider).NegativeSignTChar<TChar>(), destination, out charsWritten);
            }

            return TryFormatExInt128Slow(value, format, provider, destination, out charsWritten);

            static bool TryFormatExInt128Slow(ExInt128 value, ReadOnlySpan<char> format, IFormatProvider? provider, Span<TChar> destination, out int charsWritten) {
                char fmt = ParseFormatSpecifier(format, out int digits);
                char fmtUpper = (char)(fmt & 0xFFDF); // ensure fmt is upper-cased for purposes of comparison

                if (fmtUpper == 'G' ? digits < 1 : fmtUpper == 'D') {
                    return ExInt128.IsPositive(value)
                        ? TryExUInt128ToDecStr((ExUInt128)value, digits, destination, out charsWritten)
                        : TryNegativeExInt128ToDecStr(value, digits, NumberFormatInfo.GetInstance(provider).NegativeSignTChar<TChar>(), destination, out charsWritten);
                } else if (fmtUpper == 'X') {
                    return TryExInt128ToHexStr(value, GetHexBase(fmt), digits, destination, out charsWritten);
                } else if (fmtUpper == 'B') {
                    return TryExUInt128ToBinaryStr(value, digits, destination, out charsWritten);
                } else {
                    NumberFormatInfo info = NumberFormatInfo.GetInstance(provider);

                    Span<byte> pDigits = stackalloc byte[ExInt128NumberBufferLength];
                    NumberBuffer number = new NumberBuffer(NumberBufferKind.Integer, pDigits);

                    ExInt128ToNumber(value, ref number);

                    Span<TChar> stackPtr = stackalloc TChar[CharStackBufferSize];
                    var vlb = new ValueListBuilder<TChar>(stackPtr);

                    if (fmt != 0) {
                        NumberToString(ref vlb, ref number, fmt, digits, info);
                    } else {
                        NumberToStringFormat(ref vlb, ref number, format, info);
                    }

                    bool success = vlb.TryCopyTo(destination, out charsWritten);
                    vlb.Dispose();
                    return success;
                }
            }
        }

        public static string FormatExUInt128(ExUInt128 value, string? format, IFormatProvider? provider) {
            // Fast path for default format
            if (string.IsNullOrEmpty(format)) {
                return ExUInt128ToDecStr(value, digits: -1);
            }

            return FormatExUInt128Slow(value, format, provider);

            static string FormatExUInt128Slow(ExUInt128 value, string? format, IFormatProvider? provider) {
                ReadOnlySpan<char> formatSpan = format.AsSpan();

                char fmt = ParseFormatSpecifier(formatSpan, out int digits);
                char fmtUpper = (char)(fmt & 0xFFDF); // ensure fmt is upper-cased for purposes of comparison

                if (fmtUpper == 'G' ? digits < 1 : fmtUpper == 'D') {
                    return ExUInt128ToDecStr(value, digits);
                } else if (fmtUpper == 'X') {
                    return ExInt128ToHexStr((ExInt128)value, GetHexBase(fmt), digits);
                } else if (fmtUpper == 'B') {
                    return ExUInt128ToBinaryStr((ExInt128)value, digits);
                } else {
                    NumberFormatInfo info = NumberFormatInfo.GetInstance(provider);

                    Span<byte> pDigits = stackalloc byte[ExUInt128NumberBufferLength];
                    NumberBuffer number = new NumberBuffer(NumberBufferKind.Integer, pDigits);

                    ExUInt128ToNumber(value, ref number);

                    Span<char> stackPtr = stackalloc char[CharStackBufferSize];
                    var vlb = new ValueListBuilder<char>(stackPtr);

                    if (fmt != 0) {
                        NumberToString(ref vlb, ref number, fmt, digits, info);
                    } else {
                        NumberToStringFormat(ref vlb, ref number, formatSpan, info);
                    }

                    string result = vlb.AsSpan().ToString();
                    vlb.Dispose();
                    return result;
                }
            }
        }

        public static bool TryFormatExUInt128<TChar>(ExUInt128 value, ReadOnlySpan<char> format, IFormatProvider? provider, Span<TChar> destination, out int charsWritten) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));

            // Fast path for default format
            if (format.Length == 0) {
                return TryExUInt128ToDecStr(value, digits: -1, destination, out charsWritten);
            }

            return TryFormatExUInt128Slow(value, format, provider, destination, out charsWritten);

            static bool TryFormatExUInt128Slow(ExUInt128 value, ReadOnlySpan<char> format, IFormatProvider? provider, Span<TChar> destination, out int charsWritten) {
                char fmt = ParseFormatSpecifier(format, out int digits);
                char fmtUpper = (char)(fmt & 0xFFDF); // ensure fmt is upper-cased for purposes of comparison

                if (fmtUpper == 'G' ? digits < 1 : fmtUpper == 'D') {
                    return TryExUInt128ToDecStr(value, digits, destination, out charsWritten);
                } else if (fmtUpper == 'X') {
                    return TryExInt128ToHexStr((ExInt128)value, GetHexBase(fmt), digits, destination, out charsWritten);
                } else if (fmtUpper == 'B') {
                    return TryExUInt128ToBinaryStr((ExInt128)value, digits, destination, out charsWritten);
                } else {
                    NumberFormatInfo info = NumberFormatInfo.GetInstance(provider);

                    Span<byte> pDigits = stackalloc byte[ExUInt128NumberBufferLength];
                    NumberBuffer number = new NumberBuffer(NumberBufferKind.Integer, pDigits);

                    ExUInt128ToNumber(value, ref number);

                    Span<TChar>  stackPtr = stackalloc TChar[CharStackBufferSize];
                    var vlb = new ValueListBuilder<TChar>(stackPtr);

                    if (fmt != 0) {
                        NumberToString(ref vlb, ref number, fmt, digits, info);
                    } else {
                        NumberToStringFormat(ref vlb, ref number, format, info);
                    }

                    bool success = vlb.TryCopyTo(destination, out charsWritten);
                    vlb.Dispose();
                    return success;
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void Int32ToNumber(int value, ref NumberBuffer number) {
            number.DigitsCount = Int32Precision;

            if (value >= 0) {
                number.IsNegative = false;
            } else {
                number.IsNegative = true;
                value = -value;
            }

            ref byte buffer = ref number.DigitsPtr;
            ref byte p = ref UInt32ToDecChars(ref Unsafe.Add(ref buffer, Int32Precision), (uint)value, 0);

            int i = (int)(buffer + Int32Precision - p);

            number.DigitsCount = i;
            number.Scale = i;

            ref byte dst = ref number.DigitsPtr;
            while (--i >= 0) {
                //*dst++ = *p++;
                dst = p;
                dst = ref Unsafe.Add(ref dst, 1);
                p = ref Unsafe.Add(ref p, 1);
            }
            dst = (byte)'\0';

            number.CheckConsistency();
        }

        public static string Int32ToDecStr(int value) =>
            value >= 0 ?
                UInt32ToDecStr((uint)value) :
                NegativeInt32ToDecStr(value, -1, NumberFormatInfo.CurrentInfo.NegativeSign);

        private static string NegativeInt32ToDecStr(int value, int digits, string sNegative) {
            Debug.Assert(value < 0);

            if (digits < 1) {
                digits = 1;
            }

            int bufferLength = Math.Max(digits, FormattingHelpers.CountDigits((uint)(-value))) + sNegative.Length;
            Span<char> result = stackalloc char[bufferLength];
            if (true) {
                ref char buffer = ref result[0];
                ref char p = ref UInt32ToDecChars(ref Unsafe.Add(ref buffer, bufferLength), (uint)(-value), digits);
                Debug.Assert(p == buffer + sNegative.Length);

                for (int i = sNegative.Length - 1; i >= 0; i--) {
                    p = ref Unsafe.Subtract(ref p, 1);
                    p = sNegative[i];
                }
                Debug.Assert(Unsafe.AreSame(ref p, ref buffer));
            }
            return result.ToString();
        }

        internal static bool TryNegativeInt32ToDecStr<TChar>(int value, int digits, ReadOnlySpan<TChar> sNegative, Span<TChar> destination, out int charsWritten) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));
            Debug.Assert(value < 0);

            if (digits < 1) {
                digits = 1;
            }

            int bufferLength = Math.Max(digits, FormattingHelpers.CountDigits((uint)(-value))) + sNegative.Length;
            if (bufferLength > destination.Length) {
                charsWritten = 0;
                return false;
            }

            charsWritten = bufferLength;
            if (true) {
                ref TChar buffer = ref MemoryMarshal.GetReference(destination);
                ref TChar p = ref UInt32ToDecChars(ref Unsafe.Add(ref buffer, bufferLength), (uint)(-value), digits);
                Debug.Assert(Unsafe.AreSame(ref p, ref Unsafe.Add(ref buffer, sNegative.Length)));

                for (int i = sNegative.Length - 1; i >= 0; i--) {
                    p = ref Unsafe.Subtract(ref p, 1);
                    p = sNegative[i];
                }
                Debug.Assert(Unsafe.AreSame(ref p, ref buffer));
            }
            return true;
        }

        private static string Int32ToHexStr(int value, char hexBase, int digits) {
            if (digits < 1) {
                digits = 1;
            }

            int bufferLength = Math.Max(digits, FormattingHelpers.CountHexDigits((uint)value));
            Span<char> result = stackalloc char[bufferLength];
            if (true) {
                ref char buffer = ref result[0];
                ref char p = ref Int32ToHexChars(ref Unsafe.Add(ref buffer, bufferLength), (uint)value, hexBase, digits);
                Debug.Assert(Unsafe.AreSame(ref p, ref buffer));
            }
            return result.ToString();
        }

        internal static bool TryInt32ToHexStr<TChar>(int value, char hexBase, int digits, Span<TChar> destination, out int charsWritten) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));

            if (digits < 1) {
                digits = 1;
            }

            int bufferLength = Math.Max(digits, FormattingHelpers.CountHexDigits((uint)value));
            if (bufferLength > destination.Length) {
                charsWritten = 0;
                return false;
            }

            charsWritten = bufferLength;
            if (true) {
                ref TChar buffer = ref MemoryMarshal.GetReference(destination);
                ref TChar p = ref Int32ToHexChars(ref Unsafe.Add(ref buffer, bufferLength), (uint)value, hexBase, digits);
                Debug.Assert(Unsafe.AreSame(ref p, ref buffer));
            }
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static ref TChar Int32ToHexChars<TChar>(ref TChar buffer, uint value, int hexBase, int digits) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));

            while (--digits >= 0 || value != 0) {
                byte digit = (byte)(value & 0xF);
                buffer = ref Unsafe.Subtract(ref buffer, 1);
                buffer = CastFrom<TChar>((byte)(digit + (digit < 10 ? (byte)'0' : hexBase)));
                value >>= 4;
            }
            return ref buffer;
        }

        private static string UInt32ToBinaryStr(uint value, int digits) {
            if (digits < 1) {
                digits = 1;
            }

            int bufferLength = Math.Max(digits, 32 - (int)MathBitOperations.LeadingZeroCount(value));
            Span<char> result = stackalloc char[bufferLength];
            if (true) {
                ref char buffer = ref result[0];
                ref char p = ref UInt32ToBinaryChars(ref Unsafe.Add(ref buffer, bufferLength), value, digits);
                Debug.Assert(Unsafe.AreSame(ref p, ref buffer));
            }
            return result.ToString();
        }

        private static bool TryUInt32ToBinaryStr<TChar>(uint value, int digits, Span<TChar> destination, out int charsWritten) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));

            if (digits < 1) {
                digits = 1;
            }

            int bufferLength = Math.Max(digits, 32 - (int)MathBitOperations.LeadingZeroCount(value));
            if (bufferLength > destination.Length) {
                charsWritten = 0;
                return false;
            }

            charsWritten = bufferLength;
            if (true) {
                ref TChar buffer = ref MemoryMarshal.GetReference(destination);
                ref TChar p = ref UInt32ToBinaryChars(ref Unsafe.Add(ref buffer, bufferLength), value, digits);
                Debug.Assert(Unsafe.AreSame(ref p, ref buffer));
            }
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static ref TChar UInt32ToBinaryChars<TChar>(ref TChar buffer, uint value, int digits) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));

            while (--digits >= 0 || value != 0) {
                buffer = ref Unsafe.Subtract(ref buffer, 1);
                buffer = CastFrom<TChar>((byte)'0' + (byte)(value & 0x1));
                value >>= 1;
            }
            return ref buffer;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void UInt32ToNumber(uint value, ref NumberBuffer number) {
            number.DigitsCount = UInt32Precision;
            number.IsNegative = false;

            ref byte buffer = ref number.DigitsPtr;
            ref byte p = ref UInt32ToDecChars(ref Unsafe.Add(ref buffer, UInt32Precision), value, 0);

            int i = (int)(buffer + UInt32Precision - p);

            number.DigitsCount = i;
            number.Scale = i;

            ref byte dst = ref number.DigitsPtr;
            while (--i >= 0) {
                //*dst++ = *p++;
                dst = p;
                dst = ref Unsafe.Add(ref dst, 1);
                p = ref Unsafe.Add(ref p, 1);
            }
            dst = (byte)'\0';

            number.CheckConsistency();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void WriteTwoDigits<TChar>(uint value, ref TChar ptr) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));
            Debug.Assert(value <= 99);

            Unsafe.CopyBlockUnaligned(
                ref Unsafe.As<TChar, byte>(ref ptr),
                ref Unsafe.Add(ref UnsafeUtil.GetArrayDataReference(typeof(TChar) == typeof(char) ? TwoDigitsCharsAsBytes : TwoDigitsBytes), (nint)(Unsafe.SizeOf<TChar>() * 2 * value)),
                (uint)Unsafe.SizeOf<TChar>() * 2);
        }

        /// <summary>
        /// Writes a value [ 0000 .. 9999 ] to the buffer starting at the specified offset.
        /// This method performs best when the starting index is a constant literal.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void WriteFourDigits<TChar>(uint value, ref TChar ptr) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));
            Debug.Assert(value <= 9999);

            (value, uint remainder) = BitMath.DivRem(value, 100);

            ref byte charsArray = ref UnsafeUtil.GetArrayDataReference(typeof(TChar) == typeof(char) ? TwoDigitsCharsAsBytes : TwoDigitsBytes);

            Unsafe.CopyBlockUnaligned(
                ref Unsafe.As<TChar, byte>(ref ptr),
                ref Unsafe.Add(ref charsArray, (nint)(Unsafe.SizeOf<TChar>() * 2 * value)),
                (uint)Unsafe.SizeOf<TChar>() * 2);

            Unsafe.CopyBlockUnaligned(
                ref Unsafe.As<TChar, byte>(ref Unsafe.Add(ref ptr, 2)),
                ref Unsafe.Add(ref charsArray, (nint)(Unsafe.SizeOf<TChar>() * 2 * remainder)),
                (uint)Unsafe.SizeOf<TChar>() * 2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void WriteDigits<TChar>(uint value, ref TChar ptr, int count) where TChar : unmanaged, IEquatable<TChar> {
            ref TChar cur = ref Unsafe.Add(ref ptr, count - 1);
            for (; Unsafe.IsAddressGreaterThan(ref cur, ref ptr); cur = ref Unsafe.Subtract(ref cur, 1)) {
                uint temp = '0' + value;
                value /= 10;
                cur = CastFrom<TChar>(temp - (value * 10));
            }

            Debug.Assert(value < 10);
            Debug.Assert(Unsafe.AreSame(ref cur, ref ptr));
            cur = CastFrom<TChar>('0' + value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ref TChar UInt32ToDecChars<TChar>(ref TChar bufferEnd, uint value) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));

            if (value >= 10) {
                // Handle all values >= 100 two-digits at a time so as to avoid expensive integer division operations.
                while (value >= 100) {
                    bufferEnd = ref Unsafe.Add(ref bufferEnd, -2);
                    (value, uint remainder) = BitMath.DivRem(value, 100);
                    WriteTwoDigits(remainder, ref bufferEnd);
                }

                // If there are two digits remaining, store them.
                if (value >= 10) {
                    bufferEnd = ref Unsafe.Add(ref bufferEnd, -2);
                    WriteTwoDigits(value, ref bufferEnd);
                    return ref bufferEnd;
                }
            }

            // Otherwise, store the single digit remaining.
            bufferEnd = ref Unsafe.Add(ref bufferEnd, -1);
            bufferEnd = CastFrom<TChar>(value + '0');
            return ref bufferEnd;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ref TChar UInt32ToDecChars<TChar>(ref TChar bufferEnd, uint value, int digits) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));

            uint remainder;
            while (value >= 100) {
                bufferEnd = ref Unsafe.Add(ref bufferEnd, -2);
                digits -= 2;
                (value, remainder) = BitMath.DivRem(value, 100);
                WriteTwoDigits(remainder, ref bufferEnd);
            }

            while (value != 0 || digits > 0) {
                digits--;
                (value, remainder) = BitMath.DivRem(value, 10);
                bufferEnd = ref Unsafe.Add(ref bufferEnd, -1);
                bufferEnd = CastFrom<TChar>(remainder + '0');
            }

            return ref bufferEnd;
        }

        internal static string UInt32ToDecStr(uint value) {
            // For small numbers, consult a lazily-populated cache.
            if (value < SmallNumberCacheLength) {
                return UInt32ToDecStrForKnownSmallNumber(value);
            }

            return UInt32ToDecStr_NoSmallNumberCheck(value);
        }

        internal static string UInt32ToDecStrForKnownSmallNumber(uint value) {
            Debug.Assert(value < SmallNumberCacheLength);
            return s_smallNumberCache[value] ?? CreateAndCacheString(value);

            [MethodImpl(MethodImplOptions.NoInlining)] // keep rare usage out of fast path
            static string CreateAndCacheString(uint value) =>
                s_smallNumberCache[value] = UInt32ToDecStr_NoSmallNumberCheck(value);
        }

        private static string UInt32ToDecStr_NoSmallNumberCheck(uint value) {
            int bufferLength = FormattingHelpers.CountDigits(value);

            Span<char> result = stackalloc char[bufferLength];
            ref char buffer = ref result[0];
            if (true) {
                ref char p = ref Unsafe.Add(ref buffer, bufferLength);
                p = UInt32ToDecChars(ref p, value);
                Debug.Assert(Unsafe.AreSame(ref p, ref buffer));
            }
            return result.ToString();
        }

        private static string UInt32ToDecStr(uint value, int digits) {
            if (digits <= 1)
                return UInt32ToDecStr(value);

            int bufferLength = Math.Max(digits, FormattingHelpers.CountDigits(value));
            Span<char> result = stackalloc char[bufferLength];
            ref char buffer = ref result[0];
            if (true) {
                ref char p = ref Unsafe.Add(ref buffer, bufferLength);
                p = UInt32ToDecChars(ref p, value, digits);
                Debug.Assert(Unsafe.AreSame(ref p, ref buffer));
            }
            return result.ToString();
        }

        internal static bool TryUInt32ToDecStr<TChar>(uint value, Span<TChar> destination, out int charsWritten) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));

            int bufferLength = FormattingHelpers.CountDigits(value);
            if (bufferLength <= destination.Length) {
                charsWritten = bufferLength;
                if (true) {
                    ref TChar buffer = ref MemoryMarshal.GetReference(destination);
                    ref TChar p = ref UInt32ToDecChars(ref Unsafe.Add(ref buffer, bufferLength), value);
                    Debug.Assert(Unsafe.AreSame(ref p, ref buffer));
                }
                return true;
            }

            charsWritten = 0;
            return false;
        }

        internal static bool TryUInt32ToDecStr<TChar>(uint value, int digits, Span<TChar> destination, out int charsWritten) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));

            int countedDigits = FormattingHelpers.CountDigits(value);
            int bufferLength = Math.Max(digits, countedDigits);
            if (bufferLength <= destination.Length) {
                charsWritten = bufferLength;
                if (true) {
                    ref TChar buffer = ref MemoryMarshal.GetReference(destination);
                    ref TChar p = ref Unsafe.Add(ref buffer, bufferLength);
                    p = digits > countedDigits ?
                        UInt32ToDecChars(ref p, value, digits) :
                        UInt32ToDecChars(ref p, value);
                    Debug.Assert(Unsafe.AreSame(ref p, ref buffer));
                }
                return true;
            }

            charsWritten = 0;
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void Int64ToNumber(long value, ref NumberBuffer number) {
            number.DigitsCount = Int64Precision;

            if (value >= 0) {
                number.IsNegative = false;
            } else {
                number.IsNegative = true;
                value = -value;
            }

            ref byte buffer = ref number.DigitsPtr;
            ref byte p = ref UInt64ToDecChars(ref Unsafe.Add(ref buffer, Int64Precision), (ulong)value, 0);

            int i = (int)(buffer + Int64Precision - p);

            number.DigitsCount = i;
            number.Scale = i;

            ref byte dst = ref number.DigitsPtr;
            while (--i >= 0) {
                //*dst++ = *p++;
                dst = p;
                dst = ref Unsafe.Add(ref dst, 1);
                p = ref Unsafe.Add(ref p, 1);
            }
            dst = (byte)'\0';

            number.CheckConsistency();
        }

        public static string Int64ToDecStr(long value) {
            return value >= 0 ?
                UInt64ToDecStr((ulong)value) :
                NegativeInt64ToDecStr(value, -1, NumberFormatInfo.CurrentInfo.NegativeSign);
        }

        private static string NegativeInt64ToDecStr(long value, int digits, string sNegative) {
            Debug.Assert(value < 0);

            if (digits < 1) {
                digits = 1;
            }

            int bufferLength = Math.Max(digits, FormattingHelpers.CountDigits((ulong)(-value))) + sNegative.Length;
            Span<char> result = stackalloc char[bufferLength];
            if (true) {
                ref char buffer = ref result[0];
                ref char p = ref UInt64ToDecChars(ref Unsafe.Add(ref buffer, bufferLength), (ulong)(-value), digits);
                Debug.Assert(p == buffer + sNegative.Length);

                for (int i = sNegative.Length - 1; i >= 0; i--) {
                    p = ref Unsafe.Subtract(ref p, 1);
                    p = sNegative[i];
                }
                Debug.Assert(Unsafe.AreSame(ref p, ref buffer));
            }
            return result.ToString();
        }

        internal static bool TryNegativeInt64ToDecStr<TChar>(long value, int digits, ReadOnlySpan<TChar> sNegative, Span<TChar> destination, out int charsWritten) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));
            Debug.Assert(value < 0);

            if (digits < 1) {
                digits = 1;
            }

            int bufferLength = Math.Max(digits, FormattingHelpers.CountDigits((ulong)(-value))) + sNegative.Length;
            if (bufferLength > destination.Length) {
                charsWritten = 0;
                return false;
            }

            charsWritten = bufferLength;
            if (true) {
                ref TChar buffer = ref MemoryMarshal.GetReference(destination);
                ref TChar p = ref UInt64ToDecChars(ref Unsafe.Add(ref buffer, bufferLength), (ulong)(-value), digits);
                Debug.Assert(Unsafe.AreSame(ref p, ref Unsafe.Add(ref buffer, sNegative.Length)));

                for (int i = sNegative.Length - 1; i >= 0; i--) {
                    p = ref Unsafe.Subtract(ref p, 1);
                    p = sNegative[i];
                }
                Debug.Assert(Unsafe.AreSame(ref p, ref buffer));
            }
            return true;
        }

        private static string Int64ToHexStr(long value, char hexBase, int digits) {
            if (digits < 1) {
                digits = 1;
            }

            int bufferLength = Math.Max(digits, FormattingHelpers.CountHexDigits((ulong)value));
            Span<char> result = stackalloc char[bufferLength];
            if (true) {
                ref char buffer = ref result[0];
                ref char p = ref Int64ToHexChars(ref Unsafe.Add(ref buffer, bufferLength), (ulong)value, hexBase, digits);
                Debug.Assert(Unsafe.AreSame(ref p, ref buffer));
            }
            return result.ToString();
        }

        internal static bool TryInt64ToHexStr<TChar>(long value, char hexBase, int digits, Span<TChar> destination, out int charsWritten) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));

            if (digits < 1) {
                digits = 1;
            }

            int bufferLength = Math.Max(digits, FormattingHelpers.CountHexDigits((ulong)value));
            if (bufferLength > destination.Length) {
                charsWritten = 0;
                return false;
            }

            charsWritten = bufferLength;
            if (true) {
                ref TChar buffer = ref MemoryMarshal.GetReference(destination);
                ref TChar p = ref Int64ToHexChars(ref Unsafe.Add(ref buffer, bufferLength), (ulong)value, hexBase, digits);
                Debug.Assert(Unsafe.AreSame(ref p, ref buffer));
            }
            return true;
        }

#if TARGET_64BIT
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        private static ref TChar Int64ToHexChars<TChar>(ref TChar buffer, ulong value, int hexBase, int digits) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));
            if (!BitMathCore.Is64Bit) {
                uint lower = (uint)value;
                uint upper = (uint)(value >> 32);

                if (upper != 0)
                {
                    buffer = Int32ToHexChars(ref buffer, lower, hexBase, 8);
                    return ref Int32ToHexChars(ref buffer, upper, hexBase, digits - 8);
                }
                else
                {
                    return ref Int32ToHexChars(ref buffer, lower, hexBase, Math.Max(digits, 1));
                }
            } else {
                while (--digits >= 0 || value != 0) {
                    byte digit = (byte)(value & 0xF);
                    buffer = ref Unsafe.Subtract(ref buffer, 1);
                    buffer = CastFrom<TChar>(digit + (digit < 10 ? (byte)'0' : hexBase));
                    value >>= 4;
                }
                return ref buffer;
            }
        }

        private static string UInt64ToBinaryStr(ulong value, int digits) {
            if (digits < 1) {
                digits = 1;
            }

            int bufferLength = Math.Max(digits, 64 - (int)MathBitOperations.LeadingZeroCount(value));
            Span<char> result = stackalloc char[bufferLength];
            if (true) {
                ref char buffer = ref result[0];
                ref char p = ref UInt64ToBinaryChars(ref Unsafe.Add(ref buffer, bufferLength), value, digits);
                Debug.Assert(Unsafe.AreSame(ref p, ref buffer));
            }
            return result.ToString();
        }

        private static bool TryUInt64ToBinaryStr<TChar>(ulong value, int digits, Span<TChar> destination, out int charsWritten) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));

            if (digits < 1) {
                digits = 1;
            }

            int bufferLength = Math.Max(digits, 64 - (int)MathBitOperations.LeadingZeroCount(value));
            if (bufferLength > destination.Length) {
                charsWritten = 0;
                return false;
            }

            charsWritten = bufferLength;
            if (true) {
                ref TChar buffer = ref MemoryMarshal.GetReference(destination);
                ref TChar p = ref UInt64ToBinaryChars(ref Unsafe.Add(ref buffer, bufferLength), value, digits);
                Debug.Assert(Unsafe.AreSame(ref p, ref buffer));
            }
            return true;
        }

#if TARGET_64BIT
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        private static ref TChar UInt64ToBinaryChars<TChar>(ref TChar buffer, ulong value, int digits) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));
            if (!BitMathCore.Is64Bit) {
                uint lower = (uint)value;
                uint upper = (uint)(value >> 32);

                if (upper != 0)
                {
                    buffer = UInt32ToBinaryChars(ref buffer, lower, 32);
                    return ref UInt32ToBinaryChars(ref buffer, upper, digits - 32);
                }
                else
                {
                    return ref UInt32ToBinaryChars(ref buffer, lower, Math.Max(digits, 1));
                }
            } else {
                while (--digits >= 0 || value != 0) {
                    buffer = ref Unsafe.Subtract(ref buffer, 1);
                    buffer = CastFrom<TChar>('0' + (byte)(value & 0x1));
                    value >>= 1;
                }
                return ref buffer;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void UInt64ToNumber(ulong value, ref NumberBuffer number) {
            number.DigitsCount = UInt64Precision;
            number.IsNegative = false;

            ref byte buffer = ref number.DigitsPtr;
            ref byte p = ref UInt64ToDecChars(ref Unsafe.Add(ref buffer, UInt64Precision), value, 0);

            int i = (int)(buffer + UInt64Precision - p);

            number.DigitsCount = i;
            number.Scale = i;

            ref byte dst = ref number.DigitsPtr;
            while (--i >= 0) {
                // *dst++ = *p++;
                dst = p;
                dst = ref Unsafe.Add(ref dst, 1);
                p = ref Unsafe.Add(ref p, 1);
            }
            dst = (byte)'\0';

            number.CheckConsistency();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static uint Int64DivMod1E9(ref ulong value) {
            uint rem = (uint)(value % 1_000_000_000);
            value /= 1_000_000_000;
            return rem;
        }

#if TARGET_64BIT
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        internal static ref TChar UInt64ToDecChars<TChar>(ref TChar bufferEnd, ulong value) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));

            if (!BitMathCore.Is64Bit) {
                while ((uint)(value >> 32) != 0) {
                    bufferEnd = UInt32ToDecChars(ref bufferEnd, Int64DivMod1E9(ref value), 9);
                }
                return ref UInt32ToDecChars(ref bufferEnd, (uint)value);
            } else {
                if (value >= 10) {
                    // Handle all values >= 100 two-digits at a time so as to avoid expensive integer division operations.
                    while (value >= 100) {
                        bufferEnd = ref Unsafe.Add(ref bufferEnd, -2);
                        (value, ulong remainder) = BitMath.DivRem(value, 100);
                        WriteTwoDigits((uint)remainder, ref bufferEnd);
                    }

                    // If there are two digits remaining, store them.
                    if (value >= 10) {
                        bufferEnd = ref Unsafe.Add(ref bufferEnd, -2);
                        WriteTwoDigits((uint)value, ref bufferEnd);
                        return ref bufferEnd;
                    }
                }

                // Otherwise, store the single digit remaining.
                bufferEnd = ref Unsafe.Add(ref bufferEnd, -1);
                bufferEnd = CastFrom<TChar>(value + '0');
                return ref bufferEnd;
            }
        }

#if TARGET_64BIT
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        internal static ref TChar UInt64ToDecChars<TChar>(ref TChar bufferEnd, ulong value, int digits) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));

            if (!BitMathCore.Is64Bit) {
                while ((uint)(value >> 32) != 0)
                {
                    bufferEnd = ref UInt32ToDecChars(ref bufferEnd, Int64DivMod1E9(ref value), 9);
                    digits -= 9;
                }
                return ref UInt32ToDecChars(ref bufferEnd, (uint)value, digits);
            } else {
                ulong remainder;
                while (value >= 100) {
                    bufferEnd = ref Unsafe.Add(ref bufferEnd, -2);
                    digits -= 2;
                    (value, remainder) = BitMath.DivRem(value, 100);
                    WriteTwoDigits((uint)remainder, ref bufferEnd);
                }

                while (value != 0 || digits > 0) {
                    digits--;
                    (value, remainder) = BitMath.DivRem(value, 10);
                    bufferEnd = ref Unsafe.Add(ref bufferEnd, -1);
                    bufferEnd = CastFrom<TChar>(remainder + '0');
                }

                return ref bufferEnd;
            }
        }

        internal static string UInt64ToDecStr(ulong value) {
            // For small numbers, consult a lazily-populated cache.
            if (value < SmallNumberCacheLength) {
                return UInt32ToDecStrForKnownSmallNumber((uint)value);
            }

            int bufferLength = FormattingHelpers.CountDigits(value);

            Span<char> result = stackalloc char[bufferLength];
            if (true) {
                ref char buffer = ref result[0];
                ref char p = ref Unsafe.Add(ref buffer, bufferLength);
                p = UInt64ToDecChars(ref p, value);
                Debug.Assert(Unsafe.AreSame(ref p, ref buffer));
            }
            return result.ToString();
        }

        internal static string UInt64ToDecStr(ulong value, int digits) {
            if (digits <= 1) {
                return UInt64ToDecStr(value);
            }

            int bufferLength = Math.Max(digits, FormattingHelpers.CountDigits(value));
            Span<char> result = stackalloc char[bufferLength];
            if (true) {
                ref char buffer = ref result[0];
                ref char p = ref Unsafe.Add(ref buffer, bufferLength);
                p = UInt64ToDecChars(ref p, value, digits);
                Debug.Assert(Unsafe.AreSame(ref p, ref buffer));
            }
            return result.ToString();
        }

        internal static bool TryUInt64ToDecStr<TChar>(ulong value, Span<TChar> destination, out int charsWritten) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));

            int bufferLength = FormattingHelpers.CountDigits(value);
            if (bufferLength <= destination.Length) {
                charsWritten = bufferLength;
                if (true) {
                    ref TChar buffer = ref MemoryMarshal.GetReference(destination);
                    ref TChar p = ref Unsafe.Add(ref buffer, bufferLength);
                    p = ref UInt64ToDecChars(ref p, value);
                    Debug.Assert(Unsafe.AreSame(ref p, ref buffer));
                }
                return true;
            }

            charsWritten = 0;
            return false;
        }

        internal static bool TryUInt64ToDecStr<TChar>(ulong value, int digits, Span<TChar> destination, out int charsWritten) where TChar : unmanaged, IEquatable<TChar> {
            int countedDigits = FormattingHelpers.CountDigits(value);
            int bufferLength = Math.Max(digits, countedDigits);
            if (bufferLength <= destination.Length) {
                charsWritten = bufferLength;
                if (true) {
                    ref TChar buffer = ref MemoryMarshal.GetReference(destination);
                    ref TChar p = ref Unsafe.Add(ref buffer, bufferLength);
                    p = digits > countedDigits ?
                        UInt64ToDecChars(ref p, value, digits) :
                        UInt64ToDecChars(ref p, value);
                    Debug.Assert(Unsafe.AreSame(ref p, ref buffer));
                }
                return true;
            }

            charsWritten = 0;
            return false;
        }

        private static void ExInt128ToNumber(ExInt128 value, ref NumberBuffer number) {
            number.DigitsCount = ExInt128Precision;

            if (ExInt128.IsPositive(value)) {
                number.IsNegative = false;
            } else {
                number.IsNegative = true;
                value = -value;
            }

            ref byte buffer = ref number.DigitsPtr;
            ref byte p = ref ExUInt128ToDecChars(ref Unsafe.Add(ref buffer, ExInt128Precision), (ExUInt128)value, 0);

            int i = (int)(buffer + ExInt128Precision - p);

            number.DigitsCount = i;
            number.Scale = i;

            ref byte dst = ref number.DigitsPtr;
            while (--i >= 0) {
                dst = p;
                dst = ref Unsafe.Add(ref dst, 1);
                p = ref Unsafe.Add(ref p, 1);
            }
            dst = (byte)'\0';

            number.CheckConsistency();
        }

        public static string ExInt128ToDecStr(ExInt128 value) {
            return ExInt128.IsPositive(value)
                 ? ExUInt128ToDecStr((ExUInt128)value, -1)
                 : NegativeExInt128ToDecStr(value, -1, NumberFormatInfo.CurrentInfo.NegativeSign);
        }

        private static string NegativeExInt128ToDecStr(ExInt128 value, int digits, string sNegative) {
            Debug.Assert(ExInt128.IsNegative(value));

            if (digits < 1) {
                digits = 1;
            }

            ExUInt128 absValue = (ExUInt128)(-value);

            int bufferLength = Math.Max(digits, FormattingHelpers.CountDigits(absValue)) + sNegative.Length;
            Span<char> result = stackalloc char[bufferLength];
            if (true) {
                ref char buffer = ref result[0];
                ref char p = ref ExUInt128ToDecChars(ref Unsafe.Add(ref buffer, bufferLength), absValue, digits);
                Debug.Assert(Unsafe.AreSame(ref p, ref Unsafe.Add(ref buffer, sNegative.Length)));

                for (int i = sNegative.Length - 1; i >= 0; i--) {
                    p = ref Unsafe.Add(ref p, -1);
                    p = sNegative[i];
                }
                Debug.Assert(Unsafe.AreSame(ref p, ref buffer));
            }
            return result.ToString();
        }

        private static bool TryNegativeExInt128ToDecStr<TChar>(ExInt128 value, int digits, ReadOnlySpan<TChar> sNegative, Span<TChar> destination, out int charsWritten) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));
            Debug.Assert(ExInt128.IsNegative(value));

            if (digits < 1) {
                digits = 1;
            }

            ExUInt128 absValue = (ExUInt128)(-value);

            int bufferLength = Math.Max(digits, FormattingHelpers.CountDigits(absValue)) + sNegative.Length;
            if (bufferLength > destination.Length) {
                charsWritten = 0;
                return false;
            }

            charsWritten = bufferLength;
            if (true) {
                ref TChar buffer = ref MemoryMarshal.GetReference(destination);
                ref TChar p = ref ExUInt128ToDecChars(ref Unsafe.Add(ref buffer, bufferLength), absValue, digits);
                Debug.Assert(Unsafe.AreSame(ref p, ref Unsafe.Add(ref buffer, sNegative.Length)));

                for (int i = sNegative.Length - 1; i >= 0; i--) {
                    p = ref Unsafe.Add(ref p, -1);
                    p = sNegative[i];
                }
                Debug.Assert(Unsafe.AreSame(ref p, ref buffer));
            }
            return true;
        }

        private static string ExInt128ToHexStr(ExInt128 value, char hexBase, int digits) {
            if (digits < 1) {
                digits = 1;
            }

            ExUInt128 uValue = (ExUInt128)value;

            int bufferLength = Math.Max(digits, FormattingHelpers.CountHexDigits(uValue));
            Span<char> result = stackalloc char[bufferLength];
            if (true) {
                ref char buffer = ref result[0];
                ref char p = ref ExInt128ToHexChars(ref Unsafe.Add(ref buffer, bufferLength), uValue, hexBase, digits);
                Debug.Assert(Unsafe.AreSame(ref p, ref buffer));
            }
            return result.ToString();
        }

        private static bool TryExInt128ToHexStr<TChar>(ExInt128 value, char hexBase, int digits, Span<TChar> destination, out int charsWritten) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));

            if (digits < 1) {
                digits = 1;
            }

            ExUInt128 uValue = (ExUInt128)value;

            int bufferLength = Math.Max(digits, FormattingHelpers.CountHexDigits(uValue));
            if (bufferLength > destination.Length) {
                charsWritten = 0;
                return false;
            }

            charsWritten = bufferLength;
            if (true) {
                ref TChar buffer = ref MemoryMarshal.GetReference(destination);
                ref TChar p = ref ExInt128ToHexChars(ref Unsafe.Add(ref buffer, bufferLength), uValue, hexBase, digits);
                Debug.Assert(Unsafe.AreSame(ref p, ref buffer));
            }
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static ref TChar ExInt128ToHexChars<TChar>(ref TChar buffer, ExUInt128 value, int hexBase, int digits) where TChar : unmanaged, IEquatable<TChar> {
            ulong lower = value.Lower;
            ulong upper = value.Upper;

            if (upper != 0) {
                buffer = ref Int64ToHexChars(ref buffer, lower, hexBase, 16);
                return ref Int64ToHexChars(ref buffer, upper, hexBase, digits - 16);
            } else {
                return ref Int64ToHexChars(ref buffer, lower, hexBase, Math.Max(digits, 1));
            }
        }

        private static string ExUInt128ToBinaryStr(ExInt128 value, int digits) {
            if (digits < 1) {
                digits = 1;
            }

            ExUInt128 uValue = (ExUInt128)value;

            int bufferLength = Math.Max(digits, 128 - (int)ExUInt128.LeadingZeroCount((ExUInt128)value));
            Span<char> result = stackalloc char[bufferLength];
            if (true) {
                ref char buffer = ref result[0];
                ref char p = ref ExUInt128ToBinaryChars(ref Unsafe.Add(ref buffer, bufferLength), uValue, digits);
                Debug.Assert(Unsafe.AreSame(ref p, ref buffer));
            }
            return result.ToString();
        }

        private static bool TryExUInt128ToBinaryStr<TChar>(ExInt128 value, int digits, Span<TChar> destination, out int charsWritten) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));

            if (digits < 1) {
                digits = 1;
            }

            ExUInt128 uValue = (ExUInt128)value;

            int bufferLength = Math.Max(digits, 128 - (int)ExUInt128.LeadingZeroCount((ExUInt128)value));
            if (bufferLength > destination.Length) {
                charsWritten = 0;
                return false;
            }

            charsWritten = bufferLength;
            if (true) {
                ref TChar buffer = ref MemoryMarshal.GetReference(destination);
                ref TChar p = ref ExUInt128ToBinaryChars(ref Unsafe.Add(ref buffer, bufferLength), uValue, digits);
                Debug.Assert(Unsafe.AreSame(ref p, ref buffer));
            }
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static ref TChar ExUInt128ToBinaryChars<TChar>(ref TChar buffer, ExUInt128 value, int digits) where TChar : unmanaged, IEquatable<TChar> {
            ulong lower = value.Lower;
            ulong upper = value.Upper;

            if (upper != 0) {
                buffer = ref UInt64ToBinaryChars(ref buffer, lower, 64);
                return ref UInt64ToBinaryChars(ref buffer, upper, digits - 64);
            } else {
                return ref UInt64ToBinaryChars(ref buffer, lower, Math.Max(digits, 1));
            }
        }

        private static void ExUInt128ToNumber(ExUInt128 value, ref NumberBuffer number) {
            number.DigitsCount = ExUInt128Precision;
            number.IsNegative = false;

            ref byte buffer = ref number.DigitsPtr;
            ref byte p = ref ExUInt128ToDecChars(ref Unsafe.Add(ref buffer, ExUInt128Precision), value, 0);

            int i = (int)(buffer + ExUInt128Precision - p);

            number.DigitsCount = i;
            number.Scale = i;

            ref byte dst = ref number.DigitsPtr;
            while (--i >= 0) {
                dst = p;
                dst = ref Unsafe.Add(ref dst, 1);
                p = ref Unsafe.Add(ref p, 1);
            }
            dst = (byte)'\0';

            number.CheckConsistency();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static ulong ExInt128DivMod1E19(ref ExUInt128 value) {
            ExUInt128 divisor = new ExUInt128(0, 10_000_000_000_000_000_000);
            (value, ExUInt128 remainder) = ExUInt128.DivRem(value, divisor);
            return remainder.Lower;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ref TChar ExUInt128ToDecChars<TChar>(ref TChar bufferEnd, ExUInt128 value) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));

            while (value.Upper != 0) {
                bufferEnd = ref UInt64ToDecChars(ref bufferEnd, ExInt128DivMod1E19(ref value), 19);
            }
            return ref UInt64ToDecChars(ref bufferEnd, value.Lower);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ref TChar ExUInt128ToDecChars<TChar>(ref TChar bufferEnd, ExUInt128 value, int digits) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));

            while (value.Upper != 0) {
                bufferEnd = ref UInt64ToDecChars(ref bufferEnd, ExInt128DivMod1E19(ref value), 19);
                digits -= 19;
            }
            return ref UInt64ToDecChars(ref bufferEnd, value.Lower, digits);
        }

        internal static string ExUInt128ToDecStr(ExUInt128 value) {
            if (value.Upper == 0) {
                return UInt64ToDecStr(value.Lower);
            }

            int bufferLength = FormattingHelpers.CountDigits(value);

            Span<char> result = stackalloc char[bufferLength];
            if (true) {
                ref char buffer = ref result[0];
                ref char p = ref Unsafe.Add(ref buffer, bufferLength);
                p = ref ExUInt128ToDecChars(ref p, value);
                Debug.Assert(Unsafe.AreSame(ref p, ref buffer));
            }
            return result.ToString();
        }

        internal static string ExUInt128ToDecStr(ExUInt128 value, int digits) {
            if (digits <= 1) {
                return ExUInt128ToDecStr(value);
            }

            int bufferLength = Math.Max(digits, FormattingHelpers.CountDigits(value));
            Span<char> result = stackalloc char[bufferLength];
            if (true) {
                ref char buffer = ref result[0];
                ref char p = ref Unsafe.Add(ref buffer, bufferLength);
                p = ref ExUInt128ToDecChars(ref p, value, digits);
                Debug.Assert(Unsafe.AreSame(ref p, ref buffer));
            }
            return result.ToString();
        }

        private static bool TryExUInt128ToDecStr<TChar>(ExUInt128 value, int digits, Span<TChar> destination, out int charsWritten) where TChar : unmanaged, IEquatable<TChar> {
            int countedDigits = FormattingHelpers.CountDigits(value);
            int bufferLength = Math.Max(digits, countedDigits);
            if (bufferLength <= destination.Length) {
                charsWritten = bufferLength;
                if (true) {
                    ref TChar buffer = ref MemoryMarshal.GetReference(destination);
                    ref TChar p = ref Unsafe.Add(ref buffer, bufferLength);
                    p = digits > countedDigits ?
                        ExUInt128ToDecChars(ref p, value, digits) :
                        ExUInt128ToDecChars(ref p, value);
                    Debug.Assert(Unsafe.AreSame(ref p, ref buffer));
                }
                return true;
            }

            charsWritten = 0;
            return false;
        }

        private static ulong ExtractFractionAndBiasedExponent(double value, out int exponent) {
            ulong bits = BitConverter.DoubleToUInt64Bits(value);
            ulong fraction = (bits & 0xFFFFFFFFFFFFF);
            exponent = ((int)(bits >> 52) & 0x7FF);

            if (exponent != 0) {
                // For normalized value, according to https://en.wikipedia.org/wiki/Double-precision_floating-point_format
                // value = 1.fraction * 2^(exp - 1023)
                //       = (1 + mantissa / 2^52) * 2^(exp - 1023)
                //       = (2^52 + mantissa) * 2^(exp - 1023 - 52)
                //
                // So f = (2^52 + mantissa), e = exp - 1075;

                fraction |= (1UL << 52);
                exponent -= 1075;
            } else {
                // For denormalized value, according to https://en.wikipedia.org/wiki/Double-precision_floating-point_format
                // value = 0.fraction * 2^(1 - 1023)
                //       = (mantissa / 2^52) * 2^(-1022)
                //       = mantissa * 2^(-1022 - 52)
                //       = mantissa * 2^(-1074)
                // So f = mantissa, e = -1074
                exponent = -1074;
            }

            return fraction;
        }

#if BCL_TYPE_HALF
        private static ushort ExtractFractionAndBiasedExponent(Half value, out int exponent) {
            ushort bits = BitConverter.HalfToUInt16Bits(value);
            ushort fraction = (ushort)(bits & 0x3FF);
            exponent = ((int)(bits >> 10) & 0x1F);

            if (exponent != 0) {
                // For normalized value, according to https://en.wikipedia.org/wiki/Half-precision_floating-point_format
                // value = 1.fraction * 2^(exp - 15)
                //       = (1 + mantissa / 2^10) * 2^(exp - 15)
                //       = (2^10 + mantissa) * 2^(exp - 15 - 10)
                //
                // So f = (2^10 + mantissa), e = exp - 25;

                fraction |= (ushort)(1U << 10);
                exponent -= 25;
            } else {
                // For denormalized value, according to https://en.wikipedia.org/wiki/Half-precision_floating-point_format
                // value = 0.fraction * 2^(1 - 15)
                //       = (mantissa / 2^10) * 2^(-14)
                //       = mantissa * 2^(-14 - 10)
                //       = mantissa * 2^(-24)
                // So f = mantissa, e = -24
                exponent = -24;
            }

            return fraction;
        }
#endif

        private static uint ExtractFractionAndBiasedExponent(float value, out int exponent) {
            uint bits = BitConverter.SingleToUInt32Bits(value);
            uint fraction = (bits & 0x7FFFFF);
            exponent = ((int)(bits >> 23) & 0xFF);

            if (exponent != 0) {
                // For normalized value, according to https://en.wikipedia.org/wiki/Single-precision_floating-point_format
                // value = 1.fraction * 2^(exp - 127)
                //       = (1 + mantissa / 2^23) * 2^(exp - 127)
                //       = (2^23 + mantissa) * 2^(exp - 127 - 23)
                //
                // So f = (2^23 + mantissa), e = exp - 150;

                fraction |= (1U << 23);
                exponent -= 150;
            } else {
                // For denormalized value, according to https://en.wikipedia.org/wiki/Single-precision_floating-point_format
                // value = 0.fraction * 2^(1 - 127)
                //       = (mantissa / 2^23) * 2^(-126)
                //       = mantissa * 2^(-126 - 23)
                //       = mantissa * 2^(-149)
                // So f = mantissa, e = -149
                exponent = -149;
            }

            return fraction;
        }

#if THIS_HIDE
        private static ulong ExtractFractionAndBiasedExponent<TNumber>(TNumber value, out int exponent)
            where TNumber : unmanaged, IComparable<TNumber> {
            ulong bits = FloatFormatInfo<TNumber>.FloatToBits(value);
            ulong fraction = (bits & FloatFormatInfo<TNumber>.DenormalMantissaMask);
            exponent = ((int)(bits >> FloatFormatInfo<TNumber>.DenormalMantissaBits) & FloatFormatInfo<TNumber>.InfinityExponent);

            if (exponent != 0) {
                // For normalized value,
                // value = 1.fraction * 2^(exp - ExponentBias)
                //       = (1 + mantissa / 2^TrailingSignificandLength) * 2^(exp - ExponentBias)
                //       = (2^TrailingSignificandLength + mantissa) * 2^(exp - ExponentBias - TrailingSignificandLength)
                //
                // So f = (2^TrailingSignificandLength + mantissa), e = exp - ExponentBias - TrailingSignificandLength;

                fraction |= (1UL << FloatFormatInfo<TNumber>.DenormalMantissaBits);
                exponent -= FloatFormatInfo<TNumber>.ExponentBias + FloatFormatInfo<TNumber>.DenormalMantissaBits;
            } else {
                // For denormalized value,
                // value = 0.fraction * 2^(MinBinaryExponent)
                //       = (mantissa / 2^TrailingSignificandLength) * 2^(MinBinaryExponent)
                //       = mantissa * 2^(MinBinaryExponent - TrailingSignificandLength)
                //       = mantissa * 2^(MinBinaryExponent - TrailingSignificandLength)
                // So f = mantissa, e = MinBinaryExponent - TrailingSignificandLength
                exponent = FloatFormatInfo<TNumber>.MinBinaryExponent - FloatFormatInfo<TNumber>.DenormalMantissaBits;
            }

            return fraction;
        }
#endif // THIS_HIDE
    }

}
