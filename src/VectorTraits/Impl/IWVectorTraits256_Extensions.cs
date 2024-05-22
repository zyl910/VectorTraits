﻿using System;
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
using Zyl.VectorTraits.Extensions;
using static Zyl.VectorTraits.Impl.VectorMessageFormats;

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// Extension methods of <seealso cref="IWVectorTraits256"/> (<seealso cref="IWVectorTraits256"/> 的扩展方法)
    /// </summary>
    public static partial class IWVectorTraits256_Extensions {
#if NETCOREAPP3_0_OR_GREATER

        /// <inheritdoc cref="Vector256s.GreaterThan_Unsigned(Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> GreaterThan_Unsigned(this IWVectorTraits256 athis, Vector256<sbyte> left, Vector256<sbyte> right) {
            return athis.GreaterThan(left.AsUnsigned(), right.AsUnsigned()).AsSigned();
        }

        /// <inheritdoc cref="Vector256s.GreaterThan_Unsigned(Vector256{byte}, Vector256{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> GreaterThan_Unsigned(this IWVectorTraits256 athis, Vector256<byte> left, Vector256<byte> right) {
            return athis.GreaterThan(left, right);
        }

        /// <inheritdoc cref="Vector256s.GreaterThan_Unsigned(Vector256{short}, Vector256{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> GreaterThan_Unsigned(this IWVectorTraits256 athis, Vector256<short> left, Vector256<short> right) {
            return athis.GreaterThan(left.AsUnsigned(), right.AsUnsigned()).AsSigned();
        }

        /// <inheritdoc cref="Vector256s.GreaterThan_Unsigned(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> GreaterThan_Unsigned(this IWVectorTraits256 athis, Vector256<ushort> left, Vector256<ushort> right) {
            return athis.GreaterThan(left, right);
        }

        /// <inheritdoc cref="Vector256s.GreaterThan_Unsigned(Vector256{int}, Vector256{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> GreaterThan_Unsigned(this IWVectorTraits256 athis, Vector256<int> left, Vector256<int> right) {
            return athis.GreaterThan(left.AsUnsigned(), right.AsUnsigned()).AsSigned();
        }

        /// <inheritdoc cref="Vector256s.GreaterThan_Unsigned(Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> GreaterThan_Unsigned(this IWVectorTraits256 athis, Vector256<uint> left, Vector256<uint> right) {
            return athis.GreaterThan(left, right);
        }

        /// <inheritdoc cref="Vector256s.GreaterThan_Unsigned(Vector256{long}, Vector256{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> GreaterThan_Unsigned(this IWVectorTraits256 athis, Vector256<long> left, Vector256<long> right) {
            return athis.GreaterThan(left.AsUnsigned(), right.AsUnsigned()).AsSigned();
        }

        /// <inheritdoc cref="Vector256s.GreaterThan_Unsigned(Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> GreaterThan_Unsigned(this IWVectorTraits256 athis, Vector256<ulong> left, Vector256<ulong> right) {
            return athis.GreaterThan(left, right);
        }


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


        /// <inheritdoc cref="Vector256s.ShiftLeft_Args{T}(Vector256{T}, int)"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static (Vector256<T> args0, Vector256<T> args1) ShiftLeft_Args<T>(this IWVectorTraits256 athis, Vector256<T> dummy, int shiftAmount) where T : struct {
            if (typeof(sbyte) == typeof(T)) {
                (var args0, var args1) = athis.ShiftLeft_Args((Vector256<sbyte>)(object)dummy, shiftAmount);
                return ((Vector256<T>)(object)args0, (Vector256<T>)(object)args1);
            } else if (typeof(byte) == typeof(T)) {
                (var args0, var args1) = athis.ShiftLeft_Args((Vector256<byte>)(object)dummy, shiftAmount);
                return ((Vector256<T>)(object)args0, (Vector256<T>)(object)args1);
            } else if (typeof(short) == typeof(T)) {
                (var args0, var args1) = athis.ShiftLeft_Args((Vector256<short>)(object)dummy, shiftAmount);
                return ((Vector256<T>)(object)args0, (Vector256<T>)(object)args1);
            } else if (typeof(ushort) == typeof(T)) {
                (var args0, var args1) = athis.ShiftLeft_Args((Vector256<ushort>)(object)dummy, shiftAmount);
                return ((Vector256<T>)(object)args0, (Vector256<T>)(object)args1);
            } else if (typeof(int) == typeof(T)) {
                (var args0, var args1) = athis.ShiftLeft_Args((Vector256<int>)(object)dummy, shiftAmount);
                return ((Vector256<T>)(object)args0, (Vector256<T>)(object)args1);
            } else if (typeof(uint) == typeof(T)) {
                (var args0, var args1) = athis.ShiftLeft_Args((Vector256<uint>)(object)dummy, shiftAmount);
                return ((Vector256<T>)(object)args0, (Vector256<T>)(object)args1);
            } else if (typeof(long) == typeof(T)) {
                (var args0, var args1) = athis.ShiftLeft_Args((Vector256<long>)(object)dummy, shiftAmount);
                return ((Vector256<T>)(object)args0, (Vector256<T>)(object)args1);
            } else if (typeof(ulong) == typeof(T)) {
                (var args0, var args1) = athis.ShiftLeft_Args((Vector256<ulong>)(object)dummy, shiftAmount);
                return ((Vector256<T>)(object)args0, (Vector256<T>)(object)args1);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector256s.ShiftLeft_Args(Vector256{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<sbyte> args0, Vector256<sbyte> args1) ShiftLeft_Args(this IWVectorTraits256 athis, Vector256<sbyte> dummy, int shiftAmount) {
            var args0 = athis.ShiftLeft_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector256s.ShiftLeft_Args(Vector256{byte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<byte> args0, Vector256<byte> args1) ShiftLeft_Args(this IWVectorTraits256 athis, Vector256<byte> dummy, int shiftAmount) {
            var args0 = athis.ShiftLeft_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector256s.ShiftLeft_Args(Vector256{short}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> args0, Vector256<short> args1) ShiftLeft_Args(this IWVectorTraits256 athis, Vector256<short> dummy, int shiftAmount) {
            var args0 = athis.ShiftLeft_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector256s.ShiftLeft_Args(Vector256{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ushort> args0, Vector256<ushort> args1) ShiftLeft_Args(this IWVectorTraits256 athis, Vector256<ushort> dummy, int shiftAmount) {
            var args0 = athis.ShiftLeft_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector256s.ShiftLeft_Args(Vector256{int}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> args0, Vector256<int> args1) ShiftLeft_Args(this IWVectorTraits256 athis, Vector256<int> dummy, int shiftAmount) {
            var args0 = athis.ShiftLeft_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector256s.ShiftLeft_Args(Vector256{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<uint> args0, Vector256<uint> args1) ShiftLeft_Args(this IWVectorTraits256 athis, Vector256<uint> dummy, int shiftAmount) {
            var args0 = athis.ShiftLeft_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector256s.ShiftLeft_Args(Vector256{long}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> args0, Vector256<long> args1) ShiftLeft_Args(this IWVectorTraits256 athis, Vector256<long> dummy, int shiftAmount) {
            var args0 = athis.ShiftLeft_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector256s.ShiftLeft_Args(Vector256{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ulong> args0, Vector256<ulong> args1) ShiftLeft_Args(this IWVectorTraits256 athis, Vector256<ulong> dummy, int shiftAmount) {
            var args0 = athis.ShiftLeft_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }


        /// <inheritdoc cref="Vector256s.ShiftRightArithmetic_Args{T}(Vector256{T}, int)"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static (Vector256<T> args0, Vector256<T> args1) ShiftRightArithmetic_Args<T>(this IWVectorTraits256 athis, Vector256<T> dummy, int shiftAmount) where T : struct {
            if (typeof(sbyte) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightArithmetic_Args((Vector256<sbyte>)(object)dummy, shiftAmount);
                return ((Vector256<T>)(object)args0, (Vector256<T>)(object)args1);
            } else if (typeof(short) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightArithmetic_Args((Vector256<short>)(object)dummy, shiftAmount);
                return ((Vector256<T>)(object)args0, (Vector256<T>)(object)args1);
            } else if (typeof(int) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightArithmetic_Args((Vector256<int>)(object)dummy, shiftAmount);
                return ((Vector256<T>)(object)args0, (Vector256<T>)(object)args1);
            } else if (typeof(long) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightArithmetic_Args((Vector256<long>)(object)dummy, shiftAmount);
                return ((Vector256<T>)(object)args0, (Vector256<T>)(object)args1);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector256s.ShiftRightArithmetic_Args(Vector256{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<sbyte> args0, Vector256<sbyte> args1) ShiftRightArithmetic_Args(this IWVectorTraits256 athis, Vector256<sbyte> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightArithmetic_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector256s.ShiftRightArithmetic_Args(Vector256{short}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> args0, Vector256<short> args1) ShiftRightArithmetic_Args(this IWVectorTraits256 athis, Vector256<short> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightArithmetic_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector256s.ShiftRightArithmetic_Args(Vector256{int}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> args0, Vector256<int> args1) ShiftRightArithmetic_Args(this IWVectorTraits256 athis, Vector256<int> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightArithmetic_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector256s.ShiftRightArithmetic_Args(Vector256{long}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> args0, Vector256<long> args1) ShiftRightArithmetic_Args(this IWVectorTraits256 athis, Vector256<long> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightArithmetic_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }


        /// <inheritdoc cref="Vector256s.ShiftRightLogical_Args{T}(Vector256{T}, int)"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static (Vector256<T> args0, Vector256<T> args1) ShiftRightLogical_Args<T>(this IWVectorTraits256 athis, Vector256<T> dummy, int shiftAmount) where T : struct {
            if (typeof(sbyte) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightLogical_Args((Vector256<sbyte>)(object)dummy, shiftAmount);
                return ((Vector256<T>)(object)args0, (Vector256<T>)(object)args1);
            } else if (typeof(byte) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightLogical_Args((Vector256<byte>)(object)dummy, shiftAmount);
                return ((Vector256<T>)(object)args0, (Vector256<T>)(object)args1);
            } else if (typeof(short) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightLogical_Args((Vector256<short>)(object)dummy, shiftAmount);
                return ((Vector256<T>)(object)args0, (Vector256<T>)(object)args1);
            } else if (typeof(ushort) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightLogical_Args((Vector256<ushort>)(object)dummy, shiftAmount);
                return ((Vector256<T>)(object)args0, (Vector256<T>)(object)args1);
            } else if (typeof(int) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightLogical_Args((Vector256<int>)(object)dummy, shiftAmount);
                return ((Vector256<T>)(object)args0, (Vector256<T>)(object)args1);
            } else if (typeof(uint) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightLogical_Args((Vector256<uint>)(object)dummy, shiftAmount);
                return ((Vector256<T>)(object)args0, (Vector256<T>)(object)args1);
            } else if (typeof(long) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightLogical_Args((Vector256<long>)(object)dummy, shiftAmount);
                return ((Vector256<T>)(object)args0, (Vector256<T>)(object)args1);
            } else if (typeof(ulong) == typeof(T)) {
                (var args0, var args1) = athis.ShiftRightLogical_Args((Vector256<ulong>)(object)dummy, shiftAmount);
                return ((Vector256<T>)(object)args0, (Vector256<T>)(object)args1);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector256s.ShiftRightLogical_Args(Vector256{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<sbyte> args0, Vector256<sbyte> args1) ShiftRightLogical_Args(this IWVectorTraits256 athis, Vector256<sbyte> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightLogical_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector256s.ShiftRightLogical_Args(Vector256{byte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<byte> args0, Vector256<byte> args1) ShiftRightLogical_Args(this IWVectorTraits256 athis, Vector256<byte> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightLogical_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector256s.ShiftRightLogical_Args(Vector256{short}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> args0, Vector256<short> args1) ShiftRightLogical_Args(this IWVectorTraits256 athis, Vector256<short> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightLogical_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector256s.ShiftRightLogical_Args(Vector256{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ushort> args0, Vector256<ushort> args1) ShiftRightLogical_Args(this IWVectorTraits256 athis, Vector256<ushort> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightLogical_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector256s.ShiftRightLogical_Args(Vector256{int}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> args0, Vector256<int> args1) ShiftRightLogical_Args(this IWVectorTraits256 athis, Vector256<int> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightLogical_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector256s.ShiftRightLogical_Args(Vector256{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<uint> args0, Vector256<uint> args1) ShiftRightLogical_Args(this IWVectorTraits256 athis, Vector256<uint> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightLogical_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector256s.ShiftRightLogical_Args(Vector256{long}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> args0, Vector256<long> args1) ShiftRightLogical_Args(this IWVectorTraits256 athis, Vector256<long> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightLogical_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
        }

        /// <inheritdoc cref="Vector256s.ShiftRightLogical_Args(Vector256{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ulong> args0, Vector256<ulong> args1) ShiftRightLogical_Args(this IWVectorTraits256 athis, Vector256<ulong> dummy, int shiftAmount) {
            var args0 = athis.ShiftRightLogical_Args(dummy, shiftAmount, out var args1);
            return (args0, args1);
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

        /// <inheritdoc cref="Vector256s.Shuffle_Args{TIdx}(Vector256{TIdx})"/>
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


#endif // NETCOREAPP3_0_OR_GREATER
    }
}
