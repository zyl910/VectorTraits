using NUnit.Framework;
using Zyl.VectorTraits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zyl.VectorTraits.Tests {
    [TestFixture()]
    public class TraitsUtilTests {
        private static readonly int[] LenArray = { 0, 0x10 };

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
        public void FillTest<T>(T src) {
            foreach(int len in LenArray) {
                T[] arr = new T[len];
                TraitsUtil.Fill(arr, src);
                foreach (T p in arr) {
                    Assert.AreEqual(src, p);
                }
            }
        }
    }
}