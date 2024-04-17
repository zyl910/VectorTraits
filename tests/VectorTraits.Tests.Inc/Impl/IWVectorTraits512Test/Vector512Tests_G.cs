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

namespace Zyl.VectorTraits.Tests.Impl.IWVectorTraits512Test {
    [TestFixture()]
    public class Vector512Tests_G {
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
        public void GreaterThanTest<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.GreaterThan_AcceleratedTypes}");
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
                Vector512s<T>.XyXMask,
                Vector512s<T>.XyYMask,
                Vector512s<T>.XyzwXMask
            };
            foreach (Vector512<T> left in samples) {
                foreach (Vector512<T> right in samples) {
#if NET7_0_OR_GREATER
                    Vector512<T> expected = Vector512.GreaterThan(left, right);
#else
                    Vector512<T> expected = Vector512s.GreaterThan((dynamic)left, (dynamic)right);
#endif // NET7_0_OR_GREATER
                    foreach (IWVectorTraits512 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        Vector512<T> dst = instance.GreaterThan((dynamic)left, (dynamic)right);
                        Assert.AreEqual(expected.AsByte(), dst.AsByte(), $"{instance.GetType().Name}, left={left}, right={right}");
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
        public void GreaterThanAllTest<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.GreaterThanAll_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            Console.WriteLine();
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
            bool showNotEquals = true;
            foreach (Vector512<T> left in samples) {
                foreach (Vector512<T> right in samples) {
#if NET7_0_OR_GREATER
                    bool expected = Vector512.GreaterThanAll(left, right);
#else
                    bool expected = Vector512s.GreaterThanAll((dynamic)left, (dynamic)right);
#endif // NET7_0_OR_GREATER
                    foreach (IWVectorTraits512 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        bool dst = instance.GreaterThanAll((dynamic)left, (dynamic)right);
                        bool showLog = showNotEquals && !expected.Equals(dst);
                        if (0 == Scalars<T>.ExponentBits) showLog = false; // Integers alway use Assert.
                        if (allowLog || showLog) {
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
        public void GreaterThanAnyTest<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.GreaterThanAny_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            Console.WriteLine();
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
            bool showNotEquals = true;
            foreach (Vector512<T> left in samples) {
                foreach (Vector512<T> right in samples) {
#if NET7_0_OR_GREATER
                    bool expected = Vector512.GreaterThanAny(left, right);
#else
                    bool expected = Vector512s.GreaterThanAny((dynamic)left, (dynamic)right);
#endif // NET7_0_OR_GREATER
                    foreach (IWVectorTraits512 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        bool dst = instance.GreaterThanAny((dynamic)left, (dynamic)right);
                        bool showLog = showNotEquals && !expected.Equals(dst);
                        if (0 == Scalars<T>.ExponentBits) showLog = false; // Integers alway use Assert.
                        if (allowLog || showLog) {
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
        public void GreaterThanOrEqualTest<T>(T src) where T : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.GreaterThanOrEqual_AcceleratedTypes}");
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
            foreach (Vector512<T> left in samples) {
                foreach (Vector512<T> right in samples) {
#if NET7_0_OR_GREATER
                    Vector512<T> expected = Vector512.GreaterThanOrEqual(left, right);
#else
                    Vector512<T> expected = Vector512s.GreaterThanOrEqual((dynamic)left, (dynamic)right);
#endif // NET7_0_OR_GREATER
                    bool usedWrite = false;
                    foreach (IWVectorTraits512 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        Vector512<T> dst = instance.GreaterThanOrEqual((dynamic)left, (dynamic)right);
                        //Assert.AreEqual(expected.AsByte(), dst.AsByte(), $"{instance.GetType().Name}, left={left}, right={right}");
                        bool showLog = showNotEquals && !expected.AsByte().Equals(dst.AsByte());
                        if (0 == Scalars<T>.ExponentBits) showLog = false; // Integers alway use Assert.
                        if (allowLog || showLog) {
                            if (!usedWrite) {
                                usedWrite = true;
                                writer.WriteLine();
                                writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}, left={2}, right={3}", "Expected", expected, left, right));
                            }
                            writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                        } else {
                            Assert.AreEqual(expected.AsByte(), dst.AsByte(), $"{instance.GetType().Name}, left={left}, right={right}");
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
        public void GreaterThanOrEqualAllTest<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.GreaterThanOrEqualAll_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            Console.WriteLine();
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
            bool showNotEquals = true;
            foreach (Vector512<T> left in samples) {
                foreach (Vector512<T> right in samples) {
#if NET7_0_OR_GREATER
                    bool expected = Vector512.GreaterThanOrEqualAll(left, right);
#else
                    bool expected = Vector512s.GreaterThanOrEqualAll((dynamic)left, (dynamic)right);
#endif // NET7_0_OR_GREATER
                    foreach (IWVectorTraits512 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        bool dst = instance.GreaterThanOrEqualAll((dynamic)left, (dynamic)right);
                        bool showLog = showNotEquals && !expected.Equals(dst);
                        if (0 == Scalars<T>.ExponentBits) showLog = false; // Integers alway use Assert.
                        if (allowLog || showLog) {
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
        public void GreaterThanOrEqualAnyTest<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.GreaterThanOrEqualAny_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            Console.WriteLine();
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
            bool showNotEquals = true;
            foreach (Vector512<T> left in samples) {
                foreach (Vector512<T> right in samples) {
#if NET7_0_OR_GREATER
                    bool expected = Vector512.GreaterThanOrEqualAny(left, right);
#else
                    bool expected = Vector512s.GreaterThanOrEqualAny((dynamic)left, (dynamic)right);
#endif // NET7_0_OR_GREATER
                    foreach (IWVectorTraits512 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        bool dst = instance.GreaterThanOrEqualAny((dynamic)left, (dynamic)right);
                        bool showLog = showNotEquals && !expected.Equals(dst);
                        if (0 == Scalars<T>.ExponentBits) showLog = false; // Integers alway use Assert.
                        if (allowLog || showLog) {
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
