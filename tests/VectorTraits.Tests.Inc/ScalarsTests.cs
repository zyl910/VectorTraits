using NUnit.Framework;
#if !USED_NUNIT3
using NUnit.Framework.Legacy;
#endif
using System;
using System.Collections.Generic;
using System.Text;
using Zyl.VectorTraits;

namespace Zyl.VectorTraits.Tests {
#if USED_NUNIT3
    using ClassicAssert = Assert;
#endif

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
            ClassicAssert.AreEqual(src, dst);
        }

        [TestCase((sbyte)3)]
        [TestCase((byte)4)]
        [TestCase((short)5)]
        [TestCase((ushort)6)]
        [TestCase((int)7)]
        [TestCase((uint)8)]
        [TestCase((long)9)]
        [TestCase((ulong)10)]
        public void LimitShiftAmountTest<T>(T src) where T : struct {
            int iMin = 0;
            int iMax = Scalars<T>.BitSize - 1;
            int iMinLoop = iMin - 1;
            int iMaxLoop = iMax + (int)Scalars.GetInt64BitsFrom<T>(src);
            for (int i= iMinLoop; i<= iMaxLoop; ++i) {
                int dst = Scalars.LimitShiftAmount<T>(i);
                ClassicAssert.GreaterOrEqual(dst, iMin);
                ClassicAssert.LessOrEqual(dst, iMax);
            }
        }
    }
}