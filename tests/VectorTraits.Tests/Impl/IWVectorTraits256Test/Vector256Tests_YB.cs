using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Impl;
using Zyl.VectorTraits.Impl.AVector256;

namespace Zyl.VectorTraits.Tests.Impl.IWVectorTraits256Test {
    [TestFixture()]
    public class Vector256Tests_YB {
#if NETCOREAPP3_0_OR_GREATER


        [TestCase]
        public void YBitToByteTest() {
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.YBitToByte_IsAccelerated}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            List<uint> samples = new List<uint>();
            for (int i=0; i<32; ++i) {
                uint mask = (uint)(i) << i;
                samples.Add(mask);
            }
            foreach (uint mask in samples) {
                Vector256<byte> expected = Vector256s.YBitToByte(mask);
                foreach (IWVectorTraits256 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector256<byte> dst = instance.YBitToByte(mask);
                    Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, mask={mask}");
                }
            }
        }


#endif
    }
}
