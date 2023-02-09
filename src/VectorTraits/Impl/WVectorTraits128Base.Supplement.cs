﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif

namespace Zyl.VectorTraits.Impl {

    partial class WVectorTraits128Base {

        partial class Statics {

#if NETCOREAPP3_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.Abs_AcceleratedTypes"/>
            public static TypeCodeFlags Abs_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Abs(Vector128<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Abs(value);
#else
                return Abs_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Abs(Vector128<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Abs(value);
#else
                return Abs_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Abs(Vector128<sbyte> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Abs(value);
#else
                return Abs_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Abs(Vector128<short> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Abs(value);
#else
                return Abs_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Abs(Vector128<int> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Abs(value);
#else
                return Abs_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Abs(Vector128<long> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Abs(value);
#else
                return Abs_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<float> Abs_Base(Vector128<float> value) {
                Vector128<float> rt = value;
                float* p = (float*)&rt;
                p[0] = Math.Abs(p[0]);
                p[1] = Math.Abs(p[1]);
                p[2] = Math.Abs(p[2]);
                p[3] = Math.Abs(p[3]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<double> Abs_Base(Vector128<double> value) {
                Vector128<double> rt = value;
                double* p = (double*)&rt;
                p[0] = Math.Abs(p[0]);
                p[1] = Math.Abs(p[1]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<sbyte> Abs_Base(Vector128<sbyte> value) {
                Vector128<sbyte> rt = value;
                sbyte* p = (sbyte*)&rt;
                p[0] = BitUtil.Abs(p[0]);
                p[1] = BitUtil.Abs(p[1]);
                p[2] = BitUtil.Abs(p[2]);
                p[3] = BitUtil.Abs(p[3]);
                p[4] = BitUtil.Abs(p[4]);
                p[5] = BitUtil.Abs(p[5]);
                p[6] = BitUtil.Abs(p[6]);
                p[7] = BitUtil.Abs(p[7]);
                p[8] = BitUtil.Abs(p[8]);
                p[9] = BitUtil.Abs(p[9]);
                p[10] = BitUtil.Abs(p[10]);
                p[11] = BitUtil.Abs(p[11]);
                p[12] = BitUtil.Abs(p[12]);
                p[13] = BitUtil.Abs(p[13]);
                p[14] = BitUtil.Abs(p[14]);
                p[15] = BitUtil.Abs(p[15]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<short> Abs_Base(Vector128<short> value) {
                Vector128<short> rt = value;
                short* p = (short*)&rt;
                p[0] = BitUtil.Abs(p[0]);
                p[1] = BitUtil.Abs(p[1]);
                p[2] = BitUtil.Abs(p[2]);
                p[3] = BitUtil.Abs(p[3]);
                p[4] = BitUtil.Abs(p[4]);
                p[5] = BitUtil.Abs(p[5]);
                p[6] = BitUtil.Abs(p[6]);
                p[7] = BitUtil.Abs(p[7]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<int> Abs_Base(Vector128<int> value) {
                Vector128<int> rt = value;
                int* p = (int*)&rt;
                p[0] = BitUtil.Abs(p[0]);
                p[1] = BitUtil.Abs(p[1]);
                p[2] = BitUtil.Abs(p[2]);
                p[3] = BitUtil.Abs(p[3]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<long> Abs_Base(Vector128<long> value) {
                Vector128<long> rt = value;
                long* p = (long*)&rt;
                p[0] = BitUtil.Abs(p[0]);
                p[1] = BitUtil.Abs(p[1]);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.Add_AcceleratedTypes"/>
            public static TypeCodeFlags Add_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Add(Vector128<float> left, Vector128<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Add(left, right);
#else
                return Add_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Add(Vector128<double> left, Vector128<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Add(left, right);
#else
                return Add_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Add(Vector128<sbyte> left, Vector128<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Add(left, right);
#else
                return Add_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Add(Vector128<byte> left, Vector128<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Add(left, right);
#else
                return Add_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Add(Vector128<short> left, Vector128<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Add(left, right);
#else
                return Add_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Add(Vector128<ushort> left, Vector128<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Add(left, right);
#else
                return Add_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Add(Vector128<int> left, Vector128<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Add(left, right);
#else
                return Add_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Add(Vector128<uint> left, Vector128<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Add(left, right);
#else
                return Add_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Add(Vector128<long> left, Vector128<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Add(left, right);
#else
                return Add_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Add(Vector128<ulong> left, Vector128<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Add(left, right);
#else
                return Add_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<float> Add_Base(Vector128<float> left, Vector128<float> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<float> rt);
#else
                Vector128<float> rt = default;
#endif // NET5_0_OR_GREATER
                float* prt = (float*)&rt;
                float* pleft = (float*)&left;
                float* pright = (float*)&right;
                prt[0] = (pleft[0] + pright[0]);
                prt[1] = (pleft[1] + pright[1]);
                prt[2] = (pleft[2] + pright[2]);
                prt[3] = (pleft[3] + pright[3]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<double> Add_Base(Vector128<double> left, Vector128<double> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<double> rt);
#else
                Vector128<double> rt = default;
#endif // NET5_0_OR_GREATER
                double* prt = (double*)&rt;
                double* pleft = (double*)&left;
                double* pright = (double*)&right;
                prt[0] = (pleft[0] + pright[0]);
                prt[1] = (pleft[1] + pright[1]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<sbyte> Add_Base(Vector128<sbyte> left, Vector128<sbyte> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<sbyte> rt);
#else
                Vector128<sbyte> rt = default;
#endif // NET5_0_OR_GREATER
                sbyte* prt = (sbyte*)&rt;
                sbyte* pleft = (sbyte*)&left;
                sbyte* pright = (sbyte*)&right;
                prt[0] = (sbyte)(pleft[0] + pright[0]);
                prt[1] = (sbyte)(pleft[1] + pright[1]);
                prt[2] = (sbyte)(pleft[2] + pright[2]);
                prt[3] = (sbyte)(pleft[3] + pright[3]);
                prt[4] = (sbyte)(pleft[4] + pright[4]);
                prt[5] = (sbyte)(pleft[5] + pright[5]);
                prt[6] = (sbyte)(pleft[6] + pright[6]);
                prt[7] = (sbyte)(pleft[7] + pright[7]);
                prt[8] = (sbyte)(pleft[8] + pright[8]);
                prt[9] = (sbyte)(pleft[9] + pright[9]);
                prt[10] = (sbyte)(pleft[10] + pright[10]);
                prt[11] = (sbyte)(pleft[11] + pright[11]);
                prt[12] = (sbyte)(pleft[12] + pright[12]);
                prt[13] = (sbyte)(pleft[13] + pright[13]);
                prt[14] = (sbyte)(pleft[14] + pright[14]);
                prt[15] = (sbyte)(pleft[15] + pright[15]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<byte> Add_Base(Vector128<byte> left, Vector128<byte> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<byte> rt);
#else
                Vector128<byte> rt = default;
#endif // NET5_0_OR_GREATER
                byte* prt = (byte*)&rt;
                byte* pleft = (byte*)&left;
                byte* pright = (byte*)&right;
                prt[0] = (byte)(pleft[0] + pright[0]);
                prt[1] = (byte)(pleft[1] + pright[1]);
                prt[2] = (byte)(pleft[2] + pright[2]);
                prt[3] = (byte)(pleft[3] + pright[3]);
                prt[4] = (byte)(pleft[4] + pright[4]);
                prt[5] = (byte)(pleft[5] + pright[5]);
                prt[6] = (byte)(pleft[6] + pright[6]);
                prt[7] = (byte)(pleft[7] + pright[7]);
                prt[8] = (byte)(pleft[8] + pright[8]);
                prt[9] = (byte)(pleft[9] + pright[9]);
                prt[10] = (byte)(pleft[10] + pright[10]);
                prt[11] = (byte)(pleft[11] + pright[11]);
                prt[12] = (byte)(pleft[12] + pright[12]);
                prt[13] = (byte)(pleft[13] + pright[13]);
                prt[14] = (byte)(pleft[14] + pright[14]);
                prt[15] = (byte)(pleft[15] + pright[15]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<short> Add_Base(Vector128<short> left, Vector128<short> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<short> rt);
#else
                Vector128<short> rt = default;
#endif // NET5_0_OR_GREATER
                short* prt = (short*)&rt;
                short* pleft = (short*)&left;
                short* pright = (short*)&right;
                prt[0] = (short)(pleft[0] + pright[0]);
                prt[1] = (short)(pleft[1] + pright[1]);
                prt[2] = (short)(pleft[2] + pright[2]);
                prt[3] = (short)(pleft[3] + pright[3]);
                prt[4] = (short)(pleft[4] + pright[4]);
                prt[5] = (short)(pleft[5] + pright[5]);
                prt[6] = (short)(pleft[6] + pright[6]);
                prt[7] = (short)(pleft[7] + pright[7]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<ushort> Add_Base(Vector128<ushort> left, Vector128<ushort> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<ushort> rt);
#else
                Vector128<ushort> rt = default;
#endif // NET5_0_OR_GREATER
                ushort* prt = (ushort*)&rt;
                ushort* pleft = (ushort*)&left;
                ushort* pright = (ushort*)&right;
                prt[0] = (ushort)(pleft[0] + pright[0]);
                prt[1] = (ushort)(pleft[1] + pright[1]);
                prt[2] = (ushort)(pleft[2] + pright[2]);
                prt[3] = (ushort)(pleft[3] + pright[3]);
                prt[4] = (ushort)(pleft[4] + pright[4]);
                prt[5] = (ushort)(pleft[5] + pright[5]);
                prt[6] = (ushort)(pleft[6] + pright[6]);
                prt[7] = (ushort)(pleft[7] + pright[7]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<int> Add_Base(Vector128<int> left, Vector128<int> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<int> rt);
#else
                Vector128<int> rt = default;
#endif // NET5_0_OR_GREATER
                int* prt = (int*)&rt;
                int* pleft = (int*)&left;
                int* pright = (int*)&right;
                prt[0] = (pleft[0] + pright[0]);
                prt[1] = (pleft[1] + pright[1]);
                prt[2] = (pleft[2] + pright[2]);
                prt[3] = (pleft[3] + pright[3]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<uint> Add_Base(Vector128<uint> left, Vector128<uint> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<uint> rt);
#else
                Vector128<uint> rt = default;
#endif // NET5_0_OR_GREATER
                uint* prt = (uint*)&rt;
                uint* pleft = (uint*)&left;
                uint* pright = (uint*)&right;
                prt[0] = (pleft[0] + pright[0]);
                prt[1] = (pleft[1] + pright[1]);
                prt[2] = (pleft[2] + pright[2]);
                prt[3] = (pleft[3] + pright[3]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<long> Add_Base(Vector128<long> left, Vector128<long> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<long> rt);
#else
                Vector128<long> rt = default;
#endif // NET5_0_OR_GREATER
                long* prt = (long*)&rt;
                long* pleft = (long*)&left;
                long* pright = (long*)&right;
                prt[0] = (pleft[0] + pright[0]);
                prt[1] = (pleft[1] + pright[1]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<ulong> Add_Base(Vector128<ulong> left, Vector128<ulong> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<ulong> rt);
#else
                Vector128<ulong> rt = default;
#endif // NET5_0_OR_GREATER
                ulong* prt = (ulong*)&rt;
                ulong* pleft = (ulong*)&left;
                ulong* pright = (ulong*)&right;
                prt[0] = (pleft[0] + pright[0]);
                prt[1] = (pleft[1] + pright[1]);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.AndNot_AcceleratedTypes"/>
            public static TypeCodeFlags AndNot_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.AndNot{T}(Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> AndNot<T>(Vector128<T> left, Vector128<T> right) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.AndNot(left, right);
#else
                return AndNot_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.AndNot{T}(Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<T> AndNot_Base<T>(Vector128<T> left, Vector128<T> right) where T : struct {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<T> rt);
#else
                Vector128<T> rt = default;
#endif // NET5_0_OR_GREATER
                ulong* pleft = (ulong*)&left;
                ulong* pright = (ulong*)&right;
                ulong* q = (ulong*)&rt;
                // rt[i] := left[i] & ~right[i];
                q[0] = pleft[0] & ~pright[0];
                q[1] = pleft[1] & ~pright[1];
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.BitwiseAnd_AcceleratedTypes"/>
            public static TypeCodeFlags BitwiseAnd_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.BitwiseAnd{T}(Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> BitwiseAnd<T>(Vector128<T> left, Vector128<T> right) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.BitwiseAnd(left, right);
#else
                return BitwiseAnd_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.BitwiseAnd{T}(Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<T> BitwiseAnd_Base<T>(Vector128<T> left, Vector128<T> right) where T : struct {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<T> rt);
#else
                Vector128<T> rt = default;
#endif // NET5_0_OR_GREATER
                ulong* pleft = (ulong*)&left;
                ulong* pright = (ulong*)&right;
                ulong* q = (ulong*)&rt;
                // rt[i] := left[i] & right[i];
                q[0] = pleft[0] & pright[0];
                q[1] = pleft[1] & pright[1];
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.BitwiseOr_AcceleratedTypes"/>
            public static TypeCodeFlags BitwiseOr_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.BitwiseOr{T}(Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> BitwiseOr<T>(Vector128<T> left, Vector128<T> right) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.BitwiseOr(left, right);
#else
                return BitwiseOr_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.BitwiseOr{T}(Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<T> BitwiseOr_Base<T>(Vector128<T> left, Vector128<T> right) where T : struct {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<T> rt);
#else
                Vector128<T> rt = default;
#endif // NET5_0_OR_GREATER
                ulong* pleft = (ulong*)&left;
                ulong* pright = (ulong*)&right;
                ulong* q = (ulong*)&rt;
                // rt[i] := left[i] | right[i];
                q[0] = pleft[0] | pright[0];
                q[1] = pleft[1] | pright[1];
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.ConditionalSelect_AcceleratedTypes"/>
            public static TypeCodeFlags ConditionalSelect_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ConditionalSelect{T}(Vector128{T}, Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> ConditionalSelect<T>(Vector128<T> condition, Vector128<T> left, Vector128<T> right) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ConditionalSelect(condition, left, right);
#else
                return ConditionalSelect_Base(condition, left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            ///// <inheritdoc cref="IWVectorTraits128.ConditionalSelect(Vector128{int}, Vector128{float}, Vector128{float})"/>
            //[MethodImpl(MethodImplOptions.AggressiveInlining)]
            //public static Vector128<float> ConditionalSelect(Vector128<int> condition, Vector128<float> left, Vector128<float> right) {
            //    return ConditionalSelect<float>(condition.AsSingle(), left, right);
            //}

            ///// <inheritdoc cref="IWVectorTraits128.ConditionalSelect(Vector128{long}, Vector128{double}, Vector128{double})"/>
            //[MethodImpl(MethodImplOptions.AggressiveInlining)]
            //public static Vector128<double> ConditionalSelect(Vector128<long> condition, Vector128<double> left, Vector128<double> right) {
            //    return ConditionalSelect<double>(condition.AsDouble(), left, right);
            //}

            /// <inheritdoc cref="IWVectorTraits128.ConditionalSelect{T}(Vector128{T}, Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<T> ConditionalSelect_Base<T>(Vector128<T> condition, Vector128<T> left, Vector128<T> right) where T : struct {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<T> rt);
#else
                Vector128<T> rt = default;
#endif // NET5_0_OR_GREATER
                ulong* pcondition = (ulong*)&condition;
                ulong* pleft = (ulong*)&left;
                ulong* pright = (ulong*)&right;
                ulong* q = (ulong*)&rt;
                // result = (left & condition) | (right & ~condition);
                q[0] = (pleft[0] & pcondition[0]) | (pright[0] & ~pcondition[0]);
                q[1] = (pleft[1] & pcondition[1]) | (pright[1] & ~pcondition[1]);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.Divide_AcceleratedTypes"/>
            public static TypeCodeFlags Divide_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        // rt |= TypeCodeFlags.Single | TypeCodeFlags.Double; // Arm 32bit no hardware accelerated.
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Divide(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Divide(Vector128<float> left, Vector128<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Divide(left, right);
#else
                return Divide_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Divide(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Divide(Vector128<double> left, Vector128<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Divide(left, right);
#else
                return Divide_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Divide(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<float> Divide_Base(Vector128<float> left, Vector128<float> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<float> rt);
#else
                Vector128<float> rt = default;
#endif // NET5_0_OR_GREATER
                float* prt = (float*)&rt;
                float* pleft = (float*)&left;
                float* pright = (float*)&right;
                prt[0] = (pleft[0] / pright[0]);
                prt[1] = (pleft[1] / pright[1]);
                prt[2] = (pleft[2] / pright[2]);
                prt[3] = (pleft[3] / pright[3]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Divide(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<double> Divide_Base(Vector128<double> left, Vector128<double> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<double> rt);
#else
                Vector128<double> rt = default;
#endif // NET5_0_OR_GREATER
                double* prt = (double*)&rt;
                double* pleft = (double*)&left;
                double* pright = (double*)&right;
                prt[0] = (pleft[0] / pright[0]);
                prt[1] = (pleft[1] / pright[1]);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.GreaterThan_AcceleratedTypes"/>
            public static TypeCodeFlags GreaterThan_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> GreaterThan(Vector128<float> left, Vector128<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.GreaterThan(left, right);
#else
                return GreaterThan_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> GreaterThan(Vector128<double> left, Vector128<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.GreaterThan(left, right);
#else
                return GreaterThan_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> GreaterThan(Vector128<sbyte> left, Vector128<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.GreaterThan(left, right);
#else
                return GreaterThan_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> GreaterThan(Vector128<byte> left, Vector128<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.GreaterThan(left, right);
#else
                return GreaterThan_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> GreaterThan(Vector128<short> left, Vector128<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.GreaterThan(left, right);
#else
                return GreaterThan_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> GreaterThan(Vector128<ushort> left, Vector128<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.GreaterThan(left, right);
#else
                return GreaterThan_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> GreaterThan(Vector128<int> left, Vector128<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.GreaterThan(left, right);
#else
                return GreaterThan_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> GreaterThan(Vector128<uint> left, Vector128<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.GreaterThan(left, right);
#else
                return GreaterThan_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> GreaterThan(Vector128<long> left, Vector128<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.GreaterThan(left, right);
#else
                return GreaterThan_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> GreaterThan(Vector128<ulong> left, Vector128<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.GreaterThan(left, right);
#else
                return GreaterThan_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<float> GreaterThan_Base(Vector128<float> left, Vector128<float> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<int> condition);
#else
                Vector128<int> condition = default;
#endif // NET5_0_OR_GREATER
                int* pcondition = (int*)&condition;
                float* pleft = (float*)&left;
                float* pright = (float*)&right;
                pcondition[0] = BitUtil.ToInt32Mask(pleft[0] > pright[0]);
                pcondition[1] = BitUtil.ToInt32Mask(pleft[1] > pright[1]);
                pcondition[2] = BitUtil.ToInt32Mask(pleft[2] > pright[2]);
                pcondition[3] = BitUtil.ToInt32Mask(pleft[3] > pright[3]);
                return condition.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<double> GreaterThan_Base(Vector128<double> left, Vector128<double> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<long> condition);
#else
                Vector128<long> condition = default;
#endif // NET5_0_OR_GREATER
                long* pcondition = (long*)&condition;
                double* pleft = (double*)&left;
                double* pright = (double*)&right;
                pcondition[0] = BitUtil.ToInt32Mask(pleft[0] > pright[0]);
                pcondition[1] = BitUtil.ToInt32Mask(pleft[1] > pright[1]);
                return condition.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<sbyte> GreaterThan_Base(Vector128<sbyte> left, Vector128<sbyte> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<sbyte> condition);
#else
                Vector128<sbyte> condition = default;
#endif // NET5_0_OR_GREATER
                sbyte* pcondition = (sbyte*)&condition;
                sbyte* pleft = (sbyte*)&left;
                sbyte* pright = (sbyte*)&right;
                pcondition[0] = (sbyte)BitUtil.ToInt32Mask(pleft[0] > pright[0]);
                pcondition[1] = (sbyte)BitUtil.ToInt32Mask(pleft[1] > pright[1]);
                pcondition[2] = (sbyte)BitUtil.ToInt32Mask(pleft[2] > pright[2]);
                pcondition[3] = (sbyte)BitUtil.ToInt32Mask(pleft[3] > pright[3]);
                pcondition[4] = (sbyte)BitUtil.ToInt32Mask(pleft[4] > pright[4]);
                pcondition[5] = (sbyte)BitUtil.ToInt32Mask(pleft[5] > pright[5]);
                pcondition[6] = (sbyte)BitUtil.ToInt32Mask(pleft[6] > pright[6]);
                pcondition[7] = (sbyte)BitUtil.ToInt32Mask(pleft[7] > pright[7]);
                pcondition[8] = (sbyte)BitUtil.ToInt32Mask(pleft[8] > pright[8]);
                pcondition[9] = (sbyte)BitUtil.ToInt32Mask(pleft[9] > pright[9]);
                pcondition[10] = (sbyte)BitUtil.ToInt32Mask(pleft[10] > pright[10]);
                pcondition[11] = (sbyte)BitUtil.ToInt32Mask(pleft[11] > pright[11]);
                pcondition[12] = (sbyte)BitUtil.ToInt32Mask(pleft[12] > pright[12]);
                pcondition[13] = (sbyte)BitUtil.ToInt32Mask(pleft[13] > pright[13]);
                pcondition[14] = (sbyte)BitUtil.ToInt32Mask(pleft[14] > pright[14]);
                pcondition[15] = (sbyte)BitUtil.ToInt32Mask(pleft[15] > pright[15]);
                return condition.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<byte> GreaterThan_Base(Vector128<byte> left, Vector128<byte> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<sbyte> condition);
#else
                Vector128<sbyte> condition = default;
#endif // NET5_0_OR_GREATER
                sbyte* pcondition = (sbyte*)&condition;
                byte* pleft = (byte*)&left;
                byte* pright = (byte*)&right;
                pcondition[0] = (sbyte)BitUtil.ToInt32Mask(pleft[0] > pright[0]);
                pcondition[1] = (sbyte)BitUtil.ToInt32Mask(pleft[1] > pright[1]);
                pcondition[2] = (sbyte)BitUtil.ToInt32Mask(pleft[2] > pright[2]);
                pcondition[3] = (sbyte)BitUtil.ToInt32Mask(pleft[3] > pright[3]);
                pcondition[4] = (sbyte)BitUtil.ToInt32Mask(pleft[4] > pright[4]);
                pcondition[5] = (sbyte)BitUtil.ToInt32Mask(pleft[5] > pright[5]);
                pcondition[6] = (sbyte)BitUtil.ToInt32Mask(pleft[6] > pright[6]);
                pcondition[7] = (sbyte)BitUtil.ToInt32Mask(pleft[7] > pright[7]);
                pcondition[8] = (sbyte)BitUtil.ToInt32Mask(pleft[8] > pright[8]);
                pcondition[9] = (sbyte)BitUtil.ToInt32Mask(pleft[9] > pright[9]);
                pcondition[10] = (sbyte)BitUtil.ToInt32Mask(pleft[10] > pright[10]);
                pcondition[11] = (sbyte)BitUtil.ToInt32Mask(pleft[11] > pright[11]);
                pcondition[12] = (sbyte)BitUtil.ToInt32Mask(pleft[12] > pright[12]);
                pcondition[13] = (sbyte)BitUtil.ToInt32Mask(pleft[13] > pright[13]);
                pcondition[14] = (sbyte)BitUtil.ToInt32Mask(pleft[14] > pright[14]);
                pcondition[15] = (sbyte)BitUtil.ToInt32Mask(pleft[15] > pright[15]);
                return condition.AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<short> GreaterThan_Base(Vector128<short> left, Vector128<short> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<short> condition);
#else
                Vector128<short> condition = default;
#endif // NET5_0_OR_GREATER
                short* pcondition = (short*)&condition;
                short* pleft = (short*)&left;
                short* pright = (short*)&right;
                pcondition[0] = (short)BitUtil.ToInt32Mask(pleft[0] > pright[0]);
                pcondition[1] = (short)BitUtil.ToInt32Mask(pleft[1] > pright[1]);
                pcondition[2] = (short)BitUtil.ToInt32Mask(pleft[2] > pright[2]);
                pcondition[3] = (short)BitUtil.ToInt32Mask(pleft[3] > pright[3]);
                pcondition[4] = (short)BitUtil.ToInt32Mask(pleft[4] > pright[4]);
                pcondition[5] = (short)BitUtil.ToInt32Mask(pleft[5] > pright[5]);
                pcondition[6] = (short)BitUtil.ToInt32Mask(pleft[6] > pright[6]);
                pcondition[7] = (short)BitUtil.ToInt32Mask(pleft[7] > pright[7]);
                return condition.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<ushort> GreaterThan_Base(Vector128<ushort> left, Vector128<ushort> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<short> condition);
#else
                Vector128<short> condition = default;
#endif // NET5_0_OR_GREATER
                short* pcondition = (short*)&condition;
                ushort* pleft = (ushort*)&left;
                ushort* pright = (ushort*)&right;
                pcondition[0] = (short)BitUtil.ToInt32Mask(pleft[0] > pright[0]);
                pcondition[1] = (short)BitUtil.ToInt32Mask(pleft[1] > pright[1]);
                pcondition[2] = (short)BitUtil.ToInt32Mask(pleft[2] > pright[2]);
                pcondition[3] = (short)BitUtil.ToInt32Mask(pleft[3] > pright[3]);
                pcondition[4] = (short)BitUtil.ToInt32Mask(pleft[4] > pright[4]);
                pcondition[5] = (short)BitUtil.ToInt32Mask(pleft[5] > pright[5]);
                pcondition[6] = (short)BitUtil.ToInt32Mask(pleft[6] > pright[6]);
                pcondition[7] = (short)BitUtil.ToInt32Mask(pleft[7] > pright[7]);
                return condition.AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<int> GreaterThan_Base(Vector128<int> left, Vector128<int> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<int> condition);
#else
                Vector128<int> condition = default;
#endif // NET5_0_OR_GREATER
                int* pcondition = (int*)&condition;
                int* pleft = (int*)&left;
                int* pright = (int*)&right;
                pcondition[0] = BitUtil.ToInt32Mask(pleft[0] > pright[0]);
                pcondition[1] = BitUtil.ToInt32Mask(pleft[1] > pright[1]);
                pcondition[2] = BitUtil.ToInt32Mask(pleft[2] > pright[2]);
                pcondition[3] = BitUtil.ToInt32Mask(pleft[3] > pright[3]);
                return condition.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<uint> GreaterThan_Base(Vector128<uint> left, Vector128<uint> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<int> condition);
#else
                Vector128<int> condition = default;
#endif // NET5_0_OR_GREATER
                int* pcondition = (int*)&condition;
                uint* pleft = (uint*)&left;
                uint* pright = (uint*)&right;
                pcondition[0] = BitUtil.ToInt32Mask(pleft[0] > pright[0]);
                pcondition[1] = BitUtil.ToInt32Mask(pleft[1] > pright[1]);
                pcondition[2] = BitUtil.ToInt32Mask(pleft[2] > pright[2]);
                pcondition[3] = BitUtil.ToInt32Mask(pleft[3] > pright[3]);
                return condition.AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<long> GreaterThan_Base(Vector128<long> left, Vector128<long> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<long> condition);
#else
                Vector128<long> condition = default;
#endif // NET5_0_OR_GREATER
                long* pcondition = (long*)&condition;
                long* pleft = (long*)&left;
                long* pright = (long*)&right;
                pcondition[0] = BitUtil.ToInt32Mask(pleft[0] > pright[0]);
                pcondition[1] = BitUtil.ToInt32Mask(pleft[1] > pright[1]);
                return condition;
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<ulong> GreaterThan_Base(Vector128<ulong> left, Vector128<ulong> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<long> condition);
#else
                Vector128<long> condition = default;
#endif // NET5_0_OR_GREATER
                long* pcondition = (long*)&condition;
                ulong* pleft = (ulong*)&left;
                ulong* pright = (ulong*)&right;
                pcondition[0] = BitUtil.ToInt32Mask(pleft[0] > pright[0]);
                pcondition[1] = BitUtil.ToInt32Mask(pleft[1] > pright[1]);
                return condition.AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits128.LessThan_AcceleratedTypes"/>
            public static TypeCodeFlags LessThan_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> LessThan(Vector128<float> left, Vector128<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.LessThan(left, right);
#else
                return LessThan_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> LessThan(Vector128<double> left, Vector128<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.LessThan(left, right);
#else
                return LessThan_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> LessThan(Vector128<sbyte> left, Vector128<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.LessThan(left, right);
#else
                return LessThan_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> LessThan(Vector128<byte> left, Vector128<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.LessThan(left, right);
#else
                return LessThan_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> LessThan(Vector128<short> left, Vector128<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.LessThan(left, right);
#else
                return LessThan_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> LessThan(Vector128<ushort> left, Vector128<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.LessThan(left, right);
#else
                return LessThan_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> LessThan(Vector128<int> left, Vector128<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.LessThan(left, right);
#else
                return LessThan_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> LessThan(Vector128<uint> left, Vector128<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.LessThan(left, right);
#else
                return LessThan_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> LessThan(Vector128<long> left, Vector128<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.LessThan(left, right);
#else
                return LessThan_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> LessThan(Vector128<ulong> left, Vector128<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.LessThan(left, right);
#else
                return LessThan_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<float> LessThan_Base(Vector128<float> left, Vector128<float> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<int> condition);
#else
                Vector128<int> condition = default;
#endif // NET5_0_OR_GREATER
                int* pcondition = (int*)&condition;
                float* pleft = (float*)&left;
                float* pright = (float*)&right;
                pcondition[0] = BitUtil.ToInt32Mask(pleft[0] < pright[0]);
                pcondition[1] = BitUtil.ToInt32Mask(pleft[1] < pright[1]);
                pcondition[2] = BitUtil.ToInt32Mask(pleft[2] < pright[2]);
                pcondition[3] = BitUtil.ToInt32Mask(pleft[3] < pright[3]);
                return condition.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<double> LessThan_Base(Vector128<double> left, Vector128<double> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<long> condition);
#else
                Vector128<long> condition = default;
#endif // NET5_0_OR_GREATER
                long* pcondition = (long*)&condition;
                double* pleft = (double*)&left;
                double* pright = (double*)&right;
                pcondition[0] = BitUtil.ToInt32Mask(pleft[0] < pright[0]);
                pcondition[1] = BitUtil.ToInt32Mask(pleft[1] < pright[1]);
                return condition.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<sbyte> LessThan_Base(Vector128<sbyte> left, Vector128<sbyte> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<sbyte> condition);
#else
                Vector128<sbyte> condition = default;
#endif // NET5_0_OR_GREATER
                sbyte* pcondition = (sbyte*)&condition;
                sbyte* pleft = (sbyte*)&left;
                sbyte* pright = (sbyte*)&right;
                pcondition[0] = (sbyte)BitUtil.ToInt32Mask(pleft[0] < pright[0]);
                pcondition[1] = (sbyte)BitUtil.ToInt32Mask(pleft[1] < pright[1]);
                pcondition[2] = (sbyte)BitUtil.ToInt32Mask(pleft[2] < pright[2]);
                pcondition[3] = (sbyte)BitUtil.ToInt32Mask(pleft[3] < pright[3]);
                pcondition[4] = (sbyte)BitUtil.ToInt32Mask(pleft[4] < pright[4]);
                pcondition[5] = (sbyte)BitUtil.ToInt32Mask(pleft[5] < pright[5]);
                pcondition[6] = (sbyte)BitUtil.ToInt32Mask(pleft[6] < pright[6]);
                pcondition[7] = (sbyte)BitUtil.ToInt32Mask(pleft[7] < pright[7]);
                pcondition[8] = (sbyte)BitUtil.ToInt32Mask(pleft[8] < pright[8]);
                pcondition[9] = (sbyte)BitUtil.ToInt32Mask(pleft[9] < pright[9]);
                pcondition[10] = (sbyte)BitUtil.ToInt32Mask(pleft[10] < pright[10]);
                pcondition[11] = (sbyte)BitUtil.ToInt32Mask(pleft[11] < pright[11]);
                pcondition[12] = (sbyte)BitUtil.ToInt32Mask(pleft[12] < pright[12]);
                pcondition[13] = (sbyte)BitUtil.ToInt32Mask(pleft[13] < pright[13]);
                pcondition[14] = (sbyte)BitUtil.ToInt32Mask(pleft[14] < pright[14]);
                pcondition[15] = (sbyte)BitUtil.ToInt32Mask(pleft[15] < pright[15]);
                return condition.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<byte> LessThan_Base(Vector128<byte> left, Vector128<byte> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<sbyte> condition);
#else
                Vector128<sbyte> condition = default;
#endif // NET5_0_OR_GREATER
                sbyte* pcondition = (sbyte*)&condition;
                byte* pleft = (byte*)&left;
                byte* pright = (byte*)&right;
                pcondition[0] = (sbyte)BitUtil.ToInt32Mask(pleft[0] < pright[0]);
                pcondition[1] = (sbyte)BitUtil.ToInt32Mask(pleft[1] < pright[1]);
                pcondition[2] = (sbyte)BitUtil.ToInt32Mask(pleft[2] < pright[2]);
                pcondition[3] = (sbyte)BitUtil.ToInt32Mask(pleft[3] < pright[3]);
                pcondition[4] = (sbyte)BitUtil.ToInt32Mask(pleft[4] < pright[4]);
                pcondition[5] = (sbyte)BitUtil.ToInt32Mask(pleft[5] < pright[5]);
                pcondition[6] = (sbyte)BitUtil.ToInt32Mask(pleft[6] < pright[6]);
                pcondition[7] = (sbyte)BitUtil.ToInt32Mask(pleft[7] < pright[7]);
                pcondition[8] = (sbyte)BitUtil.ToInt32Mask(pleft[8] < pright[8]);
                pcondition[9] = (sbyte)BitUtil.ToInt32Mask(pleft[9] < pright[9]);
                pcondition[10] = (sbyte)BitUtil.ToInt32Mask(pleft[10] < pright[10]);
                pcondition[11] = (sbyte)BitUtil.ToInt32Mask(pleft[11] < pright[11]);
                pcondition[12] = (sbyte)BitUtil.ToInt32Mask(pleft[12] < pright[12]);
                pcondition[13] = (sbyte)BitUtil.ToInt32Mask(pleft[13] < pright[13]);
                pcondition[14] = (sbyte)BitUtil.ToInt32Mask(pleft[14] < pright[14]);
                pcondition[15] = (sbyte)BitUtil.ToInt32Mask(pleft[15] < pright[15]);
                return condition.AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<short> LessThan_Base(Vector128<short> left, Vector128<short> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<short> condition);
#else
                Vector128<short> condition = default;
#endif // NET5_0_OR_GREATER
                short* pcondition = (short*)&condition;
                short* pleft = (short*)&left;
                short* pright = (short*)&right;
                pcondition[0] = (short)BitUtil.ToInt32Mask(pleft[0] < pright[0]);
                pcondition[1] = (short)BitUtil.ToInt32Mask(pleft[1] < pright[1]);
                pcondition[2] = (short)BitUtil.ToInt32Mask(pleft[2] < pright[2]);
                pcondition[3] = (short)BitUtil.ToInt32Mask(pleft[3] < pright[3]);
                pcondition[4] = (short)BitUtil.ToInt32Mask(pleft[4] < pright[4]);
                pcondition[5] = (short)BitUtil.ToInt32Mask(pleft[5] < pright[5]);
                pcondition[6] = (short)BitUtil.ToInt32Mask(pleft[6] < pright[6]);
                pcondition[7] = (short)BitUtil.ToInt32Mask(pleft[7] < pright[7]);
                return condition.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<ushort> LessThan_Base(Vector128<ushort> left, Vector128<ushort> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<short> condition);
#else
                Vector128<short> condition = default;
#endif // NET5_0_OR_GREATER
                short* pcondition = (short*)&condition;
                ushort* pleft = (ushort*)&left;
                ushort* pright = (ushort*)&right;
                pcondition[0] = (short)BitUtil.ToInt32Mask(pleft[0] < pright[0]);
                pcondition[1] = (short)BitUtil.ToInt32Mask(pleft[1] < pright[1]);
                pcondition[2] = (short)BitUtil.ToInt32Mask(pleft[2] < pright[2]);
                pcondition[3] = (short)BitUtil.ToInt32Mask(pleft[3] < pright[3]);
                pcondition[4] = (short)BitUtil.ToInt32Mask(pleft[4] < pright[4]);
                pcondition[5] = (short)BitUtil.ToInt32Mask(pleft[5] < pright[5]);
                pcondition[6] = (short)BitUtil.ToInt32Mask(pleft[6] < pright[6]);
                pcondition[7] = (short)BitUtil.ToInt32Mask(pleft[7] < pright[7]);
                return condition.AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<int> LessThan_Base(Vector128<int> left, Vector128<int> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<int> condition);
#else
                Vector128<int> condition = default;
#endif // NET5_0_OR_GREATER
                int* pcondition = (int*)&condition;
                int* pleft = (int*)&left;
                int* pright = (int*)&right;
                pcondition[0] = BitUtil.ToInt32Mask(pleft[0] < pright[0]);
                pcondition[1] = BitUtil.ToInt32Mask(pleft[1] < pright[1]);
                pcondition[2] = BitUtil.ToInt32Mask(pleft[2] < pright[2]);
                pcondition[3] = BitUtil.ToInt32Mask(pleft[3] < pright[3]);
                return condition.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<uint> LessThan_Base(Vector128<uint> left, Vector128<uint> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<int> condition);
#else
                Vector128<int> condition = default;
#endif // NET5_0_OR_GREATER
                int* pcondition = (int*)&condition;
                uint* pleft = (uint*)&left;
                uint* pright = (uint*)&right;
                pcondition[0] = BitUtil.ToInt32Mask(pleft[0] < pright[0]);
                pcondition[1] = BitUtil.ToInt32Mask(pleft[1] < pright[1]);
                pcondition[2] = BitUtil.ToInt32Mask(pleft[2] < pright[2]);
                pcondition[3] = BitUtil.ToInt32Mask(pleft[3] < pright[3]);
                return condition.AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<long> LessThan_Base(Vector128<long> left, Vector128<long> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<long> condition);
#else
                Vector128<long> condition = default;
#endif // NET5_0_OR_GREATER
                long* pcondition = (long*)&condition;
                long* pleft = (long*)&left;
                long* pright = (long*)&right;
                pcondition[0] = BitUtil.ToInt32Mask(pleft[0] < pright[0]);
                pcondition[1] = BitUtil.ToInt32Mask(pleft[1] < pright[1]);
                return condition;
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<ulong> LessThan_Base(Vector128<ulong> left, Vector128<ulong> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<long> condition);
#else
                Vector128<long> condition = default;
#endif // NET5_0_OR_GREATER
                long* pcondition = (long*)&condition;
                ulong* pleft = (ulong*)&left;
                ulong* pright = (ulong*)&right;
                pcondition[0] = BitUtil.ToInt32Mask(pleft[0] < pright[0]);
                pcondition[1] = BitUtil.ToInt32Mask(pleft[1] < pright[1]);
                return condition.AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits128.Max_AcceleratedTypes"/>
            public static TypeCodeFlags Max_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Max(Vector128<float> left, Vector128<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Max(Vector128<double> left, Vector128<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Max(Vector128<sbyte> left, Vector128<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Max(Vector128<byte> left, Vector128<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Max(Vector128<short> left, Vector128<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Max(Vector128<ushort> left, Vector128<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Max(Vector128<int> left, Vector128<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Max(Vector128<uint> left, Vector128<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Max(Vector128<long> left, Vector128<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Max(Vector128<ulong> left, Vector128<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<float> Max_Conditional(Vector128<float> left, Vector128<float> right) {
                Vector128<float> condition = GreaterThan(left, right);
                Vector128<float> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<double> Max_Conditional(Vector128<double> left, Vector128<double> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<long> rt);
#else
                Vector128<long> rt = default;
#endif // NET5_0_OR_GREATER
                double* pleft = (double*)&left;
                double* pright = (double*)&right;
                long* q = (long*)&rt;
                long condition0 = BitUtil.ToInt32Mask(pleft[0] > pright[0]);
                long condition1 = BitUtil.ToInt32Mask(pleft[1] > pright[1]);
                // result = (left & condition) | (right & ~condition);
                q[0] = (BitUtil.DoubleToInt64Bits(pleft[0]) & condition0) | (BitUtil.DoubleToInt64Bits(pright[0]) & ~condition0);
                q[1] = (BitUtil.DoubleToInt64Bits(pleft[1]) & condition1) | (BitUtil.DoubleToInt64Bits(pright[1]) & ~condition1);
                return rt.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<sbyte> Max_Conditional(Vector128<sbyte> left, Vector128<sbyte> right) {
                Vector128<sbyte> condition = GreaterThan(left, right);
                Vector128<sbyte> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<byte> Max_Conditional(Vector128<byte> left, Vector128<byte> right) {
                Vector128<byte> condition = GreaterThan(left, right);
                Vector128<byte> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<short> Max_Conditional(Vector128<short> left, Vector128<short> right) {
                Vector128<short> condition = GreaterThan(left, right);
                Vector128<short> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<ushort> Max_Conditional(Vector128<ushort> left, Vector128<ushort> right) {
                Vector128<ushort> condition = GreaterThan(left, right);
                Vector128<ushort> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<int> Max_Conditional(Vector128<int> left, Vector128<int> right) {
                Vector128<int> condition = GreaterThan(left, right);
                Vector128<int> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<uint> Max_Conditional(Vector128<uint> left, Vector128<uint> right) {
                Vector128<uint> condition = GreaterThan(left, right);
                Vector128<uint> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<long> Max_Conditional(Vector128<long> left, Vector128<long> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<long> rt);
#else
                Vector128<long> rt = default;
#endif // NET5_0_OR_GREATER
                long* pleft = (long*)&left;
                long* pright = (long*)&right;
                long* q = (long*)&rt;
                long condition0 = BitUtil.ToInt32Mask(pleft[0] > pright[0]);
                long condition1 = BitUtil.ToInt32Mask(pleft[1] > pright[1]);
                // result = (left & condition) | (right & ~condition);
                q[0] = ((pleft[0]) & condition0) | ((pright[0]) & ~condition0);
                q[1] = ((pleft[1]) & condition1) | ((pright[1]) & ~condition1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<ulong> Max_Conditional(Vector128<ulong> left, Vector128<ulong> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<long> rt);
#else
                Vector128<long> rt = default;
#endif // NET5_0_OR_GREATER
                ulong* pleft = (ulong*)&left;
                ulong* pright = (ulong*)&right;
                long* q = (long*)&rt;
                long condition0 = BitUtil.ToInt32Mask(pleft[0] > pright[0]);
                long condition1 = BitUtil.ToInt32Mask(pleft[1] > pright[1]);
                // result = (left & condition) | (right & ~condition);
                q[0] = ((long)(pleft[0]) & condition0) | ((long)(pright[0]) & ~condition0);
                q[1] = ((long)(pleft[1]) & condition1) | ((long)(pright[1]) & ~condition1);
                return rt.AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits128.Min_AcceleratedTypes"/>
            public static TypeCodeFlags Min_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Min(Vector128<float> left, Vector128<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Min(Vector128<double> left, Vector128<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Min(Vector128<sbyte> left, Vector128<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Min(Vector128<byte> left, Vector128<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Min(Vector128<short> left, Vector128<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Min(Vector128<ushort> left, Vector128<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Min(Vector128<int> left, Vector128<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Min(Vector128<uint> left, Vector128<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Min(Vector128<long> left, Vector128<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Min(Vector128<ulong> left, Vector128<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<float> Min_Conditional(Vector128<float> left, Vector128<float> right) {
                Vector128<float> condition = LessThan(left, right);
                Vector128<float> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<double> Min_Conditional(Vector128<double> left, Vector128<double> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<long> rt);
#else
                Vector128<long> rt = default;
#endif // NET5_0_OR_GREATER
                double* pleft = (double*)&left;
                double* pright = (double*)&right;
                long* q = (long*)&rt;
                long condition0 = BitUtil.ToInt32Mask(pleft[0] < pright[0]);
                long condition1 = BitUtil.ToInt32Mask(pleft[1] < pright[1]);
                // result = (left & condition) | (right & ~condition);
                q[0] = (BitUtil.DoubleToInt64Bits(pleft[0]) & condition0) | (BitUtil.DoubleToInt64Bits(pright[0]) & ~condition0);
                q[1] = (BitUtil.DoubleToInt64Bits(pleft[1]) & condition1) | (BitUtil.DoubleToInt64Bits(pright[1]) & ~condition1);
                return rt.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<sbyte> Min_Conditional(Vector128<sbyte> left, Vector128<sbyte> right) {
                Vector128<sbyte> condition = LessThan(left, right);
                Vector128<sbyte> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<byte> Min_Conditional(Vector128<byte> left, Vector128<byte> right) {
                Vector128<byte> condition = LessThan(left, right);
                Vector128<byte> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<short> Min_Conditional(Vector128<short> left, Vector128<short> right) {
                Vector128<short> condition = LessThan(left, right);
                Vector128<short> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<ushort> Min_Conditional(Vector128<ushort> left, Vector128<ushort> right) {
                Vector128<ushort> condition = LessThan(left, right);
                Vector128<ushort> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<int> Min_Conditional(Vector128<int> left, Vector128<int> right) {
                Vector128<int> condition = LessThan(left, right);
                Vector128<int> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<uint> Min_Conditional(Vector128<uint> left, Vector128<uint> right) {
                Vector128<uint> condition = LessThan(left, right);
                Vector128<uint> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<long> Min_Conditional(Vector128<long> left, Vector128<long> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<long> rt);
#else
                Vector128<long> rt = default;
#endif // NET5_0_OR_GREATER
                long* pleft = (long*)&left;
                long* pright = (long*)&right;
                long* q = (long*)&rt;
                long condition0 = BitUtil.ToInt32Mask(pleft[0] < pright[0]);
                long condition1 = BitUtil.ToInt32Mask(pleft[1] < pright[1]);
                // result = (left & condition) | (right & ~condition);
                q[0] = ((pleft[0]) & condition0) | ((pright[0]) & ~condition0);
                q[1] = ((pleft[1]) & condition1) | ((pright[1]) & ~condition1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<ulong> Min_Conditional(Vector128<ulong> left, Vector128<ulong> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<long> rt);
#else
                Vector128<long> rt = default;
#endif // NET5_0_OR_GREATER
                ulong* pleft = (ulong*)&left;
                ulong* pright = (ulong*)&right;
                long* q = (long*)&rt;
                long condition0 = BitUtil.ToInt32Mask(pleft[0] < pright[0]);
                long condition1 = BitUtil.ToInt32Mask(pleft[1] < pright[1]);
                // result = (left & condition) | (right & ~condition);
                q[0] = ((long)(pleft[0]) & condition0) | ((long)(pright[0]) & ~condition0);
                q[1] = ((long)(pleft[1]) & condition1) | ((long)(pright[1]) & ~condition1);
                return rt.AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits128.Negate_AcceleratedTypes"/>
            public static TypeCodeFlags Negate_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Negate(Vector128<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Negate(value);
#else
                return Negate_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Negate(Vector128<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Negate(value);
#else
                return Negate_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Negate(Vector128<sbyte> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Negate(value);
#else
                return Negate_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Negate(Vector128<short> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Negate(value);
#else
                return Negate_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Negate(Vector128<int> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Negate(value);
#else
                return Negate_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Negate(Vector128<long> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Negate(value);
#else
                return Negate_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<float> Negate_Base(Vector128<float> value) {
                Vector128<float> rt = value;
                float* p = (float*)&rt;
                p[0] = -p[0];
                p[1] = -p[1];
                p[2] = -p[2];
                p[3] = -p[3];
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<double> Negate_Base(Vector128<double> value) {
                Vector128<double> rt = value;
                double* p = (double*)&rt;
                p[0] = -p[0];
                p[1] = -p[1];
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<sbyte> Negate_Base(Vector128<sbyte> value) {
                Vector128<sbyte> rt = value;
                sbyte* p = (sbyte*)&rt;
                p[0] = (sbyte)-p[0];
                p[1] = (sbyte)-p[1];
                p[2] = (sbyte)-p[2];
                p[3] = (sbyte)-p[3];
                p[4] = (sbyte)-p[4];
                p[5] = (sbyte)-p[5];
                p[6] = (sbyte)-p[6];
                p[7] = (sbyte)-p[7];
                p[8] = (sbyte)-p[8];
                p[9] = (sbyte)-p[9];
                p[10] = (sbyte)-p[10];
                p[11] = (sbyte)-p[11];
                p[12] = (sbyte)-p[12];
                p[13] = (sbyte)-p[13];
                p[14] = (sbyte)-p[14];
                p[15] = (sbyte)-p[15];
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<short> Negate_Base(Vector128<short> value) {
                Vector128<short> rt = value;
                short* p = (short*)&rt;
                p[0] = (short)-p[0];
                p[1] = (short)-p[1];
                p[2] = (short)-p[2];
                p[3] = (short)-p[3];
                p[4] = (short)-p[4];
                p[5] = (short)-p[5];
                p[6] = (short)-p[6];
                p[7] = (short)-p[7];
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<int> Negate_Base(Vector128<int> value) {
                Vector128<int> rt = value;
                int* p = (int*)&rt;
                p[0] = -p[0];
                p[1] = -p[1];
                p[2] = -p[2];
                p[3] = -p[3];
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<long> Negate_Base(Vector128<long> value) {
                Vector128<long> rt = value;
                long* p = (long*)&rt;
                p[0] = -p[0];
                p[1] = -p[1];
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.OnesComplement_AcceleratedTypes"/>
            public static TypeCodeFlags OnesComplement_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.OnesComplement{T}(Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> OnesComplement<T>(Vector128<T> vector) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.OnesComplement(vector);
#else
                return OnesComplement_Base(vector);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.OnesComplement{T}(Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<T> OnesComplement_Base<T>(Vector128<T> vector) where T : struct {
                Vector128<T> rt = vector;
                ulong* p = (ulong*)&rt;
                p[0] = ~p[0];
                p[1] = ~p[1];
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.Subtract_AcceleratedTypes"/>
            public static TypeCodeFlags Subtract_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Subtract(Vector128<float> left, Vector128<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Subtract(left, right);
#else
                return Subtract_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Subtract(Vector128<double> left, Vector128<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Subtract(left, right);
#else
                return Subtract_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Subtract(Vector128<sbyte> left, Vector128<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Subtract(left, right);
#else
                return Subtract_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Subtract(Vector128<byte> left, Vector128<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Subtract(left, right);
#else
                return Subtract_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Subtract(Vector128<short> left, Vector128<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Subtract(left, right);
#else
                return Subtract_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Subtract(Vector128<ushort> left, Vector128<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Subtract(left, right);
#else
                return Subtract_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Subtract(Vector128<int> left, Vector128<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Subtract(left, right);
#else
                return Subtract_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Subtract(Vector128<uint> left, Vector128<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Subtract(left, right);
#else
                return Subtract_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Subtract(Vector128<long> left, Vector128<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Subtract(left, right);
#else
                return Subtract_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Subtract(Vector128<ulong> left, Vector128<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Subtract(left, right);
#else
                return Subtract_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<float> Subtract_Base(Vector128<float> left, Vector128<float> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<float> rt);
#else
                Vector128<float> rt = default;
#endif // NET5_0_OR_GREATER
                float* prt = (float*)&rt;
                float* pleft = (float*)&left;
                float* pright = (float*)&right;
                prt[0] = (pleft[0] - pright[0]);
                prt[1] = (pleft[1] - pright[1]);
                prt[2] = (pleft[2] - pright[2]);
                prt[3] = (pleft[3] - pright[3]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<double> Subtract_Base(Vector128<double> left, Vector128<double> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<double> rt);
#else
                Vector128<double> rt = default;
#endif // NET5_0_OR_GREATER
                double* prt = (double*)&rt;
                double* pleft = (double*)&left;
                double* pright = (double*)&right;
                prt[0] = (pleft[0] - pright[0]);
                prt[1] = (pleft[1] - pright[1]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<sbyte> Subtract_Base(Vector128<sbyte> left, Vector128<sbyte> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<sbyte> rt);
#else
                Vector128<sbyte> rt = default;
#endif // NET5_0_OR_GREATER
                sbyte* prt = (sbyte*)&rt;
                sbyte* pleft = (sbyte*)&left;
                sbyte* pright = (sbyte*)&right;
                prt[0] = (sbyte)(pleft[0] - pright[0]);
                prt[1] = (sbyte)(pleft[1] - pright[1]);
                prt[2] = (sbyte)(pleft[2] - pright[2]);
                prt[3] = (sbyte)(pleft[3] - pright[3]);
                prt[4] = (sbyte)(pleft[4] - pright[4]);
                prt[5] = (sbyte)(pleft[5] - pright[5]);
                prt[6] = (sbyte)(pleft[6] - pright[6]);
                prt[7] = (sbyte)(pleft[7] - pright[7]);
                prt[8] = (sbyte)(pleft[8] - pright[8]);
                prt[9] = (sbyte)(pleft[9] - pright[9]);
                prt[10] = (sbyte)(pleft[10] - pright[10]);
                prt[11] = (sbyte)(pleft[11] - pright[11]);
                prt[12] = (sbyte)(pleft[12] - pright[12]);
                prt[13] = (sbyte)(pleft[13] - pright[13]);
                prt[14] = (sbyte)(pleft[14] - pright[14]);
                prt[15] = (sbyte)(pleft[15] - pright[15]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<byte> Subtract_Base(Vector128<byte> left, Vector128<byte> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<byte> rt);
#else
                Vector128<byte> rt = default;
#endif // NET5_0_OR_GREATER
                byte* prt = (byte*)&rt;
                byte* pleft = (byte*)&left;
                byte* pright = (byte*)&right;
                prt[0] = (byte)(pleft[0] - pright[0]);
                prt[1] = (byte)(pleft[1] - pright[1]);
                prt[2] = (byte)(pleft[2] - pright[2]);
                prt[3] = (byte)(pleft[3] - pright[3]);
                prt[4] = (byte)(pleft[4] - pright[4]);
                prt[5] = (byte)(pleft[5] - pright[5]);
                prt[6] = (byte)(pleft[6] - pright[6]);
                prt[7] = (byte)(pleft[7] - pright[7]);
                prt[8] = (byte)(pleft[8] - pright[8]);
                prt[9] = (byte)(pleft[9] - pright[9]);
                prt[10] = (byte)(pleft[10] - pright[10]);
                prt[11] = (byte)(pleft[11] - pright[11]);
                prt[12] = (byte)(pleft[12] - pright[12]);
                prt[13] = (byte)(pleft[13] - pright[13]);
                prt[14] = (byte)(pleft[14] - pright[14]);
                prt[15] = (byte)(pleft[15] - pright[15]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<short> Subtract_Base(Vector128<short> left, Vector128<short> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<short> rt);
#else
                Vector128<short> rt = default;
#endif // NET5_0_OR_GREATER
                short* prt = (short*)&rt;
                short* pleft = (short*)&left;
                short* pright = (short*)&right;
                prt[0] = (short)(pleft[0] - pright[0]);
                prt[1] = (short)(pleft[1] - pright[1]);
                prt[2] = (short)(pleft[2] - pright[2]);
                prt[3] = (short)(pleft[3] - pright[3]);
                prt[4] = (short)(pleft[4] - pright[4]);
                prt[5] = (short)(pleft[5] - pright[5]);
                prt[6] = (short)(pleft[6] - pright[6]);
                prt[7] = (short)(pleft[7] - pright[7]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<ushort> Subtract_Base(Vector128<ushort> left, Vector128<ushort> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<ushort> rt);
#else
                Vector128<ushort> rt = default;
#endif // NET5_0_OR_GREATER
                ushort* prt = (ushort*)&rt;
                ushort* pleft = (ushort*)&left;
                ushort* pright = (ushort*)&right;
                prt[0] = (ushort)(pleft[0] - pright[0]);
                prt[1] = (ushort)(pleft[1] - pright[1]);
                prt[2] = (ushort)(pleft[2] - pright[2]);
                prt[3] = (ushort)(pleft[3] - pright[3]);
                prt[4] = (ushort)(pleft[4] - pright[4]);
                prt[5] = (ushort)(pleft[5] - pright[5]);
                prt[6] = (ushort)(pleft[6] - pright[6]);
                prt[7] = (ushort)(pleft[7] - pright[7]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<int> Subtract_Base(Vector128<int> left, Vector128<int> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<int> rt);
#else
                Vector128<int> rt = default;
#endif // NET5_0_OR_GREATER
                int* prt = (int*)&rt;
                int* pleft = (int*)&left;
                int* pright = (int*)&right;
                prt[0] = (pleft[0] - pright[0]);
                prt[1] = (pleft[1] - pright[1]);
                prt[2] = (pleft[2] - pright[2]);
                prt[3] = (pleft[3] - pright[3]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<uint> Subtract_Base(Vector128<uint> left, Vector128<uint> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<uint> rt);
#else
                Vector128<uint> rt = default;
#endif // NET5_0_OR_GREATER
                uint* prt = (uint*)&rt;
                uint* pleft = (uint*)&left;
                uint* pright = (uint*)&right;
                prt[0] = (pleft[0] - pright[0]);
                prt[1] = (pleft[1] - pright[1]);
                prt[2] = (pleft[2] - pright[2]);
                prt[3] = (pleft[3] - pright[3]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<long> Subtract_Base(Vector128<long> left, Vector128<long> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<long> rt);
#else
                Vector128<long> rt = default;
#endif // NET5_0_OR_GREATER
                long* prt = (long*)&rt;
                long* pleft = (long*)&left;
                long* pright = (long*)&right;
                prt[0] = (pleft[0] - pright[0]);
                prt[1] = (pleft[1] - pright[1]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<ulong> Subtract_Base(Vector128<ulong> left, Vector128<ulong> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<ulong> rt);
#else
                Vector128<ulong> rt = default;
#endif // NET5_0_OR_GREATER
                ulong* prt = (ulong*)&rt;
                ulong* pleft = (ulong*)&left;
                ulong* pright = (ulong*)&right;
                prt[0] = (pleft[0] - pright[0]);
                prt[1] = (pleft[1] - pright[1]);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.Xor_AcceleratedTypes"/>
            public static TypeCodeFlags Xor_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Xor{T}(Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> Xor<T>(Vector128<T> left, Vector128<T> right) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Xor(left, right);
#else
                return Xor_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Xor{T}(Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<T> Xor_Base<T>(Vector128<T> left, Vector128<T> right) where T : struct {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector128<T> rt);
#else
                Vector128<T> rt = default;
#endif // NET5_0_OR_GREATER
                ulong* pleft = (ulong*)&left;
                ulong* pright = (ulong*)&right;
                ulong* q = (ulong*)&rt;
                // rt[i] := left[i] ^ right[i];
                q[0] = pleft[0] ^ pright[0];
                q[1] = pleft[1] ^ pright[1];
                return rt;
            }


#endif // NETCOREAPP3_0_OR_GREATER
        }
    }
}