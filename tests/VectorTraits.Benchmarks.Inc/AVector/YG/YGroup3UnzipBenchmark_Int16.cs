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
using Zyl.VectorTraits.Impl.AVector512;

namespace Zyl.VectorTraits.Benchmarks.AVector.YG {
#if BENCHMARKS_OFF
    using BenchmarkAttribute = FakeBenchmarkAttribute;
#else
#endif // BENCHMARKS_OFF

    // My type.
    using TMy = Int16;

    /// <summary>
    /// YGroup3Unzip benchmark - Int16.
    /// </summary>
#if NETCOREAPP3_0_OR_GREATER && DRY_JOB
    [DryJob]
#endif // NETCOREAPP3_0_OR_GREATER && DRY_JOB
    public partial class YGroup3UnzipBenchmark_Int16 : AbstractSharedBenchmark_Int16 {

        // -- var --
        private static readonly Vector<TMy> vector1 = Vectors<TMy>.SerialNegative;
        private static readonly Vector<TMy> vector2 = Vectors<TMy>.SerialDesc;


        #region BENCHMARKS_128
#if BENCHMARKS_128 && NETCOREAPP3_0_OR_GREATER

        protected TMy dstOn128 = default, baselineOn128 = default;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected virtual void CheckResult128(string name) {
            CheckResult_Report(name, dstOn128 != baselineOn128, dstOn128, baselineOn128);
        }

        /// <summary>
        /// Sum YGroup3Unzip - Vector128 - base - basic.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128Base_Basic(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vector1Used = vector1.AsVector128();
            Vector128<TMy> vector2Used = vector2.AsVector128();
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector result.
            Vector128<TMy> vrt1 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt2 = Vector128<TMy>.Zero;
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector128<TMy> vtemp = WVectorTraits128Base.Statics.YGroup3Unzip_Basic(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
                vrt = WVectorTraits128Base.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits128Base.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits128Base.Statics.Add(vrt2, vtemp2);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits128Base.Statics.Add(vrt, vrt1);
            vrt = WVectorTraits128Base.Statics.Add(vrt, vrt2);
            rt = WVectorTraits128Base.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark(Baseline = true)]
        public void Sum128Base_Basic() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn128 = StaticSum128Base_Basic(srcArray, srcArray.Length);
            if (CheckMode) {
                baselineOn128 = dstOn128;
                BenchmarkUtil.WriteItem("# Sum128Base_Basic", string.Format("{0}", baselineOn128));
            }
        }

        #region BENCHMARKS_ALGORITHM
#if BENCHMARKS_ALGORITHM

#if NET7_0_OR_GREATER

        /// <summary>
        /// Sum YGroup3Unzip - Vector128 - base - ByX2Zip.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128Base_ByX2Zip(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vector1Used = vector1.AsVector128();
            Vector128<TMy> vector2Used = vector2.AsVector128();
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector result.
            Vector128<TMy> vrt1 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt2 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt3 = Vector128<TMy>.Zero;
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector128<TMy> vtemp = WVectorTraits128Base.Statics.YGroup3Unzip_ByX2Zip(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
                vrt = WVectorTraits128Base.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits128Base.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits128Base.Statics.Add(vrt2, vtemp2);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits128Base.Statics.Add(vrt, vrt1);
            vrt = WVectorTraits128Base.Statics.Add(vrt, vrt2);
            rt = WVectorTraits128Base.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum128Base_ByX2Zip() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn128 = StaticSum128Base_ByX2Zip(srcArray, srcArray.Length);
            CheckResult128("Sum128Base_ByX2Zip");
        }

#endif // NET7_0_OR_GREATER

