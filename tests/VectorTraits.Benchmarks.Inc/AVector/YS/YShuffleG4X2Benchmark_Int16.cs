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
using System.Threading;
using Zyl.VectorTraits.Extensions;
using Zyl.VectorTraits.Impl;
using Zyl.VectorTraits.Impl.AVector;
using Zyl.VectorTraits.Impl.AVector128;
using Zyl.VectorTraits.Impl.AVector256;

namespace Zyl.VectorTraits.Benchmarks.AVector.S {
#if BENCHMARKS_OFF
    using BenchmarkAttribute = FakeBenchmarkAttribute;
#else
#endif // BENCHMARKS_OFF

    // My type.
    using TMy = Int16;

    /// <summary>
    /// YShuffleG4X2 benchmark - Int16.
    /// </summary>
#if NETCOREAPP3_0_OR_GREATER && DRY_JOB
    [DryJob]
#endif // NETCOREAPP3_0_OR_GREATER && DRY_JOB
    public partial class YShuffleG4X2Benchmark_Int16 : AbstractSharedBenchmark_Int16 {
#pragma warning disable CS0162 // Unreachable code detected

        // -- var --
        private const bool UseReduce = false;
        private const ShuffleControlG4 control = ShuffleControlG4.WZYX;

        /// <summary>
        /// Sum YShuffleG4X2 - Vector - base.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="control">The control.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumYShuffleG4X2VectorBase(TMy[] src, int srcCount, ShuffleControlG4 control) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            //int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            Vector<TMy> vrt1 = Vector<TMy>.Zero;
            int i;
            // Body.
            ref Vector<TMy> p0 = ref Unsafe.As<TMy, Vector<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                (var temp0, var temp1) = VectorTraitsBase.Statics.YShuffleG4X2(p0, Unsafe.Add(ref p0, 1), control);
                vrt += temp0;
                vrt1 += temp1;
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt += vrt1;
            if (UseReduce) {
                for (i = 0; i < VectorWidth; ++i) {
                    rt += vrt[i];
                }
            } else {
                rt = vrt[0];
            }
            return rt;
        }

        [Benchmark(Baseline = true)]
        public void SumYShuffleG4X2VectorBase() {
            //Debugger.Break();
            dstTMy = StaticSumYShuffleG4X2VectorBase(srcArray, srcArray.Length, control);
            if (CheckMode) {
                baselineTMy = dstTMy;
                BenchmarkUtil.WriteItem("# SumYShuffleG4X2VectorBase", string.Format("{0}", baselineTMy));
            }
        }

        /// <summary>
        /// Sum YShuffleG4X2 - Vector Traits - static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="control">The control.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumYShuffleG4X2VectorTraits(TMy[] src, int srcCount, ShuffleControlG4 control) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            //int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            Vector<TMy> vrt1 = Vector<TMy>.Zero;
            int i;
            // Body.
            ref Vector<TMy> p0 = ref Unsafe.As<TMy, Vector<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                (var temp0, var temp1) = Vectors.YShuffleG4X2(p0, Unsafe.Add(ref p0, 1), control);
                vrt += temp0;
                vrt1 += temp1;
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt += vrt1;
            if (UseReduce) {
                for (i = 0; i < VectorWidth; ++i) {
                    rt += vrt[i];
                }
            } else {
                rt = vrt[0];
            }
            return rt;
        }

        [Benchmark]
        public void SumYShuffleG4X2VectorTraits() {
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
            }
            dstTMy = StaticSumYShuffleG4X2VectorTraits(srcArray, srcArray.Length, control);
            CheckResult("SumYShuffleG4X2VectorTraits");
        }


#if NETCOREAPP3_0_OR_GREATER

        #region BENCHMARKS_128ALGORITHM
#if BENCHMARKS_128ALGORITHM

        #region BENCHMARKS_ALGORITHM
#if BENCHMARKS_ALGORITHM

