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
    public class Vector128Tests_E {
#if NETCOREAPP3_0_OR_GREATER

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
        public void ExtractMostSignificantBitsTest<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.ExtractMostSignificantBits_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            bool allowLog = true;
            //bool allowLogItem = Scalars<T>.ExponentBits > 0;
            bool allowLogItem = false;
            Vector128<T>[] samples = {
                Vector128s.Create(src),
                Vector128s<T>.V_1,
                Vector128s<T>.Demo,
                Vector128s<T>.InterlacedSign,
                Vector128s<T>.InterlacedSignNegative,
                Vector128s<T>.XyzwAddress0Mask
            };
            foreach (Vector128<T> vector in samples) {
#if NET7_0_OR_GREATER
                uint expected = Vector128.ExtractMostSignificantBits((dynamic)vector);
#else
                uint expected = Vector128s.ExtractMostSignificantBits((dynamic)vector);
#endif // NET7_0_OR_GREATER
                if (allowLog) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", vector));
                    Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                }
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    uint dst = instance.ExtractMostSignificantBits((dynamic)vector);
                    if (allowLogItem) {
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, vector={vector}");
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
        public void EqualsTest<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.Equals_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            Console.WriteLine();
            // run.
            Vector128<T>[] samples = {
                Vector128s.Create(src),
                Vector128s<T>.Demo,
                Vector128s<T>.Serial,
                Vector128s<T>.SerialNegative,
                Vector128s<T>.XyXMask,
                Vector128s<T>.XyYMask,
                Vector128s<T>.XyzwXMask
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector128<T> left in samples) {
                foreach (Vector128<T> right in samples) {
#if NET7_0_OR_GREATER
                    Vector128<T> expected = Vector128.Equals(left, right);
#else
                    Vector128<T> expected = Vector128s.Equals((dynamic)left, (dynamic)right);
#endif // NET7_0_OR_GREATER
                    foreach (IWVectorTraits128 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        Vector128<T> dst = instance.Equals((dynamic)left, (dynamic)right);
                        bool showLog = showNotEquals && !expected.AsByte().Equals(dst.AsByte());
                        if (0 == Scalars<T>.ExponentBits) showLog = false; // Integers alway use Assert.
                        if (allowLog || showLog) {
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, left={2}, right={3}", instance.GetType().Name, dst, left, right));
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
        public void EqualsAllTest<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.EqualsAll_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            Console.WriteLine();
            // run.
            Vector128<T>[] samples = {
                Vector128s.Create(src),
                Vector128s<T>.Demo,
                Vector128s<T>.Serial,
                Vector128s<T>.SerialNegative,
                Vector128s<T>.XyXMask,
                Vector128s<T>.XyYMask,
                Vector128s<T>.XyzwXMask
            };
            bool allowLog = false;
            bool showNotEqualsAll = true;
            foreach (Vector128<T> left in samples) {
                foreach (Vector128<T> right in samples) {
#if NET7_0_OR_GREATER
                    bool expected = Vector128.EqualsAll(left, right);
#else
                    bool expected = Vector128s.EqualsAll((dynamic)left, (dynamic)right);
#endif // NET7_0_OR_GREATER
                    foreach (IWVectorTraits128 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        bool dst = instance.EqualsAll((dynamic)left, (dynamic)right);
                        bool showLog = showNotEqualsAll && !expected.Equals(dst);
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
        public void EqualsAnyTest<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.EqualsAny_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            Console.WriteLine();
            // run.
            Vector128<T>[] samples = {
                Vector128s.Create(src),
                Vector128s<T>.Demo,
                Vector128s<T>.Serial,
                Vector128s<T>.SerialNegative,
                Vector128s<T>.XyXMask,
                Vector128s<T>.XyYMask,
                Vector128s<T>.XyzwXMask
            };
            bool allowLog = false;
            bool showNotEqualsAny = true;
            foreach (Vector128<T> left in samples) {
                foreach (Vector128<T> right in samples) {
#if NET7_0_OR_GREATER
                    bool expected = Vector128.EqualsAny(left, right);
#else
                    bool expected = Vector128s.EqualsAny((dynamic)left, (dynamic)right);
#endif // NET7_0_OR_GREATER
                    foreach (IWVectorTraits128 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        bool dst = instance.EqualsAny((dynamic)left, (dynamic)right);
                        bool showLog = showNotEqualsAny && !expected.Equals(dst);
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
