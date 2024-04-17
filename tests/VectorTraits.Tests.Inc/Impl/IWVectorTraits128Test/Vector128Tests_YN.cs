using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.IO;

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
            TextWriter writer = Console.Out;
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1}); Full=({2})", instance.GetType().Name, instance.YNarrowSaturate_AcceleratedTypes, instance.YNarrowSaturate_FullAcceleratedTypes));
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector128s.GetSupportedMethodList<Func<Vector128<T>, Vector128<T>, Vector128<TOut>>>("YNarrowSaturate_Basic", "YNarrowSaturate_Clamp", "YNarrowSaturate_Convert", "YNarrowSaturate_Pack");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
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
            bool allowLogItem = allowLog;
            for (int i = 0; i < samples.Length; i += 2) {
                Vector128<T> lower = samples[i];
                Vector128<T> upper = samples[i + 1];
                Vector128<TOut> expected = Vector128s.YNarrowSaturate((dynamic)lower, (dynamic)upper);
                if (allowLog) {
                    writer.WriteLine();
                    writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}, {1}", lower, upper));
                    writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                }
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<TOut> dst = instance.YNarrowSaturate((dynamic)lower, (dynamic)upper);
                    Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, lower={lower}, upper={upper}");
                }
                foreach (var func in funcList) {
                    string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                    Vector128<TOut> dst = func(lower, upper);
                    if (allowLogItem) {
                        writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}, lower={2}, upper={3}", funcName, dst, lower, upper));
                    } else {
                        Assert.AreEqual(expected, dst, $"{funcName}, lower={lower}, upper={upper}");
                    }
                } // funcList
                if (allowLog) {
                    writer.WriteLine();
                }
            }
        }

        [TestCase((short)5, (byte)1)]
        [TestCase((int)7, (ushort)1)]
        [TestCase((long)9, (uint)1)]
        public void YNarrowSaturateUnsignedTest<T, TOut>(T src, TOut srcOut) where T : struct where TOut : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1}); Full=({2})", instance.GetType().Name, instance.YNarrowSaturateUnsigned_AcceleratedTypes, instance.YNarrowSaturateUnsigned_FullAcceleratedTypes));
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector128s.GetSupportedMethodList<Func<Vector128<T>, Vector128<T>, Vector128<TOut>>>("YNarrowSaturateUnsigned_Basic", "YNarrowSaturateUnsigned_Clamp", "YNarrowSaturateUnsigned_Convert", "YNarrowSaturateUnsigned_Pack");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
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
            bool allowLogItem = allowLog;
            for (int i = 0; i < samples.Length; i += 2) {
                Vector128<T> lower = samples[i];
                Vector128<T> upper = samples[i + 1];
                Vector128<TOut> expected = Vector128s.YNarrowSaturateUnsigned((dynamic)lower, (dynamic)upper);
                if (allowLog) {
                    writer.WriteLine();
                    writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}, {1}", lower, upper));
                    writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                }
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<TOut> dst = instance.YNarrowSaturateUnsigned((dynamic)lower, (dynamic)upper);
                    Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, lower={lower}, upper={upper}");
                }
                foreach (var func in funcList) {
                    string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                    Vector128<TOut> dst = func(lower, upper);
                    if (allowLogItem) {
                        writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}, lower={2}, upper={3}", funcName, dst, lower, upper));
                    } else {
                        Assert.AreEqual(expected, dst, $"{funcName}, lower={lower}, upper={upper}");
                    }
                } // funcList
                if (allowLog) {
                    writer.WriteLine();
                }
            }
        }


#endif
    }
}
