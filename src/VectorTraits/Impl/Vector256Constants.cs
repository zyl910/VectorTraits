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

#endif
    }
}
