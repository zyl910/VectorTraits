using NUnit.Framework;
using Zyl.VectorTraits;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace Zyl.VectorTraits.Tests {
    [TestFixture()]
    public class VectorsTests {

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
        public void CreatePaddingTest<T>(T src) where T:struct {
            Vector<T> vzero = Vector<T>.Zero;
            T zero = default;
            // params
            Vector<T> v1 = Vectors.CreatePadding(src);
            Vector<T> v2 = Vectors.CreatePadding(src, src);
            Assert.AreNotEqual(vzero, v1);
            Assert.AreNotEqual(vzero, v2);
            // []
            int vcount = Vector<T>.Count;
            T[] arr = new T[vcount + 1];
            TraitsUtil.Fill(arr, src);
            v1 = Vectors.CreatePadding(arr);
            Assert.AreNotEqual(vzero, v1);
            // Use int index, int length
            for (int i = 0; i <= arr.Length; ++i) {
                int srcCount = i;
                if (srcCount > vcount) srcCount = vcount;
                Vector<T> v = Vectors.CreatePadding(arr, 0, i);
                for (int j = 0; j < srcCount; ++j) {
                    Assert.AreEqual(src, v[j]);
                }
                for (int j = srcCount; j < vcount; ++j) {
                    Assert.AreEqual(zero, v[j]);
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
            Vector<T> vzero = Vector<T>.Zero;
            T zero = default;
            // params
            Vector<T> v1 = Vectors.CreateRotate(src);
            Vector<T> v2 = Vectors.CreateRotate(src, src);
            Assert.AreNotEqual(vzero, v1);
            Assert.AreNotEqual(vzero, v2);
            // []
            int vcount = Vector<T>.Count;
            T[] arr = new T[vcount + 1];
            arr[0] = src;
            v1 = Vectors.CreateRotate(arr);
            Assert.AreNotEqual(vzero, v1);
            // Use int index, int length
            for (int i = 0; i <= arr.Length; ++i) {
                int srcCount = i;
                if (srcCount > vcount) srcCount = vcount;
                Vector<T> v = Vectors.CreateRotate(arr, 0, i);
                if (i>0) {
                    for (int j = 0; j < srcCount; ++j) {
                        int pos = j % srcCount;
                        T cur = arr[pos];
                        Assert.AreEqual(cur, v[j]);
                    }
                } else {
                    Assert.AreNotEqual(vzero, v);
                }
            }
        }
    }
}