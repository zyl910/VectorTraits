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


        /// <inheritdoc cref="CopySign(double, double)"/>
        /// <seealso cref="MathF.CopySign(float, float)"/>
        /// <seealso cref="float.CopySign(float, float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float CopySign(float value, float sign) {
#if NETCOREAPP3_0_OR_GREATER
            return CopySign_Bcl(value, sign);
#else
            return CopySign_Bit(value, sign);
#endif // NETCOREAPP3_0_OR_GREATER
        }

        /// <summary>Copies the sign of a value to the sign of another value (将一个值的符号复制到另一个值).</summary>
        /// <param name="value">The value whose magnitude is used in the result (结果中使用的幅度).</param>
        /// <param name="sign">The value whose sign is used in the result (结果中使用符号的值).</param>
        /// <returns>A value with the magnitude of value and the sign of sign (根据 value的幅度和sign的符号而生成的值).</returns>
        /// <remarks>
        /// <para>No exception is thrown. For the <c>MinValue</c> of integer types, the source value is returned.(不会抛出异常. 对于整数类型的 <c>MinValue</c>, 会返回源值).</para>
        /// <para>But <see cref="CopySign_Bcl(int, int)">CopySign_Bcl</see> behaves differently. Throws an exception for the <c>MinValue</c> of integer types (而 <see cref="CopySign_Bcl(int, int)">CopySign_Bcl</see> 的行为有所不同. 对于整数类型的 <c>MinValue</c>, 会抛出异常): System.OverflowException : Negating the minimum value of a twos complement number is invalid.</para>
        /// </remarks>
        /// <seealso cref="INumber{TSelf}.CopySign(TSelf, TSelf)"/>
        /// <seealso cref="Math.CopySign(double, double)"/>
        /// <seealso cref="double.CopySign(double, double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double CopySign(double value, double sign) {
#if NETCOREAPP3_0_OR_GREATER
            return CopySign_Bcl(value, sign);
#else
            return CopySign_Bit(value, sign);
#endif // NETCOREAPP3_0_OR_GREATER
        }

#if NET5_0_OR_GREATER
        /// <inheritdoc cref="CopySign(double, double)"/>
        /// <seealso cref="Half.CopySign(Half, Half)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half CopySign(Half value, Half sign) {
#if NET7_0_OR_GREATER
            return CopySign_Bcl(value, sign);
#else
            return CopySign_Bit(value, sign);
#endif // NET7_0_OR_GREATER
        }
#endif // NET5_0_OR_GREATER

        /// <inheritdoc cref="CopySign(double, double)"/>
        /// <seealso cref="sbyte.CopySign(sbyte, sbyte)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte CopySign(sbyte value, sbyte sign) {
            return CopySign_Bit(value, sign);
            // System.OverflowException : Negating the minimum value of a twos complement number is invalid.
            //return CopySign_Bcl(value, sign);
        }

        /// <inheritdoc cref="CopySign(double, double)"/>
        /// <seealso cref="short.CopySign(short, short)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short CopySign(short value, short sign) {
            return CopySign_Bit(value, sign);
            // System.OverflowException : Negating the minimum value of a twos complement number is invalid.
            //return CopySign_Bcl(value, sign);
        }

        /// <inheritdoc cref="CopySign(double, double)"/>
        /// <seealso cref="int.CopySign(int, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CopySign(int value, int sign) {
            return CopySign_Bit(value, sign);
            // System.OverflowException : Negating the minimum value of a twos complement number is invalid.
            //return CopySign_Bcl(value, sign);
        }

        /// <inheritdoc cref="CopySign(double, double)"/>
        /// <seealso cref="long.CopySign(long, long)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long CopySign(long value, long sign) {
            return CopySign_Bit(value, sign);
            // System.OverflowException : Negating the minimum value of a twos complement number is invalid.
            //return CopySign_Bcl(value, sign);
        }

#if NETCOREAPP3_0_OR_GREATER
        /// <inheritdoc cref="CopySign(float, float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float CopySign_Bcl(float value, float sign) {
            return MathF.CopySign(value, sign);
        }

        /// <inheritdoc cref="CopySign(double, double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double CopySign_Bcl(double value, double sign) {
            return Math.CopySign(value, sign);
        }

#if NET5_0_OR_GREATER
        /// <inheritdoc cref="CopySign(Half, Half)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half CopySign_Bcl(Half value, Half sign) {
#if NET7_0_OR_GREATER
            return Half.CopySign(value, sign);
#else
            return CopySign_Bit(value, sign);
