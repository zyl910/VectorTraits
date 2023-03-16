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
    public class Vector128Tests_YN {
#if NETCOREAPP3_0_OR_GREATER

        [TestCase((short)5, (sbyte)1)]
        [TestCase((ushort)6, (byte)1)]
        [TestCase((int)7, (short)1)]
        [TestCase((uint)8, (ushort)1)]
        [TestCase((long)9, (int)1)]
        [TestCase((ulong)10, (uint)1)]
        public void YNarrowSaturateTest<T, TOut>(T src, TOut srcOut) where T : struct where TOut : struct {
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1}); Full=({2})", instance.GetType().Name, instance.YNarrowSaturate_AcceleratedTypes, instance.YNarrowSaturate_FullAcceleratedTypes));
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
                Vector128s<T>.InterlacedSignNegative,
                Vector128s<T>.XyXMask,
                Vector128s<T>.XyzwXMask
            };
            bool allowLog = false;
            for (int i = 0; i < samples.Length; i += 2) {
                Vector128<T> lower = samples[i];
                Vector128<T> upper = samples[i+1];
                Vector128<TOut> expected = Vector128s.YNarrowSaturate((dynamic)lower, (dynamic)upper);
                if (allowLog) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}, {1}", lower, upper));
                    Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                }
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<TOut> dst = instance.YNarrowSaturate((dynamic)lower, (dynamic)upper);
                    Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, lower={lower}, upper={upper}");
                }
            }
        }

        [TestCase((short)5, (byte)1)]
        [TestCase((int)7, (ushort)1)]
        [TestCase((long)9, (uint)1)]
        public void YNarrowSaturateUnsignedTest<T, TOut>(T src, TOut srcOut) where T : struct where TOut : struct {
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1}); Full=({2})", instance.GetType().Name, instance.YNarrowSaturateUnsigned_AcceleratedTypes, instance.YNarrowSaturateUnsigned_FullAcceleratedTypes));
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
                Vector128s<T>.InterlacedSignNegative,
                Vector128s<T>.XyXMask,
                Vector128s<T>.XyzwXMask
            };
            bool allowLog = false;
            for (int i = 0; i < samples.Length; i += 2) {
                Vector128<T> lower = samples[i];
                Vector128<T> upper = samples[i+1];
                Vector128<TOut> expected = Vector128s.YNarrowSaturateUnsigned((dynamic)lower, (dynamic)upper);
                if (allowLog) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}, {1}", lower, upper));
                    Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                }
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<TOut> dst = instance.YNarrowSaturateUnsigned((dynamic)lower, (dynamic)upper);
                    Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, lower={lower}, upper={upper}");
                }
            }
        }


#endif
    }
}
