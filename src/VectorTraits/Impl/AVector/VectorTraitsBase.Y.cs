using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using System.Numerics;
using Zyl.VectorTraits.Extensions.SameW;
using Zyl.VectorTraits.Impl.Util;

namespace Zyl.VectorTraits.Impl.AVector {

    partial class VectorTraitsBase {

        partial class Statics {

            /// <inheritdoc cref="IVectorTraits.YClamp_AcceleratedTypes"/>
            public static TypeCodeFlags YClamp_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
                    if (Vector.IsHardwareAccelerated) {
                        rt = TypeCodeFlagsUtil.AllTypes;
                    }
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YClamp(Vector{float}, Vector{float}, Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YClamp(Vector<float> value, Vector<float> amin, Vector<float> amax) {
                return Vector.Min(Vector.Max(amin, value), amax);
            }

            /// <inheritdoc cref="IVectorTraits.YClamp(Vector{double}, Vector{double}, Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YClamp(Vector<double> value, Vector<double> amin, Vector<double> amax) {
                return Vector.Min(Vector.Max(amin, value), amax);
            }

            /// <inheritdoc cref="IVectorTraits.YClamp(Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YClamp(Vector<sbyte> value, Vector<sbyte> amin, Vector<sbyte> amax) {
                return Vector.Min(Vector.Max(amin, value), amax);
            }

            /// <inheritdoc cref="IVectorTraits.YClamp(Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YClamp(Vector<byte> value, Vector<byte> amin, Vector<byte> amax) {
                return Vector.Min(Vector.Max(amin, value), amax);
            }

