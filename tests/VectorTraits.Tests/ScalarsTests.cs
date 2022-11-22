using NUnit.Framework;
using Zyl.VectorTraits;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zyl.VectorTraits.Tests {
    [TestFixture()]
    public class ScalarsTests {
        
        [TestCase((Single)1)]
        [TestCase((Double)2)]
        [TestCase((Byte)3)]
        [TestCase((SByte)4)]
        [TestCase((Int16)5)]
        [TestCase((UInt16)6)]
        [TestCase((Int32)7)]
        [TestCase((UInt32)8)]
        [TestCase((Int64)9)]
        [TestCase((UInt64)10)]
        public void GetByDoubleTest<T>(T src) {
            double srcDouble = double.Parse("" + src);
            T dst = Scalars.GetByDouble<T>(srcDouble);
            Assert.AreEqual(src, dst);
        }
    }
}