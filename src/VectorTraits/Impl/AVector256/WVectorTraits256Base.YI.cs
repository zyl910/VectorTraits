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


            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger_AcceleratedTypes"/>
            public static TypeCodeFlags YIsEvenInteger_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if NET7_0_OR_GREATER
                    rt |= TypeCodeFlagsUtil.IntTypes & Equals_AcceleratedTypes;
                    rt |= (TypeCodeFlags.Single | TypeCodeFlags.Double) & YIsInteger_AcceleratedTypes & Floor_AcceleratedTypes;
#endif // NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsEvenInteger(Vector256<float> value) {
#if NET7_0_OR_GREATER
                return YIsEvenInteger_Bit(value);
#else
                return YIsEvenInteger_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsEvenInteger(Vector256<double> value) {
#if NET7_0_OR_GREATER
                return YIsEvenInteger_Bit(value);
#else
                return YIsEvenInteger_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YIsEvenInteger(Vector256<sbyte> value) {
#if NET7_0_OR_GREATER
                return YIsEvenInteger_Bit(value);
#else
                return YIsEvenInteger_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YIsEvenInteger(Vector256<byte> value) {
#if NET7_0_OR_GREATER
                return YIsEvenInteger_Bit(value);
#else
                return YIsEvenInteger_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YIsEvenInteger(Vector256<short> value) {
#if NET7_0_OR_GREATER
                return YIsEvenInteger_Bit(value);
#else
                return YIsEvenInteger_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YIsEvenInteger(Vector256<ushort> value) {
#if NET7_0_OR_GREATER
                return YIsEvenInteger_Bit(value);
#else
                return YIsEvenInteger_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsEvenInteger(Vector256<int> value) {
#if NET7_0_OR_GREATER
                return YIsEvenInteger_Bit(value);
#else
                return YIsEvenInteger_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YIsEvenInteger(Vector256<uint> value) {
#if NET7_0_OR_GREATER
                return YIsEvenInteger_Bit(value);
#else
                return YIsEvenInteger_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsEvenInteger(Vector256<long> value) {
#if NET7_0_OR_GREATER
                return YIsEvenInteger_Bit(value);
#else
                return YIsEvenInteger_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YIsEvenInteger(Vector256<ulong> value) {
#if NET7_0_OR_GREATER
                return YIsEvenInteger_Bit(value);
#else
                return YIsEvenInteger_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsEvenInteger_Basic(Vector256<float> value) {
                UnsafeUtil.SkipInit(out Vector256<int> rt);
                ref FixedArray8<float> pvalue = ref Unsafe.As<Vector256<float>, FixedArray8<float>>(ref value);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I3));
                p.I4 = BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I4));
                p.I5 = BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I5));
                p.I6 = BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I6));
                p.I7 = BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsEvenInteger_Basic(Vector256<double> value) {
                UnsafeUtil.SkipInit(out Vector256<long> rt);
                ref FixedArray4<double> pvalue = ref Unsafe.As<Vector256<double>, FixedArray4<double>>(ref value);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I3));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YIsEvenInteger_Basic(Vector256<sbyte> value) {
                UnsafeUtil.SkipInit(out Vector256<sbyte> rt);
                ref FixedArray32<sbyte> pvalue = ref Unsafe.As<Vector256<sbyte>, FixedArray32<sbyte>>(ref value);
                ref FixedArray32<sbyte> p = ref Unsafe.As<Vector256<sbyte>, FixedArray32<sbyte>>(ref rt);
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
                p.I16 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I16));
                p.I17 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I17));
                p.I18 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I18));
                p.I19 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I19));
                p.I20 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I20));
                p.I21 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I21));
                p.I22 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I22));
                p.I23 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I23));
                p.I24 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I24));
                p.I25 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I25));
                p.I26 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I26));
                p.I27 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I27));
                p.I28 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I28));
                p.I29 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I29));
                p.I30 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I30));
                p.I31 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I31));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YIsEvenInteger_Basic(Vector256<byte> value) {
                return YIsEvenInteger_Basic(value.AsSByte()).AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YIsEvenInteger_Basic(Vector256<short> value) {
                UnsafeUtil.SkipInit(out Vector256<short> rt);
                ref FixedArray16<short> pvalue = ref Unsafe.As<Vector256<short>, FixedArray16<short>>(ref value);
                ref FixedArray16<short> p = ref Unsafe.As<Vector256<short>, FixedArray16<short>>(ref rt);
                p.I0 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I0));
                p.I1 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I1));
                p.I2 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I2));
                p.I3 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I3));
                p.I4 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I4));
                p.I5 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I5));
                p.I6 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I6));
                p.I7 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I7));
                p.I8 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I8));
                p.I9 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I9));
                p.I10 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I10));
                p.I11 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I11));
                p.I12 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I12));
                p.I13 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I13));
                p.I14 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I14));
                p.I15 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I15));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YIsEvenInteger_Basic(Vector256<ushort> value) {
                return YIsEvenInteger_Basic(value.AsInt16()).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsEvenInteger_Basic(Vector256<int> value) {
                UnsafeUtil.SkipInit(out Vector256<int> rt);
                ref FixedArray8<int> pvalue = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref value);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I3));
                p.I4 = BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I4));
                p.I5 = BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I5));
                p.I6 = BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I6));
                p.I7 = BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YIsEvenInteger_Basic(Vector256<uint> value) {
                return YIsEvenInteger_Basic(value.AsInt32()).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsEvenInteger_Basic(Vector256<long> value) {
                UnsafeUtil.SkipInit(out Vector256<long> rt);
                ref FixedArray4<long> pvalue = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref value);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(pvalue.I3));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YIsEvenInteger_Basic(Vector256<ulong> value) {
                return YIsEvenInteger_Basic(value.AsInt64()).AsUInt64();
            }