#endif // NET7_0_OR_GREATER
        }
#endif // NET5_0_OR_GREATER

        /// <inheritdoc cref="CopySign(sbyte, sbyte)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte CopySign_Bcl(sbyte value, sbyte sign) {
#if NET7_0_OR_GREATER
            return sbyte.CopySign(value, sign);
#else
            return CopySign_Bit(value, sign);
#endif // NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="CopySign(short, short)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short CopySign_Bcl(short value, short sign) {
#if NET7_0_OR_GREATER
            return short.CopySign(value, sign);
#else
            return CopySign_Bit(value, sign);
#endif // NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="CopySign(int, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CopySign_Bcl(int value, int sign) {
#if NET7_0_OR_GREATER
            return int.CopySign(value, sign);
#else
            return CopySign_Bit(value, sign);
#endif // NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="CopySign(long, long)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long CopySign_Bcl(long value, long sign) {
#if NET7_0_OR_GREATER
            return long.CopySign(value, sign);
#else
            return CopySign_Bit(value, sign);
#endif // NET7_0_OR_GREATER
        }
#endif // NETCOREAPP3_0_OR_GREATER

        /// <inheritdoc cref="CopySign(float, float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float CopySign_Bit(float value, float sign) {
            const int signMask = ScalarConstants.Single_SignMask;
            int xbits = MathBitConverter.SingleToInt32Bits(value);
            int ybits = MathBitConverter.SingleToInt32Bits(sign);
            xbits &= ~signMask;
            ybits &= signMask;
            return MathBitConverter.Int32BitsToSingle(xbits | ybits);
        }

        /// <inheritdoc cref="CopySign(double, double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double CopySign_Bit(double value, double sign) {
            const long signMask = ScalarConstants.Double_SignMask;
            long xbits = BitConverter.DoubleToInt64Bits(value);
            long ybits = BitConverter.DoubleToInt64Bits(sign);
            xbits &= ~signMask;
            ybits &= signMask;
            return BitConverter.Int64BitsToDouble(xbits | ybits);
        }

#if NET5_0_OR_GREATER
        /// <inheritdoc cref="CopySign(Half, Half)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half CopySign_Bit(Half value, Half sign) {
            const short signMask = ScalarConstants.Half_SignMask;
            short xbits = MathBitConverter.HalfToInt16Bits(value);
            short ybits = MathBitConverter.HalfToInt16Bits(sign);
            xbits &= ~signMask;
            ybits &= signMask;
            return MathBitConverter.Int16BitsToHalf((short)(xbits | ybits));
        }
#endif // NET5_0_OR_GREATER

        /// <inheritdoc cref="CopySign(sbyte, sbyte)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte CopySign_Bit(sbyte value, sbyte sign) {
            return (sbyte)CopySign_Bit((int)value, (int)sign);
        }

        /// <inheritdoc cref="CopySign(short, short)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short CopySign_Bit(short value, short sign) {
            return (short)CopySign_Bit((int)value, (int)sign);
        }

        /// <inheritdoc cref="CopySign(int, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CopySign_Bit(int value, int sign) {
            // t = ((x^y)>>31); ISIGN = (x^t)-t; // From "Hacker's Delight" 2.9, Page 20.
            unchecked {
                int t = (value ^ sign) >> 31;
                //Console.WriteLine(string.Format("value={0}, sign={1}, t={2}", value, sign, t));
                int rt = (value ^ t) - t;
                return rt;
            }
        }

        /// <inheritdoc cref="CopySign(long, long)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long CopySign_Bit(long value, long sign) {
            unchecked {
                long t = (value ^ sign) >> 63;
                long rt = (value ^ t) - t;
                return rt;
            }
        }


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
            mask |= IsNaN(y);
            mask |= (x == y) && IsNegative(y);
            return ConditionalSelect(mask, x, y);
        }

        /// <inheritdoc cref="MaxNumber(double, double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double MaxNumber_Bit(double x, double y) {
            bool mask = x > y;
            mask |= IsNaN(y);
            mask |= (x == y) && IsNegative(y);
            return ConditionalSelect(mask, x, y);
        }

