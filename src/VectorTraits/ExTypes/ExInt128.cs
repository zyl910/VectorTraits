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

namespace Zyl.VectorTraits.ExTypes {

    /// <summary>Represents a 128-bit signed integer. It is binary compatible with <see cref="Int128"/> (表示 128 位有符号整数. 它与 <see cref="Int128"/> 是二进制兼容的).</summary>
    [StructLayout(LayoutKind.Sequential)]
    public readonly partial struct ExInt128: IFormattable, IComparable, IComparable<ExInt128>, IEquatable<ExInt128>
#if NET6_0_OR_GREATER
        , ISpanFormattable
#endif // NET6_0_OR_GREATER
#if NET7_0_OR_GREATER
        , IBinaryInteger<ExInt128>,
          IMinMaxValue<ExInt128>,
#if NET8_0_OR_GREATER
          IUtf8SpanFormattable,
#endif // NET8_0_OR_GREATER
          // IBinaryIntegerParseAndFormatInfo<ExInt128>, // internal
          ISignedNumber<ExInt128>
#endif // NET7_0_OR_GREATER
        {
        internal const int Size = 16;

#if BCL_TYPE_INT128
        private readonly Int128 _data;
#else
        private readonly ulong _data0;
        private readonly ulong _data1;
#endif

        /// <summary>Initializes a new instance of the <see cref="ExInt128" /> struct.</summary>
        /// <param name="upper">The upper 64-bits of the 128-bit value.</param>
        /// <param name="lower">The lower 64-bits of the 128-bit value.</param>
        [CLSCompliant(false)]
        public ExInt128(ulong upper, ulong lower) {
#if BCL_TYPE_INT128
            _data = new Int128(upper, lower);
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
        [CLSCompliant(false)]
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
        [CLSCompliant(false)]
        public ulong Upper {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if BCL_TYPE_INT128
                Int128 temp = _data;
                if (BitConverter.IsLittleEndian) {
                    return Unsafe.Add(ref Unsafe.As<Int128, ulong>(ref temp), 1);
                } else {
                    return Unsafe.As<Int128, ulong>(ref temp);
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
            if (value is ExInt128 other) {
                return CompareTo(other);
#if BCL_TYPE_INT128
            } else if (value is Int128) {
                return _data.CompareTo((Int128)value);
#endif
            } else if (value is null) {
                return 1;
            } else {
                throw new ArgumentException(SR.Arg_MustBeExInt128);
            }
        }

        /// <inheritdoc cref="IComparable{T}.CompareTo(T)" />
        public int CompareTo(ExInt128 value) {
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
            return (obj is ExInt128 other) && Equals(other);
        }

        /// <inheritdoc cref="IEquatable{T}.Equals(T)" />
        public bool Equals(ExInt128 other) {
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
            return Number.ExInt128ToDecStr(this);
#endif
        }

        /// <inheritdoc cref="Int128.ToString(IFormatProvider?)" />
        public string ToString(IFormatProvider? provider) {
#if BCL_TYPE_INT128
            return _data.ToString(provider);
#else
            return Number.FormatExInt128(this, null, provider);
#endif
        }

        /// <inheritdoc cref="Int128.ToString(string?)" />
        public string ToString(
#if NET7_0_OR_GREATER
            [StringSyntax(StringSyntaxAttribute.NumericFormat)]
#endif // NET7_0_OR_GREATER
            string? format) {
#if BCL_TYPE_INT128
            return _data.ToString(format);
#else
            return Number.FormatExInt128(this, format, null);
#endif
        }

        /// <inheritdoc cref="Int128.ToString(string?, IFormatProvider?)" />
        public string ToString(
#if NET7_0_OR_GREATER
            [StringSyntax(StringSyntaxAttribute.NumericFormat)]
#endif // NET7_0_OR_GREATER
            string? format, IFormatProvider? provider) {
#if BCL_TYPE_INT128
            return _data.ToString(format, provider);
#else
            return Number.FormatExInt128(this, format, provider);
#endif
        }

        /// <inheritdoc cref="Int128.TryFormat(Span{char}, out int, ReadOnlySpan{char}, IFormatProvider?)" />
        public bool TryFormat(Span<char> destination, out int charsWritten,
#if NET7_0_OR_GREATER
            [StringSyntax(StringSyntaxAttribute.NumericFormat)]
#endif // NET7_0_OR_GREATER
            ReadOnlySpan<char> format = default, IFormatProvider? provider = null) {
#if BCL_TYPE_INT128
            return _data.TryFormat(destination, out charsWritten, format, provider);
#else
            return Number.TryFormatExInt128(this, format, provider, destination, out charsWritten);
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
            return Number.TryFormatExInt128(this, format, provider, utf8Destination, out bytesWritten);
#endif
        }

        /// <inheritdoc cref="Int128.Parse(string)" />
        public static ExInt128 Parse(string s) => Parse(s, NumberStyles.Integer, provider: null);

        /// <inheritdoc cref="Int128.Parse(string, NumberStyles)" />
        public static ExInt128 Parse(string s, NumberStyles style) => Parse(s, style, provider: null);

        /// <inheritdoc cref="Int128.Parse(string, IFormatProvider?)" />
        public static ExInt128 Parse(string s, IFormatProvider? provider) => Parse(s, NumberStyles.Integer, provider);

        /// <inheritdoc cref="Int128.Parse(string, NumberStyles, IFormatProvider?)" />
        public static ExInt128 Parse(string s, NumberStyles style, IFormatProvider? provider) {
#if BCL_TYPE_INT128
            return Int128.Parse(s, style, provider);
#else
            if (s is null) { throw new ArgumentNullException(nameof(s)); }
            return Parse(s.AsSpan(), style, provider);
#endif
        }

        /// <inheritdoc cref="Int128.Parse(ReadOnlySpan{char}, NumberStyles, IFormatProvider?)" />
        public static ExInt128 Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.Integer, IFormatProvider? provider = null) {
#if BCL_TYPE_INT128
            return Int128.Parse(s, style, provider);
#else
            ExNumberFormatInfo.ValidateParseStyleInteger(style);
            return Number.ParseBinaryInteger<char, ExInt128>(s, style, NumberFormatInfo.GetInstance(provider));
#endif
        }

        /// <inheritdoc cref="Int128.TryParse(string?, out Int128)" />
        public static bool TryParse(
#if BCL_ATTR_NULL
            [NotNullWhen(true)]
#endif
            string? s, out ExInt128 result) => TryParse(s, NumberStyles.Integer, provider: null, out result);

        /// <inheritdoc cref="Int128.TryParse(ReadOnlySpan{char}, out Int128)" />
        public static bool TryParse(ReadOnlySpan<char> s, out ExInt128 result) => TryParse(s, NumberStyles.Integer, provider: null, out result);

        /// <inheritdoc cref="Int128.TryParse(ReadOnlySpan{byte}, out Int128)" />
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, out ExInt128 result) => TryParse(utf8Text, NumberStyles.Integer, provider: null, out result);

        /// <inheritdoc cref="Int128.TryParse(string?, NumberStyles, IFormatProvider?, out Int128)" />
        public static bool TryParse(
#if BCL_ATTR_NULL
            [NotNullWhen(true)]
#endif
            string? s, NumberStyles style, IFormatProvider? provider, out ExInt128 result) {
#if BCL_TYPE_INT128
            bool flag = Int128.TryParse(s, style, provider, out var rt);
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

        /// <inheritdoc cref="Int128.TryParse(ReadOnlySpan{char}, NumberStyles, IFormatProvider?, out Int128)" />
        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider, out ExInt128 result) {
#if BCL_TYPE_INT128
            bool flag = Int128.TryParse(s, style, provider, out var rt);
            result = rt;
            return flag;
#else
            ExNumberFormatInfo.ValidateParseStyleInteger(style);
            return Number.TryParseBinaryInteger(s, style, NumberFormatInfo.GetInstance(provider), out result) == Number.ParsingStatus.OK;
#endif
        }

        //
        // Explicit Conversions From ExInt128
        //

        /// <summary>Explicitly converts a 128-bit signed integer to a <see cref="byte" /> value.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="byte" />.</returns>
        public static explicit operator byte(ExInt128 value) {
#if BCL_TYPE_INT128
            return (byte)value._data;
#else
            return (byte)value.Lower;
#endif
        }

        /// <summary>Explicitly converts a 128-bit signed integer to a <see cref="byte" /> value, throwing an overflow exception for any values that fall outside the representable range.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="byte" />.</returns>
        /// <exception cref="OverflowException"><paramref name="value" /> is not representable by <see cref="ExInt128" />.</exception>
        public static explicit operator checked byte(ExInt128 value) {
#if BCL_TYPE_INT128
            return checked((byte)value._data);
#else
            if (value.Upper != 0) {
                ThrowHelper.ThrowOverflowException();
            }
            return checked((byte)value.Lower);
#endif
        }

        /// <summary>Explicitly converts a 128-bit signed integer to a <see cref="char" /> value.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="char" />.</returns>
        public static explicit operator char(ExInt128 value) {
#if BCL_TYPE_INT128
            return (char)value._data;
#else
            return (char)value.Lower;
#endif
        }

        /// <summary>Explicitly converts a 128-bit signed integer to a <see cref="char" /> value, throwing an overflow exception for any values that fall outside the representable range.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="char" />.</returns>
        /// <exception cref="OverflowException"><paramref name="value" /> is not representable by <see cref="ExInt128" />.</exception>
        public static explicit operator checked char(ExInt128 value) {
#if BCL_TYPE_INT128
            return checked((char)value._data);
#else
            if (value.Upper != 0) {
                ThrowHelper.ThrowOverflowException();
            }
            return checked((char)value.Lower);
#endif
        }

        /// <summary>Explicitly converts a 128-bit signed integer to a <see cref="decimal" /> value.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="decimal" />.</returns>
        public static explicit operator decimal(ExInt128 value) {
#if BCL_TYPE_INT128
            return (decimal)value._data;
#else
            if (IsNegative(value)) {
                value = -value;
                return -(decimal)(ExUInt128)(value);
            }
            return (decimal)(ExUInt128)(value);
#endif
        }

        /// <summary>Explicitly converts a 128-bit signed integer to a <see cref="double" /> value.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="double" />.</returns>
        public static explicit operator double(ExInt128 value) {
#if BCL_TYPE_INT128
            return (double)value._data;
#else
            if (IsNegative(value)) {
                value = -value;
                return -(double)(ExUInt128)(value);
            }
            return (double)(ExUInt128)(value);
#endif
        }

#if BCL_TYPE_HALF
        /// <summary>Explicitly converts a 128-bit signed integer to a <see cref="Half" /> value.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="Half" />.</returns>
        public static explicit operator Half(ExInt128 value) {
#if BCL_TYPE_INT128
            return (Half)value._data;
#else
            return (Half)(float)(value);
#endif
        }
#endif

        /// <summary>Explicitly converts a 128-bit signed integer to a <see cref="short" /> value.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="short" />.</returns>
        public static explicit operator short(ExInt128 value) {
#if BCL_TYPE_INT128
            return (short)value._data;
#else
            return (short)value.Lower;
#endif
        }

        /// <summary>Explicitly converts a 128-bit signed integer to a <see cref="short" /> value, throwing an overflow exception for any values that fall outside the representable range.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="short" />.</returns>
        /// <exception cref="OverflowException"><paramref name="value" /> is not representable by <see cref="ExInt128" />.</exception>
        public static explicit operator checked short(ExInt128 value) {
#if BCL_TYPE_INT128
            return checked((short)value._data);
#else
            long lower = (long)value.Lower;
            if ((long)value.Upper != lower >> 63) {
                ThrowHelper.ThrowOverflowException();
            }
            return checked((short)lower);
#endif
        }

        /// <summary>Explicitly converts a 128-bit signed integer to a <see cref="int" /> value.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="int" />.</returns>
        public static explicit operator int(ExInt128 value) {
#if BCL_TYPE_INT128
            return (int)value._data;
#else
            return (int)value.Lower;
#endif
        }

        /// <summary>Explicitly converts a 128-bit signed integer to a <see cref="int" /> value, throwing an overflow exception for any values that fall outside the representable range.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="int" />.</returns>
        /// <exception cref="OverflowException"><paramref name="value" /> is not representable by <see cref="ExInt128" />.</exception>
        public static explicit operator checked int(ExInt128 value) {
#if BCL_TYPE_INT128
            return checked((int)value._data);
#else
            long lower = (long)value.Lower;
            if ((long)value.Upper != lower >> 63) {
                ThrowHelper.ThrowOverflowException();
            }
            return checked((int)lower);
#endif
        }

        /// <summary>Explicitly converts a 128-bit signed integer to a <see cref="long" /> value.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="long" />.</returns>
        public static explicit operator long(ExInt128 value) {
#if BCL_TYPE_INT128
            return (long)value._data;
#else
            return (long)value.Lower;
#endif
        }

        /// <summary>Explicitly converts a 128-bit signed integer to a <see cref="long" /> value, throwing an overflow exception for any values that fall outside the representable range.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="long" />.</returns>
        /// <exception cref="OverflowException"><paramref name="value" /> is not representable by <see cref="ExInt128" />.</exception>
        public static explicit operator checked long(ExInt128 value) {
#if BCL_TYPE_INT128
            return checked((long)value._data);
#else
            long lower = (long)value.Lower;
            if ((long)value.Upper != lower >> 63) {
                ThrowHelper.ThrowOverflowException();
            }
            return lower;
#endif
        }

        /// <summary>Explicitly converts a 128-bit signed integer to a <see cref="IntPtr" /> value.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="IntPtr" />.</returns>
        public static explicit operator nint(ExInt128 value) {
#if BCL_TYPE_INT128
            return (nint)value._data;
#else
            return (nint)value.Lower;
#endif
        }

        /// <summary>Explicitly converts a 128-bit signed integer to a <see cref="IntPtr" /> value, throwing an overflow exception for any values that fall outside the representable range.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="IntPtr" />.</returns>
        /// <exception cref="OverflowException"><paramref name="value" /> is not representable by <see cref="ExInt128" />.</exception>
        public static explicit operator checked nint(ExInt128 value) {
#if BCL_TYPE_INT128
            return checked((nint)value._data);
#else
            long lower = (long)value.Lower;
            if ((long)value.Upper != lower >> 63) {
                ThrowHelper.ThrowOverflowException();
            }
            return checked((nint)lower);
#endif
        }

        /// <summary>Explicitly converts a 128-bit signed integer to a <see cref="sbyte" /> value.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="sbyte" />.</returns>
        [CLSCompliant(false)]
        public static explicit operator sbyte(ExInt128 value) {
#if BCL_TYPE_INT128
            return (sbyte)value._data;
#else
            return (sbyte)value.Lower;
#endif
        }

        /// <summary>Explicitly converts a 128-bit signed integer to a <see cref="sbyte" /> value, throwing an overflow exception for any values that fall outside the representable range.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="sbyte" />.</returns>
        /// <exception cref="OverflowException"><paramref name="value" /> is not representable by <see cref="ExInt128" />.</exception>
        [CLSCompliant(false)]
        public static explicit operator checked sbyte(ExInt128 value) {
#if BCL_TYPE_INT128
            return checked((sbyte)value._data);
#else
            long lower = (long)value.Lower;
            if ((long)value.Upper != lower >> 63) {
                ThrowHelper.ThrowOverflowException();
            }
            return checked((sbyte)lower);
#endif
        }

        /// <summary>Explicitly converts a 128-bit signed integer to a <see cref="float" /> value.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="float" />.</returns>
        public static explicit operator float(ExInt128 value) {
#if BCL_TYPE_INT128
            return (float)value._data;
#else
            if (IsNegative(value)) {
                value = -value;
                return -(float)(ExUInt128)(value);
            }
            return (float)(ExUInt128)(value);
#endif
        }

        /// <summary>Explicitly converts a 128-bit signed integer to a <see cref="ushort" /> value.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="ushort" />.</returns>
        [CLSCompliant(false)]
        public static explicit operator ushort(ExInt128 value) {
#if BCL_TYPE_INT128
            return (ushort)value._data;
#else
            return (ushort)value.Lower;
#endif
        }

        /// <summary>Explicitly converts a 128-bit signed integer to a <see cref="ushort" /> value, throwing an overflow exception for any values that fall outside the representable range.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="ushort" />.</returns>
        /// <exception cref="OverflowException"><paramref name="value" /> is not representable by <see cref="ExInt128" />.</exception>
        [CLSCompliant(false)]
        public static explicit operator checked ushort(ExInt128 value) {
#if BCL_TYPE_INT128
            return checked((ushort)value._data);
#else
            if (value.Upper != 0) {
                ThrowHelper.ThrowOverflowException();
            }
            return checked((ushort)value.Lower);
#endif
        }

        /// <summary>Explicitly converts a 128-bit signed integer to a <see cref="uint" /> value.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="uint" />.</returns>
        [CLSCompliant(false)]
        public static explicit operator uint(ExInt128 value) {
#if BCL_TYPE_INT128
            return (uint)value._data;
#else
            return (uint)value.Lower;
#endif
        }

        /// <summary>Explicitly converts a 128-bit signed integer to a <see cref="uint" /> value, throwing an overflow exception for any values that fall outside the representable range.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="uint" />.</returns>
        /// <exception cref="OverflowException"><paramref name="value" /> is not representable by <see cref="ExInt128" />.</exception>
        [CLSCompliant(false)]
        public static explicit operator checked uint(ExInt128 value) {
#if BCL_TYPE_INT128
            return checked((uint)value._data);
#else
            if (value.Upper != 0) {
                ThrowHelper.ThrowOverflowException();
            }
            return checked((uint)value.Lower);
#endif
        }

        /// <summary>Explicitly converts a 128-bit signed integer to a <see cref="ulong" /> value.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="ulong" />.</returns>
        [CLSCompliant(false)]
        public static explicit operator ulong(ExInt128 value) {
#if BCL_TYPE_INT128
            return (ulong)value._data;
#else
            return value.Lower;
#endif
        }

        /// <summary>Explicitly converts a 128-bit signed integer to a <see cref="ulong" /> value, throwing an overflow exception for any values that fall outside the representable range.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="ulong" />.</returns>
        /// <exception cref="OverflowException"><paramref name="value" /> is not representable by <see cref="ExInt128" />.</exception>
        [CLSCompliant(false)]
        public static explicit operator checked ulong(ExInt128 value) {
#if BCL_TYPE_INT128
            return checked((ulong)value._data);
#else
            if (value.Upper != 0) {
                ThrowHelper.ThrowOverflowException();
            }
            return value.Lower;
#endif
        }

        /// <summary>Explicitly converts a 128-bit signed integer to a <see cref="ExUInt128" /> value.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="ExUInt128" />.</returns>
        [CLSCompliant(false)]
        public static explicit operator ExUInt128(ExInt128 value) {
            return Unsafe.As<ExInt128, ExUInt128>(ref value);
        }


        /// <summary>Explicitly converts a 128-bit signed integer to a <see cref="ExUInt128" /> value, throwing an overflow exception for any values that fall outside the representable range.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="ExUInt128" />.</returns>
        /// <exception cref="OverflowException"><paramref name="value" /> is not representable by <see cref="ExInt128" />.</exception>
        [CLSCompliant(false)]
        public static explicit operator checked ExUInt128(ExInt128 value) {
#if BCL_TYPE_INT128
            return checked((UInt128)value._data);
#else
            if ((long)value.Upper < 0) {
                ThrowHelper.ThrowOverflowException();
            }
            return Unsafe.As<ExInt128, ExUInt128>(ref value);
#endif
        }

        /// <summary>Explicitly converts a 128-bit signed integer to a <see cref="UIntPtr" /> value.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="UIntPtr" />.</returns>
        [CLSCompliant(false)]
        public static explicit operator nuint(ExInt128 value) {
#if BCL_TYPE_INT128
            return (nuint)value._data;
#else
            return (nuint)value.Lower;
#endif
        }

        /// <summary>Explicitly converts a 128-bit signed integer to a <see cref="UIntPtr" /> value, throwing an overflow exception for any values that fall outside the representable range.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="UIntPtr" />.</returns>
        /// <exception cref="OverflowException"><paramref name="value" /> is not representable by <see cref="ExInt128" />.</exception>
        [CLSCompliant(false)]
        public static explicit operator checked nuint(ExInt128 value) {
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
        // Explicit Conversions To ExInt128
        //

        /// <summary>Explicitly converts a <see cref="decimal" /> value to a 128-bit signed integer.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit signed integer.</returns>
        public static explicit operator ExInt128(decimal value) {
#if BCL_TYPE_INT128
            return (Int128)(value);
#else
            value = decimal.Truncate(value);
            ulong low64 = ExBitUtil.DecodeDecimalOn64(value, out uint high);
            ExInt128 result = new ExInt128(high, low64);

            if (MathINumberBase.IsNegative(value)) {
                result = -result;
            }
            return result;
#endif
        }

        /// <summary>Explicitly converts a <see cref="double" /> value to a 128-bit signed integer.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit signed integer.</returns>
        public static explicit operator ExInt128(double value) {
#if BCL_TYPE_INT128
            return (Int128)(value);
#else
            const double TwoPow127 = 170141183460469231731687303715884105728.0;

            if (value <= -TwoPow127) {
                return MinValue;
            } else if (double.IsNaN(value)) {
                return 0;
            } else if (value >= +TwoPow127) {
                return MaxValue;
            }

            return ToExInt128(value);
#endif
        }

        /// <summary>Explicitly converts a <see cref="double" /> value to a 128-bit signed integer, throwing an overflow exception for any values that fall outside the representable range.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit signed integer.</returns>
        /// <exception cref="OverflowException"><paramref name="value" /> is not representable by <see cref="ExInt128" />.</exception>
        public static explicit operator checked ExInt128(double value) {
#if BCL_TYPE_INT128
            return checked((Int128)(value));
#else
            const double TwoPow127 = 170141183460469231731687303715884105728.0;

            if ((value < -TwoPow127) || double.IsNaN(value) || (value >= +TwoPow127)) {
                ThrowHelper.ThrowOverflowException();
            }

            return ToExInt128(value);
#endif
        }

        internal static ExInt128 ToExInt128(double value) {
            const double TwoPow127 = 170141183460469231731687303715884105728.0;

            Debug.Assert(value >= -TwoPow127);
            Debug.Assert(MathINumberBase.IsFinite(value));
            Debug.Assert(value < TwoPow127);

            // This code is based on `f64_to_i128` from m-ou-se/floatconv
            // Copyright (c) 2020 Mara Bos <m-ou.se@m-ou.se>. All rights reserved.
            //
            // Licensed under the BSD 2 - Clause "Simplified" License
            // See THIRD-PARTY-NOTICES.TXT for the full license text

            bool isNegative = MathINumberBase.IsNegative(value);

            if (isNegative) {
                value = -value;
            }

            if (value >= 1.0) {
                // In order to convert from double to int128 we first need to extract the signficand,
                // including the implicit leading bit, as a full 128-bit significand. We can then adjust
                // this down to the represented integer by right shifting by the unbiased exponent, taking
                // into account the significand is now represented as 128-bits.

                ulong bits = MathBitConverter.DoubleToUInt64Bits(value);
                ExInt128 result = new ExInt128((bits << 12) >> 1 | 0x8000_0000_0000_0000, 0x0000_0000_0000_0000);

                result >>>= (1023 + 128 - 1 - (int)(bits >> 52));

                if (isNegative) {
                    result = -result;
                }
                return result;
            } else {
                return 0;
            }
        }

        /// <summary>Explicitly converts a <see cref="float" /> value to a 128-bit signed integer.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit signed integer.</returns>
        public static explicit operator ExInt128(float value) {
#if BCL_TYPE_INT128
            return (Int128)(value);
#else
            return (ExInt128)(double)(value);
#endif
        }

        /// <summary>Explicitly converts a <see cref="float" /> value to a 128-bit signed integer, throwing an overflow exception for any values that fall outside the representable range.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit signed integer.</returns>
        /// <exception cref="OverflowException"><paramref name="value" /> is not representable by <see cref="ExInt128" />.</exception>
        public static explicit operator checked ExInt128(float value) {
#if BCL_TYPE_INT128
            return checked((Int128)(value));
#else
            return checked((ExInt128)(double)(value));
#endif
        }

        //
        // Implicit Conversions To ExInt128
        //

        /// <summary>Implicitly converts a <see cref="byte" /> value to a 128-bit signed integer.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit signed integer.</returns>
        public static implicit operator ExInt128(byte value) => new ExInt128(0, value);

        /// <summary>Implicitly converts a <see cref="char" /> value to a 128-bit signed integer.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit signed integer.</returns>
        public static implicit operator ExInt128(char value) => new ExInt128(0, value);

        /// <summary>Implicitly converts a <see cref="short" /> value to a 128-bit signed integer.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit signed integer.</returns>
        public static implicit operator ExInt128(short value) {
#if BCL_TYPE_INT128
            return (Int128)(value);
#else
            long lower = value;
            return new ExInt128((ulong)(lower >> 63), (ulong)lower);
#endif
        }

        /// <summary>Implicitly converts a <see cref="int" /> value to a 128-bit signed integer.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit signed integer.</returns>
        public static implicit operator ExInt128(int value) {
#if BCL_TYPE_INT128
            return (Int128)(value);
#else
            long lower = value;
            return new ExInt128((ulong)(lower >> 63), (ulong)lower);
#endif
        }

        /// <summary>Implicitly converts a <see cref="long" /> value to a 128-bit signed integer.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit signed integer.</returns>
        public static implicit operator ExInt128(long value) {
#if BCL_TYPE_INT128
            return (Int128)(value);
#else
            long lower = value;
            return new ExInt128((ulong)(lower >> 63), (ulong)lower);
#endif
        }

        /// <summary>Implicitly converts a <see cref="IntPtr" /> value to a 128-bit signed integer.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit signed integer.</returns>
        public static implicit operator ExInt128(nint value) {
#if BCL_TYPE_INT128
            return (Int128)(value);
#else
            long lower = value;
            return new ExInt128((ulong)(lower >> 63), (ulong)lower);
#endif
        }

        /// <summary>Implicitly converts a <see cref="sbyte" /> value to a 128-bit signed integer.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit signed integer.</returns>
        [CLSCompliant(false)]
        public static implicit operator ExInt128(sbyte value) {
#if BCL_TYPE_INT128
            return (Int128)(value);
#else
            long lower = value;
            return new ExInt128((ulong)(lower >> 63), (ulong)lower);
#endif
        }

        /// <summary>Implicitly converts a <see cref="ushort" /> value to a 128-bit signed integer.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit signed integer.</returns>
        [CLSCompliant(false)]
        public static implicit operator ExInt128(ushort value) => new ExInt128(0, value);

        /// <summary>Implicitly converts a <see cref="uint" /> value to a 128-bit signed integer.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit signed integer.</returns>
        [CLSCompliant(false)]
        public static implicit operator ExInt128(uint value) => new ExInt128(0, value);

        /// <summary>Implicitly converts a <see cref="ulong" /> value to a 128-bit signed integer.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit signed integer.</returns>
        [CLSCompliant(false)]
        public static implicit operator ExInt128(ulong value) => new ExInt128(0, value);

        /// <summary>Implicitly converts a <see cref="UIntPtr" /> value to a 128-bit signed integer.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit signed integer.</returns>
        [CLSCompliant(false)]
        public static implicit operator ExInt128(nuint value) => new ExInt128(0, value);

        //
        // IAdditionOperators
        //

        /// <inheritdoc cref="IAdditionOperators{TSelf, TOther, TResult}.op_Addition(TSelf, TOther)" />
        public static ExInt128 operator +(ExInt128 left, ExInt128 right) {
#if BCL_TYPE_INT128
            return left._data + right._data;
#else
            // For unsigned addition, we can detect overflow by checking `(x + y) < x`
            // This gives us the carry to add to upper to compute the correct result

            ulong lower = left.Lower + right.Lower;
            ulong carry = (lower < left.Lower) ? 1UL : 0UL;

            ulong upper = left.Upper + right.Upper + carry;
            return new ExInt128(upper, lower);
#endif
        }

        /// <inheritdoc cref="IAdditionOperators{TSelf, TOther, TResult}.op_Addition(TSelf, TOther)" />
        public static ExInt128 operator checked +(ExInt128 left, ExInt128 right) {
#if BCL_TYPE_INT128
            return checked(left._data + right._data);
#else
            // For signed addition, we can detect overflow by checking if the sign of
            // both inputs are the same and then if that differs from the sign of the
            // output.

            ExInt128 result = left + right;

            uint sign = (uint)(left.Upper >> 63);

            if (sign == (uint)(right.Upper >> 63)) {
                if (sign != (uint)(result.Upper >> 63)) {
                    ThrowHelper.ThrowOverflowException();
                }
            }
            return result;
#endif
        }

        //
        // IAdditiveIdentity
        //

#if GENERICS_MATH
        /// <inheritdoc cref="IAdditiveIdentity{TSelf, TResult}.AdditiveIdentity" />
        static ExInt128 IAdditiveIdentity<ExInt128, ExInt128>.AdditiveIdentity => default;
#endif

        //
        // IBinaryInteger
        //

        /// <inheritdoc cref="IBinaryInteger{TSelf}.DivRem(TSelf, TSelf)" />
        public static (ExInt128 Quotient, ExInt128 Remainder) DivRem(ExInt128 left, ExInt128 right) {
#if BCL_TYPE_INT128
            return Int128.DivRem(left._data, right._data);
#else
            ExInt128 quotient = left / right;
            return (quotient, left - (quotient * right));
#endif
        }

        /// <inheritdoc cref="IBinaryInteger{TSelf}.LeadingZeroCount(TSelf)" />
        public static ExInt128 LeadingZeroCount(ExInt128 value) {
#if BCL_TYPE_INT128
            return Int128.LeadingZeroCount(value._data);
#else
            return LeadingZeroCountAsInt32(value);
#endif
        }

        /// <summary>Computes the number of leading zero bits in this value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static int LeadingZeroCountAsInt32(ExInt128 value) {
            if (value.Upper == 0) {
                return 64 + MathBitOperations.LeadingZeroCount(value.Lower);
            }
            return MathBitOperations.LeadingZeroCount(value.Upper);
        }

        /// <inheritdoc cref="IBinaryInteger{TSelf}.PopCount(TSelf)" />
        public static ExInt128 PopCount(ExInt128 value) {
#if BCL_TYPE_INT128
            return Int128.PopCount(value._data);
#else
            return MathBitOperations.PopCount(value.Lower) + MathBitOperations.PopCount(value.Upper);
#endif
        }

        /// <inheritdoc cref="IBinaryInteger{TSelf}.RotateLeft(TSelf, int)" />
        public static ExInt128 RotateLeft(ExInt128 value, int rotateAmount) {
#if BCL_TYPE_INT128
            return Int128.RotateLeft(value._data, rotateAmount);
#else
            return (value << rotateAmount) | (value >>> (128 - rotateAmount));
#endif
        }

        /// <inheritdoc cref="IBinaryInteger{TSelf}.RotateRight(TSelf, int)" />
        public static ExInt128 RotateRight(ExInt128 value, int rotateAmount) {
#if BCL_TYPE_INT128
            return Int128.RotateRight(value._data, rotateAmount);
#else
            return (value >>> rotateAmount) | (value << (128 - rotateAmount));
#endif
        }

        /// <inheritdoc cref="IBinaryInteger{TSelf}.TrailingZeroCount(TSelf)" />
        public static ExInt128 TrailingZeroCount(ExInt128 value) {
#if BCL_TYPE_INT128
            return Int128.TrailingZeroCount(value._data);
#else
            if (value.Lower == 0) {
                return 64 + MathBitOperations.TrailingZeroCount(value.Upper);
            }
            return MathBitOperations.TrailingZeroCount(value.Lower);
#endif
        }

        /// <inheritdoc cref="IBinaryInteger{TSelf}.TryReadBigEndian(ReadOnlySpan{byte}, bool, out TSelf)" />
        public static bool TryReadBigEndian(ReadOnlySpan<byte> source, bool isUnsigned, out ExInt128 value) {
#if BCL_TYPE_INT128
            bool flag = CallIBinaryInteger.TryReadBigEndian(source, isUnsigned, out Int128 avalue);
            value = avalue;
            return flag;
#else
            ExInt128 result = default;

            if (source.Length != 0) {
                // Propagate the most significant bit so we have `0` or `-1`
                sbyte sign = (sbyte)(source[0]);
                sign >>= 31;
                Debug.Assert((sign == 0) || (sign == -1));

                // We need to also track if the input data is unsigned
                isUnsigned |= (sign == 0);

                if (isUnsigned && BitMath.IsNegative(sign) && (source.Length >= Size)) {
                    // When we are unsigned and the most significant bit is set, we are a large positive
                    // and therefore definitely out of range

                    value = result;
                    return false;
                }

                if (source.Length > Size) {
                    if (ExBitUtil.ContainsAnyExcept(source.Slice(0, source.Length - Size), (byte)sign)) {
                        // When we are unsigned and have any non-zero leading data or signed with any non-set leading
                        // data, we are a large positive/negative, respectively, and therefore definitely out of range

                        value = result;
                        return false;
                    }

                    if (isUnsigned == BitMath.IsNegative((sbyte)source[source.Length - Size])) {
                        // When the most significant bit of the value being set/clear matches whether we are unsigned
                        // or signed then we are a large positive/negative and therefore definitely out of range

                        value = result;
                        return false;
                    }
                }

                ref byte sourceRef = ref MemoryMarshal.GetReference(source);

                if (source.Length >= Size) {
                    sourceRef = ref Unsafe.Add(ref sourceRef, source.Length - Size);

                    // We have at least 16 bytes, so just read the ones we need directly
                    result = Unsafe.ReadUnaligned<ExInt128>(ref sourceRef);

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

                    if (!isUnsigned) {
                        result |= ((One << ((Size * 8) - 1)) >> (((Size - source.Length) * 8) - 1));
                    }
                }
            }

            value = result;
            return true;
#endif
        }

        /// <inheritdoc cref="IBinaryInteger{TSelf}.TryReadLittleEndian(ReadOnlySpan{byte}, bool, out TSelf)" />
        public static bool TryReadLittleEndian(ReadOnlySpan<byte> source, bool isUnsigned, out ExInt128 value) {
#if BCL_TYPE_INT128
            bool flag = CallIBinaryInteger.TryReadLittleEndian(source, isUnsigned, out Int128 avalue);
            value = avalue;
            return flag;
#else
            ExInt128 result = default;

            if (source.Length != 0) {
                // Propagate the most significant bit so we have `0` or `-1`
                sbyte sign = (sbyte)(source[source.Length - 1]);
                sign >>= 31;
                Debug.Assert((sign == 0) || (sign == -1));

                // We need to also track if the input data is unsigned
                isUnsigned |= (sign == 0);

                if (isUnsigned && BitMath.IsNegative(sign) && (source.Length >= Size)) {
                    // When we are unsigned and the most significant bit is set, we are a large positive
                    // and therefore definitely out of range

                    value = result;
                    return false;
                }

                if (source.Length > Size) {
                    if (ExBitUtil.ContainsAnyExcept(source.Slice(Size), (byte)sign)) {
                        // When we are unsigned and have any non-zero leading data or signed with any non-set leading
                        // data, we are a large positive/negative, respectively, and therefore definitely out of range

                        value = result;
                        return false;
                    }

                    if (isUnsigned == BitMath.IsNegative((sbyte)source[Size - 1])) {
                        // When the most significant bit of the value being set/clear matches whether we are unsigned
                        // or signed then we are a large positive/negative and therefore definitely out of range

                        value = result;
                        return false;
                    }
                }

                ref byte sourceRef = ref MemoryMarshal.GetReference(source);

                if (source.Length >= Size) {
                    // We have at least 16 bytes, so just read the ones we need directly
                    result = Unsafe.ReadUnaligned<ExInt128>(ref sourceRef);

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
                        result <<= 8;
                        result |= Unsafe.Add(ref sourceRef, i);
                    }

                    result <<= ((Size - source.Length) * 8);
                    result = MathBinaryPrimitives.ReverseEndianness(result);

                    if (!isUnsigned) {
                        result |= ((One << ((Size * 8) - 1)) >> (((Size - source.Length) * 8) - 1));
                    }
                }
            }

            value = result;
            return true;
#endif
        }

