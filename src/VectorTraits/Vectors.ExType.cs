#if NET7_0_OR_GREATER
#define BCL_TYPE_INT128
#endif // NET7_0_OR_GREATER

using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using System.Text;
using Zyl.VectorTraits.ExTypes;

namespace Zyl.VectorTraits {
    partial class Vectors {

        /// <summary>Creates a new vector instance of element type <see cref="ExInt128"/> with all elements initialized to the specified value (创建新的元素类型为<see cref="ExInt128"/>的向量实例，其中所有元素已初始化为指定值).</summary>
        /// <param name="value">The value that all elements will be initialized to (所有元素的初始化值).</param>
        /// <returns>A new <see cref="Vector{T}" /> with all elements initialized to <paramref name="value" /> (一个新向量，它的所有元素都初始化为 <paramref name="value" />).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ExInt128> Create(ExInt128 value) {
#if NETCOREAPP3_0_OR_GREATER
            if (Vector<byte>.Count == Vector128<byte>.Count) {
                return AsVector(Vector128s.Create(value));
            } else if (Vector<byte>.Count == Vector256<byte>.Count) {
                return AsVector(Vector256s.Create(value));
#if NET8_0_OR_GREATER
            } else if (Vector<byte>.Count == Vector512<byte>.Count) {
                return AsVector(Vector512s.Create(value));
#endif // NET8_0_OR_GREATER
            }
#endif // NETCOREAPP3_0_OR_GREATER
            Unsafe.SkipInit(out Vector<ExInt128> rt);
            ref ExInt128 p = ref Unsafe.As<Vector<ExInt128>, ExInt128>(ref rt);
            int cnt = Vector<ExInt128>.Count;
            for (int i = 0; i < cnt; ++i) {
                p = value;
                p = ref Unsafe.Add(ref p, i);
            }
            return rt;
        }

        /// <summary>Creates a new vector instance of element type <see cref="ExUInt128"/> with all elements initialized to the specified value (创建新的元素类型为<see cref="ExUInt128"/>的向量实例，其中所有元素已初始化为指定值).</summary>
        /// <param name="value">The value that all elements will be initialized to (所有元素的初始化值).</param>
        /// <returns>A new <see cref="Vector{T}" /> with all elements initialized to <paramref name="value" /> (一个新向量，它的所有元素都初始化为 <paramref name="value" />).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ExUInt128> Create(ExUInt128 value) {
#if NETCOREAPP3_0_OR_GREATER
            if (Vector<byte>.Count == Vector128<byte>.Count) {
                return AsVector(Vector128s.Create(value));
            } else if (Vector<byte>.Count == Vector256<byte>.Count) {
                return AsVector(Vector256s.Create(value));
#if NET8_0_OR_GREATER
            } else if (Vector<byte>.Count == Vector512<byte>.Count) {
                return AsVector(Vector512s.Create(value));
#endif // NET8_0_OR_GREATER
            }
#endif // NETCOREAPP3_0_OR_GREATER
            Unsafe.SkipInit(out Vector<ExUInt128> rt);
            ref ExUInt128 p = ref Unsafe.As<Vector<ExUInt128>, ExUInt128>(ref rt);
            int cnt = Vector<ExUInt128>.Count;
            for (int i = 0; i < cnt; ++i) {
                p = value;
                p = ref Unsafe.Add(ref p, i);
            }
            return rt;
        }

#if BCL_TYPE_INT128

        /// <summary>Creates a new vector instance of element type <see cref="Int128"/> with all elements initialized to the specified value (创建新的元素类型为<see cref="Int128"/>的向量实例，其中所有元素已初始化为指定值).</summary>
        /// <param name="value">The value that all elements will be initialized to (所有元素的初始化值).</param>
        /// <returns>A new <see cref="Vector{T}" /> with all elements initialized to <paramref name="value" /> (一个新向量，它的所有元素都初始化为 <paramref name="value" />).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<Int128> Create(Int128 value) {
            return Create((ExInt128)value).ExAsInt128();
        }

        /// <summary>Creates a new vector instance of element type <see cref="UInt128"/> with all elements initialized to the specified value (创建新的元素类型为<see cref="UInt128"/>的向量实例，其中所有元素已初始化为指定值).</summary>
        /// <param name="value">The value that all elements will be initialized to (所有元素的初始化值).</param>
        /// <returns>A new <see cref="Vector{T}" /> with all elements initialized to <paramref name="value" /> (一个新向量，它的所有元素都初始化为 <paramref name="value" />).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<UInt128> Create(UInt128 value) {
            return Create((ExUInt128)value).ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <summary>Creates a new vector instance of element type <see cref="ExInt128"/> with the first element initialized to the specified value and the remaining elements initialized to zero {创建新的元素类型为<see cref="ExInt128"/>的向量实例，其中首个元素已初始化为指定值并且其余元素已初始化为零}.</summary>
        /// <param name="value">The value that element 0 will be initialized to (元素 0 的初始化值).</param>
        /// <returns>A new <see cref="Vector{T}" /> instance with the first element initialized to <paramref name="value" /> and the remaining elements initialized to zero (一个新的向量实例，其中首个元素初始化为 <paramref name="value" />，其余元素初始化为零).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ExInt128> CreateScalar(ExInt128 value) {
