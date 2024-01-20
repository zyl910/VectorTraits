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

namespace Zyl.VectorTraits.Impl.AVector256 {
    using SuperStatics = WVectorTraits256Base.Statics;

    partial class WVectorTraits256Avx2 {

        partial class Statics {

#if NETCOREAPP3_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YIsAllTrue_AcceleratedTypes"/>
            public static TypeCodeFlags YIsAllTrue_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsAllTrue{T}(Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAllTrue<T>(Vector256<T> value) where T : struct {
                Vector256<int> mask = OnesComplement(value).AsInt32();
                return Avx.TestZ(mask, mask);
            }


            /// <inheritdoc cref="IWVectorTraits256.YIsAnyTrue_AcceleratedTypes"/>
            public static TypeCodeFlags YIsAnyTrue_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsAnyTrue{T}(Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAnyTrue<T>(Vector256<T> value) where T : struct {
                return !Avx.TestZ(value.AsInt32(), value.AsInt32());
            }


            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger_AcceleratedTypes"/>
            public static TypeCodeFlags YIsEvenInteger_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.IntTypes & Equals_AcceleratedTypes;
                    rt |= (TypeCodeFlags.Single | TypeCodeFlags.Double) & YIsInteger_AcceleratedTypes & Floor_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsEvenInteger(Vector256<float> value) {
                Vector256<float> valueHalf = Avx.Multiply(value, Vector256.Create(0.5f));
                Vector256<float> valueHalfTrun = Avx.Floor(valueHalf);
                Vector256<int> intMask = YIsInteger(value);
                Vector256<int> halfEqual = Equals(valueHalf, valueHalfTrun).AsInt32();
                Vector256<int> rt = Avx2.And(intMask, halfEqual);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsEvenInteger(Vector256<double> value) {
                Vector256<double> valueHalf = Avx.Multiply(value, Vector256.Create(0.5));
                Vector256<double> valueHalfTrun = Avx.Floor(valueHalf);
                Vector256<long> intMask = YIsInteger(value);
                Vector256<long> halfEqual = Equals(valueHalf, valueHalfTrun).AsInt64();
                Vector256<long> rt = Avx2.And(intMask, halfEqual);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YIsEvenInteger(Vector256<sbyte> value) {
                Vector256<sbyte> temp = Avx2.And(value, Vector256Constants.Byte_One.AsSByte());
                Vector256<sbyte> rt = Equals(Vector256<sbyte>.Zero, temp);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YIsEvenInteger(Vector256<byte> value) {
                return YIsEvenInteger(value.AsSByte()).AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YIsEvenInteger(Vector256<short> value) {
                Vector256<short> temp = Avx2.And(value, Vector256Constants.Int16_One);
                Vector256<short> rt = Equals(Vector256<short>.Zero, temp);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YIsEvenInteger(Vector256<ushort> value) {
                return YIsEvenInteger(value.AsInt16()).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsEvenInteger(Vector256<int> value) {
                Vector256<int> temp = Avx2.And(value, Vector256Constants.Int32_One);
                Vector256<int> rt = Equals(Vector256<int>.Zero, temp);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YIsEvenInteger(Vector256<uint> value) {
                return YIsEvenInteger(value.AsInt32()).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsEvenInteger(Vector256<long> value) {
                Vector256<long> temp = Avx2.And(value, Vector256Constants.Int64_One);
                Vector256<long> rt = Equals(Vector256<long>.Zero, temp);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YIsEvenInteger(Vector256<ulong> value) {
                return YIsEvenInteger(value.AsInt64()).AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits256.YIsFinite_AcceleratedTypes"/>
            public static TypeCodeFlags YIsFinite_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single;
                    rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double);
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsFinite(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsFinite(Vector256<float> value) {
                Vector256<int> exponentMask = Vector256Constants.Single_ExponentMask.AsInt32();
                Vector256<int> exponent = Avx2.And(value.AsInt32(), exponentMask);
                Vector256<int> rt = OnesComplement(Equals(exponent, exponentMask));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsFinite(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsFinite(Vector256<double> value) {
                Vector256<long> exponentMask = Vector256Constants.Double_ExponentMask.AsInt64();
                Vector256<long> exponent = Avx2.And(value.AsInt64(), exponentMask);
                Vector256<long> rt = OnesComplement(Equals(exponent, exponentMask));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.YIsInfinity_AcceleratedTypes"/>
            public static TypeCodeFlags YIsInfinity_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single;
                    rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double);
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsInfinity(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsInfinity(Vector256<float> value) {
                Vector256<int> nonSignMask = Vector256Constants.Single_NonSignMask.AsInt32();
                Vector256<int> exponentMask = Vector256Constants.Single_ExponentMask.AsInt32();
                Vector256<int> nonSign = Avx2.And(value.AsInt32(), nonSignMask);
                Vector256<int> rt = Equals(nonSign, exponentMask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsInfinity(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsInfinity(Vector256<double> value) {
                Vector256<long> nonSignMask = Vector256Constants.Double_NonSignMask.AsInt64();
                Vector256<long> exponentMask = Vector256Constants.Double_ExponentMask.AsInt64();
                Vector256<long> nonSign = Avx2.And(value.AsInt64(), nonSignMask);
                Vector256<long> rt = Equals(nonSign, exponentMask);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.YIsInfinityOrNaN_AcceleratedTypes"/>
            public static TypeCodeFlags YIsInfinityOrNaN_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single;
                    rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double);
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsInfinityOrNaN(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsInfinityOrNaN(Vector256<float> value) {
                Vector256<int> exponentMask = Vector256Constants.Single_ExponentMask.AsInt32();
                Vector256<int> exponent = Avx2.And(value.AsInt32(), exponentMask);
                Vector256<int> rt = Equals(exponent, exponentMask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsInfinityOrNaN(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsInfinityOrNaN(Vector256<double> value) {
                Vector256<long> exponentMask = Vector256Constants.Double_ExponentMask.AsInt64();
                Vector256<long> exponent = Avx2.And(value.AsInt64(), exponentMask);
                Vector256<long> rt = Equals(exponent, exponentMask);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.YIsInteger_AcceleratedTypes"/>
            public static TypeCodeFlags YIsInteger_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single;
                    rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double) & Floor_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsInteger(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsInteger(Vector256<float> value) {
                Vector256<float> valueTrun = Avx.Floor(value);
                Vector256<int> maskFinite = YIsFinite(value);
                Vector256<int> maskEquals = Equals(value, valueTrun).AsInt32();
                Vector256<int> rt = Avx2.And(maskFinite, maskEquals);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsInteger(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsInteger(Vector256<double> value) {
                Vector256<double> valueTrun = Avx.Floor(value);
                Vector256<long> maskFinite = YIsFinite(value);
                Vector256<long> maskEquals = Equals(value, valueTrun).AsInt64();
                Vector256<long> rt = Avx2.And(maskFinite, maskEquals);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.YIsNaN_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNaN_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = (TypeCodeFlags.Single | TypeCodeFlags.Double) & Equals_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNaN(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNaN(Vector256<float> value) {
                Vector256<int> rt = OnesComplement(Equals(value, value).AsInt32());
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNaN(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNaN(Vector256<double> value) {
                Vector256<long> rt = OnesComplement(Equals(value, value).AsInt64());
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.YIsNegative_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNegative_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = (TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64) & LessThan_AcceleratedTypes;
                    rt |= TypeCodeFlagsUtil.MapFlags(LessThan_AcceleratedTypes, TypeCodeFlags.Int32, TypeCodeFlags.Single, TypeCodeFlags.Int64, TypeCodeFlags.Double);
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNegative(Vector256<float> value) {
                return YIsNegative(value.AsInt32());
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNegative(Vector256<double> value) {
                return YIsNegative(value.AsInt64());
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YIsNegative(Vector256<sbyte> value) {
                Vector256<sbyte> rt = LessThan(value, Vector256<sbyte>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YIsNegative(Vector256<short> value) {
                //Vector256<short> rt = LessThan(value, Vector256<short>.Zero);
                Vector256<short> rt = Avx2.ShiftRightArithmetic(value, 15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNegative(Vector256<int> value) {
                //Vector256<int> rt = LessThan(value, Vector256<int>.Zero);
                Vector256<int> rt = Avx2.ShiftRightArithmetic(value, 31);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNegative(Vector256<long> value) {
                Vector256<long> rt = LessThan(value, Vector256<long>.Zero);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.YIsNegativeInfinity_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNegativeInfinity_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = (TypeCodeFlags.Single | TypeCodeFlags.Double) & Equals_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegativeInfinity(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNegativeInfinity(Vector256<float> value) {
                Vector256<float> sample = Vector256.Create(float.NegativeInfinity);
                Vector256<int> rt = Equals(value, sample).AsInt32();
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegativeInfinity(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNegativeInfinity(Vector256<double> value) {
                Vector256<double> sample = Vector256.Create(double.NegativeInfinity);
                Vector256<long> rt = Equals(value, sample).AsInt64();
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.YIsNegativeZero_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNegativeZero_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single;
                    rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double);
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegativeZero(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNegativeZero(Vector256<float> value) {
                Vector256<int> signMask = Vector256Constants.Single_SignMask.AsInt32();
                Vector256<int> rt = Equals(value.AsInt32(), signMask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegativeZero(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNegativeZero(Vector256<double> value) {
                Vector256<long> signMask = Vector256Constants.Double_SignMask.AsInt64();
                Vector256<long> rt = Equals(value.AsInt64(), signMask);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.YIsNormal_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNormal_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if NET7_0_OR_GREATER
                    rt |= TypeCodeFlagsUtil.MapFlags(GreaterThan_AcceleratedTypes, TypeCodeFlags.Int32, TypeCodeFlags.Single, TypeCodeFlags.Int64, TypeCodeFlags.Double);
#endif // NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNormal(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNormal(Vector256<float> value) {
                Vector256<int> exponentMask = Vector256Constants.Single_ExponentMask.AsInt32();
                Vector256<int> exponent = Avx2.And(value.AsInt32(), exponentMask);
                Vector256<int> rt = Avx2.And(GreaterThan(exponent, Vector256<int>.Zero), GreaterThan(exponentMask, exponent));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNormal(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNormal(Vector256<double> value) {
                Vector256<long> exponentMask = Vector256Constants.Double_ExponentMask.AsInt64();
                Vector256<long> exponent = Avx2.And(value.AsInt64(), exponentMask);
                Vector256<long> rt = Avx2.And(GreaterThan(exponent, Vector256<long>.Zero), GreaterThan(exponentMask, exponent));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.YIsNotNaN_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNotNaN_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = (TypeCodeFlags.Single | TypeCodeFlags.Double) & Equals_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNotNaN(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNotNaN(Vector256<float> value) {
                Vector256<int> rt = Equals(value, value).AsInt32();
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNotNaN(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNotNaN(Vector256<double> value) {
                Vector256<long> rt = Equals(value, value).AsInt64();
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger_AcceleratedTypes"/>
            public static TypeCodeFlags YIsOddInteger_AcceleratedTypes
            {
                get
                {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.IntTypes & Equals_AcceleratedTypes;
                    rt |= (TypeCodeFlags.Single | TypeCodeFlags.Double) & YIsInteger_AcceleratedTypes & Floor_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsOddInteger(Vector256<float> value)
            {
                Vector256<float> valueHalf = Avx.Multiply(value, Vector256.Create(0.5f));
                Vector256<float> valueHalfTrun = Avx.Floor(valueHalf);
                Vector256<int> intMask = YIsInteger(value);
                Vector256<int> halfEqual = Equals(valueHalf, valueHalfTrun).AsInt32();
                Vector256<int> rt = AndNot(intMask, halfEqual);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsOddInteger(Vector256<double> value)
            {
                Vector256<double> valueHalf = Avx.Multiply(value, Vector256.Create(0.5));
                Vector256<double> valueHalfTrun = Avx.Floor(valueHalf);
                Vector256<long> intMask = YIsInteger(value);
                Vector256<long> halfEqual = Equals(valueHalf, valueHalfTrun).AsInt64();
                Vector256<long> rt = AndNot(intMask, halfEqual);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YIsOddInteger(Vector256<sbyte> value)
            {
                Vector256<sbyte> temp = Avx2.And(value, Vector256Constants.Byte_One.AsSByte());
                Vector256<sbyte> rt = GreaterThan(temp, Vector256<sbyte>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YIsOddInteger(Vector256<byte> value)
            {
                return YIsOddInteger(value.AsSByte()).AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YIsOddInteger(Vector256<short> value)
            {
                Vector256<short> temp = Avx2.And(value, Vector256Constants.Int16_One);
                Vector256<short> rt = GreaterThan(temp, Vector256<short>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YIsOddInteger(Vector256<ushort> value)
            {
                return YIsOddInteger(value.AsInt16()).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsOddInteger(Vector256<int> value)
            {
                Vector256<int> temp = Avx2.And(value, Vector256Constants.Int32_One);
                Vector256<int> rt = GreaterThan(temp, Vector256<int>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YIsOddInteger(Vector256<uint> value)
            {
                return YIsOddInteger(value.AsInt32()).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsOddInteger(Vector256<long> value)
            {
                Vector256<long> temp = Avx2.And(value, Vector256Constants.Int64_One);
                Vector256<long> rt = GreaterThan(temp, Vector256<long>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YIsOddInteger(Vector256<ulong> value)
            {
                return YIsOddInteger(value.AsInt64()).AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits256.YIsPositive_AcceleratedTypes"/>
            public static TypeCodeFlags YIsPositive_AcceleratedTypes {
                get {
                    return YIsNegative_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsPositive(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsPositive(Vector256<float> value) {
                return YIsPositive(value.AsInt32());
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsPositive(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsPositive(Vector256<double> value) {
                return YIsPositive(value.AsInt64());
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsPositive(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YIsPositive(Vector256<sbyte> value) {
                Vector256<sbyte> rt = OnesComplement(YIsNegative(value));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsPositive(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YIsPositive(Vector256<short> value) {
                Vector256<short> rt = OnesComplement(YIsNegative(value));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsPositive(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsPositive(Vector256<int> value) {
                Vector256<int> rt = OnesComplement(YIsNegative(value));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsPositive(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsPositive(Vector256<long> value) {
                Vector256<long> rt = OnesComplement(YIsNegative(value));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.YIsPositiveInfinity_AcceleratedTypes"/>
            public static TypeCodeFlags YIsPositiveInfinity_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = (TypeCodeFlags.Single | TypeCodeFlags.Double) & Equals_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsPositiveInfinity(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsPositiveInfinity(Vector256<float> value) {
                Vector256<float> sample = Vector256.Create(float.PositiveInfinity);
                Vector256<int> rt = Equals(value, sample).AsInt32();
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsPositiveInfinity(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsPositiveInfinity(Vector256<double> value) {
                Vector256<double> sample = Vector256.Create(double.PositiveInfinity);
                Vector256<long> rt = Equals(value, sample).AsInt64();
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.YIsSubnormal_AcceleratedTypes"/>
            public static TypeCodeFlags YIsSubnormal_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single;
                    rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes & GreaterThan_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double);
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsSubnormal(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsSubnormal(Vector256<float> value) {
                Vector256<int> exponentMask = Vector256Constants.Single_ExponentMask.AsInt32();
                Vector256<int> mantissaMask = Vector256Constants.Single_MantissaMask.AsInt32();
                Vector256<int> zero = Vector256<int>.Zero;
                Vector256<int> exponent = Avx2.And(value.AsInt32(), exponentMask);
                Vector256<int> mantissa = Avx2.And(value.AsInt32(), mantissaMask);
                Vector256<int> rt = Avx2.And(Equals(exponent, zero), GreaterThan(mantissa, zero));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsSubnormal(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsSubnormal(Vector256<double> value) {
                Vector256<long> exponentMask = Vector256Constants.Double_ExponentMask.AsInt64();
                Vector256<long> mantissaMask = Vector256Constants.Double_MantissaMask.AsInt64();
                Vector256<long> zero = Vector256<long>.Zero;
                Vector256<long> exponent = Avx2.And(value.AsInt64(), exponentMask);
                Vector256<long> mantissa = Avx2.And(value.AsInt64(), mantissaMask);
                Vector256<long> rt = Avx2.And(Equals(exponent, zero), GreaterThan(mantissa, zero));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.YIsZero_AcceleratedTypes"/>
            public static TypeCodeFlags YIsZero_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = Equals_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsZero(Vector256<float> value) {
                return Equals(Vector256<float>.Zero, value).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsZero(Vector256<double> value) {
                return Equals(Vector256<double>.Zero, value).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YIsZero(Vector256<sbyte> value) {
                return Equals(Vector256<sbyte>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YIsZero(Vector256<byte> value) {
                return Equals(Vector256<byte>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YIsZero(Vector256<short> value) {
                return Equals(Vector256<short>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YIsZero(Vector256<ushort> value) {
                return Equals(Vector256<ushort>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsZero(Vector256<int> value) {
                return Equals(Vector256<int>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YIsZero(Vector256<uint> value) {
                return Equals(Vector256<uint>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsZero(Vector256<long> value) {
                return Equals(Vector256<long>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YIsZero(Vector256<ulong> value) {
                return Equals(Vector256<ulong>.Zero, value);
            }


            /// <inheritdoc cref="IWVectorTraits256.YIsZeroOrSubnormal_AcceleratedTypes"/>
            public static TypeCodeFlags YIsZeroOrSubnormal_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single;
                    rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double);
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZeroOrSubnormal(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsZeroOrSubnormal(Vector256<float> value) {
                Vector256<int> exponentMask = Vector256Constants.Single_ExponentMask.AsInt32();
                Vector256<int> exponent = Avx2.And(value.AsInt32(), exponentMask);
                Vector256<int> rt = Equals(exponent, Vector256<int>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZeroOrSubnormal(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsZeroOrSubnormal(Vector256<double> value) {
                Vector256<long> exponentMask = Vector256Constants.Double_ExponentMask.AsInt64();
                Vector256<long> exponent = Avx2.And(value.AsInt64(), exponentMask);
                Vector256<long> rt = Equals(exponent, Vector256<long>.Zero);
                return rt;
            }

#endif // NETCOREAPP3_0_OR_GREATER
        }
    }
}
