using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
#if NET5_0_OR_GREATER
using System.Runtime.Intrinsics.Arm;
#endif // NET5_0_OR_GREATER

namespace Zyl.VectorTraits.Impl.AVector128 {
    using SuperStatics = WVectorTraits128Base.Statics;

    partial class WVectorTraits128AdvSimd {

        partial class Statics {

#if NET5_0_OR_GREATER

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
                    TypeCodeFlags rt = TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{short}, Vector128{short})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YNarrowSaturate(Vector128<short> lower, Vector128<short> upper) {
                return AdvSimd.ExtractNarrowingSaturateUpper(AdvSimd.ExtractNarrowingSaturateLower(lower), upper);
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{ushort}, Vector128{ushort})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YNarrowSaturate(Vector128<ushort> lower, Vector128<ushort> upper) {
                return AdvSimd.ExtractNarrowingSaturateUpper(AdvSimd.ExtractNarrowingSaturateLower(lower), upper);
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{int}, Vector128{int})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YNarrowSaturate(Vector128<int> lower, Vector128<int> upper) {
                return AdvSimd.ExtractNarrowingSaturateUpper(AdvSimd.ExtractNarrowingSaturateLower(lower), upper);
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{uint}, Vector128{uint})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YNarrowSaturate(Vector128<uint> lower, Vector128<uint> upper) {
                return AdvSimd.ExtractNarrowingSaturateUpper(AdvSimd.ExtractNarrowingSaturateLower(lower), upper);
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{long}, Vector128{long})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YNarrowSaturate(Vector128<long> lower, Vector128<long> upper) {
                return AdvSimd.ExtractNarrowingSaturateUpper(AdvSimd.ExtractNarrowingSaturateLower(lower), upper);
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{ulong}, Vector128{ulong})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YNarrowSaturate(Vector128<ulong> lower, Vector128<ulong> upper) {
                return AdvSimd.ExtractNarrowingSaturateUpper(AdvSimd.ExtractNarrowingSaturateLower(lower), upper);
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
                    TypeCodeFlags rt = TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturateUnsigned(Vector128{short}, Vector128{short})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YNarrowSaturateUnsigned(Vector128<short> lower, Vector128<short> upper) {
                return AdvSimd.ExtractNarrowingSaturateUnsignedUpper(AdvSimd.ExtractNarrowingSaturateUnsignedLower(lower), upper);
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturateUnsigned(Vector128{int}, Vector128{int})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YNarrowSaturateUnsigned(Vector128<int> lower, Vector128<int> upper) {
                return AdvSimd.ExtractNarrowingSaturateUnsignedUpper(AdvSimd.ExtractNarrowingSaturateUnsignedLower(lower), upper);
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturateUnsigned(Vector128{long}, Vector128{long})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YNarrowSaturateUnsigned(Vector128<long> lower, Vector128<long> upper) {
                return AdvSimd.ExtractNarrowingSaturateUnsignedUpper(AdvSimd.ExtractNarrowingSaturateUnsignedLower(lower), upper);
            }


            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleInsert_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = SuperStatics.YShuffleInsert_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{float}, Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleInsert(Vector128<float> back, Vector128<float> vector, Vector128<int> indices) {
                return YShuffleInsert(back.AsUInt32(), vector.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{double}, Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleInsert(Vector128<double> back, Vector128<double> vector, Vector128<long> indices) {
                return YShuffleInsert(back.AsUInt64(), vector.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleInsert(Vector128<sbyte> back, Vector128<sbyte> vector, Vector128<sbyte> indices) {
                return YShuffleInsert(back.AsByte(), vector.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleInsert(Vector128<byte> back, Vector128<byte> vector, Vector128<byte> indices) {
                Vector128<byte> mask = AdvSimd.CompareGreaterThan(Vector128.Create((byte)16), indices); // (0<=i && i<16)
                Vector128<byte> raw = YShuffleKernel(vector, indices);
                Vector128<byte> rt = ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleInsert(Vector128<short> back, Vector128<short> vector, Vector128<short> indices) {
                return YShuffleInsert(back.AsUInt16(), vector.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleInsert(Vector128<ushort> back, Vector128<ushort> vector, Vector128<ushort> indices) {
                Vector128<ushort> mask = AdvSimd.CompareGreaterThan(Vector128.Create((ushort)8), indices); // (0<=i && i<8)
                Vector128<ushort> raw = YShuffleKernel(vector, indices);
                Vector128<ushort> rt = ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleInsert(Vector128<int> back, Vector128<int> vector, Vector128<int> indices) {
                return YShuffleInsert(back.AsUInt32(), vector.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleInsert(Vector128<uint> back, Vector128<uint> vector, Vector128<uint> indices) {
                Vector128<uint> mask = AdvSimd.CompareGreaterThan(Vector128.Create((uint)4), indices); // (0<=i && i<4)
                Vector128<uint> raw = YShuffleKernel(vector, indices);
                Vector128<uint> rt = ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleInsert(Vector128<long> back, Vector128<long> vector, Vector128<long> indices) {
                return YShuffleInsert(back.AsUInt64(), vector.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleInsert(Vector128<ulong> back, Vector128<ulong> vector, Vector128<ulong> indices) {
                Vector128<ulong> mask = GreaterThan(Vector128.Create((ulong)2), indices); // (0<=i && i<2)
                Vector128<ulong> raw = YShuffleKernel(vector, indices);
                Vector128<ulong> rt = ConditionalSelect(mask, raw, back);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleKernel_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = SuperStatics.YShuffleKernel_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleKernel(Vector128<float> vector, Vector128<int> indices) {
                return YShuffleKernel(vector.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleKernel(Vector128<double> vector, Vector128<long> indices) {
                return YShuffleKernel(vector.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleKernel(Vector128<sbyte> vector, Vector128<sbyte> indices) {
                return YShuffleKernel(vector.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleKernel(Vector128<byte> vector, Vector128<byte> indices) {
                //return AdvSimd.VectorTableLookup(vector, indices);
                return SuperStatics.YShuffleKernel(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleKernel(Vector128<short> vector, Vector128<short> indices) {
                return YShuffleKernel(vector.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleKernel(Vector128<ushort> vector, Vector128<ushort> indices) {
                Vector128<byte> indices2 = AdvSimd.Add(Multiply(indices, Vector128Constants.Shuffle_UInt16_Multiplier).AsByte(), Vector128Constants.Shuffle_UInt16_ByteOffset);
                return YShuffleKernel(vector.AsByte(), indices2).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleKernel(Vector128<int> vector, Vector128<int> indices) {
                return SuperStatics.YShuffleKernel(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleKernel(Vector128<uint> vector, Vector128<uint> indices) {
                return SuperStatics.YShuffleKernel(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleKernel(Vector128<long> vector, Vector128<long> indices) {
                return YShuffleKernel(vector.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleKernel(Vector128<ulong> vector, Vector128<ulong> indices) {
                return SuperStatics.YShuffleKernel(vector, indices);
            }


#endif // NET5_0_OR_GREATER
        }
    }
}
