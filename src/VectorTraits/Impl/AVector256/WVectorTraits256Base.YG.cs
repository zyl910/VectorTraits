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
using Zyl.VectorTraits.Impl.Util;

namespace Zyl.VectorTraits.Impl.AVector256 {
    partial class WVectorTraits256Base {

        partial class Statics {

#if NETCOREAPP3_0_OR_GREATER

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
                return YGroup2Unzip_Narrow(data0, data1, out y);
#else
                return YGroup2Unzip_Basic(data0, data1, out y);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
                return YGroup2Unzip_Narrow(data0, data1, out y);
#else
                return YGroup2Unzip_Basic(data0, data1, out y);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{byte}, Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2Unzip(Vector256<byte> data0, Vector256<byte> data1, out Vector256<byte> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Unzip_Narrow(data0, data1, out y);
#else
                return YGroup2Unzip_Basic(data0, data1, out y);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{short}, Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2Unzip(Vector256<short> data0, Vector256<short> data1, out Vector256<short> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Unzip_Narrow(data0, data1, out y);
#else
                return YGroup2Unzip_Basic(data0, data1, out y);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{ushort}, Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2Unzip(Vector256<ushort> data0, Vector256<ushort> data1, out Vector256<ushort> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Unzip_Narrow(data0, data1, out y);
#else
                return YGroup2Unzip_Basic(data0, data1, out y);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{int}, Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2Unzip(Vector256<int> data0, Vector256<int> data1, out Vector256<int> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Unzip_Narrow(data0, data1, out y);
#else
                return YGroup2Unzip_Basic(data0, data1, out y);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{uint}, Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2Unzip(Vector256<uint> data0, Vector256<uint> data1, out Vector256<uint> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Unzip_Narrow(data0, data1, out y);
#else
                return YGroup2Unzip_Basic(data0, data1, out y);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
                UnsafeUtil.SkipInit(out Vector256<byte> x1);
                UnsafeUtil.SkipInit(out Vector256<byte> y1);
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
                UnsafeUtil.SkipInit(out Vector256<ushort> x1);
                UnsafeUtil.SkipInit(out Vector256<ushort> y1);
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
                UnsafeUtil.SkipInit(out Vector256<uint> x1);
                UnsafeUtil.SkipInit(out Vector256<uint> y1);
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
                UnsafeUtil.SkipInit(out Vector256<ulong> x1);
                UnsafeUtil.SkipInit(out Vector256<ulong> y1);
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
                UnsafeUtil.SkipInit(out Vector256<ExUInt128> x1);
                UnsafeUtil.SkipInit(out Vector256<ExUInt128> y1);
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
                return YGroup2UnzipEven_Narrow(data0, data1);
#else
                return YGroup2UnzipEven_Basic(data0, data1);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
                return YGroup2UnzipEven_Narrow(data0, data1);
#else
                return YGroup2UnzipEven_Basic(data0, data1);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2UnzipEven(Vector256<byte> data0, Vector256<byte> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipEven_Narrow(data0, data1);
#else
                return YGroup2UnzipEven_Basic(data0, data1);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2UnzipEven(Vector256<short> data0, Vector256<short> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipEven_Narrow(data0, data1);
#else
                return YGroup2UnzipEven_Basic(data0, data1);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2UnzipEven(Vector256<ushort> data0, Vector256<ushort> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipEven_Narrow(data0, data1);
#else
                return YGroup2UnzipEven_Basic(data0, data1);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2UnzipEven(Vector256<int> data0, Vector256<int> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipEven_Narrow(data0, data1);
#else
                return YGroup2UnzipEven_Basic(data0, data1);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2UnzipEven(Vector256<uint> data0, Vector256<uint> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipEven_Narrow(data0, data1);
#else
                return YGroup2UnzipEven_Basic(data0, data1);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
                UnsafeUtil.SkipInit(out Vector256<byte> x1);
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
                UnsafeUtil.SkipInit(out Vector256<ushort> x1);
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
                UnsafeUtil.SkipInit(out Vector256<uint> x1);
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
                UnsafeUtil.SkipInit(out Vector256<ulong> x1);
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
                return YGroup2UnzipOdd_Narrow(data0, data1);
#else
                return YGroup2UnzipOdd_Basic(data0, data1);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
                return YGroup2UnzipOdd_Narrow(data0, data1);
#else
                return YGroup2UnzipOdd_Basic(data0, data1);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2UnzipOdd(Vector256<byte> data0, Vector256<byte> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipOdd_Narrow(data0, data1);
#else
                return YGroup2UnzipOdd_Basic(data0, data1);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2UnzipOdd(Vector256<short> data0, Vector256<short> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipOdd_Narrow(data0, data1);
#else
                return YGroup2UnzipOdd_Basic(data0, data1);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2UnzipOdd(Vector256<ushort> data0, Vector256<ushort> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipOdd_Narrow(data0, data1);
#else
                return YGroup2UnzipOdd_Basic(data0, data1);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2UnzipOdd(Vector256<int> data0, Vector256<int> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipOdd_Narrow(data0, data1);
#else
                return YGroup2UnzipOdd_Basic(data0, data1);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2UnzipOdd(Vector256<uint> data0, Vector256<uint> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipOdd_Narrow(data0, data1);
#else
                return YGroup2UnzipOdd_Basic(data0, data1);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
                UnsafeUtil.SkipInit(out Vector256<byte> y1);
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
                UnsafeUtil.SkipInit(out Vector256<ushort> y1);
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
                UnsafeUtil.SkipInit(out Vector256<uint> y1);
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
                UnsafeUtil.SkipInit(out Vector256<ulong> y1);
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
                return YGroup2Zip_Widen(x, y, out data1);
#else
                return YGroup2Zip_Basic(x, y, out data1);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
                return YGroup2Zip_Widen(x, y, out data1);
#else
                return YGroup2Zip_Basic(x, y, out data1);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{byte}, Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2Zip(Vector256<byte> x, Vector256<byte> y, out Vector256<byte> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Zip_Widen(x, y, out data1);
#else
                return YGroup2Zip_Basic(x, y, out data1);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{short}, Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2Zip(Vector256<short> x, Vector256<short> y, out Vector256<short> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Zip_Widen(x, y, out data1);
#else
                return YGroup2Zip_Basic(x, y, out data1);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{ushort}, Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2Zip(Vector256<ushort> x, Vector256<ushort> y, out Vector256<ushort> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Zip_Widen(x, y, out data1);
#else
                return YGroup2Zip_Basic(x, y, out data1);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{int}, Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2Zip(Vector256<int> x, Vector256<int> y, out Vector256<int> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Zip_Widen(x, y, out data1);
#else
                return YGroup2Zip_Basic(x, y, out data1);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{uint}, Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2Zip(Vector256<uint> x, Vector256<uint> y, out Vector256<uint> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Zip_Widen(x, y, out data1);
#else
                return YGroup2Zip_Basic(x, y, out data1);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
                return YGroup2ZipHigh_Widen(x, y);
#else
                return YGroup2ZipHigh_Basic(x, y);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
                return YGroup2ZipHigh_Widen(x, y);
#else
                return YGroup2ZipHigh_Basic(x, y);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2ZipHigh(Vector256<byte> x, Vector256<byte> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipHigh_Widen(x, y);
#else
                return YGroup2ZipHigh_Basic(x, y);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2ZipHigh(Vector256<short> x, Vector256<short> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipHigh_Widen(x, y);
#else
                return YGroup2ZipHigh_Basic(x, y);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2ZipHigh(Vector256<ushort> x, Vector256<ushort> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipHigh_Widen(x, y);
#else
                return YGroup2ZipHigh_Basic(x, y);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2ZipHigh(Vector256<int> x, Vector256<int> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipHigh_Widen(x, y);
#else
                return YGroup2ZipHigh_Basic(x, y);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2ZipHigh(Vector256<uint> x, Vector256<uint> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipHigh_Widen(x, y);
#else
                return YGroup2ZipHigh_Basic(x, y);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
                return YGroup2ZipLow_Widen(x, y);
#else
                return YGroup2ZipLow_Basic(x, y);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
                return YGroup2ZipLow_Widen(x, y);
#else
                return YGroup2ZipLow_Basic(x, y);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2ZipLow(Vector256<byte> x, Vector256<byte> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipLow_Widen(x, y);
#else
                return YGroup2ZipLow_Basic(x, y);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2ZipLow(Vector256<short> x, Vector256<short> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipLow_Widen(x, y);
#else
                return YGroup2ZipLow_Basic(x, y);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2ZipLow(Vector256<ushort> x, Vector256<ushort> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipLow_Widen(x, y);
#else
                return YGroup2ZipLow_Basic(x, y);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2ZipLow(Vector256<int> x, Vector256<int> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipLow_Widen(x, y);
#else
                return YGroup2ZipLow_Basic(x, y);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2ZipLow(Vector256<uint> x, Vector256<uint> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipLow_Widen(x, y);
#else
                return YGroup2ZipLow_Basic(x, y);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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

#endif // NETCOREAPP3_0_OR_GREATER
        }
    }
}
