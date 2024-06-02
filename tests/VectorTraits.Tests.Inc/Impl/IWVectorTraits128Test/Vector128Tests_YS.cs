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

namespace Zyl.VectorTraits.Tests.Impl.IWVectorTraits128Test {
#if USED_NUNIT3
    using ClassicAssert = Assert;
#endif

    [TestFixture()]
    public class Vector128Tests_YS {
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
        public void YShuffleG2Test<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
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
            Vector128<T>[] samples = {
                Vector128s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1),
                //Vector128s<T>.Demo,
                Vector128s<T>.Serial,
                //Vector128s<T>.SerialNegative
            };
            foreach (Vector128<T> source in samples) {
                if (allowLog) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("== Sample:\t{0}", source));
                }
                for (int j = 0; j <= 3; ++j) {
                    ShuffleControlG2 control = (ShuffleControlG2)j;
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("-- Control:\t{0}", control));
                    }
                    Vector128<T> expected = Vector128s.YShuffleG2((dynamic)source, control);
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                    }
                    Vector128<T> dst;
                    // Instances
                    foreach (IWVectorTraits128 instance in instances) {
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
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
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
            Vector128<T>[] samples = {
                Vector128s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1),
                //Vector128s<T>.Demo,
                Vector128s<T>.Serial,
                //Vector128s<T>.SerialNegative
            };
            //ShuffleControlG2 control = ShuffleControlG2.YX;
            foreach (Vector128<T> source in samples) {
                if (allowLog) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("== Sample:\t{0}", source));
                }
                for (int j = 0; j <= 3; ++j) {
                    ShuffleControlG2 control = (ShuffleControlG2)j;
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("-- Control:\t{0}", control));
                    }
                    Vector128<T> expected = Vector128s.YShuffleG2_Const((dynamic)source, control);
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                    }
                    Vector128<T> dst;
                    // Instances
                    foreach (IWVectorTraits128 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        dst = instance.YShuffleG2_Const((dynamic)source, control);
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
        public void YShuffleG4X2Test<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
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
            Vector128<T>[] samples = {
                Vector128s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1),
                //Vector128s<T>.Demo,
                //Vector128s<T>.Serial,
                Vector128s<T>.SerialNegative
            };
            try {
                for (int i = 0; i < samples.Length; i += 2) {
                    Vector128<T> source0 = samples[i];
                    Vector128<T> source1 = samples[i + 1];
                    if (allowLog) {
                        Console.WriteLine();
                        Console.WriteLine(VectorTextUtil.Format("== Sample:\t{0}-{1}", source0, source1));
                    }
                    for (int j = 0; j <= 255; ++j) {
                        ShuffleControlG4 control = (ShuffleControlG4)j;
                        if (allowLog) {
                            Console.WriteLine(VectorTextUtil.Format("-- Control:\t{0}", control));
                        }
                        Vector128<T> expected0, expected1;
                        dynamic expected = Vector128s.YShuffleG4X2((dynamic)source0, (dynamic)source1, control);
                        expected0 = expected.Item1;
                        expected1 = expected.Item2;
                        if (allowLog) {
                            Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}-{1}", expected0, expected1));
                        }
                        // Instances
                        Vector128<T> dst0, dst1;
                        foreach (IWVectorTraits128 instance in instances) {
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
            } catch (Exception ex) {
                Console.WriteLine(ex);
                throw;
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
        public void YShuffleG4X2_ConstTest<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
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
            Vector128<T>[] samples = {
                Vector128s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1),
                //Vector128s<T>.Demo,
                //Vector128s<T>.Serial,
                Vector128s<T>.SerialNegative
            };
            try {
                for (int i = 0; i < samples.Length; i += 2) {
                    Vector128<T> source0 = samples[i];
                    Vector128<T> source1 = samples[i + 1];
                    if (allowLog) {
                        Console.WriteLine();
                        Console.WriteLine(VectorTextUtil.Format("== Sample:\t{0}-{1}", source0, source1));
                    }
                    for (int j = 0; j <= 255; ++j) {
                        ShuffleControlG4 control = (ShuffleControlG4)j;
                        if (allowLog) {
                            Console.WriteLine(VectorTextUtil.Format("-- Control:\t{0}", control));
                        }
                        Vector128<T> expected0, expected1;
                        dynamic expected = Vector128s.YShuffleG4X2_Const((dynamic)source0, (dynamic)source1, control);
                        expected0 = expected.Item1;
                        expected1 = expected.Item2;
                        if (allowLog) {
                            Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}-{1}", expected0, expected1));
                        }
                        // Instances
                        Vector128<T> dst0, dst1;
                        foreach (IWVectorTraits128 instance in instances) {
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
            } catch (Exception ex) {
                Console.WriteLine(ex);
                throw;
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
        public void YShuffleInsertTest<T, TIdx>(T src, TIdx srcIndex) where T : struct where TIdx : struct {
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
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
            Vector128<T> back = Vector128s.Create(src);
            Vector128<T>[] samples = {
                //Vector128s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1),
                //Vector128s<T>.Demo,
                Vector128s<T>.Serial,
                //Vector128s<T>.SerialNegative
            };
            Vector128<TIdx>[] indicesList = {
                Vector128s<TIdx>.Serial,
                Vector128s<TIdx>.SerialDesc,
                Vector128s.CreateByDoubleLoop<TIdx>(0, 2),
                Vector128s.CreateByDoubleLoop<TIdx>(1, 2),
                Vector128s.CreateByDoubleLoop<TIdx>(Scalars.GetDoubleFrom(src), 1),
            };
            if (allowLog) {
                Console.WriteLine(VectorTextUtil.Format("Back:\t{0}", back));
            }
            foreach (Vector128<T> vector in samples) {
                if (allowLog) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("== Sample:\t{0}", vector));
                }
                foreach (Vector128<TIdx> indices in indicesList) {
                    Vector128<T> expected = Vector128s.YShuffleInsert((dynamic)back, (dynamic)vector, (dynamic)indices);
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("Indices:\t{0}", indices));
                        Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                    }
                    // Static: Args and Core
                    Vector128<TIdx> args0, args1, args2;
#pragma warning disable CS0618 // Type or member is obsolete
                    Vector128s.YShuffleInsert_Args<TIdx>(indices, out args0, out args1, out args2);
#pragma warning restore CS0618 // Type or member is obsolete
                    Vector128<T> dst = Vector128s.YShuffleInsert_Core((dynamic)back, (dynamic)vector, (dynamic)args0, (dynamic)args1, (dynamic)args2);
                    if (allowLogItem) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core0", dst, vector, indices));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, "_Core0, vector={vector}, indices={indices}");
                    }
                    // Static: Args and Core with ValueTuple
                    var args = Vector128s.YShuffleInsert_Args((dynamic)indices);
                    dst = Vector128s.YShuffleInsert_Core((dynamic)back, (dynamic)vector, (dynamic)args);
                    if (allowLogItem) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core", dst, vector, indices));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, "_Core, vector={vector}, indices={indices}");
                    }
                    // Instances
                    foreach (IWVectorTraits128 instance in instances) {
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
                        // dst = instance.YShuffleInsert_Core((dynamic)vector, (dynamic)argsI); // CS1973	'IWVectorTraits128' has no applicable method named 'YShuffleInsert_Core' but appears to have an extension method by that name. Extension methods cannot be dynamically dispatched. Consider casting the dynamic arguments or calling the extension method without the extension method syntax.
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
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
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
            Vector128<T>[] samples = {
                //Vector128s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1),
                //Vector128s<T>.Demo,
                Vector128s<T>.Serial,
                //Vector128s<T>.SerialNegative
            };
            Vector128<TIdx>[] indicesList = {
                Vector128s<TIdx>.Serial,
                Vector128s<TIdx>.SerialDesc,
                Vector128s.CreateByDoubleLoop<TIdx>(0, 2),
                Vector128s.CreateByDoubleLoop<TIdx>(1, 2),
                Vector128s.CreateByDoubleLoop<TIdx>(Scalars.GetDoubleFrom(src), 1),
            };
            foreach (Vector128<T> vector in samples) {
                if (allowLog) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("== Sample:\t{0}", vector));
                }
                foreach (Vector128<TIdx> indicesFor in indicesList) {
                    //Vector128<TIdx> indices = indicesFor;
                    Vector128<TIdx> indices = Vector128s.BitwiseAnd(indicesFor, Vector128s<TIdx>.IndexMask);
#if NET7_0_OR_GREATER
                    Vector128<T> expected = Vector128.Shuffle((dynamic)vector, (dynamic)indices);
#else
                    Vector128<T> expected = Vector128s.YShuffleKernel((dynamic)vector, (dynamic)indices);
#endif // NET7_0_OR_GREATER
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("Indices:\t{0}", indices));
                        Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                    }
                    // Static: Args and Core
                    Vector128<TIdx> args0, args1;
#pragma warning disable CS0618 // Type or member is obsolete
                    Vector128s.YShuffleKernel_Args<TIdx>(indices, out args0, out args1);
#pragma warning restore CS0618 // Type or member is obsolete
                    Vector128<T> dst = Vector128s.YShuffleKernel_Core((dynamic)vector, (dynamic)args0, (dynamic)args1);
                    if (allowLogItem) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core0", dst, vector, indices));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, "_Core0, vector={vector}, indices={indices}");
                    }
                    // Static: Args and Core with ValueTuple
                    var args = Vector128s.YShuffleKernel_Args((dynamic)indices);
                    dst = Vector128s.YShuffleKernel_Core((dynamic)vector, (dynamic)args);
                    if (allowLogItem) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core", dst, vector, indices));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, "_Core, vector={vector}, indices={indices}");
                    }
                    // Instances
                    foreach (IWVectorTraits128 instance in instances) {
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
                        // dst = instance.YShuffleKernel_Core((dynamic)vector, (dynamic)argsI); // CS1973	'IWVectorTraits128' has no applicable method named 'YShuffleKernel_Core' but appears to have an extension method by that name. Extension methods cannot be dynamically dispatched. Consider casting the dynamic arguments or calling the extension method without the extension method syntax.
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
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
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
            Vector128<T>[] samples = {
                //Vector128s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1),
                //Vector128s<T>.Demo,
                Vector128s<T>.Serial,
                //Vector128s<T>.SerialNegative
            };
            Vector128<TIdx>[] indicesList = {
                Vector128s<TIdx>.Serial,
                Vector128s<TIdx>.SerialDesc,
                Vector128s.CreateByDoubleLoop<TIdx>(0, 2),
                Vector128s.CreateByDoubleLoop<TIdx>(1, 2),
                Vector128s.CreateByDoubleLoop<TIdx>(Scalars.GetDoubleFrom(src), 2),
                Vector128s.CreateByDoubleLoop<TIdx>(Scalars.GetDoubleFrom(src), 3),
            };
            foreach (Vector128<T> vector in samples) {
                Vector128<T> vector1 = Vector128s<T>.SerialNegative;
                if (allowLog) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("== Sample:\t{0}", vector));
                }
                foreach (Vector128<TIdx> indices in indicesList) {
                    Vector128<T> expected = Vector128s.YShuffleX2((dynamic)vector, (dynamic)vector1, (dynamic)indices);
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("Indices:\t{0}", indices));
                        Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                    }
                    // Static: Args and Core
                    Vector128<TIdx> args0, args1, args2, args3, args4;
