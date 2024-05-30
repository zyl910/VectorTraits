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
#if ALLOW_VECTOR_TUPLES
using Zyl.VectorTraits.Tuples;
#endif // ALLOW_VECTOR_TUPLES

namespace Zyl.VectorTraits.Tests.Impl.IWVectorTraits512Test {
#if USED_NUNIT3
    using ClassicAssert = Assert;
#endif

    [TestFixture()]
    public class Vector512Tests_YS {
#if NET8_0_OR_GREATER

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
        public void YShuffleG2Test<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.YShuffleG2_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            bool allowLog = true;
            //bool allowLogItem = Scalars<T>.ExponentBits > 0;
            bool allowLogItem = false;
            Vector512<T>[] samples = {
                Vector512s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1),
                //Vector512s<T>.Demo,
                Vector512s<T>.Serial,
                //Vector512s<T>.SerialNegative
            };
            foreach (Vector512<T> source in samples) {
                if (allowLog) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("== Sample:\t{0}", source));
                }
                for (int j = 0; j <= 3; ++j) {
                    ShuffleControlG2 control = (ShuffleControlG2)j;
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("-- Control:\t{0}", control));
                    }
                    Vector512<T> expected = Vector512s.YShuffleG2((dynamic)source, control);
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                    }
                    Vector512<T> dst;
                    // Instances
                    foreach (IWVectorTraits512 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        dst = instance.YShuffleG2((dynamic)source, control);
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, source={2}, control={3}", instance.GetType().Name, dst, source, control));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, source={source}, control={control}");
                        }
                    }
                    if (allowLog) {
                        Console.WriteLine();
                    }
                } // j
            } // samples
        }

#if !REDUCE_MEMORY_USAGE
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
        public void YShuffleG2_ConstTest<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.YShuffleG2_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector512s.GetSupportedMethodList<Func<Vector512<T>, ShuffleControlG2, Vector512<T>>>("YShuffleG2_Const_Imm");
            foreach (var func in funcList) {
                Console.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            // run.
            bool allowLog = true;
            //bool allowLogItem = Scalars<T>.ExponentBits > 0;
            bool allowLogItem = false;
            Vector512<T>[] samples = {
                Vector512s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1),
                //Vector512s<T>.Demo,
                Vector512s<T>.Serial,
                //Vector512s<T>.SerialNegative
            };
            //ShuffleControlG2 control = ShuffleControlG2.YX;
            foreach (Vector512<T> source in samples) {
                if (allowLog) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("== Sample:\t{0}", source));
                }
                for (int j = 0; j <= 3; ++j) {
                    ShuffleControlG2 control = (ShuffleControlG2)j;
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("-- Control:\t{0}", control));
                    }
                    Vector512<T> expected = Vector512s.YShuffleG2_Const((dynamic)source, control);
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                    }
                    Vector512<T> dst;
                    // Instances
                    foreach (IWVectorTraits512 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        dst = instance.YShuffleG2_Const((dynamic)source, control);
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, source={2}, control={3}", instance.GetType().Name, dst, source, control));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, source={source}, control={control}");
                        }
                    }
                    foreach (var func in funcList) {
                        string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                        dst = func(source, control);
                        if (allowLogItem) {
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, source={2}, control={3}", funcName, dst, source, control));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, $"{funcName}, source={source}, control={control}");
                        }
                    } // funcList
                    if (allowLog) {
                        Console.WriteLine();
                    }
                } // j
            } // samples
        }
#endif // !REDUCE_MEMORY_USAGE

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
        public void YShuffleG4Test<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.YShuffleG4_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            bool allowLog = false;
            //bool allowLogItem = Scalars<T>.ExponentBits > 0;
            bool allowLogItem = false;
            Vector512<T>[] samples = {
                Vector512s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1),
                //Vector512s<T>.Demo,
                Vector512s<T>.Serial,
                //Vector512s<T>.SerialNegative
            };
            foreach (Vector512<T> source in samples) {
                if (allowLog) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("== Sample:\t{0}", source));
                }
                for (int j = 0; j <= 255; ++j) {
                    ShuffleControlG4 control = (ShuffleControlG4)j;
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("-- Control:\t{0}", control));
                    }
                    Vector512<T> expected = Vector512s.YShuffleG4((dynamic)source, control);
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                    }
                    Vector512<T> dst;
                    // Instances
                    foreach (IWVectorTraits512 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        dst = instance.YShuffleG4((dynamic)source, control);
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, source={2}, control={3}", instance.GetType().Name, dst, source, control));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, source={source}, control={control}");
                        }
                    }
                    if (allowLog) {
                        Console.WriteLine();
                    }
                } // j
            } // samples
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
        public void YShuffleG4_ConstTest<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.YShuffleG4_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector512s.GetSupportedMethodList<Func<Vector512<T>, ShuffleControlG4, Vector512<T>>>("YShuffleG4_Const_Imm");
            foreach (var func in funcList) {
                Console.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            // run.
            bool allowLog = false;
            //bool allowLogItem = Scalars<T>.ExponentBits > 0;
            bool allowLogItem = false;
            Vector512<T>[] samples = {
                Vector512s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1),
                //Vector512s<T>.Demo,
                Vector512s<T>.Serial,
                //Vector512s<T>.SerialNegative
            };
            //ShuffleControlG4 control = ShuffleControlG4.WZYX;
            foreach (Vector512<T> source in samples) {
                if (allowLog) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("== Sample:\t{0}", source));
                }
                for (int j = 0; j <= 255; ++j) {
                    ShuffleControlG4 control = (ShuffleControlG4)j;
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("-- Control:\t{0}", control));
                    }
                    Vector512<T> expected = Vector512s.YShuffleG4_Const((dynamic)source, control);
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                    }
                    Vector512<T> dst;
                    // Instances
                    foreach (IWVectorTraits512 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        dst = instance.YShuffleG4_Const((dynamic)source, control);
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, source={2}, control={3}", instance.GetType().Name, dst, source, control));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, source={source}, control={control}");
                        }
                    }
                    foreach (var func in funcList) {
                        string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                        dst = func(source, control);
                        if (allowLogItem) {
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, source={2}, control={3}", funcName, dst, source, control));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, $"{funcName}, source={source}, control={control}");
                        }
                    } // funcList
                    if (allowLog) {
                        Console.WriteLine();
                    }
                } // j
            } // samples
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
        public void YShuffleG4X2Test<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.YShuffleG4X2_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            bool allowLog = false;
            //bool allowLogItem = Scalars<T>.ExponentBits > 0;
            bool allowLogItem = false;
            Vector512<T>[] samples = {
                Vector512s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1),
                //Vector512s<T>.Demo,
                //Vector512s<T>.Serial,
                Vector512s<T>.SerialNegative
            };
            for (int i = 0; i < samples.Length; i += 2) {
                Vector512<T> source0 = samples[i];
                Vector512<T> source1 = samples[i + 1];
                if (allowLog) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("== Sample:\t{0}-{1}", source0, source1));
                }
                for (int j = 0; j <= 255; ++j) {
                    ShuffleControlG4 control = (ShuffleControlG4)j;
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("-- Control:\t{0}", control));
                    }
                    Vector512<T> expected0, expected1;
                    dynamic expected = Vector512s.YShuffleG4X2((dynamic)source0, (dynamic)source1, control);
                    expected0 = expected.Item1;
                    expected1 = expected.Item2;
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}-{1}", expected0, expected1));
                    }
                    // Instances
                    Vector512<T> dst0, dst1;
                    foreach (IWVectorTraits512 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
#pragma warning disable CS0618 // Type or member is obsolete
                        (dst0, dst1) = instance.YShuffleG4X2<T>(source0, source1, control);
#pragma warning restore CS0618 // Type or member is obsolete
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}-{2}, source0={3}, source1={4}, control={3}", instance.GetType().Name, dst0, dst1, source0, source1, control));
                        } else {
                            ClassicAssert.AreEqual(expected0, dst0, $"{instance.GetType().Name}, source0={source0}, control={control}");
                            ClassicAssert.AreEqual(expected1, dst1, $"{instance.GetType().Name}, source1={source1}, control={control}");
                        }
                    }
                    if (allowLog) {
                        Console.WriteLine();
                    }
                } // j
            } // samples
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
        public void YShuffleG4X2_ConstTest<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.YShuffleG4X2_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            bool allowLog = false;
            //bool allowLogItem = Scalars<T>.ExponentBits > 0;
            bool allowLogItem = false;
            Vector512<T>[] samples = {
                Vector512s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1),
                //Vector512s<T>.Demo,
                //Vector512s<T>.Serial,
                Vector512s<T>.SerialNegative
            };
            for (int i = 0; i < samples.Length; i += 2) {
                Vector512<T> source0 = samples[i];
                Vector512<T> source1 = samples[i + 1];
                if (allowLog) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("== Sample:\t{0}-{1}", source0, source1));
                }
                for (int j = 0; j <= 255; ++j) {
                    ShuffleControlG4 control = (ShuffleControlG4)j;
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("-- Control:\t{0}", control));
                    }
                    Vector512<T> expected0, expected1;
                    dynamic expected = Vector512s.YShuffleG4X2_Const((dynamic)source0, (dynamic)source1, control);
                    expected0 = expected.Item1;
                    expected1 = expected.Item2;
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}-{1}", expected0, expected1));
                    }
                    // Instances
                    Vector512<T> dst0, dst1;
                    foreach (IWVectorTraits512 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
#pragma warning disable CS0618 // Type or member is obsolete
                        (dst0, dst1) = instance.YShuffleG4X2_Const<T>(source0, source1, control);
#pragma warning restore CS0618 // Type or member is obsolete
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}-{2}, source0={3}, source1={4}, control={3}", instance.GetType().Name, dst0, dst1, source0, source1, control));
                        } else {
                            ClassicAssert.AreEqual(expected0, dst0, $"{instance.GetType().Name}, source0={source0}, control={control}");
                            ClassicAssert.AreEqual(expected1, dst1, $"{instance.GetType().Name}, source1={source1}, control={control}");
                        }
                    }
                    if (allowLog) {
                        Console.WriteLine();
                    }
                } // j
            } // samples
        }

        [TestCase((float)1, (int)7)]
        [TestCase((double)2, (long)9)]
        [TestCase((sbyte)3, (sbyte)3)]
        [TestCase((byte)4, (byte)4)]
        [TestCase((short)5, (short)5)]
        [TestCase((ushort)6, (ushort)6)]
        [TestCase((int)7, (int)7)]
        [TestCase((uint)8, (uint)8)]
        [TestCase((long)9, (long)9)]
        [TestCase((ulong)10, (ulong)10)]
        public void YShuffleInsertTest<T, TIdx>(T src, TIdx srcIndex) where T : struct where TIdx : struct {
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.YShuffleInsert_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            bool allowLog = true;
            //bool allowLogItem = Scalars<T>.ExponentBits > 0;
            bool allowLogItem = false;
            Vector512<T> back = Vector512s.Create(src);
            Vector512<T>[] samples = {
                //Vector512s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1),
                //Vector512s<T>.Demo,
                Vector512s<T>.Serial,
                //Vector512s<T>.SerialNegative
            };
            Vector512<TIdx>[] indicesList = {
                Vector512s<TIdx>.Serial,
                Vector512s<TIdx>.SerialDesc,
                Vector512s.CreateByDoubleLoop<TIdx>(0, 2),
                Vector512s.CreateByDoubleLoop<TIdx>(1, 2),
                Vector512s.CreateByDoubleLoop<TIdx>(Scalars.GetDoubleFrom(src), 1),
            };
            if (allowLog) {
                Console.WriteLine(VectorTextUtil.Format("Back:\t{0}", back));
            }
            foreach (Vector512<T> vector in samples) {
                if (allowLog) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("== Sample:\t{0}", vector));
                }
                foreach (Vector512<TIdx> indices in indicesList) {
                    Vector512<T> expected = Vector512s.YShuffleInsert((dynamic)back, (dynamic)vector, (dynamic)indices);
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("Indices:\t{0}", indices));
                        Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                    }
                    // Static: Args and Core
                    Vector512<TIdx> args0, args1, args2;
