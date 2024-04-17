﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Tests.Impl {
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
        public void GetMaskBitsTest<T>(T src) where T : struct {
            int BitSize = Scalars<T>.BitSize;
            int iMax = BitSize - 1;
            _ = src;
            for (int i = 0; i <= iMax; ++i) {
                Vector<T> expected = Vectors<T>.GetMaskBits(i);
#pragma warning disable CS0618 // Type or member is obsolete
                Vector<T> dst = VectorConstants.GetMaskBits<T>(i);
#pragma warning restore CS0618 // Type or member is obsolete
                Assert.AreEqual(expected, dst, $"index={i}");
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
        public void GetResidueMaskBitsTest<T>(T src) where T : struct {
            int BitSize = Scalars<T>.BitSize;
            int iMax = BitSize - 1;
            _ = src;
            for (int i = 0; i <= iMax; ++i) {
                Vector<T> expected = Vectors<T>.GetMaskBits(BitSize - i);
#pragma warning disable CS0618 // Type or member is obsolete
                Vector<T> dst = VectorConstants.GetResidueMaskBits<T>(i);
#pragma warning restore CS0618 // Type or member is obsolete
                Assert.AreEqual(expected, dst, $"index={i}");
            }
        }

    }
}
