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
        /// <param name="value">The 32-bit signed integer value to convert (欲转换的32位带符号整数值).</param>
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
        /// <param name="value">The 64-bit signed integer value to convert (欲转换的64位带符号整数值).</param>
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
        /// <param name="value">The 16-bit signed integer value to convert (欲转换的16位带符号整数值).</param>
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

        /// <summary>Conditionally mask selects a value from two variables on a bitwise basis (按条件掩码从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte BitSelect(sbyte condition, sbyte left, sbyte right) {
            return (sbyte)((left & condition) | (right & ~condition));
        }

        /// <summary>Conditionally mask selects a value from two variables on a bitwise basis (按条件掩码从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte BitSelect(byte condition, byte left, byte right) {
            return (byte)((left & condition) | (right & ~condition));
        }

        /// <summary>Conditionally mask selects a value from two variables on a bitwise basis (按条件掩码从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short BitSelect(short condition, short left, short right) {
            return (short)((left & condition) | (right & ~condition));
        }

        /// <summary>Conditionally mask selects a value from two variables on a bitwise basis (按条件掩码从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort BitSelect(ushort condition, ushort left, ushort right) {
            return (ushort)((left & condition) | (right & ~condition));
        }

        /// <summary>Conditionally mask selects a value from two variables on a bitwise basis (按条件掩码从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int BitSelect(int condition, int left, int right) {
            return (left & condition) | (right & ~condition);
        }

        /// <summary>Conditionally mask selects a value from two variables on a bitwise basis (按条件掩码从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint BitSelect(uint condition, uint left, uint right) {
            return (left & condition) | (right & ~condition);
        }

        /// <summary>Conditionally mask selects a value from two variables on a bitwise basis (按条件掩码从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long BitSelect(long condition, long left, long right) {
            return (left & condition) | (right & ~condition);
        }

        /// <summary>Conditionally mask selects a value from two variables on a bitwise basis (按条件掩码从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong BitSelect(ulong condition, ulong left, ulong right) {
            return (left & condition) | (right & ~condition);
        }

        /// <summary>Conditionally mask selects a value from two variables on a bitwise basis (按条件掩码从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nint BitSelect(nint condition, nint left, nint right) {
            return (left & condition) | (right & ~condition);
        }

        /// <summary>Conditionally mask selects a value from two variables on a bitwise basis (按条件掩码从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nuint BitSelect(nuint condition, nuint left, nuint right) {
            return (left & condition) | (right & ~condition);
        }

        /// <summary>Conditionally mask selects a value from two variables on a bitwise basis (按条件掩码从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float BitSelect(int condition, float left, float right) {
            return Int32BitsToSingle(BitSelect(condition, SingleToInt32Bits(left), SingleToInt32Bits(right)));
        }

        /// <summary>Conditionally mask selects a value from two variables on a bitwise basis (按条件掩码从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float BitSelect(float condition, float left, float right) {
            return BitSelect(SingleToInt32Bits(condition), left, right);
        }

        /// <summary>Conditionally mask selects a value from two variables on a bitwise basis (按条件掩码从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double BitSelect(long condition, double left, double right) {
            return Int64BitsToDouble(BitSelect(condition, DoubleToInt64Bits(left), DoubleToInt64Bits(right)));
        }

        /// <summary>Conditionally mask selects a value from two variables on a bitwise basis (按条件掩码从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double BitSelect(double condition, double left, double right) {
            return BitSelect(DoubleToInt64Bits(condition), left, right);
        }

#if NET5_0_OR_GREATER

        /// <summary>Conditionally mask selects a value from two variables on a bitwise basis (按条件掩码从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half BitSelect(short condition, Half left, Half right) {
            return Int16BitsToHalf(BitSelect(condition, HalfToInt16Bits(left), HalfToInt16Bits(right)));
        }

        /// <summary>Conditionally mask selects a value from two variables on a bitwise basis (按条件掩码从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half BitSelect(Half condition, Half left, Half right) {
            return BitSelect(HalfToInt16Bits(condition), left, right);
        }

