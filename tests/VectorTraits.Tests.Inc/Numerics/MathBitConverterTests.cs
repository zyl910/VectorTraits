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
    internal class MathBitConverterTests {

        [Test()]
        public void SingleToInt32BitsTest() {
            int n = MathBitConverter.SingleToInt32Bits((float)1);
            ClassicAssert.AreNotEqual(0, n);
        }

    }
}