#if NET5_0_OR_GREATER
        /// <inheritdoc cref="MaxNumber(Half, Half)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half MaxNumber_Bit(Half x, Half y) {
            bool mask = x > y;
            mask |= IsNaN(y);
            mask |= (x == y) && IsNegative(y);
            return ConditionalSelect(mask, x, y);
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

        /// <summary>Compares two values to compute which is greater and returning the other value if an input is <c>NaN</c> (取得两个值中较大的数字. 若其中一个是<c>NaN</c>, 则会返回另一个值).</summary>
        /// <param name="x">The value to compare with <paramref name="y"/> (要与 <paramref name="y"/> 进行比较的值).</param>
        /// <param name="y">The value to compare with <paramref name="x"/> (要与 <paramref name="x"/> 进行比较的值).</param>
        /// <returns>Return the greater number of two variables (返回两个值中较大的数字.).</returns>
        /// <remarks>This method matches the IEEE 754:2019 maximumNumber function. This requires <c>NaN</c> inputs to not be propagated back to the caller and for <c>-0.0</c> to be treated as less than <c>+0.0</c> (此方法与 IEEE 754:2019 maximumNumber 函数匹配。 这要求 <c>NaN</c> 输入不传播回调用方，且 <c>-0.0</c> 被视为小于 <c>+0.0</c>).</remarks>
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


        /// <inheritdoc cref="MinNumber(double, double)"/>
        /// <seealso cref="float.MinNumber(float, float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float MinNumber(float x, float y) {
#if NET7_0_OR_GREATER
            return MinNumber_Bcl(x, y);
#else
            return MinNumber_Bit(x, y);
#endif // NET7_0_OR_GREATER
        }

        /// <summary>Compares two values to compute which is lesser and returning the other value if an input is <c>NaN</c> (取得两个值中较小的数字. 若其中一个是<c>NaN</c>, 则会返回另一个值).</summary>
        /// <param name="x">The value to compare with <paramref name="y"/> (要与 <paramref name="y"/> 进行比较的值).</param>
        /// <param name="y">The value to compare with <paramref name="x"/> (要与 <paramref name="x"/> 进行比较的值).</param>
        /// <returns>Return the lesser number of two variables (返回两个值中较小的数字.).</returns>
        /// <remarks>This method matches the IEEE 754:2019 minimumNumber function. This requires <c>NaN</c> inputs to not be propagated back to the caller and for <c>-0.0</c> to be treated as less than <c>+0.0</c> (此方法与 IEEE 754:2019 minimumNumber 函数匹配。 这要求 <c>NaN</c> 输入不传播回调用方，且 <c>-0.0</c> 被视为小于 <c>+0.0</c>).</remarks>
        /// <seealso cref="INumber{TSelf}.MinNumber(TSelf, TSelf)"/>
        /// <seealso cref="double.MinNumber(double, double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double MinNumber(double x, double y) {
#if NET7_0_OR_GREATER
            return MinNumber_Bcl(x, y);
#else
            return MinNumber_Bit(x, y);
#endif // NET7_0_OR_GREATER
        }

#if NET5_0_OR_GREATER
        /// <inheritdoc cref="MinNumber(double, double)"/>
        /// <seealso cref="Half.MinNumber(Half, Half)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half MinNumber(Half x, Half y) {
#if NET7_0_OR_GREATER
            return MinNumber_Bcl(x, y);
#else
            return MinNumber_Bit(x, y);
#endif // NET7_0_OR_GREATER
        }
#endif // NET5_0_OR_GREATER

#if NET7_0_OR_GREATER
        /// <inheritdoc cref="MinNumber(float, float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float MinNumber_Bcl(float x, float y) {
            return float.MinNumber(x, y);
        }

        /// <inheritdoc cref="MinNumber(double, double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double MinNumber_Bcl(double x, double y) {
            return double.MinNumber(x, y);
        }

        /// <inheritdoc cref="MinNumber(Half, Half)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half MinNumber_Bcl(Half x, Half y) {
            return Half.MinNumber(x, y);
        }
#endif // NET7_0_OR_GREATER

        /// <inheritdoc cref="MinNumber(float, float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float MinNumber_Bit(float x, float y) {
            bool mask = x < y;
            mask |= (x == y) && IsNegative(x);
            mask |= IsNaN(y);
            return ConditionalSelect(mask, x, y);
        }

        /// <inheritdoc cref="MinNumber(double, double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double MinNumber_Bit(double x, double y) {
            bool mask = x < y;
            mask |= (x == y) && IsNegative(x);
            mask |= IsNaN(y);
            return ConditionalSelect(mask, x, y);
        }

#if NET5_0_OR_GREATER
        /// <inheritdoc cref="MinNumber(Half, Half)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half MinNumber_Bit(Half x, Half y) {
            bool mask = x < y;
            mask |= (x == y) && IsNegative(x);
            mask |= IsNaN(y);
            return ConditionalSelect(mask, x, y);
        }
