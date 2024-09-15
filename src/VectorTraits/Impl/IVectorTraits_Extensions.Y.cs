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

        /// <inheritdoc cref="Vectors.YShuffleG4X2{T}(Vector{T}, Vector{T}, ShuffleControlG4)"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static (Vector<T> Result0, Vector<T> Result1) YShuffleG4X2<T>(this IVectorTraits athis, Vector<T> source0, Vector<T> source1, [ConstantExpected] ShuffleControlG4 control) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector<float>)(object)source0, (Vector<float>)(object)source1, control);
                return ((Vector<T>)(object)result0, (Vector<T>)(object)result1);
            } else if (typeof(double) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector<double>)(object)source0, (Vector<double>)(object)source1, control);
                return ((Vector<T>)(object)result0, (Vector<T>)(object)result1);
            } else if (typeof(sbyte) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector<sbyte>)(object)source0, (Vector<sbyte>)(object)source1, control);
                return ((Vector<T>)(object)result0, (Vector<T>)(object)result1);
            } else if (typeof(byte) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector<byte>)(object)source0, (Vector<byte>)(object)source1, control);
                return ((Vector<T>)(object)result0, (Vector<T>)(object)result1);
            } else if (typeof(short) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector<short>)(object)source0, (Vector<short>)(object)source1, control);
                return ((Vector<T>)(object)result0, (Vector<T>)(object)result1);
            } else if (typeof(ushort) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector<ushort>)(object)source0, (Vector<ushort>)(object)source1, control);
                return ((Vector<T>)(object)result0, (Vector<T>)(object)result1);
            } else if (typeof(int) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector<int>)(object)source0, (Vector<int>)(object)source1, control);
                return ((Vector<T>)(object)result0, (Vector<T>)(object)result1);
            } else if (typeof(uint) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector<uint>)(object)source0, (Vector<uint>)(object)source1, control);
                return ((Vector<T>)(object)result0, (Vector<T>)(object)result1);
            } else if (typeof(long) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector<long>)(object)source0, (Vector<long>)(object)source1, control);
                return ((Vector<T>)(object)result0, (Vector<T>)(object)result1);
            } else if (typeof(ulong) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector<ulong>)(object)source0, (Vector<ulong>)(object)source1, control);
                return ((Vector<T>)(object)result0, (Vector<T>)(object)result1);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vectors.YShuffleG4X2(Vector{float}, Vector{float}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<float> Result0, Vector<float> Result1) YShuffleG4X2(this IVectorTraits athis, Vector<float> source0, Vector<float> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vectors.YShuffleG4X2(Vector{double}, Vector{double}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<double> Result0, Vector<double> Result1) YShuffleG4X2(this IVectorTraits athis, Vector<double> source0, Vector<double> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vectors.YShuffleG4X2(Vector{sbyte}, Vector{sbyte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> Result0, Vector<sbyte> Result1) YShuffleG4X2(this IVectorTraits athis, Vector<sbyte> source0, Vector<sbyte> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vectors.YShuffleG4X2(Vector{byte}, Vector{byte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> Result0, Vector<byte> Result1) YShuffleG4X2(this IVectorTraits athis, Vector<byte> source0, Vector<byte> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vectors.YShuffleG4X2(Vector{short}, Vector{short}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> Result0, Vector<short> Result1) YShuffleG4X2(this IVectorTraits athis, Vector<short> source0, Vector<short> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vectors.YShuffleG4X2(Vector{ushort}, Vector{ushort}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> Result0, Vector<ushort> Result1) YShuffleG4X2(this IVectorTraits athis, Vector<ushort> source0, Vector<ushort> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vectors.YShuffleG4X2(Vector{int}, Vector{int}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> Result0, Vector<int> Result1) YShuffleG4X2(this IVectorTraits athis, Vector<int> source0, Vector<int> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vectors.YShuffleG4X2(Vector{uint}, Vector{uint}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> Result0, Vector<uint> Result1) YShuffleG4X2(this IVectorTraits athis, Vector<uint> source0, Vector<uint> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vectors.YShuffleG4X2(Vector{long}, Vector{long}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> Result0, Vector<long> Result1) YShuffleG4X2(this IVectorTraits athis, Vector<long> source0, Vector<long> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vectors.YShuffleG4X2(Vector{ulong}, Vector{ulong}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> Result0, Vector<ulong> Result1) YShuffleG4X2(this IVectorTraits athis, Vector<ulong> source0, Vector<ulong> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vectors.YShuffleG4X2_Const{T}(Vector{T}, Vector{T}, ShuffleControlG4)"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static (Vector<T> Result0, Vector<T> Result1) YShuffleG4X2_Const<T>(this IVectorTraits athis, Vector<T> source0, Vector<T> source1, [ConstantExpected] ShuffleControlG4 control) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector<float>)(object)source0, (Vector<float>)(object)source1, control);
                return ((Vector<T>)(object)result0, (Vector<T>)(object)result1);
            } else if (typeof(double) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector<double>)(object)source0, (Vector<double>)(object)source1, control);
                return ((Vector<T>)(object)result0, (Vector<T>)(object)result1);
            } else if (typeof(sbyte) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector<sbyte>)(object)source0, (Vector<sbyte>)(object)source1, control);
                return ((Vector<T>)(object)result0, (Vector<T>)(object)result1);
            } else if (typeof(byte) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector<byte>)(object)source0, (Vector<byte>)(object)source1, control);
                return ((Vector<T>)(object)result0, (Vector<T>)(object)result1);
            } else if (typeof(short) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector<short>)(object)source0, (Vector<short>)(object)source1, control);
                return ((Vector<T>)(object)result0, (Vector<T>)(object)result1);
            } else if (typeof(ushort) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector<ushort>)(object)source0, (Vector<ushort>)(object)source1, control);
                return ((Vector<T>)(object)result0, (Vector<T>)(object)result1);
            } else if (typeof(int) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector<int>)(object)source0, (Vector<int>)(object)source1, control);
                return ((Vector<T>)(object)result0, (Vector<T>)(object)result1);
            } else if (typeof(uint) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector<uint>)(object)source0, (Vector<uint>)(object)source1, control);
                return ((Vector<T>)(object)result0, (Vector<T>)(object)result1);
            } else if (typeof(long) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector<long>)(object)source0, (Vector<long>)(object)source1, control);
                return ((Vector<T>)(object)result0, (Vector<T>)(object)result1);
            } else if (typeof(ulong) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector<ulong>)(object)source0, (Vector<ulong>)(object)source1, control);
                return ((Vector<T>)(object)result0, (Vector<T>)(object)result1);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vectors.YShuffleG4X2_Const(Vector{float}, Vector{float}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<float> Result0, Vector<float> Result1) YShuffleG4X2_Const(this IVectorTraits athis, Vector<float> source0, Vector<float> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vectors.YShuffleG4X2_Const(Vector{double}, Vector{double}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<double> Result0, Vector<double> Result1) YShuffleG4X2_Const(this IVectorTraits athis, Vector<double> source0, Vector<double> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vectors.YShuffleG4X2_Const(Vector{sbyte}, Vector{sbyte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> Result0, Vector<sbyte> Result1) YShuffleG4X2_Const(this IVectorTraits athis, Vector<sbyte> source0, Vector<sbyte> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vectors.YShuffleG4X2_Const(Vector{byte}, Vector{byte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> Result0, Vector<byte> Result1) YShuffleG4X2_Const(this IVectorTraits athis, Vector<byte> source0, Vector<byte> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vectors.YShuffleG4X2_Const(Vector{short}, Vector{short}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> Result0, Vector<short> Result1) YShuffleG4X2_Const(this IVectorTraits athis, Vector<short> source0, Vector<short> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vectors.YShuffleG4X2_Const(Vector{ushort}, Vector{ushort}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> Result0, Vector<ushort> Result1) YShuffleG4X2_Const(this IVectorTraits athis, Vector<ushort> source0, Vector<ushort> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vectors.YShuffleG4X2_Const(Vector{int}, Vector{int}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> Result0, Vector<int> Result1) YShuffleG4X2_Const(this IVectorTraits athis, Vector<int> source0, Vector<int> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vectors.YShuffleG4X2_Const(Vector{uint}, Vector{uint}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> Result0, Vector<uint> Result1) YShuffleG4X2_Const(this IVectorTraits athis, Vector<uint> source0, Vector<uint> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vectors.YShuffleG4X2_Const(Vector{long}, Vector{long}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> Result0, Vector<long> Result1) YShuffleG4X2_Const(this IVectorTraits athis, Vector<long> source0, Vector<long> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vectors.YShuffleG4X2_Const(Vector{ulong}, Vector{ulong}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> Result0, Vector<ulong> Result1) YShuffleG4X2_Const(this IVectorTraits athis, Vector<ulong> source0, Vector<ulong> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }


        /// <inheritdoc cref="Vectors.YShuffleInsert_Args{TIdx}(Vector{TIdx}, out Vector{TIdx}, out Vector{TIdx}, out Vector{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleInsert_Args<TIdx>(this IVectorTraits athis, Vector<TIdx> indices, out Vector<TIdx> args0, out Vector<TIdx> args1, out Vector<TIdx> args2)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a0, var a1, var a2) = athis.YShuffleInsert_Args((Vector<sbyte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a0;
                args1 = (Vector<TIdx>)(object)a1;
                args2 = (Vector<TIdx>)(object)a2;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a0, var a1, var a2) = athis.YShuffleInsert_Args((Vector<byte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a0;
                args1 = (Vector<TIdx>)(object)a1;
                args2 = (Vector<TIdx>)(object)a2;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a0, var a1, var a2) = athis.YShuffleInsert_Args((Vector<short>)(object)indices);
                args0 = (Vector<TIdx>)(object)a0;
                args1 = (Vector<TIdx>)(object)a1;
                args2 = (Vector<TIdx>)(object)a2;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a0, var a1, var a2) = athis.YShuffleInsert_Args((Vector<ushort>)(object)indices);
                args0 = (Vector<TIdx>)(object)a0;
                args1 = (Vector<TIdx>)(object)a1;
                args2 = (Vector<TIdx>)(object)a2;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a0, var a1, var a2) = athis.YShuffleInsert_Args((Vector<int>)(object)indices);
                args0 = (Vector<TIdx>)(object)a0;
                args1 = (Vector<TIdx>)(object)a1;
                args2 = (Vector<TIdx>)(object)a2;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a0, var a1, var a2) = athis.YShuffleInsert_Args((Vector<uint>)(object)indices);
                args0 = (Vector<TIdx>)(object)a0;
                args1 = (Vector<TIdx>)(object)a1;
                args2 = (Vector<TIdx>)(object)a2;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a0, var a1, var a2) = athis.YShuffleInsert_Args((Vector<long>)(object)indices);
                args0 = (Vector<TIdx>)(object)a0;
                args1 = (Vector<TIdx>)(object)a1;
                args2 = (Vector<TIdx>)(object)a2;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a0, var a1, var a2) = athis.YShuffleInsert_Args((Vector<ulong>)(object)indices);
                args0 = (Vector<TIdx>)(object)a0;
                args1 = (Vector<TIdx>)(object)a1;
                args2 = (Vector<TIdx>)(object)a2;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vectors.YShuffleInsert_Args{TIdx}(Vector{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static (Vector<TIdx> args0, Vector<TIdx> args1, Vector<TIdx> args2) YShuffleInsert_Args<TIdx>(this IVectorTraits athis, Vector<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleInsert_Args<TIdx>(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <inheritdoc cref="Vectors.YShuffleInsert_Args(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2) YShuffleInsert_Args(this IVectorTraits athis, Vector<sbyte> indices) {
            athis.YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <inheritdoc cref="Vectors.YShuffleInsert_Args(Vector{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> args0, Vector<byte> args1, Vector<byte> args2) YShuffleInsert_Args(this IVectorTraits athis, Vector<byte> indices) {
            athis.YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <inheritdoc cref="Vectors.YShuffleInsert_Args(Vector{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> args0, Vector<short> args1, Vector<short> args2) YShuffleInsert_Args(this IVectorTraits athis, Vector<short> indices) {
            athis.YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <inheritdoc cref="Vectors.YShuffleInsert_Args(Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2) YShuffleInsert_Args(this IVectorTraits athis, Vector<ushort> indices) {
            athis.YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <inheritdoc cref="Vectors.YShuffleInsert_Args(Vector{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> args0, Vector<int> args1, Vector<int> args2) YShuffleInsert_Args(this IVectorTraits athis, Vector<int> indices) {
            athis.YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <inheritdoc cref="Vectors.YShuffleInsert_Args(Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> args0, Vector<uint> args1, Vector<uint> args2) YShuffleInsert_Args(this IVectorTraits athis, Vector<uint> indices) {
            athis.YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <inheritdoc cref="Vectors.YShuffleInsert_Args(Vector{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> args0, Vector<long> args1, Vector<long> args2) YShuffleInsert_Args(this IVectorTraits athis, Vector<long> indices) {
            athis.YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <inheritdoc cref="Vectors.YShuffleInsert_Args(Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2) YShuffleInsert_Args(this IVectorTraits athis, Vector<ulong> indices) {
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
        /// <seealso cref="IVectorTraits.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleInsert_Core(Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<T> YShuffleInsert_Core<T, TIdx>(this IVectorTraits athis, Vector<T> back, Vector<T> vector, (Vector<TIdx> args0, Vector<TIdx> args1, Vector<TIdx> args2) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleInsert_Core((Vector<float>)(object)back, (Vector<float>)(object)vector, (ValueTuple<Vector<int>, Vector<int>, Vector<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleInsert_Core((Vector<double>)(object)back, (Vector<double>)(object)vector, (ValueTuple<Vector<long>, Vector<long>, Vector<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleInsert_Core((Vector<sbyte>)(object)back, (Vector<sbyte>)(object)vector, (ValueTuple<Vector<sbyte>, Vector<sbyte>, Vector<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleInsert_Core((Vector<byte>)(object)back, (Vector<byte>)(object)vector, (ValueTuple<Vector<byte>, Vector<byte>, Vector<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleInsert_Core((Vector<short>)(object)back, (Vector<short>)(object)vector, (ValueTuple<Vector<short>, Vector<short>, Vector<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleInsert_Core((Vector<ushort>)(object)back, (Vector<ushort>)(object)vector, (ValueTuple<Vector<ushort>, Vector<ushort>, Vector<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleInsert_Core((Vector<int>)(object)back, (Vector<int>)(object)vector, (ValueTuple<Vector<int>, Vector<int>, Vector<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleInsert_Core((Vector<uint>)(object)back, (Vector<uint>)(object)vector, (ValueTuple<Vector<uint>, Vector<uint>, Vector<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleInsert_Core((Vector<long>)(object)back, (Vector<long>)(object)vector, (ValueTuple<Vector<long>, Vector<long>, Vector<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleInsert_Core((Vector<ulong>)(object)back, (Vector<ulong>)(object)vector, (ValueTuple<Vector<ulong>, Vector<ulong>, Vector<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vectors.YShuffleInsert_Core(Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<float> YShuffleInsert_Core(this IVectorTraits athis, Vector<float> back, Vector<float> vector, (Vector<int> args0, Vector<int> args1, Vector<int> args2) args) {
            return athis.YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <inheritdoc cref="Vectors.YShuffleInsert_Core(Vector{double}, Vector{double}, ValueTuple{Vector{long}, Vector{long}, Vector{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<double> YShuffleInsert_Core(this IVectorTraits athis, Vector<double> back, Vector<double> vector, (Vector<long> args0, Vector<long> args1, Vector<long> args2) args) {
            return athis.YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <inheritdoc cref="Vectors.YShuffleInsert_Core(Vector{sbyte}, Vector{sbyte}, ValueTuple{Vector{sbyte}, Vector{sbyte}, Vector{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> YShuffleInsert_Core(this IVectorTraits athis, Vector<sbyte> back, Vector<sbyte> vector, (Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2) args) {
            return athis.YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <inheritdoc cref="Vectors.YShuffleInsert_Core(Vector{byte}, Vector{byte}, ValueTuple{Vector{byte}, Vector{byte}, Vector{byte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> YShuffleInsert_Core(this IVectorTraits athis, Vector<byte> back, Vector<byte> vector, (Vector<byte> args0, Vector<byte> args1, Vector<byte> args2) args) {
            return athis.YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <inheritdoc cref="Vectors.YShuffleInsert_Core(Vector{short}, Vector{short}, ValueTuple{Vector{short}, Vector{short}, Vector{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> YShuffleInsert_Core(this IVectorTraits athis, Vector<short> back, Vector<short> vector, (Vector<short> args0, Vector<short> args1, Vector<short> args2) args) {
            return athis.YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <inheritdoc cref="Vectors.YShuffleInsert_Core(Vector{ushort}, Vector{ushort}, ValueTuple{Vector{ushort}, Vector{ushort}, Vector{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> YShuffleInsert_Core(this IVectorTraits athis, Vector<ushort> back, Vector<ushort> vector, (Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2) args) {
            return athis.YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <inheritdoc cref="Vectors.YShuffleInsert_Core(Vector{int}, Vector{int}, ValueTuple{Vector{int}, Vector{int}, Vector{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> YShuffleInsert_Core(this IVectorTraits athis, Vector<int> back, Vector<int> vector, (Vector<int> args0, Vector<int> args1, Vector<int> args2) args) {
            return athis.YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <inheritdoc cref="Vectors.YShuffleInsert_Core(Vector{uint}, Vector{uint}, ValueTuple{Vector{uint}, Vector{uint}, Vector{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> YShuffleInsert_Core(this IVectorTraits athis, Vector<uint> back, Vector<uint> vector, (Vector<uint> args0, Vector<uint> args1, Vector<uint> args2) args) {
            return athis.YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <inheritdoc cref="Vectors.YShuffleInsert_Core(Vector{long}, Vector{long}, ValueTuple{Vector{long}, Vector{long}, Vector{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> YShuffleInsert_Core(this IVectorTraits athis, Vector<long> back, Vector<long> vector, (Vector<long> args0, Vector<long> args1, Vector<long> args2) args) {
            return athis.YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <inheritdoc cref="Vectors.YShuffleInsert_Core(Vector{ulong}, Vector{ulong}, ValueTuple{Vector{ulong}, Vector{ulong}, Vector{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> YShuffleInsert_Core(this IVectorTraits athis, Vector<ulong> back, Vector<ulong> vector, (Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2) args) {
            return athis.YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }


        /// <inheritdoc cref="Vectors.YShuffleKernel_Args{TIdx}(Vector{TIdx}, out Vector{TIdx}, out Vector{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleKernel_Args<TIdx>(this IVectorTraits athis, Vector<TIdx> indices, out Vector<TIdx> args0, out Vector<TIdx> args1)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b) = athis.YShuffleKernel_Args((Vector<sbyte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b) = athis.YShuffleKernel_Args((Vector<byte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b) = athis.YShuffleKernel_Args((Vector<short>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b) = athis.YShuffleKernel_Args((Vector<ushort>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b) = athis.YShuffleKernel_Args((Vector<int>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b) = athis.YShuffleKernel_Args((Vector<uint>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b) = athis.YShuffleKernel_Args((Vector<long>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b) = athis.YShuffleKernel_Args((Vector<ulong>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vectors.YShuffleKernel_Args{TIdx}(Vector{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<TIdx> args0, Vector<TIdx> args1) YShuffleKernel_Args<TIdx>(this IVectorTraits athis, Vector<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleKernel_Args<TIdx>(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vectors.YShuffleKernel_Args(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> args0, Vector<sbyte> args1) YShuffleKernel_Args(this IVectorTraits athis, Vector<sbyte> indices) {
            athis.YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vectors.YShuffleKernel_Args(Vector{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> args0, Vector<byte> args1) YShuffleKernel_Args(this IVectorTraits athis, Vector<byte> indices) {
            athis.YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vectors.YShuffleKernel_Args(Vector{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> args0, Vector<short> args1) YShuffleKernel_Args(this IVectorTraits athis, Vector<short> indices) {
            athis.YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vectors.YShuffleKernel_Args(Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> args0, Vector<ushort> args1) YShuffleKernel_Args(this IVectorTraits athis, Vector<ushort> indices) {
            athis.YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vectors.YShuffleKernel_Args(Vector{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> args0, Vector<int> args1) YShuffleKernel_Args(this IVectorTraits athis, Vector<int> indices) {
            athis.YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vectors.YShuffleKernel_Args(Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> args0, Vector<uint> args1) YShuffleKernel_Args(this IVectorTraits athis, Vector<uint> indices) {
            athis.YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vectors.YShuffleKernel_Args(Vector{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> args0, Vector<long> args1) YShuffleKernel_Args(this IVectorTraits athis, Vector<long> indices) {
            athis.YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vectors.YShuffleKernel_Args(Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> args0, Vector<ulong> args1) YShuffleKernel_Args(this IVectorTraits athis, Vector<ulong> indices) {
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
        /// <seealso cref="IVectorTraits.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleKernel_Core(Vector{float}, Vector{int}, Vector{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<T> YShuffleKernel_Core<T, TIdx>(this IVectorTraits athis, Vector<T> vector, (Vector<TIdx> args0, Vector<TIdx> args1) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleKernel_Core((Vector<float>)(object)vector, (ValueTuple<Vector<int>, Vector<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleKernel_Core((Vector<double>)(object)vector, (ValueTuple<Vector<long>, Vector<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleKernel_Core((Vector<sbyte>)(object)vector, (ValueTuple<Vector<sbyte>, Vector<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleKernel_Core((Vector<byte>)(object)vector, (ValueTuple<Vector<byte>, Vector<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleKernel_Core((Vector<short>)(object)vector, (ValueTuple<Vector<short>, Vector<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleKernel_Core((Vector<ushort>)(object)vector, (ValueTuple<Vector<ushort>, Vector<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleKernel_Core((Vector<int>)(object)vector, (ValueTuple<Vector<int>, Vector<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleKernel_Core((Vector<uint>)(object)vector, (ValueTuple<Vector<uint>, Vector<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleKernel_Core((Vector<long>)(object)vector, (ValueTuple<Vector<long>, Vector<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleKernel_Core((Vector<ulong>)(object)vector, (ValueTuple<Vector<ulong>, Vector<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vectors.YShuffleKernel_Core(Vector{float}, ValueTuple{Vector{int}, Vector{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<float> YShuffleKernel_Core(this IVectorTraits athis, Vector<float> vector, (Vector<int> args0, Vector<int> args1) args) {
            return athis.YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vectors.YShuffleKernel_Core(Vector{double}, ValueTuple{Vector{long}, Vector{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<double> YShuffleKernel_Core(this IVectorTraits athis, Vector<double> vector, (Vector<long> args0, Vector<long> args1) args) {
            return athis.YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vectors.YShuffleKernel_Core(Vector{sbyte}, ValueTuple{Vector{sbyte}, Vector{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> YShuffleKernel_Core(this IVectorTraits athis, Vector<sbyte> vector, (Vector<sbyte> args0, Vector<sbyte> args1) args) {
            return athis.YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vectors.YShuffleKernel_Core(Vector{byte}, ValueTuple{Vector{byte}, Vector{byte}})"/>
        [CLSCompliant(false)]
        public static Vector<byte> YShuffleKernel_Core(this IVectorTraits athis, Vector<byte> vector, (Vector<byte> args0, Vector<byte> args1) args) {
            return athis.YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vectors.YShuffleKernel_Core(Vector{short}, ValueTuple{Vector{short}, Vector{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> YShuffleKernel_Core(this IVectorTraits athis, Vector<short> vector, (Vector<short> args0, Vector<short> args1) args) {
            return athis.YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vectors.YShuffleKernel_Core(Vector{ushort}, ValueTuple{Vector{ushort}, Vector{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> YShuffleKernel_Core(this IVectorTraits athis, Vector<ushort> vector, (Vector<ushort> args0, Vector<ushort> args1) args) {
            return athis.YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vectors.YShuffleKernel_Core(Vector{int}, ValueTuple{Vector{int}, Vector{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> YShuffleKernel_Core(this IVectorTraits athis, Vector<int> vector, (Vector<int> args0, Vector<int> args1) args) {
            return athis.YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vectors.YShuffleKernel_Core(Vector{uint}, ValueTuple{Vector{uint}, Vector{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> YShuffleKernel_Core(this IVectorTraits athis, Vector<uint> vector, (Vector<uint> args0, Vector<uint> args1) args) {
            return athis.YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vectors.YShuffleKernel_Core(Vector{long}, ValueTuple{Vector{long}, Vector{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> YShuffleKernel_Core(this IVectorTraits athis, Vector<long> vector, (Vector<long> args0, Vector<long> args1) args) {
            return athis.YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vectors.YShuffleKernel_Core(Vector{ulong}, ValueTuple{Vector{ulong}, Vector{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> YShuffleKernel_Core(this IVectorTraits athis, Vector<ulong> vector, (Vector<ulong> args0, Vector<ulong> args1) args) {
            return athis.YShuffleKernel_Core(vector, args.args0, args.args1);
        }


        /// <inheritdoc cref="Vectors.YShuffleX2_Args{TIdx}(Vector{TIdx}, out Vector{TIdx}, out Vector{TIdx}, out Vector{TIdx}, out Vector{TIdx}, out Vector{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleX2_Args<TIdx>(this IVectorTraits athis, Vector<TIdx> indices, out Vector<TIdx> args0, out Vector<TIdx> args1, out Vector<TIdx> args2, out Vector<TIdx> args3, out Vector<TIdx> args4)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2_Args((Vector<sbyte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2_Args((Vector<byte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2_Args((Vector<short>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2_Args((Vector<ushort>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2_Args((Vector<int>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2_Args((Vector<uint>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2_Args((Vector<long>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2_Args((Vector<ulong>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vectors.YShuffleX2_Args{TIdx}(Vector{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<TIdx> args0, Vector<TIdx> args1, Vector<TIdx> args2, Vector<TIdx> args3, Vector<TIdx> args4) YShuffleX2_Args<TIdx>(this IVectorTraits athis, Vector<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2_Args(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4) YShuffleX2_Args(this IVectorTraits athis, Vector<sbyte> indices) {
            athis.YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2_Args(Vector{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4) YShuffleX2_Args(this IVectorTraits athis, Vector<byte> indices) {
            athis.YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2_Args(Vector{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4) YShuffleX2_Args(this IVectorTraits athis, Vector<short> indices) {
            athis.YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2_Args(Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4) YShuffleX2_Args(this IVectorTraits athis, Vector<ushort> indices) {
            athis.YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2_Args(Vector{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) YShuffleX2_Args(this IVectorTraits athis, Vector<int> indices) {
            athis.YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2_Args(Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4) YShuffleX2_Args(this IVectorTraits athis, Vector<uint> indices) {
            athis.YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2_Args(Vector{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) YShuffleX2_Args(this IVectorTraits athis, Vector<long> indices) {
            athis.YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2_Args(Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4) YShuffleX2_Args(this IVectorTraits athis, Vector<ulong> indices) {
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
        /// <seealso cref="IVectorTraits.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleX2_Core(Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<T> YShuffleX2_Core<T, TIdx>(this IVectorTraits athis, Vector<T> vector0, Vector<T> vector1, (Vector<TIdx> args0, Vector<TIdx> args1, Vector<TIdx> args2, Vector<TIdx> args3, Vector<TIdx> args4) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX2_Core((Vector<float>)(object)vector0, (Vector<float>)(object)vector1, (ValueTuple<Vector<int>, Vector<int>, Vector<int>, Vector<int>, Vector<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX2_Core((Vector<double>)(object)vector0, (Vector<double>)(object)vector1, (ValueTuple<Vector<long>, Vector<long>, Vector<long>, Vector<long>, Vector<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX2_Core((Vector<sbyte>)(object)vector0, (Vector<sbyte>)(object)vector1, (ValueTuple<Vector<sbyte>, Vector<sbyte>, Vector<sbyte>, Vector<sbyte>, Vector<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX2_Core((Vector<byte>)(object)vector0, (Vector<byte>)(object)vector1, (ValueTuple<Vector<byte>, Vector<byte>, Vector<byte>, Vector<byte>, Vector<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX2_Core((Vector<short>)(object)vector0, (Vector<short>)(object)vector1, (ValueTuple<Vector<short>, Vector<short>, Vector<short>, Vector<short>, Vector<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX2_Core((Vector<ushort>)(object)vector0, (Vector<ushort>)(object)vector1, (ValueTuple<Vector<ushort>, Vector<ushort>, Vector<ushort>, Vector<ushort>, Vector<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX2_Core((Vector<int>)(object)vector0, (Vector<int>)(object)vector1, (ValueTuple<Vector<int>, Vector<int>, Vector<int>, Vector<int>, Vector<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX2_Core((Vector<uint>)(object)vector0, (Vector<uint>)(object)vector1, (ValueTuple<Vector<uint>, Vector<uint>, Vector<uint>, Vector<uint>, Vector<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX2_Core((Vector<long>)(object)vector0, (Vector<long>)(object)vector1, (ValueTuple<Vector<long>, Vector<long>, Vector<long>, Vector<long>, Vector<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX2_Core((Vector<ulong>)(object)vector0, (Vector<ulong>)(object)vector1, (ValueTuple<Vector<ulong>, Vector<ulong>, Vector<ulong>, Vector<ulong>, Vector<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vectors.YShuffleX2_Core(Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<float> YShuffleX2_Core(this IVectorTraits athis, Vector<float> vector0, Vector<float> vector1, (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) args) {
            return athis.YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2_Core(Vector{double}, Vector{double}, ValueTuple{Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<double> YShuffleX2_Core(this IVectorTraits athis, Vector<double> vector0, Vector<double> vector1, (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) args) {
            return athis.YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2_Core(Vector{sbyte}, Vector{sbyte}, ValueTuple{Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> YShuffleX2_Core(this IVectorTraits athis, Vector<sbyte> vector0, Vector<sbyte> vector1, (Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4) args) {
            return athis.YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2_Core(Vector{byte}, Vector{byte}, ValueTuple{Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> YShuffleX2_Core(this IVectorTraits athis, Vector<byte> vector0, Vector<byte> vector1, (Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4) args) {
            return athis.YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2_Core(Vector{short}, Vector{short}, ValueTuple{Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> YShuffleX2_Core(this IVectorTraits athis, Vector<short> vector0, Vector<short> vector1, (Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4) args) {
            return athis.YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2_Core(Vector{ushort}, Vector{ushort}, ValueTuple{Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> YShuffleX2_Core(this IVectorTraits athis, Vector<ushort> vector0, Vector<ushort> vector1, (Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4) args) {
            return athis.YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2_Core(Vector{int}, Vector{int}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> YShuffleX2_Core(this IVectorTraits athis, Vector<int> vector0, Vector<int> vector1, (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) args) {
            return athis.YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2_Core(Vector{uint}, Vector{uint}, ValueTuple{Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> YShuffleX2_Core(this IVectorTraits athis, Vector<uint> vector0, Vector<uint> vector1, (Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4) args) {
            return athis.YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2_Core(Vector{long}, Vector{long}, ValueTuple{Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> YShuffleX2_Core(this IVectorTraits athis, Vector<long> vector0, Vector<long> vector1, (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) args) {
            return athis.YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2_Core(Vector{ulong}, Vector{ulong}, ValueTuple{Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> YShuffleX2_Core(this IVectorTraits athis, Vector<ulong> vector0, Vector<ulong> vector1, (Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4) args) {
            return athis.YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }


        /// <inheritdoc cref="Vectors.YShuffleX2Insert_Args{TIdx}(Vector{TIdx}, out Vector{TIdx}, out Vector{TIdx}, out Vector{TIdx}, out Vector{TIdx}, out Vector{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleX2Insert_Args<TIdx>(this IVectorTraits athis, Vector<TIdx> indices, out Vector<TIdx> args0, out Vector<TIdx> args1, out Vector<TIdx> args2, out Vector<TIdx> args3, out Vector<TIdx> args4)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2Insert_Args((Vector<sbyte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2Insert_Args((Vector<byte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2Insert_Args((Vector<short>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2Insert_Args((Vector<ushort>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2Insert_Args((Vector<int>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2Insert_Args((Vector<uint>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2Insert_Args((Vector<long>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2Insert_Args((Vector<ulong>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vectors.YShuffleX2Insert_Args{TIdx}(Vector{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<TIdx> args0, Vector<TIdx> args1, Vector<TIdx> args2, Vector<TIdx> args3, Vector<TIdx> args4) YShuffleX2Insert_Args<TIdx>(this IVectorTraits athis, Vector<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2Insert_Args(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4) YShuffleX2Insert_Args(this IVectorTraits athis, Vector<sbyte> indices) {
            athis.YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2Insert_Args(Vector{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4) YShuffleX2Insert_Args(this IVectorTraits athis, Vector<byte> indices) {
            athis.YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2Insert_Args(Vector{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4) YShuffleX2Insert_Args(this IVectorTraits athis, Vector<short> indices) {
            athis.YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2Insert_Args(Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4) YShuffleX2Insert_Args(this IVectorTraits athis, Vector<ushort> indices) {
            athis.YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2Insert_Args(Vector{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) YShuffleX2Insert_Args(this IVectorTraits athis, Vector<int> indices) {
            athis.YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2Insert_Args(Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4) YShuffleX2Insert_Args(this IVectorTraits athis, Vector<uint> indices) {
            athis.YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2Insert_Args(Vector{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) YShuffleX2Insert_Args(this IVectorTraits athis, Vector<long> indices) {
            athis.YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2Insert_Args(Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4) YShuffleX2Insert_Args(this IVectorTraits athis, Vector<ulong> indices) {
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
        /// <seealso cref="IVectorTraits.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleX2Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<T> YShuffleX2Insert_Core<T, TIdx>(this IVectorTraits athis, Vector<T> back, Vector<T> vector0, Vector<T> vector1, (Vector<TIdx> args0, Vector<TIdx> args1, Vector<TIdx> args2, Vector<TIdx> args3, Vector<TIdx> args4) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX2Insert_Core((Vector<float>)(object)back, (Vector<float>)(object)vector0, (Vector<float>)(object)vector1, (ValueTuple<Vector<int>, Vector<int>, Vector<int>, Vector<int>, Vector<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX2Insert_Core((Vector<double>)(object)back, (Vector<double>)(object)vector0, (Vector<double>)(object)vector1, (ValueTuple<Vector<long>, Vector<long>, Vector<long>, Vector<long>, Vector<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX2Insert_Core((Vector<sbyte>)(object)back, (Vector<sbyte>)(object)vector0, (Vector<sbyte>)(object)vector1, (ValueTuple<Vector<sbyte>, Vector<sbyte>, Vector<sbyte>, Vector<sbyte>, Vector<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX2Insert_Core((Vector<byte>)(object)back, (Vector<byte>)(object)vector0, (Vector<byte>)(object)vector1, (ValueTuple<Vector<byte>, Vector<byte>, Vector<byte>, Vector<byte>, Vector<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX2Insert_Core((Vector<short>)(object)back, (Vector<short>)(object)vector0, (Vector<short>)(object)vector1, (ValueTuple<Vector<short>, Vector<short>, Vector<short>, Vector<short>, Vector<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX2Insert_Core((Vector<ushort>)(object)back, (Vector<ushort>)(object)vector0, (Vector<ushort>)(object)vector1, (ValueTuple<Vector<ushort>, Vector<ushort>, Vector<ushort>, Vector<ushort>, Vector<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX2Insert_Core((Vector<int>)(object)back, (Vector<int>)(object)vector0, (Vector<int>)(object)vector1, (ValueTuple<Vector<int>, Vector<int>, Vector<int>, Vector<int>, Vector<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX2Insert_Core((Vector<uint>)(object)back, (Vector<uint>)(object)vector0, (Vector<uint>)(object)vector1, (ValueTuple<Vector<uint>, Vector<uint>, Vector<uint>, Vector<uint>, Vector<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX2Insert_Core((Vector<long>)(object)back, (Vector<long>)(object)vector0, (Vector<long>)(object)vector1, (ValueTuple<Vector<long>, Vector<long>, Vector<long>, Vector<long>, Vector<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX2Insert_Core((Vector<ulong>)(object)back, (Vector<ulong>)(object)vector0, (Vector<ulong>)(object)vector1, (ValueTuple<Vector<ulong>, Vector<ulong>, Vector<ulong>, Vector<ulong>, Vector<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vectors.YShuffleX2Insert_Core(Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<float> YShuffleX2Insert_Core(this IVectorTraits athis, Vector<float> back, Vector<float> vector0, Vector<float> vector1, (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) args) {
            return athis.YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2Insert_Core(Vector{double}, Vector{double}, Vector{double}, ValueTuple{Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<double> YShuffleX2Insert_Core(this IVectorTraits athis, Vector<double> back, Vector<double> vector0, Vector<double> vector1, (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) args) {
            return athis.YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2Insert_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, ValueTuple{Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> YShuffleX2Insert_Core(this IVectorTraits athis, Vector<sbyte> back, Vector<sbyte> vector0, Vector<sbyte> vector1, (Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4) args) {
            return athis.YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2Insert_Core(Vector{byte}, Vector{byte}, Vector{byte}, ValueTuple{Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> YShuffleX2Insert_Core(this IVectorTraits athis, Vector<byte> back, Vector<byte> vector0, Vector<byte> vector1, (Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4) args) {
            return athis.YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2Insert_Core(Vector{short}, Vector{short}, Vector{short}, ValueTuple{Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> YShuffleX2Insert_Core(this IVectorTraits athis, Vector<short> back, Vector<short> vector0, Vector<short> vector1, (Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4) args) {
            return athis.YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2Insert_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, ValueTuple{Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> YShuffleX2Insert_Core(this IVectorTraits athis, Vector<ushort> back, Vector<ushort> vector0, Vector<ushort> vector1, (Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4) args) {
            return athis.YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2Insert_Core(Vector{int}, Vector{int}, Vector{int}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> YShuffleX2Insert_Core(this IVectorTraits athis, Vector<int> back, Vector<int> vector0, Vector<int> vector1, (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) args) {
            return athis.YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2Insert_Core(Vector{uint}, Vector{uint}, Vector{uint}, ValueTuple{Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> YShuffleX2Insert_Core(this IVectorTraits athis, Vector<uint> back, Vector<uint> vector0, Vector<uint> vector1, (Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4) args) {
            return athis.YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2Insert_Core(Vector{long}, Vector{long}, Vector{long}, ValueTuple{Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> YShuffleX2Insert_Core(this IVectorTraits athis, Vector<long> back, Vector<long> vector0, Vector<long> vector1, (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) args) {
            return athis.YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2Insert_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, ValueTuple{Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> YShuffleX2Insert_Core(this IVectorTraits athis, Vector<ulong> back, Vector<ulong> vector0, Vector<ulong> vector1, (Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4) args) {
            return athis.YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }


        /// <inheritdoc cref="Vectors.YShuffleX2Kernel_Args{TIdx}(Vector{TIdx}, out Vector{TIdx}, out Vector{TIdx}, out Vector{TIdx}, out Vector{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleX2Kernel_Args<TIdx>(this IVectorTraits athis, Vector<TIdx> indices, out Vector<TIdx> args0, out Vector<TIdx> args1, out Vector<TIdx> args2, out Vector<TIdx> args3)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX2Kernel_Args((Vector<sbyte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX2Kernel_Args((Vector<byte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX2Kernel_Args((Vector<short>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX2Kernel_Args((Vector<ushort>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX2Kernel_Args((Vector<int>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX2Kernel_Args((Vector<uint>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX2Kernel_Args((Vector<long>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX2Kernel_Args((Vector<ulong>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vectors.YShuffleX2Kernel_Args{TIdx}(Vector{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<TIdx> args0, Vector<TIdx> args1, Vector<TIdx> args2, Vector<TIdx> args3) YShuffleX2Kernel_Args<TIdx>(this IVectorTraits athis, Vector<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2Kernel_Args(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3) YShuffleX2Kernel_Args(this IVectorTraits athis, Vector<sbyte> indices) {
            athis.YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2Kernel_Args(Vector{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3) YShuffleX2Kernel_Args(this IVectorTraits athis, Vector<byte> indices) {
            athis.YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2Kernel_Args(Vector{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3) YShuffleX2Kernel_Args(this IVectorTraits athis, Vector<short> indices) {
            athis.YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2Kernel_Args(Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3) YShuffleX2Kernel_Args(this IVectorTraits athis, Vector<ushort> indices) {
            athis.YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2Kernel_Args(Vector{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3) YShuffleX2Kernel_Args(this IVectorTraits athis, Vector<int> indices) {
            athis.YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2Kernel_Args(Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3) YShuffleX2Kernel_Args(this IVectorTraits athis, Vector<uint> indices) {
            athis.YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2Kernel_Args(Vector{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3) YShuffleX2Kernel_Args(this IVectorTraits athis, Vector<long> indices) {
            athis.YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2Kernel_Args(Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3) YShuffleX2Kernel_Args(this IVectorTraits athis, Vector<ulong> indices) {
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
        /// <seealso cref="IVectorTraits.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleX2Kernel_Core(Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<T> YShuffleX2Kernel_Core<T, TIdx>(this IVectorTraits athis, Vector<T> vector0, Vector<T> vector1, (Vector<TIdx> args0, Vector<TIdx> args1, Vector<TIdx> args2, Vector<TIdx> args3) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX2Kernel_Core((Vector<float>)(object)vector0, (Vector<float>)(object)vector1, (ValueTuple<Vector<int>, Vector<int>, Vector<int>, Vector<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX2Kernel_Core((Vector<double>)(object)vector0, (Vector<double>)(object)vector1, (ValueTuple<Vector<long>, Vector<long>, Vector<long>, Vector<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX2Kernel_Core((Vector<sbyte>)(object)vector0, (Vector<sbyte>)(object)vector1, (ValueTuple<Vector<sbyte>, Vector<sbyte>, Vector<sbyte>, Vector<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX2Kernel_Core((Vector<byte>)(object)vector0, (Vector<byte>)(object)vector1, (ValueTuple<Vector<byte>, Vector<byte>, Vector<byte>, Vector<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX2Kernel_Core((Vector<short>)(object)vector0, (Vector<short>)(object)vector1, (ValueTuple<Vector<short>, Vector<short>, Vector<short>, Vector<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX2Kernel_Core((Vector<ushort>)(object)vector0, (Vector<ushort>)(object)vector1, (ValueTuple<Vector<ushort>, Vector<ushort>, Vector<ushort>, Vector<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX2Kernel_Core((Vector<int>)(object)vector0, (Vector<int>)(object)vector1, (ValueTuple<Vector<int>, Vector<int>, Vector<int>, Vector<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX2Kernel_Core((Vector<uint>)(object)vector0, (Vector<uint>)(object)vector1, (ValueTuple<Vector<uint>, Vector<uint>, Vector<uint>, Vector<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX2Kernel_Core((Vector<long>)(object)vector0, (Vector<long>)(object)vector1, (ValueTuple<Vector<long>, Vector<long>, Vector<long>, Vector<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX2Kernel_Core((Vector<ulong>)(object)vector0, (Vector<ulong>)(object)vector1, (ValueTuple<Vector<ulong>, Vector<ulong>, Vector<ulong>, Vector<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vectors.YShuffleX2Kernel_Core(Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<float> YShuffleX2Kernel_Core(this IVectorTraits athis, Vector<float> vector0, Vector<float> vector1, (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3) args) {
            return athis.YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2Kernel_Core(Vector{double}, Vector{double}, ValueTuple{Vector{long}, Vector{long}, Vector{long}, Vector{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<double> YShuffleX2Kernel_Core(this IVectorTraits athis, Vector<double> vector0, Vector<double> vector1, (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3) args) {
            return athis.YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2Kernel_Core(Vector{sbyte}, Vector{sbyte}, ValueTuple{Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> YShuffleX2Kernel_Core(this IVectorTraits athis, Vector<sbyte> vector0, Vector<sbyte> vector1, (Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3) args) {
            return athis.YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2Kernel_Core(Vector{byte}, Vector{byte}, ValueTuple{Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> YShuffleX2Kernel_Core(this IVectorTraits athis, Vector<byte> vector0, Vector<byte> vector1, (Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3) args) {
            return athis.YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2Kernel_Core(Vector{short}, Vector{short}, ValueTuple{Vector{short}, Vector{short}, Vector{short}, Vector{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> YShuffleX2Kernel_Core(this IVectorTraits athis, Vector<short> vector0, Vector<short> vector1, (Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3) args) {
            return athis.YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2Kernel_Core(Vector{ushort}, Vector{ushort}, ValueTuple{Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> YShuffleX2Kernel_Core(this IVectorTraits athis, Vector<ushort> vector0, Vector<ushort> vector1, (Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3) args) {
            return athis.YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2Kernel_Core(Vector{int}, Vector{int}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> YShuffleX2Kernel_Core(this IVectorTraits athis, Vector<int> vector0, Vector<int> vector1, (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3) args) {
            return athis.YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2Kernel_Core(Vector{uint}, Vector{uint}, ValueTuple{Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> YShuffleX2Kernel_Core(this IVectorTraits athis, Vector<uint> vector0, Vector<uint> vector1, (Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3) args) {
            return athis.YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2Kernel_Core(Vector{long}, Vector{long}, ValueTuple{Vector{long}, Vector{long}, Vector{long}, Vector{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> YShuffleX2Kernel_Core(this IVectorTraits athis, Vector<long> vector0, Vector<long> vector1, (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3) args) {
            return athis.YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vectors.YShuffleX2Kernel_Core(Vector{ulong}, Vector{ulong}, ValueTuple{Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> YShuffleX2Kernel_Core(this IVectorTraits athis, Vector<ulong> vector0, Vector<ulong> vector1, (Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3) args) {
            return athis.YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }


        /// <inheritdoc cref="Vectors.YShuffleX3_Args{TIdx}(Vector{TIdx}, out Vector{TIdx}, out Vector{TIdx}, out Vector{TIdx}, out Vector{TIdx}, out Vector{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleX3_Args<TIdx>(this IVectorTraits athis, Vector<TIdx> indices, out Vector<TIdx> args0, out Vector<TIdx> args1, out Vector<TIdx> args2, out Vector<TIdx> args3, out Vector<TIdx> args4)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3_Args((Vector<sbyte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3_Args((Vector<byte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3_Args((Vector<short>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3_Args((Vector<ushort>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3_Args((Vector<int>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3_Args((Vector<uint>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3_Args((Vector<long>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3_Args((Vector<ulong>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vectors.YShuffleX3_Args{TIdx}(Vector{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<TIdx> args0, Vector<TIdx> args1, Vector<TIdx> args2, Vector<TIdx> args3, Vector<TIdx> args4) YShuffleX3_Args<TIdx>(this IVectorTraits athis, Vector<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3_Args(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4) YShuffleX3_Args(this IVectorTraits athis, Vector<sbyte> indices) {
            athis.YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3_Args(Vector{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4) YShuffleX3_Args(this IVectorTraits athis, Vector<byte> indices) {
            athis.YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3_Args(Vector{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4) YShuffleX3_Args(this IVectorTraits athis, Vector<short> indices) {
            athis.YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3_Args(Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4) YShuffleX3_Args(this IVectorTraits athis, Vector<ushort> indices) {
            athis.YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3_Args(Vector{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) YShuffleX3_Args(this IVectorTraits athis, Vector<int> indices) {
            athis.YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3_Args(Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4) YShuffleX3_Args(this IVectorTraits athis, Vector<uint> indices) {
            athis.YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3_Args(Vector{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) YShuffleX3_Args(this IVectorTraits athis, Vector<long> indices) {
            athis.YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3_Args(Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4) YShuffleX3_Args(this IVectorTraits athis, Vector<ulong> indices) {
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
        /// <seealso cref="IVectorTraits.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleX3_Core(Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<T> YShuffleX3_Core<T, TIdx>(this IVectorTraits athis, Vector<T> vector0, Vector<T> vector1, Vector<T> vector2, (Vector<TIdx> args0, Vector<TIdx> args1, Vector<TIdx> args2, Vector<TIdx> args3, Vector<TIdx> args4) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX3_Core((Vector<float>)(object)vector0, (Vector<float>)(object)vector1, (Vector<float>)(object)vector2, (ValueTuple<Vector<int>, Vector<int>, Vector<int>, Vector<int>, Vector<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX3_Core((Vector<double>)(object)vector0, (Vector<double>)(object)vector1, (Vector<double>)(object)vector2, (ValueTuple<Vector<long>, Vector<long>, Vector<long>, Vector<long>, Vector<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX3_Core((Vector<sbyte>)(object)vector0, (Vector<sbyte>)(object)vector1, (Vector<sbyte>)(object)vector2, (ValueTuple<Vector<sbyte>, Vector<sbyte>, Vector<sbyte>, Vector<sbyte>, Vector<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX3_Core((Vector<byte>)(object)vector0, (Vector<byte>)(object)vector1, (Vector<byte>)(object)vector2, (ValueTuple<Vector<byte>, Vector<byte>, Vector<byte>, Vector<byte>, Vector<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX3_Core((Vector<short>)(object)vector0, (Vector<short>)(object)vector1, (Vector<short>)(object)vector2, (ValueTuple<Vector<short>, Vector<short>, Vector<short>, Vector<short>, Vector<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX3_Core((Vector<ushort>)(object)vector0, (Vector<ushort>)(object)vector1, (Vector<ushort>)(object)vector2, (ValueTuple<Vector<ushort>, Vector<ushort>, Vector<ushort>, Vector<ushort>, Vector<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX3_Core((Vector<int>)(object)vector0, (Vector<int>)(object)vector1, (Vector<int>)(object)vector2, (ValueTuple<Vector<int>, Vector<int>, Vector<int>, Vector<int>, Vector<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX3_Core((Vector<uint>)(object)vector0, (Vector<uint>)(object)vector1, (Vector<uint>)(object)vector2, (ValueTuple<Vector<uint>, Vector<uint>, Vector<uint>, Vector<uint>, Vector<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX3_Core((Vector<long>)(object)vector0, (Vector<long>)(object)vector1, (Vector<long>)(object)vector2, (ValueTuple<Vector<long>, Vector<long>, Vector<long>, Vector<long>, Vector<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX3_Core((Vector<ulong>)(object)vector0, (Vector<ulong>)(object)vector1, (Vector<ulong>)(object)vector2, (ValueTuple<Vector<ulong>, Vector<ulong>, Vector<ulong>, Vector<ulong>, Vector<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vectors.YShuffleX3_Core(Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<float> YShuffleX3_Core(this IVectorTraits athis, Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) args) {
            return athis.YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3_Core(Vector{double}, Vector{double}, Vector{double}, ValueTuple{Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<double> YShuffleX3_Core(this IVectorTraits athis, Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) args) {
            return athis.YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, ValueTuple{Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> YShuffleX3_Core(this IVectorTraits athis, Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, (Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4) args) {
            return athis.YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3_Core(Vector{byte}, Vector{byte}, Vector{byte}, ValueTuple{Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> YShuffleX3_Core(this IVectorTraits athis, Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, (Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4) args) {
            return athis.YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3_Core(Vector{short}, Vector{short}, Vector{short}, ValueTuple{Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> YShuffleX3_Core(this IVectorTraits athis, Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, (Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4) args) {
            return athis.YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, ValueTuple{Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> YShuffleX3_Core(this IVectorTraits athis, Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, (Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4) args) {
            return athis.YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3_Core(Vector{int}, Vector{int}, Vector{int}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> YShuffleX3_Core(this IVectorTraits athis, Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) args) {
            return athis.YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3_Core(Vector{uint}, Vector{uint}, Vector{uint}, ValueTuple{Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> YShuffleX3_Core(this IVectorTraits athis, Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, (Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4) args) {
            return athis.YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3_Core(Vector{long}, Vector{long}, Vector{long}, ValueTuple{Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> YShuffleX3_Core(this IVectorTraits athis, Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) args) {
            return athis.YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, ValueTuple{Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> YShuffleX3_Core(this IVectorTraits athis, Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, (Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4) args) {
            return athis.YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }


        /// <inheritdoc cref="Vectors.YShuffleX3Insert_Args{TIdx}(Vector{TIdx}, out Vector{TIdx}, out Vector{TIdx}, out Vector{TIdx}, out Vector{TIdx}, out Vector{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleX3Insert_Args<TIdx>(this IVectorTraits athis, Vector<TIdx> indices, out Vector<TIdx> args0, out Vector<TIdx> args1, out Vector<TIdx> args2, out Vector<TIdx> args3, out Vector<TIdx> args4)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3Insert_Args((Vector<sbyte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3Insert_Args((Vector<byte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3Insert_Args((Vector<short>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3Insert_Args((Vector<ushort>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3Insert_Args((Vector<int>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3Insert_Args((Vector<uint>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3Insert_Args((Vector<long>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3Insert_Args((Vector<ulong>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vectors.YShuffleX3Insert_Args{TIdx}(Vector{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<TIdx> args0, Vector<TIdx> args1, Vector<TIdx> args2, Vector<TIdx> args3, Vector<TIdx> args4) YShuffleX3Insert_Args<TIdx>(this IVectorTraits athis, Vector<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3Insert_Args(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4) YShuffleX3Insert_Args(this IVectorTraits athis, Vector<sbyte> indices) {
            athis.YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3Insert_Args(Vector{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4) YShuffleX3Insert_Args(this IVectorTraits athis, Vector<byte> indices) {
            athis.YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3Insert_Args(Vector{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4) YShuffleX3Insert_Args(this IVectorTraits athis, Vector<short> indices) {
            athis.YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3Insert_Args(Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4) YShuffleX3Insert_Args(this IVectorTraits athis, Vector<ushort> indices) {
            athis.YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3Insert_Args(Vector{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) YShuffleX3Insert_Args(this IVectorTraits athis, Vector<int> indices) {
            athis.YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3Insert_Args(Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4) YShuffleX3Insert_Args(this IVectorTraits athis, Vector<uint> indices) {
            athis.YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3Insert_Args(Vector{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) YShuffleX3Insert_Args(this IVectorTraits athis, Vector<long> indices) {
            athis.YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3Insert_Args(Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4) YShuffleX3Insert_Args(this IVectorTraits athis, Vector<ulong> indices) {
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
        /// <seealso cref="IVectorTraits.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleX3Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<T> YShuffleX3Insert_Core<T, TIdx>(this IVectorTraits athis, Vector<T> back, Vector<T> vector0, Vector<T> vector1, Vector<T> vector2, (Vector<TIdx> args0, Vector<TIdx> args1, Vector<TIdx> args2, Vector<TIdx> args3, Vector<TIdx> args4) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX3Insert_Core((Vector<float>)(object)back, (Vector<float>)(object)vector0, (Vector<float>)(object)vector1, (Vector<float>)(object)vector2, (ValueTuple<Vector<int>, Vector<int>, Vector<int>, Vector<int>, Vector<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX3Insert_Core((Vector<double>)(object)back, (Vector<double>)(object)vector0, (Vector<double>)(object)vector1, (Vector<double>)(object)vector2, (ValueTuple<Vector<long>, Vector<long>, Vector<long>, Vector<long>, Vector<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX3Insert_Core((Vector<sbyte>)(object)back, (Vector<sbyte>)(object)vector0, (Vector<sbyte>)(object)vector1, (Vector<sbyte>)(object)vector2, (ValueTuple<Vector<sbyte>, Vector<sbyte>, Vector<sbyte>, Vector<sbyte>, Vector<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX3Insert_Core((Vector<byte>)(object)back, (Vector<byte>)(object)vector0, (Vector<byte>)(object)vector1, (Vector<byte>)(object)vector2, (ValueTuple<Vector<byte>, Vector<byte>, Vector<byte>, Vector<byte>, Vector<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX3Insert_Core((Vector<short>)(object)back, (Vector<short>)(object)vector0, (Vector<short>)(object)vector1, (Vector<short>)(object)vector2, (ValueTuple<Vector<short>, Vector<short>, Vector<short>, Vector<short>, Vector<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX3Insert_Core((Vector<ushort>)(object)back, (Vector<ushort>)(object)vector0, (Vector<ushort>)(object)vector1, (Vector<ushort>)(object)vector2, (ValueTuple<Vector<ushort>, Vector<ushort>, Vector<ushort>, Vector<ushort>, Vector<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX3Insert_Core((Vector<int>)(object)back, (Vector<int>)(object)vector0, (Vector<int>)(object)vector1, (Vector<int>)(object)vector2, (ValueTuple<Vector<int>, Vector<int>, Vector<int>, Vector<int>, Vector<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX3Insert_Core((Vector<uint>)(object)back, (Vector<uint>)(object)vector0, (Vector<uint>)(object)vector1, (Vector<uint>)(object)vector2, (ValueTuple<Vector<uint>, Vector<uint>, Vector<uint>, Vector<uint>, Vector<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX3Insert_Core((Vector<long>)(object)back, (Vector<long>)(object)vector0, (Vector<long>)(object)vector1, (Vector<long>)(object)vector2, (ValueTuple<Vector<long>, Vector<long>, Vector<long>, Vector<long>, Vector<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX3Insert_Core((Vector<ulong>)(object)back, (Vector<ulong>)(object)vector0, (Vector<ulong>)(object)vector1, (Vector<ulong>)(object)vector2, (ValueTuple<Vector<ulong>, Vector<ulong>, Vector<ulong>, Vector<ulong>, Vector<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vectors.YShuffleX3Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<float> YShuffleX3Insert_Core(this IVectorTraits athis, Vector<float> back, Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) args) {
            return athis.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3Insert_Core(Vector{double}, Vector{double}, Vector{double}, Vector{double}, ValueTuple{Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<double> YShuffleX3Insert_Core(this IVectorTraits athis, Vector<double> back, Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) args) {
            return athis.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3Insert_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, ValueTuple{Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> YShuffleX3Insert_Core(this IVectorTraits athis, Vector<sbyte> back, Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, (Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4) args) {
            return athis.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3Insert_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, ValueTuple{Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> YShuffleX3Insert_Core(this IVectorTraits athis, Vector<byte> back, Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, (Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4) args) {
            return athis.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3Insert_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, ValueTuple{Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> YShuffleX3Insert_Core(this IVectorTraits athis, Vector<short> back, Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, (Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4) args) {
            return athis.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3Insert_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, ValueTuple{Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> YShuffleX3Insert_Core(this IVectorTraits athis, Vector<ushort> back, Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, (Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4) args) {
            return athis.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3Insert_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> YShuffleX3Insert_Core(this IVectorTraits athis, Vector<int> back, Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) args) {
            return athis.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3Insert_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, ValueTuple{Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> YShuffleX3Insert_Core(this IVectorTraits athis, Vector<uint> back, Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, (Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4) args) {
            return athis.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3Insert_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, ValueTuple{Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> YShuffleX3Insert_Core(this IVectorTraits athis, Vector<long> back, Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) args) {
            return athis.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3Insert_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, ValueTuple{Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> YShuffleX3Insert_Core(this IVectorTraits athis, Vector<ulong> back, Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, (Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4) args) {
            return athis.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }


        /// <inheritdoc cref="Vectors.YShuffleX3Kernel_Args{TIdx}(Vector{TIdx}, out Vector{TIdx}, out Vector{TIdx}, out Vector{TIdx}, out Vector{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleX3Kernel_Args<TIdx>(this IVectorTraits athis, Vector<TIdx> indices, out Vector<TIdx> args0, out Vector<TIdx> args1, out Vector<TIdx> args2, out Vector<TIdx> args3)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX3Kernel_Args((Vector<sbyte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX3Kernel_Args((Vector<byte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX3Kernel_Args((Vector<short>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX3Kernel_Args((Vector<ushort>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX3Kernel_Args((Vector<int>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX3Kernel_Args((Vector<uint>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX3Kernel_Args((Vector<long>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX3Kernel_Args((Vector<ulong>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vectors.YShuffleX3Kernel_Args{TIdx}(Vector{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<TIdx> args0, Vector<TIdx> args1, Vector<TIdx> args2, Vector<TIdx> args3) YShuffleX3Kernel_Args<TIdx>(this IVectorTraits athis, Vector<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3Kernel_Args(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3) YShuffleX3Kernel_Args(this IVectorTraits athis, Vector<sbyte> indices) {
            athis.YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3Kernel_Args(Vector{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3) YShuffleX3Kernel_Args(this IVectorTraits athis, Vector<byte> indices) {
            athis.YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3Kernel_Args(Vector{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3) YShuffleX3Kernel_Args(this IVectorTraits athis, Vector<short> indices) {
            athis.YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3Kernel_Args(Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3) YShuffleX3Kernel_Args(this IVectorTraits athis, Vector<ushort> indices) {
            athis.YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3Kernel_Args(Vector{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3) YShuffleX3Kernel_Args(this IVectorTraits athis, Vector<int> indices) {
            athis.YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3Kernel_Args(Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3) YShuffleX3Kernel_Args(this IVectorTraits athis, Vector<uint> indices) {
            athis.YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3Kernel_Args(Vector{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3) YShuffleX3Kernel_Args(this IVectorTraits athis, Vector<long> indices) {
            athis.YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3Kernel_Args(Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3) YShuffleX3Kernel_Args(this IVectorTraits athis, Vector<ulong> indices) {
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
        /// <seealso cref="IVectorTraits.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleX3Kernel_Core(Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<T> YShuffleX3Kernel_Core<T, TIdx>(this IVectorTraits athis, Vector<T> vector0, Vector<T> vector1, Vector<T> vector2, (Vector<TIdx> args0, Vector<TIdx> args1, Vector<TIdx> args2, Vector<TIdx> args3) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX3Kernel_Core((Vector<float>)(object)vector0, (Vector<float>)(object)vector1, (Vector<float>)(object)vector2, (ValueTuple<Vector<int>, Vector<int>, Vector<int>, Vector<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX3Kernel_Core((Vector<double>)(object)vector0, (Vector<double>)(object)vector1, (Vector<double>)(object)vector2, (ValueTuple<Vector<long>, Vector<long>, Vector<long>, Vector<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX3Kernel_Core((Vector<sbyte>)(object)vector0, (Vector<sbyte>)(object)vector1, (Vector<sbyte>)(object)vector2, (ValueTuple<Vector<sbyte>, Vector<sbyte>, Vector<sbyte>, Vector<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX3Kernel_Core((Vector<byte>)(object)vector0, (Vector<byte>)(object)vector1, (Vector<byte>)(object)vector2, (ValueTuple<Vector<byte>, Vector<byte>, Vector<byte>, Vector<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX3Kernel_Core((Vector<short>)(object)vector0, (Vector<short>)(object)vector1, (Vector<short>)(object)vector2, (ValueTuple<Vector<short>, Vector<short>, Vector<short>, Vector<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX3Kernel_Core((Vector<ushort>)(object)vector0, (Vector<ushort>)(object)vector1, (Vector<ushort>)(object)vector2, (ValueTuple<Vector<ushort>, Vector<ushort>, Vector<ushort>, Vector<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX3Kernel_Core((Vector<int>)(object)vector0, (Vector<int>)(object)vector1, (Vector<int>)(object)vector2, (ValueTuple<Vector<int>, Vector<int>, Vector<int>, Vector<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX3Kernel_Core((Vector<uint>)(object)vector0, (Vector<uint>)(object)vector1, (Vector<uint>)(object)vector2, (ValueTuple<Vector<uint>, Vector<uint>, Vector<uint>, Vector<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX3Kernel_Core((Vector<long>)(object)vector0, (Vector<long>)(object)vector1, (Vector<long>)(object)vector2, (ValueTuple<Vector<long>, Vector<long>, Vector<long>, Vector<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX3Kernel_Core((Vector<ulong>)(object)vector0, (Vector<ulong>)(object)vector1, (Vector<ulong>)(object)vector2, (ValueTuple<Vector<ulong>, Vector<ulong>, Vector<ulong>, Vector<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vectors.YShuffleX3Kernel_Core(Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<float> YShuffleX3Kernel_Core(this IVectorTraits athis, Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3) args) {
            return athis.YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3Kernel_Core(Vector{double}, Vector{double}, Vector{double}, ValueTuple{Vector{long}, Vector{long}, Vector{long}, Vector{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<double> YShuffleX3Kernel_Core(this IVectorTraits athis, Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3) args) {
            return athis.YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3Kernel_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, ValueTuple{Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> YShuffleX3Kernel_Core(this IVectorTraits athis, Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, (Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3) args) {
            return athis.YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3Kernel_Core(Vector{byte}, Vector{byte}, Vector{byte}, ValueTuple{Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> YShuffleX3Kernel_Core(this IVectorTraits athis, Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, (Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3) args) {
            return athis.YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3Kernel_Core(Vector{short}, Vector{short}, Vector{short}, ValueTuple{Vector{short}, Vector{short}, Vector{short}, Vector{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> YShuffleX3Kernel_Core(this IVectorTraits athis, Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, (Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3) args) {
            return athis.YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3Kernel_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, ValueTuple{Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> YShuffleX3Kernel_Core(this IVectorTraits athis, Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, (Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3) args) {
            return athis.YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3Kernel_Core(Vector{int}, Vector{int}, Vector{int}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> YShuffleX3Kernel_Core(this IVectorTraits athis, Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3) args) {
            return athis.YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3Kernel_Core(Vector{uint}, Vector{uint}, Vector{uint}, ValueTuple{Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> YShuffleX3Kernel_Core(this IVectorTraits athis, Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, (Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3) args) {
            return athis.YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3Kernel_Core(Vector{long}, Vector{long}, Vector{long}, ValueTuple{Vector{long}, Vector{long}, Vector{long}, Vector{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> YShuffleX3Kernel_Core(this IVectorTraits athis, Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3) args) {
            return athis.YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vectors.YShuffleX3Kernel_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, ValueTuple{Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> YShuffleX3Kernel_Core(this IVectorTraits athis, Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, (Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3) args) {
            return athis.YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }


        /// <inheritdoc cref="Vectors.YShuffleX4_Args{TIdx}(Vector{TIdx}, out Vector{TIdx}, out Vector{TIdx}, out Vector{TIdx}, out Vector{TIdx}, out Vector{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleX4_Args<TIdx>(this IVectorTraits athis, Vector<TIdx> indices, out Vector<TIdx> args0, out Vector<TIdx> args1, out Vector<TIdx> args2, out Vector<TIdx> args3, out Vector<TIdx> args4)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4_Args((Vector<sbyte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4_Args((Vector<byte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4_Args((Vector<short>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4_Args((Vector<ushort>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4_Args((Vector<int>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4_Args((Vector<uint>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4_Args((Vector<long>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4_Args((Vector<ulong>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vectors.YShuffleX4_Args{TIdx}(Vector{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<TIdx> args0, Vector<TIdx> args1, Vector<TIdx> args2, Vector<TIdx> args3, Vector<TIdx> args4) YShuffleX4_Args<TIdx>(this IVectorTraits athis, Vector<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4_Args(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4) YShuffleX4_Args(this IVectorTraits athis, Vector<sbyte> indices) {
            athis.YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4_Args(Vector{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4) YShuffleX4_Args(this IVectorTraits athis, Vector<byte> indices) {
            athis.YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4_Args(Vector{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4) YShuffleX4_Args(this IVectorTraits athis, Vector<short> indices) {
            athis.YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4_Args(Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4) YShuffleX4_Args(this IVectorTraits athis, Vector<ushort> indices) {
            athis.YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4_Args(Vector{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) YShuffleX4_Args(this IVectorTraits athis, Vector<int> indices) {
            athis.YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4_Args(Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4) YShuffleX4_Args(this IVectorTraits athis, Vector<uint> indices) {
            athis.YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4_Args(Vector{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) YShuffleX4_Args(this IVectorTraits athis, Vector<long> indices) {
            athis.YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4_Args(Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4) YShuffleX4_Args(this IVectorTraits athis, Vector<ulong> indices) {
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
        /// <seealso cref="IVectorTraits.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleX4_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<T> YShuffleX4_Core<T, TIdx>(this IVectorTraits athis, Vector<T> vector0, Vector<T> vector1, Vector<T> vector2, Vector<T> vector3, (Vector<TIdx> args0, Vector<TIdx> args1, Vector<TIdx> args2, Vector<TIdx> args3, Vector<TIdx> args4) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX4_Core((Vector<float>)(object)vector0, (Vector<float>)(object)vector1, (Vector<float>)(object)vector2, (Vector<float>)(object)vector3, (ValueTuple<Vector<int>, Vector<int>, Vector<int>, Vector<int>, Vector<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX4_Core((Vector<double>)(object)vector0, (Vector<double>)(object)vector1, (Vector<double>)(object)vector2, (Vector<double>)(object)vector3, (ValueTuple<Vector<long>, Vector<long>, Vector<long>, Vector<long>, Vector<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX4_Core((Vector<sbyte>)(object)vector0, (Vector<sbyte>)(object)vector1, (Vector<sbyte>)(object)vector2, (Vector<sbyte>)(object)vector3, (ValueTuple<Vector<sbyte>, Vector<sbyte>, Vector<sbyte>, Vector<sbyte>, Vector<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX4_Core((Vector<byte>)(object)vector0, (Vector<byte>)(object)vector1, (Vector<byte>)(object)vector2, (Vector<byte>)(object)vector3, (ValueTuple<Vector<byte>, Vector<byte>, Vector<byte>, Vector<byte>, Vector<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX4_Core((Vector<short>)(object)vector0, (Vector<short>)(object)vector1, (Vector<short>)(object)vector2, (Vector<short>)(object)vector3, (ValueTuple<Vector<short>, Vector<short>, Vector<short>, Vector<short>, Vector<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX4_Core((Vector<ushort>)(object)vector0, (Vector<ushort>)(object)vector1, (Vector<ushort>)(object)vector2, (Vector<ushort>)(object)vector3, (ValueTuple<Vector<ushort>, Vector<ushort>, Vector<ushort>, Vector<ushort>, Vector<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX4_Core((Vector<int>)(object)vector0, (Vector<int>)(object)vector1, (Vector<int>)(object)vector2, (Vector<int>)(object)vector3, (ValueTuple<Vector<int>, Vector<int>, Vector<int>, Vector<int>, Vector<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX4_Core((Vector<uint>)(object)vector0, (Vector<uint>)(object)vector1, (Vector<uint>)(object)vector2, (Vector<uint>)(object)vector3, (ValueTuple<Vector<uint>, Vector<uint>, Vector<uint>, Vector<uint>, Vector<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX4_Core((Vector<long>)(object)vector0, (Vector<long>)(object)vector1, (Vector<long>)(object)vector2, (Vector<long>)(object)vector3, (ValueTuple<Vector<long>, Vector<long>, Vector<long>, Vector<long>, Vector<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX4_Core((Vector<ulong>)(object)vector0, (Vector<ulong>)(object)vector1, (Vector<ulong>)(object)vector2, (Vector<ulong>)(object)vector3, (ValueTuple<Vector<ulong>, Vector<ulong>, Vector<ulong>, Vector<ulong>, Vector<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vectors.YShuffleX4_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<float> YShuffleX4_Core(this IVectorTraits athis, Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<float> vector3, (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) args) {
            return athis.YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4_Core(Vector{double}, Vector{double}, Vector{double}, Vector{double}, ValueTuple{Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<double> YShuffleX4_Core(this IVectorTraits athis, Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<double> vector3, (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) args) {
            return athis.YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, ValueTuple{Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> YShuffleX4_Core(this IVectorTraits athis, Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> vector3, (Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4) args) {
            return athis.YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, ValueTuple{Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> YShuffleX4_Core(this IVectorTraits athis, Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> vector3, (Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4) args) {
            return athis.YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, ValueTuple{Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> YShuffleX4_Core(this IVectorTraits athis, Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> vector3, (Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4) args) {
            return athis.YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, ValueTuple{Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> YShuffleX4_Core(this IVectorTraits athis, Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> vector3, (Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4) args) {
            return athis.YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> YShuffleX4_Core(this IVectorTraits athis, Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> vector3, (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) args) {
            return athis.YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, ValueTuple{Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> YShuffleX4_Core(this IVectorTraits athis, Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> vector3, (Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4) args) {
            return athis.YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, ValueTuple{Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> YShuffleX4_Core(this IVectorTraits athis, Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> vector3, (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) args) {
            return athis.YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, ValueTuple{Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> YShuffleX4_Core(this IVectorTraits athis, Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> vector3, (Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4) args) {
            return athis.YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }


        /// <inheritdoc cref="Vectors.YShuffleX4Insert_Args{TIdx}(Vector{TIdx}, out Vector{TIdx}, out Vector{TIdx}, out Vector{TIdx}, out Vector{TIdx}, out Vector{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleX4Insert_Args<TIdx>(this IVectorTraits athis, Vector<TIdx> indices, out Vector<TIdx> args0, out Vector<TIdx> args1, out Vector<TIdx> args2, out Vector<TIdx> args3, out Vector<TIdx> args4)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4Insert_Args((Vector<sbyte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4Insert_Args((Vector<byte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4Insert_Args((Vector<short>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4Insert_Args((Vector<ushort>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4Insert_Args((Vector<int>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4Insert_Args((Vector<uint>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4Insert_Args((Vector<long>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4Insert_Args((Vector<ulong>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vectors.YShuffleX4Insert_Args{TIdx}(Vector{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<TIdx> args0, Vector<TIdx> args1, Vector<TIdx> args2, Vector<TIdx> args3, Vector<TIdx> args4) YShuffleX4Insert_Args<TIdx>(this IVectorTraits athis, Vector<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4Insert_Args(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4) YShuffleX4Insert_Args(this IVectorTraits athis, Vector<sbyte> indices) {
            athis.YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4Insert_Args(Vector{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4) YShuffleX4Insert_Args(this IVectorTraits athis, Vector<byte> indices) {
            athis.YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4Insert_Args(Vector{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4) YShuffleX4Insert_Args(this IVectorTraits athis, Vector<short> indices) {
            athis.YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4Insert_Args(Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4) YShuffleX4Insert_Args(this IVectorTraits athis, Vector<ushort> indices) {
            athis.YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4Insert_Args(Vector{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) YShuffleX4Insert_Args(this IVectorTraits athis, Vector<int> indices) {
            athis.YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4Insert_Args(Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4) YShuffleX4Insert_Args(this IVectorTraits athis, Vector<uint> indices) {
            athis.YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4Insert_Args(Vector{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) YShuffleX4Insert_Args(this IVectorTraits athis, Vector<long> indices) {
            athis.YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4Insert_Args(Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4) YShuffleX4Insert_Args(this IVectorTraits athis, Vector<ulong> indices) {
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
        /// <seealso cref="IVectorTraits.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleX4Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<T> YShuffleX4Insert_Core<T, TIdx>(this IVectorTraits athis, Vector<T> back, Vector<T> vector0, Vector<T> vector1, Vector<T> vector2, Vector<T> vector3, (Vector<TIdx> args0, Vector<TIdx> args1, Vector<TIdx> args2, Vector<TIdx> args3, Vector<TIdx> args4) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX4Insert_Core((Vector<float>)(object)back, (Vector<float>)(object)vector0, (Vector<float>)(object)vector1, (Vector<float>)(object)vector2, (Vector<float>)(object)vector3, (ValueTuple<Vector<int>, Vector<int>, Vector<int>, Vector<int>, Vector<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX4Insert_Core((Vector<double>)(object)back, (Vector<double>)(object)vector0, (Vector<double>)(object)vector1, (Vector<double>)(object)vector2, (Vector<double>)(object)vector3, (ValueTuple<Vector<long>, Vector<long>, Vector<long>, Vector<long>, Vector<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX4Insert_Core((Vector<sbyte>)(object)back, (Vector<sbyte>)(object)vector0, (Vector<sbyte>)(object)vector1, (Vector<sbyte>)(object)vector2, (Vector<sbyte>)(object)vector3, (ValueTuple<Vector<sbyte>, Vector<sbyte>, Vector<sbyte>, Vector<sbyte>, Vector<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX4Insert_Core((Vector<byte>)(object)back, (Vector<byte>)(object)vector0, (Vector<byte>)(object)vector1, (Vector<byte>)(object)vector2, (Vector<byte>)(object)vector3, (ValueTuple<Vector<byte>, Vector<byte>, Vector<byte>, Vector<byte>, Vector<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX4Insert_Core((Vector<short>)(object)back, (Vector<short>)(object)vector0, (Vector<short>)(object)vector1, (Vector<short>)(object)vector2, (Vector<short>)(object)vector3, (ValueTuple<Vector<short>, Vector<short>, Vector<short>, Vector<short>, Vector<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX4Insert_Core((Vector<ushort>)(object)back, (Vector<ushort>)(object)vector0, (Vector<ushort>)(object)vector1, (Vector<ushort>)(object)vector2, (Vector<ushort>)(object)vector3, (ValueTuple<Vector<ushort>, Vector<ushort>, Vector<ushort>, Vector<ushort>, Vector<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX4Insert_Core((Vector<int>)(object)back, (Vector<int>)(object)vector0, (Vector<int>)(object)vector1, (Vector<int>)(object)vector2, (Vector<int>)(object)vector3, (ValueTuple<Vector<int>, Vector<int>, Vector<int>, Vector<int>, Vector<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX4Insert_Core((Vector<uint>)(object)back, (Vector<uint>)(object)vector0, (Vector<uint>)(object)vector1, (Vector<uint>)(object)vector2, (Vector<uint>)(object)vector3, (ValueTuple<Vector<uint>, Vector<uint>, Vector<uint>, Vector<uint>, Vector<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX4Insert_Core((Vector<long>)(object)back, (Vector<long>)(object)vector0, (Vector<long>)(object)vector1, (Vector<long>)(object)vector2, (Vector<long>)(object)vector3, (ValueTuple<Vector<long>, Vector<long>, Vector<long>, Vector<long>, Vector<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX4Insert_Core((Vector<ulong>)(object)back, (Vector<ulong>)(object)vector0, (Vector<ulong>)(object)vector1, (Vector<ulong>)(object)vector2, (Vector<ulong>)(object)vector3, (ValueTuple<Vector<ulong>, Vector<ulong>, Vector<ulong>, Vector<ulong>, Vector<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vectors.YShuffleX4Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<float> YShuffleX4Insert_Core(this IVectorTraits athis, Vector<float> back, Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<float> vector3, (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) args) {
            return athis.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4Insert_Core(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{double}, ValueTuple{Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<double> YShuffleX4Insert_Core(this IVectorTraits athis, Vector<double> back, Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<double> vector3, (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) args) {
            return athis.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4Insert_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, ValueTuple{Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> YShuffleX4Insert_Core(this IVectorTraits athis, Vector<sbyte> back, Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> vector3, (Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4) args) {
            return athis.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4Insert_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, ValueTuple{Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> YShuffleX4Insert_Core(this IVectorTraits athis, Vector<byte> back, Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> vector3, (Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4) args) {
            return athis.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4Insert_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, ValueTuple{Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> YShuffleX4Insert_Core(this IVectorTraits athis, Vector<short> back, Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> vector3, (Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4) args) {
            return athis.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4Insert_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, ValueTuple{Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> YShuffleX4Insert_Core(this IVectorTraits athis, Vector<ushort> back, Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> vector3, (Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4) args) {
            return athis.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4Insert_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> YShuffleX4Insert_Core(this IVectorTraits athis, Vector<int> back, Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> vector3, (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) args) {
            return athis.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4Insert_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, ValueTuple{Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> YShuffleX4Insert_Core(this IVectorTraits athis, Vector<uint> back, Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> vector3, (Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4) args) {
            return athis.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4Insert_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, ValueTuple{Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> YShuffleX4Insert_Core(this IVectorTraits athis, Vector<long> back, Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> vector3, (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) args) {
            return athis.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4Insert_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, ValueTuple{Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> YShuffleX4Insert_Core(this IVectorTraits athis, Vector<ulong> back, Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> vector3, (Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4) args) {
            return athis.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }


        /// <inheritdoc cref="Vectors.YShuffleX4Kernel_Args{TIdx}(Vector{TIdx}, out Vector{TIdx}, out Vector{TIdx}, out Vector{TIdx}, out Vector{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleX4Kernel_Args<TIdx>(this IVectorTraits athis, Vector<TIdx> indices, out Vector<TIdx> args0, out Vector<TIdx> args1, out Vector<TIdx> args2, out Vector<TIdx> args3)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX4Kernel_Args((Vector<sbyte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX4Kernel_Args((Vector<byte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX4Kernel_Args((Vector<short>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX4Kernel_Args((Vector<ushort>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX4Kernel_Args((Vector<int>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX4Kernel_Args((Vector<uint>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX4Kernel_Args((Vector<long>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX4Kernel_Args((Vector<ulong>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vectors.YShuffleX4Kernel_Args{TIdx}(Vector{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<TIdx> args0, Vector<TIdx> args1, Vector<TIdx> args2, Vector<TIdx> args3) YShuffleX4Kernel_Args<TIdx>(this IVectorTraits athis, Vector<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4Kernel_Args(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3) YShuffleX4Kernel_Args(this IVectorTraits athis, Vector<sbyte> indices) {
            athis.YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4Kernel_Args(Vector{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3) YShuffleX4Kernel_Args(this IVectorTraits athis, Vector<byte> indices) {
            athis.YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4Kernel_Args(Vector{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3) YShuffleX4Kernel_Args(this IVectorTraits athis, Vector<short> indices) {
            athis.YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4Kernel_Args(Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3) YShuffleX4Kernel_Args(this IVectorTraits athis, Vector<ushort> indices) {
            athis.YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4Kernel_Args(Vector{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3) YShuffleX4Kernel_Args(this IVectorTraits athis, Vector<int> indices) {
            athis.YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4Kernel_Args(Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3) YShuffleX4Kernel_Args(this IVectorTraits athis, Vector<uint> indices) {
            athis.YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4Kernel_Args(Vector{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3) YShuffleX4Kernel_Args(this IVectorTraits athis, Vector<long> indices) {
            athis.YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4Kernel_Args(Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3) YShuffleX4Kernel_Args(this IVectorTraits athis, Vector<ulong> indices) {
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
        /// <seealso cref="IVectorTraits.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleX4Kernel_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<T> YShuffleX4Kernel_Core<T, TIdx>(this IVectorTraits athis, Vector<T> vector0, Vector<T> vector1, Vector<T> vector2, Vector<T> vector3, (Vector<TIdx> args0, Vector<TIdx> args1, Vector<TIdx> args2, Vector<TIdx> args3) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX4Kernel_Core((Vector<float>)(object)vector0, (Vector<float>)(object)vector1, (Vector<float>)(object)vector2, (Vector<float>)(object)vector3, (ValueTuple<Vector<int>, Vector<int>, Vector<int>, Vector<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX4Kernel_Core((Vector<double>)(object)vector0, (Vector<double>)(object)vector1, (Vector<double>)(object)vector2, (Vector<double>)(object)vector3, (ValueTuple<Vector<long>, Vector<long>, Vector<long>, Vector<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX4Kernel_Core((Vector<sbyte>)(object)vector0, (Vector<sbyte>)(object)vector1, (Vector<sbyte>)(object)vector2, (Vector<sbyte>)(object)vector3, (ValueTuple<Vector<sbyte>, Vector<sbyte>, Vector<sbyte>, Vector<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX4Kernel_Core((Vector<byte>)(object)vector0, (Vector<byte>)(object)vector1, (Vector<byte>)(object)vector2, (Vector<byte>)(object)vector3, (ValueTuple<Vector<byte>, Vector<byte>, Vector<byte>, Vector<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX4Kernel_Core((Vector<short>)(object)vector0, (Vector<short>)(object)vector1, (Vector<short>)(object)vector2, (Vector<short>)(object)vector3, (ValueTuple<Vector<short>, Vector<short>, Vector<short>, Vector<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX4Kernel_Core((Vector<ushort>)(object)vector0, (Vector<ushort>)(object)vector1, (Vector<ushort>)(object)vector2, (Vector<ushort>)(object)vector3, (ValueTuple<Vector<ushort>, Vector<ushort>, Vector<ushort>, Vector<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX4Kernel_Core((Vector<int>)(object)vector0, (Vector<int>)(object)vector1, (Vector<int>)(object)vector2, (Vector<int>)(object)vector3, (ValueTuple<Vector<int>, Vector<int>, Vector<int>, Vector<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX4Kernel_Core((Vector<uint>)(object)vector0, (Vector<uint>)(object)vector1, (Vector<uint>)(object)vector2, (Vector<uint>)(object)vector3, (ValueTuple<Vector<uint>, Vector<uint>, Vector<uint>, Vector<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX4Kernel_Core((Vector<long>)(object)vector0, (Vector<long>)(object)vector1, (Vector<long>)(object)vector2, (Vector<long>)(object)vector3, (ValueTuple<Vector<long>, Vector<long>, Vector<long>, Vector<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.YShuffleX4Kernel_Core((Vector<ulong>)(object)vector0, (Vector<ulong>)(object)vector1, (Vector<ulong>)(object)vector2, (Vector<ulong>)(object)vector3, (ValueTuple<Vector<ulong>, Vector<ulong>, Vector<ulong>, Vector<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vectors.YShuffleX4Kernel_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<float> YShuffleX4Kernel_Core(this IVectorTraits athis, Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<float> vector3, (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3) args) {
            return athis.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4Kernel_Core(Vector{double}, Vector{double}, Vector{double}, Vector{double}, ValueTuple{Vector{long}, Vector{long}, Vector{long}, Vector{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<double> YShuffleX4Kernel_Core(this IVectorTraits athis, Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<double> vector3, (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3) args) {
            return athis.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4Kernel_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, ValueTuple{Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> YShuffleX4Kernel_Core(this IVectorTraits athis, Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> vector3, (Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3) args) {
            return athis.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4Kernel_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, ValueTuple{Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> YShuffleX4Kernel_Core(this IVectorTraits athis, Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> vector3, (Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3) args) {
            return athis.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4Kernel_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, ValueTuple{Vector{short}, Vector{short}, Vector{short}, Vector{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> YShuffleX4Kernel_Core(this IVectorTraits athis, Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> vector3, (Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3) args) {
            return athis.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4Kernel_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, ValueTuple{Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> YShuffleX4Kernel_Core(this IVectorTraits athis, Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> vector3, (Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3) args) {
            return athis.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4Kernel_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> YShuffleX4Kernel_Core(this IVectorTraits athis, Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> vector3, (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3) args) {
            return athis.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4Kernel_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, ValueTuple{Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> YShuffleX4Kernel_Core(this IVectorTraits athis, Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> vector3, (Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3) args) {
            return athis.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4Kernel_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, ValueTuple{Vector{long}, Vector{long}, Vector{long}, Vector{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> YShuffleX4Kernel_Core(this IVectorTraits athis, Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> vector3, (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3) args) {
            return athis.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vectors.YShuffleX4Kernel_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, ValueTuple{Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> YShuffleX4Kernel_Core(this IVectorTraits athis, Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> vector3, (Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3) args) {
            return athis.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

    }
}
