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
    /// <summary>
    /// Extension methods of <seealso cref="IWVectorTraits128"/> (<seealso cref="IWVectorTraits128"/> 的扩展方法)
    /// </summary>
    partial class IWVectorTraits128_Extensions {
#if NETCOREAPP3_0_OR_GREATER

        /// <inheritdoc cref="Vector128s.YGroup1ToGroup3{T}(Vector128{T})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<T> Result0, Vector128<T> Result1, Vector128<T> Result2) YGroup1ToGroup3<T>(this IWVectorTraits128 athis, Vector128<T> x) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup1ToGroup3(x.As<T, float>());
                return (rt0.As<float, T>(), rt1.As<float, T>(), rt2.As<float, T>());
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup1ToGroup3(x.As<T, double>());
                return (rt0.As<double, T>(), rt1.As<double, T>(), rt2.As<double, T>());
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup1ToGroup3(x.As<T, sbyte>());
                return (rt0.As<sbyte, T>(), rt1.As<sbyte, T>(), rt2.As<sbyte, T>());
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup1ToGroup3(x.As<T, byte>());
                return (rt0.As<byte, T>(), rt1.As<byte, T>(), rt2.As<byte, T>());
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup1ToGroup3(x.As<T, short>());
                return (rt0.As<short, T>(), rt1.As<short, T>(), rt2.As<short, T>());
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup1ToGroup3(x.As<T, ushort>());
                return (rt0.As<ushort, T>(), rt1.As<ushort, T>(), rt2.As<ushort, T>());
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup1ToGroup3(x.As<T, int>());
                return (rt0.As<int, T>(), rt1.As<int, T>(), rt2.As<int, T>());
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup1ToGroup3(x.As<T, uint>());
                return (rt0.As<uint, T>(), rt1.As<uint, T>(), rt2.As<uint, T>());
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup1ToGroup3(x.As<T, long>());
                return (rt0.As<long, T>(), rt1.As<long, T>(), rt2.As<long, T>());
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup1ToGroup3(x.As<T, ulong>());
                return (rt0.As<ulong, T>(), rt1.As<ulong, T>(), rt2.As<ulong, T>());
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.YGroup1ToGroup3(Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<float> Result0, Vector128<float> Result1, Vector128<float> Result2) YGroup1ToGroup3(this IWVectorTraits128 athis, Vector128<float> x) {
            var rt0 = athis.YGroup1ToGroup3(x, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector128s.YGroup1ToGroup3(Vector128{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<double> Result0, Vector128<double> Result1, Vector128<double> Result2) YGroup1ToGroup3(this IWVectorTraits128 athis, Vector128<double> x) {
            var rt0 = athis.YGroup1ToGroup3(x, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector128s.YGroup1ToGroup3(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> Result0, Vector128<sbyte> Result1, Vector128<sbyte> Result2) YGroup1ToGroup3(this IWVectorTraits128 athis, Vector128<sbyte> x) {
            var rt0 = athis.YGroup1ToGroup3(x, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector128s.YGroup1ToGroup3(Vector128{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> Result0, Vector128<byte> Result1, Vector128<byte> Result2) YGroup1ToGroup3(this IWVectorTraits128 athis, Vector128<byte> x) {
            var rt0 = athis.YGroup1ToGroup3(x, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector128s.YGroup1ToGroup3(Vector128{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> Result0, Vector128<short> Result1, Vector128<short> Result2) YGroup1ToGroup3(this IWVectorTraits128 athis, Vector128<short> x) {
            var rt0 = athis.YGroup1ToGroup3(x, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector128s.YGroup1ToGroup3(Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> Result0, Vector128<ushort> Result1, Vector128<ushort> Result2) YGroup1ToGroup3(this IWVectorTraits128 athis, Vector128<ushort> x) {
            var rt0 = athis.YGroup1ToGroup3(x, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector128s.YGroup1ToGroup3(Vector128{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> Result0, Vector128<int> Result1, Vector128<int> Result2) YGroup1ToGroup3(this IWVectorTraits128 athis, Vector128<int> x) {
            var rt0 = athis.YGroup1ToGroup3(x, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector128s.YGroup1ToGroup3(Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> Result0, Vector128<uint> Result1, Vector128<uint> Result2) YGroup1ToGroup3(this IWVectorTraits128 athis, Vector128<uint> x) {
            var rt0 = athis.YGroup1ToGroup3(x, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector128s.YGroup1ToGroup3(Vector128{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> Result0, Vector128<long> Result1, Vector128<long> Result2) YGroup1ToGroup3(this IWVectorTraits128 athis, Vector128<long> x) {
            var rt0 = athis.YGroup1ToGroup3(x, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector128s.YGroup1ToGroup3(Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> Result0, Vector128<ulong> Result1, Vector128<ulong> Result2) YGroup1ToGroup3(this IWVectorTraits128 athis, Vector128<ulong> x) {
            var rt0 = athis.YGroup1ToGroup3(x, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }


        /// <inheritdoc cref="Vector128s.YGroup1ToGroup4{T}(Vector128{T})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<T> Result0, Vector128<T> Result1, Vector128<T> Result2, Vector128<T> Result3) YGroup1ToGroup4<T>(this IWVectorTraits128 athis, Vector128<T> x) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup1ToGroup4(x.As<T, float>());
                return (rt0.As<float, T>(), rt1.As<float, T>(), rt2.As<float, T>(), rt3.As<float, T>());
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup1ToGroup4(x.As<T, double>());
                return (rt0.As<double, T>(), rt1.As<double, T>(), rt2.As<double, T>(), rt3.As<double, T>());
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup1ToGroup4(x.As<T, sbyte>());
                return (rt0.As<sbyte, T>(), rt1.As<sbyte, T>(), rt2.As<sbyte, T>(), rt3.As<sbyte, T>());
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup1ToGroup4(x.As<T, byte>());
                return (rt0.As<byte, T>(), rt1.As<byte, T>(), rt2.As<byte, T>(), rt3.As<byte, T>());
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup1ToGroup4(x.As<T, short>());
                return (rt0.As<short, T>(), rt1.As<short, T>(), rt2.As<short, T>(), rt3.As<short, T>());
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup1ToGroup4(x.As<T, ushort>());
                return (rt0.As<ushort, T>(), rt1.As<ushort, T>(), rt2.As<ushort, T>(), rt3.As<ushort, T>());
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup1ToGroup4(x.As<T, int>());
                return (rt0.As<int, T>(), rt1.As<int, T>(), rt2.As<int, T>(), rt3.As<int, T>());
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup1ToGroup4(x.As<T, uint>());
                return (rt0.As<uint, T>(), rt1.As<uint, T>(), rt2.As<uint, T>(), rt3.As<uint, T>());
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup1ToGroup4(x.As<T, long>());
                return (rt0.As<long, T>(), rt1.As<long, T>(), rt2.As<long, T>(), rt3.As<long, T>());
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup1ToGroup4(x.As<T, ulong>());
                return (rt0.As<ulong, T>(), rt1.As<ulong, T>(), rt2.As<ulong, T>(), rt3.As<ulong, T>());
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.YGroup1ToGroup4(Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<float> Result0, Vector128<float> Result1, Vector128<float> Result2, Vector128<float> Result3) YGroup1ToGroup4(this IWVectorTraits128 athis, Vector128<float> x) {
            var rt0 = athis.YGroup1ToGroup4(x, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector128s.YGroup1ToGroup4(Vector128{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<double> Result0, Vector128<double> Result1, Vector128<double> Result2, Vector128<double> Result3) YGroup1ToGroup4(this IWVectorTraits128 athis, Vector128<double> x) {
            var rt0 = athis.YGroup1ToGroup4(x, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector128s.YGroup1ToGroup4(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> Result0, Vector128<sbyte> Result1, Vector128<sbyte> Result2, Vector128<sbyte> Result3) YGroup1ToGroup4(this IWVectorTraits128 athis, Vector128<sbyte> x) {
            var rt0 = athis.YGroup1ToGroup4(x, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector128s.YGroup1ToGroup4(Vector128{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> Result0, Vector128<byte> Result1, Vector128<byte> Result2, Vector128<byte> Result3) YGroup1ToGroup4(this IWVectorTraits128 athis, Vector128<byte> x) {
            var rt0 = athis.YGroup1ToGroup4(x, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector128s.YGroup1ToGroup4(Vector128{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> Result0, Vector128<short> Result1, Vector128<short> Result2, Vector128<short> Result3) YGroup1ToGroup4(this IWVectorTraits128 athis, Vector128<short> x) {
            var rt0 = athis.YGroup1ToGroup4(x, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector128s.YGroup1ToGroup4(Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> Result0, Vector128<ushort> Result1, Vector128<ushort> Result2, Vector128<ushort> Result3) YGroup1ToGroup4(this IWVectorTraits128 athis, Vector128<ushort> x) {
            var rt0 = athis.YGroup1ToGroup4(x, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector128s.YGroup1ToGroup4(Vector128{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> Result0, Vector128<int> Result1, Vector128<int> Result2, Vector128<int> Result3) YGroup1ToGroup4(this IWVectorTraits128 athis, Vector128<int> x) {
            var rt0 = athis.YGroup1ToGroup4(x, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector128s.YGroup1ToGroup4(Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> Result0, Vector128<uint> Result1, Vector128<uint> Result2, Vector128<uint> Result3) YGroup1ToGroup4(this IWVectorTraits128 athis, Vector128<uint> x) {
            var rt0 = athis.YGroup1ToGroup4(x, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector128s.YGroup1ToGroup4(Vector128{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> Result0, Vector128<long> Result1, Vector128<long> Result2, Vector128<long> Result3) YGroup1ToGroup4(this IWVectorTraits128 athis, Vector128<long> x) {
            var rt0 = athis.YGroup1ToGroup4(x, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector128s.YGroup1ToGroup4(Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> Result0, Vector128<ulong> Result1, Vector128<ulong> Result2, Vector128<ulong> Result3) YGroup1ToGroup4(this IWVectorTraits128 athis, Vector128<ulong> x) {
            var rt0 = athis.YGroup1ToGroup4(x, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }


        /// <inheritdoc cref="Vector128s.YGroup1ToGroup4WithW{T}(Vector128{T}, Vector128{T})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<T> Result0, Vector128<T> Result1, Vector128<T> Result2, Vector128<T> Result3) YGroup1ToGroup4WithW<T>(this IWVectorTraits128 athis, Vector128<T> x, Vector128<T> w) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup1ToGroup4WithW(x.As<T, float>(), w.As<T, float>());
                return (rt0.As<float, T>(), rt1.As<float, T>(), rt2.As<float, T>(), rt3.As<float, T>());
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup1ToGroup4WithW(x.As<T, double>(), w.As<T, double>());
                return (rt0.As<double, T>(), rt1.As<double, T>(), rt2.As<double, T>(), rt3.As<double, T>());
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup1ToGroup4WithW(x.As<T, sbyte>(), w.As<T, sbyte>());
                return (rt0.As<sbyte, T>(), rt1.As<sbyte, T>(), rt2.As<sbyte, T>(), rt3.As<sbyte, T>());
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup1ToGroup4WithW(x.As<T, byte>(), w.As<T, byte>());
                return (rt0.As<byte, T>(), rt1.As<byte, T>(), rt2.As<byte, T>(), rt3.As<byte, T>());
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup1ToGroup4WithW(x.As<T, short>(), w.As<T, short>());
                return (rt0.As<short, T>(), rt1.As<short, T>(), rt2.As<short, T>(), rt3.As<short, T>());
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup1ToGroup4WithW(x.As<T, ushort>(), w.As<T, ushort>());
                return (rt0.As<ushort, T>(), rt1.As<ushort, T>(), rt2.As<ushort, T>(), rt3.As<ushort, T>());
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup1ToGroup4WithW(x.As<T, int>(), w.As<T, int>());
                return (rt0.As<int, T>(), rt1.As<int, T>(), rt2.As<int, T>(), rt3.As<int, T>());
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup1ToGroup4WithW(x.As<T, uint>(), w.As<T, uint>());
                return (rt0.As<uint, T>(), rt1.As<uint, T>(), rt2.As<uint, T>(), rt3.As<uint, T>());
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup1ToGroup4WithW(x.As<T, long>(), w.As<T, long>());
                return (rt0.As<long, T>(), rt1.As<long, T>(), rt2.As<long, T>(), rt3.As<long, T>());
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup1ToGroup4WithW(x.As<T, ulong>(), w.As<T, ulong>());
                return (rt0.As<ulong, T>(), rt1.As<ulong, T>(), rt2.As<ulong, T>(), rt3.As<ulong, T>());
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.YGroup1ToGroup4WithW(Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<float> Result0, Vector128<float> Result1, Vector128<float> Result2, Vector128<float> Result3) YGroup1ToGroup4WithW(this IWVectorTraits128 athis, Vector128<float> x, Vector128<float> w) {
            var rt0 = athis.YGroup1ToGroup4WithW(x, w, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector128s.YGroup1ToGroup4WithW(Vector128{double}, Vector128{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<double> Result0, Vector128<double> Result1, Vector128<double> Result2, Vector128<double> Result3) YGroup1ToGroup4WithW(this IWVectorTraits128 athis, Vector128<double> x, Vector128<double> w) {
            var rt0 = athis.YGroup1ToGroup4WithW(x, w, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector128s.YGroup1ToGroup4WithW(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> Result0, Vector128<sbyte> Result1, Vector128<sbyte> Result2, Vector128<sbyte> Result3) YGroup1ToGroup4WithW(this IWVectorTraits128 athis, Vector128<sbyte> x, Vector128<sbyte> w) {
            var rt0 = athis.YGroup1ToGroup4WithW(x, w, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector128s.YGroup1ToGroup4WithW(Vector128{byte}, Vector128{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> Result0, Vector128<byte> Result1, Vector128<byte> Result2, Vector128<byte> Result3) YGroup1ToGroup4WithW(this IWVectorTraits128 athis, Vector128<byte> x, Vector128<byte> w) {
            var rt0 = athis.YGroup1ToGroup4WithW(x, w, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector128s.YGroup1ToGroup4WithW(Vector128{short}, Vector128{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> Result0, Vector128<short> Result1, Vector128<short> Result2, Vector128<short> Result3) YGroup1ToGroup4WithW(this IWVectorTraits128 athis, Vector128<short> x, Vector128<short> w) {
            var rt0 = athis.YGroup1ToGroup4WithW(x, w, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector128s.YGroup1ToGroup4WithW(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> Result0, Vector128<ushort> Result1, Vector128<ushort> Result2, Vector128<ushort> Result3) YGroup1ToGroup4WithW(this IWVectorTraits128 athis, Vector128<ushort> x, Vector128<ushort> w) {
            var rt0 = athis.YGroup1ToGroup4WithW(x, w, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector128s.YGroup1ToGroup4WithW(Vector128{int}, Vector128{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> Result0, Vector128<int> Result1, Vector128<int> Result2, Vector128<int> Result3) YGroup1ToGroup4WithW(this IWVectorTraits128 athis, Vector128<int> x, Vector128<int> w) {
            var rt0 = athis.YGroup1ToGroup4WithW(x, w, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector128s.YGroup1ToGroup4WithW(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> Result0, Vector128<uint> Result1, Vector128<uint> Result2, Vector128<uint> Result3) YGroup1ToGroup4WithW(this IWVectorTraits128 athis, Vector128<uint> x, Vector128<uint> w) {
            var rt0 = athis.YGroup1ToGroup4WithW(x, w, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector128s.YGroup1ToGroup4WithW(Vector128{long}, Vector128{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> Result0, Vector128<long> Result1, Vector128<long> Result2, Vector128<long> Result3) YGroup1ToGroup4WithW(this IWVectorTraits128 athis, Vector128<long> x, Vector128<long> w) {
            var rt0 = athis.YGroup1ToGroup4WithW(x, w, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector128s.YGroup1ToGroup4WithW(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> Result0, Vector128<ulong> Result1, Vector128<ulong> Result2, Vector128<ulong> Result3) YGroup1ToGroup4WithW(this IWVectorTraits128 athis, Vector128<ulong> x, Vector128<ulong> w) {
            var rt0 = athis.YGroup1ToGroup4WithW(x, w, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }


        /// <inheritdoc cref="Vector128s.YGroup2Transpose{T}(Vector128{T}, Vector128{T})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static (Vector128<T> Result0, Vector128<T> Result1) YGroup2Transpose<T>(this IWVectorTraits128 athis, Vector128<T> data0, Vector128<T> data1) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Transpose(data0.As<T, float>(), data1.As<T, float>());
                return (rt0.As<float, T>(), rt1.As<float, T>());
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Transpose(data0.As<T, double>(), data1.As<T, double>());
                return (rt0.As<double, T>(), rt1.As<double, T>());
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Transpose(data0.As<T, sbyte>(), data1.As<T, sbyte>());
                return (rt0.As<sbyte, T>(), rt1.As<sbyte, T>());
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Transpose(data0.As<T, byte>(), data1.As<T, byte>());
                return (rt0.As<byte, T>(), rt1.As<byte, T>());
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Transpose(data0.As<T, short>(), data1.As<T, short>());
                return (rt0.As<short, T>(), rt1.As<short, T>());
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Transpose(data0.As<T, ushort>(), data1.As<T, ushort>());
                return (rt0.As<ushort, T>(), rt1.As<ushort, T>());
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Transpose(data0.As<T, int>(), data1.As<T, int>());
                return (rt0.As<int, T>(), rt1.As<int, T>());
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Transpose(data0.As<T, uint>(), data1.As<T, uint>());
                return (rt0.As<uint, T>(), rt1.As<uint, T>());
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Transpose(data0.As<T, long>(), data1.As<T, long>());
                return (rt0.As<long, T>(), rt1.As<long, T>());
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Transpose(data0.As<T, ulong>(), data1.As<T, ulong>());
                return (rt0.As<ulong, T>(), rt1.As<ulong, T>());
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.YGroup2Transpose(Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<float> Result0, Vector128<float> Result1) YGroup2Transpose(this IWVectorTraits128 athis, Vector128<float> data0, Vector128<float> data1) {
            var rt0 = athis.YGroup2Transpose(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector128s.YGroup2Transpose(Vector128{double}, Vector128{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<double> Result0, Vector128<double> Result1) YGroup2Transpose(this IWVectorTraits128 athis, Vector128<double> data0, Vector128<double> data1) {
            var rt0 = athis.YGroup2Transpose(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector128s.YGroup2Transpose(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> Result0, Vector128<sbyte> Result1) YGroup2Transpose(this IWVectorTraits128 athis, Vector128<sbyte> data0, Vector128<sbyte> data1) {
            var rt0 = athis.YGroup2Transpose(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector128s.YGroup2Transpose(Vector128{byte}, Vector128{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> Result0, Vector128<byte> Result1) YGroup2Transpose(this IWVectorTraits128 athis, Vector128<byte> data0, Vector128<byte> data1) {
            var rt0 = athis.YGroup2Transpose(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector128s.YGroup2Transpose(Vector128{short}, Vector128{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> Result0, Vector128<short> Result1) YGroup2Transpose(this IWVectorTraits128 athis, Vector128<short> data0, Vector128<short> data1) {
            var rt0 = athis.YGroup2Transpose(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector128s.YGroup2Transpose(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> Result0, Vector128<ushort> Result1) YGroup2Transpose(this IWVectorTraits128 athis, Vector128<ushort> data0, Vector128<ushort> data1) {
            var rt0 = athis.YGroup2Transpose(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector128s.YGroup2Transpose(Vector128{int}, Vector128{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> Result0, Vector128<int> Result1) YGroup2Transpose(this IWVectorTraits128 athis, Vector128<int> data0, Vector128<int> data1) {
            var rt0 = athis.YGroup2Transpose(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector128s.YGroup2Transpose(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> Result0, Vector128<uint> Result1) YGroup2Transpose(this IWVectorTraits128 athis, Vector128<uint> data0, Vector128<uint> data1) {
            var rt0 = athis.YGroup2Transpose(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector128s.YGroup2Transpose(Vector128{long}, Vector128{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> Result0, Vector128<long> Result1) YGroup2Transpose(this IWVectorTraits128 athis, Vector128<long> data0, Vector128<long> data1) {
            var rt0 = athis.YGroup2Transpose(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector128s.YGroup2Transpose(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> Result0, Vector128<ulong> Result1) YGroup2Transpose(this IWVectorTraits128 athis, Vector128<ulong> data0, Vector128<ulong> data1) {
            var rt0 = athis.YGroup2Transpose(data0, data1, out var rt1);
            return (rt0, rt1);
        }


#if BCL_TYPE_INT128

        /// <inheritdoc cref="Vector128s.YGroup2Unzip(Vector128{ExInt128}, Vector128{ExInt128}, out Vector128{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<Int128> YGroup2Unzip(this IWVectorTraits128 athis, Vector128<Int128> data0, Vector128<Int128> data1, out Vector128<Int128> y) {
            var d0 = athis.YGroup2Unzip(data0.ExAsExInt128(), data1.ExAsExInt128(), out var d1);
            y = d1.ExAsInt128();
            return d0.ExAsInt128();
        }

        /// <inheritdoc cref="Vector128s.YGroup2Unzip(Vector128{ExUInt128}, Vector128{ExUInt128}, out Vector128{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<UInt128> YGroup2Unzip(this IWVectorTraits128 athis, Vector128<UInt128> data0, Vector128<UInt128> data1, out Vector128<UInt128> y) {
            var d0 = athis.YGroup2Unzip(data0.ExAsExUInt128(), data1.ExAsExUInt128(), out var d1);
            y = d1.ExAsUInt128();
            return d0.ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="Vector128s.YGroup2Unzip{T}(Vector128{T}, Vector128{T})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static (Vector128<T> X, Vector128<T> Y) YGroup2Unzip<T>(this IWVectorTraits128 athis, Vector128<T> data0, Vector128<T> data1) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip(data0.As<T, float>(), data1.As<T, float>());
                return (rt0.As<float, T>(), rt1.As<float, T>());
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip(data0.As<T, double>(), data1.As<T, double>());
                return (rt0.As<double, T>(), rt1.As<double, T>());
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip(data0.As<T, sbyte>(), data1.As<T, sbyte>());
                return (rt0.As<sbyte, T>(), rt1.As<sbyte, T>());
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip(data0.As<T, byte>(), data1.As<T, byte>());
                return (rt0.As<byte, T>(), rt1.As<byte, T>());
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip(data0.As<T, short>(), data1.As<T, short>());
                return (rt0.As<short, T>(), rt1.As<short, T>());
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip(data0.As<T, ushort>(), data1.As<T, ushort>());
                return (rt0.As<ushort, T>(), rt1.As<ushort, T>());
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip(data0.As<T, int>(), data1.As<T, int>());
                return (rt0.As<int, T>(), rt1.As<int, T>());
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip(data0.As<T, uint>(), data1.As<T, uint>());
                return (rt0.As<uint, T>(), rt1.As<uint, T>());
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip(data0.As<T, long>(), data1.As<T, long>());
                return (rt0.As<long, T>(), rt1.As<long, T>());
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip(data0.As<T, ulong>(), data1.As<T, ulong>());
                return (rt0.As<ulong, T>(), rt1.As<ulong, T>());
            } else if (typeof(ExInt128) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip(data0.ExAs<T, ExInt128>(), data1.ExAs<T, ExInt128>());
                return (rt0.ExAs<ExInt128, T>(), rt1.ExAs<ExInt128, T>());
            } else if (typeof(ExUInt128) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip(data0.ExAs<T, ExUInt128>(), data1.ExAs<T, ExUInt128>());
                return (rt0.ExAs<ExUInt128, T>(), rt1.ExAs<ExUInt128, T>());
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip(data0.ExAs<T, Int128>(), data1.ExAs<T, Int128>());
                return (rt0.ExAs<Int128, T>(), rt1.ExAs<Int128, T>());
            } else if (typeof(UInt128) == typeof(T)) {
                (var rt0, var rt1) = athis.YGroup2Unzip(data0.ExAs<T, UInt128>(), data1.ExAs<T, UInt128>());
                return (rt0.ExAs<UInt128, T>(), rt1.ExAs<UInt128, T>());
#endif // BCL_TYPE_INT128
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.YGroup2Unzip(Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<float> X, Vector128<float> Y) YGroup2Unzip(this IWVectorTraits128 athis, Vector128<float> data0, Vector128<float> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector128s.YGroup2Unzip(Vector128{double}, Vector128{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<double> X, Vector128<double> Y) YGroup2Unzip(this IWVectorTraits128 athis, Vector128<double> data0, Vector128<double> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector128s.YGroup2Unzip(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> X, Vector128<sbyte> Y) YGroup2Unzip(this IWVectorTraits128 athis, Vector128<sbyte> data0, Vector128<sbyte> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector128s.YGroup2Unzip(Vector128{byte}, Vector128{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> X, Vector128<byte> Y) YGroup2Unzip(this IWVectorTraits128 athis, Vector128<byte> data0, Vector128<byte> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector128s.YGroup2Unzip(Vector128{short}, Vector128{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> X, Vector128<short> Y) YGroup2Unzip(this IWVectorTraits128 athis, Vector128<short> data0, Vector128<short> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector128s.YGroup2Unzip(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> X, Vector128<ushort> Y) YGroup2Unzip(this IWVectorTraits128 athis, Vector128<ushort> data0, Vector128<ushort> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector128s.YGroup2Unzip(Vector128{int}, Vector128{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> X, Vector128<int> Y) YGroup2Unzip(this IWVectorTraits128 athis, Vector128<int> data0, Vector128<int> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector128s.YGroup2Unzip(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> X, Vector128<uint> Y) YGroup2Unzip(this IWVectorTraits128 athis, Vector128<uint> data0, Vector128<uint> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector128s.YGroup2Unzip(Vector128{long}, Vector128{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> X, Vector128<long> Y) YGroup2Unzip(this IWVectorTraits128 athis, Vector128<long> data0, Vector128<long> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector128s.YGroup2Unzip(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> X, Vector128<ulong> Y) YGroup2Unzip(this IWVectorTraits128 athis, Vector128<ulong> data0, Vector128<ulong> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector128s.YGroup2Unzip(Vector128{ExInt128}, Vector128{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ExInt128> X, Vector128<ExInt128> Y) YGroup2Unzip(this IWVectorTraits128 athis, Vector128<ExInt128> data0, Vector128<ExInt128> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector128s.YGroup2Unzip(Vector128{ExUInt128}, Vector128{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ExUInt128> X, Vector128<ExUInt128> Y) YGroup2Unzip(this IWVectorTraits128 athis, Vector128<ExUInt128> data0, Vector128<ExUInt128> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="Vector128s.YGroup2Unzip(Vector128{Int128}, Vector128{Int128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<Int128> X, Vector128<Int128> Y) YGroup2Unzip(this IWVectorTraits128 athis, Vector128<Int128> data0, Vector128<Int128> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="Vector128s.YGroup2Unzip(Vector128{UInt128}, Vector128{UInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<UInt128> X, Vector128<UInt128> Y) YGroup2Unzip(this IWVectorTraits128 athis, Vector128<UInt128> data0, Vector128<UInt128> data1) {
            var rt0 = athis.YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="Vector128s.YGroup2UnzipEven(Vector128{int}, Vector128{int})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static Vector128<T> YGroup2UnzipEven<T>(this IWVectorTraits128 athis, Vector128<T> data0, Vector128<T> data1) where T : struct {
            if (typeof(float) == typeof(T)) {
                return athis.YGroup2UnzipEven(data0.As<T, float>(), data1.As<T, float>()).As<float, T>();
            } else if (typeof(double) == typeof(T)) {
                return athis.YGroup2UnzipEven(data0.As<T, double>(), data1.As<T, double>()).As<double, T>();
            } else if (typeof(sbyte) == typeof(T)) {
                return athis.YGroup2UnzipEven(data0.As<T, sbyte>(), data1.As<T, sbyte>()).As<sbyte, T>();
            } else if (typeof(byte) == typeof(T)) {
                return athis.YGroup2UnzipEven(data0.As<T, byte>(), data1.As<T, byte>()).As<byte, T>();
            } else if (typeof(short) == typeof(T)) {
                return athis.YGroup2UnzipEven(data0.As<T, short>(), data1.As<T, short>()).As<short, T>();
            } else if (typeof(ushort) == typeof(T)) {
                return athis.YGroup2UnzipEven(data0.As<T, ushort>(), data1.As<T, ushort>()).As<ushort, T>();
            } else if (typeof(int) == typeof(T)) {
                return athis.YGroup2UnzipEven(data0.As<T, int>(), data1.As<T, int>()).As<int, T>();
            } else if (typeof(uint) == typeof(T)) {
                return athis.YGroup2UnzipEven(data0.As<T, uint>(), data1.As<T, uint>()).As<uint, T>();
            } else if (typeof(long) == typeof(T)) {
                return athis.YGroup2UnzipEven(data0.As<T, long>(), data1.As<T, long>()).As<long, T>();
            } else if (typeof(ulong) == typeof(T)) {
                return athis.YGroup2UnzipEven(data0.As<T, ulong>(), data1.As<T, ulong>()).As<ulong, T>();
            } else if (typeof(ExInt128) == typeof(T)) {
                return athis.YGroup2UnzipEven(data0.ExAs<T, ExInt128>(), data1.ExAs<T, ExInt128>()).ExAs<ExInt128, T>();
            } else if (typeof(ExUInt128) == typeof(T)) {
                return athis.YGroup2UnzipEven(data0.ExAs<T, ExUInt128>(), data1.ExAs<T, ExUInt128>()).ExAs<ExUInt128, T>();
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                return athis.YGroup2UnzipEven(data0.ExAs<T, Int128>(), data1.ExAs<T, Int128>()).ExAs<Int128, T>();
            } else if (typeof(UInt128) == typeof(T)) {
                return athis.YGroup2UnzipEven(data0.ExAs<T, UInt128>(), data1.ExAs<T, UInt128>()).ExAs<UInt128, T>();
#endif // BCL_TYPE_INT128
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="Vector128s.YGroup2UnzipEven(Vector128{ExInt128}, Vector128{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<Int128> YGroup2UnzipEven(this IWVectorTraits128 athis, Vector128<Int128> data0, Vector128<Int128> data1) {
            return athis.YGroup2UnzipEven(data0.ExAsExInt128(), data1.ExAsExInt128()).ExAsInt128();
        }

        /// <inheritdoc cref="Vector128s.YGroup2UnzipEven(Vector128{ExUInt128}, Vector128{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<UInt128> YGroup2UnzipEven(this IWVectorTraits128 athis, Vector128<UInt128> data0, Vector128<UInt128> data1) {
            return athis.YGroup2UnzipEven(data0.ExAsExUInt128(), data1.ExAsExUInt128()).ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="Vector128s.YGroup2UnzipOdd(Vector128{int}, Vector128{int})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static Vector128<T> YGroup2UnzipOdd<T>(this IWVectorTraits128 athis, Vector128<T> data0, Vector128<T> data1) where T : struct {
            if (typeof(float) == typeof(T)) {
                return athis.YGroup2UnzipOdd(data0.As<T, float>(), data1.As<T, float>()).As<float, T>();
            } else if (typeof(double) == typeof(T)) {
                return athis.YGroup2UnzipOdd(data0.As<T, double>(), data1.As<T, double>()).As<double, T>();
            } else if (typeof(sbyte) == typeof(T)) {
                return athis.YGroup2UnzipOdd(data0.As<T, sbyte>(), data1.As<T, sbyte>()).As<sbyte, T>();
            } else if (typeof(byte) == typeof(T)) {
                return athis.YGroup2UnzipOdd(data0.As<T, byte>(), data1.As<T, byte>()).As<byte, T>();
            } else if (typeof(short) == typeof(T)) {
                return athis.YGroup2UnzipOdd(data0.As<T, short>(), data1.As<T, short>()).As<short, T>();
            } else if (typeof(ushort) == typeof(T)) {
                return athis.YGroup2UnzipOdd(data0.As<T, ushort>(), data1.As<T, ushort>()).As<ushort, T>();
            } else if (typeof(int) == typeof(T)) {
                return athis.YGroup2UnzipOdd(data0.As<T, int>(), data1.As<T, int>()).As<int, T>();
            } else if (typeof(uint) == typeof(T)) {
                return athis.YGroup2UnzipOdd(data0.As<T, uint>(), data1.As<T, uint>()).As<uint, T>();
            } else if (typeof(long) == typeof(T)) {
                return athis.YGroup2UnzipOdd(data0.As<T, long>(), data1.As<T, long>()).As<long, T>();
            } else if (typeof(ulong) == typeof(T)) {
                return athis.YGroup2UnzipOdd(data0.As<T, ulong>(), data1.As<T, ulong>()).As<ulong, T>();
            } else if (typeof(ExInt128) == typeof(T)) {
                return athis.YGroup2UnzipOdd(data0.ExAs<T, ExInt128>(), data1.ExAs<T, ExInt128>()).ExAs<ExInt128, T>();
            } else if (typeof(ExUInt128) == typeof(T)) {
                return athis.YGroup2UnzipOdd(data0.ExAs<T, ExUInt128>(), data1.ExAs<T, ExUInt128>()).ExAs<ExUInt128, T>();
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                return athis.YGroup2UnzipOdd(data0.ExAs<T, Int128>(), data1.ExAs<T, Int128>()).ExAs<Int128, T>();
            } else if (typeof(UInt128) == typeof(T)) {
                return athis.YGroup2UnzipOdd(data0.ExAs<T, UInt128>(), data1.ExAs<T, UInt128>()).ExAs<UInt128, T>();
#endif // BCL_TYPE_INT128
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="Vector128s.YGroup2UnzipOdd(Vector128{ExInt128}, Vector128{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<Int128> YGroup2UnzipOdd(this IWVectorTraits128 athis, Vector128<Int128> data0, Vector128<Int128> data1) {
            return athis.YGroup2UnzipOdd(data0.ExAsExInt128(), data1.ExAsExInt128()).ExAsInt128();
        }

        /// <inheritdoc cref="Vector128s.YGroup2UnzipOdd(Vector128{ExUInt128}, Vector128{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<UInt128> YGroup2UnzipOdd(this IWVectorTraits128 athis, Vector128<UInt128> data0, Vector128<UInt128> data1) {
            return athis.YGroup2UnzipOdd(data0.ExAsExUInt128(), data1.ExAsExUInt128()).ExAsUInt128();
        }

#endif // BCL_TYPE_INT128


#if BCL_TYPE_INT128

        /// <inheritdoc cref="Vector128s.YGroup2Zip(Vector128{ExInt128}, Vector128{ExInt128}, out Vector128{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<Int128> YGroup2Zip(this IWVectorTraits128 athis, Vector128<Int128> x, Vector128<Int128> y, out Vector128<Int128> data1) {
            var d0 = athis.YGroup2Zip(x.ExAsExInt128(), y.ExAsExInt128(), out var d1);
            data1 = d1.ExAsInt128();
            return d0.ExAsInt128();
        }

        /// <inheritdoc cref="Vector128s.YGroup2Zip(Vector128{ExUInt128}, Vector128{ExUInt128}, out Vector128{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<UInt128> YGroup2Zip(this IWVectorTraits128 athis, Vector128<UInt128> x, Vector128<UInt128> y, out Vector128<UInt128> data1) {
            var d0 = athis.YGroup2Zip(x.ExAsExUInt128(), y.ExAsExUInt128(), out var d1);
            data1 = d1.ExAsUInt128();
            return d0.ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="Vector128s.YGroup2Zip{T}(Vector128{T}, Vector128{T})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static (Vector128<T> Data0, Vector128<T> Data1) YGroup2Zip<T>(this IWVectorTraits128 athis, Vector128<T> x, Vector128<T> y) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip(x.As<T, float>(), y.As<T, float>());
                return (data0.As<float, T>(), data1.As<float, T>());
            } else if (typeof(double) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip(x.As<T, double>(), y.As<T, double>());
                return (data0.As<double, T>(), data1.As<double, T>());
            } else if (typeof(sbyte) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip(x.As<T, sbyte>(), y.As<T, sbyte>());
                return (data0.As<sbyte, T>(), data1.As<sbyte, T>());
            } else if (typeof(byte) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip(x.As<T, byte>(), y.As<T, byte>());
                return (data0.As<byte, T>(), data1.As<byte, T>());
            } else if (typeof(short) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip(x.As<T, short>(), y.As<T, short>());
                return (data0.As<short, T>(), data1.As<short, T>());
            } else if (typeof(ushort) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip(x.As<T, ushort>(), y.As<T, ushort>());
                return (data0.As<ushort, T>(), data1.As<ushort, T>());
            } else if (typeof(int) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip(x.As<T, int>(), y.As<T, int>());
                return (data0.As<int, T>(), data1.As<int, T>());
            } else if (typeof(uint) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip(x.As<T, uint>(), y.As<T, uint>());
                return (data0.As<uint, T>(), data1.As<uint, T>());
            } else if (typeof(long) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip(x.As<T, long>(), y.As<T, long>());
                return (data0.As<long, T>(), data1.As<long, T>());
            } else if (typeof(ulong) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip(x.As<T, ulong>(), y.As<T, ulong>());
                return (data0.As<ulong, T>(), data1.As<ulong, T>());
            } else if (typeof(ExInt128) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip(x.ExAs<T, ExInt128>(), y.ExAs<T, ExInt128>());
                return (data0.ExAs<ExInt128, T>(), data1.ExAs<ExInt128, T>());
            } else if (typeof(ExUInt128) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip(x.ExAs<T, ExUInt128>(), y.ExAs<T, ExUInt128>());
                return (data0.ExAs<ExUInt128, T>(), data1.ExAs<ExUInt128, T>());
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip(x.ExAs<T, Int128>(), y.ExAs<T, Int128>());
                return (data0.ExAs<Int128, T>(), data1.ExAs<Int128, T>());
            } else if (typeof(UInt128) == typeof(T)) {
                (var data0, var data1) = athis.YGroup2Zip(x.ExAs<T, UInt128>(), y.ExAs<T, UInt128>());
                return (data0.ExAs<UInt128, T>(), data1.ExAs<UInt128, T>());
#endif // BCL_TYPE_INT128
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.YGroup2Zip(Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<float> Data0, Vector128<float> Data1) YGroup2Zip(this IWVectorTraits128 athis, Vector128<float> x, Vector128<float> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vector128s.YGroup2Zip(Vector128{double}, Vector128{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<double> Data0, Vector128<double> Data1) YGroup2Zip(this IWVectorTraits128 athis, Vector128<double> x, Vector128<double> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vector128s.YGroup2Zip(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> Data0, Vector128<sbyte> Data1) YGroup2Zip(this IWVectorTraits128 athis, Vector128<sbyte> x, Vector128<sbyte> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vector128s.YGroup2Zip(Vector128{byte}, Vector128{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> Data0, Vector128<byte> Data1) YGroup2Zip(this IWVectorTraits128 athis, Vector128<byte> x, Vector128<byte> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vector128s.YGroup2Zip(Vector128{short}, Vector128{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> Data0, Vector128<short> Data1) YGroup2Zip(this IWVectorTraits128 athis, Vector128<short> x, Vector128<short> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vector128s.YGroup2Zip(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> Data0, Vector128<ushort> Data1) YGroup2Zip(this IWVectorTraits128 athis, Vector128<ushort> x, Vector128<ushort> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vector128s.YGroup2Zip(Vector128{int}, Vector128{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> Data0, Vector128<int> Data1) YGroup2Zip(this IWVectorTraits128 athis, Vector128<int> x, Vector128<int> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vector128s.YGroup2Zip(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> Data0, Vector128<uint> Data1) YGroup2Zip(this IWVectorTraits128 athis, Vector128<uint> x, Vector128<uint> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vector128s.YGroup2Zip(Vector128{long}, Vector128{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> Data0, Vector128<long> Data1) YGroup2Zip(this IWVectorTraits128 athis, Vector128<long> x, Vector128<long> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vector128s.YGroup2Zip(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> Data0, Vector128<ulong> Data1) YGroup2Zip(this IWVectorTraits128 athis, Vector128<ulong> x, Vector128<ulong> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vector128s.YGroup2Zip(Vector128{ExInt128}, Vector128{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ExInt128> Data0, Vector128<ExInt128> Data1) YGroup2Zip(this IWVectorTraits128 athis, Vector128<ExInt128> x, Vector128<ExInt128> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vector128s.YGroup2Zip(Vector128{ExUInt128}, Vector128{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ExUInt128> Data0, Vector128<ExUInt128> Data1) YGroup2Zip(this IWVectorTraits128 athis, Vector128<ExUInt128> x, Vector128<ExUInt128> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="Vector128s.YGroup2Zip(Vector128{Int128}, Vector128{Int128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<Int128> Data0, Vector128<Int128> Data1) YGroup2Zip(this IWVectorTraits128 athis, Vector128<Int128> x, Vector128<Int128> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="Vector128s.YGroup2Zip(Vector128{UInt128}, Vector128{UInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<UInt128> Data0, Vector128<UInt128> Data1) YGroup2Zip(this IWVectorTraits128 athis, Vector128<UInt128> x, Vector128<UInt128> y) {
            var data0 = athis.YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="Vector128s.YGroup2ZipHigh(Vector128{int}, Vector128{int})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static Vector128<T> YGroup2ZipHigh<T>(this IWVectorTraits128 athis, Vector128<T> x, Vector128<T> y) where T : struct {
            if (typeof(float) == typeof(T)) {
                return athis.YGroup2ZipHigh(x.As<T, float>(), y.As<T, float>()).As<float, T>();
            } else if (typeof(double) == typeof(T)) {
                return athis.YGroup2ZipHigh(x.As<T, double>(), y.As<T, double>()).As<double, T>();
            } else if (typeof(sbyte) == typeof(T)) {
                return athis.YGroup2ZipHigh(x.As<T, sbyte>(), y.As<T, sbyte>()).As<sbyte, T>();
            } else if (typeof(byte) == typeof(T)) {
                return athis.YGroup2ZipHigh(x.As<T, byte>(), y.As<T, byte>()).As<byte, T>();
            } else if (typeof(short) == typeof(T)) {
                return athis.YGroup2ZipHigh(x.As<T, short>(), y.As<T, short>()).As<short, T>();
            } else if (typeof(ushort) == typeof(T)) {
                return athis.YGroup2ZipHigh(x.As<T, ushort>(), y.As<T, ushort>()).As<ushort, T>();
            } else if (typeof(int) == typeof(T)) {
                return athis.YGroup2ZipHigh(x.As<T, int>(), y.As<T, int>()).As<int, T>();
            } else if (typeof(uint) == typeof(T)) {
                return athis.YGroup2ZipHigh(x.As<T, uint>(), y.As<T, uint>()).As<uint, T>();
            } else if (typeof(long) == typeof(T)) {
                return athis.YGroup2ZipHigh(x.As<T, long>(), y.As<T, long>()).As<long, T>();
            } else if (typeof(ulong) == typeof(T)) {
                return athis.YGroup2ZipHigh(x.As<T, ulong>(), y.As<T, ulong>()).As<ulong, T>();
            } else if (typeof(ExInt128) == typeof(T)) {
                return athis.YGroup2ZipHigh(x.ExAs<T, ExInt128>(), y.ExAs<T, ExInt128>()).ExAs<ExInt128, T>();
            } else if (typeof(ExUInt128) == typeof(T)) {
                return athis.YGroup2ZipHigh(x.ExAs<T, ExUInt128>(), y.ExAs<T, ExUInt128>()).ExAs<ExUInt128, T>();
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                return athis.YGroup2ZipHigh(x.ExAs<T, Int128>(), y.ExAs<T, Int128>()).ExAs<Int128, T>();
            } else if (typeof(UInt128) == typeof(T)) {
                return athis.YGroup2ZipHigh(x.ExAs<T, UInt128>(), y.ExAs<T, UInt128>()).ExAs<UInt128, T>();
#endif // BCL_TYPE_INT128
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="Vector128s.YGroup2ZipHigh(Vector128{ExInt128}, Vector128{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<Int128> YGroup2ZipHigh(this IWVectorTraits128 athis, Vector128<Int128> x, Vector128<Int128> y) {
            return athis.YGroup2ZipHigh(x.ExAsExInt128(), y.ExAsExInt128()).ExAsInt128();
        }

        /// <inheritdoc cref="Vector128s.YGroup2ZipHigh(Vector128{ExUInt128}, Vector128{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<UInt128> YGroup2ZipHigh(this IWVectorTraits128 athis, Vector128<UInt128> x, Vector128<UInt128> y) {
            return athis.YGroup2ZipHigh(x.ExAsExUInt128(), y.ExAsExUInt128()).ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="Vector128s.YGroup2ZipLow(Vector128{int}, Vector128{int})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static Vector128<T> YGroup2ZipLow<T>(this IWVectorTraits128 athis, Vector128<T> x, Vector128<T> y) where T : struct {
            if (typeof(float) == typeof(T)) {
                return athis.YGroup2ZipLow(x.As<T, float>(), y.As<T, float>()).As<float, T>();
            } else if (typeof(double) == typeof(T)) {
                return athis.YGroup2ZipLow(x.As<T, double>(), y.As<T, double>()).As<double, T>();
            } else if (typeof(sbyte) == typeof(T)) {
                return athis.YGroup2ZipLow(x.As<T, sbyte>(), y.As<T, sbyte>()).As<sbyte, T>();
            } else if (typeof(byte) == typeof(T)) {
                return athis.YGroup2ZipLow(x.As<T, byte>(), y.As<T, byte>()).As<byte, T>();
            } else if (typeof(short) == typeof(T)) {
                return athis.YGroup2ZipLow(x.As<T, short>(), y.As<T, short>()).As<short, T>();
            } else if (typeof(ushort) == typeof(T)) {
                return athis.YGroup2ZipLow(x.As<T, ushort>(), y.As<T, ushort>()).As<ushort, T>();
            } else if (typeof(int) == typeof(T)) {
                return athis.YGroup2ZipLow(x.As<T, int>(), y.As<T, int>()).As<int, T>();
            } else if (typeof(uint) == typeof(T)) {
                return athis.YGroup2ZipLow(x.As<T, uint>(), y.As<T, uint>()).As<uint, T>();
            } else if (typeof(long) == typeof(T)) {
                return athis.YGroup2ZipLow(x.As<T, long>(), y.As<T, long>()).As<long, T>();
            } else if (typeof(ulong) == typeof(T)) {
                return athis.YGroup2ZipLow(x.As<T, ulong>(), y.As<T, ulong>()).As<ulong, T>();
            } else if (typeof(ExInt128) == typeof(T)) {
                return athis.YGroup2ZipLow(x.ExAs<T, ExInt128>(), y.ExAs<T, ExInt128>()).ExAs<ExInt128, T>();
            } else if (typeof(ExUInt128) == typeof(T)) {
                return athis.YGroup2ZipLow(x.ExAs<T, ExUInt128>(), y.ExAs<T, ExUInt128>()).ExAs<ExUInt128, T>();
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                return athis.YGroup2ZipLow(x.ExAs<T, Int128>(), y.ExAs<T, Int128>()).ExAs<Int128, T>();
            } else if (typeof(UInt128) == typeof(T)) {
                return athis.YGroup2ZipLow(x.ExAs<T, UInt128>(), y.ExAs<T, UInt128>()).ExAs<UInt128, T>();
#endif // BCL_TYPE_INT128
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="Vector128s.YGroup2ZipLow(Vector128{ExInt128}, Vector128{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<Int128> YGroup2ZipLow(this IWVectorTraits128 athis, Vector128<Int128> x, Vector128<Int128> y) {
            return athis.YGroup2ZipLow(x.ExAsExInt128(), y.ExAsExInt128()).ExAsInt128();
        }

        /// <inheritdoc cref="Vector128s.YGroup2ZipLow(Vector128{ExUInt128}, Vector128{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<UInt128> YGroup2ZipLow(this IWVectorTraits128 athis, Vector128<UInt128> x, Vector128<UInt128> y) {
            return athis.YGroup2ZipLow(x.ExAsExUInt128(), y.ExAsExUInt128()).ExAsUInt128();
        }

#endif // BCL_TYPE_INT128


        /// <inheritdoc cref="Vector128s.YGroup3ToGroup4{T}(Vector128{T}, Vector128{T}, Vector128{T})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<T> Result0, Vector128<T> Result1, Vector128<T> Result2, Vector128<T> Result3) YGroup3ToGroup4<T>(this IWVectorTraits128 athis, Vector128<T> data0, Vector128<T> data1, Vector128<T> data2) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup3ToGroup4(data0.As<T, float>(), data1.As<T, float>(), data2.As<T, float>());
                return (rt0.As<float, T>(), rt1.As<float, T>(), rt2.As<float, T>(), rt3.As<float, T>());
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup3ToGroup4(data0.As<T, double>(), data1.As<T, double>(), data2.As<T, double>());
                return (rt0.As<double, T>(), rt1.As<double, T>(), rt2.As<double, T>(), rt3.As<double, T>());
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup3ToGroup4(data0.As<T, sbyte>(), data1.As<T, sbyte>(), data2.As<T, sbyte>());
                return (rt0.As<sbyte, T>(), rt1.As<sbyte, T>(), rt2.As<sbyte, T>(), rt3.As<sbyte, T>());
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup3ToGroup4(data0.As<T, byte>(), data1.As<T, byte>(), data2.As<T, byte>());
                return (rt0.As<byte, T>(), rt1.As<byte, T>(), rt2.As<byte, T>(), rt3.As<byte, T>());
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup3ToGroup4(data0.As<T, short>(), data1.As<T, short>(), data2.As<T, short>());
                return (rt0.As<short, T>(), rt1.As<short, T>(), rt2.As<short, T>(), rt3.As<short, T>());
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup3ToGroup4(data0.As<T, ushort>(), data1.As<T, ushort>(), data2.As<T, ushort>());
                return (rt0.As<ushort, T>(), rt1.As<ushort, T>(), rt2.As<ushort, T>(), rt3.As<ushort, T>());
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup3ToGroup4(data0.As<T, int>(), data1.As<T, int>(), data2.As<T, int>());
                return (rt0.As<int, T>(), rt1.As<int, T>(), rt2.As<int, T>(), rt3.As<int, T>());
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup3ToGroup4(data0.As<T, uint>(), data1.As<T, uint>(), data2.As<T, uint>());
                return (rt0.As<uint, T>(), rt1.As<uint, T>(), rt2.As<uint, T>(), rt3.As<uint, T>());
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup3ToGroup4(data0.As<T, long>(), data1.As<T, long>(), data2.As<T, long>());
                return (rt0.As<long, T>(), rt1.As<long, T>(), rt2.As<long, T>(), rt3.As<long, T>());
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup3ToGroup4(data0.As<T, ulong>(), data1.As<T, ulong>(), data2.As<T, ulong>());
                return (rt0.As<ulong, T>(), rt1.As<ulong, T>(), rt2.As<ulong, T>(), rt3.As<ulong, T>());
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.YGroup3ToGroup4(Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<float> Result0, Vector128<float> Result1, Vector128<float> Result2, Vector128<float> Result3) YGroup3ToGroup4(this IWVectorTraits128 athis, Vector128<float> data0, Vector128<float> data1, Vector128<float> data2) {
            var rt0 = athis.YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector128s.YGroup3ToGroup4(Vector128{double}, Vector128{double}, Vector128{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<double> Result0, Vector128<double> Result1, Vector128<double> Result2, Vector128<double> Result3) YGroup3ToGroup4(this IWVectorTraits128 athis, Vector128<double> data0, Vector128<double> data1, Vector128<double> data2) {
            var rt0 = athis.YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector128s.YGroup3ToGroup4(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> Result0, Vector128<sbyte> Result1, Vector128<sbyte> Result2, Vector128<sbyte> Result3) YGroup3ToGroup4(this IWVectorTraits128 athis, Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2) {
            var rt0 = athis.YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector128s.YGroup3ToGroup4(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> Result0, Vector128<byte> Result1, Vector128<byte> Result2, Vector128<byte> Result3) YGroup3ToGroup4(this IWVectorTraits128 athis, Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2) {
            var rt0 = athis.YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector128s.YGroup3ToGroup4(Vector128{short}, Vector128{short}, Vector128{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> Result0, Vector128<short> Result1, Vector128<short> Result2, Vector128<short> Result3) YGroup3ToGroup4(this IWVectorTraits128 athis, Vector128<short> data0, Vector128<short> data1, Vector128<short> data2) {
            var rt0 = athis.YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector128s.YGroup3ToGroup4(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> Result0, Vector128<ushort> Result1, Vector128<ushort> Result2, Vector128<ushort> Result3) YGroup3ToGroup4(this IWVectorTraits128 athis, Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2) {
            var rt0 = athis.YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector128s.YGroup3ToGroup4(Vector128{int}, Vector128{int}, Vector128{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> Result0, Vector128<int> Result1, Vector128<int> Result2, Vector128<int> Result3) YGroup3ToGroup4(this IWVectorTraits128 athis, Vector128<int> data0, Vector128<int> data1, Vector128<int> data2) {
            var rt0 = athis.YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector128s.YGroup3ToGroup4(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> Result0, Vector128<uint> Result1, Vector128<uint> Result2, Vector128<uint> Result3) YGroup3ToGroup4(this IWVectorTraits128 athis, Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2) {
            var rt0 = athis.YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector128s.YGroup3ToGroup4(Vector128{long}, Vector128{long}, Vector128{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> Result0, Vector128<long> Result1, Vector128<long> Result2, Vector128<long> Result3) YGroup3ToGroup4(this IWVectorTraits128 athis, Vector128<long> data0, Vector128<long> data1, Vector128<long> data2) {
            var rt0 = athis.YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector128s.YGroup3ToGroup4(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> Result0, Vector128<ulong> Result1, Vector128<ulong> Result2, Vector128<ulong> Result3) YGroup3ToGroup4(this IWVectorTraits128 athis, Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2) {
            var rt0 = athis.YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }


        /// <inheritdoc cref="Vector128s.YGroup3Unzip{T}(Vector128{T}, Vector128{T}, Vector128{T})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<T> X, Vector128<T> Y, Vector128<T> Z) YGroup3Unzip<T>(this IWVectorTraits128 athis, Vector128<T> data0, Vector128<T> data1, Vector128<T> data2) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Unzip(data0.As<T, float>(), data1.As<T, float>(), data2.As<T, float>());
                return (rt0.As<float, T>(), rt1.As<float, T>(), rt2.As<float, T>());
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Unzip(data0.As<T, double>(), data1.As<T, double>(), data2.As<T, double>());
                return (rt0.As<double, T>(), rt1.As<double, T>(), rt2.As<double, T>());
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Unzip(data0.As<T, sbyte>(), data1.As<T, sbyte>(), data2.As<T, sbyte>());
                return (rt0.As<sbyte, T>(), rt1.As<sbyte, T>(), rt2.As<sbyte, T>());
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Unzip(data0.As<T, byte>(), data1.As<T, byte>(), data2.As<T, byte>());
                return (rt0.As<byte, T>(), rt1.As<byte, T>(), rt2.As<byte, T>());
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Unzip(data0.As<T, short>(), data1.As<T, short>(), data2.As<T, short>());
                return (rt0.As<short, T>(), rt1.As<short, T>(), rt2.As<short, T>());
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Unzip(data0.As<T, ushort>(), data1.As<T, ushort>(), data2.As<T, ushort>());
                return (rt0.As<ushort, T>(), rt1.As<ushort, T>(), rt2.As<ushort, T>());
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Unzip(data0.As<T, int>(), data1.As<T, int>(), data2.As<T, int>());
                return (rt0.As<int, T>(), rt1.As<int, T>(), rt2.As<int, T>());
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Unzip(data0.As<T, uint>(), data1.As<T, uint>(), data2.As<T, uint>());
                return (rt0.As<uint, T>(), rt1.As<uint, T>(), rt2.As<uint, T>());
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Unzip(data0.As<T, long>(), data1.As<T, long>(), data2.As<T, long>());
                return (rt0.As<long, T>(), rt1.As<long, T>(), rt2.As<long, T>());
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Unzip(data0.As<T, ulong>(), data1.As<T, ulong>(), data2.As<T, ulong>());
                return (rt0.As<ulong, T>(), rt1.As<ulong, T>(), rt2.As<ulong, T>());
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.YGroup3Unzip(Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<float> X, Vector128<float> Y, Vector128<float> Z) YGroup3Unzip(this IWVectorTraits128 athis, Vector128<float> data0, Vector128<float> data1, Vector128<float> data2) {
            var rt0 = athis.YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector128s.YGroup3Unzip(Vector128{double}, Vector128{double}, Vector128{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<double> X, Vector128<double> Y, Vector128<double> Z) YGroup3Unzip(this IWVectorTraits128 athis, Vector128<double> data0, Vector128<double> data1, Vector128<double> data2) {
            var rt0 = athis.YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector128s.YGroup3Unzip(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> X, Vector128<sbyte> Y, Vector128<sbyte> Z) YGroup3Unzip(this IWVectorTraits128 athis, Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2) {
            var rt0 = athis.YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector128s.YGroup3Unzip(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> X, Vector128<byte> Y, Vector128<byte> Z) YGroup3Unzip(this IWVectorTraits128 athis, Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2) {
            var rt0 = athis.YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector128s.YGroup3Unzip(Vector128{short}, Vector128{short}, Vector128{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> X, Vector128<short> Y, Vector128<short> Z) YGroup3Unzip(this IWVectorTraits128 athis, Vector128<short> data0, Vector128<short> data1, Vector128<short> data2) {
            var rt0 = athis.YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector128s.YGroup3Unzip(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> X, Vector128<ushort> Y, Vector128<ushort> Z) YGroup3Unzip(this IWVectorTraits128 athis, Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2) {
            var rt0 = athis.YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector128s.YGroup3Unzip(Vector128{int}, Vector128{int}, Vector128{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> X, Vector128<int> Y, Vector128<int> Z) YGroup3Unzip(this IWVectorTraits128 athis, Vector128<int> data0, Vector128<int> data1, Vector128<int> data2) {
            var rt0 = athis.YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector128s.YGroup3Unzip(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> X, Vector128<uint> Y, Vector128<uint> Z) YGroup3Unzip(this IWVectorTraits128 athis, Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2) {
            var rt0 = athis.YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector128s.YGroup3Unzip(Vector128{long}, Vector128{long}, Vector128{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> X, Vector128<long> Y, Vector128<long> Z) YGroup3Unzip(this IWVectorTraits128 athis, Vector128<long> data0, Vector128<long> data1, Vector128<long> data2) {
            var rt0 = athis.YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector128s.YGroup3Unzip(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> X, Vector128<ulong> Y, Vector128<ulong> Z) YGroup3Unzip(this IWVectorTraits128 athis, Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2) {
            var rt0 = athis.YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }


        /// <inheritdoc cref="Vector128s.YGroup3UnzipX2{T}(Vector128{T}, Vector128{T}, Vector128{T}, Vector128{T}, Vector128{T}, Vector128{T})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<T> X, Vector128<T> XB, Vector128<T> Y, Vector128<T> YB, Vector128<T> Z, Vector128<T> ZB) YGroup3UnzipX2<T>(this IWVectorTraits128 athis, Vector128<T> data0, Vector128<T> data1, Vector128<T> data2, Vector128<T> data3, Vector128<T> data4, Vector128<T> data5) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3UnzipX2(data0.As<T, float>(), data1.As<T, float>(), data2.As<T, float>(), data3.As<T, float>(), data4.As<T, float>(), data5.As<T, float>());
                return (rt0.As<float, T>(), rt1.As<float, T>(), rt2.As<float, T>(), rt3.As<float, T>(), rt4.As<float, T>(), rt5.As<float, T>());
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3UnzipX2(data0.As<T, double>(), data1.As<T, double>(), data2.As<T, double>(), data3.As<T, double>(), data4.As<T, double>(), data5.As<T, double>());
                return (rt0.As<double, T>(), rt1.As<double, T>(), rt2.As<double, T>(), rt3.As<double, T>(), rt4.As<double, T>(), rt5.As<double, T>());
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3UnzipX2(data0.As<T, sbyte>(), data1.As<T, sbyte>(), data2.As<T, sbyte>(), data3.As<T, sbyte>(), data4.As<T, sbyte>(), data5.As<T, sbyte>());
                return (rt0.As<sbyte, T>(), rt1.As<sbyte, T>(), rt2.As<sbyte, T>(), rt3.As<sbyte, T>(), rt4.As<sbyte, T>(), rt5.As<sbyte, T>());
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3UnzipX2(data0.As<T, byte>(), data1.As<T, byte>(), data2.As<T, byte>(), data3.As<T, byte>(), data4.As<T, byte>(), data5.As<T, byte>());
                return (rt0.As<byte, T>(), rt1.As<byte, T>(), rt2.As<byte, T>(), rt3.As<byte, T>(), rt4.As<byte, T>(), rt5.As<byte, T>());
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3UnzipX2(data0.As<T, short>(), data1.As<T, short>(), data2.As<T, short>(), data3.As<T, short>(), data4.As<T, short>(), data5.As<T, short>());
                return (rt0.As<short, T>(), rt1.As<short, T>(), rt2.As<short, T>(), rt3.As<short, T>(), rt4.As<short, T>(), rt5.As<short, T>());
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3UnzipX2(data0.As<T, ushort>(), data1.As<T, ushort>(), data2.As<T, ushort>(), data3.As<T, ushort>(), data4.As<T, ushort>(), data5.As<T, ushort>());
                return (rt0.As<ushort, T>(), rt1.As<ushort, T>(), rt2.As<ushort, T>(), rt3.As<ushort, T>(), rt4.As<ushort, T>(), rt5.As<ushort, T>());
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3UnzipX2(data0.As<T, int>(), data1.As<T, int>(), data2.As<T, int>(), data3.As<T, int>(), data4.As<T, int>(), data5.As<T, int>());
                return (rt0.As<int, T>(), rt1.As<int, T>(), rt2.As<int, T>(), rt3.As<int, T>(), rt4.As<int, T>(), rt5.As<int, T>());
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3UnzipX2(data0.As<T, uint>(), data1.As<T, uint>(), data2.As<T, uint>(), data3.As<T, uint>(), data4.As<T, uint>(), data5.As<T, uint>());
                return (rt0.As<uint, T>(), rt1.As<uint, T>(), rt2.As<uint, T>(), rt3.As<uint, T>(), rt4.As<uint, T>(), rt5.As<uint, T>());
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3UnzipX2(data0.As<T, long>(), data1.As<T, long>(), data2.As<T, long>(), data3.As<T, long>(), data4.As<T, long>(), data5.As<T, long>());
                return (rt0.As<long, T>(), rt1.As<long, T>(), rt2.As<long, T>(), rt3.As<long, T>(), rt4.As<long, T>(), rt5.As<long, T>());
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3UnzipX2(data0.As<T, ulong>(), data1.As<T, ulong>(), data2.As<T, ulong>(), data3.As<T, ulong>(), data4.As<T, ulong>(), data5.As<T, ulong>());
                return (rt0.As<ulong, T>(), rt1.As<ulong, T>(), rt2.As<ulong, T>(), rt3.As<ulong, T>(), rt4.As<ulong, T>(), rt5.As<ulong, T>());
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.YGroup3UnzipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<float> X, Vector128<float> XB, Vector128<float> Y, Vector128<float> YB, Vector128<float> Z, Vector128<float> ZB) YGroup3UnzipX2(this IWVectorTraits128 athis, Vector128<float> data0, Vector128<float> data1, Vector128<float> data2, Vector128<float> data3, Vector128<float> data4, Vector128<float> data5) {
            var rt0 = athis.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="Vector128s.YGroup3UnzipX2(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<double> X, Vector128<double> XB, Vector128<double> Y, Vector128<double> YB, Vector128<double> Z, Vector128<double> ZB) YGroup3UnzipX2(this IWVectorTraits128 athis, Vector128<double> data0, Vector128<double> data1, Vector128<double> data2, Vector128<double> data3, Vector128<double> data4, Vector128<double> data5) {
            var rt0 = athis.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="Vector128s.YGroup3UnzipX2(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> X, Vector128<sbyte> XB, Vector128<sbyte> Y, Vector128<sbyte> YB, Vector128<sbyte> Z, Vector128<sbyte> ZB) YGroup3UnzipX2(this IWVectorTraits128 athis, Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2, Vector128<sbyte> data3, Vector128<sbyte> data4, Vector128<sbyte> data5) {
            var rt0 = athis.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="Vector128s.YGroup3UnzipX2(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> X, Vector128<byte> XB, Vector128<byte> Y, Vector128<byte> YB, Vector128<byte> Z, Vector128<byte> ZB) YGroup3UnzipX2(this IWVectorTraits128 athis, Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2, Vector128<byte> data3, Vector128<byte> data4, Vector128<byte> data5) {
            var rt0 = athis.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="Vector128s.YGroup3UnzipX2(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> X, Vector128<short> XB, Vector128<short> Y, Vector128<short> YB, Vector128<short> Z, Vector128<short> ZB) YGroup3UnzipX2(this IWVectorTraits128 athis, Vector128<short> data0, Vector128<short> data1, Vector128<short> data2, Vector128<short> data3, Vector128<short> data4, Vector128<short> data5) {
            var rt0 = athis.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="Vector128s.YGroup3UnzipX2(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> X, Vector128<ushort> XB, Vector128<ushort> Y, Vector128<ushort> YB, Vector128<ushort> Z, Vector128<ushort> ZB) YGroup3UnzipX2(this IWVectorTraits128 athis, Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2, Vector128<ushort> data3, Vector128<ushort> data4, Vector128<ushort> data5) {
            var rt0 = athis.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="Vector128s.YGroup3UnzipX2(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> X, Vector128<int> XB, Vector128<int> Y, Vector128<int> YB, Vector128<int> Z, Vector128<int> ZB) YGroup3UnzipX2(this IWVectorTraits128 athis, Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, Vector128<int> data3, Vector128<int> data4, Vector128<int> data5) {
            var rt0 = athis.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="Vector128s.YGroup3UnzipX2(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> X, Vector128<uint> XB, Vector128<uint> Y, Vector128<uint> YB, Vector128<uint> Z, Vector128<uint> ZB) YGroup3UnzipX2(this IWVectorTraits128 athis, Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, Vector128<uint> data3, Vector128<uint> data4, Vector128<uint> data5) {
            var rt0 = athis.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="Vector128s.YGroup3UnzipX2(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> X, Vector128<long> XB, Vector128<long> Y, Vector128<long> YB, Vector128<long> Z, Vector128<long> ZB) YGroup3UnzipX2(this IWVectorTraits128 athis, Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, Vector128<long> data3, Vector128<long> data4, Vector128<long> data5) {
            var rt0 = athis.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="Vector128s.YGroup3UnzipX2(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> X, Vector128<ulong> XB, Vector128<ulong> Y, Vector128<ulong> YB, Vector128<ulong> Z, Vector128<ulong> ZB) YGroup3UnzipX2(this IWVectorTraits128 athis, Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, Vector128<ulong> data3, Vector128<ulong> data4, Vector128<ulong> data5) {
            var rt0 = athis.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }


        /// <inheritdoc cref="Vector128s.YGroup3Zip{T}(Vector128{T}, Vector128{T}, Vector128{T})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<T> Data0, Vector128<T> Data1, Vector128<T> Data2) YGroup3Zip<T>(this IWVectorTraits128 athis, Vector128<T> x, Vector128<T> y, Vector128<T> z) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Zip(x.As<T, float>(), y.As<T, float>(), z.As<T, float>());
                return (rt0.As<float, T>(), rt1.As<float, T>(), rt2.As<float, T>());
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Zip(x.As<T, double>(), y.As<T, double>(), z.As<T, double>());
                return (rt0.As<double, T>(), rt1.As<double, T>(), rt2.As<double, T>());
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Zip(x.As<T, sbyte>(), y.As<T, sbyte>(), z.As<T, sbyte>());
                return (rt0.As<sbyte, T>(), rt1.As<sbyte, T>(), rt2.As<sbyte, T>());
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Zip(x.As<T, byte>(), y.As<T, byte>(), z.As<T, byte>());
                return (rt0.As<byte, T>(), rt1.As<byte, T>(), rt2.As<byte, T>());
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Zip(x.As<T, short>(), y.As<T, short>(), z.As<T, short>());
                return (rt0.As<short, T>(), rt1.As<short, T>(), rt2.As<short, T>());
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Zip(x.As<T, ushort>(), y.As<T, ushort>(), z.As<T, ushort>());
                return (rt0.As<ushort, T>(), rt1.As<ushort, T>(), rt2.As<ushort, T>());
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Zip(x.As<T, int>(), y.As<T, int>(), z.As<T, int>());
                return (rt0.As<int, T>(), rt1.As<int, T>(), rt2.As<int, T>());
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Zip(x.As<T, uint>(), y.As<T, uint>(), z.As<T, uint>());
                return (rt0.As<uint, T>(), rt1.As<uint, T>(), rt2.As<uint, T>());
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Zip(x.As<T, long>(), y.As<T, long>(), z.As<T, long>());
                return (rt0.As<long, T>(), rt1.As<long, T>(), rt2.As<long, T>());
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2) = athis.YGroup3Zip(x.As<T, ulong>(), y.As<T, ulong>(), z.As<T, ulong>());
                return (rt0.As<ulong, T>(), rt1.As<ulong, T>(), rt2.As<ulong, T>());
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.YGroup3Zip(Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<float> Data0, Vector128<float> Data1, Vector128<float> Data2) YGroup3Zip(this IWVectorTraits128 athis, Vector128<float> x, Vector128<float> y, Vector128<float> z) {
            var data0 = athis.YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="Vector128s.YGroup3Zip(Vector128{double}, Vector128{double}, Vector128{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<double> Data0, Vector128<double> Data1, Vector128<double> Data2) YGroup3Zip(this IWVectorTraits128 athis, Vector128<double> x, Vector128<double> y, Vector128<double> z) {
            var data0 = athis.YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="Vector128s.YGroup3Zip(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> Data0, Vector128<sbyte> Data1, Vector128<sbyte> Data2) YGroup3Zip(this IWVectorTraits128 athis, Vector128<sbyte> x, Vector128<sbyte> y, Vector128<sbyte> z) {
            var data0 = athis.YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="Vector128s.YGroup3Zip(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> Data0, Vector128<byte> Data1, Vector128<byte> Data2) YGroup3Zip(this IWVectorTraits128 athis, Vector128<byte> x, Vector128<byte> y, Vector128<byte> z) {
            var data0 = athis.YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="Vector128s.YGroup3Zip(Vector128{short}, Vector128{short}, Vector128{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> Data0, Vector128<short> Data1, Vector128<short> Data2) YGroup3Zip(this IWVectorTraits128 athis, Vector128<short> x, Vector128<short> y, Vector128<short> z) {
            var data0 = athis.YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="Vector128s.YGroup3Zip(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> Data0, Vector128<ushort> Data1, Vector128<ushort> Data2) YGroup3Zip(this IWVectorTraits128 athis, Vector128<ushort> x, Vector128<ushort> y, Vector128<ushort> z) {
            var data0 = athis.YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="Vector128s.YGroup3Zip(Vector128{int}, Vector128{int}, Vector128{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> Data0, Vector128<int> Data1, Vector128<int> Data2) YGroup3Zip(this IWVectorTraits128 athis, Vector128<int> x, Vector128<int> y, Vector128<int> z) {
            var data0 = athis.YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="Vector128s.YGroup3Zip(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> Data0, Vector128<uint> Data1, Vector128<uint> Data2) YGroup3Zip(this IWVectorTraits128 athis, Vector128<uint> x, Vector128<uint> y, Vector128<uint> z) {
            var data0 = athis.YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="Vector128s.YGroup3Zip(Vector128{long}, Vector128{long}, Vector128{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> Data0, Vector128<long> Data1, Vector128<long> Data2) YGroup3Zip(this IWVectorTraits128 athis, Vector128<long> x, Vector128<long> y, Vector128<long> z) {
            var data0 = athis.YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="Vector128s.YGroup3Zip(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> Data0, Vector128<ulong> Data1, Vector128<ulong> Data2) YGroup3Zip(this IWVectorTraits128 athis, Vector128<ulong> x, Vector128<ulong> y, Vector128<ulong> z) {
            var data0 = athis.YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }


        /// <inheritdoc cref="Vector128s.YGroup3ZipX2{T}(Vector128{T}, Vector128{T}, Vector128{T}, Vector128{T}, Vector128{T}, Vector128{T})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<T> Data0, Vector128<T> Data1, Vector128<T> Data2, Vector128<T> Data3, Vector128<T> Data4, Vector128<T> Data5) YGroup3ZipX2<T>(this IWVectorTraits128 athis, Vector128<T> x, Vector128<T> xB, Vector128<T> y, Vector128<T> yB, Vector128<T> z, Vector128<T> zB) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3ZipX2(x.As<T, float>(), xB.As<T, float>(), y.As<T, float>(), yB.As<T, float>(), z.As<T, float>(), zB.As<T, float>());
                return (rt0.As<float, T>(), rt1.As<float, T>(), rt2.As<float, T>(), rt3.As<float, T>(), rt4.As<float, T>(), rt5.As<float, T>());
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3ZipX2(x.As<T, double>(), xB.As<T, double>(), y.As<T, double>(), yB.As<T, double>(), z.As<T, double>(), zB.As<T, double>());
                return (rt0.As<double, T>(), rt1.As<double, T>(), rt2.As<double, T>(), rt3.As<double, T>(), rt4.As<double, T>(), rt5.As<double, T>());
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3ZipX2(x.As<T, sbyte>(), xB.As<T, sbyte>(), y.As<T, sbyte>(), yB.As<T, sbyte>(), z.As<T, sbyte>(), zB.As<T, sbyte>());
                return (rt0.As<sbyte, T>(), rt1.As<sbyte, T>(), rt2.As<sbyte, T>(), rt3.As<sbyte, T>(), rt4.As<sbyte, T>(), rt5.As<sbyte, T>());
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3ZipX2(x.As<T, byte>(), xB.As<T, byte>(), y.As<T, byte>(), yB.As<T, byte>(), z.As<T, byte>(), zB.As<T, byte>());
                return (rt0.As<byte, T>(), rt1.As<byte, T>(), rt2.As<byte, T>(), rt3.As<byte, T>(), rt4.As<byte, T>(), rt5.As<byte, T>());
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3ZipX2(x.As<T, short>(), xB.As<T, short>(), y.As<T, short>(), yB.As<T, short>(), z.As<T, short>(), zB.As<T, short>());
                return (rt0.As<short, T>(), rt1.As<short, T>(), rt2.As<short, T>(), rt3.As<short, T>(), rt4.As<short, T>(), rt5.As<short, T>());
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3ZipX2(x.As<T, ushort>(), xB.As<T, ushort>(), y.As<T, ushort>(), yB.As<T, ushort>(), z.As<T, ushort>(), zB.As<T, ushort>());
                return (rt0.As<ushort, T>(), rt1.As<ushort, T>(), rt2.As<ushort, T>(), rt3.As<ushort, T>(), rt4.As<ushort, T>(), rt5.As<ushort, T>());
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3ZipX2(x.As<T, int>(), xB.As<T, int>(), y.As<T, int>(), yB.As<T, int>(), z.As<T, int>(), zB.As<T, int>());
                return (rt0.As<int, T>(), rt1.As<int, T>(), rt2.As<int, T>(), rt3.As<int, T>(), rt4.As<int, T>(), rt5.As<int, T>());
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3ZipX2(x.As<T, uint>(), xB.As<T, uint>(), y.As<T, uint>(), yB.As<T, uint>(), z.As<T, uint>(), zB.As<T, uint>());
                return (rt0.As<uint, T>(), rt1.As<uint, T>(), rt2.As<uint, T>(), rt3.As<uint, T>(), rt4.As<uint, T>(), rt5.As<uint, T>());
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3ZipX2(x.As<T, long>(), xB.As<T, long>(), y.As<T, long>(), yB.As<T, long>(), z.As<T, long>(), zB.As<T, long>());
                return (rt0.As<long, T>(), rt1.As<long, T>(), rt2.As<long, T>(), rt3.As<long, T>(), rt4.As<long, T>(), rt5.As<long, T>());
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = athis.YGroup3ZipX2(x.As<T, ulong>(), xB.As<T, ulong>(), y.As<T, ulong>(), yB.As<T, ulong>(), z.As<T, ulong>(), zB.As<T, ulong>());
                return (rt0.As<ulong, T>(), rt1.As<ulong, T>(), rt2.As<ulong, T>(), rt3.As<ulong, T>(), rt4.As<ulong, T>(), rt5.As<ulong, T>());
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.YGroup3ZipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<float> Data0, Vector128<float> Data1, Vector128<float> Data2, Vector128<float> Data3, Vector128<float> Data4, Vector128<float> Data5) YGroup3ZipX2(this IWVectorTraits128 athis, Vector128<float> x, Vector128<float> xB, Vector128<float> y, Vector128<float> yB, Vector128<float> z, Vector128<float> zB) {
            var data0 = athis.YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="Vector128s.YGroup3ZipX2(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<double> Data0, Vector128<double> Data1, Vector128<double> Data2, Vector128<double> Data3, Vector128<double> Data4, Vector128<double> Data5) YGroup3ZipX2(this IWVectorTraits128 athis, Vector128<double> x, Vector128<double> xB, Vector128<double> y, Vector128<double> yB, Vector128<double> z, Vector128<double> zB) {
            var data0 = athis.YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="Vector128s.YGroup3ZipX2(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> Data0, Vector128<sbyte> Data1, Vector128<sbyte> Data2, Vector128<sbyte> Data3, Vector128<sbyte> Data4, Vector128<sbyte> Data5) YGroup3ZipX2(this IWVectorTraits128 athis, Vector128<sbyte> x, Vector128<sbyte> xB, Vector128<sbyte> y, Vector128<sbyte> yB, Vector128<sbyte> z, Vector128<sbyte> zB) {
            var data0 = athis.YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="Vector128s.YGroup3ZipX2(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> Data0, Vector128<byte> Data1, Vector128<byte> Data2, Vector128<byte> Data3, Vector128<byte> Data4, Vector128<byte> Data5) YGroup3ZipX2(this IWVectorTraits128 athis, Vector128<byte> x, Vector128<byte> xB, Vector128<byte> y, Vector128<byte> yB, Vector128<byte> z, Vector128<byte> zB) {
            var data0 = athis.YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="Vector128s.YGroup3ZipX2(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> Data0, Vector128<short> Data1, Vector128<short> Data2, Vector128<short> Data3, Vector128<short> Data4, Vector128<short> Data5) YGroup3ZipX2(this IWVectorTraits128 athis, Vector128<short> x, Vector128<short> xB, Vector128<short> y, Vector128<short> yB, Vector128<short> z, Vector128<short> zB) {
            var data0 = athis.YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="Vector128s.YGroup3ZipX2(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> Data0, Vector128<ushort> Data1, Vector128<ushort> Data2, Vector128<ushort> Data3, Vector128<ushort> Data4, Vector128<ushort> Data5) YGroup3ZipX2(this IWVectorTraits128 athis, Vector128<ushort> x, Vector128<ushort> xB, Vector128<ushort> y, Vector128<ushort> yB, Vector128<ushort> z, Vector128<ushort> zB) {
            var data0 = athis.YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="Vector128s.YGroup3ZipX2(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> Data0, Vector128<int> Data1, Vector128<int> Data2, Vector128<int> Data3, Vector128<int> Data4, Vector128<int> Data5) YGroup3ZipX2(this IWVectorTraits128 athis, Vector128<int> x, Vector128<int> xB, Vector128<int> y, Vector128<int> yB, Vector128<int> z, Vector128<int> zB) {
            var data0 = athis.YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="Vector128s.YGroup3ZipX2(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> Data0, Vector128<uint> Data1, Vector128<uint> Data2, Vector128<uint> Data3, Vector128<uint> Data4, Vector128<uint> Data5) YGroup3ZipX2(this IWVectorTraits128 athis, Vector128<uint> x, Vector128<uint> xB, Vector128<uint> y, Vector128<uint> yB, Vector128<uint> z, Vector128<uint> zB) {
            var data0 = athis.YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="Vector128s.YGroup3ZipX2(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> Data0, Vector128<long> Data1, Vector128<long> Data2, Vector128<long> Data3, Vector128<long> Data4, Vector128<long> Data5) YGroup3ZipX2(this IWVectorTraits128 athis, Vector128<long> x, Vector128<long> xB, Vector128<long> y, Vector128<long> yB, Vector128<long> z, Vector128<long> zB) {
            var data0 = athis.YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="Vector128s.YGroup3ZipX2(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> Data0, Vector128<ulong> Data1, Vector128<ulong> Data2, Vector128<ulong> Data3, Vector128<ulong> Data4, Vector128<ulong> Data5) YGroup3ZipX2(this IWVectorTraits128 athis, Vector128<ulong> x, Vector128<ulong> xB, Vector128<ulong> y, Vector128<ulong> yB, Vector128<ulong> z, Vector128<ulong> zB) {
            var data0 = athis.YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }


        /// <inheritdoc cref="Vector128s.YGroup4ToGroup3{T}(Vector128{T}, Vector128{T}, Vector128{T}, Vector128{T})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<T> Result0, Vector128<T> Result1, Vector128<T> Result2) YGroup4ToGroup3<T>(this IWVectorTraits128 athis, Vector128<T> data0, Vector128<T> data1, Vector128<T> data2, Vector128<T> data3) where T : struct {
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

        /// <inheritdoc cref="Vector128s.YGroup4ToGroup3(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<float> Result0, Vector128<float> Result1, Vector128<float> Result2) YGroup4ToGroup3(this IWVectorTraits128 athis, Vector128<float> data0, Vector128<float> data1, Vector128<float> data2, Vector128<float> data3) {
            var rt0 = athis.YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector128s.YGroup4ToGroup3(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<double> Result0, Vector128<double> Result1, Vector128<double> Result2) YGroup4ToGroup3(this IWVectorTraits128 athis, Vector128<double> data0, Vector128<double> data1, Vector128<double> data2, Vector128<double> data3) {
            var rt0 = athis.YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector128s.YGroup4ToGroup3(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> Result0, Vector128<sbyte> Result1, Vector128<sbyte> Result2) YGroup4ToGroup3(this IWVectorTraits128 athis, Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2, Vector128<sbyte> data3) {
            var rt0 = athis.YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector128s.YGroup4ToGroup3(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> Result0, Vector128<byte> Result1, Vector128<byte> Result2) YGroup4ToGroup3(this IWVectorTraits128 athis, Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2, Vector128<byte> data3) {
            var rt0 = athis.YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector128s.YGroup4ToGroup3(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> Result0, Vector128<short> Result1, Vector128<short> Result2) YGroup4ToGroup3(this IWVectorTraits128 athis, Vector128<short> data0, Vector128<short> data1, Vector128<short> data2, Vector128<short> data3) {
            var rt0 = athis.YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector128s.YGroup4ToGroup3(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> Result0, Vector128<ushort> Result1, Vector128<ushort> Result2) YGroup4ToGroup3(this IWVectorTraits128 athis, Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2, Vector128<ushort> data3) {
            var rt0 = athis.YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector128s.YGroup4ToGroup3(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> Result0, Vector128<int> Result1, Vector128<int> Result2) YGroup4ToGroup3(this IWVectorTraits128 athis, Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, Vector128<int> data3) {
            var rt0 = athis.YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector128s.YGroup4ToGroup3(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> Result0, Vector128<uint> Result1, Vector128<uint> Result2) YGroup4ToGroup3(this IWVectorTraits128 athis, Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, Vector128<uint> data3) {
            var rt0 = athis.YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector128s.YGroup4ToGroup3(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> Result0, Vector128<long> Result1, Vector128<long> Result2) YGroup4ToGroup3(this IWVectorTraits128 athis, Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, Vector128<long> data3) {
            var rt0 = athis.YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="Vector128s.YGroup4ToGroup3(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> Result0, Vector128<ulong> Result1, Vector128<ulong> Result2) YGroup4ToGroup3(this IWVectorTraits128 athis, Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, Vector128<ulong> data3) {
            var rt0 = athis.YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }


#if BCL_TYPE_INT128

        /// <inheritdoc cref="Vector128s.YGroup4Unzip(Vector128{ExInt128}, Vector128{ExInt128}, Vector128{ExInt128}, Vector128{ExInt128}, out Vector128{ExInt128}, out Vector128{ExInt128}, out Vector128{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<Int128> YGroup4Unzip(this IWVectorTraits128 athis, Vector128<Int128> data0, Vector128<Int128> data1, Vector128<Int128> data2, Vector128<Int128> data3, out Vector128<Int128> y, out Vector128<Int128> z, out Vector128<Int128> w) {
            var d0 = athis.YGroup4Unzip(data0.ExAsExInt128(), data1.ExAsExInt128(), data2.ExAsExInt128(), data3.ExAsExInt128(), out var d1, out var d2, out var d3);
            y = d1.ExAsInt128();
            z = d2.ExAsInt128();
            w = d3.ExAsInt128();
            return d0.ExAsInt128();
        }

        /// <inheritdoc cref="Vector128s.YGroup4Unzip(Vector128{ExUInt128}, Vector128{ExUInt128}, Vector128{ExUInt128}, Vector128{ExUInt128}, out Vector128{ExUInt128}, out Vector128{ExUInt128}, out Vector128{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<UInt128> YGroup4Unzip(this IWVectorTraits128 athis, Vector128<UInt128> data0, Vector128<UInt128> data1, Vector128<UInt128> data2, Vector128<UInt128> data3, out Vector128<UInt128> y, out Vector128<UInt128> z, out Vector128<UInt128> w) {
            var d0 = athis.YGroup4Unzip(data0.ExAsExUInt128(), data1.ExAsExUInt128(), data2.ExAsExUInt128(), data3.ExAsExUInt128(), out var d1, out var d2, out var d3);
            y = d1.ExAsUInt128();
            z = d2.ExAsUInt128();
            w = d3.ExAsUInt128();
            return d0.ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="Vector128s.YGroup4Unzip{T}(Vector128{T}, Vector128{T}, Vector128{T}, Vector128{T})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<T> X, Vector128<T> Y, Vector128<T> Z, Vector128<T> W) YGroup4Unzip<T>(this IWVectorTraits128 athis, Vector128<T> data0, Vector128<T> data1, Vector128<T> data2, Vector128<T> data3) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip(data0.As<T, float>(), data1.As<T, float>(), data2.As<T, float>(), data3.As<T, float>());
                return (rt0.As<float, T>(), rt1.As<float, T>(), rt2.As<float, T>(), rt3.As<float, T>());
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip(data0.As<T, double>(), data1.As<T, double>(), data2.As<T, double>(), data3.As<T, double>());
                return (rt0.As<double, T>(), rt1.As<double, T>(), rt2.As<double, T>(), rt3.As<double, T>());
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip(data0.As<T, sbyte>(), data1.As<T, sbyte>(), data2.As<T, sbyte>(), data3.As<T, sbyte>());
                return (rt0.As<sbyte, T>(), rt1.As<sbyte, T>(), rt2.As<sbyte, T>(), rt3.As<sbyte, T>());
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip(data0.As<T, byte>(), data1.As<T, byte>(), data2.As<T, byte>(), data3.As<T, byte>());
                return (rt0.As<byte, T>(), rt1.As<byte, T>(), rt2.As<byte, T>(), rt3.As<byte, T>());
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip(data0.As<T, short>(), data1.As<T, short>(), data2.As<T, short>(), data3.As<T, short>());
                return (rt0.As<short, T>(), rt1.As<short, T>(), rt2.As<short, T>(), rt3.As<short, T>());
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip(data0.As<T, ushort>(), data1.As<T, ushort>(), data2.As<T, ushort>(), data3.As<T, ushort>());
                return (rt0.As<ushort, T>(), rt1.As<ushort, T>(), rt2.As<ushort, T>(), rt3.As<ushort, T>());
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip(data0.As<T, int>(), data1.As<T, int>(), data2.As<T, int>(), data3.As<T, int>());
                return (rt0.As<int, T>(), rt1.As<int, T>(), rt2.As<int, T>(), rt3.As<int, T>());
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip(data0.As<T, uint>(), data1.As<T, uint>(), data2.As<T, uint>(), data3.As<T, uint>());
                return (rt0.As<uint, T>(), rt1.As<uint, T>(), rt2.As<uint, T>(), rt3.As<uint, T>());
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip(data0.As<T, long>(), data1.As<T, long>(), data2.As<T, long>(), data3.As<T, long>());
                return (rt0.As<long, T>(), rt1.As<long, T>(), rt2.As<long, T>(), rt3.As<long, T>());
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip(data0.As<T, ulong>(), data1.As<T, ulong>(), data2.As<T, ulong>(), data3.As<T, ulong>());
                return (rt0.As<ulong, T>(), rt1.As<ulong, T>(), rt2.As<ulong, T>(), rt3.As<ulong, T>());
            } else if (typeof(ExInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip(data0.ExAs<T, ExInt128>(), data1.ExAs<T, ExInt128>(), data2.ExAs<T, ExInt128>(), data3.ExAs<T, ExInt128>());
                return (rt0.ExAs<ExInt128, T>(), rt1.ExAs<ExInt128, T>(), rt2.ExAs<ExInt128, T>(), rt3.ExAs<ExInt128, T>());
            } else if (typeof(ExUInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip(data0.ExAs<T, ExUInt128>(), data1.ExAs<T, ExUInt128>(), data2.ExAs<T, ExUInt128>(), data3.ExAs<T, ExUInt128>());
                return (rt0.ExAs<ExUInt128, T>(), rt1.ExAs<ExUInt128, T>(), rt2.ExAs<ExUInt128, T>(), rt3.ExAs<ExUInt128, T>());
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip(data0.ExAs<T, Int128>(), data1.ExAs<T, Int128>(), data2.ExAs<T, Int128>(), data3.ExAs<T, Int128>());
                return (rt0.ExAs<Int128, T>(), rt1.ExAs<Int128, T>(), rt2.ExAs<Int128, T>(), rt3.ExAs<Int128, T>());
            } else if (typeof(UInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Unzip(data0.ExAs<T, UInt128>(), data1.ExAs<T, UInt128>(), data2.ExAs<T, UInt128>(), data3.ExAs<T, UInt128>());
                return (rt0.ExAs<UInt128, T>(), rt1.ExAs<UInt128, T>(), rt2.ExAs<UInt128, T>(), rt3.ExAs<UInt128, T>());
#endif // BCL_TYPE_INT128
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.YGroup4Unzip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<float> X, Vector128<float> Y, Vector128<float> Z, Vector128<float> W) YGroup4Unzip(this IWVectorTraits128 athis, Vector128<float> data0, Vector128<float> data1, Vector128<float> data2, Vector128<float> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }


        /// <inheritdoc cref="Vector128s.YGroup4Unzip(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<double> X, Vector128<double> Y, Vector128<double> Z, Vector128<double> W) YGroup4Unzip(this IWVectorTraits128 athis, Vector128<double> data0, Vector128<double> data1, Vector128<double> data2, Vector128<double> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector128s.YGroup4Unzip(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> X, Vector128<sbyte> Y, Vector128<sbyte> Z, Vector128<sbyte> W) YGroup4Unzip(this IWVectorTraits128 athis, Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2, Vector128<sbyte> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector128s.YGroup4Unzip(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> X, Vector128<byte> Y, Vector128<byte> Z, Vector128<byte> W) YGroup4Unzip(this IWVectorTraits128 athis, Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2, Vector128<byte> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector128s.YGroup4Unzip(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> X, Vector128<short> Y, Vector128<short> Z, Vector128<short> W) YGroup4Unzip(this IWVectorTraits128 athis, Vector128<short> data0, Vector128<short> data1, Vector128<short> data2, Vector128<short> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector128s.YGroup4Unzip(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> X, Vector128<ushort> Y, Vector128<ushort> Z, Vector128<ushort> W) YGroup4Unzip(this IWVectorTraits128 athis, Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2, Vector128<ushort> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector128s.YGroup4Unzip(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> X, Vector128<int> Y, Vector128<int> Z, Vector128<int> W) YGroup4Unzip(this IWVectorTraits128 athis, Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, Vector128<int> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector128s.YGroup4Unzip(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> X, Vector128<uint> Y, Vector128<uint> Z, Vector128<uint> W) YGroup4Unzip(this IWVectorTraits128 athis, Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, Vector128<uint> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector128s.YGroup4Unzip(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> X, Vector128<long> Y, Vector128<long> Z, Vector128<long> W) YGroup4Unzip(this IWVectorTraits128 athis, Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, Vector128<long> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector128s.YGroup4Unzip(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> X, Vector128<ulong> Y, Vector128<ulong> Z, Vector128<ulong> W) YGroup4Unzip(this IWVectorTraits128 athis, Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, Vector128<ulong> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector128s.YGroup4Unzip(Vector128{ExInt128}, Vector128{ExInt128}, Vector128{ExInt128}, Vector128{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ExInt128> X, Vector128<ExInt128> Y, Vector128<ExInt128> Z, Vector128<ExInt128> W) YGroup4Unzip(this IWVectorTraits128 athis, Vector128<ExInt128> data0, Vector128<ExInt128> data1, Vector128<ExInt128> data2, Vector128<ExInt128> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector128s.YGroup4Unzip(Vector128{ExUInt128}, Vector128{ExUInt128}, Vector128{ExUInt128}, Vector128{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ExUInt128> X, Vector128<ExUInt128> Y, Vector128<ExUInt128> Z, Vector128<ExUInt128> W) YGroup4Unzip(this IWVectorTraits128 athis, Vector128<ExUInt128> data0, Vector128<ExUInt128> data1, Vector128<ExUInt128> data2, Vector128<ExUInt128> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="Vector128s.YGroup4Unzip(Vector128{Int128}, Vector128{Int128}, Vector128{Int128}, Vector128{Int128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<Int128> X, Vector128<Int128> Y, Vector128<Int128> Z, Vector128<Int128> W) YGroup4Unzip(this IWVectorTraits128 athis, Vector128<Int128> data0, Vector128<Int128> data1, Vector128<Int128> data2, Vector128<Int128> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="Vector128s.YGroup4Unzip(Vector128{UInt128}, Vector128{UInt128}, Vector128{UInt128}, Vector128{UInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<UInt128> X, Vector128<UInt128> Y, Vector128<UInt128> Z, Vector128<UInt128> W) YGroup4Unzip(this IWVectorTraits128 athis, Vector128<UInt128> data0, Vector128<UInt128> data1, Vector128<UInt128> data2, Vector128<UInt128> data3) {
            var rt0 = athis.YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

#endif // BCL_TYPE_INT128


#if BCL_TYPE_INT128

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{ExInt128}, Vector128{ExInt128}, Vector128{ExInt128}, Vector128{ExInt128}, out Vector128{ExInt128}, out Vector128{ExInt128}, out Vector128{ExInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<Int128> YGroup4Zip(this IWVectorTraits128 athis, Vector128<Int128> x, Vector128<Int128> y, Vector128<Int128> z, Vector128<Int128> w, out Vector128<Int128> data1, out Vector128<Int128> data2, out Vector128<Int128> data3) {
            var d0 = athis.YGroup4Zip(x.ExAsExInt128(), y.ExAsExInt128(), z.ExAsExInt128(), w.ExAsExInt128(), out var d1, out var d2, out var d3);
            data1 = d1.ExAsInt128();
            data2 = d2.ExAsInt128();
            data3 = d3.ExAsInt128();
            return d0.ExAsInt128();
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{ExUInt128}, Vector128{ExUInt128}, Vector128{ExUInt128}, Vector128{ExUInt128}, out Vector128{ExUInt128}, out Vector128{ExUInt128}, out Vector128{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<UInt128> YGroup4Zip(this IWVectorTraits128 athis, Vector128<UInt128> x, Vector128<UInt128> y, Vector128<UInt128> z, Vector128<UInt128> w, out Vector128<UInt128> data1, out Vector128<UInt128> data2, out Vector128<UInt128> data3) {
            var d0 = athis.YGroup4Zip(x.ExAsExUInt128(), y.ExAsExUInt128(), z.ExAsExUInt128(), w.ExAsExUInt128(), out var d1, out var d2, out var d3);
            data1 = d1.ExAsUInt128();
            data2 = d2.ExAsUInt128();
            data3 = d3.ExAsUInt128();
            return d0.ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="Vector128s.YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<T> Data0, Vector128<T> Data1, Vector128<T> Data2, Vector128<T> Data3) YGroup4Zip<T>(this IWVectorTraits128 athis, Vector128<T> x, Vector128<T> y, Vector128<T> z, Vector128<T> w) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip(x.As<T, float>(), y.As<T, float>(), z.As<T, float>(), w.As<T, float>());
                return (rt0.As<float, T>(), rt1.As<float, T>(), rt2.As<float, T>(), rt3.As<float, T>());
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip(x.As<T, double>(), y.As<T, double>(), z.As<T, double>(), w.As<T, double>());
                return (rt0.As<double, T>(), rt1.As<double, T>(), rt2.As<double, T>(), rt3.As<double, T>());
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip(x.As<T, sbyte>(), y.As<T, sbyte>(), z.As<T, sbyte>(), w.As<T, sbyte>());
                return (rt0.As<sbyte, T>(), rt1.As<sbyte, T>(), rt2.As<sbyte, T>(), rt3.As<sbyte, T>());
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip(x.As<T, byte>(), y.As<T, byte>(), z.As<T, byte>(), w.As<T, byte>());
                return (rt0.As<byte, T>(), rt1.As<byte, T>(), rt2.As<byte, T>(), rt3.As<byte, T>());
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip(x.As<T, short>(), y.As<T, short>(), z.As<T, short>(), w.As<T, short>());
                return (rt0.As<short, T>(), rt1.As<short, T>(), rt2.As<short, T>(), rt3.As<short, T>());
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip(x.As<T, ushort>(), y.As<T, ushort>(), z.As<T, ushort>(), w.As<T, ushort>());
                return (rt0.As<ushort, T>(), rt1.As<ushort, T>(), rt2.As<ushort, T>(), rt3.As<ushort, T>());
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip(x.As<T, int>(), y.As<T, int>(), z.As<T, int>(), w.As<T, int>());
                return (rt0.As<int, T>(), rt1.As<int, T>(), rt2.As<int, T>(), rt3.As<int, T>());
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip(x.As<T, uint>(), y.As<T, uint>(), z.As<T, uint>(), w.As<T, uint>());
                return (rt0.As<uint, T>(), rt1.As<uint, T>(), rt2.As<uint, T>(), rt3.As<uint, T>());
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip(x.As<T, long>(), y.As<T, long>(), z.As<T, long>(), w.As<T, long>());
                return (rt0.As<long, T>(), rt1.As<long, T>(), rt2.As<long, T>(), rt3.As<long, T>());
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip(x.As<T, ulong>(), y.As<T, ulong>(), z.As<T, ulong>(), w.As<T, ulong>());
                return (rt0.As<ulong, T>(), rt1.As<ulong, T>(), rt2.As<ulong, T>(), rt3.As<ulong, T>());
            } else if (typeof(ExInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip(x.ExAs<T, ExInt128>(), y.ExAs<T, ExInt128>(), z.ExAs<T, ExInt128>(), w.ExAs<T, ExInt128>());
                return (rt0.ExAs<ExInt128, T>(), rt1.ExAs<ExInt128, T>(), rt2.ExAs<ExInt128, T>(), rt3.ExAs<ExInt128, T>());
            } else if (typeof(ExUInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip(x.ExAs<T, ExUInt128>(), y.ExAs<T, ExUInt128>(), z.ExAs<T, ExUInt128>(), w.ExAs<T, ExUInt128>());
                return (rt0.ExAs<ExUInt128, T>(), rt1.ExAs<ExUInt128, T>(), rt2.ExAs<ExUInt128, T>(), rt3.ExAs<ExUInt128, T>());
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip(x.ExAs<T, Int128>(), y.ExAs<T, Int128>(), z.ExAs<T, Int128>(), w.ExAs<T, Int128>());
                return (rt0.ExAs<Int128, T>(), rt1.ExAs<Int128, T>(), rt2.ExAs<Int128, T>(), rt3.ExAs<Int128, T>());
            } else if (typeof(UInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = athis.YGroup4Zip(x.ExAs<T, UInt128>(), y.ExAs<T, UInt128>(), z.ExAs<T, UInt128>(), w.ExAs<T, UInt128>());
                return (rt0.ExAs<UInt128, T>(), rt1.ExAs<UInt128, T>(), rt2.ExAs<UInt128, T>(), rt3.ExAs<UInt128, T>());
#endif // BCL_TYPE_INT128
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<float> Data0, Vector128<float> Data1, Vector128<float> Data2, Vector128<float> Data3) YGroup4Zip(this IWVectorTraits128 athis, Vector128<float> x, Vector128<float> y, Vector128<float> z, Vector128<float> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<double> Data0, Vector128<double> Data1, Vector128<double> Data2, Vector128<double> Data3) YGroup4Zip(this IWVectorTraits128 athis, Vector128<double> x, Vector128<double> y, Vector128<double> z, Vector128<double> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> Data0, Vector128<sbyte> Data1, Vector128<sbyte> Data2, Vector128<sbyte> Data3) YGroup4Zip(this IWVectorTraits128 athis, Vector128<sbyte> x, Vector128<sbyte> y, Vector128<sbyte> z, Vector128<sbyte> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> Data0, Vector128<byte> Data1, Vector128<byte> Data2, Vector128<byte> Data3) YGroup4Zip(this IWVectorTraits128 athis, Vector128<byte> x, Vector128<byte> y, Vector128<byte> z, Vector128<byte> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> Data0, Vector128<short> Data1, Vector128<short> Data2, Vector128<short> Data3) YGroup4Zip(this IWVectorTraits128 athis, Vector128<short> x, Vector128<short> y, Vector128<short> z, Vector128<short> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> Data0, Vector128<ushort> Data1, Vector128<ushort> Data2, Vector128<ushort> Data3) YGroup4Zip(this IWVectorTraits128 athis, Vector128<ushort> x, Vector128<ushort> y, Vector128<ushort> z, Vector128<ushort> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> Data0, Vector128<int> Data1, Vector128<int> Data2, Vector128<int> Data3) YGroup4Zip(this IWVectorTraits128 athis, Vector128<int> x, Vector128<int> y, Vector128<int> z, Vector128<int> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> Data0, Vector128<uint> Data1, Vector128<uint> Data2, Vector128<uint> Data3) YGroup4Zip(this IWVectorTraits128 athis, Vector128<uint> x, Vector128<uint> y, Vector128<uint> z, Vector128<uint> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> Data0, Vector128<long> Data1, Vector128<long> Data2, Vector128<long> Data3) YGroup4Zip(this IWVectorTraits128 athis, Vector128<long> x, Vector128<long> y, Vector128<long> z, Vector128<long> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> Data0, Vector128<ulong> Data1, Vector128<ulong> Data2, Vector128<ulong> Data3) YGroup4Zip(this IWVectorTraits128 athis, Vector128<ulong> x, Vector128<ulong> y, Vector128<ulong> z, Vector128<ulong> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ExInt128> Data0, Vector128<ExInt128> Data1, Vector128<ExInt128> Data2, Vector128<ExInt128> Data3) YGroup4Zip(this IWVectorTraits128 athis, Vector128<ExInt128> x, Vector128<ExInt128> y, Vector128<ExInt128> z, Vector128<ExInt128> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ExUInt128> Data0, Vector128<ExUInt128> Data1, Vector128<ExUInt128> Data2, Vector128<ExUInt128> Data3) YGroup4Zip(this IWVectorTraits128 athis, Vector128<ExUInt128> x, Vector128<ExUInt128> y, Vector128<ExUInt128> z, Vector128<ExUInt128> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<Int128> Data0, Vector128<Int128> Data1, Vector128<Int128> Data2, Vector128<Int128> Data3) YGroup4Zip(this IWVectorTraits128 athis, Vector128<Int128> x, Vector128<Int128> y, Vector128<Int128> z, Vector128<Int128> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<UInt128> Data0, Vector128<UInt128> Data1, Vector128<UInt128> Data2, Vector128<UInt128> Data3) YGroup4Zip(this IWVectorTraits128 athis, Vector128<UInt128> x, Vector128<UInt128> y, Vector128<UInt128> z, Vector128<UInt128> w) {
            var data0 = athis.YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

#endif // BCL_TYPE_INT128

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