        /// <summary>
        /// Sum YGroup3Unzip - Vector128 - base.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128Base(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vector1Used = vector1.AsVector128();
            Vector128<TMy> vector2Used = vector2.AsVector128();
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector result.
            Vector128<TMy> vrt1 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt2 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt3 = Vector128<TMy>.Zero;
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector128<TMy> vtemp = WVectorTraits128Base.Statics.YGroup3Unzip(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
                vrt = WVectorTraits128Base.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits128Base.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits128Base.Statics.Add(vrt2, vtemp2);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits128Base.Statics.Add(vrt, vrt1);
            vrt = WVectorTraits128Base.Statics.Add(vrt, vrt2);
            rt = WVectorTraits128Base.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum128Base() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn128 = StaticSum128Base(srcArray, srcArray.Length);
            CheckResult128("Sum128Base");
        }

#if NET5_0_OR_GREATER

#if NET8_0_OR_GREATER

#endif // NET8_0_OR_GREATER

#endif // NET5_0_OR_GREATER

#if NET8_0_OR_GREATER

#endif // NET8_0_OR_GREATER

        /// <summary>
        /// Sum YGroup3Unzip - Vector128 - Sse - ByX2Zip.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128Sse_ByX2Zip(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vector1Used = vector1.AsVector128();
            Vector128<TMy> vector2Used = vector2.AsVector128();
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector result.
            Vector128<TMy> vrt1 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt2 = Vector128<TMy>.Zero;
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector128<TMy> vtemp = WVectorTraits128Sse.Statics.YGroup3Unzip_ByX2Zip(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
                vrt = WVectorTraits128Sse.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits128Sse.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits128Sse.Statics.Add(vrt2, vtemp2);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits128Sse.Statics.Add(vrt, vrt1);
            vrt = WVectorTraits128Sse.Statics.Add(vrt, vrt2);
            rt = WVectorTraits128Sse.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum128Sse_ByX2Zip() {
            WVectorTraits128Sse.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn128 = StaticSum128Sse_ByX2Zip(srcArray, srcArray.Length);
            CheckResult128("Sum128Sse_ByX2Zip");
        }

        /// <summary>
        /// Sum YGroup3Unzip - Vector128 - Sse - Shuffle.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128Sse_Shuffle(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vector1Used = vector1.AsVector128();
            Vector128<TMy> vector2Used = vector2.AsVector128();
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector result.
            Vector128<TMy> vrt1 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt2 = Vector128<TMy>.Zero;
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector128<TMy> vtemp = WVectorTraits128Sse.Statics.YGroup3Unzip_Shuffle(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
                vrt = WVectorTraits128Sse.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits128Sse.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits128Sse.Statics.Add(vrt2, vtemp2);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits128Sse.Statics.Add(vrt, vrt1);
            vrt = WVectorTraits128Sse.Statics.Add(vrt, vrt2);
            rt = WVectorTraits128Sse.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum128Sse_Shuffle() {
            WVectorTraits128Sse.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn128 = StaticSum128Sse_Shuffle(srcArray, srcArray.Length);
            CheckResult128("Sum128Sse_Shuffle");
        }

#if NET8_0_OR_GREATER
        /// <summary>
        /// Sum YGroup3Unzip - Vector128 - Sse - ShuffleX.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128Sse_ShuffleX(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vector1Used = vector1.AsVector128();
            Vector128<TMy> vector2Used = vector2.AsVector128();
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector result.
            Vector128<TMy> vrt1 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt2 = Vector128<TMy>.Zero;
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector128<TMy> vtemp = WVectorTraits128Sse.Statics.YGroup3Unzip_ShuffleX(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
                vrt = WVectorTraits128Sse.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits128Sse.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits128Sse.Statics.Add(vrt2, vtemp2);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits128Sse.Statics.Add(vrt, vrt1);
            vrt = WVectorTraits128Sse.Statics.Add(vrt, vrt2);
            rt = WVectorTraits128Sse.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum128Sse_ShuffleX() {
            WVectorTraits128Sse.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn128 = StaticSum128Sse_ShuffleX(srcArray, srcArray.Length);
            CheckResult128("Sum128Sse_ShuffleX");
        }
#endif // NET8_0_OR_GREATER

#endif // BENCHMARKS_ALGORITHM
        #endregion // BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum YGroup3Unzip - Vector128 - Traits.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128Traits(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vector1Used = vector1.AsVector128();
            Vector128<TMy> vector2Used = vector2.AsVector128();
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector result.
            Vector128<TMy> vrt1 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt2 = Vector128<TMy>.Zero;
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector128<TMy> vtemp = Vector128s.YGroup3Unzip(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
                vrt = Vector128s.Add(vrt, vtemp);
                vrt1 = Vector128s.Add(vrt1, vtemp1);
                vrt2 = Vector128s.Add(vrt2, vtemp2);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = Vector128s.Add(vrt, vrt1);
            vrt = Vector128s.Add(vrt, vrt2);
            rt = Vector128s.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum128Traits() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn128 = StaticSum128Traits(srcArray, srcArray.Length);
            CheckResult128("Sum128Traits");
        }

        /// <summary>
        /// Sum YGroup3UnzipX2 - Vector128 - base - basic.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128X2Base_Basic(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vector1Used = vector1.AsVector128();
            Vector128<TMy> vector2Used = vector2.AsVector128();
            Vector128<TMy> vector4Used = vector1Used;
            Vector128<TMy> vector5Used = vector2Used;
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector result.
            Vector128<TMy> vrt1 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt2 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt3 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt4 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt5 = Vector128<TMy>.Zero;
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector128<TMy> data3 = Unsafe.Add(ref p0, 1);
                Vector128<TMy> vtemp = WVectorTraits128Base.Statics.YGroup3UnzipX2_Basic(p0, vector1Used, vector2Used, data3, vector4Used, vector5Used, out var vtemp1, out var vtemp2, out var vtemp3, out var vtemp4, out var vtemp5);
                vrt = WVectorTraits128Base.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits128Base.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits128Base.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits128Base.Statics.Add(vrt3, vtemp3);
                vrt4 = WVectorTraits128Base.Statics.Add(vrt4, vtemp4);
                vrt5 = WVectorTraits128Base.Statics.Add(vrt5, vtemp5);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits128Base.Statics.Add(vrt, vrt1);
            vrt2 = WVectorTraits128Base.Statics.Add(vrt2, vrt3);
            vrt4 = WVectorTraits128Base.Statics.Add(vrt4, vrt5);
            vrt = WVectorTraits128Base.Statics.Add(vrt, vrt2);
            vrt = WVectorTraits128Base.Statics.Add(vrt, vrt4);
            rt = WVectorTraits128Base.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum128X2Base_Basic() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn128 = StaticSum128X2Base_Basic(srcArray, srcArray.Length);
            if (CheckMode) {
                baselineOn128 = dstOn128;
                BenchmarkUtil.WriteItem("# Sum128X2Base_Basic", string.Format("{0}", baselineOn128));
            }
        }

        #region BENCHMARKS_ALGORITHM
#if BENCHMARKS_ALGORITHM
        /// <summary>
        /// Sum YGroup3UnzipX2 - Vector128 - base - X2.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128X2Base_X2(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vector1Used = vector1.AsVector128();
            Vector128<TMy> vector2Used = vector2.AsVector128();
            Vector128<TMy> vector4Used = vector1Used;
            Vector128<TMy> vector5Used = vector2Used;
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector result.
            Vector128<TMy> vrt1 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt2 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt3 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt4 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt5 = Vector128<TMy>.Zero;
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector128<TMy> data3 = Unsafe.Add(ref p0, 1);
                Vector128<TMy> vtemp = WVectorTraits128Base.Statics.YGroup3UnzipX2_X2(p0, vector1Used, vector2Used, data3, vector4Used, vector5Used, out var vtemp1, out var vtemp2, out var vtemp3, out var vtemp4, out var vtemp5);
                vrt = WVectorTraits128Base.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits128Base.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits128Base.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits128Base.Statics.Add(vrt3, vtemp3);
                vrt4 = WVectorTraits128Base.Statics.Add(vrt4, vtemp4);
                vrt5 = WVectorTraits128Base.Statics.Add(vrt5, vtemp5);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits128Base.Statics.Add(vrt, vrt1);
            vrt2 = WVectorTraits128Base.Statics.Add(vrt2, vrt3);
            vrt4 = WVectorTraits128Base.Statics.Add(vrt4, vrt5);
            vrt = WVectorTraits128Base.Statics.Add(vrt, vrt2);
            vrt = WVectorTraits128Base.Statics.Add(vrt, vrt4);
            rt = WVectorTraits128Base.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum128X2Base_X2() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn128 = StaticSum128X2Base_X2(srcArray, srcArray.Length);
            CheckResult128("Sum128X2Base_X2");
        }

#if NET7_0_OR_GREATER

        /// <summary>
        /// Sum YGroup3UnzipX2 - Vector128 - base - Zip.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128X2Base_Zip(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vector1Used = vector1.AsVector128();
            Vector128<TMy> vector2Used = vector2.AsVector128();
            Vector128<TMy> vector4Used = vector1Used;
            Vector128<TMy> vector5Used = vector2Used;
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector result.
            Vector128<TMy> vrt1 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt2 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt3 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt4 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt5 = Vector128<TMy>.Zero;
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector128<TMy> data3 = Unsafe.Add(ref p0, 1);
                Vector128<TMy> vtemp = WVectorTraits128Base.Statics.YGroup3UnzipX2_Zip(p0, vector1Used, vector2Used, data3, vector4Used, vector5Used, out var vtemp1, out var vtemp2, out var vtemp3, out var vtemp4, out var vtemp5);
                vrt = WVectorTraits128Base.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits128Base.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits128Base.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits128Base.Statics.Add(vrt3, vtemp3);
                vrt4 = WVectorTraits128Base.Statics.Add(vrt4, vtemp4);
                vrt5 = WVectorTraits128Base.Statics.Add(vrt5, vtemp5);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits128Base.Statics.Add(vrt, vrt1);
            vrt2 = WVectorTraits128Base.Statics.Add(vrt2, vrt3);
            vrt4 = WVectorTraits128Base.Statics.Add(vrt4, vrt5);
            vrt = WVectorTraits128Base.Statics.Add(vrt, vrt2);
            vrt = WVectorTraits128Base.Statics.Add(vrt, vrt4);
            rt = WVectorTraits128Base.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum128X2Base_Zip() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn128 = StaticSum128X2Base_Zip(srcArray, srcArray.Length);
            CheckResult128("Sum128X2Base_Zip");
        }

#endif // NET7_0_OR_GREATER

