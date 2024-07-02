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
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Zyl.VectorTraits.Numerics;

namespace Zyl.VectorTraits.ExTypes.Impl {
    partial class Number {

        /// <inheritdoc cref="NumberStyles.BinaryNumber"/>
        public const NumberStyles BinaryNumber =
#if NET8_0_OR_GREATER
            NumberStyles.BinaryNumber;
#else
            NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | (NumberStyles)0x00000400; // AllowBinarySpecifier = 0x00000400
#endif // NET8_0_OR_GREATER

        internal static TSelf CastFrom<TSelf>(char value) where TSelf : unmanaged {
            unchecked {
                if (typeof(TSelf) == typeof(char)) {
                    return (TSelf)(object)(char)value;
                } else if (typeof(TSelf) == typeof(byte)) {
                    return (TSelf)(object)(byte)value;
                }
                throw new NotSupportedException(string.Format("Not supported type! {0}", typeof(TSelf).FullName));
            }
        }

        internal static TSelf CastFrom<TSelf>(byte value) where TSelf : unmanaged {
            unchecked {
                if (typeof(TSelf) == typeof(char)) {
                    return (TSelf)(object)(char)value;
                } else if (typeof(TSelf) == typeof(byte)) {
                    return (TSelf)(object)(byte)value;
                }
                throw new NotSupportedException(string.Format("Not supported type! {0}", typeof(TSelf).FullName));
            }
        }

        internal static TSelf CastFrom<TSelf>(int value) where TSelf : unmanaged {
            unchecked {
                if (typeof(TSelf) == typeof(char)) {
                    return (TSelf)(object)(char)value;
                } else if (typeof(TSelf) == typeof(sbyte)) {
                    return (TSelf)(object)(sbyte)value;
                } else if (typeof(TSelf) == typeof(byte)) {
                    return (TSelf)(object)(byte)value;
                } else if (typeof(TSelf) == typeof(short)) {
                    return (TSelf)(object)(short)value;
                } else if (typeof(TSelf) == typeof(ushort)) {
                    return (TSelf)(object)(ushort)value;
                } else if (typeof(TSelf) == typeof(int)) {
                    return (TSelf)(object)(int)value;
                } else if (typeof(TSelf) == typeof(uint)) {
                    return (TSelf)(object)(uint)value;
                } else if (typeof(TSelf) == typeof(long)) {
                    return (TSelf)(object)(long)value;
                } else if (typeof(TSelf) == typeof(ulong)) {
                    return (TSelf)(object)(ulong)value;
                } else if (typeof(TSelf) == typeof(nint)) {
                    return (TSelf)(object)(nint)value;
                } else if (typeof(TSelf) == typeof(nuint)) {
                    return (TSelf)(object)(nuint)value;
                } else if (typeof(TSelf) == typeof(ExInt128)) {
                    return (TSelf)(object)(ExInt128)value;
                } else if (typeof(TSelf) == typeof(ExUInt128)) {
                    return (TSelf)(object)(ExUInt128)value;
#if BCL_TYPE_INT128
                } else if (typeof(TSelf) == typeof(Int128)) {
                    return (TSelf)(object)(Int128)value;
                } else if (typeof(TSelf) == typeof(UInt128)) {
                    return (TSelf)(object)(UInt128)value;
#endif // BCL_TYPE_INT128
                }
                throw new NotSupportedException(string.Format("Not supported type! {0}", typeof(TSelf).FullName));
            }
        }

        internal static TSelf CastFrom<TSelf>(ushort value) where TSelf : unmanaged {
            unchecked {
                if (typeof(TSelf) == typeof(char)) {
                    return (TSelf)(object)(char)value;
                } else if (typeof(TSelf) == typeof(byte)) {
                    return (TSelf)(object)(byte)value;
                }
                throw new NotSupportedException(string.Format("Not supported type! {0}", typeof(TSelf).FullName));
            }
        }

        internal static TSelf CastFrom<TSelf>(uint value) where TSelf:unmanaged {
            unchecked {
                if (typeof(TSelf) == typeof(char)) {
                    return (TSelf)(object)(char)value;
                } else if (typeof(TSelf) == typeof(byte)) {
                    return (TSelf)(object)(byte)value;
                }
                throw new NotSupportedException(string.Format("Not supported type! {0}", typeof(TSelf).FullName));
            }
        }

        internal static TSelf CastFrom<TSelf>(ulong value) where TSelf : unmanaged {
            unchecked {
                if (typeof(TSelf) == typeof(char)) {
                    return (TSelf)(object)(char)value;
                } else if (typeof(TSelf) == typeof(byte)) {
                    return (TSelf)(object)(byte)value;
                }
                throw new NotSupportedException(string.Format("Not supported type! {0}", typeof(TSelf).FullName));
            }
        }

