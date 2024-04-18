using NUnit.Framework;
#if !USED_NUNIT3
using NUnit.Framework.Legacy;
#endif
using System;
using System.Collections.Generic;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using System.IO;
using System.Text;
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Tests.Impl.IWVectorTraits256Test {
#if USED_NUNIT3
    using ClassicAssert = Assert;
#endif

    [TestFixture()]
    public class Vector256Tests_N {
#if NETCOREAPP3_0_OR_GREATER

        [TestCase((double)2, (float)1)]
        [TestCase((short)5, (sbyte)1)]
        [TestCase((ushort)6, (byte)1)]
        [TestCase((int)7, (short)1)]
        [TestCase((uint)8, (ushort)1)]
        [TestCase((long)9, (int)1)]
        [TestCase((ulong)10, (uint)1)]
        public void NarrowTest<T, TOut>(T src, TOut srcOut) where T : struct where TOut : struct {
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.Narrow_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector256s.GetSupportedMethodList<Func<Vector256<T>, Vector256<T>, Vector256<TOut>>>("Narrow_Base");
            foreach (var func in funcList) {
                Console.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            // run.
            Vector256<T>[] samples = {
                Vector256s.Create(src),
                Vector256s<T>.Demo,
                Vector256s<T>.Serial,
                Vector256s<T>.SerialNegative,
                Vector256s<T>.InterlacedSign,
                Vector256s<T>.InterlacedSignNegative,
                Vector256s<T>.XyXMask,
                Vector256s<T>.XyzwXMask
            };
            for (int i = 0; i < samples.Length; i += 2) {
                Vector256<T> lower = samples[i];
                Vector256<T> upper = samples[i+1];
#if NET7_0_OR_GREATER
                Vector256<TOut> expected = Vector256.Narrow((dynamic)lower, (dynamic)upper);
#else
                Vector256<TOut> expected = Vector256s.Narrow((dynamic)lower, (dynamic)upper);
#endif // NET7_0_OR_GREATER
                if (Scalars<T>.ExponentBits > 0) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}, {1}", lower, upper));
                    Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                }
                foreach (IWVectorTraits256 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector256<TOut> dst = instance.Narrow((dynamic)lower, (dynamic)upper);
                    if (Scalars<T>.ExponentBits > 0) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, lower={lower}, upper={upper}");
                    }
                }
                foreach (var func in funcList) {
                    string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                    Vector256<TOut> dst = func(lower, upper);
                    if (Scalars<T>.ExponentBits > 0) {
                    // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", funcName, dst));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"{funcName}, lower={lower}, upper={upper}");
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
        public void NegateTest<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.Negate_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector256<T>[] samples = {
                Vector256s.Create(src),
                Vector256s<T>.Demo,
                Vector256s<T>.Serial,
                Vector256s<T>.SerialNegative,
                Vector256s<T>.InterlacedSign,
                Vector256s<T>.XyXMask,
                Vector256s<T>.XyzwXMask
            };
            foreach (Vector256<T> vector in samples) {
                Vector256<T> expected = Vector256s.Negate((dynamic)vector);
                if (Scalars<T>.ExponentBits > 0) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", vector));
                    Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                }
                foreach (IWVectorTraits256 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector256<T> dst = instance.Negate((dynamic)vector);
                    if (Scalars<T>.ExponentBits > 0) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        ClassicAssert.AreEqual(expected.AsByte(), dst.AsByte(), $"{instance.GetType().Name}, vector={vector}");
                    }
                }
            }
        }


#endif
    }
}
