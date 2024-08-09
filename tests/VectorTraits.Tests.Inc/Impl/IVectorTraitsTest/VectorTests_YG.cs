using NUnit.Framework;
#if !USED_NUNIT3
using NUnit.Framework.Legacy;
#endif
using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Text;
using Zyl.VectorTraits.Impl;
using Zyl.VectorTraits.Impl.Delegates;

namespace Zyl.VectorTraits.Tests.Impl.IVectorTraitsTest {
#if USED_NUNIT3
    using ClassicAssert = Assert;
#endif

    [TestFixture()]
    public class VectorTests_YG {

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
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseExInt128))]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseExUInt128))]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseInt128))]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseUInt128))]
        public void YGroup2UnzipTest<T>(T src) where T : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YGroup2Unzip_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<FuncIn2Out1<Vector<T>>>("YGroup2Unzip_Basic", "YGroup2Unzip_Narrow", "YGroup2Unzip_Permute", "YGroup2Unzip_Shuffle", "YGroup2Unzip_ShuffleX", "YGroup2Unzip_Unpack");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            if (!MyTestUtil.AllowDelegateOut) funcList.Clear();
            bool[] funcListUnsupported = new bool[funcList.Count];
            writer.WriteLine();
            // run.
            Vector<T>[] samples = {
                Vectors<T>.Serial,
                Vectors<T>.SerialDesc,
                Vectors<T>.SerialNegative,
                Vectors.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1.0),
                Vectors.CreateByDoubleLoop<T>(-Scalars.GetDoubleFrom(src), -1.0),
            };
            bool allowLog = true;
            for (int i = 0; i < samples.Length; i++) {
                Vector<T> data0 = samples[i];
                for (int j = 0; j < samples.Length; j++) {
                    if (j == i) continue;
                    Vector<T> data1 = samples[j];
                    Vector<T> dst0, dst1;
#pragma warning disable CS0618 // Type or member is obsolete
                    (Vector<T> expected0, Vector<T> expected1) = Vectors.YGroup2Unzip(data0, data1);
                    if (allowLog && 0 == i && 1 == j) {
                        writer.WriteLine(VectorTextUtil.Format("f({0}, {1}): {2}, {3}", data0, data1, expected0, expected1));
                    }
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        string funcName = instance.GetType().Name;
                        (dst0, dst1) = instance.YGroup2Unzip(data0, data1);
                        ClassicAssert.IsTrue(expected0.BitEquals(dst0), VectorTextUtil.Format("{0} != {1}. Part 0 on {2}: {3}, {4}", expected0, dst0, funcName, data0, data1));
                        ClassicAssert.IsTrue(expected1.BitEquals(dst1), VectorTextUtil.Format("{0} != {1}. Part 1 on {2}: {3}, {4}", expected1, dst1, funcName, data0, data1));
                    }
                    for (int f = 0; f < funcList.Count; f++) {
                        if (funcListUnsupported[f]) continue;
                        var func = funcList[f];
                        string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                        try {
                            dst0 = func(data0, data1, out dst1);
                        } catch (NotSupportedException ex) {
                            funcListUnsupported[f] = true;
                            writer.WriteLine(VectorTextUtil.Format("NotSupportedException on {0}: {1}, {2}. {3}", funcName, data0, data1, ex.Message));
                            continue;
                        }
                        ClassicAssert.IsTrue(expected0.BitEquals(dst0), VectorTextUtil.Format("{0} != {1}. Part 0 on {2}: {3}, {4}", expected0, dst0, funcName, data0, data1));
                        ClassicAssert.IsTrue(expected1.BitEquals(dst1), VectorTextUtil.Format("{0} != {1}. Part 1 on {2}: {3}, {4}", expected1, dst1, funcName, data0, data1));
                    } // funcList
#pragma warning restore CS0618 // Type or member is obsolete
                }
            }
        }

        [TestCase((byte)4)]
