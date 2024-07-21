//#undef BENCHMARKS_OFF

#if NET7_0_OR_GREATER
#define VECTOR_HAS_METHOD
#endif // NET7_0_OR_GREATER

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

namespace Zyl.VectorTraits.Benchmarks.AVector.YG {
#if BENCHMARKS_OFF
    using BenchmarkAttribute = FakeBenchmarkAttribute;
#else
#endif // BENCHMARKS_OFF

    // My type.
    using TMy = Int32;

    /// <summary>
    /// YGroup4Unzip benchmark - Int32.
    /// </summary>
#if NETCOREAPP3_0_OR_GREATER && DRY_JOB
    [DryJob]
#endif // NETCOREAPP3_0_OR_GREATER && DRY_JOB
    public partial class YGroup4UnzipBenchmark_Int32 : AbstractSharedBenchmark_Int32 {

        // -- var --
        private static readonly Vector<TMy> vector1 = Vectors<TMy>.SerialNegative;
        private static readonly Vector<TMy> vector2 = Vectors<TMy>.SerialDesc;
        private static readonly Vector<TMy> vector3 = Vectors<TMy>.Serial;


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
        /// Sum YGroup4Unzip - Vector256 - base - basic.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum256Base_Basic(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> vector1Used = vector1.AsVector256();
            Vector256<TMy> vector2Used = vector2.AsVector256();
            Vector256<TMy> vector3Used = vector3.AsVector256();
            Vector256<TMy> vrt = Vector256<TMy>.Zero; // Vector256 result.
            Vector256<TMy> vrt1 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt2 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt3 = Vector256<TMy>.Zero;
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector256 processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256<TMy> vtemp = WVectorTraits256Base.Statics.YGroup4Unzip_Basic(p0, vector1Used, vector2Used, vector3Used, out var vtemp1, out var vtemp2, out var vtemp3);
                vrt = WVectorTraits256Base.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits256Base.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits256Base.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits256Base.Statics.Add(vrt3, vtemp3);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector256<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits256Base.Statics.Add(vrt, vrt1);
            vrt2 = WVectorTraits256Base.Statics.Add(vrt2, vrt3);
            vrt = WVectorTraits256Base.Statics.Add(vrt, vrt2);
            rt = WVectorTraits256Base.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark(Baseline = true)]
        public void Sum256Base_Basic() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn256 = StaticSum256Base_Basic(srcArray, srcArray.Length);
            if (CheckMode) {
                baselineOn256 = dstOn256;
                BenchmarkUtil.WriteItem("# Sum256Base_Basic", string.Format("{0}", baselineOn256));
            }
        }

#if VECTOR_HAS_METHOD

        /// <summary>
        /// Sum YGroup4Unzip - Vector256 - base - Unzip.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum256Base_Unzip(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> vector1Used = vector1.AsVector256();
            Vector256<TMy> vector2Used = vector2.AsVector256();
            Vector256<TMy> vector3Used = vector3.AsVector256();
            Vector256<TMy> vrt = Vector256<TMy>.Zero; // Vector256 result.
            Vector256<TMy> vrt1 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt2 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt3 = Vector256<TMy>.Zero;
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector256 processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256<TMy> vtemp = WVectorTraits256Base.Statics.YGroup4Unzip_Unzip(p0, vector1Used, vector2Used, vector3Used, out var vtemp1, out var vtemp2, out var vtemp3);
                vrt = WVectorTraits256Base.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits256Base.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits256Base.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits256Base.Statics.Add(vrt3, vtemp3);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector256<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits256Base.Statics.Add(vrt, vrt1);
            vrt2 = WVectorTraits256Base.Statics.Add(vrt2, vrt3);
            vrt = WVectorTraits256Base.Statics.Add(vrt, vrt2);
            rt = WVectorTraits256Base.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum256Base_Unzip() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn256 = StaticSum256Base_Unzip(srcArray, srcArray.Length);
            CheckResult256("Sum256Base_Unzip");
        }

#endif // VECTOR_HAS_METHOD

        /// <summary>
        /// Sum YGroup4Unzip - Vector256 - base.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum256Base(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> vector1Used = vector1.AsVector256();
            Vector256<TMy> vector2Used = vector2.AsVector256();
            Vector256<TMy> vector3Used = vector3.AsVector256();
            Vector256<TMy> vrt = Vector256<TMy>.Zero; // Vector256 result.
            Vector256<TMy> vrt1 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt2 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt3 = Vector256<TMy>.Zero;
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector256 processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256<TMy> vtemp = WVectorTraits256Base.Statics.YGroup4Unzip(p0, vector1Used, vector2Used, vector3Used, out var vtemp1, out var vtemp2, out var vtemp3);
                vrt = WVectorTraits256Base.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits256Base.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits256Base.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits256Base.Statics.Add(vrt3, vtemp3);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector256<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits256Base.Statics.Add(vrt, vrt1);
            vrt2 = WVectorTraits256Base.Statics.Add(vrt2, vrt3);
            vrt = WVectorTraits256Base.Statics.Add(vrt, vrt2);
            rt = WVectorTraits256Base.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum256Base() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn256 = StaticSum256Base(srcArray, srcArray.Length);
            CheckResult256("Sum256Base");
        }

