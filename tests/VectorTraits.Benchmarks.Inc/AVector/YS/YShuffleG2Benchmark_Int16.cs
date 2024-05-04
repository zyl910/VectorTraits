//#undef BENCHMARKS_OFF
#if !REDUCE_MEMORY_USAGE
#define BENCHMARKS_CONST
#endif

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
using Zyl.VectorTraits.Impl.AVector512;

namespace Zyl.VectorTraits.Benchmarks.AVector.S {
#if BENCHMARKS_OFF
    using BenchmarkAttribute = FakeBenchmarkAttribute;
#else
#endif // BENCHMARKS_OFF

    // My type.
    using TMy = Int16;

    /// <summary>
    /// YShuffleG2 benchmark - Int16.
    /// </summary>
#if NETCOREAPP3_0_OR_GREATER && DRY_JOB
    [DryJob]
#endif // NETCOREAPP3_0_OR_GREATER && DRY_JOB
    public partial class YShuffleG2Benchmark_Int16 : AbstractSharedBenchmark_Int16 {
#pragma warning disable CS0162 // Unreachable code detected

        // -- var --
        private const bool UseReduce = false;
        private const ShuffleControlG2 control = ShuffleControlG2.YX;

        /// <summary>
        /// Sum YShuffleG2 - Scalar.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="control">The control.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumScalar(TMy[] src, int srcCount, ShuffleControlG2 control) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            ref Vector<TMy> p0 = ref Unsafe.As<TMy, Vector<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector<TMy> vtemp = VectorTraitsBase.Statics.YShuffleG2_Basic(p0, control);
                vrt += vtemp; // Add.
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
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
        public void SumScalar() {
            //Debugger.Break();
            dstTMy = StaticSumScalar(srcArray, srcArray.Length, control);
            if (CheckMode) {
                baselineTMy = dstTMy;
                BenchmarkUtil.WriteItem("# SumScalar", string.Format("{0}", baselineTMy));
            }
        }

        #region BENCHMARKS_ALGORITHM
#if BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum YShuffleG2 - Vector - base.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="control">The control.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumBase(TMy[] src, int srcCount, ShuffleControlG2 control) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            ref Vector<TMy> p0 = ref Unsafe.As<TMy, Vector<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector<TMy> vtemp = VectorTraitsBase.Statics.YShuffleG2(p0, control);
                vrt += vtemp; // Add.
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
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
        public void SumBase() {
            //Debugger.Break();
            dstTMy = StaticSumBase(srcArray, srcArray.Length, control);
            CheckResult("SumBase");
        }

#endif // BENCHMARKS_ALGORITHM
        #endregion // BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum YShuffleG2 - Vector Traits - static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="control">The control.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumTraits(TMy[] src, int srcCount, ShuffleControlG2 control) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            ref Vector<TMy> p0 = ref Unsafe.As<TMy, Vector<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector<TMy> vtemp = Vectors.YShuffleG2(p0, control);
                vrt += vtemp; // Add.
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
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
        public void SumTraits() {
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSumTraits(srcArray, srcArray.Length, control);
            CheckResult("SumTraits");
        }


        #region BENCHMARKS_128
#if BENCHMARKS_128 && NETCOREAPP3_0_OR_GREATER

#if NET7_0_OR_GREATER
        /// <summary>
        /// Sum YShuffleG2 - Vector128 - Base static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="control">The control.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128Base(TMy[] src, int srcCount, ShuffleControlG2 control) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector result.
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector128<TMy> vtemp = WVectorTraits128Base.Statics.YShuffleG2(p0, control);
                vrt = WVectorTraits128Base.Statics.Add(vrt, vtemp);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            if (UseReduce) {
                rt = Vector128.Sum(vrt);
            } else {
                rt = vrt.GetElement(0);
            }
            return rt;
        }

        [Benchmark]
        public void Sum128Base() {
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
            }
            dstTMy = StaticSum128Base(srcArray, srcArray.Length, control);
        }
#endif // NET7_0_OR_GREATER

        #region BENCHMARKS_ALGORITHM
#if BENCHMARKS_ALGORITHM