        /// <inheritdoc cref="IBinaryInteger{TSelf}.GetShortestBitLength()" />
        public int GetShortestBitLength() {
            ExInt128 value = this;

            if (IsPositive(value)) {
                return (Size * 8) - LeadingZeroCountAsInt32(value);
            } else {
                return (Size * 8) + 1 - LeadingZeroCountAsInt32(~value);
            }
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
#endif
        }

        /// <inheritdoc cref="IBinaryInteger{TSelf}.TryWriteLittleEndian(Span{byte}, out int)" />
        public bool TryWriteLittleEndian(Span<byte> destination, out int bytesWritten) {
#if BCL_TYPE_INT128
            return CallIBinaryInteger.TryWriteBigEndian(_data, destination, out bytesWritten);
#else
            if (destination.Length >= Size) {
                ulong lower = Lower;
                ulong upper = Upper;

                if (!BitConverter.IsLittleEndian) {
                    lower = BinaryPrimitives.ReverseEndianness(lower);
                    upper = BinaryPrimitives.ReverseEndianness(upper);
                }

                ref byte address = ref MemoryMarshal.GetReference(destination);

                Unsafe.WriteUnaligned(ref address, lower);
                Unsafe.WriteUnaligned(ref Unsafe.AddByteOffset(ref address, (nint)sizeof(ulong)), upper);

                bytesWritten = Size;
                return true;
            } else {
                bytesWritten = 0;
                return false;
            }
#endif
        }

