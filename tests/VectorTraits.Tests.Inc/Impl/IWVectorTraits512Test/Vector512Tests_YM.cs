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
    public class Vector512Tests_YM {
#if NET8_0_OR_GREATER

        [TestCase((float)1)]
        [TestCase((double)2)]
        public void YMaxNumberTest<T>(T src) where T : struct {
            var writer = Console.Out;
            writer.WriteLine("[Vector512-YMaxNumberTest<{0}>({1})]", typeof(T).Name, src);
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YMaxNumber_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector512<T>[] samples = {
                Vector512s.Create(src),
                Vector512s<T>.Demo,
                Vector512s<T>.Serial,
                Vector512s<T>.SerialNegative,
                Vector512s<T>.XyXMask,
                Vector512s<T>.XyYMask,
                Vector512s<T>.XyzwXMask
            };
            bool allowLog = false;
            bool showNotEquals = false;
            //bool showNotEquals = Scalars<T>.ExponentBits > 0;
            foreach (Vector512<T> left in samples) {
                foreach (Vector512<T> right in samples) {
                    Vector512<T> expected = Vector512s.YMaxNumber((dynamic)left, (dynamic)right);
                    bool usedWrite = false;
                    foreach (IWVectorTraits512 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        string funcName = instance.GetType().Name;
                        Vector512<T> dst = instance.YMaxNumber((dynamic)left, (dynamic)right);
                        bool showLog = allowLog;
                        if (!expected.Equals(dst)) {
                            if (showNotEquals) {
                                showLog = true;
                            }
                        }
                        if (showLog) {
                            if (!usedWrite) {
                                usedWrite = true;
                                writer.WriteLine();
                                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}, {1}", left, right));
                                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                            }
                            dst = instance.YMaxNumber((dynamic)left, (dynamic)right); // [Debug] It is easy to debug the function again.
                            writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}", funcName, dst));
                        } else {
                            ClassicAssert.AreEqual(expected.AsByte(), dst.AsByte(), $"{funcName}, left={left}, right={right}");
                        }
                    }
                }
            }
        }

        [TestCase((float)1)]
        [TestCase((double)2)]
        public void YMinNumberTest<T>(T src) where T : struct {
            var writer = Console.Out;
            writer.WriteLine("[Vector512-YMinNumberTest<{0}>({1})]", typeof(T).Name, src);
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YMinNumber_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector512<T>[] samples = {
                Vector512s.Create(src),
                Vector512s<T>.Demo,
                Vector512s<T>.Serial,
                Vector512s<T>.SerialNegative,
                Vector512s<T>.XyXMask,
                Vector512s<T>.XyYMask,
                Vector512s<T>.XyzwXMask
            };
            bool allowLog = false;
            bool showNotEquals = false;
            //bool showNotEquals = Scalars<T>.ExponentBits > 0;
            foreach (Vector512<T> left in samples) {
                foreach (Vector512<T> right in samples) {
                    Vector512<T> expected = Vector512s.YMinNumber((dynamic)left, (dynamic)right);
                    bool usedWrite = false;
                    foreach (IWVectorTraits512 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        string funcName = instance.GetType().Name;
                        Vector512<T> dst = instance.YMinNumber((dynamic)left, (dynamic)right);
                        bool showLog = allowLog;
                        if (!expected.Equals(dst)) {
                            if (showNotEquals) {
                                showLog = true;
                            }
                        }
                        if (showLog) {
                            if (!usedWrite) {
                                usedWrite = true;
                                writer.WriteLine();
                                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}, {1}", left, right));
                                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                            }
                            dst = instance.YMinNumber((dynamic)left, (dynamic)right); // [Debug] It is easy to debug the function again.
                            writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}", funcName, dst));
                        } else {
                            ClassicAssert.AreEqual(expected.AsByte(), dst.AsByte(), $"{funcName}, left={left}, right={right}");
                        }
                    }
                }
            }
        }

#endif
    }
}
