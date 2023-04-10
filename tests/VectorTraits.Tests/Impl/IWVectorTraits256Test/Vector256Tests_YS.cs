using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Impl;
using Zyl.VectorTraits.Tuples;

namespace Zyl.VectorTraits.Tests.Impl.IWVectorTraits256Test {
    [TestFixture()]
    public class Vector256Tests_YS {
#if NETCOREAPP3_0_OR_GREATER

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
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
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
            Vector256<T> back = Vector256s.Create(src);
            Vector256<T>[] samples = {
                //Vector256s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1),
                //Vector256s<T>.Demo,
                Vector256s<T>.Serial,
                //Vector256s<T>.SerialNegative
            };
            Vector256<TIdx>[] indicesList = {
                Vector256s<TIdx>.Serial,
                Vector256s<TIdx>.SerialDesc,
                Vector256s.CreateByDoubleLoop<TIdx>(0, 2),
                Vector256s.CreateByDoubleLoop<TIdx>(1, 2),
                Vector256s.CreateByDoubleLoop<TIdx>(Scalars.GetDoubleFrom(src), 1),
            };
            if (allowLog) {
                Console.WriteLine(VectorTextUtil.Format("Back:\t{0}", back));
            }
            foreach (Vector256<T> vector in samples) {
                if (allowLog) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("== Sample:\t{0}", vector));
                }
                foreach (Vector256<TIdx> indices in indicesList) {
                    Vector256<T> expected = Vector256s.YShuffleInsert((dynamic)back, (dynamic)vector, (dynamic)indices);
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("Indices:\t{0}", indices));
                        Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                    }
                    // Static: Args and Core
                    Vector256<TIdx> args0, args1, args2;
#pragma warning disable CS0618 // Type or member is obsolete
                    Vector256s.YShuffleInsert_Args<TIdx>(indices, out args0, out args1, out args2);
#pragma warning restore CS0618 // Type or member is obsolete
                    Vector256<T> dst = Vector256s.YShuffleInsert_Core((dynamic)back, (dynamic)vector, (dynamic)args0, (dynamic)args1, (dynamic)args2);
                    if (allowLogItem) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Args", dst, vector, indices));
                    } else {
                        Assert.AreEqual(expected, dst, "_Args, vector={vector}, indices={indices}");
                    }
                    // Static: Args and Core with ValueTuple
                    var args = Vector256s.YShuffleInsert_Args((dynamic)indices);
                    dst = Vector256s.YShuffleInsert_Core((dynamic)back, (dynamic)vector, (dynamic)args);
                    if (allowLogItem) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Args2", dst, vector, indices));
                    } else {
                        Assert.AreEqual(expected, dst, "_Args2, vector={vector}, indices={indices}");
                    }
                    // Instances
                    foreach (IWVectorTraits256 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        dst = instance.YShuffleInsert((dynamic)back, (dynamic)vector, (dynamic)indices);
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", instance.GetType().Name, dst, vector, indices));
                        } else {
                            Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, vector={vector}, indices={indices}");
                        }
                        // Instances: Args and Core
#pragma warning disable CS0618 // Type or member is obsolete
                        instance.YShuffleInsert_Args<TIdx>(indices, out args0, out args1, out args2);
#pragma warning restore CS0618 // Type or member is obsolete
                        dst = instance.YShuffleInsert_Core((dynamic)back, (dynamic)vector, (dynamic)args0, (dynamic)args1, (dynamic)args2);
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Args of " + instance.GetType().Name, dst, vector, indices));
                        } else {
                            Assert.AreEqual(expected, dst, "_Args of {instance.GetType().Name}, vector={vector}, indices={indices}");
                        }
                        // Instances: Args and Core with ValueTuple
#pragma warning disable CS0618 // Type or member is obsolete
                        var argsI = instance.YShuffleInsert_Args<TIdx>(indices);
                        // dst = instance.YShuffleInsert_Core((dynamic)vector, (dynamic)argsI); // CS1973	'IWVectorTraits256' has no applicable method named 'YShuffleInsert_Core' but appears to have an extension method by that name. Extension methods cannot be dynamically dispatched. Consider casting the dynamic arguments or calling the extension method without the extension method syntax.
                        dst = instance.YShuffleInsert_Core<T, TIdx>(back, vector, argsI);
