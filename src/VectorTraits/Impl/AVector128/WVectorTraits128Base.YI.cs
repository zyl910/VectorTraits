#if NET7_0_OR_GREATER
#define VECTOR_HAS_METHOD
#endif // NET7_0_OR_GREATER

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

namespace Zyl.VectorTraits.Impl.AVector128 {
    partial class WVectorTraits128Base {

        partial class Statics {

#if NETCOREAPP3_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.YIsAllTrue_AcceleratedTypes"/>
            public static TypeCodeFlags YIsAllTrue_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsAllTrue{T}(Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAllTrue<T>(Vector128<T> value) where T : struct {
#if VECTOR_HAS_METHOD
                return YIsAllTrue_Bcl(value);
#else
                return YIsAllTrue_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsAllTrue{T}(Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAllTrue_Basic<T>(Vector128<T> value) where T : struct {
                ref FixedArray2<long> p = ref Unsafe.As<Vector128<T>, FixedArray2<long>>(ref value);
                long total = p.I0 & p.I1;
                return -1 == total;
            }

#if VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits128.YIsAllTrue{T}(Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAllTrue_Bcl<T>(Vector128<T> value) where T : struct {
                Vector128<int> allBitsSet = Vector128<int>.AllBitsSet;
                return Vector128.EqualsAll(value.AsInt32(), allBitsSet);
            }
#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits128.YIsAnyTrue_AcceleratedTypes"/>
            public static TypeCodeFlags YIsAnyTrue_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsAnyTrue{T}(Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAnyTrue<T>(Vector128<T> value) where T : struct {
#if VECTOR_HAS_METHOD
                return YIsAnyTrue_Bcl(value);
#else
                return YIsAnyTrue_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsAnyTrue{T}(Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAnyTrue_Basic<T>(Vector128<T> value) where T : struct {
                ref FixedArray2<long> p = ref Unsafe.As<Vector128<T>, FixedArray2<long>>(ref value);
                long total = p.I0 | p.I1;
                return 0 != total;
            }

#if VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits128.YIsAnyTrue{T}(Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAnyTrue_Bcl<T>(Vector128<T> value) where T : struct {
                Vector128<byte> allBitsSet = Vector128<byte>.AllBitsSet; // Must use byte.
                return Vector128.EqualsAny(value.AsByte(), allBitsSet);
            }
#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger_AcceleratedTypes"/>
            public static TypeCodeFlags YIsEvenInteger_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if VECTOR_HAS_METHOD
                    rt |= TypeCodeFlagsUtil.IntTypes & Equals_AcceleratedTypes;
                    rt |= (TypeCodeFlags.Single | TypeCodeFlags.Double) & YIsInteger_AcceleratedTypes & Floor_AcceleratedTypes;
#endif // VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsEvenInteger(Vector128<float> value) {
#if VECTOR_HAS_METHOD
                return YIsEvenInteger_Bit(value);
#else
                return YIsEvenInteger_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsEvenInteger(Vector128<double> value) {
#if VECTOR_HAS_METHOD
                return YIsEvenInteger_Bit(value);
#else
                return YIsEvenInteger_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YIsEvenInteger(Vector128<sbyte> value) {
#if VECTOR_HAS_METHOD
                return YIsEvenInteger_Bit(value);
#else
                return YIsEvenInteger_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YIsEvenInteger(Vector128<byte> value) {
#if VECTOR_HAS_METHOD
                return YIsEvenInteger_Bit(value);
#else
                return YIsEvenInteger_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YIsEvenInteger(Vector128<short> value) {
#if VECTOR_HAS_METHOD
                return YIsEvenInteger_Bit(value);
#else
                return YIsEvenInteger_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YIsEvenInteger(Vector128<ushort> value) {
#if VECTOR_HAS_METHOD
                return YIsEvenInteger_Bit(value);
#else
                return YIsEvenInteger_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsEvenInteger(Vector128<int> value) {
#if VECTOR_HAS_METHOD
                return YIsEvenInteger_Bit(value);
#else
                return YIsEvenInteger_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YIsEvenInteger(Vector128<uint> value) {
#if VECTOR_HAS_METHOD
                return YIsEvenInteger_Bit(value);
#else
                return YIsEvenInteger_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsEvenInteger(Vector128<long> value) {
#if VECTOR_HAS_METHOD
                return YIsEvenInteger_Bit(value);
#else
                return YIsEvenInteger_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YIsEvenInteger(Vector128<ulong> value) {
#if VECTOR_HAS_METHOD
                return YIsEvenInteger_Bit(value);
#else
                return YIsEvenInteger_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsEvenInteger_Basic(Vector128<float> value) {
                UnsafeUtil.SkipInit(out Vector128<int> rt);
                ref FixedArray4<float> pvalue = ref Unsafe.As<Vector128<float>, FixedArray4<float>>(ref value);
                ref FixedArray4<int> p = ref Unsafe.As<Vector128<int>, FixedArray4<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I3));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsEvenInteger_Basic(Vector128<double> value) {
                UnsafeUtil.SkipInit(out Vector128<long> rt);
                ref FixedArray2<double> pvalue = ref Unsafe.As<Vector128<double>, FixedArray2<double>>(ref value);
                ref FixedArray2<long> p = ref Unsafe.As<Vector128<long>, FixedArray2<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I1));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YIsEvenInteger_Basic(Vector128<sbyte> value) {
                UnsafeUtil.SkipInit(out Vector128<sbyte> rt);
                ref FixedArray16<sbyte> pvalue = ref Unsafe.As<Vector128<sbyte>, FixedArray16<sbyte>>(ref value);
                ref FixedArray16<sbyte> p = ref Unsafe.As<Vector128<sbyte>, FixedArray16<sbyte>>(ref rt);
                p.I0 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I0));
                p.I1 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I1));
                p.I2 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I2));
                p.I3 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I3));
                p.I4 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I4));
                p.I5 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I5));
                p.I6 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I6));
                p.I7 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I7));
                p.I8 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I8));
                p.I9 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I9));
                p.I10 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I10));
                p.I11 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I11));
                p.I12 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I12));
                p.I13 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I13));
                p.I14 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I14));
                p.I15 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I15));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YIsEvenInteger_Basic(Vector128<byte> value) {
                return YIsEvenInteger_Basic(value.AsSByte()).AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YIsEvenInteger_Basic(Vector128<short> value) {
                UnsafeUtil.SkipInit(out Vector128<short> rt);
                ref FixedArray8<short> pvalue = ref Unsafe.As<Vector128<short>, FixedArray8<short>>(ref value);
                ref FixedArray8<short> p = ref Unsafe.As<Vector128<short>, FixedArray8<short>>(ref rt);
                p.I0 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I0));
                p.I1 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I1));
                p.I2 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I2));
                p.I3 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I3));
                p.I4 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I4));
                p.I5 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I5));
                p.I6 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I6));
                p.I7 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YIsEvenInteger_Basic(Vector128<ushort> value) {
                return YIsEvenInteger_Basic(value.AsInt16()).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsEvenInteger_Basic(Vector128<int> value) {
                UnsafeUtil.SkipInit(out Vector128<int> rt);
                ref FixedArray4<int> pvalue = ref Unsafe.As<Vector128<int>, FixedArray4<int>>(ref value);
                ref FixedArray4<int> p = ref Unsafe.As<Vector128<int>, FixedArray4<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I3));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YIsEvenInteger_Basic(Vector128<uint> value) {
                return YIsEvenInteger_Basic(value.AsInt32()).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsEvenInteger_Basic(Vector128<long> value) {
                UnsafeUtil.SkipInit(out Vector128<long> rt);
                ref FixedArray2<long> pvalue = ref Unsafe.As<Vector128<long>, FixedArray2<long>>(ref value);
                ref FixedArray2<long> p = ref Unsafe.As<Vector128<long>, FixedArray2<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I1));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YIsEvenInteger_Basic(Vector128<ulong> value) {
                return YIsEvenInteger_Basic(value.AsInt64()).AsUInt64();
            }

