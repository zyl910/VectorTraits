#if NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
#define BCL_ATTR_NULL
#endif // NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
#if NET5_0_OR_GREATER
#define BCL_TYPE_HALF
#endif // NET5_0_OR_GREATER
#if NET7_0_OR_GREATER
#define BCL_TYPE_INT128
#define GENERICS_MATH
#endif // NET7_0_OR_GREATER

using System;
using System.Buffers.Binary;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Zyl.VectorTraits.ExTypes.Impl;
using Zyl.VectorTraits.Numerics;

namespace Zyl.VectorTraits.ExTypes
{

    /// <summary>Represents a 128-bit unsigned integer. It is binary compatible with <see cref="UInt128"/> (表示 128 位无符号整数. 它与 <see cref="UInt128"/> 是二进制兼容的).</summary>
    [CLSCompliant(false)]
    [StructLayout(LayoutKind.Sequential)]
    public readonly partial struct ExUInt128: IFormattable, IComparable, IComparable<ExUInt128>, IEquatable<ExUInt128>
#if NET6_0_OR_GREATER
        , ISpanFormattable
#endif // NET6_0_OR_GREATER
#if NET7_0_OR_GREATER
          , IBinaryInteger<ExUInt128>,
          IMinMaxValue<ExUInt128>,
#if NET8_0_OR_GREATER
          IUtf8SpanFormattable,
#endif // NET8_0_OR_GREATER
          // IBinaryIntegerParseAndFormatInfo<ExUInt128>, // internal
          IUnsignedNumber<ExUInt128>
#endif // NET7_0_OR_GREATER
        {
        internal const int Size = 16;

#if BCL_TYPE_INT128
        private readonly UInt128 _data;
#else
        private readonly ulong _data0;
        private readonly ulong _data1;
#endif

        /// <summary>Initializes a new instance of the <see cref="ExUInt128" /> struct.</summary>
        /// <param name="upper">The upper 64-bits of the 128-bit value.</param>
        /// <param name="lower">The lower 64-bits of the 128-bit value.</param>
        [CLSCompliant(false)]
        public ExUInt128(ulong upper, ulong lower) {
#if BCL_TYPE_INT128
            _data = new UInt128(upper, lower);
#else
            if (BitConverter.IsLittleEndian) {
                _data0 = lower;
                _data1 = upper;
            } else {
                _data1 = lower;
                _data0 = upper;
            }
#endif
        }

        /// <summary>
        /// Get the lower half (取得低半部分).
        /// </summary>
        public ulong Lower {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if BCL_TYPE_INT128
                return (ulong)_data;
#else
                if (BitConverter.IsLittleEndian) {
                    return _data0;
                } else {
                    return _data1;
                }
#endif
            }
        }

        /// <summary>
        /// Get the upper half (取得高半部分).
        /// </summary>
        public ulong Upper {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if BCL_TYPE_INT128
                UInt128 temp = _data;
                if (BitConverter.IsLittleEndian) {
                    return Unsafe.Add(ref Unsafe.As<UInt128, ulong>(ref temp), 1);
                } else {
                    return Unsafe.As<UInt128, ulong>(ref temp);
                }
#else
                if (BitConverter.IsLittleEndian) {
                    return _data1;
                } else {
                    return _data0;
                }
#endif
            }
        }

        /// <inheritdoc cref="IComparable.CompareTo(object)" />
        public int CompareTo(object? value) {
            if (value is ExUInt128 other) {
                return CompareTo(other);
#if BCL_TYPE_INT128
            } else if (value is UInt128) {
                return _data.CompareTo((UInt128)value);
#endif
            } else if (value is null) {
                return 1;
            } else {
                throw new ArgumentException(SR.Arg_MustBeExUInt128);
            }
        }

        /// <inheritdoc cref="IComparable{T}.CompareTo(T)" />
        public int CompareTo(ExUInt128 value) {
            if (this < value) {
                return -1;
            } else if (this > value) {
                return 1;
            } else {
                return 0;
            }
        }

        /// <inheritdoc cref="object.Equals(object?)" />
        public override bool Equals(
#if BCL_ATTR_NULL
            [NotNullWhen(true)]
#endif
            object? obj) {
            return (obj is ExUInt128 other) && Equals(other);
        }

        /// <inheritdoc cref="IEquatable{T}.Equals(T)" />
        public bool Equals(ExUInt128 other) {
            return this == other;
        }

        /// <inheritdoc cref="object.GetHashCode()" />
        public override int GetHashCode() {
#if BCL_TYPE_INT128
            return _data.GetHashCode();
#elif NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
            return HashCode.Combine(_data0, _data1);
#else
            return (_data0 ^ _data1).GetHashCode();
#endif
        }

        /// <inheritdoc cref="object.ToString()" />
        public override string ToString() {
#if BCL_TYPE_INT128
            return _data.ToString();
#else
            return Number.ExUInt128ToDecStr(this);
#endif
        }

        /// <inheritdoc cref="UInt128.ToString(IFormatProvider?)" />
        public string ToString(IFormatProvider? provider) {
#if BCL_TYPE_INT128
            return _data.ToString(provider);
#else
            return Number.FormatExUInt128(this, null, provider);
#endif
        }

        /// <inheritdoc cref="UInt128.ToString(string?)" />
        public string ToString(
#if NET7_0_OR_GREATER
            [StringSyntax(StringSyntaxAttribute.NumericFormat)]
#endif // NET7_0_OR_GREATER
            string? format) {
#if BCL_TYPE_INT128
            return _data.ToString(format);
#else
            return Number.FormatExUInt128(this, format, null);
#endif
        }

        /// <inheritdoc cref="UInt128.ToString(string?, IFormatProvider?)" />
        public string ToString(
#if NET7_0_OR_GREATER
            [StringSyntax(StringSyntaxAttribute.NumericFormat)]
#endif // NET7_0_OR_GREATER
            string? format, IFormatProvider? provider) {
#if BCL_TYPE_INT128
            return _data.ToString(format, provider);
#else
            return Number.FormatExUInt128(this, format, provider);
#endif
        }

        /// <inheritdoc cref="UInt128.TryFormat(Span{char}, out int, ReadOnlySpan{char}, IFormatProvider?)" />
        public bool TryFormat(Span<char> destination, out int charsWritten,
#if NET7_0_OR_GREATER
            [StringSyntax(StringSyntaxAttribute.NumericFormat)]
#endif // NET7_0_OR_GREATER
            ReadOnlySpan<char> format = default, IFormatProvider? provider = null) {
#if BCL_TYPE_INT128
            return _data.TryFormat(destination, out charsWritten, format, provider);
#else
            return Number.TryFormatExUInt128(this, format, provider, destination, out charsWritten);
#endif
        }

        /// <inheritdoc cref="IUtf8SpanFormattable.TryFormat" />
        public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten,
#if NET7_0_OR_GREATER
            [StringSyntax(StringSyntaxAttribute.NumericFormat)]
#endif // NET7_0_OR_GREATER
            ReadOnlySpan<char> format = default, IFormatProvider? provider = null) {
#if BCL_TYPE_INT128 && NET8_0_OR_GREATER
            return _data.TryFormat(utf8Destination, out bytesWritten, format, provider);
#else
            return Number.TryFormatExUInt128(this, format, provider, utf8Destination, out bytesWritten);
#endif
        }

        /// <inheritdoc cref="UInt128.Parse(string)" />
        public static ExUInt128 Parse(string s) => Parse(s, NumberStyles.Integer, provider: null);

        /// <inheritdoc cref="UInt128.Parse(string, NumberStyles)" />
        public static ExUInt128 Parse(string s, NumberStyles style) => Parse(s, style, provider: null);

        /// <inheritdoc cref="UInt128.Parse(string, IFormatProvider?)" />
        public static ExUInt128 Parse(string s, IFormatProvider? provider) => Parse(s, NumberStyles.Integer, provider);

        /// <inheritdoc cref="UInt128.Parse(string, NumberStyles, IFormatProvider?)" />
        public static ExUInt128 Parse(string s, NumberStyles style, IFormatProvider? provider) {
#if BCL_TYPE_INT128
            return UInt128.Parse(s, style, provider);
#else
            if (s is null) { throw new ArgumentNullException(nameof(s)); }
            return Parse(s.AsSpan(), style, provider);
#endif
        }

        /// <inheritdoc cref="UInt128.Parse(ReadOnlySpan{char}, NumberStyles, IFormatProvider?)" />
        public static ExUInt128 Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.Integer, IFormatProvider? provider = null) {
#if BCL_TYPE_INT128
            return UInt128.Parse(s, style, provider);
#else
            ExNumberFormatInfo.ValidateParseStyleInteger(style);
            return Number.ParseBinaryInteger<char, ExUInt128>(s, style, NumberFormatInfo.GetInstance(provider));
#endif
        }

        /// <inheritdoc cref="UInt128.TryParse(string?, out UInt128)" />
        public static bool TryParse(
#if BCL_ATTR_NULL
            [NotNullWhen(true)]
#endif
            string? s, out ExUInt128 result) => TryParse(s, NumberStyles.Integer, provider: null, out result);

        /// <inheritdoc cref="UInt128.TryParse(ReadOnlySpan{char}, out UInt128)" />
        public static bool TryParse(ReadOnlySpan<char> s, out ExUInt128 result) => TryParse(s, NumberStyles.Integer, provider: null, out result);

        /// <inheritdoc cref="UInt128.TryParse(ReadOnlySpan{byte}, out UInt128)" />
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, out ExUInt128 result) => TryParse(utf8Text, NumberStyles.Integer, provider: null, out result);

        /// <inheritdoc cref="UInt128.TryParse(string?, NumberStyles, IFormatProvider?, out UInt128)" />
        public static bool TryParse(
#if BCL_ATTR_NULL
            [NotNullWhen(true)]
#endif
            string? s, NumberStyles style, IFormatProvider? provider, out ExUInt128 result) {
#if BCL_TYPE_INT128
            bool flag = UInt128.TryParse(s, style, provider, out var rt);
            result = rt;
            return flag;
#else
            ExNumberFormatInfo.ValidateParseStyleInteger(style);

            if (s is null) {
                result = 0;
                return false;
            }
            return Number.TryParseBinaryInteger(s.AsSpan(), style, NumberFormatInfo.GetInstance(provider), out result) == Number.ParsingStatus.OK;
#endif
        }

        /// <inheritdoc cref="UInt128.TryParse(ReadOnlySpan{char}, NumberStyles, IFormatProvider?, out UInt128)" />
        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider, out ExUInt128 result) {
#if BCL_TYPE_INT128
            bool flag = UInt128.TryParse(s, style, provider, out var rt);
            result = rt;
            return flag;
#else
            ExNumberFormatInfo.ValidateParseStyleInteger(style);
            return Number.TryParseBinaryInteger(s, style, NumberFormatInfo.GetInstance(provider), out result) == Number.ParsingStatus.OK;
#endif
        }

        //
        // Explicit Conversions From ExUInt128
        //

        /// <summary>Explicitly converts a 128-bit unsigned integer to a <see cref="byte" /> value.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="byte" />.</returns>
        public static explicit operator byte(ExUInt128 value) {
#if BCL_TYPE_INT128
            return (byte)value._data;
#else
            return (byte)value.Lower;
#endif
        }

        /// <summary>Explicitly converts a 128-bit unsigned integer to a <see cref="byte" /> value, throwing an overflow exception for any values that fall outside the representable range.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="byte" />.</returns>
        /// <exception cref="OverflowException"><paramref name="value" /> is not representable by <see cref="ExUInt128" />.</exception>
        public static explicit operator checked byte(ExUInt128 value) {
#if BCL_TYPE_INT128
            return checked((byte)value._data);
#else
            if (value.Upper != 0) {
                ThrowHelper.ThrowOverflowException();
            }
            return checked((byte)value.Lower);
#endif
        }

        /// <summary>Explicitly converts a 128-bit unsigned integer to a <see cref="char" /> value.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="char" />.</returns>
        public static explicit operator char(ExUInt128 value) {
#if BCL_TYPE_INT128
            return (char)value._data;
#else
            return (char)value.Lower;
#endif
        }

        /// <summary>Explicitly converts a 128-bit unsigned integer to a <see cref="char" /> value, throwing an overflow exception for any values that fall outside the representable range.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="char" />.</returns>
        /// <exception cref="OverflowException"><paramref name="value" /> is not representable by <see cref="ExUInt128" />.</exception>
        public static explicit operator checked char(ExUInt128 value) {
#if BCL_TYPE_INT128
            return checked((char)value._data);
#else
            if (value.Upper != 0) {
                ThrowHelper.ThrowOverflowException();
            }
            return checked((char)value.Lower);
#endif
        }

        /// <summary>Explicitly converts a 128-bit unsigned integer to a <see cref="decimal" /> value.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="decimal" />.</returns>
        public static explicit operator decimal(ExUInt128 value) {
#if BCL_TYPE_INT128
            return (decimal)value._data;
#else
            ulong lo64 = value.Lower;

            if (value.Upper > uint.MaxValue) {
                // The default behavior of decimal conversions is to always throw on overflow
                Number.ThrowOverflowException(SR.Overflow_Decimal);
            }

            uint hi32 = (uint)(value.Upper);

            return new decimal((int)(lo64), (int)(lo64 >> 32), (int)(hi32), isNegative: false, scale: 0);
#endif
        }

        /// <summary>Explicitly converts a 128-bit unsigned integer to a <see cref="double" /> value.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="double" />.</returns>
        public static explicit operator double(ExUInt128 value) {
#if BCL_TYPE_INT128
            return (double)value._data;
#else
            // This code is based on `u128_to_f64_round` from m-ou-se/floatconv
            // Copyright (c) 2020 Mara Bos <m-ou.se@m-ou.se>. All rights reserved.
            //
            // Licensed under the BSD 2 - Clause "Simplified" License
            // See THIRD-PARTY-NOTICES.TXT for the full license text

            const double TwoPow52 = 4503599627370496.0;
            const double TwoPow76 = 75557863725914323419136.0;
            const double TwoPow104 = 20282409603651670423947251286016.0;
            const double TwoPow128 = 340282366920938463463374607431768211456.0;

            const ulong TwoPow52Bits = 0x4330000000000000;
            const ulong TwoPow76Bits = 0x44B0000000000000;
            const ulong TwoPow104Bits = 0x4670000000000000;
            const ulong TwoPow128Bits = 0x47F0000000000000;

            if (value.Upper == 0) {
                // For values between 0 and ulong.MaxValue, we just use the existing conversion
                return (double)(value.Lower);
            } else if ((value.Upper >> 24) == 0) // value < (2^104)
              {
                // For values greater than ulong.MaxValue but less than 2^104 this takes advantage
                // that we can represent both "halves" of the uint128 within the 52-bit mantissa of
                // a pair of doubles.

                double lower = MathBitConverter.UInt64BitsToDouble(TwoPow52Bits | ((value.Lower << 12) >> 12)) - TwoPow52;
                double upper = MathBitConverter.UInt64BitsToDouble(TwoPow104Bits | (ulong)(value >> 52)) - TwoPow104;

                return lower + upper;
            } else {
                // For values greater than 2^104 we basically do the same as before but we need to account
                // for the precision loss that double will have. As such, the lower value effectively drops the
                // lowest 24 bits and then or's them back to ensure rounding stays correct.

                double lower = MathBitConverter.UInt64BitsToDouble(TwoPow76Bits | ((ulong)(value >> 12) >> 12) | (value.Lower & 0xFFFFFF)) - TwoPow76;
                double upper = MathBitConverter.UInt64BitsToDouble(TwoPow128Bits | (ulong)(value >> 76)) - TwoPow128;

                return lower + upper;
            }
#endif
        }