#if EX_APPLY_GENERIC
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseExInt128))]
#endif // EX_APPLY_GENERIC
        public void YGroup2Unzip_Int128Test<T>(T src) where T : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YGroup2Unzip_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            writer.WriteLine();
            // run.
            Vector<T>[] samples = {
                Vectors<T>.Serial,
                Vectors<T>.SerialDesc,
                Vectors<T>.SerialNegative,
                Vectors.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1.0),
                Vectors.CreateByDoubleLoop<T>(-Scalars.GetDoubleFrom(src), -1.0),
            };
            bool allowLog = true;
            for (int i = 0; i < samples.Length; i++) {
                Vector<T> data0 = samples[i];
                for (int j = 0; j < samples.Length; j++) {
                    if (j == i) continue;
                    Vector<T> data1 = samples[j];
                    Vector<T> dst0, dst1;
#pragma warning disable CS0618 // Type or member is obsolete
                    Vector<T> expected0 = Vectors.YGroup2Unzip_Int128(data0, data1, out Vector<T> expected1);
                    if (allowLog && 0 == i && 1 == j) {
                        writer.WriteLine(VectorTextUtil.Format("f({0}, {1}): {2}, {3}", data0, data1, expected0, expected1));
                    }
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        string funcName = instance.GetType().Name;
                        dst0 = instance.YGroup2Unzip_Int128(data0, data1, out dst1);
                        ClassicAssert.IsTrue(expected0.BitEquals(dst0), VectorTextUtil.Format("{0} != {1}. Part 0 on {2}: {3}, {4}", expected0, dst0, funcName, data0, data1));
                        ClassicAssert.IsTrue(expected1.BitEquals(dst1), VectorTextUtil.Format("{0} != {1}. Part 1 on {2}: {3}, {4}", expected1, dst1, funcName, data0, data1));
                    }
#pragma warning restore CS0618 // Type or member is obsolete
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
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseExInt128))]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseExUInt128))]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseInt128))]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseUInt128))]
        public void YGroup2UnzipEvenTest<T>(T src) where T : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YGroup2UnzipEven_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<Func<Vector<T>, Vector<T>, Vector<T>>>("YGroup2UnzipEven_Basic", "YGroup2UnzipEven_Narrow", "YGroup2UnzipEven_Permute", "YGroup2UnzipEven_Unpack");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            bool[] funcListUnsupported = new bool[funcList.Count];
            writer.WriteLine();
            // run.
            Vector<T>[] samples = {
                Vectors<T>.Serial,
                Vectors<T>.SerialDesc,
                Vectors<T>.SerialNegative,
                Vectors.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1.0),
                Vectors.CreateByDoubleLoop<T>(-Scalars.GetDoubleFrom(src), -1.0),
            };
            bool allowLog = false;
            for (int i = 0; i < samples.Length; i++) {
                Vector<T> data0 = samples[i];
                for (int j = 0; j < samples.Length; j++) {
                    if (j == i) continue;
                    Vector<T> data1 = samples[j];
                    Vector<T> dst;
#pragma warning disable CS0618 // Type or member is obsolete
                    Vector<T> expected = Vectors.YGroup2UnzipEven<T>(data0, data1);
                    if (allowLog && 0 == i && 1 == j) {
                        writer.WriteLine(VectorTextUtil.Format("f({0}, {1}): {2}", data0, data1, expected));
                    }
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        string funcName = instance.GetType().Name;
                        dst = instance.YGroup2UnzipEven<T>(data0, data1);
                        ClassicAssert.IsTrue(expected.BitEquals(dst), VectorTextUtil.Format("{0} != {1}. {2}: {3}, {4}", expected, dst, funcName, data0, data1));
                    }
                    for (int f = 0; f < funcList.Count; f++) {
                        if (funcListUnsupported[f]) continue;
                        var func = funcList[f];
                        string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                        try {
                            dst = func(data0, data1);
                        } catch (NotSupportedException ex) {
                            funcListUnsupported[f] = true;
                            writer.WriteLine(VectorTextUtil.Format("NotSupportedException on {0}: {1}, {2}. {3}", funcName, data0, data1, ex.Message));
                            continue;
                        }
                        ClassicAssert.IsTrue(expected.BitEquals(dst), VectorTextUtil.Format("{0} != {1}. {2}: {3}, {4}", expected, dst, funcName, data0, data1));
                    } // funcList
#pragma warning restore CS0618 // Type or member is obsolete
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
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseExInt128))]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseExUInt128))]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseInt128))]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseUInt128))]
        public void YGroup2UnzipOddTest<T>(T src) where T : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YGroup2UnzipOdd_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<Func<Vector<T>, Vector<T>, Vector<T>>>("YGroup2UnzipOdd_Basic", "YGroup2UnzipOdd_Narrow", "YGroup2UnzipOdd_Permute", "YGroup2UnzipOdd_Unpack");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            bool[] funcListUnsupported = new bool[funcList.Count];
            writer.WriteLine();
            // run.
            Vector<T>[] samples = {
                Vectors<T>.Serial,
                Vectors<T>.SerialDesc,
                Vectors<T>.SerialNegative,
                Vectors.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1.0),
                Vectors.CreateByDoubleLoop<T>(-Scalars.GetDoubleFrom(src), -1.0),
            };
            bool allowLog = false;
            for (int i = 0; i < samples.Length; i++) {
                Vector<T> data0 = samples[i];
                for (int j = 0; j < samples.Length; j++) {
                    if (j == i) continue;
                    Vector<T> data1 = samples[j];
                    Vector<T> dst;
#pragma warning disable CS0618 // Type or member is obsolete
                    Vector<T> expected = Vectors.YGroup2UnzipOdd<T>(data0, data1);
                    if (allowLog && 0 == i && 1 == j) {
                        writer.WriteLine(VectorTextUtil.Format("f({0}, {1}): {2}", data0, data1, expected));
                    }
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        string funcName = instance.GetType().Name;
                        dst = instance.YGroup2UnzipOdd<T>(data0, data1);
                        ClassicAssert.IsTrue(expected.BitEquals(dst), VectorTextUtil.Format("{0} != {1}. {2}: {3}, {4}", expected, dst, funcName, data0, data1));
                    }
                    for (int f = 0; f < funcList.Count; f++) {
                        if (funcListUnsupported[f]) continue;
                        var func = funcList[f];
                        string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                        try {
                            dst = func(data0, data1);
                        } catch (NotSupportedException ex) {
                            funcListUnsupported[f] = true;
                            writer.WriteLine(VectorTextUtil.Format("NotSupportedException on {0}: {1}, {2}. {3}", funcName, data0, data1, ex.Message));
                            continue;
                        }
                        ClassicAssert.IsTrue(expected.BitEquals(dst), VectorTextUtil.Format("{0} != {1}. {2}: {3}, {4}", expected, dst, funcName, data0, data1));
                    } // funcList
#pragma warning restore CS0618 // Type or member is obsolete
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
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseExInt128))]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseExUInt128))]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseInt128))]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseUInt128))]
        public void YGroup2ZipTest<T>(T src) where T : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YGroup2Zip_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<FuncIn2Out1<Vector<T>>>("YGroup2Zip_Basic", "YGroup2Zip_Permute", "YGroup2Zip_Shuffle", "YGroup2Zip_ShuffleX", "YGroup2Zip_Unpack", "YGroup2Zip_Widen");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            if (!MyTestUtil.AllowDelegateOut) funcList.Clear();
            bool[] funcListUnsupported = new bool[funcList.Count];
            writer.WriteLine();
            // run.
            Vector<T>[] samples = {
                Vectors<T>.Serial,
                Vectors<T>.SerialDesc,
                Vectors<T>.SerialNegative,
                Vectors.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1.0),
                Vectors.CreateByDoubleLoop<T>(-Scalars.GetDoubleFrom(src), -1.0),
            };
            bool allowLog = false;
            for (int i = 0; i < samples.Length; i++) {
                Vector<T> x = samples[i];
                for (int j = 0; j < samples.Length; j++) {
                    if (j == i) continue;
                    Vector<T> y = samples[j];
                    Vector<T> dst0, dst1;
#pragma warning disable CS0618 // Type or member is obsolete
                    (Vector<T> expected0, Vector<T> expected1) = Vectors.YGroup2Zip(x, y);
                    if (allowLog && 0 == i && 1 == j) {
                        writer.WriteLine(VectorTextUtil.Format("f({0}, {1}): {2}, {3}", x, y, expected0, expected1));
                    }
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        string funcName = instance.GetType().Name;
                        (dst0, dst1) = instance.YGroup2Zip(x, y);
                        ClassicAssert.IsTrue(expected0.BitEquals(dst0), VectorTextUtil.Format("{0} != {1}. Part 0 on {2}: {3}, {4}", expected0, dst0, funcName, x, y));
                        ClassicAssert.IsTrue(expected1.BitEquals(dst1), VectorTextUtil.Format("{0} != {1}. Part 1 on {2}: {3}, {4}", expected1, dst1, funcName, x, y));
                    }
                    for (int f = 0; f < funcList.Count; f++) {
                        if (funcListUnsupported[f]) continue;
                        var func = funcList[f];
                        string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                        try {
                            dst0 = func(x, y, out dst1);
                        } catch (NotSupportedException ex) {
                            funcListUnsupported[f] = true;
                            writer.WriteLine(VectorTextUtil.Format("NotSupportedException on {0}: {1}, {2}. {3}", funcName, x, y, ex.Message));
                            continue;
                        }
                        ClassicAssert.IsTrue(expected0.BitEquals(dst0), VectorTextUtil.Format("{0} != {1}. Part 0 on {2}: {3}, {4}", expected0, dst0, funcName, x, y));
                        ClassicAssert.IsTrue(expected1.BitEquals(dst1), VectorTextUtil.Format("{0} != {1}. Part 1 on {2}: {3}, {4}", expected1, dst1, funcName, x, y));
                    } // funcList
#pragma warning restore CS0618 // Type or member is obsolete
                }
            }
        }

        [TestCase((byte)4)]