#if NET8_0_OR_GREATER
        /// <summary>
        /// Sum YGroup4Unzip - Vector256 - Avx2 - Permute.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum256Avx2_Permute(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> vector1Used = vector1.AsVector256();
            Vector256<TMy> vector2Used = vector2.AsVector256();
            Vector256<TMy> vector3Used = vector3.AsVector256();
            Vector256<TMy> vrt = Vector256<TMy>.Zero; // Vector256 result.
            Vector256<TMy> vrt1 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt2 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt3 = Vector256<TMy>.Zero;
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector256 processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256<TMy> vtemp = WVectorTraits256Avx2.Statics.YGroup4Unzip_PermuteLonger(p0, vector1Used, vector2Used, vector3Used, out var vtemp1, out var vtemp2, out var vtemp3);
                vrt = WVectorTraits256Avx2.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits256Avx2.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits256Avx2.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits256Avx2.Statics.Add(vrt3, vtemp3);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector256<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits256Avx2.Statics.Add(vrt, vrt1);
            vrt2 = WVectorTraits256Avx2.Statics.Add(vrt2, vrt3);
            vrt = WVectorTraits256Avx2.Statics.Add(vrt, vrt2);
            rt = WVectorTraits256Avx2.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum256Avx2_Permute() {
            WVectorTraits256Avx2.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn256 = StaticSum256Avx2_Permute(srcArray, srcArray.Length);
            CheckResult256("Sum256Avx2_Permute");
        }
#endif // NET8_0_OR_GREATER

        /// <summary>
        /// Sum YGroup4Unzip - Vector256 - Avx2 - Unpack.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum256Avx2_Unpack(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> vector1Used = vector1.AsVector256();
            Vector256<TMy> vector2Used = vector2.AsVector256();
            Vector256<TMy> vector3Used = vector3.AsVector256();
            Vector256<TMy> vrt = Vector256<TMy>.Zero; // Vector256 result.
            Vector256<TMy> vrt1 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt2 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt3 = Vector256<TMy>.Zero;
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector256 processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256<TMy> vtemp = WVectorTraits256Avx2.Statics.YGroup4Unzip_Unpack(p0, vector1Used, vector2Used, vector3Used, out var vtemp1, out var vtemp2, out var vtemp3);
                vrt = WVectorTraits256Avx2.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits256Avx2.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits256Avx2.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits256Avx2.Statics.Add(vrt3, vtemp3);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector256<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits256Avx2.Statics.Add(vrt, vrt1);
            vrt2 = WVectorTraits256Avx2.Statics.Add(vrt2, vrt3);
            vrt = WVectorTraits256Avx2.Statics.Add(vrt, vrt2);
            rt = WVectorTraits256Avx2.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum256Avx2_Unpack() {
            WVectorTraits256Avx2.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn256 = StaticSum256Avx2_Unpack(srcArray, srcArray.Length);
            CheckResult256("Sum256Avx2_Unpack");
        }

        /// <summary>
        /// Sum YGroup4Unzip - Vector256 - Avx2 - Unzip.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum256Avx2_Unzip(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> vector1Used = vector1.AsVector256();
            Vector256<TMy> vector2Used = vector2.AsVector256();
            Vector256<TMy> vector3Used = vector3.AsVector256();
            Vector256<TMy> vrt = Vector256<TMy>.Zero; // Vector256 result.
            Vector256<TMy> vrt1 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt2 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt3 = Vector256<TMy>.Zero;
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector256 processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256<TMy> vtemp = WVectorTraits256Avx2.Statics.YGroup4Unzip_Unzip(p0, vector1Used, vector2Used, vector3Used, out var vtemp1, out var vtemp2, out var vtemp3);
                vrt = WVectorTraits256Avx2.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits256Avx2.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits256Avx2.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits256Avx2.Statics.Add(vrt3, vtemp3);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector256<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits256Avx2.Statics.Add(vrt, vrt1);
            vrt2 = WVectorTraits256Avx2.Statics.Add(vrt2, vrt3);
            vrt = WVectorTraits256Avx2.Statics.Add(vrt, vrt2);
            rt = WVectorTraits256Avx2.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum256Avx2_Unzip() {
            WVectorTraits256Avx2.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn256 = StaticSum256Avx2_Unzip(srcArray, srcArray.Length);
            CheckResult256("Sum256Avx2_Unzip");
        }

#endif // BENCHMARKS_ALGORITHM
        #endregion // BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum YGroup4Unzip - Vector256 - Traits.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum256Traits(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> vector1Used = vector1.AsVector256();
            Vector256<TMy> vector2Used = vector2.AsVector256();
            Vector256<TMy> vector3Used = vector3.AsVector256();
            Vector256<TMy> vrt = Vector256<TMy>.Zero; // Vector256 result.
            Vector256<TMy> vrt1 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt2 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt3 = Vector256<TMy>.Zero;
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector256 processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256<TMy> vtemp = Vector256s.YGroup4Unzip(p0, vector1Used, vector2Used, vector3Used, out var vtemp1, out var vtemp2, out var vtemp3);
                vrt = Vector256s.Add(vrt, vtemp);
                vrt1 = Vector256s.Add(vrt1, vtemp1);
                vrt2 = Vector256s.Add(vrt2, vtemp2);
                vrt3 = Vector256s.Add(vrt3, vtemp3);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector256<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = Vector256s.Add(vrt, vrt1);
            vrt2 = Vector256s.Add(vrt2, vrt3);
            vrt = Vector256s.Add(vrt, vrt2);
            rt = Vector256s.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum256Traits() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn256 = StaticSum256Traits(srcArray, srcArray.Length);
            CheckResult256("Sum256Traits");
        }

#endif // BENCHMARKS_256 && NETCOREAPP3_0_OR_GREATER
        #endregion // BENCHMARKS_256


    }
}
