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

namespace Zyl.VectorTraits.Tests.Impl.IWVectorTraits128Test {
#if USED_NUNIT3
    using ClassicAssert = Assert;
#endif

    [TestFixture()]
    public class Vector128Tests_W {
#if NETCOREAPP3_0_OR_GREATER

        [TestCase((float)1, (double)1)]
        [TestCase((sbyte)3, (short)1)]
        [TestCase((byte)4, (ushort)1)]
        [TestCase((short)5, (int)1)]
        [TestCase((ushort)6, (uint)1)]
        [TestCase((int)7, (long)1)]
        [TestCase((uint)8, (ulong)1)]
        public void WidenTest<T, TOut>(T src, TOut dst) where T : struct where TOut : struct {
#pragma warning disable CS0618 // Type or member is obsolete
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.Widen_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector128<T>[] samples = {
                Vector128s.Create(src),
                Vector128s<T>.Demo,
                Vector128s<T>.Serial,
                Vector128s<T>.SerialNegative,
                Vector128s<T>.InterlacedSign,
                Vector128s<T>.XyXMask,
                Vector128s<T>.XyzwXMask
            };
            foreach (Vector128<T> soure in samples) {
                Vector128<TOut> expected0, expected1;
#if NET7_0_OR_GREATER
                // CS8133	Cannot deconstruct dynamic objects. (expected0, expected1) = Vector128.Widen((dynamic)vector);
                Vector128Generic.Widen(soure, out expected0, out expected1);
#else
                // CS1510	A ref or out value must be an assignable variable . Vector128s.Widen((dynamic)vector, out (dynamic)expected0, out (dynamic)expected1);
                Vector128s.Widen(soure, out expected0, out expected1);
#endif // NET7_0_OR_GREATER
                if (Scalars<T>.ExponentBits > 0) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", soure));
                    Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}, {1}", expected0, expected1));
                }
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<TOut> dst0, dst1;
                    instance.Widen(soure, out dst0, out dst1);
                    if (Scalars<T>.ExponentBits > 0) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, {2}", instance.GetType().Name, dst0, dst1));
                    } else {
                        ClassicAssert.AreEqual(expected0, dst0, $"{instance.GetType().Name}, soure={soure}");
                        ClassicAssert.AreEqual(expected1, dst1, $"{instance.GetType().Name}, soure={soure}");
                    }
                }
            }
#pragma warning restore CS0618 // Type or member is obsolete
        }


#endif
    }
}
