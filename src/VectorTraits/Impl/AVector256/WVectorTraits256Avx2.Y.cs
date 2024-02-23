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

            /// <inheritdoc cref="IWVectorTraits256.YBitToByte_IsAccelerated"/>
            public static bool YBitToByte_IsAccelerated {
                get {
                    bool rt = true;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YBitToByte"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YBitToByte(uint value) {
                Vector256<byte> a = Vector256.Create(value).AsByte();
                Vector256<byte> indices = Vector256Constants.YBitToByte_Shuffle_Indices;
                Vector256<byte> bitPosMask = Vector256Constants.MaskBitPosSerialRotate8;
                // Duplicate 8bit value to 64bit
                Vector256<byte> f = Avx2.Shuffle(a, indices);
                // Check bit.
                Vector256<byte> hit = BitwiseAnd(f, bitPosMask);
                Vector256<byte> rt = OnesComplement(Equals(hit, Vector256<byte>.Zero));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.YBitToInt16_IsAccelerated"/>
            public static bool YBitToInt16_IsAccelerated {
                get {
                    bool rt = true;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YBitToInt16"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YBitToInt16(uint value) {
                Vector256<short> bitPosMask = Vector256Constants.MaskBitPosSerialRotate16;
                // Duplicate 16bit value
                Vector256<short> a = Vector256.Create((ushort)value).AsInt16();
                // Check bit.
                Vector256<short> hit = BitwiseAnd(a, bitPosMask);
                Vector256<short> rt = OnesComplement(Equals(hit, Vector256<short>.Zero));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.YBitToInt32_IsAccelerated"/>
            public static bool YBitToInt32_IsAccelerated {
                get {
                    bool rt = true;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YBitToInt32"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YBitToInt32(uint value) {
                Vector256<int> bitPosMask = Vector256Constants.MaskBitPosSerialRotate32;
                // Duplicate 32bit value
                Vector256<int> a = Vector256.Create((uint)value).AsInt32();
                // Check bit.
                Vector256<int> hit = BitwiseAnd(a, bitPosMask);
                Vector256<int> rt = OnesComplement(Equals(hit, Vector256<int>.Zero));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.YBitToInt64_IsAccelerated"/>
            public static bool YBitToInt64_IsAccelerated {
                get {
                    bool rt = true;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YBitToInt64"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YBitToInt64(uint value) {
                Vector256<long> bitPosMask = Vector256Constants.MaskBitPosSerialRotate64;
                // Duplicate 64bit value
                Vector256<long> a = Vector256.Create((ulong)value).AsInt64();
                // Check bit.
                Vector256<long> hit = BitwiseAnd(a, bitPosMask);
                Vector256<long> rt = OnesComplement(Equals(hit, Vector256<long>.Zero));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.YClamp_AcceleratedTypes"/>
            public static TypeCodeFlags YClamp_AcceleratedTypes {
                get {
                    return Max_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{float}, Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YClamp(Vector256<float> value, Vector256<float> amin, Vector256<float> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{double}, Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YClamp(Vector256<double> value, Vector256<double> amin, Vector256<double> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YClamp(Vector256<sbyte> value, Vector256<sbyte> amin, Vector256<sbyte> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YClamp(Vector256<byte> value, Vector256<byte> amin, Vector256<byte> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{short}, Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YClamp(Vector256<short> value, Vector256<short> amin, Vector256<short> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YClamp(Vector256<ushort> value, Vector256<ushort> amin, Vector256<ushort> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{int}, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YClamp(Vector256<int> value, Vector256<int> amin, Vector256<int> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YClamp(Vector256<uint> value, Vector256<uint> amin, Vector256<uint> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{long}, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YClamp(Vector256<long> value, Vector256<long> amin, Vector256<long> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YClamp(Vector256<ulong> value, Vector256<ulong> amin, Vector256<ulong> amax) {
                return Min(Max(amin, value), amax);
            }


            /// <inheritdoc cref="IWVectorTraits256.YCopySign_AcceleratedTypes"/>
            public static TypeCodeFlags YCopySign_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double;
                    rt |= (TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64) & ShiftRightArithmetic_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YCopySign(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YCopySign(Vector256<float> value, Vector256<float> sign) {
                Vector256<float> signMask = Vector256Constants.Single_SignMask;
                Vector256<float> rt = ConditionalSelect(signMask, sign, value);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YCopySign(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YCopySign(Vector256<double> value, Vector256<double> sign) {
                Vector256<double> signMask = Vector256Constants.Double_SignMask;
                Vector256<double> rt = ConditionalSelect(signMask, sign, value);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YCopySign(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YCopySign(Vector256<sbyte> value, Vector256<sbyte> sign) {
                Vector256<sbyte> t = ShiftRightArithmetic_Const(Avx2.Xor(value, sign), 7);
                Vector256<sbyte> rt = Avx2.Subtract(Avx2.Xor(value, t), t);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YCopySign(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YCopySign(Vector256<short> value, Vector256<short> sign) {
                Vector256<short> t = Avx2.ShiftRightArithmetic(Avx2.Xor(value, sign), 15);
                Vector256<short> rt = Avx2.Subtract(Avx2.Xor(value, t), t);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YCopySign(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YCopySign(Vector256<int> value, Vector256<int> sign) {
                Vector256<int> t = Avx2.ShiftRightArithmetic(Avx2.Xor(value, sign), 31);
                Vector256<int> rt = Avx2.Subtract(Avx2.Xor(value, t), t);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YCopySign(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YCopySign(Vector256<long> value, Vector256<long> sign) {
                Vector256<long> t = ShiftRightArithmetic_Const(Avx2.Xor(value, sign), 63);
                Vector256<long> rt = Avx2.Subtract(Avx2.Xor(value, t), t);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate_AcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturate_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate_FullAcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturate_FullAcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate(Vector256{short}, Vector256{short})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YNarrowSaturate(Vector256<short> lower, Vector256<short> upper) {
                Vector256<sbyte> raw = Avx2.PackSignedSaturate(lower, upper); // bit64(x, z, y, w)
                Vector256<sbyte> rt = Avx2.Permute4x64(raw.AsUInt64(), (byte)ShuffleControlG4.XZYW).AsSByte(); // Shuffle(bit64(x, z, y, w), XZYW) := bit64(x, y, z, w)
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate(Vector256{ushort}, Vector256{ushort})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YNarrowSaturate(Vector256<ushort> lower, Vector256<ushort> upper) {
                // Vector256<ushort> amax = Vector256s<ushort>.VMaxByte;
                Vector256<ushort> amax = Vector256.Create((ushort)byte.MaxValue); // .NET5+ has better performance .
                Vector256<byte> raw = Avx2.PackUnsignedSaturate(Avx2.Min(lower, amax).AsInt16(), Avx2.Min(upper, amax).AsInt16()); // bit64(x, z, y, w)
                Vector256<byte> rt = Avx2.Permute4x64(raw.AsUInt64(), (byte)ShuffleControlG4.XZYW).AsByte(); // Shuffle(bit64(x, z, y, w), XZYW) := bit64(x, y, z, w)
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate(Vector256{int}, Vector256{int})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YNarrowSaturate(Vector256<int> lower, Vector256<int> upper) {
                Vector256<short> raw = Avx2.PackSignedSaturate(lower, upper); // bit64(x, z, y, w)
                Vector256<short> rt = Avx2.Permute4x64(raw.AsUInt64(), (byte)ShuffleControlG4.XZYW).AsInt16(); // Shuffle(bit64(x, z, y, w), XZYW) := bit64(x, y, z, w)
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate(Vector256{uint}, Vector256{uint})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YNarrowSaturate(Vector256<uint> lower, Vector256<uint> upper) {
                //Vector256<uint> amax = Vector256s<uint>.VMaxUInt16;
                Vector256<uint> amax = Vector256.Create((uint)ushort.MaxValue); // .NET5+ has better performance .
                Vector256<ushort> raw = Avx2.PackUnsignedSaturate(Avx2.Min(lower, amax).AsInt32(), Avx2.Min(upper, amax).AsInt32()); // bit64(x, z, y, w)
                Vector256<ushort> rt = Avx2.Permute4x64(raw.AsUInt64(), (byte)ShuffleControlG4.XZYW).AsUInt16(); // ShuffleG4(bit64(x, z, y, w), XZYW) := bit64(x, y, z, w)
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate(Vector256{long}, Vector256{long})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YNarrowSaturate(Vector256<long> lower, Vector256<long> upper) {
                //Vector256<long> amin = Vector256s<long>.VMinInt32;
                //Vector256<long> amax = Vector256s<long>.VMaxInt32;
                Vector256<long> amin = Vector256Constants.Int64_VMinInt32;
                Vector256<long> amax = Vector256Constants.Int64_VMaxInt32;
                Vector256<long> l = YClamp(lower, amin, amax);
                Vector256<long> u = YClamp(upper, amin, amax);
                return Narrow(l, u);
            }

            /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate(Vector256{ulong}, Vector256{ulong})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YNarrowSaturate(Vector256<ulong> lower, Vector256<ulong> upper) {
                //Vector256<ulong> amax = Vector256s<ulong>.VMaxUInt32;
                Vector256<ulong> amax = Vector256Constants.Int64_VMaxUInt32.AsUInt64();
                Vector256<ulong> l = Min(lower, amax);
                Vector256<ulong> u = Min(upper, amax);
                return Narrow(l, u);
            }


            /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturateUnsigned_AcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturateUnsigned_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturateUnsigned_FullAcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturateUnsigned_FullAcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Int16 | TypeCodeFlags.Int32;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturateUnsigned(Vector256{short}, Vector256{short})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YNarrowSaturateUnsigned(Vector256<short> lower, Vector256<short> upper) {
                Vector256<byte> raw = Avx2.PackUnsignedSaturate(lower, upper); // bit64(x, z, y, w)
                Vector256<byte> rt = Avx2.Permute4x64(raw.AsUInt64(), (byte)ShuffleControlG4.XZYW).AsByte(); // Shuffle(bit64(x, z, y, w), XZYW) := bit64(x, y, z, w)
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturateUnsigned(Vector256{int}, Vector256{int})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YNarrowSaturateUnsigned(Vector256<int> lower, Vector256<int> upper) {
                Vector256<ushort> raw = Avx2.PackUnsignedSaturate(lower, upper); // bit64(x, z, y, w)
                Vector256<ushort> rt = Avx2.Permute4x64(raw.AsUInt64(), (byte)ShuffleControlG4.XZYW).AsUInt16(); // Shuffle(bit64(x, z, y, w), XZYW) := bit64(x, y, z, w)
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturateUnsigned(Vector256{long}, Vector256{long})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YNarrowSaturateUnsigned(Vector256<long> lower, Vector256<long> upper) {
                Vector256<long> amin = Vector256<long>.Zero;
                //Vector256<long> amax = Vector256s<long>.VMaxUInt32;
                Vector256<long> amax = Vector256Constants.Int64_VMaxUInt32;
                Vector256<ulong> l = YClamp(lower, amin, amax).AsUInt64();
                Vector256<ulong> u = YClamp(upper, amin, amax).AsUInt64();
                return Narrow(l, u);
            }


            /// <inheritdoc cref="IWVectorTraits256.YOrNot_AcceleratedTypes"/>
            public static TypeCodeFlags YOrNot_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YOrNot{T}(Vector256{T}, Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<T> YOrNot<T>(Vector256<T> left, Vector256<T> right) where T : struct {
                Vector256<T> right2 = OnesComplement(right);
                Vector256<T> rt = BitwiseOr(left, right2);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.YRoundToEven_AcceleratedTypes"/>
            public static TypeCodeFlags YRoundToEven_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YRoundToEven(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YRoundToEven(Vector256<float> value) {
                return Avx.RoundToNearestInteger(value);
            }

            /// <inheritdoc cref="IWVectorTraits256.YRoundToEven(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YRoundToEven(Vector256<double> value) {
                return Avx.RoundToNearestInteger(value);
            }


            /// <inheritdoc cref="IWVectorTraits256.YRoundToZero_AcceleratedTypes"/>
            public static TypeCodeFlags YRoundToZero_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YRoundToZero(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YRoundToZero(Vector256<float> value) {
                return Avx.RoundToZero(value);
            }

            /// <inheritdoc cref="IWVectorTraits256.YRoundToZero(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YRoundToZero(Vector256<double> value) {
                return Avx.RoundToZero(value);
            }


#endif // NETCOREAPP3_0_OR_GREATER
        }
    }
}
