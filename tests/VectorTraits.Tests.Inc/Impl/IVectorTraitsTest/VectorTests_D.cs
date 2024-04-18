using NUnit.Framework;
#if !USED_NUNIT3
using NUnit.Framework.Legacy;
#endif
using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Text;
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Tests.Impl.IVectorTraitsTest {
#if USED_NUNIT3
    using ClassicAssert = Assert;
#endif

    [TestFixture()]
    public class VectorTests_D {

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
        public void DotTest<T>(T src) where T : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.Dot_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector<T>[] samples = {
                Vectors.Create(src),
                Vectors<T>.Demo,
                Vectors<T>.V2,
                Vectors<T>.Serial,
                Vectors<T>.SerialNegative
            };
            bool isCompatible = Scalars<T>.ExponentBits > 0; // Compatible floating-point NaN.
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector<T> left in samples) {
                foreach (Vector<T> right in samples) {
                    T expected = Vector.Dot(left, right);
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        T dst = instance.Dot((dynamic)left, (dynamic)right);
                        bool usedWrite = allowLog;
                        if (!usedWrite && !expected.Equals(dst)) {
                            if (showNotEquals || isCompatible) {
                                usedWrite = true;
                            } else {
                                ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, left={left}, right={right}");
                            }
                        }
                        if (usedWrite) {
                            writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}, left={2}, right={3}", instance.GetType().Name, dst, left, right));
                        }
                    }
                }
            }
        }

    }
}
