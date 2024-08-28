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
    using TMy = Int64;

    /// <summary>
    /// YGroup3Zip benchmark - Int64.
    /// </summary>
#if NETCOREAPP3_0_OR_GREATER && DRY_JOB
    [DryJob]
#endif // NETCOREAPP3_0_OR_GREATER && DRY_JOB
    public partial class YGroup3ZipBenchmark_Int64 : AbstractSharedBenchmark_Int64 {

        // -- var --
        private static readonly Vector<TMy> vector1 = Vectors<TMy>.SerialNegative;
        private static readonly Vector<TMy> vector2 = Vectors<TMy>.SerialDesc;


        /// <summary>
        /// Sum YGroup3Zip - Vector - base - basic.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumBase_Basic(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vector1Used = vector1;
            Vector<TMy> vector2Used = vector2;
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            Vector<TMy> vrt1 = Vector<TMy>.Zero;
            Vector<TMy> vrt2 = Vector<TMy>.Zero;
            int i;
            // Body.
            ref Vector<TMy> p0 = ref Unsafe.As<TMy, Vector<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector<TMy> vtemp = VectorTraitsBase.Statics.YGroup3Zip_Basic(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
                vrt = Vector.Add(vrt, vtemp);
                vrt1 = Vector.Add(vrt1, vtemp1);
                vrt2 = Vector.Add(vrt2, vtemp2);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = Vector.Add(vrt, vrt1);
            vrt = Vector.Add(vrt, vrt2);
            rt = VectorTraitsBase.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark(Baseline = true)]
        public void SumBase_Basic() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstTMy = StaticSumBase_Basic(srcArray, srcArray.Length);
            if (CheckMode) {
                baselineTMy = dstTMy;
                BenchmarkUtil.WriteItem("# SumBase_Basic", string.Format("{0}", baselineTMy));
            }
        }

        #region BENCHMARKS_ALGORITHM
#if BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum YGroup3Zip - Vector - base.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumBase(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vector1Used = vector1;
            Vector<TMy> vector2Used = vector2;
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            Vector<TMy> vrt1 = Vector<TMy>.Zero;
            Vector<TMy> vrt2 = Vector<TMy>.Zero;
            Vector<TMy> vrt3 = Vector<TMy>.Zero;
            int i;
            // Body.
            ref Vector<TMy> p0 = ref Unsafe.As<TMy, Vector<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector<TMy> vtemp = VectorTraitsBase.Statics.YGroup3Zip(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
                vrt = Vector.Add(vrt, vtemp);
                vrt1 = Vector.Add(vrt1, vtemp1);
                vrt2 = Vector.Add(vrt2, vtemp2);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = Vector.Add(vrt, vrt1);
            vrt = Vector.Add(vrt, vrt2);
            rt = VectorTraitsBase.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void SumBase() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstTMy = StaticSumBase(srcArray, srcArray.Length);
            CheckResult("SumBase");
        }

#endif // BENCHMARKS_ALGORITHM
        #endregion // BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum YGroup3Zip - Vector - Traits.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumTraits(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vector1Used = vector1;
            Vector<TMy> vector2Used = vector2;
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            Vector<TMy> vrt1 = Vector<TMy>.Zero;
            Vector<TMy> vrt2 = Vector<TMy>.Zero;
            int i;
            // Body.
            ref Vector<TMy> p0 = ref Unsafe.As<TMy, Vector<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector<TMy> vtemp = Vectors.YGroup3Zip(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
                vrt = Vector.Add(vrt, vtemp);
                vrt1 = Vector.Add(vrt1, vtemp1);
                vrt2 = Vector.Add(vrt2, vtemp2);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = Vector.Add(vrt, vrt1);
            vrt = Vector.Add(vrt, vrt2);
            rt = Vectors.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void SumTraits() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstTMy = StaticSumTraits(srcArray, srcArray.Length);
            CheckResult("SumTraits");
        }

        /// <summary>
        /// Sum YGroup3ZipX2 - Vector - base - basic.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumX2Base_Basic(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vector1Used = vector1;
            Vector<TMy> vector2Used = vector2;
            Vector<TMy> vector4Used = vector1Used;
            Vector<TMy> vector5Used = vector2Used;
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            Vector<TMy> vrt1 = Vector<TMy>.Zero;
            Vector<TMy> vrt2 = Vector<TMy>.Zero;
            Vector<TMy> vrt3 = Vector<TMy>.Zero;
            Vector<TMy> vrt4 = Vector<TMy>.Zero;
            Vector<TMy> vrt5 = Vector<TMy>.Zero;
            int i;
            // Body.
            ref Vector<TMy> p0 = ref Unsafe.As<TMy, Vector<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector<TMy> data3 = Unsafe.Add(ref p0, 1);
                Vector<TMy> vtemp = VectorTraitsBase.Statics.YGroup3ZipX2_Basic(p0, vector1Used, vector2Used, data3, vector4Used, vector5Used, out var vtemp1, out var vtemp2, out var vtemp3, out var vtemp4, out var vtemp5);
                vrt = Vector.Add(vrt, vtemp);
                vrt1 = Vector.Add(vrt1, vtemp1);
                vrt2 = Vector.Add(vrt2, vtemp2);
                vrt3 = Vector.Add(vrt3, vtemp3);
                vrt4 = Vector.Add(vrt4, vtemp4);
                vrt5 = Vector.Add(vrt5, vtemp5);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = Vector.Add(vrt, vrt1);
            vrt2 = Vector.Add(vrt2, vrt3);
            vrt4 = Vector.Add(vrt4, vrt5);
            vrt = Vector.Add(vrt, vrt2);
            vrt = Vector.Add(vrt, vrt4);
            rt = VectorTraitsBase.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void SumX2Base_Basic() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstTMy = StaticSumX2Base_Basic(srcArray, srcArray.Length);
            if (CheckMode) {
                baselineTMy = dstTMy;
                BenchmarkUtil.WriteItem("# SumX2Base_Basic", string.Format("{0}", baselineTMy));
            }
        }

        #region BENCHMARKS_ALGORITHM
#if BENCHMARKS_ALGORITHM
        /// <summary>
        /// Sum YGroup3ZipX2 - Vector - base - X2.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumX2Base_X2(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vector1Used = vector1;
            Vector<TMy> vector2Used = vector2;
            Vector<TMy> vector4Used = vector1Used;
            Vector<TMy> vector5Used = vector2Used;
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            Vector<TMy> vrt1 = Vector<TMy>.Zero;
            Vector<TMy> vrt2 = Vector<TMy>.Zero;
            Vector<TMy> vrt3 = Vector<TMy>.Zero;
            Vector<TMy> vrt4 = Vector<TMy>.Zero;
            Vector<TMy> vrt5 = Vector<TMy>.Zero;
            int i;
            // Body.
            ref Vector<TMy> p0 = ref Unsafe.As<TMy, Vector<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector<TMy> data3 = Unsafe.Add(ref p0, 1);
                Vector<TMy> vtemp = VectorTraitsBase.Statics.YGroup3ZipX2_X2(p0, vector1Used, vector2Used, data3, vector4Used, vector5Used, out var vtemp1, out var vtemp2, out var vtemp3, out var vtemp4, out var vtemp5);
                vrt = Vector.Add(vrt, vtemp);
                vrt1 = Vector.Add(vrt1, vtemp1);
                vrt2 = Vector.Add(vrt2, vtemp2);
                vrt3 = Vector.Add(vrt3, vtemp3);
                vrt4 = Vector.Add(vrt4, vtemp4);
                vrt5 = Vector.Add(vrt5, vtemp5);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = Vector.Add(vrt, vrt1);
            vrt2 = Vector.Add(vrt2, vrt3);
            vrt4 = Vector.Add(vrt4, vrt5);
            vrt = Vector.Add(vrt, vrt2);
            vrt = Vector.Add(vrt, vrt4);
            rt = VectorTraitsBase.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void SumX2Base_X2() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstTMy = StaticSumX2Base_X2(srcArray, srcArray.Length);
            CheckResult("SumX2Base_X2");
        }

        /// <summary>
        /// Sum YGroup3ZipX2 - Vector - base.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumX2Base(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vector1Used = vector1;
            Vector<TMy> vector2Used = vector2;
            Vector<TMy> vector4Used = vector1Used;
            Vector<TMy> vector5Used = vector2Used;
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            Vector<TMy> vrt1 = Vector<TMy>.Zero;
            Vector<TMy> vrt2 = Vector<TMy>.Zero;
            Vector<TMy> vrt3 = Vector<TMy>.Zero;
            Vector<TMy> vrt4 = Vector<TMy>.Zero;
            Vector<TMy> vrt5 = Vector<TMy>.Zero;
            int i;
            // Body.
            ref Vector<TMy> p0 = ref Unsafe.As<TMy, Vector<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector<TMy> data3 = Unsafe.Add(ref p0, 1);
                Vector<TMy> vtemp = VectorTraitsBase.Statics.YGroup3ZipX2(p0, vector1Used, vector2Used, data3, vector4Used, vector5Used, out var vtemp1, out var vtemp2, out var vtemp3, out var vtemp4, out var vtemp5);
                vrt = Vector.Add(vrt, vtemp);
                vrt1 = Vector.Add(vrt1, vtemp1);
                vrt2 = Vector.Add(vrt2, vtemp2);
                vrt3 = Vector.Add(vrt3, vtemp3);
                vrt4 = Vector.Add(vrt4, vtemp4);
                vrt5 = Vector.Add(vrt5, vtemp5);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = Vector.Add(vrt, vrt1);
            vrt2 = Vector.Add(vrt2, vrt3);
            vrt4 = Vector.Add(vrt4, vrt5);
            vrt = Vector.Add(vrt, vrt2);
            vrt = Vector.Add(vrt, vrt4);
            rt = VectorTraitsBase.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void SumX2Base() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstTMy = StaticSumX2Base(srcArray, srcArray.Length);
            CheckResult("SumX2Base");
        }

