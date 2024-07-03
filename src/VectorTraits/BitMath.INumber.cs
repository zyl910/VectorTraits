﻿#if NET5_0_OR_GREATER
#define BCL_TYPE_HALF
#endif // NET5_0_OR_GREATER
#if NET7_0_OR_GREATER
#define BCL_TYPE_INT128
#endif // NET7_0_OR_GREATER

using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using Zyl.VectorTraits.Numerics;
using Zyl.VectorTraits.ExTypes;

namespace Zyl.VectorTraits {
    // INumber: https://learn.microsoft.com/en-us/dotnet/api/system.numerics.inumber-1
    // Referenced from generic math (参考了泛型数学): https://learn.microsoft.com/en-us/dotnet/standard/generics/math
    partial class BitMath {

        /// <inheritdoc cref="MathINumber.Clamp(sbyte, sbyte, sbyte)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte Clamp(sbyte value, sbyte amin, sbyte amax) {
            return MathINumber.Clamp(value, amin, amax);
        }

        /// <inheritdoc cref="MathINumber.Clamp(byte, byte, byte)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte Clamp(byte value, byte amin, byte amax) {
            return MathINumber.Clamp(value, amin, amax);
        }

        /// <inheritdoc cref="MathINumber.Clamp(short, short, short)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short Clamp(short value, short amin, short amax) {
            return MathINumber.Clamp(value, amin, amax);
        }

        /// <inheritdoc cref="MathINumber.Clamp(ushort, ushort, ushort)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort Clamp(ushort value, ushort amin, ushort amax) {
            return MathINumber.Clamp(value, amin, amax);
        }

        /// <inheritdoc cref="MathINumber.Clamp(int, int, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Clamp(int value, int amin, int amax) {
            return MathINumber.Clamp(value, amin, amax);
        }

        /// <inheritdoc cref="MathINumber.Clamp(uint, uint, uint)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Clamp(uint value, uint amin, uint amax) {
            return MathINumber.Clamp(value, amin, amax);
        }

        /// <inheritdoc cref="MathINumber.Clamp(long, long, long)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Clamp(long value, long amin, long amax) {
            return MathINumber.Clamp(value, amin, amax);
        }

        /// <inheritdoc cref="MathINumber.Clamp(ulong, ulong, ulong)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong Clamp(ulong value, ulong amin, ulong amax) {
            return MathINumber.Clamp(value, amin, amax);
        }

        /// <inheritdoc cref="MathINumber.Clamp(nint, nint, nint)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nint Clamp(nint value, nint amin, nint amax) {
            return MathINumber.Clamp(value, amin, amax);
        }

        /// <inheritdoc cref="MathINumber.Clamp(nuint, nuint, nuint)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nuint Clamp(nuint value, nuint amin, nuint amax) {
            return MathINumber.Clamp(value, amin, amax);
        }

        /// <inheritdoc cref="MathINumber.Clamp(float, float, float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Clamp(float value, float amin, float amax) {
            return MathINumber.Clamp(value, amin, amax);
        }

        /// <inheritdoc cref="MathINumber.Clamp(double, double, double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Clamp(double value, double amin, double amax) {
            return MathINumber.Clamp(value, amin, amax);
        }

#if BCL_TYPE_HALF

        /// <inheritdoc cref="MathINumber.Clamp(Half, Half, Half)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half Clamp(Half value, Half amin, Half amax) {
            return MathINumber.Clamp(value, amin, amax);
        }

#endif // BCL_TYPE_HALF


        /// <inheritdoc cref="MathINumber.CopySign(float, float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float CopySign(float value, float sign) {
            return MathINumber.CopySign(value, sign);
        }

        /// <inheritdoc cref="MathINumber.CopySign(double, double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double CopySign(double value, double sign) {
            return MathINumber.CopySign(value, sign);
        }

#if BCL_TYPE_HALF
        /// <inheritdoc cref="MathINumber.CopySign(Half, Half)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half CopySign(Half value, Half sign) {
            return MathINumber.CopySign(value, sign);
        }
