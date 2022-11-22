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
            Int32 n = BitUtil.SingleToInt32Bits((Single)1);
            Assert.AreNotEqual(0, n);
        }
    }
}