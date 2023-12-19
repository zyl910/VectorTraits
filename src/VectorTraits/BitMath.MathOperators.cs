using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Zyl.VectorTraits.Numerics;

namespace Zyl.VectorTraits {
    // MathOperators
    partial class BitMath {

        /// <inheritdoc cref="MathOperators.BigMul(long, long, out long)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long BigMul(long a, long b, out long low) {
            return MathOperators.BigMul(a, b, out low);
        }

        /// <inheritdoc cref="MathOperators.BigMul(ulong, ulong, out ulong)"/>
        [System.CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong BigMul(ulong a, ulong b, out ulong low) {
            return MathOperators.BigMul(a, b, out low);
        }

        /// <inheritdoc cref="MathOperators.BigMul_BigNum(long, long, out long)"/>
        [Obsolete("This method is for testing purposes only. Please use BigMul instead.")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long BigMul_BigNum(long a, long b, out long low) {
            return MathOperators.BigMul_BigNum(a, b, out low);
        }

        /// <inheritdoc cref="MathOperators.BigMul_BigNum(ulong, ulong, out ulong)"/>
        [Obsolete("This method is for testing purposes only. Please use BigMul instead.")]
        [System.CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong BigMul_BigNum(ulong a, ulong b, out ulong low) {
            return MathOperators.BigMul_BigNum(a, b, out low);
        }

        /// <inheritdoc cref="MathOperators.BigMul_Two(long, long, out long)"/>
        [Obsolete("This method is for testing purposes only. Please use BigMul instead.")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long BigMul_Two(long a, long b, out long low) {
            return MathOperators.BigMul_Two(a, b, out low);
        }

        /// <inheritdoc cref="MathOperators.BigMul_Two(ulong, ulong, out ulong)"/>
        [Obsolete("This method is for testing purposes only. Please use BigMul instead.")]
        [System.CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong BigMul_Two(ulong u, ulong v, out ulong low) {
            return MathOperators.BigMul_Two(u, v, out low);
        }

        /// <inheritdoc cref="MathOperators.BigMulHigh(long, long)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long BigMulHigh(long a, long b) {
            return MathOperators.BigMulHigh(a, b);
        }

        /// <inheritdoc cref="MathOperators.BigMulHigh(ulong, ulong)"/>
        [System.CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong BigMulHigh(ulong u, ulong v) {
            return MathOperators.BigMulHigh(u, v);
        }

        /// <inheritdoc cref="MathOperators.BigMulLow(long, long)"/>
        [Obsolete("This method is for testing purposes only. Please use the multiplication operator(*) instead.")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long BigMulLow(long a, long b) {
            return MathOperators.BigMulLow(a, b);
        }

        /// <inheritdoc cref="MathOperators.BigMulLow(ulong, ulong)"/>
        [Obsolete("This method is for testing purposes only. Please use the multiplication operator(*) instead.")]
        [System.CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong BigMulLow(ulong u, ulong v) {
            return MathOperators.BigMulLow(u, v);
        }


        /// <inheritdoc cref="MathOperators.BigNumMultiplySigned"/>
        [CLSCompliant(false)]
        public static void BigNumMultiplySigned(Span<uint> w, ReadOnlySpan<uint> u, ReadOnlySpan<uint> v) {
            MathOperators.BigNumMultiplySigned(w, u, v);
        }

        /// <inheritdoc cref="MathOperators.BigNumMultiplyUnsigned"/>
        [CLSCompliant(false)]
        public static void BigNumMultiplyUnsigned(Span<uint> w, ReadOnlySpan<uint> u, ReadOnlySpan<uint> v) {
            MathOperators.BigNumMultiplySigned(w, u, v);
        }

    }
}
