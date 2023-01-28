#undef BENCHMARKS_OFF

using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Benchmarks.AVector.YC {
#if BENCHMARKS_OFF
    using BenchmarkAttribute = FakeBenchmarkAttribute;
#else
#endif // BENCHMARKS_OFF

    // My type.
    using TMy = Int16;

    /// <summary>
    /// YClamp benchmark - Int16.
    /// </summary>
#if NETCOREAPP3_0_OR_GREATER && DRY_JOB
    [DryJob]
#endif // NETCOREAPP3_0_OR_GREATER && DRY_JOB
    public partial class YClampBenchmark_Int16 : AbstractSharedBenchmark_Int16 {

        // -- var --
        private const TMy valueMin = (TMy)sbyte.MinValue;
        private const TMy valueMax = (TMy)sbyte.MaxValue;

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
            dstTMy = StaticSumClamp_If(srcArray, srcArray.Length, valueMin, valueMax);
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
                rt += n;
            }
            return rt;
        }

        [Benchmark]
        public void SumClamp_MinMax() {
            dstTMy = StaticSumClamp_MinMax(srcArray, srcArray.Length, valueMin, valueMax);
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
            dstTMy = StaticSumClamp_Math(srcArray, srcArray.Length, valueMin, valueMax);
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
            dstTMy = StaticSumClamp_BitUtil(srcArray, srcArray.Length, valueMin, valueMax);
            CheckResult("SumClamp_BitUtil");
        }

        #region BENCHMARKS_RAW
#if BENCHMARKS_RAW

        /// <summary>
        /// Sum Clamp - Vector use scalar.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="amin">The lower bound of the result (结果的下限).</param>
        /// <param name="amax">The upper bound of the result (结果的上限).</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMy StaticSumClampVectorScalar(TMy[] src, int srcCount, TMy amin, TMy amax) {
            TMy rt = 0; // Result.
            Vector<TMy> vectorMin = new Vector<TMy>(valueMin);
            Vector<TMy> vectorMax = new Vector<TMy>(valueMax);
            for (int i = 0; i < srcCount; ++i) {
                TMy t = src[i];
                Vector<TMy> vr = VectorTraitsBase.Statics.YClamp(new Vector<TMy>(t), vectorMin, vectorMax);
                rt += vr[0];
            }
            return rt;
        }

        [Benchmark]
        public void SumClampVectorScalar() {
            dstTMy = StaticSumClampVectorScalar(srcArray, srcArray.Length, valueMin, valueMax);
            CheckResult("SumClampVectorScalar");
        }

        /// <summary>
        /// Sum Clamp - Vector base.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumClampVectorBase(TMy[] src, int srcCount, TMy amin, TMy amax) {
            TMy rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            Vector<TMy> vectorMin = new Vector<TMy>(valueMin);
            Vector<TMy> vectorMax = new Vector<TMy>(valueMax);
            int i;
            // Body.
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<TMy> vtemp = VectorTraitsBase.Statics.YClamp(*(Vector<TMy>*)p, vectorMin, vectorMax);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += BitUtil.Clamp(p[i], amin, amax);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumClampVectorBase() {
            //Debugger.Break();
            dstTMy = StaticSumClampVectorBase(srcArray, srcArray.Length, valueMin, valueMax);
            CheckResult("SumClampVectorBase");
        }

#endif // BENCHMARKS_RAW
        #endregion // BENCHMARKS_RAW

        /// <summary>
        /// Sum Clamp - Vector Traits static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumClampVectorTraits(TMy[] src, int srcCount, TMy amin, TMy amax) {
            TMy rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            Vector<TMy> vectorMin = new Vector<TMy>(valueMin);
            Vector<TMy> vectorMax = new Vector<TMy>(valueMax);
            int i;
            // Body.
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<TMy> vtemp = Vectors.YClamp(*(Vector<TMy>*)p, vectorMin, vectorMax);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += BitUtil.Clamp(p[i], amin, amax);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumClampVectorTraits() {
            //Debugger.Break();
            dstTMy = StaticSumClampVectorTraits(srcArray, srcArray.Length, valueMin, valueMax);
            CheckResult("SumClampVectorTraits");
        }

    }
}
