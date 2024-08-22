﻿#if NET7_0_OR_GREATER
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
    partial class IWVectorTraits512_Extensions {
#if NET8_0_OR_GREATER

#if BCL_TYPE_INT128

        /// <inheritdoc cref="Vector512s.YGroup2Unzip(Vector512{ExInt128}, Vector512{ExInt128}, out Vector512{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<Int128> YGroup2Unzip(this IWVectorTraits512 athis, Vector512<Int128> data0, Vector512<Int128> data1, out Vector512<Int128> y) {
            var d0 = athis.YGroup2Unzip(data0.ExAsExInt128(), data1.ExAsExInt128(), out var d1);
            y = d1.ExAsInt128();
            return d0.ExAsInt128();
        }

        /// <inheritdoc cref="Vector512s.YGroup2Unzip(Vector512{ExUInt128}, Vector512{ExUInt128}, out Vector512{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<UInt128> YGroup2Unzip(this IWVectorTraits512 athis, Vector512<UInt128> data0, Vector512<UInt128> data1, out Vector512<UInt128> y) {
            var d0 = athis.YGroup2Unzip(data0.ExAsExUInt128(), data1.ExAsExUInt128(), out var d1);
            y = d1.ExAsUInt128();
            return d0.ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="Vector512s.YGroup2Unzip{T}(Vector512{T}, Vector512{T})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static (Vector512<T> X, Vector512<T> Y) YGroup2Unzip<T>(this IWVectorTraits512 athis, Vector512<T> data0, Vector512<T> data1) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip((Vector512<float>)(object)data0, (Vector512<float>)(object)data1);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip((Vector512<double>)(object)data0, (Vector512<double>)(object)data1);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip((Vector512<sbyte>)(object)data0, (Vector512<sbyte>)(object)data1);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip((Vector512<byte>)(object)data0, (Vector512<byte>)(object)data1);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip((Vector512<short>)(object)data0, (Vector512<short>)(object)data1);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip((Vector512<ushort>)(object)data0, (Vector512<ushort>)(object)data1);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip((Vector512<int>)(object)data0, (Vector512<int>)(object)data1);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip((Vector512<uint>)(object)data0, (Vector512<uint>)(object)data1);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip((Vector512<long>)(object)data0, (Vector512<long>)(object)data1);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip((Vector512<ulong>)(object)data0, (Vector512<ulong>)(object)data1);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1);
            } else if (typeof(ExInt128) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip((Vector512<ExInt128>)(object)data0, (Vector512<ExInt128>)(object)data1);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1);
            } else if (typeof(ExUInt128) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip((Vector512<ExUInt128>)(object)data0, (Vector512<ExUInt128>)(object)data1);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1);
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip((Vector512<Int128>)(object)data0, (Vector512<Int128>)(object)data1);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1);
            } else if (typeof(UInt128) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip((Vector512<UInt128>)(object)data0, (Vector512<UInt128>)(object)data1);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1);
