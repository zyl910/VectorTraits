using System;
using System.Collections.Generic;
using System.Text;
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits {
    /// <summary>
    /// Constants of scalar (标量的常数).
    /// </summary>
    /// <typeparam name="T">Target type (目标类型).</typeparam>
    public static class Scalars<T> where T : struct {
        /// <summary>Value 0 (0的值).</summary>
        public static readonly T V0;
        /// <summary>All bit is 1 (所有位都是1的值).</summary>
        public static readonly T AllBitsSet;
        // -- Number struct --
        /// <summary>byte size (字节大小).</summary>
        public static readonly int ByteSize;
        /// <summary>Bit size (位大小).</summary>
        public static readonly int BitSize;
        /// <summary>Bit size mask (位大小掩码).</summary>
        public static readonly int BitSizeMask;
        /// <summary>Exponent bias (指数偏移值). When the type is an integer, the value is 0.</summary>
        public static readonly int ExponentBias;
        /// <summary>Sign bit size (符号位数). When the type is an unsigned number, the value is 0.</summary>
        public static readonly int SignBits;
        /// <summary>Exponent bit size (指数位数). When the type is an integer, the value is 0.</summary>
        public static readonly int ExponentBits;
        /// <summary>Mantissa bit size (尾数位数).</summary>
        public static readonly int MantissaBits;
        /// <summary>Sign shift bit (符号位移).</summary>
        public static readonly int SignShift;
        /// <summary>Exponent shift bit (指数位移).</summary>
        public static readonly int ExponentShift;
        /// <summary>Mantissa shift bit (尾数位移).</summary>
        public static readonly int MantissaShift;
        /// <summary>Sign mask (符号掩码).</summary>
        public static readonly T SignMask;
        /// <summary>Exponent mask (指数掩码).</summary>
        public static readonly T ExponentMask;
        /// <summary>Mantissa mask (尾数掩码).</summary>
        public static readonly T MantissaMask;
        /// <summary>Non-sign mask (非符号掩码).</summary>
        public static readonly T NonSignMask;
        /// <summary>Non-exponent mask (非指数掩码).</summary>
        public static readonly T NonExponentMask;
        /// <summary>Non-mantissa mask (非尾数掩码).</summary>
        public static readonly T NonMantissaMask;
        /// <summary>Represents the smallest positive value that is greater than zero (表示大于零的最小正值). When the type is an integer, the value is 1 (当类型为整数时，该值为1).</summary>
        public static readonly T Epsilon;
        /// <summary>Represents the largest possible value (表示最大可能值).</summary>
        public static readonly T MaxValue;
        /// <summary>Represents the smallest possible value (表示最小可能值).</summary>
        public static readonly T MinValue;
        /// <summary>Represents not a number (NaN) (表示“非数(NaN)”的值). When the type is an integer, the value is 0 (当类型为整数时，该值为0).</summary>
        public static readonly T NaN;
        /// <summary>Represents the number negative zero (-0) (表示“负零(-0)”的值). When the type is an integer, the value is 0 (当类型为整数时，该值为0).</summary>
        public static readonly T NegativeZero;
        /// <summary>Represents negative infinity (表示负无穷). When the type is an integer, the value is 0 (当类型为整数时，该值为0).</summary>
        public static readonly T NegativeInfinity;
        /// <summary>Represents positive infinity (表示正无穷). When the type is an integer, the value is 0 (当类型为整数时，该值为0).</summary>
        public static readonly T PositiveInfinity;
        // -- Math --
        /// <summary>Normalized number of value 1 (值1的归一化数). When the type is an integer, the value is'<see cref="MaxValue"/>'; Otherwise it's 1 (当类型为整数时，它的值为 `<see cref="MaxValue"/>`; 其他情况下为 1).</summary>
        public static readonly T NormOne;
        /// <summary>Binary shift of fixed point number (定点数的位移). When the type is an integer, the value is' <see cref="BitSize"/>/2 '; Otherwise it's 0 (当类型为整数时，它的值为 `<see cref="BitSize"/>/2`; 其他情况下为 0).</summary>
        public static readonly int FixedShift;
        /// <summary>The fixed point number of the value 1 (值1的定点数). When the type is an integer, the value is'Pow(2, <see cref="FixedShift"/>)'; Otherwise it's 1 (当类型为整数时，它的值为 `Pow(2, <see cref="FixedShift"/>)`; 其他情况下为 1).</summary>
        public static readonly T FixedOne;
        /// <summary>The double of the fixed point number with the value 1 (值1的定点数的双精度浮点值). When the type is an integer, the value is'Pow(2, <see cref="FixedShift"/>)'; Otherwise it's 1 (当类型为整数时，它的值为 `Pow(2, <see cref="FixedShift"/>)`; 其他情况下为 1).</summary>
        public static readonly double FixedOneDouble;
        /// <summary>Represents the natural logarithmic base, specified by the constant, e (表示自然对数的底，它由常数 e 指定). When the type is an integer, it is a fixed point number using the <see cref="FixedShift"/> convention (当类型为整数时, 是使用 <see cref="FixedShift"/> 约定的定点数).</summary>
        public static readonly T E;
        /// <summary>Represents the ratio of the circumference of a circle to its diameter, specified by the constant, π (表示圆的周长与其直径的比值，由常数 π 指定). When the type is an integer, it is a fixed point number using the <see cref="FixedShift"/> convention (当类型为整数时, 是使用 <see cref="FixedShift"/> 约定的定点数).</summary>
        public static readonly T Pi;
        /// <summary>Represents the number of radians in one turn, specified by the constant, τ (表示转一圈的弧度数，由常量 τ 指定). When the type is an integer, it is a fixed point number using the <see cref="FixedShift"/> convention (当类型为整数时, 是使用 <see cref="FixedShift"/> 约定的定点数).</summary>
        public static readonly T Tau;
        // -- Mask --
        /// <summary>1 bits mask (1位掩码).</summary>
        public static readonly T MaskBits1;
        /// <summary>2 bits mask (2位掩码).</summary>
        public static readonly T MaskBits2;
        /// <summary>4 bits mask (4位掩码).</summary>
        public static readonly T MaskBits4;
        /// <summary>8 bits mask (8位掩码).</summary>
        public static readonly T MaskBits8;
        /// <summary>16 bits mask (16位掩码).</summary>
        public static readonly T MaskBits16;
        /// <summary>32 bits mask (32位掩码).</summary>
        public static readonly T MaskBits32;
        // -- Positive number --
        /// <summary>Value 1 .</summary>
        public static readonly T V1;
        /// <summary>Value 2 .</summary>
        public static readonly T V2;
        /// <summary>Value 3 .</summary>
        public static readonly T V3;
        /// <summary>Value 4 .</summary>
        public static readonly T V4;
        /// <summary>Value 5 .</summary>
        public static readonly T V5;
        /// <summary>Value 6 .</summary>
        public static readonly T V6;
        /// <summary>Value 7 .</summary>
        public static readonly T V7;
        /// <summary>Value 8 .</summary>
        public static readonly T V8;
        /// <summary>Value 127 (sbyte.MaxValue).</summary>
        public static readonly T VMaxSByte;
        /// <summary>Value 255 (byte.MaxValue).</summary>
        public static readonly T VMaxByte;
        /// <summary>Value 32767 (short.MaxValue) .</summary>
        public static readonly T VMaxInt16;
        /// <summary>Value 65535 (ushort.MaxValue) .</summary>
        public static readonly T VMaxUInt16;
        /// <summary>Value 2147483647 (int.MaxValue) .</summary>
        public static readonly T VMaxInt32;
        /// <summary>Value 4294967295 (uint.MaxValue) .</summary>
        public static readonly T VMaxUInt32;
        // -- Negative number --
        /// <summary>Value -1 . When the type is unsigned integer, the value is a signed cast value (当类型为无符号整型时，值为有符号强制转换值). Example: '(byte)(-1)=255' .</summary>
        public static readonly T V_1;
        /// <summary>Value -2 .</summary>
        public static readonly T V_2;
        /// <summary>Value -3 .</summary>
        public static readonly T V_3;
        /// <summary>Value -4 .</summary>
        public static readonly T V_4;
        /// <summary>Value -5 .</summary>
        public static readonly T V_5;
        /// <summary>Value -6 .</summary>
        public static readonly T V_6;
        /// <summary>Value -7 .</summary>
        public static readonly T V_7;
        /// <summary>Value -8 .</summary>
        public static readonly T V_8;
        /// <summary>Value -128 (sbyte.MinValue).</summary>
        public static readonly T VMinSByte;
        /// <summary>Value -32768 (short.MinValue) .</summary>
        public static readonly T VMinInt16;
        /// <summary>Value -2147483648 (int.MinValue) .</summary>
        public static readonly T VMinInt32;
        // -- Reciprocal number --
        /// <summary>Reciprocal value: 1/127 (sbyte.MaxValue). When the type is an integer, it is a fixed point number using the <see cref="FixedShift"/> convention (当类型为整数时, 是使用 <see cref="FixedShift"/> 约定的定点数).</summary>
        public static readonly T VReciprocalMaxSByte;
        /// <summary>Reciprocal value: 1/255 (byte.MaxValue). When the type is an integer, it is a fixed point number using the <see cref="FixedShift"/> convention (当类型为整数时, 是使用 <see cref="FixedShift"/> 约定的定点数).</summary>
        public static readonly T VReciprocalMaxByte;
        /// <summary>Reciprocal value: 1/32767 (short.MaxValue). When the type is an integer, it is a fixed point number using the <see cref="FixedShift"/> convention (当类型为整数时, 是使用 <see cref="FixedShift"/> 约定的定点数).</summary>
        public static readonly T VReciprocalMaxInt16;
        /// <summary>Reciprocal value: 1/65535 (ushort.MaxValue). When the type is an integer, it is a fixed point number using the <see cref="FixedShift"/> convention (当类型为整数时, 是使用 <see cref="FixedShift"/> 约定的定点数).</summary>
        public static readonly T VReciprocalMaxUInt16;
        /// <summary>Reciprocal value: 1/2147483647 (int.MaxValue). When the type is an integer, it is a fixed point number using the <see cref="FixedShift"/> convention (当类型为整数时, 是使用 <see cref="FixedShift"/> 约定的定点数).</summary>
        public static readonly T VReciprocalMaxInt32;
        /// <summary>Reciprocal value: 1/4294967295 (uint.MaxValue). When the type is an integer, it is a fixed point number using the <see cref="FixedShift"/> convention (当类型为整数时, 是使用 <see cref="FixedShift"/> 约定的定点数).</summary>
        public static readonly T VReciprocalMaxUInt32;

        /// <summary>
        /// Static constructor.
        /// </summary>
        static Scalars() {
#pragma warning disable CS0618 // Type or member is obsolete
            V0 = default;
            AllBitsSet = Scalars.OnesComplement(V0);
            NegativeZero = default;
            // -- Number struct --
            unchecked {
                if (typeof(T) == typeof(float)) {
                    ByteSize = sizeof(float);
                    ExponentBias = 127;
                    SignBits = 1;
                    ExponentBits = 8;
                    MantissaBits = 23;
                    SignMask = (T)(object)BitMath.Int32BitsToSingle(ScalarConstants.Single_SignMask);
                    ExponentMask = (T)(object)BitMath.Int32BitsToSingle(ScalarConstants.Single_ExponentMask);
                    MantissaMask = (T)(object)BitMath.Int32BitsToSingle(ScalarConstants.Single_MantissaMask);
                    NonSignMask = (T)(object)BitMath.Int32BitsToSingle(ScalarConstants.Single_NonSignMask);
                    NonExponentMask = (T)(object)BitMath.Int32BitsToSingle(ScalarConstants.Single_NonExponentMask);
                    NonMantissaMask = (T)(object)BitMath.Int32BitsToSingle(ScalarConstants.Single_NonMantissaMask);
                    Epsilon = (T)(object)float.Epsilon;
                    MaxValue = (T)(object)float.MaxValue;
                    MinValue = (T)(object)float.MinValue;
                    NaN = (T)(object)float.NaN;
                    NegativeInfinity = (T)(object)float.NegativeInfinity;
                    PositiveInfinity = (T)(object)float.PositiveInfinity;
                    NegativeZero = SignMask;
                } else if (typeof(T) == typeof(double)) {
                    ByteSize = sizeof(double);
                    ExponentBias = 1023;
                    SignBits = 1;
                    ExponentBits = 11;
                    MantissaBits = 52;
                    SignMask = (T)(object)BitMath.Int64BitsToDouble(ScalarConstants.Double_SignMask);
                    ExponentMask = (T)(object)BitMath.Int64BitsToDouble(ScalarConstants.Double_ExponentMask);
                    MantissaMask = (T)(object)BitMath.Int64BitsToDouble(ScalarConstants.Double_MantissaMask);
                    NonSignMask = (T)(object)BitMath.Int64BitsToDouble(ScalarConstants.Double_NonSignMask);
                    NonExponentMask = (T)(object)BitMath.Int64BitsToDouble(ScalarConstants.Double_NonExponentMask);
                    NonMantissaMask = (T)(object)BitMath.Int64BitsToDouble(ScalarConstants.Double_NonMantissaMask);
                    Epsilon = (T)(object)double.Epsilon;
                    MaxValue = (T)(object)double.MaxValue;
                    MinValue = (T)(object)double.MinValue;
                    NaN = (T)(object)double.NaN;
                    NegativeInfinity = (T)(object)double.NegativeInfinity;
                    PositiveInfinity = (T)(object)double.PositiveInfinity;
                    NegativeZero = SignMask;
                } else if (typeof(T) == typeof(sbyte)) {
                    ByteSize = sizeof(sbyte);
                    ExponentBias = 0;
                    SignBits = 1;
                    ExponentBits = 0;
                    MantissaBits = 7;
                    SignMask = (T)(object)(sbyte)(0x80);
                    ExponentMask = (T)(object)(sbyte)(0);
                    MantissaMask = (T)(object)(sbyte)(0x7F);
                    NonSignMask = (T)(object)(sbyte)(~0x80);
                    NonExponentMask = (T)(object)(sbyte)(~0);
                    NonMantissaMask = (T)(object)(sbyte)(~0x7F);
                    Epsilon = Scalars.GetByDouble<T>(1);
                    MaxValue = (T)(object)sbyte.MaxValue;
                    MinValue = (T)(object)sbyte.MinValue;
                    NaN = V0;
                    NegativeInfinity = V0;
                    PositiveInfinity = V0;
                } else if (typeof(T) == typeof(short)) {
                    ByteSize = sizeof(short);
                    ExponentBias = 0;
                    SignBits = 1;
                    ExponentBits = 0;
                    MantissaBits = 15;
                    SignMask = (T)(object)(short)(0x8000);
                    ExponentMask = (T)(object)(short)(0);
                    MantissaMask = (T)(object)(short)(0x7FFF);
                    NonSignMask = (T)(object)(short)(~0x8000);
                    NonExponentMask = (T)(object)(short)(~0);
                    NonMantissaMask = (T)(object)(short)(~0x7FFF);
                    Epsilon = Scalars.GetByDouble<T>(1);
                    MaxValue = (T)(object)short.MaxValue;
                    MinValue = (T)(object)short.MinValue;
                    NaN = V0;
                    NegativeInfinity = V0;
                    PositiveInfinity = V0;
                } else if (typeof(T) == typeof(int)) {
                    ByteSize = sizeof(int);
                    ExponentBias = 0;
                    SignBits = 1;
                    ExponentBits = 0;
                    MantissaBits = 31;
                    SignMask = (T)(object)(int)(0x80000000);
                    ExponentMask = (T)(object)(int)(0);
                    MantissaMask = (T)(object)(int)(0x7FFFFFFF);
                    NonSignMask = (T)(object)(int)(~0x80000000);
                    NonExponentMask = (T)(object)(int)(~0);
                    NonMantissaMask = (T)(object)(int)(~0x7FFFFFFF);
                    Epsilon = Scalars.GetByDouble<T>(1);
                    MaxValue = (T)(object)int.MaxValue;
                    MinValue = (T)(object)int.MinValue;
                    NaN = V0;
                    NegativeInfinity = V0;
                    PositiveInfinity = V0;
                } else if (typeof(T) == typeof(long)) {
                    ByteSize = sizeof(long);
                    ExponentBias = 0;
                    SignBits = 1;
                    ExponentBits = 0;
                    MantissaBits = 63;
                    SignMask = (T)(object)(long)(0x8000000000000000L);
                    ExponentMask = (T)(object)(long)(0);
                    MantissaMask = (T)(object)(long)(0x7FFFFFFFFFFFFFFF);
                    NonSignMask = (T)(object)(long)(~0x8000000000000000L);
                    NonExponentMask = (T)(object)(long)(~0);
                    NonMantissaMask = (T)(object)(long)(~0x7FFFFFFFFFFFFFFF);
                    Epsilon = Scalars.GetByDouble<T>(1);
                    MaxValue = (T)(object)long.MaxValue;
                    MinValue = (T)(object)long.MinValue;
                    NaN = V0;
                    NegativeInfinity = V0;
                    PositiveInfinity = V0;
                } else if (typeof(T) == typeof(byte)) {
                    ByteSize = sizeof(byte);
                    ExponentBias = 0;
                    SignBits = 0;
                    ExponentBits = 0;
                    MantissaBits = 8;
                    SignMask = (T)(object)(byte)(0);
                    ExponentMask = (T)(object)(byte)(0);
                    MantissaMask = (T)(object)(byte)(0xFF);
                    NonSignMask = (T)(object)(byte)(~0);
                    NonExponentMask = (T)(object)(byte)(~0);
                    NonMantissaMask = (T)(object)(byte)(~0xFF);
                    Epsilon = Scalars.GetByDouble<T>(1);
                    MaxValue = (T)(object)byte.MaxValue;
                    MinValue = (T)(object)byte.MinValue;
                    NaN = V0;
                    NegativeInfinity = V0;
                    PositiveInfinity = V0;
                } else if (typeof(T) == typeof(ushort)) {
                    ByteSize = sizeof(ushort);
                    ExponentBias = 0;
                    SignBits = 0;
                    ExponentBits = 0;
                    MantissaBits = 16;
                    SignMask = (T)(object)(ushort)(0);
                    ExponentMask = (T)(object)(ushort)(0);
                    MantissaMask = (T)(object)(ushort)(0xFFFF);
                    NonSignMask = (T)(object)(ushort)(~0);
                    NonExponentMask = (T)(object)(ushort)(~0);
                    NonMantissaMask = (T)(object)(ushort)(~0xFFFF);
                    Epsilon = Scalars.GetByDouble<T>(1);
                    MaxValue = (T)(object)ushort.MaxValue;
                    MinValue = (T)(object)ushort.MinValue;
                    NaN = V0;
                    NegativeInfinity = V0;
                    PositiveInfinity = V0;
                } else if (typeof(T) == typeof(uint)) {
                    ByteSize = sizeof(uint);
                    ExponentBias = 0;
                    SignBits = 0;
                    ExponentBits = 0;
                    MantissaBits = 32;
                    SignMask = (T)(object)(uint)(0);
                    ExponentMask = (T)(object)(uint)(0);
                    MantissaMask = (T)(object)(uint)(0xFFFFFFFF);
                    NonSignMask = (T)(object)(uint)(~0);
                    NonExponentMask = (T)(object)(uint)(~0);
                    NonMantissaMask = (T)(object)(uint)(~0xFFFFFFFF);
                    Epsilon = Scalars.GetByDouble<T>(1);
                    MaxValue = (T)(object)uint.MaxValue;
                    MinValue = (T)(object)uint.MinValue;
                    NaN = V0;
                    NegativeInfinity = V0;
                    PositiveInfinity = V0;
                } else if (typeof(T) == typeof(ulong)) {
                    ByteSize = sizeof(ulong);
                    ExponentBias = 0;
                    SignBits = 0;
                    ExponentBits = 0;
                    MantissaBits = 64;
                    SignMask = (T)(object)(ulong)(0);
                    ExponentMask = (T)(object)(ulong)(0);
                    MantissaMask = (T)(object)(ulong)(0xFFFFFFFFFFFFFFFFL);
                    NonSignMask = (T)(object)(ulong)(~0L);
                    NonExponentMask = (T)(object)(ulong)(~0L);
                    NonMantissaMask = (T)(object)(ulong)(~0xFFFFFFFFFFFFFFFFL);
                    Epsilon = Scalars.GetByDouble<T>(1);
                    MaxValue = (T)(object)ulong.MaxValue;
                    MinValue = (T)(object)ulong.MinValue;
                    NaN = V0;
                    NegativeInfinity = V0;
                    PositiveInfinity = V0;
                } else if (typeof(T) == typeof(IntPtr)) {
                    ByteSize = IntPtr.Size;
                    ExponentBias = 0;
                    if (sizeof(int) == ByteSize) {
                        SignBits = 1;
                        ExponentBits = 0;
                        MantissaBits = 31;
                        SignMask = (T)(object)(IntPtr)(int)(0x80000000);
                        ExponentMask = (T)(object)(IntPtr)(int)(0);
                        MantissaMask = (T)(object)(IntPtr)(int)(0x7FFFFFFF);
                        NonSignMask = (T)(object)(IntPtr)(int)(~0x80000000);
                        NonExponentMask = (T)(object)(IntPtr)(int)(~0);
                        NonMantissaMask = (T)(object)(IntPtr)(int)(~0x7FFFFFFF);
                        MaxValue = (T)(object)(IntPtr)int.MaxValue;
                        MinValue = (T)(object)(IntPtr)int.MinValue;
                    } else {
                        SignBits = 1;
                        ExponentBits = 0;
                        MantissaBits = 63;
                        SignMask = (T)(object)(IntPtr)(long)(0x8000000000000000L);
                        ExponentMask = (T)(object)(IntPtr)(long)(0);
                        MantissaMask = (T)(object)(IntPtr)(long)(0x7FFFFFFFFFFFFFFF);
                        NonSignMask = (T)(object)(IntPtr)(long)(~0x8000000000000000L);
                        NonExponentMask = (T)(object)(IntPtr)(long)(~0);
                        NonMantissaMask = (T)(object)(IntPtr)(long)(~0x7FFFFFFFFFFFFFFF);
                        MaxValue = (T)(object)(IntPtr)long.MaxValue;
                        MinValue = (T)(object)(IntPtr)long.MinValue;
                    }
                    Epsilon = Scalars.GetByDouble<T>(1);
                    NaN = V0;
                    NegativeInfinity = V0;
                    PositiveInfinity = V0;
                } else if (typeof(T) == typeof(UIntPtr)) {
                    ByteSize = UIntPtr.Size;
                    ExponentBias = 0;
                    if (sizeof(uint) == ByteSize) {
                        SignBits = 1;
                        ExponentBits = 0;
                        MantissaBits = 31;
                        SignMask = (T)(object)(UIntPtr)(uint)(0);
                        ExponentMask = (T)(object)(UIntPtr)(uint)(0);
                        MantissaMask = (T)(object)(UIntPtr)(uint)(0xFFFFFFFF);
                        NonSignMask = (T)(object)(UIntPtr)(uint)(~0);
                        NonExponentMask = (T)(object)(UIntPtr)(uint)(~0);
                        NonMantissaMask = (T)(object)(UIntPtr)(uint)(~0xFFFFFFFF);
                        MaxValue = (T)(object)(UIntPtr)uint.MaxValue;
                        MinValue = (T)(object)(UIntPtr)uint.MinValue;
                    } else {
                        SignBits = 1;
                        ExponentBits = 0;
                        MantissaBits = 63;
                        SignMask = (T)(object)(UIntPtr)(ulong)(0);
                        ExponentMask = (T)(object)(UIntPtr)(ulong)(0);
                        MantissaMask = (T)(object)(UIntPtr)(ulong)(0xFFFFFFFFFFFFFFFFL);
                        NonSignMask = (T)(object)(UIntPtr)(ulong)(~0);
                        NonExponentMask = (T)(object)(UIntPtr)(ulong)(~0);
                        NonMantissaMask = (T)(object)(UIntPtr)(ulong)(~0xFFFFFFFFFFFFFFFFL);
                        MaxValue = (T)(object)(UIntPtr)ulong.MaxValue;
                        MinValue = (T)(object)(UIntPtr)ulong.MinValue;
                    }
                    Epsilon = Scalars.GetByDouble<T>(1);
                    NaN = V0;
                    NegativeInfinity = V0;
                    PositiveInfinity = V0;
#if NET5_0_OR_GREATER
                } else if (typeof(T) == typeof(Half)) {
                    ByteSize = 2; // sizeof(Half);
                    ExponentBias = 15;
                    SignBits = 1;
                    ExponentBits = 5;
                    MantissaBits = 10;
                    SignMask = (T)(object)BitMath.Int16BitsToHalf(ScalarConstants.Half_SignMask);
                    ExponentMask = (T)(object)BitMath.Int16BitsToHalf(ScalarConstants.Half_ExponentMask);
                    MantissaMask = (T)(object)BitMath.Int16BitsToHalf(ScalarConstants.Half_MantissaMask);
                    NonSignMask = (T)(object)BitMath.Int16BitsToHalf(ScalarConstants.Half_NonSignMask);
                    NonExponentMask = (T)(object)BitMath.Int16BitsToHalf(ScalarConstants.Half_NonExponentMask);
                    NonMantissaMask = (T)(object)BitMath.Int16BitsToHalf(ScalarConstants.Half_NonMantissaMask);
                    Epsilon = (T)(object)Half.Epsilon;
                    MaxValue = (T)(object)Half.MaxValue;
                    MinValue = (T)(object)Half.MinValue;
                    NaN = (T)(object)Half.NaN;
                    NegativeInfinity = (T)(object)Half.NegativeInfinity;
                    PositiveInfinity = (T)(object)Half.PositiveInfinity;
                    NegativeZero = SignMask;
#endif // NET5_0_OR_GREATER
                }
            }
            BitSize = ByteSize * 8;
            BitSizeMask = BitSize - 1;
            MantissaShift = 0;
            ExponentShift = MantissaShift + MantissaBits;
            SignShift = ExponentShift + ExponentBits;
            // -- Math --
            if (ExponentBits > 0) {
                NormOne = Scalars.GetByDouble<T>(1);
                // Float point number.
                FixedShift = 0;
                FixedOneDouble = 1;
            } else {
                NormOne = MaxValue;
                // Fixed point number.
                FixedShift = BitSize / 2;
                FixedOneDouble = Math.Pow(2.0, FixedShift);
            }
            FixedOne = Scalars.GetByDouble<T>(FixedOneDouble);
            E = Scalars.GetFixedByDoubleUseOne<T>(Math.E, FixedOneDouble);
            Pi = Scalars.GetFixedByDoubleUseOne<T>(Math.PI, FixedOneDouble);
            Tau = Scalars.GetFixedByDoubleUseOne<T>(
#if NET5_0_OR_GREATER
                Math.Tau
#else
                Math.PI * 2
#endif // NET5_0_OR_GREATER
                , FixedOneDouble);
            // -- Mask --
            MaskBits1 = Scalars.GetByBits<T>(0x1);
            MaskBits2 = Scalars.GetByBits<T>(0x3);
            MaskBits4 = Scalars.GetByBits<T>(0xF);
            MaskBits8 = Scalars.GetByBits<T>(0xFF);
            MaskBits16 = Scalars.GetByBits<T>(0xFFFF);
            MaskBits32 = Scalars.GetByBits<T>(0xFFFFFFFF);
            // -- Positive number --
            V1 = Scalars.GetByDouble<T>(1);
            V2 = Scalars.GetByDouble<T>(2);
            V3 = Scalars.GetByDouble<T>(3);
            V4 = Scalars.GetByDouble<T>(4);
            V5 = Scalars.GetByDouble<T>(5);
            V6 = Scalars.GetByDouble<T>(6);
            V7 = Scalars.GetByDouble<T>(7);
            V8 = Scalars.GetByDouble<T>(8);
            VMaxSByte = Scalars.GetByDouble<T>(127);
            VMaxByte = Scalars.GetByDouble<T>(255);
            VMaxInt16 = Scalars.GetByDouble<T>(32767);
            VMaxUInt16 = Scalars.GetByDouble<T>(65535);
            VMaxInt32 = Scalars.GetByDouble<T>(2147483647);
            VMaxUInt32 = Scalars.GetByDouble<T>(4294967295);
            // -- Negative number  --
            V_1 = Scalars.GetByDouble<T>(-1);
            V_2 = Scalars.GetByDouble<T>(-2);
            V_3 = Scalars.GetByDouble<T>(-3);
            V_4 = Scalars.GetByDouble<T>(-4);
            V_5 = Scalars.GetByDouble<T>(-5);
            V_6 = Scalars.GetByDouble<T>(-6);
            V_7 = Scalars.GetByDouble<T>(-7);
            V_8 = Scalars.GetByDouble<T>(-8);
            VMinSByte = Scalars.GetByDouble<T>(-128);
            VMinInt16 = Scalars.GetByDouble<T>(-32768);
            VMinInt32 = Scalars.GetByDouble<T>(-2147483648);
            // -- Reciprocal number  --
            VReciprocalMaxSByte = Scalars.GetFixedByDoubleUseOne<T>(1.0 / 127, FixedOneDouble);
            VReciprocalMaxByte = Scalars.GetFixedByDoubleUseOne<T>(1.0 / 255, FixedOneDouble);
            VReciprocalMaxInt16 = Scalars.GetFixedByDoubleUseOne<T>(1.0 / 32767, FixedOneDouble);
            VReciprocalMaxUInt16 = Scalars.GetFixedByDoubleUseOne<T>(1.0 / 65535, FixedOneDouble);
            VReciprocalMaxInt32 = Scalars.GetFixedByDoubleUseOne<T>(1.0 / 2147483647, FixedOneDouble);
            VReciprocalMaxUInt32 = Scalars.GetFixedByDoubleUseOne<T>(1.0 / 4294967295, FixedOneDouble);
#pragma warning restore CS0618 // Type or member is obsolete
        }

    }

}
