using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using System.Collections;

namespace Zyl.VectorTraits {

    /// <summary>
    /// Methods of <see cref="Vector{T}"/> .
    /// </summary>
    public static class Vectors {

        // == Mask array ==
        // It takes up too much space to construct a batch of mask arrays for each element type. Int32/UInt32/Single can share a 4-byte mask, and the total bit length of vector types is fixed. Therefore, arrays such as MaskBitPosArray1B can be shared by multiple element types. (若为每一种元素类型都构造一批掩码数组的话, 太占空间了. 考虑到 Int32/UInt32/Single 可共用4字节的掩码, 且向量类型的总位长是固定的, 于是 MaskBitPosArray1B 等数组可以给多种元素类型所共用.)

        /// <summary>Bit pos mask array - 1Byte (位偏移掩码的数组 - 1字节). e.g. 1, 2, 4, 8, 0x10 ...</summary>
        private static readonly Vector<Byte>[] MaskBitPosArray1B;
        /// <summary>Bit pos mask array - 2Byte (位偏移掩码的数组 - 2字节). e.g. 1, 2, 4, 8, 0x10 ...</summary>
        private static readonly Vector<Byte>[] MaskBitPosArray2B;
        /// <summary>Bit pos mask array - 4Byte (位偏移掩码的数组 - 4字节). e.g. 1, 2, 4, 8, 0x10 ...</summary>
        private static readonly Vector<Byte>[] MaskBitPosArray4B;
        /// <summary>Bit pos mask array - 8Byte (位偏移掩码的数组 - 8字节). e.g. 1, 2, 4, 8, 0x10 ...</summary>
        private static readonly Vector<Byte>[] MaskBitPosArray8B;
        /// <summary>Bits mask array - 1Byte (位集掩码的数组 - 1字节). e.g. 0, 1, 3, 7, 0xF, 0x1F ...</summary>
        private static readonly Vector<Byte>[] MaskBitsArray1B;
        /// <summary>Bits mask array - 2Byte (位集掩码的数组 - 2字节). e.g. 0, 1, 3, 7, 0xF, 0x1F ...</summary>
        private static readonly Vector<Byte>[] MaskBitsArray2B;
        /// <summary>Bits mask array - 4Byte (位集掩码的数组 - 4字节). e.g. 0, 1, 3, 7, 0xF, 0x1F ...</summary>
        private static readonly Vector<Byte>[] MaskBitsArray4B;
        /// <summary>Bits mask array - 8Byte (位集掩码的数组 - 8字节). e.g. 0, 1, 3, 7, 0xF, 0x1F ...</summary>
        private static readonly Vector<Byte>[] MaskBitsArray8B;

        /// <summary>
        /// Static constructor.
        /// </summary>
        static Vectors() {
            Int64 bitpos;
            Int64 bits;
            int i;
            MaskBitPosArray1B = new Vector<Byte>[1 * 8];
            MaskBitPosArray2B = new Vector<Byte>[2 * 8];
            MaskBitPosArray4B = new Vector<Byte>[4 * 8];
            MaskBitPosArray8B = new Vector<Byte>[8 * 8];
            MaskBitsArray1B = new Vector<Byte>[1 * 8 + 1];
            MaskBitsArray2B = new Vector<Byte>[2 * 8 + 1];
            MaskBitsArray4B = new Vector<Byte>[4 * 8 + 1];
            MaskBitsArray8B = new Vector<Byte>[8 * 8 + 1];
            MaskBitsArray1B[0] = Vector<Byte>.Zero;
            MaskBitsArray2B[0] = Vector<Byte>.Zero;
            MaskBitsArray4B[0] = Vector<Byte>.Zero;
            MaskBitsArray8B[0] = Vector<Byte>.Zero;
            bitpos = 1;
            bits = 1;
            for (i=0; i< MaskBitPosArray8B.Length; ++i) {
                if (i < MaskBitPosArray1B.Length) {
                    MaskBitPosArray1B[i] = Vectors.Create(Scalars.GetByBits<Byte>(bitpos));
                    MaskBitsArray1B[1 + i] = Vectors.Create(Scalars.GetByBits<Byte>(bits));
                }
                if (i < MaskBitPosArray2B.Length) {
                    MaskBitPosArray2B[i] = Vector.AsVectorByte(Vectors.Create(Scalars.GetByBits<UInt16>(bitpos)));
                    MaskBitsArray2B[1 + i] = Vector.AsVectorByte(Vectors.Create(Scalars.GetByBits<UInt16>(bits)));
                }
                if (i < MaskBitPosArray4B.Length) {
                    MaskBitPosArray4B[i] = Vector.AsVectorByte(Vectors.Create(Scalars.GetByBits<UInt32>(bitpos)));
                    MaskBitsArray4B[1 + i] = Vector.AsVectorByte(Vectors.Create(Scalars.GetByBits<UInt32>(bits)));
                }
                if (i < MaskBitPosArray8B.Length) {
                    MaskBitPosArray8B[i] = Vector.AsVectorByte(Vectors.Create(Scalars.GetByBits<UInt64>(bitpos)));
                    MaskBitsArray8B[1 + i] = Vector.AsVectorByte(Vectors.Create(Scalars.GetByBits<UInt64>(bits)));
                }
                // next.
                bitpos <<= 1;
                bits = bits << 1 | 1;
            }
            if (0!= bits) {
                // [Debug]
            }
        }

        /// <summary>
        /// Get bit pos mask array (取得位偏移掩码的数组).
        /// </summary>
        /// <param name="byteSize">元素的字节大小 (元素的字节大小).</param>
        /// <returns>Returns bit pos mask array (返回位偏移掩码的数组). An 8-byte array is returned if not found, to avoid returning null (找不到时返回8字节的数组, 这是为了避免返回null).</returns>
        internal static Vector<Byte>[] GetMaskBitPosArray(int byteSize) {
            if (1 == byteSize) {
                return MaskBitPosArray1B;
            } else if (2 == byteSize) {
                return MaskBitPosArray2B;
            } else if (4 == byteSize) {
                return MaskBitPosArray4B;
            } else {
                return MaskBitPosArray8B;
            }
        }

        /// <summary>
        /// Get bits mask array (取得位集掩码的数组).
        /// </summary>
        /// <param name="byteSize">元素的字节大小 (元素的字节大小).</param>
        /// <returns>Returns bits mask array (返回位集掩码的数组). An 8-byte array is returned if not found, to avoid returning null (找不到时返回8字节的数组, 这是为了避免返回null).</returns>
        internal static Vector<Byte>[] GetMaskBitsArray(int byteSize) {
            if (1 == byteSize) {
                return MaskBitsArray1B;
            } else if (2 == byteSize) {
                return MaskBitsArray2B;
            } else if (4 == byteSize) {
                return MaskBitsArray4B;
            } else {
                return MaskBitsArray8B;
            }
        }

        // == Vector as ==

#if NETCOREAPP3_0_OR_GREATER
        ///// <summary>
        ///// Reinterprets a <see cref="Vector64{T}"/> as a new <see cref="Vector{T}"/> (将 <see cref="Vector64{T}"/> 重新解释为新的 <see cref="Vector{T}"/>).
        ///// </summary>
        ///// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        ///// <param name="value">The vector to reinterpret (要重新解释的向量).</param>
        ///// <returns>value reinterpreted as a new <see cref="Vector{T}"/> (重新解释后新的 <see cref="Vector{T}"/>)值.</returns>
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static Vector<T> AsVector<T>(Vector64<T> value) where T : struct {
        //    //ThrowHelper.ThrowForUnsupportedVectorBaseType<T>();
        //    return Unsafe.As<Vector64<T>, Vector<T>>(ref value);
        //}

        /// <summary>
        /// Reinterprets a <see cref="Vector128{T}"/> as a new <see cref="Vector{T}"/> (将 <see cref="Vector128{T}"/> 重新解释为新的 <see cref="Vector{T}"/>).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="value">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>value reinterpreted as a new <see cref="Vector{T}"/> (重新解释后新的 <see cref="Vector{T}"/>)值.</returns>
        /// <seealso cref="Vector128.AsVector{T}(Vector128{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<T> AsVector<T>(Vector128<T> value) where T : struct {
            //ThrowHelper.ThrowForUnsupportedVectorBaseType<T>();
            return Unsafe.As<Vector128<T>, Vector<T>>(ref value);
        }

