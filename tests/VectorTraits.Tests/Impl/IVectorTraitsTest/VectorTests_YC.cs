using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.Numerics;
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Tests.Impl.IVectorTraitsTest {
    [TestFixture()]
    public class VectorTests_YC {

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
        public void YClampTest<T>(T src) where T : struct {
            bool? noHex = true;
            string? lineCommentSeparator = null;
            string? lineCommentItemSeparator = null;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.YClamp_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector<T>[] samples = {
                Vectors.Create(src),
                Vectors<T>.Demo,
                Vectors<T>.Serial,
                Vectors<T>.SerialDesc
            };
            Vector<T>[] borders = {
                Vectors<T>.V_4,
                Vectors<T>.V0,
                Vectors<T>.V3,
                Vectors<T>.Serial
            };
            for (int i = 0; i < borders.Length; ++i) {
                Vector<T> amin = borders[i];
                for (int j = i + 1; j < borders.Length; ++j) {
                    Vector<T> amax = borders[j];
                    foreach (Vector<T> value in samples) {
                        Vector<T> expected = Vectors.YClamp((dynamic)value, (dynamic)amin, (dynamic)amax);
                        if (Scalars<T>.ExponentBits > 0) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format(noHex, lineCommentSeparator, lineCommentItemSeparator, "f({0}, {1}, {2}):\t", value, amin, amax));
                        }
                        foreach (IVectorTraits instance in instances) {
                            if (!instance.GetIsSupported(true)) continue;
                            Vector<T> dst = Vectors.YClamp((dynamic)value, (dynamic)amin, (dynamic)amax);
                            if (Scalars<T>.ExponentBits > 0) {
                                // Compatible floating-point NaN.
                                Console.WriteLine(VectorTextUtil.Format(noHex, lineCommentSeparator, lineCommentItemSeparator, "\t{0}:\t{1}", instance.GetType().Name, dst));
                            } else {
                                Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}, amin={amin}, amax={amax}");
                            }
                        }
                    }

                }

            }
        }


    }
}