            /// <inheritdoc cref="IVectorTraits.YClamp(Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YClamp(Vector<short> value, Vector<short> amin, Vector<short> amax) {
                return Vector.Min(Vector.Max(amin, value), amax);
            }

            /// <inheritdoc cref="IVectorTraits.YClamp(Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YClamp(Vector<ushort> value, Vector<ushort> amin, Vector<ushort> amax) {
                return Vector.Min(Vector.Max(amin, value), amax);
            }

            /// <inheritdoc cref="IVectorTraits.YClamp(Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YClamp(Vector<int> value, Vector<int> amin, Vector<int> amax) {
                return Vector.Min(Vector.Max(amin, value), amax);
            }

            /// <inheritdoc cref="IVectorTraits.YClamp(Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YClamp(Vector<uint> value, Vector<uint> amin, Vector<uint> amax) {
                return Vector.Min(Vector.Max(amin, value), amax);
            }

            /// <inheritdoc cref="IVectorTraits.YClamp(Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YClamp(Vector<long> value, Vector<long> amin, Vector<long> amax) {
                return Vector.Min(Vector.Max(amin, value), amax);
            }

            /// <inheritdoc cref="IVectorTraits.YClamp(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YClamp(Vector<ulong> value, Vector<ulong> amin, Vector<ulong> amax) {
                return Vector.Min(Vector.Max(amin, value), amax);
            }


            /// <inheritdoc cref="IVectorTraits.YNarrowSaturate_AcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturate_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = (Narrow_AcceleratedTypes & YClamp_AcceleratedTypes)
                        & (TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64);
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturate_FullAcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturate_FullAcceleratedTypes {
                get {
                    return TypeCodeFlags.None;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{short}, Vector{short})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YNarrowSaturate(Vector<short> lower, Vector<short> upper) {
                Vector<short> amin = Vectors<short>.VMinSByte;
                Vector<short> amax = Vectors<short>.VMaxSByte;
                Vector<short> l = YClamp(lower, amin, amax);
                Vector<short> u = YClamp(upper, amin, amax);
                return Narrow(l, u);
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{ushort}, Vector{ushort})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YNarrowSaturate(Vector<ushort> lower, Vector<ushort> upper) {
                Vector<ushort> amax = Vectors<ushort>.VMaxByte;
                Vector<ushort> l = Vector.Min(lower, amax);
                Vector<ushort> u = Vector.Min(upper, amax);
                return Narrow(l, u);
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{int}, Vector{int})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YNarrowSaturate(Vector<int> lower, Vector<int> upper) {
                Vector<int> amin = Vectors<int>.VMinInt16;
                Vector<int> amax = Vectors<int>.VMaxInt16;
                Vector<int> l = YClamp(lower, amin, amax);
                Vector<int> u = YClamp(upper, amin, amax);
                return Narrow(l, u);
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{uint}, Vector{uint})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YNarrowSaturate(Vector<uint> lower, Vector<uint> upper) {
                Vector<uint> amax = Vectors<uint>.VMaxUInt16;
                Vector<uint> l = Vector.Min(lower, amax);
                Vector<uint> u = Vector.Min(upper, amax);
                return Narrow(l, u);
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{long}, Vector{long})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YNarrowSaturate(Vector<long> lower, Vector<long> upper) {
                Vector<long> amin = Vectors<long>.VMinInt32;
                Vector<long> amax = Vectors<long>.VMaxInt32;
                Vector<long> l = YClamp(lower, amin, amax);
                Vector<long> u = YClamp(upper, amin, amax);
                return Narrow(l, u);
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{ulong}, Vector{ulong})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YNarrowSaturate(Vector<ulong> lower, Vector<ulong> upper) {
                Vector<ulong> amax = Vectors<ulong>.VMaxUInt32;
                Vector<ulong> l = Vector.Min(lower, amax);
                Vector<ulong> u = Vector.Min(upper, amax);
                return Narrow(l, u);
            }


            /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned_AcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturateUnsigned_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = (Narrow_AcceleratedTypes & YClamp_AcceleratedTypes)
                        & (TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64);
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned_FullAcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturateUnsigned_FullAcceleratedTypes {
                get {
                    return TypeCodeFlags.None;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned(Vector{short}, Vector{short})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YNarrowSaturateUnsigned(Vector<short> lower, Vector<short> upper) {
                Vector<short> amin = Vector<short>.Zero;
                Vector<short> amax = Vectors<short>.VMaxByte;
                Vector<ushort> l = YClamp(lower, amin, amax).AsUInt16();
                Vector<ushort> u = YClamp(upper, amin, amax).AsUInt16();
                return Narrow(l, u);
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned(Vector{int}, Vector{int})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YNarrowSaturateUnsigned(Vector<int> lower, Vector<int> upper) {
                Vector<int> amin = Vector<int>.Zero;
                Vector<int> amax = Vectors<int>.VMaxUInt16;
                Vector<uint> l = YClamp(lower, amin, amax).AsUInt32();
                Vector<uint> u = YClamp(upper, amin, amax).AsUInt32();
                return Narrow(l, u);
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned(Vector{long}, Vector{long})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YNarrowSaturateUnsigned(Vector<long> lower, Vector<long> upper) {
                Vector<long> amin = Vector<long>.Zero;
                Vector<long> amax = Vectors<long>.VMaxUInt32;
                Vector<ulong> l = YClamp(lower, amin, amax).AsUInt64();
                Vector<ulong> u = YClamp(upper, amin, amax).AsUInt64();
                return Narrow(l, u);
            }


            /// <inheritdoc cref="IVectorTraits.YRoundToEven_AcceleratedTypes"/>
            public static TypeCodeFlags YRoundToEven_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double;
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YRoundToEven(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YRoundToEven(Vector<float> value) {
                return YRoundToEven_Add(value);
            }

            /// <inheritdoc cref="IVectorTraits.YRoundToEven(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YRoundToEven(Vector<double> value) {
                return YRoundToEven_Add(value);
            }

            /// <inheritdoc cref="IVectorTraits.YRoundToEven(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YRoundToEven_Add(Vector<float> value) {
                // [Single type] If (0<=x && x<pow(2,23)), `round_to_even(x) = x + pow(2,23) - pow(2,23)`. Next generalize this approach to all number ranges.
                Vector<float> delta = new Vector<float>(ScalarConstants.SingleVal_2Pow23);
                Vector<float> signMask = VectorConstants.Single_SignMask;
                Vector<float> valueAbs = Vector.AndNot(value, signMask);
                Vector<float> signData = Vector.BitwiseAnd(value, signMask);
                Vector<float> allowMask = Vector.LessThan(valueAbs, delta).AsSingle(); // Allow is `(value[i] < pow(2,23) )`.
                delta = Vector.BitwiseOr(delta, signData);
                delta = Vector.BitwiseAnd(delta, allowMask);
                Vector<float> rt = Vector.Add(value, delta);
                rt = Vector.Subtract(rt, delta);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YRoundToEven(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YRoundToEven_Add(Vector<double> value) {
                // [Double type] If (0<=x && x<pow(2,52)), `round_to_even(x) = x + pow(2,52) - pow(2,52)`. Next generalize this approach to all number ranges.
                Vector<double> delta = new Vector<double>(ScalarConstants.DoubleVal_2Pow52);
                Vector<double> signMask = VectorConstants.Double_SignMask;
                Vector<double> valueAbs = Vector.AndNot(value, signMask);
                Vector<double> signData = Vector.BitwiseAnd(value, signMask);
                Vector<double> allowMask = Vector.LessThan(valueAbs, delta).AsDouble(); // Allow is `(value[i] < pow(2,52) )`.
                delta = Vector.BitwiseOr(delta, signData);
                delta = Vector.BitwiseAnd(delta, allowMask);
                Vector<double> rt = Vector.Add(value, delta);
                rt = Vector.Subtract(rt, delta);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YRoundToZero_AcceleratedTypes"/>
            public static TypeCodeFlags YRoundToZero_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double;
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YRoundToZero(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YRoundToZero(Vector<float> value) {
#if NET5_0_OR_GREATER
                return YRoundToZero_Floor(value);
#else
                return YRoundToZero_ClearBit(value);
#endif
            }

            /// <inheritdoc cref="IVectorTraits.YRoundToZero(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YRoundToZero(Vector<double> value) {
#if NET5_0_OR_GREATER
                return YRoundToZero_Floor(value);
#else
                return YRoundToZero_ClearBit(value);
#endif
            }

            /// <inheritdoc cref="IVectorTraits.YRoundToZero(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YRoundToZero_ClearBit(Vector<float> value) {
                //constants.
                Vector<float> allBitsSet = Vectors<float>.AllBitsSet;
                Vector<float> nonSignMask = VectorConstants.Single_NonSignMask;
                Vector<float> rangeBegin = new Vector<float>(1.0f);
                Vector<float> exponentMask = new Vector<float>(ScalarConstants.SingleVal_ExponentMask);
                // operations
                Vector<float> valueAbs = Vector.BitwiseAnd(value, nonSignMask);
                Vector<float> rangeBegin2 = new Vector<float>(2.0f);
                Vector<int> maskBegin = Vector.GreaterThan(rangeBegin.AsInt32(), valueAbs.AsInt32()); // (a>=b) = ~(a<b) = ~(b>a)
                Vector<float> rangeEnd = new Vector<float>(ScalarConstants.SingleVal_2Pow23); // Single value: pow(2, 23)
                maskBegin = Vector.BitwiseAnd(maskBegin, nonSignMask.AsInt32()); // Support NegativeZero (`Math.Truncate(-0.0)` is `-0.0`) .
                Vector<float> valueExpData = Vector.BitwiseAnd(value, exponentMask);
                Vector<int> expMinuend = new Vector<int>(ScalarConstants.SingleBit_Truncate_expMinuend); // Item is `(int)(127*2 + 23)<<23`. Binary is `0x8320000000000000`.
                maskBegin = Vector.Xor(maskBegin, allBitsSet.AsInt32()); // maskBegin[i] = ~((maskBegin[i] > valueAbs[i])&nonSignMask[i]) = (valueAbs[i] >= maskBegin[i])|nonSignMask[i] // Vector.BitwiseOr(Vector.GreaterThanOrEqual(valueAbs, rangeBegin), nonSignMask);
                Vector<int> maskless2 = Vector.GreaterThan(rangeBegin2.AsInt32(), valueAbs.AsInt32()); // (2>valueAbs[i])
                Vector<int> maskEnd = Vector.GreaterThan(rangeEnd.AsInt32(), valueAbs.AsInt32()); // (a>=b) = ~(a<b) = ~(b>a)
                maskEnd = Vector.Xor(maskEnd, allBitsSet.AsInt32()); // maskEnd[i] = ~(rangeEnd[i] > valueAbs[i]) = (valueAbs[i] >= rangeEnd[i]) //Vector.GreaterThanOrEqual(valueAbs, rangeEnd);
                Vector<float> maskRawPow = Vector.Subtract(expMinuend.AsUInt32(), valueExpData.AsUInt32()).AsSingle(); // If valueExpData is `(127 + e)<<23`, `expMinuend-valueExpData` exponent field will be `(127*2 + 23) - (127 + e) = 1023 + (23-e)`
                Vector<float> valueFix = Vector.BitwiseAnd(value, maskBegin.AsSingle());
                Vector<int> mask = Vector.Add(maskRawPow, rangeEnd).AsInt32();
                Vector<int> nonMantissaMask = new Vector<float>(ScalarConstants.SingleVal_NonMantissaMask).AsInt32();
                mask = Vector.Xor(mask, rangeEnd.AsInt32()); // mask = ConvertToUInt32_Range23RoundToEven(maskRawPow).AsInt32();
                mask = Vector.Subtract(Vector<int>.Zero, mask); // The mask is `~(pow(2,23-e)-1)`. Because `-(x) = ~x+1`, the inverse is `~(x-1) = -(x) = 0 - x`.
                mask = Vector.ConditionalSelect(maskless2, nonMantissaMask, mask);
                mask = Vector.BitwiseOr(mask, maskEnd.AsInt32());
                //writer.WriteLine(VectorTextUtil.Format("The maskBegin:\t{0}", maskBegin));
                //writer.WriteLine(VectorTextUtil.Format("The mask:\t{0}", mask));
                Vector<float> rt = Vector.BitwiseAnd(valueFix, mask.AsSingle());
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YRoundToZero(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YRoundToZero_ClearBit(Vector<double> value) {
                // Float encode is `sign*(1.m)*pow(2,e) = sign*(1.m)*pow(2,eBias - BIAS)`. Double's BIAS is `1023`.
                // If (e>=52): Has 0bit fractional part. The mask is `0`.
                // If (e==51): Has 1bit fractional part. The mask is `0x1`.
                // ...
                // If (e==1): Has 51bit fractional part. The mask is `0x0007FFFF_FFFFFFFF`.
                // If (e==0): Has 52bit fractional part. The mask is `0x000FFFFF_FFFFFFFF`.
                // If (e< 0): Need set to zero (0.0 / -0.0). The mask is `0x7FFFFFFF_FFFFFFFF`.
                //
                // If (0<=e && e<=52): The mask is `pow(2,52-e) - 1`. So `RoundToZero(x) = x & ~mask`.
                //Constants.
                Vector<double> exponentMask = new Vector<double>(ScalarConstants.DoubleVal_ExponentMask);
                Vector<double> one = new Vector<double>(1.0);
                Vector<double> rangeEnd = new Vector<double>(ScalarConstants.DoubleVal_2Pow52); // Double value: pow(2, 52)
                Vector<double> nonSignMask = VectorConstants.Double_NonSignMask;
                Vector<double> expMinuend = new Vector<double>(ScalarConstants.DoubleVal_Truncate_expMinuend); // Item is `(long)(1023*2 + 52)<<52`. Binary is `0x8320000000000000`.
                //Operations.
                Vector<double> valueExpData = Vector.BitwiseAnd(value, exponentMask); // Get exponent field.
                Vector<long> maskBegin = Vector.GreaterThan(one, valueExpData); // `1 > valueExpData[i] = pow(2,0) > pow(2,e)`, it mean `e<0`.
                valueExpData = Vector.Min(valueExpData, rangeEnd); // Clamp to `e<=52`.
                maskBegin = Vector.BitwiseAnd(maskBegin, nonSignMask.AsInt64()); // Keep sign flag.
                Vector<double> maskRawPow = Vector.Subtract(expMinuend.AsUInt64(), valueExpData.AsUInt64()).AsDouble(); // If valueExpData is `(1023 + e)<<52`, `expMinuend-valueExpData` exponent field will be `(1023*2 + 52) - (1023 + e) = 1023 + (52-e)`
                maskRawPow = Vector.Subtract(maskRawPow, one); // The mask is `pow(2,52-e) - 1`.
                Vector<long> mask = Vector.Add(maskRawPow, rangeEnd).AsInt64(); // Step 1 of ConvertToUInt64_Range52RoundToEven .
                mask = Vector.Xor(mask, rangeEnd.AsInt64()); // mask = ConvertToUInt64_Range52RoundToEven(maskRawPow).AsInt64();
                Vector<long> allBitsSet = Vectors<long>.AllBitsSet;
                mask = Vector.BitwiseOr(mask, maskBegin); // Choose (e<0).
                //writer.WriteLine(VectorTextUtil.Format("The mask:\t{0}", mask));
                mask = Vector.Xor(mask, allBitsSet); // mask = ~mask;
                Vector<double> rt = Vector.BitwiseAnd(value, mask.AsDouble());
                return rt;
            }

#if NET5_0_OR_GREATER
            /// <inheritdoc cref="IVectorTraits.YRoundToZero(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YRoundToZero_Floor(Vector<float> value) {
                Vector<float> signMask = VectorConstants.Single_SignMask;
                Vector<float> valueAbs = Vector.AndNot(value, signMask);
                Vector<float> signData = Vector.BitwiseAnd(value, signMask);
                Vector<float> rt = Vector.Floor(valueAbs);
                rt = Vector.BitwiseOr(rt, signData);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YRoundToZero(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YRoundToZero_Floor(Vector<double> value) {
                Vector<double> signMask = VectorConstants.Double_SignMask;
                Vector<double> valueAbs = Vector.AndNot(value, signMask);
                Vector<double> signData = Vector.BitwiseAnd(value, signMask);
                Vector<double> rt = Vector.Floor(valueAbs); // Vector.Floor need .NET 5+ .
                rt = Vector.BitwiseOr(rt, signData);
                return rt;
            }
#endif // NET5_0_OR_GREATER


        }
    }
}
