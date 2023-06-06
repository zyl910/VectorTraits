using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Zyl.VectorTraits {

    /// <summary>
    /// Constants of <see cref="Vector{T}"/> .
    /// </summary>
    /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
    public abstract class Vectors<T> : AbstractVectors<T> where T : struct {
        // -- Number struct --
        /// <summary>Sign mask (符号掩码).</summary>
        public static readonly Vector<T> SignMask;
        /// <summary>Exponent mask (指数掩码).</summary>
        public static readonly Vector<T> ExponentMask;
        /// <summary>Mantissa mask (尾数掩码).</summary>
        public static readonly Vector<T> MantissaMask;
        /// <summary>Non-sign mask (非符号掩码).</summary>
        public static readonly Vector<T> NonSignMask;
        /// <summary>Non-exponent mask (非指数掩码).</summary>
        public static readonly Vector<T> NonExponentMask;
        /// <summary>Non-mantissa mask (非尾数掩码).</summary>
        public static readonly Vector<T> NonMantissaMask;
        /// <summary>Represents the smallest positive value that is greater than zero (表示大于零的最小正值). When the type is an integer, the value is 1 (当类型为整数时，该值为1).</summary>
        public static readonly Vector<T> Epsilon;
        /// <summary>Represents the largest possible value (表示最大可能值).</summary>
        public static readonly Vector<T> MaxValue;
        /// <summary>Represents the smallest possible value (表示最小可能值).</summary>
        public static readonly Vector<T> MinValue;
        /// <summary>Represents not a number (NaN) (表示“非数(NaN)”的值). When the type is an integer, the value is 0 (当类型为整数时，该值为0).</summary>
        public static readonly Vector<T> NaN;
        /// <summary>Represents negative infinity (表示负无穷). When the type is an integer, the value is 0 (当类型为整数时，该值为0).</summary>
        public static readonly Vector<T> NegativeInfinity;
        /// <summary>Represents positive infinity (表示正无穷). When the type is an integer, the value is 0 (当类型为整数时，该值为0).</summary>
        public static readonly Vector<T> PositiveInfinity;
        // -- Math --
        /// <summary>Normalized number of value 1 (值1的归一化数). When the type is an integer, the value is'<see cref="ElementMaxValue"/>'; Otherwise it's 1 (当类型为整数时，它的值为 `<see cref="ElementMaxValue"/>`; 其他情况下为 1).</summary>
        public static readonly Vector<T> NormOne;
        /// <summary>The fixed point number of the value 1 (值1的定点数). When the type is an integer, the value is'Pow(2, <see cref="ElementFixedShift"/>)'; Otherwise it's 1 (当类型为整数时，它的值为 `Pow(2, <see cref="ElementFixedShift"/>)`; 其他情况下为 1).</summary>
        public static readonly Vector<T> FixedOne;
        /// <summary>Represents the natural logarithmic base, specified by the constant, e (表示自然对数的底，它由常数 e 指定).</summary>
        public static readonly Vector<T> E;
        /// <summary>Represents the ratio of the circumference of a circle to its diameter, specified by the constant, π (表示圆的周长与其直径的比值，由常数 π 指定).</summary>
        public static readonly Vector<T> Pi;
        /// <summary>Represents the number of radians in one turn, specified by the constant, τ (表示转一圈的弧度数，由常量 τ 指定).</summary>
        public static readonly Vector<T> Tau;
        // -- Positive number --
        /// <summary>Value 1 .</summary>
        public static readonly Vector<T> V1;
        /// <summary>Value 2 .</summary>
        public static readonly Vector<T> V2;
        /// <summary>Value 3 .</summary>
        public static readonly Vector<T> V3;
        /// <summary>Value 4 .</summary>
        public static readonly Vector<T> V4;
        /// <summary>Value 5 .</summary>
        public static readonly Vector<T> V5;
        /// <summary>Value 6 .</summary>
        public static readonly Vector<T> V6;
        /// <summary>Value 7 .</summary>
        public static readonly Vector<T> V7;
        /// <summary>Value 8 .</summary>
        public static readonly Vector<T> V8;
        /// <summary>Value 127 (sbyte.MaxValue).</summary>
        public static readonly Vector<T> VMaxSByte;
        /// <summary>Value 255 (byte.MaxValue).</summary>
        public static readonly Vector<T> VMaxByte;
        /// <summary>Value 32767 (short.MaxValue) .</summary>
        public static readonly Vector<T> VMaxInt16;
        /// <summary>Value 65535 (ushort.MaxValue) .</summary>
        public static readonly Vector<T> VMaxUInt16;
        /// <summary>Value 2147483647 (int.MaxValue) .</summary>
        public static readonly Vector<T> VMaxInt32;
        /// <summary>Value 4294967295 (uint.MaxValue) .</summary>
        public static readonly Vector<T> VMaxUInt32;
        // -- Negative number --
        /// <summary>Value -1 . When the type is unsigned integer, the value is a signed cast value (当类型为无符号整型时，值为有符号强制转换值). Example: '(byte)(-1)=255' .</summary>
        public static readonly Vector<T> V_1;
        /// <summary>Value -2 .</summary>
        public static readonly Vector<T> V_2;
        /// <summary>Value -3 .</summary>
        public static readonly Vector<T> V_3;
        /// <summary>Value -4 .</summary>
        public static readonly Vector<T> V_4;
        /// <summary>Value -5 .</summary>
        public static readonly Vector<T> V_5;
        /// <summary>Value -6 .</summary>
        public static readonly Vector<T> V_6;
        /// <summary>Value -7 .</summary>
        public static readonly Vector<T> V_7;
        /// <summary>Value -8 .</summary>
        public static readonly Vector<T> V_8;
        /// <summary>Value -128 (sbyte.MinValue).</summary>
        public static readonly Vector<T> VMinSByte;
        /// <summary>Value -32768 (short.MinValue) .</summary>
        public static readonly Vector<T> VMinInt16;
        /// <summary>Value -2147483648 (int.MinValue) .</summary>
        public static readonly Vector<T> VMinInt32;
        // -- Reciprocal number --
        /// <summary>Reciprocal value: 1/127 (sbyte.MaxValue). When the type is an integer, it is a fixed point number using the <see cref="ElementFixedShift"/> convention (当类型为整数时, 是使用 <see cref="ElementFixedShift"/> 约定的定点数).</summary>
        public static readonly Vector<T> VReciprocalMaxSByte;
        /// <summary>Reciprocal value: 1/255 (byte.MaxValue). When the type is an integer, it is a fixed point number using the <see cref="ElementFixedShift"/> convention (当类型为整数时, 是使用 <see cref="ElementFixedShift"/> 约定的定点数).</summary>
        public static readonly Vector<T> VReciprocalMaxByte;
        /// <summary>Reciprocal value: 1/32767 (short.MaxValue). When the type is an integer, it is a fixed point number using the <see cref="ElementFixedShift"/> convention (当类型为整数时, 是使用 <see cref="ElementFixedShift"/> 约定的定点数).</summary>
        public static readonly Vector<T> VReciprocalMaxInt16;
        /// <summary>Reciprocal value: 1/65535 (ushort.MaxValue). When the type is an integer, it is a fixed point number using the <see cref="ElementFixedShift"/> convention (当类型为整数时, 是使用 <see cref="ElementFixedShift"/> 约定的定点数).</summary>
        public static readonly Vector<T> VReciprocalMaxUInt16;
        /// <summary>Reciprocal value: 1/2147483647 (int.MaxValue). When the type is an integer, it is a fixed point number using the <see cref="ElementFixedShift"/> convention (当类型为整数时, 是使用 <see cref="ElementFixedShift"/> 约定的定点数).</summary>
        public static readonly Vector<T> VReciprocalMaxInt32;
        /// <summary>Reciprocal value: 1/4294967295 (uint.MaxValue). When the type is an integer, it is a fixed point number using the <see cref="ElementFixedShift"/> convention (当类型为整数时, 是使用 <see cref="ElementFixedShift"/> 约定的定点数).</summary>
        public static readonly Vector<T> VReciprocalMaxUInt32;
        // -- Specified value --
        /// <summary>The mask of the index (索引的掩码). All the elements have a value of <c>Count-1</c>.</summary>
        public static readonly Vector<T> IndexMask;
        /// <summary>The mask of the index on Each128 (Each128上索引的掩码). All the elements have a value of <c>(16/sizeof(T))-1</c>.</summary>
        public static readonly Vector<T> IndexMaskEach128;
        /// <summary>Serial Value (顺序值). e.g. 0, 1, 2, 3 ...</summary>
        public static readonly Vector<T> Serial;
        /// <summary>Serial Value descend (顺序值降序). e.g. (Count-1), (Count-2), ... 2, 1, 0</summary>
        public static readonly Vector<T> SerialDesc;
        /// <summary>Negative serial Value (负数顺序值). e.g. 0, -1, -2, -3 ...</summary>
        public static readonly Vector<T> SerialNegative;
        /// <summary>Demo Value (演示值). It is a value constructed for testing purposes (它是为测试目的而构造的值).</summary>
        public static readonly Vector<T> Demo;
        /// <summary>NaN Demo Value (NaN演示值). It is a value constructed for testing purposes (它是为测试目的而构造的值).</summary>
        public static readonly Vector<T> DemoNaN;
        /// <summary>NaN Demo Value 2 (NaN演示值2). It is a value constructed for testing purposes (它是为测试目的而构造的值).</summary>
        public static readonly Vector<T> DemoNaN2;
        /// <summary>Serial bit pos mask (顺序位偏移的掩码). The element whose index exceeds the number of bits has a value of 0(索引超过位数的元素值为0). e.g. 1, 2, 4, 8, 0x10 ...</summary>
        public static readonly Vector<T> MaskBitPosSerial;
        /// <summary>Serial bit pos rotate mask (顺序位偏移的旋转掩码). e.g. 1, 2, 4, 8, 0x10 ...</summary>
        public static readonly Vector<T> MaskBitPosSerialRotate;
        /// <summary>Serial bits mask (顺序位集的掩码). The element whose index exceeds the number of bits has a value of all bit set 1(索引超过位数的元素值为所有位都是1的值). e.g. 1, 3, 7, 0xF, 0x1F ...</summary>
        public static readonly Vector<T> MaskBitsSerial;
        /// <summary>Serial bits rotate mask (顺序位集的旋转掩码). e.g. 1, 3, 7, 0xF, 0x1F ...</summary>
        public static readonly Vector<T> MaskBitsSerialRotate;
        /// <summary>Interlaced sign number (交错的符号数值). e.g. 1, -1, 1, -1, 1, -1 ...</summary>
        public static readonly Vector<T> InterlacedSign;
        /// <summary>Interlaced sign number starting with a negative number (负数开头的交错的符号数值). e.g. -1, 1, -1, 1, -1, 1 ...</summary>
        public static readonly Vector<T> InterlacedSignNegative;
        // -- Xy --
        /// <summary>Xy - Address 0 mask. For a 2-element group, select the mask of the address 0th element (对于2个元素的组，选择地址为第0个元素的掩码).</summary>
        public static readonly Vector<T> XyAddress0Mask;
        /// <summary>Xy - Address 0 mask. For a 2-element group, select the mask of the address 1st element (对于2个元素的组，选择地址为第1个元素的掩码).</summary>
        public static readonly Vector<T> XyAddress1Mask;
        /// <summary>Xy - Address 0 is normalized number of value 1 (地址0为 值1的归一化数).</summary>
        public static readonly Vector<T> XyAddress0NormOne;
        /// <summary>Xy - Address 1 is normalized number of value 1 (地址1为 值1的归一化数).</summary>
        public static readonly Vector<T> XyAddress1NormOne;
        /// <summary>Xy - X mask. For a 2-element group, select the mask of the position 0th element (对于2个元素的组，选择位置为第0个元素的掩码).</summary>
        public static readonly Vector<T> XyXMask;
        /// <summary>Xy - Y mask. For a 2-element group, select the mask of the position 1st element (对于2个元素的组，选择位置为第1个元素的掩码).</summary>
        public static readonly Vector<T> XyYMask;
        /// <summary>Xy - X is normalized number of value 1 (X为 值1的归一化数).</summary>
        public static readonly Vector<T> XyXNormOne;
        /// <summary>Xy - Y is normalized number of value 1 (Y为 值1的归一化数).</summary>
        public static readonly Vector<T> XyYNormOne;
        // -- Xyzw --
        /// <summary>Xyzw - Address 0 mask. For a 4-element group, select the mask of the address 0th element (对于4个元素的组，选择地址为第0个元素的掩码).</summary>
        public static readonly Vector<T> XyzwAddress0Mask;
        /// <summary>Xyzw - Address 1 mask. For a 4-element group, select the mask of the address 0th element (对于4个元素的组，选择地址为第1个元素的掩码).</summary>
        public static readonly Vector<T> XyzwAddress1Mask;
        /// <summary>Xyzw - Address 2 mask. For a 4-element group, select the mask of the address 0th element (对于4个元素的组，选择地址为第2个元素的掩码).</summary>
        public static readonly Vector<T> XyzwAddress2Mask;
        /// <summary>Xyzw - Address 3 mask. For a 4-element group, select the mask of the address 0th element (对于4个元素的组，选择地址为第3个元素的掩码).</summary>
        public static readonly Vector<T> XyzwAddress3Mask;
        /// <summary>Xyzw - Address 0 is normalized number of value 1 (地址0为 值1的归一化数).</summary>
        public static readonly Vector<T> XyzwAddress0NormOne;
        /// <summary>Xyzw - Address 1 is normalized number of value 1 (地址1为 值1的归一化数).</summary>
        public static readonly Vector<T> XyzwAddress1NormOne;
        /// <summary>Xyzw - Address 2 is normalized number of value 1 (地址2为 值1的归一化数).</summary>
        public static readonly Vector<T> XyzwAddress2NormOne;
        /// <summary>Xyzw - Address 3 is normalized number of value 1 (地址3为 值1的归一化数).</summary>
        public static readonly Vector<T> XyzwAddress3NormOne;
        /// <summary>Xyzw - X mask. For a 4-element group, select the mask of the position 0th element (对于4个元素的组，选择位置为第0个元素的掩码). Alias has <see cref="RgbaRMask"/>.</summary>
        public static readonly Vector<T> XyzwXMask;
        /// <summary>Xyzw - Y mask. For a 4-element group, select the mask of the position 1th element (对于4个元素的组，选择位置为第1个元素的掩码). Alias has <see cref="RgbaGMask"/>.</summary>
        public static readonly Vector<T> XyzwYMask;
        /// <summary>Xyzw - Z mask. For a 4-element group, select the mask of the position 2th element (对于4个元素的组，选择位置为第2个元素的掩码). Alias has <see cref="RgbaBMask"/>.</summary>
        public static readonly Vector<T> XyzwZMask;
        /// <summary>Xyzw - W mask. For a 4-element group, select the mask of the position 3th element (对于4个元素的组，选择位置为第3个元素的掩码). Alias has <see cref="RgbaAMask"/>.</summary>
        public static readonly Vector<T> XyzwWMask;
        /// <summary>Xyzw - X is normalized number of value 1 (X为 值1的归一化数).</summary>
        public static readonly Vector<T> XyzwXNormOne;
        /// <summary>Xyzw - Y is normalized number of value 1 (Y为 值1的归一化数).</summary>
        public static readonly Vector<T> XyzwYNormOne;
        /// <summary>Xyzw - Z is normalized number of value 1 (Z为 值1的归一化数).</summary>
        public static readonly Vector<T> XyzwZNormOne;
        /// <summary>Xyzw - W is normalized number of value 1 (W为 值1的归一化数).</summary>
        public static readonly Vector<T> XyzwWNormOne;
        // == Mask array ==
        /// <summary>Bit pos mask array (位偏移掩码的数组). e.g. 1, 2, 4, 8, 0x10 ...</summary>
        private static readonly Vector<byte>[] MaskBitPosArray;
        /// <summary>Bits mask array (位集掩码的数组). e.g. 0, 1, 3, 7, 0xF, 0x1F ...</summary>
        private static readonly Vector<byte>[] MaskBitsArray;

        /// <summary>
        /// Static constructor.
        /// </summary>
        static Vectors() {
            // -- Number struct --
            SignMask = Vectors.Create<T>(ElementSignMask);
            ExponentMask = Vectors.Create<T>(ElementExponentMask);
            MantissaMask = Vectors.Create<T>(ElementMantissaMask);
            NonSignMask = Vectors.Create<T>(ElementNonSignMask);
            NonExponentMask = Vectors.Create<T>(ElementNonExponentMask);
            NonMantissaMask = Vectors.Create<T>(ElementNonMantissaMask);
            Epsilon = Vectors.Create<T>(ElementEpsilon);
            MaxValue = Vectors.Create<T>(ElementMaxValue);
            MinValue = Vectors.Create<T>(ElementMinValue);
            NaN = Vectors.Create<T>(ElementNaN);
            NegativeInfinity = Vectors.Create<T>(ElementNegativeInfinity);
            PositiveInfinity = Vectors.Create<T>(ElementPositiveInfinity);
            // -- Math --
            NormOne = Vectors.Create<T>(ElementNormOne);
            FixedOne = Vectors.Create<T>(ElementFixedOne);
            E = Vectors.Create<T>(ElementE);
            Pi = Vectors.Create<T>(ElementPi);
            Tau = Vectors.Create<T>(ElementTau);
            // -- Positive number --
            V1 = Vectors.Create<T>(ElementV1);
            V2 = Vectors.Create<T>(ElementV2);
            V3 = Vectors.Create<T>(ElementV3);
            V4 = Vectors.Create<T>(ElementV4);
            V5 = Vectors.Create<T>(ElementV5);
            V6 = Vectors.Create<T>(ElementV6);
            V7 = Vectors.Create<T>(ElementV7);
            V8 = Vectors.Create<T>(ElementV8);
            VMaxSByte = Vectors.Create<T>(ElementVMaxSByte);
            VMaxByte = Vectors.Create<T>(ElementVMaxByte);
            VMaxInt16 = Vectors.Create<T>(ElementVMaxInt16);
            VMaxUInt16 = Vectors.Create<T>(ElementVMaxUInt16);
            VMaxInt32 = Vectors.Create<T>(ElementVMaxInt32);
            VMaxUInt32 = Vectors.Create<T>(ElementVMaxUInt32);
            // -- Negative number  --
            V_1 = Vectors.Create<T>(ElementV_1);
            V_2 = Vectors.Create<T>(ElementV_2);
            V_3 = Vectors.Create<T>(ElementV_3);
            V_4 = Vectors.Create<T>(ElementV_4);
            V_5 = Vectors.Create<T>(ElementV_5);
            V_6 = Vectors.Create<T>(ElementV_6);
            V_7 = Vectors.Create<T>(ElementV_7);
            V_8 = Vectors.Create<T>(ElementV_8);
            VMinSByte = Vectors.Create<T>(ElementVMinSByte);
            VMinInt16 = Vectors.Create<T>(ElementVMinInt16);
            VMinInt32 = Vectors.Create<T>(ElementVMinInt32);
            // -- Reciprocal number  --
            VReciprocalMaxSByte = Vectors.Create<T>(ElementVReciprocalMaxSByte);
            VReciprocalMaxByte = Vectors.Create<T>(ElementVReciprocalMaxByte);
            VReciprocalMaxInt16 = Vectors.Create<T>(ElementVReciprocalMaxInt16);
            VReciprocalMaxUInt16 = Vectors.Create<T>(ElementVReciprocalMaxUInt16);
            VReciprocalMaxInt32 = Vectors.Create<T>(ElementVReciprocalMaxInt32);
            VReciprocalMaxUInt32 = Vectors.Create<T>(ElementVReciprocalMaxUInt32);
            // -- Specified value --
            IndexMask = Vectors.CreateByBits<T>(Vector<T>.Count - 1);
            IndexMaskEach128 = Vectors.CreateByBits<T>((16 / Scalars<T>.ByteSize) - 1);
            Serial = Vectors.CreateByDoubleLoop<T>(0, 1);
            SerialDesc = Vectors.CreateByDoubleLoop<T>(Vector<T>.Count - 1, -1);
            SerialNegative = Vectors.CreateByDoubleLoop<T>(0, -1);
            Demo = Vectors.CreateByFunc<T>(Vectors.GenerateDemoElement<T>);
            DemoNaN = Vectors.CreateRotate<T>(ElementNaN, ElementNegativeInfinity, ElementSignMask, ElementPositiveInfinity, ElementMaxValue, ElementMinValue, ElementV6, ElementV7);
            DemoNaN2 = Vectors.CreateRotate<T>(ElementPositiveInfinity, ElementNaN, ElementNegativeInfinity, ElementSignMask, ElementV_4, ElementMaxValue, ElementMinValue, ElementV_7);
            int bitLen = ElementByteSize * 8;
            MaskBitPosSerial = Vectors.CreateByFunc<T>(delegate (int index) {
                long n = 0;
                if (index < bitLen) {
                    n = 1L << index;
                }
                return Scalars.GetByBits<T>(n);
            });
            MaskBitPosSerialRotate = Vectors.CreateByFunc<T>(delegate (int index) {
                int m = index % bitLen;
                long n = 1L << m;
                return Scalars.GetByBits<T>(n);
            });
            MaskBitsSerial = Vectors.CreateByFunc<T>(delegate (int index) {
                int m = Math.Min(index + 1, bitLen);
                return Scalars.GetBitsMask<T>(0, m);
            });
            MaskBitsSerialRotate = Vectors.CreateByFunc<T>(delegate (int index) {
                int m = index % bitLen + 1;
                return Scalars.GetBitsMask<T>(0, m);
            });
            InterlacedSign = Vectors.CreateRotate<T>(ElementV1, ElementV_1);
            InterlacedSignNegative = Vectors.CreateRotate<T>(ElementV_1, ElementV1);
            // -- Xyzw --
            if (true) {
                T o = ElementZero;
                T f = ElementAllBitsSet;
                T n = ElementNormOne;
                XyAddress0Mask = Vectors.CreateRotate<T>(f, o);
                XyAddress1Mask = Vectors.CreateRotate<T>(o, f);
                XyAddress0NormOne = Vectors.CreateRotate<T>(n, o);
                XyAddress1NormOne = Vectors.CreateRotate<T>(o, n);
                XyzwAddress0Mask = Vectors.CreateRotate<T>(f, o, o, o);
                XyzwAddress1Mask = Vectors.CreateRotate<T>(o, f, o, o);
                XyzwAddress2Mask = Vectors.CreateRotate<T>(o, o, f, o);
                XyzwAddress3Mask = Vectors.CreateRotate<T>(o, o, o, f);
                XyzwAddress0NormOne = Vectors.CreateRotate<T>(n, o, o, o);
                XyzwAddress1NormOne = Vectors.CreateRotate<T>(o, n, o, o);
                XyzwAddress2NormOne = Vectors.CreateRotate<T>(o, o, n, o);
                XyzwAddress3NormOne = Vectors.CreateRotate<T>(o, o, o, n);
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
            MaskBitPosArray = Vectors.GetMaskBitPosArray(ElementByteSize);
            MaskBitsArray = Vectors.GetMaskBitsArray(ElementByteSize);
        }

        /// <summary>
        /// Get bit pos mask by index (根据索引获取位偏移掩码). The equivalent of <c>Vectors.Create(Scalars.GetByBits&lt;T&gt;(1L &lt;&lt; index))</c>.
        /// </summary>
        /// <param name="index">The index (索引). The value ranges from 0 to <c>ElementBitSize-1</c> (值的范围是 0 ~ <c>ElementBitSize-1</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bit pos mask (返回位偏移掩码).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<T> GetMaskBitPos(int index) {
            return Unsafe.As<Vector<byte>, Vector<T>>(ref MaskBitPosArray[index]);
        }

        /// <summary>
        /// Get bit pos mask span (获取位偏移掩码的跨度). Tip: You can use <see cref="Unsafe.As"/> convert its item to <see cref="Vector{T}"/> type (提示: 可以用 <see cref="Unsafe.As"/> 将其中条目转为 <see cref="Vector{T}"/> 类型).
        /// </summary>
        /// <returns>Returns bit pos mask span (返回位偏移掩码的跨度).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlySpan<Vector<byte>> GetMaskBitPosSpan() {
            return new ReadOnlySpan<Vector<byte>>(MaskBitPosArray);
        }

        /// <summary>
        /// Get bits mask by index (根据索引获取位集掩码). The equivalent of <c>Vectors.Create(Scalars.GetBitsMask&lt;T&gt;(0, index))</c>.
        /// </summary>
        /// <param name="index">The index (索引). The value ranges from 0 to <c>ElementBitSize</c> (值的范围是 0 ~ <c>ElementBitSize</c>). 为了性能, 本函数不做范围检查, 调用者请确保它的值在范围内 (For performance purposes, this function does not do range checking; the caller should ensure that its value is within the range).</param>
        /// <returns>Returns bits mask mask (返回位集掩码).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<T> GetMaskBits(int index) {
            return Unsafe.As<Vector<byte>, Vector<T>>(ref MaskBitsArray[index]);
        }

        /// <summary>
        /// Get bits mask span (获取位集掩码的跨度). Tip: You can use <see cref="Unsafe.As"/> convert its item to <see cref="Vector{T}"/> type (提示: 可以用 <see cref="Unsafe.As"/> 将其中条目转为 <see cref="Vector{T}"/> 类型).
        /// </summary>
        /// <returns>Returns bits mask span (返回位集掩码的跨度).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlySpan<Vector<byte>> GetMaskBitsSpan() {
            return new ReadOnlySpan<Vector<byte>>(MaskBitsArray);
        }


        /// <summary>Zero (0).</summary>
        public static Vector<T> Zero { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Vector<T>.Zero; } }
        /// <summary>Value 0 (0的值).</summary>
        public static Vector<T> V0 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return Vector<T>.Zero; } }
        /// <summary>All bit is 1 (所有位都是1的值).</summary>
        public static Vector<T> AllBitsSet {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if NET8_0_OR_GREATER
            get => Vector.AllBitsSet;
        }
#else
            get;
        } = Vectors.Create<T>(ElementAllBitsSet);
#endif // NET8_0_OR_GREATER

        /// <summary>1 bits mask (1位掩码).</summary>
        public static Vector<T> MaskBits1 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return GetMaskBits(1); } }
        /// <summary>2 bits mask (2位掩码).</summary>
        public static Vector<T> MaskBits2 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return GetMaskBits(2); } }
        /// <summary>4 bits mask (4位掩码).</summary>
        public static Vector<T> MaskBits4 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return GetMaskBits(4); } }
        /// <summary>8 bits mask (8位掩码).</summary>
        public static Vector<T> MaskBits8 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return GetMaskBits(8); } }
        /// <summary>16 bits mask (16位掩码).</summary>
        public static Vector<T> MaskBits16 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return GetMaskBits(Math.Min(ElementBitSize, 16)); } }
        /// <summary>32 bits mask (32位掩码).</summary>
        public static Vector<T> MaskBits32 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { return GetMaskBits(Math.Min(ElementBitSize, 32)); } }

    }
}
