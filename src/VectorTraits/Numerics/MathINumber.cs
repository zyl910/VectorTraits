using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Numerics {
    using static BitMathCore;
    using static MathINumberBase;

    /// <summary>
    /// Math functions of <see cref="INumber{TSelf}"/> (INumber 的数学函数).
    /// </summary>
    /// <remarks>
    /// <para>Referenced from generic math (参考了泛型数学): https://learn.microsoft.com/en-us/dotnet/standard/generics/math</para>
    /// </remarks>
    /// <seealso cref="INumber{TSelf}"/>
    /// <seealso cref="BitMath"/>
    public static class MathINumber {

        /// <summary>Returns <paramref name="value" /> clamped to the inclusive range of <paramref name="amin" /> and <paramref name="amax" /> (返回限制在 <paramref name="amin" /> 和 <paramref name="amax" /> 范围内的 <paramref name="value" />).</summary>
        /// <param name="value">The value to be clamped (要限制的值).</param>
        /// <param name="amin">The lower bound of the result (结果的下限).</param>
        /// <param name="amax">The upper bound of the result (结果的上限).</param>
        /// <returns>Returns <c>(value&lt;amax)?( (value&gt;amin)?value:amin ):amax</c>.</returns>
        /// <seealso cref="Math.Clamp(sbyte, sbyte, sbyte)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte Clamp(sbyte value, sbyte amin, sbyte amax) {
            return ConditionalSelect(value < amax, ConditionalSelect(value > amin, value, amin), amax);
        }

        /// <summary>Returns <paramref name="value" /> clamped to the inclusive range of <paramref name="amin" /> and <paramref name="amax" /> (返回限制在 <paramref name="amin" /> 和 <paramref name="amax" /> 范围内的 <paramref name="value" />).</summary>
        /// <param name="value">The value to be clamped (要限制的值).</param>
        /// <param name="amin">The lower bound of the result (结果的下限).</param>
        /// <param name="amax">The upper bound of the result (结果的上限).</param>
        /// <returns>Returns <c>(value&lt;amax)?( (value&gt;amin)?value:amin ):amax</c>.</returns>
        /// <seealso cref="Math.Clamp(byte, byte, byte)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte Clamp(byte value, byte amin, byte amax) {
            return ConditionalSelect(value < amax, ConditionalSelect(value > amin, value, amin), amax);
        }

        /// <summary>Returns <paramref name="value" /> clamped to the inclusive range of <paramref name="amin" /> and <paramref name="amax" /> (返回限制在 <paramref name="amin" /> 和 <paramref name="amax" /> 范围内的 <paramref name="value" />).</summary>
        /// <param name="value">The value to be clamped (要限制的值).</param>
        /// <param name="amin">The lower bound of the result (结果的下限).</param>
        /// <param name="amax">The upper bound of the result (结果的上限).</param>
        /// <returns>Returns <c>(value&lt;amax)?( (value&gt;amin)?value:amin ):amax</c>.</returns>
        /// <seealso cref="Math.Clamp(short, short, short)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short Clamp(short value, short amin, short amax) {
            return ConditionalSelect(value < amax, ConditionalSelect(value > amin, value, amin), amax);
        }

        /// <summary>Returns <paramref name="value" /> clamped to the inclusive range of <paramref name="amin" /> and <paramref name="amax" /> (返回限制在 <paramref name="amin" /> 和 <paramref name="amax" /> 范围内的 <paramref name="value" />).</summary>
        /// <param name="value">The value to be clamped (要限制的值).</param>
        /// <param name="amin">The lower bound of the result (结果的下限).</param>
        /// <param name="amax">The upper bound of the result (结果的上限).</param>
        /// <returns>Returns <c>(value&lt;amax)?( (value&gt;amin)?value:amin ):amax</c>.</returns>
        /// <seealso cref="Math.Clamp(ushort, ushort, ushort)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort Clamp(ushort value, ushort amin, ushort amax) {
            return ConditionalSelect(value < amax, ConditionalSelect(value > amin, value, amin), amax);
        }

        /// <summary>Returns <paramref name="value" /> clamped to the inclusive range of <paramref name="amin" /> and <paramref name="amax" /> (返回限制在 <paramref name="amin" /> 和 <paramref name="amax" /> 范围内的 <paramref name="value" />).</summary>
        /// <param name="value">The value to be clamped (要限制的值).</param>
        /// <param name="amin">The lower bound of the result (结果的下限).</param>
        /// <param name="amax">The upper bound of the result (结果的上限).</param>
        /// <returns>Returns <c>(value&lt;amax)?( (value&gt;amin)?value:amin ):amax</c>.</returns>
        /// <seealso cref="Math.Clamp(int, int, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Clamp(int value, int amin, int amax) {
            return ConditionalSelect(value < amax, ConditionalSelect(value > amin, value, amin), amax);
        }

        /// <summary>Returns <paramref name="value" /> clamped to the inclusive range of <paramref name="amin" /> and <paramref name="amax" /> (返回限制在 <paramref name="amin" /> 和 <paramref name="amax" /> 范围内的 <paramref name="value" />).</summary>
        /// <param name="value">The value to be clamped (要限制的值).</param>
        /// <param name="amin">The lower bound of the result (结果的下限).</param>
        /// <param name="amax">The upper bound of the result (结果的上限).</param>
        /// <returns>Returns <c>(value&lt;amax)?( (value&gt;amin)?value:amin ):amax</c>.</returns>
        /// <seealso cref="Math.Clamp(uint, uint, uint)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Clamp(uint value, uint amin, uint amax) {
            return ConditionalSelect(value < amax, ConditionalSelect(value > amin, value, amin), amax);
        }

        /// <summary>Returns <paramref name="value" /> clamped to the inclusive range of <paramref name="amin" /> and <paramref name="amax" /> (返回限制在 <paramref name="amin" /> 和 <paramref name="amax" /> 范围内的 <paramref name="value" />).</summary>
        /// <param name="value">The value to be clamped (要限制的值).</param>
        /// <param name="amin">The lower bound of the result (结果的下限).</param>
        /// <param name="amax">The upper bound of the result (结果的上限).</param>
        /// <returns>Returns <c>(value&lt;amax)?( (value&gt;amin)?value:amin ):amax</c>.</returns>
        /// <seealso cref="Math.Clamp(long, long, long)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Clamp(long value, long amin, long amax) {
            return ConditionalSelect(value < amax, ConditionalSelect(value > amin, value, amin), amax);
        }

        /// <summary>Returns <paramref name="value" /> clamped to the inclusive range of <paramref name="amin" /> and <paramref name="amax" /> (返回限制在 <paramref name="amin" /> 和 <paramref name="amax" /> 范围内的 <paramref name="value" />).</summary>
        /// <param name="value">The value to be clamped (要限制的值).</param>
        /// <param name="amin">The lower bound of the result (结果的下限).</param>
        /// <param name="amax">The upper bound of the result (结果的上限).</param>
        /// <returns>Returns <c>(value&lt;amax)?( (value&gt;amin)?value:amin ):amax</c>.</returns>
        /// <seealso cref="Math.Clamp(ulong, ulong, ulong)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong Clamp(ulong value, ulong amin, ulong amax) {
            return ConditionalSelect(value < amax, ConditionalSelect(value > amin, value, amin), amax);
        }

        /// <summary>Returns <paramref name="value" /> clamped to the inclusive range of <paramref name="amin" /> and <paramref name="amax" /> (返回限制在 <paramref name="amin" /> 和 <paramref name="amax" /> 范围内的 <paramref name="value" />).</summary>
        /// <param name="value">The value to be clamped (要限制的值).</param>
        /// <param name="amin">The lower bound of the result (结果的下限).</param>
        /// <param name="amax">The upper bound of the result (结果的上限).</param>
        /// <returns>Returns <c>(value&lt;amax)?( (value&gt;amin)?value:amin ):amax</c>.</returns>
        /// <seealso cref="Math.Clamp(nint, nint, nint)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nint Clamp(nint value, nint amin, nint amax) {
            return ConditionalSelect(value < amax, ConditionalSelect(value > amin, value, amin), amax);
        }

        /// <summary>Returns <paramref name="value" /> clamped to the inclusive range of <paramref name="amin" /> and <paramref name="amax" /> (返回限制在 <paramref name="amin" /> 和 <paramref name="amax" /> 范围内的 <paramref name="value" />).</summary>
        /// <param name="value">The value to be clamped (要限制的值).</param>
        /// <param name="amin">The lower bound of the result (结果的下限).</param>
        /// <param name="amax">The upper bound of the result (结果的上限).</param>
        /// <returns>Returns <c>(value&lt;amax)?( (value&gt;amin)?value:amin ):amax</c>.</returns>
        /// <seealso cref="Math.Clamp(nuint, nuint, nuint)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nuint Clamp(nuint value, nuint amin, nuint amax) {
            return ConditionalSelect(value < amax, ConditionalSelect(value > amin, value, amin), amax);
        }

        /// <summary>Returns <paramref name="value" /> clamped to the inclusive range of <paramref name="amin" /> and <paramref name="amax" /> (返回限制在 <paramref name="amin" /> 和 <paramref name="amax" /> 范围内的 <paramref name="value" />).</summary>
        /// <param name="value">The value to be clamped (要限制的值).</param>
        /// <param name="amin">The lower bound of the result (结果的下限).</param>
        /// <param name="amax">The upper bound of the result (结果的上限).</param>
        /// <returns>Returns <c>(value&lt;amax)?( (value&gt;amin)?value:amin ):amax</c>.</returns>
        /// <seealso cref="Math.Clamp(float, float, float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Clamp(float value, float amin, float amax) {
            return ConditionalSelect(value < amax, ConditionalSelect(value > amin, value, amin), amax);
        }

        /// <summary>Returns <paramref name="value" /> clamped to the inclusive range of <paramref name="amin" /> and <paramref name="amax" /> (返回限制在 <paramref name="amin" /> 和 <paramref name="amax" /> 范围内的 <paramref name="value" />).</summary>
        /// <param name="value">The value to be clamped (要限制的值).</param>
        /// <param name="amin">The lower bound of the result (结果的下限).</param>
        /// <param name="amax">The upper bound of the result (结果的上限).</param>
        /// <returns>Returns <c>(value&lt;amax)?( (value&gt;amin)?value:amin ):amax</c>.</returns>
        /// <seealso cref="Math.Clamp(double, double, double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Clamp(double value, double amin, double amax) {
            return ConditionalSelect(value < amax, ConditionalSelect(value > amin, value, amin), amax);
        }

