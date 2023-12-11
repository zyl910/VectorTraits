using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Zyl.VectorTraits.Numerics;

namespace Zyl.VectorTraits {
    partial class BitMath {

        // == BitConverter ==
        // From MathBitConverter

        /// <inheritdoc cref="MathBitConverter.SingleToInt32Bits"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SingleToInt32Bits(float value) {
            return MathBitConverter.SingleToInt32Bits(value);
        }

        /// <inheritdoc cref="MathBitConverter.SingleToUInt32Bits"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint SingleToUInt32Bits(float value) {
            return MathBitConverter.SingleToUInt32Bits(value);
        }

        /// <inheritdoc cref="MathBitConverter.Int32BitsToSingle"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Int32BitsToSingle(int value) {
            return MathBitConverter.Int32BitsToSingle(value);
        }

        /// <inheritdoc cref="MathBitConverter.UInt32BitsToSingle"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float UInt32BitsToSingle(uint value) {
            return MathBitConverter.UInt32BitsToSingle(value);
        }

        /// <inheritdoc cref="MathBitConverter.DoubleToInt64Bits"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long DoubleToInt64Bits(double value) {
            return BitConverter.DoubleToInt64Bits(value);
        }

        /// <inheritdoc cref="MathBitConverter.DoubleToUInt64Bits"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong DoubleToUInt64Bits(double value) {
            return MathBitConverter.DoubleToUInt64Bits(value);
        }

        /// <inheritdoc cref="MathBitConverter.Int64BitsToDouble"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Int64BitsToDouble(long value) {
            return BitConverter.Int64BitsToDouble(value);
        }

        /// <inheritdoc cref="MathBitConverter.UInt64BitsToDouble"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double UInt64BitsToDouble(ulong value) {
            return MathBitConverter.UInt64BitsToDouble(value);
        }

#if NET5_0_OR_GREATER
        /// <inheritdoc cref="MathBitConverter.HalfToInt16Bits"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short HalfToInt16Bits(Half value) {
            return MathBitConverter.HalfToInt16Bits(value);
        }

        /// <inheritdoc cref="MathBitConverter.HalfToUInt16Bits"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort HalfToUInt16Bits(Half value) {
            return MathBitConverter.HalfToUInt16Bits(value);
        }

        /// <inheritdoc cref="MathBitConverter.Int16BitsToHalf"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half Int16BitsToHalf(short value) {
            return MathBitConverter.Int16BitsToHalf(value);
        }

        /// <inheritdoc cref="MathBitConverter.UInt16BitsToHalf"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half UInt16BitsToHalf(ushort value) {
            return MathBitConverter.UInt16BitsToHalf(value);
        }

#endif // NET5_0_OR_GREATER

    }
}
