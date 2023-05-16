#undef BENCHMARKS_OFF

using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Zyl.VectorTraits.Impl;
using Zyl.VectorTraits.Impl.AVector;

namespace Zyl.VectorTraits.Benchmarks.AVector.S {
#if BENCHMARKS_OFF
    using BenchmarkAttribute = FakeBenchmarkAttribute;
#else
#endif // BENCHMARKS_OFF

    // My type.
    using TMy = SByte;

    /// <summary>
    /// Shift left benchmark - SByte.
    /// </summary>
#if NETCOREAPP3_0_OR_GREATER && DRY_JOB
    [DryJob]
#endif // NETCOREAPP3_0_OR_GREATER && DRY_JOB
    public partial class ShiftLeftBenchmark_SByte : AbstractSharedBenchmark_SByte {

        // -- var --

        /// <summary>
        /// Sum shift left logical - base.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMy StaticSumSLLScalar(TMy[] src, int srcCount, int shiftAmount) {
            TMy rt = 0; // Result.
            shiftAmount = Scalars.LimitShiftAmount<TMy>(shiftAmount);
            for (int i = 0; i < srcCount; ++i) {
                rt += (TMy)(src[i] << shiftAmount);
            }
            return rt;
        }

        [Benchmark(Baseline = true)]
        public void SumSLLScalar() {
            LoopCount = ShiftAmountMax - ShiftAmountMin + 1;
            dstTMy = 0;
            for (int shiftAmount = ShiftAmountMin; shiftAmount <= ShiftAmountMax; ++shiftAmount) {
                dstTMy += StaticSumSLLScalar(srcArray, srcArray.Length, shiftAmount);
            }
            if (CheckMode) {
                baselineTMy = dstTMy;
                BenchmarkUtil.WriteItem("# SumSLLScalar", string.Format("{0}", baselineTMy));
            }
        }

#if NET7_0_OR_GREATER
        /// <summary>
        /// Sum shift left logical - VectorT - .NET Bcl.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSLLNetBcl(TMy[] src, int srcCount, int shiftAmount) {
            TMy rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<TMy>(shiftAmount);
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<TMy> vtemp = Vector.ShiftLeft(*(Vector<TMy>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumSLLNetBcl() {
            //Debugger.Break();
            dstTMy = 0;
            for (int shiftAmount = ShiftAmountMin; shiftAmount <= ShiftAmountMax; ++shiftAmount) {
                dstTMy += StaticSumSLLNetBcl(srcArray, srcArray.Length, shiftAmount);
            }
            CheckResult("SumSLLNetBcl");
        }
#endif // NET7_0_OR_GREATER

        #region BENCHMARKS_ALGORITHM
#if BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum shift left logical - Algorithm - Base128.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSLL_Base128(TMy[] src, int srcCount, int shiftAmount) {
            TMy rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<TMy>(shiftAmount);
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<TMy> vtemp = VectorTraits128Base.Statics.ShiftLeft_Base(*(Vector<TMy>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumSLL_Base128() {
            VectorTraits128Base.Statics.ThrowForUnsupported(true);
            dstTMy = 0;
            for (int shiftAmount = ShiftAmountMin; shiftAmount <= ShiftAmountMax; ++shiftAmount) {
                dstTMy += StaticSumSLL_Base128(srcArray, srcArray.Length, shiftAmount);
            }
            CheckResult("SumSLL_Base128");
        }

        /// <summary>
        /// Sum shift left logical - Algorithm - 256Base.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSLL_Base256(TMy[] src, int srcCount, int shiftAmount) {
            TMy rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<TMy>(shiftAmount);
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<TMy> vtemp = VectorTraits256Base.Statics.ShiftLeft_Base(*(Vector<TMy>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumSLL_Base256() {
            VectorTraits256Base.Statics.ThrowForUnsupported(true);
            dstTMy = 0;
            for (int shiftAmount = ShiftAmountMin; shiftAmount <= ShiftAmountMax; ++shiftAmount) {
                dstTMy += StaticSumSLL_Base256(srcArray, srcArray.Length, shiftAmount);
            }
            CheckResult("SumSLL_Base256");
        }

        /// <summary>
        /// Sum shift left logical - Algorithm - Multiply.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSLL_Multiply(TMy[] src, int srcCount, int shiftAmount) {
            TMy rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<TMy>(shiftAmount);
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<TMy> vtemp = VectorTraitsBase.Statics.ShiftLeft_Multiply(*(Vector<TMy>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumSLL_Multiply() {
            VectorTraitsBase.Statics.ThrowForUnsupported(true);
            dstTMy = 0;
            for (int shiftAmount = ShiftAmountMin; shiftAmount <= ShiftAmountMax; ++shiftAmount) {
                dstTMy += StaticSumSLL_Multiply(srcArray, srcArray.Length, shiftAmount);
            }
            CheckResult("SumSLL_Multiply");
        }

#if NETCOREAPP3_0_OR_GREATER

#endif // NETCOREAPP3_0_OR_GREATER

#if NET5_0_OR_GREATER

#endif // NET5_0_OR_GREATER

#endif // BENCHMARKS_ALGORITHM
        #endregion // BENCHMARKS_ALGORITHM

        #region BENCHMARKS_RAW
#if BENCHMARKS_RAW

#if NETCOREAPP3_0_OR_GREATER
        /// <summary>
        /// Sum shift left logical - Raw - Avx.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSLLRawAvx2(TMy[] src, int srcCount, int shiftAmount) {
            TMy rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<TMy>(shiftAmount);
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<TMy> vtemp = VectorTraits256Avx2.Statics.ShiftLeft(*(Vector<TMy>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumSLLRawAvx2() {
            VectorTraits256Avx2.Statics.ThrowForUnsupported(true);
            //Debugger.Break();
            dstTMy = 0;
            for (int shiftAmount = ShiftAmountMin; shiftAmount <= ShiftAmountMax; ++shiftAmount) {
                dstTMy += StaticSumSLLRawAvx2(srcArray, srcArray.Length, shiftAmount);
            }
            CheckResult("SumSLLRawAvx2");
        }
#endif // NETCOREAPP3_0_OR_GREATER

#if NET5_0_OR_GREATER
        /// <summary>
        /// Sum shift left logical - Raw - Avx.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSLLRawAdvSimd(TMy[] src, int srcCount, int shiftAmount) {
            TMy rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<TMy>(shiftAmount);
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<TMy> vtemp = VectorTraits128AdvSimd.Statics.ShiftLeft(*(Vector<TMy>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumSLLRawAdvSimd() {
            VectorTraits128AdvSimd.Statics.ThrowForUnsupported(true);
            //Debugger.Break();
            dstTMy = 0;
            for (int shiftAmount = ShiftAmountMin; shiftAmount <= ShiftAmountMax; ++shiftAmount) {
                dstTMy += StaticSumSLLRawAdvSimd(srcArray, srcArray.Length, shiftAmount);
            }
            CheckResult("SumSLLRawAdvSimd");
        }
#endif // NET5_0_OR_GREATER

#endif // BENCHMARKS_RAW
        #endregion // BENCHMARKS_RAW

        /// <summary>
        /// Sum shift left logical - Traits static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] // 'VectorTTraits.Instance' is compiled inline to the actual type.
        private static unsafe TMy StaticSumSLLTraits(TMy[] src, int srcCount, int shiftAmount) {
            TMy rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<TMy>(shiftAmount);
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<TMy> vtemp = Vectors.ShiftLeft(*(Vector<TMy>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumSLLTraits() {
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                Debugger.Break();
            }
            dstTMy = 0;
            dstTMy = 0;
            for (int shiftAmount = ShiftAmountMin; shiftAmount <= ShiftAmountMax; ++shiftAmount) {
                dstTMy += StaticSumSLLTraits(srcArray, srcArray.Length, shiftAmount);
            }
            CheckResult("SumSLLTraits");
        }

        #region BENCHMARKS_TRAITS_USAGES
#if BENCHMARKS_TRAITS_USAGES

        /// <summary>
        /// Sum shift left logical - Traits argument.
        /// </summary>
        /// <param name="vectorTraits">The <see cref="IVectorTraits"/> instance.</param>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSLLTraitsArg(IVectorTraits vectorTraits, TMy[] src, int srcCount, int shiftAmount) {
            TMy rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<TMy>(shiftAmount);
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<TMy> vtemp = vectorTraits.ShiftLeft(*(Vector<TMy>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumSLLTraitsArg() {
            //Debugger.Break();
            dstTMy = 0;
            for (int shiftAmount = ShiftAmountMin; shiftAmount <= ShiftAmountMax; ++shiftAmount) {
                dstTMy += StaticSumSLLTraitsArg(Vectors.Instance, srcArray, srcArray.Length, shiftAmount);
            }
            CheckResult("SumSLLTraitsArg");
        }

        [Benchmark]
        public void SumSLLTraitsArgDynamic() {
            dstTMy = 0;
            for (int shiftAmount = ShiftAmountMin; shiftAmount <= ShiftAmountMax; ++shiftAmount) {
                dstTMy += StaticSumSLLTraitsArg(Vectors.InstanceDynamic, srcArray, srcArray.Length, shiftAmount);
            }
            CheckResult("SumSLLTraitsArgDynamic");
        }

        /// <summary>
        /// Sum shift left logical - Traits overload.
        /// </summary>
        /// <param name="vectorTraits">The <see cref="IVectorTraits"/> instance.</param>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSLLTraitsOverload(IVectorTraits vectorTraits, TMy[] src, int srcCount, int shiftAmount) {
            TMy rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<TMy>(shiftAmount);
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<TMy> vtemp = vectorTraits.ShiftLeft(*(Vector<TMy>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumSLLTraitsOverload() {
            dstTMy = 0;
            for (int shiftAmount = ShiftAmountMin; shiftAmount <= ShiftAmountMax; ++shiftAmount) {
                dstTMy += StaticSumSLLTraitsOverload(Vectors.InstanceDynamic, srcArray, srcArray.Length, shiftAmount);
            }
            CheckResult("SumSLLTraitsOverload");
        }

#endif // BENCHMARKS_TRAITS_USAGES
        #endregion // BENCHMARKS_TRAITS_USAGES


        #region BENCHMARKS_TARGET_FAST
#if BENCHMARKS_TARGET_FAST

        #region BENCHMARKS_ALGORITHM
#if BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum shift left logical fast - Algorithm - Base128.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSLLFast_Base128(TMy[] src, int srcCount, int shiftAmount) {
            TMy rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<TMy>(shiftAmount);
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<TMy> vtemp = VectorTraits128Base.Statics.ShiftLeft_Fast_Base(*(Vector<TMy>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumSLLFast_Base128() {
            VectorTraits128Base.Statics.ThrowForUnsupported(true);
            dstTMy = 0;
            for (int shiftAmount = ShiftAmountMin; shiftAmount <= ShiftAmountMax; ++shiftAmount) {
                dstTMy += StaticSumSLLFast_Base128(srcArray, srcArray.Length, shiftAmount);
            }
            CheckResult("SumSLLFast_Base128");
        }

        /// <summary>
        /// Sum shift left logical fast - Algorithm - 256Base.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSLLFast_Base256(TMy[] src, int srcCount, int shiftAmount) {
            TMy rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<TMy>(shiftAmount);
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<TMy> vtemp = VectorTraits256Base.Statics.ShiftLeft_Fast_Base(*(Vector<TMy>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumSLLFast_Base256() {
            VectorTraits256Base.Statics.ThrowForUnsupported(true);
            dstTMy = 0;
            for (int shiftAmount = ShiftAmountMin; shiftAmount <= ShiftAmountMax; ++shiftAmount) {
                dstTMy += StaticSumSLLFast_Base256(srcArray, srcArray.Length, shiftAmount);
            }
            CheckResult("SumSLLFast_Base256");
        }

        /// <summary>
        /// Sum shift left logical fast - Algorithm - Multiply.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSLLFast_Multiply(TMy[] src, int srcCount, int shiftAmount) {
            TMy rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<TMy>(shiftAmount);
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<TMy> vtemp = VectorTraitsBase.Statics.ShiftLeft_Fast_Multiply(*(Vector<TMy>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumSLLFast_Multiply() {
            VectorTraitsBase.Statics.ThrowForUnsupported(true);
            dstTMy = 0;
            for (int shiftAmount = ShiftAmountMin; shiftAmount <= ShiftAmountMax; ++shiftAmount) {
                dstTMy += StaticSumSLLFast_Multiply(srcArray, srcArray.Length, shiftAmount);
            }
            CheckResult("SumSLLFast_Multiply");
        }

#if NETCOREAPP3_0_OR_GREATER

#endif // NETCOREAPP3_0_OR_GREATER

#if NET5_0_OR_GREATER

#endif // NET5_0_OR_GREATER

#endif // BENCHMARKS_ALGORITHM
        #endregion // BENCHMARKS_ALGORITHM

        #region BENCHMARKS_RAW
#if BENCHMARKS_RAW

#if NETCOREAPP3_0_OR_GREATER
        /// <summary>
        /// Sum shift left logical fast - Raw - Avx.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSLLFastRawAvx2(TMy[] src, int srcCount, int shiftAmount) {
            TMy rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<TMy>(shiftAmount);
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<TMy> vtemp = VectorTraits256Avx2.Statics.ShiftLeft_Fast(*(Vector<TMy>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumSLLFastRawAvx2() {
            VectorTraits256Avx2.Statics.ThrowForUnsupported(true);
            //Debugger.Break();
            dstTMy = 0;
            for (int shiftAmount = ShiftAmountMin; shiftAmount <= ShiftAmountMax; ++shiftAmount) {
                dstTMy += StaticSumSLLFastRawAvx2(srcArray, srcArray.Length, shiftAmount);
            }
            CheckResult("SumSLLFastRawAvx2");
        }
#endif // NETCOREAPP3_0_OR_GREATER

#if NET5_0_OR_GREATER
        /// <summary>
        /// Sum shift left logical fast - Raw - Avx.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSLLFastRawAdvSimd(TMy[] src, int srcCount, int shiftAmount) {
            TMy rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<TMy>(shiftAmount);
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<TMy> vtemp = VectorTraits128AdvSimd.Statics.ShiftLeft_Fast(*(Vector<TMy>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumSLLFastRawAdvSimd() {
            VectorTraits128AdvSimd.Statics.ThrowForUnsupported(true);
            //Debugger.Break();
            dstTMy = 0;
            for (int shiftAmount = ShiftAmountMin; shiftAmount <= ShiftAmountMax; ++shiftAmount) {
                dstTMy += StaticSumSLLFastRawAdvSimd(srcArray, srcArray.Length, shiftAmount);
            }
            CheckResult("SumSLLFastRawAdvSimd");
        }
#endif // NET5_0_OR_GREATER

#endif // BENCHMARKS_RAW
        #endregion // BENCHMARKS_RAW

        /// <summary>
        /// Sum shift left logical fast - Traits static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] // 'VectorTTraits.Instance' is compiled inline to the actual type.
        private static unsafe TMy StaticSumSLLFastTraits(TMy[] src, int srcCount, int shiftAmount) {
            TMy rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<TMy>(shiftAmount);
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<TMy> vtemp = Vectors.ShiftLeft_Fast(*(Vector<TMy>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumSLLFastTraits() {
            //Debugger.Break();
            dstTMy = 0;
            for (int shiftAmount = ShiftAmountMin; shiftAmount <= ShiftAmountMax; ++shiftAmount) {
                dstTMy += StaticSumSLLFastTraits(srcArray, srcArray.Length, shiftAmount);
            }
            CheckResult("SumSLLFastTraits");
        }

        #region BENCHMARKS_TRAITS_USAGES
#if BENCHMARKS_TRAITS_USAGES

        /// <summary>
        /// Sum shift left logical fast - Traits argument.
        /// </summary>
        /// <param name="vectorTraits">The <see cref="IVectorTraits"/> instance.</param>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSLLFastTraitsArg(IVectorTraits vectorTraits, TMy[] src, int srcCount, int shiftAmount) {
            TMy rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<TMy>(shiftAmount);
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<TMy> vtemp = vectorTraits.ShiftLeft_Fast(*(Vector<TMy>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumSLLFastTraitsArg() {
            //Debugger.Break();
            dstTMy = 0;
            for (int shiftAmount = ShiftAmountMin; shiftAmount <= ShiftAmountMax; ++shiftAmount) {
                dstTMy += StaticSumSLLFastTraitsArg(Vectors.Instance, srcArray, srcArray.Length, shiftAmount);
            }
            CheckResult("SumSLLFastTraitsArg");
        }

        [Benchmark]
        public void SumSLLFastTraitsArgDynamic() {
            dstTMy = 0;
            for (int shiftAmount = ShiftAmountMin; shiftAmount <= ShiftAmountMax; ++shiftAmount) {
                dstTMy += StaticSumSLLFastTraitsArg(Vectors.InstanceDynamic, srcArray, srcArray.Length, shiftAmount);
            }
            CheckResult("SumSLLFastTraitsArgDynamic");
        }

        /// <summary>
        /// Sum shift left logical fast - Traits overload.
        /// </summary>
        /// <param name="vectorTraits">The <see cref="IVectorTraits"/> instance.</param>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSLLFastTraitsOverload(IVectorTraits vectorTraits, TMy[] src, int srcCount, int shiftAmount) {
            TMy rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<TMy>(shiftAmount);
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<TMy> vtemp = vectorTraits.ShiftLeft_Fast(*(Vector<TMy>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumSLLFastTraitsOverload() {
            dstTMy = 0;
            for (int shiftAmount = ShiftAmountMin; shiftAmount <= ShiftAmountMax; ++shiftAmount) {
                dstTMy += StaticSumSLLFastTraitsOverload(Vectors.InstanceDynamic, srcArray, srcArray.Length, shiftAmount);
            }
            CheckResult("SumSLLFastTraitsOverload");
        }

#endif // BENCHMARKS_TRAITS_USAGES
        #endregion // BENCHMARKS_TRAITS_USAGES

#endif // BENCHMARKS_TARGET_FAST
        #endregion // BENCHMARKS_TARGET_FAST

    }
}
