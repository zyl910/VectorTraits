using NUnit.Framework;
#if !USED_NUNIT3
using NUnit.Framework.Legacy;
#endif
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Tests {
#if USED_NUNIT3
    using ClassicAssert = Assert;
#endif

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
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseExInt128))]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseExUInt128))]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseInt128))]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseUInt128))]
        public void CreatePaddingTest<T>(T src) where T : struct {
            Vector<T> vzero = Vectors<T>.Zero;
            T zero = default;
            // params
            Vector<T> v1 = Vectors.CreatePadding(src);
            Vector<T> v2 = Vectors.CreatePadding(src, src);
            ClassicAssert.AreNotEqual(vzero.ExAsByte(), v1.ExAsByte());
            ClassicAssert.AreNotEqual(vzero.ExAsByte(), v2.ExAsByte());
            // []
            int vcount = Vectors<T>.Count;
            T[] arr = new T[vcount + 1];
            VectorTextUtil.Fill(arr, src);
            v1 = Vectors.CreatePadding(arr);
            ClassicAssert.AreNotEqual(vzero.ExAsByte(), v1.ExAsByte());
            // Use int index, int length
            for (int i = 0; i <= arr.Length; ++i) {
                int srcCount = i;
                if (srcCount > vcount) srcCount = vcount;
                Vector<T> v = Vectors.CreatePadding(arr, 0, i);
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
            Vector<T> vzero = Vectors<T>.Zero;
            // params
            Vector<T> v1 = Vectors.CreateRotate(src);
            Vector<T> v2 = Vectors.CreateRotate(src, src);
            ClassicAssert.AreNotEqual(vzero.ExAsByte(), v1.ExAsByte());
            ClassicAssert.AreNotEqual(vzero.ExAsByte(), v2.ExAsByte());
            // []
            int vcount = Vectors<T>.Count;
            T[] arr = new T[vcount + 1];
            arr[0] = src;
            v1 = Vectors.CreateRotate(arr);
            ClassicAssert.AreNotEqual(vzero.ExAsByte(), v1.ExAsByte());
            // Use int index, int length
            for (int i = 0; i <= arr.Length; ++i) {
                int srcCount = i;
                if (srcCount > vcount) srcCount = vcount;
                Vector<T> v = Vectors.CreateRotate(arr, 0, i);
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
            var funcList = Vectors.GetSupportedMethodList<Func<Vector<T>, int, Vector<T>>>("ShiftLeft_Base", "ShiftLeft_Multiply");
            foreach (var func in funcList) {
                Console.WriteLine(ReflectionUtil.GetShortNameWithType(func.Method));
            }
        }


    }
}