#pragma warning restore CS0618 // Type or member is obsolete
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Args2 of " + instance.GetType().Name, dst, vector, indices));
                        } else {
                            Assert.AreEqual(expected, dst, "_Args2 of {instance.GetType().Name}, vector={vector}, indices={indices}");
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
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
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
            Vector256<T>[] samples = {
                //Vector256s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1),
                //Vector256s<T>.Demo,
                Vector256s<T>.Serial,
                //Vector256s<T>.SerialNegative
            };
            Vector256<TIdx>[] indicesList = {
                Vector256s<TIdx>.Serial,
                Vector256s<TIdx>.SerialDesc,
                Vector256s.CreateByDoubleLoop<TIdx>(0, 2),
                Vector256s.CreateByDoubleLoop<TIdx>(1, 2),
                Vector256s.CreateByDoubleLoop<TIdx>(Scalars.GetDoubleFrom(src), 1),
            };
            foreach (Vector256<T> vector in samples) {
                if (allowLog) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("== Sample:\t{0}", vector));
                }
                foreach (Vector256<TIdx> indicesFor in indicesList) {
                    //Vector256<TIdx> indices = indicesFor;
                    Vector256<TIdx> indices = Vector256s.BitwiseAnd(indicesFor, Vector256s<TIdx>.IndexMask);
#if NET7_0_OR_GREATER
                    Vector256<T> expected = Vector256.Shuffle((dynamic)vector, (dynamic)indices);
#else
                    Vector256<T> expected = Vector256s.YShuffleKernel((dynamic)vector, (dynamic)indices);
#endif // NET7_0_OR_GREATER
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("Indices:\t{0}", indices));
                        Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                    }
                    // Static: Args and Core
                    Vector256<TIdx> args0, args1;
#pragma warning disable CS0618 // Type or member is obsolete
                    Vector256s.YShuffleKernel_Args<TIdx>(indices, out args0, out args1);
#pragma warning restore CS0618 // Type or member is obsolete
                    Vector256<T> dst = Vector256s.YShuffleKernel_Core((dynamic)vector, (dynamic)args0, (dynamic)args1);
                    if (allowLogItem) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Args", dst, vector, indices));
                    } else {
                        Assert.AreEqual(expected, dst, "_Args, vector={vector}, indices={indices}");
                    }
                    // Static: Args and Core with ValueTuple
                    var args = Vector256s.YShuffleKernel_Args((dynamic)indices);
                    dst = Vector256s.YShuffleKernel_Core((dynamic)vector, (dynamic)args);
                    if (allowLogItem) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Args2", dst, vector, indices));
                    } else {
                        Assert.AreEqual(expected, dst, "_Args2, vector={vector}, indices={indices}");
                    }
                    // Static: ArgsX and Core
#pragma warning disable CS0618 // Type or member is obsolete
                    Vector256X2<TIdx> argsX = Vector256s.YShuffleKernel_ArgsX((dynamic)indices);
                    dst = Vector256s.YShuffleKernel_Core((dynamic)vector, (dynamic)argsX);
#pragma warning restore CS0618 // Type or member is obsolete
                    if (allowLogItem) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Args", dst, vector, indices));
                    } else {
                        Assert.AreEqual(expected, dst, "_ArgsX, vector={vector}, indices={indices}");
                    }
                    // Instances
                    foreach (IWVectorTraits256 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        dst = instance.YShuffleKernel((dynamic)vector, (dynamic)indices);
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", instance.GetType().Name, dst, vector, indices));
                        } else {
                            Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, vector={vector}, indices={indices}");
                        }
                        // Instances: Args and Core
#pragma warning disable CS0618 // Type or member is obsolete
                        instance.YShuffleKernel_Args<TIdx>(indices, out args0, out args1);
#pragma warning restore CS0618 // Type or member is obsolete
                        dst = instance.YShuffleKernel_Core((dynamic)vector, (dynamic)args0, (dynamic)args1);
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Args of " + instance.GetType().Name, dst, vector, indices));
                        } else {
                            Assert.AreEqual(expected, dst, "_Args of {instance.GetType().Name}, vector={vector}, indices={indices}");
                        }
                        // Instances: Args and Core with ValueTuple
#pragma warning disable CS0618 // Type or member is obsolete
                        var argsI = instance.YShuffleKernel_Args<TIdx>(indices);
                        // dst = instance.YShuffleKernel_Core((dynamic)vector, (dynamic)argsI); // CS1973	'IWVectorTraits256' has no applicable method named 'YShuffleKernel_Core' but appears to have an extension method by that name. Extension methods cannot be dynamically dispatched. Consider casting the dynamic arguments or calling the extension method without the extension method syntax.
                        dst = instance.YShuffleKernel_Core<T, TIdx>(vector, argsI);
#pragma warning restore CS0618 // Type or member is obsolete
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Args2 of " + instance.GetType().Name, dst, vector, indices));
                        } else {
                            Assert.AreEqual(expected, dst, "_Args2 of {instance.GetType().Name}, vector={vector}, indices={indices}");
                        }
                    }
                    if (allowLog) {
                        Console.WriteLine();
                    }
                }
            }
        }

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
