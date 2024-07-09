using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using System.Text;

namespace Zyl.VectorTraits {
    /// <summary>
    /// Constants of <see cref="Vector64{T}"/> .
    /// </summary>
    /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
    public abstract class Vector64s<T> : AbstractVectors<T> where T : struct {
#if NETCOREAPP3_0_OR_GREATER
        // -- Number struct --
        /// <summary>Sign mask (符号掩码).</summary>
        public static readonly Vector64<T> SignMask;
        /// <summary>Exponent mask (指数掩码).</summary>
        public static readonly Vector64<T> ExponentMask;
        /// <summary>Mantissa mask (尾数掩码).</summary>
        public static readonly Vector64<T> MantissaMask;
        /// <summary>Non-sign mask (非符号掩码).</summary>
        public static readonly Vector64<T> NonSignMask;
        /// <summary>Non-exponent mask (非指数掩码).</summary>
        public static readonly Vector64<T> NonExponentMask;
        /// <summary>Non-mantissa mask (非尾数掩码).</summary>
        public static readonly Vector64<T> NonMantissaMask;
        /// <summary>Represents the smallest positive value that is greater than zero (表示大于零的最小正值). When the type is an integer, the value is 1 (当类型为整数时，该值为1).</summary>
        public static readonly Vector64<T> Epsilon;
        /// <summary>Represents the largest possible value (表示最大可能值).</summary>
        public static readonly Vector64<T> MaxValue;
        /// <summary>Represents the smallest possible value (表示最小可能值).</summary>
        public static readonly Vector64<T> MinValue;
        /// <summary>Represents not a number (NaN) (表示“非数(NaN)”的值). When the type is an integer, the value is 0 (当类型为整数时，该值为0).</summary>
        public static readonly Vector64<T> NaN;
        /// <summary>Represents negative infinity (表示负无穷). When the type is an integer, the value is 0 (当类型为整数时，该值为0).</summary>
        public static readonly Vector64<T> NegativeInfinity;
        /// <summary>Represents positive infinity (表示正无穷). When the type is an integer, the value is 0 (当类型为整数时，该值为0).</summary>
        public static readonly Vector64<T> PositiveInfinity;
        // -- Math --
        /// <summary>Normalized number of value 1 (值1的归一化数). When the type is an integer, the value is'<see cref="AbstractVectors{T}.ElementMaxValue"/>'; Otherwise it's 1 (当类型为整数时，它的值为 `<see cref="AbstractVectors{T}.ElementMaxValue"/>`; 其他情况下为 1).</summary>
        public static readonly Vector64<T> NormOne;
        /// <summary>The fixed point number of the value 1 (值1的定点数). When the type is an integer, the value is'Pow(2, <see cref="AbstractVectors{T}.ElementFixedShift"/>)'; Otherwise it's 1 (当类型为整数时，它的值为 `Pow(2, <see cref="AbstractVectors{T}.ElementFixedShift"/>)`; 其他情况下为 1).</summary>
        public static readonly Vector64<T> FixedOne;
        /// <summary>Represents the natural logarithmic base, specified by the constant, e (表示自然对数的底，它由常数 e 指定).</summary>
        public static readonly Vector64<T> E;
        /// <summary>Represents the ratio of the circumference of a circle to its diameter, specified by the constant, π (表示圆的周长与其直径的比值，由常数 π 指定).</summary>
        public static readonly Vector64<T> Pi;
        /// <summary>Represents the number of radians in one turn, specified by the constant, τ (表示转一圈的弧度数，由常量 τ 指定).</summary>
        public static readonly Vector64<T> Tau;
        // -- Positive number --
        /// <summary>Value 1 .</summary>
        public static readonly Vector64<T> V1;
        /// <summary>Value 2 .</summary>
        public static readonly Vector64<T> V2;
        /// <summary>Value 3 .</summary>
        public static readonly Vector64<T> V3;
        /// <summary>Value 4 .</summary>
        public static readonly Vector64<T> V4;
        /// <summary>Value 5 .</summary>
        public static readonly Vector64<T> V5;
        /// <summary>Value 6 .</summary>
        public static readonly Vector64<T> V6;
        /// <summary>Value 7 .</summary>
        public static readonly Vector64<T> V7;
        /// <summary>Value 8 .</summary>
        public static readonly Vector64<T> V8;
        /// <summary>Value 127 (sbyte.MaxValue).</summary>
        public static readonly Vector64<T> VMaxSByte;
        /// <summary>Value 255 (byte.MaxValue).</summary>
        public static readonly Vector64<T> VMaxByte;
        /// <summary>Value 32767 (short.MaxValue) .</summary>
        public static readonly Vector64<T> VMaxInt16;
        /// <summary>Value 65535 (ushort.MaxValue) .</summary>
        public static readonly Vector64<T> VMaxUInt16;
        /// <summary>Value 2147483647 (int.MaxValue) .</summary>
        public static readonly Vector64<T> VMaxInt32;
        /// <summary>Value 4294967295 (uint.MaxValue) .</summary>
        public static readonly Vector64<T> VMaxUInt32;
        // -- Negative number --
        /// <summary>Value -1 . When the type is unsigned integer, the value is a signed cast value (当类型为无符号整型时，值为有符号强制转换值). Example: '(byte)(-1)=255' .</summary>
        public static readonly Vector64<T> V_1;
        /// <summary>Value -2 .</summary>
        public static readonly Vector64<T> V_2;
        /// <summary>Value -3 .</summary>
        public static readonly Vector64<T> V_3;
        /// <summary>Value -4 .</summary>
        public static readonly Vector64<T> V_4;
        /// <summary>Value -5 .</summary>
        public static readonly Vector64<T> V_5;
        /// <summary>Value -6 .</summary>
        public static readonly Vector64<T> V_6;
        /// <summary>Value -7 .</summary>
        public static readonly Vector64<T> V_7;
        /// <summary>Value -8 .</summary>
        public static readonly Vector64<T> V_8;
        /// <summary>Value -128 (sbyte.MinValue).</summary>
        public static readonly Vector64<T> VMinSByte;
        /// <summary>Value -32768 (short.MinValue) .</summary>
        public static readonly Vector64<T> VMinInt16;
        /// <summary>Value -2147483648 (int.MinValue) .</summary>
        public static readonly Vector64<T> VMinInt32;
        // -- Reciprocal number --
        /// <summary>Reciprocal value: 1/127 (sbyte.MaxValue). When the type is an integer, it is a fixed point number using the <see cref="AbstractVectors{T}.ElementFixedShift"/> convention (当类型为整数时, 是使用 <see cref="AbstractVectors{T}.ElementFixedShift"/> 约定的定点数).</summary>
        public static readonly Vector64<T> VReciprocalMaxSByte;
        /// <summary>Reciprocal value: 1/255 (byte.MaxValue). When the type is an integer, it is a fixed point number using the <see cref="AbstractVectors{T}.ElementFixedShift"/> convention (当类型为整数时, 是使用 <see cref="AbstractVectors{T}.ElementFixedShift"/> 约定的定点数).</summary>
        public static readonly Vector64<T> VReciprocalMaxByte;
        /// <summary>Reciprocal value: 1/32767 (short.MaxValue). When the type is an integer, it is a fixed point number using the <see cref="AbstractVectors{T}.ElementFixedShift"/> convention (当类型为整数时, 是使用 <see cref="AbstractVectors{T}.ElementFixedShift"/> 约定的定点数).</summary>
        public static readonly Vector64<T> VReciprocalMaxInt16;
        /// <summary>Reciprocal value: 1/65535 (ushort.MaxValue). When the type is an integer, it is a fixed point number using the <see cref="AbstractVectors{T}.ElementFixedShift"/> convention (当类型为整数时, 是使用 <see cref="AbstractVectors{T}.ElementFixedShift"/> 约定的定点数).</summary>
        public static readonly Vector64<T> VReciprocalMaxUInt16;
        /// <summary>Reciprocal value: 1/2147483647 (int.MaxValue). When the type is an integer, it is a fixed point number using the <see cref="AbstractVectors{T}.ElementFixedShift"/> convention (当类型为整数时, 是使用 <see cref="AbstractVectors{T}.ElementFixedShift"/> 约定的定点数).</summary>
        public static readonly Vector64<T> VReciprocalMaxInt32;
        /// <summary>Reciprocal value: 1/4294967295 (uint.MaxValue). When the type is an integer, it is a fixed point number using the <see cref="AbstractVectors{T}.ElementFixedShift"/> convention (当类型为整数时, 是使用 <see cref="AbstractVectors{T}.ElementFixedShift"/> 约定的定点数).</summary>
        public static readonly Vector64<T> VReciprocalMaxUInt32;
        // -- Specified value --
        /// <summary>The mask of the index (索引的掩码). All the elements have a value of <c>Count-1</c>.</summary>
        public static readonly Vector64<T> IndexMask;
        /// <summary>The mask of the index on Each128 (Each128上索引的掩码). All the elements have a value of <c>(16/sizeof(T))-1</c>.</summary>
        public static readonly Vector64<T> IndexMaskEach128;
        /// <summary>The mask of the index*2 (索引*2时的掩码). All the elements have a value of <c>Count*2-1</c>.</summary>
        public static readonly Vector64<T> IndexX2Mask;
        /// <summary>The mask of the index*4 (索引*4时的掩码). All the elements have a value of <c>Count*4-1</c>.</summary>
        public static readonly Vector64<T> IndexX4Mask;
        /// <summary>Serial Value (顺序值). e.g. 0, 1, 2, 3 ...</summary>
        public static readonly Vector64<T> Serial;
        /// <summary>Serial Value descend (顺序值降序). e.g. (Count-1), (Count-2), ... 2, 1, 0</summary>
        public static readonly Vector64<T> SerialDesc;
        /// <summary>Negative serial Value (负数顺序值). e.g. 0, -1, -2, -3 ...</summary>
        public static readonly Vector64<T> SerialNegative;
        /// <summary>Demo Value (演示值). It is a value constructed for testing purposes (它是为测试目的而构造的值).</summary>
        public static readonly Vector64<T> Demo;
        /// <summary>NaN Demo Value (NaN演示值). It is a value constructed for testing purposes (它是为测试目的而构造的值).</summary>
        public static readonly Vector64<T> DemoNaN;
        /// <summary>NaN Demo Value 2 (NaN演示值2). It is a value constructed for testing purposes (它是为测试目的而构造的值).</summary>
        public static readonly Vector64<T> DemoNaN2;
        /// <summary>Serial bit pos mask (顺序位偏移的掩码). The element whose index exceeds the number of bits has a value of 0(索引超过位数的元素值为0). e.g. 1, 2, 4, 8, 0x10 ...</summary>
        public static readonly Vector64<T> MaskBitPosSerial;
        /// <summary>Serial bit pos rotate mask (顺序位偏移的旋转掩码). e.g. 1, 2, 4, 8, 0x10, ... 1, 2, 4, 8, 0x10, ...</summary>
        public static readonly Vector64<T> MaskBitPosSerialRotate;
        /// <summary>Serial bits mask (顺序位集的掩码). The element whose index exceeds the number of bits has a value of all bit set 1(索引超过位数的元素值为所有位都是1的值). e.g. 1, 3, 7, 0xF, 0x1F ...</summary>
        public static readonly Vector64<T> MaskBitsSerial;
        /// <summary>Serial bits rotate mask (顺序位集的旋转掩码). e.g. 1, 3, 7, 0xF, 0x1F ...</summary>
        public static readonly Vector64<T> MaskBitsSerialRotate;
        /// <summary>Interlaced sign number (交错的符号数值). e.g. 1, -1, 1, -1, 1, -1 ...</summary>
        public static readonly Vector64<T> InterlacedSign;
        /// <summary>Interlaced sign number starting with a negative number (负数开头的交错的符号数值). e.g. -1, 1, -1, 1, -1, 1 ...</summary>
        public static readonly Vector64<T> InterlacedSignNegative;
        // -- Xy --
        /// <summary>Xy - Address 0 mask. For a 2-element group, select the mask of the address 0th element (对于2个元素的组，选择地址为第0个元素的掩码).</summary>
        public static readonly Vector64<T> XyAddress0Mask;
        /// <summary>Xy - Address 0 mask. For a 2-element group, select the mask of the address 1st element (对于2个元素的组，选择地址为第1个元素的掩码).</summary>
        public static readonly Vector64<T> XyAddress1Mask;
        /// <summary>Xy - Address 0 is normalized number of value 1 (地址0为 值1的归一化数).</summary>
        public static readonly Vector64<T> XyAddress0NormOne;
        /// <summary>Xy - Address 1 is normalized number of value 1 (地址1为 值1的归一化数).</summary>
        public static readonly Vector64<T> XyAddress1NormOne;
        /// <summary>Xy - X mask. For a 2-element group, select the mask of the position 0th element (对于2个元素的组，选择位置为第0个元素的掩码).</summary>
        public static readonly Vector64<T> XyXMask;
        /// <summary>Xy - Y mask. For a 2-element group, select the mask of the position 1st element (对于2个元素的组，选择位置为第1个元素的掩码).</summary>
        public static readonly Vector64<T> XyYMask;
        /// <summary>Xy - X is normalized number of value 1 (X为 值1的归一化数).</summary>
        public static readonly Vector64<T> XyXNormOne;
        /// <summary>Xy - Y is normalized number of value 1 (Y为 值1的归一化数).</summary>
        public static readonly Vector64<T> XyYNormOne;
        // -- Xyzw --
        /// <summary>Xyzw - Address 0 mask. For a 4-element group, select the mask of the address 0th element (对于4个元素的组，选择地址为第0个元素的掩码).</summary>
        public static readonly Vector64<T> XyzwAddress0Mask;
        /// <summary>Xyzw - Address 1 mask. For a 4-element group, select the mask of the address 0th element (对于4个元素的组，选择地址为第1个元素的掩码).</summary>
        public static readonly Vector64<T> XyzwAddress1Mask;
        /// <summary>Xyzw - Address 2 mask. For a 4-element group, select the mask of the address 0th element (对于4个元素的组，选择地址为第2个元素的掩码).</summary>
        public static readonly Vector64<T> XyzwAddress2Mask;
        /// <summary>Xyzw - Address 3 mask. For a 4-element group, select the mask of the address 0th element (对于4个元素的组，选择地址为第3个元素的掩码).</summary>
        public static readonly Vector64<T> XyzwAddress3Mask;
        /// <summary>Xyzw - Address 0 is normalized number of value 1 (地址0为 值1的归一化数).</summary>
        public static readonly Vector64<T> XyzwAddress0NormOne;
        /// <summary>Xyzw - Address 1 is normalized number of value 1 (地址1为 值1的归一化数).</summary>
        public static readonly Vector64<T> XyzwAddress1NormOne;
        /// <summary>Xyzw - Address 2 is normalized number of value 1 (地址2为 值1的归一化数).</summary>
        public static readonly Vector64<T> XyzwAddress2NormOne;
        /// <summary>Xyzw - Address 3 is normalized number of value 1 (地址3为 值1的归一化数).</summary>
        public static readonly Vector64<T> XyzwAddress3NormOne;
        /// <summary>Xyzw - X mask. For a 4-element group, select the mask of the position 0th element (对于4个元素的组，选择位置为第0个元素的掩码).</summary>
        public static readonly Vector64<T> XyzwXMask;
        /// <summary>Xyzw - Y mask. For a 4-element group, select the mask of the position 1th element (对于4个元素的组，选择位置为第1个元素的掩码).</summary>
        public static readonly Vector64<T> XyzwYMask;
        /// <summary>Xyzw - Z mask. For a 4-element group, select the mask of the position 2th element (对于4个元素的组，选择位置为第2个元素的掩码).</summary>
        public static readonly Vector64<T> XyzwZMask;
        /// <summary>Xyzw - W mask. For a 4-element group, select the mask of the position 3th element (对于4个元素的组，选择位置为第3个元素的掩码).</summary>
        public static readonly Vector64<T> XyzwWMask;
        /// <summary>Xyzw - X is normalized number of value 1 (X为 值1的归一化数).</summary>
        public static readonly Vector64<T> XyzwXNormOne;
        /// <summary>Xyzw - Y is normalized number of value 1 (Y为 值1的归一化数).</summary>
        public static readonly Vector64<T> XyzwYNormOne;
        /// <summary>Xyzw - Z is normalized number of value 1 (Z为 值1的归一化数).</summary>
        public static readonly Vector64<T> XyzwZNormOne;
        /// <summary>Xyzw - W is normalized number of value 1 (W为 值1的归一化数).</summary>
        public static readonly Vector64<T> XyzwWNormOne;
        // == Mask array ==
        /// <summary>Bit pos mask array (位偏移掩码的数组). e.g. 1, 2, 4, 8, 0x10 ...</summary>
        private static readonly Vector64<byte>[] MaskBitPosArray;
        /// <summary>Bits mask array (位集掩码的数组). e.g. 0, 1, 3, 7, 0xF, 0x1F ...</summary>
        private static readonly Vector64<byte>[] MaskBitsArray;