#pragma warning disable CS0618 // Type or member is obsolete
                    Vector512s.YShuffleInsert_Args<TIdx>(indices, out args0, out args1, out args2);
#pragma warning restore CS0618 // Type or member is obsolete
                    Vector512<T> dst = Vector512s.YShuffleInsert_Core((dynamic)back, (dynamic)vector, (dynamic)args0, (dynamic)args1, (dynamic)args2);
                    if (allowLogItem) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core0", dst, vector, indices));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, "_Core0, vector={vector}, indices={indices}");
                    }
                    // Static: Args and Core with ValueTuple
                    var args = Vector512s.YShuffleInsert_Args((dynamic)indices);
                    dst = Vector512s.YShuffleInsert_Core((dynamic)back, (dynamic)vector, (dynamic)args);
                    if (allowLogItem) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core", dst, vector, indices));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, "_Core, vector={vector}, indices={indices}");
                    }
                    // Instances
                    foreach (IWVectorTraits512 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        dst = instance.YShuffleInsert((dynamic)back, (dynamic)vector, (dynamic)indices);
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", instance.GetType().Name, dst, vector, indices));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, vector={vector}, indices={indices}");
                        }
                        // Instances: Args and Core
#pragma warning disable CS0618 // Type or member is obsolete
                        instance.YShuffleInsert_Args<TIdx>(indices, out args0, out args1, out args2);
#pragma warning restore CS0618 // Type or member is obsolete
                        dst = instance.YShuffleInsert_Core((dynamic)back, (dynamic)vector, (dynamic)args0, (dynamic)args1, (dynamic)args2);
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core0 of " + instance.GetType().Name, dst, vector, indices));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, "_Core0 of {instance.GetType().Name}, vector={vector}, indices={indices}");
                        }
                        // Instances: Args and Core with ValueTuple
#pragma warning disable CS0618 // Type or member is obsolete
                        var argsI = instance.YShuffleInsert_Args<TIdx>(indices);
                        // dst = instance.YShuffleInsert_Core((dynamic)vector, (dynamic)argsI); // CS1973	'IWVectorTraits512' has no applicable method named 'YShuffleInsert_Core' but appears to have an extension method by that name. Extension methods cannot be dynamically dispatched. Consider casting the dynamic arguments or calling the extension method without the extension method syntax.
                        dst = instance.YShuffleInsert_Core<T, TIdx>(back, vector, argsI);
#pragma warning restore CS0618 // Type or member is obsolete
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core of " + instance.GetType().Name, dst, vector, indices));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, "_Core of {instance.GetType().Name}, vector={vector}, indices={indices}");
                        }
                    }
                    if (allowLog) {
                        Console.WriteLine();
                    }
                }
            }
        }

        [TestCase((float)1, (int)7)]
        [TestCase((double)2, (long)9)]
        [TestCase((sbyte)3, (sbyte)3)]
        [TestCase((byte)4, (byte)4)]
        [TestCase((short)5, (short)5)]
        [TestCase((ushort)6, (ushort)6)]
        [TestCase((int)7, (int)7)]
        [TestCase((uint)8, (uint)8)]
        [TestCase((long)9, (long)9)]
        [TestCase((ulong)10, (ulong)10)]
        public void YShuffleKernelTest<T, TIdx>(T src, TIdx srcIndex) where T : struct where TIdx : struct {
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.YShuffleKernel_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            bool allowLog = true;
            //bool allowLogItem = Scalars<T>.ExponentBits > 0;
            bool allowLogItem = false;
            Vector512<T>[] samples = {
                //Vector512s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1),
                //Vector512s<T>.Demo,
                Vector512s<T>.Serial,
                //Vector512s<T>.SerialNegative
            };
            Vector512<TIdx>[] indicesList = {
                Vector512s<TIdx>.Serial,
                Vector512s<TIdx>.SerialDesc,
                Vector512s.CreateByDoubleLoop<TIdx>(0, 2),
                Vector512s.CreateByDoubleLoop<TIdx>(1, 2),
                Vector512s.CreateByDoubleLoop<TIdx>(Scalars.GetDoubleFrom(src), 1),
            };
            foreach (Vector512<T> vector in samples) {
                if (allowLog) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("== Sample:\t{0}", vector));
                }
                foreach (Vector512<TIdx> indicesFor in indicesList) {
                    //Vector512<TIdx> indices = indicesFor;
                    Vector512<TIdx> indices = Vector512s.BitwiseAnd(indicesFor, Vector512s<TIdx>.IndexMask);
#if NET7_0_OR_GREATER
                    Vector512<T> expected = Vector512.Shuffle((dynamic)vector, (dynamic)indices);
#else
                    Vector512<T> expected = Vector512s.YShuffleKernel((dynamic)vector, (dynamic)indices);
#endif // NET7_0_OR_GREATER
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("Indices:\t{0}", indices));
                        Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                    }
                    // Static: Args and Core
                    Vector512<TIdx> args0, args1;
#pragma warning disable CS0618 // Type or member is obsolete
                    Vector512s.YShuffleKernel_Args<TIdx>(indices, out args0, out args1);
#pragma warning restore CS0618 // Type or member is obsolete
                    Vector512<T> dst = Vector512s.YShuffleKernel_Core((dynamic)vector, (dynamic)args0, (dynamic)args1);
                    if (allowLogItem) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core0", dst, vector, indices));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, "_Core0, vector={vector}, indices={indices}");
                    }
                    // Static: Args and Core with ValueTuple
                    var args = Vector512s.YShuffleKernel_Args((dynamic)indices);
                    dst = Vector512s.YShuffleKernel_Core((dynamic)vector, (dynamic)args);
                    if (allowLogItem) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core", dst, vector, indices));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, "_Core, vector={vector}, indices={indices}");
                    }
                    // Static: ArgsX and Core
