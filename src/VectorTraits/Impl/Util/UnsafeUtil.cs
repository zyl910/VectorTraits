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

        /// <summary>
        /// Returns a reference to the 0th element of array. If the array is empty, returns a reference to where the 0th element would have been stored. Such a reference may be used for pinning but must never be dereferenced.
        /// </summary>
        /// <typeparam name="T">The type of the array elements.</typeparam>
        /// <param name="array">The array to analyze.</param>
        /// <returns>Reference to the 0th element in array.</returns>
        /// <exception cref="NullReferenceException">array is null.</exception>
        /// <seealso cref="MemoryMarshal.GetArrayDataReference{T}(T[])"/>
        public static ref T GetArrayDataReference<T>(T[] array) {
#if NET5_0_OR_GREATER
            return ref MemoryMarshal.GetArrayDataReference(array);
#else
            return ref array[0];
#endif // NET5_0_OR_GREATER
        }

        // == Unsafe ==

#if NET5_0_OR_GREATER
#else
#if UNSAFE
#else
        private static decimal _fakeNull = default;
#endif // UNSAFE
#endif // NET5_0_OR_GREATER

        /// <summary>
        /// Reinterprets the given value of type <typeparamref name="TFrom" /> as a value of type <typeparamref name="TTo" />.
        /// </summary>
        /// <exception cref="NotSupportedException">The size of <typeparamref name="TFrom" /> and <typeparamref name="TTo" /> are not the same.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TTo BitCast<TFrom, TTo>(TFrom source)
            where TFrom : struct
            where TTo : struct {
#if NET8_0_OR_GREATER
            return Unsafe.BitCast<TFrom, TTo>(source);
#else
            if (Unsafe.SizeOf<TFrom>() != Unsafe.SizeOf<TTo>()) {
                throw new NotSupportedException();
            }
            return Unsafe.ReadUnaligned<TTo>(ref Unsafe.As<TFrom, byte>(ref source));
#endif // NET8_0_OR_GREATER
        }

        /// <summary>
        /// Determines if a given managed pointer to a value of type <typeparamref name="T"/> is a null reference (确定指向类型的 <typeparamref name="T"/> 值的给定托管指针是否为 null 引用).
        /// </summary>
        /// <typeparam name="T">The elemental type of the managed pointer (托管指针的元素类型).</typeparam>
        /// <param name="source">The managed pointer to check (指向检查的托管指针).</param>
        /// <returns><c>true</c> if <paramref name="source"/> is a null reference; otherwise, <c>false</c>.</returns>
        /// <seealso cref="Unsafe.IsNullRef{T}(ref readonly T)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNullRef<T>(ref T source) {
#if NET5_0_OR_GREATER
            return Unsafe.IsNullRef(ref source);
#else
            return Unsafe.AreSame(ref source, ref NullRef<T>());
#endif // NET5_0_OR_GREATER
        }

        /// <summary>
        /// Returns a reference to a value of type <typeparamref name="T"/> that is a null reference (返回指向 <typeparamref name="T"/> 类型的值的 null 托管指针).
        /// </summary>
        /// <typeparam name="T">The elemental type of the managed pointer (托管指针的元素类型).</typeparam>
        /// <returns>A reference to a value of type <typeparamref name="T"/> that is a null reference (指向 <typeparamref name="T"/> 类型的值的 null 托管指针).</returns>
        /// <seealso cref="Unsafe.NullRef{T}"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref T NullRef<T>() {
#if NET5_0_OR_GREATER
            return ref Unsafe.NullRef<T>();
#else
#if UNSAFE
            unsafe {
                void* ptr = (void*)0;
                return ref Unsafe.AsRef<T>(ptr);
            }
#else
            //nint = new IntPtr(Unsafe.AsPointer(ref_fakeNull)); // Error CS0214	Pointers and fixed size buffers may only be used in an unsafe context
            return ref Unsafe.As<decimal, T>(ref _fakeNull); // fallback.
