using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Xml.Linq;
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Tests.Impl.IVectorTraitsTest {
    [TestFixture()]
    public class VectorTests_W {

        [TestCase((float)1, (double)1)]
        [TestCase((sbyte)3, (short)1)]
        [TestCase((byte)4, (ushort)1)]
        [TestCase((short)5, (int)1)]
        [TestCase((ushort)6, (uint)1)]
        [TestCase((int)7, (long)1)]
        [TestCase((uint)8, (ulong)1)]
        public void WidenTest<T, TOut>(T src, TOut dst) where T : struct where TOut : struct {
#pragma warning disable CS0618 // Type or member is obsolete
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.Widen_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector<T>[] samples = {
                Vectors.Create(src),
                Vectors<T>.Demo,
                Vectors<T>.Serial,
                Vectors<T>.SerialNegative,
                Vectors<T>.InterlacedSign,
                Vectors<T>.XyXMask,
                Vectors<T>.XyzwXMask
            };
            foreach (Vector<T> soure in samples) {
                Vector<TOut> expected0, expected1;
#if NETCOREAPP3_0_OR_GREATER
                // CS8133	Cannot deconstruct dynamic objects. (expected0, expected1) = Vector.Widen((dynamic)vector);
                VectorGeneric.Widen(soure, out expected0, out expected1);
#else
                // CS1510	A ref or out value must be an assignable variable . Vectors.Widen((dynamic)vector, out (dynamic)expected0, out (dynamic)expected1);
                Vectors.Widen(soure, out expected0, out expected1);
#endif // NETCOREAPP3_0_OR_GREATER
                if (Scalars<T>.ExponentBits > 0) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", soure));
                    Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}, {1}", expected0, expected1));
                }
                foreach (IVectorTraits instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector<TOut> dst0, dst1;
                    instance.Widen(soure, out dst0, out dst1);
                    if (Scalars<T>.ExponentBits > 0) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, {2}", instance.GetType().Name, dst0, dst1));
                    } else {
                        Assert.AreEqual(expected0, dst0, $"{instance.GetType().Name}, soure={soure}");
                        Assert.AreEqual(expected1, dst1, $"{instance.GetType().Name}, soure={soure}");
                    }
                }
            }
#pragma warning restore CS0618 // Type or member is obsolete
        }


    }
}
