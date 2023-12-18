using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Zyl.VectorTraits.Numerics;

namespace Zyl.VectorTraits {
    /// <summary>
    /// Provides constants and static methods for binary operations, and other common mathematical functions (为二进制运算和其他通用数学函数提供常数和静态方法).
    /// </summary>
    /// <seealso cref="BitConverter"/>
    /// <seealso cref="BitOperations"/>
    /// <seealso cref="Math"/>
    public abstract partial class BitMath: BitMathCore {

        // == My ==

        /// <summary>
        /// Returns the absolute value of a 8-bit signed integer (返回 8 位有符号整数的绝对值). No exception, <c>Abs(MinValue) := MinValue</c> .
        /// </summary>
        /// <param name="value">A number (一个数值).</param>
        /// <returns>Returns the absolute value (返回绝对值)</returns>
        /// <seealso cref="Math.Abs(sbyte)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte Abs(sbyte value) {
            return (sbyte)Abs((int)value);
        }

        /// <summary>
        /// Returns the absolute value of a 16-bit signed integer (返回 16 位有符号整数的绝对值). No exception, <c>Abs(MinValue) := MinValue</c> .
        /// </summary>
        /// <param name="value">A number (一个数值).</param>
        /// <returns>Returns the absolute value (返回绝对值)</returns>
        /// <seealso cref="Math.Abs(short)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short Abs(short value) {
            return (short)Abs((int)value);
        }

        /// <summary>
        /// Returns the absolute value of a 32-bit signed integer (返回 32 位有符号整数的绝对值). No exception, <c>Abs(MinValue) := MinValue</c> .
        /// </summary>
        /// <param name="value">A number (一个数值).</param>
        /// <returns>Returns the absolute value (返回绝对值)</returns>
        /// <seealso cref="Math.Abs(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Abs(int value) {
            int mask = value >> 31; //ToInt32Mask(0 > value);
            return (value ^ mask) - mask; // -x => (~x)+1 => (~x)-(-1) = (x^mask)-mask .
        }

        /// <summary>
        /// Returns the absolute value of a 64-bit signed integer (返回 64 位有符号整数的绝对值). No exception, <c>Abs(MinValue) := MinValue</c> .
        /// </summary>
        /// <param name="value">A number (一个数值).</param>
        /// <returns>Returns the absolute value (返回绝对值)</returns>
        /// <seealso cref="Math.Abs(long)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Abs(long value) {
            long mask = value >> 63; //ToInt32Mask(0 > value);
            return (value ^ mask) - mask; // -x => (~x)+1 => (~x)-(-1) = (x^mask)-mask .
        }

        /// <summary>
        /// Returns the absolute value of a native signed integer (返回本机有符号整数的绝对值). No exception, <c>Abs(MinValue) := MinValue</c> .
        /// </summary>
        /// <param name="value">A number (一个数值).</param>
        /// <returns>Returns the absolute value (返回绝对值)</returns>
        /// <seealso cref="Math.Abs(nint)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nint Abs(nint value) {
            nint mask = (nint)(((long)value) >> 63); //ToInt32Mask(0 > value);
            return (value ^ mask) - mask; // -x => (~x)+1 => (~x)-(-1) = (x^mask)-mask .
        }

        /// <summary>
        /// Produces the full product of signed big numbers (产生有符号大数字的完整乘积) (`w = u * v`). Use little endian to store (使用小端存储).
        /// </summary>
        /// <param name="w">The full product of the specified numbers (指定数字的完整乘积).</param>
        /// <param name="u">The first number to multiply (要相乘的第一个数).</param>
        /// <param name="v">The second number to multiply (要相乘的第二个数).</param>
        [CLSCompliant(false)]
        public static void BigNumMultiplySigned(Span<uint> w, ReadOnlySpan<uint> u, ReadOnlySpan<uint> v) {
            const int L = 32; // sizeof(uint) * 8;
            const int L2 = L * 2 - 1;
            int m = u.Length;
            int n = v.Length;
            ulong t, b;
            int i, j;
            BigNumMultiplyUnsigned(w, u, v);
            if ((int)u[m - 1] < 0) {
                b = 0;
                for (j = 0; j < n; j++) {
                    t = (ulong)w[j + m] - v[j] - b;
                    w[j + m] = (uint)t;
                    b = t >> L2;
                }
            }
            if ((int)v[n - 1] < 0) {
                b = 0;
                for (i = 0; i < m; i++) {
                    t = (ulong)w[i + n] - u[i] - b;
                    w[i + n] = (uint)t;
                    b = t >> L2;
                }
            }
        }

        /// <summary>
        /// Produces the full product of unsigned big numbers (产生无符号大数字的完整乘积) (`w = u * v`). Use little endian to store (使用小端存储).
        /// </summary>
        /// <param name="w">The full product of the specified numbers (指定数字的完整乘积).</param>
        /// <param name="u">The first number to multiply (要相乘的第一个数).</param>
        /// <param name="v">The second number to multiply (要相乘的第二个数).</param>
        [CLSCompliant(false)]
        public static void BigNumMultiplyUnsigned(Span<uint> w, ReadOnlySpan<uint> u, ReadOnlySpan<uint> v) {
            const int L = 32; // sizeof(uint) * 8;
            int m = u.Length;
            int n = v.Length;
            ulong k, t;
            int i, j;
            for (i = 0; i < m; i++) {
                w[i] = 0;
            }
            for (j = 0; j < n; j++) {
                k = 0;
                for (i = 0; i < m; i++) {
                    t = (ulong)u[i] * v[j] + w[i + j] + k;
                    w[i + j] = (uint)t; // 等价于 t & 0xFFFFFFFFU
                    k = t >> L;
                }
                w[m + j] = (uint)k;
            }
        }

        /// <summary>
        /// Produces the full product of two signed 64-bit numbers (生成两个有符号 64 位数的完整乘积).
        /// </summary>
        /// <param name="a">The first number to multiply (要相乘的第一个数).</param>
        /// <param name="b">The second number to multiply (要相乘的第二个数).</param>
        /// <param name="low">When this method returns, contains the low 64-bit of the product of the specified numbers (此方法返回时，包含指定数字乘积的低 64 位).</param>
        /// <returns>The high 64-bit of the product of the specified numbers (指定数字乘积的高 64 位).</returns>
        /// <seealso cref="Math.BigMul(long, long, out long)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long BigMul (long a, long b, out long low) {
