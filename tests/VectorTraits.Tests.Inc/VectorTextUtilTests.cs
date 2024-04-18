using NUnit.Framework;
#if !USED_NUNIT3
using NUnit.Framework.Legacy;
#endif
using System;
using System.Collections.Generic;
using System.Text;
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Tests {
#if USED_NUNIT3
    using ClassicAssert = Assert;
#endif

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
                    ClassicAssert.AreEqual(src, p);
                }
            }
        }

        [TestCase]
        public void SplitKeyValueToIntTest() {
            const int defaultValue = 123;
            string key;
            int dst;
            // No value.
            dst = VectorTextUtil.SplitKeyValueToInt("-accelerated", out key, defaultValue);
            ClassicAssert.AreEqual(defaultValue, dst);
            ClassicAssert.AreEqual("-accelerated", key);
            // Use defaultValue.
            dst = VectorTextUtil.SplitKeyValueToInt("-accelerated=1", out key, defaultValue);
            ClassicAssert.AreEqual(1, dst);
            ClassicAssert.AreEqual("-accelerated", key);
            // Value has space.
            dst = VectorTextUtil.SplitKeyValueToInt("-accelerated= 1", out key, defaultValue);
            ClassicAssert.AreEqual(1, dst);
            ClassicAssert.AreEqual("-accelerated", key);
        }

    }
}