#if NET5_0_OR_GREATER

        /// <summary>
        /// Sum YShuffleG2 - Vector128 - AdvSimd.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="control">The control.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128_AdvSimd(TMy[] src, int srcCount, ShuffleControlG2 control) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector result.
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector128<TMy> vtemp = WVectorTraits128AdvSimd.Statics.YShuffleG2(p0, control);
                vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vtemp);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
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
        public void Sum128_AdvSimd() {
            WVectorTraits128AdvSimd.Statics.ThrowForUnsupported(true);
            if (Vector<byte>.Count != Vector128<byte>.Count) {
                throw new NotSupportedException(string.Format("Vector byte size mismatch({0}!={1}) !", Vector<byte>.Count, Vector128<byte>.Count));
            }
            //Debugger.Break();
            dstTMy = StaticSum128_AdvSimd(srcArray, srcArray.Length, control);
            CheckResult("Sum128_AdvSimd");
        }

#endif // NET5_0_OR_GREATER

#endif // BENCHMARKS_ALGORITHM
        #endregion // BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum YShuffleG2 - Vector128 - Traits static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="control">The control.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128Traits(TMy[] src, int srcCount, ShuffleControlG2 control) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector result.
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector128<TMy> vtemp = Vector128s.YShuffleG2(p0, control);
                vrt = Vector128s.Add(vrt, vtemp);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
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
        public void Sum128Traits() {
            Vector128s.ThrowForUnsupported(true);
            if (Vector<byte>.Count != Vector128<byte>.Count) {
                throw new NotSupportedException(string.Format("Vector byte size mismatch({0}!={1}) !", Vector<byte>.Count, Vector128<byte>.Count));
            }
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
            }
            dstTMy = StaticSum128Traits(srcArray, srcArray.Length, control);
            CheckResult("Sum128Traits");
        }

#endif // BENCHMARKS_128 && NETCOREAPP3_0_OR_GREATER
        #endregion // BENCHMARKS_128

        #region BENCHMARKS_256
#if BENCHMARKS_256 && NETCOREAPP3_0_OR_GREATER

        /// <summary>
        /// Sum YShuffleG2 - Vector256 - Traits static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="control">The control.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum256Traits(TMy[] src, int srcCount, ShuffleControlG2 control) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> vrt = Vector256<TMy>.Zero; // Vector result.
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256<TMy> vtemp = Vector256s.YShuffleG2(p0, control);
                vrt = Vector256s.Add(vrt, vtemp);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
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
        public void Sum256Traits() {
            Vector256s.ThrowForUnsupported(true);
            if (Vector<byte>.Count != Vector256<byte>.Count) {
                throw new NotSupportedException(string.Format("Vector byte size mismatch({0}!={1}) !", Vector<byte>.Count, Vector256<byte>.Count));
            }
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
            }
            dstTMy = StaticSum256Traits(srcArray, srcArray.Length, control);
            CheckResult("Sum256Traits");
        }

#endif // BENCHMARKS_256 && NETCOREAPP3_0_OR_GREATER
        #endregion // BENCHMARKS_256

        #region BENCHMARKS_512
