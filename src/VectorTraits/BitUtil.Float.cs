using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zyl.VectorTraits {
    partial class BitUtil {

        // == BitConverter ==
        /// <summary>
        /// Converts a single-precision floating-point value into a 32-bit integer (将单精度浮点值转换为 32 位整数).
        /// </summary>
        /// <param name="value">The number to convert (欲转换的值).</param>
        /// <returns>A 32-bit integer whose bits are identical to value (一个32位整数，表示转换的单精度浮点值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SingleToInt32Bits(float value) {
#if (NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER)
            return BitConverter.SingleToInt32Bits(value);
#else
            return Unsafe.As<float, int>(ref value);
#endif // NET6_0_OR_GREATER
        }

        /// <summary>
        /// Converts a single-precision floating-point value into a 32-bit unsigned integer (将指定的单精度浮点数转换为 32 位无符号整数).
        /// </summary>
        /// <param name="value">The number to convert (欲转换的值).</param>
        /// <returns>A 32-bit integer whose bits are identical to value (一个32位无符号整数，表示转换的单精度浮点值).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint SingleToUInt32Bits(float value) {
#if NET6_0_OR_GREATER
            return BitConverter.SingleToUInt32Bits(value);
#else
            return Unsafe.As<float, uint>(ref value);
#endif // NET6_0_OR_GREATER
        }

        /// <summary>
        /// Reinterprets the specified 32-bit signed integer value as a single-precision floating-point value (将指定的 32 位有符号整数值重新解释为单精度浮点值).
        /// </summary>
        /// <param name="value">The 32-bit signed integer value to convert (欲转换的32位有符号整数值).</param>
        /// <returns>A single-precision floating-point value that represents the converted integer (表示根据整数转换后的单精度浮点值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Int32BitsToSingle(int value) {
#if (NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER)
            return BitConverter.Int32BitsToSingle(value);
#else
            return Unsafe.As<int, float>(ref value);
#endif // NET6_0_OR_GREATER
        }

        /// <summary>
        /// Reinterprets the specified 32-bit unsigned integer value as a single-precision floating-point value (将指定的 32 位无符号整数转换为单精度浮点数).
        /// </summary>
        /// <param name="value">The 32-bit unsigned integer value to convert (欲转换的32位无符号整数值).</param>
        /// <returns>A single-precision floating-point value that represents the converted integer (表示根据整数转换后的单精度浮点值).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float UInt32BitsToSingle(uint value) {
#if NET6_0_OR_GREATER
            return BitConverter.UInt32BitsToSingle(value);
#else
            return Unsafe.As<uint, float>(ref value);
#endif // NET6_0_OR_GREATER
        }
        /// <summary>
        /// Converts a double-precision floating-point value into a 64-bit integer (将单精度浮点值转换为 64 位整数).
        /// </summary>
        /// <param name="value">The number to convert (欲转换的值).</param>
        /// <returns>A 64-bit integer whose bits are identical to value (一个64位整数，表示转换的单精度浮点值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long DoubleToInt64Bits(double value) {
            return BitConverter.DoubleToInt64Bits(value);
        }

        /// <summary>
        /// Converts a double-precision floating-point value into a 64-bit unsigned integer (将指定的单精度浮点数转换为 64 位无符号整数).
        /// </summary>
        /// <param name="value">The number to convert (欲转换的值).</param>
        /// <returns>A 64-bit integer whose bits are identical to value (一个64位无符号整数，表示转换的单精度浮点值).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong DoubleToUInt64Bits(double value) {
#if NET6_0_OR_GREATER
            return BitConverter.DoubleToUInt64Bits(value);
#else
            return Unsafe.As<double, ulong>(ref value);
#endif // NET6_0_OR_GREATER
        }

        /// <summary>
        /// Reinterprets the specified 64-bit signed integer value as a double-precision floating-point value (将指定的 64 位有符号整数值重新解释为单精度浮点值).
        /// </summary>
        /// <param name="value">The 64-bit signed integer value to convert (欲转换的64位有符号整数值).</param>
        /// <returns>A double-precision floating-point value that represents the converted integer (表示根据整数转换后的单精度浮点值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Int64BitsToDouble(long value) {
            return BitConverter.Int64BitsToDouble(value);
        }

        /// <summary>
        /// Reinterprets the specified 64-bit unsigned integer value as a double-precision floating-point value (将指定的 64 位无符号整数转换为单精度浮点数).
        /// </summary>
        /// <param name="value">The 64-bit unsigned integer value to convert (欲转换的64位无符号整数值).</param>
        /// <returns>A double-precision floating-point value that represents the converted integer (表示根据整数转换后的单精度浮点值).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double UInt64BitsToDouble(ulong value) {
#if NET6_0_OR_GREATER
            return BitConverter.UInt64BitsToDouble(value);
#else
            return Unsafe.As<ulong, double>(ref value);
#endif // NET6_0_OR_GREATER
        }

#if NET5_0_OR_GREATER
        /// <summary>
        /// Converts a half-precision floating-point value into a 16-bit integer (将半精度浮点值转换为 16 位整数).
        /// </summary>
        /// <param name="value">The number to convert (欲转换的值).</param>
        /// <returns>A 16-bit integer whose bits are identical to value (一个16位整数，表示转换的半精度浮点值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short HalfToInt16Bits(Half value) {
#if NET6_0_OR_GREATER
            return BitConverter.HalfToInt16Bits(value);
#else
            return Unsafe.As<Half, short>(ref value);
#endif // NET6_0_OR_GREATER
        }

        /// <summary>
        /// Converts a half-precision floating-point value into a 16-bit unsigned integer (将指定的半精度浮点数转换为 16 位无符号整数).
        /// </summary>
        /// <param name="value">The number to convert (欲转换的值).</param>
        /// <returns>A 16-bit integer whose bits are identical to value (一个16位无符号整数，表示转换的半精度浮点值).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort HalfToUInt16Bits(Half value) {
#if NET6_0_OR_GREATER
            return BitConverter.HalfToUInt16Bits(value);
#else
            return Unsafe.As<Half, ushort>(ref value);
#endif // NET6_0_OR_GREATER
        }

        /// <summary>
        /// Reinterprets the specified 16-bit signed integer value as a half-precision floating-point value (将指定的 16 位有符号整数值重新解释为半精度浮点值).
        /// </summary>
        /// <param name="value">The 16-bit signed integer value to convert (欲转换的16位有符号整数值).</param>
        /// <returns>A half-precision floating-point value that represents the converted integer (表示根据整数转换后的半精度浮点值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half Int16BitsToHalf(short value) {
#if NET6_0_OR_GREATER
            return BitConverter.Int16BitsToHalf(value);
#else
            return Unsafe.As<short, Half>(ref value);
#endif // NET6_0_OR_GREATER
        }

        /// <summary>
        /// Reinterprets the specified 16-bit unsigned integer value as a half-precision floating-point value (将指定的 16 位无符号整数转换为半精度浮点数).
        /// </summary>
        /// <param name="value">The 16-bit unsigned integer value to convert (欲转换的16位无符号整数值).</param>
        /// <returns>A half-precision floating-point value that represents the converted integer (表示根据整数转换后的半精度浮点值).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half UInt16BitsToHalf(ushort value) {
#if NET6_0_OR_GREATER
            return BitConverter.UInt16BitsToHalf(value);
#else
            return Unsafe.As<ushort, Half>(ref value);
#endif // NET6_0_OR_GREATER
        }

#endif // NET5_0_OR_GREATER

    }
}
