using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.Security.Cryptography;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Tests.Impl.IWVectorTraits256Test {
    [TestFixture()]
    public class Vector256Tests_YN {
#if NETCOREAPP3_0_OR_GREATER

        [TestCase((short)5, (sbyte)1)]
        [TestCase((ushort)6, (byte)1)]
        [TestCase((int)7, (short)1)]
        [TestCase((uint)8, (ushort)1)]
        [TestCase((long)9, (int)1)]
        [TestCase((ulong)10, (uint)1)]
        public void YNarrowSaturateTest<T, TOut>(T src, TOut srcOut) where T : struct where TOut : struct {
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1}); Full=({2})", instance.GetType().Name, instance.YNarrowSaturate_AcceleratedTypes, instance.YNarrowSaturate_FullAcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector256<T>[] samples = {
                Vector256s.Create(src),
                Vector256s<T>.Demo,
                Vector256s<T>.Serial,
                Vector256s<T>.SerialNegative,
                Vector256s<T>.InterlacedSign,
                Vector256s<T>.InterlacedSignNegative,
                Vector256s<T>.XyXMask,
                Vector256s<T>.XyzwXMask
            };
            bool allowLog = false;
            for (int i = 0; i < samples.Length; i += 2) {
                Vector256<T> lower = samples[i];
                Vector256<T> upper = samples[i+1];
                Vector256<TOut> expected = Vector256s.YNarrowSaturate((dynamic)lower, (dynamic)upper);
                if (allowLog) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}, {1}", lower, upper));
                    Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                }
                foreach (IWVectorTraits256 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector256<TOut> dst = instance.YNarrowSaturate((dynamic)lower, (dynamic)upper);
                    Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, lower={lower}, upper={upper}");
                }
            }
        }


#endif
    }
}