        //
        // IBinaryNumber
        //

        /// <inheritdoc cref="IBinaryNumber{TSelf}.AllBitsSet" />
        public static ExInt128 AllBitsSet => new ExInt128(0xFFFF_FFFF_FFFF_FFFF, 0xFFFF_FFFF_FFFF_FFFF);

        /// <inheritdoc cref="IBinaryNumber{TSelf}.IsPow2(TSelf)" />
        public static bool IsPow2(ExInt128 value) {
#if BCL_TYPE_INT128
            return Int128.IsPow2(value._data);
#else
            return (PopCount(value) == 1U) && IsPositive(value);
#endif
        }

        /// <inheritdoc cref="IBinaryNumber{TSelf}.Log2(TSelf)" />
        public static ExInt128 Log2(ExInt128 value) {
#if BCL_TYPE_INT128
            return Int128.Log2(value._data);
#else
            if (IsNegative(value)) {
                ThrowHelper.ThrowValueArgumentOutOfRange_NeedNonNegNumException();
            }

            if (value.Upper == 0) {
                return MathBitOperations.Log2(value.Lower);
            }
            return 64 + MathBitOperations.Log2(value.Upper);
#endif
        }

        //
        // IBitwiseOperators
        //

        /// <inheritdoc cref="IBitwiseOperators{TSelf, TOther, TResult}.op_BitwiseAnd(TSelf, TOther)" />
        public static ExInt128 operator &(ExInt128 left, ExInt128 right) {
#if BCL_TYPE_INT128
            return left._data & right._data;
#else
            return new ExInt128(left.Upper & right.Upper, left.Lower & right.Lower);
#endif
        }

