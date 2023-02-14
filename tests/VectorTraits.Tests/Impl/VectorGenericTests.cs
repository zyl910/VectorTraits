using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Tests.Impl {
    [TestFixture()]
    public class VectorGenericTests {

#if NETCOREAPP3_0_OR_GREATER

        [TestCase((float)1, (double)1)]
        [TestCase((sbyte)3, (short)1)]
        [TestCase((byte)4, (ushort)1)]
        [TestCase((short)5, (int)1)]
        [TestCase((ushort)6, (uint)1)]
        [TestCase((int)7, (long)1)]
        [TestCase((uint)8, (ulong)1)]
        public void WidenTest<T, TOut>(T src, TOut dst) where T : struct where TOut : struct {
#pragma warning disable CS0618 // Type or member is obsolete
            // run.
            Vector<T>[] samples = {
                Vectors.Create(src),
                Vectors<T>.Demo,
                Vectors<T>.InterlacedSign,
                Vectors<T>.XyXMask,
            };
            foreach (Vector<T> soure in samples) {
                Vector<TOut> expected0, expected1;
                VectorGeneric.Widen(soure, out expected0, out expected1);
                Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", soure));
                Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}, {1}", expected0, expected1));
                Console.WriteLine();
            }
#pragma warning restore CS0618 // Type or member is obsolete
        }

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
