using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
#if NET8_0_OR_GREATER
using System.Runtime.Intrinsics.Wasm;
#endif // NET8_0_OR_GREATER

namespace Zyl.VectorTraits.Impl.AVector128 {
    using SuperStatics = WVectorTraits128Base.Statics;

    partial class WVectorTraits128PackedSimd {

        partial class Statics {

#if NET8_0_OR_GREATER
/*
            /// <inheritdoc cref="IWVectorTraits128.YIsAllTrue_AcceleratedTypes"/>
            public static TypeCodeFlags YIsAllTrue_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsAllTrue{T}(Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAllTrue<T>(Vector128<T> value) where T : struct {
                // From Danila Kutenin, "Bit twiddling with Arm Neon: beating SSE movemasks, counting bits and more"
                // https://community.arm.com/arm-community-blogs/b/infrastructure-solutions-blog/posts/porting-x86-vector-bitmask-optimizations-to-arm-neon
                // const uint16x8_t equalMask = vreinterpretq_u16_u8(vceqq_u8(chunk, vdupq_n_u8(tag)));
                // const uint8x8_t res = vshrn_n_u16(equalMask, 4);
                // const uint64_t matches = vget_lane_u64(vreinterpret_u64_u8(res), 0);
                // return matches;
                Vector64<ulong> res = PackedSimd.ShiftRightLogicalNarrowingLower(value.AsUInt16(), 4).AsUInt64();
                ulong matches = res.ToScalar();
                return ulong.MaxValue == matches;
            }


            /// <inheritdoc cref="IWVectorTraits128.YIsAnyTrue_AcceleratedTypes"/>
            public static TypeCodeFlags YIsAnyTrue_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsAnyTrue{T}(Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAnyTrue<T>(Vector128<T> value) where T : struct {
                Vector64<long> res = PackedSimd.ShiftRightLogicalNarrowingLower(value.AsUInt16(), 4).AsInt64();
                long matches = res.ToScalar();
                return 0 != matches;
            }


            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger_AcceleratedTypes"/>
            public static TypeCodeFlags YIsEvenInteger_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.IntTypes & Equals_AcceleratedTypes;
                    rt |= (TypeCodeFlags.Single | TypeCodeFlags.Double) & YIsInteger_AcceleratedTypes & Floor_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsEvenInteger(Vector128<float> value) {
                Vector128<float> valueHalf = PackedSimd.Multiply(value, Vector128.Create(0.5f));
                Vector128<float> valueHalfTrun = Floor(valueHalf);
                Vector128<int> intMask = YIsInteger(value);
                Vector128<int> halfEqual = Equals(valueHalf, valueHalfTrun).AsInt32();
                Vector128<int> rt = PackedSimd.And(intMask, halfEqual);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsEvenInteger(Vector128<double> value) {
                Vector128<double> valueHalf = Multiply(value, Vector128.Create(0.5));
                Vector128<double> valueHalfTrun = Floor(valueHalf);
                Vector128<long> intMask = YIsInteger(value);
                Vector128<long> halfEqual = Equals(valueHalf, valueHalfTrun).AsInt64();
                Vector128<long> rt = PackedSimd.And(intMask, halfEqual);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YIsEvenInteger(Vector128<sbyte> value) {
                Vector128<sbyte> temp = PackedSimd.And(value, Vector128Constants.Byte_One.AsSByte());
                Vector128<sbyte> rt = Equals(Vector128<sbyte>.Zero, temp);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YIsEvenInteger(Vector128<byte> value) {
                return YIsEvenInteger(value.AsSByte()).AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YIsEvenInteger(Vector128<short> value) {
                Vector128<short> temp = PackedSimd.And(value, Vector128Constants.Int16_One);
                Vector128<short> rt = Equals(Vector128<short>.Zero, temp);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YIsEvenInteger(Vector128<ushort> value) {
                return YIsEvenInteger(value.AsInt16()).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsEvenInteger(Vector128<int> value) {
                Vector128<int> temp = PackedSimd.And(value, Vector128Constants.Int32_One);
                Vector128<int> rt = Equals(Vector128<int>.Zero, temp);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YIsEvenInteger(Vector128<uint> value) {
                return YIsEvenInteger(value.AsInt32()).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsEvenInteger(Vector128<long> value) {
                Vector128<long> temp = PackedSimd.And(value, Vector128Constants.Int64_One);
                Vector128<long> rt = Equals(Vector128<long>.Zero, temp);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YIsEvenInteger(Vector128<ulong> value) {
                return YIsEvenInteger(value.AsInt64()).AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits128.YIsFinite_AcceleratedTypes"/>
            public static TypeCodeFlags YIsFinite_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single;
                    rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double);
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsFinite(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsFinite(Vector128<float> value) {
                Vector128<int> exponentMask = Vector128Constants.Single_ExponentMask.AsInt32();
                Vector128<int> exponent = PackedSimd.And(value.AsInt32(), exponentMask);
                Vector128<int> rt = OnesComplement(Equals(exponent, exponentMask));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsFinite(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsFinite(Vector128<double> value) {
                Vector128<long> exponentMask = Vector128Constants.Double_ExponentMask.AsInt64();
                Vector128<long> exponent = PackedSimd.And(value.AsInt64(), exponentMask);
                Vector128<long> rt = OnesComplement(Equals(exponent, exponentMask));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YIsInfinity_AcceleratedTypes"/>
            public static TypeCodeFlags YIsInfinity_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single;
                    rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double);
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsInfinity(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsInfinity(Vector128<float> value) {
                Vector128<int> nonSignMask = Vector128Constants.Single_NonSignMask.AsInt32();
                Vector128<int> exponentMask = Vector128Constants.Single_ExponentMask.AsInt32();
                Vector128<int> nonSign = PackedSimd.And(value.AsInt32(), nonSignMask);
                Vector128<int> rt = Equals(nonSign, exponentMask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsInfinity(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsInfinity(Vector128<double> value) {
                Vector128<long> nonSignMask = Vector128Constants.Double_NonSignMask.AsInt64();
                Vector128<long> exponentMask = Vector128Constants.Double_ExponentMask.AsInt64();
                Vector128<long> nonSign = PackedSimd.And(value.AsInt64(), nonSignMask);
                Vector128<long> rt = Equals(nonSign, exponentMask);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YIsInfinityOrNaN_AcceleratedTypes"/>
            public static TypeCodeFlags YIsInfinityOrNaN_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single;
                    rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double);
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsInfinityOrNaN(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsInfinityOrNaN(Vector128<float> value) {
                Vector128<int> exponentMask = Vector128Constants.Single_ExponentMask.AsInt32();
                Vector128<int> exponent = PackedSimd.And(value.AsInt32(), exponentMask);
                Vector128<int> rt = Equals(exponent, exponentMask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsInfinityOrNaN(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsInfinityOrNaN(Vector128<double> value) {
                Vector128<long> exponentMask = Vector128Constants.Double_ExponentMask.AsInt64();
                Vector128<long> exponent = PackedSimd.And(value.AsInt64(), exponentMask);
                Vector128<long> rt = Equals(exponent, exponentMask);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YIsInteger_AcceleratedTypes"/>
            public static TypeCodeFlags YIsInteger_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single;
                    rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double) & Floor_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsInteger(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsInteger(Vector128<float> value) {
                Vector128<float> valueTrun = Floor(value);
                Vector128<int> maskFinite = YIsFinite(value);
                Vector128<int> maskEquals = Equals(value, valueTrun).AsInt32();
                Vector128<int> rt = PackedSimd.And(maskFinite, maskEquals);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsInteger(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsInteger(Vector128<double> value) {
                Vector128<double> valueTrun = Floor(value);
                Vector128<long> maskFinite = YIsFinite(value);
                Vector128<long> maskEquals = Equals(value, valueTrun).AsInt64();
                Vector128<long> rt = PackedSimd.And(maskFinite, maskEquals);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YIsNaN_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNaN_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = (TypeCodeFlags.Single | TypeCodeFlags.Double) & Equals_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNaN(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsNaN(Vector128<float> value) {
                Vector128<int> rt = OnesComplement(Equals(value, value).AsInt32());
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNaN(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsNaN(Vector128<double> value) {
                Vector128<long> rt = OnesComplement(Equals(value, value).AsInt64());
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YIsNegative_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNegative_AcceleratedTypes {
                get {
                    // TypeCodeFlags rt = (TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64) & LessThan_AcceleratedTypes;
                    // rt |= TypeCodeFlagsUtil.MapFlags(LessThan_AcceleratedTypes, TypeCodeFlags.Int32, TypeCodeFlags.Single, TypeCodeFlags.Int64, TypeCodeFlags.Double);
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNegative(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsNegative(Vector128<float> value) {
                return YIsNegative(value.AsInt32());
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNegative(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsNegative(Vector128<double> value) {
                return YIsNegative(value.AsInt64());
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNegative(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YIsNegative(Vector128<sbyte> value) {
                //Vector128<sbyte> rt = LessThan(value, Vector128<sbyte>.Zero);
                Vector128<sbyte> rt = PackedSimd.ShiftRightArithmetic(value, 7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNegative(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YIsNegative(Vector128<short> value) {
                //Vector128<short> rt = LessThan(value, Vector128<short>.Zero);
                Vector128<short> rt = PackedSimd.ShiftRightArithmetic(value, 15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNegative(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsNegative(Vector128<int> value) {
                //Vector128<int> rt = LessThan(value, Vector128<int>.Zero);
                Vector128<int> rt = PackedSimd.ShiftRightArithmetic(value, 31);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNegative(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsNegative(Vector128<long> value) {
                //Vector128<long> rt = LessThan(value, Vector128<long>.Zero);
                Vector128<long> rt = PackedSimd.ShiftRightArithmetic(value, 63);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YIsNegativeInfinity_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNegativeInfinity_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = (TypeCodeFlags.Single | TypeCodeFlags.Double) & Equals_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNegativeInfinity(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsNegativeInfinity(Vector128<float> value) {
                Vector128<float> sample = Vector128.Create(float.NegativeInfinity);
                Vector128<int> rt = Equals(value, sample).AsInt32();
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNegativeInfinity(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsNegativeInfinity(Vector128<double> value) {
                Vector128<double> sample = Vector128.Create(double.NegativeInfinity);
                Vector128<long> rt = Equals(value, sample).AsInt64();
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YIsNegativeZero_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNegativeZero_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single;
                    rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double);
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNegativeZero(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsNegativeZero(Vector128<float> value) {
                Vector128<int> signMask = Vector128Constants.Single_SignMask.AsInt32();
                Vector128<int> rt = Equals(value.AsInt32(), signMask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNegativeZero(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsNegativeZero(Vector128<double> value) {
                Vector128<long> signMask = Vector128Constants.Double_SignMask.AsInt64();
                Vector128<long> rt = Equals(value.AsInt64(), signMask);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YIsNormal_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNormal_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if NET7_0_OR_GREATER
                    rt |= TypeCodeFlagsUtil.MapFlags(GreaterThan_AcceleratedTypes, TypeCodeFlags.Int32, TypeCodeFlags.Single, TypeCodeFlags.Int64, TypeCodeFlags.Double);
#endif // NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNormal(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsNormal(Vector128<float> value) {
                Vector128<int> exponentMask = Vector128Constants.Single_ExponentMask.AsInt32();
                Vector128<int> exponent = PackedSimd.And(value.AsInt32(), exponentMask);
                Vector128<int> rt = PackedSimd.And(GreaterThan(exponent, Vector128<int>.Zero), GreaterThan(exponentMask, exponent));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNormal(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsNormal(Vector128<double> value) {
                Vector128<long> exponentMask = Vector128Constants.Double_ExponentMask.AsInt64();
                Vector128<long> exponent = PackedSimd.And(value.AsInt64(), exponentMask);
                Vector128<long> rt = PackedSimd.And(GreaterThan(exponent, Vector128<long>.Zero), GreaterThan(exponentMask, exponent));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YIsNotEquals_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNotEquals_AcceleratedTypes {
                get {
                    return Equals_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNotEquals(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YIsNotEquals(Vector128<float> left, Vector128<float> right) {
                return OnesComplement(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNotEquals(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YIsNotEquals(Vector128<double> left, Vector128<double> right) {
                return OnesComplement(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNotEquals(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YIsNotEquals(Vector128<sbyte> left, Vector128<sbyte> right) {
                return OnesComplement(PackedSimd.CompareEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNotEquals(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YIsNotEquals(Vector128<byte> left, Vector128<byte> right) {
                return OnesComplement(PackedSimd.CompareEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNotEquals(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YIsNotEquals(Vector128<short> left, Vector128<short> right) {
                return OnesComplement(PackedSimd.CompareEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNotEquals(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YIsNotEquals(Vector128<ushort> left, Vector128<ushort> right) {
                return OnesComplement(PackedSimd.CompareEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNotEquals(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsNotEquals(Vector128<int> left, Vector128<int> right) {
                return OnesComplement(PackedSimd.CompareEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNotEquals(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YIsNotEquals(Vector128<uint> left, Vector128<uint> right) {
                return OnesComplement(PackedSimd.CompareEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNotEquals(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsNotEquals(Vector128<long> left, Vector128<long> right) {
                return OnesComplement(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNotEquals(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YIsNotEquals(Vector128<ulong> left, Vector128<ulong> right) {
                return OnesComplement(Equals(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits128.YIsNotNaN_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNotNaN_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = (TypeCodeFlags.Single | TypeCodeFlags.Double) & Equals_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNotNaN(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsNotNaN(Vector128<float> value) {
                Vector128<int> rt = Equals(value, value).AsInt32();
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNotNaN(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsNotNaN(Vector128<double> value) {
                Vector128<long> rt = Equals(value, value).AsInt64();
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger_AcceleratedTypes"/>
            public static TypeCodeFlags YIsOddInteger_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.IntTypes & Equals_AcceleratedTypes;
                    rt |= (TypeCodeFlags.Single | TypeCodeFlags.Double) & YIsInteger_AcceleratedTypes & Floor_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsOddInteger(Vector128<float> value) {
                Vector128<float> valueHalf = PackedSimd.Multiply(value, Vector128.Create(0.5f));
                Vector128<float> valueHalfTrun = Floor(valueHalf);
                Vector128<int> intMask = YIsInteger(value);
                Vector128<int> halfEqual = Equals(valueHalf, valueHalfTrun).AsInt32();
                Vector128<int> rt = AndNot(intMask, halfEqual);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsOddInteger(Vector128<double> value) {
                Vector128<double> valueHalf = Multiply(value, Vector128.Create(0.5));
                Vector128<double> valueHalfTrun = Floor(valueHalf);
                Vector128<long> intMask = YIsInteger(value);
                Vector128<long> halfEqual = Equals(valueHalf, valueHalfTrun).AsInt64();
                Vector128<long> rt = AndNot(intMask, halfEqual);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YIsOddInteger(Vector128<sbyte> value) {
                Vector128<sbyte> temp = PackedSimd.And(value, Vector128Constants.Byte_One.AsSByte());
                Vector128<sbyte> rt = GreaterThan(temp, Vector128<sbyte>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YIsOddInteger(Vector128<byte> value) {
                return YIsOddInteger(value.AsSByte()).AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YIsOddInteger(Vector128<short> value) {
                Vector128<short> temp = PackedSimd.And(value, Vector128Constants.Int16_One);
                Vector128<short> rt = GreaterThan(temp, Vector128<short>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YIsOddInteger(Vector128<ushort> value) {
                return YIsOddInteger(value.AsInt16()).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsOddInteger(Vector128<int> value) {
                Vector128<int> temp = PackedSimd.And(value, Vector128Constants.Int32_One);
                Vector128<int> rt = GreaterThan(temp, Vector128<int>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YIsOddInteger(Vector128<uint> value) {
                return YIsOddInteger(value.AsInt32()).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsOddInteger(Vector128<long> value) {
                Vector128<long> temp = PackedSimd.And(value, Vector128Constants.Int64_One);
                Vector128<long> rt = GreaterThan(temp, Vector128<long>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YIsOddInteger(Vector128<ulong> value) {
                return YIsOddInteger(value.AsInt64()).AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits128.YIsPositive_AcceleratedTypes"/>
            public static TypeCodeFlags YIsPositive_AcceleratedTypes {
                get {
                    return YIsNegative_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsPositive(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsPositive(Vector128<float> value) {
                return YIsPositive(value.AsInt32());
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsPositive(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsPositive(Vector128<double> value) {
                return YIsPositive(value.AsInt64());
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsPositive(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YIsPositive(Vector128<sbyte> value) {
                Vector128<sbyte> rt = OnesComplement(YIsNegative(value));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsPositive(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YIsPositive(Vector128<short> value) {
                Vector128<short> rt = OnesComplement(YIsNegative(value));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsPositive(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsPositive(Vector128<int> value) {
                Vector128<int> rt = OnesComplement(YIsNegative(value));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsPositive(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsPositive(Vector128<long> value) {
                Vector128<long> rt = OnesComplement(YIsNegative(value));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YIsPositiveInfinity_AcceleratedTypes"/>
            public static TypeCodeFlags YIsPositiveInfinity_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = (TypeCodeFlags.Single | TypeCodeFlags.Double) & Equals_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsPositiveInfinity(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsPositiveInfinity(Vector128<float> value) {
                Vector128<float> sample = Vector128.Create(float.PositiveInfinity);
                Vector128<int> rt = Equals(value, sample).AsInt32();
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsPositiveInfinity(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsPositiveInfinity(Vector128<double> value) {
                Vector128<double> sample = Vector128.Create(double.PositiveInfinity);
                Vector128<long> rt = Equals(value, sample).AsInt64();
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YIsSubnormal_AcceleratedTypes"/>
            public static TypeCodeFlags YIsSubnormal_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single;
                    rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes & GreaterThan_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double);
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsSubnormal(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsSubnormal(Vector128<float> value) {
                Vector128<int> exponentMask = Vector128Constants.Single_ExponentMask.AsInt32();
                Vector128<int> mantissaMask = Vector128Constants.Single_MantissaMask.AsInt32();
                Vector128<int> zero = Vector128<int>.Zero;
                Vector128<int> exponent = PackedSimd.And(value.AsInt32(), exponentMask);
                Vector128<int> mantissa = PackedSimd.And(value.AsInt32(), mantissaMask);
                Vector128<int> rt = PackedSimd.And(Equals(exponent, zero), GreaterThan(mantissa, zero));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsSubnormal(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsSubnormal(Vector128<double> value) {
                Vector128<long> exponentMask = Vector128Constants.Double_ExponentMask.AsInt64();
                Vector128<long> mantissaMask = Vector128Constants.Double_MantissaMask.AsInt64();
                Vector128<long> zero = Vector128<long>.Zero;
                Vector128<long> exponent = PackedSimd.And(value.AsInt64(), exponentMask);
                Vector128<long> mantissa = PackedSimd.And(value.AsInt64(), mantissaMask);
                Vector128<long> rt = PackedSimd.And(Equals(exponent, zero), GreaterThan(mantissa, zero));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YIsZero_AcceleratedTypes"/>
            public static TypeCodeFlags YIsZero_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = Equals_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsZero(Vector128<float> value) {
                return Equals(Vector128<float>.Zero, value).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsZero(Vector128<double> value) {
                return Equals(Vector128<double>.Zero, value).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YIsZero(Vector128<sbyte> value) {
                return Equals(Vector128<sbyte>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YIsZero(Vector128<byte> value) {
                return Equals(Vector128<byte>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YIsZero(Vector128<short> value) {
                return Equals(Vector128<short>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YIsZero(Vector128<ushort> value) {
                return Equals(Vector128<ushort>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsZero(Vector128<int> value) {
                return Equals(Vector128<int>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YIsZero(Vector128<uint> value) {
                return Equals(Vector128<uint>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsZero(Vector128<long> value) {
                return Equals(Vector128<long>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YIsZero(Vector128<ulong> value) {
                return Equals(Vector128<ulong>.Zero, value);
            }


            /// <inheritdoc cref="IWVectorTraits128.YIsZeroOrSubnormal_AcceleratedTypes"/>
            public static TypeCodeFlags YIsZeroOrSubnormal_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single;
                    rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double);
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZeroOrSubnormal(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsZeroOrSubnormal(Vector128<float> value) {
                Vector128<int> exponentMask = Vector128Constants.Single_ExponentMask.AsInt32();
                Vector128<int> exponent = PackedSimd.And(value.AsInt32(), exponentMask);
                Vector128<int> rt = Equals(exponent, Vector128<int>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZeroOrSubnormal(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsZeroOrSubnormal(Vector128<double> value) {
                Vector128<long> exponentMask = Vector128Constants.Double_ExponentMask.AsInt64();
                Vector128<long> exponent = PackedSimd.And(value.AsInt64(), exponentMask);
                Vector128<long> rt = Equals(exponent, Vector128<long>.Zero);
                return rt;
            }
*/
#endif // NET8_0_OR_GREATER
        }
    }
}