#if ALLOW_VECTOR_TUPLES
#pragma warning disable CS0618 // Type or member is obsolete
                    Vector512X2<TIdx> argsX = Vector512s.YShuffleKernel_ArgsX((dynamic)indices);
                    dst = Vector512s.YShuffleKernel_Core((dynamic)vector, (dynamic)argsX);
#pragma warning restore CS0618 // Type or member is obsolete
                    if (allowLogItem) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core0", dst, vector, indices));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, "_CoreX, vector={vector}, indices={indices}");
                    }
#endif // ALLOW_VECTOR_TUPLES
                    // Instances
                    foreach (IWVectorTraits512 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        dst = instance.YShuffleKernel((dynamic)vector, (dynamic)indices);
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", instance.GetType().Name, dst, vector, indices));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, vector={vector}, indices={indices}");
                        }
                        // Instances: Args and Core
#pragma warning disable CS0618 // Type or member is obsolete
                        instance.YShuffleKernel_Args<TIdx>(indices, out args0, out args1);
#pragma warning restore CS0618 // Type or member is obsolete
                        dst = instance.YShuffleKernel_Core((dynamic)vector, (dynamic)args0, (dynamic)args1);
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core0 of " + instance.GetType().Name, dst, vector, indices));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, "_Core0 of {instance.GetType().Name}, vector={vector}, indices={indices}");
                        }
                        // Instances: Args and Core with ValueTuple
#pragma warning disable CS0618 // Type or member is obsolete
                        var argsI = instance.YShuffleKernel_Args<TIdx>(indices);
                        // dst = instance.YShuffleKernel_Core((dynamic)vector, (dynamic)argsI); // CS1973	'IWVectorTraits512' has no applicable method named 'YShuffleKernel_Core' but appears to have an extension method by that name. Extension methods cannot be dynamically dispatched. Consider casting the dynamic arguments or calling the extension method without the extension method syntax.
                        dst = instance.YShuffleKernel_Core<T, TIdx>(vector, argsI);
#pragma warning restore CS0618 // Type or member is obsolete
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core of " + instance.GetType().Name, dst, vector, indices));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, "_Core of {instance.GetType().Name}, vector={vector}, indices={indices}");
                        }
                    }
                    if (allowLog) {
                        Console.WriteLine();
                    }
                }
            }
        }

        [TestCase((float)1, (int)7)]
        [TestCase((double)2, (long)9)]
        [TestCase((sbyte)3, (sbyte)3)]
        [TestCase((byte)4, (byte)4)]
        [TestCase((short)5, (short)5)]
        [TestCase((ushort)6, (ushort)6)]
        [TestCase((int)7, (int)7)]
        [TestCase((uint)8, (uint)8)]
        [TestCase((long)9, (long)9)]
        [TestCase((ulong)10, (ulong)10)]
        public void YShuffleX2Test<T, TIdx>(T src, TIdx srcIndex) where T : struct where TIdx : struct {
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.YShuffleX2_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            bool allowLog = true;
            //bool allowLogItem = Scalars<T>.ExponentBits > 0;
            bool allowLogItem = false;
            Vector512<T>[] samples = {
                //Vector512s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1),
                //Vector512s<T>.Demo,
                Vector512s<T>.Serial,
                //Vector512s<T>.SerialNegative
            };
            Vector512<TIdx>[] indicesList = {
                Vector512s<TIdx>.Serial,
                Vector512s<TIdx>.SerialDesc,
                Vector512s.CreateByDoubleLoop<TIdx>(0, 2),
                Vector512s.CreateByDoubleLoop<TIdx>(1, 2),
                Vector512s.CreateByDoubleLoop<TIdx>(Scalars.GetDoubleFrom(src), 2),
                Vector512s.CreateByDoubleLoop<TIdx>(Scalars.GetDoubleFrom(src), 3),
            };
            foreach (Vector512<T> vector in samples) {
                Vector512<T> vector1 = Vector512s<T>.SerialNegative;
                if (allowLog) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("== Sample:\t{0}", vector));
                }
                foreach (Vector512<TIdx> indices in indicesList) {
                    Vector512<T> expected = Vector512s.YShuffleX2((dynamic)vector, (dynamic)vector1, (dynamic)indices);
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("Indices:\t{0}", indices));
                        Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                    }
                    // Static: Args and Core
                    Vector512<TIdx> args0, args1, args2, args3, args4;
#pragma warning disable CS0618 // Type or member is obsolete
                    Vector512s.YShuffleX2_Args<TIdx>(indices, out args0, out args1, out args2, out args3, out args4);
#pragma warning restore CS0618 // Type or member is obsolete
                    Vector512<T> dst = Vector512s.YShuffleX2_Core((dynamic)vector, (dynamic)vector1, (dynamic)args0, (dynamic)args1, (dynamic)args2, (dynamic)args3, (dynamic)args4);
                    if (allowLogItem) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core0", dst, vector, indices));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"_Core0, vector={vector}, indices={indices}");
                    }
                    // Static: Args and Core with ValueTuple
                    var args = Vector512s.YShuffleX2_Args((dynamic)indices);
                    dst = Vector512s.YShuffleX2_Core((dynamic)vector, (dynamic)vector1, (dynamic)args);
                    if (allowLogItem) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core", dst, vector, indices));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"_Core, vector={vector}, indices={indices}");
                    }
                    // Instances
                    foreach (IWVectorTraits512 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        dst = instance.YShuffleX2((dynamic)vector, (dynamic)vector1, (dynamic)indices);
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", instance.GetType().Name, dst, vector, indices));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, vector={vector}, indices={indices}");
                        }
                        // Instances: Args and Core
#pragma warning disable CS0618 // Type or member is obsolete
                        instance.YShuffleX2_Args<TIdx>(indices, out args0, out args1, out args2, out args3, out args4);
#pragma warning restore CS0618 // Type or member is obsolete
                        dst = instance.YShuffleX2_Core((dynamic)vector, (dynamic)vector1, (dynamic)args0, (dynamic)args1, (dynamic)args2, (dynamic)args3, (dynamic)args4);
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core0 of " + instance.GetType().Name, dst, vector, indices));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, "_Core0 of {instance.GetType().Name}, vector={vector}, indices={indices}");
                        }
                        // Instances: Args and Core with ValueTuple
#pragma warning disable CS0618 // Type or member is obsolete
                        var argsI = instance.YShuffleX2_Args<TIdx>(indices);
                        dst = instance.YShuffleX2_Core<T, TIdx>(vector, vector1, argsI);
#pragma warning restore CS0618 // Type or member is obsolete
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core of " + instance.GetType().Name, dst, vector, indices));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, "_Core of {instance.GetType().Name}, vector={vector}, indices={indices}");
                        }
                    }
                    if (allowLog) {
                        Console.WriteLine();
                    }
                }
            }
        }

        [TestCase((float)1, (int)7)]
        [TestCase((double)2, (long)9)]
        [TestCase((sbyte)3, (sbyte)3)]
        [TestCase((byte)4, (byte)4)]
        [TestCase((short)5, (short)5)]
        [TestCase((ushort)6, (ushort)6)]
        [TestCase((int)7, (int)7)]
        [TestCase((uint)8, (uint)8)]
        [TestCase((long)9, (long)9)]
        [TestCase((ulong)10, (ulong)10)]
        public void YShuffleX2InsertTest<T, TIdx>(T src, TIdx srcIndex) where T : struct where TIdx : struct {
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.YShuffleX2Insert_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            bool allowLog = true;
            //bool allowLogItem = Scalars<T>.ExponentBits > 0;
            bool allowLogItem = false;
            Vector512<T> back = Vector512s.Create(src);
            Vector512<T>[] samples = {
                //Vector512s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1),
                //Vector512s<T>.Demo,
                Vector512s<T>.Serial,
                //Vector512s<T>.SerialNegative
            };
            Vector512<TIdx>[] indicesList = {
                Vector512s<TIdx>.Serial,
                Vector512s<TIdx>.SerialDesc,
                Vector512s.CreateByDoubleLoop<TIdx>(0, 2),
                Vector512s.CreateByDoubleLoop<TIdx>(1, 2),
                Vector512s.CreateByDoubleLoop<TIdx>(Scalars.GetDoubleFrom(src), 1),
            };
            if (allowLog) {
                Console.WriteLine(VectorTextUtil.Format("Back:\t{0}", back));
            }
            foreach (Vector512<T> vector in samples) {
                Vector512<T> vector1 = Vector512s<T>.SerialNegative;
                if (allowLog) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("== Sample:\t{0}", vector));
                }
                foreach (Vector512<TIdx> indices in indicesList) {
                    Vector512<T> expected = Vector512s.YShuffleX2Insert((dynamic)back, (dynamic)vector, (dynamic)vector1, (dynamic)indices);
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("Indices:\t{0}", indices));
                        Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                    }
                    // Static: Args and Core
                    Vector512<TIdx> args0, args1, args2, args3, args4;
