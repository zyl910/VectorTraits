using System;
using System.Collections.Generic;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// The constants used in <see cref="Vector256{T}"/> methods (<see cref="Vector256{T}"/> 方法所用的常数).
    /// </summary>
    public static class Vector256Constants {
#if NETCOREAPP3_0_OR_GREATER

        /// <summary>ExtractMostSignificantBits - Shuffle - Get high byte of 16bit.</summary>
        public static readonly Vector256<byte> ExtractMostSignificantBits_Shuffle_HiByteOf16 = Vector256.Create((byte)1, 3, 5, 7, 9, 11, 13, 15, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 1, 3, 5, 7, 9, 11, 13, 15, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80);

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

#endif
    }
}
