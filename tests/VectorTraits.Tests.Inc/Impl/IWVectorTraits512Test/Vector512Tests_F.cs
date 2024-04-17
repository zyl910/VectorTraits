using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Tests.Impl.IWVectorTraits512Test {
    [TestFixture()]
    public class Vector512Tests_F {
#if NET8_0_OR_GREATER

        [TestCase((float)1)]
        [TestCase((double)2)]
        public void FloorTest<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.Floor_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector512<T>[] samples = {
                Vector512s<T>.Demo,
                Vector512s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src) + 0.4, 0.3)
            };
            foreach (Vector512<T> value in samples) {
                Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector512<T> expected = Vector512s.Floor((dynamic)value);
                Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits512 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector512<T> dst = instance.Floor((dynamic)value);
                    Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                }
            }
        }

#endif
    }
}