#pragma warning disable CS0618 // Type or member is obsolete
                    Vector512s.YShuffleX2Insert_Args<TIdx>(indices, out args0, out args1, out args2, out args3, out args4);
#pragma warning restore CS0618 // Type or member is obsolete
                    Vector512<T> dst = Vector512s.YShuffleX2Insert_Core((dynamic)back, (dynamic)vector, (dynamic)vector1, (dynamic)args0, (dynamic)args1, (dynamic)args2, (dynamic)args3, (dynamic)args4);
                    if (allowLogItem) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core0", dst, vector, indices));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"_Core0, vector={vector}, indices={indices}");
                    }
                    // Static: Args and Core with ValueTuple
                    var args = Vector512s.YShuffleX2Insert_Args((dynamic)indices);
                    dst = Vector512s.YShuffleX2Insert_Core((dynamic)back, (dynamic)vector, (dynamic)vector1, (dynamic)args);
                    if (allowLogItem) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core", dst, vector, indices));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"_Core, vector={vector}, indices={indices}");
                    }
                    // Instances
                    foreach (IWVectorTraits512 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        dst = instance.YShuffleX2Insert((dynamic)back, (dynamic)vector, (dynamic)vector1, (dynamic)indices);
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", instance.GetType().Name, dst, vector, indices));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, vector={vector}, indices={indices}");
                        }
                        // Instances: Args and Core
#pragma warning disable CS0618 // Type or member is obsolete
                        instance.YShuffleX2Insert_Args<TIdx>(indices, out args0, out args1, out args2, out args3, out args4);
#pragma warning restore CS0618 // Type or member is obsolete
                        dst = instance.YShuffleX2Insert_Core((dynamic)back, (dynamic)vector, (dynamic)vector1, (dynamic)args0, (dynamic)args1, (dynamic)args2, (dynamic)args3, (dynamic)args4);
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core0 of " + instance.GetType().Name, dst, vector, indices));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, "_Core0 of {instance.GetType().Name}, vector={vector}, indices={indices}");
                        }
                        // Instances: Args and Core with ValueTuple
#pragma warning disable CS0618 // Type or member is obsolete
                        var argsI = instance.YShuffleX2Insert_Args<TIdx>(indices);
                        // dst = instance.YShuffleX2Insert_Core((dynamic)vector, (dynamic)argsI); // CS1973	'IWVectorTraits512' has no applicable method named 'YShuffleX2Insert_Core' but appears to have an extension method by that name. Extension methods cannot be dynamically dispatched. Consider casting the dynamic arguments or calling the extension method without the extension method syntax.
                        dst = instance.YShuffleX2Insert_Core<T, TIdx>(back, vector, vector1, argsI);
#pragma warning restore CS0618 // Type or member is obsolete
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core of " + instance.GetType().Name, dst, vector, indices));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, "_Core of {instance.GetType().Name}, vector={vector}, indices={indices}");
                        }
                    }
                    if (allowLog) {
                        Console.WriteLine();
                    }
                }
            }
        }

        [TestCase((float)1, (int)7)]
        [TestCase((double)2, (long)9)]
        [TestCase((sbyte)3, (sbyte)3)]
        [TestCase((byte)4, (byte)4)]
        [TestCase((short)5, (short)5)]
        [TestCase((ushort)6, (ushort)6)]
        [TestCase((int)7, (int)7)]
        [TestCase((uint)8, (uint)8)]
        [TestCase((long)9, (long)9)]
        [TestCase((ulong)10, (ulong)10)]
        public void YShuffleX2KernelTest<T, TIdx>(T src, TIdx srcIndex) where T : struct where TIdx : struct {
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.YShuffleX2Kernel_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            bool allowLog = true;
            //bool allowLogItem = Scalars<T>.ExponentBits > 0;
            bool allowLogItem = false;
            Vector512<T>[] samples = {
                //Vector512s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1),
                //Vector512s<T>.Demo,
                Vector512s<T>.Serial,
                //Vector512s<T>.SerialNegative
            };
            Vector512<TIdx>[] indicesList = {
                Vector512s<TIdx>.Serial,
                Vector512s<TIdx>.SerialDesc,
                Vector512s.CreateByDoubleLoop<TIdx>(0, 2),
                Vector512s.CreateByDoubleLoop<TIdx>(1, 2),
                Vector512s.CreateByDoubleLoop<TIdx>(Scalars.GetDoubleFrom(src), 1),
            };
            foreach (Vector512<T> vector in samples) {
                Vector512<T> vector1 = Vector512s<T>.SerialNegative;
                if (allowLog) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("== Sample:\t{0}, {1}", vector, vector1));
                }
                foreach (Vector512<TIdx> indicesFor in indicesList) {
                    //Vector512<TIdx> indices = indicesFor;
                    Vector512<TIdx> indices = Vector512s.BitwiseAnd(indicesFor, Vector512s<TIdx>.IndexX2Mask);
                    Vector512<T> expected = Vector512s.YShuffleX2Kernel((dynamic)vector, (dynamic)vector1, (dynamic)indices);
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("Indices:\t{0}", indices));
                        Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                    }
                    // Static: Args and Core
                    Vector512<TIdx> args0, args1, args2, args3;
#pragma warning disable CS0618 // Type or member is obsolete
                    Vector512s.YShuffleX2Kernel_Args<TIdx>(indices, out args0, out args1, out args2, out args3);
#pragma warning restore CS0618 // Type or member is obsolete
                    Vector512<T> dst = Vector512s.YShuffleX2Kernel_Core((dynamic)vector, (dynamic)vector1, (dynamic)args0, (dynamic)args1, (dynamic)args2, (dynamic)args3);
                    if (allowLogItem) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core0", dst, vector, indices));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"_Core0, vector={vector}, indices={indices}");
                    }
                    // Static: Args and Core with ValueTuple
                    var args = Vector512s.YShuffleX2Kernel_Args((dynamic)indices);
                    dst = Vector512s.YShuffleX2Kernel_Core((dynamic)vector, (dynamic)vector1, (dynamic)args);
                    if (allowLogItem) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core", dst, vector, indices));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"_Core, vector={vector}, indices={indices}");
                    }
                    // Instances
                    foreach (IWVectorTraits512 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        dst = instance.YShuffleX2Kernel((dynamic)vector, (dynamic)vector1, (dynamic)indices);
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", instance.GetType().Name, dst, vector, indices));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, vector={vector}, indices={indices}");
                        }
                        // Instances: Args and Core
#pragma warning disable CS0618 // Type or member is obsolete
                        instance.YShuffleX2Kernel_Args<TIdx>(indices, out args0, out args1, out args2, out args3);
#pragma warning restore CS0618 // Type or member is obsolete
                        dst = instance.YShuffleX2Kernel_Core((dynamic)vector, (dynamic)vector1, (dynamic)args0, (dynamic)args1, (dynamic)args2, (dynamic)args3);
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core0 of " + instance.GetType().Name, dst, vector, indices));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, "_Core0 of {instance.GetType().Name}, vector={vector}, indices={indices}");
                        }
                        // Instances: Args and Core with ValueTuple
#pragma warning disable CS0618 // Type or member is obsolete
                        var argsI = instance.YShuffleX2Kernel_Args<TIdx>(indices);
                        // dst = instance.YShuffleX2Kernel_Core((dynamic)vector, (dynamic)argsI); // CS1973	'IWVectorTraits512' has no applicable method named 'YShuffleX2Kernel_Core' but appears to have an extension method by that name. Extension methods cannot be dynamically dispatched. Consider casting the dynamic arguments or calling the extension method without the extension method syntax.
                        dst = instance.YShuffleX2Kernel_Core<T, TIdx>(vector, vector1, argsI);