#if NET5_0_OR_GREATER

        /// <summary>Returns <paramref name="value" /> clamped to the inclusive range of <paramref name="amin" /> and <paramref name="amax" /> (返回限制在 <paramref name="amin" /> 和 <paramref name="amax" /> 范围内的 <paramref name="value" />).</summary>
        /// <param name="value">The value to be clamped (要限制的值).</param>
        /// <param name="amin">The lower bound of the result (结果的下限).</param>
        /// <param name="amax">The upper bound of the result (结果的上限).</param>
        /// <returns>Returns <c>(value&lt;amax)?( (value&gt;amin)?value:amin ):amax</c>.</returns>
        /// <seealso cref="Math.Clamp(float, float, float)"/>
        // /// <seealso cref="Math.Clamp(Half, Half, Half)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half Clamp(Half value, Half amin, Half amax) {
            return ConditionalSelect(value < amax, ConditionalSelect(value > amin, value, amin), amax);
        }

#endif // NET5_0_OR_GREATER


        /// <summary>Get the larger of two variables (取得两个变量中较大的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the larger of two variables (返回两个变量中较大的一个).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte Max(sbyte val1, sbyte val2) {
            return ConditionalSelect(val1 > val2, val1, val2);
        }

        /// <summary>Get the larger of two variables (取得两个变量中较大的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the larger of two variables (返回两个变量中较大的一个).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte Max(byte val1, byte val2) {
            return ConditionalSelect(val1 > val2, val1, val2);
        }

        /// <summary>Get the larger of two variables (取得两个变量中较大的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the larger of two variables (返回两个变量中较大的一个).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short Max(short val1, short val2) {
            return ConditionalSelect(val1 > val2, val1, val2);
        }

        /// <summary>Get the larger of two variables (取得两个变量中较大的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the larger of two variables (返回两个变量中较大的一个).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort Max(ushort val1, ushort val2) {
            return ConditionalSelect(val1 > val2, val1, val2);
        }

        /// <summary>Get the larger of two variables (取得两个变量中较大的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the larger of two variables (返回两个变量中较大的一个).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Max(int val1, int val2) {
            return ConditionalSelect(val1 > val2, val1, val2);
        }

        /// <summary>Get the larger of two variables (取得两个变量中较大的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the larger of two variables (返回两个变量中较大的一个).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Max(uint val1, uint val2) {
            return ConditionalSelect(val1 > val2, val1, val2);
        }

        /// <summary>Get the larger of two variables (取得两个变量中较大的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the larger of two variables (返回两个变量中较大的一个).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Max(long val1, long val2) {
            return ConditionalSelect(val1 > val2, val1, val2);
        }

        /// <summary>Get the larger of two variables (取得两个变量中较大的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the larger of two variables (返回两个变量中较大的一个).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong Max(ulong val1, ulong val2) {
            return ConditionalSelect(val1 > val2, val1, val2);
        }

        /// <summary>Get the larger of two variables (取得两个变量中较大的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the larger of two variables (返回两个变量中较大的一个).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nint Max(nint val1, nint val2) {
            return ConditionalSelect(val1 > val2, val1, val2);
        }

        /// <summary>Get the larger of two variables (取得两个变量中较大的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the larger of two variables (返回两个变量中较大的一个).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nuint Max(nuint val1, nuint val2) {
            return ConditionalSelect(val1 > val2, val1, val2);
        }

        /// <summary>Get the larger of two variables (取得两个变量中较大的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the larger of two variables (返回两个变量中较大的一个).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Max(float val1, float val2) {
            return ConditionalSelect(val1 > val2, val1, val2);
        }

        /// <summary>Get the larger of two variables (取得两个变量中较大的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the larger of two variables (返回两个变量中较大的一个).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Max(double val1, double val2) {
            return ConditionalSelect(val1 > val2, val1, val2);
        }

