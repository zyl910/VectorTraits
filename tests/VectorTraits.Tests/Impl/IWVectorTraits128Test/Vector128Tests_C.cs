using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Tests.Impl.IWVectorTraits128Test {
    [TestFixture()]
    public class Vector128Tests_C {
#if NETCOREAPP3_0_OR_GREATER

        [TestCase((float)1)]
        [TestCase((double)2)]
        public void CeilingTest<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.Ceiling_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector128<T>[] samples = {
                Vector128s<T>.Demo,
                Vector128s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src) + 0.4, 0.3)
            };
            foreach (Vector128<T> value in samples) {
                Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector128<T> expected = Vector128s.Ceiling((dynamic)value);
                Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<T> dst = instance.Ceiling((dynamic)value);
                    Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
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
        public void ConditionalSelectTest<T>(T src) where T : struct {
            //Vector128<T> vzero = Vector128<T>.Zero;
            //T zero = default;
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.ConditionalSelect_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector128<T>[] conditions = {
                Vector128s<T>.Demo,
                Vector128s<T>.XyXMask,
                Vector128s<T>.XyYMask,
                Vector128s<T>.XyzwXMask,
                Vector128s<T>.XyzwYMask,
                Vector128s<T>.XyzwZMask,
                Vector128s<T>.XyzwWMask,
            };
            Vector128<T>[] samples = {
                Vector128s.Create(src),
                Vector128s<T>.Demo,
                Vector128s<T>.Serial,
            };
            foreach (Vector128<T> left in samples) {
                foreach (Vector128<T> right in samples) {
                    foreach (Vector128<T> condition in conditions) {
                        Vector128<T> expected = Vector128s.ConditionalSelect(condition, left, right);
                        foreach (IWVectorTraits128 instance in instances) {
                            if (!instance.GetIsSupported(true)) continue;
                            Vector128<T> dst = instance.ConditionalSelect(condition, left, right);
                            // NaN equality problem --
                            // Expected: <-1.7976931348623157E+308, NaN>
                            // But was:  <-1.7976931348623157E+308, NaN>
                            //Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, condition={condition}, left={left}, right={right}");
                            // Fixed NaN equality problem.
                            Assert.AreEqual(expected.AsByte(), dst.AsByte(), $"{instance.GetType().Name}, condition={condition}, left={left}, right={right}");
                        }
                    }
                }
            }
        }

        [TestCase((long)9)]
        [TestCase((ulong)10)]
        public void ConvertToDoubleTest<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.ConvertToDouble_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            Console.WriteLine();
            // run.
            Vector128<T>[] samples = {
                Vector128s<T>.Serial,
                Vector128s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src) - 16, 8),
                Vector128s<T>.Demo,
                Vector128s<T>.DemoNaN,
            };
            foreach (Vector128<T> value in samples) {
                Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector128<double> expected = Vector128s.ConvertToDouble((dynamic)value);
                Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<double> dst = instance.ConvertToDouble((dynamic)value);
                    Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                }
                Console.WriteLine();
            }
        }

        [TestCase((long)9)]
        [TestCase((ulong)10)]
        public void ConvertToDouble_Range52Test<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.ConvertToDouble_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector128s.GetSupportedMethodList<Func<Vector128<T>, Vector128<double>>>("ConvertToDouble_Bcl", "ConvertToDouble_Range52", "ConvertToDouble_Range52_Impl");
            foreach (var func in funcList) {
                Console.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            Console.WriteLine();
            // run.
            Vector128<T>[] samples = {
                Vector128s<T>.Serial,
                Vector128s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src) - 16, 8),
                Vector128s<T>.Demo,
                Vector128s<T>.DemoNaN,
            };
            bool allowLog = false;
            bool hideEquals = true;
            foreach (Vector128<T> value in samples) {
                Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector128<double> expected = Vector128s.ConvertToDouble_Range52((dynamic)value);
                Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<double> dst = instance.ConvertToDouble_Range52((dynamic)value);
                    Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                }
                foreach (var func in funcList) {
                    string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                    try {
                        Vector128<double> dst = func(value);
                        if (allowLog || !hideEquals || !expected.Equals(dst)) {
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", funcName, dst));
                        }
                    } catch (Exception ex) {
                        Console.WriteLine(string.Format("{0}:\t{1}", funcName, ex.Message));
                    }
                }
                Console.WriteLine();
            }
            // Check data in the valid range.
            bool allowLogAll = false;
            int rangeItemCount = (int)Math.Pow(2, 4);
            long[] rangeStarts = new long[0];
            if (typeof(long) == typeof(T)) {
                rangeStarts = new long[] {
                    -(1L<<51),
                    -(1L<<50),
                    0L,
                    1L<<50,
                    (1L<<51) - rangeItemCount,
                    // Out of range.
                    //1L<<51,
                    //(1L<<52) - rangeItemCount,
                    //1L<<52,
                };
            } else if (typeof(ulong) == typeof(T)) {
                rangeStarts = new long[] {
                    0L,
                    1L<<51,
                    (1L<<52) - rangeItemCount,
                    // Out of range.
                    //1L<<52,
                };
            }
            if (rangeStarts.Length > 0) {
                int rangeItemCountVector = rangeItemCount / Vector128<T>.Count;
                SortedDictionary<string, long> dict = new SortedDictionary<string, long>();
                foreach (long start in rangeStarts) {
                    for (int i = 0; i < rangeItemCountVector; ++i) {
                        long startNumber = start + Vector128<T>.Count * i;
                        Vector128<T> value = Vector128s.CreateByFunc<T>(index => Scalars.GetByBits<T>(startNumber + index));
                        Vector128<double> expected = Vector128s.BaseInstance.ConvertToDouble((dynamic)value);
                        bool usedWrite = false;
                        // funcList.
                        foreach (var func in funcList) {
                            string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                            try {
                                Vector128<double> dst = func(value);
                                bool showLog = allowLogAll;
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
                                        Console.WriteLine(VectorTextUtil.Format("Sample({0}):\t{1}", startNumber, value));
                                        Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                                    }
                                    Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", funcName, dst));
                                }
                            } catch (Exception ex) {
                                //Console.WriteLine(string.Format("{0}:\t{1}", funcName, ex.Message));
                                _ = ex; // Ignore.
                            }
                        }
                        if (usedWrite) {
                            Console.WriteLine();
                        }
                    }
                } // foreach (long start in rangeStarts)
                Console.WriteLine("Count error:");
                foreach (var func in funcList) {
                    string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                    if (!dict.ContainsKey(funcName)) {
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t0 // OK", funcName));
                    }
                }
                foreach (var kvp in dict) {
                    Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", kvp.Key, kvp.Value));
                }
            } // if (rangeStarts.Length > 0)
        }

        [TestCase((float)1)]
        public void ConvertToInt32Test<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.ConvertToInt32_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            Console.WriteLine();
            // run.
            Vector128<T>[] samples = {
                Vector128s<T>.Serial,
                Vector128s.CreateByDoubleLoop<T>(-0.5 - Scalars.GetDoubleFrom(src), 1),
                Vector128s<T>.Demo,
                Vector128s<T>.DemoNaN,
            };
            bool allowLog = false;
            foreach (Vector128<T> value in samples) {
                Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector128<int> expected = Vector128s.ConvertToInt32((dynamic)value);
                Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<int> dst = instance.ConvertToInt32((dynamic)value);
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
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.ConvertToInt64_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector128s.GetSupportedMethodList<Func<Vector128<T>, Vector128<long>>>("ConvertToInt64_HwScalar");
            foreach (var func in funcList) {
                Console.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            Console.WriteLine();
            // run.
            Vector128<T>[] samples = {
                Vector128s<T>.Serial,
                Vector128s.CreateByDoubleLoop<T>(-0.5 - Scalars.GetDoubleFrom(src), 1),
                Vector128s<T>.Demo,
                Vector128s<T>.DemoNaN,
            };
            bool allowLog = false;
            bool hideEquals = true;
            foreach (Vector128<T> value in samples) {
                Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector128<long> expected = Vector128s.ConvertToInt64((dynamic)value);
                Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<long> dst = instance.ConvertToInt64((dynamic)value);
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                    }
                }
                foreach (var func in funcList) {
                    string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                    try {
                        Vector128<long> dst = func(value);
                        if (allowLog || !hideEquals || !expected.Equals(dst)) {
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", funcName, dst));
                        }
                    } catch (Exception ex) {
                        Console.WriteLine(string.Format("{0}:\t{1}", funcName, ex.Message));
                    }
                }
                Console.WriteLine();
            }
        }

        [TestCase((double)2)]
        public void ConvertToInt64_Range52Test<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.ConvertToInt64_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector128s.GetSupportedMethodList<Func<Vector128<T>, Vector128<long>>>("ConvertToInt64_Range52", "ConvertToInt64_Range52_Impl", "ConvertToInt64_Range52_NoTruncate");
            foreach (var func in funcList) {
                Console.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            Console.WriteLine();
            // run.
            Vector128<T>[] samples = {
                Vector128s<T>.Serial,
                Vector128s.CreateByDoubleLoop<T>(-0.5 - Scalars.GetDoubleFrom(src), 1),
                Vector128s<T>.Demo,
                Vector128s<T>.DemoNaN,
            };
            bool allowLog = true;
            bool hideEquals = true;
            foreach (Vector128<T> value in samples) {
                Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector128<long> expected = Vector128s.ConvertToInt64((dynamic)value);
                Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<long> dst = instance.ConvertToInt64_Range52((dynamic)value);
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                    }
                }
                foreach (var func in funcList) {
                    string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                    try {
                        Vector128<long> dst = func(value);
                        if (allowLog || !hideEquals || !expected.Equals(dst)) {
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", funcName, dst));
                        }
                    } catch (Exception ex) {
                        Console.WriteLine(string.Format("{0}:\t{1}", funcName, ex.Message));
                    }
                }
                Console.WriteLine();
            }
            // Check data in the valid range.
            bool allowLogAll = false;
            const int stepCount = 2;
            const double stepDelta = 1.0 / stepCount;
            double rangeItemNumber = Math.Pow(2, 4);
            int rangeItemCount = (int)(rangeItemNumber * stepCount);
            double[] rangeStarts = new double[] {
                    -Math.Pow(2, 51),
                    -Math.Pow(2, 50),
                    0,
                    Math.Pow(2, 50),
                    Math.Pow(2, 51) - rangeItemNumber,
                    // Out of range.
                    //Math.Pow(2, 51),
                    //Math.Pow(2, 52) - rangeItemNumber,
                    //Math.Pow(2, 52),
            };
            if (rangeStarts.Length > 0) {
                int rangeItemCountVector = rangeItemCount / Vector128<T>.Count;
                SortedDictionary<string, long> dict = new SortedDictionary<string, long>();
                foreach (double start in rangeStarts) {
                    for (int i = 0; i < rangeItemCountVector; ++i) {
                        double startNumber = start + Vector128<T>.Count * i * stepDelta;
                        Vector128<T> value = Vector128s.CreateByDoubleLoop<T>(start, stepDelta);
                        Vector128<long> expected = Vector128s.BaseInstance.ConvertToInt64((dynamic)value);
                        bool usedWrite = false;
                        // funcList.
                        foreach (var func in funcList) {
                            string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                            try {
                                Vector128<long> dst = func(value);
                                bool showLog = allowLogAll;
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
                                        Console.WriteLine(VectorTextUtil.Format("Sample({0}):\t{1}", startNumber, value));
                                        Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                                    }
                                    Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", funcName, dst));
                                }
                            } catch (Exception ex) {
                                //Console.WriteLine(string.Format("{0}:\t{1}", funcName, ex.Message));
                                _ = ex; // Ignore.
                            }
                        }
                        if (usedWrite) {
                            Console.WriteLine();
                        }
                    }
                } // foreach (long start in rangeStarts)
                Console.WriteLine("Count error:");
                foreach (var func in funcList) {
                    string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                    if (!dict.ContainsKey(funcName)) {
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t0 // OK", funcName));
                    }
                }
                foreach (var kvp in dict) {
                    Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", kvp.Key, kvp.Value));
                }
            } // if (rangeStarts.Length > 0)
        }

        [TestCase((int)7)]
        [TestCase((uint)8)]
        public void ConvertToSingleTest<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.ConvertToSingle_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            Console.WriteLine();
            // run.
            Vector128<T>[] samples = {
                Vector128s<T>.Serial,
                Vector128s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src) - 16, 8),
                Vector128s<T>.Demo,
                Vector128s<T>.DemoNaN,
            };
            foreach (Vector128<T> value in samples) {
                Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector128<float> expected = Vector128s.ConvertToSingle((dynamic)value);
                Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<float> dst = instance.ConvertToSingle((dynamic)value);
                    Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                }
                Console.WriteLine();
            }
        }

        [TestCase((float)1)]
        public void ConvertToUInt32Test<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.ConvertToUInt32_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            Console.WriteLine();
            // run.
            Vector128<T>[] samples = {
                Vector128s<T>.Serial,
                Vector128s.CreateByDoubleLoop<T>(-0.5 - Scalars.GetDoubleFrom(src), 1),
                Vector128s<T>.Demo,
                Vector128s<T>.DemoNaN,
            };
            bool allowLog = false;
            foreach (Vector128<T> value in samples) {
                Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector128<uint> expected = Vector128s.ConvertToUInt32((dynamic)value);
                Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<uint> dst = instance.ConvertToUInt32((dynamic)value);
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
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.ConvertToUInt64_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            Console.WriteLine();
            // run.
            Vector128<T>[] samples = {
                Vector128s<T>.Serial,
                Vector128s.CreateByDoubleLoop<T>(-0.5 - Scalars.GetDoubleFrom(src), 1),
                Vector128s<T>.Demo,
                Vector128s<T>.DemoNaN,
            };
            bool allowLog = false;
            foreach (Vector128<T> value in samples) {
                Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector128<ulong> expected = Vector128s.ConvertToUInt64((dynamic)value);
                Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<ulong> dst = instance.ConvertToUInt64((dynamic)value);
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                    }
                }
                Console.WriteLine();
            }
        }


#endif
    }
}
