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
    /// Extension methods of <seealso cref="IWVectorTraits512"/> (<seealso cref="IWVectorTraits512"/> 的扩展方法)
    /// </summary>
    public static partial class IWVectorTraits512_Extensions {
#if NET8_0_OR_GREATER

        /// <inheritdoc cref="Vector512s.Widen{T, TOut}(Vector512{T}, out Vector512{TOut}, out Vector512{TOut})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void Widen<T, TOut>(this IWVectorTraits512 athis, Vector512<T> source, out Vector512<TOut> lower, out Vector512<TOut> upper)
                 where T : struct where TOut : struct {
            if (typeof(float) == typeof(T) && typeof(double) == typeof(TOut)) {
                (Vector512<double> a, Vector512<double> b) = athis.Widen((Vector512<float>)(object)source);
                lower = (Vector512<TOut>)(object)a;
                upper = (Vector512<TOut>)(object)b;
            } else if (typeof(sbyte) == typeof(T) && typeof(short) == typeof(TOut)) {
                (Vector512<short> a, Vector512<short> b) = athis.Widen((Vector512<sbyte>)(object)source);
                lower = (Vector512<TOut>)(object)a;
                upper = (Vector512<TOut>)(object)b;
            } else if (typeof(byte) == typeof(T) && typeof(ushort) == typeof(TOut)) {
                (Vector512<ushort> a, Vector512<ushort> b) = athis.Widen((Vector512<byte>)(object)source);
                lower = (Vector512<TOut>)(object)a;
                upper = (Vector512<TOut>)(object)b;
            } else if (typeof(short) == typeof(T) && typeof(int) == typeof(TOut)) {
                (Vector512<int> a, Vector512<int> b) = athis.Widen((Vector512<short>)(object)source);
                lower = (Vector512<TOut>)(object)a;
                upper = (Vector512<TOut>)(object)b;
            } else if (typeof(ushort) == typeof(T) && typeof(uint) == typeof(TOut)) {
                (Vector512<uint> a, Vector512<uint> b) = athis.Widen((Vector512<ushort>)(object)source);
                lower = (Vector512<TOut>)(object)a;
                upper = (Vector512<TOut>)(object)b;
            } else if (typeof(int) == typeof(T) && typeof(long) == typeof(TOut)) {
                (Vector512<long> a, Vector512<long> b) = athis.Widen((Vector512<int>)(object)source);
                lower = (Vector512<TOut>)(object)a;
                upper = (Vector512<TOut>)(object)b;
            } else if (typeof(uint) == typeof(T) && typeof(ulong) == typeof(TOut)) {
                (Vector512<ulong> a, Vector512<ulong> b) = athis.Widen((Vector512<uint>)(object)source);
                lower = (Vector512<TOut>)(object)a;
                upper = (Vector512<TOut>)(object)b;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TOut).Name));
            }
        }

        /// <inheritdoc cref="Vector512s.Widen(Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<double> Lower, Vector512<double> Upper) Widen(this IWVectorTraits512 athis, Vector512<float> source) {
            athis.Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector512s.Widen(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<short> Lower, Vector512<short> Upper) Widen(this IWVectorTraits512 athis, Vector512<sbyte> source) {
            athis.Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector512s.Widen(Vector512{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ushort> Lower, Vector512<ushort> Upper) Widen(this IWVectorTraits512 athis, Vector512<byte> source) {
            athis.Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector512s.Widen(Vector512{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<int> Lower, Vector512<int> Upper) Widen(this IWVectorTraits512 athis, Vector512<short> source) {
            athis.Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector512s.Widen(Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<uint> Lower, Vector512<uint> Upper) Widen(this IWVectorTraits512 athis, Vector512<ushort> source) {
            athis.Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector512s.Widen(Vector512{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<long> Lower, Vector512<long> Upper) Widen(this IWVectorTraits512 athis, Vector512<int> source) {
            athis.Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector512s.Widen(Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ulong> Lower, Vector512<ulong> Upper) Widen(this IWVectorTraits512 athis, Vector512<uint> source) {
            athis.Widen(source, out var a, out var b);
            return (a, b);
        }


        /// <inheritdoc cref="Vector512s.ShiftLeft_Args{T}(Vector512{T}, int)"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static (Vector512<T> args0, Vector512<T> args1) ShiftLeft_Args<T>(this IWVectorTraits512 athis, Vector512<T> dummy, int shiftAmount) where T : struct {
            if (typeof(sbyte) == typeof(T)) {
                (var args0, var args1) = athis.ShiftLeft_Args((Vector512<sbyte>)(object)dummy, shiftAmount);
                return ((Vector512<T>)(object)args0, (Vector512<T>)(object)args1);
            } else if (typeof(byte) == typeof(T)) {
                (var args0, var args1) = athis.ShiftLeft_Args((Vector512<byte>)(object)dummy, shiftAmount);
                return ((Vector512<T>)(object)args0, (Vector512<T>)(object)args1);
            } else if (typeof(short) == typeof(T)) {
                (var args0, var args1) = athis.ShiftLeft_Args((Vector512<short>)(object)dummy, shiftAmount);
                return ((Vector512<T>)(object)args0, (Vector512<T>)(object)args1);
            } else if (typeof(ushort) == typeof(T)) {
                (var args0, var args1) = athis.ShiftLeft_Args((Vector512<ushort>)(object)dummy, shiftAmount);
                return ((Vector512<T>)(object)args0, (Vector512<T>)(object)args1);
            } else if (typeof(int) == typeof(T)) {
                (var args0, var args1) = athis.ShiftLeft_Args((Vector512<int>)(object)dummy, shiftAmount);
                return ((Vector512<T>)(object)args0, (Vector512<T>)(object)args1);
            } else if (typeof(uint) == typeof(T)) {
                (var args0, var args1) = athis.ShiftLeft_Args((Vector512<uint>)(object)dummy, shiftAmount);
                return ((Vector512<T>)(object)args0, (Vector512<T>)(object)args1);
            } else if (typeof(long) == typeof(T)) {
                (var args0, var args1) = athis.ShiftLeft_Args((Vector512<long>)(object)dummy, shiftAmount);
                return ((Vector512<T>)(object)args0, (Vector512<T>)(object)args1);
            } else if (typeof(ulong) == typeof(T)) {
                (var args0, var args1) = athis.ShiftLeft_Args((Vector512<ulong>)(object)dummy, shiftAmount);
                return ((Vector512<T>)(object)args0, (Vector512<T>)(object)args1);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector512s.ShiftLeft_Args(Vector512{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<sbyte> args0, Vector512<sbyte> args1) ShiftLeft_Args(this IWVectorTraits512 athis, Vector512<sbyte> dummy, int shiftAmount) {
            var args0 = athis.ShiftLeft_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector512s.ShiftLeft_Args(Vector512{byte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<byte> args0, Vector512<byte> args1) ShiftLeft_Args(this IWVectorTraits512 athis, Vector512<byte> dummy, int shiftAmount) {
            var args0 = athis.ShiftLeft_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector512s.ShiftLeft_Args(Vector512{short}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<short> args0, Vector512<short> args1) ShiftLeft_Args(this IWVectorTraits512 athis, Vector512<short> dummy, int shiftAmount) {
            var args0 = athis.ShiftLeft_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector512s.ShiftLeft_Args(Vector512{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ushort> args0, Vector512<ushort> args1) ShiftLeft_Args(this IWVectorTraits512 athis, Vector512<ushort> dummy, int shiftAmount) {
            var args0 = athis.ShiftLeft_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector512s.ShiftLeft_Args(Vector512{int}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<int> args0, Vector512<int> args1) ShiftLeft_Args(this IWVectorTraits512 athis, Vector512<int> dummy, int shiftAmount) {
            var args0 = athis.ShiftLeft_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector512s.ShiftLeft_Args(Vector512{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<uint> args0, Vector512<uint> args1) ShiftLeft_Args(this IWVectorTraits512 athis, Vector512<uint> dummy, int shiftAmount) {
            var args0 = athis.ShiftLeft_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector512s.ShiftLeft_Args(Vector512{long}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<long> args0, Vector512<long> args1) ShiftLeft_Args(this IWVectorTraits512 athis, Vector512<long> dummy, int shiftAmount) {
            var args0 = athis.ShiftLeft_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector512s.ShiftLeft_Args(Vector512{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ulong> args0, Vector512<ulong> args1) ShiftLeft_Args(this IWVectorTraits512 athis, Vector512<ulong> dummy, int shiftAmount) {
            var args0 = athis.ShiftLeft_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }


        /// <inheritdoc cref="Vector512s.ShiftRightArithmetic_Args{T}(Vector512{T}, int)"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static (Vector512<T> args0, Vector512<T> args1) ShiftRightArithmetic_Args<T>(this IWVectorTraits512 athis, Vector512<T> dummy, int shiftAmount) where T : struct {
            if (typeof(sbyte) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightArithmetic_Args((Vector512<sbyte>)(object)dummy, shiftAmount);
                return ((Vector512<T>)(object)args0, (Vector512<T>)(object)args1);
            } else if (typeof(short) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightArithmetic_Args((Vector512<short>)(object)dummy, shiftAmount);
                return ((Vector512<T>)(object)args0, (Vector512<T>)(object)args1);
            } else if (typeof(int) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightArithmetic_Args((Vector512<int>)(object)dummy, shiftAmount);
                return ((Vector512<T>)(object)args0, (Vector512<T>)(object)args1);
            } else if (typeof(long) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightArithmetic_Args((Vector512<long>)(object)dummy, shiftAmount);
                return ((Vector512<T>)(object)args0, (Vector512<T>)(object)args1);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector512s.ShiftRightArithmetic_Args(Vector512{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<sbyte> args0, Vector512<sbyte> args1) ShiftRightArithmetic_Args(this IWVectorTraits512 athis, Vector512<sbyte> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightArithmetic_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector512s.ShiftRightArithmetic_Args(Vector512{short}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<short> args0, Vector512<short> args1) ShiftRightArithmetic_Args(this IWVectorTraits512 athis, Vector512<short> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightArithmetic_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector512s.ShiftRightArithmetic_Args(Vector512{int}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<int> args0, Vector512<int> args1) ShiftRightArithmetic_Args(this IWVectorTraits512 athis, Vector512<int> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightArithmetic_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector512s.ShiftRightArithmetic_Args(Vector512{long}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<long> args0, Vector512<long> args1) ShiftRightArithmetic_Args(this IWVectorTraits512 athis, Vector512<long> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightArithmetic_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }


        /// <inheritdoc cref="Vector512s.ShiftRightLogical_Args{T}(Vector512{T}, int)"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static (Vector512<T> args0, Vector512<T> args1) ShiftRightLogical_Args<T>(this IWVectorTraits512 athis, Vector512<T> dummy, int shiftAmount) where T : struct {
            if (typeof(sbyte) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightLogical_Args((Vector512<sbyte>)(object)dummy, shiftAmount);
                return ((Vector512<T>)(object)args0, (Vector512<T>)(object)args1);
            } else if (typeof(byte) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightLogical_Args((Vector512<byte>)(object)dummy, shiftAmount);
                return ((Vector512<T>)(object)args0, (Vector512<T>)(object)args1);
            } else if (typeof(short) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightLogical_Args((Vector512<short>)(object)dummy, shiftAmount);
                return ((Vector512<T>)(object)args0, (Vector512<T>)(object)args1);
            } else if (typeof(ushort) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightLogical_Args((Vector512<ushort>)(object)dummy, shiftAmount);
                return ((Vector512<T>)(object)args0, (Vector512<T>)(object)args1);
            } else if (typeof(int) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightLogical_Args((Vector512<int>)(object)dummy, shiftAmount);
                return ((Vector512<T>)(object)args0, (Vector512<T>)(object)args1);
            } else if (typeof(uint) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightLogical_Args((Vector512<uint>)(object)dummy, shiftAmount);
                return ((Vector512<T>)(object)args0, (Vector512<T>)(object)args1);
            } else if (typeof(long) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightLogical_Args((Vector512<long>)(object)dummy, shiftAmount);
                return ((Vector512<T>)(object)args0, (Vector512<T>)(object)args1);
            } else if (typeof(ulong) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightLogical_Args((Vector512<ulong>)(object)dummy, shiftAmount);
                return ((Vector512<T>)(object)args0, (Vector512<T>)(object)args1);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector512s.ShiftRightLogical_Args(Vector512{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<sbyte> args0, Vector512<sbyte> args1) ShiftRightLogical_Args(this IWVectorTraits512 athis, Vector512<sbyte> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightLogical_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector512s.ShiftRightLogical_Args(Vector512{byte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<byte> args0, Vector512<byte> args1) ShiftRightLogical_Args(this IWVectorTraits512 athis, Vector512<byte> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightLogical_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector512s.ShiftRightLogical_Args(Vector512{short}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<short> args0, Vector512<short> args1) ShiftRightLogical_Args(this IWVectorTraits512 athis, Vector512<short> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightLogical_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector512s.ShiftRightLogical_Args(Vector512{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ushort> args0, Vector512<ushort> args1) ShiftRightLogical_Args(this IWVectorTraits512 athis, Vector512<ushort> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightLogical_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector512s.ShiftRightLogical_Args(Vector512{int}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<int> args0, Vector512<int> args1) ShiftRightLogical_Args(this IWVectorTraits512 athis, Vector512<int> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightLogical_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector512s.ShiftRightLogical_Args(Vector512{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<uint> args0, Vector512<uint> args1) ShiftRightLogical_Args(this IWVectorTraits512 athis, Vector512<uint> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightLogical_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector512s.ShiftRightLogical_Args(Vector512{long}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<long> args0, Vector512<long> args1) ShiftRightLogical_Args(this IWVectorTraits512 athis, Vector512<long> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightLogical_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector512s.ShiftRightLogical_Args(Vector512{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ulong> args0, Vector512<ulong> args1) ShiftRightLogical_Args(this IWVectorTraits512 athis, Vector512<ulong> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightLogical_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }


        /// <inheritdoc cref="Vector512s.Shuffle_Args{TIdx}(Vector512{TIdx}, out Vector512{TIdx}, out Vector512{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void Shuffle_Args<TIdx>(this IWVectorTraits512 athis, Vector512<TIdx> indices, out Vector512<TIdx> args0, out Vector512<TIdx> args1)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b) = athis.Shuffle_Args((Vector512<sbyte>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b) = athis.Shuffle_Args((Vector512<byte>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b) = athis.Shuffle_Args((Vector512<short>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b) = athis.Shuffle_Args((Vector512<ushort>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b) = athis.Shuffle_Args((Vector512<int>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b) = athis.Shuffle_Args((Vector512<uint>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b) = athis.Shuffle_Args((Vector512<long>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b) = athis.Shuffle_Args((Vector512<ulong>)(object)indices);
                args0 = (Vector512<TIdx>)(object)a;
                args1 = (Vector512<TIdx>)(object)b;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector512s.Shuffle_Args{TIdx}(Vector512{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<TIdx> args0, Vector512<TIdx> args1) Shuffle_Args<TIdx>(this IWVectorTraits512 athis, Vector512<TIdx> indices)
                where TIdx : struct {
            athis.Shuffle_Args<TIdx>(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector512s.Shuffle_Args(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<sbyte> args0, Vector512<sbyte> args1) Shuffle_Args(this IWVectorTraits512 athis, Vector512<sbyte> indices) {
            athis.Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector512s.Shuffle_Args(Vector512{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<byte> args0, Vector512<byte> args1) Shuffle_Args(this IWVectorTraits512 athis, Vector512<byte> indices) {
            athis.Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector512s.Shuffle_Args(Vector512{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<short> args0, Vector512<short> args1) Shuffle_Args(this IWVectorTraits512 athis, Vector512<short> indices) {
            athis.Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector512s.Shuffle_Args(Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ushort> args0, Vector512<ushort> args1) Shuffle_Args(this IWVectorTraits512 athis, Vector512<ushort> indices) {
            athis.Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector512s.Shuffle_Args(Vector512{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<int> args0, Vector512<int> args1) Shuffle_Args(this IWVectorTraits512 athis, Vector512<int> indices) {
            athis.Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector512s.Shuffle_Args(Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<uint> args0, Vector512<uint> args1) Shuffle_Args(this IWVectorTraits512 athis, Vector512<uint> indices) {
            athis.Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector512s.Shuffle_Args(Vector512{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<long> args0, Vector512<long> args1) Shuffle_Args(this IWVectorTraits512 athis, Vector512<long> indices) {
            athis.Shuffle_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector512s.Shuffle_Args(Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ulong> args0, Vector512<ulong> args1) Shuffle_Args(this IWVectorTraits512 athis, Vector512<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits512.Shuffle_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits512.Shuffle_Core(Vector512{float}, Vector512{int}, Vector512{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<T> Shuffle_Core<T, TIdx>(this IWVectorTraits512 athis, Vector512<T> vector, (Vector512<TIdx> args0, Vector512<TIdx> args1) args)
                 where T : struct where TIdx : struct {
            if (typeof(float) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.Shuffle_Core((Vector512<float>)(object)vector, (ValueTuple<Vector512<int>, Vector512<int>>)(object)args);
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.Shuffle_Core((Vector512<double>)(object)vector, (ValueTuple<Vector512<long>, Vector512<long>>)(object)args);
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.Shuffle_Core((Vector512<sbyte>)(object)vector, (ValueTuple<Vector512<sbyte>, Vector512<sbyte>>)(object)args);
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.Shuffle_Core((Vector512<byte>)(object)vector, (ValueTuple<Vector512<byte>, Vector512<byte>>)(object)args);
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.Shuffle_Core((Vector512<short>)(object)vector, (ValueTuple<Vector512<short>, Vector512<short>>)(object)args);
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.Shuffle_Core((Vector512<ushort>)(object)vector, (ValueTuple<Vector512<ushort>, Vector512<ushort>>)(object)args);
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.Shuffle_Core((Vector512<int>)(object)vector, (ValueTuple<Vector512<int>, Vector512<int>>)(object)args);
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.Shuffle_Core((Vector512<uint>)(object)vector, (ValueTuple<Vector512<uint>, Vector512<uint>>)(object)args);
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.Shuffle_Core((Vector512<long>)(object)vector, (ValueTuple<Vector512<long>, Vector512<long>>)(object)args);
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return (Vector512<T>)(object)athis.Shuffle_Core((Vector512<ulong>)(object)vector, (ValueTuple<Vector512<ulong>, Vector512<ulong>>)(object)args);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TIdx).Name));
            }
        }

        /// <inheritdoc cref="Vector512s.Shuffle_Core(Vector512{float}, ValueTuple{Vector512{int}, Vector512{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> Shuffle_Core(this IWVectorTraits512 athis, Vector512<float> vector, (Vector512<int> args0, Vector512<int> args1) args) {
            return athis.Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector512s.Shuffle_Core(Vector512{double}, ValueTuple{Vector512{long}, Vector512{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> Shuffle_Core(this IWVectorTraits512 athis, Vector512<double> vector, (Vector512<long> args0, Vector512<long> args1) args) {
            return athis.Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector512s.Shuffle_Core(Vector512{sbyte}, ValueTuple{Vector512{sbyte}, Vector512{sbyte}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> Shuffle_Core(this IWVectorTraits512 athis, Vector512<sbyte> vector, (Vector512<sbyte> args0, Vector512<sbyte> args1) args) {
            return athis.Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector512s.Shuffle_Core(Vector512{byte}, ValueTuple{Vector512{byte}, Vector512{byte}})"/>
        [CLSCompliant(false)]
        public static Vector512<byte> Shuffle_Core(this IWVectorTraits512 athis, Vector512<byte> vector, (Vector512<byte> args0, Vector512<byte> args1) args) {
            return athis.Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector512s.Shuffle_Core(Vector512{short}, ValueTuple{Vector512{short}, Vector512{short}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> Shuffle_Core(this IWVectorTraits512 athis, Vector512<short> vector, (Vector512<short> args0, Vector512<short> args1) args) {
            return athis.Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector512s.Shuffle_Core(Vector512{ushort}, ValueTuple{Vector512{ushort}, Vector512{ushort}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> Shuffle_Core(this IWVectorTraits512 athis, Vector512<ushort> vector, (Vector512<ushort> args0, Vector512<ushort> args1) args) {
            return athis.Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector512s.Shuffle_Core(Vector512{int}, ValueTuple{Vector512{int}, Vector512{int}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> Shuffle_Core(this IWVectorTraits512 athis, Vector512<int> vector, (Vector512<int> args0, Vector512<int> args1) args) {
            return athis.Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector512s.Shuffle_Core(Vector512{uint}, ValueTuple{Vector512{uint}, Vector512{uint}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> Shuffle_Core(this IWVectorTraits512 athis, Vector512<uint> vector, (Vector512<uint> args0, Vector512<uint> args1) args) {
            return athis.Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector512s.Shuffle_Core(Vector512{long}, ValueTuple{Vector512{long}, Vector512{long}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> Shuffle_Core(this IWVectorTraits512 athis, Vector512<long> vector, (Vector512<long> args0, Vector512<long> args1) args) {
            return athis.Shuffle_Core(vector, args.args0, args.args1);
        }

        /// <inheritdoc cref="Vector512s.Shuffle_Core(Vector512{ulong}, ValueTuple{Vector512{ulong}, Vector512{ulong}})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> Shuffle_Core(this IWVectorTraits512 athis, Vector512<ulong> vector, (Vector512<ulong> args0, Vector512<ulong> args1) args) {
            return athis.Shuffle_Core(vector, args.args0, args.args1);
        }


#endif // NETCOREAPP3_0_OR_GREATER
    }
}
