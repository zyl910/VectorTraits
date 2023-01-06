using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Xml.Linq;
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Tests.Impl.IVectorTraitsTest {
    [TestFixture()]
    public class VectorTests_C {
#if NETCOREAPP3_0_OR_GREATER

        [TestCase((float)1)]
        [TestCase((double)2)]
        public void CeilingTest<T>(T src) where T : struct {
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.IsSupported) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.Ceiling_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector<T>[] samples = {
                Vectors<T>.Demo,
                Vectors.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src) + 0.4, 0.2)
            };
            foreach (Vector<T> value in samples) {
                Console.WriteLine($"Samples: {value}\t// {VectorTextUtil.GetHex(value)}");
                Vector<T> expected = Vectors.Ceiling((dynamic)value);
                Console.WriteLine($"Vectors.Ceiling: {expected}\t// {VectorTextUtil.GetHex(expected)}");
                foreach (IVectorTraits instance in instances) {
                    if (!instance.IsSupported) continue;
                    Vector<T> dst = instance.Ceiling((dynamic)value);
                    Console.WriteLine($"{instance.GetType().Name}: {dst}\t// {VectorTextUtil.GetHex(dst)}");
                }
            }
        }

#endif
    }
}
