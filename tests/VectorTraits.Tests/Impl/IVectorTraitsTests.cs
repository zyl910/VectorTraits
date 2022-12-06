using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Xml.Linq;
using Zyl.VectorTraits.Impl;


namespace Zyl.VectorTraits.Tests.Impl {
    [TestFixture()]
    public class IVectorTraitsTests {

        [TestCase((sbyte)3)]
        [TestCase((byte)4)]
        [TestCase((short)5)]
        [TestCase((ushort)6)]
        [TestCase((int)7)]
        [TestCase((uint)8)]
        [TestCase((long)9)]
        [TestCase((ulong)10)]
        public void ShiftLeftTest<T>(T src) where T : struct {
            //Vector<T> vzero = Vector<T>.Zero;
            //T zero = default;
            int shiftCountMax = Scalars<T>.BitSize + 1;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (!instance.IsSupported) {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                    continue;
                }
            }
            var funcList = Vectors.GetSupportedMethodList<Func<Vector<T>, int, Vector<T>>>("ShiftLeft_Base", "ShiftLeft_Multiply");
            foreach (var func in funcList) {
                Console.WriteLine(ReflectionUtil.GetShortNameWithType(func.Method));
            }
            // run.
            Vector<T>[] samples = {
                Vectors.Create(src),
                Vectors<T>.Demo,
                Vectors<T>.Serial,
            };
            foreach (Vector<T> vsrc in samples) {
                for (int shiftCount = -1; shiftCount <= shiftCountMax; ++shiftCount) {
                    Vector<T> vbaseline = Vectors.ShiftLeft((dynamic)vsrc, shiftCount);
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.IsSupported) continue;
                        Vector<T> vdst = instance.ShiftLeft((dynamic)vsrc, shiftCount);
                        Assert.AreEqual(vbaseline, vdst, $"{instance.GetType().Name}, shiftCount={shiftCount}, vsrc={vsrc}");
                    }
                    foreach (var func in funcList) {
                        string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                        Vector<T> vdst = func(vsrc, shiftCount);
                        Assert.AreEqual(vbaseline, vdst, $"{funcName}, shiftCount={shiftCount}, vsrc={vsrc}");
                    }
                }
            }
        }

        [TestCase((sbyte)3)]
        [TestCase((byte)4)]
        [TestCase((short)5)]
        [TestCase((ushort)6)]
        [TestCase((int)7)]
        [TestCase((uint)8)]
        [TestCase((long)9)]
        [TestCase((ulong)10)]
        public void ShiftLeftFastTest<T>(T src) where T : struct {
            //Vector<T> vzero = Vector<T>.Zero;
            //T zero = default;
            int shiftCountMax = Scalars<T>.BitSize - 1;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (!instance.IsSupported) {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                    continue;
                }
            }
            var funcList = Vectors.GetSupportedMethodList<Func<Vector<T>, int, Vector<T>>>("ShiftLeftFast_Base", "ShiftLeftFast_Multiply");
            foreach (var func in funcList) {
                Console.WriteLine(ReflectionUtil.GetShortNameWithType(func.Method));
            }
            // run.
            Vector<T>[] samples = {
                Vectors.Create(src),
                Vectors<T>.Demo,
                Vectors<T>.Serial,
            };
            foreach (Vector<T> vsrc in samples) {
                for (int shiftCount = 0; shiftCount <= shiftCountMax; ++shiftCount) {
                    Vector<T> vbaseline = Vectors.ShiftLeftFast((dynamic)vsrc, shiftCount);
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.IsSupported) continue;
                        Vector<T> vdst = instance.ShiftLeftFast((dynamic)vsrc, shiftCount);
                        Assert.AreEqual(vbaseline, vdst, $"{instance.GetType().Name}, shiftCount={shiftCount}, vsrc={vsrc}");
                    }
                    foreach (var func in funcList) {
                        string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                        Vector<T> vdst = func(vsrc, shiftCount);
                        Assert.AreEqual(vbaseline, vdst, $"{funcName}, shiftCount={shiftCount}, vsrc={vsrc}");
                    }
                }
            }
        }


    }
}