        /// <summary>Casts a value of this type to an UInt32.</summary>
        public static uint CastToUInt32<TSelf>(TSelf value) where TSelf : unmanaged {
            unchecked {
                if (typeof(TSelf) == typeof(char)) {
                    return (uint)(char)(object)value;
                } else if (typeof(TSelf) == typeof(byte)) {
                    return (uint)(byte)(object)value;
                }
                throw new NotSupportedException(string.Format("Not supported type! {0}", typeof(TSelf).FullName));
            }
        }

        internal static bool IsFinite<TSelf>(TSelf value) where TSelf : unmanaged {
            if (typeof(TSelf) == typeof(float)) {
                return MathINumberBase.IsFinite((float)(object)value);
            } else if (typeof(TSelf) == typeof(double)) {
                return MathINumberBase.IsFinite((double)(object)value);
#if BCL_TYPE_HALF
            } else if (typeof(TSelf) == typeof(Half)) {
                return MathINumberBase.IsFinite((Half)(object)value);
#endif // BCL_TYPE_HALF
            }
            throw new NotSupportedException(string.Format("Not supported type! {0}", typeof(TSelf).FullName));
        }

        internal static bool IsNaN<TSelf>(TSelf value) where TSelf : unmanaged {
            if (typeof(TSelf) == typeof(float)) {
                return MathINumberBase.IsNaN((float)(object)value);
            } else if (typeof(TSelf) == typeof(double)) {
                return MathINumberBase.IsNaN((double)(object)value);
#if BCL_TYPE_HALF
            } else if (typeof(TSelf) == typeof(Half)) {
                return MathINumberBase.IsNaN((Half)(object)value);
#endif // BCL_TYPE_HALF
            }
            throw new NotSupportedException(string.Format("Not supported type! {0}", typeof(TSelf).FullName));
        }

        internal static bool IsNegative<TSelf>(TSelf value) where TSelf : unmanaged {
            if (typeof(TSelf) == typeof(float)) {
                return MathINumberBase.IsNegative((float)(object)value);
            } else if (typeof(TSelf) == typeof(double)) {
                return MathINumberBase.IsNegative((double)(object)value);
#if BCL_TYPE_HALF
            } else if (typeof(TSelf) == typeof(Half)) {
                return MathINumberBase.IsNegative((Half)(object)value);
#endif // BCL_TYPE_HALF
            }
            throw new NotSupportedException(string.Format("Not supported type! {0}", typeof(TSelf).FullName));
        }


        /// <summary>
        /// Get <c>mid | high</c> from <see cref="decimal"/>.
        /// </summary>
        /// <param name="src">Source value (源值).</param>
        /// <returns>The <c>mid | high</c> value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint DecimalGetMidOrHigh(decimal src) {
            _ = ExBitUtil.DecodeDecimalOn32(src, out uint high, out uint mid);
            return mid | high;
        }

        /// <summary>
        /// Get low 32 bit from <see cref="decimal"/>.
        /// </summary>
        /// <param name="src">Source value (源值).</param>
        /// <returns>The low 32 bit value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint DecimalGetLow(decimal src) {
            return ExBitUtil.DecodeDecimalOn32(src, out _, out _);
        }

        /// <summary>
        /// Get scale from <see cref="decimal"/>.
        /// </summary>
        /// <param name="src">Source value (源值).</param>
        /// <returns>The scale value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte DecimalGetScale(decimal src) {
#if NET7_0_OR_GREATER
            return src.Scale;
#else
            ref uint p = ref Unsafe.As<decimal, uint>(ref src);
            uint flag = p;
            byte scale = (byte)(flag >> 16);
            return scale;