#if BCL_TYPE_HALF
        /// <summary>Explicitly converts a 128-bit unsigned integer to a <see cref="Half" /> value.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="Half" />.</returns>
        public static explicit operator Half(ExUInt128 value) {
#if BCL_TYPE_INT128
            return (Half)value._data;
#else
            return (Half)(double)(value);
#endif
        }
#endif

        /// <summary>Explicitly converts a 128-bit unsigned integer to a <see cref="short" /> value.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="short" />.</returns>
        public static explicit operator short(ExUInt128 value) {
#if BCL_TYPE_INT128
            return (short)value._data;
#else
            return (short)value.Lower;
#endif
        }

        /// <summary>Explicitly converts a 128-bit unsigned integer to a <see cref="short" /> value, throwing an overflow exception for any values that fall outside the representable range.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="short" />.</returns>
        /// <exception cref="OverflowException"><paramref name="value" /> is not representable by <see cref="ExUInt128" />.</exception>
        public static explicit operator checked short(ExUInt128 value) {
#if BCL_TYPE_INT128
            return checked((short)value._data);
#else
            if (value.Upper != 0) {
                ThrowHelper.ThrowOverflowException();
            }
            return checked((short)value.Lower);
#endif
        }

        /// <summary>Explicitly converts a 128-bit unsigned integer to a <see cref="int" /> value.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="int" />.</returns>
        public static explicit operator int(ExUInt128 value) {
#if BCL_TYPE_INT128
            return (int)value._data;
#else
            return (int)value.Lower;
#endif
        }

        /// <summary>Explicitly converts a 128-bit unsigned integer to a <see cref="int" /> value, throwing an overflow exception for any values that fall outside the representable range.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="int" />.</returns>
        /// <exception cref="OverflowException"><paramref name="value" /> is not representable by <see cref="ExUInt128" />.</exception>
        public static explicit operator checked int(ExUInt128 value) {
#if BCL_TYPE_INT128
            return checked((int)value._data);
#else
            if (value.Upper != 0) {
                ThrowHelper.ThrowOverflowException();
            }
            return checked((int)value.Lower);
#endif
        }

        /// <summary>Explicitly converts a 128-bit unsigned integer to a <see cref="long" /> value.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="long" />.</returns>
        public static explicit operator long(ExUInt128 value) {
#if BCL_TYPE_INT128
            return (long)value._data;
#else
            return (long)value.Lower;
#endif
        }

        /// <summary>Explicitly converts a 128-bit unsigned integer to a <see cref="long" /> value, throwing an overflow exception for any values that fall outside the representable range.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="long" />.</returns>
        /// <exception cref="OverflowException"><paramref name="value" /> is not representable by <see cref="ExUInt128" />.</exception>
        public static explicit operator checked long(ExUInt128 value) {
#if BCL_TYPE_INT128
            return checked((long)value._data);
#else
            if (value.Upper != 0) {
                ThrowHelper.ThrowOverflowException();
            }
            return checked((long)value.Lower);
#endif
        }

        /// <summary>Explicitly converts a 128-bit unsigned integer to a <see cref="ExInt128" /> value.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="ExInt128" />.</returns>
        [CLSCompliant(false)]
        public static explicit operator ExInt128(ExUInt128 value) {
            return Unsafe.As<ExUInt128, ExInt128>(ref value);
        }

        /// <summary>Explicitly converts a 128-bit unsigned integer to a <see cref="ExInt128" /> value, throwing an overflow exception for any values that fall outside the representable range.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="ExInt128" />.</returns>
        /// <exception cref="OverflowException"><paramref name="value" /> is not representable by <see cref="ExUInt128" />.</exception>
        [CLSCompliant(false)]
        public static explicit operator checked ExInt128(ExUInt128 value) {
#if BCL_TYPE_INT128
            return checked((Int128)value._data);
#else
            if ((long)value.Upper < 0) {
                ThrowHelper.ThrowOverflowException();
            }
            return Unsafe.As<ExUInt128, ExInt128>(ref value);
#endif
        }

        /// <summary>Explicitly converts a 128-bit unsigned integer to a <see cref="IntPtr" /> value.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="IntPtr" />.</returns>
        public static explicit operator nint(ExUInt128 value) {
#if BCL_TYPE_INT128
            return (nint)value._data;
#else
            return (nint)value.Lower;
#endif
        }

        /// <summary>Explicitly converts a 128-bit unsigned integer to a <see cref="IntPtr" /> value, throwing an overflow exception for any values that fall outside the representable range.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="IntPtr" />.</returns>
        /// <exception cref="OverflowException"><paramref name="value" /> is not representable by <see cref="ExUInt128" />.</exception>
        public static explicit operator checked nint(ExUInt128 value) {
#if BCL_TYPE_INT128
            return checked((nint)value._data);
#else
            if (value.Upper != 0) {
                ThrowHelper.ThrowOverflowException();
            }
            return checked((nint)value.Lower);
#endif
        }

        /// <summary>Explicitly converts a 128-bit unsigned integer to a <see cref="sbyte" /> value.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="sbyte" />.</returns>
        [CLSCompliant(false)]
        public static explicit operator sbyte(ExUInt128 value) {
#if BCL_TYPE_INT128
            return (sbyte)value._data;
#else
            return (sbyte)value.Lower;
#endif
        }

        /// <summary>Explicitly converts a 128-bit unsigned integer to a <see cref="sbyte" /> value, throwing an overflow exception for any values that fall outside the representable range.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="sbyte" />.</returns>
        /// <exception cref="OverflowException"><paramref name="value" /> is not representable by <see cref="ExUInt128" />.</exception>
        [CLSCompliant(false)]
        public static explicit operator checked sbyte(ExUInt128 value) {
#if BCL_TYPE_INT128
            return checked((sbyte)value._data);
#else
            if (value.Upper != 0) {
                ThrowHelper.ThrowOverflowException();
            }
            return checked((sbyte)value.Lower);
#endif
        }

        /// <summary>Explicitly converts a 128-bit unsigned integer to a <see cref="float" /> value.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="float" />.</returns>
        public static explicit operator float(ExUInt128 value) {
#if BCL_TYPE_INT128
            return (float)value._data;
#else
            return (float)(double)value.Lower;
#endif
        }

        /// <summary>Explicitly converts a 128-bit unsigned integer to a <see cref="ushort" /> value.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="ushort" />.</returns>
        [CLSCompliant(false)]
        public static explicit operator ushort(ExUInt128 value) {
#if BCL_TYPE_INT128
            return (ushort)value._data;
#else
            return (ushort)value.Lower;
#endif
        }

        /// <summary>Explicitly converts a 128-bit unsigned integer to a <see cref="ushort" /> value, throwing an overflow exception for any values that fall outside the representable range.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="ushort" />.</returns>
        /// <exception cref="OverflowException"><paramref name="value" /> is not representable by <see cref="ExUInt128" />.</exception>
        [CLSCompliant(false)]
        public static explicit operator checked ushort(ExUInt128 value) {
#if BCL_TYPE_INT128
            return checked((ushort)value._data);
#else
            if (value.Upper != 0) {
                ThrowHelper.ThrowOverflowException();
            }
            return checked((ushort)value.Lower);
#endif
        }

        /// <summary>Explicitly converts a 128-bit unsigned integer to a <see cref="uint" /> value.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="uint" />.</returns>
        [CLSCompliant(false)]
        public static explicit operator uint(ExUInt128 value) {
#if BCL_TYPE_INT128
            return (uint)value._data;
#else
            return (uint)value.Lower;
#endif
        }

        /// <summary>Explicitly converts a 128-bit unsigned integer to a <see cref="uint" /> value, throwing an overflow exception for any values that fall outside the representable range.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="uint" />.</returns>
        /// <exception cref="OverflowException"><paramref name="value" /> is not representable by <see cref="ExUInt128" />.</exception>
        [CLSCompliant(false)]
        public static explicit operator checked uint(ExUInt128 value) {
#if BCL_TYPE_INT128
            return checked((uint)value._data);
#else
            if (value.Upper != 0) {
                ThrowHelper.ThrowOverflowException();
            }
            return checked((uint)value.Lower);
#endif
        }

        /// <summary>Explicitly converts a 128-bit unsigned integer to a <see cref="ulong" /> value.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="ulong" />.</returns>
        [CLSCompliant(false)]
        public static explicit operator ulong(ExUInt128 value) {
#if BCL_TYPE_INT128
            return (ulong)value._data;
#else
            return value.Lower;
#endif
        }

        /// <summary>Explicitly converts a 128-bit unsigned integer to a <see cref="ulong" /> value, throwing an overflow exception for any values that fall outside the representable range.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="ulong" />.</returns>
        /// <exception cref="OverflowException"><paramref name="value" /> is not representable by <see cref="ExUInt128" />.</exception>
        [CLSCompliant(false)]
        public static explicit operator checked ulong(ExUInt128 value) {
#if BCL_TYPE_INT128
            return checked((ulong)value._data);
#else
            if (value.Upper != 0) {
                ThrowHelper.ThrowOverflowException();
            }
            return value.Lower;
#endif
        }

        /// <summary>Explicitly converts a 128-bit unsigned integer to a <see cref="UIntPtr" /> value.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="UIntPtr" />.</returns>
        [CLSCompliant(false)]
        public static explicit operator nuint(ExUInt128 value) {
#if BCL_TYPE_INT128
            return (nuint)value._data;
#else
            return (nuint)value.Lower;
#endif
        }

        /// <summary>Explicitly converts a 128-bit unsigned integer to a <see cref="UIntPtr" /> value, throwing an overflow exception for any values that fall outside the representable range.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="UIntPtr" />.</returns>
        /// <exception cref="OverflowException"><paramref name="value" /> is not representable by <see cref="ExUInt128" />.</exception>
        [CLSCompliant(false)]
        public static explicit operator checked nuint(ExUInt128 value) {
#if BCL_TYPE_INT128
            return checked((nuint)value._data);
#else
            if (value.Upper != 0) {
                ThrowHelper.ThrowOverflowException();
            }
            return checked((nuint)value.Lower);
#endif
        }

        //
        // Explicit Conversions To ExUInt128
        //

        /// <summary>Explicitly converts a <see cref="decimal" /> value to a 128-bit unsigned integer.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit unsigned integer.</returns>
        public static explicit operator ExUInt128(decimal value) {
#if BCL_TYPE_INT128
            return (UInt128)(value);
#else
            value = decimal.Truncate(value);

            if (value < 0.0m) {
                ThrowHelper.ThrowOverflowException();
            }
            ulong low64 = ExBitUtil.DecodeDecimalOn64(value, out uint high);
            return new ExUInt128(high, low64);
#endif
        }

        /// <summary>Explicitly converts a <see cref="double" /> value to a 128-bit unsigned integer.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit unsigned integer.</returns>
        public static explicit operator ExUInt128(double value) {
#if BCL_TYPE_INT128
            return (UInt128)(value);
#else
            const double TwoPow128 = 340282366920938463463374607431768211456.0;

            if (BitMath.IsNegative(value) || double.IsNaN(value)) {
                return MinValue;
            } else if (value >= TwoPow128) {
                return MaxValue;
            }

            return ToExUInt128(value);
#endif
        }

        /// <summary>Explicitly converts a <see cref="double" /> value to a 128-bit unsigned integer, throwing an overflow exception for any values that fall outside the representable range.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit unsigned integer.</returns>
        /// <exception cref="OverflowException"><paramref name="value" /> is not representable by <see cref="ExUInt128" />.</exception>
        public static explicit operator checked ExUInt128(double value) {
#if BCL_TYPE_INT128
            return checked((UInt128)(value));
#else
            const double TwoPow128 = 340282366920938463463374607431768211456.0;

            // We need to convert -0.0 to 0 and not throw, so we compare
            // value against 0 rather than checking IsNegative

            if ((value < 0.0) || double.IsNaN(value) || (value >= TwoPow128)) {
                ThrowHelper.ThrowOverflowException();
            }

            return ToExUInt128(value);
#endif
        }

        internal static ExUInt128 ToExUInt128(double value) {
#if BCL_TYPE_INT128
            return (UInt128)(value);
#else
            const double TwoPow128 = 340282366920938463463374607431768211456.0;

            Debug.Assert(value >= 0);
            Debug.Assert(BitMath.IsFinite(value));
            Debug.Assert(value < TwoPow128);

            // This code is based on `f64_to_u128` from m-ou-se/floatconv
            // Copyright (c) 2020 Mara Bos <m-ou.se@m-ou.se>. All rights reserved.
            //
            // Licensed under the BSD 2 - Clause "Simplified" License
            // See THIRD-PARTY-NOTICES.TXT for the full license text

            if (value >= 1.0) {
                // In order to convert from double to uint128 we first need to extract the signficand,
                // including the implicit leading bit, as a full 128-bit significand. We can then adjust
                // this down to the represented integer by right shifting by the unbiased exponent, taking
                // into account the significand is now represented as 128-bits.

                ulong bits = MathBitConverter.DoubleToUInt64Bits(value);
                ExUInt128 result = new ExUInt128((bits << 12) >> 1 | 0x8000_0000_0000_0000, 0x0000_0000_0000_0000);

                result >>= (1023 + 128 - 1 - (int)(bits >> 52));
                return result;
            } else {
                return MinValue;
            }
#endif
        }

        /// <summary>Explicitly converts a <see cref="short" /> value to a 128-bit unsigned integer.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit unsigned integer.</returns>
        public static explicit operator ExUInt128(short value) {
#if BCL_TYPE_INT128
            return (UInt128)(value);
#else
            long lower = value;
            return new ExUInt128((ulong)(lower >> 63), (ulong)lower);
#endif
        }

        /// <summary>Explicitly converts a <see cref="short" /> value to a 128-bit unsigned integer, throwing an overflow exception for any values that fall outside the representable range.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit unsigned integer.</returns>
        /// <exception cref="OverflowException"><paramref name="value" /> is not representable by <see cref="ExUInt128" />.</exception>
        public static explicit operator checked ExUInt128(short value) {
#if BCL_TYPE_INT128
            return checked((UInt128)(value));
#else
            if (value < 0) {
                ThrowHelper.ThrowOverflowException();
            }
            return new ExUInt128(0, (ushort)value);
#endif
        }

        /// <summary>Explicitly converts a <see cref="int" /> value to a 128-bit unsigned integer.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit unsigned integer.</returns>
        public static explicit operator ExUInt128(int value) {
#if BCL_TYPE_INT128
            return (UInt128)(value);
#else
            long lower = value;
            return new ExUInt128((ulong)(lower >> 63), (ulong)lower);
#endif
        }

        /// <summary>Explicitly converts a <see cref="int" /> value to a 128-bit unsigned integer, throwing an overflow exception for any values that fall outside the representable range.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit unsigned integer.</returns>
        /// <exception cref="OverflowException"><paramref name="value" /> is not representable by <see cref="ExUInt128" />.</exception>
        public static explicit operator checked ExUInt128(int value) {
#if BCL_TYPE_INT128
            return checked((UInt128)(value));
#else
            if (value < 0) {
                ThrowHelper.ThrowOverflowException();
            }
            return new ExUInt128(0, (uint)value);
#endif
        }

        /// <summary>Explicitly converts a <see cref="long" /> value to a 128-bit unsigned integer.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit unsigned integer.</returns>
        public static explicit operator ExUInt128(long value) {
#if BCL_TYPE_INT128
            return (UInt128)(value);
#else
            long lower = value;
            return new ExUInt128((ulong)(lower >> 63), (ulong)lower);
#endif
        }

        /// <summary>Explicitly converts a <see cref="long" /> value to a 128-bit unsigned integer, throwing an overflow exception for any values that fall outside the representable range.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit unsigned integer.</returns>
        /// <exception cref="OverflowException"><paramref name="value" /> is not representable by <see cref="ExUInt128" />.</exception>
        public static explicit operator checked ExUInt128(long value) {
#if BCL_TYPE_INT128
            return checked((UInt128)(value));
#else
            if (value < 0) {
                ThrowHelper.ThrowOverflowException();
            }
            return new ExUInt128(0, (ulong)value);
#endif
        }

        /// <summary>Explicitly converts a <see cref="IntPtr" /> value to a 128-bit unsigned integer.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit unsigned integer.</returns>
        public static explicit operator ExUInt128(nint value) {
#if BCL_TYPE_INT128
            return (UInt128)(value);
#else
            long lower = value;
            return new ExUInt128((ulong)(lower >> 63), (ulong)lower);
#endif
        }

        /// <summary>Explicitly converts a <see cref="IntPtr" /> value to a 128-bit unsigned integer, throwing an overflow exception for any values that fall outside the representable range.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit unsigned integer.</returns>
        /// <exception cref="OverflowException"><paramref name="value" /> is not representable by <see cref="ExUInt128" />.</exception>
        public static explicit operator checked ExUInt128(nint value) {
#if BCL_TYPE_INT128
            return checked((UInt128)(value));
#else
            if (value < 0) {
                ThrowHelper.ThrowOverflowException();
            }
            return new ExUInt128(0, (nuint)value);
#endif
        }

        /// <summary>Explicitly converts a <see cref="sbyte" /> value to a 128-bit unsigned integer.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit unsigned integer.</returns>
        [CLSCompliant(false)]
        public static explicit operator ExUInt128(sbyte value) {
#if BCL_TYPE_INT128
            return (UInt128)(value);
#else
            long lower = value;
            return new ExUInt128((ulong)(lower >> 63), (ulong)lower);
#endif
        }

        /// <summary>Explicitly converts a <see cref="sbyte" /> value to a 128-bit unsigned integer, throwing an overflow exception for any values that fall outside the representable range.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit unsigned integer.</returns>
        /// <exception cref="OverflowException"><paramref name="value" /> is not representable by <see cref="ExUInt128" />.</exception>
        [CLSCompliant(false)]
        public static explicit operator checked ExUInt128(sbyte value) {
#if BCL_TYPE_INT128
            return checked((UInt128)(value));
#else
            if (value < 0) {
                ThrowHelper.ThrowOverflowException();
            }
            return new ExUInt128(0, (byte)value);
#endif
        }

        /// <summary>Explicitly converts a <see cref="float" /> value to a 128-bit unsigned integer.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit unsigned integer.</returns>
        public static explicit operator ExUInt128(float value) {
#if BCL_TYPE_INT128
            return (UInt128)(value);
#else
            return (ExUInt128)(double)(value);
#endif
        }

        /// <summary>Explicitly converts a <see cref="float" /> value to a 128-bit unsigned integer, throwing an overflow exception for any values that fall outside the representable range.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit unsigned integer.</returns>
        /// <exception cref="OverflowException"><paramref name="value" /> is not representable by <see cref="ExUInt128" />.</exception>
        public static explicit operator checked ExUInt128(float value) {
#if BCL_TYPE_INT128
            return checked((UInt128)(value));
#else
            return checked((ExUInt128)(double)(value));
#endif
        }

        //
        // Implicit Conversions To ExUInt128
        //

        /// <summary>Implicitly converts a <see cref="byte" /> value to a 128-bit unsigned integer.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit unsigned integer.</returns>
        public static implicit operator ExUInt128(byte value) => new ExUInt128(0, value);

        /// <summary>Implicitly converts a <see cref="char" /> value to a 128-bit unsigned integer.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit unsigned integer.</returns>
        public static implicit operator ExUInt128(char value) => new ExUInt128(0, value);

        /// <summary>Implicitly converts a <see cref="ushort" /> value to a 128-bit unsigned integer.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit unsigned integer.</returns>
        [CLSCompliant(false)]
        public static implicit operator ExUInt128(ushort value) => new ExUInt128(0, value);

        /// <summary>Implicitly converts a <see cref="uint" /> value to a 128-bit unsigned integer.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit unsigned integer.</returns>
        [CLSCompliant(false)]
        public static implicit operator ExUInt128(uint value) => new ExUInt128(0, value);

        /// <summary>Implicitly converts a <see cref="ulong" /> value to a 128-bit unsigned integer.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit unsigned integer.</returns>
        [CLSCompliant(false)]
        public static implicit operator ExUInt128(ulong value) => new ExUInt128(0, value);

        /// <summary>Implicitly converts a <see cref="UIntPtr" /> value to a 128-bit unsigned integer.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit unsigned integer.</returns>
        [CLSCompliant(false)]
        public static implicit operator ExUInt128(nuint value) => new ExUInt128(0, value);

        private void WriteLittleEndianUnsafe(Span<byte> destination) {
            Debug.Assert(destination.Length >= Size);

            ulong lower = Lower;
            ulong upper = Upper;

            if (!BitConverter.IsLittleEndian) {
                lower = BinaryPrimitives.ReverseEndianness(lower);
                upper = BinaryPrimitives.ReverseEndianness(upper);
            }

            ref byte address = ref MemoryMarshal.GetReference(destination);

            Unsafe.WriteUnaligned(ref address, lower);
            Unsafe.WriteUnaligned(ref Unsafe.AddByteOffset(ref address, (nint)sizeof(ulong)), upper);
        }

        //
        // IAdditionOperators
        //

        /// <inheritdoc cref="IAdditionOperators{TSelf, TOther, TResult}.op_Addition(TSelf, TOther)" />
        public static ExUInt128 operator +(ExUInt128 left, ExUInt128 right) {
#if BCL_TYPE_INT128
            return left._data + right._data;
#else
            // For unsigned addition, we can detect overflow by checking `(x + y) < x`
            // This gives us the carry to add to upper to compute the correct result

            ulong lower = left.Lower + right.Lower;
            ulong carry = (lower < left.Lower) ? 1UL : 0UL;

            ulong upper = left.Upper + right.Upper + carry;
            return new ExUInt128(upper, lower);
#endif
        }

        /// <inheritdoc cref="IAdditionOperators{TSelf, TOther, TResult}.op_Addition(TSelf, TOther)" />
        public static ExUInt128 operator checked +(ExUInt128 left, ExUInt128 right) {
#if BCL_TYPE_INT128
            return checked(left._data + right._data);
#else
            // For unsigned addition, we can detect overflow by checking `(x + y) < x`
            // This gives us the carry to add to upper to compute the correct result

            ulong lower = left.Lower + right.Lower;
            ulong carry = (lower < left.Lower) ? 1UL : 0UL;

            ulong upper = checked(left.Upper + right.Upper + carry);
            return new ExUInt128(upper, lower);
#endif
        }

        //
        // IAdditiveIdentity
        //

