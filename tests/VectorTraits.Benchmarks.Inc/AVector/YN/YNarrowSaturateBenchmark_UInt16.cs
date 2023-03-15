#undef BENCHMARKS_OFF

using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using System.Text;
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Benchmarks.AVector.YN {
#if BENCHMARKS_OFF
    using BenchmarkAttribute = FakeBenchmarkAttribute;
#else
#endif // BENCHMARKS_OFF

    // My type.
    using TMy = UInt16;
    using TMyOut = Byte;

    /// <summary>
    /// Narrow benchmark - UInt16.
    /// </summary>
#if NETCOREAPP3_0_OR_GREATER && DRY_JOB
    [DryJob]
#endif // NETCOREAPP3_0_OR_GREATER && DRY_JOB
    public partial class YNarrowSaturateBenchmark_UInt16 : AbstractSharedBenchmark_UInt16_Byte {

        // -- var --
        private const TMy amax = TMyOut.MaxValue;

        /// <summary>
        /// Narrow - If .
        /// </summary>
        /// <param name="t">Source value.</param>
        /// <returns>Returns narrowed.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMyOut Narrow_If(TMy t) {
            TMy rt = (t < amax) ? t : amax;
            return (TMyOut)rt;
        }

        /// <summary>
        /// Narrow - MinMax .
        /// </summary>
        /// <param name="t">Source value.</param>
        /// <returns>Returns narrowed.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMyOut Narrow_MinMax(TMy t) {
            TMy rt = Math.Min(t, amax);
            return (TMyOut)rt;
        }

        /// <summary>
        /// Narrow - BitUtil .
        /// </summary>
        /// <param name="t">Source value.</param>
        /// <returns>Returns narrowed.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMyOut Narrow_BitUtil(TMy t) {
            TMy rt = BitUtil.Min(t, amax);
            return (TMyOut)rt;
        }

        /// <summary>
        /// Sum Narrow - If.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        public static TMyOut StaticSumNarrow_If(TMy[] src, int srcCount) {
            TMyOut rt = 0; // Result.
            for (int i = 0; i < srcCount; ++i) {
                rt += Narrow_If(src[i]);
            }
            return rt;
        }

        [Benchmark(Baseline = true)]
        public void SumNarrow_If() {
            dstTMy = StaticSumNarrow_If(srcArray, srcArray.Length);
            if (CheckMode) {
                baselineTMy = dstTMy;
                BenchmarkUtil.WriteItem("# SumNarrow_If", string.Format("{0}", baselineTMy));
            }
        }

        /// <summary>
        /// Sum Narrow - if - Loop unrolling *4.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMyOut StaticSumNarrow_IfUnrolling4(TMy[] src, int srcCount) {
            TMyOut rt = 0; // Result.
            TMyOut rt1 = 0;
            TMyOut rt2 = 0;
            TMyOut rt3 = 0;
            int nBlockWidth = 4; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            int p = 0; // Index for src data.
            int i;
            // Block processs.
            for (i = 0; i < cntBlock; ++i) {
                TMy t = src[p];
                rt += Narrow_If(t);
                TMy t1 = src[p + 1];
                rt1 += Narrow_If(t1);
                TMy t2 = src[p + 2];
                rt2 += Narrow_If(t2);
                TMy t3 = src[p + 3];
                rt3 += Narrow_If(t3);
                p += nBlockWidth;
            }
            // Remainder processs.
            //p = cntBlock * nBlockWidth;
            for (i = 0; i < cntRem; ++i) {
                TMy t = src[p + i];
                rt += Narrow_If(t);
            }
            // Reduce.
            rt = (TMyOut)(rt + rt1 + rt2 + rt3);
            return rt;
        }

        [Benchmark]
        public void SumNarrow_IfUnrolling4() {
            dstTMy = StaticSumNarrow_IfUnrolling4(srcArray, srcArray.Length);
            CheckResult("SumNarrow_IfUnrolling4");
        }

        /// <summary>
        /// Sum Narrow - MinMax.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        public static TMyOut StaticSumNarrow_MinMax(TMy[] src, int srcCount) {
            TMyOut rt = 0; // Result.
            for (int i = 0; i < srcCount; ++i) {
                rt += Narrow_MinMax(src[i]);
            }
            return rt;
        }

        [Benchmark]
        public void SumNarrow_MinMax() {
            dstTMy = StaticSumNarrow_MinMax(srcArray, srcArray.Length);
            CheckResult("SumNarrow_MinMax");
        }

        /// <summary>
        /// Sum Narrow - MinMax - Loop unrolling *4.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMyOut StaticSumNarrow_MinMaxUnrolling4(TMy[] src, int srcCount) {
            TMyOut rt = 0; // Result.
            TMyOut rt1 = 0;
            TMyOut rt2 = 0;
            TMyOut rt3 = 0;
            int nBlockWidth = 4; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            int p = 0; // Index for src data.
            int i;
            // Block processs.
            for (i = 0; i < cntBlock; ++i) {
                TMy t = src[p];
                rt += Narrow_MinMax(t);
                TMy t1 = src[p + 1];
                rt1 += Narrow_MinMax(t1);
                TMy t2 = src[p + 2];
                rt2 += Narrow_MinMax(t2);
                TMy t3 = src[p + 3];
                rt3 += Narrow_MinMax(t3);
                p += nBlockWidth;
            }
            // Remainder processs.
            //p = cntBlock * nBlockWidth;
            for (i = 0; i < cntRem; ++i) {
                TMy t = src[p + i];
                rt += Narrow_MinMax(t);
            }
            // Reduce.
            rt = (TMyOut)(rt + rt1 + rt2 + rt3);
            return rt;
        }

        [Benchmark]
        public void SumNarrow_MinMaxUnrolling4() {
            dstTMy = StaticSumNarrow_MinMaxUnrolling4(srcArray, srcArray.Length);
            CheckResult("SumNarrow_MinMaxUnrolling4");
        }

        /// <summary>
        /// Sum Narrow - BitUtil.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        public static TMyOut StaticSumNarrow_BitUtil(TMy[] src, int srcCount) {
            TMyOut rt = 0; // Result.
            for (int i = 0; i < srcCount; ++i) {
                rt += Narrow_BitUtil(src[i]);
            }
            return rt;
        }

        [Benchmark]
        public void SumNarrow_BitUtil() {
            dstTMy = StaticSumNarrow_BitUtil(srcArray, srcArray.Length);
            CheckResult("SumNarrow_BitUtil");
        }

        /// <summary>
        /// Sum Narrow - BitUtil - Loop unrolling *4.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMyOut StaticSumNarrow_BitUtilUnrolling4(TMy[] src, int srcCount) {
            TMyOut rt = 0; // Result.
            TMyOut rt1 = 0;
            TMyOut rt2 = 0;
            TMyOut rt3 = 0;
            int nBlockWidth = 4; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            int p = 0; // Index for src data.
            int i;
            // Block processs.
            for (i = 0; i < cntBlock; ++i) {
                TMy t = src[p];
                rt += Narrow_BitUtil(t);
                TMy t1 = src[p + 1];
                rt1 += Narrow_BitUtil(t1);
                TMy t2 = src[p + 2];
                rt2 += Narrow_BitUtil(t2);
                TMy t3 = src[p + 3];
                rt3 += Narrow_BitUtil(t3);
                p += nBlockWidth;
            }
            // Remainder processs.
            //p = cntBlock * nBlockWidth;
            for (i = 0; i < cntRem; ++i) {
                TMy t = src[p + i];
                rt += Narrow_BitUtil(t);
            }
            // Reduce.
            rt = (TMyOut)(rt + rt1 + rt2 + rt3);
            return rt;
        }

        [Benchmark]
        public void SumNarrow_BitUtilUnrolling4() {
            dstTMy = StaticSumNarrow_BitUtilUnrolling4(srcArray, srcArray.Length);
            CheckResult("SumNarrow_BitUtilUnrolling4");
        }

        #region BENCHMARKS_RAW
