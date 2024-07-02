#if NET5_0_OR_GREATER
#define BCL_TYPE_HALF
#endif // NET5_0_OR_GREATER
#if NET7_0_OR_GREATER
#define BCL_TYPE_INT128
#define GENERICS_MATH
#endif // NET7_0_OR_GREATER

using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using Zyl.VectorTraits.Numerics;

namespace Zyl.VectorTraits.ExTypes.Impl {

    // Number.Parsing.cs
    // internal interface IBinaryFloatParseAndFormatInfo<TSelf> : IBinaryFloatingPointIeee754<TSelf>, IMinMaxValue<TSelf>
    //     where TSelf : unmanaged, IBinaryFloatParseAndFormatInfo<TSelf>
    // {
    //     static int NumberBufferLength { get; }
    // 
    //     static ulong ZeroBits { get; }
    //     static ulong InfinityBits { get; }
    // 
    //     static ulong NormalMantissaMask { get; }
    //     static ulong DenormalMantissaMask { get; }
    // 
    //     static int MinBinaryExponent { get; }
    //     static int MaxBinaryExponent { get; }
    // 
    //     static int MinDecimalExponent { get; }
    //     static int MaxDecimalExponent { get; }
    // 
    //     static int ExponentBias { get; }
    //     static ushort ExponentBits { get; }
    // 
    //     static int OverflowDecimalExponent { get; }
    //     static int InfinityExponent { get; }
    // 
    //     static ushort NormalMantissaBits { get; }
    //     static ushort DenormalMantissaBits { get; }
    // 
    //     static int MinFastFloatDecimalExponent { get; }
    //     static int MaxFastFloatDecimalExponent { get; }
    // 
    //     static int MinExponentRoundToEven { get; }
    //     static int MaxExponentRoundToEven { get; }
    // 
    //     static int MaxExponentFastPath { get; }
    //     static ulong MaxMantissaFastPath { get; }
    // 
    //     static TSelf BitsToFloat(ulong bits);
    // 
    //     static ulong FloatToBits(TSelf value);
    // 
    //     // Maximum number of digits required to guarantee that any given floating point
    //     // number can roundtrip. Some numbers may require less, but none will require more.
    //     static int MaxRoundTripDigits { get; }
    // 
    //     // SinglePrecisionCustomFormat and DoublePrecisionCustomFormat are used to ensure that
    //     // custom format strings return the same string as in previous releases when the format
    //     // would return x digits or less (where x is the value of the corresponding constant).
    //     // In order to support more digits, we would need to update ParseFormatSpecifier to pre-parse
    //     // the format and determine exactly how many digits are being requested and whether they
    //     // represent "significant digits" or "digits after the decimal point".
    //     static int MaxPrecisionCustomFormat { get; }
    // }

