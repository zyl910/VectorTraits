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
using Zyl.VectorTraits.Impl;
using Zyl.VectorTraits.Impl.AVector;
using Zyl.VectorTraits.Impl.AVector128;
using Zyl.VectorTraits.Impl.AVector256;

namespace Zyl.VectorTraits.Benchmarks.AVector.C {
#if BENCHMARKS_OFF
    using BenchmarkAttribute = FakeBenchmarkAttribute;
#else
#endif // BENCHMARKS_OFF

    // My type.
    using TMy = Single;
    using TMyOut = UInt32;

#pragma warning disable CS0618 // Type or member is obsolete
    /// <summary>
    /// ConvertToUInt32 benchmark - Single.
    /// </summary>
#if NETCOREAPP3_0_OR_GREATER && DRY_JOB
    [DryJob]
#endif // NETCOREAPP3_0_OR_GREATER && DRY_JOB
    public partial class ConvertToUInt32Benchmark_Single : AbstractSharedBenchmark {

        // -- TMy ref --
        protected static ref TMyOut dstTMy => ref dstUInt32;
        protected static ref TMyOut baselineTMy => ref baselineUInt32;
        protected static TMy[] srcArray => srcArraySingle_RangeUInt32;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected override void CheckResult(string name) {
            CheckResultUInt32(name);
        }

        // -- var --

        /// <summary>
        /// Sum ConvertToUInt32 - Scalar.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        public static TMyOut StaticSumScalar(TMy[] src, int srcCount) {
            TMyOut rt = 0; // Result.
            for (int i = 0; i < srcCount; ++i) {
                rt += (TMyOut)src[i];
            }
            return rt;
        }

        [Benchmark(Baseline = true)]
        public void SumScalar() {
            dstTMy = StaticSumScalar(srcArray, srcArray.Length);
            if (CheckMode) {
                baselineTMy = dstTMy;
                BenchmarkUtil.WriteItem("# SumScalar", string.Format("{0}", baselineTMy));
            }
        }

        /// <summary>
        /// Sum ConvertToUInt32 - BCL.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        public static TMyOut StaticSumBcl(TMy[] src, int srcCount) {
            TMyOut rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMyOut> vrt = Vector<TMyOut>.Zero; // Vector result.
            Vector<TMyOut> vtemp;
            int i;
            // Body.
            ref Vector<TMy> p0 = ref Unsafe.As<TMy, Vector<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                vtemp = Vector.ConvertToUInt32(p0);
                vrt += vtemp;
                //if (BenchmarkUtil.IsLastRun && i < 3) {
                //    VectorTextUtil.WriteLine(Console.Out, "SumBcl[{0}]: {1}, {2}", i, p0, vtemp);
                //}
                p0 = ref Unsafe.Add(ref p0, 1);
            }
            // b) Remainder processs.
            ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMyOut)Unsafe.Add(ref p, i);
            }
            // Reduce.
            rt += Vectors.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void SumBcl() {
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSumBcl(srcArray, srcArray.Length);
            CheckResult("SumBcl");
            //if (CheckMode) {
            //    baselineTMy = dstTMy;
            //    BenchmarkUtil.WriteItem("# SumBcl", string.Format("{0}", baselineTMy));
            //}
        }

        #region BENCHMARKS_ALGORITHM
#if BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum ConvertToUInt32 - Base.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        public static TMyOut StaticSumBase(TMy[] src, int srcCount) {
            TMyOut rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMyOut> vrt = Vector<TMyOut>.Zero; // Vector result.
            Vector<TMyOut> vtemp;
            int i;
            // Body.
            ref Vector<TMy> p0 = ref Unsafe.As<TMy, Vector<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                vtemp = VectorTraitsBase.Statics.ConvertToUInt32(p0);
                vrt += vtemp;
                p0 = ref Unsafe.Add(ref p0, 1);
            }
            // b) Remainder processs.
            ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMyOut)Unsafe.Add(ref p, i);
            }
            // Reduce.
            rt += Vectors.Sum(vrt);
            return rt;
        }

        // [Benchmark] // Same as SumBcl
        public void SumBase() {
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSumBase(srcArray, srcArray.Length);
            CheckResult("SumBase");
        }

