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
    public class VectorTests_N {

        [TestCase((double)2, (float)1)]
        [TestCase((short)5, (sbyte)1)]
        [TestCase((ushort)6, (byte)1)]
        [TestCase((int)7, (short)1)]
        [TestCase((uint)8, (ushort)1)]
        [TestCase((long)9, (int)1)]
        [TestCase((ulong)10, (uint)1)]
        public void NarrowTest<T, TOut>(T src, TOut srcOut) where T : struct where TOut : struct {
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.Narrow_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<Func<Vector<T>, Vector<T>, Vector<TOut>>>("Narrow_Base");
            foreach (var func in funcList) {
                Console.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            // run.
            Vector<T>[] samples = {
                Vectors.Create(src),
                Vectors<T>.Demo,
                Vectors<T>.Serial,
                Vectors<T>.SerialNegative,
                Vectors<T>.InterlacedSign,
                Vectors<T>.InterlacedSignNegative,
                Vectors<T>.XyXMask,
                Vectors<T>.XyzwXMask
            };
            for (int i = 0; i < samples.Length; i += 2) {
                Vector<T> lower = samples[i];
                Vector<T> upper = samples[i+1];
#if NET7_0_OR_GREATER
                Vector<TOut> expected = Vector.Narrow((dynamic)lower, (dynamic)upper);
#else
                Vector<TOut> expected = Vectors.Narrow((dynamic)lower, (dynamic)upper);
#endif // NET7_0_OR_GREATER
                if (Scalars<T>.ExponentBits > 0) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}, {1}", lower, upper));
                    Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                }
                foreach (IVectorTraits instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector<TOut> dst = instance.Narrow((dynamic)lower, (dynamic)upper);
                    if (Scalars<T>.ExponentBits > 0) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, lower={lower}, upper={upper}");
                    }
                }
                foreach (var func in funcList) {
                    string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                    Vector<TOut> dst = func(lower, upper);
                    if (Scalars<T>.ExponentBits > 0) {
                    // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", funcName, dst));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"{funcName}, lower={lower}, upper={upper}");
                    }
                }
            }
        }


    }
}
