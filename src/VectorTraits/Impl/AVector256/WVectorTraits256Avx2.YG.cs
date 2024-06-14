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
                VectorMessageFormats.ThrowForUnsupported(Avx512F.VL.IsSupported, "Avx512Vbmi, Avx512VL");
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
                VectorMessageFormats.ThrowForUnsupported(Avx512F.VL.IsSupported, "Avx512BW, Avx512VL");
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
                x1 = Avx2.Permute4x64(x.AsUInt64(), ctl).AsUInt64(); // 3,1
                y1 = Avx2.Permute4x64(y.AsUInt64(), ctl).AsUInt64(); // 3,1
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


#endif // NETCOREAPP3_0_OR_GREATER
        }
    }
}
