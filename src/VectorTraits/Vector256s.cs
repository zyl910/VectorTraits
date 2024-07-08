#if NET7_0_OR_GREATER
#define BCL_TYPE_INT128
#endif // NET7_0_OR_GREATER

using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Impl.Util;
using Zyl.VectorTraits.ExTypes;

namespace Zyl.VectorTraits {

    /// <summary>
    /// Methods of <see cref="Vector256{T}"/> . It supports ExType,and the element type can also be (它支持扩展类型, 元素类型还可以为): <see cref="ExInt128"/>, <see cref="ExUInt128"/>, <see cref="Int128"/>, <see cref="UInt128"/>.
    /// </summary>
    public static partial class Vector256s {
#if NETCOREAPP3_0_OR_GREATER

        // == Mask array ==
        // It takes up too much space to construct a batch of mask arrays for each element type. int/uint/float can share a 4-byte mask, and the total bit length of vector types is fixed. Therefore, arrays such as MaskBitPosArray1B can be shared by multiple element types. (若为每一种元素类型都构造一批掩码数组的话, 太占空间了. 考虑到 int/uint/float 可共用4字节的掩码, 且向量类型的总位长是固定的, 于是 MaskBitPosArray1B 等数组可以给多种元素类型所共用.)

        /// <summary>Bit pos mask array - 1Byte (位偏移掩码的数组 - 1字节). e.g. 1, 2, 4, 8, 0x10 ...</summary>
        private static readonly Vector256<byte>[] MaskBitPosArray1B;
        /// <summary>Bit pos mask array - 2Byte (位偏移掩码的数组 - 2字节). e.g. 1, 2, 4, 8, 0x10 ...</summary>
        private static readonly Vector256<byte>[] MaskBitPosArray2B;
        /// <summary>Bit pos mask array - 4Byte (位偏移掩码的数组 - 4字节). e.g. 1, 2, 4, 8, 0x10 ...</summary>
        private static readonly Vector256<byte>[] MaskBitPosArray4B;
        /// <summary>Bit pos mask array - 8Byte (位偏移掩码的数组 - 8字节). e.g. 1, 2, 4, 8, 0x10 ...</summary>
        private static readonly Vector256<byte>[] MaskBitPosArray8B;
        /// <summary>Bit pos mask array - 8Byte (位偏移掩码的数组 - 16字节). e.g. 1, 2, 4, 8, 0x10 ...</summary>
        private static readonly Vector256<byte>[] MaskBitPosArray16B;
        /// <summary>Bits mask array - 1Byte (位集掩码的数组 - 1字节). e.g. 0, 1, 3, 7, 0xF, 0x1F ...</summary>
        private static readonly Vector256<byte>[] MaskBitsArray1B;
        /// <summary>Bits mask array - 2Byte (位集掩码的数组 - 2字节). e.g. 0, 1, 3, 7, 0xF, 0x1F ...</summary>
        private static readonly Vector256<byte>[] MaskBitsArray2B;
        /// <summary>Bits mask array - 4Byte (位集掩码的数组 - 4字节). e.g. 0, 1, 3, 7, 0xF, 0x1F ...</summary>
        private static readonly Vector256<byte>[] MaskBitsArray4B;
        /// <summary>Bits mask array - 8Byte (位集掩码的数组 - 8字节). e.g. 0, 1, 3, 7, 0xF, 0x1F ...</summary>
        private static readonly Vector256<byte>[] MaskBitsArray8B;
        /// <summary>Bits mask array - 8Byte (位集掩码的数组 - 16字节). e.g. 0, 1, 3, 7, 0xF, 0x1F ...</summary>
        private static readonly Vector256<byte>[] MaskBitsArray16B;