#endif // BCL_TYPE_HALF

        /// <inheritdoc cref="MathINumber.CopySign(sbyte, sbyte)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte CopySign(sbyte value, sbyte sign) {
            return MathINumber.CopySign(value, sign);
        }

        /// <inheritdoc cref="MathINumber.CopySign(short, short)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short CopySign(short value, short sign) {
            return MathINumber.CopySign(value, sign);
        }

        /// <inheritdoc cref="MathINumber.CopySign(int, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CopySign(int value, int sign) {
            return MathINumber.CopySign(value, sign);
        }

        /// <inheritdoc cref="MathINumber.CopySign(long, long)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long CopySign(long value, long sign) {
            return MathINumber.CopySign(value, sign);
        }


        /// <inheritdoc cref="MathINumber.Max(sbyte, sbyte)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte Max(sbyte val1, sbyte val2) {
            return MathINumber.Max(val1, val2);
        }

        /// <inheritdoc cref="MathINumber.Max(byte, byte)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte Max(byte val1, byte val2) {
            return MathINumber.Max(val1, val2);
        }

        /// <inheritdoc cref="MathINumber.Max(short, short)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short Max(short val1, short val2) {
            return MathINumber.Max(val1, val2);
        }

        /// <inheritdoc cref="MathINumber.Max(ushort, ushort)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort Max(ushort val1, ushort val2) {
            return MathINumber.Max(val1, val2);
        }

        /// <inheritdoc cref="MathINumber.Max(int, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Max(int val1, int val2) {
            return MathINumber.Max(val1, val2);
        }

        /// <inheritdoc cref="MathINumber.Max(uint, uint)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Max(uint val1, uint val2) {
            return MathINumber.Max(val1, val2);
        }

        /// <inheritdoc cref="MathINumber.Max(long, long)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Max(long val1, long val2) {
            return MathINumber.Max(val1, val2);
        }

        /// <inheritdoc cref="MathINumber.Max(ulong, ulong)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong Max(ulong val1, ulong val2) {
            return MathINumber.Max(val1, val2);
        }

        /// <inheritdoc cref="MathINumber.Max(ExInt128, ExInt128)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ExInt128 Max(ExInt128 val1, ExInt128 val2) {
            return MathINumber.Max(val1, val2);
        }

        /// <inheritdoc cref="MathINumber.Max(ExUInt128, ExUInt128)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ExUInt128 Max(ExUInt128 val1, ExUInt128 val2) {
            return MathINumber.Max(val1, val2);
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="MathINumber.Max(Int128, Int128)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 Max(Int128 val1, Int128 val2) {
            return MathINumber.Max(val1, val2);
        }

        /// <inheritdoc cref="MathINumber.Max(UInt128, UInt128)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 Max(UInt128 val1, UInt128 val2) {
            return MathINumber.Max(val1, val2);
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="MathINumber.Max(nint, nint)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nint Max(nint val1, nint val2) {
            return MathINumber.Max(val1, val2);
        }

        /// <inheritdoc cref="MathINumber.Max(nuint, nuint)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nuint Max(nuint val1, nuint val2) {
            return MathINumber.Max(val1, val2);
        }

        /// <inheritdoc cref="MathINumber.Max(float, float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Max(float val1, float val2) {
            return MathINumber.Max(val1, val2);
        }

        /// <inheritdoc cref="MathINumber.Max(double, double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Max(double val1, double val2) {
            return MathINumber.Max(val1, val2);
        }

#if BCL_TYPE_HALF

        /// <inheritdoc cref="MathINumber.Max(Half, Half)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half Max(Half val1, Half val2) {
            return MathINumber.Max(val1, val2);
        }

#endif // BCL_TYPE_HALF


        /// <inheritdoc cref="MathINumber.MaxNumber(float, float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float MaxNumber(float x, float y) {
            return MathINumber.MaxNumber(x, y);
        }

        /// <inheritdoc cref="MathINumber.MaxNumber(double, double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double MaxNumber(double x, double y) {
            return MathINumber.MaxNumber(x, y);
        }

#if BCL_TYPE_HALF
        /// <inheritdoc cref="MathINumber.MaxNumber(Half, Half)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half MaxNumber(Half x, Half y) {
            return MathINumber.MaxNumber(x, y);
        }
