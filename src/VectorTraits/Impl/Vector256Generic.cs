using System;
using System.Collections.Generic;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using System.Text;

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// Generic style methods for <see cref="Vector256"/> (<see cref="Vector256"/> 的泛型风格方法). 
    /// </summary>
    public static class Vector256Generic {

        /// <summary>
        /// Message format of NOT_SUPPORTED in case of 2 types (2个类型时，NOT_SUPPORTED的消息格式).
        /// </summary>
        public static readonly string FORMAT_TYPE_NOT_SUPPORTED_2 = "These element types({0}, {1}) are not supported!";

#if NETCOREAPP3_0_OR_GREATER

#if NET7_0_OR_GREATER

        /// <summary>
        /// Widens a <seealso cref="Vector256{T}"/> into two <seealso cref="Vector256{T}"/> instances - Generic version (将一个 <seealso cref="Vector256{T}"/> 扩大为两个 <seealso cref="Vector256{T}"/> 实例 - 泛型版).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        /// <typeparam name="TOut">The element type of the output parameter (输出参数的元素类型).</typeparam>
        /// <param name="source">The vector whose elements are to be widened (要扩大其元素的向量).</param>
        /// <param name="lower">When this method returns, contains the widened elements from lower indices in the source vector (当此方法返回时，包含源向量中来自较低下标的扩大元素).</param>
        /// <param name="upper">When this method returns, contains the widened elements from upper indices in the source vector (当此方法返回时，包含源向量中来自较高下标的扩大元素).</param>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="T"/>, <typeparamref name="TOut"/>) are not supported.</exception>
        /// <seealso cref="Vector256.Widen(Vector256{float})" />
        /// <seealso cref="IWVectorTraits256.Widen(Vector256{float}, out Vector256{double}, out Vector256{double})" />
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void Widen<T, TOut>(Vector256<T> source, out Vector256<TOut> lower, out Vector256<TOut> upper)
                 where T : struct where TOut : struct {
            if (typeof(float) == typeof(T) && typeof(double) == typeof(TOut)) {
                (Vector256<double> a, Vector256<double> b) = Vector256.Widen((Vector256<float>)(object)source);
                lower = (Vector256<TOut>)(object)a;
                upper = (Vector256<TOut>)(object)b;
            } else if (typeof(sbyte) == typeof(T) && typeof(short) == typeof(TOut)) {
                (Vector256<short> a, Vector256<short> b) = Vector256.Widen((Vector256<sbyte>)(object)source);
                lower = (Vector256<TOut>)(object)a;
                upper = (Vector256<TOut>)(object)b;
            } else if (typeof(byte) == typeof(T) && typeof(ushort) == typeof(TOut)) {
                (Vector256<ushort> a, Vector256<ushort> b) = Vector256.Widen((Vector256<byte>)(object)source);
                lower = (Vector256<TOut>)(object)a;
                upper = (Vector256<TOut>)(object)b;
            } else if (typeof(short) == typeof(T) && typeof(int) == typeof(TOut)) {
                (Vector256<int> a, Vector256<int> b) = Vector256.Widen((Vector256<short>)(object)source);
                lower = (Vector256<TOut>)(object)a;
                upper = (Vector256<TOut>)(object)b;
            } else if (typeof(ushort) == typeof(T) && typeof(uint) == typeof(TOut)) {
                (Vector256<uint> a, Vector256<uint> b) = Vector256.Widen((Vector256<ushort>)(object)source);
                lower = (Vector256<TOut>)(object)a;
                upper = (Vector256<TOut>)(object)b;
            } else if (typeof(int) == typeof(T) && typeof(long) == typeof(TOut)) {
                (Vector256<long> a, Vector256<long> b) = Vector256.Widen((Vector256<int>)(object)source);
                lower = (Vector256<TOut>)(object)a;
                upper = (Vector256<TOut>)(object)b;
            } else if (typeof(uint) == typeof(T) && typeof(ulong) == typeof(TOut)) {
                (Vector256<ulong> a, Vector256<ulong> b) = Vector256.Widen((Vector256<uint>)(object)source);
                lower = (Vector256<TOut>)(object)a;
                upper = (Vector256<TOut>)(object)b;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TOut).Name));
            }
        }

#endif // NET7_0_OR_GREATER

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
