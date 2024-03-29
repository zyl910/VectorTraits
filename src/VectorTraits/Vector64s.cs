﻿using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Impl.Util;

namespace Zyl.VectorTraits {

    /// <summary>
    /// Methods of <see cref="Vector64{T}"/> .
    /// </summary>
    public static partial class Vector64s {
#if NETCOREAPP3_0_OR_GREATER

        // == Mask array ==
        // It takes up too much space to construct a batch of mask arrays for each element type. int/uint/float can share a 4-byte mask, and the total bit length of vector types is fixed. Therefore, arrays such as MaskBitPosArray1B can be shared by multiple element types. (若为每一种元素类型都构造一批掩码数组的话, 太占空间了. 考虑到 int/uint/float 可共用4字节的掩码, 且向量类型的总位长是固定的, 于是 MaskBitPosArray1B 等数组可以给多种元素类型所共用.)

        /// <summary>Bit pos mask array - 1Byte (位偏移掩码的数组 - 1字节). e.g. 1, 2, 4, 8, 0x10 ...</summary>
        private static readonly Vector64<byte>[] MaskBitPosArray1B;
        /// <summary>Bit pos mask array - 2Byte (位偏移掩码的数组 - 2字节). e.g. 1, 2, 4, 8, 0x10 ...</summary>
        private static readonly Vector64<byte>[] MaskBitPosArray2B;
        /// <summary>Bit pos mask array - 4Byte (位偏移掩码的数组 - 4字节). e.g. 1, 2, 4, 8, 0x10 ...</summary>
        private static readonly Vector64<byte>[] MaskBitPosArray4B;
        /// <summary>Bit pos mask array - 8Byte (位偏移掩码的数组 - 8字节). e.g. 1, 2, 4, 8, 0x10 ...</summary>
        private static readonly Vector64<byte>[] MaskBitPosArray8B;
        /// <summary>Bits mask array - 1Byte (位集掩码的数组 - 1字节). e.g. 0, 1, 3, 7, 0xF, 0x1F ...</summary>
        private static readonly Vector64<byte>[] MaskBitsArray1B;
        /// <summary>Bits mask array - 2Byte (位集掩码的数组 - 2字节). e.g. 0, 1, 3, 7, 0xF, 0x1F ...</summary>
        private static readonly Vector64<byte>[] MaskBitsArray2B;
        /// <summary>Bits mask array - 4Byte (位集掩码的数组 - 4字节). e.g. 0, 1, 3, 7, 0xF, 0x1F ...</summary>
        private static readonly Vector64<byte>[] MaskBitsArray4B;
        /// <summary>Bits mask array - 8Byte (位集掩码的数组 - 8字节). e.g. 0, 1, 3, 7, 0xF, 0x1F ...</summary>
        private static readonly Vector64<byte>[] MaskBitsArray8B;

        /// <summary>
        /// Static constructor.
        /// </summary>
        static Vector64s() {
            unchecked {
                long bitpos;
                long bits;
                int i;
                MaskBitPosArray1B = new Vector64<byte>[1 * 8];
                MaskBitPosArray2B = new Vector64<byte>[2 * 8];
                MaskBitPosArray4B = new Vector64<byte>[4 * 8];
                MaskBitPosArray8B = new Vector64<byte>[8 * 8];
                MaskBitsArray1B = new Vector64<byte>[1 * 8 + 1];
                MaskBitsArray2B = new Vector64<byte>[2 * 8 + 1];
                MaskBitsArray4B = new Vector64<byte>[4 * 8 + 1];
                MaskBitsArray8B = new Vector64<byte>[8 * 8 + 1];
                MaskBitsArray1B[0] = Vector64<byte>.Zero;
                MaskBitsArray2B[0] = Vector64<byte>.Zero;
                MaskBitsArray4B[0] = Vector64<byte>.Zero;
                MaskBitsArray8B[0] = Vector64<byte>.Zero;
                bitpos = 1;
                bits = 1;
                for (i = 0; i < MaskBitPosArray8B.Length; ++i) {
                    if (i < MaskBitPosArray1B.Length) {
                        MaskBitPosArray1B[i] = Vector64.Create(Scalars.GetByBits<byte>(bitpos));
                        MaskBitsArray1B[1 + i] = Vector64.Create(Scalars.GetByBits<byte>(bits));
                    }
                    if (i < MaskBitPosArray2B.Length) {
                        MaskBitPosArray2B[i] = Vector64.AsByte(Vector64.Create(Scalars.GetByBits<ushort>(bitpos)));
                        MaskBitsArray2B[1 + i] = Vector64.AsByte(Vector64.Create(Scalars.GetByBits<ushort>(bits)));
                    }
                    if (i < MaskBitPosArray4B.Length) {
                        MaskBitPosArray4B[i] = Vector64.AsByte(Vector64.Create(Scalars.GetByBits<uint>(bitpos)));
                        MaskBitsArray4B[1 + i] = Vector64.AsByte(Vector64.Create(Scalars.GetByBits<uint>(bits)));
                    }
                    if (i < MaskBitPosArray8B.Length) {
                        MaskBitPosArray8B[i] = Vector64.AsByte(Vector64.Create(Scalars.GetByBits<ulong>(bitpos)));
                        MaskBitsArray8B[1 + i] = Vector64.AsByte(Vector64.Create(Scalars.GetByBits<ulong>(bits)));
                    }
                    // next.
                    bitpos <<= 1;
                    bits = bits << 1 | 1;
                }
                if (0 != bits) {
                    // [Debug]
                }
            }
        }

        /// <summary>
        /// Get bit pos mask array (取得位偏移掩码的数组).
        /// </summary>
        /// <param name="byteSize">元素的字节大小 (元素的字节大小).</param>
        /// <returns>Returns bit pos mask array (返回位偏移掩码的数组). An 8-byte array is returned if not found, to avoid returning null (找不到时返回8字节的数组, 这是为了避免返回null).</returns>
        internal static Vector64<byte>[] GetMaskBitPosArray(int byteSize) {
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
        internal static Vector64<byte>[] GetMaskBitsArray(int byteSize) {
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

        // == Vector64 methods ==

        /// <summary>
        /// Creates a new <see cref="Vector64{T}"/> instance with all elements initialized to the specified value (创建新的 <see cref="Vector64{T}"/> 实例，其中所有元素已初始化为指定值).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="value">The value that all elements will be initialized to (所有元素的初始化目标值).</param>
        /// <returns>A new <see cref="Vector64{T}"/> with all elements initialized to value (一个新的 <see cref="Vector64{T}"/>，其中所有元素已初始化为 <paramref name="value"/> ).</returns>
        /// <seealso cref="Vector64.Create{T}(T)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<T> Create<T>(T value) where T : struct {
#if NET7_0_OR_GREATER
            return Vector64.Create(value);
#else
            if (typeof(T) == typeof(float)) {
                return (Vector64<T>)(object)Vector64.Create((float)(object)value);
            } else if (typeof(T) == typeof(double)) {
                return (Vector64<T>)(object)Vector64.Create((double)(object)value);
            } else if (typeof(T) == typeof(sbyte)) {
                return (Vector64<T>)(object)Vector64.Create((sbyte)(object)value);
            } else if (typeof(T) == typeof(short)) {
                return (Vector64<T>)(object)Vector64.Create((short)(object)value);
            } else if (typeof(T) == typeof(int)) {
                return (Vector64<T>)(object)Vector64.Create((int)(object)value);
            } else if (typeof(T) == typeof(long)) {
                return (Vector64<T>)(object)Vector64.Create((long)(object)value);
            } else if (typeof(T) == typeof(byte)) {
                return (Vector64<T>)(object)Vector64.Create((byte)(object)value);
            } else if (typeof(T) == typeof(ushort)) {
                return (Vector64<T>)(object)Vector64.Create((ushort)(object)value);
            } else if (typeof(T) == typeof(uint)) {
                return (Vector64<T>)(object)Vector64.Create((uint)(object)value);
            } else if (typeof(T) == typeof(ulong)) {
                return (Vector64<T>)(object)Vector64.Create((ulong)(object)value);
            } else {
                return (Vector64<T>)(object)Vector64.Create((dynamic)value);
            }
#endif
        }

        /// <summary>
        /// Creates a new <see cref="Vector64{T}"/> from a given array (从给定数组创建一个新的 <see cref="Vector64{T}"/> ).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="values">The array from which the vector is created (用于创建向量的数组).</param>
        /// <returns>A new <see cref="Vector64{T}"/> with its elements set to the first Count elements from <paramref name="values"/> (一个新<see cref="Vector64{T}"/>，其元素设置为来自<paramref name="values"/>首批满足长度的元素).</returns>
        /// <seealso cref="Vector64.Create{T}(T[])"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<T> Create<T>(T[] values) where T : struct {
#if NET7_0_OR_GREATER
            return Vector64.Create(values);
#else
            return Create(values, 0);
#endif
        }

