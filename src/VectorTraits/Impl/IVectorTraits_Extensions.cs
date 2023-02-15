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
    public static class IVectorTraits_Extensions {

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

    }
}
