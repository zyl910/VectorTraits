using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Zyl.VectorTraits.Impl.Util {

    /// <summary>
    /// Unsafe's extended utility functions .
    /// </summary>
    /// <seealso cref="Unsafe"/>
    /// <seealso cref="MemoryMarshal"/>
    public static class UnsafeEx {
 
        // == MemoryMarshal ==

        /// <summary>
        /// Returns a reference to the element of the read-only span at index 0 (返回只读跨度在索引0处的引用).
        /// </summary>
        /// <typeparam name="T">The type of items in the span (跨度中的元素的类型).</typeparam>
        /// <param name="span">The read-only span from which the reference is retrieved (用于检索引用的只读跨度).</param>
        /// <returns>A reference to the element at index 0 (对索引为 0 处元素的引用).</returns>
        /// <seealso cref="MemoryMarshal.GetReference{T}(ReadOnlySpan{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref T GetReference<T>(ReadOnlySpan<T> span) {
#if (NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER)
            return ref MemoryMarshal.GetReference<T>(span);
#else
            return ref Unsafe.AsRef(span.GetPinnableReference());
#endif // NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        }

        /// <summary>
        /// Returns a reference to the element of the span at index 0 (返回跨度在索引0处的引用).
        /// </summary>
        /// <typeparam name="T">The type of items in the span (跨度中的元素的类型).</typeparam>
        /// <param name="span">The span from which the reference is retrieved(用于检索引用的跨度).</param>
        /// <returns>A reference to the element at index 0 (对索引为 0 处元素的引用).</returns>
        /// <seealso cref="MemoryMarshal.GetReference{T}(Span{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref T GetReference<T>(Span<T> span) {
#if (NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER)
            return ref MemoryMarshal.GetReference<T>(span);
#else
            return ref span.GetPinnableReference();
#endif // NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        }
 
        // == Unsafe ==

    }

}
