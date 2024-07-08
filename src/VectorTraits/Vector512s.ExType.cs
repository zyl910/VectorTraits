#if NET7_0_OR_GREATER
#define BCL_TYPE_INT128
#endif // NET7_0_OR_GREATER

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
#endif
using System.Text;
using Zyl.VectorTraits.ExTypes;

namespace Zyl.VectorTraits {
    partial class Vector512s {
#if NET8_0_OR_GREATER

        /// <summary>Creates a new vector instance of element type <see cref="ExInt128"/> with all elements initialized to the specified value (创建新的元素类型为<see cref="ExInt128"/>的向量实例，其中所有元素已初始化为指定值).</summary>
        /// <param name="value">The value that all elements will be initialized to (所有元素的初始化值).</param>
        /// <returns>A new <see cref="Vector512{T}" /> with all elements initialized to <paramref name="value" /> (一个新向量，它的所有元素都初始化为 <paramref name="value" />).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ExInt128> Create(ExInt128 value) {
            var a = Unsafe.As<ExInt128, Vector128<ulong>>(ref value);
            var b = Vector256.Create(a, a);
            var c = Vector512.Create(b, b);
            return c.ExAsExInt128();
        }

        /// <summary>Creates a new vector instance of element type <see cref="ExUInt128"/> with all elements initialized to the specified value (创建新的元素类型为<see cref="ExUInt128"/>的向量实例，其中所有元素已初始化为指定值).</summary>
        /// <param name="value">The value that all elements will be initialized to (所有元素的初始化值).</param>
        /// <returns>A new <see cref="Vector512{T}" /> with all elements initialized to <paramref name="value" /> (一个新向量，它的所有元素都初始化为 <paramref name="value" />).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ExUInt128> Create(ExUInt128 value) {
            var a = Unsafe.As<ExUInt128, Vector128<ulong>>(ref value);
            var b = Vector256.Create(a, a);
            var c = Vector512.Create(b, b);
            return c.ExAsExUInt128();
        }

        /// <summary>Creates a new vector instance of element type <see cref="ExInt128"/> with each element initialized to the corresponding specified value {创建新的元素类型为<see cref="ExInt128"/>的向量实例，其中每个元素都已初始化为相应的指定值}.</summary>
        /// <param name="e0">The value that element 0 will be initialized to (元素 0 的初始化值).</param>
        /// <param name="e1">The value that element 1 will be initialized to (元素 1 的初始化值).</param>
        /// <param name="e2">The value that element 2 will be initialized to (元素 2 的初始化值).</param>
        /// <param name="e3">The value that element 3 will be initialized to (元素 3 的初始化值).</param>
        /// <returns>A new <see cref="Vector512{T}" /> with each element initialized to corresponding specified value (一个新向量，其中每个元素都初始化为相应的指定值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ExInt128> Create(ExInt128 e0, ExInt128 e1, ExInt128 e2, ExInt128 e3) {
            var a0 = Unsafe.As<ExInt128, Vector128<ulong>>(ref e0);
            var a1 = Unsafe.As<ExInt128, Vector128<ulong>>(ref e1);
            var a2 = Unsafe.As<ExInt128, Vector128<ulong>>(ref e2);
            var a3 = Unsafe.As<ExInt128, Vector128<ulong>>(ref e3);
            var b0 = Vector256.Create(a0, a1);
            var b1 = Vector256.Create(a2, a3);
            var c = Vector512.Create(b0, b1);
            return c.ExAsExInt128();
        }

        /// <summary>Creates a new vector instance of element type <see cref="ExUInt128"/> with each element initialized to the corresponding specified value {创建新的元素类型为<see cref="ExUInt128"/>的向量实例，其中每个元素都已初始化为相应的指定值}.</summary>
        /// <param name="e0">The value that element 0 will be initialized to (元素 0 的初始化值).</param>
        /// <param name="e1">The value that element 1 will be initialized to (元素 1 的初始化值).</param>
        /// <param name="e2">The value that element 2 will be initialized to (元素 2 的初始化值).</param>
        /// <param name="e3">The value that element 3 will be initialized to (元素 3 的初始化值).</param>
        /// <returns>A new <see cref="Vector512{T}" /> with each element initialized to corresponding specified value (一个新向量，其中每个元素都初始化为相应的指定值).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ExUInt128> Create(ExUInt128 e0, ExUInt128 e1, ExUInt128 e2, ExUInt128 e3) {
            var a0 = Unsafe.As<ExUInt128, Vector128<ulong>>(ref e0);
            var a1 = Unsafe.As<ExUInt128, Vector128<ulong>>(ref e1);
            var a2 = Unsafe.As<ExUInt128, Vector128<ulong>>(ref e2);
            var a3 = Unsafe.As<ExUInt128, Vector128<ulong>>(ref e3);
            var b0 = Vector256.Create(a0, a1);
            var b1 = Vector256.Create(a2, a3);
            var c = Vector512.Create(b0, b1);
            return c.ExAsExUInt128();
        }

