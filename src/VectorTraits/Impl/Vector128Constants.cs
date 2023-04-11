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
    public static class Vector128Constants {
#if NETCOREAPP3_0_OR_GREATER

        /// <summary>Serial value with rotate 8.</summary>
        public static readonly Vector128<byte> SerialRotate8 = Vector128.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7);


        /// <summary>Shuffle - UInt16 - The multiplier.</summary>
        [CLSCompliant(false)]
        public static readonly Vector128<ushort> Shuffle_UInt16_Multiplier = Vector128.Create((ushort)0x202);
        /// <summary>Shuffle - UInt16 - The offset of each byte within an element.</summary>
        public static readonly Vector128<byte> Shuffle_UInt16_ByteOffset = Vector128s.CreateRotate<byte>(0, 1);

        /// <summary>Shuffle - UInt32 - The multiplier.</summary>
        [CLSCompliant(false)]
        public static readonly Vector128<uint> Shuffle_UInt32_Multiplier = Vector128.Create((uint)0x2020202U);
        /// <summary>Shuffle - UInt32 - The offset of each byte within an element.</summary>
        public static readonly Vector128<byte> Shuffle_UInt32_ByteOffset = Vector128s.CreateRotate<byte>(0, 1, 2, 3);

        /// <summary>Shuffle - UInt64 - The multiplier.</summary>
        [CLSCompliant(false)]
        public static readonly Vector128<ulong> Shuffle_UInt64_Multiplier = Vector128.Create((ulong)0x202020202020202UL);
        /// <summary>Shuffle - UInt64 - The offset of each byte within an element.</summary>
        public static readonly Vector128<byte> Shuffle_UInt64_ByteOffset = Vector128s.CreateRotate<byte>(0, 1, 2, 3, 4, 5, 6, 7);

#endif
    }
}