#if NET7_0_OR_GREATER
            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsEvenInteger_Bit(Vector256<float> value) {
                Vector256<float> valueHalf = Vector256.Multiply(value, 0.5f);
                Vector256<float> valueHalfTrun = Vector256.Floor(valueHalf);
                Vector256<int> intMask = YIsInteger(value);
                Vector256<int> halfEqual = Vector256.Equals(valueHalf, valueHalfTrun).AsInt32();
                Vector256<int> rt = Vector256.BitwiseAnd(intMask, halfEqual);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsEvenInteger_Bit(Vector256<double> value) {
                Vector256<double> valueHalf = Vector256.Multiply(value, 0.5);
                Vector256<double> valueHalfTrun = Vector256.Floor(valueHalf);
                Vector256<long> intMask = YIsInteger(value);
                Vector256<long> halfEqual = Vector256.Equals(valueHalf, valueHalfTrun).AsInt64();
                Vector256<long> rt = Vector256.BitwiseAnd(intMask, halfEqual);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YIsEvenInteger_Bit(Vector256<sbyte> value) {
                Vector256<sbyte> temp = Vector256.BitwiseAnd(value, Vector256Constants.Byte_One.AsSByte());
                Vector256<sbyte> rt = Vector256.Equals(Vector256<sbyte>.Zero, temp);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YIsEvenInteger_Bit(Vector256<byte> value) {
                return YIsEvenInteger_Bit(value.AsSByte()).AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YIsEvenInteger_Bit(Vector256<short> value) {
                Vector256<short> temp = Vector256.BitwiseAnd(value, Vector256Constants.Int16_One);
                Vector256<short> rt = Vector256.Equals(Vector256<short>.Zero, temp);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YIsEvenInteger_Bit(Vector256<ushort> value) {
                return YIsEvenInteger_Bit(value.AsInt16()).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsEvenInteger_Bit(Vector256<int> value) {
                Vector256<int> temp = Vector256.BitwiseAnd(value, Vector256Constants.Int32_One);
                Vector256<int> rt = Vector256.Equals(Vector256<int>.Zero, temp);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YIsEvenInteger_Bit(Vector256<uint> value) {
                return YIsEvenInteger_Bit(value.AsInt32()).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsEvenInteger_Bit(Vector256<long> value) {
                Vector256<long> temp = Vector256.BitwiseAnd(value, Vector256Constants.Int64_One);
                Vector256<long> rt = Vector256.Equals(Vector256<long>.Zero, temp);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YIsEvenInteger_Bit(Vector256<ulong> value) {
                return YIsEvenInteger_Bit(value.AsInt64()).AsUInt64();
            }
#endif // NET7_0_OR_GREATER


            /// <inheritdoc cref="IWVectorTraits256.YIsFinite_AcceleratedTypes"/>
            public static TypeCodeFlags YIsFinite_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if NET7_0_OR_GREATER
                    rt |= TypeCodeFlags.Single;
                    rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double);
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
                    rt |= TypeCodeFlags.Single;
                    rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double);
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
                    rt |= TypeCodeFlags.Single;
                    rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double);
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
                    rt |= TypeCodeFlags.Single;
                    rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double) & Floor_AcceleratedTypes;
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


            /// <inheritdoc cref="IWVectorTraits256.YIsNaN_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNaN_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if NET7_0_OR_GREATER
                    rt |= (TypeCodeFlags.Single | TypeCodeFlags.Double) & Equals_AcceleratedTypes;
#endif // NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNaN(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNaN(Vector256<float> value) {
#if NET7_0_OR_GREATER
                return YIsNaN_Bit(value);
#else
                return YIsNaN_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNaN(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNaN(Vector256<double> value) {
#if NET7_0_OR_GREATER
                return YIsNaN_Bit(value);
#else
                return YIsNaN_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNaN(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNaN_Basic(Vector256<float> value) {
                UnsafeUtil.SkipInit(out Vector256<int> rt);
                ref FixedArray8<float> pvalue = ref Unsafe.As<Vector256<float>, FixedArray8<float>>(ref value);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsNaN(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsNaN(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsNaN(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsNaN(pvalue.I3));
                p.I4 = BitMathCore.ToInt32Mask(MathINumberBase.IsNaN(pvalue.I4));
                p.I5 = BitMathCore.ToInt32Mask(MathINumberBase.IsNaN(pvalue.I5));
                p.I6 = BitMathCore.ToInt32Mask(MathINumberBase.IsNaN(pvalue.I6));
                p.I7 = BitMathCore.ToInt32Mask(MathINumberBase.IsNaN(pvalue.I7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNaN(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNaN_Basic(Vector256<double> value) {
                UnsafeUtil.SkipInit(out Vector256<long> rt);
                ref FixedArray4<double> pvalue = ref Unsafe.As<Vector256<double>, FixedArray4<double>>(ref value);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsNaN(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsNaN(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsNaN(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsNaN(pvalue.I3));
                return rt;
            }

#if NET7_0_OR_GREATER
            /// <inheritdoc cref="IWVectorTraits256.YIsNaN(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNaN_Bit(Vector256<float> value) {
#pragma warning disable CS1718 // Comparison made to same variable; did you mean to compare something else?
                Vector256<int> rt = Vector256.OnesComplement(Vector256.Equals(value, value).AsInt32());
#pragma warning restore CS1718 // Comparison made to same variable; did you mean to compare something else?
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNaN(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNaN_Bit(Vector256<double> value) {
#pragma warning disable CS1718 // Comparison made to same variable; did you mean to compare something else?
                Vector256<long> rt = Vector256.OnesComplement(Vector256.Equals(value, value).AsInt64());
#pragma warning restore CS1718 // Comparison made to same variable; did you mean to compare something else?
                return rt;
            }
#endif // NET7_0_OR_GREATER


            /// <inheritdoc cref="IWVectorTraits256.YIsNegative_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNegative_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if NET7_0_OR_GREATER
                    rt |= (TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64) & LessThan_AcceleratedTypes;
                    rt |= TypeCodeFlagsUtil.MapFlags(LessThan_AcceleratedTypes, TypeCodeFlags.Int32, TypeCodeFlags.Single, TypeCodeFlags.Int64, TypeCodeFlags.Double);
#endif // NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNegative(Vector256<float> value) {
#if NET7_0_OR_GREATER
                return YIsNegative_Bit(value);
#else
                return YIsNegative_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNegative(Vector256<double> value) {
#if NET7_0_OR_GREATER
                return YIsNegative_Bit(value);
#else
                return YIsNegative_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YIsNegative(Vector256<sbyte> value) {
#if NET7_0_OR_GREATER
                return YIsNegative_Bit(value);
#else
                return YIsNegative_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YIsNegative(Vector256<short> value) {
#if NET7_0_OR_GREATER
                return YIsNegative_Bit(value);
#else
                return YIsNegative_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNegative(Vector256<int> value) {
#if NET7_0_OR_GREATER
                return YIsNegative_Bit(value);
#else
                return YIsNegative_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNegative(Vector256<long> value) {
#if NET7_0_OR_GREATER
                return YIsNegative_Bit(value);
#else
                return YIsNegative_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNegative_Basic(Vector256<float> value) {
                UnsafeUtil.SkipInit(out Vector256<int> rt);
                ref FixedArray8<float> pvalue = ref Unsafe.As<Vector256<float>, FixedArray8<float>>(ref value);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I3));
                p.I4 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I4));
                p.I5 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I5));
                p.I6 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I6));
                p.I7 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNegative_Basic(Vector256<double> value) {
                UnsafeUtil.SkipInit(out Vector256<long> rt);
                ref FixedArray4<double> pvalue = ref Unsafe.As<Vector256<double>, FixedArray4<double>>(ref value);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I3));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YIsNegative_Basic(Vector256<sbyte> value) {
                UnsafeUtil.SkipInit(out Vector256<sbyte> rt);
                ref FixedArray32<sbyte> pvalue = ref Unsafe.As<Vector256<sbyte>, FixedArray32<sbyte>>(ref value);
                ref FixedArray32<sbyte> p = ref Unsafe.As<Vector256<sbyte>, FixedArray32<sbyte>>(ref rt);
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
                p.I16 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I16));
                p.I17 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I17));
                p.I18 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I18));
                p.I19 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I19));
                p.I20 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I20));
                p.I21 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I21));
                p.I22 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I22));
                p.I23 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I23));
                p.I24 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I24));
                p.I25 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I25));
                p.I26 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I26));
                p.I27 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I27));
                p.I28 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I28));
                p.I29 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I29));
                p.I30 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I30));
                p.I31 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I31));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YIsNegative_Basic(Vector256<short> value) {
                UnsafeUtil.SkipInit(out Vector256<short> rt);
                ref FixedArray16<short> pvalue = ref Unsafe.As<Vector256<short>, FixedArray16<short>>(ref value);
                ref FixedArray16<short> p = ref Unsafe.As<Vector256<short>, FixedArray16<short>>(ref rt);
                p.I0 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I0));
                p.I1 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I1));
                p.I2 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I2));
                p.I3 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I3));
                p.I4 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I4));
                p.I5 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I5));
                p.I6 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I6));
                p.I7 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I7));
                p.I8 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I8));
                p.I9 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I9));
                p.I10 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I10));
                p.I11 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I11));
                p.I12 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I12));
                p.I13 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I13));
                p.I14 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I14));
                p.I15 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I15));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNegative_Basic(Vector256<int> value) {
                UnsafeUtil.SkipInit(out Vector256<int> rt);
                ref FixedArray8<int> pvalue = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref value);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I3));
                p.I4 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I4));
                p.I5 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I5));
                p.I6 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I6));
                p.I7 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNegative_Basic(Vector256<long> value) {
                UnsafeUtil.SkipInit(out Vector256<long> rt);
                ref FixedArray4<long> pvalue = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref value);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(pvalue.I3));
                return rt;
            }

