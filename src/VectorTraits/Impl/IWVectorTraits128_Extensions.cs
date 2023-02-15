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
    public static class IWVectorTraits128_Extensions {

#if NETCOREAPP3_0_OR_GREATER

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

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
