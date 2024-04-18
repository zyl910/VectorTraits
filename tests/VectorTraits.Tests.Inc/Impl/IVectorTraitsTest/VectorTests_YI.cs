using NUnit.Framework;
#if !USED_NUNIT3
using NUnit.Framework.Legacy;
#endif
using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Text;
using Zyl.VectorTraits.Extensions.SameW;
using Zyl.VectorTraits.Impl;
using Zyl.VectorTraits.Impl.AVector;

namespace Zyl.VectorTraits.Tests.Impl.IVectorTraitsTest {
#if USED_NUNIT3
    using ClassicAssert = Assert;
#endif

    [TestFixture()]
    public class VectorTests_YI {

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
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsAllTrue_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            Console.WriteLine();
            // run.
            Vector<T>[] samples = {
                Vectors.Create(src),
                Vectors<T>.Demo,
                Vectors<T>.Serial,
                Vectors<T>.SerialNegative,
                Vectors<T>.XyXMask,
                Vectors<T>.XyYMask,
                Vectors<T>.XyzwXMask
            };
            foreach (Vector<T> left in samples) {
                foreach (Vector<T> right in samples) {
                    Vector<T> expectedSrc = Vector.Equals(left, right);
                    bool expected = Vectors.YIsAllTrue(expectedSrc);
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        bool dst = instance.YIsAllTrue(expectedSrc);
                        ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={expectedSrc}");
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
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsAnyTrue_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            Console.WriteLine();
            // run.
            Vector<T>[] samples = {
                Vectors.Create(src),
                Vectors<T>.Demo,
                Vectors<T>.Serial,
                Vectors<T>.SerialNegative,
                Vectors<T>.XyXMask,
                Vectors<T>.XyYMask,
                Vectors<T>.XyzwXMask
            };
            foreach (Vector<T> left in samples) {
                foreach (Vector<T> right in samples) {
                    Vector<T> expectedSrc = Vector.Equals(left, right);
                    bool expected = Vectors.YIsAnyTrue(expectedSrc);
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        bool dst = instance.YIsAnyTrue(expectedSrc);
                        ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={expectedSrc}");
                    }
                }
            }
        }