#endif // BCL_TYPE_HALF


        /// <inheritdoc cref="MathINumber.Min(sbyte, sbyte)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte Min(sbyte val1, sbyte val2) {
            return MathINumber.Min(val1, val2);
        }

        /// <inheritdoc cref="MathINumber.Min(byte, byte)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte Min(byte val1, byte val2) {
            return MathINumber.Min(val1, val2);
        }

        /// <inheritdoc cref="MathINumber.Min(short, short)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short Min(short val1, short val2) {
            return MathINumber.Min(val1, val2);
        }

        /// <inheritdoc cref="MathINumber.Min(ushort, ushort)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort Min(ushort val1, ushort val2) {
            return MathINumber.Min(val1, val2);
        }

        /// <inheritdoc cref="MathINumber.Min(int, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Min(int val1, int val2) {
            return MathINumber.Min(val1, val2);
        }

        /// <inheritdoc cref="MathINumber.Min(uint, uint)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Min(uint val1, uint val2) {
            return MathINumber.Min(val1, val2);
        }

        /// <inheritdoc cref="MathINumber.Min(long, long)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Min(long val1, long val2) {
            return MathINumber.Min(val1, val2);
        }

        /// <inheritdoc cref="MathINumber.Min(ulong, ulong)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong Min(ulong val1, ulong val2) {
            return MathINumber.Min(val1, val2);
        }

        /// <inheritdoc cref="MathINumber.Min(ExInt128, ExInt128)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ExInt128 Min(ExInt128 val1, ExInt128 val2) {
            return MathINumber.Min(val1, val2);
        }

        /// <inheritdoc cref="MathINumber.Min(ExUInt128, ExUInt128)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ExUInt128 Min(ExUInt128 val1, ExUInt128 val2) {
            return MathINumber.Min(val1, val2);
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="MathINumber.Min(Int128, Int128)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 Min(Int128 val1, Int128 val2) {
            return MathINumber.Min(val1, val2);
        }

        /// <inheritdoc cref="MathINumber.Min(UInt128, UInt128)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 Min(UInt128 val1, UInt128 val2) {
            return MathINumber.Min(val1, val2);
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="MathINumber.Min(nint, nint)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nint Min(nint val1, nint val2) {
            return MathINumber.Min(val1, val2);
        }

        /// <inheritdoc cref="MathINumber.Min(nuint, nuint)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nuint Min(nuint val1, nuint val2) {
            return MathINumber.Min(val1, val2);
        }

        /// <inheritdoc cref="MathINumber.Min(float, float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Min(float val1, float val2) {
            return MathINumber.Min(val1, val2);
        }

        /// <inheritdoc cref="MathINumber.Min(double, double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Min(double val1, double val2) {
            return MathINumber.Min(val1, val2);
        }

#if BCL_TYPE_HALF

        /// <inheritdoc cref="MathINumber.Min(Half, Half)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half Min(Half val1, Half val2) {
            return MathINumber.Min(val1, val2);
        }

#endif // BCL_TYPE_HALF


        /// <inheritdoc cref="MathINumber.MinNumber(float, float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float MinNumber(float x, float y) {
            return MathINumber.MinNumber(x, y);
        }

        /// <inheritdoc cref="MathINumber.MinNumber(double, double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double MinNumber(double x, double y) {
            return MathINumber.MinNumber(x, y);
        }

#if BCL_TYPE_HALF
        /// <inheritdoc cref="MathINumber.MinNumber(Half, Half)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half MinNumber(Half x, Half y) {
            return MathINumber.MinNumber(x, y);
        }
#endif // BCL_TYPE_HALF


        /// <inheritdoc cref="MathINumber.Sign(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign(float value) {
            return MathINumber.Sign(value);
        }

        /// <inheritdoc cref="MathINumber.Sign(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign(double value) {
            return MathINumber.Sign(value);
        }

#if BCL_TYPE_HALF
        /// <inheritdoc cref="MathINumber.Sign(Half)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign(Half value) {
            return MathINumber.Sign(value);
        }
#endif // BCL_TYPE_HALF

        /// <inheritdoc cref="MathINumber.Sign(sbyte)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign(sbyte value) {
            return MathINumber.Sign(value);
        }

        /// <inheritdoc cref="MathINumber.Sign(short)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign(short value) {
            return MathINumber.Sign(value);
        }

        /// <inheritdoc cref="MathINumber.Sign(int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign(int value) {
            return MathINumber.Sign(value);
        }

        /// <inheritdoc cref="MathINumber.Sign(long)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign(long value) {
            return MathINumber.Sign(value);
        }


        /// <inheritdoc cref="MathINumber.SignFloat(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float SignFloat(float value) {
            return MathINumber.SignFloat(value);
        }

        /// <inheritdoc cref="MathINumber.SignFloat(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double SignFloat(double value) {
            return MathINumber.SignFloat(value);
        }

#if BCL_TYPE_HALF
        /// <inheritdoc cref="MathINumber.SignFloat(Half)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half SignFloat(Half value) {
            return MathINumber.SignFloat(value);
        }
#endif // BCL_TYPE_HALF

    }
}