        /// <inheritdoc cref="IBitwiseOperators{TSelf, TOther, TResult}.op_BitwiseOr(TSelf, TOther)" />
        public static ExInt128 operator |(ExInt128 left, ExInt128 right) {
#if BCL_TYPE_INT128
            return left._data | right._data;
#else
            return new ExInt128(left.Upper | right.Upper, left.Lower | right.Lower);
#endif
        }

        /// <inheritdoc cref="IBitwiseOperators{TSelf, TOther, TResult}.op_ExclusiveOr(TSelf, TOther)" />
        public static ExInt128 operator ^(ExInt128 left, ExInt128 right) {
#if BCL_TYPE_INT128
            return left._data ^ right._data;
#else
            return new ExInt128(left.Upper ^ right.Upper, left.Lower ^ right.Lower);
#endif
        }

        /// <inheritdoc cref="IBitwiseOperators{TSelf, TOther, TResult}.op_OnesComplement(TSelf)" />
        public static ExInt128 operator ~(ExInt128 value) {
#if BCL_TYPE_INT128
            return ~value._data;
#else
            return new ExInt128(~value.Upper, ~value.Lower);
#endif
        }

        //
        // IComparisonOperators
        //

        /// <inheritdoc cref="IComparisonOperators{TSelf, TOther, TResult}.op_LessThan(TSelf, TOther)" />
        public static bool operator <(ExInt128 left, ExInt128 right) {
#if BCL_TYPE_INT128
            return left._data < right._data;
#else
            // If left and right have different signs: Signed comparison of Upper gives result since it is stored as two's complement
            // If signs are equal and left.Upper < right.Upper: left < right for negative and positive values,
            //                                                    since Upper is upper 64 bits in two's complement.
            // If signs are equal and left.Upper > right.Upper: left > right for negative and positive values,
            //                                                    since Upper is upper 64 bits in two's complement.
            // If left.Upper == right.Upper: unsigned comparison of Lower gives the result for both negative and positive values since
            //                                 lower values are lower 64 bits in two's complement.
            return ((long)left.Upper < (long)right.Upper)
                || ((left.Upper == right.Upper) && (left.Lower < right.Lower));
#endif
        }

