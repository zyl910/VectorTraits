using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits {
    static partial class Vector256s {

        private static readonly string FORMAT_TYPE_NOT_SUPPORTED_2 = Vector256Generic.FORMAT_TYPE_NOT_SUPPORTED_2;

#if NETCOREAPP3_0_OR_GREATER

        /// <summary>
        /// Widens a <seealso cref="Vector256{T}"/> into two <seealso cref="Vector256{T}"/> instances - Generic version (将一个 <seealso cref="Vector256{T}"/> 扩大为两个 <seealso cref="Vector256{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩大其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩大向量).</returns>
        /// <seealso cref="Vector256.Widen(Vector256{float})" />
        /// <seealso cref="IWVectorTraits256.Widen(Vector256{float}, out Vector256{double}, out Vector256{double})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<double> Lower, Vector256<double> Upper) Widen(Vector256<float> source) {
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector256{T}"/> into two <seealso cref="Vector256{T}"/> instances - Generic version (将一个 <seealso cref="Vector256{T}"/> 扩大为两个 <seealso cref="Vector256{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩大其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩大向量).</returns>
        /// <seealso cref="Vector256.Widen(Vector256{sbyte})" />
        /// <seealso cref="IWVectorTraits256.Widen(Vector256{sbyte}, out Vector256{short}, out Vector256{short})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> Lower, Vector256<short> Upper) Widen(Vector256<sbyte> source) {
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector256{T}"/> into two <seealso cref="Vector256{T}"/> instances - Generic version (将一个 <seealso cref="Vector256{T}"/> 扩大为两个 <seealso cref="Vector256{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩大其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩大向量).</returns>
        /// <seealso cref="Vector256.Widen(Vector256{byte})" />
        /// <seealso cref="IWVectorTraits256.Widen(Vector256{byte}, out Vector256{ushort}, out Vector256{ushort})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ushort> Lower, Vector256<ushort> Upper) Widen(Vector256<byte> source) {
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector256{T}"/> into two <seealso cref="Vector256{T}"/> instances - Generic version (将一个 <seealso cref="Vector256{T}"/> 扩大为两个 <seealso cref="Vector256{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩大其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩大向量).</returns>
        /// <seealso cref="Vector256.Widen(Vector256{short})" />
        /// <seealso cref="IWVectorTraits256.Widen(Vector256{short}, out Vector256{int}, out Vector256{int})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> Lower, Vector256<int> Upper) Widen(Vector256<short> source) {
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector256{T}"/> into two <seealso cref="Vector256{T}"/> instances - Generic version (将一个 <seealso cref="Vector256{T}"/> 扩大为两个 <seealso cref="Vector256{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩大其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩大向量).</returns>
        /// <seealso cref="Vector256.Widen(Vector256{ushort})" />
        /// <seealso cref="IWVectorTraits256.Widen(Vector256{ushort}, out Vector256{uint}, out Vector256{uint})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<uint> Lower, Vector256<uint> Upper) Widen(Vector256<ushort> source) {
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector256{T}"/> into two <seealso cref="Vector256{T}"/> instances - Generic version (将一个 <seealso cref="Vector256{T}"/> 扩大为两个 <seealso cref="Vector256{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩大其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩大向量).</returns>
        /// <seealso cref="Vector256.Widen(Vector256{int})" />
        /// <seealso cref="IWVectorTraits256.Widen(Vector256{int}, out Vector256{long}, out Vector256{long})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> Lower, Vector256<long> Upper) Widen(Vector256<int> source) {
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector256{T}"/> into two <seealso cref="Vector256{T}"/> instances - Generic version (将一个 <seealso cref="Vector256{T}"/> 扩大为两个 <seealso cref="Vector256{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩大其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩大向量).</returns>
        /// <seealso cref="Vector256.Widen(Vector256{uint})" />
        /// <seealso cref="IWVectorTraits256.Widen(Vector256{uint}, out Vector256{ulong}, out Vector256{ulong})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ulong> Lower, Vector256<ulong> Upper) Widen(Vector256<uint> source) {
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector256Generic.Widen{T, TOut}(Vector256{T}, out Vector256{TOut}, out Vector256{TOut})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void Widen<T, TOut>(Vector256<T> source, out Vector256<TOut> lower, out Vector256<TOut> upper)
                 where T : struct where TOut : struct {
            if (typeof(float) == typeof(T) && typeof(double) == typeof(TOut)) {
                (Vector256<double> a, Vector256<double> b) = Widen((Vector256<float>)(object)source);
                lower = (Vector256<TOut>)(object)a;
                upper = (Vector256<TOut>)(object)b;
            } else if (typeof(sbyte) == typeof(T) && typeof(short) == typeof(TOut)) {
                (Vector256<short> a, Vector256<short> b) = Widen((Vector256<sbyte>)(object)source);
                lower = (Vector256<TOut>)(object)a;
                upper = (Vector256<TOut>)(object)b;
            } else if (typeof(byte) == typeof(T) && typeof(ushort) == typeof(TOut)) {
                (Vector256<ushort> a, Vector256<ushort> b) = Widen((Vector256<byte>)(object)source);
                lower = (Vector256<TOut>)(object)a;
                upper = (Vector256<TOut>)(object)b;
            } else if (typeof(short) == typeof(T) && typeof(int) == typeof(TOut)) {
                (Vector256<int> a, Vector256<int> b) = Widen((Vector256<short>)(object)source);
                lower = (Vector256<TOut>)(object)a;
                upper = (Vector256<TOut>)(object)b;
            } else if (typeof(ushort) == typeof(T) && typeof(uint) == typeof(TOut)) {
                (Vector256<uint> a, Vector256<uint> b) = Widen((Vector256<ushort>)(object)source);
                lower = (Vector256<TOut>)(object)a;
                upper = (Vector256<TOut>)(object)b;
            } else if (typeof(int) == typeof(T) && typeof(long) == typeof(TOut)) {
                (Vector256<long> a, Vector256<long> b) = Widen((Vector256<int>)(object)source);
                lower = (Vector256<TOut>)(object)a;
                upper = (Vector256<TOut>)(object)b;
            } else if (typeof(uint) == typeof(T) && typeof(ulong) == typeof(TOut)) {
                (Vector256<ulong> a, Vector256<ulong> b) = Widen((Vector256<uint>)(object)source);
                lower = (Vector256<TOut>)(object)a;
                upper = (Vector256<TOut>)(object)b;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TOut).Name));
            }
        }

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
