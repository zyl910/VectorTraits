using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
#if NET8_0_OR_GREATER
using System.Runtime.Intrinsics.Wasm;
#endif // NET8_0_OR_GREATER

namespace Zyl.VectorTraits.Impl.AVector128 {
    using SuperStatics = WVectorTraits128Base.Statics;

    partial class WVectorTraits128PackedSimd {

        partial class Statics {

#if NET8_0_OR_GREATER

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
                Vector128<byte> a = Vector128.Create(value).AsByte();
                Vector128<byte> indices = Vector128Constants.YBitToByte_Shuffle_Indices;
                Vector128<byte> bitPosMask = Vector128Constants.MaskBitPosSerialRotate8;
                // Duplicate 8bit value to 64bit
                Vector128<byte> f = PackedSimd.Swizzle(a, indices);
                // Check bit.
                Vector128<byte> hit = BitwiseAnd(f, bitPosMask);
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
                Vector128<sbyte> t = PackedSimd.ShiftRightArithmetic(PackedSimd.Xor(value, sign), 7);
                Vector128<sbyte> rt = PackedSimd.Subtract(PackedSimd.Xor(value, t), t);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YCopySign(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YCopySign(Vector128<short> value, Vector128<short> sign) {
                Vector128<short> t = PackedSimd.ShiftRightArithmetic(PackedSimd.Xor(value, sign), 15);
                Vector128<short> rt = PackedSimd.Subtract(PackedSimd.Xor(value, t), t);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YCopySign(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YCopySign(Vector128<int> value, Vector128<int> sign) {
                Vector128<int> t = PackedSimd.ShiftRightArithmetic(PackedSimd.Xor(value, sign), 31);
                Vector128<int> rt = PackedSimd.Subtract(PackedSimd.Xor(value, t), t);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YCopySign(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YCopySign(Vector128<long> value, Vector128<long> sign) {
                Vector128<long> t = PackedSimd.ShiftRightArithmetic(PackedSimd.Xor(value, sign), 63);
                Vector128<long> rt = PackedSimd.Subtract(PackedSimd.Xor(value, t), t);
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

            /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{float}, Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YClamp_NoPseudo(Vector128<float> value, Vector128<float> amin, Vector128<float> amax) {
                return PackedSimd.Min(PackedSimd.Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{float}, Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YClamp_Pseudo(Vector128<float> value, Vector128<float> amin, Vector128<float> amax) {
                return PackedSimd.PseudoMin(PackedSimd.PseudoMax(amin, value), amax);
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


            /// <inheritdoc cref="IWVectorTraits128.YMaxNumber_AcceleratedTypes"/>
            public static TypeCodeFlags YMaxNumber_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YMaxNumber(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YMaxNumber(Vector128<float> left, Vector128<float> right) {
                Vector128<float> mask = BitwiseOr(GreaterThan(left, right), YIsNaN(right).AsSingle());
                mask = BitwiseOr(mask, BitwiseAnd(Equals(left, right), YIsNegative(right).AsSingle()));
                Vector128<float> rt = ConditionalSelect(mask, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YMaxNumber(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YMaxNumber(Vector128<double> left, Vector128<double> right) {
                Vector128<double> mask = BitwiseOr(GreaterThan(left, right), YIsNaN(right).AsDouble());
                mask = BitwiseOr(mask, BitwiseAnd(Equals(left, right), YIsNegative(right).AsDouble()));
                Vector128<double> rt = ConditionalSelect(mask, left, right);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YMinNumber_AcceleratedTypes"/>
            public static TypeCodeFlags YMinNumber_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double;
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
                    TypeCodeFlags rt = TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate_FullAcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturate_FullAcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{short}, Vector128{short})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YNarrowSaturate(Vector128<short> lower, Vector128<short> upper) {
                return PackedSimd.ConvertNarrowingSaturateSigned(lower, upper);
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{ushort}, Vector128{ushort})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YNarrowSaturate(Vector128<ushort> lower, Vector128<ushort> upper) {
                Vector128<ushort> amax = Vector128.Create((ushort)byte.MaxValue);
                Vector128<ushort> l = Min(lower, amax);
                Vector128<ushort> u = Min(upper, amax);
                Vector128<byte> rt = PackedSimd.ConvertNarrowingSaturateUnsigned(l.AsInt16(), u.AsInt16());
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{int}, Vector128{int})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YNarrowSaturate(Vector128<int> lower, Vector128<int> upper) {
                return PackedSimd.ConvertNarrowingSaturateSigned(lower, upper);
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{uint}, Vector128{uint})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YNarrowSaturate(Vector128<uint> lower, Vector128<uint> upper) {
                Vector128<uint> amax = Vector128.Create((uint)ushort.MaxValue);
                Vector128<uint> l = Min(lower, amax);
                Vector128<uint> u = Min(upper, amax);
                Vector128<ushort> rt = PackedSimd.ConvertNarrowingSaturateUnsigned(l.AsInt32(), u.AsInt32());
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
                Vector128<ulong> amax = Vector128Constants.Int64_VMaxUInt32.AsUInt64();
                Vector128<ulong> l = Min(lower, amax);
                Vector128<ulong> u = Min(upper, amax);
                return Narrow(l, u);
            }


            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturateUnsigned_AcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturateUnsigned_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Int16 | TypeCodeFlags.Int32;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturateUnsigned_FullAcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturateUnsigned_FullAcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Int16 | TypeCodeFlags.Int32;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturateUnsigned(Vector128{short}, Vector128{short})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YNarrowSaturateUnsigned(Vector128<short> lower, Vector128<short> upper) {
                return PackedSimd.ConvertNarrowingSaturateUnsigned(lower, upper);
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturateUnsigned(Vector128{int}, Vector128{int})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YNarrowSaturateUnsigned(Vector128<int> lower, Vector128<int> upper) {
                return PackedSimd.ConvertNarrowingSaturateUnsigned(lower, upper);
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
                return PackedSimd.RoundToNearest(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.YRoundToEven(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YRoundToEven(Vector128<double> value) {
                return PackedSimd.RoundToNearest(value);
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
                return PackedSimd.Truncate(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.YRoundToZero(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YRoundToZero(Vector128<double> value) {
                return PackedSimd.Truncate(value);
            }


#endif // NET8_0_OR_GREATER
        }
    }
}
