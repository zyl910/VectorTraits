﻿using System;
using System.Collections.Generic;
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

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