        /// <summary>
        /// Static constructor.
        /// </summary>
        static Vector256s() {
            unchecked {
                ExInt128 bitpos;
                ExInt128 bits;
                int i;
                MaskBitPosArray1B = new Vector256<byte>[1 * 8];
                MaskBitPosArray2B = new Vector256<byte>[2 * 8];
                MaskBitPosArray4B = new Vector256<byte>[4 * 8];
                MaskBitPosArray8B = new Vector256<byte>[8 * 8];
                MaskBitPosArray16B = new Vector256<byte>[16 * 8];
                MaskBitsArray1B = new Vector256<byte>[1 * 8 + 1];
                MaskBitsArray2B = new Vector256<byte>[2 * 8 + 1];
                MaskBitsArray4B = new Vector256<byte>[4 * 8 + 1];
                MaskBitsArray8B = new Vector256<byte>[8 * 8 + 1];
                MaskBitsArray16B = new Vector256<byte>[16 * 8 + 1];
                MaskBitsArray1B[0] = Vector256<byte>.Zero;
                MaskBitsArray2B[0] = Vector256<byte>.Zero;
                MaskBitsArray4B[0] = Vector256<byte>.Zero;
                MaskBitsArray8B[0] = Vector256<byte>.Zero;
                MaskBitsArray16B[0] = Vector256<byte>.Zero;
                bitpos = 1;
                bits = 1;
                for (i = 0; i < MaskBitPosArray8B.Length; ++i) {
                    if (i < MaskBitPosArray1B.Length) {
                        MaskBitPosArray1B[i] = Vector256.Create(Scalars.GetBy128Bits<byte>(bitpos));
                        MaskBitsArray1B[1 + i] = Vector256.Create(Scalars.GetBy128Bits<byte>(bits));
                    }
                    if (i < MaskBitPosArray2B.Length) {
                        MaskBitPosArray2B[i] = Vector256.AsByte(Vector256.Create(Scalars.GetBy128Bits<ushort>(bitpos)));
                        MaskBitsArray2B[1 + i] = Vector256.AsByte(Vector256.Create(Scalars.GetBy128Bits<ushort>(bits)));
                    }
                    if (i < MaskBitPosArray4B.Length) {
                        MaskBitPosArray4B[i] = Vector256.AsByte(Vector256.Create(Scalars.GetBy128Bits<uint>(bitpos)));
                        MaskBitsArray4B[1 + i] = Vector256.AsByte(Vector256.Create(Scalars.GetBy128Bits<uint>(bits)));
                    }
                    if (i < MaskBitPosArray8B.Length) {
                        MaskBitPosArray8B[i] = Vector256.AsByte(Vector256.Create(Scalars.GetBy128Bits<ulong>(bitpos)));
                        MaskBitsArray8B[1 + i] = Vector256.AsByte(Vector256.Create(Scalars.GetBy128Bits<ulong>(bits)));
                    }
                    if (i < MaskBitPosArray16B.Length) {
                        MaskBitPosArray16B[i] = Create(bitpos).ExAsByte();
                        MaskBitsArray16B[1 + i] = Create(bits).ExAsByte();
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
        internal static Vector256<byte>[] GetMaskBitPosArray(int byteSize) {
            if (1 == byteSize) {
                return MaskBitPosArray1B;
            } else if (2 == byteSize) {
                return MaskBitPosArray2B;
            } else if (4 == byteSize) {
                return MaskBitPosArray4B;
            } else if (8 == byteSize) {
                return MaskBitPosArray8B;
            } else {
                return MaskBitPosArray16B;
            }
        }

        /// <summary>
        /// Get bits mask array (取得位集掩码的数组).
        /// </summary>
        /// <param name="byteSize">元素的字节大小 (元素的字节大小).</param>
        /// <returns>Returns bits mask array (返回位集掩码的数组). An 8-byte array is returned if not found, to avoid returning null (找不到时返回8字节的数组, 这是为了避免返回null).</returns>
        internal static Vector256<byte>[] GetMaskBitsArray(int byteSize) {
            if (1 == byteSize) {
                return MaskBitsArray1B;
            } else if (2 == byteSize) {
                return MaskBitsArray2B;
            } else if (4 == byteSize) {
                return MaskBitsArray4B;
            } else if (8 == byteSize) {
                return MaskBitsArray8B;
            } else {
                return MaskBitsArray16B;
            }
        }

        // == Vector256 methods ==

        /// <summary>
        /// Returns the number of elements stored in the vector (返回存储在向量中的元素数量).
        /// </summary>
        /// <typeparam name="T">The type of the input vector element (输入向量元素的类型).</typeparam>
        /// <returns>The number of elements stored in the vector (存储在向量中的元素数量).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Count<T>() where T : struct {
            return Vector256<byte>.Count / Unsafe.SizeOf<T>();
        }

        /// <summary>Create a new vector instance from two shorter vector instances. (从两个更短的向量实例, 来创建新的向量实例).</summary>
        /// <typeparam name="T">The type of the input vector element (输入向量元素的类型).</typeparam>
        /// <param name="lower">The value that the lower 128-bits will be initialized to (较低 128 位的初始化值).</param>
        /// <param name="upper">The value that the upper 128-bits will be initialized to (较高 128 位的初始化值).</param>
        /// <returns>A new <see cref="Vector256{T}" /> initialized from <paramref name="lower" /> and <paramref name="upper" /> (从 <paramref name="lower" /> 和 <paramref name="upper" /> 初始化的新 <see cref="Vector256{T}" />).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<T> Create<T>(Vector128<T> lower, Vector128<T> upper) where T : struct {
            return Vector256.Create(lower.ExAsUInt64(), upper.ExAsUInt64()).ExAs<ulong, T>();
        }

        /// <summary>
        /// Creates a new <see cref="Vector256{T}"/> instance with all elements initialized to the specified value (创建新的 <see cref="Vector256{T}"/> 实例，其中所有元素已初始化为指定值).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="value">The value that all elements will be initialized to (所有元素的初始化目标值).</param>
        /// <returns>A new <see cref="Vector256{T}"/> with all elements initialized to value (一个新的 <see cref="Vector256{T}"/>，其中所有元素已初始化为 <paramref name="value"/> ).</returns>
        /// <seealso cref="Vector256.Create{T}(T)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<T> Create<T>(T value) where T : struct {
            if (typeof(T) == typeof(float)) {
                return (Vector256<T>)(object)Vector256.Create((float)(object)value);
            } else if (typeof(T) == typeof(double)) {
                return (Vector256<T>)(object)Vector256.Create((double)(object)value);
            } else if (typeof(T) == typeof(sbyte)) {
                return (Vector256<T>)(object)Vector256.Create((sbyte)(object)value);
            } else if (typeof(T) == typeof(short)) {
                return (Vector256<T>)(object)Vector256.Create((short)(object)value);
            } else if (typeof(T) == typeof(int)) {
                return (Vector256<T>)(object)Vector256.Create((int)(object)value);
            } else if (typeof(T) == typeof(long)) {
                return (Vector256<T>)(object)Vector256.Create((long)(object)value);
            } else if (typeof(T) == typeof(byte)) {
                return (Vector256<T>)(object)Vector256.Create((byte)(object)value);
            } else if (typeof(T) == typeof(ushort)) {
                return (Vector256<T>)(object)Vector256.Create((ushort)(object)value);
            } else if (typeof(T) == typeof(uint)) {
                return (Vector256<T>)(object)Vector256.Create((uint)(object)value);
            } else if (typeof(T) == typeof(ulong)) {
                return (Vector256<T>)(object)Vector256.Create((ulong)(object)value);
            } else if (typeof(T) == typeof(ExInt128)) {
                return (Vector256<T>)(object)Vector256s.Create((ExInt128)(object)value);
            } else if (typeof(T) == typeof(ExUInt128)) {
                return (Vector256<T>)(object)Vector256s.Create((ExUInt128)(object)value);
#if BCL_TYPE_INT128
            } else if (typeof(T) == typeof(Int128)) {
                return (Vector256<T>)(object)Vector256s.Create((Int128)(object)value);
            } else if (typeof(T) == typeof(UInt128)) {
                return (Vector256<T>)(object)Vector256s.Create((UInt128)(object)value);
#endif // BCL_TYPE_INT128
            } else {
#if NET7_0_OR_GREATER
                return Vector256.Create(value);
#else
                return (Vector256<T>)(object)Vector256.Create((dynamic)value);
#endif
            }
        }

            /// <summary>
            /// Creates a new <see cref="Vector256{T}"/> from a given array (从给定数组创建一个新的 <see cref="Vector256{T}"/> ).
            /// </summary>
            /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
            /// <param name="values">The array from which the vector is created (用于创建向量的数组).</param>
            /// <returns>A new <see cref="Vector256{T}"/> with its elements set to the first Count elements from <paramref name="values"/> (一个新<see cref="Vector256{T}"/>，其元素设置为来自<paramref name="values"/>首批满足长度的元素).</returns>
            /// <seealso cref="Vector256.Create{T}(T[])"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<T> Create<T>(T[] values) where T : struct {
            // return Vector256.Create(values); // Need NET7_0_OR_GREATER. But not support ExType.
            return Create(values, 0);
        }

