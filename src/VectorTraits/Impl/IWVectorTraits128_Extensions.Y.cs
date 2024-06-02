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
    /// <summary>
    /// Extension methods of <seealso cref="IWVectorTraits128"/> (<seealso cref="IWVectorTraits128"/> 的扩展方法)
    /// </summary>
    partial class IWVectorTraits128_Extensions {
#if NETCOREAPP3_0_OR_GREATER

        /// <inheritdoc cref="Vector128s.YShuffleG4X2{T}(Vector128{T}, Vector128{T}, ShuffleControlG4)"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static (Vector128<T> Result0, Vector128<T> Result1) YShuffleG4X2<T>(this IWVectorTraits128 athis, Vector128<T> source0, Vector128<T> source1, [ConstantExpected] ShuffleControlG4 control) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector128<float>)(object)source0, (Vector128<float>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(double) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector128<double>)(object)source0, (Vector128<double>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(sbyte) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector128<sbyte>)(object)source0, (Vector128<sbyte>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(byte) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector128<byte>)(object)source0, (Vector128<byte>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(short) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector128<short>)(object)source0, (Vector128<short>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(ushort) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector128<ushort>)(object)source0, (Vector128<ushort>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(int) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector128<int>)(object)source0, (Vector128<int>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(uint) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector128<uint>)(object)source0, (Vector128<uint>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(long) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector128<long>)(object)source0, (Vector128<long>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(ulong) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector128<ulong>)(object)source0, (Vector128<ulong>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.YShuffleG4X2(Vector128{float}, Vector128{float}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector128<float> Result0, Vector128<float> Result1) YShuffleG4X2(this IWVectorTraits128 athis, Vector128<float> source0, Vector128<float> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleG4X2(Vector128{double}, Vector128{double}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector128<double> Result0, Vector128<double> Result1) YShuffleG4X2(this IWVectorTraits128 athis, Vector128<double> source0, Vector128<double> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleG4X2(Vector128{sbyte}, Vector128{sbyte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector128<sbyte> Result0, Vector128<sbyte> Result1) YShuffleG4X2(this IWVectorTraits128 athis, Vector128<sbyte> source0, Vector128<sbyte> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleG4X2(Vector128{byte}, Vector128{byte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector128<byte> Result0, Vector128<byte> Result1) YShuffleG4X2(this IWVectorTraits128 athis, Vector128<byte> source0, Vector128<byte> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleG4X2(Vector128{short}, Vector128{short}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector128<short> Result0, Vector128<short> Result1) YShuffleG4X2(this IWVectorTraits128 athis, Vector128<short> source0, Vector128<short> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleG4X2(Vector128{ushort}, Vector128{ushort}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector128<ushort> Result0, Vector128<ushort> Result1) YShuffleG4X2(this IWVectorTraits128 athis, Vector128<ushort> source0, Vector128<ushort> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleG4X2(Vector128{int}, Vector128{int}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector128<int> Result0, Vector128<int> Result1) YShuffleG4X2(this IWVectorTraits128 athis, Vector128<int> source0, Vector128<int> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleG4X2(Vector128{uint}, Vector128{uint}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector128<uint> Result0, Vector128<uint> Result1) YShuffleG4X2(this IWVectorTraits128 athis, Vector128<uint> source0, Vector128<uint> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleG4X2(Vector128{long}, Vector128{long}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector128<long> Result0, Vector128<long> Result1) YShuffleG4X2(this IWVectorTraits128 athis, Vector128<long> source0, Vector128<long> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleG4X2(Vector128{ulong}, Vector128{ulong}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector128<ulong> Result0, Vector128<ulong> Result1) YShuffleG4X2(this IWVectorTraits128 athis, Vector128<ulong> source0, Vector128<ulong> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleG4X2_Const{T}(Vector128{T}, Vector128{T}, ShuffleControlG4)"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static (Vector128<T> Result0, Vector128<T> Result1) YShuffleG4X2_Const<T>(this IWVectorTraits128 athis, Vector128<T> source0, Vector128<T> source1, [ConstantExpected] ShuffleControlG4 control) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector128<float>)(object)source0, (Vector128<float>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(double) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector128<double>)(object)source0, (Vector128<double>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(sbyte) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector128<sbyte>)(object)source0, (Vector128<sbyte>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(byte) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector128<byte>)(object)source0, (Vector128<byte>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(short) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector128<short>)(object)source0, (Vector128<short>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(ushort) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector128<ushort>)(object)source0, (Vector128<ushort>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(int) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector128<int>)(object)source0, (Vector128<int>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(uint) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector128<uint>)(object)source0, (Vector128<uint>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(long) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector128<long>)(object)source0, (Vector128<long>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(ulong) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector128<ulong>)(object)source0, (Vector128<ulong>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.YShuffleG4X2_Const(Vector128{float}, Vector128{float}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector128<float> Result0, Vector128<float> Result1) YShuffleG4X2_Const(this IWVectorTraits128 athis, Vector128<float> source0, Vector128<float> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleG4X2_Const(Vector128{double}, Vector128{double}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector128<double> Result0, Vector128<double> Result1) YShuffleG4X2_Const(this IWVectorTraits128 athis, Vector128<double> source0, Vector128<double> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleG4X2_Const(Vector128{sbyte}, Vector128{sbyte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector128<sbyte> Result0, Vector128<sbyte> Result1) YShuffleG4X2_Const(this IWVectorTraits128 athis, Vector128<sbyte> source0, Vector128<sbyte> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleG4X2_Const(Vector128{byte}, Vector128{byte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector128<byte> Result0, Vector128<byte> Result1) YShuffleG4X2_Const(this IWVectorTraits128 athis, Vector128<byte> source0, Vector128<byte> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleG4X2_Const(Vector128{short}, Vector128{short}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector128<short> Result0, Vector128<short> Result1) YShuffleG4X2_Const(this IWVectorTraits128 athis, Vector128<short> source0, Vector128<short> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleG4X2_Const(Vector128{ushort}, Vector128{ushort}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector128<ushort> Result0, Vector128<ushort> Result1) YShuffleG4X2_Const(this IWVectorTraits128 athis, Vector128<ushort> source0, Vector128<ushort> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleG4X2_Const(Vector128{int}, Vector128{int}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector128<int> Result0, Vector128<int> Result1) YShuffleG4X2_Const(this IWVectorTraits128 athis, Vector128<int> source0, Vector128<int> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleG4X2_Const(Vector128{uint}, Vector128{uint}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector128<uint> Result0, Vector128<uint> Result1) YShuffleG4X2_Const(this IWVectorTraits128 athis, Vector128<uint> source0, Vector128<uint> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleG4X2_Const(Vector128{long}, Vector128{long}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector128<long> Result0, Vector128<long> Result1) YShuffleG4X2_Const(this IWVectorTraits128 athis, Vector128<long> source0, Vector128<long> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleG4X2_Const(Vector128{ulong}, Vector128{ulong}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector128<ulong> Result0, Vector128<ulong> Result1) YShuffleG4X2_Const(this IWVectorTraits128 athis, Vector128<ulong> source0, Vector128<ulong> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleInsert_Args{TIdx}(Vector128{TIdx}, out Vector128{TIdx}, out Vector128{TIdx}, out Vector128{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleInsert_Args<TIdx>(this IWVectorTraits128 athis, Vector128<TIdx> indices, out Vector128<TIdx> args0, out Vector128<TIdx> args1, out Vector128<TIdx> args2)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a0, var a1, var a2) = athis.YShuffleInsert_Args((Vector128<sbyte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a0;
                args1 = (Vector128<TIdx>)(object)a1;
                args2 = (Vector128<TIdx>)(object)a2;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a0, var a1, var a2) = athis.YShuffleInsert_Args((Vector128<byte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a0;
                args1 = (Vector128<TIdx>)(object)a1;
                args2 = (Vector128<TIdx>)(object)a2;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a0, var a1, var a2) = athis.YShuffleInsert_Args((Vector128<short>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a0;
                args1 = (Vector128<TIdx>)(object)a1;
                args2 = (Vector128<TIdx>)(object)a2;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a0, var a1, var a2) = athis.YShuffleInsert_Args((Vector128<ushort>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a0;
                args1 = (Vector128<TIdx>)(object)a1;
                args2 = (Vector128<TIdx>)(object)a2;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a0, var a1, var a2) = athis.YShuffleInsert_Args((Vector128<int>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a0;
                args1 = (Vector128<TIdx>)(object)a1;
                args2 = (Vector128<TIdx>)(object)a2;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a0, var a1, var a2) = athis.YShuffleInsert_Args((Vector128<uint>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a0;
                args1 = (Vector128<TIdx>)(object)a1;
                args2 = (Vector128<TIdx>)(object)a2;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a0, var a1, var a2) = athis.YShuffleInsert_Args((Vector128<long>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a0;
                args1 = (Vector128<TIdx>)(object)a1;
                args2 = (Vector128<TIdx>)(object)a2;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a0, var a1, var a2) = athis.YShuffleInsert_Args((Vector128<ulong>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a0;
                args1 = (Vector128<TIdx>)(object)a1;
                args2 = (Vector128<TIdx>)(object)a2;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.YShuffleInsert_Args{TIdx}(Vector128{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static (Vector128<TIdx> args0, Vector128<TIdx> args1, Vector128<TIdx> args2) YShuffleInsert_Args<TIdx>(this IWVectorTraits128 athis, Vector128<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleInsert_Args<TIdx>(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <inheritdoc cref="Vector128s.YShuffleInsert_Args(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2) YShuffleInsert_Args(this IWVectorTraits128 athis, Vector128<sbyte> indices) {
            athis.YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <inheritdoc cref="Vector128s.YShuffleInsert_Args(Vector128{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2) YShuffleInsert_Args(this IWVectorTraits128 athis, Vector128<byte> indices) {
            athis.YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <inheritdoc cref="Vector128s.YShuffleInsert_Args(Vector128{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> args0, Vector128<short> args1, Vector128<short> args2) YShuffleInsert_Args(this IWVectorTraits128 athis, Vector128<short> indices) {
            athis.YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <inheritdoc cref="Vector128s.YShuffleInsert_Args(Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2) YShuffleInsert_Args(this IWVectorTraits128 athis, Vector128<ushort> indices) {
            athis.YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <inheritdoc cref="Vector128s.YShuffleInsert_Args(Vector128{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2) YShuffleInsert_Args(this IWVectorTraits128 athis, Vector128<int> indices) {
            athis.YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <inheritdoc cref="Vector128s.YShuffleInsert_Args(Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2) YShuffleInsert_Args(this IWVectorTraits128 athis, Vector128<uint> indices) {
            athis.YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <inheritdoc cref="Vector128s.YShuffleInsert_Args(Vector128{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2) YShuffleInsert_Args(this IWVectorTraits128 athis, Vector128<long> indices) {
            athis.YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <inheritdoc cref="Vector128s.YShuffleInsert_Args(Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2) YShuffleInsert_Args(this IWVectorTraits128 athis, Vector128<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits128.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<T> YShuffleInsert_Core<T, TIdx>(this IWVectorTraits128 athis, Vector128<T> back, Vector128<T> vector, (Vector128<TIdx> args0, Vector128<TIdx> args1, Vector128<TIdx> args2) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleInsert_Core((Vector128<float>)(object)back, (Vector128<float>)(object)vector, (ValueTuple<Vector128<int>, Vector128<int>, Vector128<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleInsert_Core((Vector128<double>)(object)back, (Vector128<double>)(object)vector, (ValueTuple<Vector128<long>, Vector128<long>, Vector128<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleInsert_Core((Vector128<sbyte>)(object)back, (Vector128<sbyte>)(object)vector, (ValueTuple<Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleInsert_Core((Vector128<byte>)(object)back, (Vector128<byte>)(object)vector, (ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleInsert_Core((Vector128<short>)(object)back, (Vector128<short>)(object)vector, (ValueTuple<Vector128<short>, Vector128<short>, Vector128<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleInsert_Core((Vector128<ushort>)(object)back, (Vector128<ushort>)(object)vector, (ValueTuple<Vector128<ushort>, Vector128<ushort>, Vector128<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleInsert_Core((Vector128<int>)(object)back, (Vector128<int>)(object)vector, (ValueTuple<Vector128<int>, Vector128<int>, Vector128<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleInsert_Core((Vector128<uint>)(object)back, (Vector128<uint>)(object)vector, (ValueTuple<Vector128<uint>, Vector128<uint>, Vector128<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleInsert_Core((Vector128<long>)(object)back, (Vector128<long>)(object)vector, (ValueTuple<Vector128<long>, Vector128<long>, Vector128<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleInsert_Core((Vector128<ulong>)(object)back, (Vector128<ulong>)(object)vector, (ValueTuple<Vector128<ulong>, Vector128<ulong>, Vector128<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.YShuffleInsert_Core(Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleInsert_Core(this IWVectorTraits128 athis, Vector128<float> back, Vector128<float> vector, (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2) args) {
            return athis.YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <inheritdoc cref="Vector128s.YShuffleInsert_Core(Vector128{double}, Vector128{double}, ValueTuple{Vector128{long}, Vector128{long}, Vector128{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleInsert_Core(this IWVectorTraits128 athis, Vector128<double> back, Vector128<double> vector, (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2) args) {
            return athis.YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <inheritdoc cref="Vector128s.YShuffleInsert_Core(Vector128{sbyte}, Vector128{sbyte}, ValueTuple{Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleInsert_Core(this IWVectorTraits128 athis, Vector128<sbyte> back, Vector128<sbyte> vector, (Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2) args) {
            return athis.YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <inheritdoc cref="Vector128s.YShuffleInsert_Core(Vector128{byte}, Vector128{byte}, ValueTuple{Vector128{byte}, Vector128{byte}, Vector128{byte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleInsert_Core(this IWVectorTraits128 athis, Vector128<byte> back, Vector128<byte> vector, (Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2) args) {
            return athis.YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <inheritdoc cref="Vector128s.YShuffleInsert_Core(Vector128{short}, Vector128{short}, ValueTuple{Vector128{short}, Vector128{short}, Vector128{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleInsert_Core(this IWVectorTraits128 athis, Vector128<short> back, Vector128<short> vector, (Vector128<short> args0, Vector128<short> args1, Vector128<short> args2) args) {
            return athis.YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <inheritdoc cref="Vector128s.YShuffleInsert_Core(Vector128{ushort}, Vector128{ushort}, ValueTuple{Vector128{ushort}, Vector128{ushort}, Vector128{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleInsert_Core(this IWVectorTraits128 athis, Vector128<ushort> back, Vector128<ushort> vector, (Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2) args) {
            return athis.YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <inheritdoc cref="Vector128s.YShuffleInsert_Core(Vector128{int}, Vector128{int}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleInsert_Core(this IWVectorTraits128 athis, Vector128<int> back, Vector128<int> vector, (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2) args) {
            return athis.YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <inheritdoc cref="Vector128s.YShuffleInsert_Core(Vector128{uint}, Vector128{uint}, ValueTuple{Vector128{uint}, Vector128{uint}, Vector128{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleInsert_Core(this IWVectorTraits128 athis, Vector128<uint> back, Vector128<uint> vector, (Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2) args) {
            return athis.YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <inheritdoc cref="Vector128s.YShuffleInsert_Core(Vector128{long}, Vector128{long}, ValueTuple{Vector128{long}, Vector128{long}, Vector128{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleInsert_Core(this IWVectorTraits128 athis, Vector128<long> back, Vector128<long> vector, (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2) args) {
            return athis.YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <inheritdoc cref="Vector128s.YShuffleInsert_Core(Vector128{ulong}, Vector128{ulong}, ValueTuple{Vector128{ulong}, Vector128{ulong}, Vector128{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleInsert_Core(this IWVectorTraits128 athis, Vector128<ulong> back, Vector128<ulong> vector, (Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2) args) {
            return athis.YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }


        /// <inheritdoc cref="Vector128s.YShuffleKernel_Args{TIdx}(Vector128{TIdx}, out Vector128{TIdx}, out Vector128{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleKernel_Args<TIdx>(this IWVectorTraits128 athis, Vector128<TIdx> indices, out Vector128<TIdx> args0, out Vector128<TIdx> args1)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b) = athis.YShuffleKernel_Args((Vector128<sbyte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b) = athis.YShuffleKernel_Args((Vector128<byte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b) = athis.YShuffleKernel_Args((Vector128<short>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b) = athis.YShuffleKernel_Args((Vector128<ushort>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b) = athis.YShuffleKernel_Args((Vector128<int>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b) = athis.YShuffleKernel_Args((Vector128<uint>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b) = athis.YShuffleKernel_Args((Vector128<long>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b) = athis.YShuffleKernel_Args((Vector128<ulong>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.YShuffleKernel_Args{TIdx}(Vector128{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<TIdx> args0, Vector128<TIdx> args1) YShuffleKernel_Args<TIdx>(this IWVectorTraits128 athis, Vector128<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleKernel_Args<TIdx>(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector128s.YShuffleKernel_Args(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> args0, Vector128<sbyte> args1) YShuffleKernel_Args(this IWVectorTraits128 athis, Vector128<sbyte> indices) {
            athis.YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector128s.YShuffleKernel_Args(Vector128{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> args0, Vector128<byte> args1) YShuffleKernel_Args(this IWVectorTraits128 athis, Vector128<byte> indices) {
            athis.YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector128s.YShuffleKernel_Args(Vector128{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> args0, Vector128<short> args1) YShuffleKernel_Args(this IWVectorTraits128 athis, Vector128<short> indices) {
            athis.YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector128s.YShuffleKernel_Args(Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> args0, Vector128<ushort> args1) YShuffleKernel_Args(this IWVectorTraits128 athis, Vector128<ushort> indices) {
            athis.YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector128s.YShuffleKernel_Args(Vector128{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> args0, Vector128<int> args1) YShuffleKernel_Args(this IWVectorTraits128 athis, Vector128<int> indices) {
            athis.YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector128s.YShuffleKernel_Args(Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> args0, Vector128<uint> args1) YShuffleKernel_Args(this IWVectorTraits128 athis, Vector128<uint> indices) {
            athis.YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector128s.YShuffleKernel_Args(Vector128{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> args0, Vector128<long> args1) YShuffleKernel_Args(this IWVectorTraits128 athis, Vector128<long> indices) {
            athis.YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector128s.YShuffleKernel_Args(Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> args0, Vector128<ulong> args1) YShuffleKernel_Args(this IWVectorTraits128 athis, Vector128<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{float}, Vector128{int}, Vector128{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<T> YShuffleKernel_Core<T, TIdx>(this IWVectorTraits128 athis, Vector128<T> vector, (Vector128<TIdx> args0, Vector128<TIdx> args1) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleKernel_Core((Vector128<float>)(object)vector, (ValueTuple<Vector128<int>, Vector128<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleKernel_Core((Vector128<double>)(object)vector, (ValueTuple<Vector128<long>, Vector128<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleKernel_Core((Vector128<sbyte>)(object)vector, (ValueTuple<Vector128<sbyte>, Vector128<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleKernel_Core((Vector128<byte>)(object)vector, (ValueTuple<Vector128<byte>, Vector128<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleKernel_Core((Vector128<short>)(object)vector, (ValueTuple<Vector128<short>, Vector128<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleKernel_Core((Vector128<ushort>)(object)vector, (ValueTuple<Vector128<ushort>, Vector128<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleKernel_Core((Vector128<int>)(object)vector, (ValueTuple<Vector128<int>, Vector128<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleKernel_Core((Vector128<uint>)(object)vector, (ValueTuple<Vector128<uint>, Vector128<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleKernel_Core((Vector128<long>)(object)vector, (ValueTuple<Vector128<long>, Vector128<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleKernel_Core((Vector128<ulong>)(object)vector, (ValueTuple<Vector128<ulong>, Vector128<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.YShuffleKernel_Core(Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleKernel_Core(this IWVectorTraits128 athis, Vector128<float> vector, (Vector128<int> args0, Vector128<int> args1) args) {
            return athis.YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleKernel_Core(Vector128{double}, ValueTuple{Vector128{long}, Vector128{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleKernel_Core(this IWVectorTraits128 athis, Vector128<double> vector, (Vector128<long> args0, Vector128<long> args1) args) {
            return athis.YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleKernel_Core(Vector128{sbyte}, ValueTuple{Vector128{sbyte}, Vector128{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleKernel_Core(this IWVectorTraits128 athis, Vector128<sbyte> vector, (Vector128<sbyte> args0, Vector128<sbyte> args1) args) {
            return athis.YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleKernel_Core(Vector128{byte}, ValueTuple{Vector128{byte}, Vector128{byte}})"/>
        [CLSCompliant(false)]
        public static Vector128<byte> YShuffleKernel_Core(this IWVectorTraits128 athis, Vector128<byte> vector, (Vector128<byte> args0, Vector128<byte> args1) args) {
            return athis.YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleKernel_Core(Vector128{short}, ValueTuple{Vector128{short}, Vector128{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleKernel_Core(this IWVectorTraits128 athis, Vector128<short> vector, (Vector128<short> args0, Vector128<short> args1) args) {
            return athis.YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleKernel_Core(Vector128{ushort}, ValueTuple{Vector128{ushort}, Vector128{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleKernel_Core(this IWVectorTraits128 athis, Vector128<ushort> vector, (Vector128<ushort> args0, Vector128<ushort> args1) args) {
            return athis.YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleKernel_Core(Vector128{int}, ValueTuple{Vector128{int}, Vector128{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleKernel_Core(this IWVectorTraits128 athis, Vector128<int> vector, (Vector128<int> args0, Vector128<int> args1) args) {
            return athis.YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleKernel_Core(Vector128{uint}, ValueTuple{Vector128{uint}, Vector128{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleKernel_Core(this IWVectorTraits128 athis, Vector128<uint> vector, (Vector128<uint> args0, Vector128<uint> args1) args) {
            return athis.YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleKernel_Core(Vector128{long}, ValueTuple{Vector128{long}, Vector128{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleKernel_Core(this IWVectorTraits128 athis, Vector128<long> vector, (Vector128<long> args0, Vector128<long> args1) args) {
            return athis.YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleKernel_Core(Vector128{ulong}, ValueTuple{Vector128{ulong}, Vector128{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleKernel_Core(this IWVectorTraits128 athis, Vector128<ulong> vector, (Vector128<ulong> args0, Vector128<ulong> args1) args) {
            return athis.YShuffleKernel_Core(vector, args.args0, args.args1);
        }


        /// <inheritdoc cref="Vector128s.YShuffleX2_Args{TIdx}(Vector128{TIdx}, out Vector128{TIdx}, out Vector128{TIdx}, out Vector128{TIdx}, out Vector128{TIdx}, out Vector128{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleX2_Args<TIdx>(this IWVectorTraits128 athis, Vector128<TIdx> indices, out Vector128<TIdx> args0, out Vector128<TIdx> args1, out Vector128<TIdx> args2, out Vector128<TIdx> args3, out Vector128<TIdx> args4)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2_Args((Vector128<sbyte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2_Args((Vector128<byte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2_Args((Vector128<short>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2_Args((Vector128<ushort>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2_Args((Vector128<int>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2_Args((Vector128<uint>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2_Args((Vector128<long>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2_Args((Vector128<ulong>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2_Args{TIdx}(Vector128{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<TIdx> args0, Vector128<TIdx> args1, Vector128<TIdx> args2, Vector128<TIdx> args3, Vector128<TIdx> args4) YShuffleX2_Args<TIdx>(this IWVectorTraits128 athis, Vector128<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2_Args(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) YShuffleX2_Args(this IWVectorTraits128 athis, Vector128<sbyte> indices) {
            athis.YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2_Args(Vector128{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) YShuffleX2_Args(this IWVectorTraits128 athis, Vector128<byte> indices) {
            athis.YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2_Args(Vector128{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) YShuffleX2_Args(this IWVectorTraits128 athis, Vector128<short> indices) {
            athis.YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2_Args(Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) YShuffleX2_Args(this IWVectorTraits128 athis, Vector128<ushort> indices) {
            athis.YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2_Args(Vector128{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) YShuffleX2_Args(this IWVectorTraits128 athis, Vector128<int> indices) {
            athis.YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2_Args(Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) YShuffleX2_Args(this IWVectorTraits128 athis, Vector128<uint> indices) {
            athis.YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2_Args(Vector128{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) YShuffleX2_Args(this IWVectorTraits128 athis, Vector128<long> indices) {
            athis.YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2_Args(Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) YShuffleX2_Args(this IWVectorTraits128 athis, Vector128<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2_Core(Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<T> YShuffleX2_Core<T, TIdx>(this IWVectorTraits128 athis, Vector128<T> vector0, Vector128<T> vector1, (Vector128<TIdx> args0, Vector128<TIdx> args1, Vector128<TIdx> args2, Vector128<TIdx> args3, Vector128<TIdx> args4) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX2_Core((Vector128<float>)(object)vector0, (Vector128<float>)(object)vector1, (ValueTuple<Vector128<int>, Vector128<int>, Vector128<int>, Vector128<int>, Vector128<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX2_Core((Vector128<double>)(object)vector0, (Vector128<double>)(object)vector1, (ValueTuple<Vector128<long>, Vector128<long>, Vector128<long>, Vector128<long>, Vector128<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX2_Core((Vector128<sbyte>)(object)vector0, (Vector128<sbyte>)(object)vector1, (ValueTuple<Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX2_Core((Vector128<byte>)(object)vector0, (Vector128<byte>)(object)vector1, (ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>, Vector128<byte>, Vector128<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX2_Core((Vector128<short>)(object)vector0, (Vector128<short>)(object)vector1, (ValueTuple<Vector128<short>, Vector128<short>, Vector128<short>, Vector128<short>, Vector128<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX2_Core((Vector128<ushort>)(object)vector0, (Vector128<ushort>)(object)vector1, (ValueTuple<Vector128<ushort>, Vector128<ushort>, Vector128<ushort>, Vector128<ushort>, Vector128<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX2_Core((Vector128<int>)(object)vector0, (Vector128<int>)(object)vector1, (ValueTuple<Vector128<int>, Vector128<int>, Vector128<int>, Vector128<int>, Vector128<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX2_Core((Vector128<uint>)(object)vector0, (Vector128<uint>)(object)vector1, (ValueTuple<Vector128<uint>, Vector128<uint>, Vector128<uint>, Vector128<uint>, Vector128<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX2_Core((Vector128<long>)(object)vector0, (Vector128<long>)(object)vector1, (ValueTuple<Vector128<long>, Vector128<long>, Vector128<long>, Vector128<long>, Vector128<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX2_Core((Vector128<ulong>)(object)vector0, (Vector128<ulong>)(object)vector1, (ValueTuple<Vector128<ulong>, Vector128<ulong>, Vector128<ulong>, Vector128<ulong>, Vector128<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2_Core(Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleX2_Core(this IWVectorTraits128 athis, Vector128<float> vector0, Vector128<float> vector1, (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) args) {
            return athis.YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2_Core(Vector128{double}, Vector128{double}, ValueTuple{Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleX2_Core(this IWVectorTraits128 athis, Vector128<double> vector0, Vector128<double> vector1, (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) args) {
            return athis.YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2_Core(Vector128{sbyte}, Vector128{sbyte}, ValueTuple{Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleX2_Core(this IWVectorTraits128 athis, Vector128<sbyte> vector0, Vector128<sbyte> vector1, (Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) args) {
            return athis.YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2_Core(Vector128{byte}, Vector128{byte}, ValueTuple{Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleX2_Core(this IWVectorTraits128 athis, Vector128<byte> vector0, Vector128<byte> vector1, (Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) args) {
            return athis.YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2_Core(Vector128{short}, Vector128{short}, ValueTuple{Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleX2_Core(this IWVectorTraits128 athis, Vector128<short> vector0, Vector128<short> vector1, (Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) args) {
            return athis.YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2_Core(Vector128{ushort}, Vector128{ushort}, ValueTuple{Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleX2_Core(this IWVectorTraits128 athis, Vector128<ushort> vector0, Vector128<ushort> vector1, (Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) args) {
            return athis.YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2_Core(Vector128{int}, Vector128{int}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleX2_Core(this IWVectorTraits128 athis, Vector128<int> vector0, Vector128<int> vector1, (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) args) {
            return athis.YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2_Core(Vector128{uint}, Vector128{uint}, ValueTuple{Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleX2_Core(this IWVectorTraits128 athis, Vector128<uint> vector0, Vector128<uint> vector1, (Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) args) {
            return athis.YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2_Core(Vector128{long}, Vector128{long}, ValueTuple{Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleX2_Core(this IWVectorTraits128 athis, Vector128<long> vector0, Vector128<long> vector1, (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) args) {
            return athis.YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2_Core(Vector128{ulong}, Vector128{ulong}, ValueTuple{Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleX2_Core(this IWVectorTraits128 athis, Vector128<ulong> vector0, Vector128<ulong> vector1, (Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) args) {
            return athis.YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }


        /// <inheritdoc cref="Vector128s.YShuffleX2Insert_Args{TIdx}(Vector128{TIdx}, out Vector128{TIdx}, out Vector128{TIdx}, out Vector128{TIdx}, out Vector128{TIdx}, out Vector128{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleX2Insert_Args<TIdx>(this IWVectorTraits128 athis, Vector128<TIdx> indices, out Vector128<TIdx> args0, out Vector128<TIdx> args1, out Vector128<TIdx> args2, out Vector128<TIdx> args3, out Vector128<TIdx> args4)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2Insert_Args((Vector128<sbyte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2Insert_Args((Vector128<byte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2Insert_Args((Vector128<short>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2Insert_Args((Vector128<ushort>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2Insert_Args((Vector128<int>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2Insert_Args((Vector128<uint>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2Insert_Args((Vector128<long>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX2Insert_Args((Vector128<ulong>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2Insert_Args{TIdx}(Vector128{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<TIdx> args0, Vector128<TIdx> args1, Vector128<TIdx> args2, Vector128<TIdx> args3, Vector128<TIdx> args4) YShuffleX2Insert_Args<TIdx>(this IWVectorTraits128 athis, Vector128<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2Insert_Args(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) YShuffleX2Insert_Args(this IWVectorTraits128 athis, Vector128<sbyte> indices) {
            athis.YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2Insert_Args(Vector128{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) YShuffleX2Insert_Args(this IWVectorTraits128 athis, Vector128<byte> indices) {
            athis.YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2Insert_Args(Vector128{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) YShuffleX2Insert_Args(this IWVectorTraits128 athis, Vector128<short> indices) {
            athis.YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2Insert_Args(Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) YShuffleX2Insert_Args(this IWVectorTraits128 athis, Vector128<ushort> indices) {
            athis.YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2Insert_Args(Vector128{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) YShuffleX2Insert_Args(this IWVectorTraits128 athis, Vector128<int> indices) {
            athis.YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2Insert_Args(Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) YShuffleX2Insert_Args(this IWVectorTraits128 athis, Vector128<uint> indices) {
            athis.YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2Insert_Args(Vector128{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) YShuffleX2Insert_Args(this IWVectorTraits128 athis, Vector128<long> indices) {
            athis.YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2Insert_Args(Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) YShuffleX2Insert_Args(this IWVectorTraits128 athis, Vector128<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<T> YShuffleX2Insert_Core<T, TIdx>(this IWVectorTraits128 athis, Vector128<T> back, Vector128<T> vector0, Vector128<T> vector1, (Vector128<TIdx> args0, Vector128<TIdx> args1, Vector128<TIdx> args2, Vector128<TIdx> args3, Vector128<TIdx> args4) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX2Insert_Core((Vector128<float>)(object)back, (Vector128<float>)(object)vector0, (Vector128<float>)(object)vector1, (ValueTuple<Vector128<int>, Vector128<int>, Vector128<int>, Vector128<int>, Vector128<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX2Insert_Core((Vector128<double>)(object)back, (Vector128<double>)(object)vector0, (Vector128<double>)(object)vector1, (ValueTuple<Vector128<long>, Vector128<long>, Vector128<long>, Vector128<long>, Vector128<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX2Insert_Core((Vector128<sbyte>)(object)back, (Vector128<sbyte>)(object)vector0, (Vector128<sbyte>)(object)vector1, (ValueTuple<Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX2Insert_Core((Vector128<byte>)(object)back, (Vector128<byte>)(object)vector0, (Vector128<byte>)(object)vector1, (ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>, Vector128<byte>, Vector128<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX2Insert_Core((Vector128<short>)(object)back, (Vector128<short>)(object)vector0, (Vector128<short>)(object)vector1, (ValueTuple<Vector128<short>, Vector128<short>, Vector128<short>, Vector128<short>, Vector128<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX2Insert_Core((Vector128<ushort>)(object)back, (Vector128<ushort>)(object)vector0, (Vector128<ushort>)(object)vector1, (ValueTuple<Vector128<ushort>, Vector128<ushort>, Vector128<ushort>, Vector128<ushort>, Vector128<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX2Insert_Core((Vector128<int>)(object)back, (Vector128<int>)(object)vector0, (Vector128<int>)(object)vector1, (ValueTuple<Vector128<int>, Vector128<int>, Vector128<int>, Vector128<int>, Vector128<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX2Insert_Core((Vector128<uint>)(object)back, (Vector128<uint>)(object)vector0, (Vector128<uint>)(object)vector1, (ValueTuple<Vector128<uint>, Vector128<uint>, Vector128<uint>, Vector128<uint>, Vector128<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX2Insert_Core((Vector128<long>)(object)back, (Vector128<long>)(object)vector0, (Vector128<long>)(object)vector1, (ValueTuple<Vector128<long>, Vector128<long>, Vector128<long>, Vector128<long>, Vector128<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX2Insert_Core((Vector128<ulong>)(object)back, (Vector128<ulong>)(object)vector0, (Vector128<ulong>)(object)vector1, (ValueTuple<Vector128<ulong>, Vector128<ulong>, Vector128<ulong>, Vector128<ulong>, Vector128<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleX2Insert_Core(this IWVectorTraits128 athis, Vector128<float> back, Vector128<float> vector0, Vector128<float> vector1, (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) args) {
            return athis.YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2Insert_Core(Vector128{double}, Vector128{double}, Vector128{double}, ValueTuple{Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleX2Insert_Core(this IWVectorTraits128 athis, Vector128<double> back, Vector128<double> vector0, Vector128<double> vector1, (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) args) {
            return athis.YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2Insert_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, ValueTuple{Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleX2Insert_Core(this IWVectorTraits128 athis, Vector128<sbyte> back, Vector128<sbyte> vector0, Vector128<sbyte> vector1, (Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) args) {
            return athis.YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2Insert_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, ValueTuple{Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleX2Insert_Core(this IWVectorTraits128 athis, Vector128<byte> back, Vector128<byte> vector0, Vector128<byte> vector1, (Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) args) {
            return athis.YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2Insert_Core(Vector128{short}, Vector128{short}, Vector128{short}, ValueTuple{Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleX2Insert_Core(this IWVectorTraits128 athis, Vector128<short> back, Vector128<short> vector0, Vector128<short> vector1, (Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) args) {
            return athis.YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2Insert_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, ValueTuple{Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleX2Insert_Core(this IWVectorTraits128 athis, Vector128<ushort> back, Vector128<ushort> vector0, Vector128<ushort> vector1, (Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) args) {
            return athis.YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2Insert_Core(Vector128{int}, Vector128{int}, Vector128{int}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleX2Insert_Core(this IWVectorTraits128 athis, Vector128<int> back, Vector128<int> vector0, Vector128<int> vector1, (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) args) {
            return athis.YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2Insert_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, ValueTuple{Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleX2Insert_Core(this IWVectorTraits128 athis, Vector128<uint> back, Vector128<uint> vector0, Vector128<uint> vector1, (Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) args) {
            return athis.YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2Insert_Core(Vector128{long}, Vector128{long}, Vector128{long}, ValueTuple{Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleX2Insert_Core(this IWVectorTraits128 athis, Vector128<long> back, Vector128<long> vector0, Vector128<long> vector1, (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) args) {
            return athis.YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2Insert_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, ValueTuple{Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleX2Insert_Core(this IWVectorTraits128 athis, Vector128<ulong> back, Vector128<ulong> vector0, Vector128<ulong> vector1, (Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) args) {
            return athis.YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }


        /// <inheritdoc cref="Vector128s.YShuffleX2Kernel_Args{TIdx}(Vector128{TIdx}, out Vector128{TIdx}, out Vector128{TIdx}, out Vector128{TIdx}, out Vector128{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleX2Kernel_Args<TIdx>(this IWVectorTraits128 athis, Vector128<TIdx> indices, out Vector128<TIdx> args0, out Vector128<TIdx> args1, out Vector128<TIdx> args2, out Vector128<TIdx> args3)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX2Kernel_Args((Vector128<sbyte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX2Kernel_Args((Vector128<byte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX2Kernel_Args((Vector128<short>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX2Kernel_Args((Vector128<ushort>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX2Kernel_Args((Vector128<int>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX2Kernel_Args((Vector128<uint>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX2Kernel_Args((Vector128<long>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX2Kernel_Args((Vector128<ulong>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2Kernel_Args{TIdx}(Vector128{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<TIdx> args0, Vector128<TIdx> args1, Vector128<TIdx> args2, Vector128<TIdx> args3) YShuffleX2Kernel_Args<TIdx>(this IWVectorTraits128 athis, Vector128<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2Kernel_Args(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3) YShuffleX2Kernel_Args(this IWVectorTraits128 athis, Vector128<sbyte> indices) {
            athis.YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2Kernel_Args(Vector128{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3) YShuffleX2Kernel_Args(this IWVectorTraits128 athis, Vector128<byte> indices) {
            athis.YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2Kernel_Args(Vector128{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3) YShuffleX2Kernel_Args(this IWVectorTraits128 athis, Vector128<short> indices) {
            athis.YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2Kernel_Args(Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3) YShuffleX2Kernel_Args(this IWVectorTraits128 athis, Vector128<ushort> indices) {
            athis.YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2Kernel_Args(Vector128{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3) YShuffleX2Kernel_Args(this IWVectorTraits128 athis, Vector128<int> indices) {
            athis.YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2Kernel_Args(Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3) YShuffleX2Kernel_Args(this IWVectorTraits128 athis, Vector128<uint> indices) {
            athis.YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2Kernel_Args(Vector128{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3) YShuffleX2Kernel_Args(this IWVectorTraits128 athis, Vector128<long> indices) {
            athis.YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2Kernel_Args(Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3) YShuffleX2Kernel_Args(this IWVectorTraits128 athis, Vector128<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<T> YShuffleX2Kernel_Core<T, TIdx>(this IWVectorTraits128 athis, Vector128<T> vector0, Vector128<T> vector1, (Vector128<TIdx> args0, Vector128<TIdx> args1, Vector128<TIdx> args2, Vector128<TIdx> args3) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX2Kernel_Core((Vector128<float>)(object)vector0, (Vector128<float>)(object)vector1, (ValueTuple<Vector128<int>, Vector128<int>, Vector128<int>, Vector128<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX2Kernel_Core((Vector128<double>)(object)vector0, (Vector128<double>)(object)vector1, (ValueTuple<Vector128<long>, Vector128<long>, Vector128<long>, Vector128<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX2Kernel_Core((Vector128<sbyte>)(object)vector0, (Vector128<sbyte>)(object)vector1, (ValueTuple<Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX2Kernel_Core((Vector128<byte>)(object)vector0, (Vector128<byte>)(object)vector1, (ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>, Vector128<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX2Kernel_Core((Vector128<short>)(object)vector0, (Vector128<short>)(object)vector1, (ValueTuple<Vector128<short>, Vector128<short>, Vector128<short>, Vector128<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX2Kernel_Core((Vector128<ushort>)(object)vector0, (Vector128<ushort>)(object)vector1, (ValueTuple<Vector128<ushort>, Vector128<ushort>, Vector128<ushort>, Vector128<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX2Kernel_Core((Vector128<int>)(object)vector0, (Vector128<int>)(object)vector1, (ValueTuple<Vector128<int>, Vector128<int>, Vector128<int>, Vector128<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX2Kernel_Core((Vector128<uint>)(object)vector0, (Vector128<uint>)(object)vector1, (ValueTuple<Vector128<uint>, Vector128<uint>, Vector128<uint>, Vector128<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX2Kernel_Core((Vector128<long>)(object)vector0, (Vector128<long>)(object)vector1, (ValueTuple<Vector128<long>, Vector128<long>, Vector128<long>, Vector128<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX2Kernel_Core((Vector128<ulong>)(object)vector0, (Vector128<ulong>)(object)vector1, (ValueTuple<Vector128<ulong>, Vector128<ulong>, Vector128<ulong>, Vector128<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2Kernel_Core(Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleX2Kernel_Core(this IWVectorTraits128 athis, Vector128<float> vector0, Vector128<float> vector1, (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3) args) {
            return athis.YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2Kernel_Core(Vector128{double}, Vector128{double}, ValueTuple{Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleX2Kernel_Core(this IWVectorTraits128 athis, Vector128<double> vector0, Vector128<double> vector1, (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3) args) {
            return athis.YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2Kernel_Core(Vector128{sbyte}, Vector128{sbyte}, ValueTuple{Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleX2Kernel_Core(this IWVectorTraits128 athis, Vector128<sbyte> vector0, Vector128<sbyte> vector1, (Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3) args) {
            return athis.YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2Kernel_Core(Vector128{byte}, Vector128{byte}, ValueTuple{Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleX2Kernel_Core(this IWVectorTraits128 athis, Vector128<byte> vector0, Vector128<byte> vector1, (Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3) args) {
            return athis.YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2Kernel_Core(Vector128{short}, Vector128{short}, ValueTuple{Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleX2Kernel_Core(this IWVectorTraits128 athis, Vector128<short> vector0, Vector128<short> vector1, (Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3) args) {
            return athis.YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2Kernel_Core(Vector128{ushort}, Vector128{ushort}, ValueTuple{Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleX2Kernel_Core(this IWVectorTraits128 athis, Vector128<ushort> vector0, Vector128<ushort> vector1, (Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3) args) {
            return athis.YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2Kernel_Core(Vector128{int}, Vector128{int}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleX2Kernel_Core(this IWVectorTraits128 athis, Vector128<int> vector0, Vector128<int> vector1, (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3) args) {
            return athis.YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2Kernel_Core(Vector128{uint}, Vector128{uint}, ValueTuple{Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleX2Kernel_Core(this IWVectorTraits128 athis, Vector128<uint> vector0, Vector128<uint> vector1, (Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3) args) {
            return athis.YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2Kernel_Core(Vector128{long}, Vector128{long}, ValueTuple{Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleX2Kernel_Core(this IWVectorTraits128 athis, Vector128<long> vector0, Vector128<long> vector1, (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3) args) {
            return athis.YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX2Kernel_Core(Vector128{ulong}, Vector128{ulong}, ValueTuple{Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleX2Kernel_Core(this IWVectorTraits128 athis, Vector128<ulong> vector0, Vector128<ulong> vector1, (Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3) args) {
            return athis.YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }


        /// <inheritdoc cref="Vector128s.YShuffleX3_Args{TIdx}(Vector128{TIdx}, out Vector128{TIdx}, out Vector128{TIdx}, out Vector128{TIdx}, out Vector128{TIdx}, out Vector128{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleX3_Args<TIdx>(this IWVectorTraits128 athis, Vector128<TIdx> indices, out Vector128<TIdx> args0, out Vector128<TIdx> args1, out Vector128<TIdx> args2, out Vector128<TIdx> args3, out Vector128<TIdx> args4)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3_Args((Vector128<sbyte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3_Args((Vector128<byte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3_Args((Vector128<short>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3_Args((Vector128<ushort>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3_Args((Vector128<int>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3_Args((Vector128<uint>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3_Args((Vector128<long>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3_Args((Vector128<ulong>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3_Args{TIdx}(Vector128{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<TIdx> args0, Vector128<TIdx> args1, Vector128<TIdx> args2, Vector128<TIdx> args3, Vector128<TIdx> args4) YShuffleX3_Args<TIdx>(this IWVectorTraits128 athis, Vector128<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3_Args(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) YShuffleX3_Args(this IWVectorTraits128 athis, Vector128<sbyte> indices) {
            athis.YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3_Args(Vector128{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) YShuffleX3_Args(this IWVectorTraits128 athis, Vector128<byte> indices) {
            athis.YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3_Args(Vector128{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) YShuffleX3_Args(this IWVectorTraits128 athis, Vector128<short> indices) {
            athis.YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3_Args(Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) YShuffleX3_Args(this IWVectorTraits128 athis, Vector128<ushort> indices) {
            athis.YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3_Args(Vector128{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) YShuffleX3_Args(this IWVectorTraits128 athis, Vector128<int> indices) {
            athis.YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3_Args(Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) YShuffleX3_Args(this IWVectorTraits128 athis, Vector128<uint> indices) {
            athis.YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3_Args(Vector128{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) YShuffleX3_Args(this IWVectorTraits128 athis, Vector128<long> indices) {
            athis.YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3_Args(Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) YShuffleX3_Args(this IWVectorTraits128 athis, Vector128<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<T> YShuffleX3_Core<T, TIdx>(this IWVectorTraits128 athis, Vector128<T> vector0, Vector128<T> vector1, Vector128<T> vector2, (Vector128<TIdx> args0, Vector128<TIdx> args1, Vector128<TIdx> args2, Vector128<TIdx> args3, Vector128<TIdx> args4) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX3_Core((Vector128<float>)(object)vector0, (Vector128<float>)(object)vector1, (Vector128<float>)(object)vector2, (ValueTuple<Vector128<int>, Vector128<int>, Vector128<int>, Vector128<int>, Vector128<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX3_Core((Vector128<double>)(object)vector0, (Vector128<double>)(object)vector1, (Vector128<double>)(object)vector2, (ValueTuple<Vector128<long>, Vector128<long>, Vector128<long>, Vector128<long>, Vector128<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX3_Core((Vector128<sbyte>)(object)vector0, (Vector128<sbyte>)(object)vector1, (Vector128<sbyte>)(object)vector2, (ValueTuple<Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX3_Core((Vector128<byte>)(object)vector0, (Vector128<byte>)(object)vector1, (Vector128<byte>)(object)vector2, (ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>, Vector128<byte>, Vector128<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX3_Core((Vector128<short>)(object)vector0, (Vector128<short>)(object)vector1, (Vector128<short>)(object)vector2, (ValueTuple<Vector128<short>, Vector128<short>, Vector128<short>, Vector128<short>, Vector128<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX3_Core((Vector128<ushort>)(object)vector0, (Vector128<ushort>)(object)vector1, (Vector128<ushort>)(object)vector2, (ValueTuple<Vector128<ushort>, Vector128<ushort>, Vector128<ushort>, Vector128<ushort>, Vector128<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX3_Core((Vector128<int>)(object)vector0, (Vector128<int>)(object)vector1, (Vector128<int>)(object)vector2, (ValueTuple<Vector128<int>, Vector128<int>, Vector128<int>, Vector128<int>, Vector128<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX3_Core((Vector128<uint>)(object)vector0, (Vector128<uint>)(object)vector1, (Vector128<uint>)(object)vector2, (ValueTuple<Vector128<uint>, Vector128<uint>, Vector128<uint>, Vector128<uint>, Vector128<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX3_Core((Vector128<long>)(object)vector0, (Vector128<long>)(object)vector1, (Vector128<long>)(object)vector2, (ValueTuple<Vector128<long>, Vector128<long>, Vector128<long>, Vector128<long>, Vector128<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX3_Core((Vector128<ulong>)(object)vector0, (Vector128<ulong>)(object)vector1, (Vector128<ulong>)(object)vector2, (ValueTuple<Vector128<ulong>, Vector128<ulong>, Vector128<ulong>, Vector128<ulong>, Vector128<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3_Core(Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleX3_Core(this IWVectorTraits128 athis, Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) args) {
            return athis.YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3_Core(Vector128{double}, Vector128{double}, Vector128{double}, ValueTuple{Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleX3_Core(this IWVectorTraits128 athis, Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) args) {
            return athis.YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, ValueTuple{Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleX3_Core(this IWVectorTraits128 athis, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, (Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) args) {
            return athis.YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, ValueTuple{Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleX3_Core(this IWVectorTraits128 athis, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, (Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) args) {
            return athis.YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3_Core(Vector128{short}, Vector128{short}, Vector128{short}, ValueTuple{Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleX3_Core(this IWVectorTraits128 athis, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, (Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) args) {
            return athis.YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, ValueTuple{Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleX3_Core(this IWVectorTraits128 athis, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, (Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) args) {
            return athis.YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3_Core(Vector128{int}, Vector128{int}, Vector128{int}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleX3_Core(this IWVectorTraits128 athis, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) args) {
            return athis.YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, ValueTuple{Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleX3_Core(this IWVectorTraits128 athis, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, (Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) args) {
            return athis.YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3_Core(Vector128{long}, Vector128{long}, Vector128{long}, ValueTuple{Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleX3_Core(this IWVectorTraits128 athis, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) args) {
            return athis.YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, ValueTuple{Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleX3_Core(this IWVectorTraits128 athis, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, (Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) args) {
            return athis.YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }


        /// <inheritdoc cref="Vector128s.YShuffleX3Insert_Args{TIdx}(Vector128{TIdx}, out Vector128{TIdx}, out Vector128{TIdx}, out Vector128{TIdx}, out Vector128{TIdx}, out Vector128{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleX3Insert_Args<TIdx>(this IWVectorTraits128 athis, Vector128<TIdx> indices, out Vector128<TIdx> args0, out Vector128<TIdx> args1, out Vector128<TIdx> args2, out Vector128<TIdx> args3, out Vector128<TIdx> args4)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3Insert_Args((Vector128<sbyte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3Insert_Args((Vector128<byte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3Insert_Args((Vector128<short>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3Insert_Args((Vector128<ushort>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3Insert_Args((Vector128<int>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3Insert_Args((Vector128<uint>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3Insert_Args((Vector128<long>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX3Insert_Args((Vector128<ulong>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3Insert_Args{TIdx}(Vector128{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<TIdx> args0, Vector128<TIdx> args1, Vector128<TIdx> args2, Vector128<TIdx> args3, Vector128<TIdx> args4) YShuffleX3Insert_Args<TIdx>(this IWVectorTraits128 athis, Vector128<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3Insert_Args(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) YShuffleX3Insert_Args(this IWVectorTraits128 athis, Vector128<sbyte> indices) {
            athis.YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3Insert_Args(Vector128{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) YShuffleX3Insert_Args(this IWVectorTraits128 athis, Vector128<byte> indices) {
            athis.YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3Insert_Args(Vector128{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) YShuffleX3Insert_Args(this IWVectorTraits128 athis, Vector128<short> indices) {
            athis.YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3Insert_Args(Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) YShuffleX3Insert_Args(this IWVectorTraits128 athis, Vector128<ushort> indices) {
            athis.YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3Insert_Args(Vector128{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) YShuffleX3Insert_Args(this IWVectorTraits128 athis, Vector128<int> indices) {
            athis.YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3Insert_Args(Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) YShuffleX3Insert_Args(this IWVectorTraits128 athis, Vector128<uint> indices) {
            athis.YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3Insert_Args(Vector128{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) YShuffleX3Insert_Args(this IWVectorTraits128 athis, Vector128<long> indices) {
            athis.YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3Insert_Args(Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) YShuffleX3Insert_Args(this IWVectorTraits128 athis, Vector128<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<T> YShuffleX3Insert_Core<T, TIdx>(this IWVectorTraits128 athis, Vector128<T> back, Vector128<T> vector0, Vector128<T> vector1, Vector128<T> vector2, (Vector128<TIdx> args0, Vector128<TIdx> args1, Vector128<TIdx> args2, Vector128<TIdx> args3, Vector128<TIdx> args4) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX3Insert_Core((Vector128<float>)(object)back, (Vector128<float>)(object)vector0, (Vector128<float>)(object)vector1, (Vector128<float>)(object)vector2, (ValueTuple<Vector128<int>, Vector128<int>, Vector128<int>, Vector128<int>, Vector128<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX3Insert_Core((Vector128<double>)(object)back, (Vector128<double>)(object)vector0, (Vector128<double>)(object)vector1, (Vector128<double>)(object)vector2, (ValueTuple<Vector128<long>, Vector128<long>, Vector128<long>, Vector128<long>, Vector128<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX3Insert_Core((Vector128<sbyte>)(object)back, (Vector128<sbyte>)(object)vector0, (Vector128<sbyte>)(object)vector1, (Vector128<sbyte>)(object)vector2, (ValueTuple<Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX3Insert_Core((Vector128<byte>)(object)back, (Vector128<byte>)(object)vector0, (Vector128<byte>)(object)vector1, (Vector128<byte>)(object)vector2, (ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>, Vector128<byte>, Vector128<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX3Insert_Core((Vector128<short>)(object)back, (Vector128<short>)(object)vector0, (Vector128<short>)(object)vector1, (Vector128<short>)(object)vector2, (ValueTuple<Vector128<short>, Vector128<short>, Vector128<short>, Vector128<short>, Vector128<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX3Insert_Core((Vector128<ushort>)(object)back, (Vector128<ushort>)(object)vector0, (Vector128<ushort>)(object)vector1, (Vector128<ushort>)(object)vector2, (ValueTuple<Vector128<ushort>, Vector128<ushort>, Vector128<ushort>, Vector128<ushort>, Vector128<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX3Insert_Core((Vector128<int>)(object)back, (Vector128<int>)(object)vector0, (Vector128<int>)(object)vector1, (Vector128<int>)(object)vector2, (ValueTuple<Vector128<int>, Vector128<int>, Vector128<int>, Vector128<int>, Vector128<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX3Insert_Core((Vector128<uint>)(object)back, (Vector128<uint>)(object)vector0, (Vector128<uint>)(object)vector1, (Vector128<uint>)(object)vector2, (ValueTuple<Vector128<uint>, Vector128<uint>, Vector128<uint>, Vector128<uint>, Vector128<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX3Insert_Core((Vector128<long>)(object)back, (Vector128<long>)(object)vector0, (Vector128<long>)(object)vector1, (Vector128<long>)(object)vector2, (ValueTuple<Vector128<long>, Vector128<long>, Vector128<long>, Vector128<long>, Vector128<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX3Insert_Core((Vector128<ulong>)(object)back, (Vector128<ulong>)(object)vector0, (Vector128<ulong>)(object)vector1, (Vector128<ulong>)(object)vector2, (ValueTuple<Vector128<ulong>, Vector128<ulong>, Vector128<ulong>, Vector128<ulong>, Vector128<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleX3Insert_Core(this IWVectorTraits128 athis, Vector128<float> back, Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) args) {
            return athis.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3Insert_Core(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, ValueTuple{Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleX3Insert_Core(this IWVectorTraits128 athis, Vector128<double> back, Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) args) {
            return athis.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3Insert_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, ValueTuple{Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleX3Insert_Core(this IWVectorTraits128 athis, Vector128<sbyte> back, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, (Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) args) {
            return athis.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3Insert_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, ValueTuple{Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleX3Insert_Core(this IWVectorTraits128 athis, Vector128<byte> back, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, (Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) args) {
            return athis.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3Insert_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, ValueTuple{Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleX3Insert_Core(this IWVectorTraits128 athis, Vector128<short> back, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, (Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) args) {
            return athis.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3Insert_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, ValueTuple{Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleX3Insert_Core(this IWVectorTraits128 athis, Vector128<ushort> back, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, (Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) args) {
            return athis.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3Insert_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleX3Insert_Core(this IWVectorTraits128 athis, Vector128<int> back, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) args) {
            return athis.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3Insert_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, ValueTuple{Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleX3Insert_Core(this IWVectorTraits128 athis, Vector128<uint> back, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, (Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) args) {
            return athis.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3Insert_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, ValueTuple{Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleX3Insert_Core(this IWVectorTraits128 athis, Vector128<long> back, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) args) {
            return athis.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3Insert_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, ValueTuple{Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleX3Insert_Core(this IWVectorTraits128 athis, Vector128<ulong> back, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, (Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) args) {
            return athis.YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }


        /// <inheritdoc cref="Vector128s.YShuffleX3Kernel_Args{TIdx}(Vector128{TIdx}, out Vector128{TIdx}, out Vector128{TIdx}, out Vector128{TIdx}, out Vector128{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleX3Kernel_Args<TIdx>(this IWVectorTraits128 athis, Vector128<TIdx> indices, out Vector128<TIdx> args0, out Vector128<TIdx> args1, out Vector128<TIdx> args2, out Vector128<TIdx> args3)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX3Kernel_Args((Vector128<sbyte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX3Kernel_Args((Vector128<byte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX3Kernel_Args((Vector128<short>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX3Kernel_Args((Vector128<ushort>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX3Kernel_Args((Vector128<int>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX3Kernel_Args((Vector128<uint>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX3Kernel_Args((Vector128<long>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX3Kernel_Args((Vector128<ulong>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3Kernel_Args{TIdx}(Vector128{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<TIdx> args0, Vector128<TIdx> args1, Vector128<TIdx> args2, Vector128<TIdx> args3) YShuffleX3Kernel_Args<TIdx>(this IWVectorTraits128 athis, Vector128<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3Kernel_Args(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3) YShuffleX3Kernel_Args(this IWVectorTraits128 athis, Vector128<sbyte> indices) {
            athis.YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3Kernel_Args(Vector128{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3) YShuffleX3Kernel_Args(this IWVectorTraits128 athis, Vector128<byte> indices) {
            athis.YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3Kernel_Args(Vector128{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3) YShuffleX3Kernel_Args(this IWVectorTraits128 athis, Vector128<short> indices) {
            athis.YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3Kernel_Args(Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3) YShuffleX3Kernel_Args(this IWVectorTraits128 athis, Vector128<ushort> indices) {
            athis.YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3Kernel_Args(Vector128{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3) YShuffleX3Kernel_Args(this IWVectorTraits128 athis, Vector128<int> indices) {
            athis.YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3Kernel_Args(Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3) YShuffleX3Kernel_Args(this IWVectorTraits128 athis, Vector128<uint> indices) {
            athis.YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3Kernel_Args(Vector128{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3) YShuffleX3Kernel_Args(this IWVectorTraits128 athis, Vector128<long> indices) {
            athis.YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3Kernel_Args(Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3) YShuffleX3Kernel_Args(this IWVectorTraits128 athis, Vector128<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<T> YShuffleX3Kernel_Core<T, TIdx>(this IWVectorTraits128 athis, Vector128<T> vector0, Vector128<T> vector1, Vector128<T> vector2, (Vector128<TIdx> args0, Vector128<TIdx> args1, Vector128<TIdx> args2, Vector128<TIdx> args3) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX3Kernel_Core((Vector128<float>)(object)vector0, (Vector128<float>)(object)vector1, (Vector128<float>)(object)vector2, (ValueTuple<Vector128<int>, Vector128<int>, Vector128<int>, Vector128<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX3Kernel_Core((Vector128<double>)(object)vector0, (Vector128<double>)(object)vector1, (Vector128<double>)(object)vector2, (ValueTuple<Vector128<long>, Vector128<long>, Vector128<long>, Vector128<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX3Kernel_Core((Vector128<sbyte>)(object)vector0, (Vector128<sbyte>)(object)vector1, (Vector128<sbyte>)(object)vector2, (ValueTuple<Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX3Kernel_Core((Vector128<byte>)(object)vector0, (Vector128<byte>)(object)vector1, (Vector128<byte>)(object)vector2, (ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>, Vector128<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX3Kernel_Core((Vector128<short>)(object)vector0, (Vector128<short>)(object)vector1, (Vector128<short>)(object)vector2, (ValueTuple<Vector128<short>, Vector128<short>, Vector128<short>, Vector128<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX3Kernel_Core((Vector128<ushort>)(object)vector0, (Vector128<ushort>)(object)vector1, (Vector128<ushort>)(object)vector2, (ValueTuple<Vector128<ushort>, Vector128<ushort>, Vector128<ushort>, Vector128<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX3Kernel_Core((Vector128<int>)(object)vector0, (Vector128<int>)(object)vector1, (Vector128<int>)(object)vector2, (ValueTuple<Vector128<int>, Vector128<int>, Vector128<int>, Vector128<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX3Kernel_Core((Vector128<uint>)(object)vector0, (Vector128<uint>)(object)vector1, (Vector128<uint>)(object)vector2, (ValueTuple<Vector128<uint>, Vector128<uint>, Vector128<uint>, Vector128<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX3Kernel_Core((Vector128<long>)(object)vector0, (Vector128<long>)(object)vector1, (Vector128<long>)(object)vector2, (ValueTuple<Vector128<long>, Vector128<long>, Vector128<long>, Vector128<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX3Kernel_Core((Vector128<ulong>)(object)vector0, (Vector128<ulong>)(object)vector1, (Vector128<ulong>)(object)vector2, (ValueTuple<Vector128<ulong>, Vector128<ulong>, Vector128<ulong>, Vector128<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleX3Kernel_Core(this IWVectorTraits128 athis, Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3) args) {
            return athis.YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3Kernel_Core(Vector128{double}, Vector128{double}, Vector128{double}, ValueTuple{Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleX3Kernel_Core(this IWVectorTraits128 athis, Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3) args) {
            return athis.YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3Kernel_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, ValueTuple{Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleX3Kernel_Core(this IWVectorTraits128 athis, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, (Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3) args) {
            return athis.YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3Kernel_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, ValueTuple{Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleX3Kernel_Core(this IWVectorTraits128 athis, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, (Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3) args) {
            return athis.YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3Kernel_Core(Vector128{short}, Vector128{short}, Vector128{short}, ValueTuple{Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleX3Kernel_Core(this IWVectorTraits128 athis, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, (Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3) args) {
            return athis.YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3Kernel_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, ValueTuple{Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleX3Kernel_Core(this IWVectorTraits128 athis, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, (Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3) args) {
            return athis.YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3Kernel_Core(Vector128{int}, Vector128{int}, Vector128{int}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleX3Kernel_Core(this IWVectorTraits128 athis, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3) args) {
            return athis.YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3Kernel_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, ValueTuple{Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleX3Kernel_Core(this IWVectorTraits128 athis, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, (Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3) args) {
            return athis.YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3Kernel_Core(Vector128{long}, Vector128{long}, Vector128{long}, ValueTuple{Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleX3Kernel_Core(this IWVectorTraits128 athis, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3) args) {
            return athis.YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX3Kernel_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, ValueTuple{Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleX3Kernel_Core(this IWVectorTraits128 athis, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, (Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3) args) {
            return athis.YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }


        /// <inheritdoc cref="Vector128s.YShuffleX4_Args{TIdx}(Vector128{TIdx}, out Vector128{TIdx}, out Vector128{TIdx}, out Vector128{TIdx}, out Vector128{TIdx}, out Vector128{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleX4_Args<TIdx>(this IWVectorTraits128 athis, Vector128<TIdx> indices, out Vector128<TIdx> args0, out Vector128<TIdx> args1, out Vector128<TIdx> args2, out Vector128<TIdx> args3, out Vector128<TIdx> args4)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4_Args((Vector128<sbyte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4_Args((Vector128<byte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4_Args((Vector128<short>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4_Args((Vector128<ushort>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4_Args((Vector128<int>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4_Args((Vector128<uint>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4_Args((Vector128<long>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4_Args((Vector128<ulong>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4_Args{TIdx}(Vector128{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<TIdx> args0, Vector128<TIdx> args1, Vector128<TIdx> args2, Vector128<TIdx> args3, Vector128<TIdx> args4) YShuffleX4_Args<TIdx>(this IWVectorTraits128 athis, Vector128<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4_Args(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) YShuffleX4_Args(this IWVectorTraits128 athis, Vector128<sbyte> indices) {
            athis.YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4_Args(Vector128{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) YShuffleX4_Args(this IWVectorTraits128 athis, Vector128<byte> indices) {
            athis.YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4_Args(Vector128{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) YShuffleX4_Args(this IWVectorTraits128 athis, Vector128<short> indices) {
            athis.YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4_Args(Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) YShuffleX4_Args(this IWVectorTraits128 athis, Vector128<ushort> indices) {
            athis.YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4_Args(Vector128{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) YShuffleX4_Args(this IWVectorTraits128 athis, Vector128<int> indices) {
            athis.YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4_Args(Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) YShuffleX4_Args(this IWVectorTraits128 athis, Vector128<uint> indices) {
            athis.YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4_Args(Vector128{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) YShuffleX4_Args(this IWVectorTraits128 athis, Vector128<long> indices) {
            athis.YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4_Args(Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) YShuffleX4_Args(this IWVectorTraits128 athis, Vector128<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<T> YShuffleX4_Core<T, TIdx>(this IWVectorTraits128 athis, Vector128<T> vector0, Vector128<T> vector1, Vector128<T> vector2, Vector128<T> vector3, (Vector128<TIdx> args0, Vector128<TIdx> args1, Vector128<TIdx> args2, Vector128<TIdx> args3, Vector128<TIdx> args4) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX4_Core((Vector128<float>)(object)vector0, (Vector128<float>)(object)vector1, (Vector128<float>)(object)vector2, (Vector128<float>)(object)vector3, (ValueTuple<Vector128<int>, Vector128<int>, Vector128<int>, Vector128<int>, Vector128<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX4_Core((Vector128<double>)(object)vector0, (Vector128<double>)(object)vector1, (Vector128<double>)(object)vector2, (Vector128<double>)(object)vector3, (ValueTuple<Vector128<long>, Vector128<long>, Vector128<long>, Vector128<long>, Vector128<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX4_Core((Vector128<sbyte>)(object)vector0, (Vector128<sbyte>)(object)vector1, (Vector128<sbyte>)(object)vector2, (Vector128<sbyte>)(object)vector3, (ValueTuple<Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX4_Core((Vector128<byte>)(object)vector0, (Vector128<byte>)(object)vector1, (Vector128<byte>)(object)vector2, (Vector128<byte>)(object)vector3, (ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>, Vector128<byte>, Vector128<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX4_Core((Vector128<short>)(object)vector0, (Vector128<short>)(object)vector1, (Vector128<short>)(object)vector2, (Vector128<short>)(object)vector3, (ValueTuple<Vector128<short>, Vector128<short>, Vector128<short>, Vector128<short>, Vector128<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX4_Core((Vector128<ushort>)(object)vector0, (Vector128<ushort>)(object)vector1, (Vector128<ushort>)(object)vector2, (Vector128<ushort>)(object)vector3, (ValueTuple<Vector128<ushort>, Vector128<ushort>, Vector128<ushort>, Vector128<ushort>, Vector128<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX4_Core((Vector128<int>)(object)vector0, (Vector128<int>)(object)vector1, (Vector128<int>)(object)vector2, (Vector128<int>)(object)vector3, (ValueTuple<Vector128<int>, Vector128<int>, Vector128<int>, Vector128<int>, Vector128<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX4_Core((Vector128<uint>)(object)vector0, (Vector128<uint>)(object)vector1, (Vector128<uint>)(object)vector2, (Vector128<uint>)(object)vector3, (ValueTuple<Vector128<uint>, Vector128<uint>, Vector128<uint>, Vector128<uint>, Vector128<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX4_Core((Vector128<long>)(object)vector0, (Vector128<long>)(object)vector1, (Vector128<long>)(object)vector2, (Vector128<long>)(object)vector3, (ValueTuple<Vector128<long>, Vector128<long>, Vector128<long>, Vector128<long>, Vector128<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX4_Core((Vector128<ulong>)(object)vector0, (Vector128<ulong>)(object)vector1, (Vector128<ulong>)(object)vector2, (Vector128<ulong>)(object)vector3, (ValueTuple<Vector128<ulong>, Vector128<ulong>, Vector128<ulong>, Vector128<ulong>, Vector128<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleX4_Core(this IWVectorTraits128 athis, Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<float> vector3, (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) args) {
            return athis.YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4_Core(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, ValueTuple{Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleX4_Core(this IWVectorTraits128 athis, Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<double> vector3, (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) args) {
            return athis.YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, ValueTuple{Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleX4_Core(this IWVectorTraits128 athis, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, (Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) args) {
            return athis.YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, ValueTuple{Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleX4_Core(this IWVectorTraits128 athis, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, (Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) args) {
            return athis.YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, ValueTuple{Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleX4_Core(this IWVectorTraits128 athis, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, (Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) args) {
            return athis.YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, ValueTuple{Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleX4_Core(this IWVectorTraits128 athis, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, (Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) args) {
            return athis.YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleX4_Core(this IWVectorTraits128 athis, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) args) {
            return athis.YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, ValueTuple{Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleX4_Core(this IWVectorTraits128 athis, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, (Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) args) {
            return athis.YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, ValueTuple{Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleX4_Core(this IWVectorTraits128 athis, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) args) {
            return athis.YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, ValueTuple{Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleX4_Core(this IWVectorTraits128 athis, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, (Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) args) {
            return athis.YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }


        /// <inheritdoc cref="Vector128s.YShuffleX4Insert_Args{TIdx}(Vector128{TIdx}, out Vector128{TIdx}, out Vector128{TIdx}, out Vector128{TIdx}, out Vector128{TIdx}, out Vector128{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleX4Insert_Args<TIdx>(this IWVectorTraits128 athis, Vector128<TIdx> indices, out Vector128<TIdx> args0, out Vector128<TIdx> args1, out Vector128<TIdx> args2, out Vector128<TIdx> args3, out Vector128<TIdx> args4)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4Insert_Args((Vector128<sbyte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4Insert_Args((Vector128<byte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4Insert_Args((Vector128<short>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4Insert_Args((Vector128<ushort>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4Insert_Args((Vector128<int>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4Insert_Args((Vector128<uint>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4Insert_Args((Vector128<long>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = athis.YShuffleX4Insert_Args((Vector128<ulong>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4Insert_Args{TIdx}(Vector128{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<TIdx> args0, Vector128<TIdx> args1, Vector128<TIdx> args2, Vector128<TIdx> args3, Vector128<TIdx> args4) YShuffleX4Insert_Args<TIdx>(this IWVectorTraits128 athis, Vector128<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4Insert_Args(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) YShuffleX4Insert_Args(this IWVectorTraits128 athis, Vector128<sbyte> indices) {
            athis.YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4Insert_Args(Vector128{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) YShuffleX4Insert_Args(this IWVectorTraits128 athis, Vector128<byte> indices) {
            athis.YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4Insert_Args(Vector128{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) YShuffleX4Insert_Args(this IWVectorTraits128 athis, Vector128<short> indices) {
            athis.YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4Insert_Args(Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) YShuffleX4Insert_Args(this IWVectorTraits128 athis, Vector128<ushort> indices) {
            athis.YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4Insert_Args(Vector128{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) YShuffleX4Insert_Args(this IWVectorTraits128 athis, Vector128<int> indices) {
            athis.YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4Insert_Args(Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) YShuffleX4Insert_Args(this IWVectorTraits128 athis, Vector128<uint> indices) {
            athis.YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4Insert_Args(Vector128{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) YShuffleX4Insert_Args(this IWVectorTraits128 athis, Vector128<long> indices) {
            athis.YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4Insert_Args(Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) YShuffleX4Insert_Args(this IWVectorTraits128 athis, Vector128<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<T> YShuffleX4Insert_Core<T, TIdx>(this IWVectorTraits128 athis, Vector128<T> back, Vector128<T> vector0, Vector128<T> vector1, Vector128<T> vector2, Vector128<T> vector3, (Vector128<TIdx> args0, Vector128<TIdx> args1, Vector128<TIdx> args2, Vector128<TIdx> args3, Vector128<TIdx> args4) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX4Insert_Core((Vector128<float>)(object)back, (Vector128<float>)(object)vector0, (Vector128<float>)(object)vector1, (Vector128<float>)(object)vector2, (Vector128<float>)(object)vector3, (ValueTuple<Vector128<int>, Vector128<int>, Vector128<int>, Vector128<int>, Vector128<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX4Insert_Core((Vector128<double>)(object)back, (Vector128<double>)(object)vector0, (Vector128<double>)(object)vector1, (Vector128<double>)(object)vector2, (Vector128<double>)(object)vector3, (ValueTuple<Vector128<long>, Vector128<long>, Vector128<long>, Vector128<long>, Vector128<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX4Insert_Core((Vector128<sbyte>)(object)back, (Vector128<sbyte>)(object)vector0, (Vector128<sbyte>)(object)vector1, (Vector128<sbyte>)(object)vector2, (Vector128<sbyte>)(object)vector3, (ValueTuple<Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX4Insert_Core((Vector128<byte>)(object)back, (Vector128<byte>)(object)vector0, (Vector128<byte>)(object)vector1, (Vector128<byte>)(object)vector2, (Vector128<byte>)(object)vector3, (ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>, Vector128<byte>, Vector128<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX4Insert_Core((Vector128<short>)(object)back, (Vector128<short>)(object)vector0, (Vector128<short>)(object)vector1, (Vector128<short>)(object)vector2, (Vector128<short>)(object)vector3, (ValueTuple<Vector128<short>, Vector128<short>, Vector128<short>, Vector128<short>, Vector128<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX4Insert_Core((Vector128<ushort>)(object)back, (Vector128<ushort>)(object)vector0, (Vector128<ushort>)(object)vector1, (Vector128<ushort>)(object)vector2, (Vector128<ushort>)(object)vector3, (ValueTuple<Vector128<ushort>, Vector128<ushort>, Vector128<ushort>, Vector128<ushort>, Vector128<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX4Insert_Core((Vector128<int>)(object)back, (Vector128<int>)(object)vector0, (Vector128<int>)(object)vector1, (Vector128<int>)(object)vector2, (Vector128<int>)(object)vector3, (ValueTuple<Vector128<int>, Vector128<int>, Vector128<int>, Vector128<int>, Vector128<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX4Insert_Core((Vector128<uint>)(object)back, (Vector128<uint>)(object)vector0, (Vector128<uint>)(object)vector1, (Vector128<uint>)(object)vector2, (Vector128<uint>)(object)vector3, (ValueTuple<Vector128<uint>, Vector128<uint>, Vector128<uint>, Vector128<uint>, Vector128<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX4Insert_Core((Vector128<long>)(object)back, (Vector128<long>)(object)vector0, (Vector128<long>)(object)vector1, (Vector128<long>)(object)vector2, (Vector128<long>)(object)vector3, (ValueTuple<Vector128<long>, Vector128<long>, Vector128<long>, Vector128<long>, Vector128<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX4Insert_Core((Vector128<ulong>)(object)back, (Vector128<ulong>)(object)vector0, (Vector128<ulong>)(object)vector1, (Vector128<ulong>)(object)vector2, (Vector128<ulong>)(object)vector3, (ValueTuple<Vector128<ulong>, Vector128<ulong>, Vector128<ulong>, Vector128<ulong>, Vector128<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleX4Insert_Core(this IWVectorTraits128 athis, Vector128<float> back, Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<float> vector3, (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) args) {
            return athis.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4Insert_Core(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, ValueTuple{Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleX4Insert_Core(this IWVectorTraits128 athis, Vector128<double> back, Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<double> vector3, (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) args) {
            return athis.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4Insert_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, ValueTuple{Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleX4Insert_Core(this IWVectorTraits128 athis, Vector128<sbyte> back, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, (Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) args) {
            return athis.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4Insert_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, ValueTuple{Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleX4Insert_Core(this IWVectorTraits128 athis, Vector128<byte> back, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, (Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) args) {
            return athis.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4Insert_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, ValueTuple{Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleX4Insert_Core(this IWVectorTraits128 athis, Vector128<short> back, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, (Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) args) {
            return athis.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4Insert_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, ValueTuple{Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleX4Insert_Core(this IWVectorTraits128 athis, Vector128<ushort> back, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, (Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) args) {
            return athis.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4Insert_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleX4Insert_Core(this IWVectorTraits128 athis, Vector128<int> back, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) args) {
            return athis.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4Insert_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, ValueTuple{Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleX4Insert_Core(this IWVectorTraits128 athis, Vector128<uint> back, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, (Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) args) {
            return athis.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4Insert_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, ValueTuple{Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleX4Insert_Core(this IWVectorTraits128 athis, Vector128<long> back, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) args) {
            return athis.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4Insert_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, ValueTuple{Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleX4Insert_Core(this IWVectorTraits128 athis, Vector128<ulong> back, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, (Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) args) {
            return athis.YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }


        /// <inheritdoc cref="Vector128s.YShuffleX4Kernel_Args{TIdx}(Vector128{TIdx}, out Vector128{TIdx}, out Vector128{TIdx}, out Vector128{TIdx}, out Vector128{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void YShuffleX4Kernel_Args<TIdx>(this IWVectorTraits128 athis, Vector128<TIdx> indices, out Vector128<TIdx> args0, out Vector128<TIdx> args1, out Vector128<TIdx> args2, out Vector128<TIdx> args3)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX4Kernel_Args((Vector128<sbyte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX4Kernel_Args((Vector128<byte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX4Kernel_Args((Vector128<short>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX4Kernel_Args((Vector128<ushort>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX4Kernel_Args((Vector128<int>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX4Kernel_Args((Vector128<uint>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX4Kernel_Args((Vector128<long>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d) = athis.YShuffleX4Kernel_Args((Vector128<ulong>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4Kernel_Args{TIdx}(Vector128{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<TIdx> args0, Vector128<TIdx> args1, Vector128<TIdx> args2, Vector128<TIdx> args3) YShuffleX4Kernel_Args<TIdx>(this IWVectorTraits128 athis, Vector128<TIdx> indices)
                where TIdx : struct {
            athis.YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4Kernel_Args(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3) YShuffleX4Kernel_Args(this IWVectorTraits128 athis, Vector128<sbyte> indices) {
            athis.YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4Kernel_Args(Vector128{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3) YShuffleX4Kernel_Args(this IWVectorTraits128 athis, Vector128<byte> indices) {
            athis.YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4Kernel_Args(Vector128{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3) YShuffleX4Kernel_Args(this IWVectorTraits128 athis, Vector128<short> indices) {
            athis.YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4Kernel_Args(Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3) YShuffleX4Kernel_Args(this IWVectorTraits128 athis, Vector128<ushort> indices) {
            athis.YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4Kernel_Args(Vector128{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3) YShuffleX4Kernel_Args(this IWVectorTraits128 athis, Vector128<int> indices) {
            athis.YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4Kernel_Args(Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3) YShuffleX4Kernel_Args(this IWVectorTraits128 athis, Vector128<uint> indices) {
            athis.YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4Kernel_Args(Vector128{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3) YShuffleX4Kernel_Args(this IWVectorTraits128 athis, Vector128<long> indices) {
            athis.YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4Kernel_Args(Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3) YShuffleX4Kernel_Args(this IWVectorTraits128 athis, Vector128<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<T> YShuffleX4Kernel_Core<T, TIdx>(this IWVectorTraits128 athis, Vector128<T> vector0, Vector128<T> vector1, Vector128<T> vector2, Vector128<T> vector3, (Vector128<TIdx> args0, Vector128<TIdx> args1, Vector128<TIdx> args2, Vector128<TIdx> args3) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX4Kernel_Core((Vector128<float>)(object)vector0, (Vector128<float>)(object)vector1, (Vector128<float>)(object)vector2, (Vector128<float>)(object)vector3, (ValueTuple<Vector128<int>, Vector128<int>, Vector128<int>, Vector128<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX4Kernel_Core((Vector128<double>)(object)vector0, (Vector128<double>)(object)vector1, (Vector128<double>)(object)vector2, (Vector128<double>)(object)vector3, (ValueTuple<Vector128<long>, Vector128<long>, Vector128<long>, Vector128<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX4Kernel_Core((Vector128<sbyte>)(object)vector0, (Vector128<sbyte>)(object)vector1, (Vector128<sbyte>)(object)vector2, (Vector128<sbyte>)(object)vector3, (ValueTuple<Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX4Kernel_Core((Vector128<byte>)(object)vector0, (Vector128<byte>)(object)vector1, (Vector128<byte>)(object)vector2, (Vector128<byte>)(object)vector3, (ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>, Vector128<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX4Kernel_Core((Vector128<short>)(object)vector0, (Vector128<short>)(object)vector1, (Vector128<short>)(object)vector2, (Vector128<short>)(object)vector3, (ValueTuple<Vector128<short>, Vector128<short>, Vector128<short>, Vector128<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX4Kernel_Core((Vector128<ushort>)(object)vector0, (Vector128<ushort>)(object)vector1, (Vector128<ushort>)(object)vector2, (Vector128<ushort>)(object)vector3, (ValueTuple<Vector128<ushort>, Vector128<ushort>, Vector128<ushort>, Vector128<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX4Kernel_Core((Vector128<int>)(object)vector0, (Vector128<int>)(object)vector1, (Vector128<int>)(object)vector2, (Vector128<int>)(object)vector3, (ValueTuple<Vector128<int>, Vector128<int>, Vector128<int>, Vector128<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX4Kernel_Core((Vector128<uint>)(object)vector0, (Vector128<uint>)(object)vector1, (Vector128<uint>)(object)vector2, (Vector128<uint>)(object)vector3, (ValueTuple<Vector128<uint>, Vector128<uint>, Vector128<uint>, Vector128<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX4Kernel_Core((Vector128<long>)(object)vector0, (Vector128<long>)(object)vector1, (Vector128<long>)(object)vector2, (Vector128<long>)(object)vector3, (ValueTuple<Vector128<long>, Vector128<long>, Vector128<long>, Vector128<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.YShuffleX4Kernel_Core((Vector128<ulong>)(object)vector0, (Vector128<ulong>)(object)vector1, (Vector128<ulong>)(object)vector2, (Vector128<ulong>)(object)vector3, (ValueTuple<Vector128<ulong>, Vector128<ulong>, Vector128<ulong>, Vector128<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleX4Kernel_Core(this IWVectorTraits128 athis, Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<float> vector3, (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3) args) {
            return athis.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4Kernel_Core(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, ValueTuple{Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleX4Kernel_Core(this IWVectorTraits128 athis, Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<double> vector3, (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3) args) {
            return athis.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4Kernel_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, ValueTuple{Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleX4Kernel_Core(this IWVectorTraits128 athis, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, (Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3) args) {
            return athis.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4Kernel_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, ValueTuple{Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleX4Kernel_Core(this IWVectorTraits128 athis, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, (Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3) args) {
            return athis.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4Kernel_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, ValueTuple{Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleX4Kernel_Core(this IWVectorTraits128 athis, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, (Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3) args) {
            return athis.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4Kernel_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, ValueTuple{Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleX4Kernel_Core(this IWVectorTraits128 athis, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, (Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3) args) {
            return athis.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4Kernel_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleX4Kernel_Core(this IWVectorTraits128 athis, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3) args) {
            return athis.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4Kernel_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, ValueTuple{Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleX4Kernel_Core(this IWVectorTraits128 athis, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, (Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3) args) {
            return athis.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4Kernel_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, ValueTuple{Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleX4Kernel_Core(this IWVectorTraits128 athis, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3) args) {
            return athis.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="Vector128s.YShuffleX4Kernel_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, ValueTuple{Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleX4Kernel_Core(this IWVectorTraits128 athis, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, (Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3) args) {
            return athis.YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
