//#undef BENCHMARKS_OFF

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
using Zyl.VectorTraits.Impl.AVector;
using Zyl.VectorTraits.Impl.AVector128;
using Zyl.VectorTraits.Impl.AVector256;

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
        public static TMyOut StaticSumWidenBcl(TMy[] src, int srcCount) {
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
            ref Vector<TMy> p0 = ref Unsafe.As<TMy, Vector<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector.Widen(p0, out lower, out upper);
                vrt += lower;
                vrt1 += upper;
                p0 = ref Unsafe.Add(ref p0, 1);
            }
            // b) Remainder processs.
            ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMyOut)Unsafe.Add(ref p, i);
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
        public static TMyOut StaticSumWidenVectorBase(TMy[] src, int srcCount) {
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
            ref Vector<TMy> p0 = ref Unsafe.As<TMy, Vector<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                VectorTraitsBase.Statics.Widen(p0, out lower, out upper);
                vrt += lower;
                vrt1 += upper;
                p0 = ref Unsafe.Add(ref p0, 1);
            }
            // b) Remainder processs.
            ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMyOut)Unsafe.Add(ref p, i);
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
        public static TMyOut StaticSumWidenVectorTraits(TMy[] src, int srcCount) {
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
            ref Vector<TMy> p0 = ref Unsafe.As<TMy, Vector<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vectors.Widen(p0, out lower, out upper);
                vrt += lower;
                vrt1 += upper;
                p0 = ref Unsafe.Add(ref p0, 1);
            }
            // b) Remainder processs.
            ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMyOut)Unsafe.Add(ref p, i);
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

        /// <summary>
        /// Sum Widen - Vector Traits - static - Ptr.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe TMyOut StaticSumWidenVectorTraits_Ptr(TMy[] src, int srcCount) {
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
        public void SumWidenVectorTraits_Ptr() {
            dstTMy = StaticSumWidenVectorTraits_Ptr(srcArray, srcArray.Length);
            CheckResult("SumWidenVectorTraits_Ptr");
        }

        /// <summary>
        /// Sum Widen - Vector - Traits static use ValueTuple.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMyOut StaticSumWidenVectorTraits_Tuple(TMy[] src, int srcCount) {
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
            ref Vector<TMy> p0 = ref Unsafe.As<TMy, Vector<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                (lower, upper) = Vectors.Widen(p0);
                vrt = Vectors.Add(vrt, lower);
                vrt1 = Vectors.Add(vrt1, upper);
                p0 = ref Unsafe.Add(ref p0, 1);
            }
            // b) Remainder processs.
            ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMyOut)Unsafe.Add(ref p, i);
            }
            // Reduce.
            vrt = Vectors.Add(vrt, vrt1);
            for (i = 0; i < Vector<TMyOut>.Count; ++i) {
                rt += vrt.GetElement(i);
            }
            return rt;
        }

        [Benchmark]
        public void SumWidenVectorTraits_Tuple() {
            dstTMy = StaticSumWidenVectorTraits_Tuple(srcArray, srcArray.Length);
            CheckResult("SumWidenVectorTraits_Tuple");
        }


#if NETCOREAPP3_0_OR_GREATER

        #region BENCHMARKS_128ALGORITHM
#if BENCHMARKS_128ALGORITHM

#if NET7_0_OR_GREATER

        /// <summary>
        /// Sum Widen - Vector128 - BCL static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMyOut StaticSumWidenVector128Bcl(TMy[] src, int srcCount) {
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
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                (lower, upper) = Vector128.Widen(p0);
                vrt = Vector128s.Add(vrt, lower);
                vrt1 = Vector128s.Add(vrt1, upper);
                p0 = ref Unsafe.Add(ref p0, 1);
            }
            // b) Remainder processs.
            ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMyOut)Unsafe.Add(ref p, i);
            }
            // Reduce.
            vrt = Vector128s.Add(vrt, vrt1);
            for (i = 0; i < Vector128<TMyOut>.Count; ++i) {
                rt += vrt.GetElement(i);
            }
            return rt;
        }

        [Benchmark]
        public void SumWidenVector128Bcl() {
            dstTMy = StaticSumWidenVector128Bcl(srcArray, srcArray.Length);
            CheckResult("SumWidenVector128Bcl");
        }
#endif // NET7_0_OR_GREATER

        #region BENCHMARKS_ALGORITHM
