﻿using System;
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
        /// <inheritdoc cref="IsFinite(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsFinite_Bcl(float value) {
            return float.IsFinite(value);
        }

        /// <inheritdoc cref="IsFinite(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsFinite_Bcl(double value) {
            return double.IsFinite(value);
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
        /// <inheritdoc cref="IsInfinity(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInfinity_Bcl(float value) {
            return float.IsInfinity(value);
        }

        /// <inheritdoc cref="IsInfinity(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInfinity_Bcl(double value) {
            return double.IsInfinity(value);
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
        /// <inheritdoc cref="IsInfinityOrNaN(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInfinityOrNaN_Bcl(float value) {
            return !float.IsFinite(value);
        }

        /// <inheritdoc cref="IsInfinityOrNaN(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInfinityOrNaN_Bcl(double value) {
            return !double.IsFinite(value);
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
#if NET7_0_OR_GREATER
            return IsInteger_Bcl(value);
#else
            return IsInteger_Bit(value);
#endif // NET7_0_OR_GREATER
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
#if NET7_0_OR_GREATER
            return IsInteger_Bcl(value);
#else
            return IsInteger_Bit(value);
#endif // NET7_0_OR_GREATER
        }

#if NET7_0_OR_GREATER
        /// <inheritdoc cref="IsInteger(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInteger_Bcl(float value) {
            return float.IsInteger(value);
        }

        /// <inheritdoc cref="IsInteger(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInteger_Bcl(double value) {
            return double.IsInteger(value);
        }
#endif // NET7_0_OR_GREATER

        /// <inheritdoc cref="IsInteger(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInteger_Bit(float value) {
            float valueTrun = MathIFloatingPoint.Truncate(value);
            return IsFinite(value) && (value == valueTrun);
        }

        /// <inheritdoc cref="IsInteger(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInteger_Bit(double value) {
            double valueTrun = Math.Truncate(value);
            return IsFinite(value) && (value == valueTrun);
        }


        /// <inheritdoc cref="IsNaN(double)"/>
        /// <seealso cref="float.IsNaN"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNaN(float value) {
            return IsNaN_Bcl(value);
        }

        /// <summary>
        /// Determines if a element is NaN (确定元素是否为非数).
        /// </summary>
        /// <param name="value">The value to be checked (要检查的值).</param>
        /// <returns>Return <c>true</c> if value is NaN, otherwise is <c>false</c> (如果值是非数，则返回 <c>true</c>，否则返回 <c>false</c>).</returns>
        /// <seealso cref="INumberBase{TSelf}.IsNaN(TSelf)"/>
        /// <seealso cref="double.IsNaN"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNaN(double value) {
            return IsNaN_Bcl(value);
        }

        /// <inheritdoc cref="IsNaN(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNaN_Bcl(float value) {
            return float.IsNaN(value);
        }

        /// <inheritdoc cref="IsNaN(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNaN_Bcl(double value) {
            return double.IsNaN(value);
        }

        /// <inheritdoc cref="IsNaN(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNaN_Bit(float value) {
#pragma warning disable CS1718
            return value != value;
#pragma warning restore CS1718
        }

        /// <inheritdoc cref="IsNaN(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNaN_Bit(double value) {
            // A NaN will never equal itself so this is an
            // easy and efficient way to check for NaN.
#pragma warning disable CS1718
            return value != value;
#pragma warning restore CS1718
        }


        /// <inheritdoc cref="IsNegative(double)"/>
        /// <seealso cref="float.IsNegative"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNegative(float value) {
#if NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
            return IsNegative_Bcl(value);
#else
            return IsNegative_Bit(value);
#endif // NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        }

        /// <summary>
        /// Determines if a element represents a negative number (确定元素是否为负数).
        /// </summary>
        /// <param name="value">The value to be checked (要检查的值).</param>
        /// <returns>Return <c>true</c> if value represents negative zero or a negative real number, otherwise is <c>false</c> (如果值表示负零或负实数，则返回 <c>true</c>，否则返回 <c>false</c>).</returns>
        /// <seealso cref="INumberBase{TSelf}.IsNegative(TSelf)"/>
        /// <seealso cref="double.IsNegative"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNegative(double value) {
#if NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
            return IsNegative_Bcl(value);
#else
            return IsNegative_Bit(value);
#endif // NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        }

        /// <inheritdoc cref="IsNegative(double)"/>
        /// <seealso cref="sbyte.IsNegative"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNegative(sbyte value) {
#if NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
            return IsNegative_Bcl(value);
#else
            return IsNegative_Bit(value);
#endif // NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        }

        /// <inheritdoc cref="IsNegative(double)"/>
        /// <seealso cref="short.IsNegative"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNegative(short value) {
#if NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
            return IsNegative_Bcl(value);
#else
            return IsNegative_Bit(value);
#endif // NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        }

        /// <inheritdoc cref="IsNegative(double)"/>
        /// <seealso cref="int.IsNegative"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNegative(int value) {
#if NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
            return IsNegative_Bcl(value);
#else
            return IsNegative_Bit(value);
#endif // NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        }

        /// <inheritdoc cref="IsNegative(double)"/>
        /// <seealso cref="long.IsNegative"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNegative(long value) {
#if NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
            return IsNegative_Bcl(value);
#else
            return IsNegative_Bit(value);
#endif // NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        }

