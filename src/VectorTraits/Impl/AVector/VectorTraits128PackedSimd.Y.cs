using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Numerics;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using System.Text;
using Zyl.VectorTraits.Extensions;
using Zyl.VectorTraits.Extensions.SameW;
using Zyl.VectorTraits.Impl.AVector128;

namespace Zyl.VectorTraits.Impl.AVector {
    using WStatics = WVectorTraits128PackedSimd.Statics;
    using BaseStatics = VectorTraitsBase.Statics;

    partial class VectorTraits128PackedSimd {
#if NET8_0_OR_GREATER
        partial class Statics {

            /// <inheritdoc cref="IVectorTraits.YBitToByte_IsAccelerated"/>
            public static bool YBitToByte_IsAccelerated {
                get {
                    return WStatics.YBitToByte_IsAccelerated;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YBitToByte"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YBitToByte(ulong value) {
                return WStatics.YBitToByte((uint)value).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YBitToInt16_IsAccelerated"/>
            public static bool YBitToInt16_IsAccelerated {
                get {
                    return WStatics.YBitToInt16_IsAccelerated;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YBitToInt16"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YBitToInt16(ulong value) {
                return WStatics.YBitToInt16((uint)value).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YBitToInt32_IsAccelerated"/>
            public static bool YBitToInt32_IsAccelerated {
                get {
                    return WStatics.YBitToInt32_IsAccelerated;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YBitToInt32"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YBitToInt32(ulong value) {
                return WStatics.YBitToInt32((uint)value).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YBitToInt64_IsAccelerated"/>
            public static bool YBitToInt64_IsAccelerated {
                get {
                    return WStatics.YBitToInt64_IsAccelerated;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YBitToInt64"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YBitToInt64(ulong value) {
                return WStatics.YBitToInt64((uint)value).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YClamp_AcceleratedTypes"/>
            public static TypeCodeFlags YClamp_AcceleratedTypes {
                get {
                    return WStatics.YClamp_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YClamp(Vector{float}, Vector{float}, Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YClamp(Vector<float> value, Vector<float> amin, Vector<float> amax) {
                return WStatics.YClamp(value.AsVector128(), amin.AsVector128(), amax.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YClamp(Vector{double}, Vector{double}, Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YClamp(Vector<double> value, Vector<double> amin, Vector<double> amax) {
                return WStatics.YClamp(value.AsVector128(), amin.AsVector128(), amax.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YClamp(Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YClamp(Vector<sbyte> value, Vector<sbyte> amin, Vector<sbyte> amax) {
                return WStatics.YClamp(value.AsVector128(), amin.AsVector128(), amax.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YClamp(Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YClamp(Vector<byte> value, Vector<byte> amin, Vector<byte> amax) {
                return WStatics.YClamp(value.AsVector128(), amin.AsVector128(), amax.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YClamp(Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YClamp(Vector<short> value, Vector<short> amin, Vector<short> amax) {
                return WStatics.YClamp(value.AsVector128(), amin.AsVector128(), amax.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YClamp(Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YClamp(Vector<ushort> value, Vector<ushort> amin, Vector<ushort> amax) {
                return WStatics.YClamp(value.AsVector128(), amin.AsVector128(), amax.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YClamp(Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YClamp(Vector<int> value, Vector<int> amin, Vector<int> amax) {
                return WStatics.YClamp(value.AsVector128(), amin.AsVector128(), amax.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YClamp(Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YClamp(Vector<uint> value, Vector<uint> amin, Vector<uint> amax) {
                return WStatics.YClamp(value.AsVector128(), amin.AsVector128(), amax.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YClamp(Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YClamp(Vector<long> value, Vector<long> amin, Vector<long> amax) {
                return WStatics.YClamp(value.AsVector128(), amin.AsVector128(), amax.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YClamp(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YClamp(Vector<ulong> value, Vector<ulong> amin, Vector<ulong> amax) {
                return WStatics.YClamp(value.AsVector128(), amin.AsVector128(), amax.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YCopySign_AcceleratedTypes"/>
            public static TypeCodeFlags YCopySign_AcceleratedTypes {
                get {
                    return WStatics.YCopySign_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YCopySign(Vector{float}, Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YCopySign(Vector<float> value, Vector<float> sign) {
                return WStatics.YCopySign(value.AsVector128(), sign.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YCopySign(Vector{double}, Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YCopySign(Vector<double> value, Vector<double> sign) {
                return WStatics.YCopySign(value.AsVector128(), sign.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YCopySign(Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YCopySign(Vector<sbyte> value, Vector<sbyte> sign) {
                return WStatics.YCopySign(value.AsVector128(), sign.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YCopySign(Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YCopySign(Vector<short> value, Vector<short> sign) {
                return WStatics.YCopySign(value.AsVector128(), sign.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YCopySign(Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YCopySign(Vector<int> value, Vector<int> sign) {
                return WStatics.YCopySign(value.AsVector128(), sign.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YCopySign(Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YCopySign(Vector<long> value, Vector<long> sign) {
                return WStatics.YCopySign(value.AsVector128(), sign.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YMaxNumber_AcceleratedTypes"/>
            public static TypeCodeFlags YMaxNumber_AcceleratedTypes {
                get {
                    return WStatics.YMaxNumber_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YMaxNumber(Vector{float}, Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YMaxNumber(Vector<float> left, Vector<float> right) {
                return WStatics.YMaxNumber(left.AsVector128(), right.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YMaxNumber(Vector{double}, Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YMaxNumber(Vector<double> left, Vector<double> right) {
                return WStatics.YMaxNumber(left.AsVector128(), right.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YMinNumber_AcceleratedTypes"/>
            public static TypeCodeFlags YMinNumber_AcceleratedTypes {
                get {
                    return WStatics.YMinNumber_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YMinNumber(Vector{float}, Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YMinNumber(Vector<float> left, Vector<float> right) {
                return WStatics.YMinNumber(left.AsVector128(), right.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YMinNumber(Vector{double}, Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YMinNumber(Vector<double> left, Vector<double> right) {
                return WStatics.YMinNumber(left.AsVector128(), right.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YNarrowSaturate_AcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturate_AcceleratedTypes {
                get {
                    return WStatics.YNarrowSaturate_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturate_FullAcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturate_FullAcceleratedTypes {
                get {
                    return WStatics.YNarrowSaturate_FullAcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{short}, Vector{short})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YNarrowSaturate(Vector<short> lower, Vector<short> upper) {
                return WStatics.YNarrowSaturate(lower.AsVector128(), upper.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{ushort}, Vector{ushort})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YNarrowSaturate(Vector<ushort> lower, Vector<ushort> upper) {
                return WStatics.YNarrowSaturate(lower.AsVector128(), upper.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{int}, Vector{int})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YNarrowSaturate(Vector<int> lower, Vector<int> upper) {
                return WStatics.YNarrowSaturate(lower.AsVector128(), upper.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{uint}, Vector{uint})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YNarrowSaturate(Vector<uint> lower, Vector<uint> upper) {
                return WStatics.YNarrowSaturate(lower.AsVector128(), upper.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{long}, Vector{long})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YNarrowSaturate(Vector<long> lower, Vector<long> upper) {
                return WStatics.YNarrowSaturate(lower.AsVector128(), upper.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{ulong}, Vector{ulong})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YNarrowSaturate(Vector<ulong> lower, Vector<ulong> upper) {
                return WStatics.YNarrowSaturate(lower.AsVector128(), upper.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned_AcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturateUnsigned_AcceleratedTypes {
                get {
                    return WStatics.YNarrowSaturateUnsigned_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned_FullAcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturateUnsigned_FullAcceleratedTypes {
                get {
                    return WStatics.YNarrowSaturateUnsigned_FullAcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned(Vector{short}, Vector{short})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YNarrowSaturateUnsigned(Vector<short> lower, Vector<short> upper) {
                return WStatics.YNarrowSaturateUnsigned(lower.AsVector128(), upper.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned(Vector{int}, Vector{int})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YNarrowSaturateUnsigned(Vector<int> lower, Vector<int> upper) {
                return WStatics.YNarrowSaturateUnsigned(lower.AsVector128(), upper.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned(Vector{long}, Vector{long})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YNarrowSaturateUnsigned(Vector<long> lower, Vector<long> upper) {
                return WStatics.YNarrowSaturateUnsigned(lower.AsVector128(), upper.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YOrNot_AcceleratedTypes"/>
            public static TypeCodeFlags YOrNot_AcceleratedTypes {
                get {
                    return WStatics.YOrNot_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YOrNot{T}(Vector{T}, Vector{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<T> YOrNot<T>(Vector<T> left, Vector<T> right) where T : struct {
                return WStatics.YOrNot(left.AsVector128(), right.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YRoundToEven_AcceleratedTypes"/>
            public static TypeCodeFlags YRoundToEven_AcceleratedTypes {
                get {
                    return WStatics.YRoundToEven_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YRoundToEven(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YRoundToEven(Vector<float> value) {
                return WStatics.YRoundToEven(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YRoundToEven(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YRoundToEven(Vector<double> value) {
                return WStatics.YRoundToEven(value.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YRoundToZero_AcceleratedTypes"/>
            public static TypeCodeFlags YRoundToZero_AcceleratedTypes {
                get {
                    return WStatics.YRoundToZero_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YRoundToZero(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YRoundToZero(Vector<float> value) {
                return WStatics.YRoundToZero(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YRoundToZero(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YRoundToZero(Vector<double> value) {
                return WStatics.YRoundToZero(value.AsVector128()).AsVector();
            }

        }
#endif // NET8_0_OR_GREATER
    }
}
