using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Zyl.VectorTraits;
using Zyl.VectorTraits.Numerics;

namespace Zyl.VectorTraits.Tests.Numerics {
    [TestFixture()]
    internal class MathBitConverterTests {

        [Test()]
        public void SingleToInt32BitsTest() {
            int n = MathBitConverter.SingleToInt32Bits((float)1);
            Assert.AreNotEqual(0, n);
        }

    }
}