        /// <summary>
        /// Reinterprets a <see cref="Vector256{T}"/> as a new <see cref="Vector{T}"/> (将 <see cref="Vector256{T}"/> 重新解释为新的 <see cref="Vector{T}"/>).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="value">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>value reinterpreted as a new <see cref="Vector{T}"/> (重新解释后新的 <see cref="Vector{T}"/>)值.</returns>
        /// <seealso cref="Vector256.AsVector{T}(Vector256{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<T> AsVector<T>(Vector256<T> value) where T : struct {
            //ThrowHelper.ThrowForUnsupportedVectorBaseType<T>();
            return Unsafe.As<Vector256<T>, Vector<T>>(ref value);
        }

        ///// <summary>
        ///// Reinterprets a <see cref="Vector{T}"/> as a new <see cref="Vector64{T}"/> (将 <see cref="Vector{T}"/> 重新解释为新的 <see cref="Vector64{T}"/>).
        ///// </summary>
        ///// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        ///// <param name="value">The vector to reinterpret (要重新解释的向量).</param>
        ///// <returns>value reinterpreted as a new <see cref="Vector64{T}"/> (重新解释后新的 <see cref="Vector64{T}"/>)值.</returns>
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static Vector64<T> AsVector64<T>(Vector<T> value) where T : struct {
        //    //ThrowHelper.ThrowForUnsupportedVectorBaseType<T>();
        //    Vector64<T> source = default(Vector64<T>);
        //    Unsafe.WriteUnaligned(ref Unsafe.As<Vector64<T>, byte>(ref source), value);
        //    return source;
        //}

        /// <summary>
        /// Reinterprets a <see cref="Vector{T}"/> as a new <see cref="Vector128{T}"/> (将 <see cref="Vector{T}"/> 重新解释为新的 <see cref="Vector128{T}"/>).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="value">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>value reinterpreted as a new <see cref="Vector128{T}"/> (重新解释后新的 <see cref="Vector128{T}"/>)值.</returns>
        /// <seealso cref="Vector128.AsVector128{T}(Vector{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<T> AsVector128<T>(Vector<T> value) where T : struct {
            //ThrowHelper.ThrowForUnsupportedVectorBaseType<T>();
            Vector128<T> source = default;
            Unsafe.WriteUnaligned(ref Unsafe.As<Vector128<T>, byte>(ref source), value);
            return source;
        }

        /// <summary>
        /// Reinterprets a <see cref="Vector{T}"/> as a new <see cref="Vector256{T}"/> (将 <see cref="Vector{T}"/> 重新解释为新的 <see cref="Vector256{T}"/>).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="value">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>value reinterpreted as a new <see cref="Vector256{T}"/> (重新解释后新的 <see cref="Vector256{T}"/>)值.</returns>
        /// <seealso cref="Vector256.AsVector256{T}(Vector{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<T> AsVector256<T>(Vector<T> value) where T : struct {
            //ThrowHelper.ThrowForUnsupportedVectorBaseType<T>();
            Vector256<T> source = default;
            Unsafe.WriteUnaligned(ref Unsafe.As<Vector256<T>, byte>(ref source), value);
            return source;
        }

        /// <summary>
        /// Reinterprets a <see cref="Vector{T}"/> as a new <see cref="Vector256{T}"/> (将 <see cref="Vector{T}"/> 重新解释为新的 <see cref="Vector256{T}"/>).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="value">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>value reinterpreted as a new <see cref="Vector256{T}"/> (重新解释后新的 <see cref="Vector256{T}"/>)值.</returns>
        /// <seealso cref="Vector256.AsVector256{T}(Vector{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<T> AsVector256A<T>(Vector<T> value) where T : struct {
            return Unsafe.As<Vector<T>, Vector256<T>>(ref value);
        }

#endif

        // == Vector methods ==

        /// <summary>
        /// Creates a new <see cref="Vector{T}"/> instance with all elements initialized to the specified value (创建新的 <see cref="Vector{T}"/> 实例，其中所有元素已初始化为指定值).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="value">The value that all elements will be initialized to (所有元素的初始化目标值).</param>
        /// <returns>A new <see cref="Vector{T}"/> with all elements initialized to value (一个新的 <see cref="Vector{T}"/>，其中所有元素已初始化为 <paramref name="value"/> ).</returns>
        /// <seealso cref="Vector{T}(T)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<T> Create<T>(T value) where T : struct {
            return new Vector<T>(value);
        }

        /// <summary>
        /// Creates a new <see cref="Vector{T}"/> from a given array (从给定数组创建一个新的 <see cref="Vector{T}"/> ).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="values">The array from which the vector is created (用于创建向量的数组).</param>
        /// <returns>A new <see cref="Vector{T}"/> with its elements set to the first Count elements from <paramref name="values"/> (一个新<see cref="Vector{T}"/>，其元素设置为来自<paramref name="values"/>首批满足长度的元素).</returns>
        /// <seealso cref="Vector{T}(T[])"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<T> Create<T>(T[] values) where T:struct {
            return new Vector<T>(values);
        }

        /// <summary>
        /// Creates a new <see cref="Vector{T}"/> from a given array starting at a specified index position (于指定索引位置开始，从指定数组创建一个 <see cref="Vector{T}"/>).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="values">The array from which the vector is created (用于创建向量的数组).</param>
        /// <param name="index">The starting index position from which to create the vector (欲创建向量的起始索引位置).</param>
        /// <returns>A new <see cref="Vector{T}"/> with its elements set to the first Count elements from <paramref name="values"/> (一个新<see cref="Vector{T}"/>，其元素设置为来自<paramref name="values"/>首批满足长度的元素).</returns>
        /// <exception cref="IndexOutOfRangeException">The <paramref name="index"/> is less than zero (<paramref name="index"/> 小于零). The length of <paramref name="values"/>, starting from <paramref name="index"/>, is less than <see cref="Vector{T}.Count"/> (从 <paramref name="index"/> 开始的 <paramref name="values"/> 的长度小于 <see cref="Vector{T}.Count"/>).</exception>
        /// <seealso cref="Vector{T}(T[], int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<T> Create<T>(T[] values, int index) where T : struct {
            return new Vector<T>(values, index);
        }

        /// <summary>
        /// Creates a new <see cref="Vector{T}"/> from a given read-only span of bytes (根据给定的只读字节跨度构造一个 <see cref="Vector{T}"/>).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="values">A read-only span of bytes that contains the values to add to the vector (从中创建向量的只读字节跨度).</param>
        /// <returns>A new <see cref="Vector{T}"/> with its elements set to the first Count elements from <paramref name="values"/> (一个新<see cref="Vector{T}"/>，其元素设置为来自<paramref name="values"/>首批满足长度的元素).</returns>
        /// <exception cref="IndexOutOfRangeException"><paramref name="values"/> did not contain at least <see cref="Vector{T}.Count"/> elements (<paramref name="values"/> 的长度小于 <see cref="Vector{T}.Count"/>).</exception>
        /// <seealso cref="Vector{T}(ReadOnlySpan{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<T> Create<T>(ReadOnlySpan<byte> values) where T : struct {