#if BENCHMARKS_RAW

        /// <summary>
        /// Sum Narrow - Vector - base.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        public static TMyOut StaticSumNarrowVectorBase(TMy[] src, int srcCount) {
            TMyOut rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMyOut> vrt = Vector<TMyOut>.Zero; // Vector result.
            int i;
            // Body.
            ref Vector<TMy> p0 = ref Unsafe.As<TMy, Vector<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                vrt += VectorTraitsBase.Statics.YNarrowSaturate(p0, Unsafe.Add(ref p0, 1));
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += Narrow_BitUtil(Unsafe.Add(ref p, i));
            }
            // Reduce.
            for (i = 0; i < Vector<TMyOut>.Count; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumNarrowVectorBase() {
            dstTMy = StaticSumNarrowVectorBase(srcArray, srcArray.Length);
            CheckResult("SumNarrowVectorBase");
        }

#endif // BENCHMARKS_RAW
        #endregion // BENCHMARKS_RAW


        /// <summary>
        /// Sum Narrow - Vector Traits - static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        public static TMyOut StaticSumNarrowVectorTraits(TMy[] src, int srcCount) {
            TMyOut rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMyOut> vrt = Vector<TMyOut>.Zero; // Vector result.
            int i;
            // Body.
            ref Vector<TMy> p0 = ref Unsafe.As<TMy, Vector<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                vrt += Vectors.YNarrowSaturate(p0, Unsafe.Add(ref p0, 1));
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += Narrow_BitUtil(Unsafe.Add(ref p, i));
            }
            // Reduce.
            for (i = 0; i < Vector<TMyOut>.Count; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumNarrowVectorTraits() {
            dstTMy = StaticSumNarrowVectorTraits(srcArray, srcArray.Length);
            CheckResult("SumNarrowVectorTraits");
        }


#if NETCOREAPP3_0_OR_GREATER

        #region BENCHMARKS_128ALGORITHM
#if BENCHMARKS_128ALGORITHM

        #region BENCHMARKS_ALGORITHM
#if BENCHMARKS_ALGORITHM
#if NET5_0_OR_GREATER

#endif // NET5_0_OR_GREATER

#endif // BENCHMARKS_ALGORITHM
        #endregion // BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum Narrow - Vector128 - Traits static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        public static TMyOut StaticSumNarrowVector128Traits(TMy[] src, int srcCount) {
            TMyOut rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMyOut> vrt = Vector128<TMyOut>.Zero; // Vector128 result.
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector128 processs.
            for (i = 0; i < cntBlock; ++i) {
                var t = Vector128s.YNarrowSaturate(p0, Unsafe.Add(ref p0, 1));
                vrt = Vector128s.Add(vrt, t);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += Narrow_BitUtil(Unsafe.Add(ref p, i));
            }
            // Reduce.
            for (i = 0; i < Vector128<TMyOut>.Count; ++i) {
                rt += vrt.GetElement(i);
            }
            return rt;
        }

        [Benchmark]
        public void SumNarrowVector128Traits() {
            dstTMy = StaticSumNarrowVector128Traits(srcArray, srcArray.Length);
            CheckResult("SumNarrowVector128Traits");
        }

