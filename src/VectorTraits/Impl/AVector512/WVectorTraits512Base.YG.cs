#if NET7_0_OR_GREATER
#define BCL_HAS_SHUFFLE
#define VECTOR_HAS_METHOD
#endif // NET7_0_OR_GREATER

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Text;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Collections;
using Zyl.VectorTraits.ExTypes;
using Zyl.VectorTraits.Impl.AVector256;
using Zyl.VectorTraits.Impl.Util;

namespace Zyl.VectorTraits.Impl.AVector512 {
    using ShorterStatics = WVectorTraits256Base.Statics;

    partial class WVectorTraits512Base {

        partial class Statics {

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup3_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup1ToGroup3_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt = TypeCodeFlags.Byte | TypeCodeFlags.SByte;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup3(Vector512{float}, out Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup1ToGroup3(Vector512<float> x, out Vector512<float> result1, out Vector512<float> result2) {
                var d0 = YGroup1ToGroup3(x.AsUInt32(), out var d1, out var d2);
                result1 = d1.AsSingle();
                result2 = d2.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup3(Vector512{double}, out Vector512{double}, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup1ToGroup3(Vector512<double> x, out Vector512<double> result1, out Vector512<double> result2) {
                var d0 = YGroup1ToGroup3(x.AsUInt64(), out var d1, out var d2);
                result1 = d1.AsDouble();
                result2 = d2.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup3(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup1ToGroup3(Vector512<sbyte> x, out Vector512<sbyte> result1, out Vector512<sbyte> result2) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup1ToGroup3_Zip(x, out result1, out result2);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup1ToGroup3_Basic(x, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup3(Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup1ToGroup3(Vector512<byte> x, out Vector512<byte> result1, out Vector512<byte> result2) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup1ToGroup3_Zip(x, out result1, out result2);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup1ToGroup3_Basic(x, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup3(Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup1ToGroup3(Vector512<short> x, out Vector512<short> result1, out Vector512<short> result2) {
                return YGroup1ToGroup3_Basic(x, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup3(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup1ToGroup3(Vector512<ushort> x, out Vector512<ushort> result1, out Vector512<ushort> result2) {
                return YGroup1ToGroup3_Basic(x, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup3(Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup1ToGroup3(Vector512<int> x, out Vector512<int> result1, out Vector512<int> result2) {
                return YGroup1ToGroup3_Basic(x, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup3(Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup1ToGroup3(Vector512<uint> x, out Vector512<uint> result1, out Vector512<uint> result2) {
                return YGroup1ToGroup3_Basic(x, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup3(Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup1ToGroup3(Vector512<long> x, out Vector512<long> result1, out Vector512<long> result2) {
                return YGroup1ToGroup3_Basic(x, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup3(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup1ToGroup3(Vector512<ulong> x, out Vector512<ulong> result1, out Vector512<ulong> result2) {
                return YGroup1ToGroup3_Basic(x, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup3(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup1ToGroup3_Basic(Vector512<sbyte> x, out Vector512<sbyte> result1, out Vector512<sbyte> result2) {
                var d0 = YGroup1ToGroup3_Basic(x.AsByte(), out var d1, out var d2);
                result1 = d1.AsSByte();
                result2 = d2.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup3(Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup1ToGroup3_Basic(Vector512<byte> x, out Vector512<byte> result1, out Vector512<byte> result2) {
                Span<Vector512<byte>> src = [x];
                Span<Vector512<byte>> dst = stackalloc Vector512<byte>[3];
                Span<byte> p = MemoryMarshal.Cast<Vector512<byte>, byte>(src);
                Span<byte> q = MemoryMarshal.Cast<Vector512<byte>, byte>(dst);
                for (int i = 0; i < Vector512<byte>.Count; ++i) {
                    var m = p[0];
                    q[0] = m;
                    q[1] = m;
                    q[2] = m;
                    p = p.Slice(1);
                    q = q.Slice(3);
                }
                result1 = dst[1];
                result2 = dst[2];
                return dst[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup3(Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup1ToGroup3_Basic(Vector512<short> x, out Vector512<short> result1, out Vector512<short> result2) {
                var d0 = YGroup1ToGroup3_Basic(x.AsUInt16(), out var d1, out var d2);
                result1 = d1.AsInt16();
                result2 = d2.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup3(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup1ToGroup3_Basic(Vector512<ushort> x, out Vector512<ushort> result1, out Vector512<ushort> result2) {
                Span<Vector512<ushort>> src = [x];
                Span<Vector512<ushort>> dst = stackalloc Vector512<ushort>[3];
                Span<ushort> p = MemoryMarshal.Cast<Vector512<ushort>, ushort>(src);
                Span<ushort> q = MemoryMarshal.Cast<Vector512<ushort>, ushort>(dst);
                for (int i = 0; i < Vector512<ushort>.Count; ++i) {
                    var m = p[0];
                    q[0] = m;
                    q[1] = m;
                    q[2] = m;
                    p = p.Slice(1);
                    q = q.Slice(3);
                }
                result1 = dst[1];
                result2 = dst[2];
                return dst[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup3(Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup1ToGroup3_Basic(Vector512<int> x, out Vector512<int> result1, out Vector512<int> result2) {
                var d0 = YGroup1ToGroup3_Basic(x.AsUInt32(), out var d1, out var d2);
                result1 = d1.AsInt32();
                result2 = d2.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup3(Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup1ToGroup3_Basic(Vector512<uint> x, out Vector512<uint> result1, out Vector512<uint> result2) {
                Span<Vector512<uint>> src = [x];
                Span<Vector512<uint>> dst = stackalloc Vector512<uint>[3];
                Span<uint> p = MemoryMarshal.Cast<Vector512<uint>, uint>(src);
                Span<uint> q = MemoryMarshal.Cast<Vector512<uint>, uint>(dst);
                for (int i = 0; i < Vector512<uint>.Count; ++i) {
                    var m = p[0];
                    q[0] = m;
                    q[1] = m;
                    q[2] = m;
                    p = p.Slice(1);
                    q = q.Slice(3);
                }
                result1 = dst[1];
                result2 = dst[2];
                return dst[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup3(Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup1ToGroup3_Basic(Vector512<long> x, out Vector512<long> result1, out Vector512<long> result2) {
                var d0 = YGroup1ToGroup3_Basic(x.AsUInt64(), out var d1, out var d2);
                result1 = d1.AsInt64();
                result2 = d2.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup3(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup1ToGroup3_Basic(Vector512<ulong> x, out Vector512<ulong> result1, out Vector512<ulong> result2) {
                Span<Vector512<ulong>> src = [x];
                Span<Vector512<ulong>> dst = stackalloc Vector512<ulong>[3];
                Span<ulong> p = MemoryMarshal.Cast<Vector512<ulong>, ulong>(src);
                Span<ulong> q = MemoryMarshal.Cast<Vector512<ulong>, ulong>(dst);
                for (int i = 0; i < Vector512<ulong>.Count; ++i) {
                    var m = p[0];
                    q[0] = m;
                    q[1] = m;
                    q[2] = m;
                    p = p.Slice(1);
                    q = q.Slice(3);
                }
                result1 = dst[1];
                result2 = dst[2];
                return dst[0];
            }

#if VECTOR_HAS_METHOD

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup3(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup1ToGroup3_Shuffle(Vector512<sbyte> x, out Vector512<sbyte> result1, out Vector512<sbyte> result2) {
                var d0 = YGroup1ToGroup3_Shuffle(x.AsByte(), out var d1, out var d2);
                result1 = d1.AsSByte();
                result2 = d2.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup3(Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup1ToGroup3_Shuffle(Vector512<byte> x, out Vector512<byte> result1, out Vector512<byte> result2) {
                var f0 = Vector512Constants.YGroup1ToGroup3_Shuffle_Byte_0;
                var f1 = Vector512Constants.YGroup1ToGroup3_Shuffle_Byte_1;
                var f2 = Vector512Constants.YGroup1ToGroup3_Shuffle_Byte_2;
                var a_0 = Vector512.Shuffle(x, f0);
                var a_1 = Vector512.Shuffle(x, f1);
                var a_2 = Vector512.Shuffle(x, f2);
                result1 = a_1;
                result2 = a_2;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup3(Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup1ToGroup3_Shuffle(Vector512<short> x, out Vector512<short> result1, out Vector512<short> result2) {
                var d0 = YGroup1ToGroup3_Shuffle(x.AsUInt16(), out var d1, out var d2);
                result1 = d1.AsInt16();
                result2 = d2.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup3(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup1ToGroup3_Shuffle(Vector512<ushort> x, out Vector512<ushort> result1, out Vector512<ushort> result2) {
                var f0 = Vector512Constants.YGroup1ToGroup3_ShuffleOnByte_UInt16_0;
                var f1 = Vector512Constants.YGroup1ToGroup3_ShuffleOnByte_UInt16_1;
                var f2 = Vector512Constants.YGroup1ToGroup3_ShuffleOnByte_UInt16_2;
                var s0 = x.AsByte();
                var a_0 = Vector512.Shuffle(s0, f0).AsUInt16();
                var a_1 = Vector512.Shuffle(s0, f1).AsUInt16();
                var a_2 = Vector512.Shuffle(s0, f2).AsUInt16();
                result1 = a_1;
                result2 = a_2;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup3(Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup1ToGroup3_Shuffle(Vector512<int> x, out Vector512<int> result1, out Vector512<int> result2) {
                var d0 = YGroup1ToGroup3_Shuffle(x.AsUInt32(), out var d1, out var d2);
                result1 = d1.AsInt32();
                result2 = d2.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup3(Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup1ToGroup3_Shuffle(Vector512<uint> x, out Vector512<uint> result1, out Vector512<uint> result2) {
                var f0 = Vector512Constants.YGroup1ToGroup3_ShuffleOnByte_UInt32_0;
                var f1 = Vector512Constants.YGroup1ToGroup3_ShuffleOnByte_UInt32_1;
                var f2 = Vector512Constants.YGroup1ToGroup3_ShuffleOnByte_UInt32_2;
                var s0 = x.AsByte();
                var a_0 = Vector512.Shuffle(s0, f0).AsUInt32();
                var a_1 = Vector512.Shuffle(s0, f1).AsUInt32();
                var a_2 = Vector512.Shuffle(s0, f2).AsUInt32();
                result1 = a_1;
                result2 = a_2;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup3(Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup1ToGroup3_Shuffle(Vector512<long> x, out Vector512<long> result1, out Vector512<long> result2) {
                var d0 = YGroup1ToGroup3_Shuffle(x.AsUInt64(), out var d1, out var d2);
                result1 = d1.AsInt64();
                result2 = d2.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup3(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup1ToGroup3_Shuffle(Vector512<ulong> x, out Vector512<ulong> result1, out Vector512<ulong> result2) {
                var f0 = Vector512Constants.YGroup1ToGroup3_ShuffleOnByte_UInt64_0;
                var f1 = Vector512Constants.YGroup1ToGroup3_ShuffleOnByte_UInt64_1;
                var f2 = Vector512Constants.YGroup1ToGroup3_ShuffleOnByte_UInt64_2;
                var s0 = x.AsByte();
                var a_0 = Vector512.Shuffle(s0, f0).AsUInt64();
                var a_1 = Vector512.Shuffle(s0, f1).AsUInt64();
                var a_2 = Vector512.Shuffle(s0, f2).AsUInt64();
                result1 = a_1;
                result2 = a_2;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup3(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup1ToGroup3_Zip(Vector512<sbyte> x, out Vector512<sbyte> result1, out Vector512<sbyte> result2) {
                var d0 = YGroup1ToGroup3_Zip(x.AsByte(), out var d1, out var d2);
                result1 = d1.AsSByte();
                result2 = d2.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup3(Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup1ToGroup3_Zip(Vector512<byte> x, out Vector512<byte> result1, out Vector512<byte> result2) {
                return YGroup3Zip(x, x, x, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup3(Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup1ToGroup3_Zip(Vector512<short> x, out Vector512<short> result1, out Vector512<short> result2) {
                var d0 = YGroup1ToGroup3_Zip(x.AsUInt16(), out var d1, out var d2);
                result1 = d1.AsInt16();
                result2 = d2.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup3(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup1ToGroup3_Zip(Vector512<ushort> x, out Vector512<ushort> result1, out Vector512<ushort> result2) {
                return YGroup3Zip(x, x, x, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup3(Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup1ToGroup3_Zip(Vector512<int> x, out Vector512<int> result1, out Vector512<int> result2) {
                var d0 = YGroup1ToGroup3_Zip(x.AsUInt32(), out var d1, out var d2);
                result1 = d1.AsInt32();
                result2 = d2.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup3(Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup1ToGroup3_Zip(Vector512<uint> x, out Vector512<uint> result1, out Vector512<uint> result2) {
                return YGroup3Zip(x, x, x, out result1, out result2);
            }

#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup4_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup1ToGroup4_AcceleratedTypes {
                get {
                    return YGroup4Zip_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup4(Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup1ToGroup4(Vector512<float> x, out Vector512<float> data1, out Vector512<float> data2, out Vector512<float> data3) {
                return YGroup4Zip(x, x, x, x, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup4(Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup1ToGroup4(Vector512<double> x, out Vector512<double> data1, out Vector512<double> data2, out Vector512<double> data3) {
                return YGroup4Zip(x, x, x, x, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup4(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup1ToGroup4(Vector512<sbyte> x, out Vector512<sbyte> data1, out Vector512<sbyte> data2, out Vector512<sbyte> data3) {
                return YGroup4Zip(x, x, x, x, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup4(Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup1ToGroup4(Vector512<byte> x, out Vector512<byte> data1, out Vector512<byte> data2, out Vector512<byte> data3) {
                return YGroup4Zip(x, x, x, x, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup4(Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup1ToGroup4(Vector512<short> x, out Vector512<short> data1, out Vector512<short> data2, out Vector512<short> data3) {
                return YGroup4Zip(x, x, x, x, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup4(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup1ToGroup4(Vector512<ushort> x, out Vector512<ushort> data1, out Vector512<ushort> data2, out Vector512<ushort> data3) {
                return YGroup4Zip(x, x, x, x, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup4(Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup1ToGroup4(Vector512<int> x, out Vector512<int> data1, out Vector512<int> data2, out Vector512<int> data3) {
                return YGroup4Zip(x, x, x, x, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup4(Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup1ToGroup4(Vector512<uint> x, out Vector512<uint> data1, out Vector512<uint> data2, out Vector512<uint> data3) {
                return YGroup4Zip(x, x, x, x, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup4(Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup1ToGroup4(Vector512<long> x, out Vector512<long> data1, out Vector512<long> data2, out Vector512<long> data3) {
                return YGroup4Zip(x, x, x, x, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup4(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup1ToGroup4(Vector512<ulong> x, out Vector512<ulong> data1, out Vector512<ulong> data2, out Vector512<ulong> data3) {
                return YGroup4Zip(x, x, x, x, out data1, out data2, out data3);
            }


            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup4WithW_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup1ToGroup4WithW_AcceleratedTypes {
                get {
                    return YGroup4Zip_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup4WithW(Vector512{float}, Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup1ToGroup4WithW(Vector512<float> x, Vector512<float> w, out Vector512<float> data1, out Vector512<float> data2, out Vector512<float> data3) {
                return YGroup4Zip(x, x, x, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup4WithW(Vector512{double}, Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup1ToGroup4WithW(Vector512<double> x, Vector512<double> w, out Vector512<double> data1, out Vector512<double> data2, out Vector512<double> data3) {
                return YGroup4Zip(x, x, x, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup4WithW(Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup1ToGroup4WithW(Vector512<sbyte> x, Vector512<sbyte> w, out Vector512<sbyte> data1, out Vector512<sbyte> data2, out Vector512<sbyte> data3) {
                return YGroup4Zip(x, x, x, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup4WithW(Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup1ToGroup4WithW(Vector512<byte> x, Vector512<byte> w, out Vector512<byte> data1, out Vector512<byte> data2, out Vector512<byte> data3) {
                return YGroup4Zip(x, x, x, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup4WithW(Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup1ToGroup4WithW(Vector512<short> x, Vector512<short> w, out Vector512<short> data1, out Vector512<short> data2, out Vector512<short> data3) {
                return YGroup4Zip(x, x, x, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup4WithW(Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup1ToGroup4WithW(Vector512<ushort> x, Vector512<ushort> w, out Vector512<ushort> data1, out Vector512<ushort> data2, out Vector512<ushort> data3) {
                return YGroup4Zip(x, x, x, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup4WithW(Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup1ToGroup4WithW(Vector512<int> x, Vector512<int> w, out Vector512<int> data1, out Vector512<int> data2, out Vector512<int> data3) {
                return YGroup4Zip(x, x, x, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup4WithW(Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup1ToGroup4WithW(Vector512<uint> x, Vector512<uint> w, out Vector512<uint> data1, out Vector512<uint> data2, out Vector512<uint> data3) {
                return YGroup4Zip(x, x, x, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup4WithW(Vector512{long}, Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup1ToGroup4WithW(Vector512<long> x, Vector512<long> w, out Vector512<long> data1, out Vector512<long> data2, out Vector512<long> data3) {
                return YGroup4Zip(x, x, x, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup1ToGroup4WithW(Vector512{ulong}, Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup1ToGroup4WithW(Vector512<ulong> x, Vector512<ulong> w, out Vector512<ulong> data1, out Vector512<ulong> data2, out Vector512<ulong> data3) {
                return YGroup4Zip(x, x, x, w, out data1, out data2, out data3);
            }


            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2Unzip_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt = TypeCodeFlagsUtil.Most32Types;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{float}, Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup2Unzip(Vector512<float> data0, Vector512<float> data1, out Vector512<float> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup2Unzip_Narrow(data0, data1, out y);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Unzip_Basic(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{double}, Vector512{double}, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup2Unzip(Vector512<double> data0, Vector512<double> data1, out Vector512<double> y) {
                return YGroup2Unzip_Basic(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup2Unzip(Vector512<sbyte> data0, Vector512<sbyte> data1, out Vector512<sbyte> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup2Unzip_Narrow(data0, data1, out y);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Unzip_Basic(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{byte}, Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup2Unzip(Vector512<byte> data0, Vector512<byte> data1, out Vector512<byte> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup2Unzip_Narrow(data0, data1, out y);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Unzip_Basic(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{short}, Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup2Unzip(Vector512<short> data0, Vector512<short> data1, out Vector512<short> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup2Unzip_Narrow(data0, data1, out y);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Unzip_Basic(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{ushort}, Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup2Unzip(Vector512<ushort> data0, Vector512<ushort> data1, out Vector512<ushort> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup2Unzip_Narrow(data0, data1, out y);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Unzip_Basic(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{int}, Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup2Unzip(Vector512<int> data0, Vector512<int> data1, out Vector512<int> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup2Unzip_Narrow(data0, data1, out y);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Unzip_Basic(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{uint}, Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup2Unzip(Vector512<uint> data0, Vector512<uint> data1, out Vector512<uint> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup2Unzip_Narrow(data0, data1, out y);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Unzip_Basic(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{long}, Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup2Unzip(Vector512<long> data0, Vector512<long> data1, out Vector512<long> y) {
                return YGroup2Unzip_Basic(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{ulong}, Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup2Unzip(Vector512<ulong> data0, Vector512<ulong> data1, out Vector512<ulong> y) {
                return YGroup2Unzip_Basic(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{ExInt128}, Vector512{ExInt128}, out Vector512{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExInt128> YGroup2Unzip(Vector512<ExInt128> data0, Vector512<ExInt128> data1, out Vector512<ExInt128> y) {
                return YGroup2Unzip_Move(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{ExUInt128}, Vector512{ExUInt128}, out Vector512{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExUInt128> YGroup2Unzip(Vector512<ExUInt128> data0, Vector512<ExUInt128> data1, out Vector512<ExUInt128> y) {
                return YGroup2Unzip_Move(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip_Bit128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<T> YGroup2Unzip_Bit128<T>(Vector512<T> data0, Vector512<T> data1, out Vector512<T> y) where T : struct {
#if EX_APPLY_GENERIC
                var d0 = YGroup2Unzip_Move(data0.ExAsExUInt128(), data1.ExAsExUInt128(), out var d1);
                y = d1.ExAs<ExUInt128, T>();
                return d0.ExAs<ExUInt128, T>();
#else
                var a0 = data0;
                var a1 = data1;
                var b0 = a0.GetLower();
                var b1 = a0.GetUpper();
                var b2 = a1.GetLower();
                var b3 = a1.GetUpper();
                var c0 = b0.WithUpper(b1.GetLower()).ToVector512Unsafe().WithUpper(b2.WithUpper(b3.GetLower()));
                var c1 = b0.GetUpper().ToVector256Unsafe().WithUpper(b1.GetUpper()).ToVector512Unsafe().WithUpper(b2.GetUpper().ToVector256Unsafe().WithUpper(b3.GetUpper()));
                y = c1;
                return c0;
#endif // EX_APPLY_GENERIC
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{float}, Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup2Unzip_Basic(Vector512<float> data0, Vector512<float> data1, out Vector512<float> y) {
                var d0 = YGroup2Unzip_Basic(data0.AsUInt32(), data1.AsUInt32(), out var d1);
                y = d1.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{double}, Vector512{double}, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup2Unzip_Basic(Vector512<double> data0, Vector512<double> data1, out Vector512<double> y) {
                var d0 = YGroup2Unzip_Basic(data0.AsUInt64(), data1.AsUInt64(), out var d1);
                y = d1.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup2Unzip_Basic(Vector512<sbyte> data0, Vector512<sbyte> data1, out Vector512<sbyte> y) {
                var d0 = YGroup2Unzip_Basic(data0.AsByte(), data1.AsByte(), out var d1);
                y = d1.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{byte}, Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup2Unzip_Basic(Vector512<byte> data0, Vector512<byte> data1, out Vector512<byte> y) {
                UnsafeUtil.SkipInit(out Vector512<byte> x1);
                UnsafeUtil.SkipInit(out Vector512<byte> y1);
                Span<Vector512<byte>> src = [data0, data1];
                ref byte px = ref Unsafe.As<Vector512<byte>, byte>(ref x1);
                ref byte py = ref Unsafe.As<Vector512<byte>, byte>(ref y1);
                Span<byte> p = MemoryMarshal.Cast<Vector512<byte>, byte>(src);
                int idx = 0;
                for (int i = 0; i < Vector512<byte>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    Unsafe.Add(ref py, i) = p[idx + 1];
                    idx += 2;
                }
                y = y1;
                return x1;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{short}, Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup2Unzip_Basic(Vector512<short> data0, Vector512<short> data1, out Vector512<short> y) {
                var d0 = YGroup2Unzip_Basic(data0.AsUInt16(), data1.AsUInt16(), out var d1);
                y = d1.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{ushort}, Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup2Unzip_Basic(Vector512<ushort> data0, Vector512<ushort> data1, out Vector512<ushort> y) {
                UnsafeUtil.SkipInit(out Vector512<ushort> x1);
                UnsafeUtil.SkipInit(out Vector512<ushort> y1);
                Span<Vector512<ushort>> src = [data0, data1];
                ref ushort px = ref Unsafe.As<Vector512<ushort>, ushort>(ref x1);
                ref ushort py = ref Unsafe.As<Vector512<ushort>, ushort>(ref y1);
                Span<ushort> p = MemoryMarshal.Cast<Vector512<ushort>, ushort>(src);
                int idx = 0;
                for (int i = 0; i < Vector512<ushort>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    Unsafe.Add(ref py, i) = p[idx + 1];
                    idx += 2;
                }
                y = y1;
                return x1;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{int}, Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup2Unzip_Basic(Vector512<int> data0, Vector512<int> data1, out Vector512<int> y) {
                var d0 = YGroup2Unzip_Basic(data0.AsUInt32(), data1.AsUInt32(), out var d1);
                y = d1.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{uint}, Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup2Unzip_Basic(Vector512<uint> data0, Vector512<uint> data1, out Vector512<uint> y) {
                UnsafeUtil.SkipInit(out Vector512<uint> x1);
                UnsafeUtil.SkipInit(out Vector512<uint> y1);
                Span<Vector512<uint>> src = [data0, data1];
                ref uint px = ref Unsafe.As<Vector512<uint>, uint>(ref x1);
                ref uint py = ref Unsafe.As<Vector512<uint>, uint>(ref y1);
                Span<uint> p = MemoryMarshal.Cast<Vector512<uint>, uint>(src);
                int idx = 0;
                for (int i = 0; i < Vector512<uint>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    Unsafe.Add(ref py, i) = p[idx + 1];
                    idx += 2;
                }
                y = y1;
                return x1;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{long}, Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup2Unzip_Basic(Vector512<long> data0, Vector512<long> data1, out Vector512<long> y) {
                var d0 = YGroup2Unzip_Basic(data0.AsUInt64(), data1.AsUInt64(), out var d1);
                y = d1.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{ulong}, Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup2Unzip_Basic(Vector512<ulong> data0, Vector512<ulong> data1, out Vector512<ulong> y) {
                UnsafeUtil.SkipInit(out Vector512<ulong> x1);
                UnsafeUtil.SkipInit(out Vector512<ulong> y1);
                Span<Vector512<ulong>> src = [data0, data1];
                ref ulong px = ref Unsafe.As<Vector512<ulong>, ulong>(ref x1);
                ref ulong py = ref Unsafe.As<Vector512<ulong>, ulong>(ref y1);
                Span<ulong> p = MemoryMarshal.Cast<Vector512<ulong>, ulong>(src);
                int idx = 0;
                for (int i = 0; i < Vector512<ulong>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    Unsafe.Add(ref py, i) = p[idx + 1];
                    idx += 2;
                }
                y = y1;
                return x1;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{ExInt128}, Vector512{ExInt128}, out Vector512{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExInt128> YGroup2Unzip_Basic(Vector512<ExInt128> data0, Vector512<ExInt128> data1, out Vector512<ExInt128> y) {
                var d0 = YGroup2Unzip_Basic(data0.ExAsExUInt128(), data1.ExAsExUInt128(), out var d1);
                y = d1.ExAsExInt128();
                return d0.ExAsExInt128();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{ExUInt128}, Vector512{ExUInt128}, out Vector512{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExUInt128> YGroup2Unzip_Basic(Vector512<ExUInt128> data0, Vector512<ExUInt128> data1, out Vector512<ExUInt128> y) {
                UnsafeUtil.SkipInit(out Vector512<ExUInt128> x1);
                UnsafeUtil.SkipInit(out Vector512<ExUInt128> y1);
                Span<Vector512<ExUInt128>> src = [data0, data1];
                ref ExUInt128 px = ref Unsafe.As<Vector512<ExUInt128>, ExUInt128>(ref x1);
                ref ExUInt128 py = ref Unsafe.As<Vector512<ExUInt128>, ExUInt128>(ref y1);
                Span<ExUInt128> p = MemoryMarshal.Cast<Vector512<ExUInt128>, ExUInt128>(src);
                int idx = 0;
                for (int i = 0; i < Vector512s<ExUInt128>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    Unsafe.Add(ref py, i) = p[idx + 1];
                    idx += 2;
                }
                y = y1;
                return x1;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{ExInt128}, Vector512{ExInt128}, out Vector512{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExInt128> YGroup2Unzip_Move(Vector512<ExInt128> data0, Vector512<ExInt128> data1, out Vector512<ExInt128> y) {
                var d0 = YGroup2Unzip_Move(data0.ExAsExUInt128(), data1.ExAsExUInt128(), out var d1);
                y = d1.ExAsExInt128();
                return d0.ExAsExInt128();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{ExUInt128}, Vector512{ExUInt128}, out Vector512{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExUInt128> YGroup2Unzip_Move(Vector512<ExUInt128> data0, Vector512<ExUInt128> data1, out Vector512<ExUInt128> y) {
                var a0 = data0.ExAsUInt64();
                var a1 = data1.ExAsUInt64();
                var b0 = a0.GetLower();
                var b1 = a0.GetUpper();
                var b2 = a1.GetLower();
                var b3 = a1.GetUpper();
                var c0 = b0.WithUpper(b1.GetLower()).ToVector512Unsafe().WithUpper(b2.WithUpper(b3.GetLower()));
                var c1 = b0.GetUpper().ToVector256Unsafe().WithUpper(b1.GetUpper()).ToVector512Unsafe().WithUpper(b2.GetUpper().ToVector256Unsafe().WithUpper(b3.GetUpper()));
                y = c1.ExAsExUInt128();
                return c0.ExAsExUInt128();
            }

#if VECTOR_HAS_METHOD

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{float}, Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup2Unzip_Narrow(Vector512<float> data0, Vector512<float> data1, out Vector512<float> y) {
                var d0 = YGroup2Unzip_Narrow(data0.AsUInt32(), data1.AsUInt32(), out var d1);
                y = d1.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup2Unzip_Narrow(Vector512<sbyte> data0, Vector512<sbyte> data1, out Vector512<sbyte> y) {
                var d0 = YGroup2Unzip_Narrow(data0.AsByte(), data1.AsByte(), out var d1);
                y = d1.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{byte}, Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup2Unzip_Narrow(Vector512<byte> data0, Vector512<byte> data1, out Vector512<byte> y) {
                const int L = 8;
                Vector512<byte> rt0, rt1;
                Vector512<ushort> temp0 = data0.AsUInt16();
                Vector512<ushort> temp1 = data1.AsUInt16();
                rt0 = Vector512.Narrow(temp0, temp1);
                temp0 = Vector512.ShiftRightLogical(temp0, L);
                temp1 = Vector512.ShiftRightLogical(temp1, L);
                rt1 = Vector512.Narrow(temp0, temp1);
                if (BitConverter.IsLittleEndian) {
                    y = rt1;
                    return rt0;
                } else {
                    y = rt0;
                    return rt1;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{short}, Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup2Unzip_Narrow(Vector512<short> data0, Vector512<short> data1, out Vector512<short> y) {
                var d0 = YGroup2Unzip_Narrow(data0.AsUInt16(), data1.AsUInt16(), out var d1);
                y = d1.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{ushort}, Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup2Unzip_Narrow(Vector512<ushort> data0, Vector512<ushort> data1, out Vector512<ushort> y) {
                const int L = 16;
                Vector512<ushort> rt0, rt1;
                Vector512<uint> temp0 = data0.AsUInt32();
                Vector512<uint> temp1 = data1.AsUInt32();
                rt0 = Vector512.Narrow(temp0, temp1);
                temp0 = Vector512.ShiftRightLogical(temp0, L);
                temp1 = Vector512.ShiftRightLogical(temp1, L);
                rt1 = Vector512.Narrow(temp0, temp1);
                if (BitConverter.IsLittleEndian) {
                    y = rt1;
                    return rt0;
                } else {
                    y = rt0;
                    return rt1;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{int}, Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup2Unzip_Narrow(Vector512<int> data0, Vector512<int> data1, out Vector512<int> y) {
                var d0 = YGroup2Unzip_Narrow(data0.AsUInt32(), data1.AsUInt32(), out var d1);
                y = d1.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{uint}, Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup2Unzip_Narrow(Vector512<uint> data0, Vector512<uint> data1, out Vector512<uint> y) {
                const int L = 32;
                Vector512<uint> rt0, rt1;
                Vector512<ulong> temp0 = data0.AsUInt64();
                Vector512<ulong> temp1 = data1.AsUInt64();
                rt0 = Vector512.Narrow(temp0, temp1);
                temp0 = Vector512.ShiftRightLogical(temp0, L);
                temp1 = Vector512.ShiftRightLogical(temp1, L);
                rt1 = Vector512.Narrow(temp0, temp1);
                if (BitConverter.IsLittleEndian) {
                    y = rt1;
                    return rt0;
                } else {
                    y = rt0;
                    return rt1;
                }
            }

#endif // VECTOR_HAS_METHOD

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{ExInt128}, Vector512{ExInt128}, out Vector512{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExInt128> YGroup2Unzip_Unzip(Vector512<ExInt128> data0, Vector512<ExInt128> data1, out Vector512<ExInt128> y) {
                var d0 = YGroup2Unzip_Unzip(data0.ExAsExUInt128(), data1.ExAsExUInt128(), out var d1);
                y = d1.ExAsExInt128();
                return d0.ExAsExInt128();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{ExUInt128}, Vector512{ExUInt128}, out Vector512{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExUInt128> YGroup2Unzip_Unzip(Vector512<ExUInt128> data0, Vector512<ExUInt128> data1, out Vector512<ExUInt128> y) {
                var a0 = data0.ExAsUInt64();
                var a1 = data1.ExAsUInt64();
                var b0 = a0.GetLower();
                var b1 = a0.GetUpper();
                var b2 = a1.GetLower();
                var b3 = a1.GetUpper();
                var c0 = b0.WithUpper(b1.GetLower()).ToVector512Unsafe().WithUpper(b2.WithUpper(b3.GetLower()));
                var c1 = b0.GetUpper().ToVector256Unsafe().WithUpper(b1.GetUpper()).ToVector512Unsafe().WithUpper(b2.GetUpper().ToVector256Unsafe().WithUpper(b3.GetUpper()));
                y = c1.ExAsExUInt128();
                return c0.ExAsExUInt128();
            }


            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2UnzipEven_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt = TypeCodeFlagsUtil.Most32Types;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup2UnzipEven(Vector512<float> data0, Vector512<float> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup2UnzipEven_Narrow(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipEven_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup2UnzipEven(Vector512<double> data0, Vector512<double> data1) {
                return YGroup2UnzipEven_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup2UnzipEven(Vector512<sbyte> data0, Vector512<sbyte> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup2UnzipEven_Narrow(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipEven_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup2UnzipEven(Vector512<byte> data0, Vector512<byte> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup2UnzipEven_Narrow(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipEven_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup2UnzipEven(Vector512<short> data0, Vector512<short> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup2UnzipEven_Narrow(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipEven_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup2UnzipEven(Vector512<ushort> data0, Vector512<ushort> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup2UnzipEven_Narrow(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipEven_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup2UnzipEven(Vector512<int> data0, Vector512<int> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup2UnzipEven_Narrow(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipEven_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup2UnzipEven(Vector512<uint> data0, Vector512<uint> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup2UnzipEven_Narrow(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipEven_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup2UnzipEven(Vector512<long> data0, Vector512<long> data1) {
                return YGroup2UnzipEven_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup2UnzipEven(Vector512<ulong> data0, Vector512<ulong> data1) {
                return YGroup2UnzipEven_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{ExInt128}, Vector512{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExInt128> YGroup2UnzipEven(Vector512<ExInt128> data0, Vector512<ExInt128> data1) {
                return YGroup2UnzipEven(data0.ExAsExUInt128(), data1.ExAsExUInt128()).ExAsExInt128();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{ExUInt128}, Vector512{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExUInt128> YGroup2UnzipEven(Vector512<ExUInt128> data0, Vector512<ExUInt128> data1) {
                var a0 = data0.ExAsUInt64();
                var a1 = data1.ExAsUInt64();
                var b0 = a0.GetLower();
                var b1 = a0.GetUpper();
                var b2 = a1.GetLower();
                var b3 = a1.GetUpper();
                var c0 = b0.WithUpper(b1.GetLower()).ToVector512Unsafe().WithUpper(b2.WithUpper(b3.GetLower()));
                return c0.ExAsExUInt128();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup2UnzipEven_Basic(Vector512<float> data0, Vector512<float> data1) {
                return YGroup2UnzipEven_Basic(data0.AsUInt32(), data1.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup2UnzipEven_Basic(Vector512<double> data0, Vector512<double> data1) {
                return YGroup2UnzipEven_Basic(data0.AsUInt64(), data1.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup2UnzipEven_Basic(Vector512<sbyte> data0, Vector512<sbyte> data1) {
                return YGroup2UnzipEven_Basic(data0.AsByte(), data1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup2UnzipEven_Basic(Vector512<byte> data0, Vector512<byte> data1) {
                UnsafeUtil.SkipInit(out Vector512<byte> x1);
                Span<Vector512<byte>> src = [data0, data1];
                ref byte px = ref Unsafe.As<Vector512<byte>, byte>(ref x1);
                Span<byte> p = MemoryMarshal.Cast<Vector512<byte>, byte>(src);
                int idx = 0;
                for (int i = 0; i < Vector512<byte>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    idx += 2;
                }
                return x1;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup2UnzipEven_Basic(Vector512<short> data0, Vector512<short> data1) {
                return YGroup2UnzipEven_Basic(data0.AsUInt16(), data1.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup2UnzipEven_Basic(Vector512<ushort> data0, Vector512<ushort> data1) {
                UnsafeUtil.SkipInit(out Vector512<ushort> x1);
                Span<Vector512<ushort>> src = [data0, data1];
                ref ushort px = ref Unsafe.As<Vector512<ushort>, ushort>(ref x1);
                Span<ushort> p = MemoryMarshal.Cast<Vector512<ushort>, ushort>(src);
                int idx = 0;
                for (int i = 0; i < Vector512<ushort>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    idx += 2;
                }
                return x1;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup2UnzipEven_Basic(Vector512<int> data0, Vector512<int> data1) {
                return YGroup2UnzipEven_Basic(data0.AsUInt32(), data1.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup2UnzipEven_Basic(Vector512<uint> data0, Vector512<uint> data1) {
                UnsafeUtil.SkipInit(out Vector512<uint> x1);
                Span<Vector512<uint>> src = [data0, data1];
                ref uint px = ref Unsafe.As<Vector512<uint>, uint>(ref x1);
                Span<uint> p = MemoryMarshal.Cast<Vector512<uint>, uint>(src);
                int idx = 0;
                for (int i = 0; i < Vector512<uint>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    idx += 2;
                }
                return x1;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup2UnzipEven_Basic(Vector512<long> data0, Vector512<long> data1) {
                return YGroup2UnzipEven_Basic(data0.AsUInt64(), data1.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup2UnzipEven_Basic(Vector512<ulong> data0, Vector512<ulong> data1) {
                UnsafeUtil.SkipInit(out Vector512<ulong> x1);
                Span<Vector512<ulong>> src = [data0, data1];
                ref ulong px = ref Unsafe.As<Vector512<ulong>, ulong>(ref x1);
                Span<ulong> p = MemoryMarshal.Cast<Vector512<ulong>, ulong>(src);
                int idx = 0;
                for (int i = 0; i < Vector512<ulong>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    idx += 2;
                }
                return x1;
            }

#if VECTOR_HAS_METHOD

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup2UnzipEven_Narrow(Vector512<float> data0, Vector512<float> data1) {
                return YGroup2UnzipEven_Narrow(data0.AsUInt32(), data1.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup2UnzipEven_Narrow(Vector512<sbyte> data0, Vector512<sbyte> data1) {
                return YGroup2UnzipEven_Narrow(data0.AsByte(), data1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup2UnzipEven_Narrow(Vector512<byte> data0, Vector512<byte> data1) {
                const int L = 8;
                Vector512<byte> rt0, rt1;
                Vector512<ushort> temp0 = data0.AsUInt16();
                Vector512<ushort> temp1 = data1.AsUInt16();
                if (BitConverter.IsLittleEndian) {
                    rt0 = Vector512.Narrow(temp0, temp1);
                    return rt0;
                } else {
                    temp0 = Vector512.ShiftRightLogical(temp0, L);
                    temp1 = Vector512.ShiftRightLogical(temp1, L);
                    rt1 = Vector512.Narrow(temp0, temp1);
                    return rt1;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup2UnzipEven_Narrow(Vector512<short> data0, Vector512<short> data1) {
                return YGroup2UnzipEven_Narrow(data0.AsUInt16(), data1.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup2UnzipEven_Narrow(Vector512<ushort> data0, Vector512<ushort> data1) {
                const int L = 16;
                Vector512<ushort> rt0, rt1;
                Vector512<uint> temp0 = data0.AsUInt32();
                Vector512<uint> temp1 = data1.AsUInt32();
                if (BitConverter.IsLittleEndian) {
                    rt0 = Vector512.Narrow(temp0, temp1);
                    return rt0;
                } else {
                    temp0 = Vector512.ShiftRightLogical(temp0, L);
                    temp1 = Vector512.ShiftRightLogical(temp1, L);
                    rt1 = Vector512.Narrow(temp0, temp1);
                    return rt1;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup2UnzipEven_Narrow(Vector512<int> data0, Vector512<int> data1) {
                return YGroup2UnzipEven_Narrow(data0.AsUInt32(), data1.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup2UnzipEven_Narrow(Vector512<uint> data0, Vector512<uint> data1) {
                const int L = 32;
                Vector512<uint> rt0, rt1;
                Vector512<ulong> temp0 = data0.AsUInt64();
                Vector512<ulong> temp1 = data1.AsUInt64();
                if (BitConverter.IsLittleEndian) {
                    rt0 = Vector512.Narrow(temp0, temp1);
                    return rt0;
                } else {
                    temp0 = Vector512.ShiftRightLogical(temp0, L);
                    temp1 = Vector512.ShiftRightLogical(temp1, L);
                    rt1 = Vector512.Narrow(temp0, temp1);
                    return rt1;
                }
            }

#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2UnzipOdd_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt = TypeCodeFlagsUtil.Most32Types;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup2UnzipOdd(Vector512<float> data0, Vector512<float> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup2UnzipOdd_Narrow(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipOdd_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup2UnzipOdd(Vector512<double> data0, Vector512<double> data1) {
                return YGroup2UnzipOdd_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup2UnzipOdd(Vector512<sbyte> data0, Vector512<sbyte> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup2UnzipOdd_Narrow(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipOdd_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup2UnzipOdd(Vector512<byte> data0, Vector512<byte> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup2UnzipOdd_Narrow(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipOdd_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup2UnzipOdd(Vector512<short> data0, Vector512<short> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup2UnzipOdd_Narrow(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipOdd_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup2UnzipOdd(Vector512<ushort> data0, Vector512<ushort> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup2UnzipOdd_Narrow(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipOdd_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup2UnzipOdd(Vector512<int> data0, Vector512<int> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup2UnzipOdd_Narrow(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipOdd_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup2UnzipOdd(Vector512<uint> data0, Vector512<uint> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup2UnzipOdd_Narrow(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipOdd_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup2UnzipOdd(Vector512<long> data0, Vector512<long> data1) {
                return YGroup2UnzipOdd_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup2UnzipOdd(Vector512<ulong> data0, Vector512<ulong> data1) {
                return YGroup2UnzipOdd_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{ExInt128}, Vector512{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExInt128> YGroup2UnzipOdd(Vector512<ExInt128> data0, Vector512<ExInt128> data1) {
                return YGroup2UnzipOdd(data0.ExAsExUInt128(), data1.ExAsExUInt128()).ExAsExInt128();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{ExUInt128}, Vector512{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExUInt128> YGroup2UnzipOdd(Vector512<ExUInt128> data0, Vector512<ExUInt128> data1) {
                var a0 = data0.ExAsUInt64();
                var a1 = data1.ExAsUInt64();
                var b0 = a0.GetLower();
                var b1 = a0.GetUpper();
                var b2 = a1.GetLower();
                var b3 = a1.GetUpper();
                var c1 = b0.GetUpper().ToVector256Unsafe().WithUpper(b1.GetUpper()).ToVector512Unsafe().WithUpper(b2.GetUpper().ToVector256Unsafe().WithUpper(b3.GetUpper()));
                return c1.ExAsExUInt128();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup2UnzipOdd_Basic(Vector512<float> data0, Vector512<float> data1) {
                return YGroup2UnzipOdd_Basic(data0.AsUInt32(), data1.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup2UnzipOdd_Basic(Vector512<double> data0, Vector512<double> data1) {
                return YGroup2UnzipOdd_Basic(data0.AsUInt64(), data1.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup2UnzipOdd_Basic(Vector512<sbyte> data0, Vector512<sbyte> data1) {
                return YGroup2UnzipOdd_Basic(data0.AsByte(), data1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup2UnzipOdd_Basic(Vector512<byte> data0, Vector512<byte> data1) {
                UnsafeUtil.SkipInit(out Vector512<byte> y1);
                Span<Vector512<byte>> src = [data0, data1];
                ref byte py = ref Unsafe.As<Vector512<byte>, byte>(ref y1);
                Span<byte> p = MemoryMarshal.Cast<Vector512<byte>, byte>(src);
                int idx = 1;
                for (int i = 0; i < Vector512<byte>.Count; ++i) {
                    Unsafe.Add(ref py, i) = p[idx];
                    idx += 2;
                }
                return y1;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup2UnzipOdd_Basic(Vector512<short> data0, Vector512<short> data1) {
                return YGroup2UnzipOdd_Basic(data0.AsUInt16(), data1.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup2UnzipOdd_Basic(Vector512<ushort> data0, Vector512<ushort> data1) {
                UnsafeUtil.SkipInit(out Vector512<ushort> y1);
                Span<Vector512<ushort>> src = [data0, data1];
                ref ushort py = ref Unsafe.As<Vector512<ushort>, ushort>(ref y1);
                Span<ushort> p = MemoryMarshal.Cast<Vector512<ushort>, ushort>(src);
                int idx = 1;
                for (int i = 0; i < Vector512<ushort>.Count; ++i) {
                    Unsafe.Add(ref py, i) = p[idx];
                    idx += 2;
                }
                return y1;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup2UnzipOdd_Basic(Vector512<int> data0, Vector512<int> data1) {
                return YGroup2UnzipOdd_Basic(data0.AsUInt32(), data1.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup2UnzipOdd_Basic(Vector512<uint> data0, Vector512<uint> data1) {
                UnsafeUtil.SkipInit(out Vector512<uint> y1);
                Span<Vector512<uint>> src = [data0, data1];
                ref uint py = ref Unsafe.As<Vector512<uint>, uint>(ref y1);
                Span<uint> p = MemoryMarshal.Cast<Vector512<uint>, uint>(src);
                int idx = 1;
                for (int i = 0; i < Vector512<uint>.Count; ++i) {
                    Unsafe.Add(ref py, i) = p[idx];
                    idx += 2;
                }
                return y1;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup2UnzipOdd_Basic(Vector512<long> data0, Vector512<long> data1) {
                return YGroup2UnzipOdd_Basic(data0.AsUInt64(), data1.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup2UnzipOdd_Basic(Vector512<ulong> data0, Vector512<ulong> data1) {
                UnsafeUtil.SkipInit(out Vector512<ulong> y1);
                Span<Vector512<ulong>> src = [data0, data1];
                ref ulong py = ref Unsafe.As<Vector512<ulong>, ulong>(ref y1);
                Span<ulong> p = MemoryMarshal.Cast<Vector512<ulong>, ulong>(src);
                int idx = 1;
                for (int i = 0; i < Vector512<ulong>.Count; ++i) {
                    Unsafe.Add(ref py, i) = p[idx];
                    idx += 2;
                }
                return y1;
            }

#if VECTOR_HAS_METHOD

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup2UnzipOdd_Narrow(Vector512<float> data0, Vector512<float> data1) {
                return YGroup2UnzipOdd_Narrow(data0.AsUInt32(), data1.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup2UnzipOdd_Narrow(Vector512<sbyte> data0, Vector512<sbyte> data1) {
                return YGroup2UnzipOdd_Narrow(data0.AsByte(), data1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup2UnzipOdd_Narrow(Vector512<byte> data0, Vector512<byte> data1) {
                const int L = 8;
                Vector512<byte> rt0, rt1;
                Vector512<ushort> temp0 = data0.AsUInt16();
                Vector512<ushort> temp1 = data1.AsUInt16();
                if (BitConverter.IsLittleEndian) {
                    temp0 = Vector512.ShiftRightLogical(temp0, L);
                    temp1 = Vector512.ShiftRightLogical(temp1, L);
                    rt1 = Vector512.Narrow(temp0, temp1);
                    return rt1;
                } else {
                    rt0 = Vector512.Narrow(temp0, temp1);
                    return rt0;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup2UnzipOdd_Narrow(Vector512<short> data0, Vector512<short> data1) {
                return YGroup2UnzipOdd_Narrow(data0.AsUInt16(), data1.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup2UnzipOdd_Narrow(Vector512<ushort> data0, Vector512<ushort> data1) {
                const int L = 16;
                Vector512<ushort> rt0, rt1;
                Vector512<uint> temp0 = data0.AsUInt32();
                Vector512<uint> temp1 = data1.AsUInt32();
                if (BitConverter.IsLittleEndian) {
                    temp0 = Vector512.ShiftRightLogical(temp0, L);
                    temp1 = Vector512.ShiftRightLogical(temp1, L);
                    rt1 = Vector512.Narrow(temp0, temp1);
                    return rt1;
                } else {
                    rt0 = Vector512.Narrow(temp0, temp1);
                    return rt0;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup2UnzipOdd_Narrow(Vector512<int> data0, Vector512<int> data1) {
                return YGroup2UnzipOdd_Narrow(data0.AsUInt32(), data1.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup2UnzipOdd_Narrow(Vector512<uint> data0, Vector512<uint> data1) {
                const int L = 32;
                Vector512<uint> rt0, rt1;
                Vector512<ulong> temp0 = data0.AsUInt64();
                Vector512<ulong> temp1 = data1.AsUInt64();
                if (BitConverter.IsLittleEndian) {
                    temp0 = Vector512.ShiftRightLogical(temp0, L);
                    temp1 = Vector512.ShiftRightLogical(temp1, L);
                    rt1 = Vector512.Narrow(temp0, temp1);
                    return rt1;
                } else {
                    rt0 = Vector512.Narrow(temp0, temp1);
                    return rt0;
                }
            }

#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2Zip_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt = TypeCodeFlagsUtil.Most32Types;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{float}, Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup2Zip(Vector512<float> x, Vector512<float> y, out Vector512<float> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup2Zip_Widen(x, y, out data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Zip_Basic(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{double}, Vector512{double}, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup2Zip(Vector512<double> x, Vector512<double> y, out Vector512<double> data1) {
                return YGroup2Zip_Basic(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup2Zip(Vector512<sbyte> x, Vector512<sbyte> y, out Vector512<sbyte> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup2Zip_Widen(x, y, out data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Zip_Basic(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{byte}, Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup2Zip(Vector512<byte> x, Vector512<byte> y, out Vector512<byte> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup2Zip_Widen(x, y, out data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Zip_Basic(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{short}, Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup2Zip(Vector512<short> x, Vector512<short> y, out Vector512<short> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup2Zip_Widen(x, y, out data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Zip_Basic(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{ushort}, Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup2Zip(Vector512<ushort> x, Vector512<ushort> y, out Vector512<ushort> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup2Zip_Widen(x, y, out data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Zip_Basic(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{int}, Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup2Zip(Vector512<int> x, Vector512<int> y, out Vector512<int> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup2Zip_Widen(x, y, out data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Zip_Basic(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{uint}, Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup2Zip(Vector512<uint> x, Vector512<uint> y, out Vector512<uint> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup2Zip_Widen(x, y, out data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Zip_Basic(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{long}, Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup2Zip(Vector512<long> x, Vector512<long> y, out Vector512<long> data1) {
                return YGroup2Zip_Basic(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{ulong}, Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup2Zip(Vector512<ulong> x, Vector512<ulong> y, out Vector512<ulong> data1) {
                return YGroup2Zip_Basic(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{ExInt128}, Vector512{ExInt128}, out Vector512{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExInt128> YGroup2Zip(Vector512<ExInt128> x, Vector512<ExInt128> y, out Vector512<ExInt128> data1) {
                return YGroup2Zip_Move(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{ExUInt128}, Vector512{ExUInt128}, out Vector512{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExUInt128> YGroup2Zip(Vector512<ExUInt128> x, Vector512<ExUInt128> y, out Vector512<ExUInt128> data1) {
                return YGroup2Zip_Move(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip_Bit128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<T> YGroup2Zip_Bit128<T>(Vector512<T> x, Vector512<T> y, out Vector512<T> data1) where T : struct {
#if EX_APPLY_GENERIC
                var d0 = YGroup2Zip_Move(x.ExAsExUInt128(), y.ExAsExUInt128(), out var d1);
                data1 = d1.ExAs<ExUInt128, T>();
                return d0.ExAs<ExUInt128, T>();
#else
                var a0 = x;
                var a1 = y;
                var b0 = a0.GetLower();
                var b1 = a0.GetUpper();
                var b2 = a1.GetLower();
                var b3 = a1.GetUpper();
                var c0 = b0.WithUpper(b2.GetLower()).ToVector512Unsafe().WithUpper(b0.GetUpper().ToVector256Unsafe().WithUpper(b2.GetUpper()));
                var c1 = b1.WithUpper(b3.GetLower()).ToVector512Unsafe().WithUpper(b1.GetUpper().ToVector256Unsafe().WithUpper(b3.GetUpper()));
                data1 = c1;
                return c0;
#endif // EX_APPLY_GENERIC
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{float}, Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup2Zip_Basic(Vector512<float> x, Vector512<float> y, out Vector512<float> data1) {
                var d0 = YGroup2Zip_Basic(x.AsUInt32(), y.AsUInt32(), out var d1);
                data1 = d1.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{double}, Vector512{double}, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup2Zip_Basic(Vector512<double> x, Vector512<double> y, out Vector512<double> data1) {
                var d0 = YGroup2Zip_Basic(x.AsUInt64(), y.AsUInt64(), out var d1);
                data1 = d1.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup2Zip_Basic(Vector512<sbyte> x, Vector512<sbyte> y, out Vector512<sbyte> data1) {
                var d0 = YGroup2Zip_Basic(x.AsByte(), y.AsByte(), out var d1);
                data1 = d1.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{byte}, Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup2Zip_Basic(Vector512<byte> x, Vector512<byte> y, out Vector512<byte> data1) {
                Span<Vector512<byte>> rt = stackalloc Vector512<byte>[2];
                ref byte px = ref Unsafe.As<Vector512<byte>, byte>(ref x);
                ref byte py = ref Unsafe.As<Vector512<byte>, byte>(ref y);
                Span<byte> q = MemoryMarshal.Cast<Vector512<byte>, byte>(rt);
                int idx = 0;
                for (int i = 0; i < Vector512<byte>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    idx += 2;
                }
                data1 = rt[1];
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{short}, Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup2Zip_Basic(Vector512<short> x, Vector512<short> y, out Vector512<short> data1) {
                var d0 = YGroup2Zip_Basic(x.AsUInt16(), y.AsUInt16(), out var d1);
                data1 = d1.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{ushort}, Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup2Zip_Basic(Vector512<ushort> x, Vector512<ushort> y, out Vector512<ushort> data1) {
                Span<Vector512<ushort>> rt = stackalloc Vector512<ushort>[2];
                ref ushort px = ref Unsafe.As<Vector512<ushort>, ushort>(ref x);
                ref ushort py = ref Unsafe.As<Vector512<ushort>, ushort>(ref y);
                Span<ushort> q = MemoryMarshal.Cast<Vector512<ushort>, ushort>(rt);
                int idx = 0;
                for (int i = 0; i < Vector512<ushort>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    idx += 2;
                }
                data1 = rt[1];
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{int}, Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup2Zip_Basic(Vector512<int> x, Vector512<int> y, out Vector512<int> data1) {
                var d0 = YGroup2Zip_Basic(x.AsUInt32(), y.AsUInt32(), out var d1);
                data1 = d1.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{uint}, Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup2Zip_Basic(Vector512<uint> x, Vector512<uint> y, out Vector512<uint> data1) {
                Span<Vector512<uint>> rt = stackalloc Vector512<uint>[2];
                ref uint px = ref Unsafe.As<Vector512<uint>, uint>(ref x);
                ref uint py = ref Unsafe.As<Vector512<uint>, uint>(ref y);
                Span<uint> q = MemoryMarshal.Cast<Vector512<uint>, uint>(rt);
                int idx = 0;
                for (int i = 0; i < Vector512<uint>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    idx += 2;
                }
                data1 = rt[1];
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{long}, Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup2Zip_Basic(Vector512<long> x, Vector512<long> y, out Vector512<long> data1) {
                var d0 = YGroup2Zip_Basic(x.AsUInt64(), y.AsUInt64(), out var d1);
                data1 = d1.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{ulong}, Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup2Zip_Basic(Vector512<ulong> x, Vector512<ulong> y, out Vector512<ulong> data1) {
                Span<Vector512<ulong>> rt = stackalloc Vector512<ulong>[2];
                ref ulong px = ref Unsafe.As<Vector512<ulong>, ulong>(ref x);
                ref ulong py = ref Unsafe.As<Vector512<ulong>, ulong>(ref y);
                Span<ulong> q = MemoryMarshal.Cast<Vector512<ulong>, ulong>(rt);
                int idx = 0;
                for (int i = 0; i < Vector512<ulong>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    idx += 2;
                }
                data1 = rt[1];
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{ExInt128}, Vector512{ExInt128}, out Vector512{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExInt128> YGroup2Zip_Basic(Vector512<ExInt128> x, Vector512<ExInt128> y, out Vector512<ExInt128> data1) {
                var d0 = YGroup2Zip_Basic(x.ExAsExUInt128(), y.ExAsExUInt128(), out var d1);
                data1 = d1.ExAsExInt128();
                return d0.ExAsExInt128();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{ExUInt128}, Vector512{ExUInt128}, out Vector512{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExUInt128> YGroup2Zip_Basic(Vector512<ExUInt128> x, Vector512<ExUInt128> y, out Vector512<ExUInt128> data1) {
                Span<Vector512<ExUInt128>> rt = stackalloc Vector512<ExUInt128>[2];
                ref ExUInt128 px = ref Unsafe.As<Vector512<ExUInt128>, ExUInt128>(ref x);
                ref ExUInt128 py = ref Unsafe.As<Vector512<ExUInt128>, ExUInt128>(ref y);
                Span<ExUInt128> q = MemoryMarshal.Cast<Vector512<ExUInt128>, ExUInt128>(rt);
                int idx = 0;
                for (int i = 0; i < Vector512s<ExUInt128>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    idx += 2;
                }
                data1 = rt[1];
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{ExInt128}, Vector512{ExInt128}, out Vector512{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExInt128> YGroup2Zip_Move(Vector512<ExInt128> x, Vector512<ExInt128> y, out Vector512<ExInt128> data1) {
                var d0 = YGroup2Zip_Move(x.ExAsExUInt128(), y.ExAsExUInt128(), out var d1);
                data1 = d1.ExAsExInt128();
                return d0.ExAsExInt128();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{ExUInt128}, Vector512{ExUInt128}, out Vector512{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExUInt128> YGroup2Zip_Move(Vector512<ExUInt128> x, Vector512<ExUInt128> y, out Vector512<ExUInt128> data1) {
                var a0 = x.ExAsUInt64();
                var a1 = y.ExAsUInt64();
                var b0 = a0.GetLower();
                var b1 = a0.GetUpper();
                var b2 = a1.GetLower();
                var b3 = a1.GetUpper();
                var c0 = b0.WithUpper(b2.GetLower()).ToVector512Unsafe().WithUpper(b0.GetUpper().ToVector256Unsafe().WithUpper(b2.GetUpper()));
                var c1 = b1.WithUpper(b3.GetLower()).ToVector512Unsafe().WithUpper(b1.GetUpper().ToVector256Unsafe().WithUpper(b3.GetUpper()));
                data1 = c1.ExAsExUInt128();
                return c0.ExAsExUInt128();
            }

#if VECTOR_HAS_METHOD

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{float}, Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup2Zip_Widen(Vector512<float> x, Vector512<float> y, out Vector512<float> data1) {
                var d0 = YGroup2Zip_Widen(x.AsUInt32(), y.AsUInt32(), out var d1);
                data1 = d1.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup2Zip_Widen(Vector512<sbyte> x, Vector512<sbyte> y, out Vector512<sbyte> data1) {
                var d0 = YGroup2Zip_Widen(x.AsByte(), y.AsByte(), out var d1);
                data1 = d1.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{byte}, Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup2Zip_Widen(Vector512<byte> x, Vector512<byte> y, out Vector512<byte> data1) {
                const int L = 8;
                Vector512<ushort> a0, a1, b0, b1;
                if (BitConverter.IsLittleEndian) {
                    (b0, b1) = Vector512.Widen(y);
                    (a0, a1) = Vector512.Widen(x);
                } else {
                    (b0, b1) = Vector512.Widen(x);
                    (a0, a1) = Vector512.Widen(y);
                }
                b0 = Vector512.ShiftLeft(b0, L);
                b1 = Vector512.ShiftLeft(b1, L);
                a0 = Vector512.BitwiseOr(a0, b0);
                a1 = Vector512.BitwiseOr(a1, b1);
                data1 = a1.AsByte();
                return a0.AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{short}, Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup2Zip_Widen(Vector512<short> x, Vector512<short> y, out Vector512<short> data1) {
                var d0 = YGroup2Zip_Widen(x.AsUInt16(), y.AsUInt16(), out var d1);
                data1 = d1.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{ushort}, Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup2Zip_Widen(Vector512<ushort> x, Vector512<ushort> y, out Vector512<ushort> data1) {
                const int L = 16;
                Vector512<uint> a0, a1, b0, b1;
                if (BitConverter.IsLittleEndian) {
                    (b0, b1) = Vector512.Widen(y);
                    (a0, a1) = Vector512.Widen(x);
                } else {
                    (b0, b1) = Vector512.Widen(x);
                    (a0, a1) = Vector512.Widen(y);
                }
                b0 = Vector512.ShiftLeft(b0, L);
                b1 = Vector512.ShiftLeft(b1, L);
                a0 = Vector512.BitwiseOr(a0, b0);
                a1 = Vector512.BitwiseOr(a1, b1);
                data1 = a1.AsUInt16();
                return a0.AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{int}, Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup2Zip_Widen(Vector512<int> x, Vector512<int> y, out Vector512<int> data1) {
                var d0 = YGroup2Zip_Widen(x.AsUInt32(), y.AsUInt32(), out var d1);
                data1 = d1.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{uint}, Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup2Zip_Widen(Vector512<uint> x, Vector512<uint> y, out Vector512<uint> data1) {
                const int L = 32;
                Vector512<ulong> a0, a1, b0, b1;
                if (BitConverter.IsLittleEndian) {
                    (b0, b1) = Vector512.Widen(y);
                    (a0, a1) = Vector512.Widen(x);
                } else {
                    (b0, b1) = Vector512.Widen(x);
                    (a0, a1) = Vector512.Widen(y);
                }
                b0 = Vector512.ShiftLeft(b0, L);
                b1 = Vector512.ShiftLeft(b1, L);
                a0 = Vector512.BitwiseOr(a0, b0);
                a1 = Vector512.BitwiseOr(a1, b1);
                data1 = a1.AsUInt32();
                return a0.AsUInt32();
            }

#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2ZipHigh_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt = TypeCodeFlagsUtil.Most32Types;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup2ZipHigh(Vector512<float> x, Vector512<float> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup2ZipHigh_Widen(x, y);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipHigh_Basic(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup2ZipHigh(Vector512<double> x, Vector512<double> y) {
                return YGroup2ZipHigh_Basic(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup2ZipHigh(Vector512<sbyte> x, Vector512<sbyte> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup2ZipHigh_Widen(x, y);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipHigh_Basic(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup2ZipHigh(Vector512<byte> x, Vector512<byte> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup2ZipHigh_Widen(x, y);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipHigh_Basic(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup2ZipHigh(Vector512<short> x, Vector512<short> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup2ZipHigh_Widen(x, y);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipHigh_Basic(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup2ZipHigh(Vector512<ushort> x, Vector512<ushort> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup2ZipHigh_Widen(x, y);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipHigh_Basic(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup2ZipHigh(Vector512<int> x, Vector512<int> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup2ZipHigh_Widen(x, y);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipHigh_Basic(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup2ZipHigh(Vector512<uint> x, Vector512<uint> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup2ZipHigh_Widen(x, y);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipHigh_Basic(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup2ZipHigh(Vector512<long> x, Vector512<long> y) {
                return YGroup2ZipHigh_Basic(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup2ZipHigh(Vector512<ulong> x, Vector512<ulong> y) {
                return YGroup2ZipHigh_Basic(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{ExInt128}, Vector512{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExInt128> YGroup2ZipHigh(Vector512<ExInt128> x, Vector512<ExInt128> y) {
                return YGroup2ZipHigh(x.ExAsExUInt128(), y.ExAsExUInt128()).ExAsExInt128();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{ExUInt128}, Vector512{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExUInt128> YGroup2ZipHigh(Vector512<ExUInt128> x, Vector512<ExUInt128> y) {
                var a0 = x.ExAsUInt64();
                var a1 = y.ExAsUInt64();
                var b0 = a0.GetLower();
                var b1 = a0.GetUpper();
                var b2 = a1.GetLower();
                var b3 = a1.GetUpper();
                var c1 = b1.WithUpper(b3.GetLower()).ToVector512Unsafe().WithUpper(b1.GetUpper().ToVector256Unsafe().WithUpper(b3.GetUpper()));
                return c1.ExAsExUInt128();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup2ZipHigh_Basic(Vector512<float> x, Vector512<float> y) {
                return YGroup2ZipHigh_Basic(x.AsUInt32(), y.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup2ZipHigh_Basic(Vector512<double> x, Vector512<double> y) {
                return YGroup2ZipHigh_Basic(x.AsUInt64(), y.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup2ZipHigh_Basic(Vector512<sbyte> x, Vector512<sbyte> y) {
                return YGroup2ZipHigh_Basic(x.AsByte(), y.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup2ZipHigh_Basic(Vector512<byte> x, Vector512<byte> y) {
                Span<Vector512<byte>> rt = stackalloc Vector512<byte>[1];
                ref byte px = ref Unsafe.As<Vector512<byte>, byte>(ref x);
                ref byte py = ref Unsafe.As<Vector512<byte>, byte>(ref y);
                Span<byte> q = MemoryMarshal.Cast<Vector512<byte>, byte>(rt);
                int idx = 0;
                for (int i = Vector512<byte>.Count / 2; idx < Vector512<byte>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    idx += 2;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup2ZipHigh_Basic(Vector512<short> x, Vector512<short> y) {
                return YGroup2ZipHigh_Basic(x.AsUInt16(), y.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup2ZipHigh_Basic(Vector512<ushort> x, Vector512<ushort> y) {
                Span<Vector512<ushort>> rt = stackalloc Vector512<ushort>[1];
                ref ushort px = ref Unsafe.As<Vector512<ushort>, ushort>(ref x);
                ref ushort py = ref Unsafe.As<Vector512<ushort>, ushort>(ref y);
                Span<ushort> q = MemoryMarshal.Cast<Vector512<ushort>, ushort>(rt);
                int idx = 0;
                for (int i = Vector512<ushort>.Count / 2; idx < Vector512<ushort>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    idx += 2;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup2ZipHigh_Basic(Vector512<int> x, Vector512<int> y) {
                return YGroup2ZipHigh_Basic(x.AsUInt32(), y.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup2ZipHigh_Basic(Vector512<uint> x, Vector512<uint> y) {
                Span<Vector512<uint>> rt = stackalloc Vector512<uint>[1];
                ref uint px = ref Unsafe.As<Vector512<uint>, uint>(ref x);
                ref uint py = ref Unsafe.As<Vector512<uint>, uint>(ref y);
                Span<uint> q = MemoryMarshal.Cast<Vector512<uint>, uint>(rt);
                int idx = 0;
                for (int i = Vector512<uint>.Count / 2; idx < Vector512<uint>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    idx += 2;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup2ZipHigh_Basic(Vector512<long> x, Vector512<long> y) {
                return YGroup2ZipHigh_Basic(x.AsUInt64(), y.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup2ZipHigh_Basic(Vector512<ulong> x, Vector512<ulong> y) {
                Span<Vector512<ulong>> rt = stackalloc Vector512<ulong>[1];
                ref ulong px = ref Unsafe.As<Vector512<ulong>, ulong>(ref x);
                ref ulong py = ref Unsafe.As<Vector512<ulong>, ulong>(ref y);
                Span<ulong> q = MemoryMarshal.Cast<Vector512<ulong>, ulong>(rt);
                int idx = 0;
                for (int i = Vector512<ulong>.Count / 2; idx < Vector512<ulong>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    idx += 2;
                }
                return rt[0];
            }

#if VECTOR_HAS_METHOD

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup2ZipHigh_Widen(Vector512<float> x, Vector512<float> y) {
                return YGroup2ZipHigh_Widen(x.AsUInt32(), y.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup2ZipHigh_Widen(Vector512<sbyte> x, Vector512<sbyte> y) {
                return YGroup2ZipHigh_Widen(x.AsByte(), y.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup2ZipHigh_Widen(Vector512<byte> x, Vector512<byte> y) {
                const int L = 8;
                Vector512<ushort> a1, b1;
                if (BitConverter.IsLittleEndian) {
                    (_, b1) = Vector512.Widen(y);
                    (_, a1) = Vector512.Widen(x);
                } else {
                    (_, b1) = Vector512.Widen(x);
                    (_, a1) = Vector512.Widen(y);
                }
                b1 = Vector512.ShiftLeft(b1, L);
                a1 = Vector512.BitwiseOr(a1, b1);
                return a1.AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup2ZipHigh_Widen(Vector512<short> x, Vector512<short> y) {
                return YGroup2ZipHigh_Widen(x.AsUInt16(), y.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup2ZipHigh_Widen(Vector512<ushort> x, Vector512<ushort> y) {
                const int L = 16;
                Vector512<uint> a1, b1;
                if (BitConverter.IsLittleEndian) {
                    (_, b1) = Vector512.Widen(y);
                    (_, a1) = Vector512.Widen(x);
                } else {
                    (_, b1) = Vector512.Widen(x);
                    (_, a1) = Vector512.Widen(y);
                }
                b1 = Vector512.ShiftLeft(b1, L);
                a1 = Vector512.BitwiseOr(a1, b1);
                return a1.AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup2ZipHigh_Widen(Vector512<int> x, Vector512<int> y) {
                return YGroup2ZipHigh_Widen(x.AsUInt32(), y.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup2ZipHigh_Widen(Vector512<uint> x, Vector512<uint> y) {
                const int L = 32;
                Vector512<ulong> a1, b1;
                if (BitConverter.IsLittleEndian) {
                    (_, b1) = Vector512.Widen(y);
                    (_, a1) = Vector512.Widen(x);
                } else {
                    (_, b1) = Vector512.Widen(x);
                    (_, a1) = Vector512.Widen(y);
                }
                b1 = Vector512.ShiftLeft(b1, L);
                a1 = Vector512.BitwiseOr(a1, b1);
                return a1.AsUInt32();
            }

#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2ZipLow_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt = TypeCodeFlagsUtil.Most32Types;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup2ZipLow(Vector512<float> x, Vector512<float> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup2ZipLow_Widen(x, y);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipLow_Basic(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup2ZipLow(Vector512<double> x, Vector512<double> y) {
                return YGroup2ZipLow_Basic(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup2ZipLow(Vector512<sbyte> x, Vector512<sbyte> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup2ZipLow_Widen(x, y);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipLow_Basic(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup2ZipLow(Vector512<byte> x, Vector512<byte> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup2ZipLow_Widen(x, y);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipLow_Basic(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup2ZipLow(Vector512<short> x, Vector512<short> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup2ZipLow_Widen(x, y);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipLow_Basic(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup2ZipLow(Vector512<ushort> x, Vector512<ushort> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup2ZipLow_Widen(x, y);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipLow_Basic(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup2ZipLow(Vector512<int> x, Vector512<int> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup2ZipLow_Widen(x, y);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipLow_Basic(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup2ZipLow(Vector512<uint> x, Vector512<uint> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup2ZipLow_Widen(x, y);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipLow_Basic(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup2ZipLow(Vector512<long> x, Vector512<long> y) {
                return YGroup2ZipLow_Basic(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup2ZipLow(Vector512<ulong> x, Vector512<ulong> y) {
                return YGroup2ZipLow_Basic(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{ExInt128}, Vector512{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExInt128> YGroup2ZipLow(Vector512<ExInt128> x, Vector512<ExInt128> y) {
                return YGroup2ZipLow(x.ExAsExUInt128(), y.ExAsExUInt128()).ExAsExInt128();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{ExUInt128}, Vector512{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExUInt128> YGroup2ZipLow(Vector512<ExUInt128> x, Vector512<ExUInt128> y) {
                var a0 = x.ExAsUInt64();
                var a1 = y.ExAsUInt64();
                var b0 = a0.GetLower();
                var b1 = a0.GetUpper();
                var b2 = a1.GetLower();
                var b3 = a1.GetUpper();
                var c0 = b0.WithUpper(b2.GetLower()).ToVector512Unsafe().WithUpper(b0.GetUpper().ToVector256Unsafe().WithUpper(b2.GetUpper()));
                return c0.ExAsExUInt128();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup2ZipLow_Basic(Vector512<float> x, Vector512<float> y) {
                return YGroup2ZipLow_Basic(x.AsUInt32(), y.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup2ZipLow_Basic(Vector512<double> x, Vector512<double> y) {
                return YGroup2ZipLow_Basic(x.AsUInt64(), y.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup2ZipLow_Basic(Vector512<sbyte> x, Vector512<sbyte> y) {
                return YGroup2ZipLow_Basic(x.AsByte(), y.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup2ZipLow_Basic(Vector512<byte> x, Vector512<byte> y) {
                Span<Vector512<byte>> rt = stackalloc Vector512<byte>[1];
                ref byte px = ref Unsafe.As<Vector512<byte>, byte>(ref x);
                ref byte py = ref Unsafe.As<Vector512<byte>, byte>(ref y);
                Span<byte> q = MemoryMarshal.Cast<Vector512<byte>, byte>(rt);
                int idx = 0;
                for (int i = 0; idx < Vector512<byte>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    idx += 2;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup2ZipLow_Basic(Vector512<short> x, Vector512<short> y) {
                return YGroup2ZipLow_Basic(x.AsUInt16(), y.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup2ZipLow_Basic(Vector512<ushort> x, Vector512<ushort> y) {
                Span<Vector512<ushort>> rt = stackalloc Vector512<ushort>[1];
                ref ushort px = ref Unsafe.As<Vector512<ushort>, ushort>(ref x);
                ref ushort py = ref Unsafe.As<Vector512<ushort>, ushort>(ref y);
                Span<ushort> q = MemoryMarshal.Cast<Vector512<ushort>, ushort>(rt);
                int idx = 0;
                for (int i = 0; idx < Vector512<ushort>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    idx += 2;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup2ZipLow_Basic(Vector512<int> x, Vector512<int> y) {
                return YGroup2ZipLow_Basic(x.AsUInt32(), y.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup2ZipLow_Basic(Vector512<uint> x, Vector512<uint> y) {
                Span<Vector512<uint>> rt = stackalloc Vector512<uint>[1];
                ref uint px = ref Unsafe.As<Vector512<uint>, uint>(ref x);
                ref uint py = ref Unsafe.As<Vector512<uint>, uint>(ref y);
                Span<uint> q = MemoryMarshal.Cast<Vector512<uint>, uint>(rt);
                int idx = 0;
                for (int i = 0; idx < Vector512<uint>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    idx += 2;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup2ZipLow_Basic(Vector512<long> x, Vector512<long> y) {
                return YGroup2ZipLow_Basic(x.AsUInt64(), y.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup2ZipLow_Basic(Vector512<ulong> x, Vector512<ulong> y) {
                Span<Vector512<ulong>> rt = stackalloc Vector512<ulong>[1];
                ref ulong px = ref Unsafe.As<Vector512<ulong>, ulong>(ref x);
                ref ulong py = ref Unsafe.As<Vector512<ulong>, ulong>(ref y);
                Span<ulong> q = MemoryMarshal.Cast<Vector512<ulong>, ulong>(rt);
                int idx = 0;
                for (int i = 0; idx < Vector512<ulong>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    idx += 2;
                }
                return rt[0];
            }

#if VECTOR_HAS_METHOD

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup2ZipLow_Widen(Vector512<float> x, Vector512<float> y) {
                return YGroup2ZipLow_Widen(x.AsUInt32(), y.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup2ZipLow_Widen(Vector512<sbyte> x, Vector512<sbyte> y) {
                return YGroup2ZipLow_Widen(x.AsByte(), y.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup2ZipLow_Widen(Vector512<byte> x, Vector512<byte> y) {
                const int L = 8;
                Vector512<ushort> a0, b0;
                if (BitConverter.IsLittleEndian) {
                    (b0, _) = Vector512.Widen(y);
                    (a0, _) = Vector512.Widen(x);
                } else {
                    (b0, _) = Vector512.Widen(x);
                    (a0, _) = Vector512.Widen(y);
                }
                b0 = Vector512.ShiftLeft(b0, L);
                a0 = Vector512.BitwiseOr(a0, b0);
                return a0.AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup2ZipLow_Widen(Vector512<short> x, Vector512<short> y) {
                return YGroup2ZipLow_Widen(x.AsUInt16(), y.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup2ZipLow_Widen(Vector512<ushort> x, Vector512<ushort> y) {
                const int L = 16;
                Vector512<uint> a0, b0;
                if (BitConverter.IsLittleEndian) {
                    (b0, _) = Vector512.Widen(y);
                    (a0, _) = Vector512.Widen(x);
                } else {
                    (b0, _) = Vector512.Widen(x);
                    (a0, _) = Vector512.Widen(y);
                }
                b0 = Vector512.ShiftLeft(b0, L);
                a0 = Vector512.BitwiseOr(a0, b0);
                return a0.AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup2ZipLow_Widen(Vector512<int> x, Vector512<int> y) {
                return YGroup2ZipLow_Widen(x.AsUInt32(), y.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup2ZipLow_Widen(Vector512<uint> x, Vector512<uint> y) {
                const int L = 32;
                Vector512<ulong> a0, b0;
                if (BitConverter.IsLittleEndian) {
                    (b0, _) = Vector512.Widen(y);
                    (a0, _) = Vector512.Widen(x);
                } else {
                    (b0, _) = Vector512.Widen(x);
                    (a0, _) = Vector512.Widen(y);
                }
                b0 = Vector512.ShiftLeft(b0, L);
                a0 = Vector512.BitwiseOr(a0, b0);
                return a0.AsUInt32();
            }

#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits512.YGroup3ToGroup4_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup3ToGroup4_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt = TypeCodeFlags.Byte | TypeCodeFlags.SByte;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ToGroup4(Vector512{float}, Vector512{float}, Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup3ToGroup4(Vector512<float> data0, Vector512<float> data1, Vector512<float> data2, out Vector512<float> result1, out Vector512<float> result2, out Vector512<float> result3) {
                var d0 = YGroup3ToGroup4(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), out var d1, out var d2, out var d3);
                result1 = d1.AsSingle();
                result2 = d2.AsSingle();
                result3 = d3.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ToGroup4(Vector512{double}, Vector512{double}, Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup3ToGroup4(Vector512<double> data0, Vector512<double> data1, Vector512<double> data2, out Vector512<double> result1, out Vector512<double> result2, out Vector512<double> result3) {
                var d0 = YGroup3ToGroup4(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), out var d1, out var d2, out var d3);
                result1 = d1.AsDouble();
                result2 = d2.AsDouble();
                result3 = d3.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ToGroup4(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup3ToGroup4(Vector512<sbyte> data0, Vector512<sbyte> data1, Vector512<sbyte> data2, out Vector512<sbyte> result1, out Vector512<sbyte> result2, out Vector512<sbyte> result3) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup3ToGroup4_Unzip(data0, data1, data2, out result1, out result2, out result3);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3ToGroup4_Basic(data0, data1, data2, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ToGroup4(Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup3ToGroup4(Vector512<byte> data0, Vector512<byte> data1, Vector512<byte> data2, out Vector512<byte> result1, out Vector512<byte> result2, out Vector512<byte> result3) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup3ToGroup4_Unzip(data0, data1, data2, out result1, out result2, out result3);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3ToGroup4_Basic(data0, data1, data2, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ToGroup4(Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup3ToGroup4(Vector512<short> data0, Vector512<short> data1, Vector512<short> data2, out Vector512<short> result1, out Vector512<short> result2, out Vector512<short> result3) {
                return YGroup3ToGroup4_Basic(data0, data1, data2, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ToGroup4(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup3ToGroup4(Vector512<ushort> data0, Vector512<ushort> data1, Vector512<ushort> data2, out Vector512<ushort> result1, out Vector512<ushort> result2, out Vector512<ushort> result3) {
                return YGroup3ToGroup4_Basic(data0, data1, data2, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ToGroup4(Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup3ToGroup4(Vector512<int> data0, Vector512<int> data1, Vector512<int> data2, out Vector512<int> result1, out Vector512<int> result2, out Vector512<int> result3) {
                return YGroup3ToGroup4_Basic(data0, data1, data2, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ToGroup4(Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup3ToGroup4(Vector512<uint> data0, Vector512<uint> data1, Vector512<uint> data2, out Vector512<uint> result1, out Vector512<uint> result2, out Vector512<uint> result3) {
                return YGroup3ToGroup4_Basic(data0, data1, data2, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ToGroup4(Vector512{long}, Vector512{long}, Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup3ToGroup4(Vector512<long> data0, Vector512<long> data1, Vector512<long> data2, out Vector512<long> result1, out Vector512<long> result2, out Vector512<long> result3) {
                return YGroup3ToGroup4_Basic(data0, data1, data2, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ToGroup4(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup3ToGroup4(Vector512<ulong> data0, Vector512<ulong> data1, Vector512<ulong> data2, out Vector512<ulong> result1, out Vector512<ulong> result2, out Vector512<ulong> result3) {
                return YGroup3ToGroup4_Basic(data0, data1, data2, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ToGroup4(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup3ToGroup4_Basic(Vector512<sbyte> data0, Vector512<sbyte> data1, Vector512<sbyte> data2, out Vector512<sbyte> result1, out Vector512<sbyte> result2, out Vector512<sbyte> result3) {
                var d0 = YGroup3ToGroup4_Basic(data0.AsByte(), data1.AsByte(), data2.AsByte(), out var d1, out var d2, out var d3);
                result1 = d1.AsSByte();
                result2 = d2.AsSByte();
                result3 = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ToGroup4(Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup3ToGroup4_Basic(Vector512<byte> data0, Vector512<byte> data1, Vector512<byte> data2, out Vector512<byte> result1, out Vector512<byte> result2, out Vector512<byte> result3) {
                const byte zero = 0;
                Span<Vector512<byte>> src = [data0, data1, data2];
                Span<Vector512<byte>> dst = stackalloc Vector512<byte>[4];
                Span<byte> p = MemoryMarshal.Cast<Vector512<byte>, byte>(src);
                Span<byte> q = MemoryMarshal.Cast<Vector512<byte>, byte>(dst);
                for (int i = 0; i < Vector512<byte>.Count; ++i) {
                    q[0] = p[0];
                    q[1] = p[1];
                    q[2] = p[2];
                    q[3] = zero;
                    p = p.Slice(3);
                    q = q.Slice(4);
                }
                result1 = dst[1];
                result2 = dst[2];
                result3 = dst[3];
                return dst[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ToGroup4(Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup3ToGroup4_Basic(Vector512<short> data0, Vector512<short> data1, Vector512<short> data2, out Vector512<short> result1, out Vector512<short> result2, out Vector512<short> result3) {
                var d0 = YGroup3ToGroup4_Basic(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), out var d1, out var d2, out var d3);
                result1 = d1.AsInt16();
                result2 = d2.AsInt16();
                result3 = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ToGroup4(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup3ToGroup4_Basic(Vector512<ushort> data0, Vector512<ushort> data1, Vector512<ushort> data2, out Vector512<ushort> result1, out Vector512<ushort> result2, out Vector512<ushort> result3) {
                const ushort zero = 0;
                Span<Vector512<ushort>> src = [data0, data1, data2];
                Span<Vector512<ushort>> dst = stackalloc Vector512<ushort>[4];
                Span<ushort> p = MemoryMarshal.Cast<Vector512<ushort>, ushort>(src);
                Span<ushort> q = MemoryMarshal.Cast<Vector512<ushort>, ushort>(dst);
                for (int i = 0; i < Vector512<ushort>.Count; ++i) {
                    q[0] = p[0];
                    q[1] = p[1];
                    q[2] = p[2];
                    q[3] = zero;
                    p = p.Slice(3);
                    q = q.Slice(4);
                }
                result1 = dst[1];
                result2 = dst[2];
                result3 = dst[3];
                return dst[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ToGroup4(Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup3ToGroup4_Basic(Vector512<int> data0, Vector512<int> data1, Vector512<int> data2, out Vector512<int> result1, out Vector512<int> result2, out Vector512<int> result3) {
                var d0 = YGroup3ToGroup4_Basic(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), out var d1, out var d2, out var d3);
                result1 = d1.AsInt32();
                result2 = d2.AsInt32();
                result3 = d3.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ToGroup4(Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup3ToGroup4_Basic(Vector512<uint> data0, Vector512<uint> data1, Vector512<uint> data2, out Vector512<uint> result1, out Vector512<uint> result2, out Vector512<uint> result3) {
                const uint zero = 0;
                Span<Vector512<uint>> src = [data0, data1, data2];
                Span<Vector512<uint>> dst = stackalloc Vector512<uint>[4];
                Span<uint> p = MemoryMarshal.Cast<Vector512<uint>, uint>(src);
                Span<uint> q = MemoryMarshal.Cast<Vector512<uint>, uint>(dst);
                for (int i = 0; i < Vector512<uint>.Count; ++i) {
                    q[0] = p[0];
                    q[1] = p[1];
                    q[2] = p[2];
                    q[3] = zero;
                    p = p.Slice(3);
                    q = q.Slice(4);
                }
                result1 = dst[1];
                result2 = dst[2];
                result3 = dst[3];
                //Console.WriteLine(VectorTextUtil.Format("Basic f({0}, {1}, {2}): {3}, {4}, {5}, {6}", data0, data1, data2, dst[0], result1, result2, result3));
                return dst[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ToGroup4(Vector512{long}, Vector512{long}, Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup3ToGroup4_Basic(Vector512<long> data0, Vector512<long> data1, Vector512<long> data2, out Vector512<long> result1, out Vector512<long> result2, out Vector512<long> result3) {
                var d0 = YGroup3ToGroup4_Basic(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), out var d1, out var d2, out var d3);
                result1 = d1.AsInt64();
                result2 = d2.AsInt64();
                result3 = d3.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ToGroup4(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup3ToGroup4_Basic(Vector512<ulong> data0, Vector512<ulong> data1, Vector512<ulong> data2, out Vector512<ulong> result1, out Vector512<ulong> result2, out Vector512<ulong> result3) {
                const ulong zero = 0;
                Span<Vector512<ulong>> src = [data0, data1, data2];
                Span<Vector512<ulong>> dst = stackalloc Vector512<ulong>[4];
                Span<ulong> p = MemoryMarshal.Cast<Vector512<ulong>, ulong>(src);
                Span<ulong> q = MemoryMarshal.Cast<Vector512<ulong>, ulong>(dst);
                for (int i = 0; i < Vector512<ulong>.Count; ++i) {
                    q[0] = p[0];
                    q[1] = p[1];
                    q[2] = p[2];
                    q[3] = zero;
                    p = p.Slice(3);
                    q = q.Slice(4);
                }
                result1 = dst[1];
                result2 = dst[2];
                result3 = dst[3];
                return dst[0];
            }

#if VECTOR_HAS_METHOD

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ToGroup4(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup3ToGroup4_Shuffle(Vector512<sbyte> data0, Vector512<sbyte> data1, Vector512<sbyte> data2, out Vector512<sbyte> result1, out Vector512<sbyte> result2, out Vector512<sbyte> result3) {
                var d0 = YGroup3ToGroup4_Shuffle(data0.AsByte(), data1.AsByte(), data2.AsByte(), out var d1, out var d2, out var d3);
                result1 = d1.AsSByte();
                result2 = d2.AsSByte();
                result3 = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ToGroup4(Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup3ToGroup4_Shuffle(Vector512<byte> data0, Vector512<byte> data1, Vector512<byte> data2, out Vector512<byte> result1, out Vector512<byte> result2, out Vector512<byte> result3) {
                var maskXYZ = Vector512Constants.YGroup4_MaskXYZ_Byte;
                var f0 = Vector512Constants.YGroup3ToGroup4_Shuffle_Byte_0;
                var f1A = Vector512Constants.YGroup3ToGroup4_Shuffle_Byte_1A;
                var f1B = Vector512Constants.YGroup3ToGroup4_Shuffle_Byte_1B;
                var f2A = Vector512Constants.YGroup3ToGroup4_Shuffle_Byte_2A;
                var f2B = Vector512Constants.YGroup3ToGroup4_Shuffle_Byte_2B;
                var f3 = Vector512Constants.YGroup3ToGroup4_Shuffle_Byte_3;
                var a_0 = Vector512.BitwiseAnd(Vector512.Shuffle(data0, f0), maskXYZ);
                var a_1 = Vector512.BitwiseAnd(Vector512.BitwiseOr(Vector512.Shuffle(data0, f1A), Vector512.Shuffle(data1, f1B)), maskXYZ);
                var a_2 = Vector512.BitwiseAnd(Vector512.BitwiseOr(Vector512.Shuffle(data1, f2A), Vector512.Shuffle(data2, f2B)), maskXYZ);
                var a_3 = Vector512.BitwiseAnd(Vector512.Shuffle(data2, f3), maskXYZ);
                result1 = a_1;
                result2 = a_2;
                result3 = a_3;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ToGroup4(Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup3ToGroup4_Shuffle(Vector512<short> data0, Vector512<short> data1, Vector512<short> data2, out Vector512<short> result1, out Vector512<short> result2, out Vector512<short> result3) {
                var d0 = YGroup3ToGroup4_Shuffle(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), out var d1, out var d2, out var d3);
                result1 = d1.AsInt16();
                result2 = d2.AsInt16();
                result3 = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ToGroup4(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup3ToGroup4_Shuffle(Vector512<ushort> data0, Vector512<ushort> data1, Vector512<ushort> data2, out Vector512<ushort> result1, out Vector512<ushort> result2, out Vector512<ushort> result3) {
                var maskXYZ = Vector512Constants.YGroup4_MaskXYZ_UInt16;
                var f0 = Vector512Constants.YGroup3ToGroup4_ShuffleOnByte_UInt16_0;
                var f1A = Vector512Constants.YGroup3ToGroup4_ShuffleOnByte_UInt16_1A;
                var f1B = Vector512Constants.YGroup3ToGroup4_ShuffleOnByte_UInt16_1B;
                var f2A = Vector512Constants.YGroup3ToGroup4_ShuffleOnByte_UInt16_2A;
                var f2B = Vector512Constants.YGroup3ToGroup4_ShuffleOnByte_UInt16_2B;
                var f3 = Vector512Constants.YGroup3ToGroup4_ShuffleOnByte_UInt16_3;
                var s0 = data0.AsByte();
                var s1 = data1.AsByte();
                var s2 = data2.AsByte();
                var a_0 = Vector512.BitwiseAnd(Vector512.Shuffle(s0, f0).AsUInt16(), maskXYZ);
                var a_1 = Vector512.BitwiseAnd(Vector512.BitwiseOr(Vector512.Shuffle(s0, f1A), Vector512.Shuffle(s1, f1B)).AsUInt16(), maskXYZ);
                var a_2 = Vector512.BitwiseAnd(Vector512.BitwiseOr(Vector512.Shuffle(s1, f2A), Vector512.Shuffle(s2, f2B)).AsUInt16(), maskXYZ);
                var a_3 = Vector512.BitwiseAnd(Vector512.Shuffle(s2, f3).AsUInt16(), maskXYZ);
                result1 = a_1;
                result2 = a_2;
                result3 = a_3;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ToGroup4(Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup3ToGroup4_Shuffle(Vector512<int> data0, Vector512<int> data1, Vector512<int> data2, out Vector512<int> result1, out Vector512<int> result2, out Vector512<int> result3) {
                var d0 = YGroup3ToGroup4_Shuffle(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), out var d1, out var d2, out var d3);
                result1 = d1.AsInt32();
                result2 = d2.AsInt32();
                result3 = d3.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ToGroup4(Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup3ToGroup4_Shuffle(Vector512<uint> data0, Vector512<uint> data1, Vector512<uint> data2, out Vector512<uint> result1, out Vector512<uint> result2, out Vector512<uint> result3) {
                var maskXYZ = Vector512Constants.YGroup4_MaskXYZ_UInt32;
                var f0 = Vector512Constants.YGroup3ToGroup4_ShuffleOnByte_UInt32_0;
                var f1A = Vector512Constants.YGroup3ToGroup4_ShuffleOnByte_UInt32_1A;
                var f1B = Vector512Constants.YGroup3ToGroup4_ShuffleOnByte_UInt32_1B;
                var f2A = Vector512Constants.YGroup3ToGroup4_ShuffleOnByte_UInt32_2A;
                var f2B = Vector512Constants.YGroup3ToGroup4_ShuffleOnByte_UInt32_2B;
                var f3 = Vector512Constants.YGroup3ToGroup4_ShuffleOnByte_UInt32_3;
                var s0 = data0.AsByte();
                var s1 = data1.AsByte();
                var s2 = data2.AsByte();
                var a_0 = Vector512.BitwiseAnd(Vector512.Shuffle(s0, f0).AsUInt32(), maskXYZ);
                var a_1 = Vector512.BitwiseAnd(Vector512.BitwiseOr(Vector512.Shuffle(s0, f1A), Vector512.Shuffle(s1, f1B)).AsUInt32(), maskXYZ);
                var a_2 = Vector512.BitwiseAnd(Vector512.BitwiseOr(Vector512.Shuffle(s1, f2A), Vector512.Shuffle(s2, f2B)).AsUInt32(), maskXYZ);
                var a_3 = Vector512.BitwiseAnd(Vector512.Shuffle(s2, f3).AsUInt32(), maskXYZ);
                result1 = a_1;
                result2 = a_2;
                result3 = a_3;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ToGroup4(Vector512{long}, Vector512{long}, Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup3ToGroup4_Shuffle(Vector512<long> data0, Vector512<long> data1, Vector512<long> data2, out Vector512<long> result1, out Vector512<long> result2, out Vector512<long> result3) {
                var d0 = YGroup3ToGroup4_Shuffle(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), out var d1, out var d2, out var d3);
                result1 = d1.AsInt64();
                result2 = d2.AsInt64();
                result3 = d3.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ToGroup4(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup3ToGroup4_Shuffle(Vector512<ulong> data0, Vector512<ulong> data1, Vector512<ulong> data2, out Vector512<ulong> result1, out Vector512<ulong> result2, out Vector512<ulong> result3) {
                var maskXYZ = Vector512Constants.YGroup4_MaskXYZ_UInt64;
                var f0 = Vector512Constants.YGroup3ToGroup4_ShuffleOnByte_UInt64_0;
                var f1A = Vector512Constants.YGroup3ToGroup4_ShuffleOnByte_UInt64_1A;
                var f1B = Vector512Constants.YGroup3ToGroup4_ShuffleOnByte_UInt64_1B;
                var f2A = Vector512Constants.YGroup3ToGroup4_ShuffleOnByte_UInt64_2A;
                var f2B = Vector512Constants.YGroup3ToGroup4_ShuffleOnByte_UInt64_2B;
                var f3 = Vector512Constants.YGroup3ToGroup4_ShuffleOnByte_UInt64_3;
                var s0 = data0.AsByte();
                var s1 = data1.AsByte();
                var s2 = data2.AsByte();
                var a_0 = Vector512.BitwiseAnd(Vector512.Shuffle(s0, f0).AsUInt64(), maskXYZ);
                var a_1 = Vector512.BitwiseAnd(Vector512.BitwiseOr(Vector512.Shuffle(s0, f1A), Vector512.Shuffle(s1, f1B)).AsUInt64(), maskXYZ);
                var a_2 = Vector512.BitwiseAnd(Vector512.BitwiseOr(Vector512.Shuffle(s1, f2A), Vector512.Shuffle(s2, f2B)).AsUInt64(), maskXYZ);
                var a_3 = Vector512.BitwiseAnd(Vector512.Shuffle(s2, f3).AsUInt64(), maskXYZ);
                result1 = a_1;
                result2 = a_2;
                result3 = a_3;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ToGroup4(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup3ToGroup4_Unzip(Vector512<sbyte> data0, Vector512<sbyte> data1, Vector512<sbyte> data2, out Vector512<sbyte> result1, out Vector512<sbyte> result2, out Vector512<sbyte> result3) {
                var d0 = YGroup3ToGroup4_Unzip(data0.AsByte(), data1.AsByte(), data2.AsByte(), out var d1, out var d2, out var d3);
                result1 = d1.AsSByte();
                result2 = d2.AsSByte();
                result3 = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ToGroup4(Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup3ToGroup4_Unzip(Vector512<byte> data0, Vector512<byte> data1, Vector512<byte> data2, out Vector512<byte> result1, out Vector512<byte> result2, out Vector512<byte> result3) {
                var a_3 = Vector512<byte>.Zero;
                var a_0 = YGroup3Unzip(data0, data1, data2, out var a_1, out var a_2);
                var b_0 = YGroup4Zip(a_0, a_1, a_2, a_3, out var b_1, out var b_2, out var b_3);
                result1 = b_1;
                result2 = b_2;
                result3 = b_3;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ToGroup4(Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup3ToGroup4_Unzip(Vector512<short> data0, Vector512<short> data1, Vector512<short> data2, out Vector512<short> result1, out Vector512<short> result2, out Vector512<short> result3) {
                var d0 = YGroup3ToGroup4_Unzip(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), out var d1, out var d2, out var d3);
                result1 = d1.AsInt16();
                result2 = d2.AsInt16();
                result3 = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ToGroup4(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup3ToGroup4_Unzip(Vector512<ushort> data0, Vector512<ushort> data1, Vector512<ushort> data2, out Vector512<ushort> result1, out Vector512<ushort> result2, out Vector512<ushort> result3) {
                var a_3 = Vector512<ushort>.Zero;
                var a_0 = YGroup3Unzip(data0, data1, data2, out var a_1, out var a_2);
                var b_0 = YGroup4Zip(a_0, a_1, a_2, a_3, out var b_1, out var b_2, out var b_3);
                result1 = b_1;
                result2 = b_2;
                result3 = b_3;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ToGroup4(Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup3ToGroup4_Unzip(Vector512<int> data0, Vector512<int> data1, Vector512<int> data2, out Vector512<int> result1, out Vector512<int> result2, out Vector512<int> result3) {
                var d0 = YGroup3ToGroup4_Unzip(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), out var d1, out var d2, out var d3);
                result1 = d1.AsInt32();
                result2 = d2.AsInt32();
                result3 = d3.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ToGroup4(Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup3ToGroup4_Unzip(Vector512<uint> data0, Vector512<uint> data1, Vector512<uint> data2, out Vector512<uint> result1, out Vector512<uint> result2, out Vector512<uint> result3) {
                var a_3 = Vector512<uint>.Zero;
                var a_0 = YGroup3Unzip(data0, data1, data2, out var a_1, out var a_2);
                var b_0 = YGroup4Zip(a_0, a_1, a_2, a_3, out var b_1, out var b_2, out var b_3);
                result1 = b_1;
                result2 = b_2;
                result3 = b_3;
                return b_0;
            }

#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup3Unzip_AcceleratedTypes {
                get {
                    return YGroup2Zip_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{float}, Vector512{float}, Vector512{float}, out Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup3Unzip(Vector512<float> data0, Vector512<float> data1, Vector512<float> data2, out Vector512<float> y, out Vector512<float> z) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3Unzip_ByShorter(data0, data1, data2, out y, out z);
#else
                return YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{double}, Vector512{double}, Vector512{double}, out Vector512{double}, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup3Unzip(Vector512<double> data0, Vector512<double> data1, Vector512<double> data2, out Vector512<double> y, out Vector512<double> z) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3Unzip_ByShorter(data0, data1, data2, out y, out z);
#else
                return YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup3Unzip(Vector512<sbyte> data0, Vector512<sbyte> data1, Vector512<sbyte> data2, out Vector512<sbyte> y, out Vector512<sbyte> z) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3Unzip_ByShorter(data0, data1, data2, out y, out z);
#else
                return YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup3Unzip(Vector512<byte> data0, Vector512<byte> data1, Vector512<byte> data2, out Vector512<byte> y, out Vector512<byte> z) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3Unzip_ByShorter(data0, data1, data2, out y, out z);
#else
                return YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup3Unzip(Vector512<short> data0, Vector512<short> data1, Vector512<short> data2, out Vector512<short> y, out Vector512<short> z) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3Unzip_ByShorter(data0, data1, data2, out y, out z);
#else
                return YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup3Unzip(Vector512<ushort> data0, Vector512<ushort> data1, Vector512<ushort> data2, out Vector512<ushort> y, out Vector512<ushort> z) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3Unzip_ByShorter(data0, data1, data2, out y, out z);
#else
                return YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup3Unzip(Vector512<int> data0, Vector512<int> data1, Vector512<int> data2, out Vector512<int> y, out Vector512<int> z) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3Unzip_ByShorter(data0, data1, data2, out y, out z);
#else
                return YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup3Unzip(Vector512<uint> data0, Vector512<uint> data1, Vector512<uint> data2, out Vector512<uint> y, out Vector512<uint> z) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3Unzip_ByShorter(data0, data1, data2, out y, out z);
#else
                return YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{long}, Vector512{long}, Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup3Unzip(Vector512<long> data0, Vector512<long> data1, Vector512<long> data2, out Vector512<long> y, out Vector512<long> z) {
                return YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup3Unzip(Vector512<ulong> data0, Vector512<ulong> data1, Vector512<ulong> data2, out Vector512<ulong> y, out Vector512<ulong> z) {
                return YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip_Bit128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<T> YGroup3Unzip_Bit128<T>(Vector512<T> data0, Vector512<T> data1, Vector512<T> data2, out Vector512<T> y, out Vector512<T> z) where T : struct {
                // f({x[0], y[0], z[0], x[1]}, {y[1], z[1], x[2], y[2]}, {z[2], x[3], y[3], z[3]}) = ({x[0], x[1], x[2], x[3]}, {y[0], y[1], y[2], y[3]}, {z[0], z[1], z[2], z[3]})
                var b0 = data0.GetLower();
                var b1 = data0.GetUpper();
                var b2 = data1.GetLower();
                var b3 = data1.GetUpper();
                var b4 = data2.GetLower();
                var b5 = data2.GetUpper();
                var c0 = b0.WithUpper(b1.GetUpper()).ToVector512Unsafe().WithUpper(b3.WithUpper(b4.GetUpper()));
                var c1 = b0.GetUpper().ToVector256Unsafe().WithUpper(b2.GetLower()).ToVector512Unsafe().WithUpper(b3.GetUpper().ToVector256Unsafe().WithUpper(b5.GetLower()));
                var c2 = b1.WithUpper(b2.GetUpper()).ToVector512Unsafe().WithUpper(b4.WithUpper(b5.GetUpper()));
                y = c1;
                z = c2;
                return c0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{float}, Vector512{float}, Vector512{float}, out Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup3Unzip_Basic(Vector512<float> data0, Vector512<float> data1, Vector512<float> data2, out Vector512<float> y, out Vector512<float> z) {
                var d0 = YGroup3Unzip_Basic(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), out var d1, out var d2);
                y = d1.AsSingle();
                z = d2.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{double}, Vector512{double}, Vector512{double}, out Vector512{double}, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup3Unzip_Basic(Vector512<double> data0, Vector512<double> data1, Vector512<double> data2, out Vector512<double> y, out Vector512<double> z) {
                var d0 = YGroup3Unzip_Basic(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), out var d1, out var d2);
                y = d1.AsDouble();
                z = d2.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup3Unzip_Basic(Vector512<sbyte> data0, Vector512<sbyte> data1, Vector512<sbyte> data2, out Vector512<sbyte> y, out Vector512<sbyte> z) {
                var d0 = YGroup3Unzip_Basic(data0.AsByte(), data1.AsByte(), data2.AsByte(), out var d1, out var d2);
                y = d1.AsSByte();
                z = d2.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup3Unzip_Basic(Vector512<byte> data0, Vector512<byte> data1, Vector512<byte> data2, out Vector512<byte> y, out Vector512<byte> z) {
                UnsafeUtil.SkipInit(out Vector512<byte> x1);
                UnsafeUtil.SkipInit(out Vector512<byte> y1);
                UnsafeUtil.SkipInit(out Vector512<byte> z1);
                Span<Vector512<byte>> src = [data0, data1, data2];
                ref byte px = ref Unsafe.As<Vector512<byte>, byte>(ref x1);
                ref byte py = ref Unsafe.As<Vector512<byte>, byte>(ref y1);
                ref byte pz = ref Unsafe.As<Vector512<byte>, byte>(ref z1);
                Span<byte> p = MemoryMarshal.Cast<Vector512<byte>, byte>(src);
                int idx = 0;
                for (int i = 0; i < Vector512<byte>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    Unsafe.Add(ref py, i) = p[idx + 1];
                    Unsafe.Add(ref pz, i) = p[idx + 2];
                    idx += 3;
                }
                y = y1;
                z = z1;
                return x1;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup3Unzip_Basic(Vector512<short> data0, Vector512<short> data1, Vector512<short> data2, out Vector512<short> y, out Vector512<short> z) {
                var d0 = YGroup3Unzip_Basic(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), out var d1, out var d2);
                y = d1.AsInt16();
                z = d2.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup3Unzip_Basic(Vector512<ushort> data0, Vector512<ushort> data1, Vector512<ushort> data2, out Vector512<ushort> y, out Vector512<ushort> z) {
                UnsafeUtil.SkipInit(out Vector512<ushort> x1);
                UnsafeUtil.SkipInit(out Vector512<ushort> y1);
                UnsafeUtil.SkipInit(out Vector512<ushort> z1);
                Span<Vector512<ushort>> src = [data0, data1, data2];
                ref ushort px = ref Unsafe.As<Vector512<ushort>, ushort>(ref x1);
                ref ushort py = ref Unsafe.As<Vector512<ushort>, ushort>(ref y1);
                ref ushort pz = ref Unsafe.As<Vector512<ushort>, ushort>(ref z1);
                Span<ushort> p = MemoryMarshal.Cast<Vector512<ushort>, ushort>(src);
                int idx = 0;
                for (int i = 0; i < Vector512<ushort>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    Unsafe.Add(ref py, i) = p[idx + 1];
                    Unsafe.Add(ref pz, i) = p[idx + 2];
                    idx += 3;
                }
                y = y1;
                z = z1;
                return x1;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup3Unzip_Basic(Vector512<int> data0, Vector512<int> data1, Vector512<int> data2, out Vector512<int> y, out Vector512<int> z) {
                var d0 = YGroup3Unzip_Basic(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), out var d1, out var d2);
                y = d1.AsInt32();
                z = d2.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup3Unzip_Basic(Vector512<uint> data0, Vector512<uint> data1, Vector512<uint> data2, out Vector512<uint> y, out Vector512<uint> z) {
                UnsafeUtil.SkipInit(out Vector512<uint> x1);
                UnsafeUtil.SkipInit(out Vector512<uint> y1);
                UnsafeUtil.SkipInit(out Vector512<uint> z1);
                Span<Vector512<uint>> src = [data0, data1, data2];
                ref uint px = ref Unsafe.As<Vector512<uint>, uint>(ref x1);
                ref uint py = ref Unsafe.As<Vector512<uint>, uint>(ref y1);
                ref uint pz = ref Unsafe.As<Vector512<uint>, uint>(ref z1);
                Span<uint> p = MemoryMarshal.Cast<Vector512<uint>, uint>(src);
                int idx = 0;
                for (int i = 0; i < Vector512<uint>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    Unsafe.Add(ref py, i) = p[idx + 1];
                    Unsafe.Add(ref pz, i) = p[idx + 2];
                    idx += 3;
                }
                y = y1;
                z = z1;
                return x1;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{long}, Vector512{long}, Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup3Unzip_Basic(Vector512<long> data0, Vector512<long> data1, Vector512<long> data2, out Vector512<long> y, out Vector512<long> z) {
                var d0 = YGroup3Unzip_Basic(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), out var d1, out var d2);
                y = d1.AsInt64();
                z = d2.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup3Unzip_Basic(Vector512<ulong> data0, Vector512<ulong> data1, Vector512<ulong> data2, out Vector512<ulong> y, out Vector512<ulong> z) {
                UnsafeUtil.SkipInit(out Vector512<ulong> x1);
                UnsafeUtil.SkipInit(out Vector512<ulong> y1);
                UnsafeUtil.SkipInit(out Vector512<ulong> z1);
                Span<Vector512<ulong>> src = [data0, data1, data2];
                ref ulong px = ref Unsafe.As<Vector512<ulong>, ulong>(ref x1);
                ref ulong py = ref Unsafe.As<Vector512<ulong>, ulong>(ref y1);
                ref ulong pz = ref Unsafe.As<Vector512<ulong>, ulong>(ref z1);
                Span<ulong> p = MemoryMarshal.Cast<Vector512<ulong>, ulong>(src);
                int idx = 0;
                for (int i = 0; i < Vector512<ulong>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    Unsafe.Add(ref py, i) = p[idx + 1];
                    Unsafe.Add(ref pz, i) = p[idx + 2];
                    idx += 3;
                }
                y = y1;
                z = z1;
                return x1;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{float}, Vector512{float}, Vector512{float}, out Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup3Unzip_ByShorter(Vector512<float> data0, Vector512<float> data1, Vector512<float> data2, out Vector512<float> y, out Vector512<float> z) {
                var b0 = ShorterStatics.YGroup3UnzipX2(data0.GetLower(), data0.GetUpper(), data1.GetLower(), data1.GetUpper(), data2.GetLower(), data2.GetUpper(), out var b1, out var b2, out var b3, out var b4, out var b5);
                var c0 = b0.ToVector512Unsafe().WithUpper(b1);
                var c1 = b2.ToVector512Unsafe().WithUpper(b3);
                var c2 = b4.ToVector512Unsafe().WithUpper(b5);
                y = c1;
                z = c2;
                return c0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{double}, Vector512{double}, Vector512{double}, out Vector512{double}, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup3Unzip_ByShorter(Vector512<double> data0, Vector512<double> data1, Vector512<double> data2, out Vector512<double> y, out Vector512<double> z) {
                var b0 = ShorterStatics.YGroup3UnzipX2(data0.GetLower(), data0.GetUpper(), data1.GetLower(), data1.GetUpper(), data2.GetLower(), data2.GetUpper(), out var b1, out var b2, out var b3, out var b4, out var b5);
                var c0 = b0.ToVector512Unsafe().WithUpper(b1);
                var c1 = b2.ToVector512Unsafe().WithUpper(b3);
                var c2 = b4.ToVector512Unsafe().WithUpper(b5);
                y = c1;
                z = c2;
                return c0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup3Unzip_ByShorter(Vector512<sbyte> data0, Vector512<sbyte> data1, Vector512<sbyte> data2, out Vector512<sbyte> y, out Vector512<sbyte> z) {
                var b0 = ShorterStatics.YGroup3UnzipX2(data0.GetLower(), data0.GetUpper(), data1.GetLower(), data1.GetUpper(), data2.GetLower(), data2.GetUpper(), out var b1, out var b2, out var b3, out var b4, out var b5);
                var c0 = b0.ToVector512Unsafe().WithUpper(b1);
                var c1 = b2.ToVector512Unsafe().WithUpper(b3);
                var c2 = b4.ToVector512Unsafe().WithUpper(b5);
                y = c1;
                z = c2;
                return c0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup3Unzip_ByShorter(Vector512<byte> data0, Vector512<byte> data1, Vector512<byte> data2, out Vector512<byte> y, out Vector512<byte> z) {
                var b0 = ShorterStatics.YGroup3UnzipX2(data0.GetLower(), data0.GetUpper(), data1.GetLower(), data1.GetUpper(), data2.GetLower(), data2.GetUpper(), out var b1, out var b2, out var b3, out var b4, out var b5);
                var c0 = b0.ToVector512Unsafe().WithUpper(b1);
                var c1 = b2.ToVector512Unsafe().WithUpper(b3);
                var c2 = b4.ToVector512Unsafe().WithUpper(b5);
                y = c1;
                z = c2;
                return c0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup3Unzip_ByShorter(Vector512<short> data0, Vector512<short> data1, Vector512<short> data2, out Vector512<short> y, out Vector512<short> z) {
                var b0 = ShorterStatics.YGroup3UnzipX2(data0.GetLower(), data0.GetUpper(), data1.GetLower(), data1.GetUpper(), data2.GetLower(), data2.GetUpper(), out var b1, out var b2, out var b3, out var b4, out var b5);
                var c0 = b0.ToVector512Unsafe().WithUpper(b1);
                var c1 = b2.ToVector512Unsafe().WithUpper(b3);
                var c2 = b4.ToVector512Unsafe().WithUpper(b5);
                y = c1;
                z = c2;
                return c0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup3Unzip_ByShorter(Vector512<ushort> data0, Vector512<ushort> data1, Vector512<ushort> data2, out Vector512<ushort> y, out Vector512<ushort> z) {
                var b0 = ShorterStatics.YGroup3UnzipX2(data0.GetLower(), data0.GetUpper(), data1.GetLower(), data1.GetUpper(), data2.GetLower(), data2.GetUpper(), out var b1, out var b2, out var b3, out var b4, out var b5);
                var c0 = b0.ToVector512Unsafe().WithUpper(b1);
                var c1 = b2.ToVector512Unsafe().WithUpper(b3);
                var c2 = b4.ToVector512Unsafe().WithUpper(b5);
                y = c1;
                z = c2;
                return c0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup3Unzip_ByShorter(Vector512<int> data0, Vector512<int> data1, Vector512<int> data2, out Vector512<int> y, out Vector512<int> z) {
                var b0 = ShorterStatics.YGroup3UnzipX2(data0.GetLower(), data0.GetUpper(), data1.GetLower(), data1.GetUpper(), data2.GetLower(), data2.GetUpper(), out var b1, out var b2, out var b3, out var b4, out var b5);
                var c0 = b0.ToVector512Unsafe().WithUpper(b1);
                var c1 = b2.ToVector512Unsafe().WithUpper(b3);
                var c2 = b4.ToVector512Unsafe().WithUpper(b5);
                y = c1;
                z = c2;
                return c0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup3Unzip_ByShorter(Vector512<uint> data0, Vector512<uint> data1, Vector512<uint> data2, out Vector512<uint> y, out Vector512<uint> z) {
                var b0 = ShorterStatics.YGroup3UnzipX2(data0.GetLower(), data0.GetUpper(), data1.GetLower(), data1.GetUpper(), data2.GetLower(), data2.GetUpper(), out var b1, out var b2, out var b3, out var b4, out var b5);
                var c0 = b0.ToVector512Unsafe().WithUpper(b1);
                var c1 = b2.ToVector512Unsafe().WithUpper(b3);
                var c2 = b4.ToVector512Unsafe().WithUpper(b5);
                y = c1;
                z = c2;
                return c0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{long}, Vector512{long}, Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup3Unzip_ByShorter(Vector512<long> data0, Vector512<long> data1, Vector512<long> data2, out Vector512<long> y, out Vector512<long> z) {
                var b0 = ShorterStatics.YGroup3UnzipX2(data0.GetLower(), data0.GetUpper(), data1.GetLower(), data1.GetUpper(), data2.GetLower(), data2.GetUpper(), out var b1, out var b2, out var b3, out var b4, out var b5);
                var c0 = b0.ToVector512Unsafe().WithUpper(b1);
                var c1 = b2.ToVector512Unsafe().WithUpper(b3);
                var c2 = b4.ToVector512Unsafe().WithUpper(b5);
                y = c1;
                z = c2;
                return c0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup3Unzip_ByShorter(Vector512<ulong> data0, Vector512<ulong> data1, Vector512<ulong> data2, out Vector512<ulong> y, out Vector512<ulong> z) {
                var b0 = ShorterStatics.YGroup3UnzipX2(data0.GetLower(), data0.GetUpper(), data1.GetLower(), data1.GetUpper(), data2.GetLower(), data2.GetUpper(), out var b1, out var b2, out var b3, out var b4, out var b5);
                var c0 = b0.ToVector512Unsafe().WithUpper(b1);
                var c1 = b2.ToVector512Unsafe().WithUpper(b3);
                var c2 = b4.ToVector512Unsafe().WithUpper(b5);
                y = c1;
                z = c2;
                return c0;
            }

#if VECTOR_HAS_METHOD

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{float}, Vector512{float}, Vector512{float}, out Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup3Unzip_ByX2Zip(Vector512<float> data0, Vector512<float> data1, Vector512<float> data2, out Vector512<float> y, out Vector512<float> z) {
                return YGroup3UnzipX2_Zip(data0, data1, data2, data0, data1, data2, out _, out y, out _, out z, out _);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup3Unzip_ByX2Zip(Vector512<sbyte> data0, Vector512<sbyte> data1, Vector512<sbyte> data2, out Vector512<sbyte> y, out Vector512<sbyte> z) {
                return YGroup3UnzipX2_Zip(data0, data1, data2, data0, data1, data2, out _, out y, out _, out z, out _);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup3Unzip_ByX2Zip(Vector512<byte> data0, Vector512<byte> data1, Vector512<byte> data2, out Vector512<byte> y, out Vector512<byte> z) {
                return YGroup3UnzipX2_Zip(data0, data1, data2, data0, data1, data2, out _, out y, out _, out z, out _);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup3Unzip_ByX2Zip(Vector512<short> data0, Vector512<short> data1, Vector512<short> data2, out Vector512<short> y, out Vector512<short> z) {
                return YGroup3UnzipX2_Zip(data0, data1, data2, data0, data1, data2, out _, out y, out _, out z, out _);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup3Unzip_ByX2Zip(Vector512<ushort> data0, Vector512<ushort> data1, Vector512<ushort> data2, out Vector512<ushort> y, out Vector512<ushort> z) {
                return YGroup3UnzipX2_Zip(data0, data1, data2, data0, data1, data2, out _, out y, out _, out z, out _);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup3Unzip_ByX2Zip(Vector512<int> data0, Vector512<int> data1, Vector512<int> data2, out Vector512<int> y, out Vector512<int> z) {
                return YGroup3UnzipX2_Zip(data0, data1, data2, data0, data1, data2, out _, out y, out _, out z, out _);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Unzip(Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup3Unzip_ByX2Zip(Vector512<uint> data0, Vector512<uint> data1, Vector512<uint> data2, out Vector512<uint> y, out Vector512<uint> z) {
                return YGroup3UnzipX2_Zip(data0, data1, data2, data0, data1, data2, out _, out y, out _, out z, out _);
            }

#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup3UnzipX2_AcceleratedTypes {
                get {
                    return YGroup2Zip_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup3UnzipX2(Vector512<float> data0, Vector512<float> data1, Vector512<float> data2, Vector512<float> data3, Vector512<float> data4, Vector512<float> data5, out Vector512<float> xB, out Vector512<float> y, out Vector512<float> yB, out Vector512<float> z, out Vector512<float> zB) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup3UnzipX2_Zip(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3UnzipX2_X2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup3UnzipX2(Vector512<double> data0, Vector512<double> data1, Vector512<double> data2, Vector512<double> data3, Vector512<double> data4, Vector512<double> data5, out Vector512<double> xB, out Vector512<double> y, out Vector512<double> yB, out Vector512<double> z, out Vector512<double> zB) {
                return YGroup3UnzipX2_X2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup3UnzipX2(Vector512<sbyte> data0, Vector512<sbyte> data1, Vector512<sbyte> data2, Vector512<sbyte> data3, Vector512<sbyte> data4, Vector512<sbyte> data5, out Vector512<sbyte> xB, out Vector512<sbyte> y, out Vector512<sbyte> yB, out Vector512<sbyte> z, out Vector512<sbyte> zB) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup3UnzipX2_Zip(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3UnzipX2_X2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup3UnzipX2(Vector512<byte> data0, Vector512<byte> data1, Vector512<byte> data2, Vector512<byte> data3, Vector512<byte> data4, Vector512<byte> data5, out Vector512<byte> xB, out Vector512<byte> y, out Vector512<byte> yB, out Vector512<byte> z, out Vector512<byte> zB) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup3UnzipX2_Zip(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3UnzipX2_X2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup3UnzipX2(Vector512<short> data0, Vector512<short> data1, Vector512<short> data2, Vector512<short> data3, Vector512<short> data4, Vector512<short> data5, out Vector512<short> xB, out Vector512<short> y, out Vector512<short> yB, out Vector512<short> z, out Vector512<short> zB) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup3UnzipX2_Zip(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3UnzipX2_X2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup3UnzipX2(Vector512<ushort> data0, Vector512<ushort> data1, Vector512<ushort> data2, Vector512<ushort> data3, Vector512<ushort> data4, Vector512<ushort> data5, out Vector512<ushort> xB, out Vector512<ushort> y, out Vector512<ushort> yB, out Vector512<ushort> z, out Vector512<ushort> zB) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup3UnzipX2_Zip(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3UnzipX2_X2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup3UnzipX2(Vector512<int> data0, Vector512<int> data1, Vector512<int> data2, Vector512<int> data3, Vector512<int> data4, Vector512<int> data5, out Vector512<int> xB, out Vector512<int> y, out Vector512<int> yB, out Vector512<int> z, out Vector512<int> zB) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup3UnzipX2_Zip(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3UnzipX2_X2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup3UnzipX2(Vector512<uint> data0, Vector512<uint> data1, Vector512<uint> data2, Vector512<uint> data3, Vector512<uint> data4, Vector512<uint> data5, out Vector512<uint> xB, out Vector512<uint> y, out Vector512<uint> yB, out Vector512<uint> z, out Vector512<uint> zB) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup3UnzipX2_Zip(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3UnzipX2_X2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup3UnzipX2(Vector512<long> data0, Vector512<long> data1, Vector512<long> data2, Vector512<long> data3, Vector512<long> data4, Vector512<long> data5, out Vector512<long> xB, out Vector512<long> y, out Vector512<long> yB, out Vector512<long> z, out Vector512<long> zB) {
                return YGroup3UnzipX2_X2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup3UnzipX2(Vector512<ulong> data0, Vector512<ulong> data1, Vector512<ulong> data2, Vector512<ulong> data3, Vector512<ulong> data4, Vector512<ulong> data5, out Vector512<ulong> xB, out Vector512<ulong> y, out Vector512<ulong> yB, out Vector512<ulong> z, out Vector512<ulong> zB) {
                return YGroup3UnzipX2_X2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2_Bit128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<T> YGroup3UnzipX2_Bit128<T>(Vector512<T> data0, Vector512<T> data1, Vector512<T> data2, Vector512<T> data3, Vector512<T> data4, Vector512<T> data5, out Vector512<T> xB, out Vector512<T> y, out Vector512<T> yB, out Vector512<T> z, out Vector512<T> zB) where T : struct {
                var x = YGroup3Unzip_Bit128(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip_Bit128(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup3UnzipX2_Basic(Vector512<float> data0, Vector512<float> data1, Vector512<float> data2, Vector512<float> data3, Vector512<float> data4, Vector512<float> data5, out Vector512<float> xB, out Vector512<float> y, out Vector512<float> yB, out Vector512<float> z, out Vector512<float> zB) {
                var x = YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip_Basic(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup3UnzipX2_Basic(Vector512<double> data0, Vector512<double> data1, Vector512<double> data2, Vector512<double> data3, Vector512<double> data4, Vector512<double> data5, out Vector512<double> xB, out Vector512<double> y, out Vector512<double> yB, out Vector512<double> z, out Vector512<double> zB) {
                var x = YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip_Basic(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup3UnzipX2_Basic(Vector512<sbyte> data0, Vector512<sbyte> data1, Vector512<sbyte> data2, Vector512<sbyte> data3, Vector512<sbyte> data4, Vector512<sbyte> data5, out Vector512<sbyte> xB, out Vector512<sbyte> y, out Vector512<sbyte> yB, out Vector512<sbyte> z, out Vector512<sbyte> zB) {
                var x = YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip_Basic(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup3UnzipX2_Basic(Vector512<byte> data0, Vector512<byte> data1, Vector512<byte> data2, Vector512<byte> data3, Vector512<byte> data4, Vector512<byte> data5, out Vector512<byte> xB, out Vector512<byte> y, out Vector512<byte> yB, out Vector512<byte> z, out Vector512<byte> zB) {
                var x = YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip_Basic(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup3UnzipX2_Basic(Vector512<short> data0, Vector512<short> data1, Vector512<short> data2, Vector512<short> data3, Vector512<short> data4, Vector512<short> data5, out Vector512<short> xB, out Vector512<short> y, out Vector512<short> yB, out Vector512<short> z, out Vector512<short> zB) {
                var x = YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip_Basic(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup3UnzipX2_Basic(Vector512<ushort> data0, Vector512<ushort> data1, Vector512<ushort> data2, Vector512<ushort> data3, Vector512<ushort> data4, Vector512<ushort> data5, out Vector512<ushort> xB, out Vector512<ushort> y, out Vector512<ushort> yB, out Vector512<ushort> z, out Vector512<ushort> zB) {
                var x = YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip_Basic(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup3UnzipX2_Basic(Vector512<int> data0, Vector512<int> data1, Vector512<int> data2, Vector512<int> data3, Vector512<int> data4, Vector512<int> data5, out Vector512<int> xB, out Vector512<int> y, out Vector512<int> yB, out Vector512<int> z, out Vector512<int> zB) {
                var x = YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip_Basic(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup3UnzipX2_Basic(Vector512<uint> data0, Vector512<uint> data1, Vector512<uint> data2, Vector512<uint> data3, Vector512<uint> data4, Vector512<uint> data5, out Vector512<uint> xB, out Vector512<uint> y, out Vector512<uint> yB, out Vector512<uint> z, out Vector512<uint> zB) {
                var x = YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip_Basic(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup3UnzipX2_Basic(Vector512<long> data0, Vector512<long> data1, Vector512<long> data2, Vector512<long> data3, Vector512<long> data4, Vector512<long> data5, out Vector512<long> xB, out Vector512<long> y, out Vector512<long> yB, out Vector512<long> z, out Vector512<long> zB) {
                var x = YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip_Basic(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup3UnzipX2_Basic(Vector512<ulong> data0, Vector512<ulong> data1, Vector512<ulong> data2, Vector512<ulong> data3, Vector512<ulong> data4, Vector512<ulong> data5, out Vector512<ulong> xB, out Vector512<ulong> y, out Vector512<ulong> yB, out Vector512<ulong> z, out Vector512<ulong> zB) {
                var x = YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip_Basic(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup3UnzipX2_X2(Vector512<float> data0, Vector512<float> data1, Vector512<float> data2, Vector512<float> data3, Vector512<float> data4, Vector512<float> data5, out Vector512<float> xB, out Vector512<float> y, out Vector512<float> yB, out Vector512<float> z, out Vector512<float> zB) {
                var x = YGroup3Unzip(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup3UnzipX2_X2(Vector512<double> data0, Vector512<double> data1, Vector512<double> data2, Vector512<double> data3, Vector512<double> data4, Vector512<double> data5, out Vector512<double> xB, out Vector512<double> y, out Vector512<double> yB, out Vector512<double> z, out Vector512<double> zB) {
                var x = YGroup3Unzip(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup3UnzipX2_X2(Vector512<sbyte> data0, Vector512<sbyte> data1, Vector512<sbyte> data2, Vector512<sbyte> data3, Vector512<sbyte> data4, Vector512<sbyte> data5, out Vector512<sbyte> xB, out Vector512<sbyte> y, out Vector512<sbyte> yB, out Vector512<sbyte> z, out Vector512<sbyte> zB) {
                var x = YGroup3Unzip(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup3UnzipX2_X2(Vector512<byte> data0, Vector512<byte> data1, Vector512<byte> data2, Vector512<byte> data3, Vector512<byte> data4, Vector512<byte> data5, out Vector512<byte> xB, out Vector512<byte> y, out Vector512<byte> yB, out Vector512<byte> z, out Vector512<byte> zB) {
                var x = YGroup3Unzip(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup3UnzipX2_X2(Vector512<short> data0, Vector512<short> data1, Vector512<short> data2, Vector512<short> data3, Vector512<short> data4, Vector512<short> data5, out Vector512<short> xB, out Vector512<short> y, out Vector512<short> yB, out Vector512<short> z, out Vector512<short> zB) {
                var x = YGroup3Unzip(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup3UnzipX2_X2(Vector512<ushort> data0, Vector512<ushort> data1, Vector512<ushort> data2, Vector512<ushort> data3, Vector512<ushort> data4, Vector512<ushort> data5, out Vector512<ushort> xB, out Vector512<ushort> y, out Vector512<ushort> yB, out Vector512<ushort> z, out Vector512<ushort> zB) {
                var x = YGroup3Unzip(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup3UnzipX2_X2(Vector512<int> data0, Vector512<int> data1, Vector512<int> data2, Vector512<int> data3, Vector512<int> data4, Vector512<int> data5, out Vector512<int> xB, out Vector512<int> y, out Vector512<int> yB, out Vector512<int> z, out Vector512<int> zB) {
                var x = YGroup3Unzip(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup3UnzipX2_X2(Vector512<uint> data0, Vector512<uint> data1, Vector512<uint> data2, Vector512<uint> data3, Vector512<uint> data4, Vector512<uint> data5, out Vector512<uint> xB, out Vector512<uint> y, out Vector512<uint> yB, out Vector512<uint> z, out Vector512<uint> zB) {
                var x = YGroup3Unzip(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup3UnzipX2_X2(Vector512<long> data0, Vector512<long> data1, Vector512<long> data2, Vector512<long> data3, Vector512<long> data4, Vector512<long> data5, out Vector512<long> xB, out Vector512<long> y, out Vector512<long> yB, out Vector512<long> z, out Vector512<long> zB) {
                var x = YGroup3Unzip(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup3UnzipX2_X2(Vector512<ulong> data0, Vector512<ulong> data1, Vector512<ulong> data2, Vector512<ulong> data3, Vector512<ulong> data4, Vector512<ulong> data5, out Vector512<ulong> xB, out Vector512<ulong> y, out Vector512<ulong> yB, out Vector512<ulong> z, out Vector512<ulong> zB) {
                var x = YGroup3Unzip(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip(data3, data4, data5, out yB, out zB);
                return x;
            }

#if VECTOR_HAS_METHOD

            /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup3UnzipX2_Zip(Vector512<float> data0, Vector512<float> data1, Vector512<float> data2, Vector512<float> data3, Vector512<float> data4, Vector512<float> data5, out Vector512<float> xB, out Vector512<float> y, out Vector512<float> yB, out Vector512<float> z, out Vector512<float> zB) {
                var d0 = YGroup3UnzipX2_Zip(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), data4.AsUInt32(), data5.AsUInt32(), out var d1, out var d2, out var d3, out var d4, out var d5);
                xB = d1.AsSingle();
                y = d2.AsSingle();
                yB = d3.AsSingle();
                z = d4.AsSingle();
                zB = d5.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup3UnzipX2_Zip(Vector512<sbyte> data0, Vector512<sbyte> data1, Vector512<sbyte> data2, Vector512<sbyte> data3, Vector512<sbyte> data4, Vector512<sbyte> data5, out Vector512<sbyte> xB, out Vector512<sbyte> y, out Vector512<sbyte> yB, out Vector512<sbyte> z, out Vector512<sbyte> zB) {
                var d0 = YGroup3UnzipX2_Zip(data0.AsByte(), data1.AsByte(), data2.AsByte(), data3.AsByte(), data4.AsByte(), data5.AsByte(), out var d1, out var d2, out var d3, out var d4, out var d5);
                xB = d1.AsSByte();
                y = d2.AsSByte();
                yB = d3.AsSByte();
                z = d4.AsSByte();
                zB = d5.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup3UnzipX2_Zip(Vector512<byte> data0, Vector512<byte> data1, Vector512<byte> data2, Vector512<byte> data3, Vector512<byte> data4, Vector512<byte> data5, out Vector512<byte> xB, out Vector512<byte> y, out Vector512<byte> yB, out Vector512<byte> z, out Vector512<byte> zB) {
                Vector512<byte> a_0, a_1, a_2, a_3, a_4, a_5, b_0, b_1, b_2, b_3, b_4, b_5;
                // 0 data0 x0 y0 z0 x1 y1 z1 x2 y2 z2 x3 y3 z3 x4 y4 z4 x5 y5 z5 x6 y6 z6 x7 y7 z7 x8 y8 z8 x9 y9 z9 x10 y10 z10 x11 y11 z11 x12 y12 z12 x13 y13 z13 x14 y14 z14 x15 y15 z15 x16 y16 z16 x17 y17 z17 x18 y18 z18 x19 y19 z19 x20 y20 z20 x21 data1 y21 z21 x22 y22 z22 x23 y23 z23 x24 y24 z24 x25 y25 z25 x26 y26 z26 x27 y27 z27 x28 y28 z28 x29 y29 z29 x30 y30 z30 x31 y31 z31 x32 y32 z32 x33 y33 z33 x34 y34 z34 x35 y35 z35 x36 y36 z36 x37 y37 z37 x38 y38 z38 x39 y39 z39 x40 y40 z40 x41 y41 z41 x42 y42 data2 z42 x43 y43 z43 x44 y44 z44 x45 y45 z45 x46 y46 z46 x47 y47 z47 x48 y48 z48 x49 y49 z49 x50 y50 z50 x51 y51 z51 x52 y52 z52 x53 y53 z53 x54 y54 z54 x55 y55 z55 x56 y56 z56 x57 y57 z57 x58 y58 z58 x59 y59 z59 x60 y60 z60 x61 y61 z61 x62 y62 z62 x63 y63 z63 data3 x64 y64 z64 x65 y65 z65 x66 y66 z66 x67 y67 z67 x68 y68 z68 x69 y69 z69 x70 y70 z70 x71 y71 z71 x72 y72 z72 x73 y73 z73 x74 y74 z74 x75 y75 z75 x76 y76 z76 x77 y77 z77 x78 y78 z78 x79 y79 z79 x80 y80 z80 x81 y81 z81 x82 y82 z82 x83 y83 z83 x84 y84 z84 x85 data4 y85 z85 x86 y86 z86 x87 y87 z87 x88 y88 z88 x89 y89 z89 x90 y90 z90 x91 y91 z91 x92 y92 z92 x93 y93 z93 x94 y94 z94 x95 y95 z95 x96 y96 z96 x97 y97 z97 x98 y98 z98 x99 y99 z99 x100 y100 z100 x101 y101 z101 x102 y102 z102 x103 y103 z103 x104 y104 z104 x105 y105 z105 x106 y106 data5 z106 x107 y107 z107 x108 y108 z108 x109 y109 z109 x110 y110 z110 x111 y111 z111 x112 y112 z112 x113 y113 z113 x114 y114 z114 x115 y115 z115 x116 y116 z116 x117 y117 z117 x118 y118 z118 x119 y119 z119 x120 y120 z120 x121 y121 z121 x122 y122 z122 x123 y123 z123 x124 y124 z124 x125 y125 z125 x126 y126 z126 x127 y127 z127
                // 1 a_0 x0 x64 y0 y64 z0 z64 x1 x65 y1 y65 z1 z65 x2 x66 y2 y66 z2 z66 x3 x67 y3 y67 z3 z67 x4 x68 y4 y68 z4 z68 x5 x69 y5 y69 z5 z69 x6 x70 y6 y70 z6 z70 x7 x71 y7 y71 z7 z71 x8 x72 y8 y72 z8 z72 x9 x73 y9 y73 z9 z73 x10 x74 y10 y74 a_1 z10 z74 x11 x75 y11 y75 z11 z75 x12 x76 y12 y76 z12 z76 x13 x77 y13 y77 z13 z77 x14 x78 y14 y78 z14 z78 x15 x79 y15 y79 z15 z79 x16 x80 y16 y80 z16 z80 x17 x81 y17 y81 z17 z81 x18 x82 y18 y82 z18 z82 x19 x83 y19 y83 z19 z83 x20 x84 y20 y84 z20 z84 x21 x85 a_2 y21 y85 z21 z85 x22 x86 y22 y86 z22 z86 x23 x87 y23 y87 z23 z87 x24 x88 y24 y88 z24 z88 x25 x89 y25 y89 z25 z89 x26 x90 y26 y90 z26 z90 x27 x91 y27 y91 z27 z91 x28 x92 y28 y92 z28 z92 x29 x93 y29 y93 z29 z93 x30 x94 y30 y94 z30 z94 x31 x95 y31 y95 z31 z95 a_3 x32 x96 y32 y96 z32 z96 x33 x97 y33 y97 z33 z97 x34 x98 y34 y98 z34 z98 x35 x99 y35 y99 z35 z99 x36 x100 y36 y100 z36 z100 x37 x101 y37 y101 z37 z101 x38 x102 y38 y102 z38 z102 x39 x103 y39 y103 z39 z103 x40 x104 y40 y104 z40 z104 x41 x105 y41 y105 z41 z105 x42 x106 y42 y106 a_4 z42 z106 x43 x107 y43 y107 z43 z107 x44 x108 y44 y108 z44 z108 x45 x109 y45 y109 z45 z109 x46 x110 y46 y110 z46 z110 x47 x111 y47 y111 z47 z111 x48 x112 y48 y112 z48 z112 x49 x113 y49 y113 z49 z113 x50 x114 y50 y114 z50 z114 x51 x115 y51 y115 z51 z115 x52 x116 y52 y116 z52 z116 x53 x117 a_5 y53 y117 z53 z117 x54 x118 y54 y118 z54 z118 x55 x119 y55 y119 z55 z119 x56 x120 y56 y120 z56 z120 x57 x121 y57 y121 z57 z121 x58 x122 y58 y122 z58 z122 x59 x123 y59 y123 z59 z123 x60 x124 y60 y124 z60 z124 x61 x125 y61 y125 z61 z125 x62 x126 y62 y126 z62 z126 x63 x127 y63 y127 z63 z127
                a_0 = YGroup2Zip(data0, data3, out a_1);
                a_2 = YGroup2Zip(data1, data4, out a_3);
                a_4 = YGroup2Zip(data2, data5, out a_5);
                // 2 b_0 x0 x32 x64 x96 y0 y32 y64 y96 z0 z32 z64 z96 x1 x33 x65 x97 y1 y33 y65 y97 z1 z33 z65 z97 x2 x34 x66 x98 y2 y34 y66 y98 z2 z34 z66 z98 x3 x35 x67 x99 y3 y35 y67 y99 z3 z35 z67 z99 x4 x36 x68 x100 y4 y36 y68 y100 z4 z36 z68 z100 x5 x37 x69 x101 b_1 y5 y37 y69 y101 z5 z37 z69 z101 x6 x38 x70 x102 y6 y38 y70 y102 z6 z38 z70 z102 x7 x39 x71 x103 y7 y39 y71 y103 z7 z39 z71 z103 x8 x40 x72 x104 y8 y40 y72 y104 z8 z40 z72 z104 x9 x41 x73 x105 y9 y41 y73 y105 z9 z41 z73 z105 x10 x42 x74 x106 y10 y42 y74 y106 b_2 z10 z42 z74 z106 x11 x43 x75 x107 y11 y43 y75 y107 z11 z43 z75 z107 x12 x44 x76 x108 y12 y44 y76 y108 z12 z44 z76 z108 x13 x45 x77 x109 y13 y45 y77 y109 z13 z45 z77 z109 x14 x46 x78 x110 y14 y46 y78 y110 z14 z46 z78 z110 x15 x47 x79 x111 y15 y47 y79 y111 z15 z47 z79 z111 b_3 x16 x48 x80 x112 y16 y48 y80 y112 z16 z48 z80 z112 x17 x49 x81 x113 y17 y49 y81 y113 z17 z49 z81 z113 x18 x50 x82 x114 y18 y50 y82 y114 z18 z50 z82 z114 x19 x51 x83 x115 y19 y51 y83 y115 z19 z51 z83 z115 x20 x52 x84 x116 y20 y52 y84 y116 z20 z52 z84 z116 x21 x53 x85 x117 b_4 y21 y53 y85 y117 z21 z53 z85 z117 x22 x54 x86 x118 y22 y54 y86 y118 z22 z54 z86 z118 x23 x55 x87 x119 y23 y55 y87 y119 z23 z55 z87 z119 x24 x56 x88 x120 y24 y56 y88 y120 z24 z56 z88 z120 x25 x57 x89 x121 y25 y57 y89 y121 z25 z57 z89 z121 x26 x58 x90 x122 y26 y58 y90 y122 b_5 z26 z58 z90 z122 x27 x59 x91 x123 y27 y59 y91 y123 z27 z59 z91 z123 x28 x60 x92 x124 y28 y60 y92 y124 z28 z60 z92 z124 x29 x61 x93 x125 y29 y61 y93 y125 z29 z61 z93 z125 x30 x62 x94 x126 y30 y62 y94 y126 z30 z62 z94 z126 x31 x63 x95 x127 y31 y63 y95 y127 z31 z63 z95 z127
                b_0 = YGroup2Zip(a_0, a_3, out b_1);
                b_2 = YGroup2Zip(a_1, a_4, out b_3);
                b_4 = YGroup2Zip(a_2, a_5, out b_5);
                // 3 a_0 x0 x16 x32 x48 x64 x80 x96 x112 y0 y16 y32 y48 y64 y80 y96 y112 z0 z16 z32 z48 z64 z80 z96 z112 x1 x17 x33 x49 x65 x81 x97 x113 y1 y17 y33 y49 y65 y81 y97 y113 z1 z17 z33 z49 z65 z81 z97 z113 x2 x18 x34 x50 x66 x82 x98 x114 y2 y18 y34 y50 y66 y82 y98 y114 a_1 z2 z18 z34 z50 z66 z82 z98 z114 x3 x19 x35 x51 x67 x83 x99 x115 y3 y19 y35 y51 y67 y83 y99 y115 z3 z19 z35 z51 z67 z83 z99 z115 x4 x20 x36 x52 x68 x84 x100 x116 y4 y20 y36 y52 y68 y84 y100 y116 z4 z20 z36 z52 z68 z84 z100 z116 x5 x21 x37 x53 x69 x85 x101 x117 a_2 y5 y21 y37 y53 y69 y85 y101 y117 z5 z21 z37 z53 z69 z85 z101 z117 x6 x22 x38 x54 x70 x86 x102 x118 y6 y22 y38 y54 y70 y86 y102 y118 z6 z22 z38 z54 z70 z86 z102 z118 x7 x23 x39 x55 x71 x87 x103 x119 y7 y23 y39 y55 y71 y87 y103 y119 z7 z23 z39 z55 z71 z87 z103 z119 a_3 x8 x24 x40 x56 x72 x88 x104 x120 y8 y24 y40 y56 y72 y88 y104 y120 z8 z24 z40 z56 z72 z88 z104 z120 x9 x25 x41 x57 x73 x89 x105 x121 y9 y25 y41 y57 y73 y89 y105 y121 z9 z25 z41 z57 z73 z89 z105 z121 x10 x26 x42 x58 x74 x90 x106 x122 y10 y26 y42 y58 y74 y90 y106 y122 a_4 z10 z26 z42 z58 z74 z90 z106 z122 x11 x27 x43 x59 x75 x91 x107 x123 y11 y27 y43 y59 y75 y91 y107 y123 z11 z27 z43 z59 z75 z91 z107 z123 x12 x28 x44 x60 x76 x92 x108 x124 y12 y28 y44 y60 y76 y92 y108 y124 z12 z28 z44 z60 z76 z92 z108 z124 x13 x29 x45 x61 x77 x93 x109 x125 a_5 y13 y29 y45 y61 y77 y93 y109 y125 z13 z29 z45 z61 z77 z93 z109 z125 x14 x30 x46 x62 x78 x94 x110 x126 y14 y30 y46 y62 y78 y94 y110 y126 z14 z30 z46 z62 z78 z94 z110 z126 x15 x31 x47 x63 x79 x95 x111 x127 y15 y31 y47 y63 y79 y95 y111 y127 z15 z31 z47 z63 z79 z95 z111 z127
                a_0 = YGroup2Zip(b_0, b_3, out a_1);
                a_2 = YGroup2Zip(b_1, b_4, out a_3);
                a_4 = YGroup2Zip(b_2, b_5, out a_5);
                // 4 b_0 x0 x8 x16 x24 x32 x40 x48 x56 x64 x72 x80 x88 x96 x104 x112 x120 y0 y8 y16 y24 y32 y40 y48 y56 y64 y72 y80 y88 y96 y104 y112 y120 z0 z8 z16 z24 z32 z40 z48 z56 z64 z72 z80 z88 z96 z104 z112 z120 x1 x9 x17 x25 x33 x41 x49 x57 x65 x73 x81 x89 x97 x105 x113 x121 b_1 y1 y9 y17 y25 y33 y41 y49 y57 y65 y73 y81 y89 y97 y105 y113 y121 z1 z9 z17 z25 z33 z41 z49 z57 z65 z73 z81 z89 z97 z105 z113 z121 x2 x10 x18 x26 x34 x42 x50 x58 x66 x74 x82 x90 x98 x106 x114 x122 y2 y10 y18 y26 y34 y42 y50 y58 y66 y74 y82 y90 y98 y106 y114 y122 b_2 z2 z10 z18 z26 z34 z42 z50 z58 z66 z74 z82 z90 z98 z106 z114 z122 x3 x11 x19 x27 x35 x43 x51 x59 x67 x75 x83 x91 x99 x107 x115 x123 y3 y11 y19 y27 y35 y43 y51 y59 y67 y75 y83 y91 y99 y107 y115 y123 z3 z11 z19 z27 z35 z43 z51 z59 z67 z75 z83 z91 z99 z107 z115 z123 b_3 x4 x12 x20 x28 x36 x44 x52 x60 x68 x76 x84 x92 x100 x108 x116 x124 y4 y12 y20 y28 y36 y44 y52 y60 y68 y76 y84 y92 y100 y108 y116 y124 z4 z12 z20 z28 z36 z44 z52 z60 z68 z76 z84 z92 z100 z108 z116 z124 x5 x13 x21 x29 x37 x45 x53 x61 x69 x77 x85 x93 x101 x109 x117 x125 b_4 y5 y13 y21 y29 y37 y45 y53 y61 y69 y77 y85 y93 y101 y109 y117 y125 z5 z13 z21 z29 z37 z45 z53 z61 z69 z77 z85 z93 z101 z109 z117 z125 x6 x14 x22 x30 x38 x46 x54 x62 x70 x78 x86 x94 x102 x110 x118 x126 y6 y14 y22 y30 y38 y46 y54 y62 y70 y78 y86 y94 y102 y110 y118 y126 b_5 z6 z14 z22 z30 z38 z46 z54 z62 z70 z78 z86 z94 z102 z110 z118 z126 x7 x15 x23 x31 x39 x47 x55 x63 x71 x79 x87 x95 x103 x111 x119 x127 y7 y15 y23 y31 y39 y47 y55 y63 y71 y79 y87 y95 y103 y111 y119 y127 z7 z15 z23 z31 z39 z47 z55 z63 z71 z79 z87 z95 z103 z111 z119 z127
                b_0 = YGroup2Zip(a_0, a_3, out b_1);
                b_2 = YGroup2Zip(a_1, a_4, out b_3);
                b_4 = YGroup2Zip(a_2, a_5, out b_5);
                // 5 a_0 x0 x4 x8 x12 x16 x20 x24 x28 x32 x36 x40 x44 x48 x52 x56 x60 x64 x68 x72 x76 x80 x84 x88 x92 x96 x100 x104 x108 x112 x116 x120 x124 y0 y4 y8 y12 y16 y20 y24 y28 y32 y36 y40 y44 y48 y52 y56 y60 y64 y68 y72 y76 y80 y84 y88 y92 y96 y100 y104 y108 y112 y116 y120 y124 a_1 z0 z4 z8 z12 z16 z20 z24 z28 z32 z36 z40 z44 z48 z52 z56 z60 z64 z68 z72 z76 z80 z84 z88 z92 z96 z100 z104 z108 z112 z116 z120 z124 x1 x5 x9 x13 x17 x21 x25 x29 x33 x37 x41 x45 x49 x53 x57 x61 x65 x69 x73 x77 x81 x85 x89 x93 x97 x101 x105 x109 x113 x117 x121 x125 a_2 y1 y5 y9 y13 y17 y21 y25 y29 y33 y37 y41 y45 y49 y53 y57 y61 y65 y69 y73 y77 y81 y85 y89 y93 y97 y101 y105 y109 y113 y117 y121 y125 z1 z5 z9 z13 z17 z21 z25 z29 z33 z37 z41 z45 z49 z53 z57 z61 z65 z69 z73 z77 z81 z85 z89 z93 z97 z101 z105 z109 z113 z117 z121 z125 a_3 x2 x6 x10 x14 x18 x22 x26 x30 x34 x38 x42 x46 x50 x54 x58 x62 x66 x70 x74 x78 x82 x86 x90 x94 x98 x102 x106 x110 x114 x118 x122 x126 y2 y6 y10 y14 y18 y22 y26 y30 y34 y38 y42 y46 y50 y54 y58 y62 y66 y70 y74 y78 y82 y86 y90 y94 y98 y102 y106 y110 y114 y118 y122 y126 a_4 z2 z6 z10 z14 z18 z22 z26 z30 z34 z38 z42 z46 z50 z54 z58 z62 z66 z70 z74 z78 z82 z86 z90 z94 z98 z102 z106 z110 z114 z118 z122 z126 x3 x7 x11 x15 x19 x23 x27 x31 x35 x39 x43 x47 x51 x55 x59 x63 x67 x71 x75 x79 x83 x87 x91 x95 x99 x103 x107 x111 x115 x119 x123 x127 a_5 y3 y7 y11 y15 y19 y23 y27 y31 y35 y39 y43 y47 y51 y55 y59 y63 y67 y71 y75 y79 y83 y87 y91 y95 y99 y103 y107 y111 y115 y119 y123 y127 z3 z7 z11 z15 z19 z23 z27 z31 z35 z39 z43 z47 z51 z55 z59 z63 z67 z71 z75 z79 z83 z87 z91 z95 z99 z103 z107 z111 z115 z119 z123 z127
                a_0 = YGroup2Zip(b_0, b_3, out a_1);
                a_2 = YGroup2Zip(b_1, b_4, out a_3);
                a_4 = YGroup2Zip(b_2, b_5, out a_5);
                // 6 b_0 x0 x2 x4 x6 x8 x10 x12 x14 x16 x18 x20 x22 x24 x26 x28 x30 x32 x34 x36 x38 x40 x42 x44 x46 x48 x50 x52 x54 x56 x58 x60 x62 x64 x66 x68 x70 x72 x74 x76 x78 x80 x82 x84 x86 x88 x90 x92 x94 x96 x98 x100 x102 x104 x106 x108 x110 x112 x114 x116 x118 x120 x122 x124 x126 b_1 y0 y2 y4 y6 y8 y10 y12 y14 y16 y18 y20 y22 y24 y26 y28 y30 y32 y34 y36 y38 y40 y42 y44 y46 y48 y50 y52 y54 y56 y58 y60 y62 y64 y66 y68 y70 y72 y74 y76 y78 y80 y82 y84 y86 y88 y90 y92 y94 y96 y98 y100 y102 y104 y106 y108 y110 y112 y114 y116 y118 y120 y122 y124 y126 b_2 z0 z2 z4 z6 z8 z10 z12 z14 z16 z18 z20 z22 z24 z26 z28 z30 z32 z34 z36 z38 z40 z42 z44 z46 z48 z50 z52 z54 z56 z58 z60 z62 z64 z66 z68 z70 z72 z74 z76 z78 z80 z82 z84 z86 z88 z90 z92 z94 z96 z98 z100 z102 z104 z106 z108 z110 z112 z114 z116 z118 z120 z122 z124 z126 b_3 x1 x3 x5 x7 x9 x11 x13 x15 x17 x19 x21 x23 x25 x27 x29 x31 x33 x35 x37 x39 x41 x43 x45 x47 x49 x51 x53 x55 x57 x59 x61 x63 x65 x67 x69 x71 x73 x75 x77 x79 x81 x83 x85 x87 x89 x91 x93 x95 x97 x99 x101 x103 x105 x107 x109 x111 x113 x115 x117 x119 x121 x123 x125 x127 b_4 y1 y3 y5 y7 y9 y11 y13 y15 y17 y19 y21 y23 y25 y27 y29 y31 y33 y35 y37 y39 y41 y43 y45 y47 y49 y51 y53 y55 y57 y59 y61 y63 y65 y67 y69 y71 y73 y75 y77 y79 y81 y83 y85 y87 y89 y91 y93 y95 y97 y99 y101 y103 y105 y107 y109 y111 y113 y115 y117 y119 y121 y123 y125 y127 b_5 z1 z3 z5 z7 z9 z11 z13 z15 z17 z19 z21 z23 z25 z27 z29 z31 z33 z35 z37 z39 z41 z43 z45 z47 z49 z51 z53 z55 z57 z59 z61 z63 z65 z67 z69 z71 z73 z75 z77 z79 z81 z83 z85 z87 z89 z91 z93 z95 z97 z99 z101 z103 z105 z107 z109 z111 z113 z115 z117 z119 z121 z123 z125 z127
                b_0 = YGroup2Zip(a_0, a_3, out b_1);
                b_2 = YGroup2Zip(a_1, a_4, out b_3);
                b_4 = YGroup2Zip(a_2, a_5, out b_5);
                // 7 a_0 x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 x16 x17 x18 x19 x20 x21 x22 x23 x24 x25 x26 x27 x28 x29 x30 x31 x32 x33 x34 x35 x36 x37 x38 x39 x40 x41 x42 x43 x44 x45 x46 x47 x48 x49 x50 x51 x52 x53 x54 x55 x56 x57 x58 x59 x60 x61 x62 x63 a_1 x64 x65 x66 x67 x68 x69 x70 x71 x72 x73 x74 x75 x76 x77 x78 x79 x80 x81 x82 x83 x84 x85 x86 x87 x88 x89 x90 x91 x92 x93 x94 x95 x96 x97 x98 x99 x100 x101 x102 x103 x104 x105 x106 x107 x108 x109 x110 x111 x112 x113 x114 x115 x116 x117 x118 x119 x120 x121 x122 x123 x124 x125 x126 x127 a_2 y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 y16 y17 y18 y19 y20 y21 y22 y23 y24 y25 y26 y27 y28 y29 y30 y31 y32 y33 y34 y35 y36 y37 y38 y39 y40 y41 y42 y43 y44 y45 y46 y47 y48 y49 y50 y51 y52 y53 y54 y55 y56 y57 y58 y59 y60 y61 y62 y63 a_3 y64 y65 y66 y67 y68 y69 y70 y71 y72 y73 y74 y75 y76 y77 y78 y79 y80 y81 y82 y83 y84 y85 y86 y87 y88 y89 y90 y91 y92 y93 y94 y95 y96 y97 y98 y99 y100 y101 y102 y103 y104 y105 y106 y107 y108 y109 y110 y111 y112 y113 y114 y115 y116 y117 y118 y119 y120 y121 y122 y123 y124 y125 y126 y127 a_4 z0 z1 z2 z3 z4 z5 z6 z7 z8 z9 z10 z11 z12 z13 z14 z15 z16 z17 z18 z19 z20 z21 z22 z23 z24 z25 z26 z27 z28 z29 z30 z31 z32 z33 z34 z35 z36 z37 z38 z39 z40 z41 z42 z43 z44 z45 z46 z47 z48 z49 z50 z51 z52 z53 z54 z55 z56 z57 z58 z59 z60 z61 z62 z63 a_5 z64 z65 z66 z67 z68 z69 z70 z71 z72 z73 z74 z75 z76 z77 z78 z79 z80 z81 z82 z83 z84 z85 z86 z87 z88 z89 z90 z91 z92 z93 z94 z95 z96 z97 z98 z99 z100 z101 z102 z103 z104 z105 z106 z107 z108 z109 z110 z111 z112 z113 z114 z115 z116 z117 z118 z119 z120 z121 z122 z123 z124 z125 z126 z127
                a_0 = YGroup2Zip(b_0, b_3, out a_1);
                a_2 = YGroup2Zip(b_1, b_4, out a_3);
                a_4 = YGroup2Zip(b_2, b_5, out a_5);
                xB = a_1;
                y = a_2;
                yB = a_3;
                z = a_4;
                zB = a_5;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup3UnzipX2_Zip(Vector512<short> data0, Vector512<short> data1, Vector512<short> data2, Vector512<short> data3, Vector512<short> data4, Vector512<short> data5, out Vector512<short> xB, out Vector512<short> y, out Vector512<short> yB, out Vector512<short> z, out Vector512<short> zB) {
                var d0 = YGroup3UnzipX2_Zip(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), data3.AsUInt16(), data4.AsUInt16(), data5.AsUInt16(), out var d1, out var d2, out var d3, out var d4, out var d5);
                xB = d1.AsInt16();
                y = d2.AsInt16();
                yB = d3.AsInt16();
                z = d4.AsInt16();
                zB = d5.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup3UnzipX2_Zip(Vector512<ushort> data0, Vector512<ushort> data1, Vector512<ushort> data2, Vector512<ushort> data3, Vector512<ushort> data4, Vector512<ushort> data5, out Vector512<ushort> xB, out Vector512<ushort> y, out Vector512<ushort> yB, out Vector512<ushort> z, out Vector512<ushort> zB) {
                Vector512<ushort> a_0, a_1, a_2, a_3, a_4, a_5, b_0, b_1, b_2, b_3, b_4, b_5;
                // 0 data0 x0 y0 z0 x1 y1 z1 x2 y2 z2 x3 y3 z3 x4 y4 z4 x5 y5 z5 x6 y6 z6 x7 y7 z7 x8 y8 z8 x9 y9 z9 x10 y10 data1 z10 x11 y11 z11 x12 y12 z12 x13 y13 z13 x14 y14 z14 x15 y15 z15 x16 y16 z16 x17 y17 z17 x18 y18 z18 x19 y19 z19 x20 y20 z20 x21 data2 y21 z21 x22 y22 z22 x23 y23 z23 x24 y24 z24 x25 y25 z25 x26 y26 z26 x27 y27 z27 x28 y28 z28 x29 y29 z29 x30 y30 z30 x31 y31 z31 data3 x32 y32 z32 x33 y33 z33 x34 y34 z34 x35 y35 z35 x36 y36 z36 x37 y37 z37 x38 y38 z38 x39 y39 z39 x40 y40 z40 x41 y41 z41 x42 y42 data4 z42 x43 y43 z43 x44 y44 z44 x45 y45 z45 x46 y46 z46 x47 y47 z47 x48 y48 z48 x49 y49 z49 x50 y50 z50 x51 y51 z51 x52 y52 z52 x53 data5 y53 z53 x54 y54 z54 x55 y55 z55 x56 y56 z56 x57 y57 z57 x58 y58 z58 x59 y59 z59 x60 y60 z60 x61 y61 z61 x62 y62 z62 x63 y63 z63
                // 1 a_0 x0 x32 y0 y32 z0 z32 x1 x33 y1 y33 z1 z33 x2 x34 y2 y34 z2 z34 x3 x35 y3 y35 z3 z35 x4 x36 y4 y36 z4 z36 x5 x37 a_1 y5 y37 z5 z37 x6 x38 y6 y38 z6 z38 x7 x39 y7 y39 z7 z39 x8 x40 y8 y40 z8 z40 x9 x41 y9 y41 z9 z41 x10 x42 y10 y42 a_2 z10 z42 x11 x43 y11 y43 z11 z43 x12 x44 y12 y44 z12 z44 x13 x45 y13 y45 z13 z45 x14 x46 y14 y46 z14 z46 x15 x47 y15 y47 z15 z47 a_3 x16 x48 y16 y48 z16 z48 x17 x49 y17 y49 z17 z49 x18 x50 y18 y50 z18 z50 x19 x51 y19 y51 z19 z51 x20 x52 y20 y52 z20 z52 x21 x53 a_4 y21 y53 z21 z53 x22 x54 y22 y54 z22 z54 x23 x55 y23 y55 z23 z55 x24 x56 y24 y56 z24 z56 x25 x57 y25 y57 z25 z57 x26 x58 y26 y58 a_5 z26 z58 x27 x59 y27 y59 z27 z59 x28 x60 y28 y60 z28 z60 x29 x61 y29 y61 z29 z61 x30 x62 y30 y62 z30 z62 x31 x63 y31 y63 z31 z63
                a_0 = YGroup2Zip(data0, data3, out a_1);
                a_2 = YGroup2Zip(data1, data4, out a_3);
                a_4 = YGroup2Zip(data2, data5, out a_5);
                // 2 b_0 x0 x16 x32 x48 y0 y16 y32 y48 z0 z16 z32 z48 x1 x17 x33 x49 y1 y17 y33 y49 z1 z17 z33 z49 x2 x18 x34 x50 y2 y18 y34 y50 b_1 z2 z18 z34 z50 x3 x19 x35 x51 y3 y19 y35 y51 z3 z19 z35 z51 x4 x20 x36 x52 y4 y20 y36 y52 z4 z20 z36 z52 x5 x21 x37 x53 b_2 y5 y21 y37 y53 z5 z21 z37 z53 x6 x22 x38 x54 y6 y22 y38 y54 z6 z22 z38 z54 x7 x23 x39 x55 y7 y23 y39 y55 z7 z23 z39 z55 b_3 x8 x24 x40 x56 y8 y24 y40 y56 z8 z24 z40 z56 x9 x25 x41 x57 y9 y25 y41 y57 z9 z25 z41 z57 x10 x26 x42 x58 y10 y26 y42 y58 b_4 z10 z26 z42 z58 x11 x27 x43 x59 y11 y27 y43 y59 z11 z27 z43 z59 x12 x28 x44 x60 y12 y28 y44 y60 z12 z28 z44 z60 x13 x29 x45 x61 b_5 y13 y29 y45 y61 z13 z29 z45 z61 x14 x30 x46 x62 y14 y30 y46 y62 z14 z30 z46 z62 x15 x31 x47 x63 y15 y31 y47 y63 z15 z31 z47 z63
                b_0 = YGroup2Zip(a_0, a_3, out b_1);
                b_2 = YGroup2Zip(a_1, a_4, out b_3);
                b_4 = YGroup2Zip(a_2, a_5, out b_5);
                // 3 a_0 x0 x8 x16 x24 x32 x40 x48 x56 y0 y8 y16 y24 y32 y40 y48 y56 z0 z8 z16 z24 z32 z40 z48 z56 x1 x9 x17 x25 x33 x41 x49 x57 a_1 y1 y9 y17 y25 y33 y41 y49 y57 z1 z9 z17 z25 z33 z41 z49 z57 x2 x10 x18 x26 x34 x42 x50 x58 y2 y10 y18 y26 y34 y42 y50 y58 a_2 z2 z10 z18 z26 z34 z42 z50 z58 x3 x11 x19 x27 x35 x43 x51 x59 y3 y11 y19 y27 y35 y43 y51 y59 z3 z11 z19 z27 z35 z43 z51 z59 a_3 x4 x12 x20 x28 x36 x44 x52 x60 y4 y12 y20 y28 y36 y44 y52 y60 z4 z12 z20 z28 z36 z44 z52 z60 x5 x13 x21 x29 x37 x45 x53 x61 a_4 y5 y13 y21 y29 y37 y45 y53 y61 z5 z13 z21 z29 z37 z45 z53 z61 x6 x14 x22 x30 x38 x46 x54 x62 y6 y14 y22 y30 y38 y46 y54 y62 a_5 z6 z14 z22 z30 z38 z46 z54 z62 x7 x15 x23 x31 x39 x47 x55 x63 y7 y15 y23 y31 y39 y47 y55 y63 z7 z15 z23 z31 z39 z47 z55 z63
                a_0 = YGroup2Zip(b_0, b_3, out a_1);
                a_2 = YGroup2Zip(b_1, b_4, out a_3);
                a_4 = YGroup2Zip(b_2, b_5, out a_5);
                // 4 b_0 x0 x4 x8 x12 x16 x20 x24 x28 x32 x36 x40 x44 x48 x52 x56 x60 y0 y4 y8 y12 y16 y20 y24 y28 y32 y36 y40 y44 y48 y52 y56 y60 b_1 z0 z4 z8 z12 z16 z20 z24 z28 z32 z36 z40 z44 z48 z52 z56 z60 x1 x5 x9 x13 x17 x21 x25 x29 x33 x37 x41 x45 x49 x53 x57 x61 b_2 y1 y5 y9 y13 y17 y21 y25 y29 y33 y37 y41 y45 y49 y53 y57 y61 z1 z5 z9 z13 z17 z21 z25 z29 z33 z37 z41 z45 z49 z53 z57 z61 b_3 x2 x6 x10 x14 x18 x22 x26 x30 x34 x38 x42 x46 x50 x54 x58 x62 y2 y6 y10 y14 y18 y22 y26 y30 y34 y38 y42 y46 y50 y54 y58 y62 b_4 z2 z6 z10 z14 z18 z22 z26 z30 z34 z38 z42 z46 z50 z54 z58 z62 x3 x7 x11 x15 x19 x23 x27 x31 x35 x39 x43 x47 x51 x55 x59 x63 b_5 y3 y7 y11 y15 y19 y23 y27 y31 y35 y39 y43 y47 y51 y55 y59 y63 z3 z7 z11 z15 z19 z23 z27 z31 z35 z39 z43 z47 z51 z55 z59 z63
                b_0 = YGroup2Zip(a_0, a_3, out b_1);
                b_2 = YGroup2Zip(a_1, a_4, out b_3);
                b_4 = YGroup2Zip(a_2, a_5, out b_5);
                // 5 a_0 x0 x2 x4 x6 x8 x10 x12 x14 x16 x18 x20 x22 x24 x26 x28 x30 x32 x34 x36 x38 x40 x42 x44 x46 x48 x50 x52 x54 x56 x58 x60 x62 a_1 y0 y2 y4 y6 y8 y10 y12 y14 y16 y18 y20 y22 y24 y26 y28 y30 y32 y34 y36 y38 y40 y42 y44 y46 y48 y50 y52 y54 y56 y58 y60 y62 a_2 z0 z2 z4 z6 z8 z10 z12 z14 z16 z18 z20 z22 z24 z26 z28 z30 z32 z34 z36 z38 z40 z42 z44 z46 z48 z50 z52 z54 z56 z58 z60 z62 a_3 x1 x3 x5 x7 x9 x11 x13 x15 x17 x19 x21 x23 x25 x27 x29 x31 x33 x35 x37 x39 x41 x43 x45 x47 x49 x51 x53 x55 x57 x59 x61 x63 a_4 y1 y3 y5 y7 y9 y11 y13 y15 y17 y19 y21 y23 y25 y27 y29 y31 y33 y35 y37 y39 y41 y43 y45 y47 y49 y51 y53 y55 y57 y59 y61 y63 a_5 z1 z3 z5 z7 z9 z11 z13 z15 z17 z19 z21 z23 z25 z27 z29 z31 z33 z35 z37 z39 z41 z43 z45 z47 z49 z51 z53 z55 z57 z59 z61 z63
                a_0 = YGroup2Zip(b_0, b_3, out a_1);
                a_2 = YGroup2Zip(b_1, b_4, out a_3);
                a_4 = YGroup2Zip(b_2, b_5, out a_5);
                // 6 b_0 x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 x16 x17 x18 x19 x20 x21 x22 x23 x24 x25 x26 x27 x28 x29 x30 x31 b_1 x32 x33 x34 x35 x36 x37 x38 x39 x40 x41 x42 x43 x44 x45 x46 x47 x48 x49 x50 x51 x52 x53 x54 x55 x56 x57 x58 x59 x60 x61 x62 x63 b_2 y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 y16 y17 y18 y19 y20 y21 y22 y23 y24 y25 y26 y27 y28 y29 y30 y31 b_3 y32 y33 y34 y35 y36 y37 y38 y39 y40 y41 y42 y43 y44 y45 y46 y47 y48 y49 y50 y51 y52 y53 y54 y55 y56 y57 y58 y59 y60 y61 y62 y63 b_4 z0 z1 z2 z3 z4 z5 z6 z7 z8 z9 z10 z11 z12 z13 z14 z15 z16 z17 z18 z19 z20 z21 z22 z23 z24 z25 z26 z27 z28 z29 z30 z31 b_5 z32 z33 z34 z35 z36 z37 z38 z39 z40 z41 z42 z43 z44 z45 z46 z47 z48 z49 z50 z51 z52 z53 z54 z55 z56 z57 z58 z59 z60 z61 z62 z63
                b_0 = YGroup2Zip(a_0, a_3, out b_1);
                b_2 = YGroup2Zip(a_1, a_4, out b_3);
                b_4 = YGroup2Zip(a_2, a_5, out b_5);
                xB = b_1;
                y = b_2;
                yB = b_3;
                z = b_4;
                zB = b_5;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup3UnzipX2_Zip(Vector512<int> data0, Vector512<int> data1, Vector512<int> data2, Vector512<int> data3, Vector512<int> data4, Vector512<int> data5, out Vector512<int> xB, out Vector512<int> y, out Vector512<int> yB, out Vector512<int> z, out Vector512<int> zB) {
                var d0 = YGroup3UnzipX2_Zip(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), data4.AsUInt32(), data5.AsUInt32(), out var d1, out var d2, out var d3, out var d4, out var d5);
                xB = d1.AsInt32();
                y = d2.AsInt32();
                yB = d3.AsInt32();
                z = d4.AsInt32();
                zB = d5.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3UnzipX2(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup3UnzipX2_Zip(Vector512<uint> data0, Vector512<uint> data1, Vector512<uint> data2, Vector512<uint> data3, Vector512<uint> data4, Vector512<uint> data5, out Vector512<uint> xB, out Vector512<uint> y, out Vector512<uint> yB, out Vector512<uint> z, out Vector512<uint> zB) {
                Vector512<uint> a_0, a_1, a_2, a_3, a_4, a_5, b_0, b_1, b_2, b_3, b_4, b_5;
                // 0 data0 x0 y0 z0 x1 y1 z1 x2 y2 z2 x3 y3 z3 x4 y4 z4 x5 data1 y5 z5 x6 y6 z6 x7 y7 z7 x8 y8 z8 x9 y9 z9 x10 y10 data2 z10 x11 y11 z11 x12 y12 z12 x13 y13 z13 x14 y14 z14 x15 y15 z15 data3 x16 y16 z16 x17 y17 z17 x18 y18 z18 x19 y19 z19 x20 y20 z20 x21 data4 y21 z21 x22 y22 z22 x23 y23 z23 x24 y24 z24 x25 y25 z25 x26 y26 data5 z26 x27 y27 z27 x28 y28 z28 x29 y29 z29 x30 y30 z30 x31 y31 z31
                // 1 a_0 x0 x16 y0 y16 z0 z16 x1 x17 y1 y17 z1 z17 x2 x18 y2 y18 a_1 z2 z18 x3 x19 y3 y19 z3 z19 x4 x20 y4 y20 z4 z20 x5 x21 a_2 y5 y21 z5 z21 x6 x22 y6 y22 z6 z22 x7 x23 y7 y23 z7 z23 a_3 x8 x24 y8 y24 z8 z24 x9 x25 y9 y25 z9 z25 x10 x26 y10 y26 a_4 z10 z26 x11 x27 y11 y27 z11 z27 x12 x28 y12 y28 z12 z28 x13 x29 a_5 y13 y29 z13 z29 x14 x30 y14 y30 z14 z30 x15 x31 y15 y31 z15 z31
                a_0 = YGroup2Zip(data0, data3, out a_1);
                a_2 = YGroup2Zip(data1, data4, out a_3);
                a_4 = YGroup2Zip(data2, data5, out a_5);
                // 2 b_0 x0 x8 x16 x24 y0 y8 y16 y24 z0 z8 z16 z24 x1 x9 x17 x25 b_1 y1 y9 y17 y25 z1 z9 z17 z25 x2 x10 x18 x26 y2 y10 y18 y26 b_2 z2 z10 z18 z26 x3 x11 x19 x27 y3 y11 y19 y27 z3 z11 z19 z27 b_3 x4 x12 x20 x28 y4 y12 y20 y28 z4 z12 z20 z28 x5 x13 x21 x29 b_4 y5 y13 y21 y29 z5 z13 z21 z29 x6 x14 x22 x30 y6 y14 y22 y30 b_5 z6 z14 z22 z30 x7 x15 x23 x31 y7 y15 y23 y31 z7 z15 z23 z31
                b_0 = YGroup2Zip(a_0, a_3, out b_1);
                b_2 = YGroup2Zip(a_1, a_4, out b_3);
                b_4 = YGroup2Zip(a_2, a_5, out b_5);
                // 3 a_0 x0 x4 x8 x12 x16 x20 x24 x28 y0 y4 y8 y12 y16 y20 y24 y28 a_1 z0 z4 z8 z12 z16 z20 z24 z28 x1 x5 x9 x13 x17 x21 x25 x29 a_2 y1 y5 y9 y13 y17 y21 y25 y29 z1 z5 z9 z13 z17 z21 z25 z29 a_3 x2 x6 x10 x14 x18 x22 x26 x30 y2 y6 y10 y14 y18 y22 y26 y30 a_4 z2 z6 z10 z14 z18 z22 z26 z30 x3 x7 x11 x15 x19 x23 x27 x31 a_5 y3 y7 y11 y15 y19 y23 y27 y31 z3 z7 z11 z15 z19 z23 z27 z31
                a_0 = YGroup2Zip(b_0, b_3, out a_1);
                a_2 = YGroup2Zip(b_1, b_4, out a_3);
                a_4 = YGroup2Zip(b_2, b_5, out a_5);
                // 4 b_0 x0 x2 x4 x6 x8 x10 x12 x14 x16 x18 x20 x22 x24 x26 x28 x30 b_1 y0 y2 y4 y6 y8 y10 y12 y14 y16 y18 y20 y22 y24 y26 y28 y30 b_2 z0 z2 z4 z6 z8 z10 z12 z14 z16 z18 z20 z22 z24 z26 z28 z30 b_3 x1 x3 x5 x7 x9 x11 x13 x15 x17 x19 x21 x23 x25 x27 x29 x31 b_4 y1 y3 y5 y7 y9 y11 y13 y15 y17 y19 y21 y23 y25 y27 y29 y31 b_5 z1 z3 z5 z7 z9 z11 z13 z15 z17 z19 z21 z23 z25 z27 z29 z31
                b_0 = YGroup2Zip(a_0, a_3, out b_1);
                b_2 = YGroup2Zip(a_1, a_4, out b_3);
                b_4 = YGroup2Zip(a_2, a_5, out b_5);
                // 5 a_0 x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 a_1 x16 x17 x18 x19 x20 x21 x22 x23 x24 x25 x26 x27 x28 x29 x30 x31 a_2 y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 a_3 y16 y17 y18 y19 y20 y21 y22 y23 y24 y25 y26 y27 y28 y29 y30 y31 a_4 z0 z1 z2 z3 z4 z5 z6 z7 z8 z9 z10 z11 z12 z13 z14 z15 a_5 z16 z17 z18 z19 z20 z21 z22 z23 z24 z25 z26 z27 z28 z29 z30 z31
                a_0 = YGroup2Zip(b_0, b_3, out a_1);
                a_2 = YGroup2Zip(b_1, b_4, out a_3);
                a_4 = YGroup2Zip(b_2, b_5, out a_5);
                xB = a_1;
                y = a_2;
                yB = a_3;
                z = a_4;
                zB = a_5;
                return a_0;
            }

#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup3Zip_AcceleratedTypes {
                get {
                    return YGroup2Unzip_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{float}, Vector512{float}, Vector512{float}, out Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup3Zip(Vector512<float> x, Vector512<float> y, Vector512<float> z, out Vector512<float> data1, out Vector512<float> data2) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3Zip_ByShorter(x, y, z, out data1, out data2);
#else
                return YGroup3Zip_Basic(x, y, z, out data1, out data2);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{double}, Vector512{double}, Vector512{double}, out Vector512{double}, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup3Zip(Vector512<double> x, Vector512<double> y, Vector512<double> z, out Vector512<double> data1, out Vector512<double> data2) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3Zip_ByShorter(x, y, z, out data1, out data2);
#else
                return YGroup3Zip_Basic(x, y, z, out data1, out data2);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup3Zip(Vector512<sbyte> x, Vector512<sbyte> y, Vector512<sbyte> z, out Vector512<sbyte> data1, out Vector512<sbyte> data2) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3Zip_ByShorter(x, y, z, out data1, out data2);
#else
                return YGroup3Zip_Basic(x, y, z, out data1, out data2);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup3Zip(Vector512<byte> x, Vector512<byte> y, Vector512<byte> z, out Vector512<byte> data1, out Vector512<byte> data2) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3Zip_ByShorter(x, y, z, out data1, out data2);
#else
                return YGroup3Zip_Basic(x, y, z, out data1, out data2);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup3Zip(Vector512<short> x, Vector512<short> y, Vector512<short> z, out Vector512<short> data1, out Vector512<short> data2) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3Zip_ByShorter(x, y, z, out data1, out data2);
#else
                return YGroup3Zip_Basic(x, y, z, out data1, out data2);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup3Zip(Vector512<ushort> x, Vector512<ushort> y, Vector512<ushort> z, out Vector512<ushort> data1, out Vector512<ushort> data2) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3Zip_ByShorter(x, y, z, out data1, out data2);
#else
                return YGroup3Zip_Basic(x, y, z, out data1, out data2);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup3Zip(Vector512<int> x, Vector512<int> y, Vector512<int> z, out Vector512<int> data1, out Vector512<int> data2) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3Zip_ByShorter(x, y, z, out data1, out data2);
#else
                return YGroup3Zip_Basic(x, y, z, out data1, out data2);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup3Zip(Vector512<uint> x, Vector512<uint> y, Vector512<uint> z, out Vector512<uint> data1, out Vector512<uint> data2) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3Zip_ByShorter(x, y, z, out data1, out data2);
#else
                return YGroup3Zip_Basic(x, y, z, out data1, out data2);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{long}, Vector512{long}, Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup3Zip(Vector512<long> x, Vector512<long> y, Vector512<long> z, out Vector512<long> data1, out Vector512<long> data2) {
                return YGroup3Zip_Basic(x, y, z, out data1, out data2);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup3Zip(Vector512<ulong> x, Vector512<ulong> y, Vector512<ulong> z, out Vector512<ulong> data1, out Vector512<ulong> data2) {
                return YGroup3Zip_Basic(x, y, z, out data1, out data2);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip_Bit128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<T> YGroup3Zip_Bit128<T>(Vector512<T> x, Vector512<T> y, Vector512<T> z, out Vector512<T> data1, out Vector512<T> data2) where T : struct {
                // f({x[0], x[1], x[2], x[3]}, {y[0], y[1], y[2], y[3]}, {z[0], z[1], z[2], z[3]}) = ({x[0], y[0], z[0], x[1]}, {y[1], z[1], x[2], y[2]}, {z[2], x[3], y[3], z[3]})
                var b0 = x.GetLower();
                var b1 = x.GetUpper();
                var b2 = y.GetLower();
                var b3 = y.GetUpper();
                var b4 = z.GetLower();
                var b5 = z.GetUpper();
                var c0 = b0.WithUpper(b2.GetLower()).ToVector512Unsafe().WithUpper(b4.WithUpper(b0.GetUpper()));
                var c1 = b2.GetUpper().ToVector256Unsafe().WithUpper(b4.GetUpper()).ToVector512Unsafe().WithUpper(b1.WithUpper(b3.GetLower()));
                var c2 = b5.WithUpper(b1.GetUpper()).ToVector512Unsafe().WithUpper(b3.GetUpper().ToVector256Unsafe().WithUpper(b5.GetUpper()));
                data1 = c1;
                data2 = c2;
                return c0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{float}, Vector512{float}, Vector512{float}, out Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup3Zip_Basic(Vector512<float> x, Vector512<float> y, Vector512<float> z, out Vector512<float> data1, out Vector512<float> data2) {
                var d0 = YGroup3Zip_Basic(x.AsUInt32(), y.AsUInt32(), z.AsUInt32(), out var d1, out var d2);
                data1 = d1.AsSingle();
                data2 = d2.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{double}, Vector512{double}, Vector512{double}, out Vector512{double}, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup3Zip_Basic(Vector512<double> x, Vector512<double> y, Vector512<double> z, out Vector512<double> data1, out Vector512<double> data2) {
                var d0 = YGroup3Zip_Basic(x.AsUInt64(), y.AsUInt64(), z.AsUInt64(), out var d1, out var d2);
                data1 = d1.AsDouble();
                data2 = d2.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup3Zip_Basic(Vector512<sbyte> x, Vector512<sbyte> y, Vector512<sbyte> z, out Vector512<sbyte> data1, out Vector512<sbyte> data2) {
                var d0 = YGroup3Zip_Basic(x.AsByte(), y.AsByte(), z.AsByte(), out var d1, out var d2);
                data1 = d1.AsSByte();
                data2 = d2.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup3Zip_Basic(Vector512<byte> x, Vector512<byte> y, Vector512<byte> z, out Vector512<byte> data1, out Vector512<byte> data2) {
                Span<Vector512<byte>> rt = stackalloc Vector512<byte>[3];
                ref byte px = ref Unsafe.As<Vector512<byte>, byte>(ref x);
                ref byte py = ref Unsafe.As<Vector512<byte>, byte>(ref y);
                ref byte pz = ref Unsafe.As<Vector512<byte>, byte>(ref z);
                Span<byte> q = MemoryMarshal.Cast<Vector512<byte>, byte>(rt);
                int idx = 0;
                for (int i = 0; i < Vector512<byte>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    q[idx + 2] = Unsafe.Add(ref pz, i);
                    idx += 3;
                }
                data1 = rt[1];
                data2 = rt[2];
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup3Zip_Basic(Vector512<short> x, Vector512<short> y, Vector512<short> z, out Vector512<short> data1, out Vector512<short> data2) {
                var d0 = YGroup3Zip_Basic(x.AsUInt16(), y.AsUInt16(), z.AsUInt16(), out var d1, out var d2);
                data1 = d1.AsInt16();
                data2 = d2.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup3Zip_Basic(Vector512<ushort> x, Vector512<ushort> y, Vector512<ushort> z, out Vector512<ushort> data1, out Vector512<ushort> data2) {
                Span<Vector512<ushort>> rt = stackalloc Vector512<ushort>[3];
                ref ushort px = ref Unsafe.As<Vector512<ushort>, ushort>(ref x);
                ref ushort py = ref Unsafe.As<Vector512<ushort>, ushort>(ref y);
                ref ushort pz = ref Unsafe.As<Vector512<ushort>, ushort>(ref z);
                Span<ushort> q = MemoryMarshal.Cast<Vector512<ushort>, ushort>(rt);
                int idx = 0;
                for (int i = 0; i < Vector512<ushort>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    q[idx + 2] = Unsafe.Add(ref pz, i);
                    idx += 3;
                }
                data1 = rt[1];
                data2 = rt[2];
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup3Zip_Basic(Vector512<int> x, Vector512<int> y, Vector512<int> z, out Vector512<int> data1, out Vector512<int> data2) {
                var d0 = YGroup3Zip_Basic(x.AsUInt32(), y.AsUInt32(), z.AsUInt32(), out var d1, out var d2);
                data1 = d1.AsInt32();
                data2 = d2.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup3Zip_Basic(Vector512<uint> x, Vector512<uint> y, Vector512<uint> z, out Vector512<uint> data1, out Vector512<uint> data2) {
                Span<Vector512<uint>> rt = stackalloc Vector512<uint>[3];
                ref uint px = ref Unsafe.As<Vector512<uint>, uint>(ref x);
                ref uint py = ref Unsafe.As<Vector512<uint>, uint>(ref y);
                ref uint pz = ref Unsafe.As<Vector512<uint>, uint>(ref z);
                Span<uint> q = MemoryMarshal.Cast<Vector512<uint>, uint>(rt);
                int idx = 0;
                for (int i = 0; i < Vector512<uint>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    q[idx + 2] = Unsafe.Add(ref pz, i);
                    idx += 3;
                }
                data1 = rt[1];
                data2 = rt[2];
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{long}, Vector512{long}, Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup3Zip_Basic(Vector512<long> x, Vector512<long> y, Vector512<long> z, out Vector512<long> data1, out Vector512<long> data2) {
                var d0 = YGroup3Zip_Basic(x.AsUInt64(), y.AsUInt64(), z.AsUInt64(), out var d1, out var d2);
                data1 = d1.AsInt64();
                data2 = d2.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup3Zip_Basic(Vector512<ulong> x, Vector512<ulong> y, Vector512<ulong> z, out Vector512<ulong> data1, out Vector512<ulong> data2) {
                Span<Vector512<ulong>> rt = stackalloc Vector512<ulong>[3];
                ref ulong px = ref Unsafe.As<Vector512<ulong>, ulong>(ref x);
                ref ulong py = ref Unsafe.As<Vector512<ulong>, ulong>(ref y);
                ref ulong pz = ref Unsafe.As<Vector512<ulong>, ulong>(ref z);
                Span<ulong> q = MemoryMarshal.Cast<Vector512<ulong>, ulong>(rt);
                int idx = 0;
                for (int i = 0; i < Vector512<ulong>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    q[idx + 2] = Unsafe.Add(ref pz, i);
                    idx += 3;
                }
                data1 = rt[1];
                data2 = rt[2];
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{float}, Vector512{float}, Vector512{float}, out Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup3Zip_ByShorter(Vector512<float> x, Vector512<float> y, Vector512<float> z, out Vector512<float> data1, out Vector512<float> data2) {
                var b0 = ShorterStatics.YGroup3ZipX2(x.GetLower(), x.GetUpper(), y.GetLower(), y.GetUpper(), z.GetLower(), z.GetUpper(), out var b1, out var b2, out var b3, out var b4, out var b5);
                var c0 = b0.ToVector512Unsafe().WithUpper(b1);
                var c1 = b2.ToVector512Unsafe().WithUpper(b3);
                var c2 = b4.ToVector512Unsafe().WithUpper(b5);
                data1 = c1;
                data2 = c2;
                return c0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{double}, Vector512{double}, Vector512{double}, out Vector512{double}, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup3Zip_ByShorter(Vector512<double> x, Vector512<double> y, Vector512<double> z, out Vector512<double> data1, out Vector512<double> data2) {
                var b0 = ShorterStatics.YGroup3ZipX2(x.GetLower(), x.GetUpper(), y.GetLower(), y.GetUpper(), z.GetLower(), z.GetUpper(), out var b1, out var b2, out var b3, out var b4, out var b5);
                var c0 = b0.ToVector512Unsafe().WithUpper(b1);
                var c1 = b2.ToVector512Unsafe().WithUpper(b3);
                var c2 = b4.ToVector512Unsafe().WithUpper(b5);
                data1 = c1;
                data2 = c2;
                return c0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup3Zip_ByShorter(Vector512<sbyte> x, Vector512<sbyte> y, Vector512<sbyte> z, out Vector512<sbyte> data1, out Vector512<sbyte> data2) {
                var b0 = ShorterStatics.YGroup3ZipX2(x.GetLower(), x.GetUpper(), y.GetLower(), y.GetUpper(), z.GetLower(), z.GetUpper(), out var b1, out var b2, out var b3, out var b4, out var b5);
                var c0 = b0.ToVector512Unsafe().WithUpper(b1);
                var c1 = b2.ToVector512Unsafe().WithUpper(b3);
                var c2 = b4.ToVector512Unsafe().WithUpper(b5);
                data1 = c1;
                data2 = c2;
                return c0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup3Zip_ByShorter(Vector512<byte> x, Vector512<byte> y, Vector512<byte> z, out Vector512<byte> data1, out Vector512<byte> data2) {
                var b0 = ShorterStatics.YGroup3ZipX2(x.GetLower(), x.GetUpper(), y.GetLower(), y.GetUpper(), z.GetLower(), z.GetUpper(), out var b1, out var b2, out var b3, out var b4, out var b5);
                var c0 = b0.ToVector512Unsafe().WithUpper(b1);
                var c1 = b2.ToVector512Unsafe().WithUpper(b3);
                var c2 = b4.ToVector512Unsafe().WithUpper(b5);
                data1 = c1;
                data2 = c2;
                return c0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup3Zip_ByShorter(Vector512<short> x, Vector512<short> y, Vector512<short> z, out Vector512<short> data1, out Vector512<short> data2) {
                var b0 = ShorterStatics.YGroup3ZipX2(x.GetLower(), x.GetUpper(), y.GetLower(), y.GetUpper(), z.GetLower(), z.GetUpper(), out var b1, out var b2, out var b3, out var b4, out var b5);
                var c0 = b0.ToVector512Unsafe().WithUpper(b1);
                var c1 = b2.ToVector512Unsafe().WithUpper(b3);
                var c2 = b4.ToVector512Unsafe().WithUpper(b5);
                data1 = c1;
                data2 = c2;
                return c0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup3Zip_ByShorter(Vector512<ushort> x, Vector512<ushort> y, Vector512<ushort> z, out Vector512<ushort> data1, out Vector512<ushort> data2) {
                var b0 = ShorterStatics.YGroup3ZipX2(x.GetLower(), x.GetUpper(), y.GetLower(), y.GetUpper(), z.GetLower(), z.GetUpper(), out var b1, out var b2, out var b3, out var b4, out var b5);
                var c0 = b0.ToVector512Unsafe().WithUpper(b1);
                var c1 = b2.ToVector512Unsafe().WithUpper(b3);
                var c2 = b4.ToVector512Unsafe().WithUpper(b5);
                data1 = c1;
                data2 = c2;
                return c0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup3Zip_ByShorter(Vector512<int> x, Vector512<int> y, Vector512<int> z, out Vector512<int> data1, out Vector512<int> data2) {
                var b0 = ShorterStatics.YGroup3ZipX2(x.GetLower(), x.GetUpper(), y.GetLower(), y.GetUpper(), z.GetLower(), z.GetUpper(), out var b1, out var b2, out var b3, out var b4, out var b5);
                var c0 = b0.ToVector512Unsafe().WithUpper(b1);
                var c1 = b2.ToVector512Unsafe().WithUpper(b3);
                var c2 = b4.ToVector512Unsafe().WithUpper(b5);
                data1 = c1;
                data2 = c2;
                return c0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup3Zip_ByShorter(Vector512<uint> x, Vector512<uint> y, Vector512<uint> z, out Vector512<uint> data1, out Vector512<uint> data2) {
                var b0 = ShorterStatics.YGroup3ZipX2(x.GetLower(), x.GetUpper(), y.GetLower(), y.GetUpper(), z.GetLower(), z.GetUpper(), out var b1, out var b2, out var b3, out var b4, out var b5);
                var c0 = b0.ToVector512Unsafe().WithUpper(b1);
                var c1 = b2.ToVector512Unsafe().WithUpper(b3);
                var c2 = b4.ToVector512Unsafe().WithUpper(b5);
                data1 = c1;
                data2 = c2;
                return c0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{long}, Vector512{long}, Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup3Zip_ByShorter(Vector512<long> x, Vector512<long> y, Vector512<long> z, out Vector512<long> data1, out Vector512<long> data2) {
                var b0 = ShorterStatics.YGroup3ZipX2(x.GetLower(), x.GetUpper(), y.GetLower(), y.GetUpper(), z.GetLower(), z.GetUpper(), out var b1, out var b2, out var b3, out var b4, out var b5);
                var c0 = b0.ToVector512Unsafe().WithUpper(b1);
                var c1 = b2.ToVector512Unsafe().WithUpper(b3);
                var c2 = b4.ToVector512Unsafe().WithUpper(b5);
                data1 = c1;
                data2 = c2;
                return c0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup3Zip_ByShorter(Vector512<ulong> x, Vector512<ulong> y, Vector512<ulong> z, out Vector512<ulong> data1, out Vector512<ulong> data2) {
                var b0 = ShorterStatics.YGroup3ZipX2(x.GetLower(), x.GetUpper(), y.GetLower(), y.GetUpper(), z.GetLower(), z.GetUpper(), out var b1, out var b2, out var b3, out var b4, out var b5);
                var c0 = b0.ToVector512Unsafe().WithUpper(b1);
                var c1 = b2.ToVector512Unsafe().WithUpper(b3);
                var c2 = b4.ToVector512Unsafe().WithUpper(b5);
                data1 = c1;
                data2 = c2;
                return c0;
            }

#if VECTOR_HAS_METHOD

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{float}, Vector512{float}, Vector512{float}, out Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup3Zip_ByX2Unzip(Vector512<float> x, Vector512<float> y, Vector512<float> z, out Vector512<float> data1, out Vector512<float> data2) {
                return YGroup3ZipX2_Unzip(x, x, y, y, z, z, out data1, out data2, out _, out _, out _);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup3Zip_ByX2Unzip(Vector512<sbyte> x, Vector512<sbyte> y, Vector512<sbyte> z, out Vector512<sbyte> data1, out Vector512<sbyte> data2) {
                return YGroup3ZipX2_Unzip(x, x, y, y, z, z, out data1, out data2, out _, out _, out _);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup3Zip_ByX2Unzip(Vector512<byte> x, Vector512<byte> y, Vector512<byte> z, out Vector512<byte> data1, out Vector512<byte> data2) {
                return YGroup3ZipX2_Unzip(x, x, y, y, z, z, out data1, out data2, out _, out _, out _);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup3Zip_ByX2Unzip(Vector512<short> x, Vector512<short> y, Vector512<short> z, out Vector512<short> data1, out Vector512<short> data2) {
                return YGroup3ZipX2_Unzip(x, x, y, y, z, z, out data1, out data2, out _, out _, out _);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup3Zip_ByX2Unzip(Vector512<ushort> x, Vector512<ushort> y, Vector512<ushort> z, out Vector512<ushort> data1, out Vector512<ushort> data2) {
                return YGroup3ZipX2_Unzip(x, x, y, y, z, z, out data1, out data2, out _, out _, out _);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup3Zip_ByX2Unzip(Vector512<int> x, Vector512<int> y, Vector512<int> z, out Vector512<int> data1, out Vector512<int> data2) {
                return YGroup3ZipX2_Unzip(x, x, y, y, z, z, out data1, out data2, out _, out _, out _);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3Zip(Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup3Zip_ByX2Unzip(Vector512<uint> x, Vector512<uint> y, Vector512<uint> z, out Vector512<uint> data1, out Vector512<uint> data2) {
                return YGroup3ZipX2_Unzip(x, x, y, y, z, z, out data1, out data2, out _, out _, out _);
            }

#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup3ZipX2_AcceleratedTypes {
                get {
                    return YGroup2Zip_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup3ZipX2(Vector512<float> x, Vector512<float> xB, Vector512<float> y, Vector512<float> yB, Vector512<float> z, Vector512<float> zB, out Vector512<float> data1, out Vector512<float> data2, out Vector512<float> data3, out Vector512<float> data4, out Vector512<float> data5) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup3ZipX2_Unzip(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3ZipX2_X2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup3ZipX2(Vector512<double> x, Vector512<double> xB, Vector512<double> y, Vector512<double> yB, Vector512<double> z, Vector512<double> zB, out Vector512<double> data1, out Vector512<double> data2, out Vector512<double> data3, out Vector512<double> data4, out Vector512<double> data5) {
                return YGroup3ZipX2_X2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup3ZipX2(Vector512<sbyte> x, Vector512<sbyte> xB, Vector512<sbyte> y, Vector512<sbyte> yB, Vector512<sbyte> z, Vector512<sbyte> zB, out Vector512<sbyte> data1, out Vector512<sbyte> data2, out Vector512<sbyte> data3, out Vector512<sbyte> data4, out Vector512<sbyte> data5) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup3ZipX2_Unzip(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3ZipX2_X2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup3ZipX2(Vector512<byte> x, Vector512<byte> xB, Vector512<byte> y, Vector512<byte> yB, Vector512<byte> z, Vector512<byte> zB, out Vector512<byte> data1, out Vector512<byte> data2, out Vector512<byte> data3, out Vector512<byte> data4, out Vector512<byte> data5) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup3ZipX2_Unzip(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3ZipX2_X2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup3ZipX2(Vector512<short> x, Vector512<short> xB, Vector512<short> y, Vector512<short> yB, Vector512<short> z, Vector512<short> zB, out Vector512<short> data1, out Vector512<short> data2, out Vector512<short> data3, out Vector512<short> data4, out Vector512<short> data5) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup3ZipX2_Unzip(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3ZipX2_X2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup3ZipX2(Vector512<ushort> x, Vector512<ushort> xB, Vector512<ushort> y, Vector512<ushort> yB, Vector512<ushort> z, Vector512<ushort> zB, out Vector512<ushort> data1, out Vector512<ushort> data2, out Vector512<ushort> data3, out Vector512<ushort> data4, out Vector512<ushort> data5) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup3ZipX2_Unzip(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3ZipX2_X2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup3ZipX2(Vector512<int> x, Vector512<int> xB, Vector512<int> y, Vector512<int> yB, Vector512<int> z, Vector512<int> zB, out Vector512<int> data1, out Vector512<int> data2, out Vector512<int> data3, out Vector512<int> data4, out Vector512<int> data5) {
                return YGroup3ZipX2_X2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup3ZipX2(Vector512<uint> x, Vector512<uint> xB, Vector512<uint> y, Vector512<uint> yB, Vector512<uint> z, Vector512<uint> zB, out Vector512<uint> data1, out Vector512<uint> data2, out Vector512<uint> data3, out Vector512<uint> data4, out Vector512<uint> data5) {
                return YGroup3ZipX2_X2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup3ZipX2(Vector512<long> x, Vector512<long> xB, Vector512<long> y, Vector512<long> yB, Vector512<long> z, Vector512<long> zB, out Vector512<long> data1, out Vector512<long> data2, out Vector512<long> data3, out Vector512<long> data4, out Vector512<long> data5) {
                return YGroup3ZipX2_Basic(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup3ZipX2(Vector512<ulong> x, Vector512<ulong> xB, Vector512<ulong> y, Vector512<ulong> yB, Vector512<ulong> z, Vector512<ulong> zB, out Vector512<ulong> data1, out Vector512<ulong> data2, out Vector512<ulong> data3, out Vector512<ulong> data4, out Vector512<ulong> data5) {
                return YGroup3ZipX2_Basic(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2_Bit128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<T> YGroup3ZipX2_Bit128<T>(Vector512<T> x, Vector512<T> xB, Vector512<T> y, Vector512<T> yB, Vector512<T> z, Vector512<T> zB, out Vector512<T> data1, out Vector512<T> data2, out Vector512<T> data3, out Vector512<T> data4, out Vector512<T> data5) where T : struct {
                var data0 = YGroup3Zip_Bit128(x, y, z, out data1, out data2);
                data3 = YGroup3Zip_Bit128(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2_Basic(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup3ZipX2_Basic(Vector512<float> x, Vector512<float> xB, Vector512<float> y, Vector512<float> yB, Vector512<float> z, Vector512<float> zB, out Vector512<float> data1, out Vector512<float> data2, out Vector512<float> data3, out Vector512<float> data4, out Vector512<float> data5) {
                var data0 = YGroup3Zip_Basic(x, y, z, out data1, out data2);
                data3 = YGroup3Zip_Basic(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2_Basic(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup3ZipX2_Basic(Vector512<double> x, Vector512<double> xB, Vector512<double> y, Vector512<double> yB, Vector512<double> z, Vector512<double> zB, out Vector512<double> data1, out Vector512<double> data2, out Vector512<double> data3, out Vector512<double> data4, out Vector512<double> data5) {
                var data0 = YGroup3Zip_Basic(x, y, z, out data1, out data2);
                data3 = YGroup3Zip_Basic(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2_Basic(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup3ZipX2_Basic(Vector512<sbyte> x, Vector512<sbyte> xB, Vector512<sbyte> y, Vector512<sbyte> yB, Vector512<sbyte> z, Vector512<sbyte> zB, out Vector512<sbyte> data1, out Vector512<sbyte> data2, out Vector512<sbyte> data3, out Vector512<sbyte> data4, out Vector512<sbyte> data5) {
                var data0 = YGroup3Zip_Basic(x, y, z, out data1, out data2);
                data3 = YGroup3Zip_Basic(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2_Basic(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup3ZipX2_Basic(Vector512<byte> x, Vector512<byte> xB, Vector512<byte> y, Vector512<byte> yB, Vector512<byte> z, Vector512<byte> zB, out Vector512<byte> data1, out Vector512<byte> data2, out Vector512<byte> data3, out Vector512<byte> data4, out Vector512<byte> data5) {
                var data0 = YGroup3Zip_Basic(x, y, z, out data1, out data2);
                data3 = YGroup3Zip_Basic(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2_Basic(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup3ZipX2_Basic(Vector512<short> x, Vector512<short> xB, Vector512<short> y, Vector512<short> yB, Vector512<short> z, Vector512<short> zB, out Vector512<short> data1, out Vector512<short> data2, out Vector512<short> data3, out Vector512<short> data4, out Vector512<short> data5) {
                var data0 = YGroup3Zip_Basic(x, y, z, out data1, out data2);
                data3 = YGroup3Zip_Basic(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2_Basic(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup3ZipX2_Basic(Vector512<ushort> x, Vector512<ushort> xB, Vector512<ushort> y, Vector512<ushort> yB, Vector512<ushort> z, Vector512<ushort> zB, out Vector512<ushort> data1, out Vector512<ushort> data2, out Vector512<ushort> data3, out Vector512<ushort> data4, out Vector512<ushort> data5) {
                var data0 = YGroup3Zip_Basic(x, y, z, out data1, out data2);
                data3 = YGroup3Zip_Basic(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2_Basic(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup3ZipX2_Basic(Vector512<int> x, Vector512<int> xB, Vector512<int> y, Vector512<int> yB, Vector512<int> z, Vector512<int> zB, out Vector512<int> data1, out Vector512<int> data2, out Vector512<int> data3, out Vector512<int> data4, out Vector512<int> data5) {
                var data0 = YGroup3Zip_Basic(x, y, z, out data1, out data2);
                data3 = YGroup3Zip_Basic(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2_Basic(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup3ZipX2_Basic(Vector512<uint> x, Vector512<uint> xB, Vector512<uint> y, Vector512<uint> yB, Vector512<uint> z, Vector512<uint> zB, out Vector512<uint> data1, out Vector512<uint> data2, out Vector512<uint> data3, out Vector512<uint> data4, out Vector512<uint> data5) {
                var data0 = YGroup3Zip_Basic(x, y, z, out data1, out data2);
                data3 = YGroup3Zip_Basic(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2_Basic(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup3ZipX2_Basic(Vector512<long> x, Vector512<long> xB, Vector512<long> y, Vector512<long> yB, Vector512<long> z, Vector512<long> zB, out Vector512<long> data1, out Vector512<long> data2, out Vector512<long> data3, out Vector512<long> data4, out Vector512<long> data5) {
                var data0 = YGroup3Zip_Basic(x, y, z, out data1, out data2);
                data3 = YGroup3Zip_Basic(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2_Basic(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup3ZipX2_Basic(Vector512<ulong> x, Vector512<ulong> xB, Vector512<ulong> y, Vector512<ulong> yB, Vector512<ulong> z, Vector512<ulong> zB, out Vector512<ulong> data1, out Vector512<ulong> data2, out Vector512<ulong> data3, out Vector512<ulong> data4, out Vector512<ulong> data5) {
                var data0 = YGroup3Zip_Basic(x, y, z, out data1, out data2);
                data3 = YGroup3Zip_Basic(xB, yB, zB, out data4, out data5);
                return data0;
            }

#if VECTOR_HAS_METHOD

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2_Unzip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup3ZipX2_Unzip(Vector512<float> x, Vector512<float> xB, Vector512<float> y, Vector512<float> yB, Vector512<float> z, Vector512<float> zB, out Vector512<float> data1, out Vector512<float> data2, out Vector512<float> data3, out Vector512<float> data4, out Vector512<float> data5) {
                var d0 = YGroup3ZipX2_Unzip(x.AsUInt32(), xB.AsUInt32(), y.AsUInt32(), yB.AsUInt32(), z.AsUInt32(), zB.AsUInt32(), out var d1, out var d2, out var d3, out var d4, out var d5);
                data1 = d1.AsSingle();
                data2 = d2.AsSingle();
                data3 = d3.AsSingle();
                data4 = d4.AsSingle();
                data5 = d5.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2_Unzip(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup3ZipX2_Unzip(Vector512<sbyte> x, Vector512<sbyte> xB, Vector512<sbyte> y, Vector512<sbyte> yB, Vector512<sbyte> z, Vector512<sbyte> zB, out Vector512<sbyte> data1, out Vector512<sbyte> data2, out Vector512<sbyte> data3, out Vector512<sbyte> data4, out Vector512<sbyte> data5) {
                var d0 = YGroup3ZipX2_Unzip(x.AsByte(), xB.AsByte(), y.AsByte(), yB.AsByte(), z.AsByte(), zB.AsByte(), out var d1, out var d2, out var d3, out var d4, out var d5);
                data1 = d1.AsSByte();
                data2 = d2.AsSByte();
                data3 = d3.AsSByte();
                data4 = d4.AsSByte();
                data5 = d5.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2_Unzip(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup3ZipX2_Unzip(Vector512<byte> x, Vector512<byte> xB, Vector512<byte> y, Vector512<byte> yB, Vector512<byte> z, Vector512<byte> zB, out Vector512<byte> data1, out Vector512<byte> data2, out Vector512<byte> data3, out Vector512<byte> data4, out Vector512<byte> data5) {
                Vector512<byte> a_0, a_1, a_2, a_3, a_4, a_5, b_0, b_1, b_2, b_3, b_4, b_5;
                // 0 _x_ x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 x16 x17 x18 x19 x20 x21 x22 x23 x24 x25 x26 x27 x28 x29 x30 x31 x32 x33 x34 x35 x36 x37 x38 x39 x40 x41 x42 x43 x44 x45 x46 x47 x48 x49 x50 x51 x52 x53 x54 x55 x56 x57 x58 x59 x60 x61 x62 x63 _xB x64 x65 x66 x67 x68 x69 x70 x71 x72 x73 x74 x75 x76 x77 x78 x79 x80 x81 x82 x83 x84 x85 x86 x87 x88 x89 x90 x91 x92 x93 x94 x95 x96 x97 x98 x99 x100 x101 x102 x103 x104 x105 x106 x107 x108 x109 x110 x111 x112 x113 x114 x115 x116 x117 x118 x119 x120 x121 x122 x123 x124 x125 x126 x127 _y_ y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 y16 y17 y18 y19 y20 y21 y22 y23 y24 y25 y26 y27 y28 y29 y30 y31 y32 y33 y34 y35 y36 y37 y38 y39 y40 y41 y42 y43 y44 y45 y46 y47 y48 y49 y50 y51 y52 y53 y54 y55 y56 y57 y58 y59 y60 y61 y62 y63 _yB y64 y65 y66 y67 y68 y69 y70 y71 y72 y73 y74 y75 y76 y77 y78 y79 y80 y81 y82 y83 y84 y85 y86 y87 y88 y89 y90 y91 y92 y93 y94 y95 y96 y97 y98 y99 y100 y101 y102 y103 y104 y105 y106 y107 y108 y109 y110 y111 y112 y113 y114 y115 y116 y117 y118 y119 y120 y121 y122 y123 y124 y125 y126 y127 _z_ z0 z1 z2 z3 z4 z5 z6 z7 z8 z9 z10 z11 z12 z13 z14 z15 z16 z17 z18 z19 z20 z21 z22 z23 z24 z25 z26 z27 z28 z29 z30 z31 z32 z33 z34 z35 z36 z37 z38 z39 z40 z41 z42 z43 z44 z45 z46 z47 z48 z49 z50 z51 z52 z53 z54 z55 z56 z57 z58 z59 z60 z61 z62 z63 _zB z64 z65 z66 z67 z68 z69 z70 z71 z72 z73 z74 z75 z76 z77 z78 z79 z80 z81 z82 z83 z84 z85 z86 z87 z88 z89 z90 z91 z92 z93 z94 z95 z96 z97 z98 z99 z100 z101 z102 z103 z104 z105 z106 z107 z108 z109 z110 z111 z112 z113 z114 z115 z116 z117 z118 z119 z120 z121 z122 z123 z124 z125 z126 z127
                // 1 a_0 x0 x2 x4 x6 x8 x10 x12 x14 x16 x18 x20 x22 x24 x26 x28 x30 x32 x34 x36 x38 x40 x42 x44 x46 x48 x50 x52 x54 x56 x58 x60 x62 x64 x66 x68 x70 x72 x74 x76 x78 x80 x82 x84 x86 x88 x90 x92 x94 x96 x98 x100 x102 x104 x106 x108 x110 x112 x114 x116 x118 x120 x122 x124 x126 a_1 y0 y2 y4 y6 y8 y10 y12 y14 y16 y18 y20 y22 y24 y26 y28 y30 y32 y34 y36 y38 y40 y42 y44 y46 y48 y50 y52 y54 y56 y58 y60 y62 y64 y66 y68 y70 y72 y74 y76 y78 y80 y82 y84 y86 y88 y90 y92 y94 y96 y98 y100 y102 y104 y106 y108 y110 y112 y114 y116 y118 y120 y122 y124 y126 a_2 z0 z2 z4 z6 z8 z10 z12 z14 z16 z18 z20 z22 z24 z26 z28 z30 z32 z34 z36 z38 z40 z42 z44 z46 z48 z50 z52 z54 z56 z58 z60 z62 z64 z66 z68 z70 z72 z74 z76 z78 z80 z82 z84 z86 z88 z90 z92 z94 z96 z98 z100 z102 z104 z106 z108 z110 z112 z114 z116 z118 z120 z122 z124 z126 a_3 x1 x3 x5 x7 x9 x11 x13 x15 x17 x19 x21 x23 x25 x27 x29 x31 x33 x35 x37 x39 x41 x43 x45 x47 x49 x51 x53 x55 x57 x59 x61 x63 x65 x67 x69 x71 x73 x75 x77 x79 x81 x83 x85 x87 x89 x91 x93 x95 x97 x99 x101 x103 x105 x107 x109 x111 x113 x115 x117 x119 x121 x123 x125 x127 a_4 y1 y3 y5 y7 y9 y11 y13 y15 y17 y19 y21 y23 y25 y27 y29 y31 y33 y35 y37 y39 y41 y43 y45 y47 y49 y51 y53 y55 y57 y59 y61 y63 y65 y67 y69 y71 y73 y75 y77 y79 y81 y83 y85 y87 y89 y91 y93 y95 y97 y99 y101 y103 y105 y107 y109 y111 y113 y115 y117 y119 y121 y123 y125 y127 a_5 z1 z3 z5 z7 z9 z11 z13 z15 z17 z19 z21 z23 z25 z27 z29 z31 z33 z35 z37 z39 z41 z43 z45 z47 z49 z51 z53 z55 z57 z59 z61 z63 z65 z67 z69 z71 z73 z75 z77 z79 z81 z83 z85 z87 z89 z91 z93 z95 z97 z99 z101 z103 z105 z107 z109 z111 z113 z115 z117 z119 z121 z123 z125 z127
                a_0 = YGroup2Unzip(x, xB, out a_3);
                a_1 = YGroup2Unzip(y, yB, out a_4);
                a_2 = YGroup2Unzip(z, zB, out a_5);
                // 2 b_0 x0 x4 x8 x12 x16 x20 x24 x28 x32 x36 x40 x44 x48 x52 x56 x60 x64 x68 x72 x76 x80 x84 x88 x92 x96 x100 x104 x108 x112 x116 x120 x124 y0 y4 y8 y12 y16 y20 y24 y28 y32 y36 y40 y44 y48 y52 y56 y60 y64 y68 y72 y76 y80 y84 y88 y92 y96 y100 y104 y108 y112 y116 y120 y124 b_1 z0 z4 z8 z12 z16 z20 z24 z28 z32 z36 z40 z44 z48 z52 z56 z60 z64 z68 z72 z76 z80 z84 z88 z92 z96 z100 z104 z108 z112 z116 z120 z124 x1 x5 x9 x13 x17 x21 x25 x29 x33 x37 x41 x45 x49 x53 x57 x61 x65 x69 x73 x77 x81 x85 x89 x93 x97 x101 x105 x109 x113 x117 x121 x125 b_2 y1 y5 y9 y13 y17 y21 y25 y29 y33 y37 y41 y45 y49 y53 y57 y61 y65 y69 y73 y77 y81 y85 y89 y93 y97 y101 y105 y109 y113 y117 y121 y125 z1 z5 z9 z13 z17 z21 z25 z29 z33 z37 z41 z45 z49 z53 z57 z61 z65 z69 z73 z77 z81 z85 z89 z93 z97 z101 z105 z109 z113 z117 z121 z125 b_3 x2 x6 x10 x14 x18 x22 x26 x30 x34 x38 x42 x46 x50 x54 x58 x62 x66 x70 x74 x78 x82 x86 x90 x94 x98 x102 x106 x110 x114 x118 x122 x126 y2 y6 y10 y14 y18 y22 y26 y30 y34 y38 y42 y46 y50 y54 y58 y62 y66 y70 y74 y78 y82 y86 y90 y94 y98 y102 y106 y110 y114 y118 y122 y126 b_4 z2 z6 z10 z14 z18 z22 z26 z30 z34 z38 z42 z46 z50 z54 z58 z62 z66 z70 z74 z78 z82 z86 z90 z94 z98 z102 z106 z110 z114 z118 z122 z126 x3 x7 x11 x15 x19 x23 x27 x31 x35 x39 x43 x47 x51 x55 x59 x63 x67 x71 x75 x79 x83 x87 x91 x95 x99 x103 x107 x111 x115 x119 x123 x127 b_5 y3 y7 y11 y15 y19 y23 y27 y31 y35 y39 y43 y47 y51 y55 y59 y63 y67 y71 y75 y79 y83 y87 y91 y95 y99 y103 y107 y111 y115 y119 y123 y127 z3 z7 z11 z15 z19 z23 z27 z31 z35 z39 z43 z47 z51 z55 z59 z63 z67 z71 z75 z79 z83 z87 z91 z95 z99 z103 z107 z111 z115 z119 z123 z127
                b_0 = YGroup2Unzip(a_0, a_1, out b_3);
                b_1 = YGroup2Unzip(a_2, a_3, out b_4);
                b_2 = YGroup2Unzip(a_4, a_5, out b_5);
                // 3 a_0 x0 x8 x16 x24 x32 x40 x48 x56 x64 x72 x80 x88 x96 x104 x112 x120 y0 y8 y16 y24 y32 y40 y48 y56 y64 y72 y80 y88 y96 y104 y112 y120 z0 z8 z16 z24 z32 z40 z48 z56 z64 z72 z80 z88 z96 z104 z112 z120 x1 x9 x17 x25 x33 x41 x49 x57 x65 x73 x81 x89 x97 x105 x113 x121 a_1 y1 y9 y17 y25 y33 y41 y49 y57 y65 y73 y81 y89 y97 y105 y113 y121 z1 z9 z17 z25 z33 z41 z49 z57 z65 z73 z81 z89 z97 z105 z113 z121 x2 x10 x18 x26 x34 x42 x50 x58 x66 x74 x82 x90 x98 x106 x114 x122 y2 y10 y18 y26 y34 y42 y50 y58 y66 y74 y82 y90 y98 y106 y114 y122 a_2 z2 z10 z18 z26 z34 z42 z50 z58 z66 z74 z82 z90 z98 z106 z114 z122 x3 x11 x19 x27 x35 x43 x51 x59 x67 x75 x83 x91 x99 x107 x115 x123 y3 y11 y19 y27 y35 y43 y51 y59 y67 y75 y83 y91 y99 y107 y115 y123 z3 z11 z19 z27 z35 z43 z51 z59 z67 z75 z83 z91 z99 z107 z115 z123 a_3 x4 x12 x20 x28 x36 x44 x52 x60 x68 x76 x84 x92 x100 x108 x116 x124 y4 y12 y20 y28 y36 y44 y52 y60 y68 y76 y84 y92 y100 y108 y116 y124 z4 z12 z20 z28 z36 z44 z52 z60 z68 z76 z84 z92 z100 z108 z116 z124 x5 x13 x21 x29 x37 x45 x53 x61 x69 x77 x85 x93 x101 x109 x117 x125 a_4 y5 y13 y21 y29 y37 y45 y53 y61 y69 y77 y85 y93 y101 y109 y117 y125 z5 z13 z21 z29 z37 z45 z53 z61 z69 z77 z85 z93 z101 z109 z117 z125 x6 x14 x22 x30 x38 x46 x54 x62 x70 x78 x86 x94 x102 x110 x118 x126 y6 y14 y22 y30 y38 y46 y54 y62 y70 y78 y86 y94 y102 y110 y118 y126 a_5 z6 z14 z22 z30 z38 z46 z54 z62 z70 z78 z86 z94 z102 z110 z118 z126 x7 x15 x23 x31 x39 x47 x55 x63 x71 x79 x87 x95 x103 x111 x119 x127 y7 y15 y23 y31 y39 y47 y55 y63 y71 y79 y87 y95 y103 y111 y119 y127 z7 z15 z23 z31 z39 z47 z55 z63 z71 z79 z87 z95 z103 z111 z119 z127
                a_0 = YGroup2Unzip(b_0, b_1, out a_3);
                a_1 = YGroup2Unzip(b_2, b_3, out a_4);
                a_2 = YGroup2Unzip(b_4, b_5, out a_5);
                // 4 b_0 x0 x16 x32 x48 x64 x80 x96 x112 y0 y16 y32 y48 y64 y80 y96 y112 z0 z16 z32 z48 z64 z80 z96 z112 x1 x17 x33 x49 x65 x81 x97 x113 y1 y17 y33 y49 y65 y81 y97 y113 z1 z17 z33 z49 z65 z81 z97 z113 x2 x18 x34 x50 x66 x82 x98 x114 y2 y18 y34 y50 y66 y82 y98 y114 b_1 z2 z18 z34 z50 z66 z82 z98 z114 x3 x19 x35 x51 x67 x83 x99 x115 y3 y19 y35 y51 y67 y83 y99 y115 z3 z19 z35 z51 z67 z83 z99 z115 x4 x20 x36 x52 x68 x84 x100 x116 y4 y20 y36 y52 y68 y84 y100 y116 z4 z20 z36 z52 z68 z84 z100 z116 x5 x21 x37 x53 x69 x85 x101 x117 b_2 y5 y21 y37 y53 y69 y85 y101 y117 z5 z21 z37 z53 z69 z85 z101 z117 x6 x22 x38 x54 x70 x86 x102 x118 y6 y22 y38 y54 y70 y86 y102 y118 z6 z22 z38 z54 z70 z86 z102 z118 x7 x23 x39 x55 x71 x87 x103 x119 y7 y23 y39 y55 y71 y87 y103 y119 z7 z23 z39 z55 z71 z87 z103 z119 b_3 x8 x24 x40 x56 x72 x88 x104 x120 y8 y24 y40 y56 y72 y88 y104 y120 z8 z24 z40 z56 z72 z88 z104 z120 x9 x25 x41 x57 x73 x89 x105 x121 y9 y25 y41 y57 y73 y89 y105 y121 z9 z25 z41 z57 z73 z89 z105 z121 x10 x26 x42 x58 x74 x90 x106 x122 y10 y26 y42 y58 y74 y90 y106 y122 b_4 z10 z26 z42 z58 z74 z90 z106 z122 x11 x27 x43 x59 x75 x91 x107 x123 y11 y27 y43 y59 y75 y91 y107 y123 z11 z27 z43 z59 z75 z91 z107 z123 x12 x28 x44 x60 x76 x92 x108 x124 y12 y28 y44 y60 y76 y92 y108 y124 z12 z28 z44 z60 z76 z92 z108 z124 x13 x29 x45 x61 x77 x93 x109 x125 b_5 y13 y29 y45 y61 y77 y93 y109 y125 z13 z29 z45 z61 z77 z93 z109 z125 x14 x30 x46 x62 x78 x94 x110 x126 y14 y30 y46 y62 y78 y94 y110 y126 z14 z30 z46 z62 z78 z94 z110 z126 x15 x31 x47 x63 x79 x95 x111 x127 y15 y31 y47 y63 y79 y95 y111 y127 z15 z31 z47 z63 z79 z95 z111 z127
                b_0 = YGroup2Unzip(a_0, a_1, out b_3);
                b_1 = YGroup2Unzip(a_2, a_3, out b_4);
                b_2 = YGroup2Unzip(a_4, a_5, out b_5);
                // 5 a_0 x0 x32 x64 x96 y0 y32 y64 y96 z0 z32 z64 z96 x1 x33 x65 x97 y1 y33 y65 y97 z1 z33 z65 z97 x2 x34 x66 x98 y2 y34 y66 y98 z2 z34 z66 z98 x3 x35 x67 x99 y3 y35 y67 y99 z3 z35 z67 z99 x4 x36 x68 x100 y4 y36 y68 y100 z4 z36 z68 z100 x5 x37 x69 x101 a_1 y5 y37 y69 y101 z5 z37 z69 z101 x6 x38 x70 x102 y6 y38 y70 y102 z6 z38 z70 z102 x7 x39 x71 x103 y7 y39 y71 y103 z7 z39 z71 z103 x8 x40 x72 x104 y8 y40 y72 y104 z8 z40 z72 z104 x9 x41 x73 x105 y9 y41 y73 y105 z9 z41 z73 z105 x10 x42 x74 x106 y10 y42 y74 y106 a_2 z10 z42 z74 z106 x11 x43 x75 x107 y11 y43 y75 y107 z11 z43 z75 z107 x12 x44 x76 x108 y12 y44 y76 y108 z12 z44 z76 z108 x13 x45 x77 x109 y13 y45 y77 y109 z13 z45 z77 z109 x14 x46 x78 x110 y14 y46 y78 y110 z14 z46 z78 z110 x15 x47 x79 x111 y15 y47 y79 y111 z15 z47 z79 z111 a_3 x16 x48 x80 x112 y16 y48 y80 y112 z16 z48 z80 z112 x17 x49 x81 x113 y17 y49 y81 y113 z17 z49 z81 z113 x18 x50 x82 x114 y18 y50 y82 y114 z18 z50 z82 z114 x19 x51 x83 x115 y19 y51 y83 y115 z19 z51 z83 z115 x20 x52 x84 x116 y20 y52 y84 y116 z20 z52 z84 z116 x21 x53 x85 x117 a_4 y21 y53 y85 y117 z21 z53 z85 z117 x22 x54 x86 x118 y22 y54 y86 y118 z22 z54 z86 z118 x23 x55 x87 x119 y23 y55 y87 y119 z23 z55 z87 z119 x24 x56 x88 x120 y24 y56 y88 y120 z24 z56 z88 z120 x25 x57 x89 x121 y25 y57 y89 y121 z25 z57 z89 z121 x26 x58 x90 x122 y26 y58 y90 y122 a_5 z26 z58 z90 z122 x27 x59 x91 x123 y27 y59 y91 y123 z27 z59 z91 z123 x28 x60 x92 x124 y28 y60 y92 y124 z28 z60 z92 z124 x29 x61 x93 x125 y29 y61 y93 y125 z29 z61 z93 z125 x30 x62 x94 x126 y30 y62 y94 y126 z30 z62 z94 z126 x31 x63 x95 x127 y31 y63 y95 y127 z31 z63 z95 z127
                a_0 = YGroup2Unzip(b_0, b_1, out a_3);
                a_1 = YGroup2Unzip(b_2, b_3, out a_4);
                a_2 = YGroup2Unzip(b_4, b_5, out a_5);
                // 6 b_0 x0 x64 y0 y64 z0 z64 x1 x65 y1 y65 z1 z65 x2 x66 y2 y66 z2 z66 x3 x67 y3 y67 z3 z67 x4 x68 y4 y68 z4 z68 x5 x69 y5 y69 z5 z69 x6 x70 y6 y70 z6 z70 x7 x71 y7 y71 z7 z71 x8 x72 y8 y72 z8 z72 x9 x73 y9 y73 z9 z73 x10 x74 y10 y74 b_1 z10 z74 x11 x75 y11 y75 z11 z75 x12 x76 y12 y76 z12 z76 x13 x77 y13 y77 z13 z77 x14 x78 y14 y78 z14 z78 x15 x79 y15 y79 z15 z79 x16 x80 y16 y80 z16 z80 x17 x81 y17 y81 z17 z81 x18 x82 y18 y82 z18 z82 x19 x83 y19 y83 z19 z83 x20 x84 y20 y84 z20 z84 x21 x85 b_2 y21 y85 z21 z85 x22 x86 y22 y86 z22 z86 x23 x87 y23 y87 z23 z87 x24 x88 y24 y88 z24 z88 x25 x89 y25 y89 z25 z89 x26 x90 y26 y90 z26 z90 x27 x91 y27 y91 z27 z91 x28 x92 y28 y92 z28 z92 x29 x93 y29 y93 z29 z93 x30 x94 y30 y94 z30 z94 x31 x95 y31 y95 z31 z95 b_3 x32 x96 y32 y96 z32 z96 x33 x97 y33 y97 z33 z97 x34 x98 y34 y98 z34 z98 x35 x99 y35 y99 z35 z99 x36 x100 y36 y100 z36 z100 x37 x101 y37 y101 z37 z101 x38 x102 y38 y102 z38 z102 x39 x103 y39 y103 z39 z103 x40 x104 y40 y104 z40 z104 x41 x105 y41 y105 z41 z105 x42 x106 y42 y106 b_4 z42 z106 x43 x107 y43 y107 z43 z107 x44 x108 y44 y108 z44 z108 x45 x109 y45 y109 z45 z109 x46 x110 y46 y110 z46 z110 x47 x111 y47 y111 z47 z111 x48 x112 y48 y112 z48 z112 x49 x113 y49 y113 z49 z113 x50 x114 y50 y114 z50 z114 x51 x115 y51 y115 z51 z115 x52 x116 y52 y116 z52 z116 x53 x117 b_5 y53 y117 z53 z117 x54 x118 y54 y118 z54 z118 x55 x119 y55 y119 z55 z119 x56 x120 y56 y120 z56 z120 x57 x121 y57 y121 z57 z121 x58 x122 y58 y122 z58 z122 x59 x123 y59 y123 z59 z123 x60 x124 y60 y124 z60 z124 x61 x125 y61 y125 z61 z125 x62 x126 y62 y126 z62 z126 x63 x127 y63 y127 z63 z127
                b_0 = YGroup2Unzip(a_0, a_1, out b_3);
                b_1 = YGroup2Unzip(a_2, a_3, out b_4);
                b_2 = YGroup2Unzip(a_4, a_5, out b_5);
                // 7 a_0 x0 y0 z0 x1 y1 z1 x2 y2 z2 x3 y3 z3 x4 y4 z4 x5 y5 z5 x6 y6 z6 x7 y7 z7 x8 y8 z8 x9 y9 z9 x10 y10 z10 x11 y11 z11 x12 y12 z12 x13 y13 z13 x14 y14 z14 x15 y15 z15 x16 y16 z16 x17 y17 z17 x18 y18 z18 x19 y19 z19 x20 y20 z20 x21 a_1 y21 z21 x22 y22 z22 x23 y23 z23 x24 y24 z24 x25 y25 z25 x26 y26 z26 x27 y27 z27 x28 y28 z28 x29 y29 z29 x30 y30 z30 x31 y31 z31 x32 y32 z32 x33 y33 z33 x34 y34 z34 x35 y35 z35 x36 y36 z36 x37 y37 z37 x38 y38 z38 x39 y39 z39 x40 y40 z40 x41 y41 z41 x42 y42 a_2 z42 x43 y43 z43 x44 y44 z44 x45 y45 z45 x46 y46 z46 x47 y47 z47 x48 y48 z48 x49 y49 z49 x50 y50 z50 x51 y51 z51 x52 y52 z52 x53 y53 z53 x54 y54 z54 x55 y55 z55 x56 y56 z56 x57 y57 z57 x58 y58 z58 x59 y59 z59 x60 y60 z60 x61 y61 z61 x62 y62 z62 x63 y63 z63 a_3 x64 y64 z64 x65 y65 z65 x66 y66 z66 x67 y67 z67 x68 y68 z68 x69 y69 z69 x70 y70 z70 x71 y71 z71 x72 y72 z72 x73 y73 z73 x74 y74 z74 x75 y75 z75 x76 y76 z76 x77 y77 z77 x78 y78 z78 x79 y79 z79 x80 y80 z80 x81 y81 z81 x82 y82 z82 x83 y83 z83 x84 y84 z84 x85 a_4 y85 z85 x86 y86 z86 x87 y87 z87 x88 y88 z88 x89 y89 z89 x90 y90 z90 x91 y91 z91 x92 y92 z92 x93 y93 z93 x94 y94 z94 x95 y95 z95 x96 y96 z96 x97 y97 z97 x98 y98 z98 x99 y99 z99 x100 y100 z100 x101 y101 z101 x102 y102 z102 x103 y103 z103 x104 y104 z104 x105 y105 z105 x106 y106 a_5 z106 x107 y107 z107 x108 y108 z108 x109 y109 z109 x110 y110 z110 x111 y111 z111 x112 y112 z112 x113 y113 z113 x114 y114 z114 x115 y115 z115 x116 y116 z116 x117 y117 z117 x118 y118 z118 x119 y119 z119 x120 y120 z120 x121 y121 z121 x122 y122 z122 x123 y123 z123 x124 y124 z124 x125 y125 z125 x126 y126 z126 x127 y127 z127
                a_0 = YGroup2Unzip(b_0, b_1, out a_3);
                a_1 = YGroup2Unzip(b_2, b_3, out a_4);
                a_2 = YGroup2Unzip(b_4, b_5, out a_5);
                data1 = a_1;
                data2 = a_2;
                data3 = a_3;
                data4 = a_4;
                data5 = a_5;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2_Unzip(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup3ZipX2_Unzip(Vector512<short> x, Vector512<short> xB, Vector512<short> y, Vector512<short> yB, Vector512<short> z, Vector512<short> zB, out Vector512<short> data1, out Vector512<short> data2, out Vector512<short> data3, out Vector512<short> data4, out Vector512<short> data5) {
                var d0 = YGroup3ZipX2_Unzip(x.AsUInt16(), xB.AsUInt16(), y.AsUInt16(), yB.AsUInt16(), z.AsUInt16(), zB.AsUInt16(), out var d1, out var d2, out var d3, out var d4, out var d5);
                data1 = d1.AsInt16();
                data2 = d2.AsInt16();
                data3 = d3.AsInt16();
                data4 = d4.AsInt16();
                data5 = d5.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2_Unzip(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup3ZipX2_Unzip(Vector512<ushort> x, Vector512<ushort> xB, Vector512<ushort> y, Vector512<ushort> yB, Vector512<ushort> z, Vector512<ushort> zB, out Vector512<ushort> data1, out Vector512<ushort> data2, out Vector512<ushort> data3, out Vector512<ushort> data4, out Vector512<ushort> data5) {
                Vector512<ushort> a_0, a_1, a_2, a_3, a_4, a_5, b_0, b_1, b_2, b_3, b_4, b_5;
                // 0 _x_ x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 x16 x17 x18 x19 x20 x21 x22 x23 x24 x25 x26 x27 x28 x29 x30 x31 _xB x32 x33 x34 x35 x36 x37 x38 x39 x40 x41 x42 x43 x44 x45 x46 x47 x48 x49 x50 x51 x52 x53 x54 x55 x56 x57 x58 x59 x60 x61 x62 x63 _y_ y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 y16 y17 y18 y19 y20 y21 y22 y23 y24 y25 y26 y27 y28 y29 y30 y31 _yB y32 y33 y34 y35 y36 y37 y38 y39 y40 y41 y42 y43 y44 y45 y46 y47 y48 y49 y50 y51 y52 y53 y54 y55 y56 y57 y58 y59 y60 y61 y62 y63 _z_ z0 z1 z2 z3 z4 z5 z6 z7 z8 z9 z10 z11 z12 z13 z14 z15 z16 z17 z18 z19 z20 z21 z22 z23 z24 z25 z26 z27 z28 z29 z30 z31 b_5 _zB z33 z34 z35 z36 z37 z38 z39 z40 z41 z42 z43 z44 z45 z46 z47 z48 z49 z50 z51 z52 z53 z54 z55 z56 z57 z58 z59 z60 z61 z62 z63
                // 1 a_0 x0 x2 x4 x6 x8 x10 x12 x14 x16 x18 x20 x22 x24 x26 x28 x30 x32 x34 x36 x38 x40 x42 x44 x46 x48 x50 x52 x54 x56 x58 x60 x62 a_1 y0 y2 y4 y6 y8 y10 y12 y14 y16 y18 y20 y22 y24 y26 y28 y30 y32 y34 y36 y38 y40 y42 y44 y46 y48 y50 y52 y54 y56 y58 y60 y62 a_2 z0 z2 z4 z6 z8 z10 z12 z14 z16 z18 z20 z22 z24 z26 z28 z30 z32 z34 z36 z38 z40 z42 z44 z46 z48 z50 z52 z54 z56 z58 z60 z62 a_3 x1 x3 x5 x7 x9 x11 x13 x15 x17 x19 x21 x23 x25 x27 x29 x31 x33 x35 x37 x39 x41 x43 x45 x47 x49 x51 x53 x55 x57 x59 x61 x63 a_4 y1 y3 y5 y7 y9 y11 y13 y15 y17 y19 y21 y23 y25 y27 y29 y31 y33 y35 y37 y39 y41 y43 y45 y47 y49 y51 y53 y55 y57 y59 y61 y63 a_5 z1 z3 z5 z7 z9 z11 z13 z15 z17 z19 z21 z23 z25 z27 z29 z31 z33 z35 z37 z39 z41 z43 z45 z47 z49 z51 z53 z55 z57 z59 z61 z63
                a_0 = YGroup2Unzip(x, xB, out a_3);
                a_1 = YGroup2Unzip(y, yB, out a_4);
                a_2 = YGroup2Unzip(z, zB, out a_5);
                // 2 b_0 x0 x4 x8 x12 x16 x20 x24 x28 x32 x36 x40 x44 x48 x52 x56 x60 y0 y4 y8 y12 y16 y20 y24 y28 y32 y36 y40 y44 y48 y52 y56 y60 b_1 z0 z4 z8 z12 z16 z20 z24 z28 z32 z36 z40 z44 z48 z52 z56 z60 x1 x5 x9 x13 x17 x21 x25 x29 x33 x37 x41 x45 x49 x53 x57 x61 b_2 y1 y5 y9 y13 y17 y21 y25 y29 y33 y37 y41 y45 y49 y53 y57 y61 z1 z5 z9 z13 z17 z21 z25 z29 z33 z37 z41 z45 z49 z53 z57 z61 b_3 x2 x6 x10 x14 x18 x22 x26 x30 x34 x38 x42 x46 x50 x54 x58 x62 y2 y6 y10 y14 y18 y22 y26 y30 y34 y38 y42 y46 y50 y54 y58 y62 b_4 z2 z6 z10 z14 z18 z22 z26 z30 z34 z38 z42 z46 z50 z54 z58 z62 x3 x7 x11 x15 x19 x23 x27 x31 x35 x39 x43 x47 x51 x55 x59 x63 b_5 y3 y7 y11 y15 y19 y23 y27 y31 y35 y39 y43 y47 y51 y55 y59 y63 z3 z7 z11 z15 z19 z23 z27 z31 z35 z39 z43 z47 z51 z55 z59 z63
                b_0 = YGroup2Unzip(a_0, a_1, out b_3);
                b_1 = YGroup2Unzip(a_2, a_3, out b_4);
                b_2 = YGroup2Unzip(a_4, a_5, out b_5);
                // 3 a_0 x0 x8 x16 x24 x32 x40 x48 x56 y0 y8 y16 y24 y32 y40 y48 y56 z0 z8 z16 z24 z32 z40 z48 z56 x1 x9 x17 x25 x33 x41 x49 x57 a_1 y1 y9 y17 y25 y33 y41 y49 y57 z1 z9 z17 z25 z33 z41 z49 z57 x2 x10 x18 x26 x34 x42 x50 x58 y2 y10 y18 y26 y34 y42 y50 y58 a_2 z2 z10 z18 z26 z34 z42 z50 z58 x3 x11 x19 x27 x35 x43 x51 x59 y3 y11 y19 y27 y35 y43 y51 y59 z3 z11 z19 z27 z35 z43 z51 z59 a_3 x4 x12 x20 x28 x36 x44 x52 x60 y4 y12 y20 y28 y36 y44 y52 y60 z4 z12 z20 z28 z36 z44 z52 z60 x5 x13 x21 x29 x37 x45 x53 x61 a_4 y5 y13 y21 y29 y37 y45 y53 y61 z5 z13 z21 z29 z37 z45 z53 z61 x6 x14 x22 x30 x38 x46 x54 x62 y6 y14 y22 y30 y38 y46 y54 y62 a_5 z6 z14 z22 z30 z38 z46 z54 z62 x7 x15 x23 x31 x39 x47 x55 x63 y7 y15 y23 y31 y39 y47 y55 y63 z7 z15 z23 z31 z39 z47 z55 z63
                a_0 = YGroup2Unzip(b_0, b_1, out a_3);
                a_1 = YGroup2Unzip(b_2, b_3, out a_4);
                a_2 = YGroup2Unzip(b_4, b_5, out a_5);
                // 4 b_0 x0 x16 x32 x48 y0 y16 y32 y48 z0 z16 z32 z48 x1 x17 x33 x49 y1 y17 y33 y49 z1 z17 z33 z49 x2 x18 x34 x50 y2 y18 y34 y50 b_1 z2 z18 z34 z50 x3 x19 x35 x51 y3 y19 y35 y51 z3 z19 z35 z51 x4 x20 x36 x52 y4 y20 y36 y52 z4 z20 z36 z52 x5 x21 x37 x53 b_2 y5 y21 y37 y53 z5 z21 z37 z53 x6 x22 x38 x54 y6 y22 y38 y54 z6 z22 z38 z54 x7 x23 x39 x55 y7 y23 y39 y55 z7 z23 z39 z55 b_3 x8 x24 x40 x56 y8 y24 y40 y56 z8 z24 z40 z56 x9 x25 x41 x57 y9 y25 y41 y57 z9 z25 z41 z57 x10 x26 x42 x58 y10 y26 y42 y58 b_4 z10 z26 z42 z58 x11 x27 x43 x59 y11 y27 y43 y59 z11 z27 z43 z59 x12 x28 x44 x60 y12 y28 y44 y60 z12 z28 z44 z60 x13 x29 x45 x61 b_5 y13 y29 y45 y61 z13 z29 z45 z61 x14 x30 x46 x62 y14 y30 y46 y62 z14 z30 z46 z62 x15 x31 x47 x63 y15 y31 y47 y63 z15 z31 z47 z63
                b_0 = YGroup2Unzip(a_0, a_1, out b_3);
                b_1 = YGroup2Unzip(a_2, a_3, out b_4);
                b_2 = YGroup2Unzip(a_4, a_5, out b_5);
                // 5 a_0 x0 x32 y0 y32 z0 z32 x1 x33 y1 y33 z1 z33 x2 x34 y2 y34 z2 z34 x3 x35 y3 y35 z3 z35 x4 x36 y4 y36 z4 z36 x5 x37 a_1 y5 y37 z5 z37 x6 x38 y6 y38 z6 z38 x7 x39 y7 y39 z7 z39 x8 x40 y8 y40 z8 z40 x9 x41 y9 y41 z9 z41 x10 x42 y10 y42 a_2 z10 z42 x11 x43 y11 y43 z11 z43 x12 x44 y12 y44 z12 z44 x13 x45 y13 y45 z13 z45 x14 x46 y14 y46 z14 z46 x15 x47 y15 y47 z15 z47 a_3 x16 x48 y16 y48 z16 z48 x17 x49 y17 y49 z17 z49 x18 x50 y18 y50 z18 z50 x19 x51 y19 y51 z19 z51 x20 x52 y20 y52 z20 z52 x21 x53 a_4 y21 y53 z21 z53 x22 x54 y22 y54 z22 z54 x23 x55 y23 y55 z23 z55 x24 x56 y24 y56 z24 z56 x25 x57 y25 y57 z25 z57 x26 x58 y26 y58 a_5 z26 z58 x27 x59 y27 y59 z27 z59 x28 x60 y28 y60 z28 z60 x29 x61 y29 y61 z29 z61 x30 x62 y30 y62 z30 z62 x31 x63 y31 y63 z31 z63
                a_0 = YGroup2Unzip(b_0, b_1, out a_3);
                a_1 = YGroup2Unzip(b_2, b_3, out a_4);
                a_2 = YGroup2Unzip(b_4, b_5, out a_5);
                // 6 b_0 x0 y0 z0 x1 y1 z1 x2 y2 z2 x3 y3 z3 x4 y4 z4 x5 y5 z5 x6 y6 z6 x7 y7 z7 x8 y8 z8 x9 y9 z9 x10 y10 b_1 z10 x11 y11 z11 x12 y12 z12 x13 y13 z13 x14 y14 z14 x15 y15 z15 x16 y16 z16 x17 y17 z17 x18 y18 z18 x19 y19 z19 x20 y20 z20 x21 b_2 y21 z21 x22 y22 z22 x23 y23 z23 x24 y24 z24 x25 y25 z25 x26 y26 z26 x27 y27 z27 x28 y28 z28 x29 y29 z29 x30 y30 z30 x31 y31 z31 b_3 x32 y32 z32 x33 y33 z33 x34 y34 z34 x35 y35 z35 x36 y36 z36 x37 y37 z37 x38 y38 z38 x39 y39 z39 x40 y40 z40 x41 y41 z41 x42 y42 b_4 z42 x43 y43 z43 x44 y44 z44 x45 y45 z45 x46 y46 z46 x47 y47 z47 x48 y48 z48 x49 y49 z49 x50 y50 z50 x51 y51 z51 x52 y52 z52 x53 b_5 y53 z53 x54 y54 z54 x55 y55 z55 x56 y56 z56 x57 y57 z57 x58 y58 z58 x59 y59 z59 x60 y60 z60 x61 y61 z61 x62 y62 z62 x63 y63 z63
                b_0 = YGroup2Unzip(a_0, a_1, out b_3);
                b_1 = YGroup2Unzip(a_2, a_3, out b_4);
                b_2 = YGroup2Unzip(a_4, a_5, out b_5);
                data1 = b_1;
                data2 = b_2;
                data3 = b_3;
                data4 = b_4;
                data5 = b_5;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2_Unzip(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup3ZipX2_Unzip(Vector512<int> x, Vector512<int> xB, Vector512<int> y, Vector512<int> yB, Vector512<int> z, Vector512<int> zB, out Vector512<int> data1, out Vector512<int> data2, out Vector512<int> data3, out Vector512<int> data4, out Vector512<int> data5) {
                var d0 = YGroup3ZipX2_Unzip(x.AsUInt32(), xB.AsUInt32(), y.AsUInt32(), yB.AsUInt32(), z.AsUInt32(), zB.AsUInt32(), out var d1, out var d2, out var d3, out var d4, out var d5);
                data1 = d1.AsInt32();
                data2 = d2.AsInt32();
                data3 = d3.AsInt32();
                data4 = d4.AsInt32();
                data5 = d5.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2_Unzip(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup3ZipX2_Unzip(Vector512<uint> x, Vector512<uint> xB, Vector512<uint> y, Vector512<uint> yB, Vector512<uint> z, Vector512<uint> zB, out Vector512<uint> data1, out Vector512<uint> data2, out Vector512<uint> data3, out Vector512<uint> data4, out Vector512<uint> data5) {
                Vector512<uint> a_0, a_1, a_2, a_3, a_4, a_5, b_0, b_1, b_2, b_3, b_4, b_5;
                // 0 _x_ x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 _xb x16 x17 x18 x19 x20 x21 x22 x23 x24 x25 x26 x27 x28 x29 x30 x31 _Y_ y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 _yB y16 y17 y18 y19 y20 y21 y22 y23 y24 y25 y26 y27 y28 y29 y30 y31 _z_ z0 z1 z2 z3 z4 z5 z6 z7 z8 z9 z10 z11 z12 z13 z14 z15 _zB z16 z17 z18 z19 z20 z21 z22 z23 z24 z25 z26 z27 z28 z29 z30 z31
                // 1 a_0 x0 x2 x4 x6 x8 x10 x12 x14 x16 x18 x20 x22 x24 x26 x28 x30 a_1 y0 y2 y4 y6 y8 y10 y12 y14 y16 y18 y20 y22 y24 y26 y28 y30 a_2 z0 z2 z4 z6 z8 z10 z12 z14 z16 z18 z20 z22 z24 z26 z28 z30 a_3 x1 x3 x5 x7 x9 x11 x13 x15 x17 x19 x21 x23 x25 x27 x29 x31 a_4 y1 y3 y5 y7 y9 y11 y13 y15 y17 y19 y21 y23 y25 y27 y29 y31 a_5 z1 z3 z5 z7 z9 z11 z13 z15 z17 z19 z21 z23 z25 z27 z29 z31
                a_0 = YGroup2Unzip(x, xB, out a_3);
                a_1 = YGroup2Unzip(y, yB, out a_4);
                a_2 = YGroup2Unzip(z, zB, out a_5);
                // 2 b_0 x0 x4 x8 x12 x16 x20 x24 x28 y0 y4 y8 y12 y16 y20 y24 y28 b_1 z0 z4 z8 z12 z16 z20 z24 z28 x1 x5 x9 x13 x17 x21 x25 x29 b_2 y1 y5 y9 y13 y17 y21 y25 y29 z1 z5 z9 z13 z17 z21 z25 z29 b_3 x2 x6 x10 x14 x18 x22 x26 x30 y2 y6 y10 y14 y18 y22 y26 y30 b_4 z2 z6 z10 z14 z18 z22 z26 z30 x3 x7 x11 x15 x19 x23 x27 x31 b_5 y3 y7 y11 y15 y19 y23 y27 y31 z3 z7 z11 z15 z19 z23 z27 z31
                b_0 = YGroup2Unzip(a_0, a_1, out b_3);
                b_1 = YGroup2Unzip(a_2, a_3, out b_4);
                b_2 = YGroup2Unzip(a_4, a_5, out b_5);
                // 3 a_0 x0 x8 x16 x24 y0 y8 y16 y24 z0 z8 z16 z24 x1 x9 x17 x25 a_1 y1 y9 y17 y25 z1 z9 z17 z25 x2 x10 x18 x26 y2 y10 y18 y26 a_2 z2 z10 z18 z26 x3 x11 x19 x27 y3 y11 y19 y27 z3 z11 z19 z27 a_3 x4 x12 x20 x28 y4 y12 y20 y28 z4 z12 z20 z28 x5 x13 x21 x29 a_4 y5 y13 y21 y29 z5 z13 z21 z29 x6 x14 x22 x30 y6 y14 y22 y30 a_5 z6 z14 z22 z30 x7 x15 x23 x31 y7 y15 y23 y31 z7 z15 z23 z31
                a_0 = YGroup2Unzip(b_0, b_1, out a_3);
                a_1 = YGroup2Unzip(b_2, b_3, out a_4);
                a_2 = YGroup2Unzip(b_4, b_5, out a_5);
                // 4 b_0 x0 x16 y0 y16 z0 z16 x1 x17 y1 y17 z1 z17 x2 x18 y2 y18 b_1 z2 z18 x3 x19 y3 y19 z3 z19 x4 x20 y4 y20 z4 z20 x5 x21 b_2 y5 y21 z5 z21 x6 x22 y6 y22 z6 z22 x7 x23 y7 y23 z7 z23 b_3 x8 x24 y8 y24 z8 z24 x9 x25 y9 y25 z9 z25 x10 x26 y10 y26 b_4 z10 z26 x11 x27 y11 y27 z11 z27 x12 x28 y12 y28 z12 z28 x13 x29 b_5 y13 y29 z13 z29 x14 x30 y14 y30 z14 z30 x15 x31 y15 y31 z15 z31
                b_0 = YGroup2Unzip(a_0, a_1, out b_3);
                b_1 = YGroup2Unzip(a_2, a_3, out b_4);
                b_2 = YGroup2Unzip(a_4, a_5, out b_5);
                // 5 a_0 x0 y0 z0 x1 y1 z1 x2 y2 z2 x3 y3 z3 x4 y4 z4 x5 a_1 y5 z5 x6 y6 z6 x7 y7 z7 x8 y8 z8 x9 y9 z9 x10 y10 a_2 z10 x11 y11 z11 x12 y12 z12 x13 y13 z13 x14 y14 z14 x15 y15 z15 a_3 x16 y16 z16 x17 y17 z17 x18 y18 z18 x19 y19 z19 x20 y20 z20 x21 a_4 y21 z21 x22 y22 z22 x23 y23 z23 x24 y24 z24 x25 y25 z25 x26 y26 a_5 z26 x27 y27 z27 x28 y28 z28 x29 y29 z29 x30 y30 z30 x31 y31 z31
                a_0 = YGroup2Unzip(b_0, b_1, out a_3);
                a_1 = YGroup2Unzip(b_2, b_3, out a_4);
                a_2 = YGroup2Unzip(b_4, b_5, out a_5);
                data1 = a_1;
                data2 = a_2;
                data3 = a_3;
                data4 = a_4;
                data5 = a_5;
                return a_0;
            }

#endif // VECTOR_HAS_METHOD

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2_X2(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup3ZipX2_X2(Vector512<float> x, Vector512<float> xB, Vector512<float> y, Vector512<float> yB, Vector512<float> z, Vector512<float> zB, out Vector512<float> data1, out Vector512<float> data2, out Vector512<float> data3, out Vector512<float> data4, out Vector512<float> data5) {
                var data0 = YGroup3Zip(x, y, z, out data1, out data2);
                data3 = YGroup3Zip(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2_X2(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup3ZipX2_X2(Vector512<double> x, Vector512<double> xB, Vector512<double> y, Vector512<double> yB, Vector512<double> z, Vector512<double> zB, out Vector512<double> data1, out Vector512<double> data2, out Vector512<double> data3, out Vector512<double> data4, out Vector512<double> data5) {
                var data0 = YGroup3Zip(x, y, z, out data1, out data2);
                data3 = YGroup3Zip(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2_X2(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup3ZipX2_X2(Vector512<sbyte> x, Vector512<sbyte> xB, Vector512<sbyte> y, Vector512<sbyte> yB, Vector512<sbyte> z, Vector512<sbyte> zB, out Vector512<sbyte> data1, out Vector512<sbyte> data2, out Vector512<sbyte> data3, out Vector512<sbyte> data4, out Vector512<sbyte> data5) {
                var data0 = YGroup3Zip(x, y, z, out data1, out data2);
                data3 = YGroup3Zip(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2_X2(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup3ZipX2_X2(Vector512<byte> x, Vector512<byte> xB, Vector512<byte> y, Vector512<byte> yB, Vector512<byte> z, Vector512<byte> zB, out Vector512<byte> data1, out Vector512<byte> data2, out Vector512<byte> data3, out Vector512<byte> data4, out Vector512<byte> data5) {
                var data0 = YGroup3Zip(x, y, z, out data1, out data2);
                data3 = YGroup3Zip(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2_X2(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup3ZipX2_X2(Vector512<short> x, Vector512<short> xB, Vector512<short> y, Vector512<short> yB, Vector512<short> z, Vector512<short> zB, out Vector512<short> data1, out Vector512<short> data2, out Vector512<short> data3, out Vector512<short> data4, out Vector512<short> data5) {
                var data0 = YGroup3Zip(x, y, z, out data1, out data2);
                data3 = YGroup3Zip(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2_X2(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup3ZipX2_X2(Vector512<ushort> x, Vector512<ushort> xB, Vector512<ushort> y, Vector512<ushort> yB, Vector512<ushort> z, Vector512<ushort> zB, out Vector512<ushort> data1, out Vector512<ushort> data2, out Vector512<ushort> data3, out Vector512<ushort> data4, out Vector512<ushort> data5) {
                var data0 = YGroup3Zip(x, y, z, out data1, out data2);
                data3 = YGroup3Zip(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2_X2(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup3ZipX2_X2(Vector512<int> x, Vector512<int> xB, Vector512<int> y, Vector512<int> yB, Vector512<int> z, Vector512<int> zB, out Vector512<int> data1, out Vector512<int> data2, out Vector512<int> data3, out Vector512<int> data4, out Vector512<int> data5) {
                var data0 = YGroup3Zip(x, y, z, out data1, out data2);
                data3 = YGroup3Zip(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2_X2(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup3ZipX2_X2(Vector512<uint> x, Vector512<uint> xB, Vector512<uint> y, Vector512<uint> yB, Vector512<uint> z, Vector512<uint> zB, out Vector512<uint> data1, out Vector512<uint> data2, out Vector512<uint> data3, out Vector512<uint> data4, out Vector512<uint> data5) {
                var data0 = YGroup3Zip(x, y, z, out data1, out data2);
                data3 = YGroup3Zip(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2_X2(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup3ZipX2_X2(Vector512<long> x, Vector512<long> xB, Vector512<long> y, Vector512<long> yB, Vector512<long> z, Vector512<long> zB, out Vector512<long> data1, out Vector512<long> data2, out Vector512<long> data3, out Vector512<long> data4, out Vector512<long> data5) {
                var data0 = YGroup3Zip(x, y, z, out data1, out data2);
                data3 = YGroup3Zip(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup3ZipX2_X2(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup3ZipX2_X2(Vector512<ulong> x, Vector512<ulong> xB, Vector512<ulong> y, Vector512<ulong> yB, Vector512<ulong> z, Vector512<ulong> zB, out Vector512<ulong> data1, out Vector512<ulong> data2, out Vector512<ulong> data3, out Vector512<ulong> data4, out Vector512<ulong> data5) {
                var data0 = YGroup3Zip(x, y, z, out data1, out data2);
                data3 = YGroup3Zip(xB, yB, zB, out data4, out data5);
                return data0;
            }


            /// <inheritdoc cref="IWVectorTraits512.YGroup4ToGroup3_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup4ToGroup3_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt = TypeCodeFlags.Byte | TypeCodeFlags.SByte;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4ToGroup3(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, out Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup4ToGroup3(Vector512<float> data0, Vector512<float> data1, Vector512<float> data2, Vector512<float> data3, out Vector512<float> result1, out Vector512<float> result2) {
                var d0 = YGroup4ToGroup3(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), out var d1, out var d2);
                result1 = d1.AsSingle();
                result2 = d2.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4ToGroup3(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, out Vector512{double}, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup4ToGroup3(Vector512<double> data0, Vector512<double> data1, Vector512<double> data2, Vector512<double> data3, out Vector512<double> result1, out Vector512<double> result2) {
                var d0 = YGroup4ToGroup3(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), data3.AsUInt64(), out var d1, out var d2);
                result1 = d1.AsDouble();
                result2 = d2.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4ToGroup3(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup4ToGroup3(Vector512<sbyte> data0, Vector512<sbyte> data1, Vector512<sbyte> data2, Vector512<sbyte> data3, out Vector512<sbyte> result1, out Vector512<sbyte> result2) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup4ToGroup3_Unzip(data0, data1, data2, data3, out result1, out result2);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup4ToGroup3_Basic(data0, data1, data2, data3, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4ToGroup3(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup4ToGroup3(Vector512<byte> data0, Vector512<byte> data1, Vector512<byte> data2, Vector512<byte> data3, out Vector512<byte> result1, out Vector512<byte> result2) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup4ToGroup3_Unzip(data0, data1, data2, data3, out result1, out result2);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup4ToGroup3_Basic(data0, data1, data2, data3, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4ToGroup3(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup4ToGroup3(Vector512<short> data0, Vector512<short> data1, Vector512<short> data2, Vector512<short> data3, out Vector512<short> result1, out Vector512<short> result2) {
                return YGroup4ToGroup3_Basic(data0, data1, data2, data3, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4ToGroup3(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup4ToGroup3(Vector512<ushort> data0, Vector512<ushort> data1, Vector512<ushort> data2, Vector512<ushort> data3, out Vector512<ushort> result1, out Vector512<ushort> result2) {
                return YGroup4ToGroup3_Basic(data0, data1, data2, data3, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4ToGroup3(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup4ToGroup3(Vector512<int> data0, Vector512<int> data1, Vector512<int> data2, Vector512<int> data3, out Vector512<int> result1, out Vector512<int> result2) {
                return YGroup4ToGroup3_Basic(data0, data1, data2, data3, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4ToGroup3(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup4ToGroup3(Vector512<uint> data0, Vector512<uint> data1, Vector512<uint> data2, Vector512<uint> data3, out Vector512<uint> result1, out Vector512<uint> result2) {
                return YGroup4ToGroup3_Basic(data0, data1, data2, data3, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4ToGroup3(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup4ToGroup3(Vector512<long> data0, Vector512<long> data1, Vector512<long> data2, Vector512<long> data3, out Vector512<long> result1, out Vector512<long> result2) {
                return YGroup4ToGroup3_Basic(data0, data1, data2, data3, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4ToGroup3(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup4ToGroup3(Vector512<ulong> data0, Vector512<ulong> data1, Vector512<ulong> data2, Vector512<ulong> data3, out Vector512<ulong> result1, out Vector512<ulong> result2) {
                return YGroup4ToGroup3_Basic(data0, data1, data2, data3, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4ToGroup3(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup4ToGroup3_Basic(Vector512<sbyte> data0, Vector512<sbyte> data1, Vector512<sbyte> data2, Vector512<sbyte> data3, out Vector512<sbyte> result1, out Vector512<sbyte> result2) {
                var d0 = YGroup4ToGroup3_Basic(data0.AsByte(), data1.AsByte(), data2.AsByte(), data3.AsByte(), out var d1, out var d2);
                result1 = d1.AsSByte();
                result2 = d2.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4ToGroup3(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup4ToGroup3_Basic(Vector512<byte> data0, Vector512<byte> data1, Vector512<byte> data2, Vector512<byte> data3, out Vector512<byte> result1, out Vector512<byte> result2) {
                Span<Vector512<byte>> src = [data0, data1, data2, data3];
                Span<Vector512<byte>> dst = stackalloc Vector512<byte>[3];
                Span<byte> p = MemoryMarshal.Cast<Vector512<byte>, byte>(src);
                Span<byte> q = MemoryMarshal.Cast<Vector512<byte>, byte>(dst);
                for (int i = 0; i < Vector512<byte>.Count; ++i) {
                    q[0] = p[0];
                    q[1] = p[1];
                    q[2] = p[2];
                    p = p.Slice(4);
                    q = q.Slice(3);
                }
                result1 = dst[1];
                result2 = dst[2];
                return dst[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4ToGroup3(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup4ToGroup3_Basic(Vector512<short> data0, Vector512<short> data1, Vector512<short> data2, Vector512<short> data3, out Vector512<short> result1, out Vector512<short> result2) {
                var d0 = YGroup4ToGroup3_Basic(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), data3.AsUInt16(), out var d1, out var d2);
                result1 = d1.AsInt16();
                result2 = d2.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4ToGroup3(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup4ToGroup3_Basic(Vector512<ushort> data0, Vector512<ushort> data1, Vector512<ushort> data2, Vector512<ushort> data3, out Vector512<ushort> result1, out Vector512<ushort> result2) {
                Span<Vector512<ushort>> src = [data0, data1, data2, data3];
                Span<Vector512<ushort>> dst = stackalloc Vector512<ushort>[3];
                Span<ushort> p = MemoryMarshal.Cast<Vector512<ushort>, ushort>(src);
                Span<ushort> q = MemoryMarshal.Cast<Vector512<ushort>, ushort>(dst);
                for (int i = 0; i < Vector512<ushort>.Count; ++i) {
                    q[0] = p[0];
                    q[1] = p[1];
                    q[2] = p[2];
                    p = p.Slice(4);
                    q = q.Slice(3);
                }
                result1 = dst[1];
                result2 = dst[2];
                return dst[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4ToGroup3(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup4ToGroup3_Basic(Vector512<int> data0, Vector512<int> data1, Vector512<int> data2, Vector512<int> data3, out Vector512<int> result1, out Vector512<int> result2) {
                var d0 = YGroup4ToGroup3_Basic(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), out var d1, out var d2);
                result1 = d1.AsInt32();
                result2 = d2.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4ToGroup3(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup4ToGroup3_Basic(Vector512<uint> data0, Vector512<uint> data1, Vector512<uint> data2, Vector512<uint> data3, out Vector512<uint> result1, out Vector512<uint> result2) {
                Span<Vector512<uint>> src = [data0, data1, data2, data3];
                Span<Vector512<uint>> dst = stackalloc Vector512<uint>[3];
                Span<uint> p = MemoryMarshal.Cast<Vector512<uint>, uint>(src);
                Span<uint> q = MemoryMarshal.Cast<Vector512<uint>, uint>(dst);
                for (int i = 0; i < Vector512<uint>.Count; ++i) {
                    q[0] = p[0];
                    q[1] = p[1];
                    q[2] = p[2];
                    p = p.Slice(4);
                    q = q.Slice(3);
                }
                result1 = dst[1];
                result2 = dst[2];
                return dst[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4ToGroup3(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup4ToGroup3_Basic(Vector512<long> data0, Vector512<long> data1, Vector512<long> data2, Vector512<long> data3, out Vector512<long> result1, out Vector512<long> result2) {
                var d0 = YGroup4ToGroup3_Basic(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), data3.AsUInt64(), out var d1, out var d2);
                result1 = d1.AsInt64();
                result2 = d2.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4ToGroup3(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup4ToGroup3_Basic(Vector512<ulong> data0, Vector512<ulong> data1, Vector512<ulong> data2, Vector512<ulong> data3, out Vector512<ulong> result1, out Vector512<ulong> result2) {
                Span<Vector512<ulong>> src = [data0, data1, data2, data3];
                Span<Vector512<ulong>> dst = stackalloc Vector512<ulong>[3];
                Span<ulong> p = MemoryMarshal.Cast<Vector512<ulong>, ulong>(src);
                Span<ulong> q = MemoryMarshal.Cast<Vector512<ulong>, ulong>(dst);
                for (int i = 0; i < Vector512<ulong>.Count; ++i) {
                    q[0] = p[0];
                    q[1] = p[1];
                    q[2] = p[2];
                    p = p.Slice(4);
                    q = q.Slice(3);
                }
                result1 = dst[1];
                result2 = dst[2];
                return dst[0];
            }

#if VECTOR_HAS_METHOD

            /// <inheritdoc cref="IWVectorTraits512.YGroup4ToGroup3(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup4ToGroup3_Shuffle(Vector512<sbyte> data0, Vector512<sbyte> data1, Vector512<sbyte> data2, Vector512<sbyte> data3, out Vector512<sbyte> result1, out Vector512<sbyte> result2) {
                var d0 = YGroup4ToGroup3_Shuffle(data0.AsByte(), data1.AsByte(), data2.AsByte(), data3.AsByte(), out var d1, out var d2);
                result1 = d1.AsSByte();
                result2 = d2.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4ToGroup3(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup4ToGroup3_Shuffle(Vector512<byte> data0, Vector512<byte> data1, Vector512<byte> data2, Vector512<byte> data3, out Vector512<byte> result1, out Vector512<byte> result2) {
                var f0A = Vector512Constants.YGroup4ToGroup3_Shuffle_Byte_0A;
                var f0B = Vector512Constants.YGroup4ToGroup3_Shuffle_Byte_0B;
                var f1A = Vector512Constants.YGroup4ToGroup3_Shuffle_Byte_1A;
                var f1B = Vector512Constants.YGroup4ToGroup3_Shuffle_Byte_1B;
                var f2A = Vector512Constants.YGroup4ToGroup3_Shuffle_Byte_2A;
                var f2B = Vector512Constants.YGroup4ToGroup3_Shuffle_Byte_2B;
                var a_0 = Vector512.BitwiseOr(Vector512.Shuffle(data0, f0A), Vector512.Shuffle(data1, f0B));
                var a_1 = Vector512.BitwiseOr(Vector512.Shuffle(data1, f1A), Vector512.Shuffle(data2, f1B));
                var a_2 = Vector512.BitwiseOr(Vector512.Shuffle(data2, f2A), Vector512.Shuffle(data3, f2B));
                result1 = a_1;
                result2 = a_2;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4ToGroup3(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup4ToGroup3_Shuffle(Vector512<short> data0, Vector512<short> data1, Vector512<short> data2, Vector512<short> data3, out Vector512<short> result1, out Vector512<short> result2) {
                var d0 = YGroup4ToGroup3_Shuffle(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), data3.AsUInt16(), out var d1, out var d2);
                result1 = d1.AsInt16();
                result2 = d2.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4ToGroup3(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup4ToGroup3_Shuffle(Vector512<ushort> data0, Vector512<ushort> data1, Vector512<ushort> data2, Vector512<ushort> data3, out Vector512<ushort> result1, out Vector512<ushort> result2) {
                var f0A = Vector512Constants.YGroup4ToGroup3_ShuffleOnByte_UInt16_0A;
                var f0B = Vector512Constants.YGroup4ToGroup3_ShuffleOnByte_UInt16_0B;
                var f1A = Vector512Constants.YGroup4ToGroup3_ShuffleOnByte_UInt16_1A;
                var f1B = Vector512Constants.YGroup4ToGroup3_ShuffleOnByte_UInt16_1B;
                var f2A = Vector512Constants.YGroup4ToGroup3_ShuffleOnByte_UInt16_2A;
                var f2B = Vector512Constants.YGroup4ToGroup3_ShuffleOnByte_UInt16_2B;
                var s0 = data0.AsByte();
                var s1 = data1.AsByte();
                var s2 = data2.AsByte();
                var s3 = data3.AsByte();
                var a_0 = Vector512.BitwiseOr(Vector512.Shuffle(s0, f0A), Vector512.Shuffle(s1, f0B)).AsUInt16();
                var a_1 = Vector512.BitwiseOr(Vector512.Shuffle(s1, f1A), Vector512.Shuffle(s2, f1B)).AsUInt16();
                var a_2 = Vector512.BitwiseOr(Vector512.Shuffle(s2, f2A), Vector512.Shuffle(s3, f2B)).AsUInt16();
                result1 = a_1;
                result2 = a_2;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4ToGroup3(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup4ToGroup3_Shuffle(Vector512<int> data0, Vector512<int> data1, Vector512<int> data2, Vector512<int> data3, out Vector512<int> result1, out Vector512<int> result2) {
                var d0 = YGroup4ToGroup3_Shuffle(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), out var d1, out var d2);
                result1 = d1.AsInt32();
                result2 = d2.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4ToGroup3(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup4ToGroup3_Shuffle(Vector512<uint> data0, Vector512<uint> data1, Vector512<uint> data2, Vector512<uint> data3, out Vector512<uint> result1, out Vector512<uint> result2) {
                var f0A = Vector512Constants.YGroup4ToGroup3_ShuffleOnByte_UInt32_0A;
                var f0B = Vector512Constants.YGroup4ToGroup3_ShuffleOnByte_UInt32_0B;
                var f1A = Vector512Constants.YGroup4ToGroup3_ShuffleOnByte_UInt32_1A;
                var f1B = Vector512Constants.YGroup4ToGroup3_ShuffleOnByte_UInt32_1B;
                var f2A = Vector512Constants.YGroup4ToGroup3_ShuffleOnByte_UInt32_2A;
                var f2B = Vector512Constants.YGroup4ToGroup3_ShuffleOnByte_UInt32_2B;
                var s0 = data0.AsByte();
                var s1 = data1.AsByte();
                var s2 = data2.AsByte();
                var s3 = data3.AsByte();
                var a_0 = Vector512.BitwiseOr(Vector512.Shuffle(s0, f0A), Vector512.Shuffle(s1, f0B)).AsUInt32();
                var a_1 = Vector512.BitwiseOr(Vector512.Shuffle(s1, f1A), Vector512.Shuffle(s2, f1B)).AsUInt32();
                var a_2 = Vector512.BitwiseOr(Vector512.Shuffle(s2, f2A), Vector512.Shuffle(s3, f2B)).AsUInt32();
                result1 = a_1;
                result2 = a_2;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4ToGroup3(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup4ToGroup3_Shuffle(Vector512<long> data0, Vector512<long> data1, Vector512<long> data2, Vector512<long> data3, out Vector512<long> result1, out Vector512<long> result2) {
                var d0 = YGroup4ToGroup3_Shuffle(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), data3.AsUInt64(), out var d1, out var d2);
                result1 = d1.AsInt64();
                result2 = d2.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4ToGroup3(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup4ToGroup3_Shuffle(Vector512<ulong> data0, Vector512<ulong> data1, Vector512<ulong> data2, Vector512<ulong> data3, out Vector512<ulong> result1, out Vector512<ulong> result2) {
                var f0A = Vector512Constants.YGroup4ToGroup3_ShuffleOnByte_UInt64_0A;
                var f0B = Vector512Constants.YGroup4ToGroup3_ShuffleOnByte_UInt64_0B;
                var f1A = Vector512Constants.YGroup4ToGroup3_ShuffleOnByte_UInt64_1A;
                var f1B = Vector512Constants.YGroup4ToGroup3_ShuffleOnByte_UInt64_1B;
                var f2A = Vector512Constants.YGroup4ToGroup3_ShuffleOnByte_UInt64_2A;
                var f2B = Vector512Constants.YGroup4ToGroup3_ShuffleOnByte_UInt64_2B;
                var s0 = data0.AsByte();
                var s1 = data1.AsByte();
                var s2 = data2.AsByte();
                var s3 = data3.AsByte();
                var a_0 = Vector512.BitwiseOr(Vector512.Shuffle(s0, f0A), Vector512.Shuffle(s1, f0B)).AsUInt64();
                var a_1 = Vector512.BitwiseOr(Vector512.Shuffle(s1, f1A), Vector512.Shuffle(s2, f1B)).AsUInt64();
                var a_2 = Vector512.BitwiseOr(Vector512.Shuffle(s2, f2A), Vector512.Shuffle(s3, f2B)).AsUInt64();
                result1 = a_1;
                result2 = a_2;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4ToGroup3(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup4ToGroup3_Unzip(Vector512<sbyte> data0, Vector512<sbyte> data1, Vector512<sbyte> data2, Vector512<sbyte> data3, out Vector512<sbyte> result1, out Vector512<sbyte> result2) {
                var d0 = YGroup4ToGroup3_Unzip(data0.AsByte(), data1.AsByte(), data2.AsByte(), data3.AsByte(), out var d1, out var d2);
                result1 = d1.AsSByte();
                result2 = d2.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4ToGroup3(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup4ToGroup3_Unzip(Vector512<byte> data0, Vector512<byte> data1, Vector512<byte> data2, Vector512<byte> data3, out Vector512<byte> result1, out Vector512<byte> result2) {
                var a_0 = YGroup4Unzip(data0, data1, data2, data3, out var a_1, out var a_2, out _);
                var b_0 = YGroup3Zip(a_0, a_1, a_2, out var b_1, out var b_2);
                result1 = b_1;
                result2 = b_2;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4ToGroup3(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup4ToGroup3_Unzip(Vector512<short> data0, Vector512<short> data1, Vector512<short> data2, Vector512<short> data3, out Vector512<short> result1, out Vector512<short> result2) {
                var d0 = YGroup4ToGroup3_Unzip(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), data3.AsUInt16(), out var d1, out var d2);
                result1 = d1.AsInt16();
                result2 = d2.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4ToGroup3(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup4ToGroup3_Unzip(Vector512<ushort> data0, Vector512<ushort> data1, Vector512<ushort> data2, Vector512<ushort> data3, out Vector512<ushort> result1, out Vector512<ushort> result2) {
                var a_0 = YGroup4Unzip(data0, data1, data2, data3, out var a_1, out var a_2, out _);
                var b_0 = YGroup3Zip(a_0, a_1, a_2, out var b_1, out var b_2);
                result1 = b_1;
                result2 = b_2;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4ToGroup3(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup4ToGroup3_Unzip(Vector512<int> data0, Vector512<int> data1, Vector512<int> data2, Vector512<int> data3, out Vector512<int> result1, out Vector512<int> result2) {
                var d0 = YGroup4ToGroup3_Unzip(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), out var d1, out var d2);
                result1 = d1.AsInt32();
                result2 = d2.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4ToGroup3(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup4ToGroup3_Unzip(Vector512<uint> data0, Vector512<uint> data1, Vector512<uint> data2, Vector512<uint> data3, out Vector512<uint> result1, out Vector512<uint> result2) {
                var a_0 = YGroup4Unzip(data0, data1, data2, data3, out var a_1, out var a_2, out _);
                var b_0 = YGroup3Zip(a_0, a_1, a_2, out var b_1, out var b_2);
                result1 = b_1;
                result2 = b_2;
                return b_0;
            }

#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup4Unzip_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt = TypeCodeFlagsUtil.Most32Types;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup4Unzip(Vector512<float> data0, Vector512<float> data1, Vector512<float> data2, Vector512<float> data3, out Vector512<float> y, out Vector512<float> z, out Vector512<float> w) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup4Unzip_Basic(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup4Unzip(Vector512<double> data0, Vector512<double> data1, Vector512<double> data2, Vector512<double> data3, out Vector512<double> y, out Vector512<double> z, out Vector512<double> w) {
                return YGroup4Unzip_Basic(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup4Unzip(Vector512<sbyte> data0, Vector512<sbyte> data1, Vector512<sbyte> data2, Vector512<sbyte> data3, out Vector512<sbyte> y, out Vector512<sbyte> z, out Vector512<sbyte> w) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup4Unzip_Basic(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup4Unzip(Vector512<byte> data0, Vector512<byte> data1, Vector512<byte> data2, Vector512<byte> data3, out Vector512<byte> y, out Vector512<byte> z, out Vector512<byte> w) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup4Unzip_Basic(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup4Unzip(Vector512<short> data0, Vector512<short> data1, Vector512<short> data2, Vector512<short> data3, out Vector512<short> y, out Vector512<short> z, out Vector512<short> w) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup4Unzip_Basic(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup4Unzip(Vector512<ushort> data0, Vector512<ushort> data1, Vector512<ushort> data2, Vector512<ushort> data3, out Vector512<ushort> y, out Vector512<ushort> z, out Vector512<ushort> w) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup4Unzip_Basic(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup4Unzip(Vector512<int> data0, Vector512<int> data1, Vector512<int> data2, Vector512<int> data3, out Vector512<int> y, out Vector512<int> z, out Vector512<int> w) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup4Unzip_Basic(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup4Unzip(Vector512<uint> data0, Vector512<uint> data1, Vector512<uint> data2, Vector512<uint> data3, out Vector512<uint> y, out Vector512<uint> z, out Vector512<uint> w) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup4Unzip_Basic(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup4Unzip(Vector512<long> data0, Vector512<long> data1, Vector512<long> data2, Vector512<long> data3, out Vector512<long> y, out Vector512<long> z, out Vector512<long> w) {
                return YGroup4Unzip_Basic(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup4Unzip(Vector512<ulong> data0, Vector512<ulong> data1, Vector512<ulong> data2, Vector512<ulong> data3, out Vector512<ulong> y, out Vector512<ulong> z, out Vector512<ulong> w) {
                return YGroup4Unzip_Basic(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{ExInt128}, Vector512{ExInt128}, Vector512{ExInt128}, Vector512{ExInt128}, out Vector512{ExInt128}, out Vector512{ExInt128}, out Vector512{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExInt128> YGroup4Unzip(Vector512<ExInt128> data0, Vector512<ExInt128> data1, Vector512<ExInt128> data2, Vector512<ExInt128> data3, out Vector512<ExInt128> y, out Vector512<ExInt128> z, out Vector512<ExInt128> w) {
                return YGroup4Unzip_Move(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{ExUInt128}, Vector512{ExUInt128}, Vector512{ExUInt128}, Vector512{ExUInt128}, out Vector512{ExUInt128}, out Vector512{ExUInt128}, out Vector512{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExUInt128> YGroup4Unzip(Vector512<ExUInt128> data0, Vector512<ExUInt128> data1, Vector512<ExUInt128> data2, Vector512<ExUInt128> data3, out Vector512<ExUInt128> y, out Vector512<ExUInt128> z, out Vector512<ExUInt128> w) {
                return YGroup4Unzip_Move(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip_Bit128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<T> YGroup4Unzip_Bit128<T>(Vector512<T> data0, Vector512<T> data1, Vector512<T> data2, Vector512<T> data3, out Vector512<T> y, out Vector512<T> z, out Vector512<T> w) where T : struct {
#if EX_APPLY_GENERIC
                var d0 = YGroup4Unzip_Move(data0.ExAs<T, ExUInt128>(), data1.ExAs<T, ExUInt128>(), data2.ExAs<T, ExUInt128>(), data3.ExAs<T, ExUInt128>(), out var d1, out var d2, out var d3);
                y = d1.ExAs<ExUInt128, T>();
                z = d2.ExAs<ExUInt128, T>();
                w = d3.ExAs<ExUInt128, T>();
                return d0.ExAs<ExUInt128, T>();
#else
                var a0 = data0;
                var a1 = data1;
                var a2 = data2;
                var a3 = data3;
                var a0l = a0.GetLower();
                var a0u = a0.GetUpper();
                var a1l = a1.GetLower();
                var a1u = a1.GetUpper();
                var a2l = a2.GetLower();
                var a2u = a2.GetUpper();
                var a3l = a3.GetLower();
                var a3u = a3.GetUpper();
                var c0 = a0l.WithUpper(a1l.GetLower()).ToVector512Unsafe().WithUpper(a2l.WithUpper(a3l.GetLower()));
                var c1 = a0l.GetUpper().ToVector256Unsafe().WithUpper(a1l.GetUpper()).ToVector512Unsafe().WithUpper(a2l.GetUpper().ToVector256Unsafe().WithUpper(a3l.GetUpper()));
                var c2 = a0u.WithUpper(a1u.GetLower()).ToVector512Unsafe().WithUpper(a2u.WithUpper(a3u.GetLower()));
                var c3 = a0u.GetUpper().ToVector256Unsafe().WithUpper(a1u.GetUpper()).ToVector512Unsafe().WithUpper(a2u.GetUpper().ToVector256Unsafe().WithUpper(a3u.GetUpper()));
                y = c1;
                z = c2;
                w = c3;
                return c0;
#endif // EX_APPLY_GENERIC
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup4Unzip_Basic(Vector512<float> data0, Vector512<float> data1, Vector512<float> data2, Vector512<float> data3, out Vector512<float> y, out Vector512<float> z, out Vector512<float> w) {
                var d0 = YGroup4Unzip_Basic(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), out var d1, out var d2, out var d3);
                y = d1.AsSingle();
                z = d2.AsSingle();
                w = d3.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup4Unzip_Basic(Vector512<double> data0, Vector512<double> data1, Vector512<double> data2, Vector512<double> data3, out Vector512<double> y, out Vector512<double> z, out Vector512<double> w) {
                var d0 = YGroup4Unzip_Basic(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), data3.AsUInt64(), out var d1, out var d2, out var d3);
                y = d1.AsDouble();
                z = d2.AsDouble();
                w = d3.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup4Unzip_Basic(Vector512<sbyte> data0, Vector512<sbyte> data1, Vector512<sbyte> data2, Vector512<sbyte> data3, out Vector512<sbyte> y, out Vector512<sbyte> z, out Vector512<sbyte> w) {
                var d0 = YGroup4Unzip_Basic(data0.AsByte(), data1.AsByte(), data2.AsByte(), data3.AsByte(), out var d1, out var d2, out var d3);
                y = d1.AsSByte();
                z = d2.AsSByte();
                w = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup4Unzip_Basic(Vector512<byte> data0, Vector512<byte> data1, Vector512<byte> data2, Vector512<byte> data3, out Vector512<byte> y, out Vector512<byte> z, out Vector512<byte> w) {
                UnsafeUtil.SkipInit(out Vector512<byte> x1);
                UnsafeUtil.SkipInit(out Vector512<byte> y1);
                UnsafeUtil.SkipInit(out Vector512<byte> z1);
                UnsafeUtil.SkipInit(out Vector512<byte> w1);
                Span<Vector512<byte>> src = [data0, data1, data2, data3];
                ref byte px = ref Unsafe.As<Vector512<byte>, byte>(ref x1);
                ref byte py = ref Unsafe.As<Vector512<byte>, byte>(ref y1);
                ref byte pz = ref Unsafe.As<Vector512<byte>, byte>(ref z1);
                ref byte pw = ref Unsafe.As<Vector512<byte>, byte>(ref w1);
                Span<byte> p = MemoryMarshal.Cast<Vector512<byte>, byte>(src);
                int idx = 0;
                for (int i = 0; i < Vector512<byte>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    Unsafe.Add(ref py, i) = p[idx + 1];
                    Unsafe.Add(ref pz, i) = p[idx + 2];
                    Unsafe.Add(ref pw, i) = p[idx + 3];
                    idx += 4;
                }
                y = y1;
                z = z1;
                w = w1;
                return x1;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup4Unzip_Basic(Vector512<short> data0, Vector512<short> data1, Vector512<short> data2, Vector512<short> data3, out Vector512<short> y, out Vector512<short> z, out Vector512<short> w) {
                var d0 = YGroup4Unzip_Basic(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), data3.AsUInt16(), out var d1, out var d2, out var d3);
                y = d1.AsInt16();
                z = d2.AsInt16();
                w = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup4Unzip_Basic(Vector512<ushort> data0, Vector512<ushort> data1, Vector512<ushort> data2, Vector512<ushort> data3, out Vector512<ushort> y, out Vector512<ushort> z, out Vector512<ushort> w) {
                UnsafeUtil.SkipInit(out Vector512<ushort> x1);
                UnsafeUtil.SkipInit(out Vector512<ushort> y1);
                UnsafeUtil.SkipInit(out Vector512<ushort> z1);
                UnsafeUtil.SkipInit(out Vector512<ushort> w1);
                Span<Vector512<ushort>> src = [data0, data1, data2, data3];
                ref ushort px = ref Unsafe.As<Vector512<ushort>, ushort>(ref x1);
                ref ushort py = ref Unsafe.As<Vector512<ushort>, ushort>(ref y1);
                ref ushort pz = ref Unsafe.As<Vector512<ushort>, ushort>(ref z1);
                ref ushort pw = ref Unsafe.As<Vector512<ushort>, ushort>(ref w1);
                Span<ushort> p = MemoryMarshal.Cast<Vector512<ushort>, ushort>(src);
                int idx = 0;
                for (int i = 0; i < Vector512<ushort>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    Unsafe.Add(ref py, i) = p[idx + 1];
                    Unsafe.Add(ref pz, i) = p[idx + 2];
                    Unsafe.Add(ref pw, i) = p[idx + 3];
                    idx += 4;
                }
                y = y1;
                z = z1;
                w = w1;
                return x1;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup4Unzip_Basic(Vector512<int> data0, Vector512<int> data1, Vector512<int> data2, Vector512<int> data3, out Vector512<int> y, out Vector512<int> z, out Vector512<int> w) {
                var d0 = YGroup4Unzip_Basic(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), out var d1, out var d2, out var d3);
                y = d1.AsInt32();
                z = d2.AsInt32();
                w = d3.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup4Unzip_Basic(Vector512<uint> data0, Vector512<uint> data1, Vector512<uint> data2, Vector512<uint> data3, out Vector512<uint> y, out Vector512<uint> z, out Vector512<uint> w) {
                UnsafeUtil.SkipInit(out Vector512<uint> x1);
                UnsafeUtil.SkipInit(out Vector512<uint> y1);
                UnsafeUtil.SkipInit(out Vector512<uint> z1);
                UnsafeUtil.SkipInit(out Vector512<uint> w1);
                Span<Vector512<uint>> src = [data0, data1, data2, data3];
                ref uint px = ref Unsafe.As<Vector512<uint>, uint>(ref x1);
                ref uint py = ref Unsafe.As<Vector512<uint>, uint>(ref y1);
                ref uint pz = ref Unsafe.As<Vector512<uint>, uint>(ref z1);
                ref uint pw = ref Unsafe.As<Vector512<uint>, uint>(ref w1);
                Span<uint> p = MemoryMarshal.Cast<Vector512<uint>, uint>(src);
                int idx = 0;
                for (int i = 0; i < Vector512<uint>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    Unsafe.Add(ref py, i) = p[idx + 1];
                    Unsafe.Add(ref pz, i) = p[idx + 2];
                    Unsafe.Add(ref pw, i) = p[idx + 3];
                    idx += 4;
                }
                y = y1;
                z = z1;
                w = w1;
                return x1;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup4Unzip_Basic(Vector512<long> data0, Vector512<long> data1, Vector512<long> data2, Vector512<long> data3, out Vector512<long> y, out Vector512<long> z, out Vector512<long> w) {
                var d0 = YGroup4Unzip_Basic(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), data3.AsUInt64(), out var d1, out var d2, out var d3);
                y = d1.AsInt64();
                z = d2.AsInt64();
                w = d3.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup4Unzip_Basic(Vector512<ulong> data0, Vector512<ulong> data1, Vector512<ulong> data2, Vector512<ulong> data3, out Vector512<ulong> y, out Vector512<ulong> z, out Vector512<ulong> w) {
                UnsafeUtil.SkipInit(out Vector512<ulong> x1);
                UnsafeUtil.SkipInit(out Vector512<ulong> y1);
                UnsafeUtil.SkipInit(out Vector512<ulong> z1);
                UnsafeUtil.SkipInit(out Vector512<ulong> w1);
                Span<Vector512<ulong>> src = [data0, data1, data2, data3];
                ref ulong px = ref Unsafe.As<Vector512<ulong>, ulong>(ref x1);
                ref ulong py = ref Unsafe.As<Vector512<ulong>, ulong>(ref y1);
                ref ulong pz = ref Unsafe.As<Vector512<ulong>, ulong>(ref z1);
                ref ulong pw = ref Unsafe.As<Vector512<ulong>, ulong>(ref w1);
                Span<ulong> p = MemoryMarshal.Cast<Vector512<ulong>, ulong>(src);
                int idx = 0;
                for (int i = 0; i < Vector512<ulong>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    Unsafe.Add(ref py, i) = p[idx + 1];
                    Unsafe.Add(ref pz, i) = p[idx + 2];
                    Unsafe.Add(ref pw, i) = p[idx + 3];
                    idx += 4;
                }
                y = y1;
                z = z1;
                w = w1;
                return x1;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{ExInt128}, Vector512{ExInt128}, Vector512{ExInt128}, Vector512{ExInt128}, out Vector512{ExInt128}, out Vector512{ExInt128}, out Vector512{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExInt128> YGroup4Unzip_Basic(Vector512<ExInt128> data0, Vector512<ExInt128> data1, Vector512<ExInt128> data2, Vector512<ExInt128> data3, out Vector512<ExInt128> y, out Vector512<ExInt128> z, out Vector512<ExInt128> w) {
                var d0 = YGroup4Unzip_Basic(data0.ExAsExUInt128(), data1.ExAsExUInt128(), data2.ExAsExUInt128(), data3.ExAsExUInt128(), out var d1, out var d2, out var d3);
                y = d1.ExAsExInt128();
                z = d2.ExAsExInt128();
                w = d3.ExAsExInt128();
                return d0.ExAsExInt128();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{ExUInt128}, Vector512{ExUInt128}, Vector512{ExUInt128}, Vector512{ExUInt128}, out Vector512{ExUInt128}, out Vector512{ExUInt128}, out Vector512{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExUInt128> YGroup4Unzip_Basic(Vector512<ExUInt128> data0, Vector512<ExUInt128> data1, Vector512<ExUInt128> data2, Vector512<ExUInt128> data3, out Vector512<ExUInt128> y, out Vector512<ExUInt128> z, out Vector512<ExUInt128> w) {
                UnsafeUtil.SkipInit(out Vector512<ExUInt128> x1);
                UnsafeUtil.SkipInit(out Vector512<ExUInt128> y1);
                UnsafeUtil.SkipInit(out Vector512<ExUInt128> z1);
                UnsafeUtil.SkipInit(out Vector512<ExUInt128> w1);
                Span<Vector512<ExUInt128>> src = [data0, data1, data2, data3];
                ref ExUInt128 px = ref Unsafe.As<Vector512<ExUInt128>, ExUInt128>(ref x1);
                ref ExUInt128 py = ref Unsafe.As<Vector512<ExUInt128>, ExUInt128>(ref y1);
                ref ExUInt128 pz = ref Unsafe.As<Vector512<ExUInt128>, ExUInt128>(ref z1);
                ref ExUInt128 pw = ref Unsafe.As<Vector512<ExUInt128>, ExUInt128>(ref w1);
                Span<ExUInt128> p = MemoryMarshal.Cast<Vector512<ExUInt128>, ExUInt128>(src);
                int cnt = Vector512s<ExUInt128>.Count;
                int idx = 0;
                for (int i = 0; i < cnt; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    Unsafe.Add(ref py, i) = p[idx + 1];
                    Unsafe.Add(ref pz, i) = p[idx + 2];
                    Unsafe.Add(ref pw, i) = p[idx + 3];
                    idx += 4;
                }
                y = y1;
                z = z1;
                w = w1;
                return x1;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{ExInt128}, Vector512{ExInt128}, Vector512{ExInt128}, Vector512{ExInt128}, out Vector512{ExInt128}, out Vector512{ExInt128}, out Vector512{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExInt128> YGroup4Unzip_Move(Vector512<ExInt128> data0, Vector512<ExInt128> data1, Vector512<ExInt128> data2, Vector512<ExInt128> data3, out Vector512<ExInt128> y, out Vector512<ExInt128> z, out Vector512<ExInt128> w) {
                var d0 = YGroup4Unzip_Move(data0.ExAsExUInt128(), data1.ExAsExUInt128(), data2.ExAsExUInt128(), data3.ExAsExUInt128(), out var d1, out var d2, out var d3);
                y = d1.ExAsExInt128();
                z = d2.ExAsExInt128();
                w = d3.ExAsExInt128();
                return d0.ExAsExInt128();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{ExUInt128}, Vector512{ExUInt128}, Vector512{ExUInt128}, Vector512{ExUInt128}, out Vector512{ExUInt128}, out Vector512{ExUInt128}, out Vector512{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExUInt128> YGroup4Unzip_Move(Vector512<ExUInt128> data0, Vector512<ExUInt128> data1, Vector512<ExUInt128> data2, Vector512<ExUInt128> data3, out Vector512<ExUInt128> y, out Vector512<ExUInt128> z, out Vector512<ExUInt128> w) {
                var a0 = data0.ExAsUInt64();
                var a1 = data1.ExAsUInt64();
                var a2 = data2.ExAsUInt64();
                var a3 = data3.ExAsUInt64();
                var a0l = a0.GetLower();
                var a0u = a0.GetUpper();
                var a1l = a1.GetLower();
                var a1u = a1.GetUpper();
                var a2l = a2.GetLower();
                var a2u = a2.GetUpper();
                var a3l = a3.GetLower();
                var a3u = a3.GetUpper();
                var c0 = a0l.WithUpper(a1l.GetLower()).ToVector512Unsafe().WithUpper(a2l.WithUpper(a3l.GetLower()));
                var c1 = a0l.GetUpper().ToVector256Unsafe().WithUpper(a1l.GetUpper()).ToVector512Unsafe().WithUpper(a2l.GetUpper().ToVector256Unsafe().WithUpper(a3l.GetUpper()));
                var c2 = a0u.WithUpper(a1u.GetLower()).ToVector512Unsafe().WithUpper(a2u.WithUpper(a3u.GetLower()));
                var c3 = a0u.GetUpper().ToVector256Unsafe().WithUpper(a1u.GetUpper()).ToVector512Unsafe().WithUpper(a2u.GetUpper().ToVector256Unsafe().WithUpper(a3u.GetUpper()));
                y = c1.ExAsExUInt128();
                z = c2.ExAsExUInt128();
                w = c3.ExAsExUInt128();
                return c0.ExAsExUInt128();
            }

#if VECTOR_HAS_METHOD

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup4Unzip_Narrow(Vector512<sbyte> data0, Vector512<sbyte> data1, Vector512<sbyte> data2, Vector512<sbyte> data3, out Vector512<sbyte> y, out Vector512<sbyte> z, out Vector512<sbyte> w) {
                var d0 = YGroup4Unzip_Narrow(data0.AsByte(), data1.AsByte(), data2.AsByte(), data3.AsByte(), out var d1, out var d2, out var d3);
                y = d1.AsSByte();
                z = d2.AsSByte();
                w = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup4Unzip_Narrow(Vector512<byte> data0, Vector512<byte> data1, Vector512<byte> data2, Vector512<byte> data3, out Vector512<byte> y, out Vector512<byte> z, out Vector512<byte> w) {
                const int L = 8;
                Vector512<byte> rt0, rt1, rt2, rt3;
                Vector512<uint> temp0, temp1, temp2, temp3;
                temp0 = data0.AsUInt32();
                temp1 = data1.AsUInt32();
                temp2 = data2.AsUInt32();
                temp3 = data3.AsUInt32();
                rt0 = Vector512.Narrow(Vector512.Narrow(temp0, temp1), Vector512.Narrow(temp2, temp3));
                temp0 = Vector512.ShiftRightLogical(temp0, L);
                temp1 = Vector512.ShiftRightLogical(temp1, L);
                temp2 = Vector512.ShiftRightLogical(temp2, L);
                temp3 = Vector512.ShiftRightLogical(temp3, L);
                rt1 = Vector512.Narrow(Vector512.Narrow(temp0, temp1), Vector512.Narrow(temp2, temp3));
                temp0 = Vector512.ShiftRightLogical(temp0, L);
                temp1 = Vector512.ShiftRightLogical(temp1, L);
                temp2 = Vector512.ShiftRightLogical(temp2, L);
                temp3 = Vector512.ShiftRightLogical(temp3, L);
                rt2 = Vector512.Narrow(Vector512.Narrow(temp0, temp1), Vector512.Narrow(temp2, temp3));
                temp0 = Vector512.ShiftRightLogical(temp0, L);
                temp1 = Vector512.ShiftRightLogical(temp1, L);
                temp2 = Vector512.ShiftRightLogical(temp2, L);
                temp3 = Vector512.ShiftRightLogical(temp3, L);
                rt3 = Vector512.Narrow(Vector512.Narrow(temp0, temp1), Vector512.Narrow(temp2, temp3));
                if (BitConverter.IsLittleEndian) {
                    y = rt1;
                    z = rt2;
                    w = rt3;
                    return rt0;
                } else {
                    y = rt2;
                    z = rt1;
                    w = rt0;
                    return rt3;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup4Unzip_Narrow(Vector512<short> data0, Vector512<short> data1, Vector512<short> data2, Vector512<short> data3, out Vector512<short> y, out Vector512<short> z, out Vector512<short> w) {
                var d0 = YGroup4Unzip_Narrow(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), data3.AsUInt16(), out var d1, out var d2, out var d3);
                y = d1.AsInt16();
                z = d2.AsInt16();
                w = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup4Unzip_Narrow(Vector512<ushort> data0, Vector512<ushort> data1, Vector512<ushort> data2, Vector512<ushort> data3, out Vector512<ushort> y, out Vector512<ushort> z, out Vector512<ushort> w) {
                const int L = 16;
                Vector512<ushort> rt0, rt1, rt2, rt3;
                Vector512<ulong> temp0, temp1, temp2, temp3;
                temp0 = data0.AsUInt64();
                temp1 = data1.AsUInt64();
                temp2 = data2.AsUInt64();
                temp3 = data3.AsUInt64();
                rt0 = Vector512.Narrow(Vector512.Narrow(temp0, temp1), Vector512.Narrow(temp2, temp3));
                temp0 = Vector512.ShiftRightLogical(temp0, L);
                temp1 = Vector512.ShiftRightLogical(temp1, L);
                temp2 = Vector512.ShiftRightLogical(temp2, L);
                temp3 = Vector512.ShiftRightLogical(temp3, L);
                rt1 = Vector512.Narrow(Vector512.Narrow(temp0, temp1), Vector512.Narrow(temp2, temp3));
                temp0 = Vector512.ShiftRightLogical(temp0, L);
                temp1 = Vector512.ShiftRightLogical(temp1, L);
                temp2 = Vector512.ShiftRightLogical(temp2, L);
                temp3 = Vector512.ShiftRightLogical(temp3, L);
                rt2 = Vector512.Narrow(Vector512.Narrow(temp0, temp1), Vector512.Narrow(temp2, temp3));
                temp0 = Vector512.ShiftRightLogical(temp0, L);
                temp1 = Vector512.ShiftRightLogical(temp1, L);
                temp2 = Vector512.ShiftRightLogical(temp2, L);
                temp3 = Vector512.ShiftRightLogical(temp3, L);
                rt3 = Vector512.Narrow(Vector512.Narrow(temp0, temp1), Vector512.Narrow(temp2, temp3));
                if (BitConverter.IsLittleEndian) {
                    y = rt1;
                    z = rt2;
                    w = rt3;
                    return rt0;
                } else {
                    y = rt2;
                    z = rt1;
                    w = rt0;
                    return rt3;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup4Unzip_Unzip(Vector512<float> data0, Vector512<float> data1, Vector512<float> data2, Vector512<float> data3, out Vector512<float> y, out Vector512<float> z, out Vector512<float> w) {
                var d0 = YGroup4Unzip_Unzip(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), out var d1, out var d2, out var d3);
                y = d1.AsSingle();
                z = d2.AsSingle();
                w = d3.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup4Unzip_Unzip(Vector512<sbyte> data0, Vector512<sbyte> data1, Vector512<sbyte> data2, Vector512<sbyte> data3, out Vector512<sbyte> y, out Vector512<sbyte> z, out Vector512<sbyte> w) {
                var d0 = YGroup4Unzip_Unzip(data0.AsByte(), data1.AsByte(), data2.AsByte(), data3.AsByte(), out var d1, out var d2, out var d3);
                y = d1.AsSByte();
                z = d2.AsSByte();
                w = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup4Unzip_Unzip(Vector512<byte> data0, Vector512<byte> data1, Vector512<byte> data2, Vector512<byte> data3, out Vector512<byte> y, out Vector512<byte> z, out Vector512<byte> w) {
                Vector512<byte> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
                // 0 data0 x0 y0 z0 w0 x1 y1 z1 w1 x2 y2 z2 w2 x3 y3 z3 w3 x4 y4 z4 w4 x5 y5 z5 w5 x6 y6 z6 w6 x7 y7 z7 w7 x8 y8 z8 w8 x9 y9 z9 w9 x10 y10 z10 w10 x11 y11 z11 w11 x12 y12 z12 w12 x13 y13 z13 w13 x14 y14 z14 w14 x15 y15 z15 w15 data1 x16 y16 z16 w16 x17 y17 z17 w17 x18 y18 z18 w18 x19 y19 z19 w19 x20 y20 z20 w20 x21 y21 z21 w21 x22 y22 z22 w22 x23 y23 z23 w23 x24 y24 z24 w24 x25 y25 z25 w25 x26 y26 z26 w26 x27 y27 z27 w27 x28 y28 z28 w28 x29 y29 z29 w29 x30 y30 z30 w30 x31 y31 z31 w31 data2 x32 y32 z32 w32 x33 y33 z33 w33 x34 y34 z34 w34 x35 y35 z35 w35 x36 y36 z36 w36 x37 y37 z37 w37 x38 y38 z38 w38 x39 y39 z39 w39 x40 y40 z40 w40 x41 y41 z41 w41 x42 y42 z42 w42 x43 y43 z43 w43 x44 y44 z44 w44 x45 y45 z45 w45 x46 y46 z46 w46 x47 y47 z47 w47 data3 x48 y48 z48 w48 x49 y49 z49 w49 x50 y50 z50 w50 x51 y51 z51 w51 x52 y52 z52 w52 x53 y53 z53 w53 x54 y54 z54 w54 x55 y55 z55 w55 x56 y56 z56 w56 x57 y57 z57 w57 x58 y58 z58 w58 x59 y59 z59 w59 x60 y60 z60 w60 x61 y61 z61 w61 x62 y62 z62 w62 x63 y63 z63 w63
                // 1 a_0 x0 z0 x1 z1 x2 z2 x3 z3 x4 z4 x5 z5 x6 z6 x7 z7 x8 z8 x9 z9 x10 z10 x11 z11 x12 z12 x13 z13 x14 z14 x15 z15 x16 z16 x17 z17 x18 z18 x19 z19 x20 z20 x21 z21 x22 z22 x23 z23 x24 z24 x25 z25 x26 z26 x27 z27 x28 z28 x29 z29 x30 z30 x31 z31 a_1 x32 z32 x33 z33 x34 z34 x35 z35 x36 z36 x37 z37 x38 z38 x39 z39 x40 z40 x41 z41 x42 z42 x43 z43 x44 z44 x45 z45 x46 z46 x47 z47 x48 z48 x49 z49 x50 z50 x51 z51 x52 z52 x53 z53 x54 z54 x55 z55 x56 z56 x57 z57 x58 z58 x59 z59 x60 z60 x61 z61 x62 z62 x63 z63 a_2 y0 w0 y1 w1 y2 w2 y3 w3 y4 w4 y5 w5 y6 w6 y7 w7 y8 w8 y9 w9 y10 w10 y11 w11 y12 w12 y13 w13 y14 w14 y15 w15 y16 w16 y17 w17 y18 w18 y19 w19 y20 w20 y21 w21 y22 w22 y23 w23 y24 w24 y25 w25 y26 w26 y27 w27 y28 w28 y29 w29 y30 w30 y31 w31 a_3 y32 w32 y33 w33 y34 w34 y35 w35 y36 w36 y37 w37 y38 w38 y39 w39 y40 w40 y41 w41 y42 w42 y43 w43 y44 w44 y45 w45 y46 w46 y47 w47 y48 w48 y49 w49 y50 w50 y51 w51 y52 w52 y53 w53 y54 w54 y55 w55 y56 w56 y57 w57 y58 w58 y59 w59 y60 w60 y61 w61 y62 w62 y63 w63
                a_0 = YGroup2Unzip(data0, data1, out a_2);
                a_1 = YGroup2Unzip(data2, data3, out a_3);
                // 2 b_0 x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 x16 x17 x18 x19 x20 x21 x22 x23 x24 x25 x26 x27 x28 x29 x30 x31 x32 x33 x34 x35 x36 x37 x38 x39 x40 x41 x42 x43 x44 x45 x46 x47 x48 x49 x50 x51 x52 x53 x54 x55 x56 x57 x58 x59 x60 x61 x62 x63 b_1 y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 y16 y17 y18 y19 y20 y21 y22 y23 y24 y25 y26 y27 y28 y29 y30 y31 y32 y33 y34 y35 y36 y37 y38 y39 y40 y41 y42 y43 y44 y45 y46 y47 y48 y49 y50 y51 y52 y53 y54 y55 y56 y57 y58 y59 y60 y61 y62 y63 b_2 z0 z1 z2 z3 z4 z5 z6 z7 z8 z9 z10 z11 z12 z13 z14 z15 z16 z17 z18 z19 z20 z21 z22 z23 z24 z25 z26 z27 z28 z29 z30 z31 z32 z33 z34 z35 z36 z37 z38 z39 z40 z41 z42 z43 z44 z45 z46 z47 z48 z49 z50 z51 z52 z53 z54 z55 z56 z57 z58 z59 z60 z61 z62 z63 b_3 w0 w1 w2 w3 w4 w5 w6 w7 w8 w9 w10 w11 w12 w13 w14 w15 w16 w17 w18 w19 w20 w21 w22 w23 w24 w25 w26 w27 w28 w29 w30 w31 w32 w33 w34 w35 w36 w37 w38 w39 w40 w41 w42 w43 w44 w45 w46 w47 w48 w49 w50 w51 w52 w53 w54 w55 w56 w57 w58 w59 w60 w61 w62 w63
                b_0 = YGroup2Unzip(a_0, a_1, out b_2);
                b_1 = YGroup2Unzip(a_2, a_3, out b_3);
                y = b_1;
                z = b_2;
                w = b_3;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup4Unzip_Unzip(Vector512<short> data0, Vector512<short> data1, Vector512<short> data2, Vector512<short> data3, out Vector512<short> y, out Vector512<short> z, out Vector512<short> w) {
                var d0 = YGroup4Unzip_Unzip(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), data3.AsUInt16(), out var d1, out var d2, out var d3);
                y = d1.AsInt16();
                z = d2.AsInt16();
                w = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup4Unzip_Unzip(Vector512<ushort> data0, Vector512<ushort> data1, Vector512<ushort> data2, Vector512<ushort> data3, out Vector512<ushort> y, out Vector512<ushort> z, out Vector512<ushort> w) {
                Vector512<ushort> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
                // 0 data0 x0 y0 z0 w0 x1 y1 z1 w1 x2 y2 z2 w2 x3 y3 z3 w3 x4 y4 z4 w4 x5 y5 z5 w5 x6 y6 z6 w6 x7 y7 z7 w7 data1 x8 y8 z8 w8 x9 y9 z9 w9 x10 y10 z10 w10 x11 y11 z11 w11 x12 y12 z12 w12 x13 y13 z13 w13 x14 y14 z14 w14 x15 y15 z15 w15 data2 x16 y16 z16 w16 x17 y17 z17 w17 x18 y18 z18 w18 x19 y19 z19 w19 x20 y20 z20 w20 x21 y21 z21 w21 x22 y22 z22 w22 x23 y23 z23 w23 data3 x24 y24 z24 w24 x25 y25 z25 w25 x26 y26 z26 w26 x27 y27 z27 w27 x28 y28 z28 w28 x29 y29 z29 w29 x30 y30 z30 w30 x31 y31 z31 w31
                // 1 a_0 x0 z0 x1 z1 x2 z2 x3 z3 x4 z4 x5 z5 x6 z6 x7 z7 x8 z8 x9 z9 x10 z10 x11 z11 x12 z12 x13 z13 x14 z14 x15 z15 a_1 x16 z16 x17 z17 x18 z18 x19 z19 x20 z20 x21 z21 x22 z22 x23 z23 x24 z24 x25 z25 x26 z26 x27 z27 x28 z28 x29 z29 x30 z30 x31 z31 a_2 y0 w0 y1 w1 y2 w2 y3 w3 y4 w4 y5 w5 y6 w6 y7 w7 y8 w8 y9 w9 y10 w10 y11 w11 y12 w12 y13 w13 y14 w14 y15 w15 a_3 y16 w16 y17 w17 y18 w18 y19 w19 y20 w20 y21 w21 y22 w22 y23 w23 y24 w24 y25 w25 y26 w26 y27 w27 y28 w28 y29 w29 y30 w30 y31 w31
                a_0 = YGroup2Unzip(data0, data1, out a_2);
                a_1 = YGroup2Unzip(data2, data3, out a_3);
                // 2 b_0 x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 x16 x17 x18 x19 x20 x21 x22 x23 x24 x25 x26 x27 x28 x29 x30 x31 b_1 y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 y16 y17 y18 y19 y20 y21 y22 y23 y24 y25 y26 y27 y28 y29 y30 y31 b_2 z0 z1 z2 z3 z4 z5 z6 z7 z8 z9 z10 z11 z12 z13 z14 z15 z16 z17 z18 z19 z20 z21 z22 z23 z24 z25 z26 z27 z28 z29 z30 z31 b_3 w0 w1 w2 w3 w4 w5 w6 w7 w8 w9 w10 w11 w12 w13 w14 w15 w16 w17 w18 w19 w20 w21 w22 w23 w24 w25 w26 w27 w28 w29 w30 w31
                b_0 = YGroup2Unzip(a_0, a_1, out b_2);
                b_1 = YGroup2Unzip(a_2, a_3, out b_3);
                y = b_1;
                z = b_2;
                w = b_3;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup4Unzip_Unzip(Vector512<int> data0, Vector512<int> data1, Vector512<int> data2, Vector512<int> data3, out Vector512<int> y, out Vector512<int> z, out Vector512<int> w) {
                var d0 = YGroup4Unzip_Unzip(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), out var d1, out var d2, out var d3);
                y = d1.AsInt32();
                z = d2.AsInt32();
                w = d3.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup4Unzip_Unzip(Vector512<uint> data0, Vector512<uint> data1, Vector512<uint> data2, Vector512<uint> data3, out Vector512<uint> y, out Vector512<uint> z, out Vector512<uint> w) {
                Vector512<uint> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
                // 0 data0 x0 y0 z0 w0 x1 y1 z1 w1 x2 y2 z2 w2 x3 y3 z3 w3 data1 x4 y4 z4 w4 x5 y5 z5 w5 x6 y6 z6 w6 x7 y7 z7 w7 data2 x8 y8 z8 w8 x9 y9 z9 w9 x10 y10 z10 w10 x11 y11 z11 w11 data3 x12 y12 z12 w12 x13 y13 z13 w13 x14 y14 z14 w14 x15 y15 z15 w15
                // 1 a_0 x0 z0 x1 z1 x2 z2 x3 z3 x4 z4 x5 z5 x6 z6 x7 z7 a_1 x8 z8 x9 z9 x10 z10 x11 z11 x12 z12 x13 z13 x14 z14 x15 z15 a_2 y0 w0 y1 w1 y2 w2 y3 w3 y4 w4 y5 w5 y6 w6 y7 w7 a_3 y8 w8 y9 w9 y10 w10 y11 w11 y12 w12 y13 w13 y14 w14 y15 w15
                a_0 = YGroup2Unzip(data0, data1, out a_2);
                a_1 = YGroup2Unzip(data2, data3, out a_3);
                // 2 b_0 x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 b_1 y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 b_2 z0 z1 z2 z3 z4 z5 z6 z7 z8 z9 z10 z11 z12 z13 z14 z15 b_3 w0 w1 w2 w3 w4 w5 w6 w7 w8 w9 w10 w11 w12 w13 w14 w15
                b_0 = YGroup2Unzip(a_0, a_1, out b_2);
                b_1 = YGroup2Unzip(a_2, a_3, out b_3);
                y = b_1;
                z = b_2;
                w = b_3;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{ExInt128}, Vector512{ExInt128}, Vector512{ExInt128}, Vector512{ExInt128}, out Vector512{ExInt128}, out Vector512{ExInt128}, out Vector512{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExInt128> YGroup4Unzip_Unzip(Vector512<ExInt128> data0, Vector512<ExInt128> data1, Vector512<ExInt128> data2, Vector512<ExInt128> data3, out Vector512<ExInt128> y, out Vector512<ExInt128> z, out Vector512<ExInt128> w) {
                var d0 = YGroup4Unzip_Unzip(data0.ExAsExUInt128(), data1.ExAsExUInt128(), data2.ExAsExUInt128(), data3.ExAsExUInt128(), out var d1, out var d2, out var d3);
                y = d1.ExAsExInt128();
                z = d2.ExAsExInt128();
                w = d3.ExAsExInt128();
                return d0.ExAsExInt128();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{ExUInt128}, Vector512{ExUInt128}, Vector512{ExUInt128}, Vector512{ExUInt128}, out Vector512{ExUInt128}, out Vector512{ExUInt128}, out Vector512{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExUInt128> YGroup4Unzip_Unzip(Vector512<ExUInt128> data0, Vector512<ExUInt128> data1, Vector512<ExUInt128> data2, Vector512<ExUInt128> data3, out Vector512<ExUInt128> y, out Vector512<ExUInt128> z, out Vector512<ExUInt128> w) {
                Vector512<ExUInt128> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
                // 0 data0 x0 y0 z0 w0 data1 x1 y1 z1 w1 data2 x2 y2 z2 w2 data3 x3 y3 z3 w3
                // 1 a_0 x0 x2 y0 y2 a_1 z0 z2 w0 w2 a_2 x1 x3 y1 y3 a_3 z1 z3 w1 w3
                a_0 = YGroup2Unzip(data0, data1, out a_2);
                a_1 = YGroup2Unzip(data2, data3, out a_3);
                // 2 b_0 x0 x1 x2 x3 b_1 y0 y1 y2 y3 b_2 z0 z1 z2 z3 b_3 w0 w1 w2 w3
                b_0 = YGroup2Unzip(a_0, a_1, out b_2);
                b_1 = YGroup2Unzip(a_2, a_3, out b_3);
                y = b_1;
                z = b_2;
                w = b_3;
                return b_0;
            }

#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup4Zip_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt = TypeCodeFlagsUtil.Most32Types;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }
            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup4Zip(Vector512<float> x, Vector512<float> y, Vector512<float> z, Vector512<float> w, out Vector512<float> data1, out Vector512<float> data2, out Vector512<float> data3) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup4Zip_Basic(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup4Zip(Vector512<double> x, Vector512<double> y, Vector512<double> z, Vector512<double> w, out Vector512<double> data1, out Vector512<double> data2, out Vector512<double> data3) {
                return YGroup4Zip_Basic(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup4Zip(Vector512<sbyte> x, Vector512<sbyte> y, Vector512<sbyte> z, Vector512<sbyte> w, out Vector512<sbyte> data1, out Vector512<sbyte> data2, out Vector512<sbyte> data3) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup4Zip_Basic(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup4Zip(Vector512<byte> x, Vector512<byte> y, Vector512<byte> z, Vector512<byte> w, out Vector512<byte> data1, out Vector512<byte> data2, out Vector512<byte> data3) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup4Zip_Basic(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup4Zip(Vector512<short> x, Vector512<short> y, Vector512<short> z, Vector512<short> w, out Vector512<short> data1, out Vector512<short> data2, out Vector512<short> data3) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup4Zip_Basic(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup4Zip(Vector512<ushort> x, Vector512<ushort> y, Vector512<ushort> z, Vector512<ushort> w, out Vector512<ushort> data1, out Vector512<ushort> data2, out Vector512<ushort> data3) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup4Zip_Basic(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup4Zip(Vector512<int> x, Vector512<int> y, Vector512<int> z, Vector512<int> w, out Vector512<int> data1, out Vector512<int> data2, out Vector512<int> data3) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup4Zip_Basic(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup4Zip(Vector512<uint> x, Vector512<uint> y, Vector512<uint> z, Vector512<uint> w, out Vector512<uint> data1, out Vector512<uint> data2, out Vector512<uint> data3) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup4Zip_Basic(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup4Zip(Vector512<long> x, Vector512<long> y, Vector512<long> z, Vector512<long> w, out Vector512<long> data1, out Vector512<long> data2, out Vector512<long> data3) {
                return YGroup4Zip_Basic(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup4Zip(Vector512<ulong> x, Vector512<ulong> y, Vector512<ulong> z, Vector512<ulong> w, out Vector512<ulong> data1, out Vector512<ulong> data2, out Vector512<ulong> data3) {
                return YGroup4Zip_Basic(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{ExInt128}, Vector512{ExInt128}, Vector512{ExInt128}, Vector512{ExInt128}, out Vector512{ExInt128}, out Vector512{ExInt128}, out Vector512{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExInt128> YGroup4Zip(Vector512<ExInt128> x, Vector512<ExInt128> y, Vector512<ExInt128> z, Vector512<ExInt128> w, out Vector512<ExInt128> data1, out Vector512<ExInt128> data2, out Vector512<ExInt128> data3) {
                return YGroup4Zip_Move(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{ExUInt128}, Vector512{ExUInt128}, Vector512{ExUInt128}, Vector512{ExUInt128}, out Vector512{ExUInt128}, out Vector512{ExUInt128}, out Vector512{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExUInt128> YGroup4Zip(Vector512<ExUInt128> x, Vector512<ExUInt128> y, Vector512<ExUInt128> z, Vector512<ExUInt128> w, out Vector512<ExUInt128> data1, out Vector512<ExUInt128> data2, out Vector512<ExUInt128> data3) {
                return YGroup4Zip_Move(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip_Bit128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<T> YGroup4Zip_Bit128<T>(Vector512<T> x, Vector512<T> y, Vector512<T> z, Vector512<T> w, out Vector512<T> data1, out Vector512<T> data2, out Vector512<T> data3) where T : struct {
#if EX_APPLY_GENERIC
                var d0 = YGroup4Zip_Move(x.ExAs<T, ExUInt128>(), y.ExAs<T, ExUInt128>(), z.ExAs<T, ExUInt128>(), w.ExAs<T, ExUInt128>(), out var d1, out var d2, out var d3);
                data1 = d1.ExAs<ExUInt128, T>();
                data2 = d2.ExAs<ExUInt128, T>();
                data3 = d3.ExAs<ExUInt128, T>();
                return d0.ExAs<ExUInt128, T>();
#else
                var a0 = x;
                var a1 = y;
                var a2 = z;
                var a3 = w;
                var a0l = a0.GetLower();
                var a0u = a0.GetUpper();
                var a1l = a1.GetLower();
                var a1u = a1.GetUpper();
                var a2l = a2.GetLower();
                var a2u = a2.GetUpper();
                var a3l = a3.GetLower();
                var a3u = a3.GetUpper();
                var c0 = a0l.WithUpper(a1l.GetLower()).ToVector512Unsafe().WithUpper(a2l.WithUpper(a3l.GetLower()));
                var c1 = a0l.GetUpper().ToVector256Unsafe().WithUpper(a1l.GetUpper()).ToVector512Unsafe().WithUpper(a2l.GetUpper().ToVector256Unsafe().WithUpper(a3l.GetUpper()));
                var c2 = a0u.WithUpper(a1u.GetLower()).ToVector512Unsafe().WithUpper(a2u.WithUpper(a3u.GetLower()));
                var c3 = a0u.GetUpper().ToVector256Unsafe().WithUpper(a1u.GetUpper()).ToVector512Unsafe().WithUpper(a2u.GetUpper().ToVector256Unsafe().WithUpper(a3u.GetUpper()));
                data1 = c1;
                data2 = c2;
                data3 = c3;
                return c0;
#endif // EX_APPLY_GENERIC
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup4Zip_Basic(Vector512<float> x, Vector512<float> y, Vector512<float> z, Vector512<float> w, out Vector512<float> data1, out Vector512<float> data2, out Vector512<float> data3) {
                var d0 = YGroup4Zip_Basic(x.AsUInt32(), y.AsUInt32(), z.AsUInt32(), w.AsUInt32(), out var d1, out var d2, out var d3);
                data1 = d1.AsSingle();
                data2 = d2.AsSingle();
                data3 = d3.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup4Zip_Basic(Vector512<double> x, Vector512<double> y, Vector512<double> z, Vector512<double> w, out Vector512<double> data1, out Vector512<double> data2, out Vector512<double> data3) {
                var d0 = YGroup4Zip_Basic(x.AsUInt64(), y.AsUInt64(), z.AsUInt64(), w.AsUInt64(), out var d1, out var d2, out var d3);
                data1 = d1.AsDouble();
                data2 = d2.AsDouble();
                data3 = d3.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup4Zip_Basic(Vector512<sbyte> x, Vector512<sbyte> y, Vector512<sbyte> z, Vector512<sbyte> w, out Vector512<sbyte> data1, out Vector512<sbyte> data2, out Vector512<sbyte> data3) {
                var d0 = YGroup4Zip_Basic(x.AsByte(), y.AsByte(), z.AsByte(), w.AsByte(), out var d1, out var d2, out var d3);
                data1 = d1.AsSByte();
                data2 = d2.AsSByte();
                data3 = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup4Zip_Basic(Vector512<byte> x, Vector512<byte> y, Vector512<byte> z, Vector512<byte> w, out Vector512<byte> data1, out Vector512<byte> data2, out Vector512<byte> data3) {
                Span<Vector512<byte>> rt = stackalloc Vector512<byte>[4];
                ref byte px = ref Unsafe.As<Vector512<byte>, byte>(ref x);
                ref byte py = ref Unsafe.As<Vector512<byte>, byte>(ref y);
                ref byte pz = ref Unsafe.As<Vector512<byte>, byte>(ref z);
                ref byte pw = ref Unsafe.As<Vector512<byte>, byte>(ref w);
                Span<byte> q = MemoryMarshal.Cast<Vector512<byte>, byte>(rt);
                int idx = 0;
                for (int i = 0; i < Vector512<byte>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    q[idx + 2] = Unsafe.Add(ref pz, i);
                    q[idx + 3] = Unsafe.Add(ref pw, i);
                    idx += 4;
                }
                data1 = rt[1];
                data2 = rt[2];
                data3 = rt[3];
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup4Zip_Basic(Vector512<short> x, Vector512<short> y, Vector512<short> z, Vector512<short> w, out Vector512<short> data1, out Vector512<short> data2, out Vector512<short> data3) {
                var d0 = YGroup4Zip_Basic(x.AsUInt16(), y.AsUInt16(), z.AsUInt16(), w.AsUInt16(), out var d1, out var d2, out var d3);
                data1 = d1.AsInt16();
                data2 = d2.AsInt16();
                data3 = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup4Zip_Basic(Vector512<ushort> x, Vector512<ushort> y, Vector512<ushort> z, Vector512<ushort> w, out Vector512<ushort> data1, out Vector512<ushort> data2, out Vector512<ushort> data3) {
                Span<Vector512<ushort>> rt = stackalloc Vector512<ushort>[4];
                ref ushort px = ref Unsafe.As<Vector512<ushort>, ushort>(ref x);
                ref ushort py = ref Unsafe.As<Vector512<ushort>, ushort>(ref y);
                ref ushort pz = ref Unsafe.As<Vector512<ushort>, ushort>(ref z);
                ref ushort pw = ref Unsafe.As<Vector512<ushort>, ushort>(ref w);
                Span<ushort> q = MemoryMarshal.Cast<Vector512<ushort>, ushort>(rt);
                int idx = 0;
                for (int i = 0; i < Vector512<ushort>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    q[idx + 2] = Unsafe.Add(ref pz, i);
                    q[idx + 3] = Unsafe.Add(ref pw, i);
                    idx += 4;
                }
                data1 = rt[1];
                data2 = rt[2];
                data3 = rt[3];
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup4Zip_Basic(Vector512<int> x, Vector512<int> y, Vector512<int> z, Vector512<int> w, out Vector512<int> data1, out Vector512<int> data2, out Vector512<int> data3) {
                var d0 = YGroup4Zip_Basic(x.AsUInt32(), y.AsUInt32(), z.AsUInt32(), w.AsUInt32(), out var d1, out var d2, out var d3);
                data1 = d1.AsInt32();
                data2 = d2.AsInt32();
                data3 = d3.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup4Zip_Basic(Vector512<uint> x, Vector512<uint> y, Vector512<uint> z, Vector512<uint> w, out Vector512<uint> data1, out Vector512<uint> data2, out Vector512<uint> data3) {
                Span<Vector512<uint>> rt = stackalloc Vector512<uint>[4];
                ref uint px = ref Unsafe.As<Vector512<uint>, uint>(ref x);
                ref uint py = ref Unsafe.As<Vector512<uint>, uint>(ref y);
                ref uint pz = ref Unsafe.As<Vector512<uint>, uint>(ref z);
                ref uint pw = ref Unsafe.As<Vector512<uint>, uint>(ref w);
                Span<uint> q = MemoryMarshal.Cast<Vector512<uint>, uint>(rt);
                int idx = 0;
                for (int i = 0; i < Vector512<uint>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    q[idx + 2] = Unsafe.Add(ref pz, i);
                    q[idx + 3] = Unsafe.Add(ref pw, i);
                    idx += 4;
                }
                data1 = rt[1];
                data2 = rt[2];
                data3 = rt[3];
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup4Zip_Basic(Vector512<long> x, Vector512<long> y, Vector512<long> z, Vector512<long> w, out Vector512<long> data1, out Vector512<long> data2, out Vector512<long> data3) {
                var d0 = YGroup4Zip_Basic(x.AsUInt64(), y.AsUInt64(), z.AsUInt64(), w.AsUInt64(), out var d1, out var d2, out var d3);
                data1 = d1.AsInt64();
                data2 = d2.AsInt64();
                data3 = d3.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup4Zip_Basic(Vector512<ulong> x, Vector512<ulong> y, Vector512<ulong> z, Vector512<ulong> w, out Vector512<ulong> data1, out Vector512<ulong> data2, out Vector512<ulong> data3) {
                Span<Vector512<ulong>> rt = stackalloc Vector512<ulong>[4];
                ref ulong px = ref Unsafe.As<Vector512<ulong>, ulong>(ref x);
                ref ulong py = ref Unsafe.As<Vector512<ulong>, ulong>(ref y);
                ref ulong pz = ref Unsafe.As<Vector512<ulong>, ulong>(ref z);
                ref ulong pw = ref Unsafe.As<Vector512<ulong>, ulong>(ref w);
                Span<ulong> q = MemoryMarshal.Cast<Vector512<ulong>, ulong>(rt);
                int idx = 0;
                for (int i = 0; i < Vector512<ulong>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    q[idx + 2] = Unsafe.Add(ref pz, i);
                    q[idx + 3] = Unsafe.Add(ref pw, i);
                    idx += 4;
                }
                data1 = rt[1];
                data2 = rt[2];
                data3 = rt[3];
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{ExInt128}, Vector512{ExInt128}, Vector512{ExInt128}, Vector512{ExInt128}, out Vector512{ExInt128}, out Vector512{ExInt128}, out Vector512{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExInt128> YGroup4Zip_Basic(Vector512<ExInt128> x, Vector512<ExInt128> y, Vector512<ExInt128> z, Vector512<ExInt128> w, out Vector512<ExInt128> data1, out Vector512<ExInt128> data2, out Vector512<ExInt128> data3) {
                var d0 = YGroup4Zip_Basic(x.ExAsExUInt128(), y.ExAsExUInt128(), z.ExAsExUInt128(), w.ExAsExUInt128(), out var d1, out var d2, out var d3);
                data1 = d1.ExAsExInt128();
                data2 = d2.ExAsExInt128();
                data3 = d3.ExAsExInt128();
                return d0.ExAsExInt128();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{ExUInt128}, Vector512{ExUInt128}, Vector512{ExUInt128}, Vector512{ExUInt128}, out Vector512{ExUInt128}, out Vector512{ExUInt128}, out Vector512{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExUInt128> YGroup4Zip_Basic(Vector512<ExUInt128> x, Vector512<ExUInt128> y, Vector512<ExUInt128> z, Vector512<ExUInt128> w, out Vector512<ExUInt128> data1, out Vector512<ExUInt128> data2, out Vector512<ExUInt128> data3) {
                Span<Vector512<ExUInt128>> rt = stackalloc Vector512<ExUInt128>[4];
                ref ExUInt128 px = ref Unsafe.As<Vector512<ExUInt128>, ExUInt128>(ref x);
                ref ExUInt128 py = ref Unsafe.As<Vector512<ExUInt128>, ExUInt128>(ref y);
                ref ExUInt128 pz = ref Unsafe.As<Vector512<ExUInt128>, ExUInt128>(ref z);
                ref ExUInt128 pw = ref Unsafe.As<Vector512<ExUInt128>, ExUInt128>(ref w);
                Span<ExUInt128> q = MemoryMarshal.Cast<Vector512<ExUInt128>, ExUInt128>(rt);
                int cnt = Vector512s<ExUInt128>.Count;
                int idx = 0;
                for (int i = 0; i < cnt; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    q[idx + 2] = Unsafe.Add(ref pz, i);
                    q[idx + 3] = Unsafe.Add(ref pw, i);
                    idx += 4;
                }
                data1 = rt[1];
                data2 = rt[2];
                data3 = rt[3];
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{ExInt128}, Vector512{ExInt128}, Vector512{ExInt128}, Vector512{ExInt128}, out Vector512{ExInt128}, out Vector512{ExInt128}, out Vector512{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExInt128> YGroup4Zip_Move(Vector512<ExInt128> x, Vector512<ExInt128> y, Vector512<ExInt128> z, Vector512<ExInt128> w, out Vector512<ExInt128> data1, out Vector512<ExInt128> data2, out Vector512<ExInt128> data3) {
                var d0 = YGroup4Zip_Move(x.ExAsExUInt128(), y.ExAsExUInt128(), z.ExAsExUInt128(), w.ExAsExUInt128(), out var d1, out var d2, out var d3);
                data1 = d1.ExAsExInt128();
                data2 = d2.ExAsExInt128();
                data3 = d3.ExAsExInt128();
                return d0.ExAsExInt128();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{ExUInt128}, Vector512{ExUInt128}, Vector512{ExUInt128}, Vector512{ExUInt128}, out Vector512{ExUInt128}, out Vector512{ExUInt128}, out Vector512{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExUInt128> YGroup4Zip_Move(Vector512<ExUInt128> x, Vector512<ExUInt128> y, Vector512<ExUInt128> z, Vector512<ExUInt128> w, out Vector512<ExUInt128> data1, out Vector512<ExUInt128> data2, out Vector512<ExUInt128> data3) {
                var a0 = x.ExAsUInt64();
                var a1 = y.ExAsUInt64();
                var a2 = z.ExAsUInt64();
                var a3 = w.ExAsUInt64();
                var a0l = a0.GetLower();
                var a0u = a0.GetUpper();
                var a1l = a1.GetLower();
                var a1u = a1.GetUpper();
                var a2l = a2.GetLower();
                var a2u = a2.GetUpper();
                var a3l = a3.GetLower();
                var a3u = a3.GetUpper();
                var c0 = a0l.WithUpper(a1l.GetLower()).ToVector512Unsafe().WithUpper(a2l.WithUpper(a3l.GetLower()));
                var c1 = a0l.GetUpper().ToVector256Unsafe().WithUpper(a1l.GetUpper()).ToVector512Unsafe().WithUpper(a2l.GetUpper().ToVector256Unsafe().WithUpper(a3l.GetUpper()));
                var c2 = a0u.WithUpper(a1u.GetLower()).ToVector512Unsafe().WithUpper(a2u.WithUpper(a3u.GetLower()));
                var c3 = a0u.GetUpper().ToVector256Unsafe().WithUpper(a1u.GetUpper()).ToVector512Unsafe().WithUpper(a2u.GetUpper().ToVector256Unsafe().WithUpper(a3u.GetUpper()));
                data1 = c1.ExAsExUInt128();
                data2 = c2.ExAsExUInt128();
                data3 = c3.ExAsExUInt128();
                return c0.ExAsExUInt128();
            }

#if VECTOR_HAS_METHOD

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup4Zip_Widen(Vector512<sbyte> x, Vector512<sbyte> y, Vector512<sbyte> z, Vector512<sbyte> w, out Vector512<sbyte> data1, out Vector512<sbyte> data2, out Vector512<sbyte> data3) {
                var d0 = YGroup4Zip_Widen(x.AsByte(), y.AsByte(), z.AsByte(), w.AsByte(), out var d1, out var d2, out var d3);
                data1 = d1.AsSByte();
                data2 = d2.AsSByte();
                data3 = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup4Zip_Widen(Vector512<byte> x, Vector512<byte> y, Vector512<byte> z, Vector512<byte> w, out Vector512<byte> data1, out Vector512<byte> data2, out Vector512<byte> data3) {
                const int L = 8;
                Vector512<byte> s0, s1, s2, s3;
                Vector512<ushort> t0, t1;
                Vector512<uint> r0, r1, r2, r3, d0, d1, d2, d3;
                if (BitConverter.IsLittleEndian) {
                    s0 = w;
                    s1 = z;
                    s2 = y;
                    s3 = x;
                } else {
                    s0 = x;
                    s1 = y;
                    s2 = z;
                    s3 = w;
                }
                // Part 0
                (t0, t1) = Vector512.Widen(s0);
                (r0, r1) = Vector512.Widen(t0);
                (r2, r3) = Vector512.Widen(t1);
                d0 = Vector512.ShiftLeft(r0, L);
                d1 = Vector512.ShiftLeft(r1, L);
                d2 = Vector512.ShiftLeft(r2, L);
                d3 = Vector512.ShiftLeft(r3, L);
                // Part 1
                (t0, t1) = Vector512.Widen(s1);
                (r0, r1) = Vector512.Widen(t0);
                (r2, r3) = Vector512.Widen(t1);
                d0 = Vector512.BitwiseOr(d0, r0);
                d1 = Vector512.BitwiseOr(d1, r1);
                d2 = Vector512.BitwiseOr(d2, r2);
                d3 = Vector512.BitwiseOr(d3, r3);
                d0 = Vector512.ShiftLeft(d0, L);
                d1 = Vector512.ShiftLeft(d1, L);
                d2 = Vector512.ShiftLeft(d2, L);
                d3 = Vector512.ShiftLeft(d3, L);
                // Part 2
                (t0, t1) = Vector512.Widen(s2);
                (r0, r1) = Vector512.Widen(t0);
                (r2, r3) = Vector512.Widen(t1);
                d0 = Vector512.BitwiseOr(d0, r0);
                d1 = Vector512.BitwiseOr(d1, r1);
                d2 = Vector512.BitwiseOr(d2, r2);
                d3 = Vector512.BitwiseOr(d3, r3);
                d0 = Vector512.ShiftLeft(d0, L);
                d1 = Vector512.ShiftLeft(d1, L);
                d2 = Vector512.ShiftLeft(d2, L);
                d3 = Vector512.ShiftLeft(d3, L);
                // Part 3
                (t0, t1) = Vector512.Widen(s3);
                (r0, r1) = Vector512.Widen(t0);
                (r2, r3) = Vector512.Widen(t1);
                d0 = Vector512.BitwiseOr(d0, r0);
                d1 = Vector512.BitwiseOr(d1, r1);
                d2 = Vector512.BitwiseOr(d2, r2);
                d3 = Vector512.BitwiseOr(d3, r3);
                // done.
                data1 = d1.AsByte();
                data2 = d2.AsByte();
                data3 = d3.AsByte();
                return d0.AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup4Zip_Widen(Vector512<short> x, Vector512<short> y, Vector512<short> z, Vector512<short> w, out Vector512<short> data1, out Vector512<short> data2, out Vector512<short> data3) {
                var d0 = YGroup4Zip_Widen(x.AsUInt16(), y.AsUInt16(), z.AsUInt16(), w.AsUInt16(), out var d1, out var d2, out var d3);
                data1 = d1.AsInt16();
                data2 = d2.AsInt16();
                data3 = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup4Zip_Widen(Vector512<ushort> x, Vector512<ushort> y, Vector512<ushort> z, Vector512<ushort> w, out Vector512<ushort> data1, out Vector512<ushort> data2, out Vector512<ushort> data3) {
                const int L = 16;
                Vector512<ushort> s0, s1, s2, s3;
                Vector512<uint> t0, t1;
                Vector512<ulong> r0, r1, r2, r3, d0, d1, d2, d3;
                if (BitConverter.IsLittleEndian) {
                    s0 = w;
                    s1 = z;
                    s2 = y;
                    s3 = x;
                } else {
                    s0 = x;
                    s1 = y;
                    s2 = z;
                    s3 = w;
                }
                // Part 0
                (t0, t1) = Vector512.Widen(s0);
                (r0, r1) = Vector512.Widen(t0);
                (r2, r3) = Vector512.Widen(t1);
                d0 = Vector512.ShiftLeft(r0, L);
                d1 = Vector512.ShiftLeft(r1, L);
                d2 = Vector512.ShiftLeft(r2, L);
                d3 = Vector512.ShiftLeft(r3, L);
                // Part 1
                (t0, t1) = Vector512.Widen(s1);
                (r0, r1) = Vector512.Widen(t0);
                (r2, r3) = Vector512.Widen(t1);
                d0 = Vector512.BitwiseOr(d0, r0);
                d1 = Vector512.BitwiseOr(d1, r1);
                d2 = Vector512.BitwiseOr(d2, r2);
                d3 = Vector512.BitwiseOr(d3, r3);
                d0 = Vector512.ShiftLeft(d0, L);
                d1 = Vector512.ShiftLeft(d1, L);
                d2 = Vector512.ShiftLeft(d2, L);
                d3 = Vector512.ShiftLeft(d3, L);
                // Part 2
                (t0, t1) = Vector512.Widen(s2);
                (r0, r1) = Vector512.Widen(t0);
                (r2, r3) = Vector512.Widen(t1);
                d0 = Vector512.BitwiseOr(d0, r0);
                d1 = Vector512.BitwiseOr(d1, r1);
                d2 = Vector512.BitwiseOr(d2, r2);
                d3 = Vector512.BitwiseOr(d3, r3);
                d0 = Vector512.ShiftLeft(d0, L);
                d1 = Vector512.ShiftLeft(d1, L);
                d2 = Vector512.ShiftLeft(d2, L);
                d3 = Vector512.ShiftLeft(d3, L);
                // Part 3
                (t0, t1) = Vector512.Widen(s3);
                (r0, r1) = Vector512.Widen(t0);
                (r2, r3) = Vector512.Widen(t1);
                d0 = Vector512.BitwiseOr(d0, r0);
                d1 = Vector512.BitwiseOr(d1, r1);
                d2 = Vector512.BitwiseOr(d2, r2);
                d3 = Vector512.BitwiseOr(d3, r3);
                // done.
                data1 = d1.AsUInt16();
                data2 = d2.AsUInt16();
                data3 = d3.AsUInt16();
                return d0.AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup4Zip_Zip(Vector512<float> x, Vector512<float> y, Vector512<float> z, Vector512<float> w, out Vector512<float> data1, out Vector512<float> data2, out Vector512<float> data3) {
                var d0 = YGroup4Zip_Zip(x.AsUInt32(), y.AsUInt32(), z.AsUInt32(), w.AsUInt32(), out var d1, out var d2, out var d3);
                data1 = d1.AsSingle();
                data2 = d2.AsSingle();
                data3 = d3.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup4Zip_Zip(Vector512<sbyte> x, Vector512<sbyte> y, Vector512<sbyte> z, Vector512<sbyte> w, out Vector512<sbyte> data1, out Vector512<sbyte> data2, out Vector512<sbyte> data3) {
                var d0 = YGroup4Zip_Zip(x.AsByte(), y.AsByte(), z.AsByte(), w.AsByte(), out var d1, out var d2, out var d3);
                data1 = d1.AsSByte();
                data2 = d2.AsSByte();
                data3 = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup4Zip_Zip(Vector512<byte> x, Vector512<byte> y, Vector512<byte> z, Vector512<byte> w, out Vector512<byte> data1, out Vector512<byte> data2, out Vector512<byte> data3) {
                Vector512<byte> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
                // 0 _x_ x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 x16 x17 x18 x19 x20 x21 x22 x23 x24 x25 x26 x27 x28 x29 x30 x31 x32 x33 x34 x35 x36 x37 x38 x39 x40 x41 x42 x43 x44 x45 x46 x47 x48 x49 x50 x51 x52 x53 x54 x55 x56 x57 x58 x59 x60 x61 x62 x63 _y_ y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 y16 y17 y18 y19 y20 y21 y22 y23 y24 y25 y26 y27 y28 y29 y30 y31 y32 y33 y34 y35 y36 y37 y38 y39 y40 y41 y42 y43 y44 y45 y46 y47 y48 y49 y50 y51 y52 y53 y54 y55 y56 y57 y58 y59 y60 y61 y62 y63 _z_ z0 z1 z2 z3 z4 z5 z6 z7 z8 z9 z10 z11 z12 z13 z14 z15 z16 z17 z18 z19 z20 z21 z22 z23 z24 z25 z26 z27 z28 z29 z30 z31 z32 z33 z34 z35 z36 z37 z38 z39 z40 z41 z42 z43 z44 z45 z46 z47 z48 z49 z50 z51 z52 z53 z54 z55 z56 z57 z58 z59 z60 z61 z62 z63 _w_ w0 w1 w2 w3 w4 w5 w6 w7 w8 w9 w10 w11 w12 w13 w14 w15 w16 w17 w18 w19 w20 w21 w22 w23 w24 w25 w26 w27 w28 w29 w30 w31 w32 w33 w34 w35 w36 w37 w38 w39 w40 w41 w42 w43 w44 w45 w46 w47 w48 w49 w50 w51 w52 w53 w54 w55 w56 w57 w58 w59 w60 w61 w62 w63
                // 1 a_0 x0 z0 x1 z1 x2 z2 x3 z3 x4 z4 x5 z5 x6 z6 x7 z7 x8 z8 x9 z9 x10 z10 x11 z11 x12 z12 x13 z13 x14 z14 x15 z15 x16 z16 x17 z17 x18 z18 x19 z19 x20 z20 x21 z21 x22 z22 x23 z23 x24 z24 x25 z25 x26 z26 x27 z27 x28 z28 x29 z29 x30 z30 x31 z31 a_1 x32 z32 x33 z33 x34 z34 x35 z35 x36 z36 x37 z37 x38 z38 x39 z39 x40 z40 x41 z41 x42 z42 x43 z43 x44 z44 x45 z45 x46 z46 x47 z47 x48 z48 x49 z49 x50 z50 x51 z51 x52 z52 x53 z53 x54 z54 x55 z55 x56 z56 x57 z57 x58 z58 x59 z59 x60 z60 x61 z61 x62 z62 x63 z63 a_2 y0 w0 y1 w1 y2 w2 y3 w3 y4 w4 y5 w5 y6 w6 y7 w7 y8 w8 y9 w9 y10 w10 y11 w11 y12 w12 y13 w13 y14 w14 y15 w15 y16 w16 y17 w17 y18 w18 y19 w19 y20 w20 y21 w21 y22 w22 y23 w23 y24 w24 y25 w25 y26 w26 y27 w27 y28 w28 y29 w29 y30 w30 y31 w31 a_3 y32 w32 y33 w33 y34 w34 y35 w35 y36 w36 y37 w37 y38 w38 y39 w39 y40 w40 y41 w41 y42 w42 y43 w43 y44 w44 y45 w45 y46 w46 y47 w47 y48 w48 y49 w49 y50 w50 y51 w51 y52 w52 y53 w53 y54 w54 y55 w55 y56 w56 y57 w57 y58 w58 y59 w59 y60 w60 y61 w61 y62 w62 y63 w63
                a_0 = YGroup2Zip(x, z, out a_1);
                a_2 = YGroup2Zip(y, w, out a_3);
                // 2 b_0 x0 y0 z0 w0 x1 y1 z1 w1 x2 y2 z2 w2 x3 y3 z3 w3 x4 y4 z4 w4 x5 y5 z5 w5 x6 y6 z6 w6 x7 y7 z7 w7 x8 y8 z8 w8 x9 y9 z9 w9 x10 y10 z10 w10 x11 y11 z11 w11 x12 y12 z12 w12 x13 y13 z13 w13 x14 y14 z14 w14 x15 y15 z15 w15 b_1 x16 y16 z16 w16 x17 y17 z17 w17 x18 y18 z18 w18 x19 y19 z19 w19 x20 y20 z20 w20 x21 y21 z21 w21 x22 y22 z22 w22 x23 y23 z23 w23 x24 y24 z24 w24 x25 y25 z25 w25 x26 y26 z26 w26 x27 y27 z27 w27 x28 y28 z28 w28 x29 y29 z29 w29 x30 y30 z30 w30 x31 y31 z31 w31 b_2 x32 y32 z32 w32 x33 y33 z33 w33 x34 y34 z34 w34 x35 y35 z35 w35 x36 y36 z36 w36 x37 y37 z37 w37 x38 y38 z38 w38 x39 y39 z39 w39 x40 y40 z40 w40 x41 y41 z41 w41 x42 y42 z42 w42 x43 y43 z43 w43 x44 y44 z44 w44 x45 y45 z45 w45 x46 y46 z46 w46 x47 y47 z47 w47 b_3 x48 y48 z48 w48 x49 y49 z49 w49 x50 y50 z50 w50 x51 y51 z51 w51 x52 y52 z52 w52 x53 y53 z53 w53 x54 y54 z54 w54 x55 y55 z55 w55 x56 y56 z56 w56 x57 y57 z57 w57 x58 y58 z58 w58 x59 y59 z59 w59 x60 y60 z60 w60 x61 y61 z61 w61 x62 y62 z62 w62 x63 y63 z63 w63
                b_0 = YGroup2Zip(a_0, a_2, out b_1);
                b_2 = YGroup2Zip(a_1, a_3, out b_3);
                data1 = b_1;
                data2 = b_2;
                data3 = b_3;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup4Zip_Zip(Vector512<short> x, Vector512<short> y, Vector512<short> z, Vector512<short> w, out Vector512<short> data1, out Vector512<short> data2, out Vector512<short> data3) {
                var d0 = YGroup4Zip_Zip(x.AsUInt16(), y.AsUInt16(), z.AsUInt16(), w.AsUInt16(), out var d1, out var d2, out var d3);
                data1 = d1.AsInt16();
                data2 = d2.AsInt16();
                data3 = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup4Zip_Zip(Vector512<ushort> x, Vector512<ushort> y, Vector512<ushort> z, Vector512<ushort> w, out Vector512<ushort> data1, out Vector512<ushort> data2, out Vector512<ushort> data3) {
                Vector512<ushort> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
                // 0 _x_ x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 x16 x17 x18 x19 x20 x21 x22 x23 x24 x25 x26 x27 x28 x29 x30 x31 _y_ y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 y16 y17 y18 y19 y20 y21 y22 y23 y24 y25 y26 y27 y28 y29 y30 y31 _z_ z0 z1 z2 z3 z4 z5 z6 z7 z8 z9 z10 z11 z12 z13 z14 z15 z16 z17 z18 z19 z20 z21 z22 z23 z24 z25 z26 z27 z28 z29 z30 z31 _w_ w0 w1 w2 w3 w4 w5 w6 w7 w8 w9 w10 w11 w12 w13 w14 w15 w16 w17 w18 w19 w20 w21 w22 w23 w24 w25 w26 w27 w28 w29 w30 w31
                // 1 b_0 x0 z0 x1 z1 x2 z2 x3 z3 x4 z4 x5 z5 x6 z6 x7 z7 x8 z8 x9 z9 x10 z10 x11 z11 x12 z12 x13 z13 x14 z14 x15 z15 b_1 x16 z16 x17 z17 x18 z18 x19 z19 x20 z20 x21 z21 x22 z22 x23 z23 x24 z24 x25 z25 x26 z26 x27 z27 x28 z28 x29 z29 x30 z30 x31 z31 b_2 y0 w0 y1 w1 y2 w2 y3 w3 y4 w4 y5 w5 y6 w6 y7 w7 y8 w8 y9 w9 y10 w10 y11 w11 y12 w12 y13 w13 y14 w14 y15 w15 b_3 y16 w16 y17 w17 y18 w18 y19 w19 y20 w20 y21 w21 y22 w22 y23 w23 y24 w24 y25 w25 y26 w26 y27 w27 y28 w28 y29 w29 y30 w30 y31 w31
                a_0 = YGroup2Zip(x, z, out a_1);
                a_2 = YGroup2Zip(y, w, out a_3);
                // 2 a_0 x0 y0 z0 w0 x1 y1 z1 w1 x2 y2 z2 w2 x3 y3 z3 w3 x4 y4 z4 w4 x5 y5 z5 w5 x6 y6 z6 w6 x7 y7 z7 w7 a_1 x8 y8 z8 w8 x9 y9 z9 w9 x10 y10 z10 w10 x11 y11 z11 w11 x12 y12 z12 w12 x13 y13 z13 w13 x14 y14 z14 w14 x15 y15 z15 w15 a_2 x16 y16 z16 w16 x17 y17 z17 w17 x18 y18 z18 w18 x19 y19 z19 w19 x20 y20 z20 w20 x21 y21 z21 w21 x22 y22 z22 w22 x23 y23 z23 w23 a_3 x24 y24 z24 w24 x25 y25 z25 w25 x26 y26 z26 w26 x27 y27 z27 w27 x28 y28 z28 w28 x29 y29 z29 w29 x30 y30 z30 w30 x31 y31 z31 w31
                b_0 = YGroup2Zip(a_0, a_2, out b_1);
                b_2 = YGroup2Zip(a_1, a_3, out b_3);
                data1 = b_1;
                data2 = b_2;
                data3 = b_3;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup4Zip_Zip(Vector512<int> x, Vector512<int> y, Vector512<int> z, Vector512<int> w, out Vector512<int> data1, out Vector512<int> data2, out Vector512<int> data3) {
                var d0 = YGroup4Zip_Zip(x.AsUInt32(), y.AsUInt32(), z.AsUInt32(), w.AsUInt32(), out var d1, out var d2, out var d3);
                data1 = d1.AsInt32();
                data2 = d2.AsInt32();
                data3 = d3.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup4Zip_Zip(Vector512<uint> x, Vector512<uint> y, Vector512<uint> z, Vector512<uint> w, out Vector512<uint> data1, out Vector512<uint> data2, out Vector512<uint> data3) {
                Vector512<uint> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
                // 0 _x_ x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 _y_ y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 _z_ z0 z1 z2 z3 z4 z5 z6 z7 z8 z9 z10 z11 z12 z13 z14 z15 _w_ w0 w1 w2 w3 w4 w5 w6 w7 w8 w9 w10 w11 w12 w13 w14 w15
                // 1 a_0 x0 z0 x1 z1 x2 z2 x3 z3 x4 z4 x5 z5 x6 z6 x7 z7 a_1 x8 z8 x9 z9 x10 z10 x11 z11 x12 z12 x13 z13 x14 z14 x15 z15 a_2 y0 w0 y1 w1 y2 w2 y3 w3 y4 w4 y5 w5 y6 w6 y7 w7 a_3 y8 w8 y9 w9 y10 w10 y11 w11 y12 w12 y13 w13 y14 w14 y15 w15
                a_0 = YGroup2Zip(x, z, out a_1);
                a_2 = YGroup2Zip(y, w, out a_3);
                // 2 b_0 x0 y0 z0 w0 x1 y1 z1 w1 x2 y2 z2 w2 x3 y3 z3 w3 b_1 x4 y4 z4 w4 x5 y5 z5 w5 x6 y6 z6 w6 x7 y7 z7 w7 b_2 x8 y8 z8 w8 x9 y9 z9 w9 x10 y10 z10 w10 x11 y11 z11 w11 b_3 x12 y12 z12 w12 x13 y13 z13 w13 x14 y14 z14 w14 x15 y15 z15 w15
                b_0 = YGroup2Zip(a_0, a_2, out b_1);
                b_2 = YGroup2Zip(a_1, a_3, out b_3);
                data1 = b_1;
                data2 = b_2;
                data3 = b_3;
                return b_0;
            }

#endif // VECTOR_HAS_METHOD

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{ExInt128}, Vector512{ExInt128}, Vector512{ExInt128}, Vector512{ExInt128}, out Vector512{ExInt128}, out Vector512{ExInt128}, out Vector512{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExInt128> YGroup4Zip_Zip(Vector512<ExInt128> x, Vector512<ExInt128> y, Vector512<ExInt128> z, Vector512<ExInt128> w, out Vector512<ExInt128> data1, out Vector512<ExInt128> data2, out Vector512<ExInt128> data3) {
                var d0 = YGroup4Zip_Zip(x.ExAsExUInt128(), y.ExAsExUInt128(), z.ExAsExUInt128(), w.ExAsExUInt128(), out var d1, out var d2, out var d3);
                data1 = d1.ExAsExInt128();
                data2 = d2.ExAsExInt128();
                data3 = d3.ExAsExInt128();
                return d0.ExAsExInt128();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{ExUInt128}, Vector512{ExUInt128}, Vector512{ExUInt128}, Vector512{ExUInt128}, out Vector512{ExUInt128}, out Vector512{ExUInt128}, out Vector512{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExUInt128> YGroup4Zip_Zip(Vector512<ExUInt128> x, Vector512<ExUInt128> y, Vector512<ExUInt128> z, Vector512<ExUInt128> w, out Vector512<ExUInt128> data1, out Vector512<ExUInt128> data2, out Vector512<ExUInt128> data3) {
                Vector512<ExUInt128> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
                // 0 _x_ x0 x1 x2 x3 _y_ y0 y1 y2 y3 _z_ z0 z1 z2 z3 _w_ w0 w1 w2 w3
                // 1 a_0 x0 z0 x1 z1 a_1 x2 z2 x3 z3 a_2 y0 w0 y1 w1 a_3 y2 w2 y3 w3
                a_0 = YGroup2Zip(x, z, out a_1);
                a_2 = YGroup2Zip(y, w, out a_3);
                // 2 b_0 x0 y0 z0 w0 b_1 x1 y1 z1 w1 b_2 x2 y2 z2 w2 b_3 x3 y3 z3 w3
                b_0 = YGroup2Zip(a_0, a_2, out b_1);
                b_2 = YGroup2Zip(a_1, a_3, out b_3);
                data1 = b_1;
                data2 = b_2;
                data3 = b_3;
                return b_0;
            }


            /// <inheritdoc cref="IWVectorTraits512.YGroup6Unzip_Bit128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<T> YGroup6Unzip_Bit128<T>(Vector512<T> data0, Vector512<T> data1, Vector512<T> data2, Vector512<T> data3, Vector512<T> data4, Vector512<T> data5, out Vector512<T> y, out Vector512<T> z, out Vector512<T> w, out Vector512<T> u, out Vector512<T> v) where T : struct {
                Vector512<T> a_0, a_1, a_2, a_3, a_4, a_5, b_0, b_1, b_2, b_3, b_4, b_5;
                // 0 data0 x0 y0 z0 w0 data1 u0 v0 x1 y1 data2 z1 w1 u1 v1 data3 x2 y2 z2 w2 data4 u2 v2 x3 y3 data5 z3 w3 u3 v3
                // 1 a_0 x0 x2 y0 y2 a_1 z0 z2 w0 w2 a_2 u0 u2 v0 v2 a_3 x1 x3 y1 y3 a_4 z1 z3 w1 w3 a_5 u1 u3 v1 v3
                a_0 = YGroup2Zip_Bit128(data0, data3, out a_1);
                a_2 = YGroup2Zip_Bit128(data1, data4, out a_3);
                a_4 = YGroup2Zip_Bit128(data2, data5, out a_5);
                // 2 b_0 x0 x1 x2 x3 b_1 y0 y1 y2 y3 b_2 z0 z1 z2 z3 b_3 w0 w1 w2 w3 b_4 u0 u1 u2 u3 b_5 v0 v1 v2 v3
                b_0 = YGroup2Zip_Bit128(a_0, a_3, out b_1);
                b_2 = YGroup2Zip_Bit128(a_1, a_4, out b_3);
                b_4 = YGroup2Zip_Bit128(a_2, a_5, out b_5);
                y = b_1;
                z = b_2;
                w = b_3;
                u = b_4;
                v = b_5;
                return b_0;
            }


            /// <inheritdoc cref="IWVectorTraits512.YGroup6Zip_Bit128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<T> YGroup6Zip_Bit128<T>(Vector512<T> x, Vector512<T> y, Vector512<T> z, Vector512<T> w, Vector512<T> u, Vector512<T> v, out Vector512<T> data1, out Vector512<T> data2, out Vector512<T> data3, out Vector512<T> data4, out Vector512<T> data5) where T : struct {
                Vector512<T> a_0, a_1, a_2, a_3, a_4, a_5, b_0, b_1, b_2, b_3, b_4, b_5;
                // 0 _x_ x0 x1 x2 x3 _y_ y0 y1 y2 y3 _z_ z0 z1 z2 z3 _w_ w0 w1 w2 w3 _u_ u0 u1 u2 u3 _v_ v0 v1 v2 v3
                // 1 a_0 x0 x2 y0 y2 a_1 z0 z2 w0 w2 a_2 u0 u2 v0 v2 a_3 x1 x3 y1 y3 a_4 z1 z3 w1 w3 a_5 u1 u3 v1 v3
                a_0 = YGroup2Unzip_Bit128(x, y, out a_3);
                a_1 = YGroup2Unzip_Bit128(z, w, out a_4);
                a_2 = YGroup2Unzip_Bit128(u, v, out a_5);
                // 2 b_0 x0 y0 z0 w0 b_1 u0 v0 x1 y1 b_2 z1 w1 u1 v1 b_3 x2 y2 z2 w2 b_4 u2 v2 x3 y3 b_5 z3 w3 u3 v3
                b_0 = YGroup2Unzip_Bit128(a_0, a_1, out b_3);
                b_1 = YGroup2Unzip_Bit128(a_2, a_3, out b_4);
                b_2 = YGroup2Unzip_Bit128(a_4, a_5, out b_5);
                data1 = b_1;
                data2 = b_2;
                data3 = b_3;
                data4 = b_4;
                data5 = b_5;
                return b_0;
            }

#endif // NET8_0_OR_GREATER
        }
    }
}