#endif // BENCHMARKS_ALGORITHM
        #endregion // BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum YGroup3ZipX2 - Vector - Traits.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumX2Traits(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vector1Used = vector1;
            Vector<TMy> vector2Used = vector2;
            Vector<TMy> vector4Used = vector1Used;
            Vector<TMy> vector5Used = vector2Used;
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            Vector<TMy> vrt1 = Vector<TMy>.Zero;
            Vector<TMy> vrt2 = Vector<TMy>.Zero;
            Vector<TMy> vrt3 = Vector<TMy>.Zero;
            Vector<TMy> vrt4 = Vector<TMy>.Zero;
            Vector<TMy> vrt5 = Vector<TMy>.Zero;
            int i;
            // Body.
            ref Vector<TMy> p0 = ref Unsafe.As<TMy, Vector<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector<TMy> data3 = Unsafe.Add(ref p0, 1);
                Vector<TMy> vtemp = Vectors.YGroup3ZipX2(p0, vector1Used, vector2Used, data3, vector4Used, vector5Used, out var vtemp1, out var vtemp2, out var vtemp3, out var vtemp4, out var vtemp5);
                vrt = Vector.Add(vrt, vtemp);
                vrt1 = Vector.Add(vrt1, vtemp1);
                vrt2 = Vector.Add(vrt2, vtemp2);
                vrt3 = Vector.Add(vrt3, vtemp3);
                vrt4 = Vector.Add(vrt4, vtemp4);
                vrt5 = Vector.Add(vrt5, vtemp5);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = Vector.Add(vrt, vrt1);
            vrt2 = Vector.Add(vrt2, vrt3);
            vrt4 = Vector.Add(vrt4, vrt5);
            vrt = Vector.Add(vrt, vrt2);
            vrt = Vector.Add(vrt, vrt4);
            rt = Vectors.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void SumX2Traits() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstTMy = StaticSumX2Traits(srcArray, srcArray.Length);
            CheckResult("SumX2Traits");
        }


        #region BENCHMARKS_128
#if BENCHMARKS_128 && NETCOREAPP3_0_OR_GREATER

        protected TMy dstOn128 = default, baselineOn128 = default;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected virtual void CheckResult128(string name) {
            CheckResult_Report(name, dstOn128 != baselineOn128, dstOn128, baselineOn128);
        }

        /// <summary>
        /// Sum YGroup3Zip - Vector128 - base - basic.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128Base_Basic(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
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
                Vector128<TMy> vtemp = WVectorTraits128Base.Statics.YGroup3Zip_Basic(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
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

        /// <summary>
        /// Sum YGroup3Zip - Vector128 - base - Move.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128Base_Move(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
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
                Vector128<TMy> vtemp = WVectorTraits128Base.Statics.YGroup3Zip_Move(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
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
        public void Sum128Base_Move() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn128 = StaticSum128Base_Move(srcArray, srcArray.Length);
            CheckResult128("Sum128Base_Move");
        }

        #region BENCHMARKS_ALGORITHM
#if BENCHMARKS_ALGORITHM

#if NET7_0_OR_GREATER

#endif // NET7_0_OR_GREATER

        /// <summary>
        /// Sum YGroup3Zip - Vector128 - base.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128Base(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
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
                Vector128<TMy> vtemp = WVectorTraits128Base.Statics.YGroup3Zip(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
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

        /// <summary>
        /// Sum YGroup3Zip - Vector128 - AdvSimd - ByX2Unzip.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128AdvSimd_ByX2Unzip(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
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
                Vector128<TMy> vtemp = WVectorTraits128AdvSimd.Statics.YGroup3Zip_ByX2Unzip(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
                vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits128AdvSimd.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits128AdvSimd.Statics.Add(vrt2, vtemp2);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vrt1);
            vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vrt2);
            rt = WVectorTraits128AdvSimd.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum128AdvSimd_ByX2Unzip() {
            WVectorTraits128AdvSimd.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn128 = StaticSum128AdvSimd_ByX2Unzip(srcArray, srcArray.Length);
            CheckResult128("Sum128AdvSimd_ByX2Unzip");
        }

        /// <summary>
        /// Sum YGroup3Zip - Vector128 - AdvSimd - Shuffle.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128AdvSimd_Shuffle(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
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
                Vector128<TMy> vtemp = WVectorTraits128AdvSimd.Statics.YGroup3Zip_Shuffle(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
                vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits128AdvSimd.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits128AdvSimd.Statics.Add(vrt2, vtemp2);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vrt1);
            vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vrt2);
            rt = WVectorTraits128AdvSimd.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum128AdvSimd_Shuffle() {
            WVectorTraits128AdvSimd.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn128 = StaticSum128AdvSimd_Shuffle(srcArray, srcArray.Length);
            CheckResult128("Sum128AdvSimd_Shuffle");
        }

#if NET8_0_OR_GREATER
        /// <summary>
        /// Sum YGroup3Zip - Vector128 - AdvSimd - ShuffleX.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128AdvSimd_ShuffleX(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
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
                Vector128<TMy> vtemp = WVectorTraits128AdvSimd.Statics.YGroup3Zip_ShuffleX(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
                vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits128AdvSimd.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits128AdvSimd.Statics.Add(vrt2, vtemp2);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vrt1);
            vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vrt2);
            rt = WVectorTraits128AdvSimd.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum128AdvSimd_ShuffleX() {
            WVectorTraits128AdvSimd.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn128 = StaticSum128AdvSimd_ShuffleX(srcArray, srcArray.Length);
            CheckResult128("Sum128AdvSimd_ShuffleX");
        }
#endif // NET8_0_OR_GREATER

        /// <summary>
        /// Sum YGroup3Zip - Vector128 - AdvSimdB64 - ByX2Unzip.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128AdvSimdB64_ByX2Unzip(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
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
                Vector128<TMy> vtemp = WVectorTraits128AdvSimdB64.Statics.YGroup3Zip_ByX2Unzip(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
                vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits128AdvSimd.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits128AdvSimd.Statics.Add(vrt2, vtemp2);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vrt1);
            vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vrt2);
            rt = WVectorTraits128AdvSimdB64.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum128AdvSimdB64_ByX2Unzip() {
            WVectorTraits128AdvSimdB64.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn128 = StaticSum128AdvSimdB64_ByX2Unzip(srcArray, srcArray.Length);
            CheckResult128("Sum128AdvSimdB64_ByX2Unzip");
        }

        /// <summary>
        /// Sum YGroup3Zip - Vector128 - AdvSimdB64 - Shuffle.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128AdvSimdB64_Shuffle(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
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
                Vector128<TMy> vtemp = WVectorTraits128AdvSimdB64.Statics.YGroup3Zip_Shuffle(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
                vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits128AdvSimd.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits128AdvSimd.Statics.Add(vrt2, vtemp2);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vrt1);
            vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vrt2);
            rt = WVectorTraits128AdvSimdB64.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum128AdvSimdB64_Shuffle() {
            WVectorTraits128AdvSimdB64.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn128 = StaticSum128AdvSimdB64_Shuffle(srcArray, srcArray.Length);
            CheckResult128("Sum128AdvSimdB64_Shuffle");
        }

#if NET8_0_OR_GREATER
        /// <summary>
        /// Sum YGroup3Zip - Vector128 - AdvSimdB64 - ShuffleX.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128AdvSimdB64_ShuffleX(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
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
                Vector128<TMy> vtemp = WVectorTraits128AdvSimdB64.Statics.YGroup3Zip_ShuffleX(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
                vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits128AdvSimd.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits128AdvSimd.Statics.Add(vrt2, vtemp2);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vrt1);
            vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vrt2);
            rt = WVectorTraits128AdvSimdB64.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum128AdvSimdB64_ShuffleX() {
            WVectorTraits128AdvSimdB64.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn128 = StaticSum128AdvSimdB64_ShuffleX(srcArray, srcArray.Length);
            CheckResult128("Sum128AdvSimdB64_ShuffleX");
        }
#endif // NET8_0_OR_GREATER

#endif // NET5_0_OR_GREATER

