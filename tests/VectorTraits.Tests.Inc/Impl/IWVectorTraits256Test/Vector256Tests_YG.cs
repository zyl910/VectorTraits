using NUnit.Framework;
#if !USED_NUNIT3
using NUnit.Framework.Legacy;
#endif
using System;
using System.Collections.Generic;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using System.IO;
using System.Text;
using Zyl.VectorTraits.Impl;
using Zyl.VectorTraits.Impl.Delegates;

namespace Zyl.VectorTraits.Tests.Impl.IWVectorTraits256Test {
#if USED_NUNIT3
    using ClassicAssert = Assert;
#endif

    [TestFixture()]
    public class Vector256Tests_YG {
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
        public void YGroup2ZipTest<T>(T src) where T : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YGroup2Zip_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector256s.GetSupportedMethodList<FuncIn2Out1<Vector256<T>>>("YGroup2Zip_Basic", "YGroup2Zip_Unpack", "YGroup2Zip_Widen");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            bool[] funcListUnsupported = new bool[funcList.Count];
            writer.WriteLine();
            // run.
            Vector256<T>[] samples = {
                Vector256s<T>.Serial,
                Vector256s<T>.SerialDesc,
                Vector256s<T>.SerialNegative,
                Vector256s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1.0),
                Vector256s.CreateByDoubleLoop<T>(-Scalars.GetDoubleFrom(src), -1.0),
            };
            bool allowLog = false;
            bool isFloatType = Scalars<T>.ExponentBits > 0;
            for (int i=0; i<samples.Length; i++) {
                Vector256<T> x = samples[i];
                for (int j = 0; j < samples.Length; j++) {
                    if (j == i) continue;
                    Vector256<T> y = samples[j];
                    Vector256<T> dst0, dst1;
#pragma warning disable CS0618 // Type or member is obsolete
                    (Vector256<T> expected0, Vector256<T> expected1) = Vector256s.YGroup2Zip(x, y);
                    if (allowLog && 0==i && 1==j) {
                        writer.WriteLine(VectorTextUtil.Format("f({0}, {1}): {2}, {3}", x, y, expected0, expected1));
                    }
                    foreach (IWVectorTraits256 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        string funcName = instance.GetType().Name;
                        (dst0, dst1) = instance.YGroup2Zip(x, y);
                        if (isFloatType) {
                            ClassicAssert.AreEqual(expected0.AsByte(), dst0.AsByte(), VectorTextUtil.Format("Part 0 on {0}: {1}, {2}", funcName, x, y));
                            ClassicAssert.AreEqual(expected1.AsByte(), dst1.AsByte(), VectorTextUtil.Format("Part 1 on {0}: {1}, {2}", funcName, x, y));
                        } else {
                            ClassicAssert.AreEqual(expected0, dst0, VectorTextUtil.Format("Part 0 on {0}: {1}, {2}", funcName, x, y));
                            ClassicAssert.AreEqual(expected1, dst1, VectorTextUtil.Format("Part 1 on {0}: {1}, {2}", funcName, x, y));
                        }
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
                        if (isFloatType) {
                            ClassicAssert.AreEqual(expected0.AsByte(), dst0.AsByte(), VectorTextUtil.Format("Part 0 on {0}: {1}, {2}", funcName, x, y));
                            ClassicAssert.AreEqual(expected1.AsByte(), dst1.AsByte(), VectorTextUtil.Format("Part 1 on {0}: {1}, {2}", funcName, x, y));
                        } else {
                            ClassicAssert.AreEqual(expected0, dst0, VectorTextUtil.Format("Part 0 on {0}: {1}, {2}", funcName, x, y));
                            ClassicAssert.AreEqual(expected1, dst1, VectorTextUtil.Format("Part 1 on {0}: {1}, {2}", funcName, x, y));
                        }
                    } // funcList
#pragma warning restore CS0618 // Type or member is obsolete
                }
            }
        }

#endif
    }
}
