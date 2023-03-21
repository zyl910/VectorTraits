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
    public class Vector128Tests_C {
#if NETCOREAPP3_0_OR_GREATER

        [TestCase((float)1)]
        [TestCase((double)2)]
        public void CeilingTest<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.Ceiling_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector128<T>[] samples = {
                Vector128s<T>.Demo,
                Vector128s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src) + 0.4, 0.3)
            };
            foreach (Vector128<T> value in samples) {
                Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector128<T> expected = Vector128s.Ceiling((dynamic)value);
                Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<T> dst = instance.Ceiling((dynamic)value);
                    Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
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
            //Vector128<T> vzero = Vector128<T>.Zero;
            //T zero = default;
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.ConditionalSelect_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector128<T>[] conditions = {
                Vector128s<T>.Demo,
                Vector128s<T>.XyXMask,
                Vector128s<T>.XyYMask,
                Vector128s<T>.XyzwXMask,
                Vector128s<T>.XyzwYMask,
                Vector128s<T>.XyzwZMask,
                Vector128s<T>.XyzwWMask,
            };
            Vector128<T>[] samples = {
                Vector128s.Create(src),
                Vector128s<T>.Demo,
                Vector128s<T>.Serial,
            };
            foreach (Vector128<T> left in samples) {
                foreach (Vector128<T> right in samples) {
                    foreach (Vector128<T> condition in conditions) {
                        Vector128<T> expected = Vector128s.ConditionalSelect(condition, left, right);
                        foreach (IWVectorTraits128 instance in instances) {
                            if (!instance.GetIsSupported(true)) continue;
                            Vector128<T> dst = instance.ConditionalSelect(condition, left, right);
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

        [TestCase((long)9)]
        [TestCase((ulong)10)]
        public void ConvertToDoubleTest<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.ConvertToDouble_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            Console.WriteLine();
            // run.
            Vector128<T>[] samples = {
                Vector128s<T>.Serial,
                Vector128s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src) - 16, 8),
                Vector128s<T>.Demo,
                Vector128s<T>.DemoNaN,
            };
            foreach (Vector128<T> value in samples) {
                Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector128<double> expected = Vector128s.ConvertToDouble((dynamic)value);
                Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<double> dst = instance.ConvertToDouble((dynamic)value);
                    Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                }
                Console.WriteLine();
            }
        }

        [TestCase((float)1)]
        public void ConvertToInt32Test<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.ConvertToInt32_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            Console.WriteLine();
            // run.
            Vector128<T>[] samples = {
                Vector128s<T>.Serial,
                Vector128s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src) - 16, 8),
                Vector128s<T>.Demo,
                Vector128s<T>.DemoNaN,
            };
            bool allowLog = false;
            foreach (Vector128<T> value in samples) {
                Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector128<int> expected = Vector128s.ConvertToInt32((dynamic)value);
                Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<int> dst = instance.ConvertToInt32((dynamic)value);
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                    }
                }
                Console.WriteLine();
            }
        }

        [TestCase((double)2)]
        public void ConvertToInt64Test<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.ConvertToInt64_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            Console.WriteLine();
            // run.
            Vector128<T>[] samples = {
                Vector128s<T>.Serial,
                Vector128s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src) - 16, 8),
                Vector128s<T>.Demo,
                Vector128s<T>.DemoNaN,
            };
            bool allowLog = false;
            foreach (Vector128<T> value in samples) {
                Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector128<long> expected = Vector128s.ConvertToInt64((dynamic)value);
                Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<long> dst = instance.ConvertToInt64((dynamic)value);
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                    }
                }
                Console.WriteLine();
            }
        }

        [TestCase((int)7)]
        [TestCase((uint)8)]
        public void ConvertToSingleTest<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.ConvertToSingle_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            Console.WriteLine();
            // run.
            Vector128<T>[] samples = {
                Vector128s<T>.Serial,
                Vector128s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src) - 16, 8),
                Vector128s<T>.Demo,
                Vector128s<T>.DemoNaN,
            };
            foreach (Vector128<T> value in samples) {
                Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector128<float> expected = Vector128s.ConvertToSingle((dynamic)value);
                Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<float> dst = instance.ConvertToSingle((dynamic)value);
                    Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                }
                Console.WriteLine();
            }
        }

        [TestCase((float)1)]
        public void ConvertToUInt32Test<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.ConvertToUInt32_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            Console.WriteLine();
            // run.
            Vector128<T>[] samples = {
                Vector128s<T>.Serial,
                Vector128s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src) - 16, 8),
                Vector128s<T>.Demo,
                Vector128s<T>.DemoNaN,
            };
            bool allowLog = false;
            foreach (Vector128<T> value in samples) {
                Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector128<uint> expected = Vector128s.ConvertToUInt32((dynamic)value);
                Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<uint> dst = instance.ConvertToUInt32((dynamic)value);
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                    }
                }
                Console.WriteLine();
            }
        }

        [TestCase((double)2)]
        public void ConvertToUInt64Test<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.ConvertToUInt64_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            Console.WriteLine();
            // run.
            Vector128<T>[] samples = {
                Vector128s<T>.Serial,
                Vector128s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src) - 16, 8),
                Vector128s<T>.Demo,
                Vector128s<T>.DemoNaN,
            };
            bool allowLog = false;
            foreach (Vector128<T> value in samples) {
                Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector128<ulong> expected = Vector128s.ConvertToUInt64((dynamic)value);
                Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<ulong> dst = instance.ConvertToUInt64((dynamic)value);
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                    }
                }
                Console.WriteLine();
            }
        }


#endif
    }
}