        /// <summary>
        /// Sum YGroup3UnzipX2 - Vector128 - base.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128X2Base(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vector1Used = vector1.AsVector128();
            Vector128<TMy> vector2Used = vector2.AsVector128();
            Vector128<TMy> vector4Used = vector1Used;
            Vector128<TMy> vector5Used = vector2Used;
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector result.
            Vector128<TMy> vrt1 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt2 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt3 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt4 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt5 = Vector128<TMy>.Zero;
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector128<TMy> data3 = Unsafe.Add(ref p0, 1);
                Vector128<TMy> vtemp = WVectorTraits128Base.Statics.YGroup3UnzipX2(p0, vector1Used, vector2Used, data3, vector4Used, vector5Used, out var vtemp1, out var vtemp2, out var vtemp3, out var vtemp4, out var vtemp5);
                vrt = WVectorTraits128Base.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits128Base.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits128Base.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits128Base.Statics.Add(vrt3, vtemp3);
                vrt4 = WVectorTraits128Base.Statics.Add(vrt4, vtemp4);
                vrt5 = WVectorTraits128Base.Statics.Add(vrt5, vtemp5);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits128Base.Statics.Add(vrt, vrt1);
            vrt2 = WVectorTraits128Base.Statics.Add(vrt2, vrt3);
            vrt4 = WVectorTraits128Base.Statics.Add(vrt4, vrt5);
            vrt = WVectorTraits128Base.Statics.Add(vrt, vrt2);
            vrt = WVectorTraits128Base.Statics.Add(vrt, vrt4);
            rt = WVectorTraits128Base.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum128X2Base() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn128 = StaticSum128X2Base(srcArray, srcArray.Length);
            CheckResult128("Sum128X2Base");
        }