        /// <summary>
        /// Creates a new <see cref="Vector64{T}"/> from a given array starting at a specified index position (于指定索引位置开始，从指定数组创建一个 <see cref="Vector64{T}"/>).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="values">The array from which the vector is created (用于创建向量的数组).</param>
        /// <param name="index">The starting index position from which to create the vector (欲创建向量的起始索引位置).</param>
        /// <returns>A new <see cref="Vector64{T}"/> with its elements set to the first Count elements from <paramref name="values"/> (一个新<see cref="Vector64{T}"/>，其元素设置为来自<paramref name="values"/>首批满足长度的元素).</returns>
        /// <exception cref="IndexOutOfRangeException">The <paramref name="index"/> is less than zero (<paramref name="index"/> 小于零). The length of <paramref name="values"/>, starting from <paramref name="index"/>, is less than <see cref="Vector64{T}.Count"/> (从 <paramref name="index"/> 开始的 <paramref name="values"/> 的长度小于 <see cref="Vector64{T}.Count"/>).</exception>
        /// <seealso cref="Vector64.Create{T}(T[], int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<T> Create<T>(T[] values, int index) where T : struct {
#if NET7_0_OR_GREATER
            return Vector64.Create(values, index);
#else
            if (null == values) throw new ArgumentNullException(nameof(values));
            int idxEnd = index + Vector64<T>.Count;
            if (index < 0 || idxEnd > values.Length) {
                throw new IndexOutOfRangeException(string.Format("Index({0}) was outside the bounds{1} of the array!", index, values.Length));
            }
            return Unsafe.ReadUnaligned<Vector64<T>>(ref Unsafe.As<T, byte>(ref values[index]));
#endif
        }

        /// <summary>
        /// Creates a new <see cref="Vector64{T}"/> from a given read-only span of bytes (根据给定的只读字节跨度构造一个 <see cref="Vector64{T}"/>).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="values">A read-only span of bytes that contains the values to add to the vector (从中创建向量的只读字节跨度).</param>
        /// <returns>A new <see cref="Vector64{T}"/> with its elements set to the first Count elements from <paramref name="values"/> (一个新<see cref="Vector64{T}"/>，其元素设置为来自<paramref name="values"/>首批满足长度的元素).</returns>
        /// <exception cref="IndexOutOfRangeException"><paramref name="values"/> did not contain at least <see cref="Vector64{T}.Count"/> elements (<paramref name="values"/> 的长度小于 <see cref="Vector64{T}.Count"/>).</exception>
        /// <seealso cref="Vector64.Create{T}(ReadOnlySpan{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<T> Create<T>(ReadOnlySpan<byte> values) where T : struct {
            if (values.Length < Vector64<byte>.Count) {
                throw new IndexOutOfRangeException(string.Format("Index was outside the bounds({0}) of the array!", values.Length));
            }
            return Unsafe.ReadUnaligned<Vector64<T>>(ref MemoryMarshal.GetReference(values));
        }

        /// <summary>
        /// Creates a new <see cref="Vector64{T}"/> from a from the given <see cref="ReadOnlySpan{T}"/> (根据给定的 <see cref="ReadOnlySpan{T}"/> 构造一个 <see cref="Vector64{T}"/>).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="values">The readonly span from which the vector is created (从中创建向量的只读跨度).</param>
        /// <returns>A new <see cref="Vector64{T}"/> with its elements set to the first Count elements from <paramref name="values"/> (一个新<see cref="Vector64{T}"/>，其元素设置为来自<paramref name="values"/>首批满足长度的元素).</returns>
        /// <exception cref="IndexOutOfRangeException"><paramref name="values"/> did not contain at least <see cref="Vector64{T}.Count"/> elements (<paramref name="values"/> 的长度小于 <see cref="Vector64{T}.Count"/>).</exception>
        /// <seealso cref="Vector64.Create{T}(ReadOnlySpan{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<T> Create<T>(ReadOnlySpan<T> values) where T : struct {
#if NET7_0_OR_GREATER
            return Vector64.Create(values);
#else
            if (values.Length < Vector64<T>.Count) {
                throw new IndexOutOfRangeException(string.Format("Index was outside the bounds({0}) of the array!", values.Length));
            }
            return Unsafe.ReadUnaligned<Vector64<T>>(ref Unsafe.As<T, byte>(ref MemoryMarshal.GetReference(values)));
