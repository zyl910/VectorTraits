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

namespace Zyl.VectorTraits.Impl.AVector512 {
    partial class WVectorTraits512Base {

        partial class Statics {

#if NET8_0_OR_GREATER

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
                return YGroup2Unzip_Narrow(data0, data1, out y);
#else
                return YGroup2Unzip_Basic(data0, data1, out y);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
                return YGroup2Unzip_Narrow(data0, data1, out y);
#else
                return YGroup2Unzip_Basic(data0, data1, out y);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{byte}, Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup2Unzip(Vector512<byte> data0, Vector512<byte> data1, out Vector512<byte> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Unzip_Narrow(data0, data1, out y);
#else
                return YGroup2Unzip_Basic(data0, data1, out y);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{short}, Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup2Unzip(Vector512<short> data0, Vector512<short> data1, out Vector512<short> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Unzip_Narrow(data0, data1, out y);
#else
                return YGroup2Unzip_Basic(data0, data1, out y);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{ushort}, Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup2Unzip(Vector512<ushort> data0, Vector512<ushort> data1, out Vector512<ushort> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Unzip_Narrow(data0, data1, out y);
#else
                return YGroup2Unzip_Basic(data0, data1, out y);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{int}, Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup2Unzip(Vector512<int> data0, Vector512<int> data1, out Vector512<int> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Unzip_Narrow(data0, data1, out y);
#else
                return YGroup2Unzip_Basic(data0, data1, out y);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{uint}, Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup2Unzip(Vector512<uint> data0, Vector512<uint> data1, out Vector512<uint> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Unzip_Narrow(data0, data1, out y);
#else
                return YGroup2Unzip_Basic(data0, data1, out y);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip_Int128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<T> YGroup2Unzip_Int128<T>(Vector512<T> data0, Vector512<T> data1, out Vector512<T> y) where T : struct {
                var d0 = YGroup2Unzip_Move(data0.ExAsExUInt128(), data1.ExAsExUInt128(), out var d1);
                y = d1.ExAs<ExUInt128, T>();
                return d0.ExAs<ExUInt128, T>();
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
                return YGroup2UnzipEven_Narrow(data0, data1);
#else
                return YGroup2UnzipEven_Basic(data0, data1);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
                return YGroup2UnzipEven_Narrow(data0, data1);
#else
                return YGroup2UnzipEven_Basic(data0, data1);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup2UnzipEven(Vector512<byte> data0, Vector512<byte> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipEven_Narrow(data0, data1);
#else
                return YGroup2UnzipEven_Basic(data0, data1);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup2UnzipEven(Vector512<short> data0, Vector512<short> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipEven_Narrow(data0, data1);
#else
                return YGroup2UnzipEven_Basic(data0, data1);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup2UnzipEven(Vector512<ushort> data0, Vector512<ushort> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipEven_Narrow(data0, data1);
#else
                return YGroup2UnzipEven_Basic(data0, data1);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup2UnzipEven(Vector512<int> data0, Vector512<int> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipEven_Narrow(data0, data1);
#else
                return YGroup2UnzipEven_Basic(data0, data1);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup2UnzipEven(Vector512<uint> data0, Vector512<uint> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipEven_Narrow(data0, data1);
#else
                return YGroup2UnzipEven_Basic(data0, data1);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
                return YGroup2UnzipOdd_Narrow(data0, data1);
#else
                return YGroup2UnzipOdd_Basic(data0, data1);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
                return YGroup2UnzipOdd_Narrow(data0, data1);
#else
                return YGroup2UnzipOdd_Basic(data0, data1);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup2UnzipOdd(Vector512<byte> data0, Vector512<byte> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipOdd_Narrow(data0, data1);
#else
                return YGroup2UnzipOdd_Basic(data0, data1);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup2UnzipOdd(Vector512<short> data0, Vector512<short> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipOdd_Narrow(data0, data1);
#else
                return YGroup2UnzipOdd_Basic(data0, data1);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup2UnzipOdd(Vector512<ushort> data0, Vector512<ushort> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipOdd_Narrow(data0, data1);
#else
                return YGroup2UnzipOdd_Basic(data0, data1);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup2UnzipOdd(Vector512<int> data0, Vector512<int> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipOdd_Narrow(data0, data1);
#else
                return YGroup2UnzipOdd_Basic(data0, data1);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup2UnzipOdd(Vector512<uint> data0, Vector512<uint> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2UnzipOdd_Narrow(data0, data1);
#else
                return YGroup2UnzipOdd_Basic(data0, data1);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
                return YGroup2Zip_Widen(x, y, out data1);
#else
                return YGroup2Zip_Basic(x, y, out data1);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
                return YGroup2Zip_Widen(x, y, out data1);
#else
                return YGroup2Zip_Basic(x, y, out data1);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{byte}, Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup2Zip(Vector512<byte> x, Vector512<byte> y, out Vector512<byte> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Zip_Widen(x, y, out data1);
#else
                return YGroup2Zip_Basic(x, y, out data1);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{short}, Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup2Zip(Vector512<short> x, Vector512<short> y, out Vector512<short> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Zip_Widen(x, y, out data1);
#else
                return YGroup2Zip_Basic(x, y, out data1);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{ushort}, Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup2Zip(Vector512<ushort> x, Vector512<ushort> y, out Vector512<ushort> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Zip_Widen(x, y, out data1);
#else
                return YGroup2Zip_Basic(x, y, out data1);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{int}, Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup2Zip(Vector512<int> x, Vector512<int> y, out Vector512<int> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Zip_Widen(x, y, out data1);
#else
                return YGroup2Zip_Basic(x, y, out data1);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{uint}, Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup2Zip(Vector512<uint> x, Vector512<uint> y, out Vector512<uint> data1) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2Zip_Widen(x, y, out data1);
#else
                return YGroup2Zip_Basic(x, y, out data1);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip_Int128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<T> YGroup2Zip_Int128<T>(Vector512<T> x, Vector512<T> y, out Vector512<T> data1) where T : struct {
                var d0 = YGroup2Zip_Move(x.ExAsExUInt128(), y.ExAsExUInt128(), out var d1);
                data1 = d1.ExAs<ExUInt128, T>();
                return d0.ExAs<ExUInt128, T>();
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
                return YGroup2ZipHigh_Widen(x, y);
#else
                return YGroup2ZipHigh_Basic(x, y);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
                return YGroup2ZipHigh_Widen(x, y);
#else
                return YGroup2ZipHigh_Basic(x, y);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup2ZipHigh(Vector512<byte> x, Vector512<byte> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipHigh_Widen(x, y);
#else
                return YGroup2ZipHigh_Basic(x, y);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup2ZipHigh(Vector512<short> x, Vector512<short> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipHigh_Widen(x, y);
#else
                return YGroup2ZipHigh_Basic(x, y);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup2ZipHigh(Vector512<ushort> x, Vector512<ushort> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipHigh_Widen(x, y);
#else
                return YGroup2ZipHigh_Basic(x, y);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup2ZipHigh(Vector512<int> x, Vector512<int> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipHigh_Widen(x, y);
#else
                return YGroup2ZipHigh_Basic(x, y);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup2ZipHigh(Vector512<uint> x, Vector512<uint> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipHigh_Widen(x, y);
#else
                return YGroup2ZipHigh_Basic(x, y);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
                return YGroup2ZipLow_Widen(x, y);
#else
                return YGroup2ZipLow_Basic(x, y);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
                return YGroup2ZipLow_Widen(x, y);
#else
                return YGroup2ZipLow_Basic(x, y);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup2ZipLow(Vector512<byte> x, Vector512<byte> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipLow_Widen(x, y);
#else
                return YGroup2ZipLow_Basic(x, y);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup2ZipLow(Vector512<short> x, Vector512<short> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipLow_Widen(x, y);
#else
                return YGroup2ZipLow_Basic(x, y);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup2ZipLow(Vector512<ushort> x, Vector512<ushort> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipLow_Widen(x, y);
#else
                return YGroup2ZipLow_Basic(x, y);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup2ZipLow(Vector512<int> x, Vector512<int> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipLow_Widen(x, y);
#else
                return YGroup2ZipLow_Basic(x, y);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup2ZipLow(Vector512<uint> x, Vector512<uint> y) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup2ZipLow_Widen(x, y);
#else
                return YGroup2ZipLow_Basic(x, y);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
                return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
                return YGroup4Unzip_Basic(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
                return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
                return YGroup4Unzip_Basic(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup4Unzip(Vector512<byte> data0, Vector512<byte> data1, Vector512<byte> data2, Vector512<byte> data3, out Vector512<byte> y, out Vector512<byte> z, out Vector512<byte> w) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
                return YGroup4Unzip_Basic(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup4Unzip(Vector512<short> data0, Vector512<short> data1, Vector512<short> data2, Vector512<short> data3, out Vector512<short> y, out Vector512<short> z, out Vector512<short> w) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
                return YGroup4Unzip_Basic(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup4Unzip(Vector512<ushort> data0, Vector512<ushort> data1, Vector512<ushort> data2, Vector512<ushort> data3, out Vector512<ushort> y, out Vector512<ushort> z, out Vector512<ushort> w) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
                return YGroup4Unzip_Basic(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup4Unzip(Vector512<int> data0, Vector512<int> data1, Vector512<int> data2, Vector512<int> data3, out Vector512<int> y, out Vector512<int> z, out Vector512<int> w) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
                return YGroup4Unzip_Basic(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup4Unzip(Vector512<uint> data0, Vector512<uint> data1, Vector512<uint> data2, Vector512<uint> data3, out Vector512<uint> y, out Vector512<uint> z, out Vector512<uint> w) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
#else
                return YGroup4Unzip_Basic(data0, data1, data2, data3, out y, out z, out w);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip_Int128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<T> YGroup4Unzip_Int128<T>(Vector512<T> data0, Vector512<T> data1, Vector512<T> data2, Vector512<T> data3, out Vector512<T> y, out Vector512<T> z, out Vector512<T> w) where T : struct {
                var d0 = YGroup4Unzip_Move(data0.ExAs<T, ExUInt128>(), data1.ExAs<T, ExUInt128>(), data2.ExAs<T, ExUInt128>(), data3.ExAs<T, ExUInt128>(), out var d1, out var d2, out var d3);
                y = d1.ExAs<ExUInt128, T>();
                z = d2.ExAs<ExUInt128, T>();
                w = d3.ExAs<ExUInt128, T>();
                return d0.ExAs<ExUInt128, T>();
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
                return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
#else
                return YGroup4Zip_Basic(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
                return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
#else
                return YGroup4Zip_Basic(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup4Zip(Vector512<byte> x, Vector512<byte> y, Vector512<byte> z, Vector512<byte> w, out Vector512<byte> data1, out Vector512<byte> data2, out Vector512<byte> data3) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
#else
                return YGroup4Zip_Basic(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup4Zip(Vector512<short> x, Vector512<short> y, Vector512<short> z, Vector512<short> w, out Vector512<short> data1, out Vector512<short> data2, out Vector512<short> data3) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
#else
                return YGroup4Zip_Basic(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup4Zip(Vector512<ushort> x, Vector512<ushort> y, Vector512<ushort> z, Vector512<ushort> w, out Vector512<ushort> data1, out Vector512<ushort> data2, out Vector512<ushort> data3) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
#else
                return YGroup4Zip_Basic(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup4Zip(Vector512<int> x, Vector512<int> y, Vector512<int> z, Vector512<int> w, out Vector512<int> data1, out Vector512<int> data2, out Vector512<int> data3) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
#else
                return YGroup4Zip_Basic(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup4Zip(Vector512<uint> x, Vector512<uint> y, Vector512<uint> z, Vector512<uint> w, out Vector512<uint> data1, out Vector512<uint> data2, out Vector512<uint> data3) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
#else
                return YGroup4Zip_Basic(x, y, z, w, out data1, out data2, out data3);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip_Int128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<T> YGroup4Zip_Int128<T>(Vector512<T> x, Vector512<T> y, Vector512<T> z, Vector512<T> w, out Vector512<T> data1, out Vector512<T> data2, out Vector512<T> data3) where T : struct {
                var d0 = YGroup4Zip_Move(x.ExAs<T, ExUInt128>(), y.ExAs<T, ExUInt128>(), z.ExAs<T, ExUInt128>(), w.ExAs<T, ExUInt128>(), out var d1, out var d2, out var d3);
                data1 = d1.ExAs<ExUInt128, T>();
                data2 = d2.ExAs<ExUInt128, T>();
                data3 = d3.ExAs<ExUInt128, T>();
                return d0.ExAs<ExUInt128, T>();
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

#endif // NET8_0_OR_GREATER
        }
    }
}
