using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zyl.VectorTraits {

    /// <summary>
    /// Shuffle control constants for "4-element group" ("4元素组"的换位控制常数) .
    /// </summary>
    /// <remarks>
    /// <para>Constant names are referenced to HLSL(High-level shader language)/GLSL(OpenGL Shading Language), using the Little-Endian mode. It is like GetByteByBit2R, and the similarly inverse-ordered _MM_SHUFFLE (常量名参考了 HLSL(高级着色语言)/GLSL(OpenGL着色语言), 使用的是小端模式. 它像 GetByteByBit2R, 以及类似逆序的 _MM_SHUFFLE). </para>
    /// </remarks>
    /// <seealso cref="BitMath.GetByteByBit2R(byte, byte, byte, byte)"/>
    /// <seealso cref="BitMath._MM_SHUFFLE(byte, byte, byte, byte)"/>
    public enum ShuffleControlG4 : byte {
        /// <summary>XXXX := GetByteByBit2R(0, 0, 0, 0) = _MM_SHUFFLE(0, 0, 0, 0) = (0 &lt;&lt; 6) | (0 &lt;&lt; 4) | (0 &lt;&lt; 2) | 0 = 0x00 = 0 .</summary>
        XXXX = 0x00,
        /// <summary>YXXX := GetByteByBit2R(1, 0, 0, 0) = _MM_SHUFFLE(0, 0, 0, 1) = (0 &lt;&lt; 6) | (0 &lt;&lt; 4) | (0 &lt;&lt; 2) | 1 = 0x01 = 1 .</summary>
        YXXX = 0x01,
        /// <summary>ZXXX := GetByteByBit2R(2, 0, 0, 0) = _MM_SHUFFLE(0, 0, 0, 2) = (0 &lt;&lt; 6) | (0 &lt;&lt; 4) | (0 &lt;&lt; 2) | 2 = 0x02 = 2 .</summary>
        ZXXX = 0x02,
        /// <summary>WXXX := GetByteByBit2R(3, 0, 0, 0) = _MM_SHUFFLE(0, 0, 0, 3) = (0 &lt;&lt; 6) | (0 &lt;&lt; 4) | (0 &lt;&lt; 2) | 3 = 0x03 = 3 .</summary>
        WXXX = 0x03,
        /// <summary>XYXX := GetByteByBit2R(0, 1, 0, 0) = _MM_SHUFFLE(0, 0, 1, 0) = (0 &lt;&lt; 6) | (0 &lt;&lt; 4) | (1 &lt;&lt; 2) | 0 = 0x04 = 4 .</summary>
        XYXX = 0x04,
        /// <summary>YYXX := GetByteByBit2R(1, 1, 0, 0) = _MM_SHUFFLE(0, 0, 1, 1) = (0 &lt;&lt; 6) | (0 &lt;&lt; 4) | (1 &lt;&lt; 2) | 1 = 0x05 = 5 .</summary>
        YYXX = 0x05,
        /// <summary>ZYXX := GetByteByBit2R(2, 1, 0, 0) = _MM_SHUFFLE(0, 0, 1, 2) = (0 &lt;&lt; 6) | (0 &lt;&lt; 4) | (1 &lt;&lt; 2) | 2 = 0x06 = 6 .</summary>
        ZYXX = 0x06,
        /// <summary>WYXX := GetByteByBit2R(3, 1, 0, 0) = _MM_SHUFFLE(0, 0, 1, 3) = (0 &lt;&lt; 6) | (0 &lt;&lt; 4) | (1 &lt;&lt; 2) | 3 = 0x07 = 7 .</summary>
        WYXX = 0x07,
        /// <summary>XZXX := GetByteByBit2R(0, 2, 0, 0) = _MM_SHUFFLE(0, 0, 2, 0) = (0 &lt;&lt; 6) | (0 &lt;&lt; 4) | (2 &lt;&lt; 2) | 0 = 0x08 = 8 .</summary>
        XZXX = 0x08,
        /// <summary>YZXX := GetByteByBit2R(1, 2, 0, 0) = _MM_SHUFFLE(0, 0, 2, 1) = (0 &lt;&lt; 6) | (0 &lt;&lt; 4) | (2 &lt;&lt; 2) | 1 = 0x09 = 9 .</summary>
        YZXX = 0x09,
        /// <summary>ZZXX := GetByteByBit2R(2, 2, 0, 0) = _MM_SHUFFLE(0, 0, 2, 2) = (0 &lt;&lt; 6) | (0 &lt;&lt; 4) | (2 &lt;&lt; 2) | 2 = 0x0A = 10 .</summary>
        ZZXX = 0x0A,
        /// <summary>WZXX := GetByteByBit2R(3, 2, 0, 0) = _MM_SHUFFLE(0, 0, 2, 3) = (0 &lt;&lt; 6) | (0 &lt;&lt; 4) | (2 &lt;&lt; 2) | 3 = 0x0B = 11 .</summary>
        WZXX = 0x0B,
        /// <summary>XWXX := GetByteByBit2R(0, 3, 0, 0) = _MM_SHUFFLE(0, 0, 3, 0) = (0 &lt;&lt; 6) | (0 &lt;&lt; 4) | (3 &lt;&lt; 2) | 0 = 0x0C = 12 .</summary>
        XWXX = 0x0C,
        /// <summary>YWXX := GetByteByBit2R(1, 3, 0, 0) = _MM_SHUFFLE(0, 0, 3, 1) = (0 &lt;&lt; 6) | (0 &lt;&lt; 4) | (3 &lt;&lt; 2) | 1 = 0x0D = 13 .</summary>
        YWXX = 0x0D,
        /// <summary>ZWXX := GetByteByBit2R(2, 3, 0, 0) = _MM_SHUFFLE(0, 0, 3, 2) = (0 &lt;&lt; 6) | (0 &lt;&lt; 4) | (3 &lt;&lt; 2) | 2 = 0x0E = 14 .</summary>
        ZWXX = 0x0E,
        /// <summary>WWXX := GetByteByBit2R(3, 3, 0, 0) = _MM_SHUFFLE(0, 0, 3, 3) = (0 &lt;&lt; 6) | (0 &lt;&lt; 4) | (3 &lt;&lt; 2) | 3 = 0x0F = 15 .</summary>
        WWXX = 0x0F,
        /// <summary>XXYX := GetByteByBit2R(0, 0, 1, 0) = _MM_SHUFFLE(0, 1, 0, 0) = (0 &lt;&lt; 6) | (1 &lt;&lt; 4) | (0 &lt;&lt; 2) | 0 = 0x10 = 16 .</summary>
        XXYX = 0x10,
        /// <summary>YXYX := GetByteByBit2R(1, 0, 1, 0) = _MM_SHUFFLE(0, 1, 0, 1) = (0 &lt;&lt; 6) | (1 &lt;&lt; 4) | (0 &lt;&lt; 2) | 1 = 0x11 = 17 .</summary>
        YXYX = 0x11,
        /// <summary>ZXYX := GetByteByBit2R(2, 0, 1, 0) = _MM_SHUFFLE(0, 1, 0, 2) = (0 &lt;&lt; 6) | (1 &lt;&lt; 4) | (0 &lt;&lt; 2) | 2 = 0x12 = 18 .</summary>
        ZXYX = 0x12,
        /// <summary>WXYX := GetByteByBit2R(3, 0, 1, 0) = _MM_SHUFFLE(0, 1, 0, 3) = (0 &lt;&lt; 6) | (1 &lt;&lt; 4) | (0 &lt;&lt; 2) | 3 = 0x13 = 19 .</summary>
        WXYX = 0x13,
        /// <summary>XYYX := GetByteByBit2R(0, 1, 1, 0) = _MM_SHUFFLE(0, 1, 1, 0) = (0 &lt;&lt; 6) | (1 &lt;&lt; 4) | (1 &lt;&lt; 2) | 0 = 0x14 = 20 .</summary>
        XYYX = 0x14,
        /// <summary>YYYX := GetByteByBit2R(1, 1, 1, 0) = _MM_SHUFFLE(0, 1, 1, 1) = (0 &lt;&lt; 6) | (1 &lt;&lt; 4) | (1 &lt;&lt; 2) | 1 = 0x15 = 21 .</summary>
        YYYX = 0x15,
        /// <summary>ZYYX := GetByteByBit2R(2, 1, 1, 0) = _MM_SHUFFLE(0, 1, 1, 2) = (0 &lt;&lt; 6) | (1 &lt;&lt; 4) | (1 &lt;&lt; 2) | 2 = 0x16 = 22 .</summary>
        ZYYX = 0x16,
        /// <summary>WYYX := GetByteByBit2R(3, 1, 1, 0) = _MM_SHUFFLE(0, 1, 1, 3) = (0 &lt;&lt; 6) | (1 &lt;&lt; 4) | (1 &lt;&lt; 2) | 3 = 0x17 = 23 .</summary>
        WYYX = 0x17,
        /// <summary>XZYX := GetByteByBit2R(0, 2, 1, 0) = _MM_SHUFFLE(0, 1, 2, 0) = (0 &lt;&lt; 6) | (1 &lt;&lt; 4) | (2 &lt;&lt; 2) | 0 = 0x18 = 24 .</summary>
        XZYX = 0x18,
        /// <summary>YZYX := GetByteByBit2R(1, 2, 1, 0) = _MM_SHUFFLE(0, 1, 2, 1) = (0 &lt;&lt; 6) | (1 &lt;&lt; 4) | (2 &lt;&lt; 2) | 1 = 0x19 = 25 .</summary>
        YZYX = 0x19,
        /// <summary>ZZYX := GetByteByBit2R(2, 2, 1, 0) = _MM_SHUFFLE(0, 1, 2, 2) = (0 &lt;&lt; 6) | (1 &lt;&lt; 4) | (2 &lt;&lt; 2) | 2 = 0x1A = 26 .</summary>
        ZZYX = 0x1A,
        /// <summary>WZYX := GetByteByBit2R(3, 2, 1, 0) = _MM_SHUFFLE(0, 1, 2, 3) = (0 &lt;&lt; 6) | (1 &lt;&lt; 4) | (2 &lt;&lt; 2) | 3 = 0x1B = 27 .</summary>
        WZYX = 0x1B,
        /// <summary>XWYX := GetByteByBit2R(0, 3, 1, 0) = _MM_SHUFFLE(0, 1, 3, 0) = (0 &lt;&lt; 6) | (1 &lt;&lt; 4) | (3 &lt;&lt; 2) | 0 = 0x1C = 28 .</summary>
        XWYX = 0x1C,
        /// <summary>YWYX := GetByteByBit2R(1, 3, 1, 0) = _MM_SHUFFLE(0, 1, 3, 1) = (0 &lt;&lt; 6) | (1 &lt;&lt; 4) | (3 &lt;&lt; 2) | 1 = 0x1D = 29 .</summary>
        YWYX = 0x1D,
        /// <summary>ZWYX := GetByteByBit2R(2, 3, 1, 0) = _MM_SHUFFLE(0, 1, 3, 2) = (0 &lt;&lt; 6) | (1 &lt;&lt; 4) | (3 &lt;&lt; 2) | 2 = 0x1E = 30 .</summary>
        ZWYX = 0x1E,
        /// <summary>WWYX := GetByteByBit2R(3, 3, 1, 0) = _MM_SHUFFLE(0, 1, 3, 3) = (0 &lt;&lt; 6) | (1 &lt;&lt; 4) | (3 &lt;&lt; 2) | 3 = 0x1F = 31 .</summary>
        WWYX = 0x1F,
        /// <summary>XXZX := GetByteByBit2R(0, 0, 2, 0) = _MM_SHUFFLE(0, 2, 0, 0) = (0 &lt;&lt; 6) | (2 &lt;&lt; 4) | (0 &lt;&lt; 2) | 0 = 0x20 = 32 .</summary>
        XXZX = 0x20,
        /// <summary>YXZX := GetByteByBit2R(1, 0, 2, 0) = _MM_SHUFFLE(0, 2, 0, 1) = (0 &lt;&lt; 6) | (2 &lt;&lt; 4) | (0 &lt;&lt; 2) | 1 = 0x21 = 33 .</summary>
        YXZX = 0x21,
        /// <summary>ZXZX := GetByteByBit2R(2, 0, 2, 0) = _MM_SHUFFLE(0, 2, 0, 2) = (0 &lt;&lt; 6) | (2 &lt;&lt; 4) | (0 &lt;&lt; 2) | 2 = 0x22 = 34 .</summary>
        ZXZX = 0x22,
        /// <summary>WXZX := GetByteByBit2R(3, 0, 2, 0) = _MM_SHUFFLE(0, 2, 0, 3) = (0 &lt;&lt; 6) | (2 &lt;&lt; 4) | (0 &lt;&lt; 2) | 3 = 0x23 = 35 .</summary>
        WXZX = 0x23,
        /// <summary>XYZX := GetByteByBit2R(0, 1, 2, 0) = _MM_SHUFFLE(0, 2, 1, 0) = (0 &lt;&lt; 6) | (2 &lt;&lt; 4) | (1 &lt;&lt; 2) | 0 = 0x24 = 36 .</summary>
        XYZX = 0x24,
        /// <summary>YYZX := GetByteByBit2R(1, 1, 2, 0) = _MM_SHUFFLE(0, 2, 1, 1) = (0 &lt;&lt; 6) | (2 &lt;&lt; 4) | (1 &lt;&lt; 2) | 1 = 0x25 = 37 .</summary>
        YYZX = 0x25,
        /// <summary>ZYZX := GetByteByBit2R(2, 1, 2, 0) = _MM_SHUFFLE(0, 2, 1, 2) = (0 &lt;&lt; 6) | (2 &lt;&lt; 4) | (1 &lt;&lt; 2) | 2 = 0x26 = 38 .</summary>
        ZYZX = 0x26,
        /// <summary>WYZX := GetByteByBit2R(3, 1, 2, 0) = _MM_SHUFFLE(0, 2, 1, 3) = (0 &lt;&lt; 6) | (2 &lt;&lt; 4) | (1 &lt;&lt; 2) | 3 = 0x27 = 39 .</summary>
        WYZX = 0x27,
        /// <summary>XZZX := GetByteByBit2R(0, 2, 2, 0) = _MM_SHUFFLE(0, 2, 2, 0) = (0 &lt;&lt; 6) | (2 &lt;&lt; 4) | (2 &lt;&lt; 2) | 0 = 0x28 = 40 .</summary>
        XZZX = 0x28,
        /// <summary>YZZX := GetByteByBit2R(1, 2, 2, 0) = _MM_SHUFFLE(0, 2, 2, 1) = (0 &lt;&lt; 6) | (2 &lt;&lt; 4) | (2 &lt;&lt; 2) | 1 = 0x29 = 41 .</summary>
        YZZX = 0x29,
        /// <summary>ZZZX := GetByteByBit2R(2, 2, 2, 0) = _MM_SHUFFLE(0, 2, 2, 2) = (0 &lt;&lt; 6) | (2 &lt;&lt; 4) | (2 &lt;&lt; 2) | 2 = 0x2A = 42 .</summary>
        ZZZX = 0x2A,
        /// <summary>WZZX := GetByteByBit2R(3, 2, 2, 0) = _MM_SHUFFLE(0, 2, 2, 3) = (0 &lt;&lt; 6) | (2 &lt;&lt; 4) | (2 &lt;&lt; 2) | 3 = 0x2B = 43 .</summary>
        WZZX = 0x2B,
        /// <summary>XWZX := GetByteByBit2R(0, 3, 2, 0) = _MM_SHUFFLE(0, 2, 3, 0) = (0 &lt;&lt; 6) | (2 &lt;&lt; 4) | (3 &lt;&lt; 2) | 0 = 0x2C = 44 .</summary>
        XWZX = 0x2C,
        /// <summary>YWZX := GetByteByBit2R(1, 3, 2, 0) = _MM_SHUFFLE(0, 2, 3, 1) = (0 &lt;&lt; 6) | (2 &lt;&lt; 4) | (3 &lt;&lt; 2) | 1 = 0x2D = 45 .</summary>
        YWZX = 0x2D,
        /// <summary>ZWZX := GetByteByBit2R(2, 3, 2, 0) = _MM_SHUFFLE(0, 2, 3, 2) = (0 &lt;&lt; 6) | (2 &lt;&lt; 4) | (3 &lt;&lt; 2) | 2 = 0x2E = 46 .</summary>
        ZWZX = 0x2E,
        /// <summary>WWZX := GetByteByBit2R(3, 3, 2, 0) = _MM_SHUFFLE(0, 2, 3, 3) = (0 &lt;&lt; 6) | (2 &lt;&lt; 4) | (3 &lt;&lt; 2) | 3 = 0x2F = 47 .</summary>
        WWZX = 0x2F,
        /// <summary>XXWX := GetByteByBit2R(0, 0, 3, 0) = _MM_SHUFFLE(0, 3, 0, 0) = (0 &lt;&lt; 6) | (3 &lt;&lt; 4) | (0 &lt;&lt; 2) | 0 = 0x30 = 48 .</summary>
        XXWX = 0x30,
        /// <summary>YXWX := GetByteByBit2R(1, 0, 3, 0) = _MM_SHUFFLE(0, 3, 0, 1) = (0 &lt;&lt; 6) | (3 &lt;&lt; 4) | (0 &lt;&lt; 2) | 1 = 0x31 = 49 .</summary>
        YXWX = 0x31,
        /// <summary>ZXWX := GetByteByBit2R(2, 0, 3, 0) = _MM_SHUFFLE(0, 3, 0, 2) = (0 &lt;&lt; 6) | (3 &lt;&lt; 4) | (0 &lt;&lt; 2) | 2 = 0x32 = 50 .</summary>
        ZXWX = 0x32,
        /// <summary>WXWX := GetByteByBit2R(3, 0, 3, 0) = _MM_SHUFFLE(0, 3, 0, 3) = (0 &lt;&lt; 6) | (3 &lt;&lt; 4) | (0 &lt;&lt; 2) | 3 = 0x33 = 51 .</summary>
        WXWX = 0x33,
        /// <summary>XYWX := GetByteByBit2R(0, 1, 3, 0) = _MM_SHUFFLE(0, 3, 1, 0) = (0 &lt;&lt; 6) | (3 &lt;&lt; 4) | (1 &lt;&lt; 2) | 0 = 0x34 = 52 .</summary>
        XYWX = 0x34,
        /// <summary>YYWX := GetByteByBit2R(1, 1, 3, 0) = _MM_SHUFFLE(0, 3, 1, 1) = (0 &lt;&lt; 6) | (3 &lt;&lt; 4) | (1 &lt;&lt; 2) | 1 = 0x35 = 53 .</summary>
        YYWX = 0x35,
        /// <summary>ZYWX := GetByteByBit2R(2, 1, 3, 0) = _MM_SHUFFLE(0, 3, 1, 2) = (0 &lt;&lt; 6) | (3 &lt;&lt; 4) | (1 &lt;&lt; 2) | 2 = 0x36 = 54 .</summary>
        ZYWX = 0x36,
        /// <summary>WYWX := GetByteByBit2R(3, 1, 3, 0) = _MM_SHUFFLE(0, 3, 1, 3) = (0 &lt;&lt; 6) | (3 &lt;&lt; 4) | (1 &lt;&lt; 2) | 3 = 0x37 = 55 .</summary>
        WYWX = 0x37,
        /// <summary>XZWX := GetByteByBit2R(0, 2, 3, 0) = _MM_SHUFFLE(0, 3, 2, 0) = (0 &lt;&lt; 6) | (3 &lt;&lt; 4) | (2 &lt;&lt; 2) | 0 = 0x38 = 56 .</summary>
        XZWX = 0x38,
        /// <summary>YZWX := GetByteByBit2R(1, 2, 3, 0) = _MM_SHUFFLE(0, 3, 2, 1) = (0 &lt;&lt; 6) | (3 &lt;&lt; 4) | (2 &lt;&lt; 2) | 1 = 0x39 = 57 .</summary>
        YZWX = 0x39,
        /// <summary>ZZWX := GetByteByBit2R(2, 2, 3, 0) = _MM_SHUFFLE(0, 3, 2, 2) = (0 &lt;&lt; 6) | (3 &lt;&lt; 4) | (2 &lt;&lt; 2) | 2 = 0x3A = 58 .</summary>
        ZZWX = 0x3A,
        /// <summary>WZWX := GetByteByBit2R(3, 2, 3, 0) = _MM_SHUFFLE(0, 3, 2, 3) = (0 &lt;&lt; 6) | (3 &lt;&lt; 4) | (2 &lt;&lt; 2) | 3 = 0x3B = 59 .</summary>
        WZWX = 0x3B,
        /// <summary>XWWX := GetByteByBit2R(0, 3, 3, 0) = _MM_SHUFFLE(0, 3, 3, 0) = (0 &lt;&lt; 6) | (3 &lt;&lt; 4) | (3 &lt;&lt; 2) | 0 = 0x3C = 60 .</summary>
        XWWX = 0x3C,
        /// <summary>YWWX := GetByteByBit2R(1, 3, 3, 0) = _MM_SHUFFLE(0, 3, 3, 1) = (0 &lt;&lt; 6) | (3 &lt;&lt; 4) | (3 &lt;&lt; 2) | 1 = 0x3D = 61 .</summary>
        YWWX = 0x3D,
        /// <summary>ZWWX := GetByteByBit2R(2, 3, 3, 0) = _MM_SHUFFLE(0, 3, 3, 2) = (0 &lt;&lt; 6) | (3 &lt;&lt; 4) | (3 &lt;&lt; 2) | 2 = 0x3E = 62 .</summary>
        ZWWX = 0x3E,
        /// <summary>WWWX := GetByteByBit2R(3, 3, 3, 0) = _MM_SHUFFLE(0, 3, 3, 3) = (0 &lt;&lt; 6) | (3 &lt;&lt; 4) | (3 &lt;&lt; 2) | 3 = 0x3F = 63 .</summary>
        WWWX = 0x3F,
        /// <summary>XXXY := GetByteByBit2R(0, 0, 0, 1) = _MM_SHUFFLE(1, 0, 0, 0) = (1 &lt;&lt; 6) | (0 &lt;&lt; 4) | (0 &lt;&lt; 2) | 0 = 0x40 = 64 .</summary>
        XXXY = 0x40,
        /// <summary>YXXY := GetByteByBit2R(1, 0, 0, 1) = _MM_SHUFFLE(1, 0, 0, 1) = (1 &lt;&lt; 6) | (0 &lt;&lt; 4) | (0 &lt;&lt; 2) | 1 = 0x41 = 65 .</summary>
        YXXY = 0x41,
        /// <summary>ZXXY := GetByteByBit2R(2, 0, 0, 1) = _MM_SHUFFLE(1, 0, 0, 2) = (1 &lt;&lt; 6) | (0 &lt;&lt; 4) | (0 &lt;&lt; 2) | 2 = 0x42 = 66 .</summary>
        ZXXY = 0x42,
        /// <summary>WXXY := GetByteByBit2R(3, 0, 0, 1) = _MM_SHUFFLE(1, 0, 0, 3) = (1 &lt;&lt; 6) | (0 &lt;&lt; 4) | (0 &lt;&lt; 2) | 3 = 0x43 = 67 .</summary>
        WXXY = 0x43,
        /// <summary>XYXY := GetByteByBit2R(0, 1, 0, 1) = _MM_SHUFFLE(1, 0, 1, 0) = (1 &lt;&lt; 6) | (0 &lt;&lt; 4) | (1 &lt;&lt; 2) | 0 = 0x44 = 68 .</summary>
        XYXY = 0x44,
        /// <summary>YYXY := GetByteByBit2R(1, 1, 0, 1) = _MM_SHUFFLE(1, 0, 1, 1) = (1 &lt;&lt; 6) | (0 &lt;&lt; 4) | (1 &lt;&lt; 2) | 1 = 0x45 = 69 .</summary>
        YYXY = 0x45,
        /// <summary>ZYXY := GetByteByBit2R(2, 1, 0, 1) = _MM_SHUFFLE(1, 0, 1, 2) = (1 &lt;&lt; 6) | (0 &lt;&lt; 4) | (1 &lt;&lt; 2) | 2 = 0x46 = 70 .</summary>
        ZYXY = 0x46,
        /// <summary>WYXY := GetByteByBit2R(3, 1, 0, 1) = _MM_SHUFFLE(1, 0, 1, 3) = (1 &lt;&lt; 6) | (0 &lt;&lt; 4) | (1 &lt;&lt; 2) | 3 = 0x47 = 71 .</summary>
        WYXY = 0x47,
        /// <summary>XZXY := GetByteByBit2R(0, 2, 0, 1) = _MM_SHUFFLE(1, 0, 2, 0) = (1 &lt;&lt; 6) | (0 &lt;&lt; 4) | (2 &lt;&lt; 2) | 0 = 0x48 = 72 .</summary>
        XZXY = 0x48,
        /// <summary>YZXY := GetByteByBit2R(1, 2, 0, 1) = _MM_SHUFFLE(1, 0, 2, 1) = (1 &lt;&lt; 6) | (0 &lt;&lt; 4) | (2 &lt;&lt; 2) | 1 = 0x49 = 73 .</summary>
        YZXY = 0x49,
        /// <summary>ZZXY := GetByteByBit2R(2, 2, 0, 1) = _MM_SHUFFLE(1, 0, 2, 2) = (1 &lt;&lt; 6) | (0 &lt;&lt; 4) | (2 &lt;&lt; 2) | 2 = 0x4A = 74 .</summary>
        ZZXY = 0x4A,
        /// <summary>WZXY := GetByteByBit2R(3, 2, 0, 1) = _MM_SHUFFLE(1, 0, 2, 3) = (1 &lt;&lt; 6) | (0 &lt;&lt; 4) | (2 &lt;&lt; 2) | 3 = 0x4B = 75 .</summary>
        WZXY = 0x4B,
        /// <summary>XWXY := GetByteByBit2R(0, 3, 0, 1) = _MM_SHUFFLE(1, 0, 3, 0) = (1 &lt;&lt; 6) | (0 &lt;&lt; 4) | (3 &lt;&lt; 2) | 0 = 0x4C = 76 .</summary>
        XWXY = 0x4C,
        /// <summary>YWXY := GetByteByBit2R(1, 3, 0, 1) = _MM_SHUFFLE(1, 0, 3, 1) = (1 &lt;&lt; 6) | (0 &lt;&lt; 4) | (3 &lt;&lt; 2) | 1 = 0x4D = 77 .</summary>
        YWXY = 0x4D,
        /// <summary>ZWXY := GetByteByBit2R(2, 3, 0, 1) = _MM_SHUFFLE(1, 0, 3, 2) = (1 &lt;&lt; 6) | (0 &lt;&lt; 4) | (3 &lt;&lt; 2) | 2 = 0x4E = 78 .</summary>
        ZWXY = 0x4E,
        /// <summary>WWXY := GetByteByBit2R(3, 3, 0, 1) = _MM_SHUFFLE(1, 0, 3, 3) = (1 &lt;&lt; 6) | (0 &lt;&lt; 4) | (3 &lt;&lt; 2) | 3 = 0x4F = 79 .</summary>
        WWXY = 0x4F,
        /// <summary>XXYY := GetByteByBit2R(0, 0, 1, 1) = _MM_SHUFFLE(1, 1, 0, 0) = (1 &lt;&lt; 6) | (1 &lt;&lt; 4) | (0 &lt;&lt; 2) | 0 = 0x50 = 80 .</summary>
        XXYY = 0x50,
        /// <summary>YXYY := GetByteByBit2R(1, 0, 1, 1) = _MM_SHUFFLE(1, 1, 0, 1) = (1 &lt;&lt; 6) | (1 &lt;&lt; 4) | (0 &lt;&lt; 2) | 1 = 0x51 = 81 .</summary>
        YXYY = 0x51,
        /// <summary>ZXYY := GetByteByBit2R(2, 0, 1, 1) = _MM_SHUFFLE(1, 1, 0, 2) = (1 &lt;&lt; 6) | (1 &lt;&lt; 4) | (0 &lt;&lt; 2) | 2 = 0x52 = 82 .</summary>
        ZXYY = 0x52,
        /// <summary>WXYY := GetByteByBit2R(3, 0, 1, 1) = _MM_SHUFFLE(1, 1, 0, 3) = (1 &lt;&lt; 6) | (1 &lt;&lt; 4) | (0 &lt;&lt; 2) | 3 = 0x53 = 83 .</summary>
        WXYY = 0x53,
        /// <summary>XYYY := GetByteByBit2R(0, 1, 1, 1) = _MM_SHUFFLE(1, 1, 1, 0) = (1 &lt;&lt; 6) | (1 &lt;&lt; 4) | (1 &lt;&lt; 2) | 0 = 0x54 = 84 .</summary>
        XYYY = 0x54,
        /// <summary>YYYY := GetByteByBit2R(1, 1, 1, 1) = _MM_SHUFFLE(1, 1, 1, 1) = (1 &lt;&lt; 6) | (1 &lt;&lt; 4) | (1 &lt;&lt; 2) | 1 = 0x55 = 85 .</summary>
        YYYY = 0x55,
        /// <summary>ZYYY := GetByteByBit2R(2, 1, 1, 1) = _MM_SHUFFLE(1, 1, 1, 2) = (1 &lt;&lt; 6) | (1 &lt;&lt; 4) | (1 &lt;&lt; 2) | 2 = 0x56 = 86 .</summary>
        ZYYY = 0x56,
        /// <summary>WYYY := GetByteByBit2R(3, 1, 1, 1) = _MM_SHUFFLE(1, 1, 1, 3) = (1 &lt;&lt; 6) | (1 &lt;&lt; 4) | (1 &lt;&lt; 2) | 3 = 0x57 = 87 .</summary>
        WYYY = 0x57,
        /// <summary>XZYY := GetByteByBit2R(0, 2, 1, 1) = _MM_SHUFFLE(1, 1, 2, 0) = (1 &lt;&lt; 6) | (1 &lt;&lt; 4) | (2 &lt;&lt; 2) | 0 = 0x58 = 88 .</summary>
        XZYY = 0x58,
        /// <summary>YZYY := GetByteByBit2R(1, 2, 1, 1) = _MM_SHUFFLE(1, 1, 2, 1) = (1 &lt;&lt; 6) | (1 &lt;&lt; 4) | (2 &lt;&lt; 2) | 1 = 0x59 = 89 .</summary>
        YZYY = 0x59,
        /// <summary>ZZYY := GetByteByBit2R(2, 2, 1, 1) = _MM_SHUFFLE(1, 1, 2, 2) = (1 &lt;&lt; 6) | (1 &lt;&lt; 4) | (2 &lt;&lt; 2) | 2 = 0x5A = 90 .</summary>
        ZZYY = 0x5A,
        /// <summary>WZYY := GetByteByBit2R(3, 2, 1, 1) = _MM_SHUFFLE(1, 1, 2, 3) = (1 &lt;&lt; 6) | (1 &lt;&lt; 4) | (2 &lt;&lt; 2) | 3 = 0x5B = 91 .</summary>
        WZYY = 0x5B,
        /// <summary>XWYY := GetByteByBit2R(0, 3, 1, 1) = _MM_SHUFFLE(1, 1, 3, 0) = (1 &lt;&lt; 6) | (1 &lt;&lt; 4) | (3 &lt;&lt; 2) | 0 = 0x5C = 92 .</summary>
        XWYY = 0x5C,
        /// <summary>YWYY := GetByteByBit2R(1, 3, 1, 1) = _MM_SHUFFLE(1, 1, 3, 1) = (1 &lt;&lt; 6) | (1 &lt;&lt; 4) | (3 &lt;&lt; 2) | 1 = 0x5D = 93 .</summary>
        YWYY = 0x5D,
        /// <summary>ZWYY := GetByteByBit2R(2, 3, 1, 1) = _MM_SHUFFLE(1, 1, 3, 2) = (1 &lt;&lt; 6) | (1 &lt;&lt; 4) | (3 &lt;&lt; 2) | 2 = 0x5E = 94 .</summary>
        ZWYY = 0x5E,
        /// <summary>WWYY := GetByteByBit2R(3, 3, 1, 1) = _MM_SHUFFLE(1, 1, 3, 3) = (1 &lt;&lt; 6) | (1 &lt;&lt; 4) | (3 &lt;&lt; 2) | 3 = 0x5F = 95 .</summary>
        WWYY = 0x5F,
        /// <summary>XXZY := GetByteByBit2R(0, 0, 2, 1) = _MM_SHUFFLE(1, 2, 0, 0) = (1 &lt;&lt; 6) | (2 &lt;&lt; 4) | (0 &lt;&lt; 2) | 0 = 0x60 = 96 .</summary>
        XXZY = 0x60,
        /// <summary>YXZY := GetByteByBit2R(1, 0, 2, 1) = _MM_SHUFFLE(1, 2, 0, 1) = (1 &lt;&lt; 6) | (2 &lt;&lt; 4) | (0 &lt;&lt; 2) | 1 = 0x61 = 97 .</summary>
        YXZY = 0x61,
        /// <summary>ZXZY := GetByteByBit2R(2, 0, 2, 1) = _MM_SHUFFLE(1, 2, 0, 2) = (1 &lt;&lt; 6) | (2 &lt;&lt; 4) | (0 &lt;&lt; 2) | 2 = 0x62 = 98 .</summary>
        ZXZY = 0x62,
        /// <summary>WXZY := GetByteByBit2R(3, 0, 2, 1) = _MM_SHUFFLE(1, 2, 0, 3) = (1 &lt;&lt; 6) | (2 &lt;&lt; 4) | (0 &lt;&lt; 2) | 3 = 0x63 = 99 .</summary>
        WXZY = 0x63,
        /// <summary>XYZY := GetByteByBit2R(0, 1, 2, 1) = _MM_SHUFFLE(1, 2, 1, 0) = (1 &lt;&lt; 6) | (2 &lt;&lt; 4) | (1 &lt;&lt; 2) | 0 = 0x64 = 100 .</summary>
        XYZY = 0x64,
        /// <summary>YYZY := GetByteByBit2R(1, 1, 2, 1) = _MM_SHUFFLE(1, 2, 1, 1) = (1 &lt;&lt; 6) | (2 &lt;&lt; 4) | (1 &lt;&lt; 2) | 1 = 0x65 = 101 .</summary>
        YYZY = 0x65,
        /// <summary>ZYZY := GetByteByBit2R(2, 1, 2, 1) = _MM_SHUFFLE(1, 2, 1, 2) = (1 &lt;&lt; 6) | (2 &lt;&lt; 4) | (1 &lt;&lt; 2) | 2 = 0x66 = 102 .</summary>
        ZYZY = 0x66,
        /// <summary>WYZY := GetByteByBit2R(3, 1, 2, 1) = _MM_SHUFFLE(1, 2, 1, 3) = (1 &lt;&lt; 6) | (2 &lt;&lt; 4) | (1 &lt;&lt; 2) | 3 = 0x67 = 103 .</summary>
        WYZY = 0x67,
        /// <summary>XZZY := GetByteByBit2R(0, 2, 2, 1) = _MM_SHUFFLE(1, 2, 2, 0) = (1 &lt;&lt; 6) | (2 &lt;&lt; 4) | (2 &lt;&lt; 2) | 0 = 0x68 = 104 .</summary>
        XZZY = 0x68,
        /// <summary>YZZY := GetByteByBit2R(1, 2, 2, 1) = _MM_SHUFFLE(1, 2, 2, 1) = (1 &lt;&lt; 6) | (2 &lt;&lt; 4) | (2 &lt;&lt; 2) | 1 = 0x69 = 105 .</summary>
        YZZY = 0x69,
        /// <summary>ZZZY := GetByteByBit2R(2, 2, 2, 1) = _MM_SHUFFLE(1, 2, 2, 2) = (1 &lt;&lt; 6) | (2 &lt;&lt; 4) | (2 &lt;&lt; 2) | 2 = 0x6A = 106 .</summary>
        ZZZY = 0x6A,
        /// <summary>WZZY := GetByteByBit2R(3, 2, 2, 1) = _MM_SHUFFLE(1, 2, 2, 3) = (1 &lt;&lt; 6) | (2 &lt;&lt; 4) | (2 &lt;&lt; 2) | 3 = 0x6B = 107 .</summary>
        WZZY = 0x6B,
        /// <summary>XWZY := GetByteByBit2R(0, 3, 2, 1) = _MM_SHUFFLE(1, 2, 3, 0) = (1 &lt;&lt; 6) | (2 &lt;&lt; 4) | (3 &lt;&lt; 2) | 0 = 0x6C = 108 .</summary>
        XWZY = 0x6C,
        /// <summary>YWZY := GetByteByBit2R(1, 3, 2, 1) = _MM_SHUFFLE(1, 2, 3, 1) = (1 &lt;&lt; 6) | (2 &lt;&lt; 4) | (3 &lt;&lt; 2) | 1 = 0x6D = 109 .</summary>
        YWZY = 0x6D,
        /// <summary>ZWZY := GetByteByBit2R(2, 3, 2, 1) = _MM_SHUFFLE(1, 2, 3, 2) = (1 &lt;&lt; 6) | (2 &lt;&lt; 4) | (3 &lt;&lt; 2) | 2 = 0x6E = 110 .</summary>
        ZWZY = 0x6E,
        /// <summary>WWZY := GetByteByBit2R(3, 3, 2, 1) = _MM_SHUFFLE(1, 2, 3, 3) = (1 &lt;&lt; 6) | (2 &lt;&lt; 4) | (3 &lt;&lt; 2) | 3 = 0x6F = 111 .</summary>
        WWZY = 0x6F,
        /// <summary>XXWY := GetByteByBit2R(0, 0, 3, 1) = _MM_SHUFFLE(1, 3, 0, 0) = (1 &lt;&lt; 6) | (3 &lt;&lt; 4) | (0 &lt;&lt; 2) | 0 = 0x70 = 112 .</summary>
        XXWY = 0x70,
        /// <summary>YXWY := GetByteByBit2R(1, 0, 3, 1) = _MM_SHUFFLE(1, 3, 0, 1) = (1 &lt;&lt; 6) | (3 &lt;&lt; 4) | (0 &lt;&lt; 2) | 1 = 0x71 = 113 .</summary>
        YXWY = 0x71,
        /// <summary>ZXWY := GetByteByBit2R(2, 0, 3, 1) = _MM_SHUFFLE(1, 3, 0, 2) = (1 &lt;&lt; 6) | (3 &lt;&lt; 4) | (0 &lt;&lt; 2) | 2 = 0x72 = 114 .</summary>
        ZXWY = 0x72,
        /// <summary>WXWY := GetByteByBit2R(3, 0, 3, 1) = _MM_SHUFFLE(1, 3, 0, 3) = (1 &lt;&lt; 6) | (3 &lt;&lt; 4) | (0 &lt;&lt; 2) | 3 = 0x73 = 115 .</summary>
        WXWY = 0x73,
        /// <summary>XYWY := GetByteByBit2R(0, 1, 3, 1) = _MM_SHUFFLE(1, 3, 1, 0) = (1 &lt;&lt; 6) | (3 &lt;&lt; 4) | (1 &lt;&lt; 2) | 0 = 0x74 = 116 .</summary>
        XYWY = 0x74,
        /// <summary>YYWY := GetByteByBit2R(1, 1, 3, 1) = _MM_SHUFFLE(1, 3, 1, 1) = (1 &lt;&lt; 6) | (3 &lt;&lt; 4) | (1 &lt;&lt; 2) | 1 = 0x75 = 117 .</summary>
        YYWY = 0x75,
        /// <summary>ZYWY := GetByteByBit2R(2, 1, 3, 1) = _MM_SHUFFLE(1, 3, 1, 2) = (1 &lt;&lt; 6) | (3 &lt;&lt; 4) | (1 &lt;&lt; 2) | 2 = 0x76 = 118 .</summary>
        ZYWY = 0x76,
        /// <summary>WYWY := GetByteByBit2R(3, 1, 3, 1) = _MM_SHUFFLE(1, 3, 1, 3) = (1 &lt;&lt; 6) | (3 &lt;&lt; 4) | (1 &lt;&lt; 2) | 3 = 0x77 = 119 .</summary>
        WYWY = 0x77,
        /// <summary>XZWY := GetByteByBit2R(0, 2, 3, 1) = _MM_SHUFFLE(1, 3, 2, 0) = (1 &lt;&lt; 6) | (3 &lt;&lt; 4) | (2 &lt;&lt; 2) | 0 = 0x78 = 120 .</summary>
        XZWY = 0x78,
        /// <summary>YZWY := GetByteByBit2R(1, 2, 3, 1) = _MM_SHUFFLE(1, 3, 2, 1) = (1 &lt;&lt; 6) | (3 &lt;&lt; 4) | (2 &lt;&lt; 2) | 1 = 0x79 = 121 .</summary>
        YZWY = 0x79,
        /// <summary>ZZWY := GetByteByBit2R(2, 2, 3, 1) = _MM_SHUFFLE(1, 3, 2, 2) = (1 &lt;&lt; 6) | (3 &lt;&lt; 4) | (2 &lt;&lt; 2) | 2 = 0x7A = 122 .</summary>
        ZZWY = 0x7A,
        /// <summary>WZWY := GetByteByBit2R(3, 2, 3, 1) = _MM_SHUFFLE(1, 3, 2, 3) = (1 &lt;&lt; 6) | (3 &lt;&lt; 4) | (2 &lt;&lt; 2) | 3 = 0x7B = 123 .</summary>
        WZWY = 0x7B,
        /// <summary>XWWY := GetByteByBit2R(0, 3, 3, 1) = _MM_SHUFFLE(1, 3, 3, 0) = (1 &lt;&lt; 6) | (3 &lt;&lt; 4) | (3 &lt;&lt; 2) | 0 = 0x7C = 124 .</summary>
        XWWY = 0x7C,
        /// <summary>YWWY := GetByteByBit2R(1, 3, 3, 1) = _MM_SHUFFLE(1, 3, 3, 1) = (1 &lt;&lt; 6) | (3 &lt;&lt; 4) | (3 &lt;&lt; 2) | 1 = 0x7D = 125 .</summary>
        YWWY = 0x7D,
        /// <summary>ZWWY := GetByteByBit2R(2, 3, 3, 1) = _MM_SHUFFLE(1, 3, 3, 2) = (1 &lt;&lt; 6) | (3 &lt;&lt; 4) | (3 &lt;&lt; 2) | 2 = 0x7E = 126 .</summary>
        ZWWY = 0x7E,
        /// <summary>WWWY := GetByteByBit2R(3, 3, 3, 1) = _MM_SHUFFLE(1, 3, 3, 3) = (1 &lt;&lt; 6) | (3 &lt;&lt; 4) | (3 &lt;&lt; 2) | 3 = 0x7F = 127 .</summary>
        WWWY = 0x7F,
        /// <summary>XXXZ := GetByteByBit2R(0, 0, 0, 2) = _MM_SHUFFLE(2, 0, 0, 0) = (2 &lt;&lt; 6) | (0 &lt;&lt; 4) | (0 &lt;&lt; 2) | 0 = 0x80 = 128 .</summary>
        XXXZ = 0x80,
        /// <summary>YXXZ := GetByteByBit2R(1, 0, 0, 2) = _MM_SHUFFLE(2, 0, 0, 1) = (2 &lt;&lt; 6) | (0 &lt;&lt; 4) | (0 &lt;&lt; 2) | 1 = 0x81 = 129 .</summary>
        YXXZ = 0x81,
        /// <summary>ZXXZ := GetByteByBit2R(2, 0, 0, 2) = _MM_SHUFFLE(2, 0, 0, 2) = (2 &lt;&lt; 6) | (0 &lt;&lt; 4) | (0 &lt;&lt; 2) | 2 = 0x82 = 130 .</summary>
        ZXXZ = 0x82,
        /// <summary>WXXZ := GetByteByBit2R(3, 0, 0, 2) = _MM_SHUFFLE(2, 0, 0, 3) = (2 &lt;&lt; 6) | (0 &lt;&lt; 4) | (0 &lt;&lt; 2) | 3 = 0x83 = 131 .</summary>
        WXXZ = 0x83,
        /// <summary>XYXZ := GetByteByBit2R(0, 1, 0, 2) = _MM_SHUFFLE(2, 0, 1, 0) = (2 &lt;&lt; 6) | (0 &lt;&lt; 4) | (1 &lt;&lt; 2) | 0 = 0x84 = 132 .</summary>
        XYXZ = 0x84,
        /// <summary>YYXZ := GetByteByBit2R(1, 1, 0, 2) = _MM_SHUFFLE(2, 0, 1, 1) = (2 &lt;&lt; 6) | (0 &lt;&lt; 4) | (1 &lt;&lt; 2) | 1 = 0x85 = 133 .</summary>
        YYXZ = 0x85,
        /// <summary>ZYXZ := GetByteByBit2R(2, 1, 0, 2) = _MM_SHUFFLE(2, 0, 1, 2) = (2 &lt;&lt; 6) | (0 &lt;&lt; 4) | (1 &lt;&lt; 2) | 2 = 0x86 = 134 .</summary>
        ZYXZ = 0x86,
        /// <summary>WYXZ := GetByteByBit2R(3, 1, 0, 2) = _MM_SHUFFLE(2, 0, 1, 3) = (2 &lt;&lt; 6) | (0 &lt;&lt; 4) | (1 &lt;&lt; 2) | 3 = 0x87 = 135 .</summary>
        WYXZ = 0x87,
        /// <summary>XZXZ := GetByteByBit2R(0, 2, 0, 2) = _MM_SHUFFLE(2, 0, 2, 0) = (2 &lt;&lt; 6) | (0 &lt;&lt; 4) | (2 &lt;&lt; 2) | 0 = 0x88 = 136 .</summary>
        XZXZ = 0x88,
        /// <summary>YZXZ := GetByteByBit2R(1, 2, 0, 2) = _MM_SHUFFLE(2, 0, 2, 1) = (2 &lt;&lt; 6) | (0 &lt;&lt; 4) | (2 &lt;&lt; 2) | 1 = 0x89 = 137 .</summary>
        YZXZ = 0x89,
        /// <summary>ZZXZ := GetByteByBit2R(2, 2, 0, 2) = _MM_SHUFFLE(2, 0, 2, 2) = (2 &lt;&lt; 6) | (0 &lt;&lt; 4) | (2 &lt;&lt; 2) | 2 = 0x8A = 138 .</summary>
        ZZXZ = 0x8A,
        /// <summary>WZXZ := GetByteByBit2R(3, 2, 0, 2) = _MM_SHUFFLE(2, 0, 2, 3) = (2 &lt;&lt; 6) | (0 &lt;&lt; 4) | (2 &lt;&lt; 2) | 3 = 0x8B = 139 .</summary>
        WZXZ = 0x8B,
        /// <summary>XWXZ := GetByteByBit2R(0, 3, 0, 2) = _MM_SHUFFLE(2, 0, 3, 0) = (2 &lt;&lt; 6) | (0 &lt;&lt; 4) | (3 &lt;&lt; 2) | 0 = 0x8C = 140 .</summary>
        XWXZ = 0x8C,
        /// <summary>YWXZ := GetByteByBit2R(1, 3, 0, 2) = _MM_SHUFFLE(2, 0, 3, 1) = (2 &lt;&lt; 6) | (0 &lt;&lt; 4) | (3 &lt;&lt; 2) | 1 = 0x8D = 141 .</summary>
        YWXZ = 0x8D,
        /// <summary>ZWXZ := GetByteByBit2R(2, 3, 0, 2) = _MM_SHUFFLE(2, 0, 3, 2) = (2 &lt;&lt; 6) | (0 &lt;&lt; 4) | (3 &lt;&lt; 2) | 2 = 0x8E = 142 .</summary>
        ZWXZ = 0x8E,
        /// <summary>WWXZ := GetByteByBit2R(3, 3, 0, 2) = _MM_SHUFFLE(2, 0, 3, 3) = (2 &lt;&lt; 6) | (0 &lt;&lt; 4) | (3 &lt;&lt; 2) | 3 = 0x8F = 143 .</summary>
        WWXZ = 0x8F,
        /// <summary>XXYZ := GetByteByBit2R(0, 0, 1, 2) = _MM_SHUFFLE(2, 1, 0, 0) = (2 &lt;&lt; 6) | (1 &lt;&lt; 4) | (0 &lt;&lt; 2) | 0 = 0x90 = 144 .</summary>
        XXYZ = 0x90,
        /// <summary>YXYZ := GetByteByBit2R(1, 0, 1, 2) = _MM_SHUFFLE(2, 1, 0, 1) = (2 &lt;&lt; 6) | (1 &lt;&lt; 4) | (0 &lt;&lt; 2) | 1 = 0x91 = 145 .</summary>
        YXYZ = 0x91,
        /// <summary>ZXYZ := GetByteByBit2R(2, 0, 1, 2) = _MM_SHUFFLE(2, 1, 0, 2) = (2 &lt;&lt; 6) | (1 &lt;&lt; 4) | (0 &lt;&lt; 2) | 2 = 0x92 = 146 .</summary>
        ZXYZ = 0x92,
        /// <summary>WXYZ := GetByteByBit2R(3, 0, 1, 2) = _MM_SHUFFLE(2, 1, 0, 3) = (2 &lt;&lt; 6) | (1 &lt;&lt; 4) | (0 &lt;&lt; 2) | 3 = 0x93 = 147 .</summary>
        WXYZ = 0x93,
        /// <summary>XYYZ := GetByteByBit2R(0, 1, 1, 2) = _MM_SHUFFLE(2, 1, 1, 0) = (2 &lt;&lt; 6) | (1 &lt;&lt; 4) | (1 &lt;&lt; 2) | 0 = 0x94 = 148 .</summary>
        XYYZ = 0x94,
        /// <summary>YYYZ := GetByteByBit2R(1, 1, 1, 2) = _MM_SHUFFLE(2, 1, 1, 1) = (2 &lt;&lt; 6) | (1 &lt;&lt; 4) | (1 &lt;&lt; 2) | 1 = 0x95 = 149 .</summary>
        YYYZ = 0x95,
        /// <summary>ZYYZ := GetByteByBit2R(2, 1, 1, 2) = _MM_SHUFFLE(2, 1, 1, 2) = (2 &lt;&lt; 6) | (1 &lt;&lt; 4) | (1 &lt;&lt; 2) | 2 = 0x96 = 150 .</summary>
        ZYYZ = 0x96,
        /// <summary>WYYZ := GetByteByBit2R(3, 1, 1, 2) = _MM_SHUFFLE(2, 1, 1, 3) = (2 &lt;&lt; 6) | (1 &lt;&lt; 4) | (1 &lt;&lt; 2) | 3 = 0x97 = 151 .</summary>
        WYYZ = 0x97,
        /// <summary>XZYZ := GetByteByBit2R(0, 2, 1, 2) = _MM_SHUFFLE(2, 1, 2, 0) = (2 &lt;&lt; 6) | (1 &lt;&lt; 4) | (2 &lt;&lt; 2) | 0 = 0x98 = 152 .</summary>
        XZYZ = 0x98,
        /// <summary>YZYZ := GetByteByBit2R(1, 2, 1, 2) = _MM_SHUFFLE(2, 1, 2, 1) = (2 &lt;&lt; 6) | (1 &lt;&lt; 4) | (2 &lt;&lt; 2) | 1 = 0x99 = 153 .</summary>
        YZYZ = 0x99,
        /// <summary>ZZYZ := GetByteByBit2R(2, 2, 1, 2) = _MM_SHUFFLE(2, 1, 2, 2) = (2 &lt;&lt; 6) | (1 &lt;&lt; 4) | (2 &lt;&lt; 2) | 2 = 0x9A = 154 .</summary>
        ZZYZ = 0x9A,
        /// <summary>WZYZ := GetByteByBit2R(3, 2, 1, 2) = _MM_SHUFFLE(2, 1, 2, 3) = (2 &lt;&lt; 6) | (1 &lt;&lt; 4) | (2 &lt;&lt; 2) | 3 = 0x9B = 155 .</summary>
        WZYZ = 0x9B,
        /// <summary>XWYZ := GetByteByBit2R(0, 3, 1, 2) = _MM_SHUFFLE(2, 1, 3, 0) = (2 &lt;&lt; 6) | (1 &lt;&lt; 4) | (3 &lt;&lt; 2) | 0 = 0x9C = 156 .</summary>
        XWYZ = 0x9C,
        /// <summary>YWYZ := GetByteByBit2R(1, 3, 1, 2) = _MM_SHUFFLE(2, 1, 3, 1) = (2 &lt;&lt; 6) | (1 &lt;&lt; 4) | (3 &lt;&lt; 2) | 1 = 0x9D = 157 .</summary>
        YWYZ = 0x9D,
        /// <summary>ZWYZ := GetByteByBit2R(2, 3, 1, 2) = _MM_SHUFFLE(2, 1, 3, 2) = (2 &lt;&lt; 6) | (1 &lt;&lt; 4) | (3 &lt;&lt; 2) | 2 = 0x9E = 158 .</summary>
        ZWYZ = 0x9E,
        /// <summary>WWYZ := GetByteByBit2R(3, 3, 1, 2) = _MM_SHUFFLE(2, 1, 3, 3) = (2 &lt;&lt; 6) | (1 &lt;&lt; 4) | (3 &lt;&lt; 2) | 3 = 0x9F = 159 .</summary>
        WWYZ = 0x9F,
        /// <summary>XXZZ := GetByteByBit2R(0, 0, 2, 2) = _MM_SHUFFLE(2, 2, 0, 0) = (2 &lt;&lt; 6) | (2 &lt;&lt; 4) | (0 &lt;&lt; 2) | 0 = 0xA0 = 160 .</summary>
        XXZZ = 0xA0,
        /// <summary>YXZZ := GetByteByBit2R(1, 0, 2, 2) = _MM_SHUFFLE(2, 2, 0, 1) = (2 &lt;&lt; 6) | (2 &lt;&lt; 4) | (0 &lt;&lt; 2) | 1 = 0xA1 = 161 .</summary>
        YXZZ = 0xA1,
        /// <summary>ZXZZ := GetByteByBit2R(2, 0, 2, 2) = _MM_SHUFFLE(2, 2, 0, 2) = (2 &lt;&lt; 6) | (2 &lt;&lt; 4) | (0 &lt;&lt; 2) | 2 = 0xA2 = 162 .</summary>
        ZXZZ = 0xA2,
        /// <summary>WXZZ := GetByteByBit2R(3, 0, 2, 2) = _MM_SHUFFLE(2, 2, 0, 3) = (2 &lt;&lt; 6) | (2 &lt;&lt; 4) | (0 &lt;&lt; 2) | 3 = 0xA3 = 163 .</summary>
        WXZZ = 0xA3,
        /// <summary>XYZZ := GetByteByBit2R(0, 1, 2, 2) = _MM_SHUFFLE(2, 2, 1, 0) = (2 &lt;&lt; 6) | (2 &lt;&lt; 4) | (1 &lt;&lt; 2) | 0 = 0xA4 = 164 .</summary>
        XYZZ = 0xA4,
        /// <summary>YYZZ := GetByteByBit2R(1, 1, 2, 2) = _MM_SHUFFLE(2, 2, 1, 1) = (2 &lt;&lt; 6) | (2 &lt;&lt; 4) | (1 &lt;&lt; 2) | 1 = 0xA5 = 165 .</summary>
        YYZZ = 0xA5,
        /// <summary>ZYZZ := GetByteByBit2R(2, 1, 2, 2) = _MM_SHUFFLE(2, 2, 1, 2) = (2 &lt;&lt; 6) | (2 &lt;&lt; 4) | (1 &lt;&lt; 2) | 2 = 0xA6 = 166 .</summary>
        ZYZZ = 0xA6,
        /// <summary>WYZZ := GetByteByBit2R(3, 1, 2, 2) = _MM_SHUFFLE(2, 2, 1, 3) = (2 &lt;&lt; 6) | (2 &lt;&lt; 4) | (1 &lt;&lt; 2) | 3 = 0xA7 = 167 .</summary>
        WYZZ = 0xA7,
        /// <summary>XZZZ := GetByteByBit2R(0, 2, 2, 2) = _MM_SHUFFLE(2, 2, 2, 0) = (2 &lt;&lt; 6) | (2 &lt;&lt; 4) | (2 &lt;&lt; 2) | 0 = 0xA8 = 168 .</summary>
        XZZZ = 0xA8,
        /// <summary>YZZZ := GetByteByBit2R(1, 2, 2, 2) = _MM_SHUFFLE(2, 2, 2, 1) = (2 &lt;&lt; 6) | (2 &lt;&lt; 4) | (2 &lt;&lt; 2) | 1 = 0xA9 = 169 .</summary>
        YZZZ = 0xA9,
        /// <summary>ZZZZ := GetByteByBit2R(2, 2, 2, 2) = _MM_SHUFFLE(2, 2, 2, 2) = (2 &lt;&lt; 6) | (2 &lt;&lt; 4) | (2 &lt;&lt; 2) | 2 = 0xAA = 170 .</summary>
        ZZZZ = 0xAA,
        /// <summary>WZZZ := GetByteByBit2R(3, 2, 2, 2) = _MM_SHUFFLE(2, 2, 2, 3) = (2 &lt;&lt; 6) | (2 &lt;&lt; 4) | (2 &lt;&lt; 2) | 3 = 0xAB = 171 .</summary>
        WZZZ = 0xAB,
        /// <summary>XWZZ := GetByteByBit2R(0, 3, 2, 2) = _MM_SHUFFLE(2, 2, 3, 0) = (2 &lt;&lt; 6) | (2 &lt;&lt; 4) | (3 &lt;&lt; 2) | 0 = 0xAC = 172 .</summary>
        XWZZ = 0xAC,
        /// <summary>YWZZ := GetByteByBit2R(1, 3, 2, 2) = _MM_SHUFFLE(2, 2, 3, 1) = (2 &lt;&lt; 6) | (2 &lt;&lt; 4) | (3 &lt;&lt; 2) | 1 = 0xAD = 173 .</summary>
        YWZZ = 0xAD,
        /// <summary>ZWZZ := GetByteByBit2R(2, 3, 2, 2) = _MM_SHUFFLE(2, 2, 3, 2) = (2 &lt;&lt; 6) | (2 &lt;&lt; 4) | (3 &lt;&lt; 2) | 2 = 0xAE = 174 .</summary>
        ZWZZ = 0xAE,
        /// <summary>WWZZ := GetByteByBit2R(3, 3, 2, 2) = _MM_SHUFFLE(2, 2, 3, 3) = (2 &lt;&lt; 6) | (2 &lt;&lt; 4) | (3 &lt;&lt; 2) | 3 = 0xAF = 175 .</summary>
        WWZZ = 0xAF,
        /// <summary>XXWZ := GetByteByBit2R(0, 0, 3, 2) = _MM_SHUFFLE(2, 3, 0, 0) = (2 &lt;&lt; 6) | (3 &lt;&lt; 4) | (0 &lt;&lt; 2) | 0 = 0xB0 = 176 .</summary>
        XXWZ = 0xB0,
        /// <summary>YXWZ := GetByteByBit2R(1, 0, 3, 2) = _MM_SHUFFLE(2, 3, 0, 1) = (2 &lt;&lt; 6) | (3 &lt;&lt; 4) | (0 &lt;&lt; 2) | 1 = 0xB1 = 177 .</summary>
        YXWZ = 0xB1,
        /// <summary>ZXWZ := GetByteByBit2R(2, 0, 3, 2) = _MM_SHUFFLE(2, 3, 0, 2) = (2 &lt;&lt; 6) | (3 &lt;&lt; 4) | (0 &lt;&lt; 2) | 2 = 0xB2 = 178 .</summary>
        ZXWZ = 0xB2,
        /// <summary>WXWZ := GetByteByBit2R(3, 0, 3, 2) = _MM_SHUFFLE(2, 3, 0, 3) = (2 &lt;&lt; 6) | (3 &lt;&lt; 4) | (0 &lt;&lt; 2) | 3 = 0xB3 = 179 .</summary>
        WXWZ = 0xB3,
        /// <summary>XYWZ := GetByteByBit2R(0, 1, 3, 2) = _MM_SHUFFLE(2, 3, 1, 0) = (2 &lt;&lt; 6) | (3 &lt;&lt; 4) | (1 &lt;&lt; 2) | 0 = 0xB4 = 180 .</summary>
        XYWZ = 0xB4,
        /// <summary>YYWZ := GetByteByBit2R(1, 1, 3, 2) = _MM_SHUFFLE(2, 3, 1, 1) = (2 &lt;&lt; 6) | (3 &lt;&lt; 4) | (1 &lt;&lt; 2) | 1 = 0xB5 = 181 .</summary>
        YYWZ = 0xB5,
        /// <summary>ZYWZ := GetByteByBit2R(2, 1, 3, 2) = _MM_SHUFFLE(2, 3, 1, 2) = (2 &lt;&lt; 6) | (3 &lt;&lt; 4) | (1 &lt;&lt; 2) | 2 = 0xB6 = 182 .</summary>
        ZYWZ = 0xB6,
        /// <summary>WYWZ := GetByteByBit2R(3, 1, 3, 2) = _MM_SHUFFLE(2, 3, 1, 3) = (2 &lt;&lt; 6) | (3 &lt;&lt; 4) | (1 &lt;&lt; 2) | 3 = 0xB7 = 183 .</summary>
        WYWZ = 0xB7,
        /// <summary>XZWZ := GetByteByBit2R(0, 2, 3, 2) = _MM_SHUFFLE(2, 3, 2, 0) = (2 &lt;&lt; 6) | (3 &lt;&lt; 4) | (2 &lt;&lt; 2) | 0 = 0xB8 = 184 .</summary>
        XZWZ = 0xB8,
        /// <summary>YZWZ := GetByteByBit2R(1, 2, 3, 2) = _MM_SHUFFLE(2, 3, 2, 1) = (2 &lt;&lt; 6) | (3 &lt;&lt; 4) | (2 &lt;&lt; 2) | 1 = 0xB9 = 185 .</summary>
        YZWZ = 0xB9,
        /// <summary>ZZWZ := GetByteByBit2R(2, 2, 3, 2) = _MM_SHUFFLE(2, 3, 2, 2) = (2 &lt;&lt; 6) | (3 &lt;&lt; 4) | (2 &lt;&lt; 2) | 2 = 0xBA = 186 .</summary>
        ZZWZ = 0xBA,
        /// <summary>WZWZ := GetByteByBit2R(3, 2, 3, 2) = _MM_SHUFFLE(2, 3, 2, 3) = (2 &lt;&lt; 6) | (3 &lt;&lt; 4) | (2 &lt;&lt; 2) | 3 = 0xBB = 187 .</summary>
        WZWZ = 0xBB,
        /// <summary>XWWZ := GetByteByBit2R(0, 3, 3, 2) = _MM_SHUFFLE(2, 3, 3, 0) = (2 &lt;&lt; 6) | (3 &lt;&lt; 4) | (3 &lt;&lt; 2) | 0 = 0xBC = 188 .</summary>
        XWWZ = 0xBC,
        /// <summary>YWWZ := GetByteByBit2R(1, 3, 3, 2) = _MM_SHUFFLE(2, 3, 3, 1) = (2 &lt;&lt; 6) | (3 &lt;&lt; 4) | (3 &lt;&lt; 2) | 1 = 0xBD = 189 .</summary>
        YWWZ = 0xBD,
        /// <summary>ZWWZ := GetByteByBit2R(2, 3, 3, 2) = _MM_SHUFFLE(2, 3, 3, 2) = (2 &lt;&lt; 6) | (3 &lt;&lt; 4) | (3 &lt;&lt; 2) | 2 = 0xBE = 190 .</summary>
        ZWWZ = 0xBE,
        /// <summary>WWWZ := GetByteByBit2R(3, 3, 3, 2) = _MM_SHUFFLE(2, 3, 3, 3) = (2 &lt;&lt; 6) | (3 &lt;&lt; 4) | (3 &lt;&lt; 2) | 3 = 0xBF = 191 .</summary>
        WWWZ = 0xBF,
        /// <summary>XXXW := GetByteByBit2R(0, 0, 0, 3) = _MM_SHUFFLE(3, 0, 0, 0) = (3 &lt;&lt; 6) | (0 &lt;&lt; 4) | (0 &lt;&lt; 2) | 0 = 0xC0 = 192 .</summary>
        XXXW = 0xC0,
        /// <summary>YXXW := GetByteByBit2R(1, 0, 0, 3) = _MM_SHUFFLE(3, 0, 0, 1) = (3 &lt;&lt; 6) | (0 &lt;&lt; 4) | (0 &lt;&lt; 2) | 1 = 0xC1 = 193 .</summary>
        YXXW = 0xC1,
        /// <summary>ZXXW := GetByteByBit2R(2, 0, 0, 3) = _MM_SHUFFLE(3, 0, 0, 2) = (3 &lt;&lt; 6) | (0 &lt;&lt; 4) | (0 &lt;&lt; 2) | 2 = 0xC2 = 194 .</summary>
        ZXXW = 0xC2,
        /// <summary>WXXW := GetByteByBit2R(3, 0, 0, 3) = _MM_SHUFFLE(3, 0, 0, 3) = (3 &lt;&lt; 6) | (0 &lt;&lt; 4) | (0 &lt;&lt; 2) | 3 = 0xC3 = 195 .</summary>
        WXXW = 0xC3,
        /// <summary>XYXW := GetByteByBit2R(0, 1, 0, 3) = _MM_SHUFFLE(3, 0, 1, 0) = (3 &lt;&lt; 6) | (0 &lt;&lt; 4) | (1 &lt;&lt; 2) | 0 = 0xC4 = 196 .</summary>
        XYXW = 0xC4,
        /// <summary>YYXW := GetByteByBit2R(1, 1, 0, 3) = _MM_SHUFFLE(3, 0, 1, 1) = (3 &lt;&lt; 6) | (0 &lt;&lt; 4) | (1 &lt;&lt; 2) | 1 = 0xC5 = 197 .</summary>
        YYXW = 0xC5,
        /// <summary>ZYXW := GetByteByBit2R(2, 1, 0, 3) = _MM_SHUFFLE(3, 0, 1, 2) = (3 &lt;&lt; 6) | (0 &lt;&lt; 4) | (1 &lt;&lt; 2) | 2 = 0xC6 = 198 .</summary>
        ZYXW = 0xC6,
        /// <summary>WYXW := GetByteByBit2R(3, 1, 0, 3) = _MM_SHUFFLE(3, 0, 1, 3) = (3 &lt;&lt; 6) | (0 &lt;&lt; 4) | (1 &lt;&lt; 2) | 3 = 0xC7 = 199 .</summary>
        WYXW = 0xC7,
        /// <summary>XZXW := GetByteByBit2R(0, 2, 0, 3) = _MM_SHUFFLE(3, 0, 2, 0) = (3 &lt;&lt; 6) | (0 &lt;&lt; 4) | (2 &lt;&lt; 2) | 0 = 0xC8 = 200 .</summary>
        XZXW = 0xC8,
        /// <summary>YZXW := GetByteByBit2R(1, 2, 0, 3) = _MM_SHUFFLE(3, 0, 2, 1) = (3 &lt;&lt; 6) | (0 &lt;&lt; 4) | (2 &lt;&lt; 2) | 1 = 0xC9 = 201 .</summary>
        YZXW = 0xC9,
        /// <summary>ZZXW := GetByteByBit2R(2, 2, 0, 3) = _MM_SHUFFLE(3, 0, 2, 2) = (3 &lt;&lt; 6) | (0 &lt;&lt; 4) | (2 &lt;&lt; 2) | 2 = 0xCA = 202 .</summary>
        ZZXW = 0xCA,
        /// <summary>WZXW := GetByteByBit2R(3, 2, 0, 3) = _MM_SHUFFLE(3, 0, 2, 3) = (3 &lt;&lt; 6) | (0 &lt;&lt; 4) | (2 &lt;&lt; 2) | 3 = 0xCB = 203 .</summary>
        WZXW = 0xCB,
        /// <summary>XWXW := GetByteByBit2R(0, 3, 0, 3) = _MM_SHUFFLE(3, 0, 3, 0) = (3 &lt;&lt; 6) | (0 &lt;&lt; 4) | (3 &lt;&lt; 2) | 0 = 0xCC = 204 .</summary>
        XWXW = 0xCC,
        /// <summary>YWXW := GetByteByBit2R(1, 3, 0, 3) = _MM_SHUFFLE(3, 0, 3, 1) = (3 &lt;&lt; 6) | (0 &lt;&lt; 4) | (3 &lt;&lt; 2) | 1 = 0xCD = 205 .</summary>
        YWXW = 0xCD,
        /// <summary>ZWXW := GetByteByBit2R(2, 3, 0, 3) = _MM_SHUFFLE(3, 0, 3, 2) = (3 &lt;&lt; 6) | (0 &lt;&lt; 4) | (3 &lt;&lt; 2) | 2 = 0xCE = 206 .</summary>
        ZWXW = 0xCE,
        /// <summary>WWXW := GetByteByBit2R(3, 3, 0, 3) = _MM_SHUFFLE(3, 0, 3, 3) = (3 &lt;&lt; 6) | (0 &lt;&lt; 4) | (3 &lt;&lt; 2) | 3 = 0xCF = 207 .</summary>
        WWXW = 0xCF,
        /// <summary>XXYW := GetByteByBit2R(0, 0, 1, 3) = _MM_SHUFFLE(3, 1, 0, 0) = (3 &lt;&lt; 6) | (1 &lt;&lt; 4) | (0 &lt;&lt; 2) | 0 = 0xD0 = 208 .</summary>
        XXYW = 0xD0,
        /// <summary>YXYW := GetByteByBit2R(1, 0, 1, 3) = _MM_SHUFFLE(3, 1, 0, 1) = (3 &lt;&lt; 6) | (1 &lt;&lt; 4) | (0 &lt;&lt; 2) | 1 = 0xD1 = 209 .</summary>
        YXYW = 0xD1,
        /// <summary>ZXYW := GetByteByBit2R(2, 0, 1, 3) = _MM_SHUFFLE(3, 1, 0, 2) = (3 &lt;&lt; 6) | (1 &lt;&lt; 4) | (0 &lt;&lt; 2) | 2 = 0xD2 = 210 .</summary>
        ZXYW = 0xD2,
        /// <summary>WXYW := GetByteByBit2R(3, 0, 1, 3) = _MM_SHUFFLE(3, 1, 0, 3) = (3 &lt;&lt; 6) | (1 &lt;&lt; 4) | (0 &lt;&lt; 2) | 3 = 0xD3 = 211 .</summary>
        WXYW = 0xD3,
        /// <summary>XYYW := GetByteByBit2R(0, 1, 1, 3) = _MM_SHUFFLE(3, 1, 1, 0) = (3 &lt;&lt; 6) | (1 &lt;&lt; 4) | (1 &lt;&lt; 2) | 0 = 0xD4 = 212 .</summary>
        XYYW = 0xD4,
        /// <summary>YYYW := GetByteByBit2R(1, 1, 1, 3) = _MM_SHUFFLE(3, 1, 1, 1) = (3 &lt;&lt; 6) | (1 &lt;&lt; 4) | (1 &lt;&lt; 2) | 1 = 0xD5 = 213 .</summary>
        YYYW = 0xD5,
        /// <summary>ZYYW := GetByteByBit2R(2, 1, 1, 3) = _MM_SHUFFLE(3, 1, 1, 2) = (3 &lt;&lt; 6) | (1 &lt;&lt; 4) | (1 &lt;&lt; 2) | 2 = 0xD6 = 214 .</summary>
        ZYYW = 0xD6,
        /// <summary>WYYW := GetByteByBit2R(3, 1, 1, 3) = _MM_SHUFFLE(3, 1, 1, 3) = (3 &lt;&lt; 6) | (1 &lt;&lt; 4) | (1 &lt;&lt; 2) | 3 = 0xD7 = 215 .</summary>
        WYYW = 0xD7,
        /// <summary>XZYW := GetByteByBit2R(0, 2, 1, 3) = _MM_SHUFFLE(3, 1, 2, 0) = (3 &lt;&lt; 6) | (1 &lt;&lt; 4) | (2 &lt;&lt; 2) | 0 = 0xD8 = 216 .</summary>
        XZYW = 0xD8,
        /// <summary>YZYW := GetByteByBit2R(1, 2, 1, 3) = _MM_SHUFFLE(3, 1, 2, 1) = (3 &lt;&lt; 6) | (1 &lt;&lt; 4) | (2 &lt;&lt; 2) | 1 = 0xD9 = 217 .</summary>
        YZYW = 0xD9,
        /// <summary>ZZYW := GetByteByBit2R(2, 2, 1, 3) = _MM_SHUFFLE(3, 1, 2, 2) = (3 &lt;&lt; 6) | (1 &lt;&lt; 4) | (2 &lt;&lt; 2) | 2 = 0xDA = 218 .</summary>
        ZZYW = 0xDA,
        /// <summary>WZYW := GetByteByBit2R(3, 2, 1, 3) = _MM_SHUFFLE(3, 1, 2, 3) = (3 &lt;&lt; 6) | (1 &lt;&lt; 4) | (2 &lt;&lt; 2) | 3 = 0xDB = 219 .</summary>
        WZYW = 0xDB,
        /// <summary>XWYW := GetByteByBit2R(0, 3, 1, 3) = _MM_SHUFFLE(3, 1, 3, 0) = (3 &lt;&lt; 6) | (1 &lt;&lt; 4) | (3 &lt;&lt; 2) | 0 = 0xDC = 220 .</summary>
        XWYW = 0xDC,
        /// <summary>YWYW := GetByteByBit2R(1, 3, 1, 3) = _MM_SHUFFLE(3, 1, 3, 1) = (3 &lt;&lt; 6) | (1 &lt;&lt; 4) | (3 &lt;&lt; 2) | 1 = 0xDD = 221 .</summary>
        YWYW = 0xDD,
        /// <summary>ZWYW := GetByteByBit2R(2, 3, 1, 3) = _MM_SHUFFLE(3, 1, 3, 2) = (3 &lt;&lt; 6) | (1 &lt;&lt; 4) | (3 &lt;&lt; 2) | 2 = 0xDE = 222 .</summary>
        ZWYW = 0xDE,
        /// <summary>WWYW := GetByteByBit2R(3, 3, 1, 3) = _MM_SHUFFLE(3, 1, 3, 3) = (3 &lt;&lt; 6) | (1 &lt;&lt; 4) | (3 &lt;&lt; 2) | 3 = 0xDF = 223 .</summary>
        WWYW = 0xDF,
        /// <summary>XXZW := GetByteByBit2R(0, 0, 2, 3) = _MM_SHUFFLE(3, 2, 0, 0) = (3 &lt;&lt; 6) | (2 &lt;&lt; 4) | (0 &lt;&lt; 2) | 0 = 0xE0 = 224 .</summary>
        XXZW = 0xE0,
        /// <summary>YXZW := GetByteByBit2R(1, 0, 2, 3) = _MM_SHUFFLE(3, 2, 0, 1) = (3 &lt;&lt; 6) | (2 &lt;&lt; 4) | (0 &lt;&lt; 2) | 1 = 0xE1 = 225 .</summary>
        YXZW = 0xE1,
        /// <summary>ZXZW := GetByteByBit2R(2, 0, 2, 3) = _MM_SHUFFLE(3, 2, 0, 2) = (3 &lt;&lt; 6) | (2 &lt;&lt; 4) | (0 &lt;&lt; 2) | 2 = 0xE2 = 226 .</summary>
        ZXZW = 0xE2,
        /// <summary>WXZW := GetByteByBit2R(3, 0, 2, 3) = _MM_SHUFFLE(3, 2, 0, 3) = (3 &lt;&lt; 6) | (2 &lt;&lt; 4) | (0 &lt;&lt; 2) | 3 = 0xE3 = 227 .</summary>
        WXZW = 0xE3,
        /// <summary>XYZW := GetByteByBit2R(0, 1, 2, 3) = _MM_SHUFFLE(3, 2, 1, 0) = (3 &lt;&lt; 6) | (2 &lt;&lt; 4) | (1 &lt;&lt; 2) | 0 = 0xE4 = 228 .</summary>
        XYZW = 0xE4,
        /// <summary>YYZW := GetByteByBit2R(1, 1, 2, 3) = _MM_SHUFFLE(3, 2, 1, 1) = (3 &lt;&lt; 6) | (2 &lt;&lt; 4) | (1 &lt;&lt; 2) | 1 = 0xE5 = 229 .</summary>
        YYZW = 0xE5,
        /// <summary>ZYZW := GetByteByBit2R(2, 1, 2, 3) = _MM_SHUFFLE(3, 2, 1, 2) = (3 &lt;&lt; 6) | (2 &lt;&lt; 4) | (1 &lt;&lt; 2) | 2 = 0xE6 = 230 .</summary>
        ZYZW = 0xE6,
        /// <summary>WYZW := GetByteByBit2R(3, 1, 2, 3) = _MM_SHUFFLE(3, 2, 1, 3) = (3 &lt;&lt; 6) | (2 &lt;&lt; 4) | (1 &lt;&lt; 2) | 3 = 0xE7 = 231 .</summary>
        WYZW = 0xE7,
        /// <summary>XZZW := GetByteByBit2R(0, 2, 2, 3) = _MM_SHUFFLE(3, 2, 2, 0) = (3 &lt;&lt; 6) | (2 &lt;&lt; 4) | (2 &lt;&lt; 2) | 0 = 0xE8 = 232 .</summary>
        XZZW = 0xE8,
        /// <summary>YZZW := GetByteByBit2R(1, 2, 2, 3) = _MM_SHUFFLE(3, 2, 2, 1) = (3 &lt;&lt; 6) | (2 &lt;&lt; 4) | (2 &lt;&lt; 2) | 1 = 0xE9 = 233 .</summary>
        YZZW = 0xE9,
        /// <summary>ZZZW := GetByteByBit2R(2, 2, 2, 3) = _MM_SHUFFLE(3, 2, 2, 2) = (3 &lt;&lt; 6) | (2 &lt;&lt; 4) | (2 &lt;&lt; 2) | 2 = 0xEA = 234 .</summary>
        ZZZW = 0xEA,
        /// <summary>WZZW := GetByteByBit2R(3, 2, 2, 3) = _MM_SHUFFLE(3, 2, 2, 3) = (3 &lt;&lt; 6) | (2 &lt;&lt; 4) | (2 &lt;&lt; 2) | 3 = 0xEB = 235 .</summary>
        WZZW = 0xEB,
        /// <summary>XWZW := GetByteByBit2R(0, 3, 2, 3) = _MM_SHUFFLE(3, 2, 3, 0) = (3 &lt;&lt; 6) | (2 &lt;&lt; 4) | (3 &lt;&lt; 2) | 0 = 0xEC = 236 .</summary>
        XWZW = 0xEC,
        /// <summary>YWZW := GetByteByBit2R(1, 3, 2, 3) = _MM_SHUFFLE(3, 2, 3, 1) = (3 &lt;&lt; 6) | (2 &lt;&lt; 4) | (3 &lt;&lt; 2) | 1 = 0xED = 237 .</summary>
        YWZW = 0xED,
        /// <summary>ZWZW := GetByteByBit2R(2, 3, 2, 3) = _MM_SHUFFLE(3, 2, 3, 2) = (3 &lt;&lt; 6) | (2 &lt;&lt; 4) | (3 &lt;&lt; 2) | 2 = 0xEE = 238 .</summary>
        ZWZW = 0xEE,
        /// <summary>WWZW := GetByteByBit2R(3, 3, 2, 3) = _MM_SHUFFLE(3, 2, 3, 3) = (3 &lt;&lt; 6) | (2 &lt;&lt; 4) | (3 &lt;&lt; 2) | 3 = 0xEF = 239 .</summary>
        WWZW = 0xEF,
        /// <summary>XXWW := GetByteByBit2R(0, 0, 3, 3) = _MM_SHUFFLE(3, 3, 0, 0) = (3 &lt;&lt; 6) | (3 &lt;&lt; 4) | (0 &lt;&lt; 2) | 0 = 0xF0 = 240 .</summary>
        XXWW = 0xF0,
        /// <summary>YXWW := GetByteByBit2R(1, 0, 3, 3) = _MM_SHUFFLE(3, 3, 0, 1) = (3 &lt;&lt; 6) | (3 &lt;&lt; 4) | (0 &lt;&lt; 2) | 1 = 0xF1 = 241 .</summary>
        YXWW = 0xF1,
        /// <summary>ZXWW := GetByteByBit2R(2, 0, 3, 3) = _MM_SHUFFLE(3, 3, 0, 2) = (3 &lt;&lt; 6) | (3 &lt;&lt; 4) | (0 &lt;&lt; 2) | 2 = 0xF2 = 242 .</summary>
        ZXWW = 0xF2,
        /// <summary>WXWW := GetByteByBit2R(3, 0, 3, 3) = _MM_SHUFFLE(3, 3, 0, 3) = (3 &lt;&lt; 6) | (3 &lt;&lt; 4) | (0 &lt;&lt; 2) | 3 = 0xF3 = 243 .</summary>
        WXWW = 0xF3,
        /// <summary>XYWW := GetByteByBit2R(0, 1, 3, 3) = _MM_SHUFFLE(3, 3, 1, 0) = (3 &lt;&lt; 6) | (3 &lt;&lt; 4) | (1 &lt;&lt; 2) | 0 = 0xF4 = 244 .</summary>
        XYWW = 0xF4,
        /// <summary>YYWW := GetByteByBit2R(1, 1, 3, 3) = _MM_SHUFFLE(3, 3, 1, 1) = (3 &lt;&lt; 6) | (3 &lt;&lt; 4) | (1 &lt;&lt; 2) | 1 = 0xF5 = 245 .</summary>
        YYWW = 0xF5,
        /// <summary>ZYWW := GetByteByBit2R(2, 1, 3, 3) = _MM_SHUFFLE(3, 3, 1, 2) = (3 &lt;&lt; 6) | (3 &lt;&lt; 4) | (1 &lt;&lt; 2) | 2 = 0xF6 = 246 .</summary>
        ZYWW = 0xF6,
        /// <summary>WYWW := GetByteByBit2R(3, 1, 3, 3) = _MM_SHUFFLE(3, 3, 1, 3) = (3 &lt;&lt; 6) | (3 &lt;&lt; 4) | (1 &lt;&lt; 2) | 3 = 0xF7 = 247 .</summary>
        WYWW = 0xF7,
        /// <summary>XZWW := GetByteByBit2R(0, 2, 3, 3) = _MM_SHUFFLE(3, 3, 2, 0) = (3 &lt;&lt; 6) | (3 &lt;&lt; 4) | (2 &lt;&lt; 2) | 0 = 0xF8 = 248 .</summary>
        XZWW = 0xF8,
        /// <summary>YZWW := GetByteByBit2R(1, 2, 3, 3) = _MM_SHUFFLE(3, 3, 2, 1) = (3 &lt;&lt; 6) | (3 &lt;&lt; 4) | (2 &lt;&lt; 2) | 1 = 0xF9 = 249 .</summary>
        YZWW = 0xF9,
        /// <summary>ZZWW := GetByteByBit2R(2, 2, 3, 3) = _MM_SHUFFLE(3, 3, 2, 2) = (3 &lt;&lt; 6) | (3 &lt;&lt; 4) | (2 &lt;&lt; 2) | 2 = 0xFA = 250 .</summary>
        ZZWW = 0xFA,
        /// <summary>WZWW := GetByteByBit2R(3, 2, 3, 3) = _MM_SHUFFLE(3, 3, 2, 3) = (3 &lt;&lt; 6) | (3 &lt;&lt; 4) | (2 &lt;&lt; 2) | 3 = 0xFB = 251 .</summary>
        WZWW = 0xFB,
        /// <summary>XWWW := GetByteByBit2R(0, 3, 3, 3) = _MM_SHUFFLE(3, 3, 3, 0) = (3 &lt;&lt; 6) | (3 &lt;&lt; 4) | (3 &lt;&lt; 2) | 0 = 0xFC = 252 .</summary>
        XWWW = 0xFC,
        /// <summary>YWWW := GetByteByBit2R(1, 3, 3, 3) = _MM_SHUFFLE(3, 3, 3, 1) = (3 &lt;&lt; 6) | (3 &lt;&lt; 4) | (3 &lt;&lt; 2) | 1 = 0xFD = 253 .</summary>
        YWWW = 0xFD,
        /// <summary>ZWWW := GetByteByBit2R(2, 3, 3, 3) = _MM_SHUFFLE(3, 3, 3, 2) = (3 &lt;&lt; 6) | (3 &lt;&lt; 4) | (3 &lt;&lt; 2) | 2 = 0xFE = 254 .</summary>
        ZWWW = 0xFE,
        /// <summary>WWWW := GetByteByBit2R(3, 3, 3, 3) = _MM_SHUFFLE(3, 3, 3, 3) = (3 &lt;&lt; 6) | (3 &lt;&lt; 4) | (3 &lt;&lt; 2) | 3 = 0xFF = 255 .</summary>
        WWWW = 0xFF
    }

}
