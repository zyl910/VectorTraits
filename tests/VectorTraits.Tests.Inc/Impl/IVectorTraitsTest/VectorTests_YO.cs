using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.Numerics;
using Zyl.VectorTraits.Extensions.SameW;
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Tests.Impl.IVectorTraitsTest {
    [TestFixture()]
    public class VectorTests_YO {

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
        public void YOrNotTest<T>(T src) where T : struct {
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.YOrNot_AcceleratedTypes}");
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
                Vectors<T>.XyXMask,
                Vectors<T>.XyYMask,
                Vectors<T>.XyzwXMask
            };
            foreach (Vector<T> left in samples) {
                foreach (Vector<T> right in samples) {
                    Vector<T> expected = Vectors.YOrNot(left, right);
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        Vector<T> dst = instance.YOrNot(left, right);
                        Assert.AreEqual(expected.AsByte(), dst.AsByte(), $"{instance.GetType().Name}, left={left}, right={right}");
                    }
                }
            }
        }

    }
}
