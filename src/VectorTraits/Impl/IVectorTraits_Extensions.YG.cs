#if NET7_0_OR_GREATER
#define BCL_TYPE_INT128
#endif // NET7_0_OR_GREATER

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using Zyl.VectorTraits.ExTypes;
using Zyl.VectorTraits.Extensions.SameW;
using static Zyl.VectorTraits.Impl.VectorMessageFormats;

namespace Zyl.VectorTraits.Impl {
    partial class IVectorTraits_Extensions {

#if BCL_TYPE_INT128

        /// <inheritdoc cref="Vectors.YGroup2Unzip(Vector{ExInt128}, Vector{ExInt128}, out Vector{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<Int128> YGroup2Unzip(this IVectorTraits athis, Vector<Int128> data0, Vector<Int128> data1, out Vector<Int128> y) {
            var d0 = athis.YGroup2Unzip(data0.ExAsExInt128(), data1.ExAsExInt128(), out var d1);
            y = d1.ExAsInt128();
            return d0.ExAsInt128();
        }

        /// <inheritdoc cref="Vectors.YGroup2Unzip(Vector{ExUInt128}, Vector{ExUInt128}, out Vector{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<UInt128> YGroup2Unzip(this IVectorTraits athis, Vector<UInt128> data0, Vector<UInt128> data1, out Vector<UInt128> y) {
            var d0 = athis.YGroup2Unzip(data0.ExAsExUInt128(), data1.ExAsExUInt128(), out var d1);
            y = d1.ExAsUInt128();
            return d0.ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="Vectors.YGroup2Unzip{T}(Vector{T}, Vector{T})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static (Vector<T> X, Vector<T> Y) YGroup2Unzip<T>(this IVectorTraits athis, Vector<T> data0, Vector<T> data1) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip((Vector<float>)(object)data0, (Vector<float>)(object)data1);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip((Vector<double>)(object)data0, (Vector<double>)(object)data1);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip((Vector<sbyte>)(object)data0, (Vector<sbyte>)(object)data1);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip((Vector<byte>)(object)data0, (Vector<byte>)(object)data1);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip((Vector<short>)(object)data0, (Vector<short>)(object)data1);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip((Vector<ushort>)(object)data0, (Vector<ushort>)(object)data1);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip((Vector<int>)(object)data0, (Vector<int>)(object)data1);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip((Vector<uint>)(object)data0, (Vector<uint>)(object)data1);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip((Vector<long>)(object)data0, (Vector<long>)(object)data1);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip((Vector<ulong>)(object)data0, (Vector<ulong>)(object)data1);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1);
            } else if (typeof(ExInt128) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip((Vector<ExInt128>)(object)data0, (Vector<ExInt128>)(object)data1);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1);
            } else if (typeof(ExUInt128) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip((Vector<ExUInt128>)(object)data0, (Vector<ExUInt128>)(object)data1);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1);
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip((Vector<Int128>)(object)data0, (Vector<Int128>)(object)data1);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1);
            } else if (typeof(UInt128) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip((Vector<UInt128>)(object)data0, (Vector<UInt128>)(object)data1);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1);
