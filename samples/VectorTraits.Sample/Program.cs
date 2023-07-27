using System;
using System.IO;
using System.Numerics;
using Zyl.VectorTraits;
using Zyl.VectorTraits.Extensions.SameW;
using Zyl.VectorTraits.Impl;
using Zyl.VectorTraits.Impl.AVector;

namespace Zyl.VectorTraits.Sample {
    class Program {
        static TextWriter writer = Console.Out;
        static void Main(string[] args) {
            writer.WriteLine("VectorTraits.Sample");
            writer.WriteLine();
            TraitsOutput.OutputEnvironment(writer);
            writer.WriteLine();

            VectorTraitsGlobal.Init();
            Vector<short> src = Vectors.CreateRotate<short>(0, 1, 2, 3, 4, 5, 6, 7);
            VectorTextUtil.WriteLine(writer, "src:\t{0}", src);
            // Truncate.
            writer.WriteLine();
            Vector<double>[] samples = {
                Vectors<double>.Serial,
                Vectors.CreateByDoubleLoop<double>(-0.5, 1),
                Vectors.CreateByDoubleLoop<double>(-0.5, -1),
                Vectors<double>.Demo,
                Vectors<double>.DemoNaN,
                Vectors.CreateByDoubleLoop<double>(BitConverter.Int64BitsToDouble(((ScalarConstants.Double_ExponentBias + 0L)<<52) | ScalarConstants.Double_MantissaMask), 1),
                Vectors.CreateByDoubleLoop<double>(BitConverter.Int64BitsToDouble(((ScalarConstants.Double_ExponentBias + 1L)<<52) | ScalarConstants.Double_MantissaMask), 1),
                Vectors.CreateByDoubleLoop<double>(BitConverter.Int64BitsToDouble(((ScalarConstants.Double_ExponentBias + 2L)<<52) | ScalarConstants.Double_MantissaMask), 1),
                Vectors.CreateByDoubleLoop<double>(BitConverter.Int64BitsToDouble(((ScalarConstants.Double_ExponentBias + 50L)<<52) | ScalarConstants.Double_MantissaMask), 1),
                Vectors.CreateByDoubleLoop<double>(BitConverter.Int64BitsToDouble(((ScalarConstants.Double_ExponentBias + 51L)<<52) | ScalarConstants.Double_MantissaMask), 1),
                Vectors.CreateByDoubleLoop<double>(BitConverter.Int64BitsToDouble(((ScalarConstants.Double_ExponentBias + 52L)<<52) | ScalarConstants.Double_MantissaMask), 1),
                Vectors.CreateByDoubleLoop<double>(BitConverter.Int64BitsToDouble(-((ScalarConstants.Double_ExponentBias + 50L)<<52) | ScalarConstants.Double_MantissaMask), 1),
                Vectors.CreateByDoubleLoop<double>(BitConverter.Int64BitsToDouble(-((ScalarConstants.Double_ExponentBias + 51L)<<52) | ScalarConstants.Double_MantissaMask), 1),
                Vectors.CreateByDoubleLoop<double>(BitConverter.Int64BitsToDouble(-((ScalarConstants.Double_ExponentBias + 52L)<<52) | ScalarConstants.Double_MantissaMask), 1),
            };
            foreach(var sample in samples) {
                var expected = VectorTraitsBase.Statics.YRoundToZero_Floor(sample);
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", sample));
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                var dst = YRoundToZero_ClearBit(sample);
                if (!dst.AsInt32().Equals(expected.AsInt32())) {
                    writer.WriteLine(VectorTextUtil.Format("Dst:\t{0}", dst));
                }
                writer.WriteLine();
            }
        }
        public static Vector<double> YRoundToZero_ClearBit(Vector<double> value) {
            // Float encode is `sign*(1.m)*pow(2,e) = sign*(1.m)*pow(2,eBias - BIAS)`. Double's BIAS is `1023`.
            // If (e>=52): Has 0bit fractional part. The mask is `0`.
            // If (e==51): Has 1bit fractional part. The mask is `0x1`.
            // ...
            // If (e==1): Has 51bit fractional part. The mask is `0x0007FFFF_FFFFFFFF`.
            // If (e==0): Has 52bit fractional part. The mask is `0x000FFFFF_FFFFFFFF`.
            // If (e< 0): Need set to zero (0.0 / -0.0). The mask is `0x7FFFFFFF_FFFFFFFF`.
            //
            // If (0<=e && e<=52): The mask is `pow(2,52-e) - 1`. So `RoundToZero(x) = x & ~mask`.
            //Constants.
            Vector<double> exponentMask = new Vector<double>(ScalarConstants.DoubleVal_ExponentMask);
            Vector<double> one = new Vector<double>(1.0);
            Vector<double> rangeEnd = new Vector<double>(ScalarConstants.DoubleVal_2Pow52); // Double value: pow(2, 52)
            Vector<double> nonSignMask = VectorConstants.Double_NonSignMask;
            Vector<double> expMinuend = new Vector<double>(ScalarConstants.DoubleVal_Truncate_expMinuend); // Item is `(long)(1023*2 + 52)<<52`. Binary is `0x8320000000000000`.
            //Operations.
            Vector<double> valueExpData = Vector.BitwiseAnd(value, exponentMask); // Get exponent field.
            Vector<long> maskBegin = Vector.GreaterThan(one, valueExpData); // `1 > valueExpData[i] = pow(2,0) > pow(2,e)`, it mean `e<0`.
            valueExpData = Vector.Min(valueExpData, rangeEnd); // Clamp to `e<=52`.
            maskBegin = Vector.BitwiseAnd(maskBegin, nonSignMask.AsInt64()); // Keep sign flag.
            Vector<double> maskRawPow = Vector.Subtract(expMinuend.AsUInt64(), valueExpData.AsUInt64()).AsDouble(); // If valueExpData is `(1023 + e)<<52`, `expMinuend-valueExpData` exponent field will be `(1023*2 + 52) - (1023 + e) = 1023 + (52-e)`
            maskRawPow = Vector.Subtract(maskRawPow, one); // The mask is `pow(2,52-e) - 1`.
            Vector<long> mask = Vector.Add(maskRawPow, rangeEnd).AsInt64(); // Step 1 of ConvertToUInt64_Range52RoundToEven .
            mask = Vector.Xor(mask, rangeEnd.AsInt64()); // mask = ConvertToUInt64_Range52RoundToEven(maskRawPow).AsInt64();
            Vector<long> allBitsSet = Vectors<long>.AllBitsSet;
            mask = Vector.BitwiseOr(mask, maskBegin); // Choose (e<0).
            //writer.WriteLine(VectorTextUtil.Format("The mask:\t{0}", mask));
            mask = Vector.Xor(mask, allBitsSet); // mask = ~mask;
            Vector<double> rt = Vector.BitwiseAnd(value, mask.AsDouble());
            return rt;
        }
    }
}
