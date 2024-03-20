using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Impl;
using Zyl.VectorTraits.Impl.AVector512;

namespace Zyl.VectorTraits.Tests.Impl.IWVectorTraits512Test {
    [TestFixture()]
    public class Vector512Tests_YB {
#if NET8_0_OR_GREATER


        [TestCase]
        public void YBitToByteTest() {
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.YBitToByte_IsAccelerated}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector512s.GetSupportedMethodList<Func<uint, Vector512<byte>>>("YBitToByte_Basic", "YBitToByte_Shuffle", "YBitToByte_Widen");
            foreach (var func in funcList) {
                Console.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            // samples.
            List<uint> samples = new List<uint>();
            int bitCount = Vector512<byte>.Count;
            int bitClamped = Math.Min(bitCount, 4);
            int iMax = (1 << bitClamped) - 1;
            for (int i = 0; i <= iMax; ++i) {
                samples.Add((uint)i);
            }
            if (bitClamped < bitCount) {
                for (int i = bitClamped; i < bitCount; ++i) {
                    iMax <<= 1;
                    samples.Add((uint)iMax);
                }
            }
            // run.
            foreach (uint value in samples) {
                Vector512<byte> expected = Vector512s.YBitToByte(value);
                //Console.WriteLine(VectorTextUtil.Format("YBitToByte({0}):\t{1}", value, expected));
                foreach (IWVectorTraits512 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector512<byte> dst = instance.YBitToByte(value);
                    Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                }
                foreach (var func in funcList) {
                    string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                    Vector512<byte> dst = func(value);
                    Assert.AreEqual(expected, dst, $"{funcName}, value={value}");
                    Assert.AreEqual(expected, dst, VectorTextUtil.Format("{0}, value={1}", funcName, value));
                    //Console.WriteLine(VectorTextUtil.Format("{2}({0}):\t{1}", value, expected, funcName));
                }
            }
        }

        [TestCase]
        public void YBitToInt16Test() {
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.YBitToInt16_IsAccelerated}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // samples.
            List<uint> samples = new List<uint>();
            int bitCount = Vector512<short>.Count;
            int bitClamped = Math.Min(bitCount, 4);
            int iMax = (1 << bitClamped) - 1;
            for (int i = 0; i <= iMax; ++i) {
                samples.Add((uint)i);
            }
            if (bitClamped < bitCount) {
                for (int i = bitClamped; i < bitCount; ++i) {
                    iMax <<= 1;
                    samples.Add((uint)iMax);
                }
            }
            // run.
            foreach (uint value in samples) {
                Vector512<short> expected = Vector512s.YBitToInt16(value);
                //Console.WriteLine(VectorTextUtil.Format("YBitToInt16({0}):\t{1}", value, expected));
                foreach (IWVectorTraits512 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector512<short> dst = instance.YBitToInt16(value);
                    Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                }
            }
        }

        [TestCase]
        public void YBitToInt32Test() {
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.YBitToInt32_IsAccelerated}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // samples.
            List<uint> samples = new List<uint>();
            int bitCount = Vector512<int>.Count;
            int bitClamped = Math.Min(bitCount, 4);
            int iMax = (1 << bitClamped) - 1;
            for (int i = 0; i <= iMax; ++i) {
                samples.Add((uint)i);
            }
            if (bitClamped < bitCount) {
                for (int i = bitClamped; i < bitCount; ++i) {
                    iMax <<= 1;
                    samples.Add((uint)iMax);
                }
            }
            // run.
            foreach (uint value in samples) {
                Vector512<int> expected = Vector512s.YBitToInt32(value);
                //Console.WriteLine(VectorTextUtil.Format("YBitToInt32({0}):\t{1}", value, expected));
                foreach (IWVectorTraits512 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector512<int> dst = instance.YBitToInt32(value);
                    Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                }
            }
        }

        [TestCase]
        public void YBitToInt64Test() {
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.YBitToInt64_IsAccelerated}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // samples.
            List<uint> samples = new List<uint>();
            int bitCount = Vector512<long>.Count;
            int bitClamped = Math.Min(bitCount, 4);
            int iMax = (1 << bitClamped) - 1;
            for (int i = 0; i <= iMax; ++i) {
                samples.Add((uint)i);
            }
            if (bitClamped < bitCount) {
                for (int i = bitClamped; i < bitCount; ++i) {
                    iMax <<= 1;
                    samples.Add((uint)iMax);
                }
            }
            // run.
            foreach (uint value in samples) {
                Vector512<long> expected = Vector512s.YBitToInt64(value);
                //Console.WriteLine(VectorTextUtil.Format("YBitToInt64({0}):\t{1}", value, expected));
                foreach (IWVectorTraits512 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector512<long> dst = instance.YBitToInt64(value);
                    Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                }
            }
        }

#endif
    }
}
