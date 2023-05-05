using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// The constants used in <see cref="Vector256{T}"/> methods (<see cref="Vector256{T}"/> 方法所用的常数).
    /// </summary>
    public static class Vector256Constants {
#if NETCOREAPP3_0_OR_GREATER

        #region Vectors_T
        // == Vectors_T: originate from Vectors<T> ==

        /// <summary>Value 255 (byte.MaxValue).</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> VMaxByte_UInt16 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET5_0_OR_GREATER
                return Vector256.Create((ushort)byte.MaxValue); // .NET5+ has better performance .
#else
                return Vector256s<ushort>.VMaxByte;
#endif // NET5_0_OR_GREATER
            }
        }

        #endregion // Vectors_T

        #region Shared
        // == Shared ==

        #endregion // Shared

        #region TraitsMethod
        // == TraitsMethod ==

        /// <summary>ExtractMostSignificantBits - Shuffle - Get high byte of 16bit.</summary>
        public static readonly Vector256<byte> ExtractMostSignificantBits_Shuffle_HiByteOf16 = Vector256.Create((byte)1, 3, 5, 7, 9, 11, 13, 15, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 1, 3, 5, 7, 9, 11, 13, 15, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80);

#if !NET5_0_OR_GREATER
        private static readonly Vector256<byte> m_Shuffle_Byte_LaneAdd_K0 = Vector256.Create(0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0);
#endif // !NET5_0_OR_GREATER
        /// <summary>Shuffle - Byte - LaneAdd - K0 .</summary>
        public static Vector256<byte> Shuffle_Byte_LaneAdd_K0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET5_0_OR_GREATER
                return Vector256.Create(0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0);
#else
                return m_Shuffle_Byte_LaneAdd_K0;
#endif // NET5_0_OR_GREATER
            }
        }

#if !NET5_0_OR_GREATER
        private static readonly Vector256<byte> m_Shuffle_Byte_LaneAdd_K1 = Vector256.Create(0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70);
#endif // !NET5_0_OR_GREATER
        /// <summary>Shuffle - Byte - LaneAdd - K1 .</summary>
        public static Vector256<byte> Shuffle_Byte_LaneAdd_K1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET5_0_OR_GREATER
                return Vector256.Create(0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70);
#else
                return m_Shuffle_Byte_LaneAdd_K1;
#endif // NET5_0_OR_GREATER
            }
        }

        /// <summary>Shuffle - UInt16 - The multiplier.</summary>
        [CLSCompliant(false)]
        public static readonly Vector256<ushort> Shuffle_UInt16_Multiplier = Vector256.Create((ushort)0x202);
        /// <summary>Shuffle - UInt16 - The offset of each byte within an element.</summary>
        public static readonly Vector256<byte> Shuffle_UInt16_ByteOffset = Vector256s.CreateRotate<byte>(0, 1);

        /// <summary>Shuffle - UInt64 - The multiplier.</summary>
        [CLSCompliant(false)]
        public static readonly Vector256<ulong> Shuffle_UInt64_Multiplier = Vector256.Create((ulong)0x200000002UL);
        /// <summary>Shuffle - UInt64 - The offset of each byte within an element.</summary>
        [CLSCompliant(false)]
        public static readonly Vector256<uint> Shuffle_UInt64_UInt32Offset = Vector256s.CreateRotate<uint>(0, 1);


        /// <summary>YShuffleG2 - Byte - The indices.</summary>
        public static readonly Vector256<byte>[] YShuffleG2_Byte_Indices = {
            Vector256.Create((byte)0, 0, 2, 2, 4, 4, 6, 6, 8, 8, 10, 10, 12, 12, 14, 14, 16, 16, 18, 18, 20, 20, 22, 22, 24, 24, 26, 26, 28, 28, 30, 30), // XX
            Vector256.Create((byte)1, 0, 3, 2, 5, 4, 7, 6, 9, 8, 11, 10, 13, 12, 15, 14, 17, 16, 19, 18, 21, 20, 23, 22, 25, 24, 27, 26, 29, 28, 31, 30), // YX
            Vector256.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31), // XY
            Vector256.Create((byte)1, 1, 3, 3, 5, 5, 7, 7, 9, 9, 11, 11, 13, 13, 15, 15, 17, 17, 19, 19, 21, 21, 23, 23, 25, 25, 27, 27, 29, 29, 31, 31), // YY
        };

        /// <summary>YShuffleG2 - UInt16 - The byte indices.</summary>
        public static readonly Vector256<byte>[] YShuffleG2_UInt16_ByteIndices = {
            Vector256.Create((byte)0, 1, 0, 1, 4, 5, 4, 5, 8, 9,  8,  9, 12, 13, 12, 13, 16, 17, 16, 17, 20, 21, 20, 21, 24, 25, 24, 25, 28, 29, 28, 29), // XX
            Vector256.Create((byte)2, 3, 0, 1, 6, 7, 4, 5, 10, 11, 8, 9, 14, 15, 12, 13, 18, 19, 16, 17, 22, 23, 20, 21, 26, 27, 24, 25, 30, 31, 28, 29), // YX
            Vector256.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31), // XY
            Vector256.Create((byte)2, 3, 2, 3, 6, 7, 6, 7,10,11, 10, 11, 14, 15, 14, 15, 18, 19, 18, 19, 22, 23, 22, 23, 26, 27, 26, 27, 30, 31, 30, 31), // YY
        };

