using NUnit.Framework;
#if !USED_NUNIT3
using NUnit.Framework.Legacy;
#endif
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Zyl.VectorTraits;

namespace Zyl.VectorTraits.Tests {
#if USED_NUNIT3
    using ClassicAssert = Assert;
#endif

    [TestFixture()]
    public class MathTests {

        [Test()]
        public void FloorCompareRoundToEvenTest() {
            TextWriter writer = Console.Out;
            bool hideEquals = true;
            const long countShowMax = 100;
            const int stepCount = 2;
            const double stepDelta = 1.0 / stepCount;
            double rangeItemNumber = Math.Pow(2, 4);
            long rangeItemCount = (long)(rangeItemNumber * stepCount);
            double[] rangeStarts = new double[] {
                    -Math.Pow(2, 51),
                    -Math.Pow(2, 50),
                    0,
                    Math.Pow(2, 50),
                    Math.Pow(2, 51) - rangeItemNumber,
                    // Out of range 52.
                    Math.Pow(2, 51),
                    Math.Pow(2, 52) - rangeItemNumber,
                    Math.Pow(2, 52),
            };
            long countError = 0;
            long countShow = 0;
            if (rangeStarts.Length > 0) {
                foreach (double start in rangeStarts) {
                    for (long i = 0; i < rangeItemCount; i++) {
                        double number = start + i * stepDelta;
                        double expected = Math.Floor(number);
                        double dst = Math.Round(number - 0.5, MidpointRounding.ToEven);
                        string msg = "";
                        if (expected != dst) {
                            ++countError;
                            msg = string.Format("[{0}] {1}: {2}!={3} // 0x{4:X}", i, number, expected, dst, BitConverter.DoubleToInt64Bits(number));
                        } else {
                            if (!hideEquals) {
                                msg = string.Format("[{0}] {1}: {2}=={3} // 0x{4:X}", i, number, expected, dst, BitConverter.DoubleToInt64Bits(number));
                            }
                        }
                        if (!string.IsNullOrEmpty(msg)) {
                            ++countShow;
                            if (countShow <= countShowMax) {
                                writer.WriteLine(msg);
                            }
                        }
                    }
                }
            }
            writer.WriteLine("countError: {0}", countError);
            //ClassicAssert.Zero(countError);
        }

    }
}