#if GENERICS_MATH
        /// <inheritdoc cref="IAdditiveIdentity{TSelf, TResult}.AdditiveIdentity" />
        static ExUInt128 IAdditiveIdentity<ExUInt128, ExUInt128>.AdditiveIdentity => default;
#endif

        //
        // IBinaryInteger
        //

        /// <inheritdoc cref="IBinaryInteger{TSelf}.DivRem(TSelf, TSelf)" />
        public static (ExUInt128 Quotient, ExUInt128 Remainder) DivRem(ExUInt128 left, ExUInt128 right) {
#if BCL_TYPE_INT128
            return UInt128.DivRem(left._data, right._data);
#else
            ExUInt128 quotient = left / right;
            return (quotient, left - (quotient * right));
#endif
        }

        /// <inheritdoc cref="IBinaryInteger{TSelf}.LeadingZeroCount(TSelf)" />
        public static ExUInt128 LeadingZeroCount(ExUInt128 value) {
#if BCL_TYPE_INT128
            return UInt128.LeadingZeroCount(value._data);
#else
            return (uint)LeadingZeroCountAsInt32(value);
#endif
        }

        /// <summary>Computes the number of leading zero bits in this value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static int LeadingZeroCountAsInt32(ExUInt128 value) {
            if (value.Upper == 0) {
                return 64 + MathBitOperations.LeadingZeroCount(value.Lower);
            }
            return MathBitOperations.LeadingZeroCount(value.Upper);
        }

        /// <inheritdoc cref="IBinaryInteger{TSelf}.PopCount(TSelf)" />
        public static ExUInt128 PopCount(ExUInt128 value) {
#if BCL_TYPE_INT128
            return UInt128.PopCount(value._data);
#else
            return (ExUInt128)(MathBitOperations.PopCount(value.Lower) + MathBitOperations.PopCount(value.Upper));
#endif
        }

        /// <inheritdoc cref="IBinaryInteger{TSelf}.RotateLeft(TSelf, int)" />
        public static ExUInt128 RotateLeft(ExUInt128 value, int rotateAmount) {
#if BCL_TYPE_INT128
            return UInt128.RotateLeft(value._data, rotateAmount);
#else
            return (value << rotateAmount) | (value >>> (128 - rotateAmount));
#endif
        }

        /// <inheritdoc cref="IBinaryInteger{TSelf}.RotateRight(TSelf, int)" />
        public static ExUInt128 RotateRight(ExUInt128 value, int rotateAmount) {
#if BCL_TYPE_INT128
            return UInt128.RotateRight(value._data, rotateAmount);
#else
            return (value >>> rotateAmount) | (value << (128 - rotateAmount));
#endif
        }

        /// <inheritdoc cref="IBinaryInteger{TSelf}.TrailingZeroCount(TSelf)" />
        public static ExUInt128 TrailingZeroCount(ExUInt128 value) {
#if BCL_TYPE_INT128
            return UInt128.TrailingZeroCount(value._data);
#else
            if (value.Lower == 0) {
                return (ExUInt128)(64 + MathBitOperations.TrailingZeroCount(value.Upper));
            }
            return (ExUInt128)MathBitOperations.TrailingZeroCount(value.Lower);
#endif
        }

        /// <inheritdoc cref="IBinaryInteger{TSelf}.TryReadBigEndian(ReadOnlySpan{byte}, bool, out TSelf)" />
        public static bool TryReadBigEndian(ReadOnlySpan<byte> source, bool isUnsigned, out ExUInt128 value) {
#if BCL_TYPE_INT128
            bool flag = CallIBinaryInteger.TryReadBigEndian(source, isUnsigned, out UInt128 avalue);
            value = avalue;
            return flag;
#else
            ExUInt128 result = default;

            if (source.Length != 0) {
                if (!isUnsigned && BitMath.IsNegative((sbyte)source[0])) {
                    // When we are signed and the sign bit is set, we are negative and therefore
                    // definitely out of range

                    value = result;
                    return false;
                }

                if ((source.Length > Size) && ExBitUtil.ContainsAnyExcept(source.Slice(0, source.Length - Size), (byte)0x00)) {
                    // When we have any non-zero leading data, we are a large positive and therefore
                    // definitely out of range

                    value = result;
                    return false;
                }

                ref byte sourceRef = ref MemoryMarshal.GetReference(source);

                if (source.Length >= Size) {
                    sourceRef = ref Unsafe.Add(ref sourceRef, source.Length - Size);

                    // We have at least 16 bytes, so just read the ones we need directly
                    result = Unsafe.ReadUnaligned<ExUInt128>(ref sourceRef);

                    if (BitConverter.IsLittleEndian) {
                        result = MathBinaryPrimitives.ReverseEndianness(result);
                    }
                } else {
                    // We have between 1 and 15 bytes, so construct the relevant value directly
                    // since the data is in Big Endian format, we can just read the bytes and
                    // shift left by 8-bits for each subsequent part

                    for (int i = 0; i < source.Length; i++) {
                        result <<= 8;
                        result |= Unsafe.Add(ref sourceRef, i);
                    }
                }
            }

            value = result;
            return true;
#endif
        }

        /// <inheritdoc cref="IBinaryInteger{TSelf}.TryReadLittleEndian(ReadOnlySpan{byte}, bool, out TSelf)" />
        public static bool TryReadLittleEndian(ReadOnlySpan<byte> source, bool isUnsigned, out ExUInt128 value) {
#if BCL_TYPE_INT128
            bool flag = CallIBinaryInteger.TryReadLittleEndian(source, isUnsigned, out UInt128 avalue);
            value = avalue;
            return flag;
#else
            ExUInt128 result = default;

            if (source.Length != 0) {
                if (!isUnsigned && BitMath.IsNegative((sbyte)source[source.Length-1])) {
                    // When we are signed and the sign bit is set, we are negative and therefore
                    // definitely out of range

                    value = result;
                    return false;
                }

                if ((source.Length > Size) && ExBitUtil.ContainsAnyExcept(source.Slice(Size), (byte)0x00)) {
                    // When we have any non-zero leading data, we are a large positive and therefore
                    // definitely out of range

                    value = result;
                    return false;
                }

                ref byte sourceRef = ref MemoryMarshal.GetReference(source);

                if (source.Length >= Size) {
                    // We have at least 16 bytes, so just read the ones we need directly
                    result = Unsafe.ReadUnaligned<ExUInt128>(ref sourceRef);

                    if (!BitConverter.IsLittleEndian) {
                        result = MathBinaryPrimitives.ReverseEndianness(result);
                    }
                } else {
                    // We have between 1 and 15 bytes, so construct the relevant value directly
                    // since the data is in Little Endian format, we can just read the bytes and
                    // shift left by 8-bits for each subsequent part, then reverse endianness to
                    // ensure the order is correct. This is more efficient than iterating in reverse
                    // due to current JIT limitations

                    for (int i = 0; i < source.Length; i++) {
                        ExUInt128 part = Unsafe.Add(ref sourceRef, i);
                        part <<= (i * 8);
                        result |= part;
                    }
                }
            }

            value = result;
            return true;
#endif
        }

        /// <inheritdoc cref="IBinaryInteger{TSelf}.GetShortestBitLength()" />
        public int GetShortestBitLength() {
#if BCL_TYPE_INT128
            return CallIBinaryInteger.GetShortestBitLength(_data);
#else
            return (Size * 8) - LeadingZeroCountAsInt32(this);
#endif // BCL_TYPE_INT128
        }

        /// <inheritdoc cref="IBinaryInteger{TSelf}.GetByteCount()" />
        public int GetByteCount() => Size;

        /// <inheritdoc cref="IBinaryInteger{TSelf}.TryWriteBigEndian(Span{byte}, out int)" />
        public bool TryWriteBigEndian(Span<byte> destination, out int bytesWritten) {
#if BCL_TYPE_INT128
            return CallIBinaryInteger.TryWriteBigEndian(_data, destination, out bytesWritten);
#else
            if (destination.Length >= Size) {
                ulong lower = Lower;
                ulong upper = Upper;

                if (BitConverter.IsLittleEndian) {
                    lower = BinaryPrimitives.ReverseEndianness(lower);
                    upper = BinaryPrimitives.ReverseEndianness(upper);
                }

                ref byte address = ref MemoryMarshal.GetReference(destination);

                Unsafe.WriteUnaligned(ref address, upper);
                Unsafe.WriteUnaligned(ref Unsafe.AddByteOffset(ref address, (nint)sizeof(ulong)), lower);

                bytesWritten = Size;
                return true;
            } else {
                bytesWritten = 0;
                return false;
            }
#endif // BCL_TYPE_INT128
        }

        /// <inheritdoc cref="IBinaryInteger{TSelf}.TryWriteLittleEndian(Span{byte}, out int)" />
        public bool TryWriteLittleEndian(Span<byte> destination, out int bytesWritten) {
#if BCL_TYPE_INT128
            return CallIBinaryInteger.TryWriteLittleEndian(_data, destination, out bytesWritten);
#else
            if (destination.Length >= Size) {
                WriteLittleEndianUnsafe(destination);
                bytesWritten = Size;
                return true;
            } else {
                bytesWritten = 0;
                return false;
            }
#endif // BCL_TYPE_INT128
        }

        //
        // IBinaryNumber
        //

        /// <inheritdoc cref="IBinaryNumber{TSelf}.AllBitsSet" />
        public static ExUInt128 AllBitsSet => MaxValue;

        /// <inheritdoc cref="IBinaryNumber{TSelf}.IsPow2(TSelf)" />
        public static bool IsPow2(ExUInt128 value) {
#if BCL_TYPE_INT128
            return UInt128.IsPow2(value._data);
#else
            return PopCount(value) == 1U;
#endif
        }

        /// <inheritdoc cref="IBinaryNumber{TSelf}.Log2(TSelf)" />
        public static ExUInt128 Log2(ExUInt128 value) {
#if BCL_TYPE_INT128
            return UInt128.Log2(value._data);
#else
            if (value.Upper == 0) {
                return (ExUInt128)(MathBitOperations.Log2(value.Lower));
            }
            return (ExUInt128)(64 + MathBitOperations.Log2(value.Upper));
#endif
        }

        //
        // IBitwiseOperators
        //

        /// <inheritdoc cref="IBitwiseOperators{TSelf, TOther, TResult}.op_BitwiseAnd(TSelf, TOther)" />
        public static ExUInt128 operator &(ExUInt128 left, ExUInt128 right) {
#if BCL_TYPE_INT128
            return left._data & right._data;
#else
            return new ExUInt128(left.Upper & right.Upper, left.Lower & right.Lower);
#endif
        }

        /// <inheritdoc cref="IBitwiseOperators{TSelf, TOther, TResult}.op_BitwiseOr(TSelf, TOther)" />
        public static ExUInt128 operator |(ExUInt128 left, ExUInt128 right) {
#if BCL_TYPE_INT128
            return left._data | right._data;
#else
            return new ExUInt128(left.Upper | right.Upper, left.Lower | right.Lower);
#endif
        }

        /// <inheritdoc cref="IBitwiseOperators{TSelf, TOther, TResult}.op_ExclusiveOr(TSelf, TOther)" />
        public static ExUInt128 operator ^(ExUInt128 left, ExUInt128 right) {
#if BCL_TYPE_INT128
            return left._data ^ right._data;
#else
            return new ExUInt128(left.Upper ^ right.Upper, left.Lower ^ right.Lower);
#endif
        }

        /// <inheritdoc cref="IBitwiseOperators{TSelf, TOther, TResult}.op_OnesComplement(TSelf)" />
        public static ExUInt128 operator ~(ExUInt128 value) {
#if BCL_TYPE_INT128
            return ~value._data;
#else
            return new ExUInt128(~value.Upper, ~value.Lower);
#endif
        }

        //
        // IComparisonOperators
        //

        /// <inheritdoc cref="IComparisonOperators{TSelf, TOther, TResult}.op_LessThan(TSelf, TOther)" />
        public static bool operator <(ExUInt128 left, ExUInt128 right) {
#if BCL_TYPE_INT128
            return left._data < right._data;
#else
            return (left.Upper < right.Upper)
                || (left.Upper == right.Upper) && (left.Lower < right.Lower);
#endif
        }

        /// <inheritdoc cref="IComparisonOperators{TSelf, TOther, TResult}.op_LessThanOrEqual(TSelf, TOther)" />
        public static bool operator <=(ExUInt128 left, ExUInt128 right) {
#if BCL_TYPE_INT128
            return left._data <= right._data;
#else
            return (left.Upper < right.Upper)
                || (left.Upper == right.Upper) && (left.Lower <= right.Lower);
#endif
        }

        /// <inheritdoc cref="IComparisonOperators{TSelf, TOther, TResult}.op_GreaterThan(TSelf, TOther)" />
        public static bool operator >(ExUInt128 left, ExUInt128 right) {
#if BCL_TYPE_INT128
            return left._data > right._data;
#else
            return (left.Upper > right.Upper)
                || (left.Upper == right.Upper) && (left.Lower > right.Lower);
#endif
        }

        /// <inheritdoc cref="IComparisonOperators{TSelf, TOther, TResult}.op_GreaterThanOrEqual(TSelf, TOther)" />
        public static bool operator >=(ExUInt128 left, ExUInt128 right) {
#if BCL_TYPE_INT128
            return left._data >= right._data;
#else
            return (left.Upper > right.Upper)
                || (left.Upper == right.Upper) && (left.Lower >= right.Lower);
#endif
        }

        //
        // IDecrementOperators
        //

        /// <inheritdoc cref="IDecrementOperators{TSelf}.op_Decrement(TSelf)" />
        public static ExUInt128 operator --(ExUInt128 value) {
#if BCL_TYPE_INT128
            return value._data - UInt128.One;
#else
            return value - One;
#endif
        }

        /// <inheritdoc cref="IDecrementOperators{TSelf}.op_Decrement(TSelf)" />
        public static ExUInt128 operator checked --(ExUInt128 value) {
#if BCL_TYPE_INT128
            return checked(value._data - UInt128.One);
#else
            return checked(value - One);
#endif
        }

        //
        // IDivisionOperators
        //

        /// <inheritdoc cref="IDivisionOperators{TSelf, TOther, TResult}.op_Division(TSelf, TOther)" />
        public static ExUInt128 operator /(ExUInt128 left, ExUInt128 right) {
#if BCL_TYPE_INT128
            return left._data / right._data;
#else
            if (right.Upper == 0) {
                if (right.Lower == 0) {
                    ThrowHelper.ThrowDivideByZeroException();
                }

                if (left.Upper == 0) {
                    // left and right are both uint64
                    return left.Lower / right.Lower;
                }
            }

            if (right >= left) {
                return (right == left) ? One : Zero;
            }

            return DivideSlow(left, right);

            static uint AddDivisor(Span<uint> left, ReadOnlySpan<uint> right) {
                Debug.Assert(left.Length >= right.Length);

                // Repairs the dividend, if the last subtract was too much

                ulong carry = 0UL;

                for (int i = 0; i < right.Length; i++) {
                    ref uint leftElement = ref left[i];
                    ulong digit = (leftElement + carry) + right[i];

                    leftElement = unchecked((uint)digit);
                    carry = digit >> 32;
                }

                return (uint)carry;
            }

            static bool DivideGuessTooBig(ulong q, ulong valHi, uint valLo, uint divHi, uint divLo) {
                Debug.Assert(q <= 0xFFFFFFFF);

                // We multiply the two most significant limbs of the divisor
                // with the current guess for the quotient. If those are bigger
                // than the three most significant limbs of the current dividend
                // we return true, which means the current guess is still too big.

                ulong chkHi = divHi * q;
                ulong chkLo = divLo * q;

                chkHi += (chkLo >> 32);
                chkLo = (uint)(chkLo);

                return (chkHi > valHi) || ((chkHi == valHi) && (chkLo > valLo));
            }

            static ExUInt128 DivideSlow(ExUInt128 quotient, ExUInt128 divisor) {
                // This is the same algorithm currently used by BigInteger so
                // we need to get a Span<uint> containing the value represented
                // in the least number of elements possible.

                // We need to ensure that we end up with 4x uints representing the bits from
                // least significant to most significant so the math will be correct on both
                // little and big endian systems. So we'll just allocate the relevant buffer
                // space and then write out the four parts using the native endianness of the
                // system.

                Span<uint> pLeft = stackalloc uint[Size / sizeof(uint)];

                pLeft[0] = (uint)(quotient.Lower >> 00);
                pLeft[1] = (uint)(quotient.Lower >> 32);

                pLeft[2] = (uint)(quotient.Upper >> 00);
                pLeft[3] = (uint)(quotient.Upper >> 32);

                //Span<uint> left = new Span<uint>(pLeft, (Size / sizeof(uint)) - (LeadingZeroCountAsInt32(quotient) / 32));
                Span<uint> left = pLeft.Slice(0, (Size / sizeof(uint)) - (LeadingZeroCountAsInt32(quotient) / 32));

                // Repeat the same operation with the divisor

                Span<uint> pRight  = stackalloc uint[Size / sizeof(uint)];

                pRight[0] = (uint)(divisor.Lower >> 00);
                pRight[1] = (uint)(divisor.Lower >> 32);

                pRight[2] = (uint)(divisor.Upper >> 00);
                pRight[3] = (uint)(divisor.Upper >> 32);

                //Span<uint> right = new Span<uint>(pRight, (Size / sizeof(uint)) - (LeadingZeroCountAsInt32(divisor) / 32));
                Span<uint> right = pRight.Slice(0, (Size / sizeof(uint)) - (LeadingZeroCountAsInt32(divisor) / 32));

                Span<uint> rawBits = stackalloc uint[Size / sizeof(uint)];
                rawBits.Clear();
                Span<uint> bits = rawBits.Slice(0, left.Length - right.Length + 1);

                Debug.Assert(left.Length >= 1);
                Debug.Assert(right.Length >= 1);
                Debug.Assert(left.Length >= right.Length);

                // Executes the "grammar-school" algorithm for computing q = a / b.
                // Before calculating q_i, we get more bits into the highest bit
                // block of the divisor. Thus, guessing digits of the quotient
                // will be more precise. Additionally we'll get r = a % b.

                uint divHi = right[right.Length - 1];
                uint divLo = right.Length > 1 ? right[right.Length - 2] : 0;

                // We measure the leading zeros of the divisor
                int shift = MathBitOperations.LeadingZeroCount(divHi);
                int backShift = 32 - shift;

                // And, we make sure the most significant bit is set
                if (shift > 0) {
                    uint divNx = right.Length > 2 ? right[right.Length - 3] : 0;

                    divHi = (divHi << shift) | (divLo >> backShift);
                    divLo = (divLo << shift) | (divNx >> backShift);
                }

                // Then, we divide all of the bits as we would do it using
                // pen and paper: guessing the next digit, subtracting, ...
                for (int i = left.Length; i >= right.Length; i--) {
                    int n = i - right.Length;
                    uint t = ((uint)(i) < (uint)(left.Length)) ? left[i] : 0;

                    ulong valHi = ((ulong)(t) << 32) | left[i - 1];
                    uint valLo = (i > 1) ? left[i - 2] : 0;

                    // We shifted the divisor, we shift the dividend too
                    if (shift > 0) {
                        uint valNx = i > 2 ? left[i - 3] : 0;

                        valHi = (valHi << shift) | (valLo >> backShift);
                        valLo = (valLo << shift) | (valNx >> backShift);
                    }

                    // First guess for the current digit of the quotient,
                    // which naturally must have only 32 bits...
                    ulong digit = valHi / divHi;

                    if (digit > 0xFFFFFFFF) {
                        digit = 0xFFFFFFFF;
                    }

                    // Our first guess may be a little bit to big
                    while (DivideGuessTooBig(digit, valHi, valLo, divHi, divLo)) {
                        --digit;
                    }

                    if (digit > 0) {
                        // Now it's time to subtract our current quotient
                        uint carry = SubtractDivisor(left.Slice(n), right, digit);

                        if (carry != t) {
                            Debug.Assert(carry == (t + 1));

                            // Our guess was still exactly one too high
                            carry = AddDivisor(left.Slice(n), right);

                            --digit;
                            Debug.Assert(carry == 1);
                        }
                    }

                    // We have the digit!
                    if ((uint)(n) < (uint)(bits.Length)) {
                        bits[n] = (uint)(digit);
                    }

                    if ((uint)(i) < (uint)(left.Length)) {
                        left[i] = 0;
                    }
                }

                return new ExUInt128(
                    ((ulong)(rawBits[3]) << 32) | rawBits[2],
                    ((ulong)(rawBits[1]) << 32) | rawBits[0]
                );
            }

            static uint SubtractDivisor(Span<uint> left, ReadOnlySpan<uint> right, ulong q) {
                Debug.Assert(left.Length >= right.Length);
                Debug.Assert(q <= 0xFFFFFFFF);

                // Combines a subtract and a multiply operation, which is naturally
                // more efficient than multiplying and then subtracting...

                ulong carry = 0UL;

                for (int i = 0; i < right.Length; i++) {
                    carry += right[i] * q;

                    uint digit = (uint)(carry);
                    carry >>= 32;

                    ref uint leftElement = ref left[i];

                    if (leftElement < digit) {
                        ++carry;
                    }
                    leftElement -= digit;
                }

                return (uint)(carry);
            }
#endif
        }

        /// <inheritdoc cref="IDivisionOperators{TSelf, TOther, TResult}.op_CheckedDivision(TSelf, TOther)" />
        public static ExUInt128 operator checked /(ExUInt128 left, ExUInt128 right) {
#if BCL_TYPE_INT128
            return checked(left._data / right._data);
#else
            return left / right;
#endif
        }

        //
        // IEqualityOperators
        //

        /// <inheritdoc cref="IEqualityOperators{TSelf, TOther, TResult}.op_Equality(TSelf, TOther)" />
        public static bool operator ==(ExUInt128 left, ExUInt128 right) {
#if BCL_TYPE_INT128
            return left._data == right._data;
#else
            return (left.Lower != right.Lower) && (left.Upper == right.Upper);
#endif
        }

        /// <inheritdoc cref="IEqualityOperators{TSelf, TOther, TResult}.op_Inequality(TSelf, TOther)" />
        public static bool operator !=(ExUInt128 left, ExUInt128 right) {
#if BCL_TYPE_INT128
            return left._data != right._data;
#else
            return (left.Lower != right.Lower) || (left.Upper != right.Upper);
#endif
        }

        //
        // IIncrementOperators
        //

        /// <inheritdoc cref="IIncrementOperators{TSelf}.op_Increment(TSelf)" />
        public static ExUInt128 operator ++(ExUInt128 value) {
#if BCL_TYPE_INT128
            return value._data + UInt128.One;
#else
            return value + One;
#endif
        }

        /// <inheritdoc cref="IIncrementOperators{TSelf}.op_CheckedIncrement(TSelf)" />
        public static ExUInt128 operator checked ++(ExUInt128 value) {
#if BCL_TYPE_INT128
            return checked(value._data + UInt128.One);
#else
            return checked(value + One);
#endif
        }

        //
        // IMinMaxValue
        //

        /// <inheritdoc cref="IMinMaxValue{TSelf}.MinValue" />
        public static ExUInt128 MinValue => Zero;

        /// <inheritdoc cref="IMinMaxValue{TSelf}.MaxValue" />
        public static ExUInt128 MaxValue =>
