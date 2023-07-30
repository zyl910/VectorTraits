using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Zyl.VectorTraits.Impl.Util {

    /// <summary>
    /// Unsafe's utility functions (<see cref="Unsafe"/> 的工具函数) .
    /// </summary>
    /// <seealso cref="Unsafe"/>
    /// <seealso cref="MemoryMarshal"/>
    public static class UnsafeUtil {

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
            return ref MemoryMarshal.GetReference<T>(span);
//#if (NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER)
//#else
//            return ref Unsafe.AsRef(span.GetPinnableReference());
//#endif // NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
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
            return ref MemoryMarshal.GetReference<T>(span);
//#if (NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER)
//#else
//            return ref span.GetPinnableReference();
//#endif // NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        }

        // == Unsafe ==

        /// <summary>
        /// Bypasses definite assignment rules for a given reference (使给定引用, 绕过明确赋值规则).
        /// </summary>
        /// <typeparam name="T">The type of the reference (引用的类型).</typeparam>
        /// <param name="value">The reference whose initialization should be skipped (应跳过其初始化的引用).</param>
        /// <seealso cref="Unsafe.SkipInit{T}(out T)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SkipInit<T>(out T value) {
#if NET5_0_OR_GREATER
            Unsafe.SkipInit(out value);
#else
#pragma warning disable CS8601 // Possible null reference assignment.
            value = default;
#pragma warning restore CS8601 // Possible null reference assignment.
#endif // NET5_0_OR_GREATER
        }

        // == My ==

        /// <summary>
        /// Get a reference to an array item, and bypass the array bounds check if possible (获取数组项目的引用, 并尽可能绕过数组边界检查).
        /// </summary>
        /// <typeparam name="T">Type of array item (数组项目的类型).</typeparam>
        /// <param name="array">Source array (源数组).</param>
        /// <param name="index">The item index (项目的索引).</param>
        /// <returns>Return a reference to an array item (返回数组项目的引用).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref T UncheckGetItemReference<T>(T[] array, int index) {
#if NET5_0_OR_GREATER
            ref var data = ref MemoryMarshal.GetArrayDataReference(array);
            return ref Unsafe.Add(ref data, index);
#else
            return ref array[index];
#endif // NET5_0_OR_GREATER
        }

        /// <summary>
        /// Get a reference to an array item, and bypass the array bounds check if possible (获取数组项目的引用, 并尽可能绕过数组边界检查).
        /// </summary>
        /// <typeparam name="T">Type of array item (数组项目的类型).</typeparam>
        /// <param name="array">Source array (源数组).</param>
        /// <param name="index">The item index (项目的索引).</param>
        /// <returns>Return a reference to an array item (返回数组项目的引用).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref T UncheckGetItemReference<T>(T[] array, nint index) {
#if NET5_0_OR_GREATER
            ref var data = ref MemoryMarshal.GetArrayDataReference(array);
            return ref Unsafe.Add(ref data, index);
#else
            return ref array[index];
#endif // NET5_0_OR_GREATER
        }

        /// <summary>
        /// Get a reference to an array item, and bypass the array bounds check if possible (获取数组项目的引用, 并尽可能绕过数组边界检查).
        /// </summary>
        /// <typeparam name="T">Type of array item (数组项目的类型).</typeparam>
        /// <param name="array">Source array (源数组).</param>
        /// <param name="index">The item index (项目的索引).</param>
        /// <param name="indexMask">The index mask. When bypassing the array range check, index will do an `and` operation with this parameter (索引的掩码. 当绕过数组范围检查时, index会与本参数做 and运算).</param>
        /// <returns>Return a reference to an array item (返回数组项目的引用).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref T UncheckGetItemReference<T>(T[] array, int index, int indexMask) {
#if NET5_0_OR_GREATER
            ref var data = ref MemoryMarshal.GetArrayDataReference(array);
            return ref Unsafe.Add(ref data, indexMask & index);
#else
            return ref array[index];
#endif // NET5_0_OR_GREATER
        }

        /// <summary>
        /// Get a reference to an array item, and bypass the array bounds check if possible (获取数组项目的引用, 并尽可能绕过数组边界检查).
        /// </summary>
        /// <typeparam name="T">Type of array item (数组项目的类型).</typeparam>
        /// <param name="array">Source array (源数组).</param>
        /// <param name="index">The item index (项目的索引).</param>
        /// <param name="indexMask">The index mask. When bypassing the array range check, index will do an `and` operation with this parameter (索引的掩码. 当绕过数组范围检查时, index会与本参数做 and运算).</param>
        /// <returns>Return a reference to an array item (返回数组项目的引用).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref T UncheckGetItemReference<T>(T[] array, nint index, nint indexMask) {
#if NET5_0_OR_GREATER
            ref var data = ref MemoryMarshal.GetArrayDataReference(array);
            return ref Unsafe.Add(ref data, indexMask & index);
#else
            return ref array[index];
#endif // NET5_0_OR_GREATER
        }

    }

}
