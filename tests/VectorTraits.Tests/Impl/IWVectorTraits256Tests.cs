using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Tests.Impl {
    [TestFixture()]
    public class IWVectorTraits256Tests {
#if NETCOREAPP3_0_OR_GREATER

        //[TestCase((sbyte)3)]
        [TestCase((byte)4)]
        [TestCase((short)5)]
        //[TestCase((ushort)6)]
        [TestCase((int)7)]
        //[TestCase((uint)8)]
        //[TestCase((long)9)]
        //[TestCase((ulong)10)]
        public void ShiftLeftTest<T>(T src) where T : struct {
            //Vector256<T> vzero = Vector256<T>.Zero;
            //T zero = default;
            int shiftCountMax = Vector256s<T>.ElementBitSize + 1;
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                if (!instance.IsSupported) {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                    continue;
                }
            }
            // run.
            Vector256<T>[] samples = {
                Vector256s.Create(src),
                Vector256s<T>.Demo,
                Vector256s<T>.Serial,
            };
            foreach (Vector256<T> vsrc in samples) {
                for (int shiftCount = -1; shiftCount <= shiftCountMax; ++shiftCount) {
                    Vector256<T> vbaseline = (Vector256<T>)Vector256s.ShiftLeft((dynamic)vsrc, shiftCount);
                    foreach (IWVectorTraits256 instance in instances) {
                        if (!instance.IsSupported) continue;
                        Vector256<T> vdst = (Vector256<T>)instance.ShiftLeft((dynamic)vsrc, shiftCount);
                        Assert.AreEqual(vbaseline, vdst, $"{instance.GetType().Name}, shiftCount={shiftCount}, vsrc={vsrc}");
                    }
                }
            }
        }


#endif
    }
}