#pragma warning restore CS0618 // Type or member is obsolete
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core of " + instance.GetType().Name, dst, vector, indices));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, "_Core of {instance.GetType().Name}, vector={vector}, indices={indices}");
                        }
                    }
                    if (allowLog) {
                        Console.WriteLine();
                    }
                }
            }
        }

        [TestCase((float)1, (int)7)]
        [TestCase((double)2, (long)9)]
        [TestCase((sbyte)3, (sbyte)3)]
        [TestCase((byte)4, (byte)4)]
        [TestCase((short)5, (short)5)]
        [TestCase((ushort)6, (ushort)6)]
        [TestCase((int)7, (int)7)]
        [TestCase((uint)8, (uint)8)]
        [TestCase((long)9, (long)9)]
        [TestCase((ulong)10, (ulong)10)]
        public void YShuffleX3Test<T, TIdx>(T src, TIdx srcIndex) where T : struct where TIdx : struct {
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.YShuffleX3_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            bool allowLog = true;
            //bool allowLogItem = Scalars<T>.ExponentBits > 0;
            bool allowLogItem = false;
            Vector512<T>[] samples = {
                //Vector512s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1),
                //Vector512s<T>.Demo,
                Vector512s<T>.Serial,
                //Vector512s<T>.SerialNegative
            };
            Vector512<TIdx>[] indicesList = {
                Vector512s<TIdx>.Serial,
                Vector512s<TIdx>.SerialDesc,
                Vector512s.CreateByDoubleLoop<TIdx>(0, 3),
                Vector512s.CreateByDoubleLoop<TIdx>(1, 3),
                Vector512s.CreateByDoubleLoop<TIdx>(Scalars.GetDoubleFrom(src), 3),
                Vector512s.CreateByDoubleLoop<TIdx>(Scalars.GetDoubleFrom(src) + Vector512<TIdx>.Count, 3),
                Vector512s.CreateByDoubleLoop<TIdx>(Scalars.GetDoubleFrom(src) + Vector512<TIdx>.Count*2, 3),
            };
            foreach (Vector512<T> vector in samples) {
                Vector512<T> vector1 = Vector512s<T>.SerialNegative;
                Vector512<T> vector2 = Vector512s.CreateByDoubleLoop<T>(-Vector512<T>.Count, -1);
                if (allowLog) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("== Sample:\t{0}", vector));
                }
                foreach (Vector512<TIdx> indices in indicesList) {
                    Vector512<T> expected = Vector512s.YShuffleX3((dynamic)vector, (dynamic)vector1, (dynamic)vector2, (dynamic)indices);
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("Indices:\t{0}", indices));
                        Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                    }
                    // Static: Args and Core
                    Vector512<TIdx> args0, args1, args2, args3, args4;
#pragma warning disable CS0618 // Type or member is obsolete
                    Vector512s.YShuffleX3_Args<TIdx>(indices, out args0, out args1, out args2, out args3, out args4);
#pragma warning restore CS0618 // Type or member is obsolete
                    Vector512<T> dst = Vector512s.YShuffleX3_Core((dynamic)vector, (dynamic)vector1, (dynamic)vector2, (dynamic)args0, (dynamic)args1, (dynamic)args2, (dynamic)args3, (dynamic)args4);
                    if (allowLogItem) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core0", dst, vector, indices));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"_Core0, vector={vector}, indices={indices}");
                    }
                    // Static: Args and Core with ValueTuple
                    var args = Vector512s.YShuffleX3_Args((dynamic)indices);
                    dst = Vector512s.YShuffleX3_Core((dynamic)vector, (dynamic)vector1, (dynamic)vector2, (dynamic)args);
                    if (allowLogItem) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core", dst, vector, indices));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"_Core, vector={vector}, indices={indices}");
                    }
                    // Instances
                    foreach (IWVectorTraits512 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        dst = instance.YShuffleX3((dynamic)vector, (dynamic)vector1, (dynamic)vector2, (dynamic)indices);
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", instance.GetType().Name, dst, vector, indices));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, vector={vector}, indices={indices}");
                        }
                        // Instances: Args and Core
#pragma warning disable CS0618 // Type or member is obsolete
                        instance.YShuffleX3_Args<TIdx>(indices, out args0, out args1, out args2, out args3, out args4);
#pragma warning restore CS0618 // Type or member is obsolete
                        dst = instance.YShuffleX3_Core((dynamic)vector, (dynamic)vector1, (dynamic)vector2, (dynamic)args0, (dynamic)args1, (dynamic)args2, (dynamic)args3, (dynamic)args4);
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core0 of " + instance.GetType().Name, dst, vector, indices));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, "_Core0 of {instance.GetType().Name}, vector={vector}, indices={indices}");
                        }
                        // Instances: Args and Core with ValueTuple
#pragma warning disable CS0618 // Type or member is obsolete
                        var argsI = instance.YShuffleX3_Args<TIdx>(indices);
                        dst = instance.YShuffleX3_Core<T, TIdx>(vector, vector1, vector2, argsI);
#pragma warning restore CS0618 // Type or member is obsolete
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core of " + instance.GetType().Name, dst, vector, indices));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, "_Core of {instance.GetType().Name}, vector={vector}, indices={indices}");
                        }
                    }
                    if (allowLog) {
                        Console.WriteLine();
                    }
                }
            }
        }

        [TestCase((float)1, (int)7)]
        [TestCase((double)2, (long)9)]
        [TestCase((sbyte)3, (sbyte)3)]
        [TestCase((byte)4, (byte)4)]
        [TestCase((short)5, (short)5)]
        [TestCase((ushort)6, (ushort)6)]
        [TestCase((int)7, (int)7)]
        [TestCase((uint)8, (uint)8)]
        [TestCase((long)9, (long)9)]
        [TestCase((ulong)10, (ulong)10)]
        public void YShuffleX3InsertTest<T, TIdx>(T src, TIdx srcIndex) where T : struct where TIdx : struct {
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.YShuffleX3Insert_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            bool allowLog = true;
            //bool allowLogItem = Scalars<T>.ExponentBits > 0;
            bool allowLogItem = false;
            Vector512<T> back = Vector512s.Create(src);
            Vector512<T>[] samples = {
                //Vector512s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1),
                //Vector512s<T>.Demo,
                Vector512s<T>.Serial,
                //Vector512s<T>.SerialNegative
            };
            Vector512<TIdx>[] indicesList = {
                Vector512s<TIdx>.Serial,
                Vector512s<TIdx>.SerialDesc,
                Vector512s.CreateByDoubleLoop<TIdx>(0, 3),
                Vector512s.CreateByDoubleLoop<TIdx>(1, 3),
                Vector512s.CreateByDoubleLoop<TIdx>(Scalars.GetDoubleFrom(src), 3),
                Vector512s.CreateByDoubleLoop<TIdx>(Scalars.GetDoubleFrom(src) + Vector512<TIdx>.Count, 3),
                Vector512s.CreateByDoubleLoop<TIdx>(Scalars.GetDoubleFrom(src) + Vector512<TIdx>.Count*2, 3),
            };
            if (allowLog) {
                Console.WriteLine(VectorTextUtil.Format("Back:\t{0}", back));
            }
            foreach (Vector512<T> vector in samples) {
                Vector512<T> vector1 = Vector512s<T>.SerialNegative;
                Vector512<T> vector2 = Vector512s.CreateByDoubleLoop<T>(-Vector512<T>.Count, -1);
                if (allowLog) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("== Sample:\t{0}", vector));
                }
                foreach (Vector512<TIdx> indices in indicesList) {
                    Vector512<T> expected = Vector512s.YShuffleX3Insert((dynamic)back, (dynamic)vector, (dynamic)vector1, (dynamic)vector2, (dynamic)indices);
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("Indices:\t{0}", indices));
                        Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                    }
                    // Static: Args and Core
                    Vector512<TIdx> args0, args1, args2, args3, args4;
#pragma warning disable CS0618 // Type or member is obsolete
                    Vector512s.YShuffleX3Insert_Args<TIdx>(indices, out args0, out args1, out args2, out args3, out args4);
#pragma warning restore CS0618 // Type or member is obsolete
                    Vector512<T> dst = Vector512s.YShuffleX3Insert_Core((dynamic)back, (dynamic)vector, (dynamic)vector1, (dynamic)vector2, (dynamic)args0, (dynamic)args1, (dynamic)args2, (dynamic)args3, (dynamic)args4);
                    if (allowLogItem) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core0", dst, vector, indices));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"_Core0, vector={vector}, indices={indices}");
                    }
                    // Static: Args and Core with ValueTuple
                    var args = Vector512s.YShuffleX3Insert_Args((dynamic)indices);
                    dst = Vector512s.YShuffleX3Insert_Core((dynamic)back, (dynamic)vector, (dynamic)vector1, (dynamic)vector2, (dynamic)args);
                    if (allowLogItem) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core", dst, vector, indices));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"_Core, vector={vector}, indices={indices}");
                    }
                    // Instances
                    foreach (IWVectorTraits512 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        dst = instance.YShuffleX3Insert((dynamic)back, (dynamic)vector, (dynamic)vector1, (dynamic)vector2, (dynamic)indices);
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", instance.GetType().Name, dst, vector, indices));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, vector={vector}, indices={indices}");
                        }
                        // Instances: Args and Core
#pragma warning disable CS0618 // Type or member is obsolete
                        instance.YShuffleX3Insert_Args<TIdx>(indices, out args0, out args1, out args2, out args3, out args4);