#if BCL_TYPE_INT128

        /// <summary>Creates a new vector instance of element type <see cref="Int128"/> with all elements initialized to the specified value (创建新的元素类型为<see cref="Int128"/>的向量实例，其中所有元素已初始化为指定值).</summary>
        /// <param name="value">The value that all elements will be initialized to (所有元素的初始化值).</param>
        /// <returns>A new <see cref="Vector512{T}" /> with all elements initialized to <paramref name="value" /> (一个新向量，它的所有元素都初始化为 <paramref name="value" />).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<Int128> Create(Int128 value) {
            var a = Unsafe.As<Int128, Vector128<ulong>>(ref value);
            var b = Vector256.Create(a, a);
            var c = Vector512.Create(b, b);
            return c.ExAsInt128();
        }

        /// <summary>Creates a new vector instance of element type <see cref="UInt128"/> with all elements initialized to the specified value (创建新的元素类型为<see cref="UInt128"/>的向量实例，其中所有元素已初始化为指定值).</summary>
        /// <param name="value">The value that all elements will be initialized to (所有元素的初始化值).</param>
        /// <returns>A new <see cref="Vector512{T}" /> with all elements initialized to <paramref name="value" /> (一个新向量，它的所有元素都初始化为 <paramref name="value" />).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<UInt128> Create(UInt128 value) {
            var a = Unsafe.As<UInt128, Vector128<ulong>>(ref value);
            var b = Vector256.Create(a, a);
            var c = Vector512.Create(b, b);
            return c.ExAsUInt128();
        }

        /// <summary>Creates a new vector instance of element type <see cref="Int128"/> with each element initialized to the corresponding specified value {创建新的元素类型为<see cref="Int128"/>的向量实例，其中每个元素都已初始化为相应的指定值}.</summary>
        /// <param name="e0">The value that element 0 will be initialized to (元素 0 的初始化值).</param>
        /// <param name="e1">The value that element 1 will be initialized to (元素 1 的初始化值).</param>
        /// <param name="e2">The value that element 2 will be initialized to (元素 2 的初始化值).</param>
        /// <param name="e3">The value that element 3 will be initialized to (元素 3 的初始化值).</param>
        /// <returns>A new <see cref="Vector512{T}" /> with each element initialized to corresponding specified value (一个新向量，其中每个元素都初始化为相应的指定值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<Int128> Create(Int128 e0, Int128 e1, Int128 e2, Int128 e3) {
            var a0 = Unsafe.As<Int128, Vector128<ulong>>(ref e0);
            var a1 = Unsafe.As<Int128, Vector128<ulong>>(ref e1);
            var a2 = Unsafe.As<Int128, Vector128<ulong>>(ref e2);
            var a3 = Unsafe.As<Int128, Vector128<ulong>>(ref e3);
            var b0 = Vector256.Create(a0, a1);
            var b1 = Vector256.Create(a2, a3);
            var c = Vector512.Create(b0, b1);
            return c.ExAsInt128();
        }

        /// <summary>Creates a new vector instance of element type <see cref="UInt128"/> with each element initialized to the corresponding specified value {创建新的元素类型为<see cref="UInt128"/>的向量实例，其中每个元素都已初始化为相应的指定值}.</summary>
        /// <param name="e0">The value that element 0 will be initialized to (元素 0 的初始化值).</param>
        /// <param name="e1">The value that element 1 will be initialized to (元素 1 的初始化值).</param>
        /// <param name="e2">The value that element 2 will be initialized to (元素 2 的初始化值).</param>
        /// <param name="e3">The value that element 3 will be initialized to (元素 3 的初始化值).</param>
        /// <returns>A new <see cref="Vector512{T}" /> with each element initialized to corresponding specified value (一个新向量，其中每个元素都初始化为相应的指定值).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<UInt128> Create(UInt128 e0, UInt128 e1, UInt128 e2, UInt128 e3) {
            var a0 = Unsafe.As<UInt128, Vector128<ulong>>(ref e0);
            var a1 = Unsafe.As<UInt128, Vector128<ulong>>(ref e1);
            var a2 = Unsafe.As<UInt128, Vector128<ulong>>(ref e2);
            var a3 = Unsafe.As<UInt128, Vector128<ulong>>(ref e3);
            var b0 = Vector256.Create(a0, a1);
            var b1 = Vector256.Create(a2, a3);
            var c = Vector512.Create(b0, b1);
            return c.ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <summary>Creates a new vector instance of element type <see cref="ExInt128"/> with the first element initialized to the specified value and the remaining elements initialized to zero {创建新的元素类型为<see cref="ExInt128"/>的向量实例，其中首个元素已初始化为指定值并且其余元素已初始化为零}.</summary>
        /// <param name="value">The value that element 0 will be initialized to (元素 0 的初始化值).</param>
        /// <returns>A new <see cref="Vector512{T}" /> instance with the first element initialized to <paramref name="value" /> and the remaining elements initialized to zero (一个新的向量实例，其中首个元素初始化为 <paramref name="value" />，其余元素初始化为零).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ExInt128> CreateScalar(ExInt128 value) {
            var a = Unsafe.As<ExInt128, Vector128<ulong>>(ref value);
            var b = a.ToVector256();
            var c = b.ToVector512();
            return c.ExAsExInt128();
        }

        /// <summary>Creates a new vector instance of element type <see cref="ExUInt128"/> with the first element initialized to the specified value and the remaining elements initialized to zero {创建新的元素类型为<see cref="ExUInt128"/>的向量实例，其中首个元素已初始化为指定值并且其余元素已初始化为零}.</summary>
        /// <param name="value">The value that element 0 will be initialized to (元素 0 的初始化值).</param>
        /// <returns>A new <see cref="Vector512{T}" /> instance with the first element initialized to <paramref name="value" /> and the remaining elements initialized to zero (一个新的向量实例，其中首个元素初始化为 <paramref name="value" />，其余元素初始化为零).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ExUInt128> CreateScalar(ExUInt128 value) {
            var a = Unsafe.As<ExUInt128, Vector128<ulong>>(ref value);
            var b = a.ToVector256();
            var c = b.ToVector512();
            return c.ExAsExUInt128();
        }

