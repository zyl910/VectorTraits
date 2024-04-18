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
using Zyl.VectorTraits.Impl.AVector128;

namespace Zyl.VectorTraits.Tests.Impl.IWVectorTraits128Test {
#if USED_NUNIT3
    using ClassicAssert = Assert;
#endif

    [TestFixture()]
    public class Vector128Tests_YB {
#if NETCOREAPP3_0_OR_GREATER


        [TestCase]
        public void YBitToByteTest() {
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.YBitToByte_IsAccelerated}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector128s.GetSupportedMethodList<Func<uint, Vector128<byte>>>("YBitToByte_Basic", "YBitToByte_Shuffle", "YBitToByte_Widen");
            foreach (var func in funcList) {
                Console.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            // samples.
            List<uint> samples = new List<uint>();
            int bitCount = Vector128<byte>.Count;
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
                Vector128<byte> expected = Vector128s.YBitToByte(value);
                //Console.WriteLine(VectorTextUtil.Format("YBitToByte({0}):\t{1}", value, expected));
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<byte> dst = instance.YBitToByte(value);
                    ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                }
                foreach (var func in funcList) {
                    string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                    Vector128<byte> dst = func(value);
                    ClassicAssert.AreEqual(expected, dst, $"{funcName}, value={value}");
                    ClassicAssert.AreEqual(expected, dst, VectorTextUtil.Format("{0}, value={1}", funcName, value));
                    //Console.WriteLine(VectorTextUtil.Format("{2}({0}):\t{1}", value, expected, funcName));
                }
            }
        }

        [TestCase]
        public void YBitToInt16Test() {
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.YBitToInt16_IsAccelerated}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // samples.
            List<uint> samples = new List<uint>();
            int bitCount = Vector128<short>.Count;
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
                Vector128<short> expected = Vector128s.YBitToInt16(value);
                //Console.WriteLine(VectorTextUtil.Format("YBitToInt16({0}):\t{1}", value, expected));
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<short> dst = instance.YBitToInt16(value);
                    ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                }
            }
        }

        [TestCase]
        public void YBitToInt32Test() {
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.YBitToInt32_IsAccelerated}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // samples.
            List<uint> samples = new List<uint>();
            int bitCount = Vector128<int>.Count;
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
                Vector128<int> expected = Vector128s.YBitToInt32(value);
                //Console.WriteLine(VectorTextUtil.Format("YBitToInt32({0}):\t{1}", value, expected));
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<int> dst = instance.YBitToInt32(value);
                    ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                }
            }
        }

        [TestCase]
        public void YBitToInt64Test() {
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.YBitToInt64_IsAccelerated}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // samples.
            List<uint> samples = new List<uint>();
            int bitCount = Vector128<long>.Count;
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
                Vector128<long> expected = Vector128s.YBitToInt64(value);
                //Console.WriteLine(VectorTextUtil.Format("YBitToInt64({0}):\t{1}", value, expected));
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector128<long> dst = instance.YBitToInt64(value);
                    ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, value={value}");
                }
            }
        }

#endif
    }
}
