using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Numerics;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using System.Text;
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Tests.Impl {
    [TestFixture()]
    public class Vector256ConstantsTests {
#if NETCOREAPP3_0_OR_GREATER

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
                Vector256<T> expected = Vector256s<T>.GetMaskBits(i);
#pragma warning disable CS0618 // Type or member is obsolete
                Vector256<T> dst = Vector256Constants.GetMaskBits<T>(i);
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
                Vector256<T> expected = Vector256s<T>.GetMaskBits(BitSize - i);
#pragma warning disable CS0618 // Type or member is obsolete
                Vector256<T> dst = Vector256Constants.GetResidueMaskBits<T>(i);
#pragma warning restore CS0618 // Type or member is obsolete
                Assert.AreEqual(expected, dst, $"index={i}");
            }
        }

#endif
    }
}