#if BCL_TYPE_INT128

        /// <summary>Creates a new vector instance of element type <see cref="Int128"/> with the first element initialized to the specified value and the remaining elements initialized to zero {创建新的元素类型为<see cref="Int128"/>的向量实例，其中首个元素已初始化为指定值并且其余元素已初始化为零}.</summary>
        /// <param name="value">The value that element 0 will be initialized to (元素 0 的初始化值).</param>
        /// <returns>A new <see cref="Vector512{T}" /> instance with the first element initialized to <paramref name="value" /> and the remaining elements initialized to zero (一个新的向量实例，其中首个元素初始化为 <paramref name="value" />，其余元素初始化为零).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<Int128> CreateScalar(Int128 value) {
            var a = Unsafe.As<Int128, Vector128<ulong>>(ref value);
            var b = a.ToVector256();
            var c = b.ToVector512();
            return c.ExAsInt128();
        }

        /// <summary>Creates a new vector instance of element type <see cref="UInt128"/> with the first element initialized to the specified value and the remaining elements initialized to zero {创建新的元素类型为<see cref="UInt128"/>的向量实例，其中首个元素已初始化为指定值并且其余元素已初始化为零}.</summary>
        /// <param name="value">The value that element 0 will be initialized to (元素 0 的初始化值).</param>
        /// <returns>A new <see cref="Vector512{T}" /> instance with the first element initialized to <paramref name="value" /> and the remaining elements initialized to zero (一个新的向量实例，其中首个元素初始化为 <paramref name="value" />，其余元素初始化为零).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<UInt128> CreateScalar(UInt128 value) {
            var a = Unsafe.As<UInt128, Vector128<ulong>>(ref value);
            var b = a.ToVector256();
            var c = b.ToVector512();
            return c.ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <summary>Creates a new vector instance of element type <see cref="ExInt128"/> with the first element initialized to the specified value and the remaining elements left uninitialized (创建新的元素类型为<see cref="ExInt128"/>的向量实例，其中首个元素已初始化为指定值，而其余元素未初始化).</summary>
        /// <param name="value">The value that element 0 will be initialized to (元素 0 的初始化值).</param>
        /// <returns>A new <see cref="Vector512{T}" /> instance with the first element initialized to <paramref name="value" /> and the remaining elements left uninitialized (一个新的向量实例，其中首个元素初始化为 <paramref name="value" />，其余元素未初始化).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ExInt128> CreateScalarUnsafe(ExInt128 value) {
            var a = Unsafe.As<ExInt128, Vector128<ulong>>(ref value);
            var b = a.ToVector256Unsafe();
            var c = b.ToVector512Unsafe();
            return c.ExAsExInt128();
        }

        /// <summary>Creates a new vector instance of element type <see cref="ExUInt128"/> with the first element initialized to the specified value and the remaining elements left uninitialized (创建新的元素类型为<see cref="ExUInt128"/>的向量实例，其中首个元素已初始化为指定值，而其余元素未初始化).</summary>
        /// <param name="value">The value that element 0 will be initialized to (元素 0 的初始化值).</param>
        /// <returns>A new <see cref="Vector512{T}" /> instance with the first element initialized to <paramref name="value" /> and the remaining elements left uninitialized (一个新的向量实例，其中首个元素初始化为 <paramref name="value" />，其余元素未初始化).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ExUInt128> CreateScalarUnsafe(ExUInt128 value) {
            var a = Unsafe.As<ExUInt128, Vector128<ulong>>(ref value);
            var b = a.ToVector256Unsafe();
            var c = b.ToVector512Unsafe();
            return c.ExAsExUInt128();
        }