        /// <summary>
        /// Static constructor.
        /// </summary>
        static Vector64s() {
            // -- Number struct --
            SignMask = Vector64s.Create<T>(ElementSignMask);
            ExponentMask = Vector64s.Create<T>(ElementExponentMask);
            MantissaMask = Vector64s.Create<T>(ElementMantissaMask);
            NonSignMask = Vector64s.Create<T>(ElementNonSignMask);
            NonExponentMask = Vector64s.Create<T>(ElementNonExponentMask);
            NonMantissaMask = Vector64s.Create<T>(ElementNonMantissaMask);
            Epsilon = Vector64s.Create<T>(ElementEpsilon);
            MaxValue = Vector64s.Create<T>(ElementMaxValue);
            MinValue = Vector64s.Create<T>(ElementMinValue);
            NaN = Vector64s.Create<T>(ElementNaN);
            NegativeInfinity = Vector64s.Create<T>(ElementNegativeInfinity);
            PositiveInfinity = Vector64s.Create<T>(ElementPositiveInfinity);
            // -- Math --
            NormOne = Vector64s.Create<T>(ElementNormOne);
            FixedOne = Vector64s.Create<T>(ElementFixedOne);
            E = Vector64s.Create<T>(ElementE);
            Pi = Vector64s.Create<T>(ElementPi);
            Tau = Vector64s.Create<T>(ElementTau);
            // -- Positive number --
            V1 = Vector64s.Create<T>(ElementV1);
            V2 = Vector64s.Create<T>(ElementV2);
            V3 = Vector64s.Create<T>(ElementV3);
            V4 = Vector64s.Create<T>(ElementV4);
            V5 = Vector64s.Create<T>(ElementV5);
            V6 = Vector64s.Create<T>(ElementV6);
            V7 = Vector64s.Create<T>(ElementV7);
            V8 = Vector64s.Create<T>(ElementV8);
            VMaxSByte = Vector64s.Create<T>(ElementVMaxSByte);
            VMaxByte = Vector64s.Create<T>(ElementVMaxByte);
            VMaxInt16 = Vector64s.Create<T>(ElementVMaxInt16);
            VMaxUInt16 = Vector64s.Create<T>(ElementVMaxUInt16);
            VMaxInt32 = Vector64s.Create<T>(ElementVMaxInt32);
            VMaxUInt32 = Vector64s.Create<T>(ElementVMaxUInt32);
            // -- Negative number  --
            V_1 = Vector64s.Create<T>(ElementV_1);
            V_2 = Vector64s.Create<T>(ElementV_2);
            V_3 = Vector64s.Create<T>(ElementV_3);
            V_4 = Vector64s.Create<T>(ElementV_4);
            V_5 = Vector64s.Create<T>(ElementV_5);
            V_6 = Vector64s.Create<T>(ElementV_6);
            V_7 = Vector64s.Create<T>(ElementV_7);
            V_8 = Vector64s.Create<T>(ElementV_8);
            VMinSByte = Vector64s.Create<T>(ElementVMinSByte);
            VMinInt16 = Vector64s.Create<T>(ElementVMinInt16);
            VMinInt32 = Vector64s.Create<T>(ElementVMinInt32);
            // -- Reciprocal number  --
            VReciprocalMaxSByte = Vector64s.Create<T>(ElementVReciprocalMaxSByte);
            VReciprocalMaxByte = Vector64s.Create<T>(ElementVReciprocalMaxByte);
            VReciprocalMaxInt16 = Vector64s.Create<T>(ElementVReciprocalMaxInt16);
            VReciprocalMaxUInt16 = Vector64s.Create<T>(ElementVReciprocalMaxUInt16);
            VReciprocalMaxInt32 = Vector64s.Create<T>(ElementVReciprocalMaxInt32);
            VReciprocalMaxUInt32 = Vector64s.Create<T>(ElementVReciprocalMaxUInt32);
            // -- Specified value --
            IndexMask = Vector64s.CreateByBits<T>(Vector64s.Count<T>() - 1);
            IndexMaskEach128 = Vector64s.CreateByBits<T>((16 / Scalars<T>.ByteSize) - 1);
            IndexX2Mask = Vector64s.CreateByBits<T>(Vector64s.Count<T>() * 2 - 1);
            IndexX4Mask = Vector64s.CreateByBits<T>(Vector64s.Count<T>() * 4 - 1);
            Serial = Vector64s.CreateByDoubleLoop<T>(0, 1);
            SerialDesc = Vector64s.CreateByDoubleLoop<T>(Vector64s.Count<T>() - 1, -1);
            SerialNegative = Vector64s.CreateByDoubleLoop<T>(0, -1);
            Demo = Vector64s.CreateByFunc<T>(Vectors.GenerateDemoElement<T>);
            DemoNaN = Vector64s.CreateRotate<T>(ElementNaN, ElementNegativeInfinity, ElementSignMask, ElementPositiveInfinity, ElementMaxValue, ElementMinValue, ElementV6, ElementV7);
            DemoNaN2 = Vector64s.CreateRotate<T>(ElementPositiveInfinity, ElementNaN, ElementNegativeInfinity, ElementSignMask, ElementV_4, ElementMaxValue, ElementMinValue, ElementV_7);
            int bitLen = ElementByteSize * 8;
            MaskBitPosSerial = Vector64s.CreateByFunc<T>(delegate (int index) {
                long n = 0;
                if (index < bitLen) {
                    n = 1L << index;
                }
                return Scalars.GetByBits<T>(n);
            });
            MaskBitPosSerialRotate = Vector64s.CreateByFunc<T>(delegate (int index) {
                int m = index % bitLen;
                long n = 1L << m;
                return Scalars.GetByBits<T>(n);
            });
            MaskBitsSerial = Vector64s.CreateByFunc<T>(delegate (int index) {
                int m = Math.Min(index + 1, bitLen);
                return Scalars.GetBitsMask<T>(0, m);
            });
            MaskBitsSerialRotate = Vector64s.CreateByFunc<T>(delegate (int index) {
                int m = index % bitLen + 1;
                return Scalars.GetBitsMask<T>(0, m);
            });
            InterlacedSign = Vector64s.CreateRotate<T>(ElementV1, ElementV_1);
            InterlacedSignNegative = Vector64s.CreateRotate<T>(ElementV_1, ElementV1);
            // -- Xyzw --
            if (true) {
                T o = ElementZero;
                T f = ElementAllBitsSet;
                T n = ElementNormOne;
                XyAddress0Mask = Vector64s.CreateRotate<T>(f, o);
                XyAddress1Mask = Vector64s.CreateRotate<T>(o, f);
                XyAddress0NormOne = Vector64s.CreateRotate<T>(n, o);
                XyAddress1NormOne = Vector64s.CreateRotate<T>(o, n);
                XyzwAddress0Mask = Vector64s.CreateRotate<T>(f, o, o, o);
                XyzwAddress1Mask = Vector64s.CreateRotate<T>(o, f, o, o);
                XyzwAddress2Mask = Vector64s.CreateRotate<T>(o, o, f, o);
                XyzwAddress3Mask = Vector64s.CreateRotate<T>(o, o, o, f);
                XyzwAddress0NormOne = Vector64s.CreateRotate<T>(n, o, o, o);
                XyzwAddress1NormOne = Vector64s.CreateRotate<T>(o, n, o, o);
                XyzwAddress2NormOne = Vector64s.CreateRotate<T>(o, o, n, o);
                XyzwAddress3NormOne = Vector64s.CreateRotate<T>(o, o, o, n);
            }
            if (BitConverter.IsLittleEndian) {
                XyXMask = XyAddress0Mask;
                XyYMask = XyAddress1Mask;
                XyXNormOne = XyAddress0NormOne;
                XyYNormOne = XyAddress1NormOne;
                XyzwXMask = XyzwAddress0Mask;
                XyzwYMask = XyzwAddress1Mask;
                XyzwZMask = XyzwAddress2Mask;
                XyzwWMask = XyzwAddress3Mask;
                XyzwXNormOne = XyzwAddress0NormOne;
                XyzwYNormOne = XyzwAddress1NormOne;
                XyzwZNormOne = XyzwAddress2NormOne;
                XyzwWNormOne = XyzwAddress3NormOne;
            } else {
                XyXMask = XyAddress1Mask;
                XyYMask = XyAddress0Mask;
                XyXNormOne = XyAddress1NormOne;
                XyYNormOne = XyAddress0NormOne;
                XyzwXMask = XyzwAddress3Mask;
                XyzwYMask = XyzwAddress2Mask;
                XyzwZMask = XyzwAddress1Mask;
                XyzwWMask = XyzwAddress0Mask;
                XyzwXNormOne = XyzwAddress3NormOne;
                XyzwYNormOne = XyzwAddress2NormOne;
                XyzwZNormOne = XyzwAddress1NormOne;
                XyzwWNormOne = XyzwAddress0NormOne;
            }
            // == Mask array ==
            MaskBitPosArray = Vector64s.GetMaskBitPosArray(ElementByteSize);
            MaskBitsArray = Vector64s.GetMaskBitsArray(ElementByteSize);
        }

