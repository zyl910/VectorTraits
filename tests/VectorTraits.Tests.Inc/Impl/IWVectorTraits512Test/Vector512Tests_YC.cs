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

namespace Zyl.VectorTraits.Tests.Impl.IWVectorTraits512Test {
    [TestFixture()]
    public class Vector512Tests_YC {
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
        public void YClampTest<T>(T src) where T : struct {
            bool? noHex = true;
            string? lineCommentSeparator = null;
            string? lineCommentItemSeparator = null;
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.YClamp_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector512<T>[] samples = {
                Vector512s.Create(src),
                Vector512s<T>.Demo,
                Vector512s<T>.Serial,
                Vector512s<T>.SerialDesc
            };
            Vector512<T>[] borders = {
                Vector512s<T>.V_4,
                Vector512s<T>.V0,
                Vector512s<T>.V3,
                Vector512s<T>.Serial
            };
            for(int i=0; i< borders.Length; ++i) {
                Vector512<T> amin = borders[i];
                for (int j = i + 1; j < borders.Length; ++j) {
                    Vector512<T> amax = borders[j];
                    foreach (Vector512<T> value in samples) {
                        Vector512<T> expected = Vector512s.YClamp((dynamic)value, (dynamic)amin, (dynamic)amax);
                        if (Scalars<T>.ExponentBits > 0) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format(noHex, lineCommentSeparator, lineCommentItemSeparator, "f({0}, {1}, {2}):\t", value, amin, amax));
                        }
                        foreach (IWVectorTraits512 instance in instances) {
                            if (!instance.GetIsSupported(true)) continue;
                            Vector512<T> dst = Vector512s.YClamp((dynamic)value, (dynamic)amin, (dynamic)amax);
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
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YCopySign_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector512s.GetSupportedMethodList<Func<Vector512<T>, Vector512<T>>>("YCopySign_Basic", "YCopySign_Bit");
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
            Vector512<T>[] signList = {
                Vector512s<T>.Serial,
                Vector512s<T>.Demo,
                Vector512s<T>.InterlacedSign,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector512<T> sign in signList) {
                foreach (Vector512<T> value in samples) {
                    writer.WriteLine(VectorTextUtil.Format("Sample: {0}, Sign: {1}", value, sign));
                    Vector512<T> expected = Vector512s.YCopySign((dynamic)value, (dynamic)sign);
                    writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                    foreach (IWVectorTraits512 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        Vector512<T> dst = instance.YCopySign((dynamic)value, (dynamic)sign);
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