#endif // BENCHMARKS_ALGORITHM
        #endregion // BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum ConvertToUInt32 - Traits static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        public static TMyOut StaticSumTraits(TMy[] src, int srcCount) {
            TMyOut rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMyOut> vrt = Vector<TMyOut>.Zero; // Vector result.
            Vector<TMyOut> vtemp;
            int i;
            // Body.
            ref Vector<TMy> p0 = ref Unsafe.As<TMy, Vector<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                vtemp = Vectors.ConvertToUInt32(p0);
                vrt += vtemp;
                p0 = ref Unsafe.Add(ref p0, 1);
            }
            // b) Remainder processs.
            ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMyOut)Unsafe.Add(ref p, i);
            }
            // Reduce.
            rt += Vectors.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void SumTraits() {
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSumTraits(srcArray, srcArray.Length);
            CheckResult("SumTraits");
        }


        #region BENCHMARKS_128
#if BENCHMARKS_128 && NETCOREAPP3_0_OR_GREATER

#if NET7_0_OR_GREATER
        /// <summary>
        /// Sum ConvertToUInt32 - 128 - BCL.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        public static TMyOut StaticSum128Bcl(TMy[] src, int srcCount) {
            TMyOut rt = 0; // Result.
            int Vector128Width = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = Vector128Width; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMyOut> vrt = Vector128<TMyOut>.Zero; // Vector result.
            Vector128<TMyOut> vtemp;
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                vtemp = Vector128.ConvertToUInt32(p0);
                vrt = Vector128s.Add(vrt, vtemp);
                p0 = ref Unsafe.Add(ref p0, 1);
            }
            // b) Remainder processs.
            ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMyOut)Unsafe.Add(ref p, i);
            }
            // Reduce.
            rt += Vector128s.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum128Bcl() {
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSum128Bcl(srcArray, srcArray.Length);
            CheckResult("Sum128Bcl");
        }
#endif // NET7_0_OR_GREATER

        #region BENCHMARKS_ALGORITHM
#if BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum ConvertToUInt32 - 128 - Base - Basic.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        public static TMyOut StaticSum128Base_Basic(TMy[] src, int srcCount) {
            TMyOut rt = 0; // Result.
            int Vector128Width = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = Vector128Width; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMyOut> vrt = Vector128<TMyOut>.Zero; // Vector result.
            Vector128<TMyOut> vtemp;
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                vtemp = WVectorTraits128Base.Statics.ConvertToUInt32_Basic(p0);
                vrt = Vector128s.Add(vrt, vtemp);
                p0 = ref Unsafe.Add(ref p0, 1);
            }
            // b) Remainder processs.
            ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMyOut)Unsafe.Add(ref p, i);
            }
            // Reduce.
            rt += Vector128s.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum128Base_Basic() {
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSum128Base_Basic(srcArray, srcArray.Length);
            CheckResult("Sum128Base_Basic");
        }

        /// <summary>
        /// Sum ConvertToUInt32 - 128 - Base.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        public static TMyOut StaticSum128Base(TMy[] src, int srcCount) {
            TMyOut rt = 0; // Result.
            int Vector128Width = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = Vector128Width; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMyOut> vrt = Vector128<TMyOut>.Zero; // Vector result.
            Vector128<TMyOut> vtemp;
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                vtemp = WVectorTraits128Base.Statics.ConvertToUInt32(p0);
                vrt = Vector128s.Add(vrt, vtemp);
                p0 = ref Unsafe.Add(ref p0, 1);
            }
            // b) Remainder processs.
            ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMyOut)Unsafe.Add(ref p, i);
            }
            // Reduce.
            rt += Vector128s.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum128Base() {
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSum128Base(srcArray, srcArray.Length);
            CheckResult("Sum128Base");
        }