#endif // BCL_TYPE_INT128
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector512s.YGroup2Unzip(Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<float> X, Vector512<float> Y) YGroup2Unzip(this IWVectorTraits512 athis, Vector512<float> data0, Vector512<float> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector512s.YGroup2Unzip(Vector512{double}, Vector512{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<double> X, Vector512<double> Y) YGroup2Unzip(this IWVectorTraits512 athis, Vector512<double> data0, Vector512<double> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector512s.YGroup2Unzip(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<sbyte> X, Vector512<sbyte> Y) YGroup2Unzip(this IWVectorTraits512 athis, Vector512<sbyte> data0, Vector512<sbyte> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector512s.YGroup2Unzip(Vector512{byte}, Vector512{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<byte> X, Vector512<byte> Y) YGroup2Unzip(this IWVectorTraits512 athis, Vector512<byte> data0, Vector512<byte> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector512s.YGroup2Unzip(Vector512{short}, Vector512{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<short> X, Vector512<short> Y) YGroup2Unzip(this IWVectorTraits512 athis, Vector512<short> data0, Vector512<short> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector512s.YGroup2Unzip(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ushort> X, Vector512<ushort> Y) YGroup2Unzip(this IWVectorTraits512 athis, Vector512<ushort> data0, Vector512<ushort> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector512s.YGroup2Unzip(Vector512{int}, Vector512{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<int> X, Vector512<int> Y) YGroup2Unzip(this IWVectorTraits512 athis, Vector512<int> data0, Vector512<int> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector512s.YGroup2Unzip(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<uint> X, Vector512<uint> Y) YGroup2Unzip(this IWVectorTraits512 athis, Vector512<uint> data0, Vector512<uint> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector512s.YGroup2Unzip(Vector512{long}, Vector512{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<long> X, Vector512<long> Y) YGroup2Unzip(this IWVectorTraits512 athis, Vector512<long> data0, Vector512<long> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector512s.YGroup2Unzip(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ulong> X, Vector512<ulong> Y) YGroup2Unzip(this IWVectorTraits512 athis, Vector512<ulong> data0, Vector512<ulong> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector512s.YGroup2Unzip(Vector512{ExInt128}, Vector512{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ExInt128> X, Vector512<ExInt128> Y) YGroup2Unzip(this IWVectorTraits512 athis, Vector512<ExInt128> data0, Vector512<ExInt128> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector512s.YGroup2Unzip(Vector512{ExUInt128}, Vector512{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ExUInt128> X, Vector512<ExUInt128> Y) YGroup2Unzip(this IWVectorTraits512 athis, Vector512<ExUInt128> data0, Vector512<ExUInt128> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="Vector512s.YGroup2Unzip(Vector512{Int128}, Vector512{Int128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<Int128> X, Vector512<Int128> Y) YGroup2Unzip(this IWVectorTraits512 athis, Vector512<Int128> data0, Vector512<Int128> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector512s.YGroup2Unzip(Vector512{UInt128}, Vector512{UInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<UInt128> X, Vector512<UInt128> Y) YGroup2Unzip(this IWVectorTraits512 athis, Vector512<UInt128> data0, Vector512<UInt128> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="Vector512s.YGroup2UnzipEven(Vector512{int}, Vector512{int})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static Vector512<T> YGroup2UnzipEven<T>(this IWVectorTraits512 athis, Vector512<T> data0, Vector512<T> data1) where T : struct {
            if (typeof(float) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2UnzipEven((Vector512<float>)(object)data0, (Vector512<float>)(object)data1);
            } else if (typeof(double) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2UnzipEven((Vector512<double>)(object)data0, (Vector512<double>)(object)data1);
            } else if (typeof(sbyte) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2UnzipEven((Vector512<sbyte>)(object)data0, (Vector512<sbyte>)(object)data1);
            } else if (typeof(byte) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2UnzipEven((Vector512<byte>)(object)data0, (Vector512<byte>)(object)data1);
            } else if (typeof(short) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2UnzipEven((Vector512<short>)(object)data0, (Vector512<short>)(object)data1);
            } else if (typeof(ushort) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2UnzipEven((Vector512<ushort>)(object)data0, (Vector512<ushort>)(object)data1);
            } else if (typeof(int) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2UnzipEven((Vector512<int>)(object)data0, (Vector512<int>)(object)data1);
            } else if (typeof(uint) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2UnzipEven((Vector512<uint>)(object)data0, (Vector512<uint>)(object)data1);
            } else if (typeof(long) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2UnzipEven((Vector512<long>)(object)data0, (Vector512<long>)(object)data1);
            } else if (typeof(ulong) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2UnzipEven((Vector512<ulong>)(object)data0, (Vector512<ulong>)(object)data1);
            } else if (typeof(ExInt128) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2UnzipEven((Vector512<ExInt128>)(object)data0, (Vector512<ExInt128>)(object)data1);
            } else if (typeof(ExUInt128) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2UnzipEven((Vector512<ExUInt128>)(object)data0, (Vector512<ExUInt128>)(object)data1);
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2UnzipEven((Vector512<Int128>)(object)data0, (Vector512<Int128>)(object)data1);
            } else if (typeof(UInt128) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2UnzipEven((Vector512<UInt128>)(object)data0, (Vector512<UInt128>)(object)data1);
#endif // BCL_TYPE_INT128
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="Vector512s.YGroup2UnzipEven(Vector512{ExInt128}, Vector512{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<Int128> YGroup2UnzipEven(this IWVectorTraits512 athis, Vector512<Int128> data0, Vector512<Int128> data1) {
            return athis.YGroup2UnzipEven(data0.ExAsExInt128(), data1.ExAsExInt128()).ExAsInt128();
        }

        /// <inheritdoc cref="Vector512s.YGroup2UnzipEven(Vector512{ExUInt128}, Vector512{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<UInt128> YGroup2UnzipEven(this IWVectorTraits512 athis, Vector512<UInt128> data0, Vector512<UInt128> data1) {
            return athis.YGroup2UnzipEven(data0.ExAsExUInt128(), data1.ExAsExUInt128()).ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="Vector512s.YGroup2UnzipOdd(Vector512{int}, Vector512{int})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static Vector512<T> YGroup2UnzipOdd<T>(this IWVectorTraits512 athis, Vector512<T> data0, Vector512<T> data1) where T : struct {
            if (typeof(float) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2UnzipOdd((Vector512<float>)(object)data0, (Vector512<float>)(object)data1);
            } else if (typeof(double) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2UnzipOdd((Vector512<double>)(object)data0, (Vector512<double>)(object)data1);
            } else if (typeof(sbyte) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2UnzipOdd((Vector512<sbyte>)(object)data0, (Vector512<sbyte>)(object)data1);
            } else if (typeof(byte) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2UnzipOdd((Vector512<byte>)(object)data0, (Vector512<byte>)(object)data1);
            } else if (typeof(short) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2UnzipOdd((Vector512<short>)(object)data0, (Vector512<short>)(object)data1);
            } else if (typeof(ushort) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2UnzipOdd((Vector512<ushort>)(object)data0, (Vector512<ushort>)(object)data1);
            } else if (typeof(int) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2UnzipOdd((Vector512<int>)(object)data0, (Vector512<int>)(object)data1);
            } else if (typeof(uint) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2UnzipOdd((Vector512<uint>)(object)data0, (Vector512<uint>)(object)data1);
            } else if (typeof(long) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2UnzipOdd((Vector512<long>)(object)data0, (Vector512<long>)(object)data1);
            } else if (typeof(ulong) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2UnzipOdd((Vector512<ulong>)(object)data0, (Vector512<ulong>)(object)data1);
            } else if (typeof(ExInt128) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2UnzipOdd((Vector512<ExInt128>)(object)data0, (Vector512<ExInt128>)(object)data1);
            } else if (typeof(ExUInt128) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2UnzipOdd((Vector512<ExUInt128>)(object)data0, (Vector512<ExUInt128>)(object)data1);
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2UnzipOdd((Vector512<Int128>)(object)data0, (Vector512<Int128>)(object)data1);
            } else if (typeof(UInt128) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2UnzipOdd((Vector512<UInt128>)(object)data0, (Vector512<UInt128>)(object)data1);
#endif // BCL_TYPE_INT128
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="Vector512s.YGroup2UnzipOdd(Vector512{ExInt128}, Vector512{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<Int128> YGroup2UnzipOdd(this IWVectorTraits512 athis, Vector512<Int128> data0, Vector512<Int128> data1) {
            return athis.YGroup2UnzipOdd(data0.ExAsExInt128(), data1.ExAsExInt128()).ExAsInt128();
        }

        /// <inheritdoc cref="Vector512s.YGroup2UnzipOdd(Vector512{ExUInt128}, Vector512{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<UInt128> YGroup2UnzipOdd(this IWVectorTraits512 athis, Vector512<UInt128> data0, Vector512<UInt128> data1) {
            return athis.YGroup2UnzipOdd(data0.ExAsExUInt128(), data1.ExAsExUInt128()).ExAsUInt128();
        }

#endif // BCL_TYPE_INT128


#if BCL_TYPE_INT128

        /// <inheritdoc cref="Vector512s.YGroup2Zip(Vector512{ExInt128}, Vector512{ExInt128}, out Vector512{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<Int128> YGroup2Zip(this IWVectorTraits512 athis, Vector512<Int128> x, Vector512<Int128> y, out Vector512<Int128> data1) {
            var d0 = athis.YGroup2Zip(x.ExAsExInt128(), y.ExAsExInt128(), out var d1);
            data1 = d1.ExAsInt128();
            return d0.ExAsInt128();
        }

        /// <inheritdoc cref="Vector512s.YGroup2Zip(Vector512{ExUInt128}, Vector512{ExUInt128}, out Vector512{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<UInt128> YGroup2Zip(this IWVectorTraits512 athis, Vector512<UInt128> x, Vector512<UInt128> y, out Vector512<UInt128> data1) {
            var d0 = athis.YGroup2Zip(x.ExAsExUInt128(), y.ExAsExUInt128(), out var d1);
            data1 = d1.ExAsUInt128();
            return d0.ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="Vector512s.YGroup2Zip{T}(Vector512{T}, Vector512{T})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static (Vector512<T> Data0, Vector512<T> Data1) YGroup2Zip<T>(this IWVectorTraits512 athis, Vector512<T> x, Vector512<T> y) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip((Vector512<float>)(object)x, (Vector512<float>)(object)y);
                return ((Vector512<T>)(object)data0, (Vector512<T>)(object)data1);
            } else if (typeof(double) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip((Vector512<double>)(object)x, (Vector512<double>)(object)y);
                return ((Vector512<T>)(object)data0, (Vector512<T>)(object)data1);
            } else if (typeof(sbyte) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip((Vector512<sbyte>)(object)x, (Vector512<sbyte>)(object)y);
                return ((Vector512<T>)(object)data0, (Vector512<T>)(object)data1);
            } else if (typeof(byte) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip((Vector512<byte>)(object)x, (Vector512<byte>)(object)y);
                return ((Vector512<T>)(object)data0, (Vector512<T>)(object)data1);
            } else if (typeof(short) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip((Vector512<short>)(object)x, (Vector512<short>)(object)y);
                return ((Vector512<T>)(object)data0, (Vector512<T>)(object)data1);
            } else if (typeof(ushort) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip((Vector512<ushort>)(object)x, (Vector512<ushort>)(object)y);
                return ((Vector512<T>)(object)data0, (Vector512<T>)(object)data1);
            } else if (typeof(int) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip((Vector512<int>)(object)x, (Vector512<int>)(object)y);
                return ((Vector512<T>)(object)data0, (Vector512<T>)(object)data1);
            } else if (typeof(uint) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip((Vector512<uint>)(object)x, (Vector512<uint>)(object)y);
                return ((Vector512<T>)(object)data0, (Vector512<T>)(object)data1);
            } else if (typeof(long) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip((Vector512<long>)(object)x, (Vector512<long>)(object)y);
                return ((Vector512<T>)(object)data0, (Vector512<T>)(object)data1);
            } else if (typeof(ulong) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip((Vector512<ulong>)(object)x, (Vector512<ulong>)(object)y);
                return ((Vector512<T>)(object)data0, (Vector512<T>)(object)data1);
            } else if (typeof(ExInt128) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip((Vector512<ExInt128>)(object)x, (Vector512<ExInt128>)(object)y);
                return ((Vector512<T>)(object)data0, (Vector512<T>)(object)data1);
            } else if (typeof(ExUInt128) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip((Vector512<ExUInt128>)(object)x, (Vector512<ExUInt128>)(object)y);
                return ((Vector512<T>)(object)data0, (Vector512<T>)(object)data1);
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip((Vector512<Int128>)(object)x, (Vector512<Int128>)(object)y);
                return ((Vector512<T>)(object)data0, (Vector512<T>)(object)data1);
            } else if (typeof(UInt128) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip((Vector512<UInt128>)(object)x, (Vector512<UInt128>)(object)y);
                return ((Vector512<T>)(object)data0, (Vector512<T>)(object)data1);
#endif // BCL_TYPE_INT128
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector512s.YGroup2Zip(Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<float> Data0, Vector512<float> Data1) YGroup2Zip(this IWVectorTraits512 athis, Vector512<float> x, Vector512<float> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vector512s.YGroup2Zip(Vector512{double}, Vector512{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<double> Data0, Vector512<double> Data1) YGroup2Zip(this IWVectorTraits512 athis, Vector512<double> x, Vector512<double> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vector512s.YGroup2Zip(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<sbyte> Data0, Vector512<sbyte> Data1) YGroup2Zip(this IWVectorTraits512 athis, Vector512<sbyte> x, Vector512<sbyte> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vector512s.YGroup2Zip(Vector512{byte}, Vector512{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<byte> Data0, Vector512<byte> Data1) YGroup2Zip(this IWVectorTraits512 athis, Vector512<byte> x, Vector512<byte> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vector512s.YGroup2Zip(Vector512{short}, Vector512{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<short> Data0, Vector512<short> Data1) YGroup2Zip(this IWVectorTraits512 athis, Vector512<short> x, Vector512<short> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vector512s.YGroup2Zip(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ushort> Data0, Vector512<ushort> Data1) YGroup2Zip(this IWVectorTraits512 athis, Vector512<ushort> x, Vector512<ushort> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vector512s.YGroup2Zip(Vector512{int}, Vector512{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<int> Data0, Vector512<int> Data1) YGroup2Zip(this IWVectorTraits512 athis, Vector512<int> x, Vector512<int> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vector512s.YGroup2Zip(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<uint> Data0, Vector512<uint> Data1) YGroup2Zip(this IWVectorTraits512 athis, Vector512<uint> x, Vector512<uint> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vector512s.YGroup2Zip(Vector512{long}, Vector512{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<long> Data0, Vector512<long> Data1) YGroup2Zip(this IWVectorTraits512 athis, Vector512<long> x, Vector512<long> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vector512s.YGroup2Zip(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ulong> Data0, Vector512<ulong> Data1) YGroup2Zip(this IWVectorTraits512 athis, Vector512<ulong> x, Vector512<ulong> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vector512s.YGroup2Zip(Vector512{ExInt128}, Vector512{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ExInt128> Data0, Vector512<ExInt128> Data1) YGroup2Zip(this IWVectorTraits512 athis, Vector512<ExInt128> x, Vector512<ExInt128> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vector512s.YGroup2Zip(Vector512{ExUInt128}, Vector512{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ExUInt128> Data0, Vector512<ExUInt128> Data1) YGroup2Zip(this IWVectorTraits512 athis, Vector512<ExUInt128> x, Vector512<ExUInt128> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="Vector512s.YGroup2Zip(Vector512{Int128}, Vector512{Int128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<Int128> Data0, Vector512<Int128> Data1) YGroup2Zip(this IWVectorTraits512 athis, Vector512<Int128> x, Vector512<Int128> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vector512s.YGroup2Zip(Vector512{UInt128}, Vector512{UInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<UInt128> Data0, Vector512<UInt128> Data1) YGroup2Zip(this IWVectorTraits512 athis, Vector512<UInt128> x, Vector512<UInt128> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="Vector512s.YGroup2ZipHigh(Vector512{int}, Vector512{int})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static Vector512<T> YGroup2ZipHigh<T>(this IWVectorTraits512 athis, Vector512<T> x, Vector512<T> y) where T : struct {
            if (typeof(float) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2ZipHigh((Vector512<float>)(object)x, (Vector512<float>)(object)y);
            } else if (typeof(double) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2ZipHigh((Vector512<double>)(object)x, (Vector512<double>)(object)y);
            } else if (typeof(sbyte) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2ZipHigh((Vector512<sbyte>)(object)x, (Vector512<sbyte>)(object)y);
            } else if (typeof(byte) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2ZipHigh((Vector512<byte>)(object)x, (Vector512<byte>)(object)y);
            } else if (typeof(short) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2ZipHigh((Vector512<short>)(object)x, (Vector512<short>)(object)y);
            } else if (typeof(ushort) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2ZipHigh((Vector512<ushort>)(object)x, (Vector512<ushort>)(object)y);
            } else if (typeof(int) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2ZipHigh((Vector512<int>)(object)x, (Vector512<int>)(object)y);
            } else if (typeof(uint) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2ZipHigh((Vector512<uint>)(object)x, (Vector512<uint>)(object)y);
            } else if (typeof(long) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2ZipHigh((Vector512<long>)(object)x, (Vector512<long>)(object)y);
            } else if (typeof(ulong) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2ZipHigh((Vector512<ulong>)(object)x, (Vector512<ulong>)(object)y);
            } else if (typeof(ExInt128) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2ZipHigh((Vector512<ExInt128>)(object)x, (Vector512<ExInt128>)(object)y);
            } else if (typeof(ExUInt128) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2ZipHigh((Vector512<ExUInt128>)(object)x, (Vector512<ExUInt128>)(object)y);
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2ZipHigh((Vector512<Int128>)(object)x, (Vector512<Int128>)(object)y);
            } else if (typeof(UInt128) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2ZipHigh((Vector512<UInt128>)(object)x, (Vector512<UInt128>)(object)y);
#endif // BCL_TYPE_INT128
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="Vector512s.YGroup2ZipHigh(Vector512{ExInt128}, Vector512{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<Int128> YGroup2ZipHigh(this IWVectorTraits512 athis, Vector512<Int128> x, Vector512<Int128> y) {
            return athis.YGroup2ZipHigh(x.ExAsExInt128(), y.ExAsExInt128()).ExAsInt128();
        }

        /// <inheritdoc cref="Vector512s.YGroup2ZipHigh(Vector512{ExUInt128}, Vector512{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<UInt128> YGroup2ZipHigh(this IWVectorTraits512 athis, Vector512<UInt128> x, Vector512<UInt128> y) {
            return athis.YGroup2ZipHigh(x.ExAsExUInt128(), y.ExAsExUInt128()).ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="Vector512s.YGroup2ZipLow(Vector512{int}, Vector512{int})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static Vector512<T> YGroup2ZipLow<T>(this IWVectorTraits512 athis, Vector512<T> x, Vector512<T> y) where T : struct {
            if (typeof(float) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2ZipLow((Vector512<float>)(object)x, (Vector512<float>)(object)y);
            } else if (typeof(double) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2ZipLow((Vector512<double>)(object)x, (Vector512<double>)(object)y);
            } else if (typeof(sbyte) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2ZipLow((Vector512<sbyte>)(object)x, (Vector512<sbyte>)(object)y);
            } else if (typeof(byte) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2ZipLow((Vector512<byte>)(object)x, (Vector512<byte>)(object)y);
            } else if (typeof(short) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2ZipLow((Vector512<short>)(object)x, (Vector512<short>)(object)y);
            } else if (typeof(ushort) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2ZipLow((Vector512<ushort>)(object)x, (Vector512<ushort>)(object)y);
            } else if (typeof(int) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2ZipLow((Vector512<int>)(object)x, (Vector512<int>)(object)y);
            } else if (typeof(uint) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2ZipLow((Vector512<uint>)(object)x, (Vector512<uint>)(object)y);
            } else if (typeof(long) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2ZipLow((Vector512<long>)(object)x, (Vector512<long>)(object)y);
            } else if (typeof(ulong) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2ZipLow((Vector512<ulong>)(object)x, (Vector512<ulong>)(object)y);
            } else if (typeof(ExInt128) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2ZipLow((Vector512<ExInt128>)(object)x, (Vector512<ExInt128>)(object)y);
            } else if (typeof(ExUInt128) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2ZipLow((Vector512<ExUInt128>)(object)x, (Vector512<ExUInt128>)(object)y);
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2ZipLow((Vector512<Int128>)(object)x, (Vector512<Int128>)(object)y);
            } else if (typeof(UInt128) == typeof(T)) {
                return (Vector512<T>)(object)athis.YGroup2ZipLow((Vector512<UInt128>)(object)x, (Vector512<UInt128>)(object)y);
#endif // BCL_TYPE_INT128
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="Vector512s.YGroup2ZipLow(Vector512{ExInt128}, Vector512{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<Int128> YGroup2ZipLow(this IWVectorTraits512 athis, Vector512<Int128> x, Vector512<Int128> y) {
            return athis.YGroup2ZipLow(x.ExAsExInt128(), y.ExAsExInt128()).ExAsInt128();
        }

        /// <inheritdoc cref="Vector512s.YGroup2ZipLow(Vector512{ExUInt128}, Vector512{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<UInt128> YGroup2ZipLow(this IWVectorTraits512 athis, Vector512<UInt128> x, Vector512<UInt128> y) {
            return athis.YGroup2ZipLow(x.ExAsExUInt128(), y.ExAsExUInt128()).ExAsUInt128();
        }

#endif // BCL_TYPE_INT128


#if BCL_TYPE_INT128

        /// <inheritdoc cref="Vector512s.YGroup4Unzip(Vector512{ExInt128}, Vector512{ExInt128}, Vector512{ExInt128}, Vector512{ExInt128}, out Vector512{ExInt128}, out Vector512{ExInt128}, out Vector512{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<Int128> YGroup4Unzip(this IWVectorTraits512 athis, Vector512<Int128> data0, Vector512<Int128> data1, Vector512<Int128> data2, Vector512<Int128> data3, out Vector512<Int128> y, out Vector512<Int128> z, out Vector512<Int128> w) {
            var d0 = athis.YGroup4Unzip(data0.ExAsExInt128(), data1.ExAsExInt128(), data2.ExAsExInt128(), data3.ExAsExInt128(), out var d1, out var d2, out var d3);
            y = d1.ExAsInt128();
            z = d2.ExAsInt128();
            w = d3.ExAsInt128();
            return d0.ExAsInt128();
        }

        /// <inheritdoc cref="Vector512s.YGroup4Unzip(Vector512{ExUInt128}, Vector512{ExUInt128}, Vector512{ExUInt128}, Vector512{ExUInt128}, out Vector512{ExUInt128}, out Vector512{ExUInt128}, out Vector512{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<UInt128> YGroup4Unzip(this IWVectorTraits512 athis, Vector512<UInt128> data0, Vector512<UInt128> data1, Vector512<UInt128> data2, Vector512<UInt128> data3, out Vector512<UInt128> y, out Vector512<UInt128> z, out Vector512<UInt128> w) {
            var d0 = athis.YGroup4Unzip(data0.ExAsExUInt128(), data1.ExAsExUInt128(), data2.ExAsExUInt128(), data3.ExAsExUInt128(), out var d1, out var d2, out var d3);
            y = d1.ExAsUInt128();
            z = d2.ExAsUInt128();
            w = d3.ExAsUInt128();
            return d0.ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="Vector512s.YGroup4Unzip{T}(Vector512{T}, Vector512{T}, Vector512{T}, Vector512{T})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<T> X, Vector512<T> Y, Vector512<T> Z, Vector512<T> W) YGroup4Unzip<T>(this IWVectorTraits512 athis, Vector512<T> data0, Vector512<T> data1, Vector512<T> data2, Vector512<T> data3) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip((Vector512<float>)(object)data0, (Vector512<float>)(object)data1, (Vector512<float>)(object)data2, (Vector512<float>)(object)data3);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip((Vector512<double>)(object)data0, (Vector512<double>)(object)data1, (Vector512<double>)(object)data2, (Vector512<double>)(object)data3);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip((Vector512<sbyte>)(object)data0, (Vector512<sbyte>)(object)data1, (Vector512<sbyte>)(object)data2, (Vector512<sbyte>)(object)data3);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip((Vector512<byte>)(object)data0, (Vector512<byte>)(object)data1, (Vector512<byte>)(object)data2, (Vector512<byte>)(object)data3);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip((Vector512<short>)(object)data0, (Vector512<short>)(object)data1, (Vector512<short>)(object)data2, (Vector512<short>)(object)data3);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip((Vector512<ushort>)(object)data0, (Vector512<ushort>)(object)data1, (Vector512<ushort>)(object)data2, (Vector512<ushort>)(object)data3);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip((Vector512<int>)(object)data0, (Vector512<int>)(object)data1, (Vector512<int>)(object)data2, (Vector512<int>)(object)data3);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip((Vector512<uint>)(object)data0, (Vector512<uint>)(object)data1, (Vector512<uint>)(object)data2, (Vector512<uint>)(object)data3);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip((Vector512<long>)(object)data0, (Vector512<long>)(object)data1, (Vector512<long>)(object)data2, (Vector512<long>)(object)data3);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip((Vector512<ulong>)(object)data0, (Vector512<ulong>)(object)data1, (Vector512<ulong>)(object)data2, (Vector512<ulong>)(object)data3);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(ExInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip((Vector512<ExInt128>)(object)data0, (Vector512<ExInt128>)(object)data1, (Vector512<ExInt128>)(object)data2, (Vector512<ExInt128>)(object)data3);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(ExUInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip((Vector512<ExUInt128>)(object)data0, (Vector512<ExUInt128>)(object)data1, (Vector512<ExUInt128>)(object)data2, (Vector512<ExUInt128>)(object)data3);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip((Vector512<Int128>)(object)data0, (Vector512<Int128>)(object)data1, (Vector512<Int128>)(object)data2, (Vector512<Int128>)(object)data3);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(UInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip((Vector512<UInt128>)(object)data0, (Vector512<UInt128>)(object)data1, (Vector512<UInt128>)(object)data2, (Vector512<UInt128>)(object)data3);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
#endif // BCL_TYPE_INT128
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector512s.YGroup4Unzip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<float> X, Vector512<float> Y, Vector512<float> Z, Vector512<float> W) YGroup4Unzip(this IWVectorTraits512 athis, Vector512<float> data0, Vector512<float> data1, Vector512<float> data2, Vector512<float> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }


        /// <inheritdoc cref="Vector512s.YGroup4Unzip(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<double> X, Vector512<double> Y, Vector512<double> Z, Vector512<double> W) YGroup4Unzip(this IWVectorTraits512 athis, Vector512<double> data0, Vector512<double> data1, Vector512<double> data2, Vector512<double> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector512s.YGroup4Unzip(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<sbyte> X, Vector512<sbyte> Y, Vector512<sbyte> Z, Vector512<sbyte> W) YGroup4Unzip(this IWVectorTraits512 athis, Vector512<sbyte> data0, Vector512<sbyte> data1, Vector512<sbyte> data2, Vector512<sbyte> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector512s.YGroup4Unzip(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<byte> X, Vector512<byte> Y, Vector512<byte> Z, Vector512<byte> W) YGroup4Unzip(this IWVectorTraits512 athis, Vector512<byte> data0, Vector512<byte> data1, Vector512<byte> data2, Vector512<byte> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector512s.YGroup4Unzip(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<short> X, Vector512<short> Y, Vector512<short> Z, Vector512<short> W) YGroup4Unzip(this IWVectorTraits512 athis, Vector512<short> data0, Vector512<short> data1, Vector512<short> data2, Vector512<short> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector512s.YGroup4Unzip(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ushort> X, Vector512<ushort> Y, Vector512<ushort> Z, Vector512<ushort> W) YGroup4Unzip(this IWVectorTraits512 athis, Vector512<ushort> data0, Vector512<ushort> data1, Vector512<ushort> data2, Vector512<ushort> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector512s.YGroup4Unzip(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<int> X, Vector512<int> Y, Vector512<int> Z, Vector512<int> W) YGroup4Unzip(this IWVectorTraits512 athis, Vector512<int> data0, Vector512<int> data1, Vector512<int> data2, Vector512<int> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector512s.YGroup4Unzip(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<uint> X, Vector512<uint> Y, Vector512<uint> Z, Vector512<uint> W) YGroup4Unzip(this IWVectorTraits512 athis, Vector512<uint> data0, Vector512<uint> data1, Vector512<uint> data2, Vector512<uint> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector512s.YGroup4Unzip(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<long> X, Vector512<long> Y, Vector512<long> Z, Vector512<long> W) YGroup4Unzip(this IWVectorTraits512 athis, Vector512<long> data0, Vector512<long> data1, Vector512<long> data2, Vector512<long> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector512s.YGroup4Unzip(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ulong> X, Vector512<ulong> Y, Vector512<ulong> Z, Vector512<ulong> W) YGroup4Unzip(this IWVectorTraits512 athis, Vector512<ulong> data0, Vector512<ulong> data1, Vector512<ulong> data2, Vector512<ulong> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector512s.YGroup4Unzip(Vector512{ExInt128}, Vector512{ExInt128}, Vector512{ExInt128}, Vector512{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ExInt128> X, Vector512<ExInt128> Y, Vector512<ExInt128> Z, Vector512<ExInt128> W) YGroup4Unzip(this IWVectorTraits512 athis, Vector512<ExInt128> data0, Vector512<ExInt128> data1, Vector512<ExInt128> data2, Vector512<ExInt128> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector512s.YGroup4Unzip(Vector512{ExUInt128}, Vector512{ExUInt128}, Vector512{ExUInt128}, Vector512{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ExUInt128> X, Vector512<ExUInt128> Y, Vector512<ExUInt128> Z, Vector512<ExUInt128> W) YGroup4Unzip(this IWVectorTraits512 athis, Vector512<ExUInt128> data0, Vector512<ExUInt128> data1, Vector512<ExUInt128> data2, Vector512<ExUInt128> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }


        /// <inheritdoc cref="Vector512s.YGroup3Unzip{T}(Vector512{T}, Vector512{T}, Vector512{T})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<T> X, Vector512<T> Y, Vector512<T> Z) YGroup3Unzip<T>(this IWVectorTraits512 athis, Vector512<T> data0, Vector512<T> data1, Vector512<T> data2) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Unzip((Vector512<float>)(object)data0, (Vector512<float>)(object)data1, (Vector512<float>)(object)data2);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Unzip((Vector512<double>)(object)data0, (Vector512<double>)(object)data1, (Vector512<double>)(object)data2);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Unzip((Vector512<sbyte>)(object)data0, (Vector512<sbyte>)(object)data1, (Vector512<sbyte>)(object)data2);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Unzip((Vector512<byte>)(object)data0, (Vector512<byte>)(object)data1, (Vector512<byte>)(object)data2);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Unzip((Vector512<short>)(object)data0, (Vector512<short>)(object)data1, (Vector512<short>)(object)data2);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Unzip((Vector512<ushort>)(object)data0, (Vector512<ushort>)(object)data1, (Vector512<ushort>)(object)data2);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Unzip((Vector512<int>)(object)data0, (Vector512<int>)(object)data1, (Vector512<int>)(object)data2);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Unzip((Vector512<uint>)(object)data0, (Vector512<uint>)(object)data1, (Vector512<uint>)(object)data2);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Unzip((Vector512<long>)(object)data0, (Vector512<long>)(object)data1, (Vector512<long>)(object)data2);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Unzip((Vector512<ulong>)(object)data0, (Vector512<ulong>)(object)data1, (Vector512<ulong>)(object)data2);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector512s.YGroup3Unzip(Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<float> X, Vector512<float> Y, Vector512<float> Z) YGroup3Unzip(this IWVectorTraits512 athis, Vector512<float> data0, Vector512<float> data1, Vector512<float> data2) {
            var rt0 = athis.YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector512s.YGroup3Unzip(Vector512{double}, Vector512{double}, Vector512{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<double> X, Vector512<double> Y, Vector512<double> Z) YGroup3Unzip(this IWVectorTraits512 athis, Vector512<double> data0, Vector512<double> data1, Vector512<double> data2) {
            var rt0 = athis.YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector512s.YGroup3Unzip(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<sbyte> X, Vector512<sbyte> Y, Vector512<sbyte> Z) YGroup3Unzip(this IWVectorTraits512 athis, Vector512<sbyte> data0, Vector512<sbyte> data1, Vector512<sbyte> data2) {
            var rt0 = athis.YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector512s.YGroup3Unzip(Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<byte> X, Vector512<byte> Y, Vector512<byte> Z) YGroup3Unzip(this IWVectorTraits512 athis, Vector512<byte> data0, Vector512<byte> data1, Vector512<byte> data2) {
            var rt0 = athis.YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector512s.YGroup3Unzip(Vector512{short}, Vector512{short}, Vector512{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<short> X, Vector512<short> Y, Vector512<short> Z) YGroup3Unzip(this IWVectorTraits512 athis, Vector512<short> data0, Vector512<short> data1, Vector512<short> data2) {
            var rt0 = athis.YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector512s.YGroup3Unzip(Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ushort> X, Vector512<ushort> Y, Vector512<ushort> Z) YGroup3Unzip(this IWVectorTraits512 athis, Vector512<ushort> data0, Vector512<ushort> data1, Vector512<ushort> data2) {
            var rt0 = athis.YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector512s.YGroup3Unzip(Vector512{int}, Vector512{int}, Vector512{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<int> X, Vector512<int> Y, Vector512<int> Z) YGroup3Unzip(this IWVectorTraits512 athis, Vector512<int> data0, Vector512<int> data1, Vector512<int> data2) {
            var rt0 = athis.YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector512s.YGroup3Unzip(Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<uint> X, Vector512<uint> Y, Vector512<uint> Z) YGroup3Unzip(this IWVectorTraits512 athis, Vector512<uint> data0, Vector512<uint> data1, Vector512<uint> data2) {
            var rt0 = athis.YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector512s.YGroup3Unzip(Vector512{long}, Vector512{long}, Vector512{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<long> X, Vector512<long> Y, Vector512<long> Z) YGroup3Unzip(this IWVectorTraits512 athis, Vector512<long> data0, Vector512<long> data1, Vector512<long> data2) {
            var rt0 = athis.YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector512s.YGroup3Unzip(Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ulong> X, Vector512<ulong> Y, Vector512<ulong> Z) YGroup3Unzip(this IWVectorTraits512 athis, Vector512<ulong> data0, Vector512<ulong> data1, Vector512<ulong> data2) {
            var rt0 = athis.YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }


        /// <inheritdoc cref="Vector512s.YGroup3UnzipX2{T}(Vector512{T}, Vector512{T}, Vector512{T}, Vector512{T}, Vector512{T}, Vector512{T})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<T> X, Vector512<T> XB, Vector512<T> Y, Vector512<T> YB, Vector512<T> Z, Vector512<T> ZB) YGroup3UnzipX2<T>(this IWVectorTraits512 athis, Vector512<T> data0, Vector512<T> data1, Vector512<T> data2, Vector512<T> data3, Vector512<T> data4, Vector512<T> data5) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3UnzipX2((Vector512<float>)(object)data0, (Vector512<float>)(object)data1, (Vector512<float>)(object)data2, (Vector512<float>)(object)data3, (Vector512<float>)(object)data4, (Vector512<float>)(object)data5);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3, (Vector512<T>)(object)rt4, (Vector512<T>)(object)rt5);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3UnzipX2((Vector512<double>)(object)data0, (Vector512<double>)(object)data1, (Vector512<double>)(object)data2, (Vector512<double>)(object)data3, (Vector512<double>)(object)data4, (Vector512<double>)(object)data5);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3, (Vector512<T>)(object)rt4, (Vector512<T>)(object)rt5);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3UnzipX2((Vector512<sbyte>)(object)data0, (Vector512<sbyte>)(object)data1, (Vector512<sbyte>)(object)data2, (Vector512<sbyte>)(object)data3, (Vector512<sbyte>)(object)data4, (Vector512<sbyte>)(object)data5);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3, (Vector512<T>)(object)rt4, (Vector512<T>)(object)rt5);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3UnzipX2((Vector512<byte>)(object)data0, (Vector512<byte>)(object)data1, (Vector512<byte>)(object)data2, (Vector512<byte>)(object)data3, (Vector512<byte>)(object)data4, (Vector512<byte>)(object)data5);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3, (Vector512<T>)(object)rt4, (Vector512<T>)(object)rt5);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3UnzipX2((Vector512<short>)(object)data0, (Vector512<short>)(object)data1, (Vector512<short>)(object)data2, (Vector512<short>)(object)data3, (Vector512<short>)(object)data4, (Vector512<short>)(object)data5);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3, (Vector512<T>)(object)rt4, (Vector512<T>)(object)rt5);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3UnzipX2((Vector512<ushort>)(object)data0, (Vector512<ushort>)(object)data1, (Vector512<ushort>)(object)data2, (Vector512<ushort>)(object)data3, (Vector512<ushort>)(object)data4, (Vector512<ushort>)(object)data5);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3, (Vector512<T>)(object)rt4, (Vector512<T>)(object)rt5);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3UnzipX2((Vector512<int>)(object)data0, (Vector512<int>)(object)data1, (Vector512<int>)(object)data2, (Vector512<int>)(object)data3, (Vector512<int>)(object)data4, (Vector512<int>)(object)data5);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3, (Vector512<T>)(object)rt4, (Vector512<T>)(object)rt5);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3UnzipX2((Vector512<uint>)(object)data0, (Vector512<uint>)(object)data1, (Vector512<uint>)(object)data2, (Vector512<uint>)(object)data3, (Vector512<uint>)(object)data4, (Vector512<uint>)(object)data5);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3, (Vector512<T>)(object)rt4, (Vector512<T>)(object)rt5);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3UnzipX2((Vector512<long>)(object)data0, (Vector512<long>)(object)data1, (Vector512<long>)(object)data2, (Vector512<long>)(object)data3, (Vector512<long>)(object)data4, (Vector512<long>)(object)data5);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3, (Vector512<T>)(object)rt4, (Vector512<T>)(object)rt5);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3UnzipX2((Vector512<ulong>)(object)data0, (Vector512<ulong>)(object)data1, (Vector512<ulong>)(object)data2, (Vector512<ulong>)(object)data3, (Vector512<ulong>)(object)data4, (Vector512<ulong>)(object)data5);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3, (Vector512<T>)(object)rt4, (Vector512<T>)(object)rt5);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector512s.YGroup3UnzipX2(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<float> X, Vector512<float> XB, Vector512<float> Y, Vector512<float> YB, Vector512<float> Z, Vector512<float> ZB) YGroup3UnzipX2(this IWVectorTraits512 athis, Vector512<float> data0, Vector512<float> data1, Vector512<float> data2, Vector512<float> data3, Vector512<float> data4, Vector512<float> data5) {
            var rt0 = athis.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="Vector512s.YGroup3UnzipX2(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<double> X, Vector512<double> XB, Vector512<double> Y, Vector512<double> YB, Vector512<double> Z, Vector512<double> ZB) YGroup3UnzipX2(this IWVectorTraits512 athis, Vector512<double> data0, Vector512<double> data1, Vector512<double> data2, Vector512<double> data3, Vector512<double> data4, Vector512<double> data5) {
            var rt0 = athis.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="Vector512s.YGroup3UnzipX2(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<sbyte> X, Vector512<sbyte> XB, Vector512<sbyte> Y, Vector512<sbyte> YB, Vector512<sbyte> Z, Vector512<sbyte> ZB) YGroup3UnzipX2(this IWVectorTraits512 athis, Vector512<sbyte> data0, Vector512<sbyte> data1, Vector512<sbyte> data2, Vector512<sbyte> data3, Vector512<sbyte> data4, Vector512<sbyte> data5) {
            var rt0 = athis.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="Vector512s.YGroup3UnzipX2(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<byte> X, Vector512<byte> XB, Vector512<byte> Y, Vector512<byte> YB, Vector512<byte> Z, Vector512<byte> ZB) YGroup3UnzipX2(this IWVectorTraits512 athis, Vector512<byte> data0, Vector512<byte> data1, Vector512<byte> data2, Vector512<byte> data3, Vector512<byte> data4, Vector512<byte> data5) {
            var rt0 = athis.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="Vector512s.YGroup3UnzipX2(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<short> X, Vector512<short> XB, Vector512<short> Y, Vector512<short> YB, Vector512<short> Z, Vector512<short> ZB) YGroup3UnzipX2(this IWVectorTraits512 athis, Vector512<short> data0, Vector512<short> data1, Vector512<short> data2, Vector512<short> data3, Vector512<short> data4, Vector512<short> data5) {
            var rt0 = athis.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="Vector512s.YGroup3UnzipX2(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ushort> X, Vector512<ushort> XB, Vector512<ushort> Y, Vector512<ushort> YB, Vector512<ushort> Z, Vector512<ushort> ZB) YGroup3UnzipX2(this IWVectorTraits512 athis, Vector512<ushort> data0, Vector512<ushort> data1, Vector512<ushort> data2, Vector512<ushort> data3, Vector512<ushort> data4, Vector512<ushort> data5) {
            var rt0 = athis.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="Vector512s.YGroup3UnzipX2(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<int> X, Vector512<int> XB, Vector512<int> Y, Vector512<int> YB, Vector512<int> Z, Vector512<int> ZB) YGroup3UnzipX2(this IWVectorTraits512 athis, Vector512<int> data0, Vector512<int> data1, Vector512<int> data2, Vector512<int> data3, Vector512<int> data4, Vector512<int> data5) {
            var rt0 = athis.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="Vector512s.YGroup3UnzipX2(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<uint> X, Vector512<uint> XB, Vector512<uint> Y, Vector512<uint> YB, Vector512<uint> Z, Vector512<uint> ZB) YGroup3UnzipX2(this IWVectorTraits512 athis, Vector512<uint> data0, Vector512<uint> data1, Vector512<uint> data2, Vector512<uint> data3, Vector512<uint> data4, Vector512<uint> data5) {
            var rt0 = athis.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="Vector512s.YGroup3UnzipX2(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<long> X, Vector512<long> XB, Vector512<long> Y, Vector512<long> YB, Vector512<long> Z, Vector512<long> ZB) YGroup3UnzipX2(this IWVectorTraits512 athis, Vector512<long> data0, Vector512<long> data1, Vector512<long> data2, Vector512<long> data3, Vector512<long> data4, Vector512<long> data5) {
            var rt0 = athis.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="Vector512s.YGroup3UnzipX2(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ulong> X, Vector512<ulong> XB, Vector512<ulong> Y, Vector512<ulong> YB, Vector512<ulong> Z, Vector512<ulong> ZB) YGroup3UnzipX2(this IWVectorTraits512 athis, Vector512<ulong> data0, Vector512<ulong> data1, Vector512<ulong> data2, Vector512<ulong> data3, Vector512<ulong> data4, Vector512<ulong> data5) {
            var rt0 = athis.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }


        /// <inheritdoc cref="Vector512s.YGroup3Zip{T}(Vector512{T}, Vector512{T}, Vector512{T})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<T> Data0, Vector512<T> Data1, Vector512<T> Data2) YGroup3Zip<T>(this IWVectorTraits512 athis, Vector512<T> x, Vector512<T> y, Vector512<T> z) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Zip((Vector512<float>)(object)x, (Vector512<float>)(object)y, (Vector512<float>)(object)z);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Zip((Vector512<double>)(object)x, (Vector512<double>)(object)y, (Vector512<double>)(object)z);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Zip((Vector512<sbyte>)(object)x, (Vector512<sbyte>)(object)y, (Vector512<sbyte>)(object)z);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Zip((Vector512<byte>)(object)x, (Vector512<byte>)(object)y, (Vector512<byte>)(object)z);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Zip((Vector512<short>)(object)x, (Vector512<short>)(object)y, (Vector512<short>)(object)z);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Zip((Vector512<ushort>)(object)x, (Vector512<ushort>)(object)y, (Vector512<ushort>)(object)z);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Zip((Vector512<int>)(object)x, (Vector512<int>)(object)y, (Vector512<int>)(object)z);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Zip((Vector512<uint>)(object)x, (Vector512<uint>)(object)y, (Vector512<uint>)(object)z);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Zip((Vector512<long>)(object)x, (Vector512<long>)(object)y, (Vector512<long>)(object)z);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Zip((Vector512<ulong>)(object)x, (Vector512<ulong>)(object)y, (Vector512<ulong>)(object)z);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector512s.YGroup3Zip(Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<float> Data0, Vector512<float> Data1, Vector512<float> Data2) YGroup3Zip(this IWVectorTraits512 athis, Vector512<float> x, Vector512<float> y, Vector512<float> z) {
            var data0 = athis.YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="Vector512s.YGroup3Zip(Vector512{double}, Vector512{double}, Vector512{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<double> Data0, Vector512<double> Data1, Vector512<double> Data2) YGroup3Zip(this IWVectorTraits512 athis, Vector512<double> x, Vector512<double> y, Vector512<double> z) {
            var data0 = athis.YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="Vector512s.YGroup3Zip(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<sbyte> Data0, Vector512<sbyte> Data1, Vector512<sbyte> Data2) YGroup3Zip(this IWVectorTraits512 athis, Vector512<sbyte> x, Vector512<sbyte> y, Vector512<sbyte> z) {
            var data0 = athis.YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="Vector512s.YGroup3Zip(Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<byte> Data0, Vector512<byte> Data1, Vector512<byte> Data2) YGroup3Zip(this IWVectorTraits512 athis, Vector512<byte> x, Vector512<byte> y, Vector512<byte> z) {
            var data0 = athis.YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="Vector512s.YGroup3Zip(Vector512{short}, Vector512{short}, Vector512{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<short> Data0, Vector512<short> Data1, Vector512<short> Data2) YGroup3Zip(this IWVectorTraits512 athis, Vector512<short> x, Vector512<short> y, Vector512<short> z) {
            var data0 = athis.YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="Vector512s.YGroup3Zip(Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ushort> Data0, Vector512<ushort> Data1, Vector512<ushort> Data2) YGroup3Zip(this IWVectorTraits512 athis, Vector512<ushort> x, Vector512<ushort> y, Vector512<ushort> z) {
            var data0 = athis.YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="Vector512s.YGroup3Zip(Vector512{int}, Vector512{int}, Vector512{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<int> Data0, Vector512<int> Data1, Vector512<int> Data2) YGroup3Zip(this IWVectorTraits512 athis, Vector512<int> x, Vector512<int> y, Vector512<int> z) {
            var data0 = athis.YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="Vector512s.YGroup3Zip(Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<uint> Data0, Vector512<uint> Data1, Vector512<uint> Data2) YGroup3Zip(this IWVectorTraits512 athis, Vector512<uint> x, Vector512<uint> y, Vector512<uint> z) {
            var data0 = athis.YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="Vector512s.YGroup3Zip(Vector512{long}, Vector512{long}, Vector512{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<long> Data0, Vector512<long> Data1, Vector512<long> Data2) YGroup3Zip(this IWVectorTraits512 athis, Vector512<long> x, Vector512<long> y, Vector512<long> z) {
            var data0 = athis.YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="Vector512s.YGroup3Zip(Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ulong> Data0, Vector512<ulong> Data1, Vector512<ulong> Data2) YGroup3Zip(this IWVectorTraits512 athis, Vector512<ulong> x, Vector512<ulong> y, Vector512<ulong> z) {
            var data0 = athis.YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }


        /// <inheritdoc cref="Vector512s.YGroup3ZipX2{T}(Vector512{T}, Vector512{T}, Vector512{T}, Vector512{T}, Vector512{T}, Vector512{T})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<T> Data0, Vector512<T> Data1, Vector512<T> Data2, Vector512<T> Data3, Vector512<T> Data4, Vector512<T> Data5) YGroup3ZipX2<T>(this IWVectorTraits512 athis, Vector512<T> x, Vector512<T> xB, Vector512<T> y, Vector512<T> yB, Vector512<T> z, Vector512<T> zB) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3ZipX2((Vector512<float>)(object)x, (Vector512<float>)(object)xB, (Vector512<float>)(object)y, (Vector512<float>)(object)yB, (Vector512<float>)(object)z, (Vector512<float>)(object)zB);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3, (Vector512<T>)(object)rt4, (Vector512<T>)(object)rt5);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3ZipX2((Vector512<double>)(object)x, (Vector512<double>)(object)xB, (Vector512<double>)(object)y, (Vector512<double>)(object)yB, (Vector512<double>)(object)z, (Vector512<double>)(object)zB);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3, (Vector512<T>)(object)rt4, (Vector512<T>)(object)rt5);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3ZipX2((Vector512<sbyte>)(object)x, (Vector512<sbyte>)(object)xB, (Vector512<sbyte>)(object)y, (Vector512<sbyte>)(object)yB, (Vector512<sbyte>)(object)z, (Vector512<sbyte>)(object)zB);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3, (Vector512<T>)(object)rt4, (Vector512<T>)(object)rt5);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3ZipX2((Vector512<byte>)(object)x, (Vector512<byte>)(object)xB, (Vector512<byte>)(object)y, (Vector512<byte>)(object)yB, (Vector512<byte>)(object)z, (Vector512<byte>)(object)zB);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3, (Vector512<T>)(object)rt4, (Vector512<T>)(object)rt5);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3ZipX2((Vector512<short>)(object)x, (Vector512<short>)(object)xB, (Vector512<short>)(object)y, (Vector512<short>)(object)yB, (Vector512<short>)(object)z, (Vector512<short>)(object)zB);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3, (Vector512<T>)(object)rt4, (Vector512<T>)(object)rt5);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3ZipX2((Vector512<ushort>)(object)x, (Vector512<ushort>)(object)xB, (Vector512<ushort>)(object)y, (Vector512<ushort>)(object)yB, (Vector512<ushort>)(object)z, (Vector512<ushort>)(object)zB);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3, (Vector512<T>)(object)rt4, (Vector512<T>)(object)rt5);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3ZipX2((Vector512<int>)(object)x, (Vector512<int>)(object)xB, (Vector512<int>)(object)y, (Vector512<int>)(object)yB, (Vector512<int>)(object)z, (Vector512<int>)(object)zB);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3, (Vector512<T>)(object)rt4, (Vector512<T>)(object)rt5);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3ZipX2((Vector512<uint>)(object)x, (Vector512<uint>)(object)xB, (Vector512<uint>)(object)y, (Vector512<uint>)(object)yB, (Vector512<uint>)(object)z, (Vector512<uint>)(object)zB);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3, (Vector512<T>)(object)rt4, (Vector512<T>)(object)rt5);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3ZipX2((Vector512<long>)(object)x, (Vector512<long>)(object)xB, (Vector512<long>)(object)y, (Vector512<long>)(object)yB, (Vector512<long>)(object)z, (Vector512<long>)(object)zB);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3, (Vector512<T>)(object)rt4, (Vector512<T>)(object)rt5);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3ZipX2((Vector512<ulong>)(object)x, (Vector512<ulong>)(object)xB, (Vector512<ulong>)(object)y, (Vector512<ulong>)(object)yB, (Vector512<ulong>)(object)z, (Vector512<ulong>)(object)zB);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3, (Vector512<T>)(object)rt4, (Vector512<T>)(object)rt5);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector512s.YGroup3ZipX2(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<float> Data0, Vector512<float> Data1, Vector512<float> Data2, Vector512<float> Data3, Vector512<float> Data4, Vector512<float> Data5) YGroup3ZipX2(this IWVectorTraits512 athis, Vector512<float> x, Vector512<float> xB, Vector512<float> y, Vector512<float> yB, Vector512<float> z, Vector512<float> zB) {
            var data0 = athis.YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="Vector512s.YGroup3ZipX2(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<double> Data0, Vector512<double> Data1, Vector512<double> Data2, Vector512<double> Data3, Vector512<double> Data4, Vector512<double> Data5) YGroup3ZipX2(this IWVectorTraits512 athis, Vector512<double> x, Vector512<double> xB, Vector512<double> y, Vector512<double> yB, Vector512<double> z, Vector512<double> zB) {
            var data0 = athis.YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="Vector512s.YGroup3ZipX2(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<sbyte> Data0, Vector512<sbyte> Data1, Vector512<sbyte> Data2, Vector512<sbyte> Data3, Vector512<sbyte> Data4, Vector512<sbyte> Data5) YGroup3ZipX2(this IWVectorTraits512 athis, Vector512<sbyte> x, Vector512<sbyte> xB, Vector512<sbyte> y, Vector512<sbyte> yB, Vector512<sbyte> z, Vector512<sbyte> zB) {
            var data0 = athis.YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="Vector512s.YGroup3ZipX2(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<byte> Data0, Vector512<byte> Data1, Vector512<byte> Data2, Vector512<byte> Data3, Vector512<byte> Data4, Vector512<byte> Data5) YGroup3ZipX2(this IWVectorTraits512 athis, Vector512<byte> x, Vector512<byte> xB, Vector512<byte> y, Vector512<byte> yB, Vector512<byte> z, Vector512<byte> zB) {
            var data0 = athis.YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="Vector512s.YGroup3ZipX2(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<short> Data0, Vector512<short> Data1, Vector512<short> Data2, Vector512<short> Data3, Vector512<short> Data4, Vector512<short> Data5) YGroup3ZipX2(this IWVectorTraits512 athis, Vector512<short> x, Vector512<short> xB, Vector512<short> y, Vector512<short> yB, Vector512<short> z, Vector512<short> zB) {
            var data0 = athis.YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="Vector512s.YGroup3ZipX2(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ushort> Data0, Vector512<ushort> Data1, Vector512<ushort> Data2, Vector512<ushort> Data3, Vector512<ushort> Data4, Vector512<ushort> Data5) YGroup3ZipX2(this IWVectorTraits512 athis, Vector512<ushort> x, Vector512<ushort> xB, Vector512<ushort> y, Vector512<ushort> yB, Vector512<ushort> z, Vector512<ushort> zB) {
            var data0 = athis.YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="Vector512s.YGroup3ZipX2(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<int> Data0, Vector512<int> Data1, Vector512<int> Data2, Vector512<int> Data3, Vector512<int> Data4, Vector512<int> Data5) YGroup3ZipX2(this IWVectorTraits512 athis, Vector512<int> x, Vector512<int> xB, Vector512<int> y, Vector512<int> yB, Vector512<int> z, Vector512<int> zB) {
            var data0 = athis.YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="Vector512s.YGroup3ZipX2(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<uint> Data0, Vector512<uint> Data1, Vector512<uint> Data2, Vector512<uint> Data3, Vector512<uint> Data4, Vector512<uint> Data5) YGroup3ZipX2(this IWVectorTraits512 athis, Vector512<uint> x, Vector512<uint> xB, Vector512<uint> y, Vector512<uint> yB, Vector512<uint> z, Vector512<uint> zB) {
            var data0 = athis.YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="Vector512s.YGroup3ZipX2(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<long> Data0, Vector512<long> Data1, Vector512<long> Data2, Vector512<long> Data3, Vector512<long> Data4, Vector512<long> Data5) YGroup3ZipX2(this IWVectorTraits512 athis, Vector512<long> x, Vector512<long> xB, Vector512<long> y, Vector512<long> yB, Vector512<long> z, Vector512<long> zB) {
            var data0 = athis.YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="Vector512s.YGroup3ZipX2(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ulong> Data0, Vector512<ulong> Data1, Vector512<ulong> Data2, Vector512<ulong> Data3, Vector512<ulong> Data4, Vector512<ulong> Data5) YGroup3ZipX2(this IWVectorTraits512 athis, Vector512<ulong> x, Vector512<ulong> xB, Vector512<ulong> y, Vector512<ulong> yB, Vector512<ulong> z, Vector512<ulong> zB) {
            var data0 = athis.YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }


#if BCL_TYPE_INT128

        /// <inheritdoc cref="Vector512s.YGroup4Unzip(Vector512{Int128}, Vector512{Int128}, Vector512{Int128}, Vector512{Int128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<Int128> X, Vector512<Int128> Y, Vector512<Int128> Z, Vector512<Int128> W) YGroup4Unzip(this IWVectorTraits512 athis, Vector512<Int128> data0, Vector512<Int128> data1, Vector512<Int128> data2, Vector512<Int128> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector512s.YGroup4Unzip(Vector512{UInt128}, Vector512{UInt128}, Vector512{UInt128}, Vector512{UInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<UInt128> X, Vector512<UInt128> Y, Vector512<UInt128> Z, Vector512<UInt128> W) YGroup4Unzip(this IWVectorTraits512 athis, Vector512<UInt128> data0, Vector512<UInt128> data1, Vector512<UInt128> data2, Vector512<UInt128> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

#endif // BCL_TYPE_INT128


#if BCL_TYPE_INT128

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{ExInt128}, Vector512{ExInt128}, Vector512{ExInt128}, Vector512{ExInt128}, out Vector512{ExInt128}, out Vector512{ExInt128}, out Vector512{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<Int128> YGroup4Zip(this IWVectorTraits512 athis, Vector512<Int128> x, Vector512<Int128> y, Vector512<Int128> z, Vector512<Int128> w, out Vector512<Int128> data1, out Vector512<Int128> data2, out Vector512<Int128> data3) {
            var d0 = athis.YGroup4Zip(x.ExAsExInt128(), y.ExAsExInt128(), z.ExAsExInt128(), w.ExAsExInt128(), out var d1, out var d2, out var d3);
            data1 = d1.ExAsInt128();
            data2 = d2.ExAsInt128();
            data3 = d3.ExAsInt128();
            return d0.ExAsInt128();
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{ExUInt128}, Vector512{ExUInt128}, Vector512{ExUInt128}, Vector512{ExUInt128}, out Vector512{ExUInt128}, out Vector512{ExUInt128}, out Vector512{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<UInt128> YGroup4Zip(this IWVectorTraits512 athis, Vector512<UInt128> x, Vector512<UInt128> y, Vector512<UInt128> z, Vector512<UInt128> w, out Vector512<UInt128> data1, out Vector512<UInt128> data2, out Vector512<UInt128> data3) {
            var d0 = athis.YGroup4Zip(x.ExAsExUInt128(), y.ExAsExUInt128(), z.ExAsExUInt128(), w.ExAsExUInt128(), out var d1, out var d2, out var d3);
            data1 = d1.ExAsUInt128();
            data2 = d2.ExAsUInt128();
            data3 = d3.ExAsUInt128();
            return d0.ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="Vector128s.YGroup4Zip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<T> Data0, Vector512<T> Data1, Vector512<T> Data2, Vector512<T> Data3) YGroup4Zip<T>(this IWVectorTraits512 athis, Vector512<T> x, Vector512<T> y, Vector512<T> z, Vector512<T> w) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip((Vector512<float>)(object)x, (Vector512<float>)(object)y, (Vector512<float>)(object)z, (Vector512<float>)(object)w);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip((Vector512<double>)(object)x, (Vector512<double>)(object)y, (Vector512<double>)(object)z, (Vector512<double>)(object)w);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip((Vector512<sbyte>)(object)x, (Vector512<sbyte>)(object)y, (Vector512<sbyte>)(object)z, (Vector512<sbyte>)(object)w);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip((Vector512<byte>)(object)x, (Vector512<byte>)(object)y, (Vector512<byte>)(object)z, (Vector512<byte>)(object)w);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip((Vector512<short>)(object)x, (Vector512<short>)(object)y, (Vector512<short>)(object)z, (Vector512<short>)(object)w);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip((Vector512<ushort>)(object)x, (Vector512<ushort>)(object)y, (Vector512<ushort>)(object)z, (Vector512<ushort>)(object)w);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip((Vector512<int>)(object)x, (Vector512<int>)(object)y, (Vector512<int>)(object)z, (Vector512<int>)(object)w);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip((Vector512<uint>)(object)x, (Vector512<uint>)(object)y, (Vector512<uint>)(object)z, (Vector512<uint>)(object)w);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip((Vector512<long>)(object)x, (Vector512<long>)(object)y, (Vector512<long>)(object)z, (Vector512<long>)(object)w);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip((Vector512<ulong>)(object)x, (Vector512<ulong>)(object)y, (Vector512<ulong>)(object)z, (Vector512<ulong>)(object)w);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(ExInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip((Vector512<ExInt128>)(object)x, (Vector512<ExInt128>)(object)y, (Vector512<ExInt128>)(object)z, (Vector512<ExInt128>)(object)w);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(ExUInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip((Vector512<ExUInt128>)(object)x, (Vector512<ExUInt128>)(object)y, (Vector512<ExUInt128>)(object)z, (Vector512<ExUInt128>)(object)w);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip((Vector512<Int128>)(object)x, (Vector512<Int128>)(object)y, (Vector512<Int128>)(object)z, (Vector512<Int128>)(object)w);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(UInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip((Vector512<UInt128>)(object)x, (Vector512<UInt128>)(object)y, (Vector512<UInt128>)(object)z, (Vector512<UInt128>)(object)w);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
#endif // BCL_TYPE_INT128
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector512s.YGroup4Zip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<float> Data0, Vector512<float> Data1, Vector512<float> Data2, Vector512<float> Data3) YGroup4Zip(this IWVectorTraits512 athis, Vector512<float> x, Vector512<float> y, Vector512<float> z, Vector512<float> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<double> Data0, Vector512<double> Data1, Vector512<double> Data2, Vector512<double> Data3) YGroup4Zip(this IWVectorTraits512 athis, Vector512<double> x, Vector512<double> y, Vector512<double> z, Vector512<double> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<sbyte> Data0, Vector512<sbyte> Data1, Vector512<sbyte> Data2, Vector512<sbyte> Data3) YGroup4Zip(this IWVectorTraits512 athis, Vector512<sbyte> x, Vector512<sbyte> y, Vector512<sbyte> z, Vector512<sbyte> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<byte> Data0, Vector512<byte> Data1, Vector512<byte> Data2, Vector512<byte> Data3) YGroup4Zip(this IWVectorTraits512 athis, Vector512<byte> x, Vector512<byte> y, Vector512<byte> z, Vector512<byte> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<short> Data0, Vector512<short> Data1, Vector512<short> Data2, Vector512<short> Data3) YGroup4Zip(this IWVectorTraits512 athis, Vector512<short> x, Vector512<short> y, Vector512<short> z, Vector512<short> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ushort> Data0, Vector512<ushort> Data1, Vector512<ushort> Data2, Vector512<ushort> Data3) YGroup4Zip(this IWVectorTraits512 athis, Vector512<ushort> x, Vector512<ushort> y, Vector512<ushort> z, Vector512<ushort> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<int> Data0, Vector512<int> Data1, Vector512<int> Data2, Vector512<int> Data3) YGroup4Zip(this IWVectorTraits512 athis, Vector512<int> x, Vector512<int> y, Vector512<int> z, Vector512<int> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<uint> Data0, Vector512<uint> Data1, Vector512<uint> Data2, Vector512<uint> Data3) YGroup4Zip(this IWVectorTraits512 athis, Vector512<uint> x, Vector512<uint> y, Vector512<uint> z, Vector512<uint> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<long> Data0, Vector512<long> Data1, Vector512<long> Data2, Vector512<long> Data3) YGroup4Zip(this IWVectorTraits512 athis, Vector512<long> x, Vector512<long> y, Vector512<long> z, Vector512<long> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ulong> Data0, Vector512<ulong> Data1, Vector512<ulong> Data2, Vector512<ulong> Data3) YGroup4Zip(this IWVectorTraits512 athis, Vector512<ulong> x, Vector512<ulong> y, Vector512<ulong> z, Vector512<ulong> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ExInt128> Data0, Vector512<ExInt128> Data1, Vector512<ExInt128> Data2, Vector512<ExInt128> Data3) YGroup4Zip(this IWVectorTraits512 athis, Vector512<ExInt128> x, Vector512<ExInt128> y, Vector512<ExInt128> z, Vector512<ExInt128> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ExUInt128> Data0, Vector512<ExUInt128> Data1, Vector512<ExUInt128> Data2, Vector512<ExUInt128> Data3) YGroup4Zip(this IWVectorTraits512 athis, Vector512<ExUInt128> x, Vector512<ExUInt128> y, Vector512<ExUInt128> z, Vector512<ExUInt128> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="YGroup4Zip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<Int128> Data0, Vector512<Int128> Data1, Vector512<Int128> Data2, Vector512<Int128> Data3) YGroup4Zip(this IWVectorTraits512 athis, Vector512<Int128> x, Vector512<Int128> y, Vector512<Int128> z, Vector512<Int128> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<UInt128> Data0, Vector512<UInt128> Data1, Vector512<UInt128> Data2, Vector512<UInt128> Data3) YGroup4Zip(this IWVectorTraits512 athis, Vector512<UInt128> x, Vector512<UInt128> y, Vector512<UInt128> z, Vector512<UInt128> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

#endif // BCL_TYPE_INT128


        /// <inheritdoc cref="Vector512s.YShuffleG4X2{T}(Vector512{T}, Vector512{T}, ShuffleControlG4)"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static (Vector512<T> Result0, Vector512<T> Result1) YShuffleG4X2<T>(this IWVectorTraits512 athis, Vector512<T> source0, Vector512<T> source1, [ConstantExpected] ShuffleControlG4 control) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector512<float>)(object)source0, (Vector512<float>)(object)source1, control);
                return ((Vector512<T>)(object)result0, (Vector512<T>)(object)result1);
            } else if (typeof(double) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector512<double>)(object)source0, (Vector512<double>)(object)source1, control);
                return ((Vector512<T>)(object)result0, (Vector512<T>)(object)result1);
            } else if (typeof(sbyte) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector512<sbyte>)(object)source0, (Vector512<sbyte>)(object)source1, control);
                return ((Vector512<T>)(object)result0, (Vector512<T>)(object)result1);
            } else if (typeof(byte) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector512<byte>)(object)source0, (Vector512<byte>)(object)source1, control);
                return ((Vector512<T>)(object)result0, (Vector512<T>)(object)result1);
            } else if (typeof(short) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector512<short>)(object)source0, (Vector512<short>)(object)source1, control);
                return ((Vector512<T>)(object)result0, (Vector512<T>)(object)result1);
            } else if (typeof(ushort) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector512<ushort>)(object)source0, (Vector512<ushort>)(object)source1, control);
                return ((Vector512<T>)(object)result0, (Vector512<T>)(object)result1);
            } else if (typeof(int) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector512<int>)(object)source0, (Vector512<int>)(object)source1, control);
                return ((Vector512<T>)(object)result0, (Vector512<T>)(object)result1);
            } else if (typeof(uint) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector512<uint>)(object)source0, (Vector512<uint>)(object)source1, control);
                return ((Vector512<T>)(object)result0, (Vector512<T>)(object)result1);
            } else if (typeof(long) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector512<long>)(object)source0, (Vector512<long>)(object)source1, control);
                return ((Vector512<T>)(object)result0, (Vector512<T>)(object)result1);
            } else if (typeof(ulong) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector512<ulong>)(object)source0, (Vector512<ulong>)(object)source1, control);
                return ((Vector512<T>)(object)result0, (Vector512<T>)(object)result1);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector512s.YShuffleG4X2(Vector512{float}, Vector512{float}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<float> Result0, Vector512<float> Result1) YShuffleG4X2(this IWVectorTraits512 athis, Vector512<float> source0, Vector512<float> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleG4X2(Vector512{double}, Vector512{double}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<double> Result0, Vector512<double> Result1) YShuffleG4X2(this IWVectorTraits512 athis, Vector512<double> source0, Vector512<double> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleG4X2(Vector512{sbyte}, Vector512{sbyte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<sbyte> Result0, Vector512<sbyte> Result1) YShuffleG4X2(this IWVectorTraits512 athis, Vector512<sbyte> source0, Vector512<sbyte> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleG4X2(Vector512{byte}, Vector512{byte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<byte> Result0, Vector512<byte> Result1) YShuffleG4X2(this IWVectorTraits512 athis, Vector512<byte> source0, Vector512<byte> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleG4X2(Vector512{short}, Vector512{short}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<short> Result0, Vector512<short> Result1) YShuffleG4X2(this IWVectorTraits512 athis, Vector512<short> source0, Vector512<short> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleG4X2(Vector512{ushort}, Vector512{ushort}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ushort> Result0, Vector512<ushort> Result1) YShuffleG4X2(this IWVectorTraits512 athis, Vector512<ushort> source0, Vector512<ushort> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleG4X2(Vector512{int}, Vector512{int}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<int> Result0, Vector512<int> Result1) YShuffleG4X2(this IWVectorTraits512 athis, Vector512<int> source0, Vector512<int> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleG4X2(Vector512{uint}, Vector512{uint}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<uint> Result0, Vector512<uint> Result1) YShuffleG4X2(this IWVectorTraits512 athis, Vector512<uint> source0, Vector512<uint> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleG4X2(Vector512{long}, Vector512{long}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<long> Result0, Vector512<long> Result1) YShuffleG4X2(this IWVectorTraits512 athis, Vector512<long> source0, Vector512<long> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleG4X2(Vector512{ulong}, Vector512{ulong}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ulong> Result0, Vector512<ulong> Result1) YShuffleG4X2(this IWVectorTraits512 athis, Vector512<ulong> source0, Vector512<ulong> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleG4X2_Const{T}(Vector512{T}, Vector512{T}, ShuffleControlG4)"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static (Vector512<T> Result0, Vector512<T> Result1) YShuffleG4X2_Const<T>(this IWVectorTraits512 athis, Vector512<T> source0, Vector512<T> source1, [ConstantExpected] ShuffleControlG4 control) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector512<float>)(object)source0, (Vector512<float>)(object)source1, control);
                return ((Vector512<T>)(object)result0, (Vector512<T>)(object)result1);
            } else if (typeof(double) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector512<double>)(object)source0, (Vector512<double>)(object)source1, control);
                return ((Vector512<T>)(object)result0, (Vector512<T>)(object)result1);
            } else if (typeof(sbyte) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector512<sbyte>)(object)source0, (Vector512<sbyte>)(object)source1, control);
                return ((Vector512<T>)(object)result0, (Vector512<T>)(object)result1);
            } else if (typeof(byte) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector512<byte>)(object)source0, (Vector512<byte>)(object)source1, control);
                return ((Vector512<T>)(object)result0, (Vector512<T>)(object)result1);
            } else if (typeof(short) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector512<short>)(object)source0, (Vector512<short>)(object)source1, control);
                return ((Vector512<T>)(object)result0, (Vector512<T>)(object)result1);
            } else if (typeof(ushort) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector512<ushort>)(object)source0, (Vector512<ushort>)(object)source1, control);
                return ((Vector512<T>)(object)result0, (Vector512<T>)(object)result1);
            } else if (typeof(int) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector512<int>)(object)source0, (Vector512<int>)(object)source1, control);
                return ((Vector512<T>)(object)result0, (Vector512<T>)(object)result1);
            } else if (typeof(uint) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector512<uint>)(object)source0, (Vector512<uint>)(object)source1, control);
                return ((Vector512<T>)(object)result0, (Vector512<T>)(object)result1);
            } else if (typeof(long) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector512<long>)(object)source0, (Vector512<long>)(object)source1, control);
                return ((Vector512<T>)(object)result0, (Vector512<T>)(object)result1);
            } else if (typeof(ulong) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector512<ulong>)(object)source0, (Vector512<ulong>)(object)source1, control);
                return ((Vector512<T>)(object)result0, (Vector512<T>)(object)result1);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector512s.YShuffleG4X2_Const(Vector512{float}, Vector512{float}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<float> Result0, Vector512<float> Result1) YShuffleG4X2_Const(this IWVectorTraits512 athis, Vector512<float> source0, Vector512<float> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleG4X2_Const(Vector512{double}, Vector512{double}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<double> Result0, Vector512<double> Result1) YShuffleG4X2_Const(this IWVectorTraits512 athis, Vector512<double> source0, Vector512<double> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleG4X2_Const(Vector512{sbyte}, Vector512{sbyte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<sbyte> Result0, Vector512<sbyte> Result1) YShuffleG4X2_Const(this IWVectorTraits512 athis, Vector512<sbyte> source0, Vector512<sbyte> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleG4X2_Const(Vector512{byte}, Vector512{byte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<byte> Result0, Vector512<byte> Result1) YShuffleG4X2_Const(this IWVectorTraits512 athis, Vector512<byte> source0, Vector512<byte> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleG4X2_Const(Vector512{short}, Vector512{short}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<short> Result0, Vector512<short> Result1) YShuffleG4X2_Const(this IWVectorTraits512 athis, Vector512<short> source0, Vector512<short> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleG4X2_Const(Vector512{ushort}, Vector512{ushort}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ushort> Result0, Vector512<ushort> Result1) YShuffleG4X2_Const(this IWVectorTraits512 athis, Vector512<ushort> source0, Vector512<ushort> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleG4X2_Const(Vector512{int}, Vector512{int}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<int> Result0, Vector512<int> Result1) YShuffleG4X2_Const(this IWVectorTraits512 athis, Vector512<int> source0, Vector512<int> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleG4X2_Const(Vector512{uint}, Vector512{uint}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<uint> Result0, Vector512<uint> Result1) YShuffleG4X2_Const(this IWVectorTraits512 athis, Vector512<uint> source0, Vector512<uint> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleG4X2_Const(Vector512{long}, Vector512{long}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<long> Result0, Vector512<long> Result1) YShuffleG4X2_Const(this IWVectorTraits512 athis, Vector512<long> source0, Vector512<long> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleG4X2_Const(Vector512{ulong}, Vector512{ulong}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ulong> Result0, Vector512<ulong> Result1) YShuffleG4X2_Const(this IWVectorTraits512 athis, Vector512<ulong> source0, Vector512<ulong> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }


        /// <inheritdoc cref="Vector512s.YShuffleInsert_Args{TIdx}(Vector512{TIdx}, out Vector512{TIdx}, out Vector512{TIdx}, out Vector512{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleInsert_Args<TIdx>(this IWVectorTraits512 athis, Vector512<TIdx> indices, out Vector512<TIdx> args0, out Vector512<TIdx> args1, out Vector512<TIdx> args2)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a0, var a1, var a2) = athis.YShuffleInsert_Args((Vector512<sbyte>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a0;
                args1 = (Vector512<TIdx>)(object)a1;
                args2 = (Vector512<TIdx>)(object)a2;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a0, var a1, var a2) = athis.YShuffleInsert_Args((Vector512<byte>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a0;
                args1 = (Vector512<TIdx>)(object)a1;
                args2 = (Vector512<TIdx>)(object)a2;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a0, var a1, var a2) = athis.YShuffleInsert_Args((Vector512<short>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a0;
                args1 = (Vector512<TIdx>)(object)a1;
                args2 = (Vector512<TIdx>)(object)a2;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a0, var a1, var a2) = athis.YShuffleInsert_Args((Vector512<ushort>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a0;
                args1 = (Vector512<TIdx>)(object)a1;
                args2 = (Vector512<TIdx>)(object)a2;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a0, var a1, var a2) = athis.YShuffleInsert_Args((Vector512<int>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a0;
                args1 = (Vector512<TIdx>)(object)a1;
                args2 = (Vector512<TIdx>)(object)a2;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a0, var a1, var a2) = athis.YShuffleInsert_Args((Vector512<uint>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a0;
                args1 = (Vector512<TIdx>)(object)a1;
                args2 = (Vector512<TIdx>)(object)a2;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a0, var a1, var a2) = athis.YShuffleInsert_Args((Vector512<long>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a0;
                args1 = (Vector512<TIdx>)(object)a1;
                args2 = (Vector512<TIdx>)(object)a2;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a0, var a1, var a2) = athis.YShuffleInsert_Args((Vector512<ulong>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a0;
                args1 = (Vector512<TIdx>)(object)a1;
                args2 = (Vector512<TIdx>)(object)a2;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector512s.YShuffleInsert_Args{TIdx}(Vector512{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static (Vector512<TIdx> args0, Vector512<TIdx> args1, Vector512<TIdx> args2) YShuffleInsert_Args<TIdx>(this IWVectorTraits512 athis, Vector512<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleInsert_Args<TIdx>(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <inheritdoc cref="Vector512s.YShuffleInsert_Args(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2) YShuffleInsert_Args(this IWVectorTraits512 athis, Vector512<sbyte> indices) {
            athis.YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <inheritdoc cref="Vector512s.YShuffleInsert_Args(Vector512{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2) YShuffleInsert_Args(this IWVectorTraits512 athis, Vector512<byte> indices) {
            athis.YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <inheritdoc cref="Vector512s.YShuffleInsert_Args(Vector512{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<short> args0, Vector512<short> args1, Vector512<short> args2) YShuffleInsert_Args(this IWVectorTraits512 athis, Vector512<short> indices) {
            athis.YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <inheritdoc cref="Vector512s.YShuffleInsert_Args(Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2) YShuffleInsert_Args(this IWVectorTraits512 athis, Vector512<ushort> indices) {
            athis.YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <inheritdoc cref="Vector512s.YShuffleInsert_Args(Vector512{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<int> args0, Vector512<int> args1, Vector512<int> args2) YShuffleInsert_Args(this IWVectorTraits512 athis, Vector512<int> indices) {
            athis.YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <inheritdoc cref="Vector512s.YShuffleInsert_Args(Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2) YShuffleInsert_Args(this IWVectorTraits512 athis, Vector512<uint> indices) {
            athis.YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <inheritdoc cref="Vector512s.YShuffleInsert_Args(Vector512{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<long> args0, Vector512<long> args1, Vector512<long> args2) YShuffleInsert_Args(this IWVectorTraits512 athis, Vector512<long> indices) {
            athis.YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <inheritdoc cref="Vector512s.YShuffleInsert_Args(Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2) YShuffleInsert_Args(this IWVectorTraits512 athis, Vector512<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits512.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.YShuffleInsert_Core(Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<T> YShuffleInsert_Core<T, TIdx>(this IWVectorTraits512 athis, Vector512<T> back, Vector512<T> vector, (Vector512<TIdx> args0, Vector512<TIdx> args1, Vector512<TIdx> args2) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleInsert_Core((Vector512<float>)(object)back, (Vector512<float>)(object)vector, (ValueTuple<Vector512<int>, Vector512<int>, Vector512<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleInsert_Core((Vector512<double>)(object)back, (Vector512<double>)(object)vector, (ValueTuple<Vector512<long>, Vector512<long>, Vector512<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleInsert_Core((Vector512<sbyte>)(object)back, (Vector512<sbyte>)(object)vector, (ValueTuple<Vector512<sbyte>, Vector512<sbyte>, Vector512<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleInsert_Core((Vector512<byte>)(object)back, (Vector512<byte>)(object)vector, (ValueTuple<Vector512<byte>, Vector512<byte>, Vector512<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleInsert_Core((Vector512<short>)(object)back, (Vector512<short>)(object)vector, (ValueTuple<Vector512<short>, Vector512<short>, Vector512<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleInsert_Core((Vector512<ushort>)(object)back, (Vector512<ushort>)(object)vector, (ValueTuple<Vector512<ushort>, Vector512<ushort>, Vector512<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleInsert_Core((Vector512<int>)(object)back, (Vector512<int>)(object)vector, (ValueTuple<Vector512<int>, Vector512<int>, Vector512<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleInsert_Core((Vector512<uint>)(object)back, (Vector512<uint>)(object)vector, (ValueTuple<Vector512<uint>, Vector512<uint>, Vector512<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleInsert_Core((Vector512<long>)(object)back, (Vector512<long>)(object)vector, (ValueTuple<Vector512<long>, Vector512<long>, Vector512<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleInsert_Core((Vector512<ulong>)(object)back, (Vector512<ulong>)(object)vector, (ValueTuple<Vector512<ulong>, Vector512<ulong>, Vector512<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector512s.YShuffleInsert_Core(Vector512{float}, Vector512{float}, ValueTuple{Vector512{int}, Vector512{int}, Vector512{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YShuffleInsert_Core(this IWVectorTraits512 athis, Vector512<float> back, Vector512<float> vector, (Vector512<int> args0, Vector512<int> args1, Vector512<int> args2) args) {
            return athis.YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <inheritdoc cref="Vector512s.YShuffleInsert_Core(Vector512{double}, Vector512{double}, ValueTuple{Vector512{long}, Vector512{long}, Vector512{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YShuffleInsert_Core(this IWVectorTraits512 athis, Vector512<double> back, Vector512<double> vector, (Vector512<long> args0, Vector512<long> args1, Vector512<long> args2) args) {
            return athis.YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <inheritdoc cref="Vector512s.YShuffleInsert_Core(Vector512{sbyte}, Vector512{sbyte}, ValueTuple{Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YShuffleInsert_Core(this IWVectorTraits512 athis, Vector512<sbyte> back, Vector512<sbyte> vector, (Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2) args) {
            return athis.YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <inheritdoc cref="Vector512s.YShuffleInsert_Core(Vector512{byte}, Vector512{byte}, ValueTuple{Vector512{byte}, Vector512{byte}, Vector512{byte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YShuffleInsert_Core(this IWVectorTraits512 athis, Vector512<byte> back, Vector512<byte> vector, (Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2) args) {
            return athis.YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <inheritdoc cref="Vector512s.YShuffleInsert_Core(Vector512{short}, Vector512{short}, ValueTuple{Vector512{short}, Vector512{short}, Vector512{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YShuffleInsert_Core(this IWVectorTraits512 athis, Vector512<short> back, Vector512<short> vector, (Vector512<short> args0, Vector512<short> args1, Vector512<short> args2) args) {
            return athis.YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <inheritdoc cref="Vector512s.YShuffleInsert_Core(Vector512{ushort}, Vector512{ushort}, ValueTuple{Vector512{ushort}, Vector512{ushort}, Vector512{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YShuffleInsert_Core(this IWVectorTraits512 athis, Vector512<ushort> back, Vector512<ushort> vector, (Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2) args) {
            return athis.YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <inheritdoc cref="Vector512s.YShuffleInsert_Core(Vector512{int}, Vector512{int}, ValueTuple{Vector512{int}, Vector512{int}, Vector512{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YShuffleInsert_Core(this IWVectorTraits512 athis, Vector512<int> back, Vector512<int> vector, (Vector512<int> args0, Vector512<int> args1, Vector512<int> args2) args) {
            return athis.YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <inheritdoc cref="Vector512s.YShuffleInsert_Core(Vector512{uint}, Vector512{uint}, ValueTuple{Vector512{uint}, Vector512{uint}, Vector512{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YShuffleInsert_Core(this IWVectorTraits512 athis, Vector512<uint> back, Vector512<uint> vector, (Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2) args) {
            return athis.YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <inheritdoc cref="Vector512s.YShuffleInsert_Core(Vector512{long}, Vector512{long}, ValueTuple{Vector512{long}, Vector512{long}, Vector512{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YShuffleInsert_Core(this IWVectorTraits512 athis, Vector512<long> back, Vector512<long> vector, (Vector512<long> args0, Vector512<long> args1, Vector512<long> args2) args) {
            return athis.YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <inheritdoc cref="Vector512s.YShuffleInsert_Core(Vector512{ulong}, Vector512{ulong}, ValueTuple{Vector512{ulong}, Vector512{ulong}, Vector512{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YShuffleInsert_Core(this IWVectorTraits512 athis, Vector512<ulong> back, Vector512<ulong> vector, (Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2) args) {
            return athis.YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }


        /// <inheritdoc cref="Vector512s.YShuffleKernel_Args{TIdx}(Vector512{TIdx}, out Vector512{TIdx}, out Vector512{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleKernel_Args<TIdx>(this IWVectorTraits512 athis, Vector512<TIdx> indices, out Vector512<TIdx> args0, out Vector512<TIdx> args1)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b) = athis.YShuffleKernel_Args((Vector512<sbyte>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b) = athis.YShuffleKernel_Args((Vector512<byte>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b) = athis.YShuffleKernel_Args((Vector512<short>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b) = athis.YShuffleKernel_Args((Vector512<ushort>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b) = athis.YShuffleKernel_Args((Vector512<int>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b) = athis.YShuffleKernel_Args((Vector512<uint>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b) = athis.YShuffleKernel_Args((Vector512<long>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b) = athis.YShuffleKernel_Args((Vector512<ulong>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector512s.YShuffleKernel_Args{TIdx}(Vector512{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<TIdx> args0, Vector512<TIdx> args1) YShuffleKernel_Args<TIdx>(this IWVectorTraits512 athis, Vector512<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleKernel_Args<TIdx>(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector512s.YShuffleKernel_Args(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<sbyte> args0, Vector512<sbyte> args1) YShuffleKernel_Args(this IWVectorTraits512 athis, Vector512<sbyte> indices) {
            athis.YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector512s.YShuffleKernel_Args(Vector512{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<byte> args0, Vector512<byte> args1) YShuffleKernel_Args(this IWVectorTraits512 athis, Vector512<byte> indices) {
            athis.YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector512s.YShuffleKernel_Args(Vector512{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<short> args0, Vector512<short> args1) YShuffleKernel_Args(this IWVectorTraits512 athis, Vector512<short> indices) {
            athis.YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector512s.YShuffleKernel_Args(Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ushort> args0, Vector512<ushort> args1) YShuffleKernel_Args(this IWVectorTraits512 athis, Vector512<ushort> indices) {
            athis.YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector512s.YShuffleKernel_Args(Vector512{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<int> args0, Vector512<int> args1) YShuffleKernel_Args(this IWVectorTraits512 athis, Vector512<int> indices) {
            athis.YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector512s.YShuffleKernel_Args(Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<uint> args0, Vector512<uint> args1) YShuffleKernel_Args(this IWVectorTraits512 athis, Vector512<uint> indices) {
            athis.YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector512s.YShuffleKernel_Args(Vector512{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<long> args0, Vector512<long> args1) YShuffleKernel_Args(this IWVectorTraits512 athis, Vector512<long> indices) {
            athis.YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector512s.YShuffleKernel_Args(Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ulong> args0, Vector512<ulong> args1) YShuffleKernel_Args(this IWVectorTraits512 athis, Vector512<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits512.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.YShuffleKernel_Core(Vector512{float}, Vector512{int}, Vector512{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<T> YShuffleKernel_Core<T, TIdx>(this IWVectorTraits512 athis, Vector512<T> vector, (Vector512<TIdx> args0, Vector512<TIdx> args1) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleKernel_Core((Vector512<float>)(object)vector, (ValueTuple<Vector512<int>, Vector512<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleKernel_Core((Vector512<double>)(object)vector, (ValueTuple<Vector512<long>, Vector512<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleKernel_Core((Vector512<sbyte>)(object)vector, (ValueTuple<Vector512<sbyte>, Vector512<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleKernel_Core((Vector512<byte>)(object)vector, (ValueTuple<Vector512<byte>, Vector512<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleKernel_Core((Vector512<short>)(object)vector, (ValueTuple<Vector512<short>, Vector512<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleKernel_Core((Vector512<ushort>)(object)vector, (ValueTuple<Vector512<ushort>, Vector512<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleKernel_Core((Vector512<int>)(object)vector, (ValueTuple<Vector512<int>, Vector512<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleKernel_Core((Vector512<uint>)(object)vector, (ValueTuple<Vector512<uint>, Vector512<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleKernel_Core((Vector512<long>)(object)vector, (ValueTuple<Vector512<long>, Vector512<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleKernel_Core((Vector512<ulong>)(object)vector, (ValueTuple<Vector512<ulong>, Vector512<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector512s.YShuffleKernel_Core(Vector512{float}, ValueTuple{Vector512{int}, Vector512{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YShuffleKernel_Core(this IWVectorTraits512 athis, Vector512<float> vector, (Vector512<int> args0, Vector512<int> args1) args) {
            return athis.YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleKernel_Core(Vector512{double}, ValueTuple{Vector512{long}, Vector512{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YShuffleKernel_Core(this IWVectorTraits512 athis, Vector512<double> vector, (Vector512<long> args0, Vector512<long> args1) args) {
            return athis.YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleKernel_Core(Vector512{sbyte}, ValueTuple{Vector512{sbyte}, Vector512{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YShuffleKernel_Core(this IWVectorTraits512 athis, Vector512<sbyte> vector, (Vector512<sbyte> args0, Vector512<sbyte> args1) args) {
            return athis.YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleKernel_Core(Vector512{byte}, ValueTuple{Vector512{byte}, Vector512{byte}})"/>
        [CLSCompliant(false)]
        public static Vector512<byte> YShuffleKernel_Core(this IWVectorTraits512 athis, Vector512<byte> vector, (Vector512<byte> args0, Vector512<byte> args1) args) {
            return athis.YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleKernel_Core(Vector512{short}, ValueTuple{Vector512{short}, Vector512{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YShuffleKernel_Core(this IWVectorTraits512 athis, Vector512<short> vector, (Vector512<short> args0, Vector512<short> args1) args) {
            return athis.YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleKernel_Core(Vector512{ushort}, ValueTuple{Vector512{ushort}, Vector512{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YShuffleKernel_Core(this IWVectorTraits512 athis, Vector512<ushort> vector, (Vector512<ushort> args0, Vector512<ushort> args1) args) {
            return athis.YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleKernel_Core(Vector512{int}, ValueTuple{Vector512{int}, Vector512{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YShuffleKernel_Core(this IWVectorTraits512 athis, Vector512<int> vector, (Vector512<int> args0, Vector512<int> args1) args) {
            return athis.YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleKernel_Core(Vector512{uint}, ValueTuple{Vector512{uint}, Vector512{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YShuffleKernel_Core(this IWVectorTraits512 athis, Vector512<uint> vector, (Vector512<uint> args0, Vector512<uint> args1) args) {
            return athis.YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleKernel_Core(Vector512{long}, ValueTuple{Vector512{long}, Vector512{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YShuffleKernel_Core(this IWVectorTraits512 athis, Vector512<long> vector, (Vector512<long> args0, Vector512<long> args1) args) {
            return athis.YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleKernel_Core(Vector512{ulong}, ValueTuple{Vector512{ulong}, Vector512{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YShuffleKernel_Core(this IWVectorTraits512 athis, Vector512<ulong> vector, (Vector512<ulong> args0, Vector512<ulong> args1) args) {
            return athis.YShuffleKernel_Core(vector, args.args0, args.args1);
        }


        /// <inheritdoc cref="Vector512s.YShuffleX2_Args{TIdx}(Vector512{TIdx}, out Vector512{TIdx}, out Vector512{TIdx}, out Vector512{TIdx}, out Vector512{TIdx}, out Vector512{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleX2_Args<TIdx>(this IWVectorTraits512 athis, Vector512<TIdx> indices, out Vector512<TIdx> args0, out Vector512<TIdx> args1, out Vector512<TIdx> args2, out Vector512<TIdx> args3, out Vector512<TIdx> args4)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2_Args((Vector512<sbyte>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2_Args((Vector512<byte>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2_Args((Vector512<short>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2_Args((Vector512<ushort>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2_Args((Vector512<int>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2_Args((Vector512<uint>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2_Args((Vector512<long>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2_Args((Vector512<ulong>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2_Args{TIdx}(Vector512{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<TIdx> args0, Vector512<TIdx> args1, Vector512<TIdx> args2, Vector512<TIdx> args3, Vector512<TIdx> args4) YShuffleX2_Args<TIdx>(this IWVectorTraits512 athis, Vector512<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2_Args(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3, Vector512<sbyte> args4) YShuffleX2_Args(this IWVectorTraits512 athis, Vector512<sbyte> indices) {
            athis.YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2_Args(Vector512{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3, Vector512<byte> args4) YShuffleX2_Args(this IWVectorTraits512 athis, Vector512<byte> indices) {
            athis.YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2_Args(Vector512{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3, Vector512<short> args4) YShuffleX2_Args(this IWVectorTraits512 athis, Vector512<short> indices) {
            athis.YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2_Args(Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3, Vector512<ushort> args4) YShuffleX2_Args(this IWVectorTraits512 athis, Vector512<ushort> indices) {
            athis.YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2_Args(Vector512{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) YShuffleX2_Args(this IWVectorTraits512 athis, Vector512<int> indices) {
            athis.YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2_Args(Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3, Vector512<uint> args4) YShuffleX2_Args(this IWVectorTraits512 athis, Vector512<uint> indices) {
            athis.YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2_Args(Vector512{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) YShuffleX2_Args(this IWVectorTraits512 athis, Vector512<long> indices) {
            athis.YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2_Args(Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3, Vector512<ulong> args4) YShuffleX2_Args(this IWVectorTraits512 athis, Vector512<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits512.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.YShuffleX2_Core(Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<T> YShuffleX2_Core<T, TIdx>(this IWVectorTraits512 athis, Vector512<T> vector0, Vector512<T> vector1, (Vector512<TIdx> args0, Vector512<TIdx> args1, Vector512<TIdx> args2, Vector512<TIdx> args3, Vector512<TIdx> args4) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX2_Core((Vector512<float>)(object)vector0, (Vector512<float>)(object)vector1, (ValueTuple<Vector512<int>, Vector512<int>, Vector512<int>, Vector512<int>, Vector512<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX2_Core((Vector512<double>)(object)vector0, (Vector512<double>)(object)vector1, (ValueTuple<Vector512<long>, Vector512<long>, Vector512<long>, Vector512<long>, Vector512<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX2_Core((Vector512<sbyte>)(object)vector0, (Vector512<sbyte>)(object)vector1, (ValueTuple<Vector512<sbyte>, Vector512<sbyte>, Vector512<sbyte>, Vector512<sbyte>, Vector512<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX2_Core((Vector512<byte>)(object)vector0, (Vector512<byte>)(object)vector1, (ValueTuple<Vector512<byte>, Vector512<byte>, Vector512<byte>, Vector512<byte>, Vector512<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX2_Core((Vector512<short>)(object)vector0, (Vector512<short>)(object)vector1, (ValueTuple<Vector512<short>, Vector512<short>, Vector512<short>, Vector512<short>, Vector512<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX2_Core((Vector512<ushort>)(object)vector0, (Vector512<ushort>)(object)vector1, (ValueTuple<Vector512<ushort>, Vector512<ushort>, Vector512<ushort>, Vector512<ushort>, Vector512<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX2_Core((Vector512<int>)(object)vector0, (Vector512<int>)(object)vector1, (ValueTuple<Vector512<int>, Vector512<int>, Vector512<int>, Vector512<int>, Vector512<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX2_Core((Vector512<uint>)(object)vector0, (Vector512<uint>)(object)vector1, (ValueTuple<Vector512<uint>, Vector512<uint>, Vector512<uint>, Vector512<uint>, Vector512<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX2_Core((Vector512<long>)(object)vector0, (Vector512<long>)(object)vector1, (ValueTuple<Vector512<long>, Vector512<long>, Vector512<long>, Vector512<long>, Vector512<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX2_Core((Vector512<ulong>)(object)vector0, (Vector512<ulong>)(object)vector1, (ValueTuple<Vector512<ulong>, Vector512<ulong>, Vector512<ulong>, Vector512<ulong>, Vector512<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2_Core(Vector512{float}, Vector512{float}, ValueTuple{Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YShuffleX2_Core(this IWVectorTraits512 athis, Vector512<float> vector0, Vector512<float> vector1, (Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) args) {
            return athis.YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2_Core(Vector512{double}, Vector512{double}, ValueTuple{Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YShuffleX2_Core(this IWVectorTraits512 athis, Vector512<double> vector0, Vector512<double> vector1, (Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) args) {
            return athis.YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2_Core(Vector512{sbyte}, Vector512{sbyte}, ValueTuple{Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YShuffleX2_Core(this IWVectorTraits512 athis, Vector512<sbyte> vector0, Vector512<sbyte> vector1, (Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3, Vector512<sbyte> args4) args) {
            return athis.YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2_Core(Vector512{byte}, Vector512{byte}, ValueTuple{Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YShuffleX2_Core(this IWVectorTraits512 athis, Vector512<byte> vector0, Vector512<byte> vector1, (Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3, Vector512<byte> args4) args) {
            return athis.YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2_Core(Vector512{short}, Vector512{short}, ValueTuple{Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YShuffleX2_Core(this IWVectorTraits512 athis, Vector512<short> vector0, Vector512<short> vector1, (Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3, Vector512<short> args4) args) {
            return athis.YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2_Core(Vector512{ushort}, Vector512{ushort}, ValueTuple{Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YShuffleX2_Core(this IWVectorTraits512 athis, Vector512<ushort> vector0, Vector512<ushort> vector1, (Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3, Vector512<ushort> args4) args) {
            return athis.YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2_Core(Vector512{int}, Vector512{int}, ValueTuple{Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YShuffleX2_Core(this IWVectorTraits512 athis, Vector512<int> vector0, Vector512<int> vector1, (Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) args) {
            return athis.YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2_Core(Vector512{uint}, Vector512{uint}, ValueTuple{Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YShuffleX2_Core(this IWVectorTraits512 athis, Vector512<uint> vector0, Vector512<uint> vector1, (Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3, Vector512<uint> args4) args) {
            return athis.YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2_Core(Vector512{long}, Vector512{long}, ValueTuple{Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YShuffleX2_Core(this IWVectorTraits512 athis, Vector512<long> vector0, Vector512<long> vector1, (Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) args) {
            return athis.YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2_Core(Vector512{ulong}, Vector512{ulong}, ValueTuple{Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YShuffleX2_Core(this IWVectorTraits512 athis, Vector512<ulong> vector0, Vector512<ulong> vector1, (Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3, Vector512<ulong> args4) args) {
            return athis.YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }


        /// <inheritdoc cref="Vector512s.YShuffleX2Insert_Args{TIdx}(Vector512{TIdx}, out Vector512{TIdx}, out Vector512{TIdx}, out Vector512{TIdx}, out Vector512{TIdx}, out Vector512{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleX2Insert_Args<TIdx>(this IWVectorTraits512 athis, Vector512<TIdx> indices, out Vector512<TIdx> args0, out Vector512<TIdx> args1, out Vector512<TIdx> args2, out Vector512<TIdx> args3, out Vector512<TIdx> args4)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2Insert_Args((Vector512<sbyte>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2Insert_Args((Vector512<byte>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2Insert_Args((Vector512<short>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2Insert_Args((Vector512<ushort>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2Insert_Args((Vector512<int>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2Insert_Args((Vector512<uint>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2Insert_Args((Vector512<long>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2Insert_Args((Vector512<ulong>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2Insert_Args{TIdx}(Vector512{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<TIdx> args0, Vector512<TIdx> args1, Vector512<TIdx> args2, Vector512<TIdx> args3, Vector512<TIdx> args4) YShuffleX2Insert_Args<TIdx>(this IWVectorTraits512 athis, Vector512<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2Insert_Args(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3, Vector512<sbyte> args4) YShuffleX2Insert_Args(this IWVectorTraits512 athis, Vector512<sbyte> indices) {
            athis.YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2Insert_Args(Vector512{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3, Vector512<byte> args4) YShuffleX2Insert_Args(this IWVectorTraits512 athis, Vector512<byte> indices) {
            athis.YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2Insert_Args(Vector512{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3, Vector512<short> args4) YShuffleX2Insert_Args(this IWVectorTraits512 athis, Vector512<short> indices) {
            athis.YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2Insert_Args(Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3, Vector512<ushort> args4) YShuffleX2Insert_Args(this IWVectorTraits512 athis, Vector512<ushort> indices) {
            athis.YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2Insert_Args(Vector512{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) YShuffleX2Insert_Args(this IWVectorTraits512 athis, Vector512<int> indices) {
            athis.YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2Insert_Args(Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3, Vector512<uint> args4) YShuffleX2Insert_Args(this IWVectorTraits512 athis, Vector512<uint> indices) {
            athis.YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2Insert_Args(Vector512{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) YShuffleX2Insert_Args(this IWVectorTraits512 athis, Vector512<long> indices) {
            athis.YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2Insert_Args(Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3, Vector512<ulong> args4) YShuffleX2Insert_Args(this IWVectorTraits512 athis, Vector512<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits512.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.YShuffleX2Insert_Core(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<T> YShuffleX2Insert_Core<T, TIdx>(this IWVectorTraits512 athis, Vector512<T> back, Vector512<T> vector0, Vector512<T> vector1, (Vector512<TIdx> args0, Vector512<TIdx> args1, Vector512<TIdx> args2, Vector512<TIdx> args3, Vector512<TIdx> args4) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX2Insert_Core((Vector512<float>)(object)back, (Vector512<float>)(object)vector0, (Vector512<float>)(object)vector1, (ValueTuple<Vector512<int>, Vector512<int>, Vector512<int>, Vector512<int>, Vector512<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX2Insert_Core((Vector512<double>)(object)back, (Vector512<double>)(object)vector0, (Vector512<double>)(object)vector1, (ValueTuple<Vector512<long>, Vector512<long>, Vector512<long>, Vector512<long>, Vector512<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX2Insert_Core((Vector512<sbyte>)(object)back, (Vector512<sbyte>)(object)vector0, (Vector512<sbyte>)(object)vector1, (ValueTuple<Vector512<sbyte>, Vector512<sbyte>, Vector512<sbyte>, Vector512<sbyte>, Vector512<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX2Insert_Core((Vector512<byte>)(object)back, (Vector512<byte>)(object)vector0, (Vector512<byte>)(object)vector1, (ValueTuple<Vector512<byte>, Vector512<byte>, Vector512<byte>, Vector512<byte>, Vector512<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX2Insert_Core((Vector512<short>)(object)back, (Vector512<short>)(object)vector0, (Vector512<short>)(object)vector1, (ValueTuple<Vector512<short>, Vector512<short>, Vector512<short>, Vector512<short>, Vector512<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX2Insert_Core((Vector512<ushort>)(object)back, (Vector512<ushort>)(object)vector0, (Vector512<ushort>)(object)vector1, (ValueTuple<Vector512<ushort>, Vector512<ushort>, Vector512<ushort>, Vector512<ushort>, Vector512<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX2Insert_Core((Vector512<int>)(object)back, (Vector512<int>)(object)vector0, (Vector512<int>)(object)vector1, (ValueTuple<Vector512<int>, Vector512<int>, Vector512<int>, Vector512<int>, Vector512<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX2Insert_Core((Vector512<uint>)(object)back, (Vector512<uint>)(object)vector0, (Vector512<uint>)(object)vector1, (ValueTuple<Vector512<uint>, Vector512<uint>, Vector512<uint>, Vector512<uint>, Vector512<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX2Insert_Core((Vector512<long>)(object)back, (Vector512<long>)(object)vector0, (Vector512<long>)(object)vector1, (ValueTuple<Vector512<long>, Vector512<long>, Vector512<long>, Vector512<long>, Vector512<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX2Insert_Core((Vector512<ulong>)(object)back, (Vector512<ulong>)(object)vector0, (Vector512<ulong>)(object)vector1, (ValueTuple<Vector512<ulong>, Vector512<ulong>, Vector512<ulong>, Vector512<ulong>, Vector512<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2Insert_Core(Vector512{float}, Vector512{float}, Vector512{float}, ValueTuple{Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YShuffleX2Insert_Core(this IWVectorTraits512 athis, Vector512<float> back, Vector512<float> vector0, Vector512<float> vector1, (Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) args) {
            return athis.YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2Insert_Core(Vector512{double}, Vector512{double}, Vector512{double}, ValueTuple{Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YShuffleX2Insert_Core(this IWVectorTraits512 athis, Vector512<double> back, Vector512<double> vector0, Vector512<double> vector1, (Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) args) {
            return athis.YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2Insert_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, ValueTuple{Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YShuffleX2Insert_Core(this IWVectorTraits512 athis, Vector512<sbyte> back, Vector512<sbyte> vector0, Vector512<sbyte> vector1, (Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3, Vector512<sbyte> args4) args) {
            return athis.YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2Insert_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, ValueTuple{Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YShuffleX2Insert_Core(this IWVectorTraits512 athis, Vector512<byte> back, Vector512<byte> vector0, Vector512<byte> vector1, (Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3, Vector512<byte> args4) args) {
            return athis.YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2Insert_Core(Vector512{short}, Vector512{short}, Vector512{short}, ValueTuple{Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YShuffleX2Insert_Core(this IWVectorTraits512 athis, Vector512<short> back, Vector512<short> vector0, Vector512<short> vector1, (Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3, Vector512<short> args4) args) {
            return athis.YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2Insert_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, ValueTuple{Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YShuffleX2Insert_Core(this IWVectorTraits512 athis, Vector512<ushort> back, Vector512<ushort> vector0, Vector512<ushort> vector1, (Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3, Vector512<ushort> args4) args) {
            return athis.YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2Insert_Core(Vector512{int}, Vector512{int}, Vector512{int}, ValueTuple{Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YShuffleX2Insert_Core(this IWVectorTraits512 athis, Vector512<int> back, Vector512<int> vector0, Vector512<int> vector1, (Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) args) {
            return athis.YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2Insert_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, ValueTuple{Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YShuffleX2Insert_Core(this IWVectorTraits512 athis, Vector512<uint> back, Vector512<uint> vector0, Vector512<uint> vector1, (Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3, Vector512<uint> args4) args) {
            return athis.YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2Insert_Core(Vector512{long}, Vector512{long}, Vector512{long}, ValueTuple{Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YShuffleX2Insert_Core(this IWVectorTraits512 athis, Vector512<long> back, Vector512<long> vector0, Vector512<long> vector1, (Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) args) {
            return athis.YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2Insert_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, ValueTuple{Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YShuffleX2Insert_Core(this IWVectorTraits512 athis, Vector512<ulong> back, Vector512<ulong> vector0, Vector512<ulong> vector1, (Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3, Vector512<ulong> args4) args) {
            return athis.YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }


        /// <inheritdoc cref="Vector512s.YShuffleX2Kernel_Args{TIdx}(Vector512{TIdx}, out Vector512{TIdx}, out Vector512{TIdx}, out Vector512{TIdx}, out Vector512{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleX2Kernel_Args<TIdx>(this IWVectorTraits512 athis, Vector512<TIdx> indices, out Vector512<TIdx> args0, out Vector512<TIdx> args1, out Vector512<TIdx> args2, out Vector512<TIdx> args3)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX2Kernel_Args((Vector512<sbyte>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX2Kernel_Args((Vector512<byte>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX2Kernel_Args((Vector512<short>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX2Kernel_Args((Vector512<ushort>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX2Kernel_Args((Vector512<int>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX2Kernel_Args((Vector512<uint>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX2Kernel_Args((Vector512<long>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX2Kernel_Args((Vector512<ulong>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2Kernel_Args{TIdx}(Vector512{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<TIdx> args0, Vector512<TIdx> args1, Vector512<TIdx> args2, Vector512<TIdx> args3) YShuffleX2Kernel_Args<TIdx>(this IWVectorTraits512 athis, Vector512<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2Kernel_Args(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3) YShuffleX2Kernel_Args(this IWVectorTraits512 athis, Vector512<sbyte> indices) {
            athis.YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2Kernel_Args(Vector512{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3) YShuffleX2Kernel_Args(this IWVectorTraits512 athis, Vector512<byte> indices) {
            athis.YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2Kernel_Args(Vector512{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3) YShuffleX2Kernel_Args(this IWVectorTraits512 athis, Vector512<short> indices) {
            athis.YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2Kernel_Args(Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3) YShuffleX2Kernel_Args(this IWVectorTraits512 athis, Vector512<ushort> indices) {
            athis.YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2Kernel_Args(Vector512{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3) YShuffleX2Kernel_Args(this IWVectorTraits512 athis, Vector512<int> indices) {
            athis.YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2Kernel_Args(Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3) YShuffleX2Kernel_Args(this IWVectorTraits512 athis, Vector512<uint> indices) {
            athis.YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2Kernel_Args(Vector512{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3) YShuffleX2Kernel_Args(this IWVectorTraits512 athis, Vector512<long> indices) {
            athis.YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2Kernel_Args(Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3) YShuffleX2Kernel_Args(this IWVectorTraits512 athis, Vector512<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits512.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.YShuffleX2Kernel_Core(Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<T> YShuffleX2Kernel_Core<T, TIdx>(this IWVectorTraits512 athis, Vector512<T> vector0, Vector512<T> vector1, (Vector512<TIdx> args0, Vector512<TIdx> args1, Vector512<TIdx> args2, Vector512<TIdx> args3) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX2Kernel_Core((Vector512<float>)(object)vector0, (Vector512<float>)(object)vector1, (ValueTuple<Vector512<int>, Vector512<int>, Vector512<int>, Vector512<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX2Kernel_Core((Vector512<double>)(object)vector0, (Vector512<double>)(object)vector1, (ValueTuple<Vector512<long>, Vector512<long>, Vector512<long>, Vector512<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX2Kernel_Core((Vector512<sbyte>)(object)vector0, (Vector512<sbyte>)(object)vector1, (ValueTuple<Vector512<sbyte>, Vector512<sbyte>, Vector512<sbyte>, Vector512<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX2Kernel_Core((Vector512<byte>)(object)vector0, (Vector512<byte>)(object)vector1, (ValueTuple<Vector512<byte>, Vector512<byte>, Vector512<byte>, Vector512<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX2Kernel_Core((Vector512<short>)(object)vector0, (Vector512<short>)(object)vector1, (ValueTuple<Vector512<short>, Vector512<short>, Vector512<short>, Vector512<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX2Kernel_Core((Vector512<ushort>)(object)vector0, (Vector512<ushort>)(object)vector1, (ValueTuple<Vector512<ushort>, Vector512<ushort>, Vector512<ushort>, Vector512<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX2Kernel_Core((Vector512<int>)(object)vector0, (Vector512<int>)(object)vector1, (ValueTuple<Vector512<int>, Vector512<int>, Vector512<int>, Vector512<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX2Kernel_Core((Vector512<uint>)(object)vector0, (Vector512<uint>)(object)vector1, (ValueTuple<Vector512<uint>, Vector512<uint>, Vector512<uint>, Vector512<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX2Kernel_Core((Vector512<long>)(object)vector0, (Vector512<long>)(object)vector1, (ValueTuple<Vector512<long>, Vector512<long>, Vector512<long>, Vector512<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX2Kernel_Core((Vector512<ulong>)(object)vector0, (Vector512<ulong>)(object)vector1, (ValueTuple<Vector512<ulong>, Vector512<ulong>, Vector512<ulong>, Vector512<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2Kernel_Core(Vector512{float}, Vector512{float}, ValueTuple{Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YShuffleX2Kernel_Core(this IWVectorTraits512 athis, Vector512<float> vector0, Vector512<float> vector1, (Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3) args) {
            return athis.YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2Kernel_Core(Vector512{double}, Vector512{double}, ValueTuple{Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YShuffleX2Kernel_Core(this IWVectorTraits512 athis, Vector512<double> vector0, Vector512<double> vector1, (Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3) args) {
            return athis.YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2Kernel_Core(Vector512{sbyte}, Vector512{sbyte}, ValueTuple{Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YShuffleX2Kernel_Core(this IWVectorTraits512 athis, Vector512<sbyte> vector0, Vector512<sbyte> vector1, (Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3) args) {
            return athis.YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2Kernel_Core(Vector512{byte}, Vector512{byte}, ValueTuple{Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YShuffleX2Kernel_Core(this IWVectorTraits512 athis, Vector512<byte> vector0, Vector512<byte> vector1, (Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3) args) {
            return athis.YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2Kernel_Core(Vector512{short}, Vector512{short}, ValueTuple{Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YShuffleX2Kernel_Core(this IWVectorTraits512 athis, Vector512<short> vector0, Vector512<short> vector1, (Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3) args) {
            return athis.YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2Kernel_Core(Vector512{ushort}, Vector512{ushort}, ValueTuple{Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YShuffleX2Kernel_Core(this IWVectorTraits512 athis, Vector512<ushort> vector0, Vector512<ushort> vector1, (Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3) args) {
            return athis.YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2Kernel_Core(Vector512{int}, Vector512{int}, ValueTuple{Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YShuffleX2Kernel_Core(this IWVectorTraits512 athis, Vector512<int> vector0, Vector512<int> vector1, (Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3) args) {
            return athis.YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2Kernel_Core(Vector512{uint}, Vector512{uint}, ValueTuple{Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YShuffleX2Kernel_Core(this IWVectorTraits512 athis, Vector512<uint> vector0, Vector512<uint> vector1, (Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3) args) {
            return athis.YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2Kernel_Core(Vector512{long}, Vector512{long}, ValueTuple{Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YShuffleX2Kernel_Core(this IWVectorTraits512 athis, Vector512<long> vector0, Vector512<long> vector1, (Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3) args) {
            return athis.YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX2Kernel_Core(Vector512{ulong}, Vector512{ulong}, ValueTuple{Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YShuffleX2Kernel_Core(this IWVectorTraits512 athis, Vector512<ulong> vector0, Vector512<ulong> vector1, (Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3) args) {
            return athis.YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }


        /// <inheritdoc cref="Vector512s.YShuffleX3_Args{TIdx}(Vector512{TIdx}, out Vector512{TIdx}, out Vector512{TIdx}, out Vector512{TIdx}, out Vector512{TIdx}, out Vector512{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleX3_Args<TIdx>(this IWVectorTraits512 athis, Vector512<TIdx> indices, out Vector512<TIdx> args0, out Vector512<TIdx> args1, out Vector512<TIdx> args2, out Vector512<TIdx> args3, out Vector512<TIdx> args4)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3_Args((Vector512<sbyte>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3_Args((Vector512<byte>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3_Args((Vector512<short>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3_Args((Vector512<ushort>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3_Args((Vector512<int>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3_Args((Vector512<uint>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3_Args((Vector512<long>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3_Args((Vector512<ulong>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3_Args{TIdx}(Vector512{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<TIdx> args0, Vector512<TIdx> args1, Vector512<TIdx> args2, Vector512<TIdx> args3, Vector512<TIdx> args4) YShuffleX3_Args<TIdx>(this IWVectorTraits512 athis, Vector512<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3_Args(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3, Vector512<sbyte> args4) YShuffleX3_Args(this IWVectorTraits512 athis, Vector512<sbyte> indices) {
            athis.YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3_Args(Vector512{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3, Vector512<byte> args4) YShuffleX3_Args(this IWVectorTraits512 athis, Vector512<byte> indices) {
            athis.YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3_Args(Vector512{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3, Vector512<short> args4) YShuffleX3_Args(this IWVectorTraits512 athis, Vector512<short> indices) {
            athis.YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3_Args(Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3, Vector512<ushort> args4) YShuffleX3_Args(this IWVectorTraits512 athis, Vector512<ushort> indices) {
            athis.YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3_Args(Vector512{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) YShuffleX3_Args(this IWVectorTraits512 athis, Vector512<int> indices) {
            athis.YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3_Args(Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3, Vector512<uint> args4) YShuffleX3_Args(this IWVectorTraits512 athis, Vector512<uint> indices) {
            athis.YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3_Args(Vector512{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) YShuffleX3_Args(this IWVectorTraits512 athis, Vector512<long> indices) {
            athis.YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3_Args(Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3, Vector512<ulong> args4) YShuffleX3_Args(this IWVectorTraits512 athis, Vector512<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits512.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.YShuffleX3_Core(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<T> YShuffleX3_Core<T, TIdx>(this IWVectorTraits512 athis, Vector512<T> vector0, Vector512<T> vector1, Vector512<T> vector2, (Vector512<TIdx> args0, Vector512<TIdx> args1, Vector512<TIdx> args2, Vector512<TIdx> args3, Vector512<TIdx> args4) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX3_Core((Vector512<float>)(object)vector0, (Vector512<float>)(object)vector1, (Vector512<float>)(object)vector2, (ValueTuple<Vector512<int>, Vector512<int>, Vector512<int>, Vector512<int>, Vector512<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX3_Core((Vector512<double>)(object)vector0, (Vector512<double>)(object)vector1, (Vector512<double>)(object)vector2, (ValueTuple<Vector512<long>, Vector512<long>, Vector512<long>, Vector512<long>, Vector512<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX3_Core((Vector512<sbyte>)(object)vector0, (Vector512<sbyte>)(object)vector1, (Vector512<sbyte>)(object)vector2, (ValueTuple<Vector512<sbyte>, Vector512<sbyte>, Vector512<sbyte>, Vector512<sbyte>, Vector512<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX3_Core((Vector512<byte>)(object)vector0, (Vector512<byte>)(object)vector1, (Vector512<byte>)(object)vector2, (ValueTuple<Vector512<byte>, Vector512<byte>, Vector512<byte>, Vector512<byte>, Vector512<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX3_Core((Vector512<short>)(object)vector0, (Vector512<short>)(object)vector1, (Vector512<short>)(object)vector2, (ValueTuple<Vector512<short>, Vector512<short>, Vector512<short>, Vector512<short>, Vector512<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX3_Core((Vector512<ushort>)(object)vector0, (Vector512<ushort>)(object)vector1, (Vector512<ushort>)(object)vector2, (ValueTuple<Vector512<ushort>, Vector512<ushort>, Vector512<ushort>, Vector512<ushort>, Vector512<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX3_Core((Vector512<int>)(object)vector0, (Vector512<int>)(object)vector1, (Vector512<int>)(object)vector2, (ValueTuple<Vector512<int>, Vector512<int>, Vector512<int>, Vector512<int>, Vector512<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX3_Core((Vector512<uint>)(object)vector0, (Vector512<uint>)(object)vector1, (Vector512<uint>)(object)vector2, (ValueTuple<Vector512<uint>, Vector512<uint>, Vector512<uint>, Vector512<uint>, Vector512<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX3_Core((Vector512<long>)(object)vector0, (Vector512<long>)(object)vector1, (Vector512<long>)(object)vector2, (ValueTuple<Vector512<long>, Vector512<long>, Vector512<long>, Vector512<long>, Vector512<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX3_Core((Vector512<ulong>)(object)vector0, (Vector512<ulong>)(object)vector1, (Vector512<ulong>)(object)vector2, (ValueTuple<Vector512<ulong>, Vector512<ulong>, Vector512<ulong>, Vector512<ulong>, Vector512<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3_Core(Vector512{float}, Vector512{float}, Vector512{float}, ValueTuple{Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YShuffleX3_Core(this IWVectorTraits512 athis, Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, (Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) args) {
            return athis.YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3_Core(Vector512{double}, Vector512{double}, Vector512{double}, ValueTuple{Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YShuffleX3_Core(this IWVectorTraits512 athis, Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, (Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) args) {
            return athis.YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, ValueTuple{Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YShuffleX3_Core(this IWVectorTraits512 athis, Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, (Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3, Vector512<sbyte> args4) args) {
            return athis.YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, ValueTuple{Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YShuffleX3_Core(this IWVectorTraits512 athis, Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, (Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3, Vector512<byte> args4) args) {
            return athis.YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3_Core(Vector512{short}, Vector512{short}, Vector512{short}, ValueTuple{Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YShuffleX3_Core(this IWVectorTraits512 athis, Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, (Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3, Vector512<short> args4) args) {
            return athis.YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, ValueTuple{Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YShuffleX3_Core(this IWVectorTraits512 athis, Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, (Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3, Vector512<ushort> args4) args) {
            return athis.YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3_Core(Vector512{int}, Vector512{int}, Vector512{int}, ValueTuple{Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YShuffleX3_Core(this IWVectorTraits512 athis, Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, (Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) args) {
            return athis.YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, ValueTuple{Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YShuffleX3_Core(this IWVectorTraits512 athis, Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, (Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3, Vector512<uint> args4) args) {
            return athis.YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3_Core(Vector512{long}, Vector512{long}, Vector512{long}, ValueTuple{Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YShuffleX3_Core(this IWVectorTraits512 athis, Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, (Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) args) {
            return athis.YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, ValueTuple{Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YShuffleX3_Core(this IWVectorTraits512 athis, Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, (Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3, Vector512<ulong> args4) args) {
            return athis.YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }


        /// <inheritdoc cref="Vector512s.YShuffleX3Insert_Args{TIdx}(Vector512{TIdx}, out Vector512{TIdx}, out Vector512{TIdx}, out Vector512{TIdx}, out Vector512{TIdx}, out Vector512{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleX3Insert_Args<TIdx>(this IWVectorTraits512 athis, Vector512<TIdx> indices, out Vector512<TIdx> args0, out Vector512<TIdx> args1, out Vector512<TIdx> args2, out Vector512<TIdx> args3, out Vector512<TIdx> args4)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3Insert_Args((Vector512<sbyte>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3Insert_Args((Vector512<byte>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3Insert_Args((Vector512<short>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3Insert_Args((Vector512<ushort>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3Insert_Args((Vector512<int>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3Insert_Args((Vector512<uint>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3Insert_Args((Vector512<long>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3Insert_Args((Vector512<ulong>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3Insert_Args{TIdx}(Vector512{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<TIdx> args0, Vector512<TIdx> args1, Vector512<TIdx> args2, Vector512<TIdx> args3, Vector512<TIdx> args4) YShuffleX3Insert_Args<TIdx>(this IWVectorTraits512 athis, Vector512<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3Insert_Args(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3, Vector512<sbyte> args4) YShuffleX3Insert_Args(this IWVectorTraits512 athis, Vector512<sbyte> indices) {
            athis.YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3Insert_Args(Vector512{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3, Vector512<byte> args4) YShuffleX3Insert_Args(this IWVectorTraits512 athis, Vector512<byte> indices) {
            athis.YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3Insert_Args(Vector512{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3, Vector512<short> args4) YShuffleX3Insert_Args(this IWVectorTraits512 athis, Vector512<short> indices) {
            athis.YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3Insert_Args(Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3, Vector512<ushort> args4) YShuffleX3Insert_Args(this IWVectorTraits512 athis, Vector512<ushort> indices) {
            athis.YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3Insert_Args(Vector512{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) YShuffleX3Insert_Args(this IWVectorTraits512 athis, Vector512<int> indices) {
            athis.YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3Insert_Args(Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3, Vector512<uint> args4) YShuffleX3Insert_Args(this IWVectorTraits512 athis, Vector512<uint> indices) {
            athis.YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3Insert_Args(Vector512{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) YShuffleX3Insert_Args(this IWVectorTraits512 athis, Vector512<long> indices) {
            athis.YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3Insert_Args(Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3, Vector512<ulong> args4) YShuffleX3Insert_Args(this IWVectorTraits512 athis, Vector512<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits512.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.YShuffleX3Insert_Core(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<T> YShuffleX3Insert_Core<T, TIdx>(this IWVectorTraits512 athis, Vector512<T> back, Vector512<T> vector0, Vector512<T> vector1, Vector512<T> vector2, (Vector512<TIdx> args0, Vector512<TIdx> args1, Vector512<TIdx> args2, Vector512<TIdx> args3, Vector512<TIdx> args4) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX3Insert_Core((Vector512<float>)(object)back, (Vector512<float>)(object)vector0, (Vector512<float>)(object)vector1, (Vector512<float>)(object)vector2, (ValueTuple<Vector512<int>, Vector512<int>, Vector512<int>, Vector512<int>, Vector512<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX3Insert_Core((Vector512<double>)(object)back, (Vector512<double>)(object)vector0, (Vector512<double>)(object)vector1, (Vector512<double>)(object)vector2, (ValueTuple<Vector512<long>, Vector512<long>, Vector512<long>, Vector512<long>, Vector512<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX3Insert_Core((Vector512<sbyte>)(object)back, (Vector512<sbyte>)(object)vector0, (Vector512<sbyte>)(object)vector1, (Vector512<sbyte>)(object)vector2, (ValueTuple<Vector512<sbyte>, Vector512<sbyte>, Vector512<sbyte>, Vector512<sbyte>, Vector512<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX3Insert_Core((Vector512<byte>)(object)back, (Vector512<byte>)(object)vector0, (Vector512<byte>)(object)vector1, (Vector512<byte>)(object)vector2, (ValueTuple<Vector512<byte>, Vector512<byte>, Vector512<byte>, Vector512<byte>, Vector512<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX3Insert_Core((Vector512<short>)(object)back, (Vector512<short>)(object)vector0, (Vector512<short>)(object)vector1, (Vector512<short>)(object)vector2, (ValueTuple<Vector512<short>, Vector512<short>, Vector512<short>, Vector512<short>, Vector512<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX3Insert_Core((Vector512<ushort>)(object)back, (Vector512<ushort>)(object)vector0, (Vector512<ushort>)(object)vector1, (Vector512<ushort>)(object)vector2, (ValueTuple<Vector512<ushort>, Vector512<ushort>, Vector512<ushort>, Vector512<ushort>, Vector512<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX3Insert_Core((Vector512<int>)(object)back, (Vector512<int>)(object)vector0, (Vector512<int>)(object)vector1, (Vector512<int>)(object)vector2, (ValueTuple<Vector512<int>, Vector512<int>, Vector512<int>, Vector512<int>, Vector512<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX3Insert_Core((Vector512<uint>)(object)back, (Vector512<uint>)(object)vector0, (Vector512<uint>)(object)vector1, (Vector512<uint>)(object)vector2, (ValueTuple<Vector512<uint>, Vector512<uint>, Vector512<uint>, Vector512<uint>, Vector512<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX3Insert_Core((Vector512<long>)(object)back, (Vector512<long>)(object)vector0, (Vector512<long>)(object)vector1, (Vector512<long>)(object)vector2, (ValueTuple<Vector512<long>, Vector512<long>, Vector512<long>, Vector512<long>, Vector512<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX3Insert_Core((Vector512<ulong>)(object)back, (Vector512<ulong>)(object)vector0, (Vector512<ulong>)(object)vector1, (Vector512<ulong>)(object)vector2, (ValueTuple<Vector512<ulong>, Vector512<ulong>, Vector512<ulong>, Vector512<ulong>, Vector512<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3Insert_Core(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, ValueTuple{Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YShuffleX3Insert_Core(this IWVectorTraits512 athis, Vector512<float> back, Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, (Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) args) {
            return athis.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3Insert_Core(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, ValueTuple{Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YShuffleX3Insert_Core(this IWVectorTraits512 athis, Vector512<double> back, Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, (Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) args) {
            return athis.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3Insert_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, ValueTuple{Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YShuffleX3Insert_Core(this IWVectorTraits512 athis, Vector512<sbyte> back, Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, (Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3, Vector512<sbyte> args4) args) {
            return athis.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3Insert_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, ValueTuple{Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YShuffleX3Insert_Core(this IWVectorTraits512 athis, Vector512<byte> back, Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, (Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3, Vector512<byte> args4) args) {
            return athis.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3Insert_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, ValueTuple{Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YShuffleX3Insert_Core(this IWVectorTraits512 athis, Vector512<short> back, Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, (Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3, Vector512<short> args4) args) {
            return athis.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3Insert_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, ValueTuple{Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YShuffleX3Insert_Core(this IWVectorTraits512 athis, Vector512<ushort> back, Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, (Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3, Vector512<ushort> args4) args) {
            return athis.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3Insert_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, ValueTuple{Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YShuffleX3Insert_Core(this IWVectorTraits512 athis, Vector512<int> back, Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, (Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) args) {
            return athis.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3Insert_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, ValueTuple{Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YShuffleX3Insert_Core(this IWVectorTraits512 athis, Vector512<uint> back, Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, (Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3, Vector512<uint> args4) args) {
            return athis.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3Insert_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, ValueTuple{Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YShuffleX3Insert_Core(this IWVectorTraits512 athis, Vector512<long> back, Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, (Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) args) {
            return athis.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3Insert_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, ValueTuple{Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YShuffleX3Insert_Core(this IWVectorTraits512 athis, Vector512<ulong> back, Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, (Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3, Vector512<ulong> args4) args) {
            return athis.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }


        /// <inheritdoc cref="Vector512s.YShuffleX3Kernel_Args{TIdx}(Vector512{TIdx}, out Vector512{TIdx}, out Vector512{TIdx}, out Vector512{TIdx}, out Vector512{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleX3Kernel_Args<TIdx>(this IWVectorTraits512 athis, Vector512<TIdx> indices, out Vector512<TIdx> args0, out Vector512<TIdx> args1, out Vector512<TIdx> args2, out Vector512<TIdx> args3)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX3Kernel_Args((Vector512<sbyte>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX3Kernel_Args((Vector512<byte>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX3Kernel_Args((Vector512<short>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX3Kernel_Args((Vector512<ushort>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX3Kernel_Args((Vector512<int>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX3Kernel_Args((Vector512<uint>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX3Kernel_Args((Vector512<long>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX3Kernel_Args((Vector512<ulong>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3Kernel_Args{TIdx}(Vector512{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<TIdx> args0, Vector512<TIdx> args1, Vector512<TIdx> args2, Vector512<TIdx> args3) YShuffleX3Kernel_Args<TIdx>(this IWVectorTraits512 athis, Vector512<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3Kernel_Args(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3) YShuffleX3Kernel_Args(this IWVectorTraits512 athis, Vector512<sbyte> indices) {
            athis.YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3Kernel_Args(Vector512{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3) YShuffleX3Kernel_Args(this IWVectorTraits512 athis, Vector512<byte> indices) {
            athis.YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3Kernel_Args(Vector512{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3) YShuffleX3Kernel_Args(this IWVectorTraits512 athis, Vector512<short> indices) {
            athis.YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3Kernel_Args(Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3) YShuffleX3Kernel_Args(this IWVectorTraits512 athis, Vector512<ushort> indices) {
            athis.YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3Kernel_Args(Vector512{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3) YShuffleX3Kernel_Args(this IWVectorTraits512 athis, Vector512<int> indices) {
            athis.YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3Kernel_Args(Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3) YShuffleX3Kernel_Args(this IWVectorTraits512 athis, Vector512<uint> indices) {
            athis.YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3Kernel_Args(Vector512{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3) YShuffleX3Kernel_Args(this IWVectorTraits512 athis, Vector512<long> indices) {
            athis.YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3Kernel_Args(Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3) YShuffleX3Kernel_Args(this IWVectorTraits512 athis, Vector512<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits512.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.YShuffleX3Kernel_Core(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<T> YShuffleX3Kernel_Core<T, TIdx>(this IWVectorTraits512 athis, Vector512<T> vector0, Vector512<T> vector1, Vector512<T> vector2, (Vector512<TIdx> args0, Vector512<TIdx> args1, Vector512<TIdx> args2, Vector512<TIdx> args3) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX3Kernel_Core((Vector512<float>)(object)vector0, (Vector512<float>)(object)vector1, (Vector512<float>)(object)vector2, (ValueTuple<Vector512<int>, Vector512<int>, Vector512<int>, Vector512<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX3Kernel_Core((Vector512<double>)(object)vector0, (Vector512<double>)(object)vector1, (Vector512<double>)(object)vector2, (ValueTuple<Vector512<long>, Vector512<long>, Vector512<long>, Vector512<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX3Kernel_Core((Vector512<sbyte>)(object)vector0, (Vector512<sbyte>)(object)vector1, (Vector512<sbyte>)(object)vector2, (ValueTuple<Vector512<sbyte>, Vector512<sbyte>, Vector512<sbyte>, Vector512<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX3Kernel_Core((Vector512<byte>)(object)vector0, (Vector512<byte>)(object)vector1, (Vector512<byte>)(object)vector2, (ValueTuple<Vector512<byte>, Vector512<byte>, Vector512<byte>, Vector512<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX3Kernel_Core((Vector512<short>)(object)vector0, (Vector512<short>)(object)vector1, (Vector512<short>)(object)vector2, (ValueTuple<Vector512<short>, Vector512<short>, Vector512<short>, Vector512<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX3Kernel_Core((Vector512<ushort>)(object)vector0, (Vector512<ushort>)(object)vector1, (Vector512<ushort>)(object)vector2, (ValueTuple<Vector512<ushort>, Vector512<ushort>, Vector512<ushort>, Vector512<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX3Kernel_Core((Vector512<int>)(object)vector0, (Vector512<int>)(object)vector1, (Vector512<int>)(object)vector2, (ValueTuple<Vector512<int>, Vector512<int>, Vector512<int>, Vector512<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX3Kernel_Core((Vector512<uint>)(object)vector0, (Vector512<uint>)(object)vector1, (Vector512<uint>)(object)vector2, (ValueTuple<Vector512<uint>, Vector512<uint>, Vector512<uint>, Vector512<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX3Kernel_Core((Vector512<long>)(object)vector0, (Vector512<long>)(object)vector1, (Vector512<long>)(object)vector2, (ValueTuple<Vector512<long>, Vector512<long>, Vector512<long>, Vector512<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX3Kernel_Core((Vector512<ulong>)(object)vector0, (Vector512<ulong>)(object)vector1, (Vector512<ulong>)(object)vector2, (ValueTuple<Vector512<ulong>, Vector512<ulong>, Vector512<ulong>, Vector512<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3Kernel_Core(Vector512{float}, Vector512{float}, Vector512{float}, ValueTuple{Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YShuffleX3Kernel_Core(this IWVectorTraits512 athis, Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, (Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3) args) {
            return athis.YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3Kernel_Core(Vector512{double}, Vector512{double}, Vector512{double}, ValueTuple{Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YShuffleX3Kernel_Core(this IWVectorTraits512 athis, Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, (Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3) args) {
            return athis.YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3Kernel_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, ValueTuple{Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YShuffleX3Kernel_Core(this IWVectorTraits512 athis, Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, (Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3) args) {
            return athis.YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3Kernel_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, ValueTuple{Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YShuffleX3Kernel_Core(this IWVectorTraits512 athis, Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, (Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3) args) {
            return athis.YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3Kernel_Core(Vector512{short}, Vector512{short}, Vector512{short}, ValueTuple{Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YShuffleX3Kernel_Core(this IWVectorTraits512 athis, Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, (Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3) args) {
            return athis.YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3Kernel_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, ValueTuple{Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YShuffleX3Kernel_Core(this IWVectorTraits512 athis, Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, (Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3) args) {
            return athis.YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3Kernel_Core(Vector512{int}, Vector512{int}, Vector512{int}, ValueTuple{Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YShuffleX3Kernel_Core(this IWVectorTraits512 athis, Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, (Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3) args) {
            return athis.YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3Kernel_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, ValueTuple{Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YShuffleX3Kernel_Core(this IWVectorTraits512 athis, Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, (Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3) args) {
            return athis.YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3Kernel_Core(Vector512{long}, Vector512{long}, Vector512{long}, ValueTuple{Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YShuffleX3Kernel_Core(this IWVectorTraits512 athis, Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, (Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3) args) {
            return athis.YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX3Kernel_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, ValueTuple{Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YShuffleX3Kernel_Core(this IWVectorTraits512 athis, Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, (Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3) args) {
            return athis.YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }


        /// <inheritdoc cref="Vector512s.YShuffleX4_Args{TIdx}(Vector512{TIdx}, out Vector512{TIdx}, out Vector512{TIdx}, out Vector512{TIdx}, out Vector512{TIdx}, out Vector512{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleX4_Args<TIdx>(this IWVectorTraits512 athis, Vector512<TIdx> indices, out Vector512<TIdx> args0, out Vector512<TIdx> args1, out Vector512<TIdx> args2, out Vector512<TIdx> args3, out Vector512<TIdx> args4)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4_Args((Vector512<sbyte>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4_Args((Vector512<byte>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4_Args((Vector512<short>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4_Args((Vector512<ushort>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4_Args((Vector512<int>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4_Args((Vector512<uint>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4_Args((Vector512<long>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4_Args((Vector512<ulong>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4_Args{TIdx}(Vector512{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<TIdx> args0, Vector512<TIdx> args1, Vector512<TIdx> args2, Vector512<TIdx> args3, Vector512<TIdx> args4) YShuffleX4_Args<TIdx>(this IWVectorTraits512 athis, Vector512<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4_Args(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3, Vector512<sbyte> args4) YShuffleX4_Args(this IWVectorTraits512 athis, Vector512<sbyte> indices) {
            athis.YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4_Args(Vector512{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3, Vector512<byte> args4) YShuffleX4_Args(this IWVectorTraits512 athis, Vector512<byte> indices) {
            athis.YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4_Args(Vector512{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3, Vector512<short> args4) YShuffleX4_Args(this IWVectorTraits512 athis, Vector512<short> indices) {
            athis.YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4_Args(Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3, Vector512<ushort> args4) YShuffleX4_Args(this IWVectorTraits512 athis, Vector512<ushort> indices) {
            athis.YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4_Args(Vector512{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) YShuffleX4_Args(this IWVectorTraits512 athis, Vector512<int> indices) {
            athis.YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4_Args(Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3, Vector512<uint> args4) YShuffleX4_Args(this IWVectorTraits512 athis, Vector512<uint> indices) {
            athis.YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4_Args(Vector512{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) YShuffleX4_Args(this IWVectorTraits512 athis, Vector512<long> indices) {
            athis.YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4_Args(Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3, Vector512<ulong> args4) YShuffleX4_Args(this IWVectorTraits512 athis, Vector512<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits512.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.YShuffleX4_Core(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<T> YShuffleX4_Core<T, TIdx>(this IWVectorTraits512 athis, Vector512<T> vector0, Vector512<T> vector1, Vector512<T> vector2, Vector512<T> vector3, (Vector512<TIdx> args0, Vector512<TIdx> args1, Vector512<TIdx> args2, Vector512<TIdx> args3, Vector512<TIdx> args4) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX4_Core((Vector512<float>)(object)vector0, (Vector512<float>)(object)vector1, (Vector512<float>)(object)vector2, (Vector512<float>)(object)vector3, (ValueTuple<Vector512<int>, Vector512<int>, Vector512<int>, Vector512<int>, Vector512<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX4_Core((Vector512<double>)(object)vector0, (Vector512<double>)(object)vector1, (Vector512<double>)(object)vector2, (Vector512<double>)(object)vector3, (ValueTuple<Vector512<long>, Vector512<long>, Vector512<long>, Vector512<long>, Vector512<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX4_Core((Vector512<sbyte>)(object)vector0, (Vector512<sbyte>)(object)vector1, (Vector512<sbyte>)(object)vector2, (Vector512<sbyte>)(object)vector3, (ValueTuple<Vector512<sbyte>, Vector512<sbyte>, Vector512<sbyte>, Vector512<sbyte>, Vector512<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX4_Core((Vector512<byte>)(object)vector0, (Vector512<byte>)(object)vector1, (Vector512<byte>)(object)vector2, (Vector512<byte>)(object)vector3, (ValueTuple<Vector512<byte>, Vector512<byte>, Vector512<byte>, Vector512<byte>, Vector512<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX4_Core((Vector512<short>)(object)vector0, (Vector512<short>)(object)vector1, (Vector512<short>)(object)vector2, (Vector512<short>)(object)vector3, (ValueTuple<Vector512<short>, Vector512<short>, Vector512<short>, Vector512<short>, Vector512<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX4_Core((Vector512<ushort>)(object)vector0, (Vector512<ushort>)(object)vector1, (Vector512<ushort>)(object)vector2, (Vector512<ushort>)(object)vector3, (ValueTuple<Vector512<ushort>, Vector512<ushort>, Vector512<ushort>, Vector512<ushort>, Vector512<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX4_Core((Vector512<int>)(object)vector0, (Vector512<int>)(object)vector1, (Vector512<int>)(object)vector2, (Vector512<int>)(object)vector3, (ValueTuple<Vector512<int>, Vector512<int>, Vector512<int>, Vector512<int>, Vector512<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX4_Core((Vector512<uint>)(object)vector0, (Vector512<uint>)(object)vector1, (Vector512<uint>)(object)vector2, (Vector512<uint>)(object)vector3, (ValueTuple<Vector512<uint>, Vector512<uint>, Vector512<uint>, Vector512<uint>, Vector512<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX4_Core((Vector512<long>)(object)vector0, (Vector512<long>)(object)vector1, (Vector512<long>)(object)vector2, (Vector512<long>)(object)vector3, (ValueTuple<Vector512<long>, Vector512<long>, Vector512<long>, Vector512<long>, Vector512<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX4_Core((Vector512<ulong>)(object)vector0, (Vector512<ulong>)(object)vector1, (Vector512<ulong>)(object)vector2, (Vector512<ulong>)(object)vector3, (ValueTuple<Vector512<ulong>, Vector512<ulong>, Vector512<ulong>, Vector512<ulong>, Vector512<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4_Core(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, ValueTuple{Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YShuffleX4_Core(this IWVectorTraits512 athis, Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<float> vector3, (Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) args) {
            return athis.YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4_Core(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, ValueTuple{Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YShuffleX4_Core(this IWVectorTraits512 athis, Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<double> vector3, (Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) args) {
            return athis.YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, ValueTuple{Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YShuffleX4_Core(this IWVectorTraits512 athis, Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> vector3, (Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3, Vector512<sbyte> args4) args) {
            return athis.YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, ValueTuple{Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YShuffleX4_Core(this IWVectorTraits512 athis, Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> vector3, (Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3, Vector512<byte> args4) args) {
            return athis.YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, ValueTuple{Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YShuffleX4_Core(this IWVectorTraits512 athis, Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> vector3, (Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3, Vector512<short> args4) args) {
            return athis.YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, ValueTuple{Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YShuffleX4_Core(this IWVectorTraits512 athis, Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> vector3, (Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3, Vector512<ushort> args4) args) {
            return athis.YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, ValueTuple{Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YShuffleX4_Core(this IWVectorTraits512 athis, Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> vector3, (Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) args) {
            return athis.YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, ValueTuple{Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YShuffleX4_Core(this IWVectorTraits512 athis, Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> vector3, (Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3, Vector512<uint> args4) args) {
            return athis.YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, ValueTuple{Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YShuffleX4_Core(this IWVectorTraits512 athis, Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> vector3, (Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) args) {
            return athis.YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, ValueTuple{Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YShuffleX4_Core(this IWVectorTraits512 athis, Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> vector3, (Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3, Vector512<ulong> args4) args) {
            return athis.YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }


        /// <inheritdoc cref="Vector512s.YShuffleX4Insert_Args{TIdx}(Vector512{TIdx}, out Vector512{TIdx}, out Vector512{TIdx}, out Vector512{TIdx}, out Vector512{TIdx}, out Vector512{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleX4Insert_Args<TIdx>(this IWVectorTraits512 athis, Vector512<TIdx> indices, out Vector512<TIdx> args0, out Vector512<TIdx> args1, out Vector512<TIdx> args2, out Vector512<TIdx> args3, out Vector512<TIdx> args4)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4Insert_Args((Vector512<sbyte>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4Insert_Args((Vector512<byte>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4Insert_Args((Vector512<short>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4Insert_Args((Vector512<ushort>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4Insert_Args((Vector512<int>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4Insert_Args((Vector512<uint>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4Insert_Args((Vector512<long>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4Insert_Args((Vector512<ulong>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
                args4 = (Vector512<TIdx>)(object)e;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4Insert_Args{TIdx}(Vector512{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<TIdx> args0, Vector512<TIdx> args1, Vector512<TIdx> args2, Vector512<TIdx> args3, Vector512<TIdx> args4) YShuffleX4Insert_Args<TIdx>(this IWVectorTraits512 athis, Vector512<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4Insert_Args(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3, Vector512<sbyte> args4) YShuffleX4Insert_Args(this IWVectorTraits512 athis, Vector512<sbyte> indices) {
            athis.YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4Insert_Args(Vector512{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3, Vector512<byte> args4) YShuffleX4Insert_Args(this IWVectorTraits512 athis, Vector512<byte> indices) {
            athis.YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4Insert_Args(Vector512{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3, Vector512<short> args4) YShuffleX4Insert_Args(this IWVectorTraits512 athis, Vector512<short> indices) {
            athis.YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4Insert_Args(Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3, Vector512<ushort> args4) YShuffleX4Insert_Args(this IWVectorTraits512 athis, Vector512<ushort> indices) {
            athis.YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4Insert_Args(Vector512{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) YShuffleX4Insert_Args(this IWVectorTraits512 athis, Vector512<int> indices) {
            athis.YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4Insert_Args(Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3, Vector512<uint> args4) YShuffleX4Insert_Args(this IWVectorTraits512 athis, Vector512<uint> indices) {
            athis.YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4Insert_Args(Vector512{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) YShuffleX4Insert_Args(this IWVectorTraits512 athis, Vector512<long> indices) {
            athis.YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4Insert_Args(Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3, Vector512<ulong> args4) YShuffleX4Insert_Args(this IWVectorTraits512 athis, Vector512<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits512.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.YShuffleX4Insert_Core(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<T> YShuffleX4Insert_Core<T, TIdx>(this IWVectorTraits512 athis, Vector512<T> back, Vector512<T> vector0, Vector512<T> vector1, Vector512<T> vector2, Vector512<T> vector3, (Vector512<TIdx> args0, Vector512<TIdx> args1, Vector512<TIdx> args2, Vector512<TIdx> args3, Vector512<TIdx> args4) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX4Insert_Core((Vector512<float>)(object)back, (Vector512<float>)(object)vector0, (Vector512<float>)(object)vector1, (Vector512<float>)(object)vector2, (Vector512<float>)(object)vector3, (ValueTuple<Vector512<int>, Vector512<int>, Vector512<int>, Vector512<int>, Vector512<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX4Insert_Core((Vector512<double>)(object)back, (Vector512<double>)(object)vector0, (Vector512<double>)(object)vector1, (Vector512<double>)(object)vector2, (Vector512<double>)(object)vector3, (ValueTuple<Vector512<long>, Vector512<long>, Vector512<long>, Vector512<long>, Vector512<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX4Insert_Core((Vector512<sbyte>)(object)back, (Vector512<sbyte>)(object)vector0, (Vector512<sbyte>)(object)vector1, (Vector512<sbyte>)(object)vector2, (Vector512<sbyte>)(object)vector3, (ValueTuple<Vector512<sbyte>, Vector512<sbyte>, Vector512<sbyte>, Vector512<sbyte>, Vector512<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX4Insert_Core((Vector512<byte>)(object)back, (Vector512<byte>)(object)vector0, (Vector512<byte>)(object)vector1, (Vector512<byte>)(object)vector2, (Vector512<byte>)(object)vector3, (ValueTuple<Vector512<byte>, Vector512<byte>, Vector512<byte>, Vector512<byte>, Vector512<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX4Insert_Core((Vector512<short>)(object)back, (Vector512<short>)(object)vector0, (Vector512<short>)(object)vector1, (Vector512<short>)(object)vector2, (Vector512<short>)(object)vector3, (ValueTuple<Vector512<short>, Vector512<short>, Vector512<short>, Vector512<short>, Vector512<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX4Insert_Core((Vector512<ushort>)(object)back, (Vector512<ushort>)(object)vector0, (Vector512<ushort>)(object)vector1, (Vector512<ushort>)(object)vector2, (Vector512<ushort>)(object)vector3, (ValueTuple<Vector512<ushort>, Vector512<ushort>, Vector512<ushort>, Vector512<ushort>, Vector512<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX4Insert_Core((Vector512<int>)(object)back, (Vector512<int>)(object)vector0, (Vector512<int>)(object)vector1, (Vector512<int>)(object)vector2, (Vector512<int>)(object)vector3, (ValueTuple<Vector512<int>, Vector512<int>, Vector512<int>, Vector512<int>, Vector512<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX4Insert_Core((Vector512<uint>)(object)back, (Vector512<uint>)(object)vector0, (Vector512<uint>)(object)vector1, (Vector512<uint>)(object)vector2, (Vector512<uint>)(object)vector3, (ValueTuple<Vector512<uint>, Vector512<uint>, Vector512<uint>, Vector512<uint>, Vector512<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX4Insert_Core((Vector512<long>)(object)back, (Vector512<long>)(object)vector0, (Vector512<long>)(object)vector1, (Vector512<long>)(object)vector2, (Vector512<long>)(object)vector3, (ValueTuple<Vector512<long>, Vector512<long>, Vector512<long>, Vector512<long>, Vector512<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX4Insert_Core((Vector512<ulong>)(object)back, (Vector512<ulong>)(object)vector0, (Vector512<ulong>)(object)vector1, (Vector512<ulong>)(object)vector2, (Vector512<ulong>)(object)vector3, (ValueTuple<Vector512<ulong>, Vector512<ulong>, Vector512<ulong>, Vector512<ulong>, Vector512<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4Insert_Core(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, ValueTuple{Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YShuffleX4Insert_Core(this IWVectorTraits512 athis, Vector512<float> back, Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<float> vector3, (Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) args) {
            return athis.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4Insert_Core(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, ValueTuple{Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YShuffleX4Insert_Core(this IWVectorTraits512 athis, Vector512<double> back, Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<double> vector3, (Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) args) {
            return athis.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4Insert_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, ValueTuple{Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YShuffleX4Insert_Core(this IWVectorTraits512 athis, Vector512<sbyte> back, Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> vector3, (Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3, Vector512<sbyte> args4) args) {
            return athis.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4Insert_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, ValueTuple{Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YShuffleX4Insert_Core(this IWVectorTraits512 athis, Vector512<byte> back, Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> vector3, (Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3, Vector512<byte> args4) args) {
            return athis.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4Insert_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, ValueTuple{Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YShuffleX4Insert_Core(this IWVectorTraits512 athis, Vector512<short> back, Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> vector3, (Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3, Vector512<short> args4) args) {
            return athis.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4Insert_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, ValueTuple{Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YShuffleX4Insert_Core(this IWVectorTraits512 athis, Vector512<ushort> back, Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> vector3, (Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3, Vector512<ushort> args4) args) {
            return athis.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4Insert_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, ValueTuple{Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YShuffleX4Insert_Core(this IWVectorTraits512 athis, Vector512<int> back, Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> vector3, (Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) args) {
            return athis.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4Insert_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, ValueTuple{Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YShuffleX4Insert_Core(this IWVectorTraits512 athis, Vector512<uint> back, Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> vector3, (Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3, Vector512<uint> args4) args) {
            return athis.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4Insert_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, ValueTuple{Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YShuffleX4Insert_Core(this IWVectorTraits512 athis, Vector512<long> back, Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> vector3, (Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) args) {
            return athis.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4Insert_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, ValueTuple{Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YShuffleX4Insert_Core(this IWVectorTraits512 athis, Vector512<ulong> back, Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> vector3, (Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3, Vector512<ulong> args4) args) {
            return athis.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }


        /// <inheritdoc cref="Vector512s.YShuffleX4Kernel_Args{TIdx}(Vector512{TIdx}, out Vector512{TIdx}, out Vector512{TIdx}, out Vector512{TIdx}, out Vector512{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleX4Kernel_Args<TIdx>(this IWVectorTraits512 athis, Vector512<TIdx> indices, out Vector512<TIdx> args0, out Vector512<TIdx> args1, out Vector512<TIdx> args2, out Vector512<TIdx> args3)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX4Kernel_Args((Vector512<sbyte>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX4Kernel_Args((Vector512<byte>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX4Kernel_Args((Vector512<short>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX4Kernel_Args((Vector512<ushort>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX4Kernel_Args((Vector512<int>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX4Kernel_Args((Vector512<uint>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX4Kernel_Args((Vector512<long>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX4Kernel_Args((Vector512<ulong>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
                args2 = (Vector512<TIdx>)(object)c;
                args3 = (Vector512<TIdx>)(object)d;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4Kernel_Args{TIdx}(Vector512{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<TIdx> args0, Vector512<TIdx> args1, Vector512<TIdx> args2, Vector512<TIdx> args3) YShuffleX4Kernel_Args<TIdx>(this IWVectorTraits512 athis, Vector512<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4Kernel_Args(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3) YShuffleX4Kernel_Args(this IWVectorTraits512 athis, Vector512<sbyte> indices) {
            athis.YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4Kernel_Args(Vector512{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3) YShuffleX4Kernel_Args(this IWVectorTraits512 athis, Vector512<byte> indices) {
            athis.YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4Kernel_Args(Vector512{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3) YShuffleX4Kernel_Args(this IWVectorTraits512 athis, Vector512<short> indices) {
            athis.YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4Kernel_Args(Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3) YShuffleX4Kernel_Args(this IWVectorTraits512 athis, Vector512<ushort> indices) {
            athis.YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4Kernel_Args(Vector512{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3) YShuffleX4Kernel_Args(this IWVectorTraits512 athis, Vector512<int> indices) {
            athis.YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4Kernel_Args(Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3) YShuffleX4Kernel_Args(this IWVectorTraits512 athis, Vector512<uint> indices) {
            athis.YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4Kernel_Args(Vector512{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3) YShuffleX4Kernel_Args(this IWVectorTraits512 athis, Vector512<long> indices) {
            athis.YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4Kernel_Args(Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3) YShuffleX4Kernel_Args(this IWVectorTraits512 athis, Vector512<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits512.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.YShuffleX4Kernel_Core(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<T> YShuffleX4Kernel_Core<T, TIdx>(this IWVectorTraits512 athis, Vector512<T> vector0, Vector512<T> vector1, Vector512<T> vector2, Vector512<T> vector3, (Vector512<TIdx> args0, Vector512<TIdx> args1, Vector512<TIdx> args2, Vector512<TIdx> args3) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX4Kernel_Core((Vector512<float>)(object)vector0, (Vector512<float>)(object)vector1, (Vector512<float>)(object)vector2, (Vector512<float>)(object)vector3, (ValueTuple<Vector512<int>, Vector512<int>, Vector512<int>, Vector512<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX4Kernel_Core((Vector512<double>)(object)vector0, (Vector512<double>)(object)vector1, (Vector512<double>)(object)vector2, (Vector512<double>)(object)vector3, (ValueTuple<Vector512<long>, Vector512<long>, Vector512<long>, Vector512<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX4Kernel_Core((Vector512<sbyte>)(object)vector0, (Vector512<sbyte>)(object)vector1, (Vector512<sbyte>)(object)vector2, (Vector512<sbyte>)(object)vector3, (ValueTuple<Vector512<sbyte>, Vector512<sbyte>, Vector512<sbyte>, Vector512<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX4Kernel_Core((Vector512<byte>)(object)vector0, (Vector512<byte>)(object)vector1, (Vector512<byte>)(object)vector2, (Vector512<byte>)(object)vector3, (ValueTuple<Vector512<byte>, Vector512<byte>, Vector512<byte>, Vector512<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX4Kernel_Core((Vector512<short>)(object)vector0, (Vector512<short>)(object)vector1, (Vector512<short>)(object)vector2, (Vector512<short>)(object)vector3, (ValueTuple<Vector512<short>, Vector512<short>, Vector512<short>, Vector512<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX4Kernel_Core((Vector512<ushort>)(object)vector0, (Vector512<ushort>)(object)vector1, (Vector512<ushort>)(object)vector2, (Vector512<ushort>)(object)vector3, (ValueTuple<Vector512<ushort>, Vector512<ushort>, Vector512<ushort>, Vector512<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX4Kernel_Core((Vector512<int>)(object)vector0, (Vector512<int>)(object)vector1, (Vector512<int>)(object)vector2, (Vector512<int>)(object)vector3, (ValueTuple<Vector512<int>, Vector512<int>, Vector512<int>, Vector512<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX4Kernel_Core((Vector512<uint>)(object)vector0, (Vector512<uint>)(object)vector1, (Vector512<uint>)(object)vector2, (Vector512<uint>)(object)vector3, (ValueTuple<Vector512<uint>, Vector512<uint>, Vector512<uint>, Vector512<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX4Kernel_Core((Vector512<long>)(object)vector0, (Vector512<long>)(object)vector1, (Vector512<long>)(object)vector2, (Vector512<long>)(object)vector3, (ValueTuple<Vector512<long>, Vector512<long>, Vector512<long>, Vector512<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.YShuffleX4Kernel_Core((Vector512<ulong>)(object)vector0, (Vector512<ulong>)(object)vector1, (Vector512<ulong>)(object)vector2, (Vector512<ulong>)(object)vector3, (ValueTuple<Vector512<ulong>, Vector512<ulong>, Vector512<ulong>, Vector512<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4Kernel_Core(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, ValueTuple{Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> YShuffleX4Kernel_Core(this IWVectorTraits512 athis, Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<float> vector3, (Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3) args) {
            return athis.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4Kernel_Core(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, ValueTuple{Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> YShuffleX4Kernel_Core(this IWVectorTraits512 athis, Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<double> vector3, (Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3) args) {
            return athis.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4Kernel_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, ValueTuple{Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> YShuffleX4Kernel_Core(this IWVectorTraits512 athis, Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> vector3, (Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3) args) {
            return athis.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4Kernel_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, ValueTuple{Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> YShuffleX4Kernel_Core(this IWVectorTraits512 athis, Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> vector3, (Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3) args) {
            return athis.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4Kernel_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, ValueTuple{Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> YShuffleX4Kernel_Core(this IWVectorTraits512 athis, Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> vector3, (Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3) args) {
            return athis.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4Kernel_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, ValueTuple{Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> YShuffleX4Kernel_Core(this IWVectorTraits512 athis, Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> vector3, (Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3) args) {
            return athis.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4Kernel_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, ValueTuple{Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> YShuffleX4Kernel_Core(this IWVectorTraits512 athis, Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> vector3, (Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3) args) {
            return athis.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4Kernel_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, ValueTuple{Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> YShuffleX4Kernel_Core(this IWVectorTraits512 athis, Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> vector3, (Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3) args) {
            return athis.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4Kernel_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, ValueTuple{Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> YShuffleX4Kernel_Core(this IWVectorTraits512 athis, Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> vector3, (Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3) args) {
            return athis.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector512s.YShuffleX4Kernel_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, ValueTuple{Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> YShuffleX4Kernel_Core(this IWVectorTraits512 athis, Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> vector3, (Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3) args) {
            return athis.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
