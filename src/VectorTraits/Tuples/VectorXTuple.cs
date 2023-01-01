using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zyl.VectorTraits.Tuples {
    /// <summary>
    /// Provides static methods for creating <see cref="Vector"/> tuples (提供用于创建向量元组的静态方法).
    /// </summary>
    public static partial class VectorXTuple {

        /// <summary>
        /// Creates a new vector tuple with 2 components (创建含有 2 个组件的新向量元组).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="item1">The value of the 1st component (第1个组件的值).</param>
        /// <param name="item2">The value of the 2nd component (第2个组件的值).</param>
        /// <returns>A vector tuple with 2 components (具有2个组件的向量元组).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX2<T> Create<T>(Vector<T> item1, Vector<T> item2) where T : struct {
            return new VectorX2<T>((item1, item2));
        }

        /// <summary>
        /// Creates a new vector tuple with 2 components by ValueTuple (根据值元组, 创建含有 2 个组件的新向量元组).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="val">The value (值).</param>
        /// <returns>A vector tuple with 2 components (具有2个组件的向量元组).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VectorX2<T> Create<T>((Vector<T>, Vector<T>) val) where T : struct {
            return new VectorX2<T>(val);
        }

    }
}
