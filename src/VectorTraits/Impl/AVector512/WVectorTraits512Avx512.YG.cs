using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
#endif
using Zyl.VectorTraits.Collections;
using Zyl.VectorTraits.ExTypes;
using Zyl.VectorTraits.Impl.Util;

namespace Zyl.VectorTraits.Impl.AVector512 {
    using SuperStatics = WVectorTraits512Base.Statics;

    partial class WVectorTraits512Avx512 {

        partial class Statics {

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2Unzip_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes | TypeCodeFlags.Int128 | TypeCodeFlags.UInt128;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{float}, Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup2Unzip(Vector512<float> data0, Vector512<float> data1, out Vector512<float> y) {
                return YGroup2Unzip_Permute(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{double}, Vector512{double}, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup2Unzip(Vector512<double> data0, Vector512<double> data1, out Vector512<double> y) {
                return YGroup2Unzip_Permute(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup2Unzip(Vector512<sbyte> data0, Vector512<sbyte> data1, out Vector512<sbyte> y) {
                return YGroup2Unzip_Permute(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{byte}, Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup2Unzip(Vector512<byte> data0, Vector512<byte> data1, out Vector512<byte> y) {
                return YGroup2Unzip_Permute(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{short}, Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup2Unzip(Vector512<short> data0, Vector512<short> data1, out Vector512<short> y) {
                return YGroup2Unzip_Permute(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{ushort}, Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup2Unzip(Vector512<ushort> data0, Vector512<ushort> data1, out Vector512<ushort> y) {
                return YGroup2Unzip_Permute(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{int}, Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup2Unzip(Vector512<int> data0, Vector512<int> data1, out Vector512<int> y) {
                return YGroup2Unzip_Permute(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{uint}, Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup2Unzip(Vector512<uint> data0, Vector512<uint> data1, out Vector512<uint> y) {
                return YGroup2Unzip_Permute(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{long}, Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup2Unzip(Vector512<long> data0, Vector512<long> data1, out Vector512<long> y) {
                return YGroup2Unzip_Permute(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{ulong}, Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup2Unzip(Vector512<ulong> data0, Vector512<ulong> data1, out Vector512<ulong> y) {
                return YGroup2Unzip_Permute(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{ExInt128}, Vector512{ExInt128}, out Vector512{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExInt128> YGroup2Unzip(Vector512<ExInt128> data0, Vector512<ExInt128> data1, out Vector512<ExInt128> y) {
#if EX_APPLY_GENERIC
                return YGroup2Unzip_Int128(data0, data1, out y);
#else
                var d0 = YGroup2Unzip_Int128(data0.ExAsUInt64(), data1.ExAsUInt64(), out var d1);
                y = d1.ExAsExInt128();
                return d0.ExAsExInt128();
#endif // EX_APPLY_GENERIC
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{ExUInt128}, Vector512{ExUInt128}, out Vector512{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExUInt128> YGroup2Unzip(Vector512<ExUInt128> data0, Vector512<ExUInt128> data1, out Vector512<ExUInt128> y) {
#if EX_APPLY_GENERIC
                return YGroup2Unzip_Int128(data0, data1, out y);
#else
                var d0 = YGroup2Unzip_Int128(data0.ExAsUInt64(), data1.ExAsUInt64(), out var d1);
                y = d1.ExAsExUInt128();
                return d0.ExAsExUInt128();
#endif // EX_APPLY_GENERIC
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip_Int128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<T> YGroup2Unzip_Int128<T>(Vector512<T> data0, Vector512<T> data1, out Vector512<T> y) where T : struct {
#if EX_APPLY_GENERIC
                var d0 = Avx512F.Shuffle4x128(data0.ExAsUInt64(), data1.ExAsUInt64(), (byte)ShuffleControlG4.XZXZ); // x0 x1 x2 x3
                var d1 = Avx512F.Shuffle4x128(data0.ExAsUInt64(), data1.ExAsUInt64(), (byte)ShuffleControlG4.YWYW); // y0 y1 y2 y3
                y = d1.ExAs<ulong, T>();
                return d0.ExAs<ulong, T>();
#else
                var d0 = Avx512F.Shuffle4x128(data0.AsUInt64(), data1.AsUInt64(), (byte)ShuffleControlG4.XZXZ); // x0 x1 x2 x3
                var d1 = Avx512F.Shuffle4x128(data0.AsUInt64(), data1.AsUInt64(), (byte)ShuffleControlG4.YWYW); // y0 y1 y2 y3
                y = d1.As<ulong, T>();
                return d0.As<ulong, T>();
#endif // EX_APPLY_GENERIC
            }

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
                rt0 = Narrow(temp0, temp1);
                temp0 = Avx512BW.ShiftRightLogical(temp0, L);
                temp1 = Avx512BW.ShiftRightLogical(temp1, L);
                rt1 = Narrow(temp0, temp1);
                y = rt1;
                return rt0;
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
                // Format: Code; //Latency, Throughput(references IceLake)
                rt0 = Narrow(temp0, temp1); // 8, 2.66
                temp0 = Avx512F.ShiftRightLogical(temp0, L); // 1,0.5
                temp1 = Avx512F.ShiftRightLogical(temp1, L); // 1,0.5
                rt1 = Narrow(temp0, temp1); // 8, 2.66
                y = rt1;
                return rt0; //total latency: 18, total throughput CPI: 6.33
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
                rt0 = Narrow(temp0, temp1);
                temp0 = Avx512F.ShiftRightLogical(temp0, L);
                temp1 = Avx512F.ShiftRightLogical(temp1, L);
                rt1 = Narrow(temp0, temp1);
                y = rt1;
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{float}, Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup2Unzip_Permute(Vector512<float> data0, Vector512<float> data1, out Vector512<float> rt1) {
                var rt0 = Avx512F.PermuteVar16x32x2(data0, Vector512Constants.YGroup2Unzip_ShuffleX2_UInt32_X.AsInt32(), data1);
                rt1 = Avx512F.PermuteVar16x32x2(data0, Vector512Constants.YGroup2Unzip_ShuffleX2_UInt32_Y.AsInt32(), data1);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{double}, Vector512{double}, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup2Unzip_Permute(Vector512<double> data0, Vector512<double> data1, out Vector512<double> rt1) {
                var rt0 = Avx512F.PermuteVar8x64x2(data0, Vector512Constants.YGroup2Unzip_ShuffleX2_UInt64_X.AsInt64(), data1);
                rt1 = Avx512F.PermuteVar8x64x2(data0, Vector512Constants.YGroup2Unzip_ShuffleX2_UInt64_Y.AsInt64(), data1);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup2Unzip_Permute(Vector512<sbyte> data0, Vector512<sbyte> data1, out Vector512<sbyte> rt1) {
                var d0 = YGroup2Unzip_Permute(data0.AsByte(), data1.AsByte(), out var d1);
                rt1 = d1.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{byte}, Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup2Unzip_Permute(Vector512<byte> data0, Vector512<byte> data1, out Vector512<byte> rt1) {
                var rt0 = Avx512Vbmi.PermuteVar64x8x2(data0, Vector512Constants.YGroup2Unzip_ShuffleX2_Byte_X, data1);
                rt1 = Avx512Vbmi.PermuteVar64x8x2(data0, Vector512Constants.YGroup2Unzip_ShuffleX2_Byte_Y, data1);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{short}, Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup2Unzip_Permute(Vector512<short> data0, Vector512<short> data1, out Vector512<short> rt1) {
                var d0 = YGroup2Unzip_Permute(data0.AsUInt16(), data1.AsUInt16(), out var d1);
                rt1 = d1.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{ushort}, Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup2Unzip_Permute(Vector512<ushort> data0, Vector512<ushort> data1, out Vector512<ushort> rt1) {
                var rt0 = Avx512BW.PermuteVar32x16x2(data0, Vector512Constants.YGroup2Unzip_ShuffleX2_UInt16_X, data1);
                rt1 = Avx512BW.PermuteVar32x16x2(data0, Vector512Constants.YGroup2Unzip_ShuffleX2_UInt16_Y, data1);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{int}, Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup2Unzip_Permute(Vector512<int> data0, Vector512<int> data1, out Vector512<int> rt1) {
                var d0 = YGroup2Unzip_Permute(data0.AsUInt32(), data1.AsUInt32(), out var d1);
                rt1 = d1.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{uint}, Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup2Unzip_Permute(Vector512<uint> data0, Vector512<uint> data1, out Vector512<uint> rt1) {
                var rt0 = Avx512F.PermuteVar16x32x2(data0, Vector512Constants.YGroup2Unzip_ShuffleX2_UInt32_X, data1);
                rt1 = Avx512F.PermuteVar16x32x2(data0, Vector512Constants.YGroup2Unzip_ShuffleX2_UInt32_Y, data1);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{long}, Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup2Unzip_Permute(Vector512<long> data0, Vector512<long> data1, out Vector512<long> rt1) {
                var d0 = YGroup2Unzip_Permute(data0.AsUInt64(), data1.AsUInt64(), out var d1);
                rt1 = d1.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{ulong}, Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup2Unzip_Permute(Vector512<ulong> data0, Vector512<ulong> data1, out Vector512<ulong> rt1) {
                var rt0 = Avx512F.PermuteVar8x64x2(data0, Vector512Constants.YGroup2Unzip_ShuffleX2_UInt64_X, data1);
                rt1 = Avx512F.PermuteVar8x64x2(data0, Vector512Constants.YGroup2Unzip_ShuffleX2_UInt64_Y, data1);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{float}, Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup2Unzip_Unpack(Vector512<float> data0, Vector512<float> data1, out Vector512<float> y) {
                Vector512<float> temp0, temp1;
                Vector512<float> a_0, a_1, b_0, b_1;
                // Zip layer by 128-bits unpack.
                // 0 data0 x0 y0 x1 y1 x2 y2 x3 y3 x4 y4 x5 y5 x6 y6 x7 y7 data1 x8 y8 x9 y9 x10 y10 x11 y11 x12 y12 x13 y13 x14 y14 x15 y15
                //0b temp0 x0 y0 x1 y1 x4 y4 x5 y5 x8 y8 x9 y9 x12 y12 x13 y13 temp1 x2 y2 x3 y3 x6 y6 x7 y7 x10 y10 x11 y11 x14 y14 x15 y15
                temp0 = YGroup2Unzip_Int128(data0, data1, out temp1);
                // 1 a_0 x0 x2 y0 y2 x4 x6 y4 y6 x8 x10 y8 y10 x12 x14 y12 y14 a_1 x1 x3 y1 y3 x5 x7 y5 y7 x9 x11 y9 y11 x13 x15 y13 y15
                a_0 = Avx512F.UnpackLow(temp0, temp1);
                a_1 = Avx512F.UnpackHigh(temp0, temp1);
                // 2 b_0 x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 b_1 y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15
                b_0 = Avx512F.UnpackLow(a_0, a_1);
                b_1 = Avx512F.UnpackHigh(a_0, a_1);
                y = b_1;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{double}, Vector512{double}, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup2Unzip_Unpack(Vector512<double> data0, Vector512<double> data1, out Vector512<double> y) {
                Vector512<double> temp0, temp1;
                Vector512<double> a_0, a_1;
                // Zip layer by 128-bits unpack.
                // 0 data0 x0 y0 x1 y1 x2 y2 x3 y3 data1 x4 y4 x5 y5 x6 y6 x7 y7
                //0b temp0 x0 y0 x2 y2 x4 y4 x6 y6 temp1 x1 y1 x3 y3 x5 y5 x7 y7
                temp0 = YGroup2Unzip_Int128(data0, data1, out temp1);
                // 1 a_0 x0 x1 x2 x3 x4 x5 x6 x7 a_1 y0 y1 y2 y3 y4 y5 y6 y7
                a_0 = Avx512F.UnpackLow(temp0, temp1);
                a_1 = Avx512F.UnpackHigh(temp0, temp1);
                y = a_1;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup2Unzip_Unpack(Vector512<sbyte> data0, Vector512<sbyte> data1, out Vector512<sbyte> y) {
                var d0 = YGroup2Unzip_Unpack(data0.AsByte(), data1.AsByte(), out var d1);
                y = d1.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{byte}, Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup2Unzip_Unpack(Vector512<byte> data0, Vector512<byte> data1, out Vector512<byte> y) {
                Vector512<byte> temp0, temp1;
                Vector512<byte> a_0, a_1, b_0, b_1;
                // Zip layer by 128-bits unpack.
                // 0 data0 x0 y0 x1 y1 x2 y2 x3 y3 x4 y4 x5 y5 x6 y6 x7 y7 x8 y8 x9 y9 x10 y10 x11 y11 x12 y12 x13 y13 x14 y14 x15 y15 x16 y16 x17 y17 x18 y18 x19 y19 x20 y20 x21 y21 x22 y22 x23 y23 x24 y24 x25 y25 x26 y26 x27 y27 x28 y28 x29 y29 x30 y30 x31 y31 data1 x32 y32 x33 y33 x34 y34 x35 y35 x36 y36 x37 y37 x38 y38 x39 y39 x40 y40 x41 y41 x42 y42 x43 y43 x44 y44 x45 y45 x46 y46 x47 y47 x48 y48 x49 y49 x50 y50 x51 y51 x52 y52 x53 y53 x54 y54 x55 y55 x56 y56 x57 y57 x58 y58 x59 y59 x60 y60 x61 y61 x62 y62 x63 y63
                //0b temp0 x0 y0 x1 y1 x2 y2 x3 y3 x4 y4 x5 y5 x6 y6 x7 y7 x16 y16 x17 y17 x18 y18 x19 y19 x20 y20 x21 y21 x22 y22 x23 y23 x32 y32 x33 y33 x34 y34 x35 y35 x36 y36 x37 y37 x38 y38 x39 y39 x48 y48 x49 y49 x50 y50 x51 y51 x52 y52 x53 y53 x54 y54 x55 y55 temp1 x8 y8 x9 y9 x10 y10 x11 y11 x12 y12 x13 y13 x14 y14 x15 y15 x24 y24 x25 y25 x26 y26 x27 y27 x28 y28 x29 y29 x30 y30 x31 y31 x40 y40 x41 y41 x42 y42 x43 y43 x44 y44 x45 y45 x46 y46 x47 y47 x56 y56 x57 y57 x58 y58 x59 y59 x60 y60 x61 y61 x62 y62 x63 y63
                temp0 = YGroup2Unzip_Int128(data0, data1, out temp1);
                // 1 a_0 x0 x8 y0 y8 x1 x9 y1 y9 x2 x10 y2 y10 x3 x11 y3 y11 x16 x24 y16 y24 x17 x25 y17 y25 x18 x26 y18 y26 x19 x27 y19 y27 x32 x40 y32 y40 x33 x41 y33 y41 x34 x42 y34 y42 x35 x43 y35 y43 x48 x56 y48 y56 x49 x57 y49 y57 x50 x58 y50 y58 x51 x59 y51 y59 a_1 x4 x12 y4 y12 x5 x13 y5 y13 x6 x14 y6 y14 x7 x15 y7 y15 x20 x28 y20 y28 x21 x29 y21 y29 x22 x30 y22 y30 x23 x31 y23 y31 x36 x44 y36 y44 x37 x45 y37 y45 x38 x46 y38 y46 x39 x47 y39 y47 x52 x60 y52 y60 x53 x61 y53 y61 x54 x62 y54 y62 x55 x63 y55 y63
                a_0 = Avx512BW.UnpackLow(temp0, temp1);
                a_1 = Avx512BW.UnpackHigh(temp0, temp1);
                // 2 b_0 x0 x4 x8 x12 y0 y4 y8 y12 x1 x5 x9 x13 y1 y5 y9 y13 x16 x20 x24 x28 y16 y20 y24 y28 x17 x21 x25 x29 y17 y21 y25 y29 x32 x36 x40 x44 y32 y36 y40 y44 x33 x37 x41 x45 y33 y37 y41 y45 x48 x52 x56 x60 y48 y52 y56 y60 x49 x53 x57 x61 y49 y53 y57 y61 b_1 x2 x6 x10 x14 y2 y6 y10 y14 x3 x7 x11 x15 y3 y7 y11 y15 x18 x22 x26 x30 y18 y22 y26 y30 x19 x23 x27 x31 y19 y23 y27 y31 x34 x38 x42 x46 y34 y38 y42 y46 x35 x39 x43 x47 y35 y39 y43 y47 x50 x54 x58 x62 y50 y54 y58 y62 x51 x55 x59 x63 y51 y55 y59 y63
                b_0 = Avx512BW.UnpackLow(a_0, a_1);
                b_1 = Avx512BW.UnpackHigh(a_0, a_1);
                // 3 a_0 x0 x2 x4 x6 x8 x10 x12 x14 y0 y2 y4 y6 y8 y10 y12 y14 x16 x18 x20 x22 x24 x26 x28 x30 y16 y18 y20 y22 y24 y26 y28 y30 x32 x34 x36 x38 x40 x42 x44 x46 y32 y34 y36 y38 y40 y42 y44 y46 x48 x50 x52 x54 x56 x58 x60 x62 y48 y50 y52 y54 y56 y58 y60 y62 a_1 x1 x3 x5 x7 x9 x11 x13 x15 y1 y3 y5 y7 y9 y11 y13 y15 x17 x19 x21 x23 x25 x27 x29 x31 y17 y19 y21 y23 y25 y27 y29 y31 x33 x35 x37 x39 x41 x43 x45 x47 y33 y35 y37 y39 y41 y43 y45 y47 x49 x51 x53 x55 x57 x59 x61 x63 y49 y51 y53 y55 y57 y59 y61 y63
                a_0 = Avx512BW.UnpackLow(b_0, b_1);
                a_1 = Avx512BW.UnpackHigh(b_0, b_1);
                // 4 b_0 x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 x16 x17 x18 x19 x20 x21 x22 x23 x24 x25 x26 x27 x28 x29 x30 x31 x32 x33 x34 x35 x36 x37 x38 x39 x40 x41 x42 x43 x44 x45 x46 x47 x48 x49 x50 x51 x52 x53 x54 x55 x56 x57 x58 x59 x60 x61 x62 x63 b_1 y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 y16 y17 y18 y19 y20 y21 y22 y23 y24 y25 y26 y27 y28 y29 y30 y31 y32 y33 y34 y35 y36 y37 y38 y39 y40 y41 y42 y43 y44 y45 y46 y47 y48 y49 y50 y51 y52 y53 y54 y55 y56 y57 y58 y59 y60 y61 y62 y63
                b_0 = Avx512BW.UnpackLow(a_0, a_1);
                b_1 = Avx512BW.UnpackHigh(a_0, a_1);
                y = b_1;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{short}, Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup2Unzip_Unpack(Vector512<short> data0, Vector512<short> data1, out Vector512<short> y) {
                var d0 = YGroup2Unzip_Unpack(data0.AsUInt16(), data1.AsUInt16(), out var d1);
                y = d1.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{ushort}, Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup2Unzip_Unpack(Vector512<ushort> data0, Vector512<ushort> data1, out Vector512<ushort> y) {
                Vector512<ushort> temp0, temp1;
                Vector512<ushort> a_0, a_1, b_0, b_1;
                // Zip layer by 128-bits unpack.
                // 0 data0 x0 y0 x1 y1 x2 y2 x3 y3 x4 y4 x5 y5 x6 y6 x7 y7 x8 y8 x9 y9 x10 y10 x11 y11 x12 y12 x13 y13 x14 y14 x15 y15 data1 x16 y16 x17 y17 x18 y18 x19 y19 x20 y20 x21 y21 x22 y22 x23 y23 x24 y24 x25 y25 x26 y26 x27 y27 x28 y28 x29 y29 x30 y30 x31 y31
                //0b temp0 x0 y0 x1 y1 x2 y2 x3 y3 x8 y8 x9 y9 x10 y10 x11 y11 x16 y16 x17 y17 x18 y18 x19 y19 x24 y24 x25 y25 x26 y26 x27 y27 temp1 x4 y4 x5 y5 x6 y6 x7 y7 x12 y12 x13 y13 x14 y14 x15 y15 x20 y20 x21 y21 x22 y22 x23 y23 x28 y28 x29 y29 x30 y30 x31 y31
                temp0 = YGroup2Unzip_Int128(data0, data1, out temp1);
                // 1 a_0 x0 x4 y0 y4 x1 x5 y1 y5 x8 x12 y8 y12 x9 x13 y9 y13 x16 x20 y16 y20 x17 x21 y17 y21 x24 x28 y24 y28 x25 x29 y25 y29 a_1 x2 x6 y2 y6 x3 x7 y3 y7 x10 x14 y10 y14 x11 x15 y11 y15 x18 x22 y18 y22 x19 x23 y19 y23 x26 x30 y26 y30 x27 x31 y27 y31
                a_0 = Avx512BW.UnpackLow(temp0, temp1);
                a_1 = Avx512BW.UnpackHigh(temp0, temp1);
                // 2 b_0 x0 x2 x4 x6 y0 y2 y4 y6 x8 x10 x12 x14 y8 y10 y12 y14 x16 x18 x20 x22 y16 y18 y20 y22 x24 x26 x28 x30 y24 y26 y28 y30 b_1 x1 x3 x5 x7 y1 y3 y5 y7 x9 x11 x13 x15 y9 y11 y13 y15 x17 x19 x21 x23 y17 y19 y21 y23 x25 x27 x29 x31 y25 y27 y29 y31
                b_0 = Avx512BW.UnpackLow(a_0, a_1);
                b_1 = Avx512BW.UnpackHigh(a_0, a_1);
                // 3 a_0 x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 x16 x17 x18 x19 x20 x21 x22 x23 x24 x25 x26 x27 x28 x29 x30 x31 a_1 y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 y16 y17 y18 y19 y20 y21 y22 y23 y24 y25 y26 y27 y28 y29 y30 y31
                a_0 = Avx512BW.UnpackLow(b_0, b_1);
                a_1 = Avx512BW.UnpackHigh(b_0, b_1);
                y = a_1;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{int}, Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup2Unzip_Unpack(Vector512<int> data0, Vector512<int> data1, out Vector512<int> y) {
                var d0 = YGroup2Unzip_Unpack(data0.AsUInt32(), data1.AsUInt32(), out var d1);
                y = d1.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{uint}, Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup2Unzip_Unpack(Vector512<uint> data0, Vector512<uint> data1, out Vector512<uint> y) {
                Vector512<uint> temp0, temp1;
                Vector512<uint> a_0, a_1, b_0, b_1;
                // Zip layer by 128-bits unpack.
                // 0 data0 x0 y0 x1 y1 x2 y2 x3 y3 x4 y4 x5 y5 x6 y6 x7 y7 data1 x8 y8 x9 y9 x10 y10 x11 y11 x12 y12 x13 y13 x14 y14 x15 y15
                //0b temp0 x0 y0 x1 y1 x4 y4 x5 y5 x8 y8 x9 y9 x12 y12 x13 y13 temp1 x2 y2 x3 y3 x6 y6 x7 y7 x10 y10 x11 y11 x14 y14 x15 y15
                temp0 = YGroup2Unzip_Int128(data0, data1, out temp1);
                // 1 a_0 x0 x2 y0 y2 x4 x6 y4 y6 x8 x10 y8 y10 x12 x14 y12 y14 a_1 x1 x3 y1 y3 x5 x7 y5 y7 x9 x11 y9 y11 x13 x15 y13 y15
                a_0 = Avx512F.UnpackLow(temp0, temp1);
                a_1 = Avx512F.UnpackHigh(temp0, temp1);
                // 2 b_0 x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 b_1 y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15
                b_0 = Avx512F.UnpackLow(a_0, a_1);
                b_1 = Avx512F.UnpackHigh(a_0, a_1);
                y = b_1;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{long}, Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup2Unzip_Unpack(Vector512<long> data0, Vector512<long> data1, out Vector512<long> y) {
                var d0 = YGroup2Unzip_Unpack(data0.AsUInt64(), data1.AsUInt64(), out var d1);
                y = d1.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{ulong}, Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup2Unzip_Unpack(Vector512<ulong> data0, Vector512<ulong> data1, out Vector512<ulong> y) {
                Vector512<ulong> temp0, temp1;
                Vector512<ulong> a_0, a_1;
                // Zip layer by 128-bits unpack.
                // 0 data0 x0 y0 x1 y1 x2 y2 x3 y3 data1 x4 y4 x5 y5 x6 y6 x7 y7
                //0b temp0 x0 y0 x2 y2 x4 y4 x6 y6 temp1 x1 y1 x3 y3 x5 y5 x7 y7
                temp0 = YGroup2Unzip_Int128(data0, data1, out temp1);
                // 1 a_0 x0 x1 x2 x3 x4 x5 x6 x7 a_1 y0 y1 y2 y3 y4 y5 y6 y7
                a_0 = Avx512F.UnpackLow(temp0, temp1);
                a_1 = Avx512F.UnpackHigh(temp0, temp1);
                y = a_1;
                return a_0;
            }


            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2UnzipEven_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes | TypeCodeFlags.Int128 | TypeCodeFlags.UInt128;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup2UnzipEven(Vector512<float> data0, Vector512<float> data1) {
                return YGroup2UnzipEven_Permute(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup2UnzipEven(Vector512<double> data0, Vector512<double> data1) {
                return YGroup2UnzipEven_Permute(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup2UnzipEven(Vector512<sbyte> data0, Vector512<sbyte> data1) {
                return YGroup2UnzipEven_Permute(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup2UnzipEven(Vector512<byte> data0, Vector512<byte> data1) {
                return YGroup2UnzipEven_Permute(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup2UnzipEven(Vector512<short> data0, Vector512<short> data1) {
                return YGroup2UnzipEven_Permute(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup2UnzipEven(Vector512<ushort> data0, Vector512<ushort> data1) {
                return YGroup2UnzipEven_Permute(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup2UnzipEven(Vector512<int> data0, Vector512<int> data1) {
                return YGroup2UnzipEven_Permute(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup2UnzipEven(Vector512<uint> data0, Vector512<uint> data1) {
                return YGroup2UnzipEven_Permute(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup2UnzipEven(Vector512<long> data0, Vector512<long> data1) {
                return YGroup2UnzipEven_Permute(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup2UnzipEven(Vector512<ulong> data0, Vector512<ulong> data1) {
                return YGroup2UnzipEven_Permute(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{ExInt128}, Vector512{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExInt128> YGroup2UnzipEven(Vector512<ExInt128> data0, Vector512<ExInt128> data1) {
                return Avx512F.Shuffle4x128(data0.ExAsUInt64(), data1.ExAsUInt64(), (byte)ShuffleControlG4.XZXZ).ExAsExInt128();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{ExUInt128}, Vector512{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExUInt128> YGroup2UnzipEven(Vector512<ExUInt128> data0, Vector512<ExUInt128> data1) {
                return Avx512F.Shuffle4x128(data0.ExAsUInt64(), data1.ExAsUInt64(), (byte)ShuffleControlG4.XZXZ).ExAsExUInt128();
            }

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
                Vector512<byte> rt0;
                Vector512<ushort> temp0 = data0.AsUInt16();
                Vector512<ushort> temp1 = data1.AsUInt16();
                rt0 = Narrow(temp0, temp1);
                return rt0;
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
                Vector512<ushort> rt0;
                Vector512<uint> temp0 = data0.AsUInt32();
                Vector512<uint> temp1 = data1.AsUInt32();
                rt0 = Narrow(temp0, temp1); // 8, 2.66
                return rt0;
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
                Vector512<uint> rt0;
                Vector512<ulong> temp0 = data0.AsUInt64();
                Vector512<ulong> temp1 = data1.AsUInt64();
                rt0 = Narrow(temp0, temp1);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup2UnzipEven_Permute(Vector512<float> data0, Vector512<float> data1) {
                return Avx512F.PermuteVar16x32x2(data0, Vector512Constants.YGroup2Unzip_ShuffleX2_UInt32_X.AsInt32(), data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup2UnzipEven_Permute(Vector512<double> data0, Vector512<double> data1) {
                return Avx512F.PermuteVar8x64x2(data0, Vector512Constants.YGroup2Unzip_ShuffleX2_UInt64_X.AsInt64(), data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup2UnzipEven_Permute(Vector512<sbyte> data0, Vector512<sbyte> data1) {
                return YGroup2UnzipEven_Permute(data0.AsByte(), data1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup2UnzipEven_Permute(Vector512<byte> data0, Vector512<byte> data1) {
                return Avx512Vbmi.PermuteVar64x8x2(data0, Vector512Constants.YGroup2Unzip_ShuffleX2_Byte_X, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup2UnzipEven_Permute(Vector512<short> data0, Vector512<short> data1) {
                return YGroup2UnzipEven_Permute(data0.AsUInt16(), data1.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup2UnzipEven_Permute(Vector512<ushort> data0, Vector512<ushort> data1) {
                return Avx512BW.PermuteVar32x16x2(data0, Vector512Constants.YGroup2Unzip_ShuffleX2_UInt16_X, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup2UnzipEven_Permute(Vector512<int> data0, Vector512<int> data1) {
                return YGroup2UnzipEven_Permute(data0.AsUInt32(), data1.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup2UnzipEven_Permute(Vector512<uint> data0, Vector512<uint> data1) {
                return Avx512F.PermuteVar16x32x2(data0, Vector512Constants.YGroup2Unzip_ShuffleX2_UInt32_X, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup2UnzipEven_Permute(Vector512<long> data0, Vector512<long> data1) {
                return YGroup2UnzipEven_Permute(data0.AsUInt64(), data1.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup2UnzipEven_Permute(Vector512<ulong> data0, Vector512<ulong> data1) {
                return Avx512F.PermuteVar8x64x2(data0, Vector512Constants.YGroup2Unzip_ShuffleX2_UInt64_X, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup2UnzipEven_Unpack(Vector512<float> data0, Vector512<float> data1) {
                Vector512<float> temp0, temp1;
                Vector512<float> a_0, a_1, b_0;
                // Zip layer by 128-bits unpack.
                // 0 data0 x0 y0 x1 y1 x2 y2 x3 y3 x4 y4 x5 y5 x6 y6 x7 y7 data1 x8 y8 x9 y9 x10 y10 x11 y11 x12 y12 x13 y13 x14 y14 x15 y15
                //0b temp0 x0 y0 x1 y1 x4 y4 x5 y5 x8 y8 x9 y9 x12 y12 x13 y13 temp1 x2 y2 x3 y3 x6 y6 x7 y7 x10 y10 x11 y11 x14 y14 x15 y15
                temp0 = YGroup2Unzip_Int128(data0, data1, out temp1);
                // 1 a_0 x0 x2 y0 y2 x4 x6 y4 y6 x8 x10 y8 y10 x12 x14 y12 y14 a_1 x1 x3 y1 y3 x5 x7 y5 y7 x9 x11 y9 y11 x13 x15 y13 y15
                a_0 = Avx512F.UnpackLow(temp0, temp1);
                a_1 = Avx512F.UnpackHigh(temp0, temp1);
                // 2 b_0 x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 b_1 y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15
                b_0 = Avx512F.UnpackLow(a_0, a_1);
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup2UnzipEven_Unpack(Vector512<double> data0, Vector512<double> data1) {
                Vector512<double> temp0, temp1;
                Vector512<double> a_0;
                // Zip layer by 128-bits unpack.
                // 0 data0 x0 y0 x1 y1 x2 y2 x3 y3 data1 x4 y4 x5 y5 x6 y6 x7 y7
                //0b temp0 x0 y0 x2 y2 x4 y4 x6 y6 temp1 x1 y1 x3 y3 x5 y5 x7 y7
                temp0 = YGroup2Unzip_Int128(data0, data1, out temp1);
                // 1 a_0 x0 x1 x2 x3 x4 x5 x6 x7 a_1 y0 y1 y2 y3 y4 y5 y6 y7
                a_0 = Avx512F.UnpackLow(temp0, temp1);
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup2UnzipEven_Unpack(Vector512<sbyte> data0, Vector512<sbyte> data1) {
                return YGroup2UnzipEven_Unpack(data0.AsByte(), data1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup2UnzipEven_Unpack(Vector512<byte> data0, Vector512<byte> data1) {
                Vector512<byte> temp0, temp1;
                Vector512<byte> a_0, a_1, b_0, b_1;
                // Zip layer by 128-bits unpack.
                // 0 data0 x0 y0 x1 y1 x2 y2 x3 y3 x4 y4 x5 y5 x6 y6 x7 y7 x8 y8 x9 y9 x10 y10 x11 y11 x12 y12 x13 y13 x14 y14 x15 y15 x16 y16 x17 y17 x18 y18 x19 y19 x20 y20 x21 y21 x22 y22 x23 y23 x24 y24 x25 y25 x26 y26 x27 y27 x28 y28 x29 y29 x30 y30 x31 y31 data1 x32 y32 x33 y33 x34 y34 x35 y35 x36 y36 x37 y37 x38 y38 x39 y39 x40 y40 x41 y41 x42 y42 x43 y43 x44 y44 x45 y45 x46 y46 x47 y47 x48 y48 x49 y49 x50 y50 x51 y51 x52 y52 x53 y53 x54 y54 x55 y55 x56 y56 x57 y57 x58 y58 x59 y59 x60 y60 x61 y61 x62 y62 x63 y63
                //0b temp0 x0 y0 x1 y1 x2 y2 x3 y3 x4 y4 x5 y5 x6 y6 x7 y7 x16 y16 x17 y17 x18 y18 x19 y19 x20 y20 x21 y21 x22 y22 x23 y23 x32 y32 x33 y33 x34 y34 x35 y35 x36 y36 x37 y37 x38 y38 x39 y39 x48 y48 x49 y49 x50 y50 x51 y51 x52 y52 x53 y53 x54 y54 x55 y55 temp1 x8 y8 x9 y9 x10 y10 x11 y11 x12 y12 x13 y13 x14 y14 x15 y15 x24 y24 x25 y25 x26 y26 x27 y27 x28 y28 x29 y29 x30 y30 x31 y31 x40 y40 x41 y41 x42 y42 x43 y43 x44 y44 x45 y45 x46 y46 x47 y47 x56 y56 x57 y57 x58 y58 x59 y59 x60 y60 x61 y61 x62 y62 x63 y63
                temp0 = YGroup2Unzip_Int128(data0, data1, out temp1);
                // 1 a_0 x0 x8 y0 y8 x1 x9 y1 y9 x2 x10 y2 y10 x3 x11 y3 y11 x16 x24 y16 y24 x17 x25 y17 y25 x18 x26 y18 y26 x19 x27 y19 y27 x32 x40 y32 y40 x33 x41 y33 y41 x34 x42 y34 y42 x35 x43 y35 y43 x48 x56 y48 y56 x49 x57 y49 y57 x50 x58 y50 y58 x51 x59 y51 y59 a_1 x4 x12 y4 y12 x5 x13 y5 y13 x6 x14 y6 y14 x7 x15 y7 y15 x20 x28 y20 y28 x21 x29 y21 y29 x22 x30 y22 y30 x23 x31 y23 y31 x36 x44 y36 y44 x37 x45 y37 y45 x38 x46 y38 y46 x39 x47 y39 y47 x52 x60 y52 y60 x53 x61 y53 y61 x54 x62 y54 y62 x55 x63 y55 y63
                a_0 = Avx512BW.UnpackLow(temp0, temp1);
                a_1 = Avx512BW.UnpackHigh(temp0, temp1);
                // 2 b_0 x0 x4 x8 x12 y0 y4 y8 y12 x1 x5 x9 x13 y1 y5 y9 y13 x16 x20 x24 x28 y16 y20 y24 y28 x17 x21 x25 x29 y17 y21 y25 y29 x32 x36 x40 x44 y32 y36 y40 y44 x33 x37 x41 x45 y33 y37 y41 y45 x48 x52 x56 x60 y48 y52 y56 y60 x49 x53 x57 x61 y49 y53 y57 y61 b_1 x2 x6 x10 x14 y2 y6 y10 y14 x3 x7 x11 x15 y3 y7 y11 y15 x18 x22 x26 x30 y18 y22 y26 y30 x19 x23 x27 x31 y19 y23 y27 y31 x34 x38 x42 x46 y34 y38 y42 y46 x35 x39 x43 x47 y35 y39 y43 y47 x50 x54 x58 x62 y50 y54 y58 y62 x51 x55 x59 x63 y51 y55 y59 y63
                b_0 = Avx512BW.UnpackLow(a_0, a_1);
                b_1 = Avx512BW.UnpackHigh(a_0, a_1);
                // 3 a_0 x0 x2 x4 x6 x8 x10 x12 x14 y0 y2 y4 y6 y8 y10 y12 y14 x16 x18 x20 x22 x24 x26 x28 x30 y16 y18 y20 y22 y24 y26 y28 y30 x32 x34 x36 x38 x40 x42 x44 x46 y32 y34 y36 y38 y40 y42 y44 y46 x48 x50 x52 x54 x56 x58 x60 x62 y48 y50 y52 y54 y56 y58 y60 y62 a_1 x1 x3 x5 x7 x9 x11 x13 x15 y1 y3 y5 y7 y9 y11 y13 y15 x17 x19 x21 x23 x25 x27 x29 x31 y17 y19 y21 y23 y25 y27 y29 y31 x33 x35 x37 x39 x41 x43 x45 x47 y33 y35 y37 y39 y41 y43 y45 y47 x49 x51 x53 x55 x57 x59 x61 x63 y49 y51 y53 y55 y57 y59 y61 y63
                a_0 = Avx512BW.UnpackLow(b_0, b_1);
                a_1 = Avx512BW.UnpackHigh(b_0, b_1);
                // 4 b_0 x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 x16 x17 x18 x19 x20 x21 x22 x23 x24 x25 x26 x27 x28 x29 x30 x31 x32 x33 x34 x35 x36 x37 x38 x39 x40 x41 x42 x43 x44 x45 x46 x47 x48 x49 x50 x51 x52 x53 x54 x55 x56 x57 x58 x59 x60 x61 x62 x63 b_1 y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 y16 y17 y18 y19 y20 y21 y22 y23 y24 y25 y26 y27 y28 y29 y30 y31 y32 y33 y34 y35 y36 y37 y38 y39 y40 y41 y42 y43 y44 y45 y46 y47 y48 y49 y50 y51 y52 y53 y54 y55 y56 y57 y58 y59 y60 y61 y62 y63
                b_0 = Avx512BW.UnpackLow(a_0, a_1);
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup2UnzipEven_Unpack(Vector512<short> data0, Vector512<short> data1) {
                return YGroup2UnzipEven_Unpack(data0.AsUInt16(), data1.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup2UnzipEven_Unpack(Vector512<ushort> data0, Vector512<ushort> data1) {
                Vector512<ushort> temp0, temp1;
                Vector512<ushort> a_0, a_1, b_0, b_1;
                // Zip layer by 128-bits unpack.
                // 0 data0 x0 y0 x1 y1 x2 y2 x3 y3 x4 y4 x5 y5 x6 y6 x7 y7 x8 y8 x9 y9 x10 y10 x11 y11 x12 y12 x13 y13 x14 y14 x15 y15 data1 x16 y16 x17 y17 x18 y18 x19 y19 x20 y20 x21 y21 x22 y22 x23 y23 x24 y24 x25 y25 x26 y26 x27 y27 x28 y28 x29 y29 x30 y30 x31 y31
                //0b temp0 x0 y0 x1 y1 x2 y2 x3 y3 x8 y8 x9 y9 x10 y10 x11 y11 x16 y16 x17 y17 x18 y18 x19 y19 x24 y24 x25 y25 x26 y26 x27 y27 temp1 x4 y4 x5 y5 x6 y6 x7 y7 x12 y12 x13 y13 x14 y14 x15 y15 x20 y20 x21 y21 x22 y22 x23 y23 x28 y28 x29 y29 x30 y30 x31 y31
                temp0 = YGroup2Unzip_Int128(data0, data1, out temp1);
                // 1 a_0 x0 x4 y0 y4 x1 x5 y1 y5 x8 x12 y8 y12 x9 x13 y9 y13 x16 x20 y16 y20 x17 x21 y17 y21 x24 x28 y24 y28 x25 x29 y25 y29 a_1 x2 x6 y2 y6 x3 x7 y3 y7 x10 x14 y10 y14 x11 x15 y11 y15 x18 x22 y18 y22 x19 x23 y19 y23 x26 x30 y26 y30 x27 x31 y27 y31
                a_0 = Avx512BW.UnpackLow(temp0, temp1);
                a_1 = Avx512BW.UnpackHigh(temp0, temp1);
                // 2 b_0 x0 x2 x4 x6 y0 y2 y4 y6 x8 x10 x12 x14 y8 y10 y12 y14 x16 x18 x20 x22 y16 y18 y20 y22 x24 x26 x28 x30 y24 y26 y28 y30 b_1 x1 x3 x5 x7 y1 y3 y5 y7 x9 x11 x13 x15 y9 y11 y13 y15 x17 x19 x21 x23 y17 y19 y21 y23 x25 x27 x29 x31 y25 y27 y29 y31
                b_0 = Avx512BW.UnpackLow(a_0, a_1);
                b_1 = Avx512BW.UnpackHigh(a_0, a_1);
                // 3 a_0 x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 x16 x17 x18 x19 x20 x21 x22 x23 x24 x25 x26 x27 x28 x29 x30 x31 a_1 y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 y16 y17 y18 y19 y20 y21 y22 y23 y24 y25 y26 y27 y28 y29 y30 y31
                a_0 = Avx512BW.UnpackLow(b_0, b_1);
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup2UnzipEven_Unpack(Vector512<int> data0, Vector512<int> data1) {
                return YGroup2UnzipEven_Unpack(data0.AsUInt32(), data1.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup2UnzipEven_Unpack(Vector512<uint> data0, Vector512<uint> data1) {
                Vector512<uint> temp0, temp1;
                Vector512<uint> a_0, a_1, b_0;
                // Zip layer by 128-bits unpack.
                // 0 data0 x0 y0 x1 y1 x2 y2 x3 y3 x4 y4 x5 y5 x6 y6 x7 y7 data1 x8 y8 x9 y9 x10 y10 x11 y11 x12 y12 x13 y13 x14 y14 x15 y15
                //0b temp0 x0 y0 x1 y1 x4 y4 x5 y5 x8 y8 x9 y9 x12 y12 x13 y13 temp1 x2 y2 x3 y3 x6 y6 x7 y7 x10 y10 x11 y11 x14 y14 x15 y15
                temp0 = YGroup2Unzip_Int128(data0, data1, out temp1);
                // 1 a_0 x0 x2 y0 y2 x4 x6 y4 y6 x8 x10 y8 y10 x12 x14 y12 y14 a_1 x1 x3 y1 y3 x5 x7 y5 y7 x9 x11 y9 y11 x13 x15 y13 y15
                a_0 = Avx512F.UnpackLow(temp0, temp1);
                a_1 = Avx512F.UnpackHigh(temp0, temp1);
                // 2 b_0 x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 b_1 y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15
                b_0 = Avx512F.UnpackLow(a_0, a_1);
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup2UnzipEven_Unpack(Vector512<long> data0, Vector512<long> data1) {
                return YGroup2UnzipEven_Unpack(data0.AsUInt64(), data1.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipEven(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup2UnzipEven_Unpack(Vector512<ulong> data0, Vector512<ulong> data1) {
                Vector512<ulong> temp0, temp1;
                Vector512<ulong> a_0;
                // Zip layer by 128-bits unpack.
                // 0 data0 x0 y0 x1 y1 x2 y2 x3 y3 data1 x4 y4 x5 y5 x6 y6 x7 y7
                //0b temp0 x0 y0 x2 y2 x4 y4 x6 y6 temp1 x1 y1 x3 y3 x5 y5 x7 y7
                temp0 = YGroup2Unzip_Int128(data0, data1, out temp1);
                // 1 a_0 x0 x1 x2 x3 x4 x5 x6 x7 a_1 y0 y1 y2 y3 y4 y5 y6 y7
                a_0 = Avx512F.UnpackLow(temp0, temp1);
                return a_0;
            }


            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2UnzipOdd_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes | TypeCodeFlags.Int128 | TypeCodeFlags.UInt128;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup2UnzipOdd(Vector512<float> data0, Vector512<float> data1) {
                return YGroup2UnzipOdd_Permute(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup2UnzipOdd(Vector512<double> data0, Vector512<double> data1) {
                return YGroup2UnzipOdd_Permute(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup2UnzipOdd(Vector512<sbyte> data0, Vector512<sbyte> data1) {
                return YGroup2UnzipOdd_Permute(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup2UnzipOdd(Vector512<byte> data0, Vector512<byte> data1) {
                return YGroup2UnzipOdd_Permute(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup2UnzipOdd(Vector512<short> data0, Vector512<short> data1) {
                return YGroup2UnzipOdd_Permute(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup2UnzipOdd(Vector512<ushort> data0, Vector512<ushort> data1) {
                return YGroup2UnzipOdd_Permute(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup2UnzipOdd(Vector512<int> data0, Vector512<int> data1) {
                return YGroup2UnzipOdd_Permute(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup2UnzipOdd(Vector512<uint> data0, Vector512<uint> data1) {
                return YGroup2UnzipOdd_Permute(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup2UnzipOdd(Vector512<long> data0, Vector512<long> data1) {
                return YGroup2UnzipOdd_Unpack(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup2UnzipOdd(Vector512<ulong> data0, Vector512<ulong> data1) {
                return YGroup2UnzipOdd_Unpack(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{ExInt128}, Vector512{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExInt128> YGroup2UnzipOdd(Vector512<ExInt128> data0, Vector512<ExInt128> data1) {
                return Avx512F.Shuffle4x128(data0.ExAsUInt64(), data1.ExAsUInt64(), (byte)ShuffleControlG4.YWYW).ExAsExInt128();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{ExUInt128}, Vector512{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExUInt128> YGroup2UnzipOdd(Vector512<ExUInt128> data0, Vector512<ExUInt128> data1) {
                return Avx512F.Shuffle4x128(data0.ExAsUInt64(), data1.ExAsUInt64(), (byte)ShuffleControlG4.YWYW).ExAsExUInt128();
            }

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
                Vector512<byte> rt1;
                Vector512<ushort> temp0 = data0.AsUInt16();
                Vector512<ushort> temp1 = data1.AsUInt16();
                temp0 = Avx512BW.ShiftRightLogical(temp0, L);
                temp1 = Avx512BW.ShiftRightLogical(temp1, L);
                rt1 = Narrow(temp0, temp1);
                return rt1;
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
                Vector512<ushort> rt1;
                Vector512<uint> temp0 = data0.AsUInt32();
                Vector512<uint> temp1 = data1.AsUInt32();
                temp0 = Avx512F.ShiftRightLogical(temp0, L); // 1,0.5
                temp1 = Avx512F.ShiftRightLogical(temp1, L); // 1,0.5
                rt1 = Narrow(temp0, temp1); // 8, 2.66
                return rt1;
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
                Vector512<uint> rt1;
                Vector512<ulong> temp0 = data0.AsUInt64();
                Vector512<ulong> temp1 = data1.AsUInt64();
                temp0 = Avx512F.ShiftRightLogical(temp0, L);
                temp1 = Avx512F.ShiftRightLogical(temp1, L);
                rt1 = Narrow(temp0, temp1);
                return rt1;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup2UnzipOdd_Permute(Vector512<float> data0, Vector512<float> data1) {
                return Avx512F.PermuteVar16x32x2(data0, Vector512Constants.YGroup2Unzip_ShuffleX2_UInt32_Y.AsInt32(), data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup2UnzipOdd_Permute(Vector512<double> data0, Vector512<double> data1) {
                return Avx512F.PermuteVar8x64x2(data0, Vector512Constants.YGroup2Unzip_ShuffleX2_UInt64_Y.AsInt64(), data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup2UnzipOdd_Permute(Vector512<sbyte> data0, Vector512<sbyte> data1) {
                return YGroup2UnzipOdd_Permute(data0.AsByte(), data1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup2UnzipOdd_Permute(Vector512<byte> data0, Vector512<byte> data1) {
                return Avx512Vbmi.PermuteVar64x8x2(data0, Vector512Constants.YGroup2Unzip_ShuffleX2_Byte_Y, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup2UnzipOdd_Permute(Vector512<short> data0, Vector512<short> data1) {
                return YGroup2UnzipOdd_Permute(data0.AsUInt16(), data1.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup2UnzipOdd_Permute(Vector512<ushort> data0, Vector512<ushort> data1) {
                return Avx512BW.PermuteVar32x16x2(data0, Vector512Constants.YGroup2Unzip_ShuffleX2_UInt16_Y, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup2UnzipOdd_Permute(Vector512<int> data0, Vector512<int> data1) {
                return YGroup2UnzipOdd_Permute(data0.AsUInt32(), data1.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup2UnzipOdd_Permute(Vector512<uint> data0, Vector512<uint> data1) {
                return Avx512F.PermuteVar16x32x2(data0, Vector512Constants.YGroup2Unzip_ShuffleX2_UInt32_Y, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup2UnzipOdd_Permute(Vector512<long> data0, Vector512<long> data1) {
                return YGroup2UnzipOdd_Permute(data0.AsUInt64(), data1.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup2UnzipOdd_Permute(Vector512<ulong> data0, Vector512<ulong> data1) {
                return Avx512F.PermuteVar8x64x2(data0, Vector512Constants.YGroup2Unzip_ShuffleX2_UInt64_Y, data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup2UnzipOdd_Unpack(Vector512<float> data0, Vector512<float> data1) {
                Vector512<float> temp0, temp1;
                Vector512<float> a_0, a_1, b_1;
                // Zip layer by 128-bits unpack.
                // 0 data0 x0 y0 x1 y1 x2 y2 x3 y3 x4 y4 x5 y5 x6 y6 x7 y7 data1 x8 y8 x9 y9 x10 y10 x11 y11 x12 y12 x13 y13 x14 y14 x15 y15
                //0b temp0 x0 y0 x1 y1 x4 y4 x5 y5 x8 y8 x9 y9 x12 y12 x13 y13 temp1 x2 y2 x3 y3 x6 y6 x7 y7 x10 y10 x11 y11 x14 y14 x15 y15
                temp0 = YGroup2Unzip_Int128(data0, data1, out temp1);
                // 1 a_0 x0 x2 y0 y2 x4 x6 y4 y6 x8 x10 y8 y10 x12 x14 y12 y14 a_1 x1 x3 y1 y3 x5 x7 y5 y7 x9 x11 y9 y11 x13 x15 y13 y15
                a_0 = Avx512F.UnpackLow(temp0, temp1);
                a_1 = Avx512F.UnpackHigh(temp0, temp1);
                // 2 b_0 x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 b_1 y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15
                b_1 = Avx512F.UnpackHigh(a_0, a_1);
                return b_1;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup2UnzipOdd_Unpack(Vector512<double> data0, Vector512<double> data1) {
                Vector512<double> temp0, temp1;
                Vector512<double> a_1;
                // Zip layer by 128-bits unpack.
                // 0 data0 x0 y0 x1 y1 x2 y2 x3 y3 data1 x4 y4 x5 y5 x6 y6 x7 y7
                //0b temp0 x0 y0 x2 y2 x4 y4 x6 y6 temp1 x1 y1 x3 y3 x5 y5 x7 y7
                temp0 = YGroup2Unzip_Int128(data0, data1, out temp1);
                // 1 a_0 x0 x1 x2 x3 x4 x5 x6 x7 a_1 y0 y1 y2 y3 y4 y5 y6 y7
                a_1 = Avx512F.UnpackHigh(temp0, temp1);
                return a_1;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup2UnzipOdd_Unpack(Vector512<sbyte> data0, Vector512<sbyte> data1) {
                return YGroup2UnzipOdd_Unpack(data0.AsByte(), data1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup2UnzipOdd_Unpack(Vector512<byte> data0, Vector512<byte> data1) {
                Vector512<byte> temp0, temp1;
                Vector512<byte> a_0, a_1, b_0, b_1;
                // Zip layer by 128-bits unpack.
                // 0 data0 x0 y0 x1 y1 x2 y2 x3 y3 x4 y4 x5 y5 x6 y6 x7 y7 x8 y8 x9 y9 x10 y10 x11 y11 x12 y12 x13 y13 x14 y14 x15 y15 x16 y16 x17 y17 x18 y18 x19 y19 x20 y20 x21 y21 x22 y22 x23 y23 x24 y24 x25 y25 x26 y26 x27 y27 x28 y28 x29 y29 x30 y30 x31 y31 data1 x32 y32 x33 y33 x34 y34 x35 y35 x36 y36 x37 y37 x38 y38 x39 y39 x40 y40 x41 y41 x42 y42 x43 y43 x44 y44 x45 y45 x46 y46 x47 y47 x48 y48 x49 y49 x50 y50 x51 y51 x52 y52 x53 y53 x54 y54 x55 y55 x56 y56 x57 y57 x58 y58 x59 y59 x60 y60 x61 y61 x62 y62 x63 y63
                //0b temp0 x0 y0 x1 y1 x2 y2 x3 y3 x4 y4 x5 y5 x6 y6 x7 y7 x16 y16 x17 y17 x18 y18 x19 y19 x20 y20 x21 y21 x22 y22 x23 y23 x32 y32 x33 y33 x34 y34 x35 y35 x36 y36 x37 y37 x38 y38 x39 y39 x48 y48 x49 y49 x50 y50 x51 y51 x52 y52 x53 y53 x54 y54 x55 y55 temp1 x8 y8 x9 y9 x10 y10 x11 y11 x12 y12 x13 y13 x14 y14 x15 y15 x24 y24 x25 y25 x26 y26 x27 y27 x28 y28 x29 y29 x30 y30 x31 y31 x40 y40 x41 y41 x42 y42 x43 y43 x44 y44 x45 y45 x46 y46 x47 y47 x56 y56 x57 y57 x58 y58 x59 y59 x60 y60 x61 y61 x62 y62 x63 y63
                temp0 = YGroup2Unzip_Int128(data0, data1, out temp1);
                // 1 a_0 x0 x8 y0 y8 x1 x9 y1 y9 x2 x10 y2 y10 x3 x11 y3 y11 x16 x24 y16 y24 x17 x25 y17 y25 x18 x26 y18 y26 x19 x27 y19 y27 x32 x40 y32 y40 x33 x41 y33 y41 x34 x42 y34 y42 x35 x43 y35 y43 x48 x56 y48 y56 x49 x57 y49 y57 x50 x58 y50 y58 x51 x59 y51 y59 a_1 x4 x12 y4 y12 x5 x13 y5 y13 x6 x14 y6 y14 x7 x15 y7 y15 x20 x28 y20 y28 x21 x29 y21 y29 x22 x30 y22 y30 x23 x31 y23 y31 x36 x44 y36 y44 x37 x45 y37 y45 x38 x46 y38 y46 x39 x47 y39 y47 x52 x60 y52 y60 x53 x61 y53 y61 x54 x62 y54 y62 x55 x63 y55 y63
                a_0 = Avx512BW.UnpackLow(temp0, temp1);
                a_1 = Avx512BW.UnpackHigh(temp0, temp1);
                // 2 b_0 x0 x4 x8 x12 y0 y4 y8 y12 x1 x5 x9 x13 y1 y5 y9 y13 x16 x20 x24 x28 y16 y20 y24 y28 x17 x21 x25 x29 y17 y21 y25 y29 x32 x36 x40 x44 y32 y36 y40 y44 x33 x37 x41 x45 y33 y37 y41 y45 x48 x52 x56 x60 y48 y52 y56 y60 x49 x53 x57 x61 y49 y53 y57 y61 b_1 x2 x6 x10 x14 y2 y6 y10 y14 x3 x7 x11 x15 y3 y7 y11 y15 x18 x22 x26 x30 y18 y22 y26 y30 x19 x23 x27 x31 y19 y23 y27 y31 x34 x38 x42 x46 y34 y38 y42 y46 x35 x39 x43 x47 y35 y39 y43 y47 x50 x54 x58 x62 y50 y54 y58 y62 x51 x55 x59 x63 y51 y55 y59 y63
                b_0 = Avx512BW.UnpackLow(a_0, a_1);
                b_1 = Avx512BW.UnpackHigh(a_0, a_1);
                // 3 a_0 x0 x2 x4 x6 x8 x10 x12 x14 y0 y2 y4 y6 y8 y10 y12 y14 x16 x18 x20 x22 x24 x26 x28 x30 y16 y18 y20 y22 y24 y26 y28 y30 x32 x34 x36 x38 x40 x42 x44 x46 y32 y34 y36 y38 y40 y42 y44 y46 x48 x50 x52 x54 x56 x58 x60 x62 y48 y50 y52 y54 y56 y58 y60 y62 a_1 x1 x3 x5 x7 x9 x11 x13 x15 y1 y3 y5 y7 y9 y11 y13 y15 x17 x19 x21 x23 x25 x27 x29 x31 y17 y19 y21 y23 y25 y27 y29 y31 x33 x35 x37 x39 x41 x43 x45 x47 y33 y35 y37 y39 y41 y43 y45 y47 x49 x51 x53 x55 x57 x59 x61 x63 y49 y51 y53 y55 y57 y59 y61 y63
                a_0 = Avx512BW.UnpackLow(b_0, b_1);
                a_1 = Avx512BW.UnpackHigh(b_0, b_1);
                // 4 b_0 x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 x16 x17 x18 x19 x20 x21 x22 x23 x24 x25 x26 x27 x28 x29 x30 x31 x32 x33 x34 x35 x36 x37 x38 x39 x40 x41 x42 x43 x44 x45 x46 x47 x48 x49 x50 x51 x52 x53 x54 x55 x56 x57 x58 x59 x60 x61 x62 x63 b_1 y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 y16 y17 y18 y19 y20 y21 y22 y23 y24 y25 y26 y27 y28 y29 y30 y31 y32 y33 y34 y35 y36 y37 y38 y39 y40 y41 y42 y43 y44 y45 y46 y47 y48 y49 y50 y51 y52 y53 y54 y55 y56 y57 y58 y59 y60 y61 y62 y63
                b_1 = Avx512BW.UnpackHigh(a_0, a_1);
                return b_1;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup2UnzipOdd_Unpack(Vector512<short> data0, Vector512<short> data1) {
                return YGroup2UnzipOdd_Unpack(data0.AsUInt16(), data1.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup2UnzipOdd_Unpack(Vector512<ushort> data0, Vector512<ushort> data1) {
                Vector512<ushort> temp0, temp1;
                Vector512<ushort> a_0, a_1, b_0, b_1;
                // Zip layer by 128-bits unpack.
                // 0 data0 x0 y0 x1 y1 x2 y2 x3 y3 x4 y4 x5 y5 x6 y6 x7 y7 x8 y8 x9 y9 x10 y10 x11 y11 x12 y12 x13 y13 x14 y14 x15 y15 data1 x16 y16 x17 y17 x18 y18 x19 y19 x20 y20 x21 y21 x22 y22 x23 y23 x24 y24 x25 y25 x26 y26 x27 y27 x28 y28 x29 y29 x30 y30 x31 y31
                //0b temp0 x0 y0 x1 y1 x2 y2 x3 y3 x8 y8 x9 y9 x10 y10 x11 y11 x16 y16 x17 y17 x18 y18 x19 y19 x24 y24 x25 y25 x26 y26 x27 y27 temp1 x4 y4 x5 y5 x6 y6 x7 y7 x12 y12 x13 y13 x14 y14 x15 y15 x20 y20 x21 y21 x22 y22 x23 y23 x28 y28 x29 y29 x30 y30 x31 y31
                temp0 = YGroup2Unzip_Int128(data0, data1, out temp1);
                // 1 a_0 x0 x4 y0 y4 x1 x5 y1 y5 x8 x12 y8 y12 x9 x13 y9 y13 x16 x20 y16 y20 x17 x21 y17 y21 x24 x28 y24 y28 x25 x29 y25 y29 a_1 x2 x6 y2 y6 x3 x7 y3 y7 x10 x14 y10 y14 x11 x15 y11 y15 x18 x22 y18 y22 x19 x23 y19 y23 x26 x30 y26 y30 x27 x31 y27 y31
                a_0 = Avx512BW.UnpackLow(temp0, temp1);
                a_1 = Avx512BW.UnpackHigh(temp0, temp1);
                // 2 b_0 x0 x2 x4 x6 y0 y2 y4 y6 x8 x10 x12 x14 y8 y10 y12 y14 x16 x18 x20 x22 y16 y18 y20 y22 x24 x26 x28 x30 y24 y26 y28 y30 b_1 x1 x3 x5 x7 y1 y3 y5 y7 x9 x11 x13 x15 y9 y11 y13 y15 x17 x19 x21 x23 y17 y19 y21 y23 x25 x27 x29 x31 y25 y27 y29 y31
                b_0 = Avx512BW.UnpackLow(a_0, a_1);
                b_1 = Avx512BW.UnpackHigh(a_0, a_1);
                // 3 a_0 x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 x16 x17 x18 x19 x20 x21 x22 x23 x24 x25 x26 x27 x28 x29 x30 x31 a_1 y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 y16 y17 y18 y19 y20 y21 y22 y23 y24 y25 y26 y27 y28 y29 y30 y31
                a_1 = Avx512BW.UnpackHigh(b_0, b_1);
                return a_1;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup2UnzipOdd_Unpack(Vector512<int> data0, Vector512<int> data1) {
                return YGroup2UnzipOdd_Unpack(data0.AsUInt32(), data1.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup2UnzipOdd_Unpack(Vector512<uint> data0, Vector512<uint> data1) {
                Vector512<uint> temp0, temp1;
                Vector512<uint> a_0, a_1, b_1;
                // Zip layer by 128-bits unpack.
                // 0 data0 x0 y0 x1 y1 x2 y2 x3 y3 x4 y4 x5 y5 x6 y6 x7 y7 data1 x8 y8 x9 y9 x10 y10 x11 y11 x12 y12 x13 y13 x14 y14 x15 y15
                //0b temp0 x0 y0 x1 y1 x4 y4 x5 y5 x8 y8 x9 y9 x12 y12 x13 y13 temp1 x2 y2 x3 y3 x6 y6 x7 y7 x10 y10 x11 y11 x14 y14 x15 y15
                temp0 = YGroup2Unzip_Int128(data0, data1, out temp1);
                // 1 a_0 x0 x2 y0 y2 x4 x6 y4 y6 x8 x10 y8 y10 x12 x14 y12 y14 a_1 x1 x3 y1 y3 x5 x7 y5 y7 x9 x11 y9 y11 x13 x15 y13 y15
                a_0 = Avx512F.UnpackLow(temp0, temp1);
                a_1 = Avx512F.UnpackHigh(temp0, temp1);
                // 2 b_0 x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 b_1 y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15
                b_1 = Avx512F.UnpackHigh(a_0, a_1);
                return b_1;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup2UnzipOdd_Unpack(Vector512<long> data0, Vector512<long> data1) {
                return YGroup2UnzipOdd_Unpack(data0.AsUInt64(), data1.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2UnzipOdd(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup2UnzipOdd_Unpack(Vector512<ulong> data0, Vector512<ulong> data1) {
                Vector512<ulong> temp0, temp1;
                Vector512<ulong> a_1;
                // Zip layer by 128-bits unpack.
                // 0 data0 x0 y0 x1 y1 x2 y2 x3 y3 data1 x4 y4 x5 y5 x6 y6 x7 y7
                //0b temp0 x0 y0 x2 y2 x4 y4 x6 y6 temp1 x1 y1 x3 y3 x5 y5 x7 y7
                temp0 = YGroup2Unzip_Int128(data0, data1, out temp1);
                // 1 a_0 x0 x1 x2 x3 x4 x5 x6 x7 a_1 y0 y1 y2 y3 y4 y5 y6 y7
                a_1 = Avx512F.UnpackHigh(temp0, temp1);
                return a_1;
            }


            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2Zip_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes | TypeCodeFlags.Int128 | TypeCodeFlags.UInt128;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{float}, Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup2Zip(Vector512<float> x, Vector512<float> y, out Vector512<float> data1) {
                return YGroup2Zip_Permute(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{double}, Vector512{double}, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup2Zip(Vector512<double> x, Vector512<double> y, out Vector512<double> data1) {
                return YGroup2Zip_Permute(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup2Zip(Vector512<sbyte> x, Vector512<sbyte> y, out Vector512<sbyte> data1) {
                return YGroup2Zip_Permute(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{byte}, Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup2Zip(Vector512<byte> x, Vector512<byte> y, out Vector512<byte> data1) {
                return YGroup2Zip_Permute(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{short}, Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup2Zip(Vector512<short> x, Vector512<short> y, out Vector512<short> data1) {
                return YGroup2Zip_Permute(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{ushort}, Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup2Zip(Vector512<ushort> x, Vector512<ushort> y, out Vector512<ushort> data1) {
                return YGroup2Zip_Permute(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{int}, Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup2Zip(Vector512<int> x, Vector512<int> y, out Vector512<int> data1) {
                return YGroup2Zip_Permute(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{uint}, Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup2Zip(Vector512<uint> x, Vector512<uint> y, out Vector512<uint> data1) {
                return YGroup2Zip_Permute(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{long}, Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup2Zip(Vector512<long> x, Vector512<long> y, out Vector512<long> data1) {
                return YGroup2Zip_Permute(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{ulong}, Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup2Zip(Vector512<ulong> x, Vector512<ulong> y, out Vector512<ulong> data1) {
                return YGroup2Zip_Permute(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{ExInt128}, Vector512{ExInt128}, out Vector512{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExInt128> YGroup2Zip(Vector512<ExInt128> x, Vector512<ExInt128> y, out Vector512<ExInt128> data1) {
#if EX_APPLY_GENERIC
                return YGroup2Zip_Int128(x, y, out data1);
#else
                var d0 = YGroup2Zip_Int128(x.ExAsUInt64(), y.ExAsUInt64(), out var d1);
                data1 = d1.ExAsExInt128();
                return d0.ExAsExInt128();
#endif // EX_APPLY_GENERIC
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{ExUInt128}, Vector512{ExUInt128}, out Vector512{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExUInt128> YGroup2Zip(Vector512<ExUInt128> x, Vector512<ExUInt128> y, out Vector512<ExUInt128> data1) {
#if EX_APPLY_GENERIC
                return YGroup2Zip_Int128(x, y, out data1);
#else
                var d0 = YGroup2Zip_Int128(x.ExAsUInt64(), y.ExAsUInt64(), out var d1);
                data1 = d1.ExAsExUInt128();
                return d0.ExAsExUInt128();
#endif // EX_APPLY_GENERIC
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip_Int128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<T> YGroup2Zip_Int128<T>(Vector512<T> x, Vector512<T> y, out Vector512<T> data1) where T : struct {
#if EX_APPLY_GENERIC
                var d0 = Avx512F.PermuteVar8x64x2(x.ExAsUInt64(), Vector512Constants.YGroup2Zip_ShuffleX2_UInt128_On64_Data0, y.ExAsUInt64());
                var d1 = Avx512F.PermuteVar8x64x2(x.ExAsUInt64(), Vector512Constants.YGroup2Zip_ShuffleX2_UInt128_On64_Data1, y.ExAsUInt64());
                data1 = d1.ExAs<ulong, T>();
                return d0.ExAs<ulong, T>();
#else
                var d0 = Avx512F.PermuteVar8x64x2(x.AsUInt64(), Vector512Constants.YGroup2Zip_ShuffleX2_UInt128_On64_Data0, y.AsUInt64());
                var d1 = Avx512F.PermuteVar8x64x2(x.AsUInt64(), Vector512Constants.YGroup2Zip_ShuffleX2_UInt128_On64_Data1, y.AsUInt64());
                data1 = d1.As<ulong, T>();
                return d0.As<ulong, T>();
#endif // EX_APPLY_GENERIC
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip_Int128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<T> YGroup2Zip_Int128_Imm<T>(Vector512<T> x, Vector512<T> y, out Vector512<T> data1) where T : struct {
#if EX_APPLY_GENERIC
                var b0 = Avx512F.Shuffle4x128(x.ExAsUInt64(), y.ExAsUInt64(), (byte)ShuffleControlG4.XYXY); // x0 x1 y0 y1
                var b1 = Avx512F.Shuffle4x128(x.ExAsUInt64(), y.ExAsUInt64(), (byte)ShuffleControlG4.ZWZW); // x2 x3 y2 y3
                var d0 = Avx512F.Shuffle4x128(b0, b0, (byte)ShuffleControlG4.XZYW); // x0 y0 x1 y1
                var d1 = Avx512F.Shuffle4x128(b1, b1, (byte)ShuffleControlG4.XZYW); // x2 y2 x3 y3
                data1 = d1.ExAs<ulong, T>();
                return d0.ExAs<ulong, T>();
#else
                var b0 = Avx512F.Shuffle4x128(x.AsUInt64(), y.AsUInt64(), (byte)ShuffleControlG4.XYXY); // x0 x1 y0 y1
                var b1 = Avx512F.Shuffle4x128(x.AsUInt64(), y.AsUInt64(), (byte)ShuffleControlG4.ZWZW); // x2 x3 y2 y3
                var d0 = Avx512F.Shuffle4x128(b0, b0, (byte)ShuffleControlG4.XZYW); // x0 y0 x1 y1
                var d1 = Avx512F.Shuffle4x128(b1, b1, (byte)ShuffleControlG4.XZYW); // x2 y2 x3 y3
                data1 = d1.As<ulong, T>();
                return d0.As<ulong, T>();
#endif // EX_APPLY_GENERIC
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{float}, Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup2Zip_Permute(Vector512<float> x, Vector512<float> y, out Vector512<float> data1) {
                var data0 = Avx512F.PermuteVar16x32x2(x, Vector512Constants.YGroup2Zip_ShuffleX2_UInt32_Data0.AsInt32(), y);
                data1 = Avx512F.PermuteVar16x32x2(x, Vector512Constants.YGroup2Zip_ShuffleX2_UInt32_Data1.AsInt32(), y);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{double}, Vector512{double}, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup2Zip_Permute(Vector512<double> x, Vector512<double> y, out Vector512<double> data1) {
                var data0 = Avx512F.PermuteVar8x64x2(x, Vector512Constants.YGroup2Zip_ShuffleX2_UInt64_Data0.AsInt64(), y);
                data1 = Avx512F.PermuteVar8x64x2(x, Vector512Constants.YGroup2Zip_ShuffleX2_UInt64_Data1.AsInt64(), y);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup2Zip_Permute(Vector512<sbyte> x, Vector512<sbyte> y, out Vector512<sbyte> data1) {
                var d0 = YGroup2Zip_Permute(x.AsByte(), y.AsByte(), out var d1);
                data1 = d1.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{byte}, Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup2Zip_Permute(Vector512<byte> x, Vector512<byte> y, out Vector512<byte> data1) {
                var data0 = Avx512Vbmi.PermuteVar64x8x2(x, Vector512Constants.YGroup2Zip_ShuffleX2_Byte_Data0, y);
                data1 = Avx512Vbmi.PermuteVar64x8x2(x, Vector512Constants.YGroup2Zip_ShuffleX2_Byte_Data1, y);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{short}, Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup2Zip_Permute(Vector512<short> x, Vector512<short> y, out Vector512<short> data1) {
                var d0 = YGroup2Zip_Permute(x.AsUInt16(), y.AsUInt16(), out var d1);
                data1 = d1.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{ushort}, Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup2Zip_Permute(Vector512<ushort> x, Vector512<ushort> y, out Vector512<ushort> data1) {
                var data0 = Avx512BW.PermuteVar32x16x2(x, Vector512Constants.YGroup2Zip_ShuffleX2_UInt16_Data0, y);
                data1 = Avx512BW.PermuteVar32x16x2(x, Vector512Constants.YGroup2Zip_ShuffleX2_UInt16_Data1, y);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{int}, Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup2Zip_Permute(Vector512<int> x, Vector512<int> y, out Vector512<int> data1) {
                var d0 = YGroup2Zip_Permute(x.AsUInt32(), y.AsUInt32(), out var d1);
                data1 = d1.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{uint}, Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup2Zip_Permute(Vector512<uint> x, Vector512<uint> y, out Vector512<uint> data1) {
                var data0 = Avx512F.PermuteVar16x32x2(x, Vector512Constants.YGroup2Zip_ShuffleX2_UInt32_Data0, y);
                data1 = Avx512F.PermuteVar16x32x2(x, Vector512Constants.YGroup2Zip_ShuffleX2_UInt32_Data1, y);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{long}, Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup2Zip_Permute(Vector512<long> x, Vector512<long> y, out Vector512<long> data1) {
                var d0 = YGroup2Zip_Permute(x.AsUInt64(), y.AsUInt64(), out var d1);
                data1 = d1.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{ulong}, Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup2Zip_Permute(Vector512<ulong> x, Vector512<ulong> y, out Vector512<ulong> data1) {
                var data0 = Avx512F.PermuteVar8x64x2(x, Vector512Constants.YGroup2Zip_ShuffleX2_UInt64_Data0, y);
                data1 = Avx512F.PermuteVar8x64x2(x, Vector512Constants.YGroup2Zip_ShuffleX2_UInt64_Data1, y);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{float}, Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup2Zip_Unpack(Vector512<float> x, Vector512<float> y, out Vector512<float> data1) {
                Vector512<float> a_0, a_1, b_0, b_1;
                // Zip layer by 128-bits unpack.
                // 0 _x_ x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 _y_ y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15
                // 1 a_0 x0 y0 x1 y1 x4 y4 x5 y5 x8 y8 x9 y9 x12 y12 x13 y13 a_1 x2 y2 x3 y3 x6 y6 x7 y7 x10 y10 x11 y11 x14 y14 x15 y15
                a_0 = Avx512F.UnpackLow(x, y);
                a_1 = Avx512F.UnpackHigh(x, y);
                // Rearrange.
                b_0 = YGroup2Zip_Int128(a_0, a_1, out b_1);
                data1 = b_1;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{double}, Vector512{double}, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup2Zip_Unpack(Vector512<double> x, Vector512<double> y, out Vector512<double> data1) {
                Vector512<double> a_0, a_1, b_0, b_1;
                // Zip layer by 128-bits unpack.
                // 0 _x_ x0 x1 x2 x3 x4 x5 x6 x7 a_1 y0 y1 y2 y3 y4 y5 y6 y7
                // 1 b_0 x0 y0 x2 y2 x4 y4 x6 y6 b_1 x1 y1 x3 y3 x5 y5 x7 y7
                a_0 = Avx512F.UnpackLow(x, y);
                a_1 = Avx512F.UnpackHigh(x, y);
                // Rearrange.
                b_0 = YGroup2Zip_Int128(a_0, a_1, out b_1);
                data1 = b_1;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup2Zip_Unpack(Vector512<sbyte> x, Vector512<sbyte> y, out Vector512<sbyte> data1) {
                var d0 = YGroup2Zip_Unpack(x.AsByte(), y.AsByte(), out var d1);
                data1 = d1.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{byte}, Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup2Zip_Unpack(Vector512<byte> x, Vector512<byte> y, out Vector512<byte> data1) {
                Vector512<byte> a_0, a_1, b_0, b_1;
                // Zip layer by 128-bits unpack.
                // 0 _x_ x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 x16 x17 x18 x19 x20 x21 x22 x23 x24 x25 x26 x27 x28 x29 x30 x31 x32 x33 x34 x35 x36 x37 x38 x39 x40 x41 x42 x43 x44 x45 x46 x47 x48 x49 x50 x51 x52 x53 x54 x55 x56 x57 x58 x59 x60 x61 x62 x63 _y_ y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 y16 y17 y18 y19 y20 y21 y22 y23 y24 y25 y26 y27 y28 y29 y30 y31 y32 y33 y34 y35 y36 y37 y38 y39 y40 y41 y42 y43 y44 y45 y46 y47 y48 y49 y50 y51 y52 y53 y54 y55 y56 y57 y58 y59 y60 y61 y62 y63
                // 1 a_0 x0 y0 x1 y1 x2 y2 x3 y3 x4 y4 x5 y5 x6 y6 x7 y7 x16 y16 x17 y17 x18 y18 x19 y19 x20 y20 x21 y21 x22 y22 x23 y23 x32 y32 x33 y33 x34 y34 x35 y35 x36 y36 x37 y37 x38 y38 x39 y39 x48 y48 x49 y49 x50 y50 x51 y51 x52 y52 x53 y53 x54 y54 x55 y55 a_1 x8 y8 x9 y9 x10 y10 x11 y11 x12 y12 x13 y13 x14 y14 x15 y15 x24 y24 x25 y25 x26 y26 x27 y27 x28 y28 x29 y29 x30 y30 x31 y31 x40 y40 x41 y41 x42 y42 x43 y43 x44 y44 x45 y45 x46 y46 x47 y47 x56 y56 x57 y57 x58 y58 x59 y59 x60 y60 x61 y61 x62 y62 x63 y63
                a_0 = Avx512BW.UnpackLow(x, y);
                a_1 = Avx512BW.UnpackHigh(x, y);
                // Rearrange.
                b_0 = YGroup2Zip_Int128(a_0, a_1, out b_1);
                data1 = b_1;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{short}, Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup2Zip_Unpack(Vector512<short> x, Vector512<short> y, out Vector512<short> data1) {
                var d0 = YGroup2Zip_Unpack(x.AsUInt16(), y.AsUInt16(), out var d1);
                data1 = d1.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{ushort}, Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup2Zip_Unpack(Vector512<ushort> x, Vector512<ushort> y, out Vector512<ushort> data1) {
                Vector512<ushort> a_0, a_1, b_0, b_1;
                // Zip layer by 128-bits unpack.
                // 0 _x_ x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 x16 x17 x18 x19 x20 x21 x22 x23 x24 x25 x26 x27 x28 x29 x30 x31 _y_ y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 y16 y17 y18 y19 y20 y21 y22 y23 y24 y25 y26 y27 y28 y29 y30 y31
                // 1 b_0 x0 y0 x1 y1 x2 y2 x3 y3 x8 y8 x9 y9 x10 y10 x11 y11 x16 y16 x17 y17 x18 y18 x19 y19 x24 y24 x25 y25 x26 y26 x27 y27 b_1 x4 y4 x5 y5 x6 y6 x7 y7 x12 y12 x13 y13 x14 y14 x15 y15 x20 y20 x21 y21 x22 y22 x23 y23 x28 y28 x29 y29 x30 y30 x31 y31
                a_0 = Avx512BW.UnpackLow(x, y);
                a_1 = Avx512BW.UnpackHigh(x, y);
                // Rearrange.
                b_0 = YGroup2Zip_Int128(a_0, a_1, out b_1);
                data1 = b_1;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{int}, Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup2Zip_Unpack(Vector512<int> x, Vector512<int> y, out Vector512<int> data1) {
                var d0 = YGroup2Zip_Unpack(x.AsUInt32(), y.AsUInt32(), out var d1);
                data1 = d1.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{uint}, Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup2Zip_Unpack(Vector512<uint> x, Vector512<uint> y, out Vector512<uint> data1) {
                Vector512<uint> a_0, a_1, b_0, b_1;
                // Zip layer by 128-bits unpack.
                // 0 _x_ x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 _y_ y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15
                // 1 a_0 x0 y0 x1 y1 x4 y4 x5 y5 x8 y8 x9 y9 x12 y12 x13 y13 a_1 x2 y2 x3 y3 x6 y6 x7 y7 x10 y10 x11 y11 x14 y14 x15 y15
                a_0 = Avx512F.UnpackLow(x, y);
                a_1 = Avx512F.UnpackHigh(x, y);
                // Rearrange.
                b_0 = YGroup2Zip_Int128(a_0, a_1, out b_1);
                data1 = b_1;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{long}, Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup2Zip_Unpack(Vector512<long> x, Vector512<long> y, out Vector512<long> data1) {
                var d0 = YGroup2Zip_Unpack(x.AsUInt64(), y.AsUInt64(), out var d1);
                data1 = d1.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2Zip(Vector512{ulong}, Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup2Zip_Unpack(Vector512<ulong> x, Vector512<ulong> y, out Vector512<ulong> data1) {
                Vector512<ulong> a_0, a_1, b_0, b_1;
                // Zip layer by 128-bits unpack.
                // 0 _x_ x0 x1 x2 x3 x4 x5 x6 x7 a_1 y0 y1 y2 y3 y4 y5 y6 y7
                // 1 b_0 x0 y0 x2 y2 x4 y4 x6 y6 b_1 x1 y1 x3 y3 x5 y5 x7 y7
                a_0 = Avx512F.UnpackLow(x, y);
                a_1 = Avx512F.UnpackHigh(x, y);
                // Rearrange.
                b_0 = YGroup2Zip_Int128(a_0, a_1, out b_1);
                data1 = b_1;
                return b_0;
            }

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
                Widen(y, out b0, out b1);
                Widen(x, out a0, out a1);
                b0 = Avx512BW.ShiftLeftLogical(b0, L);
                b1 = Avx512BW.ShiftLeftLogical(b1, L);
                a0 = Avx512F.Or(a0, b0);
                a1 = Avx512F.Or(a1, b1);
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
                Widen(y, out b0, out b1);
                Widen(x, out a0, out a1);
                b0 = Avx512F.ShiftLeftLogical(b0, L);
                b1 = Avx512F.ShiftLeftLogical(b1, L);
                a0 = Avx512F.Or(a0, b0);
                a1 = Avx512F.Or(a1, b1);
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
                Widen(y, out b0, out b1);
                Widen(x, out a0, out a1);
                b0 = Avx512F.ShiftLeftLogical(b0, L);
                b1 = Avx512F.ShiftLeftLogical(b1, L);
                a0 = Avx512F.Or(a0, b0);
                a1 = Avx512F.Or(a1, b1);
                data1 = a1.AsUInt32();
                return a0.AsUInt32();
            }


            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2ZipHigh_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes | TypeCodeFlags.Int128 | TypeCodeFlags.UInt128;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup2ZipHigh(Vector512<float> x, Vector512<float> y) {
                return YGroup2ZipHigh_Permute(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup2ZipHigh(Vector512<double> x, Vector512<double> y) {
                return YGroup2ZipHigh_Permute(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup2ZipHigh(Vector512<sbyte> x, Vector512<sbyte> y) {
                return YGroup2ZipHigh_Permute(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup2ZipHigh(Vector512<byte> x, Vector512<byte> y) {
                return YGroup2ZipHigh_Permute(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup2ZipHigh(Vector512<short> x, Vector512<short> y) {
                return YGroup2ZipHigh_Permute(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup2ZipHigh(Vector512<ushort> x, Vector512<ushort> y) {
                return YGroup2ZipHigh_Permute(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup2ZipHigh(Vector512<int> x, Vector512<int> y) {
                return YGroup2ZipHigh_Permute(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup2ZipHigh(Vector512<uint> x, Vector512<uint> y) {
                return YGroup2ZipHigh_Permute(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup2ZipHigh(Vector512<long> x, Vector512<long> y) {
                return YGroup2ZipHigh_Permute(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup2ZipHigh(Vector512<ulong> x, Vector512<ulong> y) {
                return YGroup2ZipHigh_Permute(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{ExInt128}, Vector512{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExInt128> YGroup2ZipHigh(Vector512<ExInt128> x, Vector512<ExInt128> y) {
                return Avx512F.PermuteVar8x64x2(x.ExAsUInt64(), Vector512Constants.YGroup2Zip_ShuffleX2_UInt128_On64_Data1, y.ExAsUInt64()).ExAsExInt128();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{ExUInt128}, Vector512{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExUInt128> YGroup2ZipHigh(Vector512<ExUInt128> x, Vector512<ExUInt128> y) {
                return Avx512F.PermuteVar8x64x2(x.ExAsUInt64(), Vector512Constants.YGroup2Zip_ShuffleX2_UInt128_On64_Data1, y.ExAsUInt64()).ExAsExUInt128();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup2ZipHigh_Permute(Vector512<float> x, Vector512<float> y) {
                return Avx512F.PermuteVar16x32x2(x, Vector512Constants.YGroup2Zip_ShuffleX2_UInt32_Data1.AsInt32(), y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup2ZipHigh_Permute(Vector512<double> x, Vector512<double> y) {
                return Avx512F.PermuteVar8x64x2(x, Vector512Constants.YGroup2Zip_ShuffleX2_UInt64_Data1.AsInt64(), y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup2ZipHigh_Permute(Vector512<sbyte> x, Vector512<sbyte> y) {
                return YGroup2ZipHigh_Permute(x.AsByte(), y.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup2ZipHigh_Permute(Vector512<byte> x, Vector512<byte> y) {
                return Avx512Vbmi.PermuteVar64x8x2(x, Vector512Constants.YGroup2Zip_ShuffleX2_Byte_Data1, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup2ZipHigh_Permute(Vector512<short> x, Vector512<short> y) {
                return YGroup2ZipHigh_Permute(x.AsUInt16(), y.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup2ZipHigh_Permute(Vector512<ushort> x, Vector512<ushort> y) {
                return Avx512BW.PermuteVar32x16x2(x, Vector512Constants.YGroup2Zip_ShuffleX2_UInt16_Data1, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup2ZipHigh_Permute(Vector512<int> x, Vector512<int> y) {
                return YGroup2ZipHigh_Permute(x.AsUInt32(), y.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup2ZipHigh_Permute(Vector512<uint> x, Vector512<uint> y) {
                return Avx512F.PermuteVar16x32x2(x, Vector512Constants.YGroup2Zip_ShuffleX2_UInt32_Data1, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup2ZipHigh_Permute(Vector512<long> x, Vector512<long> y) {
                return YGroup2ZipHigh_Permute(x.AsUInt64(), y.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup2ZipHigh_Permute(Vector512<ulong> x, Vector512<ulong> y) {
                return Avx512F.PermuteVar8x64x2(x, Vector512Constants.YGroup2Zip_ShuffleX2_UInt64_Data1, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup2ZipHigh_Unpack(Vector512<float> x, Vector512<float> y) {
                Vector512<float> a_0, a_1, b_1;
                // Zip layer by 128-bits unpack.
                // 0 _x_ x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 _y_ y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15
                // 1 a_0 x0 y0 x1 y1 x4 y4 x5 y5 x8 y8 x9 y9 x12 y12 x13 y13 a_1 x2 y2 x3 y3 x6 y6 x7 y7 x10 y10 x11 y11 x14 y14 x15 y15
                a_0 = Avx512F.UnpackLow(x, y);
                a_1 = Avx512F.UnpackHigh(x, y);
                // Rearrange.
                _ = YGroup2Zip_Int128(a_0, a_1, out b_1);
                return b_1;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup2ZipHigh_Unpack(Vector512<double> x, Vector512<double> y) {
                Vector512<double> a_0, a_1, b_1;
                // Zip layer by 128-bits unpack.
                // 0 _x_ x0 x1 x2 x3 x4 x5 x6 x7 a_1 y0 y1 y2 y3 y4 y5 y6 y7
                // 1 b_0 x0 y0 x2 y2 x4 y4 x6 y6 b_1 x1 y1 x3 y3 x5 y5 x7 y7
                a_0 = Avx512F.UnpackLow(x, y);
                a_1 = Avx512F.UnpackHigh(x, y);
                // Rearrange.
                _ = YGroup2Zip_Int128(a_0, a_1, out b_1);
                return b_1;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup2ZipHigh_Unpack(Vector512<sbyte> x, Vector512<sbyte> y) {
                return YGroup2ZipHigh_Unpack(x.AsByte(), y.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup2ZipHigh_Unpack(Vector512<byte> x, Vector512<byte> y) {
                Vector512<byte> a_0, a_1, b_1;
                // Zip layer by 128-bits unpack.
                // 0 _x_ x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 x16 x17 x18 x19 x20 x21 x22 x23 x24 x25 x26 x27 x28 x29 x30 x31 x32 x33 x34 x35 x36 x37 x38 x39 x40 x41 x42 x43 x44 x45 x46 x47 x48 x49 x50 x51 x52 x53 x54 x55 x56 x57 x58 x59 x60 x61 x62 x63 _y_ y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 y16 y17 y18 y19 y20 y21 y22 y23 y24 y25 y26 y27 y28 y29 y30 y31 y32 y33 y34 y35 y36 y37 y38 y39 y40 y41 y42 y43 y44 y45 y46 y47 y48 y49 y50 y51 y52 y53 y54 y55 y56 y57 y58 y59 y60 y61 y62 y63
                // 1 a_0 x0 y0 x1 y1 x2 y2 x3 y3 x4 y4 x5 y5 x6 y6 x7 y7 x16 y16 x17 y17 x18 y18 x19 y19 x20 y20 x21 y21 x22 y22 x23 y23 x32 y32 x33 y33 x34 y34 x35 y35 x36 y36 x37 y37 x38 y38 x39 y39 x48 y48 x49 y49 x50 y50 x51 y51 x52 y52 x53 y53 x54 y54 x55 y55 a_1 x8 y8 x9 y9 x10 y10 x11 y11 x12 y12 x13 y13 x14 y14 x15 y15 x24 y24 x25 y25 x26 y26 x27 y27 x28 y28 x29 y29 x30 y30 x31 y31 x40 y40 x41 y41 x42 y42 x43 y43 x44 y44 x45 y45 x46 y46 x47 y47 x56 y56 x57 y57 x58 y58 x59 y59 x60 y60 x61 y61 x62 y62 x63 y63
                a_0 = Avx512BW.UnpackLow(x, y);
                a_1 = Avx512BW.UnpackHigh(x, y);
                // Rearrange.
                _ = YGroup2Zip_Int128(a_0, a_1, out b_1);
                return b_1;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup2ZipHigh_Unpack(Vector512<short> x, Vector512<short> y) {
                return YGroup2ZipHigh_Unpack(x.AsUInt16(), y.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup2ZipHigh_Unpack(Vector512<ushort> x, Vector512<ushort> y) {
                Vector512<ushort> a_0, a_1, b_1;
                // Zip layer by 128-bits unpack.
                // 0 _x_ x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 x16 x17 x18 x19 x20 x21 x22 x23 x24 x25 x26 x27 x28 x29 x30 x31 _y_ y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 y16 y17 y18 y19 y20 y21 y22 y23 y24 y25 y26 y27 y28 y29 y30 y31
                // 1 b_0 x0 y0 x1 y1 x2 y2 x3 y3 x8 y8 x9 y9 x10 y10 x11 y11 x16 y16 x17 y17 x18 y18 x19 y19 x24 y24 x25 y25 x26 y26 x27 y27 b_1 x4 y4 x5 y5 x6 y6 x7 y7 x12 y12 x13 y13 x14 y14 x15 y15 x20 y20 x21 y21 x22 y22 x23 y23 x28 y28 x29 y29 x30 y30 x31 y31
                a_0 = Avx512BW.UnpackLow(x, y);
                a_1 = Avx512BW.UnpackHigh(x, y);
                // Rearrange.
                _ = YGroup2Zip_Int128(a_0, a_1, out b_1);
                return b_1;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup2ZipHigh_Unpack(Vector512<int> x, Vector512<int> y) {
                return YGroup2ZipHigh_Unpack(x.AsUInt32(), y.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup2ZipHigh_Unpack(Vector512<uint> x, Vector512<uint> y) {
                Vector512<uint> a_0, a_1, b_1;
                // Zip layer by 128-bits unpack.
                // 0 _x_ x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 _y_ y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15
                // 1 a_0 x0 y0 x1 y1 x4 y4 x5 y5 x8 y8 x9 y9 x12 y12 x13 y13 a_1 x2 y2 x3 y3 x6 y6 x7 y7 x10 y10 x11 y11 x14 y14 x15 y15
                a_0 = Avx512F.UnpackLow(x, y);
                a_1 = Avx512F.UnpackHigh(x, y);
                // Rearrange.
                _ = YGroup2Zip_Int128(a_0, a_1, out b_1);
                return b_1;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup2ZipHigh_Unpack(Vector512<long> x, Vector512<long> y) {
                return YGroup2ZipHigh_Unpack(x.AsUInt64(), y.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup2ZipHigh_Unpack(Vector512<ulong> x, Vector512<ulong> y) {
                Vector512<ulong> a_0, a_1, b_1;
                // Zip layer by 128-bits unpack.
                // 0 _x_ x0 x1 x2 x3 x4 x5 x6 x7 a_1 y0 y1 y2 y3 y4 y5 y6 y7
                // 1 b_0 x0 y0 x2 y2 x4 y4 x6 y6 b_1 x1 y1 x3 y3 x5 y5 x7 y7
                a_0 = Avx512F.UnpackLow(x, y);
                a_1 = Avx512F.UnpackHigh(x, y);
                // Rearrange.
                _ = YGroup2Zip_Int128(a_0, a_1, out b_1);
                return b_1;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2ZipLow_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes | TypeCodeFlags.Int128 | TypeCodeFlags.UInt128;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup2ZipLow(Vector512<float> x, Vector512<float> y) {
                return YGroup2ZipLow_Permute(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup2ZipLow(Vector512<double> x, Vector512<double> y) {
                return YGroup2ZipLow_Permute(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup2ZipLow(Vector512<sbyte> x, Vector512<sbyte> y) {
                return YGroup2ZipLow_Permute(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup2ZipLow(Vector512<byte> x, Vector512<byte> y) {
                return YGroup2ZipLow_Permute(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup2ZipLow(Vector512<short> x, Vector512<short> y) {
                return YGroup2ZipLow_Permute(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup2ZipLow(Vector512<ushort> x, Vector512<ushort> y) {
                return YGroup2ZipLow_Permute(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup2ZipLow(Vector512<int> x, Vector512<int> y) {
                return YGroup2ZipLow_Permute(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup2ZipLow(Vector512<uint> x, Vector512<uint> y) {
                return YGroup2ZipLow_Permute(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup2ZipLow(Vector512<long> x, Vector512<long> y) {
                return YGroup2ZipLow_Permute(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup2ZipLow(Vector512<ulong> x, Vector512<ulong> y) {
                return YGroup2ZipLow_Permute(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{ExInt128}, Vector512{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExInt128> YGroup2ZipLow(Vector512<ExInt128> x, Vector512<ExInt128> y) {
                return Avx512F.PermuteVar8x64x2(x.ExAsUInt64(), Vector512Constants.YGroup2Zip_ShuffleX2_UInt128_On64_Data0, y.ExAsUInt64()).ExAsExInt128();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{ExUInt128}, Vector512{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExUInt128> YGroup2ZipLow(Vector512<ExUInt128> x, Vector512<ExUInt128> y) {
                return Avx512F.PermuteVar8x64x2(x.ExAsUInt64(), Vector512Constants.YGroup2Zip_ShuffleX2_UInt128_On64_Data0, y.ExAsUInt64()).ExAsExUInt128();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup2ZipLow_Permute(Vector512<float> x, Vector512<float> y) {
                return Avx512F.PermuteVar16x32x2(x, Vector512Constants.YGroup2Zip_ShuffleX2_UInt32_Data0.AsInt32(), y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup2ZipLow_Permute(Vector512<double> x, Vector512<double> y) {
                return Avx512F.PermuteVar8x64x2(x, Vector512Constants.YGroup2Zip_ShuffleX2_UInt64_Data0.AsInt64(), y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup2ZipLow_Permute(Vector512<sbyte> x, Vector512<sbyte> y) {
                return YGroup2ZipLow_Permute(x.AsByte(), y.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup2ZipLow_Permute(Vector512<byte> x, Vector512<byte> y) {
                return Avx512Vbmi.PermuteVar64x8x2(x, Vector512Constants.YGroup2Zip_ShuffleX2_Byte_Data0, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup2ZipLow_Permute(Vector512<short> x, Vector512<short> y) {
                return YGroup2ZipLow_Permute(x.AsUInt16(), y.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup2ZipLow_Permute(Vector512<ushort> x, Vector512<ushort> y) {
                return Avx512BW.PermuteVar32x16x2(x, Vector512Constants.YGroup2Zip_ShuffleX2_UInt16_Data0, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup2ZipLow_Permute(Vector512<int> x, Vector512<int> y) {
                return YGroup2ZipLow_Permute(x.AsUInt32(), y.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup2ZipLow_Permute(Vector512<uint> x, Vector512<uint> y) {
                return Avx512F.PermuteVar16x32x2(x, Vector512Constants.YGroup2Zip_ShuffleX2_UInt32_Data0, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup2ZipLow_Permute(Vector512<long> x, Vector512<long> y) {
                return YGroup2ZipLow_Permute(x.AsUInt64(), y.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup2ZipLow_Permute(Vector512<ulong> x, Vector512<ulong> y) {
                return Avx512F.PermuteVar8x64x2(x, Vector512Constants.YGroup2Zip_ShuffleX2_UInt64_Data0, y);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup2ZipLow_Unpack(Vector512<float> x, Vector512<float> y) {
                Vector512<float> a_0, a_1, b_0;
                // Zip layer by 128-bits unpack.
                // 0 _x_ x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 _y_ y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15
                // 1 a_0 x0 y0 x1 y1 x4 y4 x5 y5 x8 y8 x9 y9 x12 y12 x13 y13 a_1 x2 y2 x3 y3 x6 y6 x7 y7 x10 y10 x11 y11 x14 y14 x15 y15
                a_0 = Avx512F.UnpackLow(x, y);
                a_1 = Avx512F.UnpackHigh(x, y);
                // Rearrange.
                b_0 = YGroup2Zip_Int128(a_0, a_1, out _);
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup2ZipLow_Unpack(Vector512<double> x, Vector512<double> y) {
                Vector512<double> a_0, a_1, b_0;
                // Zip layer by 128-bits unpack.
                // 0 _x_ x0 x1 x2 x3 x4 x5 x6 x7 a_1 y0 y1 y2 y3 y4 y5 y6 y7
                // 1 b_0 x0 y0 x2 y2 x4 y4 x6 y6 b_1 x1 y1 x3 y3 x5 y5 x7 y7
                a_0 = Avx512F.UnpackLow(x, y);
                a_1 = Avx512F.UnpackHigh(x, y);
                // Rearrange.
                b_0 = YGroup2Zip_Int128(a_0, a_1, out _);
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup2ZipLow_Unpack(Vector512<sbyte> x, Vector512<sbyte> y) {
                return YGroup2ZipLow_Unpack(x.AsByte(), y.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup2ZipLow_Unpack(Vector512<byte> x, Vector512<byte> y) {
                Vector512<byte> a_0, a_1, b_0;
                // Zip layer by 128-bits unpack.
                // 0 _x_ x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 x16 x17 x18 x19 x20 x21 x22 x23 x24 x25 x26 x27 x28 x29 x30 x31 x32 x33 x34 x35 x36 x37 x38 x39 x40 x41 x42 x43 x44 x45 x46 x47 x48 x49 x50 x51 x52 x53 x54 x55 x56 x57 x58 x59 x60 x61 x62 x63 _y_ y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 y16 y17 y18 y19 y20 y21 y22 y23 y24 y25 y26 y27 y28 y29 y30 y31 y32 y33 y34 y35 y36 y37 y38 y39 y40 y41 y42 y43 y44 y45 y46 y47 y48 y49 y50 y51 y52 y53 y54 y55 y56 y57 y58 y59 y60 y61 y62 y63
                // 1 a_0 x0 y0 x1 y1 x2 y2 x3 y3 x4 y4 x5 y5 x6 y6 x7 y7 x16 y16 x17 y17 x18 y18 x19 y19 x20 y20 x21 y21 x22 y22 x23 y23 x32 y32 x33 y33 x34 y34 x35 y35 x36 y36 x37 y37 x38 y38 x39 y39 x48 y48 x49 y49 x50 y50 x51 y51 x52 y52 x53 y53 x54 y54 x55 y55 a_1 x8 y8 x9 y9 x10 y10 x11 y11 x12 y12 x13 y13 x14 y14 x15 y15 x24 y24 x25 y25 x26 y26 x27 y27 x28 y28 x29 y29 x30 y30 x31 y31 x40 y40 x41 y41 x42 y42 x43 y43 x44 y44 x45 y45 x46 y46 x47 y47 x56 y56 x57 y57 x58 y58 x59 y59 x60 y60 x61 y61 x62 y62 x63 y63
                a_0 = Avx512BW.UnpackLow(x, y);
                a_1 = Avx512BW.UnpackHigh(x, y);
                // Rearrange.
                b_0 = YGroup2Zip_Int128(a_0, a_1, out _);
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup2ZipLow_Unpack(Vector512<short> x, Vector512<short> y) {
                return YGroup2ZipLow_Unpack(x.AsUInt16(), y.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup2ZipLow_Unpack(Vector512<ushort> x, Vector512<ushort> y) {
                Vector512<ushort> a_0, a_1, b_0;
                // Zip layer by 128-bits unpack.
                // 0 _x_ x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 x16 x17 x18 x19 x20 x21 x22 x23 x24 x25 x26 x27 x28 x29 x30 x31 _y_ y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 y16 y17 y18 y19 y20 y21 y22 y23 y24 y25 y26 y27 y28 y29 y30 y31
                // 1 b_0 x0 y0 x1 y1 x2 y2 x3 y3 x8 y8 x9 y9 x10 y10 x11 y11 x16 y16 x17 y17 x18 y18 x19 y19 x24 y24 x25 y25 x26 y26 x27 y27 b_1 x4 y4 x5 y5 x6 y6 x7 y7 x12 y12 x13 y13 x14 y14 x15 y15 x20 y20 x21 y21 x22 y22 x23 y23 x28 y28 x29 y29 x30 y30 x31 y31
                a_0 = Avx512BW.UnpackLow(x, y);
                a_1 = Avx512BW.UnpackHigh(x, y);
                // Rearrange.
                b_0 = YGroup2Zip_Int128(a_0, a_1, out _);
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup2ZipLow_Unpack(Vector512<int> x, Vector512<int> y) {
                return YGroup2ZipLow_Unpack(x.AsUInt32(), y.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup2ZipLow_Unpack(Vector512<uint> x, Vector512<uint> y) {
                Vector512<uint> a_0, a_1, b_0;
                // Zip layer by 128-bits unpack.
                // 0 _x_ x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 _y_ y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15
                // 1 a_0 x0 y0 x1 y1 x4 y4 x5 y5 x8 y8 x9 y9 x12 y12 x13 y13 a_1 x2 y2 x3 y3 x6 y6 x7 y7 x10 y10 x11 y11 x14 y14 x15 y15
                a_0 = Avx512F.UnpackLow(x, y);
                a_1 = Avx512F.UnpackHigh(x, y);
                // Rearrange.
                b_0 = YGroup2Zip_Int128(a_0, a_1, out _);
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup2ZipLow_Unpack(Vector512<long> x, Vector512<long> y) {
                return YGroup2ZipLow_Unpack(x.AsUInt64(), y.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup2ZipLow_Unpack(Vector512<ulong> x, Vector512<ulong> y) {
                Vector512<ulong> a_0, a_1, b_0;
                // Zip layer by 128-bits unpack.
                // 0 _x_ x0 x1 x2 x3 x4 x5 x6 x7 a_1 y0 y1 y2 y3 y4 y5 y6 y7
                // 1 b_0 x0 y0 x2 y2 x4 y4 x6 y6 b_1 x1 y1 x3 y3 x5 y5 x7 y7
                a_0 = Avx512F.UnpackLow(x, y);
                a_1 = Avx512F.UnpackHigh(x, y);
                // Rearrange.
                b_0 = YGroup2Zip_Int128(a_0, a_1, out _);
                return b_0;
            }


            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup4Unzip_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes | TypeCodeFlags.Int128 | TypeCodeFlags.UInt128;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup4Unzip(Vector512<float> data0, Vector512<float> data1, Vector512<float> data2, Vector512<float> data3, out Vector512<float> y, out Vector512<float> z, out Vector512<float> w) {
                return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup4Unzip(Vector512<double> data0, Vector512<double> data1, Vector512<double> data2, Vector512<double> data3, out Vector512<double> y, out Vector512<double> z, out Vector512<double> w) {
                return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup4Unzip(Vector512<sbyte> data0, Vector512<sbyte> data1, Vector512<sbyte> data2, Vector512<sbyte> data3, out Vector512<sbyte> y, out Vector512<sbyte> z, out Vector512<sbyte> w) {
                return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup4Unzip(Vector512<byte> data0, Vector512<byte> data1, Vector512<byte> data2, Vector512<byte> data3, out Vector512<byte> y, out Vector512<byte> z, out Vector512<byte> w) {
                return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup4Unzip(Vector512<short> data0, Vector512<short> data1, Vector512<short> data2, Vector512<short> data3, out Vector512<short> y, out Vector512<short> z, out Vector512<short> w) {
                return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup4Unzip(Vector512<ushort> data0, Vector512<ushort> data1, Vector512<ushort> data2, Vector512<ushort> data3, out Vector512<ushort> y, out Vector512<ushort> z, out Vector512<ushort> w) {
                return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup4Unzip(Vector512<int> data0, Vector512<int> data1, Vector512<int> data2, Vector512<int> data3, out Vector512<int> y, out Vector512<int> z, out Vector512<int> w) {
                return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup4Unzip(Vector512<uint> data0, Vector512<uint> data1, Vector512<uint> data2, Vector512<uint> data3, out Vector512<uint> y, out Vector512<uint> z, out Vector512<uint> w) {
                return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup4Unzip(Vector512<long> data0, Vector512<long> data1, Vector512<long> data2, Vector512<long> data3, out Vector512<long> y, out Vector512<long> z, out Vector512<long> w) {
                return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup4Unzip(Vector512<ulong> data0, Vector512<ulong> data1, Vector512<ulong> data2, Vector512<ulong> data3, out Vector512<ulong> y, out Vector512<ulong> z, out Vector512<ulong> w) {
                return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{ExInt128}, Vector512{ExInt128}, Vector512{ExInt128}, Vector512{ExInt128}, out Vector512{ExInt128}, out Vector512{ExInt128}, out Vector512{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExInt128> YGroup4Unzip(Vector512<ExInt128> data0, Vector512<ExInt128> data1, Vector512<ExInt128> data2, Vector512<ExInt128> data3, out Vector512<ExInt128> y, out Vector512<ExInt128> z, out Vector512<ExInt128> w) {
#if EX_APPLY_GENERIC
                return YGroup4Unzip_Int128(data0, data1, data2, data3, out y, out z, out w);
#else
                var d0 = YGroup4Unzip_Int128(data0.ExAsUInt64(), data1.ExAsUInt64(), data2.ExAsUInt64(), data3.ExAsUInt64(), out var d1, out var d2, out var d3);
                y = d1.ExAsExInt128();
                z = d2.ExAsExInt128();
                w = d3.ExAsExInt128();
                return d0.ExAsExInt128();
#endif // EX_APPLY_GENERIC
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{ExUInt128}, Vector512{ExUInt128}, Vector512{ExUInt128}, Vector512{ExUInt128}, out Vector512{ExUInt128}, out Vector512{ExUInt128}, out Vector512{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExUInt128> YGroup4Unzip(Vector512<ExUInt128> data0, Vector512<ExUInt128> data1, Vector512<ExUInt128> data2, Vector512<ExUInt128> data3, out Vector512<ExUInt128> y, out Vector512<ExUInt128> z, out Vector512<ExUInt128> w) {
#if EX_APPLY_GENERIC
                return YGroup4Unzip_Int128(data0, data1, data2, data3, out y, out z, out w);
#else
                var d0 = YGroup4Unzip_Int128(data0.ExAsUInt64(), data1.ExAsUInt64(), data2.ExAsUInt64(), data3.ExAsUInt64(), out var d1, out var d2, out var d3);
                y = d1.ExAsExUInt128();
                z = d2.ExAsExUInt128();
                w = d3.ExAsExUInt128();
                return d0.ExAsExUInt128();
#endif // EX_APPLY_GENERIC
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip_Int128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<T> YGroup4Unzip_Int128<T>(Vector512<T> data0, Vector512<T> data1, Vector512<T> data2, Vector512<T> data3, out Vector512<T> y, out Vector512<T> z, out Vector512<T> w) where T : struct {
                Vector512<T> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
                // 0 data0 x0 y0 z0 w0 data1 x1 y1 z1 w1 data2 x2 y2 z2 w2 data3 x3 y3 z3 w3
                // 1 a_0 x0 x2 y0 y2 a_1 z0 z2 w0 w2 a_2 x1 x3 y1 y3 a_3 z1 z3 w1 w3
                a_0 = YGroup2Unzip_Int128(data0, data1, out a_2);
                a_1 = YGroup2Unzip_Int128(data2, data3, out a_3);
                // 2 b_0 x0 x1 x2 x3 b_1 y0 y1 y2 y3 b_2 z0 z1 z2 z3 b_3 w0 w1 w2 w3
                b_0 = YGroup2Unzip_Int128(a_0, a_1, out b_2);
                b_1 = YGroup2Unzip_Int128(a_2, a_3, out b_3);
                y = b_1;
                z = b_2;
                w = b_3;
                return b_0;
            }

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
                rt0 = Narrow(Narrow(temp0, temp1), Narrow(temp2, temp3));
                temp0 = Avx512F.ShiftRightLogical(temp0, L);
                temp1 = Avx512F.ShiftRightLogical(temp1, L);
                temp2 = Avx512F.ShiftRightLogical(temp2, L);
                temp3 = Avx512F.ShiftRightLogical(temp3, L);
                rt1 = Narrow(Narrow(temp0, temp1), Narrow(temp2, temp3));
                temp0 = Avx512F.ShiftRightLogical(temp0, L);
                temp1 = Avx512F.ShiftRightLogical(temp1, L);
                temp2 = Avx512F.ShiftRightLogical(temp2, L);
                temp3 = Avx512F.ShiftRightLogical(temp3, L);
                rt2 = Narrow(Narrow(temp0, temp1), Narrow(temp2, temp3));
                temp0 = Avx512F.ShiftRightLogical(temp0, L);
                temp1 = Avx512F.ShiftRightLogical(temp1, L);
                temp2 = Avx512F.ShiftRightLogical(temp2, L);
                temp3 = Avx512F.ShiftRightLogical(temp3, L);
                rt3 = Narrow(Narrow(temp0, temp1), Narrow(temp2, temp3));
                y = rt1;
                z = rt2;
                w = rt3;
                return rt0;
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
                rt0 = Narrow(Narrow(temp0, temp1), Narrow(temp2, temp3));
                temp0 = Avx512F.ShiftRightLogical(temp0, L);
                temp1 = Avx512F.ShiftRightLogical(temp1, L);
                temp2 = Avx512F.ShiftRightLogical(temp2, L);
                temp3 = Avx512F.ShiftRightLogical(temp3, L);
                rt1 = Narrow(Narrow(temp0, temp1), Narrow(temp2, temp3));
                temp0 = Avx512F.ShiftRightLogical(temp0, L);
                temp1 = Avx512F.ShiftRightLogical(temp1, L);
                temp2 = Avx512F.ShiftRightLogical(temp2, L);
                temp3 = Avx512F.ShiftRightLogical(temp3, L);
                rt2 = Narrow(Narrow(temp0, temp1), Narrow(temp2, temp3));
                temp0 = Avx512F.ShiftRightLogical(temp0, L);
                temp1 = Avx512F.ShiftRightLogical(temp1, L);
                temp2 = Avx512F.ShiftRightLogical(temp2, L);
                temp3 = Avx512F.ShiftRightLogical(temp3, L);
                rt3 = Narrow(Narrow(temp0, temp1), Narrow(temp2, temp3));
                y = rt1;
                z = rt2;
                w = rt3;
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup4Unzip_Permute(Vector512<float> data0, Vector512<float> data1, Vector512<float> data2, Vector512<float> data3, out Vector512<float> y, out Vector512<float> z, out Vector512<float> w) {
                var d0 = YGroup4Unzip_Permute(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), out var d1, out var d2, out var d3);
                y = d1.AsSingle();
                z = d2.AsSingle();
                w = d3.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup4Unzip_Permute(Vector512<double> data0, Vector512<double> data1, Vector512<double> data2, Vector512<double> data3, out Vector512<double> y, out Vector512<double> z, out Vector512<double> w) {
                var d0 = YGroup4Unzip_Permute(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), data3.AsUInt64(), out var d1, out var d2, out var d3);
                y = d1.AsDouble();
                z = d2.AsDouble();
                w = d3.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup4Unzip_Permute(Vector512<sbyte> data0, Vector512<sbyte> data1, Vector512<sbyte> data2, Vector512<sbyte> data3, out Vector512<sbyte> y, out Vector512<sbyte> z, out Vector512<sbyte> w) {
                var d0 = YGroup4Unzip_Permute(data0.AsByte(), data1.AsByte(), data2.AsByte(), data3.AsByte(), out var d1, out var d2, out var d3);
                y = d1.AsSByte();
                z = d2.AsSByte();
                w = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup4Unzip_Permute(Vector512<byte> data0, Vector512<byte> data1, Vector512<byte> data2, Vector512<byte> data3, out Vector512<byte> y, out Vector512<byte> z, out Vector512<byte> w) {
                var f0 = Vector512Constants.YGroup4Unzip_ShuffleX2_Byte_X;
                var f1 = Vector512Constants.YGroup4Unzip_ShuffleX2_Byte_Y;
                var f2 = Vector512Constants.YGroup4Unzip_ShuffleX2_Byte_Z;
                var f3 = Vector512Constants.YGroup4Unzip_ShuffleX2_Byte_W;
                var a0 = Avx512Vbmi.PermuteVar64x8x2(data0, f0, data1).WithUpper(Avx512Vbmi.PermuteVar64x8x2(data2, f0, data3).GetLower());
                var a1 = Avx512Vbmi.PermuteVar64x8x2(data0, f1, data1).WithUpper(Avx512Vbmi.PermuteVar64x8x2(data2, f1, data3).GetLower());
                var a2 = Avx512Vbmi.PermuteVar64x8x2(data0, f2, data1).WithUpper(Avx512Vbmi.PermuteVar64x8x2(data2, f2, data3).GetLower());
                var a3 = Avx512Vbmi.PermuteVar64x8x2(data0, f3, data1).WithUpper(Avx512Vbmi.PermuteVar64x8x2(data2, f3, data3).GetLower());
                y = a1;
                z = a2;
                w = a3;
                return a0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup4Unzip_Permute(Vector512<short> data0, Vector512<short> data1, Vector512<short> data2, Vector512<short> data3, out Vector512<short> y, out Vector512<short> z, out Vector512<short> w) {
                var d0 = YGroup4Unzip_Permute(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), data3.AsUInt16(), out var d1, out var d2, out var d3);
                y = d1.AsInt16();
                z = d2.AsInt16();
                w = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup4Unzip_Permute(Vector512<ushort> data0, Vector512<ushort> data1, Vector512<ushort> data2, Vector512<ushort> data3, out Vector512<ushort> y, out Vector512<ushort> z, out Vector512<ushort> w) {
                var f0 = Vector512Constants.YGroup4Unzip_ShuffleX2_UInt16_X;
                var f1 = Vector512Constants.YGroup4Unzip_ShuffleX2_UInt16_Y;
                var f2 = Vector512Constants.YGroup4Unzip_ShuffleX2_UInt16_Z;
                var f3 = Vector512Constants.YGroup4Unzip_ShuffleX2_UInt16_W;
                var a0 = Avx512BW.PermuteVar32x16x2(data0, f0, data1).WithUpper(Avx512BW.PermuteVar32x16x2(data2, f0, data3).GetLower());
                var a1 = Avx512BW.PermuteVar32x16x2(data0, f1, data1).WithUpper(Avx512BW.PermuteVar32x16x2(data2, f1, data3).GetLower());
                var a2 = Avx512BW.PermuteVar32x16x2(data0, f2, data1).WithUpper(Avx512BW.PermuteVar32x16x2(data2, f2, data3).GetLower());
                var a3 = Avx512BW.PermuteVar32x16x2(data0, f3, data1).WithUpper(Avx512BW.PermuteVar32x16x2(data2, f3, data3).GetLower());
                y = a1;
                z = a2;
                w = a3;
                return a0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup4Unzip_Permute(Vector512<int> data0, Vector512<int> data1, Vector512<int> data2, Vector512<int> data3, out Vector512<int> y, out Vector512<int> z, out Vector512<int> w) {
                var d0 = YGroup4Unzip_Permute(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), out var d1, out var d2, out var d3);
                y = d1.AsInt32();
                z = d2.AsInt32();
                w = d3.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup4Unzip_Permute(Vector512<uint> data0, Vector512<uint> data1, Vector512<uint> data2, Vector512<uint> data3, out Vector512<uint> y, out Vector512<uint> z, out Vector512<uint> w) {
                var f0 = Vector512Constants.YGroup4Unzip_ShuffleX2_UInt32_X;
                var f1 = Vector512Constants.YGroup4Unzip_ShuffleX2_UInt32_Y;
                var f2 = Vector512Constants.YGroup4Unzip_ShuffleX2_UInt32_Z;
                var f3 = Vector512Constants.YGroup4Unzip_ShuffleX2_UInt32_W;
                var a0 = Avx512F.PermuteVar16x32x2(data0, f0, data1).WithUpper(Avx512F.PermuteVar16x32x2(data2, f0, data3).GetLower());
                var a1 = Avx512F.PermuteVar16x32x2(data0, f1, data1).WithUpper(Avx512F.PermuteVar16x32x2(data2, f1, data3).GetLower());
                var a2 = Avx512F.PermuteVar16x32x2(data0, f2, data1).WithUpper(Avx512F.PermuteVar16x32x2(data2, f2, data3).GetLower());
                var a3 = Avx512F.PermuteVar16x32x2(data0, f3, data1).WithUpper(Avx512F.PermuteVar16x32x2(data2, f3, data3).GetLower());
                y = a1;
                z = a2;
                w = a3;
                return a0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup4Unzip_Permute(Vector512<long> data0, Vector512<long> data1, Vector512<long> data2, Vector512<long> data3, out Vector512<long> y, out Vector512<long> z, out Vector512<long> w) {
                var d0 = YGroup4Unzip_Permute(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), data3.AsUInt64(), out var d1, out var d2, out var d3);
                y = d1.AsInt64();
                z = d2.AsInt64();
                w = d3.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup4Unzip_Permute(Vector512<ulong> data0, Vector512<ulong> data1, Vector512<ulong> data2, Vector512<ulong> data3, out Vector512<ulong> y, out Vector512<ulong> z, out Vector512<ulong> w) {
                var f0 = Vector512Constants.YGroup4Unzip_ShuffleX2_UInt64_X;
                var f1 = Vector512Constants.YGroup4Unzip_ShuffleX2_UInt64_Y;
                var f2 = Vector512Constants.YGroup4Unzip_ShuffleX2_UInt64_Z;
                var f3 = Vector512Constants.YGroup4Unzip_ShuffleX2_UInt64_W;
                var a0 = Avx512F.PermuteVar8x64x2(data0, f0, data1).WithUpper(Avx512F.PermuteVar8x64x2(data2, f0, data3).GetLower());
                var a1 = Avx512F.PermuteVar8x64x2(data0, f1, data1).WithUpper(Avx512F.PermuteVar8x64x2(data2, f1, data3).GetLower());
                var a2 = Avx512F.PermuteVar8x64x2(data0, f2, data1).WithUpper(Avx512F.PermuteVar8x64x2(data2, f2, data3).GetLower());
                var a3 = Avx512F.PermuteVar8x64x2(data0, f3, data1).WithUpper(Avx512F.PermuteVar8x64x2(data2, f3, data3).GetLower());
                y = a1;
                z = a2;
                w = a3;
                return a0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup4Unzip_Unpack(Vector512<float> data0, Vector512<float> data1, Vector512<float> data2, Vector512<float> data3, out Vector512<float> y, out Vector512<float> z, out Vector512<float> w) {
                var d0 = YGroup4Unzip_Unpack(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), out var d1, out var d2, out var d3);
                y = d1.AsSingle();
                z = d2.AsSingle();
                w = d3.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup4Unzip_Unpack(Vector512<double> data0, Vector512<double> data1, Vector512<double> data2, Vector512<double> data3, out Vector512<double> y, out Vector512<double> z, out Vector512<double> w) {
                var d0 = YGroup4Unzip_Unpack(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), data3.AsUInt64(), out var d1, out var d2, out var d3);
                y = d1.AsDouble();
                z = d2.AsDouble();
                w = d3.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup4Unzip_Unpack(Vector512<sbyte> data0, Vector512<sbyte> data1, Vector512<sbyte> data2, Vector512<sbyte> data3, out Vector512<sbyte> y, out Vector512<sbyte> z, out Vector512<sbyte> w) {
                var d0 = YGroup4Unzip_Unpack(data0.AsByte(), data1.AsByte(), data2.AsByte(), data3.AsByte(), out var d1, out var d2, out var d3);
                y = d1.AsSByte();
                z = d2.AsSByte();
                w = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup4Unzip_Unpack(Vector512<byte> data0, Vector512<byte> data1, Vector512<byte> data2, Vector512<byte> data3, out Vector512<byte> y, out Vector512<byte> z, out Vector512<byte> w) {
                Vector512<byte> temp0, temp1, temp2, temp3;
                Vector512<byte> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
                // Zip layer by 128-bits unpack.
                // 0 data0 x0 y0 z0 w0 x1 y1 z1 w1 x2 y2 z2 w2 x3 y3 z3 w3 x4 y4 z4 w4 x5 y5 z5 w5 x6 y6 z6 w6 x7 y7 z7 w7 x8 y8 z8 w8 x9 y9 z9 w9 x10 y10 z10 w10 x11 y11 z11 w11 x12 y12 z12 w12 x13 y13 z13 w13 x14 y14 z14 w14 x15 y15 z15 w15 data1 x16 y16 z16 w16 x17 y17 z17 w17 x18 y18 z18 w18 x19 y19 z19 w19 x20 y20 z20 w20 x21 y21 z21 w21 x22 y22 z22 w22 x23 y23 z23 w23 x24 y24 z24 w24 x25 y25 z25 w25 x26 y26 z26 w26 x27 y27 z27 w27 x28 y28 z28 w28 x29 y29 z29 w29 x30 y30 z30 w30 x31 y31 z31 w31 data2 x32 y32 z32 w32 x33 y33 z33 w33 x34 y34 z34 w34 x35 y35 z35 w35 x36 y36 z36 w36 x37 y37 z37 w37 x38 y38 z38 w38 x39 y39 z39 w39 x40 y40 z40 w40 x41 y41 z41 w41 x42 y42 z42 w42 x43 y43 z43 w43 x44 y44 z44 w44 x45 y45 z45 w45 x46 y46 z46 w46 x47 y47 z47 w47 data3 x48 y48 z48 w48 x49 y49 z49 w49 x50 y50 z50 w50 x51 y51 z51 w51 x52 y52 z52 w52 x53 y53 z53 w53 x54 y54 z54 w54 x55 y55 z55 w55 x56 y56 z56 w56 x57 y57 z57 w57 x58 y58 z58 w58 x59 y59 z59 w59 x60 y60 z60 w60 x61 y61 z61 w61 x62 y62 z62 w62 x63 y63 z63 w63
                //0b temp0 x0 y0 z0 w0 x1 y1 z1 w1 x2 y2 z2 w2 x3 y3 z3 w3 x16 y16 z16 w16 x17 y17 z17 w17 x18 y18 z18 w18 x19 y19 z19 w19 x32 y32 z32 w32 x33 y33 z33 w33 x34 y34 z34 w34 x35 y35 z35 w35 x48 y48 z48 w48 x49 y49 z49 w49 x50 y50 z50 w50 x51 y51 z51 w51 temp1 x4 y4 z4 w4 x5 y5 z5 w5 x6 y6 z6 w6 x7 y7 z7 w7 x20 y20 z20 w20 x21 y21 z21 w21 x22 y22 z22 w22 x23 y23 z23 w23 x36 y36 z36 w36 x37 y37 z37 w37 x38 y38 z38 w38 x39 y39 z39 w39 x52 y52 z52 w52 x53 y53 z53 w53 x54 y54 z54 w54 x55 y55 z55 w55 temp2 x8 y8 z8 w8 x9 y9 z9 w9 x10 y10 z10 w10 x11 y11 z11 w11 x24 y24 z24 w24 x25 y25 z25 w25 x26 y26 z26 w26 x27 y27 z27 w27 x40 y40 z40 w40 x41 y41 z41 w41 x42 y42 z42 w42 x43 y43 z43 w43 x56 y56 z56 w56 x57 y57 z57 w57 x58 y58 z58 w58 x59 y59 z59 w59 temp3 x12 y12 z12 w12 x13 y13 z13 w13 x14 y14 z14 w14 x15 y15 z15 w15 x28 y28 z28 w28 x29 y29 z29 w29 x30 y30 z30 w30 x31 y31 z31 w31 x44 y44 z44 w44 x45 y45 z45 w45 x46 y46 z46 w46 x47 y47 z47 w47 x60 y60 z60 w60 x61 y61 z61 w61 x62 y62 z62 w62 x63 y63 z63 w63
                temp0 = YGroup4Unzip_Int128(data0, data1, data2, data3, out temp1, out temp2, out temp3);
                // 1 a_0 x0 x8 y0 y8 z0 z8 w0 w8 x1 x9 y1 y9 z1 z9 w1 w9 x16 x24 y16 y24 z16 z24 w16 w24 x17 x25 y17 y25 z17 z25 w17 w25 x32 x40 y32 y40 z32 z40 w32 w40 x33 x41 y33 y41 z33 z41 w33 w41 x48 x56 y48 y56 z48 z56 w48 w56 x49 x57 y49 y57 z49 z57 w49 w57 a_1 x2 x10 y2 y10 z2 z10 w2 w10 x3 x11 y3 y11 z3 z11 w3 w11 x18 x26 y18 y26 z18 z26 w18 w26 x19 x27 y19 y27 z19 z27 w19 w27 x34 x42 y34 y42 z34 z42 w34 w42 x35 x43 y35 y43 z35 z43 w35 w43 x50 x58 y50 y58 z50 z58 w50 w58 x51 x59 y51 y59 z51 z59 w51 w59 a_2 x4 x12 y4 y12 z4 z12 w4 w12 x5 x13 y5 y13 z5 z13 w5 w13 x20 x28 y20 y28 z20 z28 w20 w28 x21 x29 y21 y29 z21 z29 w21 w29 x36 x44 y36 y44 z36 z44 w36 w44 x37 x45 y37 y45 z37 z45 w37 w45 x52 x60 y52 y60 z52 z60 w52 w60 x53 x61 y53 y61 z53 z61 w53 w61 a_3 x6 x14 y6 y14 z6 z14 w6 w14 x7 x15 y7 y15 z7 z15 w7 w15 x22 x30 y22 y30 z22 z30 w22 w30 x23 x31 y23 y31 z23 z31 w23 w31 x38 x46 y38 y46 z38 z46 w38 w46 x39 x47 y39 y47 z39 z47 w39 w47 x54 x62 y54 y62 z54 z62 w54 w62 x55 x63 y55 y63 z55 z63 w55 w63
                a_0 = Avx512BW.UnpackLow(temp0, temp2);
                a_1 = Avx512BW.UnpackHigh(temp0, temp2);
                a_2 = Avx512BW.UnpackLow(temp1, temp3);
                a_3 = Avx512BW.UnpackHigh(temp1, temp3);
                // 2 b_0 x0 x4 x8 x12 y0 y4 y8 y12 z0 z4 z8 z12 w0 w4 w8 w12 x16 x20 x24 x28 y16 y20 y24 y28 z16 z20 z24 z28 w16 w20 w24 w28 x32 x36 x40 x44 y32 y36 y40 y44 z32 z36 z40 z44 w32 w36 w40 w44 x48 x52 x56 x60 y48 y52 y56 y60 z48 z52 z56 z60 w48 w52 w56 w60 b_1 x1 x5 x9 x13 y1 y5 y9 y13 z1 z5 z9 z13 w1 w5 w9 w13 x17 x21 x25 x29 y17 y21 y25 y29 z17 z21 z25 z29 w17 w21 w25 w29 x33 x37 x41 x45 y33 y37 y41 y45 z33 z37 z41 z45 w33 w37 w41 w45 x49 x53 x57 x61 y49 y53 y57 y61 z49 z53 z57 z61 w49 w53 w57 w61 b_2 x2 x6 x10 x14 y2 y6 y10 y14 z2 z6 z10 z14 w2 w6 w10 w14 x18 x22 x26 x30 y18 y22 y26 y30 z18 z22 z26 z30 w18 w22 w26 w30 x34 x38 x42 x46 y34 y38 y42 y46 z34 z38 z42 z46 w34 w38 w42 w46 x50 x54 x58 x62 y50 y54 y58 y62 z50 z54 z58 z62 w50 w54 w58 w62 b_3 x3 x7 x11 x15 y3 y7 y11 y15 z3 z7 z11 z15 w3 w7 w11 w15 x19 x23 x27 x31 y19 y23 y27 y31 z19 z23 z27 z31 w19 w23 w27 w31 x35 x39 x43 x47 y35 y39 y43 y47 z35 z39 z43 z47 w35 w39 w43 w47 x51 x55 x59 x63 y51 y55 y59 y63 z51 z55 z59 z63 w51 w55 w59 w63
                b_0 = Avx512BW.UnpackLow(a_0, a_2);
                b_1 = Avx512BW.UnpackHigh(a_0, a_2);
                b_2 = Avx512BW.UnpackLow(a_1, a_3);
                b_3 = Avx512BW.UnpackHigh(a_1, a_3);
                // 3 a_0 x0 x2 x4 x6 x8 x10 x12 x14 y0 y2 y4 y6 y8 y10 y12 y14 x16 x18 x20 x22 x24 x26 x28 x30 y16 y18 y20 y22 y24 y26 y28 y30 x32 x34 x36 x38 x40 x42 x44 x46 y32 y34 y36 y38 y40 y42 y44 y46 x48 x50 x52 x54 x56 x58 x60 x62 y48 y50 y52 y54 y56 y58 y60 y62 a_1 z0 z2 z4 z6 z8 z10 z12 z14 w0 w2 w4 w6 w8 w10 w12 w14 z16 z18 z20 z22 z24 z26 z28 z30 w16 w18 w20 w22 w24 w26 w28 w30 z32 z34 z36 z38 z40 z42 z44 z46 w32 w34 w36 w38 w40 w42 w44 w46 z48 z50 z52 z54 z56 z58 z60 z62 w48 w50 w52 w54 w56 w58 w60 w62 a_2 x1 x3 x5 x7 x9 x11 x13 x15 y1 y3 y5 y7 y9 y11 y13 y15 x17 x19 x21 x23 x25 x27 x29 x31 y17 y19 y21 y23 y25 y27 y29 y31 x33 x35 x37 x39 x41 x43 x45 x47 y33 y35 y37 y39 y41 y43 y45 y47 x49 x51 x53 x55 x57 x59 x61 x63 y49 y51 y53 y55 y57 y59 y61 y63 a_3 z1 z3 z5 z7 z9 z11 z13 z15 w1 w3 w5 w7 w9 w11 w13 w15 z17 z19 z21 z23 z25 z27 z29 z31 w17 w19 w21 w23 w25 w27 w29 w31 z33 z35 z37 z39 z41 z43 z45 z47 w33 w35 w37 w39 w41 w43 w45 w47 z49 z51 z53 z55 z57 z59 z61 z63 w49 w51 w53 w55 w57 w59 w61 w63
                a_0 = Avx512BW.UnpackLow(b_0, b_2);
                a_1 = Avx512BW.UnpackHigh(b_0, b_2);
                a_2 = Avx512BW.UnpackLow(b_1, b_3);
                a_3 = Avx512BW.UnpackHigh(b_1, b_3);
                // 4 b_0 x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 x16 x17 x18 x19 x20 x21 x22 x23 x24 x25 x26 x27 x28 x29 x30 x31 x32 x33 x34 x35 x36 x37 x38 x39 x40 x41 x42 x43 x44 x45 x46 x47 x48 x49 x50 x51 x52 x53 x54 x55 x56 x57 x58 x59 x60 x61 x62 x63 b_1 y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 y16 y17 y18 y19 y20 y21 y22 y23 y24 y25 y26 y27 y28 y29 y30 y31 y32 y33 y34 y35 y36 y37 y38 y39 y40 y41 y42 y43 y44 y45 y46 y47 y48 y49 y50 y51 y52 y53 y54 y55 y56 y57 y58 y59 y60 y61 y62 y63 b_2 z0 z1 z2 z3 z4 z5 z6 z7 z8 z9 z10 z11 z12 z13 z14 z15 z16 z17 z18 z19 z20 z21 z22 z23 z24 z25 z26 z27 z28 z29 z30 z31 z32 z33 z34 z35 z36 z37 z38 z39 z40 z41 z42 z43 z44 z45 z46 z47 z48 z49 z50 z51 z52 z53 z54 z55 z56 z57 z58 z59 z60 z61 z62 z63 b_3 w0 w1 w2 w3 w4 w5 w6 w7 w8 w9 w10 w11 w12 w13 w14 w15 w16 w17 w18 w19 w20 w21 w22 w23 w24 w25 w26 w27 w28 w29 w30 w31 w32 w33 w34 w35 w36 w37 w38 w39 w40 w41 w42 w43 w44 w45 w46 w47 w48 w49 w50 w51 w52 w53 w54 w55 w56 w57 w58 w59 w60 w61 w62 w63
                b_0 = Avx512BW.UnpackLow(a_0, a_2);
                b_1 = Avx512BW.UnpackHigh(a_0, a_2);
                b_2 = Avx512BW.UnpackLow(a_1, a_3);
                b_3 = Avx512BW.UnpackHigh(a_1, a_3);
                y = b_1;
                z = b_2;
                w = b_3;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup4Unzip_Unpack(Vector512<short> data0, Vector512<short> data1, Vector512<short> data2, Vector512<short> data3, out Vector512<short> y, out Vector512<short> z, out Vector512<short> w) {
                var d0 = YGroup4Unzip_Unpack(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), data3.AsUInt16(), out var d1, out var d2, out var d3);
                y = d1.AsInt16();
                z = d2.AsInt16();
                w = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup4Unzip_Unpack(Vector512<ushort> data0, Vector512<ushort> data1, Vector512<ushort> data2, Vector512<ushort> data3, out Vector512<ushort> y, out Vector512<ushort> z, out Vector512<ushort> w) {
                Vector512<ushort> temp0, temp1, temp2, temp3;
                Vector512<ushort> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
                // Zip layer by 128-bits unpack.
                // 0 data0 x0 y0 z0 w0 x1 y1 z1 w1 x2 y2 z2 w2 x3 y3 z3 w3 x4 y4 z4 w4 x5 y5 z5 w5 x6 y6 z6 w6 x7 y7 z7 w7 data1 x8 y8 z8 w8 x9 y9 z9 w9 x10 y10 z10 w10 x11 y11 z11 w11 x12 y12 z12 w12 x13 y13 z13 w13 x14 y14 z14 w14 x15 y15 z15 w15 data2 x16 y16 z16 w16 x17 y17 z17 w17 x18 y18 z18 w18 x19 y19 z19 w19 x20 y20 z20 w20 x21 y21 z21 w21 x22 y22 z22 w22 x23 y23 z23 w23 data3 x24 y24 z24 w24 x25 y25 z25 w25 x26 y26 z26 w26 x27 y27 z27 w27 x28 y28 z28 w28 x29 y29 z29 w29 x30 y30 z30 w30 x31 y31 z31 w31
                //0b temp0 x0 y0 z0 w0 x1 y1 z1 w1 x8 y8 z8 w8 x9 y9 z9 w9 x16 y16 z16 w16 x17 y17 z17 w17 x24 y24 z24 w24 x25 y25 z25 w25 temp1 x2 y2 z2 w2 x3 y3 z3 w3 x10 y10 z10 w10 x11 y11 z11 w11 x18 y18 z18 w18 x19 y19 z19 w19 x26 y26 z26 w26 x27 y27 z27 w27 temp2 x4 y4 z4 w4 x5 y5 z5 w5 x12 y12 z12 w12 x13 y13 z13 w13 x20 y20 z20 w20 x21 y21 z21 w21 x28 y28 z28 w28 x29 y29 z29 w29 temp3 x6 y6 z6 w6 x7 y7 z7 w7 x14 y14 z14 w14 x15 y15 z15 w15 x22 y22 z22 w22 x23 y23 z23 w23 x30 y30 z30 w30 x31 y31 z31 w31
                temp0 = YGroup4Unzip_Int128(data0, data1, data2, data3, out temp1, out temp2, out temp3);
                // 1 a_0 x0 x4 y0 y4 z0 z4 w0 w4 x8 x12 y8 y12 z8 z12 w8 w12 x16 x20 y16 y20 z16 z20 w16 w20 x24 x28 y24 y28 z24 z28 w24 w28 a_1 x1 x5 y1 y5 z1 z5 w1 w5 x9 x13 y9 y13 z9 z13 w9 w13 x17 x21 y17 y21 z17 z21 w17 w21 x25 x29 y25 y29 z25 z29 w25 w29 a_2 x2 x6 y2 y6 z2 z6 w2 w6 x10 x14 y10 y14 z10 z14 w10 w14 x18 x22 y18 y22 z18 z22 w18 w22 x26 x30 y26 y30 z26 z30 w26 w30 a_3 x3 x7 y3 y7 z3 z7 w3 w7 x11 x15 y11 y15 z11 z15 w11 w15 x19 x23 y19 y23 z19 z23 w19 w23 x27 x31 y27 y31 z27 z31 w27 w31
                a_0 = Avx512BW.UnpackLow(temp0, temp2);
                a_1 = Avx512BW.UnpackHigh(temp0, temp2);
                a_2 = Avx512BW.UnpackLow(temp1, temp3);
                a_3 = Avx512BW.UnpackHigh(temp1, temp3);
                // 2 b_0 x0 x2 x4 x6 y0 y2 y4 y6 x8 x10 x12 x14 y8 y10 y12 y14 x16 x18 x20 x22 y16 y18 y20 y22 x24 x26 x28 x30 y24 y26 y28 y30 b_1 z0 z2 z4 z6 w0 w2 w4 w6 z8 z10 z12 z14 w8 w10 w12 w14 z16 z18 z20 z22 w16 w18 w20 w22 z24 z26 z28 z30 w24 w26 w28 w30 b_2 x1 x3 x5 x7 y1 y3 y5 y7 x9 x11 x13 x15 y9 y11 y13 y15 x17 x19 x21 x23 y17 y19 y21 y23 x25 x27 x29 x31 y25 y27 y29 y31 b_3 z1 z3 z5 z7 w1 w3 w5 w7 z9 z11 z13 z15 w9 w11 w13 w15 z17 z19 z21 z23 w17 w19 w21 w23 z25 z27 z29 z31 w25 w27 w29 w31
                b_0 = Avx512BW.UnpackLow(a_0, a_2);
                b_1 = Avx512BW.UnpackHigh(a_0, a_2);
                b_2 = Avx512BW.UnpackLow(a_1, a_3);
                b_3 = Avx512BW.UnpackHigh(a_1, a_3);
                // 3 a_0 x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 x16 x17 x18 x19 x20 x21 x22 x23 x24 x25 x26 x27 x28 x29 x30 x31 a_1 y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 y16 y17 y18 y19 y20 y21 y22 y23 y24 y25 y26 y27 y28 y29 y30 y31 a_2 z0 z1 z2 z3 z4 z5 z6 z7 z8 z9 z10 z11 z12 z13 z14 z15 z16 z17 z18 z19 z20 z21 z22 z23 z24 z25 z26 z27 z28 z29 z30 z31 a_3 w0 w1 w2 w3 w4 w5 w6 w7 w8 w9 w10 w11 w12 w13 w14 w15 w16 w17 w18 w19 w20 w21 w22 w23 w24 w25 w26 w27 w28 w29 w30 w31
                a_0 = Avx512BW.UnpackLow(b_0, b_2);
                a_1 = Avx512BW.UnpackHigh(b_0, b_2);
                a_2 = Avx512BW.UnpackLow(b_1, b_3);
                a_3 = Avx512BW.UnpackHigh(b_1, b_3);
                y = a_1;
                z = a_2;
                w = a_3;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup4Unzip_Unpack(Vector512<int> data0, Vector512<int> data1, Vector512<int> data2, Vector512<int> data3, out Vector512<int> y, out Vector512<int> z, out Vector512<int> w) {
                var d0 = YGroup4Unzip_Unpack(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), out var d1, out var d2, out var d3);
                y = d1.AsInt32();
                z = d2.AsInt32();
                w = d3.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup4Unzip_Unpack(Vector512<uint> data0, Vector512<uint> data1, Vector512<uint> data2, Vector512<uint> data3, out Vector512<uint> y, out Vector512<uint> z, out Vector512<uint> w) {
                Vector512<uint> temp0, temp1, temp2, temp3;
                Vector512<uint> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
                // Zip layer by 128-bits unpack.
                // 0 data0 x0 y0 z0 w0 x1 y1 z1 w1 x2 y2 z2 w2 x3 y3 z3 w3 data1 x4 y4 z4 w4 x5 y5 z5 w5 x6 y6 z6 w6 x7 y7 z7 w7 data2 x8 y8 z8 w8 x9 y9 z9 w9 x10 y10 z10 w10 x11 y11 z11 w11 data3 x12 y12 z12 w12 x13 y13 z13 w13 x14 y14 z14 w14 x15 y15 z15 w15
                //0b temp0 x0 y0 z0 w0 x4 y4 z4 w4 x8 y8 z8 w8 x12 y12 z12 w12 temp1 x1 y1 z1 w1 x5 y5 z5 w5 x9 y9 z9 w9 x13 y13 z13 w13 temp2 x2 y2 z2 w2 x6 y6 z6 w6 x10 y10 z10 w10 x14 y14 z14 w14 temp3 x3 y3 z3 w3 x7 y7 z7 w7 x11 y11 z11 w11 x15 y15 z15 w15
                temp0 = YGroup4Unzip_Int128(data0, data1, data2, data3, out temp1, out temp2, out temp3);
                // 1 a_0 x0 x2 y0 y2 x4 x6 y4 y6 x8 x10 y8 y10 x12 x14 y12 y14 a_1 z0 z2 w0 w2 z4 z6 w4 w6 z8 z10 w8 w10 z12 z14 w12 w14 a_2 x1 x3 y1 y3 x5 x7 y5 y7 x9 x11 y9 y11 x13 x15 y13 y15 a_3 z1 z3 w1 w3 z5 z7 w5 w7 z9 z11 w9 w11 z13 z15 w13 w15
                a_0 = Avx512F.UnpackLow(temp0, temp2);
                a_1 = Avx512F.UnpackHigh(temp0, temp2);
                a_2 = Avx512F.UnpackLow(temp1, temp3);
                a_3 = Avx512F.UnpackHigh(temp1, temp3);
                // 2 b_0 x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 b_1 y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 b_2 z0 z1 z2 z3 z4 z5 z6 z7 z8 z9 z10 z11 z12 z13 z14 z15 b_3 w0 w1 w2 w3 w4 w5 w6 w7 w8 w9 w10 w11 w12 w13 w14 w15
                b_0 = Avx512F.UnpackLow(a_0, a_2);
                b_1 = Avx512F.UnpackHigh(a_0, a_2);
                b_2 = Avx512F.UnpackLow(a_1, a_3);
                b_3 = Avx512F.UnpackHigh(a_1, a_3);
                y = b_1;
                z = b_2;
                w = b_3;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup4Unzip_Unpack(Vector512<long> data0, Vector512<long> data1, Vector512<long> data2, Vector512<long> data3, out Vector512<long> y, out Vector512<long> z, out Vector512<long> w) {
                var d0 = YGroup4Unzip_Unpack(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), data3.AsUInt64(), out var d1, out var d2, out var d3);
                y = d1.AsInt64();
                z = d2.AsInt64();
                w = d3.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup4Unzip_Unpack(Vector512<ulong> data0, Vector512<ulong> data1, Vector512<ulong> data2, Vector512<ulong> data3, out Vector512<ulong> y, out Vector512<ulong> z, out Vector512<ulong> w) {
                Vector512<ulong> temp0, temp1, temp2, temp3;
                Vector512<ulong> a_0, a_1, a_2, a_3;
                // Zip layer by 128-bits unpack.
                // 0 data0 x0 y0 z0 w0 x1 y1 z1 w1 data1 x2 y2 z2 w2 x3 y3 z3 w3 data2 x4 y4 z4 w4 x5 y5 z5 w5 data3 x6 y6 z6 w6 x7 y7 z7 w7
                //0b temp0 x0 y0 x2 y2 x4 y4 x6 y6 temp1 z0 w0 z2 w2 z4 w4 z6 w6 temp2 x1 y1 x3 y3 x5 y5 x7 y7 temp3 z1 w1 z3 w3 z5 w5 z7 w7
                temp0 = YGroup4Unzip_Int128(data0, data1, data2, data3, out temp1, out temp2, out temp3);
                // 1 a_0 x0 x1 x2 x3 x4 x5 x6 x7 a_1 y0 y1 y2 y3 y4 y5 y6 y7 a_2 z0 z1 z2 z3 z4 z5 z6 z7 a_3 w0 w1 w2 w3 w4 w5 w6 w7
                a_0 = Avx512F.UnpackLow(temp0, temp2);
                a_1 = Avx512F.UnpackHigh(temp0, temp2);
                a_2 = Avx512F.UnpackLow(temp1, temp3);
                a_3 = Avx512F.UnpackHigh(temp1, temp3);
                y = a_1;
                z = a_2;
                w = a_3;
                return a_0;
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

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup4Unzip_Unzip(Vector512<double> data0, Vector512<double> data1, Vector512<double> data2, Vector512<double> data3, out Vector512<double> y, out Vector512<double> z, out Vector512<double> w) {
                var d0 = YGroup4Unzip_Unzip(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), data3.AsUInt64(), out var d1, out var d2, out var d3);
                y = d1.AsDouble();
                z = d2.AsDouble();
                w = d3.AsDouble();
                return d0.AsDouble();
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

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup4Unzip_Unzip(Vector512<long> data0, Vector512<long> data1, Vector512<long> data2, Vector512<long> data3, out Vector512<long> y, out Vector512<long> z, out Vector512<long> w) {
                var d0 = YGroup4Unzip_Unzip(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), data3.AsUInt64(), out var d1, out var d2, out var d3);
                y = d1.AsInt64();
                z = d2.AsInt64();
                w = d3.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup4Unzip_Unzip(Vector512<ulong> data0, Vector512<ulong> data1, Vector512<ulong> data2, Vector512<ulong> data3, out Vector512<ulong> y, out Vector512<ulong> z, out Vector512<ulong> w) {
                Vector512<ulong> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
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


            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup4Zip_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes | TypeCodeFlags.Int128 | TypeCodeFlags.UInt128;
                    return rt;
                }
            }
            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup4Zip(Vector512<float> x, Vector512<float> y, Vector512<float> z, Vector512<float> w, out Vector512<float> data1, out Vector512<float> data2, out Vector512<float> data3) {
                return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup4Zip(Vector512<double> x, Vector512<double> y, Vector512<double> z, Vector512<double> w, out Vector512<double> data1, out Vector512<double> data2, out Vector512<double> data3) {
                return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup4Zip(Vector512<sbyte> x, Vector512<sbyte> y, Vector512<sbyte> z, Vector512<sbyte> w, out Vector512<sbyte> data1, out Vector512<sbyte> data2, out Vector512<sbyte> data3) {
                return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup4Zip(Vector512<byte> x, Vector512<byte> y, Vector512<byte> z, Vector512<byte> w, out Vector512<byte> data1, out Vector512<byte> data2, out Vector512<byte> data3) {
                return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup4Zip(Vector512<short> x, Vector512<short> y, Vector512<short> z, Vector512<short> w, out Vector512<short> data1, out Vector512<short> data2, out Vector512<short> data3) {
                return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup4Zip(Vector512<ushort> x, Vector512<ushort> y, Vector512<ushort> z, Vector512<ushort> w, out Vector512<ushort> data1, out Vector512<ushort> data2, out Vector512<ushort> data3) {
                return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup4Zip(Vector512<int> x, Vector512<int> y, Vector512<int> z, Vector512<int> w, out Vector512<int> data1, out Vector512<int> data2, out Vector512<int> data3) {
                return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup4Zip(Vector512<uint> x, Vector512<uint> y, Vector512<uint> z, Vector512<uint> w, out Vector512<uint> data1, out Vector512<uint> data2, out Vector512<uint> data3) {
                return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup4Zip(Vector512<long> x, Vector512<long> y, Vector512<long> z, Vector512<long> w, out Vector512<long> data1, out Vector512<long> data2, out Vector512<long> data3) {
                return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup4Zip(Vector512<ulong> x, Vector512<ulong> y, Vector512<ulong> z, Vector512<ulong> w, out Vector512<ulong> data1, out Vector512<ulong> data2, out Vector512<ulong> data3) {
                return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{ExInt128}, Vector512{ExInt128}, Vector512{ExInt128}, Vector512{ExInt128}, out Vector512{ExInt128}, out Vector512{ExInt128}, out Vector512{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExInt128> YGroup4Zip(Vector512<ExInt128> x, Vector512<ExInt128> y, Vector512<ExInt128> z, Vector512<ExInt128> w, out Vector512<ExInt128> data1, out Vector512<ExInt128> data2, out Vector512<ExInt128> data3) {
#if EX_APPLY_GENERIC
                return YGroup4Zip_Int128(x, y, z, w, out data1, out data2, out data3);
#else
                var d0 = YGroup4Zip_Int128(x.ExAsUInt64(), y.ExAsUInt64(), z.ExAsUInt64(), w.ExAsUInt64(), out var d1, out var d2, out var d3);
                data1 = d1.ExAsExInt128();
                data2 = d2.ExAsExInt128();
                data3 = d3.ExAsExInt128();
                return d0.ExAsExInt128();
#endif // EX_APPLY_GENERIC
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{ExUInt128}, Vector512{ExUInt128}, Vector512{ExUInt128}, Vector512{ExUInt128}, out Vector512{ExUInt128}, out Vector512{ExUInt128}, out Vector512{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ExUInt128> YGroup4Zip(Vector512<ExUInt128> x, Vector512<ExUInt128> y, Vector512<ExUInt128> z, Vector512<ExUInt128> w, out Vector512<ExUInt128> data1, out Vector512<ExUInt128> data2, out Vector512<ExUInt128> data3) {
#if EX_APPLY_GENERIC
                return YGroup4Zip_Int128(x, y, z, w, out data1, out data2, out data3);
#else
                var d0 = YGroup4Zip_Int128(x.ExAsUInt64(), y.ExAsUInt64(), z.ExAsUInt64(), w.ExAsUInt64(), out var d1, out var d2, out var d3);
                data1 = d1.ExAsExUInt128();
                data2 = d2.ExAsExUInt128();
                data3 = d3.ExAsExUInt128();
                return d0.ExAsExUInt128();
#endif // EX_APPLY_GENERIC
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip_Int128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<T> YGroup4Zip_Int128<T>(Vector512<T> x, Vector512<T> y, Vector512<T> z, Vector512<T> w, out Vector512<T> data1, out Vector512<T> data2, out Vector512<T> data3) where T : struct {
                Vector512<T> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
                // 0 _x_ x0 x1 x2 x3 _y_ y0 y1 y2 y3 _z_ z0 z1 z2 z3 _w_ w0 w1 w2 w3
                // 1 a_0 x0 z0 x1 z1 a_1 x2 z2 x3 z3 a_2 y0 w0 y1 w1 a_3 y2 w2 y3 w3
                a_0 = YGroup2Zip_Int128(x, z, out a_1);
                a_2 = YGroup2Zip_Int128(y, w, out a_3);
                // 2 b_0 x0 y0 z0 w0 b_1 x1 y1 z1 w1 b_2 x2 y2 z2 w2 b_3 x3 y3 z3 w3
                b_0 = YGroup2Zip_Int128(a_0, a_2, out b_1);
                b_2 = YGroup2Zip_Int128(a_1, a_3, out b_3);
                data1 = b_1;
                data2 = b_2;
                data3 = b_3;
                return b_0;
            }

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
                Vector512<ushort> t0, t1;
                Vector512<uint> r0, r1, r2, r3, d0, d1, d2, d3;
                // Part 0
                Widen(w, out t0, out t1);
                Widen(t0, out r0, out r1);
                Widen(t1, out r2, out r3);
                d0 = ShiftLeft(r0, L);
                d1 = ShiftLeft(r1, L);
                d2 = ShiftLeft(r2, L);
                d3 = ShiftLeft(r3, L);
                // Part 1
                Widen(z, out t0, out t1);
                Widen(t0, out r0, out r1);
                Widen(t1, out r2, out r3);
                d0 = BitwiseOr(d0, r0);
                d1 = BitwiseOr(d1, r1);
                d2 = BitwiseOr(d2, r2);
                d3 = BitwiseOr(d3, r3);
                d0 = ShiftLeft(d0, L);
                d1 = ShiftLeft(d1, L);
                d2 = ShiftLeft(d2, L);
                d3 = ShiftLeft(d3, L);
                // Part 2
                Widen(y, out t0, out t1);
                Widen(t0, out r0, out r1);
                Widen(t1, out r2, out r3);
                d0 = BitwiseOr(d0, r0);
                d1 = BitwiseOr(d1, r1);
                d2 = BitwiseOr(d2, r2);
                d3 = BitwiseOr(d3, r3);
                d0 = ShiftLeft(d0, L);
                d1 = ShiftLeft(d1, L);
                d2 = ShiftLeft(d2, L);
                d3 = ShiftLeft(d3, L);
                // Part 3
                Widen(x, out t0, out t1);
                Widen(t0, out r0, out r1);
                Widen(t1, out r2, out r3);
                d0 = BitwiseOr(d0, r0);
                d1 = BitwiseOr(d1, r1);
                d2 = BitwiseOr(d2, r2);
                d3 = BitwiseOr(d3, r3);
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
                Vector512<uint> t0, t1;
                Vector512<ulong> r0, r1, r2, r3, d0, d1, d2, d3;
                // Part 0
                Widen(w, out t0, out t1);
                Widen(t0, out r0, out r1);
                Widen(t1, out r2, out r3);
                d0 = ShiftLeft(r0, L);
                d1 = ShiftLeft(r1, L);
                d2 = ShiftLeft(r2, L);
                d3 = ShiftLeft(r3, L);
                // Part 1
                Widen(z, out t0, out t1);
                Widen(t0, out r0, out r1);
                Widen(t1, out r2, out r3);
                d0 = BitwiseOr(d0, r0);
                d1 = BitwiseOr(d1, r1);
                d2 = BitwiseOr(d2, r2);
                d3 = BitwiseOr(d3, r3);
                d0 = ShiftLeft(d0, L);
                d1 = ShiftLeft(d1, L);
                d2 = ShiftLeft(d2, L);
                d3 = ShiftLeft(d3, L);
                // Part 2
                Widen(y, out t0, out t1);
                Widen(t0, out r0, out r1);
                Widen(t1, out r2, out r3);
                d0 = BitwiseOr(d0, r0);
                d1 = BitwiseOr(d1, r1);
                d2 = BitwiseOr(d2, r2);
                d3 = BitwiseOr(d3, r3);
                d0 = ShiftLeft(d0, L);
                d1 = ShiftLeft(d1, L);
                d2 = ShiftLeft(d2, L);
                d3 = ShiftLeft(d3, L);
                // Part 3
                Widen(x, out t0, out t1);
                Widen(t0, out r0, out r1);
                Widen(t1, out r2, out r3);
                d0 = BitwiseOr(d0, r0);
                d1 = BitwiseOr(d1, r1);
                d2 = BitwiseOr(d2, r2);
                d3 = BitwiseOr(d3, r3);
                // done.
                data1 = d1.AsUInt16();
                data2 = d2.AsUInt16();
                data3 = d3.AsUInt16();
                return d0.AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, out Vector512{float}, out Vector512{float}, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YGroup4Zip_Unpack(Vector512<float> x, Vector512<float> y, Vector512<float> z, Vector512<float> w, out Vector512<float> data1, out Vector512<float> data2, out Vector512<float> data3) {
                var d0 = YGroup4Zip_Unpack(x.AsUInt32(), y.AsUInt32(), z.AsUInt32(), w.AsUInt32(), out var d1, out var d2, out var d3);
                data1 = d1.AsSingle();
                data2 = d2.AsSingle();
                data3 = d3.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup4Zip_Unpack(Vector512<double> x, Vector512<double> y, Vector512<double> z, Vector512<double> w, out Vector512<double> data1, out Vector512<double> data2, out Vector512<double> data3) {
                var d0 = YGroup4Zip_Unpack(x.AsUInt64(), y.AsUInt64(), z.AsUInt64(), w.AsUInt64(), out var d1, out var d2, out var d3);
                data1 = d1.AsDouble();
                data2 = d2.AsDouble();
                data3 = d3.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YGroup4Zip_Unpack(Vector512<sbyte> x, Vector512<sbyte> y, Vector512<sbyte> z, Vector512<sbyte> w, out Vector512<sbyte> data1, out Vector512<sbyte> data2, out Vector512<sbyte> data3) {
                var d0 = YGroup4Zip_Unpack(x.AsByte(), y.AsByte(), z.AsByte(), w.AsByte(), out var d1, out var d2, out var d3);
                data1 = d1.AsSByte();
                data2 = d2.AsSByte();
                data3 = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YGroup4Zip_Unpack(Vector512<byte> x, Vector512<byte> y, Vector512<byte> z, Vector512<byte> w, out Vector512<byte> data1, out Vector512<byte> data2, out Vector512<byte> data3) {
                Vector512<byte> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
                // Zip layer by 128-bits unpack.
                // 0 b_0 x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 x16 x17 x18 x19 x20 x21 x22 x23 x24 x25 x26 x27 x28 x29 x30 x31 x32 x33 x34 x35 x36 x37 x38 x39 x40 x41 x42 x43 x44 x45 x46 x47 x48 x49 x50 x51 x52 x53 x54 x55 x56 x57 x58 x59 x60 x61 x62 x63 b_1 y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 y16 y17 y18 y19 y20 y21 y22 y23 y24 y25 y26 y27 y28 y29 y30 y31 y32 y33 y34 y35 y36 y37 y38 y39 y40 y41 y42 y43 y44 y45 y46 y47 y48 y49 y50 y51 y52 y53 y54 y55 y56 y57 y58 y59 y60 y61 y62 y63 b_2 z0 z1 z2 z3 z4 z5 z6 z7 z8 z9 z10 z11 z12 z13 z14 z15 z16 z17 z18 z19 z20 z21 z22 z23 z24 z25 z26 z27 z28 z29 z30 z31 z32 z33 z34 z35 z36 z37 z38 z39 z40 z41 z42 z43 z44 z45 z46 z47 z48 z49 z50 z51 z52 z53 z54 z55 z56 z57 z58 z59 z60 z61 z62 z63 b_3 w0 w1 w2 w3 w4 w5 w6 w7 w8 w9 w10 w11 w12 w13 w14 w15 w16 w17 w18 w19 w20 w21 w22 w23 w24 w25 w26 w27 w28 w29 w30 w31 w32 w33 w34 w35 w36 w37 w38 w39 w40 w41 w42 w43 w44 w45 w46 w47 w48 w49 w50 w51 w52 w53 w54 w55 w56 w57 w58 w59 w60 w61 w62 w63
                // 1 a_0 x0 z0 x1 z1 x2 z2 x3 z3 x4 z4 x5 z5 x6 z6 x7 z7 x16 z16 x17 z17 x18 z18 x19 z19 x20 z20 x21 z21 x22 z22 x23 z23 x32 z32 x33 z33 x34 z34 x35 z35 x36 z36 x37 z37 x38 z38 x39 z39 x48 z48 x49 z49 x50 z50 x51 z51 x52 z52 x53 z53 x54 z54 x55 z55 a_1 x8 z8 x9 z9 x10 z10 x11 z11 x12 z12 x13 z13 x14 z14 x15 z15 x24 z24 x25 z25 x26 z26 x27 z27 x28 z28 x29 z29 x30 z30 x31 z31 x40 z40 x41 z41 x42 z42 x43 z43 x44 z44 x45 z45 x46 z46 x47 z47 x56 z56 x57 z57 x58 z58 x59 z59 x60 z60 x61 z61 x62 z62 x63 z63 a_2 y0 w0 y1 w1 y2 w2 y3 w3 y4 w4 y5 w5 y6 w6 y7 w7 y16 w16 y17 w17 y18 w18 y19 w19 y20 w20 y21 w21 y22 w22 y23 w23 y32 w32 y33 w33 y34 w34 y35 w35 y36 w36 y37 w37 y38 w38 y39 w39 y48 w48 y49 w49 y50 w50 y51 w51 y52 w52 y53 w53 y54 w54 y55 w55 a_3 y8 w8 y9 w9 y10 w10 y11 w11 y12 w12 y13 w13 y14 w14 y15 w15 y24 w24 y25 w25 y26 w26 y27 w27 y28 w28 y29 w29 y30 w30 y31 w31 y40 w40 y41 w41 y42 w42 y43 w43 y44 w44 y45 w45 y46 w46 y47 w47 y56 w56 y57 w57 y58 w58 y59 w59 y60 w60 y61 w61 y62 w62 y63 w63
                a_0 = Avx512BW.UnpackLow(x, z);
                a_1 = Avx512BW.UnpackHigh(x, z);
                a_2 = Avx512BW.UnpackLow(y, w);
                a_3 = Avx512BW.UnpackHigh(y, w);
                // 2 b_0 x0 y0 z0 w0 x1 y1 z1 w1 x2 y2 z2 w2 x3 y3 z3 w3 x16 y16 z16 w16 x17 y17 z17 w17 x18 y18 z18 w18 x19 y19 z19 w19 x32 y32 z32 w32 x33 y33 z33 w33 x34 y34 z34 w34 x35 y35 z35 w35 x48 y48 z48 w48 x49 y49 z49 w49 x50 y50 z50 w50 x51 y51 z51 w51 b_1 x4 y4 z4 w4 x5 y5 z5 w5 x6 y6 z6 w6 x7 y7 z7 w7 x20 y20 z20 w20 x21 y21 z21 w21 x22 y22 z22 w22 x23 y23 z23 w23 x36 y36 z36 w36 x37 y37 z37 w37 x38 y38 z38 w38 x39 y39 z39 w39 x52 y52 z52 w52 x53 y53 z53 w53 x54 y54 z54 w54 x55 y55 z55 w55 b_2 x8 y8 z8 w8 x9 y9 z9 w9 x10 y10 z10 w10 x11 y11 z11 w11 x24 y24 z24 w24 x25 y25 z25 w25 x26 y26 z26 w26 x27 y27 z27 w27 x40 y40 z40 w40 x41 y41 z41 w41 x42 y42 z42 w42 x43 y43 z43 w43 x56 y56 z56 w56 x57 y57 z57 w57 x58 y58 z58 w58 x59 y59 z59 w59 b_3 x12 y12 z12 w12 x13 y13 z13 w13 x14 y14 z14 w14 x15 y15 z15 w15 x28 y28 z28 w28 x29 y29 z29 w29 x30 y30 z30 w30 x31 y31 z31 w31 x44 y44 z44 w44 x45 y45 z45 w45 x46 y46 z46 w46 x47 y47 z47 w47 x60 y60 z60 w60 x61 y61 z61 w61 x62 y62 z62 w62 x63 y63 z63 w63
                b_0 = Avx512BW.UnpackLow(a_0, a_2);
                b_1 = Avx512BW.UnpackHigh(a_0, a_2);
                b_2 = Avx512BW.UnpackLow(a_1, a_3);
                b_3 = Avx512BW.UnpackHigh(a_1, a_3);
                // Rearrange.
                //a_0 = YGroup2Unzip_Int128(b_0, b_1, out a_2);
                //a_1 = YGroup2Unzip_Int128(b_2, b_3, out a_3);
                a_0 = YGroup4Zip_Int128(b_0, b_1, b_2, b_3, out a_1, out a_2, out a_3);
                data1 = a_1;
                data2 = a_2;
                data3 = a_3;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YGroup4Zip_Unpack(Vector512<short> x, Vector512<short> y, Vector512<short> z, Vector512<short> w, out Vector512<short> data1, out Vector512<short> data2, out Vector512<short> data3) {
                var d0 = YGroup4Zip_Unpack(x.AsUInt16(), y.AsUInt16(), z.AsUInt16(), w.AsUInt16(), out var d1, out var d2, out var d3);
                data1 = d1.AsInt16();
                data2 = d2.AsInt16();
                data3 = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YGroup4Zip_Unpack(Vector512<ushort> x, Vector512<ushort> y, Vector512<ushort> z, Vector512<ushort> w, out Vector512<ushort> data1, out Vector512<ushort> data2, out Vector512<ushort> data3) {
                Vector512<ushort> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
                // Zip layer by 128-bits unpack.
                // 0 _x_ x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 x16 x17 x18 x19 x20 x21 x22 x23 x24 x25 x26 x27 x28 x29 x30 x31 _y_ y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 y16 y17 y18 y19 y20 y21 y22 y23 y24 y25 y26 y27 y28 y29 y30 y31 _z_ z0 z1 z2 z3 z4 z5 z6 z7 z8 z9 z10 z11 z12 z13 z14 z15 z16 z17 z18 z19 z20 z21 z22 z23 z24 z25 z26 z27 z28 z29 z30 z31 _w_ w0 w1 w2 w3 w4 w5 w6 w7 w8 w9 w10 w11 w12 w13 w14 w15 w16 w17 w18 w19 w20 w21 w22 w23 w24 w25 w26 w27 w28 w29 w30 w31
                // 1 b_0 x0 z0 x1 z1 x2 z2 x3 z3 x8 z8 x9 z9 x10 z10 x11 z11 x16 z16 x17 z17 x18 z18 x19 z19 x24 z24 x25 z25 x26 z26 x27 z27 b_1 x4 z4 x5 z5 x6 z6 x7 z7 x12 z12 x13 z13 x14 z14 x15 z15 x20 z20 x21 z21 x22 z22 x23 z23 x28 z28 x29 z29 x30 z30 x31 z31 b_2 y0 w0 y1 w1 y2 w2 y3 w3 y8 w8 y9 w9 y10 w10 y11 w11 y16 w16 y17 w17 y18 w18 y19 w19 y24 w24 y25 w25 y26 w26 y27 w27 b_3 y4 w4 y5 w5 y6 w6 y7 w7 y12 w12 y13 w13 y14 w14 y15 w15 y20 w20 y21 w21 y22 w22 y23 w23 y28 w28 y29 w29 y30 w30 y31 w31
                a_0 = Avx512BW.UnpackLow(x, z);
                a_1 = Avx512BW.UnpackHigh(x, z);
                a_2 = Avx512BW.UnpackLow(y, w);
                a_3 = Avx512BW.UnpackHigh(y, w);
                // 2 a_0 x0 y0 z0 w0 x1 y1 z1 w1 x8 y8 z8 w8 x9 y9 z9 w9 x16 y16 z16 w16 x17 y17 z17 w17 x24 y24 z24 w24 x25 y25 z25 w25 a_1 x2 y2 z2 w2 x3 y3 z3 w3 x10 y10 z10 w10 x11 y11 z11 w11 x18 y18 z18 w18 x19 y19 z19 w19 x26 y26 z26 w26 x27 y27 z27 w27 a_2 x4 y4 z4 w4 x5 y5 z5 w5 x12 y12 z12 w12 x13 y13 z13 w13 x20 y20 z20 w20 x21 y21 z21 w21 x28 y28 z28 w28 x29 y29 z29 w29 a_3 x6 y6 z6 w6 x7 y7 z7 w7 x14 y14 z14 w14 x15 y15 z15 w15 x22 y22 z22 w22 x23 y23 z23 w23 x30 y30 z30 w30 x31 y31 z31 w31
                b_0 = Avx512BW.UnpackLow(a_0, a_2);
                b_1 = Avx512BW.UnpackHigh(a_0, a_2);
                b_2 = Avx512BW.UnpackLow(a_1, a_3);
                b_3 = Avx512BW.UnpackHigh(a_1, a_3);
                // Rearrange.
                a_0 = YGroup4Zip_Int128(b_0, b_1, b_2, b_3, out a_1, out a_2, out a_3);
                data1 = a_1;
                data2 = a_2;
                data3 = a_3;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YGroup4Zip_Unpack(Vector512<int> x, Vector512<int> y, Vector512<int> z, Vector512<int> w, out Vector512<int> data1, out Vector512<int> data2, out Vector512<int> data3) {
                var d0 = YGroup4Zip_Unpack(x.AsUInt32(), y.AsUInt32(), z.AsUInt32(), w.AsUInt32(), out var d1, out var d2, out var d3);
                data1 = d1.AsInt32();
                data2 = d2.AsInt32();
                data3 = d3.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YGroup4Zip_Unpack(Vector512<uint> x, Vector512<uint> y, Vector512<uint> z, Vector512<uint> w, out Vector512<uint> data1, out Vector512<uint> data2, out Vector512<uint> data3) {
                Vector512<uint> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
                // Zip layer by 128-bits unpack.
                // 0 _x_ x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 _y_ y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 _z_ z0 z1 z2 z3 z4 z5 z6 z7 z8 z9 z10 z11 z12 z13 z14 z15 _w_ w0 w1 w2 w3 w4 w5 w6 w7 w8 w9 w10 w11 w12 w13 w14 w15
                // 1 a_0 x0 z0 x1 z1 x4 z4 x5 z5 x8 z8 x9 z9 x12 z12 x13 z13 a_1 x2 z2 x3 z3 x6 z6 x7 z7 x10 z10 x11 z11 x14 z14 x15 z15 a_2 y0 w0 y1 w1 y4 w4 y5 w5 y8 w8 y9 w9 y12 w12 y13 w13 a_3 y2 w2 y3 w3 y6 w6 y7 w7 y10 w10 y11 w11 y14 w14 y15 w15
                a_0 = Avx512F.UnpackLow(x, z);
                a_1 = Avx512F.UnpackHigh(x, z);
                a_2 = Avx512F.UnpackLow(y, w);
                a_3 = Avx512F.UnpackHigh(y, w);
                // 2 b_0 x0 y0 z0 w0 x4 y4 z4 w4 x8 y8 z8 w8 x12 y12 z12 w12 b_1 x1 y1 z1 w1 x5 y5 z5 w5 x9 y9 z9 w9 x13 y13 z13 w13 b_2 x2 y2 z2 w2 x6 y6 z6 w6 x10 y10 z10 w10 x14 y14 z14 w14 b_3 x3 y3 z3 w3 x7 y7 z7 w7 x11 y11 z11 w11 x15 y15 z15 w15
                b_0 = Avx512F.UnpackLow(a_0, a_2);
                b_1 = Avx512F.UnpackHigh(a_0, a_2);
                b_2 = Avx512F.UnpackLow(a_1, a_3);
                b_3 = Avx512F.UnpackHigh(a_1, a_3);
                // Rearrange.
                a_0 = YGroup4Zip_Int128(b_0, b_1, b_2, b_3, out a_1, out a_2, out a_3);
                data1 = a_1;
                data2 = a_2;
                data3 = a_3;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup4Zip_Unpack(Vector512<long> x, Vector512<long> y, Vector512<long> z, Vector512<long> w, out Vector512<long> data1, out Vector512<long> data2, out Vector512<long> data3) {
                var d0 = YGroup4Zip_Unpack(x.AsUInt64(), y.AsUInt64(), z.AsUInt64(), w.AsUInt64(), out var d1, out var d2, out var d3);
                data1 = d1.AsInt64();
                data2 = d2.AsInt64();
                data3 = d3.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup4Zip_Unpack(Vector512<ulong> x, Vector512<ulong> y, Vector512<ulong> z, Vector512<ulong> w, out Vector512<ulong> data1, out Vector512<ulong> data2, out Vector512<ulong> data3) {
                Vector512<ulong> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
                // Zip layer by 128-bits unpack.
                // 0 a_0 x0 x1 x2 x3 x4 x5 x6 x7 a_1 y0 y1 y2 y3 y4 y5 y6 y7 a_2 z0 z1 z2 z3 z4 z5 z6 z7 a_3 w0 w1 w2 w3 w4 w5 w6 w7
                // 1 b_0 x0 z0 x2 z2 x4 z4 x6 z6 b_1 x1 z1 x3 z3 x5 z5 x7 z7 b_2 y0 w0 y2 w2 y4 w4 y6 w6 b_3 y1 w1 y3 w3 y5 w5 y7 w7
                a_0 = Avx512F.UnpackLow(x, z);
                a_1 = Avx512F.UnpackHigh(x, z);
                a_2 = Avx512F.UnpackLow(y, w);
                a_3 = Avx512F.UnpackHigh(y, w);
                // 2 a_0 x0 y0 x2 y2 x4 y4 x6 y6 a_1 z0 w0 z2 w2 z4 w4 z6 w6 a_2 x1 y1 x3 y3 x5 y5 x7 y7 a_3 z1 w1 z3 w3 z5 w5 z7 w7
                b_0 = Avx512F.UnpackLow(a_0, a_2);
                b_1 = Avx512F.UnpackHigh(a_0, a_2);
                b_2 = Avx512F.UnpackLow(a_1, a_3);
                b_3 = Avx512F.UnpackHigh(a_1, a_3);
                // Rearrange.
                a_0 = YGroup4Zip_Int128(b_0, b_1, b_2, b_3, out a_1, out a_2, out a_3);
                data1 = a_1;
                data2 = a_2;
                data3 = a_3;
                return a_0;
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

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, out Vector512{double}, out Vector512{double}, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YGroup4Zip_Zip(Vector512<double> x, Vector512<double> y, Vector512<double> z, Vector512<double> w, out Vector512<double> data1, out Vector512<double> data2, out Vector512<double> data3) {
                var d0 = YGroup4Zip_Zip(x.AsUInt64(), y.AsUInt64(), z.AsUInt64(), w.AsUInt64(), out var d1, out var d2, out var d3);
                data1 = d1.AsDouble();
                data2 = d2.AsDouble();
                data3 = d3.AsDouble();
                return d0.AsDouble();
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

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YGroup4Zip_Zip(Vector512<long> x, Vector512<long> y, Vector512<long> z, Vector512<long> w, out Vector512<long> data1, out Vector512<long> data2, out Vector512<long> data3) {
                var d0 = YGroup4Zip_Zip(x.AsUInt64(), y.AsUInt64(), z.AsUInt64(), w.AsUInt64(), out var d1, out var d2, out var d3);
                data1 = d1.AsInt64();
                data2 = d2.AsInt64();
                data3 = d3.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YGroup4Zip_Zip(Vector512<ulong> x, Vector512<ulong> y, Vector512<ulong> z, Vector512<ulong> w, out Vector512<ulong> data1, out Vector512<ulong> data2, out Vector512<ulong> data3) {
                Vector512<ulong> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
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

#endif // NET8_0_OR_GREATER
        }
    }
}
