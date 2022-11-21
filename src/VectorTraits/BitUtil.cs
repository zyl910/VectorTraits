using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Zyl.VectorTraits {
    /// <summary>
    /// Bit manipulation util (位操控工具).
    /// </summary>
    /// <seealso cref="BitConverter"/>
    public static class BitUtil {

        // == MemoryMarshal ==

        /// <summary>
        /// Returns a reference to the element of the read-only span at index 0 (返回只读跨度在索引0处的引用).
        /// </summary>
        /// <typeparam name="T">The type of items in the span (跨度中的元素的类型).</typeparam>
        /// <param name="span">The read-only span from which the reference is retrieved (用于检索引用的只读跨度).</param>
        /// <returns>A reference to the element at index 0 (对索引为 0 处元素的引用).</returns>
        /// <seealso cref="MemoryMarshal.GetReference{T}(ReadOnlySpan{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref T GetReference<T>(ReadOnlySpan<T> span) {
#if (NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER)
            return ref MemoryMarshal.GetReference<T>(span);
#else
            return ref Unsafe.AsRef(span.GetPinnableReference());
#endif // NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        }

        /// <summary>
        /// Returns a reference to the element of the span at index 0 (返回跨度在索引0处的引用).
        /// </summary>
        /// <typeparam name="T">The type of items in the span (跨度中的元素的类型).</typeparam>
        /// <param name="span">The span from which the reference is retrieved(用于检索引用的跨度).</param>
        /// <returns>A reference to the element at index 0 (对索引为 0 处元素的引用).</returns>
        /// <seealso cref="MemoryMarshal.GetReference{T}(Span{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref T GetReference<T>(Span<T> span) {
#if (NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER)
            return ref MemoryMarshal.GetReference<T>(span);
#else
            return ref span.GetPinnableReference();
#endif // NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        }

        // == BitConverter ==
        /// <summary>
        /// Converts a single-precision floating-point value into a 32-bit integer (将单精度浮点值转换为 32 位整数).
        /// </summary>
        /// <param name="value">The number to convert (欲转换的值).</param>
        /// <returns>A 32-bit integer whose bits are identical to value (一个32位整数，表示转换的单精度浮点值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 SingleToInt32Bits(Single value) {
#if (NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER)
            return BitConverter.SingleToInt32Bits(value);
#else
            return Unsafe.As<Single, Int32>(ref value);
#endif // NET6_0_OR_GREATER
        }

        /// <summary>
        /// Converts a single-precision floating-point value into a 32-bit unsigned integer (将指定的单精度浮点数转换为 32 位无符号整数).
        /// </summary>
        /// <param name="value">The number to convert (欲转换的值).</param>
        /// <returns>A 32-bit integer whose bits are identical to value (一个32位无符号整数，表示转换的单精度浮点值).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 SingleToUInt32Bits(Single value) {
#if NET6_0_OR_GREATER
            return BitConverter.SingleToUInt32Bits(value);
#else
            return Unsafe.As<Single, UInt32>(ref value);
#endif // NET6_0_OR_GREATER
        }

        /// <summary>
        /// Reinterprets the specified 32-bit signed integer value as a single-precision floating-point value (将指定的 32 位有符号整数值重新解释为单精度浮点值).
        /// </summary>
        /// <param name="value">The 32-bit signed integer value to convert (欲转换的32位带符号整数值).</param>
        /// <returns>A single-precision floating-point value that represents the converted integer (表示根据整数转换后的单精度浮点值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single Int32BitsToSingle(Int32 value) {
#if (NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER)
            return BitConverter.Int32BitsToSingle(value);
#else
            return Unsafe.As<Int32, Single>(ref value);
#endif // NET6_0_OR_GREATER
        }

        /// <summary>
        /// Reinterprets the specified 32-bit unsigned integer value as a single-precision floating-point value (将指定的 32 位无符号整数转换为单精度浮点数).
        /// </summary>
        /// <param name="value">The 32-bit unsigned integer value to convert (欲转换的32位无符号整数值).</param>
        /// <returns>A single-precision floating-point value that represents the converted integer (表示根据整数转换后的单精度浮点值).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single UInt32BitsToSingle(UInt32 value) {
#if NET6_0_OR_GREATER
            return BitConverter.UInt32BitsToSingle(value);
#else
            return Unsafe.As<UInt32, Single>(ref value);