#endif // NET7_0_OR_GREATER
        }

        /// <summary>
        /// Creates a new <see cref="Vector64{T}"/> from a from the given <see cref="Span{T}"/> (根据给定的 <see cref="Span{T}"/> 构造一个 <see cref="Vector64{T}"/>).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="values">The span from which the vector is created (从中创建向量的跨度).</param>
        /// <returns>A new <see cref="Vector64{T}"/> with its elements set to the first Count elements from <paramref name="values"/> (一个新<see cref="Vector64{T}"/>，其元素设置为来自<paramref name="values"/>首批满足长度的元素).</returns>
        /// <exception cref="IndexOutOfRangeException"><paramref name="values"/> did not contain at least <see cref="Vector64{T}.Count"/> elements (<paramref name="values"/> 的长度小于 <see cref="Vector64{T}.Count"/>).</exception>
        /// <seealso cref="Vector64.Create{T}(ReadOnlySpan{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<T> Create<T>(Span<T> values) where T : struct {
            if (values.Length < Vector64<T>.Count) {
                throw new IndexOutOfRangeException(string.Format("Index was outside the bounds({0}) of the array!", values.Length));
            }
            return Unsafe.ReadUnaligned<Vector64<T>>(ref Unsafe.As<T, byte>(ref MemoryMarshal.GetReference(values)));
        }

        /// <summary>
        /// Padding creates a new <see cref="Vector64{T}"/> from a given span starting at a specified index position (于指定索引位置开始，从指定跨度补齐创建一个 <see cref="Vector64{T}"/>). The element after values is initialized to 0(values 之后的元素会初始化为0).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="values">The array from which the vector is created (用于创建向量的数组).</param>
        /// <param name="index">Starting index position of valid data in <paramref name="values"/> (<paramref name="values"/> 中有效数据的起始索引位置).</param>
        /// <param name="length">Length of valid data in <paramref name="values"/> (<paramref name="values"/> 中有效数据的长度).</param>
        /// <returns>A new <see cref="Vector64{T}"/> with its elements set to the first Count elements from <paramref name="values"/> (一个新<see cref="Vector64{T}"/>，其元素设置为来自<paramref name="values"/>首批满足长度的元素).</returns>
        /// <exception cref="IndexOutOfRangeException">The <paramref name="index"/> is less than zero (<paramref name="index"/> 小于零). The length of <paramref name="values"/>, starting from <paramref name="index"/>, is less than <see cref="Vector64{T}.Count"/> (从 <paramref name="index"/> 开始的 <paramref name="values"/> 的长度小于 <see cref="Vector64{T}.Count"/>).</exception>
        public static Vector64<T> CreatePadding<T>(T[] values, int index, int length) where T : struct {
            return CreatePadding((ReadOnlySpan<T>)values, index, length);
        }

        /// <summary>
        /// Padding creates a new <see cref="Vector64{T}"/> from a given span starting at a specified index position (于指定索引位置开始，从指定跨度补齐创建一个 <see cref="Vector64{T}"/>). The element after values is initialized to 0(values 之后的元素会初始化为0).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="values">The span from which the vector is created (用于创建向量的跨度).</param>
        /// <param name="index">Starting index position of valid data in <paramref name="values"/> (<paramref name="values"/> 中有效数据的起始索引位置).</param>
        /// <param name="length">Length of valid data in <paramref name="values"/> (<paramref name="values"/> 中有效数据的长度).</param>
        /// <returns>A new <see cref="Vector64{T}"/> with its elements set to the first Count elements from <paramref name="values"/> (一个新<see cref="Vector64{T}"/>，其元素设置为来自<paramref name="values"/>首批满足长度的元素).</returns>
        /// <exception cref="IndexOutOfRangeException">The <paramref name="index"/> is less than zero (<paramref name="index"/> 小于零). The length of <paramref name="values"/>, starting from <paramref name="index"/>, is less than <see cref="Vector64{T}.Count"/> (从 <paramref name="index"/> 开始的 <paramref name="values"/> 的长度小于 <see cref="Vector64{T}.Count"/>).</exception>
        public static Vector64<T> CreatePadding<T>(ReadOnlySpan<T> values, int index, int length) where T : struct {
            int idxEnd = index + length;
            int idx = index;
            if (null == values || values.Length <= 0) return Vector64<T>.Zero;
            if (index < 0 || idxEnd > values.Length) {
                throw new IndexOutOfRangeException(string.Format("Index({0}) was outside the bounds{1} of the array!", index, values.Length));
            }
            Vector64<T> temp = default;
            ref T p = ref Unsafe.As<Vector64<T>, T>(ref temp);
            int m = Math.Min(Vector64<T>.Count, length);
            for (int i = 0; i < m; ++i) {
                p = values[idx];
                ++idx;
                p = ref Unsafe.Add(ref p, 1);
            }
            return temp;
        }

        /// <summary>
        /// Padding creates a new <see cref="Vector64{T}"/> from a given span (从指定跨度补齐创建一个 <see cref="Vector64{T}"/>). The element after values is initialized to 0(values 之后的元素会初始化为0).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="values">The span from which the vector is created (用于创建向量的跨度).</param>
        /// <returns>A new <see cref="Vector64{T}"/> with its elements set to the first Count elements from <paramref name="values"/> (一个新<see cref="Vector64{T}"/>，其元素设置为来自<paramref name="values"/>首批满足长度的元素).</returns>
        public static Vector64<T> CreatePadding<T>(ReadOnlySpan<T> values) where T : struct {
            return CreatePadding<T>(values, 0, values.Length);
        }

        /// <summary>
        /// Padding creates a new <see cref="Vector64{T}"/> from a given array (从给定数组补齐创建一个新的 <see cref="Vector64{T}"/> ). The element after values is initialized to 0(values 之后的元素会初始化为0).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="values">The array from which the vector is created (用于创建向量的数组).</param>
        /// <returns>A new <see cref="Vector64{T}"/> with its elements set to the first Count elements from <paramref name="values"/> (一个新<see cref="Vector64{T}"/>，其元素设置为来自<paramref name="values"/>首批满足长度的元素).</returns>
        public static Vector64<T> CreatePadding<T>(params T[] values) where T : struct {
            return CreatePadding<T>(values, 0, values.Length);
        }

        /// <summary>
        /// Rotate creates a new <see cref="Vector64{T}"/> from a given span starting at a specified index position (于指定索引位置开始，从指定跨度旋转创建一个 <see cref="Vector64{T}"/>).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="values">The array from which the vector is created (用于创建向量的数组).</param>
        /// <param name="index">Starting index position of valid data in <paramref name="values"/> (<paramref name="values"/> 中有效数据的起始索引位置).</param>
        /// <param name="length">Length of valid data in <paramref name="values"/> (<paramref name="values"/> 中有效数据的长度).</param>
        /// <returns>A new <see cref="Vector64{T}"/> with its elements set to the first Count elements from <paramref name="values"/> (一个新<see cref="Vector64{T}"/>，其元素设置为来自<paramref name="values"/>首批满足长度的元素).</returns>
        /// <exception cref="IndexOutOfRangeException">The <paramref name="index"/> is less than zero (<paramref name="index"/> 小于零). The length of <paramref name="values"/>, starting from <paramref name="index"/>, is less than <see cref="Vector64{T}.Count"/> (从 <paramref name="index"/> 开始的 <paramref name="values"/> 的长度小于 <see cref="Vector64{T}.Count"/>).</exception>
        public static Vector64<T> CreateRotate<T>(T[] values, int index, int length) where T : struct {
            return CreateRotate((ReadOnlySpan<T>)values, index, length);
        }

        /// <summary>
        /// Rotate creates a new <see cref="Vector64{T}"/> from a given span starting at a specified index position (于指定索引位置开始，从指定跨度旋转创建一个 <see cref="Vector64{T}"/>).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="values">The span from which the vector is created (用于创建向量的跨度).</param>
        /// <param name="index">Starting index position of valid data in <paramref name="values"/> (<paramref name="values"/> 中有效数据的起始索引位置).</param>
        /// <param name="length">Length of valid data in <paramref name="values"/> (<paramref name="values"/> 中有效数据的长度).</param>
        /// <returns>A new <see cref="Vector64{T}"/> with its elements set to the first Count elements from <paramref name="values"/> (一个新<see cref="Vector64{T}"/>，其元素设置为来自<paramref name="values"/>首批满足长度的元素).</returns>
        /// <exception cref="IndexOutOfRangeException">The <paramref name="index"/> is less than zero (<paramref name="index"/> 小于零). The length of <paramref name="values"/>, starting from <paramref name="index"/>, is less than <see cref="Vector64{T}.Count"/> (从 <paramref name="index"/> 开始的 <paramref name="values"/> 的长度小于 <see cref="Vector64{T}.Count"/>).</exception>
        public static Vector64<T> CreateRotate<T>(ReadOnlySpan<T> values, int index, int length) where T : struct {
            int idxEnd = index + length;
            int idx = index;
            if (null == values || values.Length <= 0) return Vector64<T>.Zero;
            if (index < 0 || idxEnd > values.Length) {
                throw new IndexOutOfRangeException(string.Format("Index({0}) was outside the bounds{1} of the array!", index, values.Length));
            }
            UnsafeUtil.SkipInit(out Vector64<T> temp);
            ref T p = ref Unsafe.As<Vector64<T>, T>(ref temp);
            for (int i = 0; i < Vector64<T>.Count; ++i) {
                p = values[idx];
                ++idx;
                if (idx >= idxEnd) idx = index;
                p = ref Unsafe.Add(ref p, 1);
            }
            return temp;
        }

        /// <summary>
        /// Rotate creates a new <see cref="Vector64{T}"/> from a given span starting at a specified index position (于指定索引位置开始，从指定跨度旋转创建一个 <see cref="Vector64{T}"/>).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="values">The span from which the vector is created (用于创建向量的跨度).</param>
        /// <returns>A new <see cref="Vector64{T}"/> with its elements set to the first Count elements from <paramref name="values"/> (一个新<see cref="Vector64{T}"/>，其元素设置为来自<paramref name="values"/>首批满足长度的元素).</returns>
        public static Vector64<T> CreateRotate<T>(ReadOnlySpan<T> values) where T : struct {
            return CreateRotate<T>(values, 0, values.Length);
        }

        /// <summary>
        /// Rotate creates a new <see cref="Vector64{T}"/> from a given array (从给定数组旋转创建一个新的 <see cref="Vector64{T}"/> ).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="values">The array from which the vector is created (用于创建向量的数组).</param>
        /// <returns>A new <see cref="Vector64{T}"/> with its elements set to the first Count elements from <paramref name="values"/> (一个新<see cref="Vector64{T}"/>，其元素设置为来自<paramref name="values"/>首批满足长度的元素).</returns>
        public static Vector64<T> CreateRotate<T>(params T[] values) where T : struct {
            return CreateRotate<T>(values, 0, values.Length);
        }

        /// <summary>
        /// Creates a new <see cref="Vector64{T}"/> from a from the given <see cref="Func{T, TResult}"/> (从给定 <see cref="Func{T, TResult}"/> 创建一个新的 <see cref="Vector64{T}"/> ) .
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="func">A function that gets the value of each element (获取每个元素值的函数). Prototype: `T func(int index)`, `index` is element index.</param>
        /// <returns>A new <see cref="Vector64{T}"/> from a from the given <see cref="Func{T, TResult}"/> (一个新<see cref="Vector64{T}"/>，其元素来 <see cref="Func{T, TResult}"/>).</returns>
        public static Vector64<T> CreateByFunc<T>(Func<int, T> func) where T : struct {
            if (null == func) throw new ArgumentNullException(nameof(func));
            UnsafeUtil.SkipInit(out Vector64<T> temp);
            ref T p = ref Unsafe.As<Vector64<T>, T>(ref temp);
            for (int i = 0; i < Vector64<T>.Count; ++i) {
                p = func(i);
                p = ref Unsafe.Add(ref p, 1);
            }
            return temp;
        }

        /// <summary>
        /// Creates a new <see cref="Vector64{T}"/> from a from the given <see cref="Func{T1, T2, TResult}"/> (从给定 <see cref="Func{T1, T2, TResult}"/> 创建一个新的 <see cref="Vector64{T}"/> ) .
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <typeparam name="TUserdata">Type of <paramref name="userdata"/> (<paramref name="userdata"/>的类型).</typeparam>
        /// <param name="func">A function that gets the value of each element (获取每个元素值的函数). Prototype: `T func(int index, TUserdata userdata)`, `index` is element index.</param>
        /// <param name="userdata">The userdata (用户自定义数据).</param>
        /// <returns>A new <see cref="Vector64{T}"/> from a from the given <see cref="Func{T1, T2, TResult}"/> (一个新<see cref="Vector64{T}"/>，其元素来 <see cref="Func{T1, T2, TResult}"/>).</returns>
        public static Vector64<T> CreateByFunc<T, TUserdata>(Func<int, TUserdata, T> func, TUserdata userdata) where T : struct {
            if (null == func) throw new ArgumentNullException(nameof(func));
            UnsafeUtil.SkipInit(out Vector64<T> temp);
            ref T p = ref Unsafe.As<Vector64<T>, T>(ref temp);
            for (int i = 0; i < Vector64<T>.Count; ++i) {
                p = func(i, userdata);
                p = ref Unsafe.Add(ref p, 1);
            }
            return temp;
        }

        /// <summary>
        /// Creates a <see cref="Vector64{T}"/> whose components are of a specified double value (创建一个 <see cref="Vector64{T}"/>，其元素为指定的双精度浮点值).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="src">Source value (源值).</param>
        /// <returns>A new <see cref="Vector64{T}"/> with all elements initialized to value (一个新的 <see cref="Vector64{T}"/>，其中所有元素已初始化为 <paramref name="src"/> ).</returns>
        public static Vector64<T> CreateByDouble<T>(double src) where T : struct {
            return Create(Scalars.GetByDouble<T>(src));
        }

        /// <summary>
        /// Creates a <see cref="Vector64{T}"/> from double value `for` loop (创建一个 <see cref="Vector64{T}"/>，其元素来自双精度浮点值的`for`循环).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="start">Start value (起始值).</param>
        /// <param name="step">Increments at each step (每一步的增量).</param>
        /// <returns>A new <see cref="Vector64{T}"/> from a from double value `for` loop (一个新<see cref="Vector64{T}"/>，其元素来自双精度浮点值的`for`循环.</returns>
        public static Vector64<T> CreateByDoubleLoop<T>(double start, double step) where T : struct {
            return CreateByFunc(delegate (int index) {
                double src = start + step * index;
                return Scalars.GetByDouble<T>(src);
            });
        }

        /// <summary>
        /// Creates a <see cref="Vector64{T}"/> whose components are of a specified integer bits (创建一个 <see cref="Vector64{T}"/>，其元素为指定的整数位).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="src">Source value (源值).</param>
        /// <returns>A new <see cref="Vector64{T}"/> with all elements initialized to value (一个新的 <see cref="Vector64{T}"/>，其中所有元素已初始化为 <paramref name="src"/> ).</returns>
        public static Vector64<T> CreateByBits<T>(long src) where T : struct {
            return Create(Scalars.GetByBits<T>(src));
        }

        /// <summary>
        /// [Base] Computes the ones-complement (~) of a vector (计算向量的补数).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="src">The vector whose ones-complement is to be computed (要计算其补数的向量).</param>
        /// <returns>A vector whose elements are the ones-complement of the corresponding elements in <paramref name="src"/> (一个向量，其各元素是 <paramref name="src"/> 相应元素的补数).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Vector64<T> BaseOnesComplement<T>(Vector64<T> src) where T : struct {
