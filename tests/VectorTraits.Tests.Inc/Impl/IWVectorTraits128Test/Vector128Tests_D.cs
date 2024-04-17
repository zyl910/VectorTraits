using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.Numerics;
using System.IO;

#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Tests.Impl.IWVectorTraits128Test {
    [TestFixture()]
    public class Vector128Tests_D {
#if NETCOREAPP3_0_OR_GREATER

        [TestCase((float)1)]
        [TestCase((double)2)]
        public void DivideTest<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.Divide_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector128<T>[] samples = {
                Vector128s.Create(src),
                Vector128s<T>.Demo,
                Vector128s<T>.V2,
                Vector128s<T>.Serial,
                Vector128s<T>.SerialNegative
            };
            foreach (Vector128<T> left in samples) {
                foreach (Vector128<T> right in samples) {
#if NET7_0_OR_GREATER
                    Vector128<T> expected = Vector128.Divide(left, right);
#else
                    Vector128<T> expected = Vector128s.Divide((dynamic)left, (dynamic)right);
#endif // NET7_0_OR_GREATER
                    foreach (IWVectorTraits128 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        Vector128<T> dst = instance.Divide((dynamic)left, (dynamic)right);
                        if (Scalars<T>.ExponentBits > 0) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, left={2}, right={3}", instance.GetType().Name, dst, left, right));
                        } else {
                            Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, left={left}, right={right}");
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
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.Dot_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector128<T>[] samples = {
                Vector128s.Create(src),
                Vector128s<T>.Demo,
                Vector128s<T>.V2,
                Vector128s<T>.Serial,
                Vector128s<T>.SerialNegative
            };
            bool isCompatible = Scalars<T>.ExponentBits > 0; // Compatible floating-point NaN.
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector128<T> left in samples) {
                foreach (Vector128<T> right in samples) {
#if NET7_0_OR_GREATER
                    T expected = Vector128.Dot(left, right);
#else
                    T expected = Vector128s.Dot((dynamic)left, (dynamic)right);
#endif // NET7_0_OR_GREATER
                    foreach (IWVectorTraits128 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        T dst = instance.Dot((dynamic)left, (dynamic)right);
                        bool usedWrite = allowLog;
                        if (!usedWrite && !expected.Equals(dst)) {
                            if (showNotEquals || isCompatible) {
                                usedWrite = true;
                            } else {
                                Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, left={left}, right={right}");
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
