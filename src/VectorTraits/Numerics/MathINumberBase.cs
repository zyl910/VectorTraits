using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Numerics {

    /// <summary>
    /// Math functions of <see cref="INumberBase{TSelf}"/> (INumberBase 的数学函数).
    /// </summary>
    /// <remarks>
    /// <para>Referenced from generic math (参考了泛型数学): https://learn.microsoft.com/en-us/dotnet/standard/generics/math</para>
    /// </remarks>
    /// <seealso cref="INumberBase{TSelf}"/>
    /// <seealso cref="BitMath"/>
    public static class MathINumberBase {

        // IsEvenInteger: Determines if a element represents an even integral number (确定元素是否为偶数整数).

        /// <inheritdoc cref="IsFinite(double)"/>
        /// <seealso cref="float.IsFinite"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsFinite(float value) {
#if NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
            return IsFinite_Bcl(value);
#else
            return IsFinite_Bit(value);
#endif // NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        }

#if NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        /// <inheritdoc cref="IsFinite(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsFinite_Bcl(float value) {
            return float.IsFinite(value);
        }
#endif // NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER

        /// <inheritdoc cref="IsFinite(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsFinite_Bit(float value) {
#pragma warning disable CS0618 // Type or member is obsolete
            const int exponentMask = ScalarConstants.Single_ExponentMask;
#pragma warning restore CS0618 // Type or member is obsolete
            int bits = MathBitConverter.SingleToInt32Bits(value);
            bool rt = exponentMask != (bits & exponentMask);
            return rt;
        }

        /// <summary>
        /// YIsFinite: Determines if a element is finite. It contains zero, subnormal, and normal. It does not contain infinity, NaN (确定元素是否为有限值. 它包含 零、次正规数、正规数. 它不含无穷大、非数).
        /// </summary>
        /// <param name="value">The value to be checked (要检查的值).</param>
        /// <returns>Return <c>true</c> if value is finite, otherwise is <c>false</c> (如果值是有限的，则返回 <c>true</c>，否则返回 <c>false</c>).</returns>
        /// <seealso cref="INumberBase{TSelf}.IsFinite(TSelf)"/>
        /// <seealso cref="double.IsFinite"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsFinite(double value) {
#if NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
            return IsFinite_Bcl(value);
#else
            return IsFinite_Bit(value);
#endif // NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        }

#if NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        /// <inheritdoc cref="IsFinite(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsFinite_Bcl(double value) {
            return double.IsFinite(value);
        }
#endif // NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER

        /// <inheritdoc cref="IsFinite(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsFinite_Bit(double value) {
#pragma warning disable CS0618 // Type or member is obsolete
            const long exponentMask = ScalarConstants.Double_ExponentMask;
#pragma warning restore CS0618 // Type or member is obsolete
            long bits = BitConverter.DoubleToInt64Bits(value);
            bool rt = exponentMask != (bits & exponentMask);
            return rt;
        }

    }
}