#if NET7_0_OR_GREATER
            return ~src;
#else
            ref ulong p = ref Unsafe.As<Vector64<T>, ulong>(ref src);
            p = ~p;
            return src;
#endif // NET7_0_OR_GREATER
        }

#endif
    }

    /// <summary>
    /// Constants of <see cref="Vector64{T}"/> .
    /// </summary>
    /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
    public abstract class Vector64s<T> : AbstractVectors<T> where T : struct {
#if NETCOREAPP3_0_OR_GREATER
        // -- Number struct --
        /// <summary>Sign mask (符号掩码).</summary>
        public static readonly Vector64<T> SignMask;
        /// <summary>Exponent mask (指数掩码).</summary>
        public static readonly Vector64<T> ExponentMask;
        /// <summary>Mantissa mask (尾数掩码).</summary>
        public static readonly Vector64<T> MantissaMask;
        /// <summary>Non-sign mask (非符号掩码).</summary>
        public static readonly Vector64<T> NonSignMask;
        /// <summary>Non-exponent mask (非指数掩码).</summary>
        public static readonly Vector64<T> NonExponentMask;
        /// <summary>Non-mantissa mask (非尾数掩码).</summary>
        public static readonly Vector64<T> NonMantissaMask;
        /// <summary>Represents the smallest positive value that is greater than zero (表示大于零的最小正值). When the type is an integer, the value is 1 (当类型为整数时，该值为1).</summary>
        public static readonly Vector64<T> Epsilon;
        /// <summary>Represents the largest possible value (表示最大可能值).</summary>
        public static readonly Vector64<T> MaxValue;
        /// <summary>Represents the smallest possible value (表示最小可能值).</summary>
        public static readonly Vector64<T> MinValue;
        /// <summary>Represents not a number (NaN) (表示“非数(NaN)”的值). When the type is an integer, the value is 0 (当类型为整数时，该值为0).</summary>
        public static readonly Vector64<T> NaN;
        /// <summary>Represents negative infinity (表示负无穷). When the type is an integer, the value is 0 (当类型为整数时，该值为0).</summary>
        public static readonly Vector64<T> NegativeInfinity;
        /// <summary>Represents positive infinity (表示正无穷). When the type is an integer, the value is 0 (当类型为整数时，该值为0).</summary>
        public static readonly Vector64<T> PositiveInfinity;
        // -- Math --
        /// <summary>Normalized number of value 1 (值1的归一化数). When the type is an integer, the value is'<see cref="AbstractVectors{T}.ElementMaxValue"/>'; Otherwise it's 1 (当类型为整数时，它的值为 `<see cref="AbstractVectors{T}.ElementMaxValue"/>`; 其他情况下为 1).</summary>
        public static readonly Vector64<T> NormOne;
        /// <summary>The fixed point number of the value 1 (值1的定点数). When the type is an integer, the value is'Pow(2, <see cref="AbstractVectors{T}.ElementFixedShift"/>)'; Otherwise it's 1 (当类型为整数时，它的值为 `Pow(2, <see cref="AbstractVectors{T}.ElementFixedShift"/>)`; 其他情况下为 1).</summary>
        public static readonly Vector64<T> FixedOne;
        /// <summary>Represents the natural logarithmic base, specified by the constant, e (表示自然对数的底，它由常数 e 指定).</summary>
        public static readonly Vector64<T> E;
        /// <summary>Represents the ratio of the circumference of a circle to its diameter, specified by the constant, π (表示圆的周长与其直径的比值，由常数 π 指定).</summary>
        public static readonly Vector64<T> Pi;
        /// <summary>Represents the number of radians in one turn, specified by the constant, τ (表示转一圈的弧度数，由常量 τ 指定).</summary>
        public static readonly Vector64<T> Tau;
        // -- Positive number --
        /// <summary>Value 1 .</summary>
        public static readonly Vector64<T> V1;
        /// <summary>Value 2 .</summary>
        public static readonly Vector64<T> V2;
        /// <summary>Value 3 .</summary>
        public static readonly Vector64<T> V3;
        /// <summary>Value 4 .</summary>
        public static readonly Vector64<T> V4;
        /// <summary>Value 5 .</summary>
        public static readonly Vector64<T> V5;
        /// <summary>Value 6 .</summary>
        public static readonly Vector64<T> V6;
        /// <summary>Value 7 .</summary>
        public static readonly Vector64<T> V7;
        /// <summary>Value 8 .</summary>
        public static readonly Vector64<T> V8;
        /// <summary>Value 127 (sbyte.MaxValue).</summary>
        public static readonly Vector64<T> VMaxSByte;
        /// <summary>Value 255 (byte.MaxValue).</summary>
        public static readonly Vector64<T> VMaxByte;
        /// <summary>Value 32767 (short.MaxValue) .</summary>
        public static readonly Vector64<T> VMaxInt16;
        /// <summary>Value 65535 (ushort.MaxValue) .</summary>
        public static readonly Vector64<T> VMaxUInt16;
        /// <summary>Value 2147483647 (int.MaxValue) .</summary>
        public static readonly Vector64<T> VMaxInt32;
        /// <summary>Value 4294967295 (uint.MaxValue) .</summary>
        public static readonly Vector64<T> VMaxUInt32;
        // -- Negative number --
        /// <summary>Value -1 . When the type is unsigned integer, the value is a signed cast value (当类型为无符号整型时，值为有符号强制转换值). Example: '(byte)(-1)=255' .</summary>
        public static readonly Vector64<T> V_1;
        /// <summary>Value -2 .</summary>
        public static readonly Vector64<T> V_2;
        /// <summary>Value -3 .</summary>
        public static readonly Vector64<T> V_3;
        /// <summary>Value -4 .</summary>
        public static readonly Vector64<T> V_4;
        /// <summary>Value -5 .</summary>
        public static readonly Vector64<T> V_5;
        /// <summary>Value -6 .</summary>
        public static readonly Vector64<T> V_6;
        /// <summary>Value -7 .</summary>
        public static readonly Vector64<T> V_7;
        /// <summary>Value -8 .</summary>
        public static readonly Vector64<T> V_8;
        /// <summary>Value -128 (sbyte.MinValue).</summary>
        public static readonly Vector64<T> VMinSByte;
        /// <summary>Value -32768 (short.MinValue) .</summary>
        public static readonly Vector64<T> VMinInt16;
        /// <summary>Value -2147483648 (int.MinValue) .</summary>
        public static readonly Vector64<T> VMinInt32;
        // -- Reciprocal number --
        /// <summary>Reciprocal value: 1/127 (sbyte.MaxValue). When the type is an integer, it is a fixed point number using the <see cref="AbstractVectors{T}.ElementFixedShift"/> convention (当类型为整数时, 是使用 <see cref="AbstractVectors{T}.ElementFixedShift"/> 约定的定点数).</summary>
        public static readonly Vector64<T> VReciprocalMaxSByte;
        /// <summary>Reciprocal value: 1/255 (byte.MaxValue). When the type is an integer, it is a fixed point number using the <see cref="AbstractVectors{T}.ElementFixedShift"/> convention (当类型为整数时, 是使用 <see cref="AbstractVectors{T}.ElementFixedShift"/> 约定的定点数).</summary>
        public static readonly Vector64<T> VReciprocalMaxByte;
        /// <summary>Reciprocal value: 1/32767 (short.MaxValue). When the type is an integer, it is a fixed point number using the <see cref="AbstractVectors{T}.ElementFixedShift"/> convention (当类型为整数时, 是使用 <see cref="AbstractVectors{T}.ElementFixedShift"/> 约定的定点数).</summary>
        public static readonly Vector64<T> VReciprocalMaxInt16;
        /// <summary>Reciprocal value: 1/65535 (ushort.MaxValue). When the type is an integer, it is a fixed point number using the <see cref="AbstractVectors{T}.ElementFixedShift"/> convention (当类型为整数时, 是使用 <see cref="AbstractVectors{T}.ElementFixedShift"/> 约定的定点数).</summary>
        public static readonly Vector64<T> VReciprocalMaxUInt16;
        /// <summary>Reciprocal value: 1/2147483647 (int.MaxValue). When the type is an integer, it is a fixed point number using the <see cref="AbstractVectors{T}.ElementFixedShift"/> convention (当类型为整数时, 是使用 <see cref="AbstractVectors{T}.ElementFixedShift"/> 约定的定点数).</summary>
        public static readonly Vector64<T> VReciprocalMaxInt32;
        /// <summary>Reciprocal value: 1/4294967295 (uint.MaxValue). When the type is an integer, it is a fixed point number using the <see cref="AbstractVectors{T}.ElementFixedShift"/> convention (当类型为整数时, 是使用 <see cref="AbstractVectors{T}.ElementFixedShift"/> 约定的定点数).</summary>
        public static readonly Vector64<T> VReciprocalMaxUInt32;
        // -- Specified value --
        /// <summary>Serial Value (顺序值). e.g. 0, 1, 2, 3 ...</summary>
        public static readonly Vector64<T> Serial;
        /// <summary>Serial Value descend (顺序值降序). e.g. (Count-1), (Count-2), ... 2, 1, 0</summary>
        public static readonly Vector64<T> SerialDesc;
        /// <summary>Negative serial Value (负数顺序值). e.g. 0, -1, -2, -3 ...</summary>
        public static readonly Vector64<T> SerialNegative;
        /// <summary>Demo Value (演示值). It is a value constructed for testing purposes (它是为测试目的而构造的值).</summary>
        public static readonly Vector64<T> Demo;
        /// <summary>NaN Demo Value (NaN演示值). It is a value constructed for testing purposes (它是为测试目的而构造的值).</summary>
        public static readonly Vector64<T> DemoNaN;
        /// <summary>NaN Demo Value 2 (NaN演示值2). It is a value constructed for testing purposes (它是为测试目的而构造的值).</summary>
        public static readonly Vector64<T> DemoNaN2;
        /// <summary>Serial bit pos mask (顺序位偏移的掩码). The element whose index exceeds the number of bits has a value of 0(索引超过位数的元素值为0). e.g. 1, 2, 4, 8, 0x10 ...</summary>
        public static readonly Vector64<T> MaskBitPosSerial;
        /// <summary>Serial bit pos rotate mask (顺序位偏移的旋转掩码). e.g. 1, 2, 4, 8, 0x10, ... 1, 2, 4, 8, 0x10, ...</summary>
        public static readonly Vector64<T> MaskBitPosSerialRotate;
        /// <summary>Serial bits mask (顺序位集的掩码). The element whose index exceeds the number of bits has a value of all bit set 1(索引超过位数的元素值为所有位都是1的值). e.g. 1, 3, 7, 0xF, 0x1F ...</summary>
        public static readonly Vector64<T> MaskBitsSerial;
        /// <summary>Serial bits rotate mask (顺序位集的旋转掩码). e.g. 1, 3, 7, 0xF, 0x1F ...</summary>
        public static readonly Vector64<T> MaskBitsSerialRotate;
        /// <summary>Interlaced sign number (交错的符号数值). e.g. 1, -1, 1, -1, 1, -1 ...</summary>
        public static readonly Vector64<T> InterlacedSign;
        /// <summary>Interlaced sign number starting with a negative number (负数开头的交错的符号数值). e.g. -1, 1, -1, 1, -1, 1 ...</summary>
        public static readonly Vector64<T> InterlacedSignNegative;
        // -- Xy --
        /// <summary>Xy - Address 0 mask. For a 2-element group, select the mask of the address 0th element (对于2个元素的组，选择地址为第0个元素的掩码).</summary>
        public static readonly Vector64<T> XyAddress0Mask;
        /// <summary>Xy - Address 0 mask. For a 2-element group, select the mask of the address 1st element (对于2个元素的组，选择地址为第1个元素的掩码).</summary>
        public static readonly Vector64<T> XyAddress1Mask;
        /// <summary>Xy - Address 0 is normalized number of value 1 (地址0为 值1的归一化数).</summary>
        public static readonly Vector64<T> XyAddress0NormOne;
        /// <summary>Xy - Address 1 is normalized number of value 1 (地址1为 值1的归一化数).</summary>
        public static readonly Vector64<T> XyAddress1NormOne;
        /// <summary>Xy - X mask. For a 2-element group, select the mask of the position 0th element (对于2个元素的组，选择位置为第0个元素的掩码).</summary>
        public static readonly Vector64<T> XyXMask;
        /// <summary>Xy - Y mask. For a 2-element group, select the mask of the position 1st element (对于2个元素的组，选择位置为第1个元素的掩码).</summary>
        public static readonly Vector64<T> XyYMask;
        /// <summary>Xy - X is normalized number of value 1 (X为 值1的归一化数).</summary>
        public static readonly Vector64<T> XyXNormOne;
        /// <summary>Xy - Y is normalized number of value 1 (Y为 值1的归一化数).</summary>
        public static readonly Vector64<T> XyYNormOne;
        // -- Xyzw --
        /// <summary>Xyzw - Address 0 mask. For a 4-element group, select the mask of the address 0th element (对于4个元素的组，选择地址为第0个元素的掩码).</summary>
        public static readonly Vector64<T> XyzwAddress0Mask;
        /// <summary>Xyzw - Address 1 mask. For a 4-element group, select the mask of the address 0th element (对于4个元素的组，选择地址为第1个元素的掩码).</summary>
        public static readonly Vector64<T> XyzwAddress1Mask;
        /// <summary>Xyzw - Address 2 mask. For a 4-element group, select the mask of the address 0th element (对于4个元素的组，选择地址为第2个元素的掩码).</summary>
        public static readonly Vector64<T> XyzwAddress2Mask;
        /// <summary>Xyzw - Address 3 mask. For a 4-element group, select the mask of the address 0th element (对于4个元素的组，选择地址为第3个元素的掩码).</summary>
        public static readonly Vector64<T> XyzwAddress3Mask;
        /// <summary>Xyzw - Address 0 is normalized number of value 1 (地址0为 值1的归一化数).</summary>
        public static readonly Vector64<T> XyzwAddress0NormOne;
        /// <summary>Xyzw - Address 1 is normalized number of value 1 (地址1为 值1的归一化数).</summary>
        public static readonly Vector64<T> XyzwAddress1NormOne;
        /// <summary>Xyzw - Address 2 is normalized number of value 1 (地址2为 值1的归一化数).</summary>
        public static readonly Vector64<T> XyzwAddress2NormOne;
        /// <summary>Xyzw - Address 3 is normalized number of value 1 (地址3为 值1的归一化数).</summary>
        public static readonly Vector64<T> XyzwAddress3NormOne;
        /// <summary>Xyzw - X mask. For a 4-element group, select the mask of the position 0th element (对于4个元素的组，选择位置为第0个元素的掩码).</summary>
        public static readonly Vector64<T> XyzwXMask;
        /// <summary>Xyzw - Y mask. For a 4-element group, select the mask of the position 1th element (对于4个元素的组，选择位置为第1个元素的掩码).</summary>
        public static readonly Vector64<T> XyzwYMask;
        /// <summary>Xyzw - Z mask. For a 4-element group, select the mask of the position 2th element (对于4个元素的组，选择位置为第2个元素的掩码).</summary>
        public static readonly Vector64<T> XyzwZMask;
        /// <summary>Xyzw - W mask. For a 4-element group, select the mask of the position 3th element (对于4个元素的组，选择位置为第3个元素的掩码).</summary>
        public static readonly Vector64<T> XyzwWMask;
        /// <summary>Xyzw - X is normalized number of value 1 (X为 值1的归一化数).</summary>
        public static readonly Vector64<T> XyzwXNormOne;
        /// <summary>Xyzw - Y is normalized number of value 1 (Y为 值1的归一化数).</summary>
        public static readonly Vector64<T> XyzwYNormOne;
        /// <summary>Xyzw - Z is normalized number of value 1 (Z为 值1的归一化数).</summary>
        public static readonly Vector64<T> XyzwZNormOne;
        /// <summary>Xyzw - W is normalized number of value 1 (W为 值1的归一化数).</summary>
        public static readonly Vector64<T> XyzwWNormOne;
        // == Mask array ==
        /// <summary>Bit pos mask array (位偏移掩码的数组). e.g. 1, 2, 4, 8, 0x10 ...</summary>
        private static readonly Vector64<byte>[] MaskBitPosArray;
        /// <summary>Bits mask array (位集掩码的数组). e.g. 0, 1, 3, 7, 0xF, 0x1F ...</summary>
        private static readonly Vector64<byte>[] MaskBitsArray;

        /// <summary>
        /// Static constructor.
        /// </summary>
        static Vector64s() {
            // -- Number struct --
            SignMask = Vector64s.Create<T>(ElementSignMask);
            ExponentMask = Vector64s.Create<T>(ElementExponentMask);
            MantissaMask = Vector64s.Create<T>(ElementMantissaMask);
            NonSignMask = Vector64s.Create<T>(ElementNonSignMask);
            NonExponentMask = Vector64s.Create<T>(ElementNonExponentMask);
            NonMantissaMask = Vector64s.Create<T>(ElementNonMantissaMask);
            Epsilon = Vector64s.Create<T>(ElementEpsilon);
            MaxValue = Vector64s.Create<T>(ElementMaxValue);
            MinValue = Vector64s.Create<T>(ElementMinValue);
            NaN = Vector64s.Create<T>(ElementNaN);
            NegativeInfinity = Vector64s.Create<T>(ElementNegativeInfinity);
            PositiveInfinity = Vector64s.Create<T>(ElementPositiveInfinity);
            // -- Math --
            NormOne = Vector64s.Create<T>(ElementNormOne);
            FixedOne = Vector64s.Create<T>(ElementFixedOne);
            E = Vector64s.Create<T>(ElementE);
            Pi = Vector64s.Create<T>(ElementPi);
            Tau = Vector64s.Create<T>(ElementTau);
            // -- Positive number --
            V1 = Vector64s.Create<T>(ElementV1);
            V2 = Vector64s.Create<T>(ElementV2);
            V3 = Vector64s.Create<T>(ElementV3);
            V4 = Vector64s.Create<T>(ElementV4);
            V5 = Vector64s.Create<T>(ElementV5);
            V6 = Vector64s.Create<T>(ElementV6);
            V7 = Vector64s.Create<T>(ElementV7);
            V8 = Vector64s.Create<T>(ElementV8);
            VMaxSByte = Vector64s.Create<T>(ElementVMaxSByte);
            VMaxByte = Vector64s.Create<T>(ElementVMaxByte);
            VMaxInt16 = Vector64s.Create<T>(ElementVMaxInt16);
            VMaxUInt16 = Vector64s.Create<T>(ElementVMaxUInt16);
            VMaxInt32 = Vector64s.Create<T>(ElementVMaxInt32);
            VMaxUInt32 = Vector64s.Create<T>(ElementVMaxUInt32);
            // -- Negative number  --
            V_1 = Vector64s.Create<T>(ElementV_1);
            V_2 = Vector64s.Create<T>(ElementV_2);
            V_3 = Vector64s.Create<T>(ElementV_3);
            V_4 = Vector64s.Create<T>(ElementV_4);
            V_5 = Vector64s.Create<T>(ElementV_5);
            V_6 = Vector64s.Create<T>(ElementV_6);
            V_7 = Vector64s.Create<T>(ElementV_7);
            V_8 = Vector64s.Create<T>(ElementV_8);
            VMinSByte = Vector64s.Create<T>(ElementVMinSByte);
            VMinInt16 = Vector64s.Create<T>(ElementVMinInt16);
            VMinInt32 = Vector64s.Create<T>(ElementVMinInt32);
            // -- Reciprocal number  --
            VReciprocalMaxSByte = Vector64s.Create<T>(ElementVReciprocalMaxSByte);
            VReciprocalMaxByte = Vector64s.Create<T>(ElementVReciprocalMaxByte);
            VReciprocalMaxInt16 = Vector64s.Create<T>(ElementVReciprocalMaxInt16);
            VReciprocalMaxUInt16 = Vector64s.Create<T>(ElementVReciprocalMaxUInt16);
            VReciprocalMaxInt32 = Vector64s.Create<T>(ElementVReciprocalMaxInt32);
            VReciprocalMaxUInt32 = Vector64s.Create<T>(ElementVReciprocalMaxUInt32);
            // -- Specified value --
            Serial = Vector64s.CreateByDoubleLoop<T>(0, 1);
            SerialDesc = Vector64s.CreateByDoubleLoop<T>(Vector64<T>.Count - 1, -1);
            SerialNegative = Vector64s.CreateByDoubleLoop<T>(0, -1);
            Demo = Vector64s.CreateByFunc<T>(Vectors.GenerateDemoElement<T>);
            DemoNaN = Vector64s.CreateRotate<T>(ElementNaN, ElementNegativeInfinity, ElementSignMask, ElementPositiveInfinity, ElementMaxValue, ElementMinValue, ElementV6, ElementV7);
            DemoNaN2 = Vector64s.CreateRotate<T>(ElementPositiveInfinity, ElementNaN, ElementNegativeInfinity, ElementSignMask, ElementV_4, ElementMaxValue, ElementMinValue, ElementV_7);
            int bitLen = ElementByteSize * 8;
            MaskBitPosSerial = Vector64s.CreateByFunc<T>(delegate (int index) {
                long n = 0;
                if (index < bitLen) {
                    n = 1L << index;
                }
                return Scalars.GetByBits<T>(n);
            });
            MaskBitPosSerialRotate = Vector64s.CreateByFunc<T>(delegate (int index) {
                int m = index % bitLen;
                long n = 1L << m;
                return Scalars.GetByBits<T>(n);
            });
            MaskBitsSerial = Vector64s.CreateByFunc<T>(delegate (int index) {
                int m = Math.Min(index + 1, bitLen);
                return Scalars.GetBitsMask<T>(0, m);
            });
            MaskBitsSerialRotate = Vector64s.CreateByFunc<T>(delegate (int index) {
                int m = index % bitLen + 1;
                return Scalars.GetBitsMask<T>(0, m);
            });
            InterlacedSign = Vector64s.CreateRotate<T>(ElementV1, ElementV_1);
            InterlacedSignNegative = Vector64s.CreateRotate<T>(ElementV_1, ElementV1);
            // -- Xyzw --
            if (true) {
                T o = ElementZero;
                T f = ElementAllBitsSet;
                T n = ElementNormOne;
                XyAddress0Mask = Vector64s.CreateRotate<T>(f, o);
                XyAddress1Mask = Vector64s.CreateRotate<T>(o, f);
                XyAddress0NormOne = Vector64s.CreateRotate<T>(n, o);
                XyAddress1NormOne = Vector64s.CreateRotate<T>(o, n);
                XyzwAddress0Mask = Vector64s.CreateRotate<T>(f, o, o, o);
                XyzwAddress1Mask = Vector64s.CreateRotate<T>(o, f, o, o);
                XyzwAddress2Mask = Vector64s.CreateRotate<T>(o, o, f, o);
                XyzwAddress3Mask = Vector64s.CreateRotate<T>(o, o, o, f);
                XyzwAddress0NormOne = Vector64s.CreateRotate<T>(n, o, o, o);
                XyzwAddress1NormOne = Vector64s.CreateRotate<T>(o, n, o, o);
                XyzwAddress2NormOne = Vector64s.CreateRotate<T>(o, o, n, o);
                XyzwAddress3NormOne = Vector64s.CreateRotate<T>(o, o, o, n);
            }
            if (BitConverter.IsLittleEndian) {
                XyXMask = XyAddress0Mask;
                XyYMask = XyAddress1Mask;
                XyXNormOne = XyAddress0NormOne;
                XyYNormOne = XyAddress1NormOne;
                XyzwXMask = XyzwAddress0Mask;
                XyzwYMask = XyzwAddress1Mask;
                XyzwZMask = XyzwAddress2Mask;
                XyzwWMask = XyzwAddress3Mask;
                XyzwXNormOne = XyzwAddress0NormOne;
                XyzwYNormOne = XyzwAddress1NormOne;
                XyzwZNormOne = XyzwAddress2NormOne;
                XyzwWNormOne = XyzwAddress3NormOne;
            } else {
                XyXMask = XyAddress1Mask;
                XyYMask = XyAddress0Mask;
                XyXNormOne = XyAddress1NormOne;
                XyYNormOne = XyAddress0NormOne;
                XyzwXMask = XyzwAddress3Mask;
                XyzwYMask = XyzwAddress2Mask;
                XyzwZMask = XyzwAddress1Mask;
                XyzwWMask = XyzwAddress0Mask;
                XyzwXNormOne = XyzwAddress3NormOne;
                XyzwYNormOne = XyzwAddress2NormOne;
                XyzwZNormOne = XyzwAddress1NormOne;
                XyzwWNormOne = XyzwAddress0NormOne;
            }
            // == Mask array ==
            MaskBitPosArray = Vector64s.GetMaskBitPosArray(ElementByteSize);
            MaskBitsArray = Vector64s.GetMaskBitsArray(ElementByteSize);
        }

        /// <summary>
        /// Get bit pos mask by index (根据索引获取位偏移掩码). The equivalent of <c>Vector64s.Create(Scalars.GetByBits&lt;T&gt;(1L &lt;&lt; index))</c>.
        /// </summary>
        /// <param name="index">The index (索引). The value ranges from 0 to <c>ElementBitSize-1</c> (值的范围是 0 ~ <c>ElementBitSize-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bit pos mask (返回位偏移掩码).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Vector64<T> GetMaskBitPos(int index) {
            return ref Unsafe.As<Vector64<byte>, Vector64<T>>(ref MaskBitPosArray[index]);
        }

        /// <summary>
        /// Get bit pos mask span (获取位偏移掩码的跨度). Tip: You can use <see cref="Unsafe.As{TFrom, TTo}(ref TFrom)"/> convert its item to <see cref="Vector64{T}"/> type (提示: 可以用 <see cref="Unsafe.As{TFrom, TTo}(ref TFrom)"/> 将其中条目转为 <see cref="Vector64{T}"/> 类型).
        /// </summary>
        /// <returns>Returns bit pos mask span (返回位偏移掩码的跨度).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlySpan<Vector64<byte>> GetMaskBitPosSpan() {
            return new ReadOnlySpan<Vector64<byte>>(MaskBitPosArray);
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码). The equivalent of <c>Vector64s.Create(Scalars.GetBitsMask&lt;T&gt;(0, index))</c>.
        /// </summary>
        /// <param name="index">The index (索引). The value ranges from 0 to <c>ElementBitSize</c> (值的范围是 0 ~ <c>ElementBitSize</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Vector64<T> GetMaskBits(int index) {
            return ref Unsafe.As<Vector64<byte>, Vector64<T>>(ref MaskBitsArray[index]);
        }

        /// <summary>
        /// Get bits mask span (获取位集掩码的跨度). Tip: You can use <see cref="Unsafe.As{TFrom, TTo}(ref TFrom)"/> convert its item to <see cref="Vector64{T}"/> type (提示: 可以用 <see cref="Unsafe.As{TFrom, TTo}(ref TFrom)"/> 将其中条目转为 <see cref="Vector64{T}"/> 类型).
        /// </summary>
        /// <returns>Returns bits mask span (返回位集掩码的跨度).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlySpan<Vector64<byte>> GetMaskBitsSpan() {
            return new ReadOnlySpan<Vector64<byte>>(MaskBitsArray);
        }


        /// <summary>Zero (0).</summary>
        /// <seealso cref="Vector64{T}.Zero"/>
        public static Vector64<T> Zero { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Vector64<T>.Zero; } }
        /// <summary>Value 0 (0的值).</summary>
        /// <seealso cref="Vector64{T}.Zero"/>
        public static Vector64<T> V0 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Vector64<T>.Zero; } }
        /// <summary>All bit is 1 (所有位都是1的值).</summary>
        /// <seealso cref="Vector64{T}.AllBitsSet"/>
        public static Vector64<T> AllBitsSet {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET5_0_OR_GREATER
                return Vector64<T>.AllBitsSet;
#else
                return Vector64.Create((int)-1).As<int, T>();
#endif // NET5_0_OR_GREATER
            }
        }


        /// <summary>1 bits mask (1位掩码).</summary>
        public static ref readonly Vector64<T> MaskBits1 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return ref GetMaskBits(1); } }
        /// <summary>2 bits mask (2位掩码).</summary>
        public static ref readonly Vector64<T> MaskBits2 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return ref GetMaskBits(2); } }
        /// <summary>4 bits mask (4位掩码).</summary>
        public static ref readonly Vector64<T> MaskBits4 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return ref GetMaskBits(4); } }
        /// <summary>8 bits mask (8位掩码).</summary>
        public static ref readonly Vector64<T> MaskBits8 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return ref GetMaskBits(8); } }
        /// <summary>16 bits mask (16位掩码).</summary>
        public static ref readonly Vector64<T> MaskBits16 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return ref GetMaskBits(Math.Min(ElementBitSize, 16)); } }
        /// <summary>32 bits mask (32位掩码).</summary>
        public static ref readonly Vector64<T> MaskBits32 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return ref GetMaskBits(Math.Min(ElementBitSize, 32)); } }

#endif
    }
}
