using NUnit.Framework;
#if !USED_NUNIT3
using NUnit.Framework.Legacy;
#endif
using System;
using System.Collections.Generic;
using System.Text;
using Zyl.VectorTraits;
using Zyl.VectorTraits.Numerics;

namespace Zyl.VectorTraits.Tests.Numerics {
#if USED_NUNIT3
    using ClassicAssert = Assert;
#endif

    [TestFixture()]
    internal class MathINumberBaseTests {

        [TestCase((sbyte)3)]
        [TestCase((short)5)]
        [TestCase((int)7)]
        [TestCase((long)9)]
        public void AbsTest<T>(T src) where T : struct {
            T[] samples = new T[10];
            samples[0] = default;
            samples[1] = src;
            samples[2] = Scalars<T>.MinValue;
            samples[3] = Scalars<T>.MaxValue;
            for (int i = 4; i < samples.Length; ++i) {
                samples[i] = Scalars.GetByDouble<T>(-i);
            }
            // run.
            for (int i = 0; i < samples.Length; ++i) {
                T x = samples[i];
                T dst = MathINumberBase.Abs((dynamic)x);
                T expected = default;
                bool expectedError = false;
                try {
                    expected = Math.Abs((dynamic)x);
                } catch (Exception) {
                    expectedError = true;
                }
                if (expectedError) {
                    Console.WriteLine("Abs({0}):\t{1}", x, dst);
                } else {
                    ClassicAssert.AreEqual(expected, dst, string.Format("Abs({0})", x));
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
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseHalf))]
        public void IsEvenIntegerTest<T>(T src) where T : struct {
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
                bool expected = BitMath.IsEvenInteger((dynamic)x);
                if (allowLog) {
                    Console.WriteLine("IsEvenInteger({0}):\t{1}", x, expected);
                }
                // IsEvenInteger_Bit.
                bool dst = MathINumberBase.IsEvenInteger_Bit((dynamic)x);
                ClassicAssert.AreEqual(expected, dst, string.Format("IsEvenInteger_Bit({0})", x));
                // IsEvenInteger_Bcl.
#if NET7_0_OR_GREATER
                dst = MathINumberBase.IsEvenInteger_Bcl((dynamic)x);
                ClassicAssert.AreEqual(expected, dst, string.Format("IsEvenInteger_Bcl({0})", x));
#endif // NET7_0_OR_GREATER
            }
        }

        [TestCase((float)1)]
        [TestCase((double)2)]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseHalf))]
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
                ClassicAssert.AreEqual(expected, dst, string.Format("IsFinite_Bit({0})", x));
                // IsFinite_Bcl.
#if NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                dst = MathINumberBase.IsFinite_Bcl((dynamic)x);
                ClassicAssert.AreEqual(expected, dst, string.Format("IsFinite_Bcl({0})", x));
#endif // NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
            }
        }

        [TestCase((float)1)]
        [TestCase((double)2)]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseHalf))]
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
                ClassicAssert.AreEqual(expected, dst, string.Format("IsInfinity_Bit({0})", x));
                // IsInfinity_Bcl.
#if NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                dst = MathINumberBase.IsInfinity_Bcl((dynamic)x);
                ClassicAssert.AreEqual(expected, dst, string.Format("IsInfinity_Bcl({0})", x));
#endif // NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
            }
        }

        [TestCase((float)1)]
        [TestCase((double)2)]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseHalf))]
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
                ClassicAssert.AreEqual(expected, dst, string.Format("IsInfinityOrNaN_Bit({0})", x));
                // IsInfinityOrNaN_Bcl.
#if NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                dst = MathINumberBase.IsInfinityOrNaN_Bcl((dynamic)x);
                ClassicAssert.AreEqual(expected, dst, string.Format("IsInfinityOrNaN_Bcl({0})", x));
#endif // NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
            }
        }

        [TestCase((float)1)]
        [TestCase((double)2)]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseHalf))]
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
                ClassicAssert.AreEqual(expected, dst, string.Format("IsInteger_Bit({0})", x));
                // IsInteger_Bcl.
#if NET7_0_OR_GREATER
                dst = MathINumberBase.IsInteger_Bcl((dynamic)x);
                ClassicAssert.AreEqual(expected, dst, string.Format("IsInteger_Bcl({0})", x));
