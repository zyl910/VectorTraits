using NUnit.Framework;
using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Text;
using Zyl.VectorTraits;
using Zyl.VectorTraits.Numerics;

namespace Zyl.VectorTraits.Tests.Numerics {
    [TestFixture()]
    internal class MathBinaryPrimitivesTests {

        [TestCase((sbyte)3)]
        [TestCase((byte)4)]
        [TestCase((short)5)]
        [TestCase((ushort)6)]
        [TestCase((int)7)]
        [TestCase((uint)8)]
        [TestCase((long)9)]
        [TestCase((ulong)10)]
        public void ReverseEndiannessTest<T>(T src) where T : struct {
            // run.
            for (int i = 0; i < 0x1000; ++i) {
                T value = Scalars.GetByDouble<T>(i);
                T dst = MathBinaryPrimitives.ReverseEndianness((dynamic)value);
                T expected;
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
                expected = BinaryPrimitives.ReverseEndianness((dynamic)value);
#else
                expected = dst;
#endif
                Assert.AreEqual(expected, dst, $"{value}");
            }
        }

    }
}
