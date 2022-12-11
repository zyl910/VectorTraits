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

        [Test()]
        public void GetByteByBit2Test() {
            for (byte n3 = 0; n3 <= 3; ++n3) {
                for (byte n2 = 0; n2 <= 3; ++n2) {
                    for (byte n1 = 0; n1 <= 3; ++n1) {
                        for (byte n0 = 0; n0 <= 3; ++n0) {
                            byte dst = BitUtil.GetByteByBit2(n3, n2, n1, n0);
                            Console.WriteLine($"GetByteByBit2({n3}, {n2}, {n1}, {n0}) = 0x{dst:X2}\t// {dst}");
                        }
                    }
                }
            }
        }

        [Test()]
        public void GetByteByBit2RTest() {
            for (byte n3 = 0; n3 <= 3; ++n3) {
                for (byte n2 = 0; n2 <= 3; ++n2) {
                    for (byte n1 = 0; n1 <= 3; ++n1) {
                        for (byte n0 = 0; n0 <= 3; ++n0) {
                            byte expected = BitUtil.GetByteByBit2(n3, n2, n1, n0);
                            byte dst = BitUtil.GetByteByBit2R(n0, n1, n2, n3);
                            Assert.AreEqual(expected, dst, $"({n0}, {n1}, {n2}, {n3})");
                            //Console.WriteLine($"GetByteByBit2R({n0}, {n1}, {n2}, {n3}) = 0x{dst:X2}\t// {dst}");
                        }
                    }
                }
            }
        }

        [Test()]
        public void GetByteByBit4Test() {
            for (byte n1 = 0; n1 <= 15; ++n1) {
                for (byte n0 = 0; n0 <= 15; ++n0) {
                    byte dst = BitUtil.GetByteByBit4(n1, n0);
                    Console.WriteLine($"GetByteByBit4({n1}, {n0}) = 0x{dst:X2}\t// {dst}");
                }
            }
        }

        [Test()]
        public void GetByteByBit4RTest() {
            for (byte n1 = 0; n1 <= 15; ++n1) {
                for (byte n0 = 0; n0 <= 15; ++n0) {
                    byte expected = BitUtil.GetByteByBit4(n1, n0);
                    byte dst = BitUtil.GetByteByBit4R(n0, n1);
                    //Console.WriteLine($"GetByteByBit4R({n0}, {n1}) = 0x{dst:X2}\t// {dst}");
                }
            }
        }

        [Test()]
        public void _MM_SHUFFLETest() {
            for (byte n3 = 0; n3 <= 3; ++n3) {
                for (byte n2 = 0; n2 <= 3; ++n2) {
                    for (byte n1 = 0; n1 <= 3; ++n1) {
                        for (byte n0 = 0; n0 <= 3; ++n0) {
                            byte dst = BitUtil._MM_SHUFFLE(n3, n2, n1, n0);
                            Console.WriteLine($"_MM_SHUFFLE({n3}, {n2}, {n1}, {n0}) = 0x{dst:X2}\t// {dst}");
                        }
                    }
                }
            }
        }

        [Test()]
        public void _MM_SHUFFLE2Test() {
            for (byte n1 = 0; n1 <= 1; ++n1) {
                for (byte n0 = 0; n0 <= 1; ++n0) {
                    byte dst = BitUtil._MM_SHUFFLE2(n1, n0);
                    Console.WriteLine($"_MM_SHUFFLE2({n1}, {n0}) = 0x{dst:X2}\t// {dst}");
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
                    T expected;
                    T dst;
                    expected = Math.Min((dynamic)left, (dynamic)right);
                    dst = BitUtil.ConditionalSelect((dynamic)left < (dynamic)right, (dynamic)left, (dynamic)right);
                    Assert.AreEqual(expected, dst, $"{left} < {right}");
                    //Console.WriteLine($"{left} < {right}: {expected}");
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
        public void MinTest<T>(T src) where T : struct {
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
                    T expected;
                    T dst;
                    expected = Math.Min((dynamic)left, (dynamic)right);
                    dst = BitUtil.Min((dynamic)left, (dynamic)right);
                    Assert.AreEqual(expected, dst, $"{left} < {right}");
                    //Console.WriteLine($"{left} < {right}: {expected}");
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
        public void MaxTest<T>(T src) where T : struct {
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
                    T expected;
                    T dst;
                    expected = Math.Max((dynamic)left, (dynamic)right);
                    dst = BitUtil.Max((dynamic)left, (dynamic)right);
                    Assert.AreEqual(expected, dst, $"{left} < {right}");
                    //Console.WriteLine($"{left} < {right}: {expected}");
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
                T expected;
#if NETCOREAPP2_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                expected = Math.Clamp((dynamic)value, (dynamic)amin, (dynamic)amax);
#else
                expected = Math.Min(Math.Max((dynamic)value, (dynamic)amin), (dynamic)amax);
#endif
                T dst = BitUtil.Clamp((dynamic)value, (dynamic)amin, (dynamic)amax);
                Assert.AreEqual(expected, dst, $"{value}, [{amin}, {nmax}]");
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
                T expected;
#if NETCOREAPP2_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                expected = Math.Clamp((dynamic)value, (dynamic)amin, (dynamic)amax);
#else
                expected = Math.Min(Math.Max((dynamic)value, (dynamic)amin), (dynamic)amax);
#endif
                T dst = BitUtil.ClampToBitMax((dynamic)value, (dynamic)amax);
                Assert.AreEqual(expected, dst, $"{value}, [{amin}, {nmax}]");
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
                byte expected;
#if NETCOREAPP2_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                expected = (byte)Math.Clamp((dynamic)value, (dynamic)amin, (dynamic)amax);
#else
                expected = (byte)Math.Min(Math.Max((dynamic)value, (dynamic)amin), (dynamic)amax);
#endif
                byte dst = BitUtil.ClampToByte((dynamic)value);
                Assert.AreEqual(expected, dst, $"{value}, [{amin}, {nmax}]");
            }
        }

    }
}