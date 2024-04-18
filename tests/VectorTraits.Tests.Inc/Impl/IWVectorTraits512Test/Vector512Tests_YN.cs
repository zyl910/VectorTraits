using NUnit.Framework;
#if !USED_NUNIT3
using NUnit.Framework.Legacy;
#endif
using System;
using System.Collections.Generic;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using System.IO;
using System.Text;
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Tests.Impl.IWVectorTraits512Test {
#if USED_NUNIT3
    using ClassicAssert = Assert;
#endif

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
            TextWriter writer = Console.Out;
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1}); Full=({2})", instance.GetType().Name, instance.YNarrowSaturate_AcceleratedTypes, instance.YNarrowSaturate_FullAcceleratedTypes));
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector512s.GetSupportedMethodList<Func<Vector512<T>, Vector512<T>, Vector512<TOut>>>("YNarrowSaturate_Basic", "YNarrowSaturate_Clamp", "YNarrowSaturate_Convert", "YNarrowSaturate_Pack");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
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
            bool allowLogItem = allowLog;
            for (int i = 0; i < samples.Length; i += 2) {
                Vector512<T> lower = samples[i];
                Vector512<T> upper = samples[i+1];
                Vector512<TOut> expected = Vector512s.YNarrowSaturate((dynamic)lower, (dynamic)upper);
                if (allowLog) {
                    writer.WriteLine();
                    writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}, {1}", lower, upper));
                    writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                }
                foreach (IWVectorTraits512 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector512<TOut> dst = instance.YNarrowSaturate((dynamic)lower, (dynamic)upper);
                    ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, lower={lower}, upper={upper}");
                }
                foreach (var func in funcList) {
                    string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                    Vector512<TOut> dst = func(lower, upper);
                    if (allowLogItem) {
                        writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}, lower={2}, upper={3}", funcName, dst, lower, upper));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"{funcName}, lower={lower}, upper={upper}");
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
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1}); Full=({2})", instance.GetType().Name, instance.YNarrowSaturateUnsigned_AcceleratedTypes, instance.YNarrowSaturateUnsigned_FullAcceleratedTypes));
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector512s.GetSupportedMethodList<Func<Vector512<T>, Vector512<T>, Vector512<TOut>>>("YNarrowSaturateUnsigned_Basic", "YNarrowSaturateUnsigned_Clamp", "YNarrowSaturateUnsigned_Convert", "YNarrowSaturateUnsigned_Pack");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
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
            bool allowLogItem = allowLog;
            for (int i = 0; i < samples.Length; i += 2) {
                Vector512<T> lower = samples[i];
                Vector512<T> upper = samples[i+1];
                Vector512<TOut> expected = Vector512s.YNarrowSaturateUnsigned((dynamic)lower, (dynamic)upper);
                if (allowLog) {
                    writer.WriteLine();
                    writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}, {1}", lower, upper));
                    writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                }
                foreach (IWVectorTraits512 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector512<TOut> dst = instance.YNarrowSaturateUnsigned((dynamic)lower, (dynamic)upper);
                    ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, lower={lower}, upper={upper}");
                }
                foreach (var func in funcList) {
                    string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                    Vector512<TOut> dst = func(lower, upper);
                    if (allowLogItem) {
                        writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}, lower={2}, upper={3}", funcName, dst, lower, upper));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"{funcName}, lower={lower}, upper={upper}");
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
