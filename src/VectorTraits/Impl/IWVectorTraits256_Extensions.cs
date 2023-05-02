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
    /// Extension methods of <seealso cref="IWVectorTraits256"/> (<seealso cref="IWVectorTraits256"/> 的扩展方法)
    /// </summary>
    public static class IWVectorTraits256_Extensions {
#if NETCOREAPP3_0_OR_GREATER

        /// <inheritdoc cref="Vector256s.Widen{T, TOut}(Vector256{T}, out Vector256{TOut}, out Vector256{TOut})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void Widen<T, TOut>(this IWVectorTraits256 athis, Vector256<T> source, out Vector256<TOut> lower, out Vector256<TOut> upper)
                 where T : struct where TOut : struct {
            if (typeof(float) == typeof(T) && typeof(double) == typeof(TOut)) {
                (Vector256<double> a, Vector256<double> b) = athis.Widen((Vector256<float>)(object)source);
                lower = (Vector256<TOut>)(object)a;
                upper = (Vector256<TOut>)(object)b;
            } else if (typeof(sbyte) == typeof(T) && typeof(short) == typeof(TOut)) {
                (Vector256<short> a, Vector256<short> b) = athis.Widen((Vector256<sbyte>)(object)source);
                lower = (Vector256<TOut>)(object)a;
                upper = (Vector256<TOut>)(object)b;
            } else if (typeof(byte) == typeof(T) && typeof(ushort) == typeof(TOut)) {
                (Vector256<ushort> a, Vector256<ushort> b) = athis.Widen((Vector256<byte>)(object)source);
                lower = (Vector256<TOut>)(object)a;
                upper = (Vector256<TOut>)(object)b;
            } else if (typeof(short) == typeof(T) && typeof(int) == typeof(TOut)) {
                (Vector256<int> a, Vector256<int> b) = athis.Widen((Vector256<short>)(object)source);
                lower = (Vector256<TOut>)(object)a;
                upper = (Vector256<TOut>)(object)b;
            } else if (typeof(ushort) == typeof(T) && typeof(uint) == typeof(TOut)) {
                (Vector256<uint> a, Vector256<uint> b) = athis.Widen((Vector256<ushort>)(object)source);
                lower = (Vector256<TOut>)(object)a;
                upper = (Vector256<TOut>)(object)b;
            } else if (typeof(int) == typeof(T) && typeof(long) == typeof(TOut)) {
                (Vector256<long> a, Vector256<long> b) = athis.Widen((Vector256<int>)(object)source);
                lower = (Vector256<TOut>)(object)a;
                upper = (Vector256<TOut>)(object)b;
            } else if (typeof(uint) == typeof(T) && typeof(ulong) == typeof(TOut)) {
                (Vector256<ulong> a, Vector256<ulong> b) = athis.Widen((Vector256<uint>)(object)source);
                lower = (Vector256<TOut>)(object)a;
                upper = (Vector256<TOut>)(object)b;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TOut).Name));
            }
        }

        /// <inheritdoc cref="Vector256s.Widen(Vector256{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<double> Lower, Vector256<double> Upper) Widen(this IWVectorTraits256 athis, Vector256<float> source) {
            athis.Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector256s.Widen(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> Lower, Vector256<short> Upper) Widen(this IWVectorTraits256 athis, Vector256<sbyte> source) {
            athis.Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector256s.Widen(Vector256{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ushort> Lower, Vector256<ushort> Upper) Widen(this IWVectorTraits256 athis, Vector256<byte> source) {
            athis.Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector256s.Widen(Vector256{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> Lower, Vector256<int> Upper) Widen(this IWVectorTraits256 athis, Vector256<short> source) {
            athis.Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector256s.Widen(Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<uint> Lower, Vector256<uint> Upper) Widen(this IWVectorTraits256 athis, Vector256<ushort> source) {
            athis.Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector256s.Widen(Vector256{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> Lower, Vector256<long> Upper) Widen(this IWVectorTraits256 athis, Vector256<int> source) {
            athis.Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector256s.Widen(Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ulong> Lower, Vector256<ulong> Upper) Widen(this IWVectorTraits256 athis, Vector256<uint> source) {
            athis.Widen(source, out var a, out var b);
            return (a, b);
        }


        /// <inheritdoc cref="Vector256s.Shuffle_Args{TIdx}(Vector256{TIdx}, out Vector256{TIdx}, out Vector256{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void Shuffle_Args<TIdx>(this IWVectorTraits256 athis, Vector256<TIdx> indices, out Vector256<TIdx> args0, out Vector256<TIdx> args1)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b) = athis.Shuffle_Args((Vector256<sbyte>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b) = athis.Shuffle_Args((Vector256<byte>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b) = athis.Shuffle_Args((Vector256<short>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b) = athis.Shuffle_Args((Vector256<ushort>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b) = athis.Shuffle_Args((Vector256<int>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b) = athis.Shuffle_Args((Vector256<uint>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b) = athis.Shuffle_Args((Vector256<long>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b) = athis.Shuffle_Args((Vector256<ulong>)(object)indices);
                args0 = (Vector256<TIdx>)(object)a;
                args1 = (Vector256<TIdx>)(object)b;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector256s.Shuffle_Args{TIdx}(Vector256{TIdx}"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<TIdx> args0, Vector256<TIdx> args1) Shuffle_Args<TIdx>(this IWVectorTraits256 athis, Vector256<TIdx> indices)
                where TIdx : struct {
            athis.Shuffle_Args<TIdx>(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector256s.Shuffle_Args(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<sbyte> args0, Vector256<sbyte> args1) Shuffle_Args(this IWVectorTraits256 athis, Vector256<sbyte> indices) {
            athis.Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector256s.Shuffle_Args(Vector256{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<byte> args0, Vector256<byte> args1) Shuffle_Args(this IWVectorTraits256 athis, Vector256<byte> indices) {
            athis.Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector256s.Shuffle_Args(Vector256{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> args0, Vector256<short> args1) Shuffle_Args(this IWVectorTraits256 athis, Vector256<short> indices) {
            athis.Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector256s.Shuffle_Args(Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ushort> args0, Vector256<ushort> args1) Shuffle_Args(this IWVectorTraits256 athis, Vector256<ushort> indices) {
            athis.Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector256s.Shuffle_Args(Vector256{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> args0, Vector256<int> args1) Shuffle_Args(this IWVectorTraits256 athis, Vector256<int> indices) {
            athis.Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector256s.Shuffle_Args(Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<uint> args0, Vector256<uint> args1) Shuffle_Args(this IWVectorTraits256 athis, Vector256<uint> indices) {
            athis.Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector256s.Shuffle_Args(Vector256{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> args0, Vector256<long> args1) Shuffle_Args(this IWVectorTraits256 athis, Vector256<long> indices) {
            athis.Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector256s.Shuffle_Args(Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ulong> args0, Vector256<ulong> args1) Shuffle_Args(this IWVectorTraits256 athis, Vector256<ulong> indices) {
            athis.Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }


        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="athis">This object.</param>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="T"/>, <typeparamref name="TIdx"/>) are not supported.</exception>
        /// <seealso cref="IWVectorTraits256.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.Shuffle_Core(Vector256{float}, Vector256{int}, Vector256{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<T> Shuffle_Core<T, TIdx>(this IWVectorTraits256 athis, Vector256<T> vector, (Vector256<TIdx> args0, Vector256<TIdx> args1) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.Shuffle_Core((Vector256<float>)(object)vector, (ValueTuple<Vector256<int>, Vector256<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.Shuffle_Core((Vector256<double>)(object)vector, (ValueTuple<Vector256<long>, Vector256<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.Shuffle_Core((Vector256<sbyte>)(object)vector, (ValueTuple<Vector256<sbyte>, Vector256<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.Shuffle_Core((Vector256<byte>)(object)vector, (ValueTuple<Vector256<byte>, Vector256<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.Shuffle_Core((Vector256<short>)(object)vector, (ValueTuple<Vector256<short>, Vector256<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.Shuffle_Core((Vector256<ushort>)(object)vector, (ValueTuple<Vector256<ushort>, Vector256<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.Shuffle_Core((Vector256<int>)(object)vector, (ValueTuple<Vector256<int>, Vector256<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.Shuffle_Core((Vector256<uint>)(object)vector, (ValueTuple<Vector256<uint>, Vector256<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.Shuffle_Core((Vector256<long>)(object)vector, (ValueTuple<Vector256<long>, Vector256<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector256<T>)(object)athis.Shuffle_Core((Vector256<ulong>)(object)vector, (ValueTuple<Vector256<ulong>, Vector256<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector256s.Shuffle_Core(Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> Shuffle_Core(this IWVectorTraits256 athis, Vector256<float> vector, (Vector256<int> args0, Vector256<int> args1) args) {
            return athis.Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector256s.Shuffle_Core(Vector256{double}, ValueTuple{Vector256{long}, Vector256{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> Shuffle_Core(this IWVectorTraits256 athis, Vector256<double> vector, (Vector256<long> args0, Vector256<long> args1) args) {
            return athis.Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector256s.Shuffle_Core(Vector256{sbyte}, ValueTuple{Vector256{sbyte}, Vector256{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> Shuffle_Core(this IWVectorTraits256 athis, Vector256<sbyte> vector, (Vector256<sbyte> args0, Vector256<sbyte> args1) args) {
            return athis.Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector256s.Shuffle_Core(Vector256{byte}, ValueTuple{Vector256{byte}, Vector256{byte}})"/>
        [CLSCompliant(false)]
        public static Vector256<byte> Shuffle_Core(this IWVectorTraits256 athis, Vector256<byte> vector, (Vector256<byte> args0, Vector256<byte> args1) args) {
            return athis.Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector256s.Shuffle_Core(Vector256{short}, ValueTuple{Vector256{short}, Vector256{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> Shuffle_Core(this IWVectorTraits256 athis, Vector256<short> vector, (Vector256<short> args0, Vector256<short> args1) args) {
            return athis.Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector256s.Shuffle_Core(Vector256{ushort}, ValueTuple{Vector256{ushort}, Vector256{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> Shuffle_Core(this IWVectorTraits256 athis, Vector256<ushort> vector, (Vector256<ushort> args0, Vector256<ushort> args1) args) {
            return athis.Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector256s.Shuffle_Core(Vector256{int}, ValueTuple{Vector256{int}, Vector256{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> Shuffle_Core(this IWVectorTraits256 athis, Vector256<int> vector, (Vector256<int> args0, Vector256<int> args1) args) {
            return athis.Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector256s.Shuffle_Core(Vector256{uint}, ValueTuple{Vector256{uint}, Vector256{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> Shuffle_Core(this IWVectorTraits256 athis, Vector256<uint> vector, (Vector256<uint> args0, Vector256<uint> args1) args) {
            return athis.Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector256s.Shuffle_Core(Vector256{long}, ValueTuple{Vector256{long}, Vector256{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> Shuffle_Core(this IWVectorTraits256 athis, Vector256<long> vector, (Vector256<long> args0, Vector256<long> args1) args) {
            return athis.Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector256s.Shuffle_Core(Vector256{ulong}, ValueTuple{Vector256{ulong}, Vector256{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> Shuffle_Core(this IWVectorTraits256 athis, Vector256<ulong> vector, (Vector256<ulong> args0, Vector256<ulong> args1) args) {
            return athis.Shuffle_Core(vector, args.args0, args.args1);
        }


        /// <inheritdoc cref="Vector256s.YShuffleG4X2{T}(Vector256{T}, Vector256{T}, ShuffleControlG4)"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static (Vector256<T> Result0, Vector256<T> Result1) YShuffleG4X2<T>(this IWVectorTraits256 athis, Vector256<T> source0, Vector256<T> source1, ShuffleControlG4 control) where T : struct {
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
        public static (Vector256<float> Result0, Vector256<float> Result1) YShuffleG4X2(this IWVectorTraits256 athis, Vector256<float> source0, Vector256<float> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleG4X2(Vector256{double}, Vector256{double}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector256<double> Result0, Vector256<double> Result1) YShuffleG4X2(this IWVectorTraits256 athis, Vector256<double> source0, Vector256<double> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleG4X2(Vector256{sbyte}, Vector256{sbyte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector256<sbyte> Result0, Vector256<sbyte> Result1) YShuffleG4X2(this IWVectorTraits256 athis, Vector256<sbyte> source0, Vector256<sbyte> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleG4X2(Vector256{byte}, Vector256{byte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector256<byte> Result0, Vector256<byte> Result1) YShuffleG4X2(this IWVectorTraits256 athis, Vector256<byte> source0, Vector256<byte> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleG4X2(Vector256{short}, Vector256{short}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector256<short> Result0, Vector256<short> Result1) YShuffleG4X2(this IWVectorTraits256 athis, Vector256<short> source0, Vector256<short> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleG4X2(Vector256{ushort}, Vector256{ushort}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector256<ushort> Result0, Vector256<ushort> Result1) YShuffleG4X2(this IWVectorTraits256 athis, Vector256<ushort> source0, Vector256<ushort> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleG4X2(Vector256{int}, Vector256{int}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector256<int> Result0, Vector256<int> Result1) YShuffleG4X2(this IWVectorTraits256 athis, Vector256<int> source0, Vector256<int> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleG4X2(Vector256{uint}, Vector256{uint}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector256<uint> Result0, Vector256<uint> Result1) YShuffleG4X2(this IWVectorTraits256 athis, Vector256<uint> source0, Vector256<uint> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleG4X2(Vector256{long}, Vector256{long}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector256<long> Result0, Vector256<long> Result1) YShuffleG4X2(this IWVectorTraits256 athis, Vector256<long> source0, Vector256<long> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleG4X2(Vector256{ulong}, Vector256{ulong}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector256<ulong> Result0, Vector256<ulong> Result1) YShuffleG4X2(this IWVectorTraits256 athis, Vector256<ulong> source0, Vector256<ulong> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleG4X2_Const{T}(Vector256{T}, Vector256{T}, ShuffleControlG4)"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static (Vector256<T> Result0, Vector256<T> Result1) YShuffleG4X2_Const<T>(this IWVectorTraits256 athis, Vector256<T> source0, Vector256<T> source1, ShuffleControlG4 control) where T : struct {
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
        public static (Vector256<float> Result0, Vector256<float> Result1) YShuffleG4X2_Const(this IWVectorTraits256 athis, Vector256<float> source0, Vector256<float> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleG4X2_Const(Vector256{double}, Vector256{double}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector256<double> Result0, Vector256<double> Result1) YShuffleG4X2_Const(this IWVectorTraits256 athis, Vector256<double> source0, Vector256<double> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleG4X2_Const(Vector256{sbyte}, Vector256{sbyte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector256<sbyte> Result0, Vector256<sbyte> Result1) YShuffleG4X2_Const(this IWVectorTraits256 athis, Vector256<sbyte> source0, Vector256<sbyte> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleG4X2_Const(Vector256{byte}, Vector256{byte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector256<byte> Result0, Vector256<byte> Result1) YShuffleG4X2_Const(this IWVectorTraits256 athis, Vector256<byte> source0, Vector256<byte> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleG4X2_Const(Vector256{short}, Vector256{short}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector256<short> Result0, Vector256<short> Result1) YShuffleG4X2_Const(this IWVectorTraits256 athis, Vector256<short> source0, Vector256<short> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleG4X2_Const(Vector256{ushort}, Vector256{ushort}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector256<ushort> Result0, Vector256<ushort> Result1) YShuffleG4X2_Const(this IWVectorTraits256 athis, Vector256<ushort> source0, Vector256<ushort> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleG4X2_Const(Vector256{int}, Vector256{int}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector256<int> Result0, Vector256<int> Result1) YShuffleG4X2_Const(this IWVectorTraits256 athis, Vector256<int> source0, Vector256<int> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleG4X2_Const(Vector256{uint}, Vector256{uint}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector256<uint> Result0, Vector256<uint> Result1) YShuffleG4X2_Const(this IWVectorTraits256 athis, Vector256<uint> source0, Vector256<uint> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleG4X2_Const(Vector256{long}, Vector256{long}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector256<long> Result0, Vector256<long> Result1) YShuffleG4X2_Const(this IWVectorTraits256 athis, Vector256<long> source0, Vector256<long> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector256s.YShuffleG4X2_Const(Vector256{ulong}, Vector256{ulong}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
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

        /// <inheritdoc cref="Vector256s.YShuffleKernel_Args{TIdx}(Vector256{TIdx}"/>
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


#endif // NETCOREAPP3_0_OR_GREATER
    }
}
