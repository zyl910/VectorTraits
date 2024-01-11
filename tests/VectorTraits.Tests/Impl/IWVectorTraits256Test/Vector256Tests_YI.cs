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

namespace Zyl.VectorTraits.Tests.Impl.IWVectorTraits256Test {
    [TestFixture()]
    public class Vector256Tests_YI {
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
        public void YIsAllTrueTest<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsAllTrue_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            Console.WriteLine();
            // run.
            Vector256<T>[] samples = {
                Vector256s.Create(src),
                Vector256s<T>.Demo,
                Vector256s<T>.Serial,
                Vector256s<T>.SerialNegative,
                Vector256s<T>.XyXMask,
                Vector256s<T>.XyYMask,
                Vector256s<T>.XyzwXMask
            };
            foreach (Vector256<T> left in samples) {
                foreach (Vector256<T> right in samples) {
#if NET7_0_OR_GREATER
                    Vector256<T> expectedSrc = Vector256.Equals(left, right);
#else
                    Vector256<T> expectedSrc = Vector256s.Equals((dynamic)left, (dynamic)right);
#endif // NET7_0_OR_GREATER
                    bool expected = Vector256s.YIsAllTrue(expectedSrc);
                    foreach (IWVectorTraits256 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        bool dst = instance.YIsAllTrue(expectedSrc);
                        Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={expectedSrc}");
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
        public void YIsAnyTrueTest<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsAnyTrue_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            Console.WriteLine();
            // run.
            Vector256<T>[] samples = {
                Vector256s.Create(src),
                Vector256s<T>.Demo,
                Vector256s<T>.Serial,
                Vector256s<T>.SerialNegative,
                Vector256s<T>.XyXMask,
                Vector256s<T>.XyYMask,
                Vector256s<T>.XyzwXMask
            };
            foreach (Vector256<T> left in samples) {
                foreach (Vector256<T> right in samples) {
#if NET7_0_OR_GREATER
                    Vector256<T> expectedSrc = Vector256.Equals(left, right);
#else
                    Vector256<T> expectedSrc = Vector256s.Equals((dynamic)left, (dynamic)right);
#endif // NET7_0_OR_GREATER
                    bool expected = Vector256s.YIsAnyTrue(expectedSrc);
                    foreach (IWVectorTraits256 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        bool dst = instance.YIsAnyTrue(expectedSrc);
                        Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={expectedSrc}");
                    }
                }
            }
        }

        [TestCase((float)1, (int)1)]
        [TestCase((double)2, (long)1)]
        public void YIsFiniteTest<T, TOut>(T src, TOut srcOut) where T : struct where TOut : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsFinite_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector256s.GetSupportedMethodList<Func<Vector256<T>, Vector256<TOut>>>("YIsFinite_Basic", "YIsFinite_Bit");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector256<T>[] samples = {
                Vector256s<T>.Serial,
                Vector256s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), -1.0),
                Vector256s<T>.Demo,
                Vector256s<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector256<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector256<TOut> expected = Vector256s.YIsFinite((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits256 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector256<TOut> dst = instance.YIsFinite((dynamic)value);
                    if (allowLog || (showNotEquals && !expected.Equals(dst))) {
                        writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                    }
                }
                writer.WriteLine();
            }
        }

        [TestCase((float)1, (int)1)]
        [TestCase((double)2, (long)1)]
        public void YIsInfinityTest<T, TOut>(T src, TOut srcOut) where T : struct where TOut : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsInfinity_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector256s.GetSupportedMethodList<Func<Vector256<T>, Vector256<TOut>>>("YIsInfinity_Basic", "YIsInfinity_Bit");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector256<T>[] samples = {
                Vector256s<T>.Serial,
                Vector256s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), -1.0),
                Vector256s<T>.Demo,
                Vector256s<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector256<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector256<TOut> expected = Vector256s.YIsInfinity((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits256 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector256<TOut> dst = instance.YIsInfinity((dynamic)value);
                    if (allowLog || (showNotEquals && !expected.Equals(dst))) {
                        writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                    }
                }
                writer.WriteLine();
            }
        }


        [TestCase((float)1, (int)1)]
        [TestCase((double)2, (long)1)]
        public void YIsInfinityOrNaNTest<T, TOut>(T src, TOut srcOut) where T : struct where TOut : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsInfinityOrNaN_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector256s.GetSupportedMethodList<Func<Vector256<T>, Vector256<TOut>>>("YIsInfinityOrNaN_Basic", "YIsInfinityOrNaN_Bit");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector256<T>[] samples = {
                Vector256s<T>.Serial,
                Vector256s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), -1.0),
                Vector256s<T>.Demo,
                Vector256s<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector256<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector256<TOut> expected = Vector256s.YIsInfinityOrNaN((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits256 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector256<TOut> dst = instance.YIsInfinityOrNaN((dynamic)value);
                    if (allowLog || (showNotEquals && !expected.Equals(dst))) {
                        writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                    }
                }
                writer.WriteLine();
            }
        }

        [TestCase((float)1, (int)1)]
        [TestCase((double)2, (long)1)]
        public void YIsIntegerTest<T, TOut>(T src, TOut srcOut) where T : struct where TOut : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsInteger_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector256s.GetSupportedMethodList<Func<Vector256<T>, Vector256<TOut>>>("YIsInteger_Basic", "YIsInteger_Bit");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector256<T>[] samples = {
                Vector256s<T>.Serial,
                Vector256s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), -1.0),
                Vector256s<T>.Demo,
                Vector256s<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector256<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector256<TOut> expected = Vector256s.YIsInteger((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits256 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector256<TOut> dst = instance.YIsInteger((dynamic)value);
                    if (allowLog || (showNotEquals && !expected.Equals(dst))) {
                        writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                    }
                }
                writer.WriteLine();
            }
        }

#endif
    }
}