#endif // BENCHMARKS_128ALGORITHM
        #endregion // BENCHMARKS_128ALGORITHM

        #region BENCHMARKS_256ALGORITHM
#if BENCHMARKS_256ALGORITHM

        /// <summary>
        /// Sum Narrow - Vector256 - Traits static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        public static TMyOut StaticSumNarrowVector256Traits(TMy[] src, int srcCount) {
            TMyOut rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMyOut> vrt = Vector256<TMyOut>.Zero; // Vector256 result.
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector256 processs.
            for (i = 0; i < cntBlock; ++i) {
                var t = Vector256s.YNarrowSaturate(p0, Unsafe.Add(ref p0, 1));
                vrt = Vector256s.Add(vrt, t);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            ref TMy p = ref Unsafe.As<Vector256<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += Narrow_BitUtil(Unsafe.Add(ref p, i));
            }
            // Reduce.
            for (i = 0; i < Vector256<TMyOut>.Count; ++i) {
                rt += vrt.GetElement(i);
            }
            return rt;
        }

        [Benchmark]
        public void SumNarrowVector256Traits() {
            dstTMy = StaticSumNarrowVector256Traits(srcArray, srcArray.Length);
            CheckResult("SumNarrowVector256Traits");
        }

#endif // BENCHMARKS_256ALGORITHM
        #endregion // BENCHMARKS_256ALGORITHM

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
