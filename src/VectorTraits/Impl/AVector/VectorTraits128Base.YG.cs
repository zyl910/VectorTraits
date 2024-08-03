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

            /// <inheritdoc cref="IVectorTraits.YGroup2Unzip_Int128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<T> YGroup2Unzip_Int128<T>(Vector<T> data0, Vector<T> data1, out Vector<T> y) where T : struct {
#if EX_APPLY_GENERIC
                var a0 = WStatics.YGroup2Unzip_Int128(data0.ExAsVector128(), data1.ExAsVector128(), out var a1);
                y = a1.ExAsVector();
                return a0.ExAsVector();
#else
                var a0 = WStatics.YGroup2Unzip_Int128(data0.AsVector128(), data1.AsVector128(), out var a1);
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

            /// <inheritdoc cref="IVectorTraits.YGroup2Zip_Int128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<T> YGroup2Zip_Int128<T>(Vector<T> x, Vector<T> y, out Vector<T> data1) where T : struct {
#if EX_APPLY_GENERIC
                var a0 = WStatics.YGroup2Zip_Int128(x.ExAsVector128(), y.ExAsVector128(), out var a1);
                data1 = a1.ExAsVector();
                return a0.ExAsVector();
#else
                var a0 = WStatics.YGroup2Zip_Int128(x.AsVector128(), y.AsVector128(), out var a1);
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

            /// <inheritdoc cref="IVectorTraits.YGroup4Unzip_Int128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<T> YGroup4Unzip_Int128<T>(Vector<T> data0, Vector<T> data1, Vector<T> data2, Vector<T> data3, out Vector<T> y, out Vector<T> z, out Vector<T> w) where T : struct {
#if EX_APPLY_GENERIC
                var a0 = WStatics.YGroup4Unzip_Int128(data0.ExAsVector128(), data1.ExAsVector128(), data2.ExAsVector128(), data3.ExAsVector128(), out var a1, out var a2, out var a3);
                y = a1.ExAsVector();
                z = a2.ExAsVector();
                w = a3.ExAsVector();
                return a0.ExAsVector();
#else
                var a0 = WStatics.YGroup4Unzip_Int128(data0.AsVector128(), data1.AsVector128(), data2.AsVector128(), data3.AsVector128(), out var a1, out var a2, out var a3);
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

            /// <inheritdoc cref="IVectorTraits.YGroup4Zip_Int128"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<T> YGroup4Zip_Int128<T>(Vector<T> x, Vector<T> y, Vector<T> z, Vector<T> w, out Vector<T> data1, out Vector<T> data2, out Vector<T> data3) where T : struct {
#if EX_APPLY_GENERIC
                var a0 = WStatics.YGroup4Zip_Int128(x.ExAsVector128(), y.ExAsVector128(), z.ExAsVector128(), w.ExAsVector128(), out var a1, out var a2, out var a3);
                data1 = a1.ExAsVector();
                data2 = a2.ExAsVector();
                data3 = a3.ExAsVector();
                return a0.ExAsVector();
#else
                var a0 = WStatics.YGroup4Zip_Int128(x.AsVector128(), y.AsVector128(), z.AsVector128(), w.AsVector128(), out var a1, out var a2, out var a3);
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
