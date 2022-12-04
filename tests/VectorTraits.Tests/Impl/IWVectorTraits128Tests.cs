﻿using NUnit.Framework;
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
    public class IWVectorTraits128Tests {
#if NETCOREAPP3_0_OR_GREATER

        //[TestCase((sbyte)3)]
        [TestCase((byte)4)]
        [TestCase((short)5)]
        //[TestCase((ushort)6)]
        [TestCase((int)7)]
        //[TestCase((uint)8)]
        [TestCase((long)9)]
        //[TestCase((ulong)10)]
        public void ShiftLeftTest<T>(T src) where T : struct {
            //Vector128<T> vzero = Vector128<T>.Zero;
            //T zero = default;
            int shiftCountMax = Scalars<T>.BitSize + 1;
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (!instance.IsSupported) {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                    continue;
                }
            }
            // run.
            Vector128<T>[] samples = {
                Vector128s.Create(src),
                Vector128s<T>.Demo,
                Vector128s<T>.Serial,
            };
            foreach (Vector128<T> vsrc in samples) {
                for (int shiftCount = -1; shiftCount <= shiftCountMax; ++shiftCount) {
                    Vector128<T> vbaseline = (Vector128<T>)Vector128s.ShiftLeft((dynamic)vsrc, shiftCount);
                    foreach (IWVectorTraits128 instance in instances) {
                        if (!instance.IsSupported) continue;
                        Vector128<T> vdst = (Vector128<T>)instance.ShiftLeft((dynamic)vsrc, shiftCount);
                        Assert.AreEqual(vbaseline, vdst, $"{instance.GetType().Name}, shiftCount={shiftCount}, vsrc={vsrc}");
                    }
                }
            }
        }

        //[TestCase((sbyte)3)]
        [TestCase((byte)4)]
        [TestCase((short)5)]
        //[TestCase((ushort)6)]
        [TestCase((int)7)]
        //[TestCase((uint)8)]
        [TestCase((long)9)]
        //[TestCase((ulong)10)]
        public void ShiftLeftFastTest<T>(T src) where T : struct {
            //Vector128<T> vzero = Vector128<T>.Zero;
            //T zero = default;
            int shiftCountMax = Scalars<T>.BitSize - 1;
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (!instance.IsSupported) {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                    continue;
                }
            }
            // run.
            Vector128<T>[] samples = {
                Vector128s.Create(src),
                Vector128s<T>.Demo,
                Vector128s<T>.Serial,
            };
            foreach (Vector128<T> vsrc in samples) {
                for (int shiftCount = 0; shiftCount <= shiftCountMax; ++shiftCount) {
                    Vector128<T> vbaseline = (Vector128<T>)Vector128s.ShiftLeftFast((dynamic)vsrc, shiftCount);
                    foreach (IWVectorTraits128 instance in instances) {
                        if (!instance.IsSupported) continue;
                        Vector128<T> vdst = (Vector128<T>)instance.ShiftLeftFast((dynamic)vsrc, shiftCount);
                        Assert.AreEqual(vbaseline, vdst, $"{instance.GetType().Name}, shiftCount={shiftCount}, vsrc={vsrc}");
                    }
                }
            }
        }


#endif
    }
}