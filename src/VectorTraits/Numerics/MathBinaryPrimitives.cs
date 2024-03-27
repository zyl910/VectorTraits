using System;
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
using System.Buffers.Binary;
#endif
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zyl.VectorTraits.Numerics {
    /// <summary>
    /// Math functions of <see cref="BinaryPrimitives"/> (BinaryPrimitives 的数学函数).
    /// </summary>
    /// <seealso cref="BinaryPrimitives"/>
    public static class MathBinaryPrimitives {

        /// <summary>
        /// Reverses a primitive value by performing an endianness swap of the specified <see cref="sbyte" /> value, which effectively does nothing for an <see cref="sbyte" />.
        /// </summary>
        /// <param name="value">The value to reverse.</param>
        /// <returns>The passed-in value, unmodified.</returns>
        /// <remarks>This method effectively does nothing and was added only for consistency.</remarks>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte ReverseEndianness(sbyte value) => value;

        /// <summary>
        /// Reverses a primitive value by performing an endianness swap of the specified <see cref="short" /> value.
        /// </summary>
        /// <param name="value">The value to reverse.</param>
        /// <returns>The reversed value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short ReverseEndianness(short value) => (short)ReverseEndianness((ushort)value);

        /// <summary>
        /// Reverses a primitive value by performing an endianness swap of the specified <see cref="int" /> value.
        /// </summary>
        /// <param name="value">The value to reverse.</param>
        /// <returns>The reversed value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ReverseEndianness(int value) => (int)ReverseEndianness((uint)value);

        /// <summary>
        /// Reverses a primitive value by performing an endianness swap of the specified <see cref="long" /> value.
        /// </summary>
        /// <param name="value">The value to reverse.</param>
        /// <returns>The reversed value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ReverseEndianness(long value) => (long)ReverseEndianness((ulong)value);

        /// <summary>
        /// Reverses a primitive value by performing an endianness swap of the specified <see cref="nint" /> value.
        /// </summary>
        /// <param name="value">The value to reverse.</param>
        /// <returns>The reversed value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nint ReverseEndianness(nint value) => (nint)ReverseEndianness((nuint)value);

#if NET7_0_OR_GREATER
        /// <summary>
        /// Reverses a primitive value by performing an endianness swap of the specified <see cref="Int128" /> value.
        /// </summary>
        /// <param name="value">The value to reverse.</param>
        /// <returns>The reversed value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 ReverseEndianness(Int128 value) {
#if NET8_0_OR_GREATER
            return BinaryPrimitives.ReverseEndianness(value);
#else
            ulong lower = (ulong)value; // value.Lower
            ulong upper; // value.Upper
            if (BitConverter.IsLittleEndian) {
                upper = Unsafe.Add(ref Unsafe.As<Int128, ulong>(ref value), 1);
            } else {
                upper = Unsafe.As<Int128, ulong>(ref value);
            }
            return new Int128(
                ReverseEndianness(lower),
                ReverseEndianness(upper)
            );
#endif
        }
#endif // NET7_0_OR_GREATER

        /// <summary>
        /// Reverses a primitive value by performing an endianness swap of the specified <see cref="byte" /> value, which effectively does nothing for an <see cref="byte" />.
        /// </summary>
        /// <param name="value">The value to reverse.</param>
        /// <returns>The passed-in value, unmodified.</returns>
        /// <remarks>This method effectively does nothing and was added only for consistency.</remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte ReverseEndianness(byte value) => value;

        /// <summary>
        /// Reverses a primitive value by performing an endianness swap of the specified <see cref="ushort" /> value.
        /// </summary>
        /// <param name="value">The value to reverse.</param>
        /// <returns>The reversed value.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort ReverseEndianness(ushort value) {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
            return BinaryPrimitives.ReverseEndianness(value);
#else
            // Don't need to AND with 0xFF00 or 0x00FF since the final
            // cast back to ushort will clear out all bits above [ 15 .. 00 ].
            // This is normally implemented via "movzx eax, ax" on the return.
            // Alternatively, the compiler could elide the movzx instruction
            // entirely if it knows the caller is only going to access "ax"
            // instead of "eax" / "rax" when the function returns.

            return (ushort)((value >> 8) + (value << 8));
#endif
        }

        /// <summary>
        /// Reverses a primitive value by performing an endianness swap of the specified <see cref="char" /> value.
        /// </summary>
        /// <param name="value">The value to reverse.</param>
        /// <returns>The reversed value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static char ReverseEndianness(char value) => (char)ReverseEndianness((ushort)value);

        /// <summary>
        /// Reverses a primitive value by performing an endianness swap of the specified <see cref="uint" /> value.
        /// </summary>
        /// <param name="value">The value to reverse.</param>
        /// <returns>The reversed value.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ReverseEndianness(uint value) {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
            return BinaryPrimitives.ReverseEndianness(value);