#if NET5_0_OR_GREATER

        /// <summary>Get the larger of two variables (取得两个变量中较大的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the larger of two variables (返回两个变量中较大的一个).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half Max(Half val1, Half val2) {
            return ConditionalSelect(val1 > val2, val1, val2);
        }

#endif // NET5_0_OR_GREATER

        /// <inheritdoc cref="MaxNumber(double, double)"/>
        /// <seealso cref="float.MaxNumber(float, float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float MaxNumber(float x, float y) {
#if NET7_0_OR_GREATER
            return MaxNumber_Bcl(x, y);
#else
            return MaxNumber_Bit(x, y);
#endif // NET7_0_OR_GREATER
        }

        /// <summary>Compares two values to compute which is lesser and returning the other value if an input is <c>NaN</c> (取得两个值中较大的数字. 若其中一个是<c>NaN</c>, 则会返回另一个值).</summary>
        /// <param name="x">The value to compare with <paramref name="y"/> (要与 <paramref name="y"/> 进行比较的值).</param>
        /// <param name="y">The value to compare with <paramref name="x"/> (要与 <paramref name="x"/> 进行比较的值).</param>
        /// <returns>Return the larger number of two variables (返回两个值中较大的数字.).</returns>
        /// <remarks>This method matches the IEEE 754:2019 minimumNumber function. This requires <c>NaN</c> inputs to not be propagated back to the caller and for <c>-0.0</c> to be treated as less than <c>+0.0</c> (此方法与 IEEE 754:2019 minimumNumber 函数匹配。 这要求 <c>NaN</c> 输入不传播回调用方，且 <c>-0.0</c> 被视为小于 <c>+0.0</c>).</remarks>
        /// <seealso cref="INumber{TSelf}.MaxNumber(TSelf, TSelf)"/>
        /// <seealso cref="double.MaxNumber(double, double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double MaxNumber(double x, double y) {
