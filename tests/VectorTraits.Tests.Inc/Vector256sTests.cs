using NUnit.Framework;
#if !USED_NUNIT3
using NUnit.Framework.Legacy;
#endif
using System;
using System.Collections.Generic;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using System.IO;
using System.Text;
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Tests {
#if USED_NUNIT3
    using ClassicAssert = Assert;
#endif

    [TestFixture()]
    public class Vector256sTests {
#if NETCOREAPP3_0_OR_GREATER

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
        public void CreatePaddingTest<T>(T src) where T : struct {
            Vector256<T> vzero = Vector256<T>.Zero;
            T zero = default;
            // params
            Vector256<T> v1 = Vector256s.CreatePadding(src);
            Vector256<T> v2 = Vector256s.CreatePadding(src, src);
            ClassicAssert.AreNotEqual(vzero, v1);
            ClassicAssert.AreNotEqual(vzero, v2);
            // []
            int vcount = Vector256<T>.Count;
            T[] arr = new T[vcount + 1];
            VectorTextUtil.Fill(arr, src);
            v1 = Vector256s.CreatePadding(arr);
            ClassicAssert.AreNotEqual(vzero, v1);
            // Use int index, int length
            for (int i = 0; i <= arr.Length; ++i) {
                int srcCount = i;
                if (srcCount > vcount) srcCount = vcount;
                Vector256<T> v = Vector256s.CreatePadding(arr, 0, i);
                for (int j = 0; j < srcCount; ++j) {
                    ClassicAssert.AreEqual(src, v.GetElement(j));
                }
                for (int j = srcCount; j < vcount; ++j) {
                    ClassicAssert.AreEqual(zero, v.GetElement(j));
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
            Vector256<T> vzero = Vector256<T>.Zero;
            // params
            Vector256<T> v1 = Vector256s.CreateRotate(src);
            Vector256<T> v2 = Vector256s.CreateRotate(src, src);
            ClassicAssert.AreNotEqual(vzero, v1);
            ClassicAssert.AreNotEqual(vzero, v2);
            // []
            int vcount = Vector256<T>.Count;
            T[] arr = new T[vcount + 1];
            arr[0] = src;
            v1 = Vector256s.CreateRotate(arr);
            ClassicAssert.AreNotEqual(vzero, v1);
            // Use int index, int length
            for (int i = 0; i <= arr.Length; ++i) {
                int srcCount = i;
                if (srcCount > vcount) srcCount = vcount;
                Vector256<T> v = Vector256s.CreateRotate(arr, 0, i);
                if (i > 0) {
                    for (int j = 0; j < srcCount; ++j) {
                        int pos = j % srcCount;
                        T cur = arr[pos];
                        ClassicAssert.AreEqual(cur, v.GetElement(j));
                    }
                } else {
                    ClassicAssert.AreNotEqual(vzero, v);
                }
            }
        }

        [Test]
        public void TraitsInstances_SourceTest([ValueSource(typeof(Vector256s), nameof(Vector256s.TraitsInstances))] IWVectorTraits256 instances) {
            ClassicAssert.Pass(instances.GetType().Name);
        }
#endif
    }
}
