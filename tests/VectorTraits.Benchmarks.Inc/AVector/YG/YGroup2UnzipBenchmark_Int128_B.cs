#define BENCHMARKS_OFF

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
using Zyl.VectorTraits.ExTypes;
using Zyl.VectorTraits.Impl;
using Zyl.VectorTraits.Impl.AVector;
using Zyl.VectorTraits.Impl.AVector128;
using Zyl.VectorTraits.Impl.AVector256;
using Zyl.VectorTraits.Impl.AVector512;

namespace Zyl.VectorTraits.Benchmarks.AVector.YG {
#if BENCHMARKS_OFF
    using BenchmarkAttribute = FakeBenchmarkAttribute;
#else
#endif // BENCHMARKS_OFF

    // My type.
    using TMy = ExInt128;

    /// <summary>
    /// YGroup2Unzip benchmark - Int128.
    /// </summary>
#if NETCOREAPP3_0_OR_GREATER && DRY_JOB
    [DryJob]
#endif // NETCOREAPP3_0_OR_GREATER && DRY_JOB
    public partial class YGroup2UnzipBenchmark_Int128_B : AbstractSharedBenchmark_Int128 {

        // -- var --
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
        /// Sum YGroup2Unzip - Vector256 - base - basic.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum256Base_Basic(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector256s<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> vector1Used = vector1.ExAsVector256();
            Vector256<TMy> vrt = Vector256s<TMy>.Zero; // Vector256 result.
            Vector256<TMy> vrt1 = Vector256s<TMy>.Zero;
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector256 processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256<TMy> vtemp = WVectorTraits256Base.Statics.YGroup2Unzip_Basic(p0, vector1Used, out var vtemp1);
                vrt = Add(vrt, vtemp);
                vrt1 = Add(vrt1, vtemp1);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector256<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = Add(vrt, vrt1);
            rt = Sum(vrt);
            return rt;
        }

        [Benchmark(Baseline = true)]
        public void Sum256Base_Basic() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstDummy, 0);
            }
            dstOn256 = StaticSum256Base_Basic(srcArray, srcArray.Length);
            if (CheckMode) {
                baselineOn256 = dstOn256;
                BenchmarkUtil.WriteItem("# Sum256Base_Basic", string.Format("{0}", baselineOn256));
            }
        }

        /// <summary>
        /// Sum YGroup2Unzip - Vector256 - base.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum256Base(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector256s<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> vector1Used = vector1.ExAsVector256();
            Vector256<TMy> vrt = Vector256s<TMy>.Zero; // Vector256 result.
            Vector256<TMy> vrt1 = Vector256s<TMy>.Zero;
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector256 processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256<TMy> vtemp = WVectorTraits256Base.Statics.YGroup2Unzip(p0, vector1Used, out var vtemp1);
                vrt = Add(vrt, vtemp);
                vrt1 = Add(vrt1, vtemp1);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector256<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = Add(vrt, vrt1);
            rt = Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum256Base() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstDummy, 0);
            }
            dstOn256 = StaticSum256Base(srcArray, srcArray.Length);
            CheckResult256("Sum256Base");
        }

        /// <summary>
        /// Sum YGroup2Unzip - Vector256 - Avx2.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum256Avx2(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector256s<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> vector1Used = vector1.ExAsVector256();
            Vector256<TMy> vrt = Vector256s<TMy>.Zero; // Vector256 result.
            Vector256<TMy> vrt1 = Vector256s<TMy>.Zero;
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector256 processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256<TMy> vtemp = WVectorTraits256Avx2.Statics.YGroup2Unzip(p0, vector1Used, out var vtemp1);
                vrt = Add(vrt, vtemp);
                vrt1 = Add(vrt1, vtemp1);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector256<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = Add(vrt, vrt1);
            rt = Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum256Avx2() {
            WVectorTraits256Avx2.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstDummy, 0);
            }
            dstOn256 = StaticSum256Avx2(srcArray, srcArray.Length);
            CheckResult256("Sum256Avx2");
        }

#endif // BENCHMARKS_ALGORITHM
        #endregion // BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum YGroup2Unzip - Vector256 - Traits.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum256Traits(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector256s<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> vector1Used = vector1.ExAsVector256();
            Vector256<TMy> vrt = Vector256s<TMy>.Zero; // Vector256 result.
            Vector256<TMy> vrt1 = Vector256s<TMy>.Zero;
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector256 processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256<TMy> vtemp = Vector256s.YGroup2Unzip(p0, vector1Used, out var vtemp1);
                vrt = Add(vrt, vtemp);
                vrt1 = Add(vrt1, vtemp1);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector256<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = Add(vrt, vrt1);
            rt = Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum256Traits() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstDummy, 0);
            }
            dstOn256 = StaticSum256Traits(srcArray, srcArray.Length);
            CheckResult256("Sum256Traits");
        }

#endif // BENCHMARKS_256 && NETCOREAPP3_0_OR_GREATER
        #endregion // BENCHMARKS_256


    }
}