#pragma warning restore CS0618 // Type or member is obsolete
                        dst = instance.YShuffleX3Insert_Core((dynamic)back, (dynamic)vector, (dynamic)vector1, (dynamic)vector2, (dynamic)args0, (dynamic)args1, (dynamic)args2, (dynamic)args3, (dynamic)args4);
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core0 of " + instance.GetType().Name, dst, vector, indices));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, "_Core0 of {instance.GetType().Name}, vector={vector}, indices={indices}");
                        }
                        // Instances: Args and Core with ValueTuple
#pragma warning disable CS0618 // Type or member is obsolete
                        var argsI = instance.YShuffleX3Insert_Args<TIdx>(indices);
                        // dst = instance.YShuffleX3Insert_Core((dynamic)vector, (dynamic)argsI); // CS1973	'IWVectorTraits512' has no applicable method named 'YShuffleX3Insert_Core' but appears to have an extension method by that name. Extension methods cannot be dynamically dispatched. Consider casting the dynamic arguments or calling the extension method without the extension method syntax.
                        dst = instance.YShuffleX3Insert_Core<T, TIdx>(back, vector, vector1, vector2, argsI);
#pragma warning restore CS0618 // Type or member is obsolete
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core of " + instance.GetType().Name, dst, vector, indices));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, "_Core of {instance.GetType().Name}, vector={vector}, indices={indices}");
                        }
                    }
                    if (allowLog) {
                        Console.WriteLine();
                    }
                }
            }
        }

        [TestCase((float)1, (int)7)]
        [TestCase((double)2, (long)9)]
        [TestCase((sbyte)3, (sbyte)3)]
        [TestCase((byte)4, (byte)4)]
        [TestCase((short)5, (short)5)]
        [TestCase((ushort)6, (ushort)6)]
        [TestCase((int)7, (int)7)]
        [TestCase((uint)8, (uint)8)]
        [TestCase((long)9, (long)9)]
        [TestCase((ulong)10, (ulong)10)]
        public void YShuffleX3KernelTest<T, TIdx>(T src, TIdx srcIndex) where T : struct where TIdx : struct {
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.YShuffleX3Kernel_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            bool allowLog = true;
            //bool allowLogItem = Scalars<T>.ExponentBits > 0;
            bool allowLogItem = false;
            Vector512<T>[] samples = {
                //Vector512s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1),
                //Vector512s<T>.Demo,
                Vector512s<T>.Serial,
                //Vector512s<T>.SerialNegative
            };
            Vector512<TIdx>[] indicesList = {
                Vector512s<TIdx>.Serial,
                Vector512s<TIdx>.SerialDesc,
                Vector512s.CreateByDoubleLoop<TIdx>(0, 3),
                Vector512s.CreateByDoubleLoop<TIdx>(1, 3),
                Vector512s.CreateByDoubleLoop<TIdx>(Scalars.GetDoubleFrom(src), 3),
                Vector512s.CreateByDoubleLoop<TIdx>(Scalars.GetDoubleFrom(src) + Vector512<TIdx>.Count, 3),
                Vector512s.CreateByDoubleLoop<TIdx>(Scalars.GetDoubleFrom(src) + Vector512<TIdx>.Count*2, 3),
            };
            foreach (Vector512<T> vector in samples) {
                Vector512<T> vector1 = Vector512s<T>.SerialNegative;
                Vector512<T> vector2 = Vector512s.CreateByDoubleLoop<T>(-Vector512<T>.Count, -1);
                if (allowLog) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("== Sample:\t{0}, {1}", vector, vector1));
                }
                foreach (Vector512<TIdx> indicesFor in indicesList) {
                    //Vector512<TIdx> indices = indicesFor;
                    Vector512<TIdx> indices = Vector512s.BitwiseAnd(indicesFor, Vector512s<TIdx>.IndexX4Mask);
                    Vector512<TIdx> indicesMask = Vector512s.GreaterThan_Unsigned((dynamic)Vector512s.CreateByDouble<TIdx>(Vector512<TIdx>.Count * 3), (dynamic)indices);
                    indices = Vector512s.BitwiseAnd(indices, indicesMask);
                    Vector512<T> expected = Vector512s.YShuffleX3Kernel((dynamic)vector, (dynamic)vector1, (dynamic)vector2, (dynamic)indices);
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("Indices:\t{0}", indices));
                        Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                    }
                    // Static: Args and Core
                    Vector512<TIdx> args0, args1, args2, args3;
#pragma warning disable CS0618 // Type or member is obsolete
                    Vector512s.YShuffleX3Kernel_Args<TIdx>(indices, out args0, out args1, out args2, out args3);
#pragma warning restore CS0618 // Type or member is obsolete
                    Vector512<T> dst = Vector512s.YShuffleX3Kernel_Core((dynamic)vector, (dynamic)vector1, (dynamic)vector2, (dynamic)args0, (dynamic)args1, (dynamic)args2, (dynamic)args3);
                    if (allowLogItem) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core0", dst, vector, indices));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"_Core0, vector={vector}, indices={indices}");
                    }
                    // Static: Args and Core with ValueTuple
                    var args = Vector512s.YShuffleX3Kernel_Args((dynamic)indices);
                    dst = Vector512s.YShuffleX3Kernel_Core((dynamic)vector, (dynamic)vector1, (dynamic)vector2, (dynamic)args);
                    if (allowLogItem) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core", dst, vector, indices));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"_Core, vector={vector}, indices={indices}");
                    }
                    // Instances
                    foreach (IWVectorTraits512 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        dst = instance.YShuffleX3Kernel((dynamic)vector, (dynamic)vector1, (dynamic)vector2, (dynamic)indices);
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", instance.GetType().Name, dst, vector, indices));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, vector={vector}, indices={indices}");
                        }
                        // Instances: Args and Core
#pragma warning disable CS0618 // Type or member is obsolete
                        instance.YShuffleX3Kernel_Args<TIdx>(indices, out args0, out args1, out args2, out args3);
#pragma warning restore CS0618 // Type or member is obsolete
                        dst = instance.YShuffleX3Kernel_Core((dynamic)vector, (dynamic)vector1, (dynamic)vector2, (dynamic)args0, (dynamic)args1, (dynamic)args2, (dynamic)args3);
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core0 of " + instance.GetType().Name, dst, vector, indices));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, "_Core0 of {instance.GetType().Name}, vector={vector}, indices={indices}");
                        }
                        // Instances: Args and Core with ValueTuple
#pragma warning disable CS0618 // Type or member is obsolete
                        var argsI = instance.YShuffleX3Kernel_Args<TIdx>(indices);
                        // dst = instance.YShuffleX3Kernel_Core((dynamic)vector, (dynamic)argsI); // CS1973	'IWVectorTraits512' has no applicable method named 'YShuffleX3Kernel_Core' but appears to have an extension method by that name. Extension methods cannot be dynamically dispatched. Consider casting the dynamic arguments or calling the extension method without the extension method syntax.
                        dst = instance.YShuffleX3Kernel_Core<T, TIdx>(vector, vector1, vector2, argsI);
#pragma warning restore CS0618 // Type or member is obsolete
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core of " + instance.GetType().Name, dst, vector, indices));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, "_Core of {instance.GetType().Name}, vector={vector}, indices={indices}");
                        }
                    }
                    if (allowLog) {
                        Console.WriteLine();
                    }
                }
            }
        }


        [TestCase((float)1, (int)7)]
        [TestCase((double)2, (long)9)]
        [TestCase((sbyte)3, (sbyte)3)]
        [TestCase((byte)4, (byte)4)]
        [TestCase((short)5, (short)5)]
        [TestCase((ushort)6, (ushort)6)]
        [TestCase((int)7, (int)7)]
        [TestCase((uint)8, (uint)8)]
        [TestCase((long)9, (long)9)]
        [TestCase((ulong)10, (ulong)10)]
        public void YShuffleX4Test<T, TIdx>(T src, TIdx srcIndex) where T : struct where TIdx : struct {
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.YShuffleX4_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            bool allowLog = true;
            //bool allowLogItem = Scalars<T>.ExponentBits > 0;
            bool allowLogItem = false;
            Vector512<T>[] samples = {
                //Vector512s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1),
                //Vector512s<T>.Demo,
                Vector512s<T>.Serial,
                //Vector512s<T>.SerialNegative
            };
            Vector512<TIdx>[] indicesList = {
                Vector512s<TIdx>.Serial,
                Vector512s<TIdx>.SerialDesc,
                Vector512s.CreateByDoubleLoop<TIdx>(0, 4),
                Vector512s.CreateByDoubleLoop<TIdx>(1, 4),
                Vector512s.CreateByDoubleLoop<TIdx>(Scalars.GetDoubleFrom(src), 4),
                Vector512s.CreateByDoubleLoop<TIdx>(Scalars.GetDoubleFrom(src) + Vector512<TIdx>.Count, 4),
                Vector512s.CreateByDoubleLoop<TIdx>(Scalars.GetDoubleFrom(src) + Vector512<TIdx>.Count*2, 4),
                Vector512s.CreateByDoubleLoop<TIdx>(Scalars.GetDoubleFrom(src) + Vector512<TIdx>.Count*3, 4),
            };
            foreach (Vector512<T> vector in samples) {
                Vector512<T> vector1 = Vector512s<T>.SerialNegative;
                Vector512<T> vector2 = Vector512s.CreateByDoubleLoop<T>(-Vector512<T>.Count, -1);
                Vector512<T> vector3 = Vector512s.CreateByDoubleLoop<T>(-Vector512<T>.Count * 2, -1);
                if (allowLog) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("== Sample:\t{0}", vector));
                }
                foreach (Vector512<TIdx> indices in indicesList) {
                    Vector512<T> expected = Vector512s.YShuffleX4((dynamic)vector, (dynamic)vector1, (dynamic)vector2, (dynamic)vector3, (dynamic)indices);
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("Indices:\t{0}", indices));
                        Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                    }
                    // Static: Args and Core
                    Vector512<TIdx> args0, args1, args2, args3, args4;
