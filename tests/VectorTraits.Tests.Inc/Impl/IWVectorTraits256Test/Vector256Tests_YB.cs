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
using Zyl.VectorTraits.Impl.AVector256;

namespace Zyl.VectorTraits.Tests.Impl.IWVectorTraits256Test {
#if USED_NUNIT3
    using ClassicAssert = Assert;
#endif

    [TestFixture()]
    public class Vector256Tests_YB {
#if NETCOREAPP3_0_OR_GREATER


        [TestCase]
        public void YBitToByteTest() {
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.YBitToByte_IsAccelerated}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector256s.GetSupportedMethodList<Func<uint, Vector256<byte>>>("YBitToByte_Basic", "YBitToByte_Shuffle", "YBitToByte_Widen");
            foreach (var func in funcList) {
                Console.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            // samples.
            List<uint> samples = new List<uint>();
            int bitCount = Vector256<byte>.Count;
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
                Vector256<byte> expected = Vector256s.YBitToByte(value);
                //Console.WriteLine(VectorTextUtil.Format("YBitToByte({0}):\t{1}", value, expected));
                foreach (IWVectorTraits256 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector256<byte> dst = instance.YBitToByte(value);
                    ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                }
                foreach (var func in funcList) {
                    string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                    Vector256<byte> dst = func(value);
                    ClassicAssert.AreEqual(expected, dst, $"{funcName}, value={value}");
                    ClassicAssert.AreEqual(expected, dst, VectorTextUtil.Format("{0}, value={1}", funcName, value));
                    //Console.WriteLine(VectorTextUtil.Format("{2}({0}):\t{1}", value, expected, funcName));
                }
            }
        }

        [TestCase]
        public void YBitToInt16Test() {
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.YBitToInt16_IsAccelerated}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // samples.
            List<uint> samples = new List<uint>();
            int bitCount = Vector256<short>.Count;
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
                Vector256<short> expected = Vector256s.YBitToInt16(value);
                //Console.WriteLine(VectorTextUtil.Format("YBitToInt16({0}):\t{1}", value, expected));
                foreach (IWVectorTraits256 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector256<short> dst = instance.YBitToInt16(value);
                    ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                }
            }
        }

        [TestCase]
        public void YBitToInt32Test() {
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.YBitToInt32_IsAccelerated}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // samples.
            List<uint> samples = new List<uint>();
            int bitCount = Vector256<int>.Count;
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
                Vector256<int> expected = Vector256s.YBitToInt32(value);
                //Console.WriteLine(VectorTextUtil.Format("YBitToInt32({0}):\t{1}", value, expected));
                foreach (IWVectorTraits256 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector256<int> dst = instance.YBitToInt32(value);
                    ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                }
            }
        }

        [TestCase]
        public void YBitToInt64Test() {
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.YBitToInt64_IsAccelerated}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // samples.
            List<uint> samples = new List<uint>();
            int bitCount = Vector256<long>.Count;
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
                Vector256<long> expected = Vector256s.YBitToInt64(value);
                //Console.WriteLine(VectorTextUtil.Format("YBitToInt64({0}):\t{1}", value, expected));
                foreach (IWVectorTraits256 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector256<long> dst = instance.YBitToInt64(value);
                    ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                }
            }
        }

#endif
    }
}