#if BCL_TYPE_INT128
            UInt128.MaxValue;
#else
            new ExUInt128(0xFFFF_FFFF_FFFF_FFFF, 0xFFFF_FFFF_FFFF_FFFF);
#endif

        //
        // IModulusOperators
        //

        /// <inheritdoc cref="IModulusOperators{TSelf, TOther, TResult}.op_Modulus(TSelf, TOther)" />
        public static ExUInt128 operator %(ExUInt128 left, ExUInt128 right) {
#if BCL_TYPE_INT128
            return left._data % right._data;
#else
            ExUInt128 quotient = left / right;
            return left - (quotient * right);
#endif
        }

        //
        // IMultiplicativeIdentity
        //

#if GENERICS_MATH
        /// <inheritdoc cref="IMultiplicativeIdentity{TSelf, TResult}.MultiplicativeIdentity" />
        static ExUInt128 IMultiplicativeIdentity<ExUInt128, ExUInt128>.MultiplicativeIdentity => One;
#endif // GENERICS_MATH

        //
        // IMultiplyOperators
        //

        /// <inheritdoc cref="IMultiplyOperators{TSelf, TOther, TResult}.op_Multiply(TSelf, TOther)" />
        public static ExUInt128 operator *(ExUInt128 left, ExUInt128 right) {
#if BCL_TYPE_INT128
            return left._data * right._data;
#else
            ulong upper = BitMath.BigMul(left.Lower, right.Lower, out ulong lower);
            upper += (left.Upper * right.Lower) + (left.Lower * right.Upper);
            return new ExUInt128(upper, lower);
#endif
        }

        /// <inheritdoc cref="IMultiplyOperators{TSelf, TOther, TResult}.op_CheckedMultiply(TSelf, TOther)" />
        public static ExUInt128 operator checked *(ExUInt128 left, ExUInt128 right) {
#if BCL_TYPE_INT128
            return checked(left._data * right._data);
#else
            ExUInt128 upper = BigMul(left, right, out ExUInt128 lower);

            if (upper != 0U) {
                ThrowHelper.ThrowOverflowException();
            }

            return lower;
#endif
        }

        internal static ExUInt128 BigMul(ExUInt128 left, ExUInt128 right, out ExUInt128 lower) {
            // Adaptation of algorithm for multiplication
            // of 32-bit unsigned integers described
            // in Hacker's Delight by Henry S. Warren, Jr. (ISBN 0-201-91465-4), Chapter 8
            // Basically, it's an optimized version of FOIL method applied to
            // low and high qwords of each operand

            ulong al = left.Lower;
            ulong ah = left.Upper;

            ulong bl = right.Lower;
            ulong bh = right.Upper;

            ExUInt128 mull = BitMath.BigMul(al, bl);
            ExUInt128 t = BitMath.BigMul(ah, bl) + mull.Upper;
            ExUInt128 tl = BitMath.BigMul(al, bh) + t.Lower;

            lower = new ExUInt128(tl.Lower, mull.Lower);
            return BitMath.BigMul(ah, bh) + t.Upper + tl.Upper;
        }

        //
        // INumber
        //

        /// <inheritdoc cref="INumber{TSelf}.Clamp(TSelf, TSelf, TSelf)" />
        public static ExUInt128 Clamp(ExUInt128 value, ExUInt128 min, ExUInt128 max) {
#if BCL_TYPE_INT128
            return UInt128.Clamp(value._data, min._data, max._data);
#else
            if (min > max) {
                ThrowHelper.ThrowMinMaxException(min, max);
            }

            if (value < min) {
                return min;
            } else if (value > max) {
                return max;
            }

            return value;
#endif
        }

        /// <inheritdoc cref="INumber{TSelf}.CopySign(TSelf, TSelf)" />
        static ExUInt128 CopySign(ExUInt128 value, ExUInt128 sign) => value;

        /// <inheritdoc cref="INumber{TSelf}.Max(TSelf, TSelf)" />
        public static ExUInt128 Max(ExUInt128 x, ExUInt128 y) {
#if BCL_TYPE_INT128
            return UInt128.Max(x._data, y._data);
#else
            return (x >= y) ? x : y;
#endif
        }