        /// <summary>
        /// Creates a new <see cref="Vector256{T}"/> from a given array starting at a specified index position (于指定索引位置开始，从指定数组创建一个 <see cref="Vector256{T}"/>).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="values">The array from which the vector is created (用于创建向量的数组).</param>
        /// <param name="index">The starting index position from which to create the vector (欲创建向量的起始索引位置).</param>
        /// <returns>A new <see cref="Vector256{T}"/> with its elements set to the first Count elements from <paramref name="values"/> (一个新<see cref="Vector256{T}"/>，其元素设置为来自<paramref name="values"/>首批满足长度的元素).</returns>
        /// <exception cref="IndexOutOfRangeException">The <paramref name="index"/> is less than zero (<paramref name="index"/> 小于零). The length of <paramref name="values"/>, starting from <paramref name="index"/>, is less than <see cref="Vector256{T}.Count"/> (从 <paramref name="index"/> 开始的 <paramref name="values"/> 的长度小于 <see cref="Vector256{T}.Count"/>).</exception>
        /// <seealso cref="Vector256.Create{T}(T[], int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<T> Create<T>(T[] values, int index) where T : struct {
            // return Vector256.Create(values); // Need NET7_0_OR_GREATER. But not support ExType.
            if (null == values) throw new ArgumentNullException(nameof(values));
            int idxEnd = index + Count<T>();
            if (index < 0 || idxEnd > values.Length) {
                throw new IndexOutOfRangeException(string.Format("Index({0}) was outside the bounds{1} of the array!", index, values.Length));
            }
            return Unsafe.ReadUnaligned<Vector256<T>>(ref Unsafe.As<T, byte>(ref values[index]));
        }

