using NUnit.Framework;
using Zyl.VectorTraits;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zyl.VectorTraits.Tests {
    [TestFixture()]
    public class TypeCodeFlagsUtilTests {

#if NETSTANDARD1_2 || NETSTANDARD1_1 || NETSTANDARD1_0 || NET45
#else
        [Test()]
        public void FromTypeCodeTest() {
            ElementTypeCode dst = TypeCodeFlagsUtil.FromTypeCode(TypeCode.Byte);
            Assert.AreEqual(ElementTypeCode.Byte, dst);
        }

        [Test()]
        public void ToTypeCodeTest() {
            TypeCode dst = TypeCodeFlagsUtil.ToTypeCode(ElementTypeCode.Byte);
            Assert.AreEqual(TypeCode.Byte, dst);
        }
#endif

        [Test()]
        public void FlagsFromTypeCodeTest() {
            TypeCodeFlags flags = TypeCodeFlagsUtil.FlagsFromTypeCode(ElementTypeCode.Byte);
            Assert.AreEqual(TypeCodeFlags.Byte, flags);
        }

        [Test()]
        public void ForEachTest() {
            TypeCodeFlagsUtil.ForEach(TypeCodeFlagsUtil.FloatTypes, delegate (ElementTypeCode code) {
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