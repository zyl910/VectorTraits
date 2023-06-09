//#undef BENCHMARKS_OFF
//#undef BENCHMARKS_RAW

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
    using TMy = Int32;
    using TMyOut = Int64;

#pragma warning disable CS0618 // Type or member is obsolete
    /// <summary>
    /// Widen benchmark - Int32.
    /// </summary>
#if NETCOREAPP3_0_OR_GREATER && DRY_JOB
    [DryJob]
#endif // NETCOREAPP3_0_OR_GREATER && DRY_JOB
    public partial class WidenBenchmark_Int32 : AbstractSharedBenchmark_Int32_Int64 {

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

        /// <summary>
        /// Sum Widen - Vector - base - Base_NPtr .
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe TMyOut StaticSumWidenVectorBase_NPtr(TMy[] src, int srcCount) {
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
                    VectorTraitsBase.Statics.Widen_Base_NPtr(*(Vector<TMy>*)p, out lower, out upper);
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
        public void SumWidenVectorBase_NPtr() {
            dstTMy = StaticSumWidenVectorBase_NPtr(srcArray, srcArray.Length);
            CheckResult("SumWidenVectorBase_NPtr");
        }

        /// <summary>
        /// Sum Widen - Vector - base - Base_NRef .
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMyOut StaticSumWidenVectorBase_NRef(TMy[] src, int srcCount) {
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
                VectorTraitsBase.Statics.Widen_Base_NRef(p0, out lower, out upper);
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
        public void SumWidenVectorBase_NRef() {
            dstTMy = StaticSumWidenVectorBase_NRef(srcArray, srcArray.Length);
            CheckResult("SumWidenVectorBase_NRef");
        }

        /// <summary>
        /// Sum Widen - Vector - base - Base_NRef2 .
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMyOut StaticSumWidenVectorBase_NRef2(TMy[] src, int srcCount) {
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
                VectorTraitsBase.Statics.Widen_Base_NRef2(p0, out lower, out upper);
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
        public void SumWidenVectorBase_NRef2() {
            dstTMy = StaticSumWidenVectorBase_NRef2(srcArray, srcArray.Length);
            CheckResult("SumWidenVectorBase_NRef2");
        }

        /// <summary>
        /// Sum Widen - Vector - base - Base_NRefInc .
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMyOut StaticSumWidenVectorBase_NRefInc(TMy[] src, int srcCount) {
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
                VectorTraitsBase.Statics.Widen_Base_NRefInc(p0, out lower, out upper);
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
        public void SumWidenVectorBase_NRefInc() {
            dstTMy = StaticSumWidenVectorBase_NRefInc(srcArray, srcArray.Length);
            CheckResult("SumWidenVectorBase_NRefInc");
        }

        /// <summary>
        /// Sum Widen - Vector - base - Base_NRefInc2 .
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMyOut StaticSumWidenVectorBase_NRefInc2(TMy[] src, int srcCount) {
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
                VectorTraitsBase.Statics.Widen_Base_NRefInc2(p0, out lower, out upper);
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
        public void SumWidenVectorBase_NRefInc2() {
            dstTMy = StaticSumWidenVectorBase_NRefInc2(srcArray, srcArray.Length);
            CheckResult("SumWidenVectorBase_NRefInc2");
        }

        /// <summary>
        /// Sum Widen - Vector - base - Base_Ptr .
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe TMyOut StaticSumWidenVectorBase_Ptr(TMy[] src, int srcCount) {
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
                    VectorTraitsBase.Statics.Widen_Base_Ptr(*(Vector<TMy>*)p, out lower, out upper);
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
        public void SumWidenVectorBase_Ptr() {
            dstTMy = StaticSumWidenVectorBase_Ptr(srcArray, srcArray.Length);
            CheckResult("SumWidenVectorBase_Ptr");
        }

        /// <summary>
        /// Sum Widen - Vector - base - Base_Ref .
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMyOut StaticSumWidenVectorBase_Ref(TMy[] src, int srcCount) {
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
                VectorTraitsBase.Statics.Widen_Base_Ref(p0, out lower, out upper);
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
        public void SumWidenVectorBase_Ref() {
            dstTMy = StaticSumWidenVectorBase_Ref(srcArray, srcArray.Length);
            CheckResult("SumWidenVectorBase_Ref");
        }

        /// <summary>
        /// Sum Widen - Vector - base - Base_Ref2 .
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMyOut StaticSumWidenVectorBase_Ref2(TMy[] src, int srcCount) {
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
                VectorTraitsBase.Statics.Widen_Base_Ref2(p0, out lower, out upper);
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
        public void SumWidenVectorBase_Ref2() {
            dstTMy = StaticSumWidenVectorBase_Ref2(srcArray, srcArray.Length);
            CheckResult("SumWidenVectorBase_Ref2");
        }

        /// <summary>
        /// Sum Widen - Vector - base - Base_RefInc .
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMyOut StaticSumWidenVectorBase_RefInc(TMy[] src, int srcCount) {
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
                VectorTraitsBase.Statics.Widen_Base_RefInc(p0, out lower, out upper);
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
        public void SumWidenVectorBase_RefInc() {
            dstTMy = StaticSumWidenVectorBase_RefInc(srcArray, srcArray.Length);
            CheckResult("SumWidenVectorBase_RefInc");
        }

        /// <summary>
        /// Sum Widen - Vector - base - Base128_Ptr .
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe TMyOut StaticSumWidenVectorBase128_Ptr(TMy[] src, int srcCount) {
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
                    VectorTraits128Base.Statics.Widen_Base_Ptr(*(Vector<TMy>*)p, out lower, out upper);
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
        public void SumWidenVectorBase128_Ptr() {
            VectorTraits128Base.Statics.ThrowForUnsupported(true);
            dstTMy = StaticSumWidenVectorBase128_Ptr(srcArray, srcArray.Length);
            CheckResult("SumWidenVectorBase128_Ptr");
        }

        /// <summary>
        /// Sum Widen - Vector - base - Base128_Ref .
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMyOut StaticSumWidenVectorBase128_Ref(TMy[] src, int srcCount) {
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
                VectorTraits128Base.Statics.Widen_Base_Ref(p0, out lower, out upper);
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
        public void SumWidenVectorBase128_Ref() {
            VectorTraits128Base.Statics.ThrowForUnsupported(true);
            dstTMy = StaticSumWidenVectorBase128_Ref(srcArray, srcArray.Length);
            CheckResult("SumWidenVectorBase128_Ref");
        }

        /// <summary>
        /// Sum Widen - Vector - base - Base128_Ref2 .
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMyOut StaticSumWidenVectorBase128_Ref2(TMy[] src, int srcCount) {
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
                VectorTraits128Base.Statics.Widen_Base_Ref2(p0, out lower, out upper);
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
        public void SumWidenVectorBase128_Ref2() {
            VectorTraits128Base.Statics.ThrowForUnsupported(true);
            dstTMy = StaticSumWidenVectorBase128_Ref2(srcArray, srcArray.Length);
            CheckResult("SumWidenVectorBase128_Ref2");
        }

        /// <summary>
        /// Sum Widen - Vector - base - Base128_RefI .
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMyOut StaticSumWidenVectorBase128_RefI(TMy[] src, int srcCount) {
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
                VectorTraits128Base.Statics.Widen_Base_RefI(p0, out lower, out upper);
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
        public void SumWidenVectorBase128_RefI() {
            VectorTraits128Base.Statics.ThrowForUnsupported(true);
            dstTMy = StaticSumWidenVectorBase128_RefI(srcArray, srcArray.Length);
            CheckResult("SumWidenVectorBase128_RefI");
        }

        /// <summary>
        /// Sum Widen - Vector - base - Base128_RefI2 .
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMyOut StaticSumWidenVectorBase128_RefI2(TMy[] src, int srcCount) {
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
                VectorTraits128Base.Statics.Widen_Base_RefI2(p0, out lower, out upper);
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
        public void SumWidenVectorBase128_RefI2() {
            VectorTraits128Base.Statics.ThrowForUnsupported(true);
            dstTMy = StaticSumWidenVectorBase128_RefI2(srcArray, srcArray.Length);
            CheckResult("SumWidenVectorBase128_RefI2");
        }

        /// <summary>
        /// Sum Widen - Vector - base - Base128_RefInc .
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMyOut StaticSumWidenVectorBase128_RefInc(TMy[] src, int srcCount) {
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
                VectorTraits128Base.Statics.Widen_Base_RefInc(p0, out lower, out upper);
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
        public void SumWidenVectorBase128_RefInc() {
            VectorTraits128Base.Statics.ThrowForUnsupported(true);
            dstTMy = StaticSumWidenVectorBase128_RefInc(srcArray, srcArray.Length);
            CheckResult("SumWidenVectorBase128_RefInc");
        }

        /// <summary>
        /// Sum Widen - Vector - base - Base128_RefInc2 .
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMyOut StaticSumWidenVectorBase128_RefInc2(TMy[] src, int srcCount) {
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
                VectorTraits128Base.Statics.Widen_Base_RefInc2(p0, out lower, out upper);
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
        public void SumWidenVectorBase128_RefInc2() {
            VectorTraits128Base.Statics.ThrowForUnsupported(true);
            dstTMy = StaticSumWidenVectorBase128_RefInc2(srcArray, srcArray.Length);
            CheckResult("SumWidenVectorBase128_RefInc2");
        }

        /// <summary>
        /// Sum Widen - Vector - base - Base256_Ptr .
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe TMyOut StaticSumWidenVectorBase256_Ptr(TMy[] src, int srcCount) {
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
                    VectorTraits256Base.Statics.Widen_Base_Ptr(*(Vector<TMy>*)p, out lower, out upper);
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
        public void SumWidenVectorBase256_Ptr() {
            VectorTraits256Base.Statics.ThrowForUnsupported(true);
            dstTMy = StaticSumWidenVectorBase256_Ptr(srcArray, srcArray.Length);
            CheckResult("SumWidenVectorBase256_Ptr");
        }

        /// <summary>
        /// Sum Widen - Vector - base - Base256_Ref .
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMyOut StaticSumWidenVectorBase256_Ref(TMy[] src, int srcCount) {
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
                VectorTraits256Base.Statics.Widen_Base_Ref(p0, out lower, out upper);
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
        public void SumWidenVectorBase256_Ref() {
            VectorTraits256Base.Statics.ThrowForUnsupported(true);
            dstTMy = StaticSumWidenVectorBase256_Ref(srcArray, srcArray.Length);
            CheckResult("SumWidenVectorBase256_Ref");
        }

        /// <summary>
        /// Sum Widen - Vector - base - Base256_Ref2 .
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMyOut StaticSumWidenVectorBase256_Ref2(TMy[] src, int srcCount) {
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
                VectorTraits256Base.Statics.Widen_Base_Ref2(p0, out lower, out upper);
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
        public void SumWidenVectorBase256_Ref2() {
            VectorTraits256Base.Statics.ThrowForUnsupported(true);
            dstTMy = StaticSumWidenVectorBase256_Ref2(srcArray, srcArray.Length);
            CheckResult("SumWidenVectorBase256_Ref2");
        }

        /// <summary>
        /// Sum Widen - Vector - base - Base256_RefI .
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMyOut StaticSumWidenVectorBase256_RefI(TMy[] src, int srcCount) {
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
                VectorTraits256Base.Statics.Widen_Base_RefI(p0, out lower, out upper);
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
        public void SumWidenVectorBase256_RefI() {
            VectorTraits256Base.Statics.ThrowForUnsupported(true);
            dstTMy = StaticSumWidenVectorBase256_RefI(srcArray, srcArray.Length);
            CheckResult("SumWidenVectorBase256_RefI");
        }

        /// <summary>
        /// Sum Widen - Vector - base - Base256_RefI2 .
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMyOut StaticSumWidenVectorBase256_RefI2(TMy[] src, int srcCount) {
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
                VectorTraits256Base.Statics.Widen_Base_RefI2(p0, out lower, out upper);
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
        public void SumWidenVectorBase256_RefI2() {
            VectorTraits256Base.Statics.ThrowForUnsupported(true);
            dstTMy = StaticSumWidenVectorBase256_RefI2(srcArray, srcArray.Length);
            CheckResult("SumWidenVectorBase256_RefI2");
        }

        /// <summary>
        /// Sum Widen - Vector - base - Base256_RefInc .
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMyOut StaticSumWidenVectorBase256_RefInc(TMy[] src, int srcCount) {
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
                VectorTraits256Base.Statics.Widen_Base_RefInc(p0, out lower, out upper);
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
        public void SumWidenVectorBase256_RefInc() {
            VectorTraits256Base.Statics.ThrowForUnsupported(true);
            dstTMy = StaticSumWidenVectorBase256_RefInc(srcArray, srcArray.Length);
            CheckResult("SumWidenVectorBase256_RefInc");
        }

        /// <summary>
        /// Sum Widen - Vector - base - Base256_RefInc2 .
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMyOut StaticSumWidenVectorBase256_RefInc2(TMy[] src, int srcCount) {
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
                VectorTraits256Base.Statics.Widen_Base_RefInc2(p0, out lower, out upper);
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
        public void SumWidenVectorBase256_RefInc2() {
            VectorTraits256Base.Statics.ThrowForUnsupported(true);
            dstTMy = StaticSumWidenVectorBase256_RefInc2(srcArray, srcArray.Length);
            CheckResult("SumWidenVectorBase256_RefInc2");
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


#if NETCOREAPP3_0_OR_GREATER

        #region BENCHMARKS_128ALGORITHM
#if BENCHMARKS_128ALGORITHM

        #region BENCHMARKS_ALGORITHM
#if BENCHMARKS_ALGORITHM
#if NET5_0_OR_GREATER

        /// <summary>
        /// Sum Widen - Vector128 - Base_Ptr.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe TMyOut StaticSumWidenVector128_BasePtr(TMy[] src, int srcCount) {
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
                    WVectorTraits128Base.Statics.Widen_Base_Ptr(*(Vector128<TMy>*)p, out lower, out upper);
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

        //[Benchmark] // New: SumWidenVectorBase128_Ptr
        public void SumWidenVector128_BasePtr() {
            dstTMy = StaticSumWidenVector128_BasePtr(srcArray, srcArray.Length);
            CheckResult("SumWidenVector128_BasePtr");
        }

        /// <summary>
        /// Sum Widen - Vector128 - Base_Ref.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMyOut StaticSumWidenVector128_BaseRef(TMy[] src, int srcCount) {
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
                WVectorTraits128Base.Statics.Widen_Base_Ref(p0, out lower, out upper);
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

        //[Benchmark]
        public void SumWidenVector128_BaseRef() {
            dstTMy = StaticSumWidenVector128_BaseRef(srcArray, srcArray.Length);
            CheckResult("SumWidenVector128_BaseRef");
        }

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
    }
#pragma warning restore CS0618 // Type or member is obsolete

}