#pragma warning disable CS0618 // Type or member is obsolete
#if NET5_0_OR_GREATER
            return Math.BigMul(a, b, out low);
            // JIT will call hardware-specific instructions to do the optimization. For example:
            // - x86: mulx rdx,r10,r9
#else
            return BigMul_Two(a, b, out low);
#endif // NET5_0_OR_GREATER
#pragma warning restore CS0618 // Type or member is obsolete
        }

        /// <summary>
        /// Produces the full product of two unsigned 64-bit numbers (生成两个无符号 64 位数的完整乘积).
        /// </summary>
        /// <param name="a">The first number to multiply (要相乘的第一个数).</param>
        /// <param name="b">The second number to multiply (要相乘的第二个数).</param>
        /// <param name="low">When this method returns, contains the low 64-bit of the product of the specified numbers (此方法返回时，包含指定数字乘积的低 64 位).</param>
        /// <returns>The high 64-bit of the product of the specified numbers (指定数字乘积的高 64 位).</returns>
        /// <seealso cref="Math.BigMul(ulong, ulong, out ulong)"/>
        [System.CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong BigMul (ulong a, ulong b, out ulong low) {
#pragma warning disable CS0618 // Type or member is obsolete
#if NET5_0_OR_GREATER
            return Math.BigMul(a, b, out low);
#else
            return BigMul_Two(a, b, out low);
#endif // NET5_0_OR_GREATER
#pragma warning restore CS0618 // Type or member is obsolete
        }

        /// <summary>
        /// Produces the full product of two signed 64-bit numbers - BigNum (生成两个有符号 64 位数的完整乘积 - 大数算法).
        /// </summary>
        /// <param name="a">The first number to multiply (要相乘的第一个数).</param>
        /// <param name="b">The second number to multiply (要相乘的第二个数).</param>
        /// <param name="low">When this method returns, contains the low 64-bit of the product of the specified numbers (此方法返回时，包含指定数字乘积的低 64 位).</param>
        /// <returns>The high 64-bit of the product of the specified numbers (指定数字乘积的高 64 位).</returns>
        /// <seealso cref="Math.BigMul(long, long, out long)"/>
        [Obsolete("This method is for testing purposes only. Please use BigMul instead.")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long BigMul_BigNum (long a, long b, out long low) {
            const int L = 32; // sizeof(uint) * 8;
            Span<uint> w = stackalloc uint[4];
            Span<uint> u = stackalloc uint[2];
            Span<uint> v = stackalloc uint[2];
            u[0] = (uint)a;
            u[1] = (uint)(a >> L);
            v[0] = (uint)b;
            v[1] = (uint)(b >> L);
            BigNumMultiplySigned(w, u, v);
            low = ((long)w[1] << L) | w[0];
            return ((long)w[3] << L) | w[2];
        }

        /// <summary>
        /// Produces the full product of two unsigned 64-bit numbers - BigNum (生成两个无符号 64 位数的完整乘积 - 大数算法).
        /// </summary>
        /// <param name="a">The first number to multiply (要相乘的第一个数).</param>
        /// <param name="b">The second number to multiply (要相乘的第二个数).</param>
        /// <param name="low">When this method returns, contains the low 64-bit of the product of the specified numbers (此方法返回时，包含指定数字乘积的低 64 位).</param>
        /// <returns>The high 64-bit of the product of the specified numbers (指定数字乘积的高 64 位).</returns>
        /// <seealso cref="Math.BigMul(ulong, ulong, out ulong)"/>
        [Obsolete("This method is for testing purposes only. Please use BigMul instead.")]
        [System.CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong BigMul_BigNum (ulong a, ulong b, out ulong low) {
            const int L = 32; // sizeof(uint) * 8;
            Span<uint> w = stackalloc uint[4];
            Span<uint> u = stackalloc uint[2];
            Span<uint> v = stackalloc uint[2];
            u[0] = (uint)a;
            u[1] = (uint)(a >> L);
            v[0] = (uint)b;
            v[1] = (uint)(b >> L);
            BigNumMultiplyUnsigned(w, u, v);
            low = ((ulong)w[1] << L) | w[0];
            return ((ulong)w[3] << L) | w[2];
        }

        /// <summary>
        /// Produces the full product of two signed 64-bit numbers - Two word (生成两个有符号 64 位数的完整乘积 - 双字).
        /// </summary>
        /// <param name="a">The first number to multiply (要相乘的第一个数).</param>
        /// <param name="  b">The second number to multiply (要相乘的第二个数).</param>
        /// <param name="low">When this method returns, contains the low 64-bit of the product of the specified numbers (此方法返回时，包含指定数字乘积的低 64 位).</param>
        /// <returns>The high 64-bit of the product of the specified numbers (指定数字乘积的高 64 位).</returns>
        /// <seealso cref="Math.BigMul(long, long, out long)"/>
        [Obsolete("This method is for testing purposes only. Please use BigMul instead.")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long BigMul_Two(long a, long b, out long low) {
            const int L = 32; // sizeof(uint) * 8;
            const long MASK = (1L << L) - 1;
            ulong u0, v0, w0;
            long u1, v1, w1, w2, t, high;
            long u = a;
            long v = b;
            u0 = (ulong)(u & MASK); u1 = u >> L;
            v0 = (ulong)(v & MASK); v1 = v >> L;
            // u*v = (u1*v1)<<(2*L) + (u0*v1)<<L + (u1*v0)<<L + u0*v0
            // Part1 = u0*v0
            w0 = u0 * v0;
            // Part2 = (u1*v0)<<L + Part1
            t = u1 * (long)v0 + (long)(w0 >> L);
            w1 = t & MASK;
            w2 = t >> L;
            // Part3 = (u0*v1)<<L + Part2
            w1 = (long)u0 * v1 + w1;
            // Part4 = (u1*v1)<<(2*L) + Part3
            low = (w1 << L) + (long)(w0 & MASK);
            high = (u1 * v1) + w2 + (w1 >> L);
            return high;
        }

        /// <summary>
        /// Produces the full product of two unsigned 64-bit numbers - Two word (生成两个无符号 64 位数的完整乘积 - 双字).
        /// </summary>
        /// <param name="u">The first number to multiply (要相乘的第一个数).</param>
        /// <param name="v">The second number to multiply (要相乘的第二个数).</param>
        /// <param name="low">When this method returns, contains the low 64-bit of the product of the specified numbers (此方法返回时，包含指定数字乘积的低 64 位).</param>
        /// <returns>The high 64-bit of the product of the specified numbers (指定数字乘积的高 64 位).</returns>
        /// <seealso cref="Math.BigMul(ulong, ulong, out ulong)"/>
        [Obsolete("This method is for testing purposes only. Please use BigMul instead.")]
        [System.CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong BigMul_Two(ulong u, ulong v, out ulong low) {
            const int L = 32; // sizeof(uint) * 8;
            const ulong MASK = (1L << L) - 1;
            ulong u0, v0, w0;
            ulong u1, v1, w1, w2, t, high;
            u0 = u & MASK; u1 = u >> L;
            v0 = v & MASK; v1 = v >> L;
            // u*v = (u1*v1)<<(2*L) + (u0*v1)<<L + (u1*v0)<<L + u0*v0
            // Part1 = u0*v0
            w0 = u0 * v0;
            // Part2 = (u1*v0)<<L + Part1
            t = u1 * v0 + (w0 >> L);
            w1 = t & MASK;
            w2 = t >> L;
            // Part3 = (u0*v1)<<L + Part2
            w1 = u0 * v1 + w1;
            // Part4 = (u1*v1)<<(2*L) + Part3
            low = (w1 << L) + (w0 & MASK);
            high = (u1 * v1) + w2 + (w1 >> L);
            return high;
        }

        /// <summary>
        /// Computes the product of two signed 64-bit numbers and returns the higher 64 bits (计算两个有符号 64 位数的乘积，并返回较高的64位).
        /// </summary>
        /// <param name="a">The first number to multiply (要相乘的第一个数).</param>
        /// <param name="b">The second number to multiply (要相乘的第二个数).</param>
        /// <returns>The high 64-bit of the product of the specified numbers (指定数字乘积的高 64 位).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long BigMulHigh(long a, long b) {
            const int L = 32; // sizeof(uint) * 8;
            const long MASK = (1L << L) - 1;
            ulong u0, v0, w0;
            long u1, v1, w1, w2, t, high;
            long u = a;
            long v = b;
            u0 = (ulong)(u & MASK); u1 = u >> L;
            v0 = (ulong)(v & MASK); v1 = v >> L;
            // u*v = (u1*v1)<<(2*L) + (u0*v1)<<L + (u1*v0)<<L + u0*v0
            // Part1 = u0*v0
            w0 = u0 * v0;
            // Part2 = (u1*v0)<<L + Part1
            t = u1 * (long)v0 + (long)(w0 >> L);
            w1 = t & MASK;
            w2 = t >> L;
            // Part3 = (u0*v1)<<L + Part2
            w1 = (long)u0 * v1 + w1;
            // Part4 = (u1*v1)<<(2*L) + Part3
            high = (u1 * v1) + w2 + (w1 >> L);
            return high;
        }

        /// <summary>
        /// Computes the product of two unsigned 64-bit numbers and returns the higher 64 bits (计算两个无符号 64 位数的乘积，并返回较高的64位).
        /// </summary>
        /// <param name="u">The first number to multiply (要相乘的第一个数).</param>
        /// <param name="v">The second number to multiply (要相乘的第二个数).</param>
        /// <returns>The high 64-bit of the product of the specified numbers (指定数字乘积的高 64 位).</returns>
        [System.CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong BigMulHigh(ulong u, ulong v) {
            const int L = 32; // sizeof(uint) * 8;
            const ulong MASK = (1L << L) - 1;
            ulong u0, v0, w0;
            ulong u1, v1, w1, w2, t, high;
            u0 = u & MASK; u1 = u >> L;
            v0 = v & MASK; v1 = v >> L;
            // u*v = (u1*v1)<<(2*L) + (u0*v1)<<L + (u1*v0)<<L + u0*v0
            // Part1 = u0*v0
            w0 = u0 * v0;
            // Part2 = (u1*v0)<<L + Part1
            t = u1 * v0 + (w0 >> L);
            w1 = t & MASK;
            w2 = t >> L;
            // Part3 = (u0*v1)<<L + Part2
            w1 = u0 * v1 + w1;
            // Part4 = (u1*v1)<<(2*L) + Part3
            high = (u1 * v1) + w2 + (w1 >> L);
            return high;
        }

        /// <summary>
        /// Computes the product of two signed 64-bit numbers and returns the lower 64 bits (计算两个有符号 64 位数的乘积，并返回较低的64位).
        /// </summary>
        /// <param name="a">The first number to multiply (要相乘的第一个数).</param>
        /// <param name="b">The second number to multiply (要相乘的第二个数).</param>
        /// <returns>The low 64-bit of the product of the specified numbers (指定数字乘积的低 64 位).</returns>
        [Obsolete("This method is for testing purposes only. Please use the multiplication operator(*) instead.")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long BigMulLow(long a, long b) {
            const int L = 32; // sizeof(uint) * 8;
            const long MASK = (1L << L) - 1;
            ulong u0, v0, w0;
            long u1, v1, w1, low;
            long u = a;
            long v = b;
            u0 = (ulong)(u & MASK); u1 = u >> L;
            v0 = (ulong)(v & MASK); v1 = v >> L;
            // u*v = (u1*v1)<<(2*L) + (u0*v1)<<L + (u1*v0)<<L + u0*v0
            // Part1 = u0*v0
            w0 = u0 * v0;
            // Part2 = (u1*v0)<<L + Part1
            //t = u1 * (long)v0 + (long)(w0 >> L);
            //w1 = t & MASK;
            w1 = u1 * (long)v0 + (long)(w0 >> L);
            // Part3 = (u0*v1)<<L + Part2
            w1 = (long)u0 * v1 + w1;
            low = (w1 << L) + (long)(w0 & MASK);
            return low;
        }

        /// <summary>
        /// Computes the product of two unsigned 64-bit numbers and returns the lower 64 bits (计算两个无符号 64 位数的乘积，并返回较低的64位).
        /// </summary>
        /// <param name="u">The first number to multiply (要相乘的第一个数).</param>
        /// <param name="v">The second number to multiply (要相乘的第二个数).</param>
        /// <returns>The low 64-bit of the product of the specified numbers (指定数字乘积的低 64 位).</returns>
        [Obsolete("This method is for testing purposes only. Please use the multiplication operator(*) instead.")]
        [System.CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong BigMulLow(ulong u, ulong v) {
            const int L = 32; // sizeof(uint) * 8;
            const ulong MASK = (1L << L) - 1;
            ulong u0, v0, w0;
            ulong u1, v1, w1, low;
            u0 = u & MASK; u1 = u >> L;
            v0 = v & MASK; v1 = v >> L;
            // u*v = (u1*v1)<<(2*L) + (u0*v1)<<L + (u1*v0)<<L + u0*v0
            // Part1 = u0*v0
            w0 = u0 * v0;
            // Part2 = (u1*v0)<<L + Part1
            //t = u1 * v0 + (w0 >> L);
            //w1 = t & MASK;
            w1 = u1 * v0 + (w0 >> L);
            // Part3 = (u0*v1)<<L + Part2
            w1 = u0 * v1 + w1;
            low = (w1 << L) + (w0 & MASK);
            return low;
        }

    }
}
