﻿using NUnit.Framework;
#if !USED_NUNIT3
using NUnit.Framework.Legacy;
#endif
using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Text;
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Tests.Impl {
#if USED_NUNIT3
    using ClassicAssert = Assert;
#endif

    [TestFixture()]
    public class VectorConstantsTests {

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
        public void GetMaskBitsTest<T>(T src) where T : struct {
            int BitSize = Scalars<T>.BitSize;
            int iMax = BitSize - 1;
            _ = src;
            for (int i = 0; i <= iMax; ++i) {
                Vector<T> expected = Vectors<T>.GetMaskBits(i);
#pragma warning disable CS0618 // Type or member is obsolete
                Vector<T> dst = VectorConstants.GetMaskBits<T>(i);
#pragma warning restore CS0618 // Type or member is obsolete
                ClassicAssert.AreEqual(expected.ExAsInt64(), dst.ExAsInt64(), $"index={i}");
                //if (!expected.ExAsInt64().Equals(dst.ExAsInt64())) {
                //    Console.WriteLine(VectorTextUtil.Format("GetMaskBits({0}): {1} != {2}", i, expected, dst));
                //}
            }
        }

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
        public void GetResidueMaskBitsTest<T>(T src) where T : struct {
            int BitSize = Scalars<T>.BitSize;
            int iMax = BitSize - 1;
            _ = src;
            for (int i = 0; i <= iMax; ++i) {
                Vector<T> expected = Vectors<T>.GetMaskBits(BitSize - i);
#pragma warning disable CS0618 // Type or member is obsolete
                Vector<T> dst = VectorConstants.GetResidueMaskBits<T>(i);
#pragma warning restore CS0618 // Type or member is obsolete
                ClassicAssert.AreEqual(expected.ExAsInt64(), dst.ExAsInt64(), $"index={i}");
            }
        }

    }
}
