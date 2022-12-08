//#undef BENCHMARKS_OFF

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
    using TMy = Byte;

    /// <summary>
    /// Shift left benchmark - short.
    /// </summary>
#if NETCOREAPP3_0_OR_GREATER && DRY_JOB
    [DryJob]
#endif // NETCOREAPP3_0_OR_GREATER && DRY_JOB
    internal partial class ShiftLeftBenchmark_Byte : AbstractSharedBenchmark_Byte {

        // -- var --

        /// <summary>
        /// Sum shift left logical - base.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftCount">Shift count.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMy StaticSumSLLScalar(TMy[] src, int srcCount, int shiftCount) {
            TMy rt = 0; // Result.
            shiftCount = Scalars.LimitShiftCount<TMy>(shiftCount);
            for (int i = 0; i < srcCount; ++i) {
                rt += (TMy)(src[i] << shiftCount);
            }
            return rt;
        }

        [Benchmark(Baseline = true)]
        public void SumSLLScalar() {
            LoopCount = ShiftCountMax - ShiftCountMin + 1;
            dstTMy = 0;
            for (int shiftCount = ShiftCountMin; shiftCount <= ShiftCountMax; ++shiftCount) {
                dstTMy += StaticSumSLLScalar(srcArray, srcArray.Length, shiftCount);
            }
            if (CheckMode) {
                baselineTMy = dstTMy;
                BenchmarkUtil.WriteLine(string.Format("# StaticSumSLLScalar:\t{0}", baselineTMy));
            }
        }

#if NET7_0_OR_GREATER
        /// <summary>
        /// Sum shift left logical - VectorT - .NET7.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftCount">Shift count.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSLLNet7(TMy[] src, int srcCount, int shiftCount) {
            TMy rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            shiftCount = Scalars.LimitShiftCount<TMy>(shiftCount);
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<TMy> vtemp = Vector.ShiftLeft(*(Vector<TMy>*)p, shiftCount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] << shiftCount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumSLLNet7() {
            //Debugger.Break();
            dstTMy = 0;
            for (int shiftCount = ShiftCountMin; shiftCount <= ShiftCountMax; ++shiftCount) {
                dstTMy += StaticSumSLLNet7(srcArray, srcArray.Length, shiftCount);
            }
            CheckResult("SumSLLNet7");
        }
#endif // NET7_0_OR_GREATER

        #region BENCHMARKS_ALGORITHM