#if BCL_TYPE_INT128

        /// <summary>Creates a new vector instance of element type <see cref="Int128"/> with the first element initialized to the specified value and the remaining elements left uninitialized (创建新的元素类型为<see cref="Int128"/>的向量实例，其中首个元素已初始化为指定值，而其余元素未初始化).</summary>
        /// <param name="value">The value that element 0 will be initialized to (元素 0 的初始化值).</param>
        /// <returns>A new <see cref="Vector512{T}" /> instance with the first element initialized to <paramref name="value" /> and the remaining elements left uninitialized (一个新的向量实例，其中首个元素初始化为 <paramref name="value" />，其余元素未初始化).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<Int128> CreateScalarUnsafe(Int128 value) {
            var a = Unsafe.As<Int128, Vector128<ulong>>(ref value);
            var b = a.ToVector256Unsafe();
            var c = b.ToVector512Unsafe();
            return c.ExAsInt128();
        }

        /// <summary>Creates a new vector instance of element type <see cref="UInt128"/> with the first element initialized to the specified value and the remaining elements left uninitialized (创建新的元素类型为<see cref="UInt128"/>的向量实例，其中首个元素已初始化为指定值，而其余元素未初始化).</summary>
        /// <param name="value">The value that element 0 will be initialized to (元素 0 的初始化值).</param>
        /// <returns>A new <see cref="Vector512{T}" /> instance with the first element initialized to <paramref name="value" /> and the remaining elements left uninitialized (一个新的向量实例，其中首个元素初始化为 <paramref name="value" />，其余元素未初始化).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<UInt128> CreateScalarUnsafe(UInt128 value) {
            var a = Unsafe.As<UInt128, Vector128<ulong>>(ref value);
            var b = a.ToVector256Unsafe();
            var c = b.ToVector512Unsafe();
            return c.ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

#endif // NET8_0_OR_GREATER
    }
}