#pragma warning disable CS0618 // Type or member is obsolete
                    Vector128s.YShuffleX2_Args<TIdx>(indices, out args0, out args1, out args2, out args3, out args4);
#pragma warning restore CS0618 // Type or member is obsolete
                    Vector128<T> dst = Vector128s.YShuffleX2_Core((dynamic)vector, (dynamic)vector1, (dynamic)args0, (dynamic)args1, (dynamic)args2, (dynamic)args3, (dynamic)args4);
                    if (allowLogItem) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core0", dst, vector, indices));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"_Core0, vector={vector}, indices={indices}");
                    }
                    // Static: Args and Core with ValueTuple
                    var args = Vector128s.YShuffleX2_Args((dynamic)indices);
                    dst = Vector128s.YShuffleX2_Core((dynamic)vector, (dynamic)vector1, (dynamic)args);
                    if (allowLogItem) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core", dst, vector, indices));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"_Core, vector={vector}, indices={indices}");
                    }
                    // Instances
                    foreach (IWVectorTraits128 instance in instances) {
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
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
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
            Vector128<T> back = Vector128s.Create(src);
            Vector128<T>[] samples = {
                //Vector128s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1),
                //Vector128s<T>.Demo,
                Vector128s<T>.Serial,
                //Vector128s<T>.SerialNegative
            };
            Vector128<TIdx>[] indicesList = {
                Vector128s<TIdx>.Serial,
                Vector128s<TIdx>.SerialDesc,
                Vector128s.CreateByDoubleLoop<TIdx>(0, 2),
                Vector128s.CreateByDoubleLoop<TIdx>(1, 2),
                Vector128s.CreateByDoubleLoop<TIdx>(Scalars.GetDoubleFrom(src), 1),
            };
            if (allowLog) {
                Console.WriteLine(VectorTextUtil.Format("Back:\t{0}", back));
            }
            foreach (Vector128<T> vector in samples) {
                Vector128<T> vector1 = Vector128s<T>.SerialNegative;
                if (allowLog) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("== Sample:\t{0}", vector));
                }
                foreach (Vector128<TIdx> indices in indicesList) {
                    Vector128<T> expected = Vector128s.YShuffleX2Insert((dynamic)back, (dynamic)vector, (dynamic)vector1, (dynamic)indices);
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("Indices:\t{0}", indices));
                        Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                    }
                    // Static: Args and Core
                    Vector128<TIdx> args0, args1, args2, args3, args4;
