using NUnit.Framework;
using Zyl.VectorTraits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zyl.VectorTraits.Tests {
    [TestFixture()]
    public class VectorTextUtilTests {
        private static readonly int[] LenArray = { 0, 0x10 };

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
        public void FillTest<T>(T src) {
            foreach(int len in LenArray) {
                T[] arr = new T[len];
                VectorTextUtil.Fill(arr, src);
                // check.
                foreach (T p in arr) {
                    Assert.AreEqual(src, p);
                }
            }
        }
    }
}