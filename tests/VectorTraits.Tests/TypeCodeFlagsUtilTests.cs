using NUnit.Framework;
using Zyl.VectorTraits;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zyl.VectorTraits.Tests {
    [TestFixture()]
    public class TypeCodeFlagsUtilTests {
        [Test()]
        public void FromTypeCodeTest() {
            TypeCodeFlags flags = TypeCodeFlagsUtil.FromTypeCode(TypeCode.Byte);
            Assert.AreEqual(TypeCodeFlags.Byte, flags);
        }

        [Test()]
        public void ForEachTest() {
            TypeCodeFlagsUtil.ForEach(TypeCodeFlagsUtil.FloatTypes, delegate (TypeCode code) {
                Assert.AreNotEqual(0, (int)code);
            });
        }

        [Test()]
        public void ToEnumerableTest() {
            foreach (var code in TypeCodeFlagsUtil.ToEnumerable(TypeCodeFlagsUtil.IntTypes)) {
                Assert.AreNotEqual(0, (int)code);
            }
        }
    }
}