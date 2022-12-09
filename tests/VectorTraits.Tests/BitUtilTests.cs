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
                samples[i] = Scalars.GetByDouble<T>(i - 1);
            }
            // run.
            for (int i = 1; i < samples.Length; ++i) {
                T left = samples[i];
                for (int j = 1; j < samples.Length; ++j) {
                    T right = samples[j];
                    T baseline;
                    T dst;
                    baseline = Math.Min((dynamic)left, (dynamic)right);
                    dst = BitUtil.ConditionalSelect((dynamic)left < (dynamic)right, (dynamic)left, (dynamic)right);
                    Assert.AreEqual(baseline, dst, $"{left} < {right}");
                    //Console.WriteLine($"{left} < {right}: {baseline}");
                }
            }
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
        public void ClampTest<T>(T src) where T : struct {
            int nmin = 1;
            int nmax = 8;
            T amin = Scalars.GetByDouble<T>(nmin);
            T amax = Scalars.GetByDouble<T>(nmax);
            T[] samples = new T[12];
            samples[0] = src;
            for (int i = 1; i < samples.Length; ++i) {
                samples[i] = Scalars.GetByDouble<T>(i - 1);
            }
            // run.
            for (int i = 1; i < samples.Length; ++i) {
                T value = samples[i];
                T baseline;
#if NETCOREAPP2_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                baseline = Math.Clamp((dynamic)value, (dynamic)amin, (dynamic)amax);
#else
                baseline = Math.Min(Math.Max((dynamic)value, (dynamic)amin), (dynamic)amax);
#endif
                T dst = BitUtil.Clamp((dynamic)value, (dynamic)amin, (dynamic)amax);
                Assert.AreEqual(baseline, dst, $"{value}, [{amin}, {nmax}]");
            }
        }

        [TestCase((int)7)]
        [TestCase((uint)8)]
        [TestCase((long)9)]
        [TestCase((ulong)10)]
        public void ClampToBitMaxTest<T>(T src) where T : struct {
            int nmin = 0;
            int nmax = 7; // Pow(2, 3)-1.
            T amin = Scalars.GetByDouble<T>(nmin);
            T amax = Scalars.GetByDouble<T>(nmax);
            T[] samples = new T[12];
            samples[0] = src;
            for (int i = 1; i < samples.Length; ++i) {
                samples[i] = Scalars.GetByDouble<T>(i - 1);
            }
            // run.
            for (int i = 1; i < samples.Length; ++i) {
                T value = samples[i];
                T baseline;
#if NETCOREAPP2_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                baseline = Math.Clamp((dynamic)value, (dynamic)amin, (dynamic)amax);
#else
                baseline = Math.Min(Math.Max((dynamic)value, (dynamic)amin), (dynamic)amax);
#endif
                T dst = BitUtil.ClampToBitMax((dynamic)value, (dynamic)amax);
                Assert.AreEqual(baseline, dst, $"{value}, [{amin}, {nmax}]");
            }
        }

        [TestCase((int)7)]
        [TestCase((uint)8)]
        [TestCase((long)9)]
        [TestCase((ulong)10)]
        public void ClampToByteTest<T>(T src) where T : struct {
            int nmin = 0;
            int nmax = byte.MaxValue;
            T amin = Scalars.GetByDouble<T>(nmin);
            T amax = Scalars.GetByDouble<T>(nmax);
            T[] samples = new T[20];
            samples[0] = src;
            for (int i = 1; i < samples.Length; ++i) {
                samples[i] = Scalars.GetByDouble<T>(i - 10);
            }
            // run.
            for (int i = 1; i < samples.Length; ++i) {
                T value = samples[i];
                byte baseline;
#if NETCOREAPP2_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                baseline = (byte)Math.Clamp((dynamic)value, (dynamic)amin, (dynamic)amax);
#else
                baseline = (byte)Math.Min(Math.Max((dynamic)value, (dynamic)amin), (dynamic)amax);
#endif
                byte dst = BitUtil.ClampToByte((dynamic)value);
                Assert.AreEqual(baseline, dst, $"{value}, [{amin}, {nmax}]");
            }
        }

    }
}