        /// <inheritdoc cref="IComparisonOperators{TSelf, TOther, TResult}.op_LessThanOrEqual(TSelf, TOther)" />
        public static bool operator <=(ExInt128 left, ExInt128 right) {
#if BCL_TYPE_INT128
            return left._data <= right._data;
#else
            // See comment in < operator for how this works.
            return ((long)left.Upper < (long)right.Upper)
                || ((left.Upper == right.Upper) && (left.Lower <= right.Lower));
#endif
        }

        /// <inheritdoc cref="IComparisonOperators{TSelf, TOther, TResult}.op_GreaterThan(TSelf, TOther)" />
        public static bool operator >(ExInt128 left, ExInt128 right) {
#if BCL_TYPE_INT128
            return left._data > right._data;
#else
            // See comment in < operator for how this works.
            return ((long)left.Upper > (long)right.Upper)
                || ((left.Upper == right.Upper) && (left.Lower > right.Lower));
#endif
        }

        /// <inheritdoc cref="IComparisonOperators{TSelf, TOther, TResult}.op_GreaterThanOrEqual(TSelf, TOther)" />
        public static bool operator >=(ExInt128 left, ExInt128 right) {
#if BCL_TYPE_INT128
            return left._data >= right._data;
#else
            // See comment in < operator for how this works.
            return ((long)left.Upper > (long)right.Upper)
                || ((left.Upper == right.Upper) && (left.Lower >= right.Lower));
#endif
        }

        //
        // IDecrementOperators
        //

        /// <inheritdoc cref="IDecrementOperators{TSelf}.op_Decrement(TSelf)" />
        public static ExInt128 operator --(ExInt128 value) {
#if BCL_TYPE_INT128
            return value._data - Int128.One;
#else
            return value - One;
#endif
        }

        /// <inheritdoc cref="IDecrementOperators{TSelf}.op_Decrement(TSelf)" />
        public static ExInt128 operator checked --(ExInt128 value) {
#if BCL_TYPE_INT128
            return checked(value._data - Int128.One);
#else
            return checked(value - One);
#endif
        }

        //
        // IDivisionOperators
        //

        /// <inheritdoc cref="IDivisionOperators{TSelf, TOther, TResult}.op_Division(TSelf, TOther)" />
        public static ExInt128 operator /(ExInt128 left, ExInt128 right) {
#if BCL_TYPE_INT128
            return left._data / right._data;
#else
            if ((right == -1) && (left.Upper == 0x8000_0000_0000_0000) && (left.Lower == 0)) {
                ThrowHelper.ThrowOverflowException();
            }

            // We simplify the logic here by just doing unsigned division on the
            // two's complement representation and then taking the correct sign.

            ulong sign = (left.Upper ^ right.Upper) & (1UL << 63);

            if (IsNegative(left)) {
                left = ~left + 1U;
            }

            if (IsNegative(right)) {
                right = ~right + 1U;
            }

            ExUInt128 result = (ExUInt128)(left) / (ExUInt128)(right);

            if (sign != 0) {
                result = ~result + 1U;
            }

            return (ExInt128)result;
#endif
        }