#if NET5_0_OR_GREATER

#if NET8_0_OR_GREATER

#endif // NET8_0_OR_GREATER

#endif // NET5_0_OR_GREATER

#if NET8_0_OR_GREATER

#endif // NET8_0_OR_GREATER

        /// <summary>
        /// Sum YGroup3UnzipX2 - Vector128 - Sse - X2.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128X2Sse_X2(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vector1Used = vector1.AsVector128();
            Vector128<TMy> vector2Used = vector2.AsVector128();
            Vector128<TMy> vector4Used = vector1Used;
            Vector128<TMy> vector5Used = vector2Used;
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector result.
            Vector128<TMy> vrt1 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt2 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt3 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt4 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt5 = Vector128<TMy>.Zero;
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector128<TMy> data3 = Unsafe.Add(ref p0, 1);
                Vector128<TMy> vtemp = WVectorTraits128Sse.Statics.YGroup3UnzipX2_X2(p0, vector1Used, vector2Used, data3, vector4Used, vector5Used, out var vtemp1, out var vtemp2, out var vtemp3, out var vtemp4, out var vtemp5);
                vrt = WVectorTraits128Sse.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits128Sse.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits128Sse.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits128Sse.Statics.Add(vrt3, vtemp3);
                vrt4 = WVectorTraits128Sse.Statics.Add(vrt4, vtemp4);
                vrt5 = WVectorTraits128Sse.Statics.Add(vrt5, vtemp5);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits128Sse.Statics.Add(vrt, vrt1);
            vrt2 = WVectorTraits128Sse.Statics.Add(vrt2, vrt3);
            vrt4 = WVectorTraits128Sse.Statics.Add(vrt4, vrt5);
            vrt = WVectorTraits128Sse.Statics.Add(vrt, vrt2);
            vrt = WVectorTraits128Sse.Statics.Add(vrt, vrt4);
            rt = WVectorTraits128Sse.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum128X2Sse_X2() {
            WVectorTraits128Sse.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn128 = StaticSum128X2Sse_X2(srcArray, srcArray.Length);
            CheckResult128("Sum128X2Sse_X2");
        }

        /// <summary>
        /// Sum YGroup3UnzipX2 - Vector128 - Sse - Zip.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128X2Sse_Zip(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vector1Used = vector1.AsVector128();
            Vector128<TMy> vector2Used = vector2.AsVector128();
            Vector128<TMy> vector4Used = vector1Used;
            Vector128<TMy> vector5Used = vector2Used;
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector result.
            Vector128<TMy> vrt1 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt2 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt3 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt4 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt5 = Vector128<TMy>.Zero;
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector128<TMy> data3 = Unsafe.Add(ref p0, 1);
                Vector128<TMy> vtemp = WVectorTraits128Sse.Statics.YGroup3UnzipX2_Zip(p0, vector1Used, vector2Used, data3, vector4Used, vector5Used, out var vtemp1, out var vtemp2, out var vtemp3, out var vtemp4, out var vtemp5);
                vrt = WVectorTraits128Sse.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits128Sse.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits128Sse.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits128Sse.Statics.Add(vrt3, vtemp3);
                vrt4 = WVectorTraits128Sse.Statics.Add(vrt4, vtemp4);
                vrt5 = WVectorTraits128Sse.Statics.Add(vrt5, vtemp5);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits128Sse.Statics.Add(vrt, vrt1);
            vrt2 = WVectorTraits128Sse.Statics.Add(vrt2, vrt3);
            vrt4 = WVectorTraits128Sse.Statics.Add(vrt4, vrt5);
            vrt = WVectorTraits128Sse.Statics.Add(vrt, vrt2);
            vrt = WVectorTraits128Sse.Statics.Add(vrt, vrt4);
            rt = WVectorTraits128Sse.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum128X2Sse_Zip() {
            WVectorTraits128Sse.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn128 = StaticSum128X2Sse_Zip(srcArray, srcArray.Length);
            CheckResult128("Sum128X2Sse_Zip");
        }

