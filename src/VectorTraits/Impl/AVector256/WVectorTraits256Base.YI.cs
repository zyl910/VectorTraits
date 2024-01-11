using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Collections;
using Zyl.VectorTraits.Impl.Util;
using Zyl.VectorTraits.Numerics;

namespace Zyl.VectorTraits.Impl.AVector256 {
    partial class WVectorTraits256Base {

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
#if NET7_0_OR_GREATER
                return YIsAllTrue_Bcl(value);
#else
                return YIsAllTrue_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsAllTrue{T}(Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAllTrue_Basic<T>(Vector256<T> value) where T : struct {
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<T>, FixedArray4<long>>(ref value);
                long total = p.I0 & p.I1 & p.I2 & p.I3;
                return -1 == total;
            }

#if NET7_0_OR_GREATER
            /// <inheritdoc cref="IWVectorTraits256.YIsAllTrue{T}(Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAllTrue_Bcl<T>(Vector256<T> value) where T : struct {
                Vector256<int> allBitsSet = Vector256<int>.AllBitsSet;
                return Vector256.EqualsAll(value.AsInt32(), allBitsSet);
            }
#endif // NET7_0_OR_GREATER


            /// <inheritdoc cref="IWVectorTraits256.YIsAnyTrue_AcceleratedTypes"/>
            public static TypeCodeFlags YIsAnyTrue_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsAnyTrue{T}(Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAnyTrue<T>(Vector256<T> value) where T : struct {
#if NET7_0_OR_GREATER
                return YIsAnyTrue_Bcl(value);
#else
                return YIsAnyTrue_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsAnyTrue{T}(Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAnyTrue_Basic<T>(Vector256<T> value) where T : struct {
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<T>, FixedArray4<long>>(ref value);
                long total = p.I0 | p.I1 | p.I2 | p.I3;
                return 0 != total;
            }

#if NET7_0_OR_GREATER
            /// <inheritdoc cref="IWVectorTraits256.YIsAnyTrue{T}(Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAnyTrue_Bcl<T>(Vector256<T> value) where T : struct {
                Vector256<byte> allBitsSet = Vector256<byte>.AllBitsSet; // Must use byte.
                return Vector256.EqualsAny(value.AsByte(), allBitsSet);
            }
#endif // NET7_0_OR_GREATER


            /// <inheritdoc cref="IWVectorTraits256.YIsFinite_AcceleratedTypes"/>
            public static TypeCodeFlags YIsFinite_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if NET7_0_OR_GREATER
                    rt |= TypeCodeFlags.Single | TypeCodeFlags.Double;
#endif // NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsFinite(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsFinite(Vector256<float> value) {
#if NET7_0_OR_GREATER
                return YIsFinite_Bit(value);
#else
                return YIsFinite_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsFinite(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsFinite(Vector256<double> value) {
#if NET7_0_OR_GREATER
                return YIsFinite_Bit(value);
#else
                return YIsFinite_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsFinite(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsFinite_Basic(Vector256<float> value) {
                UnsafeUtil.SkipInit(out Vector256<int> rt);
                ref FixedArray8<float> pvalue = ref Unsafe.As<Vector256<float>, FixedArray8<float>>(ref value);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsFinite(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsFinite(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsFinite(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsFinite(pvalue.I3));
                p.I4 = BitMathCore.ToInt32Mask(MathINumberBase.IsFinite(pvalue.I4));
                p.I5 = BitMathCore.ToInt32Mask(MathINumberBase.IsFinite(pvalue.I5));
                p.I6 = BitMathCore.ToInt32Mask(MathINumberBase.IsFinite(pvalue.I6));
                p.I7 = BitMathCore.ToInt32Mask(MathINumberBase.IsFinite(pvalue.I7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsFinite(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsFinite_Basic(Vector256<double> value) {
                UnsafeUtil.SkipInit(out Vector256<long> rt);
                ref FixedArray4<double> pvalue = ref Unsafe.As<Vector256<double>, FixedArray4<double>>(ref value);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsFinite(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsFinite(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsFinite(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsFinite(pvalue.I3));
                return rt;
            }

#if NET7_0_OR_GREATER
            /// <inheritdoc cref="IWVectorTraits256.YIsFinite(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsFinite_Bit(Vector256<float> value) {
                Vector256<int> exponentMask = Vector256Constants.Single_ExponentMask.AsInt32();
                Vector256<int> exponent = Vector256.BitwiseAnd(value.AsInt32(), exponentMask);
                Vector256<int> rt = Vector256.OnesComplement(Vector256.Equals(exponent, exponentMask));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsFinite(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsFinite_Bit(Vector256<double> value) {
                Vector256<long> exponentMask = Vector256Constants.Double_ExponentMask.AsInt64();
                Vector256<long> exponent = Vector256.BitwiseAnd(value.AsInt64(), exponentMask);
                Vector256<long> rt = Vector256.OnesComplement(Vector256.Equals(exponent, exponentMask));
                return rt;
            }
#endif // NET7_0_OR_GREATER


            /// <inheritdoc cref="IWVectorTraits256.YIsInfinity_AcceleratedTypes"/>
            public static TypeCodeFlags YIsInfinity_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if NET7_0_OR_GREATER
                    rt |= TypeCodeFlags.Single | TypeCodeFlags.Double;
#endif // NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsInfinity(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsInfinity(Vector256<float> value) {
#if NET7_0_OR_GREATER
                return YIsInfinity_Bit(value);
#else
                return YIsInfinity_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsInfinity(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsInfinity(Vector256<double> value) {
#if NET7_0_OR_GREATER
                return YIsInfinity_Bit(value);
#else
                return YIsInfinity_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsInfinity(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsInfinity_Basic(Vector256<float> value) {
                UnsafeUtil.SkipInit(out Vector256<int> rt);
                ref FixedArray8<float> pvalue = ref Unsafe.As<Vector256<float>, FixedArray8<float>>(ref value);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinity(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinity(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinity(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinity(pvalue.I3));
                p.I4 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinity(pvalue.I4));
                p.I5 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinity(pvalue.I5));
                p.I6 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinity(pvalue.I6));
                p.I7 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinity(pvalue.I7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsInfinity(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsInfinity_Basic(Vector256<double> value) {
                UnsafeUtil.SkipInit(out Vector256<long> rt);
                ref FixedArray4<double> pvalue = ref Unsafe.As<Vector256<double>, FixedArray4<double>>(ref value);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinity(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinity(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinity(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinity(pvalue.I3));
                return rt;
            }

#if NET7_0_OR_GREATER
            /// <inheritdoc cref="IWVectorTraits256.YIsInfinity(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsInfinity_Bit(Vector256<float> value) {
                Vector256<int> nonSignMask = Vector256Constants.Single_NonSignMask.AsInt32();
                Vector256<int> exponentMask = Vector256Constants.Single_ExponentMask.AsInt32();
                Vector256<int> nonSign = Vector256.BitwiseAnd(value.AsInt32(), nonSignMask);
                Vector256<int> rt = Vector256.Equals(nonSign, exponentMask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsInfinity(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsInfinity_Bit(Vector256<double> value) {
                Vector256<long> nonSignMask = Vector256Constants.Double_NonSignMask.AsInt64();
                Vector256<long> exponentMask = Vector256Constants.Double_ExponentMask.AsInt64();
                Vector256<long> nonSign = Vector256.BitwiseAnd(value.AsInt64(), nonSignMask);
                Vector256<long> rt = Vector256.Equals(nonSign, exponentMask);
                return rt;
            }
#endif // NET7_0_OR_GREATER


            /// <inheritdoc cref="IWVectorTraits256.YIsInfinityOrNaN_AcceleratedTypes"/>
            public static TypeCodeFlags YIsInfinityOrNaN_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if NET7_0_OR_GREATER
                    rt |= TypeCodeFlags.Single | TypeCodeFlags.Double;
#endif // NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsInfinityOrNaN(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsInfinityOrNaN(Vector256<float> value) {
#if NET7_0_OR_GREATER
                return YIsInfinityOrNaN_Bit(value);
#else
                return YIsInfinityOrNaN_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsInfinityOrNaN(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsInfinityOrNaN(Vector256<double> value) {
#if NET7_0_OR_GREATER
                return YIsInfinityOrNaN_Bit(value);
#else
                return YIsInfinityOrNaN_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsInfinityOrNaN(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsInfinityOrNaN_Basic(Vector256<float> value) {
                UnsafeUtil.SkipInit(out Vector256<int> rt);
                ref FixedArray8<float> pvalue = ref Unsafe.As<Vector256<float>, FixedArray8<float>>(ref value);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinityOrNaN(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinityOrNaN(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinityOrNaN(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinityOrNaN(pvalue.I3));
                p.I4 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinityOrNaN(pvalue.I4));
                p.I5 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinityOrNaN(pvalue.I5));
                p.I6 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinityOrNaN(pvalue.I6));
                p.I7 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinityOrNaN(pvalue.I7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsInfinityOrNaN(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsInfinityOrNaN_Basic(Vector256<double> value) {
                UnsafeUtil.SkipInit(out Vector256<long> rt);
                ref FixedArray4<double> pvalue = ref Unsafe.As<Vector256<double>, FixedArray4<double>>(ref value);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinityOrNaN(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinityOrNaN(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinityOrNaN(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinityOrNaN(pvalue.I3));
                return rt;
            }

#if NET7_0_OR_GREATER
            /// <inheritdoc cref="IWVectorTraits256.YIsInfinityOrNaN(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsInfinityOrNaN_Bit(Vector256<float> value) {
                Vector256<int> exponentMask = Vector256Constants.Single_ExponentMask.AsInt32();
                Vector256<int> exponent = Vector256.BitwiseAnd(value.AsInt32(), exponentMask);
                Vector256<int> rt = Vector256.Equals(exponent, exponentMask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsInfinityOrNaN(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsInfinityOrNaN_Bit(Vector256<double> value) {
                Vector256<long> exponentMask = Vector256Constants.Double_ExponentMask.AsInt64();
                Vector256<long> exponent = Vector256.BitwiseAnd(value.AsInt64(), exponentMask);
                Vector256<long> rt = Vector256.Equals(exponent, exponentMask);
                return rt;
            }
#endif // NET7_0_OR_GREATER


            /// <inheritdoc cref="IWVectorTraits256.YIsInteger_AcceleratedTypes"/>
            public static TypeCodeFlags YIsInteger_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if NET7_0_OR_GREATER
                    rt |= TypeCodeFlags.Single | TypeCodeFlags.Double;
#endif // NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsInteger(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsInteger(Vector256<float> value) {
#if NET7_0_OR_GREATER
                return YIsInteger_Bit(value);
#else
                return YIsInteger_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsInteger(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsInteger(Vector256<double> value) {
#if NET7_0_OR_GREATER
                return YIsInteger_Bit(value);
#else
                return YIsInteger_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsInteger(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsInteger_Basic(Vector256<float> value) {
                UnsafeUtil.SkipInit(out Vector256<int> rt);
                ref FixedArray8<float> pvalue = ref Unsafe.As<Vector256<float>, FixedArray8<float>>(ref value);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsInteger(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsInteger(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsInteger(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsInteger(pvalue.I3));
                p.I4 = BitMathCore.ToInt32Mask(MathINumberBase.IsInteger(pvalue.I4));
                p.I5 = BitMathCore.ToInt32Mask(MathINumberBase.IsInteger(pvalue.I5));
                p.I6 = BitMathCore.ToInt32Mask(MathINumberBase.IsInteger(pvalue.I6));
                p.I7 = BitMathCore.ToInt32Mask(MathINumberBase.IsInteger(pvalue.I7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsInteger(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsInteger_Basic(Vector256<double> value) {
                UnsafeUtil.SkipInit(out Vector256<long> rt);
                ref FixedArray4<double> pvalue = ref Unsafe.As<Vector256<double>, FixedArray4<double>>(ref value);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsInteger(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsInteger(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsInteger(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsInteger(pvalue.I3));
                return rt;
            }

#if NET7_0_OR_GREATER
            /// <inheritdoc cref="IWVectorTraits256.YIsInteger(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsInteger_Bit(Vector256<float> value) {
                Vector256<float> valueTrun = Vector256.Floor(value);
                Vector256<int> maskFinite = YIsFinite(value);
                Vector256<int> maskEquals = Equals(value, valueTrun).AsInt32();
                Vector256<int> rt = Vector256.BitwiseAnd(maskFinite, maskEquals);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsInteger(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsInteger_Bit(Vector256<double> value) {
                Vector256<double> valueTrun = Vector256.Floor(value);
                Vector256<long> maskFinite = YIsFinite(value);
                Vector256<long> maskEquals = Equals(value, valueTrun).AsInt64();
                Vector256<long> rt = Vector256.BitwiseAnd(maskFinite, maskEquals);
                return rt;
            }
#endif // NET7_0_OR_GREATER

#endif // NETCOREAPP3_0_OR_GREATER
        }
    }
}