#endif // NET7_0_OR_GREATER
            }
        }

        [TestCase((float)1)]
        [TestCase((double)2)]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseHalf))]
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
                ClassicAssert.AreEqual(expected, dst, string.Format("IsNaN_Bit({0})", x));
                // IsNaN_Bcl.
                dst = MathINumberBase.IsNaN_Bcl((dynamic)x);
                ClassicAssert.AreEqual(expected, dst, string.Format("IsNaN_Bcl({0})", x));
            }
        }

        [TestCase((float)1)]
        [TestCase((double)2)]
        [TestCase((sbyte)3)]
        [TestCase((short)5)]
        [TestCase((int)7)]
        [TestCase((long)9)]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseHalf))]
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
                ClassicAssert.AreEqual(expected, dst, string.Format("IsNegative_Bit({0})", x));
                // IsNegative_Bcl.
#if NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                dst = MathINumberBase.IsNegative_Bcl((dynamic)x);
                ClassicAssert.AreEqual(expected, dst, string.Format("IsNegative_Bcl({0})", x));
#endif // NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
            }
        }

        [TestCase((float)1)]
        [TestCase((double)2)]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseHalf))]
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
                ClassicAssert.AreEqual(expected, dst, string.Format("IsNegativeInfinity_Bit({0})", x));
                // IsNegativeInfinity_Bcl.
                dst = MathINumberBase.IsNegativeInfinity_Bcl((dynamic)x);
                ClassicAssert.AreEqual(expected, dst, string.Format("IsNegativeInfinity_Bcl({0})", x));
            }
        }

        [TestCase((float)1)]
        [TestCase((double)2)]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseHalf))]
        public void IsNegativeZeroTest<T>(T src) where T : struct {
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
                bool expected = BitMath.IsNegativeZero((dynamic)x);
                if (allowLog) {
                    Console.WriteLine("IsNegativeZero({0}):\t{1}", x, expected);
                }
                // IsNegativeZero_Bit.
                bool dst = MathINumberBase.IsNegativeZero_Bit((dynamic)x);
                ClassicAssert.AreEqual(expected, dst, string.Format("IsNegativeZero_Bit({0})", x));
                // IsNegativeZero_Bcl.
#if NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                dst = MathINumberBase.IsNegativeZero_Bcl((dynamic)x);
                ClassicAssert.AreEqual(expected, dst, string.Format("IsNegativeZero_Bcl({0})", x));
#endif // NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
            }
        }

        [TestCase((float)1)]
        [TestCase((double)2)]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseHalf))]
        public void IsNotNaNTest<T>(T src) where T : struct {
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
                bool expected = BitMath.IsNotNaN((dynamic)x);
                if (allowLog) {
                    Console.WriteLine("IsNotNaN({0}):\t{1}", x, expected);
                }
                // IsNotNaN_Bit.
                bool dst = MathINumberBase.IsNotNaN_Bit((dynamic)x);
                ClassicAssert.AreEqual(expected, dst, string.Format("IsNotNaN_Bit({0})", x));
                // IsNotNaN_Bcl.
                dst = MathINumberBase.IsNotNaN_Bcl((dynamic)x);
                ClassicAssert.AreEqual(expected, dst, string.Format("IsNotNaN_Bcl({0})", x));
            }
        }

        [TestCase((float)1)]
        [TestCase((double)2)]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseHalf))]
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
                ClassicAssert.AreEqual(expected, dst, string.Format("IsNormal_Bit({0})", x));
                // IsNormal_Bcl.
#if NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                dst = MathINumberBase.IsNormal_Bcl((dynamic)x);
                ClassicAssert.AreEqual(expected, dst, string.Format("IsNormal_Bcl({0})", x));
