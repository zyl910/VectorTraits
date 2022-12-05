using NUnit.Framework;
using Zyl.VectorTraits;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace Zyl.VectorTraits.Tests {
    [TestFixture()]
    public class VectorsTests {

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
        public void CreateRotateTest<T>(T src) where T : struct {
            Vector<T> vzero = Vector<T>.Zero;
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
        public void GetSupportedMethodListTest<T>(T src) where T : struct {
            Console.WriteLine($"src:\t{src}\t//{typeof(T).Name}");
            var list = Vectors.GetSupportedMethodList<Func<Vector<T>, int, Vector<T>>>("ShiftLeft_Base", "ShiftLeft_Multiply");
            foreach (var func in list) {
                Console.WriteLine(func.Method);
            }
        }


    }
}
