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

namespace Zyl.VectorTraits.Impl.AVector256 {
    using SuperStatics = WVectorTraits256Base.Statics;

    partial class WVectorTraits256Avx2 {

        partial class Statics {

#if NETCOREAPP3_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2Unzip_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes | TypeCodeFlags.Int128 | TypeCodeFlags.UInt128;
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{ExInt128}, Vector256{ExInt128}, out Vector256{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExInt128> YGroup2Unzip(Vector256<ExInt128> data0, Vector256<ExInt128> data1, out Vector256<ExInt128> y) {
                var d0 = YGroup2Unzip(data0.ExAsExUInt128(), data1.ExAsExUInt128(), out var d1);
                y = d1.ExAsExInt128();
                return d0.ExAsExInt128();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{ExUInt128}, Vector256{ExUInt128}, out Vector256{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExUInt128> YGroup2Unzip(Vector256<ExUInt128> data0, Vector256<ExUInt128> data1, out Vector256<ExUInt128> y) {
                var d0 = Avx.Permute2x128(data0.ExAsUInt64(), data1.ExAsUInt64(), (byte)ShuffleControl2X4Use4.XZ);
                var d1 = Avx.Permute2x128(data0.ExAsUInt64(), data1.ExAsUInt64(), (byte)ShuffleControl2X4Use4.YW);
                y = d1.ExAsExUInt128();
                return d0.ExAsExUInt128();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip_Int128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<T> YGroup2Unzip_Int128<T>(Vector256<T> data0, Vector256<T> data1, out Vector256<T> y) where T : struct {
#if EX_APPLY_GENERIC
                //var d0 = YGroup2Unzip(data0.ExAsExUInt128(), data1.ExAsExUInt128(), out var d1);
                var d0 = Avx.Permute2x128(data0.ExAsUInt64(), data1.ExAsUInt64(), (byte)ShuffleControl2X4Use4.XZ);
                var d1 = Avx.Permute2x128(data0.ExAsUInt64(), data1.ExAsUInt64(), (byte)ShuffleControl2X4Use4.YW);
                y = d1.ExAs<ulong, T>();
                return d0.ExAs<ulong, T>();
#else
                var d0 = Avx.Permute2x128(data0.AsUInt64(), data1.AsUInt64(), (byte)ShuffleControl2X4Use4.XZ);
                var d1 = Avx.Permute2x128(data0.AsUInt64(), data1.AsUInt64(), (byte)ShuffleControl2X4Use4.YW);
                y = d1.As<ulong, T>();
                return d0.As<ulong, T>();
#endif // EX_APPLY_GENERIC
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
                var rt0 = Avx512F.VL.PermuteVar8x32x2(data0, Vector256Constants.YGroup2Unzip_ShuffleX2_UInt32_X.AsInt32(), data1);
                rt1 = Avx512F.VL.PermuteVar8x32x2(data0, Vector256Constants.YGroup2Unzip_ShuffleX2_UInt32_Y.AsInt32(), data1);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Unzip(Vector256{double}, Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2Unzip_Permute(Vector256<double> data0, Vector256<double> data1, out Vector256<double> rt1) {
                VectorMessageFormats.ThrowForUnsupported(Avx512F.VL.IsSupported, "Avx512F, Avx512VL");
                var rt0 = Avx512F.VL.PermuteVar4x64x2(data0, Vector256Constants.YGroup2Unzip_ShuffleX2_UInt64_X.AsInt64(), data1);
                rt1 = Avx512F.VL.PermuteVar4x64x2(data0, Vector256Constants.YGroup2Unzip_ShuffleX2_UInt64_Y.AsInt64(), data1);
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
                var rt0 = Avx512Vbmi.VL.PermuteVar32x8x2(data0, Vector256Constants.YGroup2Unzip_ShuffleX2_Byte_X, data1);
                rt1 = Avx512Vbmi.VL.PermuteVar32x8x2(data0, Vector256Constants.YGroup2Unzip_ShuffleX2_Byte_Y, data1);
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
                var rt0 = Avx512BW.VL.PermuteVar16x16x2(data0, Vector256Constants.YGroup2Unzip_ShuffleX2_UInt16_X, data1);
                rt1 = Avx512BW.VL.PermuteVar16x16x2(data0, Vector256Constants.YGroup2Unzip_ShuffleX2_UInt16_Y, data1);
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
                var rt0 = Avx512F.VL.PermuteVar8x32x2(data0, Vector256Constants.YGroup2Unzip_ShuffleX2_UInt32_X, data1);
                rt1 = Avx512F.VL.PermuteVar8x32x2(data0, Vector256Constants.YGroup2Unzip_ShuffleX2_UInt32_Y, data1);
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
                var rt0 = Avx512F.VL.PermuteVar4x64x2(data0, Vector256Constants.YGroup2Unzip_ShuffleX2_UInt64_X, data1);
                rt1 = Avx512F.VL.PermuteVar4x64x2(data0, Vector256Constants.YGroup2Unzip_ShuffleX2_UInt64_Y, data1);
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
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes | TypeCodeFlags.Int128 | TypeCodeFlags.UInt128;
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{ExInt128}, Vector256{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExInt128> YGroup2UnzipEven(Vector256<ExInt128> data0, Vector256<ExInt128> data1) {
                return Avx.Permute2x128(data0.ExAsUInt64(), data1.ExAsUInt64(), (byte)ShuffleControl2X4Use4.XZ).ExAsExInt128();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{ExUInt128}, Vector256{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExUInt128> YGroup2UnzipEven(Vector256<ExUInt128> data0, Vector256<ExUInt128> data1) {
                return Avx.Permute2x128(data0.ExAsUInt64(), data1.ExAsUInt64(), (byte)ShuffleControl2X4Use4.XZ).ExAsExUInt128();
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
                return Avx512F.VL.PermuteVar8x32x2(data0, Vector256Constants.YGroup2Unzip_ShuffleX2_UInt32_X.AsInt32(), data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipEven(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2UnzipEven_Permute(Vector256<double> data0, Vector256<double> data1) {
                VectorMessageFormats.ThrowForUnsupported(Avx512F.VL.IsSupported, "Avx512F, Avx512VL");
                return Avx512F.VL.PermuteVar4x64x2(data0, Vector256Constants.YGroup2Unzip_ShuffleX2_UInt64_X.AsInt64(), data1);
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
                return Avx512Vbmi.VL.PermuteVar32x8x2(data0, Vector256Constants.YGroup2Unzip_ShuffleX2_Byte_X, data1);
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
                return Avx512BW.VL.PermuteVar16x16x2(data0, Vector256Constants.YGroup2Unzip_ShuffleX2_UInt16_X, data1);
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
                return Avx512F.VL.PermuteVar8x32x2(data0, Vector256Constants.YGroup2Unzip_ShuffleX2_UInt32_X, data1);
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
                return Avx512F.VL.PermuteVar4x64x2(data0, Vector256Constants.YGroup2Unzip_ShuffleX2_UInt64_X, data1);
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
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes | TypeCodeFlags.Int128 | TypeCodeFlags.UInt128;
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{ExInt128}, Vector256{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExInt128> YGroup2UnzipOdd(Vector256<ExInt128> data0, Vector256<ExInt128> data1) {
                return Avx.Permute2x128(data0.ExAsUInt64(), data1.ExAsUInt64(), (byte)ShuffleControl2X4Use4.YW).ExAsExInt128();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{ExUInt128}, Vector256{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExUInt128> YGroup2UnzipOdd(Vector256<ExUInt128> data0, Vector256<ExUInt128> data1) {
                return Avx.Permute2x128(data0.ExAsUInt64(), data1.ExAsUInt64(), (byte)ShuffleControl2X4Use4.YW).ExAsExUInt128();
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
                return Avx512F.VL.PermuteVar8x32x2(data0, Vector256Constants.YGroup2Unzip_ShuffleX2_UInt32_Y.AsInt32(), data1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2UnzipOdd(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2UnzipOdd_Permute(Vector256<double> data0, Vector256<double> data1) {
                VectorMessageFormats.ThrowForUnsupported(Avx512F.VL.IsSupported, "Avx512F, Avx512VL");
                return Avx512F.VL.PermuteVar4x64x2(data0, Vector256Constants.YGroup2Unzip_ShuffleX2_UInt64_Y.AsInt64(), data1);
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
                return Avx512Vbmi.VL.PermuteVar32x8x2(data0, Vector256Constants.YGroup2Unzip_ShuffleX2_Byte_Y, data1);
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
                return Avx512BW.VL.PermuteVar16x16x2(data0, Vector256Constants.YGroup2Unzip_ShuffleX2_UInt16_Y, data1);
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
                return Avx512F.VL.PermuteVar8x32x2(data0, Vector256Constants.YGroup2Unzip_ShuffleX2_UInt32_Y, data1);
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
                return Avx512F.VL.PermuteVar4x64x2(data0, Vector256Constants.YGroup2Unzip_ShuffleX2_UInt64_Y, data1);
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
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes | TypeCodeFlags.Int128 | TypeCodeFlags.UInt128;
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{ExInt128}, Vector256{ExInt128}, out Vector256{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExInt128> YGroup2Zip(Vector256<ExInt128> x, Vector256<ExInt128> y, out Vector256<ExInt128> data1) {
                var d0 = YGroup2Zip(x.ExAsExUInt128(), y.ExAsExUInt128(), out var d1);
                data1 = d1.ExAsExInt128();
                return d0.ExAsExInt128();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{ExUInt128}, Vector256{ExUInt128}, out Vector256{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExUInt128> YGroup2Zip(Vector256<ExUInt128> x, Vector256<ExUInt128> y, out Vector256<ExUInt128> data1) {
                var d0 = Avx.Permute2x128(x.ExAsUInt64(), y.ExAsUInt64(), (byte)ShuffleControl2X4Use4.XZ);
                var d1 = Avx.Permute2x128(x.ExAsUInt64(), y.ExAsUInt64(), (byte)ShuffleControl2X4Use4.YW);
                data1 = d1.ExAsExUInt128();
                return d0.ExAsExUInt128();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip_Int128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<T> YGroup2Zip_Int128<T>(Vector256<T> x, Vector256<T> y, out Vector256<T> data1) where T : struct {
#if EX_APPLY_GENERIC
                var d0 = YGroup2Zip(x.ExAsExUInt128(), y.ExAsExUInt128(), out var d1);
                data1 = d1.ExAs<ExUInt128, T>();
                return d0.ExAs<ExUInt128, T>();
#else
                var d0 = Avx.Permute2x128(x.AsUInt64(), y.AsUInt64(), (byte)ShuffleControl2X4Use4.XZ);
                var d1 = Avx.Permute2x128(x.AsUInt64(), y.AsUInt64(), (byte)ShuffleControl2X4Use4.YW);
                data1 = d1.As<ulong, T>();
                return d0.As<ulong, T>();
#endif // EX_APPLY_GENERIC
            }

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{float}, Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2Zip_Permute(Vector256<float> x, Vector256<float> y, out Vector256<float> data1) {
                VectorMessageFormats.ThrowForUnsupported(Avx512F.VL.IsSupported, "Avx512F, Avx512VL");
                var data0 = Avx512F.VL.PermuteVar8x32x2(x, Vector256Constants.YGroup2Zip_ShuffleX2_UInt32_Data0.AsInt32(), y);
                data1 = Avx512F.VL.PermuteVar8x32x2(x, Vector256Constants.YGroup2Zip_ShuffleX2_UInt32_Data1.AsInt32(), y);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2Zip(Vector256{double}, Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2Zip_Permute(Vector256<double> x, Vector256<double> y, out Vector256<double> data1) {
                VectorMessageFormats.ThrowForUnsupported(Avx512F.VL.IsSupported, "Avx512F, Avx512VL");
                var data0 = Avx512F.VL.PermuteVar4x64x2(x, Vector256Constants.YGroup2Zip_ShuffleX2_UInt64_Data0.AsInt64(), y);
                data1 = Avx512F.VL.PermuteVar4x64x2(x, Vector256Constants.YGroup2Zip_ShuffleX2_UInt64_Data1.AsInt64(), y);
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
                var data0 = Avx512Vbmi.VL.PermuteVar32x8x2(x, Vector256Constants.YGroup2Zip_ShuffleX2_Byte_Data0, y);
                data1 = Avx512Vbmi.VL.PermuteVar32x8x2(x, Vector256Constants.YGroup2Zip_ShuffleX2_Byte_Data1, y);
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
                var data0 = Avx512BW.VL.PermuteVar16x16x2(x, Vector256Constants.YGroup2Zip_ShuffleX2_UInt16_Data0, y);
                data1 = Avx512BW.VL.PermuteVar16x16x2(x, Vector256Constants.YGroup2Zip_ShuffleX2_UInt16_Data1, y);
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
                var data0 = Avx512F.VL.PermuteVar8x32x2(x, Vector256Constants.YGroup2Zip_ShuffleX2_UInt32_Data0, y);
                data1 = Avx512F.VL.PermuteVar8x32x2(x, Vector256Constants.YGroup2Zip_ShuffleX2_UInt32_Data1, y);
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
                var data0 = Avx512F.VL.PermuteVar4x64x2(x, Vector256Constants.YGroup2Zip_ShuffleX2_UInt64_Data0, y);
                data1 = Avx512F.VL.PermuteVar4x64x2(x, Vector256Constants.YGroup2Zip_ShuffleX2_UInt64_Data1, y);
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
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes | TypeCodeFlags.Int128 | TypeCodeFlags.UInt128;
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{ExInt128}, Vector256{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExInt128> YGroup2ZipHigh(Vector256<ExInt128> x, Vector256<ExInt128> y) {
                return Avx.Permute2x128(x.ExAsUInt64(), y.ExAsUInt64(), (byte)ShuffleControl2X4Use4.YW).ExAsExInt128();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{ExUInt128}, Vector256{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExUInt128> YGroup2ZipHigh(Vector256<ExUInt128> x, Vector256<ExUInt128> y) {
                return Avx.Permute2x128(x.ExAsUInt64(), y.ExAsUInt64(), (byte)ShuffleControl2X4Use4.YW).ExAsExUInt128();
            }

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2ZipHigh_Permute(Vector256<float> x, Vector256<float> y) {
                //return YGroup2ZipHigh_Permute(x.AsUInt32(), y.AsUInt32()).AsSingle();
                VectorMessageFormats.ThrowForUnsupported(Avx512F.VL.IsSupported, "Avx512F, Avx512VL");
                return Avx512F.VL.PermuteVar8x32x2(x, Vector256Constants.YGroup2Zip_ShuffleX2_UInt32_Data1.AsInt32(), y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipHigh(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2ZipHigh_Permute(Vector256<double> x, Vector256<double> y) {
                //return YGroup2ZipHigh_Permute(x.AsUInt64(), y.AsUInt64()).AsDouble();
                VectorMessageFormats.ThrowForUnsupported(Avx512F.VL.IsSupported, "Avx512F, Avx512VL");
                return Avx512F.VL.PermuteVar4x64x2(x, Vector256Constants.YGroup2Zip_ShuffleX2_UInt64_Data1.AsInt64(), y);
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
                return Avx512Vbmi.VL.PermuteVar32x8x2(x, Vector256Constants.YGroup2Zip_ShuffleX2_Byte_Data1, y);
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
                return Avx512BW.VL.PermuteVar16x16x2(x, Vector256Constants.YGroup2Zip_ShuffleX2_UInt16_Data1, y);
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
                return Avx512F.VL.PermuteVar8x32x2(x, Vector256Constants.YGroup2Zip_ShuffleX2_UInt32_Data1, y);
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
                return Avx512F.VL.PermuteVar4x64x2(x, Vector256Constants.YGroup2Zip_ShuffleX2_UInt64_Data1, y);
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
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes | TypeCodeFlags.Int128 | TypeCodeFlags.UInt128;
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{ExInt128}, Vector256{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExInt128> YGroup2ZipLow(Vector256<ExInt128> x, Vector256<ExInt128> y) {
                return Avx.Permute2x128(x.ExAsUInt64(), y.ExAsUInt64(), (byte)ShuffleControl2X4Use4.XZ).ExAsExInt128();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{ExUInt128}, Vector256{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExUInt128> YGroup2ZipLow(Vector256<ExUInt128> x, Vector256<ExUInt128> y) {
                return Avx.Permute2x128(x.ExAsUInt64(), y.ExAsUInt64(), (byte)ShuffleControl2X4Use4.XZ).ExAsExUInt128();
            }

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup2ZipLow_Permute(Vector256<float> x, Vector256<float> y) {
                //return YGroup2ZipLow_Permute(x.AsUInt32(), y.AsUInt32()).AsSingle();
                VectorMessageFormats.ThrowForUnsupported(Avx512F.VL.IsSupported, "Avx512F, Avx512VL");
                return Avx512F.VL.PermuteVar8x32x2(x, Vector256Constants.YGroup2Zip_ShuffleX2_UInt32_Data0.AsInt32(), y);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup2ZipLow(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup2ZipLow_Permute(Vector256<double> x, Vector256<double> y) {
                //return YGroup2ZipLow_Permute(x.AsUInt64(), y.AsUInt64()).AsDouble();
                VectorMessageFormats.ThrowForUnsupported(Avx512F.VL.IsSupported, "Avx512F, Avx512VL");
                return Avx512F.VL.PermuteVar4x64x2(x, Vector256Constants.YGroup2Zip_ShuffleX2_UInt64_Data0.AsInt64(), y);
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
                return Avx512Vbmi.VL.PermuteVar32x8x2(x, Vector256Constants.YGroup2Zip_ShuffleX2_Byte_Data0, y);
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
                return Avx512BW.VL.PermuteVar16x16x2(x, Vector256Constants.YGroup2Zip_ShuffleX2_UInt16_Data0, y);
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
                return Avx512F.VL.PermuteVar8x32x2(x, Vector256Constants.YGroup2Zip_ShuffleX2_UInt32_Data0, y);
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
                return Avx512F.VL.PermuteVar4x64x2(x, Vector256Constants.YGroup2Zip_ShuffleX2_UInt64_Data0, y);
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


            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup3Unzip_AcceleratedTypes {
                get {
                    return YGroup2Unzip_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{float}, Vector256{float}, Vector256{float}, out Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup3Unzip(Vector256<float> data0, Vector256<float> data1, Vector256<float> data2, out Vector256<float> y, out Vector256<float> z) {
                return YGroup3Unzip_ByShorter(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{double}, Vector256{double}, Vector256{double}, out Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup3Unzip(Vector256<double> data0, Vector256<double> data1, Vector256<double> data2, out Vector256<double> y, out Vector256<double> z) {
                return YGroup3Unzip_ByShorter(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup3Unzip(Vector256<sbyte> data0, Vector256<sbyte> data1, Vector256<sbyte> data2, out Vector256<sbyte> y, out Vector256<sbyte> z) {
                return YGroup3Unzip_ByShorter(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup3Unzip(Vector256<byte> data0, Vector256<byte> data1, Vector256<byte> data2, out Vector256<byte> y, out Vector256<byte> z) {
                return YGroup3Unzip_ByShorter(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup3Unzip(Vector256<short> data0, Vector256<short> data1, Vector256<short> data2, out Vector256<short> y, out Vector256<short> z) {
                return YGroup3Unzip_ByShorter(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup3Unzip(Vector256<ushort> data0, Vector256<ushort> data1, Vector256<ushort> data2, out Vector256<ushort> y, out Vector256<ushort> z) {
                return YGroup3Unzip_ByShorter(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup3Unzip(Vector256<int> data0, Vector256<int> data1, Vector256<int> data2, out Vector256<int> y, out Vector256<int> z) {
                return YGroup3Unzip_ByShorter(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup3Unzip(Vector256<uint> data0, Vector256<uint> data1, Vector256<uint> data2, out Vector256<uint> y, out Vector256<uint> z) {
                return YGroup3Unzip_ByShorter(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{long}, Vector256{long}, Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup3Unzip(Vector256<long> data0, Vector256<long> data1, Vector256<long> data2, out Vector256<long> y, out Vector256<long> z) {
                return YGroup3Unzip_ByShorter(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup3Unzip(Vector256<ulong> data0, Vector256<ulong> data1, Vector256<ulong> data2, out Vector256<ulong> y, out Vector256<ulong> z) {
                return YGroup3Unzip_ByShorter(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip_Int128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<T> YGroup3Unzip_Int128<T>(Vector256<T> data0, Vector256<T> data1, Vector256<T> data2, out Vector256<T> y, out Vector256<T> z) where T : struct {
                // f({x[0], y[0]}, {z[0], x[1]}, {y[1], z[1]}) = ({x[0], x[1]}, {y[0], y[1]}, {z[0], z[1]})
                var d0 = Avx.Permute2x128(data0.AsUInt64(), data1.AsUInt64(), (byte)ShuffleControl2X4Use4.XW);
                var d1 = Avx.Permute2x128(data0.AsUInt64(), data2.AsUInt64(), (byte)ShuffleControl2X4Use4.YZ);
                var d2 = Avx.Permute2x128(data1.AsUInt64(), data2.AsUInt64(), (byte)ShuffleControl2X4Use4.XW);
                y = d1.As<ulong, T>();
                z = d2.As<ulong, T>();
                return d0.As<ulong, T>();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{float}, Vector256{float}, Vector256{float}, out Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup3Unzip_ByShorter(Vector256<float> data0, Vector256<float> data1, Vector256<float> data2, out Vector256<float> y, out Vector256<float> z) {
                // TODO: Implements YGroup3Unzip_ByShorter
                return SuperStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{double}, Vector256{double}, Vector256{double}, out Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup3Unzip_ByShorter(Vector256<double> data0, Vector256<double> data1, Vector256<double> data2, out Vector256<double> y, out Vector256<double> z) {
                return SuperStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup3Unzip_ByShorter(Vector256<sbyte> data0, Vector256<sbyte> data1, Vector256<sbyte> data2, out Vector256<sbyte> y, out Vector256<sbyte> z) {
                return SuperStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup3Unzip_ByShorter(Vector256<byte> data0, Vector256<byte> data1, Vector256<byte> data2, out Vector256<byte> y, out Vector256<byte> z) {
                return SuperStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup3Unzip_ByShorter(Vector256<short> data0, Vector256<short> data1, Vector256<short> data2, out Vector256<short> y, out Vector256<short> z) {
                return SuperStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup3Unzip_ByShorter(Vector256<ushort> data0, Vector256<ushort> data1, Vector256<ushort> data2, out Vector256<ushort> y, out Vector256<ushort> z) {
                return SuperStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup3Unzip_ByShorter(Vector256<int> data0, Vector256<int> data1, Vector256<int> data2, out Vector256<int> y, out Vector256<int> z) {
                return SuperStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup3Unzip_ByShorter(Vector256<uint> data0, Vector256<uint> data1, Vector256<uint> data2, out Vector256<uint> y, out Vector256<uint> z) {
                return SuperStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{long}, Vector256{long}, Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup3Unzip_ByShorter(Vector256<long> data0, Vector256<long> data1, Vector256<long> data2, out Vector256<long> y, out Vector256<long> z) {
                return SuperStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3Unzip(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup3Unzip_ByShorter(Vector256<ulong> data0, Vector256<ulong> data1, Vector256<ulong> data2, out Vector256<ulong> y, out Vector256<ulong> z) {
                return SuperStatics.YGroup3Unzip(data0, data1, data2, out y, out z);
            }


            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup3UnzipX2_AcceleratedTypes {
                get {
                    return YGroup2Zip_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup3UnzipX2(Vector256<float> data0, Vector256<float> data1, Vector256<float> data2, Vector256<float> data3, Vector256<float> data4, Vector256<float> data5, out Vector256<float> xB, out Vector256<float> y, out Vector256<float> yB, out Vector256<float> z, out Vector256<float> zB) {
                return YGroup3UnzipX2_Zip(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup3UnzipX2(Vector256<double> data0, Vector256<double> data1, Vector256<double> data2, Vector256<double> data3, Vector256<double> data4, Vector256<double> data5, out Vector256<double> xB, out Vector256<double> y, out Vector256<double> yB, out Vector256<double> z, out Vector256<double> zB) {
                return YGroup3UnzipX2_Zip(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup3UnzipX2(Vector256<sbyte> data0, Vector256<sbyte> data1, Vector256<sbyte> data2, Vector256<sbyte> data3, Vector256<sbyte> data4, Vector256<sbyte> data5, out Vector256<sbyte> xB, out Vector256<sbyte> y, out Vector256<sbyte> yB, out Vector256<sbyte> z, out Vector256<sbyte> zB) {
                return YGroup3UnzipX2_Zip(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup3UnzipX2(Vector256<byte> data0, Vector256<byte> data1, Vector256<byte> data2, Vector256<byte> data3, Vector256<byte> data4, Vector256<byte> data5, out Vector256<byte> xB, out Vector256<byte> y, out Vector256<byte> yB, out Vector256<byte> z, out Vector256<byte> zB) {
                return YGroup3UnzipX2_Zip(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup3UnzipX2(Vector256<short> data0, Vector256<short> data1, Vector256<short> data2, Vector256<short> data3, Vector256<short> data4, Vector256<short> data5, out Vector256<short> xB, out Vector256<short> y, out Vector256<short> yB, out Vector256<short> z, out Vector256<short> zB) {
                return YGroup3UnzipX2_Zip(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup3UnzipX2(Vector256<ushort> data0, Vector256<ushort> data1, Vector256<ushort> data2, Vector256<ushort> data3, Vector256<ushort> data4, Vector256<ushort> data5, out Vector256<ushort> xB, out Vector256<ushort> y, out Vector256<ushort> yB, out Vector256<ushort> z, out Vector256<ushort> zB) {
                return YGroup3UnzipX2_Zip(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup3UnzipX2(Vector256<int> data0, Vector256<int> data1, Vector256<int> data2, Vector256<int> data3, Vector256<int> data4, Vector256<int> data5, out Vector256<int> xB, out Vector256<int> y, out Vector256<int> yB, out Vector256<int> z, out Vector256<int> zB) {
                return YGroup3UnzipX2_Zip(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup3UnzipX2(Vector256<uint> data0, Vector256<uint> data1, Vector256<uint> data2, Vector256<uint> data3, Vector256<uint> data4, Vector256<uint> data5, out Vector256<uint> xB, out Vector256<uint> y, out Vector256<uint> yB, out Vector256<uint> z, out Vector256<uint> zB) {
                return YGroup3UnzipX2_Zip(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup3UnzipX2(Vector256<long> data0, Vector256<long> data1, Vector256<long> data2, Vector256<long> data3, Vector256<long> data4, Vector256<long> data5, out Vector256<long> xB, out Vector256<long> y, out Vector256<long> yB, out Vector256<long> z, out Vector256<long> zB) {
                return YGroup3UnzipX2_Zip(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup3UnzipX2(Vector256<ulong> data0, Vector256<ulong> data1, Vector256<ulong> data2, Vector256<ulong> data3, Vector256<ulong> data4, Vector256<ulong> data5, out Vector256<ulong> xB, out Vector256<ulong> y, out Vector256<ulong> yB, out Vector256<ulong> z, out Vector256<ulong> zB) {
                return YGroup3UnzipX2_Zip(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2_Int128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<T> YGroup3UnzipX2_Int128<T>(Vector256<T> data0, Vector256<T> data1, Vector256<T> data2, Vector256<T> data3, Vector256<T> data4, Vector256<T> data5, out Vector256<T> xB, out Vector256<T> y, out Vector256<T> yB, out Vector256<T> z, out Vector256<T> zB) where T : struct {
                var x = YGroup3Unzip_Int128(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip_Int128(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup3UnzipX2_Zip(Vector256<float> data0, Vector256<float> data1, Vector256<float> data2, Vector256<float> data3, Vector256<float> data4, Vector256<float> data5, out Vector256<float> xB, out Vector256<float> y, out Vector256<float> yB, out Vector256<float> z, out Vector256<float> zB) {
                Vector256<float> a_0, a_1, a_2, a_3, a_4, a_5, b_0, b_1, b_2, b_3, b_4, b_5;
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup3UnzipX2_Zip(Vector256<double> data0, Vector256<double> data1, Vector256<double> data2, Vector256<double> data3, Vector256<double> data4, Vector256<double> data5, out Vector256<double> xB, out Vector256<double> y, out Vector256<double> yB, out Vector256<double> z, out Vector256<double> zB) {
                Vector256<double> a_0, a_1, a_2, a_3, a_4, a_5, b_0, b_1, b_2, b_3, b_4, b_5;
                // 0 data0 x0 y0 z0 x1 data1 y1 z1 x2 y2 data2 z2 x3 y3 z3 data3 x4 y4 z4 x5 data4 y5 z5 x6 y6 data5 z6 x7 y7 z7
                // 1 a_0 x0 x4 y0 y4 a_1 z0 z4 x1 x5 a_2 y1 y5 z1 z5 a_3 x2 x6 y2 y6 a_4 z2 z6 x3 x7 a_5 y3 y7 z3 z7
                a_0 = YGroup2Zip(data0, data3, out a_1);
                a_2 = YGroup2Zip(data1, data4, out a_3);
                a_4 = YGroup2Zip(data2, data5, out a_5);
                // 2 b_0 x0 x2 x4 x6 b_1 y0 y2 y4 y6 b_2 z0 z2 z4 z6 b_3 x1 x3 x5 x7 b_4 y1 y3 y5 y7 b_5 z1 z3 z5 z7
                b_0 = YGroup2Zip(a_0, a_3, out b_1);
                b_2 = YGroup2Zip(a_1, a_4, out b_3);
                b_4 = YGroup2Zip(a_2, a_5, out b_5);
                // 3 a_0 x0 x1 x2 x3 a_1 x4 x5 x6 x7 a_2 y0 y1 y2 y3 a_3 y4 y5 y6 y7 a_4 z0 z1 z2 z3 a_5 z4 z5 z6 z7
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup3UnzipX2_Zip(Vector256<long> data0, Vector256<long> data1, Vector256<long> data2, Vector256<long> data3, Vector256<long> data4, Vector256<long> data5, out Vector256<long> xB, out Vector256<long> y, out Vector256<long> yB, out Vector256<long> z, out Vector256<long> zB) {
                var d0 = YGroup3UnzipX2_Zip(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), data3.AsUInt64(), data4.AsUInt64(), data5.AsUInt64(), out var d1, out var d2, out var d3, out var d4, out var d5);
                xB = d1.AsInt64();
                y = d2.AsInt64();
                yB = d3.AsInt64();
                z = d4.AsInt64();
                zB = d5.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup3UnzipX2(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup3UnzipX2_Zip(Vector256<ulong> data0, Vector256<ulong> data1, Vector256<ulong> data2, Vector256<ulong> data3, Vector256<ulong> data4, Vector256<ulong> data5, out Vector256<ulong> xB, out Vector256<ulong> y, out Vector256<ulong> yB, out Vector256<ulong> z, out Vector256<ulong> zB) {
                Vector256<ulong> a_0, a_1, a_2, a_3, a_4, a_5, b_0, b_1, b_2, b_3, b_4, b_5;
                // 0 data0 x0 y0 z0 x1 data1 y1 z1 x2 y2 data2 z2 x3 y3 z3 data3 x4 y4 z4 x5 data4 y5 z5 x6 y6 data5 z6 x7 y7 z7
                // 1 a_0 x0 x4 y0 y4 a_1 z0 z4 x1 x5 a_2 y1 y5 z1 z5 a_3 x2 x6 y2 y6 a_4 z2 z6 x3 x7 a_5 y3 y7 z3 z7
                a_0 = YGroup2Zip(data0, data3, out a_1);
                a_2 = YGroup2Zip(data1, data4, out a_3);
                a_4 = YGroup2Zip(data2, data5, out a_5);
                // 2 b_0 x0 x2 x4 x6 b_1 y0 y2 y4 y6 b_2 z0 z2 z4 z6 b_3 x1 x3 x5 x7 b_4 y1 y3 y5 y7 b_5 z1 z3 z5 z7
                b_0 = YGroup2Zip(a_0, a_3, out b_1);
                b_2 = YGroup2Zip(a_1, a_4, out b_3);
                b_4 = YGroup2Zip(a_2, a_5, out b_5);
                // 3 a_0 x0 x1 x2 x3 a_1 x4 x5 x6 x7 a_2 y0 y1 y2 y3 a_3 y4 y5 y6 y7 a_4 z0 z1 z2 z3 a_5 z4 z5 z6 z7
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


            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup4Unzip_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes | TypeCodeFlags.Int128 | TypeCodeFlags.UInt128;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup4Unzip(Vector256<float> data0, Vector256<float> data1, Vector256<float> data2, Vector256<float> data3, out Vector256<float> y, out Vector256<float> z, out Vector256<float> w) {
#if NET8_0_OR_GREATER
                if (Avx512F.IsSupported) {
                    return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
                }
#endif // NET8_0_OR_GREATER
                return YGroup4Unzip_Unpack(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup4Unzip(Vector256<double> data0, Vector256<double> data1, Vector256<double> data2, Vector256<double> data3, out Vector256<double> y, out Vector256<double> z, out Vector256<double> w) {
#if NET8_0_OR_GREATER
                if (Avx512F.IsSupported) {
                    return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
                }
#endif // NET8_0_OR_GREATER
                return YGroup4Unzip_Unpack(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup4Unzip(Vector256<sbyte> data0, Vector256<sbyte> data1, Vector256<sbyte> data2, Vector256<sbyte> data3, out Vector256<sbyte> y, out Vector256<sbyte> z, out Vector256<sbyte> w) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.IsSupported) {
                    return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
                }
#endif // NET8_0_OR_GREATER
                return YGroup4Unzip_Narrow(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup4Unzip(Vector256<byte> data0, Vector256<byte> data1, Vector256<byte> data2, Vector256<byte> data3, out Vector256<byte> y, out Vector256<byte> z, out Vector256<byte> w) {
                // None Avx512: _Unpack > _Unzip > _Narrow
                // Have Avx512: _Unzip > _PermuteLonger > _Unpack > _Narrow
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.IsSupported) {
                    return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
                }
#endif // NET8_0_OR_GREATER
                return YGroup4Unzip_Unpack(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup4Unzip(Vector256<short> data0, Vector256<short> data1, Vector256<short> data2, Vector256<short> data3, out Vector256<short> y, out Vector256<short> z, out Vector256<short> w) {
#if NET8_0_OR_GREATER
                if (Avx512BW.IsSupported) {
                    return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
                }
#endif // NET8_0_OR_GREATER
                return YGroup4Unzip_Unpack(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup4Unzip(Vector256<ushort> data0, Vector256<ushort> data1, Vector256<ushort> data2, Vector256<ushort> data3, out Vector256<ushort> y, out Vector256<ushort> z, out Vector256<ushort> w) {
#if NET8_0_OR_GREATER
                if (Avx512BW.IsSupported) {
                    return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
                }
#endif // NET8_0_OR_GREATER
                return YGroup4Unzip_Unpack(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup4Unzip(Vector256<int> data0, Vector256<int> data1, Vector256<int> data2, Vector256<int> data3, out Vector256<int> y, out Vector256<int> z, out Vector256<int> w) {
#if NET8_0_OR_GREATER
                if (Avx512F.IsSupported) {
                    return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
                }
#endif // NET8_0_OR_GREATER
                return YGroup4Unzip_Unpack(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup4Unzip(Vector256<uint> data0, Vector256<uint> data1, Vector256<uint> data2, Vector256<uint> data3, out Vector256<uint> y, out Vector256<uint> z, out Vector256<uint> w) {
#if NET8_0_OR_GREATER
                if (Avx512F.IsSupported) {
                    return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
                }
#endif // NET8_0_OR_GREATER
                return YGroup4Unzip_Unpack(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup4Unzip(Vector256<long> data0, Vector256<long> data1, Vector256<long> data2, Vector256<long> data3, out Vector256<long> y, out Vector256<long> z, out Vector256<long> w) {
                // None Avx512: _Unpack > _Unzip > _Narrow
                // Have Avx512: _Unpack > _Unzip > _PermuteLonger > _Narrow
#if NET8_0_OR_GREATER
                //if (Avx512F.IsSupported) {
                //    return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
                //}
#endif // NET8_0_OR_GREATER
                return YGroup4Unzip_Unpack(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup4Unzip(Vector256<ulong> data0, Vector256<ulong> data1, Vector256<ulong> data2, Vector256<ulong> data3, out Vector256<ulong> y, out Vector256<ulong> z, out Vector256<ulong> w) {
#if NET8_0_OR_GREATER
                //if (Avx512F.IsSupported) {
                //    return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
                //}
#endif // NET8_0_OR_GREATER
                return YGroup4Unzip_Unpack(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{ExInt128}, Vector256{ExInt128}, Vector256{ExInt128}, Vector256{ExInt128}, out Vector256{ExInt128}, out Vector256{ExInt128}, out Vector256{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExInt128> YGroup4Unzip(Vector256<ExInt128> data0, Vector256<ExInt128> data1, Vector256<ExInt128> data2, Vector256<ExInt128> data3, out Vector256<ExInt128> y, out Vector256<ExInt128> z, out Vector256<ExInt128> w) {
#if EX_APPLY_GENERIC
                return YGroup4Unzip_Int128(data0, data1, data2, data3, out y, out z, out w);
#else
                var d0 = YGroup4Unzip_Int128_On64(data0.ExAsUInt64(), data1.ExAsUInt64(), data2.ExAsUInt64(), data3.ExAsUInt64(), out var d1, out var d2, out var d3);
                y = d1.ExAsExInt128();
                z = d2.ExAsExInt128();
                w = d3.ExAsExInt128();
                return d0.ExAsExInt128();
#endif // EX_APPLY_GENERIC
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{ExUInt128}, Vector256{ExUInt128}, Vector256{ExUInt128}, Vector256{ExUInt128}, out Vector256{ExUInt128}, out Vector256{ExUInt128}, out Vector256{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExUInt128> YGroup4Unzip(Vector256<ExUInt128> data0, Vector256<ExUInt128> data1, Vector256<ExUInt128> data2, Vector256<ExUInt128> data3, out Vector256<ExUInt128> y, out Vector256<ExUInt128> z, out Vector256<ExUInt128> w) {
#if EX_APPLY_GENERIC
                return YGroup4Unzip_Int128(data0, data1, data2, data3, out y, out z, out w);
#else
                var d0 = YGroup4Unzip_Int128_On64(data0.ExAsUInt64(), data1.ExAsUInt64(), data2.ExAsUInt64(), data3.ExAsUInt64(), out var d1, out var d2, out var d3);
                y = d1.ExAsExUInt128();
                z = d2.ExAsExUInt128();
                w = d3.ExAsExUInt128();
                return d0.ExAsExUInt128();
#endif // EX_APPLY_GENERIC
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip_Int128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<T> YGroup4Unzip_Int128<T>(Vector256<T> data0, Vector256<T> data1, Vector256<T> data2, Vector256<T> data3, out Vector256<T> y, out Vector256<T> z, out Vector256<T> w) where T : struct {
#if EX_APPLY_GENERIC
                var d0 = YGroup4Unzip_Int128_On64(data0.ExAs<T, ulong>(), data1.ExAs<T, ulong>(), data2.ExAs<T, ulong>(), data3.ExAs<T, ulong>(), out var d1, out var d2, out var d3);
                y = d1.ExAs<ulong, T>();
                z = d2.ExAs<ulong, T>();
                w = d3.ExAs<ulong, T>();
                return d0.ExAs<ulong, T>();
#else
                var d0 = YGroup4Unzip_Int128_On64(data0.As<T, ulong>(), data1.As<T, ulong>(), data2.As<T, ulong>(), data3.As<T, ulong>(), out var d1, out var d2, out var d3);
                y = d1.As<ulong, T>();
                z = d2.As<ulong, T>();
                w = d3.As<ulong, T>();
                return d0.As<ulong, T>();
#endif // EX_APPLY_GENERIC
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip_Int128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static Vector256<ulong> YGroup4Unzip_Int128_On64(Vector256<ulong> data0, Vector256<ulong> data1, Vector256<ulong> data2, Vector256<ulong> data3, out Vector256<ulong> y, out Vector256<ulong> z, out Vector256<ulong> w) {
                var d0 = Avx.Permute2x128(data0, data2, (byte)ShuffleControl2X4Use4.XZ);
                var d1 = Avx.Permute2x128(data0, data2, (byte)ShuffleControl2X4Use4.YW);
                var d2 = Avx.Permute2x128(data1, data3, (byte)ShuffleControl2X4Use4.XZ);
                var d3 = Avx.Permute2x128(data1, data3, (byte)ShuffleControl2X4Use4.YW);
                y = d1;
                z = d2;
                w = d3;
                return d0;
            }

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
                rt0 = Narrow(Narrow(temp0, temp1), Narrow(temp2, temp3));
                temp0 = Avx2.ShiftRightLogical(temp0, L);
                temp1 = Avx2.ShiftRightLogical(temp1, L);
                temp2 = Avx2.ShiftRightLogical(temp2, L);
                temp3 = Avx2.ShiftRightLogical(temp3, L);
                rt1 = Narrow(Narrow(temp0, temp1), Narrow(temp2, temp3));
                temp0 = Avx2.ShiftRightLogical(temp0, L);
                temp1 = Avx2.ShiftRightLogical(temp1, L);
                temp2 = Avx2.ShiftRightLogical(temp2, L);
                temp3 = Avx2.ShiftRightLogical(temp3, L);
                rt2 = Narrow(Narrow(temp0, temp1), Narrow(temp2, temp3));
                temp0 = Avx2.ShiftRightLogical(temp0, L);
                temp1 = Avx2.ShiftRightLogical(temp1, L);
                temp2 = Avx2.ShiftRightLogical(temp2, L);
                temp3 = Avx2.ShiftRightLogical(temp3, L);
                rt3 = Narrow(Narrow(temp0, temp1), Narrow(temp2, temp3));
                y = rt1;
                z = rt2;
                w = rt3;
                return rt0;
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
                rt0 = Narrow(Narrow(temp0, temp1), Narrow(temp2, temp3));
                temp0 = Avx2.ShiftRightLogical(temp0, L);
                temp1 = Avx2.ShiftRightLogical(temp1, L);
                temp2 = Avx2.ShiftRightLogical(temp2, L);
                temp3 = Avx2.ShiftRightLogical(temp3, L);
                rt1 = Narrow(Narrow(temp0, temp1), Narrow(temp2, temp3));
                temp0 = Avx2.ShiftRightLogical(temp0, L);
                temp1 = Avx2.ShiftRightLogical(temp1, L);
                temp2 = Avx2.ShiftRightLogical(temp2, L);
                temp3 = Avx2.ShiftRightLogical(temp3, L);
                rt2 = Narrow(Narrow(temp0, temp1), Narrow(temp2, temp3));
                temp0 = Avx2.ShiftRightLogical(temp0, L);
                temp1 = Avx2.ShiftRightLogical(temp1, L);
                temp2 = Avx2.ShiftRightLogical(temp2, L);
                temp3 = Avx2.ShiftRightLogical(temp3, L);
                rt3 = Narrow(Narrow(temp0, temp1), Narrow(temp2, temp3));
                y = rt1;
                z = rt2;
                w = rt3;
                return rt0;
            }

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup4Unzip_PermuteLonger(Vector256<float> data0, Vector256<float> data1, Vector256<float> data2, Vector256<float> data3, out Vector256<float> y, out Vector256<float> z, out Vector256<float> w) {
                var d0 = YGroup4Unzip_PermuteLonger(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), out var d1, out var d2, out var d3);
                y = d1.AsSingle();
                z = d2.AsSingle();
                w = d3.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup4Unzip_PermuteLonger(Vector256<double> data0, Vector256<double> data1, Vector256<double> data2, Vector256<double> data3, out Vector256<double> y, out Vector256<double> z, out Vector256<double> w) {
                var d0 = YGroup4Unzip_PermuteLonger(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), data3.AsUInt64(), out var d1, out var d2, out var d3);
                y = d1.AsDouble();
                z = d2.AsDouble();
                w = d3.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup4Unzip_PermuteLonger(Vector256<sbyte> data0, Vector256<sbyte> data1, Vector256<sbyte> data2, Vector256<sbyte> data3, out Vector256<sbyte> y, out Vector256<sbyte> z, out Vector256<sbyte> w) {
                var d0 = YGroup4Unzip_PermuteLonger(data0.AsByte(), data1.AsByte(), data2.AsByte(), data3.AsByte(), out var d1, out var d2, out var d3);
                y = d1.AsSByte();
                z = d2.AsSByte();
                w = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup4Unzip_PermuteLonger(Vector256<byte> data0, Vector256<byte> data1, Vector256<byte> data2, Vector256<byte> data3, out Vector256<byte> y, out Vector256<byte> z, out Vector256<byte> w) {
                VectorMessageFormats.ThrowForUnsupported(Avx512Vbmi.IsSupported, "Avx512Vbmi");
                var a0 = data0.ToVector512Unsafe().WithUpper(data1);
                var a1 = data2.ToVector512Unsafe().WithUpper(data3);
                var b0 = Avx512Vbmi.PermuteVar64x8x2(a0, Vector512Constants.YGroup4Unzip_ShuffleX2Longer_Byte_XY, a1);
                var b1 = Avx512Vbmi.PermuteVar64x8x2(a0, Vector512Constants.YGroup4Unzip_ShuffleX2Longer_Byte_ZW, a1);
                y = b0.GetUpper();
                z = b1.GetLower();
                w = b1.GetUpper();
                return b0.GetLower();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup4Unzip_PermuteLonger(Vector256<short> data0, Vector256<short> data1, Vector256<short> data2, Vector256<short> data3, out Vector256<short> y, out Vector256<short> z, out Vector256<short> w) {
                var d0 = YGroup4Unzip_PermuteLonger(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), data3.AsUInt16(), out var d1, out var d2, out var d3);
                y = d1.AsInt16();
                z = d2.AsInt16();
                w = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup4Unzip_PermuteLonger(Vector256<ushort> data0, Vector256<ushort> data1, Vector256<ushort> data2, Vector256<ushort> data3, out Vector256<ushort> y, out Vector256<ushort> z, out Vector256<ushort> w) {
                VectorMessageFormats.ThrowForUnsupported(Avx512BW.IsSupported, "Avx512BW");
                var a0 = data0.ToVector512Unsafe().WithUpper(data1);
                var a1 = data2.ToVector512Unsafe().WithUpper(data3);
                var b0 = Avx512BW.PermuteVar32x16x2(a0, Vector512Constants.YGroup4Unzip_ShuffleX2Longer_UInt16_XY, a1);
                var b1 = Avx512BW.PermuteVar32x16x2(a0, Vector512Constants.YGroup4Unzip_ShuffleX2Longer_UInt16_ZW, a1);
                y = b0.GetUpper();
                z = b1.GetLower();
                w = b1.GetUpper();
                return b0.GetLower();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup4Unzip_PermuteLonger(Vector256<int> data0, Vector256<int> data1, Vector256<int> data2, Vector256<int> data3, out Vector256<int> y, out Vector256<int> z, out Vector256<int> w) {
                var d0 = YGroup4Unzip_PermuteLonger(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), out var d1, out var d2, out var d3);
                y = d1.AsInt32();
                z = d2.AsInt32();
                w = d3.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup4Unzip_PermuteLonger(Vector256<uint> data0, Vector256<uint> data1, Vector256<uint> data2, Vector256<uint> data3, out Vector256<uint> y, out Vector256<uint> z, out Vector256<uint> w) {
                VectorMessageFormats.ThrowForUnsupported(Avx512F.IsSupported, "Avx512F");
                var a0 = data0.ToVector512Unsafe().WithUpper(data1);
                var a1 = data2.ToVector512Unsafe().WithUpper(data3);
                var b0 = Avx512F.PermuteVar16x32x2(a0, Vector512Constants.YGroup4Unzip_ShuffleX2Longer_UInt32_XY, a1);
                var b1 = Avx512F.PermuteVar16x32x2(a0, Vector512Constants.YGroup4Unzip_ShuffleX2Longer_UInt32_ZW, a1);
                y = b0.GetUpper();
                z = b1.GetLower();
                w = b1.GetUpper();
                return b0.GetLower();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup4Unzip_PermuteLonger(Vector256<long> data0, Vector256<long> data1, Vector256<long> data2, Vector256<long> data3, out Vector256<long> y, out Vector256<long> z, out Vector256<long> w) {
                var d0 = YGroup4Unzip_PermuteLonger(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), data3.AsUInt64(), out var d1, out var d2, out var d3);
                y = d1.AsInt64();
                z = d2.AsInt64();
                w = d3.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup4Unzip_PermuteLonger(Vector256<ulong> data0, Vector256<ulong> data1, Vector256<ulong> data2, Vector256<ulong> data3, out Vector256<ulong> y, out Vector256<ulong> z, out Vector256<ulong> w) {
                VectorMessageFormats.ThrowForUnsupported(Avx512F.IsSupported, "Avx512F");
                var a0 = data0.ToVector512Unsafe().WithUpper(data1);
                var a1 = data2.ToVector512Unsafe().WithUpper(data3);
                var b0 = Avx512F.PermuteVar8x64x2(a0, Vector512Constants.YGroup4Unzip_ShuffleX2Longer_UInt64_XY, a1);
                var b1 = Avx512F.PermuteVar8x64x2(a0, Vector512Constants.YGroup4Unzip_ShuffleX2Longer_UInt64_ZW, a1);
                y = b0.GetUpper();
                z = b1.GetLower();
                w = b1.GetUpper();
                return b0.GetLower();
            }

#endif // NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup4Unzip_Unpack(Vector256<float> data0, Vector256<float> data1, Vector256<float> data2, Vector256<float> data3, out Vector256<float> y, out Vector256<float> z, out Vector256<float> w) {
                var d0 = YGroup4Unzip_Unpack(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), out var d1, out var d2, out var d3);
                y = d1.AsSingle();
                z = d2.AsSingle();
                w = d3.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup4Unzip_Unpack(Vector256<double> data0, Vector256<double> data1, Vector256<double> data2, Vector256<double> data3, out Vector256<double> y, out Vector256<double> z, out Vector256<double> w) {
                var d0 = YGroup4Unzip_Unpack(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), data3.AsUInt64(), out var d1, out var d2, out var d3);
                y = d1.AsDouble();
                z = d2.AsDouble();
                w = d3.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup4Unzip_Unpack(Vector256<sbyte> data0, Vector256<sbyte> data1, Vector256<sbyte> data2, Vector256<sbyte> data3, out Vector256<sbyte> y, out Vector256<sbyte> z, out Vector256<sbyte> w) {
                var d0 = YGroup4Unzip_Unpack(data0.AsByte(), data1.AsByte(), data2.AsByte(), data3.AsByte(), out var d1, out var d2, out var d3);
                y = d1.AsSByte();
                z = d2.AsSByte();
                w = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup4Unzip_Unpack(Vector256<byte> data0, Vector256<byte> data1, Vector256<byte> data2, Vector256<byte> data3, out Vector256<byte> y, out Vector256<byte> z, out Vector256<byte> w) {
                Vector256<byte> temp0, temp1, temp2, temp3;
                Vector256<byte> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
                // Zip layer by 128-bits unpack.
                // 0: data0 x0 y0 z0 w0 x1 y1 z1 w1 x2 y2 z2 w2 x3 y3 z3 w3 x4 y4 z4 w4 x5 y5 z5 w5 x6 y6 z6 w6 x7 y7 z7 w7 data1 x8 y8 z8 w8 x9 y9 z9 w9 x10 y10 z10 w10 x11 y11 z11 w11 x12 y12 z12 w12 x13 y13 z13 w13 x14 y14 z14 w14 x15 y15 z15 w15 data2 x16 y16 z16 w16 x17 y17 z17 w17 x18 y18 z18 w18 x19 y19 z19 w19 x20 y20 z20 w20 x21 y21 z21 w21 x22 y22 z22 w22 x23 y23 z23 w23 data3 x24 y24 z24 w24 x25 y25 z25 w25 x26 y26 z26 w26 x27 y27 z27 w27 x28 y28 z28 w28 x29 y29 z29 w29 x30 y30 z30 w30 x31 y31 z31 w31
                //0b: temp0 x0 y0 z0 w0 x1 y1 z1 w1 x2 y2 z2 w2 x3 y3 z3 w3 x16 y16 z16 w16 x17 y17 z17 w17 x18 y18 z18 w18 x19 y19 z19 w19 temp1 x4 y4 z4 w4 x5 y5 z5 w5 x6 y6 z6 w6 x7 y7 z7 w7 x20 y20 z20 w20 x21 y21 z21 w21 x22 y22 z22 w22 x23 y23 z23 w23 temp2 x8 y8 z8 w8 x9 y9 z9 w9 x10 y10 z10 w10 x11 y11 z11 w11 x24 y24 z24 w24 x25 y25 z25 w25 x26 y26 z26 w26 x27 y27 z27 w27 temp3 x12 y12 z12 w12 x13 y13 z13 w13 x14 y14 z14 w14 x15 y15 z15 w15 x28 y28 z28 w28 x29 y29 z29 w29 x30 y30 z30 w30 x31 y31 z31 w31
                temp0 = YGroup4Unzip_Int128(data0, data1, data2, data3, out temp1, out temp2, out temp3);
                // 1: a_0 x0 x8 y0 y8 z0 z8 w0 w8 x1 x9 y1 y9 z1 z9 w1 w9 x16 x24 y16 y24 z16 z24 w16 w24 x17 x25 y17 y25 z17 z25 w17 w25 a_1 x2 x10 y2 y10 z2 z10 w2 w10 x3 x11 y3 y11 z3 z11 w3 w11 x18 x26 y18 y26 z18 z26 w18 w26 x19 x27 y19 y27 z19 z27 w19 w27 a_2 x4 x12 y4 y12 z4 z12 w4 w12 x5 x13 y5 y13 z5 z13 w5 w13 x20 x28 y20 y28 z20 z28 w20 w28 x21 x29 y21 y29 z21 z29 w21 w29 a_3 x6 x14 y6 y14 z6 z14 w6 w14 x7 x15 y7 y15 z7 z15 w7 w15 x22 x30 y22 y30 z22 z30 w22 w30 x23 x31 y23 y31 z23 z31 w23 w31
                a_0 = Avx2.UnpackLow(temp0, temp2);
                a_1 = Avx2.UnpackHigh(temp0, temp2);
                a_2 = Avx2.UnpackLow(temp1, temp3);
                a_3 = Avx2.UnpackHigh(temp1, temp3);
                // 2: b_0 x0 x4 x8 x12 y0 y4 y8 y12 z0 z4 z8 z12 w0 w4 w8 w12 x16 x20 x24 x28 y16 y20 y24 y28 z16 z20 z24 z28 w16 w20 w24 w28 b_1 x1 x5 x9 x13 y1 y5 y9 y13 z1 z5 z9 z13 w1 w5 w9 w13 x17 x21 x25 x29 y17 y21 y25 y29 z17 z21 z25 z29 w17 w21 w25 w29 b_2 x2 x6 x10 x14 y2 y6 y10 y14 z2 z6 z10 z14 w2 w6 w10 w14 x18 x22 x26 x30 y18 y22 y26 y30 z18 z22 z26 z30 w18 w22 w26 w30 b_3 x3 x7 x11 x15 y3 y7 y11 y15 z3 z7 z11 z15 w3 w7 w11 w15 x19 x23 x27 x31 y19 y23 y27 y31 z19 z23 z27 z31 w19 w23 w27 w31
                b_0 = Avx2.UnpackLow(a_0, a_2);
                b_1 = Avx2.UnpackHigh(a_0, a_2);
                b_2 = Avx2.UnpackLow(a_1, a_3);
                b_3 = Avx2.UnpackHigh(a_1, a_3);
                // 3: a_0 x0 x2 x4 x6 x8 x10 x12 x14 y0 y2 y4 y6 y8 y10 y12 y14 x16 x18 x20 x22 x24 x26 x28 x30 y16 y18 y20 y22 y24 y26 y28 y30 a_1 z0 z2 z4 z6 z8 z10 z12 z14 w0 w2 w4 w6 w8 w10 w12 w14 z16 z18 z20 z22 z24 z26 z28 z30 w16 w18 w20 w22 w24 w26 w28 w30 a_2 x1 x3 x5 x7 x9 x11 x13 x15 y1 y3 y5 y7 y9 y11 y13 y15 x17 x19 x21 x23 x25 x27 x29 x31 y17 y19 y21 y23 y25 y27 y29 y31 a_3 z1 z3 z5 z7 z9 z11 z13 z15 w1 w3 w5 w7 w9 w11 w13 w15 z17 z19 z21 z23 z25 z27 z29 z31 w17 w19 w21 w23 w25 w27 w29 w31
                a_0 = Avx2.UnpackLow(b_0, b_2);
                a_1 = Avx2.UnpackHigh(b_0, b_2);
                a_2 = Avx2.UnpackLow(b_1, b_3);
                a_3 = Avx2.UnpackHigh(b_1, b_3);
                // 4: b_0 x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 x16 x17 x18 x19 x20 x21 x22 x23 x24 x25 x26 x27 x28 x29 x30 x31 b_1 y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 y16 y17 y18 y19 y20 y21 y22 y23 y24 y25 y26 y27 y28 y29 y30 y31 b_2 z0 z1 z2 z3 z4 z5 z6 z7 z8 z9 z10 z11 z12 z13 z14 z15 z16 z17 z18 z19 z20 z21 z22 z23 z24 z25 z26 z27 z28 z29 z30 z31 b_3 w0 w1 w2 w3 w4 w5 w6 w7 w8 w9 w10 w11 w12 w13 w14 w15 w16 w17 w18 w19 w20 w21 w22 w23 w24 w25 w26 w27 w28 w29 w30 w31
                b_0 = Avx2.UnpackLow(a_0, a_2);
                b_1 = Avx2.UnpackHigh(a_0, a_2);
                b_2 = Avx2.UnpackLow(a_1, a_3);
                b_3 = Avx2.UnpackHigh(a_1, a_3);
                y = b_1;
                z = b_2;
                w = b_3;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup4Unzip_Unpack(Vector256<short> data0, Vector256<short> data1, Vector256<short> data2, Vector256<short> data3, out Vector256<short> y, out Vector256<short> z, out Vector256<short> w) {
                var d0 = YGroup4Unzip_Unpack(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), data3.AsUInt16(), out var d1, out var d2, out var d3);
                y = d1.AsInt16();
                z = d2.AsInt16();
                w = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup4Unzip_Unpack(Vector256<ushort> data0, Vector256<ushort> data1, Vector256<ushort> data2, Vector256<ushort> data3, out Vector256<ushort> y, out Vector256<ushort> z, out Vector256<ushort> w) {
                Vector256<ushort> temp0, temp1, temp2, temp3;
                Vector256<ushort> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
                // Zip layer by 128-bits unpack.
                // 0: data0 x0 y0 z0 w0 x1 y1 z1 w1 x2 y2 z2 w2 x3 y3 z3 w3 data1 x4 y4 z4 w4 x5 y5 z5 w5 x6 y6 z6 w6 x7 y7 z7 w7 data2 x8 y8 z8 w8 x9 y9 z9 w9 x10 y10 z10 w10 x11 y11 z11 w11 data3 x12 y12 z12 w12 x13 y13 z13 w13 x14 y14 z14 w14 x15 y15 z15 w15
                //0b: temp0 x0 y0 z0 w0 x1 y1 z1 w1 x8 y8 z8 w8 x9 y9 z9 w9 temp1 x2 y2 z2 w2 x3 y3 z3 w3 x10 y10 z10 w10 x11 y11 z11 w11 temp2 x4 y4 z4 w4 x5 y5 z5 w5 x12 y12 z12 w12 x13 y13 z13 w13 temp3 x6 y6 z6 w6 x7 y7 z7 w7 x14 y14 z14 w14 x15 y15 z15 w15
                temp0 = YGroup4Unzip_Int128(data0, data1, data2, data3, out temp1, out temp2, out temp3);
                // 1: a_0 x0 x4 y0 y4 z0 z4 w0 w4 x8 x12 y8 y12 z8 z12 w8 w12 a_1 x1 x5 y1 y5 z1 z5 w1 w5 x9 x13 y9 y13 z9 z13 w9 w13 a_2 x2 x6 y2 y6 z2 z6 w2 w6 x10 x14 y10 y14 z10 z14 w10 w14 a_3 x3 x7 y3 y7 z3 z7 w3 w7 x11 x15 y11 y15 z11 z15 w11 w15
                a_0 = Avx2.UnpackLow(temp0, temp2);
                a_1 = Avx2.UnpackHigh(temp0, temp2);
                a_2 = Avx2.UnpackLow(temp1, temp3);
                a_3 = Avx2.UnpackHigh(temp1, temp3);
                // 2: b_0 x0 x2 x4 x6 y0 y2 y4 y6 x8 x10 x12 x14 y8 y10 y12 y14 b_1 z0 z2 z4 z6 w0 w2 w4 w6 z8 z10 z12 z14 w8 w10 w12 w14 b_2 x1 x3 x5 x7 y1 y3 y5 y7 x9 x11 x13 x15 y9 y11 y13 y15 b_3 z1 z3 z5 z7 w1 w3 w5 w7 z9 z11 z13 z15 w9 w11 w13 w15
                b_0 = Avx2.UnpackLow(a_0, a_2);
                b_1 = Avx2.UnpackHigh(a_0, a_2);
                b_2 = Avx2.UnpackLow(a_1, a_3);
                b_3 = Avx2.UnpackHigh(a_1, a_3);
                // 3: a_0 x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 a_1 y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 a_2 z0 z1 z2 z3 z4 z5 z6 z7 z8 z9 z10 z11 z12 z13 z14 z15 a_3 w0 w1 w2 w3 w4 w5 w6 w7 w8 w9 w10 w11 w12 w13 w14 w15
                a_0 = Avx2.UnpackLow(b_0, b_2);
                a_1 = Avx2.UnpackHigh(b_0, b_2);
                a_2 = Avx2.UnpackLow(b_1, b_3);
                a_3 = Avx2.UnpackHigh(b_1, b_3);
                y = a_1;
                z = a_2;
                w = a_3;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup4Unzip_Unpack(Vector256<int> data0, Vector256<int> data1, Vector256<int> data2, Vector256<int> data3, out Vector256<int> y, out Vector256<int> z, out Vector256<int> w) {
                var d0 = YGroup4Unzip_Unpack(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), out var d1, out var d2, out var d3);
                y = d1.AsInt32();
                z = d2.AsInt32();
                w = d3.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup4Unzip_Unpack(Vector256<uint> data0, Vector256<uint> data1, Vector256<uint> data2, Vector256<uint> data3, out Vector256<uint> y, out Vector256<uint> z, out Vector256<uint> w) {
                Vector256<uint> temp0, temp1, temp2, temp3;
                Vector256<uint> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
                // Zip layer by 128-bits unpack.
                // 0: data0 x0 y0 z0 w0 x1 y1 z1 w1 data1 x2 y2 z2 w2 x3 y3 z3 w3 data2 x4 y4 z4 w4 x5 y5 z5 w5 data3 x6 y6 z6 w6 x7 y7 z7 w7
                //0b: temp0 x0 y0 z0 w0 x4 y4 z4 w4 temp1 x1 y1 z1 w1 x5 y5 z5 w5 temp2 x2 y2 z2 w2 x6 y6 z6 w6 temp3 x3 y3 z3 w3 x7 y7 z7 w7
                temp0 = YGroup4Unzip_Int128(data0, data1, data2, data3, out temp1, out temp2, out temp3);
                // 1: a_0 x0 z0 x1 z1 x4 z4 x5 z5 a_1 x2 z2 x3 z3 x6 z6 x7 z7 a_2 y0 w0 y1 w1 y4 w4 y5 w5 a_3 y2 w2 y3 w3 y6 w6 y7 w7
                a_0 = Avx2.UnpackLow(temp0, temp2);
                a_1 = Avx2.UnpackHigh(temp0, temp2);
                a_2 = Avx2.UnpackLow(temp1, temp3);
                a_3 = Avx2.UnpackHigh(temp1, temp3);
                // 2: b_0 x0 x1 x2 x3 x4 x5 x6 x7 b_1 y0 y1 y2 y3 y4 y5 y6 y7 b_2 z0 z1 z2 z3 z4 z5 z6 z7 b_3 w0 w1 w2 w3 w4 w5 w6 w7
                b_0 = Avx2.UnpackLow(a_0, a_2);
                b_1 = Avx2.UnpackHigh(a_0, a_2);
                b_2 = Avx2.UnpackLow(a_1, a_3);
                b_3 = Avx2.UnpackHigh(a_1, a_3);
                y = b_1;
                z = b_2;
                w = b_3;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup4Unzip_Unpack(Vector256<long> data0, Vector256<long> data1, Vector256<long> data2, Vector256<long> data3, out Vector256<long> y, out Vector256<long> z, out Vector256<long> w) {
                var d0 = YGroup4Unzip_Unpack(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), data3.AsUInt64(), out var d1, out var d2, out var d3);
                y = d1.AsInt64();
                z = d2.AsInt64();
                w = d3.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup4Unzip_Unpack(Vector256<ulong> data0, Vector256<ulong> data1, Vector256<ulong> data2, Vector256<ulong> data3, out Vector256<ulong> y, out Vector256<ulong> z, out Vector256<ulong> w) {
                Vector256<ulong> temp0, temp1, temp2, temp3;
                Vector256<ulong> a_0, a_1, a_2, a_3;
                // Zip layer by 128-bits unpack.
                // 0: data0 x0 y0 z0 w0 data1 x1 y1 z1 w1 data2 x2 y2 z2 w2 data3 x3 y3 z3 w3
                //0b: temp0 x0 y0 x2 y2 temp1 z0 w0 z2 w2 temp2 x1 y1 x3 y3 temp3 z1 w1 z3 w3
                temp0 = YGroup4Unzip_Int128(data0, data1, data2, data3, out temp1, out temp2, out temp3);
                // 1: a_0 x0 x1 x2 x3 a_1 y0 y1 y2 y3 a_2 z0 z1 z2 z3 a_3 w0 w1 w2 w3
                a_0 = Avx2.UnpackLow(temp0, temp2);
                a_1 = Avx2.UnpackHigh(temp0, temp2);
                a_2 = Avx2.UnpackLow(temp1, temp3);
                a_3 = Avx2.UnpackHigh(temp1, temp3);
                y = a_1;
                z = a_2;
                w = a_3;
                return a_0;
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup4Unzip_Unzip(Vector256<double> data0, Vector256<double> data1, Vector256<double> data2, Vector256<double> data3, out Vector256<double> y, out Vector256<double> z, out Vector256<double> w) {
                var d0 = YGroup4Unzip_Unzip(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), data3.AsUInt64(), out var d1, out var d2, out var d3);
                y = d1.AsDouble();
                z = d2.AsDouble();
                w = d3.AsDouble();
                return d0.AsDouble();
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
                // 0: data0 x0 y0 z0 w0 x1 y1 z1 w1 x2 y2 z2 w2 x3 y3 z3 w3 x4 y4 z4 w4 x5 y5 z5 w5 x6 y6 z6 w6 x7 y7 z7 w7 data1 x8 y8 z8 w8 x9 y9 z9 w9 x10 y10 z10 w10 x11 y11 z11 w11 x12 y12 z12 w12 x13 y13 z13 w13 x14 y14 z14 w14 x15 y15 z15 w15 data2 x16 y16 z16 w16 x17 y17 z17 w17 x18 y18 z18 w18 x19 y19 z19 w19 x20 y20 z20 w20 x21 y21 z21 w21 x22 y22 z22 w22 x23 y23 z23 w23 data3 x24 y24 z24 w24 x25 y25 z25 w25 x26 y26 z26 w26 x27 y27 z27 w27 x28 y28 z28 w28 x29 y29 z29 w29 x30 y30 z30 w30 x31 y31 z31 w31
                // 1: a_0 x0 z0 x1 z1 x2 z2 x3 z3 x4 z4 x5 z5 x6 z6 x7 z7 x8 z8 x9 z9 x10 z10 x11 z11 x12 z12 x13 z13 x14 z14 x15 z15 a_1 x16 z16 x17 z17 x18 z18 x19 z19 x20 z20 x21 z21 x22 z22 x23 z23 x24 z24 x25 z25 x26 z26 x27 z27 x28 z28 x29 z29 x30 z30 x31 z31 a_2 y0 w0 y1 w1 y2 w2 y3 w3 y4 w4 y5 w5 y6 w6 y7 w7 y8 w8 y9 w9 y10 w10 y11 w11 y12 w12 y13 w13 y14 w14 y15 w15 a_3 y16 w16 y17 w17 y18 w18 y19 w19 y20 w20 y21 w21 y22 w22 y23 w23 y24 w24 y25 w25 y26 w26 y27 w27 y28 w28 y29 w29 y30 w30 y31 w31
                a_0 = YGroup2Unzip(data0, data1, out a_2);
                a_1 = YGroup2Unzip(data2, data3, out a_3);
                // 2: b_0 x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 x16 x17 x18 x19 x20 x21 x22 x23 x24 x25 x26 x27 x28 x29 x30 x31 b_1 y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 y16 y17 y18 y19 y20 y21 y22 y23 y24 y25 y26 y27 y28 y29 y30 y31 b_2 z0 z1 z2 z3 z4 z5 z6 z7 z8 z9 z10 z11 z12 z13 z14 z15 z16 z17 z18 z19 z20 z21 z22 z23 z24 z25 z26 z27 z28 z29 z30 z31 b_3 w0 w1 w2 w3 w4 w5 w6 w7 w8 w9 w10 w11 w12 w13 w14 w15 w16 w17 w18 w19 w20 w21 w22 w23 w24 w25 w26 w27 w28 w29 w30 w31
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
                // 0: data0 x0 y0 z0 w0 x1 y1 z1 w1 x2 y2 z2 w2 x3 y3 z3 w3 data1 x4 y4 z4 w4 x5 y5 z5 w5 x6 y6 z6 w6 x7 y7 z7 w7 data2 x8 y8 z8 w8 x9 y9 z9 w9 x10 y10 z10 w10 x11 y11 z11 w11 data3 x12 y12 z12 w12 x13 y13 z13 w13 x14 y14 z14 w14 x15 y15 z15 w15
                // 1: a_0 x0 z0 x1 z1 x2 z2 x3 z3 x4 z4 x5 z5 x6 z6 x7 z7 a_1 x8 z8 x9 z9 x10 z10 x11 z11 x12 z12 x13 z13 x14 z14 x15 z15 a_2 y0 w0 y1 w1 y2 w2 y3 w3 y4 w4 y5 w5 y6 w6 y7 w7 a_3 y8 w8 y9 w9 y10 w10 y11 w11 y12 w12 y13 w13 y14 w14 y15 w15
                a_0 = YGroup2Unzip(data0, data1, out a_2);
                a_1 = YGroup2Unzip(data2, data3, out a_3);
                // 2: b_0 x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 b_1 y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 b_2 z0 z1 z2 z3 z4 z5 z6 z7 z8 z9 z10 z11 z12 z13 z14 z15 b_3 w0 w1 w2 w3 w4 w5 w6 w7 w8 w9 w10 w11 w12 w13 w14 w15
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
                // 0: data0 x0 y0 z0 w0 x1 y1 z1 w1 data1 x2 y2 z2 w2 x3 y3 z3 w3 data2 x4 y4 z4 w4 x5 y5 z5 w5 data3 x6 y6 z6 w6 x7 y7 z7 w7
                // 1: a_0 x0 z0 x1 z1 x2 z2 x3 z3 a_1 x4 z4 x5 z5 x6 z6 x7 z7 a_2 y0 w0 y1 w1 y2 w2 y3 w3 a_3 y4 w4 y5 w5 y6 w6 y7 w7
                a_0 = YGroup2Unzip(data0, data1, out a_2);
                a_1 = YGroup2Unzip(data2, data3, out a_3);
                // 2: b_0 x0 x1 x2 x3 x4 x5 x6 x7 b_1 y0 y1 y2 y3 y4 y5 y6 y7 b_2 z0 z1 z2 z3 z4 z5 z6 z7 b_3 w0 w1 w2 w3 w4 w5 w6 w7
                b_0 = YGroup2Unzip(a_0, a_1, out b_2);
                b_1 = YGroup2Unzip(a_2, a_3, out b_3);
                y = b_1;
                z = b_2;
                w = b_3;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup4Unzip_Unzip(Vector256<long> data0, Vector256<long> data1, Vector256<long> data2, Vector256<long> data3, out Vector256<long> y, out Vector256<long> z, out Vector256<long> w) {
                var d0 = YGroup4Unzip_Unzip(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), data3.AsUInt64(), out var d1, out var d2, out var d3);
                y = d1.AsInt64();
                z = d2.AsInt64();
                w = d3.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Unzip(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup4Unzip_Unzip(Vector256<ulong> data0, Vector256<ulong> data1, Vector256<ulong> data2, Vector256<ulong> data3, out Vector256<ulong> y, out Vector256<ulong> z, out Vector256<ulong> w) {
                Vector256<ulong> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
                // 0: data0 x0 y0 z0 w0 data1 x1 y1 z1 w1 data2 x2 y2 z2 w2 data3 x3 y3 z3 w3
                // 1: a_0 x0 z0 x1 z1 a_1 x2 z2 x3 z3 a_2 y0 w0 y1 w1 a_3 y2 w2 y3 w3
                a_0 = YGroup2Unzip(data0, data1, out a_2);
                a_1 = YGroup2Unzip(data2, data3, out a_3);
                // 2: b_0 x0 x1 x2 x3 b_1 y0 y1 y2 y3 b_2 z0 z1 z2 z3 b_3 w0 w1 w2 w3
                b_0 = YGroup2Unzip(a_0, a_1, out b_2);
                b_1 = YGroup2Unzip(a_2, a_3, out b_3);
                y = b_1;
                z = b_2;
                w = b_3;
                return b_0;
            }


            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup4Zip_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes | TypeCodeFlags.Int128 | TypeCodeFlags.UInt128;
                    return rt;
                }
            }
            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup4Zip(Vector256<float> x, Vector256<float> y, Vector256<float> z, Vector256<float> w, out Vector256<float> data1, out Vector256<float> data2, out Vector256<float> data3) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.IsSupported) {
                    return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
                }
#endif // NET8_0_OR_GREATER
                return YGroup4Zip_Unpack(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup4Zip(Vector256<double> x, Vector256<double> y, Vector256<double> z, Vector256<double> w, out Vector256<double> data1, out Vector256<double> data2, out Vector256<double> data3) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.IsSupported) {
                    return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
                }
#endif // NET8_0_OR_GREATER
                return YGroup4Zip_Unpack(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup4Zip(Vector256<sbyte> x, Vector256<sbyte> y, Vector256<sbyte> z, Vector256<sbyte> w, out Vector256<sbyte> data1, out Vector256<sbyte> data2, out Vector256<sbyte> data3) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.IsSupported) {
                    return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
                }
#endif // NET8_0_OR_GREATER
                return YGroup4Zip_Unpack(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup4Zip(Vector256<byte> x, Vector256<byte> y, Vector256<byte> z, Vector256<byte> w, out Vector256<byte> data1, out Vector256<byte> data2, out Vector256<byte> data3) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.IsSupported) {
                    return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
                }
#endif // NET8_0_OR_GREATER
                return YGroup4Zip_Unpack(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup4Zip(Vector256<short> x, Vector256<short> y, Vector256<short> z, Vector256<short> w, out Vector256<short> data1, out Vector256<short> data2, out Vector256<short> data3) {
#if NET8_0_OR_GREATER
                if (Avx512BW.IsSupported) {
                    return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
                }
#endif // NET8_0_OR_GREATER
                return YGroup4Zip_Unpack(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup4Zip(Vector256<ushort> x, Vector256<ushort> y, Vector256<ushort> z, Vector256<ushort> w, out Vector256<ushort> data1, out Vector256<ushort> data2, out Vector256<ushort> data3) {
#if NET8_0_OR_GREATER
                if (Avx512BW.IsSupported) {
                    return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
                }
#endif // NET8_0_OR_GREATER
                return YGroup4Zip_Unpack(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup4Zip(Vector256<int> x, Vector256<int> y, Vector256<int> z, Vector256<int> w, out Vector256<int> data1, out Vector256<int> data2, out Vector256<int> data3) {
#if NET8_0_OR_GREATER
                if (Avx512F.IsSupported) {
                    return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
                }
#endif // NET8_0_OR_GREATER
                return YGroup4Zip_Unpack(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup4Zip(Vector256<uint> x, Vector256<uint> y, Vector256<uint> z, Vector256<uint> w, out Vector256<uint> data1, out Vector256<uint> data2, out Vector256<uint> data3) {
#if NET8_0_OR_GREATER
                if (Avx512F.IsSupported) {
                    return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
                }
#endif // NET8_0_OR_GREATER
                return YGroup4Zip_Unpack(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup4Zip(Vector256<long> x, Vector256<long> y, Vector256<long> z, Vector256<long> w, out Vector256<long> data1, out Vector256<long> data2, out Vector256<long> data3) {
#if NET8_0_OR_GREATER
                if (Avx512F.IsSupported) {
                    return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
                }
#endif // NET8_0_OR_GREATER
                return YGroup4Zip_Unpack(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup4Zip(Vector256<ulong> x, Vector256<ulong> y, Vector256<ulong> z, Vector256<ulong> w, out Vector256<ulong> data1, out Vector256<ulong> data2, out Vector256<ulong> data3) {
#if NET8_0_OR_GREATER
                if (Avx512F.IsSupported) {
                    return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
                }
#endif // NET8_0_OR_GREATER
                return YGroup4Zip_Unpack(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{ExInt128}, Vector256{ExInt128}, Vector256{ExInt128}, Vector256{ExInt128}, out Vector256{ExInt128}, out Vector256{ExInt128}, out Vector256{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExInt128> YGroup4Zip(Vector256<ExInt128> x, Vector256<ExInt128> y, Vector256<ExInt128> z, Vector256<ExInt128> w, out Vector256<ExInt128> data1, out Vector256<ExInt128> data2, out Vector256<ExInt128> data3) {
#if EX_APPLY_GENERIC
                return YGroup4Zip_Int128(x, y, z, w, out data1, out data2, out data3);
#else
                var d0 = YGroup4Zip_Int128_On64(x.ExAsUInt64(), y.ExAsUInt64(), z.ExAsUInt64(), w.ExAsUInt64(), out var d1, out var d2, out var d3);
                data1 = d1.ExAsExInt128();
                data2 = d2.ExAsExInt128();
                data3 = d3.ExAsExInt128();
                return d0.ExAsExInt128();
#endif // EX_APPLY_GENERIC
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{ExUInt128}, Vector256{ExUInt128}, Vector256{ExUInt128}, Vector256{ExUInt128}, out Vector256{ExUInt128}, out Vector256{ExUInt128}, out Vector256{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ExUInt128> YGroup4Zip(Vector256<ExUInt128> x, Vector256<ExUInt128> y, Vector256<ExUInt128> z, Vector256<ExUInt128> w, out Vector256<ExUInt128> data1, out Vector256<ExUInt128> data2, out Vector256<ExUInt128> data3) {
#if EX_APPLY_GENERIC
                return YGroup4Zip_Int128(x, y, z, w, out data1, out data2, out data3);
#else
                var d0 = YGroup4Zip_Int128_On64(x.ExAsUInt64(), y.ExAsUInt64(), z.ExAsUInt64(), w.ExAsUInt64(), out var d1, out var d2, out var d3);
                data1 = d1.ExAsExUInt128();
                data2 = d2.ExAsExUInt128();
                data3 = d3.ExAsExUInt128();
                return d0.ExAsExUInt128();
#endif // EX_APPLY_GENERIC
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip_Int128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<T> YGroup4Zip_Int128<T>(Vector256<T> x, Vector256<T> y, Vector256<T> z, Vector256<T> w, out Vector256<T> data1, out Vector256<T> data2, out Vector256<T> data3) where T : struct {
#if EX_APPLY_GENERIC
                var d0 = YGroup4Zip_Int128_On64(x.ExAs<T, ulong>(), y.ExAs<T, ulong>(), z.ExAs<T, ulong>(), w.ExAs<T, ulong>(), out var d1, out var d2, out var d3);
                data1 = d1.ExAs<ulong, T>();
                data2 = d2.ExAs<ulong, T>();
                data3 = d3.ExAs<ulong, T>();
                return d0.ExAs<ulong, T>();
#else
                var d0 = YGroup4Zip_Int128_On64(x.As<T, ulong>(), y.As<T, ulong>(), z.As<T, ulong>(), w.As<T, ulong>(), out var d1, out var d2, out var d3);
                data1 = d1.As<ulong, T>();
                data2 = d2.As<ulong, T>();
                data3 = d3.As<ulong, T>();
                return d0.As<ulong, T>();
#endif // EX_APPLY_GENERIC
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip_Int128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static Vector256<ulong> YGroup4Zip_Int128_On64(Vector256<ulong> x, Vector256<ulong> y, Vector256<ulong> z, Vector256<ulong> w, out Vector256<ulong> data1, out Vector256<ulong> data2, out Vector256<ulong> data3) {
                var d0 = Avx.Permute2x128(x, y, (byte)ShuffleControl2X4Use4.XZ);
                var d2 = Avx.Permute2x128(x, y, (byte)ShuffleControl2X4Use4.YW);
                var d1 = Avx.Permute2x128(z, w, (byte)ShuffleControl2X4Use4.XZ);
                var d3 = Avx.Permute2x128(z, w, (byte)ShuffleControl2X4Use4.YW);
                data1 = d1;
                data2 = d2;
                data3 = d3;
                return d0;
            }

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup4Zip_PermuteLonger(Vector256<float> x, Vector256<float> y, Vector256<float> z, Vector256<float> w, out Vector256<float> data1, out Vector256<float> data2, out Vector256<float> data3) {
                var d0 = YGroup4Zip_PermuteLonger(x.AsUInt32(), y.AsUInt32(), z.AsUInt32(), w.AsUInt32(), out var d1, out var d2, out var d3);
                data1 = d1.AsSingle();
                data2 = d2.AsSingle();
                data3 = d3.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup4Zip_PermuteLonger(Vector256<double> x, Vector256<double> y, Vector256<double> z, Vector256<double> w, out Vector256<double> data1, out Vector256<double> data2, out Vector256<double> data3) {
                var d0 = YGroup4Zip_PermuteLonger(x.AsUInt64(), y.AsUInt64(), z.AsUInt64(), w.AsUInt64(), out var d1, out var d2, out var d3);
                data1 = d1.AsDouble();
                data2 = d2.AsDouble();
                data3 = d3.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup4Zip_PermuteLonger(Vector256<sbyte> x, Vector256<sbyte> y, Vector256<sbyte> z, Vector256<sbyte> w, out Vector256<sbyte> data1, out Vector256<sbyte> data2, out Vector256<sbyte> data3) {
                var d0 = YGroup4Zip_PermuteLonger(x.AsByte(), y.AsByte(), z.AsByte(), w.AsByte(), out var d1, out var d2, out var d3);
                data1 = d1.AsSByte();
                data2 = d2.AsSByte();
                data3 = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup4Zip_PermuteLonger(Vector256<byte> x, Vector256<byte> y, Vector256<byte> z, Vector256<byte> w, out Vector256<byte> data1, out Vector256<byte> data2, out Vector256<byte> data3) {
                VectorMessageFormats.ThrowForUnsupported(Avx512Vbmi.IsSupported, "Avx512Vbmi");
                var a0 = x.ToVector512Unsafe().WithUpper(y);
                var a1 = z.ToVector512Unsafe().WithUpper(w);
                var b0 = Avx512Vbmi.PermuteVar64x8x2(a0, Vector512Constants.YGroup4Zip_ShuffleX2Longer_Byte_Data01, a1);
                var b1 = Avx512Vbmi.PermuteVar64x8x2(a0, Vector512Constants.YGroup4Zip_ShuffleX2Longer_Byte_Data23, a1);
                data1 = b0.GetUpper();
                data2 = b1.GetLower();
                data3 = b1.GetUpper();
                return b0.GetLower();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup4Zip_PermuteLonger(Vector256<short> x, Vector256<short> y, Vector256<short> z, Vector256<short> w, out Vector256<short> data1, out Vector256<short> data2, out Vector256<short> data3) {
                var d0 = YGroup4Zip_PermuteLonger(x.AsUInt16(), y.AsUInt16(), z.AsUInt16(), w.AsUInt16(), out var d1, out var d2, out var d3);
                data1 = d1.AsInt16();
                data2 = d2.AsInt16();
                data3 = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup4Zip_PermuteLonger(Vector256<ushort> x, Vector256<ushort> y, Vector256<ushort> z, Vector256<ushort> w, out Vector256<ushort> data1, out Vector256<ushort> data2, out Vector256<ushort> data3) {
                VectorMessageFormats.ThrowForUnsupported(Avx512BW.IsSupported, "Avx512BW");
                var a0 = x.ToVector512Unsafe().WithUpper(y);
                var a1 = z.ToVector512Unsafe().WithUpper(w);
                var b0 = Avx512BW.PermuteVar32x16x2(a0, Vector512Constants.YGroup4Zip_ShuffleX2Longer_UInt16_Data01, a1);
                var b1 = Avx512BW.PermuteVar32x16x2(a0, Vector512Constants.YGroup4Zip_ShuffleX2Longer_UInt16_Data23, a1);
                data1 = b0.GetUpper();
                data2 = b1.GetLower();
                data3 = b1.GetUpper();
                return b0.GetLower();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup4Zip_PermuteLonger(Vector256<int> x, Vector256<int> y, Vector256<int> z, Vector256<int> w, out Vector256<int> data1, out Vector256<int> data2, out Vector256<int> data3) {
                var d0 = YGroup4Zip_PermuteLonger(x.AsUInt32(), y.AsUInt32(), z.AsUInt32(), w.AsUInt32(), out var d1, out var d2, out var d3);
                data1 = d1.AsInt32();
                data2 = d2.AsInt32();
                data3 = d3.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup4Zip_PermuteLonger(Vector256<uint> x, Vector256<uint> y, Vector256<uint> z, Vector256<uint> w, out Vector256<uint> data1, out Vector256<uint> data2, out Vector256<uint> data3) {
                VectorMessageFormats.ThrowForUnsupported(Avx512F.IsSupported, "Avx512F");
                var a0 = x.ToVector512Unsafe().WithUpper(y);
                var a1 = z.ToVector512Unsafe().WithUpper(w);
                var b0 = Avx512F.PermuteVar16x32x2(a0, Vector512Constants.YGroup4Zip_ShuffleX2Longer_UInt32_Data01, a1);
                var b1 = Avx512F.PermuteVar16x32x2(a0, Vector512Constants.YGroup4Zip_ShuffleX2Longer_UInt32_Data23, a1);
                data1 = b0.GetUpper();
                data2 = b1.GetLower();
                data3 = b1.GetUpper();
                return b0.GetLower();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup4Zip_PermuteLonger(Vector256<long> x, Vector256<long> y, Vector256<long> z, Vector256<long> w, out Vector256<long> data1, out Vector256<long> data2, out Vector256<long> data3) {
                var d0 = YGroup4Zip_PermuteLonger(x.AsUInt64(), y.AsUInt64(), z.AsUInt64(), w.AsUInt64(), out var d1, out var d2, out var d3);
                data1 = d1.AsInt64();
                data2 = d2.AsInt64();
                data3 = d3.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup4Zip_PermuteLonger(Vector256<ulong> x, Vector256<ulong> y, Vector256<ulong> z, Vector256<ulong> w, out Vector256<ulong> data1, out Vector256<ulong> data2, out Vector256<ulong> data3) {
                VectorMessageFormats.ThrowForUnsupported(Avx512F.IsSupported, "Avx512F");
                var a0 = x.ToVector512Unsafe().WithUpper(y);
                var a1 = z.ToVector512Unsafe().WithUpper(w);
                var b0 = Avx512F.PermuteVar8x64x2(a0, Vector512Constants.YGroup4Zip_ShuffleX2Longer_UInt64_Data01, a1);
                var b1 = Avx512F.PermuteVar8x64x2(a0, Vector512Constants.YGroup4Zip_ShuffleX2Longer_UInt64_Data23, a1);
                data1 = b0.GetUpper();
                data2 = b1.GetLower();
                data3 = b1.GetUpper();
                return b0.GetLower();
            }

#endif // NET8_0_OR_GREATER

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
                Vector256<ushort> t0, t1;
                Vector256<uint> r0, r1, r2, r3, d0, d1, d2, d3;
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
                Vector256<uint> t0, t1;
                Vector256<ulong> r0, r1, r2, r3, d0, d1, d2, d3;
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, out Vector256{float}, out Vector256{float}, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YGroup4Zip_Unpack(Vector256<float> x, Vector256<float> y, Vector256<float> z, Vector256<float> w, out Vector256<float> data1, out Vector256<float> data2, out Vector256<float> data3) {
                var d0 = YGroup4Zip_Unpack(x.AsUInt32(), y.AsUInt32(), z.AsUInt32(), w.AsUInt32(), out var d1, out var d2, out var d3);
                data1 = d1.AsSingle();
                data2 = d2.AsSingle();
                data3 = d3.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup4Zip_Unpack(Vector256<double> x, Vector256<double> y, Vector256<double> z, Vector256<double> w, out Vector256<double> data1, out Vector256<double> data2, out Vector256<double> data3) {
                var d0 = YGroup4Zip_Unpack(x.AsUInt64(), y.AsUInt64(), z.AsUInt64(), w.AsUInt64(), out var d1, out var d2, out var d3);
                data1 = d1.AsDouble();
                data2 = d2.AsDouble();
                data3 = d3.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YGroup4Zip_Unpack(Vector256<sbyte> x, Vector256<sbyte> y, Vector256<sbyte> z, Vector256<sbyte> w, out Vector256<sbyte> data1, out Vector256<sbyte> data2, out Vector256<sbyte> data3) {
                var d0 = YGroup4Zip_Unpack(x.AsByte(), y.AsByte(), z.AsByte(), w.AsByte(), out var d1, out var d2, out var d3);
                data1 = d1.AsSByte();
                data2 = d2.AsSByte();
                data3 = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YGroup4Zip_Unpack(Vector256<byte> x, Vector256<byte> y, Vector256<byte> z, Vector256<byte> w, out Vector256<byte> data1, out Vector256<byte> data2, out Vector256<byte> data3) {
                Vector256<byte> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
                // Zip layer by 128-bits unpack.
                // 0 _x_ x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 x16 x17 x18 x19 x20 x21 x22 x23 x24 x25 x26 x27 x28 x29 x30 x31 _y_ y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 y16 y17 y18 y19 y20 y21 y22 y23 y24 y25 y26 y27 y28 y29 y30 y31 _z_ z0 z1 z2 z3 z4 z5 z6 z7 z8 z9 z10 z11 z12 z13 z14 z15 z16 z17 z18 z19 z20 z21 z22 z23 z24 z25 z26 z27 z28 z29 z30 z31 _w_ w0 w1 w2 w3 w4 w5 w6 w7 w8 w9 w10 w11 w12 w13 w14 w15 w16 w17 w18 w19 w20 w21 w22 w23 w24 w25 w26 w27 w28 w29 w30 w31
                // 1 a_0 x0 z0 x1 z1 x2 z2 x3 z3 x4 z4 x5 z5 x6 z6 x7 z7 x16 z16 x17 z17 x18 z18 x19 z19 x20 z20 x21 z21 x22 z22 x23 z23 a_1 x8 z8 x9 z9 x10 z10 x11 z11 x12 z12 x13 z13 x14 z14 x15 z15 x24 z24 x25 z25 x26 z26 x27 z27 x28 z28 x29 z29 x30 z30 x31 z31 a_2 y0 w0 y1 w1 y2 w2 y3 w3 y4 w4 y5 w5 y6 w6 y7 w7 y16 w16 y17 w17 y18 w18 y19 w19 y20 w20 y21 w21 y22 w22 y23 w23 a_3 y8 w8 y9 w9 y10 w10 y11 w11 y12 w12 y13 w13 y14 w14 y15 w15 y24 w24 y25 w25 y26 w26 y27 w27 y28 w28 y29 w29 y30 w30 y31 w31
                a_0 = Avx2.UnpackLow(x, z);
                a_1 = Avx2.UnpackHigh(x, z);
                a_2 = Avx2.UnpackLow(y, w);
                a_3 = Avx2.UnpackHigh(y, w);
                // 2 b_0 x0 y0 z0 w0 x1 y1 z1 w1 x2 y2 z2 w2 x3 y3 z3 w3 x16 y16 z16 w16 x17 y17 z17 w17 x18 y18 z18 w18 x19 y19 z19 w19 b_1 x4 y4 z4 w4 x5 y5 z5 w5 x6 y6 z6 w6 x7 y7 z7 w7 x20 y20 z20 w20 x21 y21 z21 w21 x22 y22 z22 w22 x23 y23 z23 w23 b_2 x8 y8 z8 w8 x9 y9 z9 w9 x10 y10 z10 w10 x11 y11 z11 w11 x24 y24 z24 w24 x25 y25 z25 w25 x26 y26 z26 w26 x27 y27 z27 w27 b_3 x12 y12 z12 w12 x13 y13 z13 w13 x14 y14 z14 w14 x15 y15 z15 w15 x28 y28 z28 w28 x29 y29 z29 w29 x30 y30 z30 w30 x31 y31 z31 w31
                b_0 = Avx2.UnpackLow(a_0, a_2);
                b_1 = Avx2.UnpackHigh(a_0, a_2);
                b_2 = Avx2.UnpackLow(a_1, a_3);
                b_3 = Avx2.UnpackHigh(a_1, a_3);
                // Rearrange.
                //a_0 = YGroup2Unzip_Int128(b_0, b_1, out a_2);
                //a_1 = YGroup2Unzip_Int128(b_2, b_3, out a_3);
                a_0 = YGroup4Zip_Int128(b_0, b_1, b_2, b_3, out a_1, out a_2, out a_3);
                data1 = a_1;
                data2 = a_2;
                data3 = a_3;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YGroup4Zip_Unpack(Vector256<short> x, Vector256<short> y, Vector256<short> z, Vector256<short> w, out Vector256<short> data1, out Vector256<short> data2, out Vector256<short> data3) {
                var d0 = YGroup4Zip_Unpack(x.AsUInt16(), y.AsUInt16(), z.AsUInt16(), w.AsUInt16(), out var d1, out var d2, out var d3);
                data1 = d1.AsInt16();
                data2 = d2.AsInt16();
                data3 = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YGroup4Zip_Unpack(Vector256<ushort> x, Vector256<ushort> y, Vector256<ushort> z, Vector256<ushort> w, out Vector256<ushort> data1, out Vector256<ushort> data2, out Vector256<ushort> data3) {
                Vector256<ushort> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
                // Zip layer by 128-bits unpack.
                // 0 _x_ x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 _y_ y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 _z_ z0 z1 z2 z3 z4 z5 z6 z7 z8 z9 z10 z11 z12 z13 z14 z15 _w_ w0 w1 w2 w3 w4 w5 w6 w7 w8 w9 w10 w11 w12 w13 w14 w15
                // 1 a_0 x0 z0 x1 z1 x2 z2 x3 z3 x8 z8 x9 z9 x10 z10 x11 z11 a_1 x4 z4 x5 z5 x6 z6 x7 z7 x12 z12 x13 z13 x14 z14 x15 z15 a_2 y0 w0 y1 w1 y2 w2 y3 w3 y8 w8 y9 w9 y10 w10 y11 w11 a_3 y4 w4 y5 w5 y6 w6 y7 w7 y12 w12 y13 w13 y14 w14 y15 w15
                a_0 = Avx2.UnpackLow(x, z);
                a_1 = Avx2.UnpackHigh(x, z);
                a_2 = Avx2.UnpackLow(y, w);
                a_3 = Avx2.UnpackHigh(y, w);
                // 2 b_0 x0 y0 z0 w0 x1 y1 z1 w1 x8 y8 z8 w8 x9 y9 z9 w9 b_1 x2 y2 z2 w2 x3 y3 z3 w3 x10 y10 z10 w10 x11 y11 z11 w11 b_2 x4 y4 z4 w4 x5 y5 z5 w5 x12 y12 z12 w12 x13 y13 z13 w13 b_3 x6 y6 z6 w6 x7 y7 z7 w7 x14 y14 z14 w14 x15 y15 z15 w15
                b_0 = Avx2.UnpackLow(a_0, a_2);
                b_1 = Avx2.UnpackHigh(a_0, a_2);
                b_2 = Avx2.UnpackLow(a_1, a_3);
                b_3 = Avx2.UnpackHigh(a_1, a_3);
                // Rearrange.
                a_0 = YGroup4Zip_Int128(b_0, b_1, b_2, b_3, out a_1, out a_2, out a_3);
                data1 = a_1;
                data2 = a_2;
                data3 = a_3;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YGroup4Zip_Unpack(Vector256<int> x, Vector256<int> y, Vector256<int> z, Vector256<int> w, out Vector256<int> data1, out Vector256<int> data2, out Vector256<int> data3) {
                var d0 = YGroup4Zip_Unpack(x.AsUInt32(), y.AsUInt32(), z.AsUInt32(), w.AsUInt32(), out var d1, out var d2, out var d3);
                data1 = d1.AsInt32();
                data2 = d2.AsInt32();
                data3 = d3.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YGroup4Zip_Unpack(Vector256<uint> x, Vector256<uint> y, Vector256<uint> z, Vector256<uint> w, out Vector256<uint> data1, out Vector256<uint> data2, out Vector256<uint> data3) {
                Vector256<uint> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
                // Zip layer by 128-bits unpack.
                // 0 _x_ x0 x1 x2 x3 x4 x5 x6 x7 _y_ y0 y1 y2 y3 y4 y5 y6 y7 _z_ z0 z1 z2 z3 z4 z5 z6 z7 _w_ w0 w1 w2 w3 w4 w5 w6 w7
                // 1 a_0 x0 x2 y0 y2 x4 x6 y4 y6 a_1 z0 z2 w0 w2 z4 z6 w4 w6 a_2 x1 x3 y1 y3 x5 x7 y5 y7 a_3 z1 z3 w1 w3 z5 z7 w5 w7
                a_0 = Avx2.UnpackLow(x, z);
                a_1 = Avx2.UnpackHigh(x, z);
                a_2 = Avx2.UnpackLow(y, w);
                a_3 = Avx2.UnpackHigh(y, w);
                // 2 b_0 x0 y0 z0 w0 x4 y4 z4 w4 b_1 x1 y1 z1 w1 x5 y5 z5 w5 b_2 x2 y2 z2 w2 x6 y6 z6 w6 b_3 x3 y3 z3 w3 x7 y7 z7 w7
                b_0 = Avx2.UnpackLow(a_0, a_2);
                b_1 = Avx2.UnpackHigh(a_0, a_2);
                b_2 = Avx2.UnpackLow(a_1, a_3);
                b_3 = Avx2.UnpackHigh(a_1, a_3);
                // Rearrange.
                a_0 = YGroup4Zip_Int128(b_0, b_1, b_2, b_3, out a_1, out a_2, out a_3);
                data1 = a_1;
                data2 = a_2;
                data3 = a_3;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup4Zip_Unpack(Vector256<long> x, Vector256<long> y, Vector256<long> z, Vector256<long> w, out Vector256<long> data1, out Vector256<long> data2, out Vector256<long> data3) {
                var d0 = YGroup4Zip_Unpack(x.AsUInt64(), y.AsUInt64(), z.AsUInt64(), w.AsUInt64(), out var d1, out var d2, out var d3);
                data1 = d1.AsInt64();
                data2 = d2.AsInt64();
                data3 = d3.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup4Zip_Unpack(Vector256<ulong> x, Vector256<ulong> y, Vector256<ulong> z, Vector256<ulong> w, out Vector256<ulong> data1, out Vector256<ulong> data2, out Vector256<ulong> data3) {
                Vector256<ulong> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
                // Zip layer by 128-bits unpack.
                // 0 _x_ x0 x1 x2 x3 _y_ y0 y1 y2 y3 _z_ z0 z1 z2 z3 _w_ w0 w1 w2 w3
                // 1 a_0 x0 z0 x2 z2 a_1 x1 z1 x3 z3 a_2 y0 w0 y2 w2 a_3 y1 w1 y3 w3
                a_0 = Avx2.UnpackLow(x, z);
                a_1 = Avx2.UnpackHigh(x, z);
                a_2 = Avx2.UnpackLow(y, w);
                a_3 = Avx2.UnpackHigh(y, w);
                // 2 b_0 x0 y0 x2 y2 b_1 z0 w0 z2 w2 b_2 x1 y1 x3 y3 b_3 z1 w1 z3 w3
                b_0 = Avx2.UnpackLow(a_0, a_2);
                b_1 = Avx2.UnpackHigh(a_0, a_2);
                b_2 = Avx2.UnpackLow(a_1, a_3);
                b_3 = Avx2.UnpackHigh(a_1, a_3);
                // Rearrange.
                a_0 = YGroup4Zip_Int128(b_0, b_1, b_2, b_3, out a_1, out a_2, out a_3);
                data1 = a_1;
                data2 = a_2;
                data3 = a_3;
                return a_0;
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, out Vector256{double}, out Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YGroup4Zip_Zip(Vector256<double> x, Vector256<double> y, Vector256<double> z, Vector256<double> w, out Vector256<double> data1, out Vector256<double> data2, out Vector256<double> data3) {
                var d0 = YGroup4Zip_Zip(x.AsUInt64(), y.AsUInt64(), z.AsUInt64(), w.AsUInt64(), out var d1, out var d2, out var d3);
                data1 = d1.AsDouble();
                data2 = d2.AsDouble();
                data3 = d3.AsDouble();
                return d0.AsDouble();
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

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YGroup4Zip_Zip(Vector256<long> x, Vector256<long> y, Vector256<long> z, Vector256<long> w, out Vector256<long> data1, out Vector256<long> data2, out Vector256<long> data3) {
                var d0 = YGroup4Zip_Zip(x.AsUInt64(), y.AsUInt64(), z.AsUInt64(), w.AsUInt64(), out var d1, out var d2, out var d3);
                data1 = d1.AsInt64();
                data2 = d2.AsInt64();
                data3 = d3.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YGroup4Zip_Zip(Vector256<ulong> x, Vector256<ulong> y, Vector256<ulong> z, Vector256<ulong> w, out Vector256<ulong> data1, out Vector256<ulong> data2, out Vector256<ulong> data3) {
                Vector256<ulong> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
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

#endif // NETCOREAPP3_0_OR_GREATER
            }
        }
}
