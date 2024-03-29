﻿//#undef BENCHMARKS_OFF

using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zyl.VectorTraits.Benchmarks.ABitMath {
#if BENCHMARKS_OFF
    using BenchmarkAttribute = FakeBenchmarkAttribute;
#else
#endif // BENCHMARKS_OFF

    // My type.
    using TMy = Int16;

    /// <summary>
    /// ConditionalSelect benchmark - Int16.
    /// </summary>
#if NETCOREAPP3_0_OR_GREATER && DRY_JOB
    [DryJob]
#endif // NETCOREAPP3_0_OR_GREATER && DRY_JOB
    public partial class ConditionalSelectBenchmark_Int16 : AbstractSharedBenchmark_Int16 {

        // -- var --
        private static readonly TMy[] samples = {
            TMy.MinValue/2,
            TMy.MinValue/4,
            -2,
            0,
            2,
            TMy.MaxValue/4,
            TMy.MaxValue/2
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
                BenchmarkUtil.WriteItem("# SumConditionalSelect_If", string.Format("{0}", baselineTMy));
            }
        }

        /// <summary>
        /// Sum ConditionalSelect - Math.Min.
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
            CheckResult("SumConditionalSelect_Min");
        }

        /// <summary>
        /// Sum ConditionalSelect - BitMath.Min .
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="sample">Sample value.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMy StaticSumConditionalSelect_Min_BitMath(TMy[] src, int srcCount, TMy sample) {
            TMy rt = 0; // Result.
            for (int i = 0; i < srcCount; ++i) {
                TMy t = src[i];
                rt += BitMath.ConditionalSelect(t < sample, t, sample);
            }
            return rt;
        }

        [Benchmark]
        public void SumConditionalSelect_Min_BitMath() {
            dstTMy = 0;
            foreach (TMy sample in samples) {
                dstTMy += StaticSumConditionalSelect_Min_BitMath(srcArray, srcArray.Length, sample);
            }
            CheckResult("SumConditionalSelect_Min_BitMath");
        }

        /// <summary>
        /// Sum ConditionalSelect - BitMath.ConditionalSelect .
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="sample">Sample value.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMy StaticSumConditionalSelect_BitMath(TMy[] src, int srcCount, TMy sample) {
            TMy rt = 0; // Result.
            for (int i = 0; i < srcCount; ++i) {
                TMy t = src[i];
                rt += BitMath.ConditionalSelect(t < sample, t, sample);
            }
            return rt;
        }

        [Benchmark]
        public void SumConditionalSelect_BitMath() {
            dstTMy = 0;
            foreach (TMy sample in samples) {
                dstTMy += StaticSumConditionalSelect_BitMath(srcArray, srcArray.Length, sample);
            }
            CheckResult("SumConditionalSelect_BitMath");
        }

    }
}