#if NET7_0_OR_GREATER
            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNegative_Bit(Vector256<float> value) {
                return YIsNegative_Bit(value.AsInt32());
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNegative_Bit(Vector256<double> value) {
                return YIsNegative_Bit(value.AsInt64());
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YIsNegative_Bit(Vector256<sbyte> value) {
                Vector256<sbyte> rt = Vector256.LessThan(value, Vector256<sbyte>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YIsNegative_Bit(Vector256<short> value) {
                //Vector256<short> rt = Vector256.LessThan(value, Vector256<short>.Zero);
                Vector256<short> rt = Vector256.ShiftRightArithmetic(value, 15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNegative_Bit(Vector256<int> value) {
                //Vector256<int> rt = Vector256.LessThan(value, Vector256<int>.Zero);
                Vector256<int> rt = Vector256.ShiftRightArithmetic(value, 31);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNegative_Bit(Vector256<long> value) {
                Vector256<long> rt = Vector256.LessThan(value, Vector256<long>.Zero);
                return rt;
            }
#endif // NET7_0_OR_GREATER


            /// <inheritdoc cref="IWVectorTraits256.YIsNegativeInfinity_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNegativeInfinity_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if NET7_0_OR_GREATER
                    rt |= (TypeCodeFlags.Single | TypeCodeFlags.Double) & Equals_AcceleratedTypes;
#endif // NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegativeInfinity(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNegativeInfinity(Vector256<float> value) {
#if NET7_0_OR_GREATER
                return YIsNegativeInfinity_Bit(value);
#else
                return YIsNegativeInfinity_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegativeInfinity(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNegativeInfinity(Vector256<double> value) {
#if NET7_0_OR_GREATER
                return YIsNegativeInfinity_Bit(value);
#else
                return YIsNegativeInfinity_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegativeInfinity(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNegativeInfinity_Basic(Vector256<float> value) {
                UnsafeUtil.SkipInit(out Vector256<int> rt);
                ref FixedArray8<float> pvalue = ref Unsafe.As<Vector256<float>, FixedArray8<float>>(ref value);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeInfinity(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeInfinity(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeInfinity(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeInfinity(pvalue.I3));
                p.I4 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeInfinity(pvalue.I4));
                p.I5 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeInfinity(pvalue.I5));
                p.I6 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeInfinity(pvalue.I6));
                p.I7 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeInfinity(pvalue.I7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegativeInfinity(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNegativeInfinity_Basic(Vector256<double> value) {
                UnsafeUtil.SkipInit(out Vector256<long> rt);
                ref FixedArray4<double> pvalue = ref Unsafe.As<Vector256<double>, FixedArray4<double>>(ref value);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeInfinity(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeInfinity(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeInfinity(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeInfinity(pvalue.I3));
                return rt;
            }

#if NET7_0_OR_GREATER
            /// <inheritdoc cref="IWVectorTraits256.YIsNegativeInfinity(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNegativeInfinity_Bit(Vector256<float> value) {
                Vector256<float> sample = Vector256.Create(float.NegativeInfinity);
                Vector256<int> rt = Vector256.Equals(value, sample).AsInt32();
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegativeInfinity(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNegativeInfinity_Bit(Vector256<double> value) {
                Vector256<double> sample = Vector256.Create(double.NegativeInfinity);
                Vector256<long> rt = Vector256.Equals(value, sample).AsInt64();
                return rt;
            }
#endif // NET7_0_OR_GREATER


            /// <inheritdoc cref="IWVectorTraits256.YIsNegativeZero_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNegativeZero_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if NET7_0_OR_GREATER
                    rt |= TypeCodeFlags.Single;
                    rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double);
#endif // NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegativeZero(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNegativeZero(Vector256<float> value) {
#if NET7_0_OR_GREATER
                return YIsNegativeZero_Bit(value);
#else
                return YIsNegativeZero_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegativeZero(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNegativeZero(Vector256<double> value) {
#if NET7_0_OR_GREATER
                return YIsNegativeZero_Bit(value);
#else
                return YIsNegativeZero_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegativeZero(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNegativeZero_Basic(Vector256<float> value) {
                UnsafeUtil.SkipInit(out Vector256<int> rt);
                ref FixedArray8<float> pvalue = ref Unsafe.As<Vector256<float>, FixedArray8<float>>(ref value);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeZero(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeZero(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeZero(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeZero(pvalue.I3));
                p.I4 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeZero(pvalue.I4));
                p.I5 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeZero(pvalue.I5));
                p.I6 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeZero(pvalue.I6));
                p.I7 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeZero(pvalue.I7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegativeZero(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNegativeZero_Basic(Vector256<double> value) {
                UnsafeUtil.SkipInit(out Vector256<long> rt);
                ref FixedArray4<double> pvalue = ref Unsafe.As<Vector256<double>, FixedArray4<double>>(ref value);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeZero(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeZero(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeZero(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeZero(pvalue.I3));
                return rt;
            }

#if NET7_0_OR_GREATER
            /// <inheritdoc cref="IWVectorTraits256.YIsNegativeZero(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNegativeZero_Bit(Vector256<float> value) {
                Vector256<int> signMask = Vector256Constants.Single_SignMask.AsInt32();
                Vector256<int> rt = Vector256.Equals(value.AsInt32(), signMask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegativeZero(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNegativeZero_Bit(Vector256<double> value) {
                Vector256<long> signMask = Vector256Constants.Double_SignMask.AsInt64();
                Vector256<long> rt = Vector256.Equals(value.AsInt64(), signMask);
                return rt;
            }
#endif // NET7_0_OR_GREATER


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
#if NET7_0_OR_GREATER
                return YIsNormal_Bit(value);
#else
                return YIsNormal_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNormal(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNormal(Vector256<double> value) {
#if NET7_0_OR_GREATER
                return YIsNormal_Bit(value);
#else
                return YIsNormal_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNormal(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNormal_Basic(Vector256<float> value) {
                UnsafeUtil.SkipInit(out Vector256<int> rt);
                ref FixedArray8<float> pvalue = ref Unsafe.As<Vector256<float>, FixedArray8<float>>(ref value);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsNormal(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsNormal(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsNormal(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsNormal(pvalue.I3));
                p.I4 = BitMathCore.ToInt32Mask(MathINumberBase.IsNormal(pvalue.I4));
                p.I5 = BitMathCore.ToInt32Mask(MathINumberBase.IsNormal(pvalue.I5));
                p.I6 = BitMathCore.ToInt32Mask(MathINumberBase.IsNormal(pvalue.I6));
                p.I7 = BitMathCore.ToInt32Mask(MathINumberBase.IsNormal(pvalue.I7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNormal(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNormal_Basic(Vector256<double> value) {
                UnsafeUtil.SkipInit(out Vector256<long> rt);
                ref FixedArray4<double> pvalue = ref Unsafe.As<Vector256<double>, FixedArray4<double>>(ref value);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsNormal(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsNormal(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsNormal(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsNormal(pvalue.I3));
                return rt;
            }

#if NET7_0_OR_GREATER
            /// <inheritdoc cref="IWVectorTraits256.YIsNormal(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNormal_Bit(Vector256<float> value) {
                Vector256<int> exponentMask = Vector256Constants.Single_ExponentMask.AsInt32();
                Vector256<int> exponent = Vector256.BitwiseAnd(value.AsInt32(), exponentMask);
                Vector256<int> rt = Vector256.BitwiseAnd(Vector256.GreaterThan(exponent, Vector256<int>.Zero), Vector256.GreaterThan(exponentMask, exponent));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNormal(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNormal_Bit(Vector256<double> value) {
                Vector256<long> exponentMask = Vector256Constants.Double_ExponentMask.AsInt64();
                Vector256<long> exponent = Vector256.BitwiseAnd(value.AsInt64(), exponentMask);
                Vector256<long> rt = Vector256.BitwiseAnd(Vector256.GreaterThan(exponent, Vector256<long>.Zero), Vector256.GreaterThan(exponentMask, exponent));
                return rt;
            }
#endif // NET7_0_OR_GREATER


            /// <inheritdoc cref="IWVectorTraits256.YIsNotNaN_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNotNaN_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if NET7_0_OR_GREATER
                    rt |= (TypeCodeFlags.Single | TypeCodeFlags.Double) & Equals_AcceleratedTypes;
#endif // NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNotNaN(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNotNaN(Vector256<float> value) {
#if NET7_0_OR_GREATER
                return YIsNotNaN_Bit(value);
#else
                return YIsNotNaN_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNotNaN(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNotNaN(Vector256<double> value) {
#if NET7_0_OR_GREATER
                return YIsNotNaN_Bit(value);
#else
                return YIsNotNaN_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNotNaN(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNotNaN_Basic(Vector256<float> value) {
                UnsafeUtil.SkipInit(out Vector256<int> rt);
                ref FixedArray8<float> pvalue = ref Unsafe.As<Vector256<float>, FixedArray8<float>>(ref value);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsNotNaN(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsNotNaN(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsNotNaN(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsNotNaN(pvalue.I3));
                p.I4 = BitMathCore.ToInt32Mask(MathINumberBase.IsNotNaN(pvalue.I4));
                p.I5 = BitMathCore.ToInt32Mask(MathINumberBase.IsNotNaN(pvalue.I5));
                p.I6 = BitMathCore.ToInt32Mask(MathINumberBase.IsNotNaN(pvalue.I6));
                p.I7 = BitMathCore.ToInt32Mask(MathINumberBase.IsNotNaN(pvalue.I7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNotNaN(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNotNaN_Basic(Vector256<double> value) {
                UnsafeUtil.SkipInit(out Vector256<long> rt);
                ref FixedArray4<double> pvalue = ref Unsafe.As<Vector256<double>, FixedArray4<double>>(ref value);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsNotNaN(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsNotNaN(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsNotNaN(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsNotNaN(pvalue.I3));
                return rt;
            }

#if NET7_0_OR_GREATER
            /// <inheritdoc cref="IWVectorTraits256.YIsNotNaN(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNotNaN_Bit(Vector256<float> value) {
#pragma warning disable CS1718 // Comparison made to same variable; did you mean to compare something else?
                Vector256<int> rt = Vector256.Equals(value, value).AsInt32();
#pragma warning restore CS1718 // Comparison made to same variable; did you mean to compare something else?
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNotNaN(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNotNaN_Bit(Vector256<double> value) {
#pragma warning disable CS1718 // Comparison made to same variable; did you mean to compare something else?
                Vector256<long> rt = Vector256.Equals(value, value).AsInt64();
#pragma warning restore CS1718 // Comparison made to same variable; did you mean to compare something else?
                return rt;
            }
#endif // NET7_0_OR_GREATER


            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger_AcceleratedTypes"/>
            public static TypeCodeFlags YIsOddInteger_AcceleratedTypes
            {
                get
                {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if NET7_0_OR_GREATER
                    rt |= TypeCodeFlagsUtil.IntTypes & Equals_AcceleratedTypes;
                    rt |= (TypeCodeFlags.Single | TypeCodeFlags.Double) & YIsInteger_AcceleratedTypes & Floor_AcceleratedTypes;
#endif // NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsOddInteger(Vector256<float> value)
            {
#if NET7_0_OR_GREATER
                return YIsOddInteger_Bit(value);
#else
                return YIsOddInteger_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsOddInteger(Vector256<double> value)
            {
#if NET7_0_OR_GREATER
                return YIsOddInteger_Bit(value);
#else
                return YIsOddInteger_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YIsOddInteger(Vector256<sbyte> value)
            {
#if NET7_0_OR_GREATER
                return YIsOddInteger_Bit(value);
#else
                return YIsOddInteger_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YIsOddInteger(Vector256<byte> value)
            {
#if NET7_0_OR_GREATER
                return YIsOddInteger_Bit(value);
#else
                return YIsOddInteger_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YIsOddInteger(Vector256<short> value)
            {
#if NET7_0_OR_GREATER
                return YIsOddInteger_Bit(value);
#else
                return YIsOddInteger_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YIsOddInteger(Vector256<ushort> value)
            {
#if NET7_0_OR_GREATER
                return YIsOddInteger_Bit(value);
#else
                return YIsOddInteger_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsOddInteger(Vector256<int> value)
            {
#if NET7_0_OR_GREATER
                return YIsOddInteger_Bit(value);
#else
                return YIsOddInteger_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YIsOddInteger(Vector256<uint> value)
            {
#if NET7_0_OR_GREATER
                return YIsOddInteger_Bit(value);
#else
                return YIsOddInteger_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsOddInteger(Vector256<long> value)
            {
#if NET7_0_OR_GREATER
                return YIsOddInteger_Bit(value);
#else
                return YIsOddInteger_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YIsOddInteger(Vector256<ulong> value)
            {
#if NET7_0_OR_GREATER
                return YIsOddInteger_Bit(value);
#else
                return YIsOddInteger_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsOddInteger_Basic(Vector256<float> value)
            {
                UnsafeUtil.SkipInit(out Vector256<int> rt);
                ref FixedArray8<float> pvalue = ref Unsafe.As<Vector256<float>, FixedArray8<float>>(ref value);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I3));
                p.I4 = BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I4));
                p.I5 = BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I5));
                p.I6 = BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I6));
                p.I7 = BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsOddInteger_Basic(Vector256<double> value)
            {
                UnsafeUtil.SkipInit(out Vector256<long> rt);
                ref FixedArray4<double> pvalue = ref Unsafe.As<Vector256<double>, FixedArray4<double>>(ref value);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I3));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YIsOddInteger_Basic(Vector256<sbyte> value)
            {
                UnsafeUtil.SkipInit(out Vector256<sbyte> rt);
                ref FixedArray32<sbyte> pvalue = ref Unsafe.As<Vector256<sbyte>, FixedArray32<sbyte>>(ref value);
                ref FixedArray32<sbyte> p = ref Unsafe.As<Vector256<sbyte>, FixedArray32<sbyte>>(ref rt);
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
                p.I16 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I16));
                p.I17 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I17));
                p.I18 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I18));
                p.I19 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I19));
                p.I20 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I20));
                p.I21 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I21));
                p.I22 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I22));
                p.I23 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I23));
                p.I24 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I24));
                p.I25 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I25));
                p.I26 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I26));
                p.I27 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I27));
                p.I28 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I28));
                p.I29 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I29));
                p.I30 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I30));
                p.I31 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I31));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YIsOddInteger_Basic(Vector256<byte> value)
            {
                return YIsOddInteger_Basic(value.AsSByte()).AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YIsOddInteger_Basic(Vector256<short> value)
            {
                UnsafeUtil.SkipInit(out Vector256<short> rt);
                ref FixedArray16<short> pvalue = ref Unsafe.As<Vector256<short>, FixedArray16<short>>(ref value);
                ref FixedArray16<short> p = ref Unsafe.As<Vector256<short>, FixedArray16<short>>(ref rt);
                p.I0 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I0));
                p.I1 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I1));
                p.I2 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I2));
                p.I3 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I3));
                p.I4 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I4));
                p.I5 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I5));
                p.I6 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I6));
                p.I7 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I7));
                p.I8 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I8));
                p.I9 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I9));
                p.I10 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I10));
                p.I11 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I11));
                p.I12 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I12));
                p.I13 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I13));
                p.I14 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I14));
                p.I15 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I15));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YIsOddInteger_Basic(Vector256<ushort> value)
            {
                return YIsOddInteger_Basic(value.AsInt16()).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsOddInteger_Basic(Vector256<int> value)
            {
                UnsafeUtil.SkipInit(out Vector256<int> rt);
                ref FixedArray8<int> pvalue = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref value);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I3));
                p.I4 = BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I4));
                p.I5 = BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I5));
                p.I6 = BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I6));
                p.I7 = BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YIsOddInteger_Basic(Vector256<uint> value)
            {
                return YIsOddInteger_Basic(value.AsInt32()).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsOddInteger_Basic(Vector256<long> value)
            {
                UnsafeUtil.SkipInit(out Vector256<long> rt);
                ref FixedArray4<long> pvalue = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref value);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(pvalue.I3));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YIsOddInteger_Basic(Vector256<ulong> value)
            {
                return YIsOddInteger_Basic(value.AsInt64()).AsUInt64();
            }

