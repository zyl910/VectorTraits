using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zyl.VectorTraits.Numerics {
    using static BitMathCore;

    /// <summary>
    /// Math functions of <see cref="IRootFunctions{TSelf}"/> (IRootFunctions 的数学函数).
    /// </summary>
    /// <remarks>
    /// <para>Referenced from generic math (参考了泛型数学): https://learn.microsoft.com/en-us/dotnet/standard/generics/math</para>
    /// </remarks>
    /// <seealso cref="IRootFunctions{TSelf}"/>
    /// <seealso cref="BitMath"/>
    public static class MathIRootFunctions {

        /// <inheritdoc cref="Sqrt(double)"/>
        /// <seealso cref="MathF.Sqrt"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Sqrt(float x) {
#if NETCOREAPP2_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
            return MathF.Sqrt(x);
#else
            return (float)Math.Sqrt(x);
#endif // NETCOREAPP2_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        }

        /// <summary>
        /// Computes the square-root of a value (计算值的平方根).
        /// Mnemonic: `Sqrt(x) = Pow(x, 1.0/2)`. When x is less than 0, floating-point types return NaN, integer types return 0.
        /// </summary>
        /// <param name="x">The value whose square-root is to be computed (要计算其平方根的值).</param>
        /// <returns>The square-root of <paramref name="x"/> (<paramref name="x"/>的平方根).</returns>
        /// <seealso cref="IRootFunctions{TSelf}.Sqrt(TSelf)"/>
        /// <seealso cref="Math.Sqrt"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Sqrt(double x) {
            return Math.Sqrt(x);
        }

        /// <inheritdoc cref="Sqrt(double)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte Sqrt(sbyte x) {
            return ConditionalSelect(x < 0, (sbyte)0, (sbyte)Sqrt((byte)x));
        }

        /// <inheritdoc cref="Sqrt(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte Sqrt(byte x) {
            return (byte)Sqrt((float)x);
        }

        /// <inheritdoc cref="Sqrt(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short Sqrt(short x) {
            return ConditionalSelect(x < 0, (short)0, (short)Sqrt((ushort)x));
        }

        /// <inheritdoc cref="Sqrt(double)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort Sqrt(ushort x) {
            return (ushort)Sqrt((float)x);
        }

        /// <inheritdoc cref="Sqrt(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sqrt(int x) {
            return ConditionalSelect(x < 0, (int)0, (int)Sqrt((uint)x));
        }

        /// <inheritdoc cref="Sqrt(double)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Sqrt(uint x) {
            return (uint)Sqrt((double)x);
        }

        /// <inheritdoc cref="Sqrt(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Sqrt(long x) {
            return ConditionalSelect(x < 0, (long)0, (long)Sqrt((ulong)x));
        }

        /// <inheritdoc cref="Sqrt(double)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong Sqrt(ulong x) {
            return (ulong)Sqrt((double)x);
        }


    }
}
