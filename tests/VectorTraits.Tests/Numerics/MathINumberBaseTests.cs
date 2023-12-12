using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Zyl.VectorTraits;
using Zyl.VectorTraits.Numerics;

namespace Zyl.VectorTraits.Tests.Numerics {
    internal class MathINumberBaseTests {

        [TestCase((float)1)]
        [TestCase((double)2)]
        public void IsFiniteTest<T>(T src) where T : struct {
            T[] samples = new T[8];
            samples[0] = default;
            samples[1] = Scalars<T>.NegativeZero;
            samples[2] = src;
            samples[3] = Scalars<T>.MaxValue;
            samples[4] = Scalars<T>.MinValue;
            samples[5] = Scalars<T>.PositiveInfinity;
            samples[6] = Scalars<T>.NegativeInfinity;
            samples[7] = Scalars<T>.NaN;
            // run.
            bool allowLog = false;
            for (int i = 0; i < samples.Length; ++i) {
                T x = samples[i];
                bool expected = BitMath.IsFinite((dynamic)x);
                if (allowLog) {
                    Console.WriteLine("IsFinite({0}):\t{1}", x, expected);
                }
                // IsFinite_Bit.
                bool dst = MathINumberBase.IsFinite_Bit((dynamic)x);
                Assert.AreEqual(expected, dst, string.Format("IsFinite_Bit({0})", x));
                // IsFinite_Bcl.
#if NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                dst = MathINumberBase.IsFinite_Bcl((dynamic)x);
                Assert.AreEqual(expected, dst, string.Format("IsFinite_Bcl({0})", x));
#endif // NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
            }
        }

        [TestCase((float)1)]
        [TestCase((double)2)]
        public void IsInfinityTest<T>(T src) where T : struct {
            T[] samples = new T[8];
            samples[0] = default;
            samples[1] = Scalars<T>.NegativeZero;
            samples[2] = src;
            samples[3] = Scalars<T>.MaxValue;
            samples[4] = Scalars<T>.MinValue;
            samples[5] = Scalars<T>.PositiveInfinity;
            samples[6] = Scalars<T>.NegativeInfinity;
            samples[7] = Scalars<T>.NaN;
            // run.
            bool allowLog = false;
            for (int i = 0; i < samples.Length; ++i) {
                T x = samples[i];
                bool expected = BitMath.IsInfinity((dynamic)x);
                if (allowLog) {
                    Console.WriteLine("IsInfinity({0}):\t{1}", x, expected);
                }
                // IsInfinity_Bit.
                bool dst = MathINumberBase.IsInfinity_Bit((dynamic)x);
                Assert.AreEqual(expected, dst, string.Format("IsInfinity_Bit({0})", x));
                // IsInfinity_Bcl.
#if NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                dst = MathINumberBase.IsInfinity_Bcl((dynamic)x);
                Assert.AreEqual(expected, dst, string.Format("IsInfinity_Bcl({0})", x));
#endif // NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
            }
        }

        [TestCase((float)1)]
        [TestCase((double)2)]
        public void IsInfinityOrNaNTest<T>(T src) where T : struct {
            T[] samples = new T[8];
            samples[0] = default;
            samples[1] = Scalars<T>.NegativeZero;
            samples[2] = src;
            samples[3] = Scalars<T>.MaxValue;
            samples[4] = Scalars<T>.MinValue;
            samples[5] = Scalars<T>.PositiveInfinity;
            samples[6] = Scalars<T>.NegativeInfinity;
            samples[7] = Scalars<T>.NaN;
            // run.
            bool allowLog = false;
            for (int i = 0; i < samples.Length; ++i) {
                T x = samples[i];
                bool expected = BitMath.IsInfinityOrNaN((dynamic)x);
                if (allowLog) {
                    Console.WriteLine("IsInfinityOrNaN({0}):\t{1}", x, expected);
                }
                // IsInfinityOrNaN_Bit.
                bool dst = MathINumberBase.IsInfinityOrNaN_Bit((dynamic)x);
                Assert.AreEqual(expected, dst, string.Format("IsInfinityOrNaN_Bit({0})", x));
                // IsInfinityOrNaN_Bcl.
#if NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                dst = MathINumberBase.IsInfinityOrNaN_Bcl((dynamic)x);
                Assert.AreEqual(expected, dst, string.Format("IsInfinityOrNaN_Bcl({0})", x));
#endif // NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
            }
        }

        [TestCase((float)1)]
        [TestCase((double)2)]
        public void IsIntegerTest<T>(T src) where T : struct {
            T[] samples = new T[12];
            samples[0] = default;
            samples[1] = Scalars<T>.NegativeZero;
            samples[2] = src;
            samples[3] = Scalars<T>.MaxValue;
            samples[4] = Scalars<T>.MinValue;
            samples[5] = Scalars<T>.PositiveInfinity;
            samples[6] = Scalars<T>.NegativeInfinity;
            samples[7] = Scalars<T>.NaN;
            samples[8] = Scalars<T>.V1;
            samples[9] = Scalars<T>.V2;
            samples[10] = Scalars<T>.V_1;
            samples[11] = Scalars<T>.V_2;
            // run.
            bool allowLog = false;
            for (int i = 0; i < samples.Length; ++i) {
                T x = samples[i];
                bool expected = BitMath.IsInteger((dynamic)x);
                if (allowLog) {
                    Console.WriteLine("IsInteger({0}):\t{1}", x, expected);
                }
                // IsInteger_Bit.
                bool dst = MathINumberBase.IsInteger_Bit((dynamic)x);
                Assert.AreEqual(expected, dst, string.Format("IsInteger_Bit({0})", x));
                // IsInteger_Bcl.
#if NET7_0_OR_GREATER
                dst = MathINumberBase.IsInteger_Bcl((dynamic)x);
                Assert.AreEqual(expected, dst, string.Format("IsInteger_Bcl({0})", x));
#endif // NET7_0_OR_GREATER
            }
        }

