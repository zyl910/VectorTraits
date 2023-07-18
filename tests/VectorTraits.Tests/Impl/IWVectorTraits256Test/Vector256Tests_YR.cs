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

namespace Zyl.VectorTraits.Tests.Impl.IWVectorTraits256Test {
    [TestFixture()]
    public class Vector256Tests_YR {
#if NETCOREAPP3_0_OR_GREATER

        [TestCase((float)1)]
        [TestCase((double)2)]
        public void YRoundToEvenTest<T>(T src) where T : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YRoundToEven_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector256s.GetSupportedMethodList<Func<Vector256<T>, Vector256<T>>>("YRoundToEven_Add");
            var funcListFull = Vector256s.GetSupportedMethodList<Func<Vector256<T>, Vector256<T>>>("YRoundToEven", "YRoundToEven_Add");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector256<T>[] samples = {
                Vector256s<T>.Serial,
                Vector256s.CreateByDoubleLoop<T>(-0.5, 1),
                Vector256s.CreateByDoubleLoop<T>(-0.5, -1),
                Vector256s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src) + 0.4, 0.3),
                Vector256s<T>.Demo,
                Vector256s<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector256<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector256<T> expected = Vector256s.YRoundToEven((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits256 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector256<T> dst = instance.YRoundToEven((dynamic)value);
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
                int rangeItemCountVector256 = rangeItemCount / Vector256<T>.Count;
                SortedDictionary<string, long> dict = new SortedDictionary<string, long>();
                foreach (double start in rangeStarts) {
                    for (int i = 0; i < rangeItemCountVector256; ++i) {
                        double startNumber = start + Vector256<T>.Count * i * stepDelta;
                        Vector256<T> value = Vector256s.CreateByDoubleLoop<T>(startNumber, stepDelta);
                        Vector256<T> expected = Vector256s.BaseInstance.YRoundToEven((dynamic)value);
                        bool usedWrite = false;
                        // funcList.
                        foreach (var func in funcListCurrent) {
                            string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                            try {
                                Vector256<T> dst = func(value);
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

        [TestCase((float)1)]
        [TestCase((double)2)]
        public void YRoundToZeroTest<T>(T src) where T : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YRoundToZero_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector256s.GetSupportedMethodList<Func<Vector256<T>, Vector256<T>>>("YRoundToZero_Floor");
            var funcListFull = Vector256s.GetSupportedMethodList<Func<Vector256<T>, Vector256<T>>>("YRoundToZero", "YRoundToZero_Floor");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector256<T>[] samples = {
                Vector256s<T>.Serial,
                Vector256s.CreateByDoubleLoop<T>(-0.5, 1),
                Vector256s.CreateByDoubleLoop<T>(-0.5, -1),
                Vector256s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src) + 0.4, 0.3),
                Vector256s<T>.Demo,
                Vector256s<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector256<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector256<T> expected = Vector256s.YRoundToZero((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits256 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector256<T> dst = instance.YRoundToZero((dynamic)value);
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
            if (rangeStarts.Count> 0) {
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
                int rangeItemCountVector256 = rangeItemCount / Vector256<T>.Count;
                SortedDictionary<string, long> dict = new SortedDictionary<string, long>();
                foreach (double start in rangeStarts) {
                    for (int i = 0; i < rangeItemCountVector256; ++i) {
                        double startNumber = start + Vector256<T>.Count * i * stepDelta;
                        Vector256<T> value = Vector256s.CreateByDoubleLoop<T>(startNumber, stepDelta);
                        Vector256<T> expected = Vector256s.BaseInstance.YRoundToZero((dynamic)value);
                        bool usedWrite = false;
                        // funcList.
                        foreach (var func in funcListCurrent) {
                            string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                            try {
                                Vector256<T> dst = func(value);
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
