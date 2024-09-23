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
        public void YGroup1ToGroup3Test<T>(T src) where T : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YGroup1ToGroup3_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<FuncIn1Out2<Vector<T>>>("YGroup1ToGroup3_Basic", "YGroup1ToGroup3_Move", "YGroup1ToGroup3_Shuffle", "YGroup1ToGroup3_ShuffleX", "YGroup1ToGroup3_ShuffleXImm", "YGroup1ToGroup3_Zip");
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
                Vector<T> dst0, dst1, dst2;
#pragma warning disable CS0618 // Type or member is obsolete
                (Vector<T> expected0, Vector<T> expected1, Vector<T> expected2) = Vectors.YGroup1ToGroup3(data0);
                if (allowLog && 0 == i) {
                    writer.WriteLine(VectorTextUtil.Format("f({0}): {1}, {2}, {3}", data0, expected0, expected1, expected2));
                }
                foreach (IVectorTraits instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    string funcName = instance.GetType().Name;
                    (dst0, dst1, dst2) = instance.YGroup1ToGroup3(data0);
                    ClassicAssert.IsTrue(expected0.BitEquals(dst0), VectorTextUtil.Format("{0} != {1}. Part 0 on {2}: {3}", expected0, dst0, funcName, data0));
                    ClassicAssert.IsTrue(expected1.BitEquals(dst1), VectorTextUtil.Format("{0} != {1}. Part 1 on {2}: {3}", expected1, dst1, funcName, data0));
                    ClassicAssert.IsTrue(expected2.BitEquals(dst2), VectorTextUtil.Format("{0} != {1}. Part 2 on {2}: {3}", expected2, dst2, funcName, data0));
                }
                for (int f = 0; f < funcList.Count; f++) {
                    if (funcListUnsupported[f]) continue;
                    var func = funcList[f];
                    string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                    try {
                        dst0 = func(data0, out dst1, out dst2);
                    } catch (NotSupportedException ex) {
                        funcListUnsupported[f] = true;
                        writer.WriteLine(VectorTextUtil.Format("NotSupportedException on {0}: {1}. {2}", funcName, data0, ex.Message));
                        continue;
                    }
                    ClassicAssert.IsTrue(expected0.BitEquals(dst0), VectorTextUtil.Format("{0} != {1}. Part 0 on {2}: {3}", expected0, dst0, funcName, data0));
                    ClassicAssert.IsTrue(expected1.BitEquals(dst1), VectorTextUtil.Format("{0} != {1}. Part 1 on {2}: {3}", expected1, dst1, funcName, data0));
                    ClassicAssert.IsTrue(expected2.BitEquals(dst2), VectorTextUtil.Format("{0} != {1}. Part 2 on {2}: {3}", expected2, dst2, funcName, data0));
                } // funcList
#pragma warning restore CS0618 // Type or member is obsolete
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
        public void YGroup1ToGroup4Test<T>(T src) where T : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YGroup1ToGroup4_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<FuncIn1Out3<Vector<T>>>("YGroup1ToGroup4_Basic", "YGroup1ToGroup4_Move", "YGroup1ToGroup4_Shuffle", "YGroup1ToGroup4_ShuffleX", "YGroup1ToGroup4_ShuffleXImm", "YGroup1ToGroup4_Zip");
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
                Vector<T> dst0, dst1, dst2, dst3;
#pragma warning disable CS0618 // Type or member is obsolete
                (Vector<T> expected0, Vector<T> expected1, Vector<T> expected2, Vector<T> expected3) = Vectors.YGroup1ToGroup4(data0);
                if (allowLog && 0 == i) {
                    writer.WriteLine(VectorTextUtil.Format("f({0}): {1}, {2}, {3}", data0, expected0, expected1, expected2));
                }
                foreach (IVectorTraits instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    string funcName = instance.GetType().Name;
                    (dst0, dst1, dst2, dst3) = instance.YGroup1ToGroup4(data0);
                    ClassicAssert.IsTrue(expected0.BitEquals(dst0), VectorTextUtil.Format("{0} != {1}. Part 0 on {2}: {3}", expected0, dst0, funcName, data0));
                    ClassicAssert.IsTrue(expected1.BitEquals(dst1), VectorTextUtil.Format("{0} != {1}. Part 1 on {2}: {3}", expected1, dst1, funcName, data0));
                    ClassicAssert.IsTrue(expected2.BitEquals(dst2), VectorTextUtil.Format("{0} != {1}. Part 2 on {2}: {3}", expected2, dst2, funcName, data0));
                    ClassicAssert.IsTrue(expected3.BitEquals(dst3), VectorTextUtil.Format("{0} != {1}. Part 3 on {2}: {3}", expected3, dst3, funcName, data0));
                }
                for (int f = 0; f < funcList.Count; f++) {
                    if (funcListUnsupported[f]) continue;
                    var func = funcList[f];
                    string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                    try {
                        dst0 = func(data0, out dst1, out dst2, out dst3);
                    } catch (NotSupportedException ex) {
                        funcListUnsupported[f] = true;
                        writer.WriteLine(VectorTextUtil.Format("NotSupportedException on {0}: {1}. {2}", funcName, data0, ex.Message));
                        continue;
                    }
                    ClassicAssert.IsTrue(expected0.BitEquals(dst0), VectorTextUtil.Format("{0} != {1}. Part 0 on {2}: {3}", expected0, dst0, funcName, data0));
                    ClassicAssert.IsTrue(expected1.BitEquals(dst1), VectorTextUtil.Format("{0} != {1}. Part 1 on {2}: {3}", expected1, dst1, funcName, data0));
                    ClassicAssert.IsTrue(expected2.BitEquals(dst2), VectorTextUtil.Format("{0} != {1}. Part 2 on {2}: {3}", expected2, dst2, funcName, data0));
                    ClassicAssert.IsTrue(expected3.BitEquals(dst3), VectorTextUtil.Format("{0} != {1}. Part 3 on {2}: {3}", expected3, dst3, funcName, data0));
                } // funcList
#pragma warning restore CS0618 // Type or member is obsolete
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
        public void YGroup1ToGroup4WithWTest<T>(T src) where T : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YGroup1ToGroup4WithW_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<FuncIn2Out3<Vector<T>>>("YGroup1ToGroup4WithW_Basic", "YGroup1ToGroup4WithW_Move", "YGroup1ToGroup4WithW_Narrow", "YGroup1ToGroup4WithW_Permute", "YGroup1ToGroup4WithW_PermuteLonger", "YGroup1ToGroup4WithW_Shuffle", "YGroup1ToGroup4WithW_ShuffleX", "YGroup1ToGroup4WithW_Unpack", "YGroup1ToGroup4WithW_Unzip");
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
                    Vector<T> dst0, dst1, dst2, dst3;
