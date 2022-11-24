using NUnit.Framework;
using Zyl.VectorTraits;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zyl.VectorTraits.Tests {
    [TestFixture()]
    public class BitUtilTests {
        [Test()]
        public void SingleToInt32BitsTest() {
            int n = BitUtil.SingleToInt32Bits((float)1);
            Assert.AreNotEqual(0, n);
        }
    }
}