#if EX_APPLY_GENERIC
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseExInt128))]
#endif // EX_APPLY_GENERIC
        public void YGroup2Zip_Int128Test<T>(T src) where T : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YGroup2Zip_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            writer.WriteLine();
            // run.
            Vector<T>[] samples = {
                Vectors<T>.Serial,
                Vectors<T>.SerialDesc,
                Vectors<T>.SerialNegative,
                Vectors.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1.0),
                Vectors.CreateByDoubleLoop<T>(-Scalars.GetDoubleFrom(src), -1.0),
            };
            bool allowLog = false;
            for (int i = 0; i < samples.Length; i++) {
                Vector<T> x = samples[i];
                for (int j = 0; j < samples.Length; j++) {
                    if (j == i) continue;
                    Vector<T> y = samples[j];
                    Vector<T> dst0, dst1;
#pragma warning disable CS0618 // Type or member is obsolete
                    Vector<T> expected0 = Vectors.YGroup2Zip_Int128(x, y, out Vector<T> expected1);
                    if (allowLog && 0 == i && 1 == j) {
                        writer.WriteLine(VectorTextUtil.Format("f({0}, {1}): {2}, {3}", x, y, expected0, expected1));
                    }
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        string funcName = instance.GetType().Name;
                        dst0 = instance.YGroup2Zip_Int128(x, y, out dst1);
                        ClassicAssert.IsTrue(expected0.BitEquals(dst0), VectorTextUtil.Format("{0} != {1}. Part 0 on {2}: {3}, {4}", expected0, dst0, funcName, x, y));
                        ClassicAssert.IsTrue(expected1.BitEquals(dst1), VectorTextUtil.Format("{0} != {1}. Part 1 on {2}: {3}, {4}", expected1, dst1, funcName, x, y));
                    }
#pragma warning restore CS0618 // Type or member is obsolete
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
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseExInt128))]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseExUInt128))]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseInt128))]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseUInt128))]
        public void YGroup2ZipHighTest<T>(T src) where T : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YGroup2ZipHigh_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<Func<Vector<T>, Vector<T>, Vector<T>>>("YGroup2ZipHigh_Basic", "YGroup2ZipHigh_Permute", "YGroup2ZipHigh_Unpack", "YGroup2ZipHigh_Widen");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            bool[] funcListUnsupported = new bool[funcList.Count];
            writer.WriteLine();
            // run.
            Vector<T>[] samples = {
                Vectors<T>.Serial,
                Vectors<T>.SerialDesc,
                Vectors<T>.SerialNegative,
                Vectors.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1.0),
                Vectors.CreateByDoubleLoop<T>(-Scalars.GetDoubleFrom(src), -1.0),
            };
            bool allowLog = false;
            for (int i = 0; i < samples.Length; i++) {
                Vector<T> x = samples[i];
                for (int j = 0; j < samples.Length; j++) {
                    if (j == i) continue;
                    Vector<T> y = samples[j];
                    Vector<T> dst;
#pragma warning disable CS0618 // Type or member is obsolete
                    Vector<T> expected = Vectors.YGroup2ZipHigh<T>(x, y);
                    if (allowLog && 0 == i && 1 == j) {
                        writer.WriteLine(VectorTextUtil.Format("f({0}, {1}): {2}", x, y, expected));
                    }
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        string funcName = instance.GetType().Name;
                        dst = instance.YGroup2ZipHigh<T>(x, y);
                        ClassicAssert.IsTrue(expected.BitEquals(dst), VectorTextUtil.Format("{0} != {1}. {2}: {3}, {4}", expected, dst, funcName, x, y));
                    }
                    for (int f = 0; f < funcList.Count; f++) {
                        if (funcListUnsupported[f]) continue;
                        var func = funcList[f];
                        string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                        try {
                            dst = func(x, y);
                        } catch (NotSupportedException ex) {
                            funcListUnsupported[f] = true;
                            writer.WriteLine(VectorTextUtil.Format("NotSupportedException on {0}: {1}, {2}. {3}", funcName, x, y, ex.Message));
                            continue;
                        }
                        ClassicAssert.IsTrue(expected.BitEquals(dst), VectorTextUtil.Format("{0} != {1}. {2}: {3}, {4}", expected, dst, funcName, x, y));
                    } // funcList
#pragma warning restore CS0618 // Type or member is obsolete
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
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseExInt128))]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseExUInt128))]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseInt128))]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseUInt128))]
        public void YGroup2ZipLowTest<T>(T src) where T : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YGroup2ZipLow_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<Func<Vector<T>, Vector<T>, Vector<T>>>("YGroup2ZipLow_Basic", "YGroup2ZipLow_Permute", "YGroup2ZipLow_Unpack", "YGroup2ZipLow_Widen");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            bool[] funcListUnsupported = new bool[funcList.Count];
            writer.WriteLine();
            // run.
            Vector<T>[] samples = {
                Vectors<T>.Serial,
                Vectors<T>.SerialDesc,
                Vectors<T>.SerialNegative,
                Vectors.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1.0),
                Vectors.CreateByDoubleLoop<T>(-Scalars.GetDoubleFrom(src), -1.0),
            };
            bool allowLog = false;
            for (int i = 0; i < samples.Length; i++) {
                Vector<T> x = samples[i];
                for (int j = 0; j < samples.Length; j++) {
                    if (j == i) continue;
                    Vector<T> y = samples[j];
                    Vector<T> dst;
#pragma warning disable CS0618 // Type or member is obsolete
                    Vector<T> expected = Vectors.YGroup2ZipLow<T>(x, y);
                    if (allowLog && 0 == i && 1 == j) {
                        writer.WriteLine(VectorTextUtil.Format("f({0}, {1}): {2}", x, y, expected));
                    }
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        string funcName = instance.GetType().Name;
                        dst = instance.YGroup2ZipLow<T>(x, y);
                        ClassicAssert.IsTrue(expected.BitEquals(dst), VectorTextUtil.Format("{0} != {1}. {2}: {3}, {4}", expected, dst, funcName, x, y));
                    }
                    for (int f = 0; f < funcList.Count; f++) {
                        if (funcListUnsupported[f]) continue;
                        var func = funcList[f];
                        string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                        try {
                            dst = func(x, y);
                        } catch (NotSupportedException ex) {
                            funcListUnsupported[f] = true;
                            writer.WriteLine(VectorTextUtil.Format("NotSupportedException on {0}: {1}, {2}. {3}", funcName, x, y, ex.Message));
                            continue;
                        }
                        ClassicAssert.IsTrue(expected.BitEquals(dst), VectorTextUtil.Format("{0} != {1}. {2}: {3}, {4}", expected, dst, funcName, x, y));
                    } // funcList
#pragma warning restore CS0618 // Type or member is obsolete
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
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseExInt128))]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseExUInt128))]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseInt128))]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseUInt128))]
        public void YGroup4UnzipTest<T>(T src) where T : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YGroup4Unzip_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<FuncIn4Out3<Vector<T>>>("YGroup4Unzip_Basic", "YGroup4Unzip_Move", "YGroup4Unzip_Narrow", "YGroup4Unzip_Permute", "YGroup4Unzip_PermuteLonger", "YGroup4Unzip_Shuffle", "YGroup4Unzip_ShuffleX", "YGroup4Unzip_Unpack", "YGroup4Unzip_Unzip");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            if (!MyTestUtil.AllowDelegateOut) funcList.Clear();
            bool[] funcListUnsupported = new bool[funcList.Count];
            writer.WriteLine();
            // run.
            Vector<T>[] samples = {
                Vectors<T>.Serial,
                Vectors<T>.SerialDesc,
                Vectors<T>.SerialNegative,
                Vectors.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1.0),
                Vectors.CreateByDoubleLoop<T>(-Scalars.GetDoubleFrom(src), -1.0),
            };
            bool allowLog = true;
            Vector<T> data2 = Vectors<T>.SerialDesc;
            Vector<T> data3 = Vectors<T>.SerialNegative;
            for (int i = 0; i < samples.Length; i++) {
                Vector<T> data0 = samples[i];
                for (int j = 0; j < samples.Length; j++) {
                    if (j == i) continue;
                    Vector<T> data1 = samples[j];
                    Vector<T> dst0, dst1, dst2, dst3;
#pragma warning disable CS0618 // Type or member is obsolete
                    (Vector<T> expected0, Vector<T> expected1, Vector<T> expected2, Vector<T> expected3) = Vectors.YGroup4Unzip(data0, data1, data2, data3);
                    if (allowLog && 0 == i && 1 == j) {
                        writer.WriteLine(VectorTextUtil.Format("f({0}, {1}, {2}, {3}): {4}, {5}, {6}, {7}", data0, data1, data2, data3, expected0, expected1, expected2, expected3));
                    }
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        string funcName = instance.GetType().Name;
                        (dst0, dst1, dst2, dst3) = instance.YGroup4Unzip(data0, data1, data2, data3);
                        ClassicAssert.IsTrue(expected0.BitEquals(dst0), VectorTextUtil.Format("{0} != {1}. Part 0 on {2}: {3}, {4}, {5}, {6}", expected0, dst0, funcName, data0, data1, data2, data3));
                        ClassicAssert.IsTrue(expected1.BitEquals(dst1), VectorTextUtil.Format("{0} != {1}. Part 1 on {2}: {3}, {4}, {5}, {6}", expected1, dst1, funcName, data0, data1, data2, data3));
                        ClassicAssert.IsTrue(expected2.BitEquals(dst2), VectorTextUtil.Format("{0} != {1}. Part 2 on {2}: {3}, {4}, {5}, {6}", expected2, dst2, funcName, data0, data1, data2, data3));
                        ClassicAssert.IsTrue(expected3.BitEquals(dst3), VectorTextUtil.Format("{0} != {1}. Part 3 on {2}: {3}, {4}, {5}, {6}", expected3, dst3, funcName, data0, data1, data2, data3));
                    }
                    for (int f = 0; f < funcList.Count; f++) {
                        if (funcListUnsupported[f]) continue;
                        var func = funcList[f];
                        string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                        try {
                            dst0 = func(data0, data1, data2, data3, out dst1, out dst2, out dst3);
                        } catch (NotSupportedException ex) {
                            funcListUnsupported[f] = true;
                            writer.WriteLine(VectorTextUtil.Format("NotSupportedException on {0}: {1}, {2}, {3}, {4}. {5}", funcName, data0, data1, data2, data3, ex.Message));
                            continue;
                        }
                        ClassicAssert.IsTrue(expected0.BitEquals(dst0), VectorTextUtil.Format("{0} != {1}. Part 0 on {2}: {3}, {4}, {5}, {6}", expected0, dst0, funcName, data0, data1, data2, data3));
                        ClassicAssert.IsTrue(expected1.BitEquals(dst1), VectorTextUtil.Format("{0} != {1}. Part 1 on {2}: {3}, {4}, {5}, {6}", expected1, dst1, funcName, data0, data1, data2, data3));
                        ClassicAssert.IsTrue(expected2.BitEquals(dst2), VectorTextUtil.Format("{0} != {1}. Part 2 on {2}: {3}, {4}, {5}, {6}", expected2, dst2, funcName, data0, data1, data2, data3));
                        ClassicAssert.IsTrue(expected3.BitEquals(dst3), VectorTextUtil.Format("{0} != {1}. Part 3 on {2}: {3}, {4}, {5}, {6}", expected3, dst3, funcName, data0, data1, data2, data3));
                    } // funcList
#pragma warning restore CS0618 // Type or member is obsolete
                }
            }
        }

        [TestCase((byte)4)]
