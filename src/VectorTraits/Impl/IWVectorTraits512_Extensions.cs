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
using Zyl.VectorTraits.Extensions;
using static Zyl.VectorTraits.Impl.VectorMessageFormats;

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// Extension methods of <seealso cref="IWVectorTraits512"/> (<seealso cref="IWVectorTraits512"/> 的扩展方法)
    /// </summary>
    public static partial class IWVectorTraits512_Extensions {
#if NET8_0_OR_GREATER

        /// <inheritdoc cref="Vector512s.GreaterThan_Unsigned(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> GreaterThan_Unsigned(this IWVectorTraits512 athis, Vector512<sbyte> left, Vector512<sbyte> right) {
            return athis.GreaterThan(left.AsUnsigned(), right.AsUnsigned()).AsSigned();
        }

        /// <inheritdoc cref="Vector512s.GreaterThan_Unsigned(Vector512{byte}, Vector512{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> GreaterThan_Unsigned(this IWVectorTraits512 athis, Vector512<byte> left, Vector512<byte> right) {
            return athis.GreaterThan(left, right);
        }

        /// <inheritdoc cref="Vector512s.GreaterThan_Unsigned(Vector512{short}, Vector512{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> GreaterThan_Unsigned(this IWVectorTraits512 athis, Vector512<short> left, Vector512<short> right) {
            return athis.GreaterThan(left.AsUnsigned(), right.AsUnsigned()).AsSigned();
        }

        /// <inheritdoc cref="Vector512s.GreaterThan_Unsigned(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> GreaterThan_Unsigned(this IWVectorTraits512 athis, Vector512<ushort> left, Vector512<ushort> right) {
            return athis.GreaterThan(left, right);
        }

        /// <inheritdoc cref="Vector512s.GreaterThan_Unsigned(Vector512{int}, Vector512{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> GreaterThan_Unsigned(this IWVectorTraits512 athis, Vector512<int> left, Vector512<int> right) {
            return athis.GreaterThan(left.AsUnsigned(), right.AsUnsigned()).AsSigned();
        }

        /// <inheritdoc cref="Vector512s.GreaterThan_Unsigned(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> GreaterThan_Unsigned(this IWVectorTraits512 athis, Vector512<uint> left, Vector512<uint> right) {
            return athis.GreaterThan(left, right);
        }

        /// <inheritdoc cref="Vector512s.GreaterThan_Unsigned(Vector512{long}, Vector512{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> GreaterThan_Unsigned(this IWVectorTraits512 athis, Vector512<long> left, Vector512<long> right) {
            return athis.GreaterThan(left.AsUnsigned(), right.AsUnsigned()).AsSigned();
        }

        /// <inheritdoc cref="Vector512s.GreaterThan_Unsigned(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> GreaterThan_Unsigned(this IWVectorTraits512 athis, Vector512<ulong> left, Vector512<ulong> right) {
            return athis.GreaterThan(left, right);
        }


        /// <inheritdoc cref="Vector512s.Widen{T, TOut}(Vector512{T}, out Vector512{TOut}, out Vector512{TOut})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void Widen<T, TOut>(this IWVectorTraits512 athis, Vector512<T> source, out Vector512<TOut> lower, out Vector512<TOut> upper)
                 where T : struct where TOut : struct {
            if (typeof(float) == typeof(T) && typeof(double) == typeof(TOut)) {
                (Vector512<double> a, Vector512<double> b) = athis.Widen(source.As<T, float>());
                lower = a.As<double, TOut>();
                upper = b.As<double, TOut>();
            } else if (typeof(sbyte) == typeof(T) && typeof(short) == typeof(TOut)) {
                (Vector512<short> a, Vector512<short> b) = athis.Widen(source.As<T, sbyte>());
                lower = a.As<short, TOut>();
                upper = b.As<short, TOut>();
            } else if (typeof(byte) == typeof(T) && typeof(ushort) == typeof(TOut)) {
                (Vector512<ushort> a, Vector512<ushort> b) = athis.Widen(source.As<T, byte>());
                lower = a.As<ushort, TOut>();
                upper = b.As<ushort, TOut>();
            } else if (typeof(short) == typeof(T) && typeof(int) == typeof(TOut)) {
                (Vector512<int> a, Vector512<int> b) = athis.Widen(source.As<T, short>());
                lower = a.As<int, TOut>();
                upper = b.As<int, TOut>();
            } else if (typeof(ushort) == typeof(T) && typeof(uint) == typeof(TOut)) {
                (Vector512<uint> a, Vector512<uint> b) = athis.Widen(source.As<T, ushort>());
                lower = a.As<uint, TOut>();
                upper = b.As<uint, TOut>();
            } else if (typeof(int) == typeof(T) && typeof(long) == typeof(TOut)) {
                (Vector512<long> a, Vector512<long> b) = athis.Widen(source.As<T, int>());
                lower = a.As<long, TOut>();
                upper = b.As<long, TOut>();
            } else if (typeof(uint) == typeof(T) && typeof(ulong) == typeof(TOut)) {
                (Vector512<ulong> a, Vector512<ulong> b) = athis.Widen(source.As<T, uint>());
                lower = a.As<ulong, TOut>();
                upper = b.As<ulong, TOut>();
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
                return athis.Shuffle_Core(vector.As<T, float>(), Unsafe.As<ValueTuple<Vector512<TIdx>, Vector512<TIdx>>, ValueTuple<Vector512<int>, Vector512<int>>>(ref args)).As<float, T>();
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return athis.Shuffle_Core(vector.As<T, double>(), Unsafe.As<ValueTuple<Vector512<TIdx>, Vector512<TIdx>>, ValueTuple<Vector512<long>, Vector512<long>>>(ref args)).As<double, T>();
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return athis.Shuffle_Core(vector.As<T, sbyte>(), Unsafe.As<ValueTuple<Vector512<TIdx>, Vector512<TIdx>>, ValueTuple<Vector512<sbyte>, Vector512<sbyte>>>(ref args)).As<sbyte, T>();
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return athis.Shuffle_Core(vector.As<T, byte>(), Unsafe.As<ValueTuple<Vector512<TIdx>, Vector512<TIdx>>, ValueTuple<Vector512<byte>, Vector512<byte>>>(ref args)).As<byte, T>();
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return athis.Shuffle_Core(vector.As<T, short>(), Unsafe.As<ValueTuple<Vector512<TIdx>, Vector512<TIdx>>, ValueTuple<Vector512<short>, Vector512<short>>>(ref args)).As<short, T>();
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return athis.Shuffle_Core(vector.As<T, ushort>(), Unsafe.As<ValueTuple<Vector512<TIdx>, Vector512<TIdx>>, ValueTuple<Vector512<ushort>, Vector512<ushort>>>(ref args)).As<ushort, T>();
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return athis.Shuffle_Core(vector.As<T, int>(), Unsafe.As<ValueTuple<Vector512<TIdx>, Vector512<TIdx>>, ValueTuple<Vector512<int>, Vector512<int>>>(ref args)).As<int, T>();
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return athis.Shuffle_Core(vector.As<T, uint>(), Unsafe.As<ValueTuple<Vector512<TIdx>, Vector512<TIdx>>, ValueTuple<Vector512<uint>, Vector512<uint>>>(ref args)).As<uint, T>();
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return athis.Shuffle_Core(vector.As<T, long>(), Unsafe.As<ValueTuple<Vector512<TIdx>, Vector512<TIdx>>, ValueTuple<Vector512<long>, Vector512<long>>>(ref args)).As<long, T>();
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return athis.Shuffle_Core(vector.As<T, ulong>(), Unsafe.As<ValueTuple<Vector512<TIdx>, Vector512<TIdx>>, ValueTuple<Vector512<ulong>, Vector512<ulong>>>(ref args)).As<ulong, T>();
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