#pragma warning disable CS0618 // Type or member is obsolete
                    Vector512s.YShuffleX4_Args<TIdx>(indices, out args0, out args1, out args2, out args3, out args4);
#pragma warning restore CS0618 // Type or member is obsolete
                    Vector512<T> dst = Vector512s.YShuffleX4_Core((dynamic)vector, (dynamic)vector1, (dynamic)vector2, (dynamic)vector3, (dynamic)args0, (dynamic)args1, (dynamic)args2, (dynamic)args3, (dynamic)args4);
                    if (allowLogItem) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core0", dst, vector, indices));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"_Core0, vector={vector}, indices={indices}");
                    }
                    // Static: Args and Core with ValueTuple
                    var args = Vector512s.YShuffleX4_Args((dynamic)indices);
                    dst = Vector512s.YShuffleX4_Core((dynamic)vector, (dynamic)vector1, (dynamic)vector2, (dynamic)vector3, (dynamic)args);
                    if (allowLogItem) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core", dst, vector, indices));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"_Core, vector={vector}, indices={indices}");
                    }
                    // Instances
                    foreach (IWVectorTraits512 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        dst = instance.YShuffleX4((dynamic)vector, (dynamic)vector1, (dynamic)vector2, (dynamic)vector3, (dynamic)indices);
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", instance.GetType().Name, dst, vector, indices));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, vector={vector}, indices={indices}");
                        }
                        // Instances: Args and Core
#pragma warning disable CS0618 // Type or member is obsolete
                        instance.YShuffleX4_Args<TIdx>(indices, out args0, out args1, out args2, out args3, out args4);
#pragma warning restore CS0618 // Type or member is obsolete
                        dst = instance.YShuffleX4_Core((dynamic)vector, (dynamic)vector1, (dynamic)vector2, (dynamic)vector3, (dynamic)args0, (dynamic)args1, (dynamic)args2, (dynamic)args3, (dynamic)args4);
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core0 of " + instance.GetType().Name, dst, vector, indices));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, "_Core0 of {instance.GetType().Name}, vector={vector}, indices={indices}");
                        }
                        // Instances: Args and Core with ValueTuple
#pragma warning disable CS0618 // Type or member is obsolete
                        var argsI = instance.YShuffleX4_Args<TIdx>(indices);
                        dst = instance.YShuffleX4_Core<T, TIdx>(vector, vector1, vector2, vector3, argsI);
#pragma warning restore CS0618 // Type or member is obsolete
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core of " + instance.GetType().Name, dst, vector, indices));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, "_Core of {instance.GetType().Name}, vector={vector}, indices={indices}");
                        }
                    }
                    if (allowLog) {
                        Console.WriteLine();
                    }
                }
            }
        }

        [TestCase((float)1, (int)7)]
        [TestCase((double)2, (long)9)]
        [TestCase((sbyte)3, (sbyte)3)]
        [TestCase((byte)4, (byte)4)]
        [TestCase((short)5, (short)5)]
        [TestCase((ushort)6, (ushort)6)]
        [TestCase((int)7, (int)7)]
        [TestCase((uint)8, (uint)8)]
        [TestCase((long)9, (long)9)]
        [TestCase((ulong)10, (ulong)10)]
        public void YShuffleX4InsertTest<T, TIdx>(T src, TIdx srcIndex) where T : struct where TIdx : struct {
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.YShuffleX4Insert_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            bool allowLog = true;
            //bool allowLogItem = Scalars<T>.ExponentBits > 0;
            bool allowLogItem = false;
            Vector512<T> back = Vector512s.Create(src);
            Vector512<T>[] samples = {
                //Vector512s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1),
                //Vector512s<T>.Demo,
                Vector512s<T>.Serial,
                //Vector512s<T>.SerialNegative
            };
            Vector512<TIdx>[] indicesList = {
                Vector512s<TIdx>.Serial,
                Vector512s<TIdx>.SerialDesc,
                Vector512s.CreateByDoubleLoop<TIdx>(0, 4),
                Vector512s.CreateByDoubleLoop<TIdx>(1, 4),
                Vector512s.CreateByDoubleLoop<TIdx>(Scalars.GetDoubleFrom(src), 4),
                Vector512s.CreateByDoubleLoop<TIdx>(Scalars.GetDoubleFrom(src) + Vector512<TIdx>.Count, 4),
                Vector512s.CreateByDoubleLoop<TIdx>(Scalars.GetDoubleFrom(src) + Vector512<TIdx>.Count*2, 4),
                Vector512s.CreateByDoubleLoop<TIdx>(Scalars.GetDoubleFrom(src) + Vector512<TIdx>.Count*3, 4),
            };
            if (allowLog) {
                Console.WriteLine(VectorTextUtil.Format("Back:\t{0}", back));
            }
            foreach (Vector512<T> vector in samples) {
                Vector512<T> vector1 = Vector512s<T>.SerialNegative;
                Vector512<T> vector2 = Vector512s.CreateByDoubleLoop<T>(-Vector512<T>.Count, -1);
                Vector512<T> vector3 = Vector512s.CreateByDoubleLoop<T>(-Vector512<T>.Count * 2, -1);
                if (allowLog) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("== Sample:\t{0}", vector));
                }
                foreach (Vector512<TIdx> indices in indicesList) {
                    Vector512<T> expected = Vector512s.YShuffleX4Insert((dynamic)back, (dynamic)vector, (dynamic)vector1, (dynamic)vector2, (dynamic)vector3, (dynamic)indices);
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("Indices:\t{0}", indices));
                        Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                    }
                    // Static: Args and Core
                    Vector512<TIdx> args0, args1, args2, args3, args4;
#pragma warning disable CS0618 // Type or member is obsolete
                    Vector512s.YShuffleX4Insert_Args<TIdx>(indices, out args0, out args1, out args2, out args3, out args4);
#pragma warning restore CS0618 // Type or member is obsolete
                    Vector512<T> dst = Vector512s.YShuffleX4Insert_Core((dynamic)back, (dynamic)vector, (dynamic)vector1, (dynamic)vector2, (dynamic)vector3, (dynamic)args0, (dynamic)args1, (dynamic)args2, (dynamic)args3, (dynamic)args4);
                    if (allowLogItem) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core0", dst, vector, indices));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"_Core0, vector={vector}, indices={indices}");
                    }
                    // Static: Args and Core with ValueTuple
                    var args = Vector512s.YShuffleX4Insert_Args((dynamic)indices);
                    dst = Vector512s.YShuffleX4Insert_Core((dynamic)back, (dynamic)vector, (dynamic)vector1, (dynamic)vector2, (dynamic)vector3, (dynamic)args);
                    if (allowLogItem) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core", dst, vector, indices));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"_Core, vector={vector}, indices={indices}");
                    }
                    // Instances
                    foreach (IWVectorTraits512 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        dst = instance.YShuffleX4Insert((dynamic)back, (dynamic)vector, (dynamic)vector1, (dynamic)vector2, (dynamic)vector3, (dynamic)indices);
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", instance.GetType().Name, dst, vector, indices));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, vector={vector}, indices={indices}");
                        }
                        // Instances: Args and Core
#pragma warning disable CS0618 // Type or member is obsolete
                        instance.YShuffleX4Insert_Args<TIdx>(indices, out args0, out args1, out args2, out args3, out args4);
#pragma warning restore CS0618 // Type or member is obsolete
                        dst = instance.YShuffleX4Insert_Core((dynamic)back, (dynamic)vector, (dynamic)vector1, (dynamic)vector2, (dynamic)vector3, (dynamic)args0, (dynamic)args1, (dynamic)args2, (dynamic)args3, (dynamic)args4);
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core0 of " + instance.GetType().Name, dst, vector, indices));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, "_Core0 of {instance.GetType().Name}, vector={vector}, indices={indices}");
                        }
                        // Instances: Args and Core with ValueTuple
