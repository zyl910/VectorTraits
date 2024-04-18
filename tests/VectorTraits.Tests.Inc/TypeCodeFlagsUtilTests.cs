using NUnit.Framework;
#if !USED_NUNIT3
using NUnit.Framework.Legacy;
#endif
using System;
using System.Collections.Generic;
using System.Text;

namespace Zyl.VectorTraits.Tests {
#if USED_NUNIT3
    using ClassicAssert = Assert;
#endif

    [TestFixture()]
    public class TypeCodeFlagsUtilTests {

#if NETSTANDARD1_2 || NETSTANDARD1_1 || NETSTANDARD1_0 || NET45
#else
        [Test()]
        public void FromTypeCodeTest() {
            ElementTypeCode dst = TypeCodeFlagsUtil.FromTypeCode(TypeCode.Byte);
            ClassicAssert.AreEqual(ElementTypeCode.Byte, dst);
        }

        [Test()]
        public void ToTypeCodeTest() {
            TypeCode dst = TypeCodeFlagsUtil.ToTypeCode(ElementTypeCode.Byte);
            ClassicAssert.AreEqual(TypeCode.Byte, dst);
        }
#endif

        [Test()]
        public void FlagsFromTypeCodeTest() {
            TypeCodeFlags flags = TypeCodeFlagsUtil.FlagsFromTypeCode(ElementTypeCode.Byte);
            ClassicAssert.AreEqual(TypeCodeFlags.Byte, flags);
        }

        [Test()]
        public void ForEachTest() {
            TypeCodeFlagsUtil.ForEach(TypeCodeFlagsUtil.FloatTypes, delegate (ElementTypeCode code) {
                ClassicAssert.AreNotEqual(0, (int)code);
            });
        }

        [Test()]
        public void MapFlagsTest() {
            const TypeCodeFlags expected = TypeCodeFlags.Double;
            TypeCodeFlags src = TypeCodeFlags.Int64;
            TypeCodeFlags dst = TypeCodeFlagsUtil.MapFlags(src, TypeCodeFlags.Int64, expected);
            ClassicAssert.AreEqual(expected, dst);
        }

        [Test()]
        public void MapFlagsTest_2() {
            const TypeCodeFlags expected = TypeCodeFlags.Single | TypeCodeFlags.Double;
            TypeCodeFlags src = TypeCodeFlags.Int32 | TypeCodeFlags.Int64;
            TypeCodeFlags dst = TypeCodeFlagsUtil.MapFlags(src, TypeCodeFlags.Int32, TypeCodeFlags.Single, TypeCodeFlags.Int64, TypeCodeFlags.Double);
            ClassicAssert.AreEqual(expected, dst);
        }

        [Test()]
        public void ToEnumerableTest() {
            foreach (var code in TypeCodeFlagsUtil.ToEnumerable(TypeCodeFlagsUtil.IntTypes)) {
                ClassicAssert.AreNotEqual(0, (int)code);
            }
        }
    }
}