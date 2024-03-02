using System;
using System.Collections.Generic;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
using System.Runtime.CompilerServices;
#endif
#if NET5_0_OR_GREATER
using System.Runtime.Intrinsics.Arm;
#endif // NET5_0_OR_GREATER

namespace Zyl.VectorTraits.Impl.AVector128 {
    using SuperStatics = WVectorTraits128AdvSimd.Statics;

    partial class WVectorTraits128AdvSimdB64 {

        partial class Statics {

#if NET5_0_OR_GREATER

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
                Vector128<byte> f = YShuffleKernel(a, indices);
                // Check bit.
                Vector128<byte> hit = SuperStatics.BitwiseAnd(f, bitPosMask);
                Vector128<byte> rt = SuperStatics.OnesComplement(SuperStatics.Equals(hit, Vector128<byte>.Zero));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YClamp_AcceleratedTypes"/>
            public static TypeCodeFlags YClamp_AcceleratedTypes {
                get {
                    return Max_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{double}, Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YClamp(Vector128<double> value, Vector128<double> amin, Vector128<double> amax) {
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
                    TypeCodeFlags rt = YIsNaN_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YMaxNumber(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YMaxNumber(Vector128<double> left, Vector128<double> right) {
                Vector128<double> mask = SuperStatics.BitwiseOr(GreaterThan(left, right), YIsNaN(right).AsDouble());
                mask = SuperStatics.BitwiseOr(mask, SuperStatics.BitwiseAnd(Equals(left, right), YIsNegative(right).AsDouble()));
                Vector128<double> rt = SuperStatics.ConditionalSelect(mask, left, right);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YMinNumber_AcceleratedTypes"/>
            public static TypeCodeFlags YMinNumber_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = YIsNaN_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YMinNumber(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YMinNumber(Vector128<double> left, Vector128<double> right) {
                Vector128<double> mask = SuperStatics.BitwiseOr(LessThan(left, right), YIsNaN(right).AsDouble());
                mask = SuperStatics.BitwiseOr(mask, SuperStatics.BitwiseAnd(Equals(left, right), YIsNegative(left).AsDouble()));
                Vector128<double> rt = SuperStatics.ConditionalSelect(mask, left, right);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YRoundToEven_AcceleratedTypes"/>
            public static TypeCodeFlags YRoundToEven_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YRoundToEven(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YRoundToEven(Vector128<double> value) {
                return AdvSimd.Arm64.RoundToNearest(value);
            }


            /// <inheritdoc cref="IWVectorTraits128.YRoundToZero_AcceleratedTypes"/>
            public static TypeCodeFlags YRoundToZero_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YRoundToZero(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YRoundToZero(Vector128<double> value) {
                return AdvSimd.Arm64.RoundToZero(value);
            }


#endif // NET5_0_OR_GREATER
        }
    }
}
