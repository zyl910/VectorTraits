using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Runtime.CompilerServices;
using System.Threading;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// The constants used in <see cref="Vector128{T}"/> methods (<see cref="Vector128{T}"/> 方法所用的常数).
    /// </summary>
    public static class Vector128Constants {
#if NETCOREAPP3_0_OR_GREATER

        #region Vectors_T
        // == Vectors_T: originate from Vectors<T> ==

        #endregion // Vectors_T

        #region Shared
        // == Shared ==

        /// <summary>Serial value with rotate 8.</summary>
        public static readonly Vector128<byte> SerialRotate8 = Vector128.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7);

        #endregion // Shared

        #region TraitsMethod
        // == TraitsMethod ==

#if !NET5_0_OR_GREATER
        private static readonly Vector128<ushort> m_Shuffle_UInt16_Multiplier = Vector128.Create((ushort)0x202);
#endif // !NET5_0_OR_GREATER
        /// <summary>Shuffle - UInt16 - The multiplier.</summary>
        [CLSCompliant(false)]
        public static Vector128<ushort> Shuffle_UInt16_Multiplier {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET5_0_OR_GREATER
                return Vector128.Create((ushort)0x202);
#else
                return m_Shuffle_UInt16_Multiplier;
#endif // NET5_0_OR_GREATER
            }
        }

        private static readonly Vector128<byte> m_Shuffle_UInt16_ByteOffset = Vector128s.CreateRotate<byte>(0, 1);
        /// <summary>Shuffle - UInt16 - The offset of each byte within an element.</summary>
        public static Vector128<byte> Shuffle_UInt16_ByteOffset {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                return m_Shuffle_UInt16_ByteOffset;
            }
        }

        /// <summary>Shuffle - UInt32 - The multiplier.</summary>
        [CLSCompliant(false)]
        public static readonly Vector128<uint> Shuffle_UInt32_Multiplier = Vector128.Create((uint)0x4040404U);
        /// <summary>Shuffle - UInt32 - The offset of each byte within an element.</summary>
        public static readonly Vector128<byte> Shuffle_UInt32_ByteOffset = Vector128s.CreateRotate<byte>(0, 1, 2, 3);

        /// <summary>Shuffle - UInt64 - The multiplier.</summary>
        [CLSCompliant(false)]
        public static readonly Vector128<ulong> Shuffle_UInt64_Multiplier = Vector128.Create((ulong)0x808080808080808UL);
        /// <summary>Shuffle - UInt64 - The offset of each byte within an element.</summary>
        public static readonly Vector128<byte> Shuffle_UInt64_ByteOffset = Vector128s.CreateRotate<byte>(0, 1, 2, 3, 4, 5, 6, 7);


        /// <summary>YShuffleG2 - Byte - The indices.</summary>
        public static readonly Vector128<byte>[] YShuffleG2_Byte_Indices = {
            Vector128.Create((byte)0, 0, 2, 2, 4, 4, 6, 6, 8, 8, 10, 10, 12, 12, 14, 14), // XX
            Vector128.Create((byte)1, 0, 3, 2, 5, 4, 7, 6, 9, 8, 11, 10, 13, 12, 15, 14), // YX
            Vector128.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15), // XY
            Vector128.Create((byte)1, 1, 3, 3, 5, 5, 7, 7, 9, 9, 11, 11, 13, 13, 15, 15), // YY
        };

        /// <summary>YShuffleG2 - UInt16 - The byte indices.</summary>
        public static readonly Vector128<byte>[] YShuffleG2_UInt16_ByteIndices = {
            Vector128.Create((byte)0, 1, 0, 1, 4, 5, 4, 5, 8, 9,  8,  9, 12, 13, 12, 13), // XX
            Vector128.Create((byte)2, 3, 0, 1, 6, 7, 4, 5, 10, 11, 8, 9, 14, 15, 12, 13), // YX
            Vector128.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15), // XY
            Vector128.Create((byte)2, 3, 2, 3, 6, 7, 6, 7,10,11, 10, 11, 14, 15, 14, 15), // YY
        };

        /// <summary>YShuffleG2 - UInt32 - The byte indices.</summary>
        public static readonly Vector128<byte>[] YShuffleG2_UInt32_ByteIndices = {
            Vector128.Create((byte)0, 1, 2, 3, 0, 1, 2, 3, 8, 9, 10, 11,  8,  9, 10, 11), // XX
            Vector128.Create((byte)4, 5, 6, 7, 0, 1, 2, 3, 12, 13, 14, 15, 8, 9, 10, 11), // YX
            Vector128.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15), // XY
            Vector128.Create((byte)4, 5, 6, 7, 4, 5, 6, 7,12,13, 14, 15, 12, 13, 14, 15), // YY
        };

        /// <summary>YShuffleG2 - UInt64 - The byte indices.</summary>
        public static readonly Vector128<byte>[] YShuffleG2_UInt64_ByteIndices = {
            Vector128.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 0, 1,  2,  3,  4,  5,  6,  7), // XX
            Vector128.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 0, 1, 2, 3, 4, 5, 6, 7), // YX
            Vector128.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15), // XY
            Vector128.Create((byte)8, 9,10,11,12,13,14,15, 8, 9, 10, 11, 12, 13, 14, 15), // YY
        };


        /// <summary>YShuffleG4 - Byte - The indices.</summary>
        public static readonly Vector128<byte>[] YShuffleG4_Byte_Indices = new Vector128<byte>[256];
        /// <summary>YShuffleG4 - UInt16 - The byte indices.</summary>
        public static readonly Vector128<byte>[] YShuffleG4_UInt16_ByteIndices = new Vector128<byte>[256];
        /// <summary>YShuffleG4 - UInt32 - The byte indices.</summary>
        public static readonly Vector128<byte>[] YShuffleG4_UInt32_ByteIndices = new Vector128<byte>[256];

        /// <summary>YShuffleG4X2 - UInt64 - The byte indices (result0_indices0, result0_indices1, result1_indices0, result1_indices1) .</summary>
        public static readonly Vector128<byte>[] YShuffleG4X2_UInt64_ByteIndices = new Vector128<byte>[256 * 4];

        #endregion // TraitsMethod


        static Vector128Constants() {
            // == YShuffleG4, YShuffleG4X2 ==
            int idx = 0;
            var vectorX4Bytes = new byte[Vector128<byte>.Count * 4];
            for (int ctl = 0; ctl <= 255; ++ctl) {
                Vector128<byte> indices = default;
                ref byte q = ref Unsafe.As<Vector128<byte>, byte>(ref indices);
                // -- Byte --
                for (int i = 0; i < Vector128<byte>.Count; ++i) {
                    int selectedIndex = (i & (~3)) | ((ctl >> ((i & 3) * 2)) & 3);
                    Unsafe.Add(ref q, i) = (byte)selectedIndex;
                }
                YShuffleG4_Byte_Indices[ctl] = indices;
                // -- UInt16 --
                //Vector128<ushort> indicesUInt16 = default;
                //ref ushort qUInt16 = ref Unsafe.As<Vector128<ushort>, ushort>(ref indicesUInt16);
                idx = 0;
                for (int i = 0; i < Vector128<ushort>.Count; ++i) {
                    int selectedIndex = (i & (~3)) | ((ctl >> ((i & 3) * 2)) & 3);
                    // Byte indices
                    int byteSize = sizeof(ushort);
                    int m = selectedIndex * byteSize;
                    for (int j = 0; j < byteSize; ++j) {
                        Unsafe.Add(ref q, idx++) = (byte)(m + j);
                    }
                }
                YShuffleG4_UInt16_ByteIndices[ctl] = indices;
                // -- UInt32 --
                //Vector128<uint> indicesUInt32 = default;
                //ref uint qUInt32 = ref Unsafe.As<Vector128<uint>, uint>(ref indicesUInt32);
                idx = 0;
                for (int i = 0; i < Vector128<uint>.Count; ++i) {
                    int selectedIndex = (i & (~3)) | ((ctl >> ((i & 3) * 2)) & 3);
                    //Unsafe.Add(ref qUInt32, i) = (uint)selectedIndex;
                    // Byte indices
                    int byteSize = sizeof(uint);
                    int m = selectedIndex * byteSize;
                    for (int j = 0; j < byteSize; ++j) {
                        Unsafe.Add(ref q, idx++) = (byte)(m + j);
                    }
                }
                YShuffleG4_UInt32_ByteIndices[ctl] = indices;
                // -- UInt64 - X2 --
                const byte byFillZero = (byte)0xFFU; // VectorTableLookup: 0xFF is is out of range, so it will be set to 0. That can be used for the next `or` operation.
                for (int i = 0; i < 4; ++i) {
                    int selectedIndex = (i & (~3)) | ((ctl >> ((i & 3) * 2)) & 3);
                    // Byte indices
                    int byteSize = sizeof(ulong);
                    int m = (selectedIndex & 1) * byteSize;
                    idx = (i & 1) * byteSize;
                    if (i >= 2) {
                        idx += Vector128<byte>.Count * 2;
                    }
                    for (int j = 0; j < byteSize; ++j) {
                        byte by = (byte)(m + j);
                        if (selectedIndex < 2) {
                            // lo
                            vectorX4Bytes[idx + Vector128<byte>.Count * 0] = by;
                            vectorX4Bytes[idx + Vector128<byte>.Count * 1] = byFillZero;
                        } else {
                            // hi
                            vectorX4Bytes[idx + Vector128<byte>.Count * 0] = byFillZero;
                            vectorX4Bytes[idx + Vector128<byte>.Count * 1] = by;
                        }
                        //if (i < 2) {
                        //    // (result0_indices0, result0_indices1)
                        //    if (selectedIndex < 2) {
                        //        // lo
                        //        vectorX4Bytes[idx + Vector128<byte>.Count * 0] = by;
                        //        vectorX4Bytes[idx + Vector128<byte>.Count * 1] = byFillZero;
                        //    } else {
                        //        // hi
                        //        vectorX4Bytes[idx + Vector128<byte>.Count * 2] = by;
                        //        vectorX4Bytes[idx + Vector128<byte>.Count * 3] = byFillZero;
                        //    }
                        //} else {
                        //    // (result1_indices0, result1_indices1)
                        //    if (selectedIndex < 2) {
                        //        // lo
                        //        vectorX4Bytes[idx + Vector128<byte>.Count * 0] = byFillZero;
                        //        vectorX4Bytes[idx + Vector128<byte>.Count * 2] = by;
                        //    } else {
                        //        // hi
                        //        vectorX4Bytes[idx + Vector128<byte>.Count * 1] = byFillZero;
                        //        vectorX4Bytes[idx + Vector128<byte>.Count * 3] = by;
                        //    }
                        //}
                        ++idx;
                    }
                }
                idx = ctl * 4;
                for (int i = 0; i < 4; ++i) {
                    //int n = ((i & 2) >> 1) | ((i & 1) << 1);
                    int n = i;
                    YShuffleG4X2_UInt64_ByteIndices[idx + i] = Unsafe.As<byte, Vector128<byte>>(ref vectorX4Bytes[Vector128<byte>.Count * n]);
                }
            } // ctl
            // Done.
            // Debug.Break.
            //Trace.WriteLine(string.Format("YShuffleG4X2_UInt64_ByteIndices.Length: {0}", YShuffleG4X2_UInt64_ByteIndices.Length));
        }

#endif
    }
}
