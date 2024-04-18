using NUnit.Framework;
#if !USED_NUNIT3
using NUnit.Framework.Legacy;
#endif
using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Text;
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Tests.Impl.IVectorTraitsTest {
#if USED_NUNIT3
    using ClassicAssert = Assert;
#endif

    [TestFixture()]
    public class VectorTests_F {

        [TestCase((float)1)]
        [TestCase((double)2)]
        public void FloorTest<T>(T src) where T : struct {
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.Floor_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector<T>[] samples = {
                Vectors<T>.Demo,
                Vectors.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src) + 0.4, 0.3)
            };
            foreach (Vector<T> value in samples) {
                Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector<T> expected = Vectors.Floor((dynamic)value);
                Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IVectorTraits instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector<T> dst = instance.Floor((dynamic)value);
                    Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                }
            }
        }

    }
}
