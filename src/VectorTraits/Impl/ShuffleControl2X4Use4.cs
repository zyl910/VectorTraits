using System;
using System.Collections.Generic;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics.X86;
#endif

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// Shuffle control constants for "In 2 * 4-bit groups, 4 values are used" ("2 * 4-位组中, 使用4种值"的换位控制常数) .
    /// </summary>
    /// <remarks>
    /// <para>Constant names are referenced to HLSL(High-level shader language)/GLSL(OpenGL Shading Language), using the Little-Endian mode. </para>
    /// </remarks>
    /// <seealso cref="Avx.Permute2x128(System.Runtime.Intrinsics.Vector256{byte}, System.Runtime.Intrinsics.Vector256{byte}, byte)"/>
    public static class ShuffleControl2X4Use4 {
        /// <summary>XX := (0 &lt;&lt; 4) | 0 = 0x00 = 0 .</summary>
        public const byte XX = 0x00;
        /// <summary>YX := (0 &lt;&lt; 4) | 1 = 0x01 = 1 .</summary>
        public const byte YX = 0x01;
        /// <summary>ZX := (0 &lt;&lt; 4) | 2 = 0x02 = 2 .</summary>
        public const byte ZX = 0x02;
        /// <summary>WX := (0 &lt;&lt; 4) | 3 = 0x03 = 3 .</summary>
        public const byte WX = 0x03;
        /// <summary>OX := (0 &lt;&lt; 4) | 8 = 0x08 = 8 .</summary>
        public const byte OX = 0x08;
        /// <summary>XY := (1 &lt;&lt; 4) | 0 = 0x10 = 16 .</summary>
        public const byte XY = 0x10;
        /// <summary>YY := (1 &lt;&lt; 4) | 1 = 0x11 = 17 .</summary>
        public const byte YY = 0x11;
        /// <summary>ZY := (1 &lt;&lt; 4) | 2 = 0x12 = 18 .</summary>
        public const byte ZY = 0x12;
        /// <summary>WY := (1 &lt;&lt; 4) | 3 = 0x13 = 19 .</summary>
        public const byte WY = 0x13;
        /// <summary>OY := (1 &lt;&lt; 4) | 8 = 0x18 = 24 .</summary>
        public const byte OY = 0x18;
        /// <summary>XZ := (2 &lt;&lt; 4) | 0 = 0x20 = 32 .</summary>
        public const byte XZ = 0x20;
        /// <summary>YZ := (2 &lt;&lt; 4) | 1 = 0x21 = 33 .</summary>
        public const byte YZ = 0x21;
        /// <summary>ZZ := (2 &lt;&lt; 4) | 2 = 0x22 = 34 .</summary>
        public const byte ZZ = 0x22;
        /// <summary>WZ := (2 &lt;&lt; 4) | 3 = 0x23 = 35 .</summary>
        public const byte WZ = 0x23;
        /// <summary>OZ := (2 &lt;&lt; 4) | 8 = 0x28 = 40 .</summary>
        public const byte OZ = 0x28;
        /// <summary>XW := (3 &lt;&lt; 4) | 0 = 0x30 = 48 .</summary>
        public const byte XW = 0x30;
        /// <summary>YW := (3 &lt;&lt; 4) | 1 = 0x31 = 49 .</summary>
        public const byte YW = 0x31;
        /// <summary>ZW := (3 &lt;&lt; 4) | 2 = 0x32 = 50 .</summary>
        public const byte ZW = 0x32;
        /// <summary>WW := (3 &lt;&lt; 4) | 3 = 0x33 = 51 .</summary>
        public const byte WW = 0x33;
        /// <summary>OW := (3 &lt;&lt; 4) | 8 = 0x38 = 56 .</summary>
        public const byte OW = 0x38;
        /// <summary>XO := (8 &lt;&lt; 4) | 0 = 0x80 = 128 .</summary>
        public const byte XO = 0x80;
        /// <summary>YO := (8 &lt;&lt; 4) | 1 = 0x81 = 129 .</summary>
        public const byte YO = 0x81;
        /// <summary>ZO := (8 &lt;&lt; 4) | 2 = 0x82 = 130 .</summary>
        public const byte ZO = 0x82;
        /// <summary>WO := (8 &lt;&lt; 4) | 3 = 0x83 = 131 .</summary>
        public const byte WO = 0x83;
        /// <summary>OO := (8 &lt;&lt; 4) | 8 = 0x88 = 136 .</summary>
        public const byte OO = 0x88;
    }
}