#endif // BENCHMARKS_ALGORITHM
        #endregion // BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum YGroup3UnzipX2 - Vector128 - Traits.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128X2Traits(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vector1Used = vector1.AsVector128();
            Vector128<TMy> vector2Used = vector2.AsVector128();
            Vector128<TMy> vector4Used = vector1Used;
            Vector128<TMy> vector5Used = vector2Used;
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector result.
            Vector128<TMy> vrt1 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt2 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt3 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt4 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt5 = Vector128<TMy>.Zero;
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector128<TMy> data3 = Unsafe.Add(ref p0, 1);
                Vector128<TMy> vtemp = Vector128s.YGroup3UnzipX2(p0, vector1Used, vector2Used, data3, vector4Used, vector5Used, out var vtemp1, out var vtemp2, out var vtemp3, out var vtemp4, out var vtemp5);
                vrt = Vector128s.Add(vrt, vtemp);
                vrt1 = Vector128s.Add(vrt1, vtemp1);
                vrt2 = Vector128s.Add(vrt2, vtemp2);
                vrt3 = Vector128s.Add(vrt3, vtemp3);
                vrt4 = Vector128s.Add(vrt4, vtemp4);
                vrt5 = Vector128s.Add(vrt5, vtemp5);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = Vector128s.Add(vrt, vrt1);
            vrt2 = Vector128s.Add(vrt2, vrt3);
            vrt4 = Vector128s.Add(vrt4, vrt5);
            vrt = Vector128s.Add(vrt, vrt2);
            vrt = Vector128s.Add(vrt, vrt4);
            rt = Vector128s.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum128X2Traits() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn128 = StaticSum128X2Traits(srcArray, srcArray.Length);
            CheckResult128("Sum128X2Traits");
        }

