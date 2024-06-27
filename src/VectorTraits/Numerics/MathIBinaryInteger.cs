using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zyl.VectorTraits.Numerics {
    using static BitMathCore;

    /// <summary>
    /// Math functions of <see cref="IBinaryInteger{TSelf}"/> (IBinaryInteger 的数学函数).
    /// </summary>
    /// <remarks>
    /// <para>Referenced from generic math (参考了泛型数学): https://learn.microsoft.com/en-us/dotnet/standard/generics/math</para>
    /// </remarks>
    /// <seealso cref="IBinaryInteger{TSelf}"/>
    /// <seealso cref="BitMath"/>
    public static class MathIBinaryInteger {

        /// <summary>
        /// Calculates the quotient of two 32-bit signed integers and also returns the remainder in an output parameter (计算两个 32 位有符号整数的商，并通过输出参数返回余数).
        /// </summary>
        /// <param name="a">The dividend (被除数).</param>
        /// <param name="b">The divisor (除数).</param>
        /// <param name="result">When this method returns, contains the remainder (当此方法返回时，包含余数).</param>
        /// <returns>The quotient of the specified numbers (指定数字的商).</returns>
        /// <exception cref="DivideByZeroException"><paramref name="b"/> is zero.</exception>
        public static int DivRem(int a, int b, out int result) {
#if NETCOREAPP2_0_OR_GREATER || NETSTANDARD2_0_OR_GREATER || NET20_OR_GREATER
            return Math.DivRem(a, b, out result);
#else
            int div = a / b;
            result = a - (div * b);
            return div;
#endif // NETCOREAPP2_0_OR_GREATER || NETSTANDARD2_0_OR_GREATER || NET20_OR_GREATER
        }

        /// <summary>
        /// Calculates the quotient of two 64-bit signed integers and also returns the remainder in an output parameter (计算两个 32 位有符号整数的商，并通过输出参数返回余数).
        /// </summary>
        /// <param name="a">The dividend (被除数).</param>
        /// <param name="b">The divisor (除数).</param>
        /// <param name="result">When this method returns, contains the remainder (当此方法返回时，包含余数).</param>
        /// <returns>The quotient of the specified numbers (指定数字的商).</returns>
        /// <exception cref="DivideByZeroException"><paramref name="b"/> is zero.</exception>
        public static long DivRem(long a, long b, out long result) {
#if NETCOREAPP2_0_OR_GREATER || NETSTANDARD2_0_OR_GREATER || NET20_OR_GREATER
            return Math.DivRem(a, b, out result);
#else
            long div = a / b;
            result = a - (div * b);
            return div;
#endif // NETCOREAPP2_0_OR_GREATER || NETSTANDARD2_0_OR_GREATER || NET20_OR_GREATER
        }

        /// <summary>Produces the quotient and the remainder of two signed 8-bit numbers (生成两个 有符号8位数字 的商和余数).</summary>
        /// <param name="left">The dividend (被除数).</param>
        /// <param name="right">The divisor (除数).</param>
        /// <returns>The quotient and the remainder of the specified numbers (指定数字的商和余数).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (sbyte Quotient, sbyte Remainder) DivRem(sbyte left, sbyte right) {
#if NET6_0_OR_GREATER
            return Math.DivRem(left, right);
#else
            sbyte quotient = (sbyte)(left / right);
            return (quotient, (sbyte)(left - (quotient * right)));
#endif // NET6_0_OR_GREATER
        }

        /// <summary>Produces the quotient and the remainder of two unsigned 8-bit numbers (生成两个 无符号8位数字 的商和余数).</summary>
        /// <param name="left">The dividend (被除数).</param>
        /// <param name="right">The divisor (除数).</param>
        /// <returns>The quotient and the remainder of the specified numbers (指定数字的商和余数).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (byte Quotient, byte Remainder) DivRem(byte left, byte right) {
#if NET6_0_OR_GREATER
            return Math.DivRem(left, right);
#else
            byte quotient = (byte)(left / right);
            return (quotient, (byte)(left - (quotient * right)));
#endif // NET6_0_OR_GREATER
        }

        /// <summary>Produces the quotient and the remainder of two signed 16-bit numbers (生成两个 有符号16位数字 的商和余数).</summary>
        /// <param name="left">The dividend (被除数).</param>
        /// <param name="right">The divisor (除数).</param>
        /// <returns>The quotient and the remainder of the specified numbers (指定数字的商和余数).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (short Quotient, short Remainder) DivRem(short left, short right) {
#if NET6_0_OR_GREATER
            return Math.DivRem(left, right);
