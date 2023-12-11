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
        /// Determines if a element is finite. It contains zero, subnormal, and normal. It does not contain infinity, NaN (确定元素是否为有限值. 它包含 零、次正规数、正规数. 它不含无穷大、非数).
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


        /// <inheritdoc cref="IsInfinity(double)"/>
        /// <seealso cref="float.IsInfinity"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInfinity(float value) {
#if NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
            return IsInfinity_Bcl(value);
#else
            return IsInfinity_Bit(value);
#endif // NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        }

#if NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        /// <inheritdoc cref="IsInfinity(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInfinity_Bcl(float value) {
            return float.IsInfinity(value);
        }
#endif // NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER

        /// <inheritdoc cref="IsInfinity(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInfinity_Bit(float value) {
#pragma warning disable CS0618 // Type or member is obsolete
            const int exponentMask = ScalarConstants.Single_ExponentMask;
            const int nonSignMask = ScalarConstants.Single_NonSignMask;
#pragma warning restore CS0618 // Type or member is obsolete
            int bits = MathBitConverter.SingleToInt32Bits(value);
            bool rt = (bits & nonSignMask) == exponentMask;
            return rt;
        }

        /// <summary>
        /// Determines if a element is negative or positive infinite (确定元素是否为负数或正数的无穷大).
        /// </summary>
        /// <param name="value">The value to be checked (要检查的值).</param>
        /// <returns>Return <c>true</c> if value is infinite, otherwise is <c>false</c> (如果值是无穷大，则返回 <c>true</c>，否则返回 <c>false</c>).</returns>
        /// <seealso cref="INumberBase{TSelf}.IsInfinity(TSelf)"/>
        /// <seealso cref="double.IsInfinity"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInfinity(double value) {
#if NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
            return IsInfinity_Bcl(value);
#else
            return IsInfinity_Bit(value);
#endif // NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        }

#if NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        /// <inheritdoc cref="IsInfinity(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInfinity_Bcl(double value) {
            return double.IsInfinity(value);
        }
#endif // NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER

        /// <inheritdoc cref="IsInfinity(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInfinity_Bit(double value) {
#pragma warning disable CS0618 // Type or member is obsolete
            const long exponentMask = ScalarConstants.Double_ExponentMask;
            const long nonSignMask = ScalarConstants.Double_NonSignMask;
#pragma warning restore CS0618 // Type or member is obsolete
            long bits = BitConverter.DoubleToInt64Bits(value);
            bool rt = (bits & nonSignMask) == exponentMask;
            return rt;
        }


        /// <inheritdoc cref="IsInfinityOrNaN(double)"/>
        /// <seealso cref="float.IsInfinityOrNaN"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInfinityOrNaN(float value) {
#if NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
            return IsInfinityOrNaN_Bcl(value);
#else
            return IsInfinityOrNaN_Bit(value);
#endif // NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        }

#if NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        /// <inheritdoc cref="IsInfinityOrNaN(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInfinityOrNaN_Bcl(float value) {
            return !float.IsFinite(value);
        }
#endif // NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER

        /// <inheritdoc cref="IsInfinityOrNaN(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInfinityOrNaN_Bit(float value) {
#pragma warning disable CS0618 // Type or member is obsolete
            const int exponentMask = ScalarConstants.Single_ExponentMask;
#pragma warning restore CS0618 // Type or member is obsolete
            int bits = MathBitConverter.SingleToInt32Bits(value);
            bool rt = exponentMask == (bits & exponentMask);
            return rt;
        }

        /// <summary>
        /// Determines if a element is infinite or NaN (确定元素是否为无穷大或非数).
        /// </summary>
        /// <param name="value">The value to be checked (要检查的值).</param>
        /// <returns>Return <c>true</c> if value is infinite or NaN, otherwise is <c>false</c> (如果值是无穷大或非数，则返回 <c>true</c>，否则返回 <c>false</c>).</returns>
        /// <seealso cref="INumberBase{TSelf}.IsFinite(TSelf)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInfinityOrNaN(double value) {
#if NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
            return IsInfinityOrNaN_Bcl(value);
#else
            return IsInfinityOrNaN_Bit(value);
#endif // NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        }

#if NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        /// <inheritdoc cref="IsInfinityOrNaN(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInfinityOrNaN_Bcl(double value) {
            return !double.IsFinite(value);
        }
#endif // NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER

        /// <inheritdoc cref="IsInfinityOrNaN(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInfinityOrNaN_Bit(double value) {
#pragma warning disable CS0618 // Type or member is obsolete
            const long exponentMask = ScalarConstants.Double_ExponentMask;
#pragma warning restore CS0618 // Type or member is obsolete
            long bits = BitConverter.DoubleToInt64Bits(value);
            bool rt = exponentMask == (bits & exponentMask);
            return rt;
        }


        /// <inheritdoc cref="IsInteger(double)"/>
        /// <seealso cref="float.IsInteger"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInteger(float value) {
//#if NET7_0_OR_GREATER
//            return IsInteger_Bcl(value);
//#else
//            return IsInteger_Basic(value);
//#endif // NET7_0_OR_GREATER
            return IsInteger_Bit(value);
        }

        /// <inheritdoc cref="IsInteger(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInteger_Basic(float value) {
            float m = MathIFloatingPoint.Truncate(value);
            return IsFinite(value) && (value == m);
        }

#if NET7_0_OR_GREATER
        /// <inheritdoc cref="IsInteger(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInteger_Bcl(float value) {
            return float.IsInteger(value);
        }
#endif // NET7_0_OR_GREATER

        /// <inheritdoc cref="IsInteger(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInteger_Bit(float value) {
            return IsInteger_Basic(value);
        }

        /// <summary>
        /// Determines if a element represents an integral number (确定元素是否为整数).
        /// </summary>
        /// <param name="value">The value to be checked (要检查的值).</param>
        /// <returns>Return <c>true</c> if value is integral number, otherwise is <c>false</c> (如果值是整数，则返回 <c>true</c>，否则返回 <c>false</c>).</returns>
        /// <seealso cref="INumberBase{TSelf}.IsInteger(TSelf)"/>
        /// <seealso cref="double.IsInteger"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInteger(double value) {
//#if NET7_0_OR_GREATER
//            return IsInteger_Bcl(value);
//#else
//            return IsInteger_Basic(value);
//#endif // NET7_0_OR_GREATER
            return IsInteger_Bit(value);
        }

        /// <inheritdoc cref="IsInteger(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInteger_Basic(double value) {
            double m = Math.Truncate(value);
            return IsFinite(value) && (value == m);
        }

#if NET7_0_OR_GREATER
        /// <inheritdoc cref="IsInteger(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInteger_Bcl(double value) {
            return double.IsInteger(value);
        }
#endif // NET7_0_OR_GREATER

        /// <inheritdoc cref="IsInteger(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInteger_Bit(double value) {
            return IsInteger_Basic(value);
        }


    }
}
