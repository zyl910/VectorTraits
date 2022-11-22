using NUnit.Framework;
using Zyl.VectorTraits;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif

namespace Zyl.VectorTraits.Tests {
    [TestFixture()]
    public class Vector128sTests {
#if NETCOREAPP3_0_OR_GREATER

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
        public void CreatePaddingTest<T>(T src) where T : struct {
            Vector128<T> vzero = Vector128<T>.Zero;
            T zero = default;
            // params
            Vector128<T> v1 = Vector128s.CreatePadding(src);
            Vector128<T> v2 = Vector128s.CreatePadding(src, src);
            Assert.AreNotEqual(vzero, v1);
            Assert.AreNotEqual(vzero, v2);
            // []
            int vcount = Vector128<T>.Count;
            T[] arr = new T[vcount + 1];
            TraitsUtil.Fill(arr, src);
            v1 = Vector128s.CreatePadding(arr);
            Assert.AreNotEqual(vzero, v1);
            // Use int index, int length
            for (int i = 0; i <= arr.Length; ++i) {
                int srcCount = i;
                if (srcCount > vcount) srcCount = vcount;
                Vector128<T> v = Vector128s.CreatePadding(arr, 0, i);
                for (int j = 0; j < srcCount; ++j) {
                    Assert.AreEqual(src, v.GetElement(j));
                }
                for (int j = srcCount; j < vcount; ++j) {
                    Assert.AreEqual(zero, v.GetElement(j));
                }
            }
        }

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
        public void CreateRotateTest<T>(T src) where T : struct {
            Vector128<T> vzero = Vector128<T>.Zero;
            // params
            Vector128<T> v1 = Vector128s.CreateRotate(src);
            Vector128<T> v2 = Vector128s.CreateRotate(src, src);
            Assert.AreNotEqual(vzero, v1);
            Assert.AreNotEqual(vzero, v2);
            // []
            int vcount = Vector128<T>.Count;
            T[] arr = new T[vcount + 1];
            arr[0] = src;
            v1 = Vector128s.CreateRotate(arr);
            Assert.AreNotEqual(vzero, v1);
            // Use int index, int length
            for (int i = 0; i <= arr.Length; ++i) {
                int srcCount = i;
                if (srcCount > vcount) srcCount = vcount;
                Vector128<T> v = Vector128s.CreateRotate(arr, 0, i);
                if (i > 0) {
                    for (int j = 0; j < srcCount; ++j) {
                        int pos = j % srcCount;
                        T cur = arr[pos];
                        Assert.AreEqual(cur, v.GetElement(j));
                    }
                } else {
                    Assert.AreNotEqual(vzero, v);
                }
            }
        }

#endif
    }
}