#if NET7_0_OR_GREATER
            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsOddInteger_Bit(Vector256<float> value)
            {
                Vector256<float> valueHalf = Vector256.Multiply(value, 0.5f);
                Vector256<float> valueHalfTrun = Vector256.Floor(valueHalf);
                Vector256<int> intMask = YIsInteger(value);
                Vector256<int> halfEqual = Vector256.Equals(valueHalf, valueHalfTrun).AsInt32();
                Vector256<int> rt = Vector256.AndNot(intMask, halfEqual);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsOddInteger_Bit(Vector256<double> value)
            {
                Vector256<double> valueHalf = Vector256.Multiply(value, 0.5);
                Vector256<double> valueHalfTrun = Vector256.Floor(valueHalf);
                Vector256<long> intMask = YIsInteger(value);
                Vector256<long> halfEqual = Vector256.Equals(valueHalf, valueHalfTrun).AsInt64();
                Vector256<long> rt = Vector256.AndNot(intMask, halfEqual);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YIsOddInteger_Bit(Vector256<sbyte> value)
            {
                Vector256<sbyte> temp = Vector256.BitwiseAnd(value, Vector256Constants.Byte_One.AsSByte());
                Vector256<sbyte> rt = Vector256.GreaterThan(temp, Vector256<sbyte>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YIsOddInteger_Bit(Vector256<byte> value)
            {
                return YIsOddInteger_Bit(value.AsSByte()).AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YIsOddInteger_Bit(Vector256<short> value)
            {
                Vector256<short> temp = Vector256.BitwiseAnd(value, Vector256Constants.Int16_One);
                Vector256<short> rt = Vector256.GreaterThan(temp, Vector256<short>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YIsOddInteger_Bit(Vector256<ushort> value)
            {
                return YIsOddInteger_Bit(value.AsInt16()).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsOddInteger_Bit(Vector256<int> value)
            {
                Vector256<int> temp = Vector256.BitwiseAnd(value, Vector256Constants.Int32_One);
                Vector256<int> rt = Vector256.GreaterThan(temp, Vector256<int>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YIsOddInteger_Bit(Vector256<uint> value)
            {
                return YIsOddInteger_Bit(value.AsInt32()).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsOddInteger_Bit(Vector256<long> value)
            {
                Vector256<long> temp = Vector256.BitwiseAnd(value, Vector256Constants.Int64_One);
                Vector256<long> rt = Vector256.GreaterThan(temp, Vector256<long>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YIsOddInteger_Bit(Vector256<ulong> value)
            {
                return YIsOddInteger_Bit(value.AsInt64()).AsUInt64();
            }
#endif // NET7_0_OR_GREATER


            /// <inheritdoc cref="IWVectorTraits256.YIsPositive_AcceleratedTypes"/>
            public static TypeCodeFlags YIsPositive_AcceleratedTypes {
                get {
                    return YIsNegative_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsPositive(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsPositive(Vector256<float> value) {
#if NET7_0_OR_GREATER
                return YIsPositive_Bit(value);
#else
                return YIsPositive_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsPositive(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsPositive(Vector256<double> value) {
#if NET7_0_OR_GREATER
                return YIsPositive_Bit(value);
#else
                return YIsPositive_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsPositive(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YIsPositive(Vector256<sbyte> value) {
#if NET7_0_OR_GREATER
                return YIsPositive_Bit(value);
#else
                return YIsPositive_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsPositive(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YIsPositive(Vector256<short> value) {
#if NET7_0_OR_GREATER
                return YIsPositive_Bit(value);
#else
                return YIsPositive_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsPositive(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsPositive(Vector256<int> value) {
#if NET7_0_OR_GREATER
                return YIsPositive_Bit(value);
#else
                return YIsPositive_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsPositive(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsPositive(Vector256<long> value) {
#if NET7_0_OR_GREATER
                return YIsPositive_Bit(value);
#else
                return YIsPositive_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsPositive(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsPositive_Basic(Vector256<float> value) {
                UnsafeUtil.SkipInit(out Vector256<int> rt);
                ref FixedArray8<float> pvalue = ref Unsafe.As<Vector256<float>, FixedArray8<float>>(ref value);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I3));
                p.I4 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I4));
                p.I5 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I5));
                p.I6 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I6));
                p.I7 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsPositive(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsPositive_Basic(Vector256<double> value) {
                UnsafeUtil.SkipInit(out Vector256<long> rt);
                ref FixedArray4<double> pvalue = ref Unsafe.As<Vector256<double>, FixedArray4<double>>(ref value);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I3));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.YIsPositive(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YIsPositive_Basic(Vector256<sbyte> value) {
                UnsafeUtil.SkipInit(out Vector256<sbyte> rt);
                ref FixedArray32<sbyte> pvalue = ref Unsafe.As<Vector256<sbyte>, FixedArray32<sbyte>>(ref value);
                ref FixedArray32<sbyte> p = ref Unsafe.As<Vector256<sbyte>, FixedArray32<sbyte>>(ref rt);
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
                p.I16 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I16));
                p.I17 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I17));
                p.I18 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I18));
                p.I19 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I19));
                p.I20 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I20));
                p.I21 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I21));
                p.I22 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I22));
                p.I23 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I23));
                p.I24 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I24));
                p.I25 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I25));
                p.I26 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I26));
                p.I27 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I27));
                p.I28 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I28));
                p.I29 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I29));
                p.I30 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I30));
                p.I31 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I31));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsPositive(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YIsPositive_Basic(Vector256<short> value) {
                UnsafeUtil.SkipInit(out Vector256<short> rt);
                ref FixedArray16<short> pvalue = ref Unsafe.As<Vector256<short>, FixedArray16<short>>(ref value);
                ref FixedArray16<short> p = ref Unsafe.As<Vector256<short>, FixedArray16<short>>(ref rt);
                p.I0 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I0));
                p.I1 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I1));
                p.I2 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I2));
                p.I3 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I3));
                p.I4 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I4));
                p.I5 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I5));
                p.I6 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I6));
                p.I7 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I7));
                p.I8 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I8));
                p.I9 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I9));
                p.I10 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I10));
                p.I11 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I11));
                p.I12 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I12));
                p.I13 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I13));
                p.I14 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I14));
                p.I15 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I15));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsPositive(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsPositive_Basic(Vector256<int> value) {
                UnsafeUtil.SkipInit(out Vector256<int> rt);
                ref FixedArray8<int> pvalue = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref value);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I3));
                p.I4 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I4));
                p.I5 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I5));
                p.I6 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I6));
                p.I7 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsPositive(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsPositive_Basic(Vector256<long> value) {
                UnsafeUtil.SkipInit(out Vector256<long> rt);
                ref FixedArray4<long> pvalue = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref value);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(pvalue.I3));
                return rt;
            }

