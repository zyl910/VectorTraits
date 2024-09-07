#define VECTOR_HAS_METHOD
#if NET7_0_OR_GREATER
#define BCL_HAS_SHIFT
#endif // NET7_0_OR_GREATER
#if NETX_0_OR_GREATER
#define BCL_HAS_SHUFFLE
#endif // NETX_0_OR_GREATER

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Numerics;
using Zyl.VectorTraits.ExTypes;
using Zyl.VectorTraits.Extensions.SameW;
using Zyl.VectorTraits.Impl.Util;
using Zyl.VectorTraits.Numerics;

namespace Zyl.VectorTraits.Impl.AVector {

    partial class VectorTraitsBase {

        partial class Statics {

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2Unzip_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                    if (Vector.IsHardwareAccelerated) {
                        rt = TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16;
#if BCL_HAS_SHIFT
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
#endif // BCL_HAS_SHIFT
                    }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{float}, Vector{float}, out Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup2Unzip(Vector<float> data0, Vector<float> data1, out Vector<float> y) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD && BCL_HAS_SHIFT
                if (Vector.IsHardwareAccelerated) {
                    return YGroup2Unzip_Narrow(data0, data1, out y);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup2Unzip_Basic(data0, data1, out y);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{double}, Vector{double}, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup2Unzip(Vector<double> data0, Vector<double> data1, out Vector<double> y) {
                return YGroup2Unzip_Basic(data0, data1, out y);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{sbyte}, Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup2Unzip(Vector<sbyte> data0, Vector<sbyte> data1, out Vector<sbyte> y) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
#if BCL_HAS_SHIFT
                    return YGroup2Unzip_Narrow(data0, data1, out y);
#else
                    return YGroup2Unzip_NarrowMul(data0, data1, out y);
#endif // BCL_HAS_SHIFT
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup2Unzip_Basic(data0, data1, out y);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{byte}, Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup2Unzip(Vector<byte> data0, Vector<byte> data1, out Vector<byte> y) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
#if BCL_HAS_SHIFT
                    return YGroup2Unzip_Narrow(data0, data1, out y);
#else
                    return YGroup2Unzip_NarrowMul(data0, data1, out y);
#endif // BCL_HAS_SHIFT
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup2Unzip_Basic(data0, data1, out y);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{short}, Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup2Unzip(Vector<short> data0, Vector<short> data1, out Vector<short> y) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
#if BCL_HAS_SHIFT
                    return YGroup2Unzip_Narrow(data0, data1, out y);
#else
                    return YGroup2Unzip_NarrowMul(data0, data1, out y);
#endif // BCL_HAS_SHIFT
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup2Unzip_Basic(data0, data1, out y);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{ushort}, Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup2Unzip(Vector<ushort> data0, Vector<ushort> data1, out Vector<ushort> y) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
#if BCL_HAS_SHIFT
                    return YGroup2Unzip_Narrow(data0, data1, out y);
#else
                    return YGroup2Unzip_NarrowMul(data0, data1, out y);
#endif // BCL_HAS_SHIFT
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup2Unzip_Basic(data0, data1, out y);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{int}, Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup2Unzip(Vector<int> data0, Vector<int> data1, out Vector<int> y) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD && BCL_HAS_SHIFT
                if (Vector.IsHardwareAccelerated) {
                    return YGroup2Unzip_Narrow(data0, data1, out y);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup2Unzip_Basic(data0, data1, out y);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{uint}, Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup2Unzip(Vector<uint> data0, Vector<uint> data1, out Vector<uint> y) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD && BCL_HAS_SHIFT
                if (Vector.IsHardwareAccelerated) {
                    return YGroup2Unzip_Narrow(data0, data1, out y);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup2Unzip_Basic(data0, data1, out y);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{long}, Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup2Unzip(Vector<long> data0, Vector<long> data1, out Vector<long> y) {
                return YGroup2Unzip_Basic(data0, data1, out y);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{ulong}, Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup2Unzip(Vector<ulong> data0, Vector<ulong> data1, out Vector<ulong> y) {
                return YGroup2Unzip_Basic(data0, data1, out y);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{ExInt128}, Vector{ExInt128}, out Vector{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExInt128> YGroup2Unzip(Vector<ExInt128> data0, Vector<ExInt128> data1, out Vector<ExInt128> y) {
                return YGroup2Unzip_Basic(data0, data1, out y);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{ExUInt128}, Vector{ExUInt128}, out Vector{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExUInt128> YGroup2Unzip(Vector<ExUInt128> data0, Vector<ExUInt128> data1, out Vector<ExUInt128> y) {
                return YGroup2Unzip_Basic(data0, data1, out y);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip_Bit128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<T> YGroup2Unzip_Bit128<T>(Vector<T> data0, Vector<T> data1, out Vector<T> y) where T : struct {
                var d0 = YGroup2Unzip_Basic(data0.ExAsExUInt128(), data1.ExAsExUInt128(), out var d1);
                y = d1.ExAs<ExUInt128, T>();
                return d0.ExAs<ExUInt128, T>();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{float}, Vector{float}, out Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup2Unzip_Basic(Vector<float> data0, Vector<float> data1, out Vector<float> y) {
                var d0 = YGroup2Unzip_Basic(data0.AsUInt32(), data1.AsUInt32(), out var d1);
                y = d1.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{double}, Vector{double}, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup2Unzip_Basic(Vector<double> data0, Vector<double> data1, out Vector<double> y) {
                var d0 = YGroup2Unzip_Basic(data0.AsUInt64(), data1.AsUInt64(), out var d1);
                y = d1.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{sbyte}, Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup2Unzip_Basic(Vector<sbyte> data0, Vector<sbyte> data1, out Vector<sbyte> y) {
                var d0 = YGroup2Unzip_Basic(data0.AsByte(), data1.AsByte(), out var d1);
                y = d1.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{byte}, Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup2Unzip_Basic(Vector<byte> data0, Vector<byte> data1, out Vector<byte> y) {
                UnsafeUtil.SkipInit(out Vector<byte> x1);
                UnsafeUtil.SkipInit(out Vector<byte> y1);
                Span<Vector<byte>> src = [data0, data1];
                ref byte px = ref Unsafe.As<Vector<byte>, byte>(ref x1);
                ref byte py = ref Unsafe.As<Vector<byte>, byte>(ref y1);
                Span<byte> p = MemoryMarshal.Cast<Vector<byte>, byte>(src);
                int idx = 0;
                for (int i = 0; i < Vector<byte>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    Unsafe.Add(ref py, i) = p[idx + 1];
                    idx += 2;
                }
                y = y1;
                return x1;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{short}, Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup2Unzip_Basic(Vector<short> data0, Vector<short> data1, out Vector<short> y) {
                var d0 = YGroup2Unzip_Basic(data0.AsUInt16(), data1.AsUInt16(), out var d1);
                y = d1.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{ushort}, Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup2Unzip_Basic(Vector<ushort> data0, Vector<ushort> data1, out Vector<ushort> y) {
                UnsafeUtil.SkipInit(out Vector<ushort> x1);
                UnsafeUtil.SkipInit(out Vector<ushort> y1);
                Span<Vector<ushort>> src = [data0, data1];
                ref ushort px = ref Unsafe.As<Vector<ushort>, ushort>(ref x1);
                ref ushort py = ref Unsafe.As<Vector<ushort>, ushort>(ref y1);
                Span<ushort> p = MemoryMarshal.Cast<Vector<ushort>, ushort>(src);
                int idx = 0;
                for (int i = 0; i < Vector<ushort>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    Unsafe.Add(ref py, i) = p[idx + 1];
                    idx += 2;
                }
                y = y1;
                return x1;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{int}, Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup2Unzip_Basic(Vector<int> data0, Vector<int> data1, out Vector<int> y) {
                var d0 = YGroup2Unzip_Basic(data0.AsUInt32(), data1.AsUInt32(), out var d1);
                y = d1.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{uint}, Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup2Unzip_Basic(Vector<uint> data0, Vector<uint> data1, out Vector<uint> y) {
                UnsafeUtil.SkipInit(out Vector<uint> x1);
                UnsafeUtil.SkipInit(out Vector<uint> y1);
                Span<Vector<uint>> src = [data0, data1];
                ref uint px = ref Unsafe.As<Vector<uint>, uint>(ref x1);
                ref uint py = ref Unsafe.As<Vector<uint>, uint>(ref y1);
                Span<uint> p = MemoryMarshal.Cast<Vector<uint>, uint>(src);
                int idx = 0;
                for (int i = 0; i < Vector<uint>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    Unsafe.Add(ref py, i) = p[idx + 1];
                    idx += 2;
                }
                y = y1;
                return x1;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{long}, Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup2Unzip_Basic(Vector<long> data0, Vector<long> data1, out Vector<long> y) {
                var d0 = YGroup2Unzip_Basic(data0.AsUInt64(), data1.AsUInt64(), out var d1);
                y = d1.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{ulong}, Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup2Unzip_Basic(Vector<ulong> data0, Vector<ulong> data1, out Vector<ulong> y) {
                UnsafeUtil.SkipInit(out Vector<ulong> x1);
                UnsafeUtil.SkipInit(out Vector<ulong> y1);
                Span<Vector<ulong>> src = [data0, data1];
                ref ulong px = ref Unsafe.As<Vector<ulong>, ulong>(ref x1);
                ref ulong py = ref Unsafe.As<Vector<ulong>, ulong>(ref y1);
                Span<ulong> p = MemoryMarshal.Cast<Vector<ulong>, ulong>(src);
                int idx = 0;
                for (int i = 0; i < Vector<ulong>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    Unsafe.Add(ref py, i) = p[idx + 1];
                    idx += 2;
                }
                y = y1;
                return x1;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{ExInt128}, Vector{ExInt128}, out Vector{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExInt128> YGroup2Unzip_Basic(Vector<ExInt128> data0, Vector<ExInt128> data1, out Vector<ExInt128> y) {
                var d0 = YGroup2Unzip_Basic(data0.ExAsExUInt128(), data1.ExAsExUInt128(), out var d1);
                y = d1.ExAsExInt128();
                return d0.ExAsExInt128();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{ExUInt128}, Vector{ExUInt128}, out Vector{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExUInt128> YGroup2Unzip_Basic(Vector<ExUInt128> data0, Vector<ExUInt128> data1, out Vector<ExUInt128> y) {
                UnsafeUtil.SkipInit(out Vector<ExUInt128> x1);
                UnsafeUtil.SkipInit(out Vector<ExUInt128> y1);
                Span<Vector<ExUInt128>> src = [data0, data1];
                ref ExUInt128 px = ref Unsafe.As<Vector<ExUInt128>, ExUInt128>(ref x1);
                ref ExUInt128 py = ref Unsafe.As<Vector<ExUInt128>, ExUInt128>(ref y1);
                Span<ExUInt128> p = MemoryMarshal.Cast<Vector<ExUInt128>, ExUInt128>(src);
                int idx = 0;
                for (int i = 0; i < Vectors<ExUInt128>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    Unsafe.Add(ref py, i) = p[idx + 1];
                    idx += 2;
                }
                y = y1;
                return x1;
            }

#if VECTOR_HAS_METHOD

#if BCL_HAS_SHIFT
            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{float}, Vector{float}, out Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup2Unzip_Narrow(Vector<float> data0, Vector<float> data1, out Vector<float> y) {
                var d0 = YGroup2Unzip_Narrow(data0.AsUInt32(), data1.AsUInt32(), out var d1);
                y = d1.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{sbyte}, Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup2Unzip_Narrow(Vector<sbyte> data0, Vector<sbyte> data1, out Vector<sbyte> y) {
                var d0 = YGroup2Unzip_Narrow(data0.AsByte(), data1.AsByte(), out var d1);
                y = d1.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{byte}, Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup2Unzip_Narrow(Vector<byte> data0, Vector<byte> data1, out Vector<byte> y) {
                const int L = 8;
#if BCL_HAS_SHIFT
#else
                const float scale = 1.0f / (1 << L);
                Vector<float> vscale = new Vector<float>(scale);
                Vector<float> f0, f1, f2, f3;
                Vector<uint> e0, e1, e2, e3;
#endif // BCL_HAS_SHIFT
                Vector<byte> rt0, rt1;
                Vector<ushort> temp0 = data0.AsUInt16();
                Vector<ushort> temp1 = data1.AsUInt16();
                rt0 = Vector.Narrow(temp0, temp1);
#if BCL_HAS_SHIFT
                temp0 = Vector.ShiftRightLogical(temp0, L);
                temp1 = Vector.ShiftRightLogical(temp1, L);
#else
                Vector.Widen(temp0, out e0, out e1);
                Vector.Widen(temp1, out e2, out e3);
                f0 = Vector.ConvertToSingle(e0.AsInt32());
                f1 = Vector.ConvertToSingle(e1.AsInt32());
                f2 = Vector.ConvertToSingle(e2.AsInt32());
                f3 = Vector.ConvertToSingle(e3.AsInt32());
                f0 = Floor_Positive(Vector.Multiply(f0, vscale));
                f1 = Floor_Positive(Vector.Multiply(f1, vscale));
                f2 = Floor_Positive(Vector.Multiply(f2, vscale));
                f3 = Floor_Positive(Vector.Multiply(f3, vscale));
                e0 = Vector.ConvertToInt32(f0).AsUInt32();
                e1 = Vector.ConvertToInt32(f1).AsUInt32();
                e2 = Vector.ConvertToInt32(f2).AsUInt32();
                e3 = Vector.ConvertToInt32(f3).AsUInt32();
                temp0 = Vector.Narrow(e0, e1);
                temp1 = Vector.Narrow(e2, e3);
#endif // BCL_HAS_SHIFT
                rt1 = Vector.Narrow(temp0, temp1);
                if (BitConverter.IsLittleEndian) {
                    y = rt1;
                    return rt0;
                } else {
                    y = rt0;
                    return rt1;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{short}, Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup2Unzip_Narrow(Vector<short> data0, Vector<short> data1, out Vector<short> y) {
                var d0 = YGroup2Unzip_Narrow(data0.AsUInt16(), data1.AsUInt16(), out var d1);
                y = d1.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{ushort}, Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup2Unzip_Narrow(Vector<ushort> data0, Vector<ushort> data1, out Vector<ushort> y) {
                const int L = 16;
                Vector<ushort> rt0, rt1;
                Vector<uint> temp0 = data0.AsUInt32();
                Vector<uint> temp1 = data1.AsUInt32();
                rt0 = Vector.Narrow(temp0, temp1);
                temp0 = Vector.ShiftRightLogical(temp0, L);
                temp1 = Vector.ShiftRightLogical(temp1, L);
                rt1 = Vector.Narrow(temp0, temp1);
                if (BitConverter.IsLittleEndian) {
                    y = rt1;
                    return rt0;
                } else {
                    y = rt0;
                    return rt1;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{int}, Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup2Unzip_Narrow(Vector<int> data0, Vector<int> data1, out Vector<int> y) {
                var d0 = YGroup2Unzip_Narrow(data0.AsUInt32(), data1.AsUInt32(), out var d1);
                y = d1.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{uint}, Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup2Unzip_Narrow(Vector<uint> data0, Vector<uint> data1, out Vector<uint> y) {
                const int L = 32;
                Vector<uint> rt0, rt1;
                Vector<ulong> temp0 = data0.AsUInt64();
                Vector<ulong> temp1 = data1.AsUInt64();
                rt0 = Vector.Narrow(temp0, temp1);
                temp0 = Vector.ShiftRightLogical(temp0, L);
                temp1 = Vector.ShiftRightLogical(temp1, L);
                rt1 = Vector.Narrow(temp0, temp1);
                if (BitConverter.IsLittleEndian) {
                    y = rt1;
                    return rt0;
                } else {
                    y = rt0;
                    return rt1;
                }
            }
#endif // BCL_HAS_SHIFT

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{sbyte}, Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup2Unzip_NarrowMul(Vector<sbyte> data0, Vector<sbyte> data1, out Vector<sbyte> y) {
                var d0 = YGroup2Unzip_NarrowMul(data0.AsByte(), data1.AsByte(), out var d1);
                y = d1.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{byte}, Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup2Unzip_NarrowMul(Vector<byte> data0, Vector<byte> data1, out Vector<byte> y) {
                const int L = 8;
                const float scale = 1.0f / (1 << L);
                Vector<float> vscale = new Vector<float>(scale);
                Vector<float> f0, f1, f2, f3;
                Vector<uint> e0, e1, e2, e3;
                Vector<byte> rt0, rt1;
                Vector<ushort> temp0 = data0.AsUInt16();
                Vector<ushort> temp1 = data1.AsUInt16();
                rt0 = Vector.Narrow(temp0, temp1);
                //temp0 = Vector.ShiftRightLogical(temp0, L);
                //temp1 = Vector.ShiftRightLogical(temp1, L);
                Vector.Widen(temp0, out e0, out e1);
                Vector.Widen(temp1, out e2, out e3);
                f0 = Vector.ConvertToSingle(e0.AsInt32());
                f1 = Vector.ConvertToSingle(e1.AsInt32());
                f2 = Vector.ConvertToSingle(e2.AsInt32());
                f3 = Vector.ConvertToSingle(e3.AsInt32());
                f0 = Vector.Multiply(f0, vscale);
                f1 = Vector.Multiply(f1, vscale);
                f2 = Vector.Multiply(f2, vscale);
                f3 = Vector.Multiply(f3, vscale);
                e0 = Vector.ConvertToInt32(f0).AsUInt32();
                e1 = Vector.ConvertToInt32(f1).AsUInt32();
                e2 = Vector.ConvertToInt32(f2).AsUInt32();
                e3 = Vector.ConvertToInt32(f3).AsUInt32();
                temp0 = Vector.Narrow(e0, e1);
                temp1 = Vector.Narrow(e2, e3);
                rt1 = Vector.Narrow(temp0, temp1);
                if (BitConverter.IsLittleEndian) {
                    y = rt1;
                    return rt0;
                } else {
                    y = rt0;
                    return rt1;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{short}, Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup2Unzip_NarrowMul(Vector<short> data0, Vector<short> data1, out Vector<short> y) {
                var d0 = YGroup2Unzip_NarrowMul(data0.AsUInt16(), data1.AsUInt16(), out var d1);
                y = d1.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{ushort}, Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup2Unzip_NarrowMul(Vector<ushort> data0, Vector<ushort> data1, out Vector<ushort> y) {
                const int L = 16;
                const double scale = 1.0d / (1 << L);
                Vector<double> vscale = new Vector<double>(scale);
                Vector<double> f0, f1, f2, f3;
                Vector<ulong> e0, e1, e2, e3;
                Vector<ushort> rt0, rt1;
                Vector<uint> temp0 = data0.AsUInt32();
                Vector<uint> temp1 = data1.AsUInt32();
                Vector<uint> mask = Vectors<ushort>.XyYMask.AsUInt32();
                rt0 = Vector.Narrow(temp0, temp1);
                //temp0 = Vector.ShiftRightLogical(temp0, L);
                //temp1 = Vector.ShiftRightLogical(temp1, L);
                temp0 = Vector.BitwiseAnd(temp0, mask);
                temp1 = Vector.BitwiseAnd(temp1, mask);
                Vector.Widen(temp0, out e0, out e1);
                Vector.Widen(temp1, out e2, out e3);
                f0 = ConvertToDouble_Range52(e0);
                f1 = ConvertToDouble_Range52(e1);
                f2 = ConvertToDouble_Range52(e2);
                f3 = ConvertToDouble_Range52(e3);
                f0 = Vector.Multiply(f0, vscale);
                f1 = Vector.Multiply(f1, vscale);
                f2 = Vector.Multiply(f2, vscale);
                f3 = Vector.Multiply(f3, vscale);
                e0 = ConvertToUInt64_Range52RoundToEven(f0);
                e1 = ConvertToUInt64_Range52RoundToEven(f1);
                e2 = ConvertToUInt64_Range52RoundToEven(f2);
                e3 = ConvertToUInt64_Range52RoundToEven(f3);
                temp0 = Vector.Narrow(e0, e1);
                temp1 = Vector.Narrow(e2, e3);
                rt1 = Vector.Narrow(temp0, temp1);
                if (BitConverter.IsLittleEndian) {
                    y = rt1;
                    return rt0;
                } else {
                    y = rt0;
                    return rt1;
                }
            }

#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2UnzipEven_AcceleratedTypes {
                get {
                    return YGroup2Unzip_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{float}, Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup2UnzipEven(Vector<float> data0, Vector<float> data1) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup2UnzipEven_Narrow(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup2UnzipEven_Basic(data0, data1);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{double}, Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup2UnzipEven(Vector<double> data0, Vector<double> data1) {
                return YGroup2UnzipEven_Basic(data0, data1);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup2UnzipEven(Vector<sbyte> data0, Vector<sbyte> data1) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup2UnzipEven_Narrow(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup2UnzipEven_Basic(data0, data1);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup2UnzipEven(Vector<byte> data0, Vector<byte> data1) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup2UnzipEven_Narrow(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup2UnzipEven_Basic(data0, data1);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup2UnzipEven(Vector<short> data0, Vector<short> data1) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup2UnzipEven_Narrow(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup2UnzipEven_Basic(data0, data1);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup2UnzipEven(Vector<ushort> data0, Vector<ushort> data1) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup2UnzipEven_Narrow(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup2UnzipEven_Basic(data0, data1);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup2UnzipEven(Vector<int> data0, Vector<int> data1) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup2UnzipEven_Narrow(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup2UnzipEven_Basic(data0, data1);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup2UnzipEven(Vector<uint> data0, Vector<uint> data1) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup2UnzipEven_Narrow(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup2UnzipEven_Basic(data0, data1);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup2UnzipEven(Vector<long> data0, Vector<long> data1) {
                return YGroup2UnzipEven_Basic(data0, data1);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup2UnzipEven(Vector<ulong> data0, Vector<ulong> data1) {
                return YGroup2UnzipEven_Basic(data0, data1);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{ExInt128}, Vector{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExInt128> YGroup2UnzipEven(Vector<ExInt128> data0, Vector<ExInt128> data1) {
                return YGroup2Unzip(data0, data1, out _);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{ExUInt128}, Vector{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExUInt128> YGroup2UnzipEven(Vector<ExUInt128> data0, Vector<ExUInt128> data1) {
                return YGroup2Unzip(data0, data1, out _);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{float}, Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup2UnzipEven_Basic(Vector<float> data0, Vector<float> data1) {
                return YGroup2UnzipEven_Basic(data0.AsUInt32(), data1.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{double}, Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup2UnzipEven_Basic(Vector<double> data0, Vector<double> data1) {
                return YGroup2UnzipEven_Basic(data0.AsUInt64(), data1.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup2UnzipEven_Basic(Vector<sbyte> data0, Vector<sbyte> data1) {
                return YGroup2UnzipEven_Basic(data0.AsByte(), data1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup2UnzipEven_Basic(Vector<byte> data0, Vector<byte> data1) {
                UnsafeUtil.SkipInit(out Vector<byte> x1);
                Span<Vector<byte>> src = [data0, data1];
                ref byte px = ref Unsafe.As<Vector<byte>, byte>(ref x1);
                Span<byte> p = MemoryMarshal.Cast<Vector<byte>, byte>(src);
                int idx = 0;
                for (int i = 0; i < Vector<byte>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    idx += 2;
                }
                return x1;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup2UnzipEven_Basic(Vector<short> data0, Vector<short> data1) {
                return YGroup2UnzipEven_Basic(data0.AsUInt16(), data1.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup2UnzipEven_Basic(Vector<ushort> data0, Vector<ushort> data1) {
                UnsafeUtil.SkipInit(out Vector<ushort> x1);
                Span<Vector<ushort>> src = [data0, data1];
                ref ushort px = ref Unsafe.As<Vector<ushort>, ushort>(ref x1);
                Span<ushort> p = MemoryMarshal.Cast<Vector<ushort>, ushort>(src);
                int idx = 0;
                for (int i = 0; i < Vector<ushort>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    idx += 2;
                }
                return x1;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup2UnzipEven_Basic(Vector<int> data0, Vector<int> data1) {
                return YGroup2UnzipEven_Basic(data0.AsUInt32(), data1.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup2UnzipEven_Basic(Vector<uint> data0, Vector<uint> data1) {
                UnsafeUtil.SkipInit(out Vector<uint> x1);
                Span<Vector<uint>> src = [data0, data1];
                ref uint px = ref Unsafe.As<Vector<uint>, uint>(ref x1);
                Span<uint> p = MemoryMarshal.Cast<Vector<uint>, uint>(src);
                int idx = 0;
                for (int i = 0; i < Vector<uint>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    idx += 2;
                }
                return x1;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup2UnzipEven_Basic(Vector<long> data0, Vector<long> data1) {
                return YGroup2UnzipEven_Basic(data0.AsUInt64(), data1.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup2UnzipEven_Basic(Vector<ulong> data0, Vector<ulong> data1) {
#if NETSTANDARD1_3_OR_GREATER || NETCOREAPP1_0_OR_GREATER || NET40_OR_GREATER
                //Console.WriteLine(VectorTextUtil.Format("VectorTraitsBase.YGroup2UnzipEven_Basic-0({0}, {1})", data0, data1));
#endif
                UnsafeUtil.SkipInit(out Vector<ulong> x1);
                Span<Vector<ulong>> src = [data0, data1];
                ref ulong px = ref Unsafe.As<Vector<ulong>, ulong>(ref x1);
                Span<ulong> p = MemoryMarshal.Cast<Vector<ulong>, ulong>(src);
                int idx = 0;
                for (int i = 0; i < Vector<ulong>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    idx += 2;
                }
#if NETSTANDARD1_3_OR_GREATER || NETCOREAPP1_0_OR_GREATER || NET40_OR_GREATER
                //Console.WriteLine(VectorTextUtil.Format("VectorTraitsBase.YGroup2UnzipEven_Basic({0}, {1}): {2}", data0, data1, x1));
#endif
                return x1;
            }

#if VECTOR_HAS_METHOD

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{float}, Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup2UnzipEven_Narrow(Vector<float> data0, Vector<float> data1) {
                return YGroup2UnzipEven_Narrow(data0.AsUInt32(), data1.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup2UnzipEven_Narrow(Vector<sbyte> data0, Vector<sbyte> data1) {
                return YGroup2UnzipEven_Narrow(data0.AsByte(), data1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup2UnzipEven_Narrow(Vector<byte> data0, Vector<byte> data1) {
#if BCL_HAS_SHIFT
                const int L = 8;
                Vector<byte> rt0, rt1;
                Vector<ushort> temp0 = data0.AsUInt16();
                Vector<ushort> temp1 = data1.AsUInt16();
                if (BitConverter.IsLittleEndian) {
                    rt0 = Vector.Narrow(temp0, temp1);
                    return rt0;
                } else {
                    temp0 = Vector.ShiftRightLogical(temp0, L);
                    temp1 = Vector.ShiftRightLogical(temp1, L);
                    rt1 = Vector.Narrow(temp0, temp1);
                    return rt1;
                }
#else
                return YGroup2Unzip_NarrowMul(data0, data1, out _);
#endif // BCL_HAS_SHIFT
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup2UnzipEven_Narrow(Vector<short> data0, Vector<short> data1) {
                return YGroup2UnzipEven_Narrow(data0.AsUInt16(), data1.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup2UnzipEven_Narrow(Vector<ushort> data0, Vector<ushort> data1) {
#if BCL_HAS_SHIFT
                const int L = 16;
                Vector<ushort> rt0, rt1;
                Vector<uint> temp0 = data0.AsUInt32();
                Vector<uint> temp1 = data1.AsUInt32();
                if (BitConverter.IsLittleEndian) {
                    rt0 = Vector.Narrow(temp0, temp1);
                    return rt0;
                } else {
                    temp0 = Vector.ShiftRightLogical(temp0, L);
                    temp1 = Vector.ShiftRightLogical(temp1, L);
                    rt1 = Vector.Narrow(temp0, temp1);
                    return rt1;
                }
#else
                return YGroup2Unzip_NarrowMul(data0, data1, out _);
#endif // BCL_HAS_SHIFT
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup2UnzipEven_Narrow(Vector<int> data0, Vector<int> data1) {
                return YGroup2UnzipEven_Narrow(data0.AsUInt32(), data1.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup2UnzipEven_Narrow(Vector<uint> data0, Vector<uint> data1) {
#if BCL_HAS_SHIFT
                const int L = 32;
                Vector<uint> rt0, rt1;
                Vector<ulong> temp0 = data0.AsUInt64();
                Vector<ulong> temp1 = data1.AsUInt64();
                if (BitConverter.IsLittleEndian) {
                    rt0 = Vector.Narrow(temp0, temp1);
                    return rt0;
                } else {
                    temp0 = Vector.ShiftRightLogical(temp0, L);
                    temp1 = Vector.ShiftRightLogical(temp1, L);
                    rt1 = Vector.Narrow(temp0, temp1);
                    return rt1;
                }
#else
                return YGroup2UnzipEven_Basic(data0, data1);
#endif // BCL_HAS_SHIFT
            }

#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2UnzipOdd_AcceleratedTypes {
                get {
                    return YGroup2Unzip_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{float}, Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup2UnzipOdd(Vector<float> data0, Vector<float> data1) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup2UnzipOdd_Narrow(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup2UnzipOdd_Basic(data0, data1);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{double}, Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup2UnzipOdd(Vector<double> data0, Vector<double> data1) {
                return YGroup2UnzipOdd_Basic(data0, data1);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup2UnzipOdd(Vector<sbyte> data0, Vector<sbyte> data1) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup2UnzipOdd_Narrow(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup2UnzipOdd_Basic(data0, data1);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup2UnzipOdd(Vector<byte> data0, Vector<byte> data1) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup2UnzipOdd_Narrow(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup2UnzipOdd_Basic(data0, data1);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup2UnzipOdd(Vector<short> data0, Vector<short> data1) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup2UnzipOdd_Narrow(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup2UnzipOdd_Basic(data0, data1);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup2UnzipOdd(Vector<ushort> data0, Vector<ushort> data1) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup2UnzipOdd_Narrow(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup2UnzipOdd_Basic(data0, data1);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup2UnzipOdd(Vector<int> data0, Vector<int> data1) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup2UnzipOdd_Narrow(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup2UnzipOdd_Basic(data0, data1);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup2UnzipOdd(Vector<uint> data0, Vector<uint> data1) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup2UnzipOdd_Narrow(data0, data1);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup2UnzipOdd_Basic(data0, data1);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup2UnzipOdd(Vector<long> data0, Vector<long> data1) {
                return YGroup2UnzipOdd_Basic(data0, data1);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup2UnzipOdd(Vector<ulong> data0, Vector<ulong> data1) {
                return YGroup2UnzipOdd_Basic(data0, data1);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{ExInt128}, Vector{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExInt128> YGroup2UnzipOdd(Vector<ExInt128> data0, Vector<ExInt128> data1) {
                _ = YGroup2Unzip(data0, data1, out var rt1);
                return rt1;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{ExUInt128}, Vector{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExUInt128> YGroup2UnzipOdd(Vector<ExUInt128> data0, Vector<ExUInt128> data1) {
                _ = YGroup2Unzip(data0, data1, out var rt1);
                return rt1;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{float}, Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup2UnzipOdd_Basic(Vector<float> data0, Vector<float> data1) {
                return YGroup2UnzipOdd_Basic(data0.AsUInt32(), data1.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{double}, Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup2UnzipOdd_Basic(Vector<double> data0, Vector<double> data1) {
                return YGroup2UnzipOdd_Basic(data0.AsUInt64(), data1.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup2UnzipOdd_Basic(Vector<sbyte> data0, Vector<sbyte> data1) {
                return YGroup2UnzipOdd_Basic(data0.AsByte(), data1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup2UnzipOdd_Basic(Vector<byte> data0, Vector<byte> data1) {
                UnsafeUtil.SkipInit(out Vector<byte> y1);
                Span<Vector<byte>> src = [data0, data1];
                ref byte py = ref Unsafe.As<Vector<byte>, byte>(ref y1);
                Span<byte> p = MemoryMarshal.Cast<Vector<byte>, byte>(src);
                int idx = 1;
                for (int i = 0; i < Vector<byte>.Count; ++i) {
                    Unsafe.Add(ref py, i) = p[idx];
                    idx += 2;
                }
                return y1;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup2UnzipOdd_Basic(Vector<short> data0, Vector<short> data1) {
                return YGroup2UnzipOdd_Basic(data0.AsUInt16(), data1.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup2UnzipOdd_Basic(Vector<ushort> data0, Vector<ushort> data1) {
                UnsafeUtil.SkipInit(out Vector<ushort> y1);
                Span<Vector<ushort>> src = [data0, data1];
                ref ushort py = ref Unsafe.As<Vector<ushort>, ushort>(ref y1);
                Span<ushort> p = MemoryMarshal.Cast<Vector<ushort>, ushort>(src);
                int idx = 1;
                for (int i = 0; i < Vector<ushort>.Count; ++i) {
                    Unsafe.Add(ref py, i) = p[idx];
                    idx += 2;
                }
                return y1;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup2UnzipOdd_Basic(Vector<int> data0, Vector<int> data1) {
                return YGroup2UnzipOdd_Basic(data0.AsUInt32(), data1.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup2UnzipOdd_Basic(Vector<uint> data0, Vector<uint> data1) {
                UnsafeUtil.SkipInit(out Vector<uint> y1);
                Span<Vector<uint>> src = [data0, data1];
                ref uint py = ref Unsafe.As<Vector<uint>, uint>(ref y1);
                Span<uint> p = MemoryMarshal.Cast<Vector<uint>, uint>(src);
                int idx = 1;
                for (int i = 0; i < Vector<uint>.Count; ++i) {
                    Unsafe.Add(ref py, i) = p[idx];
                    idx += 2;
                }
                return y1;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup2UnzipOdd_Basic(Vector<long> data0, Vector<long> data1) {
                return YGroup2UnzipOdd_Basic(data0.AsUInt64(), data1.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup2UnzipOdd_Basic(Vector<ulong> data0, Vector<ulong> data1) {
                UnsafeUtil.SkipInit(out Vector<ulong> y1);
                Span<Vector<ulong>> src = [data0, data1];
                ref ulong py = ref Unsafe.As<Vector<ulong>, ulong>(ref y1);
                Span<ulong> p = MemoryMarshal.Cast<Vector<ulong>, ulong>(src);
                int idx = 1;
                for (int i = 0; i < Vector<ulong>.Count; ++i) {
                    Unsafe.Add(ref py, i) = p[idx];
                    idx += 2;
                }
                return y1;
            }

#if VECTOR_HAS_METHOD

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{float}, Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup2UnzipOdd_Narrow(Vector<float> data0, Vector<float> data1) {
                return YGroup2UnzipOdd_Narrow(data0.AsUInt32(), data1.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup2UnzipOdd_Narrow(Vector<sbyte> data0, Vector<sbyte> data1) {
                return YGroup2UnzipOdd_Narrow(data0.AsByte(), data1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup2UnzipOdd_Narrow(Vector<byte> data0, Vector<byte> data1) {
#if BCL_HAS_SHIFT
                const int L = 8;
                Vector<byte> rt0, rt1;
                Vector<ushort> temp0 = data0.AsUInt16();
                Vector<ushort> temp1 = data1.AsUInt16();
                if (BitConverter.IsLittleEndian) {
                    temp0 = Vector.ShiftRightLogical(temp0, L);
                    temp1 = Vector.ShiftRightLogical(temp1, L);
                    rt1 = Vector.Narrow(temp0, temp1);
                    return rt1;
                } else {
                    rt0 = Vector.Narrow(temp0, temp1);
                    return rt0;
                }
#else
                _ = YGroup2Unzip_NarrowMul(data0, data1, out var rt1);
                return rt1;
#endif // BCL_HAS_SHIFT
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup2UnzipOdd_Narrow(Vector<short> data0, Vector<short> data1) {
                return YGroup2UnzipOdd_Narrow(data0.AsUInt16(), data1.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup2UnzipOdd_Narrow(Vector<ushort> data0, Vector<ushort> data1) {
#if BCL_HAS_SHIFT
                const int L = 16;
                Vector<ushort> rt0, rt1;
                Vector<uint> temp0 = data0.AsUInt32();
                Vector<uint> temp1 = data1.AsUInt32();
                if (BitConverter.IsLittleEndian) {
                    temp0 = Vector.ShiftRightLogical(temp0, L);
                    temp1 = Vector.ShiftRightLogical(temp1, L);
                    rt1 = Vector.Narrow(temp0, temp1);
                    return rt1;
                } else {
                    rt0 = Vector.Narrow(temp0, temp1);
                    return rt0;
                }
#else
                _ = YGroup2Unzip_NarrowMul(data0, data1, out var rt1);
                return rt1;
#endif // BCL_HAS_SHIFT
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup2UnzipOdd_Narrow(Vector<int> data0, Vector<int> data1) {
                return YGroup2UnzipOdd_Narrow(data0.AsUInt32(), data1.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup2UnzipOdd_Narrow(Vector<uint> data0, Vector<uint> data1) {
#if BCL_HAS_SHIFT
                const int L = 32;
                Vector<uint> rt0, rt1;
                Vector<ulong> temp0 = data0.AsUInt64();
                Vector<ulong> temp1 = data1.AsUInt64();
                if (BitConverter.IsLittleEndian) {
                    temp0 = Vector.ShiftRightLogical(temp0, L);
                    temp1 = Vector.ShiftRightLogical(temp1, L);
                    rt1 = Vector.Narrow(temp0, temp1);
                    return rt1;
                } else {
                    rt0 = Vector.Narrow(temp0, temp1);
                    return rt0;
                }
#else
                return YGroup2UnzipOdd_Basic(data0, data1);
#endif // BCL_HAS_SHIFT
            }

#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IVectorTraits.YGroup2Zip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2Zip_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                    if (Vector.IsHardwareAccelerated) {
                        rt = TypeCodeFlagsUtil.Most32Types;
                    }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{float}, Vector{float}, out Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup2Zip(Vector<float> x, Vector<float> y, out Vector<float> data1) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD && BCL_HAS_SHIFT
                if (Vector.IsHardwareAccelerated) {
                    return YGroup2Zip_Widen(x, y, out data1);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup2Zip_Basic(x, y, out data1);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{double}, Vector{double}, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup2Zip(Vector<double> x, Vector<double> y, out Vector<double> data1) {
                return YGroup2Zip_Basic(x, y, out data1);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{sbyte}, Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup2Zip(Vector<sbyte> x, Vector<sbyte> y, out Vector<sbyte> data1) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
#if BCL_HAS_SHIFT
                    return YGroup2Zip_Widen(x, y, out data1);
#else
                    return YGroup2Zip_WidenMul(x, y, out data1);
#endif // BCL_HAS_SHIFT
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup2Zip_Basic(x, y, out data1);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{byte}, Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup2Zip(Vector<byte> x, Vector<byte> y, out Vector<byte> data1) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
#if BCL_HAS_SHIFT
                    return YGroup2Zip_Widen(x, y, out data1);
#else
                    return YGroup2Zip_WidenMul(x, y, out data1);
#endif // BCL_HAS_SHIFT
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup2Zip_Basic(x, y, out data1);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{short}, Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup2Zip(Vector<short> x, Vector<short> y, out Vector<short> data1) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
#if BCL_HAS_SHIFT
                    return YGroup2Zip_Widen(x, y, out data1);
#else
                    return YGroup2Zip_WidenMul(x, y, out data1);
#endif // BCL_HAS_SHIFT
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup2Zip_Basic(x, y, out data1);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{ushort}, Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup2Zip(Vector<ushort> x, Vector<ushort> y, out Vector<ushort> data1) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
#if BCL_HAS_SHIFT
                    return YGroup2Zip_Widen(x, y, out data1);
#else
                    return YGroup2Zip_WidenMul(x, y, out data1);
#endif // BCL_HAS_SHIFT
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup2Zip_Basic(x, y, out data1);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{int}, Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup2Zip(Vector<int> x, Vector<int> y, out Vector<int> data1) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD && BCL_HAS_SHIFT
                if (Vector.IsHardwareAccelerated) {
                    return YGroup2Zip_Widen(x, y, out data1);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup2Zip_Basic(x, y, out data1);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{uint}, Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup2Zip(Vector<uint> x, Vector<uint> y, out Vector<uint> data1) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD && BCL_HAS_SHIFT
                if (Vector.IsHardwareAccelerated) {
                    return YGroup2Zip_Widen(x, y, out data1);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup2Zip_Basic(x, y, out data1);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{long}, Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup2Zip(Vector<long> x, Vector<long> y, out Vector<long> data1) {
                return YGroup2Zip_Basic(x, y, out data1);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{ulong}, Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup2Zip(Vector<ulong> x, Vector<ulong> y, out Vector<ulong> data1) {
                return YGroup2Zip_Basic(x, y, out data1);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{ExInt128}, Vector{ExInt128}, out Vector{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExInt128> YGroup2Zip(Vector<ExInt128> x, Vector<ExInt128> y, out Vector<ExInt128> data1) {
                return YGroup2Zip_Basic(x, y, out data1);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{ExUInt128}, Vector{ExUInt128}, out Vector{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExUInt128> YGroup2Zip(Vector<ExUInt128> x, Vector<ExUInt128> y, out Vector<ExUInt128> data1) {
                return YGroup2Zip_Basic(x, y, out data1);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Zip_Bit128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<T> YGroup2Zip_Bit128<T>(Vector<T> x, Vector<T> y, out Vector<T> data1) where T : struct {
                var d0 = YGroup2Zip_Basic(x.ExAsExUInt128(), y.ExAsExUInt128(), out var d1);
                data1 = d1.ExAs<ExUInt128, T>();
                return d0.ExAs<ExUInt128, T>();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{float}, Vector{float}, out Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup2Zip_Basic(Vector<float> x, Vector<float> y, out Vector<float> data1) {
                var d0 = YGroup2Zip_Basic(x.AsUInt32(), y.AsUInt32(), out var d1);
                data1 = d1.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{double}, Vector{double}, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup2Zip_Basic(Vector<double> x, Vector<double> y, out Vector<double> data1) {
                var d0 = YGroup2Zip_Basic(x.AsUInt64(), y.AsUInt64(), out var d1);
                data1 = d1.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{sbyte}, Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup2Zip_Basic(Vector<sbyte> x, Vector<sbyte> y, out Vector<sbyte> data1) {
                var d0 = YGroup2Zip_Basic(x.AsByte(), y.AsByte(), out var d1);
                data1 = d1.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{byte}, Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup2Zip_Basic(Vector<byte> x, Vector<byte> y, out Vector<byte> data1) {
                Span<Vector<byte>> rt = stackalloc Vector<byte>[2];
                ref byte px = ref Unsafe.As<Vector<byte>, byte>(ref x);
                ref byte py = ref Unsafe.As<Vector<byte>, byte>(ref y);
                Span<byte> q = MemoryMarshal.Cast<Vector<byte>, byte>(rt);
                int idx = 0;
                for (int i = 0; i < Vector<byte>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    idx += 2;
                }
                data1 = rt[1];
                return rt[0];
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{short}, Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup2Zip_Basic(Vector<short> x, Vector<short> y, out Vector<short> data1) {
                var d0 = YGroup2Zip_Basic(x.AsUInt16(), y.AsUInt16(), out var d1);
                data1 = d1.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{ushort}, Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup2Zip_Basic(Vector<ushort> x, Vector<ushort> y, out Vector<ushort> data1) {
                Span<Vector<ushort>> rt = stackalloc Vector<ushort>[2];
                ref ushort px = ref Unsafe.As<Vector<ushort>, ushort>(ref x);
                ref ushort py = ref Unsafe.As<Vector<ushort>, ushort>(ref y);
                Span<ushort> q = MemoryMarshal.Cast<Vector<ushort>, ushort>(rt);
                int idx = 0;
                for (int i = 0; i < Vector<ushort>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    idx += 2;
                }
                data1 = rt[1];
                return rt[0];
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{int}, Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup2Zip_Basic(Vector<int> x, Vector<int> y, out Vector<int> data1) {
                var d0 = YGroup2Zip_Basic(x.AsUInt32(), y.AsUInt32(), out var d1);
                data1 = d1.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{uint}, Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup2Zip_Basic(Vector<uint> x, Vector<uint> y, out Vector<uint> data1) {
                Span<Vector<uint>> rt = stackalloc Vector<uint>[2];
                ref uint px = ref Unsafe.As<Vector<uint>, uint>(ref x);
                ref uint py = ref Unsafe.As<Vector<uint>, uint>(ref y);
                Span<uint> q = MemoryMarshal.Cast<Vector<uint>, uint>(rt);
                int idx = 0;
                for (int i = 0; i < Vector<uint>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    idx += 2;
                }
                data1 = rt[1];
                return rt[0];
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{long}, Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup2Zip_Basic(Vector<long> x, Vector<long> y, out Vector<long> data1) {
                var d0 = YGroup2Zip_Basic(x.AsUInt64(), y.AsUInt64(), out var d1);
                data1 = d1.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{ulong}, Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup2Zip_Basic(Vector<ulong> x, Vector<ulong> y, out Vector<ulong> data1) {
                Span<Vector<ulong>> rt = stackalloc Vector<ulong>[2];
                ref ulong px = ref Unsafe.As<Vector<ulong>, ulong>(ref x);
                ref ulong py = ref Unsafe.As<Vector<ulong>, ulong>(ref y);
                Span<ulong> q = MemoryMarshal.Cast<Vector<ulong>, ulong>(rt);
                int idx = 0;
                for (int i = 0; i < Vector<ulong>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    idx += 2;
                }
                data1 = rt[1];
                return rt[0];
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{ExInt128}, Vector{ExInt128}, out Vector{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExInt128> YGroup2Zip_Basic(Vector<ExInt128> x, Vector<ExInt128> y, out Vector<ExInt128> data1) {
                var d0 = YGroup2Zip_Basic(x.ExAsExUInt128(), y.ExAsExUInt128(), out var d1);
                data1 = d1.ExAsExInt128();
                return d0.ExAsExInt128();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{ExUInt128}, Vector{ExUInt128}, out Vector{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExUInt128> YGroup2Zip_Basic(Vector<ExUInt128> x, Vector<ExUInt128> y, out Vector<ExUInt128> data1) {
                Span<Vector<ExUInt128>> rt = stackalloc Vector<ExUInt128>[2];
                ref ExUInt128 px = ref Unsafe.As<Vector<ExUInt128>, ExUInt128>(ref x);
                ref ExUInt128 py = ref Unsafe.As<Vector<ExUInt128>, ExUInt128>(ref y);
                Span<ExUInt128> q = MemoryMarshal.Cast<Vector<ExUInt128>, ExUInt128>(rt);
                int idx = 0;
                for (int i = 0; i < Vectors<ExUInt128>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    idx += 2;
                }
                data1 = rt[1];
                return rt[0];
            }

#if VECTOR_HAS_METHOD

#if BCL_HAS_SHIFT
            /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{float}, Vector{float}, out Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup2Zip_Widen(Vector<float> x, Vector<float> y, out Vector<float> data1) {
                var d0 = YGroup2Zip_Widen(x.AsUInt32(), y.AsUInt32(), out var d1);
                data1 = d1.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{sbyte}, Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup2Zip_Widen(Vector<sbyte> x, Vector<sbyte> y, out Vector<sbyte> data1) {
                var d0 = YGroup2Zip_Widen(x.AsByte(), y.AsByte(), out var d1);
                data1 = d1.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{byte}, Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup2Zip_Widen(Vector<byte> x, Vector<byte> y, out Vector<byte> data1) {
                const int L = 8;
                Vector<ushort> a0, a1, b0, b1;
                if (BitConverter.IsLittleEndian) {
                    Vector.Widen(y, out b0, out b1);
                    Vector.Widen(x, out a0, out a1);
                } else {
                    Vector.Widen(x, out b0, out b1);
                    Vector.Widen(y, out a0, out a1);
                }
                b0 = Vector.ShiftLeft(b0, L);
                b1 = Vector.ShiftLeft(b1, L);
                a0 = Vector.BitwiseOr(a0, b0);
                a1 = Vector.BitwiseOr(a1, b1);
                data1 = a1.AsByte();
                return a0.AsByte();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{short}, Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup2Zip_Widen(Vector<short> x, Vector<short> y, out Vector<short> data1) {
                var d0 = YGroup2Zip_Widen(x.AsUInt16(), y.AsUInt16(), out var d1);
                data1 = d1.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{ushort}, Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup2Zip_Widen(Vector<ushort> x, Vector<ushort> y, out Vector<ushort> data1) {
                const int L = 16;
                Vector<uint> a0, a1, b0, b1;
                if (BitConverter.IsLittleEndian) {
                    Vector.Widen(y, out b0, out b1);
                    Vector.Widen(x, out a0, out a1);
                } else {
                    Vector.Widen(x, out b0, out b1);
                    Vector.Widen(y, out a0, out a1);
                }
                b0 = Vector.ShiftLeft(b0, L);
                b1 = Vector.ShiftLeft(b1, L);
                a0 = Vector.BitwiseOr(a0, b0);
                a1 = Vector.BitwiseOr(a1, b1);
                data1 = a1.AsUInt16();
                return a0.AsUInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{int}, Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup2Zip_Widen(Vector<int> x, Vector<int> y, out Vector<int> data1) {
                var d0 = YGroup2Zip_Widen(x.AsUInt32(), y.AsUInt32(), out var d1);
                data1 = d1.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{uint}, Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup2Zip_Widen(Vector<uint> x, Vector<uint> y, out Vector<uint> data1) {
                const int L = 32;
                Vector<ulong> a0, a1, b0, b1;
                if (BitConverter.IsLittleEndian) {
                    Vector.Widen(y, out b0, out b1);
                    Vector.Widen(x, out a0, out a1);
                } else {
                    Vector.Widen(x, out b0, out b1);
                    Vector.Widen(y, out a0, out a1);
                }
                b0 = Vector.ShiftLeft(b0, L);
                b1 = Vector.ShiftLeft(b1, L);
                a0 = Vector.BitwiseOr(a0, b0);
                a1 = Vector.BitwiseOr(a1, b1);
                data1 = a1.AsUInt32();
                return a0.AsUInt32();
            }
#endif // BCL_HAS_SHIFT

            /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{sbyte}, Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup2Zip_WidenMul(Vector<sbyte> x, Vector<sbyte> y, out Vector<sbyte> data1) {
                var d0 = YGroup2Zip_WidenMul(x.AsByte(), y.AsByte(), out var d1);
                data1 = d1.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{byte}, Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup2Zip_WidenMul(Vector<byte> x, Vector<byte> y, out Vector<byte> data1) {
                const int L = 8;
                const short scale = 1 << L;
                Vector<short> vscale = new Vector<short>(scale);
                Vector<ushort> a0, a1, b0, b1;
                if (BitConverter.IsLittleEndian) {
                    Vector.Widen(y, out b0, out b1);
                    Vector.Widen(x, out a0, out a1);
                } else {
                    Vector.Widen(x, out b0, out b1);
                    Vector.Widen(y, out a0, out a1);
                }
                //b0 = Vector.ShiftLeft(b0, L);
                //b1 = Vector.ShiftLeft(b1, L);
                b0 = Vector.Multiply(b0.AsInt16(), vscale).AsUInt16();
                b1 = Vector.Multiply(b1.AsInt16(), vscale).AsUInt16();
                a0 = Vector.BitwiseOr(a0, b0);
                a1 = Vector.BitwiseOr(a1, b1);
                data1 = a1.AsByte();
                return a0.AsByte();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{short}, Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup2Zip_WidenMul(Vector<short> x, Vector<short> y, out Vector<short> data1) {
                var d0 = YGroup2Zip_WidenMul(x.AsUInt16(), y.AsUInt16(), out var d1);
                data1 = d1.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{ushort}, Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup2Zip_WidenMul(Vector<ushort> x, Vector<ushort> y, out Vector<ushort> data1) {
                const int L = 16;
                const int scale = 1 << L;
                Vector<int> vscale = new Vector<int>(scale);
                Vector<uint> a0, a1, b0, b1;
                if (BitConverter.IsLittleEndian) {
                    Vector.Widen(y, out b0, out b1);
                    Vector.Widen(x, out a0, out a1);
                } else {
                    Vector.Widen(x, out b0, out b1);
                    Vector.Widen(y, out a0, out a1);
                }
                //b0 = Vector.ShiftLeft(b0, L);
                //b1 = Vector.ShiftLeft(b1, L);
                b0 = Vector.Multiply(b0.AsInt32(), vscale).AsUInt32();
                b1 = Vector.Multiply(b1.AsInt32(), vscale).AsUInt32();
                a0 = Vector.BitwiseOr(a0, b0);
                a1 = Vector.BitwiseOr(a1, b1);
                data1 = a1.AsUInt16();
                return a0.AsUInt16();
            }

#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2ZipHigh_AcceleratedTypes {
                get {
                    return YGroup2Zip_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{float}, Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup2ZipHigh(Vector<float> x, Vector<float> y) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup2ZipHigh_Widen(x, y);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup2ZipHigh_Basic(x, y);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{double}, Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup2ZipHigh(Vector<double> x, Vector<double> y) {
                return YGroup2ZipHigh_Basic(x, y);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup2ZipHigh(Vector<sbyte> x, Vector<sbyte> y) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup2ZipHigh_Widen(x, y);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup2ZipHigh_Basic(x, y);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup2ZipHigh(Vector<byte> x, Vector<byte> y) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup2ZipHigh_Widen(x, y);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup2ZipHigh_Basic(x, y);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup2ZipHigh(Vector<short> x, Vector<short> y) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup2ZipHigh_Widen(x, y);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup2ZipHigh_Basic(x, y);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup2ZipHigh(Vector<ushort> x, Vector<ushort> y) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup2ZipHigh_Widen(x, y);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup2ZipHigh_Basic(x, y);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup2ZipHigh(Vector<int> x, Vector<int> y) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup2ZipHigh_Widen(x, y);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup2ZipHigh_Basic(x, y);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup2ZipHigh(Vector<uint> x, Vector<uint> y) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup2ZipHigh_Widen(x, y);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup2ZipHigh_Basic(x, y);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup2ZipHigh(Vector<long> x, Vector<long> y) {
                return YGroup2ZipHigh_Basic(x, y);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup2ZipHigh(Vector<ulong> x, Vector<ulong> y) {
                return YGroup2ZipHigh_Basic(x, y);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{ExInt128}, Vector{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExInt128> YGroup2ZipHigh(Vector<ExInt128> x, Vector<ExInt128> y) {
                _ = YGroup2Zip(x, y, out var rt1);
                return rt1;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{ExUInt128}, Vector{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExUInt128> YGroup2ZipHigh(Vector<ExUInt128> x, Vector<ExUInt128> y) {
                _ = YGroup2Zip(x, y, out var rt1);
                return rt1;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{float}, Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup2ZipHigh_Basic(Vector<float> x, Vector<float> y) {
                return YGroup2ZipHigh_Basic(x.AsUInt32(), y.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{double}, Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup2ZipHigh_Basic(Vector<double> x, Vector<double> y) {
                return YGroup2ZipHigh_Basic(x.AsUInt64(), y.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup2ZipHigh_Basic(Vector<sbyte> x, Vector<sbyte> y) {
                return YGroup2ZipHigh_Basic(x.AsByte(), y.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup2ZipHigh_Basic(Vector<byte> x, Vector<byte> y) {
                Span<Vector<byte>> rt = stackalloc Vector<byte>[1];
                ref byte px = ref Unsafe.As<Vector<byte>, byte>(ref x);
                ref byte py = ref Unsafe.As<Vector<byte>, byte>(ref y);
                Span<byte> q = MemoryMarshal.Cast<Vector<byte>, byte>(rt);
                int idx = 0;
                for (int i = Vector<byte>.Count / 2; idx < Vector<byte>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    idx += 2;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup2ZipHigh_Basic(Vector<short> x, Vector<short> y) {
                return YGroup2ZipHigh_Basic(x.AsUInt16(), y.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup2ZipHigh_Basic(Vector<ushort> x, Vector<ushort> y) {
                Span<Vector<ushort>> rt = stackalloc Vector<ushort>[1];
                ref ushort px = ref Unsafe.As<Vector<ushort>, ushort>(ref x);
                ref ushort py = ref Unsafe.As<Vector<ushort>, ushort>(ref y);
                Span<ushort> q = MemoryMarshal.Cast<Vector<ushort>, ushort>(rt);
                int idx = 0;
                for (int i = Vector<ushort>.Count / 2; idx < Vector<ushort>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    idx += 2;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup2ZipHigh_Basic(Vector<int> x, Vector<int> y) {
                return YGroup2ZipHigh_Basic(x.AsUInt32(), y.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup2ZipHigh_Basic(Vector<uint> x, Vector<uint> y) {
                Span<Vector<uint>> rt = stackalloc Vector<uint>[1];
                ref uint px = ref Unsafe.As<Vector<uint>, uint>(ref x);
                ref uint py = ref Unsafe.As<Vector<uint>, uint>(ref y);
                Span<uint> q = MemoryMarshal.Cast<Vector<uint>, uint>(rt);
                int idx = 0;
                for (int i = Vector<uint>.Count / 2; idx < Vector<uint>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    idx += 2;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup2ZipHigh_Basic(Vector<long> x, Vector<long> y) {
                return YGroup2ZipHigh_Basic(x.AsUInt64(), y.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup2ZipHigh_Basic(Vector<ulong> x, Vector<ulong> y) {
                Span<Vector<ulong>> rt = stackalloc Vector<ulong>[1];
                ref ulong px = ref Unsafe.As<Vector<ulong>, ulong>(ref x);
                ref ulong py = ref Unsafe.As<Vector<ulong>, ulong>(ref y);
                Span<ulong> q = MemoryMarshal.Cast<Vector<ulong>, ulong>(rt);
                int idx = 0;
                for (int i = Vector<ulong>.Count / 2; idx < Vector<ulong>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    idx += 2;
                }
                return rt[0];
            }

#if VECTOR_HAS_METHOD

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{float}, Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup2ZipHigh_Widen(Vector<float> x, Vector<float> y) {
                return YGroup2ZipHigh_Widen(x.AsUInt32(), y.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup2ZipHigh_Widen(Vector<sbyte> x, Vector<sbyte> y) {
                return YGroup2ZipHigh_Widen(x.AsByte(), y.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup2ZipHigh_Widen(Vector<byte> x, Vector<byte> y) {
#if BCL_HAS_SHIFT
                const int L = 8;
                Vector<ushort> a1, b1;
                if (BitConverter.IsLittleEndian) {
                    Vector.Widen(y, out _, out b1);
                    Vector.Widen(x, out _, out a1);
                } else {
                    Vector.Widen(x, out _, out b1);
                    Vector.Widen(y, out _, out a1);
                }
                b1 = Vector.ShiftLeft(b1, L);
                a1 = Vector.BitwiseOr(a1, b1);
                return a1.AsByte();
#else
                _ = YGroup2Zip(x, y, out var rt1);
                return rt1;
#endif // BCL_HAS_SHIFT
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup2ZipHigh_Widen(Vector<short> x, Vector<short> y) {
                return YGroup2ZipHigh_Widen(x.AsUInt16(), y.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup2ZipHigh_Widen(Vector<ushort> x, Vector<ushort> y) {
#if BCL_HAS_SHIFT
                const int L = 16;
                Vector<uint> a1, b1;
                if (BitConverter.IsLittleEndian) {
                    Vector.Widen(y, out _, out b1);
                    Vector.Widen(x, out _, out a1);
                } else {
                    Vector.Widen(x, out _, out b1);
                    Vector.Widen(y, out _, out a1);
                }
                b1 = Vector.ShiftLeft(b1, L);
                a1 = Vector.BitwiseOr(a1, b1);
                return a1.AsUInt16();
#else
                _ = YGroup2Zip(x, y, out var rt1);
                return rt1;
#endif // BCL_HAS_SHIFT
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup2ZipHigh_Widen(Vector<int> x, Vector<int> y) {
                return YGroup2ZipHigh_Widen(x.AsUInt32(), y.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup2ZipHigh_Widen(Vector<uint> x, Vector<uint> y) {
#if BCL_HAS_SHIFT
                const int L = 32;
                Vector<ulong> a1, b1;
                if (BitConverter.IsLittleEndian) {
                    Vector.Widen(y, out _, out b1);
                    Vector.Widen(x, out _, out a1);
                } else {
                    Vector.Widen(x, out _, out b1);
                    Vector.Widen(y, out _, out a1);
                }
                b1 = Vector.ShiftLeft(b1, L);
                a1 = Vector.BitwiseOr(a1, b1);
                return a1.AsUInt32();
#else
                return YGroup2ZipHigh_Basic(x, y);
#endif // BCL_HAS_SHIFT
            }

#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2ZipLow_AcceleratedTypes {
                get {
                    return YGroup2Zip_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{float}, Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup2ZipLow(Vector<float> x, Vector<float> y) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup2ZipLow_Widen(x, y);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup2ZipLow_Basic(x, y);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{double}, Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup2ZipLow(Vector<double> x, Vector<double> y) {
                return YGroup2ZipLow_Basic(x, y);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup2ZipLow(Vector<sbyte> x, Vector<sbyte> y) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup2ZipLow_Widen(x, y);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup2ZipLow_Basic(x, y);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup2ZipLow(Vector<byte> x, Vector<byte> y) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup2ZipLow_Widen(x, y);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup2ZipLow_Basic(x, y);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup2ZipLow(Vector<short> x, Vector<short> y) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup2ZipLow_Widen(x, y);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup2ZipLow_Basic(x, y);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup2ZipLow(Vector<ushort> x, Vector<ushort> y) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup2ZipLow_Widen(x, y);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup2ZipLow_Basic(x, y);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup2ZipLow(Vector<int> x, Vector<int> y) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup2ZipLow_Widen(x, y);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup2ZipLow_Basic(x, y);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup2ZipLow(Vector<uint> x, Vector<uint> y) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup2ZipLow_Widen(x, y);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup2ZipLow_Basic(x, y);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup2ZipLow(Vector<long> x, Vector<long> y) {
                return YGroup2ZipLow_Basic(x, y);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup2ZipLow(Vector<ulong> x, Vector<ulong> y) {
                return YGroup2ZipLow_Basic(x, y);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{ExInt128}, Vector{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExInt128> YGroup2ZipLow(Vector<ExInt128> x, Vector<ExInt128> y) {
                return YGroup2Zip(x, y, out _);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{ExUInt128}, Vector{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExUInt128> YGroup2ZipLow(Vector<ExUInt128> x, Vector<ExUInt128> y) {
                return YGroup2Zip(x, y, out _);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{float}, Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup2ZipLow_Basic(Vector<float> x, Vector<float> y) {
                return YGroup2ZipLow_Basic(x.AsUInt32(), y.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{double}, Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup2ZipLow_Basic(Vector<double> x, Vector<double> y) {
                return YGroup2ZipLow_Basic(x.AsUInt64(), y.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup2ZipLow_Basic(Vector<sbyte> x, Vector<sbyte> y) {
                return YGroup2ZipLow_Basic(x.AsByte(), y.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup2ZipLow_Basic(Vector<byte> x, Vector<byte> y) {
                Span<Vector<byte>> rt = stackalloc Vector<byte>[1];
                ref byte px = ref Unsafe.As<Vector<byte>, byte>(ref x);
                ref byte py = ref Unsafe.As<Vector<byte>, byte>(ref y);
                Span<byte> q = MemoryMarshal.Cast<Vector<byte>, byte>(rt);
                int idx = 0;
                for (int i = 0; idx < Vector<byte>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    idx += 2;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup2ZipLow_Basic(Vector<short> x, Vector<short> y) {
                return YGroup2ZipLow_Basic(x.AsUInt16(), y.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup2ZipLow_Basic(Vector<ushort> x, Vector<ushort> y) {
                Span<Vector<ushort>> rt = stackalloc Vector<ushort>[1];
                ref ushort px = ref Unsafe.As<Vector<ushort>, ushort>(ref x);
                ref ushort py = ref Unsafe.As<Vector<ushort>, ushort>(ref y);
                Span<ushort> q = MemoryMarshal.Cast<Vector<ushort>, ushort>(rt);
                int idx = 0;
                for (int i = 0; idx < Vector<ushort>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    idx += 2;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup2ZipLow_Basic(Vector<int> x, Vector<int> y) {
                return YGroup2ZipLow_Basic(x.AsUInt32(), y.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup2ZipLow_Basic(Vector<uint> x, Vector<uint> y) {
                Span<Vector<uint>> rt = stackalloc Vector<uint>[1];
                ref uint px = ref Unsafe.As<Vector<uint>, uint>(ref x);
                ref uint py = ref Unsafe.As<Vector<uint>, uint>(ref y);
                Span<uint> q = MemoryMarshal.Cast<Vector<uint>, uint>(rt);
                int idx = 0;
                for (int i = 0; idx < Vector<uint>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    idx += 2;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup2ZipLow_Basic(Vector<long> x, Vector<long> y) {
                return YGroup2ZipLow_Basic(x.AsUInt64(), y.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup2ZipLow_Basic(Vector<ulong> x, Vector<ulong> y) {
                Span<Vector<ulong>> rt = stackalloc Vector<ulong>[1];
                ref ulong px = ref Unsafe.As<Vector<ulong>, ulong>(ref x);
                ref ulong py = ref Unsafe.As<Vector<ulong>, ulong>(ref y);
                Span<ulong> q = MemoryMarshal.Cast<Vector<ulong>, ulong>(rt);
                int idx = 0;
                for (int i = 0; idx < Vector<ulong>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    idx += 2;
                }
                return rt[0];
            }

#if VECTOR_HAS_METHOD

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{float}, Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup2ZipLow_Widen(Vector<float> x, Vector<float> y) {
                return YGroup2ZipLow_Widen(x.AsUInt32(), y.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup2ZipLow_Widen(Vector<sbyte> x, Vector<sbyte> y) {
                return YGroup2ZipLow_Widen(x.AsByte(), y.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup2ZipLow_Widen(Vector<byte> x, Vector<byte> y) {
#if BCL_HAS_SHIFT
                const int L = 8;
                Vector<ushort> a0, b0;
                if (BitConverter.IsLittleEndian) {
                    Vector.Widen(y, out b0, out _);
                    Vector.Widen(x, out a0, out _);
                } else {
                    Vector.Widen(x, out b0, out _);
                    Vector.Widen(y, out a0, out _);
                }
                b0 = Vector.ShiftLeft(b0, L);
                a0 = Vector.BitwiseOr(a0, b0);
                return a0.AsByte();
#else
                return YGroup2Zip(x, y, out _);
#endif // BCL_HAS_SHIFT
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup2ZipLow_Widen(Vector<short> x, Vector<short> y) {
                return YGroup2ZipLow_Widen(x.AsUInt16(), y.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup2ZipLow_Widen(Vector<ushort> x, Vector<ushort> y) {
#if BCL_HAS_SHIFT
                const int L = 16;
                Vector<uint> a0, b0;
                if (BitConverter.IsLittleEndian) {
                    Vector.Widen(y, out b0, out _);
                    Vector.Widen(x, out a0, out _);
                } else {
                    Vector.Widen(x, out b0, out _);
                    Vector.Widen(y, out a0, out _);
                }
                b0 = Vector.ShiftLeft(b0, L);
                a0 = Vector.BitwiseOr(a0, b0);
                return a0.AsUInt16();
#else
                return YGroup2Zip(x, y, out _);
#endif // BCL_HAS_SHIFT
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup2ZipLow_Widen(Vector<int> x, Vector<int> y) {
                return YGroup2ZipLow_Widen(x.AsUInt32(), y.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup2ZipLow_Widen(Vector<uint> x, Vector<uint> y) {
#if BCL_HAS_SHIFT
                const int L = 32;
                Vector<ulong> a0, b0;
                if (BitConverter.IsLittleEndian) {
                    Vector.Widen(y, out b0, out _);
                    Vector.Widen(x, out a0, out _);
                } else {
                    Vector.Widen(x, out b0, out _);
                    Vector.Widen(y, out a0, out _);
                }
                b0 = Vector.ShiftLeft(b0, L);
                a0 = Vector.BitwiseOr(a0, b0);
                return a0.AsUInt32();
#else
                return YGroup2ZipLow_Basic(x, y);
#endif // BCL_HAS_SHIFT
            }

#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IVectorTraits.YGroup3ToGroup4_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup3ToGroup4_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector.IsHardwareAccelerated) {
                        rt = TypeCodeFlags.Byte | TypeCodeFlags.SByte;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ToGroup4(Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup3ToGroup4(Vector<float> data0, Vector<float> data1, Vector<float> data2, out Vector<float> result1, out Vector<float> result2, out Vector<float> result3) {
                var d0 = YGroup3ToGroup4(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), out var d1, out var d2, out var d3);
                result1 = d1.AsSingle();
                result2 = d2.AsSingle();
                result3 = d3.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ToGroup4(Vector{double}, Vector{double}, Vector{double}, out Vector{double}, out Vector{double}, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup3ToGroup4(Vector<double> data0, Vector<double> data1, Vector<double> data2, out Vector<double> result1, out Vector<double> result2, out Vector<double> result3) {
                var d0 = YGroup3ToGroup4(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), out var d1, out var d2, out var d3);
                result1 = d1.AsDouble();
                result2 = d2.AsDouble();
                result3 = d3.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ToGroup4(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup3ToGroup4(Vector<sbyte> data0, Vector<sbyte> data1, Vector<sbyte> data2, out Vector<sbyte> result1, out Vector<sbyte> result2, out Vector<sbyte> result3) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup3ToGroup4_Unzip(data0, data1, data2, out result1, out result2, out result3);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3ToGroup4_Basic(data0, data1, data2, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ToGroup4(Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup3ToGroup4(Vector<byte> data0, Vector<byte> data1, Vector<byte> data2, out Vector<byte> result1, out Vector<byte> result2, out Vector<byte> result3) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup3ToGroup4_Unzip(data0, data1, data2, out result1, out result2, out result3);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YGroup3ToGroup4_Basic(data0, data1, data2, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ToGroup4(Vector{short}, Vector{short}, Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup3ToGroup4(Vector<short> data0, Vector<short> data1, Vector<short> data2, out Vector<short> result1, out Vector<short> result2, out Vector<short> result3) {
                return YGroup3ToGroup4_Basic(data0, data1, data2, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ToGroup4(Vector{ushort}, Vector{ushort}, Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup3ToGroup4(Vector<ushort> data0, Vector<ushort> data1, Vector<ushort> data2, out Vector<ushort> result1, out Vector<ushort> result2, out Vector<ushort> result3) {
                return YGroup3ToGroup4_Basic(data0, data1, data2, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ToGroup4(Vector{int}, Vector{int}, Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup3ToGroup4(Vector<int> data0, Vector<int> data1, Vector<int> data2, out Vector<int> result1, out Vector<int> result2, out Vector<int> result3) {
                return YGroup3ToGroup4_Basic(data0, data1, data2, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ToGroup4(Vector{uint}, Vector{uint}, Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup3ToGroup4(Vector<uint> data0, Vector<uint> data1, Vector<uint> data2, out Vector<uint> result1, out Vector<uint> result2, out Vector<uint> result3) {
                return YGroup3ToGroup4_Basic(data0, data1, data2, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ToGroup4(Vector{long}, Vector{long}, Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup3ToGroup4(Vector<long> data0, Vector<long> data1, Vector<long> data2, out Vector<long> result1, out Vector<long> result2, out Vector<long> result3) {
                return YGroup3ToGroup4_Basic(data0, data1, data2, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ToGroup4(Vector{ulong}, Vector{ulong}, Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup3ToGroup4(Vector<ulong> data0, Vector<ulong> data1, Vector<ulong> data2, out Vector<ulong> result1, out Vector<ulong> result2, out Vector<ulong> result3) {
                return YGroup3ToGroup4_Basic(data0, data1, data2, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ToGroup4(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup3ToGroup4_Basic(Vector<sbyte> data0, Vector<sbyte> data1, Vector<sbyte> data2, out Vector<sbyte> result1, out Vector<sbyte> result2, out Vector<sbyte> result3) {
                var d0 = YGroup3ToGroup4_Basic(data0.AsByte(), data1.AsByte(), data2.AsByte(), out var d1, out var d2, out var d3);
                result1 = d1.AsSByte();
                result2 = d2.AsSByte();
                result3 = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ToGroup4(Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup3ToGroup4_Basic(Vector<byte> data0, Vector<byte> data1, Vector<byte> data2, out Vector<byte> result1, out Vector<byte> result2, out Vector<byte> result3) {
                const byte zero = 0;
                Span<Vector<byte>> src = [data0, data1, data2];
                Span<Vector<byte>> dst = stackalloc Vector<byte>[4];
                Span<byte> p = MemoryMarshal.Cast<Vector<byte>, byte>(src);
                Span<byte> q = MemoryMarshal.Cast<Vector<byte>, byte>(dst);
                for (int i = 0; i < Vector<byte>.Count; ++i) {
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

            /// <inheritdoc cref="IVectorTraits.YGroup3ToGroup4(Vector{short}, Vector{short}, Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup3ToGroup4_Basic(Vector<short> data0, Vector<short> data1, Vector<short> data2, out Vector<short> result1, out Vector<short> result2, out Vector<short> result3) {
                var d0 = YGroup3ToGroup4_Basic(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), out var d1, out var d2, out var d3);
                result1 = d1.AsInt16();
                result2 = d2.AsInt16();
                result3 = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ToGroup4(Vector{ushort}, Vector{ushort}, Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup3ToGroup4_Basic(Vector<ushort> data0, Vector<ushort> data1, Vector<ushort> data2, out Vector<ushort> result1, out Vector<ushort> result2, out Vector<ushort> result3) {
                const ushort zero = 0;
                Span<Vector<ushort>> src = [data0, data1, data2];
                Span<Vector<ushort>> dst = stackalloc Vector<ushort>[4];
                Span<ushort> p = MemoryMarshal.Cast<Vector<ushort>, ushort>(src);
                Span<ushort> q = MemoryMarshal.Cast<Vector<ushort>, ushort>(dst);
                for (int i = 0; i < Vector<ushort>.Count; ++i) {
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

            /// <inheritdoc cref="IVectorTraits.YGroup3ToGroup4(Vector{int}, Vector{int}, Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup3ToGroup4_Basic(Vector<int> data0, Vector<int> data1, Vector<int> data2, out Vector<int> result1, out Vector<int> result2, out Vector<int> result3) {
                var d0 = YGroup3ToGroup4_Basic(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), out var d1, out var d2, out var d3);
                result1 = d1.AsInt32();
                result2 = d2.AsInt32();
                result3 = d3.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ToGroup4(Vector{uint}, Vector{uint}, Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup3ToGroup4_Basic(Vector<uint> data0, Vector<uint> data1, Vector<uint> data2, out Vector<uint> result1, out Vector<uint> result2, out Vector<uint> result3) {
                const uint zero = 0;
                Span<Vector<uint>> src = [data0, data1, data2];
                Span<Vector<uint>> dst = stackalloc Vector<uint>[4];
                Span<uint> p = MemoryMarshal.Cast<Vector<uint>, uint>(src);
                Span<uint> q = MemoryMarshal.Cast<Vector<uint>, uint>(dst);
                for (int i = 0; i < Vector<uint>.Count; ++i) {
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

            /// <inheritdoc cref="IVectorTraits.YGroup3ToGroup4(Vector{long}, Vector{long}, Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup3ToGroup4_Basic(Vector<long> data0, Vector<long> data1, Vector<long> data2, out Vector<long> result1, out Vector<long> result2, out Vector<long> result3) {
                var d0 = YGroup3ToGroup4_Basic(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), out var d1, out var d2, out var d3);
                result1 = d1.AsInt64();
                result2 = d2.AsInt64();
                result3 = d3.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ToGroup4(Vector{ulong}, Vector{ulong}, Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup3ToGroup4_Basic(Vector<ulong> data0, Vector<ulong> data1, Vector<ulong> data2, out Vector<ulong> result1, out Vector<ulong> result2, out Vector<ulong> result3) {
                const ulong zero = 0;
                Span<Vector<ulong>> src = [data0, data1, data2];
                Span<Vector<ulong>> dst = stackalloc Vector<ulong>[4];
                Span<ulong> p = MemoryMarshal.Cast<Vector<ulong>, ulong>(src);
                Span<ulong> q = MemoryMarshal.Cast<Vector<ulong>, ulong>(dst);
                for (int i = 0; i < Vector<ulong>.Count; ++i) {
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

            /// <inheritdoc cref="IVectorTraits.YGroup3ToGroup4(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup3ToGroup4_Unzip(Vector<sbyte> data0, Vector<sbyte> data1, Vector<sbyte> data2, out Vector<sbyte> result1, out Vector<sbyte> result2, out Vector<sbyte> result3) {
                var d0 = YGroup3ToGroup4_Unzip(data0.AsByte(), data1.AsByte(), data2.AsByte(), out var d1, out var d2, out var d3);
                result1 = d1.AsSByte();
                result2 = d2.AsSByte();
                result3 = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ToGroup4(Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup3ToGroup4_Unzip(Vector<byte> data0, Vector<byte> data1, Vector<byte> data2, out Vector<byte> result1, out Vector<byte> result2, out Vector<byte> result3) {
                var a_3 = Vector<byte>.Zero;
                var a_0 = YGroup3Unzip(data0, data1, data2, out var a_1, out var a_2);
                var b_0 = YGroup4Zip(a_0, a_1, a_2, a_3, out var b_1, out var b_2, out var b_3);
                result1 = b_1;
                result2 = b_2;
                result3 = b_3;
                return b_0;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ToGroup4(Vector{short}, Vector{short}, Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup3ToGroup4_Unzip(Vector<short> data0, Vector<short> data1, Vector<short> data2, out Vector<short> result1, out Vector<short> result2, out Vector<short> result3) {
                var d0 = YGroup3ToGroup4_Unzip(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), out var d1, out var d2, out var d3);
                result1 = d1.AsInt16();
                result2 = d2.AsInt16();
                result3 = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ToGroup4(Vector{ushort}, Vector{ushort}, Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup3ToGroup4_Unzip(Vector<ushort> data0, Vector<ushort> data1, Vector<ushort> data2, out Vector<ushort> result1, out Vector<ushort> result2, out Vector<ushort> result3) {
                var a_3 = Vector<ushort>.Zero;
                var a_0 = YGroup3Unzip(data0, data1, data2, out var a_1, out var a_2);
                var b_0 = YGroup4Zip(a_0, a_1, a_2, a_3, out var b_1, out var b_2, out var b_3);
                result1 = b_1;
                result2 = b_2;
                result3 = b_3;
                return b_0;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ToGroup4(Vector{int}, Vector{int}, Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup3ToGroup4_Unzip(Vector<int> data0, Vector<int> data1, Vector<int> data2, out Vector<int> result1, out Vector<int> result2, out Vector<int> result3) {
                var d0 = YGroup3ToGroup4_Unzip(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), out var d1, out var d2, out var d3);
                result1 = d1.AsInt32();
                result2 = d2.AsInt32();
                result3 = d3.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ToGroup4(Vector{uint}, Vector{uint}, Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup3ToGroup4_Unzip(Vector<uint> data0, Vector<uint> data1, Vector<uint> data2, out Vector<uint> result1, out Vector<uint> result2, out Vector<uint> result3) {
                var a_3 = Vector<uint>.Zero;
                var a_0 = YGroup3Unzip(data0, data1, data2, out var a_1, out var a_2);
                var b_0 = YGroup4Zip(a_0, a_1, a_2, a_3, out var b_1, out var b_2, out var b_3);
                result1 = b_1;
                result2 = b_2;
                result3 = b_3;
                return b_0;
            }

#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup3Unzip_AcceleratedTypes {
                get {
#if NET8_0_OR_GREATER
                    if (RuntimeInformation.ProcessArchitecture == Architecture.Wasm) {
                        return TypeCodeFlags.None;
                    }
#endif // NET8_0_OR_GREATER
                    return YGroup2Zip_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup3Unzip(Vector<float> data0, Vector<float> data1, Vector<float> data2, out Vector<float> y, out Vector<float> z) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD && BCL_HAS_SHIFT
                if (Vector.IsHardwareAccelerated) {
                    return YGroup3Unzip_ByX2Zip(data0, data1, data2, out y, out z);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{double}, Vector{double}, Vector{double}, out Vector{double}, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup3Unzip(Vector<double> data0, Vector<double> data1, Vector<double> data2, out Vector<double> y, out Vector<double> z) {
                return YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup3Unzip(Vector<sbyte> data0, Vector<sbyte> data1, Vector<sbyte> data2, out Vector<sbyte> y, out Vector<sbyte> z) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup3Unzip_ByX2Zip(data0, data1, data2, out y, out z);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup3Unzip(Vector<byte> data0, Vector<byte> data1, Vector<byte> data2, out Vector<byte> y, out Vector<byte> z) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup3Unzip_ByX2Zip(data0, data1, data2, out y, out z);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{short}, Vector{short}, Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup3Unzip(Vector<short> data0, Vector<short> data1, Vector<short> data2, out Vector<short> y, out Vector<short> z) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup3Unzip_ByX2Zip(data0, data1, data2, out y, out z);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{ushort}, Vector{ushort}, Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup3Unzip(Vector<ushort> data0, Vector<ushort> data1, Vector<ushort> data2, out Vector<ushort> y, out Vector<ushort> z) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup3Unzip_ByX2Zip(data0, data1, data2, out y, out z);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{int}, Vector{int}, Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup3Unzip(Vector<int> data0, Vector<int> data1, Vector<int> data2, out Vector<int> y, out Vector<int> z) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD && BCL_HAS_SHIFT
                if (Vector.IsHardwareAccelerated) {
                    return YGroup3Unzip_ByX2Zip(data0, data1, data2, out y, out z);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{uint}, Vector{uint}, Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup3Unzip(Vector<uint> data0, Vector<uint> data1, Vector<uint> data2, out Vector<uint> y, out Vector<uint> z) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD && BCL_HAS_SHIFT
                if (Vector.IsHardwareAccelerated) {
                    return YGroup3Unzip_ByX2Zip(data0, data1, data2, out y, out z);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{long}, Vector{long}, Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup3Unzip(Vector<long> data0, Vector<long> data1, Vector<long> data2, out Vector<long> y, out Vector<long> z) {
                return YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{ulong}, Vector{ulong}, Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup3Unzip(Vector<ulong> data0, Vector<ulong> data1, Vector<ulong> data2, out Vector<ulong> y, out Vector<ulong> z) {
                return YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip_Bit128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<T> YGroup3Unzip_Bit128<T>(Vector<T> data0, Vector<T> data1, Vector<T> data2, out Vector<T> y, out Vector<T> z) where T : struct {
                var d0 = YGroup3Unzip_Basic(data0.ExAsExUInt128(), data1.ExAsExUInt128(), data2.ExAsExUInt128(), out var d1, out var d2);
                y = d1.ExAs<ExUInt128, T>();
                z = d2.ExAs<ExUInt128, T>();
                return d0.ExAs<ExUInt128, T>();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup3Unzip_Basic(Vector<float> data0, Vector<float> data1, Vector<float> data2, out Vector<float> y, out Vector<float> z) {
                var d0 = YGroup3Unzip_Basic(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), out var d1, out var d2);
                y = d1.AsSingle();
                z = d2.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{double}, Vector{double}, Vector{double}, out Vector{double}, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup3Unzip_Basic(Vector<double> data0, Vector<double> data1, Vector<double> data2, out Vector<double> y, out Vector<double> z) {
                var d0 = YGroup3Unzip_Basic(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), out var d1, out var d2);
                y = d1.AsDouble();
                z = d2.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup3Unzip_Basic(Vector<sbyte> data0, Vector<sbyte> data1, Vector<sbyte> data2, out Vector<sbyte> y, out Vector<sbyte> z) {
                var d0 = YGroup3Unzip_Basic(data0.AsByte(), data1.AsByte(), data2.AsByte(), out var d1, out var d2);
                y = d1.AsSByte();
                z = d2.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup3Unzip_Basic(Vector<byte> data0, Vector<byte> data1, Vector<byte> data2, out Vector<byte> y, out Vector<byte> z) {
                UnsafeUtil.SkipInit(out Vector<byte> x1);
                UnsafeUtil.SkipInit(out Vector<byte> y1);
                UnsafeUtil.SkipInit(out Vector<byte> z1);
                Span<Vector<byte>> src = [data0, data1, data2];
                ref byte px = ref Unsafe.As<Vector<byte>, byte>(ref x1);
                ref byte py = ref Unsafe.As<Vector<byte>, byte>(ref y1);
                ref byte pz = ref Unsafe.As<Vector<byte>, byte>(ref z1);
                Span<byte> p = MemoryMarshal.Cast<Vector<byte>, byte>(src);
                int idx = 0;
                for (int i = 0; i < Vector<byte>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    Unsafe.Add(ref py, i) = p[idx + 1];
                    Unsafe.Add(ref pz, i) = p[idx + 2];
                    idx += 3;
                }
                y = y1;
                z = z1;
                return x1;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{short}, Vector{short}, Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup3Unzip_Basic(Vector<short> data0, Vector<short> data1, Vector<short> data2, out Vector<short> y, out Vector<short> z) {
                var d0 = YGroup3Unzip_Basic(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), out var d1, out var d2);
                y = d1.AsInt16();
                z = d2.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{ushort}, Vector{ushort}, Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup3Unzip_Basic(Vector<ushort> data0, Vector<ushort> data1, Vector<ushort> data2, out Vector<ushort> y, out Vector<ushort> z) {
                UnsafeUtil.SkipInit(out Vector<ushort> x1);
                UnsafeUtil.SkipInit(out Vector<ushort> y1);
                UnsafeUtil.SkipInit(out Vector<ushort> z1);
                Span<Vector<ushort>> src = [data0, data1, data2];
                ref ushort px = ref Unsafe.As<Vector<ushort>, ushort>(ref x1);
                ref ushort py = ref Unsafe.As<Vector<ushort>, ushort>(ref y1);
                ref ushort pz = ref Unsafe.As<Vector<ushort>, ushort>(ref z1);
                Span<ushort> p = MemoryMarshal.Cast<Vector<ushort>, ushort>(src);
                int idx = 0;
                for (int i = 0; i < Vector<ushort>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    Unsafe.Add(ref py, i) = p[idx + 1];
                    Unsafe.Add(ref pz, i) = p[idx + 2];
                    idx += 3;
                }
                y = y1;
                z = z1;
                return x1;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{int}, Vector{int}, Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup3Unzip_Basic(Vector<int> data0, Vector<int> data1, Vector<int> data2, out Vector<int> y, out Vector<int> z) {
                var d0 = YGroup3Unzip_Basic(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), out var d1, out var d2);
                y = d1.AsInt32();
                z = d2.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{uint}, Vector{uint}, Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup3Unzip_Basic(Vector<uint> data0, Vector<uint> data1, Vector<uint> data2, out Vector<uint> y, out Vector<uint> z) {
                UnsafeUtil.SkipInit(out Vector<uint> x1);
                UnsafeUtil.SkipInit(out Vector<uint> y1);
                UnsafeUtil.SkipInit(out Vector<uint> z1);
                Span<Vector<uint>> src = [data0, data1, data2];
                ref uint px = ref Unsafe.As<Vector<uint>, uint>(ref x1);
                ref uint py = ref Unsafe.As<Vector<uint>, uint>(ref y1);
                ref uint pz = ref Unsafe.As<Vector<uint>, uint>(ref z1);
                Span<uint> p = MemoryMarshal.Cast<Vector<uint>, uint>(src);
                int idx = 0;
                for (int i = 0; i < Vector<uint>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    Unsafe.Add(ref py, i) = p[idx + 1];
                    Unsafe.Add(ref pz, i) = p[idx + 2];
                    idx += 3;
                }
                y = y1;
                z = z1;
                return x1;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{long}, Vector{long}, Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup3Unzip_Basic(Vector<long> data0, Vector<long> data1, Vector<long> data2, out Vector<long> y, out Vector<long> z) {
                var d0 = YGroup3Unzip_Basic(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), out var d1, out var d2);
                y = d1.AsInt64();
                z = d2.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{ulong}, Vector{ulong}, Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup3Unzip_Basic(Vector<ulong> data0, Vector<ulong> data1, Vector<ulong> data2, out Vector<ulong> y, out Vector<ulong> z) {
                UnsafeUtil.SkipInit(out Vector<ulong> x1);
                UnsafeUtil.SkipInit(out Vector<ulong> y1);
                UnsafeUtil.SkipInit(out Vector<ulong> z1);
                Span<Vector<ulong>> src = [data0, data1, data2];
                ref ulong px = ref Unsafe.As<Vector<ulong>, ulong>(ref x1);
                ref ulong py = ref Unsafe.As<Vector<ulong>, ulong>(ref y1);
                ref ulong pz = ref Unsafe.As<Vector<ulong>, ulong>(ref z1);
                Span<ulong> p = MemoryMarshal.Cast<Vector<ulong>, ulong>(src);
                int idx = 0;
                for (int i = 0; i < Vector<ulong>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    Unsafe.Add(ref py, i) = p[idx + 1];
                    Unsafe.Add(ref pz, i) = p[idx + 2];
                    idx += 3;
                }
                y = y1;
                z = z1;
                return x1;
            }

            // / <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{ExInt128}, Vector{ExInt128}, Vector{ExInt128}, out Vector{ExInt128}, out Vector{ExInt128})"/>
            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{long}, Vector{long}, Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExInt128> YGroup3Unzip_Basic(Vector<ExInt128> data0, Vector<ExInt128> data1, Vector<ExInt128> data2, out Vector<ExInt128> y, out Vector<ExInt128> z) {
                var d0 = YGroup3Unzip_Basic(data0.ExAsExUInt128(), data1.ExAsExUInt128(), data2.ExAsExUInt128(), out var d1, out var d2);
                y = d1.ExAsExInt128();
                z = d2.ExAsExInt128();
                return d0.ExAsExInt128();
            }

            // / <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{ExUInt128}, Vector{ExUInt128}, Vector{ExUInt128}, out Vector{ExUInt128}, out Vector{ExUInt128})"/>
            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{ulong}, Vector{ulong}, Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExUInt128> YGroup3Unzip_Basic(Vector<ExUInt128> data0, Vector<ExUInt128> data1, Vector<ExUInt128> data2, out Vector<ExUInt128> y, out Vector<ExUInt128> z) {
                UnsafeUtil.SkipInit(out Vector<ExUInt128> x1);
                UnsafeUtil.SkipInit(out Vector<ExUInt128> y1);
                UnsafeUtil.SkipInit(out Vector<ExUInt128> z1);
                Span<Vector<ExUInt128>> src = [data0, data1, data2];
                ref ExUInt128 px = ref Unsafe.As<Vector<ExUInt128>, ExUInt128>(ref x1);
                ref ExUInt128 py = ref Unsafe.As<Vector<ExUInt128>, ExUInt128>(ref y1);
                ref ExUInt128 pz = ref Unsafe.As<Vector<ExUInt128>, ExUInt128>(ref z1);
                Span<ExUInt128> p = MemoryMarshal.Cast<Vector<ExUInt128>, ExUInt128>(src);
                int idx = 0;
                for (int i = 0; i < Vectors<ExUInt128>.Count; ++i) {
                    Unsafe.Add(ref px, i) = p[idx];
                    Unsafe.Add(ref py, i) = p[idx + 1];
                    Unsafe.Add(ref pz, i) = p[idx + 2];
                    idx += 3;
                }
                y = y1;
                z = z1;
                return x1;
            }

#if VECTOR_HAS_METHOD

            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup3Unzip_ByX2Zip(Vector<float> data0, Vector<float> data1, Vector<float> data2, out Vector<float> y, out Vector<float> z) {
                return YGroup3UnzipX2_Zip(data0, data1, data2, data0, data1, data2, out _, out y, out _, out z, out _);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup3Unzip_ByX2Zip(Vector<sbyte> data0, Vector<sbyte> data1, Vector<sbyte> data2, out Vector<sbyte> y, out Vector<sbyte> z) {
                return YGroup3UnzipX2_Zip(data0, data1, data2, data0, data1, data2, out _, out y, out _, out z, out _);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup3Unzip_ByX2Zip(Vector<byte> data0, Vector<byte> data1, Vector<byte> data2, out Vector<byte> y, out Vector<byte> z) {
                return YGroup3UnzipX2_Zip(data0, data1, data2, data0, data1, data2, out _, out y, out _, out z, out _);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{short}, Vector{short}, Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup3Unzip_ByX2Zip(Vector<short> data0, Vector<short> data1, Vector<short> data2, out Vector<short> y, out Vector<short> z) {
                return YGroup3UnzipX2_Zip(data0, data1, data2, data0, data1, data2, out _, out y, out _, out z, out _);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{ushort}, Vector{ushort}, Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup3Unzip_ByX2Zip(Vector<ushort> data0, Vector<ushort> data1, Vector<ushort> data2, out Vector<ushort> y, out Vector<ushort> z) {
                return YGroup3UnzipX2_Zip(data0, data1, data2, data0, data1, data2, out _, out y, out _, out z, out _);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{int}, Vector{int}, Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup3Unzip_ByX2Zip(Vector<int> data0, Vector<int> data1, Vector<int> data2, out Vector<int> y, out Vector<int> z) {
                return YGroup3UnzipX2_Zip(data0, data1, data2, data0, data1, data2, out _, out y, out _, out z, out _);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{uint}, Vector{uint}, Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup3Unzip_ByX2Zip(Vector<uint> data0, Vector<uint> data1, Vector<uint> data2, out Vector<uint> y, out Vector<uint> z) {
                return YGroup3UnzipX2_Zip(data0, data1, data2, data0, data1, data2, out _, out y, out _, out z, out _);
            }

#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup3UnzipX2_AcceleratedTypes {
                get {
#if NET8_0_OR_GREATER
                    if (RuntimeInformation.ProcessArchitecture == Architecture.Wasm) {
                        return TypeCodeFlags.None;
                    }
#endif // NET8_0_OR_GREATER
                    return YGroup2Zip_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup3UnzipX2(Vector<float> data0, Vector<float> data1, Vector<float> data2, Vector<float> data3, Vector<float> data4, Vector<float> data5, out Vector<float> xB, out Vector<float> y, out Vector<float> yB, out Vector<float> z, out Vector<float> zB) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD && BCL_HAS_SHIFT
                if (Vector.IsHardwareAccelerated) {
                    return YGroup3UnzipX2_Zip(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup3UnzipX2_Basic(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{double}, out Vector{double}, out Vector{double}, out Vector{double}, out Vector{double}, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup3UnzipX2(Vector<double> data0, Vector<double> data1, Vector<double> data2, Vector<double> data3, Vector<double> data4, Vector<double> data5, out Vector<double> xB, out Vector<double> y, out Vector<double> yB, out Vector<double> z, out Vector<double> zB) {
                return YGroup3UnzipX2_Basic(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup3UnzipX2(Vector<sbyte> data0, Vector<sbyte> data1, Vector<sbyte> data2, Vector<sbyte> data3, Vector<sbyte> data4, Vector<sbyte> data5, out Vector<sbyte> xB, out Vector<sbyte> y, out Vector<sbyte> yB, out Vector<sbyte> z, out Vector<sbyte> zB) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup3UnzipX2_Zip(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup3UnzipX2_Basic(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup3UnzipX2(Vector<byte> data0, Vector<byte> data1, Vector<byte> data2, Vector<byte> data3, Vector<byte> data4, Vector<byte> data5, out Vector<byte> xB, out Vector<byte> y, out Vector<byte> yB, out Vector<byte> z, out Vector<byte> zB) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup3UnzipX2_Zip(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup3UnzipX2_Basic(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup3UnzipX2(Vector<short> data0, Vector<short> data1, Vector<short> data2, Vector<short> data3, Vector<short> data4, Vector<short> data5, out Vector<short> xB, out Vector<short> y, out Vector<short> yB, out Vector<short> z, out Vector<short> zB) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup3UnzipX2_Zip(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup3UnzipX2_Basic(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup3UnzipX2(Vector<ushort> data0, Vector<ushort> data1, Vector<ushort> data2, Vector<ushort> data3, Vector<ushort> data4, Vector<ushort> data5, out Vector<ushort> xB, out Vector<ushort> y, out Vector<ushort> yB, out Vector<ushort> z, out Vector<ushort> zB) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup3UnzipX2_Zip(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup3UnzipX2_Basic(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup3UnzipX2(Vector<int> data0, Vector<int> data1, Vector<int> data2, Vector<int> data3, Vector<int> data4, Vector<int> data5, out Vector<int> xB, out Vector<int> y, out Vector<int> yB, out Vector<int> z, out Vector<int> zB) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD && BCL_HAS_SHIFT
                if (Vector.IsHardwareAccelerated) {
                    return YGroup3UnzipX2_Zip(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup3UnzipX2_Basic(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup3UnzipX2(Vector<uint> data0, Vector<uint> data1, Vector<uint> data2, Vector<uint> data3, Vector<uint> data4, Vector<uint> data5, out Vector<uint> xB, out Vector<uint> y, out Vector<uint> yB, out Vector<uint> z, out Vector<uint> zB) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD && BCL_HAS_SHIFT
                if (Vector.IsHardwareAccelerated) {
                    return YGroup3UnzipX2_Zip(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup3UnzipX2_Basic(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup3UnzipX2(Vector<long> data0, Vector<long> data1, Vector<long> data2, Vector<long> data3, Vector<long> data4, Vector<long> data5, out Vector<long> xB, out Vector<long> y, out Vector<long> yB, out Vector<long> z, out Vector<long> zB) {
                return YGroup3UnzipX2_Basic(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup3UnzipX2(Vector<ulong> data0, Vector<ulong> data1, Vector<ulong> data2, Vector<ulong> data3, Vector<ulong> data4, Vector<ulong> data5, out Vector<ulong> xB, out Vector<ulong> y, out Vector<ulong> yB, out Vector<ulong> z, out Vector<ulong> zB) {
                return YGroup3UnzipX2_Basic(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2_Bit128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<T> YGroup3UnzipX2_Bit128<T>(Vector<T> data0, Vector<T> data1, Vector<T> data2, Vector<T> data3, Vector<T> data4, Vector<T> data5, out Vector<T> xB, out Vector<T> y, out Vector<T> yB, out Vector<T> z, out Vector<T> zB) where T : struct {
                var x = YGroup3Unzip_Bit128(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip_Bit128(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup3UnzipX2_Basic(Vector<float> data0, Vector<float> data1, Vector<float> data2, Vector<float> data3, Vector<float> data4, Vector<float> data5, out Vector<float> xB, out Vector<float> y, out Vector<float> yB, out Vector<float> z, out Vector<float> zB) {
                var x = YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip_Basic(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{double}, out Vector{double}, out Vector{double}, out Vector{double}, out Vector{double}, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup3UnzipX2_Basic(Vector<double> data0, Vector<double> data1, Vector<double> data2, Vector<double> data3, Vector<double> data4, Vector<double> data5, out Vector<double> xB, out Vector<double> y, out Vector<double> yB, out Vector<double> z, out Vector<double> zB) {
                var x = YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip_Basic(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup3UnzipX2_Basic(Vector<sbyte> data0, Vector<sbyte> data1, Vector<sbyte> data2, Vector<sbyte> data3, Vector<sbyte> data4, Vector<sbyte> data5, out Vector<sbyte> xB, out Vector<sbyte> y, out Vector<sbyte> yB, out Vector<sbyte> z, out Vector<sbyte> zB) {
                var x = YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip_Basic(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup3UnzipX2_Basic(Vector<byte> data0, Vector<byte> data1, Vector<byte> data2, Vector<byte> data3, Vector<byte> data4, Vector<byte> data5, out Vector<byte> xB, out Vector<byte> y, out Vector<byte> yB, out Vector<byte> z, out Vector<byte> zB) {
                var x = YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip_Basic(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup3UnzipX2_Basic(Vector<short> data0, Vector<short> data1, Vector<short> data2, Vector<short> data3, Vector<short> data4, Vector<short> data5, out Vector<short> xB, out Vector<short> y, out Vector<short> yB, out Vector<short> z, out Vector<short> zB) {
                var x = YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip_Basic(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup3UnzipX2_Basic(Vector<ushort> data0, Vector<ushort> data1, Vector<ushort> data2, Vector<ushort> data3, Vector<ushort> data4, Vector<ushort> data5, out Vector<ushort> xB, out Vector<ushort> y, out Vector<ushort> yB, out Vector<ushort> z, out Vector<ushort> zB) {
                var x = YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip_Basic(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup3UnzipX2_Basic(Vector<int> data0, Vector<int> data1, Vector<int> data2, Vector<int> data3, Vector<int> data4, Vector<int> data5, out Vector<int> xB, out Vector<int> y, out Vector<int> yB, out Vector<int> z, out Vector<int> zB) {
                var x = YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip_Basic(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup3UnzipX2_Basic(Vector<uint> data0, Vector<uint> data1, Vector<uint> data2, Vector<uint> data3, Vector<uint> data4, Vector<uint> data5, out Vector<uint> xB, out Vector<uint> y, out Vector<uint> yB, out Vector<uint> z, out Vector<uint> zB) {
                var x = YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip_Basic(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup3UnzipX2_Basic(Vector<long> data0, Vector<long> data1, Vector<long> data2, Vector<long> data3, Vector<long> data4, Vector<long> data5, out Vector<long> xB, out Vector<long> y, out Vector<long> yB, out Vector<long> z, out Vector<long> zB) {
                var x = YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip_Basic(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup3UnzipX2_Basic(Vector<ulong> data0, Vector<ulong> data1, Vector<ulong> data2, Vector<ulong> data3, Vector<ulong> data4, Vector<ulong> data5, out Vector<ulong> xB, out Vector<ulong> y, out Vector<ulong> yB, out Vector<ulong> z, out Vector<ulong> zB) {
                var x = YGroup3Unzip_Basic(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip_Basic(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup3UnzipX2_X2(Vector<float> data0, Vector<float> data1, Vector<float> data2, Vector<float> data3, Vector<float> data4, Vector<float> data5, out Vector<float> xB, out Vector<float> y, out Vector<float> yB, out Vector<float> z, out Vector<float> zB) {
                var x = YGroup3Unzip(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{double}, out Vector{double}, out Vector{double}, out Vector{double}, out Vector{double}, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup3UnzipX2_X2(Vector<double> data0, Vector<double> data1, Vector<double> data2, Vector<double> data3, Vector<double> data4, Vector<double> data5, out Vector<double> xB, out Vector<double> y, out Vector<double> yB, out Vector<double> z, out Vector<double> zB) {
                var x = YGroup3Unzip(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup3UnzipX2_X2(Vector<sbyte> data0, Vector<sbyte> data1, Vector<sbyte> data2, Vector<sbyte> data3, Vector<sbyte> data4, Vector<sbyte> data5, out Vector<sbyte> xB, out Vector<sbyte> y, out Vector<sbyte> yB, out Vector<sbyte> z, out Vector<sbyte> zB) {
                var x = YGroup3Unzip(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup3UnzipX2_X2(Vector<byte> data0, Vector<byte> data1, Vector<byte> data2, Vector<byte> data3, Vector<byte> data4, Vector<byte> data5, out Vector<byte> xB, out Vector<byte> y, out Vector<byte> yB, out Vector<byte> z, out Vector<byte> zB) {
                var x = YGroup3Unzip(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup3UnzipX2_X2(Vector<short> data0, Vector<short> data1, Vector<short> data2, Vector<short> data3, Vector<short> data4, Vector<short> data5, out Vector<short> xB, out Vector<short> y, out Vector<short> yB, out Vector<short> z, out Vector<short> zB) {
                var x = YGroup3Unzip(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup3UnzipX2_X2(Vector<ushort> data0, Vector<ushort> data1, Vector<ushort> data2, Vector<ushort> data3, Vector<ushort> data4, Vector<ushort> data5, out Vector<ushort> xB, out Vector<ushort> y, out Vector<ushort> yB, out Vector<ushort> z, out Vector<ushort> zB) {
                var x = YGroup3Unzip(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup3UnzipX2_X2(Vector<int> data0, Vector<int> data1, Vector<int> data2, Vector<int> data3, Vector<int> data4, Vector<int> data5, out Vector<int> xB, out Vector<int> y, out Vector<int> yB, out Vector<int> z, out Vector<int> zB) {
                var x = YGroup3Unzip(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup3UnzipX2_X2(Vector<uint> data0, Vector<uint> data1, Vector<uint> data2, Vector<uint> data3, Vector<uint> data4, Vector<uint> data5, out Vector<uint> xB, out Vector<uint> y, out Vector<uint> yB, out Vector<uint> z, out Vector<uint> zB) {
                var x = YGroup3Unzip(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup3UnzipX2_X2(Vector<long> data0, Vector<long> data1, Vector<long> data2, Vector<long> data3, Vector<long> data4, Vector<long> data5, out Vector<long> xB, out Vector<long> y, out Vector<long> yB, out Vector<long> z, out Vector<long> zB) {
                var x = YGroup3Unzip(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup3UnzipX2_X2(Vector<ulong> data0, Vector<ulong> data1, Vector<ulong> data2, Vector<ulong> data3, Vector<ulong> data4, Vector<ulong> data5, out Vector<ulong> xB, out Vector<ulong> y, out Vector<ulong> yB, out Vector<ulong> z, out Vector<ulong> zB) {
                var x = YGroup3Unzip(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip(data3, data4, data5, out yB, out zB);
                return x;
            }

#if VECTOR_HAS_METHOD

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup3UnzipX2_Zip(Vector<float> data0, Vector<float> data1, Vector<float> data2, Vector<float> data3, Vector<float> data4, Vector<float> data5, out Vector<float> xB, out Vector<float> y, out Vector<float> yB, out Vector<float> z, out Vector<float> zB) {
                var d0 = YGroup3UnzipX2_Zip(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), data4.AsUInt32(), data5.AsUInt32(), out var d1, out var d2, out var d3, out var d4, out var d5);
                xB = d1.AsSingle();
                y = d2.AsSingle();
                yB = d3.AsSingle();
                z = d4.AsSingle();
                zB = d5.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup3UnzipX2_Zip(Vector<sbyte> data0, Vector<sbyte> data1, Vector<sbyte> data2, Vector<sbyte> data3, Vector<sbyte> data4, Vector<sbyte> data5, out Vector<sbyte> xB, out Vector<sbyte> y, out Vector<sbyte> yB, out Vector<sbyte> z, out Vector<sbyte> zB) {
                var d0 = YGroup3UnzipX2_Zip(data0.AsByte(), data1.AsByte(), data2.AsByte(), data3.AsByte(), data4.AsByte(), data5.AsByte(), out var d1, out var d2, out var d3, out var d4, out var d5);
                xB = d1.AsSByte();
                y = d2.AsSByte();
                yB = d3.AsSByte();
                z = d4.AsSByte();
                zB = d5.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup3UnzipX2_Zip(Vector<byte> data0, Vector<byte> data1, Vector<byte> data2, Vector<byte> data3, Vector<byte> data4, Vector<byte> data5, out Vector<byte> xB, out Vector<byte> y, out Vector<byte> yB, out Vector<byte> z, out Vector<byte> zB) {
                Vector<byte> a_0, a_1, a_2, a_3, a_4, a_5, b_0, b_1, b_2, b_3, b_4, b_5;
                int cnt = Vector<byte>.Count;
                a_0 = data0;
                a_1 = data1;
                a_2 = data2;
                a_3 = data3;
                a_4 = data4;
                a_5 = data5;
                do {
                    // Step 1.
                    b_0 = YGroup2Zip(a_0, a_3, out b_1);
                    b_2 = YGroup2Zip(a_1, a_4, out b_3);
                    b_4 = YGroup2Zip(a_2, a_5, out b_5);
                    // Step 2.
                    a_0 = YGroup2Zip(b_0, b_3, out a_1);
                    a_2 = YGroup2Zip(b_1, b_4, out a_3);
                    a_4 = YGroup2Zip(b_2, b_5, out a_5);
                    // Next.
                    cnt >>= 2;
                } while (cnt >= 2);
                if (0 == cnt) {
                    xB = a_1;
                    y = a_2;
                    yB = a_3;
                    z = a_4;
                    zB = a_5;
                    return a_0;
                }
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

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup3UnzipX2_Zip(Vector<short> data0, Vector<short> data1, Vector<short> data2, Vector<short> data3, Vector<short> data4, Vector<short> data5, out Vector<short> xB, out Vector<short> y, out Vector<short> yB, out Vector<short> z, out Vector<short> zB) {
                var d0 = YGroup3UnzipX2_Zip(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), data3.AsUInt16(), data4.AsUInt16(), data5.AsUInt16(), out var d1, out var d2, out var d3, out var d4, out var d5);
                xB = d1.AsInt16();
                y = d2.AsInt16();
                yB = d3.AsInt16();
                z = d4.AsInt16();
                zB = d5.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup3UnzipX2_Zip(Vector<ushort> data0, Vector<ushort> data1, Vector<ushort> data2, Vector<ushort> data3, Vector<ushort> data4, Vector<ushort> data5, out Vector<ushort> xB, out Vector<ushort> y, out Vector<ushort> yB, out Vector<ushort> z, out Vector<ushort> zB) {
                Vector<ushort> a_0, a_1, a_2, a_3, a_4, a_5, b_0, b_1, b_2, b_3, b_4, b_5;
                int cnt = Vector<ushort>.Count;
                a_0 = data0;
                a_1 = data1;
                a_2 = data2;
                a_3 = data3;
                a_4 = data4;
                a_5 = data5;
                do {
                    // Step 1.
                    b_0 = YGroup2Zip(a_0, a_3, out b_1);
                    b_2 = YGroup2Zip(a_1, a_4, out b_3);
                    b_4 = YGroup2Zip(a_2, a_5, out b_5);
                    // Step 2.
                    a_0 = YGroup2Zip(b_0, b_3, out a_1);
                    a_2 = YGroup2Zip(b_1, b_4, out a_3);
                    a_4 = YGroup2Zip(b_2, b_5, out a_5);
                    // Next.
                    cnt >>= 2;
                } while (cnt >= 2);
                if (0 == cnt) {
                    xB = a_1;
                    y = a_2;
                    yB = a_3;
                    z = a_4;
                    zB = a_5;
                    return a_0;
                }
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

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup3UnzipX2_Zip(Vector<int> data0, Vector<int> data1, Vector<int> data2, Vector<int> data3, Vector<int> data4, Vector<int> data5, out Vector<int> xB, out Vector<int> y, out Vector<int> yB, out Vector<int> z, out Vector<int> zB) {
                var d0 = YGroup3UnzipX2_Zip(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), data4.AsUInt32(), data5.AsUInt32(), out var d1, out var d2, out var d3, out var d4, out var d5);
                xB = d1.AsInt32();
                y = d2.AsInt32();
                yB = d3.AsInt32();
                z = d4.AsInt32();
                zB = d5.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup3UnzipX2_Zip(Vector<uint> data0, Vector<uint> data1, Vector<uint> data2, Vector<uint> data3, Vector<uint> data4, Vector<uint> data5, out Vector<uint> xB, out Vector<uint> y, out Vector<uint> yB, out Vector<uint> z, out Vector<uint> zB) {
                Vector<uint> a_0, a_1, a_2, a_3, a_4, a_5, b_0, b_1, b_2, b_3, b_4, b_5;
                int cnt = Vector<uint>.Count;
                a_0 = data0;
                a_1 = data1;
                a_2 = data2;
                a_3 = data3;
                a_4 = data4;
                a_5 = data5;
                do {
                    // Step 1.
                    b_0 = YGroup2Zip(a_0, a_3, out b_1);
                    b_2 = YGroup2Zip(a_1, a_4, out b_3);
                    b_4 = YGroup2Zip(a_2, a_5, out b_5);
                    // Step 2.
                    a_0 = YGroup2Zip(b_0, b_3, out a_1);
                    a_2 = YGroup2Zip(b_1, b_4, out a_3);
                    a_4 = YGroup2Zip(b_2, b_5, out a_5);
                    // Next.
                    cnt >>= 2;
                } while (cnt >= 2);
                if (0 == cnt) {
                    xB = a_1;
                    y = a_2;
                    yB = a_3;
                    z = a_4;
                    zB = a_5;
                    return a_0;
                }
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


            /// <inheritdoc cref="IVectorTraits.YGroup3Zip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup3Zip_AcceleratedTypes {
                get {
#if NET8_0_OR_GREATER
                    if (RuntimeInformation.ProcessArchitecture == Architecture.Wasm) {
                        return TypeCodeFlags.None;
                    }
#endif // NET8_0_OR_GREATER
                    return YGroup2Unzip_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup3Zip(Vector<float> x, Vector<float> y, Vector<float> z, out Vector<float> data1, out Vector<float> data2) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD && BCL_HAS_SHIFT
                if (Vector.IsHardwareAccelerated) {
                    return YGroup3Zip_ByX2Unzip(x, y, z, out data1, out data2);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup3Zip_Basic(x, y, z, out data1, out data2);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{double}, Vector{double}, Vector{double}, out Vector{double}, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup3Zip(Vector<double> x, Vector<double> y, Vector<double> z, out Vector<double> data1, out Vector<double> data2) {
                return YGroup3Zip_Basic(x, y, z, out data1, out data2);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup3Zip(Vector<sbyte> x, Vector<sbyte> y, Vector<sbyte> z, out Vector<sbyte> data1, out Vector<sbyte> data2) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD && BCL_HAS_SHIFT
                if (Vector.IsHardwareAccelerated) {
                    return YGroup3Zip_ByX2Unzip(x, y, z, out data1, out data2);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup3Zip_Basic(x, y, z, out data1, out data2);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup3Zip(Vector<byte> x, Vector<byte> y, Vector<byte> z, out Vector<byte> data1, out Vector<byte> data2) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD && BCL_HAS_SHIFT
                if (Vector.IsHardwareAccelerated) {
                    return YGroup3Zip_ByX2Unzip(x, y, z, out data1, out data2);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup3Zip_Basic(x, y, z, out data1, out data2);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{short}, Vector{short}, Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup3Zip(Vector<short> x, Vector<short> y, Vector<short> z, out Vector<short> data1, out Vector<short> data2) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD && BCL_HAS_SHIFT
                if (Vector.IsHardwareAccelerated) {
                    return YGroup3Zip_ByX2Unzip(x, y, z, out data1, out data2);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup3Zip_Basic(x, y, z, out data1, out data2);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{ushort}, Vector{ushort}, Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup3Zip(Vector<ushort> x, Vector<ushort> y, Vector<ushort> z, out Vector<ushort> data1, out Vector<ushort> data2) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD && BCL_HAS_SHIFT
                if (Vector.IsHardwareAccelerated) {
                    return YGroup3Zip_ByX2Unzip(x, y, z, out data1, out data2);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup3Zip_Basic(x, y, z, out data1, out data2);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{int}, Vector{int}, Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup3Zip(Vector<int> x, Vector<int> y, Vector<int> z, out Vector<int> data1, out Vector<int> data2) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD && BCL_HAS_SHIFT
                if (Vector.IsHardwareAccelerated) {
                    return YGroup3Zip_ByX2Unzip(x, y, z, out data1, out data2);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup3Zip_Basic(x, y, z, out data1, out data2);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{uint}, Vector{uint}, Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup3Zip(Vector<uint> x, Vector<uint> y, Vector<uint> z, out Vector<uint> data1, out Vector<uint> data2) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD && BCL_HAS_SHIFT
                if (Vector.IsHardwareAccelerated) {
                    return YGroup3Zip_ByX2Unzip(x, y, z, out data1, out data2);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup3Zip_Basic(x, y, z, out data1, out data2);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{long}, Vector{long}, Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup3Zip(Vector<long> x, Vector<long> y, Vector<long> z, out Vector<long> data1, out Vector<long> data2) {
                return YGroup3Zip_Basic(x, y, z, out data1, out data2);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{ulong}, Vector{ulong}, Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup3Zip(Vector<ulong> x, Vector<ulong> y, Vector<ulong> z, out Vector<ulong> data1, out Vector<ulong> data2) {
                return YGroup3Zip_Basic(x, y, z, out data1, out data2);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Zip_Bit128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<T> YGroup3Zip_Bit128<T>(Vector<T> x, Vector<T> y, Vector<T> z, out Vector<T> data1, out Vector<T> data2) where T : struct {
                var d0 = YGroup3Zip_Basic(x.ExAsExUInt128(), y.ExAsExUInt128(), z.ExAsExUInt128(), out var d1, out var d2);
                data1 = d1.ExAs<ExUInt128, T>();
                data2 = d2.ExAs<ExUInt128, T>();
                return d0.ExAs<ExUInt128, T>();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup3Zip_Basic(Vector<float> x, Vector<float> y, Vector<float> z, out Vector<float> data1, out Vector<float> data2) {
                var d0 = YGroup3Zip_Basic(x.AsUInt32(), y.AsUInt32(), z.AsUInt32(), out var d1, out var d2);
                data1 = d1.AsSingle();
                data2 = d2.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{double}, Vector{double}, Vector{double}, out Vector{double}, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup3Zip_Basic(Vector<double> x, Vector<double> y, Vector<double> z, out Vector<double> data1, out Vector<double> data2) {
                var d0 = YGroup3Zip_Basic(x.AsUInt64(), y.AsUInt64(), z.AsUInt64(), out var d1, out var d2);
                data1 = d1.AsDouble();
                data2 = d2.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup3Zip_Basic(Vector<sbyte> x, Vector<sbyte> y, Vector<sbyte> z, out Vector<sbyte> data1, out Vector<sbyte> data2) {
                var d0 = YGroup3Zip_Basic(x.AsByte(), y.AsByte(), z.AsByte(), out var d1, out var d2);
                data1 = d1.AsSByte();
                data2 = d2.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup3Zip_Basic(Vector<byte> x, Vector<byte> y, Vector<byte> z, out Vector<byte> data1, out Vector<byte> data2) {
                Span<Vector<byte>> rt = stackalloc Vector<byte>[3];
                ref byte px = ref Unsafe.As<Vector<byte>, byte>(ref x);
                ref byte py = ref Unsafe.As<Vector<byte>, byte>(ref y);
                ref byte pz = ref Unsafe.As<Vector<byte>, byte>(ref z);
                Span<byte> q = MemoryMarshal.Cast<Vector<byte>, byte>(rt);
                int idx = 0;
                for (int i = 0; i < Vector<byte>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    q[idx + 2] = Unsafe.Add(ref pz, i);
                    idx += 3;
                }
                data1 = rt[1];
                data2 = rt[2];
                return rt[0];
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{short}, Vector{short}, Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup3Zip_Basic(Vector<short> x, Vector<short> y, Vector<short> z, out Vector<short> data1, out Vector<short> data2) {
                var d0 = YGroup3Zip_Basic(x.AsUInt16(), y.AsUInt16(), z.AsUInt16(), out var d1, out var d2);
                data1 = d1.AsInt16();
                data2 = d2.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{ushort}, Vector{ushort}, Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup3Zip_Basic(Vector<ushort> x, Vector<ushort> y, Vector<ushort> z, out Vector<ushort> data1, out Vector<ushort> data2) {
                Span<Vector<ushort>> rt = stackalloc Vector<ushort>[3];
                ref ushort px = ref Unsafe.As<Vector<ushort>, ushort>(ref x);
                ref ushort py = ref Unsafe.As<Vector<ushort>, ushort>(ref y);
                ref ushort pz = ref Unsafe.As<Vector<ushort>, ushort>(ref z);
                Span<ushort> q = MemoryMarshal.Cast<Vector<ushort>, ushort>(rt);
                int idx = 0;
                for (int i = 0; i < Vector<ushort>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    q[idx + 2] = Unsafe.Add(ref pz, i);
                    idx += 3;
                }
                data1 = rt[1];
                data2 = rt[2];
                return rt[0];
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{int}, Vector{int}, Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup3Zip_Basic(Vector<int> x, Vector<int> y, Vector<int> z, out Vector<int> data1, out Vector<int> data2) {
                var d0 = YGroup3Zip_Basic(x.AsUInt32(), y.AsUInt32(), z.AsUInt32(), out var d1, out var d2);
                data1 = d1.AsInt32();
                data2 = d2.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{uint}, Vector{uint}, Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup3Zip_Basic(Vector<uint> x, Vector<uint> y, Vector<uint> z, out Vector<uint> data1, out Vector<uint> data2) {
                Span<Vector<uint>> rt = stackalloc Vector<uint>[3];
                ref uint px = ref Unsafe.As<Vector<uint>, uint>(ref x);
                ref uint py = ref Unsafe.As<Vector<uint>, uint>(ref y);
                ref uint pz = ref Unsafe.As<Vector<uint>, uint>(ref z);
                Span<uint> q = MemoryMarshal.Cast<Vector<uint>, uint>(rt);
                int idx = 0;
                for (int i = 0; i < Vector<uint>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    q[idx + 2] = Unsafe.Add(ref pz, i);
                    idx += 3;
                }
                data1 = rt[1];
                data2 = rt[2];
                return rt[0];
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{long}, Vector{long}, Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup3Zip_Basic(Vector<long> x, Vector<long> y, Vector<long> z, out Vector<long> data1, out Vector<long> data2) {
                var d0 = YGroup3Zip_Basic(x.AsUInt64(), y.AsUInt64(), z.AsUInt64(), out var d1, out var d2);
                data1 = d1.AsInt64();
                data2 = d2.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{ulong}, Vector{ulong}, Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup3Zip_Basic(Vector<ulong> x, Vector<ulong> y, Vector<ulong> z, out Vector<ulong> data1, out Vector<ulong> data2) {
                Span<Vector<ulong>> rt = stackalloc Vector<ulong>[3];
                ref ulong px = ref Unsafe.As<Vector<ulong>, ulong>(ref x);
                ref ulong py = ref Unsafe.As<Vector<ulong>, ulong>(ref y);
                ref ulong pz = ref Unsafe.As<Vector<ulong>, ulong>(ref z);
                Span<ulong> q = MemoryMarshal.Cast<Vector<ulong>, ulong>(rt);
                int idx = 0;
                for (int i = 0; i < Vector<ulong>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    q[idx + 2] = Unsafe.Add(ref pz, i);
                    idx += 3;
                }
                data1 = rt[1];
                data2 = rt[2];
                return rt[0];
            }

            // / <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{ExInt128}, Vector{ExInt128}, Vector{ExInt128}, out Vector{ExInt128}, out Vector{ExInt128})"/>
            /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{long}, Vector{long}, Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExInt128> YGroup3Zip_Basic(Vector<ExInt128> x, Vector<ExInt128> y, Vector<ExInt128> z, out Vector<ExInt128> data1, out Vector<ExInt128> data2) {
                var d0 = YGroup3Zip_Basic(x.ExAsExUInt128(), y.ExAsExUInt128(), z.ExAsExUInt128(), out var d1, out var d2);
                data1 = d1.ExAsExInt128();
                data2 = d2.ExAsExInt128();
                return d0.ExAsExInt128();
            }

            // / <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{ExUInt128}, Vector{ExUInt128}, Vector{ExUInt128}, out Vector{ExUInt128}, out Vector{ExUInt128})"/>
            /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{long}, Vector{long}, Vector{long}, out Vector{long}, out Vector{long})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExUInt128> YGroup3Zip_Basic(Vector<ExUInt128> x, Vector<ExUInt128> y, Vector<ExUInt128> z, out Vector<ExUInt128> data1, out Vector<ExUInt128> data2) {
                Span<Vector<ExUInt128>> rt = stackalloc Vector<ExUInt128>[3];
                ref ExUInt128 px = ref Unsafe.As<Vector<ExUInt128>, ExUInt128>(ref x);
                ref ExUInt128 py = ref Unsafe.As<Vector<ExUInt128>, ExUInt128>(ref y);
                ref ExUInt128 pz = ref Unsafe.As<Vector<ExUInt128>, ExUInt128>(ref z);
                Span<ExUInt128> q = MemoryMarshal.Cast<Vector<ExUInt128>, ExUInt128>(rt);
                int idx = 0;
                for (int i = 0; i < Vectors<ExUInt128>.Count; ++i) {
                    q[idx] = Unsafe.Add(ref px, i);
                    q[idx + 1] = Unsafe.Add(ref py, i);
                    q[idx + 2] = Unsafe.Add(ref pz, i);
                    idx += 3;
                }
                data1 = rt[1];
                data2 = rt[2];
                return rt[0];
            }

#if VECTOR_HAS_METHOD

            /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup3Zip_ByX2Unzip(Vector<float> x, Vector<float> y, Vector<float> z, out Vector<float> data1, out Vector<float> data2) {
                return YGroup3ZipX2_Unzip(x, x, y, y, z, z, out data1, out data2, out _, out _, out _);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup3Zip_ByX2Unzip(Vector<sbyte> x, Vector<sbyte> y, Vector<sbyte> z, out Vector<sbyte> data1, out Vector<sbyte> data2) {
                return YGroup3ZipX2_Unzip(x, x, y, y, z, z, out data1, out data2, out _, out _, out _);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup3Zip_ByX2Unzip(Vector<byte> x, Vector<byte> y, Vector<byte> z, out Vector<byte> data1, out Vector<byte> data2) {
                return YGroup3ZipX2_Unzip(x, x, y, y, z, z, out data1, out data2, out _, out _, out _);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{short}, Vector{short}, Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup3Zip_ByX2Unzip(Vector<short> x, Vector<short> y, Vector<short> z, out Vector<short> data1, out Vector<short> data2) {
                return YGroup3ZipX2_Unzip(x, x, y, y, z, z, out data1, out data2, out _, out _, out _);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{ushort}, Vector{ushort}, Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup3Zip_ByX2Unzip(Vector<ushort> x, Vector<ushort> y, Vector<ushort> z, out Vector<ushort> data1, out Vector<ushort> data2) {
                return YGroup3ZipX2_Unzip(x, x, y, y, z, z, out data1, out data2, out _, out _, out _);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{int}, Vector{int}, Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup3Zip_ByX2Unzip(Vector<int> x, Vector<int> y, Vector<int> z, out Vector<int> data1, out Vector<int> data2) {
                return YGroup3ZipX2_Unzip(x, x, y, y, z, z, out data1, out data2, out _, out _, out _);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{uint}, Vector{uint}, Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup3Zip_ByX2Unzip(Vector<uint> x, Vector<uint> y, Vector<uint> z, out Vector<uint> data1, out Vector<uint> data2) {
                return YGroup3ZipX2_Unzip(x, x, y, y, z, z, out data1, out data2, out _, out _, out _);
            }

#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup3ZipX2_AcceleratedTypes {
                get {
#if NET8_0_OR_GREATER
                    if (RuntimeInformation.ProcessArchitecture == Architecture.Wasm) {
                        return TypeCodeFlags.None;
                    }
#endif // NET8_0_OR_GREATER
                    return YGroup2Zip_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup3ZipX2(Vector<float> x, Vector<float> xB, Vector<float> y, Vector<float> yB, Vector<float> z, Vector<float> zB, out Vector<float> data1, out Vector<float> data2, out Vector<float> data3, out Vector<float> data4, out Vector<float> data5) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD && BCL_HAS_SHIFT
                if (Vector.IsHardwareAccelerated) {
                    return YGroup3ZipX2_Unzip(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD && BCL_HAS_SHIFT
                return YGroup3ZipX2_X2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{double}, out Vector{double}, out Vector{double}, out Vector{double}, out Vector{double}, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup3ZipX2(Vector<double> x, Vector<double> xB, Vector<double> y, Vector<double> yB, Vector<double> z, Vector<double> zB, out Vector<double> data1, out Vector<double> data2, out Vector<double> data3, out Vector<double> data4, out Vector<double> data5) {
                return YGroup3ZipX2_X2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup3ZipX2(Vector<sbyte> x, Vector<sbyte> xB, Vector<sbyte> y, Vector<sbyte> yB, Vector<sbyte> z, Vector<sbyte> zB, out Vector<sbyte> data1, out Vector<sbyte> data2, out Vector<sbyte> data3, out Vector<sbyte> data4, out Vector<sbyte> data5) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup3ZipX2_Unzip(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup3ZipX2_X2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup3ZipX2(Vector<byte> x, Vector<byte> xB, Vector<byte> y, Vector<byte> yB, Vector<byte> z, Vector<byte> zB, out Vector<byte> data1, out Vector<byte> data2, out Vector<byte> data3, out Vector<byte> data4, out Vector<byte> data5) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup3ZipX2_Unzip(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup3ZipX2_X2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup3ZipX2(Vector<short> x, Vector<short> xB, Vector<short> y, Vector<short> yB, Vector<short> z, Vector<short> zB, out Vector<short> data1, out Vector<short> data2, out Vector<short> data3, out Vector<short> data4, out Vector<short> data5) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD && BCL_HAS_SHIFT
                if (Vector.IsHardwareAccelerated) {
                    return YGroup3ZipX2_Unzip(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD && BCL_HAS_SHIFT
                return YGroup3ZipX2_X2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup3ZipX2(Vector<ushort> x, Vector<ushort> xB, Vector<ushort> y, Vector<ushort> yB, Vector<ushort> z, Vector<ushort> zB, out Vector<ushort> data1, out Vector<ushort> data2, out Vector<ushort> data3, out Vector<ushort> data4, out Vector<ushort> data5) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD && BCL_HAS_SHIFT
                if (Vector.IsHardwareAccelerated) {
                    return YGroup3ZipX2_Unzip(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD && BCL_HAS_SHIFT
                return YGroup3ZipX2_X2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup3ZipX2(Vector<int> x, Vector<int> xB, Vector<int> y, Vector<int> yB, Vector<int> z, Vector<int> zB, out Vector<int> data1, out Vector<int> data2, out Vector<int> data3, out Vector<int> data4, out Vector<int> data5) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD && BCL_HAS_SHIFT
                if (Vector.IsHardwareAccelerated) {
                    return YGroup3ZipX2_Unzip(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD && BCL_HAS_SHIFT
                return YGroup3ZipX2_X2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup3ZipX2(Vector<uint> x, Vector<uint> xB, Vector<uint> y, Vector<uint> yB, Vector<uint> z, Vector<uint> zB, out Vector<uint> data1, out Vector<uint> data2, out Vector<uint> data3, out Vector<uint> data4, out Vector<uint> data5) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD && BCL_HAS_SHIFT
                if (Vector.IsHardwareAccelerated) {
                    return YGroup3ZipX2_Unzip(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD && BCL_HAS_SHIFT
                return YGroup3ZipX2_X2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup3ZipX2(Vector<long> x, Vector<long> xB, Vector<long> y, Vector<long> yB, Vector<long> z, Vector<long> zB, out Vector<long> data1, out Vector<long> data2, out Vector<long> data3, out Vector<long> data4, out Vector<long> data5) {
                return YGroup3ZipX2_X2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup3ZipX2(Vector<ulong> x, Vector<ulong> xB, Vector<ulong> y, Vector<ulong> yB, Vector<ulong> z, Vector<ulong> zB, out Vector<ulong> data1, out Vector<ulong> data2, out Vector<ulong> data3, out Vector<ulong> data4, out Vector<ulong> data5) {
                return YGroup3ZipX2_X2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2_Bit128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<T> YGroup3ZipX2_Bit128<T>(Vector<T> x, Vector<T> xB, Vector<T> y, Vector<T> yB, Vector<T> z, Vector<T> zB, out Vector<T> data1, out Vector<T> data2, out Vector<T> data3, out Vector<T> data4, out Vector<T> data5) where T : struct {
                var data0 = YGroup3Zip_Bit128(x, y, z, out data1, out data2);
                data3 = YGroup3Zip_Bit128(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2_Basic(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup3ZipX2_Basic(Vector<float> x, Vector<float> xB, Vector<float> y, Vector<float> yB, Vector<float> z, Vector<float> zB, out Vector<float> data1, out Vector<float> data2, out Vector<float> data3, out Vector<float> data4, out Vector<float> data5) {
                var data0 = YGroup3Zip_Basic(x, y, z, out data1, out data2);
                data3 = YGroup3Zip_Basic(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2_Basic(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{double}, out Vector{double}, out Vector{double}, out Vector{double}, out Vector{double}, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup3ZipX2_Basic(Vector<double> x, Vector<double> xB, Vector<double> y, Vector<double> yB, Vector<double> z, Vector<double> zB, out Vector<double> data1, out Vector<double> data2, out Vector<double> data3, out Vector<double> data4, out Vector<double> data5) {
                var data0 = YGroup3Zip_Basic(x, y, z, out data1, out data2);
                data3 = YGroup3Zip_Basic(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2_Basic(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup3ZipX2_Basic(Vector<sbyte> x, Vector<sbyte> xB, Vector<sbyte> y, Vector<sbyte> yB, Vector<sbyte> z, Vector<sbyte> zB, out Vector<sbyte> data1, out Vector<sbyte> data2, out Vector<sbyte> data3, out Vector<sbyte> data4, out Vector<sbyte> data5) {
                var data0 = YGroup3Zip_Basic(x, y, z, out data1, out data2);
                data3 = YGroup3Zip_Basic(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2_Basic(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup3ZipX2_Basic(Vector<byte> x, Vector<byte> xB, Vector<byte> y, Vector<byte> yB, Vector<byte> z, Vector<byte> zB, out Vector<byte> data1, out Vector<byte> data2, out Vector<byte> data3, out Vector<byte> data4, out Vector<byte> data5) {
                var data0 = YGroup3Zip_Basic(x, y, z, out data1, out data2);
                data3 = YGroup3Zip_Basic(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2_Basic(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup3ZipX2_Basic(Vector<short> x, Vector<short> xB, Vector<short> y, Vector<short> yB, Vector<short> z, Vector<short> zB, out Vector<short> data1, out Vector<short> data2, out Vector<short> data3, out Vector<short> data4, out Vector<short> data5) {
                var data0 = YGroup3Zip_Basic(x, y, z, out data1, out data2);
                data3 = YGroup3Zip_Basic(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2_Basic(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup3ZipX2_Basic(Vector<ushort> x, Vector<ushort> xB, Vector<ushort> y, Vector<ushort> yB, Vector<ushort> z, Vector<ushort> zB, out Vector<ushort> data1, out Vector<ushort> data2, out Vector<ushort> data3, out Vector<ushort> data4, out Vector<ushort> data5) {
                var data0 = YGroup3Zip_Basic(x, y, z, out data1, out data2);
                data3 = YGroup3Zip_Basic(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2_Basic(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup3ZipX2_Basic(Vector<int> x, Vector<int> xB, Vector<int> y, Vector<int> yB, Vector<int> z, Vector<int> zB, out Vector<int> data1, out Vector<int> data2, out Vector<int> data3, out Vector<int> data4, out Vector<int> data5) {
                var data0 = YGroup3Zip_Basic(x, y, z, out data1, out data2);
                data3 = YGroup3Zip_Basic(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2_Basic(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup3ZipX2_Basic(Vector<uint> x, Vector<uint> xB, Vector<uint> y, Vector<uint> yB, Vector<uint> z, Vector<uint> zB, out Vector<uint> data1, out Vector<uint> data2, out Vector<uint> data3, out Vector<uint> data4, out Vector<uint> data5) {
                var data0 = YGroup3Zip_Basic(x, y, z, out data1, out data2);
                data3 = YGroup3Zip_Basic(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2_Basic(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup3ZipX2_Basic(Vector<long> x, Vector<long> xB, Vector<long> y, Vector<long> yB, Vector<long> z, Vector<long> zB, out Vector<long> data1, out Vector<long> data2, out Vector<long> data3, out Vector<long> data4, out Vector<long> data5) {
                var data0 = YGroup3Zip_Basic(x, y, z, out data1, out data2);
                data3 = YGroup3Zip_Basic(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2_Basic(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup3ZipX2_Basic(Vector<ulong> x, Vector<ulong> xB, Vector<ulong> y, Vector<ulong> yB, Vector<ulong> z, Vector<ulong> zB, out Vector<ulong> data1, out Vector<ulong> data2, out Vector<ulong> data3, out Vector<ulong> data4, out Vector<ulong> data5) {
                var data0 = YGroup3Zip_Basic(x, y, z, out data1, out data2);
                data3 = YGroup3Zip_Basic(xB, yB, zB, out data4, out data5);
                return data0;
            }

#if VECTOR_HAS_METHOD

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2_Unzip(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup3ZipX2_Unzip(Vector<float> x, Vector<float> xB, Vector<float> y, Vector<float> yB, Vector<float> z, Vector<float> zB, out Vector<float> data1, out Vector<float> data2, out Vector<float> data3, out Vector<float> data4, out Vector<float> data5) {
                var d0 = YGroup3ZipX2_Unzip(x.AsUInt32(), xB.AsUInt32(), y.AsUInt32(), yB.AsUInt32(), z.AsUInt32(), zB.AsUInt32(), out var d1, out var d2, out var d3, out var d4, out var d5);
                data1 = d1.AsSingle();
                data2 = d2.AsSingle();
                data3 = d3.AsSingle();
                data4 = d4.AsSingle();
                data5 = d5.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2_Unzip(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup3ZipX2_Unzip(Vector<sbyte> x, Vector<sbyte> xB, Vector<sbyte> y, Vector<sbyte> yB, Vector<sbyte> z, Vector<sbyte> zB, out Vector<sbyte> data1, out Vector<sbyte> data2, out Vector<sbyte> data3, out Vector<sbyte> data4, out Vector<sbyte> data5) {
                var d0 = YGroup3ZipX2_Unzip(x.AsByte(), xB.AsByte(), y.AsByte(), yB.AsByte(), z.AsByte(), zB.AsByte(), out var d1, out var d2, out var d3, out var d4, out var d5);
                data1 = d1.AsSByte();
                data2 = d2.AsSByte();
                data3 = d3.AsSByte();
                data4 = d4.AsSByte();
                data5 = d5.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2_Unzip(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup3ZipX2_Unzip(Vector<byte> x, Vector<byte> xB, Vector<byte> y, Vector<byte> yB, Vector<byte> z, Vector<byte> zB, out Vector<byte> data1, out Vector<byte> data2, out Vector<byte> data3, out Vector<byte> data4, out Vector<byte> data5) {
                Vector<byte> a_0, a_1, a_2, a_3, a_4, a_5, b_0, b_1, b_2, b_3, b_4, b_5;
                int cnt = Vector<byte>.Count;
                a_0 = x;
                a_1 = xB;
                a_2 = y;
                a_3 = yB;
                a_4 = z;
                a_5 = zB;
                do {
                    // Step 1.
                    b_0 = YGroup2Unzip(a_0, a_1, out b_3);
                    b_1 = YGroup2Unzip(a_2, a_3, out b_4);
                    b_2 = YGroup2Unzip(a_4, a_5, out b_5);
                    // Step 2.
                    a_0 = YGroup2Unzip(b_0, b_1, out a_3);
                    a_1 = YGroup2Unzip(b_2, b_3, out a_4);
                    a_2 = YGroup2Unzip(b_4, b_5, out a_5);
                    // Next.
                    cnt >>= 2;
                } while (cnt >= 2);
                if (0 == cnt) {
                    data1 = a_1;
                    data2 = a_2;
                    data3 = a_3;
                    data4 = a_4;
                    data5 = a_5;
                    return a_0;
                }
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

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2_Unzip(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup3ZipX2_Unzip(Vector<short> x, Vector<short> xB, Vector<short> y, Vector<short> yB, Vector<short> z, Vector<short> zB, out Vector<short> data1, out Vector<short> data2, out Vector<short> data3, out Vector<short> data4, out Vector<short> data5) {
                var d0 = YGroup3ZipX2_Unzip(x.AsUInt16(), xB.AsUInt16(), y.AsUInt16(), yB.AsUInt16(), z.AsUInt16(), zB.AsUInt16(), out var d1, out var d2, out var d3, out var d4, out var d5);
                data1 = d1.AsInt16();
                data2 = d2.AsInt16();
                data3 = d3.AsInt16();
                data4 = d4.AsInt16();
                data5 = d5.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2_Unzip(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup3ZipX2_Unzip(Vector<ushort> x, Vector<ushort> xB, Vector<ushort> y, Vector<ushort> yB, Vector<ushort> z, Vector<ushort> zB, out Vector<ushort> data1, out Vector<ushort> data2, out Vector<ushort> data3, out Vector<ushort> data4, out Vector<ushort> data5) {
                Vector<ushort> a_0, a_1, a_2, a_3, a_4, a_5, b_0, b_1, b_2, b_3, b_4, b_5;
                int cnt = Vector<ushort>.Count;
                a_0 = x;
                a_1 = xB;
                a_2 = y;
                a_3 = yB;
                a_4 = z;
                a_5 = zB;
                do {
                    // Step 1.
                    b_0 = YGroup2Unzip(a_0, a_1, out b_3);
                    b_1 = YGroup2Unzip(a_2, a_3, out b_4);
                    b_2 = YGroup2Unzip(a_4, a_5, out b_5);
                    // Step 2.
                    a_0 = YGroup2Unzip(b_0, b_1, out a_3);
                    a_1 = YGroup2Unzip(b_2, b_3, out a_4);
                    a_2 = YGroup2Unzip(b_4, b_5, out a_5);
                    // Next.
                    cnt >>= 2;
                } while (cnt >= 2);
                if (0 == cnt) {
                    data1 = a_1;
                    data2 = a_2;
                    data3 = a_3;
                    data4 = a_4;
                    data5 = a_5;
                    return a_0;
                }
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

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2_Unzip(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup3ZipX2_Unzip(Vector<int> x, Vector<int> xB, Vector<int> y, Vector<int> yB, Vector<int> z, Vector<int> zB, out Vector<int> data1, out Vector<int> data2, out Vector<int> data3, out Vector<int> data4, out Vector<int> data5) {
                var d0 = YGroup3ZipX2_Unzip(x.AsUInt32(), xB.AsUInt32(), y.AsUInt32(), yB.AsUInt32(), z.AsUInt32(), zB.AsUInt32(), out var d1, out var d2, out var d3, out var d4, out var d5);
                data1 = d1.AsInt32();
                data2 = d2.AsInt32();
                data3 = d3.AsInt32();
                data4 = d4.AsInt32();
                data5 = d5.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2_Unzip(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup3ZipX2_Unzip(Vector<uint> x, Vector<uint> xB, Vector<uint> y, Vector<uint> yB, Vector<uint> z, Vector<uint> zB, out Vector<uint> data1, out Vector<uint> data2, out Vector<uint> data3, out Vector<uint> data4, out Vector<uint> data5) {
                Vector<uint> a_0, a_1, a_2, a_3, a_4, a_5, b_0, b_1, b_2, b_3, b_4, b_5;
                int cnt = Vector<uint>.Count;
                a_0 = x;
                a_1 = xB;
                a_2 = y;
                a_3 = yB;
                a_4 = z;
                a_5 = zB;
                do {
                    // Step 1.
                    b_0 = YGroup2Unzip(a_0, a_1, out b_3);
                    b_1 = YGroup2Unzip(a_2, a_3, out b_4);
                    b_2 = YGroup2Unzip(a_4, a_5, out b_5);
                    // Step 2.
                    a_0 = YGroup2Unzip(b_0, b_1, out a_3);
                    a_1 = YGroup2Unzip(b_2, b_3, out a_4);
                    a_2 = YGroup2Unzip(b_4, b_5, out a_5);
                    // Next.
                    cnt >>= 2;
                } while (cnt >= 2);
                if (0 == cnt) {
                    data1 = a_1;
                    data2 = a_2;
                    data3 = a_3;
                    data4 = a_4;
                    data5 = a_5;
                    return a_0;
                }
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

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2_X2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup3ZipX2_X2(Vector<float> x, Vector<float> xB, Vector<float> y, Vector<float> yB, Vector<float> z, Vector<float> zB, out Vector<float> data1, out Vector<float> data2, out Vector<float> data3, out Vector<float> data4, out Vector<float> data5) {
                var data0 = YGroup3Zip(x, y, z, out data1, out data2);
                data3 = YGroup3Zip(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2_X2(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{double}, out Vector{double}, out Vector{double}, out Vector{double}, out Vector{double}, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup3ZipX2_X2(Vector<double> x, Vector<double> xB, Vector<double> y, Vector<double> yB, Vector<double> z, Vector<double> zB, out Vector<double> data1, out Vector<double> data2, out Vector<double> data3, out Vector<double> data4, out Vector<double> data5) {
                var data0 = YGroup3Zip(x, y, z, out data1, out data2);
                data3 = YGroup3Zip(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2_X2(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup3ZipX2_X2(Vector<sbyte> x, Vector<sbyte> xB, Vector<sbyte> y, Vector<sbyte> yB, Vector<sbyte> z, Vector<sbyte> zB, out Vector<sbyte> data1, out Vector<sbyte> data2, out Vector<sbyte> data3, out Vector<sbyte> data4, out Vector<sbyte> data5) {
                var data0 = YGroup3Zip(x, y, z, out data1, out data2);
                data3 = YGroup3Zip(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2_X2(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup3ZipX2_X2(Vector<byte> x, Vector<byte> xB, Vector<byte> y, Vector<byte> yB, Vector<byte> z, Vector<byte> zB, out Vector<byte> data1, out Vector<byte> data2, out Vector<byte> data3, out Vector<byte> data4, out Vector<byte> data5) {
                var data0 = YGroup3Zip(x, y, z, out data1, out data2);
                data3 = YGroup3Zip(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2_X2(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup3ZipX2_X2(Vector<short> x, Vector<short> xB, Vector<short> y, Vector<short> yB, Vector<short> z, Vector<short> zB, out Vector<short> data1, out Vector<short> data2, out Vector<short> data3, out Vector<short> data4, out Vector<short> data5) {
                var data0 = YGroup3Zip(x, y, z, out data1, out data2);
                data3 = YGroup3Zip(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2_X2(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup3ZipX2_X2(Vector<ushort> x, Vector<ushort> xB, Vector<ushort> y, Vector<ushort> yB, Vector<ushort> z, Vector<ushort> zB, out Vector<ushort> data1, out Vector<ushort> data2, out Vector<ushort> data3, out Vector<ushort> data4, out Vector<ushort> data5) {
                var data0 = YGroup3Zip(x, y, z, out data1, out data2);
                data3 = YGroup3Zip(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2_X2(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup3ZipX2_X2(Vector<int> x, Vector<int> xB, Vector<int> y, Vector<int> yB, Vector<int> z, Vector<int> zB, out Vector<int> data1, out Vector<int> data2, out Vector<int> data3, out Vector<int> data4, out Vector<int> data5) {
                var data0 = YGroup3Zip(x, y, z, out data1, out data2);
                data3 = YGroup3Zip(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2_X2(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup3ZipX2_X2(Vector<uint> x, Vector<uint> xB, Vector<uint> y, Vector<uint> yB, Vector<uint> z, Vector<uint> zB, out Vector<uint> data1, out Vector<uint> data2, out Vector<uint> data3, out Vector<uint> data4, out Vector<uint> data5) {
                var data0 = YGroup3Zip(x, y, z, out data1, out data2);
                data3 = YGroup3Zip(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2_X2(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup3ZipX2_X2(Vector<long> x, Vector<long> xB, Vector<long> y, Vector<long> yB, Vector<long> z, Vector<long> zB, out Vector<long> data1, out Vector<long> data2, out Vector<long> data3, out Vector<long> data4, out Vector<long> data5) {
                var data0 = YGroup3Zip(x, y, z, out data1, out data2);
                data3 = YGroup3Zip(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2_X2(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup3ZipX2_X2(Vector<ulong> x, Vector<ulong> xB, Vector<ulong> y, Vector<ulong> yB, Vector<ulong> z, Vector<ulong> zB, out Vector<ulong> data1, out Vector<ulong> data2, out Vector<ulong> data3, out Vector<ulong> data4, out Vector<ulong> data5) {
                var data0 = YGroup3Zip(x, y, z, out data1, out data2);
                data3 = YGroup3Zip(xB, yB, zB, out data4, out data5);
                return data0;
            }


            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup4Unzip_AcceleratedTypes {
                get {
                    return YGroup2Unzip_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup4Unzip(Vector<float> data0, Vector<float> data1, Vector<float> data2, Vector<float> data3, out Vector<float> y, out Vector<float> z, out Vector<float> w) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD && BCL_HAS_SHIFT
                if (Vector.IsHardwareAccelerated) {
                    return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup4Unzip_Basic(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{double}, Vector{double}, Vector{double}, Vector{double}, out Vector{double}, out Vector{double}, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup4Unzip(Vector<double> data0, Vector<double> data1, Vector<double> data2, Vector<double> data3, out Vector<double> y, out Vector<double> z, out Vector<double> w) {
                return YGroup4Unzip_Basic(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup4Unzip(Vector<sbyte> data0, Vector<sbyte> data1, Vector<sbyte> data2, Vector<sbyte> data3, out Vector<sbyte> y, out Vector<sbyte> z, out Vector<sbyte> w) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup4Unzip_Basic(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup4Unzip(Vector<byte> data0, Vector<byte> data1, Vector<byte> data2, Vector<byte> data3, out Vector<byte> y, out Vector<byte> z, out Vector<byte> w) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup4Unzip_Basic(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{short}, Vector{short}, Vector{short}, Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup4Unzip(Vector<short> data0, Vector<short> data1, Vector<short> data2, Vector<short> data3, out Vector<short> y, out Vector<short> z, out Vector<short> w) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup4Unzip_Basic(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup4Unzip(Vector<ushort> data0, Vector<ushort> data1, Vector<ushort> data2, Vector<ushort> data3, out Vector<ushort> y, out Vector<ushort> z, out Vector<ushort> w) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup4Unzip_Basic(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{int}, Vector{int}, Vector{int}, Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup4Unzip(Vector<int> data0, Vector<int> data1, Vector<int> data2, Vector<int> data3, out Vector<int> y, out Vector<int> z, out Vector<int> w) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup4Unzip_Basic(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup4Unzip(Vector<uint> data0, Vector<uint> data1, Vector<uint> data2, Vector<uint> data3, out Vector<uint> y, out Vector<uint> z, out Vector<uint> w) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD && BCL_HAS_SHIFT
                if (Vector.IsHardwareAccelerated) {
                    return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup4Unzip_Basic(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{long}, Vector{long}, Vector{long}, Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup4Unzip(Vector<long> data0, Vector<long> data1, Vector<long> data2, Vector<long> data3, out Vector<long> y, out Vector<long> z, out Vector<long> w) {
                return YGroup4Unzip_Basic(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup4Unzip(Vector<ulong> data0, Vector<ulong> data1, Vector<ulong> data2, Vector<ulong> data3, out Vector<ulong> y, out Vector<ulong> z, out Vector<ulong> w) {
                return YGroup4Unzip_Basic(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{ExInt128}, Vector{ExInt128}, Vector{ExInt128}, Vector{ExInt128}, out Vector{ExInt128}, out Vector{ExInt128}, out Vector{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExInt128> YGroup4Unzip(Vector<ExInt128> data0, Vector<ExInt128> data1, Vector<ExInt128> data2, Vector<ExInt128> data3, out Vector<ExInt128> y, out Vector<ExInt128> z, out Vector<ExInt128> w) {
                return YGroup4Unzip_Basic(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{ExUInt128}, Vector{ExUInt128}, Vector{ExUInt128}, Vector{ExUInt128}, out Vector{ExUInt128}, out Vector{ExUInt128}, out Vector{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExUInt128> YGroup4Unzip(Vector<ExUInt128> data0, Vector<ExUInt128> data1, Vector<ExUInt128> data2, Vector<ExUInt128> data3, out Vector<ExUInt128> y, out Vector<ExUInt128> z, out Vector<ExUInt128> w) {
                return YGroup4Unzip_Basic(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip_Bit128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<T> YGroup4Unzip_Bit128<T>(Vector<T> data0, Vector<T> data1, Vector<T> data2, Vector<T> data3, out Vector<T> y, out Vector<T> z, out Vector<T> w) where T : struct {
                var d0 = YGroup4Unzip_Basic(data0.ExAs<T, ExUInt128>(), data1.ExAs<T, ExUInt128>(), data2.ExAs<T, ExUInt128>(), data3.ExAs<T, ExUInt128>(), out var d1, out var d2, out var d3);
                y = d1.ExAs<ExUInt128, T>();
                z = d2.ExAs<ExUInt128, T>();
                w = d3.ExAs<ExUInt128, T>();
                return d0.ExAs<ExUInt128, T>();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup4Unzip_Basic(Vector<float> data0, Vector<float> data1, Vector<float> data2, Vector<float> data3, out Vector<float> y, out Vector<float> z, out Vector<float> w) {
                var d0 = YGroup4Unzip_Basic(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), out var d1, out var d2, out var d3);
                y = d1.AsSingle();
                z = d2.AsSingle();
                w = d3.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{double}, Vector{double}, Vector{double}, Vector{double}, out Vector{double}, out Vector{double}, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup4Unzip_Basic(Vector<double> data0, Vector<double> data1, Vector<double> data2, Vector<double> data3, out Vector<double> y, out Vector<double> z, out Vector<double> w) {
                var d0 = YGroup4Unzip_Basic(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), data3.AsUInt64(), out var d1, out var d2, out var d3);
                y = d1.AsDouble();
                z = d2.AsDouble();
                w = d3.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup4Unzip_Basic(Vector<sbyte> data0, Vector<sbyte> data1, Vector<sbyte> data2, Vector<sbyte> data3, out Vector<sbyte> y, out Vector<sbyte> z, out Vector<sbyte> w) {
                var d0 = YGroup4Unzip_Basic(data0.AsByte(), data1.AsByte(), data2.AsByte(), data3.AsByte(), out var d1, out var d2, out var d3);
                y = d1.AsSByte();
                z = d2.AsSByte();
                w = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup4Unzip_Basic(Vector<byte> data0, Vector<byte> data1, Vector<byte> data2, Vector<byte> data3, out Vector<byte> y, out Vector<byte> z, out Vector<byte> w) {
                UnsafeUtil.SkipInit(out Vector<byte> x1);
                UnsafeUtil.SkipInit(out Vector<byte> y1);
                UnsafeUtil.SkipInit(out Vector<byte> z1);
                UnsafeUtil.SkipInit(out Vector<byte> w1);
                Span<Vector<byte>> src = [data0, data1, data2, data3];
                ref byte px = ref Unsafe.As<Vector<byte>, byte>(ref x1);
                ref byte py = ref Unsafe.As<Vector<byte>, byte>(ref y1);
                ref byte pz = ref Unsafe.As<Vector<byte>, byte>(ref z1);
                ref byte pw = ref Unsafe.As<Vector<byte>, byte>(ref w1);
                Span<byte> p = MemoryMarshal.Cast<Vector<byte>, byte>(src);
                int idx = 0;
                for (int i = 0; i < Vector<byte>.Count; ++i) {
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

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{short}, Vector{short}, Vector{short}, Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup4Unzip_Basic(Vector<short> data0, Vector<short> data1, Vector<short> data2, Vector<short> data3, out Vector<short> y, out Vector<short> z, out Vector<short> w) {
                var d0 = YGroup4Unzip_Basic(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), data3.AsUInt16(), out var d1, out var d2, out var d3);
                y = d1.AsInt16();
                z = d2.AsInt16();
                w = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup4Unzip_Basic(Vector<ushort> data0, Vector<ushort> data1, Vector<ushort> data2, Vector<ushort> data3, out Vector<ushort> y, out Vector<ushort> z, out Vector<ushort> w) {
                UnsafeUtil.SkipInit(out Vector<ushort> x1);
                UnsafeUtil.SkipInit(out Vector<ushort> y1);
                UnsafeUtil.SkipInit(out Vector<ushort> z1);
                UnsafeUtil.SkipInit(out Vector<ushort> w1);
                Span<Vector<ushort>> src = [data0, data1, data2, data3];
                ref ushort px = ref Unsafe.As<Vector<ushort>, ushort>(ref x1);
                ref ushort py = ref Unsafe.As<Vector<ushort>, ushort>(ref y1);
                ref ushort pz = ref Unsafe.As<Vector<ushort>, ushort>(ref z1);
                ref ushort pw = ref Unsafe.As<Vector<ushort>, ushort>(ref w1);
                Span<ushort> p = MemoryMarshal.Cast<Vector<ushort>, ushort>(src);
                int idx = 0;
                for (int i = 0; i < Vector<ushort>.Count; ++i) {
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

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{int}, Vector{int}, Vector{int}, Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup4Unzip_Basic(Vector<int> data0, Vector<int> data1, Vector<int> data2, Vector<int> data3, out Vector<int> y, out Vector<int> z, out Vector<int> w) {
                var d0 = YGroup4Unzip_Basic(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), out var d1, out var d2, out var d3);
                y = d1.AsInt32();
                z = d2.AsInt32();
                w = d3.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup4Unzip_Basic(Vector<uint> data0, Vector<uint> data1, Vector<uint> data2, Vector<uint> data3, out Vector<uint> y, out Vector<uint> z, out Vector<uint> w) {
                UnsafeUtil.SkipInit(out Vector<uint> x1);
                UnsafeUtil.SkipInit(out Vector<uint> y1);
                UnsafeUtil.SkipInit(out Vector<uint> z1);
                UnsafeUtil.SkipInit(out Vector<uint> w1);
                Span<Vector<uint>> src = [data0, data1, data2, data3];
                ref uint px = ref Unsafe.As<Vector<uint>, uint>(ref x1);
                ref uint py = ref Unsafe.As<Vector<uint>, uint>(ref y1);
                ref uint pz = ref Unsafe.As<Vector<uint>, uint>(ref z1);
                ref uint pw = ref Unsafe.As<Vector<uint>, uint>(ref w1);
                Span<uint> p = MemoryMarshal.Cast<Vector<uint>, uint>(src);
                int idx = 0;
                for (int i = 0; i < Vector<uint>.Count; ++i) {
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

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{long}, Vector{long}, Vector{long}, Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup4Unzip_Basic(Vector<long> data0, Vector<long> data1, Vector<long> data2, Vector<long> data3, out Vector<long> y, out Vector<long> z, out Vector<long> w) {
                var d0 = YGroup4Unzip_Basic(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), data3.AsUInt64(), out var d1, out var d2, out var d3);
                y = d1.AsInt64();
                z = d2.AsInt64();
                w = d3.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup4Unzip_Basic(Vector<ulong> data0, Vector<ulong> data1, Vector<ulong> data2, Vector<ulong> data3, out Vector<ulong> y, out Vector<ulong> z, out Vector<ulong> w) {
                UnsafeUtil.SkipInit(out Vector<ulong> x1);
                UnsafeUtil.SkipInit(out Vector<ulong> y1);
                UnsafeUtil.SkipInit(out Vector<ulong> z1);
                UnsafeUtil.SkipInit(out Vector<ulong> w1);
                Span<Vector<ulong>> src = [data0, data1, data2, data3];
                ref ulong px = ref Unsafe.As<Vector<ulong>, ulong>(ref x1);
                ref ulong py = ref Unsafe.As<Vector<ulong>, ulong>(ref y1);
                ref ulong pz = ref Unsafe.As<Vector<ulong>, ulong>(ref z1);
                ref ulong pw = ref Unsafe.As<Vector<ulong>, ulong>(ref w1);
                Span<ulong> p = MemoryMarshal.Cast<Vector<ulong>, ulong>(src);
                int idx = 0;
                for (int i = 0; i < Vector<ulong>.Count; ++i) {
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

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{ExInt128}, Vector{ExInt128}, Vector{ExInt128}, Vector{ExInt128}, out Vector{ExInt128}, out Vector{ExInt128}, out Vector{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExInt128> YGroup4Unzip_Basic(Vector<ExInt128> data0, Vector<ExInt128> data1, Vector<ExInt128> data2, Vector<ExInt128> data3, out Vector<ExInt128> y, out Vector<ExInt128> z, out Vector<ExInt128> w) {
                var d0 = YGroup4Unzip_Basic(data0.ExAsExUInt128(), data1.ExAsExUInt128(), data2.ExAsExUInt128(), data3.ExAsExUInt128(), out var d1, out var d2, out var d3);
                y = d1.ExAsExInt128();
                z = d2.ExAsExInt128();
                w = d3.ExAsExInt128();
                return d0.ExAsExInt128();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{ExUInt128}, Vector{ExUInt128}, Vector{ExUInt128}, Vector{ExUInt128}, out Vector{ExUInt128}, out Vector{ExUInt128}, out Vector{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExUInt128> YGroup4Unzip_Basic(Vector<ExUInt128> data0, Vector<ExUInt128> data1, Vector<ExUInt128> data2, Vector<ExUInt128> data3, out Vector<ExUInt128> y, out Vector<ExUInt128> z, out Vector<ExUInt128> w) {
                UnsafeUtil.SkipInit(out Vector<ExUInt128> x1);
                UnsafeUtil.SkipInit(out Vector<ExUInt128> y1);
                UnsafeUtil.SkipInit(out Vector<ExUInt128> z1);
                UnsafeUtil.SkipInit(out Vector<ExUInt128> w1);
                Span<Vector<ExUInt128>> src = [data0, data1, data2, data3];
                ref ExUInt128 px = ref Unsafe.As<Vector<ExUInt128>, ExUInt128>(ref x1);
                ref ExUInt128 py = ref Unsafe.As<Vector<ExUInt128>, ExUInt128>(ref y1);
                ref ExUInt128 pz = ref Unsafe.As<Vector<ExUInt128>, ExUInt128>(ref z1);
                ref ExUInt128 pw = ref Unsafe.As<Vector<ExUInt128>, ExUInt128>(ref w1);
                Span<ExUInt128> p = MemoryMarshal.Cast<Vector<ExUInt128>, ExUInt128>(src);
                int cnt = Vectors<ExUInt128>.Count;
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

#if VECTOR_HAS_METHOD && BCL_HAS_SHIFT

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup4Unzip_Narrow(Vector<sbyte> data0, Vector<sbyte> data1, Vector<sbyte> data2, Vector<sbyte> data3, out Vector<sbyte> y, out Vector<sbyte> z, out Vector<sbyte> w) {
                var d0 = YGroup4Unzip_Narrow(data0.AsByte(), data1.AsByte(), data2.AsByte(), data3.AsByte(), out var d1, out var d2, out var d3);
                y = d1.AsSByte();
                z = d2.AsSByte();
                w = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup4Unzip_Narrow(Vector<byte> data0, Vector<byte> data1, Vector<byte> data2, Vector<byte> data3, out Vector<byte> y, out Vector<byte> z, out Vector<byte> w) {
                const int L = 8;
                Vector<byte> rt0, rt1, rt2, rt3;
                Vector<uint> temp0, temp1, temp2, temp3;
                temp0 = data0.AsUInt32();
                temp1 = data1.AsUInt32();
                temp2 = data2.AsUInt32();
                temp3 = data3.AsUInt32();
                rt0 = Vector.Narrow(Vector.Narrow(temp0, temp1), Vector.Narrow(temp2, temp3));
                temp0 = Vector.ShiftRightLogical(temp0, L);
                temp1 = Vector.ShiftRightLogical(temp1, L);
                temp2 = Vector.ShiftRightLogical(temp2, L);
                temp3 = Vector.ShiftRightLogical(temp3, L);
                rt1 = Vector.Narrow(Vector.Narrow(temp0, temp1), Vector.Narrow(temp2, temp3));
                temp0 = Vector.ShiftRightLogical(temp0, L);
                temp1 = Vector.ShiftRightLogical(temp1, L);
                temp2 = Vector.ShiftRightLogical(temp2, L);
                temp3 = Vector.ShiftRightLogical(temp3, L);
                rt2 = Vector.Narrow(Vector.Narrow(temp0, temp1), Vector.Narrow(temp2, temp3));
                temp0 = Vector.ShiftRightLogical(temp0, L);
                temp1 = Vector.ShiftRightLogical(temp1, L);
                temp2 = Vector.ShiftRightLogical(temp2, L);
                temp3 = Vector.ShiftRightLogical(temp3, L);
                rt3 = Vector.Narrow(Vector.Narrow(temp0, temp1), Vector.Narrow(temp2, temp3));
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

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{short}, Vector{short}, Vector{short}, Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup4Unzip_Narrow(Vector<short> data0, Vector<short> data1, Vector<short> data2, Vector<short> data3, out Vector<short> y, out Vector<short> z, out Vector<short> w) {
                var d0 = YGroup4Unzip_Narrow(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), data3.AsUInt16(), out var d1, out var d2, out var d3);
                y = d1.AsInt16();
                z = d2.AsInt16();
                w = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup4Unzip_Narrow(Vector<ushort> data0, Vector<ushort> data1, Vector<ushort> data2, Vector<ushort> data3, out Vector<ushort> y, out Vector<ushort> z, out Vector<ushort> w) {
                const int L = 16;
                Vector<ushort> rt0, rt1, rt2, rt3;
                Vector<ulong> temp0, temp1, temp2, temp3;
                temp0 = data0.AsUInt64();
                temp1 = data1.AsUInt64();
                temp2 = data2.AsUInt64();
                temp3 = data3.AsUInt64();
                rt0 = Vector.Narrow(Vector.Narrow(temp0, temp1), Vector.Narrow(temp2, temp3));
                temp0 = Vector.ShiftRightLogical(temp0, L);
                temp1 = Vector.ShiftRightLogical(temp1, L);
                temp2 = Vector.ShiftRightLogical(temp2, L);
                temp3 = Vector.ShiftRightLogical(temp3, L);
                rt1 = Vector.Narrow(Vector.Narrow(temp0, temp1), Vector.Narrow(temp2, temp3));
                temp0 = Vector.ShiftRightLogical(temp0, L);
                temp1 = Vector.ShiftRightLogical(temp1, L);
                temp2 = Vector.ShiftRightLogical(temp2, L);
                temp3 = Vector.ShiftRightLogical(temp3, L);
                rt2 = Vector.Narrow(Vector.Narrow(temp0, temp1), Vector.Narrow(temp2, temp3));
                temp0 = Vector.ShiftRightLogical(temp0, L);
                temp1 = Vector.ShiftRightLogical(temp1, L);
                temp2 = Vector.ShiftRightLogical(temp2, L);
                temp3 = Vector.ShiftRightLogical(temp3, L);
                rt3 = Vector.Narrow(Vector.Narrow(temp0, temp1), Vector.Narrow(temp2, temp3));
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

#endif // VECTOR_HAS_METHOD && BCL_HAS_SHIFT

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup4Unzip_Unzip(Vector<float> data0, Vector<float> data1, Vector<float> data2, Vector<float> data3, out Vector<float> y, out Vector<float> z, out Vector<float> w) {
                var d0 = YGroup4Unzip_Unzip(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), out var d1, out var d2, out var d3);
                y = d1.AsSingle();
                z = d2.AsSingle();
                w = d3.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup4Unzip_Unzip(Vector<sbyte> data0, Vector<sbyte> data1, Vector<sbyte> data2, Vector<sbyte> data3, out Vector<sbyte> y, out Vector<sbyte> z, out Vector<sbyte> w) {
                var d0 = YGroup4Unzip_Unzip(data0.AsByte(), data1.AsByte(), data2.AsByte(), data3.AsByte(), out var d1, out var d2, out var d3);
                y = d1.AsSByte();
                z = d2.AsSByte();
                w = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup4Unzip_Unzip(Vector<byte> data0, Vector<byte> data1, Vector<byte> data2, Vector<byte> data3, out Vector<byte> y, out Vector<byte> z, out Vector<byte> w) {
                Vector<byte> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
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

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{short}, Vector{short}, Vector{short}, Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup4Unzip_Unzip(Vector<short> data0, Vector<short> data1, Vector<short> data2, Vector<short> data3, out Vector<short> y, out Vector<short> z, out Vector<short> w) {
                var d0 = YGroup4Unzip_Unzip(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), data3.AsUInt16(), out var d1, out var d2, out var d3);
                y = d1.AsInt16();
                z = d2.AsInt16();
                w = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup4Unzip_Unzip(Vector<ushort> data0, Vector<ushort> data1, Vector<ushort> data2, Vector<ushort> data3, out Vector<ushort> y, out Vector<ushort> z, out Vector<ushort> w) {
                Vector<ushort> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
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

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{int}, Vector{int}, Vector{int}, Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup4Unzip_Unzip(Vector<int> data0, Vector<int> data1, Vector<int> data2, Vector<int> data3, out Vector<int> y, out Vector<int> z, out Vector<int> w) {
                var d0 = YGroup4Unzip_Unzip(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), out var d1, out var d2, out var d3);
                y = d1.AsInt32();
                z = d2.AsInt32();
                w = d3.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup4Unzip_Unzip(Vector<uint> data0, Vector<uint> data1, Vector<uint> data2, Vector<uint> data3, out Vector<uint> y, out Vector<uint> z, out Vector<uint> w) {
                Vector<uint> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
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


            /// <inheritdoc cref="IVectorTraits.YGroup4Zip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup4Zip_AcceleratedTypes {
                get {
                    return YGroup2Zip_AcceleratedTypes;
                }
            }
            /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup4Zip(Vector<float> x, Vector<float> y, Vector<float> z, Vector<float> w, out Vector<float> data1, out Vector<float> data2, out Vector<float> data3) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD && BCL_HAS_SHIFT
                if (Vector.IsHardwareAccelerated) {
                    return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup4Zip_Basic(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{double}, Vector{double}, Vector{double}, Vector{double}, out Vector{double}, out Vector{double}, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup4Zip(Vector<double> x, Vector<double> y, Vector<double> z, Vector<double> w, out Vector<double> data1, out Vector<double> data2, out Vector<double> data3) {
                return YGroup4Zip_Basic(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup4Zip(Vector<sbyte> x, Vector<sbyte> y, Vector<sbyte> z, Vector<sbyte> w, out Vector<sbyte> data1, out Vector<sbyte> data2, out Vector<sbyte> data3) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup4Zip_Basic(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup4Zip(Vector<byte> x, Vector<byte> y, Vector<byte> z, Vector<byte> w, out Vector<byte> data1, out Vector<byte> data2, out Vector<byte> data3) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup4Zip_Basic(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{short}, Vector{short}, Vector{short}, Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup4Zip(Vector<short> x, Vector<short> y, Vector<short> z, Vector<short> w, out Vector<short> data1, out Vector<short> data2, out Vector<short> data3) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup4Zip_Basic(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup4Zip(Vector<ushort> x, Vector<ushort> y, Vector<ushort> z, Vector<ushort> w, out Vector<ushort> data1, out Vector<ushort> data2, out Vector<ushort> data3) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                if (Vector.IsHardwareAccelerated) {
                    return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup4Zip_Basic(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{int}, Vector{int}, Vector{int}, Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup4Zip(Vector<int> x, Vector<int> y, Vector<int> z, Vector<int> w, out Vector<int> data1, out Vector<int> data2, out Vector<int> data3) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD && BCL_HAS_SHIFT
                if (Vector.IsHardwareAccelerated) {
                    return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup4Zip_Basic(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup4Zip(Vector<uint> x, Vector<uint> y, Vector<uint> z, Vector<uint> w, out Vector<uint> data1, out Vector<uint> data2, out Vector<uint> data3) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD && BCL_HAS_SHIFT
                if (Vector.IsHardwareAccelerated) {
                    return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
                }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YGroup4Zip_Basic(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{long}, Vector{long}, Vector{long}, Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup4Zip(Vector<long> x, Vector<long> y, Vector<long> z, Vector<long> w, out Vector<long> data1, out Vector<long> data2, out Vector<long> data3) {
                return YGroup4Zip_Basic(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup4Zip(Vector<ulong> x, Vector<ulong> y, Vector<ulong> z, Vector<ulong> w, out Vector<ulong> data1, out Vector<ulong> data2, out Vector<ulong> data3) {
                return YGroup4Zip_Basic(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{ExInt128}, Vector{ExInt128}, Vector{ExInt128}, Vector{ExInt128}, out Vector{ExInt128}, out Vector{ExInt128}, out Vector{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExInt128> YGroup4Zip(Vector<ExInt128> x, Vector<ExInt128> y, Vector<ExInt128> z, Vector<ExInt128> w, out Vector<ExInt128> data1, out Vector<ExInt128> data2, out Vector<ExInt128> data3) {
                return YGroup4Zip_Basic(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{ExUInt128}, Vector{ExUInt128}, Vector{ExUInt128}, Vector{ExUInt128}, out Vector{ExUInt128}, out Vector{ExUInt128}, out Vector{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExUInt128> YGroup4Zip(Vector<ExUInt128> x, Vector<ExUInt128> y, Vector<ExUInt128> z, Vector<ExUInt128> w, out Vector<ExUInt128> data1, out Vector<ExUInt128> data2, out Vector<ExUInt128> data3) {
                return YGroup4Zip_Basic(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Zip_Bit128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<T> YGroup4Zip_Bit128<T>(Vector<T> x, Vector<T> y, Vector<T> z, Vector<T> w, out Vector<T> data1, out Vector<T> data2, out Vector<T> data3) where T : struct {
                var d0 = YGroup4Zip_Basic(x.ExAs<T, ExUInt128>(), y.ExAs<T, ExUInt128>(), z.ExAs<T, ExUInt128>(), w.ExAs<T, ExUInt128>(), out var d1, out var d2, out var d3);
                data1 = d1.ExAs<ExUInt128, T>();
                data2 = d2.ExAs<ExUInt128, T>();
                data3 = d3.ExAs<ExUInt128, T>();
                return d0.ExAs<ExUInt128, T>();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup4Zip_Basic(Vector<float> x, Vector<float> y, Vector<float> z, Vector<float> w, out Vector<float> data1, out Vector<float> data2, out Vector<float> data3) {
                var d0 = YGroup4Zip_Basic(x.AsUInt32(), y.AsUInt32(), z.AsUInt32(), w.AsUInt32(), out var d1, out var d2, out var d3);
                data1 = d1.AsSingle();
                data2 = d2.AsSingle();
                data3 = d3.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{double}, Vector{double}, Vector{double}, Vector{double}, out Vector{double}, out Vector{double}, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup4Zip_Basic(Vector<double> x, Vector<double> y, Vector<double> z, Vector<double> w, out Vector<double> data1, out Vector<double> data2, out Vector<double> data3) {
                var d0 = YGroup4Zip_Basic(x.AsUInt64(), y.AsUInt64(), z.AsUInt64(), w.AsUInt64(), out var d1, out var d2, out var d3);
                data1 = d1.AsDouble();
                data2 = d2.AsDouble();
                data3 = d3.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup4Zip_Basic(Vector<sbyte> x, Vector<sbyte> y, Vector<sbyte> z, Vector<sbyte> w, out Vector<sbyte> data1, out Vector<sbyte> data2, out Vector<sbyte> data3) {
                var d0 = YGroup4Zip_Basic(x.AsByte(), y.AsByte(), z.AsByte(), w.AsByte(), out var d1, out var d2, out var d3);
                data1 = d1.AsSByte();
                data2 = d2.AsSByte();
                data3 = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup4Zip_Basic(Vector<byte> x, Vector<byte> y, Vector<byte> z, Vector<byte> w, out Vector<byte> data1, out Vector<byte> data2, out Vector<byte> data3) {
                Span<Vector<byte>> rt = stackalloc Vector<byte>[4];
                ref byte px = ref Unsafe.As<Vector<byte>, byte>(ref x);
                ref byte py = ref Unsafe.As<Vector<byte>, byte>(ref y);
                ref byte pz = ref Unsafe.As<Vector<byte>, byte>(ref z);
                ref byte pw = ref Unsafe.As<Vector<byte>, byte>(ref w);
                Span<byte> q = MemoryMarshal.Cast<Vector<byte>, byte>(rt);
                int idx = 0;
                for (int i = 0; i < Vector<byte>.Count; ++i) {
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

            /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{short}, Vector{short}, Vector{short}, Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup4Zip_Basic(Vector<short> x, Vector<short> y, Vector<short> z, Vector<short> w, out Vector<short> data1, out Vector<short> data2, out Vector<short> data3) {
                var d0 = YGroup4Zip_Basic(x.AsUInt16(), y.AsUInt16(), z.AsUInt16(), w.AsUInt16(), out var d1, out var d2, out var d3);
                data1 = d1.AsInt16();
                data2 = d2.AsInt16();
                data3 = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup4Zip_Basic(Vector<ushort> x, Vector<ushort> y, Vector<ushort> z, Vector<ushort> w, out Vector<ushort> data1, out Vector<ushort> data2, out Vector<ushort> data3) {
                Span<Vector<ushort>> rt = stackalloc Vector<ushort>[4];
                ref ushort px = ref Unsafe.As<Vector<ushort>, ushort>(ref x);
                ref ushort py = ref Unsafe.As<Vector<ushort>, ushort>(ref y);
                ref ushort pz = ref Unsafe.As<Vector<ushort>, ushort>(ref z);
                ref ushort pw = ref Unsafe.As<Vector<ushort>, ushort>(ref w);
                Span<ushort> q = MemoryMarshal.Cast<Vector<ushort>, ushort>(rt);
                int idx = 0;
                for (int i = 0; i < Vector<ushort>.Count; ++i) {
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

            /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{int}, Vector{int}, Vector{int}, Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup4Zip_Basic(Vector<int> x, Vector<int> y, Vector<int> z, Vector<int> w, out Vector<int> data1, out Vector<int> data2, out Vector<int> data3) {
                var d0 = YGroup4Zip_Basic(x.AsUInt32(), y.AsUInt32(), z.AsUInt32(), w.AsUInt32(), out var d1, out var d2, out var d3);
                data1 = d1.AsInt32();
                data2 = d2.AsInt32();
                data3 = d3.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup4Zip_Basic(Vector<uint> x, Vector<uint> y, Vector<uint> z, Vector<uint> w, out Vector<uint> data1, out Vector<uint> data2, out Vector<uint> data3) {
                Span<Vector<uint>> rt = stackalloc Vector<uint>[4];
                ref uint px = ref Unsafe.As<Vector<uint>, uint>(ref x);
                ref uint py = ref Unsafe.As<Vector<uint>, uint>(ref y);
                ref uint pz = ref Unsafe.As<Vector<uint>, uint>(ref z);
                ref uint pw = ref Unsafe.As<Vector<uint>, uint>(ref w);
                Span<uint> q = MemoryMarshal.Cast<Vector<uint>, uint>(rt);
                int idx = 0;
                for (int i = 0; i < Vector<uint>.Count; ++i) {
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

            /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{long}, Vector{long}, Vector{long}, Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup4Zip_Basic(Vector<long> x, Vector<long> y, Vector<long> z, Vector<long> w, out Vector<long> data1, out Vector<long> data2, out Vector<long> data3) {
                var d0 = YGroup4Zip_Basic(x.AsUInt64(), y.AsUInt64(), z.AsUInt64(), w.AsUInt64(), out var d1, out var d2, out var d3);
                data1 = d1.AsInt64();
                data2 = d2.AsInt64();
                data3 = d3.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup4Zip_Basic(Vector<ulong> x, Vector<ulong> y, Vector<ulong> z, Vector<ulong> w, out Vector<ulong> data1, out Vector<ulong> data2, out Vector<ulong> data3) {
                Span<Vector<ulong>> rt = stackalloc Vector<ulong>[4];
                ref ulong px = ref Unsafe.As<Vector<ulong>, ulong>(ref x);
                ref ulong py = ref Unsafe.As<Vector<ulong>, ulong>(ref y);
                ref ulong pz = ref Unsafe.As<Vector<ulong>, ulong>(ref z);
                ref ulong pw = ref Unsafe.As<Vector<ulong>, ulong>(ref w);
                Span<ulong> q = MemoryMarshal.Cast<Vector<ulong>, ulong>(rt);
                int idx = 0;
                for (int i = 0; i < Vector<ulong>.Count; ++i) {
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

            /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{ExInt128}, Vector{ExInt128}, Vector{ExInt128}, Vector{ExInt128}, out Vector{ExInt128}, out Vector{ExInt128}, out Vector{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExInt128> YGroup4Zip_Basic(Vector<ExInt128> x, Vector<ExInt128> y, Vector<ExInt128> z, Vector<ExInt128> w, out Vector<ExInt128> data1, out Vector<ExInt128> data2, out Vector<ExInt128> data3) {
                var d0 = YGroup4Zip_Basic(x.ExAsExUInt128(), y.ExAsExUInt128(), z.ExAsExUInt128(), w.ExAsExUInt128(), out var d1, out var d2, out var d3);
                data1 = d1.ExAsExInt128();
                data2 = d2.ExAsExInt128();
                data3 = d3.ExAsExInt128();
                return d0.ExAsExInt128();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{ExUInt128}, Vector{ExUInt128}, Vector{ExUInt128}, Vector{ExUInt128}, out Vector{ExUInt128}, out Vector{ExUInt128}, out Vector{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExUInt128> YGroup4Zip_Basic(Vector<ExUInt128> x, Vector<ExUInt128> y, Vector<ExUInt128> z, Vector<ExUInt128> w, out Vector<ExUInt128> data1, out Vector<ExUInt128> data2, out Vector<ExUInt128> data3) {
                Span<Vector<ExUInt128>> rt = stackalloc Vector<ExUInt128>[4];
                ref ExUInt128 px = ref Unsafe.As<Vector<ExUInt128>, ExUInt128>(ref x);
                ref ExUInt128 py = ref Unsafe.As<Vector<ExUInt128>, ExUInt128>(ref y);
                ref ExUInt128 pz = ref Unsafe.As<Vector<ExUInt128>, ExUInt128>(ref z);
                ref ExUInt128 pw = ref Unsafe.As<Vector<ExUInt128>, ExUInt128>(ref w);
                Span<ExUInt128> q = MemoryMarshal.Cast<Vector<ExUInt128>, ExUInt128>(rt);
                int cnt = Vectors<ExUInt128>.Count;
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

#if VECTOR_HAS_METHOD && BCL_HAS_SHIFT

            /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup4Zip_Widen(Vector<sbyte> x, Vector<sbyte> y, Vector<sbyte> z, Vector<sbyte> w, out Vector<sbyte> data1, out Vector<sbyte> data2, out Vector<sbyte> data3) {
                var d0 = YGroup4Zip_Widen(x.AsByte(), y.AsByte(), z.AsByte(), w.AsByte(), out var d1, out var d2, out var d3);
                data1 = d1.AsSByte();
                data2 = d2.AsSByte();
                data3 = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup4Zip_Widen(Vector<byte> x, Vector<byte> y, Vector<byte> z, Vector<byte> w, out Vector<byte> data1, out Vector<byte> data2, out Vector<byte> data3) {
                const int L = 8;
                Vector<byte> s0, s1, s2, s3;
                Vector<ushort> t0, t1;
                Vector<uint> r0, r1, r2, r3, d0, d1, d2, d3;
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
                Vector.Widen(s0, out t0, out t1);
                Vector.Widen(t0, out r0, out r1);
                Vector.Widen(t1, out r2, out r3);
                d0 = Vector.ShiftLeft(r0, L);
                d1 = Vector.ShiftLeft(r1, L);
                d2 = Vector.ShiftLeft(r2, L);
                d3 = Vector.ShiftLeft(r3, L);
                // Part 1
                Vector.Widen(s1, out t0, out t1);
                Vector.Widen(t0, out r0, out r1);
                Vector.Widen(t1, out r2, out r3);
                d0 = Vector.BitwiseOr(d0, r0);
                d1 = Vector.BitwiseOr(d1, r1);
                d2 = Vector.BitwiseOr(d2, r2);
                d3 = Vector.BitwiseOr(d3, r3);
                d0 = Vector.ShiftLeft(d0, L);
                d1 = Vector.ShiftLeft(d1, L);
                d2 = Vector.ShiftLeft(d2, L);
                d3 = Vector.ShiftLeft(d3, L);
                // Part 2
                Vector.Widen(s2, out t0, out t1);
                Vector.Widen(t0, out r0, out r1);
                Vector.Widen(t1, out r2, out r3);
                d0 = Vector.BitwiseOr(d0, r0);
                d1 = Vector.BitwiseOr(d1, r1);
                d2 = Vector.BitwiseOr(d2, r2);
                d3 = Vector.BitwiseOr(d3, r3);
                d0 = Vector.ShiftLeft(d0, L);
                d1 = Vector.ShiftLeft(d1, L);
                d2 = Vector.ShiftLeft(d2, L);
                d3 = Vector.ShiftLeft(d3, L);
                // Part 3
                Vector.Widen(s3, out t0, out t1);
                Vector.Widen(t0, out r0, out r1);
                Vector.Widen(t1, out r2, out r3);
                d0 = Vector.BitwiseOr(d0, r0);
                d1 = Vector.BitwiseOr(d1, r1);
                d2 = Vector.BitwiseOr(d2, r2);
                d3 = Vector.BitwiseOr(d3, r3);
                // done.
                data1 = d1.AsByte();
                data2 = d2.AsByte();
                data3 = d3.AsByte();
                return d0.AsByte();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{short}, Vector{short}, Vector{short}, Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup4Zip_Widen(Vector<short> x, Vector<short> y, Vector<short> z, Vector<short> w, out Vector<short> data1, out Vector<short> data2, out Vector<short> data3) {
                var d0 = YGroup4Zip_Widen(x.AsUInt16(), y.AsUInt16(), z.AsUInt16(), w.AsUInt16(), out var d1, out var d2, out var d3);
                data1 = d1.AsInt16();
                data2 = d2.AsInt16();
                data3 = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup4Zip_Widen(Vector<ushort> x, Vector<ushort> y, Vector<ushort> z, Vector<ushort> w, out Vector<ushort> data1, out Vector<ushort> data2, out Vector<ushort> data3) {
                const int L = 16;
                Vector<ushort> s0, s1, s2, s3;
                Vector<uint> t0, t1;
                Vector<ulong> r0, r1, r2, r3, d0, d1, d2, d3;
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
                Vector.Widen(s0, out t0, out t1);
                Vector.Widen(t0, out r0, out r1);
                Vector.Widen(t1, out r2, out r3);
                d0 = Vector.ShiftLeft(r0, L);
                d1 = Vector.ShiftLeft(r1, L);
                d2 = Vector.ShiftLeft(r2, L);
                d3 = Vector.ShiftLeft(r3, L);
                // Part 1
                Vector.Widen(s1, out t0, out t1);
                Vector.Widen(t0, out r0, out r1);
                Vector.Widen(t1, out r2, out r3);
                d0 = Vector.BitwiseOr(d0, r0);
                d1 = Vector.BitwiseOr(d1, r1);
                d2 = Vector.BitwiseOr(d2, r2);
                d3 = Vector.BitwiseOr(d3, r3);
                d0 = Vector.ShiftLeft(d0, L);
                d1 = Vector.ShiftLeft(d1, L);
                d2 = Vector.ShiftLeft(d2, L);
                d3 = Vector.ShiftLeft(d3, L);
                // Part 2
                Vector.Widen(s2, out t0, out t1);
                Vector.Widen(t0, out r0, out r1);
                Vector.Widen(t1, out r2, out r3);
                d0 = Vector.BitwiseOr(d0, r0);
                d1 = Vector.BitwiseOr(d1, r1);
                d2 = Vector.BitwiseOr(d2, r2);
                d3 = Vector.BitwiseOr(d3, r3);
                d0 = Vector.ShiftLeft(d0, L);
                d1 = Vector.ShiftLeft(d1, L);
                d2 = Vector.ShiftLeft(d2, L);
                d3 = Vector.ShiftLeft(d3, L);
                // Part 3
                Vector.Widen(s3, out t0, out t1);
                Vector.Widen(t0, out r0, out r1);
                Vector.Widen(t1, out r2, out r3);
                d0 = Vector.BitwiseOr(d0, r0);
                d1 = Vector.BitwiseOr(d1, r1);
                d2 = Vector.BitwiseOr(d2, r2);
                d3 = Vector.BitwiseOr(d3, r3);
                // done.
                data1 = d1.AsUInt16();
                data2 = d2.AsUInt16();
                data3 = d3.AsUInt16();
                return d0.AsUInt16();
            }

#endif // VECTOR_HAS_METHOD && BCL_HAS_SHIFT

            /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup4Zip_Zip(Vector<float> x, Vector<float> y, Vector<float> z, Vector<float> w, out Vector<float> data1, out Vector<float> data2, out Vector<float> data3) {
                var d0 = YGroup4Zip_Zip(x.AsUInt32(), y.AsUInt32(), z.AsUInt32(), w.AsUInt32(), out var d1, out var d2, out var d3);
                data1 = d1.AsSingle();
                data2 = d2.AsSingle();
                data3 = d3.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup4Zip_Zip(Vector<sbyte> x, Vector<sbyte> y, Vector<sbyte> z, Vector<sbyte> w, out Vector<sbyte> data1, out Vector<sbyte> data2, out Vector<sbyte> data3) {
                var d0 = YGroup4Zip_Zip(x.AsByte(), y.AsByte(), z.AsByte(), w.AsByte(), out var d1, out var d2, out var d3);
                data1 = d1.AsSByte();
                data2 = d2.AsSByte();
                data3 = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup4Zip_Zip(Vector<byte> x, Vector<byte> y, Vector<byte> z, Vector<byte> w, out Vector<byte> data1, out Vector<byte> data2, out Vector<byte> data3) {
                Vector<byte> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
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

            /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{short}, Vector{short}, Vector{short}, Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup4Zip_Zip(Vector<short> x, Vector<short> y, Vector<short> z, Vector<short> w, out Vector<short> data1, out Vector<short> data2, out Vector<short> data3) {
                var d0 = YGroup4Zip_Zip(x.AsUInt16(), y.AsUInt16(), z.AsUInt16(), w.AsUInt16(), out var d1, out var d2, out var d3);
                data1 = d1.AsInt16();
                data2 = d2.AsInt16();
                data3 = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup4Zip_Zip(Vector<ushort> x, Vector<ushort> y, Vector<ushort> z, Vector<ushort> w, out Vector<ushort> data1, out Vector<ushort> data2, out Vector<ushort> data3) {
                Vector<ushort> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
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

            /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{int}, Vector{int}, Vector{int}, Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup4Zip_Zip(Vector<int> x, Vector<int> y, Vector<int> z, Vector<int> w, out Vector<int> data1, out Vector<int> data2, out Vector<int> data3) {
                var d0 = YGroup4Zip_Zip(x.AsUInt32(), y.AsUInt32(), z.AsUInt32(), w.AsUInt32(), out var d1, out var d2, out var d3);
                data1 = d1.AsInt32();
                data2 = d2.AsInt32();
                data3 = d3.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup4Zip_Zip(Vector<uint> x, Vector<uint> y, Vector<uint> z, Vector<uint> w, out Vector<uint> data1, out Vector<uint> data2, out Vector<uint> data3) {
                Vector<uint> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
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

        }
    }
}
