using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
#endif

namespace Zyl.VectorTraits.Impl.AVector128 {
    using SuperStatics = WVectorTraits128Base.Statics;

    partial class WVectorTraits128Sse {

        partial class Statics {

#if NETCOREAPP3_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.YBitToByte_IsAccelerated"/>
            public static bool YBitToByte_IsAccelerated {
                get {
                    bool rt = true;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YBitToByte"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YBitToByte(uint value) {
                if (Ssse3.IsSupported) {
                    return YBitToByte_Shuffle(value);
                } else {
                    return YBitToByte_Widen(value);
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YBitToByte"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YBitToByte_Shuffle(uint value) {
                if (Ssse3.IsSupported) {
                    Vector128<byte> a = Vector128.Create(value).AsByte();
                    Vector128<byte> indices = Vector128Constants.YBitToByte_Shuffle_Indices;
                    Vector128<byte> bitPosMask = Vector128Constants.MaskBitPosSerialRotate8;
                    // Duplicate 8bit value to 64bit
                    Vector128<byte> f = Ssse3.Shuffle(a, indices);
                    // Check bit.
                    Vector128<byte> hit = BitwiseAnd(f, bitPosMask);
                    Vector128<byte> rt = Equals(hit, bitPosMask);
                    return rt;
                } else {
                    return YBitToByte_Widen(value);
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YBitToByte"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YBitToByte_Widen(uint value) {
                Vector128<byte> a = Vector128.Create(value).AsByte();
                Vector128<byte> bitPosMask = Vector128Constants.MaskBitPosSerialRotate8;
                // Widen 8bit to 64bit with duplicate
                Vector128<ushort> b = Sse2.UnpackLow(a, a).AsUInt16();
                Vector128<uint> c = Sse2.UnpackLow(b, b).AsUInt32();
                Vector128<ulong> d = Sse2.UnpackLow(c, c).AsUInt64();
                // Check bit.
                Vector128<byte> hit = BitwiseAnd(d.AsByte(), bitPosMask);
                Vector128<byte> rt = Equals(hit, bitPosMask);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YBitToInt16_IsAccelerated"/>
            public static bool YBitToInt16_IsAccelerated {
                get {
                    bool rt = true;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YBitToInt16"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YBitToInt16(uint value) {
                Vector128<short> bitPosMask = Vector128Constants.MaskBitPosSerialRotate16;
                // Duplicate 16bit value
                Vector128<short> a = Vector128.Create((ushort)value).AsInt16();
                // Check bit.
                Vector128<short> hit = BitwiseAnd(a, bitPosMask);
                Vector128<short> rt = Equals(hit, bitPosMask);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YBitToInt32_IsAccelerated"/>
            public static bool YBitToInt32_IsAccelerated {
                get {
                    bool rt = true;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YBitToInt32"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YBitToInt32(uint value) {
                Vector128<int> bitPosMask = Vector128Constants.MaskBitPosSerialRotate32;
                // Duplicate 32bit value
                Vector128<int> a = Vector128.Create((uint)value).AsInt32();
                // Check bit.
                Vector128<int> hit = BitwiseAnd(a, bitPosMask);
                Vector128<int> rt = Equals(hit, bitPosMask);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YBitToInt64_IsAccelerated"/>
            public static bool YBitToInt64_IsAccelerated {
                get {
                    bool rt = true;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YBitToInt64"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YBitToInt64(uint value) {
                Vector128<long> bitPosMask = Vector128Constants.MaskBitPosSerialRotate64;
                // Duplicate 64bit value
                Vector128<long> a = Vector128.Create((ulong)value).AsInt64();
                // Check bit.
                Vector128<long> hit = BitwiseAnd(a, bitPosMask);
                Vector128<long> rt = Equals(hit, bitPosMask);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YClamp_AcceleratedTypes"/>
            public static TypeCodeFlags YClamp_AcceleratedTypes {
                get {
                    return Max_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{float}, Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YClamp(Vector128<float> value, Vector128<float> amin, Vector128<float> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{double}, Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YClamp(Vector128<double> value, Vector128<double> amin, Vector128<double> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YClamp(Vector128<sbyte> value, Vector128<sbyte> amin, Vector128<sbyte> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YClamp(Vector128<byte> value, Vector128<byte> amin, Vector128<byte> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YClamp(Vector128<short> value, Vector128<short> amin, Vector128<short> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YClamp(Vector128<ushort> value, Vector128<ushort> amin, Vector128<ushort> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YClamp(Vector128<int> value, Vector128<int> amin, Vector128<int> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YClamp(Vector128<uint> value, Vector128<uint> amin, Vector128<uint> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YClamp(Vector128<long> value, Vector128<long> amin, Vector128<long> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YClamp(Vector128<ulong> value, Vector128<ulong> amin, Vector128<ulong> amax) {
                return Min(Max(amin, value), amax);
            }


            /// <inheritdoc cref="IWVectorTraits128.YCopySign_AcceleratedTypes"/>
            public static TypeCodeFlags YCopySign_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double;
                    rt |= (TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64); // & ShiftRightArithmetic_AcceleratedTypes
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YCopySign(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YCopySign(Vector128<float> value, Vector128<float> sign) {
                Vector128<float> signMask = Vector128Constants.Single_SignMask;
                Vector128<float> rt = ConditionalSelect(signMask, sign, value);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YCopySign(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YCopySign(Vector128<double> value, Vector128<double> sign) {
                Vector128<double> signMask = Vector128Constants.Double_SignMask;
                Vector128<double> rt = ConditionalSelect(signMask, sign, value);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YCopySign(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YCopySign(Vector128<sbyte> value, Vector128<sbyte> sign) {
                //Vector128<sbyte> t = ShiftRightArithmetic_Const(Sse2.Xor(value, sign), 7);
                Vector128<sbyte> t = Sse2.CompareGreaterThan(Vector128<sbyte>.Zero, Sse2.Xor(value, sign));
                Vector128<sbyte> rt = Sse2.Subtract(Sse2.Xor(value, t), t);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YCopySign(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YCopySign(Vector128<short> value, Vector128<short> sign) {
                Vector128<short> t = Sse2.ShiftRightArithmetic(Sse2.Xor(value, sign), 15);
                Vector128<short> rt = Sse2.Subtract(Sse2.Xor(value, t), t);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YCopySign(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YCopySign(Vector128<int> value, Vector128<int> sign) {
                Vector128<int> t = Sse2.ShiftRightArithmetic(Sse2.Xor(value, sign), 31);
                Vector128<int> rt = Sse2.Subtract(Sse2.Xor(value, t), t);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YCopySign(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YCopySign(Vector128<long> value, Vector128<long> sign) {
                //Vector128<long> t = ShiftRightArithmetic_Const(Sse2.Xor(value, sign), 63);
                //Vector128<long> t = GreaterThan(Vector128<long>.Zero, Sse2.Xor(value, sign));
                Vector128<long> t = YIsNegative(Sse2.Xor(value, sign));
                Vector128<long> rt = Sse2.Subtract(Sse2.Xor(value, t), t);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YMaxNumber_AcceleratedTypes"/>
            public static TypeCodeFlags YMaxNumber_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = YIsNaN_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YMaxNumber(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YMaxNumber(Vector128<float> left, Vector128<float> right) {
                Vector128<float> maskGreater = GreaterThan(left, right);
                Vector128<float> mask = BitwiseOr(maskGreater, YIsNaN(right).AsSingle());
                mask = BitwiseOr(mask, BitwiseAnd(Equals(left, right), YIsNegative(right).AsSingle()));
                Vector128<float> rt = ConditionalSelect(mask, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YMaxNumber(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YMaxNumber(Vector128<double> left, Vector128<double> right) {
                Vector128<double> maskGreater = GreaterThan(left, right);
                Vector128<double> mask = BitwiseOr(maskGreater, YIsNaN(right).AsDouble());
                // Console.WriteLine("GreaterThan:\t{0}", GreaterThan(left, right));
                // Console.WriteLine("YIsNaN:\t{0}", YIsNaN(right));
                // Console.WriteLine("mask2:\t{0}", mask);
                mask = BitwiseOr(mask, BitwiseAnd(Equals(left, right), YIsNegative(right).AsDouble()));
                //Console.WriteLine("mask3:\t{0}", mask);
                Vector128<double> rt = ConditionalSelect(mask, left, right);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YMinNumber_AcceleratedTypes"/>
            public static TypeCodeFlags YMinNumber_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = YIsNaN_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YMinNumber(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YMinNumber(Vector128<float> left, Vector128<float> right) {
                Vector128<float> mask = BitwiseOr(LessThan(left, right), YIsNaN(right).AsSingle());
                mask = BitwiseOr(mask, BitwiseAnd(Equals(left, right), YIsNegative(left).AsSingle()));
                Vector128<float> rt = ConditionalSelect(mask, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YMinNumber(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YMinNumber(Vector128<double> left, Vector128<double> right) {
                Vector128<double> mask = BitwiseOr(LessThan(left, right), YIsNaN(right).AsDouble());
                mask = BitwiseOr(mask, BitwiseAnd(Equals(left, right), YIsNegative(left).AsDouble()));
                Vector128<double> rt = ConditionalSelect(mask, left, right);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate_AcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturate_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate_FullAcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturate_FullAcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Int16 | TypeCodeFlags.UInt16;
                    if (Sse41.IsSupported) {
                        rt |= TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    }
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{short}, Vector128{short})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YNarrowSaturate(Vector128<short> lower, Vector128<short> upper) {
                Vector128<sbyte> rt = Sse2.PackSignedSaturate(lower, upper);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{ushort}, Vector128{ushort})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YNarrowSaturate(Vector128<ushort> lower, Vector128<ushort> upper) {
                // Vector128<ushort> amax = Vector128s<ushort>.VMaxByte;
                Vector128<ushort> amax = Vector128.Create((ushort)byte.MaxValue); // .NET5+ has better performance .
                Vector128<byte> rt = Sse2.PackUnsignedSaturate(Min(lower, amax).AsInt16(), Min(upper, amax).AsInt16());
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{int}, Vector128{int})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YNarrowSaturate(Vector128<int> lower, Vector128<int> upper) {
                Vector128<short> rt = Sse2.PackSignedSaturate(lower, upper);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{uint}, Vector128{uint})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YNarrowSaturate(Vector128<uint> lower, Vector128<uint> upper) {
                //Vector128<uint> amax = Vector128s<uint>.VMaxUInt16;
                Vector128<uint> amax = Vector128.Create((uint)ushort.MaxValue); // .NET5+ has better performance .
                Vector128<uint> l = Min(lower, amax);
                Vector128<uint> u = Min(upper, amax);
                Vector128<ushort> rt;
                if (Sse41.IsSupported) {
                    rt = Sse41.PackUnsignedSaturate(l.AsInt32(), u.AsInt32());
                } else {
                    rt = Narrow(l, u);
                }
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{long}, Vector128{long})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YNarrowSaturate(Vector128<long> lower, Vector128<long> upper) {
                Vector128<long> amin = Vector128Constants.Int64_VMinInt32;
                Vector128<long> amax = Vector128Constants.Int64_VMaxInt32;
                Vector128<long> l = YClamp(lower, amin, amax);
                Vector128<long> u = YClamp(upper, amin, amax);
                return Narrow(l, u);
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{ulong}, Vector128{ulong})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YNarrowSaturate(Vector128<ulong> lower, Vector128<ulong> upper) {
                //Vector128<ulong> amax = Vector128s<ulong>.VMaxUInt32;
                Vector128<ulong> amax = Vector128Constants.Int64_VMaxUInt32.AsUInt64();
                Vector128<ulong> l = Min(lower, amax);
                Vector128<ulong> u = Min(upper, amax);
                return Narrow(l, u);
            }


            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturateUnsigned_AcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturateUnsigned_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturateUnsigned_FullAcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturateUnsigned_FullAcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Int16;
                    if (Sse41.IsSupported) {
                        rt |= TypeCodeFlags.Int32;
                    }
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturateUnsigned(Vector128{short}, Vector128{short})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YNarrowSaturateUnsigned(Vector128<short> lower, Vector128<short> upper) {
                Vector128<byte> rt = Sse2.PackUnsignedSaturate(lower, upper);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturateUnsigned(Vector128{int}, Vector128{int})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YNarrowSaturateUnsigned(Vector128<int> lower, Vector128<int> upper) {
                Vector128<ushort> rt;
                if (Sse41.IsSupported) {
                    rt = Sse41.PackUnsignedSaturate(lower, upper);
                } else {
                    Vector128<int> amin = Vector128<int>.Zero;
                    Vector128<int> amax = Vector128.Create((int)ushort.MaxValue);
                    Vector128<uint> l = YClamp(lower, amin, amax).AsUInt32();
                    Vector128<uint> u = YClamp(upper, amin, amax).AsUInt32();
                    rt = Narrow(l, u);
                }
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturateUnsigned(Vector128{long}, Vector128{long})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YNarrowSaturateUnsigned(Vector128<long> lower, Vector128<long> upper) {
                Vector128<long> amin = Vector128<long>.Zero;
                Vector128<long> amax = Vector128Constants.Int64_VMaxUInt32;
                Vector128<ulong> l = YClamp(lower, amin, amax).AsUInt64();
                Vector128<ulong> u = YClamp(upper, amin, amax).AsUInt64();
                return Narrow(l, u);
            }


            /// <inheritdoc cref="IWVectorTraits128.YOrNot_AcceleratedTypes"/>
            public static TypeCodeFlags YOrNot_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YOrNot{T}(Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> YOrNot<T>(Vector128<T> left, Vector128<T> right) where T : struct {
                Vector128<T> right2 = OnesComplement(right);
                Vector128<T> rt = BitwiseOr(left, right2);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YRoundToEven_AcceleratedTypes"/>
            public static TypeCodeFlags YRoundToEven_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YRoundToEven(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YRoundToEven(Vector128<float> value) {
                if (Sse41.IsSupported) {
                    return Sse41.RoundToNearestInteger(value);
                } else {
                    return YRoundToEven_Add(value);
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YRoundToEven(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YRoundToEven(Vector128<double> value) {
                if (Sse41.IsSupported) {
                    return Sse41.RoundToNearestInteger(value);
                } else {
                    return YRoundToEven_Add(value);
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YRoundToEven(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YRoundToEven_Add(Vector128<float> value) {
                // [Single type] If (0<=x && x<pow(2,23)), `round_to_even(x) = x + pow(2,23) - pow(2,23)`. Next generalize this approach to all number ranges.
                Vector128<float> delta = Vector128.Create(ScalarConstants.SingleVal_2Pow23);
                Vector128<float> signMask = Vector128Constants.Single_SignMask;
                Vector128<float> valueAbs = Sse.AndNot(signMask, value); // It mean `Vector128.AndNot(value, signMask)`
                Vector128<float> signData = Sse.And(value, signMask);
                //Vector128<float> allowMask = LessThan(valueAbs, delta); // Allow is `(value[i] < pow(2,23) )`.
                Vector128<float> allowMask = Sse.CompareGreaterThan(delta, valueAbs); // Allow is `(value[i] < pow(2,23) )`.
                delta = Sse.Or(delta, signData);
                delta = Sse.And(delta, allowMask);
                Vector128<float> rt = Sse.Add(value, delta);
                rt = Sse.Subtract(rt, delta);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YRoundToEven(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YRoundToEven_Add(Vector128<double> value) {
                // [Double type] If (0<=x && x<pow(2,52)), `round_to_even(x) = x + pow(2,52) - pow(2,52)`. Next generalize this approach to all number ranges.
                Vector128<double> delta = Vector128.Create(ScalarConstants.DoubleVal_2Pow52);
                Vector128<double> signMask = Vector128Constants.Double_SignMask;
                Vector128<double> valueAbs = Sse2.AndNot(signMask, value); // It mean `Vector128.AndNot(value, signMask)`
                Vector128<double> signData = Sse2.And(value, signMask);
                //Vector128<double> allowMask = LessThan(valueAbs, delta); // Allow is `(value[i] < pow(2,52) )`.
                Vector128<double> allowMask = Sse2.CompareGreaterThan(delta, valueAbs); // Allow is `(value[i] < pow(2,52) )`.
                delta = Sse2.Or(delta, signData);
                delta = Sse2.And(delta, allowMask);
                Vector128<double> rt = Sse2.Add(value, delta);
                rt = Sse2.Subtract(rt, delta);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YRoundToZero_AcceleratedTypes"/>
            public static TypeCodeFlags YRoundToZero_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YRoundToZero(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YRoundToZero(Vector128<float> value) {
                if (Sse41.IsSupported) {
                    return Sse41.RoundToZero(value);
                } else {
                    return YRoundToZero_ClearBit(value);
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YRoundToZero(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YRoundToZero(Vector128<double> value) {
                if (Sse41.IsSupported) {
                    return Sse41.RoundToZero(value);
                } else {
                    return YRoundToZero_ClearBit(value);
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YRoundToZero(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YRoundToZero_ClearBit(Vector128<float> value) {
                // Float encode is `sign*(1.m)*pow(2,e) = sign*(1.m)*pow(2,eBias - BIAS)`. Single's BIAS is `127`.
                // If (e>=23): Has 0bit fractional part. The mask is `0`.
                // If (e==22): Has 1bit fractional part. The mask is `0x1`.
                // ...
                // If (e==1): Has 22bit fractional part. The mask is `0x003FFFFF`.
                // If (e==0): Has 23bit fractional part. The mask is `0x007FFFFF`.
                // If (e< 0): Need set to zero (0.0 / -0.0). The mask is `0x7FFFFFFF`.
                //
                // If (0<=e && e<=23): The mask is `pow(2,23-e) - 1`. So `RoundToZero(x) = x & ~mask`.
                //Constants.
                Vector128<float> exponentMask = Vector128.Create(ScalarConstants.SingleVal_ExponentMask);
                Vector128<float> one = Vector128.Create(1.0f);
                Vector128<float> rangeEnd = Vector128.Create(ScalarConstants.SingleVal_2Pow23); // Single value: pow(2, 23)
                Vector128<float> nonSignMask = Vector128Constants.Single_NonSignMask;
                //Operations.
                Vector128<float> valueExpData = Sse.And(value, exponentMask); // Get exponent field.
                Vector128<int> maskBegin = Sse.CompareGreaterThan(one, valueExpData).AsInt32(); // `1 > valueExpData[i] = pow(2,0) > pow(2,e)`, it mean `e<0`.
                valueExpData = Sse.Min(valueExpData, rangeEnd); // Clamp to `e<=23`.
                maskBegin = Sse2.And(maskBegin, nonSignMask.AsInt32()); // Keep sign flag.
                Vector128<int> expMinuend = Vector128.Create(ScalarConstants.SingleBit_Truncate_expMinuend); // Item is `(int)(127*2 + 23)<<23`. Binary is `0x8A800000`.
                Vector128<float> maskRawPow = Sse2.Subtract(expMinuend.AsUInt32(), valueExpData.AsUInt32()).AsSingle(); // If valueExpData is `(127 + e)<<23`, `expMinuend-valueExpData` exponent field will be `(127*2 + 23) - (127 + e) = 127 + (23-e)`
                maskRawPow = Sse.Subtract(maskRawPow, one); // The mask is `pow(2,23-e) - 1`.
                Vector128<int> mask = Sse.Add(maskRawPow, rangeEnd).AsInt32(); // Step 1 of ConvertToUInt32_Range23RoundToEven .
                mask = Sse2.Xor(mask, rangeEnd.AsInt32()); // mask = ConvertToUInt32_Range23RoundToEven(maskRawPow).AsInt32();
                mask = Sse2.Or(mask, maskBegin); // Choose (e<0).
                //writer.WriteLine(Vector128TextUtil.Format("The mask:\t{0}", mask));
                Vector128<float> rt = Sse.AndNot(mask.AsSingle(), value); // It mean `Vector128.AndNot(value, mask.AsSingle())`
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YRoundToZero(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YRoundToZero_ClearBit(Vector128<double> value) {
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
                Vector128<double> exponentMask = Vector128.Create(ScalarConstants.DoubleVal_ExponentMask);
                Vector128<double> one = Vector128.Create(1.0);
                Vector128<double> rangeEnd = Vector128.Create(ScalarConstants.DoubleVal_2Pow52); // Double value: pow(2, 52)
                Vector128<double> nonSignMask = Vector128Constants.Double_NonSignMask;
                //Operations.
                Vector128<double> valueExpData = Sse2.And(value, exponentMask); // Get exponent field.
                Vector128<long> maskBegin = Sse2.CompareGreaterThan(one, valueExpData).AsInt64(); // `1 > valueExpData[i] = pow(2,0) > pow(2,e)`, it mean `e<0`.
                valueExpData = Sse2.Min(valueExpData, rangeEnd); // Clamp to `e<=52`.
                maskBegin = Sse2.And(maskBegin, nonSignMask.AsInt64()); // Keep sign flag.
                Vector128<double> expMinuend = Vector128.Create(ScalarConstants.DoubleVal_Truncate_expMinuend); // Item is `(long)(1023*2 + 52)<<52`. Binary is `0x8320000000000000`.
                Vector128<double> maskRawPow = Sse2.Subtract(expMinuend.AsUInt64(), valueExpData.AsUInt64()).AsDouble(); // If valueExpData is `(1023 + e)<<52`, `expMinuend-valueExpData` exponent field will be `(1023*2 + 52) - (1023 + e) = 1023 + (52-e)`
                maskRawPow = Sse2.Subtract(maskRawPow, one); // The mask is `pow(2,52-e) - 1`.
                Vector128<long> mask = Sse2.Add(maskRawPow, rangeEnd).AsInt64(); // Step 1 of ConvertToUInt64_Range52RoundToEven .
                mask = Sse2.Xor(mask, rangeEnd.AsInt64()); // mask = ConvertToUInt64_Range52RoundToEven(maskRawPow).AsInt64();
                mask = Sse2.Or(mask, maskBegin); // Choose (e<0).
                //writer.WriteLine(Vector128TextUtil.Format("The mask:\t{0}", mask));
                Vector128<double> rt = Sse2.AndNot(mask.AsDouble(), value); // It mean `Vector128.AndNot(value, mask.AsDouble())`
                return rt;
            }

#endif // NETCOREAPP3_0_OR_GREATER
        }
    }
}