#if NET7_0_OR_GREATER
            return MaxNumber_Bcl(x, y);
#else
            return MaxNumber_Bit(x, y);
#endif // NET7_0_OR_GREATER
        }

#if NET5_0_OR_GREATER
        /// <inheritdoc cref="MaxNumber(double, double)"/>
        /// <seealso cref="Half.MaxNumber(Half, Half)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half MaxNumber(Half x, Half y) {
#if NET7_0_OR_GREATER
            return MaxNumber_Bcl(x, y);
#else
            return MaxNumber_Bit(x, y);
#endif // NET7_0_OR_GREATER
        }
#endif // NET5_0_OR_GREATER

#if NET7_0_OR_GREATER
        /// <inheritdoc cref="MaxNumber(float, float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float MaxNumber_Bcl(float x, float y) {
            return float.MaxNumber(x, y);
        }

        /// <inheritdoc cref="MaxNumber(double, double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double MaxNumber_Bcl(double x, double y) {
            return double.MaxNumber(x, y);
        }

        /// <inheritdoc cref="MaxNumber(Half, Half)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half MaxNumber_Bcl(Half x, Half y) {
            return Half.MaxNumber(x, y);
        }
#endif // NET7_0_OR_GREATER

        /// <inheritdoc cref="MaxNumber(float, float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float MaxNumber_Bit(float x, float y) {
            bool mask = x > y;
            mask |= (x == y) && IsNegative(y);
            mask |= IsNaN(y);
            return ConditionalSelect(mask, x, y);
        }

        /// <inheritdoc cref="MaxNumber(double, double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double MaxNumber_Bit(double x, double y) {
            bool mask = x > y;
            mask |= (x == y) && IsNegative(y);
            mask |= IsNaN(y);
            return ConditionalSelect(mask, x, y);
        }

