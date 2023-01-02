using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif // NETCOREAPP3_0_OR_GREATER
using Zyl.VectorTraits.Tuples;

namespace Zyl.VectorTraits.Tests.Tuples {
    [TestFixture()]
    public class Vector256XTupleTests {
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
        public void AsByteTest<T>(T src) where T : struct {
            (Vector256<T>, Vector256<T>) tuple = (Vector256s<T>.Demo, Vector256s.Create<T>(src));
            Vector256X2<T> vx = Vector256XTuple.Create(tuple);
            Console.WriteLine($"Vector256XTuple.Create:\t{vx}");
            Vector256X2<byte> vxByte = vx.AsByte();
            Console.WriteLine($"AsByte:\t{vxByte}");
            if (Vector<T>.Count == Vector256<T>.Count) {
                VectorX2<byte> vScalable = vxByte.AsVector();
                Console.WriteLine($"AsVector:\t{vScalable}");
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
        public void AsByteX8Test<T>(T src) where T : struct {
            (Vector256<T>, Vector256<T>, Vector256<T>, Vector256<T>, Vector256<T>, Vector256<T>, Vector256<T>, Vector256<T>) tuple =
                (Vector256s<T>.Demo, Vector256s.Create<T>(src), Vector256s<T>.V3, Vector256s<T>.V4, Vector256s<T>.V5, Vector256s<T>.V6, Vector256s<T>.V7, Vector256s<T>.V8);
            Vector256X8<T> vx = Vector256XTuple.Create(tuple);
            Console.WriteLine($"Vector256XTuple.Create:\t{vx}");
            Vector256X8<byte> vxByte = vx.AsByte();
            Console.WriteLine($"AsByte:\t{vxByte}");
            if (Vector<T>.Count == Vector256<T>.Count) {
                VectorX8<byte> vScalable = vxByte.AsVector();
                Console.WriteLine($"AsVector:\t{vScalable}");
            }
        }

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
