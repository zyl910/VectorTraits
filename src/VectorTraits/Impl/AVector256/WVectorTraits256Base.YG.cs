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
using Zyl.VectorTraits.Impl.Util;

namespace Zyl.VectorTraits.Impl.AVector256 {
    partial class WVectorTraits256Base {

        partial class Statics {

#if NETCOREAPP3_0_OR_GREATER

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
