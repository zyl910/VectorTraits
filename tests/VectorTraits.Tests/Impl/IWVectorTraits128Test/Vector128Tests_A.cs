﻿using NUnit.Framework;
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
    public class Vector128Tests_A {
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
        public void AddTest<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.IsSupported) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.Add_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector128<T>[] samples = {
                Vector128s.Create(src),
                Vector128s<T>.Demo,
                Vector128s<T>.Serial,
                Vector128s<T>.SerialNegative
            };
            foreach (Vector128<T> left in samples) {
                foreach (Vector128<T> right in samples) {
#if NET7_0_OR_GREATER
                    Vector128<T> expected = Vector128.Add(left, right);
#else
                    Vector128<T> expected = Vector128s.Add((dynamic)left, (dynamic)right);
#endif // NET7_0_OR_GREATER
                    foreach (IWVectorTraits128 instance in instances) {
                        if (!instance.IsSupported) continue;
                        Vector128<T> dst = instance.Add((dynamic)left, (dynamic)right);
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
        public void AndNotTest<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.IsSupported) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.ConditionalSelect_AcceleratedTypes}");
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
                Vector128s<T>.XyXMask,
                Vector128s<T>.XyYMask,
                Vector128s<T>.XyzwXMask
            };
            foreach (Vector128<T> left in samples) {
                foreach (Vector128<T> right in samples) {
                    Vector128<T> expected = Vector128s.AndNot(left, right);
                    foreach (IWVectorTraits128 instance in instances) {
                        if (!instance.IsSupported) continue;
                        Vector128<T> dst = instance.AndNot(left, right);
                        Assert.AreEqual(expected.AsByte(), dst.AsByte(), $"{instance.GetType().Name}, left={left}, right={right}");
                    }
                }
            }
        }


#endif
    }
}
