using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
#endif
using Zyl.VectorTraits.Collections;
using Zyl.VectorTraits.Impl.Util;

namespace Zyl.VectorTraits.Impl.AVector512 {
    using SuperStatics = WVectorTraits512Base.Statics;

    partial class WVectorTraits512Avx512 {

        partial class Statics {

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits512.YIsAllTrue_AcceleratedTypes"/>
            public static TypeCodeFlags YIsAllTrue_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsAllTrue{T}(Vector512{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAllTrue<T>(Vector512<T> value) where T : struct {
                //Vector512<int> mask = OnesComplement(value).AsInt32();
                //return Avx.TestZ(mask, mask);
                // .NET8 methods have hardware-accelerated. .NET8 does not provide kortestw instructions.
                return SuperStatics.YIsAllTrue(value);
            }


            /// <inheritdoc cref="IWVectorTraits512.YIsAnyTrue_AcceleratedTypes"/>
            public static TypeCodeFlags YIsAnyTrue_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsAnyTrue{T}(Vector512{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAnyTrue<T>(Vector512<T> value) where T : struct {
                //return !Avx.TestZ(value.AsInt32(), value.AsInt32());
                // .NET8 methods have hardware-accelerated. .NET8 does not provide kortestw instructions.
                return SuperStatics.YIsAllTrue(value);
            }

/*
            /// <inheritdoc cref="IWVectorTraits512.YIsEvenInteger_AcceleratedTypes"/>
            public static TypeCodeFlags YIsEvenInteger_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.IntTypes & Equals_AcceleratedTypes;
                    rt |= (TypeCodeFlags.Single | TypeCodeFlags.Double) & YIsInteger_AcceleratedTypes & Floor_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsEvenInteger(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YIsEvenInteger(Vector512<float> value) {
                Vector512<float> valueHalf = Avx.Multiply(value, Vector512.Create(0.5f));
                Vector512<float> valueHalfTrun = Avx.Floor(valueHalf);
                Vector512<int> intMask = YIsInteger(value);
                Vector512<int> halfEqual = Equals(valueHalf, valueHalfTrun).AsInt32();
                Vector512<int> rt = Avx512.And(intMask, halfEqual);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsEvenInteger(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YIsEvenInteger(Vector512<double> value) {
                Vector512<double> valueHalf = Avx.Multiply(value, Vector512.Create(0.5));
                Vector512<double> valueHalfTrun = Avx.Floor(valueHalf);
                Vector512<long> intMask = YIsInteger(value);
                Vector512<long> halfEqual = Equals(valueHalf, valueHalfTrun).AsInt64();
                Vector512<long> rt = Avx512.And(intMask, halfEqual);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsEvenInteger(Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YIsEvenInteger(Vector512<sbyte> value) {
                Vector512<sbyte> temp = Avx512.And(value, Vector512Constants.Byte_One.AsSByte());
                Vector512<sbyte> rt = Equals(Vector512<sbyte>.Zero, temp);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsEvenInteger(Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YIsEvenInteger(Vector512<byte> value) {
                return YIsEvenInteger(value.AsSByte()).AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsEvenInteger(Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YIsEvenInteger(Vector512<short> value) {
                Vector512<short> temp = Avx512.And(value, Vector512Constants.Int16_One);
                Vector512<short> rt = Equals(Vector512<short>.Zero, temp);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsEvenInteger(Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YIsEvenInteger(Vector512<ushort> value) {
                return YIsEvenInteger(value.AsInt16()).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsEvenInteger(Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YIsEvenInteger(Vector512<int> value) {
                Vector512<int> temp = Avx512.And(value, Vector512Constants.Int32_One);
                Vector512<int> rt = Equals(Vector512<int>.Zero, temp);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsEvenInteger(Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YIsEvenInteger(Vector512<uint> value) {
                return YIsEvenInteger(value.AsInt32()).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsEvenInteger(Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YIsEvenInteger(Vector512<long> value) {
                Vector512<long> temp = Avx512.And(value, Vector512Constants.Int64_One);
                Vector512<long> rt = Equals(Vector512<long>.Zero, temp);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsEvenInteger(Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YIsEvenInteger(Vector512<ulong> value) {
                return YIsEvenInteger(value.AsInt64()).AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits512.YIsFinite_AcceleratedTypes"/>
            public static TypeCodeFlags YIsFinite_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single;
                    rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double);
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsFinite(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YIsFinite(Vector512<float> value) {
                Vector512<int> exponentMask = Vector512Constants.Single_ExponentMask.AsInt32();
                Vector512<int> exponent = Avx512.And(value.AsInt32(), exponentMask);
                Vector512<int> rt = OnesComplement(Equals(exponent, exponentMask));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsFinite(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YIsFinite(Vector512<double> value) {
                Vector512<long> exponentMask = Vector512Constants.Double_ExponentMask.AsInt64();
                Vector512<long> exponent = Avx512.And(value.AsInt64(), exponentMask);
                Vector512<long> rt = OnesComplement(Equals(exponent, exponentMask));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.YIsInfinity_AcceleratedTypes"/>
            public static TypeCodeFlags YIsInfinity_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single;
                    rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double);
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsInfinity(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YIsInfinity(Vector512<float> value) {
                Vector512<int> nonSignMask = Vector512Constants.Single_NonSignMask.AsInt32();
                Vector512<int> exponentMask = Vector512Constants.Single_ExponentMask.AsInt32();
                Vector512<int> nonSign = Avx512.And(value.AsInt32(), nonSignMask);
                Vector512<int> rt = Equals(nonSign, exponentMask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsInfinity(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YIsInfinity(Vector512<double> value) {
                Vector512<long> nonSignMask = Vector512Constants.Double_NonSignMask.AsInt64();
                Vector512<long> exponentMask = Vector512Constants.Double_ExponentMask.AsInt64();
                Vector512<long> nonSign = Avx512.And(value.AsInt64(), nonSignMask);
                Vector512<long> rt = Equals(nonSign, exponentMask);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.YIsInfinityOrNaN_AcceleratedTypes"/>
            public static TypeCodeFlags YIsInfinityOrNaN_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single;
                    rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double);
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsInfinityOrNaN(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YIsInfinityOrNaN(Vector512<float> value) {
                Vector512<int> exponentMask = Vector512Constants.Single_ExponentMask.AsInt32();
                Vector512<int> exponent = Avx512.And(value.AsInt32(), exponentMask);
                Vector512<int> rt = Equals(exponent, exponentMask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsInfinityOrNaN(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YIsInfinityOrNaN(Vector512<double> value) {
                Vector512<long> exponentMask = Vector512Constants.Double_ExponentMask.AsInt64();
                Vector512<long> exponent = Avx512.And(value.AsInt64(), exponentMask);
                Vector512<long> rt = Equals(exponent, exponentMask);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.YIsInteger_AcceleratedTypes"/>
            public static TypeCodeFlags YIsInteger_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single;
                    rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double) & Floor_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsInteger(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YIsInteger(Vector512<float> value) {
                Vector512<float> valueTrun = Avx.Floor(value);
                Vector512<int> maskFinite = YIsFinite(value);
                Vector512<int> maskEquals = Equals(value, valueTrun).AsInt32();
                Vector512<int> rt = Avx512.And(maskFinite, maskEquals);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsInteger(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YIsInteger(Vector512<double> value) {
                Vector512<double> valueTrun = Avx.Floor(value);
                Vector512<long> maskFinite = YIsFinite(value);
                Vector512<long> maskEquals = Equals(value, valueTrun).AsInt64();
                Vector512<long> rt = Avx512.And(maskFinite, maskEquals);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.YIsNaN_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNaN_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = (TypeCodeFlags.Single | TypeCodeFlags.Double) & Equals_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsNaN(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YIsNaN(Vector512<float> value) {
                Vector512<int> rt = YIsNotEquals(value, value).AsInt32();
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsNaN(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YIsNaN(Vector512<double> value) {
                Vector512<long> rt = YIsNotEquals(value, value).AsInt64();
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.YIsNegative_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNegative_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = (TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64) & LessThan_AcceleratedTypes;
                    rt |= TypeCodeFlagsUtil.MapFlags(LessThan_AcceleratedTypes, TypeCodeFlags.Int32, TypeCodeFlags.Single, TypeCodeFlags.Int64, TypeCodeFlags.Double);
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsNegative(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YIsNegative(Vector512<float> value) {
                return YIsNegative(value.AsInt32());
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsNegative(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YIsNegative(Vector512<double> value) {
                return YIsNegative(value.AsInt64());
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsNegative(Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YIsNegative(Vector512<sbyte> value) {
                Vector512<sbyte> rt = LessThan(value, Vector512<sbyte>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsNegative(Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YIsNegative(Vector512<short> value) {
                //Vector512<short> rt = LessThan(value, Vector512<short>.Zero);
                Vector512<short> rt = Avx512.ShiftRightArithmetic(value, 15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsNegative(Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YIsNegative(Vector512<int> value) {
                //Vector512<int> rt = LessThan(value, Vector512<int>.Zero);
                Vector512<int> rt = Avx512.ShiftRightArithmetic(value, 31);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsNegative(Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YIsNegative(Vector512<long> value) {
                Vector512<long> rt = LessThan(value, Vector512<long>.Zero);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.YIsNegativeInfinity_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNegativeInfinity_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = (TypeCodeFlags.Single | TypeCodeFlags.Double) & Equals_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsNegativeInfinity(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YIsNegativeInfinity(Vector512<float> value) {
                Vector512<float> sample = Vector512.Create(float.NegativeInfinity);
                Vector512<int> rt = Equals(value, sample).AsInt32();
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsNegativeInfinity(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YIsNegativeInfinity(Vector512<double> value) {
                Vector512<double> sample = Vector512.Create(double.NegativeInfinity);
                Vector512<long> rt = Equals(value, sample).AsInt64();
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.YIsNegativeZero_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNegativeZero_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single;
                    rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double);
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsNegativeZero(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YIsNegativeZero(Vector512<float> value) {
                Vector512<int> signMask = Vector512Constants.Single_SignMask.AsInt32();
                Vector512<int> rt = Equals(value.AsInt32(), signMask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsNegativeZero(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YIsNegativeZero(Vector512<double> value) {
                Vector512<long> signMask = Vector512Constants.Double_SignMask.AsInt64();
                Vector512<long> rt = Equals(value.AsInt64(), signMask);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.YIsNormal_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNormal_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if NET7_0_OR_GREATER
                    rt |= TypeCodeFlagsUtil.MapFlags(GreaterThan_AcceleratedTypes, TypeCodeFlags.Int32, TypeCodeFlags.Single, TypeCodeFlags.Int64, TypeCodeFlags.Double);
#endif // NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsNormal(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YIsNormal(Vector512<float> value) {
                Vector512<int> exponentMask = Vector512Constants.Single_ExponentMask.AsInt32();
                Vector512<int> exponent = Avx512.And(value.AsInt32(), exponentMask);
                Vector512<int> rt = Avx512.And(GreaterThan(exponent, Vector512<int>.Zero), GreaterThan(exponentMask, exponent));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsNormal(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YIsNormal(Vector512<double> value) {
                Vector512<long> exponentMask = Vector512Constants.Double_ExponentMask.AsInt64();
                Vector512<long> exponent = Avx512.And(value.AsInt64(), exponentMask);
                Vector512<long> rt = Avx512.And(GreaterThan(exponent, Vector512<long>.Zero), GreaterThan(exponentMask, exponent));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.YIsNotEquals_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNotEquals_AcceleratedTypes {
                get {
                    return Equals_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsNotEquals(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YIsNotEquals(Vector512<float> left, Vector512<float> right) {
#if NET5_0_OR_GREATER
                return Avx.CompareNotEqual(left, right);
#else
                return Avx.Compare(left, right, FloatComparisonMode.UnorderedNotEqualNonSignaling);
#endif // NET5_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsNotEquals(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YIsNotEquals(Vector512<double> left, Vector512<double> right) {
#if NET5_0_OR_GREATER
                return Avx.CompareNotEqual(left, right);
#else
                return Avx.Compare(left, right, FloatComparisonMode.UnorderedNotEqualNonSignaling);
#endif // NET5_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsNotEquals(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YIsNotEquals(Vector512<sbyte> left, Vector512<sbyte> right) {
                return OnesComplement(Avx512.CompareEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsNotEquals(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YIsNotEquals(Vector512<byte> left, Vector512<byte> right) {
                return OnesComplement(Avx512.CompareEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsNotEquals(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YIsNotEquals(Vector512<short> left, Vector512<short> right) {
                return OnesComplement(Avx512.CompareEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsNotEquals(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YIsNotEquals(Vector512<ushort> left, Vector512<ushort> right) {
                return OnesComplement(Avx512.CompareEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsNotEquals(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YIsNotEquals(Vector512<int> left, Vector512<int> right) {
                return OnesComplement(Avx512.CompareEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsNotEquals(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YIsNotEquals(Vector512<uint> left, Vector512<uint> right) {
                return OnesComplement(Avx512.CompareEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsNotEquals(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YIsNotEquals(Vector512<long> left, Vector512<long> right) {
                return OnesComplement(Avx512.CompareEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsNotEquals(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YIsNotEquals(Vector512<ulong> left, Vector512<ulong> right) {
                return OnesComplement(Avx512.CompareEqual(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits512.YIsNotNaN_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNotNaN_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = (TypeCodeFlags.Single | TypeCodeFlags.Double) & Equals_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsNotNaN(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YIsNotNaN(Vector512<float> value) {
                Vector512<int> rt = Equals(value, value).AsInt32();
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsNotNaN(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YIsNotNaN(Vector512<double> value) {
                Vector512<long> rt = Equals(value, value).AsInt64();
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.YIsOddInteger_AcceleratedTypes"/>
            public static TypeCodeFlags YIsOddInteger_AcceleratedTypes
            {
                get
                {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.IntTypes & Equals_AcceleratedTypes;
                    rt |= (TypeCodeFlags.Single | TypeCodeFlags.Double) & YIsInteger_AcceleratedTypes & Floor_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsOddInteger(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YIsOddInteger(Vector512<float> value)
            {
                Vector512<float> valueHalf = Avx.Multiply(value, Vector512.Create(0.5f));
                Vector512<float> valueHalfTrun = Avx.Floor(valueHalf);
                Vector512<int> intMask = YIsInteger(value);
                Vector512<int> halfEqual = Equals(valueHalf, valueHalfTrun).AsInt32();
                Vector512<int> rt = AndNot(intMask, halfEqual);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsOddInteger(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YIsOddInteger(Vector512<double> value)
            {
                Vector512<double> valueHalf = Avx.Multiply(value, Vector512.Create(0.5));
                Vector512<double> valueHalfTrun = Avx.Floor(valueHalf);
                Vector512<long> intMask = YIsInteger(value);
                Vector512<long> halfEqual = Equals(valueHalf, valueHalfTrun).AsInt64();
                Vector512<long> rt = AndNot(intMask, halfEqual);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsOddInteger(Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YIsOddInteger(Vector512<sbyte> value)
            {
                Vector512<sbyte> temp = Avx512.And(value, Vector512Constants.Byte_One.AsSByte());
                Vector512<sbyte> rt = GreaterThan(temp, Vector512<sbyte>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsOddInteger(Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YIsOddInteger(Vector512<byte> value)
            {
                return YIsOddInteger(value.AsSByte()).AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsOddInteger(Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YIsOddInteger(Vector512<short> value)
            {
                Vector512<short> temp = Avx512.And(value, Vector512Constants.Int16_One);
                Vector512<short> rt = GreaterThan(temp, Vector512<short>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsOddInteger(Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YIsOddInteger(Vector512<ushort> value)
            {
                return YIsOddInteger(value.AsInt16()).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsOddInteger(Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YIsOddInteger(Vector512<int> value)
            {
                Vector512<int> temp = Avx512.And(value, Vector512Constants.Int32_One);
                Vector512<int> rt = GreaterThan(temp, Vector512<int>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsOddInteger(Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YIsOddInteger(Vector512<uint> value)
            {
                return YIsOddInteger(value.AsInt32()).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsOddInteger(Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YIsOddInteger(Vector512<long> value)
            {
                Vector512<long> temp = Avx512.And(value, Vector512Constants.Int64_One);
                Vector512<long> rt = GreaterThan(temp, Vector512<long>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsOddInteger(Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YIsOddInteger(Vector512<ulong> value)
            {
                return YIsOddInteger(value.AsInt64()).AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits512.YIsPositive_AcceleratedTypes"/>
            public static TypeCodeFlags YIsPositive_AcceleratedTypes {
                get {
                    return YIsNegative_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsPositive(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YIsPositive(Vector512<float> value) {
                return YIsPositive(value.AsInt32());
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsPositive(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YIsPositive(Vector512<double> value) {
                return YIsPositive(value.AsInt64());
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsPositive(Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YIsPositive(Vector512<sbyte> value) {
                Vector512<sbyte> rt = OnesComplement(YIsNegative(value));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsPositive(Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YIsPositive(Vector512<short> value) {
                Vector512<short> rt = OnesComplement(YIsNegative(value));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsPositive(Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YIsPositive(Vector512<int> value) {
                Vector512<int> rt = OnesComplement(YIsNegative(value));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsPositive(Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YIsPositive(Vector512<long> value) {
                Vector512<long> rt = OnesComplement(YIsNegative(value));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.YIsPositiveInfinity_AcceleratedTypes"/>
            public static TypeCodeFlags YIsPositiveInfinity_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = (TypeCodeFlags.Single | TypeCodeFlags.Double) & Equals_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsPositiveInfinity(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YIsPositiveInfinity(Vector512<float> value) {
                Vector512<float> sample = Vector512.Create(float.PositiveInfinity);
                Vector512<int> rt = Equals(value, sample).AsInt32();
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsPositiveInfinity(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YIsPositiveInfinity(Vector512<double> value) {
                Vector512<double> sample = Vector512.Create(double.PositiveInfinity);
                Vector512<long> rt = Equals(value, sample).AsInt64();
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.YIsSubnormal_AcceleratedTypes"/>
            public static TypeCodeFlags YIsSubnormal_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single;
                    rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes & GreaterThan_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double);
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsSubnormal(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YIsSubnormal(Vector512<float> value) {
                Vector512<int> exponentMask = Vector512Constants.Single_ExponentMask.AsInt32();
                Vector512<int> mantissaMask = Vector512Constants.Single_MantissaMask.AsInt32();
                Vector512<int> zero = Vector512<int>.Zero;
                Vector512<int> exponent = Avx512.And(value.AsInt32(), exponentMask);
                Vector512<int> mantissa = Avx512.And(value.AsInt32(), mantissaMask);
                Vector512<int> rt = Avx512.And(Equals(exponent, zero), GreaterThan(mantissa, zero));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsSubnormal(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YIsSubnormal(Vector512<double> value) {
                Vector512<long> exponentMask = Vector512Constants.Double_ExponentMask.AsInt64();
                Vector512<long> mantissaMask = Vector512Constants.Double_MantissaMask.AsInt64();
                Vector512<long> zero = Vector512<long>.Zero;
                Vector512<long> exponent = Avx512.And(value.AsInt64(), exponentMask);
                Vector512<long> mantissa = Avx512.And(value.AsInt64(), mantissaMask);
                Vector512<long> rt = Avx512.And(Equals(exponent, zero), GreaterThan(mantissa, zero));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.YIsZero_AcceleratedTypes"/>
            public static TypeCodeFlags YIsZero_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = Equals_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsZero(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YIsZero(Vector512<float> value) {
                return Equals(Vector512<float>.Zero, value).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsZero(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YIsZero(Vector512<double> value) {
                return Equals(Vector512<double>.Zero, value).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsZero(Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YIsZero(Vector512<sbyte> value) {
                return Equals(Vector512<sbyte>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsZero(Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YIsZero(Vector512<byte> value) {
                return Equals(Vector512<byte>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsZero(Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YIsZero(Vector512<short> value) {
                return Equals(Vector512<short>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsZero(Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YIsZero(Vector512<ushort> value) {
                return Equals(Vector512<ushort>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsZero(Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YIsZero(Vector512<int> value) {
                return Equals(Vector512<int>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsZero(Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YIsZero(Vector512<uint> value) {
                return Equals(Vector512<uint>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsZero(Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YIsZero(Vector512<long> value) {
                return Equals(Vector512<long>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsZero(Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YIsZero(Vector512<ulong> value) {
                return Equals(Vector512<ulong>.Zero, value);
            }


            /// <inheritdoc cref="IWVectorTraits512.YIsZeroOrSubnormal_AcceleratedTypes"/>
            public static TypeCodeFlags YIsZeroOrSubnormal_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single;
                    rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double);
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsZeroOrSubnormal(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YIsZeroOrSubnormal(Vector512<float> value) {
                Vector512<int> exponentMask = Vector512Constants.Single_ExponentMask.AsInt32();
                Vector512<int> exponent = Avx512.And(value.AsInt32(), exponentMask);
                Vector512<int> rt = Equals(exponent, Vector512<int>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YIsZeroOrSubnormal(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YIsZeroOrSubnormal(Vector512<double> value) {
                Vector512<long> exponentMask = Vector512Constants.Double_ExponentMask.AsInt64();
                Vector512<long> exponent = Avx512.And(value.AsInt64(), exponentMask);
                Vector512<long> rt = Equals(exponent, Vector512<long>.Zero);
                return rt;
            }
*/
#endif // NET8_0_OR_GREATER
        }
    }
}