#endif // NET5_0_OR_GREATER

        /// <summary>
        /// Convert bool to Int32 (将 bool 转为 Int32).
        /// </summary>
        /// <param name="b">Source bool value (源 bool 值)</param>
        /// <returns>A int value (一个整数值). false is 0, true is 1 . </returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe int ToInt32(bool b) {
            return *(sbyte*)&b;
        }

        /// <summary>
        /// Convert bool to Int32 mask (将 bool 转为 Int32 掩码).
        /// </summary>
        /// <param name="b">Source bool value (源 bool 值)</param>
        /// <returns>A int value (一个整数值). false is 0, true is -1 . </returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ToInt32Mask(bool b) {
            return -ToInt32(b);
        }

        /// <summary>Conditionally selects a value from two variables on a bitwise basis (按条件从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte ConditionalSelect(bool condition, sbyte left, sbyte right) {
            return BitSelect((sbyte)ToInt32Mask(condition), left, right);
        }

        /// <summary>Conditionally selects a value from two variables on a bitwise basis (按条件从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte ConditionalSelect(bool condition, byte left, byte right) {
            return BitSelect((byte)ToInt32Mask(condition), left, right);
        }

        /// <summary>Conditionally selects a value from two variables on a bitwise basis (按条件从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short ConditionalSelect(bool condition, short left, short right) {
            return BitSelect((short)ToInt32Mask(condition), left, right);
        }

        /// <summary>Conditionally selects a value from two variables on a bitwise basis (按条件从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort ConditionalSelect(bool condition, ushort left, ushort right) {
            return BitSelect((ushort)ToInt32Mask(condition), left, right);
        }

        /// <summary>Conditionally selects a value from two variables on a bitwise basis (按条件从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ConditionalSelect(bool condition, int left, int right) {
            return BitSelect((int)ToInt32Mask(condition), left, right);
        }

        /// <summary>Conditionally selects a value from two variables on a bitwise basis (按条件从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ConditionalSelect(bool condition, uint left, uint right) {
            return BitSelect((uint)ToInt32Mask(condition), left, right);
        }

        /// <summary>Conditionally selects a value from two variables on a bitwise basis (按条件从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ConditionalSelect(bool condition, long left, long right) {
            return BitSelect((long)ToInt32Mask(condition), left, right);
        }

        /// <summary>Conditionally selects a value from two variables on a bitwise basis (按条件从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ConditionalSelect(bool condition, ulong left, ulong right) {
            return BitSelect((ulong)(long)ToInt32Mask(condition), left, right);
        }

        /// <summary>Conditionally selects a value from two variables on a bitwise basis (按条件从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nint ConditionalSelect(bool condition, nint left, nint right) {
            return BitSelect((nint)ToInt32Mask(condition), left, right);
        }

        /// <summary>Conditionally selects a value from two variables on a bitwise basis (按条件从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nuint ConditionalSelect(bool condition, nuint left, nuint right) {
            return BitSelect((nuint)(nint)ToInt32Mask(condition), left, right);
        }

        /// <summary>Conditionally selects a value from two variables on a bitwise basis (按条件从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ConditionalSelect(bool condition, float left, float right) {
            return Int32BitsToSingle(ConditionalSelect(condition, SingleToInt32Bits(left), SingleToInt32Bits(right)));
        }

        /// <summary>Conditionally selects a value from two variables on a bitwise basis (按条件从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double ConditionalSelect(bool condition, double left, double right) {
            return Int64BitsToDouble(ConditionalSelect(condition, DoubleToInt64Bits(left), DoubleToInt64Bits(right)));
        }

#if NET5_0_OR_GREATER

        /// <summary>Conditionally selects a value from two variables on a bitwise basis (按条件从两个变量中按位选择值).</summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The variable that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的变量).</param>
        /// <param name="right">The variable that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的变量).</param>
        /// <returns>A value whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个数值，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half ConditionalSelect(bool condition, Half left, Half right) {
            return Int16BitsToHalf(ConditionalSelect(condition, HalfToInt16Bits(left), HalfToInt16Bits(right)));
        }

#endif // NET5_0_OR_GREATER

    }
}