#endif // NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
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
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseHalf))]
        public void IsOddIntegerTest<T>(T src) where T : struct {
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
                bool expected = BitMath.IsOddInteger((dynamic)x);
                if (allowLog) {
                    Console.WriteLine("IsOddInteger({0}):\t{1}", x, expected);
                }
                // IsOddInteger_Bit.
                bool dst = MathINumberBase.IsOddInteger_Bit((dynamic)x);
                ClassicAssert.AreEqual(expected, dst, string.Format("IsOddInteger_Bit({0})", x));
                // IsOddInteger_Bcl.
#if NET7_0_OR_GREATER
                dst = MathINumberBase.IsOddInteger_Bcl((dynamic)x);
                ClassicAssert.AreEqual(expected, dst, string.Format("IsOddInteger_Bcl({0})", x));
#endif // NET7_0_OR_GREATER
            }
        }

        [TestCase((float)1)]
        [TestCase((double)2)]
        [TestCase((sbyte)3)]
        [TestCase((short)5)]
        [TestCase((int)7)]
        [TestCase((long)9)]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseHalf))]
        public void IsPositiveTest<T>(T src) where T : struct {
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
                bool expected = BitMath.IsPositive((dynamic)x);
                if (allowLog) {
                    Console.WriteLine("IsPositive({0}):\t{1}", x, expected);
                }
                // IsPositive_Bit.
                bool dst = MathINumberBase.IsPositive_Bit((dynamic)x);
                ClassicAssert.AreEqual(expected, dst, string.Format("IsPositive_Bit({0})", x));
                // IsPositive_Bcl.
#if NET7_0_OR_GREATER
                dst = MathINumberBase.IsPositive_Bcl((dynamic)x);
                ClassicAssert.AreEqual(expected, dst, string.Format("IsPositive_Bcl({0})", x));
#endif // NET7_0_OR_GREATER
            }
        }

        [TestCase((float)1)]
        [TestCase((double)2)]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseHalf))]
        public void IsPositiveInfinityTest<T>(T src) where T : struct {
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
                bool expected = BitMath.IsPositiveInfinity((dynamic)x);
                if (allowLog) {
                    Console.WriteLine("IsPositiveInfinity({0}):\t{1}", x, expected);
                }
                // IsPositiveInfinity_Bit.
                bool dst = MathINumberBase.IsPositiveInfinity_Bit((dynamic)x);
                ClassicAssert.AreEqual(expected, dst, string.Format("IsPositiveInfinity_Bit({0})", x));
                // IsPositiveInfinity_Bcl.
                dst = MathINumberBase.IsPositiveInfinity_Bcl((dynamic)x);
                ClassicAssert.AreEqual(expected, dst, string.Format("IsPositiveInfinity_Bcl({0})", x));
            }
        }

        [TestCase((float)1)]
        [TestCase((double)2)]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseHalf))]
        public void IsSubnormalTest<T>(T src) where T : struct {
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
                bool expected = BitMath.IsSubnormal((dynamic)x);
                if (allowLog) {
                    Console.WriteLine("IsSubnormal({0}):\t{1}", x, expected);
                }
                // IsSubnormal_Bit.
                bool dst = MathINumberBase.IsSubnormal_Bit((dynamic)x);
                ClassicAssert.AreEqual(expected, dst, string.Format("IsSubnormal_Bit({0})", x));
                // IsSubnormal_Bcl.
#if NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                dst = MathINumberBase.IsSubnormal_Bcl((dynamic)x);
                ClassicAssert.AreEqual(expected, dst, string.Format("IsSubnormal_Bcl({0})", x));
#endif // NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
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
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseHalf))]
        public void IsZeroTest<T>(T src) where T : struct {
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
                bool expected = BitMath.IsZero((dynamic)x);
                if (allowLog) {
                    Console.WriteLine("IsZero({0}):\t{1}", x, expected);
                }
                // IsZero_Bit.
                bool dst = MathINumberBase.IsZero_Bit((dynamic)x);
                ClassicAssert.AreEqual(expected, dst, string.Format("IsZero_Bit({0})", x));
                // IsZero_Bcl.
#if NET7_0_OR_GREATER
                dst = MathINumberBase.IsZero_Bcl((dynamic)x);
                ClassicAssert.AreEqual(expected, dst, string.Format("IsZero_Bcl({0})", x));
#endif // NET7_0_OR_GREATER
            }
        }

        [TestCase((float)1)]
        [TestCase((double)2)]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseHalf))]
        public void IsZeroOrSubnormalTest<T>(T src) where T : struct {
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
                bool expected = BitMath.IsZeroOrSubnormal((dynamic)x);
                if (allowLog) {
                    Console.WriteLine("IsZeroOrSubnormal({0}):\t{1}", x, expected);
                }
                // IsZeroOrSubnormal_Bit.
                bool dst = MathINumberBase.IsZeroOrSubnormal_Bit((dynamic)x);
                ClassicAssert.AreEqual(expected, dst, string.Format("IsZeroOrSubnormal_Bit({0})", x));
                // IsZeroOrSubnormal_Bcl.
#if NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                dst = MathINumberBase.IsZeroOrSubnormal_Bcl((dynamic)x);
                ClassicAssert.AreEqual(expected, dst, string.Format("IsZeroOrSubnormal_Bcl({0})", x));
#endif // NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
            }
        }

    }
}
