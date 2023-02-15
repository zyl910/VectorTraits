using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Tests.Impl.IWVectorTraits128Test {
    [TestFixture()]
    public class Vector128Tests_N {
#if NETCOREAPP3_0_OR_GREATER

        [TestCase((float)1)]
        [TestCase((double)2)]
        [TestCase((sbyte)3)]
        [TestCase((short)5)]
        [TestCase((int)7)]
        [TestCase((long)9)]
        public void NegateTest<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.ConditionalSelect_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector128<T>[] samples = {
                Vector128s.Create(src),
                Vector128s<T>.Demo,
                Vector128s<T>.Serial,
                Vector128s<T>.SerialNegative,
                Vector128s<T>.InterlacedSign,
                Vector128s<T>.XyXMask,
                Vector128s<T>.XyzwXMask
            };
            foreach (Vector128<T> vector in samples) {
                Vector128<T> expected = Vector128s.Negate((dynamic)vector);
                if (Scalars<T>.ExponentBits > 0) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", vector));
                    Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                }
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<T> dst = instance.Negate((dynamic)vector);
                    if (Scalars<T>.ExponentBits > 0) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        Assert.AreEqual(expected.AsByte(), dst.AsByte(), $"{instance.GetType().Name}, vector={vector}");
                    }
                }
            }
        }


#endif
    }
}
