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
    public class Vector128XTupleTests {
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
            (Vector128<T>, Vector128<T>) tuple = (Vector128s<T>.Demo, Vector128s.Create<T>(src));
            Vector128X2<T> vx = Vector128XTuple.Create(tuple);
            Console.WriteLine($"Vector128XTuple.Create:\t{vx}");
            Vector128X2<byte> vxByte = vx.AsByte();
            Console.WriteLine($"AsByte:\t{vxByte}");
            if (Vector<T>.Count == Vector128<T>.Count) {
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
            (Vector128<T>, Vector128<T>, Vector128<T>, Vector128<T>, Vector128<T>, Vector128<T>, Vector128<T>, Vector128<T>) tuple =
                (Vector128s<T>.Demo, Vector128s.Create<T>(src), Vector128s<T>.V3, Vector128s<T>.V4, Vector128s<T>.V5, Vector128s<T>.V6, Vector128s<T>.V7, Vector128s<T>.V8);
            Vector128X8<T> vx = Vector128XTuple.Create(tuple);
            Console.WriteLine($"Vector128XTuple.Create:\t{vx}");
            //Vector128X8<byte> vxByte = vx.AsByte();
            //Console.WriteLine($"AsByte:\t{vxByte}");
            //if (Vector<T>.Count == Vector128<T>.Count) {
            //    VectorX8<byte> vScalable = vxByte.AsVector();
            //    Console.WriteLine($"AsVector:\t{vScalable}");
            //}
        }

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