#if BENCHMARKS_ALGORITHM
#if NET5_0_OR_GREATER

        /// <summary>
        /// Sum Widen - Vector128 - AdvSimd.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMyOut StaticSumWidenVector128_AdvSimd(TMy[] src, int srcCount) {
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
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                WVectorTraits128AdvSimd.Statics.Widen(p0, out lower, out upper);
                vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, lower);
                vrt1 = WVectorTraits128AdvSimd.Statics.Add(vrt1, upper);
                p0 = ref Unsafe.Add(ref p0, 1);
            }
            // b) Remainder processs.
            ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMyOut)Unsafe.Add(ref p, i);
            }
            // Reduce.
            vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vrt1);
            for (i = 0; i < Vector128<TMyOut>.Count; ++i) {
                rt += vrt.GetElement(i);
            }
            return rt;
        }

        [Benchmark]
        public void SumWidenVector128_AdvSimd() {
            WVectorTraits128AdvSimd.Statics.ThrowForUnsupported(true);
            dstTMy = StaticSumWidenVector128_AdvSimd(srcArray, srcArray.Length);
            CheckResult("SumWidenVector128_AdvSimd");
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
        public static TMyOut StaticSumWidenVector128Traits(TMy[] src, int srcCount) {
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
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                    Vector128s.Widen(p0, out lower, out upper);
                    vrt = Vector128s.Add(vrt, lower);
                    vrt1 = Vector128s.Add(vrt1, upper);
                p0 = ref Unsafe.Add(ref p0, 1);
            }
            // b) Remainder processs.
            ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMyOut)Unsafe.Add(ref p, i);
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

        /// <summary>
        /// Sum Widen - Vector128 - Traits static use ValueTuple.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMyOut StaticSumWidenVector128Traits_Tuple(TMy[] src, int srcCount) {
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
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                (lower, upper) = Vector128s.Widen(p0);
                vrt = Vector128s.Add(vrt, lower);
                vrt1 = Vector128s.Add(vrt1, upper);
                p0 = ref Unsafe.Add(ref p0, 1);
            }
            // b) Remainder processs.
            ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMyOut)Unsafe.Add(ref p, i);
            }
            // Reduce.
            vrt = Vector128s.Add(vrt, vrt1);
            for (i = 0; i < Vector128<TMyOut>.Count; ++i) {
                rt += vrt.GetElement(i);
            }
            return rt;
        }

        [Benchmark]
        public void SumWidenVector128Traits_Tuple() {
            dstTMy = StaticSumWidenVector128Traits_Tuple(srcArray, srcArray.Length);
            CheckResult("SumWidenVector128Traits_Tuple");
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
        public static TMyOut StaticSumWidenVector256Traits(TMy[] src, int srcCount) {
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
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256s.Widen(p0, out lower, out upper);
                vrt = Vector256s.Add(vrt, lower);
                vrt1 = Vector256s.Add(vrt1, upper);
                p0 = ref Unsafe.Add(ref p0, 1);
            }
            // b) Remainder processs.
            ref TMy p = ref Unsafe.As<Vector256<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMyOut)Unsafe.Add(ref p, i);
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

        /// <summary>
        /// Sum Widen - Vector256 - Avx2 - ConvertTo.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMyOut StaticSumWidenVector256Avx_ConvertTo(TMy[] src, int srcCount) {
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
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                WVectorTraits256Avx2.Statics.Widen_ConvertTo(p0, out lower, out upper);
                vrt = WVectorTraits256Avx2.Statics.Add(vrt, lower);
                vrt1 = WVectorTraits256Avx2.Statics.Add(vrt1, upper);
                p0 = ref Unsafe.Add(ref p0, 1);
            }
            // b) Remainder processs.
            ref TMy p = ref Unsafe.As<Vector256<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMyOut)Unsafe.Add(ref p, i);
            }
            // Reduce.
            vrt = WVectorTraits256Avx2.Statics.Add(vrt, vrt1);
            for (i = 0; i < Vector256<TMyOut>.Count; ++i) {
                rt += vrt.GetElement(i);
            }
            return rt;
        }

        [Benchmark]
        public void SumWidenVector256Avx_ConvertTo() {
            WVectorTraits256Avx2.Statics.ThrowForUnsupported(true);
            dstTMy = StaticSumWidenVector256Avx_ConvertTo(srcArray, srcArray.Length);
            CheckResult("SumWidenVector256Avx_ConvertTo");
        }

        /// <summary>
        /// Sum Widen - Vector256 - Avx2 - Unpack.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMyOut StaticSumWidenVector256Avx_Unpack(TMy[] src, int srcCount) {
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
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                WVectorTraits256Avx2.Statics.Widen_Unpack(p0, out lower, out upper);
                vrt = WVectorTraits256Avx2.Statics.Add(vrt, lower);
                vrt1 = WVectorTraits256Avx2.Statics.Add(vrt1, upper);
                p0 = ref Unsafe.Add(ref p0, 1);
            }
            // b) Remainder processs.
            ref TMy p = ref Unsafe.As<Vector256<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMyOut)Unsafe.Add(ref p, i);
            }
            // Reduce.
            vrt = WVectorTraits256Avx2.Statics.Add(vrt, vrt1);
            for (i = 0; i < Vector256<TMyOut>.Count; ++i) {
                rt += vrt.GetElement(i);
            }
            return rt;
        }

        [Benchmark]
        public void SumWidenVector256Avx_Unpack() {
            WVectorTraits256Avx2.Statics.ThrowForUnsupported(true);
            dstTMy = StaticSumWidenVector256Avx_Unpack(srcArray, srcArray.Length);
            CheckResult("SumWidenVector256Avx_Unpack");
        }

