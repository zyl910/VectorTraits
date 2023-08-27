using System;
using System.Collections.Generic;
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
    public static partial class IWVectorTraits128_Extensions {
#if NETCOREAPP3_0_OR_GREATER

        /// <inheritdoc cref="Vector128s.Widen{T, TOut}(Vector128{T}, out Vector128{TOut}, out Vector128{TOut})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void Widen<T, TOut>(this IWVectorTraits128 athis, Vector128<T> source, out Vector128<TOut> lower, out Vector128<TOut> upper)
                 where T : struct where TOut : struct {
            if (typeof(float) == typeof(T) && typeof(double) == typeof(TOut)) {
                (Vector128<double> a, Vector128<double> b) = athis.Widen((Vector128<float>)(object)source);
                lower = (Vector128<TOut>)(object)a;
                upper = (Vector128<TOut>)(object)b;
            } else if (typeof(sbyte) == typeof(T) && typeof(short) == typeof(TOut)) {
                (Vector128<short> a, Vector128<short> b) = athis.Widen((Vector128<sbyte>)(object)source);
                lower = (Vector128<TOut>)(object)a;
                upper = (Vector128<TOut>)(object)b;
            } else if (typeof(byte) == typeof(T) && typeof(ushort) == typeof(TOut)) {
                (Vector128<ushort> a, Vector128<ushort> b) = athis.Widen((Vector128<byte>)(object)source);
                lower = (Vector128<TOut>)(object)a;
                upper = (Vector128<TOut>)(object)b;
            } else if (typeof(short) == typeof(T) && typeof(int) == typeof(TOut)) {
                (Vector128<int> a, Vector128<int> b) = athis.Widen((Vector128<short>)(object)source);
                lower = (Vector128<TOut>)(object)a;
                upper = (Vector128<TOut>)(object)b;
            } else if (typeof(ushort) == typeof(T) && typeof(uint) == typeof(TOut)) {
                (Vector128<uint> a, Vector128<uint> b) = athis.Widen((Vector128<ushort>)(object)source);
                lower = (Vector128<TOut>)(object)a;
                upper = (Vector128<TOut>)(object)b;
            } else if (typeof(int) == typeof(T) && typeof(long) == typeof(TOut)) {
                (Vector128<long> a, Vector128<long> b) = athis.Widen((Vector128<int>)(object)source);
                lower = (Vector128<TOut>)(object)a;
                upper = (Vector128<TOut>)(object)b;
            } else if (typeof(uint) == typeof(T) && typeof(ulong) == typeof(TOut)) {
                (Vector128<ulong> a, Vector128<ulong> b) = athis.Widen((Vector128<uint>)(object)source);
                lower = (Vector128<TOut>)(object)a;
                upper = (Vector128<TOut>)(object)b;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TOut).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.Widen(Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<double> Lower, Vector128<double> Upper) Widen(this IWVectorTraits128 athis, Vector128<float> source) {
            athis.Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector128s.Widen(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> Lower, Vector128<short> Upper) Widen(this IWVectorTraits128 athis, Vector128<sbyte> source) {
            athis.Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector128s.Widen(Vector128{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> Lower, Vector128<ushort> Upper) Widen(this IWVectorTraits128 athis, Vector128<byte> source) {
            athis.Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector128s.Widen(Vector128{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> Lower, Vector128<int> Upper) Widen(this IWVectorTraits128 athis, Vector128<short> source) {
            athis.Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector128s.Widen(Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> Lower, Vector128<uint> Upper) Widen(this IWVectorTraits128 athis, Vector128<ushort> source) {
            athis.Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector128s.Widen(Vector128{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> Lower, Vector128<long> Upper) Widen(this IWVectorTraits128 athis, Vector128<int> source) {
            athis.Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector128s.Widen(Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> Lower, Vector128<ulong> Upper) Widen(this IWVectorTraits128 athis, Vector128<uint> source) {
            athis.Widen(source, out var a, out var b);
            return (a, b);
        }


        /// <inheritdoc cref="Vector128s.ShiftLeft_Args{T}(Vector128{T}, int)"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static (Vector128<T> args0, Vector128<T> args1) ShiftLeft_Args<T>(this IWVectorTraits128 athis, Vector128<T> dummy, int shiftAmount) where T : struct {
            if (typeof(sbyte) == typeof(T)) {
                (var args0, var args1) = athis.ShiftLeft_Args((Vector128<sbyte>)(object)dummy, shiftAmount);
                return ((Vector128<T>)(object)args0, (Vector128<T>)(object)args1);
            } else if (typeof(byte) == typeof(T)) {
                (var args0, var args1) = athis.ShiftLeft_Args((Vector128<byte>)(object)dummy, shiftAmount);
                return ((Vector128<T>)(object)args0, (Vector128<T>)(object)args1);
            } else if (typeof(short) == typeof(T)) {
                (var args0, var args1) = athis.ShiftLeft_Args((Vector128<short>)(object)dummy, shiftAmount);
                return ((Vector128<T>)(object)args0, (Vector128<T>)(object)args1);
            } else if (typeof(ushort) == typeof(T)) {
                (var args0, var args1) = athis.ShiftLeft_Args((Vector128<ushort>)(object)dummy, shiftAmount);
                return ((Vector128<T>)(object)args0, (Vector128<T>)(object)args1);
            } else if (typeof(int) == typeof(T)) {
                (var args0, var args1) = athis.ShiftLeft_Args((Vector128<int>)(object)dummy, shiftAmount);
                return ((Vector128<T>)(object)args0, (Vector128<T>)(object)args1);
            } else if (typeof(uint) == typeof(T)) {
                (var args0, var args1) = athis.ShiftLeft_Args((Vector128<uint>)(object)dummy, shiftAmount);
                return ((Vector128<T>)(object)args0, (Vector128<T>)(object)args1);
            } else if (typeof(long) == typeof(T)) {
                (var args0, var args1) = athis.ShiftLeft_Args((Vector128<long>)(object)dummy, shiftAmount);
                return ((Vector128<T>)(object)args0, (Vector128<T>)(object)args1);
            } else if (typeof(ulong) == typeof(T)) {
                (var args0, var args1) = athis.ShiftLeft_Args((Vector128<ulong>)(object)dummy, shiftAmount);
                return ((Vector128<T>)(object)args0, (Vector128<T>)(object)args1);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.ShiftLeft_Args(Vector128{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> args0, Vector128<sbyte> args1) ShiftLeft_Args(this IWVectorTraits128 athis, Vector128<sbyte> dummy, int shiftAmount) {
            var args0 = athis.ShiftLeft_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector128s.ShiftLeft_Args(Vector128{byte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> args0, Vector128<byte> args1) ShiftLeft_Args(this IWVectorTraits128 athis, Vector128<byte> dummy, int shiftAmount) {
            var args0 = athis.ShiftLeft_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector128s.ShiftLeft_Args(Vector128{short}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> args0, Vector128<short> args1) ShiftLeft_Args(this IWVectorTraits128 athis, Vector128<short> dummy, int shiftAmount) {
            var args0 = athis.ShiftLeft_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector128s.ShiftLeft_Args(Vector128{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> args0, Vector128<ushort> args1) ShiftLeft_Args(this IWVectorTraits128 athis, Vector128<ushort> dummy, int shiftAmount) {
            var args0 = athis.ShiftLeft_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector128s.ShiftLeft_Args(Vector128{int}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> args0, Vector128<int> args1) ShiftLeft_Args(this IWVectorTraits128 athis, Vector128<int> dummy, int shiftAmount) {
            var args0 = athis.ShiftLeft_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector128s.ShiftLeft_Args(Vector128{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> args0, Vector128<uint> args1) ShiftLeft_Args(this IWVectorTraits128 athis, Vector128<uint> dummy, int shiftAmount) {
            var args0 = athis.ShiftLeft_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector128s.ShiftLeft_Args(Vector128{long}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> args0, Vector128<long> args1) ShiftLeft_Args(this IWVectorTraits128 athis, Vector128<long> dummy, int shiftAmount) {
            var args0 = athis.ShiftLeft_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector128s.ShiftLeft_Args(Vector128{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> args0, Vector128<ulong> args1) ShiftLeft_Args(this IWVectorTraits128 athis, Vector128<ulong> dummy, int shiftAmount) {
            var args0 = athis.ShiftLeft_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }


        /// <inheritdoc cref="Vector128s.ShiftRightArithmetic_Args{T}(Vector128{T}, int)"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static (Vector128<T> args0, Vector128<T> args1) ShiftRightArithmetic_Args<T>(this IWVectorTraits128 athis, Vector128<T> dummy, int shiftAmount) where T : struct {
            if (typeof(sbyte) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightArithmetic_Args((Vector128<sbyte>)(object)dummy, shiftAmount);
                return ((Vector128<T>)(object)args0, (Vector128<T>)(object)args1);
            } else if (typeof(short) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightArithmetic_Args((Vector128<short>)(object)dummy, shiftAmount);
                return ((Vector128<T>)(object)args0, (Vector128<T>)(object)args1);
            } else if (typeof(int) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightArithmetic_Args((Vector128<int>)(object)dummy, shiftAmount);
                return ((Vector128<T>)(object)args0, (Vector128<T>)(object)args1);
            } else if (typeof(long) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightArithmetic_Args((Vector128<long>)(object)dummy, shiftAmount);
                return ((Vector128<T>)(object)args0, (Vector128<T>)(object)args1);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.ShiftRightArithmetic_Args(Vector128{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> args0, Vector128<sbyte> args1) ShiftRightArithmetic_Args(this IWVectorTraits128 athis, Vector128<sbyte> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightArithmetic_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector128s.ShiftRightArithmetic_Args(Vector128{short}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> args0, Vector128<short> args1) ShiftRightArithmetic_Args(this IWVectorTraits128 athis, Vector128<short> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightArithmetic_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector128s.ShiftRightArithmetic_Args(Vector128{int}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> args0, Vector128<int> args1) ShiftRightArithmetic_Args(this IWVectorTraits128 athis, Vector128<int> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightArithmetic_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector128s.ShiftRightArithmetic_Args(Vector128{long}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> args0, Vector128<long> args1) ShiftRightArithmetic_Args(this IWVectorTraits128 athis, Vector128<long> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightArithmetic_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }


        /// <inheritdoc cref="Vector128s.ShiftRightLogical_Args{T}(Vector128{T}, int)"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static (Vector128<T> args0, Vector128<T> args1) ShiftRightLogical_Args<T>(this IWVectorTraits128 athis, Vector128<T> dummy, int shiftAmount) where T : struct {
            if (typeof(sbyte) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightLogical_Args((Vector128<sbyte>)(object)dummy, shiftAmount);
                return ((Vector128<T>)(object)args0, (Vector128<T>)(object)args1);
            } else if (typeof(byte) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightLogical_Args((Vector128<byte>)(object)dummy, shiftAmount);
                return ((Vector128<T>)(object)args0, (Vector128<T>)(object)args1);
            } else if (typeof(short) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightLogical_Args((Vector128<short>)(object)dummy, shiftAmount);
                return ((Vector128<T>)(object)args0, (Vector128<T>)(object)args1);
            } else if (typeof(ushort) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightLogical_Args((Vector128<ushort>)(object)dummy, shiftAmount);
                return ((Vector128<T>)(object)args0, (Vector128<T>)(object)args1);
            } else if (typeof(int) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightLogical_Args((Vector128<int>)(object)dummy, shiftAmount);
                return ((Vector128<T>)(object)args0, (Vector128<T>)(object)args1);
            } else if (typeof(uint) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightLogical_Args((Vector128<uint>)(object)dummy, shiftAmount);
                return ((Vector128<T>)(object)args0, (Vector128<T>)(object)args1);
            } else if (typeof(long) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightLogical_Args((Vector128<long>)(object)dummy, shiftAmount);
                return ((Vector128<T>)(object)args0, (Vector128<T>)(object)args1);
            } else if (typeof(ulong) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightLogical_Args((Vector128<ulong>)(object)dummy, shiftAmount);
                return ((Vector128<T>)(object)args0, (Vector128<T>)(object)args1);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.ShiftRightLogical_Args(Vector128{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> args0, Vector128<sbyte> args1) ShiftRightLogical_Args(this IWVectorTraits128 athis, Vector128<sbyte> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightLogical_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector128s.ShiftRightLogical_Args(Vector128{byte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> args0, Vector128<byte> args1) ShiftRightLogical_Args(this IWVectorTraits128 athis, Vector128<byte> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightLogical_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector128s.ShiftRightLogical_Args(Vector128{short}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> args0, Vector128<short> args1) ShiftRightLogical_Args(this IWVectorTraits128 athis, Vector128<short> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightLogical_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector128s.ShiftRightLogical_Args(Vector128{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> args0, Vector128<ushort> args1) ShiftRightLogical_Args(this IWVectorTraits128 athis, Vector128<ushort> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightLogical_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector128s.ShiftRightLogical_Args(Vector128{int}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> args0, Vector128<int> args1) ShiftRightLogical_Args(this IWVectorTraits128 athis, Vector128<int> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightLogical_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector128s.ShiftRightLogical_Args(Vector128{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> args0, Vector128<uint> args1) ShiftRightLogical_Args(this IWVectorTraits128 athis, Vector128<uint> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightLogical_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector128s.ShiftRightLogical_Args(Vector128{long}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> args0, Vector128<long> args1) ShiftRightLogical_Args(this IWVectorTraits128 athis, Vector128<long> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightLogical_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector128s.ShiftRightLogical_Args(Vector128{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> args0, Vector128<ulong> args1) ShiftRightLogical_Args(this IWVectorTraits128 athis, Vector128<ulong> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightLogical_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }


        /// <inheritdoc cref="Vector128s.Shuffle_Args{TIdx}(Vector128{TIdx}, out Vector128{TIdx}, out Vector128{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void Shuffle_Args<TIdx>(this IWVectorTraits128 athis, Vector128<TIdx> indices, out Vector128<TIdx> args0, out Vector128<TIdx> args1)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b) = athis.Shuffle_Args((Vector128<sbyte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b) = athis.Shuffle_Args((Vector128<byte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b) = athis.Shuffle_Args((Vector128<short>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b) = athis.Shuffle_Args((Vector128<ushort>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b) = athis.Shuffle_Args((Vector128<int>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b) = athis.Shuffle_Args((Vector128<uint>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b) = athis.Shuffle_Args((Vector128<long>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b) = athis.Shuffle_Args((Vector128<ulong>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.Shuffle_Args{TIdx}(Vector128{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<TIdx> args0, Vector128<TIdx> args1) Shuffle_Args<TIdx>(this IWVectorTraits128 athis, Vector128<TIdx> indices)
                where TIdx : struct {
            athis.Shuffle_Args<TIdx>(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector128s.Shuffle_Args(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> args0, Vector128<sbyte> args1) Shuffle_Args(this IWVectorTraits128 athis, Vector128<sbyte> indices) {
            athis.Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector128s.Shuffle_Args(Vector128{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> args0, Vector128<byte> args1) Shuffle_Args(this IWVectorTraits128 athis, Vector128<byte> indices) {
            athis.Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector128s.Shuffle_Args(Vector128{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> args0, Vector128<short> args1) Shuffle_Args(this IWVectorTraits128 athis, Vector128<short> indices) {
            athis.Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector128s.Shuffle_Args(Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> args0, Vector128<ushort> args1) Shuffle_Args(this IWVectorTraits128 athis, Vector128<ushort> indices) {
            athis.Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector128s.Shuffle_Args(Vector128{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> args0, Vector128<int> args1) Shuffle_Args(this IWVectorTraits128 athis, Vector128<int> indices) {
            athis.Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector128s.Shuffle_Args(Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> args0, Vector128<uint> args1) Shuffle_Args(this IWVectorTraits128 athis, Vector128<uint> indices) {
            athis.Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector128s.Shuffle_Args(Vector128{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> args0, Vector128<long> args1) Shuffle_Args(this IWVectorTraits128 athis, Vector128<long> indices) {
            athis.Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector128s.Shuffle_Args(Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> args0, Vector128<ulong> args1) Shuffle_Args(this IWVectorTraits128 athis, Vector128<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits128.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.Shuffle_Core(Vector128{float}, Vector128{int}, Vector128{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<T> Shuffle_Core<T, TIdx>(this IWVectorTraits128 athis, Vector128<T> vector, (Vector128<TIdx> args0, Vector128<TIdx> args1) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.Shuffle_Core((Vector128<float>)(object)vector, (ValueTuple<Vector128<int>, Vector128<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.Shuffle_Core((Vector128<double>)(object)vector, (ValueTuple<Vector128<long>, Vector128<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.Shuffle_Core((Vector128<sbyte>)(object)vector, (ValueTuple<Vector128<sbyte>, Vector128<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.Shuffle_Core((Vector128<byte>)(object)vector, (ValueTuple<Vector128<byte>, Vector128<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.Shuffle_Core((Vector128<short>)(object)vector, (ValueTuple<Vector128<short>, Vector128<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.Shuffle_Core((Vector128<ushort>)(object)vector, (ValueTuple<Vector128<ushort>, Vector128<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.Shuffle_Core((Vector128<int>)(object)vector, (ValueTuple<Vector128<int>, Vector128<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.Shuffle_Core((Vector128<uint>)(object)vector, (ValueTuple<Vector128<uint>, Vector128<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.Shuffle_Core((Vector128<long>)(object)vector, (ValueTuple<Vector128<long>, Vector128<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector128<T>)(object)athis.Shuffle_Core((Vector128<ulong>)(object)vector, (ValueTuple<Vector128<ulong>, Vector128<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.Shuffle_Core(Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> Shuffle_Core(this IWVectorTraits128 athis, Vector128<float> vector, (Vector128<int> args0, Vector128<int> args1) args) {
            return athis.Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector128s.Shuffle_Core(Vector128{double}, ValueTuple{Vector128{long}, Vector128{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> Shuffle_Core(this IWVectorTraits128 athis, Vector128<double> vector, (Vector128<long> args0, Vector128<long> args1) args) {
            return athis.Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector128s.Shuffle_Core(Vector128{sbyte}, ValueTuple{Vector128{sbyte}, Vector128{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> Shuffle_Core(this IWVectorTraits128 athis, Vector128<sbyte> vector, (Vector128<sbyte> args0, Vector128<sbyte> args1) args) {
            return athis.Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector128s.Shuffle_Core(Vector128{byte}, ValueTuple{Vector128{byte}, Vector128{byte}})"/>
        [CLSCompliant(false)]
        public static Vector128<byte> Shuffle_Core(this IWVectorTraits128 athis, Vector128<byte> vector, (Vector128<byte> args0, Vector128<byte> args1) args) {
            return athis.Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector128s.Shuffle_Core(Vector128{short}, ValueTuple{Vector128{short}, Vector128{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> Shuffle_Core(this IWVectorTraits128 athis, Vector128<short> vector, (Vector128<short> args0, Vector128<short> args1) args) {
            return athis.Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector128s.Shuffle_Core(Vector128{ushort}, ValueTuple{Vector128{ushort}, Vector128{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> Shuffle_Core(this IWVectorTraits128 athis, Vector128<ushort> vector, (Vector128<ushort> args0, Vector128<ushort> args1) args) {
            return athis.Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector128s.Shuffle_Core(Vector128{int}, ValueTuple{Vector128{int}, Vector128{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> Shuffle_Core(this IWVectorTraits128 athis, Vector128<int> vector, (Vector128<int> args0, Vector128<int> args1) args) {
            return athis.Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector128s.Shuffle_Core(Vector128{uint}, ValueTuple{Vector128{uint}, Vector128{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> Shuffle_Core(this IWVectorTraits128 athis, Vector128<uint> vector, (Vector128<uint> args0, Vector128<uint> args1) args) {
            return athis.Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector128s.Shuffle_Core(Vector128{long}, ValueTuple{Vector128{long}, Vector128{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> Shuffle_Core(this IWVectorTraits128 athis, Vector128<long> vector, (Vector128<long> args0, Vector128<long> args1) args) {
            return athis.Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector128s.Shuffle_Core(Vector128{ulong}, ValueTuple{Vector128{ulong}, Vector128{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> Shuffle_Core(this IWVectorTraits128 athis, Vector128<ulong> vector, (Vector128<ulong> args0, Vector128<ulong> args1) args) {
            return athis.Shuffle_Core(vector, args.args0, args.args1);
        }


#endif // NETCOREAPP3_0_OR_GREATER
    }
}
