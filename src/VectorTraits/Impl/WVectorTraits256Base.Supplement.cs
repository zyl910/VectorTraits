using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif

namespace Zyl.VectorTraits.Impl {
    partial class WVectorTraits256Base {

        partial class Statics {

#if NETCOREAPP3_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.Abs_AcceleratedTypes"/>
            public static TypeCodeFlags Abs_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Abs(Vector256<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Abs(value);
#else
                return Abs_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Abs(Vector256<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Abs(value);
#else
                return Abs_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Abs(Vector256<sbyte> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Abs(value);
#else
                return Abs_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Abs(Vector256<short> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Abs(value);
#else
                return Abs_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Abs(Vector256<int> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Abs(value);
#else
                return Abs_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> Abs(Vector256<long> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Abs(value);
#else
                return Abs_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<float> Abs_Base(Vector256<float> value) {
                Vector256<float> rt = value;
                float* p = (float*)&rt;
                p[0] = Math.Abs(p[0]);
                p[1] = Math.Abs(p[1]);
                p[2] = Math.Abs(p[2]);
                p[3] = Math.Abs(p[3]);
                p[4] = Math.Abs(p[4]);
                p[5] = Math.Abs(p[5]);
                p[6] = Math.Abs(p[6]);
                p[7] = Math.Abs(p[7]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<double> Abs_Base(Vector256<double> value) {
                Vector256<double> rt = value;
                double* p = (double*)&rt;
                p[0] = Math.Abs(p[0]);
                p[1] = Math.Abs(p[1]);
                p[2] = Math.Abs(p[2]);
                p[3] = Math.Abs(p[3]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<sbyte> Abs_Base(Vector256<sbyte> value) {
                Vector256<sbyte> rt = value;
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
                p[16] = BitUtil.Abs(p[16]);
                p[17] = BitUtil.Abs(p[17]);
                p[18] = BitUtil.Abs(p[18]);
                p[19] = BitUtil.Abs(p[19]);
                p[20] = BitUtil.Abs(p[20]);
                p[21] = BitUtil.Abs(p[21]);
                p[22] = BitUtil.Abs(p[22]);
                p[23] = BitUtil.Abs(p[23]);
                p[24] = BitUtil.Abs(p[24]);
                p[25] = BitUtil.Abs(p[25]);
                p[26] = BitUtil.Abs(p[26]);
                p[27] = BitUtil.Abs(p[27]);
                p[28] = BitUtil.Abs(p[28]);
                p[29] = BitUtil.Abs(p[29]);
                p[30] = BitUtil.Abs(p[30]);
                p[31] = BitUtil.Abs(p[31]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<short> Abs_Base(Vector256<short> value) {
                Vector256<short> rt = value;
                short* p = (short*)&rt;
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

            /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<int> Abs_Base(Vector256<int> value) {
                Vector256<int> rt = value;
                int* p = (int*)&rt;
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

            /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<long> Abs_Base(Vector256<long> value) {
                Vector256<long> rt = value;
                long* p = (long*)&rt;
                p[0] = BitUtil.Abs(p[0]);
                p[1] = BitUtil.Abs(p[1]);
                p[2] = BitUtil.Abs(p[2]);
                p[3] = BitUtil.Abs(p[3]);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.Add_AcceleratedTypes"/>
            public static TypeCodeFlags Add_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Add(Vector256<float> left, Vector256<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Add(left, right);
#else
                return Add_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Add(Vector256<double> left, Vector256<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Add(left, right);
#else
                return Add_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Add(Vector256<sbyte> left, Vector256<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Add(left, right);
#else
                return Add_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> Add(Vector256<byte> left, Vector256<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Add(left, right);
#else
                return Add_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Add(Vector256<short> left, Vector256<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Add(left, right);
#else
                return Add_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> Add(Vector256<ushort> left, Vector256<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Add(left, right);
#else
                return Add_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Add(Vector256<int> left, Vector256<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Add(left, right);
#else
                return Add_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> Add(Vector256<uint> left, Vector256<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Add(left, right);
#else
                return Add_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> Add(Vector256<long> left, Vector256<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Add(left, right);
#else
                return Add_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> Add(Vector256<ulong> left, Vector256<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Add(left, right);
#else
                return Add_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<float> Add_Base(Vector256<float> left, Vector256<float> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<float> rt);
#else
                Vector256<float> rt = default;
#endif // NET5_0_OR_GREATER
                float* prt = (float*)&rt;
                float* pleft = (float*)&left;
                float* pright = (float*)&right;
                prt[0] = (pleft[0] + pright[0]);
                prt[1] = (pleft[1] + pright[1]);
                prt[2] = (pleft[2] + pright[2]);
                prt[3] = (pleft[3] + pright[3]);
                prt[4] = (pleft[4] + pright[4]);
                prt[5] = (pleft[5] + pright[5]);
                prt[6] = (pleft[6] + pright[6]);
                prt[7] = (pleft[7] + pright[7]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<double> Add_Base(Vector256<double> left, Vector256<double> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<double> rt);
#else
                Vector256<double> rt = default;
#endif // NET5_0_OR_GREATER
                double* prt = (double*)&rt;
                double* pleft = (double*)&left;
                double* pright = (double*)&right;
                prt[0] = (pleft[0] + pright[0]);
                prt[1] = (pleft[1] + pright[1]);
                prt[2] = (pleft[2] + pright[2]);
                prt[3] = (pleft[3] + pright[3]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<sbyte> Add_Base(Vector256<sbyte> left, Vector256<sbyte> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<sbyte> rt);
#else
                Vector256<sbyte> rt = default;
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
                prt[16] = (sbyte)(pleft[16] + pright[16]);
                prt[17] = (sbyte)(pleft[17] + pright[17]);
                prt[18] = (sbyte)(pleft[18] + pright[18]);
                prt[19] = (sbyte)(pleft[19] + pright[19]);
                prt[20] = (sbyte)(pleft[20] + pright[20]);
                prt[21] = (sbyte)(pleft[21] + pright[21]);
                prt[22] = (sbyte)(pleft[22] + pright[22]);
                prt[23] = (sbyte)(pleft[23] + pright[23]);
                prt[24] = (sbyte)(pleft[24] + pright[24]);
                prt[25] = (sbyte)(pleft[25] + pright[25]);
                prt[26] = (sbyte)(pleft[26] + pright[26]);
                prt[27] = (sbyte)(pleft[27] + pright[27]);
                prt[28] = (sbyte)(pleft[28] + pright[28]);
                prt[29] = (sbyte)(pleft[29] + pright[29]);
                prt[30] = (sbyte)(pleft[30] + pright[30]);
                prt[31] = (sbyte)(pleft[31] + pright[31]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<byte> Add_Base(Vector256<byte> left, Vector256<byte> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<byte> rt);
#else
                Vector256<byte> rt = default;
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
                prt[16] = (byte)(pleft[16] + pright[16]);
                prt[17] = (byte)(pleft[17] + pright[17]);
                prt[18] = (byte)(pleft[18] + pright[18]);
                prt[19] = (byte)(pleft[19] + pright[19]);
                prt[20] = (byte)(pleft[20] + pright[20]);
                prt[21] = (byte)(pleft[21] + pright[21]);
                prt[22] = (byte)(pleft[22] + pright[22]);
                prt[23] = (byte)(pleft[23] + pright[23]);
                prt[24] = (byte)(pleft[24] + pright[24]);
                prt[25] = (byte)(pleft[25] + pright[25]);
                prt[26] = (byte)(pleft[26] + pright[26]);
                prt[27] = (byte)(pleft[27] + pright[27]);
                prt[28] = (byte)(pleft[28] + pright[28]);
                prt[29] = (byte)(pleft[29] + pright[29]);
                prt[30] = (byte)(pleft[30] + pright[30]);
                prt[31] = (byte)(pleft[31] + pright[31]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<short> Add_Base(Vector256<short> left, Vector256<short> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<short> rt);
#else
                Vector256<short> rt = default;
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
                prt[8] = (short)(pleft[8] + pright[8]);
                prt[9] = (short)(pleft[9] + pright[9]);
                prt[10] = (short)(pleft[10] + pright[10]);
                prt[11] = (short)(pleft[11] + pright[11]);
                prt[12] = (short)(pleft[12] + pright[12]);
                prt[13] = (short)(pleft[13] + pright[13]);
                prt[14] = (short)(pleft[14] + pright[14]);
                prt[15] = (short)(pleft[15] + pright[15]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<ushort> Add_Base(Vector256<ushort> left, Vector256<ushort> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<ushort> rt);
#else
                Vector256<ushort> rt = default;
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
                prt[8] = (ushort)(pleft[8] + pright[8]);
                prt[9] = (ushort)(pleft[9] + pright[9]);
                prt[10] = (ushort)(pleft[10] + pright[10]);
                prt[11] = (ushort)(pleft[11] + pright[11]);
                prt[12] = (ushort)(pleft[12] + pright[12]);
                prt[13] = (ushort)(pleft[13] + pright[13]);
                prt[14] = (ushort)(pleft[14] + pright[14]);
                prt[15] = (ushort)(pleft[15] + pright[15]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<int> Add_Base(Vector256<int> left, Vector256<int> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<int> rt);
#else
                Vector256<int> rt = default;
#endif // NET5_0_OR_GREATER
                int* prt = (int*)&rt;
                int* pleft = (int*)&left;
                int* pright = (int*)&right;
                prt[0] = (pleft[0] + pright[0]);
                prt[1] = (pleft[1] + pright[1]);
                prt[2] = (pleft[2] + pright[2]);
                prt[3] = (pleft[3] + pright[3]);
                prt[4] = (pleft[4] + pright[4]);
                prt[5] = (pleft[5] + pright[5]);
                prt[6] = (pleft[6] + pright[6]);
                prt[7] = (pleft[7] + pright[7]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<uint> Add_Base(Vector256<uint> left, Vector256<uint> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<uint> rt);
#else
                Vector256<uint> rt = default;
#endif // NET5_0_OR_GREATER
                uint* prt = (uint*)&rt;
                uint* pleft = (uint*)&left;
                uint* pright = (uint*)&right;
                prt[0] = (pleft[0] + pright[0]);
                prt[1] = (pleft[1] + pright[1]);
                prt[2] = (pleft[2] + pright[2]);
                prt[3] = (pleft[3] + pright[3]);
                prt[4] = (pleft[4] + pright[4]);
                prt[5] = (pleft[5] + pright[5]);
                prt[6] = (pleft[6] + pright[6]);
                prt[7] = (pleft[7] + pright[7]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<long> Add_Base(Vector256<long> left, Vector256<long> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<long> rt);
#else
                Vector256<long> rt = default;
#endif // NET5_0_OR_GREATER
                long* prt = (long*)&rt;
                long* pleft = (long*)&left;
                long* pright = (long*)&right;
                prt[0] = (pleft[0] + pright[0]);
                prt[1] = (pleft[1] + pright[1]);
                prt[2] = (pleft[2] + pright[2]);
                prt[3] = (pleft[3] + pright[3]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<ulong> Add_Base(Vector256<ulong> left, Vector256<ulong> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<ulong> rt);
#else
                Vector256<ulong> rt = default;
#endif // NET5_0_OR_GREATER
                ulong* prt = (ulong*)&rt;
                ulong* pleft = (ulong*)&left;
                ulong* pright = (ulong*)&right;
                prt[0] = (pleft[0] + pright[0]);
                prt[1] = (pleft[1] + pright[1]);
                prt[2] = (pleft[2] + pright[2]);
                prt[3] = (pleft[3] + pright[3]);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.AndNot_AcceleratedTypes"/>
            public static TypeCodeFlags AndNot_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.AndNot{T}(Vector256{T}, Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<T> AndNot<T>(Vector256<T> left, Vector256<T> right) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.AndNot(left, right);
#else
                return AndNot_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.AndNot{T}(Vector256{T}, Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<T> AndNot_Base<T>(Vector256<T> left, Vector256<T> right) where T : struct {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<T> rt);
#else
                Vector256<T> rt = default;
#endif // NET5_0_OR_GREATER
                ulong* pleft = (ulong*)&left;
                ulong* pright = (ulong*)&right;
                ulong* q = (ulong*)&rt;
                // rt[i] := left[i] & ~right[i];
                q[0] = pleft[0] & ~pright[0];
                q[1] = pleft[1] & ~pright[1];
                q[2] = pleft[2] & ~pright[2];
                q[3] = pleft[3] & ~pright[3];
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.BitwiseAnd_AcceleratedTypes"/>
            public static TypeCodeFlags BitwiseAnd_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.BitwiseAnd{T}(Vector256{T}, Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<T> BitwiseAnd<T>(Vector256<T> left, Vector256<T> right) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.BitwiseAnd(left, right);
#else
                return BitwiseAnd_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.BitwiseAnd{T}(Vector256{T}, Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<T> BitwiseAnd_Base<T>(Vector256<T> left, Vector256<T> right) where T : struct {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<T> rt);
#else
                Vector256<T> rt = default;
#endif // NET5_0_OR_GREATER
                ulong* pleft = (ulong*)&left;
                ulong* pright = (ulong*)&right;
                ulong* q = (ulong*)&rt;
                // rt[i] := left[i] & right[i];
                q[0] = pleft[0] & pright[0];
                q[1] = pleft[1] & pright[1];
                q[2] = pleft[2] & pright[2];
                q[3] = pleft[3] & pright[3];
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.BitwiseOr_AcceleratedTypes"/>
            public static TypeCodeFlags BitwiseOr_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.BitwiseOr{T}(Vector256{T}, Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<T> BitwiseOr<T>(Vector256<T> left, Vector256<T> right) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.BitwiseOr(left, right);
#else
                return BitwiseOr_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.BitwiseOr{T}(Vector256{T}, Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<T> BitwiseOr_Base<T>(Vector256<T> left, Vector256<T> right) where T : struct {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<T> rt);
#else
                Vector256<T> rt = default;
#endif // NET5_0_OR_GREATER
                ulong* pleft = (ulong*)&left;
                ulong* pright = (ulong*)&right;
                ulong* q = (ulong*)&rt;
                // rt[i] := left[i] | right[i];
                q[0] = pleft[0] | pright[0];
                q[1] = pleft[1] | pright[1];
                q[2] = pleft[2] | pright[2];
                q[3] = pleft[3] | pright[3];
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.ConditionalSelect_AcceleratedTypes"/>
            public static TypeCodeFlags ConditionalSelect_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.ConditionalSelect{T}(Vector256{T}, Vector256{T}, Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<T> ConditionalSelect<T>(Vector256<T> condition, Vector256<T> left, Vector256<T> right) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ConditionalSelect(condition, left, right);
#else
                return ConditionalSelect_Base(condition, left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            ///// <inheritdoc cref="IWVectorTraits256.ConditionalSelect(Vector256{int}, Vector256{float}, Vector256{float})"/>
            //[MethodImpl(MethodImplOptions.AggressiveInlining)]
            //public static Vector256<float> ConditionalSelect(Vector256<int> condition, Vector256<float> left, Vector256<float> right) {
            //    return ConditionalSelect<float>(condition.AsSingle(), left, right);
            //}

            ///// <inheritdoc cref="IWVectorTraits256.ConditionalSelect(Vector256{long}, Vector256{double}, Vector256{double})"/>
            //[MethodImpl(MethodImplOptions.AggressiveInlining)]
            //public static Vector256<double> ConditionalSelect(Vector256<long> condition, Vector256<double> left, Vector256<double> right) {
            //    return ConditionalSelect<double>(condition.AsDouble(), left, right);
            //}

            /// <inheritdoc cref="IWVectorTraits256.ConditionalSelect{T}(Vector256{T}, Vector256{T}, Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<T> ConditionalSelect_Base<T>(Vector256<T> condition, Vector256<T> left, Vector256<T> right) where T : struct {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<T> rt);
#else
                Vector256<T> rt = default;
#endif // NET5_0_OR_GREATER
                ulong* pcondition = (ulong*)&condition;
                ulong* pleft = (ulong*)&left;
                ulong* pright = (ulong*)&right;
                ulong* q = (ulong*)&rt;
                // result = (left & condition) | (right & ~condition);
                q[0] = (pleft[0] & pcondition[0]) | (pright[0] & ~pcondition[0]);
                q[1] = (pleft[1] & pcondition[1]) | (pright[1] & ~pcondition[1]);
                q[2] = (pleft[2] & pcondition[2]) | (pright[2] & ~pcondition[2]);
                q[3] = (pleft[3] & pcondition[3]) | (pright[3] & ~pcondition[3]);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.Divide_AcceleratedTypes"/>
            public static TypeCodeFlags Divide_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Double;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Divide(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Divide(Vector256<float> left, Vector256<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Divide(left, right);
#else
                return Divide_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Divide(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Divide(Vector256<double> left, Vector256<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Divide(left, right);
#else
                return Divide_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Divide(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<float> Divide_Base(Vector256<float> left, Vector256<float> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<float> rt);
#else
                Vector256<float> rt = default;
#endif // NET5_0_OR_GREATER
                float* prt = (float*)&rt;
                float* pleft = (float*)&left;
                float* pright = (float*)&right;
                prt[0] = (pleft[0] / pright[0]);
                prt[1] = (pleft[1] / pright[1]);
                prt[2] = (pleft[2] / pright[2]);
                prt[3] = (pleft[3] / pright[3]);
                prt[4] = (pleft[4] / pright[4]);
                prt[5] = (pleft[5] / pright[5]);
                prt[6] = (pleft[6] / pright[6]);
                prt[7] = (pleft[7] / pright[7]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Divide(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<double> Divide_Base(Vector256<double> left, Vector256<double> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<double> rt);
#else
                Vector256<double> rt = default;
#endif // NET5_0_OR_GREATER
                double* prt = (double*)&rt;
                double* pleft = (double*)&left;
                double* pright = (double*)&right;
                prt[0] = (pleft[0] / pright[0]);
                prt[1] = (pleft[1] / pright[1]);
                prt[2] = (pleft[2] / pright[2]);
                prt[3] = (pleft[3] / pright[3]);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.GreaterThan_AcceleratedTypes"/>
            public static TypeCodeFlags GreaterThan_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> GreaterThan(Vector256<float> left, Vector256<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.GreaterThan(left, right);
#else
                return GreaterThan_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> GreaterThan(Vector256<double> left, Vector256<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.GreaterThan(left, right);
#else
                return GreaterThan_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> GreaterThan(Vector256<sbyte> left, Vector256<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.GreaterThan(left, right);
#else
                return GreaterThan_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> GreaterThan(Vector256<byte> left, Vector256<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.GreaterThan(left, right);
#else
                return GreaterThan_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> GreaterThan(Vector256<short> left, Vector256<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.GreaterThan(left, right);
#else
                return GreaterThan_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> GreaterThan(Vector256<ushort> left, Vector256<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.GreaterThan(left, right);
#else
                return GreaterThan_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> GreaterThan(Vector256<int> left, Vector256<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.GreaterThan(left, right);
#else
                return GreaterThan_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> GreaterThan(Vector256<uint> left, Vector256<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.GreaterThan(left, right);
#else
                return GreaterThan_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> GreaterThan(Vector256<long> left, Vector256<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.GreaterThan(left, right);
#else
                return GreaterThan_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> GreaterThan(Vector256<ulong> left, Vector256<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.GreaterThan(left, right);
#else
                return GreaterThan_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<float> GreaterThan_Base(Vector256<float> left, Vector256<float> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<int> condition);
#else
                Vector256<int> condition = default;
#endif // NET5_0_OR_GREATER
                int* pcondition = (int*)&condition;
                float* pleft = (float*)&left;
                float* pright = (float*)&right;
                pcondition[0] = BitUtil.ToInt32Mask(pleft[0] > pright[0]);
                pcondition[1] = BitUtil.ToInt32Mask(pleft[1] > pright[1]);
                pcondition[2] = BitUtil.ToInt32Mask(pleft[2] > pright[2]);
                pcondition[3] = BitUtil.ToInt32Mask(pleft[3] > pright[3]);
                pcondition[4] = BitUtil.ToInt32Mask(pleft[4] > pright[4]);
                pcondition[5] = BitUtil.ToInt32Mask(pleft[5] > pright[5]);
                pcondition[6] = BitUtil.ToInt32Mask(pleft[6] > pright[6]);
                pcondition[7] = BitUtil.ToInt32Mask(pleft[7] > pright[7]);
                return condition.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<double> GreaterThan_Base(Vector256<double> left, Vector256<double> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<long> condition);
#else
                Vector256<long> condition = default;
#endif // NET5_0_OR_GREATER
                long* pcondition = (long*)&condition;
                double* pleft = (double*)&left;
                double* pright = (double*)&right;
                pcondition[0] = BitUtil.ToInt32Mask(pleft[0] > pright[0]);
                pcondition[1] = BitUtil.ToInt32Mask(pleft[1] > pright[1]);
                pcondition[2] = BitUtil.ToInt32Mask(pleft[2] > pright[2]);
                pcondition[3] = BitUtil.ToInt32Mask(pleft[3] > pright[3]);
                return condition.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<sbyte> GreaterThan_Base(Vector256<sbyte> left, Vector256<sbyte> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<sbyte> condition);
#else
                Vector256<sbyte> condition = default;
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
                pcondition[16] = (sbyte)BitUtil.ToInt32Mask(pleft[16] > pright[16]);
                pcondition[17] = (sbyte)BitUtil.ToInt32Mask(pleft[17] > pright[17]);
                pcondition[18] = (sbyte)BitUtil.ToInt32Mask(pleft[18] > pright[18]);
                pcondition[19] = (sbyte)BitUtil.ToInt32Mask(pleft[19] > pright[19]);
                pcondition[20] = (sbyte)BitUtil.ToInt32Mask(pleft[20] > pright[20]);
                pcondition[21] = (sbyte)BitUtil.ToInt32Mask(pleft[21] > pright[21]);
                pcondition[22] = (sbyte)BitUtil.ToInt32Mask(pleft[22] > pright[22]);
                pcondition[23] = (sbyte)BitUtil.ToInt32Mask(pleft[23] > pright[23]);
                pcondition[24] = (sbyte)BitUtil.ToInt32Mask(pleft[24] > pright[24]);
                pcondition[25] = (sbyte)BitUtil.ToInt32Mask(pleft[25] > pright[25]);
                pcondition[26] = (sbyte)BitUtil.ToInt32Mask(pleft[26] > pright[26]);
                pcondition[27] = (sbyte)BitUtil.ToInt32Mask(pleft[27] > pright[27]);
                pcondition[28] = (sbyte)BitUtil.ToInt32Mask(pleft[28] > pright[28]);
                pcondition[29] = (sbyte)BitUtil.ToInt32Mask(pleft[29] > pright[29]);
                pcondition[30] = (sbyte)BitUtil.ToInt32Mask(pleft[30] > pright[30]);
                pcondition[31] = (sbyte)BitUtil.ToInt32Mask(pleft[31] > pright[31]);
                return condition.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<byte> GreaterThan_Base(Vector256<byte> left, Vector256<byte> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<sbyte> condition);
#else
                Vector256<sbyte> condition = default;
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
                pcondition[16] = (sbyte)BitUtil.ToInt32Mask(pleft[16] > pright[16]);
                pcondition[17] = (sbyte)BitUtil.ToInt32Mask(pleft[17] > pright[17]);
                pcondition[18] = (sbyte)BitUtil.ToInt32Mask(pleft[18] > pright[18]);
                pcondition[19] = (sbyte)BitUtil.ToInt32Mask(pleft[19] > pright[19]);
                pcondition[20] = (sbyte)BitUtil.ToInt32Mask(pleft[20] > pright[20]);
                pcondition[21] = (sbyte)BitUtil.ToInt32Mask(pleft[21] > pright[21]);
                pcondition[22] = (sbyte)BitUtil.ToInt32Mask(pleft[22] > pright[22]);
                pcondition[23] = (sbyte)BitUtil.ToInt32Mask(pleft[23] > pright[23]);
                pcondition[24] = (sbyte)BitUtil.ToInt32Mask(pleft[24] > pright[24]);
                pcondition[25] = (sbyte)BitUtil.ToInt32Mask(pleft[25] > pright[25]);
                pcondition[26] = (sbyte)BitUtil.ToInt32Mask(pleft[26] > pright[26]);
                pcondition[27] = (sbyte)BitUtil.ToInt32Mask(pleft[27] > pright[27]);
                pcondition[28] = (sbyte)BitUtil.ToInt32Mask(pleft[28] > pright[28]);
                pcondition[29] = (sbyte)BitUtil.ToInt32Mask(pleft[29] > pright[29]);
                pcondition[30] = (sbyte)BitUtil.ToInt32Mask(pleft[30] > pright[30]);
                pcondition[31] = (sbyte)BitUtil.ToInt32Mask(pleft[31] > pright[31]);
                return condition.AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<short> GreaterThan_Base(Vector256<short> left, Vector256<short> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<short> condition);
#else
                Vector256<short> condition = default;
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
                pcondition[8] = (short)BitUtil.ToInt32Mask(pleft[8] > pright[8]);
                pcondition[9] = (short)BitUtil.ToInt32Mask(pleft[9] > pright[9]);
                pcondition[10] = (short)BitUtil.ToInt32Mask(pleft[10] > pright[10]);
                pcondition[11] = (short)BitUtil.ToInt32Mask(pleft[11] > pright[11]);
                pcondition[12] = (short)BitUtil.ToInt32Mask(pleft[12] > pright[12]);
                pcondition[13] = (short)BitUtil.ToInt32Mask(pleft[13] > pright[13]);
                pcondition[14] = (short)BitUtil.ToInt32Mask(pleft[14] > pright[14]);
                pcondition[15] = (short)BitUtil.ToInt32Mask(pleft[15] > pright[15]);
                return condition.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<ushort> GreaterThan_Base(Vector256<ushort> left, Vector256<ushort> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<short> condition);
#else
                Vector256<short> condition = default;
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
                pcondition[8] = (short)BitUtil.ToInt32Mask(pleft[8] > pright[8]);
                pcondition[9] = (short)BitUtil.ToInt32Mask(pleft[9] > pright[9]);
                pcondition[10] = (short)BitUtil.ToInt32Mask(pleft[10] > pright[10]);
                pcondition[11] = (short)BitUtil.ToInt32Mask(pleft[11] > pright[11]);
                pcondition[12] = (short)BitUtil.ToInt32Mask(pleft[12] > pright[12]);
                pcondition[13] = (short)BitUtil.ToInt32Mask(pleft[13] > pright[13]);
                pcondition[14] = (short)BitUtil.ToInt32Mask(pleft[14] > pright[14]);
                pcondition[15] = (short)BitUtil.ToInt32Mask(pleft[15] > pright[15]);
                return condition.AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<int> GreaterThan_Base(Vector256<int> left, Vector256<int> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<int> condition);
#else
                Vector256<int> condition = default;
#endif // NET5_0_OR_GREATER
                int* pcondition = (int*)&condition;
                int* pleft = (int*)&left;
                int* pright = (int*)&right;
                pcondition[0] = BitUtil.ToInt32Mask(pleft[0] > pright[0]);
                pcondition[1] = BitUtil.ToInt32Mask(pleft[1] > pright[1]);
                pcondition[2] = BitUtil.ToInt32Mask(pleft[2] > pright[2]);
                pcondition[3] = BitUtil.ToInt32Mask(pleft[3] > pright[3]);
                pcondition[4] = BitUtil.ToInt32Mask(pleft[4] > pright[4]);
                pcondition[5] = BitUtil.ToInt32Mask(pleft[5] > pright[5]);
                pcondition[6] = BitUtil.ToInt32Mask(pleft[6] > pright[6]);
                pcondition[7] = BitUtil.ToInt32Mask(pleft[7] > pright[7]);
                return condition.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<uint> GreaterThan_Base(Vector256<uint> left, Vector256<uint> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<int> condition);
#else
                Vector256<int> condition = default;
#endif // NET5_0_OR_GREATER
                int* pcondition = (int*)&condition;
                uint* pleft = (uint*)&left;
                uint* pright = (uint*)&right;
                pcondition[0] = BitUtil.ToInt32Mask(pleft[0] > pright[0]);
                pcondition[1] = BitUtil.ToInt32Mask(pleft[1] > pright[1]);
                pcondition[2] = BitUtil.ToInt32Mask(pleft[2] > pright[2]);
                pcondition[3] = BitUtil.ToInt32Mask(pleft[3] > pright[3]);
                pcondition[4] = BitUtil.ToInt32Mask(pleft[4] > pright[4]);
                pcondition[5] = BitUtil.ToInt32Mask(pleft[5] > pright[5]);
                pcondition[6] = BitUtil.ToInt32Mask(pleft[6] > pright[6]);
                pcondition[7] = BitUtil.ToInt32Mask(pleft[7] > pright[7]);
                return condition.AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<long> GreaterThan_Base(Vector256<long> left, Vector256<long> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<long> condition);
#else
                Vector256<long> condition = default;
#endif // NET5_0_OR_GREATER
                long* pcondition = (long*)&condition;
                long* pleft = (long*)&left;
                long* pright = (long*)&right;
                pcondition[0] = BitUtil.ToInt32Mask(pleft[0] > pright[0]);
                pcondition[1] = BitUtil.ToInt32Mask(pleft[1] > pright[1]);
                pcondition[2] = BitUtil.ToInt32Mask(pleft[2] > pright[2]);
                pcondition[3] = BitUtil.ToInt32Mask(pleft[3] > pright[3]);
                return condition;
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<ulong> GreaterThan_Base(Vector256<ulong> left, Vector256<ulong> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<long> condition);
#else
                Vector256<long> condition = default;
#endif // NET5_0_OR_GREATER
                long* pcondition = (long*)&condition;
                ulong* pleft = (ulong*)&left;
                ulong* pright = (ulong*)&right;
                pcondition[0] = BitUtil.ToInt32Mask(pleft[0] > pright[0]);
                pcondition[1] = BitUtil.ToInt32Mask(pleft[1] > pright[1]);
                pcondition[2] = BitUtil.ToInt32Mask(pleft[2] > pright[2]);
                pcondition[3] = BitUtil.ToInt32Mask(pleft[3] > pright[3]);
                return condition.AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits256.LessThan_AcceleratedTypes"/>
            public static TypeCodeFlags LessThan_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> LessThan(Vector256<float> left, Vector256<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.LessThan(left, right);
#else
                return LessThan_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> LessThan(Vector256<double> left, Vector256<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.LessThan(left, right);
#else
                return LessThan_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> LessThan(Vector256<sbyte> left, Vector256<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.LessThan(left, right);
#else
                return LessThan_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> LessThan(Vector256<byte> left, Vector256<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.LessThan(left, right);
#else
                return LessThan_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> LessThan(Vector256<short> left, Vector256<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.LessThan(left, right);
#else
                return LessThan_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> LessThan(Vector256<ushort> left, Vector256<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.LessThan(left, right);
#else
                return LessThan_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> LessThan(Vector256<int> left, Vector256<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.LessThan(left, right);
#else
                return LessThan_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> LessThan(Vector256<uint> left, Vector256<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.LessThan(left, right);
#else
                return LessThan_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> LessThan(Vector256<long> left, Vector256<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.LessThan(left, right);
#else
                return LessThan_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> LessThan(Vector256<ulong> left, Vector256<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.LessThan(left, right);
#else
                return LessThan_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<float> LessThan_Base(Vector256<float> left, Vector256<float> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<int> condition);
#else
                Vector256<int> condition = default;
#endif // NET5_0_OR_GREATER
                int* pcondition = (int*)&condition;
                float* pleft = (float*)&left;
                float* pright = (float*)&right;
                pcondition[0] = BitUtil.ToInt32Mask(pleft[0] < pright[0]);
                pcondition[1] = BitUtil.ToInt32Mask(pleft[1] < pright[1]);
                pcondition[2] = BitUtil.ToInt32Mask(pleft[2] < pright[2]);
                pcondition[3] = BitUtil.ToInt32Mask(pleft[3] < pright[3]);
                pcondition[4] = BitUtil.ToInt32Mask(pleft[4] < pright[4]);
                pcondition[5] = BitUtil.ToInt32Mask(pleft[5] < pright[5]);
                pcondition[6] = BitUtil.ToInt32Mask(pleft[6] < pright[6]);
                pcondition[7] = BitUtil.ToInt32Mask(pleft[7] < pright[7]);
                return condition.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<double> LessThan_Base(Vector256<double> left, Vector256<double> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<long> condition);
#else
                Vector256<long> condition = default;
#endif // NET5_0_OR_GREATER
                long* pcondition = (long*)&condition;
                double* pleft = (double*)&left;
                double* pright = (double*)&right;
                pcondition[0] = BitUtil.ToInt32Mask(pleft[0] < pright[0]);
                pcondition[1] = BitUtil.ToInt32Mask(pleft[1] < pright[1]);
                pcondition[2] = BitUtil.ToInt32Mask(pleft[2] < pright[2]);
                pcondition[3] = BitUtil.ToInt32Mask(pleft[3] < pright[3]);
                return condition.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<sbyte> LessThan_Base(Vector256<sbyte> left, Vector256<sbyte> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<sbyte> condition);
#else
                Vector256<sbyte> condition = default;
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
                pcondition[16] = (sbyte)BitUtil.ToInt32Mask(pleft[16] < pright[16]);
                pcondition[17] = (sbyte)BitUtil.ToInt32Mask(pleft[17] < pright[17]);
                pcondition[18] = (sbyte)BitUtil.ToInt32Mask(pleft[18] < pright[18]);
                pcondition[19] = (sbyte)BitUtil.ToInt32Mask(pleft[19] < pright[19]);
                pcondition[20] = (sbyte)BitUtil.ToInt32Mask(pleft[20] < pright[20]);
                pcondition[21] = (sbyte)BitUtil.ToInt32Mask(pleft[21] < pright[21]);
                pcondition[22] = (sbyte)BitUtil.ToInt32Mask(pleft[22] < pright[22]);
                pcondition[23] = (sbyte)BitUtil.ToInt32Mask(pleft[23] < pright[23]);
                pcondition[24] = (sbyte)BitUtil.ToInt32Mask(pleft[24] < pright[24]);
                pcondition[25] = (sbyte)BitUtil.ToInt32Mask(pleft[25] < pright[25]);
                pcondition[26] = (sbyte)BitUtil.ToInt32Mask(pleft[26] < pright[26]);
                pcondition[27] = (sbyte)BitUtil.ToInt32Mask(pleft[27] < pright[27]);
                pcondition[28] = (sbyte)BitUtil.ToInt32Mask(pleft[28] < pright[28]);
                pcondition[29] = (sbyte)BitUtil.ToInt32Mask(pleft[29] < pright[29]);
                pcondition[30] = (sbyte)BitUtil.ToInt32Mask(pleft[30] < pright[30]);
                pcondition[31] = (sbyte)BitUtil.ToInt32Mask(pleft[31] < pright[31]);
                return condition.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<byte> LessThan_Base(Vector256<byte> left, Vector256<byte> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<sbyte> condition);
#else
                Vector256<sbyte> condition = default;
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
                pcondition[16] = (sbyte)BitUtil.ToInt32Mask(pleft[16] < pright[16]);
                pcondition[17] = (sbyte)BitUtil.ToInt32Mask(pleft[17] < pright[17]);
                pcondition[18] = (sbyte)BitUtil.ToInt32Mask(pleft[18] < pright[18]);
                pcondition[19] = (sbyte)BitUtil.ToInt32Mask(pleft[19] < pright[19]);
                pcondition[20] = (sbyte)BitUtil.ToInt32Mask(pleft[20] < pright[20]);
                pcondition[21] = (sbyte)BitUtil.ToInt32Mask(pleft[21] < pright[21]);
                pcondition[22] = (sbyte)BitUtil.ToInt32Mask(pleft[22] < pright[22]);
                pcondition[23] = (sbyte)BitUtil.ToInt32Mask(pleft[23] < pright[23]);
                pcondition[24] = (sbyte)BitUtil.ToInt32Mask(pleft[24] < pright[24]);
                pcondition[25] = (sbyte)BitUtil.ToInt32Mask(pleft[25] < pright[25]);
                pcondition[26] = (sbyte)BitUtil.ToInt32Mask(pleft[26] < pright[26]);
                pcondition[27] = (sbyte)BitUtil.ToInt32Mask(pleft[27] < pright[27]);
                pcondition[28] = (sbyte)BitUtil.ToInt32Mask(pleft[28] < pright[28]);
                pcondition[29] = (sbyte)BitUtil.ToInt32Mask(pleft[29] < pright[29]);
                pcondition[30] = (sbyte)BitUtil.ToInt32Mask(pleft[30] < pright[30]);
                pcondition[31] = (sbyte)BitUtil.ToInt32Mask(pleft[31] < pright[31]);
                return condition.AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<short> LessThan_Base(Vector256<short> left, Vector256<short> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<short> condition);
#else
                Vector256<short> condition = default;
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
                pcondition[8] = (short)BitUtil.ToInt32Mask(pleft[8] < pright[8]);
                pcondition[9] = (short)BitUtil.ToInt32Mask(pleft[9] < pright[9]);
                pcondition[10] = (short)BitUtil.ToInt32Mask(pleft[10] < pright[10]);
                pcondition[11] = (short)BitUtil.ToInt32Mask(pleft[11] < pright[11]);
                pcondition[12] = (short)BitUtil.ToInt32Mask(pleft[12] < pright[12]);
                pcondition[13] = (short)BitUtil.ToInt32Mask(pleft[13] < pright[13]);
                pcondition[14] = (short)BitUtil.ToInt32Mask(pleft[14] < pright[14]);
                pcondition[15] = (short)BitUtil.ToInt32Mask(pleft[15] < pright[15]);
                return condition.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<ushort> LessThan_Base(Vector256<ushort> left, Vector256<ushort> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<short> condition);
#else
                Vector256<short> condition = default;
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
                pcondition[8] = (short)BitUtil.ToInt32Mask(pleft[8] < pright[8]);
                pcondition[9] = (short)BitUtil.ToInt32Mask(pleft[9] < pright[9]);
                pcondition[10] = (short)BitUtil.ToInt32Mask(pleft[10] < pright[10]);
                pcondition[11] = (short)BitUtil.ToInt32Mask(pleft[11] < pright[11]);
                pcondition[12] = (short)BitUtil.ToInt32Mask(pleft[12] < pright[12]);
                pcondition[13] = (short)BitUtil.ToInt32Mask(pleft[13] < pright[13]);
                pcondition[14] = (short)BitUtil.ToInt32Mask(pleft[14] < pright[14]);
                pcondition[15] = (short)BitUtil.ToInt32Mask(pleft[15] < pright[15]);
                return condition.AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<int> LessThan_Base(Vector256<int> left, Vector256<int> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<int> condition);
#else
                Vector256<int> condition = default;
#endif // NET5_0_OR_GREATER
                int* pcondition = (int*)&condition;
                int* pleft = (int*)&left;
                int* pright = (int*)&right;
                pcondition[0] = BitUtil.ToInt32Mask(pleft[0] < pright[0]);
                pcondition[1] = BitUtil.ToInt32Mask(pleft[1] < pright[1]);
                pcondition[2] = BitUtil.ToInt32Mask(pleft[2] < pright[2]);
                pcondition[3] = BitUtil.ToInt32Mask(pleft[3] < pright[3]);
                pcondition[4] = BitUtil.ToInt32Mask(pleft[4] < pright[4]);
                pcondition[5] = BitUtil.ToInt32Mask(pleft[5] < pright[5]);
                pcondition[6] = BitUtil.ToInt32Mask(pleft[6] < pright[6]);
                pcondition[7] = BitUtil.ToInt32Mask(pleft[7] < pright[7]);
                return condition.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<uint> LessThan_Base(Vector256<uint> left, Vector256<uint> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<int> condition);
#else
                Vector256<int> condition = default;
#endif // NET5_0_OR_GREATER
                int* pcondition = (int*)&condition;
                uint* pleft = (uint*)&left;
                uint* pright = (uint*)&right;
                pcondition[0] = BitUtil.ToInt32Mask(pleft[0] < pright[0]);
                pcondition[1] = BitUtil.ToInt32Mask(pleft[1] < pright[1]);
                pcondition[2] = BitUtil.ToInt32Mask(pleft[2] < pright[2]);
                pcondition[3] = BitUtil.ToInt32Mask(pleft[3] < pright[3]);
                pcondition[4] = BitUtil.ToInt32Mask(pleft[4] < pright[4]);
                pcondition[5] = BitUtil.ToInt32Mask(pleft[5] < pright[5]);
                pcondition[6] = BitUtil.ToInt32Mask(pleft[6] < pright[6]);
                pcondition[7] = BitUtil.ToInt32Mask(pleft[7] < pright[7]);
                return condition.AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<long> LessThan_Base(Vector256<long> left, Vector256<long> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<long> condition);
#else
                Vector256<long> condition = default;
#endif // NET5_0_OR_GREATER
                long* pcondition = (long*)&condition;
                long* pleft = (long*)&left;
                long* pright = (long*)&right;
                pcondition[0] = BitUtil.ToInt32Mask(pleft[0] < pright[0]);
                pcondition[1] = BitUtil.ToInt32Mask(pleft[1] < pright[1]);
                pcondition[2] = BitUtil.ToInt32Mask(pleft[2] < pright[2]);
                pcondition[3] = BitUtil.ToInt32Mask(pleft[3] < pright[3]);
                return condition;
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<ulong> LessThan_Base(Vector256<ulong> left, Vector256<ulong> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<long> condition);
#else
                Vector256<long> condition = default;
#endif // NET5_0_OR_GREATER
                long* pcondition = (long*)&condition;
                ulong* pleft = (ulong*)&left;
                ulong* pright = (ulong*)&right;
                pcondition[0] = BitUtil.ToInt32Mask(pleft[0] < pright[0]);
                pcondition[1] = BitUtil.ToInt32Mask(pleft[1] < pright[1]);
                pcondition[2] = BitUtil.ToInt32Mask(pleft[2] < pright[2]);
                pcondition[3] = BitUtil.ToInt32Mask(pleft[3] < pright[3]);
                return condition.AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits256.Max_AcceleratedTypes"/>
            public static TypeCodeFlags Max_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Max(Vector256<float> left, Vector256<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Max(Vector256<double> left, Vector256<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Max(Vector256<sbyte> left, Vector256<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> Max(Vector256<byte> left, Vector256<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Max(Vector256<short> left, Vector256<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> Max(Vector256<ushort> left, Vector256<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Max(Vector256<int> left, Vector256<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> Max(Vector256<uint> left, Vector256<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> Max(Vector256<long> left, Vector256<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> Max(Vector256<ulong> left, Vector256<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<float> Max_Conditional(Vector256<float> left, Vector256<float> right) {
                Vector256<float> condition = GreaterThan(left, right);
                Vector256<float> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<double> Max_Conditional(Vector256<double> left, Vector256<double> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<long> rt);
#else
                Vector256<long> rt = default;
#endif // NET5_0_OR_GREATER
                double* pleft = (double*)&left;
                double* pright = (double*)&right;
                long* q = (long*)&rt;
                long condition0 = BitUtil.ToInt32Mask(pleft[0] > pright[0]);
                long condition1 = BitUtil.ToInt32Mask(pleft[1] > pright[1]);
                long condition2 = BitUtil.ToInt32Mask(pleft[2] > pright[2]);
                long condition3 = BitUtil.ToInt32Mask(pleft[3] > pright[3]);
                // result = (left & condition) | (right & ~condition);
                q[0] = (BitUtil.DoubleToInt64Bits(pleft[0]) & condition0) | (BitUtil.DoubleToInt64Bits(pright[0]) & ~condition0);
                q[1] = (BitUtil.DoubleToInt64Bits(pleft[1]) & condition1) | (BitUtil.DoubleToInt64Bits(pright[1]) & ~condition1);
                q[2] = (BitUtil.DoubleToInt64Bits(pleft[2]) & condition2) | (BitUtil.DoubleToInt64Bits(pright[2]) & ~condition2);
                q[3] = (BitUtil.DoubleToInt64Bits(pleft[3]) & condition3) | (BitUtil.DoubleToInt64Bits(pright[3]) & ~condition3);
                return rt.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<sbyte> Max_Conditional(Vector256<sbyte> left, Vector256<sbyte> right) {
                Vector256<sbyte> condition = GreaterThan(left, right);
                Vector256<sbyte> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<byte> Max_Conditional(Vector256<byte> left, Vector256<byte> right) {
                Vector256<byte> condition = GreaterThan(left, right);
                Vector256<byte> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<short> Max_Conditional(Vector256<short> left, Vector256<short> right) {
                Vector256<short> condition = GreaterThan(left, right);
                Vector256<short> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<ushort> Max_Conditional(Vector256<ushort> left, Vector256<ushort> right) {
                Vector256<ushort> condition = GreaterThan(left, right);
                Vector256<ushort> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<int> Max_Conditional(Vector256<int> left, Vector256<int> right) {
                Vector256<int> condition = GreaterThan(left, right);
                Vector256<int> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<uint> Max_Conditional(Vector256<uint> left, Vector256<uint> right) {
                Vector256<uint> condition = GreaterThan(left, right);
                Vector256<uint> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<long> Max_Conditional(Vector256<long> left, Vector256<long> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<long> rt);
#else
                Vector256<long> rt = default;
#endif // NET5_0_OR_GREATER
                long* pleft = (long*)&left;
                long* pright = (long*)&right;
                long* q = (long*)&rt;
                long condition0 = BitUtil.ToInt32Mask(pleft[0] > pright[0]);
                long condition1 = BitUtil.ToInt32Mask(pleft[1] > pright[1]);
                long condition2 = BitUtil.ToInt32Mask(pleft[2] > pright[2]);
                long condition3 = BitUtil.ToInt32Mask(pleft[3] > pright[3]);
                // result = (left & condition) | (right & ~condition);
                q[0] = ((pleft[0]) & condition0) | ((pright[0]) & ~condition0);
                q[1] = ((pleft[1]) & condition1) | ((pright[1]) & ~condition1);
                q[2] = ((pleft[2]) & condition2) | ((pright[2]) & ~condition2);
                q[3] = ((pleft[3]) & condition3) | ((pright[3]) & ~condition3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<ulong> Max_Conditional(Vector256<ulong> left, Vector256<ulong> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<long> rt);
#else
                Vector256<long> rt = default;
#endif // NET5_0_OR_GREATER
                ulong* pleft = (ulong*)&left;
                ulong* pright = (ulong*)&right;
                long* q = (long*)&rt;
                long condition0 = BitUtil.ToInt32Mask(pleft[0] > pright[0]);
                long condition1 = BitUtil.ToInt32Mask(pleft[1] > pright[1]);
                long condition2 = BitUtil.ToInt32Mask(pleft[2] > pright[2]);
                long condition3 = BitUtil.ToInt32Mask(pleft[3] > pright[3]);
                // result = (left & condition) | (right & ~condition);
                q[0] = ((long)(pleft[0]) & condition0) | ((long)(pright[0]) & ~condition0);
                q[1] = ((long)(pleft[1]) & condition1) | ((long)(pright[1]) & ~condition1);
                q[2] = ((long)(pleft[2]) & condition2) | ((long)(pright[2]) & ~condition2);
                q[3] = ((long)(pleft[3]) & condition3) | ((long)(pright[3]) & ~condition3);
                return rt.AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits256.Min_AcceleratedTypes"/>
            public static TypeCodeFlags Min_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Min(Vector256<float> left, Vector256<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Min(Vector256<double> left, Vector256<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Min(Vector256<sbyte> left, Vector256<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> Min(Vector256<byte> left, Vector256<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Min(Vector256<short> left, Vector256<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> Min(Vector256<ushort> left, Vector256<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Min(Vector256<int> left, Vector256<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> Min(Vector256<uint> left, Vector256<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> Min(Vector256<long> left, Vector256<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> Min(Vector256<ulong> left, Vector256<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<float> Min_Conditional(Vector256<float> left, Vector256<float> right) {
                Vector256<float> condition = LessThan(left, right);
                Vector256<float> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<double> Min_Conditional(Vector256<double> left, Vector256<double> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<long> rt);
#else
                Vector256<long> rt = default;
#endif // NET5_0_OR_GREATER
                double* pleft = (double*)&left;
                double* pright = (double*)&right;
                long* q = (long*)&rt;
                long condition0 = BitUtil.ToInt32Mask(pleft[0] < pright[0]);
                long condition1 = BitUtil.ToInt32Mask(pleft[1] < pright[1]);
                long condition2 = BitUtil.ToInt32Mask(pleft[2] < pright[2]);
                long condition3 = BitUtil.ToInt32Mask(pleft[3] < pright[3]);
                // result = (left & condition) | (right & ~condition);
                q[0] = (BitUtil.DoubleToInt64Bits(pleft[0]) & condition0) | (BitUtil.DoubleToInt64Bits(pright[0]) & ~condition0);
                q[1] = (BitUtil.DoubleToInt64Bits(pleft[1]) & condition1) | (BitUtil.DoubleToInt64Bits(pright[1]) & ~condition1);
                q[2] = (BitUtil.DoubleToInt64Bits(pleft[2]) & condition2) | (BitUtil.DoubleToInt64Bits(pright[2]) & ~condition2);
                q[3] = (BitUtil.DoubleToInt64Bits(pleft[3]) & condition3) | (BitUtil.DoubleToInt64Bits(pright[3]) & ~condition3);
                return rt.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<sbyte> Min_Conditional(Vector256<sbyte> left, Vector256<sbyte> right) {
                Vector256<sbyte> condition = LessThan(left, right);
                Vector256<sbyte> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<byte> Min_Conditional(Vector256<byte> left, Vector256<byte> right) {
                Vector256<byte> condition = LessThan(left, right);
                Vector256<byte> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<short> Min_Conditional(Vector256<short> left, Vector256<short> right) {
                Vector256<short> condition = LessThan(left, right);
                Vector256<short> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<ushort> Min_Conditional(Vector256<ushort> left, Vector256<ushort> right) {
                Vector256<ushort> condition = LessThan(left, right);
                Vector256<ushort> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<int> Min_Conditional(Vector256<int> left, Vector256<int> right) {
                Vector256<int> condition = LessThan(left, right);
                Vector256<int> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<uint> Min_Conditional(Vector256<uint> left, Vector256<uint> right) {
                Vector256<uint> condition = LessThan(left, right);
                Vector256<uint> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<long> Min_Conditional(Vector256<long> left, Vector256<long> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<long> rt);
#else
                Vector256<long> rt = default;
#endif // NET5_0_OR_GREATER
                long* pleft = (long*)&left;
                long* pright = (long*)&right;
                long* q = (long*)&rt;
                long condition0 = BitUtil.ToInt32Mask(pleft[0] < pright[0]);
                long condition1 = BitUtil.ToInt32Mask(pleft[1] < pright[1]);
                long condition2 = BitUtil.ToInt32Mask(pleft[2] < pright[2]);
                long condition3 = BitUtil.ToInt32Mask(pleft[3] < pright[3]);
                // result = (left & condition) | (right & ~condition);
                q[0] = ((pleft[0]) & condition0) | ((pright[0]) & ~condition0);
                q[1] = ((pleft[1]) & condition1) | ((pright[1]) & ~condition1);
                q[2] = ((pleft[2]) & condition2) | ((pright[2]) & ~condition2);
                q[3] = ((pleft[3]) & condition3) | ((pright[3]) & ~condition3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<ulong> Min_Conditional(Vector256<ulong> left, Vector256<ulong> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<long> rt);
#else
                Vector256<long> rt = default;
#endif // NET5_0_OR_GREATER
                ulong* pleft = (ulong*)&left;
                ulong* pright = (ulong*)&right;
                long* q = (long*)&rt;
                long condition0 = BitUtil.ToInt32Mask(pleft[0] < pright[0]);
                long condition1 = BitUtil.ToInt32Mask(pleft[1] < pright[1]);
                long condition2 = BitUtil.ToInt32Mask(pleft[2] < pright[2]);
                long condition3 = BitUtil.ToInt32Mask(pleft[3] < pright[3]);
                // result = (left & condition) | (right & ~condition);
                q[0] = ((long)(pleft[0]) & condition0) | ((long)(pright[0]) & ~condition0);
                q[1] = ((long)(pleft[1]) & condition1) | ((long)(pright[1]) & ~condition1);
                q[2] = ((long)(pleft[2]) & condition2) | ((long)(pright[2]) & ~condition2);
                q[3] = ((long)(pleft[3]) & condition3) | ((long)(pright[3]) & ~condition3);
                return rt.AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits256.Multiply_AcceleratedTypes"/>
            public static TypeCodeFlags Multiply_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Multiply(Vector256<float> left, Vector256<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Multiply(left, right);
#else
                return Multiply_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Multiply(Vector256<double> left, Vector256<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Multiply(left, right);
#else
                return Multiply_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Multiply(Vector256<sbyte> left, Vector256<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Multiply(left, right);
#else
                return Multiply_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> Multiply(Vector256<byte> left, Vector256<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Multiply(left, right);
#else
                return Multiply_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Multiply(Vector256<short> left, Vector256<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Multiply(left, right);
#else
                return Multiply_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> Multiply(Vector256<ushort> left, Vector256<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Multiply(left, right);
#else
                return Multiply_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Multiply(Vector256<int> left, Vector256<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Multiply(left, right);
#else
                return Multiply_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> Multiply(Vector256<uint> left, Vector256<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Multiply(left, right);
#else
                return Multiply_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> Multiply(Vector256<long> left, Vector256<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Multiply(left, right);
#else
                return Multiply_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> Multiply(Vector256<ulong> left, Vector256<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Multiply(left, right);
#else
                return Multiply_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<float> Multiply_Base(Vector256<float> left, Vector256<float> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<float> rt);
#else
                Vector256<float> rt = default;
#endif // NET5_0_OR_GREATER
                float* prt = (float*)&rt;
                float* pleft = (float*)&left;
                float* pright = (float*)&right;
                prt[0] = (pleft[0] * pright[0]);
                prt[1] = (pleft[1] * pright[1]);
                prt[2] = (pleft[2] * pright[2]);
                prt[3] = (pleft[3] * pright[3]);
                prt[4] = (pleft[4] * pright[4]);
                prt[5] = (pleft[5] * pright[5]);
                prt[6] = (pleft[6] * pright[6]);
                prt[7] = (pleft[7] * pright[7]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<double> Multiply_Base(Vector256<double> left, Vector256<double> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<double> rt);
#else
                Vector256<double> rt = default;
#endif // NET5_0_OR_GREATER
                double* prt = (double*)&rt;
                double* pleft = (double*)&left;
                double* pright = (double*)&right;
                prt[0] = (pleft[0] * pright[0]);
                prt[1] = (pleft[1] * pright[1]);
                prt[2] = (pleft[2] * pright[2]);
                prt[3] = (pleft[3] * pright[3]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<sbyte> Multiply_Base(Vector256<sbyte> left, Vector256<sbyte> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<sbyte> rt);
#else
                Vector256<sbyte> rt = default;
#endif // NET5_0_OR_GREATER
                sbyte* prt = (sbyte*)&rt;
                sbyte* pleft = (sbyte*)&left;
                sbyte* pright = (sbyte*)&right;
                prt[0] = (sbyte)(pleft[0] * pright[0]);
                prt[1] = (sbyte)(pleft[1] * pright[1]);
                prt[2] = (sbyte)(pleft[2] * pright[2]);
                prt[3] = (sbyte)(pleft[3] * pright[3]);
                prt[4] = (sbyte)(pleft[4] * pright[4]);
                prt[5] = (sbyte)(pleft[5] * pright[5]);
                prt[6] = (sbyte)(pleft[6] * pright[6]);
                prt[7] = (sbyte)(pleft[7] * pright[7]);
                prt[8] = (sbyte)(pleft[8] * pright[8]);
                prt[9] = (sbyte)(pleft[9] * pright[9]);
                prt[10] = (sbyte)(pleft[10] * pright[10]);
                prt[11] = (sbyte)(pleft[11] * pright[11]);
                prt[12] = (sbyte)(pleft[12] * pright[12]);
                prt[13] = (sbyte)(pleft[13] * pright[13]);
                prt[14] = (sbyte)(pleft[14] * pright[14]);
                prt[15] = (sbyte)(pleft[15] * pright[15]);
                prt[16] = (sbyte)(pleft[16] * pright[16]);
                prt[17] = (sbyte)(pleft[17] * pright[17]);
                prt[18] = (sbyte)(pleft[18] * pright[18]);
                prt[19] = (sbyte)(pleft[19] * pright[19]);
                prt[20] = (sbyte)(pleft[20] * pright[20]);
                prt[21] = (sbyte)(pleft[21] * pright[21]);
                prt[22] = (sbyte)(pleft[22] * pright[22]);
                prt[23] = (sbyte)(pleft[23] * pright[23]);
                prt[24] = (sbyte)(pleft[24] * pright[24]);
                prt[25] = (sbyte)(pleft[25] * pright[25]);
                prt[26] = (sbyte)(pleft[26] * pright[26]);
                prt[27] = (sbyte)(pleft[27] * pright[27]);
                prt[28] = (sbyte)(pleft[28] * pright[28]);
                prt[29] = (sbyte)(pleft[29] * pright[29]);
                prt[30] = (sbyte)(pleft[30] * pright[30]);
                prt[31] = (sbyte)(pleft[31] * pright[31]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<byte> Multiply_Base(Vector256<byte> left, Vector256<byte> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<byte> rt);
#else
                Vector256<byte> rt = default;
#endif // NET5_0_OR_GREATER
                byte* prt = (byte*)&rt;
                byte* pleft = (byte*)&left;
                byte* pright = (byte*)&right;
                prt[0] = (byte)(pleft[0] * pright[0]);
                prt[1] = (byte)(pleft[1] * pright[1]);
                prt[2] = (byte)(pleft[2] * pright[2]);
                prt[3] = (byte)(pleft[3] * pright[3]);
                prt[4] = (byte)(pleft[4] * pright[4]);
                prt[5] = (byte)(pleft[5] * pright[5]);
                prt[6] = (byte)(pleft[6] * pright[6]);
                prt[7] = (byte)(pleft[7] * pright[7]);
                prt[8] = (byte)(pleft[8] * pright[8]);
                prt[9] = (byte)(pleft[9] * pright[9]);
                prt[10] = (byte)(pleft[10] * pright[10]);
                prt[11] = (byte)(pleft[11] * pright[11]);
                prt[12] = (byte)(pleft[12] * pright[12]);
                prt[13] = (byte)(pleft[13] * pright[13]);
                prt[14] = (byte)(pleft[14] * pright[14]);
                prt[15] = (byte)(pleft[15] * pright[15]);
                prt[16] = (byte)(pleft[16] * pright[16]);
                prt[17] = (byte)(pleft[17] * pright[17]);
                prt[18] = (byte)(pleft[18] * pright[18]);
                prt[19] = (byte)(pleft[19] * pright[19]);
                prt[20] = (byte)(pleft[20] * pright[20]);
                prt[21] = (byte)(pleft[21] * pright[21]);
                prt[22] = (byte)(pleft[22] * pright[22]);
                prt[23] = (byte)(pleft[23] * pright[23]);
                prt[24] = (byte)(pleft[24] * pright[24]);
                prt[25] = (byte)(pleft[25] * pright[25]);
                prt[26] = (byte)(pleft[26] * pright[26]);
                prt[27] = (byte)(pleft[27] * pright[27]);
                prt[28] = (byte)(pleft[28] * pright[28]);
                prt[29] = (byte)(pleft[29] * pright[29]);
                prt[30] = (byte)(pleft[30] * pright[30]);
                prt[31] = (byte)(pleft[31] * pright[31]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<short> Multiply_Base(Vector256<short> left, Vector256<short> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<short> rt);
#else
                Vector256<short> rt = default;
#endif // NET5_0_OR_GREATER
                short* prt = (short*)&rt;
                short* pleft = (short*)&left;
                short* pright = (short*)&right;
                prt[0] = (short)(pleft[0] * pright[0]);
                prt[1] = (short)(pleft[1] * pright[1]);
                prt[2] = (short)(pleft[2] * pright[2]);
                prt[3] = (short)(pleft[3] * pright[3]);
                prt[4] = (short)(pleft[4] * pright[4]);
                prt[5] = (short)(pleft[5] * pright[5]);
                prt[6] = (short)(pleft[6] * pright[6]);
                prt[7] = (short)(pleft[7] * pright[7]);
                prt[8] = (short)(pleft[8] * pright[8]);
                prt[9] = (short)(pleft[9] * pright[9]);
                prt[10] = (short)(pleft[10] * pright[10]);
                prt[11] = (short)(pleft[11] * pright[11]);
                prt[12] = (short)(pleft[12] * pright[12]);
                prt[13] = (short)(pleft[13] * pright[13]);
                prt[14] = (short)(pleft[14] * pright[14]);
                prt[15] = (short)(pleft[15] * pright[15]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<ushort> Multiply_Base(Vector256<ushort> left, Vector256<ushort> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<ushort> rt);
#else
                Vector256<ushort> rt = default;
#endif // NET5_0_OR_GREATER
                ushort* prt = (ushort*)&rt;
                ushort* pleft = (ushort*)&left;
                ushort* pright = (ushort*)&right;
                prt[0] = (ushort)(pleft[0] * pright[0]);
                prt[1] = (ushort)(pleft[1] * pright[1]);
                prt[2] = (ushort)(pleft[2] * pright[2]);
                prt[3] = (ushort)(pleft[3] * pright[3]);
                prt[4] = (ushort)(pleft[4] * pright[4]);
                prt[5] = (ushort)(pleft[5] * pright[5]);
                prt[6] = (ushort)(pleft[6] * pright[6]);
                prt[7] = (ushort)(pleft[7] * pright[7]);
                prt[8] = (ushort)(pleft[8] * pright[8]);
                prt[9] = (ushort)(pleft[9] * pright[9]);
                prt[10] = (ushort)(pleft[10] * pright[10]);
                prt[11] = (ushort)(pleft[11] * pright[11]);
                prt[12] = (ushort)(pleft[12] * pright[12]);
                prt[13] = (ushort)(pleft[13] * pright[13]);
                prt[14] = (ushort)(pleft[14] * pright[14]);
                prt[15] = (ushort)(pleft[15] * pright[15]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<int> Multiply_Base(Vector256<int> left, Vector256<int> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<int> rt);
#else
                Vector256<int> rt = default;
#endif // NET5_0_OR_GREATER
                int* prt = (int*)&rt;
                int* pleft = (int*)&left;
                int* pright = (int*)&right;
                prt[0] = (pleft[0] * pright[0]);
                prt[1] = (pleft[1] * pright[1]);
                prt[2] = (pleft[2] * pright[2]);
                prt[3] = (pleft[3] * pright[3]);
                prt[4] = (pleft[4] * pright[4]);
                prt[5] = (pleft[5] * pright[5]);
                prt[6] = (pleft[6] * pright[6]);
                prt[7] = (pleft[7] * pright[7]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<uint> Multiply_Base(Vector256<uint> left, Vector256<uint> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<uint> rt);
#else
                Vector256<uint> rt = default;
#endif // NET5_0_OR_GREATER
                uint* prt = (uint*)&rt;
                uint* pleft = (uint*)&left;
                uint* pright = (uint*)&right;
                prt[0] = (pleft[0] * pright[0]);
                prt[1] = (pleft[1] * pright[1]);
                prt[2] = (pleft[2] * pright[2]);
                prt[3] = (pleft[3] * pright[3]);
                prt[4] = (pleft[4] * pright[4]);
                prt[5] = (pleft[5] * pright[5]);
                prt[6] = (pleft[6] * pright[6]);
                prt[7] = (pleft[7] * pright[7]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<long> Multiply_Base(Vector256<long> left, Vector256<long> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<long> rt);
#else
                Vector256<long> rt = default;
#endif // NET5_0_OR_GREATER
                long* prt = (long*)&rt;
                long* pleft = (long*)&left;
                long* pright = (long*)&right;
                prt[0] = (pleft[0] * pright[0]);
                prt[1] = (pleft[1] * pright[1]);
                prt[2] = (pleft[2] * pright[2]);
                prt[3] = (pleft[3] * pright[3]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<ulong> Multiply_Base(Vector256<ulong> left, Vector256<ulong> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<ulong> rt);
#else
                Vector256<ulong> rt = default;
#endif // NET5_0_OR_GREATER
                ulong* prt = (ulong*)&rt;
                ulong* pleft = (ulong*)&left;
                ulong* pright = (ulong*)&right;
                prt[0] = (pleft[0] * pright[0]);
                prt[1] = (pleft[1] * pright[1]);
                prt[2] = (pleft[2] * pright[2]);
                prt[3] = (pleft[3] * pright[3]);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.Negate_AcceleratedTypes"/>
            public static TypeCodeFlags Negate_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Negate(Vector256<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Negate(value);
#else
                return Negate_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Negate(Vector256<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Negate(value);
#else
                return Negate_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Negate(Vector256<sbyte> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Negate(value);
#else
                return Negate_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Negate(Vector256<short> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Negate(value);
#else
                return Negate_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Negate(Vector256<int> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Negate(value);
#else
                return Negate_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> Negate(Vector256<long> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Negate(value);
#else
                return Negate_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<float> Negate_Base(Vector256<float> value) {
                Vector256<float> rt = value;
                float* p = (float*)&rt;
                p[0] = -p[0];
                p[1] = -p[1];
                p[2] = -p[2];
                p[3] = -p[3];
                p[4] = -p[4];
                p[5] = -p[5];
                p[6] = -p[6];
                p[7] = -p[7];
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<double> Negate_Base(Vector256<double> value) {
                Vector256<double> rt = value;
                double* p = (double*)&rt;
                p[0] = -p[0];
                p[1] = -p[1];
                p[2] = -p[2];
                p[3] = -p[3];
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<sbyte> Negate_Base(Vector256<sbyte> value) {
                Vector256<sbyte> rt = value;
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
                p[16] = (sbyte)-p[16];
                p[17] = (sbyte)-p[17];
                p[18] = (sbyte)-p[18];
                p[19] = (sbyte)-p[19];
                p[20] = (sbyte)-p[20];
                p[21] = (sbyte)-p[21];
                p[22] = (sbyte)-p[22];
                p[23] = (sbyte)-p[23];
                p[24] = (sbyte)-p[24];
                p[25] = (sbyte)-p[25];
                p[26] = (sbyte)-p[26];
                p[27] = (sbyte)-p[27];
                p[28] = (sbyte)-p[28];
                p[29] = (sbyte)-p[29];
                p[30] = (sbyte)-p[30];
                p[31] = (sbyte)-p[31];
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<short> Negate_Base(Vector256<short> value) {
                Vector256<short> rt = value;
                short* p = (short*)&rt;
                p[0] = (short)-p[0];
                p[1] = (short)-p[1];
                p[2] = (short)-p[2];
                p[3] = (short)-p[3];
                p[4] = (short)-p[4];
                p[5] = (short)-p[5];
                p[6] = (short)-p[6];
                p[7] = (short)-p[7];
                p[8] = (short)-p[8];
                p[9] = (short)-p[9];
                p[10] = (short)-p[10];
                p[11] = (short)-p[11];
                p[12] = (short)-p[12];
                p[13] = (short)-p[13];
                p[14] = (short)-p[14];
                p[15] = (short)-p[15];
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<int> Negate_Base(Vector256<int> value) {
                Vector256<int> rt = value;
                int* p = (int*)&rt;
                p[0] = -p[0];
                p[1] = -p[1];
                p[2] = -p[2];
                p[3] = -p[3];
                p[4] = -p[4];
                p[5] = -p[5];
                p[6] = -p[6];
                p[7] = -p[7];
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<long> Negate_Base(Vector256<long> value) {
                Vector256<long> rt = value;
                long* p = (long*)&rt;
                p[0] = -p[0];
                p[1] = -p[1];
                p[2] = -p[2];
                p[3] = -p[3];
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.OnesComplement_AcceleratedTypes"/>
            public static TypeCodeFlags OnesComplement_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.OnesComplement{T}(Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<T> OnesComplement<T>(Vector256<T> vector) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.OnesComplement(vector);
#else
                return OnesComplement_Base(vector);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.OnesComplement{T}(Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<T> OnesComplement_Base<T>(Vector256<T> vector) where T : struct {
                Vector256<T> rt = vector;
                ulong* p = (ulong*)&rt;
                p[0] = ~p[0];
                p[1] = ~p[1];
                p[2] = ~p[2];
                p[3] = ~p[3];
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.Subtract_AcceleratedTypes"/>
            public static TypeCodeFlags Subtract_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Subtract(Vector256<float> left, Vector256<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Subtract(left, right);
#else
                return Subtract_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Subtract(Vector256<double> left, Vector256<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Subtract(left, right);
#else
                return Subtract_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Subtract(Vector256<sbyte> left, Vector256<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Subtract(left, right);
#else
                return Subtract_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> Subtract(Vector256<byte> left, Vector256<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Subtract(left, right);
#else
                return Subtract_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Subtract(Vector256<short> left, Vector256<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Subtract(left, right);
#else
                return Subtract_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> Subtract(Vector256<ushort> left, Vector256<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Subtract(left, right);
#else
                return Subtract_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Subtract(Vector256<int> left, Vector256<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Subtract(left, right);
#else
                return Subtract_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> Subtract(Vector256<uint> left, Vector256<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Subtract(left, right);
#else
                return Subtract_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> Subtract(Vector256<long> left, Vector256<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Subtract(left, right);
#else
                return Subtract_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> Subtract(Vector256<ulong> left, Vector256<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Subtract(left, right);
#else
                return Subtract_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<float> Subtract_Base(Vector256<float> left, Vector256<float> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<float> rt);
#else
                Vector256<float> rt = default;
#endif // NET5_0_OR_GREATER
                float* prt = (float*)&rt;
                float* pleft = (float*)&left;
                float* pright = (float*)&right;
                prt[0] = (pleft[0] - pright[0]);
                prt[1] = (pleft[1] - pright[1]);
                prt[2] = (pleft[2] - pright[2]);
                prt[3] = (pleft[3] - pright[3]);
                prt[4] = (pleft[4] - pright[4]);
                prt[5] = (pleft[5] - pright[5]);
                prt[6] = (pleft[6] - pright[6]);
                prt[7] = (pleft[7] - pright[7]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<double> Subtract_Base(Vector256<double> left, Vector256<double> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<double> rt);
#else
                Vector256<double> rt = default;
#endif // NET5_0_OR_GREATER
                double* prt = (double*)&rt;
                double* pleft = (double*)&left;
                double* pright = (double*)&right;
                prt[0] = (pleft[0] - pright[0]);
                prt[1] = (pleft[1] - pright[1]);
                prt[2] = (pleft[2] - pright[2]);
                prt[3] = (pleft[3] - pright[3]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<sbyte> Subtract_Base(Vector256<sbyte> left, Vector256<sbyte> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<sbyte> rt);
#else
                Vector256<sbyte> rt = default;
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
                prt[16] = (sbyte)(pleft[16] - pright[16]);
                prt[17] = (sbyte)(pleft[17] - pright[17]);
                prt[18] = (sbyte)(pleft[18] - pright[18]);
                prt[19] = (sbyte)(pleft[19] - pright[19]);
                prt[20] = (sbyte)(pleft[20] - pright[20]);
                prt[21] = (sbyte)(pleft[21] - pright[21]);
                prt[22] = (sbyte)(pleft[22] - pright[22]);
                prt[23] = (sbyte)(pleft[23] - pright[23]);
                prt[24] = (sbyte)(pleft[24] - pright[24]);
                prt[25] = (sbyte)(pleft[25] - pright[25]);
                prt[26] = (sbyte)(pleft[26] - pright[26]);
                prt[27] = (sbyte)(pleft[27] - pright[27]);
                prt[28] = (sbyte)(pleft[28] - pright[28]);
                prt[29] = (sbyte)(pleft[29] - pright[29]);
                prt[30] = (sbyte)(pleft[30] - pright[30]);
                prt[31] = (sbyte)(pleft[31] - pright[31]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<byte> Subtract_Base(Vector256<byte> left, Vector256<byte> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<byte> rt);
#else
                Vector256<byte> rt = default;
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
                prt[16] = (byte)(pleft[16] - pright[16]);
                prt[17] = (byte)(pleft[17] - pright[17]);
                prt[18] = (byte)(pleft[18] - pright[18]);
                prt[19] = (byte)(pleft[19] - pright[19]);
                prt[20] = (byte)(pleft[20] - pright[20]);
                prt[21] = (byte)(pleft[21] - pright[21]);
                prt[22] = (byte)(pleft[22] - pright[22]);
                prt[23] = (byte)(pleft[23] - pright[23]);
                prt[24] = (byte)(pleft[24] - pright[24]);
                prt[25] = (byte)(pleft[25] - pright[25]);
                prt[26] = (byte)(pleft[26] - pright[26]);
                prt[27] = (byte)(pleft[27] - pright[27]);
                prt[28] = (byte)(pleft[28] - pright[28]);
                prt[29] = (byte)(pleft[29] - pright[29]);
                prt[30] = (byte)(pleft[30] - pright[30]);
                prt[31] = (byte)(pleft[31] - pright[31]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<short> Subtract_Base(Vector256<short> left, Vector256<short> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<short> rt);
#else
                Vector256<short> rt = default;
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
                prt[8] = (short)(pleft[8] - pright[8]);
                prt[9] = (short)(pleft[9] - pright[9]);
                prt[10] = (short)(pleft[10] - pright[10]);
                prt[11] = (short)(pleft[11] - pright[11]);
                prt[12] = (short)(pleft[12] - pright[12]);
                prt[13] = (short)(pleft[13] - pright[13]);
                prt[14] = (short)(pleft[14] - pright[14]);
                prt[15] = (short)(pleft[15] - pright[15]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<ushort> Subtract_Base(Vector256<ushort> left, Vector256<ushort> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<ushort> rt);
#else
                Vector256<ushort> rt = default;
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
                prt[8] = (ushort)(pleft[8] - pright[8]);
                prt[9] = (ushort)(pleft[9] - pright[9]);
                prt[10] = (ushort)(pleft[10] - pright[10]);
                prt[11] = (ushort)(pleft[11] - pright[11]);
                prt[12] = (ushort)(pleft[12] - pright[12]);
                prt[13] = (ushort)(pleft[13] - pright[13]);
                prt[14] = (ushort)(pleft[14] - pright[14]);
                prt[15] = (ushort)(pleft[15] - pright[15]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<int> Subtract_Base(Vector256<int> left, Vector256<int> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<int> rt);
#else
                Vector256<int> rt = default;
#endif // NET5_0_OR_GREATER
                int* prt = (int*)&rt;
                int* pleft = (int*)&left;
                int* pright = (int*)&right;
                prt[0] = (pleft[0] - pright[0]);
                prt[1] = (pleft[1] - pright[1]);
                prt[2] = (pleft[2] - pright[2]);
                prt[3] = (pleft[3] - pright[3]);
                prt[4] = (pleft[4] - pright[4]);
                prt[5] = (pleft[5] - pright[5]);
                prt[6] = (pleft[6] - pright[6]);
                prt[7] = (pleft[7] - pright[7]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<uint> Subtract_Base(Vector256<uint> left, Vector256<uint> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<uint> rt);
#else
                Vector256<uint> rt = default;
#endif // NET5_0_OR_GREATER
                uint* prt = (uint*)&rt;
                uint* pleft = (uint*)&left;
                uint* pright = (uint*)&right;
                prt[0] = (pleft[0] - pright[0]);
                prt[1] = (pleft[1] - pright[1]);
                prt[2] = (pleft[2] - pright[2]);
                prt[3] = (pleft[3] - pright[3]);
                prt[4] = (pleft[4] - pright[4]);
                prt[5] = (pleft[5] - pright[5]);
                prt[6] = (pleft[6] - pright[6]);
                prt[7] = (pleft[7] - pright[7]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<long> Subtract_Base(Vector256<long> left, Vector256<long> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<long> rt);
#else
                Vector256<long> rt = default;
#endif // NET5_0_OR_GREATER
                long* prt = (long*)&rt;
                long* pleft = (long*)&left;
                long* pright = (long*)&right;
                prt[0] = (pleft[0] - pright[0]);
                prt[1] = (pleft[1] - pright[1]);
                prt[2] = (pleft[2] - pright[2]);
                prt[3] = (pleft[3] - pright[3]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<ulong> Subtract_Base(Vector256<ulong> left, Vector256<ulong> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<ulong> rt);
#else
                Vector256<ulong> rt = default;
#endif // NET5_0_OR_GREATER
                ulong* prt = (ulong*)&rt;
                ulong* pleft = (ulong*)&left;
                ulong* pright = (ulong*)&right;
                prt[0] = (pleft[0] - pright[0]);
                prt[1] = (pleft[1] - pright[1]);
                prt[2] = (pleft[2] - pright[2]);
                prt[3] = (pleft[3] - pright[3]);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.Xor_AcceleratedTypes"/>
            public static TypeCodeFlags Xor_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Xor{T}(Vector256{T}, Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<T> Xor<T>(Vector256<T> left, Vector256<T> right) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Xor(left, right);
#else
                return Xor_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Xor{T}(Vector256{T}, Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<T> Xor_Base<T>(Vector256<T> left, Vector256<T> right) where T : struct {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<T> rt);
#else
                Vector256<T> rt = default;
#endif // NET5_0_OR_GREATER
                ulong* pleft = (ulong*)&left;
                ulong* pright = (ulong*)&right;
                ulong* q = (ulong*)&rt;
                // rt[i] := left[i] ^ right[i];
                q[0] = pleft[0] ^ pright[0];
                q[1] = pleft[1] ^ pright[1];
                q[2] = pleft[2] ^ pright[2];
                q[3] = pleft[3] ^ pright[3];
                return rt;
            }


#endif // NETCOREAPP3_0_OR_GREATER
        }
    }
}