        /// <summary>
        /// Creates a new <see cref="Vector256{T}"/> from a given read-only span of bytes (根据给定的只读字节跨度构造一个 <see cref="Vector256{T}"/>).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="values">A read-only span of bytes that contains the values to add to the vector (从中创建向量的只读字节跨度).</param>
        /// <returns>A new <see cref="Vector256{T}"/> with its elements set to the first Count elements from <paramref name="values"/> (一个新<see cref="Vector256{T}"/>，其元素设置为来自<paramref name="values"/>首批满足长度的元素).</returns>
        /// <exception cref="IndexOutOfRangeException"><paramref name="values"/> did not contain at least <see cref="Vector256{T}.Count"/> elements (<paramref name="values"/> 的长度小于 <see cref="Vector256{T}.Count"/>).</exception>
        /// <seealso cref="Vector256.Create{T}(ReadOnlySpan{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<T> Create<T>(ReadOnlySpan<byte> values) where T : struct {
            if (values.Length < Vector256<byte>.Count) {
                throw new IndexOutOfRangeException(string.Format("Index was outside the bounds({0}) of the array!", values.Length));
            }
            return Unsafe.ReadUnaligned<Vector256<T>>(ref MemoryMarshal.GetReference(values));
        }

        /// <summary>
        /// Creates a new <see cref="Vector256{T}"/> from a from the given <see cref="ReadOnlySpan{T}"/> (根据给定的 <see cref="ReadOnlySpan{T}"/> 构造一个 <see cref="Vector256{T}"/>).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="values">The readonly span from which the vector is created (从中创建向量的只读跨度).</param>
        /// <returns>A new <see cref="Vector256{T}"/> with its elements set to the first Count elements from <paramref name="values"/> (一个新<see cref="Vector256{T}"/>，其元素设置为来自<paramref name="values"/>首批满足长度的元素).</returns>
        /// <exception cref="IndexOutOfRangeException"><paramref name="values"/> did not contain at least <see cref="Vector256{T}.Count"/> elements (<paramref name="values"/> 的长度小于 <see cref="Vector256{T}.Count"/>).</exception>
        /// <seealso cref="Vector256.Create{T}(ReadOnlySpan{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<T> Create<T>(ReadOnlySpan<T> values) where T : struct {
            // return Vector256.Create(values); // Need NET7_0_OR_GREATER. But not support ExType.
            if (values.Length < Count<T>()) {
                throw new IndexOutOfRangeException(string.Format("Index was outside the bounds({0}) of the array!", values.Length));
            }
            return Unsafe.ReadUnaligned<Vector256<T>>(ref Unsafe.As<T, byte>(ref MemoryMarshal.GetReference(values)));
        }

        /// <summary>
        /// Creates a new <see cref="Vector256{T}"/> from a from the given <see cref="Span{T}"/> (根据给定的 <see cref="Span{T}"/> 构造一个 <see cref="Vector256{T}"/>).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="values">The span from which the vector is created (从中创建向量的跨度).</param>
        /// <returns>A new <see cref="Vector256{T}"/> with its elements set to the first Count elements from <paramref name="values"/> (一个新<see cref="Vector256{T}"/>，其元素设置为来自<paramref name="values"/>首批满足长度的元素).</returns>
        /// <exception cref="IndexOutOfRangeException"><paramref name="values"/> did not contain at least <see cref="Vector256{T}.Count"/> elements (<paramref name="values"/> 的长度小于 <see cref="Vector256{T}.Count"/>).</exception>
        /// <seealso cref="Vector256.Create{T}(ReadOnlySpan{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<T> Create<T>(Span<T> values) where T : struct {
            if (values.Length < Count<T>()) {
                throw new IndexOutOfRangeException(string.Format("Index was outside the bounds({0}) of the array!", values.Length));
            }
            return Unsafe.ReadUnaligned<Vector256<T>>(ref Unsafe.As<T, byte>(ref MemoryMarshal.GetReference(values)));
        }

        /// <summary>
        /// Padding creates a new <see cref="Vector256{T}"/> from a given span starting at a specified index position (于指定索引位置开始，从指定跨度补齐创建一个 <see cref="Vector256{T}"/>). The element after values is initialized to 0(values 之后的元素会初始化为0).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="values">The array from which the vector is created (用于创建向量的数组).</param>
        /// <param name="index">Starting index position of valid data in <paramref name="values"/> (<paramref name="values"/> 中有效数据的起始索引位置).</param>
        /// <param name="length">Length of valid data in <paramref name="values"/> (<paramref name="values"/> 中有效数据的长度).</param>
        /// <returns>A new <see cref="Vector256{T}"/> with its elements set to the first Count elements from <paramref name="values"/> (一个新<see cref="Vector256{T}"/>，其元素设置为来自<paramref name="values"/>首批满足长度的元素).</returns>
        /// <exception cref="IndexOutOfRangeException">The <paramref name="index"/> is less than zero (<paramref name="index"/> 小于零). The length of <paramref name="values"/>, starting from <paramref name="index"/>, is less than <see cref="Vector256{T}.Count"/> (从 <paramref name="index"/> 开始的 <paramref name="values"/> 的长度小于 <see cref="Vector256{T}.Count"/>).</exception>
        public static Vector256<T> CreatePadding<T>(T[] values, int index, int length) where T : struct {
            return CreatePadding((ReadOnlySpan<T>)values, index, length);
        }

        /// <summary>
        /// Padding creates a new <see cref="Vector256{T}"/> from a given span starting at a specified index position (于指定索引位置开始，从指定跨度补齐创建一个 <see cref="Vector256{T}"/>). The element after values is initialized to 0(values 之后的元素会初始化为0).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="values">The span from which the vector is created (用于创建向量的跨度).</param>
        /// <param name="index">Starting index position of valid data in <paramref name="values"/> (<paramref name="values"/> 中有效数据的起始索引位置).</param>
        /// <param name="length">Length of valid data in <paramref name="values"/> (<paramref name="values"/> 中有效数据的长度).</param>
        /// <returns>A new <see cref="Vector256{T}"/> with its elements set to the first Count elements from <paramref name="values"/> (一个新<see cref="Vector256{T}"/>，其元素设置为来自<paramref name="values"/>首批满足长度的元素).</returns>
        /// <exception cref="IndexOutOfRangeException">The <paramref name="index"/> is less than zero (<paramref name="index"/> 小于零). The length of <paramref name="values"/>, starting from <paramref name="index"/>, is less than <see cref="Vector256{T}.Count"/> (从 <paramref name="index"/> 开始的 <paramref name="values"/> 的长度小于 <see cref="Vector256{T}.Count"/>).</exception>
        public static Vector256<T> CreatePadding<T>(ReadOnlySpan<T> values, int index, int length) where T : struct {
            Vector256<T> temp = default;
            int idxEnd = index + length;
            int idx = index;
            if (null == values || values.Length <= 0) return temp;
            if (index < 0 || idxEnd > values.Length) {
                throw new IndexOutOfRangeException(string.Format("Index({0}) was outside the bounds{1} of the array!", index, values.Length));
            }
            ref T p = ref Unsafe.As<Vector256<T>, T>(ref temp);
            int m = Math.Min(Count<T>(), length);
            for (int i = 0; i < m; ++i) {
                p = values[idx];
                ++idx;
                p = ref Unsafe.Add(ref p, 1);
            }
            return temp;
        }

        /// <summary>
        /// Padding creates a new <see cref="Vector256{T}"/> from a given span (从指定跨度补齐创建一个 <see cref="Vector256{T}"/>). The element after values is initialized to 0(values 之后的元素会初始化为0).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="values">The span from which the vector is created (用于创建向量的跨度).</param>
        /// <returns>A new <see cref="Vector256{T}"/> with its elements set to the first Count elements from <paramref name="values"/> (一个新<see cref="Vector256{T}"/>，其元素设置为来自<paramref name="values"/>首批满足长度的元素).</returns>
        public static Vector256<T> CreatePadding<T>(ReadOnlySpan<T> values) where T : struct {
            return CreatePadding<T>(values, 0, values.Length);
        }

        /// <summary>
        /// Padding creates a new <see cref="Vector256{T}"/> from a given array (从给定数组补齐创建一个新的 <see cref="Vector256{T}"/> ). The element after values is initialized to 0(values 之后的元素会初始化为0).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="values">The array from which the vector is created (用于创建向量的数组).</param>
        /// <returns>A new <see cref="Vector256{T}"/> with its elements set to the first Count elements from <paramref name="values"/> (一个新<see cref="Vector256{T}"/>，其元素设置为来自<paramref name="values"/>首批满足长度的元素).</returns>
        public static Vector256<T> CreatePadding<T>(params T[] values) where T : struct {
            return CreatePadding<T>(values, 0, values.Length);
        }

        /// <summary>
        /// Rotate creates a new <see cref="Vector256{T}"/> from a given span starting at a specified index position (于指定索引位置开始，从指定跨度旋转创建一个 <see cref="Vector256{T}"/>).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="values">The array from which the vector is created (用于创建向量的数组).</param>
        /// <param name="index">Starting index position of valid data in <paramref name="values"/> (<paramref name="values"/> 中有效数据的起始索引位置).</param>
        /// <param name="length">Length of valid data in <paramref name="values"/> (<paramref name="values"/> 中有效数据的长度).</param>
        /// <returns>A new <see cref="Vector256{T}"/> with its elements set to the first Count elements from <paramref name="values"/> (一个新<see cref="Vector256{T}"/>，其元素设置为来自<paramref name="values"/>首批满足长度的元素).</returns>
        /// <exception cref="IndexOutOfRangeException">The <paramref name="index"/> is less than zero (<paramref name="index"/> 小于零). The length of <paramref name="values"/>, starting from <paramref name="index"/>, is less than <see cref="Vector256{T}.Count"/> (从 <paramref name="index"/> 开始的 <paramref name="values"/> 的长度小于 <see cref="Vector256{T}.Count"/>).</exception>
        public static Vector256<T> CreateRotate<T>(T[] values, int index, int length) where T : struct {
            return CreateRotate((ReadOnlySpan<T>)values, index, length);
        }

        /// <summary>
        /// Rotate creates a new <see cref="Vector256{T}"/> from a given span starting at a specified index position (于指定索引位置开始，从指定跨度旋转创建一个 <see cref="Vector256{T}"/>).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="values">The span from which the vector is created (用于创建向量的跨度).</param>
        /// <param name="index">Starting index position of valid data in <paramref name="values"/> (<paramref name="values"/> 中有效数据的起始索引位置).</param>
        /// <param name="length">Length of valid data in <paramref name="values"/> (<paramref name="values"/> 中有效数据的长度).</param>
        /// <returns>A new <see cref="Vector256{T}"/> with its elements set to the first Count elements from <paramref name="values"/> (一个新<see cref="Vector256{T}"/>，其元素设置为来自<paramref name="values"/>首批满足长度的元素).</returns>
        /// <exception cref="IndexOutOfRangeException">The <paramref name="index"/> is less than zero (<paramref name="index"/> 小于零). The length of <paramref name="values"/>, starting from <paramref name="index"/>, is less than <see cref="Vector256{T}.Count"/> (从 <paramref name="index"/> 开始的 <paramref name="values"/> 的长度小于 <see cref="Vector256{T}.Count"/>).</exception>
        public static Vector256<T> CreateRotate<T>(ReadOnlySpan<T> values, int index, int length) where T : struct {
            int idxEnd = index + length;
            int idx = index;
            if (null == values || values.Length <= 0) return Vector256<T>.Zero;
            if (index < 0 || idxEnd > values.Length) {
                throw new IndexOutOfRangeException(string.Format("Index({0}) was outside the bounds{1} of the array!", index, values.Length));
            }
            UnsafeUtil.SkipInit(out Vector256<T> temp);
            ref T p = ref Unsafe.As<Vector256<T>, T>(ref temp);
            for (int i = 0; i < Count<T>(); ++i) {
                p = values[idx];
                ++idx;
                if (idx >= idxEnd) idx = index;
                p = ref Unsafe.Add(ref p, 1);
            }
            return temp;
        }

        /// <summary>
        /// Rotate creates a new <see cref="Vector256{T}"/> from a given span (从指定跨度旋转创建一个 <see cref="Vector256{T}"/>).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="values">The span from which the vector is created (用于创建向量的跨度).</param>
        /// <returns>A new <see cref="Vector256{T}"/> with its elements set to the first Count elements from <paramref name="values"/> (一个新<see cref="Vector256{T}"/>，其元素设置为来自<paramref name="values"/>首批满足长度的元素).</returns>
        public static Vector256<T> CreateRotate<T>(ReadOnlySpan<T> values) where T : struct {
            return CreateRotate<T>(values, 0, values.Length);
        }

        /// <summary>
        /// Rotate creates a new <see cref="Vector256{T}"/> from a given array (从给定数组旋转创建一个新的 <see cref="Vector256{T}"/> ).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="values">The array from which the vector is created (用于创建向量的数组).</param>
        /// <returns>A new <see cref="Vector256{T}"/> with its elements set to the first Count elements from <paramref name="values"/> (一个新<see cref="Vector256{T}"/>，其元素设置为来自<paramref name="values"/>首批满足长度的元素).</returns>
        public static Vector256<T> CreateRotate<T>(params T[] values) where T : struct {
            return CreateRotate<T>(values, 0, values.Length);
        }

        /// <summary>
        /// Creates a new <see cref="Vector256{T}"/> from a from the given <see cref="Func{T, TResult}"/> (从给定 <see cref="Func{T, TResult}"/> 创建一个新的 <see cref="Vector256{T}"/> ) .
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="func">A function that gets the value of each element (获取每个元素值的函数). Prototype: `T func(int index)`, `index` is element index.</param>
        /// <returns>A new <see cref="Vector256{T}"/> from a from the given <see cref="Func{T, TResult}"/> (一个新<see cref="Vector256{T}"/>，其元素来 <see cref="Func{T, TResult}"/>).</returns>
        public static Vector256<T> CreateByFunc<T>(Func<int, T> func) where T : struct {
            if (null == func) throw new ArgumentNullException(nameof(func));
            UnsafeUtil.SkipInit(out Vector256<T> temp);
            ref T p = ref Unsafe.As<Vector256<T>, T>(ref temp);
            for (int i = 0; i < Count<T>(); ++i) {
                p = func(i);
                p = ref Unsafe.Add(ref p, 1);
            }
            return temp;
        }

        /// <summary>
        /// Creates a new <see cref="Vector256{T}"/> from a from the given <see cref="Func{T1, T2, TResult}"/> (从给定 <see cref="Func{T1, T2, TResult}"/> 创建一个新的 <see cref="Vector256{T}"/> ) .
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <typeparam name="TUserdata">Type of <paramref name="userdata"/> (<paramref name="userdata"/>的类型).</typeparam>
        /// <param name="func">A function that gets the value of each element (获取每个元素值的函数). Prototype: `T func(int index, TUserdata userdata)`, `index` is element index.</param>
        /// <param name="userdata">The userdata (用户自定义数据).</param>
        /// <returns>A new <see cref="Vector256{T}"/> from a from the given <see cref="Func{T1, T2, TResult}"/> (一个新<see cref="Vector256{T}"/>，其元素来 <see cref="Func{T1, T2, TResult}"/>).</returns>
        public static Vector256<T> CreateByFunc<T, TUserdata>(Func<int, TUserdata, T> func, TUserdata userdata) where T : struct {
            if (null == func) throw new ArgumentNullException(nameof(func));
            UnsafeUtil.SkipInit(out Vector256<T> temp);
            ref T p = ref Unsafe.As<Vector256<T>, T>(ref temp);
            for (int i = 0; i < Count<T>(); ++i) {
                p = func(i, userdata);
                p = ref Unsafe.Add(ref p, 1);
            }
            return temp;
        }

        /// <summary>
        /// Creates a <see cref="Vector256{T}"/> whose components are of a specified double value (创建一个 <see cref="Vector256{T}"/>，其元素为指定的双精度浮点值).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="src">Source value (源值).</param>
        /// <returns>A new <see cref="Vector256{T}"/> with all elements initialized to value (一个新的 <see cref="Vector256{T}"/>，其中所有元素已初始化为 <paramref name="src"/> ).</returns>
        public static Vector256<T> CreateByDouble<T>(double src) where T : struct {
            return Create(Scalars.GetByDouble<T>(src));
        }

        /// <summary>
        /// Creates a <see cref="Vector256{T}"/> from double value `for` loop (创建一个 <see cref="Vector256{T}"/>，其元素来自双精度浮点值的`for`循环).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="start">Start value (起始值).</param>
        /// <param name="step">Increments at each step (每一步的增量).</param>
        /// <returns>A new <see cref="Vector256{T}"/> from a from double value `for` loop (一个新<see cref="Vector256{T}"/>，其元素来自双精度浮点值的`for`循环.</returns>
        public static Vector256<T> CreateByDoubleLoop<T>(double start, double step) where T : struct {
            return CreateByFunc(delegate (int index) {
                double src = start + step * index;
                return Scalars.GetByDouble<T>(src);
            });
        }

        /// <summary>
        /// Creates a <see cref="Vector256{T}"/> whose components are of a specified integer bits (创建一个 <see cref="Vector256{T}"/>，其元素为指定的整数位).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="src">Source value (源值).</param>
        /// <returns>A new <see cref="Vector256{T}"/> with all elements initialized to value (一个新的 <see cref="Vector256{T}"/>，其中所有元素已初始化为 <paramref name="src"/> ).</returns>
        public static Vector256<T> CreateByBits<T>(long src) where T : struct {
            return Create(Scalars.GetByBits<T>(src));
        }

        /// <summary>
        /// Creates a <see cref="Vector256{T}"/> whose components are of a specified 128-bits integer (创建一个 <see cref="Vector256{T}"/>，其元素为指定的128位整数).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="src">Source value (源值).</param>
        /// <returns>A new <see cref="Vector256{T}"/> with all elements initialized to value (一个新的 <see cref="Vector256{T}"/>，其中所有元素已初始化为 <paramref name="src"/> ).</returns>
        public static Vector256<T> CreateBy128Bits<T>(ExInt128 src) where T : struct {
            return Create(Scalars.GetBy128Bits<T>(src));
        }

        /// <summary>
        /// Determines if this element type is native supported (判断是否原生支持这种元素类型).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <returns><c>true</c> if <typeparamref name="T" /> is supported; otherwise, <c>false</c>. (当支持 <typeparamref name="T" /> 时返回<c>true</c>; 其他情况返回 <c>false</c>)</returns>
        /// <seealso cref="Vector256{T}.IsSupported"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNativeSupported<T>() where T : struct {