#endif // NET7_0_OR_GREATER
        }

        internal static uint DecDivMod1E9(ref decimal value) {
            const uint TenToPowerNine = 1000000000;
            uint low = ExBitUtil.DecodeDecimalOn32(value, out uint high, out uint mid);
            ulong high64 = ((ulong)high << 32) + mid;
            ulong div64 = high64 / TenToPowerNine;
            //value.uhi = (uint)(div64 >> 32);
            //value.umid = (uint)div64;

            ulong num = ((high64 - (uint)div64 * TenToPowerNine) << 32) + low;
            uint div = (uint)(num / TenToPowerNine);
            //value.ulo = div;
            // Save decimal.
            ref uint pHigh = ref Unsafe.As<decimal, uint>(ref Unsafe.AddByteOffset(ref value, (nint)4));
            ref ulong pLow64 = ref Unsafe.As<decimal, ulong>(ref Unsafe.AddByteOffset(ref value, (nint)8));
            pHigh = (uint)(div64 >> 32);
            uint umid = (uint)div64;
            uint ulo = div;
            pLow64 = ((ulong)umid << 32) + ulo;
            // done.
            return (uint)num - div * TenToPowerNine;
        }

        // Contains information about the C0, Basic Latin, C1, and Latin-1 Supplement ranges [ U+0000..U+00FF ], with:
        // - 0x80 bit if set means 'is whitespace'
        // - 0x40 bit if set means 'is uppercase letter'
        // - 0x20 bit if set means 'is lowercase letter'
        // - bottom 5 bits are the UnicodeCategory of the character
        private static ReadOnlySpan<byte> Latin1CharInfo =>
        [
        //  0     1     2     3     4     5     6     7     8     9     A     B     C     D     E     F
            0x0E, 0x0E, 0x0E, 0x0E, 0x0E, 0x0E, 0x0E, 0x0E, 0x0E, 0x8E, 0x8E, 0x8E, 0x8E, 0x8E, 0x0E, 0x0E, // U+0000..U+000F
            0x0E, 0x0E, 0x0E, 0x0E, 0x0E, 0x0E, 0x0E, 0x0E, 0x0E, 0x0E, 0x0E, 0x0E, 0x0E, 0x0E, 0x0E, 0x0E, // U+0001..U+001F
            0x8B, 0x18, 0x18, 0x18, 0x1A, 0x18, 0x18, 0x18, 0x14, 0x15, 0x18, 0x19, 0x18, 0x13, 0x18, 0x18, // U+0002..U+002F
            0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x18, 0x18, 0x19, 0x19, 0x19, 0x18, // U+0003..U+003F
            0x18, 0x40, 0x40, 0x40, 0x40, 0x40, 0x40, 0x40, 0x40, 0x40, 0x40, 0x40, 0x40, 0x40, 0x40, 0x40, // U+0004..U+004F
            0x40, 0x40, 0x40, 0x40, 0x40, 0x40, 0x40, 0x40, 0x40, 0x40, 0x40, 0x14, 0x18, 0x15, 0x1B, 0x12, // U+0005..U+005F
            0x1B, 0x21, 0x21, 0x21, 0x21, 0x21, 0x21, 0x21, 0x21, 0x21, 0x21, 0x21, 0x21, 0x21, 0x21, 0x21, // U+0006..U+006F
            0x21, 0x21, 0x21, 0x21, 0x21, 0x21, 0x21, 0x21, 0x21, 0x21, 0x21, 0x14, 0x19, 0x15, 0x19, 0x0E, // U+0007..U+007F
            0x0E, 0x0E, 0x0E, 0x0E, 0x0E, 0x8E, 0x0E, 0x0E, 0x0E, 0x0E, 0x0E, 0x0E, 0x0E, 0x0E, 0x0E, 0x0E, // U+0008..U+008F
            0x0E, 0x0E, 0x0E, 0x0E, 0x0E, 0x0E, 0x0E, 0x0E, 0x0E, 0x0E, 0x0E, 0x0E, 0x0E, 0x0E, 0x0E, 0x0E, // U+0009..U+009F
            0x8B, 0x18, 0x1A, 0x1A, 0x1A, 0x1A, 0x1C, 0x18, 0x1B, 0x1C, 0x04, 0x16, 0x19, 0x0F, 0x1C, 0x1B, // U+000A..U+00AF
            0x1C, 0x19, 0x0A, 0x0A, 0x1B, 0x21, 0x18, 0x18, 0x1B, 0x0A, 0x04, 0x17, 0x0A, 0x0A, 0x0A, 0x18, // U+000B..U+00BF
            0x40, 0x40, 0x40, 0x40, 0x40, 0x40, 0x40, 0x40, 0x40, 0x40, 0x40, 0x40, 0x40, 0x40, 0x40, 0x40, // U+000C..U+00CF
            0x40, 0x40, 0x40, 0x40, 0x40, 0x40, 0x40, 0x19, 0x40, 0x40, 0x40, 0x40, 0x40, 0x40, 0x40, 0x21, // U+000D..U+00DF
            0x21, 0x21, 0x21, 0x21, 0x21, 0x21, 0x21, 0x21, 0x21, 0x21, 0x21, 0x21, 0x21, 0x21, 0x21, 0x21, // U+000E..U+00EF
            0x21, 0x21, 0x21, 0x21, 0x21, 0x21, 0x21, 0x19, 0x21, 0x21, 0x21, 0x21, 0x21, 0x21, 0x21, 0x21, // U+000F..U+00FF
        ];

        // Return true for all characters below or equal U+00ff, which is ASCII + Latin-1 Supplement.
        private static bool IsLatin1(char c) => (uint)c < (uint)Latin1CharInfo.Length;

        /// <summary>
        /// Returns <see langword="true"/> if <paramref name="c"/> is an ASCII
        /// character ([ U+0000..U+007F ]).
        /// </summary>
        /// <remarks>
        /// Per http://www.unicode.org/glossary/#ASCII, ASCII is only U+0000..U+007F.
        /// </remarks>
        public static bool IsAscii(char c) => (uint)c <= '\x007f';

        /// <summary>Indicates whether a character is categorized as an ASCII letter.</summary>
        /// <param name="c">The character to evaluate.</param>
        /// <returns>true if <paramref name="c"/> is an ASCII letter; otherwise, false.</returns>
        /// <remarks>
        /// This determines whether the character is in the range 'A' through 'Z', inclusive,
        /// or 'a' through 'z', inclusive.
        /// </remarks>
        public static bool IsAsciiLetter(char c) => (uint)((c | 0x20) - 'a') <= 'z' - 'a';

        /// <summary>Indicates whether a character is categorized as a lowercase ASCII letter.</summary>
        /// <param name="c">The character to evaluate.</param>
        /// <returns>true if <paramref name="c"/> is a lowercase ASCII letter; otherwise, false.</returns>
        /// <remarks>
        /// This determines whether the character is in the range 'a' through 'z', inclusive.
        /// </remarks>
        public static bool IsAsciiLetterLower(char c) => IsBetween(c, 'a', 'z');

        /// <summary>Indicates whether a character is categorized as an uppercase ASCII letter.</summary>
        /// <param name="c">The character to evaluate.</param>
        /// <returns>true if <paramref name="c"/> is an uppercase ASCII letter; otherwise, false.</returns>
        /// <remarks>
        /// This determines whether the character is in the range 'A' through 'Z', inclusive.
        /// </remarks>
        public static bool IsAsciiLetterUpper(char c) => IsBetween(c, 'A', 'Z');

        /// <summary>Indicates whether a character is categorized as an ASCII digit.</summary>
        /// <param name="c">The character to evaluate.</param>
        /// <returns>true if <paramref name="c"/> is an ASCII digit; otherwise, false.</returns>
        /// <remarks>
        /// This determines whether the character is in the range '0' through '9', inclusive.
        /// </remarks>
        public static bool IsAsciiDigit(char c) => IsBetween(c, '0', '9');

        /// <summary>Indicates whether a character is categorized as an ASCII letter or digit.</summary>
        /// <param name="c">The character to evaluate.</param>
        /// <returns>true if <paramref name="c"/> is an ASCII letter or digit; otherwise, false.</returns>
        /// <remarks>
        /// This determines whether the character is in the range 'A' through 'Z', inclusive,
        /// 'a' through 'z', inclusive, or '0' through '9', inclusive.
        /// </remarks>
        public static bool IsAsciiLetterOrDigit(char c) => IsAsciiLetter(c) | IsBetween(c, '0', '9');

        /*=================================IsDigit======================================
        **A wrapper for char.  Returns a boolean indicating whether    **
        **character c is considered to be a digit.                                    **
        ==============================================================================*/
        // Determines whether a character is a digit.
        public static bool IsDigit(char c) {
            if (IsLatin1(c)) {
                return IsBetween(c, '0', '9');
            }
            return CharUnicodeInfo.GetUnicodeCategory(c) == UnicodeCategory.DecimalDigitNumber;
        }

        /// <summary>Indicates whether a character is within the specified inclusive range.</summary>
        /// <param name="c">The character to evaluate.</param>
        /// <param name="minInclusive">The lower bound, inclusive.</param>
        /// <param name="maxInclusive">The upper bound, inclusive.</param>
        /// <returns>true if <paramref name="c"/> is within the specified range; otherwise, false.</returns>
        /// <remarks>
        /// The method does not validate that <paramref name="maxInclusive"/> is greater than or equal
        /// to <paramref name="minInclusive"/>.  If <paramref name="maxInclusive"/> is less than
        /// <paramref name="minInclusive"/>, the behavior is undefined.
        /// </remarks>
        public static bool IsBetween(char c, char minInclusive, char maxInclusive) =>
            (uint)(c - minInclusive) <= (uint)(maxInclusive - minInclusive);

        private static bool IsBetween(UnicodeCategory c, UnicodeCategory min, UnicodeCategory max) =>
            (uint)(c - min) <= (uint)(max - min);

    }
}