#if NET7_0_OR_GREATER
            /// <inheritdoc cref="IWVectorTraits256.YIsPositive(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsPositive_Bit(Vector256<float> value) {
                return YIsPositive_Bit(value.AsInt32());
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsPositive(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsPositive_Bit(Vector256<double> value) {
                return YIsPositive_Bit(value.AsInt64());
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsPositive(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YIsPositive_Bit(Vector256<sbyte> value) {
                Vector256<sbyte> rt = Vector256.OnesComplement(YIsNegative(value));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsPositive(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YIsPositive_Bit(Vector256<short> value) {
                Vector256<short> rt = Vector256.OnesComplement(YIsNegative(value));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsPositive(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsPositive_Bit(Vector256<int> value) {
                Vector256<int> rt = Vector256.OnesComplement(YIsNegative(value));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsPositive(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsPositive_Bit(Vector256<long> value) {
                Vector256<long> rt = Vector256.OnesComplement(YIsNegative(value));
                return rt;
            }
#endif // NET7_0_OR_GREATER


            /// <inheritdoc cref="IWVectorTraits256.YIsPositiveInfinity_AcceleratedTypes"/>
            public static TypeCodeFlags YIsPositiveInfinity_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if NET7_0_OR_GREATER
                    rt |= (TypeCodeFlags.Single | TypeCodeFlags.Double) & Equals_AcceleratedTypes;
#endif // NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsPositiveInfinity(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsPositiveInfinity(Vector256<float> value) {
#if NET7_0_OR_GREATER
                return YIsPositiveInfinity_Bit(value);
#else
                return YIsPositiveInfinity_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsPositiveInfinity(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsPositiveInfinity(Vector256<double> value) {
#if NET7_0_OR_GREATER
                return YIsPositiveInfinity_Bit(value);
#else
                return YIsPositiveInfinity_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsPositiveInfinity(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsPositiveInfinity_Basic(Vector256<float> value) {
                UnsafeUtil.SkipInit(out Vector256<int> rt);
                ref FixedArray8<float> pvalue = ref Unsafe.As<Vector256<float>, FixedArray8<float>>(ref value);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositiveInfinity(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositiveInfinity(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositiveInfinity(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositiveInfinity(pvalue.I3));
                p.I4 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositiveInfinity(pvalue.I4));
                p.I5 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositiveInfinity(pvalue.I5));
                p.I6 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositiveInfinity(pvalue.I6));
                p.I7 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositiveInfinity(pvalue.I7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsPositiveInfinity(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsPositiveInfinity_Basic(Vector256<double> value) {
                UnsafeUtil.SkipInit(out Vector256<long> rt);
                ref FixedArray4<double> pvalue = ref Unsafe.As<Vector256<double>, FixedArray4<double>>(ref value);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositiveInfinity(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositiveInfinity(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositiveInfinity(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsPositiveInfinity(pvalue.I3));
                return rt;
            }

#if NET7_0_OR_GREATER
            /// <inheritdoc cref="IWVectorTraits256.YIsPositiveInfinity(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsPositiveInfinity_Bit(Vector256<float> value) {
                Vector256<float> sample = Vector256.Create(float.NegativeInfinity);
                Vector256<int> rt = Vector256.Equals(value, sample).AsInt32();
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsPositiveInfinity(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsPositiveInfinity_Bit(Vector256<double> value) {
                Vector256<double> sample = Vector256.Create(double.NegativeInfinity);
                Vector256<long> rt = Vector256.Equals(value, sample).AsInt64();
                return rt;
            }
#endif // NET7_0_OR_GREATER


            /// <inheritdoc cref="IWVectorTraits256.YIsSubnormal_AcceleratedTypes"/>
            public static TypeCodeFlags YIsSubnormal_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if NET7_0_OR_GREATER
                    rt |= TypeCodeFlags.Single;
                    rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes & GreaterThan_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double);
#endif // NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsSubnormal(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsSubnormal(Vector256<float> value) {
#if NET7_0_OR_GREATER
                return YIsSubnormal_Bit(value);
#else
                return YIsSubnormal_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsSubnormal(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsSubnormal(Vector256<double> value) {
#if NET7_0_OR_GREATER
                return YIsSubnormal_Bit(value);
#else
                return YIsSubnormal_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsSubnormal(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsSubnormal_Basic(Vector256<float> value) {
                UnsafeUtil.SkipInit(out Vector256<int> rt);
                ref FixedArray8<float> pvalue = ref Unsafe.As<Vector256<float>, FixedArray8<float>>(ref value);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsSubnormal(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsSubnormal(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsSubnormal(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsSubnormal(pvalue.I3));
                p.I4 = BitMathCore.ToInt32Mask(MathINumberBase.IsSubnormal(pvalue.I4));
                p.I5 = BitMathCore.ToInt32Mask(MathINumberBase.IsSubnormal(pvalue.I5));
                p.I6 = BitMathCore.ToInt32Mask(MathINumberBase.IsSubnormal(pvalue.I6));
                p.I7 = BitMathCore.ToInt32Mask(MathINumberBase.IsSubnormal(pvalue.I7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsSubnormal(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsSubnormal_Basic(Vector256<double> value) {
                UnsafeUtil.SkipInit(out Vector256<long> rt);
                ref FixedArray4<double> pvalue = ref Unsafe.As<Vector256<double>, FixedArray4<double>>(ref value);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsSubnormal(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsSubnormal(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsSubnormal(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsSubnormal(pvalue.I3));
                return rt;
            }

#if NET7_0_OR_GREATER
            /// <inheritdoc cref="IWVectorTraits256.YIsSubnormal(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsSubnormal_Bit(Vector256<float> value) {
                Vector256<int> exponentMask = Vector256Constants.Single_ExponentMask.AsInt32();
                Vector256<int> mantissaMask = Vector256Constants.Single_MantissaMask.AsInt32();
                Vector256<int> zero = Vector256<int>.Zero;
                Vector256<int> exponent = Vector256.BitwiseAnd(value.AsInt32(), exponentMask);
                Vector256<int> mantissa = Vector256.BitwiseAnd(value.AsInt32(), mantissaMask);
                Vector256<int> rt = Vector256.BitwiseAnd(Vector256.Equals(exponent, zero), Vector256.GreaterThan(mantissa, zero));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsSubnormal(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsSubnormal_Bit(Vector256<double> value) {
                Vector256<long> exponentMask = Vector256Constants.Double_ExponentMask.AsInt64();
                Vector256<long> mantissaMask = Vector256Constants.Double_MantissaMask.AsInt64();
                Vector256<long> zero = Vector256<long>.Zero;
                Vector256<long> exponent = Vector256.BitwiseAnd(value.AsInt64(), exponentMask);
                Vector256<long> mantissa = Vector256.BitwiseAnd(value.AsInt64(), mantissaMask);
                Vector256<long> rt = Vector256.BitwiseAnd(Vector256.Equals(exponent, zero), Vector256.GreaterThan(mantissa, zero));
                return rt;
            }
#endif // NET7_0_OR_GREATER

#endif // NETCOREAPP3_0_OR_GREATER
        }
    }
}