#if BENCHMARKS_512 && NET8_0_OR_GREATER

        protected TMy dstOn512 = default, baselineOn512 = default;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected virtual void CheckResult512(string name) {
            CheckResult_Report(name, dstOn512 != baselineOn512, dstOn512, baselineOn512);
        }

        /// <summary>
        /// Sum YShuffleG2 - Vector512 - Base static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="control">The control.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum512Base(TMy[] src, int srcCount, ShuffleControlG2 control) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector512<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector512<TMy> vrt = Vector512<TMy>.Zero; // Vector result.
            int i;
            // Body.
            ref Vector512<TMy> p0 = ref Unsafe.As<TMy, Vector512<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector512<TMy> vtemp = WVectorTraits512Base.Statics.YShuffleG2(p0, control);
                vrt = WVectorTraits512Base.Statics.Add(vrt, vtemp);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            if (UseReduce) {
                rt = Vector512.Sum(vrt);
            } else {
                rt = vrt.GetElement(0);
            }
            return rt;
        }

        [Benchmark]
        public void Sum512Base() {
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn512 = StaticSum512Base(srcArray, srcArray.Length, control);
            if (CheckMode) {
                baselineOn512 = dstOn512;
                BenchmarkUtil.WriteItem("# Sum512Base", string.Format("{0}", baselineOn512));
            }
        }

        /// <summary>
        /// Sum YShuffleG2 - Vector512 - Traits static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="control">The control.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum512Traits(TMy[] src, int srcCount, ShuffleControlG2 control) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector512<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector512<TMy> vrt = Vector512<TMy>.Zero; // Vector result.
            int i;
            // Body.
            ref Vector512<TMy> p0 = ref Unsafe.As<TMy, Vector512<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector512<TMy> vtemp = Vector512s.YShuffleG2(p0, control);
                vrt = Vector512s.Add(vrt, vtemp);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            if (UseReduce) {
                rt = Vector512s.Sum(vrt);
            } else {
                rt = vrt.GetElement(0);
            }
            return rt;
        }

        [Benchmark]
        public void Sum512Traits() {
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
            }
            dstTMy = StaticSum512Traits(srcArray, srcArray.Length, control);
            CheckResult512("Sum512Traits");
        }

#endif // BENCHMARKS_512 && NET8_0_OR_GREATER
        #endregion // BENCHMARKS_512


        #region BENCHMARKS_CONST
#if BENCHMARKS_CONST
        /// <summary>
        /// Sum YShuffleG2_Const - Vector Traits - static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="control">The control.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum_ConstTraits(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            ref Vector<TMy> p0 = ref Unsafe.As<TMy, Vector<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector<TMy> vtemp = Vectors.YShuffleG2_Const(p0, control);
                vrt += vtemp; // Add.
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
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
        public void Sum_ConstTraits() {
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
            }
            dstTMy = StaticSum_ConstTraits(srcArray, srcArray.Length);
            CheckResult("Sum_ConstTraits");
        }


        #region BENCHMARKS_128
#if BENCHMARKS_128 && NETCOREAPP3_0_OR_GREATER

        /// <summary>
        /// Sum YShuffleG2_Const - Vector128 - Traits static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="control">The control.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum_Const128Traits(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector result.
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector128<TMy> vtemp = Vector128s.YShuffleG2_Const(p0, control);
                vrt = Vector128s.Add(vrt, vtemp);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
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
        public void Sum_Const128Traits() {
            Vector128s.ThrowForUnsupported(true);
            if (Vector<byte>.Count != Vector128<byte>.Count) {
                throw new NotSupportedException(string.Format("Vector byte size mismatch({0}!={1}) !", Vector<byte>.Count, Vector128<byte>.Count));
            }
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
            }
            dstTMy = StaticSum_Const128Traits(srcArray, srcArray.Length);
            CheckResult("Sum_Const128Traits");
        }

#endif // BENCHMARKS_128 && NETCOREAPP3_0_OR_GREATER
        #endregion // BENCHMARKS_128

        #region BENCHMARKS_256
#if BENCHMARKS_256 && NETCOREAPP3_0_OR_GREATER

        /// <summary>
        /// Sum YShuffleG2_Const - Vector256 - Traits static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="control">The control.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum_Const256Traits(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> vrt = Vector256<TMy>.Zero; // Vector result.
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256<TMy> vtemp = Vector256s.YShuffleG2_Const(p0, control);
                vrt = Vector256s.Add(vrt, vtemp);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
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
        public void Sum_Const256Traits() {
            Vector256s.ThrowForUnsupported(true);
            if (Vector<byte>.Count != Vector256<byte>.Count) {
                throw new NotSupportedException(string.Format("Vector byte size mismatch({0}!={1}) !", Vector<byte>.Count, Vector256<byte>.Count));
            }
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
            }
            dstTMy = StaticSum_Const256Traits(srcArray, srcArray.Length);
            CheckResult("Sum_Const256Traits");
        }


#endif // BENCHMARKS_256 && NETCOREAPP3_0_OR_GREATER
        #endregion // BENCHMARKS_256

#endif // BENCHMARKS_CONST
        #endregion // BENCHMARKS_CONST

#pragma warning restore CS0162 // Unreachable code detected
    }
}