#if NETCOREAPP3_0_OR_GREATER
            if (Vector<byte>.Count == Vector128<byte>.Count) {
                return AsVector(Vector128s.CreateScalar(value));
            } else if (Vector<byte>.Count == Vector256<byte>.Count) {
                return AsVector(Vector256s.CreateScalar(value));
#if NET8_0_OR_GREATER
            } else if (Vector<byte>.Count == Vector512<byte>.Count) {
                return AsVector(Vector512s.CreateScalar(value));
#endif // NET8_0_OR_GREATER
            }
#endif // NETCOREAPP3_0_OR_GREATER
            Vector<ExInt128> rt = default;
            ref ExInt128 p = ref Unsafe.As<Vector<ExInt128>, ExInt128>(ref rt);
            p = value;
            return rt;
        }

        /// <summary>Creates a new vector instance of element type <see cref="ExUInt128"/> with the first element initialized to the specified value and the remaining elements initialized to zero {创建新的元素类型为<see cref="ExUInt128"/>的向量实例，其中首个元素已初始化为指定值并且其余元素已初始化为零}.</summary>
        /// <param name="value">The value that element 0 will be initialized to (元素 0 的初始化值).</param>
        /// <returns>A new <see cref="Vector{T}" /> instance with the first element initialized to <paramref name="value" /> and the remaining elements initialized to zero (一个新的向量实例，其中首个元素初始化为 <paramref name="value" />，其余元素初始化为零).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ExUInt128> CreateScalar(ExUInt128 value) {
#if NETCOREAPP3_0_OR_GREATER
            if (Vector<byte>.Count == Vector128<byte>.Count) {
                return AsVector(Vector128s.CreateScalar(value));
            } else if (Vector<byte>.Count == Vector256<byte>.Count) {
                return AsVector(Vector256s.CreateScalar(value));
#if NET8_0_OR_GREATER
            } else if (Vector<byte>.Count == Vector512<byte>.Count) {
                return AsVector(Vector512s.CreateScalar(value));
#endif // NET8_0_OR_GREATER
            }
#endif // NETCOREAPP3_0_OR_GREATER
            Vector<ExUInt128> rt = default;
            ref ExUInt128 p = ref Unsafe.As<Vector<ExUInt128>, ExUInt128>(ref rt);
            p = value;
            return rt;
        }

#if BCL_TYPE_INT128

        /// <summary>Creates a new vector instance of element type <see cref="Int128"/> with the first element initialized to the specified value and the remaining elements initialized to zero {创建新的元素类型为<see cref="Int128"/>的向量实例，其中首个元素已初始化为指定值并且其余元素已初始化为零}.</summary>
        /// <param name="value">The value that element 0 will be initialized to (元素 0 的初始化值).</param>
        /// <returns>A new <see cref="Vector{T}" /> instance with the first element initialized to <paramref name="value" /> and the remaining elements initialized to zero (一个新的向量实例，其中首个元素初始化为 <paramref name="value" />，其余元素初始化为零).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<Int128> CreateScalar(Int128 value) {
            return CreateScalar((ExInt128)value).ExAsInt128();
        }

        /// <summary>Creates a new vector instance of element type <see cref="UInt128"/> with the first element initialized to the specified value and the remaining elements initialized to zero {创建新的元素类型为<see cref="UInt128"/>的向量实例，其中首个元素已初始化为指定值并且其余元素已初始化为零}.</summary>
        /// <param name="value">The value that element 0 will be initialized to (元素 0 的初始化值).</param>
        /// <returns>A new <see cref="Vector{T}" /> instance with the first element initialized to <paramref name="value" /> and the remaining elements initialized to zero (一个新的向量实例，其中首个元素初始化为 <paramref name="value" />，其余元素初始化为零).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<UInt128> CreateScalar(UInt128 value) {
            return CreateScalar((ExUInt128)value).ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <summary>Creates a new vector instance of element type <see cref="ExInt128"/> with the first element initialized to the specified value and the remaining elements left uninitialized (创建新的元素类型为<see cref="ExInt128"/>的向量实例，其中首个元素已初始化为指定值，而其余元素未初始化).</summary>
        /// <param name="value">The value that element 0 will be initialized to (元素 0 的初始化值).</param>
        /// <returns>A new <see cref="Vector{T}" /> instance with the first element initialized to <paramref name="value" /> and the remaining elements left uninitialized (一个新的向量实例，其中首个元素初始化为 <paramref name="value" />，其余元素未初始化).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ExInt128> CreateScalarUnsafe(ExInt128 value) {
