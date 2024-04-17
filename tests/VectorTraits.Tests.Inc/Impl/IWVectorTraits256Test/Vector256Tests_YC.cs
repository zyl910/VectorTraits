using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.Numerics;
using System.IO;

#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Tests.Impl.IWVectorTraits256Test {
    [TestFixture()]
    public class Vector256Tests_YC {
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
        public void YClampTest<T>(T src) where T : struct {
            bool? noHex = true;
            string? lineCommentSeparator = null;
            string? lineCommentItemSeparator = null;
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.YClamp_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector256<T>[] samples = {
                Vector256s.Create(src),
                Vector256s<T>.Demo,
                Vector256s<T>.Serial,
                Vector256s<T>.SerialDesc
            };
            Vector256<T>[] borders = {
                Vector256s<T>.V_4,
                Vector256s<T>.V0,
                Vector256s<T>.V3,
                Vector256s<T>.Serial
            };
            for(int i=0; i< borders.Length; ++i) {
                Vector256<T> amin = borders[i];
                for (int j = i + 1; j < borders.Length; ++j) {
                    Vector256<T> amax = borders[j];
                    foreach (Vector256<T> value in samples) {
                        Vector256<T> expected = Vector256s.YClamp((dynamic)value, (dynamic)amin, (dynamic)amax);
                        if (Scalars<T>.ExponentBits > 0) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format(noHex, lineCommentSeparator, lineCommentItemSeparator, "f({0}, {1}, {2}):\t", value, amin, amax));
                        }
                        foreach (IWVectorTraits256 instance in instances) {
                            if (!instance.GetIsSupported(true)) continue;
                            Vector256<T> dst = Vector256s.YClamp((dynamic)value, (dynamic)amin, (dynamic)amax);
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

        [TestCase((float)1)]
        [TestCase((double)2)]
        [TestCase((sbyte)3)]
        [TestCase((short)5)]
        [TestCase((int)7)]
        [TestCase((long)9)]
        public void YCopySignTest<T>(T src) where T : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YCopySign_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector256s.GetSupportedMethodList<Func<Vector256<T>, Vector256<T>>>("YCopySign_Basic", "YCopySign_Bit");
            foreach (var func in funcList) {
                writer.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            writer.WriteLine();
            // run.
            Vector256<T>[] samples = {
                Vector256s<T>.Serial,
                Vector256s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), -1.0),
                Vector256s<T>.Demo,
                Vector256s<T>.DemoNaN,
            };
            Vector256<T>[] signList = {
                Vector256s<T>.Serial,
                Vector256s<T>.Demo,
                Vector256s<T>.InterlacedSign,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector256<T> sign in signList) {
                foreach (Vector256<T> value in samples) {
                    writer.WriteLine(VectorTextUtil.Format("Sample: {0}, Sign: {1}", value, sign));
                    Vector256<T> expected = Vector256s.YCopySign((dynamic)value, (dynamic)sign);
                    writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                    foreach (IWVectorTraits256 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        Vector256<T> dst = instance.YCopySign((dynamic)value, (dynamic)sign);
                        if (allowLog || (showNotEquals && !expected.Equals(dst))) {
                            writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                        } else {
                            Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}, sign={sign}");
                        }
                    }
                    writer.WriteLine();
                }
            }
        }

#endif
    }
}