#if GENERICS_MATH
        /// <inheritdoc cref="INumber{TSelf}.MaxNumber(TSelf, TSelf)" />
        static ExUInt128 INumber<ExUInt128>.MaxNumber(ExUInt128 x, ExUInt128 y) => Max(x, y);
#endif // GENERICS_MATH

        /// <inheritdoc cref="INumber{TSelf}.Min(TSelf, TSelf)" />
        public static ExUInt128 Min(ExUInt128 x, ExUInt128 y) {
#if BCL_TYPE_INT128
            return UInt128.Min(x._data, y._data);
#else
            return (x <= y) ? x : y;
#endif
        }

#if GENERICS_MATH
        /// <inheritdoc cref="INumber{TSelf}.MinNumber(TSelf, TSelf)" />
        static ExUInt128 INumber<ExUInt128>.MinNumber(ExUInt128 x, ExUInt128 y) => Min(x, y);
#endif // GENERICS_MATH

        /// <inheritdoc cref="INumber{TSelf}.Sign(TSelf)" />
        public static int Sign(ExUInt128 value) {
#if BCL_TYPE_INT128
            return UInt128.Sign(value._data);
#else
            return (value == 0U) ? 0 : 1;
#endif
        }

        //
        // INumberBase
        //

        /// <inheritdoc cref="INumberBase{TSelf}.One" />
        public static ExUInt128 One =>