#else
            short quotient = (short)(left / right);
            return (quotient, (short)(left - (quotient * right)));
#endif // NET6_0_OR_GREATER
        }

        /// <summary>Produces the quotient and the remainder of two unsigned 16-bit numbers (生成两个 无符号16位数字 的商和余数).</summary>
        /// <param name="left">The dividend (被除数).</param>
        /// <param name="right">The divisor (除数).</param>
        /// <returns>The quotient and the remainder of the specified numbers (指定数字的商和余数).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (ushort Quotient, ushort Remainder) DivRem(ushort left, ushort right) {
#if NET6_0_OR_GREATER
            return Math.DivRem(left, right);
#else
            ushort quotient = (ushort)(left / right);
            return (quotient, (ushort)(left - (quotient * right)));
#endif // NET6_0_OR_GREATER
        }

        /// <summary>Produces the quotient and the remainder of two signed 32-bit numbers (生成两个 有符号32位数字 的商和余数).</summary>
        /// <param name="left">The dividend (被除数).</param>
        /// <param name="right">The divisor (除数).</param>
        /// <returns>The quotient and the remainder of the specified numbers (指定数字的商和余数).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (int Quotient, int Remainder) DivRem(int left, int right) {
#if NET6_0_OR_GREATER
            return Math.DivRem(left, right);
#else
            int quotient = left / right;
            return (quotient, left - (quotient * right));
#endif // NET6_0_OR_GREATER
        }

        /// <summary>Produces the quotient and the remainder of two unsigned 32-bit numbers (生成两个 无符号32位数字 的商和余数).</summary>
        /// <param name="left">The dividend (被除数).</param>
        /// <param name="right">The divisor (除数).</param>
        /// <returns>The quotient and the remainder of the specified numbers (指定数字的商和余数).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (uint Quotient, uint Remainder) DivRem(uint left, uint right) {
#if NET6_0_OR_GREATER
            return Math.DivRem(left, right);
#else
            uint quotient = left / right;
            return (quotient, left - (quotient * right));
#endif // NET6_0_OR_GREATER
        }

        /// <summary>Produces the quotient and the remainder of two signed 64-bit numbers (生成两个 有符号64位数字 的商和余数).</summary>
        /// <param name="left">The dividend (被除数).</param>
        /// <param name="right">The divisor (除数).</param>
        /// <returns>The quotient and the remainder of the specified numbers (指定数字的商和余数).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (long Quotient, long Remainder) DivRem(long left, long right) {
#if NET6_0_OR_GREATER
            return Math.DivRem(left, right);
#else
            long quotient = left / right;
            return (quotient, left - (quotient * right));
#endif // NET6_0_OR_GREATER
        }

        /// <summary>Produces the quotient and the remainder of two unsigned 64-bit numbers (生成两个 无符号64位数字 的商和余数).</summary>
        /// <param name="left">The dividend (被除数).</param>
        /// <param name="right">The divisor (除数).</param>
        /// <returns>The quotient and the remainder of the specified numbers (指定数字的商和余数).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (ulong Quotient, ulong Remainder) DivRem(ulong left, ulong right) {
#if NET6_0_OR_GREATER
            return Math.DivRem(left, right);
#else
            ulong quotient = left / right;
            return (quotient, left - (quotient * right));
#endif // NET6_0_OR_GREATER
        }

        /// <summary>Produces the quotient and the remainder of two signed native-size numbers (生成两个 有符号本机大小数字 的商和余数).</summary>
        /// <param name="left">The dividend (被除数).</param>
        /// <param name="right">The divisor (除数).</param>
        /// <returns>The quotient and the remainder of the specified numbers (指定数字的商和余数).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (nint Quotient, nint Remainder) DivRem(nint left, nint right) {
#if NET6_0_OR_GREATER
            return Math.DivRem(left, right);
#else
            nint quotient = left / right;
            return (quotient, left - (quotient * right));
#endif // NET6_0_OR_GREATER
        }

        /// <summary>Produces the quotient and the remainder of two unsigned native-size numbers (生成两个 无符号本机大小数字 的商和余数).</summary>
        /// <param name="left">The dividend (被除数).</param>
        /// <param name="right">The divisor (除数).</param>
        /// <returns>The quotient and the remainder of the specified numbers (指定数字的商和余数).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (nuint Quotient, nuint Remainder) DivRem(nuint left, nuint right) {
#if NET6_0_OR_GREATER
            return Math.DivRem(left, right);
#else
            nuint quotient = left / right;
            return (quotient, left - (quotient * right));
#endif // NET6_0_OR_GREATER
        }

    }
}