#if NET8_0_OR_GREATER

        /// <summary>
        /// Sum YGroup3Zip - Vector128 - PackedSimd - ByX2Unzip.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128PackedSimd_ByX2Unzip(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
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
                Vector128<TMy> vtemp = WVectorTraits128PackedSimd.Statics.YGroup3Zip_ByX2Unzip(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
                vrt = WVectorTraits128PackedSimd.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits128PackedSimd.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits128PackedSimd.Statics.Add(vrt2, vtemp2);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits128PackedSimd.Statics.Add(vrt, vrt1);
            vrt = WVectorTraits128PackedSimd.Statics.Add(vrt, vrt2);
            rt = WVectorTraits128PackedSimd.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum128PackedSimd_ByX2Unzip() {
            WVectorTraits128PackedSimd.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn128 = StaticSum128PackedSimd_ByX2Unzip(srcArray, srcArray.Length);
            CheckResult128("Sum128PackedSimd_ByX2Unzip");
        }

        /// <summary>
        /// Sum YGroup3Zip - Vector128 - PackedSimd - Shuffle.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128PackedSimd_Shuffle(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
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
                Vector128<TMy> vtemp = WVectorTraits128PackedSimd.Statics.YGroup3Zip_Shuffle(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
                vrt = WVectorTraits128PackedSimd.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits128PackedSimd.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits128PackedSimd.Statics.Add(vrt2, vtemp2);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits128PackedSimd.Statics.Add(vrt, vrt1);
            vrt = WVectorTraits128PackedSimd.Statics.Add(vrt, vrt2);
            rt = WVectorTraits128PackedSimd.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum128PackedSimd_Shuffle() {
            WVectorTraits128PackedSimd.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn128 = StaticSum128PackedSimd_Shuffle(srcArray, srcArray.Length);
            CheckResult128("Sum128PackedSimd_Shuffle");
        }

#endif // NET8_0_OR_GREATER

        /// <summary>
        /// Sum YGroup3Zip - Vector128 - Sse - ByX2Unzip.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128Sse_ByX2Unzip(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
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
                Vector128<TMy> vtemp = WVectorTraits128Sse.Statics.YGroup3Zip_ByX2Unzip(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
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
        public void Sum128Sse_ByX2Unzip() {
            WVectorTraits128Sse.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn128 = StaticSum128Sse_ByX2Unzip(srcArray, srcArray.Length);
            CheckResult128("Sum128Sse_ByX2Unzip");
        }

        /// <summary>
        /// Sum YGroup3Zip - Vector128 - Sse - Shuffle.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128Sse_Shuffle(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
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
                Vector128<TMy> vtemp = WVectorTraits128Sse.Statics.YGroup3Zip_Shuffle(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
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
        /// Sum YGroup3Zip - Vector128 - Sse - ShuffleX.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128Sse_ShuffleX(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
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
                Vector128<TMy> vtemp = WVectorTraits128Sse.Statics.YGroup3Zip_ShuffleX(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
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

        /// <summary>
        /// Sum YGroup3Zip - Vector128 - Sse - ShuffleXImm.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128Sse_ShuffleXImm(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
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
                Vector128<TMy> vtemp = WVectorTraits128Sse.Statics.YGroup3Zip_ShuffleXImm(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
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
        public void Sum128Sse_ShuffleXImm() {
            WVectorTraits128Sse.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn128 = StaticSum128Sse_ShuffleXImm(srcArray, srcArray.Length);
            CheckResult128("Sum128Sse_ShuffleXImm");
        }

#endif // BENCHMARKS_ALGORITHM
        #endregion // BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum YGroup3Zip - Vector128 - Traits.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128Traits(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
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
                Vector128<TMy> vtemp = Vector128s.YGroup3Zip(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
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
        /// Sum YGroup3ZipX2 - Vector128 - base - basic.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128X2Base_Basic(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
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
                Vector128<TMy> vtemp = WVectorTraits128Base.Statics.YGroup3ZipX2_Basic(p0, vector1Used, vector2Used, data3, vector4Used, vector5Used, out var vtemp1, out var vtemp2, out var vtemp3, out var vtemp4, out var vtemp5);
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
        /// Sum YGroup3ZipX2 - Vector128 - base - X2.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128X2Base_X2(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
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
                Vector128<TMy> vtemp = WVectorTraits128Base.Statics.YGroup3ZipX2_X2(p0, vector1Used, vector2Used, data3, vector4Used, vector5Used, out var vtemp1, out var vtemp2, out var vtemp3, out var vtemp4, out var vtemp5);
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

#endif // NET7_0_OR_GREATER

        /// <summary>
        /// Sum YGroup3ZipX2 - Vector128 - base.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128X2Base(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
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
                Vector128<TMy> vtemp = WVectorTraits128Base.Statics.YGroup3ZipX2(p0, vector1Used, vector2Used, data3, vector4Used, vector5Used, out var vtemp1, out var vtemp2, out var vtemp3, out var vtemp4, out var vtemp5);
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

        /// <summary>
        /// Sum YGroup3ZipX2 - Vector128 - AdvSimd - X2.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128X2AdvSimd_X2(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
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
                Vector128<TMy> vtemp = WVectorTraits128AdvSimd.Statics.YGroup3ZipX2_X2(p0, vector1Used, vector2Used, data3, vector4Used, vector5Used, out var vtemp1, out var vtemp2, out var vtemp3, out var vtemp4, out var vtemp5);
                vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits128AdvSimd.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits128AdvSimd.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits128AdvSimd.Statics.Add(vrt3, vtemp3);
                vrt4 = WVectorTraits128AdvSimd.Statics.Add(vrt4, vtemp4);
                vrt5 = WVectorTraits128AdvSimd.Statics.Add(vrt5, vtemp5);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vrt1);
            vrt2 = WVectorTraits128AdvSimd.Statics.Add(vrt2, vrt3);
            vrt4 = WVectorTraits128AdvSimd.Statics.Add(vrt4, vrt5);
            vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vrt2);
            vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vrt4);
            rt = WVectorTraits128AdvSimd.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum128X2AdvSimd_X2() {
            WVectorTraits128AdvSimd.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn128 = StaticSum128X2AdvSimd_X2(srcArray, srcArray.Length);
            CheckResult128("Sum128X2AdvSimd_X2");
        }

        /// <summary>
        /// Sum YGroup3ZipX2 - Vector128 - AdvSimd - Unzip.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128X2AdvSimd_Unzip(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
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
                Vector128<TMy> vtemp = WVectorTraits128AdvSimd.Statics.YGroup3ZipX2_Unzip(p0, vector1Used, vector2Used, data3, vector4Used, vector5Used, out var vtemp1, out var vtemp2, out var vtemp3, out var vtemp4, out var vtemp5);
                vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits128AdvSimd.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits128AdvSimd.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits128AdvSimd.Statics.Add(vrt3, vtemp3);
                vrt4 = WVectorTraits128AdvSimd.Statics.Add(vrt4, vtemp4);
                vrt5 = WVectorTraits128AdvSimd.Statics.Add(vrt5, vtemp5);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vrt1);
            vrt2 = WVectorTraits128AdvSimd.Statics.Add(vrt2, vrt3);
            vrt4 = WVectorTraits128AdvSimd.Statics.Add(vrt4, vrt5);
            vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vrt2);
            vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vrt4);
            rt = WVectorTraits128AdvSimd.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum128X2AdvSimd_Unzip() {
            WVectorTraits128AdvSimd.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn128 = StaticSum128X2AdvSimd_Unzip(srcArray, srcArray.Length);
            CheckResult128("Sum128X2AdvSimd_Unzip");
        }

        /// <summary>
        /// Sum YGroup3ZipX2 - Vector128 - AdvSimdB64 - X2.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128X2AdvSimdB64_X2(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
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
                Vector128<TMy> vtemp = WVectorTraits128AdvSimdB64.Statics.YGroup3ZipX2_X2(p0, vector1Used, vector2Used, data3, vector4Used, vector5Used, out var vtemp1, out var vtemp2, out var vtemp3, out var vtemp4, out var vtemp5);
                vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits128AdvSimd.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits128AdvSimd.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits128AdvSimd.Statics.Add(vrt3, vtemp3);
                vrt4 = WVectorTraits128AdvSimd.Statics.Add(vrt4, vtemp4);
                vrt5 = WVectorTraits128AdvSimd.Statics.Add(vrt5, vtemp5);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vrt1);
            vrt2 = WVectorTraits128AdvSimd.Statics.Add(vrt2, vrt3);
            vrt4 = WVectorTraits128AdvSimd.Statics.Add(vrt4, vrt5);
            vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vrt2);
            vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vrt4);
            rt = WVectorTraits128AdvSimdB64.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum128X2AdvSimdB64_X2() {
            WVectorTraits128AdvSimdB64.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn128 = StaticSum128X2AdvSimdB64_X2(srcArray, srcArray.Length);
            CheckResult128("Sum128X2AdvSimdB64_X2");
        }

        /// <summary>
        /// Sum YGroup3ZipX2 - Vector128 - AdvSimdB64 - Unzip.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128X2AdvSimdB64_Unzip(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
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
                Vector128<TMy> vtemp = WVectorTraits128AdvSimdB64.Statics.YGroup3ZipX2_Unzip(p0, vector1Used, vector2Used, data3, vector4Used, vector5Used, out var vtemp1, out var vtemp2, out var vtemp3, out var vtemp4, out var vtemp5);
                vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits128AdvSimd.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits128AdvSimd.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits128AdvSimd.Statics.Add(vrt3, vtemp3);
                vrt4 = WVectorTraits128AdvSimd.Statics.Add(vrt4, vtemp4);
                vrt5 = WVectorTraits128AdvSimd.Statics.Add(vrt5, vtemp5);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vrt1);
            vrt2 = WVectorTraits128AdvSimd.Statics.Add(vrt2, vrt3);
            vrt4 = WVectorTraits128AdvSimd.Statics.Add(vrt4, vrt5);
            vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vrt2);
            vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vrt4);
            rt = WVectorTraits128AdvSimdB64.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum128X2AdvSimdB64_Unzip() {
            WVectorTraits128AdvSimdB64.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn128 = StaticSum128X2AdvSimdB64_Unzip(srcArray, srcArray.Length);
            CheckResult128("Sum128X2AdvSimdB64_Unzip");
        }