#if BCL_TYPE_INT128
            UInt128.One;
#else
            new ExUInt128(0, 1);
#endif

#if GENERICS_MATH
        /// <inheritdoc cref="INumberBase{TSelf}.Radix" />
        static int INumberBase<ExUInt128>.Radix => 2;
#endif // GENERICS_MATH

        /// <inheritdoc cref="INumberBase{TSelf}.Zero" />
        public static ExUInt128 Zero => default;

#if GENERICS_MATH
        /// <inheritdoc cref="INumberBase{TSelf}.Abs(TSelf)" />
        static ExUInt128 INumberBase<ExUInt128>.Abs(ExUInt128 value) => value;
#endif // GENERICS_MATH

#if GENERICS_MATH
        /// <inheritdoc cref="INumberBase{TSelf}.CreateChecked{TOther}(TOther)" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ExUInt128 CreateChecked<TOther>(TOther value)
            where TOther : INumberBase<TOther> {
            return UInt128.CreateChecked(value);
        }

        /// <inheritdoc cref="INumberBase{TSelf}.CreateSaturating{TOther}(TOther)" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ExUInt128 CreateSaturating<TOther>(TOther value)
            where TOther : INumberBase<TOther> {
            return UInt128.CreateChecked(value);
        }

        /// <inheritdoc cref="INumberBase{TSelf}.CreateTruncating{TOther}(TOther)" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ExUInt128 CreateTruncating<TOther>(TOther value)
            where TOther : INumberBase<TOther> {
            return UInt128.CreateChecked(value);
        }

        /// <inheritdoc cref="INumberBase{TSelf}.IsCanonical(TSelf)" />
        static bool INumberBase<ExUInt128>.IsCanonical(ExUInt128 value) => true;

        /// <inheritdoc cref="INumberBase{TSelf}.IsComplexNumber(TSelf)" />
        static bool INumberBase<ExUInt128>.IsComplexNumber(ExUInt128 value) => false;
#endif // GENERICS_MATH

        /// <inheritdoc cref="INumberBase{TSelf}.IsEvenInteger(TSelf)" />
        public static bool IsEvenInteger(ExUInt128 value) {
#if BCL_TYPE_INT128
            return UInt128.IsEvenInteger(value._data);
#else
            return (value.Lower & 1) == 0;
#endif
        }

#if GENERICS_MATH
        /// <inheritdoc cref="INumberBase{TSelf}.IsFinite(TSelf)" />
        static bool INumberBase<ExUInt128>.IsFinite(ExUInt128 value) => true;

        /// <inheritdoc cref="INumberBase{TSelf}.IsImaginaryNumber(TSelf)" />
        static bool INumberBase<ExUInt128>.IsImaginaryNumber(ExUInt128 value) => false;

        /// <inheritdoc cref="INumberBase{TSelf}.IsInfinity(TSelf)" />
        static bool INumberBase<ExUInt128>.IsInfinity(ExUInt128 value) => false;

        /// <inheritdoc cref="INumberBase{TSelf}.IsInteger(TSelf)" />
        static bool INumberBase<ExUInt128>.IsInteger(ExUInt128 value) => true;

        /// <inheritdoc cref="INumberBase{TSelf}.IsNaN(TSelf)" />
        static bool INumberBase<ExUInt128>.IsNaN(ExUInt128 value) => false;

        /// <inheritdoc cref="INumberBase{TSelf}.IsNegative(TSelf)" />
        static bool INumberBase<ExUInt128>.IsNegative(ExUInt128 value) => false;

        /// <inheritdoc cref="INumberBase{TSelf}.IsNegativeInfinity(TSelf)" />
        static bool INumberBase<ExUInt128>.IsNegativeInfinity(ExUInt128 value) => false;

        /// <inheritdoc cref="INumberBase{TSelf}.IsNormal(TSelf)" />
        static bool INumberBase<ExUInt128>.IsNormal(ExUInt128 value) => value != 0U;
#endif // GENERICS_MATH

        /// <inheritdoc cref="INumberBase{TSelf}.IsOddInteger(TSelf)" />
        public static bool IsOddInteger(ExUInt128 value) {
#if BCL_TYPE_INT128
            return UInt128.IsOddInteger(value._data);
#else
            return (value.Lower & 1) != 0;
#endif
        }

