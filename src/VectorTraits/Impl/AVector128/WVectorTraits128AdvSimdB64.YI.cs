using System;
using System.Collections.Generic;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
using System.Runtime.CompilerServices;
#endif
#if NET5_0_OR_GREATER
using System.Runtime.Intrinsics.Arm;
#endif // NET5_0_OR_GREATER

namespace Zyl.VectorTraits.Impl.AVector128 {
    using SuperStatics = WVectorTraits128AdvSimd.Statics;

    partial class WVectorTraits128AdvSimdB64 {

        partial class Statics {
#if NET5_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger_AcceleratedTypes"/>
            public static TypeCodeFlags YIsEvenInteger_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.IntTypes & Equals_AcceleratedTypes;
                    rt |= (TypeCodeFlags.Single | TypeCodeFlags.Double) & YIsInteger_AcceleratedTypes & Floor_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsEvenInteger(Vector128<double> value) {
                Vector128<double> valueHalf = AdvSimd.Arm64.Multiply(value, Vector128.Create(0.5));
                Vector128<double> valueHalfTrun = Floor(valueHalf);
                Vector128<long> intMask = YIsInteger(value);
                Vector128<long> halfEqual = Equals(valueHalf, valueHalfTrun).AsInt64();
                Vector128<long> rt = AdvSimd.And(intMask, halfEqual);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsEvenInteger(Vector128<long> value) {
                Vector128<long> temp = AdvSimd.And(value, Vector128Constants.Int64_One);
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

            /// <inheritdoc cref="IWVectorTraits128.YIsFinite(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsFinite(Vector128<double> value) {
                Vector128<long> exponentMask = Vector128Constants.Double_ExponentMask.AsInt64();
                Vector128<long> exponent = AdvSimd.And(value.AsInt64(), exponentMask);
                Vector128<long> rt = SuperStatics.OnesComplement(Equals(exponent, exponentMask));
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

            /// <inheritdoc cref="IWVectorTraits128.YIsInfinity(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsInfinity(Vector128<double> value) {
                Vector128<long> nonSignMask = Vector128Constants.Double_NonSignMask.AsInt64();
                Vector128<long> exponentMask = Vector128Constants.Double_ExponentMask.AsInt64();
                Vector128<long> nonSign = AdvSimd.And(value.AsInt64(), nonSignMask);
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

            /// <inheritdoc cref="IWVectorTraits128.YIsInfinityOrNaN(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsInfinityOrNaN(Vector128<double> value) {
                Vector128<long> exponentMask = Vector128Constants.Double_ExponentMask.AsInt64();
                Vector128<long> exponent = AdvSimd.And(value.AsInt64(), exponentMask);
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

            /// <inheritdoc cref="IWVectorTraits128.YIsInteger(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsInteger(Vector128<double> value) {
                Vector128<double> valueTrun = Floor(value);
                Vector128<long> maskFinite = YIsFinite(value);
                Vector128<long> maskEquals = Equals(value, valueTrun).AsInt64();
                Vector128<long> rt = AdvSimd.And(maskFinite, maskEquals);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YIsNaN_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNaN_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = (TypeCodeFlags.Single | TypeCodeFlags.Double) & Equals_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNaN(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsNaN(Vector128<double> value) {
                Vector128<long> rt = SuperStatics.OnesComplement(Equals(value, value).AsInt64());
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YIsNegative_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNegative_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = (TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64) & LessThan_AcceleratedTypes;
                    rt |= TypeCodeFlagsUtil.MapFlags(LessThan_AcceleratedTypes, TypeCodeFlags.Int32, TypeCodeFlags.Single, TypeCodeFlags.Int64, TypeCodeFlags.Double);
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNegative(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsNegative(Vector128<double> value) {
                return YIsNegative(value.AsInt64());
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNegative(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsNegative(Vector128<long> value) {
                Vector128<long> rt = LessThan(value, Vector128<long>.Zero);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YIsNegativeInfinity_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNegativeInfinity_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = (TypeCodeFlags.Single | TypeCodeFlags.Double) & Equals_AcceleratedTypes;
                    return rt;
                }
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

            /// <inheritdoc cref="IWVectorTraits128.YIsNormal(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsNormal(Vector128<double> value) {
                Vector128<long> exponentMask = Vector128Constants.Double_ExponentMask.AsInt64();
                Vector128<long> exponent = AdvSimd.And(value.AsInt64(), exponentMask);
                Vector128<long> rt = AdvSimd.And(GreaterThan(exponent, Vector128<long>.Zero), GreaterThan(exponentMask, exponent));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YIsNotNaN_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNotNaN_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = (TypeCodeFlags.Single | TypeCodeFlags.Double) & Equals_AcceleratedTypes;
                    return rt;
                }
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

            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsOddInteger(Vector128<double> value) {
                Vector128<double> valueHalf = AdvSimd.Arm64.Multiply(value, Vector128.Create(0.5));
                Vector128<double> valueHalfTrun = Floor(valueHalf);
                Vector128<long> intMask = YIsInteger(value);
                Vector128<long> halfEqual = Equals(valueHalf, valueHalfTrun).AsInt64();
                Vector128<long> rt = SuperStatics.AndNot(intMask, halfEqual);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsOddInteger(Vector128<long> value) {
                Vector128<long> temp = AdvSimd.And(value, Vector128Constants.Int64_One);
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

            /// <inheritdoc cref="IWVectorTraits128.YIsPositive(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsPositive(Vector128<double> value) {
                return YIsPositive(value.AsInt64());
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsPositive(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsPositive(Vector128<long> value) {
                Vector128<long> rt = SuperStatics.OnesComplement(YIsNegative(value));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YIsPositiveInfinity_AcceleratedTypes"/>
            public static TypeCodeFlags YIsPositiveInfinity_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = (TypeCodeFlags.Single | TypeCodeFlags.Double) & Equals_AcceleratedTypes;
                    return rt;
                }
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

            /// <inheritdoc cref="IWVectorTraits128.YIsSubnormal(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsSubnormal(Vector128<double> value) {
                Vector128<long> exponentMask = Vector128Constants.Double_ExponentMask.AsInt64();
                Vector128<long> mantissaMask = Vector128Constants.Double_MantissaMask.AsInt64();
                Vector128<long> zero = Vector128<long>.Zero;
                Vector128<long> exponent = AdvSimd.And(value.AsInt64(), exponentMask);
                Vector128<long> mantissa = AdvSimd.And(value.AsInt64(), mantissaMask);
                Vector128<long> rt = AdvSimd.And(Equals(exponent, zero), GreaterThan(mantissa, zero));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YIsZero_AcceleratedTypes"/>
            public static TypeCodeFlags YIsZero_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = Equals_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsZero(Vector128<double> value) {
                return Equals(Vector128<double>.Zero, value).AsInt64();
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

            /// <inheritdoc cref="IWVectorTraits128.YIsZeroOrSubnormal(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsZeroOrSubnormal(Vector128<double> value) {
                Vector128<long> exponentMask = Vector128Constants.Double_ExponentMask.AsInt64();
                Vector128<long> exponent = AdvSimd.And(value.AsInt64(), exponentMask);
                Vector128<long> rt = Equals(exponent, Vector128<long>.Zero);
                return rt;
            }

#endif // NET5_0_OR_GREATER
        }
    }
}