#if NET5_0_OR_GREATER

        /// <summary>
        /// Sum YShuffleG4X2 - Vector128 - Arm.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="control">The control.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumYShuffleG4X2Vector128_Arm(TMy[] src, int srcCount, ShuffleControlG4 control) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            //int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector result.
            Vector128<TMy> vrt1 = Vector128<TMy>.Zero;
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                (var temp0, var temp1) = WVectorTraits128AdvSimd.Statics.YShuffleG4X2(p0, Unsafe.Add(ref p0, 1), control);
                vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, temp0);
                vrt1 = WVectorTraits128AdvSimd.Statics.Add(vrt1, temp1);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vrt1);
            if (UseReduce) {
                for (i = 0; i < VectorWidth; ++i) {
                    rt += vrt.GetElement(i);
                }
            } else {
                rt = vrt.GetElement(0);
            }
            return rt;
        }

        [Benchmark]
        public void SumYShuffleG4X2Vector128_Arm() {
            WVectorTraits128AdvSimd.Statics.ThrowForUnsupported(true);
            if (Vector<byte>.Count != Vector128<byte>.Count) {
                throw new NotSupportedException(string.Format("Vector byte size mismatch({0}!={1}) !", Vector<byte>.Count, Vector128<byte>.Count));
            }
            //Debugger.Break();
            dstTMy = StaticSumYShuffleG4X2Vector128_Arm(srcArray, srcArray.Length, control);
            CheckResult("SumYShuffleG4X2Vector128_Arm");
        }

#endif // NET5_0_OR_GREATER

#endif // BENCHMARKS_ALGORITHM
        #endregion // BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum YShuffleG4X2 - Vector128 - Traits static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="control">The control.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumYShuffleG4X2Vector128Traits(TMy[] src, int srcCount, ShuffleControlG4 control) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            //int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector result.
            Vector128<TMy> vrt1 = Vector128<TMy>.Zero;
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                (var temp0, var temp1) = Vector128s.YShuffleG4X2(p0, Unsafe.Add(ref p0, 1), control);
                vrt = Vector128s.Add(vrt, temp0);
                vrt1 = Vector128s.Add(vrt1, temp1);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = Vector128s.Add(vrt, vrt1);
            if (UseReduce) {
                for (i = 0; i < VectorWidth; ++i) {
                    rt += vrt.GetElement(i);
                }
            } else {
                rt = vrt.GetElement(0);
            }
            return rt;
        }

        [Benchmark]
        public void SumYShuffleG4X2Vector128Traits() {
            Vector128s.ThrowForUnsupported(true);
            if (Vector<byte>.Count != Vector128<byte>.Count) {
                throw new NotSupportedException(string.Format("Vector byte size mismatch({0}!={1}) !", Vector<byte>.Count, Vector128<byte>.Count));
            }
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
            }
            dstTMy = StaticSumYShuffleG4X2Vector128Traits(srcArray, srcArray.Length, control);
            CheckResult("SumYShuffleG4X2Vector128Traits");
        }

#endif // BENCHMARKS_128ALGORITHM
        #endregion // BENCHMARKS_128ALGORITHM

        #region BENCHMARKS_256ALGORITHM
#if BENCHMARKS_256ALGORITHM

        /// <summary>
        /// Sum YShuffleG4X2 - Vector256 - Traits static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="control">The control.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumYShuffleG4X2Vector256Traits(TMy[] src, int srcCount, ShuffleControlG4 control) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            //int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> vrt = Vector256<TMy>.Zero; // Vector result.
            Vector256<TMy> vrt1 = Vector256<TMy>.Zero;
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                (var temp0, var temp1) = Vector256s.YShuffleG4X2(p0, Unsafe.Add(ref p0, 1), control);
                vrt = Vector256s.Add(vrt, temp0);
                vrt1 = Vector256s.Add(vrt1, temp1);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = Vector256s.Add(vrt, vrt1);
            if (UseReduce) {
                for (i = 0; i < VectorWidth; ++i) {
                    rt += vrt.GetElement(i);
                }
            } else {
                rt = vrt.GetElement(0);
            }
            return rt;
        }

        [Benchmark]
        public void SumYShuffleG4X2Vector256Traits() {
            Vector256s.ThrowForUnsupported(true);
            if (Vector<byte>.Count != Vector256<byte>.Count) {
                throw new NotSupportedException(string.Format("Vector byte size mismatch({0}!={1}) !", Vector<byte>.Count, Vector256<byte>.Count));
            }
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
            }
            dstTMy = StaticSumYShuffleG4X2Vector256Traits(srcArray, srcArray.Length, control);
            CheckResult("SumYShuffleG4X2Vector256Traits");
        }

#endif // BENCHMARKS_256ALGORITHM
        #endregion // BENCHMARKS_256ALGORITHM

