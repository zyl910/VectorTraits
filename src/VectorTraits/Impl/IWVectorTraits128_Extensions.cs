using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Extensions;
using static Zyl.VectorTraits.Impl.VectorMessageFormats;

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// Extension methods of <seealso cref="IWVectorTraits128"/> (<seealso cref="IWVectorTraits128"/> 的扩展方法)
    /// </summary>
    public static partial class IWVectorTraits128_Extensions {
#if NETCOREAPP3_0_OR_GREATER

        /// <inheritdoc cref="Vector128s.GreaterThan_Unsigned(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> GreaterThan_Unsigned(this IWVectorTraits128 athis, Vector128<sbyte> left, Vector128<sbyte> right) {
            return athis.GreaterThan(left.AsUnsigned(), right.AsUnsigned()).AsSigned();
        }

        /// <inheritdoc cref="Vector128s.GreaterThan_Unsigned(Vector128{byte}, Vector128{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> GreaterThan_Unsigned(this IWVectorTraits128 athis, Vector128<byte> left, Vector128<byte> right) {
            return athis.GreaterThan(left, right);
        }

        /// <inheritdoc cref="Vector128s.GreaterThan_Unsigned(Vector128{short}, Vector128{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> GreaterThan_Unsigned(this IWVectorTraits128 athis, Vector128<short> left, Vector128<short> right) {
            return athis.GreaterThan(left.AsUnsigned(), right.AsUnsigned()).AsSigned();
        }

        /// <inheritdoc cref="Vector128s.GreaterThan_Unsigned(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> GreaterThan_Unsigned(this IWVectorTraits128 athis, Vector128<ushort> left, Vector128<ushort> right) {
            return athis.GreaterThan(left, right);
        }

        /// <inheritdoc cref="Vector128s.GreaterThan_Unsigned(Vector128{int}, Vector128{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> GreaterThan_Unsigned(this IWVectorTraits128 athis, Vector128<int> left, Vector128<int> right) {
            return athis.GreaterThan(left.AsUnsigned(), right.AsUnsigned()).AsSigned();
        }

        /// <inheritdoc cref="Vector128s.GreaterThan_Unsigned(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> GreaterThan_Unsigned(this IWVectorTraits128 athis, Vector128<uint> left, Vector128<uint> right) {
            return athis.GreaterThan(left, right);
        }

        /// <inheritdoc cref="Vector128s.GreaterThan_Unsigned(Vector128{long}, Vector128{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> GreaterThan_Unsigned(this IWVectorTraits128 athis, Vector128<long> left, Vector128<long> right) {
            return athis.GreaterThan(left.AsUnsigned(), right.AsUnsigned()).AsSigned();
        }

        /// <inheritdoc cref="Vector128s.GreaterThan_Unsigned(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> GreaterThan_Unsigned(this IWVectorTraits128 athis, Vector128<ulong> left, Vector128<ulong> right) {
            return athis.GreaterThan(left, right);
        }


        /// <inheritdoc cref="Vector128s.Widen{T, TOut}(Vector128{T}, out Vector128{TOut}, out Vector128{TOut})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static void Widen<T, TOut>(this IWVectorTraits128 athis, Vector128<T> source, out Vector128<TOut> lower, out Vector128<TOut> upper)
                 where T : struct where TOut : struct {
            if (typeof(float) == typeof(T) && typeof(double) == typeof(TOut)) {
                (Vector128<double> a, Vector128<double> b) = athis.Widen(source.As<T, float>());
                lower = a.As<double, TOut>();
                upper = b.As<double, TOut>();
            } else if (typeof(sbyte) == typeof(T) && typeof(short) == typeof(TOut)) {
                (Vector128<short> a, Vector128<short> b) = athis.Widen(source.As<T, sbyte>());
                lower = a.As<short, TOut>();
                upper = b.As<short, TOut>();
            } else if (typeof(byte) == typeof(T) && typeof(ushort) == typeof(TOut)) {
                (Vector128<ushort> a, Vector128<ushort> b) = athis.Widen(source.As<T, byte>());
                lower = a.As<ushort, TOut>();
                upper = b.As<ushort, TOut>();
            } else if (typeof(short) == typeof(T) && typeof(int) == typeof(TOut)) {
                (Vector128<int> a, Vector128<int> b) = athis.Widen(source.As<T, short>());
                lower = a.As<int, TOut>();
                upper = b.As<int, TOut>();
            } else if (typeof(ushort) == typeof(T) && typeof(uint) == typeof(TOut)) {
                (Vector128<uint> a, Vector128<uint> b) = athis.Widen(source.As<T, ushort>());
                lower = a.As<uint, TOut>();
                upper = b.As<uint, TOut>();
            } else if (typeof(int) == typeof(T) && typeof(long) == typeof(TOut)) {
                (Vector128<long> a, Vector128<long> b) = athis.Widen(source.As<T, int>());
                lower = a.As<long, TOut>();
                upper = b.As<long, TOut>();
            } else if (typeof(uint) == typeof(T) && typeof(ulong) == typeof(TOut)) {
                (Vector128<ulong> a, Vector128<ulong> b) = athis.Widen(source.As<T, uint>());
                lower = a.As<ulong, TOut>();
                upper = b.As<ulong, TOut>();
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
                return athis.Shuffle_Core(vector.As<T, float>(), Unsafe.As<ValueTuple<Vector128<TIdx>, Vector128<TIdx>>, ValueTuple<Vector128<int>, Vector128<int>>>(ref args)).As<float, T>();
            } else if (typeof(double) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return athis.Shuffle_Core(vector.As<T, double>(), Unsafe.As<ValueTuple<Vector128<TIdx>, Vector128<TIdx>>, ValueTuple<Vector128<long>, Vector128<long>>>(ref args)).As<double, T>();
            } else if (typeof(sbyte) == typeof(T) && typeof(sbyte) == typeof(TIdx)) {
                return athis.Shuffle_Core(vector.As<T, sbyte>(), Unsafe.As<ValueTuple<Vector128<TIdx>, Vector128<TIdx>>, ValueTuple<Vector128<sbyte>, Vector128<sbyte>>>(ref args)).As<sbyte, T>();
            } else if (typeof(byte) == typeof(T) && typeof(byte) == typeof(TIdx)) {
                return athis.Shuffle_Core(vector.As<T, byte>(), Unsafe.As<ValueTuple<Vector128<TIdx>, Vector128<TIdx>>, ValueTuple<Vector128<byte>, Vector128<byte>>>(ref args)).As<byte, T>();
            } else if (typeof(short) == typeof(T) && typeof(short) == typeof(TIdx)) {
                return athis.Shuffle_Core(vector.As<T, short>(), Unsafe.As<ValueTuple<Vector128<TIdx>, Vector128<TIdx>>, ValueTuple<Vector128<short>, Vector128<short>>>(ref args)).As<short, T>();
            } else if (typeof(ushort) == typeof(T) && typeof(ushort) == typeof(TIdx)) {
                return athis.Shuffle_Core(vector.As<T, ushort>(), Unsafe.As<ValueTuple<Vector128<TIdx>, Vector128<TIdx>>, ValueTuple<Vector128<ushort>, Vector128<ushort>>>(ref args)).As<ushort, T>();
            } else if (typeof(int) == typeof(T) && typeof(int) == typeof(TIdx)) {
                return athis.Shuffle_Core(vector.As<T, int>(), Unsafe.As<ValueTuple<Vector128<TIdx>, Vector128<TIdx>>, ValueTuple<Vector128<int>, Vector128<int>>>(ref args)).As<int, T>();
            } else if (typeof(uint) == typeof(T) && typeof(uint) == typeof(TIdx)) {
                return athis.Shuffle_Core(vector.As<T, uint>(), Unsafe.As<ValueTuple<Vector128<TIdx>, Vector128<TIdx>>, ValueTuple<Vector128<uint>, Vector128<uint>>>(ref args)).As<uint, T>();
            } else if (typeof(long) == typeof(T) && typeof(long) == typeof(TIdx)) {
                return athis.Shuffle_Core(vector.As<T, long>(), Unsafe.As<ValueTuple<Vector128<TIdx>, Vector128<TIdx>>, ValueTuple<Vector128<long>, Vector128<long>>>(ref args)).As<long, T>();
            } else if (typeof(ulong) == typeof(T) && typeof(ulong) == typeof(TIdx)) {
                return athis.Shuffle_Core(vector.As<T, ulong>(), Unsafe.As<ValueTuple<Vector128<TIdx>, Vector128<TIdx>>, ValueTuple<Vector128<ulong>, Vector128<ulong>>>(ref args)).As<ulong, T>();
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
