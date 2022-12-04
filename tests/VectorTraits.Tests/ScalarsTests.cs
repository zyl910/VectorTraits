using NUnit.Framework;
using Zyl.VectorTraits;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zyl.VectorTraits.Tests {
    [TestFixture()]
    public class ScalarsTests {

        [TestCase((float)1)]
        [TestCase((double)2)]
        [TestCase((sbyte)3)]
        [TestCase((byte)4)]
        [TestCase((short)5)]
        [TestCase((ushort)6)]
        [TestCase((int)7)]
        [TestCase((uint)8)]
        [TestCase((long)9)]
        [TestCase((ulong)10)]
        public void GetByDoubleTest<T>(T src) {
            double srcDouble = double.Parse("" + src);
            T dst = Scalars.GetByDouble<T>(srcDouble);
            Assert.AreEqual(src, dst);
        }

        [TestCase((sbyte)3)]
        [TestCase((byte)4)]
        [TestCase((short)5)]
        [TestCase((ushort)6)]
        [TestCase((int)7)]
        [TestCase((uint)8)]
        [TestCase((long)9)]
        [TestCase((ulong)10)]
        public void LimitShiftCountTest<T>(T src) where T : struct {
            int iMin = 0;
            int iMax = Scalars<T>.BitSize - 1;
            int iMinLoop = iMin - 1;
            int iMaxLoop = iMax + (int)Scalars.GetInt64BitsFrom<T>(src);
            for (int i= iMinLoop; i<= iMaxLoop; ++i) {
                int dst = Scalars.LimitShiftCount<T>(i);
                Assert.GreaterOrEqual(dst, iMin);
                Assert.LessOrEqual(dst, iMax);
            }
        }
    }
}