#if VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsEvenInteger_Bit(Vector128<float> value) {
                Vector128<float> valueHalf = Vector128.Multiply(value, 0.5f);
                Vector128<float> valueHalfTrun = Vector128.Floor(valueHalf);
                Vector128<int> intMask = YIsInteger(value);
                Vector128<int> halfEqual = Vector128.Equals(valueHalf, valueHalfTrun).AsInt32();
                Vector128<int> rt = Vector128.BitwiseAnd(intMask, halfEqual);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsEvenInteger_Bit(Vector128<double> value) {
                Vector128<double> valueHalf = Vector128.Multiply(value, 0.5);
                Vector128<double> valueHalfTrun = Vector128.Floor(valueHalf);
                Vector128<long> intMask = YIsInteger(value);
                Vector128<long> halfEqual = Vector128.Equals(valueHalf, valueHalfTrun).AsInt64();
                Vector128<long> rt = Vector128.BitwiseAnd(intMask, halfEqual);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YIsEvenInteger_Bit(Vector128<sbyte> value) {
                Vector128<sbyte> temp = Vector128.BitwiseAnd(value, Vector128Constants.Byte_One.AsSByte());
                Vector128<sbyte> rt = Vector128.Equals(Vector128<sbyte>.Zero, temp);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YIsEvenInteger_Bit(Vector128<byte> value) {
                return YIsEvenInteger_Bit(value.AsSByte()).AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YIsEvenInteger_Bit(Vector128<short> value) {
                Vector128<short> temp = Vector128.BitwiseAnd(value, Vector128Constants.Int16_One);
                Vector128<short> rt = Vector128.Equals(Vector128<short>.Zero, temp);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YIsEvenInteger_Bit(Vector128<ushort> value) {
                return YIsEvenInteger_Bit(value.AsInt16()).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsEvenInteger_Bit(Vector128<int> value) {
                Vector128<int> temp = Vector128.BitwiseAnd(value, Vector128Constants.Int32_One);
                Vector128<int> rt = Vector128.Equals(Vector128<int>.Zero, temp);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YIsEvenInteger_Bit(Vector128<uint> value) {
                return YIsEvenInteger_Bit(value.AsInt32()).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsEvenInteger_Bit(Vector128<long> value) {
                Vector128<long> temp = Vector128.BitwiseAnd(value, Vector128Constants.Int64_One);
                Vector128<long> rt = Vector128.Equals(Vector128<long>.Zero, temp);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YIsEvenInteger_Bit(Vector128<ulong> value) {
                return YIsEvenInteger_Bit(value.AsInt64()).AsUInt64();
            }
#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits128.YIsFinite_AcceleratedTypes"/>
            public static TypeCodeFlags YIsFinite_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if VECTOR_HAS_METHOD
                    rt |= TypeCodeFlags.Single;
                    rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double);
#endif // VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsFinite(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsFinite(Vector128<float> value) {
#if VECTOR_HAS_METHOD
                return YIsFinite_Bit(value);
#else
                return YIsFinite_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsFinite(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsFinite(Vector128<double> value) {
#if VECTOR_HAS_METHOD
                return YIsFinite_Bit(value);
#else
                return YIsFinite_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsFinite(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsFinite_Basic(Vector128<float> value) {
                UnsafeUtil.SkipInit(out Vector128<int> rt);
                ref FixedArray4<float> pvalue = ref Unsafe.As<Vector128<float>, FixedArray4<float>>(ref value);
                ref FixedArray4<int> p = ref Unsafe.As<Vector128<int>, FixedArray4<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsFinite(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsFinite(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsFinite(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsFinite(pvalue.I3));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsFinite(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsFinite_Basic(Vector128<double> value) {
                UnsafeUtil.SkipInit(out Vector128<long> rt);
                ref FixedArray2<double> pvalue = ref Unsafe.As<Vector128<double>, FixedArray2<double>>(ref value);
                ref FixedArray2<long> p = ref Unsafe.As<Vector128<long>, FixedArray2<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsFinite(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsFinite(pvalue.I1));
                return rt;
            }

#if VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits128.YIsFinite(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsFinite_Bit(Vector128<float> value) {
                Vector128<int> exponentMask = Vector128Constants.Single_ExponentMask.AsInt32();
                Vector128<int> exponent = Vector128.BitwiseAnd(value.AsInt32(), exponentMask);
                Vector128<int> rt = Vector128.OnesComplement(Vector128.Equals(exponent, exponentMask));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsFinite(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsFinite_Bit(Vector128<double> value) {
                Vector128<long> exponentMask = Vector128Constants.Double_ExponentMask.AsInt64();
                Vector128<long> exponent = Vector128.BitwiseAnd(value.AsInt64(), exponentMask);
                Vector128<long> rt = Vector128.OnesComplement(Vector128.Equals(exponent, exponentMask));
                return rt;
            }
#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits128.YIsInfinity_AcceleratedTypes"/>
            public static TypeCodeFlags YIsInfinity_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if VECTOR_HAS_METHOD
                    rt |= TypeCodeFlags.Single;
                    rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double);
#endif // VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsInfinity(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsInfinity(Vector128<float> value) {
#if VECTOR_HAS_METHOD
                return YIsInfinity_Bit(value);
#else
                return YIsInfinity_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsInfinity(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsInfinity(Vector128<double> value) {
#if VECTOR_HAS_METHOD
                return YIsInfinity_Bit(value);
#else
                return YIsInfinity_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsInfinity(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsInfinity_Basic(Vector128<float> value) {
                UnsafeUtil.SkipInit(out Vector128<int> rt);
                ref FixedArray4<float> pvalue = ref Unsafe.As<Vector128<float>, FixedArray4<float>>(ref value);
                ref FixedArray4<int> p = ref Unsafe.As<Vector128<int>, FixedArray4<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinity(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinity(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinity(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinity(pvalue.I3));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsInfinity(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsInfinity_Basic(Vector128<double> value) {
                UnsafeUtil.SkipInit(out Vector128<long> rt);
                ref FixedArray2<double> pvalue = ref Unsafe.As<Vector128<double>, FixedArray2<double>>(ref value);
                ref FixedArray2<long> p = ref Unsafe.As<Vector128<long>, FixedArray2<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinity(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinity(pvalue.I1));
                return rt;
            }

#if VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits128.YIsInfinity(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsInfinity_Bit(Vector128<float> value) {
                Vector128<int> nonSignMask = Vector128Constants.Single_NonSignMask.AsInt32();
                Vector128<int> exponentMask = Vector128Constants.Single_ExponentMask.AsInt32();
                Vector128<int> nonSign = Vector128.BitwiseAnd(value.AsInt32(), nonSignMask);
                Vector128<int> rt = Vector128.Equals(nonSign, exponentMask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsInfinity(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsInfinity_Bit(Vector128<double> value) {
                Vector128<long> nonSignMask = Vector128Constants.Double_NonSignMask.AsInt64();
                Vector128<long> exponentMask = Vector128Constants.Double_ExponentMask.AsInt64();
                Vector128<long> nonSign = Vector128.BitwiseAnd(value.AsInt64(), nonSignMask);
                Vector128<long> rt = Vector128.Equals(nonSign, exponentMask);
                return rt;
            }
#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits128.YIsInfinityOrNaN_AcceleratedTypes"/>
            public static TypeCodeFlags YIsInfinityOrNaN_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if VECTOR_HAS_METHOD
                    rt |= TypeCodeFlags.Single;
                    rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double);
#endif // VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsInfinityOrNaN(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsInfinityOrNaN(Vector128<float> value) {
#if VECTOR_HAS_METHOD
                return YIsInfinityOrNaN_Bit(value);
#else
                return YIsInfinityOrNaN_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsInfinityOrNaN(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsInfinityOrNaN(Vector128<double> value) {
#if VECTOR_HAS_METHOD
                return YIsInfinityOrNaN_Bit(value);
#else
                return YIsInfinityOrNaN_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsInfinityOrNaN(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsInfinityOrNaN_Basic(Vector128<float> value) {
                UnsafeUtil.SkipInit(out Vector128<int> rt);
                ref FixedArray4<float> pvalue = ref Unsafe.As<Vector128<float>, FixedArray4<float>>(ref value);
                ref FixedArray4<int> p = ref Unsafe.As<Vector128<int>, FixedArray4<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinityOrNaN(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinityOrNaN(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinityOrNaN(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinityOrNaN(pvalue.I3));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsInfinityOrNaN(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsInfinityOrNaN_Basic(Vector128<double> value) {
                UnsafeUtil.SkipInit(out Vector128<long> rt);
                ref FixedArray2<double> pvalue = ref Unsafe.As<Vector128<double>, FixedArray2<double>>(ref value);
                ref FixedArray2<long> p = ref Unsafe.As<Vector128<long>, FixedArray2<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinityOrNaN(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsInfinityOrNaN(pvalue.I1));
                return rt;
            }

#if VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits128.YIsInfinityOrNaN(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsInfinityOrNaN_Bit(Vector128<float> value) {
                Vector128<int> exponentMask = Vector128Constants.Single_ExponentMask.AsInt32();
                Vector128<int> exponent = Vector128.BitwiseAnd(value.AsInt32(), exponentMask);
                Vector128<int> rt = Vector128.Equals(exponent, exponentMask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsInfinityOrNaN(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsInfinityOrNaN_Bit(Vector128<double> value) {
                Vector128<long> exponentMask = Vector128Constants.Double_ExponentMask.AsInt64();
                Vector128<long> exponent = Vector128.BitwiseAnd(value.AsInt64(), exponentMask);
                Vector128<long> rt = Vector128.Equals(exponent, exponentMask);
                return rt;
            }
#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits128.YIsInteger_AcceleratedTypes"/>
            public static TypeCodeFlags YIsInteger_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if VECTOR_HAS_METHOD
                    rt |= TypeCodeFlags.Single;
                    rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double) & Floor_AcceleratedTypes;
#endif // VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsInteger(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsInteger(Vector128<float> value) {
#if VECTOR_HAS_METHOD
                return YIsInteger_Bit(value);
#else
                return YIsInteger_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsInteger(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsInteger(Vector128<double> value) {
#if VECTOR_HAS_METHOD
                return YIsInteger_Bit(value);
#else
                return YIsInteger_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsInteger(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsInteger_Basic(Vector128<float> value) {
                UnsafeUtil.SkipInit(out Vector128<int> rt);
                ref FixedArray4<float> pvalue = ref Unsafe.As<Vector128<float>, FixedArray4<float>>(ref value);
                ref FixedArray4<int> p = ref Unsafe.As<Vector128<int>, FixedArray4<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsInteger(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsInteger(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsInteger(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsInteger(pvalue.I3));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsInteger(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsInteger_Basic(Vector128<double> value) {
                UnsafeUtil.SkipInit(out Vector128<long> rt);
                ref FixedArray2<double> pvalue = ref Unsafe.As<Vector128<double>, FixedArray2<double>>(ref value);
                ref FixedArray2<long> p = ref Unsafe.As<Vector128<long>, FixedArray2<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsInteger(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsInteger(pvalue.I1));
                return rt;
            }

#if VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits128.YIsInteger(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsInteger_Bit(Vector128<float> value) {
                Vector128<float> valueTrun = Vector128.Floor(value);
                Vector128<int> maskFinite = YIsFinite(value);
                Vector128<int> maskEquals = Equals(value, valueTrun).AsInt32();
                Vector128<int> rt = Vector128.BitwiseAnd(maskFinite, maskEquals);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsInteger(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsInteger_Bit(Vector128<double> value) {
                Vector128<double> valueTrun = Vector128.Floor(value);
                Vector128<long> maskFinite = YIsFinite(value);
                Vector128<long> maskEquals = Equals(value, valueTrun).AsInt64();
                Vector128<long> rt = Vector128.BitwiseAnd(maskFinite, maskEquals);
                return rt;
            }
#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits128.YIsNaN_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNaN_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if VECTOR_HAS_METHOD
                    rt |= (TypeCodeFlags.Single | TypeCodeFlags.Double) & Equals_AcceleratedTypes;
#endif // VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNaN(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsNaN(Vector128<float> value) {
#if VECTOR_HAS_METHOD
                return YIsNaN_Bit(value);
#else
                return YIsNaN_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNaN(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsNaN(Vector128<double> value) {
#if VECTOR_HAS_METHOD
                return YIsNaN_Bit(value);
#else
                return YIsNaN_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNaN(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsNaN_Basic(Vector128<float> value) {
                UnsafeUtil.SkipInit(out Vector128<int> rt);
                ref FixedArray4<float> pvalue = ref Unsafe.As<Vector128<float>, FixedArray4<float>>(ref value);
                ref FixedArray4<int> p = ref Unsafe.As<Vector128<int>, FixedArray4<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsNaN(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsNaN(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsNaN(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsNaN(pvalue.I3));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNaN(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsNaN_Basic(Vector128<double> value) {
                UnsafeUtil.SkipInit(out Vector128<long> rt);
                ref FixedArray2<double> pvalue = ref Unsafe.As<Vector128<double>, FixedArray2<double>>(ref value);
                ref FixedArray2<long> p = ref Unsafe.As<Vector128<long>, FixedArray2<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsNaN(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsNaN(pvalue.I1));
                return rt;
            }

#if VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits128.YIsNaN(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsNaN_Bit(Vector128<float> value) {
#pragma warning disable CS1718 // Comparison made to same variable; did you mean to compare something else?
                Vector128<int> rt = Vector128.OnesComplement(Vector128.Equals(value, value).AsInt32());
#pragma warning restore CS1718 // Comparison made to same variable; did you mean to compare something else?
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNaN(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsNaN_Bit(Vector128<double> value) {
#pragma warning disable CS1718 // Comparison made to same variable; did you mean to compare something else?
                Vector128<long> rt = Vector128.OnesComplement(Vector128.Equals(value, value).AsInt64());
#pragma warning restore CS1718 // Comparison made to same variable; did you mean to compare something else?
                return rt;
            }
#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits128.YIsNegative_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNegative_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if VECTOR_HAS_METHOD
                    rt |= (TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64) & LessThan_AcceleratedTypes;
                    rt |= TypeCodeFlagsUtil.MapFlags(LessThan_AcceleratedTypes, TypeCodeFlags.Int32, TypeCodeFlags.Single, TypeCodeFlags.Int64, TypeCodeFlags.Double);
#endif // VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNegative(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsNegative(Vector128<float> value) {
#if VECTOR_HAS_METHOD
                return YIsNegative_Bit(value);
#else
                return YIsNegative_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNegative(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsNegative(Vector128<double> value) {
#if VECTOR_HAS_METHOD
                return YIsNegative_Bit(value);
#else
                return YIsNegative_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNegative(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YIsNegative(Vector128<sbyte> value) {
#if VECTOR_HAS_METHOD
                return YIsNegative_Bit(value);
#else
                return YIsNegative_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNegative(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YIsNegative(Vector128<short> value) {
#if VECTOR_HAS_METHOD
                return YIsNegative_Bit(value);
#else
                return YIsNegative_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNegative(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsNegative(Vector128<int> value) {
#if VECTOR_HAS_METHOD
                return YIsNegative_Bit(value);
#else
                return YIsNegative_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNegative(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsNegative(Vector128<long> value) {
#if VECTOR_HAS_METHOD
                return YIsNegative_Bit(value);
#else
                return YIsNegative_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNegative(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsNegative_Basic(Vector128<float> value) {
                UnsafeUtil.SkipInit(out Vector128<int> rt);
                ref FixedArray4<float> pvalue = ref Unsafe.As<Vector128<float>, FixedArray4<float>>(ref value);
                ref FixedArray4<int> p = ref Unsafe.As<Vector128<int>, FixedArray4<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I3));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNegative(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsNegative_Basic(Vector128<double> value) {
                UnsafeUtil.SkipInit(out Vector128<long> rt);
                ref FixedArray2<double> pvalue = ref Unsafe.As<Vector128<double>, FixedArray2<double>>(ref value);
                ref FixedArray2<long> p = ref Unsafe.As<Vector128<long>, FixedArray2<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I1));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YIsNegative(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YIsNegative_Basic(Vector128<sbyte> value) {
                UnsafeUtil.SkipInit(out Vector128<sbyte> rt);
                ref FixedArray16<sbyte> pvalue = ref Unsafe.As<Vector128<sbyte>, FixedArray16<sbyte>>(ref value);
                ref FixedArray16<sbyte> p = ref Unsafe.As<Vector128<sbyte>, FixedArray16<sbyte>>(ref rt);
                p.I0 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I0));
                p.I1 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I1));
                p.I2 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I2));
                p.I3 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I3));
                p.I4 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I4));
                p.I5 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I5));
                p.I6 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I6));
                p.I7 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I7));
                p.I8 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I8));
                p.I9 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I9));
                p.I10 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I10));
                p.I11 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I11));
                p.I12 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I12));
                p.I13 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I13));
                p.I14 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I14));
                p.I15 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I15));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNegative(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YIsNegative_Basic(Vector128<short> value) {
                UnsafeUtil.SkipInit(out Vector128<short> rt);
                ref FixedArray8<short> pvalue = ref Unsafe.As<Vector128<short>, FixedArray8<short>>(ref value);
                ref FixedArray8<short> p = ref Unsafe.As<Vector128<short>, FixedArray8<short>>(ref rt);
                p.I0 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I0));
                p.I1 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I1));
                p.I2 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I2));
                p.I3 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I3));
                p.I4 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I4));
                p.I5 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I5));
                p.I6 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I6));
                p.I7 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNegative(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsNegative_Basic(Vector128<int> value) {
                UnsafeUtil.SkipInit(out Vector128<int> rt);
                ref FixedArray4<int> pvalue = ref Unsafe.As<Vector128<int>, FixedArray4<int>>(ref value);
                ref FixedArray4<int> p = ref Unsafe.As<Vector128<int>, FixedArray4<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I3));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNegative(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsNegative_Basic(Vector128<long> value) {
                UnsafeUtil.SkipInit(out Vector128<long> rt);
                ref FixedArray2<long> pvalue = ref Unsafe.As<Vector128<long>, FixedArray2<long>>(ref value);
                ref FixedArray2<long> p = ref Unsafe.As<Vector128<long>, FixedArray2<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I1));
                return rt;
            }

#if VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits128.YIsNegative(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsNegative_Bit(Vector128<float> value) {
                return YIsNegative_Bit(value.AsInt32());
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNegative(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsNegative_Bit(Vector128<double> value) {
                return YIsNegative_Bit(value.AsInt64());
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNegative(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YIsNegative_Bit(Vector128<sbyte> value) {
                Vector128<sbyte> rt = Vector128.LessThan(value, Vector128<sbyte>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNegative(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YIsNegative_Bit(Vector128<short> value) {
                //Vector128<short> rt = Vector128.LessThan(value, Vector128<short>.Zero);
                Vector128<short> rt = Vector128.ShiftRightArithmetic(value, 15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNegative(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsNegative_Bit(Vector128<int> value) {
                //Vector128<int> rt = Vector128.LessThan(value, Vector128<int>.Zero);
                Vector128<int> rt = Vector128.ShiftRightArithmetic(value, 31);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNegative(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsNegative_Bit(Vector128<long> value) {
                Vector128<long> rt = Vector128.LessThan(value, Vector128<long>.Zero);
                return rt;
            }
#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits128.YIsNegativeInfinity_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNegativeInfinity_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if VECTOR_HAS_METHOD
                    rt |= (TypeCodeFlags.Single | TypeCodeFlags.Double) & Equals_AcceleratedTypes;
#endif // VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNegativeInfinity(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsNegativeInfinity(Vector128<float> value) {
#if VECTOR_HAS_METHOD
                return YIsNegativeInfinity_Bit(value);
#else
                return YIsNegativeInfinity_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNegativeInfinity(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsNegativeInfinity(Vector128<double> value) {
#if VECTOR_HAS_METHOD
                return YIsNegativeInfinity_Bit(value);
#else
                return YIsNegativeInfinity_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNegativeInfinity(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsNegativeInfinity_Basic(Vector128<float> value) {
                UnsafeUtil.SkipInit(out Vector128<int> rt);
                ref FixedArray4<float> pvalue = ref Unsafe.As<Vector128<float>, FixedArray4<float>>(ref value);
                ref FixedArray4<int> p = ref Unsafe.As<Vector128<int>, FixedArray4<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeInfinity(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeInfinity(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeInfinity(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeInfinity(pvalue.I3));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNegativeInfinity(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsNegativeInfinity_Basic(Vector128<double> value) {
                UnsafeUtil.SkipInit(out Vector128<long> rt);
                ref FixedArray2<double> pvalue = ref Unsafe.As<Vector128<double>, FixedArray2<double>>(ref value);
                ref FixedArray2<long> p = ref Unsafe.As<Vector128<long>, FixedArray2<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeInfinity(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeInfinity(pvalue.I1));
                return rt;
            }

#if VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits128.YIsNegativeInfinity(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsNegativeInfinity_Bit(Vector128<float> value) {
                Vector128<float> sample = Vector128.Create(float.NegativeInfinity);
                Vector128<int> rt = Vector128.Equals(value, sample).AsInt32();
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNegativeInfinity(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsNegativeInfinity_Bit(Vector128<double> value) {
                Vector128<double> sample = Vector128.Create(double.NegativeInfinity);
                Vector128<long> rt = Vector128.Equals(value, sample).AsInt64();
                return rt;
            }
#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits128.YIsNegativeZero_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNegativeZero_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if VECTOR_HAS_METHOD
                    rt |= TypeCodeFlags.Single;
                    rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double);
#endif // VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNegativeZero(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsNegativeZero(Vector128<float> value) {
#if VECTOR_HAS_METHOD
                return YIsNegativeZero_Bit(value);
#else
                return YIsNegativeZero_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNegativeZero(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsNegativeZero(Vector128<double> value) {
#if VECTOR_HAS_METHOD
                return YIsNegativeZero_Bit(value);
#else
                return YIsNegativeZero_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNegativeZero(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsNegativeZero_Basic(Vector128<float> value) {
                UnsafeUtil.SkipInit(out Vector128<int> rt);
                ref FixedArray4<float> pvalue = ref Unsafe.As<Vector128<float>, FixedArray4<float>>(ref value);
                ref FixedArray4<int> p = ref Unsafe.As<Vector128<int>, FixedArray4<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeZero(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeZero(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeZero(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeZero(pvalue.I3));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNegativeZero(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsNegativeZero_Basic(Vector128<double> value) {
                UnsafeUtil.SkipInit(out Vector128<long> rt);
                ref FixedArray2<double> pvalue = ref Unsafe.As<Vector128<double>, FixedArray2<double>>(ref value);
                ref FixedArray2<long> p = ref Unsafe.As<Vector128<long>, FixedArray2<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeZero(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeZero(pvalue.I1));
                return rt;
            }

#if VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits128.YIsNegativeZero(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsNegativeZero_Bit(Vector128<float> value) {
                Vector128<int> signMask = Vector128Constants.Single_SignMask.AsInt32();
                Vector128<int> rt = Vector128.Equals(value.AsInt32(), signMask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNegativeZero(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsNegativeZero_Bit(Vector128<double> value) {
                Vector128<long> signMask = Vector128Constants.Double_SignMask.AsInt64();
                Vector128<long> rt = Vector128.Equals(value.AsInt64(), signMask);
                return rt;
            }
#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits128.YIsNormal_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNormal_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if VECTOR_HAS_METHOD
                    rt |= TypeCodeFlagsUtil.MapFlags(GreaterThan_AcceleratedTypes, TypeCodeFlags.Int32, TypeCodeFlags.Single, TypeCodeFlags.Int64, TypeCodeFlags.Double);
#endif // VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNormal(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsNormal(Vector128<float> value) {
#if VECTOR_HAS_METHOD
                return YIsNormal_Bit(value);
#else
                return YIsNormal_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNormal(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsNormal(Vector128<double> value) {
#if VECTOR_HAS_METHOD
                return YIsNormal_Bit(value);
#else
                return YIsNormal_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNormal(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsNormal_Basic(Vector128<float> value) {
                UnsafeUtil.SkipInit(out Vector128<int> rt);
                ref FixedArray4<float> pvalue = ref Unsafe.As<Vector128<float>, FixedArray4<float>>(ref value);
                ref FixedArray4<int> p = ref Unsafe.As<Vector128<int>, FixedArray4<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsNormal(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsNormal(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsNormal(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsNormal(pvalue.I3));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNormal(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsNormal_Basic(Vector128<double> value) {
                UnsafeUtil.SkipInit(out Vector128<long> rt);
                ref FixedArray2<double> pvalue = ref Unsafe.As<Vector128<double>, FixedArray2<double>>(ref value);
                ref FixedArray2<long> p = ref Unsafe.As<Vector128<long>, FixedArray2<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsNormal(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsNormal(pvalue.I1));
                return rt;
            }

#if VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits128.YIsNormal(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsNormal_Bit(Vector128<float> value) {
                Vector128<int> exponentMask = Vector128Constants.Single_ExponentMask.AsInt32();
                Vector128<int> exponent = Vector128.BitwiseAnd(value.AsInt32(), exponentMask);
                Vector128<int> rt = Vector128.BitwiseAnd(Vector128.GreaterThan(exponent, Vector128<int>.Zero), Vector128.GreaterThan(exponentMask, exponent));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNormal(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsNormal_Bit(Vector128<double> value) {
                Vector128<long> exponentMask = Vector128Constants.Double_ExponentMask.AsInt64();
                Vector128<long> exponent = Vector128.BitwiseAnd(value.AsInt64(), exponentMask);
                Vector128<long> rt = Vector128.BitwiseAnd(Vector128.GreaterThan(exponent, Vector128<long>.Zero), Vector128.GreaterThan(exponentMask, exponent));
                return rt;
            }
#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits128.YIsNotNaN_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNotNaN_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if VECTOR_HAS_METHOD
                    rt |= (TypeCodeFlags.Single | TypeCodeFlags.Double) & Equals_AcceleratedTypes;
#endif // VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNotNaN(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsNotNaN(Vector128<float> value) {
#if VECTOR_HAS_METHOD
                return YIsNotNaN_Bit(value);
#else
                return YIsNotNaN_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNotNaN(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsNotNaN(Vector128<double> value) {
#if VECTOR_HAS_METHOD
                return YIsNotNaN_Bit(value);
#else
                return YIsNotNaN_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNotNaN(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsNotNaN_Basic(Vector128<float> value) {
                UnsafeUtil.SkipInit(out Vector128<int> rt);
                ref FixedArray4<float> pvalue = ref Unsafe.As<Vector128<float>, FixedArray4<float>>(ref value);
                ref FixedArray4<int> p = ref Unsafe.As<Vector128<int>, FixedArray4<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsNotNaN(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsNotNaN(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsNotNaN(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsNotNaN(pvalue.I3));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNotNaN(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsNotNaN_Basic(Vector128<double> value) {
                UnsafeUtil.SkipInit(out Vector128<long> rt);
                ref FixedArray2<double> pvalue = ref Unsafe.As<Vector128<double>, FixedArray2<double>>(ref value);
                ref FixedArray2<long> p = ref Unsafe.As<Vector128<long>, FixedArray2<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsNotNaN(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsNotNaN(pvalue.I1));
                return rt;
            }

#if VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits128.YIsNotNaN(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsNotNaN_Bit(Vector128<float> value) {
#pragma warning disable CS1718 // Comparison made to same variable; did you mean to compare something else?
                Vector128<int> rt = Vector128.Equals(value, value).AsInt32();
#pragma warning restore CS1718 // Comparison made to same variable; did you mean to compare something else?
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsNotNaN(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsNotNaN_Bit(Vector128<double> value) {
#pragma warning disable CS1718 // Comparison made to same variable; did you mean to compare something else?
                Vector128<long> rt = Vector128.Equals(value, value).AsInt64();
#pragma warning restore CS1718 // Comparison made to same variable; did you mean to compare something else?
                return rt;
            }
#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger_AcceleratedTypes"/>
            public static TypeCodeFlags YIsOddInteger_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if VECTOR_HAS_METHOD
                    rt |= TypeCodeFlagsUtil.IntTypes & Equals_AcceleratedTypes;
                    rt |= (TypeCodeFlags.Single | TypeCodeFlags.Double) & YIsInteger_AcceleratedTypes & Floor_AcceleratedTypes;
#endif // VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsOddInteger(Vector128<float> value) {
#if VECTOR_HAS_METHOD
                return YIsOddInteger_Bit(value);
#else
                return YIsOddInteger_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsOddInteger(Vector128<double> value) {
#if VECTOR_HAS_METHOD
                return YIsOddInteger_Bit(value);
#else
                return YIsOddInteger_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YIsOddInteger(Vector128<sbyte> value) {
#if VECTOR_HAS_METHOD
                return YIsOddInteger_Bit(value);
#else
                return YIsOddInteger_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YIsOddInteger(Vector128<byte> value) {
#if VECTOR_HAS_METHOD
                return YIsOddInteger_Bit(value);
#else
                return YIsOddInteger_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YIsOddInteger(Vector128<short> value) {
#if VECTOR_HAS_METHOD
                return YIsOddInteger_Bit(value);
#else
                return YIsOddInteger_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YIsOddInteger(Vector128<ushort> value) {
#if VECTOR_HAS_METHOD
                return YIsOddInteger_Bit(value);
#else
                return YIsOddInteger_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsOddInteger(Vector128<int> value) {
#if VECTOR_HAS_METHOD
                return YIsOddInteger_Bit(value);
#else
                return YIsOddInteger_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YIsOddInteger(Vector128<uint> value) {
#if VECTOR_HAS_METHOD
                return YIsOddInteger_Bit(value);
#else
                return YIsOddInteger_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsOddInteger(Vector128<long> value) {
#if VECTOR_HAS_METHOD
                return YIsOddInteger_Bit(value);
#else
                return YIsOddInteger_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YIsOddInteger(Vector128<ulong> value) {
#if VECTOR_HAS_METHOD
                return YIsOddInteger_Bit(value);
#else
                return YIsOddInteger_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsOddInteger_Basic(Vector128<float> value) {
                UnsafeUtil.SkipInit(out Vector128<int> rt);
                ref FixedArray4<float> pvalue = ref Unsafe.As<Vector128<float>, FixedArray4<float>>(ref value);
                ref FixedArray4<int> p = ref Unsafe.As<Vector128<int>, FixedArray4<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I3));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsOddInteger_Basic(Vector128<double> value) {
                UnsafeUtil.SkipInit(out Vector128<long> rt);
                ref FixedArray2<double> pvalue = ref Unsafe.As<Vector128<double>, FixedArray2<double>>(ref value);
                ref FixedArray2<long> p = ref Unsafe.As<Vector128<long>, FixedArray2<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I1));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YIsOddInteger_Basic(Vector128<sbyte> value) {
                UnsafeUtil.SkipInit(out Vector128<sbyte> rt);
                ref FixedArray16<sbyte> pvalue = ref Unsafe.As<Vector128<sbyte>, FixedArray16<sbyte>>(ref value);
                ref FixedArray16<sbyte> p = ref Unsafe.As<Vector128<sbyte>, FixedArray16<sbyte>>(ref rt);
                p.I0 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I0));
                p.I1 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I1));
                p.I2 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I2));
                p.I3 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I3));
                p.I4 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I4));
                p.I5 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I5));
                p.I6 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I6));
                p.I7 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I7));
                p.I8 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I8));
                p.I9 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I9));
                p.I10 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I10));
                p.I11 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I11));
                p.I12 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I12));
                p.I13 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I13));
                p.I14 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I14));
                p.I15 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I15));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YIsOddInteger_Basic(Vector128<byte> value) {
                return YIsOddInteger_Basic(value.AsSByte()).AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YIsOddInteger_Basic(Vector128<short> value) {
                UnsafeUtil.SkipInit(out Vector128<short> rt);
                ref FixedArray8<short> pvalue = ref Unsafe.As<Vector128<short>, FixedArray8<short>>(ref value);
                ref FixedArray8<short> p = ref Unsafe.As<Vector128<short>, FixedArray8<short>>(ref rt);
                p.I0 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I0));
                p.I1 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I1));
                p.I2 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I2));
                p.I3 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I3));
                p.I4 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I4));
                p.I5 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I5));
                p.I6 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I6));
                p.I7 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YIsOddInteger_Basic(Vector128<ushort> value) {
                return YIsOddInteger_Basic(value.AsInt16()).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsOddInteger_Basic(Vector128<int> value) {
                UnsafeUtil.SkipInit(out Vector128<int> rt);
                ref FixedArray4<int> pvalue = ref Unsafe.As<Vector128<int>, FixedArray4<int>>(ref value);
                ref FixedArray4<int> p = ref Unsafe.As<Vector128<int>, FixedArray4<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I3));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YIsOddInteger_Basic(Vector128<uint> value) {
                return YIsOddInteger_Basic(value.AsInt32()).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsOddInteger_Basic(Vector128<long> value) {
                UnsafeUtil.SkipInit(out Vector128<long> rt);
                ref FixedArray2<long> pvalue = ref Unsafe.As<Vector128<long>, FixedArray2<long>>(ref value);
                ref FixedArray2<long> p = ref Unsafe.As<Vector128<long>, FixedArray2<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I1));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YIsOddInteger_Basic(Vector128<ulong> value) {
                return YIsOddInteger_Basic(value.AsInt64()).AsUInt64();
            }

#if VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsOddInteger_Bit(Vector128<float> value) {
                Vector128<float> valueHalf = Vector128.Multiply(value, 0.5f);
                Vector128<float> valueHalfTrun = Vector128.Floor(valueHalf);
                Vector128<int> intMask = YIsInteger(value);
                Vector128<int> halfEqual = Vector128.Equals(valueHalf, valueHalfTrun).AsInt32();
                Vector128<int> rt = Vector128.AndNot(intMask, halfEqual);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsOddInteger_Bit(Vector128<double> value) {
                Vector128<double> valueHalf = Vector128.Multiply(value, 0.5);
                Vector128<double> valueHalfTrun = Vector128.Floor(valueHalf);
                Vector128<long> intMask = YIsInteger(value);
                Vector128<long> halfEqual = Vector128.Equals(valueHalf, valueHalfTrun).AsInt64();
                Vector128<long> rt = Vector128.AndNot(intMask, halfEqual);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YIsOddInteger_Bit(Vector128<sbyte> value) {
                Vector128<sbyte> temp = Vector128.BitwiseAnd(value, Vector128Constants.Byte_One.AsSByte());
                Vector128<sbyte> rt = Vector128.GreaterThan(temp, Vector128<sbyte>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YIsOddInteger_Bit(Vector128<byte> value) {
                return YIsOddInteger_Bit(value.AsSByte()).AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YIsOddInteger_Bit(Vector128<short> value) {
                Vector128<short> temp = Vector128.BitwiseAnd(value, Vector128Constants.Int16_One);
                Vector128<short> rt = Vector128.GreaterThan(temp, Vector128<short>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YIsOddInteger_Bit(Vector128<ushort> value) {
                return YIsOddInteger_Bit(value.AsInt16()).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsOddInteger_Bit(Vector128<int> value) {
                Vector128<int> temp = Vector128.BitwiseAnd(value, Vector128Constants.Int32_One);
                Vector128<int> rt = Vector128.GreaterThan(temp, Vector128<int>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YIsOddInteger_Bit(Vector128<uint> value) {
                return YIsOddInteger_Bit(value.AsInt32()).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsOddInteger_Bit(Vector128<long> value) {
                Vector128<long> temp = Vector128.BitwiseAnd(value, Vector128Constants.Int64_One);
                Vector128<long> rt = Vector128.GreaterThan(temp, Vector128<long>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YIsOddInteger_Bit(Vector128<ulong> value) {
                return YIsOddInteger_Bit(value.AsInt64()).AsUInt64();
            }
#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits128.YIsPositive_AcceleratedTypes"/>
            public static TypeCodeFlags YIsPositive_AcceleratedTypes {
                get {
                    return YIsNegative_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsPositive(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsPositive(Vector128<float> value) {
#if VECTOR_HAS_METHOD
                return YIsPositive_Bit(value);
#else
                return YIsPositive_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsPositive(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsPositive(Vector128<double> value) {
#if VECTOR_HAS_METHOD
                return YIsPositive_Bit(value);
#else
                return YIsPositive_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsPositive(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YIsPositive(Vector128<sbyte> value) {
#if VECTOR_HAS_METHOD
                return YIsPositive_Bit(value);
#else
                return YIsPositive_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsPositive(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YIsPositive(Vector128<short> value) {
#if VECTOR_HAS_METHOD
                return YIsPositive_Bit(value);
#else
                return YIsPositive_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsPositive(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsPositive(Vector128<int> value) {
#if VECTOR_HAS_METHOD
                return YIsPositive_Bit(value);
#else
                return YIsPositive_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsPositive(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsPositive(Vector128<long> value) {
#if VECTOR_HAS_METHOD
                return YIsPositive_Bit(value);
#else
                return YIsPositive_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsPositive(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsPositive_Basic(Vector128<float> value) {
                UnsafeUtil.SkipInit(out Vector128<int> rt);
                ref FixedArray4<float> pvalue = ref Unsafe.As<Vector128<float>, FixedArray4<float>>(ref value);
                ref FixedArray4<int> p = ref Unsafe.As<Vector128<int>, FixedArray4<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I3));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsPositive(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsPositive_Basic(Vector128<double> value) {
                UnsafeUtil.SkipInit(out Vector128<long> rt);
                ref FixedArray2<double> pvalue = ref Unsafe.As<Vector128<double>, FixedArray2<double>>(ref value);
                ref FixedArray2<long> p = ref Unsafe.As<Vector128<long>, FixedArray2<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I1));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YIsPositive(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YIsPositive_Basic(Vector128<sbyte> value) {
                UnsafeUtil.SkipInit(out Vector128<sbyte> rt);
                ref FixedArray16<sbyte> pvalue = ref Unsafe.As<Vector128<sbyte>, FixedArray16<sbyte>>(ref value);
                ref FixedArray16<sbyte> p = ref Unsafe.As<Vector128<sbyte>, FixedArray16<sbyte>>(ref rt);
                p.I0 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I0));
                p.I1 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I1));
                p.I2 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I2));
                p.I3 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I3));
                p.I4 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I4));
                p.I5 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I5));
                p.I6 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I6));
                p.I7 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I7));
                p.I8 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I8));
                p.I9 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I9));
                p.I10 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I10));
                p.I11 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I11));
                p.I12 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I12));
                p.I13 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I13));
                p.I14 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I14));
                p.I15 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I15));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsPositive(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YIsPositive_Basic(Vector128<short> value) {
                UnsafeUtil.SkipInit(out Vector128<short> rt);
                ref FixedArray8<short> pvalue = ref Unsafe.As<Vector128<short>, FixedArray8<short>>(ref value);
                ref FixedArray8<short> p = ref Unsafe.As<Vector128<short>, FixedArray8<short>>(ref rt);
                p.I0 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I0));
                p.I1 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I1));
                p.I2 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I2));
                p.I3 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I3));
                p.I4 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I4));
                p.I5 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I5));
                p.I6 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I6));
                p.I7 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsPositive(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsPositive_Basic(Vector128<int> value) {
                UnsafeUtil.SkipInit(out Vector128<int> rt);
                ref FixedArray4<int> pvalue = ref Unsafe.As<Vector128<int>, FixedArray4<int>>(ref value);
                ref FixedArray4<int> p = ref Unsafe.As<Vector128<int>, FixedArray4<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I3));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsPositive(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsPositive_Basic(Vector128<long> value) {
                UnsafeUtil.SkipInit(out Vector128<long> rt);
                ref FixedArray2<long> pvalue = ref Unsafe.As<Vector128<long>, FixedArray2<long>>(ref value);
                ref FixedArray2<long> p = ref Unsafe.As<Vector128<long>, FixedArray2<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I1));
                return rt;
            }

#if VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits128.YIsPositive(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsPositive_Bit(Vector128<float> value) {
                return YIsPositive_Bit(value.AsInt32());
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsPositive(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsPositive_Bit(Vector128<double> value) {
                return YIsPositive_Bit(value.AsInt64());
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsPositive(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YIsPositive_Bit(Vector128<sbyte> value) {
                Vector128<sbyte> rt = Vector128.OnesComplement(YIsNegative(value));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsPositive(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YIsPositive_Bit(Vector128<short> value) {
                Vector128<short> rt = Vector128.OnesComplement(YIsNegative(value));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsPositive(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsPositive_Bit(Vector128<int> value) {
                Vector128<int> rt = Vector128.OnesComplement(YIsNegative(value));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsPositive(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsPositive_Bit(Vector128<long> value) {
                Vector128<long> rt = Vector128.OnesComplement(YIsNegative(value));
                return rt;
            }
#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits128.YIsPositiveInfinity_AcceleratedTypes"/>
            public static TypeCodeFlags YIsPositiveInfinity_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if VECTOR_HAS_METHOD
                    rt |= (TypeCodeFlags.Single | TypeCodeFlags.Double) & Equals_AcceleratedTypes;
#endif // VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsPositiveInfinity(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsPositiveInfinity(Vector128<float> value) {
#if VECTOR_HAS_METHOD
                return YIsPositiveInfinity_Bit(value);
#else
                return YIsPositiveInfinity_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsPositiveInfinity(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsPositiveInfinity(Vector128<double> value) {
#if VECTOR_HAS_METHOD
                return YIsPositiveInfinity_Bit(value);
#else
                return YIsPositiveInfinity_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsPositiveInfinity(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsPositiveInfinity_Basic(Vector128<float> value) {
                UnsafeUtil.SkipInit(out Vector128<int> rt);
                ref FixedArray4<float> pvalue = ref Unsafe.As<Vector128<float>, FixedArray4<float>>(ref value);
                ref FixedArray4<int> p = ref Unsafe.As<Vector128<int>, FixedArray4<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositiveInfinity(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositiveInfinity(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositiveInfinity(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositiveInfinity(pvalue.I3));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsPositiveInfinity(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsPositiveInfinity_Basic(Vector128<double> value) {
                UnsafeUtil.SkipInit(out Vector128<long> rt);
                ref FixedArray2<double> pvalue = ref Unsafe.As<Vector128<double>, FixedArray2<double>>(ref value);
                ref FixedArray2<long> p = ref Unsafe.As<Vector128<long>, FixedArray2<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositiveInfinity(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositiveInfinity(pvalue.I1));
                return rt;
            }

#if VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits128.YIsPositiveInfinity(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsPositiveInfinity_Bit(Vector128<float> value) {
                Vector128<float> sample = Vector128.Create(float.NegativeInfinity);
                Vector128<int> rt = Vector128.Equals(value, sample).AsInt32();
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsPositiveInfinity(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsPositiveInfinity_Bit(Vector128<double> value) {
                Vector128<double> sample = Vector128.Create(double.NegativeInfinity);
                Vector128<long> rt = Vector128.Equals(value, sample).AsInt64();
                return rt;
            }
#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits128.YIsSubnormal_AcceleratedTypes"/>
            public static TypeCodeFlags YIsSubnormal_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if VECTOR_HAS_METHOD
                    rt |= TypeCodeFlags.Single;
                    rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes & GreaterThan_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double);
#endif // VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsSubnormal(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsSubnormal(Vector128<float> value) {
#if VECTOR_HAS_METHOD
                return YIsSubnormal_Bit(value);
#else
                return YIsSubnormal_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsSubnormal(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsSubnormal(Vector128<double> value) {
#if VECTOR_HAS_METHOD
                return YIsSubnormal_Bit(value);
#else
                return YIsSubnormal_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsSubnormal(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsSubnormal_Basic(Vector128<float> value) {
                UnsafeUtil.SkipInit(out Vector128<int> rt);
                ref FixedArray4<float> pvalue = ref Unsafe.As<Vector128<float>, FixedArray4<float>>(ref value);
                ref FixedArray4<int> p = ref Unsafe.As<Vector128<int>, FixedArray4<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsSubnormal(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsSubnormal(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsSubnormal(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsSubnormal(pvalue.I3));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsSubnormal(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsSubnormal_Basic(Vector128<double> value) {
                UnsafeUtil.SkipInit(out Vector128<long> rt);
                ref FixedArray2<double> pvalue = ref Unsafe.As<Vector128<double>, FixedArray2<double>>(ref value);
                ref FixedArray2<long> p = ref Unsafe.As<Vector128<long>, FixedArray2<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsSubnormal(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsSubnormal(pvalue.I1));
                return rt;
            }

#if VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits128.YIsSubnormal(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsSubnormal_Bit(Vector128<float> value) {
                Vector128<int> exponentMask = Vector128Constants.Single_ExponentMask.AsInt32();
                Vector128<int> mantissaMask = Vector128Constants.Single_MantissaMask.AsInt32();
                Vector128<int> zero = Vector128<int>.Zero;
                Vector128<int> exponent = Vector128.BitwiseAnd(value.AsInt32(), exponentMask);
                Vector128<int> mantissa = Vector128.BitwiseAnd(value.AsInt32(), mantissaMask);
                Vector128<int> rt = Vector128.BitwiseAnd(Vector128.Equals(exponent, zero), Vector128.GreaterThan(mantissa, zero));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsSubnormal(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsSubnormal_Bit(Vector128<double> value) {
                Vector128<long> exponentMask = Vector128Constants.Double_ExponentMask.AsInt64();
                Vector128<long> mantissaMask = Vector128Constants.Double_MantissaMask.AsInt64();
                Vector128<long> zero = Vector128<long>.Zero;
                Vector128<long> exponent = Vector128.BitwiseAnd(value.AsInt64(), exponentMask);
                Vector128<long> mantissa = Vector128.BitwiseAnd(value.AsInt64(), mantissaMask);
                Vector128<long> rt = Vector128.BitwiseAnd(Vector128.Equals(exponent, zero), Vector128.GreaterThan(mantissa, zero));
                return rt;
            }
#endif // VECTOR_HAS_METHOD


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
#if VECTOR_HAS_METHOD
                return YIsZero_Bit(value);
#else
                return YIsZero_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsZero(Vector128<double> value) {
#if VECTOR_HAS_METHOD
                return YIsZero_Bit(value);
#else
                return YIsZero_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YIsZero(Vector128<sbyte> value) {
#if VECTOR_HAS_METHOD
                return YIsZero_Bit(value);
#else
                return YIsZero_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YIsZero(Vector128<byte> value) {
#if VECTOR_HAS_METHOD
                return YIsZero_Bit(value);
#else
                return YIsZero_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YIsZero(Vector128<short> value) {
#if VECTOR_HAS_METHOD
                return YIsZero_Bit(value);
#else
                return YIsZero_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YIsZero(Vector128<ushort> value) {
#if VECTOR_HAS_METHOD
                return YIsZero_Bit(value);
#else
                return YIsZero_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsZero(Vector128<int> value) {
#if VECTOR_HAS_METHOD
                return YIsZero_Bit(value);
#else
                return YIsZero_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YIsZero(Vector128<uint> value) {
#if VECTOR_HAS_METHOD
                return YIsZero_Bit(value);
#else
                return YIsZero_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsZero(Vector128<long> value) {
#if VECTOR_HAS_METHOD
                return YIsZero_Bit(value);
#else
                return YIsZero_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YIsZero(Vector128<ulong> value) {
#if VECTOR_HAS_METHOD
                return YIsZero_Bit(value);
#else
                return YIsZero_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsZero_Basic(Vector128<float> value) {
                UnsafeUtil.SkipInit(out Vector128<int> rt);
                ref FixedArray4<float> pvalue = ref Unsafe.As<Vector128<float>, FixedArray4<float>>(ref value);
                ref FixedArray4<int> p = ref Unsafe.As<Vector128<int>, FixedArray4<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I3));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsZero_Basic(Vector128<double> value) {
                UnsafeUtil.SkipInit(out Vector128<long> rt);
                ref FixedArray2<double> pvalue = ref Unsafe.As<Vector128<double>, FixedArray2<double>>(ref value);
                ref FixedArray2<long> p = ref Unsafe.As<Vector128<long>, FixedArray2<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I1));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YIsZero_Basic(Vector128<sbyte> value) {
                UnsafeUtil.SkipInit(out Vector128<sbyte> rt);
                ref FixedArray16<sbyte> pvalue = ref Unsafe.As<Vector128<sbyte>, FixedArray16<sbyte>>(ref value);
                ref FixedArray16<sbyte> p = ref Unsafe.As<Vector128<sbyte>, FixedArray16<sbyte>>(ref rt);
                p.I0 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I0));
                p.I1 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I1));
                p.I2 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I2));
                p.I3 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I3));
                p.I4 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I4));
                p.I5 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I5));
                p.I6 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I6));
                p.I7 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I7));
                p.I8 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I8));
                p.I9 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I9));
                p.I10 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I10));
                p.I11 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I11));
                p.I12 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I12));
                p.I13 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I13));
                p.I14 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I14));
                p.I15 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I15));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YIsZero_Basic(Vector128<byte> value) {
                return YIsZero_Basic(value.AsSByte()).AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YIsZero_Basic(Vector128<short> value) {
                UnsafeUtil.SkipInit(out Vector128<short> rt);
                ref FixedArray8<short> pvalue = ref Unsafe.As<Vector128<short>, FixedArray8<short>>(ref value);
                ref FixedArray8<short> p = ref Unsafe.As<Vector128<short>, FixedArray8<short>>(ref rt);
                p.I0 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I0));
                p.I1 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I1));
                p.I2 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I2));
                p.I3 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I3));
                p.I4 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I4));
                p.I5 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I5));
                p.I6 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I6));
                p.I7 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YIsZero_Basic(Vector128<ushort> value) {
                return YIsZero_Basic(value.AsInt16()).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsZero_Basic(Vector128<int> value) {
                UnsafeUtil.SkipInit(out Vector128<int> rt);
                ref FixedArray4<int> pvalue = ref Unsafe.As<Vector128<int>, FixedArray4<int>>(ref value);
                ref FixedArray4<int> p = ref Unsafe.As<Vector128<int>, FixedArray4<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I3));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YIsZero_Basic(Vector128<uint> value) {
                return YIsZero_Basic(value.AsInt32()).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsZero_Basic(Vector128<long> value) {
                UnsafeUtil.SkipInit(out Vector128<long> rt);
                ref FixedArray2<long> pvalue = ref Unsafe.As<Vector128<long>, FixedArray2<long>>(ref value);
                ref FixedArray2<long> p = ref Unsafe.As<Vector128<long>, FixedArray2<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I1));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YIsZero_Basic(Vector128<ulong> value) {
                return YIsZero_Basic(value.AsInt64()).AsUInt64();
            }