        /// <summary>
        /// Returns the number of elements stored in the vector (返回存储在向量中的元素数量). It supports ExType (它支持扩展类型).
        /// </summary>
        public static int Count {
            get {
                return Vector64s.Count<T>();
            }
        }

        /// <summary>
        /// Get bit pos mask by index (根据索引获取位偏移掩码). The equivalent of <c>Vector64s.Create(Scalars.GetByBits&lt;T&gt;(1L &lt;&lt; index))</c>.
        /// </summary>
        /// <param name="index">The index (索引). The value ranges from 0 to <c>ElementBitSize-1</c> (值的范围是 0 ~ <c>ElementBitSize-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bit pos mask (返回位偏移掩码).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Vector64<T> GetMaskBitPos(int index) {
            return ref Unsafe.As<Vector64<byte>, Vector64<T>>(ref MaskBitPosArray[index]);
        }

        /// <summary>
        /// Get bit pos mask span (获取位偏移掩码的跨度). Tip: You can use <see cref="Unsafe.As{TFrom, TTo}(ref TFrom)"/> convert its item to <see cref="Vector64{T}"/> type (提示: 可以用 <see cref="Unsafe.As{TFrom, TTo}(ref TFrom)"/> 将其中条目转为 <see cref="Vector64{T}"/> 类型).
        /// </summary>
        /// <returns>Returns bit pos mask span (返回位偏移掩码的跨度).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlySpan<Vector64<byte>> GetMaskBitPosSpan() {
            return new ReadOnlySpan<Vector64<byte>>(MaskBitPosArray);
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码). The equivalent of <c>Vector64s.Create(Scalars.GetBitsMask&lt;T&gt;(0, index))</c>.
        /// </summary>
        /// <param name="index">The index (索引). The value ranges from 0 to <c>ElementBitSize</c> (值的范围是 0 ~ <c>ElementBitSize</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Vector64<T> GetMaskBits(int index) {
            return ref Unsafe.As<Vector64<byte>, Vector64<T>>(ref MaskBitsArray[index]);
        }

        /// <summary>
        /// Get bits mask span (获取位集掩码的跨度). Tip: You can use <see cref="Unsafe.As{TFrom, TTo}(ref TFrom)"/> convert its item to <see cref="Vector64{T}"/> type (提示: 可以用 <see cref="Unsafe.As{TFrom, TTo}(ref TFrom)"/> 将其中条目转为 <see cref="Vector64{T}"/> 类型).
        /// </summary>
        /// <returns>Returns bits mask span (返回位集掩码的跨度).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlySpan<Vector64<byte>> GetMaskBitsSpan() {
            return new ReadOnlySpan<Vector64<byte>>(MaskBitsArray);
        }


        /// <summary>Zero (0).</summary>
        /// <seealso cref="Vector64{T}.Zero"/>
        public static Vector64<T> Zero { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Vector64<byte>.Zero.ExAs<byte, T>(); } }
        /// <summary>Value 0 (0的值).</summary>
        /// <seealso cref="Vector64{T}.Zero"/>
        public static Vector64<T> V0 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Vector64<byte>.Zero.ExAs<byte, T>(); } }
        /// <summary>All bit is 1 (所有位都是1的值).</summary>
        /// <seealso cref="Vector64{T}.AllBitsSet"/>
        public static Vector64<T> AllBitsSet {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET5_0_OR_GREATER
                return Vector64<T>.AllBitsSet;
#else
                return Vector64.Create((int)-1).As<int, T>();
#endif // NET5_0_OR_GREATER
            }
        }


        /// <summary>1 bits mask (1位掩码).</summary>
        public static ref readonly Vector64<T> MaskBits1 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return ref GetMaskBits(1); } }
        /// <summary>2 bits mask (2位掩码).</summary>
        public static ref readonly Vector64<T> MaskBits2 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return ref GetMaskBits(2); } }
        /// <summary>4 bits mask (4位掩码).</summary>
        public static ref readonly Vector64<T> MaskBits4 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return ref GetMaskBits(4); } }
        /// <summary>8 bits mask (8位掩码).</summary>
        public static ref readonly Vector64<T> MaskBits8 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return ref GetMaskBits(8); } }
        /// <summary>16 bits mask (16位掩码).</summary>
        public static ref readonly Vector64<T> MaskBits16 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return ref GetMaskBits(Math.Min(ElementBitSize, 16)); } }
        /// <summary>32 bits mask (32位掩码).</summary>
        public static ref readonly Vector64<T> MaskBits32 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return ref GetMaskBits(Math.Min(ElementBitSize, 32)); } }

#endif
    }

}