        [TestCase((float)1, (int)1)]
        [TestCase((double)2, (long)1)]
        [TestCase((sbyte)3, (sbyte)1)]
        [TestCase((byte)4, (byte)1)]
        [TestCase((short)5, (short)1)]
        [TestCase((ushort)6, (ushort)1)]
        [TestCase((int)7, (int)1)]
        [TestCase((uint)8, (uint)1)]
        [TestCase((long)9, (long)1)]
        [TestCase((ulong)10, (ulong)1)]
        public void YIsEvenIntegerTest<T, TOut>(T src, TOut srcOut) where T : struct where TOut : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsEvenInteger_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<Func<Vector<T>, Vector<TOut>>>("YIsEvenInteger_Basic", "YIsEvenInteger_Bit");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector<T>[] samples = {
                Vectors<T>.Serial,
                Vectors.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), -1.0),
                Vectors<T>.Demo,
                Vectors<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector<TOut> expected = Vectors.YIsEvenInteger((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IVectorTraits instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector<TOut> dst = instance.YIsEvenInteger((dynamic)value);
                    if (allowLog || (showNotEquals && !expected.Equals(dst))) {
                        writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                    }
                }
                writer.WriteLine();
            }
        }

        [TestCase((float)1, (int)1)]
        [TestCase((double)2, (long)1)]
        public void YIsFiniteTest<T, TOut>(T src, TOut srcOut) where T : struct where TOut : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsFinite_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<Func<Vector<T>, Vector<TOut>>>("YIsFinite_Basic", "YIsFinite_Bit");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector<T>[] samples = {
                Vectors<T>.Serial,
                Vectors.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), -1.0),
                Vectors<T>.Demo,
                Vectors<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector<TOut> expected = Vectors.YIsFinite((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IVectorTraits instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector<TOut> dst = instance.YIsFinite((dynamic)value);
                    if (allowLog || (showNotEquals && !expected.Equals(dst))) {
                        writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                    }
                }
                writer.WriteLine();
            }
        }

        [TestCase((float)1, (int)1)]
        [TestCase((double)2, (long)1)]
        public void YIsInfinityTest<T, TOut>(T src, TOut srcOut) where T : struct where TOut : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsInfinity_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<Func<Vector<T>, Vector<TOut>>>("YIsInfinity_Basic", "YIsInfinity_Bit");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector<T>[] samples = {
                Vectors<T>.Serial,
                Vectors.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), -1.0),
                Vectors<T>.Demo,
                Vectors<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector<TOut> expected = Vectors.YIsInfinity((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IVectorTraits instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector<TOut> dst = instance.YIsInfinity((dynamic)value);
                    if (allowLog || (showNotEquals && !expected.Equals(dst))) {
                        writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                    }
                }
                writer.WriteLine();
            }
        }


        [TestCase((float)1, (int)1)]
        [TestCase((double)2, (long)1)]
        public void YIsInfinityOrNaNTest<T, TOut>(T src, TOut srcOut) where T : struct where TOut : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsInfinityOrNaN_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<Func<Vector<T>, Vector<TOut>>>("YIsInfinityOrNaN_Basic", "YIsInfinityOrNaN_Bit");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector<T>[] samples = {
                Vectors<T>.Serial,
                Vectors.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), -1.0),
                Vectors<T>.Demo,
                Vectors<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector<TOut> expected = Vectors.YIsInfinityOrNaN((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IVectorTraits instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector<TOut> dst = instance.YIsInfinityOrNaN((dynamic)value);
                    if (allowLog || (showNotEquals && !expected.Equals(dst))) {
                        writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                    }
                }
                writer.WriteLine();
            }
        }

        [TestCase((float)1, (int)1)]
        [TestCase((double)2, (long)1)]
        public void YIsIntegerTest<T, TOut>(T src, TOut srcOut) where T : struct where TOut : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsInteger_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<Func<Vector<T>, Vector<TOut>>>("YIsInteger_Basic", "YIsInteger_Bit");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector<T>[] samples = {
                Vectors<T>.Serial,
                Vectors.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), -1.0),
                Vectors<T>.Demo,
                Vectors<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector<TOut> expected = Vectors.YIsInteger((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IVectorTraits instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector<TOut> dst = instance.YIsInteger((dynamic)value);
                    if (allowLog || (showNotEquals && !expected.Equals(dst))) {
                        writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                    }
                }
                writer.WriteLine();
            }
        }

        [TestCase((float)1, (int)1)]
        [TestCase((double)2, (long)1)]
        public void YIsNaNTest<T, TOut>(T src, TOut srcOut) where T : struct where TOut : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsNaN_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<Func<Vector<T>, Vector<TOut>>>("YIsNaN_Basic", "YIsNaN_Bit");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector<T>[] samples = {
                Vectors<T>.Serial,
                Vectors.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), -1.0),
                Vectors<T>.Demo,
                Vectors<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector<TOut> expected = Vectors.YIsNaN((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IVectorTraits instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector<TOut> dst = instance.YIsNaN((dynamic)value);
                    if (allowLog || (showNotEquals && !expected.Equals(dst))) {
                        writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                    }
                }
                writer.WriteLine();
            }
        }

        [TestCase((float)1, (int)1)]
        [TestCase((double)2, (long)1)]
        [TestCase((sbyte)3, (sbyte)1)]
        [TestCase((short)5, (short)1)]
        [TestCase((int)7, (int)1)]
        [TestCase((long)9, (long)1)]
        public void YIsNegativeTest<T, TOut>(T src, TOut srcOut) where T : struct where TOut : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsNegative_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<Func<Vector<T>, Vector<TOut>>>("YIsNegative_Basic", "YIsNegative_Bit");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector<T>[] samples = {
                Vectors<T>.Serial,
                Vectors.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), -1.0),
                Vectors<T>.Demo,
                Vectors<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector<TOut> expected = Vectors.YIsNegative((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IVectorTraits instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector<TOut> dst = instance.YIsNegative((dynamic)value);
                    if (allowLog || (showNotEquals && !expected.Equals(dst))) {
                        writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                    }
                }
                writer.WriteLine();
            }
        }

        [TestCase((float)1, (int)1)]
        [TestCase((double)2, (long)1)]
        public void YIsNegativeInfinityTest<T, TOut>(T src, TOut srcOut) where T : struct where TOut : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsNegativeInfinity_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<Func<Vector<T>, Vector<TOut>>>("YIsNegativeInfinity_Basic", "YIsNegativeInfinity_Bit");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector<T>[] samples = {
                Vectors<T>.Serial,
                Vectors.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), -1.0),
                Vectors<T>.Demo,
                Vectors<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector<TOut> expected = Vectors.YIsNegativeInfinity((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IVectorTraits instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector<TOut> dst = instance.YIsNegativeInfinity((dynamic)value);
                    if (allowLog || (showNotEquals && !expected.Equals(dst))) {
                        writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                    }
                }
                writer.WriteLine();
            }
        }

        [TestCase((float)1, (int)1)]
        [TestCase((double)2, (long)1)]
        public void YIsNegativeZeroTest<T, TOut>(T src, TOut srcOut) where T : struct where TOut : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsNegativeZero_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<Func<Vector<T>, Vector<TOut>>>("YIsNegativeZero_Basic", "YIsNegativeZero_Bit");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector<T>[] samples = {
                Vectors<T>.Serial,
                Vectors.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), -1.0),
                Vectors<T>.Demo,
                Vectors<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector<TOut> expected = Vectors.YIsNegativeZero((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IVectorTraits instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector<TOut> dst = instance.YIsNegativeZero((dynamic)value);
                    if (allowLog || (showNotEquals && !expected.Equals(dst))) {
                        writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                    }
                }
                writer.WriteLine();
            }
        }

        [TestCase((float)1, (int)1)]
        [TestCase((double)2, (long)1)]
        public void YIsNormalTest<T, TOut>(T src, TOut srcOut) where T : struct where TOut : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsNormal_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<Func<Vector<T>, Vector<TOut>>>("YIsNormal_Basic", "YIsNormal_Bit");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector<T>[] samples = {
                Vectors<T>.Serial,
                Vectors.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), -1.0),
                Vectors<T>.Demo,
                Vectors<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector<TOut> expected = Vectors.YIsNormal((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IVectorTraits instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector<TOut> dst = instance.YIsNormal((dynamic)value);
                    if (allowLog || (showNotEquals && !expected.Equals(dst))) {
                        writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                    }
                }
                writer.WriteLine();
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
        public void YIsNotEqualsTest<T>(T src) where T : struct {
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsNotEquals_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            Console.WriteLine();
            // run.
            Vector<T>[] samples = {
                Vectors.Create(src),
                Vectors<T>.Demo,
                Vectors<T>.Serial,
                Vectors<T>.SerialNegative,
                Vectors<T>.XyXMask,
                Vectors<T>.XyYMask,
                Vectors<T>.XyzwXMask
            };
            bool allowLog = false;
            bool showNotYIsNotEquals = false;
            foreach (Vector<T> left in samples) {
                foreach (Vector<T> right in samples) {
                    Vector<T> expected = Vectors.YIsNotEquals((dynamic)left, (dynamic)right);
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        Vector<T> dst = instance.YIsNotEquals((dynamic)left, (dynamic)right);
                        bool showLog = showNotYIsNotEquals && !expected.AsByte().Equals(dst.AsByte());
                        if (0 == Scalars<T>.ExponentBits) showLog = false; // Integers alway use ClassicAssert.
                        if (allowLog || showLog) {
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, left={2}, right={3}", instance.GetType().Name, dst, left, right));
                        } else {
                            ClassicAssert.AreEqual(expected.AsByte(), dst.AsByte(), $"{instance.GetType().Name}, left={left}, right={right}");
                        }
                    }
                }
            }
        }

        [TestCase((float)1, (int)1)]
        [TestCase((double)2, (long)1)]
        public void YIsNotNaNTest<T, TOut>(T src, TOut srcOut) where T : struct where TOut : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsNotNaN_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<Func<Vector<T>, Vector<TOut>>>("YIsNotNaN_Basic", "YIsNotNaN_Bit");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector<T>[] samples = {
                Vectors<T>.Serial,
                Vectors.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), -1.0),
                Vectors<T>.Demo,
                Vectors<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector<TOut> expected = Vectors.YIsNotNaN((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IVectorTraits instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector<TOut> dst = instance.YIsNotNaN((dynamic)value);
                    if (allowLog || (showNotEquals && !expected.Equals(dst))) {
                        writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                    }
                }
                writer.WriteLine();
            }
        }

        [TestCase((float)1, (int)1)]
        [TestCase((double)2, (long)1)]
        [TestCase((sbyte)3, (sbyte)1)]
        [TestCase((byte)4, (byte)1)]
        [TestCase((short)5, (short)1)]
        [TestCase((ushort)6, (ushort)1)]
        [TestCase((int)7, (int)1)]
        [TestCase((uint)8, (uint)1)]
        [TestCase((long)9, (long)1)]
        [TestCase((ulong)10, (ulong)1)]
        public void YIsOddIntegerTest<T, TOut>(T src, TOut srcOut) where T : struct where TOut : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsOddInteger_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<Func<Vector<T>, Vector<TOut>>>("YIsOddInteger_Basic", "YIsOddInteger_Bit");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector<T>[] samples = {
                Vectors<T>.Serial,
                Vectors.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), -1.0),
                Vectors<T>.Demo,
                Vectors<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector<TOut> expected = Vectors.YIsOddInteger((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IVectorTraits instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector<TOut> dst = instance.YIsOddInteger((dynamic)value);
                    if (allowLog || (showNotEquals && !expected.Equals(dst))) {
                        writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                    }
                }
                writer.WriteLine();
            }
        }

        [TestCase((float)1, (int)1)]
        [TestCase((double)2, (long)1)]
        [TestCase((sbyte)3, (sbyte)1)]
        [TestCase((short)5, (short)1)]
        [TestCase((int)7, (int)1)]
        [TestCase((long)9, (long)1)]
        public void YIsPositiveTest<T, TOut>(T src, TOut srcOut) where T : struct where TOut : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsPositive_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<Func<Vector<T>, Vector<TOut>>>("YIsPositive_Basic", "YIsPositive_Bit");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector<T>[] samples = {
                Vectors<T>.Serial,
                Vectors.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), -1.0),
                Vectors<T>.Demo,
                Vectors<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector<TOut> expected = Vectors.YIsPositive((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IVectorTraits instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector<TOut> dst = instance.YIsPositive((dynamic)value);
                    if (allowLog || (showNotEquals && !expected.Equals(dst))) {
                        writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                    }
                }
                writer.WriteLine();
            }
        }

        [TestCase((float)1, (int)1)]
        [TestCase((double)2, (long)1)]
        public void YIsPositiveInfinityTest<T, TOut>(T src, TOut srcOut) where T : struct where TOut : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsPositiveInfinity_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<Func<Vector<T>, Vector<TOut>>>("YIsPositiveInfinity_Basic", "YIsPositiveInfinity_Bit");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector<T>[] samples = {
                Vectors<T>.Serial,
                Vectors.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), -1.0),
                Vectors<T>.Demo,
                Vectors<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector<TOut> expected = Vectors.YIsPositiveInfinity((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IVectorTraits instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector<TOut> dst = instance.YIsPositiveInfinity((dynamic)value);
                    if (allowLog || (showNotEquals && !expected.Equals(dst))) {
                        writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                    }
                }
                writer.WriteLine();
            }
        }

        [TestCase((float)1, (int)1)]
        [TestCase((double)2, (long)1)]
        public void YIsSubnormalTest<T, TOut>(T src, TOut srcOut) where T : struct where TOut : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsSubnormal_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<Func<Vector<T>, Vector<TOut>>>("YIsSubnormal_Basic", "YIsSubnormal_Bit");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector<T>[] samples = {
                Vectors<T>.Serial,
                Vectors.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), -1.0),
                Vectors<T>.Demo,
                Vectors<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector<TOut> expected = Vectors.YIsSubnormal((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IVectorTraits instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector<TOut> dst = instance.YIsSubnormal((dynamic)value);
                    if (allowLog || (showNotEquals && !expected.Equals(dst))) {
                        writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                    }
                }
                writer.WriteLine();
            }
        }

        [TestCase((float)1, (int)1)]
        [TestCase((double)2, (long)1)]
        [TestCase((sbyte)3, (sbyte)1)]
        [TestCase((byte)4, (byte)1)]
        [TestCase((short)5, (short)1)]
        [TestCase((ushort)6, (ushort)1)]
        [TestCase((int)7, (int)1)]
        [TestCase((uint)8, (uint)1)]
        [TestCase((long)9, (long)1)]
        [TestCase((ulong)10, (ulong)1)]
        public void YIsZeroTest<T, TOut>(T src, TOut srcOut) where T : struct where TOut : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsZero_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<Func<Vector<T>, Vector<TOut>>>("YIsZero_Basic", "YIsZero_Bit");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector<T>[] samples = {
                Vectors<T>.Serial,
                Vectors.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), -1.0),
                Vectors<T>.Demo,
                Vectors<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector<TOut> expected = Vectors.YIsZero((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IVectorTraits instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector<TOut> dst = instance.YIsZero((dynamic)value);
                    if (allowLog || (showNotEquals && !expected.Equals(dst))) {
                        writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                    }
                }
                writer.WriteLine();
            }
        }

        [TestCase((float)1, (int)1)]
        [TestCase((double)2, (long)1)]
        public void YIsZeroOrSubnormalTest<T, TOut>(T src, TOut srcOut) where T : struct where TOut : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsZeroOrSubnormal_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<Func<Vector<T>, Vector<TOut>>>("YIsZeroOrSubnormal_Basic", "YIsZeroOrSubnormal_Bit");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector<T>[] samples = {
                Vectors<T>.Serial,
                Vectors.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), -1.0),
                Vectors<T>.Demo,
                Vectors<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector<TOut> expected = Vectors.YIsZeroOrSubnormal((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IVectorTraits instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector<TOut> dst = instance.YIsZeroOrSubnormal((dynamic)value);
                    if (allowLog || (showNotEquals && !expected.Equals(dst))) {
                        writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                    }
                }
                writer.WriteLine();
            }
        }
    }
}
