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
                                ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}, amin={amin}, amax={amax}");
                            }
                        }
                    }

                }

            }
        }

        [TestCase((float)1)]
        [TestCase((double)2)]
        [TestCase((sbyte)3)]
        [TestCase((short)5)]
        [TestCase((int)7)]
        [TestCase((long)9)]
        public void YCopySignTest<T>(T src) where T : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YCopySign_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<Func<Vector<T>, Vector<T>>>("YCopySign_Basic", "YCopySign_Bit");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector<T>[] samples = {
                Vectors<T>.Serial,
                Vectors.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), -1.0),
                Vectors<T>.Demo,
                Vectors<T>.DemoNaN,
            };
            Vector<T>[] signList = {
                Vectors<T>.Serial,
                Vectors<T>.Demo,
                Vectors<T>.InterlacedSign,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector<T> sign in signList) {
                foreach (Vector<T> value in samples) {
                    writer.WriteLine(VectorTextUtil.Format("Sample: {0}, Sign: {1}", value, sign));
                    Vector<T> expected = Vectors.YCopySign((dynamic)value, (dynamic)sign);
                    writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        Vector<T> dst = instance.YCopySign((dynamic)value, (dynamic)sign);
                        if (allowLog || (showNotEquals && !expected.Equals(dst))) {
                            writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}, sign={sign}");
                        }
                    }
                    writer.WriteLine();
                }
            }
        }


    }
}
