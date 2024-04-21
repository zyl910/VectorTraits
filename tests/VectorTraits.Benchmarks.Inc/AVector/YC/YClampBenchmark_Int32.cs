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

namespace Zyl.VectorTraits.Benchmarks.AVector.YC {
#if BENCHMARKS_OFF
    using BenchmarkAttribute = FakeBenchmarkAttribute;
#else
#endif // BENCHMARKS_OFF

    // My type.
    using TMy = Int32;

    /// <summary>
    /// YClamp benchmark - Int32.
    /// </summary>
#if NETCOREAPP3_0_OR_GREATER && DRY_JOB
    [DryJob]
#endif // NETCOREAPP3_0_OR_GREATER && DRY_JOB
    public partial class YClampBenchmark_Int32 : AbstractSharedBenchmark_Int32 {

        // -- var --
        private const TMy valueMin = (TMy)Int16.MinValue;
        private const TMy valueMax = (TMy)Int16.MaxValue;

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
        /// Sum Clamp - BitMath.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="amin">The lower bound of the result (结果的下限).</param>
        /// <param name="amax">The upper bound of the result (结果的上限).</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMy StaticSumClamp_BitMath(TMy[] src, int srcCount, TMy amin, TMy amax) {
            TMy rt = 0; // Result.
            for (int i = 0; i < srcCount; ++i) {
                TMy t = src[i];
                rt += BitMath.Clamp(t, amin, amax);
            }
            return rt;
        }

        [Benchmark]
        public void SumClamp_BitMath() {
            dstTMy = StaticSumClamp_BitMath(srcArray, srcArray.Length, valueMin, valueMax);
            CheckResult("SumClamp_BitMath");
        }

        #region BENCHMARKS_RAW
#if BENCHMARKS_RAW

        /// <summary>
        /// Sum Clamp - Vector - use scalar.
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
        /// Sum Clamp - Vector - base.
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
                    rt += BitMath.Clamp(p[i], amin, amax);
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
        /// Sum Clamp - Vector Traits - static.
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
                    rt += BitMath.Clamp(p[i], amin, amax);
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


#if NETCOREAPP3_0_OR_GREATER

        #region BENCHMARKS_128ALGORITHM
#if BENCHMARKS_128ALGORITHM

        #region BENCHMARKS_ALGORITHM
#if BENCHMARKS_ALGORITHM
#if NET5_0_OR_GREATER

        /// <summary>
        /// Sum Clamp - Vector128 - AdvSimd.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumClampVector128_AdvSimd(TMy[] src, int srcCount, TMy amin, TMy amax) {
            TMy rt = 0; // Result.
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector result.
            Vector128<TMy> vectorMin = Vector128.Create(valueMin);
            Vector128<TMy> vectorMax = Vector128.Create(valueMax);
            int i;
            // Body.
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector128<TMy> vtemp = WVectorTraits128AdvSimd.Statics.YClamp(*(Vector128<TMy>*)p, vectorMin, vectorMax);
                    vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vtemp); // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += BitMath.Clamp(p[i], amin, amax);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt.GetElement(i);
            }
            return rt;
        }

        [Benchmark]
        public void SumClampVector128_AdvSimd() {
            WVectorTraits128AdvSimd.Statics.ThrowForUnsupported(true);
            //Debugger.Break();
            dstTMy = StaticSumClampVector128_AdvSimd(srcArray, srcArray.Length, valueMin, valueMax);
            CheckResult("SumClampVector128_AdvSimd");
        }

#endif // NET5_0_OR_GREATER

#endif // BENCHMARKS_ALGORITHM
        #endregion // BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum Clamp - Vector128 - Traits static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumClampVector128Traits(TMy[] src, int srcCount, TMy amin, TMy amax) {
            TMy rt = 0; // Result.
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector result.
            Vector128<TMy> vectorMin = Vector128.Create(valueMin);
            Vector128<TMy> vectorMax = Vector128.Create(valueMax);
            int i;
            // Body.
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector128<TMy> vtemp = Vector128s.YClamp(*(Vector128<TMy>*)p, vectorMin, vectorMax);
                    vrt = Vector128s.Add(vrt, vtemp); // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += BitMath.Clamp(p[i], amin, amax);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt.GetElement(i);
            }
            return rt;
        }

        [Benchmark]
        public void SumClampVector128Traits() {
            Vector128s.ThrowForUnsupported(true);
            //Debugger.Break();
            dstTMy = StaticSumClampVector128Traits(srcArray, srcArray.Length, valueMin, valueMax);
            CheckResult("SumClampVector128Traits");
        }