#if !REDUCE_MEMORY_USAGE
        /// <summary>YShuffleG2 - UInt32 - The uint32 indices.</summary>
        [CLSCompliant(false)]
        public static readonly Vector256<uint>[] YShuffleG2_UInt32_Indices = {
            Vector256.Create((uint)0, 0, 2, 2, 4, 4, 6, 6), // XX
            Vector256.Create((uint)1, 0, 3, 2, 5, 4, 7, 6), // YX
            Vector256.Create((uint)0, 1, 2, 3, 4, 5, 6, 7), // XY
            Vector256.Create((uint)1, 1, 3, 3, 5, 5, 7, 7), // YY
        };
#endif // !REDUCE_MEMORY_USAGE
        /// <summary>YShuffleG2 - UInt32 - The byte indices.</summary>
        public static readonly Vector256<byte>[] YShuffleG2_UInt32_ByteIndices = {
            Vector256.Create((byte)0, 1, 2, 3, 0, 1, 2, 3, 8, 9, 10, 11,  8,  9, 10, 11, 16, 17, 18, 19, 16, 17, 18, 19, 24, 25, 26, 27, 24, 25, 26, 27), // XX
            Vector256.Create((byte)4, 5, 6, 7, 0, 1, 2, 3, 12, 13, 14, 15, 8, 9, 10, 11, 20, 21, 22, 23, 16, 17, 18, 19, 28, 29, 30, 31, 24, 25, 26, 27), // YX
            Vector256.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31), // XY
            Vector256.Create((byte)4, 5, 6, 7, 4, 5, 6, 7,12,13, 14, 15, 12, 13, 14, 15, 20, 21, 22, 23, 20, 21, 22, 23, 28, 29, 30, 31, 28, 29, 30, 31), // YY
        };

        /// <summary>YShuffleG2 - UInt64 - The byte indices.</summary>
        public static readonly Vector256<byte>[] YShuffleG2_UInt64_ByteIndices = {
            Vector256.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 0, 1,  2,  3,  4,  5,  6,  7, 16, 17, 18, 19, 20, 21, 22, 23, 16, 17, 18, 19, 20, 21, 22, 23), // XX
            Vector256.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 0, 1, 2, 3, 4, 5, 6, 7, 24, 25, 26, 27, 28, 29, 30, 31, 16, 17, 18, 19, 20, 21, 22, 23), // YX
            Vector256.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31), // XY
            Vector256.Create((byte)8, 9,10,11,12,13,14,15, 8, 9, 10, 11, 12, 13, 14, 15, 24, 25, 26, 27, 28, 29, 30, 31, 24, 25, 26, 27, 28, 29, 30, 31), // YY
        };

        /// <summary>YShuffleG4 - Byte - The indices.</summary>
        public static readonly Vector256<byte>[] YShuffleG4_Byte_Indices = new Vector256<byte>[256];
        /// <summary>YShuffleG4 - UInt16 - The byte indices.</summary>
        public static readonly Vector256<byte>[] YShuffleG4_UInt16_ByteIndices = new Vector256<byte>[256];
#if !REDUCE_MEMORY_USAGE
        /// <summary>YShuffleG4 - UInt32 - The indices.</summary>
        [CLSCompliant(false)]
        public static readonly Vector256<uint>[] YShuffleG4_UInt32_Indices = new Vector256<uint>[256];
