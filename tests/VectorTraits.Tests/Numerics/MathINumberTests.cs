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
        [TestCase((short)5)]
        [TestCase((int)7)]
        [TestCase((long)9)]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseHalf))]
        public void CopySignTest<T>(T src) where T : struct {
            System.IO.TextWriter writer = Console.Out;
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
            for (int i = 1; i < samples.Length; ++i) {
                T left = samples[i];
                for (int j = 1; j < samples.Length; ++j) {
                    T right = samples[j];
                    T expected;
                    T dst;
                    expected = BitMath.CopySign((dynamic)left, (dynamic)right);
                    if (allowLog) {
                        VectorTextUtil.WriteLine(writer, "CopySign({0}, {1}):\t{2}", left, right, expected);
                    }
                    // CopySign_Bit.
                    dst = MathINumber.CopySign_Bit((dynamic)left, (dynamic)right);
                    Assert.AreEqual(expected, dst, string.Format("CopySign_Bit({0}, {1})", left, right));
                    // CopySign_Bcl.
#if NET7_0_OR_GREATER
                    try {
                        dst = MathINumber.CopySign_Bcl((dynamic)left, (dynamic)right);
                        Assert.AreEqual(expected, dst, string.Format("CopySign_Bcl({0}, {1})", left, right));
                    } catch (Exception ex) {
                        VectorTextUtil.WriteLine(writer, "CopySign_Bcl({0}, {1}):\t{2}", left, right, ex.Message);
                    }
#endif // NET7_0_OR_GREATER
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
                    dst = MathINumber.Max((dynamic)left, (dynamic)right);
                    Assert.AreEqual(expected, dst, $"{left} < {right}");
                    //Console.WriteLine($"{left} < {right}: {expected}");
                }
            }
        }

        [TestCase((float)1)]
        [TestCase((double)2)]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseHalf))]
        public void MaxNumberTest<T>(T src) where T : struct {
            System.IO.TextWriter writer = Console.Out;
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
            for (int i = 1; i < samples.Length; ++i) {
                T left = samples[i];
                for (int j = 1; j < samples.Length; ++j) {
                    T right = samples[j];
                    T expected;
                    T dst;
                    expected = BitMath.MaxNumber((dynamic)left, (dynamic)right);
                    if (allowLog) {
                        VectorTextUtil.WriteLine(writer, "MaxNumber({0}, {1}):\t{2}", left, right, expected);
                    }
                    // MaxNumber_Bit.
                    dst = MathINumber.MaxNumber_Bit((dynamic)left, (dynamic)right);
                    Assert.AreEqual(expected, dst, string.Format("MaxNumber_Bit({0}, {1})", left, right));
                    // MaxNumber_Bcl.
#if NET7_0_OR_GREATER
                    dst = MathINumber.MaxNumber_Bcl((dynamic)left, (dynamic)right);
                    Assert.AreEqual(expected, dst, string.Format("MaxNumber_Bcl({0}, {1})", left, right));
#endif // NET7_0_OR_GREATER
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

        [TestCase((float)1)]
        [TestCase((double)2)]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseHalf))]
        public void MinNumberTest<T>(T src) where T : struct {
            System.IO.TextWriter writer = Console.Out;
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
            for (int i = 1; i < samples.Length; ++i) {
                T left = samples[i];
                for (int j = 1; j < samples.Length; ++j) {
                    T right = samples[j];
                    T expected;
                    T dst;
                    expected = BitMath.MinNumber((dynamic)left, (dynamic)right);
                    if (allowLog) {
                        VectorTextUtil.WriteLine(writer, "MinNumber({0}, {1}):\t{2}", left, right, expected);
                    }
                    // MinNumber_Bit.
                    dst = MathINumber.MinNumber_Bit((dynamic)left, (dynamic)right);
                    Assert.AreEqual(expected, dst, string.Format("MinNumber_Bit({0}, {1})", left, right));
                    // MinNumber_Bcl.
#if NET7_0_OR_GREATER
                    dst = MathINumber.MinNumber_Bcl((dynamic)left, (dynamic)right);
                    Assert.AreEqual(expected, dst, string.Format("MinNumber_Bcl({0}, {1})", left, right));
#endif // NET7_0_OR_GREATER
                }
            }
        }

        [TestCase((float)1)]
        [TestCase((double)2)]
        [TestCase((sbyte)3)]
        [TestCase((short)5)]
        [TestCase((int)7)]
        [TestCase((long)9)]
        [TestCaseSource(typeof(TestDataSource), nameof(TestDataSource.UseHalf))]
        public void SignTest<T>(T src) where T : struct {
            System.IO.TextWriter writer = Console.Out;
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
                int expected = BitMath.Sign((dynamic)x);
                if (allowLog) {
                    VectorTextUtil.WriteLine(writer, "Sign({0}):\t{1}", x, expected);
                }
                // Sign_Bit.
                int dst = MathINumber.Sign_Bit((dynamic)x);
                Assert.AreEqual(expected, dst, string.Format("Sign_Bit({0})", x));
                // Sign_Bcl.
#if NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                try {
                    dst = MathINumber.Sign_Bcl((dynamic)x);
                    Assert.AreEqual(expected, dst, string.Format("Sign_Bcl({0})", x));
                } catch (Exception ex) {
                    VectorTextUtil.WriteLine(writer, "Sign_Bcl({0}):\t{1}", x, ex.Message);
                }
#endif // NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
            }
        }

    }
}
