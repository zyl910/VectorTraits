#if ALLOW_VECTOR_TUPLES
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Zyl.VectorTraits.Tuples;

namespace Zyl.VectorTraits.Tests.Tuples {
    [TestFixture()]
    public class VectorXTupleTests {

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
        public void AsByteTest<T>(T src) where T : struct {
            (Vector<T>, Vector<T>) tuple = (Vectors<T>.Demo, Vectors.Create<T>(src));
            VectorX2<T> vx = VectorXTuple.Create(tuple);
            Console.WriteLine($"VectorXTuple.Create:\t{vx}");
            VectorX2<byte> vxByte = vx.AsByte();
            Console.WriteLine($"AsByte:\t{vxByte}");
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
        public void AsByteX8Test<T>(T src) where T : struct {
            (Vector<T>, Vector<T>, Vector<T>, Vector<T>, Vector<T>, Vector<T>, Vector<T>, Vector<T>) tuple =
                (Vectors<T>.Demo, Vectors.Create<T>(src), Vectors<T>.V3, Vectors<T>.V4, Vectors<T>.V5, Vectors<T>.V6, Vectors<T>.V7, Vectors<T>.V8);
            VectorX8<T> vx = VectorXTuple.Create(tuple);
            Console.WriteLine($"VectorXTuple.Create:\t{vx}");
            VectorX8<byte> vxByte = vx.AsByte();
            Console.WriteLine($"AsByte:\t{vxByte}");
        }

    }
}
#endif // ALLOW_VECTOR_TUPLES