        [TestCase((float)1)]
        [TestCase((double)2)]
        public void IsNaNTest<T>(T src) where T : struct {
            T[] samples = new T[8];
            samples[0] = default;
            samples[1] = Scalars<T>.NegativeZero;
            samples[2] = src;
            samples[3] = Scalars<T>.MaxValue;
            samples[4] = Scalars<T>.MinValue;
            samples[5] = Scalars<T>.PositiveInfinity;
            samples[6] = Scalars<T>.NegativeInfinity;
            samples[7] = Scalars<T>.NaN;
            // run.
            bool allowLog = false;
            for (int i = 0; i < samples.Length; ++i) {
                T x = samples[i];
                bool expected = BitMath.IsNaN((dynamic)x);
                if (allowLog) {
                    Console.WriteLine("IsNaN({0}):\t{1}", x, expected);
                }
                // IsNaN_Bit.
                bool dst = MathINumberBase.IsNaN_Bit((dynamic)x);
                Assert.AreEqual(expected, dst, string.Format("IsNaN_Bit({0})", x));
                // IsNaN_Bcl.
                dst = MathINumberBase.IsNaN_Bcl((dynamic)x);
                Assert.AreEqual(expected, dst, string.Format("IsNaN_Bcl({0})", x));
            }
        }

        [TestCase((float)1)]
        [TestCase((double)2)]
        [TestCase((sbyte)3)]
        [TestCase((short)5)]
        [TestCase((int)7)]
        [TestCase((long)9)]
        public void IsNegativeTest<T>(T src) where T : struct {
            T[] samples = new T[8];
            samples[0] = default;
            samples[1] = Scalars<T>.NegativeZero;
            samples[2] = src;
            samples[3] = Scalars<T>.MaxValue;
            samples[4] = Scalars<T>.MinValue;
            samples[5] = Scalars<T>.PositiveInfinity;
            samples[6] = Scalars<T>.NegativeInfinity;
            samples[7] = Scalars<T>.NaN;
            // run.
            bool allowLog = false;
            for (int i = 0; i < samples.Length; ++i) {
                T x = samples[i];
                bool expected = BitMath.IsNegative((dynamic)x);
                if (allowLog) {
                    Console.WriteLine("IsNegative({0}):\t{1}", x, expected);
                }
                // IsNegative_Bit.
                bool dst = MathINumberBase.IsNegative_Bit((dynamic)x);
                Assert.AreEqual(expected, dst, string.Format("IsNegative_Bit({0})", x));
                // IsNegative_Bcl.
#if NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                dst = MathINumberBase.IsNegative_Bcl((dynamic)x);
                Assert.AreEqual(expected, dst, string.Format("IsNegative_Bcl({0})", x));
#endif // NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
            }
        }

        [TestCase((float)1)]
        [TestCase((double)2)]
        public void IsNegativeInfinityTest<T>(T src) where T : struct {
            T[] samples = new T[8];
            samples[0] = default;
            samples[1] = Scalars<T>.NegativeZero;
            samples[2] = src;
            samples[3] = Scalars<T>.MaxValue;
            samples[4] = Scalars<T>.MinValue;
            samples[5] = Scalars<T>.PositiveInfinity;
            samples[6] = Scalars<T>.NegativeInfinity;
            samples[7] = Scalars<T>.NaN;
            // run.
            bool allowLog = false;
            for (int i = 0; i < samples.Length; ++i) {
                T x = samples[i];
                bool expected = BitMath.IsNegativeInfinity((dynamic)x);
                if (allowLog) {
                    Console.WriteLine("IsNegativeInfinity({0}):\t{1}", x, expected);
                }
                // IsNegativeInfinity_Bit.
                bool dst = MathINumberBase.IsNegativeInfinity_Bit((dynamic)x);
                Assert.AreEqual(expected, dst, string.Format("IsNegativeInfinity_Bit({0})", x));
                // IsNegativeInfinity_Bcl.
                dst = MathINumberBase.IsNegativeInfinity_Bcl((dynamic)x);
                Assert.AreEqual(expected, dst, string.Format("IsNegativeInfinity_Bcl({0})", x));
            }
        }

        [TestCase((float)1)]
        [TestCase((double)2)]
        public void IsNormalTest<T>(T src) where T : struct {
            T[] samples = new T[8];
            samples[0] = default;
            samples[1] = Scalars<T>.NegativeZero;
            samples[2] = src;
            samples[3] = Scalars<T>.MaxValue;
            samples[4] = Scalars<T>.MinValue;
            samples[5] = Scalars<T>.PositiveInfinity;
            samples[6] = Scalars<T>.NegativeInfinity;
            samples[7] = Scalars<T>.NaN;
            // run.
            bool allowLog = false;
            for (int i = 0; i < samples.Length; ++i) {
                T x = samples[i];
                bool expected = BitMath.IsNormal((dynamic)x);
                if (allowLog) {
                    Console.WriteLine("IsNormal({0}):\t{1}", x, expected);
                }
                // IsNormal_Bit.
                bool dst = MathINumberBase.IsNormal_Bit((dynamic)x);
                Assert.AreEqual(expected, dst, string.Format("IsNormal_Bit({0})", x));
                // IsNormal_Bcl.
#if NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                dst = MathINumberBase.IsNormal_Bcl((dynamic)x);
                Assert.AreEqual(expected, dst, string.Format("IsNormal_Bcl({0})", x));
#endif // NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
            }
        }

    }
}