#endif // BCL_TYPE_INT128
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vectors.YGroup2Unzip(Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<float> X, Vector<float> Y) YGroup2Unzip(this IVectorTraits athis, Vector<float> data0, Vector<float> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vectors.YGroup2Unzip(Vector{double}, Vector{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<double> X, Vector<double> Y) YGroup2Unzip(this IVectorTraits athis, Vector<double> data0, Vector<double> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vectors.YGroup2Unzip(Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> X, Vector<sbyte> Y) YGroup2Unzip(this IVectorTraits athis, Vector<sbyte> data0, Vector<sbyte> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vectors.YGroup2Unzip(Vector{byte}, Vector{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> X, Vector<byte> Y) YGroup2Unzip(this IVectorTraits athis, Vector<byte> data0, Vector<byte> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vectors.YGroup2Unzip(Vector{short}, Vector{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> X, Vector<short> Y) YGroup2Unzip(this IVectorTraits athis, Vector<short> data0, Vector<short> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vectors.YGroup2Unzip(Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> X, Vector<ushort> Y) YGroup2Unzip(this IVectorTraits athis, Vector<ushort> data0, Vector<ushort> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vectors.YGroup2Unzip(Vector{int}, Vector{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> X, Vector<int> Y) YGroup2Unzip(this IVectorTraits athis, Vector<int> data0, Vector<int> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vectors.YGroup2Unzip(Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> X, Vector<uint> Y) YGroup2Unzip(this IVectorTraits athis, Vector<uint> data0, Vector<uint> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vectors.YGroup2Unzip(Vector{long}, Vector{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> X, Vector<long> Y) YGroup2Unzip(this IVectorTraits athis, Vector<long> data0, Vector<long> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vectors.YGroup2Unzip(Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> X, Vector<ulong> Y) YGroup2Unzip(this IVectorTraits athis, Vector<ulong> data0, Vector<ulong> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vectors.YGroup2Unzip(Vector{ExInt128}, Vector{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ExInt128> X, Vector<ExInt128> Y) YGroup2Unzip(this IVectorTraits athis, Vector<ExInt128> data0, Vector<ExInt128> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vectors.YGroup2Unzip(Vector{ExUInt128}, Vector{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ExUInt128> X, Vector<ExUInt128> Y) YGroup2Unzip(this IVectorTraits athis, Vector<ExUInt128> data0, Vector<ExUInt128> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="Vectors.YGroup2Unzip(Vector{Int128}, Vector{Int128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<Int128> X, Vector<Int128> Y) YGroup2Unzip(this IVectorTraits athis, Vector<Int128> data0, Vector<Int128> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vectors.YGroup2Unzip(Vector{UInt128}, Vector{UInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<UInt128> X, Vector<UInt128> Y) YGroup2Unzip(this IVectorTraits athis, Vector<UInt128> data0, Vector<UInt128> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="Vectors.YGroup2UnzipEven(Vector{int}, Vector{int})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static Vector<T> YGroup2UnzipEven<T>(this IVectorTraits athis, Vector<T> data0, Vector<T> data1) where T : struct {
            if (typeof(float) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2UnzipEven((Vector<float>)(object)data0, (Vector<float>)(object)data1);
            } else if (typeof(double) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2UnzipEven((Vector<double>)(object)data0, (Vector<double>)(object)data1);
            } else if (typeof(sbyte) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2UnzipEven((Vector<sbyte>)(object)data0, (Vector<sbyte>)(object)data1);
            } else if (typeof(byte) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2UnzipEven((Vector<byte>)(object)data0, (Vector<byte>)(object)data1);
            } else if (typeof(short) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2UnzipEven((Vector<short>)(object)data0, (Vector<short>)(object)data1);
            } else if (typeof(ushort) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2UnzipEven((Vector<ushort>)(object)data0, (Vector<ushort>)(object)data1);
            } else if (typeof(int) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2UnzipEven((Vector<int>)(object)data0, (Vector<int>)(object)data1);
            } else if (typeof(uint) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2UnzipEven((Vector<uint>)(object)data0, (Vector<uint>)(object)data1);
            } else if (typeof(long) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2UnzipEven((Vector<long>)(object)data0, (Vector<long>)(object)data1);
            } else if (typeof(ulong) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2UnzipEven((Vector<ulong>)(object)data0, (Vector<ulong>)(object)data1);
            } else if (typeof(ExInt128) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2UnzipEven((Vector<ExInt128>)(object)data0, (Vector<ExInt128>)(object)data1);
            } else if (typeof(ExUInt128) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2UnzipEven((Vector<ExUInt128>)(object)data0, (Vector<ExUInt128>)(object)data1);
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2UnzipEven((Vector<Int128>)(object)data0, (Vector<Int128>)(object)data1);
            } else if (typeof(UInt128) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2UnzipEven((Vector<UInt128>)(object)data0, (Vector<UInt128>)(object)data1);
#endif // BCL_TYPE_INT128
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="Vectors.YGroup2UnzipEven(Vector{ExInt128}, Vector{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<Int128> YGroup2UnzipEven(this IVectorTraits athis, Vector<Int128> data0, Vector<Int128> data1) {
            return athis.YGroup2UnzipEven(data0.ExAsExInt128(), data1.ExAsExInt128()).ExAsInt128();
        }

        /// <inheritdoc cref="Vectors.YGroup2UnzipEven(Vector{ExUInt128}, Vector{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<UInt128> YGroup2UnzipEven(this IVectorTraits athis, Vector<UInt128> data0, Vector<UInt128> data1) {
            return athis.YGroup2UnzipEven(data0.ExAsExUInt128(), data1.ExAsExUInt128()).ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="Vectors.YGroup2UnzipOdd(Vector{int}, Vector{int})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static Vector<T> YGroup2UnzipOdd<T>(this IVectorTraits athis, Vector<T> data0, Vector<T> data1) where T : struct {
            if (typeof(float) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2UnzipOdd((Vector<float>)(object)data0, (Vector<float>)(object)data1);
            } else if (typeof(double) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2UnzipOdd((Vector<double>)(object)data0, (Vector<double>)(object)data1);
            } else if (typeof(sbyte) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2UnzipOdd((Vector<sbyte>)(object)data0, (Vector<sbyte>)(object)data1);
            } else if (typeof(byte) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2UnzipOdd((Vector<byte>)(object)data0, (Vector<byte>)(object)data1);
            } else if (typeof(short) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2UnzipOdd((Vector<short>)(object)data0, (Vector<short>)(object)data1);
            } else if (typeof(ushort) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2UnzipOdd((Vector<ushort>)(object)data0, (Vector<ushort>)(object)data1);
            } else if (typeof(int) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2UnzipOdd((Vector<int>)(object)data0, (Vector<int>)(object)data1);
            } else if (typeof(uint) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2UnzipOdd((Vector<uint>)(object)data0, (Vector<uint>)(object)data1);
            } else if (typeof(long) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2UnzipOdd((Vector<long>)(object)data0, (Vector<long>)(object)data1);
            } else if (typeof(ulong) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2UnzipOdd((Vector<ulong>)(object)data0, (Vector<ulong>)(object)data1);
            } else if (typeof(ExInt128) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2UnzipOdd((Vector<ExInt128>)(object)data0, (Vector<ExInt128>)(object)data1);
            } else if (typeof(ExUInt128) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2UnzipOdd((Vector<ExUInt128>)(object)data0, (Vector<ExUInt128>)(object)data1);
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2UnzipOdd((Vector<Int128>)(object)data0, (Vector<Int128>)(object)data1);
            } else if (typeof(UInt128) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2UnzipOdd((Vector<UInt128>)(object)data0, (Vector<UInt128>)(object)data1);
#endif // BCL_TYPE_INT128
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="Vectors.YGroup2UnzipOdd(Vector{ExInt128}, Vector{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<Int128> YGroup2UnzipOdd(this IVectorTraits athis, Vector<Int128> data0, Vector<Int128> data1) {
            return athis.YGroup2UnzipOdd(data0.ExAsExInt128(), data1.ExAsExInt128()).ExAsInt128();
        }

        /// <inheritdoc cref="Vectors.YGroup2UnzipOdd(Vector{ExUInt128}, Vector{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<UInt128> YGroup2UnzipOdd(this IVectorTraits athis, Vector<UInt128> data0, Vector<UInt128> data1) {
            return athis.YGroup2UnzipOdd(data0.ExAsExUInt128(), data1.ExAsExUInt128()).ExAsUInt128();
        }

#endif // BCL_TYPE_INT128


#if BCL_TYPE_INT128

        /// <inheritdoc cref="Vectors.YGroup2Zip(Vector{ExInt128}, Vector{ExInt128}, out Vector{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<Int128> YGroup2Zip(this IVectorTraits athis, Vector<Int128> x, Vector<Int128> y, out Vector<Int128> data1) {
            var d0 = athis.YGroup2Zip(x.ExAsExInt128(), y.ExAsExInt128(), out var d1);
            data1 = d1.ExAsInt128();
            return d0.ExAsInt128();
        }

        /// <inheritdoc cref="Vectors.YGroup2Zip(Vector{ExUInt128}, Vector{ExUInt128}, out Vector{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<UInt128> YGroup2Zip(this IVectorTraits athis, Vector<UInt128> x, Vector<UInt128> y, out Vector<UInt128> data1) {
            var d0 = athis.YGroup2Zip(x.ExAsExUInt128(), y.ExAsExUInt128(), out var d1);
            data1 = d1.ExAsUInt128();
            return d0.ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="Vectors.YGroup2Zip{T}(Vector{T}, Vector{T})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static (Vector<T> Data0, Vector<T> Data1) YGroup2Zip<T>(this IVectorTraits athis, Vector<T> x, Vector<T> y) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip((Vector<float>)(object)x, (Vector<float>)(object)y);
                return ((Vector<T>)(object)data0, (Vector<T>)(object)data1);
            } else if (typeof(double) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip((Vector<double>)(object)x, (Vector<double>)(object)y);
                return ((Vector<T>)(object)data0, (Vector<T>)(object)data1);
            } else if (typeof(sbyte) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip((Vector<sbyte>)(object)x, (Vector<sbyte>)(object)y);
                return ((Vector<T>)(object)data0, (Vector<T>)(object)data1);
            } else if (typeof(byte) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip((Vector<byte>)(object)x, (Vector<byte>)(object)y);
                return ((Vector<T>)(object)data0, (Vector<T>)(object)data1);
            } else if (typeof(short) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip((Vector<short>)(object)x, (Vector<short>)(object)y);
                return ((Vector<T>)(object)data0, (Vector<T>)(object)data1);
            } else if (typeof(ushort) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip((Vector<ushort>)(object)x, (Vector<ushort>)(object)y);
                return ((Vector<T>)(object)data0, (Vector<T>)(object)data1);
            } else if (typeof(int) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip((Vector<int>)(object)x, (Vector<int>)(object)y);
                return ((Vector<T>)(object)data0, (Vector<T>)(object)data1);
            } else if (typeof(uint) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip((Vector<uint>)(object)x, (Vector<uint>)(object)y);
                return ((Vector<T>)(object)data0, (Vector<T>)(object)data1);
            } else if (typeof(long) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip((Vector<long>)(object)x, (Vector<long>)(object)y);
                return ((Vector<T>)(object)data0, (Vector<T>)(object)data1);
            } else if (typeof(ulong) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip((Vector<ulong>)(object)x, (Vector<ulong>)(object)y);
                return ((Vector<T>)(object)data0, (Vector<T>)(object)data1);
            } else if (typeof(ExInt128) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip((Vector<ExInt128>)(object)x, (Vector<ExInt128>)(object)y);
                return ((Vector<T>)(object)data0, (Vector<T>)(object)data1);
            } else if (typeof(ExUInt128) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip((Vector<ExUInt128>)(object)x, (Vector<ExUInt128>)(object)y);
                return ((Vector<T>)(object)data0, (Vector<T>)(object)data1);
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip((Vector<Int128>)(object)x, (Vector<Int128>)(object)y);
                return ((Vector<T>)(object)data0, (Vector<T>)(object)data1);
            } else if (typeof(UInt128) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip((Vector<UInt128>)(object)x, (Vector<UInt128>)(object)y);
                return ((Vector<T>)(object)data0, (Vector<T>)(object)data1);
#endif // BCL_TYPE_INT128
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vectors.YGroup2Zip(Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<float> Data0, Vector<float> Data1) YGroup2Zip(this IVectorTraits athis, Vector<float> x, Vector<float> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vectors.YGroup2Zip(Vector{double}, Vector{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<double> Data0, Vector<double> Data1) YGroup2Zip(this IVectorTraits athis, Vector<double> x, Vector<double> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vectors.YGroup2Zip(Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> Data0, Vector<sbyte> Data1) YGroup2Zip(this IVectorTraits athis, Vector<sbyte> x, Vector<sbyte> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vectors.YGroup2Zip(Vector{byte}, Vector{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> Data0, Vector<byte> Data1) YGroup2Zip(this IVectorTraits athis, Vector<byte> x, Vector<byte> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vectors.YGroup2Zip(Vector{short}, Vector{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> Data0, Vector<short> Data1) YGroup2Zip(this IVectorTraits athis, Vector<short> x, Vector<short> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vectors.YGroup2Zip(Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> Data0, Vector<ushort> Data1) YGroup2Zip(this IVectorTraits athis, Vector<ushort> x, Vector<ushort> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vectors.YGroup2Zip(Vector{int}, Vector{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> Data0, Vector<int> Data1) YGroup2Zip(this IVectorTraits athis, Vector<int> x, Vector<int> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vectors.YGroup2Zip(Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> Data0, Vector<uint> Data1) YGroup2Zip(this IVectorTraits athis, Vector<uint> x, Vector<uint> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vectors.YGroup2Zip(Vector{long}, Vector{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> Data0, Vector<long> Data1) YGroup2Zip(this IVectorTraits athis, Vector<long> x, Vector<long> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vectors.YGroup2Zip(Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> Data0, Vector<ulong> Data1) YGroup2Zip(this IVectorTraits athis, Vector<ulong> x, Vector<ulong> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vectors.YGroup2Zip(Vector{ExInt128}, Vector{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ExInt128> Data0, Vector<ExInt128> Data1) YGroup2Zip(this IVectorTraits athis, Vector<ExInt128> x, Vector<ExInt128> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vectors.YGroup2Zip(Vector{ExUInt128}, Vector{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ExUInt128> Data0, Vector<ExUInt128> Data1) YGroup2Zip(this IVectorTraits athis, Vector<ExUInt128> x, Vector<ExUInt128> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="Vectors.YGroup2Zip(Vector{Int128}, Vector{Int128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<Int128> Data0, Vector<Int128> Data1) YGroup2Zip(this IVectorTraits athis, Vector<Int128> x, Vector<Int128> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vectors.YGroup2Zip(Vector{UInt128}, Vector{UInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<UInt128> Data0, Vector<UInt128> Data1) YGroup2Zip(this IVectorTraits athis, Vector<UInt128> x, Vector<UInt128> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="Vectors.YGroup2ZipHigh(Vector{int}, Vector{int})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static Vector<T> YGroup2ZipHigh<T>(this IVectorTraits athis, Vector<T> x, Vector<T> y) where T : struct {
            if (typeof(float) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2ZipHigh((Vector<float>)(object)x, (Vector<float>)(object)y);
            } else if (typeof(double) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2ZipHigh((Vector<double>)(object)x, (Vector<double>)(object)y);
            } else if (typeof(sbyte) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2ZipHigh((Vector<sbyte>)(object)x, (Vector<sbyte>)(object)y);
            } else if (typeof(byte) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2ZipHigh((Vector<byte>)(object)x, (Vector<byte>)(object)y);
            } else if (typeof(short) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2ZipHigh((Vector<short>)(object)x, (Vector<short>)(object)y);
            } else if (typeof(ushort) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2ZipHigh((Vector<ushort>)(object)x, (Vector<ushort>)(object)y);
            } else if (typeof(int) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2ZipHigh((Vector<int>)(object)x, (Vector<int>)(object)y);
            } else if (typeof(uint) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2ZipHigh((Vector<uint>)(object)x, (Vector<uint>)(object)y);
            } else if (typeof(long) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2ZipHigh((Vector<long>)(object)x, (Vector<long>)(object)y);
            } else if (typeof(ulong) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2ZipHigh((Vector<ulong>)(object)x, (Vector<ulong>)(object)y);
            } else if (typeof(ExInt128) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2ZipHigh((Vector<ExInt128>)(object)x, (Vector<ExInt128>)(object)y);
            } else if (typeof(ExUInt128) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2ZipHigh((Vector<ExUInt128>)(object)x, (Vector<ExUInt128>)(object)y);
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2ZipHigh((Vector<Int128>)(object)x, (Vector<Int128>)(object)y);
            } else if (typeof(UInt128) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2ZipHigh((Vector<UInt128>)(object)x, (Vector<UInt128>)(object)y);
#endif // BCL_TYPE_INT128
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="Vectors.YGroup2ZipHigh(Vector{ExInt128}, Vector{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<Int128> YGroup2ZipHigh(this IVectorTraits athis, Vector<Int128> x, Vector<Int128> y) {
            return athis.YGroup2ZipHigh(x.ExAsExInt128(), y.ExAsExInt128()).ExAsInt128();
        }

        /// <inheritdoc cref="Vectors.YGroup2ZipHigh(Vector{ExUInt128}, Vector{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<UInt128> YGroup2ZipHigh(this IVectorTraits athis, Vector<UInt128> x, Vector<UInt128> y) {
            return athis.YGroup2ZipHigh(x.ExAsExUInt128(), y.ExAsExUInt128()).ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="Vectors.YGroup2ZipLow(Vector{int}, Vector{int})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static Vector<T> YGroup2ZipLow<T>(this IVectorTraits athis, Vector<T> x, Vector<T> y) where T : struct {
            if (typeof(float) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2ZipLow((Vector<float>)(object)x, (Vector<float>)(object)y);
            } else if (typeof(double) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2ZipLow((Vector<double>)(object)x, (Vector<double>)(object)y);
            } else if (typeof(sbyte) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2ZipLow((Vector<sbyte>)(object)x, (Vector<sbyte>)(object)y);
            } else if (typeof(byte) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2ZipLow((Vector<byte>)(object)x, (Vector<byte>)(object)y);
            } else if (typeof(short) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2ZipLow((Vector<short>)(object)x, (Vector<short>)(object)y);
            } else if (typeof(ushort) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2ZipLow((Vector<ushort>)(object)x, (Vector<ushort>)(object)y);
            } else if (typeof(int) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2ZipLow((Vector<int>)(object)x, (Vector<int>)(object)y);
            } else if (typeof(uint) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2ZipLow((Vector<uint>)(object)x, (Vector<uint>)(object)y);
            } else if (typeof(long) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2ZipLow((Vector<long>)(object)x, (Vector<long>)(object)y);
            } else if (typeof(ulong) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2ZipLow((Vector<ulong>)(object)x, (Vector<ulong>)(object)y);
            } else if (typeof(ExInt128) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2ZipLow((Vector<ExInt128>)(object)x, (Vector<ExInt128>)(object)y);
            } else if (typeof(ExUInt128) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2ZipLow((Vector<ExUInt128>)(object)x, (Vector<ExUInt128>)(object)y);
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2ZipLow((Vector<Int128>)(object)x, (Vector<Int128>)(object)y);
            } else if (typeof(UInt128) == typeof(T)) {
                return (Vector<T>)(object)athis.YGroup2ZipLow((Vector<UInt128>)(object)x, (Vector<UInt128>)(object)y);
#endif // BCL_TYPE_INT128
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="Vectors.YGroup2ZipLow(Vector{ExInt128}, Vector{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<Int128> YGroup2ZipLow(this IVectorTraits athis, Vector<Int128> x, Vector<Int128> y) {
            return athis.YGroup2ZipLow(x.ExAsExInt128(), y.ExAsExInt128()).ExAsInt128();
        }

        /// <inheritdoc cref="Vectors.YGroup2ZipLow(Vector{ExUInt128}, Vector{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<UInt128> YGroup2ZipLow(this IVectorTraits athis, Vector<UInt128> x, Vector<UInt128> y) {
            return athis.YGroup2ZipLow(x.ExAsExUInt128(), y.ExAsExUInt128()).ExAsUInt128();
        }

#endif // BCL_TYPE_INT128


        /// <inheritdoc cref="Vectors.YGroup3ToGroup4{T}(Vector{T}, Vector{T}, Vector{T})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<T> Result0, Vector<T> Result1, Vector<T> Result2, Vector<T> Result3) YGroup3ToGroup4<T>(this IVectorTraits athis, Vector<T> data0, Vector<T> data1, Vector<T> data2) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup3ToGroup4((Vector<float>)(object)data0, (Vector<float>)(object)data1, (Vector<float>)(object)data2);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup3ToGroup4((Vector<double>)(object)data0, (Vector<double>)(object)data1, (Vector<double>)(object)data2);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup3ToGroup4((Vector<sbyte>)(object)data0, (Vector<sbyte>)(object)data1, (Vector<sbyte>)(object)data2);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup3ToGroup4((Vector<byte>)(object)data0, (Vector<byte>)(object)data1, (Vector<byte>)(object)data2);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup3ToGroup4((Vector<short>)(object)data0, (Vector<short>)(object)data1, (Vector<short>)(object)data2);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup3ToGroup4((Vector<ushort>)(object)data0, (Vector<ushort>)(object)data1, (Vector<ushort>)(object)data2);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup3ToGroup4((Vector<int>)(object)data0, (Vector<int>)(object)data1, (Vector<int>)(object)data2);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup3ToGroup4((Vector<uint>)(object)data0, (Vector<uint>)(object)data1, (Vector<uint>)(object)data2);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup3ToGroup4((Vector<long>)(object)data0, (Vector<long>)(object)data1, (Vector<long>)(object)data2);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup3ToGroup4((Vector<ulong>)(object)data0, (Vector<ulong>)(object)data1, (Vector<ulong>)(object)data2);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vectors.YGroup3ToGroup4(Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<float> Result0, Vector<float> Result1, Vector<float> Result2, Vector<float> Result3) YGroup3ToGroup4(this IVectorTraits athis, Vector<float> data0, Vector<float> data1, Vector<float> data2) {
            var rt0 = athis.YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vectors.YGroup3ToGroup4(Vector{double}, Vector{double}, Vector{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<double> Result0, Vector<double> Result1, Vector<double> Result2, Vector<double> Result3) YGroup3ToGroup4(this IVectorTraits athis, Vector<double> data0, Vector<double> data1, Vector<double> data2) {
            var rt0 = athis.YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vectors.YGroup3ToGroup4(Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> Result0, Vector<sbyte> Result1, Vector<sbyte> Result2, Vector<sbyte> Result3) YGroup3ToGroup4(this IVectorTraits athis, Vector<sbyte> data0, Vector<sbyte> data1, Vector<sbyte> data2) {
            var rt0 = athis.YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vectors.YGroup3ToGroup4(Vector{byte}, Vector{byte}, Vector{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> Result0, Vector<byte> Result1, Vector<byte> Result2, Vector<byte> Result3) YGroup3ToGroup4(this IVectorTraits athis, Vector<byte> data0, Vector<byte> data1, Vector<byte> data2) {
            var rt0 = athis.YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vectors.YGroup3ToGroup4(Vector{short}, Vector{short}, Vector{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> Result0, Vector<short> Result1, Vector<short> Result2, Vector<short> Result3) YGroup3ToGroup4(this IVectorTraits athis, Vector<short> data0, Vector<short> data1, Vector<short> data2) {
            var rt0 = athis.YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vectors.YGroup3ToGroup4(Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> Result0, Vector<ushort> Result1, Vector<ushort> Result2, Vector<ushort> Result3) YGroup3ToGroup4(this IVectorTraits athis, Vector<ushort> data0, Vector<ushort> data1, Vector<ushort> data2) {
            var rt0 = athis.YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vectors.YGroup3ToGroup4(Vector{int}, Vector{int}, Vector{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> Result0, Vector<int> Result1, Vector<int> Result2, Vector<int> Result3) YGroup3ToGroup4(this IVectorTraits athis, Vector<int> data0, Vector<int> data1, Vector<int> data2) {
            var rt0 = athis.YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vectors.YGroup3ToGroup4(Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> Result0, Vector<uint> Result1, Vector<uint> Result2, Vector<uint> Result3) YGroup3ToGroup4(this IVectorTraits athis, Vector<uint> data0, Vector<uint> data1, Vector<uint> data2) {
            var rt0 = athis.YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            //Console.WriteLine(VectorTextUtil.Format("athis f({0}, {1}, {2}): {3}, {4}, {5}, {6}", data0, data1, data2, rt0, rt1, rt2, rt3));
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vectors.YGroup3ToGroup4(Vector{long}, Vector{long}, Vector{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> Result0, Vector<long> Result1, Vector<long> Result2, Vector<long> Result3) YGroup3ToGroup4(this IVectorTraits athis, Vector<long> data0, Vector<long> data1, Vector<long> data2) {
            var rt0 = athis.YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vectors.YGroup3ToGroup4(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> Result0, Vector<ulong> Result1, Vector<ulong> Result2, Vector<ulong> Result3) YGroup3ToGroup4(this IVectorTraits athis, Vector<ulong> data0, Vector<ulong> data1, Vector<ulong> data2) {
            var rt0 = athis.YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }


        /// <inheritdoc cref="Vectors.YGroup3Unzip{T}(Vector{T}, Vector{T}, Vector{T})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<T> X, Vector<T> Y, Vector<T> Z) YGroup3Unzip<T>(this IVectorTraits athis, Vector<T> data0, Vector<T> data1, Vector<T> data2) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Unzip((Vector<float>)(object)data0, (Vector<float>)(object)data1, (Vector<float>)(object)data2);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Unzip((Vector<double>)(object)data0, (Vector<double>)(object)data1, (Vector<double>)(object)data2);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Unzip((Vector<sbyte>)(object)data0, (Vector<sbyte>)(object)data1, (Vector<sbyte>)(object)data2);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Unzip((Vector<byte>)(object)data0, (Vector<byte>)(object)data1, (Vector<byte>)(object)data2);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Unzip((Vector<short>)(object)data0, (Vector<short>)(object)data1, (Vector<short>)(object)data2);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Unzip((Vector<ushort>)(object)data0, (Vector<ushort>)(object)data1, (Vector<ushort>)(object)data2);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Unzip((Vector<int>)(object)data0, (Vector<int>)(object)data1, (Vector<int>)(object)data2);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Unzip((Vector<uint>)(object)data0, (Vector<uint>)(object)data1, (Vector<uint>)(object)data2);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Unzip((Vector<long>)(object)data0, (Vector<long>)(object)data1, (Vector<long>)(object)data2);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Unzip((Vector<ulong>)(object)data0, (Vector<ulong>)(object)data1, (Vector<ulong>)(object)data2);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vectors.YGroup3Unzip(Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<float> X, Vector<float> Y, Vector<float> Z) YGroup3Unzip(this IVectorTraits athis, Vector<float> data0, Vector<float> data1, Vector<float> data2) {
            var rt0 = athis.YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vectors.YGroup3Unzip(Vector{double}, Vector{double}, Vector{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<double> X, Vector<double> Y, Vector<double> Z) YGroup3Unzip(this IVectorTraits athis, Vector<double> data0, Vector<double> data1, Vector<double> data2) {
            var rt0 = athis.YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vectors.YGroup3Unzip(Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> X, Vector<sbyte> Y, Vector<sbyte> Z) YGroup3Unzip(this IVectorTraits athis, Vector<sbyte> data0, Vector<sbyte> data1, Vector<sbyte> data2) {
            var rt0 = athis.YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vectors.YGroup3Unzip(Vector{byte}, Vector{byte}, Vector{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> X, Vector<byte> Y, Vector<byte> Z) YGroup3Unzip(this IVectorTraits athis, Vector<byte> data0, Vector<byte> data1, Vector<byte> data2) {
            var rt0 = athis.YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vectors.YGroup3Unzip(Vector{short}, Vector{short}, Vector{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> X, Vector<short> Y, Vector<short> Z) YGroup3Unzip(this IVectorTraits athis, Vector<short> data0, Vector<short> data1, Vector<short> data2) {
            var rt0 = athis.YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vectors.YGroup3Unzip(Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> X, Vector<ushort> Y, Vector<ushort> Z) YGroup3Unzip(this IVectorTraits athis, Vector<ushort> data0, Vector<ushort> data1, Vector<ushort> data2) {
            var rt0 = athis.YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vectors.YGroup3Unzip(Vector{int}, Vector{int}, Vector{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> X, Vector<int> Y, Vector<int> Z) YGroup3Unzip(this IVectorTraits athis, Vector<int> data0, Vector<int> data1, Vector<int> data2) {
            var rt0 = athis.YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vectors.YGroup3Unzip(Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> X, Vector<uint> Y, Vector<uint> Z) YGroup3Unzip(this IVectorTraits athis, Vector<uint> data0, Vector<uint> data1, Vector<uint> data2) {
            var rt0 = athis.YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vectors.YGroup3Unzip(Vector{long}, Vector{long}, Vector{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> X, Vector<long> Y, Vector<long> Z) YGroup3Unzip(this IVectorTraits athis, Vector<long> data0, Vector<long> data1, Vector<long> data2) {
            var rt0 = athis.YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vectors.YGroup3Unzip(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> X, Vector<ulong> Y, Vector<ulong> Z) YGroup3Unzip(this IVectorTraits athis, Vector<ulong> data0, Vector<ulong> data1, Vector<ulong> data2) {
            var rt0 = athis.YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }


        /// <inheritdoc cref="Vectors.YGroup3UnzipX2{T}(Vector{T}, Vector{T}, Vector{T}, Vector{T}, Vector{T}, Vector{T})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<T> X, Vector<T> XB, Vector<T> Y, Vector<T> YB, Vector<T> Z, Vector<T> ZB) YGroup3UnzipX2<T>(this IVectorTraits athis, Vector<T> data0, Vector<T> data1, Vector<T> data2, Vector<T> data3, Vector<T> data4, Vector<T> data5) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3UnzipX2((Vector<float>)(object)data0, (Vector<float>)(object)data1, (Vector<float>)(object)data2, (Vector<float>)(object)data3, (Vector<float>)(object)data4, (Vector<float>)(object)data5);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3, (Vector<T>)(object)rt4, (Vector<T>)(object)rt5);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3UnzipX2((Vector<double>)(object)data0, (Vector<double>)(object)data1, (Vector<double>)(object)data2, (Vector<double>)(object)data3, (Vector<double>)(object)data4, (Vector<double>)(object)data5);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3, (Vector<T>)(object)rt4, (Vector<T>)(object)rt5);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3UnzipX2((Vector<sbyte>)(object)data0, (Vector<sbyte>)(object)data1, (Vector<sbyte>)(object)data2, (Vector<sbyte>)(object)data3, (Vector<sbyte>)(object)data4, (Vector<sbyte>)(object)data5);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3, (Vector<T>)(object)rt4, (Vector<T>)(object)rt5);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3UnzipX2((Vector<byte>)(object)data0, (Vector<byte>)(object)data1, (Vector<byte>)(object)data2, (Vector<byte>)(object)data3, (Vector<byte>)(object)data4, (Vector<byte>)(object)data5);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3, (Vector<T>)(object)rt4, (Vector<T>)(object)rt5);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3UnzipX2((Vector<short>)(object)data0, (Vector<short>)(object)data1, (Vector<short>)(object)data2, (Vector<short>)(object)data3, (Vector<short>)(object)data4, (Vector<short>)(object)data5);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3, (Vector<T>)(object)rt4, (Vector<T>)(object)rt5);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3UnzipX2((Vector<ushort>)(object)data0, (Vector<ushort>)(object)data1, (Vector<ushort>)(object)data2, (Vector<ushort>)(object)data3, (Vector<ushort>)(object)data4, (Vector<ushort>)(object)data5);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3, (Vector<T>)(object)rt4, (Vector<T>)(object)rt5);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3UnzipX2((Vector<int>)(object)data0, (Vector<int>)(object)data1, (Vector<int>)(object)data2, (Vector<int>)(object)data3, (Vector<int>)(object)data4, (Vector<int>)(object)data5);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3, (Vector<T>)(object)rt4, (Vector<T>)(object)rt5);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3UnzipX2((Vector<uint>)(object)data0, (Vector<uint>)(object)data1, (Vector<uint>)(object)data2, (Vector<uint>)(object)data3, (Vector<uint>)(object)data4, (Vector<uint>)(object)data5);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3, (Vector<T>)(object)rt4, (Vector<T>)(object)rt5);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3UnzipX2((Vector<long>)(object)data0, (Vector<long>)(object)data1, (Vector<long>)(object)data2, (Vector<long>)(object)data3, (Vector<long>)(object)data4, (Vector<long>)(object)data5);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3, (Vector<T>)(object)rt4, (Vector<T>)(object)rt5);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3UnzipX2((Vector<ulong>)(object)data0, (Vector<ulong>)(object)data1, (Vector<ulong>)(object)data2, (Vector<ulong>)(object)data3, (Vector<ulong>)(object)data4, (Vector<ulong>)(object)data5);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3, (Vector<T>)(object)rt4, (Vector<T>)(object)rt5);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vectors.YGroup3UnzipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<float> X, Vector<float> XB, Vector<float> Y, Vector<float> YB, Vector<float> Z, Vector<float> ZB) YGroup3UnzipX2(this IVectorTraits athis, Vector<float> data0, Vector<float> data1, Vector<float> data2, Vector<float> data3, Vector<float> data4, Vector<float> data5) {
            var rt0 = athis.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="Vectors.YGroup3UnzipX2(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<double> X, Vector<double> XB, Vector<double> Y, Vector<double> YB, Vector<double> Z, Vector<double> ZB) YGroup3UnzipX2(this IVectorTraits athis, Vector<double> data0, Vector<double> data1, Vector<double> data2, Vector<double> data3, Vector<double> data4, Vector<double> data5) {
            var rt0 = athis.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="Vectors.YGroup3UnzipX2(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> X, Vector<sbyte> XB, Vector<sbyte> Y, Vector<sbyte> YB, Vector<sbyte> Z, Vector<sbyte> ZB) YGroup3UnzipX2(this IVectorTraits athis, Vector<sbyte> data0, Vector<sbyte> data1, Vector<sbyte> data2, Vector<sbyte> data3, Vector<sbyte> data4, Vector<sbyte> data5) {
            var rt0 = athis.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="Vectors.YGroup3UnzipX2(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> X, Vector<byte> XB, Vector<byte> Y, Vector<byte> YB, Vector<byte> Z, Vector<byte> ZB) YGroup3UnzipX2(this IVectorTraits athis, Vector<byte> data0, Vector<byte> data1, Vector<byte> data2, Vector<byte> data3, Vector<byte> data4, Vector<byte> data5) {
            var rt0 = athis.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="Vectors.YGroup3UnzipX2(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> X, Vector<short> XB, Vector<short> Y, Vector<short> YB, Vector<short> Z, Vector<short> ZB) YGroup3UnzipX2(this IVectorTraits athis, Vector<short> data0, Vector<short> data1, Vector<short> data2, Vector<short> data3, Vector<short> data4, Vector<short> data5) {
            var rt0 = athis.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="Vectors.YGroup3UnzipX2(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> X, Vector<ushort> XB, Vector<ushort> Y, Vector<ushort> YB, Vector<ushort> Z, Vector<ushort> ZB) YGroup3UnzipX2(this IVectorTraits athis, Vector<ushort> data0, Vector<ushort> data1, Vector<ushort> data2, Vector<ushort> data3, Vector<ushort> data4, Vector<ushort> data5) {
            var rt0 = athis.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="Vectors.YGroup3UnzipX2(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> X, Vector<int> XB, Vector<int> Y, Vector<int> YB, Vector<int> Z, Vector<int> ZB) YGroup3UnzipX2(this IVectorTraits athis, Vector<int> data0, Vector<int> data1, Vector<int> data2, Vector<int> data3, Vector<int> data4, Vector<int> data5) {
            var rt0 = athis.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="Vectors.YGroup3UnzipX2(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> X, Vector<uint> XB, Vector<uint> Y, Vector<uint> YB, Vector<uint> Z, Vector<uint> ZB) YGroup3UnzipX2(this IVectorTraits athis, Vector<uint> data0, Vector<uint> data1, Vector<uint> data2, Vector<uint> data3, Vector<uint> data4, Vector<uint> data5) {
            var rt0 = athis.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="Vectors.YGroup3UnzipX2(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> X, Vector<long> XB, Vector<long> Y, Vector<long> YB, Vector<long> Z, Vector<long> ZB) YGroup3UnzipX2(this IVectorTraits athis, Vector<long> data0, Vector<long> data1, Vector<long> data2, Vector<long> data3, Vector<long> data4, Vector<long> data5) {
            var rt0 = athis.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="Vectors.YGroup3UnzipX2(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> X, Vector<ulong> XB, Vector<ulong> Y, Vector<ulong> YB, Vector<ulong> Z, Vector<ulong> ZB) YGroup3UnzipX2(this IVectorTraits athis, Vector<ulong> data0, Vector<ulong> data1, Vector<ulong> data2, Vector<ulong> data3, Vector<ulong> data4, Vector<ulong> data5) {
            var rt0 = athis.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }


        /// <inheritdoc cref="Vectors.YGroup3Zip{T}(Vector{T}, Vector{T}, Vector{T})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<T> Data0, Vector<T> Data1, Vector<T> Data2) YGroup3Zip<T>(this IVectorTraits athis, Vector<T> x, Vector<T> y, Vector<T> z) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Zip((Vector<float>)(object)x, (Vector<float>)(object)y, (Vector<float>)(object)z);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Zip((Vector<double>)(object)x, (Vector<double>)(object)y, (Vector<double>)(object)z);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Zip((Vector<sbyte>)(object)x, (Vector<sbyte>)(object)y, (Vector<sbyte>)(object)z);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Zip((Vector<byte>)(object)x, (Vector<byte>)(object)y, (Vector<byte>)(object)z);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Zip((Vector<short>)(object)x, (Vector<short>)(object)y, (Vector<short>)(object)z);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Zip((Vector<ushort>)(object)x, (Vector<ushort>)(object)y, (Vector<ushort>)(object)z);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Zip((Vector<int>)(object)x, (Vector<int>)(object)y, (Vector<int>)(object)z);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Zip((Vector<uint>)(object)x, (Vector<uint>)(object)y, (Vector<uint>)(object)z);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Zip((Vector<long>)(object)x, (Vector<long>)(object)y, (Vector<long>)(object)z);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Zip((Vector<ulong>)(object)x, (Vector<ulong>)(object)y, (Vector<ulong>)(object)z);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vectors.YGroup3Zip(Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<float> Data0, Vector<float> Data1, Vector<float> Data2) YGroup3Zip(this IVectorTraits athis, Vector<float> x, Vector<float> y, Vector<float> z) {
            var data0 = athis.YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="Vectors.YGroup3Zip(Vector{double}, Vector{double}, Vector{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<double> Data0, Vector<double> Data1, Vector<double> Data2) YGroup3Zip(this IVectorTraits athis, Vector<double> x, Vector<double> y, Vector<double> z) {
            var data0 = athis.YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="Vectors.YGroup3Zip(Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> Data0, Vector<sbyte> Data1, Vector<sbyte> Data2) YGroup3Zip(this IVectorTraits athis, Vector<sbyte> x, Vector<sbyte> y, Vector<sbyte> z) {
            var data0 = athis.YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="Vectors.YGroup3Zip(Vector{byte}, Vector{byte}, Vector{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> Data0, Vector<byte> Data1, Vector<byte> Data2) YGroup3Zip(this IVectorTraits athis, Vector<byte> x, Vector<byte> y, Vector<byte> z) {
            var data0 = athis.YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="Vectors.YGroup3Zip(Vector{short}, Vector{short}, Vector{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> Data0, Vector<short> Data1, Vector<short> Data2) YGroup3Zip(this IVectorTraits athis, Vector<short> x, Vector<short> y, Vector<short> z) {
            var data0 = athis.YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="Vectors.YGroup3Zip(Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> Data0, Vector<ushort> Data1, Vector<ushort> Data2) YGroup3Zip(this IVectorTraits athis, Vector<ushort> x, Vector<ushort> y, Vector<ushort> z) {
            var data0 = athis.YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="Vectors.YGroup3Zip(Vector{int}, Vector{int}, Vector{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> Data0, Vector<int> Data1, Vector<int> Data2) YGroup3Zip(this IVectorTraits athis, Vector<int> x, Vector<int> y, Vector<int> z) {
            var data0 = athis.YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="Vectors.YGroup3Zip(Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> Data0, Vector<uint> Data1, Vector<uint> Data2) YGroup3Zip(this IVectorTraits athis, Vector<uint> x, Vector<uint> y, Vector<uint> z) {
            var data0 = athis.YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="Vectors.YGroup3Zip(Vector{long}, Vector{long}, Vector{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> Data0, Vector<long> Data1, Vector<long> Data2) YGroup3Zip(this IVectorTraits athis, Vector<long> x, Vector<long> y, Vector<long> z) {
            var data0 = athis.YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="Vectors.YGroup3Zip(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> Data0, Vector<ulong> Data1, Vector<ulong> Data2) YGroup3Zip(this IVectorTraits athis, Vector<ulong> x, Vector<ulong> y, Vector<ulong> z) {
            var data0 = athis.YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }


        /// <inheritdoc cref="Vectors.YGroup3ZipX2{T}(Vector{T}, Vector{T}, Vector{T}, Vector{T}, Vector{T}, Vector{T})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<T> Data0, Vector<T> Data1, Vector<T> Data2, Vector<T> Data3, Vector<T> Data4, Vector<T> Data5) YGroup3ZipX2<T>(this IVectorTraits athis, Vector<T> x, Vector<T> xB, Vector<T> y, Vector<T> yB, Vector<T> z, Vector<T> zB) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3ZipX2((Vector<float>)(object)x, (Vector<float>)(object)xB, (Vector<float>)(object)y, (Vector<float>)(object)yB, (Vector<float>)(object)z, (Vector<float>)(object)zB);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3, (Vector<T>)(object)rt4, (Vector<T>)(object)rt5);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3ZipX2((Vector<double>)(object)x, (Vector<double>)(object)xB, (Vector<double>)(object)y, (Vector<double>)(object)yB, (Vector<double>)(object)z, (Vector<double>)(object)zB);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3, (Vector<T>)(object)rt4, (Vector<T>)(object)rt5);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3ZipX2((Vector<sbyte>)(object)x, (Vector<sbyte>)(object)xB, (Vector<sbyte>)(object)y, (Vector<sbyte>)(object)yB, (Vector<sbyte>)(object)z, (Vector<sbyte>)(object)zB);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3, (Vector<T>)(object)rt4, (Vector<T>)(object)rt5);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3ZipX2((Vector<byte>)(object)x, (Vector<byte>)(object)xB, (Vector<byte>)(object)y, (Vector<byte>)(object)yB, (Vector<byte>)(object)z, (Vector<byte>)(object)zB);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3, (Vector<T>)(object)rt4, (Vector<T>)(object)rt5);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3ZipX2((Vector<short>)(object)x, (Vector<short>)(object)xB, (Vector<short>)(object)y, (Vector<short>)(object)yB, (Vector<short>)(object)z, (Vector<short>)(object)zB);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3, (Vector<T>)(object)rt4, (Vector<T>)(object)rt5);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3ZipX2((Vector<ushort>)(object)x, (Vector<ushort>)(object)xB, (Vector<ushort>)(object)y, (Vector<ushort>)(object)yB, (Vector<ushort>)(object)z, (Vector<ushort>)(object)zB);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3, (Vector<T>)(object)rt4, (Vector<T>)(object)rt5);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3ZipX2((Vector<int>)(object)x, (Vector<int>)(object)xB, (Vector<int>)(object)y, (Vector<int>)(object)yB, (Vector<int>)(object)z, (Vector<int>)(object)zB);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3, (Vector<T>)(object)rt4, (Vector<T>)(object)rt5);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3ZipX2((Vector<uint>)(object)x, (Vector<uint>)(object)xB, (Vector<uint>)(object)y, (Vector<uint>)(object)yB, (Vector<uint>)(object)z, (Vector<uint>)(object)zB);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3, (Vector<T>)(object)rt4, (Vector<T>)(object)rt5);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3ZipX2((Vector<long>)(object)x, (Vector<long>)(object)xB, (Vector<long>)(object)y, (Vector<long>)(object)yB, (Vector<long>)(object)z, (Vector<long>)(object)zB);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3, (Vector<T>)(object)rt4, (Vector<T>)(object)rt5);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3ZipX2((Vector<ulong>)(object)x, (Vector<ulong>)(object)xB, (Vector<ulong>)(object)y, (Vector<ulong>)(object)yB, (Vector<ulong>)(object)z, (Vector<ulong>)(object)zB);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3, (Vector<T>)(object)rt4, (Vector<T>)(object)rt5);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vectors.YGroup3ZipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<float> Data0, Vector<float> Data1, Vector<float> Data2, Vector<float> Data3, Vector<float> Data4, Vector<float> Data5) YGroup3ZipX2(this IVectorTraits athis, Vector<float> x, Vector<float> xB, Vector<float> y, Vector<float> yB, Vector<float> z, Vector<float> zB) {
            var data0 = athis.YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="Vectors.YGroup3ZipX2(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<double> Data0, Vector<double> Data1, Vector<double> Data2, Vector<double> Data3, Vector<double> Data4, Vector<double> Data5) YGroup3ZipX2(this IVectorTraits athis, Vector<double> x, Vector<double> xB, Vector<double> y, Vector<double> yB, Vector<double> z, Vector<double> zB) {
            var data0 = athis.YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="Vectors.YGroup3ZipX2(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> Data0, Vector<sbyte> Data1, Vector<sbyte> Data2, Vector<sbyte> Data3, Vector<sbyte> Data4, Vector<sbyte> Data5) YGroup3ZipX2(this IVectorTraits athis, Vector<sbyte> x, Vector<sbyte> xB, Vector<sbyte> y, Vector<sbyte> yB, Vector<sbyte> z, Vector<sbyte> zB) {
            var data0 = athis.YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="Vectors.YGroup3ZipX2(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> Data0, Vector<byte> Data1, Vector<byte> Data2, Vector<byte> Data3, Vector<byte> Data4, Vector<byte> Data5) YGroup3ZipX2(this IVectorTraits athis, Vector<byte> x, Vector<byte> xB, Vector<byte> y, Vector<byte> yB, Vector<byte> z, Vector<byte> zB) {
            var data0 = athis.YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="Vectors.YGroup3ZipX2(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> Data0, Vector<short> Data1, Vector<short> Data2, Vector<short> Data3, Vector<short> Data4, Vector<short> Data5) YGroup3ZipX2(this IVectorTraits athis, Vector<short> x, Vector<short> xB, Vector<short> y, Vector<short> yB, Vector<short> z, Vector<short> zB) {
            var data0 = athis.YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="Vectors.YGroup3ZipX2(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> Data0, Vector<ushort> Data1, Vector<ushort> Data2, Vector<ushort> Data3, Vector<ushort> Data4, Vector<ushort> Data5) YGroup3ZipX2(this IVectorTraits athis, Vector<ushort> x, Vector<ushort> xB, Vector<ushort> y, Vector<ushort> yB, Vector<ushort> z, Vector<ushort> zB) {
            var data0 = athis.YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="Vectors.YGroup3ZipX2(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> Data0, Vector<int> Data1, Vector<int> Data2, Vector<int> Data3, Vector<int> Data4, Vector<int> Data5) YGroup3ZipX2(this IVectorTraits athis, Vector<int> x, Vector<int> xB, Vector<int> y, Vector<int> yB, Vector<int> z, Vector<int> zB) {
            var data0 = athis.YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="Vectors.YGroup3ZipX2(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> Data0, Vector<uint> Data1, Vector<uint> Data2, Vector<uint> Data3, Vector<uint> Data4, Vector<uint> Data5) YGroup3ZipX2(this IVectorTraits athis, Vector<uint> x, Vector<uint> xB, Vector<uint> y, Vector<uint> yB, Vector<uint> z, Vector<uint> zB) {
            var data0 = athis.YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="Vectors.YGroup3ZipX2(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> Data0, Vector<long> Data1, Vector<long> Data2, Vector<long> Data3, Vector<long> Data4, Vector<long> Data5) YGroup3ZipX2(this IVectorTraits athis, Vector<long> x, Vector<long> xB, Vector<long> y, Vector<long> yB, Vector<long> z, Vector<long> zB) {
            var data0 = athis.YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="Vectors.YGroup3ZipX2(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> Data0, Vector<ulong> Data1, Vector<ulong> Data2, Vector<ulong> Data3, Vector<ulong> Data4, Vector<ulong> Data5) YGroup3ZipX2(this IVectorTraits athis, Vector<ulong> x, Vector<ulong> xB, Vector<ulong> y, Vector<ulong> yB, Vector<ulong> z, Vector<ulong> zB) {
            var data0 = athis.YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }


        /// <inheritdoc cref="Vectors.YGroup4ToGroup3{T}(Vector{T}, Vector{T}, Vector{T}, Vector{T})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<T> Result0, Vector<T> Result1, Vector<T> Result2) YGroup4ToGroup3<T>(this IVectorTraits athis, Vector<T> data0, Vector<T> data1, Vector<T> data2, Vector<T> data3) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup4ToGroup3(data0.As<T, float>(), data1.As<T, float>(), data2.As<T, float>(), data3.As<T, float>());
                return (rt0.As<float, T>(), rt1.As<float, T>(), rt2.As<float, T>());
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup4ToGroup3(data0.As<T, double>(), data1.As<T, double>(), data2.As<T, double>(), data3.As<T, double>());
                return (rt0.As<double, T>(), rt1.As<double, T>(), rt2.As<double, T>());
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup4ToGroup3(data0.As<T, sbyte>(), data1.As<T, sbyte>(), data2.As<T, sbyte>(), data3.As<T, sbyte>());
                return (rt0.As<sbyte, T>(), rt1.As<sbyte, T>(), rt2.As<sbyte, T>());
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup4ToGroup3(data0.As<T, byte>(), data1.As<T, byte>(), data2.As<T, byte>(), data3.As<T, byte>());
                return (rt0.As<byte, T>(), rt1.As<byte, T>(), rt2.As<byte, T>());
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup4ToGroup3(data0.As<T, short>(), data1.As<T, short>(), data2.As<T, short>(), data3.As<T, short>());
                return (rt0.As<short, T>(), rt1.As<short, T>(), rt2.As<short, T>());
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup4ToGroup3(data0.As<T, ushort>(), data1.As<T, ushort>(), data2.As<T, ushort>(), data3.As<T, ushort>());
                return (rt0.As<ushort, T>(), rt1.As<ushort, T>(), rt2.As<ushort, T>());
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup4ToGroup3(data0.As<T, int>(), data1.As<T, int>(), data2.As<T, int>(), data3.As<T, int>());
                return (rt0.As<int, T>(), rt1.As<int, T>(), rt2.As<int, T>());
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup4ToGroup3(data0.As<T, uint>(), data1.As<T, uint>(), data2.As<T, uint>(), data3.As<T, uint>());
                return (rt0.As<uint, T>(), rt1.As<uint, T>(), rt2.As<uint, T>());
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup4ToGroup3(data0.As<T, long>(), data1.As<T, long>(), data2.As<T, long>(), data3.As<T, long>());
                return (rt0.As<long, T>(), rt1.As<long, T>(), rt2.As<long, T>());
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup4ToGroup3(data0.As<T, ulong>(), data1.As<T, ulong>(), data2.As<T, ulong>(), data3.As<T, ulong>());
                return (rt0.As<ulong, T>(), rt1.As<ulong, T>(), rt2.As<ulong, T>());
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vectors.YGroup4ToGroup3(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<float> Result0, Vector<float> Result1, Vector<float> Result2) YGroup4ToGroup3(this IVectorTraits athis, Vector<float> data0, Vector<float> data1, Vector<float> data2, Vector<float> data3) {
            var rt0 = athis.YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vectors.YGroup4ToGroup3(Vector{double}, Vector{double}, Vector{double}, Vector{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<double> Result0, Vector<double> Result1, Vector<double> Result2) YGroup4ToGroup3(this IVectorTraits athis, Vector<double> data0, Vector<double> data1, Vector<double> data2, Vector<double> data3) {
            var rt0 = athis.YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vectors.YGroup4ToGroup3(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> Result0, Vector<sbyte> Result1, Vector<sbyte> Result2) YGroup4ToGroup3(this IVectorTraits athis, Vector<sbyte> data0, Vector<sbyte> data1, Vector<sbyte> data2, Vector<sbyte> data3) {
            var rt0 = athis.YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vectors.YGroup4ToGroup3(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> Result0, Vector<byte> Result1, Vector<byte> Result2) YGroup4ToGroup3(this IVectorTraits athis, Vector<byte> data0, Vector<byte> data1, Vector<byte> data2, Vector<byte> data3) {
            var rt0 = athis.YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vectors.YGroup4ToGroup3(Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> Result0, Vector<short> Result1, Vector<short> Result2) YGroup4ToGroup3(this IVectorTraits athis, Vector<short> data0, Vector<short> data1, Vector<short> data2, Vector<short> data3) {
            var rt0 = athis.YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vectors.YGroup4ToGroup3(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> Result0, Vector<ushort> Result1, Vector<ushort> Result2) YGroup4ToGroup3(this IVectorTraits athis, Vector<ushort> data0, Vector<ushort> data1, Vector<ushort> data2, Vector<ushort> data3) {
            var rt0 = athis.YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vectors.YGroup4ToGroup3(Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> Result0, Vector<int> Result1, Vector<int> Result2) YGroup4ToGroup3(this IVectorTraits athis, Vector<int> data0, Vector<int> data1, Vector<int> data2, Vector<int> data3) {
            var rt0 = athis.YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vectors.YGroup4ToGroup3(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> Result0, Vector<uint> Result1, Vector<uint> Result2) YGroup4ToGroup3(this IVectorTraits athis, Vector<uint> data0, Vector<uint> data1, Vector<uint> data2, Vector<uint> data3) {
            var rt0 = athis.YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vectors.YGroup4ToGroup3(Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> Result0, Vector<long> Result1, Vector<long> Result2) YGroup4ToGroup3(this IVectorTraits athis, Vector<long> data0, Vector<long> data1, Vector<long> data2, Vector<long> data3) {
            var rt0 = athis.YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vectors.YGroup4ToGroup3(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> Result0, Vector<ulong> Result1, Vector<ulong> Result2) YGroup4ToGroup3(this IVectorTraits athis, Vector<ulong> data0, Vector<ulong> data1, Vector<ulong> data2, Vector<ulong> data3) {
            var rt0 = athis.YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }


#if BCL_TYPE_INT128

        /// <inheritdoc cref="Vectors.YGroup4Unzip(Vector{ExInt128}, Vector{ExInt128}, Vector{ExInt128}, Vector{ExInt128}, out Vector{ExInt128}, out Vector{ExInt128}, out Vector{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<Int128> YGroup4Unzip(this IVectorTraits athis, Vector<Int128> data0, Vector<Int128> data1, Vector<Int128> data2, Vector<Int128> data3, out Vector<Int128> y, out Vector<Int128> z, out Vector<Int128> w) {
            var d0 = athis.YGroup4Unzip(data0.ExAsExInt128(), data1.ExAsExInt128(), data2.ExAsExInt128(), data3.ExAsExInt128(), out var d1, out var d2, out var d3);
            y = d1.ExAsInt128();
            z = d2.ExAsInt128();
            w = d3.ExAsInt128();
            return d0.ExAsInt128();
        }

        /// <inheritdoc cref="Vectors.YGroup4Unzip(Vector{ExUInt128}, Vector{ExUInt128}, Vector{ExUInt128}, Vector{ExUInt128}, out Vector{ExUInt128}, out Vector{ExUInt128}, out Vector{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<UInt128> YGroup4Unzip(this IVectorTraits athis, Vector<UInt128> data0, Vector<UInt128> data1, Vector<UInt128> data2, Vector<UInt128> data3, out Vector<UInt128> y, out Vector<UInt128> z, out Vector<UInt128> w) {
            var d0 = athis.YGroup4Unzip(data0.ExAsExUInt128(), data1.ExAsExUInt128(), data2.ExAsExUInt128(), data3.ExAsExUInt128(), out var d1, out var d2, out var d3);
            y = d1.ExAsUInt128();
            z = d2.ExAsUInt128();
            w = d3.ExAsUInt128();
            return d0.ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="Vectors.YGroup4Unzip{T}(Vector{T}, Vector{T}, Vector{T}, Vector{T})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<T> X, Vector<T> Y, Vector<T> Z, Vector<T> W) YGroup4Unzip<T>(this IVectorTraits athis, Vector<T> data0, Vector<T> data1, Vector<T> data2, Vector<T> data3) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip((Vector<float>)(object)data0, (Vector<float>)(object)data1, (Vector<float>)(object)data2, (Vector<float>)(object)data3);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip((Vector<double>)(object)data0, (Vector<double>)(object)data1, (Vector<double>)(object)data2, (Vector<double>)(object)data3);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip((Vector<sbyte>)(object)data0, (Vector<sbyte>)(object)data1, (Vector<sbyte>)(object)data2, (Vector<sbyte>)(object)data3);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip((Vector<byte>)(object)data0, (Vector<byte>)(object)data1, (Vector<byte>)(object)data2, (Vector<byte>)(object)data3);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip((Vector<short>)(object)data0, (Vector<short>)(object)data1, (Vector<short>)(object)data2, (Vector<short>)(object)data3);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip((Vector<ushort>)(object)data0, (Vector<ushort>)(object)data1, (Vector<ushort>)(object)data2, (Vector<ushort>)(object)data3);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip((Vector<int>)(object)data0, (Vector<int>)(object)data1, (Vector<int>)(object)data2, (Vector<int>)(object)data3);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip((Vector<uint>)(object)data0, (Vector<uint>)(object)data1, (Vector<uint>)(object)data2, (Vector<uint>)(object)data3);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip((Vector<long>)(object)data0, (Vector<long>)(object)data1, (Vector<long>)(object)data2, (Vector<long>)(object)data3);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip((Vector<ulong>)(object)data0, (Vector<ulong>)(object)data1, (Vector<ulong>)(object)data2, (Vector<ulong>)(object)data3);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(ExInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip((Vector<ExInt128>)(object)data0, (Vector<ExInt128>)(object)data1, (Vector<ExInt128>)(object)data2, (Vector<ExInt128>)(object)data3);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(ExUInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip((Vector<ExUInt128>)(object)data0, (Vector<ExUInt128>)(object)data1, (Vector<ExUInt128>)(object)data2, (Vector<ExUInt128>)(object)data3);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip((Vector<Int128>)(object)data0, (Vector<Int128>)(object)data1, (Vector<Int128>)(object)data2, (Vector<Int128>)(object)data3);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(UInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip((Vector<UInt128>)(object)data0, (Vector<UInt128>)(object)data1, (Vector<UInt128>)(object)data2, (Vector<UInt128>)(object)data3);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
#endif // BCL_TYPE_INT128
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vectors.YGroup4Unzip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<float> X, Vector<float> Y, Vector<float> Z, Vector<float> W) YGroup4Unzip(this IVectorTraits athis, Vector<float> data0, Vector<float> data1, Vector<float> data2, Vector<float> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }


        /// <inheritdoc cref="Vectors.YGroup4Unzip(Vector{double}, Vector{double}, Vector{double}, Vector{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<double> X, Vector<double> Y, Vector<double> Z, Vector<double> W) YGroup4Unzip(this IVectorTraits athis, Vector<double> data0, Vector<double> data1, Vector<double> data2, Vector<double> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vectors.YGroup4Unzip(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> X, Vector<sbyte> Y, Vector<sbyte> Z, Vector<sbyte> W) YGroup4Unzip(this IVectorTraits athis, Vector<sbyte> data0, Vector<sbyte> data1, Vector<sbyte> data2, Vector<sbyte> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vectors.YGroup4Unzip(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> X, Vector<byte> Y, Vector<byte> Z, Vector<byte> W) YGroup4Unzip(this IVectorTraits athis, Vector<byte> data0, Vector<byte> data1, Vector<byte> data2, Vector<byte> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vectors.YGroup4Unzip(Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> X, Vector<short> Y, Vector<short> Z, Vector<short> W) YGroup4Unzip(this IVectorTraits athis, Vector<short> data0, Vector<short> data1, Vector<short> data2, Vector<short> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vectors.YGroup4Unzip(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> X, Vector<ushort> Y, Vector<ushort> Z, Vector<ushort> W) YGroup4Unzip(this IVectorTraits athis, Vector<ushort> data0, Vector<ushort> data1, Vector<ushort> data2, Vector<ushort> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vectors.YGroup4Unzip(Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> X, Vector<int> Y, Vector<int> Z, Vector<int> W) YGroup4Unzip(this IVectorTraits athis, Vector<int> data0, Vector<int> data1, Vector<int> data2, Vector<int> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vectors.YGroup4Unzip(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> X, Vector<uint> Y, Vector<uint> Z, Vector<uint> W) YGroup4Unzip(this IVectorTraits athis, Vector<uint> data0, Vector<uint> data1, Vector<uint> data2, Vector<uint> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vectors.YGroup4Unzip(Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> X, Vector<long> Y, Vector<long> Z, Vector<long> W) YGroup4Unzip(this IVectorTraits athis, Vector<long> data0, Vector<long> data1, Vector<long> data2, Vector<long> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vectors.YGroup4Unzip(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> X, Vector<ulong> Y, Vector<ulong> Z, Vector<ulong> W) YGroup4Unzip(this IVectorTraits athis, Vector<ulong> data0, Vector<ulong> data1, Vector<ulong> data2, Vector<ulong> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vectors.YGroup4Unzip(Vector{ExInt128}, Vector{ExInt128}, Vector{ExInt128}, Vector{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ExInt128> X, Vector<ExInt128> Y, Vector<ExInt128> Z, Vector<ExInt128> W) YGroup4Unzip(this IVectorTraits athis, Vector<ExInt128> data0, Vector<ExInt128> data1, Vector<ExInt128> data2, Vector<ExInt128> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vectors.YGroup4Unzip(Vector{ExUInt128}, Vector{ExUInt128}, Vector{ExUInt128}, Vector{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ExUInt128> X, Vector<ExUInt128> Y, Vector<ExUInt128> Z, Vector<ExUInt128> W) YGroup4Unzip(this IVectorTraits athis, Vector<ExUInt128> data0, Vector<ExUInt128> data1, Vector<ExUInt128> data2, Vector<ExUInt128> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="Vectors.YGroup4Unzip(Vector{Int128}, Vector{Int128}, Vector{Int128}, Vector{Int128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<Int128> X, Vector<Int128> Y, Vector<Int128> Z, Vector<Int128> W) YGroup4Unzip(this IVectorTraits athis, Vector<Int128> data0, Vector<Int128> data1, Vector<Int128> data2, Vector<Int128> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vectors.YGroup4Unzip(Vector{UInt128}, Vector{UInt128}, Vector{UInt128}, Vector{UInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<UInt128> X, Vector<UInt128> Y, Vector<UInt128> Z, Vector<UInt128> W) YGroup4Unzip(this IVectorTraits athis, Vector<UInt128> data0, Vector<UInt128> data1, Vector<UInt128> data2, Vector<UInt128> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

#endif // BCL_TYPE_INT128


#if BCL_TYPE_INT128

        /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{ExInt128}, Vector{ExInt128}, Vector{ExInt128}, Vector{ExInt128}, out Vector{ExInt128}, out Vector{ExInt128}, out Vector{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<Int128> YGroup4Zip(this IVectorTraits athis, Vector<Int128> x, Vector<Int128> y, Vector<Int128> z, Vector<Int128> w, out Vector<Int128> data1, out Vector<Int128> data2, out Vector<Int128> data3) {
            var d0 = athis.YGroup4Zip(x.ExAsExInt128(), y.ExAsExInt128(), z.ExAsExInt128(), w.ExAsExInt128(), out var d1, out var d2, out var d3);
            data1 = d1.ExAsInt128();
            data2 = d2.ExAsInt128();
            data3 = d3.ExAsInt128();
            return d0.ExAsInt128();
        }

        /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{ExUInt128}, Vector{ExUInt128}, Vector{ExUInt128}, Vector{ExUInt128}, out Vector{ExUInt128}, out Vector{ExUInt128}, out Vector{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<UInt128> YGroup4Zip(this IVectorTraits athis, Vector<UInt128> x, Vector<UInt128> y, Vector<UInt128> z, Vector<UInt128> w, out Vector<UInt128> data1, out Vector<UInt128> data2, out Vector<UInt128> data3) {
            var d0 = athis.YGroup4Zip(x.ExAsExUInt128(), y.ExAsExUInt128(), z.ExAsExUInt128(), w.ExAsExUInt128(), out var d1, out var d2, out var d3);
            data1 = d1.ExAsUInt128();
            data2 = d2.ExAsUInt128();
            data3 = d3.ExAsUInt128();
            return d0.ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<T> Data0, Vector<T> Data1, Vector<T> Data2, Vector<T> Data3) YGroup4Zip<T>(this IVectorTraits athis, Vector<T> x, Vector<T> y, Vector<T> z, Vector<T> w) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip((Vector<float>)(object)x, (Vector<float>)(object)y, (Vector<float>)(object)z, (Vector<float>)(object)w);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip((Vector<double>)(object)x, (Vector<double>)(object)y, (Vector<double>)(object)z, (Vector<double>)(object)w);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip((Vector<sbyte>)(object)x, (Vector<sbyte>)(object)y, (Vector<sbyte>)(object)z, (Vector<sbyte>)(object)w);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip((Vector<byte>)(object)x, (Vector<byte>)(object)y, (Vector<byte>)(object)z, (Vector<byte>)(object)w);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip((Vector<short>)(object)x, (Vector<short>)(object)y, (Vector<short>)(object)z, (Vector<short>)(object)w);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip((Vector<ushort>)(object)x, (Vector<ushort>)(object)y, (Vector<ushort>)(object)z, (Vector<ushort>)(object)w);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip((Vector<int>)(object)x, (Vector<int>)(object)y, (Vector<int>)(object)z, (Vector<int>)(object)w);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip((Vector<uint>)(object)x, (Vector<uint>)(object)y, (Vector<uint>)(object)z, (Vector<uint>)(object)w);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip((Vector<long>)(object)x, (Vector<long>)(object)y, (Vector<long>)(object)z, (Vector<long>)(object)w);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip((Vector<ulong>)(object)x, (Vector<ulong>)(object)y, (Vector<ulong>)(object)z, (Vector<ulong>)(object)w);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(ExInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip((Vector<ExInt128>)(object)x, (Vector<ExInt128>)(object)y, (Vector<ExInt128>)(object)z, (Vector<ExInt128>)(object)w);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(ExUInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip((Vector<ExUInt128>)(object)x, (Vector<ExUInt128>)(object)y, (Vector<ExUInt128>)(object)z, (Vector<ExUInt128>)(object)w);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip((Vector<Int128>)(object)x, (Vector<Int128>)(object)y, (Vector<Int128>)(object)z, (Vector<Int128>)(object)w);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(UInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip((Vector<UInt128>)(object)x, (Vector<UInt128>)(object)y, (Vector<UInt128>)(object)z, (Vector<UInt128>)(object)w);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
#endif // BCL_TYPE_INT128
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vectors.YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<float> Data0, Vector<float> Data1, Vector<float> Data2, Vector<float> Data3) YGroup4Zip(this IVectorTraits athis, Vector<float> x, Vector<float> y, Vector<float> z, Vector<float> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<double> Data0, Vector<double> Data1, Vector<double> Data2, Vector<double> Data3) YGroup4Zip(this IVectorTraits athis, Vector<double> x, Vector<double> y, Vector<double> z, Vector<double> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> Data0, Vector<sbyte> Data1, Vector<sbyte> Data2, Vector<sbyte> Data3) YGroup4Zip(this IVectorTraits athis, Vector<sbyte> x, Vector<sbyte> y, Vector<sbyte> z, Vector<sbyte> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> Data0, Vector<byte> Data1, Vector<byte> Data2, Vector<byte> Data3) YGroup4Zip(this IVectorTraits athis, Vector<byte> x, Vector<byte> y, Vector<byte> z, Vector<byte> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> Data0, Vector<short> Data1, Vector<short> Data2, Vector<short> Data3) YGroup4Zip(this IVectorTraits athis, Vector<short> x, Vector<short> y, Vector<short> z, Vector<short> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> Data0, Vector<ushort> Data1, Vector<ushort> Data2, Vector<ushort> Data3) YGroup4Zip(this IVectorTraits athis, Vector<ushort> x, Vector<ushort> y, Vector<ushort> z, Vector<ushort> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> Data0, Vector<int> Data1, Vector<int> Data2, Vector<int> Data3) YGroup4Zip(this IVectorTraits athis, Vector<int> x, Vector<int> y, Vector<int> z, Vector<int> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> Data0, Vector<uint> Data1, Vector<uint> Data2, Vector<uint> Data3) YGroup4Zip(this IVectorTraits athis, Vector<uint> x, Vector<uint> y, Vector<uint> z, Vector<uint> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> Data0, Vector<long> Data1, Vector<long> Data2, Vector<long> Data3) YGroup4Zip(this IVectorTraits athis, Vector<long> x, Vector<long> y, Vector<long> z, Vector<long> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> Data0, Vector<ulong> Data1, Vector<ulong> Data2, Vector<ulong> Data3) YGroup4Zip(this IVectorTraits athis, Vector<ulong> x, Vector<ulong> y, Vector<ulong> z, Vector<ulong> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ExInt128> Data0, Vector<ExInt128> Data1, Vector<ExInt128> Data2, Vector<ExInt128> Data3) YGroup4Zip(this IVectorTraits athis, Vector<ExInt128> x, Vector<ExInt128> y, Vector<ExInt128> z, Vector<ExInt128> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ExUInt128> Data0, Vector<ExUInt128> Data1, Vector<ExUInt128> Data2, Vector<ExUInt128> Data3) YGroup4Zip(this IVectorTraits athis, Vector<ExUInt128> x, Vector<ExUInt128> y, Vector<ExUInt128> z, Vector<ExUInt128> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<Int128> Data0, Vector<Int128> Data1, Vector<Int128> Data2, Vector<Int128> Data3) YGroup4Zip(this IVectorTraits athis, Vector<Int128> x, Vector<Int128> y, Vector<Int128> z, Vector<Int128> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<UInt128> Data0, Vector<UInt128> Data1, Vector<UInt128> Data2, Vector<UInt128> Data3) YGroup4Zip(this IVectorTraits athis, Vector<UInt128> x, Vector<UInt128> y, Vector<UInt128> z, Vector<UInt128> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

#endif // BCL_TYPE_INT128

    }
}
