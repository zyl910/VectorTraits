using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using static Zyl.VectorTraits.Impl.VectorMessageFormats;

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// Extension methods of <seealso cref="IVectorTraits"/> (<seealso cref="IVectorTraits"/> 的扩展方法)
    /// </summary>
    public static partial class IVectorTraits_Extensions {

        /// <inheritdoc cref="Vectors.Widen{T, TOut}(Vector{T}, out Vector{TOut}, out Vector{TOut})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void Widen<T, TOut>(this IVectorTraits athis, Vector<T> source, out Vector<TOut> lower, out Vector<TOut> upper)
                 where T : struct where TOut : struct {
            if (typeof(float) == typeof(T) && typeof(double) == typeof(TOut)) {
                (Vector<double> a, Vector<double> b) = athis.Widen((Vector<float>)(object)source);
                lower = (Vector<TOut>)(object)a;
                upper = (Vector<TOut>)(object)b;
            } else if (typeof(sbyte) == typeof(T) && typeof(short) == typeof(TOut)) {
                (Vector<short> a, Vector<short> b) = athis.Widen((Vector<sbyte>)(object)source);
                lower = (Vector<TOut>)(object)a;
                upper = (Vector<TOut>)(object)b;
            } else if (typeof(byte) == typeof(T) && typeof(ushort) == typeof(TOut)) {
                (Vector<ushort> a, Vector<ushort> b) = athis.Widen((Vector<byte>)(object)source);
                lower = (Vector<TOut>)(object)a;
                upper = (Vector<TOut>)(object)b;
            } else if (typeof(short) == typeof(T) && typeof(int) == typeof(TOut)) {
                (Vector<int> a, Vector<int> b) = athis.Widen((Vector<short>)(object)source);
                lower = (Vector<TOut>)(object)a;
                upper = (Vector<TOut>)(object)b;
            } else if (typeof(ushort) == typeof(T) && typeof(uint) == typeof(TOut)) {
                (Vector<uint> a, Vector<uint> b) = athis.Widen((Vector<ushort>)(object)source);
                lower = (Vector<TOut>)(object)a;
                upper = (Vector<TOut>)(object)b;
            } else if (typeof(int) == typeof(T) && typeof(long) == typeof(TOut)) {
                (Vector<long> a, Vector<long> b) = athis.Widen((Vector<int>)(object)source);
                lower = (Vector<TOut>)(object)a;
                upper = (Vector<TOut>)(object)b;
            } else if (typeof(uint) == typeof(T) && typeof(ulong) == typeof(TOut)) {
                (Vector<ulong> a, Vector<ulong> b) = athis.Widen((Vector<uint>)(object)source);
                lower = (Vector<TOut>)(object)a;
                upper = (Vector<TOut>)(object)b;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TOut).Name));
            }
        }

        /// <inheritdoc cref="Vectors.Widen(Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<double> Lower, Vector<double> Upper) Widen(this IVectorTraits athis, Vector<float> source) {
            athis.Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vectors.Widen(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> Lower, Vector<short> Upper) Widen(this IVectorTraits athis, Vector<sbyte> source) {
            athis.Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vectors.Widen(Vector{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> Lower, Vector<ushort> Upper) Widen(this IVectorTraits athis, Vector<byte> source) {
            athis.Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vectors.Widen(Vector{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> Lower, Vector<int> Upper) Widen(this IVectorTraits athis, Vector<short> source) {
            athis.Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vectors.Widen(Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> Lower, Vector<uint> Upper) Widen(this IVectorTraits athis, Vector<ushort> source) {
            athis.Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vectors.Widen(Vector{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> Lower, Vector<long> Upper) Widen(this IVectorTraits athis, Vector<int> source) {
            athis.Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vectors.Widen(Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> Lower, Vector<ulong> Upper) Widen(this IVectorTraits athis, Vector<uint> source) {
            athis.Widen(source, out var a, out var b);
            return (a, b);
        }


        /// <inheritdoc cref="Vectors.ShiftLeft_Args{T}(Vector{T}, int)"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static (Vector<T> args0, Vector<T> args1) ShiftLeft_Args<T>(this IVectorTraits athis, Vector<T> dummy, int shiftAmount) where T : struct {
            if (typeof(sbyte) == typeof(T)) {
                (var args0, var args1) = athis.ShiftLeft_Args((Vector<sbyte>)(object)dummy, shiftAmount);
                return ((Vector<T>)(object)args0, (Vector<T>)(object)args1);
            } else if (typeof(byte) == typeof(T)) {
                (var args0, var args1) = athis.ShiftLeft_Args((Vector<byte>)(object)dummy, shiftAmount);
                return ((Vector<T>)(object)args0, (Vector<T>)(object)args1);
            } else if (typeof(short) == typeof(T)) {
                (var args0, var args1) = athis.ShiftLeft_Args((Vector<short>)(object)dummy, shiftAmount);
                return ((Vector<T>)(object)args0, (Vector<T>)(object)args1);
            } else if (typeof(ushort) == typeof(T)) {
                (var args0, var args1) = athis.ShiftLeft_Args((Vector<ushort>)(object)dummy, shiftAmount);
                return ((Vector<T>)(object)args0, (Vector<T>)(object)args1);
            } else if (typeof(int) == typeof(T)) {
                (var args0, var args1) = athis.ShiftLeft_Args((Vector<int>)(object)dummy, shiftAmount);
                return ((Vector<T>)(object)args0, (Vector<T>)(object)args1);
            } else if (typeof(uint) == typeof(T)) {
                (var args0, var args1) = athis.ShiftLeft_Args((Vector<uint>)(object)dummy, shiftAmount);
                return ((Vector<T>)(object)args0, (Vector<T>)(object)args1);
            } else if (typeof(long) == typeof(T)) {
                (var args0, var args1) = athis.ShiftLeft_Args((Vector<long>)(object)dummy, shiftAmount);
                return ((Vector<T>)(object)args0, (Vector<T>)(object)args1);
            } else if (typeof(ulong) == typeof(T)) {
                (var args0, var args1) = athis.ShiftLeft_Args((Vector<ulong>)(object)dummy, shiftAmount);
                return ((Vector<T>)(object)args0, (Vector<T>)(object)args1);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vectors.ShiftLeft_Args(Vector{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> args0, Vector<sbyte> args1) ShiftLeft_Args(this IVectorTraits athis, Vector<sbyte> dummy, int shiftAmount) {
            var args0 = athis.ShiftLeft_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vectors.ShiftLeft_Args(Vector{byte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> args0, Vector<byte> args1) ShiftLeft_Args(this IVectorTraits athis, Vector<byte> dummy, int shiftAmount) {
            var args0 = athis.ShiftLeft_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vectors.ShiftLeft_Args(Vector{short}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> args0, Vector<short> args1) ShiftLeft_Args(this IVectorTraits athis, Vector<short> dummy, int shiftAmount) {
            var args0 = athis.ShiftLeft_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vectors.ShiftLeft_Args(Vector{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> args0, Vector<ushort> args1) ShiftLeft_Args(this IVectorTraits athis, Vector<ushort> dummy, int shiftAmount) {
            var args0 = athis.ShiftLeft_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vectors.ShiftLeft_Args(Vector{int}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> args0, Vector<int> args1) ShiftLeft_Args(this IVectorTraits athis, Vector<int> dummy, int shiftAmount) {
            var args0 = athis.ShiftLeft_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vectors.ShiftLeft_Args(Vector{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> args0, Vector<uint> args1) ShiftLeft_Args(this IVectorTraits athis, Vector<uint> dummy, int shiftAmount) {
            var args0 = athis.ShiftLeft_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vectors.ShiftLeft_Args(Vector{long}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> args0, Vector<long> args1) ShiftLeft_Args(this IVectorTraits athis, Vector<long> dummy, int shiftAmount) {
            var args0 = athis.ShiftLeft_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vectors.ShiftLeft_Args(Vector{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> args0, Vector<ulong> args1) ShiftLeft_Args(this IVectorTraits athis, Vector<ulong> dummy, int shiftAmount) {
            var args0 = athis.ShiftLeft_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }


        /// <inheritdoc cref="Vectors.ShiftRightArithmetic_Args{T}(Vector{T}, int)"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static (Vector<T> args0, Vector<T> args1) ShiftRightArithmetic_Args<T>(this IVectorTraits athis, Vector<T> dummy, int shiftAmount) where T : struct {
            if (typeof(sbyte) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightArithmetic_Args((Vector<sbyte>)(object)dummy, shiftAmount);
                return ((Vector<T>)(object)args0, (Vector<T>)(object)args1);
            } else if (typeof(short) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightArithmetic_Args((Vector<short>)(object)dummy, shiftAmount);
                return ((Vector<T>)(object)args0, (Vector<T>)(object)args1);
            } else if (typeof(int) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightArithmetic_Args((Vector<int>)(object)dummy, shiftAmount);
                return ((Vector<T>)(object)args0, (Vector<T>)(object)args1);
            } else if (typeof(long) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightArithmetic_Args((Vector<long>)(object)dummy, shiftAmount);
                return ((Vector<T>)(object)args0, (Vector<T>)(object)args1);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vectors.ShiftRightArithmetic_Args(Vector{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> args0, Vector<sbyte> args1) ShiftRightArithmetic_Args(this IVectorTraits athis, Vector<sbyte> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightArithmetic_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vectors.ShiftRightArithmetic_Args(Vector{short}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> args0, Vector<short> args1) ShiftRightArithmetic_Args(this IVectorTraits athis, Vector<short> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightArithmetic_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vectors.ShiftRightArithmetic_Args(Vector{int}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> args0, Vector<int> args1) ShiftRightArithmetic_Args(this IVectorTraits athis, Vector<int> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightArithmetic_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vectors.ShiftRightArithmetic_Args(Vector{long}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> args0, Vector<long> args1) ShiftRightArithmetic_Args(this IVectorTraits athis, Vector<long> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightArithmetic_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }


        /// <inheritdoc cref="Vectors.ShiftRightLogical_Args{T}(Vector{T}, int)"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static (Vector<T> args0, Vector<T> args1) ShiftRightLogical_Args<T>(this IVectorTraits athis, Vector<T> dummy, int shiftAmount) where T : struct {
            if (typeof(sbyte) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightLogical_Args((Vector<sbyte>)(object)dummy, shiftAmount);
                return ((Vector<T>)(object)args0, (Vector<T>)(object)args1);
            } else if (typeof(byte) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightLogical_Args((Vector<byte>)(object)dummy, shiftAmount);
                return ((Vector<T>)(object)args0, (Vector<T>)(object)args1);
            } else if (typeof(short) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightLogical_Args((Vector<short>)(object)dummy, shiftAmount);
                return ((Vector<T>)(object)args0, (Vector<T>)(object)args1);
            } else if (typeof(ushort) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightLogical_Args((Vector<ushort>)(object)dummy, shiftAmount);
                return ((Vector<T>)(object)args0, (Vector<T>)(object)args1);
            } else if (typeof(int) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightLogical_Args((Vector<int>)(object)dummy, shiftAmount);
                return ((Vector<T>)(object)args0, (Vector<T>)(object)args1);
            } else if (typeof(uint) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightLogical_Args((Vector<uint>)(object)dummy, shiftAmount);
                return ((Vector<T>)(object)args0, (Vector<T>)(object)args1);
            } else if (typeof(long) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightLogical_Args((Vector<long>)(object)dummy, shiftAmount);
                return ((Vector<T>)(object)args0, (Vector<T>)(object)args1);
            } else if (typeof(ulong) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightLogical_Args((Vector<ulong>)(object)dummy, shiftAmount);
                return ((Vector<T>)(object)args0, (Vector<T>)(object)args1);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vectors.ShiftRightLogical_Args(Vector{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> args0, Vector<sbyte> args1) ShiftRightLogical_Args(this IVectorTraits athis, Vector<sbyte> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightLogical_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vectors.ShiftRightLogical_Args(Vector{byte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> args0, Vector<byte> args1) ShiftRightLogical_Args(this IVectorTraits athis, Vector<byte> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightLogical_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vectors.ShiftRightLogical_Args(Vector{short}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> args0, Vector<short> args1) ShiftRightLogical_Args(this IVectorTraits athis, Vector<short> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightLogical_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vectors.ShiftRightLogical_Args(Vector{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> args0, Vector<ushort> args1) ShiftRightLogical_Args(this IVectorTraits athis, Vector<ushort> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightLogical_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vectors.ShiftRightLogical_Args(Vector{int}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> args0, Vector<int> args1) ShiftRightLogical_Args(this IVectorTraits athis, Vector<int> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightLogical_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vectors.ShiftRightLogical_Args(Vector{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> args0, Vector<uint> args1) ShiftRightLogical_Args(this IVectorTraits athis, Vector<uint> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightLogical_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vectors.ShiftRightLogical_Args(Vector{long}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> args0, Vector<long> args1) ShiftRightLogical_Args(this IVectorTraits athis, Vector<long> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightLogical_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vectors.ShiftRightLogical_Args(Vector{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> args0, Vector<ulong> args1) ShiftRightLogical_Args(this IVectorTraits athis, Vector<ulong> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightLogical_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }


        /// <inheritdoc cref="Vectors.Shuffle_Args{TIdx}(Vector{TIdx}, out Vector{TIdx}, out Vector{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void Shuffle_Args<TIdx>(this IVectorTraits athis, Vector<TIdx> indices, out Vector<TIdx> args0, out Vector<TIdx> args1)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b) = athis.Shuffle_Args((Vector<sbyte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b) = athis.Shuffle_Args((Vector<byte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b) = athis.Shuffle_Args((Vector<short>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b) = athis.Shuffle_Args((Vector<ushort>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b) = athis.Shuffle_Args((Vector<int>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b) = athis.Shuffle_Args((Vector<uint>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b) = athis.Shuffle_Args((Vector<long>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b) = athis.Shuffle_Args((Vector<ulong>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vectors.Shuffle_Args{TIdx}(Vector{TIdx}"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<TIdx> args0, Vector<TIdx> args1) Shuffle_Args<TIdx>(this IVectorTraits athis, Vector<TIdx> indices)
                where TIdx : struct {
            athis.Shuffle_Args<TIdx>(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vectors.Shuffle_Args(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> args0, Vector<sbyte> args1) Shuffle_Args(this IVectorTraits athis, Vector<sbyte> indices) {
            athis.Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vectors.Shuffle_Args(Vector{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> args0, Vector<byte> args1) Shuffle_Args(this IVectorTraits athis, Vector<byte> indices) {
            athis.Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vectors.Shuffle_Args(Vector{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> args0, Vector<short> args1) Shuffle_Args(this IVectorTraits athis, Vector<short> indices) {
            athis.Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vectors.Shuffle_Args(Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> args0, Vector<ushort> args1) Shuffle_Args(this IVectorTraits athis, Vector<ushort> indices) {
            athis.Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vectors.Shuffle_Args(Vector{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> args0, Vector<int> args1) Shuffle_Args(this IVectorTraits athis, Vector<int> indices) {
            athis.Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vectors.Shuffle_Args(Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> args0, Vector<uint> args1) Shuffle_Args(this IVectorTraits athis, Vector<uint> indices) {
            athis.Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vectors.Shuffle_Args(Vector{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> args0, Vector<long> args1) Shuffle_Args(this IVectorTraits athis, Vector<long> indices) {
            athis.Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vectors.Shuffle_Args(Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> args0, Vector<ulong> args1) Shuffle_Args(this IVectorTraits athis, Vector<ulong> indices) {
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
        /// <seealso cref="IVectorTraits.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.Shuffle_Core(Vector{float}, Vector{int}, Vector{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<T> Shuffle_Core<T, TIdx>(this IVectorTraits athis, Vector<T> vector, (Vector<TIdx> args0, Vector<TIdx> args1) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.Shuffle_Core((Vector<float>)(object)vector, (ValueTuple<Vector<int>, Vector<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.Shuffle_Core((Vector<double>)(object)vector, (ValueTuple<Vector<long>, Vector<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.Shuffle_Core((Vector<sbyte>)(object)vector, (ValueTuple<Vector<sbyte>, Vector<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.Shuffle_Core((Vector<byte>)(object)vector, (ValueTuple<Vector<byte>, Vector<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.Shuffle_Core((Vector<short>)(object)vector, (ValueTuple<Vector<short>, Vector<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.Shuffle_Core((Vector<ushort>)(object)vector, (ValueTuple<Vector<ushort>, Vector<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.Shuffle_Core((Vector<int>)(object)vector, (ValueTuple<Vector<int>, Vector<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.Shuffle_Core((Vector<uint>)(object)vector, (ValueTuple<Vector<uint>, Vector<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.Shuffle_Core((Vector<long>)(object)vector, (ValueTuple<Vector<long>, Vector<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector<T>)(object)athis.Shuffle_Core((Vector<ulong>)(object)vector, (ValueTuple<Vector<ulong>, Vector<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vectors.Shuffle_Core(Vector{float}, ValueTuple{Vector{int}, Vector{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<float> Shuffle_Core(this IVectorTraits athis, Vector<float> vector, (Vector<int> args0, Vector<int> args1) args) {
            return athis.Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vectors.Shuffle_Core(Vector{double}, ValueTuple{Vector{long}, Vector{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<double> Shuffle_Core(this IVectorTraits athis, Vector<double> vector, (Vector<long> args0, Vector<long> args1) args) {
            return athis.Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vectors.Shuffle_Core(Vector{sbyte}, ValueTuple{Vector{sbyte}, Vector{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> Shuffle_Core(this IVectorTraits athis, Vector<sbyte> vector, (Vector<sbyte> args0, Vector<sbyte> args1) args) {
            return athis.Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vectors.Shuffle_Core(Vector{byte}, ValueTuple{Vector{byte}, Vector{byte}})"/>
        [CLSCompliant(false)]
        public static Vector<byte> Shuffle_Core(this IVectorTraits athis, Vector<byte> vector, (Vector<byte> args0, Vector<byte> args1) args) {
            return athis.Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vectors.Shuffle_Core(Vector{short}, ValueTuple{Vector{short}, Vector{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> Shuffle_Core(this IVectorTraits athis, Vector<short> vector, (Vector<short> args0, Vector<short> args1) args) {
            return athis.Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vectors.Shuffle_Core(Vector{ushort}, ValueTuple{Vector{ushort}, Vector{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> Shuffle_Core(this IVectorTraits athis, Vector<ushort> vector, (Vector<ushort> args0, Vector<ushort> args1) args) {
            return athis.Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vectors.Shuffle_Core(Vector{int}, ValueTuple{Vector{int}, Vector{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> Shuffle_Core(this IVectorTraits athis, Vector<int> vector, (Vector<int> args0, Vector<int> args1) args) {
            return athis.Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vectors.Shuffle_Core(Vector{uint}, ValueTuple{Vector{uint}, Vector{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> Shuffle_Core(this IVectorTraits athis, Vector<uint> vector, (Vector<uint> args0, Vector<uint> args1) args) {
            return athis.Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vectors.Shuffle_Core(Vector{long}, ValueTuple{Vector{long}, Vector{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> Shuffle_Core(this IVectorTraits athis, Vector<long> vector, (Vector<long> args0, Vector<long> args1) args) {
            return athis.Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vectors.Shuffle_Core(Vector{ulong}, ValueTuple{Vector{ulong}, Vector{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> Shuffle_Core(this IVectorTraits athis, Vector<ulong> vector, (Vector<ulong> args0, Vector<ulong> args1) args) {
            return athis.Shuffle_Core(vector, args.args0, args.args1);
        }


    }
}