#pragma warning disable CS0618 // Type or member is obsolete
                    Vector128s.YShuffleX2Insert_Args<TIdx>(indices, out args0, out args1, out args2, out args3, out args4);
#pragma warning restore CS0618 // Type or member is obsolete
                    Vector128<T> dst = Vector128s.YShuffleX2Insert_Core((dynamic)back, (dynamic)vector, (dynamic)vector1, (dynamic)args0, (dynamic)args1, (dynamic)args2, (dynamic)args3, (dynamic)args4);
                    if (allowLogItem) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core0", dst, vector, indices));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"_Core0, vector={vector}, indices={indices}");
                    }
                    // Static: Args and Core with ValueTuple
                    var args = Vector128s.YShuffleX2Insert_Args((dynamic)indices);
                    dst = Vector128s.YShuffleX2Insert_Core((dynamic)back, (dynamic)vector, (dynamic)vector1, (dynamic)args);
                    if (allowLogItem) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core", dst, vector, indices));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"_Core, vector={vector}, indices={indices}");
                    }
                    // Instances
                    foreach (IWVectorTraits128 instance in instances) {
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
                        // dst = instance.YShuffleX2Insert_Core((dynamic)vector, (dynamic)argsI); // CS1973	'IWVectorTraits128' has no applicable method named 'YShuffleX2Insert_Core' but appears to have an extension method by that name. Extension methods cannot be dynamically dispatched. Consider casting the dynamic arguments or calling the extension method without the extension method syntax.
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
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
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
            Vector128<T>[] samples = {
                //Vector128s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1),
                //Vector128s<T>.Demo,
                Vector128s<T>.Serial,
                //Vector128s<T>.SerialNegative
            };
            Vector128<TIdx>[] indicesList = {
                Vector128s<TIdx>.Serial,
                Vector128s<TIdx>.SerialDesc,
                Vector128s.CreateByDoubleLoop<TIdx>(0, 2),
                Vector128s.CreateByDoubleLoop<TIdx>(1, 2),
                Vector128s.CreateByDoubleLoop<TIdx>(Scalars.GetDoubleFrom(src), 1),
            };
            foreach (Vector128<T> vector in samples) {
                Vector128<T> vector1 = Vector128s<T>.SerialNegative;
                if (allowLog) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("== Sample:\t{0}, {1}", vector, vector1));
                }
                foreach (Vector128<TIdx> indicesFor in indicesList) {
                    //Vector128<TIdx> indices = indicesFor;
                    Vector128<TIdx> indices = Vector128s.BitwiseAnd(indicesFor, Vector128s<TIdx>.IndexX2Mask);
                    Vector128<T> expected = Vector128s.YShuffleX2Kernel((dynamic)vector, (dynamic)vector1, (dynamic)indices);
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("Indices:\t{0}", indices));
                        Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                    }
                    // Static: Args and Core
                    Vector128<TIdx> args0, args1, args2, args3;
