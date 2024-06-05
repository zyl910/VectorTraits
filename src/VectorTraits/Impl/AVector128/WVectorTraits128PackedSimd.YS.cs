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

            /// <inheritdoc cref="Vector128s.YShuffleG4X2(Vector128{float}, Vector128{float}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static (Vector128<float> Result0, Vector128<float> Result1) YShuffleG4X2(Vector128<float> source0, Vector128<float> source1, ShuffleControlG4 control) {
                (var result0, var result1) = YShuffleG4X2(source0.AsUInt32(), source1.AsUInt32(), control);
                return (result0.AsSingle(), result1.AsSingle());
            }

            /// <inheritdoc cref="Vector128s.YShuffleG4X2(Vector128{double}, Vector128{double}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static (Vector128<double> Result0, Vector128<double> Result1) YShuffleG4X2(Vector128<double> source0, Vector128<double> source1, ShuffleControlG4 control) {
                (var result0, var result1) = YShuffleG4X2(source0.AsUInt64(), source1.AsUInt64(), control);
                return (result0.AsDouble(), result1.AsDouble());
            }

            /// <inheritdoc cref="Vector128s.YShuffleG4X2(Vector128{sbyte}, Vector128{sbyte}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static (Vector128<sbyte> Result0, Vector128<sbyte> Result1) YShuffleG4X2(Vector128<sbyte> source0, Vector128<sbyte> source1, ShuffleControlG4 control) {
                (var result0, var result1) = YShuffleG4X2(source0.AsByte(), source1.AsByte(), control);
                return (result0.AsSByte(), result1.AsSByte());
            }

            /// <inheritdoc cref="Vector128s.YShuffleG4X2(Vector128{byte}, Vector128{byte}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static (Vector128<byte> Result0, Vector128<byte> Result1) YShuffleG4X2(Vector128<byte> source0, Vector128<byte> source1, ShuffleControlG4 control) {
                var indices = Vector128Constants.GetYShuffleG4_Byte_Indices(control);
                var rt0 = YShuffleKernel(source0, indices);
                var rt1 = YShuffleKernel(source1, indices);
                return (rt0, rt1);
            }

            /// <inheritdoc cref="Vector128s.YShuffleG4X2(Vector128{short}, Vector128{short}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static (Vector128<short> Result0, Vector128<short> Result1) YShuffleG4X2(Vector128<short> source0, Vector128<short> source1, ShuffleControlG4 control) {
                //(var result0, var result1) = YShuffleG4X2(source0.AsUInt16(), source1.AsUInt16(), control);
                //return (result0.AsInt16(), result1.AsInt16());
                var indices = Vector128Constants.GetYShuffleG4_UInt16_ByteIndices(control);
                var rt0 = PackedSimd.Swizzle(source0.AsByte(), indices).AsInt16();
                var rt1 = PackedSimd.Swizzle(source1.AsByte(), indices).AsInt16();
                return (rt0, rt1);
            }

            /// <inheritdoc cref="Vector128s.YShuffleG4X2(Vector128{ushort}, Vector128{ushort}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [CLSCompliant(false)]
            public static (Vector128<ushort> Result0, Vector128<ushort> Result1) YShuffleG4X2(Vector128<ushort> source0, Vector128<ushort> source1, ShuffleControlG4 control) {
                var indices = Vector128Constants.GetYShuffleG4_UInt16_ByteIndices(control);
                var rt0 = YShuffleKernel(source0.AsByte(), indices).AsUInt16();
                var rt1 = YShuffleKernel(source1.AsByte(), indices).AsUInt16();
                return (rt0, rt1);
            }

            /// <inheritdoc cref="Vector128s.YShuffleG4X2(Vector128{int}, Vector128{int}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static (Vector128<int> Result0, Vector128<int> Result1) YShuffleG4X2(Vector128<int> source0, Vector128<int> source1, ShuffleControlG4 control) {
                (var result0, var result1) = YShuffleG4X2(source0.AsUInt32(), source1.AsUInt32(), control);
                return (result0.AsInt32(), result1.AsInt32());
            }

            /// <inheritdoc cref="Vector128s.YShuffleG4X2(Vector128{uint}, Vector128{uint}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static (Vector128<uint> Result0, Vector128<uint> Result1) YShuffleG4X2(Vector128<uint> source0, Vector128<uint> source1, ShuffleControlG4 control) {
                var indices = Vector128Constants.GetYShuffleG4_UInt32_ByteIndices(control);
                var rt0 = YShuffleKernel(source0.AsByte(), indices).AsUInt32();
                var rt1 = YShuffleKernel(source1.AsByte(), indices).AsUInt32();
                return (rt0, rt1);
            }

            /// <inheritdoc cref="Vector128s.YShuffleG4X2(Vector128{long}, Vector128{long}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static (Vector128<long> Result0, Vector128<long> Result1) YShuffleG4X2(Vector128<long> source0, Vector128<long> source1, ShuffleControlG4 control) {
                (var result0, var result1) = YShuffleG4X2(source0.AsUInt64(), source1.AsUInt64(), control);
                return (result0.AsInt64(), result1.AsInt64());
            }

            /// <inheritdoc cref="Vector128s.YShuffleG4X2(Vector128{ulong}, Vector128{ulong}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [CLSCompliant(false)]
            public static (Vector128<ulong> Result0, Vector128<ulong> Result1) YShuffleG4X2(Vector128<ulong> source0, Vector128<ulong> source1, ShuffleControlG4 control) {
                ref Vector128<byte> indices = ref Vector128Constants.GetYShuffleG4X2_UInt64_ByteIndices(control);
                var result0 = PackedSimd.Or(
                    YShuffleKernel(source0.AsByte(), indices),
                    YShuffleKernel(source1.AsByte(), Unsafe.Add(ref indices, 1))
                ).AsUInt64();
                var result1 = PackedSimd.Or(
                    YShuffleKernel(source0.AsByte(), Unsafe.Add(ref indices, 2)),
                    YShuffleKernel(source1.AsByte(), Unsafe.Add(ref indices, 3))
                ).AsUInt64();
                return (result0, result1);
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

            /// <inheritdoc cref="Vector128s.YShuffleG4X2_Const(Vector128{float}, Vector128{float}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static (Vector128<float> Result0, Vector128<float> Result1) YShuffleG4X2_Const(Vector128<float> source0, Vector128<float> source1, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4X2(source0, source1, control);
            }

            /// <inheritdoc cref="Vector128s.YShuffleG4X2_Const(Vector128{double}, Vector128{double}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static (Vector128<double> Result0, Vector128<double> Result1) YShuffleG4X2_Const(Vector128<double> source0, Vector128<double> source1, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4X2(source0, source1, control);
            }

            /// <inheritdoc cref="Vector128s.YShuffleG4X2_Const(Vector128{sbyte}, Vector128{sbyte}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [CLSCompliant(false)]
            public static (Vector128<sbyte> Result0, Vector128<sbyte> Result1) YShuffleG4X2_Const(Vector128<sbyte> source0, Vector128<sbyte> source1, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4X2(source0, source1, control);
            }

            /// <inheritdoc cref="Vector128s.YShuffleG4X2_Const(Vector128{byte}, Vector128{byte}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static (Vector128<byte> Result0, Vector128<byte> Result1) YShuffleG4X2_Const(Vector128<byte> source0, Vector128<byte> source1, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4X2(source0, source1, control);
            }

            /// <inheritdoc cref="Vector128s.YShuffleG4X2_Const(Vector128{short}, Vector128{short}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static (Vector128<short> Result0, Vector128<short> Result1) YShuffleG4X2_Const(Vector128<short> source0, Vector128<short> source1, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4X2(source0, source1, control);
            }

            /// <inheritdoc cref="Vector128s.YShuffleG4X2_Const(Vector128{ushort}, Vector128{ushort}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [CLSCompliant(false)]
            public static (Vector128<ushort> Result0, Vector128<ushort> Result1) YShuffleG4X2_Const(Vector128<ushort> source0, Vector128<ushort> source1, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4X2(source0, source1, control);
            }

            /// <inheritdoc cref="Vector128s.YShuffleG4X2_Const(Vector128{int}, Vector128{int}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static (Vector128<int> Result0, Vector128<int> Result1) YShuffleG4X2_Const(Vector128<int> source0, Vector128<int> source1, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4X2(source0, source1, control);
            }

            /// <inheritdoc cref="Vector128s.YShuffleG4X2_Const(Vector128{uint}, Vector128{uint}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [CLSCompliant(false)]
            public static (Vector128<uint> Result0, Vector128<uint> Result1) YShuffleG4X2_Const(Vector128<uint> source0, Vector128<uint> source1, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4X2(source0, source1, control);
            }

            /// <inheritdoc cref="Vector128s.YShuffleG4X2_Const(Vector128{long}, Vector128{long}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static (Vector128<long> Result0, Vector128<long> Result1) YShuffleG4X2_Const(Vector128<long> source0, Vector128<long> source1, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4X2(source0, source1, control);
            }

            /// <inheritdoc cref="Vector128s.YShuffleG4X2_Const(Vector128{ulong}, Vector128{ulong}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [CLSCompliant(false)]
            public static (Vector128<ulong> Result0, Vector128<ulong> Result1) YShuffleG4X2_Const(Vector128<ulong> source0, Vector128<ulong> source1, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4X2(source0, source1, control);
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
                Vector128<uint> temp = PackedSimd.Or(PackedSimd.ShiftLeft(indices, 32), indices).AsUInt32();
                Vector128<byte> indices2 = PackedSimd.Add(PackedSimd.Multiply(temp, Vector128Constants.Shuffle_UInt64_Multiplier.AsUInt32()).AsByte(), Vector128Constants.Shuffle_UInt64_ByteOffset);
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


            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX2_AcceleratedTypes {
                get {
                    return YShuffleX2Kernel_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{float}, Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX2(Vector128<float> vector0, Vector128<float> vector1, Vector128<int> indices) {
                return YShuffleX2(vector0.AsInt32(), vector1.AsInt32(), indices).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{double}, Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX2(Vector128<double> vector0, Vector128<double> vector1, Vector128<long> indices) {
                return YShuffleX2(vector0.AsInt64(), vector1.AsInt64(), indices).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX2(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> indices) {
                return YShuffleX2(vector0.AsByte(), vector1.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX2(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> indices) {
                const byte total = 2 * ByteCountValue / sizeof(byte); // 2 * Vector128<byte>.Count
                Vector128<byte> mask, raw, rt;
                mask = PackedSimd.CompareGreaterThan(
                    Vector128.Create((sbyte)(total + sbyte.MinValue)),
                    PackedSimd.Add(indices.AsSByte(), Vector128.Create(sbyte.MinValue))
                ).AsByte(); // Unsigned compare: (i < total)
                raw = YShuffleX2Kernel(vector0, vector1, indices);
                rt = PackedSimd.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX2(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> indices) {
                return YShuffleX2(vector0.AsUInt16(), vector1.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX2(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> indices) {
                Vector128<ushort> mask, raw, rt;
                mask = PackedSimd.CompareEqual(PackedSimd.ShiftRightLogical(indices, 4), Vector128<ushort>.Zero); // Unsigned compare: (i < 16)
                raw = YShuffleX2Kernel(vector0, vector1, indices);
                rt = PackedSimd.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX2(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> indices) {
                return YShuffleX2(vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX2(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> indices) {
                Vector128<uint> mask, raw, rt;
                mask = PackedSimd.CompareEqual(PackedSimd.ShiftRightLogical(indices, 3), Vector128<uint>.Zero); // Unsigned compare: (i < 8)
                raw = YShuffleX2Kernel(vector0, vector1, indices);
                rt = PackedSimd.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX2(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> indices) {
                return YShuffleX2(vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX2(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> indices) {
                Vector128<ulong> mask, raw, rt;
                mask = PackedSimd.CompareEqual(PackedSimd.ShiftRightLogical(indices, 2), Vector128<ulong>.Zero); // Unsigned compare: (i < 4)
                raw = YShuffleX2Kernel(vector0, vector1, indices);
                rt = PackedSimd.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3, out Vector128<sbyte> args4) {
                YShuffleX2_Args(indices.AsByte(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsSByte();
                args1 = a1.AsSByte();
                args2 = a2.AsSByte();
                args3 = a3.AsSByte();
                args4 = a4.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3, out Vector128<byte> args4) {
                const byte total = 2 * ByteCountValue / sizeof(byte); // 2 * Vector128<byte>.Count
                YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
                args4 = PackedSimd.CompareGreaterThan(
                    Vector128.Create((sbyte)(total + sbyte.MinValue)),
                    PackedSimd.Add(indices.AsSByte(), Vector128.Create(sbyte.MinValue))
                ).AsByte(); // Unsigned compare: (i < total)
                Vector128<byte> mask = OnesComplement(args4); // Change mask to `0 is keep; AllBitsSet is set zero`.
                args0 = PackedSimd.Or(args0, mask);
                args1 = PackedSimd.Or(args1, mask);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3, out Vector128<short> args4) {
                YShuffleX2_Args(indices.AsUInt16(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsInt16();
                args1 = a1.AsInt16();
                args2 = a2.AsInt16();
                args3 = a3.AsInt16();
                args4 = a4.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3, out Vector128<ushort> args4) {
                YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
                args4 = PackedSimd.CompareEqual(PackedSimd.ShiftRightLogical(indices, 4), Vector128<ushort>.Zero); // Unsigned compare: (i < 16)
                Vector128<ushort> mask = OnesComplement(args4); // Change mask to `0 is keep; AllBitsSet is set zero`.
                args0 = PackedSimd.Or(args0, mask);
                args1 = PackedSimd.Or(args1, mask);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3, out Vector128<int> args4) {
                YShuffleX2_Args(indices.AsUInt32(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsInt32();
                args1 = a1.AsInt32();
                args2 = a2.AsInt32();
                args3 = a3.AsInt32();
                args4 = a4.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3, out Vector128<uint> args4) {
                YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
                args4 = PackedSimd.CompareEqual(PackedSimd.ShiftRightLogical(indices, 3), Vector128<uint>.Zero); // Unsigned compare: (i < 8)
                Vector128<uint> mask = OnesComplement(args4); // Change mask to `0 is keep; AllBitsSet is set zero`.
                args0 = PackedSimd.Or(args0, mask);
                args1 = PackedSimd.Or(args1, mask);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3, out Vector128<long> args4) {
                YShuffleX2_Args(indices.AsUInt64(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsInt64();
                args1 = a1.AsInt64();
                args2 = a2.AsInt64();
                args3 = a3.AsInt64();
                args4 = a4.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3, out Vector128<ulong> args4) {
                YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
                args4 = Equals(PackedSimd.ShiftRightLogical(indices, 2), Vector128<ulong>.Zero); // Unsigned compare: (i < 4)
                Vector128<ulong> mask = OnesComplement(args4); // Change mask to `0 is keep; AllBitsSet is set zero`.
                args0 = PackedSimd.Or(args0, mask);
                args1 = PackedSimd.Or(args1, mask);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Core(Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX2_Core(Vector128<float> vector0, Vector128<float> vector1, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
                return YShuffleX2_Core(vector0.AsUInt32(), vector1.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32(), args4.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Core(Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX2_Core(Vector128<double> vector0, Vector128<double> vector1, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
                return YShuffleX2_Core(vector0.AsUInt64(), vector1.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64(), args4.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX2_Core(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) {
                return YShuffleX2_Core(vector0.AsByte(), vector1.AsByte(), args0.AsByte(), args1.AsByte(), args2.AsByte(), args3.AsByte(), args4.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX2_Core(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) {
                Vector128<byte> rt = YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                //rt = PackedSimd.And(rt, args4);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX2_Core(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) {
                return YShuffleX2_Core(vector0.AsUInt16(), vector1.AsUInt16(), args0.AsUInt16(), args1.AsUInt16(), args2.AsUInt16(), args3.AsUInt16(), args4.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX2_Core(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) {
                Vector128<ushort> rt = YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                //rt = PackedSimd.And(rt, args4);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX2_Core(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
                return YShuffleX2_Core(vector0.AsUInt32(), vector1.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32(), args4.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX2_Core(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) {
                Vector128<uint> rt = YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                //rt = PackedSimd.And(rt, args4);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX2_Core(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
                return YShuffleX2_Core(vector0.AsUInt64(), vector1.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64(), args4.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX2_Core(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) {
                Vector128<ulong> rt = YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                //rt = PackedSimd.And(rt, args4);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX2Insert_AcceleratedTypes {
                get {
                    return YShuffleX2Kernel_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX2Insert(Vector128<float> back, Vector128<float> vector0, Vector128<float> vector1, Vector128<int> indices) {
                return YShuffleX2Insert(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX2Insert(Vector128<double> back, Vector128<double> vector0, Vector128<double> vector1, Vector128<long> indices) {
                return YShuffleX2Insert(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX2Insert(Vector128<sbyte> back, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> indices) {
                return YShuffleX2Insert(back.AsByte(), vector0.AsByte(), vector1.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX2Insert(Vector128<byte> back, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> indices) {
                const byte total = 2 * ByteCountValue / sizeof(byte); // 2 * Vector128<byte>.Count
                Vector128<byte> mask, raw, rt;
                mask = PackedSimd.CompareGreaterThan(
                    Vector128.Create((sbyte)(total + sbyte.MinValue)),
                    PackedSimd.Add(indices.AsSByte(), Vector128.Create(sbyte.MinValue))
                ).AsByte(); // Unsigned compare: (i < total)
                raw = YShuffleX2Kernel(vector0, vector1, indices);
                rt = Vector128.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX2Insert(Vector128<short> back, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> indices) {
                return YShuffleX2Insert(back.AsUInt16(), vector0.AsUInt16(), vector1.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX2Insert(Vector128<ushort> back, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> indices) {
                Vector128<ushort> mask, raw, rt;
                mask = PackedSimd.CompareEqual(PackedSimd.ShiftRightLogical(indices, 4), Vector128<ushort>.Zero); // Unsigned compare: (i < 16)
                raw = YShuffleX2Kernel(vector0, vector1, indices);
                rt = Vector128.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX2Insert(Vector128<int> back, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> indices) {
                return YShuffleX2Insert(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX2Insert(Vector128<uint> back, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> indices) {
                Vector128<uint> mask, raw, rt;
                mask = PackedSimd.CompareEqual(PackedSimd.ShiftRightLogical(indices, 3), Vector128<uint>.Zero); // Unsigned compare: (i < 8)
                raw = YShuffleX2Kernel(vector0, vector1, indices);
                rt = Vector128.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX2Insert(Vector128<long> back, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> indices) {
                return YShuffleX2Insert(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX2Insert(Vector128<ulong> back, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> indices) {
                Vector128<ulong> mask, raw, rt;
                mask = Equals(PackedSimd.ShiftRightLogical(indices, 2), Vector128<ulong>.Zero); // Unsigned compare: (i < 4)
                raw = YShuffleX2Kernel(vector0, vector1, indices);
                rt = Vector128.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3, out Vector128<sbyte> args4) {
                YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3, out Vector128<byte> args4) {
                YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3, out Vector128<short> args4) {
                YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3, out Vector128<ushort> args4) {
                YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3, out Vector128<int> args4) {
                YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3, out Vector128<uint> args4) {
                YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3, out Vector128<long> args4) {
                YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3, out Vector128<ulong> args4) {
                YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX2Insert_Core(Vector128<float> back, Vector128<float> vector0, Vector128<float> vector1, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
                return YShuffleX2Insert_Core(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32(), args4.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX2Insert_Core(Vector128<double> back, Vector128<double> vector0, Vector128<double> vector1, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
                return YShuffleX2Insert_Core(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64(), args4.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX2Insert_Core(Vector128<sbyte> back, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) {
                return YShuffleX2Insert_Core(back.AsByte(), vector0.AsByte(), vector1.AsByte(), args0.AsByte(), args1.AsByte(), args2.AsByte(), args3.AsByte(), args4.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX2Insert_Core(Vector128<byte> back, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) {
                Vector128<byte> rt = YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                rt = Vector128.ConditionalSelect(args4, rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX2Insert_Core(Vector128<short> back, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) {
                return YShuffleX2Insert_Core(back.AsUInt16(), vector0.AsUInt16(), vector1.AsUInt16(), args0.AsUInt16(), args1.AsUInt16(), args2.AsUInt16(), args3.AsUInt16(), args4.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX2Insert_Core(Vector128<ushort> back, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) {
                Vector128<ushort> rt = YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                rt = Vector128.ConditionalSelect(args4, rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX2Insert_Core(Vector128<int> back, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
                return YShuffleX2Insert_Core(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32(), args4.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX2Insert_Core(Vector128<uint> back, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) {
                Vector128<uint> rt = YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                rt = Vector128.ConditionalSelect(args4, rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX2Insert_Core(Vector128<long> back, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
                return YShuffleX2Insert_Core(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64(), args4.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX2Insert_Core(Vector128<ulong> back, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) {
                Vector128<ulong> rt = YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                rt = Vector128.ConditionalSelect(args4, rt, back);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX2Kernel_AcceleratedTypes {
                get {
                    return YShuffleKernel_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{float}, Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX2Kernel(Vector128<float> vector0, Vector128<float> vector1, Vector128<int> indices) {
                return YShuffleX2Kernel(vector0.AsInt32(), vector1.AsInt32(), indices).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{double}, Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX2Kernel(Vector128<double> vector0, Vector128<double> vector1, Vector128<long> indices) {
                return YShuffleX2Kernel(vector0.AsInt64(), vector1.AsInt64(), indices).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX2Kernel(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> indices) {
                return YShuffleX2Kernel(vector0.AsByte(), vector1.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX2Kernel(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> indices) {
                return YShuffleX2Kernel_Combine(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX2Kernel_Combine(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> indices) {
                return YShuffleX2Kernel_Combine(vector0.AsByte(), vector1.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX2Kernel_Combine(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> indices) {
                Vector128<byte> vCount = Vector128.Create((byte)Vector128<byte>.Count);
                Vector128<byte> indices1 = PackedSimd.Subtract(indices, vCount);
                Vector128<byte> rt0 = PackedSimd.Swizzle(vector0, indices);
                Vector128<byte> mask = PackedSimd.CompareGreaterThan(vCount.AsSByte(), indices.AsSByte()).AsByte(); // vCount[i]>indices[i] ==> indices[i]<vCount[i].
                Vector128<byte> rt1 = PackedSimd.Swizzle(vector1, indices1);
                Vector128<byte> rt = Vector128.ConditionalSelect(mask, rt0, rt1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX2Kernel(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> indices) {
                return YShuffleX2Kernel(vector0.AsUInt16(), vector1.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX2Kernel(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> indices) {
                return YShuffleX2Kernel_Combine(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{short}, Vector128{short}, Vector128{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX2Kernel_Combine(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> indices) {
                return YShuffleX2Kernel_Combine(vector0.AsUInt16(), vector1.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX2Kernel_Combine(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> indices) {
                Vector128<byte> indices2 = PackedSimd.Add(Multiply(indices, Vector128Constants.Shuffle_UInt16_Multiplier).AsByte(), Vector128Constants.Shuffle_UInt16_ByteOffset);
                return YShuffleX2Kernel_Combine(vector0.AsByte(), vector1.AsByte(), indices2).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX2Kernel(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> indices) {
                return YShuffleX2Kernel(vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX2Kernel(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> indices) {
                return YShuffleX2Kernel_Combine(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{int}, Vector128{int}, Vector128{int})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX2Kernel_Combine(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> indices) {
                return YShuffleX2Kernel_Combine(vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX2Kernel_Combine(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> indices) {
                Vector128<byte> indices2 = PackedSimd.Add(Multiply(indices, Vector128Constants.Shuffle_UInt32_Multiplier).AsByte(), Vector128Constants.Shuffle_UInt32_ByteOffset);
                return YShuffleX2Kernel_Combine(vector0.AsByte(), vector1.AsByte(), indices2).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX2Kernel(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> indices) {
                return YShuffleX2Kernel(vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX2Kernel(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> indices) {
                return YShuffleX2Kernel_Combine(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{long}, Vector128{long}, Vector128{long})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX2Kernel_Combine(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> indices) {
                return YShuffleX2Kernel_Combine(vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX2Kernel_Combine(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> indices) {
                Vector128<uint> temp = PackedSimd.Or(PackedSimd.ShiftLeft(indices, 32), indices).AsUInt32();
                Vector128<byte> indices2 = PackedSimd.Add(PackedSimd.Multiply(temp, Vector128Constants.Shuffle_UInt64_Multiplier.AsUInt32()).AsByte(), Vector128Constants.Shuffle_UInt64_ByteOffset);
                return YShuffleX2Kernel_Combine(vector0.AsByte(), vector1.AsByte(), indices2).AsUInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3) {
                YShuffleX2Kernel_Args(indices.AsByte(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsSByte();
                args1 = a1.AsSByte();
                args2 = a2.AsSByte();
                args3 = a3.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3) {
                Vector128<byte> vCount = Vector128.Create((byte)Vector128<byte>.Count);
                Vector128<byte> indices1 = PackedSimd.Subtract(indices, vCount);
                Vector128<byte> mask = PackedSimd.CompareGreaterThan(vCount.AsSByte(), indices.AsSByte()).AsByte(); // vCount[i]>indices[i] ==> indices[i]<vCount[i].
                args0 = YOrNot(indices, mask);
                args1 = PackedSimd.Or(indices1, mask);
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3) {
                YShuffleX2Kernel_Args(indices.AsUInt16(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsInt16();
                args1 = a1.AsInt16();
                args2 = a2.AsInt16();
                args3 = a3.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3) {
                Vector128<byte> indices2 = PackedSimd.Add(Multiply(indices, Vector128Constants.Shuffle_UInt16_Multiplier).AsByte(), Vector128Constants.Shuffle_UInt16_ByteOffset);
                YShuffleX2Kernel_Args(indices2, out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsUInt16();
                args1 = a1.AsUInt16();
                args2 = a2.AsUInt16();
                args3 = a3.AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3) {
                YShuffleX2Kernel_Args(indices.AsUInt32(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsInt32();
                args1 = a1.AsInt32();
                args2 = a2.AsInt32();
                args3 = a3.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3) {
                Vector128<byte> indices2 = PackedSimd.Add(Multiply(indices, Vector128Constants.Shuffle_UInt32_Multiplier).AsByte(), Vector128Constants.Shuffle_UInt32_ByteOffset);
                YShuffleX2Kernel_Args(indices2, out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsUInt32();
                args1 = a1.AsUInt32();
                args2 = a2.AsUInt32();
                args3 = a3.AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3) {
                YShuffleX2Kernel_Args(indices.AsUInt64(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsInt64();
                args1 = a1.AsInt64();
                args2 = a2.AsInt64();
                args3 = a3.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3) {
                Vector128<uint> temp = PackedSimd.Or(PackedSimd.ShiftLeft(indices, 32), indices).AsUInt32();
                Vector128<byte> indices2 = PackedSimd.Add(PackedSimd.Multiply(temp, Vector128Constants.Shuffle_UInt64_Multiplier.AsUInt32()).AsByte(), Vector128Constants.Shuffle_UInt64_ByteOffset);
                YShuffleX2Kernel_Args(indices2, out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsUInt64();
                args1 = a1.AsUInt64();
                args2 = a2.AsUInt64();
                args3 = a3.AsUInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX2Kernel_Core(Vector128<float> vector0, Vector128<float> vector1, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3) {
                return YShuffleX2Kernel_Core(vector0.AsUInt32(), vector1.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX2Kernel_Core(Vector128<double> vector0, Vector128<double> vector1, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3) {
                return YShuffleX2Kernel_Core(vector0.AsUInt64(), vector1.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX2Kernel_Core(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3) {
                return YShuffleX2Kernel_Core(vector0.AsByte(), vector1.AsByte(), args0.AsByte(), args1.AsByte(), args2.AsByte(), args3.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX2Kernel_Core(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                Vector128<byte> rt0 = PackedSimd.Swizzle(vector0, args0);
                Vector128<byte> rt1 = PackedSimd.Swizzle(vector1, args1);
                Vector128<byte> rt = PackedSimd.Or(rt0, rt1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX2Kernel_Core(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3) {
                return YShuffleX2Kernel_Core(vector0.AsUInt16(), vector1.AsUInt16(), args0.AsUInt16(), args1.AsUInt16(), args2.AsUInt16(), args3.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX2Kernel_Core(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3) {
                return YShuffleX2Kernel_Core(vector0.AsByte(), vector1.AsByte(), args0.AsByte(), args1.AsByte(), args2.AsByte(), args3.AsByte()).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX2Kernel_Core(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3) {
                return YShuffleX2Kernel_Core(vector0.AsUInt32(), vector1.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX2Kernel_Core(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3) {
                return YShuffleX2Kernel_Core(vector0.AsByte(), vector1.AsByte(), args0.AsByte(), args1.AsByte(), args2.AsByte(), args3.AsByte()).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX2Kernel_Core(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3) {
                return YShuffleX2Kernel_Core(vector0.AsUInt64(), vector1.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX2Kernel_Core(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3) {
                return YShuffleX2Kernel_Core(vector0.AsByte(), vector1.AsByte(), args0.AsByte(), args1.AsByte(), args2.AsByte(), args3.AsByte()).AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX3_AcceleratedTypes {
                get {
                    return YShuffleX3Kernel_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX3(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<int> indices) {
                return YShuffleX3(vector0.AsInt32(), vector1.AsInt32(), vector2.AsInt32(), indices).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX3(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<long> indices) {
                return YShuffleX3(vector0.AsInt64(), vector1.AsInt64(), vector2.AsInt64(), indices).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX3(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> indices) {
                return YShuffleX3(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX3(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> indices) {
                const byte total = 3 * ByteCountValue / sizeof(byte); // 3 * Vector128<byte>.Count
                Vector128<byte> mask, raw, rt;
                mask = PackedSimd.CompareGreaterThan(
                    Vector128.Create((sbyte)(total + sbyte.MinValue)),
                    PackedSimd.Add(indices.AsSByte(), Vector128.Create(sbyte.MinValue))
                ).AsByte(); // Unsigned compare: (i < total)
                raw = YShuffleX3Kernel(vector0, vector1, vector2, indices);
                rt = PackedSimd.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX3(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> indices) {
                return YShuffleX3(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX3(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> indices) {
                const ushort total = 3 * ByteCountValue / sizeof(ushort); // 3 * Vector128<ushort>.Count
                Vector128<ushort> mask, raw, rt;
                mask = PackedSimd.CompareGreaterThan(
                    Vector128.Create((short)(total + short.MinValue)),
                    PackedSimd.Add(indices.AsInt16(), Vector128.Create(short.MinValue))
                ).AsUInt16(); // Unsigned compare: (i < total)
                raw = YShuffleX3Kernel(vector0, vector1, vector2, indices);
                rt = PackedSimd.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX3(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> indices) {
                return YShuffleX3(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX3(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> indices) {
                const uint total = 3 * ByteCountValue / sizeof(uint); // 3 * Vector128<uint>.Count
                Vector128<uint> mask, raw, rt;
                mask = PackedSimd.CompareGreaterThan(
                    Vector128.Create((int)(total + int.MinValue)),
                    PackedSimd.Add(indices.AsInt32(), Vector128.Create(int.MinValue))
                ).AsUInt32(); // Unsigned compare: (i < total)
                raw = YShuffleX3Kernel(vector0, vector1, vector2, indices);
                rt = PackedSimd.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX3(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> indices) {
                return YShuffleX3(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX3(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> indices) {
                const ulong total = 3 * ByteCountValue / sizeof(ulong); // 3 * Vector128<ulong>.Count
                Vector128<ulong> mask, raw, rt;
                mask = GreaterThan(
                    Vector128.Create((long)(total) + long.MinValue),
                    PackedSimd.Add(indices.AsInt64(), Vector128.Create(long.MinValue))
                ).AsUInt64(); // Unsigned compare: (i < total)
                raw = YShuffleX3Kernel(vector0, vector1, vector2, indices);
                rt = PackedSimd.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3, out Vector128<sbyte> args4) {
                YShuffleX3_Args(indices.AsByte(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsSByte();
                args1 = a1.AsSByte();
                args2 = a2.AsSByte();
                args3 = a3.AsSByte();
                args4 = a4.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3, out Vector128<byte> args4) {
                const byte total = 3 * ByteCountValue / sizeof(byte); // 3 * Vector128<byte>.Count
                YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
                args4 = PackedSimd.CompareGreaterThan(
                    Vector128.Create((sbyte)(total + sbyte.MinValue)),
                    PackedSimd.Add(indices.AsSByte(), Vector128.Create(sbyte.MinValue))
                ).AsByte(); // Unsigned compare: (i < total)
                Vector128<byte> mask = OnesComplement(args4); // Change mask to `0 is keep; AllBitsSet is set zero`.
                args0 = PackedSimd.Or(args0, mask);
                args1 = PackedSimd.Or(args1, mask);
                args2 = PackedSimd.Or(args2, mask);
                //args3 = PackedSimd.Or(args3, mask);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3, out Vector128<short> args4) {
                YShuffleX3_Args(indices.AsUInt16(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsInt16();
                args1 = a1.AsInt16();
                args2 = a2.AsInt16();
                args3 = a3.AsInt16();
                args4 = a4.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3, out Vector128<ushort> args4) {
                const ushort total = 3 * ByteCountValue / sizeof(ushort); // 3 * Vector128<ushort>.Count
                YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
                args4 = PackedSimd.CompareGreaterThan(
                    Vector128.Create((short)(total + short.MinValue)),
                    PackedSimd.Add(indices.AsInt16(), Vector128.Create(short.MinValue))
                ).AsUInt16(); // Unsigned compare: (i < total)
                Vector128<ushort> mask = OnesComplement(args4); // Change mask to `0 is keep; AllBitsSet is set zero`.
                args0 = PackedSimd.Or(args0, mask);
                args1 = PackedSimd.Or(args1, mask);
                args2 = PackedSimd.Or(args2, mask);
                //args3 = PackedSimd.Or(args3, mask);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3, out Vector128<int> args4) {
                YShuffleX3_Args(indices.AsUInt32(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsInt32();
                args1 = a1.AsInt32();
                args2 = a2.AsInt32();
                args3 = a3.AsInt32();
                args4 = a4.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3, out Vector128<uint> args4) {
                const uint total = 3 * ByteCountValue / sizeof(uint); // 3 * Vector128<uint>.Count
                YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
                args4 = PackedSimd.CompareGreaterThan(
                    Vector128.Create((int)(total + int.MinValue)),
                    PackedSimd.Add(indices.AsInt32(), Vector128.Create(int.MinValue))
                ).AsUInt32(); // Unsigned compare: (i < total)
                Vector128<uint> mask = OnesComplement(args4); // Change mask to `0 is keep; AllBitsSet is set zero`.
                args0 = PackedSimd.Or(args0, mask);
                args1 = PackedSimd.Or(args1, mask);
                args2 = PackedSimd.Or(args2, mask);
                //args3 = PackedSimd.Or(args3, mask);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3, out Vector128<long> args4) {
                YShuffleX3_Args(indices.AsUInt64(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsInt64();
                args1 = a1.AsInt64();
                args2 = a2.AsInt64();
                args3 = a3.AsInt64();
                args4 = a4.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3, out Vector128<ulong> args4) {
                const ulong total = 3 * ByteCountValue / sizeof(ulong); // 3 * Vector128<ulong>.Count
                YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
                args4 = GreaterThan(
                    Vector128.Create((long)(total) + long.MinValue),
                    PackedSimd.Add(indices.AsInt64(), Vector128.Create(long.MinValue))
                ).AsUInt64(); // Unsigned compare: (i < total)
                Vector128<ulong> mask = OnesComplement(args4); // Change mask to `0 is keep; AllBitsSet is set zero`.
                args0 = PackedSimd.Or(args0, mask);
                args1 = PackedSimd.Or(args1, mask);
                args2 = PackedSimd.Or(args2, mask);
                //args3 = PackedSimd.Or(args3, mask);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX3_Core(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
                return YShuffleX3_Core(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32(), args4.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Core(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX3_Core(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
                return YShuffleX3_Core(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64(), args4.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX3_Core(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) {
                return YShuffleX3_Core(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), args0.AsByte(), args1.AsByte(), args2.AsByte(), args3.AsByte(), args4.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX3_Core(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) {
                Vector128<byte> rt = YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
                //rt = PackedSimd.And(rt, args4);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX3_Core(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) {
                return YShuffleX3_Core(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), args0.AsUInt16(), args1.AsUInt16(), args2.AsUInt16(), args3.AsUInt16(), args4.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX3_Core(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) {
                Vector128<ushort> rt = YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
                //rt = PackedSimd.And(rt, args4);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX3_Core(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
                return YShuffleX3_Core(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32(), args4.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX3_Core(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) {
                Vector128<uint> rt = YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
                //rt = PackedSimd.And(rt, args4);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX3_Core(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
                return YShuffleX3_Core(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64(), args4.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX3_Core(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) {
                Vector128<ulong> rt = YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
                //rt = PackedSimd.And(rt, args4);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX3Insert_AcceleratedTypes {
                get {
                    return YShuffleX3Kernel_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX3Insert(Vector128<float> back, Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<int> indices) {
                return YShuffleX3Insert(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX3Insert(Vector128<double> back, Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<long> indices) {
                return YShuffleX3Insert(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX3Insert(Vector128<sbyte> back, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> indices) {
                return YShuffleX3Insert(back.AsByte(), vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX3Insert(Vector128<byte> back, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> indices) {
                const byte total = 3 * ByteCountValue / sizeof(byte); // 3 * Vector128<byte>.Count
                Vector128<byte> mask, raw, rt;
                mask = PackedSimd.CompareGreaterThan(
                    Vector128.Create((sbyte)(total + sbyte.MinValue)),
                    PackedSimd.Add(indices.AsSByte(), Vector128.Create(sbyte.MinValue))
                ).AsByte(); // Unsigned compare: (i < total)
                raw = YShuffleX3Kernel(vector0, vector1, vector2, indices);
                rt = Vector128.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX3Insert(Vector128<short> back, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> indices) {
                return YShuffleX3Insert(back.AsUInt16(), vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX3Insert(Vector128<ushort> back, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> indices) {
                const ushort total = 3 * ByteCountValue / sizeof(ushort); // 3 * Vector128<ushort>.Count
                Vector128<ushort> mask, raw, rt;
                mask = PackedSimd.CompareGreaterThan(
                    Vector128.Create((short)(total + short.MinValue)),
                    PackedSimd.Add(indices.AsInt16(), Vector128.Create(short.MinValue))
                ).AsUInt16(); // Unsigned compare: (i < total)
                raw = YShuffleX3Kernel(vector0, vector1, vector2, indices);
                rt = Vector128.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX3Insert(Vector128<int> back, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> indices) {
                return YShuffleX3Insert(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX3Insert(Vector128<uint> back, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> indices) {
                const uint total = 3 * ByteCountValue / sizeof(uint); // 3 * Vector128<uint>.Count
                Vector128<uint> mask, raw, rt;
                mask = PackedSimd.CompareGreaterThan(
                    Vector128.Create((int)(total + int.MinValue)),
                    PackedSimd.Add(indices.AsInt32(), Vector128.Create(int.MinValue))
                ).AsUInt32(); // Unsigned compare: (i < total)
                raw = YShuffleX3Kernel(vector0, vector1, vector2, indices);
                rt = Vector128.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX3Insert(Vector128<long> back, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> indices) {
                return YShuffleX3Insert(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX3Insert(Vector128<ulong> back, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> indices) {
                const ulong total = 3 * ByteCountValue / sizeof(ulong); // 3 * Vector128<ulong>.Count
                Vector128<ulong> mask, raw, rt;
                mask = GreaterThan(
                    Vector128.Create((long)(total) + long.MinValue),
                    PackedSimd.Add(indices.AsInt64(), Vector128.Create(long.MinValue))
                ).AsUInt64(); // Unsigned compare: (i < total)
                raw = YShuffleX3Kernel(vector0, vector1, vector2, indices);
                rt = Vector128.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3, out Vector128<sbyte> args4) {
                YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3, out Vector128<byte> args4) {
                YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3, out Vector128<short> args4) {
                YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3, out Vector128<ushort> args4) {
                YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3, out Vector128<int> args4) {
                YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3, out Vector128<uint> args4) {
                YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3, out Vector128<long> args4) {
                YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3, out Vector128<ulong> args4) {
                YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX3Insert_Core(Vector128<float> back, Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
                //return YShuffleX3Insert_Core(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32(), args4.AsUInt32()).AsSingle();
                Vector128<float> rt = YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
                rt = Vector128.ConditionalSelect(args4.AsSingle(), rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX3Insert_Core(Vector128<double> back, Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
                //return YShuffleX3Insert_Core(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64(), args4.AsUInt64()).AsDouble();
                Vector128<double> rt = YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
                rt = Vector128.ConditionalSelect(args4.AsDouble(), rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX3Insert_Core(Vector128<sbyte> back, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) {
                return YShuffleX3Insert_Core(back.AsByte(), vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), args0.AsByte(), args1.AsByte(), args2.AsByte(), args3.AsByte(), args4.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX3Insert_Core(Vector128<byte> back, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) {
                Vector128<byte> rt = YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
                rt = Vector128.ConditionalSelect(args4, rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX3Insert_Core(Vector128<short> back, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) {
                return YShuffleX3Insert_Core(back.AsUInt16(), vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), args0.AsUInt16(), args1.AsUInt16(), args2.AsUInt16(), args3.AsUInt16(), args4.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX3Insert_Core(Vector128<ushort> back, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) {
                Vector128<ushort> rt = YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
                rt = Vector128.ConditionalSelect(args4, rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX3Insert_Core(Vector128<int> back, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
                return YShuffleX3Insert_Core(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32(), args4.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX3Insert_Core(Vector128<uint> back, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) {
                Vector128<uint> rt = YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
                rt = Vector128.ConditionalSelect(args4, rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX3Insert_Core(Vector128<long> back, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
                return YShuffleX3Insert_Core(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64(), args4.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX3Insert_Core(Vector128<ulong> back, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) {
                Vector128<ulong> rt = YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
                rt = Vector128.ConditionalSelect(args4, rt, back);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX3Kernel_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = YShuffleKernel_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX3Kernel(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<int> indices) {
                return YShuffleX3Kernel(vector0.AsInt32(), vector1.AsInt32(), vector2.AsInt32(), indices).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX3Kernel(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<long> indices) {
                return YShuffleX3Kernel(vector0.AsInt64(), vector1.AsInt64(), vector2.AsInt64(), indices).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX3Kernel(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> indices) {
                return YShuffleX3Kernel(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX3Kernel(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> indices) {
                return YShuffleX3Kernel_Combine(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX3Kernel_Combine(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> indices) {
                return YShuffleX3Kernel_Combine(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX3Kernel_Combine(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> indices) {
                Vector128<byte> vCount2 = Vector128.Create((byte)(Vector128<byte>.Count * 2));
                Vector128<byte> indices1 = PackedSimd.Subtract(indices, vCount2);
                Vector128<byte> rt0 = YShuffleX2Kernel_Combine(vector0, vector1, indices);
                Vector128<byte> mask = PackedSimd.CompareGreaterThan(vCount2.AsSByte(), indices.AsSByte()).AsByte(); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                Vector128<byte> rt1 = PackedSimd.Swizzle(vector2, indices1);
                Vector128<byte> rt = Vector128.ConditionalSelect(mask, rt0, rt1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX3Kernel(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> indices) {
                return YShuffleX3Kernel(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX3Kernel(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> indices) {
                return YShuffleX3Kernel_Combine(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX3Kernel_Combine(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> indices) {
                return YShuffleX3Kernel_Combine(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX3Kernel_Combine(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> indices) {
                Vector128<byte> indices2 = PackedSimd.Add(Multiply(indices, Vector128Constants.Shuffle_UInt16_Multiplier).AsByte(), Vector128Constants.Shuffle_UInt16_ByteOffset);
                return YShuffleX3Kernel_Combine(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), indices2).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX3Kernel(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> indices) {
                return YShuffleX3Kernel(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX3Kernel(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> indices) {
                return YShuffleX3Kernel_Combine(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX3Kernel_Combine(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> indices) {
                return YShuffleX3Kernel_Combine(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX3Kernel_Combine(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> indices) {
                Vector128<byte> indices2 = PackedSimd.Add(Multiply(indices, Vector128Constants.Shuffle_UInt32_Multiplier).AsByte(), Vector128Constants.Shuffle_UInt32_ByteOffset);
                return YShuffleX3Kernel_Combine(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), indices2).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX3Kernel(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> indices) {
                return YShuffleX3Kernel(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX3Kernel(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> indices) {
                return YShuffleX3Kernel_Combine(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX3Kernel_Combine(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> indices) {
                return YShuffleX3Kernel_Combine(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX3Kernel_Combine(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> indices) {
                Vector128<uint> temp = PackedSimd.Or(PackedSimd.ShiftLeft(indices, 32), indices).AsUInt32();
                Vector128<byte> indices2 = PackedSimd.Add(PackedSimd.Multiply(temp, Vector128Constants.Shuffle_UInt64_Multiplier.AsUInt32()).AsByte(), Vector128Constants.Shuffle_UInt64_ByteOffset);
                return YShuffleX3Kernel_Combine(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), indices2).AsUInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3) {
                YShuffleX3Kernel_Args(indices.AsByte(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsSByte();
                args1 = a1.AsSByte();
                args2 = a2.AsSByte();
                args3 = a3.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3) {
                YShuffleX3Kernel_Args_Combine(indices, out args0, out args1, out args2, out args3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args_Combine(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3) {
                Vector128<byte> vCount = Vector128.Create((byte)(Vector128<byte>.Count));
                Vector128<sbyte> vzero = Vector128<sbyte>.Zero;
                Vector128<byte> indices1 = PackedSimd.Subtract(indices, vCount);
                Vector128<byte> indices2 = PackedSimd.Subtract(indices1, vCount);
                Vector128<byte> mask0 = PackedSimd.CompareGreaterThan(vzero, indices1.AsSByte()).AsByte(); // 0>indices1[i] ==> indices1[i]<0 ==> indices[i]<Count.
                Vector128<byte> mask2 = PackedSimd.CompareGreaterThan(vzero, indices2.AsSByte()).AsByte(); // 0>indices2[i] ==> indices2[i]<0 ==> indices[i]<Count*2.
                Vector128<byte> mask1 = AndNot(mask2, mask0);
                args0 = YOrNot(indices, mask0);
                args1 = YOrNot(indices1, mask1);
                args2 = PackedSimd.Or(indices2, mask2);
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3) {
                YShuffleX3Kernel_Args(indices.AsUInt16(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsInt16();
                args1 = a1.AsInt16();
                args2 = a2.AsInt16();
                args3 = a3.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3) {
                Vector128<byte> indices2 = PackedSimd.Add(Multiply(indices, Vector128Constants.Shuffle_UInt16_Multiplier).AsByte(), Vector128Constants.Shuffle_UInt16_ByteOffset);
                YShuffleX3Kernel_Args(indices2, out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsUInt16();
                args1 = a1.AsUInt16();
                args2 = a2.AsUInt16();
                args3 = a3.AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3) {
                YShuffleX3Kernel_Args(indices.AsUInt32(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsInt32();
                args1 = a1.AsInt32();
                args2 = a2.AsInt32();
                args3 = a3.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3) {
                Vector128<byte> indices2 = PackedSimd.Add(Multiply(indices, Vector128Constants.Shuffle_UInt32_Multiplier).AsByte(), Vector128Constants.Shuffle_UInt32_ByteOffset);
                YShuffleX3Kernel_Args(indices2, out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsUInt32();
                args1 = a1.AsUInt32();
                args2 = a2.AsUInt32();
                args3 = a3.AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3) {
                YShuffleX3Kernel_Args(indices.AsUInt64(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsInt64();
                args1 = a1.AsInt64();
                args2 = a2.AsInt64();
                args3 = a3.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3) {
                Vector128<uint> temp = PackedSimd.Or(PackedSimd.ShiftLeft(indices, 32), indices).AsUInt32();
                Vector128<byte> indices2 = PackedSimd.Add(PackedSimd.Multiply(temp, Vector128Constants.Shuffle_UInt64_Multiplier.AsUInt32()).AsByte(), Vector128Constants.Shuffle_UInt64_ByteOffset);
                YShuffleX3Kernel_Args(indices2, out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsUInt64();
                args1 = a1.AsUInt64();
                args2 = a2.AsUInt64();
                args3 = a3.AsUInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX3Kernel_Core(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3) {
                return YShuffleX3Kernel_Core(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX3Kernel_Core(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3) {
                return YShuffleX3Kernel_Core(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX3Kernel_Core(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3) {
                return YShuffleX3Kernel_Core(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), args0.AsByte(), args1.AsByte(), args2.AsByte(), args3.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX3Kernel_Core(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3) {
                return YShuffleX3Kernel_Core_Combine(vector0, vector1, vector2, args0, args1, args2, args3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX3Kernel_Core_Combine(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3) {
                Vector128<byte> rt0 = PackedSimd.Swizzle(vector0, args0);
                Vector128<byte> rt1 = PackedSimd.Swizzle(vector1, args1);
                rt0 = PackedSimd.Or(rt0, rt1);
                Vector128<byte> rt2 = PackedSimd.Swizzle(vector2, args2);
                rt0 = PackedSimd.Or(rt0, rt2);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX3Kernel_Core(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3) {
                return YShuffleX3Kernel_Core(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), args0.AsUInt16(), args1.AsUInt16(), args2.AsUInt16(), args3.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX3Kernel_Core(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3) {
                return YShuffleX3Kernel_Core(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), args0.AsByte(), args1.AsByte(), args2.AsByte(), args3.AsByte()).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX3Kernel_Core(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3) {
                return YShuffleX3Kernel_Core(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX3Kernel_Core(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3) {
                return YShuffleX3Kernel_Core(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), args0.AsByte(), args1.AsByte(), args2.AsByte(), args3.AsByte()).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX3Kernel_Core(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3) {
                return YShuffleX3Kernel_Core(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX3Kernel_Core(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3) {
                return YShuffleX3Kernel_Core(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), args0.AsByte(), args1.AsByte(), args2.AsByte(), args3.AsByte()).AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX4_AcceleratedTypes {
                get {
                    return YShuffleX4Kernel_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX4(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<float> vector3, Vector128<int> indices) {
                return YShuffleX4(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX4(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<double> vector3, Vector128<long> indices) {
                return YShuffleX4(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX4(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, Vector128<sbyte> indices) {
                return YShuffleX4(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), vector3.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX4(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, Vector128<byte> indices) {
                const byte total = 4 * ByteCountValue / sizeof(byte); // 4 * Vector128<byte>.Count
                Vector128<byte> mask, raw, rt;
                mask = PackedSimd.CompareGreaterThan(
                    Vector128.Create((sbyte)(total + sbyte.MinValue)),
                    PackedSimd.Add(indices.AsSByte(), Vector128.Create(sbyte.MinValue))
                ).AsByte(); // Unsigned compare: (i < total)
                raw = YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
                rt = PackedSimd.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX4(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, Vector128<short> indices) {
                return YShuffleX4(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), vector3.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX4(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, Vector128<ushort> indices) {
                Vector128<ushort> mask, raw, rt;
                mask = PackedSimd.CompareEqual(PackedSimd.ShiftRightLogical(indices, 5), Vector128<ushort>.Zero); // Unsigned compare: (i < 32)
                raw = YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
                rt = PackedSimd.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX4(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, Vector128<int> indices) {
                return YShuffleX4(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX4(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, Vector128<uint> indices) {
                Vector128<uint> mask, raw, rt;
                mask = PackedSimd.CompareEqual(PackedSimd.ShiftRightLogical(indices, 4), Vector128<uint>.Zero); // Unsigned compare: (i < 16)
                raw = YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
                rt = PackedSimd.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX4(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, Vector128<long> indices) {
                return YShuffleX4(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX4(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, Vector128<ulong> indices) {
                Vector128<ulong> mask, raw, rt;
                mask = Equals(PackedSimd.ShiftRightLogical(indices, 3), Vector128<ulong>.Zero); // Unsigned compare: (i < 8)
                raw = YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
                rt = PackedSimd.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3, out Vector128<sbyte> args4) {
                YShuffleX4_Args(indices.AsByte(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsSByte();
                args1 = a1.AsSByte();
                args2 = a2.AsSByte();
                args3 = a3.AsSByte();
                args4 = a4.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3, out Vector128<byte> args4) {
                const byte total = 4 * ByteCountValue / sizeof(byte); // 4 * Vector128<byte>.Count
                YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
                args4 = PackedSimd.CompareGreaterThan(
                    Vector128.Create((sbyte)(total + sbyte.MinValue)),
                    PackedSimd.Add(indices.AsSByte(), Vector128.Create(sbyte.MinValue))
                ).AsByte(); // Unsigned compare: (i < total)
                Vector128<byte> mask = OnesComplement(args4); // Change mask to `0 is keep; AllBitsSet is set zero`.
                args0 = PackedSimd.Or(args0, mask);
                args1 = PackedSimd.Or(args1, mask);
                args2 = PackedSimd.Or(args2, mask);
                args3 = PackedSimd.Or(args3, mask);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3, out Vector128<short> args4) {
                YShuffleX4_Args(indices.AsUInt16(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsInt16();
                args1 = a1.AsInt16();
                args2 = a2.AsInt16();
                args3 = a3.AsInt16();
                args4 = a4.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3, out Vector128<ushort> args4) {
                YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
                args4 = PackedSimd.CompareEqual(PackedSimd.ShiftRightLogical(indices, 5), Vector128<ushort>.Zero); // Unsigned compare: (i < 32)
                Vector128<ushort> mask = OnesComplement(args4); // Change mask to `0 is keep; AllBitsSet is set zero`.
                args0 = PackedSimd.Or(args0, mask);
                args1 = PackedSimd.Or(args1, mask);
                args2 = PackedSimd.Or(args2, mask);
                args3 = PackedSimd.Or(args3, mask);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3, out Vector128<int> args4) {
                YShuffleX4_Args(indices.AsUInt32(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsInt32();
                args1 = a1.AsInt32();
                args2 = a2.AsInt32();
                args3 = a3.AsInt32();
                args4 = a4.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3, out Vector128<uint> args4) {
                YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
                args4 = PackedSimd.CompareEqual(PackedSimd.ShiftRightLogical(indices, 4), Vector128<uint>.Zero); // Unsigned compare: (i < 16)
                Vector128<uint> mask = OnesComplement(args4); // Change mask to `0 is keep; AllBitsSet is set zero`.
                args0 = PackedSimd.Or(args0, mask);
                args1 = PackedSimd.Or(args1, mask);
                args2 = PackedSimd.Or(args2, mask);
                args3 = PackedSimd.Or(args3, mask);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3, out Vector128<long> args4) {
                YShuffleX4_Args(indices.AsUInt64(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsInt64();
                args1 = a1.AsInt64();
                args2 = a2.AsInt64();
                args3 = a3.AsInt64();
                args4 = a4.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3, out Vector128<ulong> args4) {
                YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
                args4 = Equals(PackedSimd.ShiftRightLogical(indices, 3), Vector128<ulong>.Zero); // Unsigned compare: (i < 8)
                Vector128<ulong> mask = OnesComplement(args4); // Change mask to `0 is keep; AllBitsSet is set zero`.
                args0 = PackedSimd.Or(args0, mask);
                args1 = PackedSimd.Or(args1, mask);
                args2 = PackedSimd.Or(args2, mask);
                args3 = PackedSimd.Or(args3, mask);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX4_Core(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<float> vector3, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
                Vector128<float> rt = YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
                //rt = PackedSimd.And(rt, args4);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Core(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX4_Core(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<double> vector3, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
                Vector128<double> rt = YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
                //rt = PackedSimd.And(rt, args4);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX4_Core(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) {
                return YShuffleX4_Core(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), vector3.AsByte(), args0.AsByte(), args1.AsByte(), args2.AsByte(), args3.AsByte(), args4.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX4_Core(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) {
                Vector128<byte> rt = YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
                //rt = PackedSimd.And(rt, args4);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX4_Core(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) {
                return YShuffleX4_Core(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), vector3.AsUInt16(), args0.AsUInt16(), args1.AsUInt16(), args2.AsUInt16(), args3.AsUInt16(), args4.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX4_Core(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) {
                Vector128<ushort> rt = YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
                //rt = PackedSimd.And(rt, args4);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX4_Core(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
                return YShuffleX4_Core(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32(), args4.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX4_Core(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) {
                Vector128<uint> rt = YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
                //rt = PackedSimd.And(rt, args4);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX4_Core(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
                return YShuffleX4_Core(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64(), args4.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX4_Core(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) {
                Vector128<ulong> rt = YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
                //rt = PackedSimd.And(rt, args4);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX4Insert_AcceleratedTypes {
                get {
                    return YShuffleX4Kernel_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX4Insert(Vector128<float> back, Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<float> vector3, Vector128<int> indices) {
                return YShuffleX4Insert(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX4Insert(Vector128<double> back, Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<double> vector3, Vector128<long> indices) {
                return YShuffleX4Insert(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX4Insert(Vector128<sbyte> back, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, Vector128<sbyte> indices) {
                return YShuffleX4Insert(back.AsByte(), vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), vector3.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX4Insert(Vector128<byte> back, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, Vector128<byte> indices) {
                const byte total = 4 * ByteCountValue / sizeof(byte); // 3 * Vector128<byte>.Count
                Vector128<byte> mask, raw, rt;
                mask = PackedSimd.CompareGreaterThan(
                    Vector128.Create((sbyte)(total + sbyte.MinValue)),
                    PackedSimd.Add(indices.AsSByte(), Vector128.Create(sbyte.MinValue))
                ).AsByte(); // Unsigned compare: (i < total)
                raw = YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
                rt = Vector128.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX4Insert(Vector128<short> back, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, Vector128<short> indices) {
                return YShuffleX4Insert(back.AsUInt16(), vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), vector3.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX4Insert(Vector128<ushort> back, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, Vector128<ushort> indices) {
                Vector128<ushort> mask, raw, rt;
                mask = PackedSimd.CompareEqual(PackedSimd.ShiftRightLogical(indices, 5), Vector128<ushort>.Zero); // Unsigned compare: (i < 32)
                raw = YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
                rt = Vector128.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX4Insert(Vector128<int> back, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, Vector128<int> indices) {
                return YShuffleX4Insert(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX4Insert(Vector128<uint> back, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, Vector128<uint> indices) {
                Vector128<uint> mask, raw, rt;
                mask = PackedSimd.CompareEqual(PackedSimd.ShiftRightLogical(indices, 4), Vector128<uint>.Zero); // Unsigned compare: (i < 16)
                raw = YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
                rt = Vector128.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX4Insert(Vector128<long> back, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, Vector128<long> indices) {
                return YShuffleX4Insert(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX4Insert(Vector128<ulong> back, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, Vector128<ulong> indices) {
                Vector128<ulong> mask, raw, rt;
                mask = Equals(PackedSimd.ShiftRightLogical(indices, 3), Vector128<ulong>.Zero); // Unsigned compare: (i < 8)
                raw = YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
                rt = Vector128.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3, out Vector128<sbyte> args4) {
                YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3, out Vector128<byte> args4) {
                YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3, out Vector128<short> args4) {
                YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3, out Vector128<ushort> args4) {
                YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3, out Vector128<int> args4) {
                YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3, out Vector128<uint> args4) {
                YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3, out Vector128<long> args4) {
                YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3, out Vector128<ulong> args4) {
                YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX4Insert_Core(Vector128<float> back, Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<float> vector3, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
                Vector128<float> rt = YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
                rt = Vector128.ConditionalSelect(args4.AsSingle(), rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX4Insert_Core(Vector128<double> back, Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<double> vector3, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
                Vector128<double> rt = YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
                rt = Vector128.ConditionalSelect(args4.AsDouble(), rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX4Insert_Core(Vector128<sbyte> back, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) {
                return YShuffleX4Insert_Core(back.AsByte(), vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), vector3.AsByte(), args0.AsByte(), args1.AsByte(), args2.AsByte(), args3.AsByte(), args4.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX4Insert_Core(Vector128<byte> back, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) {
                Vector128<byte> rt = YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
                rt = Vector128.ConditionalSelect(args4, rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX4Insert_Core(Vector128<short> back, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) {
                return YShuffleX4Insert_Core(back.AsUInt16(), vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), vector3.AsUInt16(), args0.AsUInt16(), args1.AsUInt16(), args2.AsUInt16(), args3.AsUInt16(), args4.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX4Insert_Core(Vector128<ushort> back, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) {
                Vector128<ushort> rt = YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
                rt = Vector128.ConditionalSelect(args4, rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX4Insert_Core(Vector128<int> back, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
                return YShuffleX4Insert_Core(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32(), args4.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX4Insert_Core(Vector128<uint> back, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) {
                Vector128<uint> rt = YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
                rt = Vector128.ConditionalSelect(args4, rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX4Insert_Core(Vector128<long> back, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
                return YShuffleX4Insert_Core(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64(), args4.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX4Insert_Core(Vector128<ulong> back, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) {
                Vector128<ulong> rt = YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
                rt = Vector128.ConditionalSelect(args4, rt, back);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX4Kernel_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = YShuffleKernel_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX4Kernel(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<float> vector3, Vector128<int> indices) {
                return YShuffleX4Kernel(vector0.AsInt32(), vector1.AsInt32(), vector2.AsInt32(), vector3.AsInt32(), indices).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX4Kernel(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<double> vector3, Vector128<long> indices) {
                return YShuffleX4Kernel(vector0.AsInt64(), vector1.AsInt64(), vector2.AsInt64(), vector3.AsInt64(), indices).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX4Kernel(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, Vector128<sbyte> indices) {
                return YShuffleX4Kernel(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), vector3.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX4Kernel(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, Vector128<byte> indices) {
                return YShuffleX4Kernel_Combine(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX4Kernel_Combine(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, Vector128<sbyte> indices) {
                return YShuffleX4Kernel_Combine(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), vector3.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX4Kernel_Combine(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, Vector128<byte> indices) {
                Vector128<byte> vCount2 = Vector128.Create((byte)(Vector128<byte>.Count * 2));
                Vector128<byte> indices1 = PackedSimd.Subtract(indices, vCount2);
                Vector128<byte> rt0 = YShuffleX2Kernel_Combine(vector0, vector1, indices);
                Vector128<byte> mask = PackedSimd.CompareGreaterThan(vCount2.AsSByte(), indices.AsSByte()).AsByte(); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                Vector128<byte> rt1 = YShuffleX2Kernel_Combine(vector2, vector3, indices1);
                Vector128<byte> rt = Vector128.ConditionalSelect(mask, rt0, rt1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX4Kernel(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, Vector128<short> indices) {
                return YShuffleX4Kernel(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), vector3.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX4Kernel(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, Vector128<ushort> indices) {
                return YShuffleX4Kernel_Combine(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX4Kernel_Combine(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, Vector128<short> indices) {
                return YShuffleX4Kernel_Combine(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), vector3.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX4Kernel_Combine(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, Vector128<ushort> indices) {
                Vector128<byte> indices2 = PackedSimd.Add(Multiply(indices, Vector128Constants.Shuffle_UInt16_Multiplier).AsByte(), Vector128Constants.Shuffle_UInt16_ByteOffset);
                return YShuffleX4Kernel_Combine(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), vector3.AsByte(), indices2).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX4Kernel(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, Vector128<int> indices) {
                return YShuffleX4Kernel(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX4Kernel(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, Vector128<uint> indices) {
                return YShuffleX4Kernel_Combine(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX4Kernel_Combine(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, Vector128<int> indices) {
                return YShuffleX4Kernel_Combine(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX4Kernel_Combine(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, Vector128<uint> indices) {
                Vector128<byte> indices2 = PackedSimd.Add(Multiply(indices, Vector128Constants.Shuffle_UInt32_Multiplier).AsByte(), Vector128Constants.Shuffle_UInt32_ByteOffset);
                return YShuffleX4Kernel_Combine(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), vector3.AsByte(), indices2).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX4Kernel(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, Vector128<long> indices) {
                return YShuffleX4Kernel(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX4Kernel(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, Vector128<ulong> indices) {
                return YShuffleX4Kernel_Combine(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX4Kernel_Combine(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, Vector128<long> indices) {
                return YShuffleX4Kernel_Combine(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX4Kernel_Combine(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, Vector128<ulong> indices) {
                Vector128<uint> temp = PackedSimd.Or(PackedSimd.ShiftLeft(indices, 32), indices).AsUInt32();
                Vector128<byte> indices2 = PackedSimd.Add(PackedSimd.Multiply(temp, Vector128Constants.Shuffle_UInt64_Multiplier.AsUInt32()).AsByte(), Vector128Constants.Shuffle_UInt64_ByteOffset);
                return YShuffleX4Kernel_Combine(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), vector3.AsByte(), indices2).AsUInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3) {
                YShuffleX4Kernel_Args(indices.AsByte(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsSByte();
                args1 = a1.AsSByte();
                args2 = a2.AsSByte();
                args3 = a3.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3) {
                YShuffleX4Kernel_Args_Combine(indices, out args0, out args1, out args2, out args3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args_Combine(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3) {
                Vector128<byte> vCount = Vector128.Create((byte)(Vector128<byte>.Count));
                Vector128<sbyte> vzero = Vector128<sbyte>.Zero;
                Vector128<byte> indices1 = PackedSimd.Subtract(indices, vCount);
                Vector128<byte> indices2 = PackedSimd.Subtract(indices1, vCount);
                Vector128<byte> indices3 = PackedSimd.Subtract(indices2, vCount);
                Vector128<byte> mask0 = PackedSimd.CompareGreaterThan(vzero, indices1.AsSByte()).AsByte(); // 0>indices1[i] ==> indices1[i]<0 ==> indices[i]<Count.
                Vector128<byte> mask1 = PackedSimd.CompareGreaterThan(vzero, indices2.AsSByte()).AsByte(); // 0>indices2[i] ==> indices2[i]<0 ==> indices[i]<Count*2.
                Vector128<byte> mask2 = PackedSimd.CompareGreaterThan(vzero, indices3.AsSByte()).AsByte(); // 0>indices3[i] ==> indices3[i]<0 ==> indices[i]<Count*3.
                Vector128<byte> mask3 = OnesComplement(mask2); // indices[i]>=Count*3.
                mask2 = AndNot(mask2, mask1);
                mask1 = AndNot(mask1, mask0);
                args0 = YOrNot(indices, mask0);
                args1 = YOrNot(indices1, mask1);
                args2 = YOrNot(indices2, mask2);
                args3 = YOrNot(indices3, mask3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3) {
                YShuffleX4Kernel_Args(indices.AsUInt16(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsInt16();
                args1 = a1.AsInt16();
                args2 = a2.AsInt16();
                args3 = a3.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3) {
                Vector128<byte> indices2 = PackedSimd.Add(Multiply(indices, Vector128Constants.Shuffle_UInt16_Multiplier).AsByte(), Vector128Constants.Shuffle_UInt16_ByteOffset);
                YShuffleX4Kernel_Args(indices2, out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsUInt16();
                args1 = a1.AsUInt16();
                args2 = a2.AsUInt16();
                args3 = a3.AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3) {
                YShuffleX4Kernel_Args(indices.AsUInt32(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsInt32();
                args1 = a1.AsInt32();
                args2 = a2.AsInt32();
                args3 = a3.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3) {
                Vector128<byte> indices2 = PackedSimd.Add(Multiply(indices, Vector128Constants.Shuffle_UInt32_Multiplier).AsByte(), Vector128Constants.Shuffle_UInt32_ByteOffset);
                YShuffleX4Kernel_Args(indices2, out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsUInt32();
                args1 = a1.AsUInt32();
                args2 = a2.AsUInt32();
                args3 = a3.AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3) {
                YShuffleX4Kernel_Args(indices.AsUInt64(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsInt64();
                args1 = a1.AsInt64();
                args2 = a2.AsInt64();
                args3 = a3.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3) {
                Vector128<uint> temp = PackedSimd.Or(PackedSimd.ShiftLeft(indices, 32), indices).AsUInt32();
                Vector128<byte> indices2 = PackedSimd.Add(PackedSimd.Multiply(temp, Vector128Constants.Shuffle_UInt64_Multiplier.AsUInt32()).AsByte(), Vector128Constants.Shuffle_UInt64_ByteOffset);
                YShuffleX4Kernel_Args(indices2, out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsUInt64();
                args1 = a1.AsUInt64();
                args2 = a2.AsUInt64();
                args3 = a3.AsUInt64();
                return;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX4Kernel_Core(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<float> vector3, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3) {
                return YShuffleX4Kernel_Core(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX4Kernel_Core(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<double> vector3, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3) {
                return YShuffleX4Kernel_Core(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX4Kernel_Core(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3) {
                return YShuffleX4Kernel_Core(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), vector3.AsByte(), args0.AsByte(), args1.AsByte(), args2.AsByte(), args3.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX4Kernel_Core(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3) {
                return YShuffleX4Kernel_Core_Combine(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX4Kernel_Core_Combine(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3) {
                Vector128<byte> rt0 = PackedSimd.Swizzle(vector0, args0);
                Vector128<byte> rt1 = PackedSimd.Swizzle(vector1, args1);
                rt0 = PackedSimd.Or(rt0, rt1);
                Vector128<byte> rt2 = PackedSimd.Swizzle(vector2, args2);
                Vector128<byte> rt3 = PackedSimd.Swizzle(vector3, args3);
                rt2 = PackedSimd.Or(rt2, rt3);
                rt0 = PackedSimd.Or(rt0, rt2);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX4Kernel_Core(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3) {
                return YShuffleX4Kernel_Core(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), vector3.AsUInt16(), args0.AsUInt16(), args1.AsUInt16(), args2.AsUInt16(), args3.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX4Kernel_Core(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3) {
                return YShuffleX4Kernel_Core(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), vector3.AsByte(), args0.AsByte(), args1.AsByte(), args2.AsByte(), args3.AsByte()).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX4Kernel_Core(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3) {
                return YShuffleX4Kernel_Core(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX4Kernel_Core(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3) {
                return YShuffleX4Kernel_Core(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), vector3.AsByte(), args0.AsByte(), args1.AsByte(), args2.AsByte(), args3.AsByte()).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX4Kernel_Core(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3) {
                return YShuffleX4Kernel_Core(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX4Kernel_Core(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3) {
                return YShuffleX4Kernel_Core(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), vector3.AsByte(), args0.AsByte(), args1.AsByte(), args2.AsByte(), args3.AsByte()).AsUInt64();
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
