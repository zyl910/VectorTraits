﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
#endif

namespace Zyl.VectorTraits.Impl.AVector128 {
    using SuperStatics = WVectorTraits128Base.Statics;

    partial class WVectorTraits128Sse {

        partial class Statics {

#if NETCOREAPP3_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.Abs_AcceleratedTypes"/>
            public static TypeCodeFlags Abs_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Abs(Vector128<float> value) {
                var mask = Vector128Constants.Single_NonSignMask;
                return Avx.And(mask, value);
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Abs(Vector128<double> value) {
                var mask = Vector128Constants.Double_NonSignMask;
                return Avx.And(mask, value);
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Abs(Vector128<sbyte> value) {
                return Avx2.Abs(value).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Abs(Vector128<short> value) {
                return Avx2.Abs(value).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Abs(Vector128<int> value) {
                return Avx2.Abs(value).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Abs(Vector128<long> value) {
                // If an integer value is positive or zero, no action is required. Otherwise complement and add 1.
                Vector128<long> mask = Avx2.CompareGreaterThan(Vector128<long>.Zero, value); // 0>value => value<0
                Vector128<long> rt = Avx2.Subtract(Avx2.Xor(value, mask), mask); // -x => (~x)+1 => (~x)-(-1) = (x^mask)-mask .
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.Add_AcceleratedTypes"/>
            public static TypeCodeFlags Add_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Add(Vector128<float> left, Vector128<float> right) {
                return Avx.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Add(Vector128<double> left, Vector128<double> right) {
                return Avx.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Add(Vector128<sbyte> left, Vector128<sbyte> right) {
                return Avx2.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Add(Vector128<byte> left, Vector128<byte> right) {
                return Avx2.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Add(Vector128<short> left, Vector128<short> right) {
                return Avx2.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Add(Vector128<ushort> left, Vector128<ushort> right) {
                return Avx2.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Add(Vector128<int> left, Vector128<int> right) {
                return Avx2.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Add(Vector128<uint> left, Vector128<uint> right) {
                return Avx2.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Add(Vector128<long> left, Vector128<long> right) {
                return Avx2.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Add(Vector128<ulong> left, Vector128<ulong> right) {
                return Avx2.Add(left, right);
            }


            /// <inheritdoc cref="IWVectorTraits128.AndNot_AcceleratedTypes"/>
            public static TypeCodeFlags AndNot_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.AndNot{T}(Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> AndNot<T>(Vector128<T> left, Vector128<T> right) where T : struct {
                // __m128i _mm128_andnot_si128 (__m128i a, __m128i b)
                // #include <immintrin.h>
                // Instruction: vpandn ymm, ymm, ymm
                // CPUID Flags: AVX2
                // Description
                // Compute the bitwise NOT of 128 bits (representing integer data) in a and then AND with b, and store the result in dst.
                // Operation
                // dst[255:0] := ((NOT a[255:0]) AND b[255:0])
                return Avx2.AndNot(right.AsUInt64(), left.AsUInt64()).As<ulong, T>();
            }


            /// <inheritdoc cref="IWVectorTraits128.BitwiseAnd_AcceleratedTypes"/>
            public static TypeCodeFlags BitwiseAnd_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.BitwiseAnd{T}(Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> BitwiseAnd<T>(Vector128<T> left, Vector128<T> right) where T : struct {
                return Avx2.And(left.AsUInt64(), right.AsUInt64()).As<ulong, T>();
            }


            /// <inheritdoc cref="IWVectorTraits128.BitwiseOr_AcceleratedTypes"/>
            public static TypeCodeFlags BitwiseOr_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.BitwiseOr{T}(Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> BitwiseOr<T>(Vector128<T> left, Vector128<T> right) where T : struct {
                return Avx2.Or(left.AsUInt64(), right.AsUInt64()).As<ulong, T>();
            }


            /// <inheritdoc cref="IWVectorTraits128.ConditionalSelect_AcceleratedTypes"/>
            public static TypeCodeFlags ConditionalSelect_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ConditionalSelect{T}(Vector128{T}, Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> ConditionalSelect<T>(Vector128<T> condition, Vector128<T> left, Vector128<T> right) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ConditionalSelect(condition, left, right);
#else
                return ConditionalSelect_OrAnd(condition, left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.ConditionalSelect{T}(Vector128{T}, Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> ConditionalSelect_OrAnd<T>(Vector128<T> condition, Vector128<T> left, Vector128<T> right) where T : struct {
                // result = (left & condition) | (right & ~condition);
                return Avx2.Or(Avx2.And(condition.AsUInt64(), left.AsUInt64())
                    , Avx2.AndNot(condition.AsUInt64(), right.AsUInt64())
                    ).As<ulong, T>();
            }


            /// <inheritdoc cref="IWVectorTraits128.Divide_AcceleratedTypes"/>
            public static TypeCodeFlags Divide_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Single | TypeCodeFlags.Double;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Divide(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Divide(Vector128<float> left, Vector128<float> right) {
                return Avx.Divide(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Divide(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Divide(Vector128<double> left, Vector128<double> right) {
                return Avx.Divide(left, right);
            }


            /// <inheritdoc cref="IWVectorTraits128.GreaterThan_AcceleratedTypes"/>
            public static TypeCodeFlags GreaterThan_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> GreaterThan(Vector128<float> left, Vector128<float> right) {
#if NET5_0_OR_GREATER
                return Avx.CompareGreaterThan(left, right);
#else
                return Avx.Compare(left, right, FloatComparisonMode.OrderedGreaterThanSignaling);
#endif // NET5_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> GreaterThan(Vector128<double> left, Vector128<double> right) {
#if NET5_0_OR_GREATER
                return Avx.CompareGreaterThan(left, right);
#else
                return Avx.Compare(left, right, FloatComparisonMode.OrderedGreaterThanSignaling);
#endif // NET5_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> GreaterThan(Vector128<sbyte> left, Vector128<sbyte> right) {
                return Avx2.CompareGreaterThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> GreaterThan(Vector128<byte> left, Vector128<byte> right) {
                //Vector128<sbyte> mid = Vector128s<sbyte>.MinValue;
                Vector128<sbyte> mid = Vector128.Create(sbyte.MinValue); // .NET5+ has better performance .
                Vector128<sbyte> left2 = Avx2.Xor(left.AsSByte(), mid);
                Vector128<sbyte> right2 = Avx2.Xor(right.AsSByte(), mid);
                Vector128<sbyte> mask = Avx2.CompareGreaterThan(left2, right2);
                return mask.AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> GreaterThan(Vector128<short> left, Vector128<short> right) {
                return Avx2.CompareGreaterThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> GreaterThan(Vector128<ushort> left, Vector128<ushort> right) {
                //Vector128<short> mid = Vector128s<short>.MinValue;
                Vector128<short> mid = Vector128.Create(short.MinValue); // .NET5+ has better performance .
                Vector128<short> left2 = Avx2.Xor(left.AsInt16(), mid);
                Vector128<short> right2 = Avx2.Xor(right.AsInt16(), mid);
                Vector128<short> mask = Avx2.CompareGreaterThan(left2, right2);
                return mask.AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> GreaterThan(Vector128<int> left, Vector128<int> right) {
                return Avx2.CompareGreaterThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> GreaterThan(Vector128<uint> left, Vector128<uint> right) {
                //Vector128<int> mid = Vector128s<int>.MinValue;
                Vector128<int> mid = Vector128.Create(int.MinValue); // .NET5+ has better performance .
                Vector128<int> left2 = Avx2.Xor(left.AsInt32(), mid);
                Vector128<int> right2 = Avx2.Xor(right.AsInt32(), mid);
                Vector128<int> mask = Avx2.CompareGreaterThan(left2, right2);
                return mask.AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> GreaterThan(Vector128<long> left, Vector128<long> right) {
                Vector128<long> mask = Avx2.CompareGreaterThan(left, right);
                return mask;
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> GreaterThan(Vector128<ulong> left, Vector128<ulong> right) {
                //Vector128<long> mid = Vector128s<long>.MinValue;
                Vector128<long> mid = Vector128Constants.Int64_MinValue;
                Vector128<long> left2 = Avx2.Add(left.AsInt64(), mid);
                Vector128<long> right2 = Avx2.Add(right.AsInt64(), mid);
                Vector128<long> mask = Avx2.CompareGreaterThan(left2, right2);
                return mask.AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits128.LessThan_AcceleratedTypes"/>
            public static TypeCodeFlags LessThan_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> LessThan(Vector128<float> left, Vector128<float> right) {
#if NET5_0_OR_GREATER
                return Avx.CompareLessThan(left, right);
#else
                return Avx.Compare(left, right, FloatComparisonMode.OrderedLessThanSignaling);
#endif // NET5_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> LessThan(Vector128<double> left, Vector128<double> right) {
#if NET5_0_OR_GREATER
                return Avx.CompareLessThan(left, right);
#else
                return Avx.Compare(left, right, FloatComparisonMode.OrderedLessThanSignaling);
#endif // NET5_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> LessThan(Vector128<sbyte> left, Vector128<sbyte> right) {
                return Avx2.CompareGreaterThan(right, left);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> LessThan(Vector128<byte> left, Vector128<byte> right) {
                //Vector128<sbyte> mid = Vector128s<sbyte>.MinValue;
                Vector128<sbyte> mid = Vector128.Create(sbyte.MinValue); // .NET5+ has better performance .
                Vector128<sbyte> left2 = Avx2.Xor(left.AsSByte(), mid);
                Vector128<sbyte> right2 = Avx2.Xor(right.AsSByte(), mid);
                Vector128<sbyte> mask = Avx2.CompareGreaterThan(right2, left2);
                return mask.AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> LessThan(Vector128<short> left, Vector128<short> right) {
                return Avx2.CompareGreaterThan(right, left);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> LessThan(Vector128<ushort> left, Vector128<ushort> right) {
                //Vector128<short> mid = Vector128s<short>.MinValue;
                Vector128<short> mid = Vector128.Create(short.MinValue); // .NET5+ has better performance .
                Vector128<short> left2 = Avx2.Xor(left.AsInt16(), mid);
                Vector128<short> right2 = Avx2.Xor(right.AsInt16(), mid);
                Vector128<short> mask = Avx2.CompareGreaterThan(right2, left2);
                return mask.AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> LessThan(Vector128<int> left, Vector128<int> right) {
                return Avx2.CompareGreaterThan(right, left);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> LessThan(Vector128<uint> left, Vector128<uint> right) {
                //Vector128<int> mid = Vector128s<int>.MinValue;
                Vector128<int> mid = Vector128.Create(int.MinValue); // .NET5+ has better performance .
                Vector128<int> left2 = Avx2.Xor(left.AsInt32(), mid);
                Vector128<int> right2 = Avx2.Xor(right.AsInt32(), mid);
                Vector128<int> mask = Avx2.CompareGreaterThan(right2, left2);
                return mask.AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> LessThan(Vector128<long> left, Vector128<long> right) {
                return Avx2.CompareGreaterThan(right, left);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> LessThan(Vector128<ulong> left, Vector128<ulong> right) {
                //Vector128<long> mid = Vector128s<long>.MinValue;
                Vector128<long> mid = Vector128Constants.Int64_MinValue;
                Vector128<long> left2 = Avx2.Add(mid, left.AsInt64());
                Vector128<long> right2 = Avx2.Add(mid, right.AsInt64());
                Vector128<long> mask = Avx2.CompareGreaterThan(right2, left2);
                return mask.AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits128.Max_AcceleratedTypes"/>
            public static TypeCodeFlags Max_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Max(Vector128<float> left, Vector128<float> right) {
                return Avx.Max(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Max(Vector128<double> left, Vector128<double> right) {
                return Avx.Max(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Max(Vector128<sbyte> left, Vector128<sbyte> right) {
                return Avx2.Max(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Max(Vector128<byte> left, Vector128<byte> right) {
                return Avx2.Max(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Max(Vector128<short> left, Vector128<short> right) {
                return Avx2.Max(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Max(Vector128<ushort> left, Vector128<ushort> right) {
                return Avx2.Max(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Max(Vector128<int> left, Vector128<int> right) {
                return Avx2.Max(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Max(Vector128<uint> left, Vector128<uint> right) {
                return Avx2.Max(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Max(Vector128<long> left, Vector128<long> right) {
                Vector128<long> mask = Avx2.CompareGreaterThan(left, right);
                Vector128<long> rt = Avx2.BlendVariable(right, left, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Max(Vector128<ulong> left, Vector128<ulong> right) {
                //Vector128<long> mid = Vector128s<long>.MinValue;
                Vector128<long> mid = Vector128Constants.Int64_MinValue;
                Vector128<long> left2 = Avx2.Xor(left.AsInt64(), mid);
                Vector128<long> right2 = Avx2.Xor(right.AsInt64(), mid);
                Vector128<long> mask = Avx2.CompareGreaterThan(left2, right2);
                Vector128<ulong> rt = Avx2.BlendVariable(right, left, mask.AsUInt64());
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.Min_AcceleratedTypes"/>
            public static TypeCodeFlags Min_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Min(Vector128<float> left, Vector128<float> right) {
                return Avx.Min(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Min(Vector128<double> left, Vector128<double> right) {
                return Avx.Min(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Min(Vector128<sbyte> left, Vector128<sbyte> right) {
                return Avx2.Min(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Min(Vector128<byte> left, Vector128<byte> right) {
                return Avx2.Min(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Min(Vector128<short> left, Vector128<short> right) {
                return Avx2.Min(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Min(Vector128<ushort> left, Vector128<ushort> right) {
                return Avx2.Min(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Min(Vector128<int> left, Vector128<int> right) {
                return Avx2.Min(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Min(Vector128<uint> left, Vector128<uint> right) {
                return Avx2.Min(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Min(Vector128<long> left, Vector128<long> right) {
                Vector128<long> mask = Avx2.CompareGreaterThan(right, left);
                Vector128<long> rt = Avx2.BlendVariable(right, left, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Min(Vector128<ulong> left, Vector128<ulong> right) {
                //Vector128<long> mid = Vector128s<long>.MinValue;
                Vector128<long> mid = Vector128Constants.Int64_MinValue;
                Vector128<long> left2 = Avx2.Xor(left.AsInt64(), mid);
                Vector128<long> right2 = Avx2.Xor(right.AsInt64(), mid);
                Vector128<long> mask = Avx2.CompareGreaterThan(right2, left2);
                Vector128<ulong> rt = Avx2.BlendVariable(right, left, mask.AsUInt64());
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.Multiply_AcceleratedTypes"/>
            public static TypeCodeFlags Multiply_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
#if HARDWARE_OPTIMIZATION
                    rt |= TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
#endif // HARDWARE_OPTIMIZATION
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply_FullAcceleratedTypes"/>
            public static TypeCodeFlags Multiply_FullAcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Multiply(Vector128<float> left, Vector128<float> right) {
                return Avx.Multiply(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Multiply(Vector128<double> left, Vector128<double> right) {
                return Avx.Multiply(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Multiply(Vector128<sbyte> left, Vector128<sbyte> right) {
#if HARDWARE_OPTIMIZATION
                return Multiply_Widen(left, right);
#else
                return SuperStatics.Multiply(left, right);
#endif // HARDWARE_OPTIMIZATION
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Multiply(Vector128<byte> left, Vector128<byte> right) {
#if HARDWARE_OPTIMIZATION
                return Multiply_Widen(left, right);
#else
                return SuperStatics.Multiply(left, right);
#endif // HARDWARE_OPTIMIZATION
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Multiply(Vector128<short> left, Vector128<short> right) {
                return Avx2.MultiplyLow(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Multiply(Vector128<ushort> left, Vector128<ushort> right) {
                return Avx2.MultiplyLow(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Multiply(Vector128<int> left, Vector128<int> right) {
                return Avx2.MultiplyLow(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Multiply(Vector128<uint> left, Vector128<uint> right) {
                return Avx2.MultiplyLow(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Multiply(Vector128<long> left, Vector128<long> right) {
#if HARDWARE_OPTIMIZATION
                return Multiply_TwoWord(left, right);
#else
                return SuperStatics.Multiply(left, right);
#endif // HARDWARE_OPTIMIZATION
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Multiply(Vector128<ulong> left, Vector128<ulong> right) {
#if HARDWARE_OPTIMIZATION
                return Multiply_TwoWord(left, right);
#else
                return SuperStatics.Multiply(left, right);
#endif // HARDWARE_OPTIMIZATION
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Multiply_TwoWord(Vector128<long> left, Vector128<long> right) {
                return Multiply_TwoWord(left.AsUInt64(), right.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Multiply_TwoWord(Vector128<ulong> left, Vector128<ulong> right) {
                const int L = 32; // sizeof(uint) * 8;
                //const ulong MASK_VALUE = (1L << L) - 1;
                //Vector128<ulong> mask = Vector128.Create(MASK_VALUE);
                Vector128<ulong> mask = Vector128Constants.Int64_VMaxUInt32.AsUInt64();
                Vector128<ulong> w0;
                Vector128<ulong> u1, v1, w1, low;
                // u=left; v=right;
                //u0 = u & MASK_VALUE; u1 = u >> L;
                //v0 = v & MASK_VALUE; v1 = v >> L;
                u1 = Avx2.ShiftRightLogical(left, L);
                v1 = Avx2.ShiftRightLogical(right, L);
                // u*v = (u1*v1)<<(2*L) + (u0*v1)<<L + (u1*v0)<<L + u0*v0
                // Part1 = u0*v0
                //w0 = u0 * v0;
                w0 = Avx2.Multiply(left.AsUInt32(), right.AsUInt32());
                // Part2 = (u1*v0)<<L + Part1
                //w1 = u1 * v0 + (w0 >> L);
                w1 = Avx2.Add(Avx2.Multiply(u1.AsUInt32(), right.AsUInt32())
                    , Avx2.ShiftRightLogical(w0, L));
                // Part3 = (u0*v1)<<L + Part2
                //w1 = u0 * v1 + w1;
                //low = (w1 << L) + (w0 & MASK_VALUE);
                w1 = Avx2.Add(w1
                    , Avx2.Multiply(left.AsUInt32(), v1.AsUInt32()));
                low = Avx2.Or(Avx2.ShiftLeftLogical(w1, L)
                    , Avx2.And(w0, mask));
                return low;
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Multiply_Widen(Vector128<sbyte> left, Vector128<sbyte> right) {
                return Multiply_Widen(left.AsByte(), right.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Multiply_Widen(Vector128<byte> left, Vector128<byte> right) {
                Widen(left, out Vector128<ushort> u0, out Vector128<ushort> u1);
                Widen(right, out Vector128<ushort> v0, out Vector128<ushort> v1);
                Vector128<ushort> w0 = Multiply(u0, v0);
                Vector128<ushort> w1 = Multiply(u1, v1);
                Vector128<byte> rt = Narrow(w0, w1);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.Negate_AcceleratedTypes"/>
            public static TypeCodeFlags Negate_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Negate(Vector128<float> value) {
                return Avx.Subtract(Vector128<float>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Negate(Vector128<double> value) {
                return Avx.Subtract(Vector128<double>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Negate(Vector128<sbyte> value) {
                return Avx2.Subtract(Vector128<sbyte>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Negate(Vector128<short> value) {
                return Avx2.Subtract(Vector128<short>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Negate(Vector128<int> value) {
                return Avx2.Subtract(Vector128<int>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Negate(Vector128<long> value) {
                return Avx2.Subtract(Vector128<long>.Zero, value);
            }


            /// <inheritdoc cref="IWVectorTraits128.OnesComplement_AcceleratedTypes"/>
            public static TypeCodeFlags OnesComplement_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.OnesComplement{T}(Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> OnesComplement<T>(Vector128<T> vector) where T : struct {
                return Avx2.Xor(Vector128s<ulong>.AllBitsSet, vector.AsUInt64()).As<ulong, T>();
            }


            /// <inheritdoc cref="IWVectorTraits128.Subtract_AcceleratedTypes"/>
            public static TypeCodeFlags Subtract_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Subtract(Vector128<float> left, Vector128<float> right) {
                return Avx.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Subtract(Vector128<double> left, Vector128<double> right) {
                return Avx.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Subtract(Vector128<sbyte> left, Vector128<sbyte> right) {
                return Avx2.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Subtract(Vector128<byte> left, Vector128<byte> right) {
                return Avx2.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Subtract(Vector128<short> left, Vector128<short> right) {
                return Avx2.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Subtract(Vector128<ushort> left, Vector128<ushort> right) {
                return Avx2.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Subtract(Vector128<int> left, Vector128<int> right) {
                return Avx2.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Subtract(Vector128<uint> left, Vector128<uint> right) {
                return Avx2.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Subtract(Vector128<long> left, Vector128<long> right) {
                return Avx2.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Subtract(Vector128<ulong> left, Vector128<ulong> right) {
                return Avx2.Subtract(left, right);
            }


            /// <inheritdoc cref="IWVectorTraits128.Xor_AcceleratedTypes"/>
            public static TypeCodeFlags Xor_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Xor{T}(Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> Xor<T>(Vector128<T> left, Vector128<T> right) where T : struct {
                return Avx2.Xor(left.AsUInt64(), right.AsUInt64()).As<ulong, T>();
            }


#endif // NETCOREAPP3_0_OR_GREATER
            }
    }
}