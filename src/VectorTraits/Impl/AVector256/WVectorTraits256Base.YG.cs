﻿#if NET7_0_OR_GREATER
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
using Zyl.VectorTraits.Impl.AVector128;
using Zyl.VectorTraits.Impl.Util;

namespace Zyl.VectorTraits.Impl.AVector256 {
    using ShorterStatics = WVectorTraits128Base.Statics;

    partial class WVectorTraits256Base {

        partial class Statics {

#if NETCOREAPP3_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup3_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup1ToGroup3_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt = TypeCodeFlags.Byte | TypeCodeFlags.SByte;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup3(Vector256{float}, out Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup1ToGroup3(Vector256<float> x, out Vector256<float> result1, out Vector256<float> result2) {
                var d0 = YGroup1ToGroup3(x.AsUInt32(), out var d1, out var d2);
                result1 = d1.AsSingle();
                result2 = d2.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup3(Vector256{double}, out Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup1ToGroup3(Vector256<double> x, out Vector256<double> result1, out Vector256<double> result2) {
                var d0 = YGroup1ToGroup3(x.AsUInt64(), out var d1, out var d2);
                result1 = d1.AsDouble();
                result2 = d2.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup3(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup1ToGroup3(Vector256<sbyte> x, out Vector256<sbyte> result1, out Vector256<sbyte> result2) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup1ToGroup3_Zip(x, out result1, out result2);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup1ToGroup3_Basic(x, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup3(Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup1ToGroup3(Vector256<byte> x, out Vector256<byte> result1, out Vector256<byte> result2) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup1ToGroup3_Zip(x, out result1, out result2);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup1ToGroup3_Basic(x, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup3(Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup1ToGroup3(Vector256<short> x, out Vector256<short> result1, out Vector256<short> result2) {
                return YGroup1ToGroup3_Basic(x, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup3(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup1ToGroup3(Vector256<ushort> x, out Vector256<ushort> result1, out Vector256<ushort> result2) {
                return YGroup1ToGroup3_Basic(x, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup3(Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup1ToGroup3(Vector256<int> x, out Vector256<int> result1, out Vector256<int> result2) {
                return YGroup1ToGroup3_Basic(x, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup3(Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup1ToGroup3(Vector256<uint> x, out Vector256<uint> result1, out Vector256<uint> result2) {
                return YGroup1ToGroup3_Basic(x, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup3(Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup1ToGroup3(Vector256<long> x, out Vector256<long> result1, out Vector256<long> result2) {
                return YGroup1ToGroup3_Basic(x, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup3(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup1ToGroup3(Vector256<ulong> x, out Vector256<ulong> result1, out Vector256<ulong> result2) {
                return YGroup1ToGroup3_Basic(x, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup3(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup1ToGroup3_Basic(Vector256<sbyte> x, out Vector256<sbyte> result1, out Vector256<sbyte> result2) {
                var d0 = YGroup1ToGroup3_Basic(x.AsByte(), out var d1, out var d2);
                result1 = d1.AsSByte();
                result2 = d2.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup3(Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup1ToGroup3_Basic(Vector256<byte> x, out Vector256<byte> result1, out Vector256<byte> result2) {
                Span<Vector256<byte>> src = [x];
                Span<Vector256<byte>> dst = stackalloc Vector256<byte>[3];
                Span<byte> p = MemoryMarshal.Cast<Vector256<byte>, byte>(src);
                Span<byte> q = MemoryMarshal.Cast<Vector256<byte>, byte>(dst);
                for (int i = 0; i < Vector256<byte>.Count; ++i) {
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup3(Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup1ToGroup3_Basic(Vector256<short> x, out Vector256<short> result1, out Vector256<short> result2) {
                var d0 = YGroup1ToGroup3_Basic(x.AsUInt16(), out var d1, out var d2);
                result1 = d1.AsInt16();
                result2 = d2.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup3(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup1ToGroup3_Basic(Vector256<ushort> x, out Vector256<ushort> result1, out Vector256<ushort> result2) {
                Span<Vector256<ushort>> src = [x];
                Span<Vector256<ushort>> dst = stackalloc Vector256<ushort>[3];
                Span<ushort> p = MemoryMarshal.Cast<Vector256<ushort>, ushort>(src);
                Span<ushort> q = MemoryMarshal.Cast<Vector256<ushort>, ushort>(dst);
                for (int i = 0; i < Vector256<ushort>.Count; ++i) {
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup3(Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup1ToGroup3_Basic(Vector256<int> x, out Vector256<int> result1, out Vector256<int> result2) {
                var d0 = YGroup1ToGroup3_Basic(x.AsUInt32(), out var d1, out var d2);
                result1 = d1.AsInt32();
                result2 = d2.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup3(Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup1ToGroup3_Basic(Vector256<uint> x, out Vector256<uint> result1, out Vector256<uint> result2) {
                Span<Vector256<uint>> src = [x];
                Span<Vector256<uint>> dst = stackalloc Vector256<uint>[3];
                Span<uint> p = MemoryMarshal.Cast<Vector256<uint>, uint>(src);
                Span<uint> q = MemoryMarshal.Cast<Vector256<uint>, uint>(dst);
                for (int i = 0; i < Vector256<uint>.Count; ++i) {
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup3(Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup1ToGroup3_Basic(Vector256<long> x, out Vector256<long> result1, out Vector256<long> result2) {
                var d0 = YGroup1ToGroup3_Basic(x.AsUInt64(), out var d1, out var d2);
                result1 = d1.AsInt64();
                result2 = d2.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup3(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup1ToGroup3_Basic(Vector256<ulong> x, out Vector256<ulong> result1, out Vector256<ulong> result2) {
                Span<Vector256<ulong>> src = [x];
                Span<Vector256<ulong>> dst = stackalloc Vector256<ulong>[3];
                Span<ulong> p = MemoryMarshal.Cast<Vector256<ulong>, ulong>(src);
                Span<ulong> q = MemoryMarshal.Cast<Vector256<ulong>, ulong>(dst);
                for (int i = 0; i < Vector256<ulong>.Count; ++i) {
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup3(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup1ToGroup3_Shuffle(Vector256<sbyte> x, out Vector256<sbyte> result1, out Vector256<sbyte> result2) {
                var d0 = YGroup1ToGroup3_Shuffle(x.AsByte(), out var d1, out var d2);
                result1 = d1.AsSByte();
                result2 = d2.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup3(Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup1ToGroup3_Shuffle(Vector256<byte> x, out Vector256<byte> result1, out Vector256<byte> result2) {
                var f0 = Vector256Constants.YGroup1ToGroup3_Shuffle_Byte_0;
                var f1 = Vector256Constants.YGroup1ToGroup3_Shuffle_Byte_1;
                var f2 = Vector256Constants.YGroup1ToGroup3_Shuffle_Byte_2;
                var a_0 = Vector256.Shuffle(x, f0);
                var a_1 = Vector256.Shuffle(x, f1);
                var a_2 = Vector256.Shuffle(x, f2);
                result1 = a_1;
                result2 = a_2;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup3(Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup1ToGroup3_Shuffle(Vector256<short> x, out Vector256<short> result1, out Vector256<short> result2) {
                var d0 = YGroup1ToGroup3_Shuffle(x.AsUInt16(), out var d1, out var d2);
                result1 = d1.AsInt16();
                result2 = d2.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup3(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup1ToGroup3_Shuffle(Vector256<ushort> x, out Vector256<ushort> result1, out Vector256<ushort> result2) {
                var f0 = Vector256Constants.YGroup1ToGroup3_ShuffleOnByte_UInt16_0;
                var f1 = Vector256Constants.YGroup1ToGroup3_ShuffleOnByte_UInt16_1;
                var f2 = Vector256Constants.YGroup1ToGroup3_ShuffleOnByte_UInt16_2;
                var s0 = x.AsByte();
                var a_0 = Vector256.Shuffle(s0, f0).AsUInt16();
                var a_1 = Vector256.Shuffle(s0, f1).AsUInt16();
                var a_2 = Vector256.Shuffle(s0, f2).AsUInt16();
                result1 = a_1;
                result2 = a_2;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup3(Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup1ToGroup3_Shuffle(Vector256<int> x, out Vector256<int> result1, out Vector256<int> result2) {
                var d0 = YGroup1ToGroup3_Shuffle(x.AsUInt32(), out var d1, out var d2);
                result1 = d1.AsInt32();
                result2 = d2.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup3(Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup1ToGroup3_Shuffle(Vector256<uint> x, out Vector256<uint> result1, out Vector256<uint> result2) {
                var f0 = Vector256Constants.YGroup1ToGroup3_ShuffleOnByte_UInt32_0;
                var f1 = Vector256Constants.YGroup1ToGroup3_ShuffleOnByte_UInt32_1;
                var f2 = Vector256Constants.YGroup1ToGroup3_ShuffleOnByte_UInt32_2;
                var s0 = x.AsByte();
                var a_0 = Vector256.Shuffle(s0, f0).AsUInt32();
                var a_1 = Vector256.Shuffle(s0, f1).AsUInt32();
                var a_2 = Vector256.Shuffle(s0, f2).AsUInt32();
                result1 = a_1;
                result2 = a_2;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup3(Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup1ToGroup3_Shuffle(Vector256<long> x, out Vector256<long> result1, out Vector256<long> result2) {
                var d0 = YGroup1ToGroup3_Shuffle(x.AsUInt64(), out var d1, out var d2);
                result1 = d1.AsInt64();
                result2 = d2.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup3(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup1ToGroup3_Shuffle(Vector256<ulong> x, out Vector256<ulong> result1, out Vector256<ulong> result2) {
                var f0 = Vector256Constants.YGroup1ToGroup3_ShuffleOnByte_UInt64_0;
                var f1 = Vector256Constants.YGroup1ToGroup3_ShuffleOnByte_UInt64_1;
                var f2 = Vector256Constants.YGroup1ToGroup3_ShuffleOnByte_UInt64_2;
                var s0 = x.AsByte();
                var a_0 = Vector256.Shuffle(s0, f0).AsUInt64();
                var a_1 = Vector256.Shuffle(s0, f1).AsUInt64();
                var a_2 = Vector256.Shuffle(s0, f2).AsUInt64();
                result1 = a_1;
                result2 = a_2;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup3(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup1ToGroup3_Zip(Vector256<sbyte> x, out Vector256<sbyte> result1, out Vector256<sbyte> result2) {
                var d0 = YGroup1ToGroup3_Zip(x.AsByte(), out var d1, out var d2);
                result1 = d1.AsSByte();
                result2 = d2.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup3(Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup1ToGroup3_Zip(Vector256<byte> x, out Vector256<byte> result1, out Vector256<byte> result2) {
                return YGroup3Zip(x, x, x, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup3(Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup1ToGroup3_Zip(Vector256<short> x, out Vector256<short> result1, out Vector256<short> result2) {
                var d0 = YGroup1ToGroup3_Zip(x.AsUInt16(), out var d1, out var d2);
                result1 = d1.AsInt16();
                result2 = d2.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup3(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup1ToGroup3_Zip(Vector256<ushort> x, out Vector256<ushort> result1, out Vector256<ushort> result2) {
                return YGroup3Zip(x, x, x, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup3(Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup1ToGroup3_Zip(Vector256<int> x, out Vector256<int> result1, out Vector256<int> result2) {
                var d0 = YGroup1ToGroup3_Zip(x.AsUInt32(), out var d1, out var d2);
                result1 = d1.AsInt32();
                result2 = d2.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup3(Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup1ToGroup3_Zip(Vector256<uint> x, out Vector256<uint> result1, out Vector256<uint> result2) {
                return YGroup3Zip(x, x, x, out result1, out result2);
            }

#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup4_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup1ToGroup4_AcceleratedTypes {
                get {
                    return YGroup4Zip_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup4(Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup1ToGroup4(Vector256<float> x, out Vector256<float> result1, out Vector256<float> result2, out Vector256<float> result3) {
                return YGroup4Zip(x, x, x, x, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup4(Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup1ToGroup4(Vector256<double> x, out Vector256<double> result1, out Vector256<double> result2, out Vector256<double> result3) {
                return YGroup4Zip(x, x, x, x, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup4(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup1ToGroup4(Vector256<sbyte> x, out Vector256<sbyte> result1, out Vector256<sbyte> result2, out Vector256<sbyte> result3) {
                return YGroup4Zip(x, x, x, x, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup4(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup1ToGroup4(Vector256<byte> x, out Vector256<byte> result1, out Vector256<byte> result2, out Vector256<byte> result3) {
                return YGroup4Zip(x, x, x, x, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup4(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup1ToGroup4(Vector256<short> x, out Vector256<short> result1, out Vector256<short> result2, out Vector256<short> result3) {
                return YGroup4Zip(x, x, x, x, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup4(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup1ToGroup4(Vector256<ushort> x, out Vector256<ushort> result1, out Vector256<ushort> result2, out Vector256<ushort> result3) {
                return YGroup4Zip(x, x, x, x, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup4(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup1ToGroup4(Vector256<int> x, out Vector256<int> result1, out Vector256<int> result2, out Vector256<int> result3) {
                return YGroup4Zip(x, x, x, x, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup4(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup1ToGroup4(Vector256<uint> x, out Vector256<uint> result1, out Vector256<uint> result2, out Vector256<uint> result3) {
                return YGroup4Zip(x, x, x, x, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup4(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup1ToGroup4(Vector256<long> x, out Vector256<long> result1, out Vector256<long> result2, out Vector256<long> result3) {
                return YGroup4Zip(x, x, x, x, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup4(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup1ToGroup4(Vector256<ulong> x, out Vector256<ulong> result1, out Vector256<ulong> result2, out Vector256<ulong> result3) {
                return YGroup4Zip(x, x, x, x, out result1, out result2, out result3);
            }


            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup4WithW_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup1ToGroup4WithW_AcceleratedTypes {
                get {
                    return YGroup4Zip_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup4WithW(Vector256{float}, Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup1ToGroup4WithW(Vector256<float> x, Vector256<float> w, out Vector256<float> result1, out Vector256<float> result2, out Vector256<float> result3) {
                return YGroup4Zip(x, x, x, w, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup4WithW(Vector256{double}, Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup1ToGroup4WithW(Vector256<double> x, Vector256<double> w, out Vector256<double> result1, out Vector256<double> result2, out Vector256<double> result3) {
                return YGroup4Zip(x, x, x, w, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup4WithW(Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup1ToGroup4WithW(Vector256<sbyte> x, Vector256<sbyte> w, out Vector256<sbyte> result1, out Vector256<sbyte> result2, out Vector256<sbyte> result3) {
                return YGroup4Zip(x, x, x, w, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup4WithW(Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup1ToGroup4WithW(Vector256<byte> x, Vector256<byte> w, out Vector256<byte> result1, out Vector256<byte> result2, out Vector256<byte> result3) {
                return YGroup4Zip(x, x, x, w, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup4WithW(Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup1ToGroup4WithW(Vector256<short> x, Vector256<short> w, out Vector256<short> result1, out Vector256<short> result2, out Vector256<short> result3) {
                return YGroup4Zip(x, x, x, w, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup4WithW(Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup1ToGroup4WithW(Vector256<ushort> x, Vector256<ushort> w, out Vector256<ushort> result1, out Vector256<ushort> result2, out Vector256<ushort> result3) {
                return YGroup4Zip(x, x, x, w, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup4WithW(Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup1ToGroup4WithW(Vector256<int> x, Vector256<int> w, out Vector256<int> result1, out Vector256<int> result2, out Vector256<int> result3) {
                return YGroup4Zip(x, x, x, w, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup4WithW(Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup1ToGroup4WithW(Vector256<uint> x, Vector256<uint> w, out Vector256<uint> result1, out Vector256<uint> result2, out Vector256<uint> result3) {
                return YGroup4Zip(x, x, x, w, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup4WithW(Vector256{long}, Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup1ToGroup4WithW(Vector256<long> x, Vector256<long> w, out Vector256<long> result1, out Vector256<long> result2, out Vector256<long> result3) {
                return YGroup4Zip(x, x, x, w, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup1ToGroup4WithW(Vector256{ulong}, Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup1ToGroup4WithW(Vector256<ulong> x, Vector256<ulong> w, out Vector256<ulong> result1, out Vector256<ulong> result2, out Vector256<ulong> result3) {
                return YGroup4Zip(x, x, x, w, out result1, out result2, out result3);
            }


            /// <inheritdoc cref="IWVectorTraits256.YGroup2Transpose_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2Transpose_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt = TypeCodeFlagsUtil.Most32Types;
                    }
#if BCL_HAS_SHUFFLE
                    if (Bcl_Shuffle_Used && Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.Bit64Types;
                    }
#endif // BCL_HAS_SHUFFLE
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Transpose(Vector256{float}, Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2Transpose(Vector256<float> data0, Vector256<float> data1, out Vector256<float> result1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2Transpose_Shift(data0, data1, out result1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Transpose_Basic(data0, data1, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Transpose(Vector256{double}, Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2Transpose(Vector256<double> data0, Vector256<double> data1, out Vector256<double> result1) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector256.IsHardwareAccelerated) {
                    return YGroup2Transpose_Shuffle(data0, data1, out result1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YGroup2Transpose_Basic(data0, data1, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Transpose(Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2Transpose(Vector256<sbyte> data0, Vector256<sbyte> data1, out Vector256<sbyte> result1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2Transpose_Shift(data0, data1, out result1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Transpose_Basic(data0, data1, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Transpose(Vector256{byte}, Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2Transpose(Vector256<byte> data0, Vector256<byte> data1, out Vector256<byte> result1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2Transpose_Shift(data0, data1, out result1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Transpose_Basic(data0, data1, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Transpose(Vector256{short}, Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2Transpose(Vector256<short> data0, Vector256<short> data1, out Vector256<short> result1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2Transpose_Shift(data0, data1, out result1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Transpose_Basic(data0, data1, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Transpose(Vector256{ushort}, Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2Transpose(Vector256<ushort> data0, Vector256<ushort> data1, out Vector256<ushort> result1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2Transpose_Shift(data0, data1, out result1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Transpose_Basic(data0, data1, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Transpose(Vector256{int}, Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2Transpose(Vector256<int> data0, Vector256<int> data1, out Vector256<int> result1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2Transpose_Shift(data0, data1, out result1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Transpose_Basic(data0, data1, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Transpose(Vector256{uint}, Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2Transpose(Vector256<uint> data0, Vector256<uint> data1, out Vector256<uint> result1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2Transpose_Shift(data0, data1, out result1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Transpose_Basic(data0, data1, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Transpose(Vector256{long}, Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup2Transpose(Vector256<long> data0, Vector256<long> data1, out Vector256<long> result1) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector256.IsHardwareAccelerated) {
                    return YGroup2Transpose_Shuffle(data0, data1, out result1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YGroup2Transpose_Basic(data0, data1, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Transpose(Vector256{ulong}, Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup2Transpose(Vector256<ulong> data0, Vector256<ulong> data1, out Vector256<ulong> result1) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector256.IsHardwareAccelerated) {
                    return YGroup2Transpose_Shuffle(data0, data1, out result1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YGroup2Transpose_Basic(data0, data1, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Transpose(Vector256{float}, Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2Transpose_Basic(Vector256<float> data0, Vector256<float> data1, out Vector256<float> result1) {
                var d0 = YGroup2Transpose_Basic(data0.AsUInt32(), data1.AsUInt32(), out var d1);
                result1 = d1.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Transpose(Vector256{double}, Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2Transpose_Basic(Vector256<double> data0, Vector256<double> data1, out Vector256<double> result1) {
                var d0 = YGroup2Transpose_Basic(data0.AsUInt64(), data1.AsUInt64(), out var d1);
                result1 = d1.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Transpose(Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2Transpose_Basic(Vector256<sbyte> data0, Vector256<sbyte> data1, out Vector256<sbyte> result1) {
                var d0 = YGroup2Transpose_Basic(data0.AsByte(), data1.AsByte(), out var d1);
                result1 = d1.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Transpose(Vector256{byte}, Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2Transpose_Basic(Vector256<byte> data0, Vector256<byte> data1, out Vector256<byte> result1) {
                Unsafe.SkipInit(out Vector256<byte> rt0);
                Unsafe.SkipInit(out Vector256<byte> rt1);
                ref byte px = ref Unsafe.As<Vector256<byte>, byte>(ref data0);
                ref byte py = ref Unsafe.As<Vector256<byte>, byte>(ref data1);
                ref byte q0 = ref Unsafe.As<Vector256<byte>, byte>(ref rt0);
                ref byte q1 = ref Unsafe.As<Vector256<byte>, byte>(ref rt1);
                for (int i = 0; i < Vector256<byte>.Count; i += 2) {
                    q0 = px;
                    Unsafe.Add(ref q0, 1) = py;
                    q1 = Unsafe.Add(ref px, 1);
                    Unsafe.Add(ref q1, 1) = Unsafe.Add(ref py, 1);
                    px = ref Unsafe.Add(ref px, 2);
                    py = ref Unsafe.Add(ref py, 2);
                    q0 = ref Unsafe.Add(ref q0, 2);
                    q1 = ref Unsafe.Add(ref q1, 2);
                }
                result1 = rt1;
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Transpose(Vector256{short}, Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2Transpose_Basic(Vector256<short> data0, Vector256<short> data1, out Vector256<short> result1) {
                var d0 = YGroup2Transpose_Basic(data0.AsUInt16(), data1.AsUInt16(), out var d1);
                result1 = d1.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Transpose(Vector256{ushort}, Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2Transpose_Basic(Vector256<ushort> data0, Vector256<ushort> data1, out Vector256<ushort> result1) {
                Unsafe.SkipInit(out Vector256<ushort> rt0);
                Unsafe.SkipInit(out Vector256<ushort> rt1);
                ref ushort px = ref Unsafe.As<Vector256<ushort>, ushort>(ref data0);
                ref ushort py = ref Unsafe.As<Vector256<ushort>, ushort>(ref data1);
                ref ushort q0 = ref Unsafe.As<Vector256<ushort>, ushort>(ref rt0);
                ref ushort q1 = ref Unsafe.As<Vector256<ushort>, ushort>(ref rt1);
                for (int i = 0; i < Vector256<ushort>.Count; i += 2) {
                    q0 = px;
                    Unsafe.Add(ref q0, 1) = py;
                    q1 = Unsafe.Add(ref px, 1);
                    Unsafe.Add(ref q1, 1) = Unsafe.Add(ref py, 1);
                    px = ref Unsafe.Add(ref px, 2);
                    py = ref Unsafe.Add(ref py, 2);
                    q0 = ref Unsafe.Add(ref q0, 2);
                    q1 = ref Unsafe.Add(ref q1, 2);
                }
                result1 = rt1;
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Transpose(Vector256{int}, Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2Transpose_Basic(Vector256<int> data0, Vector256<int> data1, out Vector256<int> result1) {
                var d0 = YGroup2Transpose_Basic(data0.AsUInt32(), data1.AsUInt32(), out var d1);
                result1 = d1.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Transpose(Vector256{uint}, Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2Transpose_Basic(Vector256<uint> data0, Vector256<uint> data1, out Vector256<uint> result1) {
                Unsafe.SkipInit(out Vector256<uint> rt0);
                Unsafe.SkipInit(out Vector256<uint> rt1);
                ref uint px = ref Unsafe.As<Vector256<uint>, uint>(ref data0);
                ref uint py = ref Unsafe.As<Vector256<uint>, uint>(ref data1);
                ref uint q0 = ref Unsafe.As<Vector256<uint>, uint>(ref rt0);
                ref uint q1 = ref Unsafe.As<Vector256<uint>, uint>(ref rt1);
                for (int i = 0; i < Vector256<uint>.Count; i += 2) {
                    q0 = px;
                    Unsafe.Add(ref q0, 1) = py;
                    q1 = Unsafe.Add(ref px, 1);
                    Unsafe.Add(ref q1, 1) = Unsafe.Add(ref py, 1);
                    px = ref Unsafe.Add(ref px, 2);
                    py = ref Unsafe.Add(ref py, 2);
                    q0 = ref Unsafe.Add(ref q0, 2);
                    q1 = ref Unsafe.Add(ref q1, 2);
                }
                result1 = rt1;
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Transpose(Vector256{long}, Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup2Transpose_Basic(Vector256<long> data0, Vector256<long> data1, out Vector256<long> result1) {
                var d0 = YGroup2Transpose_Basic(data0.AsUInt64(), data1.AsUInt64(), out var d1);
                result1 = d1.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Transpose(Vector256{ulong}, Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup2Transpose_Basic(Vector256<ulong> data0, Vector256<ulong> data1, out Vector256<ulong> result1) {
                Unsafe.SkipInit(out Vector256<ulong> rt0);
                Unsafe.SkipInit(out Vector256<ulong> rt1);
                ref ulong px = ref Unsafe.As<Vector256<ulong>, ulong>(ref data0);
                ref ulong py = ref Unsafe.As<Vector256<ulong>, ulong>(ref data1);
                ref ulong q0 = ref Unsafe.As<Vector256<ulong>, ulong>(ref rt0);
                ref ulong q1 = ref Unsafe.As<Vector256<ulong>, ulong>(ref rt1);
                for (int i = 0; i < Vector256<ulong>.Count; i += 2) {
                    q0 = px;
                    Unsafe.Add(ref q0, 1) = py;
                    q1 = Unsafe.Add(ref px, 1);
                    Unsafe.Add(ref q1, 1) = Unsafe.Add(ref py, 1);
                    px = ref Unsafe.Add(ref px, 2);
                    py = ref Unsafe.Add(ref py, 2);
                    q0 = ref Unsafe.Add(ref q0, 2);
                    q1 = ref Unsafe.Add(ref q1, 2);
                }
                result1 = rt1;
                return rt0;
            }

#if VECTOR_HAS_METHOD

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Transpose(Vector256{float}, Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2Transpose_Shift(Vector256<float> data0, Vector256<float> data1, out Vector256<float> result1) {
                var d0 = YGroup2Transpose_Shift(data0.AsUInt32(), data1.AsUInt32(), out var d1);
                result1 = d1.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Transpose(Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2Transpose_Shift(Vector256<sbyte> data0, Vector256<sbyte> data1, out Vector256<sbyte> result1) {
                var d0 = YGroup2Transpose_Shift(data0.AsByte(), data1.AsByte(), out var d1);
                result1 = d1.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Transpose(Vector256{byte}, Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2Transpose_Shift(Vector256<byte> data0, Vector256<byte> data1, out Vector256<byte> result1) {
                const int L = 8;
                Vector256<ushort> a_0, a_1, b_0, b_1, c_0, c_1;
                Vector256<ushort> mask = Vector256.Create((ushort)0x00FFU);
                a_0 = data0.AsUInt16();
                a_1 = data1.AsUInt16();
                if (BitConverter.IsLittleEndian) {
                    b_1 = Vector256.ShiftLeft(a_1, L);
                    b_0 = Vector256.ShiftRightLogical(a_0, L);
                    c_0 = Vector256.BitwiseOr(Vector256.BitwiseAnd(a_0, mask), b_1);
                    c_1 = Vector256.BitwiseOr(Vector256.AndNot(a_1, mask), b_0);
                } else {
                    b_1 = Vector256.ShiftRightLogical(a_1, L);
                    b_0 = Vector256.ShiftLeft(a_0, L);
                    c_0 = Vector256.BitwiseOr(Vector256.AndNot(a_0, mask), b_1);
                    c_1 = Vector256.BitwiseOr(Vector256.BitwiseAnd(a_1, mask), b_0);
                }
                result1 = c_1.AsByte();
                return c_0.AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Transpose(Vector256{short}, Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2Transpose_Shift(Vector256<short> data0, Vector256<short> data1, out Vector256<short> result1) {
                var d0 = YGroup2Transpose_Shift(data0.AsUInt16(), data1.AsUInt16(), out var d1);
                result1 = d1.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Transpose(Vector256{ushort}, Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2Transpose_Shift(Vector256<ushort> data0, Vector256<ushort> data1, out Vector256<ushort> result1) {
                const int L = 16;
                Vector256<uint> a_0, a_1, b_0, b_1, c_0, c_1;
                Vector256<uint> mask = Vector256.Create((uint)0x0000FFFFU);
                a_0 = data0.AsUInt32();
                a_1 = data1.AsUInt32();
                if (BitConverter.IsLittleEndian) {
                    b_1 = Vector256.ShiftLeft(a_1, L);
                    b_0 = Vector256.ShiftRightLogical(a_0, L);
                    c_0 = Vector256.BitwiseOr(Vector256.BitwiseAnd(a_0, mask), b_1);
                    c_1 = Vector256.BitwiseOr(Vector256.AndNot(a_1, mask), b_0);
                } else {
                    b_1 = Vector256.ShiftRightLogical(a_1, L);
                    b_0 = Vector256.ShiftLeft(a_0, L);
                    c_0 = Vector256.BitwiseOr(Vector256.AndNot(a_0, mask), b_1);
                    c_1 = Vector256.BitwiseOr(Vector256.BitwiseAnd(a_1, mask), b_0);
                }
                result1 = c_1.AsUInt16();
                return c_0.AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Transpose(Vector256{int}, Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2Transpose_Shift(Vector256<int> data0, Vector256<int> data1, out Vector256<int> result1) {
                var d0 = YGroup2Transpose_Shift(data0.AsUInt32(), data1.AsUInt32(), out var d1);
                result1 = d1.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Transpose(Vector256{uint}, Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2Transpose_Shift(Vector256<uint> data0, Vector256<uint> data1, out Vector256<uint> result1) {
                const int L = 32;
                Vector256<ulong> a_0, a_1, b_0, b_1, c_0, c_1;
                Vector256<ulong> mask = Vector256.Create((ulong)0x00000000FFFFFFFFUL);
                a_0 = data0.AsUInt64();
                a_1 = data1.AsUInt64();
                if (BitConverter.IsLittleEndian) {
                    b_1 = Vector256.ShiftLeft(a_1, L);
                    b_0 = Vector256.ShiftRightLogical(a_0, L);
                    c_0 = Vector256.BitwiseOr(Vector256.BitwiseAnd(a_0, mask), b_1);
                    c_1 = Vector256.BitwiseOr(Vector256.AndNot(a_1, mask), b_0);
                } else {
                    b_1 = Vector256.ShiftRightLogical(a_1, L);
                    b_0 = Vector256.ShiftLeft(a_0, L);
                    c_0 = Vector256.BitwiseOr(Vector256.AndNot(a_0, mask), b_1);
                    c_1 = Vector256.BitwiseOr(Vector256.BitwiseAnd(a_1, mask), b_0);
                }
                result1 = c_1.AsUInt32();
                return c_0.AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Transpose(Vector256{float}, Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2Transpose_Shuffle(Vector256<float> data0, Vector256<float> data1, out Vector256<float> result1) {
                var d0 = YGroup2Transpose_Shuffle(data0.AsUInt32(), data1.AsUInt32(), out var d1);
                result1 = d1.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Transpose(Vector256{double}, Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2Transpose_Shuffle(Vector256<double> data0, Vector256<double> data1, out Vector256<double> result1) {
                var d0 = YGroup2Transpose_Shuffle(data0.AsUInt64(), data1.AsUInt64(), out var d1);
                result1 = d1.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Transpose(Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2Transpose_Shuffle(Vector256<sbyte> data0, Vector256<sbyte> data1, out Vector256<sbyte> result1) {
                var d0 = YGroup2Transpose_Shuffle(data0.AsByte(), data1.AsByte(), out var d1);
                result1 = d1.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Transpose(Vector256{byte}, Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2Transpose_Shuffle(Vector256<byte> data0, Vector256<byte> data1, out Vector256<byte> result1) {
                var f0A = Vector256Constants.YGroup2Transpose_Shuffle_Byte_0A;
                var f0B = Vector256Constants.YGroup2Transpose_Shuffle_Byte_0B;
                var f1A = Vector256Constants.YGroup2Transpose_Shuffle_Byte_1A;
                var f1B = Vector256Constants.YGroup2Transpose_Shuffle_Byte_1B;
                var a_0 = Vector256.BitwiseOr(Vector256.Shuffle(data0, f0A), Vector256.Shuffle(data1, f0B));
                var a_1 = Vector256.BitwiseOr(Vector256.Shuffle(data0, f1A), Vector256.Shuffle(data1, f1B));
                result1 = a_1;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Transpose(Vector256{short}, Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2Transpose_Shuffle(Vector256<short> data0, Vector256<short> data1, out Vector256<short> result1) {
                var d0 = YGroup2Transpose_Shuffle(data0.AsUInt16(), data1.AsUInt16(), out var d1);
                result1 = d1.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Transpose(Vector256{ushort}, Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2Transpose_Shuffle(Vector256<ushort> data0, Vector256<ushort> data1, out Vector256<ushort> result1) {
                var f0A = Vector256Constants.YGroup2Transpose_ShuffleOnByte_UInt16_0A;
                var f0B = Vector256Constants.YGroup2Transpose_ShuffleOnByte_UInt16_0B;
                var f1A = Vector256Constants.YGroup2Transpose_ShuffleOnByte_UInt16_1A;
                var f1B = Vector256Constants.YGroup2Transpose_ShuffleOnByte_UInt16_1B;
                var a_0 = Vector256.BitwiseOr(Vector256.Shuffle(data0.AsByte(), f0A), Vector256.Shuffle(data1.AsByte(), f0B)).AsUInt16();
                var a_1 = Vector256.BitwiseOr(Vector256.Shuffle(data0.AsByte(), f1A), Vector256.Shuffle(data1.AsByte(), f1B)).AsUInt16();
                result1 = a_1;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Transpose(Vector256{int}, Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2Transpose_Shuffle(Vector256<int> data0, Vector256<int> data1, out Vector256<int> result1) {
                var d0 = YGroup2Transpose_Shuffle(data0.AsUInt32(), data1.AsUInt32(), out var d1);
                result1 = d1.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Transpose(Vector256{uint}, Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2Transpose_Shuffle(Vector256<uint> data0, Vector256<uint> data1, out Vector256<uint> result1) {
                var f0A = Vector256Constants.YGroup2Transpose_ShuffleOnByte_UInt32_0A;
                var f0B = Vector256Constants.YGroup2Transpose_ShuffleOnByte_UInt32_0B;
                var f1A = Vector256Constants.YGroup2Transpose_ShuffleOnByte_UInt32_1A;
                var f1B = Vector256Constants.YGroup2Transpose_ShuffleOnByte_UInt32_1B;
                var a_0 = Vector256.BitwiseOr(Vector256.Shuffle(data0.AsByte(), f0A), Vector256.Shuffle(data1.AsByte(), f0B)).AsUInt32();
                var a_1 = Vector256.BitwiseOr(Vector256.Shuffle(data0.AsByte(), f1A), Vector256.Shuffle(data1.AsByte(), f1B)).AsUInt32();
                result1 = a_1;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Transpose(Vector256{long}, Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup2Transpose_Shuffle(Vector256<long> data0, Vector256<long> data1, out Vector256<long> result1) {
                var d0 = YGroup2Transpose_Shuffle(data0.AsUInt64(), data1.AsUInt64(), out var d1);
                result1 = d1.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Transpose(Vector256{ulong}, Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup2Transpose_Shuffle(Vector256<ulong> data0, Vector256<ulong> data1, out Vector256<ulong> result1) {
                var f0A = Vector256Constants.YGroup2Transpose_ShuffleOnByte_UInt64_0A;
                var f0B = Vector256Constants.YGroup2Transpose_ShuffleOnByte_UInt64_0B;
                var f1A = Vector256Constants.YGroup2Transpose_ShuffleOnByte_UInt64_1A;
                var f1B = Vector256Constants.YGroup2Transpose_ShuffleOnByte_UInt64_1B;
                var a_0 = Vector256.BitwiseOr(Vector256.Shuffle(data0.AsByte(), f0A), Vector256.Shuffle(data1.AsByte(), f0B)).AsUInt64();
                var a_1 = Vector256.BitwiseOr(Vector256.Shuffle(data0.AsByte(), f1A), Vector256.Shuffle(data1.AsByte(), f1B)).AsUInt64();
                result1 = a_1;
                return a_0;
            }

#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeEven_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2TransposeEven_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt = TypeCodeFlagsUtil.Most32Types;
                    }
#if BCL_HAS_SHUFFLE
                    if (Bcl_Shuffle_Used && Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.Bit64Types;
                    }
#endif // BCL_HAS_SHUFFLE
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeEven(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2TransposeEven(Vector256<float> data0, Vector256<float> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2TransposeEven_Shift(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2TransposeEven_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeEven(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2TransposeEven(Vector256<double> data0, Vector256<double> data1) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector256.IsHardwareAccelerated) {
                    return YGroup2TransposeEven_Shuffle(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YGroup2TransposeEven_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeEven(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2TransposeEven(Vector256<sbyte> data0, Vector256<sbyte> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2TransposeEven_Shift(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2TransposeEven_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeEven(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2TransposeEven(Vector256<byte> data0, Vector256<byte> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2TransposeEven_Shift(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2TransposeEven_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeEven(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2TransposeEven(Vector256<short> data0, Vector256<short> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2TransposeEven_Shift(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2TransposeEven_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeEven(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2TransposeEven(Vector256<ushort> data0, Vector256<ushort> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2TransposeEven_Shift(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2TransposeEven_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeEven(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2TransposeEven(Vector256<int> data0, Vector256<int> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2TransposeEven_Shift(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2TransposeEven_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeEven(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2TransposeEven(Vector256<uint> data0, Vector256<uint> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2TransposeEven_Shift(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2TransposeEven_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeEven(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup2TransposeEven(Vector256<long> data0, Vector256<long> data1) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector256.IsHardwareAccelerated) {
                    return YGroup2TransposeEven_Shuffle(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YGroup2TransposeEven_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeEven(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup2TransposeEven(Vector256<ulong> data0, Vector256<ulong> data1) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector256.IsHardwareAccelerated) {
                    return YGroup2TransposeEven_Shuffle(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YGroup2TransposeEven_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeEven(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2TransposeEven_Basic(Vector256<float> data0, Vector256<float> data1) {
                return YGroup2TransposeEven_Basic(data0.AsUInt32(), data1.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeEven(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2TransposeEven_Basic(Vector256<double> data0, Vector256<double> data1) {
                return YGroup2TransposeEven_Basic(data0.AsUInt64(), data1.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeEven(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2TransposeEven_Basic(Vector256<sbyte> data0, Vector256<sbyte> data1) {
                return YGroup2TransposeEven_Basic(data0.AsByte(), data1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeEven(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2TransposeEven_Basic(Vector256<byte> data0, Vector256<byte> data1) {
                Unsafe.SkipInit(out Vector256<byte> rt0);
                ref byte px = ref Unsafe.As<Vector256<byte>, byte>(ref data0);
                ref byte py = ref Unsafe.As<Vector256<byte>, byte>(ref data1);
                ref byte q0 = ref Unsafe.As<Vector256<byte>, byte>(ref rt0);
                for (int i = 0; i < Vector256<byte>.Count; i += 2) {
                    q0 = px;
                    Unsafe.Add(ref q0, 1) = py;
                    px = ref Unsafe.Add(ref px, 2);
                    py = ref Unsafe.Add(ref py, 2);
                    q0 = ref Unsafe.Add(ref q0, 2);
                }
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeEven(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2TransposeEven_Basic(Vector256<short> data0, Vector256<short> data1) {
                return YGroup2TransposeEven_Basic(data0.AsUInt16(), data1.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeEven(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2TransposeEven_Basic(Vector256<ushort> data0, Vector256<ushort> data1) {
                Unsafe.SkipInit(out Vector256<ushort> rt0);
                ref ushort px = ref Unsafe.As<Vector256<ushort>, ushort>(ref data0);
                ref ushort py = ref Unsafe.As<Vector256<ushort>, ushort>(ref data1);
                ref ushort q0 = ref Unsafe.As<Vector256<ushort>, ushort>(ref rt0);
                for (int i = 0; i < Vector256<ushort>.Count; i += 2) {
                    q0 = px;
                    Unsafe.Add(ref q0, 1) = py;
                    px = ref Unsafe.Add(ref px, 2);
                    py = ref Unsafe.Add(ref py, 2);
                    q0 = ref Unsafe.Add(ref q0, 2);
                }
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeEven(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2TransposeEven_Basic(Vector256<int> data0, Vector256<int> data1) {
                return YGroup2TransposeEven_Basic(data0.AsUInt32(), data1.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeEven(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2TransposeEven_Basic(Vector256<uint> data0, Vector256<uint> data1) {
                Unsafe.SkipInit(out Vector256<uint> rt0);
                ref uint px = ref Unsafe.As<Vector256<uint>, uint>(ref data0);
                ref uint py = ref Unsafe.As<Vector256<uint>, uint>(ref data1);
                ref uint q0 = ref Unsafe.As<Vector256<uint>, uint>(ref rt0);
                for (int i = 0; i < Vector256<uint>.Count; i += 2) {
                    q0 = px;
                    Unsafe.Add(ref q0, 1) = py;
                    px = ref Unsafe.Add(ref px, 2);
                    py = ref Unsafe.Add(ref py, 2);
                    q0 = ref Unsafe.Add(ref q0, 2);
                }
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeEven(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup2TransposeEven_Basic(Vector256<long> data0, Vector256<long> data1) {
                return YGroup2TransposeEven_Basic(data0.AsUInt64(), data1.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeEven(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup2TransposeEven_Basic(Vector256<ulong> data0, Vector256<ulong> data1) {
                Unsafe.SkipInit(out Vector256<ulong> rt0);
                ref ulong px = ref Unsafe.As<Vector256<ulong>, ulong>(ref data0);
                ref ulong py = ref Unsafe.As<Vector256<ulong>, ulong>(ref data1);
                ref ulong q0 = ref Unsafe.As<Vector256<ulong>, ulong>(ref rt0);
                for (int i = 0; i < Vector256<ulong>.Count; i += 2) {
                    q0 = px;
                    Unsafe.Add(ref q0, 1) = py;
                    px = ref Unsafe.Add(ref px, 2);
                    py = ref Unsafe.Add(ref py, 2);
                    q0 = ref Unsafe.Add(ref q0, 2);
                }
                return rt0;
            }

#if VECTOR_HAS_METHOD

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeEven(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2TransposeEven_Shift(Vector256<float> data0, Vector256<float> data1) {
                return YGroup2TransposeEven_Shift(data0.AsUInt32(), data1.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeEven(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2TransposeEven_Shift(Vector256<sbyte> data0, Vector256<sbyte> data1) {
                return YGroup2TransposeEven_Shift(data0.AsByte(), data1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeEven(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2TransposeEven_Shift(Vector256<byte> data0, Vector256<byte> data1) {
                return YGroup2Transpose_Shift(data0, data1, out _);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeEven(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2TransposeEven_Shift(Vector256<short> data0, Vector256<short> data1) {
                return YGroup2TransposeEven_Shift(data0.AsUInt16(), data1.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeEven(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2TransposeEven_Shift(Vector256<ushort> data0, Vector256<ushort> data1) {
                return YGroup2Transpose_Shift(data0, data1, out _);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeEven(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2TransposeEven_Shift(Vector256<int> data0, Vector256<int> data1) {
                return YGroup2TransposeEven_Shift(data0.AsUInt32(), data1.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeEven(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2TransposeEven_Shift(Vector256<uint> data0, Vector256<uint> data1) {
                return YGroup2Transpose_Shift(data0, data1, out _);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeEven(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2TransposeEven_Shuffle(Vector256<float> data0, Vector256<float> data1) {
                return YGroup2TransposeEven_Shuffle(data0.AsUInt32(), data1.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeEven(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2TransposeEven_Shuffle(Vector256<double> data0, Vector256<double> data1) {
                return YGroup2TransposeEven_Shuffle(data0.AsUInt64(), data1.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeEven(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2TransposeEven_Shuffle(Vector256<sbyte> data0, Vector256<sbyte> data1) {
                return YGroup2TransposeEven_Shuffle(data0.AsByte(), data1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeEven(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2TransposeEven_Shuffle(Vector256<byte> data0, Vector256<byte> data1) {
                var f0A = Vector256Constants.YGroup2Transpose_Shuffle_Byte_0A;
                var f0B = Vector256Constants.YGroup2Transpose_Shuffle_Byte_0B;
                var a_0 = Vector256.BitwiseOr(Vector256.Shuffle(data0, f0A), Vector256.Shuffle(data1, f0B));
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeEven(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2TransposeEven_Shuffle(Vector256<short> data0, Vector256<short> data1) {
                return YGroup2TransposeEven_Shuffle(data0.AsUInt16(), data1.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeEven(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2TransposeEven_Shuffle(Vector256<ushort> data0, Vector256<ushort> data1) {
                var f0A = Vector256Constants.YGroup2Transpose_ShuffleOnByte_UInt16_0A;
                var f0B = Vector256Constants.YGroup2Transpose_ShuffleOnByte_UInt16_0B;
                var a_0 = Vector256.BitwiseOr(Vector256.Shuffle(data0.AsByte(), f0A), Vector256.Shuffle(data1.AsByte(), f0B)).AsUInt16();
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeEven(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2TransposeEven_Shuffle(Vector256<int> data0, Vector256<int> data1) {
                return YGroup2TransposeEven_Shuffle(data0.AsUInt32(), data1.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeEven(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2TransposeEven_Shuffle(Vector256<uint> data0, Vector256<uint> data1) {
                var f0A = Vector256Constants.YGroup2Transpose_ShuffleOnByte_UInt32_0A;
                var f0B = Vector256Constants.YGroup2Transpose_ShuffleOnByte_UInt32_0B;
                var a_0 = Vector256.BitwiseOr(Vector256.Shuffle(data0.AsByte(), f0A), Vector256.Shuffle(data1.AsByte(), f0B)).AsUInt32();
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeEven(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup2TransposeEven_Shuffle(Vector256<long> data0, Vector256<long> data1) {
                return YGroup2TransposeEven_Shuffle(data0.AsUInt64(), data1.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeEven(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup2TransposeEven_Shuffle(Vector256<ulong> data0, Vector256<ulong> data1) {
                var f0A = Vector256Constants.YGroup2Transpose_ShuffleOnByte_UInt64_0A;
                var f0B = Vector256Constants.YGroup2Transpose_ShuffleOnByte_UInt64_0B;
                var a_0 = Vector256.BitwiseOr(Vector256.Shuffle(data0.AsByte(), f0A), Vector256.Shuffle(data1.AsByte(), f0B)).AsUInt64();
                return a_0;
            }

#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeOdd_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2TransposeOdd_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt = TypeCodeFlagsUtil.Most32Types;
                    }
#if BCL_HAS_SHUFFLE
                    if (Bcl_Shuffle_Used && Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.Bit64Types;
                    }
#endif // BCL_HAS_SHUFFLE
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeOdd(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2TransposeOdd(Vector256<float> data0, Vector256<float> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2TransposeOdd_Shift(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2TransposeOdd_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeOdd(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2TransposeOdd(Vector256<double> data0, Vector256<double> data1) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector256.IsHardwareAccelerated) {
                    return YGroup2TransposeOdd_Shuffle(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YGroup2TransposeOdd_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeOdd(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2TransposeOdd(Vector256<sbyte> data0, Vector256<sbyte> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2TransposeOdd_Shift(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2TransposeOdd_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeOdd(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2TransposeOdd(Vector256<byte> data0, Vector256<byte> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2TransposeOdd_Shift(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2TransposeOdd_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeOdd(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2TransposeOdd(Vector256<short> data0, Vector256<short> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2TransposeOdd_Shift(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2TransposeOdd_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeOdd(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2TransposeOdd(Vector256<ushort> data0, Vector256<ushort> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2TransposeOdd_Shift(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2TransposeOdd_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeOdd(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2TransposeOdd(Vector256<int> data0, Vector256<int> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2TransposeOdd_Shift(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2TransposeOdd_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeOdd(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2TransposeOdd(Vector256<uint> data0, Vector256<uint> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2TransposeOdd_Shift(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2TransposeOdd_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeOdd(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup2TransposeOdd(Vector256<long> data0, Vector256<long> data1) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector256.IsHardwareAccelerated) {
                    return YGroup2TransposeOdd_Shuffle(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YGroup2TransposeOdd_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeOdd(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup2TransposeOdd(Vector256<ulong> data0, Vector256<ulong> data1) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector256.IsHardwareAccelerated) {
                    return YGroup2TransposeOdd_Shuffle(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YGroup2TransposeOdd_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeOdd(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2TransposeOdd_Basic(Vector256<float> data0, Vector256<float> data1) {
                return YGroup2TransposeOdd_Basic(data0.AsUInt32(), data1.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeOdd(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2TransposeOdd_Basic(Vector256<double> data0, Vector256<double> data1) {
                return YGroup2TransposeOdd_Basic(data0.AsUInt64(), data1.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeOdd(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2TransposeOdd_Basic(Vector256<sbyte> data0, Vector256<sbyte> data1) {
                return YGroup2TransposeOdd_Basic(data0.AsByte(), data1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeOdd(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2TransposeOdd_Basic(Vector256<byte> data0, Vector256<byte> data1) {
                Unsafe.SkipInit(out Vector256<byte> rt1);
                ref byte px = ref Unsafe.As<Vector256<byte>, byte>(ref data0);
                ref byte py = ref Unsafe.As<Vector256<byte>, byte>(ref data1);
                ref byte q1 = ref Unsafe.As<Vector256<byte>, byte>(ref rt1);
                for (int i = 0; i < Vector256<byte>.Count; i += 2) {
                    q1 = Unsafe.Add(ref px, 1);
                    Unsafe.Add(ref q1, 1) = Unsafe.Add(ref py, 1);
                    px = ref Unsafe.Add(ref px, 2);
                    py = ref Unsafe.Add(ref py, 2);
                    q1 = ref Unsafe.Add(ref q1, 2);
                }
                return rt1;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeOdd(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2TransposeOdd_Basic(Vector256<short> data0, Vector256<short> data1) {
                return YGroup2TransposeOdd_Basic(data0.AsUInt16(), data1.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeOdd(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2TransposeOdd_Basic(Vector256<ushort> data0, Vector256<ushort> data1) {
                Unsafe.SkipInit(out Vector256<ushort> rt1);
                ref ushort px = ref Unsafe.As<Vector256<ushort>, ushort>(ref data0);
                ref ushort py = ref Unsafe.As<Vector256<ushort>, ushort>(ref data1);
                ref ushort q1 = ref Unsafe.As<Vector256<ushort>, ushort>(ref rt1);
                for (int i = 0; i < Vector256<ushort>.Count; i += 2) {
                    q1 = Unsafe.Add(ref px, 1);
                    Unsafe.Add(ref q1, 1) = Unsafe.Add(ref py, 1);
                    px = ref Unsafe.Add(ref px, 2);
                    py = ref Unsafe.Add(ref py, 2);
                    q1 = ref Unsafe.Add(ref q1, 2);
                }
                return rt1;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeOdd(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2TransposeOdd_Basic(Vector256<int> data0, Vector256<int> data1) {
                return YGroup2TransposeOdd_Basic(data0.AsUInt32(), data1.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeOdd(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2TransposeOdd_Basic(Vector256<uint> data0, Vector256<uint> data1) {
                Unsafe.SkipInit(out Vector256<uint> rt1);
                ref uint px = ref Unsafe.As<Vector256<uint>, uint>(ref data0);
                ref uint py = ref Unsafe.As<Vector256<uint>, uint>(ref data1);
                ref uint q1 = ref Unsafe.As<Vector256<uint>, uint>(ref rt1);
                for (int i = 0; i < Vector256<uint>.Count; i += 2) {
                    q1 = Unsafe.Add(ref px, 1);
                    Unsafe.Add(ref q1, 1) = Unsafe.Add(ref py, 1);
                    px = ref Unsafe.Add(ref px, 2);
                    py = ref Unsafe.Add(ref py, 2);
                    q1 = ref Unsafe.Add(ref q1, 2);
                }
                return rt1;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeOdd(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup2TransposeOdd_Basic(Vector256<long> data0, Vector256<long> data1) {
                return YGroup2TransposeOdd_Basic(data0.AsUInt64(), data1.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeOdd(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup2TransposeOdd_Basic(Vector256<ulong> data0, Vector256<ulong> data1) {
                Unsafe.SkipInit(out Vector256<ulong> rt1);
                ref ulong px = ref Unsafe.As<Vector256<ulong>, ulong>(ref data0);
                ref ulong py = ref Unsafe.As<Vector256<ulong>, ulong>(ref data1);
                ref ulong q1 = ref Unsafe.As<Vector256<ulong>, ulong>(ref rt1);
                for (int i = 0; i < Vector256<ulong>.Count; i += 2) {
                    q1 = Unsafe.Add(ref px, 1);
                    Unsafe.Add(ref q1, 1) = Unsafe.Add(ref py, 1);
                    px = ref Unsafe.Add(ref px, 2);
                    py = ref Unsafe.Add(ref py, 2);
                    q1 = ref Unsafe.Add(ref q1, 2);
                }
                return rt1;
            }

#if VECTOR_HAS_METHOD

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeOdd(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2TransposeOdd_Shift(Vector256<float> data0, Vector256<float> data1) {
                return YGroup2TransposeOdd_Shift(data0.AsUInt32(), data1.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeOdd(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2TransposeOdd_Shift(Vector256<sbyte> data0, Vector256<sbyte> data1) {
                return YGroup2TransposeOdd_Shift(data0.AsByte(), data1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeOdd(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2TransposeOdd_Shift(Vector256<byte> data0, Vector256<byte> data1) {
                _ = YGroup2Transpose_Shift(data0, data1, out var rt1);
                return rt1;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeOdd(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2TransposeOdd_Shift(Vector256<short> data0, Vector256<short> data1) {
                return YGroup2TransposeOdd_Shift(data0.AsUInt16(), data1.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeOdd(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2TransposeOdd_Shift(Vector256<ushort> data0, Vector256<ushort> data1) {
                _ = YGroup2Transpose_Shift(data0, data1, out var rt1);
                return rt1;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeOdd(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2TransposeOdd_Shift(Vector256<int> data0, Vector256<int> data1) {
                return YGroup2TransposeOdd_Shift(data0.AsUInt32(), data1.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeOdd(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2TransposeOdd_Shift(Vector256<uint> data0, Vector256<uint> data1) {
                _ = YGroup2Transpose_Shift(data0, data1, out var rt1);
                return rt1;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeOdd(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2TransposeOdd_Shuffle(Vector256<float> data0, Vector256<float> data1) {
                return YGroup2TransposeOdd_Shuffle(data0.AsUInt32(), data1.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeOdd(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2TransposeOdd_Shuffle(Vector256<double> data0, Vector256<double> data1) {
                return YGroup2TransposeOdd_Shuffle(data0.AsUInt64(), data1.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeOdd(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2TransposeOdd_Shuffle(Vector256<sbyte> data0, Vector256<sbyte> data1) {
                return YGroup2TransposeOdd_Shuffle(data0.AsByte(), data1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeOdd(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2TransposeOdd_Shuffle(Vector256<byte> data0, Vector256<byte> data1) {
                var f1A = Vector256Constants.YGroup2Transpose_Shuffle_Byte_1A;
                var f1B = Vector256Constants.YGroup2Transpose_Shuffle_Byte_1B;
                var a_1 = Vector256.BitwiseOr(Vector256.Shuffle(data0, f1A), Vector256.Shuffle(data1, f1B));
                return a_1;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeOdd(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2TransposeOdd_Shuffle(Vector256<short> data0, Vector256<short> data1) {
                return YGroup2TransposeOdd_Shuffle(data0.AsUInt16(), data1.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeOdd(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2TransposeOdd_Shuffle(Vector256<ushort> data0, Vector256<ushort> data1) {
                var f1A = Vector256Constants.YGroup2Transpose_ShuffleOnByte_UInt16_1A;
                var f1B = Vector256Constants.YGroup2Transpose_ShuffleOnByte_UInt16_1B;
                var a_1 = Vector256.BitwiseOr(Vector256.Shuffle(data0.AsByte(), f1A), Vector256.Shuffle(data1.AsByte(), f1B)).AsUInt16();
                return a_1;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeOdd(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2TransposeOdd_Shuffle(Vector256<int> data0, Vector256<int> data1) {
                return YGroup2TransposeOdd_Shuffle(data0.AsUInt32(), data1.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeOdd(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2TransposeOdd_Shuffle(Vector256<uint> data0, Vector256<uint> data1) {
                var f1A = Vector256Constants.YGroup2Transpose_ShuffleOnByte_UInt32_1A;
                var f1B = Vector256Constants.YGroup2Transpose_ShuffleOnByte_UInt32_1B;
                var a_1 = Vector256.BitwiseOr(Vector256.Shuffle(data0.AsByte(), f1A), Vector256.Shuffle(data1.AsByte(), f1B)).AsUInt32();
                return a_1;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeOdd(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup2TransposeOdd_Shuffle(Vector256<long> data0, Vector256<long> data1) {
                return YGroup2TransposeOdd_Shuffle(data0.AsUInt64(), data1.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2TransposeOdd(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup2TransposeOdd_Shuffle(Vector256<ulong> data0, Vector256<ulong> data1) {
                var f1A = Vector256Constants.YGroup2Transpose_ShuffleOnByte_UInt64_1A;
                var f1B = Vector256Constants.YGroup2Transpose_ShuffleOnByte_UInt64_1B;
                var a_1 = Vector256.BitwiseOr(Vector256.Shuffle(data0.AsByte(), f1A), Vector256.Shuffle(data1.AsByte(), f1B)).AsUInt64();
                return a_1;
            }

#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2Unzip_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt = TypeCodeFlagsUtil.Most32Types;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{float}, Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2Unzip(Vector256<float> data0, Vector256<float> data1, out Vector256<float> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2Unzip_Narrow(data0, data1, out y);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Unzip_Basic(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{double}, Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2Unzip(Vector256<double> data0, Vector256<double> data1, out Vector256<double> y) {
                return YGroup2Unzip_Basic(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2Unzip(Vector256<sbyte> data0, Vector256<sbyte> data1, out Vector256<sbyte> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2Unzip_Narrow(data0, data1, out y);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Unzip_Basic(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{byte}, Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2Unzip(Vector256<byte> data0, Vector256<byte> data1, out Vector256<byte> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2Unzip_Narrow(data0, data1, out y);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Unzip_Basic(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{short}, Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2Unzip(Vector256<short> data0, Vector256<short> data1, out Vector256<short> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2Unzip_Narrow(data0, data1, out y);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Unzip_Basic(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{ushort}, Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2Unzip(Vector256<ushort> data0, Vector256<ushort> data1, out Vector256<ushort> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2Unzip_Narrow(data0, data1, out y);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Unzip_Basic(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{int}, Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2Unzip(Vector256<int> data0, Vector256<int> data1, out Vector256<int> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2Unzip_Narrow(data0, data1, out y);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Unzip_Basic(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{uint}, Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2Unzip(Vector256<uint> data0, Vector256<uint> data1, out Vector256<uint> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2Unzip_Narrow(data0, data1, out y);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Unzip_Basic(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{long}, Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup2Unzip(Vector256<long> data0, Vector256<long> data1, out Vector256<long> y) {
                return YGroup2Unzip_Basic(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{ulong}, Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup2Unzip(Vector256<ulong> data0, Vector256<ulong> data1, out Vector256<ulong> y) {
                return YGroup2Unzip_Basic(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{ExInt128}, Vector256{ExInt128}, out Vector256{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExInt128> YGroup2Unzip(Vector256<ExInt128> data0, Vector256<ExInt128> data1, out Vector256<ExInt128> y) {
                return YGroup2Unzip_Move(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{ExUInt128}, Vector256{ExUInt128}, out Vector256{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExUInt128> YGroup2Unzip(Vector256<ExUInt128> data0, Vector256<ExUInt128> data1, out Vector256<ExUInt128> y) {
                return YGroup2Unzip_Move(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip_Bit128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<T> YGroup2Unzip_Bit128<T>(Vector256<T> data0, Vector256<T> data1, out Vector256<T> y) where T : struct {
#if EX_APPLY_GENERIC
                var d0 = YGroup2Unzip_Move(data0.ExAsExUInt128(), data1.ExAsExUInt128(), out var d1);
                y = d1.ExAs<ExUInt128, T>();
                return d0.ExAs<ExUInt128, T>();
#else
                var c0 = data0.WithUpper(data1.GetLower());
                var c1 = data1.WithLower(data0.GetUpper());
                y = c1;
                return c0;
#endif // EX_APPLY_GENERIC
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{float}, Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2Unzip_Basic(Vector256<float> data0, Vector256<float> data1, out Vector256<float> y) {
                var d0 = YGroup2Unzip_Basic(data0.AsUInt32(), data1.AsUInt32(), out var d1);
                y = d1.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{double}, Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2Unzip_Basic(Vector256<double> data0, Vector256<double> data1, out Vector256<double> y) {
                var d0 = YGroup2Unzip_Basic(data0.AsUInt64(), data1.AsUInt64(), out var d1);
                y = d1.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2Unzip_Basic(Vector256<sbyte> data0, Vector256<sbyte> data1, out Vector256<sbyte> y) {
                var d0 = YGroup2Unzip_Basic(data0.AsByte(), data1.AsByte(), out var d1);
                y = d1.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{byte}, Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2Unzip_Basic(Vector256<byte> data0, Vector256<byte> data1, out Vector256<byte> y) {
                Unsafe.SkipInit(out Vector256<byte> x1);
                Unsafe.SkipInit(out Vector256<byte> y1);
                Span<Vector256<byte>> src = [data0, data1];
                ref byte px = ref Unsafe.As<Vector256<byte>, byte>(ref x1);
                ref byte py = ref Unsafe.As<Vector256<byte>, byte>(ref y1);
                Span<byte> p = MemoryMarshal.Cast<Vector256<byte>, byte>(src);
                int idx = 0;
                for (int i = 0; i < Vector256<byte>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    Unsafe.Add(ref py, i) = p[idx + 1];
                    idx += 2;
                }
                y = y1;
                return x1;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{short}, Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2Unzip_Basic(Vector256<short> data0, Vector256<short> data1, out Vector256<short> y) {
                var d0 = YGroup2Unzip_Basic(data0.AsUInt16(), data1.AsUInt16(), out var d1);
                y = d1.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{ushort}, Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2Unzip_Basic(Vector256<ushort> data0, Vector256<ushort> data1, out Vector256<ushort> y) {
                Unsafe.SkipInit(out Vector256<ushort> x1);
                Unsafe.SkipInit(out Vector256<ushort> y1);
                Span<Vector256<ushort>> src = [data0, data1];
                ref ushort px = ref Unsafe.As<Vector256<ushort>, ushort>(ref x1);
                ref ushort py = ref Unsafe.As<Vector256<ushort>, ushort>(ref y1);
                Span<ushort> p = MemoryMarshal.Cast<Vector256<ushort>, ushort>(src);
                int idx = 0;
                for (int i = 0; i < Vector256<ushort>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    Unsafe.Add(ref py, i) = p[idx + 1];
                    idx += 2;
                }
                y = y1;
                return x1;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{int}, Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2Unzip_Basic(Vector256<int> data0, Vector256<int> data1, out Vector256<int> y) {
                var d0 = YGroup2Unzip_Basic(data0.AsUInt32(), data1.AsUInt32(), out var d1);
                y = d1.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{uint}, Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2Unzip_Basic(Vector256<uint> data0, Vector256<uint> data1, out Vector256<uint> y) {
                Unsafe.SkipInit(out Vector256<uint> x1);
                Unsafe.SkipInit(out Vector256<uint> y1);
                Span<Vector256<uint>> src = [data0, data1];
                ref uint px = ref Unsafe.As<Vector256<uint>, uint>(ref x1);
                ref uint py = ref Unsafe.As<Vector256<uint>, uint>(ref y1);
                Span<uint> p = MemoryMarshal.Cast<Vector256<uint>, uint>(src);
                int idx = 0;
                for (int i = 0; i < Vector256<uint>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    Unsafe.Add(ref py, i) = p[idx + 1];
                    idx += 2;
                }
                y = y1;
                return x1;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{long}, Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup2Unzip_Basic(Vector256<long> data0, Vector256<long> data1, out Vector256<long> y) {
                var d0 = YGroup2Unzip_Basic(data0.AsUInt64(), data1.AsUInt64(), out var d1);
                y = d1.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{ulong}, Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup2Unzip_Basic(Vector256<ulong> data0, Vector256<ulong> data1, out Vector256<ulong> y) {
                Unsafe.SkipInit(out Vector256<ulong> x1);
                Unsafe.SkipInit(out Vector256<ulong> y1);
                Span<Vector256<ulong>> src = [data0, data1];
                ref ulong px = ref Unsafe.As<Vector256<ulong>, ulong>(ref x1);
                ref ulong py = ref Unsafe.As<Vector256<ulong>, ulong>(ref y1);
                Span<ulong> p = MemoryMarshal.Cast<Vector256<ulong>, ulong>(src);
                int idx = 0;
                for (int i = 0; i < Vector256<ulong>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    Unsafe.Add(ref py, i) = p[idx + 1];
                    idx += 2;
                }
                y = y1;
                return x1;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{ExInt128}, Vector256{ExInt128}, out Vector256{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExInt128> YGroup2Unzip_Basic(Vector256<ExInt128> data0, Vector256<ExInt128> data1, out Vector256<ExInt128> y) {
                var d0 = YGroup2Unzip_Basic(data0.ExAsExUInt128(), data1.ExAsExUInt128(), out var d1);
                y = d1.ExAsExInt128();
                return d0.ExAsExInt128();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{ExUInt128}, Vector256{ExUInt128}, out Vector256{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExUInt128> YGroup2Unzip_Basic(Vector256<ExUInt128> data0, Vector256<ExUInt128> data1, out Vector256<ExUInt128> y) {
                Unsafe.SkipInit(out Vector256<ExUInt128> x1);
                Unsafe.SkipInit(out Vector256<ExUInt128> y1);
                Span<Vector256<ExUInt128>> src = [data0, data1];
                ref ExUInt128 px = ref Unsafe.As<Vector256<ExUInt128>, ExUInt128>(ref x1);
                ref ExUInt128 py = ref Unsafe.As<Vector256<ExUInt128>, ExUInt128>(ref y1);
                Span<ExUInt128> p = MemoryMarshal.Cast<Vector256<ExUInt128>, ExUInt128>(src);
                int idx = 0;
                for (int i = 0; i < Vector256s<ExUInt128>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    Unsafe.Add(ref py, i) = p[idx + 1];
                    idx += 2;
                }
                y = y1;
                return x1;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{ExInt128}, Vector256{ExInt128}, out Vector256{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExInt128> YGroup2Unzip_Move(Vector256<ExInt128> data0, Vector256<ExInt128> data1, out Vector256<ExInt128> y) {
                var d0 = YGroup2Unzip_Move(data0.ExAsExUInt128(), data1.ExAsExUInt128(), out var d1);
                y = d1.ExAsExInt128();
                return d0.ExAsExInt128();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{ExUInt128}, Vector256{ExUInt128}, out Vector256{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExUInt128> YGroup2Unzip_Move(Vector256<ExUInt128> data0, Vector256<ExUInt128> data1, out Vector256<ExUInt128> y) {
                var a0 = data0.ExAsUInt64();
                var a1 = data1.ExAsUInt64();
                var c0 = a0.WithUpper(a1.GetLower());
                var c1 = a1.WithLower(a0.GetUpper());
                y = c1.ExAsExUInt128();
                return c0.ExAsExUInt128();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{ExInt128}, Vector256{ExInt128}, out Vector256{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExInt128> YGroup2Unzip_Move2(Vector256<ExInt128> data0, Vector256<ExInt128> data1, out Vector256<ExInt128> y) {
                var d0 = YGroup2Unzip_Move2(data0.ExAsExUInt128(), data1.ExAsExUInt128(), out var d1);
                y = d1.ExAsExInt128();
                return d0.ExAsExInt128();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{ExUInt128}, Vector256{ExUInt128}, out Vector256{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExUInt128> YGroup2Unzip_Move2(Vector256<ExUInt128> data0, Vector256<ExUInt128> data1, out Vector256<ExUInt128> y) {
                var a0 = data0.ExAsUInt64();
                var a1 = data1.ExAsUInt64();
                var b0 = a0.GetLower();
                var b1 = a0.GetUpper();
                var b2 = a1.GetLower();
                var b3 = a1.GetUpper();
                var c0 = b0.ToVector256Unsafe().WithUpper(b2);
                var c1 = b1.ToVector256Unsafe().WithUpper(b3);
                y = c1.ExAsExUInt128();
                return c0.ExAsExUInt128();
            }

#if VECTOR_HAS_METHOD

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{float}, Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2Unzip_Narrow(Vector256<float> data0, Vector256<float> data1, out Vector256<float> y) {
                var d0 = YGroup2Unzip_Narrow(data0.AsUInt32(), data1.AsUInt32(), out var d1);
                y = d1.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2Unzip_Narrow(Vector256<sbyte> data0, Vector256<sbyte> data1, out Vector256<sbyte> y) {
                var d0 = YGroup2Unzip_Narrow(data0.AsByte(), data1.AsByte(), out var d1);
                y = d1.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{byte}, Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2Unzip_Narrow(Vector256<byte> data0, Vector256<byte> data1, out Vector256<byte> y) {
                const int L = 8;
                Vector256<byte> rt0, rt1;
                Vector256<ushort> temp0 = data0.AsUInt16();
                Vector256<ushort> temp1 = data1.AsUInt16();
                rt0 = Vector256.Narrow(temp0, temp1);
                temp0 = Vector256.ShiftRightLogical(temp0, L);
                temp1 = Vector256.ShiftRightLogical(temp1, L);
                rt1 = Vector256.Narrow(temp0, temp1);
                if (BitConverter.IsLittleEndian) {
                    y = rt1;
                    return rt0;
                } else {
                    y = rt0;
                    return rt1;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{short}, Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2Unzip_Narrow(Vector256<short> data0, Vector256<short> data1, out Vector256<short> y) {
                var d0 = YGroup2Unzip_Narrow(data0.AsUInt16(), data1.AsUInt16(), out var d1);
                y = d1.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{ushort}, Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2Unzip_Narrow(Vector256<ushort> data0, Vector256<ushort> data1, out Vector256<ushort> y) {
                const int L = 16;
                Vector256<ushort> rt0, rt1;
                Vector256<uint> temp0 = data0.AsUInt32();
                Vector256<uint> temp1 = data1.AsUInt32();
                rt0 = Vector256.Narrow(temp0, temp1);
                temp0 = Vector256.ShiftRightLogical(temp0, L);
                temp1 = Vector256.ShiftRightLogical(temp1, L);
                rt1 = Vector256.Narrow(temp0, temp1);
                if (BitConverter.IsLittleEndian) {
                    y = rt1;
                    return rt0;
                } else {
                    y = rt0;
                    return rt1;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{int}, Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2Unzip_Narrow(Vector256<int> data0, Vector256<int> data1, out Vector256<int> y) {
                var d0 = YGroup2Unzip_Narrow(data0.AsUInt32(), data1.AsUInt32(), out var d1);
                y = d1.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{uint}, Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2Unzip_Narrow(Vector256<uint> data0, Vector256<uint> data1, out Vector256<uint> y) {
                const int L = 32;
                Vector256<uint> rt0, rt1;
                Vector256<ulong> temp0 = data0.AsUInt64();
                Vector256<ulong> temp1 = data1.AsUInt64();
                rt0 = Vector256.Narrow(temp0, temp1);
                temp0 = Vector256.ShiftRightLogical(temp0, L);
                temp1 = Vector256.ShiftRightLogical(temp1, L);
                rt1 = Vector256.Narrow(temp0, temp1);
                if (BitConverter.IsLittleEndian) {
                    y = rt1;
                    return rt0;
                } else {
                    y = rt0;
                    return rt1;
                }
            }

#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2UnzipEven_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt = TypeCodeFlagsUtil.Most32Types;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2UnzipEven(Vector256<float> data0, Vector256<float> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2UnzipEven_Narrow(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipEven_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2UnzipEven(Vector256<double> data0, Vector256<double> data1) {
                return YGroup2UnzipEven_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2UnzipEven(Vector256<sbyte> data0, Vector256<sbyte> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2UnzipEven_Narrow(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipEven_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2UnzipEven(Vector256<byte> data0, Vector256<byte> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2UnzipEven_Narrow(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipEven_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2UnzipEven(Vector256<short> data0, Vector256<short> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2UnzipEven_Narrow(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipEven_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2UnzipEven(Vector256<ushort> data0, Vector256<ushort> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2UnzipEven_Narrow(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipEven_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2UnzipEven(Vector256<int> data0, Vector256<int> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2UnzipEven_Narrow(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipEven_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2UnzipEven(Vector256<uint> data0, Vector256<uint> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2UnzipEven_Narrow(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipEven_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup2UnzipEven(Vector256<long> data0, Vector256<long> data1) {
                return YGroup2UnzipEven_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup2UnzipEven(Vector256<ulong> data0, Vector256<ulong> data1) {
                return YGroup2UnzipEven_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{ExInt128}, Vector256{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExInt128> YGroup2UnzipEven(Vector256<ExInt128> data0, Vector256<ExInt128> data1) {
                return YGroup2UnzipEven(data0.ExAsExUInt128(), data1.ExAsExUInt128()).ExAsExInt128();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{ExUInt128}, Vector256{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExUInt128> YGroup2UnzipEven(Vector256<ExUInt128> data0, Vector256<ExUInt128> data1) {
                var a0 = data0.ExAsUInt64();
                var a1 = data1.ExAsUInt64();
                var b0 = a0.GetLower();
                var b2 = a1.GetLower();
                var c0 = b0.ToVector256Unsafe().WithUpper(b2);
                return c0.ExAsExUInt128();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2UnzipEven_Basic(Vector256<float> data0, Vector256<float> data1) {
                return YGroup2UnzipEven_Basic(data0.AsUInt32(), data1.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2UnzipEven_Basic(Vector256<double> data0, Vector256<double> data1) {
                return YGroup2UnzipEven_Basic(data0.AsUInt64(), data1.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2UnzipEven_Basic(Vector256<sbyte> data0, Vector256<sbyte> data1) {
                return YGroup2UnzipEven_Basic(data0.AsByte(), data1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2UnzipEven_Basic(Vector256<byte> data0, Vector256<byte> data1) {
                Unsafe.SkipInit(out Vector256<byte> x1);
                Span<Vector256<byte>> src = [data0, data1];
                ref byte px = ref Unsafe.As<Vector256<byte>, byte>(ref x1);
                Span<byte> p = MemoryMarshal.Cast<Vector256<byte>, byte>(src);
                int idx = 0;
                for (int i = 0; i < Vector256<byte>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    idx += 2;
                }
                return x1;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2UnzipEven_Basic(Vector256<short> data0, Vector256<short> data1) {
                return YGroup2UnzipEven_Basic(data0.AsUInt16(), data1.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2UnzipEven_Basic(Vector256<ushort> data0, Vector256<ushort> data1) {
                Unsafe.SkipInit(out Vector256<ushort> x1);
                Span<Vector256<ushort>> src = [data0, data1];
                ref ushort px = ref Unsafe.As<Vector256<ushort>, ushort>(ref x1);
                Span<ushort> p = MemoryMarshal.Cast<Vector256<ushort>, ushort>(src);
                int idx = 0;
                for (int i = 0; i < Vector256<ushort>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    idx += 2;
                }
                return x1;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2UnzipEven_Basic(Vector256<int> data0, Vector256<int> data1) {
                return YGroup2UnzipEven_Basic(data0.AsUInt32(), data1.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2UnzipEven_Basic(Vector256<uint> data0, Vector256<uint> data1) {
                Unsafe.SkipInit(out Vector256<uint> x1);
                Span<Vector256<uint>> src = [data0, data1];
                ref uint px = ref Unsafe.As<Vector256<uint>, uint>(ref x1);
                Span<uint> p = MemoryMarshal.Cast<Vector256<uint>, uint>(src);
                int idx = 0;
                for (int i = 0; i < Vector256<uint>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    idx += 2;
                }
                return x1;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup2UnzipEven_Basic(Vector256<long> data0, Vector256<long> data1) {
                return YGroup2UnzipEven_Basic(data0.AsUInt64(), data1.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup2UnzipEven_Basic(Vector256<ulong> data0, Vector256<ulong> data1) {
                Unsafe.SkipInit(out Vector256<ulong> x1);
                Span<Vector256<ulong>> src = [data0, data1];
                ref ulong px = ref Unsafe.As<Vector256<ulong>, ulong>(ref x1);
                Span<ulong> p = MemoryMarshal.Cast<Vector256<ulong>, ulong>(src);
                int idx = 0;
                for (int i = 0; i < Vector256<ulong>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    idx += 2;
                }
                return x1;
            }

#if VECTOR_HAS_METHOD

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2UnzipEven_Narrow(Vector256<float> data0, Vector256<float> data1) {
                return YGroup2UnzipEven_Narrow(data0.AsUInt32(), data1.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2UnzipEven_Narrow(Vector256<sbyte> data0, Vector256<sbyte> data1) {
                return YGroup2UnzipEven_Narrow(data0.AsByte(), data1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2UnzipEven_Narrow(Vector256<byte> data0, Vector256<byte> data1) {
                const int L = 8;
                Vector256<byte> rt0, rt1;
                Vector256<ushort> temp0 = data0.AsUInt16();
                Vector256<ushort> temp1 = data1.AsUInt16();
                if (BitConverter.IsLittleEndian) {
                    rt0 = Vector256.Narrow(temp0, temp1);
                    return rt0;
                } else {
                    temp0 = Vector256.ShiftRightLogical(temp0, L);
                    temp1 = Vector256.ShiftRightLogical(temp1, L);
                    rt1 = Vector256.Narrow(temp0, temp1);
                    return rt1;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2UnzipEven_Narrow(Vector256<short> data0, Vector256<short> data1) {
                return YGroup2UnzipEven_Narrow(data0.AsUInt16(), data1.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2UnzipEven_Narrow(Vector256<ushort> data0, Vector256<ushort> data1) {
                const int L = 16;
                Vector256<ushort> rt0, rt1;
                Vector256<uint> temp0 = data0.AsUInt32();
                Vector256<uint> temp1 = data1.AsUInt32();
                if (BitConverter.IsLittleEndian) {
                    rt0 = Vector256.Narrow(temp0, temp1);
                    return rt0;
                } else {
                    temp0 = Vector256.ShiftRightLogical(temp0, L);
                    temp1 = Vector256.ShiftRightLogical(temp1, L);
                    rt1 = Vector256.Narrow(temp0, temp1);
                    return rt1;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2UnzipEven_Narrow(Vector256<int> data0, Vector256<int> data1) {
                return YGroup2UnzipEven_Narrow(data0.AsUInt32(), data1.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2UnzipEven_Narrow(Vector256<uint> data0, Vector256<uint> data1) {
                const int L = 32;
                Vector256<uint> rt0, rt1;
                Vector256<ulong> temp0 = data0.AsUInt64();
                Vector256<ulong> temp1 = data1.AsUInt64();
                if (BitConverter.IsLittleEndian) {
                    rt0 = Vector256.Narrow(temp0, temp1);
                    return rt0;
                } else {
                    temp0 = Vector256.ShiftRightLogical(temp0, L);
                    temp1 = Vector256.ShiftRightLogical(temp1, L);
                    rt1 = Vector256.Narrow(temp0, temp1);
                    return rt1;
                }
            }

#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2UnzipOdd_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt = TypeCodeFlagsUtil.Most32Types;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2UnzipOdd(Vector256<float> data0, Vector256<float> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2UnzipOdd_Narrow(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipOdd_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2UnzipOdd(Vector256<double> data0, Vector256<double> data1) {
                return YGroup2UnzipOdd_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2UnzipOdd(Vector256<sbyte> data0, Vector256<sbyte> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2UnzipOdd_Narrow(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipOdd_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2UnzipOdd(Vector256<byte> data0, Vector256<byte> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2UnzipOdd_Narrow(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipOdd_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2UnzipOdd(Vector256<short> data0, Vector256<short> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2UnzipOdd_Narrow(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipOdd_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2UnzipOdd(Vector256<ushort> data0, Vector256<ushort> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2UnzipOdd_Narrow(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipOdd_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2UnzipOdd(Vector256<int> data0, Vector256<int> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2UnzipOdd_Narrow(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipOdd_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2UnzipOdd(Vector256<uint> data0, Vector256<uint> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2UnzipOdd_Narrow(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipOdd_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup2UnzipOdd(Vector256<long> data0, Vector256<long> data1) {
                return YGroup2UnzipOdd_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup2UnzipOdd(Vector256<ulong> data0, Vector256<ulong> data1) {
                return YGroup2UnzipOdd_Basic(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{ExInt128}, Vector256{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExInt128> YGroup2UnzipOdd(Vector256<ExInt128> data0, Vector256<ExInt128> data1) {
                return YGroup2UnzipOdd(data0.ExAsExUInt128(), data1.ExAsExUInt128()).ExAsExInt128();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{ExUInt128}, Vector256{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExUInt128> YGroup2UnzipOdd(Vector256<ExUInt128> data0, Vector256<ExUInt128> data1) {
                var a0 = data0.ExAsUInt64();
                var a1 = data1.ExAsUInt64();
                var b1 = a0.GetUpper();
                var b3 = a1.GetUpper();
                var c1 = b1.ToVector256Unsafe().WithUpper(b3);
                return c1.ExAsExUInt128();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2UnzipOdd_Basic(Vector256<float> data0, Vector256<float> data1) {
                return YGroup2UnzipOdd_Basic(data0.AsUInt32(), data1.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2UnzipOdd_Basic(Vector256<double> data0, Vector256<double> data1) {
                return YGroup2UnzipOdd_Basic(data0.AsUInt64(), data1.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2UnzipOdd_Basic(Vector256<sbyte> data0, Vector256<sbyte> data1) {
                return YGroup2UnzipOdd_Basic(data0.AsByte(), data1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2UnzipOdd_Basic(Vector256<byte> data0, Vector256<byte> data1) {
                Unsafe.SkipInit(out Vector256<byte> y1);
                Span<Vector256<byte>> src = [data0, data1];
                ref byte py = ref Unsafe.As<Vector256<byte>, byte>(ref y1);
                Span<byte> p = MemoryMarshal.Cast<Vector256<byte>, byte>(src);
                int idx = 1;
                for (int i = 0; i < Vector256<byte>.Count; ++i) {
                    Unsafe.Add(ref py, i) = p[idx];
                    idx += 2;
                }
                return y1;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2UnzipOdd_Basic(Vector256<short> data0, Vector256<short> data1) {
                return YGroup2UnzipOdd_Basic(data0.AsUInt16(), data1.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2UnzipOdd_Basic(Vector256<ushort> data0, Vector256<ushort> data1) {
                Unsafe.SkipInit(out Vector256<ushort> y1);
                Span<Vector256<ushort>> src = [data0, data1];
                ref ushort py = ref Unsafe.As<Vector256<ushort>, ushort>(ref y1);
                Span<ushort> p = MemoryMarshal.Cast<Vector256<ushort>, ushort>(src);
                int idx = 1;
                for (int i = 0; i < Vector256<ushort>.Count; ++i) {
                    Unsafe.Add(ref py, i) = p[idx];
                    idx += 2;
                }
                return y1;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2UnzipOdd_Basic(Vector256<int> data0, Vector256<int> data1) {
                return YGroup2UnzipOdd_Basic(data0.AsUInt32(), data1.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2UnzipOdd_Basic(Vector256<uint> data0, Vector256<uint> data1) {
                Unsafe.SkipInit(out Vector256<uint> y1);
                Span<Vector256<uint>> src = [data0, data1];
                ref uint py = ref Unsafe.As<Vector256<uint>, uint>(ref y1);
                Span<uint> p = MemoryMarshal.Cast<Vector256<uint>, uint>(src);
                int idx = 1;
                for (int i = 0; i < Vector256<uint>.Count; ++i) {
                    Unsafe.Add(ref py, i) = p[idx];
                    idx += 2;
                }
                return y1;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup2UnzipOdd_Basic(Vector256<long> data0, Vector256<long> data1) {
                return YGroup2UnzipOdd_Basic(data0.AsUInt64(), data1.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup2UnzipOdd_Basic(Vector256<ulong> data0, Vector256<ulong> data1) {
                Unsafe.SkipInit(out Vector256<ulong> y1);
                Span<Vector256<ulong>> src = [data0, data1];
                ref ulong py = ref Unsafe.As<Vector256<ulong>, ulong>(ref y1);
                Span<ulong> p = MemoryMarshal.Cast<Vector256<ulong>, ulong>(src);
                int idx = 1;
                for (int i = 0; i < Vector256<ulong>.Count; ++i) {
                    Unsafe.Add(ref py, i) = p[idx];
                    idx += 2;
                }
                return y1;
            }

#if VECTOR_HAS_METHOD

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2UnzipOdd_Narrow(Vector256<float> data0, Vector256<float> data1) {
                return YGroup2UnzipOdd_Narrow(data0.AsUInt32(), data1.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2UnzipOdd_Narrow(Vector256<sbyte> data0, Vector256<sbyte> data1) {
                return YGroup2UnzipOdd_Narrow(data0.AsByte(), data1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2UnzipOdd_Narrow(Vector256<byte> data0, Vector256<byte> data1) {
                const int L = 8;
                Vector256<byte> rt0, rt1;
                Vector256<ushort> temp0 = data0.AsUInt16();
                Vector256<ushort> temp1 = data1.AsUInt16();
                if (BitConverter.IsLittleEndian) {
                    temp0 = Vector256.ShiftRightLogical(temp0, L);
                    temp1 = Vector256.ShiftRightLogical(temp1, L);
                    rt1 = Vector256.Narrow(temp0, temp1);
                    return rt1;
                } else {
                    rt0 = Vector256.Narrow(temp0, temp1);
                    return rt0;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2UnzipOdd_Narrow(Vector256<short> data0, Vector256<short> data1) {
                return YGroup2UnzipOdd_Narrow(data0.AsUInt16(), data1.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2UnzipOdd_Narrow(Vector256<ushort> data0, Vector256<ushort> data1) {
                const int L = 16;
                Vector256<ushort> rt0, rt1;
                Vector256<uint> temp0 = data0.AsUInt32();
                Vector256<uint> temp1 = data1.AsUInt32();
                if (BitConverter.IsLittleEndian) {
                    temp0 = Vector256.ShiftRightLogical(temp0, L);
                    temp1 = Vector256.ShiftRightLogical(temp1, L);
                    rt1 = Vector256.Narrow(temp0, temp1);
                    return rt1;
                } else {
                    rt0 = Vector256.Narrow(temp0, temp1);
                    return rt0;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2UnzipOdd_Narrow(Vector256<int> data0, Vector256<int> data1) {
                return YGroup2UnzipOdd_Narrow(data0.AsUInt32(), data1.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2UnzipOdd_Narrow(Vector256<uint> data0, Vector256<uint> data1) {
                const int L = 32;
                Vector256<uint> rt0, rt1;
                Vector256<ulong> temp0 = data0.AsUInt64();
                Vector256<ulong> temp1 = data1.AsUInt64();
                if (BitConverter.IsLittleEndian) {
                    temp0 = Vector256.ShiftRightLogical(temp0, L);
                    temp1 = Vector256.ShiftRightLogical(temp1, L);
                    rt1 = Vector256.Narrow(temp0, temp1);
                    return rt1;
                } else {
                    rt0 = Vector256.Narrow(temp0, temp1);
                    return rt0;
                }
            }

#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2Zip_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt = TypeCodeFlagsUtil.Most32Types;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{float}, Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2Zip(Vector256<float> x, Vector256<float> y, out Vector256<float> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2Zip_Widen(x, y, out data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Zip_Basic(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{double}, Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2Zip(Vector256<double> x, Vector256<double> y, out Vector256<double> data1) {
                return YGroup2Zip_Basic(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2Zip(Vector256<sbyte> x, Vector256<sbyte> y, out Vector256<sbyte> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2Zip_Widen(x, y, out data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Zip_Basic(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{byte}, Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2Zip(Vector256<byte> x, Vector256<byte> y, out Vector256<byte> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2Zip_Widen(x, y, out data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Zip_Basic(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{short}, Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2Zip(Vector256<short> x, Vector256<short> y, out Vector256<short> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2Zip_Widen(x, y, out data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Zip_Basic(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{ushort}, Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2Zip(Vector256<ushort> x, Vector256<ushort> y, out Vector256<ushort> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2Zip_Widen(x, y, out data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Zip_Basic(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{int}, Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2Zip(Vector256<int> x, Vector256<int> y, out Vector256<int> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2Zip_Widen(x, y, out data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Zip_Basic(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{uint}, Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2Zip(Vector256<uint> x, Vector256<uint> y, out Vector256<uint> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2Zip_Widen(x, y, out data1);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Zip_Basic(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{long}, Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup2Zip(Vector256<long> x, Vector256<long> y, out Vector256<long> data1) {
                return YGroup2Zip_Basic(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{ulong}, Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup2Zip(Vector256<ulong> x, Vector256<ulong> y, out Vector256<ulong> data1) {
                return YGroup2Zip_Basic(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{ExInt128}, Vector256{ExInt128}, out Vector256{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExInt128> YGroup2Zip(Vector256<ExInt128> x, Vector256<ExInt128> y, out Vector256<ExInt128> data1) {
                return YGroup2Zip_Move(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{ExUInt128}, Vector256{ExUInt128}, out Vector256{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExUInt128> YGroup2Zip(Vector256<ExUInt128> x, Vector256<ExUInt128> y, out Vector256<ExUInt128> data1) {
                return YGroup2Zip_Move(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip_Bit128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<T> YGroup2Zip_Bit128<T>(Vector256<T> x, Vector256<T> y, out Vector256<T> data1) where T : struct {
#if EX_APPLY_GENERIC
                var d0 = YGroup2Zip_Move(x.ExAsExUInt128(), y.ExAsExUInt128(), out var d1);
                data1 = d1.ExAs<ExUInt128, T>();
                return d0.ExAs<ExUInt128, T>();
#else
                var c0 = x.WithUpper(y.GetLower());
                var c1 = y.WithLower(x.GetUpper());
                data1 = c1;
                return c0;
#endif // EX_APPLY_GENERIC
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{float}, Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2Zip_Basic(Vector256<float> x, Vector256<float> y, out Vector256<float> data1) {
                var d0 = YGroup2Zip_Basic(x.AsUInt32(), y.AsUInt32(), out var d1);
                data1 = d1.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{double}, Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2Zip_Basic(Vector256<double> x, Vector256<double> y, out Vector256<double> data1) {
                var d0 = YGroup2Zip_Basic(x.AsUInt64(), y.AsUInt64(), out var d1);
                data1 = d1.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2Zip_Basic(Vector256<sbyte> x, Vector256<sbyte> y, out Vector256<sbyte> data1) {
                var d0 = YGroup2Zip_Basic(x.AsByte(), y.AsByte(), out var d1);
                data1 = d1.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{byte}, Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2Zip_Basic(Vector256<byte> x, Vector256<byte> y, out Vector256<byte> data1) {
                Span<Vector256<byte>> rt = stackalloc Vector256<byte>[2];
                ref byte px = ref Unsafe.As<Vector256<byte>, byte>(ref x);
                ref byte py = ref Unsafe.As<Vector256<byte>, byte>(ref y);
                Span<byte> q = MemoryMarshal.Cast<Vector256<byte>, byte>(rt);
                int idx = 0;
                for (int i = 0; i < Vector256<byte>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    idx += 2;
                }
                data1 = rt[1];
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{short}, Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2Zip_Basic(Vector256<short> x, Vector256<short> y, out Vector256<short> data1) {
                var d0 = YGroup2Zip_Basic(x.AsUInt16(), y.AsUInt16(), out var d1);
                data1 = d1.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{ushort}, Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2Zip_Basic(Vector256<ushort> x, Vector256<ushort> y, out Vector256<ushort> data1) {
                Span<Vector256<ushort>> rt = stackalloc Vector256<ushort>[2];
                ref ushort px = ref Unsafe.As<Vector256<ushort>, ushort>(ref x);
                ref ushort py = ref Unsafe.As<Vector256<ushort>, ushort>(ref y);
                Span<ushort> q = MemoryMarshal.Cast<Vector256<ushort>, ushort>(rt);
                int idx = 0;
                for (int i = 0; i < Vector256<ushort>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    idx += 2;
                }
                data1 = rt[1];
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{int}, Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2Zip_Basic(Vector256<int> x, Vector256<int> y, out Vector256<int> data1) {
                var d0 = YGroup2Zip_Basic(x.AsUInt32(), y.AsUInt32(), out var d1);
                data1 = d1.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{uint}, Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2Zip_Basic(Vector256<uint> x, Vector256<uint> y, out Vector256<uint> data1) {
                Span<Vector256<uint>> rt = stackalloc Vector256<uint>[2];
                ref uint px = ref Unsafe.As<Vector256<uint>, uint>(ref x);
                ref uint py = ref Unsafe.As<Vector256<uint>, uint>(ref y);
                Span<uint> q = MemoryMarshal.Cast<Vector256<uint>, uint>(rt);
                int idx = 0;
                for (int i = 0; i < Vector256<uint>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    idx += 2;
                }
                data1 = rt[1];
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{long}, Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup2Zip_Basic(Vector256<long> x, Vector256<long> y, out Vector256<long> data1) {
                var d0 = YGroup2Zip_Basic(x.AsUInt64(), y.AsUInt64(), out var d1);
                data1 = d1.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{ulong}, Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup2Zip_Basic(Vector256<ulong> x, Vector256<ulong> y, out Vector256<ulong> data1) {
                Span<Vector256<ulong>> rt = stackalloc Vector256<ulong>[2];
                ref ulong px = ref Unsafe.As<Vector256<ulong>, ulong>(ref x);
                ref ulong py = ref Unsafe.As<Vector256<ulong>, ulong>(ref y);
                Span<ulong> q = MemoryMarshal.Cast<Vector256<ulong>, ulong>(rt);
                int idx = 0;
                for (int i = 0; i < Vector256<ulong>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    idx += 2;
                }
                data1 = rt[1];
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{ExInt128}, Vector256{ExInt128}, out Vector256{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExInt128> YGroup2Zip_Basic(Vector256<ExInt128> x, Vector256<ExInt128> y, out Vector256<ExInt128> data1) {
                var d0 = YGroup2Zip_Basic(x.ExAsExUInt128(), y.ExAsExUInt128(), out var d1);
                data1 = d1.ExAsExInt128();
                return d0.ExAsExInt128();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{ExUInt128}, Vector256{ExUInt128}, out Vector256{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExUInt128> YGroup2Zip_Basic(Vector256<ExUInt128> x, Vector256<ExUInt128> y, out Vector256<ExUInt128> data1) {
                Span<Vector256<ExUInt128>> rt = stackalloc Vector256<ExUInt128>[2];
                ref ExUInt128 px = ref Unsafe.As<Vector256<ExUInt128>, ExUInt128>(ref x);
                ref ExUInt128 py = ref Unsafe.As<Vector256<ExUInt128>, ExUInt128>(ref y);
                Span<ExUInt128> q = MemoryMarshal.Cast<Vector256<ExUInt128>, ExUInt128>(rt);
                int idx = 0;
                for (int i = 0; i < Vector256s<ExUInt128>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    idx += 2;
                }
                data1 = rt[1];
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{ExInt128}, Vector256{ExInt128}, out Vector256{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExInt128> YGroup2Zip_Move(Vector256<ExInt128> x, Vector256<ExInt128> y, out Vector256<ExInt128> data1) {
                var d0 = YGroup2Zip_Move(x.ExAsExUInt128(), y.ExAsExUInt128(), out var d1);
                data1 = d1.ExAsExInt128();
                return d0.ExAsExInt128();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{ExUInt128}, Vector256{ExUInt128}, out Vector256{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExUInt128> YGroup2Zip_Move(Vector256<ExUInt128> x, Vector256<ExUInt128> y, out Vector256<ExUInt128> data1) {
                var a0 = x.ExAsUInt64();
                var a1 = y.ExAsUInt64();
                var c0 = a0.WithUpper(a1.GetLower());
                var c1 = a1.WithLower(a0.GetUpper());
                data1 = c1.ExAsExUInt128();
                return c0.ExAsExUInt128();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{ExInt128}, Vector256{ExInt128}, out Vector256{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExInt128> YGroup2Zip_Move2(Vector256<ExInt128> x, Vector256<ExInt128> y, out Vector256<ExInt128> data1) {
                var d0 = YGroup2Zip_Move2(x.ExAsExUInt128(), y.ExAsExUInt128(), out var d1);
                data1 = d1.ExAsExInt128();
                return d0.ExAsExInt128();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{ExUInt128}, Vector256{ExUInt128}, out Vector256{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExUInt128> YGroup2Zip_Move2(Vector256<ExUInt128> x, Vector256<ExUInt128> y, out Vector256<ExUInt128> data1) {
                var a0 = x.ExAsUInt64();
                var a1 = y.ExAsUInt64();
                var b0 = a0.GetLower();
                var b1 = a0.GetUpper();
                var b2 = a1.GetLower();
                var b3 = a1.GetUpper();
                var c0 = b0.ToVector256Unsafe().WithUpper(b2);
                var c1 = b1.ToVector256Unsafe().WithUpper(b3);
                data1 = c1.ExAsExUInt128();
                return c0.ExAsExUInt128();
            }

#if VECTOR_HAS_METHOD

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{float}, Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2Zip_Widen(Vector256<float> x, Vector256<float> y, out Vector256<float> data1) {
                var d0 = YGroup2Zip_Widen(x.AsUInt32(), y.AsUInt32(), out var d1);
                data1 = d1.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2Zip_Widen(Vector256<sbyte> x, Vector256<sbyte> y, out Vector256<sbyte> data1) {
                var d0 = YGroup2Zip_Widen(x.AsByte(), y.AsByte(), out var d1);
                data1 = d1.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{byte}, Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2Zip_Widen(Vector256<byte> x, Vector256<byte> y, out Vector256<byte> data1) {
                const int L = 8;
                Vector256<ushort> a0, a1, b0, b1;
                if (BitConverter.IsLittleEndian) {
                    (b0, b1) = Vector256.Widen(y);
                    (a0, a1) = Vector256.Widen(x);
                } else {
                    (b0, b1) = Vector256.Widen(x);
                    (a0, a1) = Vector256.Widen(y);
                }
                b0 = Vector256.ShiftLeft(b0, L);
                b1 = Vector256.ShiftLeft(b1, L);
                a0 = Vector256.BitwiseOr(a0, b0);
                a1 = Vector256.BitwiseOr(a1, b1);
                data1 = a1.AsByte();
                return a0.AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{short}, Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2Zip_Widen(Vector256<short> x, Vector256<short> y, out Vector256<short> data1) {
                var d0 = YGroup2Zip_Widen(x.AsUInt16(), y.AsUInt16(), out var d1);
                data1 = d1.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{ushort}, Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2Zip_Widen(Vector256<ushort> x, Vector256<ushort> y, out Vector256<ushort> data1) {
                const int L = 16;
                Vector256<uint> a0, a1, b0, b1;
                if (BitConverter.IsLittleEndian) {
                    (b0, b1) = Vector256.Widen(y);
                    (a0, a1) = Vector256.Widen(x);
                } else {
                    (b0, b1) = Vector256.Widen(x);
                    (a0, a1) = Vector256.Widen(y);
                }
                b0 = Vector256.ShiftLeft(b0, L);
                b1 = Vector256.ShiftLeft(b1, L);
                a0 = Vector256.BitwiseOr(a0, b0);
                a1 = Vector256.BitwiseOr(a1, b1);
                data1 = a1.AsUInt16();
                return a0.AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{int}, Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2Zip_Widen(Vector256<int> x, Vector256<int> y, out Vector256<int> data1) {
                var d0 = YGroup2Zip_Widen(x.AsUInt32(), y.AsUInt32(), out var d1);
                data1 = d1.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{uint}, Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2Zip_Widen(Vector256<uint> x, Vector256<uint> y, out Vector256<uint> data1) {
                const int L = 32;
                Vector256<ulong> a0, a1, b0, b1;
                if (BitConverter.IsLittleEndian) {
                    (b0, b1) = Vector256.Widen(y);
                    (a0, a1) = Vector256.Widen(x);
                } else {
                    (b0, b1) = Vector256.Widen(x);
                    (a0, a1) = Vector256.Widen(y);
                }
                b0 = Vector256.ShiftLeft(b0, L);
                b1 = Vector256.ShiftLeft(b1, L);
                a0 = Vector256.BitwiseOr(a0, b0);
                a1 = Vector256.BitwiseOr(a1, b1);
                data1 = a1.AsUInt32();
                return a0.AsUInt32();
            }

#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2ZipHigh_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt = TypeCodeFlagsUtil.Most32Types;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2ZipHigh(Vector256<float> x, Vector256<float> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2ZipHigh_Widen(x, y);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipHigh_Basic(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2ZipHigh(Vector256<double> x, Vector256<double> y) {
                return YGroup2ZipHigh_Basic(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2ZipHigh(Vector256<sbyte> x, Vector256<sbyte> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2ZipHigh_Widen(x, y);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipHigh_Basic(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2ZipHigh(Vector256<byte> x, Vector256<byte> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2ZipHigh_Widen(x, y);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipHigh_Basic(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2ZipHigh(Vector256<short> x, Vector256<short> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2ZipHigh_Widen(x, y);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipHigh_Basic(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2ZipHigh(Vector256<ushort> x, Vector256<ushort> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2ZipHigh_Widen(x, y);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipHigh_Basic(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2ZipHigh(Vector256<int> x, Vector256<int> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2ZipHigh_Widen(x, y);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipHigh_Basic(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2ZipHigh(Vector256<uint> x, Vector256<uint> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2ZipHigh_Widen(x, y);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipHigh_Basic(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup2ZipHigh(Vector256<long> x, Vector256<long> y) {
                return YGroup2ZipHigh_Basic(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup2ZipHigh(Vector256<ulong> x, Vector256<ulong> y) {
                return YGroup2ZipHigh_Basic(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{ExInt128}, Vector256{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExInt128> YGroup2ZipHigh(Vector256<ExInt128> x, Vector256<ExInt128> y) {
                return YGroup2ZipHigh(x.ExAsExUInt128(), y.ExAsExUInt128()).ExAsExInt128();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{ExUInt128}, Vector256{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExUInt128> YGroup2ZipHigh(Vector256<ExUInt128> x, Vector256<ExUInt128> y) {
                var a0 = x.ExAsUInt64();
                var a1 = y.ExAsUInt64();
                var b1 = a0.GetUpper();
                var b3 = a1.GetUpper();
                var c1 = b1.ToVector256Unsafe().WithUpper(b3);
                return c1.ExAsExUInt128();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2ZipHigh_Basic(Vector256<float> x, Vector256<float> y) {
                return YGroup2ZipHigh_Basic(x.AsUInt32(), y.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2ZipHigh_Basic(Vector256<double> x, Vector256<double> y) {
                return YGroup2ZipHigh_Basic(x.AsUInt64(), y.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2ZipHigh_Basic(Vector256<sbyte> x, Vector256<sbyte> y) {
                return YGroup2ZipHigh_Basic(x.AsByte(), y.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2ZipHigh_Basic(Vector256<byte> x, Vector256<byte> y) {
                Span<Vector256<byte>> rt = stackalloc Vector256<byte>[1];
                ref byte px = ref Unsafe.As<Vector256<byte>, byte>(ref x);
                ref byte py = ref Unsafe.As<Vector256<byte>, byte>(ref y);
                Span<byte> q = MemoryMarshal.Cast<Vector256<byte>, byte>(rt);
                int idx = 0;
                for (int i = Vector256<byte>.Count / 2; idx < Vector256<byte>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    idx += 2;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2ZipHigh_Basic(Vector256<short> x, Vector256<short> y) {
                return YGroup2ZipHigh_Basic(x.AsUInt16(), y.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2ZipHigh_Basic(Vector256<ushort> x, Vector256<ushort> y) {
                Span<Vector256<ushort>> rt = stackalloc Vector256<ushort>[1];
                ref ushort px = ref Unsafe.As<Vector256<ushort>, ushort>(ref x);
                ref ushort py = ref Unsafe.As<Vector256<ushort>, ushort>(ref y);
                Span<ushort> q = MemoryMarshal.Cast<Vector256<ushort>, ushort>(rt);
                int idx = 0;
                for (int i = Vector256<ushort>.Count / 2; idx < Vector256<ushort>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    idx += 2;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2ZipHigh_Basic(Vector256<int> x, Vector256<int> y) {
                return YGroup2ZipHigh_Basic(x.AsUInt32(), y.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2ZipHigh_Basic(Vector256<uint> x, Vector256<uint> y) {
                Span<Vector256<uint>> rt = stackalloc Vector256<uint>[1];
                ref uint px = ref Unsafe.As<Vector256<uint>, uint>(ref x);
                ref uint py = ref Unsafe.As<Vector256<uint>, uint>(ref y);
                Span<uint> q = MemoryMarshal.Cast<Vector256<uint>, uint>(rt);
                int idx = 0;
                for (int i = Vector256<uint>.Count / 2; idx < Vector256<uint>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    idx += 2;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup2ZipHigh_Basic(Vector256<long> x, Vector256<long> y) {
                return YGroup2ZipHigh_Basic(x.AsUInt64(), y.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup2ZipHigh_Basic(Vector256<ulong> x, Vector256<ulong> y) {
                Span<Vector256<ulong>> rt = stackalloc Vector256<ulong>[1];
                ref ulong px = ref Unsafe.As<Vector256<ulong>, ulong>(ref x);
                ref ulong py = ref Unsafe.As<Vector256<ulong>, ulong>(ref y);
                Span<ulong> q = MemoryMarshal.Cast<Vector256<ulong>, ulong>(rt);
                int idx = 0;
                for (int i = Vector256<ulong>.Count / 2; idx < Vector256<ulong>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    idx += 2;
                }
                return rt[0];
            }

#if VECTOR_HAS_METHOD

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2ZipHigh_Widen(Vector256<float> x, Vector256<float> y) {
                return YGroup2ZipHigh_Widen(x.AsUInt32(), y.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2ZipHigh_Widen(Vector256<sbyte> x, Vector256<sbyte> y) {
                return YGroup2ZipHigh_Widen(x.AsByte(), y.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2ZipHigh_Widen(Vector256<byte> x, Vector256<byte> y) {
                const int L = 8;
                Vector256<ushort> a1, b1;
                if (BitConverter.IsLittleEndian) {
                    (_, b1) = Vector256.Widen(y);
                    (_, a1) = Vector256.Widen(x);
                } else {
                    (_, b1) = Vector256.Widen(x);
                    (_, a1) = Vector256.Widen(y);
                }
                b1 = Vector256.ShiftLeft(b1, L);
                a1 = Vector256.BitwiseOr(a1, b1);
                return a1.AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2ZipHigh_Widen(Vector256<short> x, Vector256<short> y) {
                return YGroup2ZipHigh_Widen(x.AsUInt16(), y.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2ZipHigh_Widen(Vector256<ushort> x, Vector256<ushort> y) {
                const int L = 16;
                Vector256<uint> a1, b1;
                if (BitConverter.IsLittleEndian) {
                    (_, b1) = Vector256.Widen(y);
                    (_, a1) = Vector256.Widen(x);
                } else {
                    (_, b1) = Vector256.Widen(x);
                    (_, a1) = Vector256.Widen(y);
                }
                b1 = Vector256.ShiftLeft(b1, L);
                a1 = Vector256.BitwiseOr(a1, b1);
                return a1.AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2ZipHigh_Widen(Vector256<int> x, Vector256<int> y) {
                return YGroup2ZipHigh_Widen(x.AsUInt32(), y.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2ZipHigh_Widen(Vector256<uint> x, Vector256<uint> y) {
                const int L = 32;
                Vector256<ulong> a1, b1;
                if (BitConverter.IsLittleEndian) {
                    (_, b1) = Vector256.Widen(y);
                    (_, a1) = Vector256.Widen(x);
                } else {
                    (_, b1) = Vector256.Widen(x);
                    (_, a1) = Vector256.Widen(y);
                }
                b1 = Vector256.ShiftLeft(b1, L);
                a1 = Vector256.BitwiseOr(a1, b1);
                return a1.AsUInt32();
            }

#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2ZipLow_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt = TypeCodeFlagsUtil.Most32Types;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2ZipLow(Vector256<float> x, Vector256<float> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                return YGroup2ZipLow_Widen(x, y);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipLow_Basic(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2ZipLow(Vector256<double> x, Vector256<double> y) {
                return YGroup2ZipLow_Basic(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2ZipLow(Vector256<sbyte> x, Vector256<sbyte> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2ZipLow_Widen(x, y);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipLow_Basic(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2ZipLow(Vector256<byte> x, Vector256<byte> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2ZipLow_Widen(x, y);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipLow_Basic(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2ZipLow(Vector256<short> x, Vector256<short> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2ZipLow_Widen(x, y);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipLow_Basic(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2ZipLow(Vector256<ushort> x, Vector256<ushort> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2ZipLow_Widen(x, y);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipLow_Basic(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2ZipLow(Vector256<int> x, Vector256<int> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2ZipLow_Widen(x, y);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipLow_Basic(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2ZipLow(Vector256<uint> x, Vector256<uint> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup2ZipLow_Widen(x, y);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipLow_Basic(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup2ZipLow(Vector256<long> x, Vector256<long> y) {
                return YGroup2ZipLow_Basic(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup2ZipLow(Vector256<ulong> x, Vector256<ulong> y) {
                return YGroup2ZipLow_Basic(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{ExInt128}, Vector256{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExInt128> YGroup2ZipLow(Vector256<ExInt128> x, Vector256<ExInt128> y) {
                return YGroup2ZipLow(x.ExAsExUInt128(), y.ExAsExUInt128()).ExAsExInt128();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{ExUInt128}, Vector256{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExUInt128> YGroup2ZipLow(Vector256<ExUInt128> x, Vector256<ExUInt128> y) {
                var a0 = x.ExAsUInt64();
                var a1 = y.ExAsUInt64();
                var b0 = a0.GetLower();
                var b2 = a1.GetLower();
                var c0 = b0.ToVector256Unsafe().WithUpper(b2);
                return c0.ExAsExUInt128();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2ZipLow_Basic(Vector256<float> x, Vector256<float> y) {
                return YGroup2ZipLow_Basic(x.AsUInt32(), y.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2ZipLow_Basic(Vector256<double> x, Vector256<double> y) {
                return YGroup2ZipLow_Basic(x.AsUInt64(), y.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2ZipLow_Basic(Vector256<sbyte> x, Vector256<sbyte> y) {
                return YGroup2ZipLow_Basic(x.AsByte(), y.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2ZipLow_Basic(Vector256<byte> x, Vector256<byte> y) {
                Span<Vector256<byte>> rt = stackalloc Vector256<byte>[1];
                ref byte px = ref Unsafe.As<Vector256<byte>, byte>(ref x);
                ref byte py = ref Unsafe.As<Vector256<byte>, byte>(ref y);
                Span<byte> q = MemoryMarshal.Cast<Vector256<byte>, byte>(rt);
                int idx = 0;
                for (int i = 0; idx < Vector256<byte>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    idx += 2;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2ZipLow_Basic(Vector256<short> x, Vector256<short> y) {
                return YGroup2ZipLow_Basic(x.AsUInt16(), y.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2ZipLow_Basic(Vector256<ushort> x, Vector256<ushort> y) {
                Span<Vector256<ushort>> rt = stackalloc Vector256<ushort>[1];
                ref ushort px = ref Unsafe.As<Vector256<ushort>, ushort>(ref x);
                ref ushort py = ref Unsafe.As<Vector256<ushort>, ushort>(ref y);
                Span<ushort> q = MemoryMarshal.Cast<Vector256<ushort>, ushort>(rt);
                int idx = 0;
                for (int i = 0; idx < Vector256<ushort>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    idx += 2;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2ZipLow_Basic(Vector256<int> x, Vector256<int> y) {
                return YGroup2ZipLow_Basic(x.AsUInt32(), y.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2ZipLow_Basic(Vector256<uint> x, Vector256<uint> y) {
                Span<Vector256<uint>> rt = stackalloc Vector256<uint>[1];
                ref uint px = ref Unsafe.As<Vector256<uint>, uint>(ref x);
                ref uint py = ref Unsafe.As<Vector256<uint>, uint>(ref y);
                Span<uint> q = MemoryMarshal.Cast<Vector256<uint>, uint>(rt);
                int idx = 0;
                for (int i = 0; idx < Vector256<uint>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    idx += 2;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup2ZipLow_Basic(Vector256<long> x, Vector256<long> y) {
                return YGroup2ZipLow_Basic(x.AsUInt64(), y.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup2ZipLow_Basic(Vector256<ulong> x, Vector256<ulong> y) {
                Span<Vector256<ulong>> rt = stackalloc Vector256<ulong>[1];
                ref ulong px = ref Unsafe.As<Vector256<ulong>, ulong>(ref x);
                ref ulong py = ref Unsafe.As<Vector256<ulong>, ulong>(ref y);
                Span<ulong> q = MemoryMarshal.Cast<Vector256<ulong>, ulong>(rt);
                int idx = 0;
                for (int i = 0; idx < Vector256<ulong>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    idx += 2;
                }
                return rt[0];
            }

#if VECTOR_HAS_METHOD

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2ZipLow_Widen(Vector256<float> x, Vector256<float> y) {
                return YGroup2ZipLow_Widen(x.AsUInt32(), y.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2ZipLow_Widen(Vector256<sbyte> x, Vector256<sbyte> y) {
                return YGroup2ZipLow_Widen(x.AsByte(), y.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2ZipLow_Widen(Vector256<byte> x, Vector256<byte> y) {
                const int L = 8;
                Vector256<ushort> a0, b0;
                if (BitConverter.IsLittleEndian) {
                    (b0, _) = Vector256.Widen(y);
                    (a0, _) = Vector256.Widen(x);
                } else {
                    (b0, _) = Vector256.Widen(x);
                    (a0, _) = Vector256.Widen(y);
                }
                b0 = Vector256.ShiftLeft(b0, L);
                a0 = Vector256.BitwiseOr(a0, b0);
                return a0.AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2ZipLow_Widen(Vector256<short> x, Vector256<short> y) {
                return YGroup2ZipLow_Widen(x.AsUInt16(), y.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2ZipLow_Widen(Vector256<ushort> x, Vector256<ushort> y) {
                const int L = 16;
                Vector256<uint> a0, b0;
                if (BitConverter.IsLittleEndian) {
                    (b0, _) = Vector256.Widen(y);
                    (a0, _) = Vector256.Widen(x);
                } else {
                    (b0, _) = Vector256.Widen(x);
                    (a0, _) = Vector256.Widen(y);
                }
                b0 = Vector256.ShiftLeft(b0, L);
                a0 = Vector256.BitwiseOr(a0, b0);
                return a0.AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2ZipLow_Widen(Vector256<int> x, Vector256<int> y) {
                return YGroup2ZipLow_Widen(x.AsUInt32(), y.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2ZipLow_Widen(Vector256<uint> x, Vector256<uint> y) {
                const int L = 32;
                Vector256<ulong> a0, b0;
                if (BitConverter.IsLittleEndian) {
                    (b0, _) = Vector256.Widen(y);
                    (a0, _) = Vector256.Widen(x);
                } else {
                    (b0, _) = Vector256.Widen(x);
                    (a0, _) = Vector256.Widen(y);
                }
                b0 = Vector256.ShiftLeft(b0, L);
                a0 = Vector256.BitwiseOr(a0, b0);
                return a0.AsUInt32();
            }

#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits256.YGroup3ToGroup4_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup3ToGroup4_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt = TypeCodeFlags.Byte | TypeCodeFlags.SByte;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ToGroup4(Vector256{float}, Vector256{float}, Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup3ToGroup4(Vector256<float> data0, Vector256<float> data1, Vector256<float> data2, out Vector256<float> result1, out Vector256<float> result2, out Vector256<float> result3) {
                var d0 = YGroup3ToGroup4(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), out var d1, out var d2, out var d3);
                result1 = d1.AsSingle();
                result2 = d2.AsSingle();
                result3 = d3.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ToGroup4(Vector256{double}, Vector256{double}, Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup3ToGroup4(Vector256<double> data0, Vector256<double> data1, Vector256<double> data2, out Vector256<double> result1, out Vector256<double> result2, out Vector256<double> result3) {
                var d0 = YGroup3ToGroup4(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), out var d1, out var d2, out var d3);
                result1 = d1.AsDouble();
                result2 = d2.AsDouble();
                result3 = d3.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ToGroup4(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup3ToGroup4(Vector256<sbyte> data0, Vector256<sbyte> data1, Vector256<sbyte> data2, out Vector256<sbyte> result1, out Vector256<sbyte> result2, out Vector256<sbyte> result3) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup3ToGroup4_Unzip(data0, data1, data2, out result1, out result2, out result3);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3ToGroup4_Basic(data0, data1, data2, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ToGroup4(Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup3ToGroup4(Vector256<byte> data0, Vector256<byte> data1, Vector256<byte> data2, out Vector256<byte> result1, out Vector256<byte> result2, out Vector256<byte> result3) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup3ToGroup4_Unzip(data0, data1, data2, out result1, out result2, out result3);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3ToGroup4_Basic(data0, data1, data2, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ToGroup4(Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup3ToGroup4(Vector256<short> data0, Vector256<short> data1, Vector256<short> data2, out Vector256<short> result1, out Vector256<short> result2, out Vector256<short> result3) {
                return YGroup3ToGroup4_Basic(data0, data1, data2, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ToGroup4(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup3ToGroup4(Vector256<ushort> data0, Vector256<ushort> data1, Vector256<ushort> data2, out Vector256<ushort> result1, out Vector256<ushort> result2, out Vector256<ushort> result3) {
                return YGroup3ToGroup4_Basic(data0, data1, data2, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ToGroup4(Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup3ToGroup4(Vector256<int> data0, Vector256<int> data1, Vector256<int> data2, out Vector256<int> result1, out Vector256<int> result2, out Vector256<int> result3) {
                return YGroup3ToGroup4_Basic(data0, data1, data2, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ToGroup4(Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup3ToGroup4(Vector256<uint> data0, Vector256<uint> data1, Vector256<uint> data2, out Vector256<uint> result1, out Vector256<uint> result2, out Vector256<uint> result3) {
                return YGroup3ToGroup4_Basic(data0, data1, data2, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ToGroup4(Vector256{long}, Vector256{long}, Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup3ToGroup4(Vector256<long> data0, Vector256<long> data1, Vector256<long> data2, out Vector256<long> result1, out Vector256<long> result2, out Vector256<long> result3) {
                return YGroup3ToGroup4_Basic(data0, data1, data2, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ToGroup4(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup3ToGroup4(Vector256<ulong> data0, Vector256<ulong> data1, Vector256<ulong> data2, out Vector256<ulong> result1, out Vector256<ulong> result2, out Vector256<ulong> result3) {
                return YGroup3ToGroup4_Basic(data0, data1, data2, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ToGroup4(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup3ToGroup4_Basic(Vector256<sbyte> data0, Vector256<sbyte> data1, Vector256<sbyte> data2, out Vector256<sbyte> result1, out Vector256<sbyte> result2, out Vector256<sbyte> result3) {
                var d0 = YGroup3ToGroup4_Basic(data0.AsByte(), data1.AsByte(), data2.AsByte(), out var d1, out var d2, out var d3);
                result1 = d1.AsSByte();
                result2 = d2.AsSByte();
                result3 = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ToGroup4(Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup3ToGroup4_Basic(Vector256<byte> data0, Vector256<byte> data1, Vector256<byte> data2, out Vector256<byte> result1, out Vector256<byte> result2, out Vector256<byte> result3) {
                const byte zero = 0;
                Span<Vector256<byte>> src = [data0, data1, data2];
                Span<Vector256<byte>> dst = stackalloc Vector256<byte>[4];
                Span<byte> p = MemoryMarshal.Cast<Vector256<byte>, byte>(src);
                Span<byte> q = MemoryMarshal.Cast<Vector256<byte>, byte>(dst);
                for (int i = 0; i < Vector256<byte>.Count; ++i) {
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ToGroup4(Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup3ToGroup4_Basic(Vector256<short> data0, Vector256<short> data1, Vector256<short> data2, out Vector256<short> result1, out Vector256<short> result2, out Vector256<short> result3) {
                var d0 = YGroup3ToGroup4_Basic(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), out var d1, out var d2, out var d3);
                result1 = d1.AsInt16();
                result2 = d2.AsInt16();
                result3 = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ToGroup4(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup3ToGroup4_Basic(Vector256<ushort> data0, Vector256<ushort> data1, Vector256<ushort> data2, out Vector256<ushort> result1, out Vector256<ushort> result2, out Vector256<ushort> result3) {
                const ushort zero = 0;
                Span<Vector256<ushort>> src = [data0, data1, data2];
                Span<Vector256<ushort>> dst = stackalloc Vector256<ushort>[4];
                Span<ushort> p = MemoryMarshal.Cast<Vector256<ushort>, ushort>(src);
                Span<ushort> q = MemoryMarshal.Cast<Vector256<ushort>, ushort>(dst);
                for (int i = 0; i < Vector256<ushort>.Count; ++i) {
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ToGroup4(Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup3ToGroup4_Basic(Vector256<int> data0, Vector256<int> data1, Vector256<int> data2, out Vector256<int> result1, out Vector256<int> result2, out Vector256<int> result3) {
                var d0 = YGroup3ToGroup4_Basic(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), out var d1, out var d2, out var d3);
                result1 = d1.AsInt32();
                result2 = d2.AsInt32();
                result3 = d3.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ToGroup4(Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup3ToGroup4_Basic(Vector256<uint> data0, Vector256<uint> data1, Vector256<uint> data2, out Vector256<uint> result1, out Vector256<uint> result2, out Vector256<uint> result3) {
                const uint zero = 0;
                Span<Vector256<uint>> src = [data0, data1, data2];
                Span<Vector256<uint>> dst = stackalloc Vector256<uint>[4];
                Span<uint> p = MemoryMarshal.Cast<Vector256<uint>, uint>(src);
                Span<uint> q = MemoryMarshal.Cast<Vector256<uint>, uint>(dst);
                for (int i = 0; i < Vector256<uint>.Count; ++i) {
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ToGroup4(Vector256{long}, Vector256{long}, Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup3ToGroup4_Basic(Vector256<long> data0, Vector256<long> data1, Vector256<long> data2, out Vector256<long> result1, out Vector256<long> result2, out Vector256<long> result3) {
                var d0 = YGroup3ToGroup4_Basic(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), out var d1, out var d2, out var d3);
                result1 = d1.AsInt64();
                result2 = d2.AsInt64();
                result3 = d3.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ToGroup4(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup3ToGroup4_Basic(Vector256<ulong> data0, Vector256<ulong> data1, Vector256<ulong> data2, out Vector256<ulong> result1, out Vector256<ulong> result2, out Vector256<ulong> result3) {
                const ulong zero = 0;
                Span<Vector256<ulong>> src = [data0, data1, data2];
                Span<Vector256<ulong>> dst = stackalloc Vector256<ulong>[4];
                Span<ulong> p = MemoryMarshal.Cast<Vector256<ulong>, ulong>(src);
                Span<ulong> q = MemoryMarshal.Cast<Vector256<ulong>, ulong>(dst);
                for (int i = 0; i < Vector256<ulong>.Count; ++i) {
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ToGroup4(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup3ToGroup4_Shuffle(Vector256<sbyte> data0, Vector256<sbyte> data1, Vector256<sbyte> data2, out Vector256<sbyte> result1, out Vector256<sbyte> result2, out Vector256<sbyte> result3) {
                var d0 = YGroup3ToGroup4_Shuffle(data0.AsByte(), data1.AsByte(), data2.AsByte(), out var d1, out var d2, out var d3);
                result1 = d1.AsSByte();
                result2 = d2.AsSByte();
                result3 = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ToGroup4(Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup3ToGroup4_Shuffle(Vector256<byte> data0, Vector256<byte> data1, Vector256<byte> data2, out Vector256<byte> result1, out Vector256<byte> result2, out Vector256<byte> result3) {
                var maskXYZ = Vector256Constants.YGroup4_MaskXYZ_Byte;
                var f0 = Vector256Constants.YGroup3ToGroup4_Shuffle_Byte_0;
                var f1A = Vector256Constants.YGroup3ToGroup4_Shuffle_Byte_1A;
                var f1B = Vector256Constants.YGroup3ToGroup4_Shuffle_Byte_1B;
                var f2A = Vector256Constants.YGroup3ToGroup4_Shuffle_Byte_2A;
                var f2B = Vector256Constants.YGroup3ToGroup4_Shuffle_Byte_2B;
                var f3 = Vector256Constants.YGroup3ToGroup4_Shuffle_Byte_3;
                var a_0 = Vector256.BitwiseAnd(Vector256.Shuffle(data0, f0), maskXYZ);
                var a_1 = Vector256.BitwiseAnd(Vector256.BitwiseOr(Vector256.Shuffle(data0, f1A), Vector256.Shuffle(data1, f1B)), maskXYZ);
                var a_2 = Vector256.BitwiseAnd(Vector256.BitwiseOr(Vector256.Shuffle(data1, f2A), Vector256.Shuffle(data2, f2B)), maskXYZ);
                var a_3 = Vector256.BitwiseAnd(Vector256.Shuffle(data2, f3), maskXYZ);
                result1 = a_1;
                result2 = a_2;
                result3 = a_3;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ToGroup4(Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup3ToGroup4_Shuffle(Vector256<short> data0, Vector256<short> data1, Vector256<short> data2, out Vector256<short> result1, out Vector256<short> result2, out Vector256<short> result3) {
                var d0 = YGroup3ToGroup4_Shuffle(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), out var d1, out var d2, out var d3);
                result1 = d1.AsInt16();
                result2 = d2.AsInt16();
                result3 = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ToGroup4(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup3ToGroup4_Shuffle(Vector256<ushort> data0, Vector256<ushort> data1, Vector256<ushort> data2, out Vector256<ushort> result1, out Vector256<ushort> result2, out Vector256<ushort> result3) {
                var maskXYZ = Vector256Constants.YGroup4_MaskXYZ_UInt16;
                var f0 = Vector256Constants.YGroup3ToGroup4_ShuffleOnByte_UInt16_0;
                var f1A = Vector256Constants.YGroup3ToGroup4_ShuffleOnByte_UInt16_1A;
                var f1B = Vector256Constants.YGroup3ToGroup4_ShuffleOnByte_UInt16_1B;
                var f2A = Vector256Constants.YGroup3ToGroup4_ShuffleOnByte_UInt16_2A;
                var f2B = Vector256Constants.YGroup3ToGroup4_ShuffleOnByte_UInt16_2B;
                var f3 = Vector256Constants.YGroup3ToGroup4_ShuffleOnByte_UInt16_3;
                var s0 = data0.AsByte();
                var s1 = data1.AsByte();
                var s2 = data2.AsByte();
                var a_0 = Vector256.BitwiseAnd(Vector256.Shuffle(s0, f0).AsUInt16(), maskXYZ);
                var a_1 = Vector256.BitwiseAnd(Vector256.BitwiseOr(Vector256.Shuffle(s0, f1A), Vector256.Shuffle(s1, f1B)).AsUInt16(), maskXYZ);
                var a_2 = Vector256.BitwiseAnd(Vector256.BitwiseOr(Vector256.Shuffle(s1, f2A), Vector256.Shuffle(s2, f2B)).AsUInt16(), maskXYZ);
                var a_3 = Vector256.BitwiseAnd(Vector256.Shuffle(s2, f3).AsUInt16(), maskXYZ);
                result1 = a_1;
                result2 = a_2;
                result3 = a_3;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ToGroup4(Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup3ToGroup4_Shuffle(Vector256<int> data0, Vector256<int> data1, Vector256<int> data2, out Vector256<int> result1, out Vector256<int> result2, out Vector256<int> result3) {
                var d0 = YGroup3ToGroup4_Shuffle(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), out var d1, out var d2, out var d3);
                result1 = d1.AsInt32();
                result2 = d2.AsInt32();
                result3 = d3.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ToGroup4(Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup3ToGroup4_Shuffle(Vector256<uint> data0, Vector256<uint> data1, Vector256<uint> data2, out Vector256<uint> result1, out Vector256<uint> result2, out Vector256<uint> result3) {
                var maskXYZ = Vector256Constants.YGroup4_MaskXYZ_UInt32;
                var f0 = Vector256Constants.YGroup3ToGroup4_ShuffleOnByte_UInt32_0;
                var f1A = Vector256Constants.YGroup3ToGroup4_ShuffleOnByte_UInt32_1A;
                var f1B = Vector256Constants.YGroup3ToGroup4_ShuffleOnByte_UInt32_1B;
                var f2A = Vector256Constants.YGroup3ToGroup4_ShuffleOnByte_UInt32_2A;
                var f2B = Vector256Constants.YGroup3ToGroup4_ShuffleOnByte_UInt32_2B;
                var f3 = Vector256Constants.YGroup3ToGroup4_ShuffleOnByte_UInt32_3;
                var s0 = data0.AsByte();
                var s1 = data1.AsByte();
                var s2 = data2.AsByte();
                var a_0 = Vector256.BitwiseAnd(Vector256.Shuffle(s0, f0).AsUInt32(), maskXYZ);
                var a_1 = Vector256.BitwiseAnd(Vector256.BitwiseOr(Vector256.Shuffle(s0, f1A), Vector256.Shuffle(s1, f1B)).AsUInt32(), maskXYZ);
                var a_2 = Vector256.BitwiseAnd(Vector256.BitwiseOr(Vector256.Shuffle(s1, f2A), Vector256.Shuffle(s2, f2B)).AsUInt32(), maskXYZ);
                var a_3 = Vector256.BitwiseAnd(Vector256.Shuffle(s2, f3).AsUInt32(), maskXYZ);
                result1 = a_1;
                result2 = a_2;
                result3 = a_3;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ToGroup4(Vector256{long}, Vector256{long}, Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup3ToGroup4_Shuffle(Vector256<long> data0, Vector256<long> data1, Vector256<long> data2, out Vector256<long> result1, out Vector256<long> result2, out Vector256<long> result3) {
                var d0 = YGroup3ToGroup4_Shuffle(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), out var d1, out var d2, out var d3);
                result1 = d1.AsInt64();
                result2 = d2.AsInt64();
                result3 = d3.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ToGroup4(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup3ToGroup4_Shuffle(Vector256<ulong> data0, Vector256<ulong> data1, Vector256<ulong> data2, out Vector256<ulong> result1, out Vector256<ulong> result2, out Vector256<ulong> result3) {
                var maskXYZ = Vector256Constants.YGroup4_MaskXYZ_UInt64;
                var f1A = Vector256Constants.YGroup3ToGroup4_ShuffleOnByte_UInt64_1A;
                var f1B = Vector256Constants.YGroup3ToGroup4_ShuffleOnByte_UInt64_1B;
                var f2A = Vector256Constants.YGroup3ToGroup4_ShuffleOnByte_UInt64_2A;
                var f2B = Vector256Constants.YGroup3ToGroup4_ShuffleOnByte_UInt64_2B;
                var f3 = Vector256Constants.YGroup3ToGroup4_ShuffleOnByte_UInt64_3;
                var s0 = data0.AsByte();
                var s1 = data1.AsByte();
                var s2 = data2.AsByte();
                var a_0 = Vector256.BitwiseAnd(data0, maskXYZ);
                var a_1 = Vector256.BitwiseAnd(Vector256.BitwiseOr(Vector256.Shuffle(s0, f1A), Vector256.Shuffle(s1, f1B)).AsUInt64(), maskXYZ);
                var a_2 = Vector256.BitwiseAnd(Vector256.BitwiseOr(Vector256.Shuffle(s1, f2A), Vector256.Shuffle(s2, f2B)).AsUInt64(), maskXYZ);
                var a_3 = Vector256.BitwiseAnd(Vector256.Shuffle(s2, f3).AsUInt64(), maskXYZ);
                result1 = a_1;
                result2 = a_2;
                result3 = a_3;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ToGroup4(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup3ToGroup4_Unzip(Vector256<sbyte> data0, Vector256<sbyte> data1, Vector256<sbyte> data2, out Vector256<sbyte> result1, out Vector256<sbyte> result2, out Vector256<sbyte> result3) {
                var d0 = YGroup3ToGroup4_Unzip(data0.AsByte(), data1.AsByte(), data2.AsByte(), out var d1, out var d2, out var d3);
                result1 = d1.AsSByte();
                result2 = d2.AsSByte();
                result3 = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ToGroup4(Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup3ToGroup4_Unzip(Vector256<byte> data0, Vector256<byte> data1, Vector256<byte> data2, out Vector256<byte> result1, out Vector256<byte> result2, out Vector256<byte> result3) {
                var a_3 = Vector256<byte>.Zero;
                var a_0 = YGroup3Unzip(data0, data1, data2, out var a_1, out var a_2);
                var b_0 = YGroup4Zip(a_0, a_1, a_2, a_3, out var b_1, out var b_2, out var b_3);
                result1 = b_1;
                result2 = b_2;
                result3 = b_3;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ToGroup4(Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup3ToGroup4_Unzip(Vector256<short> data0, Vector256<short> data1, Vector256<short> data2, out Vector256<short> result1, out Vector256<short> result2, out Vector256<short> result3) {
                var d0 = YGroup3ToGroup4_Unzip(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), out var d1, out var d2, out var d3);
                result1 = d1.AsInt16();
                result2 = d2.AsInt16();
                result3 = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ToGroup4(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup3ToGroup4_Unzip(Vector256<ushort> data0, Vector256<ushort> data1, Vector256<ushort> data2, out Vector256<ushort> result1, out Vector256<ushort> result2, out Vector256<ushort> result3) {
                var a_3 = Vector256<ushort>.Zero;
                var a_0 = YGroup3Unzip(data0, data1, data2, out var a_1, out var a_2);
                var b_0 = YGroup4Zip(a_0, a_1, a_2, a_3, out var b_1, out var b_2, out var b_3);
                result1 = b_1;
                result2 = b_2;
                result3 = b_3;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ToGroup4(Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup3ToGroup4_Unzip(Vector256<int> data0, Vector256<int> data1, Vector256<int> data2, out Vector256<int> result1, out Vector256<int> result2, out Vector256<int> result3) {
                var d0 = YGroup3ToGroup4_Unzip(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), out var d1, out var d2, out var d3);
                result1 = d1.AsInt32();
                result2 = d2.AsInt32();
                result3 = d3.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ToGroup4(Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup3ToGroup4_Unzip(Vector256<uint> data0, Vector256<uint> data1, Vector256<uint> data2, out Vector256<uint> result1, out Vector256<uint> result2, out Vector256<uint> result3) {
                var a_3 = Vector256<uint>.Zero;
                var a_0 = YGroup3Unzip(data0, data1, data2, out var a_1, out var a_2);
                var b_0 = YGroup4Zip(a_0, a_1, a_2, a_3, out var b_1, out var b_2, out var b_3);
                result1 = b_1;
                result2 = b_2;
                result3 = b_3;
                return b_0;
            }

#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup3Unzip_AcceleratedTypes {
                get {
                    return YGroup2Zip_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{float}, Vector256{float}, Vector256{float}, out Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup3Unzip(Vector256<float> data0, Vector256<float> data1, Vector256<float> data2, out Vector256<float> y, out Vector256<float> z) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3Unzip_ByShorter(data0, data1, data2, out y, out z);
#else
                return YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{double}, Vector256{double}, Vector256{double}, out Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup3Unzip(Vector256<double> data0, Vector256<double> data1, Vector256<double> data2, out Vector256<double> y, out Vector256<double> z) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3Unzip_ByShorter(data0, data1, data2, out y, out z);
#else
                return YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup3Unzip(Vector256<sbyte> data0, Vector256<sbyte> data1, Vector256<sbyte> data2, out Vector256<sbyte> y, out Vector256<sbyte> z) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3Unzip_ByShorter(data0, data1, data2, out y, out z);
#else
                return YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup3Unzip(Vector256<byte> data0, Vector256<byte> data1, Vector256<byte> data2, out Vector256<byte> y, out Vector256<byte> z) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3Unzip_ByShorter(data0, data1, data2, out y, out z);
#else
                return YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup3Unzip(Vector256<short> data0, Vector256<short> data1, Vector256<short> data2, out Vector256<short> y, out Vector256<short> z) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3Unzip_ByShorter(data0, data1, data2, out y, out z);
#else
                return YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup3Unzip(Vector256<ushort> data0, Vector256<ushort> data1, Vector256<ushort> data2, out Vector256<ushort> y, out Vector256<ushort> z) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3Unzip_ByShorter(data0, data1, data2, out y, out z);
#else
                return YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup3Unzip(Vector256<int> data0, Vector256<int> data1, Vector256<int> data2, out Vector256<int> y, out Vector256<int> z) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3Unzip_ByShorter(data0, data1, data2, out y, out z);
#else
                return YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup3Unzip(Vector256<uint> data0, Vector256<uint> data1, Vector256<uint> data2, out Vector256<uint> y, out Vector256<uint> z) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3Unzip_ByShorter(data0, data1, data2, out y, out z);
#else
                return YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{long}, Vector256{long}, Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup3Unzip(Vector256<long> data0, Vector256<long> data1, Vector256<long> data2, out Vector256<long> y, out Vector256<long> z) {
                return YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup3Unzip(Vector256<ulong> data0, Vector256<ulong> data1, Vector256<ulong> data2, out Vector256<ulong> y, out Vector256<ulong> z) {
                return YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip_Bit128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<T> YGroup3Unzip_Bit128<T>(Vector256<T> data0, Vector256<T> data1, Vector256<T> data2, out Vector256<T> y, out Vector256<T> z) where T : struct {
                var c0 = data0.WithUpper(data1.GetUpper());
                var c1 = data0.GetUpper().ToVector256Unsafe().WithUpper(data2.GetLower());
                var c2 = data1.WithUpper(data2.GetUpper());
                y = c1;
                z = c2;
                return c0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{float}, Vector256{float}, Vector256{float}, out Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup3Unzip_Basic(Vector256<float> data0, Vector256<float> data1, Vector256<float> data2, out Vector256<float> y, out Vector256<float> z) {
                var d0 = YGroup3Unzip_Basic(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), out var d1, out var d2);
                y = d1.AsSingle();
                z = d2.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{double}, Vector256{double}, Vector256{double}, out Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup3Unzip_Basic(Vector256<double> data0, Vector256<double> data1, Vector256<double> data2, out Vector256<double> y, out Vector256<double> z) {
                var d0 = YGroup3Unzip_Basic(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), out var d1, out var d2);
                y = d1.AsDouble();
                z = d2.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup3Unzip_Basic(Vector256<sbyte> data0, Vector256<sbyte> data1, Vector256<sbyte> data2, out Vector256<sbyte> y, out Vector256<sbyte> z) {
                var d0 = YGroup3Unzip_Basic(data0.AsByte(), data1.AsByte(), data2.AsByte(), out var d1, out var d2);
                y = d1.AsSByte();
                z = d2.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup3Unzip_Basic(Vector256<byte> data0, Vector256<byte> data1, Vector256<byte> data2, out Vector256<byte> y, out Vector256<byte> z) {
                Unsafe.SkipInit(out Vector256<byte> x1);
                Unsafe.SkipInit(out Vector256<byte> y1);
                Unsafe.SkipInit(out Vector256<byte> z1);
                Span<Vector256<byte>> src = [data0, data1, data2];
                ref byte px = ref Unsafe.As<Vector256<byte>, byte>(ref x1);
                ref byte py = ref Unsafe.As<Vector256<byte>, byte>(ref y1);
                ref byte pz = ref Unsafe.As<Vector256<byte>, byte>(ref z1);
                Span<byte> p = MemoryMarshal.Cast<Vector256<byte>, byte>(src);
                int idx = 0;
                for (int i = 0; i < Vector256<byte>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    Unsafe.Add(ref py, i) = p[idx + 1];
                    Unsafe.Add(ref pz, i) = p[idx + 2];
                    idx += 3;
                }
                y = y1;
                z = z1;
                return x1;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup3Unzip_Basic(Vector256<short> data0, Vector256<short> data1, Vector256<short> data2, out Vector256<short> y, out Vector256<short> z) {
                var d0 = YGroup3Unzip_Basic(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), out var d1, out var d2);
                y = d1.AsInt16();
                z = d2.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup3Unzip_Basic(Vector256<ushort> data0, Vector256<ushort> data1, Vector256<ushort> data2, out Vector256<ushort> y, out Vector256<ushort> z) {
                Unsafe.SkipInit(out Vector256<ushort> x1);
                Unsafe.SkipInit(out Vector256<ushort> y1);
                Unsafe.SkipInit(out Vector256<ushort> z1);
                Span<Vector256<ushort>> src = [data0, data1, data2];
                ref ushort px = ref Unsafe.As<Vector256<ushort>, ushort>(ref x1);
                ref ushort py = ref Unsafe.As<Vector256<ushort>, ushort>(ref y1);
                ref ushort pz = ref Unsafe.As<Vector256<ushort>, ushort>(ref z1);
                Span<ushort> p = MemoryMarshal.Cast<Vector256<ushort>, ushort>(src);
                int idx = 0;
                for (int i = 0; i < Vector256<ushort>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    Unsafe.Add(ref py, i) = p[idx + 1];
                    Unsafe.Add(ref pz, i) = p[idx + 2];
                    idx += 3;
                }
                y = y1;
                z = z1;
                return x1;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup3Unzip_Basic(Vector256<int> data0, Vector256<int> data1, Vector256<int> data2, out Vector256<int> y, out Vector256<int> z) {
                var d0 = YGroup3Unzip_Basic(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), out var d1, out var d2);
                y = d1.AsInt32();
                z = d2.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup3Unzip_Basic(Vector256<uint> data0, Vector256<uint> data1, Vector256<uint> data2, out Vector256<uint> y, out Vector256<uint> z) {
                Unsafe.SkipInit(out Vector256<uint> x1);
                Unsafe.SkipInit(out Vector256<uint> y1);
                Unsafe.SkipInit(out Vector256<uint> z1);
                Span<Vector256<uint>> src = [data0, data1, data2];
                ref uint px = ref Unsafe.As<Vector256<uint>, uint>(ref x1);
                ref uint py = ref Unsafe.As<Vector256<uint>, uint>(ref y1);
                ref uint pz = ref Unsafe.As<Vector256<uint>, uint>(ref z1);
                Span<uint> p = MemoryMarshal.Cast<Vector256<uint>, uint>(src);
                int idx = 0;
                for (int i = 0; i < Vector256<uint>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    Unsafe.Add(ref py, i) = p[idx + 1];
                    Unsafe.Add(ref pz, i) = p[idx + 2];
                    idx += 3;
                }
                y = y1;
                z = z1;
                return x1;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{long}, Vector256{long}, Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup3Unzip_Basic(Vector256<long> data0, Vector256<long> data1, Vector256<long> data2, out Vector256<long> y, out Vector256<long> z) {
                var d0 = YGroup3Unzip_Basic(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), out var d1, out var d2);
                y = d1.AsInt64();
                z = d2.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup3Unzip_Basic(Vector256<ulong> data0, Vector256<ulong> data1, Vector256<ulong> data2, out Vector256<ulong> y, out Vector256<ulong> z) {
                Unsafe.SkipInit(out Vector256<ulong> x1);
                Unsafe.SkipInit(out Vector256<ulong> y1);
                Unsafe.SkipInit(out Vector256<ulong> z1);
                Span<Vector256<ulong>> src = [data0, data1, data2];
                ref ulong px = ref Unsafe.As<Vector256<ulong>, ulong>(ref x1);
                ref ulong py = ref Unsafe.As<Vector256<ulong>, ulong>(ref y1);
                ref ulong pz = ref Unsafe.As<Vector256<ulong>, ulong>(ref z1);
                Span<ulong> p = MemoryMarshal.Cast<Vector256<ulong>, ulong>(src);
                int idx = 0;
                for (int i = 0; i < Vector256<ulong>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    Unsafe.Add(ref py, i) = p[idx + 1];
                    Unsafe.Add(ref pz, i) = p[idx + 2];
                    idx += 3;
                }
                y = y1;
                z = z1;
                return x1;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{float}, Vector256{float}, Vector256{float}, out Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup3Unzip_ByShorter(Vector256<float> data0, Vector256<float> data1, Vector256<float> data2, out Vector256<float> y, out Vector256<float> z) {
                var b0 = ShorterStatics.YGroup3UnzipX2(data0.GetLower(), data0.GetUpper(), data1.GetLower(), data1.GetUpper(), data2.GetLower(), data2.GetUpper(), out var b1, out var b2, out var b3, out var b4, out var b5);
                var c0 = b0.ToVector256Unsafe().WithUpper(b1);
                var c1 = b2.ToVector256Unsafe().WithUpper(b3);
                var c2 = b4.ToVector256Unsafe().WithUpper(b5);
                y = c1;
                z = c2;
                return c0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{double}, Vector256{double}, Vector256{double}, out Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup3Unzip_ByShorter(Vector256<double> data0, Vector256<double> data1, Vector256<double> data2, out Vector256<double> y, out Vector256<double> z) {
                var b0 = ShorterStatics.YGroup3UnzipX2(data0.GetLower(), data0.GetUpper(), data1.GetLower(), data1.GetUpper(), data2.GetLower(), data2.GetUpper(), out var b1, out var b2, out var b3, out var b4, out var b5);
                var c0 = b0.ToVector256Unsafe().WithUpper(b1);
                var c1 = b2.ToVector256Unsafe().WithUpper(b3);
                var c2 = b4.ToVector256Unsafe().WithUpper(b5);
                y = c1;
                z = c2;
                return c0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup3Unzip_ByShorter(Vector256<sbyte> data0, Vector256<sbyte> data1, Vector256<sbyte> data2, out Vector256<sbyte> y, out Vector256<sbyte> z) {
                var b0 = ShorterStatics.YGroup3UnzipX2(data0.GetLower(), data0.GetUpper(), data1.GetLower(), data1.GetUpper(), data2.GetLower(), data2.GetUpper(), out var b1, out var b2, out var b3, out var b4, out var b5);
                var c0 = b0.ToVector256Unsafe().WithUpper(b1);
                var c1 = b2.ToVector256Unsafe().WithUpper(b3);
                var c2 = b4.ToVector256Unsafe().WithUpper(b5);
                y = c1;
                z = c2;
                return c0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup3Unzip_ByShorter(Vector256<byte> data0, Vector256<byte> data1, Vector256<byte> data2, out Vector256<byte> y, out Vector256<byte> z) {
                var b0 = ShorterStatics.YGroup3UnzipX2(data0.GetLower(), data0.GetUpper(), data1.GetLower(), data1.GetUpper(), data2.GetLower(), data2.GetUpper(), out var b1, out var b2, out var b3, out var b4, out var b5);
                var c0 = b0.ToVector256Unsafe().WithUpper(b1);
                var c1 = b2.ToVector256Unsafe().WithUpper(b3);
                var c2 = b4.ToVector256Unsafe().WithUpper(b5);
                y = c1;
                z = c2;
                return c0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup3Unzip_ByShorter(Vector256<short> data0, Vector256<short> data1, Vector256<short> data2, out Vector256<short> y, out Vector256<short> z) {
                var b0 = ShorterStatics.YGroup3UnzipX2(data0.GetLower(), data0.GetUpper(), data1.GetLower(), data1.GetUpper(), data2.GetLower(), data2.GetUpper(), out var b1, out var b2, out var b3, out var b4, out var b5);
                var c0 = b0.ToVector256Unsafe().WithUpper(b1);
                var c1 = b2.ToVector256Unsafe().WithUpper(b3);
                var c2 = b4.ToVector256Unsafe().WithUpper(b5);
                y = c1;
                z = c2;
                return c0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup3Unzip_ByShorter(Vector256<ushort> data0, Vector256<ushort> data1, Vector256<ushort> data2, out Vector256<ushort> y, out Vector256<ushort> z) {
                var b0 = ShorterStatics.YGroup3UnzipX2(data0.GetLower(), data0.GetUpper(), data1.GetLower(), data1.GetUpper(), data2.GetLower(), data2.GetUpper(), out var b1, out var b2, out var b3, out var b4, out var b5);
                var c0 = b0.ToVector256Unsafe().WithUpper(b1);
                var c1 = b2.ToVector256Unsafe().WithUpper(b3);
                var c2 = b4.ToVector256Unsafe().WithUpper(b5);
                y = c1;
                z = c2;
                return c0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup3Unzip_ByShorter(Vector256<int> data0, Vector256<int> data1, Vector256<int> data2, out Vector256<int> y, out Vector256<int> z) {
                var b0 = ShorterStatics.YGroup3UnzipX2(data0.GetLower(), data0.GetUpper(), data1.GetLower(), data1.GetUpper(), data2.GetLower(), data2.GetUpper(), out var b1, out var b2, out var b3, out var b4, out var b5);
                var c0 = b0.ToVector256Unsafe().WithUpper(b1);
                var c1 = b2.ToVector256Unsafe().WithUpper(b3);
                var c2 = b4.ToVector256Unsafe().WithUpper(b5);
                y = c1;
                z = c2;
                return c0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup3Unzip_ByShorter(Vector256<uint> data0, Vector256<uint> data1, Vector256<uint> data2, out Vector256<uint> y, out Vector256<uint> z) {
                var b0 = ShorterStatics.YGroup3UnzipX2(data0.GetLower(), data0.GetUpper(), data1.GetLower(), data1.GetUpper(), data2.GetLower(), data2.GetUpper(), out var b1, out var b2, out var b3, out var b4, out var b5);
                var c0 = b0.ToVector256Unsafe().WithUpper(b1);
                var c1 = b2.ToVector256Unsafe().WithUpper(b3);
                var c2 = b4.ToVector256Unsafe().WithUpper(b5);
                y = c1;
                z = c2;
                return c0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{long}, Vector256{long}, Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup3Unzip_ByShorter(Vector256<long> data0, Vector256<long> data1, Vector256<long> data2, out Vector256<long> y, out Vector256<long> z) {
                var b0 = ShorterStatics.YGroup3UnzipX2(data0.GetLower(), data0.GetUpper(), data1.GetLower(), data1.GetUpper(), data2.GetLower(), data2.GetUpper(), out var b1, out var b2, out var b3, out var b4, out var b5);
                var c0 = b0.ToVector256Unsafe().WithUpper(b1);
                var c1 = b2.ToVector256Unsafe().WithUpper(b3);
                var c2 = b4.ToVector256Unsafe().WithUpper(b5);
                y = c1;
                z = c2;
                return c0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup3Unzip_ByShorter(Vector256<ulong> data0, Vector256<ulong> data1, Vector256<ulong> data2, out Vector256<ulong> y, out Vector256<ulong> z) {
                var b0 = ShorterStatics.YGroup3UnzipX2(data0.GetLower(), data0.GetUpper(), data1.GetLower(), data1.GetUpper(), data2.GetLower(), data2.GetUpper(), out var b1, out var b2, out var b3, out var b4, out var b5);
                var c0 = b0.ToVector256Unsafe().WithUpper(b1);
                var c1 = b2.ToVector256Unsafe().WithUpper(b3);
                var c2 = b4.ToVector256Unsafe().WithUpper(b5);
                y = c1;
                z = c2;
                return c0;
            }

#if VECTOR_HAS_METHOD

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{float}, Vector256{float}, Vector256{float}, out Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup3Unzip_ByX2Zip(Vector256<float> data0, Vector256<float> data1, Vector256<float> data2, out Vector256<float> y, out Vector256<float> z) {
                return YGroup3UnzipX2_Zip(data0, data1, data2, data0, data1, data2, out _, out y, out _, out z, out _);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup3Unzip_ByX2Zip(Vector256<sbyte> data0, Vector256<sbyte> data1, Vector256<sbyte> data2, out Vector256<sbyte> y, out Vector256<sbyte> z) {
                return YGroup3UnzipX2_Zip(data0, data1, data2, data0, data1, data2, out _, out y, out _, out z, out _);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup3Unzip_ByX2Zip(Vector256<byte> data0, Vector256<byte> data1, Vector256<byte> data2, out Vector256<byte> y, out Vector256<byte> z) {
                return YGroup3UnzipX2_Zip(data0, data1, data2, data0, data1, data2, out _, out y, out _, out z, out _);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup3Unzip_ByX2Zip(Vector256<short> data0, Vector256<short> data1, Vector256<short> data2, out Vector256<short> y, out Vector256<short> z) {
                return YGroup3UnzipX2_Zip(data0, data1, data2, data0, data1, data2, out _, out y, out _, out z, out _);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup3Unzip_ByX2Zip(Vector256<ushort> data0, Vector256<ushort> data1, Vector256<ushort> data2, out Vector256<ushort> y, out Vector256<ushort> z) {
                return YGroup3UnzipX2_Zip(data0, data1, data2, data0, data1, data2, out _, out y, out _, out z, out _);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup3Unzip_ByX2Zip(Vector256<int> data0, Vector256<int> data1, Vector256<int> data2, out Vector256<int> y, out Vector256<int> z) {
                return YGroup3UnzipX2_Zip(data0, data1, data2, data0, data1, data2, out _, out y, out _, out z, out _);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup3Unzip_ByX2Zip(Vector256<uint> data0, Vector256<uint> data1, Vector256<uint> data2, out Vector256<uint> y, out Vector256<uint> z) {
                return YGroup3UnzipX2_Zip(data0, data1, data2, data0, data1, data2, out _, out y, out _, out z, out _);
            }

#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup3UnzipX2_AcceleratedTypes {
                get {
                    return YGroup2Zip_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup3UnzipX2(Vector256<float> data0, Vector256<float> data1, Vector256<float> data2, Vector256<float> data3, Vector256<float> data4, Vector256<float> data5, out Vector256<float> xB, out Vector256<float> y, out Vector256<float> yB, out Vector256<float> z, out Vector256<float> zB) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup3UnzipX2_Zip(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3UnzipX2_X2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup3UnzipX2(Vector256<double> data0, Vector256<double> data1, Vector256<double> data2, Vector256<double> data3, Vector256<double> data4, Vector256<double> data5, out Vector256<double> xB, out Vector256<double> y, out Vector256<double> yB, out Vector256<double> z, out Vector256<double> zB) {
                return YGroup3UnzipX2_X2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup3UnzipX2(Vector256<sbyte> data0, Vector256<sbyte> data1, Vector256<sbyte> data2, Vector256<sbyte> data3, Vector256<sbyte> data4, Vector256<sbyte> data5, out Vector256<sbyte> xB, out Vector256<sbyte> y, out Vector256<sbyte> yB, out Vector256<sbyte> z, out Vector256<sbyte> zB) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup3UnzipX2_Zip(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3UnzipX2_X2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup3UnzipX2(Vector256<byte> data0, Vector256<byte> data1, Vector256<byte> data2, Vector256<byte> data3, Vector256<byte> data4, Vector256<byte> data5, out Vector256<byte> xB, out Vector256<byte> y, out Vector256<byte> yB, out Vector256<byte> z, out Vector256<byte> zB) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup3UnzipX2_Zip(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3UnzipX2_X2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup3UnzipX2(Vector256<short> data0, Vector256<short> data1, Vector256<short> data2, Vector256<short> data3, Vector256<short> data4, Vector256<short> data5, out Vector256<short> xB, out Vector256<short> y, out Vector256<short> yB, out Vector256<short> z, out Vector256<short> zB) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup3UnzipX2_Zip(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3UnzipX2_X2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup3UnzipX2(Vector256<ushort> data0, Vector256<ushort> data1, Vector256<ushort> data2, Vector256<ushort> data3, Vector256<ushort> data4, Vector256<ushort> data5, out Vector256<ushort> xB, out Vector256<ushort> y, out Vector256<ushort> yB, out Vector256<ushort> z, out Vector256<ushort> zB) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup3UnzipX2_Zip(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3UnzipX2_X2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup3UnzipX2(Vector256<int> data0, Vector256<int> data1, Vector256<int> data2, Vector256<int> data3, Vector256<int> data4, Vector256<int> data5, out Vector256<int> xB, out Vector256<int> y, out Vector256<int> yB, out Vector256<int> z, out Vector256<int> zB) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup3UnzipX2_Zip(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3UnzipX2_X2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup3UnzipX2(Vector256<uint> data0, Vector256<uint> data1, Vector256<uint> data2, Vector256<uint> data3, Vector256<uint> data4, Vector256<uint> data5, out Vector256<uint> xB, out Vector256<uint> y, out Vector256<uint> yB, out Vector256<uint> z, out Vector256<uint> zB) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup3UnzipX2_Zip(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3UnzipX2_X2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup3UnzipX2(Vector256<long> data0, Vector256<long> data1, Vector256<long> data2, Vector256<long> data3, Vector256<long> data4, Vector256<long> data5, out Vector256<long> xB, out Vector256<long> y, out Vector256<long> yB, out Vector256<long> z, out Vector256<long> zB) {
                return YGroup3UnzipX2_X2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup3UnzipX2(Vector256<ulong> data0, Vector256<ulong> data1, Vector256<ulong> data2, Vector256<ulong> data3, Vector256<ulong> data4, Vector256<ulong> data5, out Vector256<ulong> xB, out Vector256<ulong> y, out Vector256<ulong> yB, out Vector256<ulong> z, out Vector256<ulong> zB) {
                return YGroup3UnzipX2_X2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2_Bit128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<T> YGroup3UnzipX2_Bit128<T>(Vector256<T> data0, Vector256<T> data1, Vector256<T> data2, Vector256<T> data3, Vector256<T> data4, Vector256<T> data5, out Vector256<T> xB, out Vector256<T> y, out Vector256<T> yB, out Vector256<T> z, out Vector256<T> zB) where T : struct {
                var x = YGroup3Unzip_Bit128(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip_Bit128(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup3UnzipX2_Basic(Vector256<float> data0, Vector256<float> data1, Vector256<float> data2, Vector256<float> data3, Vector256<float> data4, Vector256<float> data5, out Vector256<float> xB, out Vector256<float> y, out Vector256<float> yB, out Vector256<float> z, out Vector256<float> zB) {
                var x = YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip_Basic(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup3UnzipX2_Basic(Vector256<double> data0, Vector256<double> data1, Vector256<double> data2, Vector256<double> data3, Vector256<double> data4, Vector256<double> data5, out Vector256<double> xB, out Vector256<double> y, out Vector256<double> yB, out Vector256<double> z, out Vector256<double> zB) {
                var x = YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip_Basic(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup3UnzipX2_Basic(Vector256<sbyte> data0, Vector256<sbyte> data1, Vector256<sbyte> data2, Vector256<sbyte> data3, Vector256<sbyte> data4, Vector256<sbyte> data5, out Vector256<sbyte> xB, out Vector256<sbyte> y, out Vector256<sbyte> yB, out Vector256<sbyte> z, out Vector256<sbyte> zB) {
                var x = YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip_Basic(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup3UnzipX2_Basic(Vector256<byte> data0, Vector256<byte> data1, Vector256<byte> data2, Vector256<byte> data3, Vector256<byte> data4, Vector256<byte> data5, out Vector256<byte> xB, out Vector256<byte> y, out Vector256<byte> yB, out Vector256<byte> z, out Vector256<byte> zB) {
                var x = YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip_Basic(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup3UnzipX2_Basic(Vector256<short> data0, Vector256<short> data1, Vector256<short> data2, Vector256<short> data3, Vector256<short> data4, Vector256<short> data5, out Vector256<short> xB, out Vector256<short> y, out Vector256<short> yB, out Vector256<short> z, out Vector256<short> zB) {
                var x = YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip_Basic(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup3UnzipX2_Basic(Vector256<ushort> data0, Vector256<ushort> data1, Vector256<ushort> data2, Vector256<ushort> data3, Vector256<ushort> data4, Vector256<ushort> data5, out Vector256<ushort> xB, out Vector256<ushort> y, out Vector256<ushort> yB, out Vector256<ushort> z, out Vector256<ushort> zB) {
                var x = YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip_Basic(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup3UnzipX2_Basic(Vector256<int> data0, Vector256<int> data1, Vector256<int> data2, Vector256<int> data3, Vector256<int> data4, Vector256<int> data5, out Vector256<int> xB, out Vector256<int> y, out Vector256<int> yB, out Vector256<int> z, out Vector256<int> zB) {
                var x = YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip_Basic(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup3UnzipX2_Basic(Vector256<uint> data0, Vector256<uint> data1, Vector256<uint> data2, Vector256<uint> data3, Vector256<uint> data4, Vector256<uint> data5, out Vector256<uint> xB, out Vector256<uint> y, out Vector256<uint> yB, out Vector256<uint> z, out Vector256<uint> zB) {
                var x = YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip_Basic(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup3UnzipX2_Basic(Vector256<long> data0, Vector256<long> data1, Vector256<long> data2, Vector256<long> data3, Vector256<long> data4, Vector256<long> data5, out Vector256<long> xB, out Vector256<long> y, out Vector256<long> yB, out Vector256<long> z, out Vector256<long> zB) {
                var x = YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip_Basic(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup3UnzipX2_Basic(Vector256<ulong> data0, Vector256<ulong> data1, Vector256<ulong> data2, Vector256<ulong> data3, Vector256<ulong> data4, Vector256<ulong> data5, out Vector256<ulong> xB, out Vector256<ulong> y, out Vector256<ulong> yB, out Vector256<ulong> z, out Vector256<ulong> zB) {
                var x = YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip_Basic(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup3UnzipX2_X2(Vector256<float> data0, Vector256<float> data1, Vector256<float> data2, Vector256<float> data3, Vector256<float> data4, Vector256<float> data5, out Vector256<float> xB, out Vector256<float> y, out Vector256<float> yB, out Vector256<float> z, out Vector256<float> zB) {
                var x = YGroup3Unzip(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup3UnzipX2_X2(Vector256<double> data0, Vector256<double> data1, Vector256<double> data2, Vector256<double> data3, Vector256<double> data4, Vector256<double> data5, out Vector256<double> xB, out Vector256<double> y, out Vector256<double> yB, out Vector256<double> z, out Vector256<double> zB) {
                var x = YGroup3Unzip(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup3UnzipX2_X2(Vector256<sbyte> data0, Vector256<sbyte> data1, Vector256<sbyte> data2, Vector256<sbyte> data3, Vector256<sbyte> data4, Vector256<sbyte> data5, out Vector256<sbyte> xB, out Vector256<sbyte> y, out Vector256<sbyte> yB, out Vector256<sbyte> z, out Vector256<sbyte> zB) {
                var x = YGroup3Unzip(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup3UnzipX2_X2(Vector256<byte> data0, Vector256<byte> data1, Vector256<byte> data2, Vector256<byte> data3, Vector256<byte> data4, Vector256<byte> data5, out Vector256<byte> xB, out Vector256<byte> y, out Vector256<byte> yB, out Vector256<byte> z, out Vector256<byte> zB) {
                var x = YGroup3Unzip(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup3UnzipX2_X2(Vector256<short> data0, Vector256<short> data1, Vector256<short> data2, Vector256<short> data3, Vector256<short> data4, Vector256<short> data5, out Vector256<short> xB, out Vector256<short> y, out Vector256<short> yB, out Vector256<short> z, out Vector256<short> zB) {
                var x = YGroup3Unzip(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup3UnzipX2_X2(Vector256<ushort> data0, Vector256<ushort> data1, Vector256<ushort> data2, Vector256<ushort> data3, Vector256<ushort> data4, Vector256<ushort> data5, out Vector256<ushort> xB, out Vector256<ushort> y, out Vector256<ushort> yB, out Vector256<ushort> z, out Vector256<ushort> zB) {
                var x = YGroup3Unzip(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup3UnzipX2_X2(Vector256<int> data0, Vector256<int> data1, Vector256<int> data2, Vector256<int> data3, Vector256<int> data4, Vector256<int> data5, out Vector256<int> xB, out Vector256<int> y, out Vector256<int> yB, out Vector256<int> z, out Vector256<int> zB) {
                var x = YGroup3Unzip(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup3UnzipX2_X2(Vector256<uint> data0, Vector256<uint> data1, Vector256<uint> data2, Vector256<uint> data3, Vector256<uint> data4, Vector256<uint> data5, out Vector256<uint> xB, out Vector256<uint> y, out Vector256<uint> yB, out Vector256<uint> z, out Vector256<uint> zB) {
                var x = YGroup3Unzip(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup3UnzipX2_X2(Vector256<long> data0, Vector256<long> data1, Vector256<long> data2, Vector256<long> data3, Vector256<long> data4, Vector256<long> data5, out Vector256<long> xB, out Vector256<long> y, out Vector256<long> yB, out Vector256<long> z, out Vector256<long> zB) {
                var x = YGroup3Unzip(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup3UnzipX2_X2(Vector256<ulong> data0, Vector256<ulong> data1, Vector256<ulong> data2, Vector256<ulong> data3, Vector256<ulong> data4, Vector256<ulong> data5, out Vector256<ulong> xB, out Vector256<ulong> y, out Vector256<ulong> yB, out Vector256<ulong> z, out Vector256<ulong> zB) {
                var x = YGroup3Unzip(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip(data3, data4, data5, out yB, out zB);
                return x;
            }

#if VECTOR_HAS_METHOD

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup3UnzipX2_Zip(Vector256<float> data0, Vector256<float> data1, Vector256<float> data2, Vector256<float> data3, Vector256<float> data4, Vector256<float> data5, out Vector256<float> xB, out Vector256<float> y, out Vector256<float> yB, out Vector256<float> z, out Vector256<float> zB) {
                var d0 = YGroup3UnzipX2_Zip(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), data4.AsUInt32(), data5.AsUInt32(), out var d1, out var d2, out var d3, out var d4, out var d5);
                xB = d1.AsSingle();
                y = d2.AsSingle();
                yB = d3.AsSingle();
                z = d4.AsSingle();
                zB = d5.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup3UnzipX2_Zip(Vector256<sbyte> data0, Vector256<sbyte> data1, Vector256<sbyte> data2, Vector256<sbyte> data3, Vector256<sbyte> data4, Vector256<sbyte> data5, out Vector256<sbyte> xB, out Vector256<sbyte> y, out Vector256<sbyte> yB, out Vector256<sbyte> z, out Vector256<sbyte> zB) {
                var d0 = YGroup3UnzipX2_Zip(data0.AsByte(), data1.AsByte(), data2.AsByte(), data3.AsByte(), data4.AsByte(), data5.AsByte(), out var d1, out var d2, out var d3, out var d4, out var d5);
                xB = d1.AsSByte();
                y = d2.AsSByte();
                yB = d3.AsSByte();
                z = d4.AsSByte();
                zB = d5.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup3UnzipX2_Zip(Vector256<byte> data0, Vector256<byte> data1, Vector256<byte> data2, Vector256<byte> data3, Vector256<byte> data4, Vector256<byte> data5, out Vector256<byte> xB, out Vector256<byte> y, out Vector256<byte> yB, out Vector256<byte> z, out Vector256<byte> zB) {
                Vector256<byte> a_0, a_1, a_2, a_3, a_4, a_5, b_0, b_1, b_2, b_3, b_4, b_5;
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup3UnzipX2_Zip(Vector256<short> data0, Vector256<short> data1, Vector256<short> data2, Vector256<short> data3, Vector256<short> data4, Vector256<short> data5, out Vector256<short> xB, out Vector256<short> y, out Vector256<short> yB, out Vector256<short> z, out Vector256<short> zB) {
                var d0 = YGroup3UnzipX2_Zip(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), data3.AsUInt16(), data4.AsUInt16(), data5.AsUInt16(), out var d1, out var d2, out var d3, out var d4, out var d5);
                xB = d1.AsInt16();
                y = d2.AsInt16();
                yB = d3.AsInt16();
                z = d4.AsInt16();
                zB = d5.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup3UnzipX2_Zip(Vector256<ushort> data0, Vector256<ushort> data1, Vector256<ushort> data2, Vector256<ushort> data3, Vector256<ushort> data4, Vector256<ushort> data5, out Vector256<ushort> xB, out Vector256<ushort> y, out Vector256<ushort> yB, out Vector256<ushort> z, out Vector256<ushort> zB) {
                Vector256<ushort> a_0, a_1, a_2, a_3, a_4, a_5, b_0, b_1, b_2, b_3, b_4, b_5;
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup3UnzipX2_Zip(Vector256<int> data0, Vector256<int> data1, Vector256<int> data2, Vector256<int> data3, Vector256<int> data4, Vector256<int> data5, out Vector256<int> xB, out Vector256<int> y, out Vector256<int> yB, out Vector256<int> z, out Vector256<int> zB) {
                var d0 = YGroup3UnzipX2_Zip(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), data4.AsUInt32(), data5.AsUInt32(), out var d1, out var d2, out var d3, out var d4, out var d5);
                xB = d1.AsInt32();
                y = d2.AsInt32();
                yB = d3.AsInt32();
                z = d4.AsInt32();
                zB = d5.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup3UnzipX2_Zip(Vector256<uint> data0, Vector256<uint> data1, Vector256<uint> data2, Vector256<uint> data3, Vector256<uint> data4, Vector256<uint> data5, out Vector256<uint> xB, out Vector256<uint> y, out Vector256<uint> yB, out Vector256<uint> z, out Vector256<uint> zB) {
                Vector256<uint> a_0, a_1, a_2, a_3, a_4, a_5, b_0, b_1, b_2, b_3, b_4, b_5;
                // 0 data0 x0 y0 z0 x1 y1 z1 x2 y2 data1 z2 x3 y3 z3 x4 y4 z4 x5 data2 y5 z5 x6 y6 z6 x7 y7 z7 data3 x8 y8 z8 x9 y9 z9 x10 y10 data4 z10 x11 y11 z11 x12 y12 z12 x13 data5 y13 z13 x14 y14 z14 x15 y15 z15
                // 1 a_0 x0 x8 y0 y8 z0 z8 x1 x9 a_1 y1 y9 z1 z9 x2 x10 y2 y10 a_2 z2 z10 x3 x11 y3 y11 z3 z11 a_3 x4 x12 y4 y12 z4 z12 x5 x13 a_4 y5 y13 z5 z13 x6 x14 y6 y14 a_5 z6 z14 x7 x15 y7 y15 z7 z15
                a_0 = YGroup2Zip(data0, data3, out a_1);
                a_2 = YGroup2Zip(data1, data4, out a_3);
                a_4 = YGroup2Zip(data2, data5, out a_5);
                // 2 b_0 x0 x4 x8 x12 y0 y4 y8 y12 b_1 z0 z4 z8 z12 x1 x5 x9 x13 b_2 y1 y5 y9 y13 z1 z5 z9 z13 b_3 x2 x6 x10 x14 y2 y6 y10 y14 b_4 z2 z6 z10 z14 x3 x7 x11 x15 b_5 y3 y7 y11 y15 z3 z7 z11 z15
                b_0 = YGroup2Zip(a_0, a_3, out b_1);
                b_2 = YGroup2Zip(a_1, a_4, out b_3);
                b_4 = YGroup2Zip(a_2, a_5, out b_5);
                // 3 a_0 x0 x2 x4 x6 x8 x10 x12 x14 a_1 y0 y2 y4 y6 y8 y10 y12 y14 a_2 z0 z2 z4 z6 z8 z10 z12 z14 a_3 x1 x3 x5 x7 x9 x11 x13 x15 a_4 y1 y3 y5 y7 y9 y11 y13 y15 a_5 z1 z3 z5 z7 z9 z11 z13 z15
                a_0 = YGroup2Zip(b_0, b_3, out a_1);
                a_2 = YGroup2Zip(b_1, b_4, out a_3);
                a_4 = YGroup2Zip(b_2, b_5, out a_5);
                // 4 b_0 x0 x1 x2 x3 x4 x5 x6 x7 b_1 x8 x9 x10 x11 x12 x13 x14 x15 b_2 y0 y1 y2 y3 y4 y5 y6 y7 b_3 y8 y9 y10 y11 y12 y13 y14 y15 b_4 z0 z1 z2 z3 z4 z5 z6 z7 b_5 z8 z9 z10 z11 z12 z13 z14 z15
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

#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits256.YGroup3Zip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup3Zip_AcceleratedTypes {
                get {
                    return YGroup2Unzip_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Zip(Vector256{float}, Vector256{float}, Vector256{float}, out Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup3Zip(Vector256<float> x, Vector256<float> y, Vector256<float> z, out Vector256<float> data1, out Vector256<float> data2) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3Zip_ByShorter(x, y, z, out data1, out data2);
#else
                return YGroup3Zip_Basic(x, y, z, out data1, out data2);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Zip(Vector256{double}, Vector256{double}, Vector256{double}, out Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup3Zip(Vector256<double> x, Vector256<double> y, Vector256<double> z, out Vector256<double> data1, out Vector256<double> data2) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3Zip_ByShorter(x, y, z, out data1, out data2);
#else
                return YGroup3Zip_Basic(x, y, z, out data1, out data2);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Zip(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup3Zip(Vector256<sbyte> x, Vector256<sbyte> y, Vector256<sbyte> z, out Vector256<sbyte> data1, out Vector256<sbyte> data2) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3Zip_ByShorter(x, y, z, out data1, out data2);
#else
                return YGroup3Zip_Basic(x, y, z, out data1, out data2);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Zip(Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup3Zip(Vector256<byte> x, Vector256<byte> y, Vector256<byte> z, out Vector256<byte> data1, out Vector256<byte> data2) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3Zip_ByShorter(x, y, z, out data1, out data2);
#else
                return YGroup3Zip_Basic(x, y, z, out data1, out data2);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Zip(Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup3Zip(Vector256<short> x, Vector256<short> y, Vector256<short> z, out Vector256<short> data1, out Vector256<short> data2) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3Zip_ByShorter(x, y, z, out data1, out data2);
#else
                return YGroup3Zip_Basic(x, y, z, out data1, out data2);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Zip(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup3Zip(Vector256<ushort> x, Vector256<ushort> y, Vector256<ushort> z, out Vector256<ushort> data1, out Vector256<ushort> data2) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3Zip_ByShorter(x, y, z, out data1, out data2);
#else
                return YGroup3Zip_Basic(x, y, z, out data1, out data2);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Zip(Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup3Zip(Vector256<int> x, Vector256<int> y, Vector256<int> z, out Vector256<int> data1, out Vector256<int> data2) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3Zip_ByShorter(x, y, z, out data1, out data2);
#else
                return YGroup3Zip_Basic(x, y, z, out data1, out data2);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Zip(Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup3Zip(Vector256<uint> x, Vector256<uint> y, Vector256<uint> z, out Vector256<uint> data1, out Vector256<uint> data2) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3Zip_ByShorter(x, y, z, out data1, out data2);
#else
                return YGroup3Zip_Basic(x, y, z, out data1, out data2);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Zip(Vector256{long}, Vector256{long}, Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup3Zip(Vector256<long> x, Vector256<long> y, Vector256<long> z, out Vector256<long> data1, out Vector256<long> data2) {
                return YGroup3Zip_Basic(x, y, z, out data1, out data2);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Zip(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup3Zip(Vector256<ulong> x, Vector256<ulong> y, Vector256<ulong> z, out Vector256<ulong> data1, out Vector256<ulong> data2) {
                return YGroup3Zip_Basic(x, y, z, out data1, out data2);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Zip_Bit128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<T> YGroup3Zip_Bit128<T>(Vector256<T> x, Vector256<T> y, Vector256<T> z, out Vector256<T> data1, out Vector256<T> data2) where T : struct {
                var c0 = x.WithUpper(y.GetLower());
                var c1 = z.WithUpper(x.GetUpper());
                var c2 = y.GetUpper().ToVector256Unsafe().WithUpper(z.GetUpper());
                data1 = c1;
                data2 = c2;
                return c0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Zip(Vector256{float}, Vector256{float}, Vector256{float}, out Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup3Zip_Basic(Vector256<float> x, Vector256<float> y, Vector256<float> z, out Vector256<float> data1, out Vector256<float> data2) {
                var d0 = YGroup3Zip_Basic(x.AsUInt32(), y.AsUInt32(), z.AsUInt32(), out var d1, out var d2);
                data1 = d1.AsSingle();
                data2 = d2.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Zip(Vector256{double}, Vector256{double}, Vector256{double}, out Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup3Zip_Basic(Vector256<double> x, Vector256<double> y, Vector256<double> z, out Vector256<double> data1, out Vector256<double> data2) {
                var d0 = YGroup3Zip_Basic(x.AsUInt64(), y.AsUInt64(), z.AsUInt64(), out var d1, out var d2);
                data1 = d1.AsDouble();
                data2 = d2.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Zip(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup3Zip_Basic(Vector256<sbyte> x, Vector256<sbyte> y, Vector256<sbyte> z, out Vector256<sbyte> data1, out Vector256<sbyte> data2) {
                var d0 = YGroup3Zip_Basic(x.AsByte(), y.AsByte(), z.AsByte(), out var d1, out var d2);
                data1 = d1.AsSByte();
                data2 = d2.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Zip(Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup3Zip_Basic(Vector256<byte> x, Vector256<byte> y, Vector256<byte> z, out Vector256<byte> data1, out Vector256<byte> data2) {
                Span<Vector256<byte>> rt = stackalloc Vector256<byte>[3];
                ref byte px = ref Unsafe.As<Vector256<byte>, byte>(ref x);
                ref byte py = ref Unsafe.As<Vector256<byte>, byte>(ref y);
                ref byte pz = ref Unsafe.As<Vector256<byte>, byte>(ref z);
                Span<byte> q = MemoryMarshal.Cast<Vector256<byte>, byte>(rt);
                int idx = 0;
                for (int i = 0; i < Vector256<byte>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    q[idx + 2] = Unsafe.Add(ref pz, i);
                    idx += 3;
                }
                data1 = rt[1];
                data2 = rt[2];
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Zip(Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup3Zip_Basic(Vector256<short> x, Vector256<short> y, Vector256<short> z, out Vector256<short> data1, out Vector256<short> data2) {
                var d0 = YGroup3Zip_Basic(x.AsUInt16(), y.AsUInt16(), z.AsUInt16(), out var d1, out var d2);
                data1 = d1.AsInt16();
                data2 = d2.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Zip(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup3Zip_Basic(Vector256<ushort> x, Vector256<ushort> y, Vector256<ushort> z, out Vector256<ushort> data1, out Vector256<ushort> data2) {
                Span<Vector256<ushort>> rt = stackalloc Vector256<ushort>[3];
                ref ushort px = ref Unsafe.As<Vector256<ushort>, ushort>(ref x);
                ref ushort py = ref Unsafe.As<Vector256<ushort>, ushort>(ref y);
                ref ushort pz = ref Unsafe.As<Vector256<ushort>, ushort>(ref z);
                Span<ushort> q = MemoryMarshal.Cast<Vector256<ushort>, ushort>(rt);
                int idx = 0;
                for (int i = 0; i < Vector256<ushort>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    q[idx + 2] = Unsafe.Add(ref pz, i);
                    idx += 3;
                }
                data1 = rt[1];
                data2 = rt[2];
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Zip(Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup3Zip_Basic(Vector256<int> x, Vector256<int> y, Vector256<int> z, out Vector256<int> data1, out Vector256<int> data2) {
                var d0 = YGroup3Zip_Basic(x.AsUInt32(), y.AsUInt32(), z.AsUInt32(), out var d1, out var d2);
                data1 = d1.AsInt32();
                data2 = d2.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Zip(Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup3Zip_Basic(Vector256<uint> x, Vector256<uint> y, Vector256<uint> z, out Vector256<uint> data1, out Vector256<uint> data2) {
                Span<Vector256<uint>> rt = stackalloc Vector256<uint>[3];
                ref uint px = ref Unsafe.As<Vector256<uint>, uint>(ref x);
                ref uint py = ref Unsafe.As<Vector256<uint>, uint>(ref y);
                ref uint pz = ref Unsafe.As<Vector256<uint>, uint>(ref z);
                Span<uint> q = MemoryMarshal.Cast<Vector256<uint>, uint>(rt);
                int idx = 0;
                for (int i = 0; i < Vector256<uint>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    q[idx + 2] = Unsafe.Add(ref pz, i);
                    idx += 3;
                }
                data1 = rt[1];
                data2 = rt[2];
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Zip(Vector256{long}, Vector256{long}, Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup3Zip_Basic(Vector256<long> x, Vector256<long> y, Vector256<long> z, out Vector256<long> data1, out Vector256<long> data2) {
                var d0 = YGroup3Zip_Basic(x.AsUInt64(), y.AsUInt64(), z.AsUInt64(), out var d1, out var d2);
                data1 = d1.AsInt64();
                data2 = d2.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Zip(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup3Zip_Basic(Vector256<ulong> x, Vector256<ulong> y, Vector256<ulong> z, out Vector256<ulong> data1, out Vector256<ulong> data2) {
                Span<Vector256<ulong>> rt = stackalloc Vector256<ulong>[3];
                ref ulong px = ref Unsafe.As<Vector256<ulong>, ulong>(ref x);
                ref ulong py = ref Unsafe.As<Vector256<ulong>, ulong>(ref y);
                ref ulong pz = ref Unsafe.As<Vector256<ulong>, ulong>(ref z);
                Span<ulong> q = MemoryMarshal.Cast<Vector256<ulong>, ulong>(rt);
                int idx = 0;
                for (int i = 0; i < Vector256<ulong>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    q[idx + 2] = Unsafe.Add(ref pz, i);
                    idx += 3;
                }
                data1 = rt[1];
                data2 = rt[2];
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Zip(Vector256{float}, Vector256{float}, Vector256{float}, out Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup3Zip_ByShorter(Vector256<float> x, Vector256<float> y, Vector256<float> z, out Vector256<float> data1, out Vector256<float> data2) {
                var b0 = ShorterStatics.YGroup3ZipX2(x.GetLower(), x.GetUpper(), y.GetLower(), y.GetUpper(), z.GetLower(), z.GetUpper(), out var b1, out var b2, out var b3, out var b4, out var b5);
                var c0 = b0.ToVector256Unsafe().WithUpper(b1);
                var c1 = b2.ToVector256Unsafe().WithUpper(b3);
                var c2 = b4.ToVector256Unsafe().WithUpper(b5);
                data1 = c1;
                data2 = c2;
                return c0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Zip(Vector256{double}, Vector256{double}, Vector256{double}, out Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup3Zip_ByShorter(Vector256<double> x, Vector256<double> y, Vector256<double> z, out Vector256<double> data1, out Vector256<double> data2) {
                var b0 = ShorterStatics.YGroup3ZipX2(x.GetLower(), x.GetUpper(), y.GetLower(), y.GetUpper(), z.GetLower(), z.GetUpper(), out var b1, out var b2, out var b3, out var b4, out var b5);
                var c0 = b0.ToVector256Unsafe().WithUpper(b1);
                var c1 = b2.ToVector256Unsafe().WithUpper(b3);
                var c2 = b4.ToVector256Unsafe().WithUpper(b5);
                data1 = c1;
                data2 = c2;
                return c0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Zip(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup3Zip_ByShorter(Vector256<sbyte> x, Vector256<sbyte> y, Vector256<sbyte> z, out Vector256<sbyte> data1, out Vector256<sbyte> data2) {
                var b0 = ShorterStatics.YGroup3ZipX2(x.GetLower(), x.GetUpper(), y.GetLower(), y.GetUpper(), z.GetLower(), z.GetUpper(), out var b1, out var b2, out var b3, out var b4, out var b5);
                var c0 = b0.ToVector256Unsafe().WithUpper(b1);
                var c1 = b2.ToVector256Unsafe().WithUpper(b3);
                var c2 = b4.ToVector256Unsafe().WithUpper(b5);
                data1 = c1;
                data2 = c2;
                return c0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Zip(Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup3Zip_ByShorter(Vector256<byte> x, Vector256<byte> y, Vector256<byte> z, out Vector256<byte> data1, out Vector256<byte> data2) {
                var b0 = ShorterStatics.YGroup3ZipX2(x.GetLower(), x.GetUpper(), y.GetLower(), y.GetUpper(), z.GetLower(), z.GetUpper(), out var b1, out var b2, out var b3, out var b4, out var b5);
                var c0 = b0.ToVector256Unsafe().WithUpper(b1);
                var c1 = b2.ToVector256Unsafe().WithUpper(b3);
                var c2 = b4.ToVector256Unsafe().WithUpper(b5);
                data1 = c1;
                data2 = c2;
                return c0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Zip(Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup3Zip_ByShorter(Vector256<short> x, Vector256<short> y, Vector256<short> z, out Vector256<short> data1, out Vector256<short> data2) {
                var b0 = ShorterStatics.YGroup3ZipX2(x.GetLower(), x.GetUpper(), y.GetLower(), y.GetUpper(), z.GetLower(), z.GetUpper(), out var b1, out var b2, out var b3, out var b4, out var b5);
                var c0 = b0.ToVector256Unsafe().WithUpper(b1);
                var c1 = b2.ToVector256Unsafe().WithUpper(b3);
                var c2 = b4.ToVector256Unsafe().WithUpper(b5);
                data1 = c1;
                data2 = c2;
                return c0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Zip(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup3Zip_ByShorter(Vector256<ushort> x, Vector256<ushort> y, Vector256<ushort> z, out Vector256<ushort> data1, out Vector256<ushort> data2) {
                var b0 = ShorterStatics.YGroup3ZipX2(x.GetLower(), x.GetUpper(), y.GetLower(), y.GetUpper(), z.GetLower(), z.GetUpper(), out var b1, out var b2, out var b3, out var b4, out var b5);
                var c0 = b0.ToVector256Unsafe().WithUpper(b1);
                var c1 = b2.ToVector256Unsafe().WithUpper(b3);
                var c2 = b4.ToVector256Unsafe().WithUpper(b5);
                data1 = c1;
                data2 = c2;
                return c0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Zip(Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup3Zip_ByShorter(Vector256<int> x, Vector256<int> y, Vector256<int> z, out Vector256<int> data1, out Vector256<int> data2) {
                var b0 = ShorterStatics.YGroup3ZipX2(x.GetLower(), x.GetUpper(), y.GetLower(), y.GetUpper(), z.GetLower(), z.GetUpper(), out var b1, out var b2, out var b3, out var b4, out var b5);
                var c0 = b0.ToVector256Unsafe().WithUpper(b1);
                var c1 = b2.ToVector256Unsafe().WithUpper(b3);
                var c2 = b4.ToVector256Unsafe().WithUpper(b5);
                data1 = c1;
                data2 = c2;
                return c0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Zip(Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup3Zip_ByShorter(Vector256<uint> x, Vector256<uint> y, Vector256<uint> z, out Vector256<uint> data1, out Vector256<uint> data2) {
                var b0 = ShorterStatics.YGroup3ZipX2(x.GetLower(), x.GetUpper(), y.GetLower(), y.GetUpper(), z.GetLower(), z.GetUpper(), out var b1, out var b2, out var b3, out var b4, out var b5);
                var c0 = b0.ToVector256Unsafe().WithUpper(b1);
                var c1 = b2.ToVector256Unsafe().WithUpper(b3);
                var c2 = b4.ToVector256Unsafe().WithUpper(b5);
                data1 = c1;
                data2 = c2;
                return c0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Zip(Vector256{long}, Vector256{long}, Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup3Zip_ByShorter(Vector256<long> x, Vector256<long> y, Vector256<long> z, out Vector256<long> data1, out Vector256<long> data2) {
                var b0 = ShorterStatics.YGroup3ZipX2(x.GetLower(), x.GetUpper(), y.GetLower(), y.GetUpper(), z.GetLower(), z.GetUpper(), out var b1, out var b2, out var b3, out var b4, out var b5);
                var c0 = b0.ToVector256Unsafe().WithUpper(b1);
                var c1 = b2.ToVector256Unsafe().WithUpper(b3);
                var c2 = b4.ToVector256Unsafe().WithUpper(b5);
                data1 = c1;
                data2 = c2;
                return c0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Zip(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup3Zip_ByShorter(Vector256<ulong> x, Vector256<ulong> y, Vector256<ulong> z, out Vector256<ulong> data1, out Vector256<ulong> data2) {
                var b0 = ShorterStatics.YGroup3ZipX2(x.GetLower(), x.GetUpper(), y.GetLower(), y.GetUpper(), z.GetLower(), z.GetUpper(), out var b1, out var b2, out var b3, out var b4, out var b5);
                var c0 = b0.ToVector256Unsafe().WithUpper(b1);
                var c1 = b2.ToVector256Unsafe().WithUpper(b3);
                var c2 = b4.ToVector256Unsafe().WithUpper(b5);
                data1 = c1;
                data2 = c2;
                return c0;
            }

#if VECTOR_HAS_METHOD

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Zip(Vector256{float}, Vector256{float}, Vector256{float}, out Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup3Zip_ByX2Unzip(Vector256<float> x, Vector256<float> y, Vector256<float> z, out Vector256<float> data1, out Vector256<float> data2) {
                return YGroup3ZipX2_Unzip(x, x, y, y, z, z, out data1, out data2, out _, out _, out _);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Zip(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup3Zip_ByX2Unzip(Vector256<sbyte> x, Vector256<sbyte> y, Vector256<sbyte> z, out Vector256<sbyte> data1, out Vector256<sbyte> data2) {
                return YGroup3ZipX2_Unzip(x, x, y, y, z, z, out data1, out data2, out _, out _, out _);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Zip(Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup3Zip_ByX2Unzip(Vector256<byte> x, Vector256<byte> y, Vector256<byte> z, out Vector256<byte> data1, out Vector256<byte> data2) {
                return YGroup3ZipX2_Unzip(x, x, y, y, z, z, out data1, out data2, out _, out _, out _);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Zip(Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup3Zip_ByX2Unzip(Vector256<short> x, Vector256<short> y, Vector256<short> z, out Vector256<short> data1, out Vector256<short> data2) {
                return YGroup3ZipX2_Unzip(x, x, y, y, z, z, out data1, out data2, out _, out _, out _);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Zip(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup3Zip_ByX2Unzip(Vector256<ushort> x, Vector256<ushort> y, Vector256<ushort> z, out Vector256<ushort> data1, out Vector256<ushort> data2) {
                return YGroup3ZipX2_Unzip(x, x, y, y, z, z, out data1, out data2, out _, out _, out _);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Zip(Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup3Zip_ByX2Unzip(Vector256<int> x, Vector256<int> y, Vector256<int> z, out Vector256<int> data1, out Vector256<int> data2) {
                return YGroup3ZipX2_Unzip(x, x, y, y, z, z, out data1, out data2, out _, out _, out _);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Zip(Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup3Zip_ByX2Unzip(Vector256<uint> x, Vector256<uint> y, Vector256<uint> z, out Vector256<uint> data1, out Vector256<uint> data2) {
                return YGroup3ZipX2_Unzip(x, x, y, y, z, z, out data1, out data2, out _, out _, out _);
            }

#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits256.YGroup3ZipX2_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup3ZipX2_AcceleratedTypes {
                get {
                    return YGroup2Zip_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ZipX2(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup3ZipX2(Vector256<float> x, Vector256<float> xB, Vector256<float> y, Vector256<float> yB, Vector256<float> z, Vector256<float> zB, out Vector256<float> data1, out Vector256<float> data2, out Vector256<float> data3, out Vector256<float> data4, out Vector256<float> data5) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup3ZipX2_Unzip(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3ZipX2_X2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ZipX2(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup3ZipX2(Vector256<double> x, Vector256<double> xB, Vector256<double> y, Vector256<double> yB, Vector256<double> z, Vector256<double> zB, out Vector256<double> data1, out Vector256<double> data2, out Vector256<double> data3, out Vector256<double> data4, out Vector256<double> data5) {
                return YGroup3ZipX2_X2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ZipX2(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup3ZipX2(Vector256<sbyte> x, Vector256<sbyte> xB, Vector256<sbyte> y, Vector256<sbyte> yB, Vector256<sbyte> z, Vector256<sbyte> zB, out Vector256<sbyte> data1, out Vector256<sbyte> data2, out Vector256<sbyte> data3, out Vector256<sbyte> data4, out Vector256<sbyte> data5) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup3ZipX2_Unzip(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3ZipX2_X2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ZipX2(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup3ZipX2(Vector256<byte> x, Vector256<byte> xB, Vector256<byte> y, Vector256<byte> yB, Vector256<byte> z, Vector256<byte> zB, out Vector256<byte> data1, out Vector256<byte> data2, out Vector256<byte> data3, out Vector256<byte> data4, out Vector256<byte> data5) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup3ZipX2_Unzip(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3ZipX2_X2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ZipX2(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup3ZipX2(Vector256<short> x, Vector256<short> xB, Vector256<short> y, Vector256<short> yB, Vector256<short> z, Vector256<short> zB, out Vector256<short> data1, out Vector256<short> data2, out Vector256<short> data3, out Vector256<short> data4, out Vector256<short> data5) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup3ZipX2_Unzip(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3ZipX2_X2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ZipX2(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup3ZipX2(Vector256<ushort> x, Vector256<ushort> xB, Vector256<ushort> y, Vector256<ushort> yB, Vector256<ushort> z, Vector256<ushort> zB, out Vector256<ushort> data1, out Vector256<ushort> data2, out Vector256<ushort> data3, out Vector256<ushort> data4, out Vector256<ushort> data5) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup3ZipX2_Unzip(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3ZipX2_X2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ZipX2(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup3ZipX2(Vector256<int> x, Vector256<int> xB, Vector256<int> y, Vector256<int> yB, Vector256<int> z, Vector256<int> zB, out Vector256<int> data1, out Vector256<int> data2, out Vector256<int> data3, out Vector256<int> data4, out Vector256<int> data5) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup3ZipX2_Unzip(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3ZipX2_X2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ZipX2(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup3ZipX2(Vector256<uint> x, Vector256<uint> xB, Vector256<uint> y, Vector256<uint> yB, Vector256<uint> z, Vector256<uint> zB, out Vector256<uint> data1, out Vector256<uint> data2, out Vector256<uint> data3, out Vector256<uint> data4, out Vector256<uint> data5) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup3ZipX2_Unzip(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3ZipX2_X2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ZipX2(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup3ZipX2(Vector256<long> x, Vector256<long> xB, Vector256<long> y, Vector256<long> yB, Vector256<long> z, Vector256<long> zB, out Vector256<long> data1, out Vector256<long> data2, out Vector256<long> data3, out Vector256<long> data4, out Vector256<long> data5) {
                return YGroup3ZipX2_X2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ZipX2(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup3ZipX2(Vector256<ulong> x, Vector256<ulong> xB, Vector256<ulong> y, Vector256<ulong> yB, Vector256<ulong> z, Vector256<ulong> zB, out Vector256<ulong> data1, out Vector256<ulong> data2, out Vector256<ulong> data3, out Vector256<ulong> data4, out Vector256<ulong> data5) {
                return YGroup3ZipX2_X2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ZipX2_Bit128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<T> YGroup3ZipX2_Bit128<T>(Vector256<T> x, Vector256<T> xB, Vector256<T> y, Vector256<T> yB, Vector256<T> z, Vector256<T> zB, out Vector256<T> data1, out Vector256<T> data2, out Vector256<T> data3, out Vector256<T> data4, out Vector256<T> data5) where T : struct {
                var data0 = YGroup3Zip_Bit128(x, y, z, out data1, out data2);
                data3 = YGroup3Zip_Bit128(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ZipX2_Basic(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup3ZipX2_Basic(Vector256<float> x, Vector256<float> xB, Vector256<float> y, Vector256<float> yB, Vector256<float> z, Vector256<float> zB, out Vector256<float> data1, out Vector256<float> data2, out Vector256<float> data3, out Vector256<float> data4, out Vector256<float> data5) {
                var data0 = YGroup3Zip_Basic(x, y, z, out data1, out data2);
                data3 = YGroup3Zip_Basic(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ZipX2_Basic(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup3ZipX2_Basic(Vector256<double> x, Vector256<double> xB, Vector256<double> y, Vector256<double> yB, Vector256<double> z, Vector256<double> zB, out Vector256<double> data1, out Vector256<double> data2, out Vector256<double> data3, out Vector256<double> data4, out Vector256<double> data5) {
                var data0 = YGroup3Zip_Basic(x, y, z, out data1, out data2);
                data3 = YGroup3Zip_Basic(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ZipX2_Basic(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup3ZipX2_Basic(Vector256<sbyte> x, Vector256<sbyte> xB, Vector256<sbyte> y, Vector256<sbyte> yB, Vector256<sbyte> z, Vector256<sbyte> zB, out Vector256<sbyte> data1, out Vector256<sbyte> data2, out Vector256<sbyte> data3, out Vector256<sbyte> data4, out Vector256<sbyte> data5) {
                var data0 = YGroup3Zip_Basic(x, y, z, out data1, out data2);
                data3 = YGroup3Zip_Basic(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ZipX2_Basic(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup3ZipX2_Basic(Vector256<byte> x, Vector256<byte> xB, Vector256<byte> y, Vector256<byte> yB, Vector256<byte> z, Vector256<byte> zB, out Vector256<byte> data1, out Vector256<byte> data2, out Vector256<byte> data3, out Vector256<byte> data4, out Vector256<byte> data5) {
                var data0 = YGroup3Zip_Basic(x, y, z, out data1, out data2);
                data3 = YGroup3Zip_Basic(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ZipX2_Basic(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup3ZipX2_Basic(Vector256<short> x, Vector256<short> xB, Vector256<short> y, Vector256<short> yB, Vector256<short> z, Vector256<short> zB, out Vector256<short> data1, out Vector256<short> data2, out Vector256<short> data3, out Vector256<short> data4, out Vector256<short> data5) {
                var data0 = YGroup3Zip_Basic(x, y, z, out data1, out data2);
                data3 = YGroup3Zip_Basic(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ZipX2_Basic(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup3ZipX2_Basic(Vector256<ushort> x, Vector256<ushort> xB, Vector256<ushort> y, Vector256<ushort> yB, Vector256<ushort> z, Vector256<ushort> zB, out Vector256<ushort> data1, out Vector256<ushort> data2, out Vector256<ushort> data3, out Vector256<ushort> data4, out Vector256<ushort> data5) {
                var data0 = YGroup3Zip_Basic(x, y, z, out data1, out data2);
                data3 = YGroup3Zip_Basic(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ZipX2_Basic(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup3ZipX2_Basic(Vector256<int> x, Vector256<int> xB, Vector256<int> y, Vector256<int> yB, Vector256<int> z, Vector256<int> zB, out Vector256<int> data1, out Vector256<int> data2, out Vector256<int> data3, out Vector256<int> data4, out Vector256<int> data5) {
                var data0 = YGroup3Zip_Basic(x, y, z, out data1, out data2);
                data3 = YGroup3Zip_Basic(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ZipX2_Basic(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup3ZipX2_Basic(Vector256<uint> x, Vector256<uint> xB, Vector256<uint> y, Vector256<uint> yB, Vector256<uint> z, Vector256<uint> zB, out Vector256<uint> data1, out Vector256<uint> data2, out Vector256<uint> data3, out Vector256<uint> data4, out Vector256<uint> data5) {
                var data0 = YGroup3Zip_Basic(x, y, z, out data1, out data2);
                data3 = YGroup3Zip_Basic(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ZipX2_Basic(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup3ZipX2_Basic(Vector256<long> x, Vector256<long> xB, Vector256<long> y, Vector256<long> yB, Vector256<long> z, Vector256<long> zB, out Vector256<long> data1, out Vector256<long> data2, out Vector256<long> data3, out Vector256<long> data4, out Vector256<long> data5) {
                var data0 = YGroup3Zip_Basic(x, y, z, out data1, out data2);
                data3 = YGroup3Zip_Basic(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ZipX2_Basic(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup3ZipX2_Basic(Vector256<ulong> x, Vector256<ulong> xB, Vector256<ulong> y, Vector256<ulong> yB, Vector256<ulong> z, Vector256<ulong> zB, out Vector256<ulong> data1, out Vector256<ulong> data2, out Vector256<ulong> data3, out Vector256<ulong> data4, out Vector256<ulong> data5) {
                var data0 = YGroup3Zip_Basic(x, y, z, out data1, out data2);
                data3 = YGroup3Zip_Basic(xB, yB, zB, out data4, out data5);
                return data0;
            }

#if VECTOR_HAS_METHOD

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ZipX2_Unzip(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup3ZipX2_Unzip(Vector256<float> x, Vector256<float> xB, Vector256<float> y, Vector256<float> yB, Vector256<float> z, Vector256<float> zB, out Vector256<float> data1, out Vector256<float> data2, out Vector256<float> data3, out Vector256<float> data4, out Vector256<float> data5) {
                var d0 = YGroup3ZipX2_Unzip(x.AsUInt32(), xB.AsUInt32(), y.AsUInt32(), yB.AsUInt32(), z.AsUInt32(), zB.AsUInt32(), out var d1, out var d2, out var d3, out var d4, out var d5);
                data1 = d1.AsSingle();
                data2 = d2.AsSingle();
                data3 = d3.AsSingle();
                data4 = d4.AsSingle();
                data5 = d5.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ZipX2_Unzip(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup3ZipX2_Unzip(Vector256<sbyte> x, Vector256<sbyte> xB, Vector256<sbyte> y, Vector256<sbyte> yB, Vector256<sbyte> z, Vector256<sbyte> zB, out Vector256<sbyte> data1, out Vector256<sbyte> data2, out Vector256<sbyte> data3, out Vector256<sbyte> data4, out Vector256<sbyte> data5) {
                var d0 = YGroup3ZipX2_Unzip(x.AsByte(), xB.AsByte(), y.AsByte(), yB.AsByte(), z.AsByte(), zB.AsByte(), out var d1, out var d2, out var d3, out var d4, out var d5);
                data1 = d1.AsSByte();
                data2 = d2.AsSByte();
                data3 = d3.AsSByte();
                data4 = d4.AsSByte();
                data5 = d5.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ZipX2_Unzip(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup3ZipX2_Unzip(Vector256<byte> x, Vector256<byte> xB, Vector256<byte> y, Vector256<byte> yB, Vector256<byte> z, Vector256<byte> zB, out Vector256<byte> data1, out Vector256<byte> data2, out Vector256<byte> data3, out Vector256<byte> data4, out Vector256<byte> data5) {
                Vector256<byte> a_0, a_1, a_2, a_3, a_4, a_5, b_0, b_1, b_2, b_3, b_4, b_5;
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ZipX2_Unzip(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup3ZipX2_Unzip(Vector256<short> x, Vector256<short> xB, Vector256<short> y, Vector256<short> yB, Vector256<short> z, Vector256<short> zB, out Vector256<short> data1, out Vector256<short> data2, out Vector256<short> data3, out Vector256<short> data4, out Vector256<short> data5) {
                var d0 = YGroup3ZipX2_Unzip(x.AsUInt16(), xB.AsUInt16(), y.AsUInt16(), yB.AsUInt16(), z.AsUInt16(), zB.AsUInt16(), out var d1, out var d2, out var d3, out var d4, out var d5);
                data1 = d1.AsInt16();
                data2 = d2.AsInt16();
                data3 = d3.AsInt16();
                data4 = d4.AsInt16();
                data5 = d5.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ZipX2_Unzip(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup3ZipX2_Unzip(Vector256<ushort> x, Vector256<ushort> xB, Vector256<ushort> y, Vector256<ushort> yB, Vector256<ushort> z, Vector256<ushort> zB, out Vector256<ushort> data1, out Vector256<ushort> data2, out Vector256<ushort> data3, out Vector256<ushort> data4, out Vector256<ushort> data5) {
                Vector256<ushort> a_0, a_1, a_2, a_3, a_4, a_5, b_0, b_1, b_2, b_3, b_4, b_5;
                // 0 b_0 x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 b_1 x16 x17 x18 x19 x20 x21 x22 x23 x24 x25 x26 x27 x28 x29 x30 x31 b_2 y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 b_3 y16 y17 y18 y19 y20 y21 y22 y23 y24 y25 y26 y27 y28 y29 y30 y31 b_4 z0 z1 z2 z3 z4 z5 z6 z7 z8 z9 z10 z11 z12 z13 z14 z15 b_5 z16 z17 z18 z19 z20 z21 z22 z23 z24 z25 z26 z27 z28 z29 z30 z31
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ZipX2_Unzip(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup3ZipX2_Unzip(Vector256<int> x, Vector256<int> xB, Vector256<int> y, Vector256<int> yB, Vector256<int> z, Vector256<int> zB, out Vector256<int> data1, out Vector256<int> data2, out Vector256<int> data3, out Vector256<int> data4, out Vector256<int> data5) {
                var d0 = YGroup3ZipX2_Unzip(x.AsUInt32(), xB.AsUInt32(), y.AsUInt32(), yB.AsUInt32(), z.AsUInt32(), zB.AsUInt32(), out var d1, out var d2, out var d3, out var d4, out var d5);
                data1 = d1.AsInt32();
                data2 = d2.AsInt32();
                data3 = d3.AsInt32();
                data4 = d4.AsInt32();
                data5 = d5.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ZipX2_Unzip(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup3ZipX2_Unzip(Vector256<uint> x, Vector256<uint> xB, Vector256<uint> y, Vector256<uint> yB, Vector256<uint> z, Vector256<uint> zB, out Vector256<uint> data1, out Vector256<uint> data2, out Vector256<uint> data3, out Vector256<uint> data4, out Vector256<uint> data5) {
                Vector256<uint> a_0, a_1, a_2, a_3, a_4, a_5, b_0, b_1, b_2, b_3, b_4, b_5;
                // 0 _x_ x0 x1 x2 x3 x4 x5 x6 x7 _xB x8 x9 x10 x11 x12 x13 x14 x15 _y_ y0 y1 y2 y3 y4 y5 y6 y7 _yB y8 y9 y10 y11 y12 y13 y14 y15 _z_ z0 z1 z2 z3 z4 z5 z6 z7 _zB z8 z9 z10 z11 z12 z13 z14 z15
                // 1 a_0 x0 x2 x4 x6 x8 x10 x12 x14 a_1 y0 y2 y4 y6 y8 y10 y12 y14 a_2 z0 z2 z4 z6 z8 z10 z12 z14 a_3 x1 x3 x5 x7 x9 x11 x13 x15 a_4 y1 y3 y5 y7 y9 y11 y13 y15 a_5 z1 z3 z5 z7 z9 z11 z13 z15
                a_0 = YGroup2Unzip(x, xB, out a_3);
                a_1 = YGroup2Unzip(y, yB, out a_4);
                a_2 = YGroup2Unzip(z, zB, out a_5);
                // 2 b_0 x0 x4 x8 x12 y0 y4 y8 y12 b_1 z0 z4 z8 z12 x1 x5 x9 x13 b_2 y1 y5 y9 y13 z1 z5 z9 z13 b_3 x2 x6 x10 x14 y2 y6 y10 y14 b_4 z2 z6 z10 z14 x3 x7 x11 x15 b_5 y3 y7 y11 y15 z3 z7 z11 z15
                b_0 = YGroup2Unzip(a_0, a_1, out b_3);
                b_1 = YGroup2Unzip(a_2, a_3, out b_4);
                b_2 = YGroup2Unzip(a_4, a_5, out b_5);
                // 3 a_0 x0 x8 y0 y8 z0 z8 x1 x9 a_1 y1 y9 z1 z9 x2 x10 y2 y10 a_2 z2 z10 x3 x11 y3 y11 z3 z11 a_3 x4 x12 y4 y12 z4 z12 x5 x13 a_4 y5 y13 z5 z13 x6 x14 y6 y14 a_5 z6 z14 x7 x15 y7 y15 z7 z15
                a_0 = YGroup2Unzip(b_0, b_1, out a_3);
                a_1 = YGroup2Unzip(b_2, b_3, out a_4);
                a_2 = YGroup2Unzip(b_4, b_5, out a_5);
                // 4 b_0 x0 y0 z0 x1 y1 z1 x2 y2 b_1 z2 x3 y3 z3 x4 y4 z4 x5 b_2 y5 z5 x6 y6 z6 x7 y7 z7 b_3 x8 y8 z8 x9 y9 z9 x10 y10 b_4 z10 x11 y11 z11 x12 y12 z12 x13 b_5 y13 z13 x14 y14 z14 x15 y15 z15
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

#endif // VECTOR_HAS_METHOD

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ZipX2_X2(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup3ZipX2_X2(Vector256<float> x, Vector256<float> xB, Vector256<float> y, Vector256<float> yB, Vector256<float> z, Vector256<float> zB, out Vector256<float> data1, out Vector256<float> data2, out Vector256<float> data3, out Vector256<float> data4, out Vector256<float> data5) {
                var data0 = YGroup3Zip(x, y, z, out data1, out data2);
                data3 = YGroup3Zip(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ZipX2_X2(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup3ZipX2_X2(Vector256<double> x, Vector256<double> xB, Vector256<double> y, Vector256<double> yB, Vector256<double> z, Vector256<double> zB, out Vector256<double> data1, out Vector256<double> data2, out Vector256<double> data3, out Vector256<double> data4, out Vector256<double> data5) {
                var data0 = YGroup3Zip(x, y, z, out data1, out data2);
                data3 = YGroup3Zip(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ZipX2_X2(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup3ZipX2_X2(Vector256<sbyte> x, Vector256<sbyte> xB, Vector256<sbyte> y, Vector256<sbyte> yB, Vector256<sbyte> z, Vector256<sbyte> zB, out Vector256<sbyte> data1, out Vector256<sbyte> data2, out Vector256<sbyte> data3, out Vector256<sbyte> data4, out Vector256<sbyte> data5) {
                var data0 = YGroup3Zip(x, y, z, out data1, out data2);
                data3 = YGroup3Zip(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ZipX2_X2(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup3ZipX2_X2(Vector256<byte> x, Vector256<byte> xB, Vector256<byte> y, Vector256<byte> yB, Vector256<byte> z, Vector256<byte> zB, out Vector256<byte> data1, out Vector256<byte> data2, out Vector256<byte> data3, out Vector256<byte> data4, out Vector256<byte> data5) {
                var data0 = YGroup3Zip(x, y, z, out data1, out data2);
                data3 = YGroup3Zip(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ZipX2_X2(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup3ZipX2_X2(Vector256<short> x, Vector256<short> xB, Vector256<short> y, Vector256<short> yB, Vector256<short> z, Vector256<short> zB, out Vector256<short> data1, out Vector256<short> data2, out Vector256<short> data3, out Vector256<short> data4, out Vector256<short> data5) {
                var data0 = YGroup3Zip(x, y, z, out data1, out data2);
                data3 = YGroup3Zip(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ZipX2_X2(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup3ZipX2_X2(Vector256<ushort> x, Vector256<ushort> xB, Vector256<ushort> y, Vector256<ushort> yB, Vector256<ushort> z, Vector256<ushort> zB, out Vector256<ushort> data1, out Vector256<ushort> data2, out Vector256<ushort> data3, out Vector256<ushort> data4, out Vector256<ushort> data5) {
                var data0 = YGroup3Zip(x, y, z, out data1, out data2);
                data3 = YGroup3Zip(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ZipX2_X2(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup3ZipX2_X2(Vector256<int> x, Vector256<int> xB, Vector256<int> y, Vector256<int> yB, Vector256<int> z, Vector256<int> zB, out Vector256<int> data1, out Vector256<int> data2, out Vector256<int> data3, out Vector256<int> data4, out Vector256<int> data5) {
                var data0 = YGroup3Zip(x, y, z, out data1, out data2);
                data3 = YGroup3Zip(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ZipX2_X2(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup3ZipX2_X2(Vector256<uint> x, Vector256<uint> xB, Vector256<uint> y, Vector256<uint> yB, Vector256<uint> z, Vector256<uint> zB, out Vector256<uint> data1, out Vector256<uint> data2, out Vector256<uint> data3, out Vector256<uint> data4, out Vector256<uint> data5) {
                var data0 = YGroup3Zip(x, y, z, out data1, out data2);
                data3 = YGroup3Zip(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ZipX2_X2(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup3ZipX2_X2(Vector256<long> x, Vector256<long> xB, Vector256<long> y, Vector256<long> yB, Vector256<long> z, Vector256<long> zB, out Vector256<long> data1, out Vector256<long> data2, out Vector256<long> data3, out Vector256<long> data4, out Vector256<long> data5) {
                var data0 = YGroup3Zip(x, y, z, out data1, out data2);
                data3 = YGroup3Zip(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3ZipX2_X2(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup3ZipX2_X2(Vector256<ulong> x, Vector256<ulong> xB, Vector256<ulong> y, Vector256<ulong> yB, Vector256<ulong> z, Vector256<ulong> zB, out Vector256<ulong> data1, out Vector256<ulong> data2, out Vector256<ulong> data3, out Vector256<ulong> data4, out Vector256<ulong> data5) {
                var data0 = YGroup3Zip(x, y, z, out data1, out data2);
                data3 = YGroup3Zip(xB, yB, zB, out data4, out data5);
                return data0;
            }


            /// <inheritdoc cref="IWVectorTraits256.YGroup4ToGroup3_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup4ToGroup3_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt = TypeCodeFlags.Byte | TypeCodeFlags.SByte;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4ToGroup3(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, out Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup4ToGroup3(Vector256<float> data0, Vector256<float> data1, Vector256<float> data2, Vector256<float> data3, out Vector256<float> result1, out Vector256<float> result2) {
                var d0 = YGroup4ToGroup3(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), out var d1, out var d2);
                result1 = d1.AsSingle();
                result2 = d2.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4ToGroup3(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, out Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup4ToGroup3(Vector256<double> data0, Vector256<double> data1, Vector256<double> data2, Vector256<double> data3, out Vector256<double> result1, out Vector256<double> result2) {
                var d0 = YGroup4ToGroup3(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), data3.AsUInt64(), out var d1, out var d2);
                result1 = d1.AsDouble();
                result2 = d2.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4ToGroup3(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup4ToGroup3(Vector256<sbyte> data0, Vector256<sbyte> data1, Vector256<sbyte> data2, Vector256<sbyte> data3, out Vector256<sbyte> result1, out Vector256<sbyte> result2) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup4ToGroup3_Unzip(data0, data1, data2, data3, out result1, out result2);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup4ToGroup3_Basic(data0, data1, data2, data3, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4ToGroup3(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup4ToGroup3(Vector256<byte> data0, Vector256<byte> data1, Vector256<byte> data2, Vector256<byte> data3, out Vector256<byte> result1, out Vector256<byte> result2) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup4ToGroup3_Unzip(data0, data1, data2, data3, out result1, out result2);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup4ToGroup3_Basic(data0, data1, data2, data3, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4ToGroup3(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup4ToGroup3(Vector256<short> data0, Vector256<short> data1, Vector256<short> data2, Vector256<short> data3, out Vector256<short> result1, out Vector256<short> result2) {
                return YGroup4ToGroup3_Basic(data0, data1, data2, data3, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4ToGroup3(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup4ToGroup3(Vector256<ushort> data0, Vector256<ushort> data1, Vector256<ushort> data2, Vector256<ushort> data3, out Vector256<ushort> result1, out Vector256<ushort> result2) {
                return YGroup4ToGroup3_Basic(data0, data1, data2, data3, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4ToGroup3(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup4ToGroup3(Vector256<int> data0, Vector256<int> data1, Vector256<int> data2, Vector256<int> data3, out Vector256<int> result1, out Vector256<int> result2) {
                return YGroup4ToGroup3_Basic(data0, data1, data2, data3, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4ToGroup3(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup4ToGroup3(Vector256<uint> data0, Vector256<uint> data1, Vector256<uint> data2, Vector256<uint> data3, out Vector256<uint> result1, out Vector256<uint> result2) {
                return YGroup4ToGroup3_Basic(data0, data1, data2, data3, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4ToGroup3(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup4ToGroup3(Vector256<long> data0, Vector256<long> data1, Vector256<long> data2, Vector256<long> data3, out Vector256<long> result1, out Vector256<long> result2) {
                return YGroup4ToGroup3_Basic(data0, data1, data2, data3, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4ToGroup3(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup4ToGroup3(Vector256<ulong> data0, Vector256<ulong> data1, Vector256<ulong> data2, Vector256<ulong> data3, out Vector256<ulong> result1, out Vector256<ulong> result2) {
                return YGroup4ToGroup3_Basic(data0, data1, data2, data3, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4ToGroup3(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup4ToGroup3_Basic(Vector256<sbyte> data0, Vector256<sbyte> data1, Vector256<sbyte> data2, Vector256<sbyte> data3, out Vector256<sbyte> result1, out Vector256<sbyte> result2) {
                var d0 = YGroup4ToGroup3_Basic(data0.AsByte(), data1.AsByte(), data2.AsByte(), data3.AsByte(), out var d1, out var d2);
                result1 = d1.AsSByte();
                result2 = d2.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4ToGroup3(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup4ToGroup3_Basic(Vector256<byte> data0, Vector256<byte> data1, Vector256<byte> data2, Vector256<byte> data3, out Vector256<byte> result1, out Vector256<byte> result2) {
                Span<Vector256<byte>> src = [data0, data1, data2, data3];
                Span<Vector256<byte>> dst = stackalloc Vector256<byte>[3];
                Span<byte> p = MemoryMarshal.Cast<Vector256<byte>, byte>(src);
                Span<byte> q = MemoryMarshal.Cast<Vector256<byte>, byte>(dst);
                for (int i = 0; i < Vector256<byte>.Count; ++i) {
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup4ToGroup3(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup4ToGroup3_Basic(Vector256<short> data0, Vector256<short> data1, Vector256<short> data2, Vector256<short> data3, out Vector256<short> result1, out Vector256<short> result2) {
                var d0 = YGroup4ToGroup3_Basic(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), data3.AsUInt16(), out var d1, out var d2);
                result1 = d1.AsInt16();
                result2 = d2.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4ToGroup3(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup4ToGroup3_Basic(Vector256<ushort> data0, Vector256<ushort> data1, Vector256<ushort> data2, Vector256<ushort> data3, out Vector256<ushort> result1, out Vector256<ushort> result2) {
                Span<Vector256<ushort>> src = [data0, data1, data2, data3];
                Span<Vector256<ushort>> dst = stackalloc Vector256<ushort>[3];
                Span<ushort> p = MemoryMarshal.Cast<Vector256<ushort>, ushort>(src);
                Span<ushort> q = MemoryMarshal.Cast<Vector256<ushort>, ushort>(dst);
                for (int i = 0; i < Vector256<ushort>.Count; ++i) {
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup4ToGroup3(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup4ToGroup3_Basic(Vector256<int> data0, Vector256<int> data1, Vector256<int> data2, Vector256<int> data3, out Vector256<int> result1, out Vector256<int> result2) {
                var d0 = YGroup4ToGroup3_Basic(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), out var d1, out var d2);
                result1 = d1.AsInt32();
                result2 = d2.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4ToGroup3(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup4ToGroup3_Basic(Vector256<uint> data0, Vector256<uint> data1, Vector256<uint> data2, Vector256<uint> data3, out Vector256<uint> result1, out Vector256<uint> result2) {
                Span<Vector256<uint>> src = [data0, data1, data2, data3];
                Span<Vector256<uint>> dst = stackalloc Vector256<uint>[3];
                Span<uint> p = MemoryMarshal.Cast<Vector256<uint>, uint>(src);
                Span<uint> q = MemoryMarshal.Cast<Vector256<uint>, uint>(dst);
                for (int i = 0; i < Vector256<uint>.Count; ++i) {
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup4ToGroup3(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup4ToGroup3_Basic(Vector256<long> data0, Vector256<long> data1, Vector256<long> data2, Vector256<long> data3, out Vector256<long> result1, out Vector256<long> result2) {
                var d0 = YGroup4ToGroup3_Basic(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), data3.AsUInt64(), out var d1, out var d2);
                result1 = d1.AsInt64();
                result2 = d2.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4ToGroup3(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup4ToGroup3_Basic(Vector256<ulong> data0, Vector256<ulong> data1, Vector256<ulong> data2, Vector256<ulong> data3, out Vector256<ulong> result1, out Vector256<ulong> result2) {
                Span<Vector256<ulong>> src = [data0, data1, data2, data3];
                Span<Vector256<ulong>> dst = stackalloc Vector256<ulong>[3];
                Span<ulong> p = MemoryMarshal.Cast<Vector256<ulong>, ulong>(src);
                Span<ulong> q = MemoryMarshal.Cast<Vector256<ulong>, ulong>(dst);
                for (int i = 0; i < Vector256<ulong>.Count; ++i) {
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup4ToGroup3(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup4ToGroup3_Shuffle(Vector256<sbyte> data0, Vector256<sbyte> data1, Vector256<sbyte> data2, Vector256<sbyte> data3, out Vector256<sbyte> result1, out Vector256<sbyte> result2) {
                var d0 = YGroup4ToGroup3_Shuffle(data0.AsByte(), data1.AsByte(), data2.AsByte(), data3.AsByte(), out var d1, out var d2);
                result1 = d1.AsSByte();
                result2 = d2.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4ToGroup3(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup4ToGroup3_Shuffle(Vector256<byte> data0, Vector256<byte> data1, Vector256<byte> data2, Vector256<byte> data3, out Vector256<byte> result1, out Vector256<byte> result2) {
                var f0A = Vector256Constants.YGroup4ToGroup3_Shuffle_Byte_0A;
                var f0B = Vector256Constants.YGroup4ToGroup3_Shuffle_Byte_0B;
                var f1A = Vector256Constants.YGroup4ToGroup3_Shuffle_Byte_1A;
                var f1B = Vector256Constants.YGroup4ToGroup3_Shuffle_Byte_1B;
                var f2A = Vector256Constants.YGroup4ToGroup3_Shuffle_Byte_2A;
                var f2B = Vector256Constants.YGroup4ToGroup3_Shuffle_Byte_2B;
                var a_0 = Vector256.BitwiseOr(Vector256.Shuffle(data0, f0A), Vector256.Shuffle(data1, f0B));
                var a_1 = Vector256.BitwiseOr(Vector256.Shuffle(data1, f1A), Vector256.Shuffle(data2, f1B));
                var a_2 = Vector256.BitwiseOr(Vector256.Shuffle(data2, f2A), Vector256.Shuffle(data3, f2B));
                result1 = a_1;
                result2 = a_2;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4ToGroup3(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup4ToGroup3_Shuffle(Vector256<short> data0, Vector256<short> data1, Vector256<short> data2, Vector256<short> data3, out Vector256<short> result1, out Vector256<short> result2) {
                var d0 = YGroup4ToGroup3_Shuffle(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), data3.AsUInt16(), out var d1, out var d2);
                result1 = d1.AsInt16();
                result2 = d2.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4ToGroup3(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup4ToGroup3_Shuffle(Vector256<ushort> data0, Vector256<ushort> data1, Vector256<ushort> data2, Vector256<ushort> data3, out Vector256<ushort> result1, out Vector256<ushort> result2) {
                var f0A = Vector256Constants.YGroup4ToGroup3_ShuffleOnByte_UInt16_0A;
                var f0B = Vector256Constants.YGroup4ToGroup3_ShuffleOnByte_UInt16_0B;
                var f1A = Vector256Constants.YGroup4ToGroup3_ShuffleOnByte_UInt16_1A;
                var f1B = Vector256Constants.YGroup4ToGroup3_ShuffleOnByte_UInt16_1B;
                var f2A = Vector256Constants.YGroup4ToGroup3_ShuffleOnByte_UInt16_2A;
                var f2B = Vector256Constants.YGroup4ToGroup3_ShuffleOnByte_UInt16_2B;
                var s0 = data0.AsByte();
                var s1 = data1.AsByte();
                var s2 = data2.AsByte();
                var s3 = data3.AsByte();
                var a_0 = Vector256.BitwiseOr(Vector256.Shuffle(s0, f0A), Vector256.Shuffle(s1, f0B)).AsUInt16();
                var a_1 = Vector256.BitwiseOr(Vector256.Shuffle(s1, f1A), Vector256.Shuffle(s2, f1B)).AsUInt16();
                var a_2 = Vector256.BitwiseOr(Vector256.Shuffle(s2, f2A), Vector256.Shuffle(s3, f2B)).AsUInt16();
                result1 = a_1;
                result2 = a_2;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4ToGroup3(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup4ToGroup3_Shuffle(Vector256<int> data0, Vector256<int> data1, Vector256<int> data2, Vector256<int> data3, out Vector256<int> result1, out Vector256<int> result2) {
                var d0 = YGroup4ToGroup3_Shuffle(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), out var d1, out var d2);
                result1 = d1.AsInt32();
                result2 = d2.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4ToGroup3(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup4ToGroup3_Shuffle(Vector256<uint> data0, Vector256<uint> data1, Vector256<uint> data2, Vector256<uint> data3, out Vector256<uint> result1, out Vector256<uint> result2) {
                var f0A = Vector256Constants.YGroup4ToGroup3_ShuffleOnByte_UInt32_0A;
                var f0B = Vector256Constants.YGroup4ToGroup3_ShuffleOnByte_UInt32_0B;
                var f1A = Vector256Constants.YGroup4ToGroup3_ShuffleOnByte_UInt32_1A;
                var f1B = Vector256Constants.YGroup4ToGroup3_ShuffleOnByte_UInt32_1B;
                var f2A = Vector256Constants.YGroup4ToGroup3_ShuffleOnByte_UInt32_2A;
                var f2B = Vector256Constants.YGroup4ToGroup3_ShuffleOnByte_UInt32_2B;
                var s0 = data0.AsByte();
                var s1 = data1.AsByte();
                var s2 = data2.AsByte();
                var s3 = data3.AsByte();
                var a_0 = Vector256.BitwiseOr(Vector256.Shuffle(s0, f0A), Vector256.Shuffle(s1, f0B)).AsUInt32();
                var a_1 = Vector256.BitwiseOr(Vector256.Shuffle(s1, f1A), Vector256.Shuffle(s2, f1B)).AsUInt32();
                var a_2 = Vector256.BitwiseOr(Vector256.Shuffle(s2, f2A), Vector256.Shuffle(s3, f2B)).AsUInt32();
                result1 = a_1;
                result2 = a_2;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4ToGroup3(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup4ToGroup3_Shuffle(Vector256<long> data0, Vector256<long> data1, Vector256<long> data2, Vector256<long> data3, out Vector256<long> result1, out Vector256<long> result2) {
                var d0 = YGroup4ToGroup3_Shuffle(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), data3.AsUInt64(), out var d1, out var d2);
                result1 = d1.AsInt64();
                result2 = d2.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4ToGroup3(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup4ToGroup3_Shuffle(Vector256<ulong> data0, Vector256<ulong> data1, Vector256<ulong> data2, Vector256<ulong> data3, out Vector256<ulong> result1, out Vector256<ulong> result2) {
                var f0A = Vector256Constants.YGroup4ToGroup3_ShuffleOnByte_UInt64_0A;
                var f0B = Vector256Constants.YGroup4ToGroup3_ShuffleOnByte_UInt64_0B;
                var f1A = Vector256Constants.YGroup4ToGroup3_ShuffleOnByte_UInt64_1A;
                var f1B = Vector256Constants.YGroup4ToGroup3_ShuffleOnByte_UInt64_1B;
                var f2A = Vector256Constants.YGroup4ToGroup3_ShuffleOnByte_UInt64_2A;
                var f2B = Vector256Constants.YGroup4ToGroup3_ShuffleOnByte_UInt64_2B;
                var s0 = data0.AsByte();
                var s1 = data1.AsByte();
                var s2 = data2.AsByte();
                var s3 = data3.AsByte();
                var a_0 = Vector256.BitwiseOr(Vector256.Shuffle(s0, f0A), Vector256.Shuffle(s1, f0B)).AsUInt64();
                var a_1 = Vector256.BitwiseOr(Vector256.Shuffle(s1, f1A), Vector256.Shuffle(s2, f1B)).AsUInt64();
                var a_2 = Vector256.BitwiseOr(Vector256.Shuffle(s2, f2A), Vector256.Shuffle(s3, f2B)).AsUInt64();
                result1 = a_1;
                result2 = a_2;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4ToGroup3(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup4ToGroup3_Unzip(Vector256<sbyte> data0, Vector256<sbyte> data1, Vector256<sbyte> data2, Vector256<sbyte> data3, out Vector256<sbyte> result1, out Vector256<sbyte> result2) {
                var d0 = YGroup4ToGroup3_Unzip(data0.AsByte(), data1.AsByte(), data2.AsByte(), data3.AsByte(), out var d1, out var d2);
                result1 = d1.AsSByte();
                result2 = d2.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4ToGroup3(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup4ToGroup3_Unzip(Vector256<byte> data0, Vector256<byte> data1, Vector256<byte> data2, Vector256<byte> data3, out Vector256<byte> result1, out Vector256<byte> result2) {
                var a_0 = YGroup4Unzip(data0, data1, data2, data3, out var a_1, out var a_2, out _);
                var b_0 = YGroup3Zip(a_0, a_1, a_2, out var b_1, out var b_2);
                result1 = b_1;
                result2 = b_2;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4ToGroup3(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup4ToGroup3_Unzip(Vector256<short> data0, Vector256<short> data1, Vector256<short> data2, Vector256<short> data3, out Vector256<short> result1, out Vector256<short> result2) {
                var d0 = YGroup4ToGroup3_Unzip(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), data3.AsUInt16(), out var d1, out var d2);
                result1 = d1.AsInt16();
                result2 = d2.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4ToGroup3(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup4ToGroup3_Unzip(Vector256<ushort> data0, Vector256<ushort> data1, Vector256<ushort> data2, Vector256<ushort> data3, out Vector256<ushort> result1, out Vector256<ushort> result2) {
                var a_0 = YGroup4Unzip(data0, data1, data2, data3, out var a_1, out var a_2, out _);
                var b_0 = YGroup3Zip(a_0, a_1, a_2, out var b_1, out var b_2);
                result1 = b_1;
                result2 = b_2;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4ToGroup3(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup4ToGroup3_Unzip(Vector256<int> data0, Vector256<int> data1, Vector256<int> data2, Vector256<int> data3, out Vector256<int> result1, out Vector256<int> result2) {
                var d0 = YGroup4ToGroup3_Unzip(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), out var d1, out var d2);
                result1 = d1.AsInt32();
                result2 = d2.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4ToGroup3(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup4ToGroup3_Unzip(Vector256<uint> data0, Vector256<uint> data1, Vector256<uint> data2, Vector256<uint> data3, out Vector256<uint> result1, out Vector256<uint> result2) {
                var a_0 = YGroup4Unzip(data0, data1, data2, data3, out var a_1, out var a_2, out _);
                var b_0 = YGroup3Zip(a_0, a_1, a_2, out var b_1, out var b_2);
                result1 = b_1;
                result2 = b_2;
                return b_0;
            }

#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup4Unzip_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt = TypeCodeFlagsUtil.Most32Types;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup4Unzip(Vector256<float> data0, Vector256<float> data1, Vector256<float> data2, Vector256<float> data3, out Vector256<float> y, out Vector256<float> z, out Vector256<float> w) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup4Unzip_Basic(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup4Unzip(Vector256<double> data0, Vector256<double> data1, Vector256<double> data2, Vector256<double> data3, out Vector256<double> y, out Vector256<double> z, out Vector256<double> w) {
                return YGroup4Unzip_Basic(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup4Unzip(Vector256<sbyte> data0, Vector256<sbyte> data1, Vector256<sbyte> data2, Vector256<sbyte> data3, out Vector256<sbyte> y, out Vector256<sbyte> z, out Vector256<sbyte> w) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup4Unzip_Basic(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup4Unzip(Vector256<byte> data0, Vector256<byte> data1, Vector256<byte> data2, Vector256<byte> data3, out Vector256<byte> y, out Vector256<byte> z, out Vector256<byte> w) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup4Unzip_Basic(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup4Unzip(Vector256<short> data0, Vector256<short> data1, Vector256<short> data2, Vector256<short> data3, out Vector256<short> y, out Vector256<short> z, out Vector256<short> w) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup4Unzip_Basic(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup4Unzip(Vector256<ushort> data0, Vector256<ushort> data1, Vector256<ushort> data2, Vector256<ushort> data3, out Vector256<ushort> y, out Vector256<ushort> z, out Vector256<ushort> w) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup4Unzip_Basic(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup4Unzip(Vector256<int> data0, Vector256<int> data1, Vector256<int> data2, Vector256<int> data3, out Vector256<int> y, out Vector256<int> z, out Vector256<int> w) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup4Unzip_Basic(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup4Unzip(Vector256<uint> data0, Vector256<uint> data1, Vector256<uint> data2, Vector256<uint> data3, out Vector256<uint> y, out Vector256<uint> z, out Vector256<uint> w) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup4Unzip_Basic(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup4Unzip(Vector256<long> data0, Vector256<long> data1, Vector256<long> data2, Vector256<long> data3, out Vector256<long> y, out Vector256<long> z, out Vector256<long> w) {
                return YGroup4Unzip_Basic(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup4Unzip(Vector256<ulong> data0, Vector256<ulong> data1, Vector256<ulong> data2, Vector256<ulong> data3, out Vector256<ulong> y, out Vector256<ulong> z, out Vector256<ulong> w) {
                return YGroup4Unzip_Basic(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{ExInt128}, Vector256{ExInt128}, Vector256{ExInt128}, Vector256{ExInt128}, out Vector256{ExInt128}, out Vector256{ExInt128}, out Vector256{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExInt128> YGroup4Unzip(Vector256<ExInt128> data0, Vector256<ExInt128> data1, Vector256<ExInt128> data2, Vector256<ExInt128> data3, out Vector256<ExInt128> y, out Vector256<ExInt128> z, out Vector256<ExInt128> w) {
                return YGroup4Unzip_Move(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{ExUInt128}, Vector256{ExUInt128}, Vector256{ExUInt128}, Vector256{ExUInt128}, out Vector256{ExUInt128}, out Vector256{ExUInt128}, out Vector256{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExUInt128> YGroup4Unzip(Vector256<ExUInt128> data0, Vector256<ExUInt128> data1, Vector256<ExUInt128> data2, Vector256<ExUInt128> data3, out Vector256<ExUInt128> y, out Vector256<ExUInt128> z, out Vector256<ExUInt128> w) {
                return YGroup4Unzip_Move(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip_Bit128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<T> YGroup4Unzip_Bit128<T>(Vector256<T> data0, Vector256<T> data1, Vector256<T> data2, Vector256<T> data3, out Vector256<T> y, out Vector256<T> z, out Vector256<T> w) where T : struct {
#if EX_APPLY_GENERIC
                var d0 = YGroup4Unzip(data0.ExAs<T, ExUInt128>(), data1.ExAs<T, ExUInt128>(), data2.ExAs<T, ExUInt128>(), data3.ExAs<T, ExUInt128>(), out var d1, out var d2, out var d3);
                y = d1.ExAs<ExUInt128, T>();
                z = d2.ExAs<ExUInt128, T>();
                w = d3.ExAs<ExUInt128, T>();
                return d0.ExAs<ExUInt128, T>();
#else
                var a0 = data0;
                var a1 = data1;
                var a2 = data2;
                var a3 = data3;
                var c0 = a0.WithUpper(a2.GetLower());
                var c1 = a0.GetUpper().ToVector256Unsafe().WithUpper(a2.GetUpper());
                var c2 = a1.WithUpper(a3.GetLower());
                var c3 = a1.GetUpper().ToVector256Unsafe().WithUpper(a3.GetUpper());
                y = c1;
                z = c2;
                w = c3;
                return c0;
#endif // EX_APPLY_GENERIC
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup4Unzip_Basic(Vector256<float> data0, Vector256<float> data1, Vector256<float> data2, Vector256<float> data3, out Vector256<float> y, out Vector256<float> z, out Vector256<float> w) {
                var d0 = YGroup4Unzip_Basic(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), out var d1, out var d2, out var d3);
                y = d1.AsSingle();
                z = d2.AsSingle();
                w = d3.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup4Unzip_Basic(Vector256<double> data0, Vector256<double> data1, Vector256<double> data2, Vector256<double> data3, out Vector256<double> y, out Vector256<double> z, out Vector256<double> w) {
                var d0 = YGroup4Unzip_Basic(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), data3.AsUInt64(), out var d1, out var d2, out var d3);
                y = d1.AsDouble();
                z = d2.AsDouble();
                w = d3.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup4Unzip_Basic(Vector256<sbyte> data0, Vector256<sbyte> data1, Vector256<sbyte> data2, Vector256<sbyte> data3, out Vector256<sbyte> y, out Vector256<sbyte> z, out Vector256<sbyte> w) {
                var d0 = YGroup4Unzip_Basic(data0.AsByte(), data1.AsByte(), data2.AsByte(), data3.AsByte(), out var d1, out var d2, out var d3);
                y = d1.AsSByte();
                z = d2.AsSByte();
                w = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup4Unzip_Basic(Vector256<byte> data0, Vector256<byte> data1, Vector256<byte> data2, Vector256<byte> data3, out Vector256<byte> y, out Vector256<byte> z, out Vector256<byte> w) {
                Unsafe.SkipInit(out Vector256<byte> x1);
                Unsafe.SkipInit(out Vector256<byte> y1);
                Unsafe.SkipInit(out Vector256<byte> z1);
                Unsafe.SkipInit(out Vector256<byte> w1);
                Span<Vector256<byte>> src = [data0, data1, data2, data3];
                ref byte px = ref Unsafe.As<Vector256<byte>, byte>(ref x1);
                ref byte py = ref Unsafe.As<Vector256<byte>, byte>(ref y1);
                ref byte pz = ref Unsafe.As<Vector256<byte>, byte>(ref z1);
                ref byte pw = ref Unsafe.As<Vector256<byte>, byte>(ref w1);
                Span<byte> p = MemoryMarshal.Cast<Vector256<byte>, byte>(src);
                int idx = 0;
                for (int i = 0; i < Vector256<byte>.Count; ++i) {
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup4Unzip_Basic(Vector256<short> data0, Vector256<short> data1, Vector256<short> data2, Vector256<short> data3, out Vector256<short> y, out Vector256<short> z, out Vector256<short> w) {
                var d0 = YGroup4Unzip_Basic(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), data3.AsUInt16(), out var d1, out var d2, out var d3);
                y = d1.AsInt16();
                z = d2.AsInt16();
                w = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup4Unzip_Basic(Vector256<ushort> data0, Vector256<ushort> data1, Vector256<ushort> data2, Vector256<ushort> data3, out Vector256<ushort> y, out Vector256<ushort> z, out Vector256<ushort> w) {
                Unsafe.SkipInit(out Vector256<ushort> x1);
                Unsafe.SkipInit(out Vector256<ushort> y1);
                Unsafe.SkipInit(out Vector256<ushort> z1);
                Unsafe.SkipInit(out Vector256<ushort> w1);
                Span<Vector256<ushort>> src = [data0, data1, data2, data3];
                ref ushort px = ref Unsafe.As<Vector256<ushort>, ushort>(ref x1);
                ref ushort py = ref Unsafe.As<Vector256<ushort>, ushort>(ref y1);
                ref ushort pz = ref Unsafe.As<Vector256<ushort>, ushort>(ref z1);
                ref ushort pw = ref Unsafe.As<Vector256<ushort>, ushort>(ref w1);
                Span<ushort> p = MemoryMarshal.Cast<Vector256<ushort>, ushort>(src);
                int idx = 0;
                for (int i = 0; i < Vector256<ushort>.Count; ++i) {
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup4Unzip_Basic(Vector256<int> data0, Vector256<int> data1, Vector256<int> data2, Vector256<int> data3, out Vector256<int> y, out Vector256<int> z, out Vector256<int> w) {
                var d0 = YGroup4Unzip_Basic(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), out var d1, out var d2, out var d3);
                y = d1.AsInt32();
                z = d2.AsInt32();
                w = d3.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup4Unzip_Basic(Vector256<uint> data0, Vector256<uint> data1, Vector256<uint> data2, Vector256<uint> data3, out Vector256<uint> y, out Vector256<uint> z, out Vector256<uint> w) {
                Unsafe.SkipInit(out Vector256<uint> x1);
                Unsafe.SkipInit(out Vector256<uint> y1);
                Unsafe.SkipInit(out Vector256<uint> z1);
                Unsafe.SkipInit(out Vector256<uint> w1);
                Span<Vector256<uint>> src = [data0, data1, data2, data3];
                ref uint px = ref Unsafe.As<Vector256<uint>, uint>(ref x1);
                ref uint py = ref Unsafe.As<Vector256<uint>, uint>(ref y1);
                ref uint pz = ref Unsafe.As<Vector256<uint>, uint>(ref z1);
                ref uint pw = ref Unsafe.As<Vector256<uint>, uint>(ref w1);
                Span<uint> p = MemoryMarshal.Cast<Vector256<uint>, uint>(src);
                int idx = 0;
                for (int i = 0; i < Vector256<uint>.Count; ++i) {
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup4Unzip_Basic(Vector256<long> data0, Vector256<long> data1, Vector256<long> data2, Vector256<long> data3, out Vector256<long> y, out Vector256<long> z, out Vector256<long> w) {
                var d0 = YGroup4Unzip_Basic(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), data3.AsUInt64(), out var d1, out var d2, out var d3);
                y = d1.AsInt64();
                z = d2.AsInt64();
                w = d3.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup4Unzip_Basic(Vector256<ulong> data0, Vector256<ulong> data1, Vector256<ulong> data2, Vector256<ulong> data3, out Vector256<ulong> y, out Vector256<ulong> z, out Vector256<ulong> w) {
                Unsafe.SkipInit(out Vector256<ulong> x1);
                Unsafe.SkipInit(out Vector256<ulong> y1);
                Unsafe.SkipInit(out Vector256<ulong> z1);
                Unsafe.SkipInit(out Vector256<ulong> w1);
                Span<Vector256<ulong>> src = [data0, data1, data2, data3];
                ref ulong px = ref Unsafe.As<Vector256<ulong>, ulong>(ref x1);
                ref ulong py = ref Unsafe.As<Vector256<ulong>, ulong>(ref y1);
                ref ulong pz = ref Unsafe.As<Vector256<ulong>, ulong>(ref z1);
                ref ulong pw = ref Unsafe.As<Vector256<ulong>, ulong>(ref w1);
                Span<ulong> p = MemoryMarshal.Cast<Vector256<ulong>, ulong>(src);
                int idx = 0;
                for (int i = 0; i < Vector256<ulong>.Count; ++i) {
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{ExInt128}, Vector256{ExInt128}, Vector256{ExInt128}, Vector256{ExInt128}, out Vector256{ExInt128}, out Vector256{ExInt128}, out Vector256{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExInt128> YGroup4Unzip_Basic(Vector256<ExInt128> data0, Vector256<ExInt128> data1, Vector256<ExInt128> data2, Vector256<ExInt128> data3, out Vector256<ExInt128> y, out Vector256<ExInt128> z, out Vector256<ExInt128> w) {
                var d0 = YGroup4Unzip_Basic(data0.ExAsExUInt128(), data1.ExAsExUInt128(), data2.ExAsExUInt128(), data3.ExAsExUInt128(), out var d1, out var d2, out var d3);
                y = d1.ExAsExInt128();
                z = d2.ExAsExInt128();
                w = d3.ExAsExInt128();
                return d0.ExAsExInt128();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{ExUInt128}, Vector256{ExUInt128}, Vector256{ExUInt128}, Vector256{ExUInt128}, out Vector256{ExUInt128}, out Vector256{ExUInt128}, out Vector256{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExUInt128> YGroup4Unzip_Basic(Vector256<ExUInt128> data0, Vector256<ExUInt128> data1, Vector256<ExUInt128> data2, Vector256<ExUInt128> data3, out Vector256<ExUInt128> y, out Vector256<ExUInt128> z, out Vector256<ExUInt128> w) {
                Unsafe.SkipInit(out Vector256<ExUInt128> x1);
                Unsafe.SkipInit(out Vector256<ExUInt128> y1);
                Unsafe.SkipInit(out Vector256<ExUInt128> z1);
                Unsafe.SkipInit(out Vector256<ExUInt128> w1);
                Span<Vector256<ExUInt128>> src = [data0, data1, data2, data3];
                ref ExUInt128 px = ref Unsafe.As<Vector256<ExUInt128>, ExUInt128>(ref x1);
                ref ExUInt128 py = ref Unsafe.As<Vector256<ExUInt128>, ExUInt128>(ref y1);
                ref ExUInt128 pz = ref Unsafe.As<Vector256<ExUInt128>, ExUInt128>(ref z1);
                ref ExUInt128 pw = ref Unsafe.As<Vector256<ExUInt128>, ExUInt128>(ref w1);
                Span<ExUInt128> p = MemoryMarshal.Cast<Vector256<ExUInt128>, ExUInt128>(src);
                int cnt = Vector256s<ExUInt128>.Count;
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{ExInt128}, Vector256{ExInt128}, Vector256{ExInt128}, Vector256{ExInt128}, out Vector256{ExInt128}, out Vector256{ExInt128}, out Vector256{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExInt128> YGroup4Unzip_Move(Vector256<ExInt128> data0, Vector256<ExInt128> data1, Vector256<ExInt128> data2, Vector256<ExInt128> data3, out Vector256<ExInt128> y, out Vector256<ExInt128> z, out Vector256<ExInt128> w) {
                var d0 = YGroup4Unzip_Move(data0.ExAsExUInt128(), data1.ExAsExUInt128(), data2.ExAsExUInt128(), data3.ExAsExUInt128(), out var d1, out var d2, out var d3);
                y = d1.ExAsExInt128();
                z = d2.ExAsExInt128();
                w = d3.ExAsExInt128();
                return d0.ExAsExInt128();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{ExUInt128}, Vector256{ExUInt128}, Vector256{ExUInt128}, Vector256{ExUInt128}, out Vector256{ExUInt128}, out Vector256{ExUInt128}, out Vector256{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExUInt128> YGroup4Unzip_Move(Vector256<ExUInt128> data0, Vector256<ExUInt128> data1, Vector256<ExUInt128> data2, Vector256<ExUInt128> data3, out Vector256<ExUInt128> y, out Vector256<ExUInt128> z, out Vector256<ExUInt128> w) {
                var a0 = data0.ExAsUInt64();
                var a1 = data1.ExAsUInt64();
                var a2 = data2.ExAsUInt64();
                var a3 = data3.ExAsUInt64();
                var c0 = a0.WithUpper(a2.GetLower());
                var c1 = a0.GetUpper().ToVector256Unsafe().WithUpper(a2.GetUpper());
                var c2 = a1.WithUpper(a3.GetLower());
                var c3 = a1.GetUpper().ToVector256Unsafe().WithUpper(a3.GetUpper());
                y = c1.ExAsExUInt128();
                z = c2.ExAsExUInt128();
                w = c3.ExAsExUInt128();
                return c0.ExAsExUInt128();
            }

#if VECTOR_HAS_METHOD

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup4Unzip_Narrow(Vector256<sbyte> data0, Vector256<sbyte> data1, Vector256<sbyte> data2, Vector256<sbyte> data3, out Vector256<sbyte> y, out Vector256<sbyte> z, out Vector256<sbyte> w) {
                var d0 = YGroup4Unzip_Narrow(data0.AsByte(), data1.AsByte(), data2.AsByte(), data3.AsByte(), out var d1, out var d2, out var d3);
                y = d1.AsSByte();
                z = d2.AsSByte();
                w = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup4Unzip_Narrow(Vector256<byte> data0, Vector256<byte> data1, Vector256<byte> data2, Vector256<byte> data3, out Vector256<byte> y, out Vector256<byte> z, out Vector256<byte> w) {
                const int L = 8;
                Vector256<byte> rt0, rt1, rt2, rt3;
                Vector256<uint> temp0, temp1, temp2, temp3;
                temp0 = data0.AsUInt32();
                temp1 = data1.AsUInt32();
                temp2 = data2.AsUInt32();
                temp3 = data3.AsUInt32();
                rt0 = Vector256.Narrow(Vector256.Narrow(temp0, temp1), Vector256.Narrow(temp2, temp3));
                temp0 = Vector256.ShiftRightLogical(temp0, L);
                temp1 = Vector256.ShiftRightLogical(temp1, L);
                temp2 = Vector256.ShiftRightLogical(temp2, L);
                temp3 = Vector256.ShiftRightLogical(temp3, L);
                rt1 = Vector256.Narrow(Vector256.Narrow(temp0, temp1), Vector256.Narrow(temp2, temp3));
                temp0 = Vector256.ShiftRightLogical(temp0, L);
                temp1 = Vector256.ShiftRightLogical(temp1, L);
                temp2 = Vector256.ShiftRightLogical(temp2, L);
                temp3 = Vector256.ShiftRightLogical(temp3, L);
                rt2 = Vector256.Narrow(Vector256.Narrow(temp0, temp1), Vector256.Narrow(temp2, temp3));
                temp0 = Vector256.ShiftRightLogical(temp0, L);
                temp1 = Vector256.ShiftRightLogical(temp1, L);
                temp2 = Vector256.ShiftRightLogical(temp2, L);
                temp3 = Vector256.ShiftRightLogical(temp3, L);
                rt3 = Vector256.Narrow(Vector256.Narrow(temp0, temp1), Vector256.Narrow(temp2, temp3));
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup4Unzip_Narrow(Vector256<short> data0, Vector256<short> data1, Vector256<short> data2, Vector256<short> data3, out Vector256<short> y, out Vector256<short> z, out Vector256<short> w) {
                var d0 = YGroup4Unzip_Narrow(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), data3.AsUInt16(), out var d1, out var d2, out var d3);
                y = d1.AsInt16();
                z = d2.AsInt16();
                w = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup4Unzip_Narrow(Vector256<ushort> data0, Vector256<ushort> data1, Vector256<ushort> data2, Vector256<ushort> data3, out Vector256<ushort> y, out Vector256<ushort> z, out Vector256<ushort> w) {
                const int L = 16;
                Vector256<ushort> rt0, rt1, rt2, rt3;
                Vector256<ulong> temp0, temp1, temp2, temp3;
                temp0 = data0.AsUInt64();
                temp1 = data1.AsUInt64();
                temp2 = data2.AsUInt64();
                temp3 = data3.AsUInt64();
                rt0 = Vector256.Narrow(Vector256.Narrow(temp0, temp1), Vector256.Narrow(temp2, temp3));
                temp0 = Vector256.ShiftRightLogical(temp0, L);
                temp1 = Vector256.ShiftRightLogical(temp1, L);
                temp2 = Vector256.ShiftRightLogical(temp2, L);
                temp3 = Vector256.ShiftRightLogical(temp3, L);
                rt1 = Vector256.Narrow(Vector256.Narrow(temp0, temp1), Vector256.Narrow(temp2, temp3));
                temp0 = Vector256.ShiftRightLogical(temp0, L);
                temp1 = Vector256.ShiftRightLogical(temp1, L);
                temp2 = Vector256.ShiftRightLogical(temp2, L);
                temp3 = Vector256.ShiftRightLogical(temp3, L);
                rt2 = Vector256.Narrow(Vector256.Narrow(temp0, temp1), Vector256.Narrow(temp2, temp3));
                temp0 = Vector256.ShiftRightLogical(temp0, L);
                temp1 = Vector256.ShiftRightLogical(temp1, L);
                temp2 = Vector256.ShiftRightLogical(temp2, L);
                temp3 = Vector256.ShiftRightLogical(temp3, L);
                rt3 = Vector256.Narrow(Vector256.Narrow(temp0, temp1), Vector256.Narrow(temp2, temp3));
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup4Unzip_Unzip(Vector256<float> data0, Vector256<float> data1, Vector256<float> data2, Vector256<float> data3, out Vector256<float> y, out Vector256<float> z, out Vector256<float> w) {
                var d0 = YGroup4Unzip_Unzip(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), out var d1, out var d2, out var d3);
                y = d1.AsSingle();
                z = d2.AsSingle();
                w = d3.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup4Unzip_Unzip(Vector256<sbyte> data0, Vector256<sbyte> data1, Vector256<sbyte> data2, Vector256<sbyte> data3, out Vector256<sbyte> y, out Vector256<sbyte> z, out Vector256<sbyte> w) {
                var d0 = YGroup4Unzip_Unzip(data0.AsByte(), data1.AsByte(), data2.AsByte(), data3.AsByte(), out var d1, out var d2, out var d3);
                y = d1.AsSByte();
                z = d2.AsSByte();
                w = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup4Unzip_Unzip(Vector256<byte> data0, Vector256<byte> data1, Vector256<byte> data2, Vector256<byte> data3, out Vector256<byte> y, out Vector256<byte> z, out Vector256<byte> w) {
                Vector256<byte> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup4Unzip_Unzip(Vector256<short> data0, Vector256<short> data1, Vector256<short> data2, Vector256<short> data3, out Vector256<short> y, out Vector256<short> z, out Vector256<short> w) {
                var d0 = YGroup4Unzip_Unzip(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), data3.AsUInt16(), out var d1, out var d2, out var d3);
                y = d1.AsInt16();
                z = d2.AsInt16();
                w = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup4Unzip_Unzip(Vector256<ushort> data0, Vector256<ushort> data1, Vector256<ushort> data2, Vector256<ushort> data3, out Vector256<ushort> y, out Vector256<ushort> z, out Vector256<ushort> w) {
                Vector256<ushort> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup4Unzip_Unzip(Vector256<int> data0, Vector256<int> data1, Vector256<int> data2, Vector256<int> data3, out Vector256<int> y, out Vector256<int> z, out Vector256<int> w) {
                var d0 = YGroup4Unzip_Unzip(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), out var d1, out var d2, out var d3);
                y = d1.AsInt32();
                z = d2.AsInt32();
                w = d3.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup4Unzip_Unzip(Vector256<uint> data0, Vector256<uint> data1, Vector256<uint> data2, Vector256<uint> data3, out Vector256<uint> y, out Vector256<uint> z, out Vector256<uint> w) {
                Vector256<uint> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
                // 0 data0 x0 y0 z0 w0 x1 y1 z1 w1 data1 x2 y2 z2 w2 x3 y3 z3 w3 data2 x4 y4 z4 w4 x5 y5 z5 w5 data3 x6 y6 z6 w6 x7 y7 z7 w7
                // 1 a_0 x0 z0 x1 z1 x2 z2 x3 z3 a_1 x4 z4 x5 z5 x6 z6 x7 z7 a_2 y0 w0 y1 w1 y2 w2 y3 w3 a_3 y4 w4 y5 w5 y6 w6 y7 w7
                a_0 = YGroup2Unzip(data0, data1, out a_2);
                a_1 = YGroup2Unzip(data2, data3, out a_3);
                // 2 b_0 x0 x1 x2 x3 x4 x5 x6 x7 b_1 y0 y1 y2 y3 y4 y5 y6 y7 b_2 z0 z1 z2 z3 z4 z5 z6 z7 b_3 w0 w1 w2 w3 w4 w5 w6 w7
                b_0 = YGroup2Unzip(a_0, a_1, out b_2);
                b_1 = YGroup2Unzip(a_2, a_3, out b_3);
                y = b_1;
                z = b_2;
                w = b_3;
                return b_0;
            }

#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup4Zip_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector256.IsHardwareAccelerated) {
                        rt = TypeCodeFlagsUtil.Most32Types;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }
            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup4Zip(Vector256<float> x, Vector256<float> y, Vector256<float> z, Vector256<float> w, out Vector256<float> data1, out Vector256<float> data2, out Vector256<float> data3) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup4Zip_Basic(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup4Zip(Vector256<double> x, Vector256<double> y, Vector256<double> z, Vector256<double> w, out Vector256<double> data1, out Vector256<double> data2, out Vector256<double> data3) {
                return YGroup4Zip_Basic(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup4Zip(Vector256<sbyte> x, Vector256<sbyte> y, Vector256<sbyte> z, Vector256<sbyte> w, out Vector256<sbyte> data1, out Vector256<sbyte> data2, out Vector256<sbyte> data3) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup4Zip_Basic(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup4Zip(Vector256<byte> x, Vector256<byte> y, Vector256<byte> z, Vector256<byte> w, out Vector256<byte> data1, out Vector256<byte> data2, out Vector256<byte> data3) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup4Zip_Basic(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup4Zip(Vector256<short> x, Vector256<short> y, Vector256<short> z, Vector256<short> w, out Vector256<short> data1, out Vector256<short> data2, out Vector256<short> data3) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup4Zip_Basic(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup4Zip(Vector256<ushort> x, Vector256<ushort> y, Vector256<ushort> z, Vector256<ushort> w, out Vector256<ushort> data1, out Vector256<ushort> data2, out Vector256<ushort> data3) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup4Zip_Basic(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup4Zip(Vector256<int> x, Vector256<int> y, Vector256<int> z, Vector256<int> w, out Vector256<int> data1, out Vector256<int> data2, out Vector256<int> data3) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup4Zip_Basic(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup4Zip(Vector256<uint> x, Vector256<uint> y, Vector256<uint> z, Vector256<uint> w, out Vector256<uint> data1, out Vector256<uint> data2, out Vector256<uint> data3) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector256.IsHardwareAccelerated) {
                    return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup4Zip_Basic(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup4Zip(Vector256<long> x, Vector256<long> y, Vector256<long> z, Vector256<long> w, out Vector256<long> data1, out Vector256<long> data2, out Vector256<long> data3) {
                return YGroup4Zip_Basic(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup4Zip(Vector256<ulong> x, Vector256<ulong> y, Vector256<ulong> z, Vector256<ulong> w, out Vector256<ulong> data1, out Vector256<ulong> data2, out Vector256<ulong> data3) {
                return YGroup4Zip_Basic(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{ExInt128}, Vector256{ExInt128}, Vector256{ExInt128}, Vector256{ExInt128}, out Vector256{ExInt128}, out Vector256{ExInt128}, out Vector256{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExInt128> YGroup4Zip(Vector256<ExInt128> x, Vector256<ExInt128> y, Vector256<ExInt128> z, Vector256<ExInt128> w, out Vector256<ExInt128> data1, out Vector256<ExInt128> data2, out Vector256<ExInt128> data3) {
                return YGroup4Zip_Move(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{ExUInt128}, Vector256{ExUInt128}, Vector256{ExUInt128}, Vector256{ExUInt128}, out Vector256{ExUInt128}, out Vector256{ExUInt128}, out Vector256{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExUInt128> YGroup4Zip(Vector256<ExUInt128> x, Vector256<ExUInt128> y, Vector256<ExUInt128> z, Vector256<ExUInt128> w, out Vector256<ExUInt128> data1, out Vector256<ExUInt128> data2, out Vector256<ExUInt128> data3) {
                return YGroup4Zip_Move(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip_Bit128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<T> YGroup4Zip_Bit128<T>(Vector256<T> x, Vector256<T> y, Vector256<T> z, Vector256<T> w, out Vector256<T> data1, out Vector256<T> data2, out Vector256<T> data3) where T : struct {
#if EX_APPLY_GENERIC
                var d0 = YGroup4Zip(x.ExAs<T, ExUInt128>(), y.ExAs<T, ExUInt128>(), z.ExAs<T, ExUInt128>(), w.ExAs<T, ExUInt128>(), out var d1, out var d2, out var d3);
                data1 = d1.ExAs<ExUInt128, T>();
                data2 = d2.ExAs<ExUInt128, T>();
                data3 = d3.ExAs<ExUInt128, T>();
                return d0.ExAs<ExUInt128, T>();
#else
                var a0 = x;
                var a1 = y;
                var a2 = z;
                var a3 = w;
                var c0 = a0.WithUpper(a1.GetLower());
                var c1 = a2.WithUpper(a3.GetLower());
                var c2 = a0.GetUpper().ToVector256Unsafe().WithUpper(a1.GetUpper());
                var c3 = a2.GetUpper().ToVector256Unsafe().WithUpper(a3.GetUpper());
                data1 = c1;
                data2 = c2;
                data3 = c3;
                return c0;
#endif // EX_APPLY_GENERIC
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup4Zip_Basic(Vector256<float> x, Vector256<float> y, Vector256<float> z, Vector256<float> w, out Vector256<float> data1, out Vector256<float> data2, out Vector256<float> data3) {
                var d0 = YGroup4Zip_Basic(x.AsUInt32(), y.AsUInt32(), z.AsUInt32(), w.AsUInt32(), out var d1, out var d2, out var d3);
                data1 = d1.AsSingle();
                data2 = d2.AsSingle();
                data3 = d3.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup4Zip_Basic(Vector256<double> x, Vector256<double> y, Vector256<double> z, Vector256<double> w, out Vector256<double> data1, out Vector256<double> data2, out Vector256<double> data3) {
                var d0 = YGroup4Zip_Basic(x.AsUInt64(), y.AsUInt64(), z.AsUInt64(), w.AsUInt64(), out var d1, out var d2, out var d3);
                data1 = d1.AsDouble();
                data2 = d2.AsDouble();
                data3 = d3.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup4Zip_Basic(Vector256<sbyte> x, Vector256<sbyte> y, Vector256<sbyte> z, Vector256<sbyte> w, out Vector256<sbyte> data1, out Vector256<sbyte> data2, out Vector256<sbyte> data3) {
                var d0 = YGroup4Zip_Basic(x.AsByte(), y.AsByte(), z.AsByte(), w.AsByte(), out var d1, out var d2, out var d3);
                data1 = d1.AsSByte();
                data2 = d2.AsSByte();
                data3 = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup4Zip_Basic(Vector256<byte> x, Vector256<byte> y, Vector256<byte> z, Vector256<byte> w, out Vector256<byte> data1, out Vector256<byte> data2, out Vector256<byte> data3) {
                Span<Vector256<byte>> rt = stackalloc Vector256<byte>[4];
                ref byte px = ref Unsafe.As<Vector256<byte>, byte>(ref x);
                ref byte py = ref Unsafe.As<Vector256<byte>, byte>(ref y);
                ref byte pz = ref Unsafe.As<Vector256<byte>, byte>(ref z);
                ref byte pw = ref Unsafe.As<Vector256<byte>, byte>(ref w);
                Span<byte> q = MemoryMarshal.Cast<Vector256<byte>, byte>(rt);
                int idx = 0;
                for (int i = 0; i < Vector256<byte>.Count; ++i) {
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup4Zip_Basic(Vector256<short> x, Vector256<short> y, Vector256<short> z, Vector256<short> w, out Vector256<short> data1, out Vector256<short> data2, out Vector256<short> data3) {
                var d0 = YGroup4Zip_Basic(x.AsUInt16(), y.AsUInt16(), z.AsUInt16(), w.AsUInt16(), out var d1, out var d2, out var d3);
                data1 = d1.AsInt16();
                data2 = d2.AsInt16();
                data3 = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup4Zip_Basic(Vector256<ushort> x, Vector256<ushort> y, Vector256<ushort> z, Vector256<ushort> w, out Vector256<ushort> data1, out Vector256<ushort> data2, out Vector256<ushort> data3) {
                Span<Vector256<ushort>> rt = stackalloc Vector256<ushort>[4];
                ref ushort px = ref Unsafe.As<Vector256<ushort>, ushort>(ref x);
                ref ushort py = ref Unsafe.As<Vector256<ushort>, ushort>(ref y);
                ref ushort pz = ref Unsafe.As<Vector256<ushort>, ushort>(ref z);
                ref ushort pw = ref Unsafe.As<Vector256<ushort>, ushort>(ref w);
                Span<ushort> q = MemoryMarshal.Cast<Vector256<ushort>, ushort>(rt);
                int idx = 0;
                for (int i = 0; i < Vector256<ushort>.Count; ++i) {
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup4Zip_Basic(Vector256<int> x, Vector256<int> y, Vector256<int> z, Vector256<int> w, out Vector256<int> data1, out Vector256<int> data2, out Vector256<int> data3) {
                var d0 = YGroup4Zip_Basic(x.AsUInt32(), y.AsUInt32(), z.AsUInt32(), w.AsUInt32(), out var d1, out var d2, out var d3);
                data1 = d1.AsInt32();
                data2 = d2.AsInt32();
                data3 = d3.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup4Zip_Basic(Vector256<uint> x, Vector256<uint> y, Vector256<uint> z, Vector256<uint> w, out Vector256<uint> data1, out Vector256<uint> data2, out Vector256<uint> data3) {
                Span<Vector256<uint>> rt = stackalloc Vector256<uint>[4];
                ref uint px = ref Unsafe.As<Vector256<uint>, uint>(ref x);
                ref uint py = ref Unsafe.As<Vector256<uint>, uint>(ref y);
                ref uint pz = ref Unsafe.As<Vector256<uint>, uint>(ref z);
                ref uint pw = ref Unsafe.As<Vector256<uint>, uint>(ref w);
                Span<uint> q = MemoryMarshal.Cast<Vector256<uint>, uint>(rt);
                int idx = 0;
                for (int i = 0; i < Vector256<uint>.Count; ++i) {
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup4Zip_Basic(Vector256<long> x, Vector256<long> y, Vector256<long> z, Vector256<long> w, out Vector256<long> data1, out Vector256<long> data2, out Vector256<long> data3) {
                var d0 = YGroup4Zip_Basic(x.AsUInt64(), y.AsUInt64(), z.AsUInt64(), w.AsUInt64(), out var d1, out var d2, out var d3);
                data1 = d1.AsInt64();
                data2 = d2.AsInt64();
                data3 = d3.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup4Zip_Basic(Vector256<ulong> x, Vector256<ulong> y, Vector256<ulong> z, Vector256<ulong> w, out Vector256<ulong> data1, out Vector256<ulong> data2, out Vector256<ulong> data3) {
                Span<Vector256<ulong>> rt = stackalloc Vector256<ulong>[4];
                ref ulong px = ref Unsafe.As<Vector256<ulong>, ulong>(ref x);
                ref ulong py = ref Unsafe.As<Vector256<ulong>, ulong>(ref y);
                ref ulong pz = ref Unsafe.As<Vector256<ulong>, ulong>(ref z);
                ref ulong pw = ref Unsafe.As<Vector256<ulong>, ulong>(ref w);
                Span<ulong> q = MemoryMarshal.Cast<Vector256<ulong>, ulong>(rt);
                int idx = 0;
                for (int i = 0; i < Vector256<ulong>.Count; ++i) {
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{ExInt128}, Vector256{ExInt128}, Vector256{ExInt128}, Vector256{ExInt128}, out Vector256{ExInt128}, out Vector256{ExInt128}, out Vector256{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExInt128> YGroup4Zip_Basic(Vector256<ExInt128> x, Vector256<ExInt128> y, Vector256<ExInt128> z, Vector256<ExInt128> w, out Vector256<ExInt128> data1, out Vector256<ExInt128> data2, out Vector256<ExInt128> data3) {
                var d0 = YGroup4Zip_Basic(x.ExAsExUInt128(), y.ExAsExUInt128(), z.ExAsExUInt128(), w.ExAsExUInt128(), out var d1, out var d2, out var d3);
                data1 = d1.ExAsExInt128();
                data2 = d2.ExAsExInt128();
                data3 = d3.ExAsExInt128();
                return d0.ExAsExInt128();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{ExUInt128}, Vector256{ExUInt128}, Vector256{ExUInt128}, Vector256{ExUInt128}, out Vector256{ExUInt128}, out Vector256{ExUInt128}, out Vector256{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExUInt128> YGroup4Zip_Basic(Vector256<ExUInt128> x, Vector256<ExUInt128> y, Vector256<ExUInt128> z, Vector256<ExUInt128> w, out Vector256<ExUInt128> data1, out Vector256<ExUInt128> data2, out Vector256<ExUInt128> data3) {
                Span<Vector256<ExUInt128>> rt = stackalloc Vector256<ExUInt128>[4];
                ref ExUInt128 px = ref Unsafe.As<Vector256<ExUInt128>, ExUInt128>(ref x);
                ref ExUInt128 py = ref Unsafe.As<Vector256<ExUInt128>, ExUInt128>(ref y);
                ref ExUInt128 pz = ref Unsafe.As<Vector256<ExUInt128>, ExUInt128>(ref z);
                ref ExUInt128 pw = ref Unsafe.As<Vector256<ExUInt128>, ExUInt128>(ref w);
                Span<ExUInt128> q = MemoryMarshal.Cast<Vector256<ExUInt128>, ExUInt128>(rt);
                int cnt = Vector256s<ExUInt128>.Count;
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{ExInt128}, Vector256{ExInt128}, Vector256{ExInt128}, Vector256{ExInt128}, out Vector256{ExInt128}, out Vector256{ExInt128}, out Vector256{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExInt128> YGroup4Zip_Move(Vector256<ExInt128> x, Vector256<ExInt128> y, Vector256<ExInt128> z, Vector256<ExInt128> w, out Vector256<ExInt128> data1, out Vector256<ExInt128> data2, out Vector256<ExInt128> data3) {
                var d0 = YGroup4Zip_Move(x.ExAsExUInt128(), y.ExAsExUInt128(), z.ExAsExUInt128(), w.ExAsExUInt128(), out var d1, out var d2, out var d3);
                data1 = d1.ExAsExInt128();
                data2 = d2.ExAsExInt128();
                data3 = d3.ExAsExInt128();
                return d0.ExAsExInt128();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{ExUInt128}, Vector256{ExUInt128}, Vector256{ExUInt128}, Vector256{ExUInt128}, out Vector256{ExUInt128}, out Vector256{ExUInt128}, out Vector256{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExUInt128> YGroup4Zip_Move(Vector256<ExUInt128> x, Vector256<ExUInt128> y, Vector256<ExUInt128> z, Vector256<ExUInt128> w, out Vector256<ExUInt128> data1, out Vector256<ExUInt128> data2, out Vector256<ExUInt128> data3) {
                var a0 = x.ExAsUInt64();
                var a1 = y.ExAsUInt64();
                var a2 = z.ExAsUInt64();
                var a3 = w.ExAsUInt64();
                var c0 = a0.WithUpper(a1.GetLower());
                var c1 = a2.WithUpper(a3.GetLower());
                var c2 = a0.GetUpper().ToVector256Unsafe().WithUpper(a1.GetUpper());
                var c3 = a2.GetUpper().ToVector256Unsafe().WithUpper(a3.GetUpper());
                data1 = c1.ExAsExUInt128();
                data2 = c2.ExAsExUInt128();
                data3 = c3.ExAsExUInt128();
                return c0.ExAsExUInt128();
            }

#if VECTOR_HAS_METHOD

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup4Zip_Widen(Vector256<sbyte> x, Vector256<sbyte> y, Vector256<sbyte> z, Vector256<sbyte> w, out Vector256<sbyte> data1, out Vector256<sbyte> data2, out Vector256<sbyte> data3) {
                var d0 = YGroup4Zip_Widen(x.AsByte(), y.AsByte(), z.AsByte(), w.AsByte(), out var d1, out var d2, out var d3);
                data1 = d1.AsSByte();
                data2 = d2.AsSByte();
                data3 = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup4Zip_Widen(Vector256<byte> x, Vector256<byte> y, Vector256<byte> z, Vector256<byte> w, out Vector256<byte> data1, out Vector256<byte> data2, out Vector256<byte> data3) {
                const int L = 8;
                Vector256<byte> s0, s1, s2, s3;
                Vector256<ushort> t0, t1;
                Vector256<uint> r0, r1, r2, r3, d0, d1, d2, d3;
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
                (t0, t1) = Vector256.Widen(s0);
                (r0, r1) = Vector256.Widen(t0);
                (r2, r3) = Vector256.Widen(t1);
                d0 = Vector256.ShiftLeft(r0, L);
                d1 = Vector256.ShiftLeft(r1, L);
                d2 = Vector256.ShiftLeft(r2, L);
                d3 = Vector256.ShiftLeft(r3, L);
                // Part 1
                (t0, t1) = Vector256.Widen(s1);
                (r0, r1) = Vector256.Widen(t0);
                (r2, r3) = Vector256.Widen(t1);
                d0 = Vector256.BitwiseOr(d0, r0);
                d1 = Vector256.BitwiseOr(d1, r1);
                d2 = Vector256.BitwiseOr(d2, r2);
                d3 = Vector256.BitwiseOr(d3, r3);
                d0 = Vector256.ShiftLeft(d0, L);
                d1 = Vector256.ShiftLeft(d1, L);
                d2 = Vector256.ShiftLeft(d2, L);
                d3 = Vector256.ShiftLeft(d3, L);
                // Part 2
                (t0, t1) = Vector256.Widen(s2);
                (r0, r1) = Vector256.Widen(t0);
                (r2, r3) = Vector256.Widen(t1);
                d0 = Vector256.BitwiseOr(d0, r0);
                d1 = Vector256.BitwiseOr(d1, r1);
                d2 = Vector256.BitwiseOr(d2, r2);
                d3 = Vector256.BitwiseOr(d3, r3);
                d0 = Vector256.ShiftLeft(d0, L);
                d1 = Vector256.ShiftLeft(d1, L);
                d2 = Vector256.ShiftLeft(d2, L);
                d3 = Vector256.ShiftLeft(d3, L);
                // Part 3
                (t0, t1) = Vector256.Widen(s3);
                (r0, r1) = Vector256.Widen(t0);
                (r2, r3) = Vector256.Widen(t1);
                d0 = Vector256.BitwiseOr(d0, r0);
                d1 = Vector256.BitwiseOr(d1, r1);
                d2 = Vector256.BitwiseOr(d2, r2);
                d3 = Vector256.BitwiseOr(d3, r3);
                // done.
                data1 = d1.AsByte();
                data2 = d2.AsByte();
                data3 = d3.AsByte();
                return d0.AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup4Zip_Widen(Vector256<short> x, Vector256<short> y, Vector256<short> z, Vector256<short> w, out Vector256<short> data1, out Vector256<short> data2, out Vector256<short> data3) {
                var d0 = YGroup4Zip_Widen(x.AsUInt16(), y.AsUInt16(), z.AsUInt16(), w.AsUInt16(), out var d1, out var d2, out var d3);
                data1 = d1.AsInt16();
                data2 = d2.AsInt16();
                data3 = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup4Zip_Widen(Vector256<ushort> x, Vector256<ushort> y, Vector256<ushort> z, Vector256<ushort> w, out Vector256<ushort> data1, out Vector256<ushort> data2, out Vector256<ushort> data3) {
                const int L = 16;
                Vector256<ushort> s0, s1, s2, s3;
                Vector256<uint> t0, t1;
                Vector256<ulong> r0, r1, r2, r3, d0, d1, d2, d3;
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
                (t0, t1) = Vector256.Widen(s0);
                (r0, r1) = Vector256.Widen(t0);
                (r2, r3) = Vector256.Widen(t1);
                d0 = Vector256.ShiftLeft(r0, L);
                d1 = Vector256.ShiftLeft(r1, L);
                d2 = Vector256.ShiftLeft(r2, L);
                d3 = Vector256.ShiftLeft(r3, L);
                // Part 1
                (t0, t1) = Vector256.Widen(s1);
                (r0, r1) = Vector256.Widen(t0);
                (r2, r3) = Vector256.Widen(t1);
                d0 = Vector256.BitwiseOr(d0, r0);
                d1 = Vector256.BitwiseOr(d1, r1);
                d2 = Vector256.BitwiseOr(d2, r2);
                d3 = Vector256.BitwiseOr(d3, r3);
                d0 = Vector256.ShiftLeft(d0, L);
                d1 = Vector256.ShiftLeft(d1, L);
                d2 = Vector256.ShiftLeft(d2, L);
                d3 = Vector256.ShiftLeft(d3, L);
                // Part 2
                (t0, t1) = Vector256.Widen(s2);
                (r0, r1) = Vector256.Widen(t0);
                (r2, r3) = Vector256.Widen(t1);
                d0 = Vector256.BitwiseOr(d0, r0);
                d1 = Vector256.BitwiseOr(d1, r1);
                d2 = Vector256.BitwiseOr(d2, r2);
                d3 = Vector256.BitwiseOr(d3, r3);
                d0 = Vector256.ShiftLeft(d0, L);
                d1 = Vector256.ShiftLeft(d1, L);
                d2 = Vector256.ShiftLeft(d2, L);
                d3 = Vector256.ShiftLeft(d3, L);
                // Part 3
                (t0, t1) = Vector256.Widen(s3);
                (r0, r1) = Vector256.Widen(t0);
                (r2, r3) = Vector256.Widen(t1);
                d0 = Vector256.BitwiseOr(d0, r0);
                d1 = Vector256.BitwiseOr(d1, r1);
                d2 = Vector256.BitwiseOr(d2, r2);
                d3 = Vector256.BitwiseOr(d3, r3);
                // done.
                data1 = d1.AsUInt16();
                data2 = d2.AsUInt16();
                data3 = d3.AsUInt16();
                return d0.AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup4Zip_Zip(Vector256<float> x, Vector256<float> y, Vector256<float> z, Vector256<float> w, out Vector256<float> data1, out Vector256<float> data2, out Vector256<float> data3) {
                var d0 = YGroup4Zip_Zip(x.AsUInt32(), y.AsUInt32(), z.AsUInt32(), w.AsUInt32(), out var d1, out var d2, out var d3);
                data1 = d1.AsSingle();
                data2 = d2.AsSingle();
                data3 = d3.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup4Zip_Zip(Vector256<sbyte> x, Vector256<sbyte> y, Vector256<sbyte> z, Vector256<sbyte> w, out Vector256<sbyte> data1, out Vector256<sbyte> data2, out Vector256<sbyte> data3) {
                var d0 = YGroup4Zip_Zip(x.AsByte(), y.AsByte(), z.AsByte(), w.AsByte(), out var d1, out var d2, out var d3);
                data1 = d1.AsSByte();
                data2 = d2.AsSByte();
                data3 = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup4Zip_Zip(Vector256<byte> x, Vector256<byte> y, Vector256<byte> z, Vector256<byte> w, out Vector256<byte> data1, out Vector256<byte> data2, out Vector256<byte> data3) {
                Vector256<byte> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
                // 0 _x_ x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 x16 x17 x18 x19 x20 x21 x22 x23 x24 x25 x26 x27 x28 x29 x30 x31 _y_ y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 y16 y17 y18 y19 y20 y21 y22 y23 y24 y25 y26 y27 y28 y29 y30 y31 _z_ z0 z1 z2 z3 z4 z5 z6 z7 z8 z9 z10 z11 z12 z13 z14 z15 z16 z17 z18 z19 z20 z21 z22 z23 z24 z25 z26 z27 z28 z29 z30 z31 _w_ w0 w1 w2 w3 w4 w5 w6 w7 w8 w9 w10 w11 w12 w13 w14 w15 w16 w17 w18 w19 w20 w21 w22 w23 w24 w25 w26 w27 w28 w29 w30 w31
                // 1 a_0 x0 z0 x1 z1 x2 z2 x3 z3 x4 z4 x5 z5 x6 z6 x7 z7 x8 z8 x9 z9 x10 z10 x11 z11 x12 z12 x13 z13 x14 z14 x15 z15 a_1 x16 z16 x17 z17 x18 z18 x19 z19 x20 z20 x21 z21 x22 z22 x23 z23 x24 z24 x25 z25 x26 z26 x27 z27 x28 z28 x29 z29 x30 z30 x31 z31 a_2 y0 w0 y1 w1 y2 w2 y3 w3 y4 w4 y5 w5 y6 w6 y7 w7 y8 w8 y9 w9 y10 w10 y11 w11 y12 w12 y13 w13 y14 w14 y15 w15 a_3 y16 w16 y17 w17 y18 w18 y19 w19 y20 w20 y21 w21 y22 w22 y23 w23 y24 w24 y25 w25 y26 w26 y27 w27 y28 w28 y29 w29 y30 w30 y31 w31
                a_0 = YGroup2Zip(x, z, out a_1);
                a_2 = YGroup2Zip(y, w, out a_3);
                // 2 b_0 x0 y0 z0 w0 x1 y1 z1 w1 x2 y2 z2 w2 x3 y3 z3 w3 x4 y4 z4 w4 x5 y5 z5 w5 x6 y6 z6 w6 x7 y7 z7 w7 b_1 x8 y8 z8 w8 x9 y9 z9 w9 x10 y10 z10 w10 x11 y11 z11 w11 x12 y12 z12 w12 x13 y13 z13 w13 x14 y14 z14 w14 x15 y15 z15 w15 b_2 x16 y16 z16 w16 x17 y17 z17 w17 x18 y18 z18 w18 x19 y19 z19 w19 x20 y20 z20 w20 x21 y21 z21 w21 x22 y22 z22 w22 x23 y23 z23 w23 b_3 x24 y24 z24 w24 x25 y25 z25 w25 x26 y26 z26 w26 x27 y27 z27 w27 x28 y28 z28 w28 x29 y29 z29 w29 x30 y30 z30 w30 x31 y31 z31 w31
                b_0 = YGroup2Zip(a_0, a_2, out b_1);
                b_2 = YGroup2Zip(a_1, a_3, out b_3);
                data1 = b_1;
                data2 = b_2;
                data3 = b_3;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup4Zip_Zip(Vector256<short> x, Vector256<short> y, Vector256<short> z, Vector256<short> w, out Vector256<short> data1, out Vector256<short> data2, out Vector256<short> data3) {
                var d0 = YGroup4Zip_Zip(x.AsUInt16(), y.AsUInt16(), z.AsUInt16(), w.AsUInt16(), out var d1, out var d2, out var d3);
                data1 = d1.AsInt16();
                data2 = d2.AsInt16();
                data3 = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup4Zip_Zip(Vector256<ushort> x, Vector256<ushort> y, Vector256<ushort> z, Vector256<ushort> w, out Vector256<ushort> data1, out Vector256<ushort> data2, out Vector256<ushort> data3) {
                Vector256<ushort> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup4Zip_Zip(Vector256<int> x, Vector256<int> y, Vector256<int> z, Vector256<int> w, out Vector256<int> data1, out Vector256<int> data2, out Vector256<int> data3) {
                var d0 = YGroup4Zip_Zip(x.AsUInt32(), y.AsUInt32(), z.AsUInt32(), w.AsUInt32(), out var d1, out var d2, out var d3);
                data1 = d1.AsInt32();
                data2 = d2.AsInt32();
                data3 = d3.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup4Zip_Zip(Vector256<uint> x, Vector256<uint> y, Vector256<uint> z, Vector256<uint> w, out Vector256<uint> data1, out Vector256<uint> data2, out Vector256<uint> data3) {
                Vector256<uint> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
                // 0 _x_ x0 x1 x2 x3 x4 x5 x6 x7 _y_ y0 y1 y2 y3 y4 y5 y6 y7 _z_ z0 z1 z2 z3 z4 z5 z6 z7 _w_ w0 w1 w2 w3 w4 w5 w6 w7
                // 1 a_0 x0 z0 x1 z1 x2 z2 x3 z3 a_1 x4 z4 x5 z5 x6 z6 x7 z7 a_2 y0 w0 y1 w1 y2 w2 y3 w3 a_3 y4 w4 y5 w5 y6 w6 y7 w7
                a_0 = YGroup2Zip(x, z, out a_1);
                a_2 = YGroup2Zip(y, w, out a_3);
                // 2 b_0 x0 y0 z0 w0 x1 y1 z1 w1 b_1 x2 y2 z2 w2 x3 y3 z3 w3 b_2 x4 y4 z4 w4 x5 y5 z5 w5 b_3 x6 y6 z6 w6 x7 y7 z7 w7
                b_0 = YGroup2Zip(a_0, a_2, out b_1);
                b_2 = YGroup2Zip(a_1, a_3, out b_3);
                data1 = b_1;
                data2 = b_2;
                data3 = b_3;
                return b_0;
            }

#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits256.YGroup6Unzip_Bit128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<T> YGroup6Unzip_Bit128<T>(Vector256<T> data0, Vector256<T> data1, Vector256<T> data2, Vector256<T> data3, Vector256<T> data4, Vector256<T> data5, out Vector256<T> y, out Vector256<T> z, out Vector256<T> w, out Vector256<T> u, out Vector256<T> v) where T : struct {
                // 0 data0 x0 y0 data1 z0 w0 data2 u0 v0 data3 x1 y1 data4 z1 w1 data5 u1 v1
                // 1 a_0 x0 x1 a_1 y0 y1 a_2 z0 z1 a_3 w0 w1 a_4 u0 u1 a_5 v0 v1
                var a_0 = YGroup2Unzip_Bit128(data0, data3, out var a_1);
                var a_2 = YGroup2Unzip_Bit128(data1, data4, out var a_3);
                var a_4 = YGroup2Unzip_Bit128(data2, data5, out var a_5);
                y = a_1;
                z = a_2;
                w = a_3;
                u = a_4;
                v = a_5;
                return a_0;
            }


            /// <inheritdoc cref="IWVectorTraits256.YGroup6Zip_Bit128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<T> YGroup6Zip_Bit128<T>(Vector256<T> x, Vector256<T> y, Vector256<T> z, Vector256<T> w, Vector256<T> u, Vector256<T> v, out Vector256<T> data1, out Vector256<T> data2, out Vector256<T> data3, out Vector256<T> data4, out Vector256<T> data5) where T : struct {
                // 0 _x_ x0 x1 _y_ y0 y1 _z_ z0 z1 _w_ w0 w1 _u_ u0 u1 _v_ v0 v1
                // 1 a_0 x0 y0 a_1 z0 w0 a_2 u0 v0 a_3 x1 y1 a_4 z1 w1 a_5 u1 v1
                var a_0 = YGroup2Zip_Bit128(x, y, out var a_3);
                var a_1 = YGroup2Zip_Bit128(z, w, out var a_4);
                var a_2 = YGroup2Zip_Bit128(u, v, out var a_5);
                data1 = a_1;
                data2 = a_2;
                data3 = a_3;
                data4 = a_4;
                data5 = a_5;
                return a_0;
            }

#endif // NETCOREAPP3_0_OR_GREATER
        }
    }
}
