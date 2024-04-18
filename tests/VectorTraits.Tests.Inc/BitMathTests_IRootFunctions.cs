﻿using NUnit.Framework;
#if !USED_NUNIT3
using NUnit.Framework.Legacy;
#endif
using System;
using System.Collections.Generic;
using System.Text;
using Zyl.VectorTraits;

namespace Zyl.VectorTraits.Tests {
#if USED_NUNIT3
    using ClassicAssert = Assert;
#endif

    [Obsolete("It has been instead by MathIRootFunctionsTests class.")]
    [TestFixture()]
    internal class BitMathTests_IRootFunctions {

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
        public void SqrtTest<T>(T src) where T : struct {
            T[] samples = new T[10];
            samples[0] = default;
            samples[1] = src;
            samples[2] = Scalars<T>.V_2;
            samples[3] = Scalars<T>.MaxValue;
            samples[4] = Scalars<T>.PositiveInfinity;
            samples[5] = Scalars<T>.NaN;
            for (int i = 6; i < samples.Length; ++i) {
                samples[i] = Scalars.GetByDouble<T>(i);
            }
            bool allowLog = false;
            bool showNotEquals = true;
            // run.
            for (int i = 0; i < samples.Length; ++i) {
                T x = samples[i];
                double xDouble = Scalars.GetDoubleFrom(x);
                double expectedDouble = Math.Sqrt(xDouble);
                T expected = Scalars.GetByDouble<T>(expectedDouble);
                T dst = BitMath.Sqrt((dynamic)x);
                bool showLog = allowLog;
                if (!showLog && !expected.Equals(dst)) {
                    if (showNotEquals) {
                        showLog = true;
                    }
                }
                if (showLog) {
                    Console.WriteLine("Sqrt({0}):\t{1}\t// {2}", x, dst, expected);
                } else {
                    ClassicAssert.AreEqual(expected, dst, string.Format("Sqrt({0})", x));
                }
            }
        }

    }
}
