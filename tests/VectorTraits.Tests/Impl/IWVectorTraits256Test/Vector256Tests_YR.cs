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
using Zyl.VectorTraits.Impl.AVector256;

namespace Zyl.VectorTraits.Tests.Impl.IWVectorTraits256Test {
    [TestFixture()]
    public class Vector256Tests_YR {
#if NETCOREAPP3_0_OR_GREATER

        [TestCase((float)1)]
        [TestCase((double)2)]
        public void YRoundToZeroTest<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.YRoundToZero_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector256<T>[] samples = {
                Vector256s<T>.Serial,
                Vector256s.CreateByDoubleLoop<T>(-0.5, 1),
                Vector256s.CreateByDoubleLoop<T>(-0.5, -1),
                Vector256s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src) + 0.4, 0.3),
                Vector256s<T>.Demo,
                Vector256s<T>.DemoNaN,
            };
            foreach (Vector256<T> value in samples) {
                Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector256<T> expected = WVectorTraits256Base.Statics.YRoundToZero((dynamic)value);
                Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits256 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector256<T> dst = instance.YRoundToZero((dynamic)value);
                    Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                }
                Console.WriteLine();
            }
        }


#endif
    }
}
