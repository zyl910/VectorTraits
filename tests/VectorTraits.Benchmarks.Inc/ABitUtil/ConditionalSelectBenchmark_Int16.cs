#undef BENCHMARKS_OFF

using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zyl.VectorTraits.Benchmarks.ABitUtil {
#if BENCHMARKS_OFF
    using BenchmarkAttribute = FakeBenchmarkAttribute;
#else
#endif // BENCHMARKS_OFF

    // My type.
    using TMy = Int16;

    /// <summary>
    /// Shift left benchmark - short.
    /// </summary>
#if NETCOREAPP3_0_OR_GREATER && DRY_JOB
    [DryJob]
#endif // NETCOREAPP3_0_OR_GREATER && DRY_JOB
    internal partial class ConditionalSelectBenchmark_Int16 : AbstractSharedBenchmark_Int16 {

        // -- var --
        private static readonly TMy[] samples = {
            TMy.MinValue/2,
            TMy.MinValue/4,
            -2,
            0,
            2,
            TMy.MaxValue/4,
            TMy.MinValue/2
        };

        /// <summary>
        /// Sum ConditionalSelect - if.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="sample">Sample value.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMy StaticSumConditionalSelect_If(TMy[] src, int srcCount, TMy sample) {
            TMy rt = 0; // Result.
            for (int i = 0; i < srcCount; ++i) {
                TMy t = src[i];
                rt += (t < sample) ? t : sample;
            }
            return rt;
        }

        [Benchmark(Baseline = true)]
        public void SumConditionalSelect_If() {
            LoopCount = samples.Length;
            dstTMy = 0;
            foreach (TMy sample in samples) {
                dstTMy += StaticSumConditionalSelect_If(srcArray, srcArray.Length, sample);
            }
            if (CheckMode) {
                baselineTMy = dstTMy;
                BenchmarkUtil.WriteLine(string.Format("# SumConditionalSelect_If:\t{0}", baselineTMy));
            }
        }

        /// <summary>
        /// Sum ConditionalSelect - Min.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="sample">Sample value.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMy StaticSumConditionalSelect_Min(TMy[] src, int srcCount, TMy sample) {
            TMy rt = 0; // Result.
            for (int i = 0; i < srcCount; ++i) {
                TMy t = src[i];
                rt += Math.Min(t, sample);
            }
            return rt;
        }

        [Benchmark]
        public void SumConditionalSelect_Min() {
            dstTMy = 0;
            foreach (TMy sample in samples) {
                dstTMy += StaticSumConditionalSelect_Min(srcArray, srcArray.Length, sample);
            }
            CheckResult("SumSLLNet7");
        }

        /// <summary>
        /// Sum ConditionalSelect - BitUtil.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="sample">Sample value.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMy StaticSumConditionalSelect_BitUtil(TMy[] src, int srcCount, TMy sample) {
            TMy rt = 0; // Result.
            for (int i = 0; i < srcCount; ++i) {
                TMy t = src[i];
                rt += BitUtil.ConditionalSelect(t < sample, t, sample);
            }
            return rt;
        }

        [Benchmark]
        public void SumConditionalSelect_BitUtil() {
            dstTMy = 0;
            foreach (TMy sample in samples) {
                dstTMy += StaticSumConditionalSelect_BitUtil(srcArray, srcArray.Length, sample);
            }
            CheckResult("SumSLLNet7");
        }

    }
}