#endif // NET5_0_OR_GREATER

#if NET8_0_OR_GREATER

        /// <summary>
        /// Sum YGroup3ZipX2 - Vector128 - PackedSimd - X2.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128X2PackedSimd_X2(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
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
                Vector128<TMy> vtemp = WVectorTraits128PackedSimd.Statics.YGroup3ZipX2_X2(p0, vector1Used, vector2Used, data3, vector4Used, vector5Used, out var vtemp1, out var vtemp2, out var vtemp3, out var vtemp4, out var vtemp5);
                vrt = WVectorTraits128PackedSimd.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits128PackedSimd.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits128PackedSimd.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits128PackedSimd.Statics.Add(vrt3, vtemp3);
                vrt4 = WVectorTraits128PackedSimd.Statics.Add(vrt4, vtemp4);
                vrt5 = WVectorTraits128PackedSimd.Statics.Add(vrt5, vtemp5);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits128PackedSimd.Statics.Add(vrt, vrt1);
            vrt2 = WVectorTraits128PackedSimd.Statics.Add(vrt2, vrt3);
            vrt4 = WVectorTraits128PackedSimd.Statics.Add(vrt4, vrt5);
            vrt = WVectorTraits128PackedSimd.Statics.Add(vrt, vrt2);
            vrt = WVectorTraits128PackedSimd.Statics.Add(vrt, vrt4);
            rt = WVectorTraits128PackedSimd.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum128X2PackedSimd_X2() {
            WVectorTraits128PackedSimd.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn128 = StaticSum128X2PackedSimd_X2(srcArray, srcArray.Length);
            CheckResult128("Sum128X2PackedSimd_X2");
        }

        /// <summary>
        /// Sum YGroup3ZipX2 - Vector128 - PackedSimd - Unzip.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128X2PackedSimd_Unzip(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
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
                Vector128<TMy> vtemp = WVectorTraits128PackedSimd.Statics.YGroup3ZipX2_Unzip(p0, vector1Used, vector2Used, data3, vector4Used, vector5Used, out var vtemp1, out var vtemp2, out var vtemp3, out var vtemp4, out var vtemp5);
                vrt = WVectorTraits128PackedSimd.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits128PackedSimd.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits128PackedSimd.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits128PackedSimd.Statics.Add(vrt3, vtemp3);
                vrt4 = WVectorTraits128PackedSimd.Statics.Add(vrt4, vtemp4);
                vrt5 = WVectorTraits128PackedSimd.Statics.Add(vrt5, vtemp5);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits128PackedSimd.Statics.Add(vrt, vrt1);
            vrt2 = WVectorTraits128PackedSimd.Statics.Add(vrt2, vrt3);
            vrt4 = WVectorTraits128PackedSimd.Statics.Add(vrt4, vrt5);
            vrt = WVectorTraits128PackedSimd.Statics.Add(vrt, vrt2);
            vrt = WVectorTraits128PackedSimd.Statics.Add(vrt, vrt4);
            rt = WVectorTraits128PackedSimd.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum128X2PackedSimd_Unzip() {
            WVectorTraits128PackedSimd.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn128 = StaticSum128X2PackedSimd_Unzip(srcArray, srcArray.Length);
            CheckResult128("Sum128X2PackedSimd_Unzip");
        }

#endif // NET8_0_OR_GREATER

        /// <summary>
        /// Sum YGroup3ZipX2 - Vector128 - Sse - X2.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128X2Sse_X2(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
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
                Vector128<TMy> vtemp = WVectorTraits128Sse.Statics.YGroup3ZipX2_X2(p0, vector1Used, vector2Used, data3, vector4Used, vector5Used, out var vtemp1, out var vtemp2, out var vtemp3, out var vtemp4, out var vtemp5);
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
        /// Sum YGroup3ZipX2 - Vector128 - Sse - Unzip.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128X2Sse_Unzip(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
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
                Vector128<TMy> vtemp = WVectorTraits128Sse.Statics.YGroup3ZipX2_Unzip(p0, vector1Used, vector2Used, data3, vector4Used, vector5Used, out var vtemp1, out var vtemp2, out var vtemp3, out var vtemp4, out var vtemp5);
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
        public void Sum128X2Sse_Unzip() {
            WVectorTraits128Sse.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn128 = StaticSum128X2Sse_Unzip(srcArray, srcArray.Length);
            CheckResult128("Sum128X2Sse_Unzip");
        }