#if GENERICS_MATH
        /// <inheritdoc cref="INumberBase{TSelf}.IsPositive(TSelf)" />
        static bool INumberBase<ExUInt128>.IsPositive(ExUInt128 value) => true;

        /// <inheritdoc cref="INumberBase{TSelf}.IsPositiveInfinity(TSelf)" />
        static bool INumberBase<ExUInt128>.IsPositiveInfinity(ExUInt128 value) => false;

        /// <inheritdoc cref="INumberBase{TSelf}.IsRealNumber(TSelf)" />
        static bool INumberBase<ExUInt128>.IsRealNumber(ExUInt128 value) => true;

        /// <inheritdoc cref="INumberBase{TSelf}.IsSubnormal(TSelf)" />
        static bool INumberBase<ExUInt128>.IsSubnormal(ExUInt128 value) => false;

        /// <inheritdoc cref="INumberBase{TSelf}.IsZero(TSelf)" />
        static bool INumberBase<ExUInt128>.IsZero(ExUInt128 value) => (value == 0U);

        /// <inheritdoc cref="INumberBase{TSelf}.MaxMagnitude(TSelf, TSelf)" />
        static ExUInt128 INumberBase<ExUInt128>.MaxMagnitude(ExUInt128 x, ExUInt128 y) => Max(x, y);

        /// <inheritdoc cref="INumberBase{TSelf}.MaxMagnitudeNumber(TSelf, TSelf)" />
        static ExUInt128 INumberBase<ExUInt128>.MaxMagnitudeNumber(ExUInt128 x, ExUInt128 y) => Max(x, y);

        /// <inheritdoc cref="INumberBase{TSelf}.MinMagnitude(TSelf, TSelf)" />
        static ExUInt128 INumberBase<ExUInt128>.MinMagnitude(ExUInt128 x, ExUInt128 y) => Min(x, y);

        /// <inheritdoc cref="INumberBase{TSelf}.MinMagnitudeNumber(TSelf, TSelf)" />
        static ExUInt128 INumberBase<ExUInt128>.MinMagnitudeNumber(ExUInt128 x, ExUInt128 y) => Min(x, y);
#endif // GENERICS_MATH

        /// <inheritdoc cref="INumberBase{TSelf}.MultiplyAddEstimate(TSelf, TSelf, TSelf)" />
        public static ExUInt128 MultiplyAddEstimate(ExUInt128 left, ExUInt128 right, ExUInt128 addend) {
#if NET9_0_OR_GREATER
            return CallINumberBase.MultiplyAddEstimate(left, right, addend);
#else
            return (left * right) + addend;
#endif // NET9_0_OR_GREATER
        }

#if GENERICS_MATH
        /// <inheritdoc cref="INumberBase{TSelf}.TryConvertFromChecked{TOther}(TOther, out TSelf)" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static bool INumberBase<ExUInt128>.TryConvertFromChecked<TOther>(TOther value, out ExUInt128 result) => TryConvertFromChecked(value, out result);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool TryConvertFromChecked<TOther>(TOther value, out ExUInt128 result)
            where TOther : INumberBase<TOther> {
            // In order to reduce overall code duplication and improve the inlinabilty of these
            // methods for the corelib types we have `ConvertFrom` handle the same sign and
            // `ConvertTo` handle the opposite sign. However, since there is an uneven split
            // between signed and unsigned types, the one that handles unsigned will also
            // handle `Decimal`.
            //
            // That is, `ConvertFrom` for `ExUInt128` will handle the other unsigned types and
            // `ConvertTo` will handle the signed types

            if (typeof(TOther) == typeof(byte)) {
                byte actualValue = (byte)(object)value;
                result = actualValue;
                return true;
            } else if (typeof(TOther) == typeof(char)) {
                char actualValue = (char)(object)value;
                result = actualValue;
                return true;
            } else if (typeof(TOther) == typeof(decimal)) {
                decimal actualValue = (decimal)(object)value;
                result = checked((ExUInt128)actualValue);
                return true;
            } else if (typeof(TOther) == typeof(ushort)) {
                ushort actualValue = (ushort)(object)value;
                result = actualValue;
                return true;
            } else if (typeof(TOther) == typeof(uint)) {
                uint actualValue = (uint)(object)value;
                result = actualValue;
                return true;
            } else if (typeof(TOther) == typeof(ulong)) {
                ulong actualValue = (ulong)(object)value;
                result = actualValue;
                return true;
            } else if (typeof(TOther) == typeof(nuint)) {
                nuint actualValue = (nuint)(object)value;
                result = actualValue;
                return true;
            } else if (typeof(TOther) == typeof(UInt128)) {
                UInt128 actualValue = (UInt128)(object)value;
                result = actualValue;
                return true;
            } else {
                result = default;
                return false;
            }
        }

        /// <inheritdoc cref="INumberBase{TSelf}.TryConvertFromSaturating{TOther}(TOther, out TSelf)" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static bool INumberBase<ExUInt128>.TryConvertFromSaturating<TOther>(TOther value, out ExUInt128 result) => TryConvertFromSaturating(value, out result);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool TryConvertFromSaturating<TOther>(TOther value, out ExUInt128 result)
            where TOther : INumberBase<TOther> {
            // In order to reduce overall code duplication and improve the inlinabilty of these
            // methods for the corelib types we have `ConvertFrom` handle the same sign and
            // `ConvertTo` handle the opposite sign. However, since there is an uneven split
            // between signed and unsigned types, the one that handles unsigned will also
            // handle `Decimal`.
            //
            // That is, `ConvertFrom` for `ExUInt128` will handle the other unsigned types and
            // `ConvertTo` will handle the signed types

            if (typeof(TOther) == typeof(byte)) {
                byte actualValue = (byte)(object)value;
                result = actualValue;
                return true;
            } else if (typeof(TOther) == typeof(char)) {
                char actualValue = (char)(object)value;
                result = actualValue;
                return true;
            } else if (typeof(TOther) == typeof(decimal)) {
                decimal actualValue = (decimal)(object)value;
                result = (actualValue < 0) ? MinValue : (ExUInt128)actualValue;
                return true;
            } else if (typeof(TOther) == typeof(ushort)) {
                ushort actualValue = (ushort)(object)value;
                result = actualValue;
                return true;
            } else if (typeof(TOther) == typeof(uint)) {
                uint actualValue = (uint)(object)value;
                result = actualValue;
                return true;
            } else if (typeof(TOther) == typeof(ulong)) {
                ulong actualValue = (ulong)(object)value;
                result = actualValue;
                return true;
            } else if (typeof(TOther) == typeof(nuint)) {
                nuint actualValue = (nuint)(object)value;
                result = actualValue;
                return true;
            } else if (typeof(TOther) == typeof(UInt128)) {
                UInt128 actualValue = (UInt128)(object)value;
                result = actualValue;
                return true;
            } else {
                result = default;
                return false;
            }
        }

        /// <inheritdoc cref="INumberBase{TSelf}.TryConvertFromTruncating{TOther}(TOther, out TSelf)" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static bool INumberBase<ExUInt128>.TryConvertFromTruncating<TOther>(TOther value, out ExUInt128 result) => TryConvertFromTruncating(value, out result);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool TryConvertFromTruncating<TOther>(TOther value, out ExUInt128 result)
            where TOther : INumberBase<TOther> {
            // In order to reduce overall code duplication and improve the inlinabilty of these
            // methods for the corelib types we have `ConvertFrom` handle the same sign and
            // `ConvertTo` handle the opposite sign. However, since there is an uneven split
            // between signed and unsigned types, the one that handles unsigned will also
            // handle `Decimal`.
            //
            // That is, `ConvertFrom` for `ExUInt128` will handle the other unsigned types and
            // `ConvertTo` will handle the signed types

            if (typeof(TOther) == typeof(byte)) {
                byte actualValue = (byte)(object)value;
                result = actualValue;
                return true;
            } else if (typeof(TOther) == typeof(char)) {
                char actualValue = (char)(object)value;
                result = actualValue;
                return true;
            } else if (typeof(TOther) == typeof(decimal)) {
                decimal actualValue = (decimal)(object)value;
                result = (actualValue < 0) ? MinValue : (ExUInt128)actualValue;
                return true;
            } else if (typeof(TOther) == typeof(ushort)) {
                ushort actualValue = (ushort)(object)value;
                result = actualValue;
                return true;
            } else if (typeof(TOther) == typeof(uint)) {
                uint actualValue = (uint)(object)value;
                result = actualValue;
                return true;
            } else if (typeof(TOther) == typeof(ulong)) {
                ulong actualValue = (ulong)(object)value;
                result = actualValue;
                return true;
            } else if (typeof(TOther) == typeof(nuint)) {
                nuint actualValue = (nuint)(object)value;
                result = actualValue;
                return true;
            } else if (typeof(TOther) == typeof(UInt128)) {
                UInt128 actualValue = (UInt128)(object)value;
                result = actualValue;
                return true;
            } else {
                result = default;
                return false;
            }
        }

        /// <inheritdoc cref="INumberBase{TSelf}.TryConvertToChecked{TOther}(TSelf, out TOther)" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static bool INumberBase<ExUInt128>.TryConvertToChecked<TOther>(ExUInt128 value, [MaybeNullWhen(false)] out TOther result) {
            // In order to reduce overall code duplication and improve the inlinabilty of these
            // methods for the corelib types we have `ConvertFrom` handle the same sign and
            // `ConvertTo` handle the opposite sign. However, since there is an uneven split
            // between signed and unsigned types, the one that handles unsigned will also
            // handle `Decimal`.
            //
            // That is, `ConvertFrom` for `ExUInt128` will handle the other unsigned types and
            // `ConvertTo` will handle the signed types

            if (typeof(TOther) == typeof(double)) {
                double actualResult = (double)value;
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(Half)) {
                Half actualResult = (Half)value;
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(short)) {
                short actualResult = checked((short)value);
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(int)) {
                int actualResult = checked((int)value);
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(long)) {
                long actualResult = checked((long)value);
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(Int128)) {
                Int128 actualResult = checked((Int128)value);
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(ExInt128)) {
                ExInt128 actualResult = checked((ExInt128)value);
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(nint)) {
                nint actualResult = checked((nint)value);
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(sbyte)) {
                sbyte actualResult = checked((sbyte)value);
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(float)) {
                float actualResult = (float)value;
                result = (TOther)(object)actualResult;
                return true;
            } else {
                result = default;
                return false;
            }
        }

        /// <inheritdoc cref="INumberBase{TSelf}.TryConvertToSaturating{TOther}(TSelf, out TOther)" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static bool INumberBase<ExUInt128>.TryConvertToSaturating<TOther>(ExUInt128 value, [MaybeNullWhen(false)] out TOther result) {
            // In order to reduce overall code duplication and improve the inlinabilty of these
            // methods for the corelib types we have `ConvertFrom` handle the same sign and
            // `ConvertTo` handle the opposite sign. However, since there is an uneven split
            // between signed and unsigned types, the one that handles unsigned will also
            // handle `Decimal`.
            //
            // That is, `ConvertFrom` for `ExUInt128` will handle the other unsigned types and
            // `ConvertTo` will handle the signed types

            if (typeof(TOther) == typeof(double)) {
                double actualResult = (double)value;
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(Half)) {
                Half actualResult = (Half)value;
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(short)) {
                short actualResult = (value >= new ExUInt128(0x0000_0000_0000_0000, 0x0000_0000_0000_7FFF)) ? short.MaxValue : (short)value;
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(int)) {
                int actualResult = (value >= new ExUInt128(0x0000_0000_0000_0000, 0x0000_0000_7FFF_FFFF)) ? int.MaxValue : (int)value;
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(long)) {
                long actualResult = (value >= new ExUInt128(0x0000_0000_0000_0000, 0x7FFF_FFFF_FFFF_FFFF)) ? long.MaxValue : (long)value;
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(Int128)) {
                Int128 actualResult = (value >= new ExUInt128(0x7FFF_FFFF_FFFF_FFFF, 0xFFFF_FFFF_FFFF_FFFF)) ? Int128.MaxValue : (Int128)value;
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(ExInt128)) {
                ExInt128 actualResult = (value >= new ExUInt128(0x7FFF_FFFF_FFFF_FFFF, 0xFFFF_FFFF_FFFF_FFFF)) ? ExInt128.MaxValue : (ExInt128)value;
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(nint)) {
                nint actualResult;
                if (BitMathCore.Is64Bit) {
                    actualResult = (value >= new ExUInt128(0x0000_0000_0000_0000, 0x7FFF_FFFF_FFFF_FFFF)) ? nint.MaxValue : (nint)value;
                } else {
                    actualResult = (value >= new ExUInt128(0x0000_0000_0000_0000, 0x0000_0000_7FFF_FFFF)) ? nint.MaxValue : (nint)value;
                }
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(sbyte)) {
                sbyte actualResult = (value >= new ExUInt128(0x0000_0000_0000_0000, 0x0000_0000_0000_007F)) ? sbyte.MaxValue : (sbyte)value;
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(float)) {
                float actualResult = (float)value;
                result = (TOther)(object)actualResult;
                return true;
            } else {
                result = default;
                return false;
            }
        }

        /// <inheritdoc cref="INumberBase{TSelf}.TryConvertToTruncating{TOther}(TSelf, out TOther)" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static bool INumberBase<ExUInt128>.TryConvertToTruncating<TOther>(ExUInt128 value, [MaybeNullWhen(false)] out TOther result) {
            // In order to reduce overall code duplication and improve the inlinabilty of these
            // methods for the corelib types we have `ConvertFrom` handle the same sign and
            // `ConvertTo` handle the opposite sign. However, since there is an uneven split
            // between signed and unsigned types, the one that handles unsigned will also
            // handle `Decimal`.
            //
            // That is, `ConvertFrom` for `ExUInt128` will handle the other unsigned types and
            // `ConvertTo` will handle the signed types

            if (typeof(TOther) == typeof(double)) {
                double actualResult = (double)value;
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(Half)) {
                Half actualResult = (Half)value;
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(short)) {
                short actualResult = (short)value;
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(int)) {
                int actualResult = (int)value;
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(long)) {
                long actualResult = (long)value;
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(Int128)) {
                Int128 actualResult = (Int128)value;
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(ExInt128)) {
                ExInt128 actualResult = (ExInt128)value;
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(nint)) {
                nint actualResult = (nint)value;
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(sbyte)) {
                sbyte actualResult = (sbyte)value;
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(float)) {
                float actualResult = (float)value;
                result = (TOther)(object)actualResult;
                return true;
            } else {
                result = default;
                return false;
            }
        }
