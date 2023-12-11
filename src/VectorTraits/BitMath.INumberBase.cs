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

    }
}
