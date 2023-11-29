using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
#endif

namespace Zyl.VectorTraits.Impl.AVector256 {
    using SuperStatics = WVectorTraits256Base.Statics;

    partial class WVectorTraits256Avx2 {

        partial class Statics {

#if NETCOREAPP3_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.Abs_AcceleratedTypes"/>
            public static TypeCodeFlags Abs_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Abs(Vector256<float> value) {
                var mask = Vector256Constants.Single_NonSignMask;
                return Avx.And(mask, value);
            }

            /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Abs(Vector256<double> value) {
                var mask = Vector256Constants.Double_NonSignMask;
                return Avx.And(mask, value);
            }

            /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Abs(Vector256<sbyte> value) {
                return Avx2.Abs(value).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Abs(Vector256<short> value) {
                return Avx2.Abs(value).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Abs(Vector256<int> value) {
                return Avx2.Abs(value).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> Abs(Vector256<long> value) {
                // If an integer value is positive or zero, no action is required. Otherwise complement and add 1.
                Vector256<long> mask = Avx2.CompareGreaterThan(Vector256<long>.Zero, value); // 0>value => value<0
                Vector256<long> rt = Avx2.Subtract(Avx2.Xor(value, mask), mask); // -x => (~x)+1 => (~x)-(-1) = (x^mask)-mask .
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.Add_AcceleratedTypes"/>
            public static TypeCodeFlags Add_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Add(Vector256<float> left, Vector256<float> right) {
                return Avx.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Add(Vector256<double> left, Vector256<double> right) {
                return Avx.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Add(Vector256<sbyte> left, Vector256<sbyte> right) {
                return Avx2.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> Add(Vector256<byte> left, Vector256<byte> right) {
                return Avx2.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Add(Vector256<short> left, Vector256<short> right) {
                return Avx2.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> Add(Vector256<ushort> left, Vector256<ushort> right) {
                return Avx2.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Add(Vector256<int> left, Vector256<int> right) {
                return Avx2.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> Add(Vector256<uint> left, Vector256<uint> right) {
                return Avx2.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> Add(Vector256<long> left, Vector256<long> right) {
                return Avx2.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> Add(Vector256<ulong> left, Vector256<ulong> right) {
                return Avx2.Add(left, right);
            }


            /// <inheritdoc cref="IWVectorTraits256.AndNot_AcceleratedTypes"/>
            public static TypeCodeFlags AndNot_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.AndNot{T}(Vector256{T}, Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<T> AndNot<T>(Vector256<T> left, Vector256<T> right) where T : struct {
                // __m256i _mm256_andnot_si256 (__m256i a, __m256i b)
                // #include <immintrin.h>
                // Instruction: vpandn ymm, ymm, ymm
                // CPUID Flags: AVX2
                // Description
                // Compute the bitwise NOT of 256 bits (representing integer data) in a and then AND with b, and store the result in dst.
                // Operation
                // dst[255:0] := ((NOT a[255:0]) AND b[255:0])
                return Avx2.AndNot(right.AsUInt64(), left.AsUInt64()).As<ulong, T>();
            }


            /// <inheritdoc cref="IWVectorTraits256.BitwiseAnd_AcceleratedTypes"/>
            public static TypeCodeFlags BitwiseAnd_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.BitwiseAnd{T}(Vector256{T}, Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<T> BitwiseAnd<T>(Vector256<T> left, Vector256<T> right) where T : struct {
                return Avx2.And(left.AsUInt64(), right.AsUInt64()).As<ulong, T>();
            }


            /// <inheritdoc cref="IWVectorTraits256.BitwiseOr_AcceleratedTypes"/>
            public static TypeCodeFlags BitwiseOr_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.BitwiseOr{T}(Vector256{T}, Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<T> BitwiseOr<T>(Vector256<T> left, Vector256<T> right) where T : struct {
                return Avx2.Or(left.AsUInt64(), right.AsUInt64()).As<ulong, T>();
            }


            /// <inheritdoc cref="IWVectorTraits256.ConditionalSelect_AcceleratedTypes"/>
            public static TypeCodeFlags ConditionalSelect_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.ConditionalSelect{T}(Vector256{T}, Vector256{T}, Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<T> ConditionalSelect<T>(Vector256<T> condition, Vector256<T> left, Vector256<T> right) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ConditionalSelect(condition, left, right);
#else
                return ConditionalSelect_OrAnd(condition, left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.ConditionalSelect{T}(Vector256{T}, Vector256{T}, Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<T> ConditionalSelect_OrAnd<T>(Vector256<T> condition, Vector256<T> left, Vector256<T> right) where T : struct {
                // result = (left & condition) | (right & ~condition);
                return Avx2.Or(Avx2.And(condition.AsUInt64(), left.AsUInt64())
                    , Avx2.AndNot(condition.AsUInt64(), right.AsUInt64())
                    ).As<ulong, T>();
            }


            /// <inheritdoc cref="IWVectorTraits256.Divide_AcceleratedTypes"/>
            public static TypeCodeFlags Divide_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Single | TypeCodeFlags.Double;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Divide(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Divide(Vector256<float> left, Vector256<float> right) {
                return Avx.Divide(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Divide(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Divide(Vector256<double> left, Vector256<double> right) {
                return Avx.Divide(left, right);
            }


            /// <inheritdoc cref="IWVectorTraits256.Dot_AcceleratedTypes"/>
            public static TypeCodeFlags Dot_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = Multiply_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Dot(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float Dot(Vector256<float> left, Vector256<float> right) {
                Vector256<float> temp = Avx.Multiply(left, right);
                return Sum(temp);
            }

            /// <inheritdoc cref="IWVectorTraits256.Dot(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static double Dot(Vector256<double> left, Vector256<double> right) {
                Vector256<double> temp = Avx.Multiply(left, right);
                return Sum(temp);
            }

            /// <inheritdoc cref="IWVectorTraits256.Dot(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static sbyte Dot(Vector256<sbyte> left, Vector256<sbyte> right) {
                return (sbyte)Dot(left.AsByte(), right.AsByte());
            }

            /// <inheritdoc cref="IWVectorTraits256.Dot(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static byte Dot(Vector256<byte> left, Vector256<byte> right) {
                Widen(left, out Vector256<ushort> u0, out Vector256<ushort> u1);
                Widen(right, out Vector256<ushort> v0, out Vector256<ushort> v1);
                Vector256<ushort> w0 = Avx2.MultiplyLow(u0, v0);
                Vector256<ushort> w1 = Avx2.MultiplyLow(u1, v1);
                w0 = Avx2.Add(w0, w1);
                return (byte)Sum(w0);
            }

            /// <inheritdoc cref="IWVectorTraits256.Dot(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static short Dot(Vector256<short> left, Vector256<short> right) {
                Vector256<short> temp = Avx2.MultiplyLow(left, right);
                return Sum(temp);
            }

            /// <inheritdoc cref="IWVectorTraits256.Dot(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ushort Dot(Vector256<ushort> left, Vector256<ushort> right) {
                Vector256<ushort> temp = Avx2.MultiplyLow(left, right);
                return Sum(temp);
            }

            /// <inheritdoc cref="IWVectorTraits256.Dot(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static int Dot(Vector256<int> left, Vector256<int> right) {
                Vector256<int> temp = Avx2.MultiplyLow(left, right);
                return Sum(temp);
            }

            /// <inheritdoc cref="IWVectorTraits256.Dot(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint Dot(Vector256<uint> left, Vector256<uint> right) {
                Vector256<uint> temp = Avx2.MultiplyLow(left, right);
                return Sum(temp);
            }

            /// <inheritdoc cref="IWVectorTraits256.Dot(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static long Dot(Vector256<long> left, Vector256<long> right) {
                Vector256<long> temp = Multiply(left, right);
                return Sum(temp);
            }

            /// <inheritdoc cref="IWVectorTraits256.Dot(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong Dot(Vector256<ulong> left, Vector256<ulong> right) {
                Vector256<ulong> temp = Multiply(left, right);
                return Sum(temp);
            }


            /// <inheritdoc cref="IWVectorTraits256.Equals_AcceleratedTypes"/>
            public static TypeCodeFlags Equals_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Equals(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Equals(Vector256<float> left, Vector256<float> right) {
#if NET5_0_OR_GREATER
                return Avx.CompareEqual(left, right);
#else
                return Avx.Compare(left, right, FloatComparisonMode.OrderedEqualNonSignaling);
#endif // NET5_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Equals(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Equals(Vector256<double> left, Vector256<double> right) {
#if NET5_0_OR_GREATER
                return Avx.CompareEqual(left, right);
#else
                return Avx.Compare(left, right, FloatComparisonMode.OrderedEqualNonSignaling);
#endif // NET5_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Equals(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Equals(Vector256<sbyte> left, Vector256<sbyte> right) {
                return Avx2.CompareEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Equals(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> Equals(Vector256<byte> left, Vector256<byte> right) {
                return Avx2.CompareEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Equals(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Equals(Vector256<short> left, Vector256<short> right) {
                return Avx2.CompareEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Equals(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> Equals(Vector256<ushort> left, Vector256<ushort> right) {
                return Avx2.CompareEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Equals(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Equals(Vector256<int> left, Vector256<int> right) {
                return Avx2.CompareEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Equals(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> Equals(Vector256<uint> left, Vector256<uint> right) {
                return Avx2.CompareEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Equals(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> Equals(Vector256<long> left, Vector256<long> right) {
                return Avx2.CompareEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Equals(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> Equals(Vector256<ulong> left, Vector256<ulong> right) {
                return Avx2.CompareEqual(left, right);
            }


            /// <inheritdoc cref="IWVectorTraits256.EqualsAll_AcceleratedTypes"/>
            public static TypeCodeFlags EqualsAll_AcceleratedTypes {
                get {
                    return Equals_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.EqualsAll(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector256<float> left, Vector256<float> right) {
                return YIsAllTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.EqualsAll(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector256<double> left, Vector256<double> right) {
                return YIsAllTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.EqualsAll(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector256<sbyte> left, Vector256<sbyte> right) {
                return YIsAllTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.EqualsAll(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector256<byte> left, Vector256<byte> right) {
                return YIsAllTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.EqualsAll(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector256<short> left, Vector256<short> right) {
                return YIsAllTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.EqualsAll(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector256<ushort> left, Vector256<ushort> right) {
                return YIsAllTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.EqualsAll(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector256<int> left, Vector256<int> right) {
                return YIsAllTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.EqualsAll(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector256<uint> left, Vector256<uint> right) {
                return YIsAllTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.EqualsAll(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector256<long> left, Vector256<long> right) {
                return YIsAllTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.EqualsAll(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector256<ulong> left, Vector256<ulong> right) {
                return YIsAllTrue(Equals(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits256.EqualsAny_AcceleratedTypes"/>
            public static TypeCodeFlags EqualsAny_AcceleratedTypes {
                get {
                    return Equals_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.EqualsAny(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector256<float> left, Vector256<float> right) {
                return YIsAnyTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.EqualsAny(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector256<double> left, Vector256<double> right) {
                return YIsAnyTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.EqualsAny(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector256<sbyte> left, Vector256<sbyte> right) {
                return YIsAnyTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.EqualsAny(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector256<byte> left, Vector256<byte> right) {
                return YIsAnyTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.EqualsAny(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector256<short> left, Vector256<short> right) {
                return YIsAnyTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.EqualsAny(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector256<ushort> left, Vector256<ushort> right) {
                return YIsAnyTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.EqualsAny(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector256<int> left, Vector256<int> right) {
                return YIsAnyTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.EqualsAny(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector256<uint> left, Vector256<uint> right) {
                return YIsAnyTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.EqualsAny(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector256<long> left, Vector256<long> right) {
                return YIsAnyTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.EqualsAny(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector256<ulong> left, Vector256<ulong> right) {
                return YIsAnyTrue(Equals(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits256.GreaterThan_AcceleratedTypes"/>
            public static TypeCodeFlags GreaterThan_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> GreaterThan(Vector256<float> left, Vector256<float> right) {
#if NET5_0_OR_GREATER
                return Avx.CompareGreaterThan(left, right);
#else
                return Avx.Compare(left, right, FloatComparisonMode.OrderedGreaterThanSignaling);
#endif // NET5_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> GreaterThan(Vector256<double> left, Vector256<double> right) {
#if NET5_0_OR_GREATER
                return Avx.CompareGreaterThan(left, right);
#else
                return Avx.Compare(left, right, FloatComparisonMode.OrderedGreaterThanSignaling);
#endif // NET5_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> GreaterThan(Vector256<sbyte> left, Vector256<sbyte> right) {
                return Avx2.CompareGreaterThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> GreaterThan(Vector256<byte> left, Vector256<byte> right) {
                //Vector256<sbyte> mid = Vector256s<sbyte>.MinValue;
                Vector256<sbyte> mid = Vector256.Create(sbyte.MinValue); // .NET5+ has better performance .
                Vector256<sbyte> left2 = Avx2.Xor(left.AsSByte(), mid);
                Vector256<sbyte> right2 = Avx2.Xor(right.AsSByte(), mid);
                Vector256<sbyte> mask = Avx2.CompareGreaterThan(left2, right2);
                return mask.AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> GreaterThan(Vector256<short> left, Vector256<short> right) {
                return Avx2.CompareGreaterThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> GreaterThan(Vector256<ushort> left, Vector256<ushort> right) {
                //Vector256<short> mid = Vector256s<short>.MinValue;
                Vector256<short> mid = Vector256.Create(short.MinValue); // .NET5+ has better performance .
                Vector256<short> left2 = Avx2.Xor(left.AsInt16(), mid);
                Vector256<short> right2 = Avx2.Xor(right.AsInt16(), mid);
                Vector256<short> mask = Avx2.CompareGreaterThan(left2, right2);
                return mask.AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> GreaterThan(Vector256<int> left, Vector256<int> right) {
                return Avx2.CompareGreaterThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> GreaterThan(Vector256<uint> left, Vector256<uint> right) {
                //Vector256<int> mid = Vector256s<int>.MinValue;
                Vector256<int> mid = Vector256.Create(int.MinValue); // .NET5+ has better performance .
                Vector256<int> left2 = Avx2.Xor(left.AsInt32(), mid);
                Vector256<int> right2 = Avx2.Xor(right.AsInt32(), mid);
                Vector256<int> mask = Avx2.CompareGreaterThan(left2, right2);
                return mask.AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> GreaterThan(Vector256<long> left, Vector256<long> right) {
                Vector256<long> mask = Avx2.CompareGreaterThan(left, right);
                return mask;
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> GreaterThan(Vector256<ulong> left, Vector256<ulong> right) {
                //Vector256<long> mid = Vector256s<long>.MinValue;
                Vector256<long> mid = Vector256Constants.Int64_MinValue;
                Vector256<long> left2 = Avx2.Add(left.AsInt64(), mid);
                Vector256<long> right2 = Avx2.Add(right.AsInt64(), mid);
                Vector256<long> mask = Avx2.CompareGreaterThan(left2, right2);
                return mask.AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAll_AcceleratedTypes"/>
            public static TypeCodeFlags GreaterThanAll_AcceleratedTypes {
                get {
                    return GreaterThan_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAll(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector256<float> left, Vector256<float> right) {
                return YIsAllTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAll(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector256<double> left, Vector256<double> right) {
                return YIsAllTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAll(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector256<sbyte> left, Vector256<sbyte> right) {
                return YIsAllTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAll(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector256<byte> left, Vector256<byte> right) {
                return YIsAllTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAll(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector256<short> left, Vector256<short> right) {
                return YIsAllTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAll(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector256<ushort> left, Vector256<ushort> right) {
                return YIsAllTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAll(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector256<int> left, Vector256<int> right) {
                return YIsAllTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAll(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector256<uint> left, Vector256<uint> right) {
                return YIsAllTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAll(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector256<long> left, Vector256<long> right) {
                return YIsAllTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAll(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector256<ulong> left, Vector256<ulong> right) {
                return YIsAllTrue(GreaterThan(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAny_AcceleratedTypes"/>
            public static TypeCodeFlags GreaterThanAny_AcceleratedTypes {
                get {
                    return GreaterThan_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAny(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector256<float> left, Vector256<float> right) {
                return YIsAnyTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAny(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector256<double> left, Vector256<double> right) {
                return YIsAnyTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAny(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector256<sbyte> left, Vector256<sbyte> right) {
                return YIsAnyTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAny(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector256<byte> left, Vector256<byte> right) {
                return YIsAnyTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAny(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector256<short> left, Vector256<short> right) {
                return YIsAnyTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAny(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector256<ushort> left, Vector256<ushort> right) {
                return YIsAnyTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAny(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector256<int> left, Vector256<int> right) {
                return YIsAnyTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAny(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector256<uint> left, Vector256<uint> right) {
                return YIsAnyTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAny(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector256<long> left, Vector256<long> right) {
                return YIsAnyTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAny(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector256<ulong> left, Vector256<ulong> right) {
                return YIsAnyTrue(GreaterThan(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits256.LessThan_AcceleratedTypes"/>
            public static TypeCodeFlags LessThan_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> LessThan(Vector256<float> left, Vector256<float> right) {
#if NET5_0_OR_GREATER
                return Avx.CompareLessThan(left, right);
#else
                return Avx.Compare(left, right, FloatComparisonMode.OrderedLessThanSignaling);
#endif // NET5_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> LessThan(Vector256<double> left, Vector256<double> right) {
#if NET5_0_OR_GREATER
                return Avx.CompareLessThan(left, right);
#else
                return Avx.Compare(left, right, FloatComparisonMode.OrderedLessThanSignaling);
#endif // NET5_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> LessThan(Vector256<sbyte> left, Vector256<sbyte> right) {
                return Avx2.CompareGreaterThan(right, left);
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> LessThan(Vector256<byte> left, Vector256<byte> right) {
                //Vector256<sbyte> mid = Vector256s<sbyte>.MinValue;
                Vector256<sbyte> mid = Vector256.Create(sbyte.MinValue); // .NET5+ has better performance .
                Vector256<sbyte> left2 = Avx2.Xor(left.AsSByte(), mid);
                Vector256<sbyte> right2 = Avx2.Xor(right.AsSByte(), mid);
                Vector256<sbyte> mask = Avx2.CompareGreaterThan(right2, left2);
                return mask.AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> LessThan(Vector256<short> left, Vector256<short> right) {
                return Avx2.CompareGreaterThan(right, left);
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> LessThan(Vector256<ushort> left, Vector256<ushort> right) {
                //Vector256<short> mid = Vector256s<short>.MinValue;
                Vector256<short> mid = Vector256.Create(short.MinValue); // .NET5+ has better performance .
                Vector256<short> left2 = Avx2.Xor(left.AsInt16(), mid);
                Vector256<short> right2 = Avx2.Xor(right.AsInt16(), mid);
                Vector256<short> mask = Avx2.CompareGreaterThan(right2, left2);
                return mask.AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> LessThan(Vector256<int> left, Vector256<int> right) {
                return Avx2.CompareGreaterThan(right, left);
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> LessThan(Vector256<uint> left, Vector256<uint> right) {
                //Vector256<int> mid = Vector256s<int>.MinValue;
                Vector256<int> mid = Vector256.Create(int.MinValue); // .NET5+ has better performance .
                Vector256<int> left2 = Avx2.Xor(left.AsInt32(), mid);
                Vector256<int> right2 = Avx2.Xor(right.AsInt32(), mid);
                Vector256<int> mask = Avx2.CompareGreaterThan(right2, left2);
                return mask.AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> LessThan(Vector256<long> left, Vector256<long> right) {
                return Avx2.CompareGreaterThan(right, left);
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> LessThan(Vector256<ulong> left, Vector256<ulong> right) {
                //Vector256<long> mid = Vector256s<long>.MinValue;
                Vector256<long> mid = Vector256Constants.Int64_MinValue;
                Vector256<long> left2 = Avx2.Add(mid, left.AsInt64());
                Vector256<long> right2 = Avx2.Add(mid, right.AsInt64());
                Vector256<long> mask = Avx2.CompareGreaterThan(right2, left2);
                return mask.AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits256.Max_AcceleratedTypes"/>
            public static TypeCodeFlags Max_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Max(Vector256<float> left, Vector256<float> right) {
                return Avx.Max(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Max(Vector256<double> left, Vector256<double> right) {
                return Avx.Max(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Max(Vector256<sbyte> left, Vector256<sbyte> right) {
                return Avx2.Max(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> Max(Vector256<byte> left, Vector256<byte> right) {
                return Avx2.Max(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Max(Vector256<short> left, Vector256<short> right) {
                return Avx2.Max(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> Max(Vector256<ushort> left, Vector256<ushort> right) {
                return Avx2.Max(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Max(Vector256<int> left, Vector256<int> right) {
                return Avx2.Max(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> Max(Vector256<uint> left, Vector256<uint> right) {
                return Avx2.Max(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> Max(Vector256<long> left, Vector256<long> right) {
                Vector256<long> mask = Avx2.CompareGreaterThan(left, right);
                Vector256<long> rt = Avx2.BlendVariable(right, left, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> Max(Vector256<ulong> left, Vector256<ulong> right) {
                //Vector256<long> mid = Vector256s<long>.MinValue;
                Vector256<long> mid = Vector256Constants.Int64_MinValue;
                Vector256<long> left2 = Avx2.Xor(left.AsInt64(), mid);
                Vector256<long> right2 = Avx2.Xor(right.AsInt64(), mid);
                Vector256<long> mask = Avx2.CompareGreaterThan(left2, right2);
                Vector256<ulong> rt = Avx2.BlendVariable(right, left, mask.AsUInt64());
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.Min_AcceleratedTypes"/>
            public static TypeCodeFlags Min_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Min(Vector256<float> left, Vector256<float> right) {
                return Avx.Min(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Min(Vector256<double> left, Vector256<double> right) {
                return Avx.Min(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Min(Vector256<sbyte> left, Vector256<sbyte> right) {
                return Avx2.Min(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> Min(Vector256<byte> left, Vector256<byte> right) {
                return Avx2.Min(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Min(Vector256<short> left, Vector256<short> right) {
                return Avx2.Min(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> Min(Vector256<ushort> left, Vector256<ushort> right) {
                return Avx2.Min(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Min(Vector256<int> left, Vector256<int> right) {
                return Avx2.Min(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> Min(Vector256<uint> left, Vector256<uint> right) {
                return Avx2.Min(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> Min(Vector256<long> left, Vector256<long> right) {
                Vector256<long> mask = Avx2.CompareGreaterThan(right, left);
                Vector256<long> rt = Avx2.BlendVariable(right, left, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> Min(Vector256<ulong> left, Vector256<ulong> right) {
                //Vector256<long> mid = Vector256s<long>.MinValue;
                Vector256<long> mid = Vector256Constants.Int64_MinValue;
                Vector256<long> left2 = Avx2.Xor(left.AsInt64(), mid);
                Vector256<long> right2 = Avx2.Xor(right.AsInt64(), mid);
                Vector256<long> mask = Avx2.CompareGreaterThan(right2, left2);
                Vector256<ulong> rt = Avx2.BlendVariable(right, left, mask.AsUInt64());
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.Multiply_AcceleratedTypes"/>
            public static TypeCodeFlags Multiply_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
#if HARDWARE_OPTIMIZATION
                    rt |= TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
#endif // HARDWARE_OPTIMIZATION
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply_FullAcceleratedTypes"/>
            public static TypeCodeFlags Multiply_FullAcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Multiply(Vector256<float> left, Vector256<float> right) {
                return Avx.Multiply(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Multiply(Vector256<double> left, Vector256<double> right) {
                return Avx.Multiply(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Multiply(Vector256<sbyte> left, Vector256<sbyte> right) {
#if HARDWARE_OPTIMIZATION
                return Multiply_Widen(left, right);
#else
                return SuperStatics.Multiply(left, right);
#endif // HARDWARE_OPTIMIZATION
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> Multiply(Vector256<byte> left, Vector256<byte> right) {
#if HARDWARE_OPTIMIZATION
                return Multiply_Widen(left, right);
#else
                return SuperStatics.Multiply(left, right);
#endif // HARDWARE_OPTIMIZATION
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Multiply(Vector256<short> left, Vector256<short> right) {
                return Avx2.MultiplyLow(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> Multiply(Vector256<ushort> left, Vector256<ushort> right) {
                return Avx2.MultiplyLow(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Multiply(Vector256<int> left, Vector256<int> right) {
                return Avx2.MultiplyLow(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> Multiply(Vector256<uint> left, Vector256<uint> right) {
                return Avx2.MultiplyLow(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> Multiply(Vector256<long> left, Vector256<long> right) {
#if HARDWARE_OPTIMIZATION
                return Multiply_TwoWord(left, right);
#else
                return SuperStatics.Multiply(left, right);
#endif // HARDWARE_OPTIMIZATION
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> Multiply(Vector256<ulong> left, Vector256<ulong> right) {
#if HARDWARE_OPTIMIZATION
                return Multiply_TwoWord(left, right);
#else
                return SuperStatics.Multiply(left, right);
#endif // HARDWARE_OPTIMIZATION
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> Multiply_TwoWord(Vector256<long> left, Vector256<long> right) {
                return Multiply_TwoWord(left.AsUInt64(), right.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> Multiply_TwoWord(Vector256<ulong> left, Vector256<ulong> right) {
                const int L = 32; // sizeof(uint) * 8;
                //const ulong MASK_VALUE = (1L << L) - 1;
                //Vector256<ulong> mask = Vector256.Create(MASK_VALUE);
                Vector256<ulong> mask = Vector256Constants.Int64_VMaxUInt32.AsUInt64();
                Vector256<ulong> w0;
                Vector256<ulong> u1, v1, w1, low;
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

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Multiply_Widen(Vector256<sbyte> left, Vector256<sbyte> right) {
                return Multiply_Widen(left.AsByte(), right.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> Multiply_Widen(Vector256<byte> left, Vector256<byte> right) {
                Widen(left, out Vector256<ushort> u0, out Vector256<ushort> u1);
                Widen(right, out Vector256<ushort> v0, out Vector256<ushort> v1);
                Vector256<ushort> w0 = Multiply(u0, v0);
                Vector256<ushort> w1 = Multiply(u1, v1);
                Vector256<byte> rt = Narrow(w0, w1);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.Negate_AcceleratedTypes"/>
            public static TypeCodeFlags Negate_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Negate(Vector256<float> value) {
                return Avx.Subtract(Vector256<float>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Negate(Vector256<double> value) {
                return Avx.Subtract(Vector256<double>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Negate(Vector256<sbyte> value) {
                return Avx2.Subtract(Vector256<sbyte>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Negate(Vector256<short> value) {
                return Avx2.Subtract(Vector256<short>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Negate(Vector256<int> value) {
                return Avx2.Subtract(Vector256<int>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> Negate(Vector256<long> value) {
                return Avx2.Subtract(Vector256<long>.Zero, value);
            }


            /// <inheritdoc cref="IWVectorTraits256.OnesComplement_AcceleratedTypes"/>
            public static TypeCodeFlags OnesComplement_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.OnesComplement{T}(Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<T> OnesComplement<T>(Vector256<T> vector) where T : struct {
                return Avx2.Xor(Vector256s<ulong>.AllBitsSet, vector.AsUInt64()).As<ulong, T>();
            }


            /// <inheritdoc cref="IWVectorTraits256.Subtract_AcceleratedTypes"/>
            public static TypeCodeFlags Subtract_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Subtract(Vector256<float> left, Vector256<float> right) {
                return Avx.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Subtract(Vector256<double> left, Vector256<double> right) {
                return Avx.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Subtract(Vector256<sbyte> left, Vector256<sbyte> right) {
                return Avx2.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> Subtract(Vector256<byte> left, Vector256<byte> right) {
                return Avx2.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Subtract(Vector256<short> left, Vector256<short> right) {
                return Avx2.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> Subtract(Vector256<ushort> left, Vector256<ushort> right) {
                return Avx2.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Subtract(Vector256<int> left, Vector256<int> right) {
                return Avx2.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> Subtract(Vector256<uint> left, Vector256<uint> right) {
                return Avx2.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> Subtract(Vector256<long> left, Vector256<long> right) {
                return Avx2.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> Subtract(Vector256<ulong> left, Vector256<ulong> right) {
                return Avx2.Subtract(left, right);
            }


            /// <inheritdoc cref="IWVectorTraits256.Xor_AcceleratedTypes"/>
            public static TypeCodeFlags Xor_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Xor{T}(Vector256{T}, Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<T> Xor<T>(Vector256<T> left, Vector256<T> right) where T : struct {
                return Avx2.Xor(left.AsUInt64(), right.AsUInt64()).As<ulong, T>();
            }


#endif // NETCOREAPP3_0_OR_GREATER
            }
    }
}
