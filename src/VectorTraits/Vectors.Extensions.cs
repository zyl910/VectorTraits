using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using Zyl.VectorTraits.Impl;
using static Zyl.VectorTraits.Impl.VectorMessageFormats;

namespace Zyl.VectorTraits {
    static partial class Vectors {

        /// <summary>
        /// Widens a <seealso cref="Vector{T}"/> into two <seealso cref="Vector{T}"/> instances - Generic version (将一个 <seealso cref="Vector{T}"/> 扩宽为两个 <seealso cref="Vector{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩宽向量).</returns>
        /// <seealso cref="Vector.Widen(Vector{float}, out Vector{double}, out Vector{double})" />
        /// <seealso cref="IVectorTraits.Widen(Vector{float}, out Vector{double}, out Vector{double})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<double> Lower, Vector<double> Upper) Widen(Vector<float> source) {
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector{T}"/> into two <seealso cref="Vector{T}"/> instances - Generic version (将一个 <seealso cref="Vector{T}"/> 扩宽为两个 <seealso cref="Vector{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩宽向量).</returns>
        /// <seealso cref="Vector.Widen(Vector{sbyte}, out Vector{short}, out Vector{short})" />
        /// <seealso cref="IVectorTraits.Widen(Vector{sbyte}, out Vector{short}, out Vector{short})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> Lower, Vector<short> Upper) Widen(Vector<sbyte> source) {
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector{T}"/> into two <seealso cref="Vector{T}"/> instances - Generic version (将一个 <seealso cref="Vector{T}"/> 扩宽为两个 <seealso cref="Vector{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩宽向量).</returns>
        /// <seealso cref="Vector.Widen(Vector{byte}, out Vector{ushort}, out Vector{ushort})" />
        /// <seealso cref="IVectorTraits.Widen(Vector{byte}, out Vector{ushort}, out Vector{ushort})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> Lower, Vector<ushort> Upper) Widen(Vector<byte> source) {
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector{T}"/> into two <seealso cref="Vector{T}"/> instances - Generic version (将一个 <seealso cref="Vector{T}"/> 扩宽为两个 <seealso cref="Vector{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩宽向量).</returns>
        /// <seealso cref="Vector.Widen(Vector{short}, out Vector{int}, out Vector{int})" />
        /// <seealso cref="IVectorTraits.Widen(Vector{short}, out Vector{int}, out Vector{int})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> Lower, Vector<int> Upper) Widen(Vector<short> source) {
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector{T}"/> into two <seealso cref="Vector{T}"/> instances - Generic version (将一个 <seealso cref="Vector{T}"/> 扩宽为两个 <seealso cref="Vector{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩宽向量).</returns>
        /// <seealso cref="Vector.Widen(Vector{ushort}, out Vector{uint}, out Vector{uint})" />
        /// <seealso cref="IVectorTraits.Widen(Vector{ushort}, out Vector{uint}, out Vector{uint})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> Lower, Vector<uint> Upper) Widen(Vector<ushort> source) {
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector{T}"/> into two <seealso cref="Vector{T}"/> instances - Generic version (将一个 <seealso cref="Vector{T}"/> 扩宽为两个 <seealso cref="Vector{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩宽向量).</returns>
        /// <seealso cref="Vector.Widen(Vector{int}, out Vector{long}, out Vector{long})" />
        /// <seealso cref="IVectorTraits.Widen(Vector{int}, out Vector{long}, out Vector{long})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> Lower, Vector<long> Upper) Widen(Vector<int> source) {
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector{T}"/> into two <seealso cref="Vector{T}"/> instances - Generic version (将一个 <seealso cref="Vector{T}"/> 扩宽为两个 <seealso cref="Vector{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩宽向量).</returns>
        /// <seealso cref="Vector.Widen(Vector{uint}, out Vector{ulong}, out Vector{ulong})" />
        /// <seealso cref="IVectorTraits.Widen(Vector{uint}, out Vector{ulong}, out Vector{ulong})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> Lower, Vector<ulong> Upper) Widen(Vector<uint> source) {
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector{T}"/> into two <seealso cref="Vector{T}"/> instances - Generic version (将一个 <seealso cref="Vector{T}"/> 扩宽为两个 <seealso cref="Vector{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        /// <typeparam name="TOut">The element type of the output parameter (输出参数的元素类型).</typeparam>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <param name="lower">When this method returns, contains the widened elements from lower indices in the source vector (当此方法返回时，包含源向量中来自较低下标的扩宽元素).</param>
        /// <param name="upper">When this method returns, contains the widened elements from upper indices in the source vector (当此方法返回时，包含源向量中来自较高下标的扩宽元素).</param>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="T"/>, <typeparamref name="TOut"/>) are not supported.</exception>
        /// <seealso cref="Vector.Widen(Vector{float}, out Vector{double}, out Vector{double})" />
        /// <seealso cref="IVectorTraits.Widen(Vector{float}, out Vector{double}, out Vector{double})" />
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

    }
}