#endif // BENCHMARKS_128ALGORITHM
        #endregion // BENCHMARKS_128ALGORITHM

        #region BENCHMARKS_256ALGORITHM
#if BENCHMARKS_256ALGORITHM

        /// <summary>
        /// Sum Clamp - Vector256 - Traits static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumClampVector256Traits(TMy[] src, int srcCount, TMy amin, TMy amax) {
            TMy rt = 0; // Result.
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> vrt = Vector256<TMy>.Zero; // Vector result.
            Vector256<TMy> vectorMin = Vector256.Create(valueMin);
            Vector256<TMy> vectorMax = Vector256.Create(valueMax);
            int i;
            // Body.
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector256<TMy> vtemp = Vector256s.YClamp(*(Vector256<TMy>*)p, vectorMin, vectorMax);
                    vrt = Vector256s.Add(vrt, vtemp); // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += BitMath.Clamp(p[i], amin, amax);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt.GetElement(i);
            }
            return rt;
        }

        [Benchmark]
        public void SumClampVector256Traits() {
            Vector256s.ThrowForUnsupported(true);
            //Debugger.Break();
            dstTMy = StaticSumClampVector256Traits(srcArray, srcArray.Length, valueMin, valueMax);
            CheckResult("SumClampVector256Traits");
        }

#endif // BENCHMARKS_256ALGORITHM
        #endregion // BENCHMARKS_256ALGORITHM

#endif

        #region BENCHMARKS_512
#if BENCHMARKS_512 && NET8_0_OR_GREATER

        /// <summary>
        /// Sum Clamp - Vector512 - BCL static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static TMy StaticSumClampVector512Bcl(TMy[] src, int srcCount, TMy amin, TMy amax) {
            TMy rt = 0; // Result.
            int VectorWidth = Vector512<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector512<TMy> vrt = Vector512<TMy>.Zero; // Vector result.
            Vector512<TMy> vectorMin = Vector512.Create(valueMin);
            Vector512<TMy> vectorMax = Vector512.Create(valueMax);
            int i;
            // Body.
            ref Vector512<TMy> p0 = ref Unsafe.As<TMy, Vector512<TMy>>(ref src[0]);
            // Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector512<TMy> vtemp = Vector512s.YClamp(p0, vectorMin, vectorMax);
                vrt = Vector512s.Add(vrt, vtemp); // Add.
                p0 = ref Unsafe.Add(ref p0, 1);
            }
            // Remainder processs.
            ref TMy p = ref Unsafe.As<Vector512<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += BitMath.Clamp(Unsafe.Add(ref p, i), amin, amax);
            }
            // Reduce.
            rt = Vector512s.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void SumClampVector512Bcl() {
            Vector512s.ThrowForUnsupported(true);
            //Debugger.Break();
            dstTMy = StaticSumClampVector512Bcl(srcArray, srcArray.Length, valueMin, valueMax);
            CheckResult("SumClampVector512Bcl");
        }

        /// <summary>
        /// Sum Clamp - Vector512 - Traits static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static TMy StaticSumClampVector512Traits(TMy[] src, int srcCount, TMy amin, TMy amax) {
            TMy rt = 0; // Result.
            int VectorWidth = Vector512<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector512<TMy> vrt = Vector512<TMy>.Zero; // Vector result.
            Vector512<TMy> vectorMin = Vector512.Create(valueMin);
            Vector512<TMy> vectorMax = Vector512.Create(valueMax);
            int i;
            // Body.
            ref Vector512<TMy> p0 = ref Unsafe.As<TMy, Vector512<TMy>>(ref src[0]);
            // Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector512<TMy> vtemp = Vector512s.YClamp(p0, vectorMin, vectorMax);
                vrt = Vector512s.Add(vrt, vtemp); // Add.
                p0 = ref Unsafe.Add(ref p0, 1);
            }
            // Remainder processs.
            ref TMy p = ref Unsafe.As<Vector512<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += BitMath.Clamp(Unsafe.Add(ref p, i), amin, amax);
            }
            // Reduce.
            rt = Vector512s.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void SumClampVector512Traits() {
            Vector512s.ThrowForUnsupported(true);
            //Debugger.Break();
            dstTMy = StaticSumClampVector512Traits(srcArray, srcArray.Length, valueMin, valueMax);
            CheckResult("SumClampVector512Traits");
        }

#endif // BENCHMARKS_512 && NET8_0_OR_GREATER
        #endregion // BENCHMARKS_512

    }
}
