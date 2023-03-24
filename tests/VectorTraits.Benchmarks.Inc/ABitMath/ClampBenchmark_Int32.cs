//#undef BENCHMARKS_OFF

using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zyl.VectorTraits.Benchmarks.ABitMath {
#if BENCHMARKS_OFF
    using BenchmarkAttribute = FakeBenchmarkAttribute;
#else
#endif // BENCHMARKS_OFF

    // My type.
    using TMy = Int32;

    /// <summary>
    /// Clamp benchmark - Int32.
    /// </summary>
#if NETCOREAPP3_0_OR_GREATER && DRY_JOB
    [DryJob]
#endif // NETCOREAPP3_0_OR_GREATER && DRY_JOB
    public partial class ClampBenchmark_Int32 : AbstractSharedBenchmark_Int32 {

        // -- var --
        private const TMy valueMin = default;
        private static readonly TMy[] valueMaxList = {
            1,
            2,
            3,
            TMy.MaxValue/4,
            TMy.MaxValue/2
        };

        /// <summary>
        /// Sum Clamp - if.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="amin">The lower bound of the result (结果的下限).</param>
        /// <param name="amax">The upper bound of the result (结果的上限).</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMy StaticSumClamp_If(TMy[] src, int srcCount, TMy amin, TMy amax) {
            TMy rt = 0; // Result.
            for (int i = 0; i < srcCount; ++i) {
                TMy t = src[i];
                rt += (t < amax) ? ((t > amin) ? t : amin) : amax;
            }
            return rt;
        }

        [Benchmark(Baseline = true)]
        public void SumClamp_If() {
            LoopCount = valueMaxList.Length;
            dstTMy = 0;
            foreach (TMy amax in valueMaxList) {
                dstTMy += StaticSumClamp_If(srcArray, srcArray.Length, valueMin, amax);
            }
            if (CheckMode) {
                baselineTMy = dstTMy;
                BenchmarkUtil.WriteItem("# SumClamp_If", string.Format("{0}", baselineTMy));
            }
        }

        /// <summary>
        /// Sum Clamp - if - Loop unrolling *4.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="amin">The lower bound of the result (结果的下限).</param>
        /// <param name="amax">The upper bound of the result (结果的上限).</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMy StaticSumClamp_IfUnrolling4(TMy[] src, int srcCount, TMy amin, TMy amax) {
            TMy rt = 0; // Result.
            TMy rt1 = 0;
            TMy rt2 = 0;
            TMy rt3 = 0;
            int nBlockWidth = 4; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            int p = 0; // Index for src data.
            int i;
            // Block processs.
            for (i = 0; i < cntBlock; ++i) {
                TMy t = src[p];
                rt += (t < amax) ? ((t > amin) ? t : amin) : amax;
                TMy t1 = src[p + 1];
                rt1 += (t1 < amax) ? ((t1 > amin) ? t1 : amin) : amax;
                TMy t2 = src[p + 2];
                rt2 += (t2 < amax) ? ((t2 > amin) ? t2 : amin) : amax;
                TMy t3 = src[p + 3];
                rt3 += (t3 < amax) ? ((t3 > amin) ? t3 : amin) : amax;
                p += nBlockWidth;
            }
            // Remainder processs.
            //p = cntBlock * nBlockWidth;
            for (i = 0; i < cntRem; ++i) {
                TMy t = src[p + i];
                rt += (t < amax) ? ((t > amin) ? t : amin) : amax;
            }
            // Reduce.
            rt = (TMy)(rt + rt1 + rt2 + rt3);
            return rt;
        }

        [Benchmark]
        public void SumClamp_IfUnrolling4() {
            dstTMy = 0;
            foreach (TMy amax in valueMaxList) {
                dstTMy += StaticSumClamp_IfUnrolling4(srcArray, srcArray.Length, valueMin, amax);
            }
            CheckResult("SumClamp_IfUnrolling4");
        }

        /// <summary>
        /// Sum Clamp - MinMax.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="amin">The lower bound of the result (结果的下限).</param>
        /// <param name="amax">The upper bound of the result (结果的上限).</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMy StaticSumClamp_MinMax(TMy[] src, int srcCount, TMy amin, TMy amax) {
            TMy rt = 0; // Result.
            for (int i = 0; i < srcCount; ++i) {
                TMy t = src[i];
                TMy n = Math.Min(Math.Max(t, amin), amax);
                //TMy n0 = (t < amax) ? ((t > amin) ? t : amin) : amax;
                //if (n0 != n) {
                //    Debug.WriteLine($"{n} != {n0}");
                //}
                rt += n;
            }
            return rt;
        }

        [Benchmark]
        public void SumClamp_MinMax() {
            dstTMy = 0;
            foreach (TMy amax in valueMaxList) {
                dstTMy += StaticSumClamp_MinMax(srcArray, srcArray.Length, valueMin, amax);
            }
            CheckResult("SumClamp_MinMax");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMy StaticSumClamp_MinMaxUnrolling4(TMy[] src, int srcCount, TMy amin, TMy amax) {
            TMy rt = 0; // Result.
            TMy rt1 = 0;
            TMy rt2 = 0;
            TMy rt3 = 0;
            int nBlockWidth = 4; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            int p = 0; // Index for src data.
            int i;
            // Block processs.
            for (i = 0; i < cntBlock; ++i) {
                rt += Math.Min(Math.Max(src[p], amin), amax);
                rt1 += Math.Min(Math.Max(src[p + 1], amin), amax);
                rt2 += Math.Min(Math.Max(src[p + 2], amin), amax);
                rt3 += Math.Min(Math.Max(src[p + 3], amin), amax);
                p += nBlockWidth;
            }
            // Remainder processs.
            //p = cntBlock * nBlockWidth;
            for (i = 0; i < cntRem; ++i) {
                rt += Math.Min(Math.Max(src[p + i], amin), amax);
            }
            // Reduce.
            rt = (TMy)(rt + rt1 + rt2 + rt3);
            return rt;
        }

        [Benchmark(Baseline = true)]
        public void SumClamp_MinMaxUnrolling4() {
            dstTMy = 0;
            foreach (TMy amax in valueMaxList) {
                dstTMy += StaticSumClamp_MinMaxUnrolling4(srcArray, srcArray.Length, valueMin, amax);
            }
            CheckResult("SumClamp_MinMaxUnrolling4");
        }

#if NETCOREAPP2_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        /// <summary>
        /// Sum Clamp - Clamp method of Math class .
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="amin">The lower bound of the result (结果的下限).</param>
        /// <param name="amax">The upper bound of the result (结果的上限).</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMy StaticSumClamp_Math(TMy[] src, int srcCount, TMy amin, TMy amax) {
            TMy rt = 0; // Result.
            for (int i = 0; i < srcCount; ++i) {
                TMy t = src[i];
                rt += Math.Clamp(t, amin, amax);
            }
            return rt;
        }

        [Benchmark]
        public void SumClamp_Math() {
            dstTMy = 0;
            foreach (TMy amax in valueMaxList) {
                dstTMy += StaticSumClamp_Math(srcArray, srcArray.Length, valueMin, amax);
            }
            CheckResult("SumClamp_Math");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMy StaticSumClamp_MathUnrolling4(TMy[] src, int srcCount, TMy amin, TMy amax) {
            TMy rt = 0; // Result.
            TMy rt1 = 0;
            TMy rt2 = 0;
            TMy rt3 = 0;
            int nBlockWidth = 4; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            int p = 0; // Index for src data.
            int i;
            // Block processs.
            for (i = 0; i < cntBlock; ++i) {
                rt += Math.Clamp(src[p], amin, amax);
                rt1 += Math.Clamp(src[p + 1], amin, amax);
                rt2 += Math.Clamp(src[p + 2], amin, amax);
                rt3 += Math.Clamp(src[p + 3], amin, amax);
                p += nBlockWidth;
            }
            // Remainder processs.
            //p = cntBlock * nBlockWidth;
            for (i = 0; i < cntRem; ++i) {
                rt += Math.Clamp(src[p + i], amin, amax);
            }
            // Reduce.
            rt = (TMy)(rt + rt1 + rt2 + rt3);
            return rt;
        }

        [Benchmark(Baseline = true)]
        public void SumClamp_MathUnrolling4() {
            dstTMy = 0;
            foreach (TMy amax in valueMaxList) {
                dstTMy += StaticSumClamp_MathUnrolling4(srcArray, srcArray.Length, valueMin, amax);
            }
            CheckResult("SumClamp_MathUnrolling4");
        }
#endif // NETCOREAPP2_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER

        /// <summary>
        /// Sum Clamp - BitMath.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="amin">The lower bound of the result (结果的下限).</param>
        /// <param name="amax">The upper bound of the result (结果的上限).</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMy StaticSumClamp_BitMath(TMy[] src, int srcCount, TMy amin, TMy amax) {
            TMy rt = 0; // Result.
            for (int i = 0; i < srcCount; ++i) {
                TMy t = src[i];
                rt += BitMath.Clamp(t, amin, amax);
            }
            return rt;
        }

        [Benchmark]
        public void SumClamp_BitMath() {
            dstTMy = 0;
            foreach (TMy amax in valueMaxList) {
                dstTMy += StaticSumClamp_BitMath(srcArray, srcArray.Length, valueMin, amax);
            }
            CheckResult("SumClamp_BitMath");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMy StaticSumClamp_BitMathUnrolling4(TMy[] src, int srcCount, TMy amin, TMy amax) {
            TMy rt = 0; // Result.
            TMy rt1 = 0;
            TMy rt2 = 0;
            TMy rt3 = 0;
            int nBlockWidth = 4; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            int p = 0; // Index for src data.
            int i;
            // Block processs.
            for (i = 0; i < cntBlock; ++i) {
                rt += BitMath.Clamp(src[p], amin, amax);
                rt1 += BitMath.Clamp(src[p + 1], amin, amax);
                rt2 += BitMath.Clamp(src[p + 2], amin, amax);
                rt3 += BitMath.Clamp(src[p + 3], amin, amax);
                p += nBlockWidth;
            }
            // Remainder processs.
            //p = cntBlock * nBlockWidth;
            for (i = 0; i < cntRem; ++i) {
                rt += BitMath.Clamp(src[p + i], amin, amax);
            }
            // Reduce.
            rt = (TMy)(rt + rt1 + rt2 + rt3);
            return rt;
        }

        [Benchmark(Baseline = true)]
        public void SumClamp_BitMathUnrolling4() {
            dstTMy = 0;
            foreach (TMy amax in valueMaxList) {
                dstTMy += StaticSumClamp_BitMathUnrolling4(srcArray, srcArray.Length, valueMin, amax);
            }
            CheckResult("SumClamp_BitMathUnrolling4");
        }

    }
}
