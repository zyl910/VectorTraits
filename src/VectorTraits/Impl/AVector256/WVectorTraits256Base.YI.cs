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

namespace Zyl.VectorTraits.Impl.AVector256 {
    partial class WVectorTraits256Base {

        partial class Statics {

#if NETCOREAPP3_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YIsAllTrue_AcceleratedTypes"/>
            public static TypeCodeFlags YIsAllTrue_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsAllTrue{T}(Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAllTrue<T>(Vector256<T> value) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsAllTrue_Bcl(value);
#else
                return YIsAllTrue_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsAllTrue{T}(Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAllTrue_Basic<T>(Vector256<T> value) where T : struct {
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<T>, FixedArray4<long>>(ref value);
                long total = p.I0 & p.I1 & p.I2 & p.I3;
                return -1 == total;
            }

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits256.YIsAllTrue{T}(Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAllTrue_Bcl<T>(Vector256<T> value) where T : struct {
                Vector256<int> allBitsSet = Vector256<int>.AllBitsSet;
                return Vector256.EqualsAll(value.AsInt32(), allBitsSet);
            }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits256.YIsAnyTrue_AcceleratedTypes"/>
            public static TypeCodeFlags YIsAnyTrue_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsAnyTrue{T}(Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAnyTrue<T>(Vector256<T> value) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsAnyTrue_Bcl(value);
#else
                return YIsAnyTrue_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsAnyTrue{T}(Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAnyTrue_Basic<T>(Vector256<T> value) where T : struct {
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<T>, FixedArray4<long>>(ref value);
                long total = p.I0 | p.I1 | p.I2 | p.I3;
                return 0 != total;
            }

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits256.YIsAnyTrue{T}(Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAnyTrue_Bcl<T>(Vector256<T> value) where T : struct {
                Vector256<byte> allBitsSet = Vector256<byte>.AllBitsSet; // Must use byte.
                return Vector256.EqualsAny(value.AsByte(), allBitsSet);
            }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger_AcceleratedTypes"/>
            public static TypeCodeFlags YIsEvenInteger_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.IntTypes & Equals_AcceleratedTypes;
                        rt |= (TypeCodeFlags.Single | TypeCodeFlags.Double) & YIsInteger_AcceleratedTypes & Floor_AcceleratedTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsEvenInteger(Vector256<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsEvenInteger_Bit(value);
#else
                return YIsEvenInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsEvenInteger(Vector256<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsEvenInteger_Bit(value);
#else
                return YIsEvenInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YIsEvenInteger(Vector256<sbyte> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsEvenInteger_Bit(value);
#else
                return YIsEvenInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YIsEvenInteger(Vector256<byte> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsEvenInteger_Bit(value);
#else
                return YIsEvenInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YIsEvenInteger(Vector256<short> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsEvenInteger_Bit(value);
#else
                return YIsEvenInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YIsEvenInteger(Vector256<ushort> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsEvenInteger_Bit(value);
#else
                return YIsEvenInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsEvenInteger(Vector256<int> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsEvenInteger_Bit(value);
#else
                return YIsEvenInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YIsEvenInteger(Vector256<uint> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsEvenInteger_Bit(value);
#else
                return YIsEvenInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsEvenInteger(Vector256<long> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsEvenInteger_Bit(value);
#else
                return YIsEvenInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YIsEvenInteger(Vector256<ulong> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsEvenInteger_Bit(value);
#else
                return YIsEvenInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits256.YIsFinite_AcceleratedTypes"/>
            public static TypeCodeFlags YIsFinite_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single;
                        rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double);
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsFinite(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsFinite(Vector256<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsFinite_Bit(value);
#else
                return YIsFinite_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsFinite(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsFinite(Vector256<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsFinite_Bit(value);
#else
                return YIsFinite_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits256.YIsInfinity_AcceleratedTypes"/>
            public static TypeCodeFlags YIsInfinity_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single;
                        rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double);
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsInfinity(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsInfinity(Vector256<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsInfinity_Bit(value);
#else
                return YIsInfinity_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsInfinity(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsInfinity(Vector256<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsInfinity_Bit(value);
#else
                return YIsInfinity_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits256.YIsInfinityOrNaN_AcceleratedTypes"/>
            public static TypeCodeFlags YIsInfinityOrNaN_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single;
                        rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double);
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsInfinityOrNaN(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsInfinityOrNaN(Vector256<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsInfinityOrNaN_Bit(value);
#else
                return YIsInfinityOrNaN_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsInfinityOrNaN(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsInfinityOrNaN(Vector256<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsInfinityOrNaN_Bit(value);
#else
                return YIsInfinityOrNaN_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits256.YIsInteger_AcceleratedTypes"/>
            public static TypeCodeFlags YIsInteger_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single;
                        rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double) & Floor_AcceleratedTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsInteger(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsInteger(Vector256<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsInteger_Bit(value);
#else
                return YIsInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsInteger(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsInteger(Vector256<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsInteger_Bit(value);
#else
                return YIsInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits256.YIsNaN_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNaN_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= (TypeCodeFlags.Single | TypeCodeFlags.Double) & Equals_AcceleratedTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNaN(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNaN(Vector256<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsNaN_Bit(value);
#else
                return YIsNaN_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNaN(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNaN(Vector256<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsNaN_Bit(value);
#else
                return YIsNaN_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits256.YIsNegative_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNegative_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= (TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64) & LessThan_AcceleratedTypes;
                        rt |= TypeCodeFlagsUtil.MapFlags(LessThan_AcceleratedTypes, TypeCodeFlags.Int32, TypeCodeFlags.Single, TypeCodeFlags.Int64, TypeCodeFlags.Double);
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNegative(Vector256<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsNegative_Bit(value);
#else
                return YIsNegative_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNegative(Vector256<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsNegative_Bit(value);
#else
                return YIsNegative_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YIsNegative(Vector256<sbyte> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsNegative_Bit(value);
#else
                return YIsNegative_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YIsNegative(Vector256<short> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsNegative_Bit(value);
#else
                return YIsNegative_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNegative(Vector256<int> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsNegative_Bit(value);
#else
                return YIsNegative_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNegative(Vector256<long> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsNegative_Bit(value);
#else
                return YIsNegative_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits256.YIsNegativeInfinity_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNegativeInfinity_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= (TypeCodeFlags.Single | TypeCodeFlags.Double) & Equals_AcceleratedTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegativeInfinity(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNegativeInfinity(Vector256<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsNegativeInfinity_Bit(value);
#else
                return YIsNegativeInfinity_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegativeInfinity(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNegativeInfinity(Vector256<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsNegativeInfinity_Bit(value);
#else
                return YIsNegativeInfinity_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits256.YIsNegativeZero_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNegativeZero_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single;
                        rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double);
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegativeZero(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNegativeZero(Vector256<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsNegativeZero_Bit(value);
#else
                return YIsNegativeZero_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNegativeZero(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNegativeZero(Vector256<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsNegativeZero_Bit(value);
#else
                return YIsNegativeZero_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits256.YIsNormal_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNormal_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.MapFlags(GreaterThan_AcceleratedTypes, TypeCodeFlags.Int32, TypeCodeFlags.Single, TypeCodeFlags.Int64, TypeCodeFlags.Double);
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNormal(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNormal(Vector256<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsNormal_Bit(value);
#else
                return YIsNormal_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNormal(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNormal(Vector256<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsNormal_Bit(value);
#else
                return YIsNormal_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNotEquals_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = Equals_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YIsNotEquals(Vector256<float> left, Vector256<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsNotEquals_Bit(left, right);
#else
                return YIsNotEquals_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YIsNotEquals(Vector256<double> left, Vector256<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsNotEquals_Bit(left, right);
#else
                return YIsNotEquals_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YIsNotEquals(Vector256<sbyte> left, Vector256<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsNotEquals_Bit(left, right);
#else
                return YIsNotEquals_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YIsNotEquals(Vector256<byte> left, Vector256<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsNotEquals_Bit(left, right);
#else
                return YIsNotEquals_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YIsNotEquals(Vector256<short> left, Vector256<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsNotEquals_Bit(left, right);
#else
                return YIsNotEquals_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YIsNotEquals(Vector256<ushort> left, Vector256<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsNotEquals_Bit(left, right);
#else
                return YIsNotEquals_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNotEquals(Vector256<int> left, Vector256<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsNotEquals_Bit(left, right);
#else
                return YIsNotEquals_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YIsNotEquals(Vector256<uint> left, Vector256<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsNotEquals_Bit(left, right);
#else
                return YIsNotEquals_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNotEquals(Vector256<long> left, Vector256<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsNotEquals_Bit(left, right);
#else
                return YIsNotEquals_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YIsNotEquals(Vector256<ulong> left, Vector256<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsNotEquals_Bit(left, right);
#else
                return YIsNotEquals_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YIsNotEquals_Basic(Vector256<float> left, Vector256<float> right) {
                UnsafeUtil.SkipInit(out Vector256<float> rt);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<float>, FixedArray8<int>>(ref rt);
                ref FixedArray8<float> pleft = ref Unsafe.As<Vector256<float>, FixedArray8<float>>(ref left);
                ref FixedArray8<float> pright = ref Unsafe.As<Vector256<float>, FixedArray8<float>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 != pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 != pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 != pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 != pright.I3);
                p.I4 = BitMath.ToInt32Mask(pleft.I4 != pright.I4);
                p.I5 = BitMath.ToInt32Mask(pleft.I5 != pright.I5);
                p.I6 = BitMath.ToInt32Mask(pleft.I6 != pright.I6);
                p.I7 = BitMath.ToInt32Mask(pleft.I7 != pright.I7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YIsNotEquals_Basic(Vector256<double> left, Vector256<double> right) {
                UnsafeUtil.SkipInit(out Vector256<double> rt);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<double>, FixedArray4<long>>(ref rt);
                ref FixedArray4<double> pleft = ref Unsafe.As<Vector256<double>, FixedArray4<double>>(ref left);
                ref FixedArray4<double> pright = ref Unsafe.As<Vector256<double>, FixedArray4<double>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 != pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 != pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 != pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 != pright.I3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YIsNotEquals_Basic(Vector256<sbyte> left, Vector256<sbyte> right) {
                UnsafeUtil.SkipInit(out Vector256<sbyte> rt);
                ref FixedArray32<sbyte> p = ref Unsafe.As<Vector256<sbyte>, FixedArray32<sbyte>>(ref rt);
                ref FixedArray32<sbyte> pleft = ref Unsafe.As<Vector256<sbyte>, FixedArray32<sbyte>>(ref left);
                ref FixedArray32<sbyte> pright = ref Unsafe.As<Vector256<sbyte>, FixedArray32<sbyte>>(ref right);
                p.I0 = (sbyte)BitMath.ToInt32Mask(pleft.I0 != pright.I0);
                p.I1 = (sbyte)BitMath.ToInt32Mask(pleft.I1 != pright.I1);
                p.I2 = (sbyte)BitMath.ToInt32Mask(pleft.I2 != pright.I2);
                p.I3 = (sbyte)BitMath.ToInt32Mask(pleft.I3 != pright.I3);
                p.I4 = (sbyte)BitMath.ToInt32Mask(pleft.I4 != pright.I4);
                p.I5 = (sbyte)BitMath.ToInt32Mask(pleft.I5 != pright.I5);
                p.I6 = (sbyte)BitMath.ToInt32Mask(pleft.I6 != pright.I6);
                p.I7 = (sbyte)BitMath.ToInt32Mask(pleft.I7 != pright.I7);
                p.I8 = (sbyte)BitMath.ToInt32Mask(pleft.I8 != pright.I8);
                p.I9 = (sbyte)BitMath.ToInt32Mask(pleft.I9 != pright.I9);
                p.I10 = (sbyte)BitMath.ToInt32Mask(pleft.I10 != pright.I10);
                p.I11 = (sbyte)BitMath.ToInt32Mask(pleft.I11 != pright.I11);
                p.I12 = (sbyte)BitMath.ToInt32Mask(pleft.I12 != pright.I12);
                p.I13 = (sbyte)BitMath.ToInt32Mask(pleft.I13 != pright.I13);
                p.I14 = (sbyte)BitMath.ToInt32Mask(pleft.I14 != pright.I14);
                p.I15 = (sbyte)BitMath.ToInt32Mask(pleft.I15 != pright.I15);
                p.I16 = (sbyte)BitMath.ToInt32Mask(pleft.I16 != pright.I16);
                p.I17 = (sbyte)BitMath.ToInt32Mask(pleft.I17 != pright.I17);
                p.I18 = (sbyte)BitMath.ToInt32Mask(pleft.I18 != pright.I18);
                p.I19 = (sbyte)BitMath.ToInt32Mask(pleft.I19 != pright.I19);
                p.I20 = (sbyte)BitMath.ToInt32Mask(pleft.I20 != pright.I20);
                p.I21 = (sbyte)BitMath.ToInt32Mask(pleft.I21 != pright.I21);
                p.I22 = (sbyte)BitMath.ToInt32Mask(pleft.I22 != pright.I22);
                p.I23 = (sbyte)BitMath.ToInt32Mask(pleft.I23 != pright.I23);
                p.I24 = (sbyte)BitMath.ToInt32Mask(pleft.I24 != pright.I24);
                p.I25 = (sbyte)BitMath.ToInt32Mask(pleft.I25 != pright.I25);
                p.I26 = (sbyte)BitMath.ToInt32Mask(pleft.I26 != pright.I26);
                p.I27 = (sbyte)BitMath.ToInt32Mask(pleft.I27 != pright.I27);
                p.I28 = (sbyte)BitMath.ToInt32Mask(pleft.I28 != pright.I28);
                p.I29 = (sbyte)BitMath.ToInt32Mask(pleft.I29 != pright.I29);
                p.I30 = (sbyte)BitMath.ToInt32Mask(pleft.I30 != pright.I30);
                p.I31 = (sbyte)BitMath.ToInt32Mask(pleft.I31 != pright.I31);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YIsNotEquals_Basic(Vector256<byte> left, Vector256<byte> right) {
                UnsafeUtil.SkipInit(out Vector256<byte> rt);
                ref FixedArray32<sbyte> p = ref Unsafe.As<Vector256<byte>, FixedArray32<sbyte>>(ref rt);
                ref FixedArray32<byte> pleft = ref Unsafe.As<Vector256<byte>, FixedArray32<byte>>(ref left);
                ref FixedArray32<byte> pright = ref Unsafe.As<Vector256<byte>, FixedArray32<byte>>(ref right);
                p.I0 = (sbyte)BitMath.ToInt32Mask(pleft.I0 != pright.I0);
                p.I1 = (sbyte)BitMath.ToInt32Mask(pleft.I1 != pright.I1);
                p.I2 = (sbyte)BitMath.ToInt32Mask(pleft.I2 != pright.I2);
                p.I3 = (sbyte)BitMath.ToInt32Mask(pleft.I3 != pright.I3);
                p.I4 = (sbyte)BitMath.ToInt32Mask(pleft.I4 != pright.I4);
                p.I5 = (sbyte)BitMath.ToInt32Mask(pleft.I5 != pright.I5);
                p.I6 = (sbyte)BitMath.ToInt32Mask(pleft.I6 != pright.I6);
                p.I7 = (sbyte)BitMath.ToInt32Mask(pleft.I7 != pright.I7);
                p.I8 = (sbyte)BitMath.ToInt32Mask(pleft.I8 != pright.I8);
                p.I9 = (sbyte)BitMath.ToInt32Mask(pleft.I9 != pright.I9);
                p.I10 = (sbyte)BitMath.ToInt32Mask(pleft.I10 != pright.I10);
                p.I11 = (sbyte)BitMath.ToInt32Mask(pleft.I11 != pright.I11);
                p.I12 = (sbyte)BitMath.ToInt32Mask(pleft.I12 != pright.I12);
                p.I13 = (sbyte)BitMath.ToInt32Mask(pleft.I13 != pright.I13);
                p.I14 = (sbyte)BitMath.ToInt32Mask(pleft.I14 != pright.I14);
                p.I15 = (sbyte)BitMath.ToInt32Mask(pleft.I15 != pright.I15);
                p.I16 = (sbyte)BitMath.ToInt32Mask(pleft.I16 != pright.I16);
                p.I17 = (sbyte)BitMath.ToInt32Mask(pleft.I17 != pright.I17);
                p.I18 = (sbyte)BitMath.ToInt32Mask(pleft.I18 != pright.I18);
                p.I19 = (sbyte)BitMath.ToInt32Mask(pleft.I19 != pright.I19);
                p.I20 = (sbyte)BitMath.ToInt32Mask(pleft.I20 != pright.I20);
                p.I21 = (sbyte)BitMath.ToInt32Mask(pleft.I21 != pright.I21);
                p.I22 = (sbyte)BitMath.ToInt32Mask(pleft.I22 != pright.I22);
                p.I23 = (sbyte)BitMath.ToInt32Mask(pleft.I23 != pright.I23);
                p.I24 = (sbyte)BitMath.ToInt32Mask(pleft.I24 != pright.I24);
                p.I25 = (sbyte)BitMath.ToInt32Mask(pleft.I25 != pright.I25);
                p.I26 = (sbyte)BitMath.ToInt32Mask(pleft.I26 != pright.I26);
                p.I27 = (sbyte)BitMath.ToInt32Mask(pleft.I27 != pright.I27);
                p.I28 = (sbyte)BitMath.ToInt32Mask(pleft.I28 != pright.I28);
                p.I29 = (sbyte)BitMath.ToInt32Mask(pleft.I29 != pright.I29);
                p.I30 = (sbyte)BitMath.ToInt32Mask(pleft.I30 != pright.I30);
                p.I31 = (sbyte)BitMath.ToInt32Mask(pleft.I31 != pright.I31);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YIsNotEquals_Basic(Vector256<short> left, Vector256<short> right) {
                UnsafeUtil.SkipInit(out Vector256<short> rt);
                ref FixedArray16<short> p = ref Unsafe.As<Vector256<short>, FixedArray16<short>>(ref rt);
                ref FixedArray16<short> pleft = ref Unsafe.As<Vector256<short>, FixedArray16<short>>(ref left);
                ref FixedArray16<short> pright = ref Unsafe.As<Vector256<short>, FixedArray16<short>>(ref right);
                p.I0 = (short)BitMath.ToInt32Mask(pleft.I0 != pright.I0);
                p.I1 = (short)BitMath.ToInt32Mask(pleft.I1 != pright.I1);
                p.I2 = (short)BitMath.ToInt32Mask(pleft.I2 != pright.I2);
                p.I3 = (short)BitMath.ToInt32Mask(pleft.I3 != pright.I3);
                p.I4 = (short)BitMath.ToInt32Mask(pleft.I4 != pright.I4);
                p.I5 = (short)BitMath.ToInt32Mask(pleft.I5 != pright.I5);
                p.I6 = (short)BitMath.ToInt32Mask(pleft.I6 != pright.I6);
                p.I7 = (short)BitMath.ToInt32Mask(pleft.I7 != pright.I7);
                p.I8 = (short)BitMath.ToInt32Mask(pleft.I8 != pright.I8);
                p.I9 = (short)BitMath.ToInt32Mask(pleft.I9 != pright.I9);
                p.I10 = (short)BitMath.ToInt32Mask(pleft.I10 != pright.I10);
                p.I11 = (short)BitMath.ToInt32Mask(pleft.I11 != pright.I11);
                p.I12 = (short)BitMath.ToInt32Mask(pleft.I12 != pright.I12);
                p.I13 = (short)BitMath.ToInt32Mask(pleft.I13 != pright.I13);
                p.I14 = (short)BitMath.ToInt32Mask(pleft.I14 != pright.I14);
                p.I15 = (short)BitMath.ToInt32Mask(pleft.I15 != pright.I15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YIsNotEquals_Basic(Vector256<ushort> left, Vector256<ushort> right) {
                UnsafeUtil.SkipInit(out Vector256<ushort> rt);
                ref FixedArray16<short> p = ref Unsafe.As<Vector256<ushort>, FixedArray16<short>>(ref rt);
                ref FixedArray16<ushort> pleft = ref Unsafe.As<Vector256<ushort>, FixedArray16<ushort>>(ref left);
                ref FixedArray16<ushort> pright = ref Unsafe.As<Vector256<ushort>, FixedArray16<ushort>>(ref right);
                p.I0 = (short)BitMath.ToInt32Mask(pleft.I0 != pright.I0);
                p.I1 = (short)BitMath.ToInt32Mask(pleft.I1 != pright.I1);
                p.I2 = (short)BitMath.ToInt32Mask(pleft.I2 != pright.I2);
                p.I3 = (short)BitMath.ToInt32Mask(pleft.I3 != pright.I3);
                p.I4 = (short)BitMath.ToInt32Mask(pleft.I4 != pright.I4);
                p.I5 = (short)BitMath.ToInt32Mask(pleft.I5 != pright.I5);
                p.I6 = (short)BitMath.ToInt32Mask(pleft.I6 != pright.I6);
                p.I7 = (short)BitMath.ToInt32Mask(pleft.I7 != pright.I7);
                p.I8 = (short)BitMath.ToInt32Mask(pleft.I8 != pright.I8);
                p.I9 = (short)BitMath.ToInt32Mask(pleft.I9 != pright.I9);
                p.I10 = (short)BitMath.ToInt32Mask(pleft.I10 != pright.I10);
                p.I11 = (short)BitMath.ToInt32Mask(pleft.I11 != pright.I11);
                p.I12 = (short)BitMath.ToInt32Mask(pleft.I12 != pright.I12);
                p.I13 = (short)BitMath.ToInt32Mask(pleft.I13 != pright.I13);
                p.I14 = (short)BitMath.ToInt32Mask(pleft.I14 != pright.I14);
                p.I15 = (short)BitMath.ToInt32Mask(pleft.I15 != pright.I15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNotEquals_Basic(Vector256<int> left, Vector256<int> right) {
                UnsafeUtil.SkipInit(out Vector256<int> rt);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref rt);
                ref FixedArray8<int> pleft = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref left);
                ref FixedArray8<int> pright = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 != pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 != pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 != pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 != pright.I3);
                p.I4 = BitMath.ToInt32Mask(pleft.I4 != pright.I4);
                p.I5 = BitMath.ToInt32Mask(pleft.I5 != pright.I5);
                p.I6 = BitMath.ToInt32Mask(pleft.I6 != pright.I6);
                p.I7 = BitMath.ToInt32Mask(pleft.I7 != pright.I7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YIsNotEquals_Basic(Vector256<uint> left, Vector256<uint> right) {
                UnsafeUtil.SkipInit(out Vector256<uint> rt);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<uint>, FixedArray8<int>>(ref rt);
                ref FixedArray8<uint> pleft = ref Unsafe.As<Vector256<uint>, FixedArray8<uint>>(ref left);
                ref FixedArray8<uint> pright = ref Unsafe.As<Vector256<uint>, FixedArray8<uint>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 != pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 != pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 != pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 != pright.I3);
                p.I4 = BitMath.ToInt32Mask(pleft.I4 != pright.I4);
                p.I5 = BitMath.ToInt32Mask(pleft.I5 != pright.I5);
                p.I6 = BitMath.ToInt32Mask(pleft.I6 != pright.I6);
                p.I7 = BitMath.ToInt32Mask(pleft.I7 != pright.I7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNotEquals_Basic(Vector256<long> left, Vector256<long> right) {
                UnsafeUtil.SkipInit(out Vector256<long> rt);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref rt);
                ref FixedArray4<long> pleft = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref left);
                ref FixedArray4<long> pright = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 != pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 != pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 != pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 != pright.I3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YIsNotEquals_Basic(Vector256<ulong> left, Vector256<ulong> right) {
                UnsafeUtil.SkipInit(out Vector256<ulong> rt);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<ulong>, FixedArray4<long>>(ref rt);
                ref FixedArray4<ulong> pleft = ref Unsafe.As<Vector256<ulong>, FixedArray4<ulong>>(ref left);
                ref FixedArray4<ulong> pright = ref Unsafe.As<Vector256<ulong>, FixedArray4<ulong>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 != pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 != pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 != pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 != pright.I3);
                return rt;
            }

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YIsNotEquals_Bit(Vector256<float> left, Vector256<float> right) {
                return OnesComplement(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YIsNotEquals_Bit(Vector256<double> left, Vector256<double> right) {
                return OnesComplement(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YIsNotEquals_Bit(Vector256<sbyte> left, Vector256<sbyte> right) {
                return OnesComplement(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YIsNotEquals_Bit(Vector256<byte> left, Vector256<byte> right) {
                return OnesComplement(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YIsNotEquals_Bit(Vector256<short> left, Vector256<short> right) {
                return OnesComplement(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YIsNotEquals_Bit(Vector256<ushort> left, Vector256<ushort> right) {
                return OnesComplement(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNotEquals_Bit(Vector256<int> left, Vector256<int> right) {
                return OnesComplement(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YIsNotEquals_Bit(Vector256<uint> left, Vector256<uint> right) {
                return OnesComplement(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNotEquals_Bit(Vector256<long> left, Vector256<long> right) {
                return OnesComplement(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YIsNotEquals_Bit(Vector256<ulong> left, Vector256<ulong> right) {
                return OnesComplement(Equals(left, right));
            }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits256.YIsNotNaN_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNotNaN_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= (TypeCodeFlags.Single | TypeCodeFlags.Double) & Equals_AcceleratedTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNotNaN(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsNotNaN(Vector256<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsNotNaN_Bit(value);
#else
                return YIsNotNaN_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsNotNaN(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsNotNaN(Vector256<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsNotNaN_Bit(value);
#else
                return YIsNotNaN_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger_AcceleratedTypes"/>
            public static TypeCodeFlags YIsOddInteger_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.IntTypes & Equals_AcceleratedTypes;
                        rt |= (TypeCodeFlags.Single | TypeCodeFlags.Double) & YIsInteger_AcceleratedTypes & Floor_AcceleratedTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsOddInteger(Vector256<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsOddInteger_Bit(value);
#else
                return YIsOddInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsOddInteger(Vector256<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsOddInteger_Bit(value);
#else
                return YIsOddInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YIsOddInteger(Vector256<sbyte> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsOddInteger_Bit(value);
#else
                return YIsOddInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YIsOddInteger(Vector256<byte> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsOddInteger_Bit(value);
#else
                return YIsOddInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YIsOddInteger(Vector256<short> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsOddInteger_Bit(value);
#else
                return YIsOddInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YIsOddInteger(Vector256<ushort> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsOddInteger_Bit(value);
#else
                return YIsOddInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsOddInteger(Vector256<int> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsOddInteger_Bit(value);
#else
                return YIsOddInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YIsOddInteger(Vector256<uint> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsOddInteger_Bit(value);
#else
                return YIsOddInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsOddInteger(Vector256<long> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsOddInteger_Bit(value);
#else
                return YIsOddInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YIsOddInteger(Vector256<ulong> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsOddInteger_Bit(value);
#else
                return YIsOddInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsOddInteger_Basic(Vector256<float> value) {
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
            public static Vector256<long> YIsOddInteger_Basic(Vector256<double> value) {
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
            public static Vector256<sbyte> YIsOddInteger_Basic(Vector256<sbyte> value) {
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
            public static Vector256<byte> YIsOddInteger_Basic(Vector256<byte> value) {
                return YIsOddInteger_Basic(value.AsSByte()).AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YIsOddInteger_Basic(Vector256<short> value) {
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
            public static Vector256<ushort> YIsOddInteger_Basic(Vector256<ushort> value) {
                return YIsOddInteger_Basic(value.AsInt16()).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsOddInteger_Basic(Vector256<int> value) {
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
            public static Vector256<uint> YIsOddInteger_Basic(Vector256<uint> value) {
                return YIsOddInteger_Basic(value.AsInt32()).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsOddInteger_Basic(Vector256<long> value) {
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
            public static Vector256<ulong> YIsOddInteger_Basic(Vector256<ulong> value) {
                return YIsOddInteger_Basic(value.AsInt64()).AsUInt64();
            }

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsOddInteger_Bit(Vector256<float> value) {
                Vector256<float> valueHalf = Vector256.Multiply(value, 0.5f);
                Vector256<float> valueHalfTrun = Vector256.Floor(valueHalf);
                Vector256<int> intMask = YIsInteger(value);
                Vector256<int> halfEqual = Vector256.Equals(valueHalf, valueHalfTrun).AsInt32();
                Vector256<int> rt = Vector256.AndNot(intMask, halfEqual);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsOddInteger_Bit(Vector256<double> value) {
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
            public static Vector256<sbyte> YIsOddInteger_Bit(Vector256<sbyte> value) {
                Vector256<sbyte> temp = Vector256.BitwiseAnd(value, Vector256Constants.Byte_One.AsSByte());
                Vector256<sbyte> rt = Vector256.GreaterThan(temp, Vector256<sbyte>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YIsOddInteger_Bit(Vector256<byte> value) {
                return YIsOddInteger_Bit(value.AsSByte()).AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YIsOddInteger_Bit(Vector256<short> value) {
                Vector256<short> temp = Vector256.BitwiseAnd(value, Vector256Constants.Int16_One);
                Vector256<short> rt = Vector256.GreaterThan(temp, Vector256<short>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YIsOddInteger_Bit(Vector256<ushort> value) {
                return YIsOddInteger_Bit(value.AsInt16()).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsOddInteger_Bit(Vector256<int> value) {
                Vector256<int> temp = Vector256.BitwiseAnd(value, Vector256Constants.Int32_One);
                Vector256<int> rt = Vector256.GreaterThan(temp, Vector256<int>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YIsOddInteger_Bit(Vector256<uint> value) {
                return YIsOddInteger_Bit(value.AsInt32()).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsOddInteger_Bit(Vector256<long> value) {
                Vector256<long> temp = Vector256.BitwiseAnd(value, Vector256Constants.Int64_One);
                Vector256<long> rt = Vector256.GreaterThan(temp, Vector256<long>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YIsOddInteger_Bit(Vector256<ulong> value) {
                return YIsOddInteger_Bit(value.AsInt64()).AsUInt64();
            }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits256.YIsPositive_AcceleratedTypes"/>
            public static TypeCodeFlags YIsPositive_AcceleratedTypes {
                get {
                    return YIsNegative_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsPositive(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsPositive(Vector256<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsPositive_Bit(value);
#else
                return YIsPositive_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsPositive(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsPositive(Vector256<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsPositive_Bit(value);
#else
                return YIsPositive_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsPositive(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YIsPositive(Vector256<sbyte> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsPositive_Bit(value);
#else
                return YIsPositive_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsPositive(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YIsPositive(Vector256<short> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsPositive_Bit(value);
#else
                return YIsPositive_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsPositive(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsPositive(Vector256<int> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsPositive_Bit(value);
#else
                return YIsPositive_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsPositive(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsPositive(Vector256<long> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsPositive_Bit(value);
#else
                return YIsPositive_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits256.YIsPositiveInfinity_AcceleratedTypes"/>
            public static TypeCodeFlags YIsPositiveInfinity_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= (TypeCodeFlags.Single | TypeCodeFlags.Double) & Equals_AcceleratedTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsPositiveInfinity(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsPositiveInfinity(Vector256<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsPositiveInfinity_Bit(value);
#else
                return YIsPositiveInfinity_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsPositiveInfinity(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsPositiveInfinity(Vector256<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsPositiveInfinity_Bit(value);
#else
                return YIsPositiveInfinity_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits256.YIsSubnormal_AcceleratedTypes"/>
            public static TypeCodeFlags YIsSubnormal_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    rt |= TypeCodeFlags.Single;
                    rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes & GreaterThan_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsSubnormal(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsSubnormal(Vector256<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsSubnormal_Bit(value);
#else
                return YIsSubnormal_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsSubnormal(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsSubnormal(Vector256<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsSubnormal_Bit(value);
#else
                return YIsSubnormal_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD


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
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsZero_Bit(value);
#else
                return YIsZero_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsZero(Vector256<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsZero_Bit(value);
#else
                return YIsZero_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YIsZero(Vector256<sbyte> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsZero_Bit(value);
#else
                return YIsZero_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YIsZero(Vector256<byte> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsZero_Bit(value);
#else
                return YIsZero_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YIsZero(Vector256<short> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsZero_Bit(value);
#else
                return YIsZero_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YIsZero(Vector256<ushort> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsZero_Bit(value);
#else
                return YIsZero_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsZero(Vector256<int> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsZero_Bit(value);
#else
                return YIsZero_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YIsZero(Vector256<uint> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsZero_Bit(value);
#else
                return YIsZero_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsZero(Vector256<long> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsZero_Bit(value);
#else
                return YIsZero_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YIsZero(Vector256<ulong> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsZero_Bit(value);
#else
                return YIsZero_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsZero_Basic(Vector256<float> value) {
                UnsafeUtil.SkipInit(out Vector256<int> rt);
                ref FixedArray8<float> pvalue = ref Unsafe.As<Vector256<float>, FixedArray8<float>>(ref value);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I3));
                p.I4 = BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I4));
                p.I5 = BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I5));
                p.I6 = BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I6));
                p.I7 = BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsZero_Basic(Vector256<double> value) {
                UnsafeUtil.SkipInit(out Vector256<long> rt);
                ref FixedArray4<double> pvalue = ref Unsafe.As<Vector256<double>, FixedArray4<double>>(ref value);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I3));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YIsZero_Basic(Vector256<sbyte> value) {
                UnsafeUtil.SkipInit(out Vector256<sbyte> rt);
                ref FixedArray32<sbyte> pvalue = ref Unsafe.As<Vector256<sbyte>, FixedArray32<sbyte>>(ref value);
                ref FixedArray32<sbyte> p = ref Unsafe.As<Vector256<sbyte>, FixedArray32<sbyte>>(ref rt);
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
                p.I16 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I16));
                p.I17 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I17));
                p.I18 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I18));
                p.I19 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I19));
                p.I20 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I20));
                p.I21 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I21));
                p.I22 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I22));
                p.I23 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I23));
                p.I24 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I24));
                p.I25 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I25));
                p.I26 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I26));
                p.I27 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I27));
                p.I28 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I28));
                p.I29 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I29));
                p.I30 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I30));
                p.I31 = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I31));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YIsZero_Basic(Vector256<byte> value) {
                return YIsZero_Basic(value.AsSByte()).AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YIsZero_Basic(Vector256<short> value) {
                UnsafeUtil.SkipInit(out Vector256<short> rt);
                ref FixedArray16<short> pvalue = ref Unsafe.As<Vector256<short>, FixedArray16<short>>(ref value);
                ref FixedArray16<short> p = ref Unsafe.As<Vector256<short>, FixedArray16<short>>(ref rt);
                p.I0 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I0));
                p.I1 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I1));
                p.I2 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I2));
                p.I3 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I3));
                p.I4 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I4));
                p.I5 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I5));
                p.I6 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I6));
                p.I7 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I7));
                p.I8 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I8));
                p.I9 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I9));
                p.I10 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I10));
                p.I11 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I11));
                p.I12 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I12));
                p.I13 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I13));
                p.I14 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I14));
                p.I15 = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I15));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YIsZero_Basic(Vector256<ushort> value) {
                return YIsZero_Basic(value.AsInt16()).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsZero_Basic(Vector256<int> value) {
                UnsafeUtil.SkipInit(out Vector256<int> rt);
                ref FixedArray8<int> pvalue = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref value);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I3));
                p.I4 = BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I4));
                p.I5 = BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I5));
                p.I6 = BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I6));
                p.I7 = BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YIsZero_Basic(Vector256<uint> value) {
                return YIsZero_Basic(value.AsInt32()).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsZero_Basic(Vector256<long> value) {
                UnsafeUtil.SkipInit(out Vector256<long> rt);
                ref FixedArray4<long> pvalue = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref value);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsZero(pvalue.I3));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YIsZero_Basic(Vector256<ulong> value) {
                return YIsZero_Basic(value.AsInt64()).AsUInt64();
            }

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsZero_Bit(Vector256<float> value) {
                return Vector256.Equals(Vector256<float>.Zero, value).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsZero_Bit(Vector256<double> value) {
                return Vector256.Equals(Vector256<double>.Zero, value).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YIsZero_Bit(Vector256<sbyte> value) {
                return Vector256.Equals(Vector256<sbyte>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YIsZero_Bit(Vector256<byte> value) {
                return Vector256.Equals(Vector256<byte>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YIsZero_Bit(Vector256<short> value) {
                return Vector256.Equals(Vector256<short>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YIsZero_Bit(Vector256<ushort> value) {
                return Vector256.Equals(Vector256<ushort>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsZero_Bit(Vector256<int> value) {
                return Vector256.Equals(Vector256<int>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YIsZero_Bit(Vector256<uint> value) {
                return Vector256.Equals(Vector256<uint>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsZero_Bit(Vector256<long> value) {
                return Vector256.Equals(Vector256<long>.Zero, value);
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YIsZero_Bit(Vector256<ulong> value) {
                return Vector256.Equals(Vector256<ulong>.Zero, value);
            }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits256.YIsZeroOrSubnormal_AcceleratedTypes"/>
            public static TypeCodeFlags YIsZeroOrSubnormal_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single;
                        rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double);
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZeroOrSubnormal(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsZeroOrSubnormal(Vector256<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsZeroOrSubnormal_Bit(value);
#else
                return YIsZeroOrSubnormal_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZeroOrSubnormal(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsZeroOrSubnormal(Vector256<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsZeroOrSubnormal_Bit(value);
#else
                return YIsZeroOrSubnormal_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZeroOrSubnormal(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsZeroOrSubnormal_Basic(Vector256<float> value) {
                UnsafeUtil.SkipInit(out Vector256<int> rt);
                ref FixedArray8<float> pvalue = ref Unsafe.As<Vector256<float>, FixedArray8<float>>(ref value);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsZeroOrSubnormal(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsZeroOrSubnormal(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsZeroOrSubnormal(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsZeroOrSubnormal(pvalue.I3));
                p.I4 = BitMathCore.ToInt32Mask(MathINumberBase.IsZeroOrSubnormal(pvalue.I4));
                p.I5 = BitMathCore.ToInt32Mask(MathINumberBase.IsZeroOrSubnormal(pvalue.I5));
                p.I6 = BitMathCore.ToInt32Mask(MathINumberBase.IsZeroOrSubnormal(pvalue.I6));
                p.I7 = BitMathCore.ToInt32Mask(MathINumberBase.IsZeroOrSubnormal(pvalue.I7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZeroOrSubnormal(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsZeroOrSubnormal_Basic(Vector256<double> value) {
                UnsafeUtil.SkipInit(out Vector256<long> rt);
                ref FixedArray4<double> pvalue = ref Unsafe.As<Vector256<double>, FixedArray4<double>>(ref value);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref rt);
                p.I0 = BitMathCore.ToInt32Mask(MathINumberBase.IsZeroOrSubnormal(pvalue.I0));
                p.I1 = BitMathCore.ToInt32Mask(MathINumberBase.IsZeroOrSubnormal(pvalue.I1));
                p.I2 = BitMathCore.ToInt32Mask(MathINumberBase.IsZeroOrSubnormal(pvalue.I2));
                p.I3 = BitMathCore.ToInt32Mask(MathINumberBase.IsZeroOrSubnormal(pvalue.I3));
                return rt;
            }

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits256.YIsZeroOrSubnormal(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsZeroOrSubnormal_Bit(Vector256<float> value) {
                Vector256<int> exponentMask = Vector256Constants.Single_ExponentMask.AsInt32();
                Vector256<int> exponent = Vector256.BitwiseAnd(value.AsInt32(), exponentMask);
                Vector256<int> rt = Vector256.Equals(exponent, Vector256<int>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsZeroOrSubnormal(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsZeroOrSubnormal_Bit(Vector256<double> value) {
                Vector256<long> exponentMask = Vector256Constants.Double_ExponentMask.AsInt64();
                Vector256<long> exponent = Vector256.BitwiseAnd(value.AsInt64(), exponentMask);
                Vector256<long> rt = Vector256.Equals(exponent, Vector256<long>.Zero);
                return rt;
            }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD

#endif // NETCOREAPP3_0_OR_GREATER
        }
    }
}
