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
    public class Vector512Tests_D {
#if NET8_0_OR_GREATER

        [TestCase((float)1)]
        [TestCase((double)2)]
        public void DivideTest<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.Divide_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector512<T>[] samples = {
                Vector512s.Create(src),
                Vector512s<T>.Demo,
                Vector512s<T>.V2,
                Vector512s<T>.Serial,
                Vector512s<T>.SerialNegative
            };
            foreach (Vector512<T> left in samples) {
                foreach (Vector512<T> right in samples) {
#if NET7_0_OR_GREATER
                    Vector512<T> expected = Vector512.Divide(left, right);
#else
                    Vector512<T> expected = Vector512s.Divide((dynamic)left, (dynamic)right);
#endif // NET7_0_OR_GREATER
                    foreach (IWVectorTraits512 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        Vector512<T> dst = instance.Divide((dynamic)left, (dynamic)right);
                        if (Scalars<T>.ExponentBits > 0) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, left={2}, right={3}", instance.GetType().Name, dst, left, right));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, left={left}, right={right}");
                        }
                    }
                }
            }
        }

        [TestCase((float)1)]
        [TestCase((double)2)]
        [TestCase((sbyte)3)]
        [TestCase((byte)4)]
        [TestCase((short)5)]
        [TestCase((ushort)6)]
        [TestCase((int)7)]
        [TestCase((uint)8)]
        [TestCase((long)9)]
        [TestCase((ulong)10)]
        public void DotTest<T>(T src) where T : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.Dot_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector512<T>[] samples = {
                Vector512s.Create(src),
                Vector512s<T>.Demo,
                Vector512s<T>.V2,
                Vector512s<T>.Serial,
                Vector512s<T>.SerialNegative
            };
            bool isCompatible = Scalars<T>.ExponentBits > 0; // Compatible floating-point NaN.
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector512<T> left in samples) {
                foreach (Vector512<T> right in samples) {
#if NET7_0_OR_GREATER
                    T expected = Vector512.Dot(left, right);
#else
                    T expected = Vector512s.Dot((dynamic)left, (dynamic)right);
#endif // NET7_0_OR_GREATER
                    foreach (IWVectorTraits512 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        T dst = instance.Dot((dynamic)left, (dynamic)right);
                        bool usedWrite = allowLog;
                        if (!usedWrite && !expected.Equals(dst)) {
                            if (showNotEquals || isCompatible) {
                                usedWrite = true;
                            } else {
                                ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, left={left}, right={right}");
                            }
                        }
                        if (usedWrite) {
                            writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}, left={2}, right={3}", instance.GetType().Name, dst, left, right));
                        }
                    }
                }
            }
        }

#endif
    }
}
