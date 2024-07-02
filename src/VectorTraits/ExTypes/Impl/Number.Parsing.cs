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
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Zyl.VectorTraits.Impl.Util;
using Zyl.VectorTraits.Numerics;

namespace Zyl.VectorTraits.ExTypes.Impl {
    using BitConverter = MathBitConverter;
    //using IBinaryIntegerParseAndFormatInfo = IComparable;
    //using IBinaryFloatParseAndFormatInfo = IComparable;
    //using IUtfChar = IEquatable;

    internal static partial class Number {
        private const int Int32Precision = 10;
        private const int UInt32Precision = Int32Precision;
        private const int Int64Precision = 19;
        private const int UInt64Precision = 20;
        private const int ExInt128Precision = 39;
        private const int ExUInt128Precision = 39;

        private const int FloatingPointMaxExponent = 309;
        private const int FloatingPointMinExponent = -324;

        private const int FloatingPointMaxDenormalMantissaBits = 52;

        private static bool TryNumberBufferToBinaryInteger<TInteger>(ref NumberBuffer number, ref TInteger value)
            where TInteger : unmanaged, IComparable<TInteger>
#if GENERICS_MATH
            , IBinaryInteger<TInteger>
#endif // GENERICS_MATH
            {
            number.CheckConsistency();

            int i = number.Scale;

            if ((i > IntegerFormatInfo<TInteger>.MaxDigitCount) || (i < number.DigitsCount) || (!IntegerFormatInfo<TInteger>.IsSigned && number.IsNegative)) {
                return false;
            }

            ref byte p = ref number.DigitsPtr;

            Debug.Assert(!UnsafeUtil.IsNullRef(ref p));
            TInteger n = IntegerFormatInfo<TInteger>.Zero;

            while (--i >= 0) {
                if (IntegerFormatInfo<TInteger>.IsGreaterThanAsUnsigned(n, IntegerFormatInfo<TInteger>.MaxValueDiv10)) {
                    return false;
                }

                n = IntegerFormatInfo<TInteger>.MultiplyBy10(n);

                if (p != '\0') {
                    // TInteger newN = n + TInteger.CreateTruncating(*p++ - '0');
                    TInteger newN = IntegerFormatInfo<TInteger>.AddInt(n, p - (byte)'0');
                    p = ref Unsafe.Add(ref p, 1);

                    if (!IntegerFormatInfo<TInteger>.IsSigned && (newN.CompareTo(n)<0)) {
                        return false;
                    }

                    n = newN;
                }
            }

            if (IntegerFormatInfo<TInteger>.IsSigned) {
                TInteger zero = IntegerFormatInfo<TInteger>.Zero;
                if (number.IsNegative) {
                    n = IntegerFormatInfo<TInteger>.UnaryNegation(n);

                    if (n.CompareTo(zero) > 0) {
                        return false;
                    }
                } else if (n.CompareTo(zero) < 0) {
                    return false;
                }
            }

            value = n;
            return true;
        }

