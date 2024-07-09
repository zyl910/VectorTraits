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
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseExInt128))]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseExUInt128))]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseInt128))]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseUInt128))]
        public void CreatePaddingTest<T>(T src) where T : struct {
            Vector256<T> vzero = Vector256s<T>.Zero;
            T zero = default;
            // params
            Vector256<T> v1 = Vector256s.CreatePadding(src);
            Vector256<T> v2 = Vector256s.CreatePadding(src, src);
            ClassicAssert.AreNotEqual(vzero.ExAsByte(), v1.ExAsByte());
            ClassicAssert.AreNotEqual(vzero.ExAsByte(), v2.ExAsByte());
            // []
            int vcount = Vector256s<T>.Count;
            T[] arr = new T[vcount + 1];
            VectorTextUtil.Fill(arr, src);
            v1 = Vector256s.CreatePadding(arr);
            ClassicAssert.AreNotEqual(vzero.ExAsByte(), v1.ExAsByte());
            // Use int index, int length
            for (int i = 0; i <= arr.Length; ++i) {
                int srcCount = i;
                if (srcCount > vcount) srcCount = vcount;
                Vector256<T> v = Vector256s.CreatePadding(arr, 0, i);
                for (int j = 0; j < srcCount; ++j) {
                    ClassicAssert.AreEqual(src, v.ExGetElement(j));
                }
                for (int j = srcCount; j < vcount; ++j) {
                    ClassicAssert.AreEqual(zero, v.ExGetElement(j));
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
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseExInt128))]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseExUInt128))]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseInt128))]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseUInt128))]
        public void CreateRotateTest<T>(T src) where T : struct {
            Vector256<T> vzero = Vector256s<T>.Zero;
            // params
            Vector256<T> v1 = Vector256s.CreateRotate(src);
            Vector256<T> v2 = Vector256s.CreateRotate(src, src);
            ClassicAssert.AreNotEqual(vzero.ExAsByte(), v1.ExAsByte());
            ClassicAssert.AreNotEqual(vzero.ExAsByte(), v2.ExAsByte());
            // []
            int vcount = Vector256s<T>.Count;
            T[] arr = new T[vcount + 1];
            arr[0] = src;
            v1 = Vector256s.CreateRotate(arr);
            ClassicAssert.AreNotEqual(vzero.ExAsByte(), v1.ExAsByte());
            // Use int index, int length
            for (int i = 0; i <= arr.Length; ++i) {
                int srcCount = i;
                if (srcCount > vcount) srcCount = vcount;
                Vector256<T> v = Vector256s.CreateRotate(arr, 0, i);
                if (i > 0) {
                    for (int j = 0; j < srcCount; ++j) {
                        int pos = j % srcCount;
                        T cur = arr[pos];
                        ClassicAssert.AreEqual(cur, v.ExGetElement(j));
                    }
                } else {
                    ClassicAssert.AreNotEqual(vzero.ExAsByte(), v.ExAsByte());
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