#if NET5_0_OR_GREATER
        /// <inheritdoc cref="MaxNumber(Half, Half)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half MaxNumber_Bit(Half x, Half y) {
            bool mask = x > y;
            mask |= (x == y) && IsNegative(y);
            mask |= IsNaN(y);
            return ConditionalSelect(mask, x, y);
        }
#endif // NET5_0_OR_GREATER

        /// <summary>Get the smaller of two variables (取得两个变量中较小的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the smaller of two variables (返回两个变量中较小的一个).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte Min(sbyte val1, sbyte val2) {
            return ConditionalSelect(val1 < val2, val1, val2);
        }

        /// <summary>Get the smaller of two variables (取得两个变量中较小的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the smaller of two variables (返回两个变量中较小的一个).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte Min(byte val1, byte val2) {
            return ConditionalSelect(val1 < val2, val1, val2);
        }

        /// <summary>Get the smaller of two variables (取得两个变量中较小的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the smaller of two variables (返回两个变量中较小的一个).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short Min(short val1, short val2) {
            return ConditionalSelect(val1 < val2, val1, val2);
        }

        /// <summary>Get the smaller of two variables (取得两个变量中较小的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the smaller of two variables (返回两个变量中较小的一个).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort Min(ushort val1, ushort val2) {
            return ConditionalSelect(val1 < val2, val1, val2);
        }

        /// <summary>Get the smaller of two variables (取得两个变量中较小的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the smaller of two variables (返回两个变量中较小的一个).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Min(int val1, int val2) {
            return ConditionalSelect(val1 < val2, val1, val2);
        }

        /// <summary>Get the smaller of two variables (取得两个变量中较小的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the smaller of two variables (返回两个变量中较小的一个).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Min(uint val1, uint val2) {
            return ConditionalSelect(val1 < val2, val1, val2);
        }

        /// <summary>Get the smaller of two variables (取得两个变量中较小的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the smaller of two variables (返回两个变量中较小的一个).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Min(long val1, long val2) {
            return ConditionalSelect(val1 < val2, val1, val2);
        }

        /// <summary>Get the smaller of two variables (取得两个变量中较小的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the smaller of two variables (返回两个变量中较小的一个).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong Min(ulong val1, ulong val2) {
            return ConditionalSelect(val1 < val2, val1, val2);
        }

        /// <summary>Get the smaller of two variables (取得两个变量中较小的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the smaller of two variables (返回两个变量中较小的一个).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nint Min(nint val1, nint val2) {
            return ConditionalSelect(val1 < val2, val1, val2);
        }

        /// <summary>Get the smaller of two variables (取得两个变量中较小的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the smaller of two variables (返回两个变量中较小的一个).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nuint Min(nuint val1, nuint val2) {
            return ConditionalSelect(val1 < val2, val1, val2);
        }

        /// <summary>Get the smaller of two variables (取得两个变量中较小的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the smaller of two variables (返回两个变量中较小的一个).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Min(float val1, float val2) {
            return ConditionalSelect(val1 < val2, val1, val2);
        }

        /// <summary>Get the smaller of two variables (取得两个变量中较小的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the smaller of two variables (返回两个变量中较小的一个).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Min(double val1, double val2) {
            return ConditionalSelect(val1 < val2, val1, val2);
        }

#if NET5_0_OR_GREATER

        /// <summary>Get the smaller of two variables (取得两个变量中较小的一个).</summary>
        /// <param name="val1">The first of two variables to compare (要比较的两个变量中的第一个).</param>
        /// <param name="val2">The second of two variables to compare (要比较的两个变量中的第二个).</param>
        /// <returns>Return the smaller of two variables (返回两个变量中较小的一个).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half Min(Half val1, Half val2) {
            return ConditionalSelect(val1 < val2, val1, val2);
        }

#endif // NET5_0_OR_GREATER


    }
}