#endif // UNSAFE
#endif // NET5_0_OR_GREATER
        }

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
        /// Decrement to the given managed pointer (向给定的托管指针递减).
        /// Mnemonic: <c>--p</c>.
        /// </summary>
        /// <typeparam name="T">The elemental type of the managed pointer (托管指针的元素类型).</typeparam>
        /// <param name="source">The managed pointer to decrement to (要向其递减的托管指针).</param>
        /// <returns>A new managed pointer that reflects the decrement to the <paramref name="source"/> pointer (一个新的托管指针，是源指针递减的结果).</returns>
        /// <seealso cref="Unsafe.Subtract{T}(ref T, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref T Dec<T>(ref T source) {
            return ref Unsafe.Subtract(ref source, 1);
        }

        /// <summary>
        /// Determines byte offset from origin to target from the given references (确定给定托管指针从源到目标的字节偏移量).
        /// </summary>
        /// <typeparam name="T">The elemental type of the managed pointer (托管指针的元素类型).</typeparam>
        /// <param name="origin">The reference to origin (指向源的托管指针).</param>
        /// <param name="target">The reference to target (指向目标的托管指针).</param>
        /// <returns>The offset from origin to target (从源到目标的偏移量). i.e. <c>target - origin</c>.</returns>
        /// <seealso cref="Unsafe.ByteOffset{T}(ref T, ref T)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static nint GetOffset<T>(ref T origin, ref T target) {
            nint byteOffset = Unsafe.ByteOffset(ref origin, ref target);
            nint rt = byteOffset / Unsafe.SizeOf<T>();
            return rt;
        }

        /// <summary>
        /// Increment to the given managed pointer (向给定的托管指针递增).
        /// Mnemonic: <c>++p</c>.
        /// </summary>
        /// <typeparam name="T">The elemental type of the managed pointer (托管指针的元素类型).</typeparam>
        /// <param name="source">The managed pointer to increment to (要向其递增的托管指针).</param>
        /// <returns>A new managed pointer that reflects the increment to the <paramref name="source"/> pointer (一个新的托管指针，是源指针递增的结果).</returns>
        /// <seealso cref="Unsafe.Add{T}(ref T, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref T Inc<T>(ref T source) {
            return ref Unsafe.Add(ref source, 1);
        }

        /// <summary>
        /// Determines whether the memory address referenced by <paramref name="left"/> is greater or equal than the memory address referenced by <paramref name="right"/> (返回一个值，该值指示指定的托管指针是否大于另一个指定的托管指针).
        /// </summary>
        /// <typeparam name="T">The elemental type of the managed pointer (托管指针的元素类型).</typeparam>
        /// <param name="left">The first managed pointer to compare (要比较的第一个托管指针).</param>
        /// <param name="right">The second managed pointer to compare (要比较的第二个托管指针).</param>
        /// <returns><c>true</c> if is greater or equal; otherwise, <c>false</c> (大于等于时返回 <c>true</c>; 否则返回 <c>false</c>).</returns>
        /// <remarks>
        /// This check is conceptually similar to "(void*)(&amp;left) &gt;= (void*)(&amp;right)".
        /// </remarks>
        /// <seealso cref="Unsafe.IsAddressLessThan{T}(ref readonly T, ref readonly T)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsAddressGreaterThanOrEqual<T>(ref T left,ref T right) {
            return !Unsafe.IsAddressLessThan(ref left, ref right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <summary>
        /// Determines whether the memory address referenced by <paramref name="left"/> is greater or equal than the memory address referenced by <paramref name="right"/> (返回一个值，该值指示指定的托管指针是否大于另一个指定的托管指针).
        /// </summary>
        /// <typeparam name="T">The elemental type of the managed pointer (托管指针的元素类型).</typeparam>
        /// <param name="left">The first managed pointer to compare (要比较的第一个托管指针).</param>
        /// <param name="right">The second managed pointer to compare (要比较的第二个托管指针).</param>
        /// <param name="rightOffset">Offset of the second managed pointer (第二个托管指针的偏移量).</param>
        /// <returns><c>true</c> if is greater or equal; otherwise, <c>false</c> (大于等于时返回 <c>true</c>; 否则返回 <c>false</c>).</returns>
        /// <remarks>
        /// This check is conceptually similar to "(void*)(&amp;left) &gt;= (void*)(&amp;(right+rightOffset))".
        /// </remarks>
        /// <seealso cref="Unsafe.IsAddressGreaterThan{T}(ref readonly T, ref readonly T)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsAddressGreaterThanOrEqual<T>(ref T left, ref T right, int rightOffset) {
            return IsAddressGreaterThanOrEqual(ref left, ref Unsafe.Add(ref right, rightOffset));
        }

        /// <summary>
        /// Determines whether the memory address referenced by <paramref name="left"/> is less or equal than the memory address referenced by <paramref name="right"/> (返回一个值，该值指示指定的托管指针是否小于另一个指定的托管指针).
        /// </summary>
        /// <typeparam name="T">The elemental type of the managed pointer (托管指针的元素类型).</typeparam>
        /// <param name="left">The first managed pointer to compare (要比较的第一个托管指针).</param>
        /// <param name="right">The second managed pointer to compare (要比较的第二个托管指针).</param>
        /// <returns><c>true</c> if is less or equal; otherwise, <c>false</c> (小于等于时返回 <c>true</c>; 否则返回 <c>false</c>).</returns>
        /// <remarks>
        /// This check is conceptually similar to "(void*)(&amp;left) &lt;= (void*)(&amp;right)".
        /// </remarks>
        /// <seealso cref="Unsafe.IsAddressGreaterThan{T}(ref readonly T, ref readonly T)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsAddressLessThaOrEqual<T>(ref T left, ref T right) {
            return !Unsafe.IsAddressGreaterThan(ref left, ref right);
        }

        /// <summary>
        /// Pre-decrement to the given managed pointer. It also returns the value pointed to after the decrement (向给定的托管指针前置递减. 还会返回递减之后所指向的值).
        /// Mnemonic: <c>afterValue = --p</c>.
        /// </summary>
        /// <typeparam name="T">The elemental type of the managed pointer (托管指针的元素类型).</typeparam>
        /// <param name="source">The managed pointer to Pre-decrement to (要向其递减的托管指针).</param>
        /// <param name="afterValue">Returns the value pointed to after the decrement (返回递减后所指向的值).</param>
        /// <returns>A new managed pointer that reflects the decrement to the <paramref name="source"/> pointer (一个新的托管指针，是源指针递减的结果).</returns>
        /// <seealso cref="Unsafe.Subtract{T}(ref T, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref T PreDec<T>(ref T source, out T afterValue) {
            ref T rt = ref Unsafe.Add(ref source, 1);
            afterValue = rt;
            return ref rt;
        }

        /// <summary>
        /// Pre-increment to the given managed pointer. It also returns the value pointed to after the increment (向给定的托管指针前置递增. 还会返回递增之后所指向的值).
        /// Mnemonic: <c>afterValue = ++p</c>.
        /// </summary>
        /// <typeparam name="T">The elemental type of the managed pointer (托管指针的元素类型).</typeparam>
        /// <param name="source">The managed pointer to Pre-increment to (要向其递增的托管指针).</param>
        /// <param name="afterValue">Returns the value pointed to after the increment (返回递增后所指向的值).</param>
        /// <returns>A new managed pointer that reflects the increment to the <paramref name="source"/> pointer (一个新的托管指针，是源指针递增的结果).</returns>
        /// <seealso cref="Unsafe.Add{T}(ref T, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref T PreInc<T>(ref T source, out T afterValue) {
            ref T rt = ref Unsafe.Add(ref source, 1);
            afterValue = rt;
            return ref rt;
        }

        /// <summary>
        /// Post-decrement to the given managed pointer. It also returns the value pointed to before the decrement (向给定的托管指针后置递减. 还会返回递减之前所指向的值).
        /// Mnemonic: <c>beforeValue = p--</c>.
        /// </summary>
        /// <typeparam name="T">The elemental type of the managed pointer (托管指针的元素类型).</typeparam>
        /// <param name="source">The managed pointer to decrement to (要向其递减的托管指针).</param>
        /// <param name="beforeValue">Returns the value pointed to before the decrement (返回递减前所指向的值).</param>
        /// <returns>A new managed pointer that reflects the decrement to the <paramref name="source"/> pointer (一个新的托管指针，是源指针递减的结果).</returns>
        /// <seealso cref="Unsafe.Subtract{T}(ref T, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref T PostDec<T>(ref T source, out T beforeValue) {
            beforeValue = source;
            return ref Unsafe.Add(ref source, 1);
        }

        /// <summary>
        /// When not equal to the specified value, post-decrement of the given managed pointer. It contains the checkValue parameter (当不与指定值相等时, 向给定的托管指针后置递减. 它含有 checkValue 参数).
        /// Mnemonic: <c>beforeValue = (*p != checkValue) ? *p-- : newValue)</c>.
        /// </summary>
        /// <typeparam name="T">The elemental type of the managed pointer (托管指针的元素类型).</typeparam>
        /// <param name="source">The managed pointer to decrement to (要向其递减的托管指针).</param>
        /// <param name="beforeValue">When not equal to the specified value, returns the value pointed to before the decrement. Otherwise, it returns <paramref name="newValue"/> (当不与指定值相等时, 返回递减前所指向的值. 否则便返回 <paramref name="newValue"/>).</param>
        /// <param name="checkValue">Special values to be check (将进行检查的特殊值).</param>
        /// <param name="newValue">When equal to the specified value, <paramref name="beforeValue"/> returns the new value (当与指定值相等时, <paramref name="beforeValue"/> 会返回这个新值).</param>
        /// <returns>When not equal to the specified value, post-decrement of the given managed pointer. Otherwise, it returns <paramref name="source"/> (当不与指定值相等时, 向给定的托管指针后置递减. 否则便返回 <paramref name="source"/>).</returns>
        /// <seealso cref="Unsafe.Subtract{T}(ref T, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref T PostDecExcept<T>(ref T source, out T beforeValue, T checkValue, T newValue) where T : IEquatable<T> {
            beforeValue = source;
            if (beforeValue.Equals(checkValue)) {
                beforeValue = newValue;
                return ref source;
            }
            return ref Unsafe.Add(ref source, 1);
        }

        /// <summary>
        /// When not equal to the specified value, post-decrement of the given managed pointer (当不与指定值相等时, 向给定的托管指针后置递减).
        /// Mnemonic: <c>beforeValue = (*p != checkValue) ? *p-- : newValue)</c>.
        /// </summary>
        /// <typeparam name="T">The elemental type of the managed pointer (托管指针的元素类型).</typeparam>
        /// <param name="source">The managed pointer to decrement to (要向其递减的托管指针).</param>
        /// <param name="beforeValue">Returns the value pointed to before the decrement (返回递减前所指向的值).</param>
        /// <param name="checkValue">Special values to be check (将进行检查的特殊值).</param>
        /// <returns>When not equal to the specified value, post-decrement of the given managed pointer. Otherwise, it returns <paramref name="source"/> (当不与指定值相等时, 向给定的托管指针后置递减. 否则便返回 <paramref name="source"/>).</returns>
        /// <seealso cref="Unsafe.Subtract{T}(ref T, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref T PostDecExcept<T>(ref T source, out T beforeValue, T checkValue) where T : IEquatable<T> {
            return ref PostDecExcept(ref source, out beforeValue, checkValue, checkValue);
        }

        /// <summary>
        /// When not equal to the zero, post-decrement of the given managed pointer (当不与0相等时, 向给定的托管指针后置递减).
        /// Mnemonic: <c>beforeValue = (*p != 0) ? *p-- : newValue)</c>.
        /// </summary>
        /// <typeparam name="T">The elemental type of the managed pointer (托管指针的元素类型).</typeparam>
        /// <param name="source">The managed pointer to decrement to (要向其递减的托管指针).</param>
        /// <param name="beforeValue">When not equal to the zero, returns the value pointed to before the decrement. Otherwise, it returns <paramref name="newValue"/> (当不与0相等时, 返回递减前所指向的值. 否则便返回 <paramref name="newValue"/>).</param>
        /// <param name="newValue">When equal to the zero, <paramref name="beforeValue"/> returns the new value (当与0相等时, <paramref name="beforeValue"/> 会返回这个新值).</param>
        /// <returns>When not equal to the zero, post-decrement of the given managed pointer. Otherwise, it returns to the <paramref name="source"/> (当不与0相等时, 向给定的托管指针后置递减. 否则便返回 <paramref name="source"/>).</returns>
        /// <seealso cref="Unsafe.Subtract{T}(ref T, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref T PostDecExceptZero<T>(ref T source, out T beforeValue, T newValue = default) where T : struct, IEquatable<T> {
            return ref PostDecExcept(ref source, out beforeValue, default, newValue);
        }

        /// <summary>
        /// Post-increment to the given managed pointer. It also returns the value pointed to before the increment (向给定的托管指针后置递增. 还会返回递增之前所指向的值).
        /// Mnemonic: <c>beforeValue = p++</c>.
        /// </summary>
        /// <typeparam name="T">The elemental type of the managed pointer (托管指针的元素类型).</typeparam>
        /// <param name="source">The managed pointer to increment to (要向其递增的托管指针).</param>
        /// <param name="beforeValue">Returns the value pointed to before the increment (返回递增前所指向的值).</param>
        /// <returns>A new managed pointer that reflects the increment to the <paramref name="source"/> pointer (一个新的托管指针，是源指针递增的结果).</returns>
        /// <seealso cref="Unsafe.Add{T}(ref T, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref T PostInc<T>(ref T source, out T beforeValue) {
            beforeValue = source;
            return ref Unsafe.Add(ref source, 1);
        }

        /// <summary>
        /// When not equal to the specified value, post-increment of the given managed pointer. It contains the checkValue parameter (当不与指定值相等时, 向给定的托管指针后置递增. 它含有 checkValue 参数).
        /// Mnemonic: <c>beforeValue = (*p != checkValue) ? *p++ : newValue)</c>.
        /// </summary>
        /// <typeparam name="T">The elemental type of the managed pointer (托管指针的元素类型).</typeparam>
        /// <param name="source">The managed pointer to increment to (要向其递增的托管指针).</param>
        /// <param name="beforeValue">When not equal to the specified value, returns the value pointed to before the increment. Otherwise, it returns <paramref name="newValue"/> (当不与指定值相等时, 返回递增前所指向的值. 否则便返回 <paramref name="newValue"/>).</param>
        /// <param name="checkValue">Special values to be check (将进行检查的特殊值).</param>
        /// <param name="newValue">When equal to the specified value, <paramref name="beforeValue"/> returns the new value (当与指定值相等时, <paramref name="beforeValue"/> 会返回这个新值).</param>
        /// <returns>When not equal to the specified value, post-increment of the given managed pointer. Otherwise, it returns <paramref name="source"/> (当不与指定值相等时, 向给定的托管指针后置递增. 否则便返回 <paramref name="source"/>).</returns>
        /// <seealso cref="Unsafe.Add{T}(ref T, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref T PostIncExcept<T>(ref T source, out T beforeValue, T checkValue, T newValue) where T : IEquatable<T> {
            beforeValue = source;
            if (beforeValue.Equals(checkValue)) {
                beforeValue = newValue;
                return ref source;
            }
            return ref Unsafe.Add(ref source, 1);
        }

        /// <summary>
        /// When not equal to the specified value, post-increment of the given managed pointer (当不与指定值相等时, 向给定的托管指针后置递增).
        /// Mnemonic: <c>beforeValue = (*p != checkValue) ? *p++ : newValue)</c>.
        /// </summary>
        /// <typeparam name="T">The elemental type of the managed pointer (托管指针的元素类型).</typeparam>
        /// <param name="source">The managed pointer to increment to (要向其递增的托管指针).</param>
        /// <param name="beforeValue">Returns the value pointed to before the increment (返回递增前所指向的值).</param>
        /// <param name="checkValue">Special values to be check (将进行检查的特殊值).</param>
        /// <returns>When not equal to the specified value, post-increment of the given managed pointer. Otherwise, it returns <paramref name="source"/> (当不与指定值相等时, 向给定的托管指针后置递增. 否则便返回 <paramref name="source"/>).</returns>
        /// <seealso cref="Unsafe.Add{T}(ref T, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref T PostIncExcept<T>(ref T source, out T beforeValue, T checkValue) where T : IEquatable<T> {
            return ref PostIncExcept(ref source, out beforeValue, checkValue, checkValue);
        }

        /// <summary>
        /// When not equal to the zero, post-increment of the given managed pointer (当不与0相等时, 向给定的托管指针后置递增).
        /// Mnemonic: <c>beforeValue = (*p != 0) ? *p++ : newValue)</c>.
        /// </summary>
        /// <typeparam name="T">The elemental type of the managed pointer (托管指针的元素类型).</typeparam>
        /// <param name="source">The managed pointer to increment to (要向其递增的托管指针).</param>
        /// <param name="beforeValue">When not equal to the zero, returns the value pointed to before the increment. Otherwise, it returns <paramref name="newValue"/> (当不与0相等时, 返回递增前所指向的值. 否则便返回 <paramref name="newValue"/>).</param>
        /// <param name="newValue">When equal to the zero, <paramref name="beforeValue"/> returns the new value (当与0相等时, <paramref name="beforeValue"/> 会返回这个新值).</param>
        /// <returns>When not equal to the zero, post-increment of the given managed pointer. Otherwise, it returns to the <paramref name="source"/> (当不与0相等时, 向给定的托管指针后置递增. 否则便返回 <paramref name="source"/>).</returns>
        /// <seealso cref="Unsafe.Add{T}(ref T, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref T PostIncExceptZero<T>(ref T source, out T beforeValue, T newValue = default) where T : struct, IEquatable<T> {
            return ref PostIncExcept(ref source, out beforeValue, default, newValue);
        }


        /// <summary>
        /// Get a reference to an array item, and bypass the array bounds check if possible (获取数组项目的引用, 并尽可能绕过数组边界检查).
        /// </summary>
        /// <typeparam name="T">Type of array item (数组项目的类型).</typeparam>
        /// <param name="array">Source array (源数组).</param>
        /// <param name="index">The item index (项目的索引).</param>
        /// <returns>Return a reference to an array item (返回数组项目的引用).</returns>
        /// <seealso cref="MemoryMarshal.GetArrayDataReference{T}(T[])"/>
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