#endif // BENCHMARKS_128 && NETCOREAPP3_0_OR_GREATER
        #endregion // BENCHMARKS_128


        #region BENCHMARKS_256
#if BENCHMARKS_256 && NETCOREAPP3_0_OR_GREATER

        protected TMy dstOn256 = default, baselineOn256 = default;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected virtual void CheckResult256(string name) {
            CheckResult_Report(name, dstOn256 != baselineOn256, dstOn256, baselineOn256);
        }

        #region BENCHMARKS_ALGORITHM
#if BENCHMARKS_ALGORITHM

#endif // BENCHMARKS_ALGORITHM
        #endregion // BENCHMARKS_ALGORITHM

#endif // BENCHMARKS_256 && NETCOREAPP3_0_OR_GREATER
        #endregion // BENCHMARKS_256


        #region BENCHMARKS_512
#if BENCHMARKS_512 && NET8_0_OR_GREATER

        protected TMy dstOn512 = default, baselineOn512 = default;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected virtual void CheckResult512(string name) {
            CheckResult_Report(name, dstOn512 != baselineOn512, dstOn512, baselineOn512);
        }

        #region BENCHMARKS_ALGORITHM
#if BENCHMARKS_ALGORITHM

#endif // BENCHMARKS_ALGORITHM
        #endregion // BENCHMARKS_ALGORITHM

#endif // BENCHMARKS_512 && NET8_0_OR_GREATER
        #endregion // BENCHMARKS_512

    }
}