#pragma warning disable CS0618 // Type or member is obsolete
                        var argsI = instance.YShuffleX4Insert_Args<TIdx>(indices);
                        // dst = instance.YShuffleX4Insert_Core((dynamic)vector, (dynamic)argsI); // CS1973	'IWVectorTraits512' has no applicable method named 'YShuffleX4Insert_Core' but appears to have an extension method by that name. Extension methods cannot be dynamically dispatched. Consider casting the dynamic arguments or calling the extension method without the extension method syntax.
                        dst = instance.YShuffleX4Insert_Core<T, TIdx>(back, vector, vector1, vector2, vector3, argsI);
#pragma warning restore CS0618 // Type or member is obsolete
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core of " + instance.GetType().Name, dst, vector, indices));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, "_Core of {instance.GetType().Name}, vector={vector}, indices={indices}");
                        }
                    }
                    if (allowLog) {
                        Console.WriteLine();
                    }
                }
            }
        }

        [TestCase((float)1, (int)7)]
        [TestCase((double)2, (long)9)]
        [TestCase((sbyte)3, (sbyte)3)]
        [TestCase((byte)4, (byte)4)]
        [TestCase((short)5, (short)5)]
        [TestCase((ushort)6, (ushort)6)]
        [TestCase((int)7, (int)7)]
        [TestCase((uint)8, (uint)8)]
        [TestCase((long)9, (long)9)]
        [TestCase((ulong)10, (ulong)10)]
        public void YShuffleX4KernelTest<T, TIdx>(T src, TIdx srcIndex) where T : struct where TIdx : struct {
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.YShuffleX4Kernel_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            bool allowLog = true;
            //bool allowLogItem = Scalars<T>.ExponentBits > 0;
            bool allowLogItem = false;
            Vector512<T>[] samples = {
                //Vector512s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1),
                //Vector512s<T>.Demo,
                Vector512s<T>.Serial,
                //Vector512s<T>.SerialNegative
            };
            Vector512<TIdx>[] indicesList = {
                Vector512s<TIdx>.Serial,
                Vector512s<TIdx>.SerialDesc,
                Vector512s.CreateByDoubleLoop<TIdx>(0, 4),
                Vector512s.CreateByDoubleLoop<TIdx>(1, 4),
                Vector512s.CreateByDoubleLoop<TIdx>(Scalars.GetDoubleFrom(src), 4),
                Vector512s.CreateByDoubleLoop<TIdx>(Scalars.GetDoubleFrom(src) + Vector512<TIdx>.Count, 4),
                Vector512s.CreateByDoubleLoop<TIdx>(Scalars.GetDoubleFrom(src) + Vector512<TIdx>.Count*2, 4),
                Vector512s.CreateByDoubleLoop<TIdx>(Scalars.GetDoubleFrom(src) + Vector512<TIdx>.Count*3, 4),
            };
            foreach (Vector512<T> vector in samples) {
                Vector512<T> vector1 = Vector512s<T>.SerialNegative;
                Vector512<T> vector2 = Vector512s.CreateByDoubleLoop<T>(-Vector512<T>.Count, -1);
                Vector512<T> vector3 = Vector512s.CreateByDoubleLoop<T>(-Vector512<T>.Count * 2, -1);
                if (allowLog) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("== Sample:\t{0}, {1}", vector, vector1));
                }
                foreach (Vector512<TIdx> indicesFor in indicesList) {
                    //Vector512<TIdx> indices = indicesFor;
                    Vector512<TIdx> indices = Vector512s.BitwiseAnd(indicesFor, Vector512s<TIdx>.IndexX4Mask);
                    Vector512<T> expected = Vector512s.YShuffleX4Kernel((dynamic)vector, (dynamic)vector1, (dynamic)vector2, (dynamic)vector3, (dynamic)indices);
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("Indices:\t{0}", indices));
                        Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                    }
                    // Static: Args and Core
                    Vector512<TIdx> args0, args1, args2, args3;
#pragma warning disable CS0618 // Type or member is obsolete
                    Vector512s.YShuffleX4Kernel_Args<TIdx>(indices, out args0, out args1, out args2, out args3);
#pragma warning restore CS0618 // Type or member is obsolete
                    Vector512<T> dst = Vector512s.YShuffleX4Kernel_Core((dynamic)vector, (dynamic)vector1, (dynamic)vector2, (dynamic)vector3, (dynamic)args0, (dynamic)args1, (dynamic)args2, (dynamic)args3);
                    if (allowLogItem) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core0", dst, vector, indices));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"_Core0, vector={vector}, indices={indices}");
                    }
                    // Static: Args and Core with ValueTuple
                    var args = Vector512s.YShuffleX4Kernel_Args((dynamic)indices);
                    dst = Vector512s.YShuffleX4Kernel_Core((dynamic)vector, (dynamic)vector1, (dynamic)vector2, (dynamic)vector3, (dynamic)args);
                    if (allowLogItem) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core", dst, vector, indices));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"_Core, vector={vector}, indices={indices}");
                    }
                    // Instances
                    foreach (IWVectorTraits512 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        dst = instance.YShuffleX4Kernel((dynamic)vector, (dynamic)vector1, (dynamic)vector2, (dynamic)vector3, (dynamic)indices);
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", instance.GetType().Name, dst, vector, indices));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, vector={vector}, indices={indices}");
                        }
                        // Instances: Args and Core
#pragma warning disable CS0618 // Type or member is obsolete
                        instance.YShuffleX4Kernel_Args<TIdx>(indices, out args0, out args1, out args2, out args3);
#pragma warning restore CS0618 // Type or member is obsolete
                        dst = instance.YShuffleX4Kernel_Core((dynamic)vector, (dynamic)vector1, (dynamic)vector2, (dynamic)vector3, (dynamic)args0, (dynamic)args1, (dynamic)args2, (dynamic)args3);
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core0 of " + instance.GetType().Name, dst, vector, indices));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, "_Core0 of {instance.GetType().Name}, vector={vector}, indices={indices}");
                        }
                        // Instances: Args and Core with ValueTuple
#pragma warning disable CS0618 // Type or member is obsolete
                        var argsI = instance.YShuffleX4Kernel_Args<TIdx>(indices);
                        // dst = instance.YShuffleX4Kernel_Core((dynamic)vector, (dynamic)argsI); // CS1973	'IWVectorTraits512' has no applicable method named 'YShuffleX4Kernel_Core' but appears to have an extension method by that name. Extension methods cannot be dynamically dispatched. Consider casting the dynamic arguments or calling the extension method without the extension method syntax.
                        dst = instance.YShuffleX4Kernel_Core<T, TIdx>(vector, vector1, vector2, vector3, argsI);
#pragma warning restore CS0618 // Type or member is obsolete
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core of " + instance.GetType().Name, dst, vector, indices));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, "_Core of {instance.GetType().Name}, vector={vector}, indices={indices}");
                        }
                    }
                    if (allowLog) {
                        Console.WriteLine();
                    }
                }
            }
        }


        [TestCase((float)1, (int)1)]
        [TestCase((double)2, (long)1)]
        [TestCase((sbyte)3, (sbyte)1)]
        [TestCase((short)5, (short)1)]
        [TestCase((int)7, (int)1)]
        [TestCase((long)9, (long)1)]
        public void YSignTest<T, TOut>(T src, TOut srcOut) where T : struct where TOut : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YSign_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector512s.GetSupportedMethodList<Func<Vector512<T>, Vector512<TOut>>>("YSign_Basic", "YSign_Bit");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector512<T>[] samples = {
                Vector512s<T>.Serial,
                Vector512s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), -1.0),
                Vector512s<T>.Demo,
                Vector512s<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector512<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector512<TOut> expected = Vector512s.YSign((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits512 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector512<TOut> dst = instance.YSign((dynamic)value);
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
        public void YSignFloatTest<T>(T src) where T : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YSignFloat_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector512s.GetSupportedMethodList<Func<Vector512<T>, Vector512<T>>>("YSignFloat_Basic", "YSignFloat_Bit", "YSignFloat_Compare", "YSignFloat_Convert");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector512<T>[] samples = {
                Vector512s<T>.Serial,
                Vector512s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), -1.0),
                Vector512s<T>.Demo,
                Vector512s<T>.DemoNaN,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector512<T> value in samples) {
                writer.WriteLine(VectorTextUtil.Format("Sample:\t{0}", value));
                Vector512<T> expected = Vector512s.YSignFloat((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits512 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector512<T> dst = instance.YSignFloat((dynamic)value);
                    if (allowLog || (showNotEquals && !expected.Equals(dst))) {
                        writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                    }
                }
                writer.WriteLine();
            }
        }

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
