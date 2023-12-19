using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using Zyl.VectorTraits.Numerics;

namespace Zyl.VectorTraits {
    // IRootFunctions: https://learn.microsoft.com/en-us/dotnet/api/system.numerics.irootfunctions-1
    // Referenced from generic math (参考了泛型数学): https://learn.microsoft.com/en-us/dotnet/standard/generics/math
    partial class BitMath {

        /// <inheritdoc cref="MathIRootFunctions.Sqrt(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Sqrt(float x) {
            return MathIRootFunctions.Sqrt(x);
        }

        /// <inheritdoc cref="MathIRootFunctions.Sqrt(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Sqrt(double x) {
            return MathIRootFunctions.Sqrt(x);
        }

        /// <inheritdoc cref="MathIRootFunctions.Sqrt(sbyte)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte Sqrt(sbyte x) {
            return MathIRootFunctions.Sqrt(x);
        }

        /// <inheritdoc cref="MathIRootFunctions.Sqrt(byte)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte Sqrt(byte x) {
            return MathIRootFunctions.Sqrt(x);
        }

        /// <inheritdoc cref="MathIRootFunctions.Sqrt(short)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short Sqrt(short x) {
            return MathIRootFunctions.Sqrt(x);
        }

        /// <inheritdoc cref="MathIRootFunctions.Sqrt(ushort)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort Sqrt(ushort x) {
            return MathIRootFunctions.Sqrt(x);
        }

        /// <inheritdoc cref="MathIRootFunctions.Sqrt(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sqrt(int x) {
            return MathIRootFunctions.Sqrt(x);
        }

        /// <inheritdoc cref="MathIRootFunctions.Sqrt(uint)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Sqrt(uint x) {
            return MathIRootFunctions.Sqrt(x);
        }

        /// <inheritdoc cref="MathIRootFunctions.Sqrt(long)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Sqrt(long x) {
            return MathIRootFunctions.Sqrt(x);
        }

        /// <inheritdoc cref="MathIRootFunctions.Sqrt(ulong)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong Sqrt(ulong x) {
            return MathIRootFunctions.Sqrt(x);
        }

    }
}
