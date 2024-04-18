using NUnit.Framework;
#if !USED_NUNIT3
using NUnit.Framework.Legacy;
#endif
using System;
using System.Collections.Generic;
using System.Text;
using Zyl.VectorTraits;
using Zyl.VectorTraits.Numerics;

namespace Zyl.VectorTraits.Tests.Numerics {
#if USED_NUNIT3
    using ClassicAssert = Assert;
#endif

    [TestFixture()]
    internal class MathOperatorsTests {

        [Test()]
        public void BigMulTestTest_Int64() {
#pragma warning disable CS0618 // Type or member is obsolete
            long[] samples = {
                -0xFFFFFFFFL,
                -0x100000000L,
                -0x100000001L,
                -0x100000002L,
                1,
                2,
                3,
                0xFFFF,
                0x100000,
                0xFFFFFFFFL,
                0x100000000L,
                0x100000001L,
                0x100000002L,
                0x200000000L,
                0x200000001L,
                0x200000002L,
            };
            bool allowLog = false;
            for (int i = 0; i < samples.Length; ++i) {
                long a = samples[i];
                for (int j = 0; j <= i; ++j) {
                    long b = samples[j];
                    long low, high;
                    high = MathOperators.BigMul_BigNum(a, b, out low);
                    long expectedLow = low;
                    long expectedHigh = high;
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("{0} * {1} = ({2}, {3})", a, b, expectedHigh, expectedLow));
                    }
                    // bcl.
#if NET5_0_OR_GREATER
                    high = Math.BigMul(a, b, out low);
                    ClassicAssert.AreEqual(expectedLow, low, string.Format("BigMul_BigNum({0}, {1}).low", a, b));
                    ClassicAssert.AreEqual(expectedHigh, high, string.Format("BigMul_BigNum({0}, {1}).high", a, b));
#endif // NET5_0_OR_GREATER
                    // MathOperators.BigMul .
                    high = MathOperators.BigMul(a, b, out low);
                    ClassicAssert.AreEqual(expectedLow, low, string.Format("MathOperators.BigMul({0}, {1}).low", a, b));
                    ClassicAssert.AreEqual(expectedHigh, high, string.Format("MathOperators.BigMul({0}, {1}).high", a, b));
                    // BigMul_Two.
                    high = MathOperators.BigMul_Two(a, b, out low);
                    ClassicAssert.AreEqual(expectedLow, low, string.Format("BigMul_Two({0}, {1}).low", a, b));
                    ClassicAssert.AreEqual(expectedHigh, high, string.Format("BigMul_Two({0}, {1}).high", a, b));
                    // BigMulHigh.
                    high = MathOperators.BigMulHigh(a, b);
                    ClassicAssert.AreEqual(expectedHigh, high, string.Format("BigMulHigh({0}, {1}).high", a, b));
                    // BigMulLow.
                    low = MathOperators.BigMulLow(a, b);
                    ClassicAssert.AreEqual(expectedLow, low, string.Format("BigMulLow({0}, {1}).low", a, b));
                }
            }
#pragma warning restore CS0618 // Type or member is obsolete
        }

        [Test()]
        public void BigMulTestTest_UInt64() {
#pragma warning disable CS0618 // Type or member is obsolete
            ulong[] samples = {
                1,
                2,
                3,
                0xFFFF,
                0x100000,
                0xFFFFFFFFL,
                0x100000000L,
                0x100000001L,
                0x100000002L,
                0x200000000L,
                0x200000001L,
                0x200000002L,
            };
            bool allowLog = false;
            for (int i = 0; i < samples.Length; ++i) {
                ulong a = samples[i];
                for (int j = 0; j <= i; ++j) {
                    ulong b = samples[j];
                    ulong low, high;
                    high = MathOperators.BigMul_BigNum(a, b, out low);
                    ulong expectedLow = low;
                    ulong expectedHigh = high;
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("{0} * {1} = ({2}, {3})", a, b, expectedHigh, expectedLow));
                    }
                    // bcl.
#if NET5_0_OR_GREATER
                    high = Math.BigMul(a, b, out low);
                    ClassicAssert.AreEqual(expectedLow, low, string.Format("BigMul_BigNum({0}, {1}).low", a, b));
                    ClassicAssert.AreEqual(expectedHigh, high, string.Format("BigMul_BigNum({0}, {1}).high", a, b));
#endif // NET5_0_OR_GREATER
                    // MathOperators.BigMul .
                    high = MathOperators.BigMul(a, b, out low);
                    ClassicAssert.AreEqual(expectedLow, low, string.Format("MathOperators.BigMul({0}, {1}).low", a, b));
                    ClassicAssert.AreEqual(expectedHigh, high, string.Format("MathOperators.BigMul({0}, {1}).high", a, b));
                    // BigMul_Two.
                    high = MathOperators.BigMul_Two(a, b, out low);
                    ClassicAssert.AreEqual(expectedLow, low, string.Format("BigMul_Two({0}, {1}).low", a, b));
                    ClassicAssert.AreEqual(expectedHigh, high, string.Format("BigMul_Two({0}, {1}).high", a, b));
                    // BigMulHigh.
                    high = MathOperators.BigMulHigh(a, b);
                    ClassicAssert.AreEqual(expectedHigh, high, string.Format("BigMulHigh({0}, {1}).high", a, b));
                    // BigMulLow.
                    low = MathOperators.BigMulLow(a, b);
                    ClassicAssert.AreEqual(expectedLow, low, string.Format("BigMulLow({0}, {1}).low", a, b));
                }
            }
#pragma warning restore CS0618 // Type or member is obsolete
        }

    }
}
