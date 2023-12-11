using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Numerics {

    /// <summary>
    /// Math functions of <see cref="IFloatingPoint{TSelf}"/> (IFloatingPoint 的数学函数).
    /// </summary>
    /// <remarks>
    /// <para>Referenced from generic math (参考了泛型数学): https://learn.microsoft.com/en-us/dotnet/standard/generics/math</para>
    /// </remarks>
    /// <seealso cref="IFloatingPoint{TSelf}"/>
    /// <seealso cref="BitMath"/>
    public static class MathIFloatingPoint {

        /// <inheritdoc cref="Truncate(double)"/>
        /// <seealso cref="MathF.Truncate"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Truncate(float x) {
#if NETCOREAPP2_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
            return MathF.Truncate(x);
#else
            return (float)Math.Truncate(x);
#endif // NETCOREAPP2_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        }

        /// <summary>
        /// Computes the round to zero of value (计算值的向零舍入). It is also known as truncate (它也被称作截断取整). See more: <see cref="MidpointRounding.ToZero"/>.
        /// </summary>
        /// <param name="x">The value to truncate (要截断的值).</param>
        /// <returns>Returns the truncated value (返回截断后的值).</returns>
        /// <seealso cref="IFloatingPoint{TSelf}.Truncate(TSelf)"/>
        /// <seealso cref="Math.Truncate(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Truncate(double x) {
            return Math.Truncate(x);
        }

    }
}
