using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.Reflection;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using NUnit.Framework.Internal;
using Zyl.VectorTraits.Impl;
using Zyl.VectorTraits.Impl.AVector256;

namespace Zyl.VectorTraits.Tests.Impl.IWVectorTraits256Test {
    [TestFixture()]
    public class Vector256Tests_C {
#if NETCOREAPP3_0_OR_GREATER

        [TestCase((float)1)]
        [TestCase((double)2)]
        public void CeilingTest<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.Ceiling_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector256<T>[] samples = {
                Vector256s<T>.Demo,
                Vector256s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src) + 0.4, 0.3)
            };
            foreach (Vector256<T> value in samples) {
                Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector256<T> expected = Vector256s.Ceiling((dynamic)value);
                Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits256 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector256<T> dst = instance.Ceiling((dynamic)value);
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
            //Vector256<T> vzero = Vector256<T>.Zero;
            //T zero = default;
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.ConditionalSelect_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector256<T>[] conditions = {
                Vector256s<T>.Demo,
                Vector256s<T>.XyXMask,
                Vector256s<T>.XyYMask,
                Vector256s<T>.XyzwXMask,
                Vector256s<T>.XyzwYMask,
                Vector256s<T>.XyzwZMask,
                Vector256s<T>.XyzwWMask,
            };
            Vector256<T>[] samples = {
                Vector256s.Create(src),
                Vector256s<T>.Demo,
                Vector256s<T>.Serial,
            };
            foreach (Vector256<T> left in samples) {
                foreach (Vector256<T> right in samples) {
                    foreach (Vector256<T> condition in conditions) {
                        Vector256<T> expected = Vector256s.ConditionalSelect(condition, left, right);
                        foreach (IWVectorTraits256 instance in instances) {
                            if (!instance.GetIsSupported(true)) continue;
                            Vector256<T> dst = instance.ConditionalSelect(condition, left, right);
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
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.ConvertToDouble_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            Console.WriteLine();
            // run.
            Vector256<T>[] samples = {
                Vector256s<T>.Serial,
                Vector256s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src) - 16, 8),
                Vector256s<T>.Demo,
                Vector256s<T>.DemoNaN,
            };
            //bool allowLog = true;
            //bool hideEquals = true;
            foreach (Vector256<T> value in samples) {
                Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector256<double> expected = Vector256s.ConvertToDouble((dynamic)value);
                Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits256 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector256<double> dst = instance.ConvertToDouble((dynamic)value);
                    Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                }
                Console.WriteLine();
            }
        }

        [TestCase((long)9)]
        [TestCase((ulong)10)]
        public void ConvertToDouble_Range52Test<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.ConvertToDouble_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector256s.GetSupportedMethodList<Func<Vector256<T>, Vector256<double>>>("ConvertToDouble_Bcl", "ConvertToDouble_Range52", "ConvertToDouble_Range52_Impl");
            foreach (var func in funcList) {
                Console.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            Console.WriteLine();
            // run.
            Vector256<T>[] samples = {
                Vector256s<T>.Serial,
                Vector256s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src) - 16, 8),
                Vector256s<T>.Demo,
                Vector256s<T>.DemoNaN,
            };
            bool allowLog = false;
            bool hideEquals = true;
            foreach (Vector256<T> value in samples) {
                Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector256<double> expected = Vector256s.ConvertToDouble_Range52((dynamic)value);
                Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits256 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector256<double> dst = instance.ConvertToDouble_Range52((dynamic)value);
                    Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                }
                foreach (var func in funcList) {
                    string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                    try {
                        Vector256<double> dst = func(value);
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
                int rangeItemCountVector = rangeItemCount / Vector256<T>.Count;
                SortedDictionary<string, long> dict = new SortedDictionary<string, long>();
                foreach (long start in rangeStarts) {
                    for (int i = 0; i < rangeItemCountVector; ++i) {
                        long startNumber = start + Vector256<T>.Count * i;
                        Vector256<T> value = Vector256s.CreateByFunc<T>(index => Scalars.GetByBits<T>(startNumber + index));
                        Vector256<double> expected = Vector256s.BaseInstance.ConvertToDouble((dynamic)value);
                        bool usedWrite = false;
                        // funcList.
                        foreach (var func in funcList) {
                            string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                            try {
                                Vector256<double> dst = func(value);
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
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.ConvertToInt32_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            Console.WriteLine();
            // run.
            Vector256<T>[] samples = {
                Vector256s<T>.Serial,
                Vector256s.CreateByDoubleLoop<T>(-0.5 - Scalars.GetDoubleFrom(src), 1),
                Vector256s<T>.Demo,
                Vector256s<T>.DemoNaN,
            };
            bool allowLog = false;
            foreach (Vector256<T> value in samples) {
                Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector256<int> expected = Vector256s.ConvertToInt32((dynamic)value);
                Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits256 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector256<int> dst = instance.ConvertToInt32((dynamic)value);
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
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.ConvertToInt64_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector256s.GetSupportedMethodList<Func<Vector256<T>, Vector256<long>>>("ConvertToInt64_HwScalar", "ConvertToInt64_Veloctor");
            foreach (var func in funcList) {
                Console.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            Console.WriteLine();
            // run.
            Vector256<T>[] samples = {
                Vector256s<T>.Serial,
                Vector256s.CreateByDoubleLoop<T>(-0.5 - Scalars.GetDoubleFrom(src), 1),
                // It is out of range of UInt64, but still in the range of Int64.
                Vector256s.CreateByDoubleLoop<T>(-Math.Pow(2, 63), Math.Pow(2, 10)),
                // It is out of the range of Int64, but still in the range of UInt64.
                Vector256s.CreateByDoubleLoop<T>(Math.Pow(2, 63), Math.Pow(2, 11)),
                Vector256s.CreateByDoubleLoop<T>(Math.Pow(2, 64), -Math.Pow(2, 11)),
                // It is out of range.
                Vector256s.CreateByDoubleLoop<T>(-Math.Pow(2, 63), -Math.Pow(2, 11)),
                Vector256s.CreateByDoubleLoop<T>(Math.Pow(2, 64), Math.Pow(2, 12)),
                Vector256s.CreateByFunc<T>(index=>Scalars.GetByDouble<T>(Math.Pow(2, 63+index))),
                Vector256s.CreateByFunc<T>(index=>Scalars.GetByDouble<T>(Math.Pow(2, 1023-index))),
                Vector256s<T>.Demo,
                Vector256s<T>.DemoNaN,
            };
            bool allowLog = false;
            bool hideEquals = true;
            foreach (Vector256<T> value in samples) {
                Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector256<long> expected = Vector256s.ConvertToInt64((dynamic)value);
                Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits256 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector256<long> dst = instance.ConvertToInt64((dynamic)value);
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                    }
                }
                foreach (var func in funcList) {
                    string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                    try {
                        Vector256<long> dst = func(value);
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
            int rangeItemCount = (int)Math.Pow(2, 13);
            int rangeItemCountVector = rangeItemCount / Vector256<T>.Count;
            double[] rangeStarts = new double[] {
                -Math.Pow(2, 63),
                0.0,
                Math.Pow(2, 62),
                (Math.Pow(2, 63)-rangeItemCount)
            };
            double maxValueOut = Math.Pow(2, 63);
            SortedDictionary<string, long> dict = new SortedDictionary<string, long>();
            foreach (double start in rangeStarts) {
                for (int i = 0; i < rangeItemCountVector; ++i) {
                    double startNumber = start + Vector256<T>.Count * i;
                    if (startNumber >= maxValueOut) continue;
                    Vector256<T> value = Vector256s.CreateByDoubleLoop<T>(startNumber, 1);
                    Vector256<long> expected = Vector256s.BaseInstance.ConvertToInt64((dynamic)value);
                    foreach (IWVectorTraits256 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        string funcName = instance.GetType().Name;
                        Vector256<long> dst = instance.ConvertToInt64((dynamic)value);
                        Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                    }
                    bool usedWrite = false;
                    // funcList.
                    foreach (var func in funcList) {
                        string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                        try {
                            Vector256<long> dst = func(value);
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
        }

        [TestCase((double)2)]
        public void ConvertToInt64_Range52Test<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.ConvertToInt64_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector256s.GetSupportedMethodList<Func<Vector256<T>, Vector256<long>>>("ConvertToInt64_Range52", "ConvertToInt64_Range52_Impl", "ConvertToInt64_Range52_NoTruncate");
            foreach (var func in funcList) {
                Console.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            Console.WriteLine();
            // run.
            Vector256<T>[] samples = {
                Vector256s<T>.Serial,
                Vector256s.CreateByDoubleLoop<T>(-0.5 - Scalars.GetDoubleFrom(src), 1),
                Vector256s<T>.Demo,
                Vector256s<T>.DemoNaN,
            };
            bool allowLog = true;
            bool hideEquals = true;
            foreach (Vector256<T> value in samples) {
                Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector256<long> expected = Vector256s.ConvertToInt64((dynamic)value);
                Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits256 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector256<long> dst = instance.ConvertToInt64_Range52((dynamic)value);
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                    }
                }
                foreach (var func in funcList) {
                    string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                    try {
                        Vector256<long> dst = func(value);
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
                int rangeItemCountVector = rangeItemCount / Vector256<T>.Count;
                SortedDictionary<string, long> dict = new SortedDictionary<string, long>();
                foreach (double start in rangeStarts) {
                    for (int i = 0; i < rangeItemCountVector; ++i) {
                        double startNumber = start + Vector256<T>.Count * i * stepDelta;
                        Vector256<T> value = Vector256s.CreateByDoubleLoop<T>(start, stepDelta);
                        Vector256<long> expected = Vector256s.BaseInstance.ConvertToInt64((dynamic)value);
                        bool usedWrite = false;
                        // funcList.
                        foreach (var func in funcList) {
                            string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                            try {
                                Vector256<long> dst = func(value);
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
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.ConvertToSingle_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            Console.WriteLine();
            // run.
            Vector256<T>[] samples = {
                Vector256s<T>.Serial,
                Vector256s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src) - 16, 8),
                Vector256s<T>.Demo,
                Vector256s<T>.DemoNaN,
            };
            foreach (Vector256<T> value in samples) {
                Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector256<float> expected = Vector256s.ConvertToSingle((dynamic)value);
                Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits256 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector256<float> dst = instance.ConvertToSingle((dynamic)value);
                    Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                }
                Console.WriteLine();
            }
        }

        [TestCase((float)1)]
        public void ConvertToUInt32Test<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.ConvertToUInt32_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector256s.GetSupportedMethodList<Func<Vector256<T>, Vector256<uint>>>("ConvertToUInt32_As", "ConvertToUInt32_Mapping", "ConvertToUInt32_MappingFix", "ConvertToUInt32_Mod");
            foreach (var func in funcList) {
                Console.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            Console.WriteLine();
            // run.
            Vector256<T>[] samples = {
                Vector256s<T>.Serial,
                Vector256s.CreateByDoubleLoop<T>(-0.5 - Scalars.GetDoubleFrom(src), 1),
                // It is out of the range of Int32, but still in the range of UInt32.
                Vector256s.CreateByDoubleLoop<T>(Math.Pow(2, 31), Math.Pow(2, 6)),
                Vector256s.CreateByDoubleLoop<T>(Math.Pow(2, 32), -Math.Pow(2, 8)),
                // It is out of range of UInt32, but still in the range of Int32.
                Vector256s.CreateByDoubleLoop<T>(-Math.Pow(2, 31), Math.Pow(2, 6)),
                // It is out of range.
                Vector256s.CreateByDoubleLoop<T>(-Math.Pow(2, 31), -Math.Pow(2, 8)),
                Vector256s.CreateByDoubleLoop<T>(Math.Pow(2, 32), Math.Pow(2, 8)),
                Vector256s.CreateByFunc<T>(index=>Scalars.GetByDouble<T>(Math.Pow(2, 31+index))),
                Vector256s.CreateByFunc<T>(index=>Scalars.GetByDouble<T>(Math.Pow(2, 127-index))),
                Vector256s<T>.Demo,
                Vector256s<T>.DemoNaN,
            };
            bool allowLog = true;
            bool hideEquals = true;
            foreach (Vector256<T> value in samples) {
                Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector256<uint> expected = Vector256s.BaseInstance.ConvertToUInt32((dynamic)value);
                Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits256 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector256<uint> dst = instance.ConvertToUInt32((dynamic)value);
                    if (allowLog) {
                        if (!hideEquals || !expected.Equals(dst)) {
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                        }
                    } else {
                        Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                    }
                }
                foreach (var func in funcList) {
                    string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                    try {
                        Vector256<uint> dst = func(value);
                        if (!hideEquals || !expected.Equals(dst)) {
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
            int rangeItemCount = (int)Math.Pow(2, 12);
            int rangeItemCountVector = rangeItemCount / Vector256<T>.Count;
            double[] rangeStarts = new double[] {
                0.0,
                Math.Pow(2, 31),
                (Math.Pow(2, 32)-rangeItemCount)
            };
            float maxValueOut = (float)Math.Pow(2, 32);
            SortedDictionary<string, long> dict = new SortedDictionary<string, long>();
            foreach (double start in rangeStarts) {
                for (int i = 0; i < rangeItemCountVector; ++i) {
                    double startNumber = start + Vector256<T>.Count * i;
                    float startNumberSingle = (float)startNumber;
                    if (startNumberSingle >= maxValueOut) continue;
                    Vector256<T> value = Vector256s.CreateByDoubleLoop<T>(startNumber, 1);
                    Vector256<uint> expected = Vector256s.BaseInstance.ConvertToUInt32((dynamic)value);
                    foreach (IWVectorTraits256 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        string funcName = instance.GetType().Name;
                        Vector256<uint> dst = instance.ConvertToUInt32((dynamic)value);
                        Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                    }
                    bool usedWrite = false;
                    // funcList.
                    foreach (var func in funcList) {
                        string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                        try {
                            Vector256<uint> dst = func(value);
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
        }

        [TestCase((double)2)]
        public void ConvertToUInt64Test<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.ConvertToUInt64_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            Console.WriteLine();
            // run.
            Vector256<T>[] samples = {
                Vector256s<T>.Serial,
                Vector256s.CreateByDoubleLoop<T>(-0.5 - Scalars.GetDoubleFrom(src), 1),
                Vector256s<T>.Demo,
                Vector256s<T>.DemoNaN,
            };
            bool allowLog = false;
            foreach (Vector256<T> value in samples) {
                Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector256<ulong> expected = Vector256s.ConvertToUInt64((dynamic)value);
                Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits256 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector256<ulong> dst = instance.ConvertToUInt64((dynamic)value);
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
        public void ConvertToUInt64_Range52Test<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.ConvertToUInt64_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector256s.GetSupportedMethodList<Func<Vector256<T>, Vector256<ulong>>>("ConvertToUInt64_Range52_Impl", "ConvertToUInt64_Range52_NoTruncate");
            foreach (var func in funcList) {
                Console.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            Console.WriteLine();
            Console.WriteLine();
            // run.
            Vector256<T>[] samples = {
                Vector256s<T>.Serial,
                Vector256s.CreateByDoubleLoop<T>(-0.5 - Scalars.GetDoubleFrom(src), 1),
                Vector256s<T>.Demo,
                Vector256s<T>.DemoNaN,
            };
            bool allowLog = false;
            bool hideEquals = true;
            foreach (Vector256<T> value in samples) {
                Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector256<ulong> expected = Vector256s.ConvertToUInt64((dynamic)value);
                Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits256 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector256<ulong> dst = instance.ConvertToUInt64((dynamic)value);
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                    }
                }
                foreach (var func in funcList) {
                    string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                    try {
                        Vector256<ulong> dst = func(value);
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
                    0,
                    Math.Pow(2, 51),
                    Math.Pow(2, 52) - rangeItemNumber,
                    // Out of range.
                    //Math.Pow(2, 52),
            };
            if (rangeStarts.Length > 0) {
                int rangeItemCountVector = rangeItemCount / Vector256<T>.Count;
                SortedDictionary<string, ulong> dict = new SortedDictionary<string, ulong>();
                foreach (double start in rangeStarts) {
                    for (int i = 0; i < rangeItemCountVector; ++i) {
                        double startNumber = start + Vector256<T>.Count * i * stepDelta;
                        Vector256<T> value = Vector256s.CreateByDoubleLoop<T>(start, stepDelta);
                        Vector256<ulong> expected = Vector256s.BaseInstance.ConvertToUInt64((dynamic)value);
                        bool usedWrite = false;
                        // funcList.
                        foreach (var func in funcList) {
                            string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                            try {
                                Vector256<ulong> dst = func(value);
                                bool showLog = allowLogAll;
                                if (!expected.Equals(dst)) {
                                    ulong countError;
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
                } // foreach (ulong start in rangeStarts)
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


#endif
    }
}
