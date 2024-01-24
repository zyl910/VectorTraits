#define VECTOR_HAS_METHOD

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using System.Numerics;
using Zyl.VectorTraits.Extensions.SameW;
using Zyl.VectorTraits.Impl.Util;
using Zyl.VectorTraits.Numerics;

namespace Zyl.VectorTraits.Impl.AVector {

    partial class VectorTraitsBase {

        partial class Statics {

            /// <inheritdoc cref="IVectorTraits.YIsAllTrue_AcceleratedTypes"/>
            public static TypeCodeFlags YIsAllTrue_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
                    if (Vector.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsAllTrue{T}(Vector{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAllTrue<T>(Vector<T> value) where T : struct {
                Vector<int> allBitsSet = Vectors<int>.AllBitsSet;
                return Vector.EqualsAll(value.AsInt32(), allBitsSet);
            }


            /// <inheritdoc cref="IVectorTraits.YIsAnyTrue_AcceleratedTypes"/>
            public static TypeCodeFlags YIsAnyTrue_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
                    if (Vector.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsAnyTrue{T}(Vector{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAnyTrue<T>(Vector<T> value) where T : struct {
                Vector<byte> allBitsSet = Vectors<byte>.AllBitsSet; // Must use byte.
                return Vector.EqualsAny(value.AsByte(), allBitsSet);
            }


            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger_AcceleratedTypes"/>
            public static TypeCodeFlags YIsEvenInteger_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.IntTypes & Equals_AcceleratedTypes;
                        rt |= (TypeCodeFlags.Single | TypeCodeFlags.Double) & YIsInteger_AcceleratedTypes & Floor_AcceleratedTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsEvenInteger(Vector<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsEvenInteger_Bit(value);
#else
                return YIsEvenInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsEvenInteger(Vector<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsEvenInteger_Bit(value);
#else
                return YIsEvenInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YIsEvenInteger(Vector<sbyte> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsEvenInteger_Bit(value);
#else
                return YIsEvenInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YIsEvenInteger(Vector<byte> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsEvenInteger_Bit(value);
#else
                return YIsEvenInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YIsEvenInteger(Vector<short> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsEvenInteger_Bit(value);
#else
                return YIsEvenInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YIsEvenInteger(Vector<ushort> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsEvenInteger_Bit(value);
#else
                return YIsEvenInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsEvenInteger(Vector<int> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsEvenInteger_Bit(value);
#else
                return YIsEvenInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YIsEvenInteger(Vector<uint> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsEvenInteger_Bit(value);
#else
                return YIsEvenInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsEvenInteger(Vector<long> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsEvenInteger_Bit(value);
#else
                return YIsEvenInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YIsEvenInteger(Vector<ulong> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsEvenInteger_Bit(value);
#else
                return YIsEvenInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsEvenInteger_Basic(Vector<float> value) {
                Vector<float> rt = value;
                ref float p = ref Unsafe.As<Vector<float>, float>(ref rt);
                for (nint i = 0; i < Vector<float>.Count; ++i) {
                    p = MathBitConverter.Int32BitsToSingle(BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(p)));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt.AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsEvenInteger_Basic(Vector<double> value) {
                Vector<double> rt = value;
                ref double p = ref Unsafe.As<Vector<double>, double>(ref rt);
                for (nint i = 0; i < Vector<double>.Count; ++i) {
                    p = MathBitConverter.Int64BitsToDouble(BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(p)));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt.AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YIsEvenInteger_Basic(Vector<sbyte> value) {
                Vector<sbyte> rt = value;
                ref sbyte p = ref Unsafe.As<Vector<sbyte>, sbyte>(ref rt);
                for (nint i = 0; i < Vector<sbyte>.Count; ++i) {
                    p = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(p));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YIsEvenInteger_Basic(Vector<byte> value) {
                return YIsEvenInteger_Basic(value.AsSByte()).AsByte();
            }

            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YIsEvenInteger_Basic(Vector<short> value) {
                Vector<short> rt = value;
                ref short p = ref Unsafe.As<Vector<short>, short>(ref rt);
                for (nint i = 0; i < Vector<short>.Count; ++i) {
                    p = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(p));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YIsEvenInteger_Basic(Vector<ushort> value) {
                return YIsEvenInteger_Basic(value.AsInt16()).AsUInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsEvenInteger_Basic(Vector<int> value) {
                Vector<int> rt = value;
                ref int p = ref Unsafe.As<Vector<int>, int>(ref rt);
                for (nint i = 0; i < Vector<int>.Count; ++i) {
                    p = BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(p));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YIsEvenInteger_Basic(Vector<uint> value) {
                return YIsEvenInteger_Basic(value.AsInt32()).AsUInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsEvenInteger_Basic(Vector<long> value) {
                Vector<long> rt = value;
                ref long p = ref Unsafe.As<Vector<long>, long>(ref rt);
                for (nint i = 0; i < Vector<long>.Count; ++i) {
                    p = BitMathCore.ToInt32Mask(MathINumberBase.IsEvenInteger(p));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YIsEvenInteger_Basic(Vector<ulong> value) {
                return YIsEvenInteger_Basic(value.AsInt64()).AsUInt64();
            }

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsEvenInteger_Bit(Vector<float> value) {
                Vector<float> valueHalf = Vector.Multiply(value, 0.5f);
                Vector<float> valueHalfTrun = Floor(valueHalf);
                Vector<int> intMask = YIsInteger(value);
                Vector<int> halfEqual = Vector.Equals(valueHalf, valueHalfTrun).AsInt32();
                Vector<int> rt = Vector.BitwiseAnd(intMask, halfEqual);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsEvenInteger_Bit(Vector<double> value) {
                Vector<double> valueHalf = Vector.Multiply(value, 0.5);
                Vector<double> valueHalfTrun = Floor(valueHalf);
                Vector<long> intMask = YIsInteger(value);
                Vector<long> halfEqual = Vector.Equals(valueHalf, valueHalfTrun).AsInt64();
                Vector<long> rt = Vector.BitwiseAnd(intMask, halfEqual);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YIsEvenInteger_Bit(Vector<sbyte> value) {
                Vector<sbyte> temp = Vector.BitwiseAnd(value, VectorConstants.Byte_One.AsSByte());
                Vector<sbyte> rt = Vector.Equals(Vector<sbyte>.Zero, temp);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YIsEvenInteger_Bit(Vector<byte> value) {
                return YIsEvenInteger_Bit(value.AsSByte()).AsByte();
            }

            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YIsEvenInteger_Bit(Vector<short> value) {
                Vector<short> temp = Vector.BitwiseAnd(value, VectorConstants.Int16_One);
                Vector<short> rt = Vector.Equals(Vector<short>.Zero, temp);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YIsEvenInteger_Bit(Vector<ushort> value) {
                return YIsEvenInteger_Bit(value.AsInt16()).AsUInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsEvenInteger_Bit(Vector<int> value) {
                Vector<int> temp = Vector.BitwiseAnd(value, VectorConstants.Int32_One);
                Vector<int> rt = Vector.Equals(Vector<int>.Zero, temp);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YIsEvenInteger_Bit(Vector<uint> value) {
                return YIsEvenInteger_Bit(value.AsInt32()).AsUInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsEvenInteger_Bit(Vector<long> value) {
                Vector<long> temp = Vector.BitwiseAnd(value, VectorConstants.Int64_One);
                Vector<long> rt = Vector.Equals(Vector<long>.Zero, temp);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YIsEvenInteger_Bit(Vector<ulong> value) {
                return YIsEvenInteger_Bit(value.AsInt64()).AsUInt64();
            }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IVectorTraits.YIsFinite_AcceleratedTypes"/>
            public static TypeCodeFlags YIsFinite_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single;
                        rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double);
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsFinite(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsFinite(Vector<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsFinite_Bit(value);
#else
                return YIsFinite_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsFinite(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsFinite(Vector<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsFinite_Bit(value);
#else
                return YIsFinite_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsFinite(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsFinite_Basic(Vector<float> value) {
                Vector<float> rt = value;
                ref float p = ref Unsafe.As<Vector<float>, float>(ref rt);
                for (nint i = 0; i < Vector<float>.Count; ++i) {
                    p = MathBitConverter.Int32BitsToSingle(BitMathCore.ToInt32Mask(MathINumberBase.IsFinite(p)));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt.AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YIsFinite(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsFinite_Basic(Vector<double> value) {
                Vector<double> rt = value;
                ref double p = ref Unsafe.As<Vector<double>, double>(ref rt);
                for (nint i = 0; i < Vector<double>.Count; ++i) {
                    p = MathBitConverter.Int64BitsToDouble(BitMathCore.ToInt32Mask(MathINumberBase.IsFinite(p)));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt.AsInt64();
            }

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            /// <inheritdoc cref="IVectorTraits.YIsFinite(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsFinite_Bit(Vector<float> value) {
                Vector<int> exponentMask = VectorConstants.Single_ExponentMask.AsInt32();
                Vector<int> exponent = Vector.BitwiseAnd(value.AsInt32(), exponentMask);
                Vector<int> rt = Vector.OnesComplement(Vector.Equals(exponent, exponentMask));
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsFinite(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsFinite_Bit(Vector<double> value) {
                Vector<long> exponentMask = VectorConstants.Double_ExponentMask.AsInt64();
                Vector<long> exponent = Vector.BitwiseAnd(value.AsInt64(), exponentMask);
                Vector<long> rt = Vector.OnesComplement(Vector.Equals(exponent, exponentMask));
                return rt;
            }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IVectorTraits.YIsInfinity_AcceleratedTypes"/>
            public static TypeCodeFlags YIsInfinity_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single;
                        rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double);
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsInfinity(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsInfinity(Vector<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsInfinity_Bit(value);
#else
                return YIsInfinity_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsInfinity(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsInfinity(Vector<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsInfinity_Bit(value);
#else
                return YIsInfinity_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsInfinity(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsInfinity_Basic(Vector<float> value) {
                Vector<float> rt = value;
                ref float p = ref Unsafe.As<Vector<float>, float>(ref rt);
                for (nint i = 0; i < Vector<float>.Count; ++i) {
                    p = MathBitConverter.Int32BitsToSingle(BitMathCore.ToInt32Mask(MathINumberBase.IsInfinity(p)));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt.AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YIsInfinity(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsInfinity_Basic(Vector<double> value) {
                Vector<double> rt = value;
                ref double p = ref Unsafe.As<Vector<double>, double>(ref rt);
                for (nint i = 0; i < Vector<double>.Count; ++i) {
                    p = MathBitConverter.Int64BitsToDouble(BitMathCore.ToInt32Mask(MathINumberBase.IsInfinity(p)));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt.AsInt64();
            }

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            /// <inheritdoc cref="IVectorTraits.YIsInfinity(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsInfinity_Bit(Vector<float> value) {
                Vector<int> nonSignMask = VectorConstants.Single_NonSignMask.AsInt32();
                Vector<int> exponentMask = VectorConstants.Single_ExponentMask.AsInt32();
                Vector<int> nonSign = Vector.BitwiseAnd(value.AsInt32(), nonSignMask);
                Vector<int> rt = Vector.Equals(nonSign, exponentMask);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsInfinity(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsInfinity_Bit(Vector<double> value) {
                Vector<long> nonSignMask = VectorConstants.Double_NonSignMask.AsInt64();
                Vector<long> exponentMask = VectorConstants.Double_ExponentMask.AsInt64();
                Vector<long> nonSign = Vector.BitwiseAnd(value.AsInt64(), nonSignMask);
                Vector<long> rt = Vector.Equals(nonSign, exponentMask);
                return rt;
            }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IVectorTraits.YIsInfinityOrNaN_AcceleratedTypes"/>
            public static TypeCodeFlags YIsInfinityOrNaN_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single;
                        rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double);
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsInfinityOrNaN(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsInfinityOrNaN(Vector<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsInfinityOrNaN_Bit(value);
#else
                return YIsInfinityOrNaN_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsInfinityOrNaN(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsInfinityOrNaN(Vector<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsInfinityOrNaN_Bit(value);
#else
                return YIsInfinityOrNaN_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsInfinityOrNaN(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsInfinityOrNaN_Basic(Vector<float> value) {
                Vector<float> rt = value;
                ref float p = ref Unsafe.As<Vector<float>, float>(ref rt);
                for (nint i = 0; i < Vector<float>.Count; ++i) {
                    p = MathBitConverter.Int32BitsToSingle(BitMathCore.ToInt32Mask(MathINumberBase.IsInfinityOrNaN(p)));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt.AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YIsInfinityOrNaN(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsInfinityOrNaN_Basic(Vector<double> value) {
                Vector<double> rt = value;
                ref double p = ref Unsafe.As<Vector<double>, double>(ref rt);
                for (nint i = 0; i < Vector<double>.Count; ++i) {
                    p = MathBitConverter.Int64BitsToDouble(BitMathCore.ToInt32Mask(MathINumberBase.IsInfinityOrNaN(p)));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt.AsInt64();
            }

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            /// <inheritdoc cref="IVectorTraits.YIsInfinityOrNaN(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsInfinityOrNaN_Bit(Vector<float> value) {
                Vector<int> exponentMask = VectorConstants.Single_ExponentMask.AsInt32();
                Vector<int> exponent = Vector.BitwiseAnd(value.AsInt32(), exponentMask);
                Vector<int> rt = Vector.Equals(exponent, exponentMask);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsInfinityOrNaN(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsInfinityOrNaN_Bit(Vector<double> value) {
                Vector<long> exponentMask = VectorConstants.Double_ExponentMask.AsInt64();
                Vector<long> exponent = Vector.BitwiseAnd(value.AsInt64(), exponentMask);
                Vector<long> rt = Vector.Equals(exponent, exponentMask);
                return rt;
            }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IVectorTraits.YIsInteger_AcceleratedTypes"/>
            public static TypeCodeFlags YIsInteger_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single;
                        rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double) & Floor_AcceleratedTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsInteger(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsInteger(Vector<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsInteger_Bit(value);
#else
                return YIsInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsInteger(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsInteger(Vector<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsInteger_Bit(value);
#else
                return YIsInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsInteger(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsInteger_Basic(Vector<float> value) {
                Vector<float> rt = value;
                ref float p = ref Unsafe.As<Vector<float>, float>(ref rt);
                for (nint i = 0; i < Vector<float>.Count; ++i) {
                    p = MathBitConverter.Int32BitsToSingle(BitMathCore.ToInt32Mask(MathINumberBase.IsInteger(p)));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt.AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YIsInteger(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsInteger_Basic(Vector<double> value) {
                Vector<double> rt = value;
                ref double p = ref Unsafe.As<Vector<double>, double>(ref rt);
                for (nint i = 0; i < Vector<double>.Count; ++i) {
                    p = MathBitConverter.Int64BitsToDouble(BitMathCore.ToInt32Mask(MathINumberBase.IsInteger(p)));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt.AsInt64();
            }

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            /// <inheritdoc cref="IVectorTraits.YIsInteger(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsInteger_Bit(Vector<float> value) {
                Vector<float> valueTrun = Floor(value);
                Vector<int> maskFinite = YIsFinite(value);
                Vector<int> maskEquals = Vector.Equals(value, valueTrun).AsInt32();
                Vector<int> rt = Vector.BitwiseAnd(maskFinite, maskEquals);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsInteger(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsInteger_Bit(Vector<double> value) {
                Vector<double> valueTrun = Floor(value);
                Vector<long> maskFinite = YIsFinite(value);
                Vector<long> maskEquals = Vector.Equals(value, valueTrun).AsInt64();
                Vector<long> rt = Vector.BitwiseAnd(maskFinite, maskEquals);
                return rt;
            }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IVectorTraits.YIsNaN_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNaN_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector.IsHardwareAccelerated) {
                        rt |= (TypeCodeFlags.Single | TypeCodeFlags.Double) & Equals_AcceleratedTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsNaN(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsNaN(Vector<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsNaN_Bit(value);
#else
                return YIsNaN_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsNaN(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsNaN(Vector<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsNaN_Bit(value);
#else
                return YIsNaN_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsNaN(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsNaN_Basic(Vector<float> value) {
                Vector<float> rt = value;
                ref float p = ref Unsafe.As<Vector<float>, float>(ref rt);
                for (nint i = 0; i < Vector<float>.Count; ++i) {
                    p = MathBitConverter.Int32BitsToSingle(BitMathCore.ToInt32Mask(MathINumberBase.IsNaN(p)));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt.AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YIsNaN(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsNaN_Basic(Vector<double> value) {
                Vector<double> rt = value;
                ref double p = ref Unsafe.As<Vector<double>, double>(ref rt);
                for (nint i = 0; i < Vector<double>.Count; ++i) {
                    p = MathBitConverter.Int64BitsToDouble(BitMathCore.ToInt32Mask(MathINumberBase.IsNaN(p)));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt.AsInt64();
            }

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            /// <inheritdoc cref="IVectorTraits.YIsNaN(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsNaN_Bit(Vector<float> value) {
#pragma warning disable CS1718 // Comparison made to same variable; did you mean to compare something else?
                Vector<int> rt = Vector.OnesComplement(Vector.Equals(value, value).AsInt32());
#pragma warning restore CS1718 // Comparison made to same variable; did you mean to compare something else?
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsNaN(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsNaN_Bit(Vector<double> value) {
#pragma warning disable CS1718 // Comparison made to same variable; did you mean to compare something else?
                Vector<long> rt = Vector.OnesComplement(Vector.Equals(value, value).AsInt64());
#pragma warning restore CS1718 // Comparison made to same variable; did you mean to compare something else?
                return rt;
            }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IVectorTraits.YIsNegative_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNegative_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector.IsHardwareAccelerated) {
                        rt |= (TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64) & LessThan_AcceleratedTypes;
                        rt |= TypeCodeFlagsUtil.MapFlags(LessThan_AcceleratedTypes, TypeCodeFlags.Int32, TypeCodeFlags.Single, TypeCodeFlags.Int64, TypeCodeFlags.Double);
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsNegative(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsNegative(Vector<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsNegative_Bit(value);
#else
                return YIsNegative_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsNegative(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsNegative(Vector<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsNegative_Bit(value);
#else
                return YIsNegative_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsNegative(Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YIsNegative(Vector<sbyte> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsNegative_Bit(value);
#else
                return YIsNegative_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsNegative(Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YIsNegative(Vector<short> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsNegative_Bit(value);
#else
                return YIsNegative_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsNegative(Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsNegative(Vector<int> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsNegative_Bit(value);
#else
                return YIsNegative_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsNegative(Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsNegative(Vector<long> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsNegative_Bit(value);
#else
                return YIsNegative_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsNegative(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsNegative_Basic(Vector<float> value) {
                Vector<float> rt = value;
                ref float p = ref Unsafe.As<Vector<float>, float>(ref rt);
                for (nint i = 0; i < Vector<float>.Count; ++i) {
                    p = MathBitConverter.Int32BitsToSingle(BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(p)));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt.AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YIsNegative(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsNegative_Basic(Vector<double> value) {
                Vector<double> rt = value;
                ref double p = ref Unsafe.As<Vector<double>, double>(ref rt);
                for (nint i = 0; i < Vector<double>.Count; ++i) {
                    p = MathBitConverter.Int64BitsToDouble(BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(p)));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt.AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YIsNegative(Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YIsNegative_Basic(Vector<sbyte> value) {
                Vector<sbyte> rt = value;
                ref sbyte p = ref Unsafe.As<Vector<sbyte>, sbyte>(ref rt);
                for (nint i = 0; i < Vector<sbyte>.Count; ++i) {
                    p = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(p));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsNegative(Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YIsNegative_Basic(Vector<short> value) {
                Vector<short> rt = value;
                ref short p = ref Unsafe.As<Vector<short>, short>(ref rt);
                for (nint i = 0; i < Vector<short>.Count; ++i) {
                    p = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(p));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsNegative(Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsNegative_Basic(Vector<int> value) {
                Vector<int> rt = value;
                ref int p = ref Unsafe.As<Vector<int>, int>(ref rt);
                for (nint i = 0; i < Vector<int>.Count; ++i) {
                    p = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(p));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsNegative(Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsNegative_Basic(Vector<long> value) {
                Vector<long> rt = value;
                ref long p = ref Unsafe.As<Vector<long>, long>(ref rt);
                for (nint i = 0; i < Vector<long>.Count; ++i) {
                    p = BitMathCore.ToInt32Mask(MathINumberBase.IsNegative(p));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            /// <inheritdoc cref="IVectorTraits.YIsNegative(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsNegative_Bit(Vector<float> value) {
                return YIsNegative_Bit(value.AsInt32());
            }

            /// <inheritdoc cref="IVectorTraits.YIsNegative(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsNegative_Bit(Vector<double> value) {
                return YIsNegative_Bit(value.AsInt64());
            }

            /// <inheritdoc cref="IVectorTraits.YIsNegative(Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YIsNegative_Bit(Vector<sbyte> value) {
                Vector<sbyte> rt = Vector.LessThan(value, Vector<sbyte>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsNegative(Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YIsNegative_Bit(Vector<short> value) {
#if NET7_0_OR_GREATER
                Vector<short> rt = Vector.ShiftRightArithmetic(value, 15);
#else
                Vector<short> rt = Vector.LessThan(value, Vector<short>.Zero);
#endif // NET7_0_OR_GREATER
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsNegative(Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsNegative_Bit(Vector<int> value) {
#if NET7_0_OR_GREATER
                Vector<int> rt = Vector.ShiftRightArithmetic(value, 31);
#else
                Vector<int> rt = Vector.LessThan(value, Vector<int>.Zero);
#endif // NET7_0_OR_GREATER
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsNegative(Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsNegative_Bit(Vector<long> value) {
                Vector<long> rt = Vector.LessThan(value, Vector<long>.Zero);
                return rt;
            }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IVectorTraits.YIsNegativeInfinity_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNegativeInfinity_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector.IsHardwareAccelerated) {
                        rt |= (TypeCodeFlags.Single | TypeCodeFlags.Double) & Equals_AcceleratedTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsNegativeInfinity(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsNegativeInfinity(Vector<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsNegativeInfinity_Bit(value);
#else
                return YIsNegativeInfinity_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsNegativeInfinity(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsNegativeInfinity(Vector<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsNegativeInfinity_Bit(value);
#else
                return YIsNegativeInfinity_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsNegativeInfinity(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsNegativeInfinity_Basic(Vector<float> value) {
                Vector<float> rt = value;
                ref float p = ref Unsafe.As<Vector<float>, float>(ref rt);
                for (nint i = 0; i < Vector<float>.Count; ++i) {
                    p = MathBitConverter.Int32BitsToSingle(BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeInfinity(p)));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt.AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YIsNegativeInfinity(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsNegativeInfinity_Basic(Vector<double> value) {
                Vector<double> rt = value;
                ref double p = ref Unsafe.As<Vector<double>, double>(ref rt);
                for (nint i = 0; i < Vector<double>.Count; ++i) {
                    p = MathBitConverter.Int64BitsToDouble(BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeInfinity(p)));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt.AsInt64();
            }

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            /// <inheritdoc cref="IVectorTraits.YIsNegativeInfinity(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsNegativeInfinity_Bit(Vector<float> value) {
                Vector<float> sample = new Vector<float>(float.NegativeInfinity);
                Vector<int> rt = Vector.Equals(value, sample).AsInt32();
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsNegativeInfinity(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsNegativeInfinity_Bit(Vector<double> value) {
                Vector<double> sample = new Vector<double>(double.NegativeInfinity);
                Vector<long> rt = Vector.Equals(value, sample).AsInt64();
                return rt;
            }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IVectorTraits.YIsNegativeZero_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNegativeZero_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single;
                        rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double);
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsNegativeZero(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsNegativeZero(Vector<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsNegativeZero_Bit(value);
#else
                return YIsNegativeZero_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsNegativeZero(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsNegativeZero(Vector<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsNegativeZero_Bit(value);
#else
                return YIsNegativeZero_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsNegativeZero(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsNegativeZero_Basic(Vector<float> value) {
                Vector<float> rt = value;
                ref float p = ref Unsafe.As<Vector<float>, float>(ref rt);
                for (nint i = 0; i < Vector<float>.Count; ++i) {
                    p = MathBitConverter.Int32BitsToSingle(BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeZero(p)));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt.AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YIsNegativeZero(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsNegativeZero_Basic(Vector<double> value) {
                Vector<double> rt = value;
                ref double p = ref Unsafe.As<Vector<double>, double>(ref rt);
                for (nint i = 0; i < Vector<double>.Count; ++i) {
                    p = MathBitConverter.Int64BitsToDouble(BitMathCore.ToInt32Mask(MathINumberBase.IsNegativeZero(p)));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt.AsInt64();
            }

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            /// <inheritdoc cref="IVectorTraits.YIsNegativeZero(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsNegativeZero_Bit(Vector<float> value) {
                Vector<int> signMask = VectorConstants.Single_SignMask.AsInt32();
                Vector<int> rt = Vector.Equals(value.AsInt32(), signMask);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsNegativeZero(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsNegativeZero_Bit(Vector<double> value) {
                Vector<long> signMask = VectorConstants.Double_SignMask.AsInt64();
                Vector<long> rt = Vector.Equals(value.AsInt64(), signMask);
                return rt;
            }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IVectorTraits.YIsNormal_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNormal_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.MapFlags(GreaterThan_AcceleratedTypes, TypeCodeFlags.Int32, TypeCodeFlags.Single, TypeCodeFlags.Int64, TypeCodeFlags.Double);
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsNormal(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsNormal(Vector<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsNormal_Bit(value);
#else
                return YIsNormal_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsNormal(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsNormal(Vector<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsNormal_Bit(value);
#else
                return YIsNormal_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsNormal(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsNormal_Basic(Vector<float> value) {
                Vector<float> rt = value;
                ref float p = ref Unsafe.As<Vector<float>, float>(ref rt);
                for (nint i = 0; i < Vector<float>.Count; ++i) {
                    p = MathBitConverter.Int32BitsToSingle(BitMathCore.ToInt32Mask(MathINumberBase.IsNormal(p)));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt.AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YIsNormal(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsNormal_Basic(Vector<double> value) {
                Vector<double> rt = value;
                ref double p = ref Unsafe.As<Vector<double>, double>(ref rt);
                for (nint i = 0; i < Vector<double>.Count; ++i) {
                    p = MathBitConverter.Int64BitsToDouble(BitMathCore.ToInt32Mask(MathINumberBase.IsNormal(p)));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt.AsInt64();
            }

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            /// <inheritdoc cref="IVectorTraits.YIsNormal(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsNormal_Bit(Vector<float> value) {
                Vector<int> exponentMask = VectorConstants.Single_ExponentMask.AsInt32();
                Vector<int> exponent = Vector.BitwiseAnd(value.AsInt32(), exponentMask);
                Vector<int> rt = Vector.BitwiseAnd(Vector.GreaterThan(exponent, Vector<int>.Zero), Vector.GreaterThan(exponentMask, exponent));
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsNormal(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsNormal_Bit(Vector<double> value) {
                Vector<long> exponentMask = VectorConstants.Double_ExponentMask.AsInt64();
                Vector<long> exponent = Vector.BitwiseAnd(value.AsInt64(), exponentMask);
                Vector<long> rt = Vector.BitwiseAnd(Vector.GreaterThan(exponent, Vector<long>.Zero), Vector.GreaterThan(exponentMask, exponent));
                return rt;
            }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IVectorTraits.YIsNotNaN_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNotNaN_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector.IsHardwareAccelerated) {
                        rt |= (TypeCodeFlags.Single | TypeCodeFlags.Double) & Equals_AcceleratedTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsNotNaN(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsNotNaN(Vector<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsNotNaN_Bit(value);
#else
                return YIsNotNaN_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsNotNaN(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsNotNaN(Vector<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsNotNaN_Bit(value);
#else
                return YIsNotNaN_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsNotNaN(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsNotNaN_Basic(Vector<float> value) {
                Vector<float> rt = value;
                ref float p = ref Unsafe.As<Vector<float>, float>(ref rt);
                for (nint i = 0; i < Vector<float>.Count; ++i) {
                    p = MathBitConverter.Int32BitsToSingle(BitMathCore.ToInt32Mask(MathINumberBase.IsNotNaN(p)));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt.AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YIsNotNaN(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsNotNaN_Basic(Vector<double> value) {
                Vector<double> rt = value;
                ref double p = ref Unsafe.As<Vector<double>, double>(ref rt);
                for (nint i = 0; i < Vector<double>.Count; ++i) {
                    p = MathBitConverter.Int64BitsToDouble(BitMathCore.ToInt32Mask(MathINumberBase.IsNotNaN(p)));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt.AsInt64();
            }

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            /// <inheritdoc cref="IVectorTraits.YIsNotNaN(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsNotNaN_Bit(Vector<float> value) {
#pragma warning disable CS1718 // Comparison made to same variable; did you mean to compare something else?
                Vector<int> rt = Vector.Equals(value, value).AsInt32();
#pragma warning restore CS1718 // Comparison made to same variable; did you mean to compare something else?
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsNotNaN(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsNotNaN_Bit(Vector<double> value) {
#pragma warning disable CS1718 // Comparison made to same variable; did you mean to compare something else?
                Vector<long> rt = Vector.Equals(value, value).AsInt64();
#pragma warning restore CS1718 // Comparison made to same variable; did you mean to compare something else?
                return rt;
            }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IVectorTraits.YIsOddInteger_AcceleratedTypes"/>
            public static TypeCodeFlags YIsOddInteger_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.IntTypes & Equals_AcceleratedTypes;
                        rt |= (TypeCodeFlags.Single | TypeCodeFlags.Double) & YIsInteger_AcceleratedTypes & Floor_AcceleratedTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsOddInteger(Vector<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsOddInteger_Bit(value);
#else
                return YIsOddInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsOddInteger(Vector<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsOddInteger_Bit(value);
#else
                return YIsOddInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YIsOddInteger(Vector<sbyte> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsOddInteger_Bit(value);
#else
                return YIsOddInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YIsOddInteger(Vector<byte> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsOddInteger_Bit(value);
#else
                return YIsOddInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YIsOddInteger(Vector<short> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsOddInteger_Bit(value);
#else
                return YIsOddInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YIsOddInteger(Vector<ushort> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsOddInteger_Bit(value);
#else
                return YIsOddInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsOddInteger(Vector<int> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsOddInteger_Bit(value);
#else
                return YIsOddInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YIsOddInteger(Vector<uint> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsOddInteger_Bit(value);
#else
                return YIsOddInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsOddInteger(Vector<long> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsOddInteger_Bit(value);
#else
                return YIsOddInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YIsOddInteger(Vector<ulong> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsOddInteger_Bit(value);
#else
                return YIsOddInteger_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsOddInteger_Basic(Vector<float> value) {
                Vector<float> rt = value;
                ref float p = ref Unsafe.As<Vector<float>, float>(ref rt);
                for (nint i = 0; i < Vector<float>.Count; ++i) {
                    p = MathBitConverter.Int32BitsToSingle(BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(p)));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt.AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsOddInteger_Basic(Vector<double> value) {
                Vector<double> rt = value;
                ref double p = ref Unsafe.As<Vector<double>, double>(ref rt);
                for (nint i = 0; i < Vector<double>.Count; ++i) {
                    p = MathBitConverter.Int64BitsToDouble(BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(p)));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt.AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YIsOddInteger_Basic(Vector<sbyte> value) {
                Vector<sbyte> rt = value;
                ref sbyte p = ref Unsafe.As<Vector<sbyte>, sbyte>(ref rt);
                for (nint i = 0; i < Vector<sbyte>.Count; ++i) {
                    p = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(p));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YIsOddInteger_Basic(Vector<byte> value) {
                return YIsOddInteger_Basic(value.AsSByte()).AsByte();
            }

            /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YIsOddInteger_Basic(Vector<short> value) {
                Vector<short> rt = value;
                ref short p = ref Unsafe.As<Vector<short>, short>(ref rt);
                for (nint i = 0; i < Vector<short>.Count; ++i) {
                    p = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(p));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YIsOddInteger_Basic(Vector<ushort> value) {
                return YIsOddInteger_Basic(value.AsInt16()).AsUInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsOddInteger_Basic(Vector<int> value) {
                Vector<int> rt = value;
                ref int p = ref Unsafe.As<Vector<int>, int>(ref rt);
                for (nint i = 0; i < Vector<int>.Count; ++i) {
                    p = BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(p));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YIsOddInteger_Basic(Vector<uint> value) {
                return YIsOddInteger_Basic(value.AsInt32()).AsUInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsOddInteger_Basic(Vector<long> value) {
                Vector<long> rt = value;
                ref long p = ref Unsafe.As<Vector<long>, long>(ref rt);
                for (nint i = 0; i < Vector<long>.Count; ++i) {
                    p = BitMathCore.ToInt32Mask(MathINumberBase.IsOddInteger(p));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YIsOddInteger_Basic(Vector<ulong> value) {
                return YIsOddInteger_Basic(value.AsInt64()).AsUInt64();
            }

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsOddInteger_Bit(Vector<float> value) {
                Vector<float> valueHalf = Vector.Multiply(value, 0.5f);
                Vector<float> valueHalfTrun = Floor(valueHalf);
                Vector<int> intMask = YIsInteger(value);
                Vector<int> halfEqual = Vector.Equals(valueHalf, valueHalfTrun).AsInt32();
                Vector<int> rt = Vector.AndNot(intMask, halfEqual);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsOddInteger_Bit(Vector<double> value) {
                Vector<double> valueHalf = Vector.Multiply(value, 0.5);
                Vector<double> valueHalfTrun = Floor(valueHalf);
                Vector<long> intMask = YIsInteger(value);
                Vector<long> halfEqual = Vector.Equals(valueHalf, valueHalfTrun).AsInt64();
                Vector<long> rt = Vector.AndNot(intMask, halfEqual);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YIsOddInteger_Bit(Vector<sbyte> value) {
                Vector<sbyte> temp = Vector.BitwiseAnd(value, VectorConstants.Byte_One.AsSByte());
                Vector<sbyte> rt = Vector.GreaterThan(temp, Vector<sbyte>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YIsOddInteger_Bit(Vector<byte> value) {
                return YIsOddInteger_Bit(value.AsSByte()).AsByte();
            }

            /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YIsOddInteger_Bit(Vector<short> value) {
                Vector<short> temp = Vector.BitwiseAnd(value, VectorConstants.Int16_One);
                Vector<short> rt = Vector.GreaterThan(temp, Vector<short>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YIsOddInteger_Bit(Vector<ushort> value) {
                return YIsOddInteger_Bit(value.AsInt16()).AsUInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsOddInteger_Bit(Vector<int> value) {
                Vector<int> temp = Vector.BitwiseAnd(value, VectorConstants.Int32_One);
                Vector<int> rt = Vector.GreaterThan(temp, Vector<int>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YIsOddInteger_Bit(Vector<uint> value) {
                return YIsOddInteger_Bit(value.AsInt32()).AsUInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsOddInteger_Bit(Vector<long> value) {
                Vector<long> temp = Vector.BitwiseAnd(value, VectorConstants.Int64_One);
                Vector<long> rt = Vector.GreaterThan(temp, Vector<long>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YIsOddInteger_Bit(Vector<ulong> value) {
                return YIsOddInteger_Bit(value.AsInt64()).AsUInt64();
            }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IVectorTraits.YIsPositive_AcceleratedTypes"/>
            public static TypeCodeFlags YIsPositive_AcceleratedTypes {
                get {
                    return YIsNegative_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsPositive(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsPositive(Vector<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsPositive_Bit(value);
#else
                return YIsPositive_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsPositive(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsPositive(Vector<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsPositive_Bit(value);
#else
                return YIsPositive_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsPositive(Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YIsPositive(Vector<sbyte> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsPositive_Bit(value);
#else
                return YIsPositive_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsPositive(Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YIsPositive(Vector<short> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsPositive_Bit(value);
#else
                return YIsPositive_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsPositive(Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsPositive(Vector<int> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsPositive_Bit(value);
#else
                return YIsPositive_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsPositive(Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsPositive(Vector<long> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsPositive_Bit(value);
#else
                return YIsPositive_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsPositive(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsPositive_Basic(Vector<float> value) {
                Vector<float> rt = value;
                ref float p = ref Unsafe.As<Vector<float>, float>(ref rt);
                for (nint i = 0; i < Vector<float>.Count; ++i) {
                    p = MathBitConverter.Int32BitsToSingle(BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(p)));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt.AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YIsPositive(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsPositive_Basic(Vector<double> value) {
                Vector<double> rt = value;
                ref double p = ref Unsafe.As<Vector<double>, double>(ref rt);
                for (nint i = 0; i < Vector<double>.Count; ++i) {
                    p = MathBitConverter.Int64BitsToDouble(BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(p)));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt.AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YIsPositive(Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YIsPositive_Basic(Vector<sbyte> value) {
                Vector<sbyte> rt = value;
                ref sbyte p = ref Unsafe.As<Vector<sbyte>, sbyte>(ref rt);
                for (nint i = 0; i < Vector<sbyte>.Count; ++i) {
                    p = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(p));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsPositive(Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YIsPositive_Basic(Vector<short> value) {
                Vector<short> rt = value;
                ref short p = ref Unsafe.As<Vector<short>, short>(ref rt);
                for (nint i = 0; i < Vector<short>.Count; ++i) {
                    p = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(p));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsPositive(Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsPositive_Basic(Vector<int> value) {
                Vector<int> rt = value;
                ref int p = ref Unsafe.As<Vector<int>, int>(ref rt);
                for (nint i = 0; i < Vector<int>.Count; ++i) {
                    p = BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(p));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsPositive(Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsPositive_Basic(Vector<long> value) {
                Vector<long> rt = value;
                ref long p = ref Unsafe.As<Vector<long>, long>(ref rt);
                for (nint i = 0; i < Vector<long>.Count; ++i) {
                    p = BitMathCore.ToInt32Mask(MathINumberBase.IsPositive(p));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            /// <inheritdoc cref="IVectorTraits.YIsPositive(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsPositive_Bit(Vector<float> value) {
                return YIsPositive_Bit(value.AsInt32());
            }

            /// <inheritdoc cref="IVectorTraits.YIsPositive(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsPositive_Bit(Vector<double> value) {
                return YIsPositive_Bit(value.AsInt64());
            }

            /// <inheritdoc cref="IVectorTraits.YIsPositive(Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YIsPositive_Bit(Vector<sbyte> value) {
                Vector<sbyte> rt = Vector.OnesComplement(YIsNegative(value));
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsPositive(Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YIsPositive_Bit(Vector<short> value) {
                Vector<short> rt = Vector.OnesComplement(YIsNegative(value));
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsPositive(Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsPositive_Bit(Vector<int> value) {
                Vector<int> rt = Vector.OnesComplement(YIsNegative(value));
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsPositive(Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsPositive_Bit(Vector<long> value) {
                Vector<long> rt = Vector.OnesComplement(YIsNegative(value));
                return rt;
            }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IVectorTraits.YIsPositiveInfinity_AcceleratedTypes"/>
            public static TypeCodeFlags YIsPositiveInfinity_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector.IsHardwareAccelerated) {
                        rt |= (TypeCodeFlags.Single | TypeCodeFlags.Double) & Equals_AcceleratedTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsPositiveInfinity(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsPositiveInfinity(Vector<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsPositiveInfinity_Bit(value);
#else
                return YIsPositiveInfinity_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsPositiveInfinity(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsPositiveInfinity(Vector<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsPositiveInfinity_Bit(value);
#else
                return YIsPositiveInfinity_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsPositiveInfinity(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsPositiveInfinity_Basic(Vector<float> value) {
                Vector<float> rt = value;
                ref float p = ref Unsafe.As<Vector<float>, float>(ref rt);
                for (nint i = 0; i < Vector<float>.Count; ++i) {
                    p = MathBitConverter.Int32BitsToSingle(BitMathCore.ToInt32Mask(MathINumberBase.IsPositiveInfinity(p)));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt.AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YIsPositiveInfinity(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsPositiveInfinity_Basic(Vector<double> value) {
                Vector<double> rt = value;
                ref double p = ref Unsafe.As<Vector<double>, double>(ref rt);
                for (nint i = 0; i < Vector<double>.Count; ++i) {
                    p = MathBitConverter.Int64BitsToDouble(BitMathCore.ToInt32Mask(MathINumberBase.IsPositiveInfinity(p)));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt.AsInt64();
            }

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            /// <inheritdoc cref="IVectorTraits.YIsPositiveInfinity(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsPositiveInfinity_Bit(Vector<float> value) {
                Vector<float> sample = new Vector<float>(float.NegativeInfinity);
                Vector<int> rt = Vector.Equals(value, sample).AsInt32();
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsPositiveInfinity(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsPositiveInfinity_Bit(Vector<double> value) {
                Vector<double> sample = new Vector<double>(double.NegativeInfinity);
                Vector<long> rt = Vector.Equals(value, sample).AsInt64();
                return rt;
            }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IVectorTraits.YIsSubnormal_AcceleratedTypes"/>
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

            /// <inheritdoc cref="IVectorTraits.YIsSubnormal(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsSubnormal(Vector<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsSubnormal_Bit(value);
#else
                return YIsSubnormal_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsSubnormal(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsSubnormal(Vector<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsSubnormal_Bit(value);
#else
                return YIsSubnormal_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsSubnormal(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsSubnormal_Basic(Vector<float> value) {
                Vector<float> rt = value;
                ref float p = ref Unsafe.As<Vector<float>, float>(ref rt);
                for (nint i = 0; i < Vector<float>.Count; ++i) {
                    p = MathBitConverter.Int32BitsToSingle(BitMathCore.ToInt32Mask(MathINumberBase.IsSubnormal(p)));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt.AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YIsSubnormal(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsSubnormal_Basic(Vector<double> value) {
                Vector<double> rt = value;
                ref double p = ref Unsafe.As<Vector<double>, double>(ref rt);
                for (nint i = 0; i < Vector<double>.Count; ++i) {
                    p = MathBitConverter.Int64BitsToDouble(BitMathCore.ToInt32Mask(MathINumberBase.IsSubnormal(p)));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt.AsInt64();
            }

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            /// <inheritdoc cref="IVectorTraits.YIsSubnormal(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsSubnormal_Bit(Vector<float> value) {
                Vector<int> exponentMask = VectorConstants.Single_ExponentMask.AsInt32();
                Vector<int> mantissaMask = VectorConstants.Single_MantissaMask.AsInt32();
                Vector<int> zero = Vector<int>.Zero;
                Vector<int> exponent = Vector.BitwiseAnd(value.AsInt32(), exponentMask);
                Vector<int> mantissa = Vector.BitwiseAnd(value.AsInt32(), mantissaMask);
                Vector<int> rt = Vector.BitwiseAnd(Vector.Equals(exponent, zero), Vector.GreaterThan(mantissa, zero));
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsSubnormal(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsSubnormal_Bit(Vector<double> value) {
                Vector<long> exponentMask = VectorConstants.Double_ExponentMask.AsInt64();
                Vector<long> mantissaMask = VectorConstants.Double_MantissaMask.AsInt64();
                Vector<long> zero = Vector<long>.Zero;
                Vector<long> exponent = Vector.BitwiseAnd(value.AsInt64(), exponentMask);
                Vector<long> mantissa = Vector.BitwiseAnd(value.AsInt64(), mantissaMask);
                Vector<long> rt = Vector.BitwiseAnd(Vector.Equals(exponent, zero), Vector.GreaterThan(mantissa, zero));
                return rt;
            }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IVectorTraits.YIsZero_AcceleratedTypes"/>
            public static TypeCodeFlags YIsZero_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = Equals_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsZero(Vector<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsZero_Bit(value);
#else
                return YIsZero_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsZero(Vector<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsZero_Bit(value);
#else
                return YIsZero_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YIsZero(Vector<sbyte> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsZero_Bit(value);
#else
                return YIsZero_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YIsZero(Vector<byte> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsZero_Bit(value);
#else
                return YIsZero_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YIsZero(Vector<short> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsZero_Bit(value);
#else
                return YIsZero_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YIsZero(Vector<ushort> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsZero_Bit(value);
#else
                return YIsZero_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsZero(Vector<int> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsZero_Bit(value);
#else
                return YIsZero_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YIsZero(Vector<uint> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsZero_Bit(value);
#else
                return YIsZero_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsZero(Vector<long> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsZero_Bit(value);
#else
                return YIsZero_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YIsZero(Vector<ulong> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsZero_Bit(value);
#else
                return YIsZero_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsZero_Basic(Vector<float> value) {
                Vector<float> rt = value;
                ref float p = ref Unsafe.As<Vector<float>, float>(ref rt);
                for (nint i = 0; i < Vector<float>.Count; ++i) {
                    p = MathBitConverter.Int32BitsToSingle(BitMathCore.ToInt32Mask(MathINumberBase.IsZero(p)));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt.AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsZero_Basic(Vector<double> value) {
                Vector<double> rt = value;
                ref double p = ref Unsafe.As<Vector<double>, double>(ref rt);
                for (nint i = 0; i < Vector<double>.Count; ++i) {
                    p = MathBitConverter.Int64BitsToDouble(BitMathCore.ToInt32Mask(MathINumberBase.IsZero(p)));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt.AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YIsZero_Basic(Vector<sbyte> value) {
                Vector<sbyte> rt = value;
                ref sbyte p = ref Unsafe.As<Vector<sbyte>, sbyte>(ref rt);
                for (nint i = 0; i < Vector<sbyte>.Count; ++i) {
                    p = (sbyte)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(p));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YIsZero_Basic(Vector<byte> value) {
                return YIsZero_Basic(value.AsSByte()).AsByte();
            }

            /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YIsZero_Basic(Vector<short> value) {
                Vector<short> rt = value;
                ref short p = ref Unsafe.As<Vector<short>, short>(ref rt);
                for (nint i = 0; i < Vector<short>.Count; ++i) {
                    p = (short)BitMathCore.ToInt32Mask(MathINumberBase.IsZero(p));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YIsZero_Basic(Vector<ushort> value) {
                return YIsZero_Basic(value.AsInt16()).AsUInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsZero_Basic(Vector<int> value) {
                Vector<int> rt = value;
                ref int p = ref Unsafe.As<Vector<int>, int>(ref rt);
                for (nint i = 0; i < Vector<int>.Count; ++i) {
                    p = BitMathCore.ToInt32Mask(MathINumberBase.IsZero(p));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YIsZero_Basic(Vector<uint> value) {
                return YIsZero_Basic(value.AsInt32()).AsUInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsZero_Basic(Vector<long> value) {
                Vector<long> rt = value;
                ref long p = ref Unsafe.As<Vector<long>, long>(ref rt);
                for (nint i = 0; i < Vector<long>.Count; ++i) {
                    p = BitMathCore.ToInt32Mask(MathINumberBase.IsZero(p));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YIsZero_Basic(Vector<ulong> value) {
                return YIsZero_Basic(value.AsInt64()).AsUInt64();
            }

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsZero_Bit(Vector<float> value) {
                return Vector.Equals(Vector<float>.Zero, value).AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsZero_Bit(Vector<double> value) {
                return Vector.Equals(Vector<double>.Zero, value).AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YIsZero_Bit(Vector<sbyte> value) {
                return Vector.Equals(Vector<sbyte>.Zero, value);
            }

            /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YIsZero_Bit(Vector<byte> value) {
                return Vector.Equals(Vector<byte>.Zero, value);
            }

            /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YIsZero_Bit(Vector<short> value) {
                return Vector.Equals(Vector<short>.Zero, value);
            }

            /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YIsZero_Bit(Vector<ushort> value) {
                return Vector.Equals(Vector<ushort>.Zero, value);
            }

            /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsZero_Bit(Vector<int> value) {
                return Vector.Equals(Vector<int>.Zero, value);
            }

            /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YIsZero_Bit(Vector<uint> value) {
                return Vector.Equals(Vector<uint>.Zero, value);
            }

            /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsZero_Bit(Vector<long> value) {
                return Vector.Equals(Vector<long>.Zero, value);
            }

            /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YIsZero_Bit(Vector<ulong> value) {
                return Vector.Equals(Vector<ulong>.Zero, value);
            }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IVectorTraits.YIsZeroOrSubnormal_AcceleratedTypes"/>
            public static TypeCodeFlags YIsZeroOrSubnormal_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single;
                        rt |= TypeCodeFlagsUtil.MapFlags(Equals_AcceleratedTypes, TypeCodeFlags.Int64, TypeCodeFlags.Double);
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsZeroOrSubnormal(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsZeroOrSubnormal(Vector<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsZeroOrSubnormal_Bit(value);
#else
                return YIsZeroOrSubnormal_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsZeroOrSubnormal(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsZeroOrSubnormal(Vector<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YIsZeroOrSubnormal_Bit(value);
#else
                return YIsZeroOrSubnormal_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YIsZeroOrSubnormal(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsZeroOrSubnormal_Basic(Vector<float> value) {
                Vector<float> rt = value;
                ref float p = ref Unsafe.As<Vector<float>, float>(ref rt);
                for (nint i = 0; i < Vector<float>.Count; ++i) {
                    p = MathBitConverter.Int32BitsToSingle(BitMathCore.ToInt32Mask(MathINumberBase.IsZeroOrSubnormal(p)));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt.AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YIsZeroOrSubnormal(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsZeroOrSubnormal_Basic(Vector<double> value) {
                Vector<double> rt = value;
                ref double p = ref Unsafe.As<Vector<double>, double>(ref rt);
                for (nint i = 0; i < Vector<double>.Count; ++i) {
                    p = MathBitConverter.Int64BitsToDouble(BitMathCore.ToInt32Mask(MathINumberBase.IsZeroOrSubnormal(p)));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt.AsInt64();
            }

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            /// <inheritdoc cref="IVectorTraits.YIsZeroOrSubnormal(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsZeroOrSubnormal_Bit(Vector<float> value) {
                Vector<int> exponentMask = VectorConstants.Single_ExponentMask.AsInt32();
                Vector<int> exponent = Vector.BitwiseAnd(value.AsInt32(), exponentMask);
                Vector<int> rt = Vector.Equals(exponent, Vector<int>.Zero);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YIsZeroOrSubnormal(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsZeroOrSubnormal_Bit(Vector<double> value) {
                Vector<long> exponentMask = VectorConstants.Double_ExponentMask.AsInt64();
                Vector<long> exponent = Vector.BitwiseAnd(value.AsInt64(), exponentMask);
                Vector<long> rt = Vector.Equals(exponent, Vector<long>.Zero);
                return rt;
            }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD

        }
    }
}