#endif // BENCHMARKS_ALGORITHM
        #endregion // BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum ConvertToUInt32 - 128 - Traits static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        public static TMyOut StaticSum128Traits(TMy[] src, int srcCount) {
            TMyOut rt = 0; // Result.
            int Vector128Width = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = Vector128Width; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMyOut> vrt = Vector128<TMyOut>.Zero; // Vector result.
            Vector128<TMyOut> vtemp;
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                vtemp = Vector128s.ConvertToUInt32(p0);
                vrt = Vector128s.Add(vrt, vtemp);
                p0 = ref Unsafe.Add(ref p0, 1);
            }
            // b) Remainder processs.
            ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMyOut)Unsafe.Add(ref p, i);
            }
            // Reduce.
            rt += Vector128s.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum128Traits() {
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSum128Traits(srcArray, srcArray.Length);
            CheckResult("Sum128Traits");
        }

#endif // BENCHMARKS_128 && NETCOREAPP3_0_OR_GREATER
        #endregion // BENCHMARKS_128


        #region BENCHMARKS_256
#if BENCHMARKS_256 && NETCOREAPP3_0_OR_GREATER

#if NET7_0_OR_GREATER
        /// <summary>
        /// Sum ConvertToUInt32 - 256 - BCL.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        public static TMyOut StaticSum256Bcl(TMy[] src, int srcCount) {
            TMyOut rt = 0; // Result.
            int Vector256Width = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = Vector256Width; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMyOut> vrt = Vector256<TMyOut>.Zero; // Vector result.
            Vector256<TMyOut> vtemp;
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                vtemp = Vector256.ConvertToUInt32(p0);
                vrt = Vector256s.Add(vrt, vtemp);
                p0 = ref Unsafe.Add(ref p0, 1);
            }
            // b) Remainder processs.
            ref TMy p = ref Unsafe.As<Vector256<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMyOut)Unsafe.Add(ref p, i);
            }
            // Reduce.
            rt += Vector256s.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum256Bcl() {
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSum256Bcl(srcArray, srcArray.Length);
            CheckResult("Sum256Bcl");
        }
#endif // NET7_0_OR_GREATER

        #region BENCHMARKS_ALGORITHM
