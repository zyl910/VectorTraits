#if NET7_0_OR_GREATER
#define BCL_TYPE_INT128
#endif // NET7_0_OR_GREATER

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Runtime.CompilerServices;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.ExTypes;
using static Zyl.VectorTraits.Impl.VectorMessageFormats;

namespace Zyl.VectorTraits.Impl {
    partial class IWVectorTraits256_Extensions {
#if NETCOREAPP3_0_OR_GREATER

#if BCL_TYPE_INT128

        /// <inheritdoc cref="Vector256s.YGroup2Unzip(Vector256{ExInt128}, Vector256{ExInt128}, out Vector256{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<Int128> YGroup2Unzip(this IWVectorTraits256 athis, Vector256<Int128> data0, Vector256<Int128> data1, out Vector256<Int128> y) {
            var d0 = athis.YGroup2Unzip(data0.ExAsExInt128(), data1.ExAsExInt128(), out var d1);
            y = d1.ExAsInt128();
            return d0.ExAsInt128();
        }

        /// <inheritdoc cref="Vector256s.YGroup2Unzip(Vector256{ExUInt128}, Vector256{ExUInt128}, out Vector256{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<UInt128> YGroup2Unzip(this IWVectorTraits256 athis, Vector256<UInt128> data0, Vector256<UInt128> data1, out Vector256<UInt128> y) {
            var d0 = athis.YGroup2Unzip(data0.ExAsExUInt128(), data1.ExAsExUInt128(), out var d1);
            y = d1.ExAsUInt128();
            return d0.ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="Vector256s.YGroup2Unzip{T}(Vector256{T}, Vector256{T})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static (Vector256<T> X, Vector256<T> Y) YGroup2Unzip<T>(this IWVectorTraits256 athis, Vector256<T> data0, Vector256<T> data1) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip((Vector256<float>)(object)data0, (Vector256<float>)(object)data1);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip((Vector256<double>)(object)data0, (Vector256<double>)(object)data1);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip((Vector256<sbyte>)(object)data0, (Vector256<sbyte>)(object)data1);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip((Vector256<byte>)(object)data0, (Vector256<byte>)(object)data1);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip((Vector256<short>)(object)data0, (Vector256<short>)(object)data1);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip((Vector256<ushort>)(object)data0, (Vector256<ushort>)(object)data1);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip((Vector256<int>)(object)data0, (Vector256<int>)(object)data1);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip((Vector256<uint>)(object)data0, (Vector256<uint>)(object)data1);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip((Vector256<long>)(object)data0, (Vector256<long>)(object)data1);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip((Vector256<ulong>)(object)data0, (Vector256<ulong>)(object)data1);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1);
            } else if (typeof(ExInt128) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip((Vector256<ExInt128>)(object)data0, (Vector256<ExInt128>)(object)data1);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1);
            } else if (typeof(ExUInt128) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip((Vector256<ExUInt128>)(object)data0, (Vector256<ExUInt128>)(object)data1);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1);
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip((Vector256<Int128>)(object)data0, (Vector256<Int128>)(object)data1);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1);
            } else if (typeof(UInt128) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip((Vector256<UInt128>)(object)data0, (Vector256<UInt128>)(object)data1);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1);
