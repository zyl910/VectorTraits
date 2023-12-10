using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.Numerics;
using Zyl.VectorTraits.Extensions.SameW;
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Tests.Impl.IVectorTraitsTest {
    [TestFixture()]
    public class VectorTests_YB {

        [TestCase]
        public void YBitToByteTest() {
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.YBitToByte_IsAccelerated}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<Func<ulong, Vector<byte>>>("YBitToByte_Basic", "YBitToByte_Shuffle", "YBitToByte_Widen");
            foreach (var func in funcList) {
                Console.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            // samples.
            List<ulong> samples = new List<ulong>();
            int bitCount = Vector<byte>.Count;
            int bitClamped = Math.Min(bitCount, 4);
            int iMax = (1 << bitClamped) - 1;
            for (int i = 0; i <= iMax; ++i) {
                samples.Add((ulong)i);
            }
            if (bitClamped < bitCount) {
                for (int i = bitClamped; i < bitCount; ++i) {
                    iMax <<= 1;
                    samples.Add((ulong)iMax);
                }
            }
            // run.
            foreach (ulong value in samples) {
                Vector<byte> expected = Vectors.YBitToByte(value);
                //Console.WriteLine(VectorTextUtil.Format("YBitToByte({0}):\t{1}", value, expected));
                foreach (IVectorTraits instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector<byte> dst = instance.YBitToByte(value);
                    Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                }
                foreach (var func in funcList) {
                    string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                    Vector<byte> dst = func(value);
                    Assert.AreEqual(expected, dst, $"{funcName}, value={value}");
                    Assert.AreEqual(expected, dst, VectorTextUtil.Format("{0}, value={1}", funcName, value));
                    //Console.WriteLine(VectorTextUtil.Format("{2}({0}):\t{1}", value, expected, funcName));
                }
            }
        }

        [TestCase]
        public void YBitToInt16Test() {
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.YBitToInt16_IsAccelerated}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // samples.
            List<ulong> samples = new List<ulong>();
            int bitCount = Vector<short>.Count;
            int bitClamped = Math.Min(bitCount, 4);
            int iMax = (1 << bitClamped) - 1;
            for (int i = 0; i <= iMax; ++i) {
                samples.Add((ulong)i);
            }
            if (bitClamped < bitCount) {
                for (int i = bitClamped; i < bitCount; ++i) {
                    iMax <<= 1;
                    samples.Add((ulong)iMax);
                }
            }
            // run.
            foreach (ulong value in samples) {
                Vector<short> expected = Vectors.YBitToInt16(value);
                //Console.WriteLine(VectorTextUtil.Format("YBitToInt16({0}):\t{1}", value, expected));
                foreach (IVectorTraits instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector<short> dst = instance.YBitToInt16(value);
                    Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                }
            }
        }

        [TestCase]
        public void YBitToInt32Test() {
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.YBitToInt32_IsAccelerated}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // samples.
            List<ulong> samples = new List<ulong>();
            int bitCount = Vector<int>.Count;
            int bitClamped = Math.Min(bitCount, 4);
            int iMax = (1 << bitClamped) - 1;
            for (int i = 0; i <= iMax; ++i) {
                samples.Add((ulong)i);
            }
            if (bitClamped < bitCount) {
                for (int i = bitClamped; i < bitCount; ++i) {
                    iMax <<= 1;
                    samples.Add((ulong)iMax);
                }
            }
            // run.
            foreach (ulong value in samples) {
                Vector<int> expected = Vectors.YBitToInt32(value);
                //Console.WriteLine(VectorTextUtil.Format("YBitToInt32({0}):\t{1}", value, expected));
                foreach (IVectorTraits instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector<int> dst = instance.YBitToInt32(value);
                    Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                }
            }
        }

        [TestCase]
        public void YBitToInt64Test() {
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.YBitToInt64_IsAccelerated}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // samples.
            List<ulong> samples = new List<ulong>();
            int bitCount = Vector<long>.Count;
            int bitClamped = Math.Min(bitCount, 4);
            int iMax = (1 << bitClamped) - 1;
            for (int i = 0; i <= iMax; ++i) {
                samples.Add((ulong)i);
            }
            if (bitClamped < bitCount) {
                for (int i = bitClamped; i < bitCount; ++i) {
                    iMax <<= 1;
                    samples.Add((ulong)iMax);
                }
            }
            // run.
            foreach (ulong value in samples) {
                Vector<long> expected = Vectors.YBitToInt64(value);
                //Console.WriteLine(VectorTextUtil.Format("YBitToInt64({0}):\t{1}", value, expected));
                foreach (IVectorTraits instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector<long> dst = instance.YBitToInt64(value);
                    Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                }
            }
        }

    }
}
