using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.Numerics;
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Tests.Impl.IVectorTraitsTest {
    [TestFixture()]
    public class VectorTests_YS {
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
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
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
            Vector<T> back = Vectors.Create(src);
            Vector<T>[] samples = {
                //Vectors.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1),
                //Vectors<T>.Demo,
                Vectors<T>.Serial,
                //Vectors<T>.SerialNegative
            };
            Vector<TIdx>[] indicesList = {
                Vectors<TIdx>.Serial,
                Vectors<TIdx>.SerialDesc,
                Vectors.CreateByDoubleLoop<TIdx>(0, 2),
                Vectors.CreateByDoubleLoop<TIdx>(1, 2),
                Vectors.CreateByDoubleLoop<TIdx>(Scalars.GetDoubleFrom(src), 1),
            };
            if (allowLog) {
                Console.WriteLine(VectorTextUtil.Format("Back:\t{0}", back));
            }
            foreach (Vector<T> vector in samples) {
                if (allowLog) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("== Sample:\t{0}", vector));
                }
                foreach (Vector<TIdx> indices in indicesList) {
                    Vector<T> expected = Vectors.YShuffleInsert((dynamic)back, (dynamic)vector, (dynamic)indices);
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("Indices:\t{0}", indices));
                        Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                    }
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        Vector<T> dst = instance.YShuffleInsert((dynamic)back, (dynamic)vector, (dynamic)indices);
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", instance.GetType().Name, dst, vector, indices));
                        } else {
                            Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, vector={vector}, indices={indices}");
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
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
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
            Vector<T>[] samples = {
                //Vectors.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1),
                //Vectors<T>.Demo,
                Vectors<T>.Serial,
                //Vectors<T>.SerialNegative
            };
            Vector<TIdx>[] indicesList = {
                Vectors<TIdx>.Serial,
                Vectors<TIdx>.SerialDesc,
                Vectors.CreateByDoubleLoop<TIdx>(0, 2),
                Vectors.CreateByDoubleLoop<TIdx>(1, 2),
                Vectors.CreateByDoubleLoop<TIdx>(Scalars.GetDoubleFrom(src), 1),
            };
            foreach (Vector<T> vector in samples) {
                if (allowLog) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("== Sample:\t{0}", vector));
                }
                foreach (Vector<TIdx> indicesFor in indicesList) {
                    //Vector<TIdx> indices = indicesFor;
                    Vector<TIdx> indices = Vector.BitwiseAnd(indicesFor, Vectors<TIdx>.IndexMask);
#if NETX_0_OR_GREATER
                    Vector<T> expected = Vector.Shuffle((dynamic)vector, (dynamic)indices);
#else
                    Vector<T> expected = Vectors.YShuffleKernel((dynamic)vector, (dynamic)indices);
#endif // NETX_0_OR_GREATER
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("Indices:\t{0}", indices));
                        Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                    }
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        Vector<T> dst = instance.YShuffleKernel((dynamic)vector, (dynamic)indices);
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", instance.GetType().Name, dst, vector, indices));
                        } else {
                            Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, vector={vector}, indices={indices}");
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
