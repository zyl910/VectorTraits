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
using System.Threading.Tasks;
#endif // NET8_0_OR_GREATER

namespace Zyl.VectorTraits.Impl.AVector128 {
    using SuperStatics = WVectorTraits128Base.Statics;

    partial class WVectorTraits128PackedSimd {

        partial class Statics {

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleG2_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{float}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleG2(Vector128<float> source, ShuffleControlG2 control) {
                return YShuffleG2(source.AsUInt32(), control).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{double}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleG2(Vector128<double> source, ShuffleControlG2 control) {
                return YShuffleG2(source.AsUInt64(), control).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{sbyte}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleG2(Vector128<sbyte> source, ShuffleControlG2 control) {
                return YShuffleG2(source.AsByte(), control).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{byte}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleG2(Vector128<byte> source, ShuffleControlG2 control) {
                Vector128<byte> indices = Vector128Constants.GetYShuffleG2_Byte_Indices(control); // It also supports _mm128_shuffle_epi8 for 128-bit lanes .
                return YShuffleKernel(source, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{short}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleG2(Vector128<short> source, ShuffleControlG2 control) {
                return YShuffleG2(source.AsUInt16(), control).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{ushort}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleG2(Vector128<ushort> source, ShuffleControlG2 control) {
                Vector128<byte> indices = Vector128Constants.GetYShuffleG2_UInt16_ByteIndices(control).AsByte(); // It also supports _mm128_shuffle_epi8 for 128-bit lanes .
                return YShuffleKernel(source.AsByte(), indices).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{int}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleG2(Vector128<int> source, ShuffleControlG2 control) {
                return YShuffleG2(source.AsUInt32(), control).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{uint}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleG2(Vector128<uint> source, ShuffleControlG2 control) {
                Vector128<byte> indices = Vector128Constants.GetYShuffleG2_UInt32_ByteIndices(control).AsByte(); // It also supports _mm128_shuffle_epi8 for 128-bit lanes .
                return YShuffleKernel(source.AsByte(), indices).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{long}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleG2(Vector128<long> source, ShuffleControlG2 control) {
                return YShuffleG2(source.AsUInt64(), control).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{ulong}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleG2(Vector128<ulong> source, ShuffleControlG2 control) {
                Vector128<byte> indices = Vector128Constants.GetYShuffleG2_UInt64_ByteIndices(control).AsByte(); // It also supports _mm128_shuffle_epi8 for 128-bit lanes .
                return YShuffleKernel(source.AsByte(), indices).AsUInt64();
            }

#if !REDUCE_MEMORY_USAGE
            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{float}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleG2_Const(Vector128<float> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{double}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleG2_Const(Vector128<double> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{sbyte}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleG2_Const(Vector128<sbyte> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{byte}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleG2_Const(Vector128<byte> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{short}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleG2_Const(Vector128<short> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{ushort}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleG2_Const(Vector128<ushort> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{int}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleG2_Const(Vector128<int> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{uint}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleG2_Const(Vector128<uint> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{long}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleG2_Const(Vector128<long> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{ulong}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleG2_Const(Vector128<ulong> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2(source, control);
            }
#endif // !REDUCE_MEMORY_USAGE


            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleG4_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.Most32Types;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{float}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleG4(Vector128<float> source, ShuffleControlG4 control) {
                return YShuffleG4(source.AsUInt32(), control).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{sbyte}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleG4(Vector128<sbyte> source, ShuffleControlG4 control) {
                return YShuffleG4(source.AsByte(), control).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{byte}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleG4(Vector128<byte> source, ShuffleControlG4 control) {
                var indices = Vector128Constants.GetYShuffleG4_Byte_Indices(control);
                return YShuffleKernel(source, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{short}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleG4(Vector128<short> source, ShuffleControlG4 control) {
                return YShuffleG4(source.AsUInt16(), control).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{ushort}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleG4(Vector128<ushort> source, ShuffleControlG4 control) {
                var indices = Vector128Constants.GetYShuffleG4_UInt16_ByteIndices(control);
                return YShuffleKernel(source.AsByte(), indices).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{int}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleG4(Vector128<int> source, ShuffleControlG4 control) {
                return YShuffleG4(source.AsUInt32(), control).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{uint}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleG4(Vector128<uint> source, ShuffleControlG4 control) {
                var indices = Vector128Constants.GetYShuffleG4_UInt32_ByteIndices(control);
                return YShuffleKernel(source.AsByte(), indices).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{float}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleG4_Const(Vector128<float> source, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{sbyte}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleG4_Const(Vector128<sbyte> source, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{byte}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleG4_Const(Vector128<byte> source, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{short}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleG4_Const(Vector128<short> source, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{ushort}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleG4_Const(Vector128<ushort> source, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{int}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleG4_Const(Vector128<int> source, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{uint}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleG4_Const(Vector128<uint> source, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4(source, control);
            }


            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleG4X2_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{float}, Vector128{float}, ShuffleControlG4, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleG4X2(Vector128<float> source0, Vector128<float> source1, ShuffleControlG4 control, out Vector128<float> result1) {
                var rt0 = YShuffleG4X2(source0.AsUInt32(), source1.AsUInt32(), control, out var rt1);
                result1 = rt1.AsSingle();
                return rt0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{double}, Vector128{double}, ShuffleControlG4, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleG4X2(Vector128<double> source0, Vector128<double> source1, ShuffleControlG4 control, out Vector128<double> result1) {
                var rt0 = YShuffleG4X2(source0.AsUInt64(), source1.AsUInt64(), control, out var rt1);
                result1 = rt1.AsDouble();
                return rt0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{sbyte}, Vector128{sbyte}, ShuffleControlG4, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleG4X2(Vector128<sbyte> source0, Vector128<sbyte> source1, ShuffleControlG4 control, out Vector128<sbyte> result1) {
                var rt0 = YShuffleG4X2(source0.AsByte(), source1.AsByte(), control, out var rt1);
                result1 = rt1.AsSByte();
                return rt0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{byte}, Vector128{byte}, ShuffleControlG4, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleG4X2(Vector128<byte> source0, Vector128<byte> source1, ShuffleControlG4 control, out Vector128<byte> result1) {
                var indices = Vector128Constants.GetYShuffleG4_Byte_Indices(control);
                var rt0 = YShuffleKernel(source0, indices);
                result1 = YShuffleKernel(source1, indices);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{short}, Vector128{short}, ShuffleControlG4, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleG4X2(Vector128<short> source0, Vector128<short> source1, ShuffleControlG4 control, out Vector128<short> result1) {
                var rt0 = YShuffleG4X2(source0.AsUInt16(), source1.AsUInt16(), control, out var rt1);
                result1 = rt1.AsInt16();
                return rt0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{ushort}, Vector128{ushort}, ShuffleControlG4, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleG4X2(Vector128<ushort> source0, Vector128<ushort> source1, ShuffleControlG4 control, out Vector128<ushort> result1) {
                var indices = Vector128Constants.GetYShuffleG4_UInt16_ByteIndices(control);
                var rt0 = YShuffleKernel(source0.AsByte(), indices).AsUInt16();
                result1 = YShuffleKernel(source1.AsByte(), indices).AsUInt16();
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{int}, Vector128{int}, ShuffleControlG4, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleG4X2(Vector128<int> source0, Vector128<int> source1, ShuffleControlG4 control, out Vector128<int> result1) {
                var rt0 = YShuffleG4X2(source0.AsUInt32(), source1.AsUInt32(), control, out var rt1);
                result1 = rt1.AsInt32();
                return rt0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{uint}, Vector128{uint}, ShuffleControlG4, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleG4X2(Vector128<uint> source0, Vector128<uint> source1, ShuffleControlG4 control, out Vector128<uint> result1) {
                var indices = Vector128Constants.GetYShuffleG4_UInt32_ByteIndices(control);
                var rt0 = YShuffleKernel(source0.AsByte(), indices).AsUInt32();
                result1 = YShuffleKernel(source1.AsByte(), indices).AsUInt32();
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{long}, Vector128{long}, ShuffleControlG4, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleG4X2(Vector128<long> source0, Vector128<long> source1, ShuffleControlG4 control, out Vector128<long> result1) {
                var rt0 = YShuffleG4X2(source0.AsUInt64(), source1.AsUInt64(), control, out var rt1);
                result1 = rt1.AsInt64();
                return rt0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{ulong}, Vector128{ulong}, ShuffleControlG4, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleG4X2(Vector128<ulong> source0, Vector128<ulong> source1, ShuffleControlG4 control, out Vector128<ulong> result1) {
                return YShuffleG4X2_Lookup(source0, source1, control, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{ulong}, Vector128{ulong}, ShuffleControlG4, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleG4X2_Lookup(Vector128<ulong> source0, Vector128<ulong> source1, ShuffleControlG4 control, out Vector128<ulong> result1) {
                ref Vector128<byte> indices = ref Vector128Constants.GetYShuffleG4X2_UInt64_ByteIndices(control);
                var result0 = PackedSimd.Or(
                    YShuffleKernel(source0.AsByte(), indices),
                    YShuffleKernel(source1.AsByte(), Unsafe.Add(ref indices, 1))
                ).AsUInt64();
                result1 = PackedSimd.Or(
                    YShuffleKernel(source0.AsByte(), Unsafe.Add(ref indices, 2)),
                    YShuffleKernel(source1.AsByte(), Unsafe.Add(ref indices, 3))
                ).AsUInt64();
                return result0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{long}, Vector128{long}, ShuffleControlG4, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleG4X2_Lookup(Vector128<long> source0, Vector128<long> source1, ShuffleControlG4 control, out Vector128<long> result1) {
                var rt0 = YShuffleG4X2_Lookup(source0.AsUInt64(), source1.AsUInt64(), control, out var rt1);
                result1 = rt1.AsInt64();
                return rt0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{float}, Vector128{float}, ShuffleControlG4, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleG4X2_Const(Vector128<float> source0, Vector128<float> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<float> result1) {
                return YShuffleG4X2(source0, source1, control, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{double}, Vector128{double}, ShuffleControlG4, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleG4X2_Const(Vector128<double> source0, Vector128<double> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<double> result1) {
                return YShuffleG4X2(source0, source1, control, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{sbyte}, Vector128{sbyte}, ShuffleControlG4, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleG4X2_Const(Vector128<sbyte> source0, Vector128<sbyte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<sbyte> result1) {
                return YShuffleG4X2(source0, source1, control, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{byte}, Vector128{byte}, ShuffleControlG4, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleG4X2_Const(Vector128<byte> source0, Vector128<byte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<byte> result1) {
                return YShuffleG4X2(source0, source1, control, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{short}, Vector128{short}, ShuffleControlG4, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleG4X2_Const(Vector128<short> source0, Vector128<short> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<short> result1) {
                return YShuffleG4X2(source0, source1, control, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{ushort}, Vector128{ushort}, ShuffleControlG4, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleG4X2_Const(Vector128<ushort> source0, Vector128<ushort> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<ushort> result1) {
                return YShuffleG4X2(source0, source1, control, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{int}, Vector128{int}, ShuffleControlG4, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleG4X2_Const(Vector128<int> source0, Vector128<int> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<int> result1) {
                return YShuffleG4X2(source0, source1, control, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{uint}, Vector128{uint}, ShuffleControlG4, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleG4X2_Const(Vector128<uint> source0, Vector128<uint> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<uint> result1) {
                return YShuffleG4X2(source0, source1, control, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{long}, Vector128{long}, ShuffleControlG4, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleG4X2_Const(Vector128<long> source0, Vector128<long> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<long> result1) {
                return YShuffleG4X2(source0, source1, control, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{ulong}, Vector128{ulong}, ShuffleControlG4, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleG4X2_Const(Vector128<ulong> source0, Vector128<ulong> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<ulong> result1) {
                return YShuffleG4X2(source0, source1, control, out result1);
            }


            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleInsert_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{float}, Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleInsert(Vector128<float> back, Vector128<float> vector, Vector128<int> indices) {
                return YShuffleInsert(back.AsUInt32(), vector.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{double}, Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleInsert(Vector128<double> back, Vector128<double> vector, Vector128<long> indices) {
                return YShuffleInsert(back.AsUInt64(), vector.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleInsert(Vector128<sbyte> back, Vector128<sbyte> vector, Vector128<sbyte> indices) {
                return YShuffleInsert(back.AsByte(), vector.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleInsert(Vector128<byte> back, Vector128<byte> vector, Vector128<byte> indices) {
                Vector128<byte> mask = PackedSimd.CompareGreaterThan(Vector128.Create((byte)16), indices); // (0<=i && i<16)
                Vector128<byte> rt = PackedSimd.Swizzle(vector, indices);
                rt = ConditionalSelect(mask, rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleInsert(Vector128<short> back, Vector128<short> vector, Vector128<short> indices) {
                return YShuffleInsert(back.AsUInt16(), vector.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleInsert(Vector128<ushort> back, Vector128<ushort> vector, Vector128<ushort> indices) {
                Vector128<ushort> mask = PackedSimd.CompareGreaterThan(Vector128.Create((ushort)8), indices); // (0<=i && i<8)
                Vector128<byte> indices2 = PackedSimd.Add(PackedSimd.Multiply(indices, Vector128Constants.Shuffle_UInt16_Multiplier).AsByte(), Vector128Constants.Shuffle_UInt16_ByteOffset);
                Vector128<ushort> rt = PackedSimd.Swizzle(vector.AsByte(), indices2).AsUInt16();
                rt = ConditionalSelect(mask, rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleInsert(Vector128<int> back, Vector128<int> vector, Vector128<int> indices) {
                return YShuffleInsert(back.AsUInt32(), vector.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleInsert(Vector128<uint> back, Vector128<uint> vector, Vector128<uint> indices) {
                Vector128<uint> mask = PackedSimd.CompareGreaterThan(Vector128.Create((uint)4), indices); // (0<=i && i<4)
                //Vector128<byte> indices2 = PackedSimd.Add(PackedSimd.Multiply(indices, Vector128Constants.Shuffle_UInt32_Multiplier).AsByte(), Vector128Constants.Shuffle_UInt32_ByteOffset);
                //Vector128<uint> rt = PackedSimd.Swizzle(vector.AsByte(), indices2).AsUInt32();
                Vector128<uint> rt = Vector128.Shuffle(vector, indices);
                rt = ConditionalSelect(mask, rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleInsert(Vector128<long> back, Vector128<long> vector, Vector128<long> indices) {
                return YShuffleInsert(back.AsUInt64(), vector.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleInsert(Vector128<ulong> back, Vector128<ulong> vector, Vector128<ulong> indices) {
                Vector128<ulong> mask = PackedSimd.CompareEqual(PackedSimd.ShiftRightLogical(indices, 1), Vector128<ulong>.Zero); // Unsigned compare: (i < 2)
                Vector128<uint> indices1 = PackedSimd.Or(PackedSimd.ShiftLeft(indices, 32), indices).AsUInt32();
                Vector128<byte> indices2 = PackedSimd.Add(PackedSimd.Multiply(indices1, Vector128Constants.Shuffle_UInt64_Multiplier.AsUInt32()).AsByte(), Vector128Constants.Shuffle_UInt64_ByteOffset);
                Vector128<ulong> rt = PackedSimd.Swizzle(vector.AsByte(), indices2).AsUInt64();
                rt = ConditionalSelect(mask, rt, back);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2) {
                YShuffleInsert_Args(indices.AsByte(), out var a0, out var a1, out var a2);
                args0 = a0.AsSByte();
                args1 = a1.AsSByte();
                args2 = a2.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2) {
                args0 = indices;
                args1 = default;
                args2 = PackedSimd.CompareGreaterThan(Vector128.Create((byte)16), indices); // (0<=i && i<16)
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2) {
                YShuffleInsert_Args(indices.AsUInt16(), out var a0, out var a1, out var a2);
                args0 = a0.AsInt16();
                args1 = a1.AsInt16();
                args2 = a2.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2) {
                Vector128<ushort> mask = PackedSimd.CompareGreaterThan(Vector128.Create((ushort)8), indices); // (0<=i && i<8)
                YShuffleKernel_Args(indices, out args0, out args1);
                args2 = mask;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2) {
                YShuffleInsert_Args(indices.AsUInt32(), out var a0, out var a1, out var a2);
                args0 = a0.AsInt32();
                args1 = a1.AsInt32();
                args2 = a2.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2) {
                Vector128<uint> mask = PackedSimd.CompareGreaterThan(Vector128.Create((uint)4), indices); // (0<=i && i<4)
                YShuffleKernel_Args(indices, out args0, out args1);
                args2 = mask;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2) {
                YShuffleInsert_Args(indices.AsUInt64(), out var a0, out var a1, out var a2);
                args0 = a0.AsInt64();
                args1 = a1.AsInt64();
                args2 = a2.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2) {
                Vector128<ulong> mask = PackedSimd.CompareEqual(PackedSimd.ShiftRightLogical(indices, 1), Vector128<ulong>.Zero); // Unsigned compare: (i < 2)
                YShuffleKernel_Args(indices, out args0, out args1);
                args2 = mask;
            }


            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleInsert_Core(Vector128<float> back, Vector128<float> vector, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2) {
                return YShuffleInsert_Core(back.AsUInt32(), vector.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleInsert_Core(Vector128<double> back, Vector128<double> vector, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2) {
                return YShuffleInsert_Core(back.AsUInt64(), vector.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleInsert_Core(Vector128<sbyte> back, Vector128<sbyte> vector, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2) {
                return YShuffleInsert_Core(back.AsByte(), vector.AsByte(), args0.AsByte(), args1.AsByte(), args2.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleInsert_Core(Vector128<byte> back, Vector128<byte> vector, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2) {
                _ = args1;
                Vector128<byte> rt = PackedSimd.Swizzle(vector, args0);
                rt = ConditionalSelect(args2, rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleInsert_Core(Vector128<short> back, Vector128<short> vector, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2) {
                return YShuffleInsert_Core(back.AsUInt16(), vector.AsUInt16(), args0.AsUInt16(), args1.AsUInt16(), args2.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleInsert_Core(Vector128<ushort> back, Vector128<ushort> vector, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2) {
                Vector128<ushort> rt = PackedSimd.Swizzle(vector.AsByte(), args0.AsByte()).AsUInt16();
                rt = ConditionalSelect(args2, rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleInsert_Core(Vector128<int> back, Vector128<int> vector, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2) {
                return YShuffleInsert_Core(back.AsUInt32(), vector.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleInsert_Core(Vector128<uint> back, Vector128<uint> vector, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2) {
                Vector128<uint> rt = Vector128.Shuffle(vector, args0);
                rt = ConditionalSelect(args2, rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleInsert_Core(Vector128<long> back, Vector128<long> vector, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2) {
                return YShuffleInsert_Core(back.AsUInt64(), vector.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleInsert_Core(Vector128<ulong> back, Vector128<ulong> vector, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2) {
                Vector128<ulong> rt = PackedSimd.Swizzle(vector.AsByte(), args0.AsByte()).AsUInt64();
                rt = ConditionalSelect(args2, rt, back);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleKernel_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleKernel(Vector128<float> vector, Vector128<int> indices) {
                return YShuffleKernel(vector.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleKernel(Vector128<double> vector, Vector128<long> indices) {
                return YShuffleKernel(vector.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleKernel(Vector128<sbyte> vector, Vector128<sbyte> indices) {
                return YShuffleKernel(vector.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleKernel(Vector128<byte> vector, Vector128<byte> indices) {
                return PackedSimd.Swizzle(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleKernel(Vector128<short> vector, Vector128<short> indices) {
                return YShuffleKernel(vector.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleKernel(Vector128<ushort> vector, Vector128<ushort> indices) {
                Vector128<byte> indices2 = PackedSimd.Add(PackedSimd.Multiply(indices, Vector128Constants.Shuffle_UInt16_Multiplier).AsByte(), Vector128Constants.Shuffle_UInt16_ByteOffset);
                return YShuffleKernel(vector.AsByte(), indices2).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleKernel(Vector128<int> vector, Vector128<int> indices) {
                return YShuffleKernel(vector.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleKernel(Vector128<uint> vector, Vector128<uint> indices) {
                return Vector128.Shuffle(vector, indices);
                //Vector128<byte> indices2 = PackedSimd.Add(PackedSimd.Multiply(indices, Vector128Constants.Shuffle_UInt32_Multiplier).AsByte(), Vector128Constants.Shuffle_UInt32_ByteOffset);
                //return YShuffleKernel(vector.AsByte(), indices2).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleKernel(Vector128<long> vector, Vector128<long> indices) {
                return YShuffleKernel(vector.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleKernel(Vector128<ulong> vector, Vector128<ulong> indices) {
                return YShuffleKernel_Shift(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleKernel_Multiply(Vector128<ulong> vector, Vector128<ulong> indices) {
                Vector128<byte> indices2 = PackedSimd.Add(Multiply(indices, Vector128Constants.Shuffle_UInt64_Multiplier).AsByte(), Vector128Constants.Shuffle_UInt64_ByteOffset);
                return YShuffleKernel(vector.AsByte(), indices2).AsUInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleKernel_Shift(Vector128<ulong> vector, Vector128<ulong> indices) {
                Vector128<uint> indices1 = PackedSimd.Or(PackedSimd.ShiftLeft(indices, 32), indices).AsUInt32();
                Vector128<byte> indices2 = PackedSimd.Add(PackedSimd.Multiply(indices1, Vector128Constants.Shuffle_UInt64_Multiplier.AsUInt32()).AsByte(), Vector128Constants.Shuffle_UInt64_ByteOffset);
                return YShuffleKernel(vector.AsByte(), indices2).AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1) {
                YShuffleKernel_Args(indices.AsByte(), out var a0, out var a1);
                args0 = a0.AsSByte();
                args1 = a1.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1) {
                YShuffleKernel_Args(indices.AsUInt16(), out var a0, out var a1);
                args0 = a0.AsInt16();
                args1 = a1.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1) {
                Vector128<byte> indices2 = PackedSimd.Add(PackedSimd.Multiply(indices, Vector128Constants.Shuffle_UInt16_Multiplier).AsByte(), Vector128Constants.Shuffle_UInt16_ByteOffset);
                args0 = indices2.AsUInt16();
                args1 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1) {
                YShuffleKernel_Args(indices.AsUInt32(), out var a0, out var a1);
                args0 = a0.AsInt32();
                args1 = a1.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1) {
                //Vector128<byte> indices2 = PackedSimd.Add(PackedSimd.Multiply(indices, Vector128Constants.Shuffle_UInt32_Multiplier).AsByte(), Vector128Constants.Shuffle_UInt32_ByteOffset);
                //args0 = indices2.AsUInt32();
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1) {
                YShuffleKernel_Args(indices.AsUInt64(), out var a0, out var a1);
                args0 = a0.AsInt64();
                args1 = a1.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1) {
                Vector128<uint> indices1 = PackedSimd.Or(PackedSimd.ShiftLeft(indices, 32), indices).AsUInt32();
                Vector128<byte> indices2 = PackedSimd.Add(PackedSimd.Multiply(indices1, Vector128Constants.Shuffle_UInt64_Multiplier.AsUInt32()).AsByte(), Vector128Constants.Shuffle_UInt64_ByteOffset);
                args0 = indices2.AsUInt64();
                args1 = default;
            }


            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{float}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleKernel_Core(Vector128<float> vector, Vector128<int> args0, Vector128<int> args1) {
                return YShuffleKernel_Core(vector.AsUInt32(), args0.AsUInt32(), args1.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{double}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleKernel_Core(Vector128<double> vector, Vector128<long> args0, Vector128<long> args1) {
                return YShuffleKernel_Core(vector.AsUInt64(), args0.AsUInt64(), args1.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleKernel_Core(Vector128<sbyte> vector, Vector128<sbyte> args0, Vector128<sbyte> args1) {
                return YShuffleKernel_Core(vector.AsByte(), args0.AsByte(), args1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleKernel_Core(Vector128<byte> vector, Vector128<byte> args0, Vector128<byte> args1) {
                _ = args1;
                return PackedSimd.Swizzle(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleKernel_Core(Vector128<short> vector, Vector128<short> args0, Vector128<short> args1) {
                return YShuffleKernel_Core(vector.AsUInt16(), args0.AsUInt16(), args1.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleKernel_Core(Vector128<ushort> vector, Vector128<ushort> args0, Vector128<ushort> args1) {
                return YShuffleKernel_Core(vector.AsByte(), args0.AsByte(), args1.AsByte()).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleKernel_Core(Vector128<int> vector, Vector128<int> args0, Vector128<int> args1) {
                return YShuffleKernel_Core(vector.AsUInt32(), args0.AsUInt32(), args1.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleKernel_Core(Vector128<uint> vector, Vector128<uint> args0, Vector128<uint> args1) {
                return Vector128.Shuffle(vector, args0);
                //return YShuffleKernel_Core(vector.AsByte(), args0.AsByte(), args1.AsByte()).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleKernel_Core(Vector128<long> vector, Vector128<long> args0, Vector128<long> args1) {
                return YShuffleKernel_Core(vector.AsUInt64(), args0.AsUInt64(), args1.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleKernel_Core(Vector128<ulong> vector, Vector128<ulong> args0, Vector128<ulong> args1) {
                return YShuffleKernel_Core(vector.AsByte(), args0.AsByte(), args1.AsByte()).AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits128.YSign_AcceleratedTypes"/>
            public static TypeCodeFlags YSign_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YSign(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YSign(Vector128<float> value) {
                Vector128<float> zero = Vector128<float>.Zero;
                Vector128<int> m = LessThan(value, zero).AsInt32();
                Vector128<int> n = GreaterThan(value, zero).AsInt32();
                Vector128<int> rt = PackedSimd.Subtract(m, n);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YSign(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YSign(Vector128<double> value) {
                Vector128<double> zero = Vector128<double>.Zero;
                Vector128<long> m = LessThan(value, zero).AsInt64();
                Vector128<long> n = GreaterThan(value, zero).AsInt64();
                Vector128<long> rt = PackedSimd.Subtract(m, n);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YSign(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YSign(Vector128<sbyte> value) {
                Vector128<sbyte> zero = Vector128<sbyte>.Zero;
                Vector128<sbyte> m = LessThan(value, zero);
                Vector128<sbyte> n = GreaterThan(value, zero);
                Vector128<sbyte> rt = PackedSimd.Subtract(m, n);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YSign(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YSign(Vector128<short> value) {
                Vector128<short> zero = Vector128<short>.Zero;
                Vector128<short> m = LessThan(value, zero);
                Vector128<short> n = GreaterThan(value, zero);
                Vector128<short> rt = PackedSimd.Subtract(m, n);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YSign(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YSign(Vector128<int> value) {
                Vector128<int> zero = Vector128<int>.Zero;
                Vector128<int> m = LessThan(value, zero);
                Vector128<int> n = GreaterThan(value, zero);
                Vector128<int> rt = PackedSimd.Subtract(m, n);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YSign(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YSign(Vector128<long> value) {
                Vector128<long> zero = Vector128<long>.Zero;
                Vector128<long> m = LessThan(value, zero);
                Vector128<long> n = GreaterThan(value, zero);
                Vector128<long> rt = PackedSimd.Subtract(m, n);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YSignFloat_AcceleratedTypes"/>
            public static TypeCodeFlags YSignFloat_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
                    rt |= (TypeCodeFlags.Single) & YIsNaN_AcceleratedTypes & ConvertToSingle_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YSignFloat(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YSignFloat(Vector128<float> value) {
                Vector128<int> signVal = YSign(value);
                Vector128<float> nanMask = YIsNaN(value).AsSingle();
                Vector128<float> rt = ConvertToSingle(signVal);
                rt = BitwiseOr(rt, BitwiseAnd(nanMask, value)); // ConditionalSelect(nanMask, value, rt);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YSignFloat(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YSignFloat(Vector128<double> value) {
                return YSignFloat_Compare(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.YSignFloat(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YSignFloat_Compare(Vector128<double> value) {
                Vector128<double> negativeOne = Vector128.Create(-1.0);
                Vector128<double> zero = Vector128<double>.Zero;
                Vector128<double> one = Vector128.Create(1.0);
                Vector128<double> rt = BitwiseAnd(LessThan(value, zero), negativeOne);
                Vector128<double> nanMask = YIsNaN(value).AsDouble();
                rt = BitwiseOr(rt, BitwiseAnd(GreaterThan(value, zero), one)); // rt = ConvertToDouble(YSign(value));
                rt = BitwiseOr(rt, BitwiseAnd(nanMask, value)); // ConditionalSelect(nanMask, value, rt);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YSignFloat(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YSignFloat_Convert(Vector128<double> value) {
                Vector128<long> signVal = YSign(value);
                Vector128<double> nanMask = YIsNaN(value).AsDouble();
                Vector128<double> rt = ConvertToDouble_Range52(signVal);
                rt = BitwiseOr(rt, BitwiseAnd(nanMask, value)); // ConditionalSelect(nanMask, value, rt);
                return rt;
            }


#endif // NET8_0_OR_GREATER
        }
    }
}