#if EX_APPLY_GENERIC
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseExInt128))]
#endif // EX_APPLY_GENERIC
        public void YGroup4Unzip_Int128Test<T>(T src) where T : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YGroup4Unzip_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            writer.WriteLine();
            // run.
            Vector<T>[] samples = {
                Vectors<T>.Serial,
                Vectors<T>.SerialDesc,
                Vectors<T>.SerialNegative,
                Vectors.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1.0),
                Vectors.CreateByDoubleLoop<T>(-Scalars.GetDoubleFrom(src), -1.0),
            };
            bool allowLog = true;
            Vector<T> data2 = Vectors<T>.SerialDesc;
            Vector<T> data3 = Vectors<T>.SerialNegative;
            for (int i = 0; i < samples.Length; i++) {
                Vector<T> data0 = samples[i];
                for (int j = 0; j < samples.Length; j++) {
                    if (j == i) continue;
                    Vector<T> data1 = samples[j];
                    Vector<T> dst0, dst1, dst2, dst3;
#pragma warning disable CS0618 // Type or member is obsolete
                    Vector<T> expected0 = Vectors.YGroup4Unzip_Int128(data0, data1, data2, data3, out Vector<T> expected1, out Vector<T> expected2, out Vector<T> expected3);
                    if (allowLog && 0 == i && 1 == j) {
                        writer.WriteLine(VectorTextUtil.Format("f({0}, {1}, {2}, {3}): {4}, {5}, {6}, {7}", data0, data1, data2, data3, expected0, expected1, expected2, expected3));
                    }
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        string funcName = instance.GetType().Name;
                        dst0 = instance.YGroup4Unzip_Int128(data0, data1, data2, data3, out dst1, out dst2, out dst3);
                        ClassicAssert.IsTrue(expected0.BitEquals(dst0), VectorTextUtil.Format("{0} != {1}. Part 0 on {2}: {3}, {4}, {5}, {6}", expected0, dst0, funcName, data0, data1, data2, data3));
                        ClassicAssert.IsTrue(expected1.BitEquals(dst1), VectorTextUtil.Format("{0} != {1}. Part 1 on {2}: {3}, {4}, {5}, {6}", expected1, dst1, funcName, data0, data1, data2, data3));
                        ClassicAssert.IsTrue(expected2.BitEquals(dst2), VectorTextUtil.Format("{0} != {1}. Part 2 on {2}: {3}, {4}, {5}, {6}", expected2, dst2, funcName, data0, data1, data2, data3));
                        ClassicAssert.IsTrue(expected3.BitEquals(dst3), VectorTextUtil.Format("{0} != {1}. Part 3 on {2}: {3}, {4}, {5}, {6}", expected3, dst3, funcName, data0, data1, data2, data3));
                    }
#pragma warning restore CS0618 // Type or member is obsolete
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
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseExInt128))]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseExUInt128))]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseInt128))]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseUInt128))]
        public void YGroup4ZipTest<T>(T src) where T : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YGroup4Zip_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<FuncIn4Out3<Vector<T>>>("YGroup4Zip_Basic", "YGroup4Zip_Move", "YGroup4Zip_Narrow", "YGroup4Zip_Permute", "YGroup4Zip_PermuteLonger", "YGroup4Zip_Shuffle", "YGroup4Zip_ShuffleX", "YGroup4Zip_Unpack", "YGroup4Zip_Unzip");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            if (!MyTestUtil.AllowDelegateOut) funcList.Clear();
            bool[] funcListUnsupported = new bool[funcList.Count];
            writer.WriteLine();
            // run.
            Vector<T>[] samples = {
                Vectors<T>.Serial,
                Vectors<T>.SerialDesc,
                Vectors<T>.SerialNegative,
                Vectors.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1.0),
                Vectors.CreateByDoubleLoop<T>(-Scalars.GetDoubleFrom(src), -1.0),
            };
            bool allowLog = true;
            Vector<T> data2 = Vectors<T>.SerialDesc;
            Vector<T> data3 = Vectors<T>.SerialNegative;
            for (int i = 0; i < samples.Length; i++) {
                Vector<T> data0 = samples[i];
                for (int j = 0; j < samples.Length; j++) {
                    if (j == i) continue;
                    Vector<T> data1 = samples[j];
                    Vector<T> dst0, dst1, dst2, dst3;
#pragma warning disable CS0618 // Type or member is obsolete
                    (Vector<T> expected0, Vector<T> expected1, Vector<T> expected2, Vector<T> expected3) = Vectors.YGroup4Zip(data0, data1, data2, data3);
                    if (allowLog && 0 == i && 1 == j) {
                        writer.WriteLine(VectorTextUtil.Format("f({0}, {1}, {2}, {3}): {4}, {5}, {6}, {7}", data0, data1, data2, data3, expected0, expected1, expected2, expected3));
                    }
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        string funcName = instance.GetType().Name;
                        (dst0, dst1, dst2, dst3) = instance.YGroup4Zip(data0, data1, data2, data3);
                        ClassicAssert.IsTrue(expected0.BitEquals(dst0), VectorTextUtil.Format("{0} != {1}. Part 0 on {2}: {3}, {4}, {5}, {6}", expected0, dst0, funcName, data0, data1, data2, data3));
                        ClassicAssert.IsTrue(expected1.BitEquals(dst1), VectorTextUtil.Format("{0} != {1}. Part 1 on {2}: {3}, {4}, {5}, {6}", expected1, dst1, funcName, data0, data1, data2, data3));
                        ClassicAssert.IsTrue(expected2.BitEquals(dst2), VectorTextUtil.Format("{0} != {1}. Part 2 on {2}: {3}, {4}, {5}, {6}", expected2, dst2, funcName, data0, data1, data2, data3));
                        ClassicAssert.IsTrue(expected3.BitEquals(dst3), VectorTextUtil.Format("{0} != {1}. Part 3 on {2}: {3}, {4}, {5}, {6}", expected3, dst3, funcName, data0, data1, data2, data3));
                    }
                    for (int f = 0; f < funcList.Count; f++) {
                        if (funcListUnsupported[f]) continue;
                        var func = funcList[f];
                        string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                        try {
                            dst0 = func(data0, data1, data2, data3, out dst1, out dst2, out dst3);
                        } catch (NotSupportedException ex) {
                            funcListUnsupported[f] = true;
                            writer.WriteLine(VectorTextUtil.Format("NotSupportedException on {0}: {1}, {2}, {3}, {4}. {5}", funcName, data0, data1, data2, data3, ex.Message));
                            continue;
                        }
                        ClassicAssert.IsTrue(expected0.BitEquals(dst0), VectorTextUtil.Format("{0} != {1}. Part 0 on {2}: {3}, {4}, {5}, {6}", expected0, dst0, funcName, data0, data1, data2, data3));
                        ClassicAssert.IsTrue(expected1.BitEquals(dst1), VectorTextUtil.Format("{0} != {1}. Part 1 on {2}: {3}, {4}, {5}, {6}", expected1, dst1, funcName, data0, data1, data2, data3));
                        ClassicAssert.IsTrue(expected2.BitEquals(dst2), VectorTextUtil.Format("{0} != {1}. Part 2 on {2}: {3}, {4}, {5}, {6}", expected2, dst2, funcName, data0, data1, data2, data3));
                        ClassicAssert.IsTrue(expected3.BitEquals(dst3), VectorTextUtil.Format("{0} != {1}. Part 3 on {2}: {3}, {4}, {5}, {6}", expected3, dst3, funcName, data0, data1, data2, data3));
                    } // funcList
#pragma warning restore CS0618 // Type or member is obsolete
                }
            }
        }

        [TestCase((byte)4)]
