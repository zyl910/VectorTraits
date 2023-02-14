using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// Generic style methods for <see cref="Vector"/> (<see cref="Vector"/> 的泛型风格方法). 
    /// </summary>
    public static class VectorGeneric {

        /// <summary>
        /// Message format of NOT_SUPPORTED in case of 2 types (2个类型时，NOT_SUPPORTED的消息格式).
        /// </summary>
        public static readonly string FORMAT_TYPE_NOT_SUPPORTED_2 = "These element types({0}, {1}) are not supported!";

#if NETCOREAPP2_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER

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
                (Vector<double> a, Vector<double> b) = Widen((Vector<float>)(object)source);
                lower = (Vector<TOut>)(object)a;
                upper = (Vector<TOut>)(object)b;
            } else if (typeof(sbyte) == typeof(T) && typeof(short) == typeof(TOut)) {
                (Vector<short> a, Vector<short> b) = Widen((Vector<sbyte>)(object)source);
                lower = (Vector<TOut>)(object)a;
                upper = (Vector<TOut>)(object)b;
            } else if (typeof(byte) == typeof(T) && typeof(ushort) == typeof(TOut)) {
                (Vector<ushort> a, Vector<ushort> b) = Widen((Vector<byte>)(object)source);
                lower = (Vector<TOut>)(object)a;
                upper = (Vector<TOut>)(object)b;
            } else if (typeof(short) == typeof(T) && typeof(int) == typeof(TOut)) {
                (Vector<int> a, Vector<int> b) = Widen((Vector<short>)(object)source);
                lower = (Vector<TOut>)(object)a;
                upper = (Vector<TOut>)(object)b;
            } else if (typeof(ushort) == typeof(T) && typeof(uint) == typeof(TOut)) {
                (Vector<uint> a, Vector<uint> b) = Widen((Vector<ushort>)(object)source);
                lower = (Vector<TOut>)(object)a;
                upper = (Vector<TOut>)(object)b;
            } else if (typeof(int) == typeof(T) && typeof(long) == typeof(TOut)) {
                (Vector<long> a, Vector<long> b) = Widen((Vector<int>)(object)source);
                lower = (Vector<TOut>)(object)a;
                upper = (Vector<TOut>)(object)b;
            } else if (typeof(uint) == typeof(T) && typeof(ulong) == typeof(TOut)) {
                (Vector<ulong> a, Vector<ulong> b) = Widen((Vector<uint>)(object)source);
                lower = (Vector<TOut>)(object)a;
                upper = (Vector<TOut>)(object)b;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TOut).Name));
            }
        }

#endif // NETCOREAPP2_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
    }
}
