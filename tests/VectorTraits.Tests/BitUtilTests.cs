using NUnit.Framework;
using Zyl.VectorTraits;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zyl.VectorTraits.Tests {
    [TestFixture()]
    public class BitUtilTests {
        [Test()]
        public void SingleToInt32BitsTest() {
            int n = BitUtil.SingleToInt32Bits((float)1);
            Assert.AreNotEqual(0, n);
        }

        [TestCase((float)1)]
        [TestCase((double)2)]
        [TestCase((sbyte)3)]
        [TestCase((byte)4)]
        [TestCase((short)5)]
        [TestCase((ushort)6)]
        [TestCase((int)7)]
        [TestCase((uint)8)]
        [TestCase((long)9)]
        [TestCase((ulong)10)]
        public void ConditionalSelectTest<T>(T src) where T : struct {
            T[] samples = new T[10];
            samples[0] = src;
            for (int i = 1; i < samples.Length; ++i) {
                samples[1] = Scalars.GetByDouble<T>(i - 1);
            }
            // run.
            for (int i = 1; i < samples.Length; ++i) {
                for (int j = 1; j < samples.Length; ++j) {
                    T baseline;
                    T dst;
                    if (typeof(T) == typeof(sbyte)) {
                        baseline = (T)(object)Math.Min((sbyte)i, (sbyte)j);
                        dst = (T)(object)BitUtil.ConditionalSelect(i < j, (sbyte)i, (sbyte)j);
                    } else if (typeof(T) == typeof(byte)) {
                        baseline = (T)(object)Math.Min((byte)i, (byte)j);
                        dst = (T)(object)BitUtil.ConditionalSelect(i < j, (byte)i, (byte)j);
                    } else if (typeof(T) == typeof(short)) {
                        baseline = (T)(object)Math.Min((short)i, (short)j);
                        dst = (T)(object)BitUtil.ConditionalSelect(i < j, (short)i, (short)j);
                    } else if (typeof(T) == typeof(ushort)) {
                        baseline = (T)(object)Math.Min((ushort)i, (ushort)j);
                        dst = (T)(object)BitUtil.ConditionalSelect(i < j, (ushort)i, (ushort)j);
                    } else if (typeof(T) == typeof(uint)) {
                        baseline = (T)(object)Math.Min((uint)i, (uint)j);
                        dst = (T)(object)BitUtil.ConditionalSelect(i < j, (uint)i, (uint)j);
                    } else if (typeof(T) == typeof(ulong)) {
                        baseline = (T)(object)Math.Min((ulong)i, (ulong)j);
                        dst = (T)(object)BitUtil.ConditionalSelect(i < j, (ulong)i, (ulong)j);
                    } else {
                        baseline = Math.Min((dynamic)i, (dynamic)j);
                        dst = BitUtil.ConditionalSelect(i < j, (dynamic)i, (dynamic)j);
                    }
                    Assert.AreEqual(baseline, dst, $"{i} < {j}");
                }
            }
        }

    }
}