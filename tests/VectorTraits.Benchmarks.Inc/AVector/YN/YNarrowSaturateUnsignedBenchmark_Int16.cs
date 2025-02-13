﻿//#undef BENCHMARKS_OFF

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
using System.Threading;
using Zyl.VectorTraits.Impl;
using Zyl.VectorTraits.Impl.AVector;
using Zyl.VectorTraits.Impl.AVector128;
using Zyl.VectorTraits.Impl.AVector512;

namespace Zyl.VectorTraits.Benchmarks.AVector.YN {
#if BENCHMARKS_OFF
    using BenchmarkAttribute = FakeBenchmarkAttribute;
#else
#endif // BENCHMARKS_OFF

    // My type.
    using TMy = Int16;
    using TMyOut = Byte;

    /// <summary>
    /// Narrow benchmark - Int16.
    /// </summary>
#if NETCOREAPP3_0_OR_GREATER && DRY_JOB
    [DryJob]
#endif // NETCOREAPP3_0_OR_GREATER && DRY_JOB
    public partial class YNarrowSaturateUnsignedBenchmark_Int16 : AbstractSharedBenchmark_Int16_Byte {

        // -- var --
        private const TMy amin = TMyOut.MinValue;
        private const TMy amax = TMyOut.MaxValue;

        /// <summary>
        /// Narrow - If .
        /// </summary>
        /// <param name="t">Source value.</param>
        /// <returns>Returns narrowed.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMyOut Narrow_If(TMy t) {
            TMy rt = (t < amax) ? ((t > amin) ? t : amin) : amax;
            return (TMyOut)rt;
        }

        /// <summary>
        /// Narrow - MinMax .
        /// </summary>
        /// <param name="t">Source value.</param>
        /// <returns>Returns narrowed.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMyOut Narrow_MinMax(TMy t) {
            TMy rt = Math.Min(Math.Max(t, amin), amax);
            return (TMyOut)rt;
        }

        /// <summary>
        /// Narrow - BitMath .
        /// </summary>
        /// <param name="t">Source value.</param>
        /// <returns>Returns narrowed.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMyOut Narrow_BitMath(TMy t) {
            TMy rt = BitMath.Clamp(t, amin, amax);
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
        /// Sum Narrow - BitMath.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        public static TMyOut StaticSumNarrow_BitMath(TMy[] src, int srcCount) {
            TMyOut rt = 0; // Result.
            for (int i = 0; i < srcCount; ++i) {
                rt += Narrow_BitMath(src[i]);
            }
            return rt;
        }

        [Benchmark]
        public void SumNarrow_BitMath() {
            dstTMy = StaticSumNarrow_BitMath(srcArray, srcArray.Length);
            CheckResult("SumNarrow_BitMath");
        }

        /// <summary>
        /// Sum Narrow - BitMath - Loop unrolling *4.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMyOut StaticSumNarrow_BitMathUnrolling4(TMy[] src, int srcCount) {
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
                rt += Narrow_BitMath(t);
                TMy t1 = src[p + 1];
                rt1 += Narrow_BitMath(t1);
                TMy t2 = src[p + 2];
                rt2 += Narrow_BitMath(t2);
                TMy t3 = src[p + 3];
                rt3 += Narrow_BitMath(t3);
                p += nBlockWidth;
            }
            // Remainder processs.
            //p = cntBlock * nBlockWidth;
            for (i = 0; i < cntRem; ++i) {
                TMy t = src[p + i];
                rt += Narrow_BitMath(t);
            }
            // Reduce.
            rt = (TMyOut)(rt + rt1 + rt2 + rt3);
            return rt;
        }

        [Benchmark]
        public void SumNarrow_BitMathUnrolling4() {
            dstTMy = StaticSumNarrow_BitMathUnrolling4(srcArray, srcArray.Length);
            CheckResult("SumNarrow_BitMathUnrolling4");
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
                vrt += VectorTraitsBase.Statics.YNarrowSaturateUnsigned(p0, Unsafe.Add(ref p0, 1));
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += Narrow_BitMath(Unsafe.Add(ref p, i));
            }
            // Reduce.
            for (i = 0; i < Vector<TMyOut>.Count; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumNarrowVectorBase() {
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
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
                vrt += Vectors.YNarrowSaturateUnsigned(p0, Unsafe.Add(ref p0, 1));
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += Narrow_BitMath(Unsafe.Add(ref p, i));
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

#if NET7_0_OR_GREATER
        /// <summary>
        /// Sum Narrow - Vector128 - Base static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        public static TMyOut StaticSumNarrowVector128Base(TMy[] src, int srcCount) {
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
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                var t = WVectorTraits128Base.Statics.YNarrowSaturateUnsigned(p0, Unsafe.Add(ref p0, 1));
                vrt = Vector128.Add(vrt, t);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += Narrow_BitMath(Unsafe.Add(ref p, i));
            }
            // Reduce.
            for (i = 0; i < Vector128<TMyOut>.Count; ++i) {
                rt += vrt.GetElement(i);
            }
            return rt;
        }

        [Benchmark]
        public void SumNarrowVector128Base() {
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSumNarrowVector128Base(srcArray, srcArray.Length);
            CheckResult("SumNarrowVector128Base");
        }
