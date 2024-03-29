﻿using System;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Impl;
using Zyl.VectorTraits.Impl.Util;

namespace Zyl.VectorTraits {

    /// <summary>
    /// Methods of <see cref="Vector{T}"/> .
    /// </summary>
    public static partial class Vectors {

        // == Mask array ==
        // It takes up too much space to construct a batch of mask arrays for each element type. int/uint/float can share a 4-byte mask, and the total bit length of vector types is fixed. Therefore, arrays such as MaskBitPosArray1B can be shared by multiple element types. (若为每一种元素类型都构造一批掩码数组的话, 太占空间了. 考虑到 int/uint/float 可共用4字节的掩码, 且向量类型的总位长是固定的, 于是 MaskBitPosArray1B 等数组可以给多种元素类型所共用.)

        /// <summary>Bit pos mask array - 1Byte (位偏移掩码的数组 - 1字节). e.g. 1, 2, 4, 8, 0x10 ...</summary>
        private static readonly Vector<byte>[] MaskBitPosArray1B;
        /// <summary>Bit pos mask array - 2Byte (位偏移掩码的数组 - 2字节). e.g. 1, 2, 4, 8, 0x10 ...</summary>
        private static readonly Vector<byte>[] MaskBitPosArray2B;
        /// <summary>Bit pos mask array - 4Byte (位偏移掩码的数组 - 4字节). e.g. 1, 2, 4, 8, 0x10 ...</summary>
        private static readonly Vector<byte>[] MaskBitPosArray4B;
        /// <summary>Bit pos mask array - 8Byte (位偏移掩码的数组 - 8字节). e.g. 1, 2, 4, 8, 0x10 ...</summary>
        private static readonly Vector<byte>[] MaskBitPosArray8B;
        /// <summary>Bits mask array - 1Byte (位集掩码的数组 - 1字节). e.g. 0, 1, 3, 7, 0xF, 0x1F ...</summary>
        private static readonly Vector<byte>[] MaskBitsArray1B;
        /// <summary>Bits mask array - 2Byte (位集掩码的数组 - 2字节). e.g. 0, 1, 3, 7, 0xF, 0x1F ...</summary>
        private static readonly Vector<byte>[] MaskBitsArray2B;
        /// <summary>Bits mask array - 4Byte (位集掩码的数组 - 4字节). e.g. 0, 1, 3, 7, 0xF, 0x1F ...</summary>
        private static readonly Vector<byte>[] MaskBitsArray4B;
        /// <summary>Bits mask array - 8Byte (位集掩码的数组 - 8字节). e.g. 0, 1, 3, 7, 0xF, 0x1F ...</summary>
        private static readonly Vector<byte>[] MaskBitsArray8B;

        /// <summary>
        /// Static constructor.
        /// </summary>
        static Vectors() {
            long bitpos;
            long bits;
            int i;
            MaskBitPosArray1B = new Vector<byte>[1 * 8];
            MaskBitPosArray2B = new Vector<byte>[2 * 8];
            MaskBitPosArray4B = new Vector<byte>[4 * 8];
            MaskBitPosArray8B = new Vector<byte>[8 * 8];
            MaskBitsArray1B = new Vector<byte>[1 * 8 + 1];
            MaskBitsArray2B = new Vector<byte>[2 * 8 + 1];
            MaskBitsArray4B = new Vector<byte>[4 * 8 + 1];
            MaskBitsArray8B = new Vector<byte>[8 * 8 + 1];
            MaskBitsArray1B[0] = Vector<byte>.Zero;
            MaskBitsArray2B[0] = Vector<byte>.Zero;
            MaskBitsArray4B[0] = Vector<byte>.Zero;
            MaskBitsArray8B[0] = Vector<byte>.Zero;
            bitpos = 1;
            bits = 1;
            for (i = 0; i < MaskBitPosArray8B.Length; ++i) {
                if (i < MaskBitPosArray1B.Length) {
                    MaskBitPosArray1B[i] = Vectors.Create(Scalars.GetByBits<byte>(bitpos));
                    MaskBitsArray1B[1 + i] = Vectors.Create(Scalars.GetByBits<byte>(bits));
                }
                if (i < MaskBitPosArray2B.Length) {
                    MaskBitPosArray2B[i] = Vector.AsVectorByte(Vectors.Create(Scalars.GetByBits<ushort>(bitpos)));
                    MaskBitsArray2B[1 + i] = Vector.AsVectorByte(Vectors.Create(Scalars.GetByBits<ushort>(bits)));
                }
                if (i < MaskBitPosArray4B.Length) {
                    MaskBitPosArray4B[i] = Vector.AsVectorByte(Vectors.Create(Scalars.GetByBits<uint>(bitpos)));
                    MaskBitsArray4B[1 + i] = Vector.AsVectorByte(Vectors.Create(Scalars.GetByBits<uint>(bits)));
                }
                if (i < MaskBitPosArray8B.Length) {
                    MaskBitPosArray8B[i] = Vector.AsVectorByte(Vectors.Create(Scalars.GetByBits<ulong>(bitpos)));
                    MaskBitsArray8B[1 + i] = Vector.AsVectorByte(Vectors.Create(Scalars.GetByBits<ulong>(bits)));
                }
                // next.
                bitpos <<= 1;
                bits = bits << 1 | 1;
            }
            // Vector128Constants
#if NETCOREAPP3_0_OR_GREATER
            //Trace.WriteLine(string.Format("YShuffleG4X2_UInt64_ByteIndices.Length: {0}", Vector128Constants.YShuffleG4X2_UInt64_ByteIndices.Length));
#endif // NETCOREAPP3_0_OR_GREATER
            // Done.
            if (0 != bits) {
                // [Debug]
            }
        }

