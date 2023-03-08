#undef BENCHMARKS_OFF

using BenchmarkDotNet.Attributes;
using System;

namespace Zyl.VectorTraits.Benchmarks.ABitUtil {
#if BENCHMARKS_OFF
    using BenchmarkAttribute = FakeBenchmarkAttribute;
#else
#endif // BENCHMARKS_OFF

    // My type.
    using TMy = UInt64;

    /// <summary>
    /// BigMul benchmark - UInt64.
    /// </summary>
#if NETCOREAPP3_0_OR_GREATER && DRY_JOB
    [DryJob]
#endif // NETCOREAPP3_0_OR_GREATER && DRY_JOB
    public partial class BigMulBenchmark_UInt64 : AbstractSharedBenchmark_UInt64 {
#pragma warning disable CS0618 // Type or member is obsolete

        // -- var --

        /// <summary>
        /// Sum BigMul - BigNum.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        public static TMy StaticSumBigMul_BigNum(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            TMy rtLow = 0;
            TMy high, low;
            for (int i = 0; i < srcCount; i += 2) {
                high = BitUtil.BigMul_BigNum(src[i], src[i + 1], out low);
                rt += high;
                rtLow += low;
            }
            rt += rtLow;
            return rt;
        }

        [Benchmark(Baseline = true)]
        public void SumBigMul_BigNum() {
            dstTMy = StaticSumBigMul_BigNum(srcArray, srcArray.Length);
            if (CheckMode) {
                baselineTMy = dstTMy;
                BenchmarkUtil.WriteItem("# SumBigMul_BigNum", string.Format("{0}", baselineTMy));
            }
        }

#if NET5_0_OR_GREATER

        /// <summary>
        /// Sum BigMul - BCL.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        public static TMy StaticSumBigMul_BCL(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            TMy rtLow = 0;
            TMy high, low;
            for (int i = 0; i < srcCount; i += 2) {
                high = Math.BigMul(src[i], src[i + 1], out low);
                rt += high;
                rtLow += low;
            }
            rt += rtLow;
            return rt;
        }

        [Benchmark]
        public void SumBigMul_BCL() {
            dstTMy = StaticSumBigMul_BCL(srcArray, srcArray.Length);
            CheckResult("SumBigMul_BCL");
        }

#endif // NET5_0_OR_GREATER

        /// <summary>
        /// Sum BigMul - BitUtil.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        public static TMy StaticSumBigMul_BitUtil(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            TMy rtLow = 0;
            TMy high, low;
            for (int i = 0; i < srcCount; i += 2) {
                high = BitUtil.BigMul(src[i], src[i + 1], out low);
                rt += high;
                rtLow += low;
            }
            rt += rtLow;
            return rt;
        }

        [Benchmark]
        public void SumBigMul_BitUtil() {
            dstTMy = StaticSumBigMul_BitUtil(srcArray, srcArray.Length);
            CheckResult("SumBigMul_BitUtil");
        }

        /// <summary>
        /// Sum BigMul - Two.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        public static TMy StaticSumBigMul_Two(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            TMy rtLow = 0;
            TMy high, low;
            for (int i = 0; i < srcCount; i += 2) {
                high = BitUtil.BigMul_Two(src[i], src[i + 1], out low);
                rt += high;
                rtLow += low;
            }
            rt += rtLow;
            return rt;
        }

        [Benchmark]
        public void SumBigMul_Two() {
            dstTMy = StaticSumBigMul_Two(srcArray, srcArray.Length);
            CheckResult("SumBigMul_Two");
        }

        /// <summary>
        /// Sum BigMul - HighLow.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        public static TMy StaticSumBigMul_HighLow(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            TMy rtLow = 0;
            TMy high, low;
            for (int i = 0; i < srcCount; i += 2) {
                high = BitUtil.BigMulHigh(src[i], src[i + 1]);
                low = BitUtil.BigMulLow(src[i], src[i + 1]);
                rt += high;
                rtLow += low;
            }
            rt += rtLow;
            return rt;
        }

        [Benchmark]
        public void SumBigMul_HighLow() {
            dstTMy = StaticSumBigMul_HighLow(srcArray, srcArray.Length);
            CheckResult("SumBigMul_HighLow");
        }

#pragma warning restore CS0618 // Type or member is obsolete
    }
}
