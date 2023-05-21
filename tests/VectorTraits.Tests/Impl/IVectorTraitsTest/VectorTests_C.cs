using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Tests.Impl.IVectorTraitsTest {
    [TestFixture()]
    public class VectorTests_C {

        [TestCase((float)1)]
        [TestCase((double)2)]
        public void CeilingTest<T>(T src) where T : struct {
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.Ceiling_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector<T>[] samples = {
                Vectors<T>.Demo,
                Vectors.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src) + 0.4, 0.3)
            };
            foreach (Vector<T> value in samples) {
                Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector<T> expected = Vectors.Ceiling((dynamic)value);
                Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IVectorTraits instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector<T> dst = instance.Ceiling((dynamic)value);
                    Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                }
            }
        }

        [TestCase((long)9)]
        [TestCase((ulong)10)]
        public void ConvertToDoubleTest<T>(T src) where T : struct {
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.ConvertToDouble_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            Console.WriteLine();
            // run.
            Vector<T>[] samples = {
                Vectors<T>.Serial,
                Vectors.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src) - 16, 8),
                Vectors<T>.Demo,
                Vectors<T>.DemoNaN,
            };
            foreach (Vector<T> value in samples) {
                Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector<double> expected = Vectors.ConvertToDouble((dynamic)value);
                Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IVectorTraits instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector<double> dst = instance.ConvertToDouble((dynamic)value);
                    Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                }
                Console.WriteLine();
            }
        }

        [TestCase((float)1)]
        public void ConvertToInt32Test<T>(T src) where T : struct {
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.ConvertToInt32_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            Console.WriteLine();
            // run.
            Vector<T>[] samples = {
                Vectors<T>.Serial,
                Vectors.CreateByDoubleLoop<T>(-0.5 - Scalars.GetDoubleFrom(src), 1),
                Vectors<T>.Demo,
                Vectors<T>.DemoNaN,
            };
            bool allowLog = false;
            foreach (Vector<T> value in samples) {
                Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector<int> expected = Vectors.ConvertToInt32((dynamic)value);
                Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IVectorTraits instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector<int> dst = instance.ConvertToInt32((dynamic)value);
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
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.ConvertToInt64_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            Console.WriteLine();
            // run.
            Vector<T>[] samples = {
                Vectors<T>.Serial,
                Vectors.CreateByDoubleLoop<T>(-0.5 - Scalars.GetDoubleFrom(src), 1),
                Vectors<T>.Demo,
                Vectors<T>.DemoNaN,
            };
            bool allowLog = false;
            foreach (Vector<T> value in samples) {
                Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector<long> expected = Vectors.ConvertToInt64((dynamic)value);
                Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IVectorTraits instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector<long> dst = instance.ConvertToInt64((dynamic)value);
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
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.ConvertToSingle_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            Console.WriteLine();
            // run.
            Vector<T>[] samples = {
                Vectors<T>.Serial,
                Vectors.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src) - 16, 8),
                Vectors<T>.Demo,
                Vectors<T>.DemoNaN,
            };
            foreach (Vector<T> value in samples) {
                Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector<float> expected = Vectors.ConvertToSingle((dynamic)value);
                Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IVectorTraits instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector<float> dst = instance.ConvertToSingle((dynamic)value);
                    Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                }
                Console.WriteLine();
            }
        }

        [TestCase((float)1)]
        public void ConvertToUInt32Test<T>(T src) where T : struct {
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.ConvertToUInt32_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            Console.WriteLine();
            // run.
            Vector<T>[] samples = {
                Vectors<T>.Serial,
                Vectors.CreateByDoubleLoop<T>(-0.5 - Scalars.GetDoubleFrom(src), 1),
                Vectors<T>.Demo,
                Vectors<T>.DemoNaN,
            };
            bool allowLog = false;
            foreach (Vector<T> value in samples) {
                Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector<uint> expected = Vectors.ConvertToUInt32((dynamic)value);
                Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IVectorTraits instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector<uint> dst = instance.ConvertToUInt32((dynamic)value);
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
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.ConvertToUInt64_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            Console.WriteLine();
            // run.
            Vector<T>[] samples = {
                Vectors<T>.Serial,
                Vectors.CreateByDoubleLoop<T>(-0.5 - Scalars.GetDoubleFrom(src), 1),
                Vectors<T>.Demo,
                Vectors<T>.DemoNaN,
            };
            bool allowLog = false;
            foreach (Vector<T> value in samples) {
                Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector<ulong> expected = Vectors.ConvertToUInt64((dynamic)value);
                Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IVectorTraits instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector<ulong> dst = instance.ConvertToUInt64((dynamic)value);
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                    }
                }
                Console.WriteLine();
            }
        }

    }
}
