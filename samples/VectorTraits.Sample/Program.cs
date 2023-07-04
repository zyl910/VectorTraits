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
                Vectors<double>.Demo,
                Vectors<double>.DemoNaN,
                Vectors.CreateByDoubleLoop<double>(BitConverter.Int64BitsToDouble(((ScalarConstants.Double_ExponentBias + 0L)<<52) | ScalarConstants.Double_MantissaMask), 1),
                Vectors.CreateByDoubleLoop<double>(BitConverter.Int64BitsToDouble(((ScalarConstants.Double_ExponentBias + 1L)<<52) | ScalarConstants.Double_MantissaMask), 1),
                Vectors.CreateByDoubleLoop<double>(BitConverter.Int64BitsToDouble(((ScalarConstants.Double_ExponentBias + 2L)<<52) | ScalarConstants.Double_MantissaMask), 1),
                Vectors.CreateByDoubleLoop<double>(BitConverter.Int64BitsToDouble(((ScalarConstants.Double_ExponentBias + 50L)<<52) | ScalarConstants.Double_MantissaMask), 1),
                Vectors.CreateByDoubleLoop<double>(BitConverter.Int64BitsToDouble(((ScalarConstants.Double_ExponentBias + 51L)<<52) | ScalarConstants.Double_MantissaMask), 1),
                Vectors.CreateByDoubleLoop<double>(BitConverter.Int64BitsToDouble(((ScalarConstants.Double_ExponentBias + 52L)<<52) | ScalarConstants.Double_MantissaMask), 1),
            };
            foreach(var sample in samples) {
                var expected = VectorTraitsBase.Statics.YTruncate_Floor(sample);
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", sample));
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                var dst = YTruncate_ClearBit(sample);
                if (!dst.Equals(expected)) {
                    writer.WriteLine(VectorTextUtil.Format("Dst:\t{0}", dst));
                }
                writer.WriteLine();
            }
        }
        public static Vector<double> YTruncate_ClearBit(Vector<double> value) {
            //constants.
            Vector<double> signMask = new Vector<long>(ScalarConstants.Double_SignMask).AsDouble();
            Vector<double> exponentMask = new Vector<long>(ScalarConstants.Double_ExponentMask).AsDouble();
            Vector<long> expMinuend = new Vector<long>(((long)ScalarConstants.Double_ExponentBias*2 + ScalarConstants.Double_ExponentShift) << ScalarConstants.Double_ExponentShift); // Item is `(1023*2 + 52)<<52`.
            Vector<double> rangeBegin = new Vector<double>(1.0);
            Vector<double> rangeBegin2 = new Vector<double>(2.0);
            Vector<double> rangeEnd = new Vector<long>(ScalarConstants.DoubleBit_2Pow52).AsDouble(); // Double value: pow(2, 52)
            Vector<long> nonMantissaMask = new Vector<long>(ScalarConstants.Double_NonMantissaMask);
            // operations
            Vector<double> valueAbs = Vector.AndNot(value, signMask);
            Vector<double> valueExpData = Vector.BitwiseAnd(value, exponentMask);
            // AndNot will be used instead of BitwiseAnd: Vector<long> maskBegin = Vector.OnesComplement(Vector.GreaterThan(rangeBegin.AsInt64(), valueAbs.AsInt64())); // Vector.GreaterThanOrEqual(valueAbs, rangeBegin);
            Vector<long> maskBegin = Vector.GreaterThan(rangeBegin.AsInt64(), valueAbs.AsInt64()); // Vector.GreaterThanOrEqual(valueAbs, rangeBegin);
            Vector<long> maskless2 = Vector.GreaterThan(rangeBegin2.AsInt64(), valueAbs.AsInt64()); // (2>valueAbs[i])
            Vector<long> maskEnd = Vector.OnesComplement(Vector.GreaterThan(rangeEnd.AsInt64(), valueAbs.AsInt64())); // (a>=b) = ~(a<b) = ~(b>a) //Vector.GreaterThanOrEqual(valueAbs, rangeEnd);
            Vector<double> maskRawPow = Vector.Subtract(expMinuend.AsUInt64(), valueExpData.AsUInt64()).AsDouble(); // If valueExpData is `(1023 + e)<<52`, `expMinuend-valueExpData` exponent field is `(1023*2 + 52) - (1023 + e) = 1023 + (52-e)`
            //writer.WriteLine(VectorTextUtil.Format("The maskRawPow:\t{0}", maskRawPow));
            Vector<double> valueFix = Vector.AndNot(value, maskBegin.AsDouble());
            //Vector<long> mask = VectorTraitsBase.Statics.ConvertToUInt64_Range52_NoTruncate(maskRawPow).AsInt64();
            Vector<long> mask = Vector.Add(maskRawPow, rangeEnd).AsInt64();
            //writer.WriteLine(VectorTextUtil.Format("The mask step 1:\t{0}", mask));
            mask = Vector.Xor(mask, rangeEnd.AsInt64()); // mask = ConvertToUInt64_Range52_NoTruncate(maskRawPow).AsInt64();
            //writer.WriteLine(VectorTextUtil.Format("The mask step 2:\t{0}", mask));
            mask = Vector.Subtract(Vector<long>.Zero, mask); // The mask is `~(pow(2,52-e)-1)`. Because `-(x) = ~x+1`, the inverse is `~(x-1) = -(x) = 0 - x`.
            mask = Vector.ConditionalSelect(maskless2, nonMantissaMask, mask);
            mask = Vector.BitwiseOr(mask, maskEnd.AsInt64());
            //writer.WriteLine(VectorTextUtil.Format("The maskBegin:\t{0}", maskBegin));
            //writer.WriteLine(VectorTextUtil.Format("The mask:\t{0}", mask));
            Vector<double> rt = Vector.BitwiseAnd(valueFix, mask.AsDouble());
            return rt;
        }
    }
}
