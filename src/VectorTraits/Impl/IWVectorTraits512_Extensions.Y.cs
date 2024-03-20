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
using static Zyl.VectorTraits.Impl.VectorMessageFormats;

namespace Zyl.VectorTraits.Impl {
    partial class IWVectorTraits512_Extensions {
#if NET8_0_OR_GREATER

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
        public static (Vector512<float> Result0, Vector512<float> Result1) YShuffleG4X2(this IWVectorTraits512 athis, Vector512<float> source0, Vector512<float> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleG4X2(Vector512{double}, Vector512{double}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector512<double> Result0, Vector512<double> Result1) YShuffleG4X2(this IWVectorTraits512 athis, Vector512<double> source0, Vector512<double> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleG4X2(Vector512{sbyte}, Vector512{sbyte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector512<sbyte> Result0, Vector512<sbyte> Result1) YShuffleG4X2(this IWVectorTraits512 athis, Vector512<sbyte> source0, Vector512<sbyte> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleG4X2(Vector512{byte}, Vector512{byte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector512<byte> Result0, Vector512<byte> Result1) YShuffleG4X2(this IWVectorTraits512 athis, Vector512<byte> source0, Vector512<byte> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleG4X2(Vector512{short}, Vector512{short}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector512<short> Result0, Vector512<short> Result1) YShuffleG4X2(this IWVectorTraits512 athis, Vector512<short> source0, Vector512<short> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleG4X2(Vector512{ushort}, Vector512{ushort}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector512<ushort> Result0, Vector512<ushort> Result1) YShuffleG4X2(this IWVectorTraits512 athis, Vector512<ushort> source0, Vector512<ushort> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleG4X2(Vector512{int}, Vector512{int}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector512<int> Result0, Vector512<int> Result1) YShuffleG4X2(this IWVectorTraits512 athis, Vector512<int> source0, Vector512<int> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleG4X2(Vector512{uint}, Vector512{uint}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector512<uint> Result0, Vector512<uint> Result1) YShuffleG4X2(this IWVectorTraits512 athis, Vector512<uint> source0, Vector512<uint> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleG4X2(Vector512{long}, Vector512{long}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector512<long> Result0, Vector512<long> Result1) YShuffleG4X2(this IWVectorTraits512 athis, Vector512<long> source0, Vector512<long> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleG4X2(Vector512{ulong}, Vector512{ulong}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
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
        public static (Vector512<float> Result0, Vector512<float> Result1) YShuffleG4X2_Const(this IWVectorTraits512 athis, Vector512<float> source0, Vector512<float> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleG4X2_Const(Vector512{double}, Vector512{double}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector512<double> Result0, Vector512<double> Result1) YShuffleG4X2_Const(this IWVectorTraits512 athis, Vector512<double> source0, Vector512<double> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleG4X2_Const(Vector512{sbyte}, Vector512{sbyte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector512<sbyte> Result0, Vector512<sbyte> Result1) YShuffleG4X2_Const(this IWVectorTraits512 athis, Vector512<sbyte> source0, Vector512<sbyte> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleG4X2_Const(Vector512{byte}, Vector512{byte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector512<byte> Result0, Vector512<byte> Result1) YShuffleG4X2_Const(this IWVectorTraits512 athis, Vector512<byte> source0, Vector512<byte> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleG4X2_Const(Vector512{short}, Vector512{short}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector512<short> Result0, Vector512<short> Result1) YShuffleG4X2_Const(this IWVectorTraits512 athis, Vector512<short> source0, Vector512<short> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleG4X2_Const(Vector512{ushort}, Vector512{ushort}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector512<ushort> Result0, Vector512<ushort> Result1) YShuffleG4X2_Const(this IWVectorTraits512 athis, Vector512<ushort> source0, Vector512<ushort> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleG4X2_Const(Vector512{int}, Vector512{int}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector512<int> Result0, Vector512<int> Result1) YShuffleG4X2_Const(this IWVectorTraits512 athis, Vector512<int> source0, Vector512<int> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleG4X2_Const(Vector512{uint}, Vector512{uint}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector512<uint> Result0, Vector512<uint> Result1) YShuffleG4X2_Const(this IWVectorTraits512 athis, Vector512<uint> source0, Vector512<uint> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleG4X2_Const(Vector512{long}, Vector512{long}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector512<long> Result0, Vector512<long> Result1) YShuffleG4X2_Const(this IWVectorTraits512 athis, Vector512<long> source0, Vector512<long> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector512s.YShuffleG4X2_Const(Vector512{ulong}, Vector512{ulong}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
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

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
