using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.Numerics;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Tests.Impl.IVectorTraitsTest {
    [TestFixture()]
    public class VectorTests_E {
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
        public void ExtractMostSignificantBitsTest<T>(T src) where T : struct {
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.ExtractMostSignificantBits_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            bool allowLog = true;
            //bool allowLogItem = Scalars<T>.ExponentBits > 0;
            bool allowLogItem = false;
            Vector<T>[] samples = {
                Vectors.Create(src),
                Vectors<T>.V_1,
                Vectors<T>.Demo,
                Vectors<T>.InterlacedSign,
                Vectors<T>.InterlacedSignNegative,
                Vectors<T>.XyzwAddress0Mask
            };
            foreach (Vector<T> vector in samples) {
#if NETX_0_OR_GREATER
                ulong expected = Vector.ExtractMostSignificantBits((dynamic)vector);
#else
                ulong expected = Vectors.ExtractMostSignificantBits((dynamic)vector);
#endif // NETX_0_OR_GREATER
                if (allowLog) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", vector));
                    Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                }
                foreach (IVectorTraits instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    ulong dst = instance.ExtractMostSignificantBits((dynamic)vector);
                    if (allowLogItem) {
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, vector={vector}");
                    }
                }
            }
        }


#endif
    }
}