        /// <inheritdoc cref="IDivisionOperators{TSelf, TOther, TResult}.op_CheckedDivision(TSelf, TOther)" />
        public static ExInt128 operator checked /(ExInt128 left, ExInt128 right) {
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
        public static bool operator ==(ExInt128 left, ExInt128 right) {
#if BCL_TYPE_INT128
            return left._data == right._data;
#else
            return (left.Lower == right.Lower) && (left.Upper == right.Upper);
#endif
        }

        /// <inheritdoc cref="IEqualityOperators{TSelf, TOther, TResult}.op_Inequality(TSelf, TOther)" />
        public static bool operator !=(ExInt128 left, ExInt128 right) {
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
        public static ExInt128 operator ++(ExInt128 value) {
#if BCL_TYPE_INT128
            return value._data + Int128.One;
#else
            return value + One;
#endif
        }

        /// <inheritdoc cref="IIncrementOperators{TSelf}.op_CheckedIncrement(TSelf)" />
        public static ExInt128 operator checked ++(ExInt128 value) {
#if BCL_TYPE_INT128
            return checked(value._data + Int128.One);
#else
            return checked(value + One);
#endif
        }

        //
        // IMinMaxValue
        //

        /// <inheritdoc cref="IMinMaxValue{TSelf}.MinValue" />
        public static ExInt128 MinValue =>
#if BCL_TYPE_INT128
            Int128.MinValue;
#else
            new ExInt128(0x8000_0000_0000_0000, 0);
#endif

        /// <inheritdoc cref="IMinMaxValue{TSelf}.MaxValue" />
        public static ExInt128 MaxValue =>
#if BCL_TYPE_INT128
            Int128.MaxValue;
#else
            new ExInt128(0x7FFF_FFFF_FFFF_FFFF, 0xFFFF_FFFF_FFFF_FFFF);
#endif

        //
        // IModulusOperators
        //

        /// <inheritdoc cref="IModulusOperators{TSelf, TOther, TResult}.op_Modulus(TSelf, TOther)" />
        public static ExInt128 operator %(ExInt128 left, ExInt128 right) {
#if BCL_TYPE_INT128
            return left._data % right._data;
#else
            ExInt128 quotient = left / right;
            return left - (quotient * right);
#endif
        }

        //
        // IMultiplicativeIdentity
        //

#if GENERICS_MATH
        /// <inheritdoc cref="IMultiplicativeIdentity{TSelf, TResult}.MultiplicativeIdentity" />
        static ExInt128 IMultiplicativeIdentity<ExInt128, ExInt128>.MultiplicativeIdentity => One;
#endif // GENERICS_MATH

        //
        // IMultiplyOperators
        //

        /// <inheritdoc cref="IMultiplyOperators{TSelf, TOther, TResult}.op_Multiply(TSelf, TOther)" />
        public static ExInt128 operator *(ExInt128 left, ExInt128 right) {
#if BCL_TYPE_INT128
            return left._data * right._data;
#else
            // Multiplication is the same for signed and unsigned provided the "upper" bits aren't needed
            return (ExInt128)((ExUInt128)(left) * (ExUInt128)(right));
#endif
        }

        /// <inheritdoc cref="IMultiplyOperators{TSelf, TOther, TResult}.op_CheckedMultiply(TSelf, TOther)" />
        public static ExInt128 operator checked *(ExInt128 left, ExInt128 right) {
#if BCL_TYPE_INT128
            return unchecked(left._data * right._data);
#else
            ExInt128 upper = BigMul(left, right, out ExInt128 lower);

            if (((upper != 0) || (lower < 0)) && ((~upper != 0) || (lower >= 0))) {
                // The upper bits can safely be either Zero or AllBitsSet
                // where the former represents a positive value and the
                // latter a negative value.
                //
                // However, when the upper bits are Zero, we also need to
                // confirm the lower bits are positive, otherwise we have
                // a positive value greater than MaxValue and should throw
                //
                // Likewise, when the upper bits are AllBitsSet, we also
                // need to confirm the lower bits are negative, otherwise
                // we have a large negative value less than MinValue and
                // should throw.

                ThrowHelper.ThrowOverflowException();
            }

            return lower;
#endif
        }

        internal static ExInt128 BigMul(ExInt128 left, ExInt128 right, out ExInt128 lower) {
            // This follows the same logic as is used in `long Math.BigMul(long, long, out long)`

            ExUInt128 upper = ExUInt128.BigMul((ExUInt128)(left), (ExUInt128)(right), out ExUInt128 ulower);
            lower = (ExInt128)(ulower);
            return (ExInt128)(upper) - ((left >> 127) & right) - ((right >> 127) & left);
        }

        //
        // INumber
        //

        /// <inheritdoc cref="INumber{TSelf}.Clamp(TSelf, TSelf, TSelf)" />
        public static ExInt128 Clamp(ExInt128 value, ExInt128 min, ExInt128 max) {
#if BCL_TYPE_INT128
            return Int128.Clamp(value._data, min._data, max._data);
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
        public static ExInt128 CopySign(ExInt128 value, ExInt128 sign) {
#if BCL_TYPE_INT128
            return Int128.CopySign(value._data, sign._data);
#else
            ExInt128 absValue = value;

            if (IsNegative(absValue)) {
                absValue = -absValue;
            }

            if (IsPositive(sign)) {
                if (IsNegative(absValue)) {
                    ThrowHelper.ThrowNegateTwosCompOverflow();
                }
                return absValue;
            }
            return -absValue;
#endif
        }

        /// <inheritdoc cref="INumber{TSelf}.Max(TSelf, TSelf)" />
        public static ExInt128 Max(ExInt128 x, ExInt128 y) {
#if BCL_TYPE_INT128
            return Int128.Max(x._data, y._data);
#else
            return (x >= y) ? x : y;
#endif
        }

#if GENERICS_MATH
        /// <inheritdoc cref="INumber{TSelf}.MaxNumber(TSelf, TSelf)" />
        static ExInt128 INumber<ExInt128>.MaxNumber(ExInt128 x, ExInt128 y) => Max(x, y);
#endif // GENERICS_MATH

        /// <inheritdoc cref="INumber{TSelf}.Min(TSelf, TSelf)" />
        public static ExInt128 Min(ExInt128 x, ExInt128 y) {
#if BCL_TYPE_INT128
            return Int128.Min(x._data, y._data);
#else
            return (x <= y) ? x : y;
#endif
        }

#if GENERICS_MATH
        /// <inheritdoc cref="INumber{TSelf}.MinNumber(TSelf, TSelf)" />
        static ExInt128 INumber<ExInt128>.MinNumber(ExInt128 x, ExInt128 y) => Min(x, y);
#endif // GENERICS_MATH

        /// <inheritdoc cref="INumber{TSelf}.Sign(TSelf)" />
        public static int Sign(ExInt128 value) {
#if BCL_TYPE_INT128
            return Int128.Sign(value._data);
#else
            if (IsNegative(value)) {
                return -1;
            } else if (value != default) {
                return 1;
            } else {
                return 0;
            }
#endif
        }

        //
        // INumberBase
        //

        /// <inheritdoc cref="INumberBase{TSelf}.One" />
        public static ExInt128 One =>
#if BCL_TYPE_INT128
            Int128.One;
#else
            new ExInt128(0, 1);
#endif

#if GENERICS_MATH
        /// <inheritdoc cref="INumberBase{TSelf}.Radix" />
        static int INumberBase<ExInt128>.Radix => 2;
#endif // GENERICS_MATH

        /// <inheritdoc cref="INumberBase{TSelf}.Zero" />
        public static ExInt128 Zero => default;

        /// <inheritdoc cref="INumberBase{TSelf}.Abs(TSelf)" />
        public static ExInt128 Abs(ExInt128 value) {
#if BCL_TYPE_INT128
            return Int128.Abs(value._data);
#else
            if (IsNegative(value)) {
                value = -value;

                if (IsNegative(value)) {
                    ThrowHelper.ThrowNegateTwosCompOverflow();
                }
            }
            return value;
#endif
        }

#if GENERICS_MATH
        /// <inheritdoc cref="INumberBase{TSelf}.CreateChecked{TOther}(TOther)" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ExInt128 CreateChecked<TOther>(TOther value)
            where TOther : INumberBase<TOther> {
            return Int128.CreateChecked(value);
        }

        /// <inheritdoc cref="INumberBase{TSelf}.CreateSaturating{TOther}(TOther)" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ExInt128 CreateSaturating<TOther>(TOther value)
            where TOther : INumberBase<TOther> {
            return Int128.CreateSaturating(value);
        }

        /// <inheritdoc cref="INumberBase{TSelf}.CreateTruncating{TOther}(TOther)" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ExInt128 CreateTruncating<TOther>(TOther value)
            where TOther : INumberBase<TOther> {
            return Int128.CreateTruncating(value);
        }

        /// <inheritdoc cref="INumberBase{TSelf}.IsCanonical(TSelf)" />
        static bool INumberBase<ExInt128>.IsCanonical(ExInt128 value) => true;

        /// <inheritdoc cref="INumberBase{TSelf}.IsComplexNumber(TSelf)" />
        static bool INumberBase<ExInt128>.IsComplexNumber(ExInt128 value) => false;
#endif // GENERICS_MATH

        /// <inheritdoc cref="INumberBase{TSelf}.IsEvenInteger(TSelf)" />
        public static bool IsEvenInteger(ExInt128 value) {
#if BCL_TYPE_INT128
            return Int128.IsEvenInteger(value._data);
#else
            return (value.Lower & 1) == 0;
#endif
        }

#if GENERICS_MATH
        /// <inheritdoc cref="INumberBase{TSelf}.IsFinite(TSelf)" />
        static bool INumberBase<ExInt128>.IsFinite(ExInt128 value) => true;

        /// <inheritdoc cref="INumberBase{TSelf}.IsImaginaryNumber(TSelf)" />
        static bool INumberBase<ExInt128>.IsImaginaryNumber(ExInt128 value) => false;

        /// <inheritdoc cref="INumberBase{TSelf}.IsInfinity(TSelf)" />
        static bool INumberBase<ExInt128>.IsInfinity(ExInt128 value) => false;

        /// <inheritdoc cref="INumberBase{TSelf}.IsInteger(TSelf)" />
        static bool INumberBase<ExInt128>.IsInteger(ExInt128 value) => true;

        /// <inheritdoc cref="INumberBase{TSelf}.IsNaN(TSelf)" />
        static bool INumberBase<ExInt128>.IsNaN(ExInt128 value) => false;
#endif // GENERICS_MATH

        /// <inheritdoc cref="INumberBase{TSelf}.IsNegative(TSelf)" />
        public static bool IsNegative(ExInt128 value) => (long)value.Upper < 0;

#if GENERICS_MATH
        /// <inheritdoc cref="INumberBase{TSelf}.IsNegativeInfinity(TSelf)" />
        static bool INumberBase<ExInt128>.IsNegativeInfinity(ExInt128 value) => false;

        /// <inheritdoc cref="INumberBase{TSelf}.IsNormal(TSelf)" />
        static bool INumberBase<ExInt128>.IsNormal(ExInt128 value) => value != 0;
#endif // GENERICS_MATH

        /// <inheritdoc cref="INumberBase{TSelf}.IsOddInteger(TSelf)" />
        public static bool IsOddInteger(ExInt128 value) {
#if BCL_TYPE_INT128
            return Int128.IsOddInteger(value._data);
#else
            return (value.Lower & 1) != 0;
#endif
        }

        /// <inheritdoc cref="INumberBase{TSelf}.IsPositive(TSelf)" />
        public static bool IsPositive(ExInt128 value) {
#if BCL_TYPE_INT128
            return Int128.IsPositive(value._data);
#else
            return (long)value.Upper >= 0;
#endif
        }

#if GENERICS_MATH
        /// <inheritdoc cref="INumberBase{TSelf}.IsPositiveInfinity(TSelf)" />
        static bool INumberBase<ExInt128>.IsPositiveInfinity(ExInt128 value) => false;

        /// <inheritdoc cref="INumberBase{TSelf}.IsRealNumber(TSelf)" />
        static bool INumberBase<ExInt128>.IsRealNumber(ExInt128 value) => true;

        /// <inheritdoc cref="INumberBase{TSelf}.IsSubnormal(TSelf)" />
        static bool INumberBase<ExInt128>.IsSubnormal(ExInt128 value) => false;

        /// <inheritdoc cref="INumberBase{TSelf}.IsZero(TSelf)" />
        static bool INumberBase<ExInt128>.IsZero(ExInt128 value) => (value == 0);
#endif // GENERICS_MATH

        /// <inheritdoc cref="INumberBase{TSelf}.MaxMagnitude(TSelf, TSelf)" />
        public static ExInt128 MaxMagnitude(ExInt128 x, ExInt128 y) {
#if BCL_TYPE_INT128
            return Int128.MaxMagnitude(x._data, y._data);
#else
            ExInt128 absX = x;

            if (IsNegative(absX)) {
                absX = -absX;

                if (IsNegative(absX)) {
                    return x;
                }
            }

            ExInt128 absY = y;

            if (IsNegative(absY)) {
                absY = -absY;

                if (IsNegative(absY)) {
                    return y;
                }
            }

            if (absX > absY) {
                return x;
            }

            if (absX == absY) {
                return IsNegative(x) ? y : x;
            }

            return y;
#endif
        }

#if GENERICS_MATH
        /// <inheritdoc cref="INumberBase{TSelf}.MaxMagnitudeNumber(TSelf, TSelf)" />
        static ExInt128 INumberBase<ExInt128>.MaxMagnitudeNumber(ExInt128 x, ExInt128 y) => MaxMagnitude(x, y);
#endif // GENERICS_MATH

        /// <inheritdoc cref="INumberBase{TSelf}.MinMagnitude(TSelf, TSelf)" />
        public static ExInt128 MinMagnitude(ExInt128 x, ExInt128 y) {
#if BCL_TYPE_INT128
            return Int128.MinMagnitude(x._data, y._data);
#else
            ExInt128 absX = x;

            if (IsNegative(absX)) {
                absX = -absX;

                if (IsNegative(absX)) {
                    return y;
                }
            }

            ExInt128 absY = y;

            if (IsNegative(absY)) {
                absY = -absY;

                if (IsNegative(absY)) {
                    return x;
                }
            }

            if (absX < absY) {
                return x;
            }

            if (absX == absY) {
                return IsNegative(x) ? x : y;
            }

            return y;
#endif
        }

#if GENERICS_MATH
        /// <inheritdoc cref="INumberBase{TSelf}.MinMagnitudeNumber(TSelf, TSelf)" />
        static ExInt128 INumberBase<ExInt128>.MinMagnitudeNumber(ExInt128 x, ExInt128 y) => MinMagnitude(x, y);
#endif // GENERICS_MATH

#if NET9_0_OR_GREATER
        /// <inheritdoc cref="INumberBase{TSelf}.MultiplyAddEstimate(TSelf, TSelf, TSelf)" />
        static ExInt128 INumberBase<ExInt128>.MultiplyAddEstimate(ExInt128 left, ExInt128 right, ExInt128 addend) => CallINumberBase.MultiplyAddEstimate(left, right, addend);
#endif // NET9_0_OR_GREATER
        /// <inheritdoc cref="INumberBase{TSelf}.MultiplyAddEstimate(TSelf, TSelf, TSelf)" />
        public static ExInt128 MultiplyAddEstimate(ExInt128 left, ExInt128 right, ExInt128 addend) {
#if NET9_0_OR_GREATER
            return CallINumberBase.MultiplyAddEstimate(left, right, addend);
#else
            return (left * right) + addend;
#endif // NET9_0_OR_GREATER
        }

#if GENERICS_MATH
        /// <inheritdoc cref="INumberBase{TSelf}.TryConvertFromChecked{TOther}(TOther, out TSelf)" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static bool INumberBase<ExInt128>.TryConvertFromChecked<TOther>(TOther value, out ExInt128 result) => TryConvertFromChecked(value, out result);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool TryConvertFromChecked<TOther>(TOther value, out ExInt128 result)
            where TOther : INumberBase<TOther> {
            // In order to reduce overall code duplication and improve the inlinabilty of these
            // methods for the corelib types we have `ConvertFrom` handle the same sign and
            // `ConvertTo` handle the opposite sign. However, since there is an uneven split
            // between signed and unsigned types, the one that handles unsigned will also
            // handle `Decimal`.
            //
            // That is, `ConvertFrom` for `ExInt128` will handle the other signed types and
            // `ConvertTo` will handle the unsigned types

            if (typeof(TOther) == typeof(double)) {
                double actualValue = (double)(object)value;
                result = checked((ExInt128)actualValue);
                return true;
            } else if (typeof(TOther) == typeof(Half)) {
                Half actualValue = (Half)(object)value;
                result = checked((ExInt128)actualValue);
                return true;
            } else if (typeof(TOther) == typeof(short)) {
                short actualValue = (short)(object)value;
                result = actualValue;
                return true;
            } else if (typeof(TOther) == typeof(int)) {
                int actualValue = (int)(object)value;
                result = actualValue;
                return true;
            } else if (typeof(TOther) == typeof(long)) {
                long actualValue = (long)(object)value;
                result = actualValue;
                return true;
            } else if (typeof(TOther) == typeof(nint)) {
                nint actualValue = (nint)(object)value;
                result = actualValue;
                return true;
            } else if (typeof(TOther) == typeof(sbyte)) {
                sbyte actualValue = (sbyte)(object)value;
                result = actualValue;
                return true;
            } else if (typeof(TOther) == typeof(float)) {
                float actualValue = (float)(object)value;
                result = checked((ExInt128)actualValue);
                return true;
            } else if (typeof(TOther) == typeof(Int128)) {
                Int128 actualValue = (Int128)(object)value;
                result = checked((ExInt128)actualValue);
                return true;
            } else {
                result = default;
                return false;
            }
        }

        /// <inheritdoc cref="INumberBase{TSelf}.TryConvertFromSaturating{TOther}(TOther, out TSelf)" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static bool INumberBase<ExInt128>.TryConvertFromSaturating<TOther>(TOther value, out ExInt128 result) => TryConvertFromSaturating(value, out result);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool TryConvertFromSaturating<TOther>(TOther value, out ExInt128 result)
            where TOther : INumberBase<TOther> {
            // In order to reduce overall code duplication and improve the inlinabilty of these
            // methods for the corelib types we have `ConvertFrom` handle the same sign and
            // `ConvertTo` handle the opposite sign. However, since there is an uneven split
            // between signed and unsigned types, the one that handles unsigned will also
            // handle `Decimal`.
            //
            // That is, `ConvertFrom` for `ExInt128` will handle the other signed types and
            // `ConvertTo` will handle the unsigned types

            if (typeof(TOther) == typeof(double)) {
                double actualValue = (double)(object)value;
                result = (actualValue >= +170141183460469231731687303715884105727.0) ? MaxValue :
                         (actualValue <= -170141183460469231731687303715884105728.0) ? MinValue : (ExInt128)actualValue;
                return true;
            } else if (typeof(TOther) == typeof(Half)) {
                Half actualValue = (Half)(object)value;
                result = (actualValue == Half.PositiveInfinity) ? MaxValue :
                         (actualValue == Half.NegativeInfinity) ? MinValue : (ExInt128)actualValue;
                return true;
            } else if (typeof(TOther) == typeof(short)) {
                short actualValue = (short)(object)value;
                result = actualValue;
                return true;
            } else if (typeof(TOther) == typeof(int)) {
                int actualValue = (int)(object)value;
                result = actualValue;
                return true;
            } else if (typeof(TOther) == typeof(long)) {
                long actualValue = (long)(object)value;
                result = actualValue;
                return true;
            } else if (typeof(TOther) == typeof(nint)) {
                nint actualValue = (nint)(object)value;
                result = actualValue;
                return true;
            } else if (typeof(TOther) == typeof(sbyte)) {
                sbyte actualValue = (sbyte)(object)value;
                result = actualValue;
                return true;
            } else if (typeof(TOther) == typeof(float)) {
                float actualValue = (float)(object)value;
                result = (actualValue >= +170141183460469231731687303715884105727.0f) ? MaxValue :
                         (actualValue <= -170141183460469231731687303715884105728.0f) ? MinValue : (ExInt128)actualValue;
                return true;
            } else if (typeof(TOther) == typeof(Int128)) {
                Int128 actualValue = (Int128)(object)value;
                result = (ExInt128)actualValue;
                return true;
            } else {
                result = default;
                return false;
            }
        }

        /// <inheritdoc cref="INumberBase{TSelf}.TryConvertFromTruncating{TOther}(TOther, out TSelf)" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static bool INumberBase<ExInt128>.TryConvertFromTruncating<TOther>(TOther value, out ExInt128 result) => TryConvertFromTruncating(value, out result);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool TryConvertFromTruncating<TOther>(TOther value, out ExInt128 result)
            where TOther : INumberBase<TOther> {
            // In order to reduce overall code duplication and improve the inlinabilty of these
            // methods for the corelib types we have `ConvertFrom` handle the same sign and
            // `ConvertTo` handle the opposite sign. However, since there is an uneven split
            // between signed and unsigned types, the one that handles unsigned will also
            // handle `Decimal`.
            //
            // That is, `ConvertFrom` for `ExInt128` will handle the other signed types and
            // `ConvertTo` will handle the unsigned types

            if (typeof(TOther) == typeof(double)) {
                double actualValue = (double)(object)value;
                result = (actualValue >= +170141183460469231731687303715884105727.0) ? MaxValue :
                         (actualValue <= -170141183460469231731687303715884105728.0) ? MinValue : (ExInt128)actualValue;
                return true;
            } else if (typeof(TOther) == typeof(Half)) {
                Half actualValue = (Half)(object)value;
                result = (actualValue == Half.PositiveInfinity) ? MaxValue :
                         (actualValue == Half.NegativeInfinity) ? MinValue : (ExInt128)actualValue;
                return true;
            } else if (typeof(TOther) == typeof(short)) {
                short actualValue = (short)(object)value;
                result = actualValue;
                return true;
            } else if (typeof(TOther) == typeof(int)) {
                int actualValue = (int)(object)value;
                result = actualValue;
                return true;
            } else if (typeof(TOther) == typeof(long)) {
                long actualValue = (long)(object)value;
                result = actualValue;
                return true;
            } else if (typeof(TOther) == typeof(nint)) {
                nint actualValue = (nint)(object)value;
                result = actualValue;
                return true;
            } else if (typeof(TOther) == typeof(sbyte)) {
                sbyte actualValue = (sbyte)(object)value;
                result = actualValue;
                return true;
            } else if (typeof(TOther) == typeof(float)) {
                float actualValue = (float)(object)value;
                result = (actualValue >= +170141183460469231731687303715884105727.0f) ? MaxValue :
                         (actualValue <= -170141183460469231731687303715884105728.0f) ? MinValue : (ExInt128)actualValue;
                return true;
            } else if (typeof(TOther) == typeof(Int128)) {
                Int128 actualValue = (Int128)(object)value;
                result = (ExInt128)actualValue;
                return true;
            } else {
                result = default;
                return false;
            }
        }

        /// <inheritdoc cref="INumberBase{TSelf}.TryConvertToChecked{TOther}(TSelf, out TOther)" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static bool INumberBase<ExInt128>.TryConvertToChecked<TOther>(ExInt128 value, [MaybeNullWhen(false)] out TOther result) {
            // In order to reduce overall code duplication and improve the inlinabilty of these
            // methods for the corelib types we have `ConvertFrom` handle the same sign and
            // `ConvertTo` handle the opposite sign. However, since there is an uneven split
            // between signed and unsigned types, the one that handles unsigned will also
            // handle `Decimal`.
            //
            // That is, `ConvertFrom` for `ExInt128` will handle the other signed types and
            // `ConvertTo` will handle the unsigned types

            if (typeof(TOther) == typeof(byte)) {
                byte actualResult = checked((byte)value);
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(char)) {
                char actualResult = checked((char)value);
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(decimal)) {
                decimal actualResult = checked((decimal)value);
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(ushort)) {
                ushort actualResult = checked((ushort)value);
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(uint)) {
                uint actualResult = checked((uint)value);
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(ulong)) {
                ulong actualResult = checked((ulong)value);
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(ExUInt128)) {
                ExUInt128 actualResult = checked((ExUInt128)value);
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(UInt128)) {
                UInt128 actualResult = checked((UInt128)value);
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(nuint)) {
                nuint actualResult = checked((nuint)value);
                result = (TOther)(object)actualResult;
                return true;
            } else {
                result = default;
                return false;
            }
        }

        /// <inheritdoc cref="INumberBase{TSelf}.TryConvertToSaturating{TOther}(TSelf, out TOther)" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static bool INumberBase<ExInt128>.TryConvertToSaturating<TOther>(ExInt128 value, [MaybeNullWhen(false)] out TOther result) {
            // In order to reduce overall code duplication and improve the inlinabilty of these
            // methods for the corelib types we have `ConvertFrom` handle the same sign and
            // `ConvertTo` handle the opposite sign. However, since there is an uneven split
            // between signed and unsigned types, the one that handles unsigned will also
            // handle `Decimal`.
            //
            // That is, `ConvertFrom` for `ExInt128` will handle the other signed types and
            // `ConvertTo` will handle the unsigned types

            if (typeof(TOther) == typeof(byte)) {
                byte actualResult = (value >= byte.MaxValue) ? byte.MaxValue :
                                    (value <= byte.MinValue) ? byte.MinValue : (byte)value;
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(char)) {
                char actualResult = (value >= char.MaxValue) ? char.MaxValue :
                                    (value <= char.MinValue) ? char.MinValue : (char)value;
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(decimal)) {
                decimal actualResult = (value >= new ExInt128(0x0000_0000_FFFF_FFFF, 0xFFFF_FFFF_FFFF_FFFF)) ? decimal.MaxValue :
                                       (value <= new ExInt128(0xFFFF_FFFF_0000_0000, 0x0000_0000_0000_0001)) ? decimal.MinValue : (decimal)value;
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(ushort)) {
                ushort actualResult = (value >= ushort.MaxValue) ? ushort.MaxValue :
                                      (value <= ushort.MinValue) ? ushort.MinValue : (ushort)value;
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(uint)) {
                uint actualResult = (value >= uint.MaxValue) ? uint.MaxValue :
                                    (value <= uint.MinValue) ? uint.MinValue : (uint)value;
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(ulong)) {
                ulong actualResult = (value >= ulong.MaxValue) ? ulong.MaxValue :
                                     (value <= ulong.MinValue) ? ulong.MinValue : (ulong)value;
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(ExUInt128)) {
                ExUInt128 actualResult = (value <= 0) ? ExUInt128.MinValue : (ExUInt128)value;
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(UInt128)) {
                UInt128 actualResult = (value <= 0) ? UInt128.MinValue : (UInt128)value;
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(nuint)) {
                nuint actualResult = (value >= nuint.MaxValue) ? nuint.MaxValue :
                                     (value <= nuint.MinValue) ? nuint.MinValue : (nuint)value;
                result = (TOther)(object)actualResult;
                return true;
            } else {
                result = default;
                return false;
            }
        }

        /// <inheritdoc cref="INumberBase{TSelf}.TryConvertToTruncating{TOther}(TSelf, out TOther)" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static bool INumberBase<ExInt128>.TryConvertToTruncating<TOther>(ExInt128 value, [MaybeNullWhen(false)] out TOther result) {
            // In order to reduce overall code duplication and improve the inlinabilty of these
            // methods for the corelib types we have `ConvertFrom` handle the same sign and
            // `ConvertTo` handle the opposite sign. However, since there is an uneven split
            // between signed and unsigned types, the one that handles unsigned will also
            // handle `Decimal`.
            //
            // That is, `ConvertFrom` for `ExInt128` will handle the other signed types and
            // `ConvertTo` will handle the unsigned types

            if (typeof(TOther) == typeof(byte)) {
                byte actualResult = (byte)value;
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(char)) {
                char actualResult = (char)value;
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(decimal)) {
                decimal actualResult = (value >= new ExInt128(0x0000_0000_FFFF_FFFF, 0xFFFF_FFFF_FFFF_FFFF)) ? decimal.MaxValue :
                                       (value <= new ExInt128(0xFFFF_FFFF_0000_0000, 0x0000_0000_0000_0001)) ? decimal.MinValue : (decimal)value;
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(ushort)) {
                ushort actualResult = (ushort)value;
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(uint)) {
                uint actualResult = (uint)value;
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(ulong)) {
                ulong actualResult = (ulong)value;
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(ExUInt128)) {
                ExUInt128 actualResult = (ExUInt128)value;
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(UInt128)) {
                UInt128 actualResult = (UInt128)value;
                result = (TOther)(object)actualResult;
                return true;
            } else if (typeof(TOther) == typeof(nuint)) {
                nuint actualResult = (nuint)value;
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
            string? s, IFormatProvider? provider, out ExInt128 result) {
#if BCL_TYPE_INT128
            bool flag = Int128.TryParse(s, provider, out var rt);
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
        public static ExInt128 operator <<(ExInt128 value, int shiftAmount) {
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
                return new ExInt128(upper, 0);
            } else if (shiftAmount != 0) {
                // Otherwise we need to shift both upper and lower halves by the masked
                // amount and then or that with whatever bits were shifted "out" of lower

                ulong lower = value.Lower << shiftAmount;
                ulong upper = (value.Upper << shiftAmount) | (value.Lower >> (64 - shiftAmount));

                return new ExInt128(upper, lower);
            } else {
                return value;
            }
#endif
        }

        /// <inheritdoc cref="IShiftOperators{TSelf, TOther, TResult}.op_RightShift(TSelf, TOther)" />
        public static ExInt128 operator >>(ExInt128 value, int shiftAmount) {
#if BCL_TYPE_INT128
            return value._data >> shiftAmount;
#else
            // C# automatically masks the shift amount for UInt64 to be 0x3F. So we
            // need to specially handle things if the 7th bit is set.

            shiftAmount &= 0x7F;

            if ((shiftAmount & 0x40) != 0) {
                // In the case it is set, we know the entire upper bits must be the sign
                // and so the lower bits are just the upper shifted by the remaining
                // masked amount

                ulong lower = (ulong)((long)value.Upper >> shiftAmount);
                ulong upper = (ulong)((long)value.Upper >> 63);

                return new ExInt128(upper, lower);
            } else if (shiftAmount != 0) {
                // Otherwise we need to shift both upper and lower halves by the masked
                // amount and then or that with whatever bits were shifted "out" of upper

                ulong lower = (value.Lower >> shiftAmount) | (value.Upper << (64 - shiftAmount));
                ulong upper = (ulong)((long)value.Upper >> shiftAmount);

                return new ExInt128(upper, lower);
            } else {
                return value;
            }
#endif
        }

        /// <inheritdoc cref="IShiftOperators{TSelf, TOther, TResult}.op_UnsignedRightShift(TSelf, TOther)" />
        public static ExInt128 operator >>>(ExInt128 value, int shiftAmount) {
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
                return new ExInt128(0, lower);
            } else if (shiftAmount != 0) {
                // Otherwise we need to shift both upper and lower halves by the masked
                // amount and then or that with whatever bits were shifted "out" of upper

                ulong lower = (value.Lower >> shiftAmount) | (value.Upper << (64 - shiftAmount));
                ulong upper = value.Upper >> shiftAmount;

                return new ExInt128(upper, lower);
            } else {
                return value;
            }
#endif
        }