    /// <summary>
    /// Same IBinaryFloatParseAndFormatInfo.
    /// </summary>
    /// <typeparam name="TSelf">Type of number (数值的类型).</typeparam>
    internal static class FloatFormatInfo<TSelf> where TSelf : unmanaged
#if GENERICS_MATH
        , IBinaryFloatingPointIeee754<TSelf>
#endif
        {

        // -- Float type  --
        public static TSelf Zero { get; private set; }
        public static TSelf NaN { get; private set; }
        public static TSelf PositiveInfinity { get; private set; }
        public static TSelf NegativeInfinity { get; private set; }

        // -- IBinaryFloatParseAndFormatInfo  --
        public static int NumberBufferLength { get; private set; }

        public static ulong ZeroBits { get; private set; }
        public static ulong InfinityBits { get; private set; }

        public static ulong NormalMantissaMask { get; private set; }
        public static ulong DenormalMantissaMask { get; private set; }

        public static int MinBinaryExponent { get; private set; }
        public static int MaxBinaryExponent { get; private set; }

        public static int MinDecimalExponent { get; private set; }
        public static int MaxDecimalExponent { get; private set; }

        public static int ExponentBias { get; private set; }
        public static ushort ExponentBits { get; private set; }

        public static int OverflowDecimalExponent { get; private set; }
        public static int InfinityExponent { get; private set; }

        public static ushort NormalMantissaBits { get; private set; }
        public static ushort DenormalMantissaBits { get; private set; }

        public static int MinFastFloatDecimalExponent { get; private set; }
        public static int MaxFastFloatDecimalExponent { get; private set; }

        public static int MinExponentRoundToEven { get; private set; }
        public static int MaxExponentRoundToEven { get; private set; }

        public static int MaxExponentFastPath { get; private set; }
        public static ulong MaxMantissaFastPath { get; private set; }

        //static TSelf BitsToFloat(ulong bits);

        //static ulong FloatToBits(TSelf value);

        // Maximum number of digits required to guarantee that any given floating point
        // number can roundtrip. Some numbers may require less, but none will require more.
        public static int MaxRoundTripDigits { get; private set; }

        // SinglePrecisionCustomFormat and DoublePrecisionCustomFormat are used to ensure that
        // custom format strings return the same string as in previous releases when the format
        // would return x digits or less (where x is the value of the corresponding constant).
        // In order to support more digits, we would need to update ParseFormatSpecifier to pre-parse
        // the format and determine exactly how many digits are being requested and whether they
        // represent "significant digits" or "digits after the decimal point".
        public static int MaxPrecisionCustomFormat { get; private set; }

        static FloatFormatInfo() {
#pragma warning disable CS0219 // Variable is assigned but its value is never used
            unchecked {
                if (typeof(TSelf) == typeof(float)) {
                    Zero = (TSelf)(object)(float)0.0f;
                    NaN = (TSelf)(object)float.NaN;
                    PositiveInfinity = (TSelf)(object)float.PositiveInfinity;
                    NegativeInfinity = (TSelf)(object)float.NegativeInfinity;
                    // -- IBinaryFloatParseAndFormatInfo  --
                    uint SignMask = 0x8000_0000;
                    int SignShift = 31;
                    byte ShiftedSignMask = (byte)(SignMask >> SignShift);

                    uint BiasedExponentMask = 0x7F80_0000;
                    int BiasedExponentShift = 23;
                    int BiasedExponentLength = 8;
                    byte ShiftedBiasedExponentMask = (byte)(BiasedExponentMask >> BiasedExponentShift);

                    uint TrailingSignificandMask = 0x007F_FFFF;

                    byte MinSign = 0;
                    byte MaxSign = 1;

                    byte MinBiasedExponent = 0x00;
                    byte MaxBiasedExponent = 0xFF;

                    byte _ExponentBias = 127;

                    sbyte MinExponent = -126;
                    sbyte MaxExponent = +127;

                    uint MinTrailingSignificand = 0x0000_0000;
                    uint MaxTrailingSignificand = 0x007F_FFFF;

                    int TrailingSignificandLength = 23;
                    int SignificandLength = TrailingSignificandLength + 1;
                    // -- Property --
                    NumberBufferLength = Number.SingleNumberBufferLength;

                    ZeroBits = 0;
                    InfinityBits = 0x7F800000;

                    NormalMantissaMask = (1UL << SignificandLength) - 1;
                    DenormalMantissaMask = TrailingSignificandMask;

                    MinBinaryExponent = 1 - MaxExponent;
                    MaxBinaryExponent = MaxExponent;

                    MinDecimalExponent = -45;
                    MaxDecimalExponent = 39;

                    ExponentBias = _ExponentBias;
                    ExponentBits = 8;

                    OverflowDecimalExponent = (MaxExponent + (2 * SignificandLength)) / 3;
                    InfinityExponent = 0xFF;

                    NormalMantissaBits = (ushort)SignificandLength;
                    DenormalMantissaBits = (ushort)TrailingSignificandLength;

                    MinFastFloatDecimalExponent = -65;
                    MaxFastFloatDecimalExponent = 38;

                    MinExponentRoundToEven = -17;
                    MaxExponentRoundToEven = 10;

                    MaxExponentFastPath = 10;
                    MaxMantissaFastPath = 2UL << TrailingSignificandLength;

                    //BitsToFloat(ulong bits) = BitConverter.UInt32BitsToSingle((uint)(bits));

                    //FloatToBits(float value) = BitConverter.SingleToUInt32Bits(value);

                    MaxRoundTripDigits = 9;

                    MaxPrecisionCustomFormat = 7;
                } else if (typeof(TSelf) == typeof(double)) {
                    Zero = (TSelf)(object)(double)0.0;
                    NaN = (TSelf)(object)double.NaN;
                    PositiveInfinity = (TSelf)(object)double.PositiveInfinity;
                    NegativeInfinity = (TSelf)(object)double.NegativeInfinity;
                    // -- IBinaryFloatParseAndFormatInfo  --
                    ulong SignMask = 0x8000_0000_0000_0000;
                    int SignShift = 63;
                    byte ShiftedSignMask = (byte)(SignMask >> SignShift);

                    ulong BiasedExponentMask = 0x7FF0_0000_0000_0000;
                    int BiasedExponentShift = 52;
                    int BiasedExponentLength = 11;
                    ushort ShiftedExponentMask = (ushort)(BiasedExponentMask >> BiasedExponentShift);

                    ulong TrailingSignificandMask = 0x000F_FFFF_FFFF_FFFF;

                    byte MinSign = 0;
                    byte MaxSign = 1;

                    ushort MinBiasedExponent = 0x0000;
                    ushort MaxBiasedExponent = 0x07FF;

                    ushort _ExponentBias = 1023;

                    short MinExponent = -1022;
                    short MaxExponent = +1023;

                    ulong MinTrailingSignificand = 0x0000_0000_0000_0000;
                    ulong MaxTrailingSignificand = 0x000F_FFFF_FFFF_FFFF;

                    int TrailingSignificandLength = 52;
                    int SignificandLength = TrailingSignificandLength + 1;

                    // Constants representing the private bit-representation for various default values

                    ulong PositiveZeroBits = 0x0000_0000_0000_0000;
                    ulong NegativeZeroBits = 0x8000_0000_0000_0000;

                    ulong EpsilonBits = 0x0000_0000_0000_0001;

                    ulong PositiveInfinityBits = 0x7FF0_0000_0000_0000;
                    ulong NegativeInfinityBits = 0xFFF0_0000_0000_0000;

                    ulong SmallestNormalBits = 0x0010_0000_0000_0000;
                    // -- Property --

                    NumberBufferLength = Number.DoubleNumberBufferLength;

                    ZeroBits = 0;
                    InfinityBits = 0x7FF00000_00000000;

                    NormalMantissaMask = (1UL << SignificandLength) - 1;
                    DenormalMantissaMask = TrailingSignificandMask;

                    MinBinaryExponent = 1 - MaxExponent;
                    MaxBinaryExponent = MaxExponent;

                    MinDecimalExponent = -324;
                    MaxDecimalExponent = 309;

                    ExponentBias = _ExponentBias;
                    ExponentBits = 11;

                    OverflowDecimalExponent = (MaxExponent + (2 * SignificandLength)) / 3;
                    InfinityExponent = 0x7FF;

                    NormalMantissaBits = (ushort)SignificandLength;
                    DenormalMantissaBits = (ushort)TrailingSignificandLength;

                    MinFastFloatDecimalExponent = -342;
                    MaxFastFloatDecimalExponent = 308;

                    MinExponentRoundToEven = -4;
                    MaxExponentRoundToEven = 23;

                    MaxExponentFastPath = 22;
                    MaxMantissaFastPath = 2UL << TrailingSignificandLength;

                    //BitsToFloat(ulong bits) = BitConverter.UInt64BitsToDouble(bits);

                    //FloatToBits(double value) = BitConverter.DoubleToUInt64Bits(value);

                    MaxRoundTripDigits = 17;

                    MaxPrecisionCustomFormat = 15;
#if BCL_TYPE_HALF
                } else if (typeof(TSelf) == typeof(Half)) {
                    Zero = (TSelf)(object)(Half)0.0f;
                    NaN = (TSelf)(object)Half.NaN;
                    PositiveInfinity = (TSelf)(object)Half.PositiveInfinity;
                    NegativeInfinity = (TSelf)(object)Half.NegativeInfinity;
                    // -- IBinaryFloatParseAndFormatInfo  --
                    ushort SignMask = 0x8000;
                    int SignShift = 15;
                    byte ShiftedSignMask = (byte)(SignMask >> SignShift);

                    ushort BiasedExponentMask = 0x7C00;
                    int BiasedExponentShift = 10;
                    int BiasedExponentLength = 5;
                    byte ShiftedBiasedExponentMask = (byte)(BiasedExponentMask >> BiasedExponentShift);

                    ushort TrailingSignificandMask = 0x03FF;

                    byte MinSign = 0;
                    byte MaxSign = 1;

                    byte MinBiasedExponent = 0x00;
                    byte MaxBiasedExponent = 0x1F;

                    byte _ExponentBias = 15;

                    sbyte MinExponent = -14;
                    sbyte MaxExponent = +15;

                    ushort MinTrailingSignificand = 0x0000;
                    ushort MaxTrailingSignificand = 0x03FF;

                    int TrailingSignificandLength = 10;
                    int SignificandLength = TrailingSignificandLength + 1;
                    // -- Property --
                    NumberBufferLength = Number.HalfNumberBufferLength;

                    ZeroBits = 0;
                    InfinityBits = 0x7C00;

                    NormalMantissaMask = (1UL << SignificandLength) - 1;
                    DenormalMantissaMask = TrailingSignificandMask;

                    MinBinaryExponent = 1 - MaxExponent;
                    MaxBinaryExponent = MaxExponent;

                    MinDecimalExponent = -8;
                    MaxDecimalExponent = 5;

                    ExponentBias = _ExponentBias;
                    ExponentBits = 5;

                    OverflowDecimalExponent = (MaxExponent + (2 * SignificandLength)) / 3;
                    InfinityExponent = 0x1F;

                    NormalMantissaBits = (ushort)SignificandLength;
                    DenormalMantissaBits = (ushort)TrailingSignificandLength;

                    MinFastFloatDecimalExponent = -8;
                    MaxFastFloatDecimalExponent = 4;

                    MinExponentRoundToEven = -21;
                    MaxExponentRoundToEven = 5;

                    MaxExponentFastPath = 4;
                    MaxMantissaFastPath = 2UL << TrailingSignificandLength;

                    //BitsToFloat (ulong bits) = BitConverter.UInt16BitsToHalf((ushort)(bits));

                    //FloatToBits (Half value) = BitConverter.HalfToUInt16Bits(value);

                    MaxRoundTripDigits = 5;

                    MaxPrecisionCustomFormat = 5;
#endif // BCL_TYPE_HALF
                }
            }
#pragma warning restore CS0219 // Variable is assigned but its value is never used
        }

        public static TSelf BitsToFloat(ulong bits) {
            if (typeof(TSelf) == typeof(float)) {
                return (TSelf)(object)MathBitConverter.UInt32BitsToSingle((uint)(bits));
            } else if (typeof(TSelf) == typeof(double)) {
                return (TSelf)(object)MathBitConverter.UInt64BitsToDouble((ulong)(bits));
#if BCL_TYPE_HALF
            } else if (typeof(TSelf) == typeof(Half)) {
                return (TSelf)(object)MathBitConverter.UInt16BitsToHalf((ushort)(bits));
#endif // BCL_TYPE_HALF
            }
            return default;
        }

        public static ulong FloatToBits(TSelf value) {
            if (typeof(TSelf) == typeof(float)) {
                return MathBitConverter.SingleToUInt32Bits((float)(object)value);
            } else if (typeof(TSelf) == typeof(double)) {
                return MathBitConverter.DoubleToUInt64Bits((double)(object)value);
#if BCL_TYPE_HALF
            } else if (typeof(TSelf) == typeof(Half)) {
                return MathBitConverter.HalfToUInt16Bits((Half)(object)value);
#endif // BCL_TYPE_HALF
            }
            return default;
        }

        public static TSelf CreateSaturating(double value) {
#if GENERICS_MATH
            return TSelf.CreateSaturating(value);
#else
            if (typeof(TSelf) == typeof(double)) {
                return (TSelf)(object)value;
            } else if (typeof(TSelf) == typeof(float)) {
                return (TSelf)(object)(float)value;
#if BCL_TYPE_HALF
            } else if (typeof(TSelf) == typeof(Half)) {
                return (TSelf)(object)(Half)value;
#endif // BCL_TYPE_HALF
            }
            throw new NotSupportedException(string.Format("Not supported type! {0}", typeof(TSelf).FullName));
#endif
        }

    }

}
