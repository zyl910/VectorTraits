using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Zyl.VectorTraits;
using Zyl.VectorTraits.Numerics;

namespace Zyl.VectorTraits.Tests.Numerics {
    [TestFixture()]
    internal class MathINumberTests {

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
                T dst = MathINumber.Clamp((dynamic)value, (dynamic)amin, (dynamic)amax);
                Assert.AreEqual(expected, dst, $"{value}, [{amin}, {nmax}]");
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
                    dst = MathINumber.Max((dynamic)left, (dynamic)right);
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
                    dst = MathINumber.Min((dynamic)left, (dynamic)right);
                    Assert.AreEqual(expected, dst, $"{left} < {right}");
                    //Console.WriteLine($"{left} < {right}: {expected}");
                }
            }
        }

    }
}
