﻿#if NET7_0_OR_GREATER
#define BCL_TYPE_INT128
#endif // NET7_0_OR_GREATER

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using System.Text;
using Zyl.VectorTraits.ExTypes;

namespace Zyl.VectorTraits {
    partial class Vector128s {
#if NETCOREAPP3_0_OR_GREATER

        /// <summary>Creates a new vector instance of element type <see cref="ExInt128"/> with all elements initialized to the specified value (创建新的元素类型为<see cref="ExInt128"/>的向量实例，其中所有元素已初始化为指定值).</summary>
        /// <param name="value">The value that all elements will be initialized to (所有元素的初始化值).</param>
        /// <returns>A new <see cref="Vector128{T}" /> with all elements initialized to <paramref name="value" /> (一个新向量，它的所有元素都初始化为 <paramref name="value" />).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ExInt128> Create(ExInt128 value) {
            var a = Unsafe.As<ExInt128, Vector128<ulong>>(ref value);
            return a.ExAsExInt128();
        }

        /// <summary>Creates a new vector instance of element type <see cref="ExUInt128"/> with all elements initialized to the specified value (创建新的元素类型为<see cref="ExUInt128"/>的向量实例，其中所有元素已初始化为指定值).</summary>
        /// <param name="value">The value that all elements will be initialized to (所有元素的初始化值).</param>
        /// <returns>A new <see cref="Vector128{T}" /> with all elements initialized to <paramref name="value" /> (一个新向量，它的所有元素都初始化为 <paramref name="value" />).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ExUInt128> Create(ExUInt128 value) {
            var a = Unsafe.As<ExUInt128, Vector128<ulong>>(ref value);
            return a.ExAsExUInt128();
        }

#if BCL_TYPE_INT128

        /// <summary>Creates a new vector instance of element type <see cref="Int128"/> with all elements initialized to the specified value (创建新的元素类型为<see cref="Int128"/>的向量实例，其中所有元素已初始化为指定值).</summary>
        /// <param name="value">The value that all elements will be initialized to (所有元素的初始化值).</param>
        /// <returns>A new <see cref="Vector128{T}" /> with all elements initialized to <paramref name="value" /> (一个新向量，它的所有元素都初始化为 <paramref name="value" />).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<Int128> Create(Int128 value) {
            var a = Unsafe.As<Int128, Vector128<ulong>>(ref value);
            return a.ExAsInt128();
        }

        /// <summary>Creates a new vector instance of element type <see cref="UInt128"/> with all elements initialized to the specified value (创建新的元素类型为<see cref="UInt128"/>的向量实例，其中所有元素已初始化为指定值).</summary>
        /// <param name="value">The value that all elements will be initialized to (所有元素的初始化值).</param>
        /// <returns>A new <see cref="Vector128{T}" /> with all elements initialized to <paramref name="value" /> (一个新向量，它的所有元素都初始化为 <paramref name="value" />).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<UInt128> Create(UInt128 value) {
            var a = Unsafe.As<UInt128, Vector128<ulong>>(ref value);
            return a.ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <summary>Creates a new vector instance of element type <see cref="ExInt128"/> with the first element initialized to the specified value and the remaining elements initialized to zero {创建新的元素类型为<see cref="ExInt128"/>的向量实例，其中首个元素已初始化为指定值并且其余元素已初始化为零}.</summary>
        /// <param name="value">The value that element 0 will be initialized to (元素 0 的初始化值).</param>
        /// <returns>A new <see cref="Vector128{T}" /> instance with the first element initialized to <paramref name="value" /> and the remaining elements initialized to zero (一个新的向量实例，其中首个元素初始化为 <paramref name="value" />，其余元素初始化为零).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ExInt128> CreateScalar(ExInt128 value) {
            var a = Unsafe.As<ExInt128, Vector128<ulong>>(ref value);
            return a.ExAsExInt128();
        }

        /// <summary>Creates a new vector instance of element type <see cref="ExUInt128"/> with the first element initialized to the specified value and the remaining elements initialized to zero {创建新的元素类型为<see cref="ExUInt128"/>的向量实例，其中首个元素已初始化为指定值并且其余元素已初始化为零}.</summary>
        /// <param name="value">The value that element 0 will be initialized to (元素 0 的初始化值).</param>
        /// <returns>A new <see cref="Vector128{T}" /> instance with the first element initialized to <paramref name="value" /> and the remaining elements initialized to zero (一个新的向量实例，其中首个元素初始化为 <paramref name="value" />，其余元素初始化为零).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ExUInt128> CreateScalar(ExUInt128 value) {
            var a = Unsafe.As<ExUInt128, Vector128<ulong>>(ref value);
            return a.ExAsExUInt128();
        }

