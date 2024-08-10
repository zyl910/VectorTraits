using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
#if NET8_0_OR_GREATER
using System.Runtime.Intrinsics.Wasm;
#endif // NET8_0_OR_GREATER
using Zyl.VectorTraits.ExTypes;

namespace Zyl.VectorTraits.Impl.AVector128 {
    using SuperStatics = WVectorTraits128Base.Statics;

    partial class WVectorTraits128PackedSimd {

        partial class Statics {

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2Unzip_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{float}, Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup2Unzip(Vector128<float> data0, Vector128<float> data1, out Vector128<float> y) {
                return YGroup2Unzip_Shuffle(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{double}, Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup2Unzip(Vector128<double> data0, Vector128<double> data1, out Vector128<double> y) {
                return YGroup2Unzip_Shuffle(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup2Unzip(Vector128<sbyte> data0, Vector128<sbyte> data1, out Vector128<sbyte> y) {
                return YGroup2Unzip_Shuffle(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{byte}, Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup2Unzip(Vector128<byte> data0, Vector128<byte> data1, out Vector128<byte> y) {
                // _Shuffle >= SuperStatics > _Narrow > _TupleNarrow > _TupleShuffle
                //return SuperStatics.YGroup2Unzip(data0, data1, out y);
                //return SuperStatics.YGroup2Unzip_Narrow(data0, data1, out y);
                //return YGroup2Unzip_Narrow(data0, data1, out y);
                return YGroup2Unzip_Shuffle(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{short}, Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup2Unzip(Vector128<short> data0, Vector128<short> data1, out Vector128<short> y) {
                // _Shuffle > SuperStatics > _Narrow > _TupleShuffle > _TupleNarrow
                return YGroup2Unzip_Shuffle(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{ushort}, Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup2Unzip(Vector128<ushort> data0, Vector128<ushort> data1, out Vector128<ushort> y) {
                return YGroup2Unzip_Shuffle(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{int}, Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup2Unzip(Vector128<int> data0, Vector128<int> data1, out Vector128<int> y) {
                return YGroup2Unzip_Shuffle(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{uint}, Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup2Unzip(Vector128<uint> data0, Vector128<uint> data1, out Vector128<uint> y) {
                return YGroup2Unzip_Shuffle(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{long}, Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup2Unzip(Vector128<long> data0, Vector128<long> data1, out Vector128<long> y) {
                return YGroup2Unzip_Shuffle(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{ulong}, Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup2Unzip(Vector128<ulong> data0, Vector128<ulong> data1, out Vector128<ulong> y) {
                return YGroup2Unzip_Shuffle(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{float}, Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup2Unzip_Narrow(Vector128<float> data0, Vector128<float> data1, out Vector128<float> y) {
                var d0 = YGroup2Unzip_Narrow(data0.AsUInt32(), data1.AsUInt32(), out var d1);
                y = d1.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup2Unzip_Narrow(Vector128<sbyte> data0, Vector128<sbyte> data1, out Vector128<sbyte> y) {
                var d0 = YGroup2Unzip_Narrow(data0.AsByte(), data1.AsByte(), out var d1);
                y = d1.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{byte}, Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup2Unzip_Narrow(Vector128<byte> data0, Vector128<byte> data1, out Vector128<byte> y) {
                const int L = 8;
                Vector128<byte> rt0, rt1;
                Vector128<ushort> temp0 = data0.AsUInt16();
                Vector128<ushort> temp1 = data1.AsUInt16();
                rt0 = Vector128.Narrow(temp0, temp1);
                temp0 = PackedSimd.ShiftRightLogical(temp0, L);
                temp1 = PackedSimd.ShiftRightLogical(temp1, L);
                rt1 = Vector128.Narrow(temp0, temp1);
                if (BitConverter.IsLittleEndian) {
                    y = rt1;
                    return rt0;
                } else {
                    y = rt0;
                    return rt1;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{short}, Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup2Unzip_Narrow(Vector128<short> data0, Vector128<short> data1, out Vector128<short> y) {
                var d0 = YGroup2Unzip_Narrow(data0.AsUInt16(), data1.AsUInt16(), out var d1);
                y = d1.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{ushort}, Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup2Unzip_Narrow(Vector128<ushort> data0, Vector128<ushort> data1, out Vector128<ushort> y) {
                const int L = 16;
                Vector128<ushort> rt0, rt1;
                Vector128<uint> temp0 = data0.AsUInt32();
                Vector128<uint> temp1 = data1.AsUInt32();
                rt0 = Vector128.Narrow(temp0, temp1);
                temp0 = PackedSimd.ShiftRightLogical(temp0, L);
                temp1 = PackedSimd.ShiftRightLogical(temp1, L);
                rt1 = Vector128.Narrow(temp0, temp1);
                if (BitConverter.IsLittleEndian) {
                    y = rt1;
                    return rt0;
                } else {
                    y = rt0;
                    return rt1;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{int}, Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup2Unzip_Narrow(Vector128<int> data0, Vector128<int> data1, out Vector128<int> y) {
                var d0 = YGroup2Unzip_Narrow(data0.AsUInt32(), data1.AsUInt32(), out var d1);
                y = d1.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{uint}, Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup2Unzip_Narrow(Vector128<uint> data0, Vector128<uint> data1, out Vector128<uint> y) {
                const int L = 32;
                Vector128<uint> rt0, rt1;
                Vector128<ulong> temp0 = data0.AsUInt64();
                Vector128<ulong> temp1 = data1.AsUInt64();
                rt0 = Vector128.Narrow(temp0, temp1);
                temp0 = PackedSimd.ShiftRightLogical(temp0, L);
                temp1 = PackedSimd.ShiftRightLogical(temp1, L);
                rt1 = Vector128.Narrow(temp0, temp1);
                if (BitConverter.IsLittleEndian) {
                    y = rt1;
                    return rt0;
                } else {
                    y = rt0;
                    return rt1;
                }
            }

            /// <inheritdoc cref="Vector128s.YGroup2Unzip(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static (Vector128<float> X, Vector128<float> Y) YGroup2Unzip_Narrow(Vector128<float> data0, Vector128<float> data1) {
                (var rt0, var rt1) = YGroup2Unzip_Narrow(data0.AsUInt32(), data1.AsUInt32());
                return (rt0.AsSingle(), rt1.AsSingle());
            }

            /// <inheritdoc cref="Vector128s.YGroup2Unzip(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static (Vector128<sbyte> X, Vector128<sbyte> Y) YGroup2Unzip_Narrow(Vector128<sbyte> data0, Vector128<sbyte> data1) {
                (var rt0, var rt1) = YGroup2Unzip_Narrow(data0.AsByte(), data1.AsByte());
                return (rt0.AsSByte(), rt1.AsSByte());
            }

            /// <inheritdoc cref="Vector128s.YGroup2Unzip(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static (Vector128<byte> X, Vector128<byte> Y) YGroup2Unzip_Narrow(Vector128<byte> data0, Vector128<byte> data1) {
                const int L = 8;
                Vector128<byte> rt0, rt1;
                Vector128<ushort> temp0 = data0.AsUInt16();
                Vector128<ushort> temp1 = data1.AsUInt16();
                rt0 = Vector128.Narrow(temp0, temp1);
                temp0 = PackedSimd.ShiftRightLogical(temp0, L);
                temp1 = PackedSimd.ShiftRightLogical(temp1, L);
                rt1 = Vector128.Narrow(temp0, temp1);
                if (BitConverter.IsLittleEndian) {
                    return (rt0, rt1);
                } else {
                    return (rt1, rt0);
                }
            }

            /// <inheritdoc cref="Vector128s.YGroup2Unzip(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static (Vector128<short> X, Vector128<short> Y) YGroup2Unzip_Narrow(Vector128<short> data0, Vector128<short> data1) {
                (var rt0, var rt1) = YGroup2Unzip_Narrow(data0.AsUInt16(), data1.AsUInt16());
                return (rt0.AsInt16(), rt1.AsInt16());
            }

            /// <inheritdoc cref="Vector128s.YGroup2Unzip(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static (Vector128<ushort> X, Vector128<ushort> Y) YGroup2Unzip_Narrow(Vector128<ushort> data0, Vector128<ushort> data1) {
                const int L = 16;
                Vector128<ushort> rt0, rt1;
                Vector128<uint> temp0 = data0.AsUInt32();
                Vector128<uint> temp1 = data1.AsUInt32();
                rt0 = Vector128.Narrow(temp0, temp1);
                temp0 = PackedSimd.ShiftRightLogical(temp0, L);
                temp1 = PackedSimd.ShiftRightLogical(temp1, L);
                rt1 = Vector128.Narrow(temp0, temp1);
                if (BitConverter.IsLittleEndian) {
                    return (rt0, rt1);
                } else {
                    return (rt1, rt0);
                }
            }

            /// <inheritdoc cref="Vector128s.YGroup2Unzip(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static (Vector128<int> X, Vector128<int> Y) YGroup2Unzip_Narrow(Vector128<int> data0, Vector128<int> data1) {
                (var rt0, var rt1) = YGroup2Unzip_Narrow(data0.AsUInt32(), data1.AsUInt32());
                return (rt0.AsInt32(), rt1.AsInt32());
            }

            /// <inheritdoc cref="Vector128s.YGroup2Unzip(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static (Vector128<uint> X, Vector128<uint> Y) YGroup2Unzip_Narrow(Vector128<uint> data0, Vector128<uint> data1) {
                const int L = 32;
                Vector128<uint> rt0, rt1;
                Vector128<ulong> temp0 = data0.AsUInt64();
                Vector128<ulong> temp1 = data1.AsUInt64();
                rt0 = Vector128.Narrow(temp0, temp1);
                temp0 = PackedSimd.ShiftRightLogical(temp0, L);
                temp1 = PackedSimd.ShiftRightLogical(temp1, L);
                rt1 = Vector128.Narrow(temp0, temp1);
                if (BitConverter.IsLittleEndian) {
                    return (rt0, rt1);
                } else {
                    return (rt1, rt0);
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{float}, Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup2Unzip_Shuffle(Vector128<float> data0, Vector128<float> data1, out Vector128<float> y) {
                var d0 = YGroup2Unzip_Shuffle(data0.AsUInt32(), data1.AsUInt32(), out var d1);
                y = d1.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{double}, Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup2Unzip_Shuffle(Vector128<double> data0, Vector128<double> data1, out Vector128<double> y) {
                var d0 = YGroup2Unzip_Shuffle(data0.AsUInt64(), data1.AsUInt64(), out var d1);
                y = d1.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup2Unzip_Shuffle(Vector128<sbyte> data0, Vector128<sbyte> data1, out Vector128<sbyte> y) {
                var d0 = YGroup2Unzip_Shuffle(data0.AsByte(), data1.AsByte(), out var d1);
                y = d1.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{byte}, Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup2Unzip_Shuffle(Vector128<byte> data0, Vector128<byte> data1, out Vector128<byte> y) {
                var f0 = Vector128Constants.YGroup2Unzip_ShuffleX2_Byte_X;
                var f0B = Vector128Constants.YGroup2Unzip_ShuffleX2_Byte_X_Part1;
                var f1 = Vector128Constants.YGroup2Unzip_ShuffleX2_Byte_Y;
                var f1B = Vector128Constants.YGroup2Unzip_ShuffleX2_Byte_Y_Part1;
                var a0 = PackedSimd.Or(PackedSimd.Swizzle(data0, f0), PackedSimd.Swizzle(data1, f0B));
                var a1 = PackedSimd.Or(PackedSimd.Swizzle(data0, f1), PackedSimd.Swizzle(data1, f1B));
                y = a1;
                return a0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{short}, Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup2Unzip_Shuffle(Vector128<short> data0, Vector128<short> data1, out Vector128<short> y) {
                var d0 = YGroup2Unzip_Shuffle(data0.AsUInt16(), data1.AsUInt16(), out var d1);
                y = d1.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{ushort}, Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup2Unzip_Shuffle(Vector128<ushort> data0, Vector128<ushort> data1, out Vector128<ushort> y) {
                var f0 = Vector128Constants.YGroup2Unzip_ShuffleX2OnByte_UInt16_X;
                var f0B = Vector128Constants.YGroup2Unzip_ShuffleX2OnByte_UInt16_X_Part1;
                var f1 = Vector128Constants.YGroup2Unzip_ShuffleX2OnByte_UInt16_Y;
                var f1B = Vector128Constants.YGroup2Unzip_ShuffleX2OnByte_UInt16_Y_Part1;
                var a0 = PackedSimd.Or(PackedSimd.Swizzle(data0.AsByte(), f0), PackedSimd.Swizzle(data1.AsByte(), f0B));
                var a1 = PackedSimd.Or(PackedSimd.Swizzle(data0.AsByte(), f1), PackedSimd.Swizzle(data1.AsByte(), f1B));
                y = a1.AsUInt16();
                return a0.AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{int}, Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup2Unzip_Shuffle(Vector128<int> data0, Vector128<int> data1, out Vector128<int> y) {
                var d0 = YGroup2Unzip_Shuffle(data0.AsUInt32(), data1.AsUInt32(), out var d1);
                y = d1.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{uint}, Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup2Unzip_Shuffle(Vector128<uint> data0, Vector128<uint> data1, out Vector128<uint> y) {
                var f0 = Vector128Constants.YGroup2Unzip_ShuffleX2OnByte_UInt32_X;
                var f0B = Vector128Constants.YGroup2Unzip_ShuffleX2OnByte_UInt32_X_Part1;
                var f1 = Vector128Constants.YGroup2Unzip_ShuffleX2OnByte_UInt32_Y;
                var f1B = Vector128Constants.YGroup2Unzip_ShuffleX2OnByte_UInt32_Y_Part1;
                var a0 = PackedSimd.Or(PackedSimd.Swizzle(data0.AsByte(), f0), PackedSimd.Swizzle(data1.AsByte(), f0B));
                var a1 = PackedSimd.Or(PackedSimd.Swizzle(data0.AsByte(), f1), PackedSimd.Swizzle(data1.AsByte(), f1B));
                y = a1.AsUInt32();
                return a0.AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{long}, Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup2Unzip_Shuffle(Vector128<long> data0, Vector128<long> data1, out Vector128<long> y) {
                var d0 = YGroup2Unzip_Shuffle(data0.AsUInt64(), data1.AsUInt64(), out var d1);
                y = d1.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{ulong}, Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup2Unzip_Shuffle(Vector128<ulong> data0, Vector128<ulong> data1, out Vector128<ulong> y) {
                var f0 = Vector128Constants.YGroup2Unzip_ShuffleX2OnByte_UInt64_X;
                var f0B = Vector128Constants.YGroup2Unzip_ShuffleX2OnByte_UInt64_X_Part1;
                var f1 = Vector128Constants.YGroup2Unzip_ShuffleX2OnByte_UInt64_Y;
                var f1B = Vector128Constants.YGroup2Unzip_ShuffleX2OnByte_UInt64_Y_Part1;
                var a0 = PackedSimd.Or(PackedSimd.Swizzle(data0.AsByte(), f0), PackedSimd.Swizzle(data1.AsByte(), f0B));
                var a1 = PackedSimd.Or(PackedSimd.Swizzle(data0.AsByte(), f1), PackedSimd.Swizzle(data1.AsByte(), f1B));
                y = a1.AsUInt64();
                return a0.AsUInt64();
            }

            /// <inheritdoc cref="Vector128s.YGroup2Unzip(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static (Vector128<float> X, Vector128<float> Y) YGroup2Unzip_Shuffle(Vector128<float> data0, Vector128<float> data1) {
                (var rt0, var rt1) = YGroup2Unzip_Shuffle(data0.AsUInt32(), data1.AsUInt32());
                return (rt0.AsSingle(), rt1.AsSingle());
            }

            /// <inheritdoc cref="Vector128s.YGroup2Unzip(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static (Vector128<double> X, Vector128<double> Y) YGroup2Unzip_Shuffle(Vector128<double> data0, Vector128<double> data1) {
                (var rt0, var rt1) = YGroup2Unzip_Shuffle(data0.AsUInt64(), data1.AsUInt64());
                return (rt0.AsDouble(), rt1.AsDouble());
            }

            /// <inheritdoc cref="Vector128s.YGroup2Unzip(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static (Vector128<sbyte> X, Vector128<sbyte> Y) YGroup2Unzip_Shuffle(Vector128<sbyte> data0, Vector128<sbyte> data1) {
                (var rt0, var rt1) = YGroup2Unzip_Shuffle(data0.AsByte(), data1.AsByte());
                return (rt0.AsSByte(), rt1.AsSByte());
            }

            /// <inheritdoc cref="Vector128s.YGroup2Unzip(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static (Vector128<byte> X, Vector128<byte> Y) YGroup2Unzip_Shuffle(Vector128<byte> data0, Vector128<byte> data1) {
                var f0 = Vector128Constants.YGroup2Unzip_ShuffleX2_Byte_X;
                var f0B = Vector128Constants.YGroup2Unzip_ShuffleX2_Byte_X_Part1;
                var f1 = Vector128Constants.YGroup2Unzip_ShuffleX2_Byte_Y;
                var f1B = Vector128Constants.YGroup2Unzip_ShuffleX2_Byte_Y_Part1;
                var a0 = PackedSimd.Or(PackedSimd.Swizzle(data0, f0), PackedSimd.Swizzle(data1, f0B));
                var a1 = PackedSimd.Or(PackedSimd.Swizzle(data0, f1), PackedSimd.Swizzle(data1, f1B));
                return (a0, a1);
            }

            /// <inheritdoc cref="Vector128s.YGroup2Unzip(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static (Vector128<short> X, Vector128<short> Y) YGroup2Unzip_Shuffle(Vector128<short> data0, Vector128<short> data1) {
                (var rt0, var rt1) = YGroup2Unzip_Shuffle(data0.AsUInt16(), data1.AsUInt16());
                return (rt0.AsInt16(), rt1.AsInt16());
            }

            /// <inheritdoc cref="Vector128s.YGroup2Unzip(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static (Vector128<ushort> X, Vector128<ushort> Y) YGroup2Unzip_Shuffle(Vector128<ushort> data0, Vector128<ushort> data1) {
                var f0 = Vector128Constants.YGroup2Unzip_ShuffleX2OnByte_UInt16_X;
                var f0B = Vector128Constants.YGroup2Unzip_ShuffleX2OnByte_UInt16_X_Part1;
                var f1 = Vector128Constants.YGroup2Unzip_ShuffleX2OnByte_UInt16_Y;
                var f1B = Vector128Constants.YGroup2Unzip_ShuffleX2OnByte_UInt16_Y_Part1;
                var a0 = PackedSimd.Or(PackedSimd.Swizzle(data0.AsByte(), f0), PackedSimd.Swizzle(data1.AsByte(), f0B));
                var a1 = PackedSimd.Or(PackedSimd.Swizzle(data0.AsByte(), f1), PackedSimd.Swizzle(data1.AsByte(), f1B));
                return (a0.AsUInt16(), a1.AsUInt16());
            }

            /// <inheritdoc cref="Vector128s.YGroup2Unzip(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static (Vector128<int> X, Vector128<int> Y) YGroup2Unzip_Shuffle(Vector128<int> data0, Vector128<int> data1) {
                (var rt0, var rt1) = YGroup2Unzip_Shuffle(data0.AsUInt32(), data1.AsUInt32());
                return (rt0.AsInt32(), rt1.AsInt32());
            }

            /// <inheritdoc cref="Vector128s.YGroup2Unzip(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static (Vector128<uint> X, Vector128<uint> Y) YGroup2Unzip_Shuffle(Vector128<uint> data0, Vector128<uint> data1) {
                var f0 = Vector128Constants.YGroup2Unzip_ShuffleX2OnByte_UInt32_X;
                var f0B = Vector128Constants.YGroup2Unzip_ShuffleX2OnByte_UInt32_X_Part1;
                var f1 = Vector128Constants.YGroup2Unzip_ShuffleX2OnByte_UInt32_Y;
                var f1B = Vector128Constants.YGroup2Unzip_ShuffleX2OnByte_UInt32_Y_Part1;
                var a0 = PackedSimd.Or(PackedSimd.Swizzle(data0.AsByte(), f0), PackedSimd.Swizzle(data1.AsByte(), f0B));
                var a1 = PackedSimd.Or(PackedSimd.Swizzle(data0.AsByte(), f1), PackedSimd.Swizzle(data1.AsByte(), f1B));
                return (a0.AsUInt32(), a1.AsUInt32());
            }

            /// <inheritdoc cref="Vector128s.YGroup2Unzip(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static (Vector128<long> X, Vector128<long> Y) YGroup2Unzip_Shuffle(Vector128<long> data0, Vector128<long> data1) {
                (var rt0, var rt1) = YGroup2Unzip_Shuffle(data0.AsUInt64(), data1.AsUInt64());
                return (rt0.AsInt64(), rt1.AsInt64());
            }

            /// <inheritdoc cref="Vector128s.YGroup2Unzip(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static (Vector128<ulong> X, Vector128<ulong> Y) YGroup2Unzip_Shuffle(Vector128<ulong> data0, Vector128<ulong> data1) {
                var f0 = Vector128Constants.YGroup2Unzip_ShuffleX2OnByte_UInt64_X;
                var f0B = Vector128Constants.YGroup2Unzip_ShuffleX2OnByte_UInt64_X_Part1;
                var f1 = Vector128Constants.YGroup2Unzip_ShuffleX2OnByte_UInt64_Y;
                var f1B = Vector128Constants.YGroup2Unzip_ShuffleX2OnByte_UInt64_Y_Part1;
                var a0 = PackedSimd.Or(PackedSimd.Swizzle(data0.AsByte(), f0), PackedSimd.Swizzle(data1.AsByte(), f0B));
                var a1 = PackedSimd.Or(PackedSimd.Swizzle(data0.AsByte(), f1), PackedSimd.Swizzle(data1.AsByte(), f1B));
                return (a0.AsUInt64(), a1.AsUInt64());
            }


            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2UnzipEven_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup2UnzipEven(Vector128<float> data0, Vector128<float> data1) {
                return YGroup2UnzipEven_Shuffle(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup2UnzipEven(Vector128<double> data0, Vector128<double> data1) {
                return YGroup2UnzipEven_Shuffle(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup2UnzipEven(Vector128<sbyte> data0, Vector128<sbyte> data1) {
                return YGroup2UnzipEven_Shuffle(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup2UnzipEven(Vector128<byte> data0, Vector128<byte> data1) {
                return YGroup2UnzipEven_Shuffle(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup2UnzipEven(Vector128<short> data0, Vector128<short> data1) {
                return YGroup2UnzipEven_Shuffle(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup2UnzipEven(Vector128<ushort> data0, Vector128<ushort> data1) {
                return YGroup2UnzipEven_Shuffle(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup2UnzipEven(Vector128<int> data0, Vector128<int> data1) {
                return YGroup2UnzipEven_Shuffle(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup2UnzipEven(Vector128<uint> data0, Vector128<uint> data1) {
                return YGroup2UnzipEven_Shuffle(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup2UnzipEven(Vector128<long> data0, Vector128<long> data1) {
                return YGroup2UnzipEven_Shuffle(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup2UnzipEven(Vector128<ulong> data0, Vector128<ulong> data1) {
                return YGroup2UnzipEven_Shuffle(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup2UnzipEven_Narrow(Vector128<float> data0, Vector128<float> data1) {
                return YGroup2UnzipEven_Narrow(data0.AsUInt32(), data1.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup2UnzipEven_Narrow(Vector128<sbyte> data0, Vector128<sbyte> data1) {
                return YGroup2UnzipEven_Narrow(data0.AsByte(), data1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup2UnzipEven_Narrow(Vector128<byte> data0, Vector128<byte> data1) {
                const int L = 8;
                Vector128<byte> rt0, rt1;
                Vector128<ushort> temp0 = data0.AsUInt16();
                Vector128<ushort> temp1 = data1.AsUInt16();
                if (BitConverter.IsLittleEndian) {
                    rt0 = Narrow(temp0, temp1);
                    return rt0;
                } else {
                    temp0 = PackedSimd.ShiftRightLogical(temp0, L);
                    temp1 = PackedSimd.ShiftRightLogical(temp1, L);
                    rt1 = Narrow(temp0, temp1);
                    return rt1;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup2UnzipEven_Narrow(Vector128<short> data0, Vector128<short> data1) {
                return YGroup2UnzipEven_Narrow(data0.AsUInt16(), data1.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup2UnzipEven_Narrow(Vector128<ushort> data0, Vector128<ushort> data1) {
                const int L = 16;
                Vector128<ushort> rt0, rt1;
                Vector128<uint> temp0 = data0.AsUInt32();
                Vector128<uint> temp1 = data1.AsUInt32();
                if (BitConverter.IsLittleEndian) {
                    rt0 = Narrow(temp0, temp1);
                    return rt0;
                } else {
                    temp0 = PackedSimd.ShiftRightLogical(temp0, L);
                    temp1 = PackedSimd.ShiftRightLogical(temp1, L);
                    rt1 = Narrow(temp0, temp1);
                    return rt1;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup2UnzipEven_Narrow(Vector128<int> data0, Vector128<int> data1) {
                return YGroup2UnzipEven_Narrow(data0.AsUInt32(), data1.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup2UnzipEven_Narrow(Vector128<uint> data0, Vector128<uint> data1) {
                const int L = 32;
                Vector128<uint> rt0, rt1;
                Vector128<ulong> temp0 = data0.AsUInt64();
                Vector128<ulong> temp1 = data1.AsUInt64();
                if (BitConverter.IsLittleEndian) {
                    rt0 = Narrow(temp0, temp1);
                    return rt0;
                } else {
                    temp0 = PackedSimd.ShiftRightLogical(temp0, L);
                    temp1 = PackedSimd.ShiftRightLogical(temp1, L);
                    rt1 = Narrow(temp0, temp1);
                    return rt1;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup2UnzipEven_Shuffle(Vector128<float> data0, Vector128<float> data1) {
                return YGroup2UnzipEven_Shuffle(data0.AsUInt32(), data1.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup2UnzipEven_Shuffle(Vector128<double> data0, Vector128<double> data1) {
                return YGroup2UnzipEven_Shuffle(data0.AsUInt64(), data1.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup2UnzipEven_Shuffle(Vector128<sbyte> data0, Vector128<sbyte> data1) {
                return YGroup2UnzipEven_Shuffle(data0.AsByte(), data1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup2UnzipEven_Shuffle(Vector128<byte> data0, Vector128<byte> data1) {
                var f0 = Vector128Constants.YGroup2Unzip_ShuffleX2_Byte_X;
                var f0B = Vector128Constants.YGroup2Unzip_ShuffleX2_Byte_X_Part1;
                return PackedSimd.Or(PackedSimd.Swizzle(data0, f0), PackedSimd.Swizzle(data1, f0B));
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup2UnzipEven_Shuffle(Vector128<short> data0, Vector128<short> data1) {
                return YGroup2UnzipEven_Shuffle(data0.AsUInt16(), data1.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup2UnzipEven_Shuffle(Vector128<ushort> data0, Vector128<ushort> data1) {
                var f0 = Vector128Constants.YGroup2Unzip_ShuffleX2OnByte_UInt16_X;
                var f0B = Vector128Constants.YGroup2Unzip_ShuffleX2OnByte_UInt16_X_Part1;
                return PackedSimd.Or(PackedSimd.Swizzle(data0.AsByte(), f0), PackedSimd.Swizzle(data1.AsByte(), f0B)).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup2UnzipEven_Shuffle(Vector128<int> data0, Vector128<int> data1) {
                return YGroup2UnzipEven_Shuffle(data0.AsUInt32(), data1.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup2UnzipEven_Shuffle(Vector128<uint> data0, Vector128<uint> data1) {
                var f0 = Vector128Constants.YGroup2Unzip_ShuffleX2OnByte_UInt32_X;
                var f0B = Vector128Constants.YGroup2Unzip_ShuffleX2OnByte_UInt32_X_Part1;
                return PackedSimd.Or(PackedSimd.Swizzle(data0.AsByte(), f0), PackedSimd.Swizzle(data1.AsByte(), f0B)).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup2UnzipEven_Shuffle(Vector128<long> data0, Vector128<long> data1) {
                return YGroup2UnzipEven_Shuffle(data0.AsUInt64(), data1.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup2UnzipEven_Shuffle(Vector128<ulong> data0, Vector128<ulong> data1) {
                var f0 = Vector128Constants.YGroup2Unzip_ShuffleX2OnByte_UInt64_X;
                var f0B = Vector128Constants.YGroup2Unzip_ShuffleX2OnByte_UInt64_X_Part1;
                return PackedSimd.Or(PackedSimd.Swizzle(data0.AsByte(), f0), PackedSimd.Swizzle(data1.AsByte(), f0B)).AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2UnzipOdd_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup2UnzipOdd(Vector128<float> data0, Vector128<float> data1) {
                return YGroup2UnzipOdd_Shuffle(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup2UnzipOdd(Vector128<double> data0, Vector128<double> data1) {
                return YGroup2UnzipOdd_Shuffle(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup2UnzipOdd(Vector128<sbyte> data0, Vector128<sbyte> data1) {
                return YGroup2UnzipOdd_Shuffle(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup2UnzipOdd(Vector128<byte> data0, Vector128<byte> data1) {
                return YGroup2UnzipOdd_Shuffle(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup2UnzipOdd(Vector128<short> data0, Vector128<short> data1) {
                return YGroup2UnzipOdd_Shuffle(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup2UnzipOdd(Vector128<ushort> data0, Vector128<ushort> data1) {
                return YGroup2UnzipOdd_Shuffle(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup2UnzipOdd(Vector128<int> data0, Vector128<int> data1) {
                return YGroup2UnzipOdd_Shuffle(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup2UnzipOdd(Vector128<uint> data0, Vector128<uint> data1) {
                return YGroup2UnzipOdd_Shuffle(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup2UnzipOdd(Vector128<long> data0, Vector128<long> data1) {
                return YGroup2UnzipOdd_Shuffle(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup2UnzipOdd(Vector128<ulong> data0, Vector128<ulong> data1) {
                return YGroup2UnzipOdd_Shuffle(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup2UnzipOdd_Narrow(Vector128<float> data0, Vector128<float> data1) {
                return YGroup2UnzipOdd_Narrow(data0.AsUInt32(), data1.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup2UnzipOdd_Narrow(Vector128<sbyte> data0, Vector128<sbyte> data1) {
                return YGroup2UnzipOdd_Narrow(data0.AsByte(), data1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup2UnzipOdd_Narrow(Vector128<byte> data0, Vector128<byte> data1) {
                const int L = 8;
                Vector128<byte> rt0, rt1;
                Vector128<ushort> temp0 = data0.AsUInt16();
                Vector128<ushort> temp1 = data1.AsUInt16();
                if (BitConverter.IsLittleEndian) {
                    temp0 = PackedSimd.ShiftRightLogical(temp0, L);
                    temp1 = PackedSimd.ShiftRightLogical(temp1, L);
                    rt1 = Narrow(temp0, temp1);
                    return rt1;
                } else {
                    rt0 = Narrow(temp0, temp1);
                    return rt0;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup2UnzipOdd_Narrow(Vector128<short> data0, Vector128<short> data1) {
                return YGroup2UnzipOdd_Narrow(data0.AsUInt16(), data1.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup2UnzipOdd_Narrow(Vector128<ushort> data0, Vector128<ushort> data1) {
                const int L = 16;
                Vector128<ushort> rt0, rt1;
                Vector128<uint> temp0 = data0.AsUInt32();
                Vector128<uint> temp1 = data1.AsUInt32();
                if (BitConverter.IsLittleEndian) {
                    temp0 = PackedSimd.ShiftRightLogical(temp0, L);
                    temp1 = PackedSimd.ShiftRightLogical(temp1, L);
                    rt1 = Narrow(temp0, temp1);
                    return rt1;
                } else {
                    rt0 = Narrow(temp0, temp1);
                    return rt0;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup2UnzipOdd_Narrow(Vector128<int> data0, Vector128<int> data1) {
                return YGroup2UnzipOdd_Narrow(data0.AsUInt32(), data1.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup2UnzipOdd_Narrow(Vector128<uint> data0, Vector128<uint> data1) {
                const int L = 32;
                Vector128<uint> rt0, rt1;
                Vector128<ulong> temp0 = data0.AsUInt64();
                Vector128<ulong> temp1 = data1.AsUInt64();
                if (BitConverter.IsLittleEndian) {
                    temp0 = PackedSimd.ShiftRightLogical(temp0, L);
                    temp1 = PackedSimd.ShiftRightLogical(temp1, L);
                    rt1 = Narrow(temp0, temp1);
                    return rt1;
                } else {
                    rt0 = Narrow(temp0, temp1);
                    return rt0;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup2UnzipOdd_Shuffle(Vector128<float> data0, Vector128<float> data1) {
                return YGroup2UnzipOdd_Shuffle(data0.AsUInt32(), data1.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup2UnzipOdd_Shuffle(Vector128<double> data0, Vector128<double> data1) {
                return YGroup2UnzipOdd_Shuffle(data0.AsUInt64(), data1.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup2UnzipOdd_Shuffle(Vector128<sbyte> data0, Vector128<sbyte> data1) {
                return YGroup2UnzipOdd_Shuffle(data0.AsByte(), data1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup2UnzipOdd_Shuffle(Vector128<byte> data0, Vector128<byte> data1) {
                var f1 = Vector128Constants.YGroup2Unzip_ShuffleX2_Byte_Y;
                var f1B = Vector128Constants.YGroup2Unzip_ShuffleX2_Byte_Y_Part1;
                return PackedSimd.Or(PackedSimd.Swizzle(data0, f1), PackedSimd.Swizzle(data1, f1B));
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup2UnzipOdd_Shuffle(Vector128<short> data0, Vector128<short> data1) {
                return YGroup2UnzipOdd_Shuffle(data0.AsUInt16(), data1.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup2UnzipOdd_Shuffle(Vector128<ushort> data0, Vector128<ushort> data1) {
                var f1 = Vector128Constants.YGroup2Unzip_ShuffleX2OnByte_UInt16_Y;
                var f1B = Vector128Constants.YGroup2Unzip_ShuffleX2OnByte_UInt16_Y_Part1;
                return PackedSimd.Or(PackedSimd.Swizzle(data0.AsByte(), f1), PackedSimd.Swizzle(data1.AsByte(), f1B)).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup2UnzipOdd_Shuffle(Vector128<int> data0, Vector128<int> data1) {
                return YGroup2UnzipOdd_Shuffle(data0.AsUInt32(), data1.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup2UnzipOdd_Shuffle(Vector128<uint> data0, Vector128<uint> data1) {
                var f1 = Vector128Constants.YGroup2Unzip_ShuffleX2OnByte_UInt32_Y;
                var f1B = Vector128Constants.YGroup2Unzip_ShuffleX2OnByte_UInt32_Y_Part1;
                return PackedSimd.Or(PackedSimd.Swizzle(data0.AsByte(), f1), PackedSimd.Swizzle(data1.AsByte(), f1B)).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup2UnzipOdd_Shuffle(Vector128<long> data0, Vector128<long> data1) {
                return YGroup2UnzipOdd_Shuffle(data0.AsUInt64(), data1.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup2UnzipOdd_Shuffle(Vector128<ulong> data0, Vector128<ulong> data1) {
                var f1 = Vector128Constants.YGroup2Unzip_ShuffleX2OnByte_UInt64_Y;
                var f1B = Vector128Constants.YGroup2Unzip_ShuffleX2OnByte_UInt64_Y_Part1;
                return PackedSimd.Or(PackedSimd.Swizzle(data0.AsByte(), f1), PackedSimd.Swizzle(data1.AsByte(), f1B)).AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2Zip_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.Most32Types;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{float}, Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup2Zip(Vector128<float> x, Vector128<float> y, out Vector128<float> data1) {
                return YGroup2Zip_Widen(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{double}, Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup2Zip(Vector128<double> x, Vector128<double> y, out Vector128<double> data1) {
                return SuperStatics.YGroup2Zip(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup2Zip(Vector128<sbyte> x, Vector128<sbyte> y, out Vector128<sbyte> data1) {
                return YGroup2Zip_Widen(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{byte}, Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup2Zip(Vector128<byte> x, Vector128<byte> y, out Vector128<byte> data1) {
                // Base = _Widen >= _ShuffleX > _Shuffle
                return YGroup2Zip_Widen(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{short}, Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup2Zip(Vector128<short> x, Vector128<short> y, out Vector128<short> data1) {
                return YGroup2Zip_Widen(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{ushort}, Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup2Zip(Vector128<ushort> x, Vector128<ushort> y, out Vector128<ushort> data1) {
                return YGroup2Zip_Widen(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{int}, Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup2Zip(Vector128<int> x, Vector128<int> y, out Vector128<int> data1) {
                return YGroup2Zip_Widen(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{uint}, Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup2Zip(Vector128<uint> x, Vector128<uint> y, out Vector128<uint> data1) {
                return YGroup2Zip_Widen(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{long}, Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup2Zip(Vector128<long> x, Vector128<long> y, out Vector128<long> data1) {
                return SuperStatics.YGroup2Zip(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{ulong}, Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup2Zip(Vector128<ulong> x, Vector128<ulong> y, out Vector128<ulong> data1) {
                return SuperStatics.YGroup2Zip(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{float}, Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup2Zip_Widen(Vector128<float> x, Vector128<float> y, out Vector128<float> data1) {
                var d0 = YGroup2Zip_Widen(x.AsUInt32(), y.AsUInt32(), out var d1);
                data1 = d1.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup2Zip_Widen(Vector128<sbyte> x, Vector128<sbyte> y, out Vector128<sbyte> data1) {
                var d0 = YGroup2Zip_Widen(x.AsByte(), y.AsByte(), out var d1);
                data1 = d1.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{byte}, Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup2Zip_Widen(Vector128<byte> x, Vector128<byte> y, out Vector128<byte> data1) {
                const int L = 8;
                Vector128<ushort> a0, a1, b0, b1;
                if (BitConverter.IsLittleEndian) {
                    Widen(y, out b0, out b1);
                    Widen(x, out a0, out a1);
                } else {
                    Widen(x, out b0, out b1);
                    Widen(y, out a0, out a1);
                }
                b0 = PackedSimd.ShiftLeft(b0, L);
                b1 = PackedSimd.ShiftLeft(b1, L);
                a0 = PackedSimd.Or(a0, b0);
                a1 = PackedSimd.Or(a1, b1);
                data1 = a1.AsByte();
                return a0.AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{short}, Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup2Zip_Widen(Vector128<short> x, Vector128<short> y, out Vector128<short> data1) {
                var d0 = YGroup2Zip_Widen(x.AsUInt16(), y.AsUInt16(), out var d1);
                data1 = d1.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{ushort}, Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup2Zip_Widen(Vector128<ushort> x, Vector128<ushort> y, out Vector128<ushort> data1) {
                const int L = 16;
                Vector128<uint> a0, a1, b0, b1;
                if (BitConverter.IsLittleEndian) {
                    Widen(y, out b0, out b1);
                    Widen(x, out a0, out a1);
                } else {
                    Widen(x, out b0, out b1);
                    Widen(y, out a0, out a1);
                }
                b0 = PackedSimd.ShiftLeft(b0, L);
                b1 = PackedSimd.ShiftLeft(b1, L);
                a0 = PackedSimd.Or(a0, b0);
                a1 = PackedSimd.Or(a1, b1);
                data1 = a1.AsUInt16();
                return a0.AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{int}, Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup2Zip_Widen(Vector128<int> x, Vector128<int> y, out Vector128<int> data1) {
                var d0 = YGroup2Zip_Widen(x.AsUInt32(), y.AsUInt32(), out var d1);
                data1 = d1.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{uint}, Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup2Zip_Widen(Vector128<uint> x, Vector128<uint> y, out Vector128<uint> data1) {
                const int L = 32;
                Vector128<ulong> a0, a1, b0, b1;
                if (BitConverter.IsLittleEndian) {
                    Widen(y, out b0, out b1);
                    Widen(x, out a0, out a1);
                } else {
                    Widen(x, out b0, out b1);
                    Widen(y, out a0, out a1);
                }
                b0 = PackedSimd.ShiftLeft(b0, L);
                b1 = PackedSimd.ShiftLeft(b1, L);
                a0 = PackedSimd.Or(a0, b0);
                a1 = PackedSimd.Or(a1, b1);
                data1 = a1.AsUInt32();
                return a0.AsUInt32();
            }


            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2ZipHigh_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.Most32Types;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup2ZipHigh(Vector128<float> x, Vector128<float> y) {
                return SuperStatics.YGroup2ZipHigh(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup2ZipHigh(Vector128<double> x, Vector128<double> y) {
                return SuperStatics.YGroup2ZipHigh(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup2ZipHigh(Vector128<sbyte> x, Vector128<sbyte> y) {
                return SuperStatics.YGroup2ZipHigh(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup2ZipHigh(Vector128<byte> x, Vector128<byte> y) {
                return SuperStatics.YGroup2ZipHigh(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup2ZipHigh(Vector128<short> x, Vector128<short> y) {
                return SuperStatics.YGroup2ZipHigh(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup2ZipHigh(Vector128<ushort> x, Vector128<ushort> y) {
                return SuperStatics.YGroup2ZipHigh(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup2ZipHigh(Vector128<int> x, Vector128<int> y) {
                return SuperStatics.YGroup2ZipHigh(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup2ZipHigh(Vector128<uint> x, Vector128<uint> y) {
                return SuperStatics.YGroup2ZipHigh(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup2ZipHigh(Vector128<long> x, Vector128<long> y) {
                return SuperStatics.YGroup2ZipHigh(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup2ZipHigh(Vector128<ulong> x, Vector128<ulong> y) {
                return SuperStatics.YGroup2ZipHigh(x, y);
            }


            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2ZipLow_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.Most32Types;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup2ZipLow(Vector128<float> x, Vector128<float> y) {
                return SuperStatics.YGroup2ZipLow(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup2ZipLow(Vector128<double> x, Vector128<double> y) {
                return SuperStatics.YGroup2ZipLow(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup2ZipLow(Vector128<sbyte> x, Vector128<sbyte> y) {
                return SuperStatics.YGroup2ZipLow(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup2ZipLow(Vector128<byte> x, Vector128<byte> y) {
                return SuperStatics.YGroup2ZipLow(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup2ZipLow(Vector128<short> x, Vector128<short> y) {
                return SuperStatics.YGroup2ZipLow(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup2ZipLow(Vector128<ushort> x, Vector128<ushort> y) {
                return SuperStatics.YGroup2ZipLow(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup2ZipLow(Vector128<int> x, Vector128<int> y) {
                return SuperStatics.YGroup2ZipLow(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup2ZipLow(Vector128<uint> x, Vector128<uint> y) {
                return SuperStatics.YGroup2ZipLow(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup2ZipLow(Vector128<long> x, Vector128<long> y) {
                return SuperStatics.YGroup2ZipLow(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup2ZipLow(Vector128<ulong> x, Vector128<ulong> y) {
                return SuperStatics.YGroup2ZipLow(x, y);
            }


            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup4Unzip_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.Most32Types;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup4Unzip(Vector128<float> data0, Vector128<float> data1, Vector128<float> data2, Vector128<float> data3, out Vector128<float> y, out Vector128<float> z, out Vector128<float> w) {
                return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup4Unzip(Vector128<double> data0, Vector128<double> data1, Vector128<double> data2, Vector128<double> data3, out Vector128<double> y, out Vector128<double> z, out Vector128<double> w) {
                return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup4Unzip(Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2, Vector128<sbyte> data3, out Vector128<sbyte> y, out Vector128<sbyte> z, out Vector128<sbyte> w) {
                return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup4Unzip(Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2, Vector128<byte> data3, out Vector128<byte> y, out Vector128<byte> z, out Vector128<byte> w) {
                return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup4Unzip(Vector128<short> data0, Vector128<short> data1, Vector128<short> data2, Vector128<short> data3, out Vector128<short> y, out Vector128<short> z, out Vector128<short> w) {
                return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup4Unzip(Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2, Vector128<ushort> data3, out Vector128<ushort> y, out Vector128<ushort> z, out Vector128<ushort> w) {
                return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup4Unzip(Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, Vector128<int> data3, out Vector128<int> y, out Vector128<int> z, out Vector128<int> w) {
                return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup4Unzip(Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, Vector128<uint> data3, out Vector128<uint> y, out Vector128<uint> z, out Vector128<uint> w) {
                return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup4Unzip(Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, Vector128<long> data3, out Vector128<long> y, out Vector128<long> z, out Vector128<long> w) {
                return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup4Unzip(Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, Vector128<ulong> data3, out Vector128<ulong> y, out Vector128<ulong> z, out Vector128<ulong> w) {
                return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup4Unzip_Narrow(Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2, Vector128<sbyte> data3, out Vector128<sbyte> y, out Vector128<sbyte> z, out Vector128<sbyte> w) {
                var d0 = YGroup4Unzip_Narrow(data0.AsByte(), data1.AsByte(), data2.AsByte(), data3.AsByte(), out var d1, out var d2, out var d3);
                y = d1.AsSByte();
                z = d2.AsSByte();
                w = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup4Unzip_Narrow(Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2, Vector128<byte> data3, out Vector128<byte> y, out Vector128<byte> z, out Vector128<byte> w) {
                const int L = 8;
                Vector128<byte> rt0, rt1, rt2, rt3;
                Vector128<uint> temp0, temp1, temp2, temp3;
                temp0 = data0.AsUInt32();
                temp1 = data1.AsUInt32();
                temp2 = data2.AsUInt32();
                temp3 = data3.AsUInt32();
                rt0 = Narrow(Narrow(temp0, temp1), Narrow(temp2, temp3));
                temp0 = PackedSimd.ShiftRightLogical(temp0, L);
                temp1 = PackedSimd.ShiftRightLogical(temp1, L);
                temp2 = PackedSimd.ShiftRightLogical(temp2, L);
                temp3 = PackedSimd.ShiftRightLogical(temp3, L);
                rt1 = Narrow(Narrow(temp0, temp1), Narrow(temp2, temp3));
                temp0 = PackedSimd.ShiftRightLogical(temp0, L);
                temp1 = PackedSimd.ShiftRightLogical(temp1, L);
                temp2 = PackedSimd.ShiftRightLogical(temp2, L);
                temp3 = PackedSimd.ShiftRightLogical(temp3, L);
                rt2 = Narrow(Narrow(temp0, temp1), Narrow(temp2, temp3));
                temp0 = PackedSimd.ShiftRightLogical(temp0, L);
                temp1 = PackedSimd.ShiftRightLogical(temp1, L);
                temp2 = PackedSimd.ShiftRightLogical(temp2, L);
                temp3 = PackedSimd.ShiftRightLogical(temp3, L);
                rt3 = Narrow(Narrow(temp0, temp1), Narrow(temp2, temp3));
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

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup4Unzip_Narrow(Vector128<short> data0, Vector128<short> data1, Vector128<short> data2, Vector128<short> data3, out Vector128<short> y, out Vector128<short> z, out Vector128<short> w) {
                var d0 = YGroup4Unzip_Narrow(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), data3.AsUInt16(), out var d1, out var d2, out var d3);
                y = d1.AsInt16();
                z = d2.AsInt16();
                w = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup4Unzip_Narrow(Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2, Vector128<ushort> data3, out Vector128<ushort> y, out Vector128<ushort> z, out Vector128<ushort> w) {
                const int L = 16;
                Vector128<ushort> rt0, rt1, rt2, rt3;
                Vector128<ulong> temp0, temp1, temp2, temp3;
                temp0 = data0.AsUInt64();
                temp1 = data1.AsUInt64();
                temp2 = data2.AsUInt64();
                temp3 = data3.AsUInt64();
                rt0 = Narrow(Narrow(temp0, temp1), Narrow(temp2, temp3));
                temp0 = PackedSimd.ShiftRightLogical(temp0, L);
                temp1 = PackedSimd.ShiftRightLogical(temp1, L);
                temp2 = PackedSimd.ShiftRightLogical(temp2, L);
                temp3 = PackedSimd.ShiftRightLogical(temp3, L);
                rt1 = Narrow(Narrow(temp0, temp1), Narrow(temp2, temp3));
                temp0 = PackedSimd.ShiftRightLogical(temp0, L);
                temp1 = PackedSimd.ShiftRightLogical(temp1, L);
                temp2 = PackedSimd.ShiftRightLogical(temp2, L);
                temp3 = PackedSimd.ShiftRightLogical(temp3, L);
                rt2 = Narrow(Narrow(temp0, temp1), Narrow(temp2, temp3));
                temp0 = PackedSimd.ShiftRightLogical(temp0, L);
                temp1 = PackedSimd.ShiftRightLogical(temp1, L);
                temp2 = PackedSimd.ShiftRightLogical(temp2, L);
                temp3 = PackedSimd.ShiftRightLogical(temp3, L);
                rt3 = Narrow(Narrow(temp0, temp1), Narrow(temp2, temp3));
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

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup4Unzip_Unzip(Vector128<float> data0, Vector128<float> data1, Vector128<float> data2, Vector128<float> data3, out Vector128<float> y, out Vector128<float> z, out Vector128<float> w) {
                var d0 = YGroup4Unzip_Unzip(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), out var d1, out var d2, out var d3);
                y = d1.AsSingle();
                z = d2.AsSingle();
                w = d3.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup4Unzip_Unzip(Vector128<double> data0, Vector128<double> data1, Vector128<double> data2, Vector128<double> data3, out Vector128<double> y, out Vector128<double> z, out Vector128<double> w) {
                var d0 = YGroup4Unzip_Unzip(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), data3.AsUInt64(), out var d1, out var d2, out var d3);
                y = d1.AsDouble();
                z = d2.AsDouble();
                w = d3.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup4Unzip_Unzip(Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2, Vector128<sbyte> data3, out Vector128<sbyte> y, out Vector128<sbyte> z, out Vector128<sbyte> w) {
                var d0 = YGroup4Unzip_Unzip(data0.AsByte(), data1.AsByte(), data2.AsByte(), data3.AsByte(), out var d1, out var d2, out var d3);
                y = d1.AsSByte();
                z = d2.AsSByte();
                w = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup4Unzip_Unzip(Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2, Vector128<byte> data3, out Vector128<byte> y, out Vector128<byte> z, out Vector128<byte> w) {
                Vector128<byte> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
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

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup4Unzip_Unzip(Vector128<short> data0, Vector128<short> data1, Vector128<short> data2, Vector128<short> data3, out Vector128<short> y, out Vector128<short> z, out Vector128<short> w) {
                var d0 = YGroup4Unzip_Unzip(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), data3.AsUInt16(), out var d1, out var d2, out var d3);
                y = d1.AsInt16();
                z = d2.AsInt16();
                w = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup4Unzip_Unzip(Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2, Vector128<ushort> data3, out Vector128<ushort> y, out Vector128<ushort> z, out Vector128<ushort> w) {
                Vector128<ushort> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
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

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup4Unzip_Unzip(Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, Vector128<int> data3, out Vector128<int> y, out Vector128<int> z, out Vector128<int> w) {
                var d0 = YGroup4Unzip_Unzip(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), out var d1, out var d2, out var d3);
                y = d1.AsInt32();
                z = d2.AsInt32();
                w = d3.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup4Unzip_Unzip(Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, Vector128<uint> data3, out Vector128<uint> y, out Vector128<uint> z, out Vector128<uint> w) {
                Vector128<uint> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
                // 0 data0 x0 y0 z0 w0 data1 x1 y1 z1 w1 data2 x2 y2 z2 w2 data3 x3 y3 z3 w3
                // 1 a_0 x0 z0 x1 z1 a_1 x2 z2 x3 z3 a_2 y0 w0 y1 w1 a_3 y2 w2 y3 w3
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

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup4Unzip_Unzip(Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, Vector128<long> data3, out Vector128<long> y, out Vector128<long> z, out Vector128<long> w) {
                var d0 = YGroup4Unzip_Unzip(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), data3.AsUInt64(), out var d1, out var d2, out var d3);
                y = d1.AsInt64();
                z = d2.AsInt64();
                w = d3.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup4Unzip_Unzip(Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, Vector128<ulong> data3, out Vector128<ulong> y, out Vector128<ulong> z, out Vector128<ulong> w) {
                Vector128<ulong> a_0, a_1, a_2, a_3;
                // 0 data0 x0 y0 data1 z0 w0 data2 x1 y1 data3 z1 w1
                // 1 a_0 x0 x1 a_1 y0 y1 a_2 z0 z1 a_3 w0 w1
                a_0 = YGroup2Unzip(data0, data2, out a_1);
                a_2 = YGroup2Unzip(data1, data3, out a_3);
                y = a_1;
                z = a_2;
                w = a_3;
                return a_0;
            }


            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup4Zip_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.Most32Types;
                    return rt;
                }
            }
            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup4Zip(Vector128<float> x, Vector128<float> y, Vector128<float> z, Vector128<float> w, out Vector128<float> data1, out Vector128<float> data2, out Vector128<float> data3) {
                return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup4Zip(Vector128<double> x, Vector128<double> y, Vector128<double> z, Vector128<double> w, out Vector128<double> data1, out Vector128<double> data2, out Vector128<double> data3) {
                return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup4Zip(Vector128<sbyte> x, Vector128<sbyte> y, Vector128<sbyte> z, Vector128<sbyte> w, out Vector128<sbyte> data1, out Vector128<sbyte> data2, out Vector128<sbyte> data3) {
                return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup4Zip(Vector128<byte> x, Vector128<byte> y, Vector128<byte> z, Vector128<byte> w, out Vector128<byte> data1, out Vector128<byte> data2, out Vector128<byte> data3) {
                return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup4Zip(Vector128<short> x, Vector128<short> y, Vector128<short> z, Vector128<short> w, out Vector128<short> data1, out Vector128<short> data2, out Vector128<short> data3) {
                return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup4Zip(Vector128<ushort> x, Vector128<ushort> y, Vector128<ushort> z, Vector128<ushort> w, out Vector128<ushort> data1, out Vector128<ushort> data2, out Vector128<ushort> data3) {
                return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup4Zip(Vector128<int> x, Vector128<int> y, Vector128<int> z, Vector128<int> w, out Vector128<int> data1, out Vector128<int> data2, out Vector128<int> data3) {
                return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup4Zip(Vector128<uint> x, Vector128<uint> y, Vector128<uint> z, Vector128<uint> w, out Vector128<uint> data1, out Vector128<uint> data2, out Vector128<uint> data3) {
                return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup4Zip(Vector128<long> x, Vector128<long> y, Vector128<long> z, Vector128<long> w, out Vector128<long> data1, out Vector128<long> data2, out Vector128<long> data3) {
                return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup4Zip(Vector128<ulong> x, Vector128<ulong> y, Vector128<ulong> z, Vector128<ulong> w, out Vector128<ulong> data1, out Vector128<ulong> data2, out Vector128<ulong> data3) {
                return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup4Zip_Widen(Vector128<sbyte> x, Vector128<sbyte> y, Vector128<sbyte> z, Vector128<sbyte> w, out Vector128<sbyte> data1, out Vector128<sbyte> data2, out Vector128<sbyte> data3) {
                var d0 = YGroup4Zip_Widen(x.AsByte(), y.AsByte(), z.AsByte(), w.AsByte(), out var d1, out var d2, out var d3);
                data1 = d1.AsSByte();
                data2 = d2.AsSByte();
                data3 = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup4Zip_Widen(Vector128<byte> x, Vector128<byte> y, Vector128<byte> z, Vector128<byte> w, out Vector128<byte> data1, out Vector128<byte> data2, out Vector128<byte> data3) {
                const int L = 8;
                Vector128<byte> s0, s1, s2, s3;
                Vector128<ushort> t0, t1;
                Vector128<uint> r0, r1, r2, r3, d0, d1, d2, d3;
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
                Widen(s0, out t0, out t1);
                Widen(t0, out r0, out r1);
                Widen(t1, out r2, out r3);
                d0 = ShiftLeft(r0, L);
                d1 = ShiftLeft(r1, L);
                d2 = ShiftLeft(r2, L);
                d3 = ShiftLeft(r3, L);
                // Part 1
                Widen(s1, out t0, out t1);
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
                Widen(s2, out t0, out t1);
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
                Widen(s3, out t0, out t1);
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

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup4Zip_Widen(Vector128<short> x, Vector128<short> y, Vector128<short> z, Vector128<short> w, out Vector128<short> data1, out Vector128<short> data2, out Vector128<short> data3) {
                var d0 = YGroup4Zip_Widen(x.AsUInt16(), y.AsUInt16(), z.AsUInt16(), w.AsUInt16(), out var d1, out var d2, out var d3);
                data1 = d1.AsInt16();
                data2 = d2.AsInt16();
                data3 = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup4Zip_Widen(Vector128<ushort> x, Vector128<ushort> y, Vector128<ushort> z, Vector128<ushort> w, out Vector128<ushort> data1, out Vector128<ushort> data2, out Vector128<ushort> data3) {
                const int L = 16;
                Vector128<ushort> s0, s1, s2, s3;
                Vector128<uint> t0, t1;
                Vector128<ulong> r0, r1, r2, r3, d0, d1, d2, d3;
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
                Widen(s0, out t0, out t1);
                Widen(t0, out r0, out r1);
                Widen(t1, out r2, out r3);
                d0 = ShiftLeft(r0, L);
                d1 = ShiftLeft(r1, L);
                d2 = ShiftLeft(r2, L);
                d3 = ShiftLeft(r3, L);
                // Part 1
                Widen(s1, out t0, out t1);
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
                Widen(s2, out t0, out t1);
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
                Widen(s3, out t0, out t1);
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

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup4Zip_Zip(Vector128<float> x, Vector128<float> y, Vector128<float> z, Vector128<float> w, out Vector128<float> data1, out Vector128<float> data2, out Vector128<float> data3) {
                var d0 = YGroup4Zip_Zip(x.AsUInt32(), y.AsUInt32(), z.AsUInt32(), w.AsUInt32(), out var d1, out var d2, out var d3);
                data1 = d1.AsSingle();
                data2 = d2.AsSingle();
                data3 = d3.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup4Zip_Zip(Vector128<double> x, Vector128<double> y, Vector128<double> z, Vector128<double> w, out Vector128<double> data1, out Vector128<double> data2, out Vector128<double> data3) {
                var d0 = YGroup4Zip_Zip(x.AsUInt64(), y.AsUInt64(), z.AsUInt64(), w.AsUInt64(), out var d1, out var d2, out var d3);
                data1 = d1.AsDouble();
                data2 = d2.AsDouble();
                data3 = d3.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup4Zip_Zip(Vector128<sbyte> x, Vector128<sbyte> y, Vector128<sbyte> z, Vector128<sbyte> w, out Vector128<sbyte> data1, out Vector128<sbyte> data2, out Vector128<sbyte> data3) {
                var d0 = YGroup4Zip_Zip(x.AsByte(), y.AsByte(), z.AsByte(), w.AsByte(), out var d1, out var d2, out var d3);
                data1 = d1.AsSByte();
                data2 = d2.AsSByte();
                data3 = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup4Zip_Zip(Vector128<byte> x, Vector128<byte> y, Vector128<byte> z, Vector128<byte> w, out Vector128<byte> data1, out Vector128<byte> data2, out Vector128<byte> data3) {
                Vector128<byte> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
                // 0 b_0 x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 b_1 y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 b_2 z0 z1 z2 z3 z4 z5 z6 z7 z8 z9 z10 z11 z12 z13 z14 z15 b_3 w0 w1 w2 w3 w4 w5 w6 w7 w8 w9 w10 w11 w12 w13 w14 w15
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

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup4Zip_Zip(Vector128<short> x, Vector128<short> y, Vector128<short> z, Vector128<short> w, out Vector128<short> data1, out Vector128<short> data2, out Vector128<short> data3) {
                var d0 = YGroup4Zip_Zip(x.AsUInt16(), y.AsUInt16(), z.AsUInt16(), w.AsUInt16(), out var d1, out var d2, out var d3);
                data1 = d1.AsInt16();
                data2 = d2.AsInt16();
                data3 = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup4Zip_Zip(Vector128<ushort> x, Vector128<ushort> y, Vector128<ushort> z, Vector128<ushort> w, out Vector128<ushort> data1, out Vector128<ushort> data2, out Vector128<ushort> data3) {
                Vector128<ushort> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
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

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup4Zip_Zip(Vector128<int> x, Vector128<int> y, Vector128<int> z, Vector128<int> w, out Vector128<int> data1, out Vector128<int> data2, out Vector128<int> data3) {
                var d0 = YGroup4Zip_Zip(x.AsUInt32(), y.AsUInt32(), z.AsUInt32(), w.AsUInt32(), out var d1, out var d2, out var d3);
                data1 = d1.AsInt32();
                data2 = d2.AsInt32();
                data3 = d3.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup4Zip_Zip(Vector128<uint> x, Vector128<uint> y, Vector128<uint> z, Vector128<uint> w, out Vector128<uint> data1, out Vector128<uint> data2, out Vector128<uint> data3) {
                Vector128<uint> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
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

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup4Zip_Zip(Vector128<long> x, Vector128<long> y, Vector128<long> z, Vector128<long> w, out Vector128<long> data1, out Vector128<long> data2, out Vector128<long> data3) {
                var d0 = YGroup4Zip_Zip(x.AsUInt64(), y.AsUInt64(), z.AsUInt64(), w.AsUInt64(), out var d1, out var d2, out var d3);
                data1 = d1.AsInt64();
                data2 = d2.AsInt64();
                data3 = d3.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup4Zip_Zip(Vector128<ulong> x, Vector128<ulong> y, Vector128<ulong> z, Vector128<ulong> w, out Vector128<ulong> data1, out Vector128<ulong> data2, out Vector128<ulong> data3) {
                Vector128<ulong> a_0, a_1, a_2, a_3;
                // 0 a_0 x0 x1 a_1 y0 y1 a_2 z0 z1 a_3 w0 w1
                // 1 a_0 x0 y0 a_1 z0 w0 a_2 x1 y1 a_3 z1 w1
                a_0 = YGroup2Zip(x, y, out a_2);
                a_1 = YGroup2Zip(z, w, out a_3);
                data1 = a_1;
                data2 = a_2;
                data3 = a_3;
                return a_0;
            }

#endif // NET8_0_OR_GREATER
        }
    }
}
