﻿using NUnit.Framework;
#if !USED_NUNIT3
using NUnit.Framework.Legacy;
#endif
using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Text;
using Zyl.VectorTraits.Impl;
using Zyl.VectorTraits.Impl.AVector;

namespace Zyl.VectorTraits.Tests.Impl.IVectorTraitsTest {
#if USED_NUNIT3
    using ClassicAssert = Assert;
#endif

    [TestFixture()]
    public class VectorTests_YR {

        [TestCase((float)1)]
        [TestCase((double)2)]
        public void YRoundToEvenTest<T>(T src) where T : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YRoundToEven_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<Func<Vector<T>, Vector<T>>>("YRoundToEven_Add");
            var funcListFull = Vectors.GetSupportedMethodList<Func<Vector<T>, Vector<T>>>("YRoundToEven", "YRoundToEven_Add");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector<T>[] samples = {
                Vectors<T>.Serial,
                Vectors.CreateByDoubleLoop<T>(-0.5, 1),
                Vectors.CreateByDoubleLoop<T>(-0.5, -1),
                Vectors.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src) + 0.4, 0.3),
                Vectors<T>.Demo,
                Vectors<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector<T> expected = Vectors.YRoundToEven((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IVectorTraits instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector<T> dst = instance.YRoundToEven((dynamic)value);
                    if (allowLog || (showNotEquals && !expected.Equals(dst))) {
                        writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
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
                int rangeItemCountVector = rangeItemCount / Vector<T>.Count;
                SortedDictionary<string, long> dict = new SortedDictionary<string, long>();
                foreach (double start in rangeStarts) {
                    for (int i = 0; i < rangeItemCountVector; ++i) {
                        double startNumber = start + Vector<T>.Count * i * stepDelta;
                        Vector<T> value = Vectors.CreateByDoubleLoop<T>(startNumber, stepDelta);
                        Vector<T> expected = Vectors.BaseInstance.YRoundToEven((dynamic)value);
                        bool usedWrite = false;
                        // funcList.
                        foreach (var func in funcListCurrent) {
                            string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                            try {
                                Vector<T> dst = func(value);
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
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YRoundToZero_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<Func<Vector<T>, Vector<T>>>("YRoundToZero_ClearBit", "YRoundToZero_ClearBit_Not", "YRoundToZero_Floor");
            var funcListFull = Vectors.GetSupportedMethodList<Func<Vector<T>, Vector<T>>>("YRoundToZero", "YRoundToZero_ClearBit", "YRoundToZero_ClearBit_Not", "YRoundToZero_Floor");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector<T>[] samples = {
                Vectors<T>.Serial,
                Vectors.CreateByDoubleLoop<T>(-0.5, 1),
                Vectors.CreateByDoubleLoop<T>(-0.5, -1),
                Vectors.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src) + 0.4, 0.3),
                Vectors<T>.Demo,
                Vectors<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector<T> expected = Vectors.YRoundToZero((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IVectorTraits instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector<T> dst = instance.YRoundToZero((dynamic)value);
                    if (allowLog || (showNotEquals && !expected.Equals(dst))) {
                        writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
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
                int rangeItemCountVector = rangeItemCount / Vector<T>.Count;
                SortedDictionary<string, long> dict = new SortedDictionary<string, long>();
                foreach (double start in rangeStarts) {
                    for (int i = 0; i < rangeItemCountVector; ++i) {
                        double startNumber = start + Vector<T>.Count * i * stepDelta;
                        Vector<T> value = Vectors.CreateByDoubleLoop<T>(startNumber, stepDelta);
                        Vector<T> expected = Vectors.BaseInstance.YRoundToZero((dynamic)value);
                        bool usedWrite = false;
                        // funcList.
                        foreach (var func in funcListCurrent) {
                            string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                            try {
                                Vector<T> dst = func(value);
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


    }
}
