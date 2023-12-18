using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Zyl.VectorTraits.Numerics;

namespace Zyl.VectorTraits {
    // INumberBase: https://learn.microsoft.com/en-us/dotnet/api/system.numerics.inumberbase-1
    // Referenced from generic math (参考了泛型数学): https://learn.microsoft.com/en-us/dotnet/standard/generics/math
    partial class BitMath {

        /// <inheritdoc cref="MathINumberBase.Abs(sbyte)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte Abs(sbyte value) {
            return MathINumberBase.Abs(value);
        }

        /// <inheritdoc cref="MathINumberBase.Abs(short)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short Abs(short value) {
            return MathINumberBase.Abs(value);
        }

        /// <inheritdoc cref="MathINumberBase.Abs(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Abs(int value) {
            return MathINumberBase.Abs(value);
        }

        /// <inheritdoc cref="MathINumberBase.Abs(long)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Abs(long value) {
            return MathINumberBase.Abs(value);
        }

        /// <inheritdoc cref="MathINumberBase.Abs(nint)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nint Abs(nint value) {
            return MathINumberBase.Abs(value);
        }


        /// <inheritdoc cref="MathINumberBase.IsEvenInteger(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEvenInteger(float value) {
            return MathINumberBase.IsEvenInteger(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsEvenInteger(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEvenInteger(double value) {
            return MathINumberBase.IsEvenInteger(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsEvenInteger(sbyte)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEvenInteger(sbyte value) {
            return MathINumberBase.IsEvenInteger(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsEvenInteger(byte)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEvenInteger(byte value) {
            return MathINumberBase.IsEvenInteger(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsEvenInteger(short)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEvenInteger(short value) {
            return MathINumberBase.IsEvenInteger(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsEvenInteger(ushort)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEvenInteger(ushort value) {
            return MathINumberBase.IsEvenInteger(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsEvenInteger(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEvenInteger(int value) {
            return MathINumberBase.IsEvenInteger(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsEvenInteger(uint)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEvenInteger(uint value) {
            return MathINumberBase.IsEvenInteger(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsEvenInteger(long)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEvenInteger(long value) {
            return MathINumberBase.IsEvenInteger(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsEvenInteger(ulong)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEvenInteger(ulong value) {
            return MathINumberBase.IsEvenInteger(value);
        }


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


        /// <inheritdoc cref="MathINumberBase.IsOddInteger(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsOddInteger(float value) {
            return MathINumberBase.IsOddInteger(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsOddInteger(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsOddInteger(double value) {
            return MathINumberBase.IsOddInteger(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsOddInteger(sbyte)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsOddInteger(sbyte value) {
            return MathINumberBase.IsOddInteger(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsOddInteger(byte)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsOddInteger(byte value) {
            return MathINumberBase.IsOddInteger(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsOddInteger(short)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsOddInteger(short value) {
            return MathINumberBase.IsOddInteger(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsOddInteger(ushort)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsOddInteger(ushort value) {
            return MathINumberBase.IsOddInteger(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsOddInteger(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsOddInteger(int value) {
            return MathINumberBase.IsOddInteger(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsOddInteger(uint)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsOddInteger(uint value) {
            return MathINumberBase.IsOddInteger(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsOddInteger(long)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsOddInteger(long value) {
            return MathINumberBase.IsOddInteger(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsOddInteger(ulong)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsOddInteger(ulong value) {
            return MathINumberBase.IsOddInteger(value);
        }


        /// <inheritdoc cref="MathINumberBase.IsPositive(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsPositive(float value) {
            return MathINumberBase.IsPositive(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsPositive(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsPositive(double value) {
            return MathINumberBase.IsPositive(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsPositive(sbyte)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsPositive(sbyte value) {
            return MathINumberBase.IsPositive(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsPositive(short)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsPositive(short value) {
            return MathINumberBase.IsPositive(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsPositive(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsPositive(int value) {
            return MathINumberBase.IsPositive(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsPositive(long)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsPositive(long value) {
            return MathINumberBase.IsPositive(value);
        }


        /// <inheritdoc cref="MathINumberBase.IsPositiveInfinity(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsPositiveInfinity(float value) {
            return MathINumberBase.IsPositiveInfinity(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsPositiveInfinity(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsPositiveInfinity(double value) {
            return MathINumberBase.IsPositiveInfinity(value);
        }


        /// <inheritdoc cref="MathINumberBase.IsSubnormal(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsSubnormal(float value) {
            return MathINumberBase.IsSubnormal(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsSubnormal(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsSubnormal(double value) {
            return MathINumberBase.IsSubnormal(value);
        }


        /// <inheritdoc cref="MathINumberBase.IsZero(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsZero(float value) {
            return MathINumberBase.IsZero(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsZero(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsZero(double value) {
            return MathINumberBase.IsZero(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsZero(sbyte)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsZero(sbyte value) {
            return MathINumberBase.IsZero(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsZero(byte)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsZero(byte value) {
            return MathINumberBase.IsZero(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsZero(short)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsZero(short value) {
            return MathINumberBase.IsZero(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsZero(ushort)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsZero(ushort value) {
            return MathINumberBase.IsZero(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsZero(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsZero(int value) {
            return MathINumberBase.IsZero(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsZero(uint)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsZero(uint value) {
            return MathINumberBase.IsZero(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsZero(long)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsZero(long value) {
            return MathINumberBase.IsZero(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsZero(ulong)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsZero(ulong value) {
            return MathINumberBase.IsZero(value);
        }


        /// <inheritdoc cref="MathINumberBase.IsZeroOrSubnormal(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsZeroOrSubnormal(float value) {
            return MathINumberBase.IsZeroOrSubnormal(value);
        }

        /// <inheritdoc cref="MathINumberBase.IsZeroOrSubnormal(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsZeroOrSubnormal(double value) {
            return MathINumberBase.IsZeroOrSubnormal(value);
        }

    }
}
