using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using Zyl.VectorTraits.Numerics;

namespace Zyl.VectorTraits {
    // IBinaryInteger: https://learn.microsoft.com/zh-cn/dotnet/api/system.numerics.ibinaryinteger-1
    // Referenced from generic math (参考了泛型数学): https://learn.microsoft.com/en-us/dotnet/standard/generics/math
    partial class BitMath {

        /// <inheritdoc cref="MathIBinaryInteger.DivRem(int, int, out int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int DivRem(int a, int b, out int result) {
            return MathIBinaryInteger.DivRem(a, b, out result);
        }

        /// <inheritdoc cref="MathIBinaryInteger.DivRem(long, long, out long)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long DivRem(long a, long b, out long result) {
            return MathIBinaryInteger.DivRem(a, b, out result);
        }

        /// <inheritdoc cref="MathIBinaryInteger.DivRem(sbyte, sbyte)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (sbyte Quotient, sbyte Remainder) DivRem(sbyte left, sbyte right) {
            return MathIBinaryInteger.DivRem(left, right);
        }

        /// <inheritdoc cref="MathIBinaryInteger.DivRem(byte, byte)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (byte Quotient, byte Remainder) DivRem(byte left, byte right) {
            return MathIBinaryInteger.DivRem(left, right);
        }

        /// <inheritdoc cref="MathIBinaryInteger.DivRem(short, short)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (short Quotient, short Remainder) DivRem(short left, short right) {
            return MathIBinaryInteger.DivRem(left, right);
        }

        /// <inheritdoc cref="MathIBinaryInteger.DivRem(ushort, ushort)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (ushort Quotient, ushort Remainder) DivRem(ushort left, ushort right) {
            return MathIBinaryInteger.DivRem(left, right);
        }

        /// <inheritdoc cref="MathIBinaryInteger.DivRem(int, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (int Quotient, int Remainder) DivRem(int left, int right) {
            return MathIBinaryInteger.DivRem(left, right);
        }

        /// <inheritdoc cref="MathIBinaryInteger.DivRem(uint, uint)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (uint Quotient, uint Remainder) DivRem(uint left, uint right) {
            return MathIBinaryInteger.DivRem(left, right);
        }

        /// <inheritdoc cref="MathIBinaryInteger.DivRem(long, long)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (long Quotient, long Remainder) DivRem(long left, long right) {
            return MathIBinaryInteger.DivRem(left, right);
        }

        /// <inheritdoc cref="MathIBinaryInteger.DivRem(ulong, ulong)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (ulong Quotient, ulong Remainder) DivRem(ulong left, ulong right) {
            return MathIBinaryInteger.DivRem(left, right);
        }

    }
}