#if NET7_0_OR_GREATER
            return Vector256<T>.IsSupported;
#else
            return (typeof(T) == typeof(byte))
                || (typeof(T) == typeof(double))
                || (typeof(T) == typeof(short))
                || (typeof(T) == typeof(int))
                || (typeof(T) == typeof(long))
                || (typeof(T) == typeof(sbyte))
                || (typeof(T) == typeof(float))
                || (typeof(T) == typeof(ushort))
                || (typeof(T) == typeof(uint))
                || (typeof(T) == typeof(ulong));
#endif // NET7_0_OR_GREATER
        }

        /// <summary>
        /// [Base] Computes the ones-complement (~) of a vector (计算向量的补数).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="src">The vector whose ones-complement is to be computed (要计算其补数的向量).</param>
        /// <returns>A vector whose elements are the ones-complement of the corresponding elements in <paramref name="src"/> (一个向量，其各元素是 <paramref name="src"/> 相应元素的补数).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Vector256<T> BaseOnesComplement<T>(Vector256<T> src) where T : struct {
#if NET7_0_OR_GREATER
            return ~src;
#else
            ref ulong p = ref Unsafe.As<Vector256<T>, ulong>(ref src);
            p = ~p;
            Unsafe.Add(ref p, 1) = ~Unsafe.Add(ref p, 1);
            Unsafe.Add(ref p, 2) = ~Unsafe.Add(ref p, 2);
            Unsafe.Add(ref p, 3) = ~Unsafe.Add(ref p, 3);
            return src;
#endif // NET7_0_OR_GREATER
        }

#endif
    }
}