#if NETCOREAPP3_0_OR_GREATER
            return new Vector<T>(values);
#else
            if (values.Length < Vector<byte>.Count) {
                throw new IndexOutOfRangeException(string.Format("Index was outside the bounds({0}) of the array!", values.Length));
            }
            return Unsafe.ReadUnaligned<Vector<T>>(ref BitUtil.GetReference(values));
#endif // NETCOREAPP3_0_OR_GREATER
        }

        /// <summary>
        /// Creates a new <see cref="Vector{T}"/> from a from the given <see cref="ReadOnlySpan{T}"/> (根据给定的 <see cref="ReadOnlySpan{T}"/> 构造一个 <see cref="Vector{T}"/>).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="values">The readonly span from which the vector is created (从中创建向量的只读跨度).</param>
        /// <returns>A new <see cref="Vector{T}"/> with its elements set to the first Count elements from <paramref name="values"/> (一个新<see cref="Vector{T}"/>，其元素设置为来自<paramref name="values"/>首批满足长度的元素).</returns>
        /// <exception cref="IndexOutOfRangeException"><paramref name="values"/> did not contain at least <see cref="Vector{T}.Count"/> elements (<paramref name="values"/> 的长度小于 <see cref="Vector{T}.Count"/>).</exception>
        /// <seealso cref="Vector{T}(ReadOnlySpan{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<T> Create<T>(ReadOnlySpan<T> values) where T : struct {
#if NETCOREAPP3_0_OR_GREATER
            return new Vector<T>(values);
#else
            if (values.Length < Vector<T>.Count) {
                throw new IndexOutOfRangeException(string.Format("Index was outside the bounds({0}) of the array!", values.Length));
            }
            return Unsafe.ReadUnaligned<Vector<T>>(ref Unsafe.As<T, byte>(ref BitUtil.GetReference(values)));
#endif // NETCOREAPP3_0_OR_GREATER
        }

        /// <summary>
        /// Creates a new <see cref="Vector{T}"/> from a from the given <see cref="Span{T}"/> (根据给定的 <see cref="Span{T}"/> 构造一个 <see cref="Vector{T}"/>).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="values">The span from which the vector is created (从中创建向量的跨度).</param>
        /// <returns>A new <see cref="Vector{T}"/> with its elements set to the first Count elements from <paramref name="values"/> (一个新<see cref="Vector{T}"/>，其元素设置为来自<paramref name="values"/>首批满足长度的元素).</returns>
        /// <exception cref="IndexOutOfRangeException"><paramref name="values"/> did not contain at least <see cref="Vector{T}.Count"/> elements (<paramref name="values"/> 的长度小于 <see cref="Vector{T}.Count"/>).</exception>
        /// <seealso cref="Vector{T}(Span{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<T> Create<T>(Span<T> values) where T : struct {
#if (NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER)
            return new Vector<T>(values);
#else
            if (values.Length < Vector<T>.Count) {
                throw new IndexOutOfRangeException(string.Format("Index was outside the bounds({0}) of the array!", values.Length));
            }
            return Unsafe.ReadUnaligned<Vector<T>>(ref Unsafe.As<T, byte>(ref BitUtil.GetReference(values)));
