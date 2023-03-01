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

namespace Zyl.VectorTraits.Benchmarks.AVector.W {
#if BENCHMARKS_OFF
    using BenchmarkAttribute = FakeBenchmarkAttribute;
#else
#endif // BENCHMARKS_OFF

    // My type.
    using TMy = SByte;
    using TMyOut = Int16;

    /// <summary>
    /// Widen benchmark - SByte.
    /// </summary>
#if NETCOREAPP3_0_OR_GREATER && DRY_JOB
    [DryJob]
#endif // NETCOREAPP3_0_OR_GREATER && DRY_JOB
    public partial class WidenBenchmark_SByte : AbstractSharedBenchmark_SByte_Int16 {

        // -- var --

        /// <summary>
        /// Sum Widen - Scalar.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMyOut StaticSumWidenScalar(TMy[] src, int srcCount) {
            TMyOut rt = 0; // Result.
            for (int i = 0; i < srcCount; ++i) {
                rt += (TMyOut)src[i];
            }
            return rt;
        }

        [Benchmark(Baseline = true)]
        public void SumWidenScalar() {
            dstTMy = StaticSumWidenScalar(srcArray, srcArray.Length);
            if (CheckMode) {
                baselineTMy = dstTMy;
                BenchmarkUtil.WriteItem("# SumWidenScalar", string.Format("{0}", baselineTMy));
            }
        }

        /// <summary>
        /// Sum Widen - BCL.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe TMyOut StaticSumWidenBcl(TMy[] src, int srcCount) {
            TMyOut rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMyOut> vrt = Vector<TMyOut>.Zero; // Vector result.
            Vector<TMyOut> vrt1 = Vector<TMyOut>.Zero;
            Vector<TMyOut> lower, upper;
            int i;
            // Body.
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector.Widen(*(Vector<TMy>*)p, out lower, out upper);
                    vrt += lower;
                    vrt1 += upper;
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMyOut)p[i];
                }
            }
            // Reduce.
            vrt += vrt1;
            for (i = 0; i < Vector<TMyOut>.Count; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumWidenBcl() {
            dstTMy = StaticSumWidenBcl(srcArray, srcArray.Length);
            CheckResult("SumWidenBcl");
        }

        #region BENCHMARKS_RAW
#if BENCHMARKS_RAW

        /// <summary>
        /// Sum Widen - Vector - base.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe TMyOut StaticSumWidenVectorBase(TMy[] src, int srcCount) {
            TMyOut rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMyOut> vrt = Vector<TMyOut>.Zero; // Vector result.
            Vector<TMyOut> vrt1 = Vector<TMyOut>.Zero;
            Vector<TMyOut> lower, upper;
            int i;
            // Body.
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    VectorTraitsBase.Statics.Widen(*(Vector<TMy>*)p, out lower, out upper);
                    vrt += lower;
                    vrt1 += upper;
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMyOut)p[i];
                }
            }
            // Reduce.
            vrt += vrt1;
            for (i = 0; i < Vector<TMyOut>.Count; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumWidenVectorBase() {
            dstTMy = StaticSumWidenVectorBase(srcArray, srcArray.Length);
            CheckResult("SumWidenVectorBase");
        }

#endif // BENCHMARKS_RAW
        #endregion // BENCHMARKS_RAW


        /// <summary>
        /// Sum Widen - Vector Traits - static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe TMyOut StaticSumWidenVectorTraits(TMy[] src, int srcCount) {
            TMyOut rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMyOut> vrt = Vector<TMyOut>.Zero; // Vector result.
            Vector<TMyOut> vrt1 = Vector<TMyOut>.Zero;
            Vector<TMyOut> lower, upper;
            int i;
            // Body.
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vectors.Widen(*(Vector<TMy>*)p, out lower, out upper);
                    vrt += lower;
                    vrt1 += upper;
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMyOut)p[i];
                }
            }
            // Reduce.
            vrt += vrt1;
            for (i = 0; i < Vector<TMyOut>.Count; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumWidenVectorTraits() {
            dstTMy = StaticSumWidenVectorTraits(srcArray, srcArray.Length);
            CheckResult("SumWidenVectorTraits");
        }


#if NETCOREAPP3_0_OR_GREATER

        #region BENCHMARKS_128ALGORITHM
#if BENCHMARKS_128ALGORITHM

        #region BENCHMARKS_ALGORITHM
#if BENCHMARKS_ALGORITHM
#if NET5_0_OR_GREATER

        /// <summary>
        /// Sum Widen - Vector128 - Arm.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe TMyOut StaticSumWidenVector128_Arm(TMy[] src, int srcCount) {
            TMyOut rt = 0; // Result.
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMyOut> vrt = Vector128<TMyOut>.Zero; // Vector result.
            Vector128<TMyOut> vrt1 = Vector128<TMyOut>.Zero;
            Vector128<TMyOut> lower, upper;
            int i;
            // Body.
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    WVectorTraits128AdvSimd.Statics.Widen(*(Vector128<TMy>*)p, out lower, out upper);
                    vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, lower);
                    vrt1 = WVectorTraits128AdvSimd.Statics.Add(vrt1, upper);
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMyOut)p[i];
                }
            }
            // Reduce.
            vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vrt1);
            for (i = 0; i < Vector128<TMyOut>.Count; ++i) {
                rt += vrt.GetElement(i);
            }
            return rt;
        }

        [Benchmark]
        public void SumWidenVector128_Arm() {
            WVectorTraits128AdvSimd.Statics.ThrowForUnsupported(true);
            dstTMy = StaticSumWidenVector128_Arm(srcArray, srcArray.Length);
            CheckResult("SumWidenVector128_Arm");
        }