#endif // !REDUCE_MEMORY_USAGE
        /// <summary>YShuffleG4 - UInt32 - The byte indices.</summary>
        public static readonly Vector256<byte>[] YShuffleG4_UInt32_ByteIndices = new Vector256<byte>[256];
        /// <summary>YShuffleG4 - UInt64 - The byte indices.</summary>
        public static readonly Vector256<byte>[] YShuffleG4_UInt64_ByteIndices = new Vector256<byte>[256];
        /// <summary>YShuffleG4 - UInt64 - The UInt32 indices.</summary>
        [CLSCompliant(false)]
        public static readonly Vector256<uint>[] YShuffleG4_UInt64_UInt32Indices = new Vector256<uint>[256];

        #endregion // TraitsMethod

        static Vector256Constants() {
            // == YShuffleG4 ==
            for (int ctl = 0; ctl <= 255; ++ctl) {
                int idx;
                Vector256<byte> indices = default;
                ref byte q = ref Unsafe.As<Vector256<byte>, byte>(ref indices);
                // -- Byte --
                for (int i = 0; i < Vector256<byte>.Count; ++i) {
                    int selectedIndex = (i & (~3)) | ((ctl >> ((i & 3) * 2)) & 3);
                    Unsafe.Add(ref q, i) = (byte)selectedIndex;
                }
                YShuffleG4_Byte_Indices[ctl] = indices;
                // -- UInt16 --
                Vector256<ushort> indicesUInt16 = default;
                ref ushort qUInt16 = ref Unsafe.As<Vector256<ushort>, ushort>(ref indicesUInt16);
                idx = 0;
                for (int i = 0; i < Vector256<ushort>.Count; ++i) {
                    int selectedIndex = (i & (~3)) | ((ctl >> ((i & 3) * 2)) & 3);
                    Unsafe.Add(ref qUInt16, i) = (ushort)selectedIndex;
                    // Byte indices
                    int byteSize = sizeof(ushort);
                    int m = selectedIndex * byteSize;
                    for (int j = 0; j < byteSize; ++j) {
                        Unsafe.Add(ref q, idx++) = (byte)(m + j);
                    }
                }
                YShuffleG4_UInt16_ByteIndices[ctl] = indices;
                // -- UInt32 --
                Vector256<uint> indicesUInt32 = default;
                ref uint qUInt32 = ref Unsafe.As<Vector256<uint>, uint>(ref indicesUInt32);
                idx = 0;
                for (int i = 0; i < Vector256<uint>.Count; ++i) {
                    int selectedIndex = (i & (~3)) | ((ctl >> ((i & 3) * 2)) & 3);
                    Unsafe.Add(ref qUInt32, i) = (uint)selectedIndex;
                    // Byte indices
                    int byteSize = sizeof(uint);
                    int m = selectedIndex * byteSize;
                    for (int j = 0; j < byteSize; ++j) {
                        Unsafe.Add(ref q, idx++) = (byte)(m + j);
                    }
                }
#if !REDUCE_MEMORY_USAGE
                YShuffleG4_UInt32_Indices[ctl] = indicesUInt32;
#endif // !REDUCE_MEMORY_USAGE
                YShuffleG4_UInt32_ByteIndices[ctl] = indices;
                // -- UInt64 --
                Vector256<ulong> indicesUInt64 = default;
                ref ulong qUInt64 = ref Unsafe.As<Vector256<ulong>, ulong>(ref indicesUInt64);
                idx = 0;
                int idxUInt32 = 0;
                for (int i = 0; i < Vector256<ulong>.Count; ++i) {
                    int selectedIndex = (i & (~3)) | ((ctl >> ((i & 3) * 2)) & 3);
                    Unsafe.Add(ref qUInt64, i) = (ulong)selectedIndex;
                    // Byte indices
                    int byteSize = sizeof(ulong);
                    int m = selectedIndex * byteSize;
                    for (int j = 0; j < byteSize; ++j) {
                        Unsafe.Add(ref q, idx++) = (byte)(m + j);
                    }
                    // UInt32 indices
                    int itemSize = sizeof(ulong) / sizeof(uint);
                    m = selectedIndex * itemSize;
                    for (int j = 0; j < itemSize; ++j) {
                        Unsafe.Add(ref qUInt32, idxUInt32++) = (byte)(m + j);
                    }
                }
                YShuffleG4_UInt64_ByteIndices[ctl] = indices;
                YShuffleG4_UInt64_UInt32Indices[ctl] = indicesUInt32;
            } // ctl

        }

#endif
    }
}
