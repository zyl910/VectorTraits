﻿using NUnit.Framework;
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

namespace Zyl.VectorTraits.Tests.Impl.IWVectorTraits128Test {
    [TestFixture()]
    public class Vector128Tests_YC {
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
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.YClamp_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector128<T>[] samples = {
                Vector128s.Create(src),
                Vector128s<T>.Demo,
                Vector128s<T>.Serial,
                Vector128s<T>.SerialDesc
            };
            Vector128<T>[] borders = {
                Vector128s<T>.V_4,
                Vector128s<T>.V0,
                Vector128s<T>.V3,
                Vector128s<T>.Serial
            };
            for (int i = 0; i < borders.Length; ++i) {
                Vector128<T> amin = borders[i];
                for (int j = i + 1; j < borders.Length; ++j) {
                    Vector128<T> amax = borders[j];
                    foreach (Vector128<T> value in samples) {
                        Vector128<T> expected = Vector128s.YClamp((dynamic)value, (dynamic)amin, (dynamic)amax);
                        if (Scalars<T>.ExponentBits > 0) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format(noHex, lineCommentSeparator, lineCommentItemSeparator, "f({0}, {1}, {2}):\t", value, amin, amax));
                        }
                        foreach (IWVectorTraits128 instance in instances) {
                            if (!instance.GetIsSupported(true)) continue;
                            Vector128<T> dst = Vector128s.YClamp((dynamic)value, (dynamic)amin, (dynamic)amax);
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
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK. {instance.YCopySign_AcceleratedTypes}");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector128s.GetSupportedMethodList<Func<Vector128<T>, Vector128<T>>>("YCopySign_Basic", "YCopySign_Bit");
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
            Vector128<T>[] signList = {
                Vector128s<T>.Serial,
                Vector128s<T>.Demo,
                Vector128s<T>.InterlacedSign,
            };
            bool allowLog = false;
            bool showNotEquals = true;
            foreach (Vector128<T> sign in signList) {
                foreach (Vector128<T> value in samples) {
                    writer.WriteLine(VectorTextUtil.Format("Sample: {0}, Sign: {1}", value, sign));
                    Vector128<T> expected = Vector128s.YCopySign((dynamic)value, (dynamic)sign);
                    writer.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                    foreach (IWVectorTraits128 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        Vector128<T> dst = instance.YCopySign((dynamic)value, (dynamic)sign);
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
