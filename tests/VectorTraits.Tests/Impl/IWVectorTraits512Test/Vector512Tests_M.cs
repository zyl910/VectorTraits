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
    public class Vector512Tests_M {
#if NET8_0_OR_GREATER

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
        public void MaxTest<T>(T src) where T : struct {
            var writer = Console.Out;
            writer.WriteLine("[Vector512-MaxTest<{0}>({1})]", typeof(T).Name, src);
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.Max_AcceleratedTypes}");
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
            //bool showNotEquals = false;
            bool showNotEquals = Scalars<T>.ExponentBits > 0;
            foreach (Vector512<T> left in samples) {
                foreach (Vector512<T> right in samples) {
#if NET7_0_OR_GREATER
                    Vector512<T> expected = Vector512.Max(left, right);
#else
                    Vector512<T> expected = Vector512s.Max((dynamic)left, (dynamic)right);
#endif // NET7_0_OR_GREATER
                    bool usedWrite = false;
                    foreach (IWVectorTraits512 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        string funcName = instance.GetType().Name;
                        Vector512<T> dst = instance.Max((dynamic)left, (dynamic)right);
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
                            dst = instance.Max((dynamic)left, (dynamic)right); // [Debug] It is easy to debug the function again.
                            writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}", funcName, dst));
                        } else {
                            Assert.AreEqual(expected.AsByte(), dst.AsByte(), $"{funcName}, left={left}, right={right}");
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
        public void MinTest<T>(T src) where T : struct {
            var writer = Console.Out;
            writer.WriteLine("[Vector512-MinTest<{0}>({1})]", typeof(T).Name, src);
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.Min_AcceleratedTypes}");
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
            //bool showNotEquals = false;
            bool showNotEquals = Scalars<T>.ExponentBits > 0;
            foreach (Vector512<T> left in samples) {
                foreach (Vector512<T> right in samples) {
#if NET7_0_OR_GREATER
                    Vector512<T> expected = Vector512.Min(left, right);
#else
                    Vector512<T> expected = Vector512s.Min((dynamic)left, (dynamic)right);
#endif // NET7_0_OR_GREATER
                    bool usedWrite = false;
                    foreach (IWVectorTraits512 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        string funcName = instance.GetType().Name;
                        Vector512<T> dst = instance.Min((dynamic)left, (dynamic)right);
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
                            dst = instance.Min((dynamic)left, (dynamic)right); // [Debug] It is easy to debug the function again.
                            writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}", funcName, dst));
                        } else {
                            Assert.AreEqual(expected.AsByte(), dst.AsByte(), $"{funcName}, left={left}, right={right}");
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
        public void MultiplyTest<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.Multiply_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector512<T>[] samples = {
                Vector512s.Create(src),
                Vector512s<T>.Demo,
                Vector512s<T>.Serial,
                Vector512s<T>.SerialNegative
            };
            foreach (Vector512<T> left in samples) {
                foreach (Vector512<T> right in samples) {
#if NET7_0_OR_GREATER
                    Vector512<T> expected = Vector512.Multiply(left, right);
#else
                    Vector512<T> expected = Vector512s.Multiply((dynamic)left, (dynamic)right);
#endif // NET7_0_OR_GREATER
                    foreach (IWVectorTraits512 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        Vector512<T> dst = instance.Multiply((dynamic)left, (dynamic)right);
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


#endif
    }
}
