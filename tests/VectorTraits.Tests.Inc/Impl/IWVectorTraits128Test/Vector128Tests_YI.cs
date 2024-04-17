﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Tests.Impl.IWVectorTraits128Test {
    [TestFixture()]
    public class Vector128Tests_YI {
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
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsAllTrue_AcceleratedTypes}");
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
            foreach (Vector128<T> left in samples) {
                foreach (Vector128<T> right in samples) {
#if NET7_0_OR_GREATER
                    Vector128<T> expectedSrc = Vector128.Equals(left, right);
#else
                    Vector128<T> expectedSrc = Vector128s.Equals((dynamic)left, (dynamic)right);
#endif // NET7_0_OR_GREATER
                    bool expected = Vector128s.YIsAllTrue(expectedSrc);
                    foreach (IWVectorTraits128 instance in instances) {
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
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsAnyTrue_AcceleratedTypes}");
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
            foreach (Vector128<T> left in samples) {
                foreach (Vector128<T> right in samples) {
#if NET7_0_OR_GREATER
                    Vector128<T> expectedSrc = Vector128.Equals(left, right);
#else
                    Vector128<T> expectedSrc = Vector128s.Equals((dynamic)left, (dynamic)right);
#endif // NET7_0_OR_GREATER
                    bool expected = Vector128s.YIsAnyTrue(expectedSrc);
                    foreach (IWVectorTraits128 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        bool dst = instance.YIsAnyTrue(expectedSrc);
                        Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={expectedSrc}");
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
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsEvenInteger_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector128s.GetSupportedMethodList<Func<Vector128<T>, Vector128<TOut>>>("YIsEvenInteger_Basic", "YIsEvenInteger_Bit");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector128<T>[] samples = {
                Vector128s<T>.Serial,
                Vector128s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), -1.0),
                Vector128s<T>.Demo,
                Vector128s<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector128<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector128<TOut> expected = Vector128s.YIsEvenInteger((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<TOut> dst = instance.YIsEvenInteger((dynamic)value);
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
        public void YIsFiniteTest<T, TOut>(T src, TOut srcOut) where T : struct where TOut : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsFinite_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector128s.GetSupportedMethodList<Func<Vector128<T>, Vector128<TOut>>>("YIsFinite_Basic", "YIsFinite_Bit");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector128<T>[] samples = {
                Vector128s<T>.Serial,
                Vector128s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), -1.0),
                Vector128s<T>.Demo,
                Vector128s<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector128<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector128<TOut> expected = Vector128s.YIsFinite((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<TOut> dst = instance.YIsFinite((dynamic)value);
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
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsInfinity_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector128s.GetSupportedMethodList<Func<Vector128<T>, Vector128<TOut>>>("YIsInfinity_Basic", "YIsInfinity_Bit");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector128<T>[] samples = {
                Vector128s<T>.Serial,
                Vector128s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), -1.0),
                Vector128s<T>.Demo,
                Vector128s<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector128<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector128<TOut> expected = Vector128s.YIsInfinity((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<TOut> dst = instance.YIsInfinity((dynamic)value);
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
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsInfinityOrNaN_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector128s.GetSupportedMethodList<Func<Vector128<T>, Vector128<TOut>>>("YIsInfinityOrNaN_Basic", "YIsInfinityOrNaN_Bit");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector128<T>[] samples = {
                Vector128s<T>.Serial,
                Vector128s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), -1.0),
                Vector128s<T>.Demo,
                Vector128s<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector128<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector128<TOut> expected = Vector128s.YIsInfinityOrNaN((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<TOut> dst = instance.YIsInfinityOrNaN((dynamic)value);
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
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsInteger_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector128s.GetSupportedMethodList<Func<Vector128<T>, Vector128<TOut>>>("YIsInteger_Basic", "YIsInteger_Bit");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector128<T>[] samples = {
                Vector128s<T>.Serial,
                Vector128s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), -1.0),
                Vector128s<T>.Demo,
                Vector128s<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector128<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector128<TOut> expected = Vector128s.YIsInteger((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<TOut> dst = instance.YIsInteger((dynamic)value);
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
        public void YIsNaNTest<T, TOut>(T src, TOut srcOut) where T : struct where TOut : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsNaN_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector128s.GetSupportedMethodList<Func<Vector128<T>, Vector128<TOut>>>("YIsNaN_Basic", "YIsNaN_Bit");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector128<T>[] samples = {
                Vector128s<T>.Serial,
                Vector128s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), -1.0),
                Vector128s<T>.Demo,
                Vector128s<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector128<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector128<TOut> expected = Vector128s.YIsNaN((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<TOut> dst = instance.YIsNaN((dynamic)value);
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
        [TestCase((sbyte)3, (sbyte)1)]
        [TestCase((short)5, (short)1)]
        [TestCase((int)7, (int)1)]
        [TestCase((long)9, (long)1)]
        public void YIsNegativeTest<T, TOut>(T src, TOut srcOut) where T : struct where TOut : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsNegative_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector128s.GetSupportedMethodList<Func<Vector128<T>, Vector128<TOut>>>("YIsNegative_Basic", "YIsNegative_Bit");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector128<T>[] samples = {
                Vector128s<T>.Serial,
                Vector128s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), -1.0),
                Vector128s<T>.Demo,
                Vector128s<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector128<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector128<TOut> expected = Vector128s.YIsNegative((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<TOut> dst = instance.YIsNegative((dynamic)value);
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
        public void YIsNegativeInfinityTest<T, TOut>(T src, TOut srcOut) where T : struct where TOut : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsNegativeInfinity_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector128s.GetSupportedMethodList<Func<Vector128<T>, Vector128<TOut>>>("YIsNegativeInfinity_Basic", "YIsNegativeInfinity_Bit");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector128<T>[] samples = {
                Vector128s<T>.Serial,
                Vector128s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), -1.0),
                Vector128s<T>.Demo,
                Vector128s<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector128<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector128<TOut> expected = Vector128s.YIsNegativeInfinity((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<TOut> dst = instance.YIsNegativeInfinity((dynamic)value);
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
        public void YIsNegativeZeroTest<T, TOut>(T src, TOut srcOut) where T : struct where TOut : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsNegativeZero_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector128s.GetSupportedMethodList<Func<Vector128<T>, Vector128<TOut>>>("YIsNegativeZero_Basic", "YIsNegativeZero_Bit");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector128<T>[] samples = {
                Vector128s<T>.Serial,
                Vector128s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), -1.0),
                Vector128s<T>.Demo,
                Vector128s<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector128<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector128<TOut> expected = Vector128s.YIsNegativeZero((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<TOut> dst = instance.YIsNegativeZero((dynamic)value);
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
        public void YIsNormalTest<T, TOut>(T src, TOut srcOut) where T : struct where TOut : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsNormal_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector128s.GetSupportedMethodList<Func<Vector128<T>, Vector128<TOut>>>("YIsNormal_Basic", "YIsNormal_Bit");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector128<T>[] samples = {
                Vector128s<T>.Serial,
                Vector128s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), -1.0),
                Vector128s<T>.Demo,
                Vector128s<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector128<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector128<TOut> expected = Vector128s.YIsNormal((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<TOut> dst = instance.YIsNormal((dynamic)value);
                    if (allowLog || (showNotEquals && !expected.Equals(dst))) {
                        writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
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
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsNotEquals_AcceleratedTypes}");
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
            bool showNotYIsNotEquals = false;
            foreach (Vector128<T> left in samples) {
                foreach (Vector128<T> right in samples) {
                    Vector128<T> expected = Vector128s.YIsNotEquals((dynamic)left, (dynamic)right);
                    foreach (IWVectorTraits128 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        Vector128<T> dst = instance.YIsNotEquals((dynamic)left, (dynamic)right);
                        bool showLog = showNotYIsNotEquals && !expected.AsByte().Equals(dst.AsByte());
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

        [TestCase((float)1, (int)1)]
        [TestCase((double)2, (long)1)]
        public void YIsNotNaNTest<T, TOut>(T src, TOut srcOut) where T : struct where TOut : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsNotNaN_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector128s.GetSupportedMethodList<Func<Vector128<T>, Vector128<TOut>>>("YIsNotNaN_Basic", "YIsNotNaN_Bit");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector128<T>[] samples = {
                Vector128s<T>.Serial,
                Vector128s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), -1.0),
                Vector128s<T>.Demo,
                Vector128s<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector128<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector128<TOut> expected = Vector128s.YIsNotNaN((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<TOut> dst = instance.YIsNotNaN((dynamic)value);
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
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsOddInteger_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector128s.GetSupportedMethodList<Func<Vector128<T>, Vector128<TOut>>>("YIsOddInteger_Basic", "YIsOddInteger_Bit");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector128<T>[] samples = {
                Vector128s<T>.Serial,
                Vector128s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), -1.0),
                Vector128s<T>.Demo,
                Vector128s<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector128<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector128<TOut> expected = Vector128s.YIsOddInteger((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<TOut> dst = instance.YIsOddInteger((dynamic)value);
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
        [TestCase((sbyte)3, (sbyte)1)]
        [TestCase((short)5, (short)1)]
        [TestCase((int)7, (int)1)]
        [TestCase((long)9, (long)1)]
        public void YIsPositiveTest<T, TOut>(T src, TOut srcOut) where T : struct where TOut : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsPositive_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector128s.GetSupportedMethodList<Func<Vector128<T>, Vector128<TOut>>>("YIsPositive_Basic", "YIsPositive_Bit");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector128<T>[] samples = {
                Vector128s<T>.Serial,
                Vector128s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), -1.0),
                Vector128s<T>.Demo,
                Vector128s<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector128<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector128<TOut> expected = Vector128s.YIsPositive((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<TOut> dst = instance.YIsPositive((dynamic)value);
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
        public void YIsPositiveInfinityTest<T, TOut>(T src, TOut srcOut) where T : struct where TOut : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsPositiveInfinity_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector128s.GetSupportedMethodList<Func<Vector128<T>, Vector128<TOut>>>("YIsPositiveInfinity_Basic", "YIsPositiveInfinity_Bit");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector128<T>[] samples = {
                Vector128s<T>.Serial,
                Vector128s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), -1.0),
                Vector128s<T>.Demo,
                Vector128s<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector128<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector128<TOut> expected = Vector128s.YIsPositiveInfinity((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<TOut> dst = instance.YIsPositiveInfinity((dynamic)value);
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
        public void YIsSubnormalTest<T, TOut>(T src, TOut srcOut) where T : struct where TOut : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsSubnormal_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector128s.GetSupportedMethodList<Func<Vector128<T>, Vector128<TOut>>>("YIsSubnormal_Basic", "YIsSubnormal_Bit");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector128<T>[] samples = {
                Vector128s<T>.Serial,
                Vector128s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), -1.0),
                Vector128s<T>.Demo,
                Vector128s<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector128<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector128<TOut> expected = Vector128s.YIsSubnormal((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<TOut> dst = instance.YIsSubnormal((dynamic)value);
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
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsZero_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector128s.GetSupportedMethodList<Func<Vector128<T>, Vector128<TOut>>>("YIsZero_Basic", "YIsZero_Bit");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector128<T>[] samples = {
                Vector128s<T>.Serial,
                Vector128s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), -1.0),
                Vector128s<T>.Demo,
                Vector128s<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector128<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector128<TOut> expected = Vector128s.YIsZero((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<TOut> dst = instance.YIsZero((dynamic)value);
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
        public void YIsZeroOrSubnormalTest<T, TOut>(T src, TOut srcOut) where T : struct where TOut : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YIsZeroOrSubnormal_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector128s.GetSupportedMethodList<Func<Vector128<T>, Vector128<TOut>>>("YIsZeroOrSubnormal_Basic", "YIsZeroOrSubnormal_Bit");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector128<T>[] samples = {
                Vector128s<T>.Serial,
                Vector128s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), -1.0),
                Vector128s<T>.Demo,
                Vector128s<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector128<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector128<TOut> expected = Vector128s.YIsZeroOrSubnormal((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<TOut> dst = instance.YIsZeroOrSubnormal((dynamic)value);
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
