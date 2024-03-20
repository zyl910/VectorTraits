﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
#endif

namespace Zyl.VectorTraits.Impl.AVector512 {
    using SuperStatics = WVectorTraits512Base.Statics;

    partial class WVectorTraits512Avx512 {

        partial class Statics {

#if NET8_0_OR_GREATER
/*
            /// <inheritdoc cref="IWVectorTraits512.Abs_AcceleratedTypes"/>
            public static TypeCodeFlags Abs_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.Abs(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Abs(Vector512<float> value) {
                var mask = Vector512Constants.Single_NonSignMask;
                return Avx.And(mask, value);
            }

            /// <inheritdoc cref="IWVectorTraits512.Abs(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Abs(Vector512<double> value) {
                var mask = Vector512Constants.Double_NonSignMask;
                return Avx.And(mask, value);
            }

            /// <inheritdoc cref="IWVectorTraits512.Abs(Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> Abs(Vector512<sbyte> value) {
                return Avx512.Abs(value).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.Abs(Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> Abs(Vector512<short> value) {
                return Avx512.Abs(value).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.Abs(Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> Abs(Vector512<int> value) {
                return Avx512.Abs(value).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.Abs(Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> Abs(Vector512<long> value) {
                // If an integer value is positive or zero, no action is required. Otherwise complement and add 1.
                Vector512<long> mask = Avx512.CompareGreaterThan(Vector512<long>.Zero, value); // 0>value => value<0
                Vector512<long> rt = Avx512.Subtract(Avx512.Xor(value, mask), mask); // -x => (~x)+1 => (~x)-(-1) = (x^mask)-mask .
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.Add_AcceleratedTypes"/>
            public static TypeCodeFlags Add_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Add(Vector512<float> left, Vector512<float> right) {
                return Avx.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Add(Vector512<double> left, Vector512<double> right) {
                return Avx.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> Add(Vector512<sbyte> left, Vector512<sbyte> right) {
                return Avx512.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> Add(Vector512<byte> left, Vector512<byte> right) {
                return Avx512.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> Add(Vector512<short> left, Vector512<short> right) {
                return Avx512.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> Add(Vector512<ushort> left, Vector512<ushort> right) {
                return Avx512.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> Add(Vector512<int> left, Vector512<int> right) {
                return Avx512.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> Add(Vector512<uint> left, Vector512<uint> right) {
                return Avx512.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> Add(Vector512<long> left, Vector512<long> right) {
                return Avx512.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> Add(Vector512<ulong> left, Vector512<ulong> right) {
                return Avx512.Add(left, right);
            }


            /// <inheritdoc cref="IWVectorTraits512.AndNot_AcceleratedTypes"/>
            public static TypeCodeFlags AndNot_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.AndNot{T}(Vector512{T}, Vector512{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<T> AndNot<T>(Vector512<T> left, Vector512<T> right) where T : struct {
                // __m512i _mm512_andnot_si512 (__m512i a, __m512i b)
                // #include <immintrin.h>
                // Instruction: vpandn ymm, ymm, ymm
                // CPUID Flags: AVX2
                // Description
                // Compute the bitwise NOT of 512 bits (representing integer data) in a and then AND with b, and store the result in dst.
                // Operation
                // dst[255:0] := ((NOT a[255:0]) AND b[255:0])
                return Avx512.AndNot(right.AsUInt64(), left.AsUInt64()).As<ulong, T>();
            }


            /// <inheritdoc cref="IWVectorTraits512.BitwiseAnd_AcceleratedTypes"/>
            public static TypeCodeFlags BitwiseAnd_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.BitwiseAnd{T}(Vector512{T}, Vector512{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<T> BitwiseAnd<T>(Vector512<T> left, Vector512<T> right) where T : struct {
                return Avx512.And(left.AsUInt64(), right.AsUInt64()).As<ulong, T>();
            }


            /// <inheritdoc cref="IWVectorTraits512.BitwiseOr_AcceleratedTypes"/>
            public static TypeCodeFlags BitwiseOr_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.BitwiseOr{T}(Vector512{T}, Vector512{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<T> BitwiseOr<T>(Vector512<T> left, Vector512<T> right) where T : struct {
                return Avx512.Or(left.AsUInt64(), right.AsUInt64()).As<ulong, T>();
            }


            /// <inheritdoc cref="IWVectorTraits512.ConditionalSelect_AcceleratedTypes"/>
            public static TypeCodeFlags ConditionalSelect_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.ConditionalSelect{T}(Vector512{T}, Vector512{T}, Vector512{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<T> ConditionalSelect<T>(Vector512<T> condition, Vector512<T> left, Vector512<T> right) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector512.ConditionalSelect(condition, left, right);
#else
                return ConditionalSelect_OrAnd(condition, left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits512.ConditionalSelect{T}(Vector512{T}, Vector512{T}, Vector512{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<T> ConditionalSelect_OrAnd<T>(Vector512<T> condition, Vector512<T> left, Vector512<T> right) where T : struct {
                // result = (left & condition) | (right & ~condition);
                return Avx512.Or(Avx512.And(condition.AsUInt64(), left.AsUInt64())
                    , Avx512.AndNot(condition.AsUInt64(), right.AsUInt64())
                    ).As<ulong, T>();
            }


            /// <inheritdoc cref="IWVectorTraits512.Divide_AcceleratedTypes"/>
            public static TypeCodeFlags Divide_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Single | TypeCodeFlags.Double;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.Divide(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Divide(Vector512<float> left, Vector512<float> right) {
                return Avx.Divide(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Divide(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Divide(Vector512<double> left, Vector512<double> right) {
                return Avx.Divide(left, right);
            }


            /// <inheritdoc cref="IWVectorTraits512.Dot_AcceleratedTypes"/>
            public static TypeCodeFlags Dot_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = Multiply_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float Dot(Vector512<float> left, Vector512<float> right) {
                Vector512<float> temp = Avx.Multiply(left, right);
                return Sum(temp);
            }

            /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static double Dot(Vector512<double> left, Vector512<double> right) {
                Vector512<double> temp = Avx.Multiply(left, right);
                return Sum(temp);
            }

            /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static sbyte Dot(Vector512<sbyte> left, Vector512<sbyte> right) {
                return (sbyte)Dot(left.AsByte(), right.AsByte());
            }

            /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static byte Dot(Vector512<byte> left, Vector512<byte> right) {
                Widen(left, out Vector512<ushort> u0, out Vector512<ushort> u1);
                Widen(right, out Vector512<ushort> v0, out Vector512<ushort> v1);
                Vector512<ushort> w0 = Avx512.MultiplyLow(u0, v0);
                Vector512<ushort> w1 = Avx512.MultiplyLow(u1, v1);
                w0 = Avx512.Add(w0, w1);
                return (byte)Sum(w0);
            }

            /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static short Dot(Vector512<short> left, Vector512<short> right) {
                Vector512<short> temp = Avx512.MultiplyLow(left, right);
                return Sum(temp);
            }

            /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ushort Dot(Vector512<ushort> left, Vector512<ushort> right) {
                Vector512<ushort> temp = Avx512.MultiplyLow(left, right);
                return Sum(temp);
            }

            /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static int Dot(Vector512<int> left, Vector512<int> right) {
                Vector512<int> temp = Avx512.MultiplyLow(left, right);
                return Sum(temp);
            }

            /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint Dot(Vector512<uint> left, Vector512<uint> right) {
                Vector512<uint> temp = Avx512.MultiplyLow(left, right);
                return Sum(temp);
            }

            /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static long Dot(Vector512<long> left, Vector512<long> right) {
                Vector512<long> temp = Multiply(left, right);
                return Sum(temp);
            }

            /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong Dot(Vector512<ulong> left, Vector512<ulong> right) {
                Vector512<ulong> temp = Multiply(left, right);
                return Sum(temp);
            }


            /// <inheritdoc cref="IWVectorTraits512.Equals_AcceleratedTypes"/>
            public static TypeCodeFlags Equals_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Equals(Vector512<float> left, Vector512<float> right) {
#if NET5_0_OR_GREATER
                return Avx.CompareEqual(left, right);
#else
                return Avx.Compare(left, right, FloatComparisonMode.OrderedEqualNonSignaling);
#endif // NET5_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Equals(Vector512<double> left, Vector512<double> right) {
#if NET5_0_OR_GREATER
                return Avx.CompareEqual(left, right);
#else
                return Avx.Compare(left, right, FloatComparisonMode.OrderedEqualNonSignaling);
#endif // NET5_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> Equals(Vector512<sbyte> left, Vector512<sbyte> right) {
                return Avx512.CompareEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> Equals(Vector512<byte> left, Vector512<byte> right) {
                return Avx512.CompareEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> Equals(Vector512<short> left, Vector512<short> right) {
                return Avx512.CompareEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> Equals(Vector512<ushort> left, Vector512<ushort> right) {
                return Avx512.CompareEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> Equals(Vector512<int> left, Vector512<int> right) {
                return Avx512.CompareEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> Equals(Vector512<uint> left, Vector512<uint> right) {
                return Avx512.CompareEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> Equals(Vector512<long> left, Vector512<long> right) {
                return Avx512.CompareEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> Equals(Vector512<ulong> left, Vector512<ulong> right) {
                return Avx512.CompareEqual(left, right);
            }


            /// <inheritdoc cref="IWVectorTraits512.EqualsAll_AcceleratedTypes"/>
            public static TypeCodeFlags EqualsAll_AcceleratedTypes {
                get {
                    return Equals_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.EqualsAll(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector512<float> left, Vector512<float> right) {
                return YIsAllTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.EqualsAll(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector512<double> left, Vector512<double> right) {
                return YIsAllTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.EqualsAll(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector512<sbyte> left, Vector512<sbyte> right) {
                return YIsAllTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.EqualsAll(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector512<byte> left, Vector512<byte> right) {
                return YIsAllTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.EqualsAll(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector512<short> left, Vector512<short> right) {
                return YIsAllTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.EqualsAll(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector512<ushort> left, Vector512<ushort> right) {
                return YIsAllTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.EqualsAll(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector512<int> left, Vector512<int> right) {
                return YIsAllTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.EqualsAll(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector512<uint> left, Vector512<uint> right) {
                return YIsAllTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.EqualsAll(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector512<long> left, Vector512<long> right) {
                return YIsAllTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.EqualsAll(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector512<ulong> left, Vector512<ulong> right) {
                return YIsAllTrue(Equals(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits512.EqualsAny_AcceleratedTypes"/>
            public static TypeCodeFlags EqualsAny_AcceleratedTypes {
                get {
                    return Equals_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.EqualsAny(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector512<float> left, Vector512<float> right) {
                return YIsAnyTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.EqualsAny(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector512<double> left, Vector512<double> right) {
                return YIsAnyTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.EqualsAny(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector512<sbyte> left, Vector512<sbyte> right) {
                return YIsAnyTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.EqualsAny(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector512<byte> left, Vector512<byte> right) {
                return YIsAnyTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.EqualsAny(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector512<short> left, Vector512<short> right) {
                return YIsAnyTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.EqualsAny(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector512<ushort> left, Vector512<ushort> right) {
                return YIsAnyTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.EqualsAny(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector512<int> left, Vector512<int> right) {
                return YIsAnyTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.EqualsAny(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector512<uint> left, Vector512<uint> right) {
                return YIsAnyTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.EqualsAny(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector512<long> left, Vector512<long> right) {
                return YIsAnyTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.EqualsAny(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector512<ulong> left, Vector512<ulong> right) {
                return YIsAnyTrue(Equals(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits512.GreaterThan_AcceleratedTypes"/>
            public static TypeCodeFlags GreaterThan_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> GreaterThan(Vector512<float> left, Vector512<float> right) {
#if NET5_0_OR_GREATER
                return Avx.CompareGreaterThan(left, right);
#else
                return Avx.Compare(left, right, FloatComparisonMode.OrderedGreaterThanSignaling);
#endif // NET5_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> GreaterThan(Vector512<double> left, Vector512<double> right) {
#if NET5_0_OR_GREATER
                return Avx.CompareGreaterThan(left, right);
#else
                return Avx.Compare(left, right, FloatComparisonMode.OrderedGreaterThanSignaling);
#endif // NET5_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> GreaterThan(Vector512<sbyte> left, Vector512<sbyte> right) {
                return Avx512.CompareGreaterThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> GreaterThan(Vector512<byte> left, Vector512<byte> right) {
                //Vector512<sbyte> mid = Vector512s<sbyte>.MinValue;
                Vector512<sbyte> mid = Vector512.Create(sbyte.MinValue); // .NET5+ has better performance .
                Vector512<sbyte> left2 = Avx512.Xor(left.AsSByte(), mid);
                Vector512<sbyte> right2 = Avx512.Xor(right.AsSByte(), mid);
                Vector512<sbyte> mask = Avx512.CompareGreaterThan(left2, right2);
                return mask.AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> GreaterThan(Vector512<short> left, Vector512<short> right) {
                return Avx512.CompareGreaterThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> GreaterThan(Vector512<ushort> left, Vector512<ushort> right) {
                //Vector512<short> mid = Vector512s<short>.MinValue;
                Vector512<short> mid = Vector512.Create(short.MinValue); // .NET5+ has better performance .
                Vector512<short> left2 = Avx512.Xor(left.AsInt16(), mid);
                Vector512<short> right2 = Avx512.Xor(right.AsInt16(), mid);
                Vector512<short> mask = Avx512.CompareGreaterThan(left2, right2);
                return mask.AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> GreaterThan(Vector512<int> left, Vector512<int> right) {
                return Avx512.CompareGreaterThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> GreaterThan(Vector512<uint> left, Vector512<uint> right) {
                //Vector512<int> mid = Vector512s<int>.MinValue;
                Vector512<int> mid = Vector512.Create(int.MinValue); // .NET5+ has better performance .
                Vector512<int> left2 = Avx512.Xor(left.AsInt32(), mid);
                Vector512<int> right2 = Avx512.Xor(right.AsInt32(), mid);
                Vector512<int> mask = Avx512.CompareGreaterThan(left2, right2);
                return mask.AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> GreaterThan(Vector512<long> left, Vector512<long> right) {
                Vector512<long> mask = Avx512.CompareGreaterThan(left, right);
                return mask;
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> GreaterThan(Vector512<ulong> left, Vector512<ulong> right) {
                //Vector512<long> mid = Vector512s<long>.MinValue;
                Vector512<long> mid = Vector512Constants.Int64_MinValue;
                Vector512<long> left2 = Avx512.Add(left.AsInt64(), mid);
                Vector512<long> right2 = Avx512.Add(right.AsInt64(), mid);
                Vector512<long> mask = Avx512.CompareGreaterThan(left2, right2);
                return mask.AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll_AcceleratedTypes"/>
            public static TypeCodeFlags GreaterThanAll_AcceleratedTypes {
                get {
                    return GreaterThan_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector512<float> left, Vector512<float> right) {
                return YIsAllTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector512<double> left, Vector512<double> right) {
                return YIsAllTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector512<sbyte> left, Vector512<sbyte> right) {
                return YIsAllTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector512<byte> left, Vector512<byte> right) {
                return YIsAllTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector512<short> left, Vector512<short> right) {
                return YIsAllTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector512<ushort> left, Vector512<ushort> right) {
                return YIsAllTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector512<int> left, Vector512<int> right) {
                return YIsAllTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector512<uint> left, Vector512<uint> right) {
                return YIsAllTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector512<long> left, Vector512<long> right) {
                return YIsAllTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector512<ulong> left, Vector512<ulong> right) {
                return YIsAllTrue(GreaterThan(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny_AcceleratedTypes"/>
            public static TypeCodeFlags GreaterThanAny_AcceleratedTypes {
                get {
                    return GreaterThan_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector512<float> left, Vector512<float> right) {
                return YIsAnyTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector512<double> left, Vector512<double> right) {
                return YIsAnyTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector512<sbyte> left, Vector512<sbyte> right) {
                return YIsAnyTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector512<byte> left, Vector512<byte> right) {
                return YIsAnyTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector512<short> left, Vector512<short> right) {
                return YIsAnyTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector512<ushort> left, Vector512<ushort> right) {
                return YIsAnyTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector512<int> left, Vector512<int> right) {
                return YIsAnyTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector512<uint> left, Vector512<uint> right) {
                return YIsAnyTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector512<long> left, Vector512<long> right) {
                return YIsAnyTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector512<ulong> left, Vector512<ulong> right) {
                return YIsAnyTrue(GreaterThan(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual_AcceleratedTypes"/>
            public static TypeCodeFlags GreaterThanOrEqual_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> GreaterThanOrEqual(Vector512<float> left, Vector512<float> right) {
#if NET5_0_OR_GREATER
                return Avx.CompareGreaterThanOrEqual(left, right);
#else
                return Avx.Compare(left, right, FloatComparisonMode.OrderedGreaterThanOrEqualSignaling);
#endif // NET5_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> GreaterThanOrEqual(Vector512<double> left, Vector512<double> right) {
#if NET5_0_OR_GREATER
                return Avx.CompareGreaterThanOrEqual(left, right);
#else
                return Avx.Compare(left, right, FloatComparisonMode.OrderedGreaterThanOrEqualSignaling);
#endif // NET5_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> GreaterThanOrEqual(Vector512<sbyte> left, Vector512<sbyte> right) {
                return OnesComplement(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> GreaterThanOrEqual(Vector512<byte> left, Vector512<byte> right) {
                return OnesComplement(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> GreaterThanOrEqual(Vector512<short> left, Vector512<short> right) {
                return OnesComplement(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> GreaterThanOrEqual(Vector512<ushort> left, Vector512<ushort> right) {
                return OnesComplement(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> GreaterThanOrEqual(Vector512<int> left, Vector512<int> right) {
                return OnesComplement(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> GreaterThanOrEqual(Vector512<uint> left, Vector512<uint> right) {
                return OnesComplement(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> GreaterThanOrEqual(Vector512<long> left, Vector512<long> right) {
                return OnesComplement(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> GreaterThanOrEqual(Vector512<ulong> left, Vector512<ulong> right) {
                return OnesComplement(LessThan(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll_AcceleratedTypes"/>
            public static TypeCodeFlags GreaterThanOrEqualAll_AcceleratedTypes {
                get {
                    return GreaterThanOrEqual_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector512<float> left, Vector512<float> right) {
                return YIsAllTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector512<double> left, Vector512<double> right) {
                return YIsAllTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector512<sbyte> left, Vector512<sbyte> right) {
                return YIsAllTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector512<byte> left, Vector512<byte> right) {
                return YIsAllTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector512<short> left, Vector512<short> right) {
                return YIsAllTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector512<ushort> left, Vector512<ushort> right) {
                return YIsAllTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector512<int> left, Vector512<int> right) {
                return YIsAllTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector512<uint> left, Vector512<uint> right) {
                return YIsAllTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector512<long> left, Vector512<long> right) {
                return YIsAllTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector512<ulong> left, Vector512<ulong> right) {
                return YIsAllTrue(GreaterThanOrEqual(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny_AcceleratedTypes"/>
            public static TypeCodeFlags GreaterThanOrEqualAny_AcceleratedTypes {
                get {
                    return GreaterThanOrEqual_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector512<float> left, Vector512<float> right) {
                return YIsAnyTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector512<double> left, Vector512<double> right) {
                return YIsAnyTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector512<sbyte> left, Vector512<sbyte> right) {
                return YIsAnyTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector512<byte> left, Vector512<byte> right) {
                return YIsAnyTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector512<short> left, Vector512<short> right) {
                return YIsAnyTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector512<ushort> left, Vector512<ushort> right) {
                return YIsAnyTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector512<int> left, Vector512<int> right) {
                return YIsAnyTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector512<uint> left, Vector512<uint> right) {
                return YIsAnyTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector512<long> left, Vector512<long> right) {
                return YIsAnyTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector512<ulong> left, Vector512<ulong> right) {
                return YIsAnyTrue(GreaterThanOrEqual(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits512.LessThan_AcceleratedTypes"/>
            public static TypeCodeFlags LessThan_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> LessThan(Vector512<float> left, Vector512<float> right) {
#if NET5_0_OR_GREATER
                return Avx.CompareLessThan(left, right);
#else
                return Avx.Compare(left, right, FloatComparisonMode.OrderedLessThanSignaling);
#endif // NET5_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> LessThan(Vector512<double> left, Vector512<double> right) {
#if NET5_0_OR_GREATER
                return Avx.CompareLessThan(left, right);
#else
                return Avx.Compare(left, right, FloatComparisonMode.OrderedLessThanSignaling);
#endif // NET5_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> LessThan(Vector512<sbyte> left, Vector512<sbyte> right) {
                return Avx512.CompareGreaterThan(right, left);
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> LessThan(Vector512<byte> left, Vector512<byte> right) {
                //Vector512<sbyte> mid = Vector512s<sbyte>.MinValue;
                Vector512<sbyte> mid = Vector512.Create(sbyte.MinValue); // .NET5+ has better performance .
                Vector512<sbyte> left2 = Avx512.Xor(left.AsSByte(), mid);
                Vector512<sbyte> right2 = Avx512.Xor(right.AsSByte(), mid);
                Vector512<sbyte> mask = Avx512.CompareGreaterThan(right2, left2);
                return mask.AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> LessThan(Vector512<short> left, Vector512<short> right) {
                return Avx512.CompareGreaterThan(right, left);
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> LessThan(Vector512<ushort> left, Vector512<ushort> right) {
                //Vector512<short> mid = Vector512s<short>.MinValue;
                Vector512<short> mid = Vector512.Create(short.MinValue); // .NET5+ has better performance .
                Vector512<short> left2 = Avx512.Xor(left.AsInt16(), mid);
                Vector512<short> right2 = Avx512.Xor(right.AsInt16(), mid);
                Vector512<short> mask = Avx512.CompareGreaterThan(right2, left2);
                return mask.AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> LessThan(Vector512<int> left, Vector512<int> right) {
                return Avx512.CompareGreaterThan(right, left);
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> LessThan(Vector512<uint> left, Vector512<uint> right) {
                //Vector512<int> mid = Vector512s<int>.MinValue;
                Vector512<int> mid = Vector512.Create(int.MinValue); // .NET5+ has better performance .
                Vector512<int> left2 = Avx512.Xor(left.AsInt32(), mid);
                Vector512<int> right2 = Avx512.Xor(right.AsInt32(), mid);
                Vector512<int> mask = Avx512.CompareGreaterThan(right2, left2);
                return mask.AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> LessThan(Vector512<long> left, Vector512<long> right) {
                return Avx512.CompareGreaterThan(right, left);
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> LessThan(Vector512<ulong> left, Vector512<ulong> right) {
                //Vector512<long> mid = Vector512s<long>.MinValue;
                Vector512<long> mid = Vector512Constants.Int64_MinValue;
                Vector512<long> left2 = Avx512.Add(mid, left.AsInt64());
                Vector512<long> right2 = Avx512.Add(mid, right.AsInt64());
                Vector512<long> mask = Avx512.CompareGreaterThan(right2, left2);
                return mask.AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits512.LessThanAll_AcceleratedTypes"/>
            public static TypeCodeFlags LessThanAll_AcceleratedTypes {
                get {
                    return LessThan_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanAll(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector512<float> left, Vector512<float> right) {
                return YIsAllTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanAll(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector512<double> left, Vector512<double> right) {
                return YIsAllTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanAll(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector512<sbyte> left, Vector512<sbyte> right) {
                return YIsAllTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanAll(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector512<byte> left, Vector512<byte> right) {
                return YIsAllTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanAll(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector512<short> left, Vector512<short> right) {
                return YIsAllTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanAll(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector512<ushort> left, Vector512<ushort> right) {
                return YIsAllTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanAll(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector512<int> left, Vector512<int> right) {
                return YIsAllTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanAll(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector512<uint> left, Vector512<uint> right) {
                return YIsAllTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanAll(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector512<long> left, Vector512<long> right) {
                return YIsAllTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanAll(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector512<ulong> left, Vector512<ulong> right) {
                return YIsAllTrue(LessThan(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits512.LessThanAny_AcceleratedTypes"/>
            public static TypeCodeFlags LessThanAny_AcceleratedTypes {
                get {
                    return LessThan_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanAny(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector512<float> left, Vector512<float> right) {
                return YIsAnyTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanAny(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector512<double> left, Vector512<double> right) {
                return YIsAnyTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanAny(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector512<sbyte> left, Vector512<sbyte> right) {
                return YIsAnyTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanAny(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector512<byte> left, Vector512<byte> right) {
                return YIsAnyTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanAny(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector512<short> left, Vector512<short> right) {
                return YIsAnyTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanAny(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector512<ushort> left, Vector512<ushort> right) {
                return YIsAnyTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanAny(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector512<int> left, Vector512<int> right) {
                return YIsAnyTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanAny(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector512<uint> left, Vector512<uint> right) {
                return YIsAnyTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanAny(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector512<long> left, Vector512<long> right) {
                return YIsAnyTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanAny(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector512<ulong> left, Vector512<ulong> right) {
                return YIsAnyTrue(LessThan(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual_AcceleratedTypes"/>
            public static TypeCodeFlags LessThanOrEqual_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> LessThanOrEqual(Vector512<float> left, Vector512<float> right) {
#if NET5_0_OR_GREATER
                return Avx.CompareLessThanOrEqual(left, right);
#else
                return Avx.Compare(left, right, FloatComparisonMode.OrderedLessThanOrEqualSignaling);
#endif // NET5_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> LessThanOrEqual(Vector512<double> left, Vector512<double> right) {
#if NET5_0_OR_GREATER
                return Avx.CompareLessThanOrEqual(left, right);
#else
                return Avx.Compare(left, right, FloatComparisonMode.OrderedLessThanOrEqualSignaling);
#endif // NET5_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> LessThanOrEqual(Vector512<sbyte> left, Vector512<sbyte> right) {
                return OnesComplement(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> LessThanOrEqual(Vector512<byte> left, Vector512<byte> right) {
                return OnesComplement(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> LessThanOrEqual(Vector512<short> left, Vector512<short> right) {
                return OnesComplement(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> LessThanOrEqual(Vector512<ushort> left, Vector512<ushort> right) {
                return OnesComplement(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> LessThanOrEqual(Vector512<int> left, Vector512<int> right) {
                return OnesComplement(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> LessThanOrEqual(Vector512<uint> left, Vector512<uint> right) {
                return OnesComplement(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> LessThanOrEqual(Vector512<long> left, Vector512<long> right) {
                return OnesComplement(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> LessThanOrEqual(Vector512<ulong> left, Vector512<ulong> right) {
                return OnesComplement(GreaterThan(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll_AcceleratedTypes"/>
            public static TypeCodeFlags LessThanOrEqualAll_AcceleratedTypes {
                get {
                    return LessThanOrEqual_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector512<float> left, Vector512<float> right) {
                return YIsAllTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector512<double> left, Vector512<double> right) {
                return YIsAllTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector512<sbyte> left, Vector512<sbyte> right) {
                return YIsAllTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector512<byte> left, Vector512<byte> right) {
                return YIsAllTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector512<short> left, Vector512<short> right) {
                return YIsAllTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector512<ushort> left, Vector512<ushort> right) {
                return YIsAllTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector512<int> left, Vector512<int> right) {
                return YIsAllTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector512<uint> left, Vector512<uint> right) {
                return YIsAllTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector512<long> left, Vector512<long> right) {
                return YIsAllTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector512<ulong> left, Vector512<ulong> right) {
                return YIsAllTrue(LessThanOrEqual(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny_AcceleratedTypes"/>
            public static TypeCodeFlags LessThanOrEqualAny_AcceleratedTypes {
                get {
                    return LessThanOrEqual_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector512<float> left, Vector512<float> right) {
                return YIsAnyTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector512<double> left, Vector512<double> right) {
                return YIsAnyTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector512<sbyte> left, Vector512<sbyte> right) {
                return YIsAnyTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector512<byte> left, Vector512<byte> right) {
                return YIsAnyTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector512<short> left, Vector512<short> right) {
                return YIsAnyTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector512<ushort> left, Vector512<ushort> right) {
                return YIsAnyTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector512<int> left, Vector512<int> right) {
                return YIsAnyTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector512<uint> left, Vector512<uint> right) {
                return YIsAnyTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector512<long> left, Vector512<long> right) {
                return YIsAnyTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector512<ulong> left, Vector512<ulong> right) {
                return YIsAnyTrue(LessThanOrEqual(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits512.Max_AcceleratedTypes"/>
            public static TypeCodeFlags Max_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Max(Vector512<float> left, Vector512<float> right) {
                return Avx.Max(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Max(Vector512<double> left, Vector512<double> right) {
                return Avx.Max(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> Max(Vector512<sbyte> left, Vector512<sbyte> right) {
                return Avx512.Max(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> Max(Vector512<byte> left, Vector512<byte> right) {
                return Avx512.Max(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> Max(Vector512<short> left, Vector512<short> right) {
                return Avx512.Max(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> Max(Vector512<ushort> left, Vector512<ushort> right) {
                return Avx512.Max(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> Max(Vector512<int> left, Vector512<int> right) {
                return Avx512.Max(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> Max(Vector512<uint> left, Vector512<uint> right) {
                return Avx512.Max(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> Max(Vector512<long> left, Vector512<long> right) {
                Vector512<long> mask = Avx512.CompareGreaterThan(left, right);
                Vector512<long> rt = Avx512.BlendVariable(right, left, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> Max(Vector512<ulong> left, Vector512<ulong> right) {
                //Vector512<long> mid = Vector512s<long>.MinValue;
                Vector512<long> mid = Vector512Constants.Int64_MinValue;
                Vector512<long> left2 = Avx512.Xor(left.AsInt64(), mid);
                Vector512<long> right2 = Avx512.Xor(right.AsInt64(), mid);
                Vector512<long> mask = Avx512.CompareGreaterThan(left2, right2);
                Vector512<ulong> rt = Avx512.BlendVariable(right, left, mask.AsUInt64());
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.Min_AcceleratedTypes"/>
            public static TypeCodeFlags Min_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Min(Vector512<float> left, Vector512<float> right) {
                return Avx.Min(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Min(Vector512<double> left, Vector512<double> right) {
                return Avx.Min(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> Min(Vector512<sbyte> left, Vector512<sbyte> right) {
                return Avx512.Min(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> Min(Vector512<byte> left, Vector512<byte> right) {
                return Avx512.Min(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> Min(Vector512<short> left, Vector512<short> right) {
                return Avx512.Min(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> Min(Vector512<ushort> left, Vector512<ushort> right) {
                return Avx512.Min(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> Min(Vector512<int> left, Vector512<int> right) {
                return Avx512.Min(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> Min(Vector512<uint> left, Vector512<uint> right) {
                return Avx512.Min(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> Min(Vector512<long> left, Vector512<long> right) {
                Vector512<long> mask = Avx512.CompareGreaterThan(right, left);
                Vector512<long> rt = Avx512.BlendVariable(right, left, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> Min(Vector512<ulong> left, Vector512<ulong> right) {
                //Vector512<long> mid = Vector512s<long>.MinValue;
                Vector512<long> mid = Vector512Constants.Int64_MinValue;
                Vector512<long> left2 = Avx512.Xor(left.AsInt64(), mid);
                Vector512<long> right2 = Avx512.Xor(right.AsInt64(), mid);
                Vector512<long> mask = Avx512.CompareGreaterThan(right2, left2);
                Vector512<ulong> rt = Avx512.BlendVariable(right, left, mask.AsUInt64());
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.Multiply_AcceleratedTypes"/>
            public static TypeCodeFlags Multiply_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
#if HARDWARE_OPTIMIZATION
                    rt |= TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
#endif // HARDWARE_OPTIMIZATION
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.Multiply_FullAcceleratedTypes"/>
            public static TypeCodeFlags Multiply_FullAcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Multiply(Vector512<float> left, Vector512<float> right) {
                return Avx.Multiply(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Multiply(Vector512<double> left, Vector512<double> right) {
                return Avx.Multiply(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> Multiply(Vector512<sbyte> left, Vector512<sbyte> right) {
#if HARDWARE_OPTIMIZATION
                return Multiply_Widen(left, right);
#else
                return SuperStatics.Multiply(left, right);
#endif // HARDWARE_OPTIMIZATION
            }

            /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> Multiply(Vector512<byte> left, Vector512<byte> right) {
#if HARDWARE_OPTIMIZATION
                return Multiply_Widen(left, right);
#else
                return SuperStatics.Multiply(left, right);
#endif // HARDWARE_OPTIMIZATION
            }

            /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> Multiply(Vector512<short> left, Vector512<short> right) {
                return Avx512.MultiplyLow(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> Multiply(Vector512<ushort> left, Vector512<ushort> right) {
                return Avx512.MultiplyLow(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> Multiply(Vector512<int> left, Vector512<int> right) {
                return Avx512.MultiplyLow(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> Multiply(Vector512<uint> left, Vector512<uint> right) {
                return Avx512.MultiplyLow(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> Multiply(Vector512<long> left, Vector512<long> right) {
#if HARDWARE_OPTIMIZATION
                return Multiply_TwoWord(left, right);
#else
                return SuperStatics.Multiply(left, right);
#endif // HARDWARE_OPTIMIZATION
            }

            /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> Multiply(Vector512<ulong> left, Vector512<ulong> right) {
#if HARDWARE_OPTIMIZATION
                return Multiply_TwoWord(left, right);
#else
                return SuperStatics.Multiply(left, right);
#endif // HARDWARE_OPTIMIZATION
            }

            /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> Multiply_TwoWord(Vector512<long> left, Vector512<long> right) {
                return Multiply_TwoWord(left.AsUInt64(), right.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> Multiply_TwoWord(Vector512<ulong> left, Vector512<ulong> right) {
                const int L = 32; // sizeof(uint) * 8;
                //const ulong MASK_VALUE = (1L << L) - 1;
                //Vector512<ulong> mask = Vector512.Create(MASK_VALUE);
                Vector512<ulong> mask = Vector512Constants.Int64_VMaxUInt32.AsUInt64();
                Vector512<ulong> w0;
                Vector512<ulong> u1, v1, w1, low;
                // u=left; v=right;
                //u0 = u & MASK_VALUE; u1 = u >> L;
                //v0 = v & MASK_VALUE; v1 = v >> L;
                u1 = Avx512.ShiftRightLogical(left, L);
                v1 = Avx512.ShiftRightLogical(right, L);
                // u*v = (u1*v1)<<(2*L) + (u0*v1)<<L + (u1*v0)<<L + u0*v0
                // Part1 = u0*v0
                //w0 = u0 * v0;
                w0 = Avx512.Multiply(left.AsUInt32(), right.AsUInt32());
                // Part2 = (u1*v0)<<L + Part1
                //w1 = u1 * v0 + (w0 >> L);
                w1 = Avx512.Add(Avx512.Multiply(u1.AsUInt32(), right.AsUInt32())
                    , Avx512.ShiftRightLogical(w0, L));
                // Part3 = (u0*v1)<<L + Part2
                //w1 = u0 * v1 + w1;
                //low = (w1 << L) + (w0 & MASK_VALUE);
                w1 = Avx512.Add(w1
                    , Avx512.Multiply(left.AsUInt32(), v1.AsUInt32()));
                low = Avx512.Or(Avx512.ShiftLeftLogical(w1, L)
                    , Avx512.And(w0, mask));
                return low;
            }

            /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> Multiply_Widen(Vector512<sbyte> left, Vector512<sbyte> right) {
                return Multiply_Widen(left.AsByte(), right.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> Multiply_Widen(Vector512<byte> left, Vector512<byte> right) {
                Widen(left, out Vector512<ushort> u0, out Vector512<ushort> u1);
                Widen(right, out Vector512<ushort> v0, out Vector512<ushort> v1);
                Vector512<ushort> w0 = Multiply(u0, v0);
                Vector512<ushort> w1 = Multiply(u1, v1);
                Vector512<byte> rt = Narrow(w0, w1);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.Negate_AcceleratedTypes"/>
            public static TypeCodeFlags Negate_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.Negate(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Negate(Vector512<float> value) {
                return Avx.Subtract(Vector512<float>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits512.Negate(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Negate(Vector512<double> value) {
                return Avx.Subtract(Vector512<double>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits512.Negate(Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> Negate(Vector512<sbyte> value) {
                return Avx512.Subtract(Vector512<sbyte>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits512.Negate(Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> Negate(Vector512<short> value) {
                return Avx512.Subtract(Vector512<short>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits512.Negate(Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> Negate(Vector512<int> value) {
                return Avx512.Subtract(Vector512<int>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits512.Negate(Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> Negate(Vector512<long> value) {
                return Avx512.Subtract(Vector512<long>.Zero, value);
            }


            /// <inheritdoc cref="IWVectorTraits512.OnesComplement_AcceleratedTypes"/>
            public static TypeCodeFlags OnesComplement_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.OnesComplement{T}(Vector512{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<T> OnesComplement<T>(Vector512<T> vector) where T : struct {
                return Avx512.Xor(Vector512s<ulong>.AllBitsSet, vector.AsUInt64()).As<ulong, T>();
            }


            /// <inheritdoc cref="IWVectorTraits512.Sqrt_AcceleratedTypes"/>
            public static TypeCodeFlags Sqrt_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Sqrt(Vector512<float> value) {
                return Avx.Sqrt(value);
            }

            /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Sqrt(Vector512<double> value) {
                return Avx.Sqrt(value);
            }

            /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> Sqrt(Vector512<sbyte> value) {
                Vector512<sbyte> mask = GreaterThan(Vector512<sbyte>.Zero, value); // 0>x = x<0.
                Vector512<sbyte> temp = Sqrt(value.AsByte()).AsSByte();
                Vector512<sbyte> rt = AndNot(temp, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> Sqrt(Vector512<byte> value) {
                // To float
                Widen(value, out Vector512<ushort> t0, out Vector512<ushort> t1);
                Widen(t0, out Vector512<uint> w0, out Vector512<uint> w1);
                Widen(t1, out Vector512<uint> w2, out Vector512<uint> w3);
                Vector512<float> src0 = ConvertToSingle(w0.AsInt32()); // On x86 platforms, Int32 typically has special instructions to speed up, which is faster than UInt32.
                Vector512<float> src1 = ConvertToSingle(w1.AsInt32());
                Vector512<float> src2 = ConvertToSingle(w2.AsInt32());
                Vector512<float> src3 = ConvertToSingle(w3.AsInt32());
                // Body
                Vector512<float> dst0 = Avx.Sqrt(src0);
                Vector512<float> dst1 = Avx.Sqrt(src1);
                Vector512<float> dst2 = Avx.Sqrt(src2);
                Vector512<float> dst3 = Avx.Sqrt(src3);
                // To int
                w0 = ConvertToInt32(dst0).AsUInt32();
                w1 = ConvertToInt32(dst1).AsUInt32();
                w2 = ConvertToInt32(dst2).AsUInt32();
                w3 = ConvertToInt32(dst3).AsUInt32();
                t0 = Narrow(w0, w1);
                t1 = Narrow(w2, w3);
                Vector512<byte> rt = Narrow(t0, t1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> Sqrt(Vector512<short> value) {
                Vector512<short> mask = GreaterThan(Vector512<short>.Zero, value); // 0>x = x<0.
                Vector512<short> temp = Sqrt(value.AsUInt16()).AsInt16();
                Vector512<short> rt = AndNot(temp, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> Sqrt(Vector512<ushort> value) {
                // To float
                Widen(value, out Vector512<uint> w0, out Vector512<uint> w1);
                Vector512<float> src0 = ConvertToSingle(w0.AsInt32());
                Vector512<float> src1 = ConvertToSingle(w1.AsInt32());
                // Body
                Vector512<float> dst0 = Avx.Sqrt(src0);
                Vector512<float> dst1 = Avx.Sqrt(src1);
                // To int
                w0 = ConvertToInt32(dst0).AsUInt32();
                w1 = ConvertToInt32(dst1).AsUInt32();
                Vector512<ushort> rt = Narrow(w0, w1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> Sqrt(Vector512<int> value) {
                Vector512<int> mask = GreaterThan(Vector512<int>.Zero, value); // 0>x = x<0.
                Vector512<int> temp = Sqrt(value.AsUInt32()).AsInt32();
                Vector512<int> rt = AndNot(temp, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> Sqrt(Vector512<uint> value) {
                // To float
                Widen(value, out Vector512<ulong> w0, out Vector512<ulong> w1);
                Vector512<double> src0 = ConvertToDouble_Range52(w0);
                Vector512<double> src1 = ConvertToDouble_Range52(w1);
                // Body
                Vector512<double> dst0 = Avx.Sqrt(src0);
                Vector512<double> dst1 = Avx.Sqrt(src1);
                // To int
                w0 = ConvertToUInt64_Range52(dst0);
                w1 = ConvertToUInt64_Range52(dst1);
                Vector512<uint> rt = Narrow(w0, w1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> Sqrt(Vector512<long> value) {
                Vector512<long> mask = GreaterThan(Vector512<long>.Zero, value); // 0>x = x<0.
                Vector512<long> temp = Sqrt(value.AsUInt64()).AsInt64();
                Vector512<long> rt = AndNot(temp, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> Sqrt(Vector512<ulong> value) {
                // To float
                Vector512<double> src0 = ConvertToDouble(value);
                // Body
                Vector512<double> dst0 = Avx.Sqrt(src0);
                // To int
                Vector512<ulong> rt = ConvertToUInt64_Range52(dst0);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.Subtract_AcceleratedTypes"/>
            public static TypeCodeFlags Subtract_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Subtract(Vector512<float> left, Vector512<float> right) {
                return Avx.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Subtract(Vector512<double> left, Vector512<double> right) {
                return Avx.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> Subtract(Vector512<sbyte> left, Vector512<sbyte> right) {
                return Avx512.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> Subtract(Vector512<byte> left, Vector512<byte> right) {
                return Avx512.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> Subtract(Vector512<short> left, Vector512<short> right) {
                return Avx512.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> Subtract(Vector512<ushort> left, Vector512<ushort> right) {
                return Avx512.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> Subtract(Vector512<int> left, Vector512<int> right) {
                return Avx512.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> Subtract(Vector512<uint> left, Vector512<uint> right) {
                return Avx512.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> Subtract(Vector512<long> left, Vector512<long> right) {
                return Avx512.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> Subtract(Vector512<ulong> left, Vector512<ulong> right) {
                return Avx512.Subtract(left, right);
            }


            /// <inheritdoc cref="IWVectorTraits512.Xor_AcceleratedTypes"/>
            public static TypeCodeFlags Xor_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.Xor{T}(Vector512{T}, Vector512{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<T> Xor<T>(Vector512<T> left, Vector512<T> right) where T : struct {
                return Avx512.Xor(left.AsUInt64(), right.AsUInt64()).As<ulong, T>();
            }

*/
#endif // NET8_0_OR_GREATER
        }
    }
}