#endif // NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        }

        /// <summary>
        /// Padding creates a new <see cref="Vector{T}"/> from a given span starting at a specified index position (于指定索引位置开始，从指定跨度补齐创建一个 <see cref="Vector{T}"/>). The element after values is initialized to 0(values 之后的元素会初始化为0).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="values">The span from which the vector is created (用于创建向量的跨度).</param>
        /// <param name="index">Starting index position of valid data in <paramref name="values"/> (<paramref name="values"/> 中有效数据的起始索引位置).</param>
        /// <param name="length">Length of valid data in <paramref name="values"/> (<paramref name="values"/> 中有效数据的长度).</param>
        /// <returns>A new <see cref="Vector{T}"/> with its elements set to the first Count elements from <paramref name="values"/> (一个新<see cref="Vector{T}"/>，其元素设置为来自<paramref name="values"/>首批满足长度的元素).</returns>
        /// <exception cref="IndexOutOfRangeException">The <paramref name="index"/> is less than zero (<paramref name="index"/> 小于零). The length of <paramref name="values"/>, starting from <paramref name="index"/>, is less than <see cref="Vector{T}.Count"/> (从 <paramref name="index"/> 开始的 <paramref name="values"/> 的长度小于 <see cref="Vector{T}.Count"/>).</exception>
        public static Vector<T> CreatePadding<T>(ReadOnlySpan<T> values, int index, int length) where T : struct {
            int idxEnd = index + length;
            int idx = index;
            if (null == values || values.Length <= 0) return Vector<T>.Zero;
            if (index < 0 || idxEnd > values.Length) {
                throw new IndexOutOfRangeException(string.Format("Index({0}) was outside the bounds{1} of the array!", index, values.Length));
            }
            Vector<T> temp = default;
            unsafe {
                // T* arr = (T*)&temp; // CS0208	Cannot take the address of, get the size of, or declare a pointer to a managed type ('T')
                Span<T> arr = new Span<T>(&temp, Vector<T>.Count);
                int m = Math.Min(arr.Length, length);
                for (int i = 0; i < m; ++i) {
                    arr[i] = values[idx];
                    ++idx;
                    if (idx >= idxEnd) break;
                }
                return Create(arr);
            }
        }

        /// <summary>
        /// Padding creates a new <see cref="Vector{T}"/> from a given span (从指定跨度补齐创建一个 <see cref="Vector{T}"/>). The element after values is initialized to 0(values 之后的元素会初始化为0).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="values">The span from which the vector is created (用于创建向量的跨度).</param>
        /// <returns>A new <see cref="Vector{T}"/> with its elements set to the first Count elements from <paramref name="values"/> (一个新<see cref="Vector{T}"/>，其元素设置为来自<paramref name="values"/>首批满足长度的元素).</returns>
        public static Vector<T> CreatePadding<T>(ReadOnlySpan<T> values) where T : struct {
            return CreatePadding<T>(values, 0, values.Length);
        }

        /// <summary>
        /// Padding creates a new <see cref="Vector{T}"/> from a given array (从给定数组补齐创建一个新的 <see cref="Vector{T}"/> ). The element after values is initialized to 0(values 之后的元素会初始化为0).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="values">The array from which the vector is created (用于创建向量的数组).</param>
        /// <returns>A new <see cref="Vector{T}"/> with its elements set to the first Count elements from <paramref name="values"/> (一个新<see cref="Vector{T}"/>，其元素设置为来自<paramref name="values"/>首批满足长度的元素).</returns>
        public static Vector<T> CreatePadding<T>(params T[] values) where T : struct {
            return CreatePadding<T>(values, 0, values.Length);
        }

        /// <summary>
        /// Rotate creates a new <see cref="Vector{T}"/> from a given span starting at a specified index position (于指定索引位置开始，从指定跨度旋转创建一个 <see cref="Vector{T}"/>).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="values">The span from which the vector is created (用于创建向量的跨度).</param>
        /// <param name="index">Starting index position of valid data in <paramref name="values"/> (<paramref name="values"/> 中有效数据的起始索引位置).</param>
        /// <param name="length">Length of valid data in <paramref name="values"/> (<paramref name="values"/> 中有效数据的长度).</param>
        /// <returns>A new <see cref="Vector{T}"/> with its elements set to the first Count elements from <paramref name="values"/> (一个新<see cref="Vector{T}"/>，其元素设置为来自<paramref name="values"/>首批满足长度的元素).</returns>
        /// <exception cref="IndexOutOfRangeException">The <paramref name="index"/> is less than zero (<paramref name="index"/> 小于零). The length of <paramref name="values"/>, starting from <paramref name="index"/>, is less than <see cref="Vector{T}.Count"/> (从 <paramref name="index"/> 开始的 <paramref name="values"/> 的长度小于 <see cref="Vector{T}.Count"/>).</exception>
        public static Vector<T> CreateRotate<T>(ReadOnlySpan<T> values, int index, int length) where T : struct {
            int idxEnd = index + length;
            int idx = index;
            if (null == values || values.Length <= 0) return Vector<T>.Zero;
            if (index < 0 || idxEnd > values.Length) {
                throw new IndexOutOfRangeException(string.Format("Index({0}) was outside the bounds{1} of the array!", index, values.Length));
            }
            Vector<T> temp = default;
            unsafe {
                // T* arr = (T*)&temp; // CS0208	Cannot take the address of, get the size of, or declare a pointer to a managed type ('T')
                Span<T> arr = new Span<T>(&temp, Vector<T>.Count);
                for (int i = 0; i < arr.Length; ++i) {
                    arr[i] = values[idx];
                    ++idx;
                    if (idx >= idxEnd) idx = index;
                }
                return Create(arr);
            }
        }

        /// <summary>
        /// Rotate creates a new <see cref="Vector{T}"/> from a given span starting at a specified index position (于指定索引位置开始，从指定跨度旋转创建一个 <see cref="Vector{T}"/>).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="values">The span from which the vector is created (用于创建向量的跨度).</param>
        /// <returns>A new <see cref="Vector{T}"/> with its elements set to the first Count elements from <paramref name="values"/> (一个新<see cref="Vector{T}"/>，其元素设置为来自<paramref name="values"/>首批满足长度的元素).</returns>
        public static Vector<T> CreateRotate<T>(ReadOnlySpan<T> values) where T : struct {
            return CreateRotate<T>(values, 0, values.Length);
        }

        /// <summary>
        /// Rotate creates a new <see cref="Vector{T}"/> from a given array (从给定数组旋转创建一个新的 <see cref="Vector{T}"/> ).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="values">The array from which the vector is created (用于创建向量的数组).</param>
        /// <returns>A new <see cref="Vector{T}"/> with its elements set to the first Count elements from <paramref name="values"/> (一个新<see cref="Vector{T}"/>，其元素设置为来自<paramref name="values"/>首批满足长度的元素).</returns>
        public static Vector<T> CreateRotate<T>(params T[] values) where T : struct {
            return CreateRotate<T>(values, 0, values.Length);
        }

        /// <summary>
        /// Creates a new <see cref="Vector{T}"/> from a from the given <see cref="Func{T, TResult}"/> (从给定 <see cref="Func{T, TResult}"/> 创建一个新的 <see cref="Vector{T}"/> ) .
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="func">A function that gets the value of each element (获取每个元素值的函数). Prototype: `T func(int index)`, `index` is element index.</param>
        /// <returns>A new <see cref="Vector{T}"/> from a from the given <see cref="Func{T, TResult}"/> (一个新<see cref="Vector{T}"/>，其元素来 <see cref="Func{T, TResult}"/>).</returns>
        public static Vector<T> CreateByFunc<T>(Func<int, T> func) where T : struct {
            if (null == func) throw new ArgumentNullException(nameof(func));
            Vector<T> temp = default;
            unsafe {
                Span<T> arr = new Span<T>(&temp, Vector<T>.Count);
                for (int i = 0; i < Vector<T>.Count; ++i) {
                    arr[i] = func(i);
                }
                return Create(arr);
            }
        }

        /// <summary>
        /// Creates a new <see cref="Vector{T}"/> from a from the given <see cref="Func{T1, T2, TResult}"/> (从给定 <see cref="Func{T1, T2, TResult}"/> 创建一个新的 <see cref="Vector{T}"/> ) .
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <typeparam name="TUserdata">Type of <paramref name="userdata"/> (<paramref name="userdata"/>的类型).</typeparam>
        /// <param name="func">A function that gets the value of each element (获取每个元素值的函数). Prototype: `T func(int index, TUserdata userdata)`, `index` is element index.</param>
        /// <param name="userdata">The userdata (用户自定义数据).</param>
        /// <returns>A new <see cref="Vector{T}"/> from a from the given <see cref="Func{T1, T2, TResult}"/> (一个新<see cref="Vector{T}"/>，其元素来 <see cref="Func{T1, T2, TResult}"/>).</returns>
        public static Vector<T> CreateByFunc<T, TUserdata>(Func<int, TUserdata, T> func, TUserdata userdata) where T : struct {
            if (null == func) throw new ArgumentNullException(nameof(func));
            Vector<T> temp = default;
            unsafe {
                Span<T> arr = new Span<T>(&temp, Vector<T>.Count);
                for (int i = 0; i < Vector<T>.Count; ++i) {
                    arr[i] = func(i, userdata);
                }
                return Create(arr);
            }
        }

        /// <summary>
        /// Generate the elements of the <see cref="Vectors{T}.Demo"/> value (生成演示值的各元素).
        /// </summary>
        /// <typeparam name="T">Target type (目标类型).</typeparam>
        /// <param name="index">Element index(元素索引).</param>
        /// <returns>Return element item.</returns>
        public static T GenerateDemoElement<T>(int index) where T : struct {
            T rt = Scalars.GetByDouble<T>(index);
            if (0 == index) {
                rt = Scalars<T>.MinValue;
            } else if (1 == index) {
                rt = Scalars.GetByDouble<T>(-2.3);
            } else if (2 == index) {
                rt = Scalars<T>.MaxValue;
            } else if (3 == index) {
                rt = Scalars<T>.AllBitsSet;
            //} else if (6 == index) {
            //    rt = Scalars<T>.E;
            //} else if (7 == index) {
            //    rt = Scalars<T>.Pi;
            //} else if (8 == index) {
            //    rt = Scalars<T>.Tau;
            }
            if (Scalars<T>.ExponentBits > 0) {
                // Float point number.
                if (4 == index) {
                    rt = Scalars<T>.PositiveInfinity;
                } else if (5 == index) {
                    rt = Scalars<T>.Epsilon;
                }
            } else {
                // Fixed point number.
                if (4 == index) {
                    rt = Scalars.GetByDouble<T>(Scalars<T>.FixedShift);
                } else if (5 == index) {
                    rt = Scalars<T>.FixedOne;
                }
            }
            return rt;
        }

        /// <summary>
        /// Creates a <see cref="Vector{T}"/> whose components are of a specified double value (创建一个 <see cref="Vector{T}"/>，其元素为指定的双精度浮点值).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="src">Source value (源值).</param>
        /// <returns>A new <see cref="Vector{T}"/> with all elements initialized to value (一个新的 <see cref="Vector{T}"/>，其中所有元素已初始化为 <paramref name="value"/> ).</returns>
        public static Vector<T> CreateByDouble<T>(double src) where T : struct {
            return Create(Scalars.GetByDouble<T>(src));
        }

        /// <summary>
        /// Creates a <see cref="Vector{T}"/> from double value `for` loop (创建一个 <see cref="Vector{T}"/>，其元素来自双精度浮点值的`for`循环).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="start">Start value (起始值).</param>
        /// <param name="step">Increments at each step (每一步的增量).</param>
        /// <returns>A new <see cref="Vector{T}"/> from a from double value `for` loop (一个新<see cref="Vector{T}"/>，其元素来自双精度浮点值的`for`循环.</returns>
        public static Vector<T> CreateByDoubleLoop<T>(double start, double step) where T : struct {
            return CreateByFunc(delegate (int index) {
                double src = start + step * index;
                return Scalars.GetByDouble<T>(src);
            });
        }

        /// <summary>
        /// Creates a <see cref="Vector{T}"/> whose components are of a specified integer bits (创建一个 <see cref="Vector{T}"/>，其元素为指定的整数位).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="src">Source value (源值).</param>
        /// <returns>A new <see cref="Vector{T}"/> with all elements initialized to value (一个新的 <see cref="Vector{T}"/>，其中所有元素已初始化为 <paramref name="value"/> ).</returns>
        public static Vector<T> CreateByBits<T>(Int64 src) where T : struct {
            return Create(Scalars.GetByBits<T>(src));
        }

        /// <summary>
        /// [Base] Computes the ones-complement (~) of a vector (计算向量的补数).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="src">The vector whose ones-complement is to be computed (要计算其补数的向量).</param>
        /// <returns>A vector whose elements are the ones-complement of the corresponding elements in <paramref name="src"/> (一个向量，其各元素是 <paramref name="src"/> 相应元素的补数).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Vector<T> BaseOnesComplement<T>(Vector<T> src) where T : struct {
            return ~src;
        }

    }

    /// <summary>
    /// Constants of <see cref="Vector{T}"/> .
    /// </summary>
    /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
    public abstract class Vectors<T>: AbstractVectors<T> where T:struct {
        /// <summary>Value 0 (0的值).</summary>
        public static readonly Vector<T> V0;
        /// <summary>All bit is 1 (所有位都是1的值).</summary>
        public static readonly Vector<T> AllBitsSet;
        // -- Number struct --
        /// <summary>Sign mask (符号掩码).</summary>
        public static readonly Vector<T> SignMask;
        /// <summary>Exponent mask (指数掩码).</summary>
        public static readonly Vector<T> ExponentMask;
        /// <summary>Mantissa mask (尾数掩码).</summary>
        public static readonly Vector<T> MantissaMask;
        /// <summary>Non-sign mask (非符号掩码).</summary>
        public static readonly Vector<T> NonSignMask;
        /// <summary>Non-exponent mask (非指数掩码).</summary>
        public static readonly Vector<T> NonExponentMask;
        /// <summary>Non-mantissa mask (非尾数掩码).</summary>
        public static readonly Vector<T> NonMantissaMask;
        /// <summary>Represents the smallest positive value that is greater than zero (表示大于零的最小正值). When the type is an integer, the value is 1 (当类型为整数时，该值为1).</summary>
        public static readonly Vector<T> Epsilon;
        /// <summary>Represents the largest possible value (表示最大可能值).</summary>
        public static readonly Vector<T> MaxValue;
        /// <summary>Represents the smallest possible value (表示最大可能值).</summary>
        public static readonly Vector<T> MinValue;
        /// <summary>Represents not a number (NaN) (表示“非数(NaN)”的值). When the type is an integer, the value is 0 (当类型为整数时，该值为0).</summary>
        public static readonly Vector<T> NaN;
        /// <summary>Represents negative infinity (表示负无穷). When the type is an integer, the value is 0 (当类型为整数时，该值为0).</summary>
        public static readonly Vector<T> NegativeInfinity;
        /// <summary>Represents positive infinity (表示正无穷). When the type is an integer, the value is 0 (当类型为整数时，该值为0).</summary>
        public static readonly Vector<T> PositiveInfinity;
        // -- Math --
        /// <summary>Normalized number of value 1 (值1的归一化数). When the type is an integer, the value is'<see cref="ElementMaxValue"/>'; Otherwise it's 1 (当类型为整数时，它的值为 `<see cref="ElementMaxValue"/>`; 其他情况下为 1).</summary>
        public static readonly Vector<T> NormOne;
        /// <summary>The fixed point number of the value 1 (值1的定点数). When the type is an integer, the value is'Pow(2, <see cref="ElementFixedShift"/>)'; Otherwise it's 1 (当类型为整数时，它的值为 `Pow(2, <see cref="ElementFixedShift"/>)`; 其他情况下为 1).</summary>
        public static readonly Vector<T> FixedOne;
        /// <summary>Represents the natural logarithmic base, specified by the constant, e (表示自然对数的底，它由常数 e 指定).</summary>
        public static readonly Vector<T> E;
        /// <summary>Represents the ratio of the circumference of a circle to its diameter, specified by the constant, π (表示圆的周长与其直径的比值，由常数 π 指定).</summary>
        public static readonly Vector<T> Pi;
        /// <summary>Represents the number of radians in one turn, specified by the constant, τ (表示转一圈的弧度数，由常量 τ 指定).</summary>
        public static readonly Vector<T> Tau;
        // -- Positive number --
        /// <summary>Value 1 .</summary>
        public static readonly Vector<T> V1;
        /// <summary>Value 2 .</summary>
        public static readonly Vector<T> V2;
        /// <summary>Value 3 .</summary>
        public static readonly Vector<T> V3;
        /// <summary>Value 4 .</summary>
        public static readonly Vector<T> V4;
        /// <summary>Value 5 .</summary>
        public static readonly Vector<T> V5;
        /// <summary>Value 6 .</summary>
        public static readonly Vector<T> V6;
        /// <summary>Value 7 .</summary>
        public static readonly Vector<T> V7;
        /// <summary>Value 8 .</summary>
        public static readonly Vector<T> V8;
        /// <summary>Value 127 (SByte.MaxValue).</summary>
        public static readonly Vector<T> VMaxSByte;
        /// <summary>Value 255 (Byte.MaxValue).</summary>
        public static readonly Vector<T> VMaxByte;
        /// <summary>Value 32767 (Int16.MaxValue) .</summary>
        public static readonly Vector<T> VMaxInt16;
        /// <summary>Value 65535 (UInt16.MaxValue) .</summary>
        public static readonly Vector<T> VMaxUInt16;
        /// <summary>Value 2147483647 (Int32.MaxValue) .</summary>
        public static readonly Vector<T> VMaxInt32;
        /// <summary>Value 4294967295 (UInt32.MaxValue) .</summary>
        public static readonly Vector<T> VMaxUInt32;
        // -- Negative number --
        /// <summary>Value -1 . When the type is unsigned integer, the value is a signed cast value (当类型为无符号整型时，值为带符号强制转换值). Example: '(Byte)(-1)=255' .</summary>
        public static readonly Vector<T> V_1;
        /// <summary>Value -2 .</summary>
        public static readonly Vector<T> V_2;
        /// <summary>Value -3 .</summary>
        public static readonly Vector<T> V_3;
        /// <summary>Value -4 .</summary>
        public static readonly Vector<T> V_4;
        /// <summary>Value -5 .</summary>
        public static readonly Vector<T> V_5;
        /// <summary>Value -6 .</summary>
        public static readonly Vector<T> V_6;
        /// <summary>Value -7 .</summary>
        public static readonly Vector<T> V_7;
        /// <summary>Value -8 .</summary>
        public static readonly Vector<T> V_8;
        /// <summary>Value -128 (SByte.MinValue).</summary>
        public static readonly Vector<T> VMinSByte;
        /// <summary>Value -32768 (Int16.MinValue) .</summary>
        public static readonly Vector<T> VMinInt16;
        /// <summary>Value -2147483648 (Int32.MinValue) .</summary>
        public static readonly Vector<T> VMinInt32;
        // -- Reciprocal number --
        /// <summary>Reciprocal value: 1/127 (SByte.MaxValue). When the type is an integer, it is a fixed point number using the <see cref="ElementFixedShift"/> convention (当类型为整数时, 是使用 <see cref="ElementFixedShift"/> 约定的定点数).</summary>
        public static readonly Vector<T> VReciprocalMaxSByte;
        /// <summary>Reciprocal value: 1/255 (Byte.MaxValue). When the type is an integer, it is a fixed point number using the <see cref="ElementFixedShift"/> convention (当类型为整数时, 是使用 <see cref="ElementFixedShift"/> 约定的定点数).</summary>
        public static readonly Vector<T> VReciprocalMaxByte;
        /// <summary>Reciprocal value: 1/32767 (Int16.MaxValue). When the type is an integer, it is a fixed point number using the <see cref="ElementFixedShift"/> convention (当类型为整数时, 是使用 <see cref="ElementFixedShift"/> 约定的定点数).</summary>
        public static readonly Vector<T> VReciprocalMaxInt16;
        /// <summary>Reciprocal value: 1/65535 (UInt16.MaxValue). When the type is an integer, it is a fixed point number using the <see cref="ElementFixedShift"/> convention (当类型为整数时, 是使用 <see cref="ElementFixedShift"/> 约定的定点数).</summary>
        public static readonly Vector<T> VReciprocalMaxUInt16;
        /// <summary>Reciprocal value: 1/2147483647 (Int32.MaxValue). When the type is an integer, it is a fixed point number using the <see cref="ElementFixedShift"/> convention (当类型为整数时, 是使用 <see cref="ElementFixedShift"/> 约定的定点数).</summary>
        public static readonly Vector<T> VReciprocalMaxInt32;
        /// <summary>Reciprocal value: 1/4294967295 (UInt32.MaxValue). When the type is an integer, it is a fixed point number using the <see cref="ElementFixedShift"/> convention (当类型为整数时, 是使用 <see cref="ElementFixedShift"/> 约定的定点数).</summary>
        public static readonly Vector<T> VReciprocalMaxUInt32;
        // -- Specified value --
        /// <summary>Serial Value (顺序值). e.g. 0, 1, 2, 3 ...</summary>
        public static readonly Vector<T> Serial;
        /// <summary>Serial Value descend (顺序值降序). e.g. (Count-1), (Count-2), ... 2, 1, 0</summary>
        public static readonly Vector<T> SerialDesc;
        /// <summary>Negative serial Value (负数顺序值). e.g. 0, -1, -2, -3 ...</summary>
        public static readonly Vector<T> SerialNegative;
        /// <summary>Demo Value (演示值). It is a value constructed for testing purposes (它是为测试目的而构造的值).</summary>
        public static readonly Vector<T> Demo;
        /// <summary>Serial bit pos mask (顺序位偏移的掩码). The element whose index exceeds the number of bits has a value of 0(索引超过位数的元素值为0). e.g. 1, 2, 4, 8, 0x10 ...</summary>
        public static readonly Vector<T> MaskBitPosSerial;
        /// <summary>Serial bit pos rotate mask (顺序位偏移的旋转掩码). e.g. 1, 2, 4, 8, 0x10 ...</summary>
        public static readonly Vector<T> MaskBitPosSerialRotate;
        /// <summary>Serial bits mask (顺序位集的掩码). The element whose index exceeds the number of bits has a value of all bit set 1(索引超过位数的元素值为所有位都是1的值). e.g. 1, 3, 7, 0xF, 0x1F ...</summary>
        public static readonly Vector<T> MaskBitsSerial;
        /// <summary>Serial bits rotate mask (顺序位集的旋转掩码). e.g. 1, 3, 7, 0xF, 0x1F ...</summary>
        public static readonly Vector<T> MaskBitsSerialRotate;
        /// <summary>Interlaced sign number (交错的符号数值). e.g. 1, -1, 1, -1, 1, -1 ...</summary>
        public static readonly Vector<T> InterlacedSign;
        /// <summary>Interlaced sign number starting with a negative number (负数开头的交错的符号数值). e.g. -1, 1, -1, 1, -1, 1 ...</summary>
        public static readonly Vector<T> InterlacedSignNegative;
        // -- Xyzw --
        /// <summary>Xy - X mask. For a 2-element group, select the mask of the 0th element (对于2个元素的组，选择第0个元素的掩码).</summary>
        public static readonly Vector<T> XyXMask;
        /// <summary>Xy - Y mask. For a 2-element group, select the mask of the 1st element (对于2个元素的组，选择第1个元素的掩码).</summary>
        public static readonly Vector<T> XyYMask;
        /// <summary>Xyzw - X mask. For a 4-element group, select the mask of the 0th element (对于4个元素的组，选择第0个元素的掩码). Alias has <see cref="RgbaRMask"/>.</summary>
        public static readonly Vector<T> XyzwXMask;
        /// <summary>Xyzw - Y mask. For a 4-element group, select the mask of the 1th element (对于4个元素的组，选择第1个元素的掩码). Alias has <see cref="RgbaGMask"/>.</summary>
        public static readonly Vector<T> XyzwYMask;
        /// <summary>Xyzw - Z mask. For a 4-element group, select the mask of the 2th element (对于4个元素的组，选择第2个元素的掩码). Alias has <see cref="RgbaBMask"/>.</summary>
        public static readonly Vector<T> XyzwZMask;
        /// <summary>Xyzw - W mask. For a 4-element group, select the mask of the 3th element (对于4个元素的组，选择第3个元素的掩码). Alias has <see cref="RgbaAMask"/>.</summary>
        public static readonly Vector<T> XyzwWMask;
        /// <summary>Xyzw - Not X mask. For a 4-element group, not select the mask of the 0th element (对于4个元素的组，不选择第0个元素的掩码). Alias has <see cref="RgbaNotRMask"/>.</summary>
        public static readonly Vector<T> XyzwNotXMask;
        /// <summary>Xyzw - Not Y mask. For a 4-element group, not select the mask of the 1th element (对于4个元素的组，不选择第1个元素的掩码). Alias has <see cref="RgbaNotGMask"/>.</summary>
        public static readonly Vector<T> XyzwNotYMask;
        /// <summary>Xyzw - Not Z mask. For a 4-element group, not select the mask of the 2th element (对于4个元素的组，不选择第2个元素的掩码). Alias has <see cref="RgbaNotBMask"/>.</summary>
        public static readonly Vector<T> XyzwNotZMask;
        /// <summary>Xyzw - Not W mask. For a 4-element group, not select the mask of the 3th element (对于4个元素的组，不选择第3个元素的掩码). Alias has <see cref="RgbaNotAMask"/>.</summary>
        public static readonly Vector<T> XyzwNotWMask;
        /// <summary>Xyzw - X is normalized number of value 1 (X 为值1的归一化数).</summary>
        public static readonly Vector<T> XyzwXNormOne;
        /// <summary>Xyzw - Y is normalized number of value 1 (Y 为值1的归一化数).</summary>
        public static readonly Vector<T> XyzwYNormOne;
        /// <summary>Xyzw - Z is normalized number of value 1 (Z 为值1的归一化数).</summary>
        public static readonly Vector<T> XyzwZNormOne;
        /// <summary>Xyzw - W is normalized number of value 1 (W 为值1的归一化数).</summary>
        public static readonly Vector<T> XyzwWNormOne;
        // == Mask array ==
        /// <summary>Bit pos mask array (位偏移掩码的数组). e.g. 1, 2, 4, 8, 0x10 ...</summary>
        private static readonly Vector<Byte>[] MaskBitPosArray;
        /// <summary>Bits mask array (位集掩码的数组). e.g. 0, 1, 3, 7, 0xF, 0x1F ...</summary>
        private static readonly Vector<Byte>[] MaskBitsArray;

        /// <summary>
        /// Static constructor.
        /// </summary>
        static Vectors() {
            V0 = Vectors.Create<T>(ElementV0);
            AllBitsSet = Vectors.Create<T>(ElementAllBitsSet);
            // -- Number struct --
            SignMask = Vectors.Create<T>(ElementSignMask);
            ExponentMask = Vectors.Create<T>(ElementExponentMask);
            MantissaMask = Vectors.Create<T>(ElementMantissaMask);
            NonSignMask = Vectors.Create<T>(ElementNonSignMask);
            NonExponentMask = Vectors.Create<T>(ElementNonExponentMask);
            NonMantissaMask = Vectors.Create<T>(ElementNonMantissaMask);
            Epsilon = Vectors.Create<T>(ElementEpsilon);
            MaxValue = Vectors.Create<T>(ElementMaxValue);
            MinValue = Vectors.Create<T>(ElementMinValue);
            NaN = Vectors.Create<T>(ElementNaN);
            NegativeInfinity = Vectors.Create<T>(ElementNegativeInfinity);
            PositiveInfinity = Vectors.Create<T>(ElementPositiveInfinity);
            // -- Math --
            NormOne = Vectors.Create<T>(ElementNormOne);
            FixedOne = Vectors.Create<T>(ElementFixedOne);
            E = Vectors.Create<T>(ElementE);
            Pi = Vectors.Create<T>(ElementPi);
            Tau = Vectors.Create<T>(ElementTau);
            // -- Positive number --
            V1 = Vectors.Create<T>(ElementV1);
            V2 = Vectors.Create<T>(ElementV2);
            V3 = Vectors.Create<T>(ElementV3);
            V4 = Vectors.Create<T>(ElementV4);
            V5 = Vectors.Create<T>(ElementV5);
            V6 = Vectors.Create<T>(ElementV6);
            V7 = Vectors.Create<T>(ElementV7);
            V8 = Vectors.Create<T>(ElementV8);
            VMaxSByte = Vectors.Create<T>(ElementVMaxSByte);
            VMaxByte = Vectors.Create<T>(ElementVMaxByte);
            VMaxInt16 = Vectors.Create<T>(ElementVMaxInt16);
            VMaxUInt16 = Vectors.Create<T>(ElementVMaxUInt16);
            VMaxInt32 = Vectors.Create<T>(ElementVMaxInt32);
            VMaxUInt32 = Vectors.Create<T>(ElementVMaxUInt32);
            // -- Negative number  --
            V_1 = Vectors.Create<T>(ElementV_1);
            V_2 = Vectors.Create<T>(ElementV_2);
            V_3 = Vectors.Create<T>(ElementV_3);
            V_4 = Vectors.Create<T>(ElementV_4);
            V_5 = Vectors.Create<T>(ElementV_5);
            V_6 = Vectors.Create<T>(ElementV_6);
            V_7 = Vectors.Create<T>(ElementV_7);
            V_8 = Vectors.Create<T>(ElementV_8);
            VMinSByte = Vectors.Create<T>(ElementVMinSByte);
            VMinInt16 = Vectors.Create<T>(ElementVMinInt16);
            VMinInt32 = Vectors.Create<T>(ElementVMinInt32);
            // -- Reciprocal number  --
            VReciprocalMaxSByte = Vectors.Create<T>(ElementVReciprocalMaxSByte);
            VReciprocalMaxByte = Vectors.Create<T>(ElementVReciprocalMaxByte);
            VReciprocalMaxInt16 = Vectors.Create<T>(ElementVReciprocalMaxInt16);
            VReciprocalMaxUInt16 = Vectors.Create<T>(ElementVReciprocalMaxUInt16);
            VReciprocalMaxInt32 = Vectors.Create<T>(ElementVReciprocalMaxInt32);
            VReciprocalMaxUInt32 = Vectors.Create<T>(ElementVReciprocalMaxUInt32);
            // -- Specified value --
            Serial = Vectors.CreateByDoubleLoop<T>(0, 1);
            SerialDesc = Vectors.CreateByDoubleLoop<T>(Vector<T>.Count - 1, -1);
            SerialNegative = Vectors.CreateByDoubleLoop<T>(0, -1);
            Demo = Vectors.CreateByFunc<T>(Vectors.GenerateDemoElement<T>);
            int bitLen = ElementByteSize * 8;
            MaskBitPosSerial = Vectors.CreateByFunc<T>(delegate (int index) {
                long n = 0;
                if (index < bitLen) {
                    n = 1L << index;
                }
                return Scalars.GetByBits<T>(n);
            });
            MaskBitPosSerialRotate = Vectors.CreateByFunc<T>(delegate (int index) {
                int m = index % bitLen;
                long n = 1L << m;
                return Scalars.GetByBits<T>(n);
            });
            MaskBitsSerial = Vectors.CreateByFunc<T>(delegate (int index) {
                int m = Math.Min(index + 1, bitLen);
                return Scalars.GetBitsMask<T>(0, m);
            });
            MaskBitsSerialRotate = Vectors.CreateByFunc<T>(delegate (int index) {
                int m = index % bitLen + 1;
                return Scalars.GetBitsMask<T>(0, m);
            });
            InterlacedSign = Vectors.CreateRotate<T>(ElementV1, ElementV_1);
            InterlacedSignNegative = Vectors.CreateRotate<T>(ElementV_1, ElementV1);
            // -- Xyzw --
            if (true) {
                T o = ElementZero;
                T f = ElementAllBitsSet;
                T n = ElementNormOne;
                XyXMask = Vectors.CreateRotate<T>(f, o);
                XyYMask = Vectors.CreateRotate<T>(o, f);
                XyzwXMask = Vectors.CreateRotate<T>(f, o, o, o);
                XyzwYMask = Vectors.CreateRotate<T>(o, f, o, o);
                XyzwZMask = Vectors.CreateRotate<T>(o, o, f, o);
                XyzwWMask = Vectors.CreateRotate<T>(o, o, o, f);
                XyzwNotXMask = Vectors.BaseOnesComplement(XyzwXMask);
                XyzwNotYMask = Vectors.BaseOnesComplement(XyzwYMask);
                XyzwNotZMask = Vectors.BaseOnesComplement(XyzwZMask);
                XyzwNotWMask = Vectors.BaseOnesComplement(XyzwWMask);
                XyzwXNormOne = Vectors.CreateRotate<T>(n, o, o, o);
                XyzwYNormOne = Vectors.CreateRotate<T>(o, n, o, o);
                XyzwZNormOne = Vectors.CreateRotate<T>(o, o, n, o);
                XyzwWNormOne = Vectors.CreateRotate<T>(o, o, o, n);
            }
            // == Mask array ==
            MaskBitPosArray = Vectors.GetMaskBitPosArray(ElementByteSize);
            MaskBitsArray = Vectors.GetMaskBitsArray(ElementByteSize);
        }

        /// <summary>
        /// Get bit pos mask by index (根据索引获取位偏移掩码). The equivalent of <c>Vectors.Create(Scalars.GetByBits&lt;T&gt;(1L &lt;&lt; index))</c>.
        /// </summary>
        /// <param name="index">The index (索引). The value ranges from 0 to <c>ElementBitSize-1</c> (值的范围是 0 ~ <c>ElementBitSize-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bit pos mask (返回位偏移掩码).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Vector<T> GetMaskBitPos(int index) {
            return ref Unsafe.As<Vector<Byte>, Vector<T>>(ref MaskBitPosArray[index]);
        }

        /// <summary>
        /// Get bit pos mask span (获取位偏移掩码的跨度). Tip: You can use <see cref="Unsafe.As"/> convert its item to <see cref="Vector{T}"/> type (提示: 可以用 <see cref="Unsafe.As"/> 将其中条目转为 <see cref="Vector{T}"/> 类型).
        /// </summary>
        /// <returns>Returns bit pos mask span (返回位偏移掩码的跨度).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlySpan<Vector<Byte>> GetMaskBitPosSpan() {
            return new ReadOnlySpan<Vector<Byte>>(MaskBitPosArray);
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码). The equivalent of <c>Vectors.Create(Scalars.GetBitsMask&lt;T&gt;(0, index))</c>.
        /// </summary>
        /// <param name="index">The index (索引). The value ranges from 0 to <c>ElementBitSize</c> (值的范围是 0 ~ <c>ElementBitSize</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Vector<T> GetMaskBits(int index) {
            return ref Unsafe.As<Vector<Byte>, Vector<T>>(ref MaskBitsArray[index]);
        }

        /// <summary>
        /// Get bits mask span (获取位集掩码的跨度). Tip: You can use <see cref="Unsafe.As"/> convert its item to <see cref="Vector{T}"/> type (提示: 可以用 <see cref="Unsafe.As"/> 将其中条目转为 <see cref="Vector{T}"/> 类型).
        /// </summary>
        /// <returns>Returns bits mask span (返回位集掩码的跨度).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlySpan<Vector<Byte>> GetMaskBitsSpan() {
            return new ReadOnlySpan<Vector<Byte>>(MaskBitsArray);
        }


        /// <summary>Zero (0).</summary>
        public static Vector<T> Zero { get { return V0; } }

        /// <summary>1 bits mask (1位掩码).</summary>
        public static ref readonly Vector<T> MaskBits1 { [MethodImpl(MethodImplOptions.AggressiveInlining)]get { return ref GetMaskBits(1); } }
        /// <summary>2 bits mask (2位掩码).</summary>
        public static ref readonly Vector<T> MaskBits2 { [MethodImpl(MethodImplOptions.AggressiveInlining)]get { return ref GetMaskBits(2); } }
        /// <summary>4 bits mask (4位掩码).</summary>
        public static ref readonly Vector<T> MaskBits4 { [MethodImpl(MethodImplOptions.AggressiveInlining)]get { return ref GetMaskBits(4); } }
        /// <summary>8 bits mask (8位掩码).</summary>
        public static ref readonly Vector<T> MaskBits8 { [MethodImpl(MethodImplOptions.AggressiveInlining)]get { return ref GetMaskBits(8); } }
        /// <summary>16 bits mask (16位掩码).</summary>
        public static ref readonly Vector<T> MaskBits16 { [MethodImpl(MethodImplOptions.AggressiveInlining)]get { return ref GetMaskBits(Math.Min(ElementBitSize, 16)); } }
        /// <summary>32 bits mask (32位掩码).</summary>
        public static ref readonly Vector<T> MaskBits32 { [MethodImpl(MethodImplOptions.AggressiveInlining)]get { return ref GetMaskBits(Math.Min(ElementBitSize, 32)); } }

        /// <summary>Xy - Not X mask. For a 2-element group, not select the mask of the 0th element (对于2个元素的组，不选择第0个元素的掩码).</summary>
        public static ref readonly Vector<T> XyNotXMask { [MethodImpl(MethodImplOptions.AggressiveInlining)]get { return ref XyYMask; } }
        /// <summary>Xy - Not Y mask. For a 2-element group, not select the mask of the 1st element (对于2个元素的组，不选择第1个元素的掩码).</summary>
        public static ref readonly Vector<T> XyNotYMask { [MethodImpl(MethodImplOptions.AggressiveInlining)]get { return ref XyXMask; } }
        /// <summary>Rgba - R mask. For a 4-element group, select the mask of the 0th element (对于4个元素的组，选择第0个元素的掩码). Alias has <see cref="XyzwXMask"/>.</summary>
        public static ref readonly Vector<T> RgbaRMask { [MethodImpl(MethodImplOptions.AggressiveInlining)]get { return ref XyzwXMask; } }
        /// <summary>Rgba - G mask. For a 4-element group, select the mask of the 1th element (对于4个元素的组，选择第1个元素的掩码). Alias has <see cref="XyzwYMask"/>.</summary>
        public static ref readonly Vector<T> RgbaGMask { [MethodImpl(MethodImplOptions.AggressiveInlining)]get { return ref XyzwYMask; } }
        /// <summary>Rgba - B mask. For a 4-element group, select the mask of the 2th element (对于4个元素的组，选择第2个元素的掩码). Alias has <see cref="XyzwZMask"/>.</summary>
        public static ref readonly Vector<T> RgbaBMask { [MethodImpl(MethodImplOptions.AggressiveInlining)]get { return ref XyzwZMask; } }
        /// <summary>Rgba - A mask. For a 4-element group, select the mask of the 3th element (对于4个元素的组，选择第3个元素的掩码). Alias has <see cref="XyzwWMask"/>.</summary>
        public static ref readonly Vector<T> RgbaAMask { [MethodImpl(MethodImplOptions.AggressiveInlining)]get { return ref XyzwWMask; } }
        /// <summary>Rgba - Not R mask. For a 4-element group, not select the mask of the 0th element (对于4个元素的组，不选择第0个元素的掩码). Alias has <see cref="XyzwNotXMask"/>.</summary>
        public static ref readonly Vector<T> RgbaNotRMask { [MethodImpl(MethodImplOptions.AggressiveInlining)]get { return ref XyzwNotXMask; } }
        /// <summary>Rgba - Not G mask. For a 4-element group, not select the mask of the 1th element (对于4个元素的组，不选择第1个元素的掩码). Alias has <see cref="XyzwNotYMask"/>.</summary>
        public static ref readonly Vector<T> RgbaNotGMask { [MethodImpl(MethodImplOptions.AggressiveInlining)]get { return ref XyzwNotYMask; } }
        /// <summary>Rgba - Not B mask. For a 4-element group, not select the mask of the 2th element (对于4个元素的组，不选择第2个元素的掩码). Alias has <see cref="XyzwNotZMask"/>.</summary>
        public static ref readonly Vector<T> RgbaNotBMask { [MethodImpl(MethodImplOptions.AggressiveInlining)]get { return ref XyzwNotZMask; } }
        /// <summary>Rgba - Not A mask. For a 4-element group, not select the mask of the 3th element (对于4个元素的组，不选择第3个元素的掩码). Alias has <see cref="XyzwNotWMask"/>.</summary>
        public static ref readonly Vector<T> RgbaNotAMask { [MethodImpl(MethodImplOptions.AggressiveInlining)]get { return ref XyzwNotWMask; } }
        /// <summary>Rgba - R is normalized number of value 1 (R 为值1的归一化数).</summary>
        public static ref readonly Vector<T> RgbaRNormOne { [MethodImpl(MethodImplOptions.AggressiveInlining)]get { return ref XyzwXNormOne; } }
        /// <summary>Rgba - G is normalized number of value 1 (G 为值1的归一化数).</summary>
        public static ref readonly Vector<T> RgbaGNormOne { [MethodImpl(MethodImplOptions.AggressiveInlining)]get { return ref XyzwYNormOne; } }
        /// <summary>Rgba - B is normalized number of value 1 (B 为值1的归一化数).</summary>
        public static ref readonly Vector<T> RgbaBNormOne { [MethodImpl(MethodImplOptions.AggressiveInlining)]get { return ref XyzwZNormOne; } }
        /// <summary>Rgba - A is normalized number of value 1 (A 为值1的归一化数).</summary>
        public static ref readonly Vector<T> RgbaANormOne { [MethodImpl(MethodImplOptions.AggressiveInlining)]get { return ref XyzwWNormOne; } }

    }
}
