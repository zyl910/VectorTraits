using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Zyl.VectorTraits.Numerics;

namespace Zyl.VectorTraits {

    /// <summary>
    /// Shuffle control constants for "2-element group" ("2元素组"的换位控制常数) .
    /// </summary>
    /// <remarks>
    /// <para>Constant names are referenced to HLSL(High-level shader language)/GLSL(OpenGL Shading Language), using the Little-Endian mode. It is like inverse-ordered _MM_SHUFFLE2 (常量名参考了 HLSL(高级着色语言)/GLSL(OpenGL着色语言), 使用的是小端模式. 它像逆序的 _MM_SHUFFLE2). </para>
    /// </remarks>
    /// <seealso cref="BitMathCore._MM_SHUFFLE2(byte, byte)"/>
    public enum ShuffleControlG2 : byte {
        /// <summary>XX := _MM_SHUFFLE2(0, 0) = (0 &lt;&lt; 1) | 0 = 0x00 = 0 .</summary>
        XX = 0,
        /// <summary>XY := _MM_SHUFFLE2(1, 0) = (1 &lt;&lt; 1) | 0 = 0x02 = 2 .</summary>
        XY = 2,
        /// <summary>YX := _MM_SHUFFLE2(0, 1) = (0 &lt;&lt; 1) | 1 = 0x01 = 1 .</summary>
        YX = 1,
        /// <summary>YY := _MM_SHUFFLE2(1, 1) = (1 &lt;&lt; 1) | 1 = 0x03 = 3 .</summary>
        YY = 3
    }

}
