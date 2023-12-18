using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Numerics {
    using static BitMathCore;

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