#if NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        /// <inheritdoc cref="IsNegative(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNegative_Bcl(float value) {
            return float.IsNegative(value);
        }

        /// <inheritdoc cref="IsNegative(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNegative_Bcl(double value) {
            return double.IsNegative(value);
        }

        /// <inheritdoc cref="IsNegative(sbyte)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNegative_Bcl(sbyte value) {
#if NET7_0_OR_GREATER
            return sbyte.IsNegative(value);
#else
            return IsNegative_Bit(value);
#endif // NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IsNegative(short)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNegative_Bcl(short value) {
#if NET7_0_OR_GREATER
            return short.IsNegative(value);
#else
            return IsNegative_Bit(value);
#endif // NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IsNegative(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNegative_Bcl(int value) {
#if NET7_0_OR_GREATER
            return int.IsNegative(value);
#else
            return IsNegative_Bit(value);
#endif // NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IsNegative(long)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNegative_Bcl(long value) {
#if NET7_0_OR_GREATER
            return long.IsNegative(value);
#else
            return IsNegative_Bit(value);
#endif // NET7_0_OR_GREATER
        }
#endif // NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER

        /// <inheritdoc cref="IsNegative(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNegative_Bit(float value) {
            return MathBitConverter.SingleToInt32Bits(value) < 0;
        }

        /// <inheritdoc cref="IsNegative(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNegative_Bit(double value) {
            return BitConverter.DoubleToInt64Bits(value) < 0;
        }

        /// <inheritdoc cref="IsNegative(sbyte)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNegative_Bit(sbyte value) {
            return value < 0;
        }

        /// <inheritdoc cref="IsNegative(short)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNegative_Bit(short value) {
            return value < 0;
        }

        /// <inheritdoc cref="IsNegative(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNegative_Bit(int value) {
            return value < 0;
        }

        /// <inheritdoc cref="IsNegative(long)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNegative_Bit(long value) {
            return value < 0;
        }


        /// <inheritdoc cref="IsNegativeInfinity(double)"/>
        /// <seealso cref="float.IsNegativeInfinity"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNegativeInfinity(float value) {
            return IsNegativeInfinity_Bcl(value);
        }

        /// <summary>
        /// Determines if a element is negative infinity (确定元素是否为负无穷大).
        /// </summary>
        /// <param name="value">The value to be checked (要检查的值).</param>
        /// <returns>Return <c>true</c> if value is negative infinity, otherwise is <c>false</c> (如果值是负无穷大，则返回 <c>true</c>，否则返回 <c>false</c>).</returns>
        /// <seealso cref="INumberBase{TSelf}.IsNegativeInfinity(TSelf)"/>
        /// <seealso cref="double.IsNegativeInfinity"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNegativeInfinity(double value) {
            return IsNegativeInfinity_Bcl(value);
        }

        /// <inheritdoc cref="IsNegativeInfinity(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNegativeInfinity_Bcl(float value) {
            return float.IsNegativeInfinity(value);
        }

        /// <inheritdoc cref="IsNegativeInfinity(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNegativeInfinity_Bcl(double value) {
            return double.IsNegativeInfinity(value);
        }

        /// <inheritdoc cref="IsNegativeInfinity(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNegativeInfinity_Bit(float value) {
            return value == float.NegativeInfinity;
        }

        /// <inheritdoc cref="IsNegativeInfinity(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNegativeInfinity_Bit(double value) {
            return value == double.NegativeInfinity;
        }


        /// <inheritdoc cref="IsNormal(double)"/>
        /// <seealso cref="float.IsNormal"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNormal(float value) {
#if NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
            return IsNormal_Bcl(value);
#else
            return IsNormal_Bit(value);
#endif // NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        }

        /// <summary>
        /// Determines if a element is normal (确定元素是否为正规数).
        /// </summary>
        /// <param name="value">The value to be checked (要检查的值).</param>
        /// <returns>Return <c>true</c> if value is normal, otherwise is <c>false</c> (如果值是正规数，则返回 <c>true</c>，否则返回 <c>false</c>).</returns>
        /// <seealso cref="INumberBase{TSelf}.IsNormal(TSelf)"/>
        /// <seealso cref="double.IsNormal"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNormal(double value) {
#if NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
            return IsNormal_Bcl(value);
#else
            return IsNormal_Bit(value);
#endif // NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        }

#if NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        /// <inheritdoc cref="IsNormal(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNormal_Bcl(float value) {
            return float.IsNormal(value);
        }

        /// <inheritdoc cref="IsNormal(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNormal_Bcl(double value) {
            return double.IsNormal(value);
        }
#endif // NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER

        /// <inheritdoc cref="IsNormal(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNormal_Bit(float value) {
#pragma warning disable CS0618 // Type or member is obsolete
            const int exponentMask = ScalarConstants.Single_ExponentMask;
#pragma warning restore CS0618 // Type or member is obsolete
            int bits = MathBitConverter.SingleToInt32Bits(value);
            bits &= exponentMask;
            bool rt = (bits > 0) && (exponentMask > bits);
            return rt;
        }

        /// <inheritdoc cref="IsNormal(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNormal_Bit(double value) {
#pragma warning disable CS0618 // Type or member is obsolete
            const long exponentMask = ScalarConstants.Double_ExponentMask;
#pragma warning restore CS0618 // Type or member is obsolete
            long bits = BitConverter.DoubleToInt64Bits(value);
            bits &= exponentMask;
            bool rt = (bits > 0) && (exponentMask > bits);
            return rt;
        }


    }
}
