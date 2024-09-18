using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using Zyl.VectorTraits.Extensions.SameW;
using static Zyl.VectorTraits.Impl.VectorMessageFormats;

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// Generic style methods for <see cref="Vector"/> (<see cref="Vector"/> 的泛型风格方法). 
    /// </summary>
    public static class VectorGeneric {

        /// <inheritdoc cref="Vectors.Widen(Vector{float}, out Vector{double}, out Vector{double})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<double> Lower, Vector<double> Upper) Widen(Vector<float> source) {
            Vector.Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vectors.Widen(Vector{sbyte}, out Vector{short}, out Vector{short})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> Lower, Vector<short> Upper) Widen(Vector<sbyte> source) {
            Vector.Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vectors.Widen(Vector{byte}, out Vector{ushort}, out Vector{ushort})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> Lower, Vector<ushort> Upper) Widen(Vector<byte> source) {
            Vector.Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vectors.Widen(Vector{short}, out Vector{int}, out Vector{int})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> Lower, Vector<int> Upper) Widen(Vector<short> source) {
            Vector.Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vectors.Widen(Vector{ushort}, out Vector{uint}, out Vector{uint})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> Lower, Vector<uint> Upper) Widen(Vector<ushort> source) {
            Vector.Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vectors.Widen(Vector{int}, out Vector{long}, out Vector{long})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> Lower, Vector<long> Upper) Widen(Vector<int> source) {
            Vector.Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vectors.Widen(Vector{uint}, out Vector{ulong}, out Vector{ulong})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> Lower, Vector<ulong> Upper) Widen(Vector<uint> source) {
            Vector.Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vectors.Widen{T, TOut}(Vector{T}, out Vector{TOut}, out Vector{TOut})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void Widen<T, TOut>(Vector<T> source, out Vector<TOut> lower, out Vector<TOut> upper)
                 where T : struct where TOut : struct {
            if (typeof(float) == typeof(T) && typeof(double) == typeof(TOut)) {
                (Vector<double> a, Vector<double> b) = Widen(source.As<T, float>());
                lower = a.As<double, TOut>();
                upper = b.As<double, TOut>();
            } else if (typeof(sbyte) == typeof(T) && typeof(short) == typeof(TOut)) {
                (Vector<short> a, Vector<short> b) = Widen(source.As<T, sbyte>());
                lower = a.As<short, TOut>();
                upper = b.As<short, TOut>();
            } else if (typeof(byte) == typeof(T) && typeof(ushort) == typeof(TOut)) {
                (Vector<ushort> a, Vector<ushort> b) = Widen(source.As<T, byte>());
                lower = a.As<ushort, TOut>();
                upper = b.As<ushort, TOut>();
            } else if (typeof(short) == typeof(T) && typeof(int) == typeof(TOut)) {
                (Vector<int> a, Vector<int> b) = Widen(source.As<T, short>());
                lower = a.As<int, TOut>();
                upper = b.As<int, TOut>();
            } else if (typeof(ushort) == typeof(T) && typeof(uint) == typeof(TOut)) {
                (Vector<uint> a, Vector<uint> b) = Widen(source.As<T, ushort>());
                lower = a.As<uint, TOut>();
                upper = b.As<uint, TOut>();
            } else if (typeof(int) == typeof(T) && typeof(long) == typeof(TOut)) {
                (Vector<long> a, Vector<long> b) = Widen(source.As<T, int>());
                lower = a.As<long, TOut>();
                upper = b.As<long, TOut>();
            } else if (typeof(uint) == typeof(T) && typeof(ulong) == typeof(TOut)) {
                (Vector<ulong> a, Vector<ulong> b) = Widen(source.As<T, uint>());
                lower = a.As<ulong, TOut>();
                upper = b.As<ulong, TOut>();
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TOut).Name));
            }
        }

    }
}
