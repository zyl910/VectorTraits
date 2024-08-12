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
    /// Shuffle control constants for "2-element group" at 512 bits vector ("2元素组"在512位向量时的换位控制常数) .
    /// </summary>
    /// <remarks>
    /// <para>Constant names are referenced to HLSL(High-level shader language)/GLSL(OpenGL Shading Language), using the Little-Endian mode (常量名参考了 HLSL(高级着色语言)/GLSL(OpenGL着色语言), 使用的是小端模式). </para>
    /// </remarks>
    /// <seealso cref="BitMathCore._MM_SHUFFLE2(byte, byte)"/>
    /// <seealso cref="BitMathCore.GetByteBy8XBitR(byte, byte, byte, byte, byte, byte, byte, byte)"/>
    /// <seealso cref="ShuffleControlG2"/>
    /// <seealso cref="ShuffleControlG2On256"/>
    /// <seealso cref="Avx512F.Shuffle(Vector512{double}, Vector512{double}, byte)"/>
    public enum ShuffleControlG2On512 : byte {
        /// <summary>XXXXXXXX := GetByteBy8XBitR(0, 0, 0, 0, 0, 0, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x00 = 0 .</summary>
        XXXXXXXX = 0x00,
        /// <summary>YXXXXXXX := GetByteBy8XBitR(1, 0, 0, 0, 0, 0, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x01 = 1 .</summary>
        YXXXXXXX = 0x01,
        /// <summary>XYXXXXXX := GetByteBy8XBitR(0, 1, 0, 0, 0, 0, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x02 = 2 .</summary>
        XYXXXXXX = 0x02,
        /// <summary>YYXXXXXX := GetByteBy8XBitR(1, 1, 0, 0, 0, 0, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x03 = 3 .</summary>
        YYXXXXXX = 0x03,
        /// <summary>XXYXXXXX := GetByteBy8XBitR(0, 0, 1, 0, 0, 0, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x04 = 4 .</summary>
        XXYXXXXX = 0x04,
        /// <summary>YXYXXXXX := GetByteBy8XBitR(1, 0, 1, 0, 0, 0, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x05 = 5 .</summary>
        YXYXXXXX = 0x05,
        /// <summary>XYYXXXXX := GetByteBy8XBitR(0, 1, 1, 0, 0, 0, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x06 = 6 .</summary>
        XYYXXXXX = 0x06,
        /// <summary>YYYXXXXX := GetByteBy8XBitR(1, 1, 1, 0, 0, 0, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x07 = 7 .</summary>
        YYYXXXXX = 0x07,
        /// <summary>XXXYXXXX := GetByteBy8XBitR(0, 0, 0, 1, 0, 0, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x08 = 8 .</summary>
        XXXYXXXX = 0x08,
        /// <summary>YXXYXXXX := GetByteBy8XBitR(1, 0, 0, 1, 0, 0, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x09 = 9 .</summary>
        YXXYXXXX = 0x09,
        /// <summary>XYXYXXXX := GetByteBy8XBitR(0, 1, 0, 1, 0, 0, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x0A = 10 .</summary>
        XYXYXXXX = 0x0A,
        /// <summary>YYXYXXXX := GetByteBy8XBitR(1, 1, 0, 1, 0, 0, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x0B = 11 .</summary>
        YYXYXXXX = 0x0B,
        /// <summary>XXYYXXXX := GetByteBy8XBitR(0, 0, 1, 1, 0, 0, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x0C = 12 .</summary>
        XXYYXXXX = 0x0C,
        /// <summary>YXYYXXXX := GetByteBy8XBitR(1, 0, 1, 1, 0, 0, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x0D = 13 .</summary>
        YXYYXXXX = 0x0D,
        /// <summary>XYYYXXXX := GetByteBy8XBitR(0, 1, 1, 1, 0, 0, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x0E = 14 .</summary>
        XYYYXXXX = 0x0E,
        /// <summary>YYYYXXXX := GetByteBy8XBitR(1, 1, 1, 1, 0, 0, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x0F = 15 .</summary>
        YYYYXXXX = 0x0F,
        /// <summary>XXXXYXXX := GetByteBy8XBitR(0, 0, 0, 0, 1, 0, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x10 = 16 .</summary>
        XXXXYXXX = 0x10,
        /// <summary>YXXXYXXX := GetByteBy8XBitR(1, 0, 0, 0, 1, 0, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x11 = 17 .</summary>
        YXXXYXXX = 0x11,
        /// <summary>XYXXYXXX := GetByteBy8XBitR(0, 1, 0, 0, 1, 0, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x12 = 18 .</summary>
        XYXXYXXX = 0x12,
        /// <summary>YYXXYXXX := GetByteBy8XBitR(1, 1, 0, 0, 1, 0, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x13 = 19 .</summary>
        YYXXYXXX = 0x13,
        /// <summary>XXYXYXXX := GetByteBy8XBitR(0, 0, 1, 0, 1, 0, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x14 = 20 .</summary>
        XXYXYXXX = 0x14,
        /// <summary>YXYXYXXX := GetByteBy8XBitR(1, 0, 1, 0, 1, 0, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x15 = 21 .</summary>
        YXYXYXXX = 0x15,
        /// <summary>XYYXYXXX := GetByteBy8XBitR(0, 1, 1, 0, 1, 0, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x16 = 22 .</summary>
        XYYXYXXX = 0x16,
        /// <summary>YYYXYXXX := GetByteBy8XBitR(1, 1, 1, 0, 1, 0, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x17 = 23 .</summary>
        YYYXYXXX = 0x17,
        /// <summary>XXXYYXXX := GetByteBy8XBitR(0, 0, 0, 1, 1, 0, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x18 = 24 .</summary>
        XXXYYXXX = 0x18,
        /// <summary>YXXYYXXX := GetByteBy8XBitR(1, 0, 0, 1, 1, 0, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x19 = 25 .</summary>
        YXXYYXXX = 0x19,
        /// <summary>XYXYYXXX := GetByteBy8XBitR(0, 1, 0, 1, 1, 0, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x1A = 26 .</summary>
        XYXYYXXX = 0x1A,
        /// <summary>YYXYYXXX := GetByteBy8XBitR(1, 1, 0, 1, 1, 0, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x1B = 27 .</summary>
        YYXYYXXX = 0x1B,
        /// <summary>XXYYYXXX := GetByteBy8XBitR(0, 0, 1, 1, 1, 0, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x1C = 28 .</summary>
        XXYYYXXX = 0x1C,
        /// <summary>YXYYYXXX := GetByteBy8XBitR(1, 0, 1, 1, 1, 0, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x1D = 29 .</summary>
        YXYYYXXX = 0x1D,
        /// <summary>XYYYYXXX := GetByteBy8XBitR(0, 1, 1, 1, 1, 0, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x1E = 30 .</summary>
        XYYYYXXX = 0x1E,
        /// <summary>YYYYYXXX := GetByteBy8XBitR(1, 1, 1, 1, 1, 0, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x1F = 31 .</summary>
        YYYYYXXX = 0x1F,
        /// <summary>XXXXXYXX := GetByteBy8XBitR(0, 0, 0, 0, 0, 1, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x20 = 32 .</summary>
        XXXXXYXX = 0x20,
        /// <summary>YXXXXYXX := GetByteBy8XBitR(1, 0, 0, 0, 0, 1, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x21 = 33 .</summary>
        YXXXXYXX = 0x21,
        /// <summary>XYXXXYXX := GetByteBy8XBitR(0, 1, 0, 0, 0, 1, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x22 = 34 .</summary>
        XYXXXYXX = 0x22,
        /// <summary>YYXXXYXX := GetByteBy8XBitR(1, 1, 0, 0, 0, 1, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x23 = 35 .</summary>
        YYXXXYXX = 0x23,
        /// <summary>XXYXXYXX := GetByteBy8XBitR(0, 0, 1, 0, 0, 1, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x24 = 36 .</summary>
        XXYXXYXX = 0x24,
        /// <summary>YXYXXYXX := GetByteBy8XBitR(1, 0, 1, 0, 0, 1, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x25 = 37 .</summary>
        YXYXXYXX = 0x25,
        /// <summary>XYYXXYXX := GetByteBy8XBitR(0, 1, 1, 0, 0, 1, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x26 = 38 .</summary>
        XYYXXYXX = 0x26,
        /// <summary>YYYXXYXX := GetByteBy8XBitR(1, 1, 1, 0, 0, 1, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x27 = 39 .</summary>
        YYYXXYXX = 0x27,
        /// <summary>XXXYXYXX := GetByteBy8XBitR(0, 0, 0, 1, 0, 1, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x28 = 40 .</summary>
        XXXYXYXX = 0x28,
        /// <summary>YXXYXYXX := GetByteBy8XBitR(1, 0, 0, 1, 0, 1, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x29 = 41 .</summary>
        YXXYXYXX = 0x29,
        /// <summary>XYXYXYXX := GetByteBy8XBitR(0, 1, 0, 1, 0, 1, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x2A = 42 .</summary>
        XYXYXYXX = 0x2A,
        /// <summary>YYXYXYXX := GetByteBy8XBitR(1, 1, 0, 1, 0, 1, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x2B = 43 .</summary>
        YYXYXYXX = 0x2B,
        /// <summary>XXYYXYXX := GetByteBy8XBitR(0, 0, 1, 1, 0, 1, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x2C = 44 .</summary>
        XXYYXYXX = 0x2C,
        /// <summary>YXYYXYXX := GetByteBy8XBitR(1, 0, 1, 1, 0, 1, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x2D = 45 .</summary>
        YXYYXYXX = 0x2D,
        /// <summary>XYYYXYXX := GetByteBy8XBitR(0, 1, 1, 1, 0, 1, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x2E = 46 .</summary>
        XYYYXYXX = 0x2E,
        /// <summary>YYYYXYXX := GetByteBy8XBitR(1, 1, 1, 1, 0, 1, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x2F = 47 .</summary>
        YYYYXYXX = 0x2F,
        /// <summary>XXXXYYXX := GetByteBy8XBitR(0, 0, 0, 0, 1, 1, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x30 = 48 .</summary>
        XXXXYYXX = 0x30,
        /// <summary>YXXXYYXX := GetByteBy8XBitR(1, 0, 0, 0, 1, 1, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x31 = 49 .</summary>
        YXXXYYXX = 0x31,
        /// <summary>XYXXYYXX := GetByteBy8XBitR(0, 1, 0, 0, 1, 1, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x32 = 50 .</summary>
        XYXXYYXX = 0x32,
        /// <summary>YYXXYYXX := GetByteBy8XBitR(1, 1, 0, 0, 1, 1, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x33 = 51 .</summary>
        YYXXYYXX = 0x33,
        /// <summary>XXYXYYXX := GetByteBy8XBitR(0, 0, 1, 0, 1, 1, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x34 = 52 .</summary>
        XXYXYYXX = 0x34,
        /// <summary>YXYXYYXX := GetByteBy8XBitR(1, 0, 1, 0, 1, 1, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x35 = 53 .</summary>
        YXYXYYXX = 0x35,
        /// <summary>XYYXYYXX := GetByteBy8XBitR(0, 1, 1, 0, 1, 1, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x36 = 54 .</summary>
        XYYXYYXX = 0x36,
        /// <summary>YYYXYYXX := GetByteBy8XBitR(1, 1, 1, 0, 1, 1, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x37 = 55 .</summary>
        YYYXYYXX = 0x37,
        /// <summary>XXXYYYXX := GetByteBy8XBitR(0, 0, 0, 1, 1, 1, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x38 = 56 .</summary>
        XXXYYYXX = 0x38,
        /// <summary>YXXYYYXX := GetByteBy8XBitR(1, 0, 0, 1, 1, 1, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x39 = 57 .</summary>
        YXXYYYXX = 0x39,
        /// <summary>XYXYYYXX := GetByteBy8XBitR(0, 1, 0, 1, 1, 1, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x3A = 58 .</summary>
        XYXYYYXX = 0x3A,
        /// <summary>YYXYYYXX := GetByteBy8XBitR(1, 1, 0, 1, 1, 1, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x3B = 59 .</summary>
        YYXYYYXX = 0x3B,
        /// <summary>XXYYYYXX := GetByteBy8XBitR(0, 0, 1, 1, 1, 1, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x3C = 60 .</summary>
        XXYYYYXX = 0x3C,
        /// <summary>YXYYYYXX := GetByteBy8XBitR(1, 0, 1, 1, 1, 1, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x3D = 61 .</summary>
        YXYYYYXX = 0x3D,
        /// <summary>XYYYYYXX := GetByteBy8XBitR(0, 1, 1, 1, 1, 1, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x3E = 62 .</summary>
        XYYYYYXX = 0x3E,
        /// <summary>YYYYYYXX := GetByteBy8XBitR(1, 1, 1, 1, 1, 1, 0, 0) = (_MM_SHUFFLE2(0, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (0 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x3F = 63 .</summary>
        YYYYYYXX = 0x3F,
        /// <summary>XXXXXXYX := GetByteBy8XBitR(0, 0, 0, 0, 0, 0, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x40 = 64 .</summary>
        XXXXXXYX = 0x40,
        /// <summary>YXXXXXYX := GetByteBy8XBitR(1, 0, 0, 0, 0, 0, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x41 = 65 .</summary>
        YXXXXXYX = 0x41,
        /// <summary>XYXXXXYX := GetByteBy8XBitR(0, 1, 0, 0, 0, 0, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x42 = 66 .</summary>
        XYXXXXYX = 0x42,
        /// <summary>YYXXXXYX := GetByteBy8XBitR(1, 1, 0, 0, 0, 0, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x43 = 67 .</summary>
        YYXXXXYX = 0x43,
        /// <summary>XXYXXXYX := GetByteBy8XBitR(0, 0, 1, 0, 0, 0, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x44 = 68 .</summary>
        XXYXXXYX = 0x44,
        /// <summary>YXYXXXYX := GetByteBy8XBitR(1, 0, 1, 0, 0, 0, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x45 = 69 .</summary>
        YXYXXXYX = 0x45,
        /// <summary>XYYXXXYX := GetByteBy8XBitR(0, 1, 1, 0, 0, 0, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x46 = 70 .</summary>
        XYYXXXYX = 0x46,
        /// <summary>YYYXXXYX := GetByteBy8XBitR(1, 1, 1, 0, 0, 0, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x47 = 71 .</summary>
        YYYXXXYX = 0x47,
        /// <summary>XXXYXXYX := GetByteBy8XBitR(0, 0, 0, 1, 0, 0, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x48 = 72 .</summary>
        XXXYXXYX = 0x48,
        /// <summary>YXXYXXYX := GetByteBy8XBitR(1, 0, 0, 1, 0, 0, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x49 = 73 .</summary>
        YXXYXXYX = 0x49,
        /// <summary>XYXYXXYX := GetByteBy8XBitR(0, 1, 0, 1, 0, 0, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x4A = 74 .</summary>
        XYXYXXYX = 0x4A,
        /// <summary>YYXYXXYX := GetByteBy8XBitR(1, 1, 0, 1, 0, 0, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x4B = 75 .</summary>
        YYXYXXYX = 0x4B,
        /// <summary>XXYYXXYX := GetByteBy8XBitR(0, 0, 1, 1, 0, 0, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x4C = 76 .</summary>
        XXYYXXYX = 0x4C,
        /// <summary>YXYYXXYX := GetByteBy8XBitR(1, 0, 1, 1, 0, 0, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x4D = 77 .</summary>
        YXYYXXYX = 0x4D,
        /// <summary>XYYYXXYX := GetByteBy8XBitR(0, 1, 1, 1, 0, 0, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x4E = 78 .</summary>
        XYYYXXYX = 0x4E,
        /// <summary>YYYYXXYX := GetByteBy8XBitR(1, 1, 1, 1, 0, 0, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x4F = 79 .</summary>
        YYYYXXYX = 0x4F,
        /// <summary>XXXXYXYX := GetByteBy8XBitR(0, 0, 0, 0, 1, 0, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x50 = 80 .</summary>
        XXXXYXYX = 0x50,
        /// <summary>YXXXYXYX := GetByteBy8XBitR(1, 0, 0, 0, 1, 0, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x51 = 81 .</summary>
        YXXXYXYX = 0x51,
        /// <summary>XYXXYXYX := GetByteBy8XBitR(0, 1, 0, 0, 1, 0, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x52 = 82 .</summary>
        XYXXYXYX = 0x52,
        /// <summary>YYXXYXYX := GetByteBy8XBitR(1, 1, 0, 0, 1, 0, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x53 = 83 .</summary>
        YYXXYXYX = 0x53,
        /// <summary>XXYXYXYX := GetByteBy8XBitR(0, 0, 1, 0, 1, 0, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x54 = 84 .</summary>
        XXYXYXYX = 0x54,
        /// <summary>YXYXYXYX := GetByteBy8XBitR(1, 0, 1, 0, 1, 0, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x55 = 85 .</summary>
        YXYXYXYX = 0x55,
        /// <summary>XYYXYXYX := GetByteBy8XBitR(0, 1, 1, 0, 1, 0, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x56 = 86 .</summary>
        XYYXYXYX = 0x56,
        /// <summary>YYYXYXYX := GetByteBy8XBitR(1, 1, 1, 0, 1, 0, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x57 = 87 .</summary>
        YYYXYXYX = 0x57,
        /// <summary>XXXYYXYX := GetByteBy8XBitR(0, 0, 0, 1, 1, 0, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x58 = 88 .</summary>
        XXXYYXYX = 0x58,
        /// <summary>YXXYYXYX := GetByteBy8XBitR(1, 0, 0, 1, 1, 0, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x59 = 89 .</summary>
        YXXYYXYX = 0x59,
        /// <summary>XYXYYXYX := GetByteBy8XBitR(0, 1, 0, 1, 1, 0, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x5A = 90 .</summary>
        XYXYYXYX = 0x5A,
        /// <summary>YYXYYXYX := GetByteBy8XBitR(1, 1, 0, 1, 1, 0, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x5B = 91 .</summary>
        YYXYYXYX = 0x5B,
        /// <summary>XXYYYXYX := GetByteBy8XBitR(0, 0, 1, 1, 1, 0, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x5C = 92 .</summary>
        XXYYYXYX = 0x5C,
        /// <summary>YXYYYXYX := GetByteBy8XBitR(1, 0, 1, 1, 1, 0, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x5D = 93 .</summary>
        YXYYYXYX = 0x5D,
        /// <summary>XYYYYXYX := GetByteBy8XBitR(0, 1, 1, 1, 1, 0, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x5E = 94 .</summary>
        XYYYYXYX = 0x5E,
        /// <summary>YYYYYXYX := GetByteBy8XBitR(1, 1, 1, 1, 1, 0, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x5F = 95 .</summary>
        YYYYYXYX = 0x5F,
        /// <summary>XXXXXYYX := GetByteBy8XBitR(0, 0, 0, 0, 0, 1, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x60 = 96 .</summary>
        XXXXXYYX = 0x60,
        /// <summary>YXXXXYYX := GetByteBy8XBitR(1, 0, 0, 0, 0, 1, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x61 = 97 .</summary>
        YXXXXYYX = 0x61,
        /// <summary>XYXXXYYX := GetByteBy8XBitR(0, 1, 0, 0, 0, 1, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x62 = 98 .</summary>
        XYXXXYYX = 0x62,
        /// <summary>YYXXXYYX := GetByteBy8XBitR(1, 1, 0, 0, 0, 1, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x63 = 99 .</summary>
        YYXXXYYX = 0x63,
        /// <summary>XXYXXYYX := GetByteBy8XBitR(0, 0, 1, 0, 0, 1, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x64 = 100 .</summary>
        XXYXXYYX = 0x64,
        /// <summary>YXYXXYYX := GetByteBy8XBitR(1, 0, 1, 0, 0, 1, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x65 = 101 .</summary>
        YXYXXYYX = 0x65,
        /// <summary>XYYXXYYX := GetByteBy8XBitR(0, 1, 1, 0, 0, 1, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x66 = 102 .</summary>
        XYYXXYYX = 0x66,
        /// <summary>YYYXXYYX := GetByteBy8XBitR(1, 1, 1, 0, 0, 1, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x67 = 103 .</summary>
        YYYXXYYX = 0x67,
        /// <summary>XXXYXYYX := GetByteBy8XBitR(0, 0, 0, 1, 0, 1, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x68 = 104 .</summary>
        XXXYXYYX = 0x68,
        /// <summary>YXXYXYYX := GetByteBy8XBitR(1, 0, 0, 1, 0, 1, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x69 = 105 .</summary>
        YXXYXYYX = 0x69,
        /// <summary>XYXYXYYX := GetByteBy8XBitR(0, 1, 0, 1, 0, 1, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x6A = 106 .</summary>
        XYXYXYYX = 0x6A,
        /// <summary>YYXYXYYX := GetByteBy8XBitR(1, 1, 0, 1, 0, 1, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x6B = 107 .</summary>
        YYXYXYYX = 0x6B,
        /// <summary>XXYYXYYX := GetByteBy8XBitR(0, 0, 1, 1, 0, 1, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x6C = 108 .</summary>
        XXYYXYYX = 0x6C,
        /// <summary>YXYYXYYX := GetByteBy8XBitR(1, 0, 1, 1, 0, 1, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x6D = 109 .</summary>
        YXYYXYYX = 0x6D,
        /// <summary>XYYYXYYX := GetByteBy8XBitR(0, 1, 1, 1, 0, 1, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x6E = 110 .</summary>
        XYYYXYYX = 0x6E,
        /// <summary>YYYYXYYX := GetByteBy8XBitR(1, 1, 1, 1, 0, 1, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x6F = 111 .</summary>
        YYYYXYYX = 0x6F,
        /// <summary>XXXXYYYX := GetByteBy8XBitR(0, 0, 0, 0, 1, 1, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x70 = 112 .</summary>
        XXXXYYYX = 0x70,
        /// <summary>YXXXYYYX := GetByteBy8XBitR(1, 0, 0, 0, 1, 1, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x71 = 113 .</summary>
        YXXXYYYX = 0x71,
        /// <summary>XYXXYYYX := GetByteBy8XBitR(0, 1, 0, 0, 1, 1, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x72 = 114 .</summary>
        XYXXYYYX = 0x72,
        /// <summary>YYXXYYYX := GetByteBy8XBitR(1, 1, 0, 0, 1, 1, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x73 = 115 .</summary>
        YYXXYYYX = 0x73,
        /// <summary>XXYXYYYX := GetByteBy8XBitR(0, 0, 1, 0, 1, 1, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x74 = 116 .</summary>
        XXYXYYYX = 0x74,
        /// <summary>YXYXYYYX := GetByteBy8XBitR(1, 0, 1, 0, 1, 1, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x75 = 117 .</summary>
        YXYXYYYX = 0x75,
        /// <summary>XYYXYYYX := GetByteBy8XBitR(0, 1, 1, 0, 1, 1, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x76 = 118 .</summary>
        XYYXYYYX = 0x76,
        /// <summary>YYYXYYYX := GetByteBy8XBitR(1, 1, 1, 0, 1, 1, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x77 = 119 .</summary>
        YYYXYYYX = 0x77,
        /// <summary>XXXYYYYX := GetByteBy8XBitR(0, 0, 0, 1, 1, 1, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x78 = 120 .</summary>
        XXXYYYYX = 0x78,
        /// <summary>YXXYYYYX := GetByteBy8XBitR(1, 0, 0, 1, 1, 1, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x79 = 121 .</summary>
        YXXYYYYX = 0x79,
        /// <summary>XYXYYYYX := GetByteBy8XBitR(0, 1, 0, 1, 1, 1, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x7A = 122 .</summary>
        XYXYYYYX = 0x7A,
        /// <summary>YYXYYYYX := GetByteBy8XBitR(1, 1, 0, 1, 1, 1, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x7B = 123 .</summary>
        YYXYYYYX = 0x7B,
        /// <summary>XXYYYYYX := GetByteBy8XBitR(0, 0, 1, 1, 1, 1, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x7C = 124 .</summary>
        XXYYYYYX = 0x7C,
        /// <summary>YXYYYYYX := GetByteBy8XBitR(1, 0, 1, 1, 1, 1, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x7D = 125 .</summary>
        YXYYYYYX = 0x7D,
        /// <summary>XYYYYYYX := GetByteBy8XBitR(0, 1, 1, 1, 1, 1, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x7E = 126 .</summary>
        XYYYYYYX = 0x7E,
        /// <summary>YYYYYYYX := GetByteBy8XBitR(1, 1, 1, 1, 1, 1, 1, 0) = (_MM_SHUFFLE2(0, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (0 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x7F = 127 .</summary>
        YYYYYYYX = 0x7F,
        /// <summary>XXXXXXXY := GetByteBy8XBitR(0, 0, 0, 0, 0, 0, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x80 = 128 .</summary>
        XXXXXXXY = 0x80,
        /// <summary>YXXXXXXY := GetByteBy8XBitR(1, 0, 0, 0, 0, 0, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x81 = 129 .</summary>
        YXXXXXXY = 0x81,
        /// <summary>XYXXXXXY := GetByteBy8XBitR(0, 1, 0, 0, 0, 0, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x82 = 130 .</summary>
        XYXXXXXY = 0x82,
        /// <summary>YYXXXXXY := GetByteBy8XBitR(1, 1, 0, 0, 0, 0, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x83 = 131 .</summary>
        YYXXXXXY = 0x83,
        /// <summary>XXYXXXXY := GetByteBy8XBitR(0, 0, 1, 0, 0, 0, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x84 = 132 .</summary>
        XXYXXXXY = 0x84,
        /// <summary>YXYXXXXY := GetByteBy8XBitR(1, 0, 1, 0, 0, 0, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x85 = 133 .</summary>
        YXYXXXXY = 0x85,
        /// <summary>XYYXXXXY := GetByteBy8XBitR(0, 1, 1, 0, 0, 0, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x86 = 134 .</summary>
        XYYXXXXY = 0x86,
        /// <summary>YYYXXXXY := GetByteBy8XBitR(1, 1, 1, 0, 0, 0, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x87 = 135 .</summary>
        YYYXXXXY = 0x87,
        /// <summary>XXXYXXXY := GetByteBy8XBitR(0, 0, 0, 1, 0, 0, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x88 = 136 .</summary>
        XXXYXXXY = 0x88,
        /// <summary>YXXYXXXY := GetByteBy8XBitR(1, 0, 0, 1, 0, 0, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x89 = 137 .</summary>
        YXXYXXXY = 0x89,
        /// <summary>XYXYXXXY := GetByteBy8XBitR(0, 1, 0, 1, 0, 0, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x8A = 138 .</summary>
        XYXYXXXY = 0x8A,
        /// <summary>YYXYXXXY := GetByteBy8XBitR(1, 1, 0, 1, 0, 0, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x8B = 139 .</summary>
        YYXYXXXY = 0x8B,
        /// <summary>XXYYXXXY := GetByteBy8XBitR(0, 0, 1, 1, 0, 0, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x8C = 140 .</summary>
        XXYYXXXY = 0x8C,
        /// <summary>YXYYXXXY := GetByteBy8XBitR(1, 0, 1, 1, 0, 0, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x8D = 141 .</summary>
        YXYYXXXY = 0x8D,
        /// <summary>XYYYXXXY := GetByteBy8XBitR(0, 1, 1, 1, 0, 0, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x8E = 142 .</summary>
        XYYYXXXY = 0x8E,
        /// <summary>YYYYXXXY := GetByteBy8XBitR(1, 1, 1, 1, 0, 0, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x8F = 143 .</summary>
        YYYYXXXY = 0x8F,
        /// <summary>XXXXYXXY := GetByteBy8XBitR(0, 0, 0, 0, 1, 0, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x90 = 144 .</summary>
        XXXXYXXY = 0x90,
        /// <summary>YXXXYXXY := GetByteBy8XBitR(1, 0, 0, 0, 1, 0, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x91 = 145 .</summary>
        YXXXYXXY = 0x91,
        /// <summary>XYXXYXXY := GetByteBy8XBitR(0, 1, 0, 0, 1, 0, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x92 = 146 .</summary>
        XYXXYXXY = 0x92,
        /// <summary>YYXXYXXY := GetByteBy8XBitR(1, 1, 0, 0, 1, 0, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x93 = 147 .</summary>
        YYXXYXXY = 0x93,
        /// <summary>XXYXYXXY := GetByteBy8XBitR(0, 0, 1, 0, 1, 0, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x94 = 148 .</summary>
        XXYXYXXY = 0x94,
        /// <summary>YXYXYXXY := GetByteBy8XBitR(1, 0, 1, 0, 1, 0, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x95 = 149 .</summary>
        YXYXYXXY = 0x95,
        /// <summary>XYYXYXXY := GetByteBy8XBitR(0, 1, 1, 0, 1, 0, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x96 = 150 .</summary>
        XYYXYXXY = 0x96,
        /// <summary>YYYXYXXY := GetByteBy8XBitR(1, 1, 1, 0, 1, 0, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x97 = 151 .</summary>
        YYYXYXXY = 0x97,
        /// <summary>XXXYYXXY := GetByteBy8XBitR(0, 0, 0, 1, 1, 0, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x98 = 152 .</summary>
        XXXYYXXY = 0x98,
        /// <summary>YXXYYXXY := GetByteBy8XBitR(1, 0, 0, 1, 1, 0, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x99 = 153 .</summary>
        YXXYYXXY = 0x99,
        /// <summary>XYXYYXXY := GetByteBy8XBitR(0, 1, 0, 1, 1, 0, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x9A = 154 .</summary>
        XYXYYXXY = 0x9A,
        /// <summary>YYXYYXXY := GetByteBy8XBitR(1, 1, 0, 1, 1, 0, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x9B = 155 .</summary>
        YYXYYXXY = 0x9B,
        /// <summary>XXYYYXXY := GetByteBy8XBitR(0, 0, 1, 1, 1, 0, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0x9C = 156 .</summary>
        XXYYYXXY = 0x9C,
        /// <summary>YXYYYXXY := GetByteBy8XBitR(1, 0, 1, 1, 1, 0, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0x9D = 157 .</summary>
        YXYYYXXY = 0x9D,
        /// <summary>XYYYYXXY := GetByteBy8XBitR(0, 1, 1, 1, 1, 0, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0x9E = 158 .</summary>
        XYYYYXXY = 0x9E,
        /// <summary>YYYYYXXY := GetByteBy8XBitR(1, 1, 1, 1, 1, 0, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0x9F = 159 .</summary>
        YYYYYXXY = 0x9F,
        /// <summary>XXXXXYXY := GetByteBy8XBitR(0, 0, 0, 0, 0, 1, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0xA0 = 160 .</summary>
        XXXXXYXY = 0xA0,
        /// <summary>YXXXXYXY := GetByteBy8XBitR(1, 0, 0, 0, 0, 1, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0xA1 = 161 .</summary>
        YXXXXYXY = 0xA1,
        /// <summary>XYXXXYXY := GetByteBy8XBitR(0, 1, 0, 0, 0, 1, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0xA2 = 162 .</summary>
        XYXXXYXY = 0xA2,
        /// <summary>YYXXXYXY := GetByteBy8XBitR(1, 1, 0, 0, 0, 1, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0xA3 = 163 .</summary>
        YYXXXYXY = 0xA3,
        /// <summary>XXYXXYXY := GetByteBy8XBitR(0, 0, 1, 0, 0, 1, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0xA4 = 164 .</summary>
        XXYXXYXY = 0xA4,
        /// <summary>YXYXXYXY := GetByteBy8XBitR(1, 0, 1, 0, 0, 1, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0xA5 = 165 .</summary>
        YXYXXYXY = 0xA5,
        /// <summary>XYYXXYXY := GetByteBy8XBitR(0, 1, 1, 0, 0, 1, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0xA6 = 166 .</summary>
        XYYXXYXY = 0xA6,
        /// <summary>YYYXXYXY := GetByteBy8XBitR(1, 1, 1, 0, 0, 1, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0xA7 = 167 .</summary>
        YYYXXYXY = 0xA7,
        /// <summary>XXXYXYXY := GetByteBy8XBitR(0, 0, 0, 1, 0, 1, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0xA8 = 168 .</summary>
        XXXYXYXY = 0xA8,
        /// <summary>YXXYXYXY := GetByteBy8XBitR(1, 0, 0, 1, 0, 1, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0xA9 = 169 .</summary>
        YXXYXYXY = 0xA9,
        /// <summary>XYXYXYXY := GetByteBy8XBitR(0, 1, 0, 1, 0, 1, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0xAA = 170 .</summary>
        XYXYXYXY = 0xAA,
        /// <summary>YYXYXYXY := GetByteBy8XBitR(1, 1, 0, 1, 0, 1, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0xAB = 171 .</summary>
        YYXYXYXY = 0xAB,
        /// <summary>XXYYXYXY := GetByteBy8XBitR(0, 0, 1, 1, 0, 1, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0xAC = 172 .</summary>
        XXYYXYXY = 0xAC,
        /// <summary>YXYYXYXY := GetByteBy8XBitR(1, 0, 1, 1, 0, 1, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0xAD = 173 .</summary>
        YXYYXYXY = 0xAD,
        /// <summary>XYYYXYXY := GetByteBy8XBitR(0, 1, 1, 1, 0, 1, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0xAE = 174 .</summary>
        XYYYXYXY = 0xAE,
        /// <summary>YYYYXYXY := GetByteBy8XBitR(1, 1, 1, 1, 0, 1, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0xAF = 175 .</summary>
        YYYYXYXY = 0xAF,
        /// <summary>XXXXYYXY := GetByteBy8XBitR(0, 0, 0, 0, 1, 1, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0xB0 = 176 .</summary>
        XXXXYYXY = 0xB0,
        /// <summary>YXXXYYXY := GetByteBy8XBitR(1, 0, 0, 0, 1, 1, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0xB1 = 177 .</summary>
        YXXXYYXY = 0xB1,
        /// <summary>XYXXYYXY := GetByteBy8XBitR(0, 1, 0, 0, 1, 1, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0xB2 = 178 .</summary>
        XYXXYYXY = 0xB2,
        /// <summary>YYXXYYXY := GetByteBy8XBitR(1, 1, 0, 0, 1, 1, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0xB3 = 179 .</summary>
        YYXXYYXY = 0xB3,
        /// <summary>XXYXYYXY := GetByteBy8XBitR(0, 0, 1, 0, 1, 1, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0xB4 = 180 .</summary>
        XXYXYYXY = 0xB4,
        /// <summary>YXYXYYXY := GetByteBy8XBitR(1, 0, 1, 0, 1, 1, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0xB5 = 181 .</summary>
        YXYXYYXY = 0xB5,
        /// <summary>XYYXYYXY := GetByteBy8XBitR(0, 1, 1, 0, 1, 1, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0xB6 = 182 .</summary>
        XYYXYYXY = 0xB6,
        /// <summary>YYYXYYXY := GetByteBy8XBitR(1, 1, 1, 0, 1, 1, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0xB7 = 183 .</summary>
        YYYXYYXY = 0xB7,
        /// <summary>XXXYYYXY := GetByteBy8XBitR(0, 0, 0, 1, 1, 1, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0xB8 = 184 .</summary>
        XXXYYYXY = 0xB8,
        /// <summary>YXXYYYXY := GetByteBy8XBitR(1, 0, 0, 1, 1, 1, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0xB9 = 185 .</summary>
        YXXYYYXY = 0xB9,
        /// <summary>XYXYYYXY := GetByteBy8XBitR(0, 1, 0, 1, 1, 1, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0xBA = 186 .</summary>
        XYXYYYXY = 0xBA,
        /// <summary>YYXYYYXY := GetByteBy8XBitR(1, 1, 0, 1, 1, 1, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0xBB = 187 .</summary>
        YYXYYYXY = 0xBB,
        /// <summary>XXYYYYXY := GetByteBy8XBitR(0, 0, 1, 1, 1, 1, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0xBC = 188 .</summary>
        XXYYYYXY = 0xBC,
        /// <summary>YXYYYYXY := GetByteBy8XBitR(1, 0, 1, 1, 1, 1, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0xBD = 189 .</summary>
        YXYYYYXY = 0xBD,
        /// <summary>XYYYYYXY := GetByteBy8XBitR(0, 1, 1, 1, 1, 1, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0xBE = 190 .</summary>
        XYYYYYXY = 0xBE,
        /// <summary>YYYYYYXY := GetByteBy8XBitR(1, 1, 1, 1, 1, 1, 0, 1) = (_MM_SHUFFLE2(1, 0)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (1 &lt;&lt; 7) | (0 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0xBF = 191 .</summary>
        YYYYYYXY = 0xBF,
        /// <summary>XXXXXXYY := GetByteBy8XBitR(0, 0, 0, 0, 0, 0, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0xC0 = 192 .</summary>
        XXXXXXYY = 0xC0,
        /// <summary>YXXXXXYY := GetByteBy8XBitR(1, 0, 0, 0, 0, 0, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0xC1 = 193 .</summary>
        YXXXXXYY = 0xC1,
        /// <summary>XYXXXXYY := GetByteBy8XBitR(0, 1, 0, 0, 0, 0, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0xC2 = 194 .</summary>
        XYXXXXYY = 0xC2,
        /// <summary>YYXXXXYY := GetByteBy8XBitR(1, 1, 0, 0, 0, 0, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0xC3 = 195 .</summary>
        YYXXXXYY = 0xC3,
        /// <summary>XXYXXXYY := GetByteBy8XBitR(0, 0, 1, 0, 0, 0, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0xC4 = 196 .</summary>
        XXYXXXYY = 0xC4,
        /// <summary>YXYXXXYY := GetByteBy8XBitR(1, 0, 1, 0, 0, 0, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0xC5 = 197 .</summary>
        YXYXXXYY = 0xC5,
        /// <summary>XYYXXXYY := GetByteBy8XBitR(0, 1, 1, 0, 0, 0, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0xC6 = 198 .</summary>
        XYYXXXYY = 0xC6,
        /// <summary>YYYXXXYY := GetByteBy8XBitR(1, 1, 1, 0, 0, 0, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0xC7 = 199 .</summary>
        YYYXXXYY = 0xC7,
        /// <summary>XXXYXXYY := GetByteBy8XBitR(0, 0, 0, 1, 0, 0, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0xC8 = 200 .</summary>
        XXXYXXYY = 0xC8,
        /// <summary>YXXYXXYY := GetByteBy8XBitR(1, 0, 0, 1, 0, 0, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0xC9 = 201 .</summary>
        YXXYXXYY = 0xC9,
        /// <summary>XYXYXXYY := GetByteBy8XBitR(0, 1, 0, 1, 0, 0, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0xCA = 202 .</summary>
        XYXYXXYY = 0xCA,
        /// <summary>YYXYXXYY := GetByteBy8XBitR(1, 1, 0, 1, 0, 0, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0xCB = 203 .</summary>
        YYXYXXYY = 0xCB,
        /// <summary>XXYYXXYY := GetByteBy8XBitR(0, 0, 1, 1, 0, 0, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0xCC = 204 .</summary>
        XXYYXXYY = 0xCC,
        /// <summary>YXYYXXYY := GetByteBy8XBitR(1, 0, 1, 1, 0, 0, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0xCD = 205 .</summary>
        YXYYXXYY = 0xCD,
        /// <summary>XYYYXXYY := GetByteBy8XBitR(0, 1, 1, 1, 0, 0, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0xCE = 206 .</summary>
        XYYYXXYY = 0xCE,
        /// <summary>YYYYXXYY := GetByteBy8XBitR(1, 1, 1, 1, 0, 0, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0xCF = 207 .</summary>
        YYYYXXYY = 0xCF,
        /// <summary>XXXXYXYY := GetByteBy8XBitR(0, 0, 0, 0, 1, 0, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0xD0 = 208 .</summary>
        XXXXYXYY = 0xD0,
        /// <summary>YXXXYXYY := GetByteBy8XBitR(1, 0, 0, 0, 1, 0, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0xD1 = 209 .</summary>
        YXXXYXYY = 0xD1,
        /// <summary>XYXXYXYY := GetByteBy8XBitR(0, 1, 0, 0, 1, 0, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0xD2 = 210 .</summary>
        XYXXYXYY = 0xD2,
        /// <summary>YYXXYXYY := GetByteBy8XBitR(1, 1, 0, 0, 1, 0, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0xD3 = 211 .</summary>
        YYXXYXYY = 0xD3,
        /// <summary>XXYXYXYY := GetByteBy8XBitR(0, 0, 1, 0, 1, 0, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0xD4 = 212 .</summary>
        XXYXYXYY = 0xD4,
        /// <summary>YXYXYXYY := GetByteBy8XBitR(1, 0, 1, 0, 1, 0, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0xD5 = 213 .</summary>
        YXYXYXYY = 0xD5,
        /// <summary>XYYXYXYY := GetByteBy8XBitR(0, 1, 1, 0, 1, 0, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0xD6 = 214 .</summary>
        XYYXYXYY = 0xD6,
        /// <summary>YYYXYXYY := GetByteBy8XBitR(1, 1, 1, 0, 1, 0, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0xD7 = 215 .</summary>
        YYYXYXYY = 0xD7,
        /// <summary>XXXYYXYY := GetByteBy8XBitR(0, 0, 0, 1, 1, 0, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0xD8 = 216 .</summary>
        XXXYYXYY = 0xD8,
        /// <summary>YXXYYXYY := GetByteBy8XBitR(1, 0, 0, 1, 1, 0, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0xD9 = 217 .</summary>
        YXXYYXYY = 0xD9,
        /// <summary>XYXYYXYY := GetByteBy8XBitR(0, 1, 0, 1, 1, 0, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0xDA = 218 .</summary>
        XYXYYXYY = 0xDA,
        /// <summary>YYXYYXYY := GetByteBy8XBitR(1, 1, 0, 1, 1, 0, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0xDB = 219 .</summary>
        YYXYYXYY = 0xDB,
        /// <summary>XXYYYXYY := GetByteBy8XBitR(0, 0, 1, 1, 1, 0, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0xDC = 220 .</summary>
        XXYYYXYY = 0xDC,
        /// <summary>YXYYYXYY := GetByteBy8XBitR(1, 0, 1, 1, 1, 0, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0xDD = 221 .</summary>
        YXYYYXYY = 0xDD,
        /// <summary>XYYYYXYY := GetByteBy8XBitR(0, 1, 1, 1, 1, 0, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0xDE = 222 .</summary>
        XYYYYXYY = 0xDE,
        /// <summary>YYYYYXYY := GetByteBy8XBitR(1, 1, 1, 1, 1, 0, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(0, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (0 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0xDF = 223 .</summary>
        YYYYYXYY = 0xDF,
        /// <summary>XXXXXYYY := GetByteBy8XBitR(0, 0, 0, 0, 0, 1, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0xE0 = 224 .</summary>
        XXXXXYYY = 0xE0,
        /// <summary>YXXXXYYY := GetByteBy8XBitR(1, 0, 0, 0, 0, 1, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0xE1 = 225 .</summary>
        YXXXXYYY = 0xE1,
        /// <summary>XYXXXYYY := GetByteBy8XBitR(0, 1, 0, 0, 0, 1, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0xE2 = 226 .</summary>
        XYXXXYYY = 0xE2,
        /// <summary>YYXXXYYY := GetByteBy8XBitR(1, 1, 0, 0, 0, 1, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0xE3 = 227 .</summary>
        YYXXXYYY = 0xE3,
        /// <summary>XXYXXYYY := GetByteBy8XBitR(0, 0, 1, 0, 0, 1, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0xE4 = 228 .</summary>
        XXYXXYYY = 0xE4,
        /// <summary>YXYXXYYY := GetByteBy8XBitR(1, 0, 1, 0, 0, 1, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0xE5 = 229 .</summary>
        YXYXXYYY = 0xE5,
        /// <summary>XYYXXYYY := GetByteBy8XBitR(0, 1, 1, 0, 0, 1, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0xE6 = 230 .</summary>
        XYYXXYYY = 0xE6,
        /// <summary>YYYXXYYY := GetByteBy8XBitR(1, 1, 1, 0, 0, 1, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0xE7 = 231 .</summary>
        YYYXXYYY = 0xE7,
        /// <summary>XXXYXYYY := GetByteBy8XBitR(0, 0, 0, 1, 0, 1, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0xE8 = 232 .</summary>
        XXXYXYYY = 0xE8,
        /// <summary>YXXYXYYY := GetByteBy8XBitR(1, 0, 0, 1, 0, 1, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0xE9 = 233 .</summary>
        YXXYXYYY = 0xE9,
        /// <summary>XYXYXYYY := GetByteBy8XBitR(0, 1, 0, 1, 0, 1, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0xEA = 234 .</summary>
        XYXYXYYY = 0xEA,
        /// <summary>YYXYXYYY := GetByteBy8XBitR(1, 1, 0, 1, 0, 1, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0xEB = 235 .</summary>
        YYXYXYYY = 0xEB,
        /// <summary>XXYYXYYY := GetByteBy8XBitR(0, 0, 1, 1, 0, 1, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0xEC = 236 .</summary>
        XXYYXYYY = 0xEC,
        /// <summary>YXYYXYYY := GetByteBy8XBitR(1, 0, 1, 1, 0, 1, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0xED = 237 .</summary>
        YXYYXYYY = 0xED,
        /// <summary>XYYYXYYY := GetByteBy8XBitR(0, 1, 1, 1, 0, 1, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0xEE = 238 .</summary>
        XYYYXYYY = 0xEE,
        /// <summary>YYYYXYYY := GetByteBy8XBitR(1, 1, 1, 1, 0, 1, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 0)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (0 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0xEF = 239 .</summary>
        YYYYXYYY = 0xEF,
        /// <summary>XXXXYYYY := GetByteBy8XBitR(0, 0, 0, 0, 1, 1, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0xF0 = 240 .</summary>
        XXXXYYYY = 0xF0,
        /// <summary>YXXXYYYY := GetByteBy8XBitR(1, 0, 0, 0, 1, 1, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0xF1 = 241 .</summary>
        YXXXYYYY = 0xF1,
        /// <summary>XYXXYYYY := GetByteBy8XBitR(0, 1, 0, 0, 1, 1, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0xF2 = 242 .</summary>
        XYXXYYYY = 0xF2,
        /// <summary>YYXXYYYY := GetByteBy8XBitR(1, 1, 0, 0, 1, 1, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0xF3 = 243 .</summary>
        YYXXYYYY = 0xF3,
        /// <summary>XXYXYYYY := GetByteBy8XBitR(0, 0, 1, 0, 1, 1, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0xF4 = 244 .</summary>
        XXYXYYYY = 0xF4,
        /// <summary>YXYXYYYY := GetByteBy8XBitR(1, 0, 1, 0, 1, 1, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0xF5 = 245 .</summary>
        YXYXYYYY = 0xF5,
        /// <summary>XYYXYYYY := GetByteBy8XBitR(0, 1, 1, 0, 1, 1, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0xF6 = 246 .</summary>
        XYYXYYYY = 0xF6,
        /// <summary>YYYXYYYY := GetByteBy8XBitR(1, 1, 1, 0, 1, 1, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(0, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (0 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0xF7 = 247 .</summary>
        YYYXYYYY = 0xF7,
        /// <summary>XXXYYYYY := GetByteBy8XBitR(0, 0, 0, 1, 1, 1, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0xF8 = 248 .</summary>
        XXXYYYYY = 0xF8,
        /// <summary>YXXYYYYY := GetByteBy8XBitR(1, 0, 0, 1, 1, 1, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0xF9 = 249 .</summary>
        YXXYYYYY = 0xF9,
        /// <summary>XYXYYYYY := GetByteBy8XBitR(0, 1, 0, 1, 1, 1, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0xFA = 250 .</summary>
        XYXYYYYY = 0xFA,
        /// <summary>YYXYYYYY := GetByteBy8XBitR(1, 1, 0, 1, 1, 1, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 0)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (0 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0xFB = 251 .</summary>
        YYXYYYYY = 0xFB,
        /// <summary>XXYYYYYY := GetByteBy8XBitR(0, 0, 1, 1, 1, 1, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 0) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 0 = 0xFC = 252 .</summary>
        XXYYYYYY = 0xFC,
        /// <summary>YXYYYYYY := GetByteBy8XBitR(1, 0, 1, 1, 1, 1, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(0, 1) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (0 &lt;&lt; 1) | 1 = 0xFD = 253 .</summary>
        YXYYYYYY = 0xFD,
        /// <summary>XYYYYYYY := GetByteBy8XBitR(0, 1, 1, 1, 1, 1, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 0) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 0 = 0xFE = 254 .</summary>
        XYYYYYYY = 0xFE,
        /// <summary>YYYYYYYY := GetByteBy8XBitR(1, 1, 1, 1, 1, 1, 1, 1) = (_MM_SHUFFLE2(1, 1)&lt;&lt;6) | (_MM_SHUFFLE2(1, 1)&lt;&lt;4) | (_MM_SHUFFLE2(1, 1)&lt;&lt;2) | _MM_SHUFFLE2(1, 1) = (1 &lt;&lt; 7) | (1 &lt;&lt; 6) | (1 &lt;&lt; 5) | (1 &lt;&lt; 4) | (1 &lt;&lt; 3) | (1 &lt;&lt; 2) | (1 &lt;&lt; 1) | 1 = 0xFF = 255 .</summary>
        YYYYYYYY = 0xFF
    }

}
