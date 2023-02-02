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

namespace Zyl.VectorTraits.Tests.Impl.IWVectorTraits256Test {
    [TestFixture()]
    public class Vector256Tests_D {
#if NETCOREAPP3_0_OR_GREATER

        [TestCase((float)1)]
        [TestCase((double)2)]
        public void DivideTest<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                if (instance.IsSupported) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.Divide_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector256<T>[] samples = {
                Vector256s.Create(src),
                Vector256s<T>.Demo,
                Vector256s<T>.V2,
                Vector256s<T>.Serial,
                Vector256s<T>.SerialNegative
            };
            foreach (Vector256<T> left in samples) {
                foreach (Vector256<T> right in samples) {
#if NET7_0_OR_GREATER
                    Vector256<T> expected = Vector256.Divide(left, right);
#else
                    Vector256<T> expected = Vector256s.Divide((dynamic)left, (dynamic)right);
#endif // NET7_0_OR_GREATER
                    foreach (IWVectorTraits256 instance in instances) {
                        if (!instance.IsSupported) continue;
                        Vector256<T> dst = instance.Divide((dynamic)left, (dynamic)right);
                        if (Scalars<T>.ExponentBits > 0) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, left={2}, right={3}", instance.GetType().Name, dst, left, right));
                        } else {
                            Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, left={left}, right={right}");
                        }
                    }
                }
            }
        }

#endif
    }
}
