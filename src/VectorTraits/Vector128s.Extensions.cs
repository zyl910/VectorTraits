using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits {
    static partial class Vector128s {

        private static readonly string FORMAT_TYPE_NOT_SUPPORTED_2 = Vector128Generic.FORMAT_TYPE_NOT_SUPPORTED_2;

#if NETCOREAPP3_0_OR_GREATER

        /// <summary>
        /// Widens a <seealso cref="Vector128{T}"/> into two <seealso cref="Vector128{T}"/> instances - Generic version (将一个 <seealso cref="Vector128{T}"/> 扩宽为两个 <seealso cref="Vector128{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩宽向量).</returns>
        /// <seealso cref="Vector128.Widen(Vector128{float})" />
        /// <seealso cref="IWVectorTraits128.Widen(Vector128{float}, out Vector128{double}, out Vector128{double})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<double> Lower, Vector128<double> Upper) Widen(Vector128<float> source) {
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector128{T}"/> into two <seealso cref="Vector128{T}"/> instances - Generic version (将一个 <seealso cref="Vector128{T}"/> 扩宽为两个 <seealso cref="Vector128{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩宽向量).</returns>
        /// <seealso cref="Vector128.Widen(Vector128{sbyte})" />
        /// <seealso cref="IWVectorTraits128.Widen(Vector128{sbyte}, out Vector128{short}, out Vector128{short})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> Lower, Vector128<short> Upper) Widen(Vector128<sbyte> source) {
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector128{T}"/> into two <seealso cref="Vector128{T}"/> instances - Generic version (将一个 <seealso cref="Vector128{T}"/> 扩宽为两个 <seealso cref="Vector128{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩宽向量).</returns>
        /// <seealso cref="Vector128.Widen(Vector128{byte})" />
        /// <seealso cref="IWVectorTraits128.Widen(Vector128{byte}, out Vector128{ushort}, out Vector128{ushort})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> Lower, Vector128<ushort> Upper) Widen(Vector128<byte> source) {
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector128{T}"/> into two <seealso cref="Vector128{T}"/> instances - Generic version (将一个 <seealso cref="Vector128{T}"/> 扩宽为两个 <seealso cref="Vector128{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩宽向量).</returns>
        /// <seealso cref="Vector128.Widen(Vector128{short})" />
        /// <seealso cref="IWVectorTraits128.Widen(Vector128{short}, out Vector128{int}, out Vector128{int})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> Lower, Vector128<int> Upper) Widen(Vector128<short> source) {
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector128{T}"/> into two <seealso cref="Vector128{T}"/> instances - Generic version (将一个 <seealso cref="Vector128{T}"/> 扩宽为两个 <seealso cref="Vector128{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩宽向量).</returns>
        /// <seealso cref="Vector128.Widen(Vector128{ushort})" />
        /// <seealso cref="IWVectorTraits128.Widen(Vector128{ushort}, out Vector128{uint}, out Vector128{uint})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> Lower, Vector128<uint> Upper) Widen(Vector128<ushort> source) {
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector128{T}"/> into two <seealso cref="Vector128{T}"/> instances - Generic version (将一个 <seealso cref="Vector128{T}"/> 扩宽为两个 <seealso cref="Vector128{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩宽向量).</returns>
        /// <seealso cref="Vector128.Widen(Vector128{int})" />
        /// <seealso cref="IWVectorTraits128.Widen(Vector128{int}, out Vector128{long}, out Vector128{long})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> Lower, Vector128<long> Upper) Widen(Vector128<int> source) {
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Widens a <seealso cref="Vector128{T}"/> into two <seealso cref="Vector128{T}"/> instances - Generic version (将一个 <seealso cref="Vector128{T}"/> 扩宽为两个 <seealso cref="Vector128{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <returns>A pair of vectors that contain the widened lower and upper halves of <paramref name="source" /> (包含 <paramref name="source" /> 的下半部和上半部的一对扩宽向量).</returns>
        /// <seealso cref="Vector128.Widen(Vector128{uint})" />
        /// <seealso cref="IWVectorTraits128.Widen(Vector128{uint}, out Vector128{ulong}, out Vector128{ulong})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> Lower, Vector128<ulong> Upper) Widen(Vector128<uint> source) {
            Widen(source, out var a, out var b);
            return (a, b);
        }

        /// <inheritdoc cref="Vector128Generic.Widen{T, TOut}(Vector128{T}, out Vector128{TOut}, out Vector128{TOut})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void Widen<T, TOut>(Vector128<T> source, out Vector128<TOut> lower, out Vector128<TOut> upper)
                 where T : struct where TOut : struct {
            if (typeof(float) == typeof(T) && typeof(double) == typeof(TOut)) {
                (Vector128<double> a, Vector128<double> b) = Widen((Vector128<float>)(object)source);
                lower = (Vector128<TOut>)(object)a;
                upper = (Vector128<TOut>)(object)b;
            } else if (typeof(sbyte) == typeof(T) && typeof(short) == typeof(TOut)) {
                (Vector128<short> a, Vector128<short> b) = Widen((Vector128<sbyte>)(object)source);
                lower = (Vector128<TOut>)(object)a;
                upper = (Vector128<TOut>)(object)b;
            } else if (typeof(byte) == typeof(T) && typeof(ushort) == typeof(TOut)) {
                (Vector128<ushort> a, Vector128<ushort> b) = Widen((Vector128<byte>)(object)source);
                lower = (Vector128<TOut>)(object)a;
                upper = (Vector128<TOut>)(object)b;
            } else if (typeof(short) == typeof(T) && typeof(int) == typeof(TOut)) {
                (Vector128<int> a, Vector128<int> b) = Widen((Vector128<short>)(object)source);
                lower = (Vector128<TOut>)(object)a;
                upper = (Vector128<TOut>)(object)b;
            } else if (typeof(ushort) == typeof(T) && typeof(uint) == typeof(TOut)) {
                (Vector128<uint> a, Vector128<uint> b) = Widen((Vector128<ushort>)(object)source);
                lower = (Vector128<TOut>)(object)a;
                upper = (Vector128<TOut>)(object)b;
            } else if (typeof(int) == typeof(T) && typeof(long) == typeof(TOut)) {
                (Vector128<long> a, Vector128<long> b) = Widen((Vector128<int>)(object)source);
                lower = (Vector128<TOut>)(object)a;
                upper = (Vector128<TOut>)(object)b;
            } else if (typeof(uint) == typeof(T) && typeof(ulong) == typeof(TOut)) {
                (Vector128<ulong> a, Vector128<ulong> b) = Widen((Vector128<uint>)(object)source);
                lower = (Vector128<TOut>)(object)a;
                upper = (Vector128<TOut>)(object)b;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TOut).Name));
            }
        }

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