#endif // NET5_0_OR_GREATER


        /// <inheritdoc cref="Sign(double)"/>
        /// <seealso cref="Math.Sign(float)"/>
        /// <seealso cref="float.Sign"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign(float value) {
            return Sign_Bit(value);
            // System.ArithmeticException: Function does not accept floating point Not-a-Number values.
            //return Sign_Bcl(value);
        }

        /// <summary>
        /// Computes the sign of a value (计算值的符号).
        /// </summary>
        /// <param name="value">The value whose sign is to be computed (要计算其符号的值)</param>
        /// <returns>Returns 1 if the value is positive, 0 if the value is zero, and -1 if the value is negative (值为正数时返回1, 值为0时返回0, 值为负数时返回-1).</returns>
        /// <remarks>
        /// <para>No exception is thrown. For the <c>NaN</c> of float types, returns 0.(不会抛出异常. 对于浮点类型的 <c>NaN</c>, 会返回0).</para>
        /// <para>But <see cref="Sign_Bcl(float)">Sign_Bcl</see> behaves differently. Throws an exception for the <c>NaN</c> of float types (而 <see cref="Sign_Bcl(int, int)">Sign_Bcl</see> 的行为有所不同. 对于浮点类型的 <c>NaN</c>, 会抛出异常): System.ArithmeticException: Function does not accept floating point Not-a-Number values.</para>
        /// </remarks>
        /// <seealso cref="INumber{TSelf}.Sign(TSelf)"/>
        /// <seealso cref="Math.Sign(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign(double value) {
            return Sign_Bit(value);
            // System.ArithmeticException: Function does not accept floating point Not-a-Number values.
            //return Sign_Bcl(value);
        }

#if NET5_0_OR_GREATER
        /// <inheritdoc cref="Sign(double)"/>
        /// <seealso cref="Half.Sign"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign(Half value) {
            return Sign_Bit(value);
            // System.ArithmeticException: Function does not accept floating point Not-a-Number values.
            //return Sign_Bcl(value);
        }
#endif // NET5_0_OR_GREATER

        /// <inheritdoc cref="Sign(double)"/>
        /// <seealso cref="Math.Sign(sbyte)"/>
        /// <seealso cref="sbyte.Sign"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign(sbyte value) {
            return Sign_Bcl(value);
        }

        /// <inheritdoc cref="Sign(double)"/>
        /// <seealso cref="Math.Sign(short)"/>
        /// <seealso cref="short.Sign"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign(short value) {
            return Sign_Bcl(value);
        }

        /// <inheritdoc cref="Sign(double)"/>
        /// <seealso cref="Math.Sign(int)"/>
        /// <seealso cref="int.Sign"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign(int value) {
            return Sign_Bcl(value);
        }

        /// <inheritdoc cref="Sign(double)"/>
        /// <seealso cref="Math.Sign(long)"/>
        /// <seealso cref="long.Sign"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign(long value) {
            return Sign_Bcl(value);
        }

        /// <inheritdoc cref="Sign(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign_Bcl(float value) {
            return Math.Sign(value);
        }

        /// <inheritdoc cref="Sign(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign_Bcl(double value) {
            return Math.Sign(value);
        }

#if NET5_0_OR_GREATER
        /// <inheritdoc cref="Sign(Half)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign_Bcl(Half value) {
#if NET7_0_OR_GREATER
            return Half.Sign(value);
#else
            return Sign_Bit(value);
#endif // NET7_0_OR_GREATER
        }
#endif // NET5_0_OR_GREATER

        /// <inheritdoc cref="Sign(sbyte)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign_Bcl(sbyte value) {
            return Math.Sign(value);
        }

        /// <inheritdoc cref="Sign(short)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign_Bcl(short value) {
            return Math.Sign(value);
        }

        /// <inheritdoc cref="Sign(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign_Bcl(int value) {
            return Math.Sign(value);
        }

        /// <inheritdoc cref="Sign(long)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign_Bcl(long value) {
            return Math.Sign(value);
        }

        /// <inheritdoc cref="Sign(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign_Bit(float value) {
            int m = ToInt32(value > 0);
            int n = ToInt32(value < 0);
            int rt = m - n;
            return rt;
        }

        /// <inheritdoc cref="Sign(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign_Bit(double value) {
            // (x > 0) - (x < 0); //From "Hacker's Delight" 2.7, Page 19.
            int m = ToInt32(value > 0);
            int n = ToInt32(value < 0);
            int rt = m - n;
            return rt;
        }