#endif // BENCHMARKS_256ALGORITHM
        #endregion // BENCHMARKS_256ALGORITHM

#endif // NETCOREAPP3_0_OR_GREATER

        #region BENCHMARKS_512
#if BENCHMARKS_512 && NET8_0_OR_GREATER

        /// <summary>
        /// Sum Widen - Vector512 - BCL static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMyOut StaticSumWidenVector512Bcl(TMy[] src, int srcCount) {
            TMyOut rt = 0; // Result.
            int VectorWidth = Vector512<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector512<TMyOut> vrt = Vector512<TMyOut>.Zero; // Vector result.
            Vector512<TMyOut> vrt1 = Vector512<TMyOut>.Zero;
            Vector512<TMyOut> lower, upper;
            int i;
            // Body.
            ref Vector512<TMy> p0 = ref Unsafe.As<TMy, Vector512<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                (lower, upper) = Vector512.Widen(p0);
                vrt = Vector512.Add(vrt, lower);
                vrt1 = Vector512.Add(vrt1, upper);
                p0 = ref Unsafe.Add(ref p0, 1);
            }
            // b) Remainder processs.
            ref TMy p = ref Unsafe.As<Vector512<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMyOut)Unsafe.Add(ref p, i);
            }
            // Reduce.
            vrt = Vector512.Add(vrt, vrt1);
            rt = Vector512.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void SumWidenVector512Bcl() {
            dstTMy = StaticSumWidenVector512Bcl(srcArray, srcArray.Length);
            CheckResult("SumWidenVector512Bcl");
        }

        /// <summary>
        /// Sum Widen - Vector512 - Traits static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMyOut StaticSumWidenVector512Traits(TMy[] src, int srcCount) {
            TMyOut rt = 0; // Result.
            int VectorWidth = Vector512<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector512<TMyOut> vrt = Vector512<TMyOut>.Zero; // Vector result.
            Vector512<TMyOut> vrt1 = Vector512<TMyOut>.Zero;
            Vector512<TMyOut> lower, upper;
            int i;
            // Body.
            ref Vector512<TMy> p0 = ref Unsafe.As<TMy, Vector512<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector512s.Widen(p0, out lower, out upper);
                vrt = Vector512s.Add(vrt, lower);
                vrt1 = Vector512s.Add(vrt1, upper);
                p0 = ref Unsafe.Add(ref p0, 1);
            }
            // b) Remainder processs.
            ref TMy p = ref Unsafe.As<Vector512<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMyOut)Unsafe.Add(ref p, i);
            }
            // Reduce.
            vrt = Vector512s.Add(vrt, vrt1);
            rt = Vector512s.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void SumWidenVector512Traits() {
            dstTMy = StaticSumWidenVector512Traits(srcArray, srcArray.Length);
            CheckResult("SumWidenVector512Traits");
        }

#endif // BENCHMARKS_512 && NET8_0_OR_GREATER
        #endregion // BENCHMARKS_512

    }
}