        internal static TInteger ParseBinaryInteger<TChar, TInteger>(ReadOnlySpan<TChar> value, NumberStyles styles, NumberFormatInfo info)
            where TChar : unmanaged, IEquatable<TChar>
            where TInteger : unmanaged, IComparable<TInteger>
#if GENERICS_MATH
            , IBinaryInteger<TInteger>
#endif // GENERICS_MATH
            {
            ParsingStatus status = TryParseBinaryInteger(value, styles, info, out TInteger result);

            if (status != ParsingStatus.OK) {
                ThrowOverflowOrFormatException<TChar, TInteger>(status, value);
            }
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ParsingStatus TryParseBinaryInteger<TChar, TInteger>(ReadOnlySpan<TChar> value, NumberStyles styles, NumberFormatInfo info, out TInteger result)
            where TChar : unmanaged, IEquatable<TChar>
            where TInteger : unmanaged, IComparable<TInteger>
#if GENERICS_MATH
            , IBinaryInteger<TInteger>
#endif // GENERICS_MATH
            {
            if ((styles & ~NumberStyles.Integer) == 0) {
                // Optimized path for the common case of anything that's allowed for integer style.
                return TryParseBinaryIntegerStyle(value, styles, info, out result);
            }

            if ((styles & NumberStyles.AllowHexSpecifier) != 0) {
                return TryParseBinaryIntegerHexNumberStyle(value, styles, out result);
            }

#if NET8_0_OR_GREATER
            if ((styles & NumberStyles.AllowBinarySpecifier) != 0) {
                return TryParseBinaryIntegerHexOrBinaryNumberStyle<TChar, TInteger, BinaryParser<TInteger>>(value, styles, out result);
            }
#endif // NET8_0_OR_GREATER

            return TryParseBinaryIntegerNumber(value, styles, info, out result);
        }

        private static ParsingStatus TryParseBinaryIntegerNumber<TChar, TInteger>(ReadOnlySpan<TChar> value, NumberStyles styles, NumberFormatInfo info, out TInteger result)
            where TChar : unmanaged, IEquatable<TChar>
            where TInteger : unmanaged, IComparable<TInteger>
#if GENERICS_MATH
            , IBinaryInteger<TInteger>
#endif // GENERICS_MATH
            {
            result = IntegerFormatInfo<TInteger>.Zero;
            NumberBuffer number = new NumberBuffer(NumberBufferKind.Integer, stackalloc byte[IntegerFormatInfo<TInteger>.MaxDigitCount + 1]);

            if (!TryStringToNumber(value, styles, ref number, info)) {
                return ParsingStatus.Failed;
            }

            if (!TryNumberBufferToBinaryInteger(ref number, ref result)) {
                return ParsingStatus.Overflow;
            }

            return ParsingStatus.OK;
        }

        /// <summary>Parses int limited to styles that make up NumberStyles.Integer.</summary>
        internal static ParsingStatus TryParseBinaryIntegerStyle<TChar, TInteger>(ReadOnlySpan<TChar> value, NumberStyles styles, NumberFormatInfo info, out TInteger result)
            where TChar : unmanaged, IEquatable<TChar>
            where TInteger : unmanaged, IComparable<TInteger>
#if GENERICS_MATH
            , IBinaryInteger<TInteger>
#endif // GENERICS_MATH
            {
            Debug.Assert((styles & ~NumberStyles.Integer) == 0, "Only handles subsets of Integer format");

            if (value.IsEmpty) {
                goto FalseExit;
            }

            int index = 0;
            uint num = CastToUInt32(value[0]);

            // Skip past any whitespace at the beginning.
            if ((styles & NumberStyles.AllowLeadingWhite) != 0 && IsWhite(num)) {
                do {
                    index++;

                    if ((uint)index >= (uint)value.Length) {
                        goto FalseExit;
                    }
                    num = CastToUInt32(value[index]);
                }
                while (IsWhite(num));
            }

            // Parse leading sign.
            bool isNegative = false;
            if ((styles & NumberStyles.AllowLeadingSign) != 0) {
                if (info.HasInvariantNumberSignsCheck()) {
                    if (num == '-') {
                        isNegative = true;
                        index++;

                        if ((uint)index >= (uint)value.Length) {
                            goto FalseExit;
                        }
                        num = CastToUInt32(value[index]);
                    } else if (num == '+') {
                        index++;

                        if ((uint)index >= (uint)value.Length) {
                            goto FalseExit;
                        }
                        num = CastToUInt32(value[index]);
                    }
                } else if (info.AllowHyphenDuringParsing() && num == '-') {
                    isNegative = true;
                    index++;

                    if ((uint)index >= (uint)value.Length) {
                        goto FalseExit;
                    }
                    num = CastToUInt32(value[index]);
                } else {
                    value = value.Slice(index);
                    index = 0;

                    ReadOnlySpan<TChar> positiveSign = info.PositiveSignTChar<TChar>();
                    ReadOnlySpan<TChar> negativeSign = info.NegativeSignTChar<TChar>();

                    if (!positiveSign.IsEmpty && value.StartsWith(positiveSign)) {
                        index += positiveSign.Length;

                        if ((uint)index >= (uint)value.Length) {
                            goto FalseExit;
                        }
                        num = CastToUInt32(value[index]);
                    } else if (!negativeSign.IsEmpty && value.StartsWith(negativeSign)) {
                        isNegative = true;
                        index += negativeSign.Length;

                        if ((uint)index >= (uint)value.Length) {
                            goto FalseExit;
                        }
                        num = CastToUInt32(value[index]);
                    }
                }
            }

            bool overflow = !IntegerFormatInfo<TInteger>.IsSigned && isNegative;
            TInteger answer = IntegerFormatInfo<TInteger>.Zero;

            if (IsDigit(num)) {
                // Skip past leading zeros.
                if (num == '0') {
                    do {
                        index++;

                        if ((uint)index >= (uint)value.Length) {
                            goto DoneAtEnd;
                        }
                        num = CastToUInt32(value[index]);
                    } while (num == '0');

                    if (!IsDigit(num)) {
                        if (!IntegerFormatInfo<TInteger>.IsSigned) {
                            overflow = false;
                        }
                        goto HasTrailingChars;
                    }
                }

                // Parse most digits, up to the potential for overflow, which can't happen until after MaxDigitCount - 1 digits.
                answer = IntegerFormatInfo<TInteger>.CreateTruncating((int)num - '0'); // first digit
                index++;

                for (int i = 0; i < IntegerFormatInfo<TInteger>.MaxDigitCount - 2; i++) // next MaxDigitCount - 2 digits can't overflow
                {
                    if ((uint)index >= (uint)value.Length) {
                        if (!IntegerFormatInfo<TInteger>.IsSigned) {
                            goto DoneAtEndButPotentialOverflow;
                        } else {
                            goto DoneAtEnd;
                        }
                    }

                    num = CastToUInt32(value[index]);

                    if (!IsDigit(num)) {
                        goto HasTrailingChars;
                    }
                    index++;

                    answer = IntegerFormatInfo<TInteger>.MultiplyBy10(answer);
                    //answer += TInteger.CreateTruncating(num - '0');
                    answer = IntegerFormatInfo<TInteger>.AddInt(answer, (int)num - '0');
                }

                if ((uint)index >= (uint)value.Length) {
                    if (!IntegerFormatInfo<TInteger>.IsSigned) {
                        goto DoneAtEndButPotentialOverflow;
                    } else {
                        goto DoneAtEnd;
                    }
                }

                num = CastToUInt32(value[index]);

                if (!IsDigit(num)) {
                    goto HasTrailingChars;
                }
                index++;

                // Potential overflow now processing the MaxDigitCount digit.
                int cmp = answer.CompareTo(IntegerFormatInfo<TInteger>.MaxValueDiv10);
                if (!IntegerFormatInfo<TInteger>.IsSigned) {
                    overflow |= (cmp > 0) || ((cmp == 0) && (num > '5'));
                } else {
                    overflow = cmp > 0;
                }

                answer = IntegerFormatInfo<TInteger>.MultiplyBy10(answer);
                answer = IntegerFormatInfo<TInteger>.AddInt(answer, (int)num - '0');

                if (IntegerFormatInfo<TInteger>.IsSigned) {
                    // overflow |= TInteger.IsGreaterThanAsUnsigned(answer, TInteger.MaxValue + (isNegative ? TInteger.One : TInteger.Zero));
                    TInteger right = IntegerFormatInfo<TInteger>.MaxValue;
                    if (isNegative) {
                        right = IntegerFormatInfo<TInteger>.AddInt(right, 1);
                    }
                    overflow |= IntegerFormatInfo<TInteger>.IsGreaterThanAsUnsigned(answer, right);
                }

                if ((uint)index >= (uint)value.Length) {
                    goto DoneAtEndButPotentialOverflow;
                }

                // At this point, we're either overflowing or hitting a formatting error.
                // Format errors take precedence for compatibility.
                num = CastToUInt32(value[index]);

                while (IsDigit(num)) {
                    overflow = true;
                    index++;

                    if ((uint)index >= (uint)value.Length) {
                        goto OverflowExit;
                    }
                    num = CastToUInt32(value[index]);
                }
                goto HasTrailingChars;
            }
            goto FalseExit;

        DoneAtEndButPotentialOverflow:
            if (overflow) {
                goto OverflowExit;
            }

        DoneAtEnd:
            if (!IntegerFormatInfo<TInteger>.IsSigned) {
                result = answer;
            } else {
                result = isNegative ? IntegerFormatInfo<TInteger>.UnaryNegation(answer) : answer;
            }
            ParsingStatus status = ParsingStatus.OK;

        Exit:
            return status;

        FalseExit: // parsing failed
            result = IntegerFormatInfo<TInteger>.Zero;
            status = ParsingStatus.Failed;
            goto Exit;

        OverflowExit:
            result = IntegerFormatInfo<TInteger>.Zero;
            status = ParsingStatus.Overflow;
            goto Exit;

        HasTrailingChars: // we've successfully parsed, but there are still remaining characters in the span
            // Skip past trailing whitespace, then past trailing zeros, and if anything else remains, fail.
            if (IsWhite(num)) {
                if ((styles & NumberStyles.AllowTrailingWhite) == 0) {
                    goto FalseExit;
                }

                for (index++; index < value.Length; index++) {
                    uint ch = CastToUInt32(value[index]);

                    if (!IsWhite(ch)) {
                        break;
                    }
                }
                if ((uint)index >= (uint)value.Length)
                    goto DoneAtEndButPotentialOverflow;
            }

            if (!TrailingZeros(value, index)) {
                goto FalseExit;
            }
            goto DoneAtEndButPotentialOverflow;
        }

        /// <summary>Parses <typeparamref name="TInteger"/> limited to styles that make up NumberStyles.HexNumber.</summary>
        internal static ParsingStatus TryParseBinaryIntegerHexNumberStyle<TChar, TInteger>(ReadOnlySpan<TChar> value, NumberStyles styles, out TInteger result)
            where TChar : unmanaged, IEquatable<TChar>
            where TInteger : unmanaged, IComparable<TInteger>
#if GENERICS_MATH
            , IBinaryInteger<TInteger>
#endif // GENERICS_MATH
            {
            return TryParseBinaryIntegerHexOrBinaryNumberStyle<TChar, TInteger, HexParser<TInteger>>(value, styles, out result);
        }

        private interface IHexOrBinaryParser<TInteger>
            where TInteger : unmanaged, IComparable<TInteger>
#if GENERICS_MATH
            , IBinaryInteger<TInteger>
#endif // GENERICS_MATH
            {
            NumberStyles AllowedStyles { get; }
            bool IsValidChar(uint ch);
            uint FromChar(uint ch);
            uint MaxDigitValue { get; }
            int MaxDigitCount { get; }
            TInteger ShiftLeftForNextDigit(TInteger value);
        }

        private readonly struct HexParser<TInteger> : IHexOrBinaryParser<TInteger> where TInteger : unmanaged, IComparable<TInteger>
#if GENERICS_MATH
            , IBinaryInteger<TInteger>
#endif // GENERICS_MATH
            {
            /// <summary>Static instance.</summary>
            public NumberStyles AllowedStyles => NumberStyles.HexNumber;
            public bool IsValidChar(uint ch) => HexConverter.IsHexChar((int)ch);
            public uint FromChar(uint ch) => (uint)HexConverter.FromChar((int)ch);
            public uint MaxDigitValue => 0xF;
            public int MaxDigitCount => IntegerFormatInfo<TInteger>.MaxHexDigitCount;
            public TInteger ShiftLeftForNextDigit(TInteger value) => IntegerFormatInfo<TInteger>.MultiplyBy16(value);
        }

        private readonly struct BinaryParser<TInteger> : IHexOrBinaryParser<TInteger> where TInteger : unmanaged, IComparable<TInteger>
#if GENERICS_MATH
            , IBinaryInteger<TInteger>
#endif // GENERICS_MATH
            {
            /// <summary>Static instance.</summary>
            public NumberStyles AllowedStyles => BinaryNumber;
            public bool IsValidChar(uint ch) => (ch - '0') <= 1;
            public uint FromChar(uint ch) => ch - '0';
            public uint MaxDigitValue => 1;
            public int MaxDigitCount => Unsafe.SizeOf<TInteger>() * 8;
            public TInteger ShiftLeftForNextDigit(TInteger value) => IntegerFormatInfo<TInteger>.MultiplyByInt(value, 2);
        }

        private static ParsingStatus TryParseBinaryIntegerHexOrBinaryNumberStyle<TChar, TInteger, TParser>(ReadOnlySpan<TChar> value, NumberStyles styles, out TInteger result)
            where TChar : unmanaged, IEquatable<TChar>
            where TInteger : unmanaged, IComparable<TInteger>
#if GENERICS_MATH
            , IBinaryInteger<TInteger>
#endif // GENERICS_MATH
            where TParser : struct, IHexOrBinaryParser<TInteger> {
            TParser aParser = default;
            Debug.Assert((styles & ~aParser.AllowedStyles) == 0, $"Only handles subsets of {aParser.AllowedStyles} format");

            if (value.IsEmpty) {
                goto FalseExit;
            }

            int index = 0;
            uint num = CastToUInt32(value[0]);

            // Skip past any whitespace at the beginning.
            if ((styles & NumberStyles.AllowLeadingWhite) != 0 && IsWhite(num)) {
                do {
                    index++;

                    if ((uint)index >= (uint)value.Length) {
                        goto FalseExit;
                    }
                    num = CastToUInt32(value[index]);
                }
                while (IsWhite(num));
            }

            bool overflow = false;
            TInteger answer = IntegerFormatInfo<TInteger>.Zero;

            if (aParser.IsValidChar(num)) {
                // Skip past leading zeros.
                if (num == '0') {
                    do {
                        index++;

                        if ((uint)index >= (uint)value.Length) {
                            goto DoneAtEnd;
                        }
                        num = CastToUInt32(value[index]);
                    } while (num == '0');

                    if (!aParser.IsValidChar(num)) {
                        goto HasTrailingChars;
                    }
                }

                // Parse up through MaxDigitCount digits, as no overflow is possible
                answer = IntegerFormatInfo<TInteger>.CreateTruncating(aParser.FromChar(num)); // first digit
                index++;

                for (int i = 0; i < aParser.MaxDigitCount - 1; i++) // next MaxDigitCount - 1 digits can't overflow
                {
                    if ((uint)index >= (uint)value.Length) {
                        goto DoneAtEnd;
                    }
                    num = CastToUInt32(value[index]);

                    uint numValue = aParser.FromChar(num);

                    if (numValue > aParser.MaxDigitValue) {
                        goto HasTrailingChars;
                    }
                    index++;

                    answer = aParser.ShiftLeftForNextDigit(answer);
                    // answer += TInteger.CreateTruncating(numValue);
                    answer = IntegerFormatInfo<TInteger>.AddInt(answer, numValue);
                }

                // If there's another digit, it's an overflow.
                if ((uint)index >= (uint)value.Length) {
                    goto DoneAtEnd;
                }

                num = CastToUInt32(value[index]);

                if (!aParser.IsValidChar(num)) {
                    goto HasTrailingChars;
                }

                // At this point, we're either overflowing or hitting a formatting error.
                // Format errors take precedence for compatibility. Read through any remaining digits.
                do {
                    index++;

                    if ((uint)index >= (uint)value.Length) {
                        goto OverflowExit;
                    }
                    num = CastToUInt32(value[index]);
                } while (aParser.IsValidChar(num));

                overflow = true;
                goto HasTrailingChars;
            }
            goto FalseExit;

        DoneAtEndButPotentialOverflow:
            if (overflow) {
                goto OverflowExit;
            }

        DoneAtEnd:
            result = answer;
            ParsingStatus status = ParsingStatus.OK;

        Exit:
            return status;

        FalseExit: // parsing failed
            result = IntegerFormatInfo<TInteger>.Zero;
            status = ParsingStatus.Failed;
            goto Exit;

        OverflowExit:
            result = IntegerFormatInfo<TInteger>.Zero;
            status = ParsingStatus.Overflow;
            goto Exit;

        HasTrailingChars: // we've successfully parsed, but there are still remaining characters in the span
            // Skip past trailing whitespace, then past trailing zeros, and if anything else remains, fail.
            if (IsWhite(num)) {
                if ((styles & NumberStyles.AllowTrailingWhite) == 0) {
                    goto FalseExit;
                }

                for (index++; index < value.Length; index++) {
                    uint ch = CastToUInt32(value[index]);

                    if (!IsWhite(ch)) {
                        break;
                    }
                }

                if ((uint)index >= (uint)value.Length) {
                    goto DoneAtEndButPotentialOverflow;
                }
            }

            if (!TrailingZeros(value, index)) {
                goto FalseExit;
            }
            goto DoneAtEndButPotentialOverflow;
        }

        internal static decimal ParseDecimal<TChar>(ReadOnlySpan<TChar> value, NumberStyles styles, NumberFormatInfo info)
            where TChar : unmanaged, IEquatable<TChar> {
            ParsingStatus status = TryParseDecimal(value, styles, info, out decimal result);
            if (status != ParsingStatus.OK) {
                if (status == ParsingStatus.Failed) {
                    ThrowFormatException(value);
                }
                ThrowOverflowException(SR.Overflow_Decimal);
            }

            return result;
        }

        internal static bool TryNumberToDecimal(ref NumberBuffer number, ref decimal value) {
            number.CheckConsistency();

            ref byte p = ref number.DigitsPtr;
            int e = number.Scale;
            bool sign = number.IsNegative;
            uint c = p;
            if (c == 0) {
                // To avoid risking an app-compat issue with pre 4.5 (where some app was illegally using Reflection to examine the internal scale bits), we'll only force
                // the scale to 0 if the scale was previously positive (previously, such cases were unparsable to a bug.)
                value = new decimal(0, 0, 0, sign, (byte)BitMath.Clamp(-e, 0, 28));
                return true;
            }

            if (e > DecimalPrecision)
                return false;

            ulong low64 = 0;
            while (e > -28) {
                e--;
                low64 *= 10;
                low64 += c - '0';
                p = ref Unsafe.Add(ref p, 1);
                c = p;
                if (low64 >= ulong.MaxValue / 10)
                    break;
                if (c == 0) {
                    while (e > 0) {
                        e--;
                        low64 *= 10;
                        if (low64 >= ulong.MaxValue / 10)
                            break;
                    }
                    break;
                }
            }

            uint high = 0;
            while ((e > 0 || (c != 0 && e > -28)) &&
              (high < uint.MaxValue / 10 || (high == uint.MaxValue / 10 && (low64 < 0x99999999_99999999 || (low64 == 0x99999999_99999999 && c <= '5'))))) {
                // multiply by 10
                ulong tmpLow = (uint)low64 * 10UL;
                ulong tmp64 = ((uint)(low64 >> 32) * 10UL) + (tmpLow >> 32);
                low64 = (uint)tmpLow + (tmp64 << 32);
                high = (uint)(tmp64 >> 32) + (high * 10);

                if (c != 0) {
                    c -= '0';
                    low64 += c;
                    if (low64 < c)
                        high++;
                    p = ref Unsafe.Add(ref p, 1);
                    c = p;
                }
                e--;
            }

            if (c >= '5') {
                if ((c == '5') && ((low64 & 1) == 0)) {
                    p = ref Unsafe.Add(ref p, 1);
                    c = p;

                    bool hasZeroTail = !number.HasNonZeroTail;

                    // We might still have some additional digits, in which case they need
                    // to be considered as part of hasZeroTail. Some examples of this are:
                    //  * 3.0500000000000000000001e-27
                    //  * 3.05000000000000000000001e-27
                    // In these cases, we will have processed 3 and 0, and ended on 5. The
                    // buffer, however, will still contain a number of trailing zeros and
                    // a trailing non-zero number.

                    while ((c != 0) && hasZeroTail) {
                        hasZeroTail &= c == '0';
                        p = ref Unsafe.Add(ref p, 1);
                        c = p;
                    }

                    // We should either be at the end of the stream or have a non-zero tail
                    Debug.Assert((c == 0) || !hasZeroTail);

                    if (hasZeroTail) {
                        // When the next digit is 5, the number is even, and all following
                        // digits are zero we don't need to round.
                        goto NoRounding;
                    }
                }

                if (++low64 == 0 && ++high == 0) {
                    low64 = 0x99999999_9999999A;
                    high = uint.MaxValue / 10;
                    e++;
                }
            }
        NoRounding:

            if (e > 0)
                return false;

            if (e <= -DecimalPrecision) {
                // Parsing a large scale zero can give you more precision than fits in the decimal.
                // This should only happen for actual zeros or very small numbers that round to zero.
                value = new decimal(0, 0, 0, sign, DecimalPrecision - 1);
            } else {
                value = new decimal((int)low64, (int)(low64 >> 32), (int)high, sign, (byte)-e);
            }
            return true;
        }

        internal static TFloat ParseFloat<TChar, TFloat>(ReadOnlySpan<TChar> value, NumberStyles styles, NumberFormatInfo info)
            where TChar : unmanaged, IEquatable<TChar>
            where TFloat : unmanaged, IComparable<TFloat>
#if GENERICS_MATH
            , IBinaryFloatingPointIeee754<TFloat>
#endif
            {
            if (!TryParseFloat(value, styles, info, out TFloat result)) {
                ThrowFormatException(value);
            }
            return result;
        }

        internal static ParsingStatus TryParseDecimal<TChar>(ReadOnlySpan<TChar> value, NumberStyles styles, NumberFormatInfo info, out decimal result)
            where TChar : unmanaged, IEquatable<TChar> {
            NumberBuffer number = new NumberBuffer(NumberBufferKind.Decimal, stackalloc byte[DecimalNumberBufferLength]);

            result = 0;

            if (!TryStringToNumber(value, styles, ref number, info)) {
                return ParsingStatus.Failed;
            }

            if (!TryNumberToDecimal(ref number, ref result)) {
                return ParsingStatus.Overflow;
            }

            return ParsingStatus.OK;
        }

        internal static bool SpanStartsWith<TChar>(ReadOnlySpan<TChar> span, TChar c)
            where TChar : unmanaged, IEquatable<TChar> {
            return !span.IsEmpty && (span[0].Equals(c));
        }

        internal static bool SpanStartsWith<TChar>(ReadOnlySpan<TChar> span, ReadOnlySpan<TChar> value, StringComparison comparisonType)
            where TChar : unmanaged, IEquatable<TChar> {
            if (typeof(TChar) == typeof(char)) {
                ReadOnlySpan<char> typedSpan = MemoryMarshal.Cast<TChar, char>(span);
                ReadOnlySpan<char> typedValue = MemoryMarshal.Cast<TChar, char>(value);
                return typedSpan.StartsWith(typedValue, comparisonType);
            } else {
                Debug.Assert(typeof(TChar) == typeof(byte));

                ReadOnlySpan<byte> typedSpan = MemoryMarshal.Cast<TChar, byte>(span);
                ReadOnlySpan<byte> typedValue = MemoryMarshal.Cast<TChar, byte>(value);
                return typedSpan.StartsWithUtf8(typedValue, comparisonType);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ReadOnlySpan<TChar> SpanTrim<TChar>(ReadOnlySpan<TChar> span)
            where TChar : unmanaged, IEquatable<TChar> {
            if (typeof(TChar) == typeof(char)) {
                return MemoryMarshal.Cast<char, TChar>(MemoryMarshal.Cast<TChar, char>(span).Trim());
            } else {
                Debug.Assert(typeof(TChar) == typeof(byte));

                return MemoryMarshal.Cast<byte, TChar>(MemoryMarshal.Cast<TChar, byte>(span).TrimUtf8());
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static bool SpanEqualsOrdinalIgnoreCase<TChar>(ReadOnlySpan<TChar> span, ReadOnlySpan<TChar> value)
            where TChar : unmanaged, IEquatable<TChar> {
            if (typeof(TChar) == typeof(char)) {
                ReadOnlySpan<char> typedSpan = MemoryMarshal.Cast<TChar, char>(span);
                ReadOnlySpan<char> typedValue = MemoryMarshal.Cast<TChar, char>(value);
                return typedSpan.EqualsOrdinalIgnoreCase(typedValue);
            } else {
                Debug.Assert(typeof(TChar) == typeof(byte));

                ReadOnlySpan<byte> typedSpan = MemoryMarshal.Cast<TChar, byte>(span);
                ReadOnlySpan<byte> typedValue = MemoryMarshal.Cast<TChar, byte>(value);
                return typedSpan.EqualsOrdinalIgnoreCaseUtf8(typedValue);
            }
        }

        internal static bool TryParseFloat<TChar, TFloat>(ReadOnlySpan<TChar> value, NumberStyles styles, NumberFormatInfo info, out TFloat result)
            where TChar : unmanaged, IEquatable<TChar>
            where TFloat : unmanaged, IComparable<TFloat>
#if GENERICS_MATH
            , IBinaryFloatingPointIeee754<TFloat>
#endif
            {
            NumberBuffer number = new NumberBuffer(NumberBufferKind.FloatingPoint, stackalloc byte[FloatFormatInfo<TFloat>.NumberBufferLength]);

            if (!TryStringToNumber(value, styles, ref number, info)) {
                ReadOnlySpan<TChar> valueTrim = SpanTrim(value);

                // This code would be simpler if we only had the concept of `InfinitySymbol`, but
                // we don't so we'll check the existing cases first and then handle `PositiveSign` +
                // `PositiveInfinitySymbol` and `PositiveSign/NegativeSign` + `NaNSymbol` last.

                ReadOnlySpan<TChar> positiveInfinitySymbol = info.PositiveInfinitySymbolTChar<TChar>();

                if (SpanEqualsOrdinalIgnoreCase(valueTrim, positiveInfinitySymbol)) {
                    result = FloatFormatInfo<TFloat>.PositiveInfinity;
                    return true;
                }

                if (SpanEqualsOrdinalIgnoreCase(valueTrim, info.NegativeInfinitySymbolTChar<TChar>())) {
                    result = FloatFormatInfo<TFloat>.NegativeInfinity;
                    return true;
                }

                ReadOnlySpan<TChar> nanSymbol = info.NaNSymbolTChar<TChar>();

                if (SpanEqualsOrdinalIgnoreCase(valueTrim, nanSymbol)) {
                    result = FloatFormatInfo<TFloat>.NaN;
                    return true;
                }

                var positiveSign = info.PositiveSignTChar<TChar>();

                if (SpanStartsWith(valueTrim, positiveSign, StringComparison.OrdinalIgnoreCase)) {
                    valueTrim = valueTrim.Slice(positiveSign.Length);

                    if (SpanEqualsOrdinalIgnoreCase(valueTrim, positiveInfinitySymbol)) {
                        result = FloatFormatInfo<TFloat>.PositiveInfinity;
                        return true;
                    } else if (SpanEqualsOrdinalIgnoreCase(valueTrim, nanSymbol)) {
                        result = FloatFormatInfo<TFloat>.NaN;
                        return true;
                    }

                    result = FloatFormatInfo<TFloat>.Zero;
                    return false;
                }

                ReadOnlySpan<TChar> negativeSign = info.NegativeSignTChar<TChar>();

                if (SpanStartsWith(valueTrim, negativeSign, StringComparison.OrdinalIgnoreCase)) {
                    if (SpanEqualsOrdinalIgnoreCase(valueTrim.Slice(negativeSign.Length), nanSymbol)) {
                        result = FloatFormatInfo<TFloat>.NaN;
                        return true;
                    }

                    if (info.AllowHyphenDuringParsing() && SpanStartsWith(valueTrim, CastFrom<TChar>('-')) && SpanEqualsOrdinalIgnoreCase(valueTrim.Slice(1), nanSymbol)) {
                        result = FloatFormatInfo<TFloat>.NaN;
                        return true;
                    }
                }

                result = FloatFormatInfo<TFloat>.Zero;
                return false; // We really failed
            }

            result = NumberToFloat<TFloat>(ref number);
            return true;
        }

#if NETCOREAPP1_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        [DoesNotReturn]
#endif // NETCOREAPP1_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        internal static void ThrowOverflowOrFormatException<TChar, TInteger>(ParsingStatus status, ReadOnlySpan<TChar> value)
            where TChar : unmanaged, IEquatable<TChar>
            where TInteger : unmanaged, IComparable<TInteger>
#if GENERICS_MATH
            , IBinaryInteger<TInteger>
#endif // GENERICS_MATH
            {
            if (status == ParsingStatus.Failed) {
                ThrowFormatException(value);
            }
            ThrowOverflowException<TInteger>();
        }

#if NETCOREAPP1_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        [DoesNotReturn]
#endif // NETCOREAPP1_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        internal static void ThrowFormatException<TChar>(ReadOnlySpan<TChar> value)
            where TChar : unmanaged, IEquatable<TChar> {
            string errorMessage;

            if (typeof(TChar) == typeof(byte)) {
                // Decode the UTF8 value into a string we can include in the error message. We're here
                // because we failed to parse, which also means the bytes might not be valid UTF8,
                // so fallback to a message that doesn't include the value if the bytes are invalid.
                // It's possible after we check the bytes for validity that they could be concurrently
                // mutated, but if that's happening, all bets are off, anyway, and it simply impacts
                // which exception is thrown.
                //ReadOnlySpan<byte> bytes = Unsafe.BitCast<ReadOnlySpan<TChar>, ReadOnlySpan<byte>>(value);
                //errorMessage = Utf8.IsValid(bytes) ?
                //    SR.Format(SR.Format_InvalidStringWithValue, Encoding.UTF8.GetString(bytes)) :
                //    SR.Format_InvalidString;
                errorMessage = SR.Format_InvalidString;
            } else {
                errorMessage = string.Format(SR.Format_InvalidStringWithValue, value.ToString());
            }

            throw new FormatException(errorMessage);
        }

#if NETCOREAPP1_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        [DoesNotReturn]
#endif // NETCOREAPP1_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        internal static void ThrowOverflowException<TInteger>()
            where TInteger : unmanaged, IComparable<TInteger>
#if GENERICS_MATH
            , IBinaryInteger<TInteger>
#endif // GENERICS_MATH
            {
            throw new OverflowException(IntegerFormatInfo<TInteger>.OverflowMessage);
        }

#if NETCOREAPP1_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        [DoesNotReturn]
#endif // NETCOREAPP1_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        internal static void ThrowOverflowException(string message) {
            throw new OverflowException(message);
        }

        internal static TFloat NumberToFloat<TFloat>(ref NumberBuffer number)
            where TFloat : unmanaged, IComparable<TFloat>
#if GENERICS_MATH
            , IBinaryFloatingPointIeee754<TFloat>
#endif
            {
            number.CheckConsistency();
            TFloat result;

            if ((number.DigitsCount == 0) || (number.Scale < FloatFormatInfo<TFloat>.MinDecimalExponent)) {
                result = FloatFormatInfo<TFloat>.Zero;
            } else if (number.Scale > FloatFormatInfo<TFloat>.MaxDecimalExponent) {
                result = FloatFormatInfo<TFloat>.PositiveInfinity;
            } else {
                ulong bits = NumberToFloatingPointBits<TFloat>(ref number);
                result = FloatFormatInfo<TFloat>.BitsToFloat(bits);
            }

            return number.IsNegative ?  ExBitUtil.UnaryNegation(result) : result;
        }
    }

}