#else
            // This takes advantage of the fact that the JIT can detect
            // ROL32 / ROR32 patterns and output the correct intrinsic.
            //
            // Input: value = [ ww xx yy zz ]
            //
            // First line generates : [ ww xx yy zz ]
            //                      & [ 00 FF 00 FF ]
            //                      = [ 00 xx 00 zz ]
            //             ROR32(8) = [ zz 00 xx 00 ]
            //
            // Second line generates: [ ww xx yy zz ]
            //                      & [ FF 00 FF 00 ]
            //                      = [ ww 00 yy 00 ]
            //             ROL32(8) = [ 00 yy 00 ww ]
            //
            //                (sum) = [ zz yy xx ww ]
            // Testing shows that throughput increases if the AND
            // is performed before the ROL / ROR.
            //return BitOperations.RotateRight(value & 0x00FF00FFu, 8) // xx zz
            //    + BitOperations.RotateLeft(value & 0xFF00FF00u, 8); // ww yy
            // https://www.csharp-examples.net/reverse-bytes/
            return (value & 0x000000FFU) << 24 | (value & 0x0000FF00U) << 8 |
                   (value & 0x00FF0000U) >> 8 | (value & 0xFF000000U) >> 24;
#endif
        }

        /// <summary>
        /// Reverses a primitive value by performing an endianness swap of the specified <see cref="ulong" /> value.
        /// </summary>
        /// <param name="value">The value to reverse.</param>
        /// <returns>The reversed value.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ReverseEndianness(ulong value) {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
            return BinaryPrimitives.ReverseEndianness(value);
#else
            // Operations on 32-bit values have higher throughput than
            // operations on 64-bit values, so decompose.
            //return ((ulong)ReverseEndianness((uint)value) << 32)
            //    + ReverseEndianness((uint)(value >> 32));
            // https://www.csharp-examples.net/reverse-bytes/
            return (value & 0x00000000000000FFUL) << 56 | (value & 0x000000000000FF00UL) << 40 |
                (value & 0x0000000000FF0000UL) << 24 | (value & 0x00000000FF000000UL) << 8 |
                (value & 0x000000FF00000000UL) >> 8 | (value & 0x0000FF0000000000UL) >> 24 |
                (value & 0x00FF000000000000UL) >> 40 | (value & 0xFF00000000000000UL) >> 56;
#endif
        }

        /// <summary>
        /// Reverses a primitive value by performing an endianness swap of the specified <see cref="nuint" /> value.
        /// </summary>
        /// <param name="value">The value to reverse.</param>
        /// <returns>The reversed value.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nuint ReverseEndianness(nuint value) {
            if (UIntPtr.Size == sizeof(ulong)) {
                return (nuint)ReverseEndianness((ulong)value);
            } else {
                return (nuint)ReverseEndianness((uint)value);
            }
        }

#if NET7_0_OR_GREATER
        /// <summary>
        /// Reverses a primitive value by performing an endianness swap of the specified <see cref="UInt128" /> value.
        /// </summary>
        /// <param name="value">The value to reverse.</param>
        /// <returns>The reversed value.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 ReverseEndianness(UInt128 value) {
#if NET8_0_OR_GREATER
            return BinaryPrimitives.ReverseEndianness(value);
#else
            ulong lower = (ulong)value; // value.Lower
            ulong upper; // value.Upper
            if (BitConverter.IsLittleEndian) {
                upper = Unsafe.Add(ref Unsafe.As<UInt128, ulong>(ref value), 1);
            } else {
                upper = Unsafe.As<UInt128, ulong>(ref value);
            }
            return new UInt128(
                ReverseEndianness(lower),
                ReverseEndianness(upper)
            );
#endif
        }
#endif // NET7_0_OR_GREATER

    }
}
