using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using Zyl.VectorTraits.Extensions.SameW;
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
                (Vector<double> a, Vector<double> b) = athis.Widen(source.As<T, float>());
                lower = a.As<double, TOut>();
                upper = b.As<double, TOut>();
            } else if (typeof(sbyte) == typeof(T) && typeof(short) == typeof(TOut)) {
                (Vector<short> a, Vector<short> b) = athis.Widen(source.As<T, sbyte>());
                lower = a.As<short, TOut>();
                upper = b.As<short, TOut>();
            } else if (typeof(byte) == typeof(T) && typeof(ushort) == typeof(TOut)) {
                (Vector<ushort> a, Vector<ushort> b) = athis.Widen(source.As<T, byte>());
                lower = a.As<ushort, TOut>();
                upper = b.As<ushort, TOut>();
            } else if (typeof(short) == typeof(T) && typeof(int) == typeof(TOut)) {
                (Vector<int> a, Vector<int> b) = athis.Widen(source.As<T, short>());
                lower = a.As<int, TOut>();
                upper = b.As<int, TOut>();
            } else if (typeof(ushort) == typeof(T) && typeof(uint) == typeof(TOut)) {
                (Vector<uint> a, Vector<uint> b) = athis.Widen(source.As<T, ushort>());
                lower = a.As<uint, TOut>();
                upper = b.As<uint, TOut>();
            } else if (typeof(int) == typeof(T) && typeof(long) == typeof(TOut)) {
                (Vector<long> a, Vector<long> b) = athis.Widen(source.As<T, int>());
                lower = a.As<long, TOut>();
                upper = b.As<long, TOut>();
            } else if (typeof(uint) == typeof(T) && typeof(ulong) == typeof(TOut)) {
                (Vector<ulong> a, Vector<ulong> b) = athis.Widen(source.As<T, uint>());
                lower = a.As<ulong, TOut>();
                upper = b.As<ulong, TOut>();
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
                (var args0, var args1) = athis.ShiftLeft_Args(dummy.As<T, sbyte>(), shiftAmount);
                return (args0.As<sbyte, T>(), args1.As<sbyte, T>());
            } else if (typeof(byte) == typeof(T)) {
                (var args0, var args1) = athis.ShiftLeft_Args(dummy.As<T, byte>(), shiftAmount);
                return (args0.As<byte, T>(), args1.As<byte, T>());
            } else if (typeof(short) == typeof(T)) {
                (var args0, var args1) = athis.ShiftLeft_Args(dummy.As<T, short>(), shiftAmount);
                return (args0.As<short, T>(), args1.As<short, T>());
            } else if (typeof(ushort) == typeof(T)) {
                (var args0, var args1) = athis.ShiftLeft_Args(dummy.As<T, ushort>(), shiftAmount);
                return (args0.As<ushort, T>(), args1.As<ushort, T>());
            } else if (typeof(int) == typeof(T)) {
                (var args0, var args1) = athis.ShiftLeft_Args(dummy.As<T, int>(), shiftAmount);
                return (args0.As<int, T>(), args1.As<int, T>());
            } else if (typeof(uint) == typeof(T)) {
                (var args0, var args1) = athis.ShiftLeft_Args(dummy.As<T, uint>(), shiftAmount);
                return (args0.As<uint, T>(), args1.As<uint, T>());
            } else if (typeof(long) == typeof(T)) {
                (var args0, var args1) = athis.ShiftLeft_Args(dummy.As<T, long>(), shiftAmount);
                return (args0.As<long, T>(), args1.As<long, T>());
            } else if (typeof(ulong) == typeof(T)) {
                (var args0, var args1) = athis.ShiftLeft_Args(dummy.As<T, ulong>(), shiftAmount);
                return (args0.As<ulong, T>(), args1.As<ulong, T>());
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
                (var args0, var args1) = athis.ShiftRightArithmetic_Args(dummy.As<T, sbyte>(), shiftAmount);
                return (args0.As<sbyte, T>(), args1.As<sbyte, T>());
            } else if (typeof(short) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightArithmetic_Args(dummy.As<T, short>(), shiftAmount);
                return (args0.As<short, T>(), args1.As<short, T>());
            } else if (typeof(int) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightArithmetic_Args(dummy.As<T, int>(), shiftAmount);
                return (args0.As<int, T>(), args1.As<int, T>());
            } else if (typeof(long) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightArithmetic_Args(dummy.As<T, long>(), shiftAmount);
                return (args0.As<long, T>(), args1.As<long, T>());
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
                (var args0, var args1) = athis.ShiftRightLogical_Args(dummy.As<T, sbyte>(), shiftAmount);
                return (args0.As<sbyte, T>(), args1.As<sbyte, T>());
            } else if (typeof(byte) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightLogical_Args(dummy.As<T, byte>(), shiftAmount);
                return (args0.As<byte, T>(), args1.As<byte, T>());
            } else if (typeof(short) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightLogical_Args(dummy.As<T, short>(), shiftAmount);
                return (args0.As<short, T>(), args1.As<short, T>());
            } else if (typeof(ushort) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightLogical_Args(dummy.As<T, ushort>(), shiftAmount);
                return (args0.As<ushort, T>(), args1.As<ushort, T>());
            } else if (typeof(int) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightLogical_Args(dummy.As<T, int>(), shiftAmount);
                return (args0.As<int, T>(), args1.As<int, T>());
            } else if (typeof(uint) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightLogical_Args(dummy.As<T, uint>(), shiftAmount);
                return (args0.As<uint, T>(), args1.As<uint, T>());
            } else if (typeof(long) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightLogical_Args(dummy.As<T, long>(), shiftAmount);
                return (args0.As<long, T>(), args1.As<long, T>());
            } else if (typeof(ulong) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightLogical_Args(dummy.As<T, ulong>(), shiftAmount);
                return (args0.As<ulong, T>(), args1.As<ulong, T>());
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
                (var a, var b) = athis.Shuffle_Args(indices.As<TIdx, sbyte>());
                args0 = a.As<sbyte, TIdx>();
                args1 = b.As<sbyte, TIdx>();
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b) = athis.Shuffle_Args(indices.As<TIdx, byte>());
                args0 = a.As<byte, TIdx>();
                args1 = b.As<byte, TIdx>();
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b) = athis.Shuffle_Args(indices.As<TIdx, short>());
                args0 = a.As<short, TIdx>();
                args1 = b.As<short, TIdx>();
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b) = athis.Shuffle_Args(indices.As<TIdx, ushort>());
                args0 = a.As<ushort, TIdx>();
                args1 = b.As<ushort, TIdx>();
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b) = athis.Shuffle_Args(indices.As<TIdx, int>());
                args0 = a.As<int, TIdx>();
                args1 = b.As<int, TIdx>();
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b) = athis.Shuffle_Args(indices.As<TIdx, uint>());
                args0 = a.As<uint, TIdx>();
                args1 = b.As<uint, TIdx>();
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b) = athis.Shuffle_Args(indices.As<TIdx, long>());
                args0 = a.As<long, TIdx>();
                args1 = b.As<long, TIdx>();
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b) = athis.Shuffle_Args(indices.As<TIdx, ulong>());
                args0 = a.As<ulong, TIdx>();
                args1 = b.As<ulong, TIdx>();
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vectors.Shuffle_Args{TIdx}(Vector{TIdx})"/>
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
                return athis.Shuffle_Core(vector.As<T, float>(), Unsafe.As<ValueTuple<Vector<TIdx>, Vector<TIdx>>, ValueTuple<Vector<int>, Vector<int>>>(ref args)).As<float, T>();
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return athis.Shuffle_Core(vector.As<T, double>(), Unsafe.As<ValueTuple<Vector<TIdx>, Vector<TIdx>>, ValueTuple<Vector<long>, Vector<long>>>(ref args)).As<double, T>();
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return athis.Shuffle_Core(vector.As<T, sbyte>(), Unsafe.As<ValueTuple<Vector<TIdx>, Vector<TIdx>>, ValueTuple<Vector<sbyte>, Vector<sbyte>>>(ref args)).As<sbyte, T>();
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return athis.Shuffle_Core(vector.As<T, byte>(), Unsafe.As<ValueTuple<Vector<TIdx>, Vector<TIdx>>, ValueTuple<Vector<byte>, Vector<byte>>>(ref args)).As<byte, T>();
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return athis.Shuffle_Core(vector.As<T, short>(), Unsafe.As<ValueTuple<Vector<TIdx>, Vector<TIdx>>, ValueTuple<Vector<short>, Vector<short>>>(ref args)).As<short, T>();
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return athis.Shuffle_Core(vector.As<T, ushort>(), Unsafe.As<ValueTuple<Vector<TIdx>, Vector<TIdx>>, ValueTuple<Vector<ushort>, Vector<ushort>>>(ref args)).As<ushort, T>();
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return athis.Shuffle_Core(vector.As<T, int>(), Unsafe.As<ValueTuple<Vector<TIdx>, Vector<TIdx>>, ValueTuple<Vector<int>, Vector<int>>>(ref args)).As<int, T>();
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return athis.Shuffle_Core(vector.As<T, uint>(), Unsafe.As<ValueTuple<Vector<TIdx>, Vector<TIdx>>, ValueTuple<Vector<uint>, Vector<uint>>>(ref args)).As<uint, T>();
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return athis.Shuffle_Core(vector.As<T, long>(), Unsafe.As<ValueTuple<Vector<TIdx>, Vector<TIdx>>, ValueTuple<Vector<long>, Vector<long>>>(ref args)).As<long, T>();
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return athis.Shuffle_Core(vector.As<T, ulong>(), Unsafe.As<ValueTuple<Vector<TIdx>, Vector<TIdx>>, ValueTuple<Vector<ulong>, Vector<ulong>>>(ref args)).As<ulong, T>();
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
