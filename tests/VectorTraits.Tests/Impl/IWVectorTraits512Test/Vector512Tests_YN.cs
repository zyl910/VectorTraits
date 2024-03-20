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
    public class Vector512Tests_YN {
#if NET8_0_OR_GREATER

        [TestCase((short)5, (sbyte)1)]
        [TestCase((ushort)6, (byte)1)]
        [TestCase((int)7, (short)1)]
        [TestCase((uint)8, (ushort)1)]
        [TestCase((long)9, (int)1)]
        [TestCase((ulong)10, (uint)1)]
        public void YNarrowSaturateTest<T, TOut>(T src, TOut srcOut) where T : struct where TOut : struct {
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1}); Full=({2})", instance.GetType().Name, instance.YNarrowSaturate_AcceleratedTypes, instance.YNarrowSaturate_FullAcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector512<T>[] samples = {
                Vector512s.Create(src),
                Vector512s<T>.Demo,
                Vector512s<T>.Serial,
                Vector512s<T>.SerialNegative,
                Vector512s<T>.InterlacedSign,
                Vector512s<T>.InterlacedSignNegative,
                Vector512s<T>.XyXMask,
                Vector512s<T>.XyzwXMask
            };
            bool allowLog = false;
            for (int i = 0; i < samples.Length; i += 2) {
                Vector512<T> lower = samples[i];
                Vector512<T> upper = samples[i+1];
                Vector512<TOut> expected = Vector512s.YNarrowSaturate((dynamic)lower, (dynamic)upper);
                if (allowLog) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}, {1}", lower, upper));
                    Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                }
                foreach (IWVectorTraits512 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector512<TOut> dst = instance.YNarrowSaturate((dynamic)lower, (dynamic)upper);
                    Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, lower={lower}, upper={upper}");
                }
            }
        }

        [TestCase((short)5, (byte)1)]
        [TestCase((int)7, (ushort)1)]
        [TestCase((long)9, (uint)1)]
        public void YNarrowSaturateUnsignedTest<T, TOut>(T src, TOut srcOut) where T : struct where TOut : struct {
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1}); Full=({2})", instance.GetType().Name, instance.YNarrowSaturateUnsigned_AcceleratedTypes, instance.YNarrowSaturateUnsigned_FullAcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector512<T>[] samples = {
                Vector512s.Create(src),
                Vector512s<T>.Demo,
                Vector512s<T>.Serial,
                Vector512s<T>.SerialNegative,
                Vector512s<T>.InterlacedSign,
                Vector512s<T>.InterlacedSignNegative,
                Vector512s<T>.XyXMask,
                Vector512s<T>.XyzwXMask
            };
            bool allowLog = false;
            for (int i = 0; i < samples.Length; i += 2) {
                Vector512<T> lower = samples[i];
                Vector512<T> upper = samples[i+1];
                Vector512<TOut> expected = Vector512s.YNarrowSaturateUnsigned((dynamic)lower, (dynamic)upper);
                if (allowLog) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}, {1}", lower, upper));
                    Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                }
                foreach (IWVectorTraits512 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector512<TOut> dst = instance.YNarrowSaturateUnsigned((dynamic)lower, (dynamic)upper);
                    Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, lower={lower}, upper={upper}");
                }
            }
        }


#endif
    }
}
