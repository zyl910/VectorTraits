using System;
using System.Collections.Generic;
using System.Text;

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// The constants of scalar (标量的常数).
    /// </summary>
    public static class ScalarConstants {

        // ## Number struct ##
        // == Half (s1e5m10, sometimes called FP16 or float16) ==
        /// <summary>Half - Sign bit size (符号位数). Value is `1`.</summary>
        public const int Half_SignBits = 1;
        /// <summary>Half - Exponent bit size (指数位数). Value is `5`.</summary>
        public const int Half_ExponentBits = 5;
        /// <summary>Half - Mantissa bit size (尾数位数). Value is `10`.</summary>
        public const int Half_MantissaBits = 10;
        /// <summary>Half - Sign shift bit (符号位移). Value is `10+5=15`.</summary>
        public const int Half_SignShift = Half_MantissaBits + Half_ExponentBits;
        /// <summary>Half - Exponent shift bit (指数位移). Value is `10`.</summary>
        public const int Half_ExponentShift = Half_MantissaBits;
        /// <summary>Half - Mantissa shift bit (尾数位移). Value is `0`.</summary>
        public const int Half_MantissaShift = 0;
        /// <summary>Half - Exponent bias (指数偏移值). Value is `15`.</summary>
        public const int Half_ExponentBias = 15;
        /// <summary>Half - The minimum value for exponential bias (指数偏移时的最小值). Value is `-14`.</summary>
        public const int Half_ExponentBias_Min = -14;
        /// <summary>Half - The maximum value for exponential bias (指数偏移时的最大值). Value is `15`.</summary>
        public const int Half_ExponentBias_Max = 15;
        /// <summary>Half - Exponent value at infinite or NaN (无穷或非数时的指数值). Value is `31`.</summary>
        public const int Half_ExponentInfinity = 31;
        /// <summary>Half - Sign mask (符号掩码). Value is `0x8000`.</summary>
        public const short Half_SignMask = short.MinValue;
        /// <summary>Half - Exponent mask (指数掩码). Value is `0x7C00`.</summary>
        public const short Half_ExponentMask = 0x7C00;
        /// <summary>Half - Mantissa mask (尾数掩码). Value is `0x03FF`.</summary>
        public const short Half_MantissaMask = 0x03FF;
        /// <summary>Half - Non-sign mask (非符号掩码). Value is `0x7FFF`.</summary>
        public const short Half_NonSignMask = ~Half_SignMask;
        /// <summary>Half - Non-exponent mask (非指数掩码). Value is `0x83FF`.</summary>
        public const short Half_NonExponentMask = ~Half_ExponentMask;
        /// <summary>Half - Non-mantissa mask (非尾数掩码). Value is `0xFC00`.</summary>
        public const short Half_NonMantissaMask = ~Half_MantissaMask;

        // == Single (s1e8m23) ==
        /// <summary>Single - Sign bit size (符号位数). Value is `1`.</summary>
        public const int Single_SignBits = 1;
        /// <summary>Single - Exponent bit size (指数位数). Value is `8`.</summary>
        public const int Single_ExponentBits = 8;
        /// <summary>Single - Mantissa bit size (尾数位数). Value is `23`.</summary>
        public const int Single_MantissaBits = 23;
        /// <summary>Single - Sign shift bit (符号位移). Value is `23+8=31`.</summary>
        public const int Single_SignShift = Single_MantissaBits + Single_ExponentBits;
        /// <summary>Single - Exponent shift bit (指数位移). Value is `23`.</summary>
        public const int Single_ExponentShift = Single_MantissaBits;
        /// <summary>Single - Mantissa shift bit (尾数位移). Value is `0`.</summary>
        public const int Single_MantissaShift = 0;
        /// <summary>Single - Exponent bias (指数偏移值). Value is `127`.</summary>
        public const int Single_ExponentBias = 127;
        /// <summary>Single - The minimum value for exponential bias (指数偏移时的最小值). Value is `-126`.</summary>
        public const int Single_ExponentBias_Min = -126;
        /// <summary>Single - The maximum value for exponential bias (指数偏移时的最大值). Value is `127`.</summary>
        public const int Single_ExponentBias_Max = 127;
        /// <summary>Single - Exponent value at infinite or NaN (无穷或非数时的指数值). Value is `255`.</summary>
        public const int Single_ExponentInfinity = 255;
        /// <summary>Single - Sign mask (符号掩码). Value is `0x80000000`.</summary>
        public const int Single_SignMask = int.MinValue;
        /// <summary>Single - Exponent mask (指数掩码). Value is `0x7F800000`.</summary>
        public const int Single_ExponentMask = 0x7F800000;
        /// <summary>Single - Mantissa mask (尾数掩码). Value is `0x007FFFFF`.</summary>
        public const int Single_MantissaMask = 0x007FFFFF;
        /// <summary>Single - Non-sign mask (非符号掩码). Value is `0x7FFFFFFF`.</summary>
        public const int Single_NonSignMask = ~Single_SignMask;
        /// <summary>Single - Non-exponent mask (非指数掩码). Value is `0x807FFFFF`.</summary>
        public const int Single_NonExponentMask = ~Single_ExponentMask;
        /// <summary>Single - Non-mantissa mask (非尾数掩码). Value is `0xFF800000`.</summary>
        public const int Single_NonMantissaMask = ~Single_MantissaMask;

        // == Double (s1e11m52) ==
        /// <summary>Double - Sign bit size (符号位数). Value is `1`.</summary>
        public const int Double_SignBits = 1;
        /// <summary>Double - Exponent bit size (指数位数). Value is `11`.</summary>
        public const int Double_ExponentBits = 11;
        /// <summary>Double - Mantissa bit size (尾数位数). Value is `52`.</summary>
        public const int Double_MantissaBits = 52;
        /// <summary>Double - Sign shift bit (符号位移). Value is `52+11=63`.</summary>
        public const int Double_SignShift = Double_MantissaBits + Double_ExponentBits;
        /// <summary>Double - Exponent shift bit (指数位移). Value is `52`.</summary>
        public const int Double_ExponentShift = Double_MantissaBits;
        /// <summary>Double - Mantissa shift bit (尾数位移). Value is `0`.</summary>
        public const int Double_MantissaShift = 0;
        /// <summary>Double - Exponent bias (指数偏移值). Value is `1023`.</summary>
        public const int Double_ExponentBias = 1023;
        /// <summary>Double - The minimum value for exponential bias (指数偏移时的最小值). Value is `-1022`.</summary>
        public const int Double_ExponentBias_Min = -1022;
        /// <summary>Double - The maximum value for exponential bias (指数偏移时的最大值). Value is `1023`.</summary>
        public const int Double_ExponentBias_Max = 1023;
        /// <summary>Double - Exponent value at infinite or NaN (无穷或非数时的指数值). Value is `2047`.</summary>
        public const int Double_ExponentInfinity = 2047;
        /// <summary>Double - Sign mask (符号掩码). Value is `0x8000000000000000L`.</summary>
        public const long Double_SignMask = long.MinValue;
        /// <summary>Double - Exponent mask (指数掩码). Value is `0x7FF0000000000000L`.</summary>
        public const long Double_ExponentMask = 0x7FF0000000000000L;
        /// <summary>Double - Mantissa mask (尾数掩码). Value is `0x000FFFFFFFFFFFFFL`.</summary>
        public const long Double_MantissaMask = 0x000FFFFFFFFFFFFFL;
        /// <summary>Double - Non-sign mask (非符号掩码). Value is `0x7FFFFFFFFFFFFFFFL`.</summary>
        public const long Double_NonSignMask = ~Double_SignMask;
        /// <summary>Double - Non-exponent mask (非指数掩码). Value is `0x800FFFFFFFFFFFFFL`.</summary>
        public const long Double_NonExponentMask = ~Double_ExponentMask;
        /// <summary>Double - Non-mantissa mask (非尾数掩码). Value is `0xFFF0000000000000L`.</summary>
        public const long Double_NonMantissaMask = ~Double_MantissaMask;


        // ## Bit of float ##
        // == BitSingle: Bit of Single ==
        /// <summary>BitSingle - `-pow(2, 31) = -2147483648`.</summary>
        public const int BitSingle_Negative2Pow31 = unchecked((int)0xCF000000U); // BitConverter.SingleToInt32Bits((float)-Math.Pow(2, 31)).ToString("X")
        /// <summary>BitSingle - `-pow(2, 32) = -4294967296`.</summary>
        public const int BitSingle_Negative2Pow32 = unchecked((int)0xCF800000U);

        /// <summary>BitSingle - `pow(2, 23) = 8388608`.</summary>
        public const int BitSingle_2Pow23 = 0x4B000000; // BitConverter.SingleToInt32Bits((float)Math.Pow(2, 23)).ToString("X")
        /// <summary>BitSingle - `pow(2, 31) = 2147483648`.</summary>
        public const int BitSingle_2Pow31 = 0x4F000000;
        /// <summary>BitSingle - `pow(2, 32) = 4294967296`.</summary>
        public const int BitSingle_2Pow32 = 0x4F800000;

        // == BitDouble: Bit of Double ==
        /// <summary>BitDouble - `(double)0x0010000000000000 = pow(2, 52) = 4503599627370496`.</summary>
        public const long BitDouble_2Pow52 = 0x43300000_00000000; // BitConverter.DoubleToInt64Bits(Math.Pow(2, 52)).ToString("X")
        /// <summary>BitDouble - `(double)0x0018000000000000 = pow(2, 52) + pow(2, 51) = 1.5*pow(2, 52) = 6755399441055744`.</summary>
        public const long BitDouble_2Pow52_2Pow51 = 0x43380000_00000000L; // BitConverter.DoubleToInt64Bits(1.5*Math.Pow(2, 52)).ToString("X")

    }
}
