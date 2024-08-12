using System;
using System.Collections.Generic;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
#endif
using System.Text;
using Zyl.VectorTraits.Numerics;

namespace Zyl.VectorTraits.Impl {

    /// <summary>
    /// Shuffle control constants for "2-element group" at 256 bits vector ("2元素组"在256位向量时的换位控制常数) .
    /// </summary>
    /// <remarks>
    /// <para>Constant names are referenced to HLSL(High-level shader language)/GLSL(OpenGL Shading Language), using the Little-Endian mode (常量名参考了 HLSL(高级着色语言)/GLSL(OpenGL着色语言), 使用的是小端模式). </para>
    /// </remarks>
    /// <seealso cref="BitMathCore._MM_SHUFFLE2(byte, byte)"/>
    /// <seealso cref="BitMathCore.GetByteBy4XBitR(byte, byte, byte, byte)"/>
    /// <seealso cref="ShuffleControlG2"/>
    /// <seealso cref="ShuffleControlG2On512"/>
    /// <seealso cref="Avx.Shuffle(Vector256{double}, Vector256{double}, byte)"/>
    public enum ShuffleControlG2On256 : byte {
        /// <summary>XXXX := GetByteBy4XBitR(0, 0, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x00 = 0 .</summary>
        XXXX = 0x00,
        /// <summary>YXXX := GetByteBy4XBitR(1, 0, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x01 = 1 .</summary>
        YXXX = 0x01,
        /// <summary>XYXX := GetByteBy4XBitR(0, 1, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x02 = 2 .</summary>
        XYXX = 0x02,
        /// <summary>YYXX := GetByteBy4XBitR(1, 1, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x03 = 3 .</summary>
        YYXX = 0x03,
        /// <summary>XXYX := GetByteBy4XBitR(0, 0, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x04 = 4 .</summary>
        XXYX = 0x04,
        /// <summary>YXYX := GetByteBy4XBitR(1, 0, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x05 = 5 .</summary>
        YXYX = 0x05,
        /// <summary>XYYX := GetByteBy4XBitR(0, 1, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x06 = 6 .</summary>
        XYYX = 0x06,
        /// <summary>YYYX := GetByteBy4XBitR(1, 1, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x07 = 7 .</summary>
        YYYX = 0x07,
        /// <summary>XXXY := GetByteBy4XBitR(0, 0, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x08 = 8 .</summary>
        XXXY = 0x08,
        /// <summary>YXXY := GetByteBy4XBitR(1, 0, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x09 = 9 .</summary>
        YXXY = 0x09,
        /// <summary>XYXY := GetByteBy4XBitR(0, 1, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x0A = 10 .</summary>
        XYXY = 0x0A,
        /// <summary>YYXY := GetByteBy4XBitR(1, 1, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x0B = 11 .</summary>
        YYXY = 0x0B,
        /// <summary>XXYY := GetByteBy4XBitR(0, 0, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x0C = 12 .</summary>
        XXYY = 0x0C,
        /// <summary>YXYY := GetByteBy4XBitR(1, 0, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x0D = 13 .</summary>
        YXYY = 0x0D,
        /// <summary>XYYY := GetByteBy4XBitR(0, 1, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x0E = 14 .</summary>
        XYYY = 0x0E,
        /// <summary>YYYY := GetByteBy4XBitR(1, 1, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x0F = 15 .</summary>
        YYYY = 0x0F
    }

}
