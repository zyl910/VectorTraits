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
    /// YShuffleX2Kernel benchmark - Int16.
    /// </summary>
#if NETCOREAPP3_0_OR_GREATER && DRY_JOB
    [DryJob]
#endif // NETCOREAPP3_0_OR_GREATER && DRY_JOB
    public partial class YShuffleX2KernelBenchmark_Int16 : AbstractSharedBenchmark_Int16 {

        // -- var --
        private static readonly Vector<TMy> indices = Vectors.CreateByDoubleLoop<TMy>(0, 2);
        private static readonly Vector<TMy> vector1 = Vectors<TMy>.SerialNegative;

        #region BENCHMARKS_256
#if BENCHMARKS_256 && NETCOREAPP3_0_OR_GREATER

        protected TMy dstOn256 = default, baselineOn256 = default;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected virtual void CheckResult256(string name) {
            CheckResult_Report(name, dstOn256 != baselineOn256, dstOn256, baselineOn256);
        }

        #region BENCHMARKS_ALGORITHM
#if BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum YShuffleX2Kernel - Vector256 - base - basic.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="indices">The indices.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum256Base_Basic(TMy[] src, int srcCount, Vector<TMy> indices) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> indicesUsed = indices.AsVector256();
            Vector256<TMy> vector1Used = vector1.AsVector256();
            Vector256<TMy> vrt = Vector256<TMy>.Zero; // Vector256 result.
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector256 processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256<TMy> vtemp = WVectorTraits256Base.Statics.YShuffleX2Kernel_Basic(p0, vector1Used, indicesUsed);
                vrt = WVectorTraits256Base.Statics.Add(vrt, vtemp);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector256<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            rt = WVectorTraits256Base.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark(Baseline = true)]
        //[Benchmark]
        public void Sum256Base_Basic() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn256 = StaticSum256Base_Basic(srcArray, srcArray.Length, indices);
            if (CheckMode) {
                baselineOn256 = dstOn256;
                BenchmarkUtil.WriteItem("# Sum256Base_Basic", string.Format("{0}", baselineOn256));
            }
        }

        /// <summary>
        /// Sum YShuffleX2Kernel - Vector256 - base.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="indices">The indices.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum256Base(TMy[] src, int srcCount, Vector<TMy> indices) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> indicesUsed = indices.AsVector256();
            Vector256<TMy> vector1Used = vector1.AsVector256();
            Vector256<TMy> vrt = Vector256<TMy>.Zero; // Vector256 result.
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector256 processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256<TMy> vtemp = WVectorTraits256Base.Statics.YShuffleX2Kernel(p0, vector1Used, indicesUsed);
                vrt = WVectorTraits256Base.Statics.Add(vrt, vtemp);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector256<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            rt = WVectorTraits256Base.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum256Base() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn256 = StaticSum256Base(srcArray, srcArray.Length, indices);
            CheckResult256("Sum256Base");
        }

        /// <summary>
        /// Sum YShuffleX2Kernel - Vector256 - Avx2 - Combine.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="indices">The indices.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum256Avx2_Combine(TMy[] src, int srcCount, Vector<TMy> indices) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> indicesUsed = indices.AsVector256();
            Vector256<TMy> vector1Used = vector1.AsVector256();
            Vector256<TMy> vrt = Vector256<TMy>.Zero; // Vector256 result.
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector256 processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256<TMy> vtemp = WVectorTraits256Avx2.Statics.YShuffleX2Kernel_Combine(p0, vector1Used, indicesUsed);
                vrt = WVectorTraits256Avx2.Statics.Add(vrt, vtemp);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector256<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            rt = WVectorTraits256Avx2.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum256Avx2_Combine() {
            WVectorTraits256Avx2.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn256 = StaticSum256Avx2_Combine(srcArray, srcArray.Length, indices);
            CheckResult256("Sum256Avx2_Combine");
        }

#endif // BENCHMARKS_ALGORITHM
        #endregion // BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum YShuffleX2Kernel - Vector256 - Traits.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="indices">The indices.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum256Traits(TMy[] src, int srcCount, Vector<TMy> indices) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> indicesUsed = indices.AsVector256();
            Vector256<TMy> vector1Used = vector1.AsVector256();
            Vector256<TMy> vrt = Vector256<TMy>.Zero; // Vector256 result.
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector256 processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256<TMy> vtemp = Vector256s.YShuffleX2Kernel(p0, vector1Used, indicesUsed);
                vrt = Vector256s.Add(vrt, vtemp);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector256<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            rt = Vector256s.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum256Traits() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn256 = StaticSum256Traits(srcArray, srcArray.Length, indices);
            CheckResult256("Sum256Traits");
        }

        /// <summary>
        /// Sum YShuffleX2Kernel - Vector256 - Traits - Args with ValueTuple.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="indices">The indices.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum256Traits_ArgsT(TMy[] src, int srcCount, Vector<TMy> indices) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> indicesUsed = indices.AsVector256();
            Vector256<TMy> vector1Used = vector1.AsVector256();
            Vector256<TMy> vrt = Vector256<TMy>.Zero; // Vector256 result.
            var args = Vector256s.YShuffleX2Kernel_Args(indicesUsed);
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector256 processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256<TMy> vtemp = Vector256s.YShuffleX2Kernel_Core(p0, vector1Used, args);
                vrt = Vector256s.Add(vrt, vtemp);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector256<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            rt = Vector256s.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum256Traits_ArgsT() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn256 = StaticSum256Traits_ArgsT(srcArray, srcArray.Length, indices);
            CheckResult256("Sum256Traits_ArgsT");
        }

#endif // BENCHMARKS_256 && NETCOREAPP3_0_OR_GREATER
        #endregion // BENCHMARKS_256

    }
}