#if BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum shift left logical - Algorithm - Base128.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftCount">Shift count.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSLL_Base128(TMy[] src, int srcCount, int shiftCount) {
            TMy rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            shiftCount = Scalars.LimitShiftCount<TMy>(shiftCount);
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<TMy> vtemp = VectorTraits128Base.Statics.ShiftLeft_Base(*(Vector<TMy>*)p, shiftCount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] << shiftCount);
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
            for (int shiftCount = ShiftCountMin; shiftCount <= ShiftCountMax; ++shiftCount) {
                dstTMy += StaticSumSLL_Base128(srcArray, srcArray.Length, shiftCount);
            }
            CheckResult("SumSLL_Base128");
        }

        /// <summary>
        /// Sum shift left logical - Algorithm - 256Base.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftCount">Shift count.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSLL_Base256(TMy[] src, int srcCount, int shiftCount) {
            TMy rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            shiftCount = Scalars.LimitShiftCount<TMy>(shiftCount);
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<TMy> vtemp = VectorTraits256Base.Statics.ShiftLeft_Base(*(Vector<TMy>*)p, shiftCount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] << shiftCount);
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
            for (int shiftCount = ShiftCountMin; shiftCount <= ShiftCountMax; ++shiftCount) {
                dstTMy += StaticSumSLL_Base256(srcArray, srcArray.Length, shiftCount);
            }
            CheckResult("SumSLL_Base256");
        }

        /// <summary>
        /// Sum shift left logical - Algorithm - Multiply.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftCount">Shift count.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSLL_Multiply(TMy[] src, int srcCount, int shiftCount) {
            TMy rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            shiftCount = Scalars.LimitShiftCount<TMy>(shiftCount);
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<TMy> vtemp = VectorTraitsBase.Statics.ShiftLeft_Multiply(*(Vector<TMy>*)p, shiftCount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] << shiftCount);
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
            for (int shiftCount = ShiftCountMin; shiftCount <= ShiftCountMax; ++shiftCount) {
                dstTMy += StaticSumSLL_Multiply(srcArray, srcArray.Length, shiftCount);
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
        /// <param name="shiftCount">Shift count.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSLLRawAvx2(TMy[] src, int srcCount, int shiftCount) {
            TMy rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            shiftCount = Scalars.LimitShiftCount<TMy>(shiftCount);
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<TMy> vtemp = VectorTraits256Avx2.Statics.ShiftLeft(*(Vector<TMy>*)p, shiftCount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] << shiftCount);
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
            for (int shiftCount = ShiftCountMin; shiftCount <= ShiftCountMax; ++shiftCount) {
                dstTMy += StaticSumSLLRawAvx2(srcArray, srcArray.Length, shiftCount);
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
        /// <param name="shiftCount">Shift count.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSLLRawAdvSimd(TMy[] src, int srcCount, int shiftCount) {
            TMy rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            shiftCount = Scalars.LimitShiftCount<TMy>(shiftCount);
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<TMy> vtemp = VectorTraits128AdvSimd.Statics.ShiftLeft(*(Vector<TMy>*)p, shiftCount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] << shiftCount);
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
            for (int shiftCount = ShiftCountMin; shiftCount <= ShiftCountMax; ++shiftCount) {
                dstTMy += StaticSumSLLRawAdvSimd(srcArray, srcArray.Length, shiftCount);
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
        /// <param name="shiftCount">Shift count.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] // 'VectorTTraits.Instance' is compiled inline to the actual type.
        private static unsafe TMy StaticSumSLLTraits(TMy[] src, int srcCount, int shiftCount) {
            TMy rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            shiftCount = Scalars.LimitShiftCount<TMy>(shiftCount);
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<TMy> vtemp = Vectors.ShiftLeft(*(Vector<TMy>*)p, shiftCount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] << shiftCount);
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
            //Debugger.Break();
            dstTMy = 0;
            for (int shiftCount = ShiftCountMin; shiftCount <= ShiftCountMax; ++shiftCount) {
                dstTMy += StaticSumSLLTraits(srcArray, srcArray.Length, shiftCount);
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
        /// <param name="shiftCount">Shift count.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSLLTraitsArg(IVectorTraits vectorTraits, TMy[] src, int srcCount, int shiftCount) {
            TMy rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            shiftCount = Scalars.LimitShiftCount<TMy>(shiftCount);
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<TMy> vtemp = vectorTraits.ShiftLeft(*(Vector<TMy>*)p, shiftCount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] << shiftCount);
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
            for (int shiftCount = ShiftCountMin; shiftCount <= ShiftCountMax; ++shiftCount) {
                dstTMy += StaticSumSLLTraitsArg(Vectors.Instance, srcArray, srcArray.Length, shiftCount);
            }
            CheckResult("SumSLLTraitsArg");
        }

        [Benchmark]
        public void SumSLLTraitsArgDynamic() {
            dstTMy = 0;
            for (int shiftCount = ShiftCountMin; shiftCount <= ShiftCountMax; ++shiftCount) {
                dstTMy += StaticSumSLLTraitsArg(Vectors.InstanceDynamic, srcArray, srcArray.Length, shiftCount);
            }
            CheckResult("SumSLLTraitsArgDynamic");
        }

        /// <summary>
        /// Sum shift left logical - Traits overload.
        /// </summary>
        /// <param name="vectorTraits">The <see cref="IVectorTraits"/> instance.</param>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftCount">Shift count.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSLLTraitsOverload(IVectorTraits vectorTraits, TMy[] src, int srcCount, int shiftCount) {
            TMy rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            shiftCount = Scalars.LimitShiftCount<TMy>(shiftCount);
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<TMy> vtemp = vectorTraits.ShiftLeft(*(Vector<TMy>*)p, shiftCount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] << shiftCount);
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
            for (int shiftCount = ShiftCountMin; shiftCount <= ShiftCountMax; ++shiftCount) {
                dstTMy += StaticSumSLLTraitsOverload(Vectors.InstanceDynamic, srcArray, srcArray.Length, shiftCount);
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
        /// <param name="shiftCount">Shift count.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSLLFast_Base128(TMy[] src, int srcCount, int shiftCount) {
            TMy rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            shiftCount = Scalars.LimitShiftCount<TMy>(shiftCount);
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<TMy> vtemp = VectorTraits128Base.Statics.ShiftLeftFast_Base(*(Vector<TMy>*)p, shiftCount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] << shiftCount);
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
            for (int shiftCount = ShiftCountMin; shiftCount <= ShiftCountMax; ++shiftCount) {
                dstTMy += StaticSumSLLFast_Base128(srcArray, srcArray.Length, shiftCount);
            }
            CheckResult("SumSLLFast_Base128");
        }

        /// <summary>
        /// Sum shift left logical fast - Algorithm - 256Base.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftCount">Shift count.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSLLFast_Base256(TMy[] src, int srcCount, int shiftCount) {
            TMy rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            shiftCount = Scalars.LimitShiftCount<TMy>(shiftCount);
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<TMy> vtemp = VectorTraits256Base.Statics.ShiftLeftFast_Base(*(Vector<TMy>*)p, shiftCount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] << shiftCount);
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
            for (int shiftCount = ShiftCountMin; shiftCount <= ShiftCountMax; ++shiftCount) {
                dstTMy += StaticSumSLLFast_Base256(srcArray, srcArray.Length, shiftCount);
            }
            CheckResult("SumSLLFast_Base256");
        }

        /// <summary>
        /// Sum shift left logical fast - Algorithm - Multiply.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftCount">Shift count.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSLLFast_Multiply(TMy[] src, int srcCount, int shiftCount) {
            TMy rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            shiftCount = Scalars.LimitShiftCount<TMy>(shiftCount);
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<TMy> vtemp = VectorTraitsBase.Statics.ShiftLeftFast_Multiply(*(Vector<TMy>*)p, shiftCount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] << shiftCount);
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
            for (int shiftCount = ShiftCountMin; shiftCount <= ShiftCountMax; ++shiftCount) {
                dstTMy += StaticSumSLLFast_Multiply(srcArray, srcArray.Length, shiftCount);
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
        /// <param name="shiftCount">Shift count.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSLLFastRawAvx2(TMy[] src, int srcCount, int shiftCount) {
            TMy rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            shiftCount = Scalars.LimitShiftCount<TMy>(shiftCount);
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<TMy> vtemp = VectorTraits256Avx2.Statics.ShiftLeftFast(*(Vector<TMy>*)p, shiftCount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] << shiftCount);
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
            for (int shiftCount = ShiftCountMin; shiftCount <= ShiftCountMax; ++shiftCount) {
                dstTMy += StaticSumSLLFastRawAvx2(srcArray, srcArray.Length, shiftCount);
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
        /// <param name="shiftCount">Shift count.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSLLFastRawAdvSimd(TMy[] src, int srcCount, int shiftCount) {
            TMy rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            shiftCount = Scalars.LimitShiftCount<TMy>(shiftCount);
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<TMy> vtemp = VectorTraits128AdvSimd.Statics.ShiftLeftFast(*(Vector<TMy>*)p, shiftCount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] << shiftCount);
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
            for (int shiftCount = ShiftCountMin; shiftCount <= ShiftCountMax; ++shiftCount) {
                dstTMy += StaticSumSLLFastRawAdvSimd(srcArray, srcArray.Length, shiftCount);
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
        /// <param name="shiftCount">Shift count.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] // 'VectorTTraits.Instance' is compiled inline to the actual type.
        private static unsafe TMy StaticSumSLLFastTraits(TMy[] src, int srcCount, int shiftCount) {
            TMy rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            shiftCount = Scalars.LimitShiftCount<TMy>(shiftCount);
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<TMy> vtemp = Vectors.ShiftLeftFast(*(Vector<TMy>*)p, shiftCount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] << shiftCount);
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
            for (int shiftCount = ShiftCountMin; shiftCount <= ShiftCountMax; ++shiftCount) {
                dstTMy += StaticSumSLLFastTraits(srcArray, srcArray.Length, shiftCount);
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
        /// <param name="shiftCount">Shift count.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSLLFastTraitsArg(IVectorTraits vectorTraits, TMy[] src, int srcCount, int shiftCount) {
            TMy rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            shiftCount = Scalars.LimitShiftCount<TMy>(shiftCount);
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<TMy> vtemp = vectorTraits.ShiftLeftFast(*(Vector<TMy>*)p, shiftCount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] << shiftCount);
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
            for (int shiftCount = ShiftCountMin; shiftCount <= ShiftCountMax; ++shiftCount) {
                dstTMy += StaticSumSLLFastTraitsArg(Vectors.Instance, srcArray, srcArray.Length, shiftCount);
            }
            CheckResult("SumSLLFastTraitsArg");
        }

        [Benchmark]
        public void SumSLLFastTraitsArgDynamic() {
            dstTMy = 0;
            for (int shiftCount = ShiftCountMin; shiftCount <= ShiftCountMax; ++shiftCount) {
                dstTMy += StaticSumSLLFastTraitsArg(Vectors.InstanceDynamic, srcArray, srcArray.Length, shiftCount);
            }
            CheckResult("SumSLLFastTraitsArgDynamic");
        }

        /// <summary>
        /// Sum shift left logical fast - Traits overload.
        /// </summary>
        /// <param name="vectorTraits">The <see cref="IVectorTraits"/> instance.</param>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftCount">Shift count.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSLLFastTraitsOverload(IVectorTraits vectorTraits, TMy[] src, int srcCount, int shiftCount) {
            TMy rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            shiftCount = Scalars.LimitShiftCount<TMy>(shiftCount);
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<TMy> vtemp = vectorTraits.ShiftLeftFast(*(Vector<TMy>*)p, shiftCount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (TMy)(p[i] << shiftCount);
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
            for (int shiftCount = ShiftCountMin; shiftCount <= ShiftCountMax; ++shiftCount) {
                dstTMy += StaticSumSLLFastTraitsOverload(Vectors.InstanceDynamic, srcArray, srcArray.Length, shiftCount);
            }
            CheckResult("SumSLLFastTraitsOverload");
        }

#endif // BENCHMARKS_TRAITS_USAGES
        #endregion // BENCHMARKS_TRAITS_USAGES

#endif // BENCHMARKS_TARGET_FAST
        #endregion // BENCHMARKS_TARGET_FAST

    }
}