#endif

        /// <summary>
        /// Sum YShuffleG4X2_Const - Vector Traits - static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="control">The control.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumYShuffleG4X2_ConstVectorTraits(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            //int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            Vector<TMy> vrt1 = Vector<TMy>.Zero;
            int i;
            // Body.
            ref Vector<TMy> p0 = ref Unsafe.As<TMy, Vector<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                (var temp0, var temp1) = Vectors.YShuffleG4X2_Const(p0, Unsafe.Add(ref p0, 1), control);
                vrt += temp0;
                vrt1 += temp1;
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt += vrt1;
            if (UseReduce) {
                for (i = 0; i < VectorWidth; ++i) {
                    rt += vrt[i];
                }
            } else {
                rt = vrt[0];
            }
            return rt;
        }

        [Benchmark]
        public void SumYShuffleG4X2_ConstVectorTraits() {
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
            }
            dstTMy = StaticSumYShuffleG4X2_ConstVectorTraits(srcArray, srcArray.Length);
            CheckResult("SumYShuffleG4X2_ConstVectorTraits");
        }


#if NETCOREAPP3_0_OR_GREATER

        #region BENCHMARKS_128ALGORITHM
#if BENCHMARKS_128ALGORITHM

        #region BENCHMARKS_ALGORITHM
#if BENCHMARKS_ALGORITHM

#endif // BENCHMARKS_ALGORITHM
        #endregion // BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum YShuffleG4X2_Const - Vector128 - Traits static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="control">The control.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumYShuffleG4X2_ConstVector128Traits(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            //int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector result.
            Vector128<TMy> vrt1 = Vector128<TMy>.Zero;
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                (var temp0, var temp1) = Vector128s.YShuffleG4X2_Const(p0, Unsafe.Add(ref p0, 1), control);
                vrt = Vector128s.Add(vrt, temp0);
                vrt1 = Vector128s.Add(vrt1, temp1);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = Vector128s.Add(vrt, vrt1);
            if (UseReduce) {
                for (i = 0; i < VectorWidth; ++i) {
                    rt += vrt.GetElement(i);
                }
            } else {
                rt = vrt.GetElement(0);
            }
            return rt;
        }

        [Benchmark]
        public void SumYShuffleG4X2_ConstVector128Traits() {
            Vector128s.ThrowForUnsupported(true);
            if (Vector<byte>.Count != Vector128<byte>.Count) {
                throw new NotSupportedException(string.Format("Vector byte size mismatch({0}!={1}) !", Vector<byte>.Count, Vector128<byte>.Count));
            }
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
            }
            dstTMy = StaticSumYShuffleG4X2_ConstVector128Traits(srcArray, srcArray.Length);
            CheckResult("SumYShuffleG4X2_ConstVector128Traits");
        }

#endif // BENCHMARKS_128ALGORITHM
        #endregion // BENCHMARKS_128ALGORITHM

        #region BENCHMARKS_256ALGORITHM
#if BENCHMARKS_256ALGORITHM

        /// <summary>
        /// Sum YShuffleG4X2_Const - Vector256 - Traits static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="control">The control.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumYShuffleG4X2_ConstVector256Traits(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            //int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> vrt = Vector256<TMy>.Zero; // Vector result.
            Vector256<TMy> vrt1 = Vector256<TMy>.Zero;
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                (var temp0, var temp1) = Vector256s.YShuffleG4X2_Const(p0, Unsafe.Add(ref p0, 1), control);
                vrt = Vector256s.Add(vrt, temp0);
                vrt1 = Vector256s.Add(vrt1, temp1);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = Vector256s.Add(vrt, vrt1);
            if (UseReduce) {
                for (i = 0; i < VectorWidth; ++i) {
                    rt += vrt.GetElement(i);
                }
            } else {
                rt = vrt.GetElement(0);
            }
            return rt;
        }

        [Benchmark]
        public void SumYShuffleG4X2_ConstVector256Traits() {
            Vector256s.ThrowForUnsupported(true);
            if (Vector<byte>.Count != Vector256<byte>.Count) {
                throw new NotSupportedException(string.Format("Vector byte size mismatch({0}!={1}) !", Vector<byte>.Count, Vector256<byte>.Count));
            }
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
            }
            dstTMy = StaticSumYShuffleG4X2_ConstVector256Traits(srcArray, srcArray.Length);
            CheckResult("SumYShuffleG4X2_ConstVector256Traits");
        }

#endif // BENCHMARKS_256ALGORITHM
        #endregion // BENCHMARKS_256ALGORITHM

#endif

#pragma warning restore CS0162 // Unreachable code detected
    }
}