#endif // BENCHMARKS_ALGORITHM
        #endregion // BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum YGroup3ZipX2 - Vector128 - Traits.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128X2Traits(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
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
                Vector128<TMy> vtemp = Vector128s.YGroup3ZipX2(p0, vector1Used, vector2Used, data3, vector4Used, vector5Used, out var vtemp1, out var vtemp2, out var vtemp3, out var vtemp4, out var vtemp5);
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

        /// <summary>
        /// Sum YGroup3Zip - Vector256 - base - basic.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum256Base_Basic(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> vector1Used = vector1.AsVector256();
            Vector256<TMy> vector2Used = vector2.AsVector256();
            Vector256<TMy> vrt = Vector256<TMy>.Zero; // Vector result.
            Vector256<TMy> vrt1 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt2 = Vector256<TMy>.Zero;
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256<TMy> vtemp = WVectorTraits256Base.Statics.YGroup3Zip_Basic(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
                vrt = WVectorTraits256Base.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits256Base.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits256Base.Statics.Add(vrt2, vtemp2);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector256<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits256Base.Statics.Add(vrt, vrt1);
            vrt = WVectorTraits256Base.Statics.Add(vrt, vrt2);
            rt = WVectorTraits256Base.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
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

        #region BENCHMARKS_ALGORITHM
#if BENCHMARKS_ALGORITHM

#if NET7_0_OR_GREATER

        /// <summary>
        /// Sum YGroup3Zip - Vector256 - base - ByShorter.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum256Base_ByShorter(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> vector1Used = vector1.AsVector256();
            Vector256<TMy> vector2Used = vector2.AsVector256();
            Vector256<TMy> vrt = Vector256<TMy>.Zero; // Vector result.
            Vector256<TMy> vrt1 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt2 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt3 = Vector256<TMy>.Zero;
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256<TMy> vtemp = WVectorTraits256Base.Statics.YGroup3Zip_ByShorter(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
                vrt = WVectorTraits256Base.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits256Base.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits256Base.Statics.Add(vrt2, vtemp2);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector256<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits256Base.Statics.Add(vrt, vrt1);
            vrt = WVectorTraits256Base.Statics.Add(vrt, vrt2);
            rt = WVectorTraits256Base.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum256Base_ByShorter() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn256 = StaticSum256Base_ByShorter(srcArray, srcArray.Length);
            CheckResult256("Sum256Base_ByShorter");
        }

#endif // NET7_0_OR_GREATER

        /// <summary>
        /// Sum YGroup3Zip - Vector256 - base.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum256Base(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> vector1Used = vector1.AsVector256();
            Vector256<TMy> vector2Used = vector2.AsVector256();
            Vector256<TMy> vrt = Vector256<TMy>.Zero; // Vector result.
            Vector256<TMy> vrt1 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt2 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt3 = Vector256<TMy>.Zero;
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256<TMy> vtemp = WVectorTraits256Base.Statics.YGroup3Zip(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
                vrt = WVectorTraits256Base.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits256Base.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits256Base.Statics.Add(vrt2, vtemp2);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector256<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits256Base.Statics.Add(vrt, vrt1);
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

        /// <summary>
        /// Sum YGroup3Zip - Vector256 - Avx2 - ByShorter.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum256Avx2_ByShorter(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> vector1Used = vector1.AsVector256();
            Vector256<TMy> vector2Used = vector2.AsVector256();
            Vector256<TMy> vrt = Vector256<TMy>.Zero; // Vector result.
            Vector256<TMy> vrt1 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt2 = Vector256<TMy>.Zero;
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256<TMy> vtemp = WVectorTraits256Avx2.Statics.YGroup3Zip_ByShorter(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
                vrt = WVectorTraits256Avx2.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits256Avx2.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits256Avx2.Statics.Add(vrt2, vtemp2);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector256<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits256Avx2.Statics.Add(vrt, vrt1);
            vrt = WVectorTraits256Avx2.Statics.Add(vrt, vrt2);
            rt = WVectorTraits256Avx2.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum256Avx2_ByShorter() {
            WVectorTraits256Avx2.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn256 = StaticSum256Avx2_ByShorter(srcArray, srcArray.Length);
            CheckResult256("Sum256Avx2_ByShorter");
        }

        /// <summary>
        /// Sum YGroup3Zip - Vector256 - Avx2 - ByX2Unzip.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum256Avx2_ByX2Unzip(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> vector1Used = vector1.AsVector256();
            Vector256<TMy> vector2Used = vector2.AsVector256();
            Vector256<TMy> vrt = Vector256<TMy>.Zero; // Vector result.
            Vector256<TMy> vrt1 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt2 = Vector256<TMy>.Zero;
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256<TMy> vtemp = WVectorTraits256Avx2.Statics.YGroup3Zip_ByX2Unzip(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
                vrt = WVectorTraits256Avx2.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits256Avx2.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits256Avx2.Statics.Add(vrt2, vtemp2);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector256<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits256Avx2.Statics.Add(vrt, vrt1);
            vrt = WVectorTraits256Avx2.Statics.Add(vrt, vrt2);
            rt = WVectorTraits256Avx2.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum256Avx2_ByX2Unzip() {
            WVectorTraits256Avx2.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn256 = StaticSum256Avx2_ByX2Unzip(srcArray, srcArray.Length);
            CheckResult256("Sum256Avx2_ByX2Unzip");
        }

        /// <summary>
        /// Sum YGroup3Zip - Vector256 - Avx2 - Shuffle.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum256Avx2_Shuffle(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> vector1Used = vector1.AsVector256();
            Vector256<TMy> vector2Used = vector2.AsVector256();
            Vector256<TMy> vrt = Vector256<TMy>.Zero; // Vector result.
            Vector256<TMy> vrt1 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt2 = Vector256<TMy>.Zero;
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256<TMy> vtemp = WVectorTraits256Avx2.Statics.YGroup3Zip_Shuffle(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
                vrt = WVectorTraits256Avx2.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits256Avx2.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits256Avx2.Statics.Add(vrt2, vtemp2);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector256<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits256Avx2.Statics.Add(vrt, vrt1);
            vrt = WVectorTraits256Avx2.Statics.Add(vrt, vrt2);
            rt = WVectorTraits256Avx2.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum256Avx2_Shuffle() {
            WVectorTraits256Avx2.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn256 = StaticSum256Avx2_Shuffle(srcArray, srcArray.Length);
            CheckResult256("Sum256Avx2_Shuffle");
        }

#if NET8_0_OR_GREATER
        /// <summary>
        /// Sum YGroup3Zip - Vector256 - Avx2 - ShuffleX.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum256Avx2_ShuffleX(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> vector1Used = vector1.AsVector256();
            Vector256<TMy> vector2Used = vector2.AsVector256();
            Vector256<TMy> vrt = Vector256<TMy>.Zero; // Vector result.
            Vector256<TMy> vrt1 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt2 = Vector256<TMy>.Zero;
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256<TMy> vtemp = WVectorTraits256Avx2.Statics.YGroup3Zip_ShuffleX(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
                vrt = WVectorTraits256Avx2.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits256Avx2.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits256Avx2.Statics.Add(vrt2, vtemp2);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector256<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits256Avx2.Statics.Add(vrt, vrt1);
            vrt = WVectorTraits256Avx2.Statics.Add(vrt, vrt2);
            rt = WVectorTraits256Avx2.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum256Avx2_ShuffleX() {
            WVectorTraits256Avx2.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn256 = StaticSum256Avx2_ShuffleX(srcArray, srcArray.Length);
            CheckResult256("Sum256Avx2_ShuffleX");
        }
#endif // NET8_0_OR_GREATER

        /// <summary>
        /// Sum YGroup3Zip - Vector256 - Avx2 - ShuffleXImm.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum256Avx2_ShuffleXImm(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> vector1Used = vector1.AsVector256();
            Vector256<TMy> vector2Used = vector2.AsVector256();
            Vector256<TMy> vrt = Vector256<TMy>.Zero; // Vector result.
            Vector256<TMy> vrt1 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt2 = Vector256<TMy>.Zero;
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256<TMy> vtemp = WVectorTraits256Avx2.Statics.YGroup3Zip_ShuffleXImm(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
                vrt = WVectorTraits256Avx2.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits256Avx2.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits256Avx2.Statics.Add(vrt2, vtemp2);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector256<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits256Avx2.Statics.Add(vrt, vrt1);
            vrt = WVectorTraits256Avx2.Statics.Add(vrt, vrt2);
            rt = WVectorTraits256Avx2.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum256Avx2_ShuffleXImm() {
            WVectorTraits256Avx2.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn256 = StaticSum256Avx2_ShuffleXImm(srcArray, srcArray.Length);
            CheckResult256("Sum256Avx2_ShuffleXImm");
        }

#endif // BENCHMARKS_ALGORITHM
        #endregion // BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum YGroup3Zip - Vector256 - Traits.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum256Traits(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> vector1Used = vector1.AsVector256();
            Vector256<TMy> vector2Used = vector2.AsVector256();
            Vector256<TMy> vrt = Vector256<TMy>.Zero; // Vector result.
            Vector256<TMy> vrt1 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt2 = Vector256<TMy>.Zero;
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256<TMy> vtemp = Vector256s.YGroup3Zip(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
                vrt = Vector256s.Add(vrt, vtemp);
                vrt1 = Vector256s.Add(vrt1, vtemp1);
                vrt2 = Vector256s.Add(vrt2, vtemp2);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector256<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = Vector256s.Add(vrt, vrt1);
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

        /// <summary>
        /// Sum YGroup3ZipX2 - Vector256 - base - basic.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum256X2Base_Basic(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> vector1Used = vector1.AsVector256();
            Vector256<TMy> vector2Used = vector2.AsVector256();
            Vector256<TMy> vector4Used = vector1Used;
            Vector256<TMy> vector5Used = vector2Used;
            Vector256<TMy> vrt = Vector256<TMy>.Zero; // Vector result.
            Vector256<TMy> vrt1 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt2 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt3 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt4 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt5 = Vector256<TMy>.Zero;
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256<TMy> data3 = Unsafe.Add(ref p0, 1);
                Vector256<TMy> vtemp = WVectorTraits256Base.Statics.YGroup3ZipX2_Basic(p0, vector1Used, vector2Used, data3, vector4Used, vector5Used, out var vtemp1, out var vtemp2, out var vtemp3, out var vtemp4, out var vtemp5);
                vrt = WVectorTraits256Base.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits256Base.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits256Base.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits256Base.Statics.Add(vrt3, vtemp3);
                vrt4 = WVectorTraits256Base.Statics.Add(vrt4, vtemp4);
                vrt5 = WVectorTraits256Base.Statics.Add(vrt5, vtemp5);
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
            vrt4 = WVectorTraits256Base.Statics.Add(vrt4, vrt5);
            vrt = WVectorTraits256Base.Statics.Add(vrt, vrt2);
            vrt = WVectorTraits256Base.Statics.Add(vrt, vrt4);
            rt = WVectorTraits256Base.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum256X2Base_Basic() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn256 = StaticSum256X2Base_Basic(srcArray, srcArray.Length);
            if (CheckMode) {
                baselineOn256 = dstOn256;
                BenchmarkUtil.WriteItem("# Sum256X2Base_Basic", string.Format("{0}", baselineOn256));
            }
        }

        #region BENCHMARKS_ALGORITHM
#if BENCHMARKS_ALGORITHM
        /// <summary>
        /// Sum YGroup3ZipX2 - Vector256 - base - X2.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum256X2Base_X2(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> vector1Used = vector1.AsVector256();
            Vector256<TMy> vector2Used = vector2.AsVector256();
            Vector256<TMy> vector4Used = vector1Used;
            Vector256<TMy> vector5Used = vector2Used;
            Vector256<TMy> vrt = Vector256<TMy>.Zero; // Vector result.
            Vector256<TMy> vrt1 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt2 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt3 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt4 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt5 = Vector256<TMy>.Zero;
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256<TMy> data3 = Unsafe.Add(ref p0, 1);
                Vector256<TMy> vtemp = WVectorTraits256Base.Statics.YGroup3ZipX2_X2(p0, vector1Used, vector2Used, data3, vector4Used, vector5Used, out var vtemp1, out var vtemp2, out var vtemp3, out var vtemp4, out var vtemp5);
                vrt = WVectorTraits256Base.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits256Base.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits256Base.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits256Base.Statics.Add(vrt3, vtemp3);
                vrt4 = WVectorTraits256Base.Statics.Add(vrt4, vtemp4);
                vrt5 = WVectorTraits256Base.Statics.Add(vrt5, vtemp5);
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
            vrt4 = WVectorTraits256Base.Statics.Add(vrt4, vrt5);
            vrt = WVectorTraits256Base.Statics.Add(vrt, vrt2);
            vrt = WVectorTraits256Base.Statics.Add(vrt, vrt4);
            rt = WVectorTraits256Base.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum256X2Base_X2() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn256 = StaticSum256X2Base_X2(srcArray, srcArray.Length);
            CheckResult256("Sum256X2Base_X2");
        }

#if NET7_0_OR_GREATER

#endif // NET7_0_OR_GREATER

        /// <summary>
        /// Sum YGroup3ZipX2 - Vector256 - base.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum256X2Base(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> vector1Used = vector1.AsVector256();
            Vector256<TMy> vector2Used = vector2.AsVector256();
            Vector256<TMy> vector4Used = vector1Used;
            Vector256<TMy> vector5Used = vector2Used;
            Vector256<TMy> vrt = Vector256<TMy>.Zero; // Vector result.
            Vector256<TMy> vrt1 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt2 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt3 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt4 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt5 = Vector256<TMy>.Zero;
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256<TMy> data3 = Unsafe.Add(ref p0, 1);
                Vector256<TMy> vtemp = WVectorTraits256Base.Statics.YGroup3ZipX2(p0, vector1Used, vector2Used, data3, vector4Used, vector5Used, out var vtemp1, out var vtemp2, out var vtemp3, out var vtemp4, out var vtemp5);
                vrt = WVectorTraits256Base.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits256Base.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits256Base.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits256Base.Statics.Add(vrt3, vtemp3);
                vrt4 = WVectorTraits256Base.Statics.Add(vrt4, vtemp4);
                vrt5 = WVectorTraits256Base.Statics.Add(vrt5, vtemp5);
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
            vrt4 = WVectorTraits256Base.Statics.Add(vrt4, vrt5);
            vrt = WVectorTraits256Base.Statics.Add(vrt, vrt2);
            vrt = WVectorTraits256Base.Statics.Add(vrt, vrt4);
            rt = WVectorTraits256Base.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum256X2Base() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn256 = StaticSum256X2Base(srcArray, srcArray.Length);
            CheckResult256("Sum256X2Base");
        }

        /// <summary>
        /// Sum YGroup3ZipX2 - Vector256 - Avx2 - X2.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum256X2Avx2_X2(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> vector1Used = vector1.AsVector256();
            Vector256<TMy> vector2Used = vector2.AsVector256();
            Vector256<TMy> vector4Used = vector1Used;
            Vector256<TMy> vector5Used = vector2Used;
            Vector256<TMy> vrt = Vector256<TMy>.Zero; // Vector result.
            Vector256<TMy> vrt1 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt2 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt3 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt4 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt5 = Vector256<TMy>.Zero;
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256<TMy> data3 = Unsafe.Add(ref p0, 1);
                Vector256<TMy> vtemp = WVectorTraits256Avx2.Statics.YGroup3ZipX2_X2(p0, vector1Used, vector2Used, data3, vector4Used, vector5Used, out var vtemp1, out var vtemp2, out var vtemp3, out var vtemp4, out var vtemp5);
                vrt = WVectorTraits256Avx2.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits256Avx2.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits256Avx2.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits256Avx2.Statics.Add(vrt3, vtemp3);
                vrt4 = WVectorTraits256Avx2.Statics.Add(vrt4, vtemp4);
                vrt5 = WVectorTraits256Avx2.Statics.Add(vrt5, vtemp5);
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
            vrt4 = WVectorTraits256Avx2.Statics.Add(vrt4, vrt5);
            vrt = WVectorTraits256Avx2.Statics.Add(vrt, vrt2);
            vrt = WVectorTraits256Avx2.Statics.Add(vrt, vrt4);
            rt = WVectorTraits256Avx2.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum256X2Avx2_X2() {
            WVectorTraits256Avx2.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn256 = StaticSum256X2Avx2_X2(srcArray, srcArray.Length);
            CheckResult256("Sum256X2Avx2_X2");
        }

        /// <summary>
        /// Sum YGroup3ZipX2 - Vector256 - Avx2 - Unzip.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum256X2Avx2_Unzip(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> vector1Used = vector1.AsVector256();
            Vector256<TMy> vector2Used = vector2.AsVector256();
            Vector256<TMy> vector4Used = vector1Used;
            Vector256<TMy> vector5Used = vector2Used;
            Vector256<TMy> vrt = Vector256<TMy>.Zero; // Vector result.
            Vector256<TMy> vrt1 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt2 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt3 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt4 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt5 = Vector256<TMy>.Zero;
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256<TMy> data3 = Unsafe.Add(ref p0, 1);
                Vector256<TMy> vtemp = WVectorTraits256Avx2.Statics.YGroup3ZipX2_Unzip(p0, vector1Used, vector2Used, data3, vector4Used, vector5Used, out var vtemp1, out var vtemp2, out var vtemp3, out var vtemp4, out var vtemp5);
                vrt = WVectorTraits256Avx2.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits256Avx2.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits256Avx2.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits256Avx2.Statics.Add(vrt3, vtemp3);
                vrt4 = WVectorTraits256Avx2.Statics.Add(vrt4, vtemp4);
                vrt5 = WVectorTraits256Avx2.Statics.Add(vrt5, vtemp5);
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
            vrt4 = WVectorTraits256Avx2.Statics.Add(vrt4, vrt5);
            vrt = WVectorTraits256Avx2.Statics.Add(vrt, vrt2);
            vrt = WVectorTraits256Avx2.Statics.Add(vrt, vrt4);
            rt = WVectorTraits256Avx2.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum256X2Avx2_Unzip() {
            WVectorTraits256Avx2.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn256 = StaticSum256X2Avx2_Unzip(srcArray, srcArray.Length);
            CheckResult256("Sum256X2Avx2_Unzip");
        }

#endif // BENCHMARKS_ALGORITHM
        #endregion // BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum YGroup3ZipX2 - Vector256 - Traits.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum256X2Traits(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> vector1Used = vector1.AsVector256();
            Vector256<TMy> vector2Used = vector2.AsVector256();
            Vector256<TMy> vector4Used = vector1Used;
            Vector256<TMy> vector5Used = vector2Used;
            Vector256<TMy> vrt = Vector256<TMy>.Zero; // Vector result.
            Vector256<TMy> vrt1 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt2 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt3 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt4 = Vector256<TMy>.Zero;
            Vector256<TMy> vrt5 = Vector256<TMy>.Zero;
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256<TMy> data3 = Unsafe.Add(ref p0, 1);
                Vector256<TMy> vtemp = Vector256s.YGroup3ZipX2(p0, vector1Used, vector2Used, data3, vector4Used, vector5Used, out var vtemp1, out var vtemp2, out var vtemp3, out var vtemp4, out var vtemp5);
                vrt = Vector256s.Add(vrt, vtemp);
                vrt1 = Vector256s.Add(vrt1, vtemp1);
                vrt2 = Vector256s.Add(vrt2, vtemp2);
                vrt3 = Vector256s.Add(vrt3, vtemp3);
                vrt4 = Vector256s.Add(vrt4, vtemp4);
                vrt5 = Vector256s.Add(vrt5, vtemp5);
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
            vrt4 = Vector256s.Add(vrt4, vrt5);
            vrt = Vector256s.Add(vrt, vrt2);
            vrt = Vector256s.Add(vrt, vrt4);
            rt = Vector256s.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum256X2Traits() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn256 = StaticSum256X2Traits(srcArray, srcArray.Length);
            CheckResult256("Sum256X2Traits");
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
        /// Sum YGroup3Zip - Vector512 - base - basic.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum512Base_Basic(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector512<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector512<TMy> vector1Used = vector1.AsVector512();
            Vector512<TMy> vector2Used = vector2.AsVector512();
            Vector512<TMy> vrt = Vector512<TMy>.Zero; // Vector result.
            Vector512<TMy> vrt1 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt2 = Vector512<TMy>.Zero;
            int i;
            // Body.
            ref Vector512<TMy> p0 = ref Unsafe.As<TMy, Vector512<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector512<TMy> vtemp = WVectorTraits512Base.Statics.YGroup3Zip_Basic(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
                vrt = WVectorTraits512Base.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits512Base.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits512Base.Statics.Add(vrt2, vtemp2);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector512<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits512Base.Statics.Add(vrt, vrt1);
            vrt = WVectorTraits512Base.Statics.Add(vrt, vrt2);
            rt = WVectorTraits512Base.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum512Base_Basic() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn512 = StaticSum512Base_Basic(srcArray, srcArray.Length);
            if (CheckMode) {
                baselineOn512 = dstOn512;
                BenchmarkUtil.WriteItem("# Sum512Base_Basic", string.Format("{0}", baselineOn512));
            }
        }

        #region BENCHMARKS_ALGORITHM
#if BENCHMARKS_ALGORITHM

#if NET7_0_OR_GREATER

        /// <summary>
        /// Sum YGroup3Zip - Vector512 - base - ByShorter.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum512Base_ByShorter(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector512<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector512<TMy> vector1Used = vector1.AsVector512();
            Vector512<TMy> vector2Used = vector2.AsVector512();
            Vector512<TMy> vrt = Vector512<TMy>.Zero; // Vector result.
            Vector512<TMy> vrt1 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt2 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt3 = Vector512<TMy>.Zero;
            int i;
            // Body.
            ref Vector512<TMy> p0 = ref Unsafe.As<TMy, Vector512<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector512<TMy> vtemp = WVectorTraits512Base.Statics.YGroup3Zip_ByShorter(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
                vrt = WVectorTraits512Base.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits512Base.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits512Base.Statics.Add(vrt2, vtemp2);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector512<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits512Base.Statics.Add(vrt, vrt1);
            vrt = WVectorTraits512Base.Statics.Add(vrt, vrt2);
            rt = WVectorTraits512Base.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum512Base_ByShorter() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn512 = StaticSum512Base_ByShorter(srcArray, srcArray.Length);
            CheckResult512("Sum512Base_ByShorter");
        }

#endif // NET7_0_OR_GREATER

        /// <summary>
        /// Sum YGroup3Zip - Vector512 - base.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum512Base(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector512<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector512<TMy> vector1Used = vector1.AsVector512();
            Vector512<TMy> vector2Used = vector2.AsVector512();
            Vector512<TMy> vrt = Vector512<TMy>.Zero; // Vector result.
            Vector512<TMy> vrt1 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt2 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt3 = Vector512<TMy>.Zero;
            int i;
            // Body.
            ref Vector512<TMy> p0 = ref Unsafe.As<TMy, Vector512<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector512<TMy> vtemp = WVectorTraits512Base.Statics.YGroup3Zip(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
                vrt = WVectorTraits512Base.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits512Base.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits512Base.Statics.Add(vrt2, vtemp2);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector512<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits512Base.Statics.Add(vrt, vrt1);
            vrt = WVectorTraits512Base.Statics.Add(vrt, vrt2);
            rt = WVectorTraits512Base.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum512Base() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn512 = StaticSum512Base(srcArray, srcArray.Length);
            CheckResult512("Sum512Base");
        }

        /// <summary>
        /// Sum YGroup3Zip - Vector512 - Avx512 - ByShorter.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum512Avx512_ByShorter(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector512<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector512<TMy> vector1Used = vector1.AsVector512();
            Vector512<TMy> vector2Used = vector2.AsVector512();
            Vector512<TMy> vrt = Vector512<TMy>.Zero; // Vector result.
            Vector512<TMy> vrt1 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt2 = Vector512<TMy>.Zero;
            int i;
            // Body.
            ref Vector512<TMy> p0 = ref Unsafe.As<TMy, Vector512<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector512<TMy> vtemp = WVectorTraits512Avx512.Statics.YGroup3Zip_ByShorter(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
                vrt = WVectorTraits512Avx512.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits512Avx512.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits512Avx512.Statics.Add(vrt2, vtemp2);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector512<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits512Avx512.Statics.Add(vrt, vrt1);
            vrt = WVectorTraits512Avx512.Statics.Add(vrt, vrt2);
            rt = WVectorTraits512Avx512.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum512Avx512_ByShorter() {
            WVectorTraits512Avx512.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn512 = StaticSum512Avx512_ByShorter(srcArray, srcArray.Length);
            CheckResult512("Sum512Avx512_ByShorter");
        }

        /// <summary>
        /// Sum YGroup3Zip - Vector512 - Avx512 - ByX2Unzip.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum512Avx512_ByX2Unzip(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector512<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector512<TMy> vector1Used = vector1.AsVector512();
            Vector512<TMy> vector2Used = vector2.AsVector512();
            Vector512<TMy> vrt = Vector512<TMy>.Zero; // Vector result.
            Vector512<TMy> vrt1 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt2 = Vector512<TMy>.Zero;
            int i;
            // Body.
            ref Vector512<TMy> p0 = ref Unsafe.As<TMy, Vector512<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector512<TMy> vtemp = WVectorTraits512Avx512.Statics.YGroup3Zip_ByX2Unzip(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
                vrt = WVectorTraits512Avx512.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits512Avx512.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits512Avx512.Statics.Add(vrt2, vtemp2);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector512<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits512Avx512.Statics.Add(vrt, vrt1);
            vrt = WVectorTraits512Avx512.Statics.Add(vrt, vrt2);
            rt = WVectorTraits512Avx512.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum512Avx512_ByX2Unzip() {
            WVectorTraits512Avx512.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn512 = StaticSum512Avx512_ByX2Unzip(srcArray, srcArray.Length);
            CheckResult512("Sum512Avx512_ByX2Unzip");
        }

        /// <summary>
        /// Sum YGroup3Zip - Vector512 - Avx512 - ShuffleX.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum512Avx512_ShuffleX(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector512<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector512<TMy> vector1Used = vector1.AsVector512();
            Vector512<TMy> vector2Used = vector2.AsVector512();
            Vector512<TMy> vrt = Vector512<TMy>.Zero; // Vector result.
            Vector512<TMy> vrt1 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt2 = Vector512<TMy>.Zero;
            int i;
            // Body.
            ref Vector512<TMy> p0 = ref Unsafe.As<TMy, Vector512<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector512<TMy> vtemp = WVectorTraits512Avx512.Statics.YGroup3Zip_ShuffleX(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
                vrt = WVectorTraits512Avx512.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits512Avx512.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits512Avx512.Statics.Add(vrt2, vtemp2);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector512<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits512Avx512.Statics.Add(vrt, vrt1);
            vrt = WVectorTraits512Avx512.Statics.Add(vrt, vrt2);
            rt = WVectorTraits512Avx512.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum512Avx512_ShuffleX() {
            WVectorTraits512Avx512.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn512 = StaticSum512Avx512_ShuffleX(srcArray, srcArray.Length);
            CheckResult512("Sum512Avx512_ShuffleX");
        }

        /// <summary>
        /// Sum YGroup3Zip - Vector512 - Avx512 - ShuffleXImm.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum512Avx512_ShuffleXImm(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector512<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector512<TMy> vector1Used = vector1.AsVector512();
            Vector512<TMy> vector2Used = vector2.AsVector512();
            Vector512<TMy> vrt = Vector512<TMy>.Zero; // Vector result.
            Vector512<TMy> vrt1 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt2 = Vector512<TMy>.Zero;
            int i;
            // Body.
            ref Vector512<TMy> p0 = ref Unsafe.As<TMy, Vector512<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector512<TMy> vtemp = WVectorTraits512Avx512.Statics.YGroup3Zip_ShuffleXImm(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
                vrt = WVectorTraits512Avx512.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits512Avx512.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits512Avx512.Statics.Add(vrt2, vtemp2);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector512<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits512Avx512.Statics.Add(vrt, vrt1);
            vrt = WVectorTraits512Avx512.Statics.Add(vrt, vrt2);
            rt = WVectorTraits512Avx512.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum512Avx512_ShuffleXImm() {
            WVectorTraits512Avx512.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn512 = StaticSum512Avx512_ShuffleXImm(srcArray, srcArray.Length);
            CheckResult512("Sum512Avx512_ShuffleXImm");
        }

#endif // BENCHMARKS_ALGORITHM
        #endregion // BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum YGroup3Zip - Vector512 - Traits.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum512Traits(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector512<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector512<TMy> vector1Used = vector1.AsVector512();
            Vector512<TMy> vector2Used = vector2.AsVector512();
            Vector512<TMy> vrt = Vector512<TMy>.Zero; // Vector result.
            Vector512<TMy> vrt1 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt2 = Vector512<TMy>.Zero;
            int i;
            // Body.
            ref Vector512<TMy> p0 = ref Unsafe.As<TMy, Vector512<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector512<TMy> vtemp = Vector512s.YGroup3Zip(p0, vector1Used, vector2Used, out var vtemp1, out var vtemp2);
                vrt = Vector512s.Add(vrt, vtemp);
                vrt1 = Vector512s.Add(vrt1, vtemp1);
                vrt2 = Vector512s.Add(vrt2, vtemp2);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector512<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = Vector512s.Add(vrt, vrt1);
            vrt = Vector512s.Add(vrt, vrt2);
            rt = Vector512s.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum512Traits() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn512 = StaticSum512Traits(srcArray, srcArray.Length);
            CheckResult512("Sum512Traits");
        }

        /// <summary>
        /// Sum YGroup3ZipX2 - Vector512 - base - basic.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum512X2Base_Basic(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector512<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector512<TMy> vector1Used = vector1.AsVector512();
            Vector512<TMy> vector2Used = vector2.AsVector512();
            Vector512<TMy> vector4Used = vector1Used;
            Vector512<TMy> vector5Used = vector2Used;
            Vector512<TMy> vrt = Vector512<TMy>.Zero; // Vector result.
            Vector512<TMy> vrt1 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt2 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt3 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt4 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt5 = Vector512<TMy>.Zero;
            int i;
            // Body.
            ref Vector512<TMy> p0 = ref Unsafe.As<TMy, Vector512<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector512<TMy> data3 = Unsafe.Add(ref p0, 1);
                Vector512<TMy> vtemp = WVectorTraits512Base.Statics.YGroup3ZipX2_Basic(p0, vector1Used, vector2Used, data3, vector4Used, vector5Used, out var vtemp1, out var vtemp2, out var vtemp3, out var vtemp4, out var vtemp5);
                vrt = WVectorTraits512Base.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits512Base.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits512Base.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits512Base.Statics.Add(vrt3, vtemp3);
                vrt4 = WVectorTraits512Base.Statics.Add(vrt4, vtemp4);
                vrt5 = WVectorTraits512Base.Statics.Add(vrt5, vtemp5);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector512<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits512Base.Statics.Add(vrt, vrt1);
            vrt2 = WVectorTraits512Base.Statics.Add(vrt2, vrt3);
            vrt4 = WVectorTraits512Base.Statics.Add(vrt4, vrt5);
            vrt = WVectorTraits512Base.Statics.Add(vrt, vrt2);
            vrt = WVectorTraits512Base.Statics.Add(vrt, vrt4);
            rt = WVectorTraits512Base.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum512X2Base_Basic() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn512 = StaticSum512X2Base_Basic(srcArray, srcArray.Length);
            if (CheckMode) {
                baselineOn512 = dstOn512;
                BenchmarkUtil.WriteItem("# Sum512X2Base_Basic", string.Format("{0}", baselineOn512));
            }
        }

        #region BENCHMARKS_ALGORITHM
#if BENCHMARKS_ALGORITHM
        /// <summary>
        /// Sum YGroup3ZipX2 - Vector512 - base - X2.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum512X2Base_X2(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector512<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector512<TMy> vector1Used = vector1.AsVector512();
            Vector512<TMy> vector2Used = vector2.AsVector512();
            Vector512<TMy> vector4Used = vector1Used;
            Vector512<TMy> vector5Used = vector2Used;
            Vector512<TMy> vrt = Vector512<TMy>.Zero; // Vector result.
            Vector512<TMy> vrt1 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt2 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt3 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt4 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt5 = Vector512<TMy>.Zero;
            int i;
            // Body.
            ref Vector512<TMy> p0 = ref Unsafe.As<TMy, Vector512<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector512<TMy> data3 = Unsafe.Add(ref p0, 1);
                Vector512<TMy> vtemp = WVectorTraits512Base.Statics.YGroup3ZipX2_X2(p0, vector1Used, vector2Used, data3, vector4Used, vector5Used, out var vtemp1, out var vtemp2, out var vtemp3, out var vtemp4, out var vtemp5);
                vrt = WVectorTraits512Base.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits512Base.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits512Base.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits512Base.Statics.Add(vrt3, vtemp3);
                vrt4 = WVectorTraits512Base.Statics.Add(vrt4, vtemp4);
                vrt5 = WVectorTraits512Base.Statics.Add(vrt5, vtemp5);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector512<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits512Base.Statics.Add(vrt, vrt1);
            vrt2 = WVectorTraits512Base.Statics.Add(vrt2, vrt3);
            vrt4 = WVectorTraits512Base.Statics.Add(vrt4, vrt5);
            vrt = WVectorTraits512Base.Statics.Add(vrt, vrt2);
            vrt = WVectorTraits512Base.Statics.Add(vrt, vrt4);
            rt = WVectorTraits512Base.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum512X2Base_X2() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn512 = StaticSum512X2Base_X2(srcArray, srcArray.Length);
            CheckResult512("Sum512X2Base_X2");
        }

#if NET7_0_OR_GREATER

#endif // NET7_0_OR_GREATER

        /// <summary>
        /// Sum YGroup3ZipX2 - Vector512 - base.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum512X2Base(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector512<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector512<TMy> vector1Used = vector1.AsVector512();
            Vector512<TMy> vector2Used = vector2.AsVector512();
            Vector512<TMy> vector4Used = vector1Used;
            Vector512<TMy> vector5Used = vector2Used;
            Vector512<TMy> vrt = Vector512<TMy>.Zero; // Vector result.
            Vector512<TMy> vrt1 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt2 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt3 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt4 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt5 = Vector512<TMy>.Zero;
            int i;
            // Body.
            ref Vector512<TMy> p0 = ref Unsafe.As<TMy, Vector512<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector512<TMy> data3 = Unsafe.Add(ref p0, 1);
                Vector512<TMy> vtemp = WVectorTraits512Base.Statics.YGroup3ZipX2(p0, vector1Used, vector2Used, data3, vector4Used, vector5Used, out var vtemp1, out var vtemp2, out var vtemp3, out var vtemp4, out var vtemp5);
                vrt = WVectorTraits512Base.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits512Base.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits512Base.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits512Base.Statics.Add(vrt3, vtemp3);
                vrt4 = WVectorTraits512Base.Statics.Add(vrt4, vtemp4);
                vrt5 = WVectorTraits512Base.Statics.Add(vrt5, vtemp5);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector512<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits512Base.Statics.Add(vrt, vrt1);
            vrt2 = WVectorTraits512Base.Statics.Add(vrt2, vrt3);
            vrt4 = WVectorTraits512Base.Statics.Add(vrt4, vrt5);
            vrt = WVectorTraits512Base.Statics.Add(vrt, vrt2);
            vrt = WVectorTraits512Base.Statics.Add(vrt, vrt4);
            rt = WVectorTraits512Base.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum512X2Base() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn512 = StaticSum512X2Base(srcArray, srcArray.Length);
            CheckResult512("Sum512X2Base");
        }

        /// <summary>
        /// Sum YGroup3ZipX2 - Vector512 - Avx512 - X2.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum512X2Avx512_X2(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector512<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector512<TMy> vector1Used = vector1.AsVector512();
            Vector512<TMy> vector2Used = vector2.AsVector512();
            Vector512<TMy> vector4Used = vector1Used;
            Vector512<TMy> vector5Used = vector2Used;
            Vector512<TMy> vrt = Vector512<TMy>.Zero; // Vector result.
            Vector512<TMy> vrt1 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt2 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt3 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt4 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt5 = Vector512<TMy>.Zero;
            int i;
            // Body.
            ref Vector512<TMy> p0 = ref Unsafe.As<TMy, Vector512<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector512<TMy> data3 = Unsafe.Add(ref p0, 1);
                Vector512<TMy> vtemp = WVectorTraits512Avx512.Statics.YGroup3ZipX2_X2(p0, vector1Used, vector2Used, data3, vector4Used, vector5Used, out var vtemp1, out var vtemp2, out var vtemp3, out var vtemp4, out var vtemp5);
                vrt = WVectorTraits512Avx512.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits512Avx512.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits512Avx512.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits512Avx512.Statics.Add(vrt3, vtemp3);
                vrt4 = WVectorTraits512Avx512.Statics.Add(vrt4, vtemp4);
                vrt5 = WVectorTraits512Avx512.Statics.Add(vrt5, vtemp5);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector512<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits512Avx512.Statics.Add(vrt, vrt1);
            vrt2 = WVectorTraits512Avx512.Statics.Add(vrt2, vrt3);
            vrt4 = WVectorTraits512Avx512.Statics.Add(vrt4, vrt5);
            vrt = WVectorTraits512Avx512.Statics.Add(vrt, vrt2);
            vrt = WVectorTraits512Avx512.Statics.Add(vrt, vrt4);
            rt = WVectorTraits512Avx512.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum512X2Avx512_X2() {
            WVectorTraits512Avx512.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn512 = StaticSum512X2Avx512_X2(srcArray, srcArray.Length);
            CheckResult512("Sum512X2Avx512_X2");
        }

        /// <summary>
        /// Sum YGroup3ZipX2 - Vector512 - Avx512 - Unzip.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum512X2Avx512_Unzip(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector512<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector512<TMy> vector1Used = vector1.AsVector512();
            Vector512<TMy> vector2Used = vector2.AsVector512();
            Vector512<TMy> vector4Used = vector1Used;
            Vector512<TMy> vector5Used = vector2Used;
            Vector512<TMy> vrt = Vector512<TMy>.Zero; // Vector result.
            Vector512<TMy> vrt1 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt2 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt3 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt4 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt5 = Vector512<TMy>.Zero;
            int i;
            // Body.
            ref Vector512<TMy> p0 = ref Unsafe.As<TMy, Vector512<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector512<TMy> data3 = Unsafe.Add(ref p0, 1);
                Vector512<TMy> vtemp = WVectorTraits512Avx512.Statics.YGroup3ZipX2_Unzip(p0, vector1Used, vector2Used, data3, vector4Used, vector5Used, out var vtemp1, out var vtemp2, out var vtemp3, out var vtemp4, out var vtemp5);
                vrt = WVectorTraits512Avx512.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits512Avx512.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits512Avx512.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits512Avx512.Statics.Add(vrt3, vtemp3);
                vrt4 = WVectorTraits512Avx512.Statics.Add(vrt4, vtemp4);
                vrt5 = WVectorTraits512Avx512.Statics.Add(vrt5, vtemp5);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector512<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = WVectorTraits512Avx512.Statics.Add(vrt, vrt1);
            vrt2 = WVectorTraits512Avx512.Statics.Add(vrt2, vrt3);
            vrt4 = WVectorTraits512Avx512.Statics.Add(vrt4, vrt5);
            vrt = WVectorTraits512Avx512.Statics.Add(vrt, vrt2);
            vrt = WVectorTraits512Avx512.Statics.Add(vrt, vrt4);
            rt = WVectorTraits512Avx512.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum512X2Avx512_Unzip() {
            WVectorTraits512Avx512.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn512 = StaticSum512X2Avx512_Unzip(srcArray, srcArray.Length);
            CheckResult512("Sum512X2Avx512_Unzip");
        }

#endif // BENCHMARKS_ALGORITHM
        #endregion // BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum YGroup3ZipX2 - Vector512 - Traits.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum512X2Traits(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 2;
            int VectorWidth = Vector512<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth * GroupSize; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector512<TMy> vector1Used = vector1.AsVector512();
            Vector512<TMy> vector2Used = vector2.AsVector512();
            Vector512<TMy> vector4Used = vector1Used;
            Vector512<TMy> vector5Used = vector2Used;
            Vector512<TMy> vrt = Vector512<TMy>.Zero; // Vector result.
            Vector512<TMy> vrt1 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt2 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt3 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt4 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt5 = Vector512<TMy>.Zero;
            int i;
            // Body.
            ref Vector512<TMy> p0 = ref Unsafe.As<TMy, Vector512<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector512<TMy> data3 = Unsafe.Add(ref p0, 1);
                Vector512<TMy> vtemp = Vector512s.YGroup3ZipX2(p0, vector1Used, vector2Used, data3, vector4Used, vector5Used, out var vtemp1, out var vtemp2, out var vtemp3, out var vtemp4, out var vtemp5);
                vrt = Vector512s.Add(vrt, vtemp);
                vrt1 = Vector512s.Add(vrt1, vtemp1);
                vrt2 = Vector512s.Add(vrt2, vtemp2);
                vrt3 = Vector512s.Add(vrt3, vtemp3);
                vrt4 = Vector512s.Add(vrt4, vtemp4);
                vrt5 = Vector512s.Add(vrt5, vtemp5);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector512<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            vrt = Vector512s.Add(vrt, vrt1);
            vrt2 = Vector512s.Add(vrt2, vrt3);
            vrt4 = Vector512s.Add(vrt4, vrt5);
            vrt = Vector512s.Add(vrt, vrt2);
            vrt = Vector512s.Add(vrt, vrt4);
            rt = Vector512s.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum512X2Traits() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn512 = StaticSum512X2Traits(srcArray, srcArray.Length);
            CheckResult512("Sum512X2Traits");
        }

#endif // BENCHMARKS_512 && NET8_0_OR_GREATER
        #endregion // BENCHMARKS_512

    }
}
