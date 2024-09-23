using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using System.Text;
using Zyl.VectorTraits.ExTypes;
using Zyl.VectorTraits.Extensions;
using Zyl.VectorTraits.Extensions.SameW;
using Zyl.VectorTraits.Impl.AVector128;

namespace Zyl.VectorTraits.Impl.AVector {
    using WStatics = WVectorTraits128Base.Statics;
    using BaseStatics = VectorTraitsBase.Statics;

    partial class VectorTraits128Base {

        partial class Statics {
#if NETCOREAPP3_0_OR_GREATER

            /// <inheritdoc cref="IVectorTraits.YGroup1ToGroup3_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup1ToGroup3_AcceleratedTypes {
                get {
                    return WStatics.YGroup1ToGroup3_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YGroup1ToGroup3(Vector{float}, out Vector{float}, out Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup1ToGroup3(Vector<float> x, out Vector<float> result1, out Vector<float> result2) {
                var a0 = WStatics.YGroup1ToGroup3(x.AsVector128(), out var a1, out var a2);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup1ToGroup3(Vector{double}, out Vector{double}, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup1ToGroup3(Vector<double> x, out Vector<double> result1, out Vector<double> result2) {
                var a0 = WStatics.YGroup1ToGroup3(x.AsVector128(), out var a1, out var a2);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup1ToGroup3(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup1ToGroup3(Vector<sbyte> x, out Vector<sbyte> result1, out Vector<sbyte> result2) {
                var a0 = WStatics.YGroup1ToGroup3(x.AsVector128(), out var a1, out var a2);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup1ToGroup3(Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup1ToGroup3(Vector<byte> x, out Vector<byte> result1, out Vector<byte> result2) {
                var a0 = WStatics.YGroup1ToGroup3(x.AsVector128(), out var a1, out var a2);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup1ToGroup3(Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup1ToGroup3(Vector<short> x, out Vector<short> result1, out Vector<short> result2) {
                var a0 = WStatics.YGroup1ToGroup3(x.AsVector128(), out var a1, out var a2);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup1ToGroup3(Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup1ToGroup3(Vector<ushort> x, out Vector<ushort> result1, out Vector<ushort> result2) {
                var a0 = WStatics.YGroup1ToGroup3(x.AsVector128(), out var a1, out var a2);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup1ToGroup3(Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup1ToGroup3(Vector<int> x, out Vector<int> result1, out Vector<int> result2) {
                var a0 = WStatics.YGroup1ToGroup3(x.AsVector128(), out var a1, out var a2);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup1ToGroup3(Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup1ToGroup3(Vector<uint> x, out Vector<uint> result1, out Vector<uint> result2) {
                var a0 = WStatics.YGroup1ToGroup3(x.AsVector128(), out var a1, out var a2);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup1ToGroup3(Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup1ToGroup3(Vector<long> x, out Vector<long> result1, out Vector<long> result2) {
                var a0 = WStatics.YGroup1ToGroup3(x.AsVector128(), out var a1, out var a2);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup1ToGroup3(Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup1ToGroup3(Vector<ulong> x, out Vector<ulong> result1, out Vector<ulong> result2) {
                var a0 = WStatics.YGroup1ToGroup3(x.AsVector128(), out var a1, out var a2);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                return a0.AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YGroup1ToGroup4_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup1ToGroup4_AcceleratedTypes {
                get {
                    return WStatics.YGroup1ToGroup4_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YGroup1ToGroup4(Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup1ToGroup4(Vector<float> x, out Vector<float> result1, out Vector<float> result2, out Vector<float> result3) {
                var a0 = WStatics.YGroup1ToGroup4(x.AsVector128(), out var a1, out var a2, out var a3);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                result3 = a3.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup1ToGroup4(Vector{double}, out Vector{double}, out Vector{double}, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup1ToGroup4(Vector<double> x, out Vector<double> result1, out Vector<double> result2, out Vector<double> result3) {
                var a0 = WStatics.YGroup1ToGroup4(x.AsVector128(), out var a1, out var a2, out var a3);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                result3 = a3.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup1ToGroup4(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup1ToGroup4(Vector<sbyte> x, out Vector<sbyte> result1, out Vector<sbyte> result2, out Vector<sbyte> result3) {
                var a0 = WStatics.YGroup1ToGroup4(x.AsVector128(), out var a1, out var a2, out var a3);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                result3 = a3.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup1ToGroup4(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup1ToGroup4(Vector<byte> x, out Vector<byte> result1, out Vector<byte> result2, out Vector<byte> result3) {
                var a0 = WStatics.YGroup1ToGroup4(x.AsVector128(), out var a1, out var a2, out var a3);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                result3 = a3.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup1ToGroup4(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup1ToGroup4(Vector<short> x, out Vector<short> result1, out Vector<short> result2, out Vector<short> result3) {
                var a0 = WStatics.YGroup1ToGroup4(x.AsVector128(), out var a1, out var a2, out var a3);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                result3 = a3.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup1ToGroup4(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup1ToGroup4(Vector<ushort> x, out Vector<ushort> result1, out Vector<ushort> result2, out Vector<ushort> result3) {
                var a0 = WStatics.YGroup1ToGroup4(x.AsVector128(), out var a1, out var a2, out var a3);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                result3 = a3.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup1ToGroup4(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup1ToGroup4(Vector<int> x, out Vector<int> result1, out Vector<int> result2, out Vector<int> result3) {
                var a0 = WStatics.YGroup1ToGroup4(x.AsVector128(), out var a1, out var a2, out var a3);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                result3 = a3.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup1ToGroup4(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup1ToGroup4(Vector<uint> x, out Vector<uint> result1, out Vector<uint> result2, out Vector<uint> result3) {
                var a0 = WStatics.YGroup1ToGroup4(x.AsVector128(), out var a1, out var a2, out var a3);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                result3 = a3.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup1ToGroup4(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup1ToGroup4(Vector<long> x, out Vector<long> result1, out Vector<long> result2, out Vector<long> result3) {
                var a0 = WStatics.YGroup1ToGroup4(x.AsVector128(), out var a1, out var a2, out var a3);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                result3 = a3.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup1ToGroup4(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup1ToGroup4(Vector<ulong> x, out Vector<ulong> result1, out Vector<ulong> result2, out Vector<ulong> result3) {
                var a0 = WStatics.YGroup1ToGroup4(x.AsVector128(), out var a1, out var a2, out var a3);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                result3 = a3.AsVector();
                return a0.AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YGroup1ToGroup4WithW_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup1ToGroup4WithW_AcceleratedTypes {
                get {
                    return WStatics.YGroup1ToGroup4WithW_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YGroup1ToGroup4WithW(Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup1ToGroup4WithW(Vector<float> x, Vector<float> w, out Vector<float> result1, out Vector<float> result2, out Vector<float> result3) {
                var a0 = WStatics.YGroup1ToGroup4WithW(x.AsVector128(), w.AsVector128(), out var a1, out var a2, out var a3);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                result3 = a3.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup1ToGroup4WithW(Vector{double}, Vector{double}, out Vector{double}, out Vector{double}, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup1ToGroup4WithW(Vector<double> x, Vector<double> w, out Vector<double> result1, out Vector<double> result2, out Vector<double> result3) {
                var a0 = WStatics.YGroup1ToGroup4WithW(x.AsVector128(), w.AsVector128(), out var a1, out var a2, out var a3);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                result3 = a3.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup1ToGroup4WithW(Vector{sbyte}, Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup1ToGroup4WithW(Vector<sbyte> x, Vector<sbyte> w, out Vector<sbyte> result1, out Vector<sbyte> result2, out Vector<sbyte> result3) {
                var a0 = WStatics.YGroup1ToGroup4WithW(x.AsVector128(), w.AsVector128(), out var a1, out var a2, out var a3);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                result3 = a3.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup1ToGroup4WithW(Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup1ToGroup4WithW(Vector<byte> x, Vector<byte> w, out Vector<byte> result1, out Vector<byte> result2, out Vector<byte> result3) {
                var a0 = WStatics.YGroup1ToGroup4WithW(x.AsVector128(), w.AsVector128(), out var a1, out var a2, out var a3);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                result3 = a3.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup1ToGroup4WithW(Vector{short}, Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup1ToGroup4WithW(Vector<short> x, Vector<short> w, out Vector<short> result1, out Vector<short> result2, out Vector<short> result3) {
                var a0 = WStatics.YGroup1ToGroup4WithW(x.AsVector128(), w.AsVector128(), out var a1, out var a2, out var a3);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                result3 = a3.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup1ToGroup4WithW(Vector{ushort}, Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup1ToGroup4WithW(Vector<ushort> x, Vector<ushort> w, out Vector<ushort> result1, out Vector<ushort> result2, out Vector<ushort> result3) {
                var a0 = WStatics.YGroup1ToGroup4WithW(x.AsVector128(), w.AsVector128(), out var a1, out var a2, out var a3);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                result3 = a3.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup1ToGroup4WithW(Vector{int}, Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup1ToGroup4WithW(Vector<int> x, Vector<int> w, out Vector<int> result1, out Vector<int> result2, out Vector<int> result3) {
                var a0 = WStatics.YGroup1ToGroup4WithW(x.AsVector128(), w.AsVector128(), out var a1, out var a2, out var a3);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                result3 = a3.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup1ToGroup4WithW(Vector{uint}, Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup1ToGroup4WithW(Vector<uint> x, Vector<uint> w, out Vector<uint> result1, out Vector<uint> result2, out Vector<uint> result3) {
                var a0 = WStatics.YGroup1ToGroup4WithW(x.AsVector128(), w.AsVector128(), out var a1, out var a2, out var a3);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                result3 = a3.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup1ToGroup4WithW(Vector{long}, Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup1ToGroup4WithW(Vector<long> x, Vector<long> w, out Vector<long> result1, out Vector<long> result2, out Vector<long> result3) {
                var a0 = WStatics.YGroup1ToGroup4WithW(x.AsVector128(), w.AsVector128(), out var a1, out var a2, out var a3);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                result3 = a3.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup1ToGroup4WithW(Vector{ulong}, Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup1ToGroup4WithW(Vector<ulong> x, Vector<ulong> w, out Vector<ulong> result1, out Vector<ulong> result2, out Vector<ulong> result3) {
                var a0 = WStatics.YGroup1ToGroup4WithW(x.AsVector128(), w.AsVector128(), out var a1, out var a2, out var a3);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                result3 = a3.AsVector();
                return a0.AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2Unzip_AcceleratedTypes {
                get {
                    return WStatics.YGroup2Unzip_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{double}, Vector{double}, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup2Unzip(Vector<double> data0, Vector<double> data1, out Vector<double> y) {
                var a0 = WStatics.YGroup2Unzip(data0.AsVector128(), data1.AsVector128(), out var a1);
                y = a1.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{long}, Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup2Unzip(Vector<long> data0, Vector<long> data1, out Vector<long> y) {
                var a0 = WStatics.YGroup2Unzip(data0.AsVector128(), data1.AsVector128(), out var a1);
                y = a1.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{ulong}, Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup2Unzip(Vector<ulong> data0, Vector<ulong> data1, out Vector<ulong> y) {
                var a0 = WStatics.YGroup2Unzip(data0.AsVector128(), data1.AsVector128(), out var a1);
                y = a1.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{ExInt128}, Vector{ExInt128}, out Vector{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExInt128> YGroup2Unzip(Vector<ExInt128> data0, Vector<ExInt128> data1, out Vector<ExInt128> y) {
                var a0 = WStatics.YGroup2Unzip(data0.ExAsVector128(), data1.ExAsVector128(), out var a1);
                y = a1.ExAsVector();
                return a0.ExAsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{ExUInt128}, Vector{ExUInt128}, out Vector{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExUInt128> YGroup2Unzip(Vector<ExUInt128> data0, Vector<ExUInt128> data1, out Vector<ExUInt128> y) {
                var a0 = WStatics.YGroup2Unzip(data0.ExAsVector128(), data1.ExAsVector128(), out var a1);
                y = a1.ExAsVector();
                return a0.ExAsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip_Bit128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<T> YGroup2Unzip_Bit128<T>(Vector<T> data0, Vector<T> data1, out Vector<T> y) where T : struct {
#if EX_APPLY_GENERIC
                var a0 = WStatics.YGroup2Unzip_Bit128(data0.ExAsVector128(), data1.ExAsVector128(), out var a1);
                y = a1.ExAsVector();
                return a0.ExAsVector();
#else
                var a0 = WStatics.YGroup2Unzip_Bit128(data0.AsVector128(), data1.AsVector128(), out var a1);
                y = a1.AsVector();
                return a0.AsVector();
#endif // EX_APPLY_GENERIC
            }


            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2UnzipEven_AcceleratedTypes {
                get {
                    return WStatics.YGroup2UnzipEven_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{double}, Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup2UnzipEven(Vector<double> data0, Vector<double> data1) {
                return WStatics.YGroup2UnzipEven(data0.AsVector128(), data1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup2UnzipEven(Vector<long> data0, Vector<long> data1) {
                return WStatics.YGroup2UnzipEven(data0.AsVector128(), data1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup2UnzipEven(Vector<ulong> data0, Vector<ulong> data1) {
                return WStatics.YGroup2UnzipEven(data0.AsVector128(), data1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{ExInt128}, Vector{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExInt128> YGroup2UnzipEven(Vector<ExInt128> data0, Vector<ExInt128> data1) {
                return WStatics.YGroup2UnzipEven(data0.ExAsVector128(), data1.ExAsVector128()).ExAsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipEven(Vector{ExUInt128}, Vector{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExUInt128> YGroup2UnzipEven(Vector<ExUInt128> data0, Vector<ExUInt128> data1) {
                return WStatics.YGroup2UnzipEven(data0.ExAsVector128(), data1.ExAsVector128()).ExAsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2UnzipOdd_AcceleratedTypes {
                get {
                    return WStatics.YGroup2UnzipOdd_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{double}, Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup2UnzipOdd(Vector<double> data0, Vector<double> data1) {
                return WStatics.YGroup2UnzipOdd(data0.AsVector128(), data1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup2UnzipOdd(Vector<long> data0, Vector<long> data1) {
                return WStatics.YGroup2UnzipOdd(data0.AsVector128(), data1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup2UnzipOdd(Vector<ulong> data0, Vector<ulong> data1) {
                return WStatics.YGroup2UnzipOdd(data0.AsVector128(), data1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{ExInt128}, Vector{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExInt128> YGroup2UnzipOdd(Vector<ExInt128> data0, Vector<ExInt128> data1) {
                return WStatics.YGroup2UnzipOdd(data0.ExAsVector128(), data1.ExAsVector128()).ExAsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2UnzipOdd(Vector{ExUInt128}, Vector{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExUInt128> YGroup2UnzipOdd(Vector<ExUInt128> data0, Vector<ExUInt128> data1) {
                return WStatics.YGroup2UnzipOdd(data0.ExAsVector128(), data1.ExAsVector128()).ExAsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YGroup2Zip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2Zip_AcceleratedTypes {
                get {
                    return WStatics.YGroup2Zip_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{double}, Vector{double}, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup2Zip(Vector<double> x, Vector<double> y, out Vector<double> data1) {
                var a0 = WStatics.YGroup2Zip(x.AsVector128(), y.AsVector128(), out var a1);
                data1 = a1.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{long}, Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup2Zip(Vector<long> x, Vector<long> y, out Vector<long> data1) {
                var a0 = WStatics.YGroup2Zip(x.AsVector128(), y.AsVector128(), out var a1);
                data1 = a1.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{ulong}, Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup2Zip(Vector<ulong> x, Vector<ulong> y, out Vector<ulong> data1) {
                var a0 = WStatics.YGroup2Zip(x.AsVector128(), y.AsVector128(), out var a1);
                data1 = a1.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{ExInt128}, Vector{ExInt128}, out Vector{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExInt128> YGroup2Zip(Vector<ExInt128> x, Vector<ExInt128> y, out Vector<ExInt128> data1) {
                var a0 = WStatics.YGroup2Zip(x.ExAsVector128(), y.ExAsVector128(), out var a1);
                data1 = a1.ExAsVector();
                return a0.ExAsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Zip(Vector{ExUInt128}, Vector{ExUInt128}, out Vector{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExUInt128> YGroup2Zip(Vector<ExUInt128> x, Vector<ExUInt128> y, out Vector<ExUInt128> data1) {
                var a0 = WStatics.YGroup2Zip(x.ExAsVector128(), y.ExAsVector128(), out var a1);
                data1 = a1.ExAsVector();
                return a0.ExAsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2Zip_Bit128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<T> YGroup2Zip_Bit128<T>(Vector<T> x, Vector<T> y, out Vector<T> data1) where T : struct {
#if EX_APPLY_GENERIC
                var a0 = WStatics.YGroup2Zip_Bit128(x.ExAsVector128(), y.ExAsVector128(), out var a1);
                data1 = a1.ExAsVector();
                return a0.ExAsVector();
#else
                var a0 = WStatics.YGroup2Zip_Bit128(x.AsVector128(), y.AsVector128(), out var a1);
                data1 = a1.AsVector();
                return a0.AsVector();
#endif // EX_APPLY_GENERIC
            }


            /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2ZipHigh_AcceleratedTypes {
                get {
                    return WStatics.YGroup2ZipHigh_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{double}, Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup2ZipHigh(Vector<double> x, Vector<double> y) {
                return WStatics.YGroup2ZipHigh(x.AsVector128(), y.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup2ZipHigh(Vector<long> x, Vector<long> y) {
                return WStatics.YGroup2ZipHigh(x.AsVector128(), y.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup2ZipHigh(Vector<ulong> x, Vector<ulong> y) {
                return WStatics.YGroup2ZipHigh(x.AsVector128(), y.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{ExInt128}, Vector{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExInt128> YGroup2ZipHigh(Vector<ExInt128> x, Vector<ExInt128> y) {
                return WStatics.YGroup2ZipHigh(x.ExAsVector128(), y.ExAsVector128()).ExAsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{ExUInt128}, Vector{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExUInt128> YGroup2ZipHigh(Vector<ExUInt128> x, Vector<ExUInt128> y) {
                return WStatics.YGroup2ZipHigh(x.ExAsVector128(), y.ExAsVector128()).ExAsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2ZipLow_AcceleratedTypes {
                get {
                    return WStatics.YGroup2ZipLow_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{double}, Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup2ZipLow(Vector<double> x, Vector<double> y) {
                return WStatics.YGroup2ZipLow(x.AsVector128(), y.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup2ZipLow(Vector<long> x, Vector<long> y) {
                return WStatics.YGroup2ZipLow(x.AsVector128(), y.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup2ZipLow(Vector<ulong> x, Vector<ulong> y) {
                return WStatics.YGroup2ZipLow(x.AsVector128(), y.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{ExInt128}, Vector{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExInt128> YGroup2ZipLow(Vector<ExInt128> x, Vector<ExInt128> y) {
                return WStatics.YGroup2ZipLow(x.ExAsVector128(), y.ExAsVector128()).ExAsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{ExUInt128}, Vector{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExUInt128> YGroup2ZipLow(Vector<ExUInt128> x, Vector<ExUInt128> y) {
                return WStatics.YGroup2ZipLow(x.ExAsVector128(), y.ExAsVector128()).ExAsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YGroup3ToGroup4_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup3ToGroup4_AcceleratedTypes {
                get {
                    return WStatics.YGroup3ToGroup4_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ToGroup4(Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup3ToGroup4(Vector<float> data0, Vector<float> data1, Vector<float> data2, out Vector<float> result1, out Vector<float> result2, out Vector<float> result3) {
                var a0 = WStatics.YGroup3ToGroup4(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), out var a1, out var a2, out var a3);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                result3 = a3.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ToGroup4(Vector{double}, Vector{double}, Vector{double}, out Vector{double}, out Vector{double}, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup3ToGroup4(Vector<double> data0, Vector<double> data1, Vector<double> data2, out Vector<double> result1, out Vector<double> result2, out Vector<double> result3) {
                var a0 = WStatics.YGroup3ToGroup4(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), out var a1, out var a2, out var a3);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                result3 = a3.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ToGroup4(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup3ToGroup4(Vector<sbyte> data0, Vector<sbyte> data1, Vector<sbyte> data2, out Vector<sbyte> result1, out Vector<sbyte> result2, out Vector<sbyte> result3) {
                var a0 = WStatics.YGroup3ToGroup4(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), out var a1, out var a2, out var a3);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                result3 = a3.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ToGroup4(Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup3ToGroup4(Vector<byte> data0, Vector<byte> data1, Vector<byte> data2, out Vector<byte> result1, out Vector<byte> result2, out Vector<byte> result3) {
                var a0 = WStatics.YGroup3ToGroup4(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), out var a1, out var a2, out var a3);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                result3 = a3.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ToGroup4(Vector{short}, Vector{short}, Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup3ToGroup4(Vector<short> data0, Vector<short> data1, Vector<short> data2, out Vector<short> result1, out Vector<short> result2, out Vector<short> result3) {
                var a0 = WStatics.YGroup3ToGroup4(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), out var a1, out var a2, out var a3);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                result3 = a3.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ToGroup4(Vector{ushort}, Vector{ushort}, Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup3ToGroup4(Vector<ushort> data0, Vector<ushort> data1, Vector<ushort> data2, out Vector<ushort> result1, out Vector<ushort> result2, out Vector<ushort> result3) {
                var a0 = WStatics.YGroup3ToGroup4(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), out var a1, out var a2, out var a3);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                result3 = a3.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ToGroup4(Vector{int}, Vector{int}, Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup3ToGroup4(Vector<int> data0, Vector<int> data1, Vector<int> data2, out Vector<int> result1, out Vector<int> result2, out Vector<int> result3) {
                var a0 = WStatics.YGroup3ToGroup4(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), out var a1, out var a2, out var a3);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                result3 = a3.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ToGroup4(Vector{uint}, Vector{uint}, Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup3ToGroup4(Vector<uint> data0, Vector<uint> data1, Vector<uint> data2, out Vector<uint> result1, out Vector<uint> result2, out Vector<uint> result3) {
                var a0 = WStatics.YGroup3ToGroup4(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), out var a1, out var a2, out var a3);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                result3 = a3.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ToGroup4(Vector{long}, Vector{long}, Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup3ToGroup4(Vector<long> data0, Vector<long> data1, Vector<long> data2, out Vector<long> result1, out Vector<long> result2, out Vector<long> result3) {
                var a0 = WStatics.YGroup3ToGroup4(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), out var a1, out var a2, out var a3);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                result3 = a3.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ToGroup4(Vector{ulong}, Vector{ulong}, Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup3ToGroup4(Vector<ulong> data0, Vector<ulong> data1, Vector<ulong> data2, out Vector<ulong> result1, out Vector<ulong> result2, out Vector<ulong> result3) {
                var a0 = WStatics.YGroup3ToGroup4(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), out var a1, out var a2, out var a3);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                result3 = a3.AsVector();
                return a0.AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup3Unzip_AcceleratedTypes {
                get {
                    return WStatics.YGroup3Unzip_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup3Unzip(Vector<float> data0, Vector<float> data1, Vector<float> data2, out Vector<float> y, out Vector<float> z) {
                var a0 = WStatics.YGroup3Unzip(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), out var a1, out var a2);
                y = a1.AsVector();
                z = a2.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{double}, Vector{double}, Vector{double}, out Vector{double}, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup3Unzip(Vector<double> data0, Vector<double> data1, Vector<double> data2, out Vector<double> y, out Vector<double> z) {
                var a0 = WStatics.YGroup3Unzip(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), out var a1, out var a2);
                y = a1.AsVector();
                z = a2.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup3Unzip(Vector<sbyte> data0, Vector<sbyte> data1, Vector<sbyte> data2, out Vector<sbyte> y, out Vector<sbyte> z) {
                var a0 = WStatics.YGroup3Unzip(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), out var a1, out var a2);
                y = a1.AsVector();
                z = a2.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup3Unzip(Vector<byte> data0, Vector<byte> data1, Vector<byte> data2, out Vector<byte> y, out Vector<byte> z) {
                var a0 = WStatics.YGroup3Unzip(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), out var a1, out var a2);
                y = a1.AsVector();
                z = a2.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{short}, Vector{short}, Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup3Unzip(Vector<short> data0, Vector<short> data1, Vector<short> data2, out Vector<short> y, out Vector<short> z) {
                var a0 = WStatics.YGroup3Unzip(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), out var a1, out var a2);
                y = a1.AsVector();
                z = a2.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{ushort}, Vector{ushort}, Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup3Unzip(Vector<ushort> data0, Vector<ushort> data1, Vector<ushort> data2, out Vector<ushort> y, out Vector<ushort> z) {
                var a0 = WStatics.YGroup3Unzip(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), out var a1, out var a2);
                y = a1.AsVector();
                z = a2.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{int}, Vector{int}, Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup3Unzip(Vector<int> data0, Vector<int> data1, Vector<int> data2, out Vector<int> y, out Vector<int> z) {
                var a0 = WStatics.YGroup3Unzip(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), out var a1, out var a2);
                y = a1.AsVector();
                z = a2.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{uint}, Vector{uint}, Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup3Unzip(Vector<uint> data0, Vector<uint> data1, Vector<uint> data2, out Vector<uint> y, out Vector<uint> z) {
                var a0 = WStatics.YGroup3Unzip(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), out var a1, out var a2);
                y = a1.AsVector();
                z = a2.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{long}, Vector{long}, Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup3Unzip(Vector<long> data0, Vector<long> data1, Vector<long> data2, out Vector<long> y, out Vector<long> z) {
                var a0 = WStatics.YGroup3Unzip(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), out var a1, out var a2);
                y = a1.AsVector();
                z = a2.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip(Vector{ulong}, Vector{ulong}, Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup3Unzip(Vector<ulong> data0, Vector<ulong> data1, Vector<ulong> data2, out Vector<ulong> y, out Vector<ulong> z) {
                var a0 = WStatics.YGroup3Unzip(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), out var a1, out var a2);
                y = a1.AsVector();
                z = a2.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Unzip_Bit128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<T> YGroup3Unzip_Bit128<T>(Vector<T> data0, Vector<T> data1, Vector<T> data2, out Vector<T> y, out Vector<T> z) where T : struct {
                var a0 = WStatics.YGroup3Unzip_Bit128(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), out var a1, out var a2);
                y = a1.AsVector();
                z = a2.AsVector();
                return a0.AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup3UnzipX2_AcceleratedTypes {
                get {
                    return WStatics.YGroup3UnzipX2_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup3UnzipX2(Vector<float> data0, Vector<float> data1, Vector<float> data2, Vector<float> data3, Vector<float> data4, Vector<float> data5, out Vector<float> xB, out Vector<float> y, out Vector<float> yB, out Vector<float> z, out Vector<float> zB) {
                var a0 = WStatics.YGroup3UnzipX2(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), data3.AsVector128(), data4.AsVector128(), data5.AsVector128(), out var a1, out var a2, out var a3, out var a4, out var a5);
                xB = a1.AsVector();
                y = a2.AsVector();
                yB = a3.AsVector();
                z = a4.AsVector();
                zB = a5.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{double}, out Vector{double}, out Vector{double}, out Vector{double}, out Vector{double}, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup3UnzipX2(Vector<double> data0, Vector<double> data1, Vector<double> data2, Vector<double> data3, Vector<double> data4, Vector<double> data5, out Vector<double> xB, out Vector<double> y, out Vector<double> yB, out Vector<double> z, out Vector<double> zB) {
                var a0 = WStatics.YGroup3UnzipX2(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), data3.AsVector128(), data4.AsVector128(), data5.AsVector128(), out var a1, out var a2, out var a3, out var a4, out var a5);
                xB = a1.AsVector();
                y = a2.AsVector();
                yB = a3.AsVector();
                z = a4.AsVector();
                zB = a5.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup3UnzipX2(Vector<sbyte> data0, Vector<sbyte> data1, Vector<sbyte> data2, Vector<sbyte> data3, Vector<sbyte> data4, Vector<sbyte> data5, out Vector<sbyte> xB, out Vector<sbyte> y, out Vector<sbyte> yB, out Vector<sbyte> z, out Vector<sbyte> zB) {
                var a0 = WStatics.YGroup3UnzipX2(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), data3.AsVector128(), data4.AsVector128(), data5.AsVector128(), out var a1, out var a2, out var a3, out var a4, out var a5);
                xB = a1.AsVector();
                y = a2.AsVector();
                yB = a3.AsVector();
                z = a4.AsVector();
                zB = a5.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup3UnzipX2(Vector<byte> data0, Vector<byte> data1, Vector<byte> data2, Vector<byte> data3, Vector<byte> data4, Vector<byte> data5, out Vector<byte> xB, out Vector<byte> y, out Vector<byte> yB, out Vector<byte> z, out Vector<byte> zB) {
                var a0 = WStatics.YGroup3UnzipX2(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), data3.AsVector128(), data4.AsVector128(), data5.AsVector128(), out var a1, out var a2, out var a3, out var a4, out var a5);
                xB = a1.AsVector();
                y = a2.AsVector();
                yB = a3.AsVector();
                z = a4.AsVector();
                zB = a5.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup3UnzipX2(Vector<short> data0, Vector<short> data1, Vector<short> data2, Vector<short> data3, Vector<short> data4, Vector<short> data5, out Vector<short> xB, out Vector<short> y, out Vector<short> yB, out Vector<short> z, out Vector<short> zB) {
                var a0 = WStatics.YGroup3UnzipX2(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), data3.AsVector128(), data4.AsVector128(), data5.AsVector128(), out var a1, out var a2, out var a3, out var a4, out var a5);
                xB = a1.AsVector();
                y = a2.AsVector();
                yB = a3.AsVector();
                z = a4.AsVector();
                zB = a5.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup3UnzipX2(Vector<ushort> data0, Vector<ushort> data1, Vector<ushort> data2, Vector<ushort> data3, Vector<ushort> data4, Vector<ushort> data5, out Vector<ushort> xB, out Vector<ushort> y, out Vector<ushort> yB, out Vector<ushort> z, out Vector<ushort> zB) {
                var a0 = WStatics.YGroup3UnzipX2(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), data3.AsVector128(), data4.AsVector128(), data5.AsVector128(), out var a1, out var a2, out var a3, out var a4, out var a5);
                xB = a1.AsVector();
                y = a2.AsVector();
                yB = a3.AsVector();
                z = a4.AsVector();
                zB = a5.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup3UnzipX2(Vector<int> data0, Vector<int> data1, Vector<int> data2, Vector<int> data3, Vector<int> data4, Vector<int> data5, out Vector<int> xB, out Vector<int> y, out Vector<int> yB, out Vector<int> z, out Vector<int> zB) {
                var a0 = WStatics.YGroup3UnzipX2(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), data3.AsVector128(), data4.AsVector128(), data5.AsVector128(), out var a1, out var a2, out var a3, out var a4, out var a5);
                xB = a1.AsVector();
                y = a2.AsVector();
                yB = a3.AsVector();
                z = a4.AsVector();
                zB = a5.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup3UnzipX2(Vector<uint> data0, Vector<uint> data1, Vector<uint> data2, Vector<uint> data3, Vector<uint> data4, Vector<uint> data5, out Vector<uint> xB, out Vector<uint> y, out Vector<uint> yB, out Vector<uint> z, out Vector<uint> zB) {
                var a0 = WStatics.YGroup3UnzipX2(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), data3.AsVector128(), data4.AsVector128(), data5.AsVector128(), out var a1, out var a2, out var a3, out var a4, out var a5);
                xB = a1.AsVector();
                y = a2.AsVector();
                yB = a3.AsVector();
                z = a4.AsVector();
                zB = a5.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup3UnzipX2(Vector<long> data0, Vector<long> data1, Vector<long> data2, Vector<long> data3, Vector<long> data4, Vector<long> data5, out Vector<long> xB, out Vector<long> y, out Vector<long> yB, out Vector<long> z, out Vector<long> zB) {
                var a0 = WStatics.YGroup3UnzipX2(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), data3.AsVector128(), data4.AsVector128(), data5.AsVector128(), out var a1, out var a2, out var a3, out var a4, out var a5);
                xB = a1.AsVector();
                y = a2.AsVector();
                yB = a3.AsVector();
                z = a4.AsVector();
                zB = a5.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup3UnzipX2(Vector<ulong> data0, Vector<ulong> data1, Vector<ulong> data2, Vector<ulong> data3, Vector<ulong> data4, Vector<ulong> data5, out Vector<ulong> xB, out Vector<ulong> y, out Vector<ulong> yB, out Vector<ulong> z, out Vector<ulong> zB) {
                var a0 = WStatics.YGroup3UnzipX2(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), data3.AsVector128(), data4.AsVector128(), data5.AsVector128(), out var a1, out var a2, out var a3, out var a4, out var a5);
                xB = a1.AsVector();
                y = a2.AsVector();
                yB = a3.AsVector();
                z = a4.AsVector();
                zB = a5.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3UnzipX2_Bit128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<T> YGroup3UnzipX2_Bit128<T>(Vector<T> data0, Vector<T> data1, Vector<T> data2, Vector<T> data3, Vector<T> data4, Vector<T> data5, out Vector<T> xB, out Vector<T> y, out Vector<T> yB, out Vector<T> z, out Vector<T> zB) where T : struct {
                var a0 = WStatics.YGroup3UnzipX2_Bit128(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), data3.AsVector128(), data4.AsVector128(), data5.AsVector128(), out var a1, out var a2, out var a3, out var a4, out var a5);
                xB = a1.AsVector();
                y = a2.AsVector();
                yB = a3.AsVector();
                z = a4.AsVector();
                zB = a5.AsVector();
                return a0.AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YGroup3Zip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup3Zip_AcceleratedTypes {
                get {
                    return WStatics.YGroup3Zip_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup3Zip(Vector<float> x, Vector<float> y, Vector<float> z, out Vector<float> data1, out Vector<float> data2) {
                var a0 = WStatics.YGroup3Zip(x.AsVector128(), y.AsVector128(), z.AsVector128(), out var a1, out var a2);
                data1 = a1.AsVector();
                data2 = a2.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{double}, Vector{double}, Vector{double}, out Vector{double}, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup3Zip(Vector<double> x, Vector<double> y, Vector<double> z, out Vector<double> data1, out Vector<double> data2) {
                var a0 = WStatics.YGroup3Zip(x.AsVector128(), y.AsVector128(), z.AsVector128(), out var a1, out var a2);
                data1 = a1.AsVector();
                data2 = a2.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup3Zip(Vector<sbyte> x, Vector<sbyte> y, Vector<sbyte> z, out Vector<sbyte> data1, out Vector<sbyte> data2) {
                var a0 = WStatics.YGroup3Zip(x.AsVector128(), y.AsVector128(), z.AsVector128(), out var a1, out var a2);
                data1 = a1.AsVector();
                data2 = a2.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup3Zip(Vector<byte> x, Vector<byte> y, Vector<byte> z, out Vector<byte> data1, out Vector<byte> data2) {
                var a0 = WStatics.YGroup3Zip(x.AsVector128(), y.AsVector128(), z.AsVector128(), out var a1, out var a2);
                data1 = a1.AsVector();
                data2 = a2.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{short}, Vector{short}, Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup3Zip(Vector<short> x, Vector<short> y, Vector<short> z, out Vector<short> data1, out Vector<short> data2) {
                var a0 = WStatics.YGroup3Zip(x.AsVector128(), y.AsVector128(), z.AsVector128(), out var a1, out var a2);
                data1 = a1.AsVector();
                data2 = a2.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{ushort}, Vector{ushort}, Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup3Zip(Vector<ushort> x, Vector<ushort> y, Vector<ushort> z, out Vector<ushort> data1, out Vector<ushort> data2) {
                var a0 = WStatics.YGroup3Zip(x.AsVector128(), y.AsVector128(), z.AsVector128(), out var a1, out var a2);
                data1 = a1.AsVector();
                data2 = a2.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{int}, Vector{int}, Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup3Zip(Vector<int> x, Vector<int> y, Vector<int> z, out Vector<int> data1, out Vector<int> data2) {
                var a0 = WStatics.YGroup3Zip(x.AsVector128(), y.AsVector128(), z.AsVector128(), out var a1, out var a2);
                data1 = a1.AsVector();
                data2 = a2.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{uint}, Vector{uint}, Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup3Zip(Vector<uint> x, Vector<uint> y, Vector<uint> z, out Vector<uint> data1, out Vector<uint> data2) {
                var a0 = WStatics.YGroup3Zip(x.AsVector128(), y.AsVector128(), z.AsVector128(), out var a1, out var a2);
                data1 = a1.AsVector();
                data2 = a2.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{long}, Vector{long}, Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup3Zip(Vector<long> x, Vector<long> y, Vector<long> z, out Vector<long> data1, out Vector<long> data2) {
                var a0 = WStatics.YGroup3Zip(x.AsVector128(), y.AsVector128(), z.AsVector128(), out var a1, out var a2);
                data1 = a1.AsVector();
                data2 = a2.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Zip(Vector{ulong}, Vector{ulong}, Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup3Zip(Vector<ulong> x, Vector<ulong> y, Vector<ulong> z, out Vector<ulong> data1, out Vector<ulong> data2) {
                var a0 = WStatics.YGroup3Zip(x.AsVector128(), y.AsVector128(), z.AsVector128(), out var a1, out var a2);
                data1 = a1.AsVector();
                data2 = a2.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3Zip_Bit128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<T> YGroup3Zip_Bit128<T>(Vector<T> x, Vector<T> y, Vector<T> z, out Vector<T> data1, out Vector<T> data2) where T : struct {
                var a0 = WStatics.YGroup3Zip_Bit128(x.AsVector128(), y.AsVector128(), z.AsVector128(), out var a1, out var a2);
                data1 = a1.AsVector();
                data2 = a2.AsVector();
                return a0.AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup3ZipX2_AcceleratedTypes {
                get {
                    return WStatics.YGroup3ZipX2_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float}, out Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup3ZipX2(Vector<float> x, Vector<float> xB, Vector<float> y, Vector<float> yB, Vector<float> z, Vector<float> zB, out Vector<float> data1, out Vector<float> data2, out Vector<float> data3, out Vector<float> data4, out Vector<float> data5) {
                var a0 = WStatics.YGroup3ZipX2(x.AsVector128(), xB.AsVector128(), y.AsVector128(), yB.AsVector128(), z.AsVector128(), zB.AsVector128(), out var a1, out var a2, out var a3, out var a4, out var a5);
                data1 = a1.AsVector();
                data2 = a2.AsVector();
                data3 = a3.AsVector();
                data4 = a4.AsVector();
                data5 = a5.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{double}, out Vector{double}, out Vector{double}, out Vector{double}, out Vector{double}, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup3ZipX2(Vector<double> x, Vector<double> xB, Vector<double> y, Vector<double> yB, Vector<double> z, Vector<double> zB, out Vector<double> data1, out Vector<double> data2, out Vector<double> data3, out Vector<double> data4, out Vector<double> data5) {
                var a0 = WStatics.YGroup3ZipX2(x.AsVector128(), xB.AsVector128(), y.AsVector128(), yB.AsVector128(), z.AsVector128(), zB.AsVector128(), out var a1, out var a2, out var a3, out var a4, out var a5);
                data1 = a1.AsVector();
                data2 = a2.AsVector();
                data3 = a3.AsVector();
                data4 = a4.AsVector();
                data5 = a5.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup3ZipX2(Vector<sbyte> x, Vector<sbyte> xB, Vector<sbyte> y, Vector<sbyte> yB, Vector<sbyte> z, Vector<sbyte> zB, out Vector<sbyte> data1, out Vector<sbyte> data2, out Vector<sbyte> data3, out Vector<sbyte> data4, out Vector<sbyte> data5) {
                var a0 = WStatics.YGroup3ZipX2(x.AsVector128(), xB.AsVector128(), y.AsVector128(), yB.AsVector128(), z.AsVector128(), zB.AsVector128(), out var a1, out var a2, out var a3, out var a4, out var a5);
                data1 = a1.AsVector();
                data2 = a2.AsVector();
                data3 = a3.AsVector();
                data4 = a4.AsVector();
                data5 = a5.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup3ZipX2(Vector<byte> x, Vector<byte> xB, Vector<byte> y, Vector<byte> yB, Vector<byte> z, Vector<byte> zB, out Vector<byte> data1, out Vector<byte> data2, out Vector<byte> data3, out Vector<byte> data4, out Vector<byte> data5) {
                var a0 = WStatics.YGroup3ZipX2(x.AsVector128(), xB.AsVector128(), y.AsVector128(), yB.AsVector128(), z.AsVector128(), zB.AsVector128(), out var a1, out var a2, out var a3, out var a4, out var a5);
                data1 = a1.AsVector();
                data2 = a2.AsVector();
                data3 = a3.AsVector();
                data4 = a4.AsVector();
                data5 = a5.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup3ZipX2(Vector<short> x, Vector<short> xB, Vector<short> y, Vector<short> yB, Vector<short> z, Vector<short> zB, out Vector<short> data1, out Vector<short> data2, out Vector<short> data3, out Vector<short> data4, out Vector<short> data5) {
                var a0 = WStatics.YGroup3ZipX2(x.AsVector128(), xB.AsVector128(), y.AsVector128(), yB.AsVector128(), z.AsVector128(), zB.AsVector128(), out var a1, out var a2, out var a3, out var a4, out var a5);
                data1 = a1.AsVector();
                data2 = a2.AsVector();
                data3 = a3.AsVector();
                data4 = a4.AsVector();
                data5 = a5.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup3ZipX2(Vector<ushort> x, Vector<ushort> xB, Vector<ushort> y, Vector<ushort> yB, Vector<ushort> z, Vector<ushort> zB, out Vector<ushort> data1, out Vector<ushort> data2, out Vector<ushort> data3, out Vector<ushort> data4, out Vector<ushort> data5) {
                var a0 = WStatics.YGroup3ZipX2(x.AsVector128(), xB.AsVector128(), y.AsVector128(), yB.AsVector128(), z.AsVector128(), zB.AsVector128(), out var a1, out var a2, out var a3, out var a4, out var a5);
                data1 = a1.AsVector();
                data2 = a2.AsVector();
                data3 = a3.AsVector();
                data4 = a4.AsVector();
                data5 = a5.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup3ZipX2(Vector<int> x, Vector<int> xB, Vector<int> y, Vector<int> yB, Vector<int> z, Vector<int> zB, out Vector<int> data1, out Vector<int> data2, out Vector<int> data3, out Vector<int> data4, out Vector<int> data5) {
                var a0 = WStatics.YGroup3ZipX2(x.AsVector128(), xB.AsVector128(), y.AsVector128(), yB.AsVector128(), z.AsVector128(), zB.AsVector128(), out var a1, out var a2, out var a3, out var a4, out var a5);
                data1 = a1.AsVector();
                data2 = a2.AsVector();
                data3 = a3.AsVector();
                data4 = a4.AsVector();
                data5 = a5.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup3ZipX2(Vector<uint> x, Vector<uint> xB, Vector<uint> y, Vector<uint> yB, Vector<uint> z, Vector<uint> zB, out Vector<uint> data1, out Vector<uint> data2, out Vector<uint> data3, out Vector<uint> data4, out Vector<uint> data5) {
                var a0 = WStatics.YGroup3ZipX2(x.AsVector128(), xB.AsVector128(), y.AsVector128(), yB.AsVector128(), z.AsVector128(), zB.AsVector128(), out var a1, out var a2, out var a3, out var a4, out var a5);
                data1 = a1.AsVector();
                data2 = a2.AsVector();
                data3 = a3.AsVector();
                data4 = a4.AsVector();
                data5 = a5.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup3ZipX2(Vector<long> x, Vector<long> xB, Vector<long> y, Vector<long> yB, Vector<long> z, Vector<long> zB, out Vector<long> data1, out Vector<long> data2, out Vector<long> data3, out Vector<long> data4, out Vector<long> data5) {
                var a0 = WStatics.YGroup3ZipX2(x.AsVector128(), xB.AsVector128(), y.AsVector128(), yB.AsVector128(), z.AsVector128(), zB.AsVector128(), out var a1, out var a2, out var a3, out var a4, out var a5);
                data1 = a1.AsVector();
                data2 = a2.AsVector();
                data3 = a3.AsVector();
                data4 = a4.AsVector();
                data5 = a5.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup3ZipX2(Vector<ulong> x, Vector<ulong> xB, Vector<ulong> y, Vector<ulong> yB, Vector<ulong> z, Vector<ulong> zB, out Vector<ulong> data1, out Vector<ulong> data2, out Vector<ulong> data3, out Vector<ulong> data4, out Vector<ulong> data5) {
                var a0 = WStatics.YGroup3ZipX2(x.AsVector128(), xB.AsVector128(), y.AsVector128(), yB.AsVector128(), z.AsVector128(), zB.AsVector128(), out var a1, out var a2, out var a3, out var a4, out var a5);
                data1 = a1.AsVector();
                data2 = a2.AsVector();
                data3 = a3.AsVector();
                data4 = a4.AsVector();
                data5 = a5.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup3ZipX2_Bit128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<T> YGroup3ZipX2_Bit128<T>(Vector<T> x, Vector<T> xB, Vector<T> y, Vector<T> yB, Vector<T> z, Vector<T> zB, out Vector<T> data1, out Vector<T> data2, out Vector<T> data3, out Vector<T> data4, out Vector<T> data5) where T : struct {
                var a0 = WStatics.YGroup3ZipX2_Bit128(x.AsVector128(), xB.AsVector128(), y.AsVector128(), yB.AsVector128(), z.AsVector128(), zB.AsVector128(), out var a1, out var a2, out var a3, out var a4, out var a5);
                data1 = a1.AsVector();
                data2 = a2.AsVector();
                data3 = a3.AsVector();
                data4 = a4.AsVector();
                data5 = a5.AsVector();
                return a0.AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YGroup4ToGroup3_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup4ToGroup3_AcceleratedTypes {
                get {
                    return WStatics.YGroup4ToGroup3_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4ToGroup3(Vector{float}, Vector{float}, Vector{float}, Vector{float}, out Vector{float}, out Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YGroup4ToGroup3(Vector<float> data0, Vector<float> data1, Vector<float> data2, Vector<float> data3, out Vector<float> result1, out Vector<float> result2) {
                var a0 = WStatics.YGroup4ToGroup3(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), data3.AsVector128(), out var a1, out var a2);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4ToGroup3(Vector{double}, Vector{double}, Vector{double}, Vector{double}, out Vector{double}, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup4ToGroup3(Vector<double> data0, Vector<double> data1, Vector<double> data2, Vector<double> data3, out Vector<double> result1, out Vector<double> result2) {
                var a0 = WStatics.YGroup4ToGroup3(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), data3.AsVector128(), out var a1, out var a2);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4ToGroup3(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YGroup4ToGroup3(Vector<sbyte> data0, Vector<sbyte> data1, Vector<sbyte> data2, Vector<sbyte> data3, out Vector<sbyte> result1, out Vector<sbyte> result2) {
                var a0 = WStatics.YGroup4ToGroup3(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), data3.AsVector128(), out var a1, out var a2);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4ToGroup3(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YGroup4ToGroup3(Vector<byte> data0, Vector<byte> data1, Vector<byte> data2, Vector<byte> data3, out Vector<byte> result1, out Vector<byte> result2) {
                var a0 = WStatics.YGroup4ToGroup3(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), data3.AsVector128(), out var a1, out var a2);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4ToGroup3(Vector{short}, Vector{short}, Vector{short}, Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YGroup4ToGroup3(Vector<short> data0, Vector<short> data1, Vector<short> data2, Vector<short> data3, out Vector<short> result1, out Vector<short> result2) {
                var a0 = WStatics.YGroup4ToGroup3(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), data3.AsVector128(), out var a1, out var a2);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4ToGroup3(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YGroup4ToGroup3(Vector<ushort> data0, Vector<ushort> data1, Vector<ushort> data2, Vector<ushort> data3, out Vector<ushort> result1, out Vector<ushort> result2) {
                var a0 = WStatics.YGroup4ToGroup3(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), data3.AsVector128(), out var a1, out var a2);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4ToGroup3(Vector{int}, Vector{int}, Vector{int}, Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YGroup4ToGroup3(Vector<int> data0, Vector<int> data1, Vector<int> data2, Vector<int> data3, out Vector<int> result1, out Vector<int> result2) {
                var a0 = WStatics.YGroup4ToGroup3(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), data3.AsVector128(), out var a1, out var a2);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4ToGroup3(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YGroup4ToGroup3(Vector<uint> data0, Vector<uint> data1, Vector<uint> data2, Vector<uint> data3, out Vector<uint> result1, out Vector<uint> result2) {
                var a0 = WStatics.YGroup4ToGroup3(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), data3.AsVector128(), out var a1, out var a2);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4ToGroup3(Vector{long}, Vector{long}, Vector{long}, Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup4ToGroup3(Vector<long> data0, Vector<long> data1, Vector<long> data2, Vector<long> data3, out Vector<long> result1, out Vector<long> result2) {
                var a0 = WStatics.YGroup4ToGroup3(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), data3.AsVector128(), out var a1, out var a2);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4ToGroup3(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup4ToGroup3(Vector<ulong> data0, Vector<ulong> data1, Vector<ulong> data2, Vector<ulong> data3, out Vector<ulong> result1, out Vector<ulong> result2) {
                var a0 = WStatics.YGroup4ToGroup3(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), data3.AsVector128(), out var a1, out var a2);
                result1 = a1.AsVector();
                result2 = a2.AsVector();
                return a0.AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup4Unzip_AcceleratedTypes {
                get {
                    return WStatics.YGroup4Unzip_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{double}, Vector{double}, Vector{double}, Vector{double}, out Vector{double}, out Vector{double}, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup4Unzip(Vector<double> data0, Vector<double> data1, Vector<double> data2, Vector<double> data3, out Vector<double> y, out Vector<double> z, out Vector<double> w) {
                var a0 = WStatics.YGroup4Unzip(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), data3.AsVector128(), out var a1, out var a2, out var a3);
                y = a1.AsVector();
                z = a2.AsVector();
                w = a3.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{long}, Vector{long}, Vector{long}, Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup4Unzip(Vector<long> data0, Vector<long> data1, Vector<long> data2, Vector<long> data3, out Vector<long> y, out Vector<long> z, out Vector<long> w) {
                var a0 = WStatics.YGroup4Unzip(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), data3.AsVector128(), out var a1, out var a2, out var a3);
                y = a1.AsVector();
                z = a2.AsVector();
                w = a3.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup4Unzip(Vector<ulong> data0, Vector<ulong> data1, Vector<ulong> data2, Vector<ulong> data3, out Vector<ulong> y, out Vector<ulong> z, out Vector<ulong> w) {
                var a0 = WStatics.YGroup4Unzip(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), data3.AsVector128(), out var a1, out var a2, out var a3);
                y = a1.AsVector();
                z = a2.AsVector();
                w = a3.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{ExInt128}, Vector{ExInt128}, Vector{ExInt128}, Vector{ExInt128}, out Vector{ExInt128}, out Vector{ExInt128}, out Vector{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExInt128> YGroup4Unzip(Vector<ExInt128> data0, Vector<ExInt128> data1, Vector<ExInt128> data2, Vector<ExInt128> data3, out Vector<ExInt128> y, out Vector<ExInt128> z, out Vector<ExInt128> w) {
                var a0 = WStatics.YGroup4Unzip(data0.ExAsVector128(), data1.ExAsVector128(), data2.ExAsVector128(), data3.ExAsVector128(), out var a1, out var a2, out var a3);
                y = a1.ExAsVector();
                z = a2.ExAsVector();
                w = a3.ExAsVector();
                return a0.ExAsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{ExUInt128}, Vector{ExUInt128}, Vector{ExUInt128}, Vector{ExUInt128}, out Vector{ExUInt128}, out Vector{ExUInt128}, out Vector{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExUInt128> YGroup4Unzip(Vector<ExUInt128> data0, Vector<ExUInt128> data1, Vector<ExUInt128> data2, Vector<ExUInt128> data3, out Vector<ExUInt128> y, out Vector<ExUInt128> z, out Vector<ExUInt128> w) {
                var a0 = WStatics.YGroup4Unzip(data0.ExAsVector128(), data1.ExAsVector128(), data2.ExAsVector128(), data3.ExAsVector128(), out var a1, out var a2, out var a3);
                y = a1.ExAsVector();
                z = a2.ExAsVector();
                w = a3.ExAsVector();
                return a0.ExAsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip_Bit128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<T> YGroup4Unzip_Bit128<T>(Vector<T> data0, Vector<T> data1, Vector<T> data2, Vector<T> data3, out Vector<T> y, out Vector<T> z, out Vector<T> w) where T : struct {
#if EX_APPLY_GENERIC
                var a0 = WStatics.YGroup4Unzip_Bit128(data0.ExAsVector128(), data1.ExAsVector128(), data2.ExAsVector128(), data3.ExAsVector128(), out var a1, out var a2, out var a3);
                y = a1.ExAsVector();
                z = a2.ExAsVector();
                w = a3.ExAsVector();
                return a0.ExAsVector();
#else
                var a0 = WStatics.YGroup4Unzip_Bit128(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), data3.AsVector128(), out var a1, out var a2, out var a3);
                y = a1.AsVector();
                z = a2.AsVector();
                w = a3.AsVector();
                return a0.AsVector();
#endif // EX_APPLY_GENERIC
            }


            /// <inheritdoc cref="IVectorTraits.YGroup4Zip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup4Zip_AcceleratedTypes {
                get {
                    return WStatics.YGroup4Zip_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{double}, Vector{double}, Vector{double}, Vector{double}, out Vector{double}, out Vector{double}, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YGroup4Zip(Vector<double> x, Vector<double> y, Vector<double> z, Vector<double> w, out Vector<double> data1, out Vector<double> data2, out Vector<double> data3) {
                var a0 = WStatics.YGroup4Zip(x.AsVector128(), y.AsVector128(), z.AsVector128(), w.AsVector128(), out var a1, out var a2, out var a3);
                data1 = a1.AsVector();
                data2 = a2.AsVector();
                data3 = a3.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{long}, Vector{long}, Vector{long}, Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YGroup4Zip(Vector<long> x, Vector<long> y, Vector<long> z, Vector<long> w, out Vector<long> data1, out Vector<long> data2, out Vector<long> data3) {
                var a0 = WStatics.YGroup4Zip(x.AsVector128(), y.AsVector128(), z.AsVector128(), w.AsVector128(), out var a1, out var a2, out var a3);
                data1 = a1.AsVector();
                data2 = a2.AsVector();
                data3 = a3.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YGroup4Zip(Vector<ulong> x, Vector<ulong> y, Vector<ulong> z, Vector<ulong> w, out Vector<ulong> data1, out Vector<ulong> data2, out Vector<ulong> data3) {
                var a0 = WStatics.YGroup4Zip(x.AsVector128(), y.AsVector128(), z.AsVector128(), w.AsVector128(), out var a1, out var a2, out var a3);
                data1 = a1.AsVector();
                data2 = a2.AsVector();
                data3 = a3.AsVector();
                return a0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{ExInt128}, Vector{ExInt128}, Vector{ExInt128}, Vector{ExInt128}, out Vector{ExInt128}, out Vector{ExInt128}, out Vector{ExInt128})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExInt128> YGroup4Zip(Vector<ExInt128> x, Vector<ExInt128> y, Vector<ExInt128> z, Vector<ExInt128> w, out Vector<ExInt128> data1, out Vector<ExInt128> data2, out Vector<ExInt128> data3) {
                var a0 = WStatics.YGroup4Zip(x.ExAsVector128(), y.ExAsVector128(), z.ExAsVector128(), w.ExAsVector128(), out var a1, out var a2, out var a3);
                data1 = a1.ExAsVector();
                data2 = a2.ExAsVector();
                data3 = a3.ExAsVector();
                return a0.ExAsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{ExUInt128}, Vector{ExUInt128}, Vector{ExUInt128}, Vector{ExUInt128}, out Vector{ExUInt128}, out Vector{ExUInt128}, out Vector{ExUInt128})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ExUInt128> YGroup4Zip(Vector<ExUInt128> x, Vector<ExUInt128> y, Vector<ExUInt128> z, Vector<ExUInt128> w, out Vector<ExUInt128> data1, out Vector<ExUInt128> data2, out Vector<ExUInt128> data3) {
                var a0 = WStatics.YGroup4Zip(x.ExAsVector128(), y.ExAsVector128(), z.ExAsVector128(), w.ExAsVector128(), out var a1, out var a2, out var a3);
                data1 = a1.ExAsVector();
                data2 = a2.ExAsVector();
                data3 = a3.ExAsVector();
                return a0.ExAsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YGroup4Zip_Bit128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<T> YGroup4Zip_Bit128<T>(Vector<T> x, Vector<T> y, Vector<T> z, Vector<T> w, out Vector<T> data1, out Vector<T> data2, out Vector<T> data3) where T : struct {
#if EX_APPLY_GENERIC
                var a0 = WStatics.YGroup4Zip_Bit128(x.ExAsVector128(), y.ExAsVector128(), z.ExAsVector128(), w.ExAsVector128(), out var a1, out var a2, out var a3);
                data1 = a1.ExAsVector();
                data2 = a2.ExAsVector();
                data3 = a3.ExAsVector();
                return a0.ExAsVector();
#else
                var a0 = WStatics.YGroup4Zip_Bit128(x.AsVector128(), y.AsVector128(), z.AsVector128(), w.AsVector128(), out var a1, out var a2, out var a3);
                data1 = a1.AsVector();
                data2 = a2.AsVector();
                data3 = a3.AsVector();
                return a0.AsVector();
#endif // EX_APPLY_GENERIC
            }

#endif // NETCOREAPP3_0_OR_GREATER
        }
    }
}
