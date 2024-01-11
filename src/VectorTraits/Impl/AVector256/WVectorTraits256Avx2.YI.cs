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


            /// <inheritdoc cref="IWVectorTraits256.YIsFinite_AcceleratedTypes"/>
            public static TypeCodeFlags YIsFinite_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double;
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
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double;
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
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double;
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
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double;
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
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double;
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
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double;
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
                Vector256<short> rt = LessThan(value, Vector256<short>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNegative(Vector256<int> value) {
                Vector256<int> rt = LessThan(value, Vector256<int>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNegative(Vector256<long> value) {
                Vector256<long> rt = LessThan(value, Vector256<long>.Zero);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.YIsNegativeZero_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNegativeZero_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double;
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

#endif // NETCOREAPP3_0_OR_GREATER
        }
    }
}