#endif // NET7_0_OR_GREATER

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
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                var t = Vector128s.YNarrowSaturateUnsigned(p0, Unsafe.Add(ref p0, 1));
                vrt = Vector128s.Add(vrt, t);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += Narrow_BitMath(Unsafe.Add(ref p, i));
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
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                var t = Vector256s.YNarrowSaturateUnsigned(p0, Unsafe.Add(ref p0, 1));
                vrt = Vector256s.Add(vrt, t);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            ref TMy p = ref Unsafe.As<Vector256<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += Narrow_BitMath(Unsafe.Add(ref p, i));
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

#if NET8_0_OR_GREATER

        #region BENCHMARKS_512ALGORITHM
#if BENCHMARKS_512ALGORITHM

        /// <summary>
        /// Sum Narrow - Vector512 - Base static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        public static TMyOut StaticSumNarrowVector512Base(TMy[] src, int srcCount) {
            TMyOut rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector512<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector512<TMyOut> vrt = Vector512<TMyOut>.Zero; // Vector512 result.
            int i;
            // Body.
            ref Vector512<TMy> p0 = ref Unsafe.As<TMy, Vector512<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                var t = WVectorTraits512Base.Statics.YNarrowSaturateUnsigned(p0, Unsafe.Add(ref p0, 1));
                vrt = Vector512.Add(vrt, t);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            ref TMy p = ref Unsafe.As<Vector512<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += Narrow_BitMath(Unsafe.Add(ref p, i));
            }
            // Reduce.
            for (i = 0; i < Vector512<TMyOut>.Count; ++i) {
                rt += vrt.GetElement(i);
            }
            return rt;
        }

        [Benchmark]
        public void SumNarrowVector512Base() {
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSumNarrowVector512Base(srcArray, srcArray.Length);
            CheckResult("SumNarrowVector512Base");
        }

        /// <summary>
        /// Sum Narrow - Vector512 - Traits static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        public static TMyOut StaticSumNarrowVector512Traits(TMy[] src, int srcCount) {
            TMyOut rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector512<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector512<TMyOut> vrt = Vector512<TMyOut>.Zero; // Vector512 result.
            int i;
            // Body.
            ref Vector512<TMy> p0 = ref Unsafe.As<TMy, Vector512<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                var t = Vector512s.YNarrowSaturateUnsigned(p0, Unsafe.Add(ref p0, 1));
                vrt = Vector512s.Add(vrt, t);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            ref TMy p = ref Unsafe.As<Vector512<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += Narrow_BitMath(Unsafe.Add(ref p, i));
            }
            // Reduce.
            for (i = 0; i < Vector512<TMyOut>.Count; ++i) {
                rt += vrt.GetElement(i);
            }
            return rt;
        }

        [Benchmark]
        public void SumNarrowVector512Traits() {
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSumNarrowVector512Traits(srcArray, srcArray.Length);
            CheckResult("SumNarrowVector512Traits");
        }

        /// <summary>
        /// Sum Narrow - Vector512 - Convert static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        public static TMyOut StaticSumNarrowVector512_Convert(TMy[] src, int srcCount) {
            TMyOut rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector512<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector512<TMyOut> vrt = Vector512<TMyOut>.Zero; // Vector512 result.
            int i;
            // Body.
            ref Vector512<TMy> p0 = ref Unsafe.As<TMy, Vector512<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                var t = WVectorTraits512Avx512.Statics.YNarrowSaturateUnsigned_Convert(p0, Unsafe.Add(ref p0, 1));
                vrt = Vector512.Add(vrt, t);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            ref TMy p = ref Unsafe.As<Vector512<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += Narrow_BitMath(Unsafe.Add(ref p, i));
            }
            // Reduce.
            for (i = 0; i < Vector512<TMyOut>.Count; ++i) {
                rt += vrt.GetElement(i);
            }
            return rt;
        }

        [Benchmark]
        public void SumNarrowVector512_Convert() {
            WVectorTraits512Avx512.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSumNarrowVector512_Convert(srcArray, srcArray.Length);
            CheckResult("SumNarrowVector512_Convert");
        }

#endif // BENCHMARKS_512ALGORITHM
        #endregion // BENCHMARKS_512ALGORITHM

#endif // NET8_0_OR_GREATER
    }
}
