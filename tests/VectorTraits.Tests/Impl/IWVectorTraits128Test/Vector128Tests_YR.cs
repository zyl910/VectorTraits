using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Impl;
using Zyl.VectorTraits.Impl.AVector256;

namespace Zyl.VectorTraits.Tests.Impl.IWVectorTraits128Test {
    [TestFixture()]
    public class Vector128Tests_YR {
#if NETCOREAPP3_0_OR_GREATER

        [TestCase((float)1)]
        [TestCase((double)2)]
        public void YRoundToZeroTest<T>(T src) where T : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YRoundToZero_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector128s.GetSupportedMethodList<Func<Vector128<T>, Vector128<T>>>("YRoundToZero_Floor");
            var funcListFull = Vector128s.GetSupportedMethodList<Func<Vector128<T>, Vector128<T>>>("YRoundToZero", "YRoundToZero_Floor");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector128<T>[] samples = {
                Vector128s<T>.Serial,
                Vector128s.CreateByDoubleLoop<T>(-0.5, 1),
                Vector128s.CreateByDoubleLoop<T>(-0.5, -1),
                Vector128s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src) + 0.4, 0.3),
                Vector128s<T>.Demo,
                Vector128s<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector128<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector128<T> expected = Vector128s.YRoundToZero((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<T> dst = instance.YRoundToZero((dynamic)value);
                    if (allowLog || (showNotEquals && !expected.Equals(dst))) {
                        writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                    }
                }
                writer.WriteLine();
            }
            // Check data.
            const int stepCount = 4;
            const double stepDelta = 1.0 / stepCount;
            double rangeItemNumber = Math.Pow(2, 4);
            int rangeItemCount = (int)(rangeItemNumber * stepCount);
            List<double> rangeStarts = new List<double>() {
                0.0,
                rangeItemNumber,
            };
            if (rangeStarts.Count > 0) {
                var funcListCurrent = funcListFull;
                for (int i = -3; i <= 1; ++i) {
                    int n = Scalars<T>.MantissaBits + i;
                    double powValue = Math.Pow(2, n);
                    double powValueSub = powValue - rangeItemNumber;
                    rangeStarts.Add(powValueSub);
                    rangeStarts.Add(powValue);
                    rangeStarts.Add(-powValueSub);
                    rangeStarts.Add(-powValue);
                }
                int rangeItemCountVector128 = rangeItemCount / Vector128<T>.Count;
                SortedDictionary<string, long> dict = new SortedDictionary<string, long>();
                foreach (double start in rangeStarts) {
                    for (int i = 0; i < rangeItemCountVector128; ++i) {
                        double startNumber = start + Vector128<T>.Count * i * stepDelta;
                        Vector128<T> value = Vector128s.CreateByDoubleLoop<T>(startNumber, stepDelta);
                        Vector128<T> expected = Vector128s.BaseInstance.YRoundToZero((dynamic)value);
                        bool usedWrite = false;
                        // funcList.
                        foreach (var func in funcListCurrent) {
                            string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                            try {
                                Vector128<T> dst = func(value);
                                bool showLog = allowLog;
                                if (!expected.Equals(dst)) {
                                    long countError;
                                    if (!dict.TryGetValue(funcName, out countError)) {
                                        countError = 0;
                                    }
                                    if (countError <= 0) {
                                        showLog = true;
                                    }
                                    ++countError;
                                    dict[funcName] = countError;
                                }
                                if (showLog) {
                                    if (!usedWrite) {
                                        usedWrite = true;
                                        writer.WriteLine(VectorTextUtil.Format("Sample({0}):\t{1}", startNumber, value));
                                        writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                                    }
                                    writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}", funcName, dst));
                                }
                            } catch (Exception ex) {
                                //writer.WriteLine(string.Format("{0}:\t{1}", funcName, ex.Message));
                                _ = ex; // Ignore.
                            }
                        }
                        if (usedWrite) {
                            writer.WriteLine();
                        }
                    }
                } // foreach (double start in rangeStarts)
                writer.WriteLine("Count error:");
                foreach (var func in funcListCurrent) {
                    string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                    if (!dict.ContainsKey(funcName)) {
                        writer.WriteLine(VectorTextUtil.Format("{0}:\t0 // OK", funcName));
                    }
                }
                foreach (var kvp in dict) {
                    writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}", kvp.Key, kvp.Value));
                }
            } // if (rangeStarts.Length > 0)
        }


#endif
    }
}