        //
        // ISignedNumber
        //

        /// <inheritdoc cref="ISignedNumber{TSelf}.NegativeOne" />
        public static ExInt128 NegativeOne =>
#if BCL_TYPE_INT128
            Int128.NegativeOne;
#else
            new ExInt128(0xFFFF_FFFF_FFFF_FFFF, 0xFFFF_FFFF_FFFF_FFFF);
#endif

        //
        // ISpanParsable
        //

        /// <inheritdoc cref="ISpanParsable{TSelf}.Parse(ReadOnlySpan{char}, IFormatProvider?)" />
        public static ExInt128 Parse(ReadOnlySpan<char> s, IFormatProvider? provider) {
#if BCL_TYPE_INT128
            return Int128.Parse(s, NumberStyles.Integer, provider);
#else
            return Parse(s, NumberStyles.Integer, provider);
#endif
        }

        /// <inheritdoc cref="ISpanParsable{TSelf}.TryParse(ReadOnlySpan{char}, IFormatProvider?, out TSelf)" />
        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, out ExInt128 result) {
#if BCL_TYPE_INT128
            bool flag = Int128.TryParse(s, NumberStyles.Integer, provider, out var rt);
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
        public static ExInt128 operator -(ExInt128 left, ExInt128 right) {
#if BCL_TYPE_INT128
            return left._data - right._data;
#else
            // For unsigned subtract, we can detect overflow by checking `(x - y) > x`
            // This gives us the borrow to subtract from upper to compute the correct result

            ulong lower = left.Lower - right.Lower;
            ulong borrow = (lower > left.Lower) ? 1UL : 0UL;

            ulong upper = left.Upper - right.Upper - borrow;
            return new ExInt128(upper, lower);
#endif
        }

        /// <inheritdoc cref="ISubtractionOperators{TSelf, TOther, TResult}.op_CheckedSubtraction(TSelf, TOther)" />
        public static ExInt128 operator checked -(ExInt128 left, ExInt128 right) {
#if BCL_TYPE_INT128
            return checked(left._data - right._data);
#else
            // For signed subtraction, we can detect overflow by checking if the sign of
            // both inputs are different and then if that differs from the sign of the
            // output.

            ExInt128 result = left - right;

            uint sign = (uint)(left.Upper >> 63);

            if (sign != (uint)(right.Upper >> 63)) {
                if (sign != (uint)(result.Upper >> 63)) {
                    ThrowHelper.ThrowOverflowException();
                }
            }
            return result;
#endif
        }

        //
        // IUnaryNegationOperators
        //

        /// <inheritdoc cref="IUnaryNegationOperators{TSelf, TResult}.op_UnaryNegation(TSelf)" />
        public static ExInt128 operator -(ExInt128 value) {
#if BCL_TYPE_INT128
            return -value._data;
#else
            return Zero - value;
#endif
        }

        /// <inheritdoc cref="IUnaryNegationOperators{TSelf, TResult}.op_CheckedUnaryNegation(TSelf)" />
        public static ExInt128 operator checked -(ExInt128 value) {
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
        public static ExInt128 operator +(ExInt128 value) => value;

        //
        // IUtf8SpanParsable
        //

        /// <inheritdoc cref="INumberBase{TSelf}.Parse(ReadOnlySpan{byte}, NumberStyles, IFormatProvider?)" />
        public static ExInt128 Parse(ReadOnlySpan<byte> utf8Text, NumberStyles style = NumberStyles.Integer, IFormatProvider? provider = null) {
            ExNumberFormatInfo.ValidateParseStyleInteger(style);
            return Number.ParseBinaryInteger<byte, ExInt128>(utf8Text, style, NumberFormatInfo.GetInstance(provider));
        }

        /// <inheritdoc cref="INumberBase{TSelf}.TryParse(ReadOnlySpan{byte}, NumberStyles, IFormatProvider?, out TSelf)" />
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, NumberStyles style, IFormatProvider? provider, out ExInt128 result) {
            ExNumberFormatInfo.ValidateParseStyleInteger(style);
            return Number.TryParseBinaryInteger(utf8Text, style, NumberFormatInfo.GetInstance(provider), out result) == Number.ParsingStatus.OK;
        }

        /// <inheritdoc cref="IUtf8SpanParsable{TSelf}.Parse(ReadOnlySpan{byte}, IFormatProvider?)" />
        public static ExInt128 Parse(ReadOnlySpan<byte> utf8Text, IFormatProvider? provider) => Parse(utf8Text, NumberStyles.Integer, provider);

        /// <inheritdoc cref="IUtf8SpanParsable{TSelf}.TryParse(ReadOnlySpan{byte}, IFormatProvider?, out TSelf)" />
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, IFormatProvider? provider, out ExInt128 result) => TryParse(utf8Text, NumberStyles.Integer, provider, out result);

        //
        // IBinaryIntegerParseAndFormatInfo
        //

        //static bool IBinaryIntegerParseAndFormatInfo<ExInt128>.IsSigned => true;

        //static int IBinaryIntegerParseAndFormatInfo<ExInt128>.MaxDigitCount => 39; // 170_141_183_460_469_231_731_687_303_715_884_105_727

        //static int IBinaryIntegerParseAndFormatInfo<ExInt128>.MaxHexDigitCount => 32; // 0x7FFF_FFFF_FFFF_FFFF_FFFF_FFFF_FFFF_FFFF

        //static ExInt128 IBinaryIntegerParseAndFormatInfo<ExInt128>.MaxValueDiv10 => new ExInt128(0x0CCC_CCCC_CCCC_CCCC, 0xCCCC_CCCC_CCCC_CCCC);

        //static string IBinaryIntegerParseAndFormatInfo<ExInt128>.OverflowMessage => SR.Overflow_ExInt128;

        //static bool IBinaryIntegerParseAndFormatInfo<ExInt128>.IsGreaterThanAsUnsigned(ExInt128 left, ExInt128 right) => (ExUInt128)(left) > (ExUInt128)(right);

        //static ExInt128 IBinaryIntegerParseAndFormatInfo<ExInt128>.MultiplyBy10(ExInt128 value) => value * 10;

        //static ExInt128 IBinaryIntegerParseAndFormatInfo<ExInt128>.MultiplyBy16(ExInt128 value) => value * 16;
    }

}