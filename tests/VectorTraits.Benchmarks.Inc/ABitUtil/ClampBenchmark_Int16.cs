//#undef BENCHMARKS_OFF

using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Clamp benchmark - Int16.
    /// </summary>
#if NETCOREAPP3_0_OR_GREATER && DRY_JOB
    [DryJob]
#endif // NETCOREAPP3_0_OR_GREATER && DRY_JOB
    public partial class ClampBenchmark_Int16 : AbstractSharedBenchmark_Int16 {

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

#if NETCOREAPP2_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        /// <summary>
        /// Sum Clamp - Math.
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
#endif // NETCOREAPP2_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER

        /// <summary>
        /// Sum Clamp - BitUtil.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="amin">The lower bound of the result (结果的下限).</param>
        /// <param name="amax">The upper bound of the result (结果的上限).</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMy StaticSumClamp_BitUtil(TMy[] src, int srcCount, TMy amin, TMy amax) {
            TMy rt = 0; // Result.
            for (int i = 0; i < srcCount; ++i) {
                TMy t = src[i];
                rt += BitUtil.Clamp(t, amin, amax);
            }
            return rt;
        }

        [Benchmark]
        public void SumClamp_BitUtil() {
            dstTMy = 0;
            foreach (TMy amax in valueMaxList) {
                dstTMy += StaticSumClamp_BitUtil(srcArray, srcArray.Length, valueMin, amax);
            }
            CheckResult("SumClamp_BitUtil");
        }

    }
}