#if NET5_0_OR_GREATER
        /// <inheritdoc cref="Sign(Half)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign_Bit(Half value) {
            Half zero = (Half)0;
            int m = ToInt32(value > zero);
            int n = ToInt32(value < zero);
            int rt = m - n;
            return rt;
        }
#endif // NET5_0_OR_GREATER

        /// <inheritdoc cref="Sign(sbyte)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign_Bit(sbyte value) {
            return Sign_Bit((int)value);
        }

        /// <inheritdoc cref="Sign(short)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign_Bit(short value) {
            return Sign_Bit((int)value);
        }

        /// <inheritdoc cref="Sign(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign_Bit(int value) {
            // (x >> 31) | (-x u>> 31); //From "Hacker's Delight" 2.7, Page 19.
            return unchecked(value >> 31 | (int)((uint)-value >> 31));
        }

        /// <inheritdoc cref="Sign(long)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign_Bit(long value) {
            return unchecked((int)(value >> 63 | (long)((ulong)-value >> 63)));
        }


        /// <inheritdoc cref="SignFloat(double)"/>
        /// <seealso cref="Math.Sign(float)"/>
        /// <seealso cref="float.Sign"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float SignFloat(float value) {
            return SignFloat_Bit(value);
            // Poor performance due to the presence of branching statements.
            //return SignFloat_Bcl(value);
        }

        /// <summary>
        /// Computes the sign of a value and returns a floating point number (计算值的符号并返回浮点数).
        /// </summary>
        /// <param name="value">The value whose sign is to be computed (要计算其符号的值)</param>
        /// <returns>Returns 1 if the value is positive, 0 if the value is zero, -1 if the value is negative, and <c>NaN</c> if the value is <c>NaN</c> (值为正数时返回1, 值为0时返回0, 值为负数时返回-1, 值为<c>NaN</c>时返回<c>NaN</c>).</returns>
        /// <remarks>
        /// <para>No exception is thrown. For the <c>NaN</c> of float types, returns <c>NaN</c>.(不会抛出异常. 对于浮点类型的 <c>NaN</c>, 会返回 <c>NaN</c>).</para>
        /// </remarks>
        /// <seealso cref="INumber{TSelf}.Sign(TSelf)"/>
        /// <seealso cref="Math.Sign(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double SignFloat(double value) {
            return SignFloat_Bit(value);
            // Poor performance due to the presence of branching statements.
            //return SignFloat_Bcl(value);
        }

#if NET5_0_OR_GREATER
        /// <inheritdoc cref="SignFloat(double)"/>
        /// <seealso cref="Half.Sign"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half SignFloat(Half value) {
            return SignFloat_Bit(value);
            // Poor performance due to the presence of branching statements.
            //return SignFloat_Bcl(value);
        }
#endif // NET5_0_OR_GREATER

        /// <inheritdoc cref="SignFloat(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float SignFloat_Bcl(float value) {
            if (IsNaN_Bcl(value)) return value;
            return (float)Sign_Bit(value);
        }

        /// <inheritdoc cref="SignFloat(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double SignFloat_Bcl(double value) {
            if (IsNaN_Bcl(value)) return value;
            return (double)Sign_Bit(value);
        }

#if NET5_0_OR_GREATER
        /// <inheritdoc cref="SignFloat(Half)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half SignFloat_Bcl(Half value) {
#if NET7_0_OR_GREATER
            if (IsNaN_Bcl(value)) return value;
            return (Half)Sign_Bit(value);
#else
            return SignFloat_Bit(value);
#endif // NET7_0_OR_GREATER
        }
#endif // NET5_0_OR_GREATER

        /// <inheritdoc cref="SignFloat(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float SignFloat_Bit(float value) {
            bool nanMask = IsNaN_Bit(value);
            float rt = (float)Sign_Bit(value);
            rt = ConditionalSelect(nanMask, value, rt);
            return rt;
        }

        /// <inheritdoc cref="SignFloat(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double SignFloat_Bit(double value) {
            bool nanMask = IsNaN_Bit(value);
            double rt = (double)Sign_Bit(value);
            rt = ConditionalSelect(nanMask, value, rt);
            return rt;
        }

#if NET5_0_OR_GREATER
        /// <inheritdoc cref="SignFloat(Half)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half SignFloat_Bit(Half value) {
            bool nanMask = IsNaN_Bit(value);
            Half rt = (Half)Sign_Bit(value);
            rt = ConditionalSelect(nanMask, value, rt);
            return rt;
        }
#endif // NET5_0_OR_GREATER


    }
}