#if VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsZero_Bit(Vector128<float> value) {
                return Vector128.Equals(Vector128<float>.Zero, value).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsZero_Bit(Vector128<double> value) {
                return Vector128.Equals(Vector128<double>.Zero, value).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YIsZero_Bit(Vector128<sbyte> value) {
                return Vector128.Equals(Vector128<sbyte>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YIsZero_Bit(Vector128<byte> value) {
                return Vector128.Equals(Vector128<byte>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YIsZero_Bit(Vector128<short> value) {
                return Vector128.Equals(Vector128<short>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YIsZero_Bit(Vector128<ushort> value) {
                return Vector128.Equals(Vector128<ushort>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsZero_Bit(Vector128<int> value) {
                return Vector128.Equals(Vector128<int>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YIsZero_Bit(Vector128<uint> value) {
                return Vector128.Equals(Vector128<uint>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsZero_Bit(Vector128<long> value) {
                return Vector128.Equals(Vector128<long>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YIsZero_Bit(Vector128<ulong> value) {
                return Vector128.Equals(Vector128<ulong>.Zero, value);
            }
#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits128.YIsZeroOrSubnormal_AcceleratedTypes"/>
            public static TypeCodeFlags YIsZeroOrSubnormal_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if VECTOR_HAS_METHOD
                    rt |= TypeCodeFlags.Single;
                    rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double);
#endif // VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZeroOrSubnormal(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsZeroOrSubnormal(Vector128<float> value) {
#if VECTOR_HAS_METHOD
                return YIsZeroOrSubnormal_Bit(value);
#else
                return YIsZeroOrSubnormal_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZeroOrSubnormal(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsZeroOrSubnormal(Vector128<double> value) {
#if VECTOR_HAS_METHOD
                return YIsZeroOrSubnormal_Bit(value);
#else
                return YIsZeroOrSubnormal_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZeroOrSubnormal(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsZeroOrSubnormal_Basic(Vector128<float> value) {
                UnsafeUtil.SkipInit(out Vector128<int> rt);
                ref FixedArray4<float> pvalue = ref Unsafe.As<Vector128<float>, FixedArray4<float>>(ref value);
                ref FixedArray4<int> p = ref Unsafe.As<Vector128<int>, FixedArray4<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsZeroOrSubnormal(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsZeroOrSubnormal(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsZeroOrSubnormal(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsZeroOrSubnormal(pvalue.I3));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZeroOrSubnormal(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsZeroOrSubnormal_Basic(Vector128<double> value) {
                UnsafeUtil.SkipInit(out Vector128<long> rt);
                ref FixedArray2<double> pvalue = ref Unsafe.As<Vector128<double>, FixedArray2<double>>(ref value);
                ref FixedArray2<long> p = ref Unsafe.As<Vector128<long>, FixedArray2<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsZeroOrSubnormal(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsZeroOrSubnormal(pvalue.I1));
                return rt;
            }

#if VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits128.YIsZeroOrSubnormal(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YIsZeroOrSubnormal_Bit(Vector128<float> value) {
                Vector128<int> exponentMask = Vector128Constants.Single_ExponentMask.AsInt32();
                Vector128<int> exponent = Vector128.BitwiseAnd(value.AsInt32(), exponentMask);
                Vector128<int> rt = Vector128.Equals(exponent, Vector128<int>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsZeroOrSubnormal(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YIsZeroOrSubnormal_Bit(Vector128<double> value) {
                Vector128<long> exponentMask = Vector128Constants.Double_ExponentMask.AsInt64();
                Vector128<long> exponent = Vector128.BitwiseAnd(value.AsInt64(), exponentMask);
                Vector128<long> rt = Vector128.Equals(exponent, Vector128<long>.Zero);
                return rt;
            }
#endif // VECTOR_HAS_METHOD

#endif // NETCOREAPP3_0_OR_GREATER
        }
    }
}