#endif // GENERICS_MATH

        //
        // IParsable
        //

        /// <inheritdoc cref="IParsable{TSelf}.TryParse(string?, IFormatProvider?, out TSelf)" />
        public static bool TryParse(
#if BCL_ATTR_NULL
            [NotNullWhen(true)]
#endif
            string? s, IFormatProvider? provider, out ExUInt128 result) {
#if BCL_TYPE_INT128
            bool flag = UInt128.TryParse(s, provider, out var rt);
            result = rt;
            return flag;
#else
            return TryParse(s, NumberStyles.Integer, provider, out result);
#endif
        }

        //
        // IShiftOperators
        //

        /// <inheritdoc cref="IShiftOperators{TSelf, TOther, TResult}.op_LeftShift(TSelf, TOther)" />
        public static ExUInt128 operator <<(ExUInt128 value, int shiftAmount) {
#if BCL_TYPE_INT128
            return value._data << shiftAmount;
#else
            // C# automatically masks the shift amount for UInt64 to be 0x3F. So we
            // need to specially handle things if the 7th bit is set.

            shiftAmount &= 0x7F;

            if ((shiftAmount & 0x40) != 0) {
                // In the case it is set, we know the entire lower bits must be zero
                // and so the upper bits are just the lower shifted by the remaining
                // masked amount

                ulong upper = value.Lower << shiftAmount;
                return new ExUInt128(upper, 0);
            } else if (shiftAmount != 0) {
                // Otherwise we need to shift both upper and lower halves by the masked
                // amount and then or that with whatever bits were shifted "out" of lower

                ulong lower = value.Lower << shiftAmount;
                ulong upper = (value.Upper << shiftAmount) | (value.Lower >> (64 - shiftAmount));

                return new ExUInt128(upper, lower);
            } else {
                return value;
            }
#endif
        }

        /// <inheritdoc cref="IShiftOperators{TSelf, TOther, TResult}.op_RightShift(TSelf, TOther)" />
        public static ExUInt128 operator >>(ExUInt128 value, int shiftAmount) => value >>> shiftAmount;

        /// <inheritdoc cref="IShiftOperators{TSelf, TOther, TResult}.op_UnsignedRightShift(TSelf, TOther)" />
        public static ExUInt128 operator >>>(ExUInt128 value, int shiftAmount) {
#if BCL_TYPE_INT128
            return value._data >>> shiftAmount;
#else
            // C# automatically masks the shift amount for UInt64 to be 0x3F. So we
            // need to specially handle things if the 7th bit is set.

            shiftAmount &= 0x7F;

            if ((shiftAmount & 0x40) != 0) {
                // In the case it is set, we know the entire upper bits must be zero
                // and so the lower bits are just the upper shifted by the remaining
                // masked amount

                ulong lower = value.Upper >> shiftAmount;
                return new ExUInt128(0, lower);
            } else if (shiftAmount != 0) {
                // Otherwise we need to shift both upper and lower halves by the masked
                // amount and then or that with whatever bits were shifted "out" of upper

                ulong lower = (value.Lower >> shiftAmount) | (value.Upper << (64 - shiftAmount));
                ulong upper = value.Upper >> shiftAmount;

                return new ExUInt128(upper, lower);
            } else {
                return value;
            }
#endif
        }

        //
        // ISpanParsable
        //

        /// <inheritdoc cref="ISpanParsable{TSelf}.Parse(ReadOnlySpan{char}, IFormatProvider?)" />
        public static ExUInt128 Parse(ReadOnlySpan<char> s, IFormatProvider? provider) {
#if BCL_TYPE_INT128
            return UInt128.Parse(s, NumberStyles.Integer, provider);
#else
            return Parse(s, NumberStyles.Integer, provider);
#endif
        }

        /// <inheritdoc cref="ISpanParsable{TSelf}.TryParse(ReadOnlySpan{char}, IFormatProvider?, out TSelf)" />
        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, out ExUInt128 result) {
#if BCL_TYPE_INT128
            bool flag = UInt128.TryParse(s, NumberStyles.Integer, provider, out var rt);
            result = rt;
            return flag;
#else
            return TryParse(s, NumberStyles.Integer, provider, out result);
#endif
        }

        //
        // ISubtractionOperators
        //

        /// <inheritdoc cref="ISubtractionOperators{TSelf, TOther, TResult}.op_Subtraction(TSelf, TOther)" />
        public static ExUInt128 operator -(ExUInt128 left, ExUInt128 right) {
#if BCL_TYPE_INT128
            return left._data - right._data;
#else
            // For unsigned subtract, we can detect overflow by checking `(x - y) > x`
            // This gives us the borrow to subtract from upper to compute the correct result

            ulong lower = left.Lower - right.Lower;
            ulong borrow = (lower > left.Lower) ? 1UL : 0UL;

            ulong upper = left.Upper - right.Upper - borrow;
            return new ExUInt128(upper, lower);
#endif
        }

        /// <inheritdoc cref="ISubtractionOperators{TSelf, TOther, TResult}.op_CheckedSubtraction(TSelf, TOther)" />
        public static ExUInt128 operator checked -(ExUInt128 left, ExUInt128 right) {
#if BCL_TYPE_INT128
            return checked(left._data - right._data);
#else
            // For unsigned subtract, we can detect overflow by checking `(x - y) > x`
            // This gives us the borrow to subtract from upper to compute the correct result

            ulong lower = left.Lower - right.Lower;
            ulong borrow = (lower > left.Lower) ? 1UL : 0UL;

            ulong upper = checked(left.Upper - right.Upper - borrow);
            return new ExUInt128(upper, lower);
#endif
        }

        //
        // IUnaryNegationOperators
        //

        /// <inheritdoc cref="IUnaryNegationOperators{TSelf, TResult}.op_UnaryNegation(TSelf)" />
        public static ExUInt128 operator -(ExUInt128 value) {
#if BCL_TYPE_INT128
            return -value._data;
#else
            return Zero - value;
#endif
        }

        /// <inheritdoc cref="IUnaryNegationOperators{TSelf, TResult}.op_CheckedUnaryNegation(TSelf)" />
        public static ExUInt128 operator checked -(ExUInt128 value) {
#if BCL_TYPE_INT128
            return checked(-value._data);
#else
            return checked(Zero - value);
#endif
        }

        //
        // IUnaryPlusOperators
        //

        /// <inheritdoc cref="IUnaryPlusOperators{TSelf, TResult}.op_UnaryPlus(TSelf)" />
        public static ExUInt128 operator +(ExUInt128 value) => value;

        //
        // IUtf8SpanParsable
        //

        /// <inheritdoc cref="INumberBase{TSelf}.Parse(ReadOnlySpan{byte}, NumberStyles, IFormatProvider?)" />
        public static ExUInt128 Parse(ReadOnlySpan<byte> utf8Text, NumberStyles style = NumberStyles.Integer, IFormatProvider? provider = null) {
            ExNumberFormatInfo.ValidateParseStyleInteger(style);
            return Number.ParseBinaryInteger<byte, ExUInt128>(utf8Text, style, NumberFormatInfo.GetInstance(provider));
        }

        /// <inheritdoc cref="INumberBase{TSelf}.TryParse(ReadOnlySpan{byte}, NumberStyles, IFormatProvider?, out TSelf)" />
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, NumberStyles style, IFormatProvider? provider, out ExUInt128 result) {
            ExNumberFormatInfo.ValidateParseStyleInteger(style);
            return Number.TryParseBinaryInteger(utf8Text, style, NumberFormatInfo.GetInstance(provider), out result) == Number.ParsingStatus.OK;
        }

        /// <inheritdoc cref="IUtf8SpanParsable{TSelf}.Parse(ReadOnlySpan{byte}, IFormatProvider?)" />
        public static ExUInt128 Parse(ReadOnlySpan<byte> utf8Text, IFormatProvider? provider) => Parse(utf8Text, NumberStyles.Integer, provider);

        /// <inheritdoc cref="IUtf8SpanParsable{TSelf}.TryParse(ReadOnlySpan{byte}, IFormatProvider?, out TSelf)" />
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, IFormatProvider? provider, out ExUInt128 result) => TryParse(utf8Text, NumberStyles.Integer, provider, out result);

        //
        // IBinaryIntegerParseAndFormatInfo
        //

        //static bool IBinaryIntegerParseAndFormatInfo<ExUInt128>.IsSigned => false;

        //static int IBinaryIntegerParseAndFormatInfo<ExUInt128>.MaxDigitCount => 39; // 340_282_366_920_938_463_463_374_607_431_768_211_455

        //static int IBinaryIntegerParseAndFormatInfo<ExUInt128>.MaxHexDigitCount => 32; // 0xFFFF_FFFF_FFFF_FFFF_FFFF_FFFF_FFFF_FFFF

        //static ExUInt128 IBinaryIntegerParseAndFormatInfo<ExUInt128>.MaxValueDiv10 => new ExUInt128(0x1999_9999_9999_9999, 0x9999_9999_9999_9999);

        //static string IBinaryIntegerParseAndFormatInfo<ExUInt128>.OverflowMessage => SR.Overflow_ExUInt128;

        //static bool IBinaryIntegerParseAndFormatInfo<ExUInt128>.IsGreaterThanAsUnsigned(ExUInt128 left, ExUInt128 right) => left > right;

        //static ExUInt128 IBinaryIntegerParseAndFormatInfo<ExUInt128>.MultiplyBy10(ExUInt128 value) => value * 10;

        //static ExUInt128 IBinaryIntegerParseAndFormatInfo<ExUInt128>.MultiplyBy16(ExUInt128 value) => value * 16;
    }

}
