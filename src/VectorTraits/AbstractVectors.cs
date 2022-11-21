using System;
using System.Collections.Generic;
using System.Text;

namespace Zyl.VectorTraits {

    /// <summary>
    /// Common constants of any Vector types (任何向量类型的公用常量).
    /// </summary>
    /// <typeparam name="T">The vector element type. T can be any primitive numeric type.</typeparam>
    public abstract class AbstractVectors<T> where T : struct {
        /// <summary>(Element) Zero (0).</summary>
        public static T ElementZero { get { return Scalars<T>.V0; } }
        /// <summary>(Element) Value 0 (0的值).</summary>
        public static T ElementV0 { get { return Scalars<T>.V0; } }
        /// <summary>(Element) All bit is 1 (所有位都是1的值).</summary>
        public static T ElementAllBitsSet { get { return Scalars<T>.AllBitsSet; } }
        // -- Number struct --
        /// <summary>(Element) Byte size (字节大小).</summary>
        public static int ElementByteSize { get { return Scalars<T>.ByteSize; } }
        /// <summary>(Element) Bit size (位大小).</summary>
        public static int ElementBitSize { get { return Scalars<T>.BitSize; } }
        /// <summary>(Element) Bit size mask (位大小掩码).</summary>
        public static int ElementBitSizeMask { get { return Scalars<T>.BitSizeMask; } }
        /// <summary>(Element) Exponent bias (指数偏移值). When the type is an integer, the value is 0.</summary>
        public static int ElementExponentBias { get { return Scalars<T>.ExponentBias; } }
        /// <summary>(Element) Sign bit size (符号位数). When the type is an unsigned number, the value is 0.</summary>
        public static int ElementSignBits { get { return Scalars<T>.SignBits; } }
        /// <summary>(Element) Exponent bit size (指数位数). When the type is an integer, the value is 0.</summary>
        public static int ElementExponentBits { get { return Scalars<T>.ExponentBits; } }
        /// <summary>(Element) Mantissa bit size (尾数位数).</summary>
        public static int ElementMantissaBits { get { return Scalars<T>.MantissaBits; } }
        /// <summary>(Element) Sign shift bit (符号位移).</summary>
        public static int ElementSignShift { get { return Scalars<T>.SignShift; } }
        /// <summary>(Element) Exponent shift bit (指数位移).</summary>
        public static int ElementExponentShift { get { return Scalars<T>.ExponentShift; } }
        /// <summary>(Element) Mantissa shift bit (尾数位移).</summary>
        public static int ElementMantissaShift { get { return Scalars<T>.MantissaShift; } }
        /// <summary>(Element) Sign mask (符号掩码).</summary>
        public static T ElementSignMask { get { return Scalars<T>.SignMask; } }
        /// <summary>(Element) Exponent mask (指数掩码).</summary>
        public static T ElementExponentMask { get { return Scalars<T>.ExponentMask; } }
        /// <summary>(Element) Mantissa mast (尾数掩码)k.</summary>
        public static T ElementMantissaMask { get { return Scalars<T>.MantissaMask; } }
        /// <summary>(Element) Non-sign mask (非符号掩码).</summary>
        public static T ElementNonSignMask { get { return Scalars<T>.NonSignMask; } }
        /// <summary>(Element) Non-exponent mask (非指数掩码).</summary>
        public static T ElementNonExponentMask { get { return Scalars<T>.NonExponentMask; } }
        /// <summary>(Element) Non-mantissa mask (非尾数掩码).</summary>
        public static T ElementNonMantissaMask { get { return Scalars<T>.NonMantissaMask; } }
        /// <summary>(Element) Represents the smallest positive value that is greater than zero (表示大于零的最小正值). When the type is an integer, the value is 1 (当类型为整数时，该值为1).</summary>
        public static T ElementEpsilon { get { return Scalars<T>.Epsilon; } }
        /// <summary>(Element) Represents the largest possible value (表示最大可能值).</summary>
        public static T ElementMaxValue { get { return Scalars<T>.MaxValue; } }
        /// <summary>(Element) Represents the smallest possible value (表示最大可能值).</summary>
        public static T ElementMinValue { get { return Scalars<T>.MinValue; } }
        /// <summary>(Element) Represents not a number (NaN) (表示“非数(NaN)”的值). When the type is an integer, the value is 0 (当类型为整数时，该值为0).</summary>
        public static T ElementNaN { get { return Scalars<T>.NaN; } }
        /// <summary>(Element) Represents negative infinity (表示负无穷). When the type is an integer, the value is 0 (当类型为整数时，该值为0).</summary>
        public static T ElementNegativeInfinity { get { return Scalars<T>.NegativeInfinity; } }
        /// <summary>(Element) Represents positive infinity (表示正无穷). When the type is an integer, the value is 0 (当类型为整数时，该值为0).</summary>
        public static T ElementPositiveInfinity { get { return Scalars<T>.PositiveInfinity; } }
        // -- Math --
        /// <summary>(Element) Normalized number of value 1 (值1的归一化数). When the type is an integer, the value is'<see cref="MaxValue"/>'; Otherwise it's 1 (当类型为整数时，它的值为 `<see cref="MaxValue"/>`; 其他情况下为 1).</summary>
        public static T ElementNormOne { get { return Scalars<T>.NormOne; } }
        /// <summary>(Element) Binary shift of fixed point number (定点数的位移). When the type is an integer, the value is' <see cref="BitSize"/>/2 '; Otherwise it's 0 (当类型为整数时，它的值为 `<see cref="BitSize"/>/2`; 其他情况下为 0).</summary>
        public static int ElementFixedShift { get { return Scalars<T>.FixedShift; } }
        /// <summary>(Element) The fixed point number of the value 1 (值1的定点数). When the type is an integer, the value is'Pow(2, <see cref="ElementFixedShift"/>)'; Otherwise it's 1 (当类型为整数时，它的值为 `Pow(2, <see cref="ElementFixedShift"/>)`; 其他情况下为 1).</summary>
        public static T ElementFixedOne { get { return Scalars<T>.FixedOne; } }
        /// <summary>(Element) The double of the fixed point number with the value 1 (值1的定点数的双精度浮点值). When the type is an integer, the value is'Pow(2, <see cref="ElementFixedShift"/>)'; Otherwise it's 1 (当类型为整数时，它的值为 `Pow(2, <see cref="ElementFixedShift"/>)`; 其他情况下为 1).</summary>
        public static double ElementFixedOneDouble { get { return Scalars<T>.FixedOneDouble; } }
        /// <summary>(Element) Represents the natural logarithmic base, specified by the constant, e (表示自然对数的底，它由常数 e 指定).</summary>
        public static T ElementE { get { return Scalars<T>.E; } }
        /// <summary>(Element) Represents the ratio of the circumference of a circle to its diameter, specified by the constant, π (表示圆的周长与其直径的比值，由常数 π 指定).</summary>
        public static T ElementPi { get { return Scalars<T>.Pi; } }
        /// <summary>(Element) Represents the number of radians in one turn, specified by the constant, τ (表示转一圈的弧度数，由常量 τ 指定).</summary>
        public static T ElementTau { get { return Scalars<T>.Tau; } }
        // -- Mask --
        /// <summary>(Element) 1 bits mask (1位掩码).</summary>
        public static T ElementMaskBits1 { get { return Scalars<T>.MaskBits1; } }
        /// <summary>(Element) 2 bits mask (2位掩码).</summary>
        public static T ElementMaskBits2 { get { return Scalars<T>.MaskBits2; } }
        /// <summary>(Element) 4 bits mask (4位掩码).</summary>
        public static T ElementMaskBits4 { get { return Scalars<T>.MaskBits4; } }
        /// <summary>(Element) 8 bits mask (8位掩码).</summary>
        public static T ElementMaskBits8 { get { return Scalars<T>.MaskBits8; } }
        /// <summary>(Element) 16 bits mask (16位掩码).</summary>
        public static T ElementMaskBits16 { get { return Scalars<T>.MaskBits16; } }
        /// <summary>(Element) 32 bits mask (32位掩码).</summary>
        public static T ElementMaskBits32 { get { return Scalars<T>.MaskBits32; } }
        // -- Positive number --
        /// <summary>(Element) Value 1 .</summary>
        public static T ElementV1 { get { return Scalars<T>.V1; } }
        /// <summary>(Element) Value 2 .</summary>
        public static T ElementV2 { get { return Scalars<T>.V2; } }
        /// <summary>(Element) Value 3 .</summary>
        public static T ElementV3 { get { return Scalars<T>.V3; } }
        /// <summary>(Element) Value 4 .</summary>
        public static T ElementV4 { get { return Scalars<T>.V4; } }
        /// <summary>(Element) Value 5 .</summary>
        public static T ElementV5 { get { return Scalars<T>.V5; } }
        /// <summary>(Element) Value 6 .</summary>
        public static T ElementV6 { get { return Scalars<T>.V6; } }
        /// <summary>(Element) Value 7 .</summary>
        public static T ElementV7 { get { return Scalars<T>.V7; } }
        /// <summary>(Element) Value 8 .</summary>
        public static T ElementV8 { get { return Scalars<T>.V8; } }
        /// <summary>(Element) Value 127 (SByte.MaxValue).</summary>
        public static T ElementVMaxSByte { get { return Scalars<T>.VMaxSByte; } }
        /// <summary>(Element) Value 255 (Byte.MaxValue).</summary>
        public static T ElementVMaxByte { get { return Scalars<T>.VMaxByte; } }
        /// <summary>(Element) Value 32767 (Int16.MaxValue) .</summary>
        public static T ElementVMaxInt16 { get { return Scalars<T>.VMaxInt16; } }
        /// <summary>(Element) Value 65535 (UInt16.MaxValue) .</summary>
        public static T ElementVMaxUInt16 { get { return Scalars<T>.VMaxUInt16; } }
        /// <summary>(Element) Value 2147483647 (Int32.MaxValue) .</summary>
        public static T ElementVMaxInt32 { get { return Scalars<T>.VMaxInt32; } }
        /// <summary>(Element) Value 4294967295 (UInt32.MaxValue) .</summary>
        public static T ElementVMaxUInt32 { get { return Scalars<T>.VMaxUInt32; } }
        // -- Negative number  --
        /// <summary>(Element) Value -1 . When the type is unsigned integer, the value is a signed cast value (当类型为无符号整型时，值为带符号强制转换值). Example: '(Byte)(-1)=255' .</summary>
        public static T ElementV_1 { get { return Scalars<T>.V_1; } }
        /// <summary>(Element) Value -2 .</summary>
        public static T ElementV_2 { get { return Scalars<T>.V_2; } }
        /// <summary>(Element) Value -3 .</summary>
        public static T ElementV_3 { get { return Scalars<T>.V_3; } }
        /// <summary>(Element) Value -4 .</summary>
        public static T ElementV_4 { get { return Scalars<T>.V_4; } }
        /// <summary>(Element) Value -5 .</summary>
        public static T ElementV_5 { get { return Scalars<T>.V_5; } }
        /// <summary>(Element) Value -6 .</summary>
        public static T ElementV_6 { get { return Scalars<T>.V_6; } }
        /// <summary>(Element) Value -7 .</summary>
        public static T ElementV_7 { get { return Scalars<T>.V_7; } }
        /// <summary>(Element) Value -8 .</summary>
        public static T ElementV_8 { get { return Scalars<T>.V_8; } }
        /// <summary>(Element) Value -128 (SByte.MinValue).</summary>
        public static T ElementVMinSByte { get { return Scalars<T>.VMinSByte; } }
        /// <summary>(Element) Value -32768 (Int16.MinValue) .</summary>
        public static T ElementVMinInt16 { get { return Scalars<T>.VMinInt16; } }
        /// <summary>(Element) Value -2147483648 (Int32.MinValue) .</summary>
        public static T ElementVMinInt32 { get { return Scalars<T>.VMinInt32; } }
        // -- Reciprocal number --
        /// <summary>Reciprocal value: 1/127 (SByte.MaxValue). When the type is an integer, it is a fixed point number using the <see cref="ElementFixedShift"/> convention (当类型为整数时, 是使用 <see cref="ElementFixedShift"/> 约定的定点数).</summary>
        public static T ElementVReciprocalMaxSByte { get { return Scalars<T>.VReciprocalMaxSByte; } }
        /// <summary>Reciprocal value: 1/255 (Byte.MaxValue). When the type is an integer, it is a fixed point number using the <see cref="ElementFixedShift"/> convention (当类型为整数时, 是使用 <see cref="ElementFixedShift"/> 约定的定点数).</summary>
        public static T ElementVReciprocalMaxByte { get { return Scalars<T>.VReciprocalMaxByte; } }
        /// <summary>Reciprocal value: 1/32767 (Int16.MaxValue). When the type is an integer, it is a fixed point number using the <see cref="ElementFixedShift"/> convention (当类型为整数时, 是使用 <see cref="ElementFixedShift"/> 约定的定点数).</summary>
        public static T ElementVReciprocalMaxInt16 { get { return Scalars<T>.VReciprocalMaxInt16; } }
        /// <summary>Reciprocal value: 1/65535 (UInt16.MaxValue). When the type is an integer, it is a fixed point number using the <see cref="ElementFixedShift"/> convention (当类型为整数时, 是使用 <see cref="ElementFixedShift"/> 约定的定点数).</summary>
        public static T ElementVReciprocalMaxUInt16 { get { return Scalars<T>.VReciprocalMaxUInt16; } }
        /// <summary>Reciprocal value: 1/2147483647 (Int32.MaxValue). When the type is an integer, it is a fixed point number using the <see cref="ElementFixedShift"/> convention (当类型为整数时, 是使用 <see cref="ElementFixedShift"/> 约定的定点数).</summary>
        public static T ElementVReciprocalMaxInt32 { get { return Scalars<T>.VReciprocalMaxInt32; } }
        /// <summary>Reciprocal value: 1/4294967295 (UInt32.MaxValue). When the type is an integer, it is a fixed point number using the <see cref="ElementFixedShift"/> convention (当类型为整数时, 是使用 <see cref="ElementFixedShift"/> 约定的定点数).</summary>
        public static T ElementVReciprocalMaxUInt32 { get { return Scalars<T>.VReciprocalMaxUInt32; } }
    }

}
