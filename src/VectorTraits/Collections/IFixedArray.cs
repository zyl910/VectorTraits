using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Zyl.VectorTraits.Collections {
    /// <summary>
    /// An array of fixed capacity interface. It has no bounds checking to avoid performance loss. Span only supports stack memory, and it supports static memory (固定容量数组的接口. 它没有边界检查, 可避免性能损失. Span 仅支持栈内存, 而它支持静态内存).
    /// </summary>
    /// <typeparam name="T">The array element type (数组中的元素的类型).</typeparam>
    public interface IFixedArray<T> : IEnumerable<T>, IEnumerable, IReadOnlyCollection<T> {
        /// <summary>
        /// Gets or sets the element at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the element to get or set.</param>
        /// <returns>The element at the specified index.</returns>
        T this[int index] { get; set; }
    }
}
