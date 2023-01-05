using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Tests.Impl.IWVectorTraits256Test {
    [TestFixture()]
    public class Vector256Tests_C {
#if NETCOREAPP3_0_OR_GREATER

        [TestCase((float)1)]
        [TestCase((double)2)]
        public void CeilingTest<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                if (instance.IsSupported) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.Ceiling_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector256<T>[] samples = {
                Vector256s<T>.Demo,
                Vector256s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src) + 0.4, 0.1)
            };
            foreach (Vector256<T> value in samples) {
                Console.WriteLine($"Samples: {value}\t// {VectorTextUtil.GetHex(value)}");
                Vector256<T> expected = Vector256s.Ceiling((dynamic)value);
                Console.WriteLine($"Vector256s.Ceiling: {expected}\t// {VectorTextUtil.GetHex(expected)}");
                foreach (IWVectorTraits256 instance in instances) {
                    if (!instance.IsSupported) continue;
                    Vector256<T> dst = instance.Ceiling((dynamic)value);
                    Console.WriteLine($"{instance.GetType().Name}: {dst}\t// {VectorTextUtil.GetHex(dst)}");
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
        public void ConditionalSelectTest<T>(T src) where T : struct {
            //Vector256<T> vzero = Vector256<T>.Zero;
            //T zero = default;
            int shiftAmountMax = Scalars<T>.BitSize + 1;
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                if (instance.IsSupported) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.ConditionalSelect_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector256<T>[] conditions = {
                Vector256s<T>.Demo,
                Vector256s<T>.XyXMask,
                Vector256s<T>.XyYMask,
                Vector256s<T>.XyzwXMask,
                Vector256s<T>.XyzwYMask,
                Vector256s<T>.XyzwZMask,
                Vector256s<T>.XyzwWMask,
            };
            Vector256<T>[] samples = {
                Vector256s.Create(src),
                Vector256s<T>.Demo,
                Vector256s<T>.Serial,
            };
            foreach (Vector256<T> left in samples) {
                foreach (Vector256<T> right in samples) {
                    foreach (Vector256<T> condition in conditions) {
                        Vector256<T> expected = Vector256s.ConditionalSelect(condition, left, right);
                        foreach (IWVectorTraits256 instance in instances) {
                            if (!instance.IsSupported) continue;
                            Vector256<T> dst = instance.ConditionalSelect(condition, left, right);
                            // NaN equality problem --
                            // Expected: <-1.7976931348623157E+308, NaN>
                            // But was:  <-1.7976931348623157E+308, NaN>
                            //Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, condition={condition}, left={left}, right={right}");
                            // Fixed NaN equality problem.
                            Assert.AreEqual(expected.AsByte(), dst.AsByte(), $"{instance.GetType().Name}, condition={condition}, left={left}, right={right}");
                        }
                    }
                }
            }
        }


#endif
    }
}
