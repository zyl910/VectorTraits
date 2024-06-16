using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
#endif
using Zyl.VectorTraits.Collections;
using Zyl.VectorTraits.Impl.Util;

namespace Zyl.VectorTraits.Impl.AVector256 {
    using SuperStatics = WVectorTraits256Base.Statics;

    partial class WVectorTraits256Avx2 {

        partial class Statics {

#if NETCOREAPP3_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2Unzip_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{float}, Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2Unzip(Vector256<float> data0, Vector256<float> data1, out Vector256<float> y) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2Unzip_Permute(data0, data1, out y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2Unzip_Unpack(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{double}, Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2Unzip(Vector256<double> data0, Vector256<double> data1, out Vector256<double> y) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2Unzip_Permute(data0, data1, out y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2Unzip_Unpack(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2Unzip(Vector256<sbyte> data0, Vector256<sbyte> data1, out Vector256<sbyte> y) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    return YGroup2Unzip_Permute(data0, data1, out y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2Unzip_Narrow(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{byte}, Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2Unzip(Vector256<byte> data0, Vector256<byte> data1, out Vector256<byte> y) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    return YGroup2Unzip_Permute(data0, data1, out y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2Unzip_Narrow(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{short}, Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2Unzip(Vector256<short> data0, Vector256<short> data1, out Vector256<short> y) {
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    return YGroup2Unzip_Permute(data0, data1, out y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2Unzip_Narrow(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{ushort}, Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2Unzip(Vector256<ushort> data0, Vector256<ushort> data1, out Vector256<ushort> y) {
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    return YGroup2Unzip_Permute(data0, data1, out y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2Unzip_Narrow(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{int}, Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2Unzip(Vector256<int> data0, Vector256<int> data1, out Vector256<int> y) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2Unzip_Permute(data0, data1, out y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2Unzip_Unpack(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{uint}, Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2Unzip(Vector256<uint> data0, Vector256<uint> data1, out Vector256<uint> y) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2Unzip_Permute(data0, data1, out y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2Unzip_Unpack(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{long}, Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup2Unzip(Vector256<long> data0, Vector256<long> data1, out Vector256<long> y) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2Unzip_Permute(data0, data1, out y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2Unzip_Unpack(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{ulong}, Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup2Unzip(Vector256<ulong> data0, Vector256<ulong> data1, out Vector256<ulong> y) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2Unzip_Permute(data0, data1, out y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2Unzip_Unpack(data0, data1, out y);
            }

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
                rt0 = Narrow(temp0, temp1);
                temp0 = Avx2.ShiftRightLogical(temp0, L);
                temp1 = Avx2.ShiftRightLogical(temp1, L);
                rt1 = Narrow(temp0, temp1);
                y = rt1;
                return rt0;
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
                // Format: Code; //Latency, Throughput(references IceLake)
                rt0 = Narrow(temp0, temp1); // 8, 2.66
                temp0 = Avx2.ShiftRightLogical(temp0, L); // 1,0.5
                temp1 = Avx2.ShiftRightLogical(temp1, L); // 1,0.5
                rt1 = Narrow(temp0, temp1); // 8, 2.66
                y = rt1;
                return rt0; //total latency: 18, total throughput CPI: 6.33
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
                rt0 = Narrow(temp0, temp1);
                temp0 = Avx2.ShiftRightLogical(temp0, L);
                temp1 = Avx2.ShiftRightLogical(temp1, L);
                rt1 = Narrow(temp0, temp1);
                y = rt1;
                return rt0;
            }

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{float}, Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2Unzip_Permute(Vector256<float> data0, Vector256<float> data1, out Vector256<float> rt1) {
                VectorMessageFormats.ThrowForUnsupported(Avx512F.VL.IsSupported, "Avx512F, Avx512VL");
                var rt0 = Avx512F.VL.PermuteVar8x32x2(data0, Vector256Constants.YGroup2Unzip_UInt32_ShuffleX2_Index0.AsInt32(), data1);
                rt1 = Avx512F.VL.PermuteVar8x32x2(data0, Vector256Constants.YGroup2Unzip_UInt32_ShuffleX2_Index1.AsInt32(), data1);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{double}, Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2Unzip_Permute(Vector256<double> data0, Vector256<double> data1, out Vector256<double> rt1) {
                VectorMessageFormats.ThrowForUnsupported(Avx512F.VL.IsSupported, "Avx512F, Avx512VL");
                var rt0 = Avx512F.VL.PermuteVar4x64x2(data0, Vector256Constants.YGroup2Unzip_UInt64_ShuffleX2_Index0.AsInt64(), data1);
                rt1 = Avx512F.VL.PermuteVar4x64x2(data0, Vector256Constants.YGroup2Unzip_UInt64_ShuffleX2_Index1.AsInt64(), data1);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2Unzip_Permute(Vector256<sbyte> data0, Vector256<sbyte> data1, out Vector256<sbyte> rt1) {
                var d0 = YGroup2Unzip_Permute(data0.AsByte(), data1.AsByte(), out var d1);
                rt1 = d1.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{byte}, Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2Unzip_Permute(Vector256<byte> data0, Vector256<byte> data1, out Vector256<byte> rt1) {
                VectorMessageFormats.ThrowForUnsupported(Avx512Vbmi.VL.IsSupported, "Avx512Vbmi, Avx512VL");
                var rt0 = Avx512Vbmi.VL.PermuteVar32x8x2(data0, Vector256Constants.YGroup2Unzip_Byte_ShuffleX2_Index0, data1);
                rt1 = Avx512Vbmi.VL.PermuteVar32x8x2(data0, Vector256Constants.YGroup2Unzip_Byte_ShuffleX2_Index1, data1);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{short}, Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2Unzip_Permute(Vector256<short> data0, Vector256<short> data1, out Vector256<short> rt1) {
                var d0 = YGroup2Unzip_Permute(data0.AsUInt16(), data1.AsUInt16(), out var d1);
                rt1 = d1.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{ushort}, Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2Unzip_Permute(Vector256<ushort> data0, Vector256<ushort> data1, out Vector256<ushort> rt1) {
                VectorMessageFormats.ThrowForUnsupported(Avx512BW.VL.IsSupported, "Avx512BW, Avx512VL");
                var rt0 = Avx512BW.VL.PermuteVar16x16x2(data0, Vector256Constants.YGroup2Unzip_UInt16_ShuffleX2_Index0, data1);
                rt1 = Avx512BW.VL.PermuteVar16x16x2(data0, Vector256Constants.YGroup2Unzip_UInt16_ShuffleX2_Index1, data1);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{int}, Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2Unzip_Permute(Vector256<int> data0, Vector256<int> data1, out Vector256<int> rt1) {
                var d0 = YGroup2Unzip_Permute(data0.AsUInt32(), data1.AsUInt32(), out var d1);
                rt1 = d1.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{uint}, Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2Unzip_Permute(Vector256<uint> data0, Vector256<uint> data1, out Vector256<uint> rt1) {
                VectorMessageFormats.ThrowForUnsupported(Avx512F.VL.IsSupported, "Avx512F, Avx512VL");
                var rt0 = Avx512F.VL.PermuteVar8x32x2(data0, Vector256Constants.YGroup2Unzip_UInt32_ShuffleX2_Index0, data1);
                rt1 = Avx512F.VL.PermuteVar8x32x2(data0, Vector256Constants.YGroup2Unzip_UInt32_ShuffleX2_Index1, data1);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{long}, Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup2Unzip_Permute(Vector256<long> data0, Vector256<long> data1, out Vector256<long> rt1) {
                var d0 = YGroup2Unzip_Permute(data0.AsUInt64(), data1.AsUInt64(), out var d1);
                rt1 = d1.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{ulong}, Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup2Unzip_Permute(Vector256<ulong> data0, Vector256<ulong> data1, out Vector256<ulong> rt1) {
                VectorMessageFormats.ThrowForUnsupported(Avx512F.VL.IsSupported, "Avx512F, Avx512VL");
                var rt0 = Avx512F.VL.PermuteVar4x64x2(data0, Vector256Constants.YGroup2Unzip_UInt64_ShuffleX2_Index0, data1);
                rt1 = Avx512F.VL.PermuteVar4x64x2(data0, Vector256Constants.YGroup2Unzip_UInt64_ShuffleX2_Index1, data1);
                return rt0;
            }

#endif // NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{float}, Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2Unzip_Unpack(Vector256<float> data0, Vector256<float> data1, out Vector256<float> y) {
                const byte ctl = (byte)ShuffleControlG4.XZYW;
                Vector256<float> a0, a1, b0, b1;
                a0 = Avx.UnpackLow(data0, data1);
                a1 = Avx.UnpackHigh(data0, data1);
                b0 = Avx.UnpackLow(a0, a1);
                b1 = Avx.UnpackHigh(a0, a1);
                b0 = Avx2.Permute4x64(b0.AsUInt64(), ctl).AsSingle();
                b1 = Avx2.Permute4x64(b1.AsUInt64(), ctl).AsSingle();
                y = b1;
                return b0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{double}, Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2Unzip_Unpack(Vector256<double> data0, Vector256<double> data1, out Vector256<double> y) {
                const byte ctl = (byte)ShuffleControlG4.XZYW;
                Vector256<double> a0, a1;
                a0 = Avx.UnpackLow(data0, data1);
                a1 = Avx.UnpackHigh(data0, data1);
                a0 = Avx2.Permute4x64(a0, ctl);
                a1 = Avx2.Permute4x64(a1, ctl);
                y = a1;
                return a0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2Unzip_Unpack(Vector256<sbyte> data0, Vector256<sbyte> data1, out Vector256<sbyte> y) {
                var d0 = YGroup2Unzip_Unpack(data0.AsByte(), data1.AsByte(), out var d1);
                y = d1.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{byte}, Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2Unzip_Unpack(Vector256<byte> data0, Vector256<byte> data1, out Vector256<byte> y) {
                const byte ctl = (byte)ShuffleControlG4.XZYW;
                Vector256<byte> a0, a1, b0, b1;
                a0 = Avx2.UnpackLow(data0, data1);
                a1 = Avx2.UnpackHigh(data0, data1);
                b0 = Avx2.UnpackLow(a0, a1);
                b1 = Avx2.UnpackHigh(a0, a1);
                a0 = Avx2.UnpackLow(b0, b1);
                a1 = Avx2.UnpackHigh(b0, b1);
                b0 = Avx2.UnpackLow(a0, a1);
                b1 = Avx2.UnpackHigh(a0, a1);
                b0 = Avx2.Permute4x64(b0.AsUInt64(), ctl).AsByte();
                b1 = Avx2.Permute4x64(b1.AsUInt64(), ctl).AsByte();
                y = b1;
                return b0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{short}, Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2Unzip_Unpack(Vector256<short> data0, Vector256<short> data1, out Vector256<short> y) {
                var d0 = YGroup2Unzip_Unpack(data0.AsUInt16(), data1.AsUInt16(), out var d1);
                y = d1.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{ushort}, Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2Unzip_Unpack(Vector256<ushort> data0, Vector256<ushort> data1, out Vector256<ushort> y) {
                const byte ctl = (byte)ShuffleControlG4.XZYW;
                Vector256<ushort> a0, a1, b0, b1;
                // Format: Code; //Latency, Throughput(references IceLake)
                a0 = Avx2.UnpackLow(data0, data1);  // 1,0.5
                a1 = Avx2.UnpackHigh(data0, data1); // 1,0.5
                b0 = Avx2.UnpackLow(a0, a1);  // 1,0.5
                b1 = Avx2.UnpackHigh(a0, a1); // 1,0.5
                a0 = Avx2.UnpackLow(b0, b1);  // 1,0.5
                a1 = Avx2.UnpackHigh(b0, b1); // 1,0.5
                a0 = Avx2.Permute4x64(a0.AsUInt64(), ctl).AsUInt16(); // 3,1
                a1 = Avx2.Permute4x64(a1.AsUInt64(), ctl).AsUInt16(); // 3,1
                y = a1;
                return a0; //total latency: 12, total throughput CPI: 5
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{int}, Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2Unzip_Unpack(Vector256<int> data0, Vector256<int> data1, out Vector256<int> y) {
                var d0 = YGroup2Unzip_Unpack(data0.AsUInt32(), data1.AsUInt32(), out var d1);
                y = d1.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{uint}, Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2Unzip_Unpack(Vector256<uint> data0, Vector256<uint> data1, out Vector256<uint> y) {
                const byte ctl = (byte)ShuffleControlG4.XZYW;
                Vector256<uint> a0, a1, b0, b1;
                a0 = Avx2.UnpackLow(data0, data1);
                a1 = Avx2.UnpackHigh(data0, data1);
                b0 = Avx2.UnpackLow(a0, a1);
                b1 = Avx2.UnpackHigh(a0, a1);
                b0 = Avx2.Permute4x64(b0.AsUInt64(), ctl).AsUInt32();
                b1 = Avx2.Permute4x64(b1.AsUInt64(), ctl).AsUInt32();
                y = b1;
                return b0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{long}, Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup2Unzip_Unpack(Vector256<long> data0, Vector256<long> data1, out Vector256<long> y) {
                var d0 = YGroup2Unzip_Unpack(data0.AsUInt64(), data1.AsUInt64(), out var d1);
                y = d1.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{ulong}, Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup2Unzip_Unpack(Vector256<ulong> data0, Vector256<ulong> data1, out Vector256<ulong> y) {
                const byte ctl = (byte)ShuffleControlG4.XZYW;
                Vector256<ulong> a0, a1;
                a0 = Avx2.UnpackLow(data0, data1);
                a1 = Avx2.UnpackHigh(data0, data1);
                a0 = Avx2.Permute4x64(a0, ctl);
                a1 = Avx2.Permute4x64(a1, ctl);
                y = a1;
                return a0;
            }


            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2UnzipEven_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2UnzipEven(Vector256<float> data0, Vector256<float> data1) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2UnzipEven_Permute(data0, data1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2UnzipEven_Unpack(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2UnzipEven(Vector256<double> data0, Vector256<double> data1) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2UnzipEven_Permute(data0, data1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2UnzipEven_Unpack(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2UnzipEven(Vector256<sbyte> data0, Vector256<sbyte> data1) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    return YGroup2UnzipEven_Permute(data0, data1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2UnzipEven_Narrow(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2UnzipEven(Vector256<byte> data0, Vector256<byte> data1) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    return YGroup2UnzipEven_Permute(data0, data1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2UnzipEven_Narrow(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2UnzipEven(Vector256<short> data0, Vector256<short> data1) {
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    return YGroup2UnzipEven_Permute(data0, data1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2UnzipEven_Narrow(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2UnzipEven(Vector256<ushort> data0, Vector256<ushort> data1) {
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    return YGroup2UnzipEven_Permute(data0, data1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2UnzipEven_Narrow(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2UnzipEven(Vector256<int> data0, Vector256<int> data1) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2UnzipEven_Permute(data0, data1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2UnzipEven_Unpack(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2UnzipEven(Vector256<uint> data0, Vector256<uint> data1) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2UnzipEven_Permute(data0, data1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2UnzipEven_Unpack(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup2UnzipEven(Vector256<long> data0, Vector256<long> data1) {
                return YGroup2UnzipEven_Unpack(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup2UnzipEven(Vector256<ulong> data0, Vector256<ulong> data1) {
                return YGroup2UnzipEven_Unpack(data0, data1);
            }

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
                Vector256<byte> rt0;
                Vector256<ushort> temp0 = data0.AsUInt16();
                Vector256<ushort> temp1 = data1.AsUInt16();
                rt0 = Narrow(temp0, temp1);
                return rt0;
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
                Vector256<ushort> rt0;
                Vector256<uint> temp0 = data0.AsUInt32();
                Vector256<uint> temp1 = data1.AsUInt32();
                rt0 = Narrow(temp0, temp1); // 8, 2.66
                return rt0;
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
                Vector256<uint> rt0;
                Vector256<ulong> temp0 = data0.AsUInt64();
                Vector256<ulong> temp1 = data1.AsUInt64();
                rt0 = Narrow(temp0, temp1);
                return rt0;
            }

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2UnzipEven_Permute(Vector256<float> data0, Vector256<float> data1) {
                VectorMessageFormats.ThrowForUnsupported(Avx512F.VL.IsSupported, "Avx512F, Avx512VL");
                return Avx512F.VL.PermuteVar8x32x2(data0, Vector256Constants.YGroup2Unzip_UInt32_ShuffleX2_Index0.AsInt32(), data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2UnzipEven_Permute(Vector256<double> data0, Vector256<double> data1) {
                VectorMessageFormats.ThrowForUnsupported(Avx512F.VL.IsSupported, "Avx512F, Avx512VL");
                return Avx512F.VL.PermuteVar4x64x2(data0, Vector256Constants.YGroup2Unzip_UInt64_ShuffleX2_Index0.AsInt64(), data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2UnzipEven_Permute(Vector256<sbyte> data0, Vector256<sbyte> data1) {
                return YGroup2UnzipEven_Permute(data0.AsByte(), data1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2UnzipEven_Permute(Vector256<byte> data0, Vector256<byte> data1) {
                VectorMessageFormats.ThrowForUnsupported(Avx512Vbmi.VL.IsSupported, "Avx512Vbmi, Avx512VL");
                return Avx512Vbmi.VL.PermuteVar32x8x2(data0, Vector256Constants.YGroup2Unzip_Byte_ShuffleX2_Index0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2UnzipEven_Permute(Vector256<short> data0, Vector256<short> data1) {
                return YGroup2UnzipEven_Permute(data0.AsUInt16(), data1.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2UnzipEven_Permute(Vector256<ushort> data0, Vector256<ushort> data1) {
                VectorMessageFormats.ThrowForUnsupported(Avx512BW.VL.IsSupported, "Avx512BW, Avx512VL");
                return Avx512BW.VL.PermuteVar16x16x2(data0, Vector256Constants.YGroup2Unzip_UInt16_ShuffleX2_Index0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2UnzipEven_Permute(Vector256<int> data0, Vector256<int> data1) {
                return YGroup2UnzipEven_Permute(data0.AsUInt32(), data1.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2UnzipEven_Permute(Vector256<uint> data0, Vector256<uint> data1) {
                VectorMessageFormats.ThrowForUnsupported(Avx512F.VL.IsSupported, "Avx512F, Avx512VL");
                return Avx512F.VL.PermuteVar8x32x2(data0, Vector256Constants.YGroup2Unzip_UInt32_ShuffleX2_Index0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup2UnzipEven_Permute(Vector256<long> data0, Vector256<long> data1) {
                return YGroup2UnzipEven_Permute(data0.AsUInt64(), data1.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup2UnzipEven_Permute(Vector256<ulong> data0, Vector256<ulong> data1) {
                VectorMessageFormats.ThrowForUnsupported(Avx512F.VL.IsSupported, "Avx512F, Avx512VL");
                return Avx512F.VL.PermuteVar4x64x2(data0, Vector256Constants.YGroup2Unzip_UInt64_ShuffleX2_Index0, data1);
            }

#endif // NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2UnzipEven_Unpack(Vector256<float> data0, Vector256<float> data1) {
                const byte ctl = (byte)ShuffleControlG4.XZYW;
                Vector256<float> a0, a1, b0;
                a0 = Avx.UnpackLow(data0, data1);
                a1 = Avx.UnpackHigh(data0, data1);
                b0 = Avx.UnpackLow(a0, a1);
                b0 = Avx2.Permute4x64(b0.AsUInt64(), ctl).AsSingle();
                return b0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2UnzipEven_Unpack(Vector256<double> data0, Vector256<double> data1) {
                const byte ctl = (byte)ShuffleControlG4.XZYW;
                Vector256<double> a0;
                a0 = Avx.UnpackLow(data0, data1);
                a0 = Avx2.Permute4x64(a0, ctl);
                return a0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2UnzipEven_Unpack(Vector256<sbyte> data0, Vector256<sbyte> data1) {
                return YGroup2UnzipEven_Unpack(data0.AsByte(), data1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2UnzipEven_Unpack(Vector256<byte> data0, Vector256<byte> data1) {
                const byte ctl = (byte)ShuffleControlG4.XZYW;
                Vector256<byte> a0, a1, b0, b1;
                a0 = Avx2.UnpackLow(data0, data1);
                a1 = Avx2.UnpackHigh(data0, data1);
                b0 = Avx2.UnpackLow(a0, a1);
                b1 = Avx2.UnpackHigh(a0, a1);
                a0 = Avx2.UnpackLow(b0, b1);
                a1 = Avx2.UnpackHigh(b0, b1);
                b0 = Avx2.UnpackLow(a0, a1);
                b0 = Avx2.Permute4x64(b0.AsUInt64(), ctl).AsByte();
                return b0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2UnzipEven_Unpack(Vector256<short> data0, Vector256<short> data1) {
                return YGroup2UnzipEven_Unpack(data0.AsUInt16(), data1.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2UnzipEven_Unpack(Vector256<ushort> data0, Vector256<ushort> data1) {
                const byte ctl = (byte)ShuffleControlG4.XZYW;
                Vector256<ushort> a0, a1, b0, b1;
                // Format: Code; //Latency, Throughput(references IceLake)
                a0 = Avx2.UnpackLow(data0, data1);  // 1,0.5
                a1 = Avx2.UnpackHigh(data0, data1); // 1,0.5
                b0 = Avx2.UnpackLow(a0, a1);  // 1,0.5
                b1 = Avx2.UnpackHigh(a0, a1); // 1,0.5
                a0 = Avx2.UnpackLow(b0, b1);  // 1,0.5
                a0 = Avx2.Permute4x64(a0.AsUInt64(), ctl).AsUInt16(); // 3,1
                return a0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2UnzipEven_Unpack(Vector256<int> data0, Vector256<int> data1) {
                return YGroup2UnzipEven_Unpack(data0.AsUInt32(), data1.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2UnzipEven_Unpack(Vector256<uint> data0, Vector256<uint> data1) {
                const byte ctl = (byte)ShuffleControlG4.XZYW;
                Vector256<uint> a0, a1, b0;
                a0 = Avx2.UnpackLow(data0, data1);
                a1 = Avx2.UnpackHigh(data0, data1);
                b0 = Avx2.UnpackLow(a0, a1);
                b0 = Avx2.Permute4x64(b0.AsUInt64(), ctl).AsUInt32();
                return b0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup2UnzipEven_Unpack(Vector256<long> data0, Vector256<long> data1) {
                return YGroup2UnzipEven_Unpack(data0.AsUInt64(), data1.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup2UnzipEven_Unpack(Vector256<ulong> data0, Vector256<ulong> data1) {
                const byte ctl = (byte)ShuffleControlG4.XZYW;
                Vector256<ulong> a0;
                a0 = Avx2.UnpackLow(data0, data1);
                a0 = Avx2.Permute4x64(a0, ctl);
                return a0;
            }


            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2UnzipOdd_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2UnzipOdd(Vector256<float> data0, Vector256<float> data1) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2UnzipOdd_Permute(data0, data1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2UnzipOdd_Unpack(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2UnzipOdd(Vector256<double> data0, Vector256<double> data1) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2UnzipOdd_Permute(data0, data1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2UnzipOdd_Unpack(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2UnzipOdd(Vector256<sbyte> data0, Vector256<sbyte> data1) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    return YGroup2UnzipOdd_Permute(data0, data1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2UnzipOdd_Narrow(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2UnzipOdd(Vector256<byte> data0, Vector256<byte> data1) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    return YGroup2UnzipOdd_Permute(data0, data1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2UnzipOdd_Narrow(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2UnzipOdd(Vector256<short> data0, Vector256<short> data1) {
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    return YGroup2UnzipOdd_Permute(data0, data1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2UnzipOdd_Narrow(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2UnzipOdd(Vector256<ushort> data0, Vector256<ushort> data1) {
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    return YGroup2UnzipOdd_Permute(data0, data1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2UnzipOdd_Narrow(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2UnzipOdd(Vector256<int> data0, Vector256<int> data1) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2UnzipOdd_Permute(data0, data1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2UnzipOdd_Unpack(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2UnzipOdd(Vector256<uint> data0, Vector256<uint> data1) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2UnzipOdd_Permute(data0, data1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2UnzipOdd_Unpack(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup2UnzipOdd(Vector256<long> data0, Vector256<long> data1) {
                return YGroup2UnzipOdd_Unpack(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup2UnzipOdd(Vector256<ulong> data0, Vector256<ulong> data1) {
                return YGroup2UnzipOdd_Unpack(data0, data1);
            }

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
                Vector256<byte> rt1;
                Vector256<ushort> temp0 = data0.AsUInt16();
                Vector256<ushort> temp1 = data1.AsUInt16();
                temp0 = Avx2.ShiftRightLogical(temp0, L);
                temp1 = Avx2.ShiftRightLogical(temp1, L);
                rt1 = Narrow(temp0, temp1);
                return rt1;
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
                Vector256<ushort> rt1;
                Vector256<uint> temp0 = data0.AsUInt32();
                Vector256<uint> temp1 = data1.AsUInt32();
                temp0 = Avx2.ShiftRightLogical(temp0, L); // 1,0.5
                temp1 = Avx2.ShiftRightLogical(temp1, L); // 1,0.5
                rt1 = Narrow(temp0, temp1); // 8, 2.66
                return rt1;
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
                Vector256<uint> rt1;
                Vector256<ulong> temp0 = data0.AsUInt64();
                Vector256<ulong> temp1 = data1.AsUInt64();
                temp0 = Avx2.ShiftRightLogical(temp0, L);
                temp1 = Avx2.ShiftRightLogical(temp1, L);
                rt1 = Narrow(temp0, temp1);
                return rt1;
            }

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2UnzipOdd_Permute(Vector256<float> data0, Vector256<float> data1) {
                VectorMessageFormats.ThrowForUnsupported(Avx512F.VL.IsSupported, "Avx512F, Avx512VL");
                return Avx512F.VL.PermuteVar8x32x2(data0, Vector256Constants.YGroup2Unzip_UInt32_ShuffleX2_Index1.AsInt32(), data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2UnzipOdd_Permute(Vector256<double> data0, Vector256<double> data1) {
                VectorMessageFormats.ThrowForUnsupported(Avx512F.VL.IsSupported, "Avx512F, Avx512VL");
                return Avx512F.VL.PermuteVar4x64x2(data0, Vector256Constants.YGroup2Unzip_UInt64_ShuffleX2_Index1.AsInt64(), data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2UnzipOdd_Permute(Vector256<sbyte> data0, Vector256<sbyte> data1) {
                return YGroup2UnzipOdd_Permute(data0.AsByte(), data1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2UnzipOdd_Permute(Vector256<byte> data0, Vector256<byte> data1) {
                VectorMessageFormats.ThrowForUnsupported(Avx512Vbmi.VL.IsSupported, "Avx512Vbmi, Avx512VL");
                return Avx512Vbmi.VL.PermuteVar32x8x2(data0, Vector256Constants.YGroup2Unzip_Byte_ShuffleX2_Index1, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2UnzipOdd_Permute(Vector256<short> data0, Vector256<short> data1) {
                return YGroup2UnzipOdd_Permute(data0.AsUInt16(), data1.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2UnzipOdd_Permute(Vector256<ushort> data0, Vector256<ushort> data1) {
                VectorMessageFormats.ThrowForUnsupported(Avx512BW.VL.IsSupported, "Avx512BW, Avx512VL");
                return Avx512BW.VL.PermuteVar16x16x2(data0, Vector256Constants.YGroup2Unzip_UInt16_ShuffleX2_Index1, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2UnzipOdd_Permute(Vector256<int> data0, Vector256<int> data1) {
                return YGroup2UnzipOdd_Permute(data0.AsUInt32(), data1.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2UnzipOdd_Permute(Vector256<uint> data0, Vector256<uint> data1) {
                VectorMessageFormats.ThrowForUnsupported(Avx512F.VL.IsSupported, "Avx512F, Avx512VL");
                return Avx512F.VL.PermuteVar8x32x2(data0, Vector256Constants.YGroup2Unzip_UInt32_ShuffleX2_Index1, data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup2UnzipOdd_Permute(Vector256<long> data0, Vector256<long> data1) {
                return YGroup2UnzipOdd_Permute(data0.AsUInt64(), data1.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup2UnzipOdd_Permute(Vector256<ulong> data0, Vector256<ulong> data1) {
                VectorMessageFormats.ThrowForUnsupported(Avx512F.VL.IsSupported, "Avx512F, Avx512VL");
                return Avx512F.VL.PermuteVar4x64x2(data0, Vector256Constants.YGroup2Unzip_UInt64_ShuffleX2_Index1, data1);
            }

#endif // NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2UnzipOdd_Unpack(Vector256<float> data0, Vector256<float> data1) {
                const byte ctl = (byte)ShuffleControlG4.XZYW;
                Vector256<float> a0, a1, b1;
                a0 = Avx.UnpackLow(data0, data1);
                a1 = Avx.UnpackHigh(data0, data1);
                b1 = Avx.UnpackHigh(a0, a1);
                b1 = Avx2.Permute4x64(b1.AsUInt64(), ctl).AsSingle();
                return b1;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2UnzipOdd_Unpack(Vector256<double> data0, Vector256<double> data1) {
                const byte ctl = (byte)ShuffleControlG4.XZYW;
                Vector256<double> a1;
                a1 = Avx.UnpackHigh(data0, data1);
                a1 = Avx2.Permute4x64(a1, ctl);
                return a1;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2UnzipOdd_Unpack(Vector256<sbyte> data0, Vector256<sbyte> data1) {
                return YGroup2UnzipOdd_Unpack(data0.AsByte(), data1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2UnzipOdd_Unpack(Vector256<byte> data0, Vector256<byte> data1) {
                const byte ctl = (byte)ShuffleControlG4.XZYW;
                Vector256<byte> a0, a1, b0, b1;
                a0 = Avx2.UnpackLow(data0, data1);
                a1 = Avx2.UnpackHigh(data0, data1);
                b0 = Avx2.UnpackLow(a0, a1);
                b1 = Avx2.UnpackHigh(a0, a1);
                a0 = Avx2.UnpackLow(b0, b1);
                a1 = Avx2.UnpackHigh(b0, b1);
                b1 = Avx2.UnpackHigh(a0, a1);
                b1 = Avx2.Permute4x64(b1.AsUInt64(), ctl).AsByte();
                return b1;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2UnzipOdd_Unpack(Vector256<short> data0, Vector256<short> data1) {
                return YGroup2UnzipOdd_Unpack(data0.AsUInt16(), data1.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2UnzipOdd_Unpack(Vector256<ushort> data0, Vector256<ushort> data1) {
                const byte ctl = (byte)ShuffleControlG4.XZYW;
                Vector256<ushort> a0, a1, b0, b1;
                // Format: Code; //Latency, Throughput(references IceLake)
                a0 = Avx2.UnpackLow(data0, data1);  // 1,0.5
                a1 = Avx2.UnpackHigh(data0, data1); // 1,0.5
                b0 = Avx2.UnpackLow(a0, a1);  // 1,0.5
                b1 = Avx2.UnpackHigh(a0, a1); // 1,0.5
                a1 = Avx2.UnpackHigh(b0, b1); // 1,0.5
                a1 = Avx2.Permute4x64(a1.AsUInt64(), ctl).AsUInt16(); // 3,1
                return a1;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2UnzipOdd_Unpack(Vector256<int> data0, Vector256<int> data1) {
                return YGroup2UnzipOdd_Unpack(data0.AsUInt32(), data1.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2UnzipOdd_Unpack(Vector256<uint> data0, Vector256<uint> data1) {
                const byte ctl = (byte)ShuffleControlG4.XZYW;
                Vector256<uint> a0, a1, b1;
                a0 = Avx2.UnpackLow(data0, data1);
                a1 = Avx2.UnpackHigh(data0, data1);
                b1 = Avx2.UnpackHigh(a0, a1);
                b1 = Avx2.Permute4x64(b1.AsUInt64(), ctl).AsUInt32();
                return b1;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup2UnzipOdd_Unpack(Vector256<long> data0, Vector256<long> data1) {
                return YGroup2UnzipOdd_Unpack(data0.AsUInt64(), data1.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup2UnzipOdd_Unpack(Vector256<ulong> data0, Vector256<ulong> data1) {
                const byte ctl = (byte)ShuffleControlG4.XZYW;
                Vector256<ulong> a1;
                a1 = Avx2.UnpackHigh(data0, data1);
                a1 = Avx2.Permute4x64(a1, ctl);
                return a1;
            }


            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2Zip_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{float}, Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2Zip(Vector256<float> x, Vector256<float> y, out Vector256<float> data1) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2Zip_Permute(x, y, out data1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2Zip_Unpack(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{double}, Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2Zip(Vector256<double> x, Vector256<double> y, out Vector256<double> data1) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2Zip_Permute(x, y, out data1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2Zip_Unpack(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2Zip(Vector256<sbyte> x, Vector256<sbyte> y, out Vector256<sbyte> data1) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    return YGroup2Zip_Permute(x, y, out data1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2Zip_Unpack(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{byte}, Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2Zip(Vector256<byte> x, Vector256<byte> y, out Vector256<byte> data1) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    return YGroup2Zip_Permute(x, y, out data1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2Zip_Unpack(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{short}, Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2Zip(Vector256<short> x, Vector256<short> y, out Vector256<short> data1) {
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    return YGroup2Zip_Permute(x, y, out data1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2Zip_Unpack(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{ushort}, Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2Zip(Vector256<ushort> x, Vector256<ushort> y, out Vector256<ushort> data1) {
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    return YGroup2Zip_Permute(x, y, out data1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2Zip_Unpack(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{int}, Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2Zip(Vector256<int> x, Vector256<int> y, out Vector256<int> data1) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2Zip_Permute(x, y, out data1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2Zip_Unpack(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{uint}, Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2Zip(Vector256<uint> x, Vector256<uint> y, out Vector256<uint> data1) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2Zip_Permute(x, y, out data1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2Zip_Unpack(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{long}, Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup2Zip(Vector256<long> x, Vector256<long> y, out Vector256<long> data1) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2Zip_Permute(x, y, out data1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2Zip_Unpack(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{ulong}, Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup2Zip(Vector256<ulong> x, Vector256<ulong> y, out Vector256<ulong> data1) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2Zip_Permute(x, y, out data1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2Zip_Unpack(x, y, out data1);
            }

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{float}, Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2Zip_Permute(Vector256<float> x, Vector256<float> y, out Vector256<float> data1) {
                VectorMessageFormats.ThrowForUnsupported(Avx512F.VL.IsSupported, "Avx512F, Avx512VL");
                var data0 = Avx512F.VL.PermuteVar8x32x2(x, Vector256Constants.YGroup2Zip_UInt32_ShuffleX2_Index0.AsInt32(), y);
                data1 = Avx512F.VL.PermuteVar8x32x2(x, Vector256Constants.YGroup2Zip_UInt32_ShuffleX2_Index1.AsInt32(), y);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{double}, Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2Zip_Permute(Vector256<double> x, Vector256<double> y, out Vector256<double> data1) {
                VectorMessageFormats.ThrowForUnsupported(Avx512F.VL.IsSupported, "Avx512F, Avx512VL");
                var data0 = Avx512F.VL.PermuteVar4x64x2(x, Vector256Constants.YGroup2Zip_UInt64_ShuffleX2_Index0.AsInt64(), y);
                data1 = Avx512F.VL.PermuteVar4x64x2(x, Vector256Constants.YGroup2Zip_UInt64_ShuffleX2_Index1.AsInt64(), y);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2Zip_Permute(Vector256<sbyte> x, Vector256<sbyte> y, out Vector256<sbyte> data1) {
                var d0 = YGroup2Zip_Permute(x.AsByte(), y.AsByte(), out var d1);
                data1 = d1.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{byte}, Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2Zip_Permute(Vector256<byte> x, Vector256<byte> y, out Vector256<byte> data1) {
                VectorMessageFormats.ThrowForUnsupported(Avx512Vbmi.VL.IsSupported, "Avx512Vbmi, Avx512VL");
                var data0 = Avx512Vbmi.VL.PermuteVar32x8x2(x, Vector256Constants.YGroup2Zip_Byte_ShuffleX2_Index0, y);
                data1 = Avx512Vbmi.VL.PermuteVar32x8x2(x, Vector256Constants.YGroup2Zip_Byte_ShuffleX2_Index1, y);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{short}, Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2Zip_Permute(Vector256<short> x, Vector256<short> y, out Vector256<short> data1) {
                var d0 = YGroup2Zip_Permute(x.AsUInt16(), y.AsUInt16(), out var d1);
                data1 = d1.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{ushort}, Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2Zip_Permute(Vector256<ushort> x, Vector256<ushort> y, out Vector256<ushort> data1) {
                VectorMessageFormats.ThrowForUnsupported(Avx512BW.VL.IsSupported, "Avx512BW, Avx512VL");
                var data0 = Avx512BW.VL.PermuteVar16x16x2(x, Vector256Constants.YGroup2Zip_UInt16_ShuffleX2_Index0, y);
                data1 = Avx512BW.VL.PermuteVar16x16x2(x, Vector256Constants.YGroup2Zip_UInt16_ShuffleX2_Index1, y);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{int}, Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2Zip_Permute(Vector256<int> x, Vector256<int> y, out Vector256<int> data1) {
                var d0 = YGroup2Zip_Permute(x.AsUInt32(), y.AsUInt32(), out var d1);
                data1 = d1.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{uint}, Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2Zip_Permute(Vector256<uint> x, Vector256<uint> y, out Vector256<uint> data1) {
                VectorMessageFormats.ThrowForUnsupported(Avx512F.VL.IsSupported, "Avx512F, Avx512VL");
                var data0 = Avx512F.VL.PermuteVar8x32x2(x, Vector256Constants.YGroup2Zip_UInt32_ShuffleX2_Index0, y);
                data1 = Avx512F.VL.PermuteVar8x32x2(x, Vector256Constants.YGroup2Zip_UInt32_ShuffleX2_Index1, y);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{long}, Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup2Zip_Permute(Vector256<long> x, Vector256<long> y, out Vector256<long> data1) {
                var d0 = YGroup2Zip_Permute(x.AsUInt64(), y.AsUInt64(), out var d1);
                data1 = d1.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{ulong}, Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup2Zip_Permute(Vector256<ulong> x, Vector256<ulong> y, out Vector256<ulong> data1) {
                VectorMessageFormats.ThrowForUnsupported(Avx512F.VL.IsSupported, "Avx512F, Avx512VL");
                var data0 = Avx512F.VL.PermuteVar4x64x2(x, Vector256Constants.YGroup2Zip_UInt64_ShuffleX2_Index0, y);
                data1 = Avx512F.VL.PermuteVar4x64x2(x, Vector256Constants.YGroup2Zip_UInt64_ShuffleX2_Index1, y);
                return data0;
            }

#endif // NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{float}, Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2Zip_Unpack(Vector256<float> x, Vector256<float> y, out Vector256<float> data1) {
                //var d0 = YGroup2Zip_Unpack(x.AsUInt32(), y.AsUInt32(), out var d1);
                //data1 = d1.AsSingle();
                //return d0.AsSingle();
                const byte ctl = (byte)ShuffleControlG4.XZYW;
                Vector256<float> x1, y1, data0;
                // Format: Code; //Latency, Throughput(references IceLake)
                x1 = Avx2.Permute4x64(x.AsUInt64(), ctl).AsSingle(); // 3,1
                y1 = Avx2.Permute4x64(y.AsUInt64(), ctl).AsSingle(); // 3,1
                data0 = Avx.UnpackLow(x1, y1); // 1,0.5
                data1 = Avx.UnpackHigh(x1, y1); // 1,0.5
                return data0; //total latency: 8, total throughput CPI: 3
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{double}, Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2Zip_Unpack(Vector256<double> x, Vector256<double> y, out Vector256<double> data1) {
                //var d0 = YGroup2Zip_Unpack(x.AsUInt64(), y.AsUInt64(), out var d1);
                //data1 = d1.AsDouble();
                //return d0.AsDouble();
                const byte ctl = (byte)ShuffleControlG4.XZYW;
                Vector256<double> x1, y1, data0;
                // Format: Code; //Latency, Throughput(references IceLake)
                x1 = Avx2.Permute4x64(x, ctl); // 3,1
                y1 = Avx2.Permute4x64(y, ctl); // 3,1
                data0 = Avx.UnpackLow(x1, y1); // 1,0.5
                data1 = Avx.UnpackHigh(x1, y1); // 1,0.5
                return data0; //total latency: 8, total throughput CPI: 3
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2Zip_Unpack(Vector256<sbyte> x, Vector256<sbyte> y, out Vector256<sbyte> data1) {
                var d0 = YGroup2Zip_Unpack(x.AsByte(), y.AsByte(), out var d1);
                data1 = d1.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{byte}, Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2Zip_Unpack(Vector256<byte> x, Vector256<byte> y, out Vector256<byte> data1) {
                const byte ctl = (byte)ShuffleControlG4.XZYW;
                Vector256<byte> x1, y1, data0;
                // Format: Code; //Latency, Throughput(references IceLake)
                x1 = Avx2.Permute4x64(x.AsUInt64(), ctl).AsByte(); // 3,1
                y1 = Avx2.Permute4x64(y.AsUInt64(), ctl).AsByte(); // 3,1
                data0 = Avx2.UnpackLow(x1, y1); // 1,0.5
                data1 = Avx2.UnpackHigh(x1, y1); // 1,0.5
                return data0; //total latency: 8, total throughput CPI: 3
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{short}, Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2Zip_Unpack(Vector256<short> x, Vector256<short> y, out Vector256<short> data1) {
                var d0 = YGroup2Zip_Unpack(x.AsUInt16(), y.AsUInt16(), out var d1);
                data1 = d1.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{ushort}, Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2Zip_Unpack(Vector256<ushort> x, Vector256<ushort> y, out Vector256<ushort> data1) {
                const byte ctl = (byte)ShuffleControlG4.XZYW;
                Vector256<ushort> x1, y1, data0;
                // Format: Code; //Latency, Throughput(references IceLake)
                x1 = Avx2.Permute4x64(x.AsUInt64(), ctl).AsUInt16(); // 3,1
                y1 = Avx2.Permute4x64(y.AsUInt64(), ctl).AsUInt16(); // 3,1
                data0 = Avx2.UnpackLow(x1, y1); // 1,0.5
                data1 = Avx2.UnpackHigh(x1, y1); // 1,0.5
                return data0; //total latency: 8, total throughput CPI: 3
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{int}, Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2Zip_Unpack(Vector256<int> x, Vector256<int> y, out Vector256<int> data1) {
                var d0 = YGroup2Zip_Unpack(x.AsUInt32(), y.AsUInt32(), out var d1);
                data1 = d1.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{uint}, Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2Zip_Unpack(Vector256<uint> x, Vector256<uint> y, out Vector256<uint> data1) {
                const byte ctl = (byte)ShuffleControlG4.XZYW;
                Vector256<uint> x1, y1, data0;
                // Format: Code; //Latency, Throughput(references IceLake)
                x1 = Avx2.Permute4x64(x.AsUInt64(), ctl).AsUInt32(); // 3,1
                y1 = Avx2.Permute4x64(y.AsUInt64(), ctl).AsUInt32(); // 3,1
                data0 = Avx2.UnpackLow(x1, y1); // 1,0.5
                data1 = Avx2.UnpackHigh(x1, y1); // 1,0.5
                return data0; //total latency: 8, total throughput CPI: 3
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{long}, Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup2Zip_Unpack(Vector256<long> x, Vector256<long> y, out Vector256<long> data1) {
                var d0 = YGroup2Zip_Unpack(x.AsUInt64(), y.AsUInt64(), out var d1);
                data1 = d1.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{ulong}, Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup2Zip_Unpack(Vector256<ulong> x, Vector256<ulong> y, out Vector256<ulong> data1) {
                const byte ctl = (byte)ShuffleControlG4.XZYW;
                Vector256<ulong> x1, y1, data0;
                // Format: Code; //Latency, Throughput(references IceLake)
                x1 = Avx2.Permute4x64(x, ctl).AsUInt64(); // 3,1
                y1 = Avx2.Permute4x64(y, ctl).AsUInt64(); // 3,1
                data0 = Avx2.UnpackLow(x1, y1); // 1,0.5
                data1 = Avx2.UnpackHigh(x1, y1); // 1,0.5
                return data0; //total latency: 8, total throughput CPI: 3
            }

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
                Widen(y, out b0, out b1);
                Widen(x, out a0, out a1);
                b0 = Avx2.ShiftLeftLogical(b0, L);
                b1 = Avx2.ShiftLeftLogical(b1, L);
                a0 = Avx2.Or(a0, b0);
                a1 = Avx2.Or(a1, b1);
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
                Widen(y, out b0, out b1);
                Widen(x, out a0, out a1);
                b0 = Avx2.ShiftLeftLogical(b0, L);
                b1 = Avx2.ShiftLeftLogical(b1, L);
                a0 = Avx2.Or(a0, b0);
                a1 = Avx2.Or(a1, b1);
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
                Widen(y, out b0, out b1);
                Widen(x, out a0, out a1);
                b0 = Avx2.ShiftLeftLogical(b0, L);
                b1 = Avx2.ShiftLeftLogical(b1, L);
                a0 = Avx2.Or(a0, b0);
                a1 = Avx2.Or(a1, b1);
                data1 = a1.AsUInt32();
                return a0.AsUInt32();
            }


            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2ZipHigh_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2ZipHigh(Vector256<float> x, Vector256<float> y) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2ZipHigh_Permute(x, y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2ZipHigh_Unpack(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2ZipHigh(Vector256<double> x, Vector256<double> y) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2ZipHigh_Permute(x, y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2ZipHigh_Unpack(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2ZipHigh(Vector256<sbyte> x, Vector256<sbyte> y) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    return YGroup2ZipHigh_Permute(x, y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2ZipHigh_Unpack(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2ZipHigh(Vector256<byte> x, Vector256<byte> y) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    return YGroup2ZipHigh_Permute(x, y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2ZipHigh_Unpack(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2ZipHigh(Vector256<short> x, Vector256<short> y) {
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    return YGroup2ZipHigh_Permute(x, y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2ZipHigh_Unpack(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2ZipHigh(Vector256<ushort> x, Vector256<ushort> y) {
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    return YGroup2ZipHigh_Permute(x, y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2ZipHigh_Unpack(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2ZipHigh(Vector256<int> x, Vector256<int> y) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2ZipHigh_Permute(x, y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2ZipHigh_Unpack(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2ZipHigh(Vector256<uint> x, Vector256<uint> y) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2ZipHigh_Permute(x, y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2ZipHigh_Unpack(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup2ZipHigh(Vector256<long> x, Vector256<long> y) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2ZipHigh_Permute(x, y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2ZipHigh_Unpack(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup2ZipHigh(Vector256<ulong> x, Vector256<ulong> y) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2ZipHigh_Permute(x, y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2ZipHigh_Unpack(x, y);
            }

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2ZipHigh_Permute(Vector256<float> x, Vector256<float> y) {
                //return YGroup2ZipHigh_Permute(x.AsUInt32(), y.AsUInt32()).AsSingle();
                VectorMessageFormats.ThrowForUnsupported(Avx512F.VL.IsSupported, "Avx512F, Avx512VL");
                return Avx512F.VL.PermuteVar8x32x2(x, Vector256Constants.YGroup2Zip_UInt32_ShuffleX2_Index1.AsInt32(), y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2ZipHigh_Permute(Vector256<double> x, Vector256<double> y) {
                //return YGroup2ZipHigh_Permute(x.AsUInt64(), y.AsUInt64()).AsDouble();
                VectorMessageFormats.ThrowForUnsupported(Avx512F.VL.IsSupported, "Avx512F, Avx512VL");
                return Avx512F.VL.PermuteVar4x64x2(x, Vector256Constants.YGroup2Zip_UInt64_ShuffleX2_Index1.AsInt64(), y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2ZipHigh_Permute(Vector256<sbyte> x, Vector256<sbyte> y) {
                return YGroup2ZipHigh_Permute(x.AsByte(), y.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2ZipHigh_Permute(Vector256<byte> x, Vector256<byte> y) {
                VectorMessageFormats.ThrowForUnsupported(Avx512Vbmi.VL.IsSupported, "Avx512Vbmi, Avx512VL");
                return Avx512Vbmi.VL.PermuteVar32x8x2(x, Vector256Constants.YGroup2Zip_Byte_ShuffleX2_Index1, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2ZipHigh_Permute(Vector256<short> x, Vector256<short> y) {
                return YGroup2ZipHigh_Permute(x.AsUInt16(), y.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2ZipHigh_Permute(Vector256<ushort> x, Vector256<ushort> y) {
                VectorMessageFormats.ThrowForUnsupported(Avx512BW.VL.IsSupported, "Avx512BW, Avx512VL");
                return Avx512BW.VL.PermuteVar16x16x2(x, Vector256Constants.YGroup2Zip_UInt16_ShuffleX2_Index1, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2ZipHigh_Permute(Vector256<int> x, Vector256<int> y) {
                return YGroup2ZipHigh_Permute(x.AsUInt32(), y.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2ZipHigh_Permute(Vector256<uint> x, Vector256<uint> y) {
                VectorMessageFormats.ThrowForUnsupported(Avx512F.VL.IsSupported, "Avx512F, Avx512VL");
                return Avx512F.VL.PermuteVar8x32x2(x, Vector256Constants.YGroup2Zip_UInt32_ShuffleX2_Index1, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup2ZipHigh_Permute(Vector256<long> x, Vector256<long> y) {
                return YGroup2ZipHigh_Permute(x.AsUInt64(), y.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup2ZipHigh_Permute(Vector256<ulong> x, Vector256<ulong> y) {
                VectorMessageFormats.ThrowForUnsupported(Avx512F.VL.IsSupported, "Avx512F, Avx512VL");
                return Avx512F.VL.PermuteVar4x64x2(x, Vector256Constants.YGroup2Zip_UInt64_ShuffleX2_Index1, y);
            }

#endif // NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2ZipHigh_Unpack(Vector256<float> x, Vector256<float> y) {
                //return YGroup2ZipHigh_Unpack(x.AsUInt32(), y.AsUInt32()).AsSingle();
                const byte ctl = (byte)ShuffleControlG4.XZYW;
                Vector256<float> x1, y1;
                x1 = Avx2.Permute4x64(x.AsUInt64(), ctl).AsSingle();
                y1 = Avx2.Permute4x64(y.AsUInt64(), ctl).AsSingle();
                return Avx.UnpackHigh(x1, y1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2ZipHigh_Unpack(Vector256<double> x, Vector256<double> y) {
                //return YGroup2ZipHigh_Unpack(x.AsUInt64(), y.AsUInt64()).AsDouble();
                const byte ctl = (byte)ShuffleControlG4.XZYW;
                Vector256<double> x1, y1;
                x1 = Avx2.Permute4x64(x, ctl);
                y1 = Avx2.Permute4x64(y, ctl);
                return Avx.UnpackHigh(x1, y1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2ZipHigh_Unpack(Vector256<sbyte> x, Vector256<sbyte> y) {
                return YGroup2ZipHigh_Unpack(x.AsByte(), y.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2ZipHigh_Unpack(Vector256<byte> x, Vector256<byte> y) {
                const byte ctl = (byte)ShuffleControlG4.XZYW;
                Vector256<byte> x1, y1;
                x1 = Avx2.Permute4x64(x.AsUInt64(), ctl).AsByte();
                y1 = Avx2.Permute4x64(y.AsUInt64(), ctl).AsByte();
                return Avx2.UnpackHigh(x1, y1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2ZipHigh_Unpack(Vector256<short> x, Vector256<short> y) {
                return YGroup2ZipHigh_Unpack(x.AsUInt16(), y.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2ZipHigh_Unpack(Vector256<ushort> x, Vector256<ushort> y) {
                const byte ctl = (byte)ShuffleControlG4.XZYW;
                Vector256<ushort> x1, y1;
                x1 = Avx2.Permute4x64(x.AsUInt64(), ctl).AsUInt16();
                y1 = Avx2.Permute4x64(y.AsUInt64(), ctl).AsUInt16();
                return Avx2.UnpackHigh(x1, y1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
                public static Vector256<int> YGroup2ZipHigh_Unpack(Vector256<int> x, Vector256<int> y) {
                    return YGroup2ZipHigh_Unpack(x.AsUInt32(), y.AsUInt32()).AsInt32();
                }

                /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{uint}, Vector256{uint})"/>
                [CLSCompliant(false)]
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                public static Vector256<uint> YGroup2ZipHigh_Unpack(Vector256<uint> x, Vector256<uint> y) {
                const byte ctl = (byte)ShuffleControlG4.XZYW;
                Vector256<uint> x1, y1;
                x1 = Avx2.Permute4x64(x.AsUInt64(), ctl).AsUInt32();
                y1 = Avx2.Permute4x64(y.AsUInt64(), ctl).AsUInt32();
                return Avx2.UnpackHigh(x1, y1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup2ZipHigh_Unpack(Vector256<long> x, Vector256<long> y) {
                return YGroup2ZipHigh_Unpack(x.AsUInt64(), y.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
                public static Vector256<ulong> YGroup2ZipHigh_Unpack(Vector256<ulong> x, Vector256<ulong> y) {
                const byte ctl = (byte)ShuffleControlG4.XZYW;
                Vector256<ulong> x1, y1;
                x1 = Avx2.Permute4x64(x, ctl).AsUInt64();
                y1 = Avx2.Permute4x64(y, ctl).AsUInt64();
                return Avx2.UnpackHigh(x1, y1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2ZipLow_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2ZipLow(Vector256<float> x, Vector256<float> y) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2ZipLow_Permute(x, y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2ZipLow_Unpack(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2ZipLow(Vector256<double> x, Vector256<double> y) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2ZipLow_Permute(x, y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2ZipLow_Unpack(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2ZipLow(Vector256<sbyte> x, Vector256<sbyte> y) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    return YGroup2ZipLow_Permute(x, y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2ZipLow_Unpack(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2ZipLow(Vector256<byte> x, Vector256<byte> y) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    return YGroup2ZipLow_Permute(x, y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2ZipLow_Unpack(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2ZipLow(Vector256<short> x, Vector256<short> y) {
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    return YGroup2ZipLow_Permute(x, y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2ZipLow_Unpack(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2ZipLow(Vector256<ushort> x, Vector256<ushort> y) {
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    return YGroup2ZipLow_Permute(x, y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2ZipLow_Unpack(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2ZipLow(Vector256<int> x, Vector256<int> y) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2ZipLow_Permute(x, y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2ZipLow_Unpack(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2ZipLow(Vector256<uint> x, Vector256<uint> y) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2ZipLow_Permute(x, y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2ZipLow_Unpack(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup2ZipLow(Vector256<long> x, Vector256<long> y) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2ZipLow_Permute(x, y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2ZipLow_Unpack(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup2ZipLow(Vector256<ulong> x, Vector256<ulong> y) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2ZipLow_Permute(x, y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2ZipLow_Unpack(x, y);
            }

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2ZipLow_Permute(Vector256<float> x, Vector256<float> y) {
                //return YGroup2ZipLow_Permute(x.AsUInt32(), y.AsUInt32()).AsSingle();
                VectorMessageFormats.ThrowForUnsupported(Avx512F.VL.IsSupported, "Avx512F, Avx512VL");
                return Avx512F.VL.PermuteVar8x32x2(x, Vector256Constants.YGroup2Zip_UInt32_ShuffleX2_Index0.AsInt32(), y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2ZipLow_Permute(Vector256<double> x, Vector256<double> y) {
                //return YGroup2ZipLow_Permute(x.AsUInt64(), y.AsUInt64()).AsDouble();
                VectorMessageFormats.ThrowForUnsupported(Avx512F.VL.IsSupported, "Avx512F, Avx512VL");
                return Avx512F.VL.PermuteVar4x64x2(x, Vector256Constants.YGroup2Zip_UInt64_ShuffleX2_Index0.AsInt64(), y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2ZipLow_Permute(Vector256<sbyte> x, Vector256<sbyte> y) {
                return YGroup2ZipLow_Permute(x.AsByte(), y.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2ZipLow_Permute(Vector256<byte> x, Vector256<byte> y) {
                VectorMessageFormats.ThrowForUnsupported(Avx512Vbmi.VL.IsSupported, "Avx512Vbmi, Avx512VL");
                return Avx512Vbmi.VL.PermuteVar32x8x2(x, Vector256Constants.YGroup2Zip_Byte_ShuffleX2_Index0, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2ZipLow_Permute(Vector256<short> x, Vector256<short> y) {
                return YGroup2ZipLow_Permute(x.AsUInt16(), y.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2ZipLow_Permute(Vector256<ushort> x, Vector256<ushort> y) {
                VectorMessageFormats.ThrowForUnsupported(Avx512BW.VL.IsSupported, "Avx512BW, Avx512VL");
                return Avx512BW.VL.PermuteVar16x16x2(x, Vector256Constants.YGroup2Zip_UInt16_ShuffleX2_Index0, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2ZipLow_Permute(Vector256<int> x, Vector256<int> y) {
                return YGroup2ZipLow_Permute(x.AsUInt32(), y.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2ZipLow_Permute(Vector256<uint> x, Vector256<uint> y) {
                VectorMessageFormats.ThrowForUnsupported(Avx512F.VL.IsSupported, "Avx512F, Avx512VL");
                return Avx512F.VL.PermuteVar8x32x2(x, Vector256Constants.YGroup2Zip_UInt32_ShuffleX2_Index0, y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup2ZipLow_Permute(Vector256<long> x, Vector256<long> y) {
                return YGroup2ZipLow_Permute(x.AsUInt64(), y.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup2ZipLow_Permute(Vector256<ulong> x, Vector256<ulong> y) {
                VectorMessageFormats.ThrowForUnsupported(Avx512F.VL.IsSupported, "Avx512F, Avx512VL");
                return Avx512F.VL.PermuteVar4x64x2(x, Vector256Constants.YGroup2Zip_UInt64_ShuffleX2_Index0, y);
            }

#endif // NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2ZipLow_Unpack(Vector256<float> x, Vector256<float> y) {
                //return YGroup2ZipLow_Unpack(x.AsUInt32(), y.AsUInt32()).AsSingle();
                const byte ctl = (byte)ShuffleControlG4.XZYW;
                Vector256<float> x1, y1;
                x1 = Avx2.Permute4x64(x.AsUInt64(), ctl).AsSingle();
                y1 = Avx2.Permute4x64(y.AsUInt64(), ctl).AsSingle();
                return Avx.UnpackLow(x1, y1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2ZipLow_Unpack(Vector256<double> x, Vector256<double> y) {
                //return YGroup2ZipLow_Unpack(x.AsUInt64(), y.AsUInt64()).AsDouble();
                const byte ctl = (byte)ShuffleControlG4.XZYW;
                Vector256<double> x1, y1;
                x1 = Avx2.Permute4x64(x, ctl);
                y1 = Avx2.Permute4x64(y, ctl);
                return Avx.UnpackLow(x1, y1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup2ZipLow_Unpack(Vector256<sbyte> x, Vector256<sbyte> y) {
                return YGroup2ZipLow_Unpack(x.AsByte(), y.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup2ZipLow_Unpack(Vector256<byte> x, Vector256<byte> y) {
                const byte ctl = (byte)ShuffleControlG4.XZYW;
                Vector256<byte> x1, y1;
                x1 = Avx2.Permute4x64(x.AsUInt64(), ctl).AsByte();
                y1 = Avx2.Permute4x64(y.AsUInt64(), ctl).AsByte();
                return Avx2.UnpackLow(x1, y1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup2ZipLow_Unpack(Vector256<short> x, Vector256<short> y) {
                return YGroup2ZipLow_Unpack(x.AsUInt16(), y.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup2ZipLow_Unpack(Vector256<ushort> x, Vector256<ushort> y) {
                const byte ctl = (byte)ShuffleControlG4.XZYW;
                Vector256<ushort> x1, y1;
                x1 = Avx2.Permute4x64(x.AsUInt64(), ctl).AsUInt16();
                y1 = Avx2.Permute4x64(y.AsUInt64(), ctl).AsUInt16();
                return Avx2.UnpackLow(x1, y1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup2ZipLow_Unpack(Vector256<int> x, Vector256<int> y) {
                return YGroup2ZipLow_Unpack(x.AsUInt32(), y.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup2ZipLow_Unpack(Vector256<uint> x, Vector256<uint> y) {
                const byte ctl = (byte)ShuffleControlG4.XZYW;
                Vector256<uint> x1, y1;
                x1 = Avx2.Permute4x64(x.AsUInt64(), ctl).AsUInt32();
                y1 = Avx2.Permute4x64(y.AsUInt64(), ctl).AsUInt32();
                return Avx2.UnpackLow(x1, y1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup2ZipLow_Unpack(Vector256<long> x, Vector256<long> y) {
                return YGroup2ZipLow_Unpack(x.AsUInt64(), y.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup2ZipLow_Unpack(Vector256<ulong> x, Vector256<ulong> y) {
                const byte ctl = (byte)ShuffleControlG4.XZYW;
                Vector256<ulong> x1, y1;
                x1 = Avx2.Permute4x64(x, ctl).AsUInt64();
                y1 = Avx2.Permute4x64(y, ctl).AsUInt64();
                return Avx2.UnpackLow(x1, y1);
            }


#endif // NETCOREAPP3_0_OR_GREATER
        }
    }
}