#if BCL_TYPE_INT128

        /// <summary>Creates a new vector instance of element type <see cref="Int128"/> with the first element initialized to the specified value and the remaining elements initialized to zero {创建新的元素类型为<see cref="Int128"/>的向量实例，其中首个元素已初始化为指定值并且其余元素已初始化为零}.</summary>
        /// <param name="value">The value that element 0 will be initialized to (元素 0 的初始化值).</param>
        /// <returns>A new <see cref="Vector128{T}" /> instance with the first element initialized to <paramref name="value" /> and the remaining elements initialized to zero (一个新的向量实例，其中首个元素初始化为 <paramref name="value" />，其余元素初始化为零).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<Int128> CreateScalar(Int128 value) {
            var a = Unsafe.As<Int128, Vector128<ulong>>(ref value);
            return a.ExAsInt128();
        }

        /// <summary>Creates a new vector instance of element type <see cref="UInt128"/> with the first element initialized to the specified value and the remaining elements initialized to zero {创建新的元素类型为<see cref="UInt128"/>的向量实例，其中首个元素已初始化为指定值并且其余元素已初始化为零}.</summary>
        /// <param name="value">The value that element 0 will be initialized to (元素 0 的初始化值).</param>
        /// <returns>A new <see cref="Vector128{T}" /> instance with the first element initialized to <paramref name="value" /> and the remaining elements initialized to zero (一个新的向量实例，其中首个元素初始化为 <paramref name="value" />，其余元素初始化为零).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<UInt128> CreateScalar(UInt128 value) {
            var a = Unsafe.As<UInt128, Vector128<ulong>>(ref value);
            return a.ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <summary>Creates a new vector instance of element type <see cref="ExInt128"/> with the first element initialized to the specified value and the remaining elements left uninitialized (创建新的元素类型为<see cref="ExInt128"/>的向量实例，其中首个元素已初始化为指定值，而其余元素未初始化).</summary>
        /// <param name="value">The value that element 0 will be initialized to (元素 0 的初始化值).</param>
        /// <returns>A new <see cref="Vector128{T}" /> instance with the first element initialized to <paramref name="value" /> and the remaining elements left uninitialized (一个新的向量实例，其中首个元素初始化为 <paramref name="value" />，其余元素未初始化).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ExInt128> CreateScalarUnsafe(ExInt128 value) {
            return CreateScalar(value);
        }

        /// <summary>Creates a new vector instance of element type <see cref="ExUInt128"/> with the first element initialized to the specified value and the remaining elements left uninitialized (创建新的元素类型为<see cref="ExUInt128"/>的向量实例，其中首个元素已初始化为指定值，而其余元素未初始化).</summary>
        /// <param name="value">The value that element 0 will be initialized to (元素 0 的初始化值).</param>
        /// <returns>A new <see cref="Vector128{T}" /> instance with the first element initialized to <paramref name="value" /> and the remaining elements left uninitialized (一个新的向量实例，其中首个元素初始化为 <paramref name="value" />，其余元素未初始化).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ExUInt128> CreateScalarUnsafe(ExUInt128 value) {
            return CreateScalar(value);
        }

#if BCL_TYPE_INT128

        /// <summary>Creates a new vector instance of element type <see cref="Int128"/> with the first element initialized to the specified value and the remaining elements left uninitialized (创建新的元素类型为<see cref="Int128"/>的向量实例，其中首个元素已初始化为指定值，而其余元素未初始化).</summary>
        /// <param name="value">The value that element 0 will be initialized to (元素 0 的初始化值).</param>
        /// <returns>A new <see cref="Vector128{T}" /> instance with the first element initialized to <paramref name="value" /> and the remaining elements left uninitialized (一个新的向量实例，其中首个元素初始化为 <paramref name="value" />，其余元素未初始化).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<Int128> CreateScalarUnsafe(Int128 value) {
            return CreateScalar(value);
        }

        /// <summary>Creates a new vector instance of element type <see cref="UInt128"/> with the first element initialized to the specified value and the remaining elements left uninitialized (创建新的元素类型为<see cref="UInt128"/>的向量实例，其中首个元素已初始化为指定值，而其余元素未初始化).</summary>
        /// <param name="value">The value that element 0 will be initialized to (元素 0 的初始化值).</param>
        /// <returns>A new <see cref="Vector128{T}" /> instance with the first element initialized to <paramref name="value" /> and the remaining elements left uninitialized (一个新的向量实例，其中首个元素初始化为 <paramref name="value" />，其余元素未初始化).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<UInt128> CreateScalarUnsafe(UInt128 value) {
            return CreateScalar(value);
        }

#endif // BCL_TYPE_INT128

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
