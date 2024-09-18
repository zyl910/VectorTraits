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
    partial class IWVectorTraits256_Extensions {
#if NETCOREAPP3_0_OR_GREATER

        /// <inheritdoc cref="Vector256s.YShuffleG4X2{T}(Vector256{T}, Vector256{T}, ShuffleControlG4)"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static (Vector256<T> Result0, Vector256<T> Result1) YShuffleG4X2<T>(this IWVectorTraits256 athis, Vector256<T> source0, Vector256<T> source1, [ConstantExpected] ShuffleControlG4 control) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2(source0.As<T, float>(), source1.As<T, float>(), control);
                return (result0.As<float, T>(), result1.As<float, T>());
            } else if (typeof(double) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2(source0.As<T, double>(), source1.As<T, double>(), control);
                return (result0.As<double, T>(), result1.As<double, T>());
            } else if (typeof(sbyte) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2(source0.As<T, sbyte>(), source1.As<T, sbyte>(), control);
                return (result0.As<sbyte, T>(), result1.As<sbyte, T>());
            } else if (typeof(byte) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2(source0.As<T, byte>(), source1.As<T, byte>(), control);
                return (result0.As<byte, T>(), result1.As<byte, T>());
            } else if (typeof(short) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2(source0.As<T, short>(), source1.As<T, short>(), control);
                return (result0.As<short, T>(), result1.As<short, T>());
            } else if (typeof(ushort) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2(source0.As<T, ushort>(), source1.As<T, ushort>(), control);
                return (result0.As<ushort, T>(), result1.As<ushort, T>());
            } else if (typeof(int) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2(source0.As<T, int>(), source1.As<T, int>(), control);
                return (result0.As<int, T>(), result1.As<int, T>());
            } else if (typeof(uint) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2(source0.As<T, uint>(), source1.As<T, uint>(), control);
                return (result0.As<uint, T>(), result1.As<uint, T>());
            } else if (typeof(long) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2(source0.As<T, long>(), source1.As<T, long>(), control);
                return (result0.As<long, T>(), result1.As<long, T>());
            } else if (typeof(ulong) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2(source0.As<T, ulong>(), source1.As<T, ulong>(), control);
                return (result0.As<ulong, T>(), result1.As<ulong, T>());
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
                (var result0, var result1) = athis.YShuffleG4X2_Const(source0.As<T, float>(), source1.As<T, float>(), control);
                return (result0.As<float, T>(), result1.As<float, T>());
            } else if (typeof(double) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const(source0.As<T, double>(), source1.As<T, double>(), control);
                return (result0.As<double, T>(), result1.As<double, T>());
            } else if (typeof(sbyte) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const(source0.As<T, sbyte>(), source1.As<T, sbyte>(), control);
                return (result0.As<sbyte, T>(), result1.As<sbyte, T>());
            } else if (typeof(byte) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const(source0.As<T, byte>(), source1.As<T, byte>(), control);
                return (result0.As<byte, T>(), result1.As<byte, T>());
            } else if (typeof(short) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const(source0.As<T, short>(), source1.As<T, short>(), control);
                return (result0.As<short, T>(), result1.As<short, T>());
            } else if (typeof(ushort) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const(source0.As<T, ushort>(), source1.As<T, ushort>(), control);
                return (result0.As<ushort, T>(), result1.As<ushort, T>());
            } else if (typeof(int) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const(source0.As<T, int>(), source1.As<T, int>(), control);
                return (result0.As<int, T>(), result1.As<int, T>());
            } else if (typeof(uint) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const(source0.As<T, uint>(), source1.As<T, uint>(), control);
                return (result0.As<uint, T>(), result1.As<uint, T>());
            } else if (typeof(long) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const(source0.As<T, long>(), source1.As<T, long>(), control);
                return (result0.As<long, T>(), result1.As<long, T>());
            } else if (typeof(ulong) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const(source0.As<T, ulong>(), source1.As<T, ulong>(), control);
                return (result0.As<ulong, T>(), result1.As<ulong, T>());
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
                (var a0, var a1, var a2) = athis.YShuffleInsert_Args(indices.As<TIdx, sbyte>());
                args0 = a0.As<sbyte, TIdx>();
                args1 = a1.As<sbyte, TIdx>();
                args2 = a2.As<sbyte, TIdx>();
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a0, var a1, var a2) = athis.YShuffleInsert_Args(indices.As<TIdx, byte>());
                args0 = a0.As<byte, TIdx>();
                args1 = a1.As<byte, TIdx>();
                args2 = a2.As<byte, TIdx>();
            } else if (typeof(short) == typeof(TIdx)) {
                (var a0, var a1, var a2) = athis.YShuffleInsert_Args(indices.As<TIdx, short>());
                args0 = a0.As<short, TIdx>();
                args1 = a1.As<short, TIdx>();
                args2 = a2.As<short, TIdx>();
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a0, var a1, var a2) = athis.YShuffleInsert_Args(indices.As<TIdx, ushort>());
                args0 = a0.As<ushort, TIdx>();
                args1 = a1.As<ushort, TIdx>();
                args2 = a2.As<ushort, TIdx>();
            } else if (typeof(int) == typeof(TIdx)) {
                (var a0, var a1, var a2) = athis.YShuffleInsert_Args(indices.As<TIdx, int>());
                args0 = a0.As<int, TIdx>();
                args1 = a1.As<int, TIdx>();
                args2 = a2.As<int, TIdx>();
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a0, var a1, var a2) = athis.YShuffleInsert_Args(indices.As<TIdx, uint>());
                args0 = a0.As<uint, TIdx>();
                args1 = a1.As<uint, TIdx>();
                args2 = a2.As<uint, TIdx>();
            } else if (typeof(long) == typeof(TIdx)) {
                (var a0, var a1, var a2) = athis.YShuffleInsert_Args(indices.As<TIdx, long>());
                args0 = a0.As<long, TIdx>();
                args1 = a1.As<long, TIdx>();
                args2 = a2.As<long, TIdx>();
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a0, var a1, var a2) = athis.YShuffleInsert_Args(indices.As<TIdx, ulong>());
                args0 = a0.As<ulong, TIdx>();
                args1 = a1.As<ulong, TIdx>();
                args2 = a2.As<ulong, TIdx>();
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
                return athis.YShuffleInsert_Core(back.As<T, float>(), vector.As<T, float>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<int>, Vector256<int>, Vector256<int>>>(ref args)).As<float, T>();
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return athis.YShuffleInsert_Core(back.As<T, double>(), vector.As<T, double>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<long>, Vector256<long>, Vector256<long>>>(ref args)).As<double, T>();
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return athis.YShuffleInsert_Core(back.As<T, sbyte>(), vector.As<T, sbyte>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>>>(ref args)).As<sbyte, T>();
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return athis.YShuffleInsert_Core(back.As<T, byte>(), vector.As<T, byte>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<byte>, Vector256<byte>, Vector256<byte>>>(ref args)).As<byte, T>();
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return athis.YShuffleInsert_Core(back.As<T, short>(), vector.As<T, short>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<short>, Vector256<short>, Vector256<short>>>(ref args)).As<short, T>();
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return athis.YShuffleInsert_Core(back.As<T, ushort>(), vector.As<T, ushort>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<ushort>, Vector256<ushort>, Vector256<ushort>>>(ref args)).As<ushort, T>();
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return athis.YShuffleInsert_Core(back.As<T, int>(), vector.As<T, int>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<int>, Vector256<int>, Vector256<int>>>(ref args)).As<int, T>();
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return athis.YShuffleInsert_Core(back.As<T, uint>(), vector.As<T, uint>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<uint>, Vector256<uint>, Vector256<uint>>>(ref args)).As<uint, T>();
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return athis.YShuffleInsert_Core(back.As<T, long>(), vector.As<T, long>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<long>, Vector256<long>, Vector256<long>>>(ref args)).As<long, T>();
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return athis.YShuffleInsert_Core(back.As<T, ulong>(), vector.As<T, ulong>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<ulong>, Vector256<ulong>, Vector256<ulong>>>(ref args)).As<ulong, T>();
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
                (var a0, var a1) = athis.YShuffleKernel_Args(indices.As<TIdx, sbyte>());
                args0 = a0.As<sbyte, TIdx>();
                args1 = a1.As<sbyte, TIdx>();
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a0, var a1) = athis.YShuffleKernel_Args(indices.As<TIdx, byte>());
                args0 = a0.As<byte, TIdx>();
                args1 = a1.As<byte, TIdx>();
            } else if (typeof(short) == typeof(TIdx)) {
                (var a0, var a1) = athis.YShuffleKernel_Args(indices.As<TIdx, short>());
                args0 = a0.As<short, TIdx>();
                args1 = a1.As<short, TIdx>();
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a0, var a1) = athis.YShuffleKernel_Args(indices.As<TIdx, ushort>());
                args0 = a0.As<ushort, TIdx>();
                args1 = a1.As<ushort, TIdx>();
            } else if (typeof(int) == typeof(TIdx)) {
                (var a0, var a1) = athis.YShuffleKernel_Args(indices.As<TIdx, int>());
                args0 = a0.As<int, TIdx>();
                args1 = a1.As<int, TIdx>();
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a0, var a1) = athis.YShuffleKernel_Args(indices.As<TIdx, uint>());
                args0 = a0.As<uint, TIdx>();
                args1 = a1.As<uint, TIdx>();
            } else if (typeof(long) == typeof(TIdx)) {
                (var a0, var a1) = athis.YShuffleKernel_Args(indices.As<TIdx, long>());
                args0 = a0.As<long, TIdx>();
                args1 = a1.As<long, TIdx>();
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a0, var a1) = athis.YShuffleKernel_Args(indices.As<TIdx, ulong>());
                args0 = a0.As<ulong, TIdx>();
                args1 = a1.As<ulong, TIdx>();
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
                return athis.YShuffleKernel_Core(vector.As<T, float>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<int>, Vector256<int>>>(ref args)).As<float, T>();
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return athis.YShuffleKernel_Core(vector.As<T, double>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<long>, Vector256<long>>>(ref args)).As<double, T>();
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return athis.YShuffleKernel_Core(vector.As<T, sbyte>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<sbyte>, Vector256<sbyte>>>(ref args)).As<sbyte, T>();
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return athis.YShuffleKernel_Core(vector.As<T, byte>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<byte>, Vector256<byte>>>(ref args)).As<byte, T>();
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return athis.YShuffleKernel_Core(vector.As<T, short>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<short>, Vector256<short>>>(ref args)).As<short, T>();
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return athis.YShuffleKernel_Core(vector.As<T, ushort>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<ushort>, Vector256<ushort>>>(ref args)).As<ushort, T>();
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return athis.YShuffleKernel_Core(vector.As<T, int>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<int>, Vector256<int>>>(ref args)).As<int, T>();
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return athis.YShuffleKernel_Core(vector.As<T, uint>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<uint>, Vector256<uint>>>(ref args)).As<uint, T>();
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return athis.YShuffleKernel_Core(vector.As<T, long>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<long>, Vector256<long>>>(ref args)).As<long, T>();
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return athis.YShuffleKernel_Core(vector.As<T, ulong>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<ulong>, Vector256<ulong>>>(ref args)).As<ulong, T>();
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
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX2_Args(indices.As<TIdx, sbyte>());
                args0 = a0.As<sbyte, TIdx>();
                args1 = a1.As<sbyte, TIdx>();
                args2 = a2.As<sbyte, TIdx>();
                args3 = a3.As<sbyte, TIdx>();
                args4 = a4.As<sbyte, TIdx>();
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX2_Args(indices.As<TIdx, byte>());
                args0 = a0.As<byte, TIdx>();
                args1 = a1.As<byte, TIdx>();
                args2 = a2.As<byte, TIdx>();
                args3 = a3.As<byte, TIdx>();
                args4 = a4.As<byte, TIdx>();
            } else if (typeof(short) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX2_Args(indices.As<TIdx, short>());
                args0 = a0.As<short, TIdx>();
                args1 = a1.As<short, TIdx>();
                args2 = a2.As<short, TIdx>();
                args3 = a3.As<short, TIdx>();
                args4 = a4.As<short, TIdx>();
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX2_Args(indices.As<TIdx, ushort>());
                args0 = a0.As<ushort, TIdx>();
                args1 = a1.As<ushort, TIdx>();
                args2 = a2.As<ushort, TIdx>();
                args3 = a3.As<ushort, TIdx>();
                args4 = a4.As<ushort, TIdx>();
            } else if (typeof(int) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX2_Args(indices.As<TIdx, int>());
                args0 = a0.As<int, TIdx>();
                args1 = a1.As<int, TIdx>();
                args2 = a2.As<int, TIdx>();
                args3 = a3.As<int, TIdx>();
                args4 = a4.As<int, TIdx>();
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX2_Args(indices.As<TIdx, uint>());
                args0 = a0.As<uint, TIdx>();
                args1 = a1.As<uint, TIdx>();
                args2 = a2.As<uint, TIdx>();
                args3 = a3.As<uint, TIdx>();
                args4 = a4.As<uint, TIdx>();
            } else if (typeof(long) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX2_Args(indices.As<TIdx, long>());
                args0 = a0.As<long, TIdx>();
                args1 = a1.As<long, TIdx>();
                args2 = a2.As<long, TIdx>();
                args3 = a3.As<long, TIdx>();
                args4 = a4.As<long, TIdx>();
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX2_Args(indices.As<TIdx, ulong>());
                args0 = a0.As<ulong, TIdx>();
                args1 = a1.As<ulong, TIdx>();
                args2 = a2.As<ulong, TIdx>();
                args3 = a3.As<ulong, TIdx>();
                args4 = a4.As<ulong, TIdx>();
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
                return athis.YShuffleX2_Core(vector0.As<T, float>(), vector1.As<T, float>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>>>(ref args)).As<float, T>();
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return athis.YShuffleX2_Core(vector0.As<T, double>(), vector1.As<T, double>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>>>(ref args)).As<double, T>();
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return athis.YShuffleX2_Core(vector0.As<T, sbyte>(), vector1.As<T, sbyte>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>>>(ref args)).As<sbyte, T>();
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return athis.YShuffleX2_Core(vector0.As<T, byte>(), vector1.As<T, byte>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<byte>, Vector256<byte>, Vector256<byte>, Vector256<byte>, Vector256<byte>>>(ref args)).As<byte, T>();
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return athis.YShuffleX2_Core(vector0.As<T, short>(), vector1.As<T, short>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<short>, Vector256<short>, Vector256<short>, Vector256<short>, Vector256<short>>>(ref args)).As<short, T>();
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return athis.YShuffleX2_Core(vector0.As<T, ushort>(), vector1.As<T, ushort>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<ushort>, Vector256<ushort>, Vector256<ushort>, Vector256<ushort>, Vector256<ushort>>>(ref args)).As<ushort, T>();
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return athis.YShuffleX2_Core(vector0.As<T, int>(), vector1.As<T, int>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>>>(ref args)).As<int, T>();
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return athis.YShuffleX2_Core(vector0.As<T, uint>(), vector1.As<T, uint>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<uint>, Vector256<uint>, Vector256<uint>, Vector256<uint>, Vector256<uint>>>(ref args)).As<uint, T>();
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return athis.YShuffleX2_Core(vector0.As<T, long>(), vector1.As<T, long>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>>>(ref args)).As<long, T>();
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return athis.YShuffleX2_Core(vector0.As<T, ulong>(), vector1.As<T, ulong>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<ulong>, Vector256<ulong>, Vector256<ulong>, Vector256<ulong>, Vector256<ulong>>>(ref args)).As<ulong, T>();
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
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX2Insert_Args(indices.As<TIdx, sbyte>());
                args0 = a0.As<sbyte, TIdx>();
                args1 = a1.As<sbyte, TIdx>();
                args2 = a2.As<sbyte, TIdx>();
                args3 = a3.As<sbyte, TIdx>();
                args4 = a4.As<sbyte, TIdx>();
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX2Insert_Args(indices.As<TIdx, byte>());
                args0 = a0.As<byte, TIdx>();
                args1 = a1.As<byte, TIdx>();
                args2 = a2.As<byte, TIdx>();
                args3 = a3.As<byte, TIdx>();
                args4 = a4.As<byte, TIdx>();
            } else if (typeof(short) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX2Insert_Args(indices.As<TIdx, short>());
                args0 = a0.As<short, TIdx>();
                args1 = a1.As<short, TIdx>();
                args2 = a2.As<short, TIdx>();
                args3 = a3.As<short, TIdx>();
                args4 = a4.As<short, TIdx>();
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX2Insert_Args(indices.As<TIdx, ushort>());
                args0 = a0.As<ushort, TIdx>();
                args1 = a1.As<ushort, TIdx>();
                args2 = a2.As<ushort, TIdx>();
                args3 = a3.As<ushort, TIdx>();
                args4 = a4.As<ushort, TIdx>();
            } else if (typeof(int) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX2Insert_Args(indices.As<TIdx, int>());
                args0 = a0.As<int, TIdx>();
                args1 = a1.As<int, TIdx>();
                args2 = a2.As<int, TIdx>();
                args3 = a3.As<int, TIdx>();
                args4 = a4.As<int, TIdx>();
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX2Insert_Args(indices.As<TIdx, uint>());
                args0 = a0.As<uint, TIdx>();
                args1 = a1.As<uint, TIdx>();
                args2 = a2.As<uint, TIdx>();
                args3 = a3.As<uint, TIdx>();
                args4 = a4.As<uint, TIdx>();
            } else if (typeof(long) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX2Insert_Args(indices.As<TIdx, long>());
                args0 = a0.As<long, TIdx>();
                args1 = a1.As<long, TIdx>();
                args2 = a2.As<long, TIdx>();
                args3 = a3.As<long, TIdx>();
                args4 = a4.As<long, TIdx>();
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX2Insert_Args(indices.As<TIdx, ulong>());
                args0 = a0.As<ulong, TIdx>();
                args1 = a1.As<ulong, TIdx>();
                args2 = a2.As<ulong, TIdx>();
                args3 = a3.As<ulong, TIdx>();
                args4 = a4.As<ulong, TIdx>();
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
                return athis.YShuffleX2Insert_Core(back.As<T, float>(), vector0.As<T, float>(), vector1.As<T, float>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>>>(ref args)).As<float, T>();
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return athis.YShuffleX2Insert_Core(back.As<T, double>(), vector0.As<T, double>(), vector1.As<T, double>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>>>(ref args)).As<double, T>();
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return athis.YShuffleX2Insert_Core(back.As<T, sbyte>(), vector0.As<T, sbyte>(), vector1.As<T, sbyte>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>>>(ref args)).As<sbyte, T>();
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return athis.YShuffleX2Insert_Core(back.As<T, byte>(), vector0.As<T, byte>(), vector1.As<T, byte>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<byte>, Vector256<byte>, Vector256<byte>, Vector256<byte>, Vector256<byte>>>(ref args)).As<byte, T>();
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return athis.YShuffleX2Insert_Core(back.As<T, short>(), vector0.As<T, short>(), vector1.As<T, short>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<short>, Vector256<short>, Vector256<short>, Vector256<short>, Vector256<short>>>(ref args)).As<short, T>();
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return athis.YShuffleX2Insert_Core(back.As<T, ushort>(), vector0.As<T, ushort>(), vector1.As<T, ushort>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<ushort>, Vector256<ushort>, Vector256<ushort>, Vector256<ushort>, Vector256<ushort>>>(ref args)).As<ushort, T>();
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return athis.YShuffleX2Insert_Core(back.As<T, int>(), vector0.As<T, int>(), vector1.As<T, int>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>>>(ref args)).As<int, T>();
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return athis.YShuffleX2Insert_Core(back.As<T, uint>(), vector0.As<T, uint>(), vector1.As<T, uint>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<uint>, Vector256<uint>, Vector256<uint>, Vector256<uint>, Vector256<uint>>>(ref args)).As<uint, T>();
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return athis.YShuffleX2Insert_Core(back.As<T, long>(), vector0.As<T, long>(), vector1.As<T, long>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>>>(ref args)).As<long, T>();
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return athis.YShuffleX2Insert_Core(back.As<T, ulong>(), vector0.As<T, ulong>(), vector1.As<T, ulong>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<ulong>, Vector256<ulong>, Vector256<ulong>, Vector256<ulong>, Vector256<ulong>>>(ref args)).As<ulong, T>();
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
                (var a0, var a1, var a2, var a3) = athis.YShuffleX2Kernel_Args(indices.As<TIdx, sbyte>());
                args0 = a0.As<sbyte, TIdx>();
                args1 = a1.As<sbyte, TIdx>();
                args2 = a2.As<sbyte, TIdx>();
                args3 = a3.As<sbyte, TIdx>();
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = athis.YShuffleX2Kernel_Args(indices.As<TIdx, byte>());
                args0 = a0.As<byte, TIdx>();
                args1 = a1.As<byte, TIdx>();
                args2 = a2.As<byte, TIdx>();
                args3 = a3.As<byte, TIdx>();
            } else if (typeof(short) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = athis.YShuffleX2Kernel_Args(indices.As<TIdx, short>());
                args0 = a0.As<short, TIdx>();
                args1 = a1.As<short, TIdx>();
                args2 = a2.As<short, TIdx>();
                args3 = a3.As<short, TIdx>();
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = athis.YShuffleX2Kernel_Args(indices.As<TIdx, ushort>());
                args0 = a0.As<ushort, TIdx>();
                args1 = a1.As<ushort, TIdx>();
                args2 = a2.As<ushort, TIdx>();
                args3 = a3.As<ushort, TIdx>();
            } else if (typeof(int) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = athis.YShuffleX2Kernel_Args(indices.As<TIdx, int>());
                args0 = a0.As<int, TIdx>();
                args1 = a1.As<int, TIdx>();
                args2 = a2.As<int, TIdx>();
                args3 = a3.As<int, TIdx>();
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = athis.YShuffleX2Kernel_Args(indices.As<TIdx, uint>());
                args0 = a0.As<uint, TIdx>();
                args1 = a1.As<uint, TIdx>();
                args2 = a2.As<uint, TIdx>();
                args3 = a3.As<uint, TIdx>();
            } else if (typeof(long) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = athis.YShuffleX2Kernel_Args(indices.As<TIdx, long>());
                args0 = a0.As<long, TIdx>();
                args1 = a1.As<long, TIdx>();
                args2 = a2.As<long, TIdx>();
                args3 = a3.As<long, TIdx>();
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = athis.YShuffleX2Kernel_Args(indices.As<TIdx, ulong>());
                args0 = a0.As<ulong, TIdx>();
                args1 = a1.As<ulong, TIdx>();
                args2 = a2.As<ulong, TIdx>();
                args3 = a3.As<ulong, TIdx>();
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
                return athis.YShuffleX2Kernel_Core(vector0.As<T, float>(), vector1.As<T, float>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>>>(ref args)).As<float, T>();
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return athis.YShuffleX2Kernel_Core(vector0.As<T, double>(), vector1.As<T, double>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>>>(ref args)).As<double, T>();
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return athis.YShuffleX2Kernel_Core(vector0.As<T, sbyte>(), vector1.As<T, sbyte>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>>>(ref args)).As<sbyte, T>();
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return athis.YShuffleX2Kernel_Core(vector0.As<T, byte>(), vector1.As<T, byte>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<byte>, Vector256<byte>, Vector256<byte>, Vector256<byte>>>(ref args)).As<byte, T>();
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return athis.YShuffleX2Kernel_Core(vector0.As<T, short>(), vector1.As<T, short>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<short>, Vector256<short>, Vector256<short>, Vector256<short>>>(ref args)).As<short, T>();
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return athis.YShuffleX2Kernel_Core(vector0.As<T, ushort>(), vector1.As<T, ushort>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<ushort>, Vector256<ushort>, Vector256<ushort>, Vector256<ushort>>>(ref args)).As<ushort, T>();
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return athis.YShuffleX2Kernel_Core(vector0.As<T, int>(), vector1.As<T, int>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>>>(ref args)).As<int, T>();
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return athis.YShuffleX2Kernel_Core(vector0.As<T, uint>(), vector1.As<T, uint>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<uint>, Vector256<uint>, Vector256<uint>, Vector256<uint>>>(ref args)).As<uint, T>();
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return athis.YShuffleX2Kernel_Core(vector0.As<T, long>(), vector1.As<T, long>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>>>(ref args)).As<long, T>();
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return athis.YShuffleX2Kernel_Core(vector0.As<T, ulong>(), vector1.As<T, ulong>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<ulong>, Vector256<ulong>, Vector256<ulong>, Vector256<ulong>>>(ref args)).As<ulong, T>();
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
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX3_Args(indices.As<TIdx, sbyte>());
                args0 = a0.As<sbyte, TIdx>();
                args1 = a1.As<sbyte, TIdx>();
                args2 = a2.As<sbyte, TIdx>();
                args3 = a3.As<sbyte, TIdx>();
                args4 = a4.As<sbyte, TIdx>();
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX3_Args(indices.As<TIdx, byte>());
                args0 = a0.As<byte, TIdx>();
                args1 = a1.As<byte, TIdx>();
                args2 = a2.As<byte, TIdx>();
                args3 = a3.As<byte, TIdx>();
                args4 = a4.As<byte, TIdx>();
            } else if (typeof(short) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX3_Args(indices.As<TIdx, short>());
                args0 = a0.As<short, TIdx>();
                args1 = a1.As<short, TIdx>();
                args2 = a2.As<short, TIdx>();
                args3 = a3.As<short, TIdx>();
                args4 = a4.As<short, TIdx>();
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX3_Args(indices.As<TIdx, ushort>());
                args0 = a0.As<ushort, TIdx>();
                args1 = a1.As<ushort, TIdx>();
                args2 = a2.As<ushort, TIdx>();
                args3 = a3.As<ushort, TIdx>();
                args4 = a4.As<ushort, TIdx>();
            } else if (typeof(int) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX3_Args(indices.As<TIdx, int>());
                args0 = a0.As<int, TIdx>();
                args1 = a1.As<int, TIdx>();
                args2 = a2.As<int, TIdx>();
                args3 = a3.As<int, TIdx>();
                args4 = a4.As<int, TIdx>();
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX3_Args(indices.As<TIdx, uint>());
                args0 = a0.As<uint, TIdx>();
                args1 = a1.As<uint, TIdx>();
                args2 = a2.As<uint, TIdx>();
                args3 = a3.As<uint, TIdx>();
                args4 = a4.As<uint, TIdx>();
            } else if (typeof(long) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX3_Args(indices.As<TIdx, long>());
                args0 = a0.As<long, TIdx>();
                args1 = a1.As<long, TIdx>();
                args2 = a2.As<long, TIdx>();
                args3 = a3.As<long, TIdx>();
                args4 = a4.As<long, TIdx>();
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX3_Args(indices.As<TIdx, ulong>());
                args0 = a0.As<ulong, TIdx>();
                args1 = a1.As<ulong, TIdx>();
                args2 = a2.As<ulong, TIdx>();
                args3 = a3.As<ulong, TIdx>();
                args4 = a4.As<ulong, TIdx>();
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
                return athis.YShuffleX3_Core(vector0.As<T, float>(), vector1.As<T, float>(), vector2.As<T, float>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>>>(ref args)).As<float, T>();
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return athis.YShuffleX3_Core(vector0.As<T, double>(), vector1.As<T, double>(), vector2.As<T, double>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>>>(ref args)).As<double, T>();
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return athis.YShuffleX3_Core(vector0.As<T, sbyte>(), vector1.As<T, sbyte>(), vector2.As<T, sbyte>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>>>(ref args)).As<sbyte, T>();
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return athis.YShuffleX3_Core(vector0.As<T, byte>(), vector1.As<T, byte>(), vector2.As<T, byte>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<byte>, Vector256<byte>, Vector256<byte>, Vector256<byte>, Vector256<byte>>>(ref args)).As<byte, T>();
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return athis.YShuffleX3_Core(vector0.As<T, short>(), vector1.As<T, short>(), vector2.As<T, short>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<short>, Vector256<short>, Vector256<short>, Vector256<short>, Vector256<short>>>(ref args)).As<short, T>();
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return athis.YShuffleX3_Core(vector0.As<T, ushort>(), vector1.As<T, ushort>(), vector2.As<T, ushort>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<ushort>, Vector256<ushort>, Vector256<ushort>, Vector256<ushort>, Vector256<ushort>>>(ref args)).As<ushort, T>();
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return athis.YShuffleX3_Core(vector0.As<T, int>(), vector1.As<T, int>(), vector2.As<T, int>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>>>(ref args)).As<int, T>();
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return athis.YShuffleX3_Core(vector0.As<T, uint>(), vector1.As<T, uint>(), vector2.As<T, uint>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<uint>, Vector256<uint>, Vector256<uint>, Vector256<uint>, Vector256<uint>>>(ref args)).As<uint, T>();
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return athis.YShuffleX3_Core(vector0.As<T, long>(), vector1.As<T, long>(), vector2.As<T, long>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>>>(ref args)).As<long, T>();
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return athis.YShuffleX3_Core(vector0.As<T, ulong>(), vector1.As<T, ulong>(), vector2.As<T, ulong>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<ulong>, Vector256<ulong>, Vector256<ulong>, Vector256<ulong>, Vector256<ulong>>>(ref args)).As<ulong, T>();
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
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX3Insert_Args(indices.As<TIdx, sbyte>());
                args0 = a0.As<sbyte, TIdx>();
                args1 = a1.As<sbyte, TIdx>();
                args2 = a2.As<sbyte, TIdx>();
                args3 = a3.As<sbyte, TIdx>();
                args4 = a4.As<sbyte, TIdx>();
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX3Insert_Args(indices.As<TIdx, byte>());
                args0 = a0.As<byte, TIdx>();
                args1 = a1.As<byte, TIdx>();
                args2 = a2.As<byte, TIdx>();
                args3 = a3.As<byte, TIdx>();
                args4 = a4.As<byte, TIdx>();
            } else if (typeof(short) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX3Insert_Args(indices.As<TIdx, short>());
                args0 = a0.As<short, TIdx>();
                args1 = a1.As<short, TIdx>();
                args2 = a2.As<short, TIdx>();
                args3 = a3.As<short, TIdx>();
                args4 = a4.As<short, TIdx>();
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX3Insert_Args(indices.As<TIdx, ushort>());
                args0 = a0.As<ushort, TIdx>();
                args1 = a1.As<ushort, TIdx>();
                args2 = a2.As<ushort, TIdx>();
                args3 = a3.As<ushort, TIdx>();
                args4 = a4.As<ushort, TIdx>();
            } else if (typeof(int) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX3Insert_Args(indices.As<TIdx, int>());
                args0 = a0.As<int, TIdx>();
                args1 = a1.As<int, TIdx>();
                args2 = a2.As<int, TIdx>();
                args3 = a3.As<int, TIdx>();
                args4 = a4.As<int, TIdx>();
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX3Insert_Args(indices.As<TIdx, uint>());
                args0 = a0.As<uint, TIdx>();
                args1 = a1.As<uint, TIdx>();
                args2 = a2.As<uint, TIdx>();
                args3 = a3.As<uint, TIdx>();
                args4 = a4.As<uint, TIdx>();
            } else if (typeof(long) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX3Insert_Args(indices.As<TIdx, long>());
                args0 = a0.As<long, TIdx>();
                args1 = a1.As<long, TIdx>();
                args2 = a2.As<long, TIdx>();
                args3 = a3.As<long, TIdx>();
                args4 = a4.As<long, TIdx>();
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX3Insert_Args(indices.As<TIdx, ulong>());
                args0 = a0.As<ulong, TIdx>();
                args1 = a1.As<ulong, TIdx>();
                args2 = a2.As<ulong, TIdx>();
                args3 = a3.As<ulong, TIdx>();
                args4 = a4.As<ulong, TIdx>();
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
                return athis.YShuffleX3Insert_Core(back.As<T, float>(), vector0.As<T, float>(), vector1.As<T, float>(), vector2.As<T, float>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>>>(ref args)).As<float, T>();
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return athis.YShuffleX3Insert_Core(back.As<T, double>(), vector0.As<T, double>(), vector1.As<T, double>(), vector2.As<T, double>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>>>(ref args)).As<double, T>();
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return athis.YShuffleX3Insert_Core(back.As<T, sbyte>(), vector0.As<T, sbyte>(), vector1.As<T, sbyte>(), vector2.As<T, sbyte>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>>>(ref args)).As<sbyte, T>();
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return athis.YShuffleX3Insert_Core(back.As<T, byte>(), vector0.As<T, byte>(), vector1.As<T, byte>(), vector2.As<T, byte>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<byte>, Vector256<byte>, Vector256<byte>, Vector256<byte>, Vector256<byte>>>(ref args)).As<byte, T>();
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return athis.YShuffleX3Insert_Core(back.As<T, short>(), vector0.As<T, short>(), vector1.As<T, short>(), vector2.As<T, short>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<short>, Vector256<short>, Vector256<short>, Vector256<short>, Vector256<short>>>(ref args)).As<short, T>();
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return athis.YShuffleX3Insert_Core(back.As<T, ushort>(), vector0.As<T, ushort>(), vector1.As<T, ushort>(), vector2.As<T, ushort>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<ushort>, Vector256<ushort>, Vector256<ushort>, Vector256<ushort>, Vector256<ushort>>>(ref args)).As<ushort, T>();
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return athis.YShuffleX3Insert_Core(back.As<T, int>(), vector0.As<T, int>(), vector1.As<T, int>(), vector2.As<T, int>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>>>(ref args)).As<int, T>();
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return athis.YShuffleX3Insert_Core(back.As<T, uint>(), vector0.As<T, uint>(), vector1.As<T, uint>(), vector2.As<T, uint>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<uint>, Vector256<uint>, Vector256<uint>, Vector256<uint>, Vector256<uint>>>(ref args)).As<uint, T>();
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return athis.YShuffleX3Insert_Core(back.As<T, long>(), vector0.As<T, long>(), vector1.As<T, long>(), vector2.As<T, long>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>>>(ref args)).As<long, T>();
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return athis.YShuffleX3Insert_Core(back.As<T, ulong>(), vector0.As<T, ulong>(), vector1.As<T, ulong>(), vector2.As<T, ulong>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<ulong>, Vector256<ulong>, Vector256<ulong>, Vector256<ulong>, Vector256<ulong>>>(ref args)).As<ulong, T>();
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
                (var a0, var a1, var a2, var a3) = athis.YShuffleX3Kernel_Args(indices.As<TIdx, sbyte>());
                args0 = a0.As<sbyte, TIdx>();
                args1 = a1.As<sbyte, TIdx>();
                args2 = a2.As<sbyte, TIdx>();
                args3 = a3.As<sbyte, TIdx>();
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = athis.YShuffleX3Kernel_Args(indices.As<TIdx, byte>());
                args0 = a0.As<byte, TIdx>();
                args1 = a1.As<byte, TIdx>();
                args2 = a2.As<byte, TIdx>();
                args3 = a3.As<byte, TIdx>();
            } else if (typeof(short) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = athis.YShuffleX3Kernel_Args(indices.As<TIdx, short>());
                args0 = a0.As<short, TIdx>();
                args1 = a1.As<short, TIdx>();
                args2 = a2.As<short, TIdx>();
                args3 = a3.As<short, TIdx>();
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = athis.YShuffleX3Kernel_Args(indices.As<TIdx, ushort>());
                args0 = a0.As<ushort, TIdx>();
                args1 = a1.As<ushort, TIdx>();
                args2 = a2.As<ushort, TIdx>();
                args3 = a3.As<ushort, TIdx>();
            } else if (typeof(int) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = athis.YShuffleX3Kernel_Args(indices.As<TIdx, int>());
                args0 = a0.As<int, TIdx>();
                args1 = a1.As<int, TIdx>();
                args2 = a2.As<int, TIdx>();
                args3 = a3.As<int, TIdx>();
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = athis.YShuffleX3Kernel_Args(indices.As<TIdx, uint>());
                args0 = a0.As<uint, TIdx>();
                args1 = a1.As<uint, TIdx>();
                args2 = a2.As<uint, TIdx>();
                args3 = a3.As<uint, TIdx>();
            } else if (typeof(long) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = athis.YShuffleX3Kernel_Args(indices.As<TIdx, long>());
                args0 = a0.As<long, TIdx>();
                args1 = a1.As<long, TIdx>();
                args2 = a2.As<long, TIdx>();
                args3 = a3.As<long, TIdx>();
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = athis.YShuffleX3Kernel_Args(indices.As<TIdx, ulong>());
                args0 = a0.As<ulong, TIdx>();
                args1 = a1.As<ulong, TIdx>();
                args2 = a2.As<ulong, TIdx>();
                args3 = a3.As<ulong, TIdx>();
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
                return athis.YShuffleX3Kernel_Core(vector0.As<T, float>(), vector1.As<T, float>(), vector2.As<T, float>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>>>(ref args)).As<float, T>();
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return athis.YShuffleX3Kernel_Core(vector0.As<T, double>(), vector1.As<T, double>(), vector2.As<T, double>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>>>(ref args)).As<double, T>();
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return athis.YShuffleX3Kernel_Core(vector0.As<T, sbyte>(), vector1.As<T, sbyte>(), vector2.As<T, sbyte>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>>>(ref args)).As<sbyte, T>();
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return athis.YShuffleX3Kernel_Core(vector0.As<T, byte>(), vector1.As<T, byte>(), vector2.As<T, byte>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<byte>, Vector256<byte>, Vector256<byte>, Vector256<byte>>>(ref args)).As<byte, T>();
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return athis.YShuffleX3Kernel_Core(vector0.As<T, short>(), vector1.As<T, short>(), vector2.As<T, short>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<short>, Vector256<short>, Vector256<short>, Vector256<short>>>(ref args)).As<short, T>();
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return athis.YShuffleX3Kernel_Core(vector0.As<T, ushort>(), vector1.As<T, ushort>(), vector2.As<T, ushort>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<ushort>, Vector256<ushort>, Vector256<ushort>, Vector256<ushort>>>(ref args)).As<ushort, T>();
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return athis.YShuffleX3Kernel_Core(vector0.As<T, int>(), vector1.As<T, int>(), vector2.As<T, int>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>>>(ref args)).As<int, T>();
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return athis.YShuffleX3Kernel_Core(vector0.As<T, uint>(), vector1.As<T, uint>(), vector2.As<T, uint>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<uint>, Vector256<uint>, Vector256<uint>, Vector256<uint>>>(ref args)).As<uint, T>();
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return athis.YShuffleX3Kernel_Core(vector0.As<T, long>(), vector1.As<T, long>(), vector2.As<T, long>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>>>(ref args)).As<long, T>();
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return athis.YShuffleX3Kernel_Core(vector0.As<T, ulong>(), vector1.As<T, ulong>(), vector2.As<T, ulong>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<ulong>, Vector256<ulong>, Vector256<ulong>, Vector256<ulong>>>(ref args)).As<ulong, T>();
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
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX4_Args(indices.As<TIdx, sbyte>());
                args0 = a0.As<sbyte, TIdx>();
                args1 = a1.As<sbyte, TIdx>();
                args2 = a2.As<sbyte, TIdx>();
                args3 = a3.As<sbyte, TIdx>();
                args4 = a4.As<sbyte, TIdx>();
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX4_Args(indices.As<TIdx, byte>());
                args0 = a0.As<byte, TIdx>();
                args1 = a1.As<byte, TIdx>();
                args2 = a2.As<byte, TIdx>();
                args3 = a3.As<byte, TIdx>();
                args4 = a4.As<byte, TIdx>();
            } else if (typeof(short) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX4_Args(indices.As<TIdx, short>());
                args0 = a0.As<short, TIdx>();
                args1 = a1.As<short, TIdx>();
                args2 = a2.As<short, TIdx>();
                args3 = a3.As<short, TIdx>();
                args4 = a4.As<short, TIdx>();
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX4_Args(indices.As<TIdx, ushort>());
                args0 = a0.As<ushort, TIdx>();
                args1 = a1.As<ushort, TIdx>();
                args2 = a2.As<ushort, TIdx>();
                args3 = a3.As<ushort, TIdx>();
                args4 = a4.As<ushort, TIdx>();
            } else if (typeof(int) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX4_Args(indices.As<TIdx, int>());
                args0 = a0.As<int, TIdx>();
                args1 = a1.As<int, TIdx>();
                args2 = a2.As<int, TIdx>();
                args3 = a3.As<int, TIdx>();
                args4 = a4.As<int, TIdx>();
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX4_Args(indices.As<TIdx, uint>());
                args0 = a0.As<uint, TIdx>();
                args1 = a1.As<uint, TIdx>();
                args2 = a2.As<uint, TIdx>();
                args3 = a3.As<uint, TIdx>();
                args4 = a4.As<uint, TIdx>();
            } else if (typeof(long) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX4_Args(indices.As<TIdx, long>());
                args0 = a0.As<long, TIdx>();
                args1 = a1.As<long, TIdx>();
                args2 = a2.As<long, TIdx>();
                args3 = a3.As<long, TIdx>();
                args4 = a4.As<long, TIdx>();
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX4_Args(indices.As<TIdx, ulong>());
                args0 = a0.As<ulong, TIdx>();
                args1 = a1.As<ulong, TIdx>();
                args2 = a2.As<ulong, TIdx>();
                args3 = a3.As<ulong, TIdx>();
                args4 = a4.As<ulong, TIdx>();
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
                return athis.YShuffleX4_Core(vector0.As<T, float>(), vector1.As<T, float>(), vector2.As<T, float>(), vector3.As<T, float>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>>>(ref args)).As<float, T>();
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return athis.YShuffleX4_Core(vector0.As<T, double>(), vector1.As<T, double>(), vector2.As<T, double>(), vector3.As<T, double>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>>>(ref args)).As<double, T>();
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return athis.YShuffleX4_Core(vector0.As<T, sbyte>(), vector1.As<T, sbyte>(), vector2.As<T, sbyte>(), vector3.As<T, sbyte>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>>>(ref args)).As<sbyte, T>();
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return athis.YShuffleX4_Core(vector0.As<T, byte>(), vector1.As<T, byte>(), vector2.As<T, byte>(), vector3.As<T, byte>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<byte>, Vector256<byte>, Vector256<byte>, Vector256<byte>, Vector256<byte>>>(ref args)).As<byte, T>();
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return athis.YShuffleX4_Core(vector0.As<T, short>(), vector1.As<T, short>(), vector2.As<T, short>(), vector3.As<T, short>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<short>, Vector256<short>, Vector256<short>, Vector256<short>, Vector256<short>>>(ref args)).As<short, T>();
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return athis.YShuffleX4_Core(vector0.As<T, ushort>(), vector1.As<T, ushort>(), vector2.As<T, ushort>(), vector3.As<T, ushort>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<ushort>, Vector256<ushort>, Vector256<ushort>, Vector256<ushort>, Vector256<ushort>>>(ref args)).As<ushort, T>();
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return athis.YShuffleX4_Core(vector0.As<T, int>(), vector1.As<T, int>(), vector2.As<T, int>(), vector3.As<T, int>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>>>(ref args)).As<int, T>();
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return athis.YShuffleX4_Core(vector0.As<T, uint>(), vector1.As<T, uint>(), vector2.As<T, uint>(), vector3.As<T, uint>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<uint>, Vector256<uint>, Vector256<uint>, Vector256<uint>, Vector256<uint>>>(ref args)).As<uint, T>();
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return athis.YShuffleX4_Core(vector0.As<T, long>(), vector1.As<T, long>(), vector2.As<T, long>(), vector3.As<T, long>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>>>(ref args)).As<long, T>();
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return athis.YShuffleX4_Core(vector0.As<T, ulong>(), vector1.As<T, ulong>(), vector2.As<T, ulong>(), vector3.As<T, ulong>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<ulong>, Vector256<ulong>, Vector256<ulong>, Vector256<ulong>, Vector256<ulong>>>(ref args)).As<ulong, T>();
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
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX4Insert_Args(indices.As<TIdx, sbyte>());
                args0 = a0.As<sbyte, TIdx>();
                args1 = a1.As<sbyte, TIdx>();
                args2 = a2.As<sbyte, TIdx>();
                args3 = a3.As<sbyte, TIdx>();
                args4 = a4.As<sbyte, TIdx>();
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX4Insert_Args(indices.As<TIdx, byte>());
                args0 = a0.As<byte, TIdx>();
                args1 = a1.As<byte, TIdx>();
                args2 = a2.As<byte, TIdx>();
                args3 = a3.As<byte, TIdx>();
                args4 = a4.As<byte, TIdx>();
            } else if (typeof(short) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX4Insert_Args(indices.As<TIdx, short>());
                args0 = a0.As<short, TIdx>();
                args1 = a1.As<short, TIdx>();
                args2 = a2.As<short, TIdx>();
                args3 = a3.As<short, TIdx>();
                args4 = a4.As<short, TIdx>();
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX4Insert_Args(indices.As<TIdx, ushort>());
                args0 = a0.As<ushort, TIdx>();
                args1 = a1.As<ushort, TIdx>();
                args2 = a2.As<ushort, TIdx>();
                args3 = a3.As<ushort, TIdx>();
                args4 = a4.As<ushort, TIdx>();
            } else if (typeof(int) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX4Insert_Args(indices.As<TIdx, int>());
                args0 = a0.As<int, TIdx>();
                args1 = a1.As<int, TIdx>();
                args2 = a2.As<int, TIdx>();
                args3 = a3.As<int, TIdx>();
                args4 = a4.As<int, TIdx>();
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX4Insert_Args(indices.As<TIdx, uint>());
                args0 = a0.As<uint, TIdx>();
                args1 = a1.As<uint, TIdx>();
                args2 = a2.As<uint, TIdx>();
                args3 = a3.As<uint, TIdx>();
                args4 = a4.As<uint, TIdx>();
            } else if (typeof(long) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX4Insert_Args(indices.As<TIdx, long>());
                args0 = a0.As<long, TIdx>();
                args1 = a1.As<long, TIdx>();
                args2 = a2.As<long, TIdx>();
                args3 = a3.As<long, TIdx>();
                args4 = a4.As<long, TIdx>();
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = athis.YShuffleX4Insert_Args(indices.As<TIdx, ulong>());
                args0 = a0.As<ulong, TIdx>();
                args1 = a1.As<ulong, TIdx>();
                args2 = a2.As<ulong, TIdx>();
                args3 = a3.As<ulong, TIdx>();
                args4 = a4.As<ulong, TIdx>();
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
                return athis.YShuffleX4Insert_Core(back.As<T, float>(), vector0.As<T, float>(), vector1.As<T, float>(), vector2.As<T, float>(), vector3.As<T, float>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>>>(ref args)).As<float, T>();
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return athis.YShuffleX4Insert_Core(back.As<T, double>(), vector0.As<T, double>(), vector1.As<T, double>(), vector2.As<T, double>(), vector3.As<T, double>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>>>(ref args)).As<double, T>();
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return athis.YShuffleX4Insert_Core(back.As<T, sbyte>(), vector0.As<T, sbyte>(), vector1.As<T, sbyte>(), vector2.As<T, sbyte>(), vector3.As<T, sbyte>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>>>(ref args)).As<sbyte, T>();
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return athis.YShuffleX4Insert_Core(back.As<T, byte>(), vector0.As<T, byte>(), vector1.As<T, byte>(), vector2.As<T, byte>(), vector3.As<T, byte>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<byte>, Vector256<byte>, Vector256<byte>, Vector256<byte>, Vector256<byte>>>(ref args)).As<byte, T>();
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return athis.YShuffleX4Insert_Core(back.As<T, short>(), vector0.As<T, short>(), vector1.As<T, short>(), vector2.As<T, short>(), vector3.As<T, short>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<short>, Vector256<short>, Vector256<short>, Vector256<short>, Vector256<short>>>(ref args)).As<short, T>();
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return athis.YShuffleX4Insert_Core(back.As<T, ushort>(), vector0.As<T, ushort>(), vector1.As<T, ushort>(), vector2.As<T, ushort>(), vector3.As<T, ushort>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<ushort>, Vector256<ushort>, Vector256<ushort>, Vector256<ushort>, Vector256<ushort>>>(ref args)).As<ushort, T>();
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return athis.YShuffleX4Insert_Core(back.As<T, int>(), vector0.As<T, int>(), vector1.As<T, int>(), vector2.As<T, int>(), vector3.As<T, int>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>>>(ref args)).As<int, T>();
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return athis.YShuffleX4Insert_Core(back.As<T, uint>(), vector0.As<T, uint>(), vector1.As<T, uint>(), vector2.As<T, uint>(), vector3.As<T, uint>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<uint>, Vector256<uint>, Vector256<uint>, Vector256<uint>, Vector256<uint>>>(ref args)).As<uint, T>();
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return athis.YShuffleX4Insert_Core(back.As<T, long>(), vector0.As<T, long>(), vector1.As<T, long>(), vector2.As<T, long>(), vector3.As<T, long>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>>>(ref args)).As<long, T>();
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return athis.YShuffleX4Insert_Core(back.As<T, ulong>(), vector0.As<T, ulong>(), vector1.As<T, ulong>(), vector2.As<T, ulong>(), vector3.As<T, ulong>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<ulong>, Vector256<ulong>, Vector256<ulong>, Vector256<ulong>, Vector256<ulong>>>(ref args)).As<ulong, T>();
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
                (var a0, var a1, var a2, var a3) = athis.YShuffleX4Kernel_Args(indices.As<TIdx, sbyte>());
                args0 = a0.As<sbyte, TIdx>();
                args1 = a1.As<sbyte, TIdx>();
                args2 = a2.As<sbyte, TIdx>();
                args3 = a3.As<sbyte, TIdx>();
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = athis.YShuffleX4Kernel_Args(indices.As<TIdx, byte>());
                args0 = a0.As<byte, TIdx>();
                args1 = a1.As<byte, TIdx>();
                args2 = a2.As<byte, TIdx>();
                args3 = a3.As<byte, TIdx>();
            } else if (typeof(short) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = athis.YShuffleX4Kernel_Args(indices.As<TIdx, short>());
                args0 = a0.As<short, TIdx>();
                args1 = a1.As<short, TIdx>();
                args2 = a2.As<short, TIdx>();
                args3 = a3.As<short, TIdx>();
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = athis.YShuffleX4Kernel_Args(indices.As<TIdx, ushort>());
                args0 = a0.As<ushort, TIdx>();
                args1 = a1.As<ushort, TIdx>();
                args2 = a2.As<ushort, TIdx>();
                args3 = a3.As<ushort, TIdx>();
            } else if (typeof(int) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = athis.YShuffleX4Kernel_Args(indices.As<TIdx, int>());
                args0 = a0.As<int, TIdx>();
                args1 = a1.As<int, TIdx>();
                args2 = a2.As<int, TIdx>();
                args3 = a3.As<int, TIdx>();
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = athis.YShuffleX4Kernel_Args(indices.As<TIdx, uint>());
                args0 = a0.As<uint, TIdx>();
                args1 = a1.As<uint, TIdx>();
                args2 = a2.As<uint, TIdx>();
                args3 = a3.As<uint, TIdx>();
            } else if (typeof(long) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = athis.YShuffleX4Kernel_Args(indices.As<TIdx, long>());
                args0 = a0.As<long, TIdx>();
                args1 = a1.As<long, TIdx>();
                args2 = a2.As<long, TIdx>();
                args3 = a3.As<long, TIdx>();
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = athis.YShuffleX4Kernel_Args(indices.As<TIdx, ulong>());
                args0 = a0.As<ulong, TIdx>();
                args1 = a1.As<ulong, TIdx>();
                args2 = a2.As<ulong, TIdx>();
                args3 = a3.As<ulong, TIdx>();
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
                return athis.YShuffleX4Kernel_Core(vector0.As<T, float>(), vector1.As<T, float>(), vector2.As<T, float>(), vector3.As<T, float>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>>>(ref args)).As<float, T>();
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return athis.YShuffleX4Kernel_Core(vector0.As<T, double>(), vector1.As<T, double>(), vector2.As<T, double>(), vector3.As<T, double>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>>>(ref args)).As<double, T>();
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return athis.YShuffleX4Kernel_Core(vector0.As<T, sbyte>(), vector1.As<T, sbyte>(), vector2.As<T, sbyte>(), vector3.As<T, sbyte>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>, Vector256<sbyte>>>(ref args)).As<sbyte, T>();
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return athis.YShuffleX4Kernel_Core(vector0.As<T, byte>(), vector1.As<T, byte>(), vector2.As<T, byte>(), vector3.As<T, byte>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<byte>, Vector256<byte>, Vector256<byte>, Vector256<byte>>>(ref args)).As<byte, T>();
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return athis.YShuffleX4Kernel_Core(vector0.As<T, short>(), vector1.As<T, short>(), vector2.As<T, short>(), vector3.As<T, short>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<short>, Vector256<short>, Vector256<short>, Vector256<short>>>(ref args)).As<short, T>();
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return athis.YShuffleX4Kernel_Core(vector0.As<T, ushort>(), vector1.As<T, ushort>(), vector2.As<T, ushort>(), vector3.As<T, ushort>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<ushort>, Vector256<ushort>, Vector256<ushort>, Vector256<ushort>>>(ref args)).As<ushort, T>();
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return athis.YShuffleX4Kernel_Core(vector0.As<T, int>(), vector1.As<T, int>(), vector2.As<T, int>(), vector3.As<T, int>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<int>, Vector256<int>, Vector256<int>, Vector256<int>>>(ref args)).As<int, T>();
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return athis.YShuffleX4Kernel_Core(vector0.As<T, uint>(), vector1.As<T, uint>(), vector2.As<T, uint>(), vector3.As<T, uint>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<uint>, Vector256<uint>, Vector256<uint>, Vector256<uint>>>(ref args)).As<uint, T>();
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return athis.YShuffleX4Kernel_Core(vector0.As<T, long>(), vector1.As<T, long>(), vector2.As<T, long>(), vector3.As<T, long>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<long>, Vector256<long>, Vector256<long>, Vector256<long>>>(ref args)).As<long, T>();
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return athis.YShuffleX4Kernel_Core(vector0.As<T, ulong>(), vector1.As<T, ulong>(), vector2.As<T, ulong>(), vector3.As<T, ulong>(), Unsafe.As<ValueTuple<Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>, Vector256<TIdx>>, ValueTuple<Vector256<ulong>, Vector256<ulong>, Vector256<ulong>, Vector256<ulong>>>(ref args)).As<ulong, T>();
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
