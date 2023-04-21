using System;
using System.Collections.Generic;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// The constants used in <see cref="Vector128{T}"/> methods (<see cref="Vector128{T}"/> 方法所用的常数).
    /// </summary>
    internal static class Vector128Constants {
#if NETCOREAPP3_0_OR_GREATER

        /// <summary>Serial value with rotate 8.</summary>
        public static readonly Vector128<byte> SerialRotate8 = Vector128.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7);


        /// <summary>Shuffle - UInt16 - The multiplier.</summary>
        public static readonly Vector128<ushort> Shuffle_UInt16_Multiplier = Vector128.Create((ushort)0x202);
        /// <summary>Shuffle - UInt16 - The offset of each byte within an element.</summary>
        public static readonly Vector128<byte> Shuffle_UInt16_ByteOffset = Vector128s.CreateRotate<byte>(0, 1);

        /// <summary>Shuffle - UInt32 - The multiplier.</summary>
        public static readonly Vector128<uint> Shuffle_UInt32_Multiplier = Vector128.Create((uint)0x4040404U);
        /// <summary>Shuffle - UInt32 - The offset of each byte within an element.</summary>
        public static readonly Vector128<byte> Shuffle_UInt32_ByteOffset = Vector128s.CreateRotate<byte>(0, 1, 2, 3);

        /// <summary>Shuffle - UInt64 - The multiplier.</summary>
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

#endif
    }
}