#endif // BCL_TYPE_INT128
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector256s.YGroup2Unzip(Vector256{float}, Vector256{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<float> X, Vector256<float> Y) YGroup2Unzip(this IWVectorTraits256 athis, Vector256<float> data0, Vector256<float> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector256s.YGroup2Unzip(Vector256{double}, Vector256{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<double> X, Vector256<double> Y) YGroup2Unzip(this IWVectorTraits256 athis, Vector256<double> data0, Vector256<double> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector256s.YGroup2Unzip(Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<sbyte> X, Vector256<sbyte> Y) YGroup2Unzip(this IWVectorTraits256 athis, Vector256<sbyte> data0, Vector256<sbyte> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector256s.YGroup2Unzip(Vector256{byte}, Vector256{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<byte> X, Vector256<byte> Y) YGroup2Unzip(this IWVectorTraits256 athis, Vector256<byte> data0, Vector256<byte> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector256s.YGroup2Unzip(Vector256{short}, Vector256{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> X, Vector256<short> Y) YGroup2Unzip(this IWVectorTraits256 athis, Vector256<short> data0, Vector256<short> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector256s.YGroup2Unzip(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ushort> X, Vector256<ushort> Y) YGroup2Unzip(this IWVectorTraits256 athis, Vector256<ushort> data0, Vector256<ushort> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector256s.YGroup2Unzip(Vector256{int}, Vector256{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> X, Vector256<int> Y) YGroup2Unzip(this IWVectorTraits256 athis, Vector256<int> data0, Vector256<int> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector256s.YGroup2Unzip(Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<uint> X, Vector256<uint> Y) YGroup2Unzip(this IWVectorTraits256 athis, Vector256<uint> data0, Vector256<uint> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector256s.YGroup2Unzip(Vector256{long}, Vector256{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> X, Vector256<long> Y) YGroup2Unzip(this IWVectorTraits256 athis, Vector256<long> data0, Vector256<long> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector256s.YGroup2Unzip(Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ulong> X, Vector256<ulong> Y) YGroup2Unzip(this IWVectorTraits256 athis, Vector256<ulong> data0, Vector256<ulong> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector256s.YGroup2Unzip(Vector256{ExInt128}, Vector256{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ExInt128> X, Vector256<ExInt128> Y) YGroup2Unzip(this IWVectorTraits256 athis, Vector256<ExInt128> data0, Vector256<ExInt128> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector256s.YGroup2Unzip(Vector256{ExUInt128}, Vector256{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ExUInt128> X, Vector256<ExUInt128> Y) YGroup2Unzip(this IWVectorTraits256 athis, Vector256<ExUInt128> data0, Vector256<ExUInt128> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="Vector256s.YGroup2Unzip(Vector256{Int128}, Vector256{Int128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<Int128> X, Vector256<Int128> Y) YGroup2Unzip(this IWVectorTraits256 athis, Vector256<Int128> data0, Vector256<Int128> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector256s.YGroup2Unzip(Vector256{UInt128}, Vector256{UInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<UInt128> X, Vector256<UInt128> Y) YGroup2Unzip(this IWVectorTraits256 athis, Vector256<UInt128> data0, Vector256<UInt128> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="Vector256s.YGroup2UnzipEven(Vector256{int}, Vector256{int})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static Vector256<T> YGroup2UnzipEven<T>(this IWVectorTraits256 athis, Vector256<T> data0, Vector256<T> data1) where T : struct {
            if (typeof(float) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2UnzipEven((Vector256<float>)(object)data0, (Vector256<float>)(object)data1);
            } else if (typeof(double) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2UnzipEven((Vector256<double>)(object)data0, (Vector256<double>)(object)data1);
            } else if (typeof(sbyte) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2UnzipEven((Vector256<sbyte>)(object)data0, (Vector256<sbyte>)(object)data1);
            } else if (typeof(byte) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2UnzipEven((Vector256<byte>)(object)data0, (Vector256<byte>)(object)data1);
            } else if (typeof(short) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2UnzipEven((Vector256<short>)(object)data0, (Vector256<short>)(object)data1);
            } else if (typeof(ushort) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2UnzipEven((Vector256<ushort>)(object)data0, (Vector256<ushort>)(object)data1);
            } else if (typeof(int) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2UnzipEven((Vector256<int>)(object)data0, (Vector256<int>)(object)data1);
            } else if (typeof(uint) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2UnzipEven((Vector256<uint>)(object)data0, (Vector256<uint>)(object)data1);
            } else if (typeof(long) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2UnzipEven((Vector256<long>)(object)data0, (Vector256<long>)(object)data1);
            } else if (typeof(ulong) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2UnzipEven((Vector256<ulong>)(object)data0, (Vector256<ulong>)(object)data1);
            } else if (typeof(ExInt128) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2UnzipEven((Vector256<ExInt128>)(object)data0, (Vector256<ExInt128>)(object)data1);
            } else if (typeof(ExUInt128) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2UnzipEven((Vector256<ExUInt128>)(object)data0, (Vector256<ExUInt128>)(object)data1);
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2UnzipEven((Vector256<Int128>)(object)data0, (Vector256<Int128>)(object)data1);
            } else if (typeof(UInt128) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2UnzipEven((Vector256<UInt128>)(object)data0, (Vector256<UInt128>)(object)data1);
#endif // BCL_TYPE_INT128
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="Vector256s.YGroup2UnzipEven(Vector256{ExInt128}, Vector256{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<Int128> YGroup2UnzipEven(this IWVectorTraits256 athis, Vector256<Int128> data0, Vector256<Int128> data1) {
            return athis.YGroup2UnzipEven(data0.ExAsExInt128(), data1.ExAsExInt128()).ExAsInt128();
        }

        /// <inheritdoc cref="Vector256s.YGroup2UnzipEven(Vector256{ExUInt128}, Vector256{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<UInt128> YGroup2UnzipEven(this IWVectorTraits256 athis, Vector256<UInt128> data0, Vector256<UInt128> data1) {
            return athis.YGroup2UnzipEven(data0.ExAsExUInt128(), data1.ExAsExUInt128()).ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="Vector256s.YGroup2UnzipOdd(Vector256{int}, Vector256{int})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static Vector256<T> YGroup2UnzipOdd<T>(this IWVectorTraits256 athis, Vector256<T> data0, Vector256<T> data1) where T : struct {
            if (typeof(float) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2UnzipOdd((Vector256<float>)(object)data0, (Vector256<float>)(object)data1);
            } else if (typeof(double) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2UnzipOdd((Vector256<double>)(object)data0, (Vector256<double>)(object)data1);
            } else if (typeof(sbyte) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2UnzipOdd((Vector256<sbyte>)(object)data0, (Vector256<sbyte>)(object)data1);
            } else if (typeof(byte) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2UnzipOdd((Vector256<byte>)(object)data0, (Vector256<byte>)(object)data1);
            } else if (typeof(short) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2UnzipOdd((Vector256<short>)(object)data0, (Vector256<short>)(object)data1);
            } else if (typeof(ushort) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2UnzipOdd((Vector256<ushort>)(object)data0, (Vector256<ushort>)(object)data1);
            } else if (typeof(int) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2UnzipOdd((Vector256<int>)(object)data0, (Vector256<int>)(object)data1);
            } else if (typeof(uint) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2UnzipOdd((Vector256<uint>)(object)data0, (Vector256<uint>)(object)data1);
            } else if (typeof(long) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2UnzipOdd((Vector256<long>)(object)data0, (Vector256<long>)(object)data1);
            } else if (typeof(ulong) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2UnzipOdd((Vector256<ulong>)(object)data0, (Vector256<ulong>)(object)data1);
            } else if (typeof(ExInt128) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2UnzipOdd((Vector256<ExInt128>)(object)data0, (Vector256<ExInt128>)(object)data1);
            } else if (typeof(ExUInt128) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2UnzipOdd((Vector256<ExUInt128>)(object)data0, (Vector256<ExUInt128>)(object)data1);
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2UnzipOdd((Vector256<Int128>)(object)data0, (Vector256<Int128>)(object)data1);
            } else if (typeof(UInt128) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2UnzipOdd((Vector256<UInt128>)(object)data0, (Vector256<UInt128>)(object)data1);
#endif // BCL_TYPE_INT128
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="Vector256s.YGroup2UnzipOdd(Vector256{ExInt128}, Vector256{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<Int128> YGroup2UnzipOdd(this IWVectorTraits256 athis, Vector256<Int128> data0, Vector256<Int128> data1) {
            return athis.YGroup2UnzipOdd(data0.ExAsExInt128(), data1.ExAsExInt128()).ExAsInt128();
        }

        /// <inheritdoc cref="Vector256s.YGroup2UnzipOdd(Vector256{ExUInt128}, Vector256{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<UInt128> YGroup2UnzipOdd(this IWVectorTraits256 athis, Vector256<UInt128> data0, Vector256<UInt128> data1) {
            return athis.YGroup2UnzipOdd(data0.ExAsExUInt128(), data1.ExAsExUInt128()).ExAsUInt128();
        }

#endif // BCL_TYPE_INT128


#if BCL_TYPE_INT128

        /// <inheritdoc cref="Vector256s.YGroup2Zip(Vector256{ExInt128}, Vector256{ExInt128}, out Vector256{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<Int128> YGroup2Zip(this IWVectorTraits256 athis, Vector256<Int128> x, Vector256<Int128> y, out Vector256<Int128> data1) {
            var d0 = athis.YGroup2Zip(x.ExAsExInt128(), y.ExAsExInt128(), out var d1);
            data1 = d1.ExAsInt128();
            return d0.ExAsInt128();
        }

        /// <inheritdoc cref="Vector256s.YGroup2Zip(Vector256{ExUInt128}, Vector256{ExUInt128}, out Vector256{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<UInt128> YGroup2Zip(this IWVectorTraits256 athis, Vector256<UInt128> x, Vector256<UInt128> y, out Vector256<UInt128> data1) {
            var d0 = athis.YGroup2Zip(x.ExAsExUInt128(), y.ExAsExUInt128(), out var d1);
            data1 = d1.ExAsUInt128();
            return d0.ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="Vector256s.YGroup2Zip{T}(Vector256{T}, Vector256{T})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static (Vector256<T> Data0, Vector256<T> Data1) YGroup2Zip<T>(this IWVectorTraits256 athis, Vector256<T> x, Vector256<T> y) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip((Vector256<float>)(object)x, (Vector256<float>)(object)y);
                return ((Vector256<T>)(object)data0, (Vector256<T>)(object)data1);
            } else if (typeof(double) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip((Vector256<double>)(object)x, (Vector256<double>)(object)y);
                return ((Vector256<T>)(object)data0, (Vector256<T>)(object)data1);
            } else if (typeof(sbyte) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip((Vector256<sbyte>)(object)x, (Vector256<sbyte>)(object)y);
                return ((Vector256<T>)(object)data0, (Vector256<T>)(object)data1);
            } else if (typeof(byte) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip((Vector256<byte>)(object)x, (Vector256<byte>)(object)y);
                return ((Vector256<T>)(object)data0, (Vector256<T>)(object)data1);
            } else if (typeof(short) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip((Vector256<short>)(object)x, (Vector256<short>)(object)y);
                return ((Vector256<T>)(object)data0, (Vector256<T>)(object)data1);
            } else if (typeof(ushort) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip((Vector256<ushort>)(object)x, (Vector256<ushort>)(object)y);
                return ((Vector256<T>)(object)data0, (Vector256<T>)(object)data1);
            } else if (typeof(int) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip((Vector256<int>)(object)x, (Vector256<int>)(object)y);
                return ((Vector256<T>)(object)data0, (Vector256<T>)(object)data1);
            } else if (typeof(uint) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip((Vector256<uint>)(object)x, (Vector256<uint>)(object)y);
                return ((Vector256<T>)(object)data0, (Vector256<T>)(object)data1);
            } else if (typeof(long) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip((Vector256<long>)(object)x, (Vector256<long>)(object)y);
                return ((Vector256<T>)(object)data0, (Vector256<T>)(object)data1);
            } else if (typeof(ulong) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip((Vector256<ulong>)(object)x, (Vector256<ulong>)(object)y);
                return ((Vector256<T>)(object)data0, (Vector256<T>)(object)data1);
            } else if (typeof(ExInt128) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip((Vector256<ExInt128>)(object)x, (Vector256<ExInt128>)(object)y);
                return ((Vector256<T>)(object)data0, (Vector256<T>)(object)data1);
            } else if (typeof(ExUInt128) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip((Vector256<ExUInt128>)(object)x, (Vector256<ExUInt128>)(object)y);
                return ((Vector256<T>)(object)data0, (Vector256<T>)(object)data1);
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip((Vector256<Int128>)(object)x, (Vector256<Int128>)(object)y);
                return ((Vector256<T>)(object)data0, (Vector256<T>)(object)data1);
            } else if (typeof(UInt128) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip((Vector256<UInt128>)(object)x, (Vector256<UInt128>)(object)y);
                return ((Vector256<T>)(object)data0, (Vector256<T>)(object)data1);
#endif // BCL_TYPE_INT128
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector256s.YGroup2Zip(Vector256{float}, Vector256{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<float> Data0, Vector256<float> Data1) YGroup2Zip(this IWVectorTraits256 athis, Vector256<float> x, Vector256<float> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vector256s.YGroup2Zip(Vector256{double}, Vector256{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<double> Data0, Vector256<double> Data1) YGroup2Zip(this IWVectorTraits256 athis, Vector256<double> x, Vector256<double> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vector256s.YGroup2Zip(Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<sbyte> Data0, Vector256<sbyte> Data1) YGroup2Zip(this IWVectorTraits256 athis, Vector256<sbyte> x, Vector256<sbyte> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vector256s.YGroup2Zip(Vector256{byte}, Vector256{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<byte> Data0, Vector256<byte> Data1) YGroup2Zip(this IWVectorTraits256 athis, Vector256<byte> x, Vector256<byte> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vector256s.YGroup2Zip(Vector256{short}, Vector256{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> Data0, Vector256<short> Data1) YGroup2Zip(this IWVectorTraits256 athis, Vector256<short> x, Vector256<short> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vector256s.YGroup2Zip(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ushort> Data0, Vector256<ushort> Data1) YGroup2Zip(this IWVectorTraits256 athis, Vector256<ushort> x, Vector256<ushort> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vector256s.YGroup2Zip(Vector256{int}, Vector256{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> Data0, Vector256<int> Data1) YGroup2Zip(this IWVectorTraits256 athis, Vector256<int> x, Vector256<int> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vector256s.YGroup2Zip(Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<uint> Data0, Vector256<uint> Data1) YGroup2Zip(this IWVectorTraits256 athis, Vector256<uint> x, Vector256<uint> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vector256s.YGroup2Zip(Vector256{long}, Vector256{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> Data0, Vector256<long> Data1) YGroup2Zip(this IWVectorTraits256 athis, Vector256<long> x, Vector256<long> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vector256s.YGroup2Zip(Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ulong> Data0, Vector256<ulong> Data1) YGroup2Zip(this IWVectorTraits256 athis, Vector256<ulong> x, Vector256<ulong> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vector256s.YGroup2Zip(Vector256{ExInt128}, Vector256{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ExInt128> Data0, Vector256<ExInt128> Data1) YGroup2Zip(this IWVectorTraits256 athis, Vector256<ExInt128> x, Vector256<ExInt128> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vector256s.YGroup2Zip(Vector256{ExUInt128}, Vector256{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ExUInt128> Data0, Vector256<ExUInt128> Data1) YGroup2Zip(this IWVectorTraits256 athis, Vector256<ExUInt128> x, Vector256<ExUInt128> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="Vector256s.YGroup2Zip(Vector256{Int128}, Vector256{Int128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<Int128> Data0, Vector256<Int128> Data1) YGroup2Zip(this IWVectorTraits256 athis, Vector256<Int128> x, Vector256<Int128> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vector256s.YGroup2Zip(Vector256{UInt128}, Vector256{UInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<UInt128> Data0, Vector256<UInt128> Data1) YGroup2Zip(this IWVectorTraits256 athis, Vector256<UInt128> x, Vector256<UInt128> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="Vector256s.YGroup2ZipHigh(Vector256{int}, Vector256{int})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static Vector256<T> YGroup2ZipHigh<T>(this IWVectorTraits256 athis, Vector256<T> x, Vector256<T> y) where T : struct {
            if (typeof(float) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2ZipHigh((Vector256<float>)(object)x, (Vector256<float>)(object)y);
            } else if (typeof(double) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2ZipHigh((Vector256<double>)(object)x, (Vector256<double>)(object)y);
            } else if (typeof(sbyte) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2ZipHigh((Vector256<sbyte>)(object)x, (Vector256<sbyte>)(object)y);
            } else if (typeof(byte) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2ZipHigh((Vector256<byte>)(object)x, (Vector256<byte>)(object)y);
            } else if (typeof(short) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2ZipHigh((Vector256<short>)(object)x, (Vector256<short>)(object)y);
            } else if (typeof(ushort) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2ZipHigh((Vector256<ushort>)(object)x, (Vector256<ushort>)(object)y);
            } else if (typeof(int) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2ZipHigh((Vector256<int>)(object)x, (Vector256<int>)(object)y);
            } else if (typeof(uint) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2ZipHigh((Vector256<uint>)(object)x, (Vector256<uint>)(object)y);
            } else if (typeof(long) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2ZipHigh((Vector256<long>)(object)x, (Vector256<long>)(object)y);
            } else if (typeof(ulong) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2ZipHigh((Vector256<ulong>)(object)x, (Vector256<ulong>)(object)y);
            } else if (typeof(ExInt128) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2ZipHigh((Vector256<ExInt128>)(object)x, (Vector256<ExInt128>)(object)y);
            } else if (typeof(ExUInt128) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2ZipHigh((Vector256<ExUInt128>)(object)x, (Vector256<ExUInt128>)(object)y);
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2ZipHigh((Vector256<Int128>)(object)x, (Vector256<Int128>)(object)y);
            } else if (typeof(UInt128) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2ZipHigh((Vector256<UInt128>)(object)x, (Vector256<UInt128>)(object)y);
#endif // BCL_TYPE_INT128
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="Vector256s.YGroup2ZipHigh(Vector256{ExInt128}, Vector256{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<Int128> YGroup2ZipHigh(this IWVectorTraits256 athis, Vector256<Int128> x, Vector256<Int128> y) {
            return athis.YGroup2ZipHigh(x.ExAsExInt128(), y.ExAsExInt128()).ExAsInt128();
        }

        /// <inheritdoc cref="Vector256s.YGroup2ZipHigh(Vector256{ExUInt128}, Vector256{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<UInt128> YGroup2ZipHigh(this IWVectorTraits256 athis, Vector256<UInt128> x, Vector256<UInt128> y) {
            return athis.YGroup2ZipHigh(x.ExAsExUInt128(), y.ExAsExUInt128()).ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="Vector256s.YGroup2ZipLow(Vector256{int}, Vector256{int})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static Vector256<T> YGroup2ZipLow<T>(this IWVectorTraits256 athis, Vector256<T> x, Vector256<T> y) where T : struct {
            if (typeof(float) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2ZipLow((Vector256<float>)(object)x, (Vector256<float>)(object)y);
            } else if (typeof(double) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2ZipLow((Vector256<double>)(object)x, (Vector256<double>)(object)y);
            } else if (typeof(sbyte) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2ZipLow((Vector256<sbyte>)(object)x, (Vector256<sbyte>)(object)y);
            } else if (typeof(byte) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2ZipLow((Vector256<byte>)(object)x, (Vector256<byte>)(object)y);
            } else if (typeof(short) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2ZipLow((Vector256<short>)(object)x, (Vector256<short>)(object)y);
            } else if (typeof(ushort) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2ZipLow((Vector256<ushort>)(object)x, (Vector256<ushort>)(object)y);
            } else if (typeof(int) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2ZipLow((Vector256<int>)(object)x, (Vector256<int>)(object)y);
            } else if (typeof(uint) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2ZipLow((Vector256<uint>)(object)x, (Vector256<uint>)(object)y);
            } else if (typeof(long) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2ZipLow((Vector256<long>)(object)x, (Vector256<long>)(object)y);
            } else if (typeof(ulong) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2ZipLow((Vector256<ulong>)(object)x, (Vector256<ulong>)(object)y);
            } else if (typeof(ExInt128) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2ZipLow((Vector256<ExInt128>)(object)x, (Vector256<ExInt128>)(object)y);
            } else if (typeof(ExUInt128) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2ZipLow((Vector256<ExUInt128>)(object)x, (Vector256<ExUInt128>)(object)y);
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2ZipLow((Vector256<Int128>)(object)x, (Vector256<Int128>)(object)y);
            } else if (typeof(UInt128) == typeof(T)) {
                return (Vector256<T>)(object)athis.YGroup2ZipLow((Vector256<UInt128>)(object)x, (Vector256<UInt128>)(object)y);
#endif // BCL_TYPE_INT128
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="Vector256s.YGroup2ZipLow(Vector256{ExInt128}, Vector256{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<Int128> YGroup2ZipLow(this IWVectorTraits256 athis, Vector256<Int128> x, Vector256<Int128> y) {
            return athis.YGroup2ZipLow(x.ExAsExInt128(), y.ExAsExInt128()).ExAsInt128();
        }

        /// <inheritdoc cref="Vector256s.YGroup2ZipLow(Vector256{ExUInt128}, Vector256{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<UInt128> YGroup2ZipLow(this IWVectorTraits256 athis, Vector256<UInt128> x, Vector256<UInt128> y) {
            return athis.YGroup2ZipLow(x.ExAsExUInt128(), y.ExAsExUInt128()).ExAsUInt128();
        }

#endif // BCL_TYPE_INT128


        /// <inheritdoc cref="Vector256s.YGroup3ToGroup4{T}(Vector256{T}, Vector256{T}, Vector256{T})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<T> Result0, Vector256<T> Result1, Vector256<T> Result2, Vector256<T> Result3) YGroup3ToGroup4<T>(this IWVectorTraits256 athis, Vector256<T> data0, Vector256<T> data1, Vector256<T> data2) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup3ToGroup4((Vector256<float>)(object)data0, (Vector256<float>)(object)data1, (Vector256<float>)(object)data2);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup3ToGroup4((Vector256<double>)(object)data0, (Vector256<double>)(object)data1, (Vector256<double>)(object)data2);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup3ToGroup4((Vector256<sbyte>)(object)data0, (Vector256<sbyte>)(object)data1, (Vector256<sbyte>)(object)data2);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup3ToGroup4((Vector256<byte>)(object)data0, (Vector256<byte>)(object)data1, (Vector256<byte>)(object)data2);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup3ToGroup4((Vector256<short>)(object)data0, (Vector256<short>)(object)data1, (Vector256<short>)(object)data2);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup3ToGroup4((Vector256<ushort>)(object)data0, (Vector256<ushort>)(object)data1, (Vector256<ushort>)(object)data2);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup3ToGroup4((Vector256<int>)(object)data0, (Vector256<int>)(object)data1, (Vector256<int>)(object)data2);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup3ToGroup4((Vector256<uint>)(object)data0, (Vector256<uint>)(object)data1, (Vector256<uint>)(object)data2);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup3ToGroup4((Vector256<long>)(object)data0, (Vector256<long>)(object)data1, (Vector256<long>)(object)data2);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup3ToGroup4((Vector256<ulong>)(object)data0, (Vector256<ulong>)(object)data1, (Vector256<ulong>)(object)data2);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector256s.YGroup3ToGroup4(Vector256{float}, Vector256{float}, Vector256{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<float> Result0, Vector256<float> Result1, Vector256<float> Result2, Vector256<float> Result3) YGroup3ToGroup4(this IWVectorTraits256 athis, Vector256<float> data0, Vector256<float> data1, Vector256<float> data2) {
            var rt0 = athis.YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector256s.YGroup3ToGroup4(Vector256{double}, Vector256{double}, Vector256{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<double> Result0, Vector256<double> Result1, Vector256<double> Result2, Vector256<double> Result3) YGroup3ToGroup4(this IWVectorTraits256 athis, Vector256<double> data0, Vector256<double> data1, Vector256<double> data2) {
            var rt0 = athis.YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector256s.YGroup3ToGroup4(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<sbyte> Result0, Vector256<sbyte> Result1, Vector256<sbyte> Result2, Vector256<sbyte> Result3) YGroup3ToGroup4(this IWVectorTraits256 athis, Vector256<sbyte> data0, Vector256<sbyte> data1, Vector256<sbyte> data2) {
            var rt0 = athis.YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector256s.YGroup3ToGroup4(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<byte> Result0, Vector256<byte> Result1, Vector256<byte> Result2, Vector256<byte> Result3) YGroup3ToGroup4(this IWVectorTraits256 athis, Vector256<byte> data0, Vector256<byte> data1, Vector256<byte> data2) {
            var rt0 = athis.YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector256s.YGroup3ToGroup4(Vector256{short}, Vector256{short}, Vector256{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> Result0, Vector256<short> Result1, Vector256<short> Result2, Vector256<short> Result3) YGroup3ToGroup4(this IWVectorTraits256 athis, Vector256<short> data0, Vector256<short> data1, Vector256<short> data2) {
            var rt0 = athis.YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector256s.YGroup3ToGroup4(Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ushort> Result0, Vector256<ushort> Result1, Vector256<ushort> Result2, Vector256<ushort> Result3) YGroup3ToGroup4(this IWVectorTraits256 athis, Vector256<ushort> data0, Vector256<ushort> data1, Vector256<ushort> data2) {
            var rt0 = athis.YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector256s.YGroup3ToGroup4(Vector256{int}, Vector256{int}, Vector256{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> Result0, Vector256<int> Result1, Vector256<int> Result2, Vector256<int> Result3) YGroup3ToGroup4(this IWVectorTraits256 athis, Vector256<int> data0, Vector256<int> data1, Vector256<int> data2) {
            var rt0 = athis.YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector256s.YGroup3ToGroup4(Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<uint> Result0, Vector256<uint> Result1, Vector256<uint> Result2, Vector256<uint> Result3) YGroup3ToGroup4(this IWVectorTraits256 athis, Vector256<uint> data0, Vector256<uint> data1, Vector256<uint> data2) {
            var rt0 = athis.YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            //Console.WriteLine(VectorTextUtil.Format("athis f({0}, {1}, {2}): {3}, {4}, {5}, {6}", data0, data1, data2, rt0, rt1, rt2, rt3));
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector256s.YGroup3ToGroup4(Vector256{long}, Vector256{long}, Vector256{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> Result0, Vector256<long> Result1, Vector256<long> Result2, Vector256<long> Result3) YGroup3ToGroup4(this IWVectorTraits256 athis, Vector256<long> data0, Vector256<long> data1, Vector256<long> data2) {
            var rt0 = athis.YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector256s.YGroup3ToGroup4(Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ulong> Result0, Vector256<ulong> Result1, Vector256<ulong> Result2, Vector256<ulong> Result3) YGroup3ToGroup4(this IWVectorTraits256 athis, Vector256<ulong> data0, Vector256<ulong> data1, Vector256<ulong> data2) {
            var rt0 = athis.YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }


        /// <inheritdoc cref="Vector256s.YGroup3Unzip{T}(Vector256{T}, Vector256{T}, Vector256{T})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<T> X, Vector256<T> Y, Vector256<T> Z) YGroup3Unzip<T>(this IWVectorTraits256 athis, Vector256<T> data0, Vector256<T> data1, Vector256<T> data2) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Unzip((Vector256<float>)(object)data0, (Vector256<float>)(object)data1, (Vector256<float>)(object)data2);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Unzip((Vector256<double>)(object)data0, (Vector256<double>)(object)data1, (Vector256<double>)(object)data2);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Unzip((Vector256<sbyte>)(object)data0, (Vector256<sbyte>)(object)data1, (Vector256<sbyte>)(object)data2);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Unzip((Vector256<byte>)(object)data0, (Vector256<byte>)(object)data1, (Vector256<byte>)(object)data2);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Unzip((Vector256<short>)(object)data0, (Vector256<short>)(object)data1, (Vector256<short>)(object)data2);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Unzip((Vector256<ushort>)(object)data0, (Vector256<ushort>)(object)data1, (Vector256<ushort>)(object)data2);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Unzip((Vector256<int>)(object)data0, (Vector256<int>)(object)data1, (Vector256<int>)(object)data2);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Unzip((Vector256<uint>)(object)data0, (Vector256<uint>)(object)data1, (Vector256<uint>)(object)data2);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Unzip((Vector256<long>)(object)data0, (Vector256<long>)(object)data1, (Vector256<long>)(object)data2);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Unzip((Vector256<ulong>)(object)data0, (Vector256<ulong>)(object)data1, (Vector256<ulong>)(object)data2);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector256s.YGroup3Unzip(Vector256{float}, Vector256{float}, Vector256{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<float> X, Vector256<float> Y, Vector256<float> Z) YGroup3Unzip(this IWVectorTraits256 athis, Vector256<float> data0, Vector256<float> data1, Vector256<float> data2) {
            var rt0 = athis.YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector256s.YGroup3Unzip(Vector256{double}, Vector256{double}, Vector256{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<double> X, Vector256<double> Y, Vector256<double> Z) YGroup3Unzip(this IWVectorTraits256 athis, Vector256<double> data0, Vector256<double> data1, Vector256<double> data2) {
            var rt0 = athis.YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector256s.YGroup3Unzip(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<sbyte> X, Vector256<sbyte> Y, Vector256<sbyte> Z) YGroup3Unzip(this IWVectorTraits256 athis, Vector256<sbyte> data0, Vector256<sbyte> data1, Vector256<sbyte> data2) {
            var rt0 = athis.YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector256s.YGroup3Unzip(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<byte> X, Vector256<byte> Y, Vector256<byte> Z) YGroup3Unzip(this IWVectorTraits256 athis, Vector256<byte> data0, Vector256<byte> data1, Vector256<byte> data2) {
            var rt0 = athis.YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector256s.YGroup3Unzip(Vector256{short}, Vector256{short}, Vector256{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> X, Vector256<short> Y, Vector256<short> Z) YGroup3Unzip(this IWVectorTraits256 athis, Vector256<short> data0, Vector256<short> data1, Vector256<short> data2) {
            var rt0 = athis.YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector256s.YGroup3Unzip(Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ushort> X, Vector256<ushort> Y, Vector256<ushort> Z) YGroup3Unzip(this IWVectorTraits256 athis, Vector256<ushort> data0, Vector256<ushort> data1, Vector256<ushort> data2) {
            var rt0 = athis.YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector256s.YGroup3Unzip(Vector256{int}, Vector256{int}, Vector256{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> X, Vector256<int> Y, Vector256<int> Z) YGroup3Unzip(this IWVectorTraits256 athis, Vector256<int> data0, Vector256<int> data1, Vector256<int> data2) {
            var rt0 = athis.YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector256s.YGroup3Unzip(Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<uint> X, Vector256<uint> Y, Vector256<uint> Z) YGroup3Unzip(this IWVectorTraits256 athis, Vector256<uint> data0, Vector256<uint> data1, Vector256<uint> data2) {
            var rt0 = athis.YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector256s.YGroup3Unzip(Vector256{long}, Vector256{long}, Vector256{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> X, Vector256<long> Y, Vector256<long> Z) YGroup3Unzip(this IWVectorTraits256 athis, Vector256<long> data0, Vector256<long> data1, Vector256<long> data2) {
            var rt0 = athis.YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector256s.YGroup3Unzip(Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ulong> X, Vector256<ulong> Y, Vector256<ulong> Z) YGroup3Unzip(this IWVectorTraits256 athis, Vector256<ulong> data0, Vector256<ulong> data1, Vector256<ulong> data2) {
            var rt0 = athis.YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }


        /// <inheritdoc cref="Vector256s.YGroup3UnzipX2{T}(Vector256{T}, Vector256{T}, Vector256{T}, Vector256{T}, Vector256{T}, Vector256{T})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<T> X, Vector256<T> XB, Vector256<T> Y, Vector256<T> YB, Vector256<T> Z, Vector256<T> ZB) YGroup3UnzipX2<T>(this IWVectorTraits256 athis, Vector256<T> data0, Vector256<T> data1, Vector256<T> data2, Vector256<T> data3, Vector256<T> data4, Vector256<T> data5) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3UnzipX2((Vector256<float>)(object)data0, (Vector256<float>)(object)data1, (Vector256<float>)(object)data2, (Vector256<float>)(object)data3, (Vector256<float>)(object)data4, (Vector256<float>)(object)data5);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3, (Vector256<T>)(object)rt4, (Vector256<T>)(object)rt5);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3UnzipX2((Vector256<double>)(object)data0, (Vector256<double>)(object)data1, (Vector256<double>)(object)data2, (Vector256<double>)(object)data3, (Vector256<double>)(object)data4, (Vector256<double>)(object)data5);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3, (Vector256<T>)(object)rt4, (Vector256<T>)(object)rt5);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3UnzipX2((Vector256<sbyte>)(object)data0, (Vector256<sbyte>)(object)data1, (Vector256<sbyte>)(object)data2, (Vector256<sbyte>)(object)data3, (Vector256<sbyte>)(object)data4, (Vector256<sbyte>)(object)data5);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3, (Vector256<T>)(object)rt4, (Vector256<T>)(object)rt5);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3UnzipX2((Vector256<byte>)(object)data0, (Vector256<byte>)(object)data1, (Vector256<byte>)(object)data2, (Vector256<byte>)(object)data3, (Vector256<byte>)(object)data4, (Vector256<byte>)(object)data5);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3, (Vector256<T>)(object)rt4, (Vector256<T>)(object)rt5);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3UnzipX2((Vector256<short>)(object)data0, (Vector256<short>)(object)data1, (Vector256<short>)(object)data2, (Vector256<short>)(object)data3, (Vector256<short>)(object)data4, (Vector256<short>)(object)data5);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3, (Vector256<T>)(object)rt4, (Vector256<T>)(object)rt5);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3UnzipX2((Vector256<ushort>)(object)data0, (Vector256<ushort>)(object)data1, (Vector256<ushort>)(object)data2, (Vector256<ushort>)(object)data3, (Vector256<ushort>)(object)data4, (Vector256<ushort>)(object)data5);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3, (Vector256<T>)(object)rt4, (Vector256<T>)(object)rt5);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3UnzipX2((Vector256<int>)(object)data0, (Vector256<int>)(object)data1, (Vector256<int>)(object)data2, (Vector256<int>)(object)data3, (Vector256<int>)(object)data4, (Vector256<int>)(object)data5);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3, (Vector256<T>)(object)rt4, (Vector256<T>)(object)rt5);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3UnzipX2((Vector256<uint>)(object)data0, (Vector256<uint>)(object)data1, (Vector256<uint>)(object)data2, (Vector256<uint>)(object)data3, (Vector256<uint>)(object)data4, (Vector256<uint>)(object)data5);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3, (Vector256<T>)(object)rt4, (Vector256<T>)(object)rt5);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3UnzipX2((Vector256<long>)(object)data0, (Vector256<long>)(object)data1, (Vector256<long>)(object)data2, (Vector256<long>)(object)data3, (Vector256<long>)(object)data4, (Vector256<long>)(object)data5);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3, (Vector256<T>)(object)rt4, (Vector256<T>)(object)rt5);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3UnzipX2((Vector256<ulong>)(object)data0, (Vector256<ulong>)(object)data1, (Vector256<ulong>)(object)data2, (Vector256<ulong>)(object)data3, (Vector256<ulong>)(object)data4, (Vector256<ulong>)(object)data5);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3, (Vector256<T>)(object)rt4, (Vector256<T>)(object)rt5);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector256s.YGroup3UnzipX2(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<float> X, Vector256<float> XB, Vector256<float> Y, Vector256<float> YB, Vector256<float> Z, Vector256<float> ZB) YGroup3UnzipX2(this IWVectorTraits256 athis, Vector256<float> data0, Vector256<float> data1, Vector256<float> data2, Vector256<float> data3, Vector256<float> data4, Vector256<float> data5) {
            var rt0 = athis.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="Vector256s.YGroup3UnzipX2(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<double> X, Vector256<double> XB, Vector256<double> Y, Vector256<double> YB, Vector256<double> Z, Vector256<double> ZB) YGroup3UnzipX2(this IWVectorTraits256 athis, Vector256<double> data0, Vector256<double> data1, Vector256<double> data2, Vector256<double> data3, Vector256<double> data4, Vector256<double> data5) {
            var rt0 = athis.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="Vector256s.YGroup3UnzipX2(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<sbyte> X, Vector256<sbyte> XB, Vector256<sbyte> Y, Vector256<sbyte> YB, Vector256<sbyte> Z, Vector256<sbyte> ZB) YGroup3UnzipX2(this IWVectorTraits256 athis, Vector256<sbyte> data0, Vector256<sbyte> data1, Vector256<sbyte> data2, Vector256<sbyte> data3, Vector256<sbyte> data4, Vector256<sbyte> data5) {
            var rt0 = athis.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="Vector256s.YGroup3UnzipX2(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<byte> X, Vector256<byte> XB, Vector256<byte> Y, Vector256<byte> YB, Vector256<byte> Z, Vector256<byte> ZB) YGroup3UnzipX2(this IWVectorTraits256 athis, Vector256<byte> data0, Vector256<byte> data1, Vector256<byte> data2, Vector256<byte> data3, Vector256<byte> data4, Vector256<byte> data5) {
            var rt0 = athis.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="Vector256s.YGroup3UnzipX2(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> X, Vector256<short> XB, Vector256<short> Y, Vector256<short> YB, Vector256<short> Z, Vector256<short> ZB) YGroup3UnzipX2(this IWVectorTraits256 athis, Vector256<short> data0, Vector256<short> data1, Vector256<short> data2, Vector256<short> data3, Vector256<short> data4, Vector256<short> data5) {
            var rt0 = athis.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="Vector256s.YGroup3UnzipX2(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ushort> X, Vector256<ushort> XB, Vector256<ushort> Y, Vector256<ushort> YB, Vector256<ushort> Z, Vector256<ushort> ZB) YGroup3UnzipX2(this IWVectorTraits256 athis, Vector256<ushort> data0, Vector256<ushort> data1, Vector256<ushort> data2, Vector256<ushort> data3, Vector256<ushort> data4, Vector256<ushort> data5) {
            var rt0 = athis.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="Vector256s.YGroup3UnzipX2(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> X, Vector256<int> XB, Vector256<int> Y, Vector256<int> YB, Vector256<int> Z, Vector256<int> ZB) YGroup3UnzipX2(this IWVectorTraits256 athis, Vector256<int> data0, Vector256<int> data1, Vector256<int> data2, Vector256<int> data3, Vector256<int> data4, Vector256<int> data5) {
            var rt0 = athis.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="Vector256s.YGroup3UnzipX2(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<uint> X, Vector256<uint> XB, Vector256<uint> Y, Vector256<uint> YB, Vector256<uint> Z, Vector256<uint> ZB) YGroup3UnzipX2(this IWVectorTraits256 athis, Vector256<uint> data0, Vector256<uint> data1, Vector256<uint> data2, Vector256<uint> data3, Vector256<uint> data4, Vector256<uint> data5) {
            var rt0 = athis.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="Vector256s.YGroup3UnzipX2(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> X, Vector256<long> XB, Vector256<long> Y, Vector256<long> YB, Vector256<long> Z, Vector256<long> ZB) YGroup3UnzipX2(this IWVectorTraits256 athis, Vector256<long> data0, Vector256<long> data1, Vector256<long> data2, Vector256<long> data3, Vector256<long> data4, Vector256<long> data5) {
            var rt0 = athis.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="Vector256s.YGroup3UnzipX2(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ulong> X, Vector256<ulong> XB, Vector256<ulong> Y, Vector256<ulong> YB, Vector256<ulong> Z, Vector256<ulong> ZB) YGroup3UnzipX2(this IWVectorTraits256 athis, Vector256<ulong> data0, Vector256<ulong> data1, Vector256<ulong> data2, Vector256<ulong> data3, Vector256<ulong> data4, Vector256<ulong> data5) {
            var rt0 = athis.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }


        /// <inheritdoc cref="Vector256s.YGroup3Zip{T}(Vector256{T}, Vector256{T}, Vector256{T})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<T> Data0, Vector256<T> Data1, Vector256<T> Data2) YGroup3Zip<T>(this IWVectorTraits256 athis, Vector256<T> x, Vector256<T> y, Vector256<T> z) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Zip((Vector256<float>)(object)x, (Vector256<float>)(object)y, (Vector256<float>)(object)z);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Zip((Vector256<double>)(object)x, (Vector256<double>)(object)y, (Vector256<double>)(object)z);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Zip((Vector256<sbyte>)(object)x, (Vector256<sbyte>)(object)y, (Vector256<sbyte>)(object)z);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Zip((Vector256<byte>)(object)x, (Vector256<byte>)(object)y, (Vector256<byte>)(object)z);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Zip((Vector256<short>)(object)x, (Vector256<short>)(object)y, (Vector256<short>)(object)z);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Zip((Vector256<ushort>)(object)x, (Vector256<ushort>)(object)y, (Vector256<ushort>)(object)z);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Zip((Vector256<int>)(object)x, (Vector256<int>)(object)y, (Vector256<int>)(object)z);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Zip((Vector256<uint>)(object)x, (Vector256<uint>)(object)y, (Vector256<uint>)(object)z);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Zip((Vector256<long>)(object)x, (Vector256<long>)(object)y, (Vector256<long>)(object)z);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Zip((Vector256<ulong>)(object)x, (Vector256<ulong>)(object)y, (Vector256<ulong>)(object)z);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector256s.YGroup3Zip(Vector256{float}, Vector256{float}, Vector256{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<float> Data0, Vector256<float> Data1, Vector256<float> Data2) YGroup3Zip(this IWVectorTraits256 athis, Vector256<float> x, Vector256<float> y, Vector256<float> z) {
            var data0 = athis.YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="Vector256s.YGroup3Zip(Vector256{double}, Vector256{double}, Vector256{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<double> Data0, Vector256<double> Data1, Vector256<double> Data2) YGroup3Zip(this IWVectorTraits256 athis, Vector256<double> x, Vector256<double> y, Vector256<double> z) {
            var data0 = athis.YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="Vector256s.YGroup3Zip(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<sbyte> Data0, Vector256<sbyte> Data1, Vector256<sbyte> Data2) YGroup3Zip(this IWVectorTraits256 athis, Vector256<sbyte> x, Vector256<sbyte> y, Vector256<sbyte> z) {
            var data0 = athis.YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="Vector256s.YGroup3Zip(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<byte> Data0, Vector256<byte> Data1, Vector256<byte> Data2) YGroup3Zip(this IWVectorTraits256 athis, Vector256<byte> x, Vector256<byte> y, Vector256<byte> z) {
            var data0 = athis.YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="Vector256s.YGroup3Zip(Vector256{short}, Vector256{short}, Vector256{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> Data0, Vector256<short> Data1, Vector256<short> Data2) YGroup3Zip(this IWVectorTraits256 athis, Vector256<short> x, Vector256<short> y, Vector256<short> z) {
            var data0 = athis.YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="Vector256s.YGroup3Zip(Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ushort> Data0, Vector256<ushort> Data1, Vector256<ushort> Data2) YGroup3Zip(this IWVectorTraits256 athis, Vector256<ushort> x, Vector256<ushort> y, Vector256<ushort> z) {
            var data0 = athis.YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="Vector256s.YGroup3Zip(Vector256{int}, Vector256{int}, Vector256{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> Data0, Vector256<int> Data1, Vector256<int> Data2) YGroup3Zip(this IWVectorTraits256 athis, Vector256<int> x, Vector256<int> y, Vector256<int> z) {
            var data0 = athis.YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="Vector256s.YGroup3Zip(Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<uint> Data0, Vector256<uint> Data1, Vector256<uint> Data2) YGroup3Zip(this IWVectorTraits256 athis, Vector256<uint> x, Vector256<uint> y, Vector256<uint> z) {
            var data0 = athis.YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="Vector256s.YGroup3Zip(Vector256{long}, Vector256{long}, Vector256{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> Data0, Vector256<long> Data1, Vector256<long> Data2) YGroup3Zip(this IWVectorTraits256 athis, Vector256<long> x, Vector256<long> y, Vector256<long> z) {
            var data0 = athis.YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="Vector256s.YGroup3Zip(Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ulong> Data0, Vector256<ulong> Data1, Vector256<ulong> Data2) YGroup3Zip(this IWVectorTraits256 athis, Vector256<ulong> x, Vector256<ulong> y, Vector256<ulong> z) {
            var data0 = athis.YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }


        /// <inheritdoc cref="Vector256s.YGroup3ZipX2{T}(Vector256{T}, Vector256{T}, Vector256{T}, Vector256{T}, Vector256{T}, Vector256{T})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<T> Data0, Vector256<T> Data1, Vector256<T> Data2, Vector256<T> Data3, Vector256<T> Data4, Vector256<T> Data5) YGroup3ZipX2<T>(this IWVectorTraits256 athis, Vector256<T> x, Vector256<T> xB, Vector256<T> y, Vector256<T> yB, Vector256<T> z, Vector256<T> zB) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3ZipX2((Vector256<float>)(object)x, (Vector256<float>)(object)xB, (Vector256<float>)(object)y, (Vector256<float>)(object)yB, (Vector256<float>)(object)z, (Vector256<float>)(object)zB);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3, (Vector256<T>)(object)rt4, (Vector256<T>)(object)rt5);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3ZipX2((Vector256<double>)(object)x, (Vector256<double>)(object)xB, (Vector256<double>)(object)y, (Vector256<double>)(object)yB, (Vector256<double>)(object)z, (Vector256<double>)(object)zB);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3, (Vector256<T>)(object)rt4, (Vector256<T>)(object)rt5);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3ZipX2((Vector256<sbyte>)(object)x, (Vector256<sbyte>)(object)xB, (Vector256<sbyte>)(object)y, (Vector256<sbyte>)(object)yB, (Vector256<sbyte>)(object)z, (Vector256<sbyte>)(object)zB);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3, (Vector256<T>)(object)rt4, (Vector256<T>)(object)rt5);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3ZipX2((Vector256<byte>)(object)x, (Vector256<byte>)(object)xB, (Vector256<byte>)(object)y, (Vector256<byte>)(object)yB, (Vector256<byte>)(object)z, (Vector256<byte>)(object)zB);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3, (Vector256<T>)(object)rt4, (Vector256<T>)(object)rt5);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3ZipX2((Vector256<short>)(object)x, (Vector256<short>)(object)xB, (Vector256<short>)(object)y, (Vector256<short>)(object)yB, (Vector256<short>)(object)z, (Vector256<short>)(object)zB);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3, (Vector256<T>)(object)rt4, (Vector256<T>)(object)rt5);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3ZipX2((Vector256<ushort>)(object)x, (Vector256<ushort>)(object)xB, (Vector256<ushort>)(object)y, (Vector256<ushort>)(object)yB, (Vector256<ushort>)(object)z, (Vector256<ushort>)(object)zB);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3, (Vector256<T>)(object)rt4, (Vector256<T>)(object)rt5);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3ZipX2((Vector256<int>)(object)x, (Vector256<int>)(object)xB, (Vector256<int>)(object)y, (Vector256<int>)(object)yB, (Vector256<int>)(object)z, (Vector256<int>)(object)zB);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3, (Vector256<T>)(object)rt4, (Vector256<T>)(object)rt5);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3ZipX2((Vector256<uint>)(object)x, (Vector256<uint>)(object)xB, (Vector256<uint>)(object)y, (Vector256<uint>)(object)yB, (Vector256<uint>)(object)z, (Vector256<uint>)(object)zB);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3, (Vector256<T>)(object)rt4, (Vector256<T>)(object)rt5);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3ZipX2((Vector256<long>)(object)x, (Vector256<long>)(object)xB, (Vector256<long>)(object)y, (Vector256<long>)(object)yB, (Vector256<long>)(object)z, (Vector256<long>)(object)zB);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3, (Vector256<T>)(object)rt4, (Vector256<T>)(object)rt5);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3ZipX2((Vector256<ulong>)(object)x, (Vector256<ulong>)(object)xB, (Vector256<ulong>)(object)y, (Vector256<ulong>)(object)yB, (Vector256<ulong>)(object)z, (Vector256<ulong>)(object)zB);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3, (Vector256<T>)(object)rt4, (Vector256<T>)(object)rt5);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector256s.YGroup3ZipX2(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<float> Data0, Vector256<float> Data1, Vector256<float> Data2, Vector256<float> Data3, Vector256<float> Data4, Vector256<float> Data5) YGroup3ZipX2(this IWVectorTraits256 athis, Vector256<float> x, Vector256<float> xB, Vector256<float> y, Vector256<float> yB, Vector256<float> z, Vector256<float> zB) {
            var data0 = athis.YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="Vector256s.YGroup3ZipX2(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<double> Data0, Vector256<double> Data1, Vector256<double> Data2, Vector256<double> Data3, Vector256<double> Data4, Vector256<double> Data5) YGroup3ZipX2(this IWVectorTraits256 athis, Vector256<double> x, Vector256<double> xB, Vector256<double> y, Vector256<double> yB, Vector256<double> z, Vector256<double> zB) {
            var data0 = athis.YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="Vector256s.YGroup3ZipX2(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<sbyte> Data0, Vector256<sbyte> Data1, Vector256<sbyte> Data2, Vector256<sbyte> Data3, Vector256<sbyte> Data4, Vector256<sbyte> Data5) YGroup3ZipX2(this IWVectorTraits256 athis, Vector256<sbyte> x, Vector256<sbyte> xB, Vector256<sbyte> y, Vector256<sbyte> yB, Vector256<sbyte> z, Vector256<sbyte> zB) {
            var data0 = athis.YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="Vector256s.YGroup3ZipX2(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<byte> Data0, Vector256<byte> Data1, Vector256<byte> Data2, Vector256<byte> Data3, Vector256<byte> Data4, Vector256<byte> Data5) YGroup3ZipX2(this IWVectorTraits256 athis, Vector256<byte> x, Vector256<byte> xB, Vector256<byte> y, Vector256<byte> yB, Vector256<byte> z, Vector256<byte> zB) {
            var data0 = athis.YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="Vector256s.YGroup3ZipX2(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> Data0, Vector256<short> Data1, Vector256<short> Data2, Vector256<short> Data3, Vector256<short> Data4, Vector256<short> Data5) YGroup3ZipX2(this IWVectorTraits256 athis, Vector256<short> x, Vector256<short> xB, Vector256<short> y, Vector256<short> yB, Vector256<short> z, Vector256<short> zB) {
            var data0 = athis.YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="Vector256s.YGroup3ZipX2(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ushort> Data0, Vector256<ushort> Data1, Vector256<ushort> Data2, Vector256<ushort> Data3, Vector256<ushort> Data4, Vector256<ushort> Data5) YGroup3ZipX2(this IWVectorTraits256 athis, Vector256<ushort> x, Vector256<ushort> xB, Vector256<ushort> y, Vector256<ushort> yB, Vector256<ushort> z, Vector256<ushort> zB) {
            var data0 = athis.YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="Vector256s.YGroup3ZipX2(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> Data0, Vector256<int> Data1, Vector256<int> Data2, Vector256<int> Data3, Vector256<int> Data4, Vector256<int> Data5) YGroup3ZipX2(this IWVectorTraits256 athis, Vector256<int> x, Vector256<int> xB, Vector256<int> y, Vector256<int> yB, Vector256<int> z, Vector256<int> zB) {
            var data0 = athis.YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="Vector256s.YGroup3ZipX2(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<uint> Data0, Vector256<uint> Data1, Vector256<uint> Data2, Vector256<uint> Data3, Vector256<uint> Data4, Vector256<uint> Data5) YGroup3ZipX2(this IWVectorTraits256 athis, Vector256<uint> x, Vector256<uint> xB, Vector256<uint> y, Vector256<uint> yB, Vector256<uint> z, Vector256<uint> zB) {
            var data0 = athis.YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="Vector256s.YGroup3ZipX2(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> Data0, Vector256<long> Data1, Vector256<long> Data2, Vector256<long> Data3, Vector256<long> Data4, Vector256<long> Data5) YGroup3ZipX2(this IWVectorTraits256 athis, Vector256<long> x, Vector256<long> xB, Vector256<long> y, Vector256<long> yB, Vector256<long> z, Vector256<long> zB) {
            var data0 = athis.YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="Vector256s.YGroup3ZipX2(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ulong> Data0, Vector256<ulong> Data1, Vector256<ulong> Data2, Vector256<ulong> Data3, Vector256<ulong> Data4, Vector256<ulong> Data5) YGroup3ZipX2(this IWVectorTraits256 athis, Vector256<ulong> x, Vector256<ulong> xB, Vector256<ulong> y, Vector256<ulong> yB, Vector256<ulong> z, Vector256<ulong> zB) {
            var data0 = athis.YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }


#if BCL_TYPE_INT128

        /// <inheritdoc cref="Vector256s.YGroup4Unzip(Vector256{ExInt128}, Vector256{ExInt128}, Vector256{ExInt128}, Vector256{ExInt128}, out Vector256{ExInt128}, out Vector256{ExInt128}, out Vector256{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<Int128> YGroup4Unzip(this IWVectorTraits256 athis, Vector256<Int128> data0, Vector256<Int128> data1, Vector256<Int128> data2, Vector256<Int128> data3, out Vector256<Int128> y, out Vector256<Int128> z, out Vector256<Int128> w) {
            var d0 = athis.YGroup4Unzip(data0.ExAsExInt128(), data1.ExAsExInt128(), data2.ExAsExInt128(), data3.ExAsExInt128(), out var d1, out var d2, out var d3);
            y = d1.ExAsInt128();
            z = d2.ExAsInt128();
            w = d3.ExAsInt128();
            return d0.ExAsInt128();
        }

        /// <inheritdoc cref="Vector256s.YGroup4Unzip(Vector256{ExUInt128}, Vector256{ExUInt128}, Vector256{ExUInt128}, Vector256{ExUInt128}, out Vector256{ExUInt128}, out Vector256{ExUInt128}, out Vector256{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<UInt128> YGroup4Unzip(this IWVectorTraits256 athis, Vector256<UInt128> data0, Vector256<UInt128> data1, Vector256<UInt128> data2, Vector256<UInt128> data3, out Vector256<UInt128> y, out Vector256<UInt128> z, out Vector256<UInt128> w) {
            var d0 = athis.YGroup4Unzip(data0.ExAsExUInt128(), data1.ExAsExUInt128(), data2.ExAsExUInt128(), data3.ExAsExUInt128(), out var d1, out var d2, out var d3);
            y = d1.ExAsUInt128();
            z = d2.ExAsUInt128();
            w = d3.ExAsUInt128();
            return d0.ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="Vector256s.YGroup4Unzip{T}(Vector256{T}, Vector256{T}, Vector256{T}, Vector256{T})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<T> X, Vector256<T> Y, Vector256<T> Z, Vector256<T> W) YGroup4Unzip<T>(this IWVectorTraits256 athis, Vector256<T> data0, Vector256<T> data1, Vector256<T> data2, Vector256<T> data3) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip((Vector256<float>)(object)data0, (Vector256<float>)(object)data1, (Vector256<float>)(object)data2, (Vector256<float>)(object)data3);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip((Vector256<double>)(object)data0, (Vector256<double>)(object)data1, (Vector256<double>)(object)data2, (Vector256<double>)(object)data3);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip((Vector256<sbyte>)(object)data0, (Vector256<sbyte>)(object)data1, (Vector256<sbyte>)(object)data2, (Vector256<sbyte>)(object)data3);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip((Vector256<byte>)(object)data0, (Vector256<byte>)(object)data1, (Vector256<byte>)(object)data2, (Vector256<byte>)(object)data3);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip((Vector256<short>)(object)data0, (Vector256<short>)(object)data1, (Vector256<short>)(object)data2, (Vector256<short>)(object)data3);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip((Vector256<ushort>)(object)data0, (Vector256<ushort>)(object)data1, (Vector256<ushort>)(object)data2, (Vector256<ushort>)(object)data3);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip((Vector256<int>)(object)data0, (Vector256<int>)(object)data1, (Vector256<int>)(object)data2, (Vector256<int>)(object)data3);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip((Vector256<uint>)(object)data0, (Vector256<uint>)(object)data1, (Vector256<uint>)(object)data2, (Vector256<uint>)(object)data3);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip((Vector256<long>)(object)data0, (Vector256<long>)(object)data1, (Vector256<long>)(object)data2, (Vector256<long>)(object)data3);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip((Vector256<ulong>)(object)data0, (Vector256<ulong>)(object)data1, (Vector256<ulong>)(object)data2, (Vector256<ulong>)(object)data3);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3);
            } else if (typeof(ExInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip((Vector256<ExInt128>)(object)data0, (Vector256<ExInt128>)(object)data1, (Vector256<ExInt128>)(object)data2, (Vector256<ExInt128>)(object)data3);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3);
            } else if (typeof(ExUInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip((Vector256<ExUInt128>)(object)data0, (Vector256<ExUInt128>)(object)data1, (Vector256<ExUInt128>)(object)data2, (Vector256<ExUInt128>)(object)data3);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3);
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip((Vector256<Int128>)(object)data0, (Vector256<Int128>)(object)data1, (Vector256<Int128>)(object)data2, (Vector256<Int128>)(object)data3);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3);
            } else if (typeof(UInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip((Vector256<UInt128>)(object)data0, (Vector256<UInt128>)(object)data1, (Vector256<UInt128>)(object)data2, (Vector256<UInt128>)(object)data3);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3);
#endif // BCL_TYPE_INT128
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector256s.YGroup4Unzip(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<float> X, Vector256<float> Y, Vector256<float> Z, Vector256<float> W) YGroup4Unzip(this IWVectorTraits256 athis, Vector256<float> data0, Vector256<float> data1, Vector256<float> data2, Vector256<float> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }


        /// <inheritdoc cref="Vector256s.YGroup4Unzip(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<double> X, Vector256<double> Y, Vector256<double> Z, Vector256<double> W) YGroup4Unzip(this IWVectorTraits256 athis, Vector256<double> data0, Vector256<double> data1, Vector256<double> data2, Vector256<double> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector256s.YGroup4Unzip(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<sbyte> X, Vector256<sbyte> Y, Vector256<sbyte> Z, Vector256<sbyte> W) YGroup4Unzip(this IWVectorTraits256 athis, Vector256<sbyte> data0, Vector256<sbyte> data1, Vector256<sbyte> data2, Vector256<sbyte> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector256s.YGroup4Unzip(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<byte> X, Vector256<byte> Y, Vector256<byte> Z, Vector256<byte> W) YGroup4Unzip(this IWVectorTraits256 athis, Vector256<byte> data0, Vector256<byte> data1, Vector256<byte> data2, Vector256<byte> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector256s.YGroup4Unzip(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> X, Vector256<short> Y, Vector256<short> Z, Vector256<short> W) YGroup4Unzip(this IWVectorTraits256 athis, Vector256<short> data0, Vector256<short> data1, Vector256<short> data2, Vector256<short> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector256s.YGroup4Unzip(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ushort> X, Vector256<ushort> Y, Vector256<ushort> Z, Vector256<ushort> W) YGroup4Unzip(this IWVectorTraits256 athis, Vector256<ushort> data0, Vector256<ushort> data1, Vector256<ushort> data2, Vector256<ushort> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector256s.YGroup4Unzip(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> X, Vector256<int> Y, Vector256<int> Z, Vector256<int> W) YGroup4Unzip(this IWVectorTraits256 athis, Vector256<int> data0, Vector256<int> data1, Vector256<int> data2, Vector256<int> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector256s.YGroup4Unzip(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<uint> X, Vector256<uint> Y, Vector256<uint> Z, Vector256<uint> W) YGroup4Unzip(this IWVectorTraits256 athis, Vector256<uint> data0, Vector256<uint> data1, Vector256<uint> data2, Vector256<uint> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector256s.YGroup4Unzip(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> X, Vector256<long> Y, Vector256<long> Z, Vector256<long> W) YGroup4Unzip(this IWVectorTraits256 athis, Vector256<long> data0, Vector256<long> data1, Vector256<long> data2, Vector256<long> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector256s.YGroup4Unzip(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ulong> X, Vector256<ulong> Y, Vector256<ulong> Z, Vector256<ulong> W) YGroup4Unzip(this IWVectorTraits256 athis, Vector256<ulong> data0, Vector256<ulong> data1, Vector256<ulong> data2, Vector256<ulong> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector256s.YGroup4Unzip(Vector256{ExInt128}, Vector256{ExInt128}, Vector256{ExInt128}, Vector256{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ExInt128> X, Vector256<ExInt128> Y, Vector256<ExInt128> Z, Vector256<ExInt128> W) YGroup4Unzip(this IWVectorTraits256 athis, Vector256<ExInt128> data0, Vector256<ExInt128> data1, Vector256<ExInt128> data2, Vector256<ExInt128> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector256s.YGroup4Unzip(Vector256{ExUInt128}, Vector256{ExUInt128}, Vector256{ExUInt128}, Vector256{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ExUInt128> X, Vector256<ExUInt128> Y, Vector256<ExUInt128> Z, Vector256<ExUInt128> W) YGroup4Unzip(this IWVectorTraits256 athis, Vector256<ExUInt128> data0, Vector256<ExUInt128> data1, Vector256<ExUInt128> data2, Vector256<ExUInt128> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="Vector256s.YGroup4Unzip(Vector256{Int128}, Vector256{Int128}, Vector256{Int128}, Vector256{Int128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<Int128> X, Vector256<Int128> Y, Vector256<Int128> Z, Vector256<Int128> W) YGroup4Unzip(this IWVectorTraits256 athis, Vector256<Int128> data0, Vector256<Int128> data1, Vector256<Int128> data2, Vector256<Int128> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector256s.YGroup4Unzip(Vector256{UInt128}, Vector256{UInt128}, Vector256{UInt128}, Vector256{UInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<UInt128> X, Vector256<UInt128> Y, Vector256<UInt128> Z, Vector256<UInt128> W) YGroup4Unzip(this IWVectorTraits256 athis, Vector256<UInt128> data0, Vector256<UInt128> data1, Vector256<UInt128> data2, Vector256<UInt128> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

#endif // BCL_TYPE_INT128


#if BCL_TYPE_INT128

        /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{ExInt128}, Vector256{ExInt128}, Vector256{ExInt128}, Vector256{ExInt128}, out Vector256{ExInt128}, out Vector256{ExInt128}, out Vector256{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<Int128> YGroup4Zip(this IWVectorTraits256 athis, Vector256<Int128> x, Vector256<Int128> y, Vector256<Int128> z, Vector256<Int128> w, out Vector256<Int128> data1, out Vector256<Int128> data2, out Vector256<Int128> data3) {
            var d0 = athis.YGroup4Zip(x.ExAsExInt128(), y.ExAsExInt128(), z.ExAsExInt128(), w.ExAsExInt128(), out var d1, out var d2, out var d3);
            data1 = d1.ExAsInt128();
            data2 = d2.ExAsInt128();
            data3 = d3.ExAsInt128();
            return d0.ExAsInt128();
        }

        /// <inheritdoc cref="IWVectorTraits256.YGroup4Zip(Vector256{ExUInt128}, Vector256{ExUInt128}, Vector256{ExUInt128}, Vector256{ExUInt128}, out Vector256{ExUInt128}, out Vector256{ExUInt128}, out Vector256{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<UInt128> YGroup4Zip(this IWVectorTraits256 athis, Vector256<UInt128> x, Vector256<UInt128> y, Vector256<UInt128> z, Vector256<UInt128> w, out Vector256<UInt128> data1, out Vector256<UInt128> data2, out Vector256<UInt128> data3) {
            var d0 = athis.YGroup4Zip(x.ExAsExUInt128(), y.ExAsExUInt128(), z.ExAsExUInt128(), w.ExAsExUInt128(), out var d1, out var d2, out var d3);
            data1 = d1.ExAsUInt128();
            data2 = d2.ExAsUInt128();
            data3 = d3.ExAsUInt128();
            return d0.ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="Vector128s.YGroup4Zip(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<T> Data0, Vector256<T> Data1, Vector256<T> Data2, Vector256<T> Data3) YGroup4Zip<T>(this IWVectorTraits256 athis, Vector256<T> x, Vector256<T> y, Vector256<T> z, Vector256<T> w) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip((Vector256<float>)(object)x, (Vector256<float>)(object)y, (Vector256<float>)(object)z, (Vector256<float>)(object)w);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip((Vector256<double>)(object)x, (Vector256<double>)(object)y, (Vector256<double>)(object)z, (Vector256<double>)(object)w);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip((Vector256<sbyte>)(object)x, (Vector256<sbyte>)(object)y, (Vector256<sbyte>)(object)z, (Vector256<sbyte>)(object)w);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip((Vector256<byte>)(object)x, (Vector256<byte>)(object)y, (Vector256<byte>)(object)z, (Vector256<byte>)(object)w);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip((Vector256<short>)(object)x, (Vector256<short>)(object)y, (Vector256<short>)(object)z, (Vector256<short>)(object)w);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip((Vector256<ushort>)(object)x, (Vector256<ushort>)(object)y, (Vector256<ushort>)(object)z, (Vector256<ushort>)(object)w);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip((Vector256<int>)(object)x, (Vector256<int>)(object)y, (Vector256<int>)(object)z, (Vector256<int>)(object)w);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip((Vector256<uint>)(object)x, (Vector256<uint>)(object)y, (Vector256<uint>)(object)z, (Vector256<uint>)(object)w);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip((Vector256<long>)(object)x, (Vector256<long>)(object)y, (Vector256<long>)(object)z, (Vector256<long>)(object)w);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip((Vector256<ulong>)(object)x, (Vector256<ulong>)(object)y, (Vector256<ulong>)(object)z, (Vector256<ulong>)(object)w);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3);
            } else if (typeof(ExInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip((Vector256<ExInt128>)(object)x, (Vector256<ExInt128>)(object)y, (Vector256<ExInt128>)(object)z, (Vector256<ExInt128>)(object)w);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3);
            } else if (typeof(ExUInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip((Vector256<ExUInt128>)(object)x, (Vector256<ExUInt128>)(object)y, (Vector256<ExUInt128>)(object)z, (Vector256<ExUInt128>)(object)w);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3);
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip((Vector256<Int128>)(object)x, (Vector256<Int128>)(object)y, (Vector256<Int128>)(object)z, (Vector256<Int128>)(object)w);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3);
            } else if (typeof(UInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip((Vector256<UInt128>)(object)x, (Vector256<UInt128>)(object)y, (Vector256<UInt128>)(object)z, (Vector256<UInt128>)(object)w);
                return ((Vector256<T>)(object)rt0, (Vector256<T>)(object)rt1, (Vector256<T>)(object)rt2, (Vector256<T>)(object)rt3);
#endif // BCL_TYPE_INT128
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector256s.YGroup4Zip(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<float> Data0, Vector256<float> Data1, Vector256<float> Data2, Vector256<float> Data3) YGroup4Zip(this IWVectorTraits256 athis, Vector256<float> x, Vector256<float> y, Vector256<float> z, Vector256<float> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<double> Data0, Vector256<double> Data1, Vector256<double> Data2, Vector256<double> Data3) YGroup4Zip(this IWVectorTraits256 athis, Vector256<double> x, Vector256<double> y, Vector256<double> z, Vector256<double> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<sbyte> Data0, Vector256<sbyte> Data1, Vector256<sbyte> Data2, Vector256<sbyte> Data3) YGroup4Zip(this IWVectorTraits256 athis, Vector256<sbyte> x, Vector256<sbyte> y, Vector256<sbyte> z, Vector256<sbyte> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<byte> Data0, Vector256<byte> Data1, Vector256<byte> Data2, Vector256<byte> Data3) YGroup4Zip(this IWVectorTraits256 athis, Vector256<byte> x, Vector256<byte> y, Vector256<byte> z, Vector256<byte> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> Data0, Vector256<short> Data1, Vector256<short> Data2, Vector256<short> Data3) YGroup4Zip(this IWVectorTraits256 athis, Vector256<short> x, Vector256<short> y, Vector256<short> z, Vector256<short> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ushort> Data0, Vector256<ushort> Data1, Vector256<ushort> Data2, Vector256<ushort> Data3) YGroup4Zip(this IWVectorTraits256 athis, Vector256<ushort> x, Vector256<ushort> y, Vector256<ushort> z, Vector256<ushort> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> Data0, Vector256<int> Data1, Vector256<int> Data2, Vector256<int> Data3) YGroup4Zip(this IWVectorTraits256 athis, Vector256<int> x, Vector256<int> y, Vector256<int> z, Vector256<int> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<uint> Data0, Vector256<uint> Data1, Vector256<uint> Data2, Vector256<uint> Data3) YGroup4Zip(this IWVectorTraits256 athis, Vector256<uint> x, Vector256<uint> y, Vector256<uint> z, Vector256<uint> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> Data0, Vector256<long> Data1, Vector256<long> Data2, Vector256<long> Data3) YGroup4Zip(this IWVectorTraits256 athis, Vector256<long> x, Vector256<long> y, Vector256<long> z, Vector256<long> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ulong> Data0, Vector256<ulong> Data1, Vector256<ulong> Data2, Vector256<ulong> Data3) YGroup4Zip(this IWVectorTraits256 athis, Vector256<ulong> x, Vector256<ulong> y, Vector256<ulong> z, Vector256<ulong> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ExInt128> Data0, Vector256<ExInt128> Data1, Vector256<ExInt128> Data2, Vector256<ExInt128> Data3) YGroup4Zip(this IWVectorTraits256 athis, Vector256<ExInt128> x, Vector256<ExInt128> y, Vector256<ExInt128> z, Vector256<ExInt128> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ExUInt128> Data0, Vector256<ExUInt128> Data1, Vector256<ExUInt128> Data2, Vector256<ExUInt128> Data3) YGroup4Zip(this IWVectorTraits256 athis, Vector256<ExUInt128> x, Vector256<ExUInt128> y, Vector256<ExUInt128> z, Vector256<ExUInt128> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="YGroup4Zip(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<Int128> Data0, Vector256<Int128> Data1, Vector256<Int128> Data2, Vector256<Int128> Data3) YGroup4Zip(this IWVectorTraits256 athis, Vector256<Int128> x, Vector256<Int128> y, Vector256<Int128> z, Vector256<Int128> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<UInt128> Data0, Vector256<UInt128> Data1, Vector256<UInt128> Data2, Vector256<UInt128> Data3) YGroup4Zip(this IWVectorTraits256 athis, Vector256<UInt128> x, Vector256<UInt128> y, Vector256<UInt128> z, Vector256<UInt128> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

#endif // BCL_TYPE_INT128


        /// <inheritdoc cref="Vector256s.YShuffleG4X2{T}(Vector256{T}, Vector256{T}, ShuffleControlG4)"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static (Vector256<T> Result0, Vector256<T> Result1) YShuffleG4X2<T>(this IWVectorTraits256 athis, Vector256<T> source0, Vector256<T> source1, [ConstantExpected] ShuffleControlG4 control) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector256<float>)(object)source0, (Vector256<float>)(object)source1, control);
                return ((Vector256<T>)(object)result0, (Vector256<T>)(object)result1);
            } else if (typeof(double) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector256<double>)(object)source0, (Vector256<double>)(object)source1, control);
                return ((Vector256<T>)(object)result0, (Vector256<T>)(object)result1);
            } else if (typeof(sbyte) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector256<sbyte>)(object)source0, (Vector256<sbyte>)(object)source1, control);
                return ((Vector256<T>)(object)result0, (Vector256<T>)(object)result1);
            } else if (typeof(byte) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector256<byte>)(object)source0, (Vector256<byte>)(object)source1, control);
                return ((Vector256<T>)(object)result0, (Vector256<T>)(object)result1);
            } else if (typeof(short) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector256<short>)(object)source0, (Vector256<short>)(object)source1, control);
                return ((Vector256<T>)(object)result0, (Vector256<T>)(object)result1);
            } else if (typeof(ushort) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector256<ushort>)(object)source0, (Vector256<ushort>)(object)source1, control);
                return ((Vector256<T>)(object)result0, (Vector256<T>)(object)result1);
            } else if (typeof(int) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector256<int>)(object)source0, (Vector256<int>)(object)source1, control);
                return ((Vector256<T>)(object)result0, (Vector256<T>)(object)result1);
            } else if (typeof(uint) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector256<uint>)(object)source0, (Vector256<uint>)(object)source1, control);
                return ((Vector256<T>)(object)result0, (Vector256<T>)(object)result1);
            } else if (typeof(long) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector256<long>)(object)source0, (Vector256<long>)(object)source1, control);
                return ((Vector256<T>)(object)result0, (Vector256<T>)(object)result1);
            } else if (typeof(ulong) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector256<ulong>)(object)source0, (Vector256<ulong>)(object)source1, control);
                return ((Vector256<T>)(object)result0, (Vector256<T>)(object)result1);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector256s.YShuffleG4X2(Vector256{float}, Vector256{float}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<float> Result0, Vector256<float> Result1) YShuffleG4X2(this IWVectorTraits256 athis, Vector256<float> source0, Vector256<float> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleG4X2(Vector256{double}, Vector256{double}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<double> Result0, Vector256<double> Result1) YShuffleG4X2(this IWVectorTraits256 athis, Vector256<double> source0, Vector256<double> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleG4X2(Vector256{sbyte}, Vector256{sbyte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<sbyte> Result0, Vector256<sbyte> Result1) YShuffleG4X2(this IWVectorTraits256 athis, Vector256<sbyte> source0, Vector256<sbyte> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleG4X2(Vector256{byte}, Vector256{byte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<byte> Result0, Vector256<byte> Result1) YShuffleG4X2(this IWVectorTraits256 athis, Vector256<byte> source0, Vector256<byte> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleG4X2(Vector256{short}, Vector256{short}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> Result0, Vector256<short> Result1) YShuffleG4X2(this IWVectorTraits256 athis, Vector256<short> source0, Vector256<short> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleG4X2(Vector256{ushort}, Vector256{ushort}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ushort> Result0, Vector256<ushort> Result1) YShuffleG4X2(this IWVectorTraits256 athis, Vector256<ushort> source0, Vector256<ushort> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleG4X2(Vector256{int}, Vector256{int}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> Result0, Vector256<int> Result1) YShuffleG4X2(this IWVectorTraits256 athis, Vector256<int> source0, Vector256<int> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleG4X2(Vector256{uint}, Vector256{uint}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<uint> Result0, Vector256<uint> Result1) YShuffleG4X2(this IWVectorTraits256 athis, Vector256<uint> source0, Vector256<uint> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleG4X2(Vector256{long}, Vector256{long}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> Result0, Vector256<long> Result1) YShuffleG4X2(this IWVectorTraits256 athis, Vector256<long> source0, Vector256<long> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleG4X2(Vector256{ulong}, Vector256{ulong}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ulong> Result0, Vector256<ulong> Result1) YShuffleG4X2(this IWVectorTraits256 athis, Vector256<ulong> source0, Vector256<ulong> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleG4X2_Const{T}(Vector256{T}, Vector256{T}, ShuffleControlG4)"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static (Vector256<T> Result0, Vector256<T> Result1) YShuffleG4X2_Const<T>(this IWVectorTraits256 athis, Vector256<T> source0, Vector256<T> source1, [ConstantExpected] ShuffleControlG4 control) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector256<float>)(object)source0, (Vector256<float>)(object)source1, control);
                return ((Vector256<T>)(object)result0, (Vector256<T>)(object)result1);
            } else if (typeof(double) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector256<double>)(object)source0, (Vector256<double>)(object)source1, control);
                return ((Vector256<T>)(object)result0, (Vector256<T>)(object)result1);
            } else if (typeof(sbyte) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector256<sbyte>)(object)source0, (Vector256<sbyte>)(object)source1, control);
                return ((Vector256<T>)(object)result0, (Vector256<T>)(object)result1);
            } else if (typeof(byte) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector256<byte>)(object)source0, (Vector256<byte>)(object)source1, control);
                return ((Vector256<T>)(object)result0, (Vector256<T>)(object)result1);
            } else if (typeof(short) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector256<short>)(object)source0, (Vector256<short>)(object)source1, control);
                return ((Vector256<T>)(object)result0, (Vector256<T>)(object)result1);
            } else if (typeof(ushort) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector256<ushort>)(object)source0, (Vector256<ushort>)(object)source1, control);
                return ((Vector256<T>)(object)result0, (Vector256<T>)(object)result1);
            } else if (typeof(int) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector256<int>)(object)source0, (Vector256<int>)(object)source1, control);
                return ((Vector256<T>)(object)result0, (Vector256<T>)(object)result1);
            } else if (typeof(uint) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector256<uint>)(object)source0, (Vector256<uint>)(object)source1, control);
                return ((Vector256<T>)(object)result0, (Vector256<T>)(object)result1);
            } else if (typeof(long) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector256<long>)(object)source0, (Vector256<long>)(object)source1, control);
                return ((Vector256<T>)(object)result0, (Vector256<T>)(object)result1);
            } else if (typeof(ulong) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector256<ulong>)(object)source0, (Vector256<ulong>)(object)source1, control);
                return ((Vector256<T>)(object)result0, (Vector256<T>)(object)result1);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector256s.YShuffleG4X2_Const(Vector256{float}, Vector256{float}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<float> Result0, Vector256<float> Result1) YShuffleG4X2_Const(this IWVectorTraits256 athis, Vector256<float> source0, Vector256<float> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleG4X2_Const(Vector256{double}, Vector256{double}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<double> Result0, Vector256<double> Result1) YShuffleG4X2_Const(this IWVectorTraits256 athis, Vector256<double> source0, Vector256<double> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleG4X2_Const(Vector256{sbyte}, Vector256{sbyte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<sbyte> Result0, Vector256<sbyte> Result1) YShuffleG4X2_Const(this IWVectorTraits256 athis, Vector256<sbyte> source0, Vector256<sbyte> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleG4X2_Const(Vector256{byte}, Vector256{byte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<byte> Result0, Vector256<byte> Result1) YShuffleG4X2_Const(this IWVectorTraits256 athis, Vector256<byte> source0, Vector256<byte> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleG4X2_Const(Vector256{short}, Vector256{short}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> Result0, Vector256<short> Result1) YShuffleG4X2_Const(this IWVectorTraits256 athis, Vector256<short> source0, Vector256<short> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleG4X2_Const(Vector256{ushort}, Vector256{ushort}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ushort> Result0, Vector256<ushort> Result1) YShuffleG4X2_Const(this IWVectorTraits256 athis, Vector256<ushort> source0, Vector256<ushort> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleG4X2_Const(Vector256{int}, Vector256{int}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> Result0, Vector256<int> Result1) YShuffleG4X2_Const(this IWVectorTraits256 athis, Vector256<int> source0, Vector256<int> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleG4X2_Const(Vector256{uint}, Vector256{uint}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<uint> Result0, Vector256<uint> Result1) YShuffleG4X2_Const(this IWVectorTraits256 athis, Vector256<uint> source0, Vector256<uint> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleG4X2_Const(Vector256{long}, Vector256{long}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> Result0, Vector256<long> Result1) YShuffleG4X2_Const(this IWVectorTraits256 athis, Vector256<long> source0, Vector256<long> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleG4X2_Const(Vector256{ulong}, Vector256{ulong}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ulong> Result0, Vector256<ulong> Result1) YShuffleG4X2_Const(this IWVectorTraits256 athis, Vector256<ulong> source0, Vector256<ulong> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }


        /// <inheritdoc cref="Vector256s.YShuffleInsert_Args{TIdx}(Vector256{TIdx}, out Vector256{TIdx}, out Vector256{TIdx}, out Vector256{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleInsert_Args<TIdx>(this IWVectorTraits256 athis, Vector256<TIdx> indices, out Vector256<TIdx> args0, out Vector256<TIdx> args1, out Vector256<TIdx> args2)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a0, var a1, var a2) = athis.YShuffleInsert_Args((Vector256<sbyte>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a0;
                args1 = (Vector256<TIdx>)(object)a1;
                args2 = (Vector256<TIdx>)(object)a2;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a0, var a1, var a2) = athis.YShuffleInsert_Args((Vector256<byte>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a0;
                args1 = (Vector256<TIdx>)(object)a1;
                args2 = (Vector256<TIdx>)(object)a2;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a0, var a1, var a2) = athis.YShuffleInsert_Args((Vector256<short>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a0;
                args1 = (Vector256<TIdx>)(object)a1;
                args2 = (Vector256<TIdx>)(object)a2;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a0, var a1, var a2) = athis.YShuffleInsert_Args((Vector256<ushort>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a0;
                args1 = (Vector256<TIdx>)(object)a1;
                args2 = (Vector256<TIdx>)(object)a2;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a0, var a1, var a2) = athis.YShuffleInsert_Args((Vector256<int>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a0;
                args1 = (Vector256<TIdx>)(object)a1;
                args2 = (Vector256<TIdx>)(object)a2;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a0, var a1, var a2) = athis.YShuffleInsert_Args((Vector256<uint>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a0;
                args1 = (Vector256<TIdx>)(object)a1;
                args2 = (Vector256<TIdx>)(object)a2;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a0, var a1, var a2) = athis.YShuffleInsert_Args((Vector256<long>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a0;
                args1 = (Vector256<TIdx>)(object)a1;
                args2 = (Vector256<TIdx>)(object)a2;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a0, var a1, var a2) = athis.YShuffleInsert_Args((Vector256<ulong>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a0;
                args1 = (Vector256<TIdx>)(object)a1;
                args2 = (Vector256<TIdx>)(object)a2;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector256s.YShuffleInsert_Args{TIdx}(Vector256{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static (Vector256<TIdx> args0, Vector256<TIdx> args1, Vector256<TIdx> args2) YShuffleInsert_Args<TIdx>(this IWVectorTraits256 athis, Vector256<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleInsert_Args<TIdx>(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <inheritdoc cref="Vector256s.YShuffleInsert_Args(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2) YShuffleInsert_Args(this IWVectorTraits256 athis, Vector256<sbyte> indices) {
            athis.YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <inheritdoc cref="Vector256s.YShuffleInsert_Args(Vector256{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2) YShuffleInsert_Args(this IWVectorTraits256 athis, Vector256<byte> indices) {
            athis.YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <inheritdoc cref="Vector256s.YShuffleInsert_Args(Vector256{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> args0, Vector256<short> args1, Vector256<short> args2) YShuffleInsert_Args(this IWVectorTraits256 athis, Vector256<short> indices) {
            athis.YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <inheritdoc cref="Vector256s.YShuffleInsert_Args(Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2) YShuffleInsert_Args(this IWVectorTraits256 athis, Vector256<ushort> indices) {
            athis.YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <inheritdoc cref="Vector256s.YShuffleInsert_Args(Vector256{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2) YShuffleInsert_Args(this IWVectorTraits256 athis, Vector256<int> indices) {
            athis.YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <inheritdoc cref="Vector256s.YShuffleInsert_Args(Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2) YShuffleInsert_Args(this IWVectorTraits256 athis, Vector256<uint> indices) {
            athis.YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <inheritdoc cref="Vector256s.YShuffleInsert_Args(Vector256{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2) YShuffleInsert_Args(this IWVectorTraits256 athis, Vector256<long> indices) {
            athis.YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <inheritdoc cref="Vector256s.YShuffleInsert_Args(Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2) YShuffleInsert_Args(this IWVectorTraits256 athis, Vector256<ulong> indices) {
            athis.YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }


        /// <summary>
        /// Core calculation for shuffle and insert (换位并插入的核心计算). Its arguments are derived from YShuffleInsert_Args (其参数来源于 YShuffleInsert_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="athis">This object.</param>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleInsert_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="T"/>, <typeparamref name="TIdx"/>) are not supported.</exception>
        /// <seealso cref="IWVectorTraits256.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<T> YShuffleInsert_Core<T, TIdx>(this IWVectorTraits256 athis, Vector256<T> back, Vector256<T> vector, (Vector256<TIdx> args0, Vector256<TIdx> args1, Vector256<TIdx> args2) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleInsert_Core((Vector256<float>)(object)back, (Vector256<float>)(object)vector, (ValueTuple<Vector256<int>, Vector256<int>, Vector256<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleInsert_Core((Vector256<double>)(object)back, (Vector256<double>)(object)vector, (ValueTuple<Vector256<long>, Vector256<long>, Vector256<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleInsert_Core((Vector256<sbyte>)(object)back, (Vector256<sbyte>)(object)vector, (ValueTuple<Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleInsert_Core((Vector256<byte>)(object)back, (Vector256<byte>)(object)vector, (ValueTuple<Vector256<byte>, Vector256<byte>, Vector256<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleInsert_Core((Vector256<short>)(object)back, (Vector256<short>)(object)vector, (ValueTuple<Vector256<short>, Vector256<short>, Vector256<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleInsert_Core((Vector256<ushort>)(object)back, (Vector256<ushort>)(object)vector, (ValueTuple<Vector256<ushort>, Vector256<ushort>, Vector256<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleInsert_Core((Vector256<int>)(object)back, (Vector256<int>)(object)vector, (ValueTuple<Vector256<int>, Vector256<int>, Vector256<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleInsert_Core((Vector256<uint>)(object)back, (Vector256<uint>)(object)vector, (ValueTuple<Vector256<uint>, Vector256<uint>, Vector256<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleInsert_Core((Vector256<long>)(object)back, (Vector256<long>)(object)vector, (ValueTuple<Vector256<long>, Vector256<long>, Vector256<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleInsert_Core((Vector256<ulong>)(object)back, (Vector256<ulong>)(object)vector, (ValueTuple<Vector256<ulong>, Vector256<ulong>, Vector256<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector256s.YShuffleInsert_Core(Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleInsert_Core(this IWVectorTraits256 athis, Vector256<float> back, Vector256<float> vector, (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2) args) {
            return athis.YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <inheritdoc cref="Vector256s.YShuffleInsert_Core(Vector256{double}, Vector256{double}, ValueTuple{Vector256{long}, Vector256{long}, Vector256{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleInsert_Core(this IWVectorTraits256 athis, Vector256<double> back, Vector256<double> vector, (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2) args) {
            return athis.YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <inheritdoc cref="Vector256s.YShuffleInsert_Core(Vector256{sbyte}, Vector256{sbyte}, ValueTuple{Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleInsert_Core(this IWVectorTraits256 athis, Vector256<sbyte> back, Vector256<sbyte> vector, (Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2) args) {
            return athis.YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <inheritdoc cref="Vector256s.YShuffleInsert_Core(Vector256{byte}, Vector256{byte}, ValueTuple{Vector256{byte}, Vector256{byte}, Vector256{byte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleInsert_Core(this IWVectorTraits256 athis, Vector256<byte> back, Vector256<byte> vector, (Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2) args) {
            return athis.YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <inheritdoc cref="Vector256s.YShuffleInsert_Core(Vector256{short}, Vector256{short}, ValueTuple{Vector256{short}, Vector256{short}, Vector256{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleInsert_Core(this IWVectorTraits256 athis, Vector256<short> back, Vector256<short> vector, (Vector256<short> args0, Vector256<short> args1, Vector256<short> args2) args) {
            return athis.YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <inheritdoc cref="Vector256s.YShuffleInsert_Core(Vector256{ushort}, Vector256{ushort}, ValueTuple{Vector256{ushort}, Vector256{ushort}, Vector256{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleInsert_Core(this IWVectorTraits256 athis, Vector256<ushort> back, Vector256<ushort> vector, (Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2) args) {
            return athis.YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <inheritdoc cref="Vector256s.YShuffleInsert_Core(Vector256{int}, Vector256{int}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleInsert_Core(this IWVectorTraits256 athis, Vector256<int> back, Vector256<int> vector, (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2) args) {
            return athis.YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <inheritdoc cref="Vector256s.YShuffleInsert_Core(Vector256{uint}, Vector256{uint}, ValueTuple{Vector256{uint}, Vector256{uint}, Vector256{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleInsert_Core(this IWVectorTraits256 athis, Vector256<uint> back, Vector256<uint> vector, (Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2) args) {
            return athis.YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <inheritdoc cref="Vector256s.YShuffleInsert_Core(Vector256{long}, Vector256{long}, ValueTuple{Vector256{long}, Vector256{long}, Vector256{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleInsert_Core(this IWVectorTraits256 athis, Vector256<long> back, Vector256<long> vector, (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2) args) {
            return athis.YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <inheritdoc cref="Vector256s.YShuffleInsert_Core(Vector256{ulong}, Vector256{ulong}, ValueTuple{Vector256{ulong}, Vector256{ulong}, Vector256{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleInsert_Core(this IWVectorTraits256 athis, Vector256<ulong> back, Vector256<ulong> vector, (Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2) args) {
            return athis.YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }


        /// <inheritdoc cref="Vector256s.YShuffleKernel_Args{TIdx}(Vector256{TIdx}, out Vector256{TIdx}, out Vector256{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleKernel_Args<TIdx>(this IWVectorTraits256 athis, Vector256<TIdx> indices, out Vector256<TIdx> args0, out Vector256<TIdx> args1)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b) = athis.YShuffleKernel_Args((Vector256<sbyte>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b) = athis.YShuffleKernel_Args((Vector256<byte>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b) = athis.YShuffleKernel_Args((Vector256<short>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b) = athis.YShuffleKernel_Args((Vector256<ushort>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b) = athis.YShuffleKernel_Args((Vector256<int>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b) = athis.YShuffleKernel_Args((Vector256<uint>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b) = athis.YShuffleKernel_Args((Vector256<long>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b) = athis.YShuffleKernel_Args((Vector256<ulong>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector256s.YShuffleKernel_Args{TIdx}(Vector256{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<TIdx> args0, Vector256<TIdx> args1) YShuffleKernel_Args<TIdx>(this IWVectorTraits256 athis, Vector256<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleKernel_Args<TIdx>(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector256s.YShuffleKernel_Args(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<sbyte> args0, Vector256<sbyte> args1) YShuffleKernel_Args(this IWVectorTraits256 athis, Vector256<sbyte> indices) {
            athis.YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector256s.YShuffleKernel_Args(Vector256{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<byte> args0, Vector256<byte> args1) YShuffleKernel_Args(this IWVectorTraits256 athis, Vector256<byte> indices) {
            athis.YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector256s.YShuffleKernel_Args(Vector256{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> args0, Vector256<short> args1) YShuffleKernel_Args(this IWVectorTraits256 athis, Vector256<short> indices) {
            athis.YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector256s.YShuffleKernel_Args(Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ushort> args0, Vector256<ushort> args1) YShuffleKernel_Args(this IWVectorTraits256 athis, Vector256<ushort> indices) {
            athis.YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector256s.YShuffleKernel_Args(Vector256{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> args0, Vector256<int> args1) YShuffleKernel_Args(this IWVectorTraits256 athis, Vector256<int> indices) {
            athis.YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector256s.YShuffleKernel_Args(Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<uint> args0, Vector256<uint> args1) YShuffleKernel_Args(this IWVectorTraits256 athis, Vector256<uint> indices) {
            athis.YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector256s.YShuffleKernel_Args(Vector256{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> args0, Vector256<long> args1) YShuffleKernel_Args(this IWVectorTraits256 athis, Vector256<long> indices) {
            athis.YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector256s.YShuffleKernel_Args(Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ulong> args0, Vector256<ulong> args1) YShuffleKernel_Args(this IWVectorTraits256 athis, Vector256<ulong> indices) {
            athis.YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }


        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="athis">This object.</param>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="T"/>, <typeparamref name="TIdx"/>) are not supported.</exception>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{float}, Vector256{int}, Vector256{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<T> YShuffleKernel_Core<T, TIdx>(this IWVectorTraits256 athis, Vector256<T> vector, (Vector256<TIdx> args0, Vector256<TIdx> args1) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleKernel_Core((Vector256<float>)(object)vector, (ValueTuple<Vector256<int>, Vector256<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleKernel_Core((Vector256<double>)(object)vector, (ValueTuple<Vector256<long>, Vector256<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleKernel_Core((Vector256<sbyte>)(object)vector, (ValueTuple<Vector256<sbyte>, Vector256<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleKernel_Core((Vector256<byte>)(object)vector, (ValueTuple<Vector256<byte>, Vector256<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleKernel_Core((Vector256<short>)(object)vector, (ValueTuple<Vector256<short>, Vector256<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleKernel_Core((Vector256<ushort>)(object)vector, (ValueTuple<Vector256<ushort>, Vector256<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleKernel_Core((Vector256<int>)(object)vector, (ValueTuple<Vector256<int>, Vector256<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleKernel_Core((Vector256<uint>)(object)vector, (ValueTuple<Vector256<uint>, Vector256<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleKernel_Core((Vector256<long>)(object)vector, (ValueTuple<Vector256<long>, Vector256<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleKernel_Core((Vector256<ulong>)(object)vector, (ValueTuple<Vector256<ulong>, Vector256<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector256s.YShuffleKernel_Core(Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleKernel_Core(this IWVectorTraits256 athis, Vector256<float> vector, (Vector256<int> args0, Vector256<int> args1) args) {
            return athis.YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleKernel_Core(Vector256{double}, ValueTuple{Vector256{long}, Vector256{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleKernel_Core(this IWVectorTraits256 athis, Vector256<double> vector, (Vector256<long> args0, Vector256<long> args1) args) {
            return athis.YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleKernel_Core(Vector256{sbyte}, ValueTuple{Vector256{sbyte}, Vector256{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleKernel_Core(this IWVectorTraits256 athis, Vector256<sbyte> vector, (Vector256<sbyte> args0, Vector256<sbyte> args1) args) {
            return athis.YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleKernel_Core(Vector256{byte}, ValueTuple{Vector256{byte}, Vector256{byte}})"/>
        [CLSCompliant(false)]
        public static Vector256<byte> YShuffleKernel_Core(this IWVectorTraits256 athis, Vector256<byte> vector, (Vector256<byte> args0, Vector256<byte> args1) args) {
            return athis.YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleKernel_Core(Vector256{short}, ValueTuple{Vector256{short}, Vector256{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleKernel_Core(this IWVectorTraits256 athis, Vector256<short> vector, (Vector256<short> args0, Vector256<short> args1) args) {
            return athis.YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleKernel_Core(Vector256{ushort}, ValueTuple{Vector256{ushort}, Vector256{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleKernel_Core(this IWVectorTraits256 athis, Vector256<ushort> vector, (Vector256<ushort> args0, Vector256<ushort> args1) args) {
            return athis.YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleKernel_Core(Vector256{int}, ValueTuple{Vector256{int}, Vector256{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleKernel_Core(this IWVectorTraits256 athis, Vector256<int> vector, (Vector256<int> args0, Vector256<int> args1) args) {
            return athis.YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleKernel_Core(Vector256{uint}, ValueTuple{Vector256{uint}, Vector256{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleKernel_Core(this IWVectorTraits256 athis, Vector256<uint> vector, (Vector256<uint> args0, Vector256<uint> args1) args) {
            return athis.YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleKernel_Core(Vector256{long}, ValueTuple{Vector256{long}, Vector256{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleKernel_Core(this IWVectorTraits256 athis, Vector256<long> vector, (Vector256<long> args0, Vector256<long> args1) args) {
            return athis.YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleKernel_Core(Vector256{ulong}, ValueTuple{Vector256{ulong}, Vector256{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleKernel_Core(this IWVectorTraits256 athis, Vector256<ulong> vector, (Vector256<ulong> args0, Vector256<ulong> args1) args) {
            return athis.YShuffleKernel_Core(vector, args.args0, args.args1);
        }


        /// <inheritdoc cref="Vector256s.YShuffleX2_Args{TIdx}(Vector256{TIdx}, out Vector256{TIdx}, out Vector256{TIdx}, out Vector256{TIdx}, out Vector256{TIdx}, out Vector256{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleX2_Args<TIdx>(this IWVectorTraits256 athis, Vector256<TIdx> indices, out Vector256<TIdx> args0, out Vector256<TIdx> args1, out Vector256<TIdx> args2, out Vector256<TIdx> args3, out Vector256<TIdx> args4)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2_Args((Vector256<sbyte>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2_Args((Vector256<byte>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2_Args((Vector256<short>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2_Args((Vector256<ushort>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2_Args((Vector256<int>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2_Args((Vector256<uint>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2_Args((Vector256<long>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2_Args((Vector256<ulong>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2_Args{TIdx}(Vector256{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<TIdx> args0, Vector256<TIdx> args1, Vector256<TIdx> args2, Vector256<TIdx> args3, Vector256<TIdx> args4) YShuffleX2_Args<TIdx>(this IWVectorTraits256 athis, Vector256<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2_Args(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4) YShuffleX2_Args(this IWVectorTraits256 athis, Vector256<sbyte> indices) {
            athis.YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2_Args(Vector256{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4) YShuffleX2_Args(this IWVectorTraits256 athis, Vector256<byte> indices) {
            athis.YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2_Args(Vector256{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4) YShuffleX2_Args(this IWVectorTraits256 athis, Vector256<short> indices) {
            athis.YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2_Args(Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4) YShuffleX2_Args(this IWVectorTraits256 athis, Vector256<ushort> indices) {
            athis.YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2_Args(Vector256{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) YShuffleX2_Args(this IWVectorTraits256 athis, Vector256<int> indices) {
            athis.YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2_Args(Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4) YShuffleX2_Args(this IWVectorTraits256 athis, Vector256<uint> indices) {
            athis.YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2_Args(Vector256{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) YShuffleX2_Args(this IWVectorTraits256 athis, Vector256<long> indices) {
            athis.YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2_Args(Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4) YShuffleX2_Args(this IWVectorTraits256 athis, Vector256<ulong> indices) {
            athis.YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <summary>
        /// Core calculation for shuffle and clear on 2 vectors (在2个向量上进行换位并清零的核心计算). Its arguments are derived from YShuffleX2_Args (其参数来源于 YShuffleX2_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*2))?( element_ref(indices[i], vector0, vector1) ):0</c>.
        /// </summary>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="athis">This object.</param>
        /// <param name="vector0">The input vector 0 from which values are selected (从中选择值的输入向量0).</param>
        /// <param name="vector1">The input vector 1 from which values are selected (从中选择值的输入向量1).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from input vectors selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从输入向量集中选择的值).</returns>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="T"/>, <typeparamref name="TIdx"/>) are not supported.</exception>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2_Core(Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<T> YShuffleX2_Core<T, TIdx>(this IWVectorTraits256 athis, Vector256<T> vector0, Vector256<T> vector1, (Vector256<TIdx> args0, Vector256<TIdx> args1, Vector256<TIdx> args2, Vector256<TIdx> args3, Vector256<TIdx> args4) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX2_Core((Vector256<float>)(object)vector0, (Vector256<float>)(object)vector1, (ValueTuple<Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX2_Core((Vector256<double>)(object)vector0, (Vector256<double>)(object)vector1, (ValueTuple<Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX2_Core((Vector256<sbyte>)(object)vector0, (Vector256<sbyte>)(object)vector1, (ValueTuple<Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX2_Core((Vector256<byte>)(object)vector0, (Vector256<byte>)(object)vector1, (ValueTuple<Vector256<byte>, Vector256<byte>, Vector256<byte>, Vector256<byte>, Vector256<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX2_Core((Vector256<short>)(object)vector0, (Vector256<short>)(object)vector1, (ValueTuple<Vector256<short>, Vector256<short>, Vector256<short>, Vector256<short>, Vector256<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX2_Core((Vector256<ushort>)(object)vector0, (Vector256<ushort>)(object)vector1, (ValueTuple<Vector256<ushort>, Vector256<ushort>, Vector256<ushort>, Vector256<ushort>, Vector256<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX2_Core((Vector256<int>)(object)vector0, (Vector256<int>)(object)vector1, (ValueTuple<Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX2_Core((Vector256<uint>)(object)vector0, (Vector256<uint>)(object)vector1, (ValueTuple<Vector256<uint>, Vector256<uint>, Vector256<uint>, Vector256<uint>, Vector256<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX2_Core((Vector256<long>)(object)vector0, (Vector256<long>)(object)vector1, (ValueTuple<Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX2_Core((Vector256<ulong>)(object)vector0, (Vector256<ulong>)(object)vector1, (ValueTuple<Vector256<ulong>, Vector256<ulong>, Vector256<ulong>, Vector256<ulong>, Vector256<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2_Core(Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleX2_Core(this IWVectorTraits256 athis, Vector256<float> vector0, Vector256<float> vector1, (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) args) {
            return athis.YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2_Core(Vector256{double}, Vector256{double}, ValueTuple{Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleX2_Core(this IWVectorTraits256 athis, Vector256<double> vector0, Vector256<double> vector1, (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) args) {
            return athis.YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2_Core(Vector256{sbyte}, Vector256{sbyte}, ValueTuple{Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleX2_Core(this IWVectorTraits256 athis, Vector256<sbyte> vector0, Vector256<sbyte> vector1, (Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4) args) {
            return athis.YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2_Core(Vector256{byte}, Vector256{byte}, ValueTuple{Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleX2_Core(this IWVectorTraits256 athis, Vector256<byte> vector0, Vector256<byte> vector1, (Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4) args) {
            return athis.YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2_Core(Vector256{short}, Vector256{short}, ValueTuple{Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleX2_Core(this IWVectorTraits256 athis, Vector256<short> vector0, Vector256<short> vector1, (Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4) args) {
            return athis.YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2_Core(Vector256{ushort}, Vector256{ushort}, ValueTuple{Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleX2_Core(this IWVectorTraits256 athis, Vector256<ushort> vector0, Vector256<ushort> vector1, (Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4) args) {
            return athis.YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2_Core(Vector256{int}, Vector256{int}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleX2_Core(this IWVectorTraits256 athis, Vector256<int> vector0, Vector256<int> vector1, (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) args) {
            return athis.YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2_Core(Vector256{uint}, Vector256{uint}, ValueTuple{Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleX2_Core(this IWVectorTraits256 athis, Vector256<uint> vector0, Vector256<uint> vector1, (Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4) args) {
            return athis.YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2_Core(Vector256{long}, Vector256{long}, ValueTuple{Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleX2_Core(this IWVectorTraits256 athis, Vector256<long> vector0, Vector256<long> vector1, (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) args) {
            return athis.YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2_Core(Vector256{ulong}, Vector256{ulong}, ValueTuple{Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleX2_Core(this IWVectorTraits256 athis, Vector256<ulong> vector0, Vector256<ulong> vector1, (Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4) args) {
            return athis.YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }


        /// <inheritdoc cref="Vector256s.YShuffleX2Insert_Args{TIdx}(Vector256{TIdx}, out Vector256{TIdx}, out Vector256{TIdx}, out Vector256{TIdx}, out Vector256{TIdx}, out Vector256{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleX2Insert_Args<TIdx>(this IWVectorTraits256 athis, Vector256<TIdx> indices, out Vector256<TIdx> args0, out Vector256<TIdx> args1, out Vector256<TIdx> args2, out Vector256<TIdx> args3, out Vector256<TIdx> args4)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2Insert_Args((Vector256<sbyte>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2Insert_Args((Vector256<byte>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2Insert_Args((Vector256<short>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2Insert_Args((Vector256<ushort>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2Insert_Args((Vector256<int>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2Insert_Args((Vector256<uint>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2Insert_Args((Vector256<long>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2Insert_Args((Vector256<ulong>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2Insert_Args{TIdx}(Vector256{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<TIdx> args0, Vector256<TIdx> args1, Vector256<TIdx> args2, Vector256<TIdx> args3, Vector256<TIdx> args4) YShuffleX2Insert_Args<TIdx>(this IWVectorTraits256 athis, Vector256<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2Insert_Args(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4) YShuffleX2Insert_Args(this IWVectorTraits256 athis, Vector256<sbyte> indices) {
            athis.YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2Insert_Args(Vector256{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4) YShuffleX2Insert_Args(this IWVectorTraits256 athis, Vector256<byte> indices) {
            athis.YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2Insert_Args(Vector256{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4) YShuffleX2Insert_Args(this IWVectorTraits256 athis, Vector256<short> indices) {
            athis.YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2Insert_Args(Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4) YShuffleX2Insert_Args(this IWVectorTraits256 athis, Vector256<ushort> indices) {
            athis.YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2Insert_Args(Vector256{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) YShuffleX2Insert_Args(this IWVectorTraits256 athis, Vector256<int> indices) {
            athis.YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2Insert_Args(Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4) YShuffleX2Insert_Args(this IWVectorTraits256 athis, Vector256<uint> indices) {
            athis.YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2Insert_Args(Vector256{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) YShuffleX2Insert_Args(this IWVectorTraits256 athis, Vector256<long> indices) {
            athis.YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2Insert_Args(Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4) YShuffleX2Insert_Args(this IWVectorTraits256 athis, Vector256<ulong> indices) {
            athis.YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <summary>
        /// Core calculation for shuffle and insert on 2 vectors (在2个向量上进行换位并插入的核心计算). Its arguments are derived from YShuffleX2Insert_Args (其参数来源于 YShuffleX2Insert_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*2))?( element_ref(indices[i], vector0, vector1) ):back[i]</c>.
        /// </summary>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="athis">This object.</param>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector0">The input vector 0 from which values are selected (从中选择值的输入向量0).</param>
        /// <param name="vector1">The input vector 1 from which values are selected (从中选择值的输入向量1).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from input vectors selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从输入向量集中选择的值).</returns>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="T"/>, <typeparamref name="TIdx"/>) are not supported.</exception>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<T> YShuffleX2Insert_Core<T, TIdx>(this IWVectorTraits256 athis, Vector256<T> back, Vector256<T> vector0, Vector256<T> vector1, (Vector256<TIdx> args0, Vector256<TIdx> args1, Vector256<TIdx> args2, Vector256<TIdx> args3, Vector256<TIdx> args4) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX2Insert_Core((Vector256<float>)(object)back, (Vector256<float>)(object)vector0, (Vector256<float>)(object)vector1, (ValueTuple<Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX2Insert_Core((Vector256<double>)(object)back, (Vector256<double>)(object)vector0, (Vector256<double>)(object)vector1, (ValueTuple<Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX2Insert_Core((Vector256<sbyte>)(object)back, (Vector256<sbyte>)(object)vector0, (Vector256<sbyte>)(object)vector1, (ValueTuple<Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX2Insert_Core((Vector256<byte>)(object)back, (Vector256<byte>)(object)vector0, (Vector256<byte>)(object)vector1, (ValueTuple<Vector256<byte>, Vector256<byte>, Vector256<byte>, Vector256<byte>, Vector256<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX2Insert_Core((Vector256<short>)(object)back, (Vector256<short>)(object)vector0, (Vector256<short>)(object)vector1, (ValueTuple<Vector256<short>, Vector256<short>, Vector256<short>, Vector256<short>, Vector256<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX2Insert_Core((Vector256<ushort>)(object)back, (Vector256<ushort>)(object)vector0, (Vector256<ushort>)(object)vector1, (ValueTuple<Vector256<ushort>, Vector256<ushort>, Vector256<ushort>, Vector256<ushort>, Vector256<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX2Insert_Core((Vector256<int>)(object)back, (Vector256<int>)(object)vector0, (Vector256<int>)(object)vector1, (ValueTuple<Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX2Insert_Core((Vector256<uint>)(object)back, (Vector256<uint>)(object)vector0, (Vector256<uint>)(object)vector1, (ValueTuple<Vector256<uint>, Vector256<uint>, Vector256<uint>, Vector256<uint>, Vector256<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX2Insert_Core((Vector256<long>)(object)back, (Vector256<long>)(object)vector0, (Vector256<long>)(object)vector1, (ValueTuple<Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX2Insert_Core((Vector256<ulong>)(object)back, (Vector256<ulong>)(object)vector0, (Vector256<ulong>)(object)vector1, (ValueTuple<Vector256<ulong>, Vector256<ulong>, Vector256<ulong>, Vector256<ulong>, Vector256<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleX2Insert_Core(this IWVectorTraits256 athis, Vector256<float> back, Vector256<float> vector0, Vector256<float> vector1, (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) args) {
            return athis.YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2Insert_Core(Vector256{double}, Vector256{double}, Vector256{double}, ValueTuple{Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleX2Insert_Core(this IWVectorTraits256 athis, Vector256<double> back, Vector256<double> vector0, Vector256<double> vector1, (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) args) {
            return athis.YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2Insert_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, ValueTuple{Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleX2Insert_Core(this IWVectorTraits256 athis, Vector256<sbyte> back, Vector256<sbyte> vector0, Vector256<sbyte> vector1, (Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4) args) {
            return athis.YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2Insert_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, ValueTuple{Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleX2Insert_Core(this IWVectorTraits256 athis, Vector256<byte> back, Vector256<byte> vector0, Vector256<byte> vector1, (Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4) args) {
            return athis.YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2Insert_Core(Vector256{short}, Vector256{short}, Vector256{short}, ValueTuple{Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleX2Insert_Core(this IWVectorTraits256 athis, Vector256<short> back, Vector256<short> vector0, Vector256<short> vector1, (Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4) args) {
            return athis.YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2Insert_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, ValueTuple{Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleX2Insert_Core(this IWVectorTraits256 athis, Vector256<ushort> back, Vector256<ushort> vector0, Vector256<ushort> vector1, (Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4) args) {
            return athis.YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2Insert_Core(Vector256{int}, Vector256{int}, Vector256{int}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleX2Insert_Core(this IWVectorTraits256 athis, Vector256<int> back, Vector256<int> vector0, Vector256<int> vector1, (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) args) {
            return athis.YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2Insert_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, ValueTuple{Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleX2Insert_Core(this IWVectorTraits256 athis, Vector256<uint> back, Vector256<uint> vector0, Vector256<uint> vector1, (Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4) args) {
            return athis.YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2Insert_Core(Vector256{long}, Vector256{long}, Vector256{long}, ValueTuple{Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleX2Insert_Core(this IWVectorTraits256 athis, Vector256<long> back, Vector256<long> vector0, Vector256<long> vector1, (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) args) {
            return athis.YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2Insert_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, ValueTuple{Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleX2Insert_Core(this IWVectorTraits256 athis, Vector256<ulong> back, Vector256<ulong> vector0, Vector256<ulong> vector1, (Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4) args) {
            return athis.YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }


        /// <inheritdoc cref="Vector256s.YShuffleX2Kernel_Args{TIdx}(Vector256{TIdx}, out Vector256{TIdx}, out Vector256{TIdx}, out Vector256{TIdx}, out Vector256{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleX2Kernel_Args<TIdx>(this IWVectorTraits256 athis, Vector256<TIdx> indices, out Vector256<TIdx> args0, out Vector256<TIdx> args1, out Vector256<TIdx> args2, out Vector256<TIdx> args3)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX2Kernel_Args((Vector256<sbyte>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX2Kernel_Args((Vector256<byte>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX2Kernel_Args((Vector256<short>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX2Kernel_Args((Vector256<ushort>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX2Kernel_Args((Vector256<int>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX2Kernel_Args((Vector256<uint>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX2Kernel_Args((Vector256<long>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX2Kernel_Args((Vector256<ulong>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2Kernel_Args{TIdx}(Vector256{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<TIdx> args0, Vector256<TIdx> args1, Vector256<TIdx> args2, Vector256<TIdx> args3) YShuffleX2Kernel_Args<TIdx>(this IWVectorTraits256 athis, Vector256<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2Kernel_Args(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3) YShuffleX2Kernel_Args(this IWVectorTraits256 athis, Vector256<sbyte> indices) {
            athis.YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2Kernel_Args(Vector256{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3) YShuffleX2Kernel_Args(this IWVectorTraits256 athis, Vector256<byte> indices) {
            athis.YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2Kernel_Args(Vector256{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3) YShuffleX2Kernel_Args(this IWVectorTraits256 athis, Vector256<short> indices) {
            athis.YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2Kernel_Args(Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3) YShuffleX2Kernel_Args(this IWVectorTraits256 athis, Vector256<ushort> indices) {
            athis.YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2Kernel_Args(Vector256{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3) YShuffleX2Kernel_Args(this IWVectorTraits256 athis, Vector256<int> indices) {
            athis.YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2Kernel_Args(Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3) YShuffleX2Kernel_Args(this IWVectorTraits256 athis, Vector256<uint> indices) {
            athis.YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2Kernel_Args(Vector256{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3) YShuffleX2Kernel_Args(this IWVectorTraits256 athis, Vector256<long> indices) {
            athis.YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2Kernel_Args(Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3) YShuffleX2Kernel_Args(this IWVectorTraits256 athis, Vector256<ulong> indices) {
            athis.YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <summary>
        /// Core calculation for only shuffle on 2 vectors (在2个向量上进行仅换位的核心计算). Its arguments are derived from YShuffleX2Kernel_Args (其参数来源于 YShuffleX2Kernel_Args).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*2)</c>.
        /// </summary>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="athis">This object.</param>
        /// <param name="vector0">The input vector 0 from which values are selected (从中选择值的输入向量0).</param>
        /// <param name="vector1">The input vector 1 from which values are selected (从中选择值的输入向量1).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from input vectors selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从输入向量集中选择的值).</returns>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="T"/>, <typeparamref name="TIdx"/>) are not supported.</exception>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2Kernel_Core(Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<T> YShuffleX2Kernel_Core<T, TIdx>(this IWVectorTraits256 athis, Vector256<T> vector0, Vector256<T> vector1, (Vector256<TIdx> args0, Vector256<TIdx> args1, Vector256<TIdx> args2, Vector256<TIdx> args3) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX2Kernel_Core((Vector256<float>)(object)vector0, (Vector256<float>)(object)vector1, (ValueTuple<Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX2Kernel_Core((Vector256<double>)(object)vector0, (Vector256<double>)(object)vector1, (ValueTuple<Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX2Kernel_Core((Vector256<sbyte>)(object)vector0, (Vector256<sbyte>)(object)vector1, (ValueTuple<Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX2Kernel_Core((Vector256<byte>)(object)vector0, (Vector256<byte>)(object)vector1, (ValueTuple<Vector256<byte>, Vector256<byte>, Vector256<byte>, Vector256<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX2Kernel_Core((Vector256<short>)(object)vector0, (Vector256<short>)(object)vector1, (ValueTuple<Vector256<short>, Vector256<short>, Vector256<short>, Vector256<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX2Kernel_Core((Vector256<ushort>)(object)vector0, (Vector256<ushort>)(object)vector1, (ValueTuple<Vector256<ushort>, Vector256<ushort>, Vector256<ushort>, Vector256<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX2Kernel_Core((Vector256<int>)(object)vector0, (Vector256<int>)(object)vector1, (ValueTuple<Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX2Kernel_Core((Vector256<uint>)(object)vector0, (Vector256<uint>)(object)vector1, (ValueTuple<Vector256<uint>, Vector256<uint>, Vector256<uint>, Vector256<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX2Kernel_Core((Vector256<long>)(object)vector0, (Vector256<long>)(object)vector1, (ValueTuple<Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX2Kernel_Core((Vector256<ulong>)(object)vector0, (Vector256<ulong>)(object)vector1, (ValueTuple<Vector256<ulong>, Vector256<ulong>, Vector256<ulong>, Vector256<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2Kernel_Core(Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleX2Kernel_Core(this IWVectorTraits256 athis, Vector256<float> vector0, Vector256<float> vector1, (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3) args) {
            return athis.YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2Kernel_Core(Vector256{double}, Vector256{double}, ValueTuple{Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleX2Kernel_Core(this IWVectorTraits256 athis, Vector256<double> vector0, Vector256<double> vector1, (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3) args) {
            return athis.YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2Kernel_Core(Vector256{sbyte}, Vector256{sbyte}, ValueTuple{Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleX2Kernel_Core(this IWVectorTraits256 athis, Vector256<sbyte> vector0, Vector256<sbyte> vector1, (Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3) args) {
            return athis.YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2Kernel_Core(Vector256{byte}, Vector256{byte}, ValueTuple{Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleX2Kernel_Core(this IWVectorTraits256 athis, Vector256<byte> vector0, Vector256<byte> vector1, (Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3) args) {
            return athis.YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2Kernel_Core(Vector256{short}, Vector256{short}, ValueTuple{Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleX2Kernel_Core(this IWVectorTraits256 athis, Vector256<short> vector0, Vector256<short> vector1, (Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3) args) {
            return athis.YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2Kernel_Core(Vector256{ushort}, Vector256{ushort}, ValueTuple{Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleX2Kernel_Core(this IWVectorTraits256 athis, Vector256<ushort> vector0, Vector256<ushort> vector1, (Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3) args) {
            return athis.YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2Kernel_Core(Vector256{int}, Vector256{int}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleX2Kernel_Core(this IWVectorTraits256 athis, Vector256<int> vector0, Vector256<int> vector1, (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3) args) {
            return athis.YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2Kernel_Core(Vector256{uint}, Vector256{uint}, ValueTuple{Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleX2Kernel_Core(this IWVectorTraits256 athis, Vector256<uint> vector0, Vector256<uint> vector1, (Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3) args) {
            return athis.YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2Kernel_Core(Vector256{long}, Vector256{long}, ValueTuple{Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleX2Kernel_Core(this IWVectorTraits256 athis, Vector256<long> vector0, Vector256<long> vector1, (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3) args) {
            return athis.YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX2Kernel_Core(Vector256{ulong}, Vector256{ulong}, ValueTuple{Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleX2Kernel_Core(this IWVectorTraits256 athis, Vector256<ulong> vector0, Vector256<ulong> vector1, (Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3) args) {
            return athis.YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }


        /// <inheritdoc cref="Vector256s.YShuffleX3_Args{TIdx}(Vector256{TIdx}, out Vector256{TIdx}, out Vector256{TIdx}, out Vector256{TIdx}, out Vector256{TIdx}, out Vector256{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleX3_Args<TIdx>(this IWVectorTraits256 athis, Vector256<TIdx> indices, out Vector256<TIdx> args0, out Vector256<TIdx> args1, out Vector256<TIdx> args2, out Vector256<TIdx> args3, out Vector256<TIdx> args4)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3_Args((Vector256<sbyte>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3_Args((Vector256<byte>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3_Args((Vector256<short>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3_Args((Vector256<ushort>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3_Args((Vector256<int>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3_Args((Vector256<uint>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3_Args((Vector256<long>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3_Args((Vector256<ulong>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3_Args{TIdx}(Vector256{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<TIdx> args0, Vector256<TIdx> args1, Vector256<TIdx> args2, Vector256<TIdx> args3, Vector256<TIdx> args4) YShuffleX3_Args<TIdx>(this IWVectorTraits256 athis, Vector256<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3_Args(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4) YShuffleX3_Args(this IWVectorTraits256 athis, Vector256<sbyte> indices) {
            athis.YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3_Args(Vector256{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4) YShuffleX3_Args(this IWVectorTraits256 athis, Vector256<byte> indices) {
            athis.YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3_Args(Vector256{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4) YShuffleX3_Args(this IWVectorTraits256 athis, Vector256<short> indices) {
            athis.YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3_Args(Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4) YShuffleX3_Args(this IWVectorTraits256 athis, Vector256<ushort> indices) {
            athis.YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3_Args(Vector256{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) YShuffleX3_Args(this IWVectorTraits256 athis, Vector256<int> indices) {
            athis.YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3_Args(Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4) YShuffleX3_Args(this IWVectorTraits256 athis, Vector256<uint> indices) {
            athis.YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3_Args(Vector256{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) YShuffleX3_Args(this IWVectorTraits256 athis, Vector256<long> indices) {
            athis.YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3_Args(Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4) YShuffleX3_Args(this IWVectorTraits256 athis, Vector256<ulong> indices) {
            athis.YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <summary>
        /// Core calculation for shuffle and clear on 3 vectors (在3个向量上进行换位并清零的核心计算). Its arguments are derived from YShuffleX3_Args (其参数来源于 YShuffleX3_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*3))?( element_ref(indices[i], vector0, vector1, vector2) ):0</c>.
        /// </summary>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="athis">This object.</param>
        /// <param name="vector0">The input vector 0 from which values are selected (从中选择值的输入向量0).</param>
        /// <param name="vector1">The input vector 1 from which values are selected (从中选择值的输入向量1).</param>
        /// <param name="vector2">The input vector 2 from which values are selected (从中选择值的输入向量2).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from input vectors selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从输入向量集中选择的值).</returns>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="T"/>, <typeparamref name="TIdx"/>) are not supported.</exception>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<T> YShuffleX3_Core<T, TIdx>(this IWVectorTraits256 athis, Vector256<T> vector0, Vector256<T> vector1, Vector256<T> vector2, (Vector256<TIdx> args0, Vector256<TIdx> args1, Vector256<TIdx> args2, Vector256<TIdx> args3, Vector256<TIdx> args4) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX3_Core((Vector256<float>)(object)vector0, (Vector256<float>)(object)vector1, (Vector256<float>)(object)vector2, (ValueTuple<Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX3_Core((Vector256<double>)(object)vector0, (Vector256<double>)(object)vector1, (Vector256<double>)(object)vector2, (ValueTuple<Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX3_Core((Vector256<sbyte>)(object)vector0, (Vector256<sbyte>)(object)vector1, (Vector256<sbyte>)(object)vector2, (ValueTuple<Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX3_Core((Vector256<byte>)(object)vector0, (Vector256<byte>)(object)vector1, (Vector256<byte>)(object)vector2, (ValueTuple<Vector256<byte>, Vector256<byte>, Vector256<byte>, Vector256<byte>, Vector256<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX3_Core((Vector256<short>)(object)vector0, (Vector256<short>)(object)vector1, (Vector256<short>)(object)vector2, (ValueTuple<Vector256<short>, Vector256<short>, Vector256<short>, Vector256<short>, Vector256<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX3_Core((Vector256<ushort>)(object)vector0, (Vector256<ushort>)(object)vector1, (Vector256<ushort>)(object)vector2, (ValueTuple<Vector256<ushort>, Vector256<ushort>, Vector256<ushort>, Vector256<ushort>, Vector256<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX3_Core((Vector256<int>)(object)vector0, (Vector256<int>)(object)vector1, (Vector256<int>)(object)vector2, (ValueTuple<Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX3_Core((Vector256<uint>)(object)vector0, (Vector256<uint>)(object)vector1, (Vector256<uint>)(object)vector2, (ValueTuple<Vector256<uint>, Vector256<uint>, Vector256<uint>, Vector256<uint>, Vector256<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX3_Core((Vector256<long>)(object)vector0, (Vector256<long>)(object)vector1, (Vector256<long>)(object)vector2, (ValueTuple<Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX3_Core((Vector256<ulong>)(object)vector0, (Vector256<ulong>)(object)vector1, (Vector256<ulong>)(object)vector2, (ValueTuple<Vector256<ulong>, Vector256<ulong>, Vector256<ulong>, Vector256<ulong>, Vector256<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3_Core(Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleX3_Core(this IWVectorTraits256 athis, Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) args) {
            return athis.YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3_Core(Vector256{double}, Vector256{double}, Vector256{double}, ValueTuple{Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleX3_Core(this IWVectorTraits256 athis, Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) args) {
            return athis.YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, ValueTuple{Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleX3_Core(this IWVectorTraits256 athis, Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, (Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4) args) {
            return athis.YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, ValueTuple{Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleX3_Core(this IWVectorTraits256 athis, Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, (Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4) args) {
            return athis.YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3_Core(Vector256{short}, Vector256{short}, Vector256{short}, ValueTuple{Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleX3_Core(this IWVectorTraits256 athis, Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, (Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4) args) {
            return athis.YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, ValueTuple{Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleX3_Core(this IWVectorTraits256 athis, Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, (Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4) args) {
            return athis.YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3_Core(Vector256{int}, Vector256{int}, Vector256{int}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleX3_Core(this IWVectorTraits256 athis, Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) args) {
            return athis.YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, ValueTuple{Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleX3_Core(this IWVectorTraits256 athis, Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, (Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4) args) {
            return athis.YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3_Core(Vector256{long}, Vector256{long}, Vector256{long}, ValueTuple{Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleX3_Core(this IWVectorTraits256 athis, Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) args) {
            return athis.YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, ValueTuple{Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleX3_Core(this IWVectorTraits256 athis, Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, (Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4) args) {
            return athis.YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }


        /// <inheritdoc cref="Vector256s.YShuffleX3Insert_Args{TIdx}(Vector256{TIdx}, out Vector256{TIdx}, out Vector256{TIdx}, out Vector256{TIdx}, out Vector256{TIdx}, out Vector256{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleX3Insert_Args<TIdx>(this IWVectorTraits256 athis, Vector256<TIdx> indices, out Vector256<TIdx> args0, out Vector256<TIdx> args1, out Vector256<TIdx> args2, out Vector256<TIdx> args3, out Vector256<TIdx> args4)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3Insert_Args((Vector256<sbyte>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3Insert_Args((Vector256<byte>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3Insert_Args((Vector256<short>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3Insert_Args((Vector256<ushort>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3Insert_Args((Vector256<int>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3Insert_Args((Vector256<uint>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3Insert_Args((Vector256<long>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3Insert_Args((Vector256<ulong>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3Insert_Args{TIdx}(Vector256{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<TIdx> args0, Vector256<TIdx> args1, Vector256<TIdx> args2, Vector256<TIdx> args3, Vector256<TIdx> args4) YShuffleX3Insert_Args<TIdx>(this IWVectorTraits256 athis, Vector256<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3Insert_Args(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4) YShuffleX3Insert_Args(this IWVectorTraits256 athis, Vector256<sbyte> indices) {
            athis.YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3Insert_Args(Vector256{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4) YShuffleX3Insert_Args(this IWVectorTraits256 athis, Vector256<byte> indices) {
            athis.YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3Insert_Args(Vector256{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4) YShuffleX3Insert_Args(this IWVectorTraits256 athis, Vector256<short> indices) {
            athis.YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3Insert_Args(Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4) YShuffleX3Insert_Args(this IWVectorTraits256 athis, Vector256<ushort> indices) {
            athis.YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3Insert_Args(Vector256{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) YShuffleX3Insert_Args(this IWVectorTraits256 athis, Vector256<int> indices) {
            athis.YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3Insert_Args(Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4) YShuffleX3Insert_Args(this IWVectorTraits256 athis, Vector256<uint> indices) {
            athis.YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3Insert_Args(Vector256{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) YShuffleX3Insert_Args(this IWVectorTraits256 athis, Vector256<long> indices) {
            athis.YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3Insert_Args(Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4) YShuffleX3Insert_Args(this IWVectorTraits256 athis, Vector256<ulong> indices) {
            athis.YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <summary>
        /// Core calculation for shuffle and insert on 3 vectors (在3个向量上进行换位并插入的核心计算). Its arguments are derived from YShuffleX3Insert_Args (其参数来源于 YShuffleX3Insert_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*3))?( element_ref(indices[i], vector0, vector1, vector2) ):back[i]</c>.
        /// </summary>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="athis">This object.</param>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector0">The input vector 0 from which values are selected (从中选择值的输入向量0).</param>
        /// <param name="vector1">The input vector 1 from which values are selected (从中选择值的输入向量1).</param>
        /// <param name="vector2">The input vector 2 from which values are selected (从中选择值的输入向量2).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from input vectors selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从输入向量集中选择的值).</returns>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="T"/>, <typeparamref name="TIdx"/>) are not supported.</exception>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<T> YShuffleX3Insert_Core<T, TIdx>(this IWVectorTraits256 athis, Vector256<T> back, Vector256<T> vector0, Vector256<T> vector1, Vector256<T> vector2, (Vector256<TIdx> args0, Vector256<TIdx> args1, Vector256<TIdx> args2, Vector256<TIdx> args3, Vector256<TIdx> args4) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX3Insert_Core((Vector256<float>)(object)back, (Vector256<float>)(object)vector0, (Vector256<float>)(object)vector1, (Vector256<float>)(object)vector2, (ValueTuple<Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX3Insert_Core((Vector256<double>)(object)back, (Vector256<double>)(object)vector0, (Vector256<double>)(object)vector1, (Vector256<double>)(object)vector2, (ValueTuple<Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX3Insert_Core((Vector256<sbyte>)(object)back, (Vector256<sbyte>)(object)vector0, (Vector256<sbyte>)(object)vector1, (Vector256<sbyte>)(object)vector2, (ValueTuple<Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX3Insert_Core((Vector256<byte>)(object)back, (Vector256<byte>)(object)vector0, (Vector256<byte>)(object)vector1, (Vector256<byte>)(object)vector2, (ValueTuple<Vector256<byte>, Vector256<byte>, Vector256<byte>, Vector256<byte>, Vector256<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX3Insert_Core((Vector256<short>)(object)back, (Vector256<short>)(object)vector0, (Vector256<short>)(object)vector1, (Vector256<short>)(object)vector2, (ValueTuple<Vector256<short>, Vector256<short>, Vector256<short>, Vector256<short>, Vector256<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX3Insert_Core((Vector256<ushort>)(object)back, (Vector256<ushort>)(object)vector0, (Vector256<ushort>)(object)vector1, (Vector256<ushort>)(object)vector2, (ValueTuple<Vector256<ushort>, Vector256<ushort>, Vector256<ushort>, Vector256<ushort>, Vector256<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX3Insert_Core((Vector256<int>)(object)back, (Vector256<int>)(object)vector0, (Vector256<int>)(object)vector1, (Vector256<int>)(object)vector2, (ValueTuple<Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX3Insert_Core((Vector256<uint>)(object)back, (Vector256<uint>)(object)vector0, (Vector256<uint>)(object)vector1, (Vector256<uint>)(object)vector2, (ValueTuple<Vector256<uint>, Vector256<uint>, Vector256<uint>, Vector256<uint>, Vector256<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX3Insert_Core((Vector256<long>)(object)back, (Vector256<long>)(object)vector0, (Vector256<long>)(object)vector1, (Vector256<long>)(object)vector2, (ValueTuple<Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX3Insert_Core((Vector256<ulong>)(object)back, (Vector256<ulong>)(object)vector0, (Vector256<ulong>)(object)vector1, (Vector256<ulong>)(object)vector2, (ValueTuple<Vector256<ulong>, Vector256<ulong>, Vector256<ulong>, Vector256<ulong>, Vector256<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleX3Insert_Core(this IWVectorTraits256 athis, Vector256<float> back, Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) args) {
            return athis.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3Insert_Core(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, ValueTuple{Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleX3Insert_Core(this IWVectorTraits256 athis, Vector256<double> back, Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) args) {
            return athis.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3Insert_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, ValueTuple{Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleX3Insert_Core(this IWVectorTraits256 athis, Vector256<sbyte> back, Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, (Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4) args) {
            return athis.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3Insert_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, ValueTuple{Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleX3Insert_Core(this IWVectorTraits256 athis, Vector256<byte> back, Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, (Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4) args) {
            return athis.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3Insert_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, ValueTuple{Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleX3Insert_Core(this IWVectorTraits256 athis, Vector256<short> back, Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, (Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4) args) {
            return athis.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3Insert_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, ValueTuple{Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleX3Insert_Core(this IWVectorTraits256 athis, Vector256<ushort> back, Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, (Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4) args) {
            return athis.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3Insert_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleX3Insert_Core(this IWVectorTraits256 athis, Vector256<int> back, Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) args) {
            return athis.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3Insert_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, ValueTuple{Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleX3Insert_Core(this IWVectorTraits256 athis, Vector256<uint> back, Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, (Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4) args) {
            return athis.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3Insert_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, ValueTuple{Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleX3Insert_Core(this IWVectorTraits256 athis, Vector256<long> back, Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) args) {
            return athis.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3Insert_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, ValueTuple{Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleX3Insert_Core(this IWVectorTraits256 athis, Vector256<ulong> back, Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, (Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4) args) {
            return athis.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }


        /// <inheritdoc cref="Vector256s.YShuffleX3Kernel_Args{TIdx}(Vector256{TIdx}, out Vector256{TIdx}, out Vector256{TIdx}, out Vector256{TIdx}, out Vector256{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleX3Kernel_Args<TIdx>(this IWVectorTraits256 athis, Vector256<TIdx> indices, out Vector256<TIdx> args0, out Vector256<TIdx> args1, out Vector256<TIdx> args2, out Vector256<TIdx> args3)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX3Kernel_Args((Vector256<sbyte>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX3Kernel_Args((Vector256<byte>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX3Kernel_Args((Vector256<short>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX3Kernel_Args((Vector256<ushort>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX3Kernel_Args((Vector256<int>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX3Kernel_Args((Vector256<uint>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX3Kernel_Args((Vector256<long>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX3Kernel_Args((Vector256<ulong>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3Kernel_Args{TIdx}(Vector256{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<TIdx> args0, Vector256<TIdx> args1, Vector256<TIdx> args2, Vector256<TIdx> args3) YShuffleX3Kernel_Args<TIdx>(this IWVectorTraits256 athis, Vector256<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3Kernel_Args(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3) YShuffleX3Kernel_Args(this IWVectorTraits256 athis, Vector256<sbyte> indices) {
            athis.YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3Kernel_Args(Vector256{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3) YShuffleX3Kernel_Args(this IWVectorTraits256 athis, Vector256<byte> indices) {
            athis.YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3Kernel_Args(Vector256{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3) YShuffleX3Kernel_Args(this IWVectorTraits256 athis, Vector256<short> indices) {
            athis.YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3Kernel_Args(Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3) YShuffleX3Kernel_Args(this IWVectorTraits256 athis, Vector256<ushort> indices) {
            athis.YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3Kernel_Args(Vector256{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3) YShuffleX3Kernel_Args(this IWVectorTraits256 athis, Vector256<int> indices) {
            athis.YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3Kernel_Args(Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3) YShuffleX3Kernel_Args(this IWVectorTraits256 athis, Vector256<uint> indices) {
            athis.YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3Kernel_Args(Vector256{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3) YShuffleX3Kernel_Args(this IWVectorTraits256 athis, Vector256<long> indices) {
            athis.YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3Kernel_Args(Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3) YShuffleX3Kernel_Args(this IWVectorTraits256 athis, Vector256<ulong> indices) {
            athis.YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <summary>
        /// Core calculation for only shuffle on 3 vectors (在3个向量上进行仅换位的核心计算). Its arguments are derived from YShuffleX3Kernel_Args (其参数来源于 YShuffleX3Kernel_Args).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1, vector2)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*3)</c>.
        /// </summary>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="athis">This object.</param>
        /// <param name="vector0">The input vector 0 from which values are selected (从中选择值的输入向量0).</param>
        /// <param name="vector1">The input vector 1 from which values are selected (从中选择值的输入向量1).</param>
        /// <param name="vector2">The input vector 2 from which values are selected (从中选择值的输入向量2).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from input vectors selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从输入向量集中选择的值).</returns>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="T"/>, <typeparamref name="TIdx"/>) are not supported.</exception>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<T> YShuffleX3Kernel_Core<T, TIdx>(this IWVectorTraits256 athis, Vector256<T> vector0, Vector256<T> vector1, Vector256<T> vector2, (Vector256<TIdx> args0, Vector256<TIdx> args1, Vector256<TIdx> args2, Vector256<TIdx> args3) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX3Kernel_Core((Vector256<float>)(object)vector0, (Vector256<float>)(object)vector1, (Vector256<float>)(object)vector2, (ValueTuple<Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX3Kernel_Core((Vector256<double>)(object)vector0, (Vector256<double>)(object)vector1, (Vector256<double>)(object)vector2, (ValueTuple<Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX3Kernel_Core((Vector256<sbyte>)(object)vector0, (Vector256<sbyte>)(object)vector1, (Vector256<sbyte>)(object)vector2, (ValueTuple<Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX3Kernel_Core((Vector256<byte>)(object)vector0, (Vector256<byte>)(object)vector1, (Vector256<byte>)(object)vector2, (ValueTuple<Vector256<byte>, Vector256<byte>, Vector256<byte>, Vector256<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX3Kernel_Core((Vector256<short>)(object)vector0, (Vector256<short>)(object)vector1, (Vector256<short>)(object)vector2, (ValueTuple<Vector256<short>, Vector256<short>, Vector256<short>, Vector256<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX3Kernel_Core((Vector256<ushort>)(object)vector0, (Vector256<ushort>)(object)vector1, (Vector256<ushort>)(object)vector2, (ValueTuple<Vector256<ushort>, Vector256<ushort>, Vector256<ushort>, Vector256<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX3Kernel_Core((Vector256<int>)(object)vector0, (Vector256<int>)(object)vector1, (Vector256<int>)(object)vector2, (ValueTuple<Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX3Kernel_Core((Vector256<uint>)(object)vector0, (Vector256<uint>)(object)vector1, (Vector256<uint>)(object)vector2, (ValueTuple<Vector256<uint>, Vector256<uint>, Vector256<uint>, Vector256<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX3Kernel_Core((Vector256<long>)(object)vector0, (Vector256<long>)(object)vector1, (Vector256<long>)(object)vector2, (ValueTuple<Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX3Kernel_Core((Vector256<ulong>)(object)vector0, (Vector256<ulong>)(object)vector1, (Vector256<ulong>)(object)vector2, (ValueTuple<Vector256<ulong>, Vector256<ulong>, Vector256<ulong>, Vector256<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleX3Kernel_Core(this IWVectorTraits256 athis, Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3) args) {
            return athis.YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3Kernel_Core(Vector256{double}, Vector256{double}, Vector256{double}, ValueTuple{Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleX3Kernel_Core(this IWVectorTraits256 athis, Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3) args) {
            return athis.YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3Kernel_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, ValueTuple{Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleX3Kernel_Core(this IWVectorTraits256 athis, Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, (Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3) args) {
            return athis.YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3Kernel_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, ValueTuple{Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleX3Kernel_Core(this IWVectorTraits256 athis, Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, (Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3) args) {
            return athis.YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3Kernel_Core(Vector256{short}, Vector256{short}, Vector256{short}, ValueTuple{Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleX3Kernel_Core(this IWVectorTraits256 athis, Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, (Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3) args) {
            return athis.YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3Kernel_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, ValueTuple{Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleX3Kernel_Core(this IWVectorTraits256 athis, Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, (Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3) args) {
            return athis.YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3Kernel_Core(Vector256{int}, Vector256{int}, Vector256{int}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleX3Kernel_Core(this IWVectorTraits256 athis, Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3) args) {
            return athis.YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3Kernel_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, ValueTuple{Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleX3Kernel_Core(this IWVectorTraits256 athis, Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, (Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3) args) {
            return athis.YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3Kernel_Core(Vector256{long}, Vector256{long}, Vector256{long}, ValueTuple{Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleX3Kernel_Core(this IWVectorTraits256 athis, Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3) args) {
            return athis.YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX3Kernel_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, ValueTuple{Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleX3Kernel_Core(this IWVectorTraits256 athis, Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, (Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3) args) {
            return athis.YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }


        /// <inheritdoc cref="Vector256s.YShuffleX4_Args{TIdx}(Vector256{TIdx}, out Vector256{TIdx}, out Vector256{TIdx}, out Vector256{TIdx}, out Vector256{TIdx}, out Vector256{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleX4_Args<TIdx>(this IWVectorTraits256 athis, Vector256<TIdx> indices, out Vector256<TIdx> args0, out Vector256<TIdx> args1, out Vector256<TIdx> args2, out Vector256<TIdx> args3, out Vector256<TIdx> args4)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4_Args((Vector256<sbyte>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4_Args((Vector256<byte>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4_Args((Vector256<short>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4_Args((Vector256<ushort>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4_Args((Vector256<int>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4_Args((Vector256<uint>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4_Args((Vector256<long>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4_Args((Vector256<ulong>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4_Args{TIdx}(Vector256{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<TIdx> args0, Vector256<TIdx> args1, Vector256<TIdx> args2, Vector256<TIdx> args3, Vector256<TIdx> args4) YShuffleX4_Args<TIdx>(this IWVectorTraits256 athis, Vector256<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4_Args(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4) YShuffleX4_Args(this IWVectorTraits256 athis, Vector256<sbyte> indices) {
            athis.YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4_Args(Vector256{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4) YShuffleX4_Args(this IWVectorTraits256 athis, Vector256<byte> indices) {
            athis.YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4_Args(Vector256{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4) YShuffleX4_Args(this IWVectorTraits256 athis, Vector256<short> indices) {
            athis.YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4_Args(Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4) YShuffleX4_Args(this IWVectorTraits256 athis, Vector256<ushort> indices) {
            athis.YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4_Args(Vector256{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) YShuffleX4_Args(this IWVectorTraits256 athis, Vector256<int> indices) {
            athis.YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4_Args(Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4) YShuffleX4_Args(this IWVectorTraits256 athis, Vector256<uint> indices) {
            athis.YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4_Args(Vector256{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) YShuffleX4_Args(this IWVectorTraits256 athis, Vector256<long> indices) {
            athis.YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4_Args(Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4) YShuffleX4_Args(this IWVectorTraits256 athis, Vector256<ulong> indices) {
            athis.YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <summary>
        /// Core calculation for shuffle and clear on 4 vectors (在4个向量上进行换位并清零的核心计算). Its arguments are derived from YShuffleX4_Args (其参数来源于 YShuffleX4_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*4))?( element_ref(indices[i], vector0, vector1, vector2, vector3) ):0</c>.
        /// </summary>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="athis">This object.</param>
        /// <param name="vector0">The input vector 0 from which values are selected (从中选择值的输入向量0).</param>
        /// <param name="vector1">The input vector 1 from which values are selected (从中选择值的输入向量1).</param>
        /// <param name="vector2">The input vector 2 from which values are selected (从中选择值的输入向量2).</param>
        /// <param name="vector3">The input vector 3 from which values are selected (从中选择值的输入向量3).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from input vectors selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从输入向量集中选择的值).</returns>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="T"/>, <typeparamref name="TIdx"/>) are not supported.</exception>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<T> YShuffleX4_Core<T, TIdx>(this IWVectorTraits256 athis, Vector256<T> vector0, Vector256<T> vector1, Vector256<T> vector2, Vector256<T> vector3, (Vector256<TIdx> args0, Vector256<TIdx> args1, Vector256<TIdx> args2, Vector256<TIdx> args3, Vector256<TIdx> args4) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX4_Core((Vector256<float>)(object)vector0, (Vector256<float>)(object)vector1, (Vector256<float>)(object)vector2, (Vector256<float>)(object)vector3, (ValueTuple<Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX4_Core((Vector256<double>)(object)vector0, (Vector256<double>)(object)vector1, (Vector256<double>)(object)vector2, (Vector256<double>)(object)vector3, (ValueTuple<Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX4_Core((Vector256<sbyte>)(object)vector0, (Vector256<sbyte>)(object)vector1, (Vector256<sbyte>)(object)vector2, (Vector256<sbyte>)(object)vector3, (ValueTuple<Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX4_Core((Vector256<byte>)(object)vector0, (Vector256<byte>)(object)vector1, (Vector256<byte>)(object)vector2, (Vector256<byte>)(object)vector3, (ValueTuple<Vector256<byte>, Vector256<byte>, Vector256<byte>, Vector256<byte>, Vector256<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX4_Core((Vector256<short>)(object)vector0, (Vector256<short>)(object)vector1, (Vector256<short>)(object)vector2, (Vector256<short>)(object)vector3, (ValueTuple<Vector256<short>, Vector256<short>, Vector256<short>, Vector256<short>, Vector256<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX4_Core((Vector256<ushort>)(object)vector0, (Vector256<ushort>)(object)vector1, (Vector256<ushort>)(object)vector2, (Vector256<ushort>)(object)vector3, (ValueTuple<Vector256<ushort>, Vector256<ushort>, Vector256<ushort>, Vector256<ushort>, Vector256<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX4_Core((Vector256<int>)(object)vector0, (Vector256<int>)(object)vector1, (Vector256<int>)(object)vector2, (Vector256<int>)(object)vector3, (ValueTuple<Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX4_Core((Vector256<uint>)(object)vector0, (Vector256<uint>)(object)vector1, (Vector256<uint>)(object)vector2, (Vector256<uint>)(object)vector3, (ValueTuple<Vector256<uint>, Vector256<uint>, Vector256<uint>, Vector256<uint>, Vector256<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX4_Core((Vector256<long>)(object)vector0, (Vector256<long>)(object)vector1, (Vector256<long>)(object)vector2, (Vector256<long>)(object)vector3, (ValueTuple<Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX4_Core((Vector256<ulong>)(object)vector0, (Vector256<ulong>)(object)vector1, (Vector256<ulong>)(object)vector2, (Vector256<ulong>)(object)vector3, (ValueTuple<Vector256<ulong>, Vector256<ulong>, Vector256<ulong>, Vector256<ulong>, Vector256<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleX4_Core(this IWVectorTraits256 athis, Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, Vector256<float> vector3, (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) args) {
            return athis.YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4_Core(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, ValueTuple{Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleX4_Core(this IWVectorTraits256 athis, Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, Vector256<double> vector3, (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) args) {
            return athis.YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, ValueTuple{Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleX4_Core(this IWVectorTraits256 athis, Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, Vector256<sbyte> vector3, (Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4) args) {
            return athis.YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, ValueTuple{Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleX4_Core(this IWVectorTraits256 athis, Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> vector3, (Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4) args) {
            return athis.YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, ValueTuple{Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleX4_Core(this IWVectorTraits256 athis, Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, Vector256<short> vector3, (Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4) args) {
            return athis.YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, ValueTuple{Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleX4_Core(this IWVectorTraits256 athis, Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, Vector256<ushort> vector3, (Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4) args) {
            return athis.YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleX4_Core(this IWVectorTraits256 athis, Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, Vector256<int> vector3, (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) args) {
            return athis.YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, ValueTuple{Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleX4_Core(this IWVectorTraits256 athis, Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, Vector256<uint> vector3, (Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4) args) {
            return athis.YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, ValueTuple{Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleX4_Core(this IWVectorTraits256 athis, Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, Vector256<long> vector3, (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) args) {
            return athis.YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, ValueTuple{Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleX4_Core(this IWVectorTraits256 athis, Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, Vector256<ulong> vector3, (Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4) args) {
            return athis.YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }


        /// <inheritdoc cref="Vector256s.YShuffleX4Insert_Args{TIdx}(Vector256{TIdx}, out Vector256{TIdx}, out Vector256{TIdx}, out Vector256{TIdx}, out Vector256{TIdx}, out Vector256{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleX4Insert_Args<TIdx>(this IWVectorTraits256 athis, Vector256<TIdx> indices, out Vector256<TIdx> args0, out Vector256<TIdx> args1, out Vector256<TIdx> args2, out Vector256<TIdx> args3, out Vector256<TIdx> args4)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4Insert_Args((Vector256<sbyte>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4Insert_Args((Vector256<byte>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4Insert_Args((Vector256<short>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4Insert_Args((Vector256<ushort>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4Insert_Args((Vector256<int>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4Insert_Args((Vector256<uint>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4Insert_Args((Vector256<long>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4Insert_Args((Vector256<ulong>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
                args4 = (Vector256<TIdx>)(object)e;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4Insert_Args{TIdx}(Vector256{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<TIdx> args0, Vector256<TIdx> args1, Vector256<TIdx> args2, Vector256<TIdx> args3, Vector256<TIdx> args4) YShuffleX4Insert_Args<TIdx>(this IWVectorTraits256 athis, Vector256<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4Insert_Args(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4) YShuffleX4Insert_Args(this IWVectorTraits256 athis, Vector256<sbyte> indices) {
            athis.YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4Insert_Args(Vector256{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4) YShuffleX4Insert_Args(this IWVectorTraits256 athis, Vector256<byte> indices) {
            athis.YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4Insert_Args(Vector256{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4) YShuffleX4Insert_Args(this IWVectorTraits256 athis, Vector256<short> indices) {
            athis.YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4Insert_Args(Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4) YShuffleX4Insert_Args(this IWVectorTraits256 athis, Vector256<ushort> indices) {
            athis.YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4Insert_Args(Vector256{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) YShuffleX4Insert_Args(this IWVectorTraits256 athis, Vector256<int> indices) {
            athis.YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4Insert_Args(Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4) YShuffleX4Insert_Args(this IWVectorTraits256 athis, Vector256<uint> indices) {
            athis.YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4Insert_Args(Vector256{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) YShuffleX4Insert_Args(this IWVectorTraits256 athis, Vector256<long> indices) {
            athis.YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4Insert_Args(Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4) YShuffleX4Insert_Args(this IWVectorTraits256 athis, Vector256<ulong> indices) {
            athis.YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <summary>
        /// Core calculation for shuffle and insert on 4 vectors (在4个向量上进行换位并插入的核心计算). Its arguments are derived from YShuffleX4Insert_Args (其参数来源于 YShuffleX4Insert_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*4))?( element_ref(indices[i], vector0, vector1, vector2, vector3) ):back[i]</c>.
        /// </summary>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="athis">This object.</param>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector0">The input vector 0 from which values are selected (从中选择值的输入向量0).</param>
        /// <param name="vector1">The input vector 1 from which values are selected (从中选择值的输入向量1).</param>
        /// <param name="vector2">The input vector 2 from which values are selected (从中选择值的输入向量2).</param>
        /// <param name="vector3">The input vector 3 from which values are selected (从中选择值的输入向量3).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from input vectors selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从输入向量集中选择的值).</returns>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="T"/>, <typeparamref name="TIdx"/>) are not supported.</exception>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<T> YShuffleX4Insert_Core<T, TIdx>(this IWVectorTraits256 athis, Vector256<T> back, Vector256<T> vector0, Vector256<T> vector1, Vector256<T> vector2, Vector256<T> vector3, (Vector256<TIdx> args0, Vector256<TIdx> args1, Vector256<TIdx> args2, Vector256<TIdx> args3, Vector256<TIdx> args4) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX4Insert_Core((Vector256<float>)(object)back, (Vector256<float>)(object)vector0, (Vector256<float>)(object)vector1, (Vector256<float>)(object)vector2, (Vector256<float>)(object)vector3, (ValueTuple<Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX4Insert_Core((Vector256<double>)(object)back, (Vector256<double>)(object)vector0, (Vector256<double>)(object)vector1, (Vector256<double>)(object)vector2, (Vector256<double>)(object)vector3, (ValueTuple<Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX4Insert_Core((Vector256<sbyte>)(object)back, (Vector256<sbyte>)(object)vector0, (Vector256<sbyte>)(object)vector1, (Vector256<sbyte>)(object)vector2, (Vector256<sbyte>)(object)vector3, (ValueTuple<Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX4Insert_Core((Vector256<byte>)(object)back, (Vector256<byte>)(object)vector0, (Vector256<byte>)(object)vector1, (Vector256<byte>)(object)vector2, (Vector256<byte>)(object)vector3, (ValueTuple<Vector256<byte>, Vector256<byte>, Vector256<byte>, Vector256<byte>, Vector256<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX4Insert_Core((Vector256<short>)(object)back, (Vector256<short>)(object)vector0, (Vector256<short>)(object)vector1, (Vector256<short>)(object)vector2, (Vector256<short>)(object)vector3, (ValueTuple<Vector256<short>, Vector256<short>, Vector256<short>, Vector256<short>, Vector256<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX4Insert_Core((Vector256<ushort>)(object)back, (Vector256<ushort>)(object)vector0, (Vector256<ushort>)(object)vector1, (Vector256<ushort>)(object)vector2, (Vector256<ushort>)(object)vector3, (ValueTuple<Vector256<ushort>, Vector256<ushort>, Vector256<ushort>, Vector256<ushort>, Vector256<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX4Insert_Core((Vector256<int>)(object)back, (Vector256<int>)(object)vector0, (Vector256<int>)(object)vector1, (Vector256<int>)(object)vector2, (Vector256<int>)(object)vector3, (ValueTuple<Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX4Insert_Core((Vector256<uint>)(object)back, (Vector256<uint>)(object)vector0, (Vector256<uint>)(object)vector1, (Vector256<uint>)(object)vector2, (Vector256<uint>)(object)vector3, (ValueTuple<Vector256<uint>, Vector256<uint>, Vector256<uint>, Vector256<uint>, Vector256<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX4Insert_Core((Vector256<long>)(object)back, (Vector256<long>)(object)vector0, (Vector256<long>)(object)vector1, (Vector256<long>)(object)vector2, (Vector256<long>)(object)vector3, (ValueTuple<Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX4Insert_Core((Vector256<ulong>)(object)back, (Vector256<ulong>)(object)vector0, (Vector256<ulong>)(object)vector1, (Vector256<ulong>)(object)vector2, (Vector256<ulong>)(object)vector3, (ValueTuple<Vector256<ulong>, Vector256<ulong>, Vector256<ulong>, Vector256<ulong>, Vector256<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleX4Insert_Core(this IWVectorTraits256 athis, Vector256<float> back, Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, Vector256<float> vector3, (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) args) {
            return athis.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4Insert_Core(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, ValueTuple{Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleX4Insert_Core(this IWVectorTraits256 athis, Vector256<double> back, Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, Vector256<double> vector3, (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) args) {
            return athis.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4Insert_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, ValueTuple{Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleX4Insert_Core(this IWVectorTraits256 athis, Vector256<sbyte> back, Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, Vector256<sbyte> vector3, (Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4) args) {
            return athis.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4Insert_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, ValueTuple{Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleX4Insert_Core(this IWVectorTraits256 athis, Vector256<byte> back, Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> vector3, (Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4) args) {
            return athis.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4Insert_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, ValueTuple{Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleX4Insert_Core(this IWVectorTraits256 athis, Vector256<short> back, Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, Vector256<short> vector3, (Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4) args) {
            return athis.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4Insert_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, ValueTuple{Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleX4Insert_Core(this IWVectorTraits256 athis, Vector256<ushort> back, Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, Vector256<ushort> vector3, (Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4) args) {
            return athis.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4Insert_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleX4Insert_Core(this IWVectorTraits256 athis, Vector256<int> back, Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, Vector256<int> vector3, (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) args) {
            return athis.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4Insert_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, ValueTuple{Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleX4Insert_Core(this IWVectorTraits256 athis, Vector256<uint> back, Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, Vector256<uint> vector3, (Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4) args) {
            return athis.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4Insert_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, ValueTuple{Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleX4Insert_Core(this IWVectorTraits256 athis, Vector256<long> back, Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, Vector256<long> vector3, (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) args) {
            return athis.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4Insert_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, ValueTuple{Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleX4Insert_Core(this IWVectorTraits256 athis, Vector256<ulong> back, Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, Vector256<ulong> vector3, (Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4) args) {
            return athis.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }


        /// <inheritdoc cref="Vector256s.YShuffleX4Kernel_Args{TIdx}(Vector256{TIdx}, out Vector256{TIdx}, out Vector256{TIdx}, out Vector256{TIdx}, out Vector256{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleX4Kernel_Args<TIdx>(this IWVectorTraits256 athis, Vector256<TIdx> indices, out Vector256<TIdx> args0, out Vector256<TIdx> args1, out Vector256<TIdx> args2, out Vector256<TIdx> args3)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX4Kernel_Args((Vector256<sbyte>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX4Kernel_Args((Vector256<byte>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX4Kernel_Args((Vector256<short>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX4Kernel_Args((Vector256<ushort>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX4Kernel_Args((Vector256<int>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX4Kernel_Args((Vector256<uint>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX4Kernel_Args((Vector256<long>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX4Kernel_Args((Vector256<ulong>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
                args2 = (Vector256<TIdx>)(object)c;
                args3 = (Vector256<TIdx>)(object)d;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4Kernel_Args{TIdx}(Vector256{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<TIdx> args0, Vector256<TIdx> args1, Vector256<TIdx> args2, Vector256<TIdx> args3) YShuffleX4Kernel_Args<TIdx>(this IWVectorTraits256 athis, Vector256<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4Kernel_Args(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3) YShuffleX4Kernel_Args(this IWVectorTraits256 athis, Vector256<sbyte> indices) {
            athis.YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4Kernel_Args(Vector256{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3) YShuffleX4Kernel_Args(this IWVectorTraits256 athis, Vector256<byte> indices) {
            athis.YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4Kernel_Args(Vector256{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3) YShuffleX4Kernel_Args(this IWVectorTraits256 athis, Vector256<short> indices) {
            athis.YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4Kernel_Args(Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3) YShuffleX4Kernel_Args(this IWVectorTraits256 athis, Vector256<ushort> indices) {
            athis.YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4Kernel_Args(Vector256{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3) YShuffleX4Kernel_Args(this IWVectorTraits256 athis, Vector256<int> indices) {
            athis.YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4Kernel_Args(Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3) YShuffleX4Kernel_Args(this IWVectorTraits256 athis, Vector256<uint> indices) {
            athis.YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4Kernel_Args(Vector256{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3) YShuffleX4Kernel_Args(this IWVectorTraits256 athis, Vector256<long> indices) {
            athis.YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4Kernel_Args(Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3) YShuffleX4Kernel_Args(this IWVectorTraits256 athis, Vector256<ulong> indices) {
            athis.YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <summary>
        /// Core calculation for only shuffle on 4 vectors (在4个向量上进行仅换位的核心计算). Its arguments are derived from YShuffleX4Kernel_Args (其参数来源于 YShuffleX4Kernel_Args).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1, vector2, vector3)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*4)</c>.
        /// </summary>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="athis">This object.</param>
        /// <param name="vector0">The input vector 0 from which values are selected (从中选择值的输入向量0).</param>
        /// <param name="vector1">The input vector 1 from which values are selected (从中选择值的输入向量1).</param>
        /// <param name="vector2">The input vector 2 from which values are selected (从中选择值的输入向量2).</param>
        /// <param name="vector3">The input vector 3 from which values are selected (从中选择值的输入向量3).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from input vectors selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从输入向量集中选择的值).</returns>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="T"/>, <typeparamref name="TIdx"/>) are not supported.</exception>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<T> YShuffleX4Kernel_Core<T, TIdx>(this IWVectorTraits256 athis, Vector256<T> vector0, Vector256<T> vector1, Vector256<T> vector2, Vector256<T> vector3, (Vector256<TIdx> args0, Vector256<TIdx> args1, Vector256<TIdx> args2, Vector256<TIdx> args3) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX4Kernel_Core((Vector256<float>)(object)vector0, (Vector256<float>)(object)vector1, (Vector256<float>)(object)vector2, (Vector256<float>)(object)vector3, (ValueTuple<Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX4Kernel_Core((Vector256<double>)(object)vector0, (Vector256<double>)(object)vector1, (Vector256<double>)(object)vector2, (Vector256<double>)(object)vector3, (ValueTuple<Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX4Kernel_Core((Vector256<sbyte>)(object)vector0, (Vector256<sbyte>)(object)vector1, (Vector256<sbyte>)(object)vector2, (Vector256<sbyte>)(object)vector3, (ValueTuple<Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX4Kernel_Core((Vector256<byte>)(object)vector0, (Vector256<byte>)(object)vector1, (Vector256<byte>)(object)vector2, (Vector256<byte>)(object)vector3, (ValueTuple<Vector256<byte>, Vector256<byte>, Vector256<byte>, Vector256<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX4Kernel_Core((Vector256<short>)(object)vector0, (Vector256<short>)(object)vector1, (Vector256<short>)(object)vector2, (Vector256<short>)(object)vector3,(ValueTuple<Vector256<short>, Vector256<short>, Vector256<short>, Vector256<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX4Kernel_Core((Vector256<ushort>)(object)vector0, (Vector256<ushort>)(object)vector1, (Vector256<ushort>)(object)vector2, (Vector256<ushort>)(object)vector3, (ValueTuple<Vector256<ushort>, Vector256<ushort>, Vector256<ushort>, Vector256<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX4Kernel_Core((Vector256<int>)(object)vector0, (Vector256<int>)(object)vector1, (Vector256<int>)(object)vector2, (Vector256<int>)(object)vector3, (ValueTuple<Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX4Kernel_Core((Vector256<uint>)(object)vector0, (Vector256<uint>)(object)vector1, (Vector256<uint>)(object)vector2, (Vector256<uint>)(object)vector3, (ValueTuple<Vector256<uint>, Vector256<uint>, Vector256<uint>, Vector256<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX4Kernel_Core((Vector256<long>)(object)vector0, (Vector256<long>)(object)vector1, (Vector256<long>)(object)vector2, (Vector256<long>)(object)vector3, (ValueTuple<Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.YShuffleX4Kernel_Core((Vector256<ulong>)(object)vector0, (Vector256<ulong>)(object)vector1, (Vector256<ulong>)(object)vector2, (Vector256<ulong>)(object)vector3, (ValueTuple<Vector256<ulong>, Vector256<ulong>, Vector256<ulong>, Vector256<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleX4Kernel_Core(this IWVectorTraits256 athis, Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, Vector256<float> vector3, (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3) args) {
            return athis.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4Kernel_Core(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, ValueTuple{Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleX4Kernel_Core(this IWVectorTraits256 athis, Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, Vector256<double> vector3, (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3) args) {
            return athis.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4Kernel_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, ValueTuple{Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleX4Kernel_Core(this IWVectorTraits256 athis, Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, Vector256<sbyte> vector3, (Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3) args) {
            return athis.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4Kernel_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, ValueTuple{Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleX4Kernel_Core(this IWVectorTraits256 athis, Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> vector3, (Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3) args) {
            return athis.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4Kernel_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, ValueTuple{Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleX4Kernel_Core(this IWVectorTraits256 athis, Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, Vector256<short> vector3, (Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3) args) {
            return athis.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4Kernel_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, ValueTuple{Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleX4Kernel_Core(this IWVectorTraits256 athis, Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, Vector256<ushort> vector3, (Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3) args) {
            return athis.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4Kernel_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleX4Kernel_Core(this IWVectorTraits256 athis, Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, Vector256<int> vector3, (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3) args) {
            return athis.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4Kernel_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, ValueTuple{Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleX4Kernel_Core(this IWVectorTraits256 athis, Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, Vector256<uint> vector3, (Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3) args) {
            return athis.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4Kernel_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, ValueTuple{Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleX4Kernel_Core(this IWVectorTraits256 athis, Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, Vector256<long> vector3, (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3) args) {
            return athis.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector256s.YShuffleX4Kernel_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, ValueTuple{Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleX4Kernel_Core(this IWVectorTraits256 athis, Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, Vector256<ulong> vector3, (Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3) args) {
            return athis.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