#endif // NET6_0_OR_GREATER
        }
        /// <summary>
        /// Converts a double-precision floating-point value into a 64-bit integer (将单精度浮点值转换为 64 位整数).
        /// </summary>
        /// <param name="value">The number to convert (欲转换的值).</param>
        /// <returns>A 64-bit integer whose bits are identical to value (一个64位整数，表示转换的单精度浮点值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 DoubleToInt64Bits(Double value) {
            return BitConverter.DoubleToInt64Bits(value);
        }

        /// <summary>
        /// Converts a double-precision floating-point value into a 64-bit unsigned integer (将指定的单精度浮点数转换为 64 位无符号整数).
        /// </summary>
        /// <param name="value">The number to convert (欲转换的值).</param>
        /// <returns>A 64-bit integer whose bits are identical to value (一个64位无符号整数，表示转换的单精度浮点值).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 DoubleToUInt64Bits(Double value) {
#if NET6_0_OR_GREATER
            return BitConverter.DoubleToUInt64Bits(value);
#else
            return Unsafe.As<Double, UInt64>(ref value);
#endif // NET6_0_OR_GREATER
        }

        /// <summary>
        /// Reinterprets the specified 64-bit signed integer value as a double-precision floating-point value (将指定的 64 位有符号整数值重新解释为单精度浮点值).
        /// </summary>
        /// <param name="value">The 64-bit signed integer value to convert (欲转换的64位带符号整数值).</param>
        /// <returns>A double-precision floating-point value that represents the converted integer (表示根据整数转换后的单精度浮点值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double Int64BitsToDouble(Int64 value) {
            return BitConverter.Int64BitsToDouble(value);
        }

        /// <summary>
        /// Reinterprets the specified 64-bit unsigned integer value as a double-precision floating-point value (将指定的 64 位无符号整数转换为单精度浮点数).
        /// </summary>
        /// <param name="value">The 64-bit unsigned integer value to convert (欲转换的64位无符号整数值).</param>
        /// <returns>A double-precision floating-point value that represents the converted integer (表示根据整数转换后的单精度浮点值).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double UInt64BitsToDouble(UInt64 value) {
#if NET6_0_OR_GREATER
            return BitConverter.UInt64BitsToDouble(value);
#else
            return Unsafe.As<UInt64, Double>(ref value);
#endif // NET6_0_OR_GREATER
        }

#if NET5_0_OR_GREATER
        /// <summary>
        /// Converts a half-precision floating-point value into a 16-bit integer (将半精度浮点值转换为 16 位整数).
        /// </summary>
        /// <param name="value">The number to convert (欲转换的值).</param>
        /// <returns>A 16-bit integer whose bits are identical to value (一个16位整数，表示转换的半精度浮点值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 HalfToInt16Bits(Half value) {
#if NET6_0_OR_GREATER
            return BitConverter.HalfToInt16Bits(value);
#else
            return Unsafe.As<Half, Int16>(ref value);
#endif // NET6_0_OR_GREATER
        }

        /// <summary>
        /// Converts a half-precision floating-point value into a 16-bit unsigned integer (将指定的半精度浮点数转换为 16 位无符号整数).
        /// </summary>
        /// <param name="value">The number to convert (欲转换的值).</param>
        /// <returns>A 16-bit integer whose bits are identical to value (一个16位无符号整数，表示转换的半精度浮点值).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 HalfToUInt16Bits(Half value) {
#if NET6_0_OR_GREATER
            return BitConverter.HalfToUInt16Bits(value);
#else
            return Unsafe.As<Half, UInt16>(ref value);
#endif // NET6_0_OR_GREATER
        }

        /// <summary>
        /// Reinterprets the specified 16-bit signed integer value as a half-precision floating-point value (将指定的 16 位有符号整数值重新解释为半精度浮点值).
        /// </summary>
        /// <param name="value">The 16-bit signed integer value to convert (欲转换的16位带符号整数值).</param>
        /// <returns>A half-precision floating-point value that represents the converted integer (表示根据整数转换后的半精度浮点值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half Int16BitsToHalf(Int16 value) {
#if NET6_0_OR_GREATER
            return BitConverter.Int16BitsToHalf(value);
#else
            return Unsafe.As<Int16, Half>(ref value);
#endif // NET6_0_OR_GREATER
        }

        /// <summary>
        /// Reinterprets the specified 16-bit unsigned integer value as a half-precision floating-point value (将指定的 16 位无符号整数转换为半精度浮点数).
        /// </summary>
        /// <param name="value">The 16-bit unsigned integer value to convert (欲转换的16位无符号整数值).</param>
        /// <returns>A half-precision floating-point value that represents the converted integer (表示根据整数转换后的半精度浮点值).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half UInt16BitsToHalf(UInt16 value) {
#if NET6_0_OR_GREATER
            return BitConverter.UInt16BitsToHalf(value);
#else
            return Unsafe.As<UInt16, Half>(ref value);
#endif // NET6_0_OR_GREATER
        }

#endif // NET5_0_OR_GREATER

    }
}