#pragma warning disable CS0618 // Type or member is obsolete
                    Vector128s.YShuffleX2Kernel_Args<TIdx>(indices, out args0, out args1, out args2, out args3);
#pragma warning restore CS0618 // Type or member is obsolete
                    Vector128<T> dst = Vector128s.YShuffleX2Kernel_Core((dynamic)vector, (dynamic)vector1, (dynamic)args0, (dynamic)args1, (dynamic)args2, (dynamic)args3);
                    if (allowLogItem) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core0", dst, vector, indices));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"_Core0, vector={vector}, indices={indices}");
                    }
                    // Static: Args and Core with ValueTuple
                    var args = Vector128s.YShuffleX2Kernel_Args((dynamic)indices);
                    dst = Vector128s.YShuffleX2Kernel_Core((dynamic)vector, (dynamic)vector1, (dynamic)args);
                    if (allowLogItem) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core", dst, vector, indices));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"_Core, vector={vector}, indices={indices}");
                    }
                    // Instances
                    foreach (IWVectorTraits128 instance in instances) {
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
                        // dst = instance.YShuffleX2Kernel_Core((dynamic)vector, (dynamic)argsI); // CS1973	'IWVectorTraits128' has no applicable method named 'YShuffleX2Kernel_Core' but appears to have an extension method by that name. Extension methods cannot be dynamically dispatched. Consider casting the dynamic arguments or calling the extension method without the extension method syntax.
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

        [TestCase((float)1, (int)1)]
        [TestCase((double)2, (long)1)]
        [TestCase((sbyte)3, (sbyte)1)]
        [TestCase((short)5, (short)1)]
        [TestCase((int)7, (int)1)]
        [TestCase((long)9, (long)1)]
        public void YSignTest<T, TOut>(T src, TOut srcOut) where T : struct where TOut : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YSign_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector128s.GetSupportedMethodList<Func<Vector128<T>, Vector128<TOut>>>("YSign_Basic", "YSign_Bit");
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
                Vector128<TOut> expected = Vector128s.YSign((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<TOut> dst = instance.YSign((dynamic)value);
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
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YSignFloat_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector128s.GetSupportedMethodList<Func<Vector128<T>, Vector128<T>>>("YSignFloat_Basic", "YSignFloat_Bit", "YSignFloat_Compare", "YSignFloat_Convert");
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
                Vector128<T> expected = Vector128s.YSignFloat((dynamic)value);
                writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<T> dst = instance.YSignFloat((dynamic)value);
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
