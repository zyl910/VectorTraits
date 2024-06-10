using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Numerics;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using System.Text;
using Zyl.VectorTraits.Extensions;
using Zyl.VectorTraits.Extensions.SameW;
using Zyl.VectorTraits.Impl.AVector128;

namespace Zyl.VectorTraits.Impl.AVector {
    using WStatics = WVectorTraits128Sse.Statics;
    using BaseStatics = VectorTraitsBase.Statics;

    partial class VectorTraits128Sse {
#if NETCOREAPP3_0_OR_GREATER
        partial class Statics {

            /// <inheritdoc cref="IVectorTraits.YShuffleG2_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleG2_AcceleratedTypes {
                get {
                    return WStatics.YShuffleG2_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{float}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleG2(Vector<float> source, ShuffleControlG2 control) {
                return WStatics.YShuffleG2(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{double}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleG2(Vector<double> source, ShuffleControlG2 control) {
                return WStatics.YShuffleG2(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{sbyte}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleG2(Vector<sbyte> source, ShuffleControlG2 control) {
                return WStatics.YShuffleG2(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{byte}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleG2(Vector<byte> source, ShuffleControlG2 control) {
                return WStatics.YShuffleG2(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{short}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleG2(Vector<short> source, ShuffleControlG2 control) {
                return WStatics.YShuffleG2(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{ushort}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleG2(Vector<ushort> source, ShuffleControlG2 control) {
                return WStatics.YShuffleG2(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{int}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleG2(Vector<int> source, ShuffleControlG2 control) {
                return WStatics.YShuffleG2(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{uint}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleG2(Vector<uint> source, ShuffleControlG2 control) {
                return WStatics.YShuffleG2(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{long}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleG2(Vector<long> source, ShuffleControlG2 control) {
                return WStatics.YShuffleG2(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{ulong}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleG2(Vector<ulong> source, ShuffleControlG2 control) {
                return WStatics.YShuffleG2(source.AsVector128(), control).AsVector();
            }

#if !REDUCE_MEMORY_USAGE
            /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{float}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleG2_Const(Vector<float> source, [ConstantExpected] ShuffleControlG2 control) {
                return WStatics.YShuffleG2(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{double}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleG2_Const(Vector<double> source, [ConstantExpected] ShuffleControlG2 control) {
                return WStatics.YShuffleG2(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{sbyte}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleG2_Const(Vector<sbyte> source, [ConstantExpected] ShuffleControlG2 control) {
                return WStatics.YShuffleG2_Const(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{byte}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleG2_Const(Vector<byte> source, [ConstantExpected] ShuffleControlG2 control) {
                return WStatics.YShuffleG2_Const(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{short}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleG2_Const(Vector<short> source, [ConstantExpected] ShuffleControlG2 control) {
                return WStatics.YShuffleG2_Const(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{ushort}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleG2_Const(Vector<ushort> source, [ConstantExpected] ShuffleControlG2 control) {
                return WStatics.YShuffleG2_Const(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{int}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleG2_Const(Vector<int> source, [ConstantExpected] ShuffleControlG2 control) {
                return WStatics.YShuffleG2_Const(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{uint}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleG2_Const(Vector<uint> source, [ConstantExpected] ShuffleControlG2 control) {
                return WStatics.YShuffleG2_Const(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{long}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleG2_Const(Vector<long> source, [ConstantExpected] ShuffleControlG2 control) {
                return WStatics.YShuffleG2_Const(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{ulong}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleG2_Const(Vector<ulong> source, [ConstantExpected] ShuffleControlG2 control) {
                return WStatics.YShuffleG2_Const(source.AsVector128(), control).AsVector();
            }
#endif // !REDUCE_MEMORY_USAGE


            /// <inheritdoc cref="IVectorTraits.YShuffleG4_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleG4_AcceleratedTypes {
                get {
                    return WStatics.YShuffleG4_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{float}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleG4(Vector<float> source, ShuffleControlG4 control) {
                return WStatics.YShuffleG4(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{sbyte}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleG4(Vector<sbyte> source, ShuffleControlG4 control) {
                return WStatics.YShuffleG4(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{byte}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleG4(Vector<byte> source, ShuffleControlG4 control) {
                return WStatics.YShuffleG4(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{short}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleG4(Vector<short> source, ShuffleControlG4 control) {
                return WStatics.YShuffleG4(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{ushort}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleG4(Vector<ushort> source, ShuffleControlG4 control) {
                return WStatics.YShuffleG4(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{int}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleG4(Vector<int> source, ShuffleControlG4 control) {
                return WStatics.YShuffleG4(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{uint}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleG4(Vector<uint> source, ShuffleControlG4 control) {
                return WStatics.YShuffleG4(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{float}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleG4_Const(Vector<float> source, [ConstantExpected] ShuffleControlG4 control) {
                return WStatics.YShuffleG4_Const(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{sbyte}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleG4_Const(Vector<sbyte> source, [ConstantExpected] ShuffleControlG4 control) {
                return WStatics.YShuffleG4_Const(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{byte}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleG4_Const(Vector<byte> source, [ConstantExpected] ShuffleControlG4 control) {
                return WStatics.YShuffleG4_Const(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{short}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleG4_Const(Vector<short> source, [ConstantExpected] ShuffleControlG4 control) {
                return WStatics.YShuffleG4_Const(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{ushort}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleG4_Const(Vector<ushort> source, [ConstantExpected] ShuffleControlG4 control) {
                return WStatics.YShuffleG4_Const(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{int}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleG4_Const(Vector<int> source, [ConstantExpected] ShuffleControlG4 control) {
                return WStatics.YShuffleG4_Const(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{uint}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleG4_Const(Vector<uint> source, [ConstantExpected] ShuffleControlG4 control) {
                return WStatics.YShuffleG4_Const(source.AsVector128(), control).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleG4X2_AcceleratedTypes {
                get {
                    return WStatics.YShuffleG4X2_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{float}, Vector{float}, ShuffleControlG4, out Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleG4X2(Vector<float> source0, Vector<float> source1, ShuffleControlG4 control, out Vector<float> result1) {
                var rt0 = WStatics.YShuffleG4X2(source0.AsVector128(), source1.AsVector128(), control, out var rt1);
                result1 = rt1.AsVector();
                return rt0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{double}, Vector{double}, ShuffleControlG4, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleG4X2(Vector<double> source0, Vector<double> source1, ShuffleControlG4 control, out Vector<double> result1) {
                var rt0 = WStatics.YShuffleG4X2(source0.AsVector128(), source1.AsVector128(), control, out var rt1);
                result1 = rt1.AsVector();
                return rt0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{sbyte}, Vector{sbyte}, ShuffleControlG4, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleG4X2(Vector<sbyte> source0, Vector<sbyte> source1, ShuffleControlG4 control, out Vector<sbyte> result1) {
                var rt0 = WStatics.YShuffleG4X2(source0.AsVector128(), source1.AsVector128(), control, out var rt1);
                result1 = rt1.AsVector();
                return rt0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{byte}, Vector{byte}, ShuffleControlG4, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleG4X2(Vector<byte> source0, Vector<byte> source1, ShuffleControlG4 control, out Vector<byte> result1) {
                var rt0 = WStatics.YShuffleG4X2(source0.AsVector128(), source1.AsVector128(), control, out var rt1);
                result1 = rt1.AsVector();
                return rt0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{short}, Vector{short}, ShuffleControlG4, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleG4X2(Vector<short> source0, Vector<short> source1, ShuffleControlG4 control, out Vector<short> result1) {
                var rt0 = WStatics.YShuffleG4X2(source0.AsVector128(), source1.AsVector128(), control, out var rt1);
                result1 = rt1.AsVector();
                return rt0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{ushort}, Vector{ushort}, ShuffleControlG4, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleG4X2(Vector<ushort> source0, Vector<ushort> source1, ShuffleControlG4 control, out Vector<ushort> result1) {
                var rt0 = WStatics.YShuffleG4X2(source0.AsVector128(), source1.AsVector128(), control, out var rt1);
                result1 = rt1.AsVector();
                return rt0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{int}, Vector{int}, ShuffleControlG4, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleG4X2(Vector<int> source0, Vector<int> source1, ShuffleControlG4 control, out Vector<int> result1) {
                var rt0 = WStatics.YShuffleG4X2(source0.AsVector128(), source1.AsVector128(), control, out var rt1);
                result1 = rt1.AsVector();
                return rt0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{uint}, Vector{uint}, ShuffleControlG4, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleG4X2(Vector<uint> source0, Vector<uint> source1, ShuffleControlG4 control, out Vector<uint> result1) {
                var rt0 = WStatics.YShuffleG4X2(source0.AsVector128(), source1.AsVector128(), control, out var rt1);
                result1 = rt1.AsVector();
                return rt0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{long}, Vector{long}, ShuffleControlG4, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleG4X2(Vector<long> source0, Vector<long> source1, ShuffleControlG4 control, out Vector<long> result1) {
                var rt0 = WStatics.YShuffleG4X2(source0.AsVector128(), source1.AsVector128(), control, out var rt1);
                result1 = rt1.AsVector();
                return rt0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{ulong}, Vector{ulong}, ShuffleControlG4, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleG4X2(Vector<ulong> source0, Vector<ulong> source1, ShuffleControlG4 control, out Vector<ulong> result1) {
                var rt0 = WStatics.YShuffleG4X2(source0.AsVector128(), source1.AsVector128(), control, out var rt1);
                result1 = rt1.AsVector();
                return rt0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{float}, Vector{float}, ShuffleControlG4, out Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleG4X2_Const(Vector<float> source0, Vector<float> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<float> result1) {
                var rt0 = WStatics.YShuffleG4X2_Const(source0.AsVector128(), source1.AsVector128(), control, out var rt1);
                result1 = rt1.AsVector();
                return rt0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{double}, Vector{double}, ShuffleControlG4, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleG4X2_Const(Vector<double> source0, Vector<double> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<double> result1) {
                var rt0 = WStatics.YShuffleG4X2_Const(source0.AsVector128(), source1.AsVector128(), control, out var rt1);
                result1 = rt1.AsVector();
                return rt0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{sbyte}, Vector{sbyte}, ShuffleControlG4, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleG4X2_Const(Vector<sbyte> source0, Vector<sbyte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<sbyte> result1) {
                var rt0 = WStatics.YShuffleG4X2_Const(source0.AsVector128(), source1.AsVector128(), control, out var rt1);
                result1 = rt1.AsVector();
                return rt0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{byte}, Vector{byte}, ShuffleControlG4, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleG4X2_Const(Vector<byte> source0, Vector<byte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<byte> result1) {
                var rt0 = WStatics.YShuffleG4X2_Const(source0.AsVector128(), source1.AsVector128(), control, out var rt1);
                result1 = rt1.AsVector();
                return rt0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{short}, Vector{short}, ShuffleControlG4, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleG4X2_Const(Vector<short> source0, Vector<short> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<short> result1) {
                var rt0 = WStatics.YShuffleG4X2_Const(source0.AsVector128(), source1.AsVector128(), control, out var rt1);
                result1 = rt1.AsVector();
                return rt0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{ushort}, Vector{ushort}, ShuffleControlG4, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleG4X2_Const(Vector<ushort> source0, Vector<ushort> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<ushort> result1) {
                var rt0 = WStatics.YShuffleG4X2_Const(source0.AsVector128(), source1.AsVector128(), control, out var rt1);
                result1 = rt1.AsVector();
                return rt0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{int}, Vector{int}, ShuffleControlG4, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleG4X2_Const(Vector<int> source0, Vector<int> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<int> result1) {
                var rt0 = WStatics.YShuffleG4X2_Const(source0.AsVector128(), source1.AsVector128(), control, out var rt1);
                result1 = rt1.AsVector();
                return rt0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{uint}, Vector{uint}, ShuffleControlG4, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleG4X2_Const(Vector<uint> source0, Vector<uint> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<uint> result1) {
                var rt0 = WStatics.YShuffleG4X2_Const(source0.AsVector128(), source1.AsVector128(), control, out var rt1);
                result1 = rt1.AsVector();
                return rt0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{long}, Vector{long}, ShuffleControlG4, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleG4X2_Const(Vector<long> source0, Vector<long> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<long> result1) {
                var rt0 = WStatics.YShuffleG4X2_Const(source0.AsVector128(), source1.AsVector128(), control, out var rt1);
                result1 = rt1.AsVector();
                return rt0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{ulong}, Vector{ulong}, ShuffleControlG4, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleG4X2_Const(Vector<ulong> source0, Vector<ulong> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<ulong> result1) {
                var rt0 = WStatics.YShuffleG4X2_Const(source0.AsVector128(), source1.AsVector128(), control, out var rt1);
                result1 = rt1.AsVector();
                return rt0.AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleInsert_AcceleratedTypes {
                get {
                    return WStatics.YShuffleInsert_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{float}, Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleInsert(Vector<float> back, Vector<float> vector, Vector<int> indices) {
                return WStatics.YShuffleInsert(back.AsVector128(), vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{double}, Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleInsert(Vector<double> back, Vector<double> vector, Vector<long> indices) {
                return WStatics.YShuffleInsert(back.AsVector128(), vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleInsert(Vector<sbyte> back, Vector<sbyte> vector, Vector<sbyte> indices) {
                return WStatics.YShuffleInsert(back.AsVector128(), vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleInsert(Vector<byte> back, Vector<byte> vector, Vector<byte> indices) {
                return WStatics.YShuffleInsert(back.AsVector128(), vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleInsert(Vector<short> back, Vector<short> vector, Vector<short> indices) {
                return WStatics.YShuffleInsert(back.AsVector128(), vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleInsert(Vector<ushort> back, Vector<ushort> vector, Vector<ushort> indices) {
                return WStatics.YShuffleInsert(back.AsVector128(), vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleInsert(Vector<int> back, Vector<int> vector, Vector<int> indices) {
                return WStatics.YShuffleInsert(back.AsVector128(), vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleInsert(Vector<uint> back, Vector<uint> vector, Vector<uint> indices) {
                return WStatics.YShuffleInsert(back.AsVector128(), vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleInsert(Vector<long> back, Vector<long> vector, Vector<long> indices) {
                return WStatics.YShuffleInsert(back.AsVector128(), vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleInsert(Vector<ulong> back, Vector<ulong> vector, Vector<ulong> indices) {
                return WStatics.YShuffleInsert(back.AsVector128(), vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2) {
                WStatics.YShuffleInsert_Args(indices.AsVector128(), out var a0, out var a1, out var a2);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2) {
                WStatics.YShuffleInsert_Args(indices.AsVector128(), out var a0, out var a1, out var a2);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2) {
                WStatics.YShuffleInsert_Args(indices.AsVector128(), out var a0, out var a1, out var a2);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2) {
                WStatics.YShuffleInsert_Args(indices.AsVector128(), out var a0, out var a1, out var a2);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2) {
                WStatics.YShuffleInsert_Args(indices.AsVector128(), out var a0, out var a1, out var a2);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2) {
                WStatics.YShuffleInsert_Args(indices.AsVector128(), out var a0, out var a1, out var a2);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2) {
                WStatics.YShuffleInsert_Args(indices.AsVector128(), out var a0, out var a1, out var a2);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2) {
                WStatics.YShuffleInsert_Args(indices.AsVector128(), out var a0, out var a1, out var a2);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleInsert_Core(Vector<float> back, Vector<float> vector, Vector<int> args0, Vector<int> args1, Vector<int> args2) {
                return WStatics.YShuffleInsert_Core(back.AsVector128(), vector.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{double}, Vector{double}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleInsert_Core(Vector<double> back, Vector<double> vector, Vector<long> args0, Vector<long> args1, Vector<long> args2) {
                return WStatics.YShuffleInsert_Core(back.AsVector128(), vector.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleInsert_Core(Vector<sbyte> back, Vector<sbyte> vector, Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2) {
                return WStatics.YShuffleInsert_Core(back.AsVector128(), vector.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleInsert_Core(Vector<byte> back, Vector<byte> vector, Vector<byte> args0, Vector<byte> args1, Vector<byte> args2) {
                return WStatics.YShuffleInsert_Core(back.AsVector128(), vector.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleInsert_Core(Vector<short> back, Vector<short> vector, Vector<short> args0, Vector<short> args1, Vector<short> args2) {
                return WStatics.YShuffleInsert_Core(back.AsVector128(), vector.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleInsert_Core(Vector<ushort> back, Vector<ushort> vector, Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2) {
                return WStatics.YShuffleInsert_Core(back.AsVector128(), vector.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleInsert_Core(Vector<int> back, Vector<int> vector, Vector<int> args0, Vector<int> args1, Vector<int> args2) {
                return WStatics.YShuffleInsert_Core(back.AsVector128(), vector.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleInsert_Core(Vector<uint> back, Vector<uint> vector, Vector<uint> args0, Vector<uint> args1, Vector<uint> args2) {
                return WStatics.YShuffleInsert_Core(back.AsVector128(), vector.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleInsert_Core(Vector<long> back, Vector<long> vector, Vector<long> args0, Vector<long> args1, Vector<long> args2) {
                return WStatics.YShuffleInsert_Core(back.AsVector128(), vector.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleInsert_Core(Vector<ulong> back, Vector<ulong> vector, Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2) {
                return WStatics.YShuffleInsert_Core(back.AsVector128(), vector.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleKernel_AcceleratedTypes {
                get {
                    return WStatics.YShuffleKernel_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleKernel(Vector<float> vector, Vector<int> indices) {
                return WStatics.YShuffleKernel(vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleKernel(Vector<double> vector, Vector<long> indices) {
                return WStatics.YShuffleKernel(vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleKernel(Vector<sbyte> vector, Vector<sbyte> indices) {
                return WStatics.YShuffleKernel(vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleKernel(Vector<byte> vector, Vector<byte> indices) {
                return WStatics.YShuffleKernel(vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleKernel(Vector<short> vector, Vector<short> indices) {
                return WStatics.YShuffleKernel(vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleKernel(Vector<ushort> vector, Vector<ushort> indices) {
                return WStatics.YShuffleKernel(vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleKernel(Vector<int> vector, Vector<int> indices) {
                return WStatics.YShuffleKernel(vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleKernel(Vector<uint> vector, Vector<uint> indices) {
                return WStatics.YShuffleKernel(vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleKernel(Vector<long> vector, Vector<long> indices) {
                return WStatics.YShuffleKernel(vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleKernel(Vector<ulong> vector, Vector<ulong> indices) {
                return WStatics.YShuffleKernel(vector.AsVector128(), indices.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1) {
                WStatics.YShuffleKernel_Args(indices.AsVector128(), out var a0, out var a1);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Args(Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1) {
                WStatics.YShuffleKernel_Args(indices.AsVector128(), out var a0, out var a1);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Args(Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1) {
                WStatics.YShuffleKernel_Args(indices.AsVector128(), out var a0, out var a1);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1) {
                WStatics.YShuffleKernel_Args(indices.AsVector128(), out var a0, out var a1);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Args(Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1) {
                WStatics.YShuffleKernel_Args(indices.AsVector128(), out var a0, out var a1);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Args(Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1) {
                WStatics.YShuffleKernel_Args(indices.AsVector128(), out var a0, out var a1);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Args(Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1) {
                WStatics.YShuffleKernel_Args(indices.AsVector128(), out var a0, out var a1);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1) {
                WStatics.YShuffleKernel_Args(indices.AsVector128(), out var a0, out var a1);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{float}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleKernel_Core(Vector<float> vector, Vector<int> args0, Vector<int> args1) {
                return WStatics.YShuffleKernel_Core(vector.AsVector128(), args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{double}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleKernel_Core(Vector<double> vector, Vector<long> args0, Vector<long> args1) {
                return WStatics.YShuffleKernel_Core(vector.AsVector128(), args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleKernel_Core(Vector<sbyte> vector, Vector<sbyte> args0, Vector<sbyte> args1) {
                return WStatics.YShuffleKernel_Core(vector.AsVector128(), args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleKernel_Core(Vector<byte> vector, Vector<byte> args0, Vector<byte> args1) {
                return WStatics.YShuffleKernel_Core(vector.AsVector128(), args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleKernel_Core(Vector<short> vector, Vector<short> args0, Vector<short> args1) {
                return WStatics.YShuffleKernel_Core(vector.AsVector128(), args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleKernel_Core(Vector<ushort> vector, Vector<ushort> args0, Vector<ushort> args1) {
                return WStatics.YShuffleKernel_Core(vector.AsVector128(), args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleKernel_Core(Vector<int> vector, Vector<int> args0, Vector<int> args1) {
                return WStatics.YShuffleKernel_Core(vector.AsVector128(), args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleKernel_Core(Vector<uint> vector, Vector<uint> args0, Vector<uint> args1) {
                return WStatics.YShuffleKernel_Core(vector.AsVector128(), args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleKernel_Core(Vector<long> vector, Vector<long> args0, Vector<long> args1) {
                return WStatics.YShuffleKernel_Core(vector.AsVector128(), args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleKernel_Core(Vector<ulong> vector, Vector<ulong> args0, Vector<ulong> args1) {
                return WStatics.YShuffleKernel_Core(vector.AsVector128(), args0.AsVector128(), args1.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YShuffleX2_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX2_AcceleratedTypes {
                get {
                    return WStatics.YShuffleX2_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{float}, Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX2(Vector<float> vector0, Vector<float> vector1, Vector<int> indices) {
                return WStatics.YShuffleX2(vector0.AsVector128(), vector1.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{double}, Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX2(Vector<double> vector0, Vector<double> vector1, Vector<long> indices) {
                return WStatics.YShuffleX2(vector0.AsVector128(), vector1.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX2(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> indices) {
                return WStatics.YShuffleX2(vector0.AsVector128(), vector1.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX2(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> indices) {
                return WStatics.YShuffleX2(vector0.AsVector128(), vector1.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX2(Vector<short> vector0, Vector<short> vector1, Vector<short> indices) {
                return WStatics.YShuffleX2(vector0.AsVector128(), vector1.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX2(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> indices) {
                return WStatics.YShuffleX2(vector0.AsVector128(), vector1.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX2(Vector<int> vector0, Vector<int> vector1, Vector<int> indices) {
                return WStatics.YShuffleX2(vector0.AsVector128(), vector1.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX2(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> indices) {
                return WStatics.YShuffleX2(vector0.AsVector128(), vector1.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX2(Vector<long> vector0, Vector<long> vector1, Vector<long> indices) {
                return WStatics.YShuffleX2(vector0.AsVector128(), vector1.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX2(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> indices) {
                return WStatics.YShuffleX2(vector0.AsVector128(), vector1.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2, out Vector<sbyte> args3, out Vector<sbyte> args4) {
                WStatics.YShuffleX2_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2, out Vector<byte> args3, out Vector<byte> args4) {
                WStatics.YShuffleX2_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2, out Vector<short> args3, out Vector<short> args4) {
                WStatics.YShuffleX2_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2, out Vector<ushort> args3, out Vector<ushort> args4) {
                WStatics.YShuffleX2_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2, out Vector<int> args3, out Vector<int> args4) {
                WStatics.YShuffleX2_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2, out Vector<uint> args3, out Vector<uint> args4) {
                WStatics.YShuffleX2_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2, out Vector<long> args3, out Vector<long> args4) {
                WStatics.YShuffleX2_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2, out Vector<ulong> args3, out Vector<ulong> args4) {
                WStatics.YShuffleX2_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2_Core(Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX2_Core(Vector<float> vector0, Vector<float> vector1, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) {
                return WStatics.YShuffleX2_Core(vector0.AsVector128(), vector1.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2_Core(Vector{double}, Vector{double}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX2_Core(Vector<double> vector0, Vector<double> vector1, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) {
                return WStatics.YShuffleX2_Core(vector0.AsVector128(), vector1.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX2_Core(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4) {
                return WStatics.YShuffleX2_Core(vector0.AsVector128(), vector1.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX2_Core(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4) {
                return WStatics.YShuffleX2_Core(vector0.AsVector128(), vector1.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX2_Core(Vector<short> vector0, Vector<short> vector1, Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4) {
                return WStatics.YShuffleX2_Core(vector0.AsVector128(), vector1.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX2_Core(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4) {
                return WStatics.YShuffleX2_Core(vector0.AsVector128(), vector1.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX2_Core(Vector<int> vector0, Vector<int> vector1, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) {
                return WStatics.YShuffleX2_Core(vector0.AsVector128(), vector1.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX2_Core(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4) {
                return WStatics.YShuffleX2_Core(vector0.AsVector128(), vector1.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX2_Core(Vector<long> vector0, Vector<long> vector1, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) {
                return WStatics.YShuffleX2_Core(vector0.AsVector128(), vector1.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX2_Core(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4) {
                return WStatics.YShuffleX2_Core(vector0.AsVector128(), vector1.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX2Insert_AcceleratedTypes {
                get {
                    return WStatics.YShuffleX2Insert_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX2Insert(Vector<float> back, Vector<float> vector0, Vector<float> vector1, Vector<int> indices) {
                return WStatics.YShuffleX2Insert(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{double}, Vector{double}, Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX2Insert(Vector<double> back, Vector<double> vector0, Vector<double> vector1, Vector<long> indices) {
                return WStatics.YShuffleX2Insert(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX2Insert(Vector<sbyte> back, Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> indices) {
                return WStatics.YShuffleX2Insert(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX2Insert(Vector<byte> back, Vector<byte> vector0, Vector<byte> vector1, Vector<byte> indices) {
                return WStatics.YShuffleX2Insert(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX2Insert(Vector<short> back, Vector<short> vector0, Vector<short> vector1, Vector<short> indices) {
                return WStatics.YShuffleX2Insert(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX2Insert(Vector<ushort> back, Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> indices) {
                return WStatics.YShuffleX2Insert(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX2Insert(Vector<int> back, Vector<int> vector0, Vector<int> vector1, Vector<int> indices) {
                return WStatics.YShuffleX2Insert(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX2Insert(Vector<uint> back, Vector<uint> vector0, Vector<uint> vector1, Vector<uint> indices) {
                return WStatics.YShuffleX2Insert(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX2Insert(Vector<long> back, Vector<long> vector0, Vector<long> vector1, Vector<long> indices) {
                return WStatics.YShuffleX2Insert(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX2Insert(Vector<ulong> back, Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> indices) {
                return WStatics.YShuffleX2Insert(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2, out Vector<sbyte> args3, out Vector<sbyte> args4) {
                WStatics.YShuffleX2Insert_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2, out Vector<byte> args3, out Vector<byte> args4) {
                WStatics.YShuffleX2Insert_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2, out Vector<short> args3, out Vector<short> args4) {
                WStatics.YShuffleX2Insert_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2, out Vector<ushort> args3, out Vector<ushort> args4) {
                WStatics.YShuffleX2Insert_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2, out Vector<int> args3, out Vector<int> args4) {
                WStatics.YShuffleX2Insert_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2, out Vector<uint> args3, out Vector<uint> args4) {
                WStatics.YShuffleX2Insert_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2, out Vector<long> args3, out Vector<long> args4) {
                WStatics.YShuffleX2Insert_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2, out Vector<ulong> args3, out Vector<ulong> args4) {
                WStatics.YShuffleX2Insert_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX2Insert_Core(Vector<float> back, Vector<float> vector0, Vector<float> vector1, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) {
                return WStatics.YShuffleX2Insert_Core(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Core(Vector{double}, Vector{double}, Vector{double}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX2Insert_Core(Vector<double> back, Vector<double> vector0, Vector<double> vector1, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) {
                return WStatics.YShuffleX2Insert_Core(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX2Insert_Core(Vector<sbyte> back, Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4) {
                return WStatics.YShuffleX2Insert_Core(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX2Insert_Core(Vector<byte> back, Vector<byte> vector0, Vector<byte> vector1, Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4) {
                return WStatics.YShuffleX2Insert_Core(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX2Insert_Core(Vector<short> back, Vector<short> vector0, Vector<short> vector1, Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4) {
                return WStatics.YShuffleX2Insert_Core(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX2Insert_Core(Vector<ushort> back, Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4) {
                return WStatics.YShuffleX2Insert_Core(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX2Insert_Core(Vector<int> back, Vector<int> vector0, Vector<int> vector1, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) {
                return WStatics.YShuffleX2Insert_Core(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX2Insert_Core(Vector<uint> back, Vector<uint> vector0, Vector<uint> vector1, Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4) {
                return WStatics.YShuffleX2Insert_Core(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX2Insert_Core(Vector<long> back, Vector<long> vector0, Vector<long> vector1, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) {
                return WStatics.YShuffleX2Insert_Core(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX2Insert_Core(Vector<ulong> back, Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4) {
                return WStatics.YShuffleX2Insert_Core(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX2Kernel_AcceleratedTypes {
                get {
                    return WStatics.YShuffleX2Kernel_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{float}, Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX2Kernel(Vector<float> vector0, Vector<float> vector1, Vector<int> indices) {
                return WStatics.YShuffleX2Kernel(vector0.AsVector128(), vector1.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{double}, Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX2Kernel(Vector<double> vector0, Vector<double> vector1, Vector<long> indices) {
                return WStatics.YShuffleX2Kernel(vector0.AsVector128(), vector1.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX2Kernel(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> indices) {
                return WStatics.YShuffleX2Kernel(vector0.AsVector128(), vector1.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX2Kernel(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> indices) {
                return WStatics.YShuffleX2Kernel(vector0.AsVector128(), vector1.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX2Kernel(Vector<short> vector0, Vector<short> vector1, Vector<short> indices) {
                return WStatics.YShuffleX2Kernel(vector0.AsVector128(), vector1.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX2Kernel(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> indices) {
                return WStatics.YShuffleX2Kernel(vector0.AsVector128(), vector1.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX2Kernel(Vector<int> vector0, Vector<int> vector1, Vector<int> indices) {
                return WStatics.YShuffleX2Kernel(vector0.AsVector128(), vector1.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX2Kernel(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> indices) {
                return WStatics.YShuffleX2Kernel(vector0.AsVector128(), vector1.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX2Kernel(Vector<long> vector0, Vector<long> vector1, Vector<long> indices) {
                return WStatics.YShuffleX2Kernel(vector0.AsVector128(), vector1.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX2Kernel(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> indices) {
                return WStatics.YShuffleX2Kernel(vector0.AsVector128(), vector1.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2, out Vector<sbyte> args3) {
                WStatics.YShuffleX2Kernel_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2, out Vector<byte> args3) {
                WStatics.YShuffleX2Kernel_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2, out Vector<short> args3) {
                WStatics.YShuffleX2Kernel_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2, out Vector<ushort> args3) {
                WStatics.YShuffleX2Kernel_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2, out Vector<int> args3) {
                WStatics.YShuffleX2Kernel_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2, out Vector<uint> args3) {
                WStatics.YShuffleX2Kernel_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2, out Vector<long> args3) {
                WStatics.YShuffleX2Kernel_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2, out Vector<ulong> args3) {
                WStatics.YShuffleX2Kernel_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Core(Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX2Kernel_Core(Vector<float> vector0, Vector<float> vector1, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3) {
                return WStatics.YShuffleX2Kernel_Core(vector0.AsVector128(), vector1.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Core(Vector{double}, Vector{double}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX2Kernel_Core(Vector<double> vector0, Vector<double> vector1, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3) {
                return WStatics.YShuffleX2Kernel_Core(vector0.AsVector128(), vector1.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX2Kernel_Core(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3) {
                return WStatics.YShuffleX2Kernel_Core(vector0.AsVector128(), vector1.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX2Kernel_Core(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3) {
                return WStatics.YShuffleX2Kernel_Core(vector0.AsVector128(), vector1.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX2Kernel_Core(Vector<short> vector0, Vector<short> vector1, Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3) {
                return WStatics.YShuffleX2Kernel_Core(vector0.AsVector128(), vector1.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX2Kernel_Core(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3) {
                return WStatics.YShuffleX2Kernel_Core(vector0.AsVector128(), vector1.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX2Kernel_Core(Vector<int> vector0, Vector<int> vector1, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3) {
                return WStatics.YShuffleX2Kernel_Core(vector0.AsVector128(), vector1.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX2Kernel_Core(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3) {
                return WStatics.YShuffleX2Kernel_Core(vector0.AsVector128(), vector1.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX2Kernel_Core(Vector<long> vector0, Vector<long> vector1, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3) {
                return WStatics.YShuffleX2Kernel_Core(vector0.AsVector128(), vector1.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX2Kernel_Core(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3) {
                return WStatics.YShuffleX2Kernel_Core(vector0.AsVector128(), vector1.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YShuffleX3_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX3_AcceleratedTypes {
                get {
                    return WStatics.YShuffleX3_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX3(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<int> indices) {
                return WStatics.YShuffleX3(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{double}, Vector{double}, Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX3(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<long> indices) {
                return WStatics.YShuffleX3(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX3(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> indices) {
                return WStatics.YShuffleX3(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX3(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> indices) {
                return WStatics.YShuffleX3(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX3(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> indices) {
                return WStatics.YShuffleX3(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX3(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> indices) {
                return WStatics.YShuffleX3(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX3(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> indices) {
                return WStatics.YShuffleX3(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX3(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> indices) {
                return WStatics.YShuffleX3(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX3(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> indices) {
                return WStatics.YShuffleX3(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX3(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> indices) {
                return WStatics.YShuffleX3(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2, out Vector<sbyte> args3, out Vector<sbyte> args4) {
                WStatics.YShuffleX3_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2, out Vector<byte> args3, out Vector<byte> args4) {
                WStatics.YShuffleX3_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2, out Vector<short> args3, out Vector<short> args4) {
                WStatics.YShuffleX3_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2, out Vector<ushort> args3, out Vector<ushort> args4) {
                WStatics.YShuffleX3_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2, out Vector<int> args3, out Vector<int> args4) {
                WStatics.YShuffleX3_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2, out Vector<uint> args3, out Vector<uint> args4) {
                WStatics.YShuffleX3_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2, out Vector<long> args3, out Vector<long> args4) {
                WStatics.YShuffleX3_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2, out Vector<ulong> args3, out Vector<ulong> args4) {
                WStatics.YShuffleX3_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3_Core(Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX3_Core(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) {
                return WStatics.YShuffleX3_Core(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3_Core(Vector{double}, Vector{double}, Vector{double}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX3_Core(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) {
                return WStatics.YShuffleX3_Core(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX3_Core(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4) {
                return WStatics.YShuffleX3_Core(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX3_Core(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4) {
                return WStatics.YShuffleX3_Core(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX3_Core(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4) {
                return WStatics.YShuffleX3_Core(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX3_Core(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4) {
                return WStatics.YShuffleX3_Core(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX3_Core(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) {
                return WStatics.YShuffleX3_Core(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX3_Core(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4) {
                return WStatics.YShuffleX3_Core(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX3_Core(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) {
                return WStatics.YShuffleX3_Core(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX3_Core(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4) {
                return WStatics.YShuffleX3_Core(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX3Insert_AcceleratedTypes {
                get {
                    return YShuffleX3Kernel_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX3Insert(Vector<float> back, Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<int> indices) {
                return WStatics.YShuffleX3Insert(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX3Insert(Vector<double> back, Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<long> indices) {
                return WStatics.YShuffleX3Insert(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX3Insert(Vector<sbyte> back, Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> indices) {
                return WStatics.YShuffleX3Insert(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX3Insert(Vector<byte> back, Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> indices) {
                return WStatics.YShuffleX3Insert(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX3Insert(Vector<short> back, Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> indices) {
                return WStatics.YShuffleX3Insert(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX3Insert(Vector<ushort> back, Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> indices) {
                return WStatics.YShuffleX3Insert(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX3Insert(Vector<int> back, Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> indices) {
                return WStatics.YShuffleX3Insert(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX3Insert(Vector<uint> back, Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> indices) {
                return WStatics.YShuffleX3Insert(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX3Insert(Vector<long> back, Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> indices) {
                return WStatics.YShuffleX3Insert(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX3Insert(Vector<ulong> back, Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> indices) {
                return WStatics.YShuffleX3Insert(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2, out Vector<sbyte> args3, out Vector<sbyte> args4) {
                WStatics.YShuffleX3Insert_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2, out Vector<byte> args3, out Vector<byte> args4) {
                WStatics.YShuffleX3Insert_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2, out Vector<short> args3, out Vector<short> args4) {
                WStatics.YShuffleX3Insert_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2, out Vector<ushort> args3, out Vector<ushort> args4) {
                WStatics.YShuffleX3Insert_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2, out Vector<int> args3, out Vector<int> args4) {
                WStatics.YShuffleX3Insert_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2, out Vector<uint> args3, out Vector<uint> args4) {
                WStatics.YShuffleX3Insert_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2, out Vector<long> args3, out Vector<long> args4) {
                WStatics.YShuffleX3Insert_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2, out Vector<ulong> args3, out Vector<ulong> args4) {
                WStatics.YShuffleX3Insert_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX3Insert_Core(Vector<float> back, Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) {
                return WStatics.YShuffleX3Insert_Core(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Core(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX3Insert_Core(Vector<double> back, Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) {
                return WStatics.YShuffleX3Insert_Core(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX3Insert_Core(Vector<sbyte> back, Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4) {
                return WStatics.YShuffleX3Insert_Core(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX3Insert_Core(Vector<byte> back, Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4) {
                return WStatics.YShuffleX3Insert_Core(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX3Insert_Core(Vector<short> back, Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4) {
                return WStatics.YShuffleX3Insert_Core(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX3Insert_Core(Vector<ushort> back, Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4) {
                return WStatics.YShuffleX3Insert_Core(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX3Insert_Core(Vector<int> back, Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) {
                return WStatics.YShuffleX3Insert_Core(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX3Insert_Core(Vector<uint> back, Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4) {
                return WStatics.YShuffleX3Insert_Core(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX3Insert_Core(Vector<long> back, Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) {
                return WStatics.YShuffleX3Insert_Core(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX3Insert_Core(Vector<ulong> back, Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4) {
                return WStatics.YShuffleX3Insert_Core(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX3Kernel_AcceleratedTypes {
                get {
                    return WStatics.YShuffleX3Kernel_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX3Kernel(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<int> indices) {
                return WStatics.YShuffleX3Kernel(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{double}, Vector{double}, Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX3Kernel(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<long> indices) {
                return WStatics.YShuffleX3Kernel(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX3Kernel(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> indices) {
                return WStatics.YShuffleX3Kernel(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX3Kernel(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> indices) {
                return WStatics.YShuffleX3Kernel(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX3Kernel(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> indices) {
                return WStatics.YShuffleX3Kernel(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX3Kernel(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> indices) {
                return WStatics.YShuffleX3Kernel(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX3Kernel(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> indices) {
                return WStatics.YShuffleX3Kernel(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX3Kernel(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> indices) {
                return WStatics.YShuffleX3Kernel(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX3Kernel(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> indices) {
                return WStatics.YShuffleX3Kernel(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX3Kernel(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> indices) {
                return WStatics.YShuffleX3Kernel(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2, out Vector<sbyte> args3) {
                WStatics.YShuffleX3Kernel_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2, out Vector<byte> args3) {
                WStatics.YShuffleX3Kernel_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2, out Vector<short> args3) {
                WStatics.YShuffleX3Kernel_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2, out Vector<ushort> args3) {
                WStatics.YShuffleX3Kernel_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2, out Vector<int> args3) {
                WStatics.YShuffleX3Kernel_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2, out Vector<uint> args3) {
                WStatics.YShuffleX3Kernel_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2, out Vector<long> args3) {
                WStatics.YShuffleX3Kernel_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2, out Vector<ulong> args3) {
                WStatics.YShuffleX3Kernel_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Core(Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX3Kernel_Core(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3) {
                return WStatics.YShuffleX3Kernel_Core(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Core(Vector{double}, Vector{double}, Vector{double}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX3Kernel_Core(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3) {
                return WStatics.YShuffleX3Kernel_Core(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX3Kernel_Core(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3) {
                return WStatics.YShuffleX3Kernel_Core(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX3Kernel_Core(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3) {
                return WStatics.YShuffleX3Kernel_Core(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX3Kernel_Core(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3) {
                return WStatics.YShuffleX3Kernel_Core(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX3Kernel_Core(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3) {
                return WStatics.YShuffleX3Kernel_Core(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX3Kernel_Core(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3) {
                return WStatics.YShuffleX3Kernel_Core(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX3Kernel_Core(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3) {
                return WStatics.YShuffleX3Kernel_Core(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX3Kernel_Core(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3) {
                return WStatics.YShuffleX3Kernel_Core(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX3Kernel_Core(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3) {
                return WStatics.YShuffleX3Kernel_Core(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YShuffleX4_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX4_AcceleratedTypes {
                get {
                    return WStatics.YShuffleX4_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX4(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<float> vector3, Vector<int> indices) {
                return WStatics.YShuffleX4(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX4(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<double> vector3, Vector<long> indices) {
                return WStatics.YShuffleX4(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX4(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> vector3, Vector<sbyte> indices) {
                return WStatics.YShuffleX4(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX4(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> vector3, Vector<byte> indices) {
                return WStatics.YShuffleX4(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX4(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> vector3, Vector<short> indices) {
                return WStatics.YShuffleX4(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX4(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> vector3, Vector<ushort> indices) {
                return WStatics.YShuffleX4(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX4(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> vector3, Vector<int> indices) {
                return WStatics.YShuffleX4(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX4(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> vector3, Vector<uint> indices) {
                return WStatics.YShuffleX4(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX4(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> vector3, Vector<long> indices) {
                return WStatics.YShuffleX4(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX4(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> vector3, Vector<ulong> indices) {
                return WStatics.YShuffleX4(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2, out Vector<sbyte> args3, out Vector<sbyte> args4) {
                WStatics.YShuffleX4_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2, out Vector<byte> args3, out Vector<byte> args4) {
                WStatics.YShuffleX4_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2, out Vector<short> args3, out Vector<short> args4) {
                WStatics.YShuffleX4_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2, out Vector<ushort> args3, out Vector<ushort> args4) {
                WStatics.YShuffleX4_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2, out Vector<int> args3, out Vector<int> args4) {
                WStatics.YShuffleX4_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2, out Vector<uint> args3, out Vector<uint> args4) {
                WStatics.YShuffleX4_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2, out Vector<long> args3, out Vector<long> args4) {
                WStatics.YShuffleX4_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2, out Vector<ulong> args3, out Vector<ulong> args4) {
                WStatics.YShuffleX4_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX4_Core(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<float> vector3, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) {
                return WStatics.YShuffleX4_Core(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4_Core(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX4_Core(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<double> vector3, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) {
                return WStatics.YShuffleX4_Core(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX4_Core(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> vector3, Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4) {
                return WStatics.YShuffleX4_Core(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX4_Core(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> vector3, Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4) {
                return WStatics.YShuffleX4_Core(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX4_Core(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> vector3, Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4) {
                return WStatics.YShuffleX4_Core(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX4_Core(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> vector3, Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4) {
                return WStatics.YShuffleX4_Core(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX4_Core(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> vector3, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) {
                return WStatics.YShuffleX4_Core(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX4_Core(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> vector3, Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4) {
                return WStatics.YShuffleX4_Core(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX4_Core(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> vector3, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) {
                return WStatics.YShuffleX4_Core(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX4_Core(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> vector3, Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4) {
                return WStatics.YShuffleX4_Core(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX4Insert_AcceleratedTypes {
                get {
                    return WStatics.YShuffleX4Insert_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX4Insert(Vector<float> back, Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<float> vector3, Vector<int> indices) {
                return WStatics.YShuffleX4Insert(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX4Insert(Vector<double> back, Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<double> vector3, Vector<long> indices) {
                return WStatics.YShuffleX4Insert(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX4Insert(Vector<sbyte> back, Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> vector3, Vector<sbyte> indices) {
                return WStatics.YShuffleX4Insert(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX4Insert(Vector<byte> back, Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> vector3, Vector<byte> indices) {
                return WStatics.YShuffleX4Insert(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX4Insert(Vector<short> back, Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> vector3, Vector<short> indices) {
                return WStatics.YShuffleX4Insert(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX4Insert(Vector<ushort> back, Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> vector3, Vector<ushort> indices) {
                return WStatics.YShuffleX4Insert(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX4Insert(Vector<int> back, Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> vector3, Vector<int> indices) {
                return WStatics.YShuffleX4Insert(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX4Insert(Vector<uint> back, Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> vector3, Vector<uint> indices) {
                return WStatics.YShuffleX4Insert(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX4Insert(Vector<long> back, Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> vector3, Vector<long> indices) {
                return WStatics.YShuffleX4Insert(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX4Insert(Vector<ulong> back, Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> vector3, Vector<ulong> indices) {
                return WStatics.YShuffleX4Insert(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2, out Vector<sbyte> args3, out Vector<sbyte> args4) {
                WStatics.YShuffleX4Insert_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2, out Vector<byte> args3, out Vector<byte> args4) {
                WStatics.YShuffleX4Insert_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2, out Vector<short> args3, out Vector<short> args4) {
                WStatics.YShuffleX4Insert_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2, out Vector<ushort> args3, out Vector<ushort> args4) {
                WStatics.YShuffleX4Insert_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2, out Vector<int> args3, out Vector<int> args4) {
                WStatics.YShuffleX4Insert_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2, out Vector<uint> args3, out Vector<uint> args4) {
                WStatics.YShuffleX4Insert_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2, out Vector<long> args3, out Vector<long> args4) {
                WStatics.YShuffleX4Insert_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2, out Vector<ulong> args3, out Vector<ulong> args4) {
                WStatics.YShuffleX4Insert_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
                args4 = a4.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX4Insert_Core(Vector<float> back, Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<float> vector3, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) {
                return WStatics.YShuffleX4Insert_Core(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Core(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX4Insert_Core(Vector<double> back, Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<double> vector3, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) {
                return WStatics.YShuffleX4Insert_Core(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX4Insert_Core(Vector<sbyte> back, Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> vector3, Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4) {
                return WStatics.YShuffleX4Insert_Core(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX4Insert_Core(Vector<byte> back, Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> vector3, Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4) {
                return WStatics.YShuffleX4Insert_Core(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX4Insert_Core(Vector<short> back, Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> vector3, Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4) {
                return WStatics.YShuffleX4Insert_Core(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX4Insert_Core(Vector<ushort> back, Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> vector3, Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4) {
                return WStatics.YShuffleX4Insert_Core(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX4Insert_Core(Vector<int> back, Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> vector3, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) {
                return WStatics.YShuffleX4Insert_Core(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX4Insert_Core(Vector<uint> back, Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> vector3, Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4) {
                return WStatics.YShuffleX4Insert_Core(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX4Insert_Core(Vector<long> back, Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> vector3, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) {
                return WStatics.YShuffleX4Insert_Core(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX4Insert_Core(Vector<ulong> back, Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> vector3, Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4) {
                return WStatics.YShuffleX4Insert_Core(back.AsVector128(), vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128(), args4.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX4Kernel_AcceleratedTypes {
                get {
                    return WStatics.YShuffleX4Kernel_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX4Kernel(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<float> vector3, Vector<int> indices) {
                return WStatics.YShuffleX4Kernel(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX4Kernel(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<double> vector3, Vector<long> indices) {
                return WStatics.YShuffleX4Kernel(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX4Kernel(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> vector3, Vector<sbyte> indices) {
                return WStatics.YShuffleX4Kernel(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX4Kernel(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> vector3, Vector<byte> indices) {
                return WStatics.YShuffleX4Kernel(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX4Kernel(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> vector3, Vector<short> indices) {
                return WStatics.YShuffleX4Kernel(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX4Kernel(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> vector3, Vector<ushort> indices) {
                return WStatics.YShuffleX4Kernel(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX4Kernel(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> vector3, Vector<int> indices) {
                return WStatics.YShuffleX4Kernel(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX4Kernel(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> vector3, Vector<uint> indices) {
                return WStatics.YShuffleX4Kernel(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX4Kernel(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> vector3, Vector<long> indices) {
                return WStatics.YShuffleX4Kernel(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX4Kernel(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> vector3, Vector<ulong> indices) {
                return WStatics.YShuffleX4Kernel(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2, out Vector<sbyte> args3) {
                WStatics.YShuffleX4Kernel_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2, out Vector<byte> args3) {
                WStatics.YShuffleX4Kernel_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2, out Vector<short> args3) {
                WStatics.YShuffleX4Kernel_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2, out Vector<ushort> args3) {
                WStatics.YShuffleX4Kernel_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2, out Vector<int> args3) {
                WStatics.YShuffleX4Kernel_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2, out Vector<uint> args3) {
                WStatics.YShuffleX4Kernel_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2, out Vector<long> args3) {
                WStatics.YShuffleX4Kernel_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2, out Vector<ulong> args3) {
                WStatics.YShuffleX4Kernel_Args(indices.AsVector128(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
                args3 = a3.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX4Kernel_Core(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<float> vector3, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3) {
                return WStatics.YShuffleX4Kernel_Core(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Core(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX4Kernel_Core(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<double> vector3, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3) {
                return WStatics.YShuffleX4Kernel_Core(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX4Kernel_Core(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> vector3, Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3) {
                return WStatics.YShuffleX4Kernel_Core(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX4Kernel_Core(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> vector3, Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3) {
                return WStatics.YShuffleX4Kernel_Core(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX4Kernel_Core(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> vector3, Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3) {
                return WStatics.YShuffleX4Kernel_Core(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX4Kernel_Core(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> vector3, Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3) {
                return WStatics.YShuffleX4Kernel_Core(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX4Kernel_Core(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> vector3, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3) {
                return WStatics.YShuffleX4Kernel_Core(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX4Kernel_Core(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> vector3, Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3) {
                return WStatics.YShuffleX4Kernel_Core(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX4Kernel_Core(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> vector3, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3) {
                return WStatics.YShuffleX4Kernel_Core(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX4Kernel_Core(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> vector3, Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3) {
                return WStatics.YShuffleX4Kernel_Core(vector0.AsVector128(), vector1.AsVector128(), vector2.AsVector128(), vector3.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128(), args3.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YSign_AcceleratedTypes"/>
            public static TypeCodeFlags YSign_AcceleratedTypes {
                get {
                    return WStatics.YSign_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YSign(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YSign(Vector<float> value) {
                return WStatics.YSign(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YSign(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YSign(Vector<double> value) {
                return WStatics.YSign(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YSign(Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YSign(Vector<sbyte> value) {
                return WStatics.YSign(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YSign(Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YSign(Vector<short> value) {
                return WStatics.YSign(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YSign(Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YSign(Vector<int> value) {
                return WStatics.YSign(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YSign(Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YSign(Vector<long> value) {
                return WStatics.YSign(value.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YSignFloat_AcceleratedTypes"/>
            public static TypeCodeFlags YSignFloat_AcceleratedTypes {
                get {
                    return WStatics.YSignFloat_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YSignFloat(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YSignFloat(Vector<float> value) {
                return WStatics.YSignFloat(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YSignFloat(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YSignFloat(Vector<double> value) {
                return WStatics.YSignFloat(value.AsVector128()).AsVector();
            }

        }
#endif // NETCOREAPP3_0_OR_GREATER
    }
}