        /// <summary>
        /// Get bit pos mask array (取得位偏移掩码的数组).
        /// </summary>
        /// <param name="byteSize">元素的字节大小 (元素的字节大小).</param>
        /// <returns>Returns bit pos mask array (返回位偏移掩码的数组). An 8-byte array is returned if not found, to avoid returning null (找不到时返回8字节的数组, 这是为了避免返回null).</returns>
        internal static Vector<byte>[] GetMaskBitPosArray(int byteSize) {
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
        internal static Vector<byte>[] GetMaskBitsArray(int byteSize) {
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
        public static Vector<T> Create<T>(T[] values) where T : struct {
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
            return Unsafe.ReadUnaligned<Vector<T>>(ref UnsafeUtil.GetReference(values));
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
            return Unsafe.ReadUnaligned<Vector<T>>(ref Unsafe.As<T, byte>(ref UnsafeUtil.GetReference(values)));
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
            return Unsafe.ReadUnaligned<Vector<T>>(ref Unsafe.As<T, byte>(ref UnsafeUtil.GetReference(values)));
#endif // NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        }

        /// <summary>
        /// Padding creates a new <see cref="Vector{T}"/> from a given span starting at a specified index position (于指定索引位置开始，从指定跨度补齐创建一个 <see cref="Vector{T}"/>). The element after values is initialized to 0(values 之后的元素会初始化为0).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="values">The array from which the vector is created (用于创建向量的数组).</param>
        /// <param name="index">Starting index position of valid data in <paramref name="values"/> (<paramref name="values"/> 中有效数据的起始索引位置).</param>
        /// <param name="length">Length of valid data in <paramref name="values"/> (<paramref name="values"/> 中有效数据的长度).</param>
        /// <returns>A new <see cref="Vector{T}"/> with its elements set to the first Count elements from <paramref name="values"/> (一个新<see cref="Vector{T}"/>，其元素设置为来自<paramref name="values"/>首批满足长度的元素).</returns>
        /// <exception cref="IndexOutOfRangeException">The <paramref name="index"/> is less than zero (<paramref name="index"/> 小于零). The length of <paramref name="values"/>, starting from <paramref name="index"/>, is less than <see cref="Vector{T}.Count"/> (从 <paramref name="index"/> 开始的 <paramref name="values"/> 的长度小于 <see cref="Vector{T}.Count"/>).</exception>
        public static Vector<T> CreatePadding<T>(T[] values, int index, int length) where T : struct {
            return CreatePadding((ReadOnlySpan<T>)values, index, length);
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
            ref T p = ref Unsafe.As<Vector<T>, T>(ref temp);
            int m = Math.Min(Vector<T>.Count, length);
            for (int i = 0; i < m; ++i) {
                p = values[idx];
                ++idx;
                p = ref Unsafe.Add(ref p, 1);
            }
            return temp;
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
        /// <param name="values">The array from which the vector is created (用于创建向量的数组).</param>
        /// <param name="index">Starting index position of valid data in <paramref name="values"/> (<paramref name="values"/> 中有效数据的起始索引位置).</param>
        /// <param name="length">Length of valid data in <paramref name="values"/> (<paramref name="values"/> 中有效数据的长度).</param>
        /// <returns>A new <see cref="Vector{T}"/> with its elements set to the first Count elements from <paramref name="values"/> (一个新<see cref="Vector{T}"/>，其元素设置为来自<paramref name="values"/>首批满足长度的元素).</returns>
        /// <exception cref="IndexOutOfRangeException">The <paramref name="index"/> is less than zero (<paramref name="index"/> 小于零). The length of <paramref name="values"/>, starting from <paramref name="index"/>, is less than <see cref="Vector{T}.Count"/> (从 <paramref name="index"/> 开始的 <paramref name="values"/> 的长度小于 <see cref="Vector{T}.Count"/>).</exception>
        public static Vector<T> CreateRotate<T>(T[] values, int index, int length) where T : struct {
            return CreateRotate((ReadOnlySpan<T>)values, index, length);
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
            UnsafeUtil.SkipInit(out Vector<T> temp);
            ref T p = ref Unsafe.As<Vector<T>, T>(ref temp);
            for (int i = 0; i < Vector<T>.Count; ++i) {
                p = values[idx];
                ++idx;
                if (idx >= idxEnd) idx = index;
                p = ref Unsafe.Add(ref p, 1);
            }
            return temp;
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
            UnsafeUtil.SkipInit(out Vector<T> temp);
            ref T p = ref Unsafe.As<Vector<T>, T>(ref temp);
            for (int i = 0; i < Vector<T>.Count; ++i) {
                p = func(i);
                p = ref Unsafe.Add(ref p, 1);
            }
            return temp;
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
            UnsafeUtil.SkipInit(out Vector<T> temp);
            ref T p = ref Unsafe.As<Vector<T>, T>(ref temp);
            for (int i = 0; i < Vector<T>.Count; ++i) {
                p = func(i, userdata);
                p = ref Unsafe.Add(ref p, 1);
            }
            return temp;
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
        /// <returns>A new <see cref="Vector{T}"/> with all elements initialized to <paramref name="src"/> (一个新的 <see cref="Vector{T}"/>，其中所有元素已初始化为 <paramref name="src"/> ).</returns>
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
        /// <returns>A new <see cref="Vector{T}"/> with all elements initialized to <paramref name="src"/> (一个新的 <see cref="Vector{T}"/>，其中所有元素已初始化为 <paramref name="src"/> ).</returns>
        public static Vector<T> CreateByBits<T>(long src) where T : struct {
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
}