#if NETCOREAPP3_0_OR_GREATER
            if (Vector<byte>.Count == Vector128<byte>.Count) {
                return AsVector(Vector128s.CreateScalarUnsafe(value));
            } else if (Vector<byte>.Count == Vector256<byte>.Count) {
                return AsVector(Vector256s.CreateScalarUnsafe(value));
#if NET8_0_OR_GREATER
            } else if (Vector<byte>.Count == Vector512<byte>.Count) {
                return AsVector(Vector512s.CreateScalarUnsafe(value));
#endif // NET8_0_OR_GREATER
            }
#endif // NETCOREAPP3_0_OR_GREATER
            Unsafe.SkipInit(out Vector<ExInt128> rt);
            ref ExInt128 p = ref Unsafe.As<Vector<ExInt128>, ExInt128>(ref rt);
            p = value;
            return rt;
        }

        /// <summary>Creates a new vector instance of element type <see cref="ExUInt128"/> with the first element initialized to the specified value and the remaining elements left uninitialized (创建新的元素类型为<see cref="ExUInt128"/>的向量实例，其中首个元素已初始化为指定值，而其余元素未初始化).</summary>
        /// <param name="value">The value that element 0 will be initialized to (元素 0 的初始化值).</param>
        /// <returns>A new <see cref="Vector{T}" /> instance with the first element initialized to <paramref name="value" /> and the remaining elements left uninitialized (一个新的向量实例，其中首个元素初始化为 <paramref name="value" />，其余元素未初始化).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ExUInt128> CreateScalarUnsafe(ExUInt128 value) {
#if NETCOREAPP3_0_OR_GREATER
            if (Vector<byte>.Count == Vector128<byte>.Count) {
                return AsVector(Vector128s.CreateScalarUnsafe(value));
            } else if (Vector<byte>.Count == Vector256<byte>.Count) {
                return AsVector(Vector256s.CreateScalarUnsafe(value));
#if NET8_0_OR_GREATER
            } else if (Vector<byte>.Count == Vector512<byte>.Count) {
                return AsVector(Vector512s.CreateScalarUnsafe(value));
#endif // NET8_0_OR_GREATER
            }
#endif // NETCOREAPP3_0_OR_GREATER
            Unsafe.SkipInit(out Vector<ExUInt128> rt);
            ref ExUInt128 p = ref Unsafe.As<Vector<ExUInt128>, ExUInt128>(ref rt);
            p = value;
            return rt;
        }

#if BCL_TYPE_INT128

        /// <summary>Creates a new vector instance of element type <see cref="Int128"/> with the first element initialized to the specified value and the remaining elements left uninitialized (创建新的元素类型为<see cref="Int128"/>的向量实例，其中首个元素已初始化为指定值，而其余元素未初始化).</summary>
        /// <param name="value">The value that element 0 will be initialized to (元素 0 的初始化值).</param>
        /// <returns>A new <see cref="Vector{T}" /> instance with the first element initialized to <paramref name="value" /> and the remaining elements left uninitialized (一个新的向量实例，其中首个元素初始化为 <paramref name="value" />，其余元素未初始化).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<Int128> CreateScalarUnsafe(Int128 value) {
            return CreateScalarUnsafe((ExInt128)value).ExAsInt128();
        }

        /// <summary>Creates a new vector instance of element type <see cref="UInt128"/> with the first element initialized to the specified value and the remaining elements left uninitialized (创建新的元素类型为<see cref="UInt128"/>的向量实例，其中首个元素已初始化为指定值，而其余元素未初始化).</summary>
        /// <param name="value">The value that element 0 will be initialized to (元素 0 的初始化值).</param>
        /// <returns>A new <see cref="Vector{T}" /> instance with the first element initialized to <paramref name="value" /> and the remaining elements left uninitialized (一个新的向量实例，其中首个元素初始化为 <paramref name="value" />，其余元素未初始化).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<UInt128> CreateScalarUnsafe(UInt128 value) {
            return CreateScalarUnsafe((ExUInt128)value).ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

    }
}