#pragma warning disable CS0618 // Type or member is obsolete
                    (Vector<T> expected0, Vector<T> expected1, Vector<T> expected2, Vector<T> expected3) = Vectors.YGroup1ToGroup4WithW(data0, data1);
                    if (allowLog && 0 == i && 1 == j) {
                        writer.WriteLine(VectorTextUtil.Format("f({0}, {1}): {2}, {3}, {4}, {5}", data0, data1, expected0, expected1, expected2, expected3));
                    }
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        string funcName = instance.GetType().Name;
                        (dst0, dst1, dst2, dst3) = instance.YGroup1ToGroup4WithW(data0, data1);
                        ClassicAssert.IsTrue(expected0.BitEquals(dst0), VectorTextUtil.Format("{0} != {1}. Part 0 on {2}: {3}, {4}", expected0, dst0, funcName, data0, data1));
                        ClassicAssert.IsTrue(expected1.BitEquals(dst1), VectorTextUtil.Format("{0} != {1}. Part 1 on {2}: {3}, {4}", expected1, dst1, funcName, data0, data1));
                        ClassicAssert.IsTrue(expected2.BitEquals(dst2), VectorTextUtil.Format("{0} != {1}. Part 2 on {2}: {3}, {4}", expected2, dst2, funcName, data0, data1));
                        ClassicAssert.IsTrue(expected3.BitEquals(dst3), VectorTextUtil.Format("{0} != {1}. Part 3 on {2}: {3}, {4}", expected3, dst3, funcName, data0, data1));
                    }
                    for (int f = 0; f < funcList.Count; f++) {
                        if (funcListUnsupported[f]) continue;
                        var func = funcList[f];
                        string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                        try {
                            dst0 = func(data0, data1, out dst1, out dst2, out dst3);
                        } catch (NotSupportedException ex) {
                            funcListUnsupported[f] = true;
                            writer.WriteLine(VectorTextUtil.Format("NotSupportedException on {0}: {1}, {2}. {3}", funcName, data0, data1, ex.Message));
                            continue;
                        }
                        ClassicAssert.IsTrue(expected0.BitEquals(dst0), VectorTextUtil.Format("{0} != {1}. Part 0 on {2}: {3}, {4}", expected0, dst0, funcName, data0, data1));
                        ClassicAssert.IsTrue(expected1.BitEquals(dst1), VectorTextUtil.Format("{0} != {1}. Part 1 on {2}: {3}, {4}", expected1, dst1, funcName, data0, data1));
                        ClassicAssert.IsTrue(expected2.BitEquals(dst2), VectorTextUtil.Format("{0} != {1}. Part 2 on {2}: {3}, {4}", expected2, dst2, funcName, data0, data1));
                        ClassicAssert.IsTrue(expected3.BitEquals(dst3), VectorTextUtil.Format("{0} != {1}. Part 3 on {2}: {3}, {4}", expected3, dst3, funcName, data0, data1));
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
        public void YGroup2Unzip_Bit128Test<T>(T src) where T : struct {
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
                    Vector<T> expected0 = Vectors.YGroup2Unzip_Bit128(data0, data1, out Vector<T> expected1);
                    if (allowLog && 0 == i && 1 == j) {
                        writer.WriteLine(VectorTextUtil.Format("f({0}, {1}): {2}, {3}", data0, data1, expected0, expected1));
                    }
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        string funcName = instance.GetType().Name;
                        dst0 = instance.YGroup2Unzip_Bit128(data0, data1, out dst1);
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
            if (!MyTestUtil.AllowDelegateMultiParam) funcList.Clear();
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
                    //if (Scalars<T>.BitSize >= 64) {
                    if (allowLog && 0 == i && 1 == j) {
                        writer.WriteLine(VectorTextUtil.Format("f({0}, {1}): {2}", data0, data1, expected));
                    }
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        string funcName = instance.GetType().Name;
                        dst = instance.YGroup2UnzipEven<T>(data0, data1);
                        ClassicAssert.IsTrue(expected.BitEquals(dst), VectorTextUtil.Format("{0} != {1}. {2}: {3}, {4}", expected, dst, funcName, data0, data1));
                    }
                    if (0 == i && 1 == j && funcList.Count > 0) {
                        //System.Diagnostics.Debugger.Break();
                    }
                    for (int f = 0; f < funcList.Count; f++) {
                        if (funcListUnsupported[f]) continue;
                        var func = funcList[f];
                        string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                        try {
                            //if (Scalars<T>.BitSize >= 64) {
                            //    writer.WriteLine(VectorTextUtil.Format("{0}({1}, {2})-0", funcName, data0, data1));
                            //}
                            dst = func(data0, data1);
                            //if (Scalars<T>.BitSize >= 64) {
                            //    writer.WriteLine(VectorTextUtil.Format("{0}({1}, {2})-1: {3}", funcName, data0, data1, dst));
                            //}
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
            if (!MyTestUtil.AllowDelegateMultiParam) funcList.Clear();
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
        public void YGroup2Zip_Bit128Test<T>(T src) where T : struct {
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
                    Vector<T> expected0 = Vectors.YGroup2Zip_Bit128(x, y, out Vector<T> expected1);
                    if (allowLog && 0 == i && 1 == j) {
                        writer.WriteLine(VectorTextUtil.Format("f({0}, {1}): {2}, {3}", x, y, expected0, expected1));
                    }
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        string funcName = instance.GetType().Name;
                        dst0 = instance.YGroup2Zip_Bit128(x, y, out dst1);
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
            if (!MyTestUtil.AllowDelegateMultiParam) funcList.Clear();
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
            if (!MyTestUtil.AllowDelegateMultiParam) funcList.Clear();
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
        public void YGroup3ToGroup4Test<T>(T src) where T : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YGroup3ToGroup4_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<FuncIn3Out3<Vector<T>>>("YGroup3ToGroup4_AlignRight", "YGroup3ToGroup4_Basic", "YGroup3ToGroup4_Move", "YGroup3ToGroup4_Shuffle", "YGroup3ToGroup4_ShuffleX", "YGroup3ToGroup4_ShuffleXImm", "YGroup3ToGroup4_Unzip");
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
            for (int i = 0; i < samples.Length; i++) {
                Vector<T> data0 = samples[i];
                for (int j = 0; j < samples.Length; j++) {
                    if (j == i) continue;
                    Vector<T> data1 = samples[j];
                    Vector<T> dst0, dst1, dst2, dst3;
#pragma warning disable CS0618 // Type or member is obsolete
                    (Vector<T> expected0, Vector<T> expected1, Vector<T> expected2, Vector<T> expected3) = Vectors.YGroup3ToGroup4(data0, data1, data2);
                    if (allowLog && 0 == i && 1 == j) {
                        writer.WriteLine(VectorTextUtil.Format("f({0}, {1}, {2}): {3}, {4}, {5}, {6}", data0, data1, data2, expected0, expected1, expected2, expected3));
                    }
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        string funcName = instance.GetType().Name;
                        (dst0, dst1, dst2, dst3) = instance.YGroup3ToGroup4(data0, data1, data2);
                        ClassicAssert.IsTrue(expected0.BitEquals(dst0), VectorTextUtil.Format("{0} != {1}. Part 0 on {2}: {3}, {4}, {5}", expected0, dst0, funcName, data0, data1, data2));
                        ClassicAssert.IsTrue(expected1.BitEquals(dst1), VectorTextUtil.Format("{0} != {1}. Part 1 on {2}: {3}, {4}, {5}", expected1, dst1, funcName, data0, data1, data2));
                        ClassicAssert.IsTrue(expected2.BitEquals(dst2), VectorTextUtil.Format("{0} != {1}. Part 2 on {2}: {3}, {4}, {5}", expected2, dst2, funcName, data0, data1, data2));
                        ClassicAssert.IsTrue(expected3.BitEquals(dst3), VectorTextUtil.Format("{0} != {1}. Part 3 on {2}: {3}, {4}, {5}", expected3, dst3, funcName, data0, data1, data2));
                    }
                    for (int f = 0; f < funcList.Count; f++) {
                        if (funcListUnsupported[f]) continue;
                        var func = funcList[f];
                        string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                        try {
                            dst0 = func(data0, data1, data2, out dst1, out dst2, out dst3);
                        } catch (NotSupportedException ex) {
                            funcListUnsupported[f] = true;
                            writer.WriteLine(VectorTextUtil.Format("NotSupportedException on {0}: {1}, {2}, {3}. {4}", funcName, data0, data1, data2, ex.Message));
                            continue;
                        }
                        ClassicAssert.IsTrue(expected0.BitEquals(dst0), VectorTextUtil.Format("{0} != {1}. Part 0 on {2}: {3}, {4}, {5}", expected0, dst0, funcName, data0, data1, data2));
                        ClassicAssert.IsTrue(expected1.BitEquals(dst1), VectorTextUtil.Format("{0} != {1}. Part 1 on {2}: {3}, {4}, {5}", expected1, dst1, funcName, data0, data1, data2));
                        ClassicAssert.IsTrue(expected2.BitEquals(dst2), VectorTextUtil.Format("{0} != {1}. Part 2 on {2}: {3}, {4}, {5}", expected2, dst2, funcName, data0, data1, data2));
                        ClassicAssert.IsTrue(expected3.BitEquals(dst3), VectorTextUtil.Format("{0} != {1}. Part 3 on {2}: {3}, {4}, {5}", expected3, dst3, funcName, data0, data1, data2));
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
        public void YGroup3UnzipTest<T>(T src) where T : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YGroup3Unzip_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<FuncIn3Out2<Vector<T>>>("YGroup3Unzip_Basic", "YGroup3Unzip_ByShorter", "YGroup3Unzip_ByX2Unpack", "YGroup3Unzip_ByX2Zip", "YGroup3Unzip_Move", "YGroup3Unzip_Shuffle", "YGroup3Unzip_ShuffleX", "YGroup3Unzip_ShuffleXImm");
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
            for (int i = 0; i < samples.Length; i++) {
                Vector<T> data0 = samples[i];
                for (int j = 0; j < samples.Length; j++) {
                    if (j == i) continue;
                    Vector<T> data1 = samples[j];
                    Vector<T> dst0, dst1, dst2;
#pragma warning disable CS0618 // Type or member is obsolete
                    (Vector<T> expected0, Vector<T> expected1, Vector<T> expected2) = Vectors.YGroup3Unzip(data0, data1, data2);
                    if (allowLog && 0 == i && 1 == j) {
                        writer.WriteLine(VectorTextUtil.Format("f({0}, {1}, {2}): {3}, {4}, {5}", data0, data1, data2, expected0, expected1, expected2));
                    }
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        string funcName = instance.GetType().Name;
                        (dst0, dst1, dst2) = instance.YGroup3Unzip(data0, data1, data2);
                        ClassicAssert.IsTrue(expected0.BitEquals(dst0), VectorTextUtil.Format("{0} != {1}. Part 0 on {2}: {3}, {4}, {5}", expected0, dst0, funcName, data0, data1, data2));
                        ClassicAssert.IsTrue(expected1.BitEquals(dst1), VectorTextUtil.Format("{0} != {1}. Part 1 on {2}: {3}, {4}, {5}", expected1, dst1, funcName, data0, data1, data2));
                        ClassicAssert.IsTrue(expected2.BitEquals(dst2), VectorTextUtil.Format("{0} != {1}. Part 2 on {2}: {3}, {4}, {5}", expected2, dst2, funcName, data0, data1, data2));
                    }
                    for (int f = 0; f < funcList.Count; f++) {
                        if (funcListUnsupported[f]) continue;
                        var func = funcList[f];
                        string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                        try {
                            dst0 = func(data0, data1, data2, out dst1, out dst2);
                        } catch (NotSupportedException ex) {
                            funcListUnsupported[f] = true;
                            writer.WriteLine(VectorTextUtil.Format("NotSupportedException on {0}: {1}, {2}, {3}. {4}", funcName, data0, data1, data2, ex.Message));
                            continue;
                        }
                        ClassicAssert.IsTrue(expected0.BitEquals(dst0), VectorTextUtil.Format("{0} != {1}. Part 0 on {2}: {3}, {4}, {5}", expected0, dst0, funcName, data0, data1, data2));
                        ClassicAssert.IsTrue(expected1.BitEquals(dst1), VectorTextUtil.Format("{0} != {1}. Part 1 on {2}: {3}, {4}, {5}", expected1, dst1, funcName, data0, data1, data2));
                        ClassicAssert.IsTrue(expected2.BitEquals(dst2), VectorTextUtil.Format("{0} != {1}. Part 2 on {2}: {3}, {4}, {5}", expected2, dst2, funcName, data0, data1, data2));
                    } // funcList
#pragma warning restore CS0618 // Type or member is obsolete
                }
            }
        }

        [TestCase((byte)4)]
        public void YGroup3Unzip_Bit128Test<T>(T src) where T : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YGroup3Unzip_AcceleratedTypes}");
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
            for (int i = 0; i < samples.Length; i++) {
                Vector<T> data0 = samples[i];
                for (int j = 0; j < samples.Length; j++) {
                    if (j == i) continue;
                    Vector<T> data1 = samples[j];
                    Vector<T> dst0, dst1, dst2;
#pragma warning disable CS0618 // Type or member is obsolete
                    Vector<T> expected0 = Vectors.YGroup3Unzip_Bit128(data0, data1, data2, out Vector<T> expected1, out Vector<T> expected2);
                    if (allowLog && 0 == i && 1 == j) {
                        writer.WriteLine(VectorTextUtil.Format("f({0}, {1}, {2}): {3}, {4}, {5}", data0, data1, data2, expected0, expected1, expected2));
                    }
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        string funcName = instance.GetType().Name;
                        dst0 = instance.YGroup3Unzip_Bit128(data0, data1, data2, out dst1, out dst2);
                        ClassicAssert.IsTrue(expected0.BitEquals(dst0), VectorTextUtil.Format("{0} != {1}. Part 0 on {2}: {3}, {4}, {5}", expected0, dst0, funcName, data0, data1, data2));
                        ClassicAssert.IsTrue(expected1.BitEquals(dst1), VectorTextUtil.Format("{0} != {1}. Part 1 on {2}: {3}, {4}, {5}", expected1, dst1, funcName, data0, data1, data2));
                        ClassicAssert.IsTrue(expected2.BitEquals(dst2), VectorTextUtil.Format("{0} != {1}. Part 2 on {2}: {3}, {4}, {5}", expected2, dst2, funcName, data0, data1, data2));
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
        public void YGroup3UnzipX2Test<T>(T src) where T : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YGroup3UnzipX2_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<FuncIn6Out5<Vector<T>>>("YGroup3UnzipX2_Basic", "YGroup3UnzipX2_Move", "YGroup3UnzipX2_Unpack", "YGroup3UnzipX2_X2", "YGroup3UnzipX2_Zip");
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
            Vector<T> data4 = data3;
            Vector<T> data5 = data2;
            for (int i = 0; i < samples.Length; i++) {
                Vector<T> data0 = samples[i];
                for (int j = 0; j < samples.Length; j++) {
                    if (j == i) continue;
                    Vector<T> data1 = samples[j];
                    Vector<T> dst0, dst1, dst2, dst3, dst4, dst5;
#pragma warning disable CS0618 // Type or member is obsolete
                    (Vector<T> expected0, Vector<T> expected1, Vector<T> expected2, Vector<T> expected3, Vector<T> expected4, Vector<T> expected5)
                        = Vectors.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5);
                    if (allowLog && 0 == i && 1 == j) {
                        writer.WriteLine(VectorTextUtil.Format("f({0}, {1}, {2}, {3}, {4}, {5}): {6}, {7}, {8}, {9}, {10}, {11}", data0, data1, data2, data3, data4, data5, expected0, expected1, expected2, expected3, expected4, expected5));
                    }
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        string funcName = instance.GetType().Name;
                        (dst0, dst1, dst2, dst3, dst4, dst5) = instance.YGroup3UnzipX2(data0, data1, data2, data3, data4, data5);
                        ClassicAssert.IsTrue(expected0.BitEquals(dst0), VectorTextUtil.Format("{0} != {1}. Part 0 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", expected0, dst0, funcName, data0, data1, data2, data3, data4, data5));
                        ClassicAssert.IsTrue(expected1.BitEquals(dst1), VectorTextUtil.Format("{0} != {1}. Part 1 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", expected1, dst1, funcName, data0, data1, data2, data3, data4, data5));
                        ClassicAssert.IsTrue(expected2.BitEquals(dst2), VectorTextUtil.Format("{0} != {1}. Part 2 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", expected2, dst2, funcName, data0, data1, data2, data3, data4, data5));
                        ClassicAssert.IsTrue(expected3.BitEquals(dst3), VectorTextUtil.Format("{0} != {1}. Part 3 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", expected3, dst3, funcName, data0, data1, data2, data3, data4, data5));
                        ClassicAssert.IsTrue(expected4.BitEquals(dst4), VectorTextUtil.Format("{0} != {1}. Part 4 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", expected4, dst4, funcName, data0, data1, data2, data3, data4, data5));
                        ClassicAssert.IsTrue(expected5.BitEquals(dst5), VectorTextUtil.Format("{0} != {1}. Part 5 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", expected5, dst5, funcName, data0, data1, data2, data3, data4, data5));
                    }
                    for (int f = 0; f < funcList.Count; f++) {
                        if (funcListUnsupported[f]) continue;
                        var func = funcList[f];
                        string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                        try {
                            dst0 = func(data0, data1, data2, data3, data4, data5, out dst1, out dst2, out dst3, out dst4, out dst5);
                        } catch (NotSupportedException ex) {
                            funcListUnsupported[f] = true;
                            writer.WriteLine(VectorTextUtil.Format("NotSupportedException on {0}: {1}, {2}, {3}, {4}. {5}, {6}. {7}", funcName, data0, data1, data2, data3, data4, data5, ex.Message));
                            continue;
                        }
                        ClassicAssert.IsTrue(expected0.BitEquals(dst0), VectorTextUtil.Format("{0} != {1}. Part 0 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", expected0, dst0, funcName, data0, data1, data2, data3, data4, data5));
                        ClassicAssert.IsTrue(expected1.BitEquals(dst1), VectorTextUtil.Format("{0} != {1}. Part 1 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", expected1, dst1, funcName, data0, data1, data2, data3, data4, data5));
                        ClassicAssert.IsTrue(expected2.BitEquals(dst2), VectorTextUtil.Format("{0} != {1}. Part 2 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", expected2, dst2, funcName, data0, data1, data2, data3, data4, data5));
                        ClassicAssert.IsTrue(expected3.BitEquals(dst3), VectorTextUtil.Format("{0} != {1}. Part 3 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", expected3, dst3, funcName, data0, data1, data2, data3, data4, data5));
                        ClassicAssert.IsTrue(expected4.BitEquals(dst4), VectorTextUtil.Format("{0} != {1}. Part 4 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", expected4, dst4, funcName, data0, data1, data2, data3, data4, data5));
                        ClassicAssert.IsTrue(expected5.BitEquals(dst5), VectorTextUtil.Format("{0} != {1}. Part 5 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", expected5, dst5, funcName, data0, data1, data2, data3, data4, data5));
                    } // funcList
#pragma warning restore CS0618 // Type or member is obsolete
                }
            }
        }

        [TestCase((byte)4)]
        public void YGroup3UnzipX2_Bit128Test<T>(T src) where T : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YGroup3UnzipX2_AcceleratedTypes}");
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
            Vector<T> data4 = data3;
            Vector<T> data5 = data2;
            for (int i = 0; i < samples.Length; i++) {
                Vector<T> data0 = samples[i];
                for (int j = 0; j < samples.Length; j++) {
                    if (j == i) continue;
                    Vector<T> data1 = samples[j];
                    Vector<T> dst0, dst1, dst2, dst3, dst4, dst5;
#pragma warning disable CS0618 // Type or member is obsolete
                    Vector<T> expected0 = Vectors.YGroup3UnzipX2_Bit128(data0, data1, data2, data3, data4, data5, out Vector<T> expected1, out Vector<T> expected2, out Vector<T> expected3, out Vector<T> expected4, out Vector<T> expected5);
                    if (allowLog && 0 == i && 1 == j) {
                        writer.WriteLine(VectorTextUtil.Format("f({0}, {1}, {2}, {3}, {4}, {5}): {6}, {7}, {8}, {9}, {10}, {11}", data0, data1, data2, data3, data4, data5, expected0, expected1, expected2, expected3, expected4, expected5));
                    }
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        string funcName = instance.GetType().Name;
                        dst0 = instance.YGroup3UnzipX2_Bit128(data0, data1, data2, data3, data4, data5, out dst1, out dst2, out dst3, out dst4, out dst5);
                        ClassicAssert.IsTrue(expected0.BitEquals(dst0), VectorTextUtil.Format("{0} != {1}. Part 0 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", expected0, dst0, funcName, data0, data1, data2, data3, data4, data5));
                        ClassicAssert.IsTrue(expected1.BitEquals(dst1), VectorTextUtil.Format("{0} != {1}. Part 1 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", expected1, dst1, funcName, data0, data1, data2, data3, data4, data5));
                        ClassicAssert.IsTrue(expected2.BitEquals(dst2), VectorTextUtil.Format("{0} != {1}. Part 2 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", expected2, dst2, funcName, data0, data1, data2, data3, data4, data5));
                        ClassicAssert.IsTrue(expected3.BitEquals(dst3), VectorTextUtil.Format("{0} != {1}. Part 3 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", expected3, dst3, funcName, data0, data1, data2, data3, data4, data5));
                        ClassicAssert.IsTrue(expected4.BitEquals(dst4), VectorTextUtil.Format("{0} != {1}. Part 4 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", expected4, dst4, funcName, data0, data1, data2, data3, data4, data5));
                        ClassicAssert.IsTrue(expected5.BitEquals(dst5), VectorTextUtil.Format("{0} != {1}. Part 5 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", expected5, dst5, funcName, data0, data1, data2, data3, data4, data5));
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
        public void YGroup3ZipTest<T>(T src) where T : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YGroup3Zip_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<FuncIn3Out2<Vector<T>>>("YGroup3Zip_Basic", "YGroup3Zip_ByShorter", "YGroup3Zip_ByX2Unpack", "YGroup3Zip_ByX2Unzip", "YGroup3Zip_Move", "YGroup3Zip_Shuffle", "YGroup3Zip_ShuffleX", "YGroup3Zip_ShuffleXImm");
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
            bool checkUnzip = true;
            Vector<T> data2 = Vectors<T>.SerialDesc;
            for (int i = 0; i < samples.Length; i++) {
                Vector<T> data0 = samples[i];
                for (int j = 0; j < samples.Length; j++) {
                    if (j == i) continue;
                    Vector<T> data1 = samples[j];
                    Vector<T> dst0, dst1, dst2;
#pragma warning disable CS0618 // Type or member is obsolete
                    (Vector<T> expected0, Vector<T> expected1, Vector<T> expected2) = Vectors.YGroup3Zip(data0, data1, data2);
                    if (allowLog && 0 == i && 1 == j) {
                        writer.WriteLine(VectorTextUtil.Format("f({0}, {1}, {2}): {3}, {4}, {5}", data0, data1, data2, expected0, expected1, expected2));
                    }
                    if (checkUnzip) {
                        Vector<T> chk0, chk1, chk2;
                        (chk0, chk1, chk2) = Vectors.YGroup3Unzip(expected0, expected1, expected2);
                        string funcName = "Unzip";
                        ClassicAssert.IsTrue(data0.BitEquals(chk0), VectorTextUtil.Format("{0} != {1}. Part 0 on {2}: {3}, {4}, {5}", data0, chk0, funcName, data0, data1, data2));
                        ClassicAssert.IsTrue(data1.BitEquals(chk1), VectorTextUtil.Format("{0} != {1}. Part 1 on {2}: {3}, {4}, {5}", data1, chk1, funcName, data0, data1, data2));
                        ClassicAssert.IsTrue(data2.BitEquals(chk2), VectorTextUtil.Format("{0} != {1}. Part 2 on {2}: {3}, {4}, {5}", data2, chk2, funcName, data0, data1, data2));
                    }
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        string funcName = instance.GetType().Name;
                        (dst0, dst1, dst2) = instance.YGroup3Zip(data0, data1, data2);
                        ClassicAssert.IsTrue(expected0.BitEquals(dst0), VectorTextUtil.Format("{0} != {1}. Part 0 on {2}: {3}, {4}, {5}", expected0, dst0, funcName, data0, data1, data2));
                        ClassicAssert.IsTrue(expected1.BitEquals(dst1), VectorTextUtil.Format("{0} != {1}. Part 1 on {2}: {3}, {4}, {5}", expected1, dst1, funcName, data0, data1, data2));
                        ClassicAssert.IsTrue(expected2.BitEquals(dst2), VectorTextUtil.Format("{0} != {1}. Part 2 on {2}: {3}, {4}, {5}", expected2, dst2, funcName, data0, data1, data2));
                    }
                    for (int f = 0; f < funcList.Count; f++) {
                        if (funcListUnsupported[f]) continue;
                        var func = funcList[f];
                        string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                        try {
                            dst0 = func(data0, data1, data2, out dst1, out dst2);
                        } catch (NotSupportedException ex) {
                            funcListUnsupported[f] = true;
                            writer.WriteLine(VectorTextUtil.Format("NotSupportedException on {0}: {1}, {2}, {3}. {4}", funcName, data0, data1, data2, ex.Message));
                            continue;
                        }
                        ClassicAssert.IsTrue(expected0.BitEquals(dst0), VectorTextUtil.Format("{0} != {1}. Part 0 on {2}: {3}, {4}, {5}", expected0, dst0, funcName, data0, data1, data2));
                        ClassicAssert.IsTrue(expected1.BitEquals(dst1), VectorTextUtil.Format("{0} != {1}. Part 1 on {2}: {3}, {4}, {5}", expected1, dst1, funcName, data0, data1, data2));
                        ClassicAssert.IsTrue(expected2.BitEquals(dst2), VectorTextUtil.Format("{0} != {1}. Part 2 on {2}: {3}, {4}, {5}", expected2, dst2, funcName, data0, data1, data2));
                    } // funcList
#pragma warning restore CS0618 // Type or member is obsolete
                }
            }
        }

        [TestCase((byte)4)]
        public void YGroup3Zip_Bit128Test<T>(T src) where T : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YGroup3Zip_AcceleratedTypes}");
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
            bool checkUnzip = true;
            Vector<T> data2 = Vectors<T>.SerialDesc;
            for (int i = 0; i < samples.Length; i++) {
                Vector<T> data0 = samples[i];
                for (int j = 0; j < samples.Length; j++) {
                    if (j == i) continue;
                    Vector<T> data1 = samples[j];
                    Vector<T> dst0, dst1, dst2;
#pragma warning disable CS0618 // Type or member is obsolete
                    Vector<T> expected0 = Vectors.YGroup3Zip_Bit128(data0, data1, data2, out Vector<T> expected1, out Vector<T> expected2);
                    if (allowLog && 0 == i && 1 == j) {
                        writer.WriteLine(VectorTextUtil.Format("f({0}, {1}, {2}): {3}, {4}, {5}", data0, data1, data2, expected0, expected1, expected2));
                    }
                    if (checkUnzip) {
                        Vector<T> chk0, chk1, chk2;
                        chk0 = Vectors.YGroup3Unzip_Bit128(expected0, expected1, expected2, out chk1, out chk2);
                        string funcName = "Unzip";
                        ClassicAssert.IsTrue(data0.BitEquals(chk0), VectorTextUtil.Format("{0} != {1}. Part 0 on {2}: {3}, {4}, {5}", data0, chk0, funcName, data0, data1, data2));
                        ClassicAssert.IsTrue(data1.BitEquals(chk1), VectorTextUtil.Format("{0} != {1}. Part 1 on {2}: {3}, {4}, {5}", data1, chk1, funcName, data0, data1, data2));
                        ClassicAssert.IsTrue(data2.BitEquals(chk2), VectorTextUtil.Format("{0} != {1}. Part 2 on {2}: {3}, {4}, {5}", data2, chk2, funcName, data0, data1, data2));
                    }
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        string funcName = instance.GetType().Name;
                        dst0 = instance.YGroup3Zip_Bit128(data0, data1, data2, out dst1, out dst2);
                        ClassicAssert.IsTrue(expected0.BitEquals(dst0), VectorTextUtil.Format("{0} != {1}. Part 0 on {2}: {3}, {4}, {5}", expected0, dst0, funcName, data0, data1, data2));
                        ClassicAssert.IsTrue(expected1.BitEquals(dst1), VectorTextUtil.Format("{0} != {1}. Part 1 on {2}: {3}, {4}, {5}", expected1, dst1, funcName, data0, data1, data2));
                        ClassicAssert.IsTrue(expected2.BitEquals(dst2), VectorTextUtil.Format("{0} != {1}. Part 2 on {2}: {3}, {4}, {5}", expected2, dst2, funcName, data0, data1, data2));
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
        public void YGroup3ZipX2Test<T>(T src) where T : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YGroup3ZipX2_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<FuncIn6Out5<Vector<T>>>("YGroup3ZipX2_Basic", "YGroup3ZipX2_Move", "YGroup3ZipX2_Unpack", "YGroup3ZipX2_X2", "YGroup3ZipX2_Unzip");
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
            bool checkUnzip = true;
            Vector<T> data2 = Vectors<T>.SerialDesc;
            Vector<T> data3 = Vectors<T>.SerialNegative;
            Vector<T> data4 = data3;
            Vector<T> data5 = data2;
            for (int i = 0; i < samples.Length; i++) {
                Vector<T> data0 = samples[i];
                for (int j = 0; j < samples.Length; j++) {
                    if (j == i) continue;
                    Vector<T> data1 = samples[j];
                    Vector<T> dst0, dst1, dst2, dst3, dst4, dst5;
#pragma warning disable CS0618 // Type or member is obsolete
                    (Vector<T> expected0, Vector<T> expected1, Vector<T> expected2, Vector<T> expected3, Vector<T> expected4, Vector<T> expected5)
                        = Vectors.YGroup3ZipX2(data0, data1, data2, data3, data4, data5);
                    if (allowLog && 0 == i && 1 == j) {
                        writer.WriteLine(VectorTextUtil.Format("f({0}, {1}, {2}, {3}, {4}, {5}): {6}, {7}, {8}, {9}, {10}, {11}", data0, data1, data2, data3, data4, data5, expected0, expected1, expected2, expected3, expected4, expected5));
                    }
                    if (checkUnzip) {
                        Vector<T> chk0, chk1, chk2, chk3, chk4, chk5;
                        (chk0, chk1, chk2, chk3, chk4, chk5) = Vectors.YGroup3UnzipX2(expected0, expected1, expected2, expected3, expected4, expected5);
                        string funcName = "Unzip";
                        ClassicAssert.IsTrue(data0.BitEquals(chk0), VectorTextUtil.Format("{0} != {1}. Part 0 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", data0, chk0, funcName, data0, data1, data2, data3, data4, data5));
                        ClassicAssert.IsTrue(data1.BitEquals(chk1), VectorTextUtil.Format("{0} != {1}. Part 1 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", data1, chk1, funcName, data0, data1, data2, data3, data4, data5));
                        ClassicAssert.IsTrue(data2.BitEquals(chk2), VectorTextUtil.Format("{0} != {1}. Part 2 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", data2, chk2, funcName, data0, data1, data2, data3, data4, data5));
                        ClassicAssert.IsTrue(data3.BitEquals(chk3), VectorTextUtil.Format("{0} != {1}. Part 3 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", data3, chk3, funcName, data0, data1, data2, data3, data4, data5));
                        ClassicAssert.IsTrue(data4.BitEquals(chk4), VectorTextUtil.Format("{0} != {1}. Part 4 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", data4, chk4, funcName, data0, data1, data2, data3, data4, data5));
                        ClassicAssert.IsTrue(data5.BitEquals(chk5), VectorTextUtil.Format("{0} != {1}. Part 5 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", data5, chk5, funcName, data0, data1, data2, data3, data4, data5));
                    }
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        string funcName = instance.GetType().Name;
                        (dst0, dst1, dst2, dst3, dst4, dst5) = instance.YGroup3ZipX2(data0, data1, data2, data3, data4, data5);
                        ClassicAssert.IsTrue(expected0.BitEquals(dst0), VectorTextUtil.Format("{0} != {1}. Part 0 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", expected0, dst0, funcName, data0, data1, data2, data3, data4, data5));
                        ClassicAssert.IsTrue(expected1.BitEquals(dst1), VectorTextUtil.Format("{0} != {1}. Part 1 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", expected1, dst1, funcName, data0, data1, data2, data3, data4, data5));
                        ClassicAssert.IsTrue(expected2.BitEquals(dst2), VectorTextUtil.Format("{0} != {1}. Part 2 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", expected2, dst2, funcName, data0, data1, data2, data3, data4, data5));
                        ClassicAssert.IsTrue(expected3.BitEquals(dst3), VectorTextUtil.Format("{0} != {1}. Part 3 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", expected3, dst3, funcName, data0, data1, data2, data3, data4, data5));
                        ClassicAssert.IsTrue(expected4.BitEquals(dst4), VectorTextUtil.Format("{0} != {1}. Part 4 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", expected4, dst4, funcName, data0, data1, data2, data3, data4, data5));
                        ClassicAssert.IsTrue(expected5.BitEquals(dst5), VectorTextUtil.Format("{0} != {1}. Part 5 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", expected5, dst5, funcName, data0, data1, data2, data3, data4, data5));
                    }
                    for (int f = 0; f < funcList.Count; f++) {
                        if (funcListUnsupported[f]) continue;
                        var func = funcList[f];
                        string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                        try {
                            dst0 = func(data0, data1, data2, data3, data4, data5, out dst1, out dst2, out dst3, out dst4, out dst5);
                        } catch (NotSupportedException ex) {
                            funcListUnsupported[f] = true;
                            writer.WriteLine(VectorTextUtil.Format("NotSupportedException on {0}: {1}, {2}, {3}, {4}. {5}, {6}. {7}", funcName, data0, data1, data2, data3, data4, data5, ex.Message));
                            continue;
                        }
                        ClassicAssert.IsTrue(expected0.BitEquals(dst0), VectorTextUtil.Format("{0} != {1}. Part 0 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", expected0, dst0, funcName, data0, data1, data2, data3, data4, data5));
                        ClassicAssert.IsTrue(expected1.BitEquals(dst1), VectorTextUtil.Format("{0} != {1}. Part 1 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", expected1, dst1, funcName, data0, data1, data2, data3, data4, data5));
                        ClassicAssert.IsTrue(expected2.BitEquals(dst2), VectorTextUtil.Format("{0} != {1}. Part 2 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", expected2, dst2, funcName, data0, data1, data2, data3, data4, data5));
                        ClassicAssert.IsTrue(expected3.BitEquals(dst3), VectorTextUtil.Format("{0} != {1}. Part 3 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", expected3, dst3, funcName, data0, data1, data2, data3, data4, data5));
                        ClassicAssert.IsTrue(expected4.BitEquals(dst4), VectorTextUtil.Format("{0} != {1}. Part 4 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", expected4, dst4, funcName, data0, data1, data2, data3, data4, data5));
                        ClassicAssert.IsTrue(expected5.BitEquals(dst5), VectorTextUtil.Format("{0} != {1}. Part 5 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", expected5, dst5, funcName, data0, data1, data2, data3, data4, data5));
                    } // funcList
#pragma warning restore CS0618 // Type or member is obsolete
                }
            }
        }

        [TestCase((byte)4)]
        public void YGroup3ZipX2_Bit128Test<T>(T src) where T : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YGroup3ZipX2_AcceleratedTypes}");
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
            bool checkUnzip = true;
            Vector<T> data2 = Vectors<T>.SerialDesc;
            Vector<T> data3 = Vectors<T>.SerialNegative;
            Vector<T> data4 = data3;
            Vector<T> data5 = data2;
            for (int i = 0; i < samples.Length; i++) {
                Vector<T> data0 = samples[i];
                for (int j = 0; j < samples.Length; j++) {
                    if (j == i) continue;
                    Vector<T> data1 = samples[j];
                    Vector<T> dst0, dst1, dst2, dst3, dst4, dst5;
#pragma warning disable CS0618 // Type or member is obsolete
                    Vector<T> expected0 = Vectors.YGroup3ZipX2_Bit128(data0, data1, data2, data3, data4, data5, out Vector<T> expected1, out Vector<T> expected2, out Vector<T> expected3, out Vector<T> expected4, out Vector<T> expected5);
                    if (allowLog && 0 == i && 1 == j) {
                        writer.WriteLine(VectorTextUtil.Format("f({0}, {1}, {2}, {3}, {4}, {5}): {6}, {7}, {8}, {9}, {10}, {11}", data0, data1, data2, data3, data4, data5, expected0, expected1, expected2, expected3, expected4, expected5));
                    }
                    if (checkUnzip) {
                        Vector<T> chk0, chk1, chk2, chk3, chk4, chk5;
                        chk0 = Vectors.YGroup3UnzipX2_Bit128(expected0, expected1, expected2, expected3, expected4, expected5, out chk1, out chk2, out chk3, out chk4, out chk5);
                        string funcName = "Unzip";
                        ClassicAssert.IsTrue(data0.BitEquals(chk0), VectorTextUtil.Format("{0} != {1}. Part 0 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", data0, chk0, funcName, data0, data1, data2, data3, data4, data5));
                        ClassicAssert.IsTrue(data1.BitEquals(chk1), VectorTextUtil.Format("{0} != {1}. Part 1 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", data1, chk1, funcName, data0, data1, data2, data3, data4, data5));
                        ClassicAssert.IsTrue(data2.BitEquals(chk2), VectorTextUtil.Format("{0} != {1}. Part 2 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", data2, chk2, funcName, data0, data1, data2, data3, data4, data5));
                        ClassicAssert.IsTrue(data3.BitEquals(chk3), VectorTextUtil.Format("{0} != {1}. Part 3 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", data3, chk3, funcName, data0, data1, data2, data3, data4, data5));
                        ClassicAssert.IsTrue(data4.BitEquals(chk4), VectorTextUtil.Format("{0} != {1}. Part 4 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", data4, chk4, funcName, data0, data1, data2, data3, data4, data5));
                        ClassicAssert.IsTrue(data5.BitEquals(chk5), VectorTextUtil.Format("{0} != {1}. Part 5 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", data5, chk5, funcName, data0, data1, data2, data3, data4, data5));
                    }
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        string funcName = instance.GetType().Name;
                        dst0 = instance.YGroup3ZipX2_Bit128(data0, data1, data2, data3, data4, data5, out dst1, out dst2, out dst3, out dst4, out dst5);
                        ClassicAssert.IsTrue(expected0.BitEquals(dst0), VectorTextUtil.Format("{0} != {1}. Part 0 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", expected0, dst0, funcName, data0, data1, data2, data3, data4, data5));
                        ClassicAssert.IsTrue(expected1.BitEquals(dst1), VectorTextUtil.Format("{0} != {1}. Part 1 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", expected1, dst1, funcName, data0, data1, data2, data3, data4, data5));
                        ClassicAssert.IsTrue(expected2.BitEquals(dst2), VectorTextUtil.Format("{0} != {1}. Part 2 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", expected2, dst2, funcName, data0, data1, data2, data3, data4, data5));
                        ClassicAssert.IsTrue(expected3.BitEquals(dst3), VectorTextUtil.Format("{0} != {1}. Part 3 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", expected3, dst3, funcName, data0, data1, data2, data3, data4, data5));
                        ClassicAssert.IsTrue(expected4.BitEquals(dst4), VectorTextUtil.Format("{0} != {1}. Part 4 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", expected4, dst4, funcName, data0, data1, data2, data3, data4, data5));
                        ClassicAssert.IsTrue(expected5.BitEquals(dst5), VectorTextUtil.Format("{0} != {1}. Part 5 on {2}: {3}, {4}, {5}, {6}, {7}, {8}", expected5, dst5, funcName, data0, data1, data2, data3, data4, data5));
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
        public void YGroup4ToGroup3Test<T>(T src) where T : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YGroup4ToGroup3_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<FuncIn4Out2<Vector<T>>>("YGroup4ToGroup3_AlignRight", "YGroup4ToGroup3_Basic", "YGroup4ToGroup3_Move", "YGroup4ToGroup3_Shuffle", "YGroup4ToGroup3_ShuffleX", "YGroup4ToGroup3_ShuffleXImm", "YGroup4ToGroup3_Unzip");
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
                    Vector<T> dst0, dst1, dst2;
#pragma warning disable CS0618 // Type or member is obsolete
                    (Vector<T> expected0, Vector<T> expected1, Vector<T> expected2) = Vectors.YGroup4ToGroup3(data0, data1, data2, data3);
                    if (allowLog && 0 == i && 1 == j) {
                        writer.WriteLine(VectorTextUtil.Format("f({0}, {1}, {2}, {3}): {4}, {5}, {6}", data0, data1, data2, data3, expected0, expected1, expected2));
                    }
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        string funcName = instance.GetType().Name;
                        (dst0, dst1, dst2) = instance.YGroup4ToGroup3(data0, data1, data2, data3);
                        ClassicAssert.IsTrue(expected0.BitEquals(dst0), VectorTextUtil.Format("{0} != {1}. Part 0 on {2}: {3}, {4}, {5}, {6}", expected0, dst0, funcName, data0, data1, data2, data3));
                        ClassicAssert.IsTrue(expected1.BitEquals(dst1), VectorTextUtil.Format("{0} != {1}. Part 1 on {2}: {3}, {4}, {5}, {6}", expected1, dst1, funcName, data0, data1, data2, data3));
                        ClassicAssert.IsTrue(expected2.BitEquals(dst2), VectorTextUtil.Format("{0} != {1}. Part 2 on {2}: {3}, {4}, {5}, {6}", expected2, dst2, funcName, data0, data1, data2, data3));
                    }
                    for (int f = 0; f < funcList.Count; f++) {
                        if (funcListUnsupported[f]) continue;
                        var func = funcList[f];
                        string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                        try {
                            dst0 = func(data0, data1, data2, data3, out dst1, out dst2);
                        } catch (NotSupportedException ex) {
                            funcListUnsupported[f] = true;
                            writer.WriteLine(VectorTextUtil.Format("NotSupportedException on {0}: {1}, {2}, {3}, {4}. {5}", funcName, data0, data1, data2, data3, ex.Message));
                            continue;
                        }
                        ClassicAssert.IsTrue(expected0.BitEquals(dst0), VectorTextUtil.Format("{0} != {1}. Part 0 on {2}: {3}, {4}, {5}, {6}", expected0, dst0, funcName, data0, data1, data2, data3));
                        ClassicAssert.IsTrue(expected1.BitEquals(dst1), VectorTextUtil.Format("{0} != {1}. Part 1 on {2}: {3}, {4}, {5}, {6}", expected1, dst1, funcName, data0, data1, data2, data3));
                        ClassicAssert.IsTrue(expected2.BitEquals(dst2), VectorTextUtil.Format("{0} != {1}. Part 2 on {2}: {3}, {4}, {5}, {6}", expected2, dst2, funcName, data0, data1, data2, data3));
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
        public void YGroup4Unzip_Bit128Test<T>(T src) where T : struct {
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
                    Vector<T> expected0 = Vectors.YGroup4Unzip_Bit128(data0, data1, data2, data3, out Vector<T> expected1, out Vector<T> expected2, out Vector<T> expected3);
                    if (allowLog && 0 == i && 1 == j) {
                        writer.WriteLine(VectorTextUtil.Format("f({0}, {1}, {2}, {3}): {4}, {5}, {6}, {7}", data0, data1, data2, data3, expected0, expected1, expected2, expected3));
                    }
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        string funcName = instance.GetType().Name;
                        dst0 = instance.YGroup4Unzip_Bit128(data0, data1, data2, data3, out dst1, out dst2, out dst3);
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
        public void YGroup4Zip_Bit128Test<T>(T src) where T : struct {
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
                    Vector<T> expected0 = Vectors.YGroup4Zip_Bit128(data0, data1, data2, data3, out Vector<T> expected1, out Vector<T> expected2, out Vector<T> expected3);
                    if (allowLog && 0 == i && 1 == j) {
                        writer.WriteLine(VectorTextUtil.Format("f({0}, {1}, {2}, {3}): {4}, {5}, {6}, {7}", data0, data1, data2, data3, expected0, expected1, expected2, expected3));
                    }
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        string funcName = instance.GetType().Name;
                        dst0 = instance.YGroup4Zip_Bit128(data0, data1, data2, data3, out dst1, out dst2, out dst3);
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