#endif // NET5_0_OR_GREATER

#endif // BENCHMARKS_ALGORITHM
        #endregion // BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum Widen - Vector128 - Traits static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe TMyOut StaticSumWidenVector128Traits(TMy[] src, int srcCount) {
            TMyOut rt = 0; // Result.
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMyOut> vrt = Vector128<TMyOut>.Zero; // Vector result.
            Vector128<TMyOut> vrt1 = Vector128<TMyOut>.Zero;
            Vector128<TMyOut> lower, upper;
            int i;
            // Body.
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector128s.Widen(*(Vector128<TMy>*)p, out lower, out upper);
                    vrt = Vector128s.Add(vrt, lower);
                    vrt1 = Vector128s.Add(vrt1, upper);
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMyOut)p[i];
                }
            }
            // Reduce.
            vrt = Vector128s.Add(vrt, vrt1);
            for (i = 0; i < Vector128<TMyOut>.Count; ++i) {
                rt += vrt.GetElement(i);
            }
            return rt;
        }

        [Benchmark]
        public void SumWidenVector128Traits() {
            dstTMy = StaticSumWidenVector128Traits(srcArray, srcArray.Length);
            CheckResult("SumWidenVector128Traits");
        }

#endif // BENCHMARKS_128ALGORITHM
        #endregion // BENCHMARKS_128ALGORITHM

        #region BENCHMARKS_256ALGORITHM
#if BENCHMARKS_256ALGORITHM

        /// <summary>
        /// Sum Widen - Vector256 - Traits static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe TMyOut StaticSumWidenVector256Traits(TMy[] src, int srcCount) {
            TMyOut rt = 0; // Result.
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMyOut> vrt = Vector256<TMyOut>.Zero; // Vector result.
            Vector256<TMyOut> vrt1 = Vector256<TMyOut>.Zero;
            Vector256<TMyOut> lower, upper;
            int i;
            // Body.
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector256s.Widen(*(Vector256<TMy>*)p, out lower, out upper);
                    vrt = Vector256s.Add(vrt, lower);
                    vrt1 = Vector256s.Add(vrt1, upper);
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMyOut)p[i];
                }
            }
            // Reduce.
            vrt = Vector256s.Add(vrt, vrt1);
            for (i = 0; i < Vector256<TMyOut>.Count; ++i) {
                rt += vrt.GetElement(i);
            }
            return rt;
        }

        [Benchmark]
        public void SumWidenVector256Traits() {
            dstTMy = StaticSumWidenVector256Traits(srcArray, srcArray.Length);
            CheckResult("SumWidenVector256Traits");
        }

#endif // BENCHMARKS_256ALGORITHM
        #endregion // BENCHMARKS_256ALGORITHM

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