#if BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum ConvertToUInt32 - 256 - Base - Basic.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        public static TMyOut StaticSum256Base_Basic(TMy[] src, int srcCount) {
            TMyOut rt = 0; // Result.
            int Vector256Width = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = Vector256Width; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMyOut> vrt = Vector256<TMyOut>.Zero; // Vector result.
            Vector256<TMyOut> vtemp;
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                vtemp = WVectorTraits256Base.Statics.ConvertToUInt32_Basic(p0);
                vrt = Vector256s.Add(vrt, vtemp);
                p0 = ref Unsafe.Add(ref p0, 1);
            }
            // b) Remainder processs.
            ref TMy p = ref Unsafe.As<Vector256<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMyOut)Unsafe.Add(ref p, i);
            }
            // Reduce.
            rt += Vector256s.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum256Base_Basic() {
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSum256Base_Basic(srcArray, srcArray.Length);
            CheckResult("Sum256Base_Basic");
        }

        /// <summary>
        /// Sum ConvertToUInt32 - 256 - Base.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        public static TMyOut StaticSum256Base(TMy[] src, int srcCount) {
            TMyOut rt = 0; // Result.
            int Vector256Width = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = Vector256Width; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMyOut> vrt = Vector256<TMyOut>.Zero; // Vector result.
            Vector256<TMyOut> vtemp;
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                vtemp = WVectorTraits256Base.Statics.ConvertToUInt32(p0);
                vrt = Vector256s.Add(vrt, vtemp);
                p0 = ref Unsafe.Add(ref p0, 1);
            }
            // b) Remainder processs.
            ref TMy p = ref Unsafe.As<Vector256<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMyOut)Unsafe.Add(ref p, i);
            }
            // Reduce.
            rt += Vector256s.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum256Base() {
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSum256Base(srcArray, srcArray.Length);
            CheckResult("Sum256Base");
        }

        /// <summary>
        /// Sum ConvertToUInt32 - 256 - Avx2 - Mapping.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        public static TMyOut StaticSum256Avx2_Mapping(TMy[] src, int srcCount) {
            TMyOut rt = 0; // Result.
            int Vector256Width = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = Vector256Width; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMyOut> vrt = Vector256<TMyOut>.Zero; // Vector result.
            Vector256<TMyOut> vtemp;
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                vtemp = WVectorTraits256Avx2.Statics.ConvertToUInt32_Mapping(p0);
                vrt = Vector256s.Add(vrt, vtemp);
                p0 = ref Unsafe.Add(ref p0, 1);
            }
            // b) Remainder processs.
            ref TMy p = ref Unsafe.As<Vector256<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMyOut)Unsafe.Add(ref p, i);
            }
            // Reduce.
            rt += Vector256s.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum256Avx2_Mapping() {
            WVectorTraits256Avx2.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSum256Avx2_Mapping(srcArray, srcArray.Length);
            CheckResult("Sum256Avx2_Mapping");
        }

        /// <summary>
        /// Sum ConvertToUInt32 - 256 - Avx2 - MappingFix.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        public static TMyOut StaticSum256Avx2_MappingFix(TMy[] src, int srcCount) {
            TMyOut rt = 0; // Result.
            int Vector256Width = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = Vector256Width; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMyOut> vrt = Vector256<TMyOut>.Zero; // Vector result.
            Vector256<TMyOut> vtemp;
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                vtemp = WVectorTraits256Avx2.Statics.ConvertToUInt32_MappingFix(p0);
                vrt = Vector256s.Add(vrt, vtemp);
                p0 = ref Unsafe.Add(ref p0, 1);
            }
            // b) Remainder processs.
            ref TMy p = ref Unsafe.As<Vector256<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMyOut)Unsafe.Add(ref p, i);
            }
            // Reduce.
            rt += Vector256s.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum256Avx2_MappingFix() {
            WVectorTraits256Avx2.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSum256Avx2_MappingFix(srcArray, srcArray.Length);
            CheckResult("Sum256Avx2_MappingFix");
        }

        /// <summary>
        /// Sum ConvertToUInt32 - 256 - Avx2 - Mod.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        public static TMyOut StaticSum256Avx2_Mod(TMy[] src, int srcCount) {
            TMyOut rt = 0; // Result.
            int Vector256Width = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = Vector256Width; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMyOut> vrt = Vector256<TMyOut>.Zero; // Vector result.
            Vector256<TMyOut> vtemp;
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                vtemp = WVectorTraits256Avx2.Statics.ConvertToUInt32_Mod(p0);
                vrt = Vector256s.Add(vrt, vtemp);
                p0 = ref Unsafe.Add(ref p0, 1);
            }
            // b) Remainder processs.
            ref TMy p = ref Unsafe.As<Vector256<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMyOut)Unsafe.Add(ref p, i);
            }
            // Reduce.
            rt += Vector256s.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum256Avx2_Mod() {
            WVectorTraits256Avx2.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSum256Avx2_Mod(srcArray, srcArray.Length);
            CheckResult("Sum256Avx2_Mod");
        }

#endif // BENCHMARKS_ALGORITHM
        #endregion // BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum ConvertToUInt32 - 256 - Traits static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        public static TMyOut StaticSum256Traits(TMy[] src, int srcCount) {
            TMyOut rt = 0; // Result.
            int Vector256Width = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = Vector256Width; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMyOut> vrt = Vector256<TMyOut>.Zero; // Vector result.
            Vector256<TMyOut> vtemp;
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                vtemp = Vector256s.ConvertToUInt32(p0);
                vrt = Vector256s.Add(vrt, vtemp);
                p0 = ref Unsafe.Add(ref p0, 1);
            }
            // b) Remainder processs.
            ref TMy p = ref Unsafe.As<Vector256<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMyOut)Unsafe.Add(ref p, i);
            }
            // Reduce.
            rt += Vector256s.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum256Traits() {
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSum256Traits(srcArray, srcArray.Length);
            CheckResult("Sum256Traits");
        }

#endif // BENCHMARKS_256 && NETCOREAPP3_0_OR_GREATER
        #endregion // BENCHMARKS_256


    }

}