#if EX_APPLY_GENERIC
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseExInt128))]
#endif // EX_APPLY_GENERIC
        public void YGroup4Zip_Int128Test<T>(T src) where T : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YGroup4Zip_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            writer.WriteLine();
            // run.
            Vector<T>[] samples = {
                Vectors<T>.Serial,
                Vectors<T>.SerialDesc,
                Vectors<T>.SerialNegative,
                Vectors.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1.0),
                Vectors.CreateByDoubleLoop<T>(-Scalars.GetDoubleFrom(src), -1.0),
            };
            bool allowLog = true;
            Vector<T> data2 = Vectors<T>.SerialDesc;
            Vector<T> data3 = Vectors<T>.SerialNegative;
            for (int i = 0; i < samples.Length; i++) {
                Vector<T> data0 = samples[i];
                for (int j = 0; j < samples.Length; j++) {
                    if (j == i) continue;
                    Vector<T> data1 = samples[j];
                    Vector<T> dst0, dst1, dst2, dst3;
#pragma warning disable CS0618 // Type or member is obsolete
                    Vector<T> expected0 = Vectors.YGroup4Zip_Int128(data0, data1, data2, data3, out Vector<T> expected1, out Vector<T> expected2, out Vector<T> expected3);
                    if (allowLog && 0 == i && 1 == j) {
                        writer.WriteLine(VectorTextUtil.Format("f({0}, {1}, {2}, {3}): {4}, {5}, {6}, {7}", data0, data1, data2, data3, expected0, expected1, expected2, expected3));
                    }
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        string funcName = instance.GetType().Name;
                        dst0 = instance.YGroup4Zip_Int128(data0, data1, data2, data3, out dst1, out dst2, out dst3);
                        ClassicAssert.IsTrue(expected0.BitEquals(dst0), VectorTextUtil.Format("{0} != {1}. Part 0 on {2}: {3}, {4}, {5}, {6}", expected0, dst0, funcName, data0, data1, data2, data3));
                        ClassicAssert.IsTrue(expected1.BitEquals(dst1), VectorTextUtil.Format("{0} != {1}. Part 1 on {2}: {3}, {4}, {5}, {6}", expected1, dst1, funcName, data0, data1, data2, data3));
                        ClassicAssert.IsTrue(expected2.BitEquals(dst2), VectorTextUtil.Format("{0} != {1}. Part 2 on {2}: {3}, {4}, {5}, {6}", expected2, dst2, funcName, data0, data1, data2, data3));
                        ClassicAssert.IsTrue(expected3.BitEquals(dst3), VectorTextUtil.Format("{0} != {1}. Part 3 on {2}: {3}, {4}, {5}, {6}", expected3, dst3, funcName, data0, data1, data2, data3));
                    }
#pragma warning restore CS0618 // Type or member is obsolete
                }
            }
        }

    }
}
