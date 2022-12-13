#undef BENCHMARKS_OFF

using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Benchmarks.AVector.S {
#if BENCHMARKS_OFF
    using BenchmarkAttribute = FakeBenchmarkAttribute;
#else
#endif // BENCHMARKS_OFF

    // My type.
    using TMy = UInt64;

    /// <summary>
    /// Shift left benchmark - UInt64.
    /// </summary>
#if NETCOREAPP3_0_OR_GREATER && DRY_JOB
    [DryJob]
#endif // NETCOREAPP3_0_OR_GREATER && DRY_JOB
    internal partial class ShiftRightLogicalBenchmark_UInt64 : AbstractSharedBenchmark_UInt64 {

        // -- var --

        /// <summary>
        /// Sum shift right logical - base.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMy StaticSumSRLScalar(TMy[] src, int srcCount, int shiftAmount) {
            TMy rt = 0; // Result.
            shiftAmount = Scalars.LimitShiftAmount<TMy>(shiftAmount);
            for (int i = 0; i < srcCount; ++i) {
                rt += (TMy)(src[i] >> shiftAmount);
            }
            return rt;
        }

        [Benchmark(Baseline = true)]
        public void SumSRLScalar() {
            LoopCount = ShiftAmountMax - ShiftAmountMin + 1;
            dstTMy = 0;
            for (int shiftAmount = ShiftAmountMin; shiftAmount <= ShiftAmountMax; ++shiftAmount) {
                dstTMy += StaticSumSRLScalar(srcArray, srcArray.Length, shiftAmount);
            }
            if (CheckMode) {
                baselineTMy = dstTMy;
                BenchmarkUtil.WriteLine(string.Format("# SumSRLScalar:\t{0}", baselineTMy));
            }
        }

#if NET7_0_OR_GREATER
        /// <summary>
        /// Sum shift right logical - VectorT - .NET Bcl.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSRLNetBcl(TMy[] src, int srcCount, int shiftAmount) {
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
                    Vector<TMy> vtemp = Vector.ShiftRightLogical(*(Vector<TMy>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumSRLNetBcl() {
            //Debugger.Break();
            dstTMy = 0;
            for (int shiftAmount = ShiftAmountMin; shiftAmount <= ShiftAmountMax; ++shiftAmount) {
                dstTMy += StaticSumSRLNetBcl(srcArray, srcArray.Length, shiftAmount);
            }
            CheckResult("SumSRLNetBcl");
        }
#endif // NET7_0_OR_GREATER

        #region BENCHMARKS_ALGORITHM
#if BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum shift right logical - Algorithm - Base.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSRL_Base(TMy[] src, int srcCount, int shiftAmount) {
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
                    Vector<TMy> vtemp = VectorTraitsBase.Statics.ShiftRightLogical_Base(*(Vector<TMy>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumSRL_Base() {
            VectorTraitsBase.Statics.ThrowForUnsupported(true);
            dstTMy = 0;
            for (int shiftAmount = ShiftAmountMin; shiftAmount <= ShiftAmountMax; ++shiftAmount) {
                dstTMy += StaticSumSRL_Base(srcArray, srcArray.Length, shiftAmount);
            }
            CheckResult("SumSRL_Base");
        }

        /// <summary>
        /// Sum shift right logical - Algorithm - Base128.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSRL_Base128(TMy[] src, int srcCount, int shiftAmount) {
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
                    Vector<TMy> vtemp = VectorTraits128Base.Statics.ShiftRightLogical_Base(*(Vector<TMy>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumSRL_Base128() {
            VectorTraits128Base.Statics.ThrowForUnsupported(true);
            dstTMy = 0;
            for (int shiftAmount = ShiftAmountMin; shiftAmount <= ShiftAmountMax; ++shiftAmount) {
                dstTMy += StaticSumSRL_Base128(srcArray, srcArray.Length, shiftAmount);
            }
            CheckResult("SumSRL_Base128");
        }

        /// <summary>
        /// Sum shift right logical - Algorithm - Base256.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSRL_Base256(TMy[] src, int srcCount, int shiftAmount) {
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
                    Vector<TMy> vtemp = VectorTraits256Base.Statics.ShiftRightLogical_Base(*(Vector<TMy>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumSRL_Base256() {
            VectorTraits256Base.Statics.ThrowForUnsupported(true);
            dstTMy = 0;
            for (int shiftAmount = ShiftAmountMin; shiftAmount <= ShiftAmountMax; ++shiftAmount) {
                dstTMy += StaticSumSRL_Base256(srcArray, srcArray.Length, shiftAmount);
            }
            CheckResult("SumSRL_Base256");
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
        /// Sum shift right logical - Raw - Avx.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSRLRawAvx2(TMy[] src, int srcCount, int shiftAmount) {
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
                    Vector<TMy> vtemp = VectorTraits256Avx2.Statics.ShiftRightLogical(*(Vector<TMy>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumSRLRawAvx2() {
            VectorTraits256Avx2.Statics.ThrowForUnsupported(true);
            //Debugger.Break();
            dstTMy = 0;
            for (int shiftAmount = ShiftAmountMin; shiftAmount <= ShiftAmountMax; ++shiftAmount) {
                dstTMy += StaticSumSRLRawAvx2(srcArray, srcArray.Length, shiftAmount);
            }
            CheckResult("SumSRLRawAvx2");
        }
#endif // NETCOREAPP3_0_OR_GREATER

#if NET5_0_OR_GREATER
        /// <summary>
        /// Sum shift right logical - Raw - Avx.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSRLRawAdvSimd(TMy[] src, int srcCount, int shiftAmount) {
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
                    Vector<TMy> vtemp = VectorTraits128AdvSimd.Statics.ShiftRightLogical(*(Vector<TMy>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumSRLRawAdvSimd() {
            VectorTraits128AdvSimd.Statics.ThrowForUnsupported(true);
            //Debugger.Break();
            dstTMy = 0;
            for (int shiftAmount = ShiftAmountMin; shiftAmount <= ShiftAmountMax; ++shiftAmount) {
                dstTMy += StaticSumSRLRawAdvSimd(srcArray, srcArray.Length, shiftAmount);
            }
            CheckResult("SumSRLRawAdvSimd");
        }
#endif // NET5_0_OR_GREATER

#endif // BENCHMARKS_RAW
        #endregion // BENCHMARKS_RAW

        /// <summary>
        /// Sum shift right logical - Traits static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] // 'VectorTTraits.Instance' is compiled inline to the actual type.
        private static unsafe TMy StaticSumSRLTraits(TMy[] src, int srcCount, int shiftAmount) {
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
                    Vector<TMy> vtemp = Vectors.ShiftRightLogical(*(Vector<TMy>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumSRLTraits() {
            //Debugger.Break();
            dstTMy = 0;
            for (int shiftAmount = ShiftAmountMin; shiftAmount <= ShiftAmountMax; ++shiftAmount) {
                dstTMy += StaticSumSRLTraits(srcArray, srcArray.Length, shiftAmount);
            }
            CheckResult("SumSRLTraits");
        }

        #region BENCHMARKS_TRAITS_USAGES
#if BENCHMARKS_TRAITS_USAGES

        /// <summary>
        /// Sum shift right logical - Traits argument.
        /// </summary>
        /// <param name="vectorTraits">The <see cref="IVectorTraits"/> instance.</param>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSRLTraitsArg(IVectorTraits vectorTraits, TMy[] src, int srcCount, int shiftAmount) {
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
                    Vector<TMy> vtemp = vectorTraits.ShiftRightLogical(*(Vector<TMy>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumSRLTraitsArg() {
            //Debugger.Break();
            dstTMy = 0;
            for (int shiftAmount = ShiftAmountMin; shiftAmount <= ShiftAmountMax; ++shiftAmount) {
                dstTMy += StaticSumSRLTraitsArg(Vectors.Instance, srcArray, srcArray.Length, shiftAmount);
            }
            CheckResult("SumSRLTraitsArg");
        }

        [Benchmark]
        public void SumSRLTraitsArgDynamic() {
            dstTMy = 0;
            for (int shiftAmount = ShiftAmountMin; shiftAmount <= ShiftAmountMax; ++shiftAmount) {
                dstTMy += StaticSumSRLTraitsArg(Vectors.InstanceDynamic, srcArray, srcArray.Length, shiftAmount);
            }
            CheckResult("SumSRLTraitsArgDynamic");
        }

        /// <summary>
        /// Sum shift right logical - Traits overload.
        /// </summary>
        /// <param name="vectorTraits">The <see cref="IVectorTraits"/> instance.</param>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSRLTraitsOverload(IVectorTraits vectorTraits, TMy[] src, int srcCount, int shiftAmount) {
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
                    Vector<TMy> vtemp = vectorTraits.ShiftRightLogical(*(Vector<TMy>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumSRLTraitsOverload() {
            dstTMy = 0;
            for (int shiftAmount = ShiftAmountMin; shiftAmount <= ShiftAmountMax; ++shiftAmount) {
                dstTMy += StaticSumSRLTraitsOverload(Vectors.InstanceDynamic, srcArray, srcArray.Length, shiftAmount);
            }
            CheckResult("SumSRLTraitsOverload");
        }

#endif // BENCHMARKS_TRAITS_USAGES
        #endregion // BENCHMARKS_TRAITS_USAGES


        #region BENCHMARKS_TARGET_FAST
#if BENCHMARKS_TARGET_FAST

        #region BENCHMARKS_ALGORITHM
#if BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum shift right logical fast - Algorithm - Base.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSRLFast_Base(TMy[] src, int srcCount, int shiftAmount) {
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
                    Vector<TMy> vtemp = VectorTraitsBase.Statics.ShiftRightLogicalFast_Base(*(Vector<TMy>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumSRLFast_Base() {
            VectorTraitsBase.Statics.ThrowForUnsupported(true);
            dstTMy = 0;
            for (int shiftAmount = ShiftAmountMin; shiftAmount <= ShiftAmountMax; ++shiftAmount) {
                dstTMy += StaticSumSRLFast_Base(srcArray, srcArray.Length, shiftAmount);
            }
            CheckResult("SumSRLFast_Base");
        }

        /// <summary>
        /// Sum shift right logical fast - Algorithm - Base128.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSRLFast_Base128(TMy[] src, int srcCount, int shiftAmount) {
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
                    Vector<TMy> vtemp = VectorTraits128Base.Statics.ShiftRightLogicalFast_Base(*(Vector<TMy>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumSRLFast_Base128() {
            VectorTraits128Base.Statics.ThrowForUnsupported(true);
            dstTMy = 0;
            for (int shiftAmount = ShiftAmountMin; shiftAmount <= ShiftAmountMax; ++shiftAmount) {
                dstTMy += StaticSumSRLFast_Base128(srcArray, srcArray.Length, shiftAmount);
            }
            CheckResult("SumSRLFast_Base128");
        }

        /// <summary>
        /// Sum shift right logical fast - Algorithm - Base256.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSRLFast_Base256(TMy[] src, int srcCount, int shiftAmount) {
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
                    Vector<TMy> vtemp = VectorTraits256Base.Statics.ShiftRightLogicalFast_Base(*(Vector<TMy>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumSRLFast_Base256() {
            VectorTraits256Base.Statics.ThrowForUnsupported(true);
            dstTMy = 0;
            for (int shiftAmount = ShiftAmountMin; shiftAmount <= ShiftAmountMax; ++shiftAmount) {
                dstTMy += StaticSumSRLFast_Base256(srcArray, srcArray.Length, shiftAmount);
            }
            CheckResult("SumSRLFast_Base256");
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
        /// Sum shift right logical fast - Raw - Avx.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSRLFastRawAvx2(TMy[] src, int srcCount, int shiftAmount) {
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
                    Vector<TMy> vtemp = VectorTraits256Avx2.Statics.ShiftRightLogicalFast(*(Vector<TMy>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumSRLFastRawAvx2() {
            VectorTraits256Avx2.Statics.ThrowForUnsupported(true);
            //Debugger.Break();
            dstTMy = 0;
            for (int shiftAmount = ShiftAmountMin; shiftAmount <= ShiftAmountMax; ++shiftAmount) {
                dstTMy += StaticSumSRLFastRawAvx2(srcArray, srcArray.Length, shiftAmount);
            }
            CheckResult("SumSRLFastRawAvx2");
        }

#endif // NETCOREAPP3_0_OR_GREATER

#if NET5_0_OR_GREATER
        /// <summary>
        /// Sum shift right logical fast - Raw - Avx.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSRLFastRawAdvSimd(TMy[] src, int srcCount, int shiftAmount) {
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
                    Vector<TMy> vtemp = VectorTraits128AdvSimd.Statics.ShiftRightLogicalFast(*(Vector<TMy>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumSRLFastRawAdvSimd() {
            VectorTraits128AdvSimd.Statics.ThrowForUnsupported(true);
            //Debugger.Break();
            dstTMy = 0;
            for (int shiftAmount = ShiftAmountMin; shiftAmount <= ShiftAmountMax; ++shiftAmount) {
                dstTMy += StaticSumSRLFastRawAdvSimd(srcArray, srcArray.Length, shiftAmount);
            }
            CheckResult("SumSRLFastRawAdvSimd");
        }
#endif // NET5_0_OR_GREATER

#endif // BENCHMARKS_RAW
        #endregion // BENCHMARKS_RAW

        /// <summary>
        /// Sum shift right logical fast - Traits static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] // 'VectorTTraits.Instance' is compiled inline to the actual type.
        private static unsafe TMy StaticSumSRLFastTraits(TMy[] src, int srcCount, int shiftAmount) {
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
                    Vector<TMy> vtemp = Vectors.ShiftRightLogicalFast(*(Vector<TMy>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumSRLFastTraits() {
            //Debugger.Break();
            dstTMy = 0;
            for (int shiftAmount = ShiftAmountMin; shiftAmount <= ShiftAmountMax; ++shiftAmount) {
                dstTMy += StaticSumSRLFastTraits(srcArray, srcArray.Length, shiftAmount);
            }
            CheckResult("SumSRLFastTraits");
        }

        #region BENCHMARKS_TRAITS_USAGES
#if BENCHMARKS_TRAITS_USAGES

        /// <summary>
        /// Sum shift right logical fast - Traits argument.
        /// </summary>
        /// <param name="vectorTraits">The <see cref="IVectorTraits"/> instance.</param>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSRLFastTraitsArg(IVectorTraits vectorTraits, TMy[] src, int srcCount, int shiftAmount) {
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
                    Vector<TMy> vtemp = vectorTraits.ShiftRightLogicalFast(*(Vector<TMy>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumSRLFastTraitsArg() {
            //Debugger.Break();
            dstTMy = 0;
            for (int shiftAmount = ShiftAmountMin; shiftAmount <= ShiftAmountMax; ++shiftAmount) {
                dstTMy += StaticSumSRLFastTraitsArg(Vectors.Instance, srcArray, srcArray.Length, shiftAmount);
            }
            CheckResult("SumSRLFastTraitsArg");
        }

        [Benchmark]
        public void SumSRLFastTraitsArgDynamic() {
            dstTMy = 0;
            for (int shiftAmount = ShiftAmountMin; shiftAmount <= ShiftAmountMax; ++shiftAmount) {
                dstTMy += StaticSumSRLFastTraitsArg(Vectors.InstanceDynamic, srcArray, srcArray.Length, shiftAmount);
            }
            CheckResult("SumSRLFastTraitsArgDynamic");
        }

        /// <summary>
        /// Sum shift right logical fast - Traits overload.
        /// </summary>
        /// <param name="vectorTraits">The <see cref="IVectorTraits"/> instance.</param>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSRLFastTraitsOverload(IVectorTraits vectorTraits, TMy[] src, int srcCount, int shiftAmount) {
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
                    Vector<TMy> vtemp = vectorTraits.ShiftRightLogicalFast(*(Vector<TMy>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumSRLFastTraitsOverload() {
            dstTMy = 0;
            for (int shiftAmount = ShiftAmountMin; shiftAmount <= ShiftAmountMax; ++shiftAmount) {
                dstTMy += StaticSumSRLFastTraitsOverload(Vectors.InstanceDynamic, srcArray, srcArray.Length, shiftAmount);
            }
            CheckResult("SumSRLFastTraitsOverload");
        }

#endif // BENCHMARKS_TRAITS_USAGES
        #endregion // BENCHMARKS_TRAITS_USAGES

#endif // BENCHMARKS_TARGET_FAST
        #endregion // BENCHMARKS_TARGET_FAST

    }
}
