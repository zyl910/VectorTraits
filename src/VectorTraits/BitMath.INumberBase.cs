using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Zyl.VectorTraits.Numerics;

namespace Zyl.VectorTraits {
    // INumberBase: https://learn.microsoft.com/en-us/dotnet/api/system.numerics.inumberbase-1?view=net-8.0
    // Referenced from generic math (参考了泛型数学): https://learn.microsoft.com/en-us/dotnet/standard/generics/math
    partial class BitMath {

        /// <inheritdoc cref="MathINumberBase.IsFinite(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsFinite(float value) {
            return MathINumberBase.IsFinite(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsFinite(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsFinite(double value) {
            return MathINumberBase.IsFinite(value);
        }


        /// <inheritdoc cref="MathINumberBase.IsInfinity(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInfinity(float value) {
            return MathINumberBase.IsInfinity(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsInfinity(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInfinity(double value) {
            return MathINumberBase.IsInfinity(value);
        }


        /// <inheritdoc cref="MathINumberBase.IsInfinityOrNaN(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInfinityOrNaN(float value) {
            return MathINumberBase.IsInfinityOrNaN(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsInfinityOrNaN(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInfinityOrNaN(double value) {
            return MathINumberBase.IsInfinityOrNaN(value);
        }


        /// <inheritdoc cref="MathINumberBase.IsInteger(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInteger(float value) {
            return MathINumberBase.IsInteger(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsInteger(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInteger(double value) {
            return MathINumberBase.IsInteger(value);
        }


        /// <inheritdoc cref="MathINumberBase.IsNaN(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNaN(float value) {
            return MathINumberBase.IsNaN(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsNaN(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNaN(double value) {
            return MathINumberBase.IsNaN(value);
        }


        /// <inheritdoc cref="MathINumberBase.IsNegative(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNegative(float value) {
            return MathINumberBase.IsNegative(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsNegative(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNegative(double value) {
            return MathINumberBase.IsNegative(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsNegative(sbyte)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNegative(sbyte value) {
            return MathINumberBase.IsNegative(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsNegative(short)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNegative(short value) {
            return MathINumberBase.IsNegative(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsNegative(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNegative(int value) {
            return MathINumberBase.IsNegative(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsNegative(long)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNegative(long value) {
            return MathINumberBase.IsNegative(value);
        }


        /// <inheritdoc cref="MathINumberBase.IsNegativeInfinity(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNegativeInfinity(float value) {
            return MathINumberBase.IsNegativeInfinity(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsNegativeInfinity(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNegativeInfinity(double value) {
            return MathINumberBase.IsNegativeInfinity(value);
        }


        /// <inheritdoc cref="MathINumberBase.IsNormal(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNormal(float value) {
            return MathINumberBase.IsNormal(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsNormal(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNormal(double value) {
            return MathINumberBase.IsNormal(value);
        }

    }
}
