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

namespace Zyl.VectorTraits.Benchmarks.AVector.S {
#if BENCHMARKS_OFF
    using BenchmarkAttribute = FakeBenchmarkAttribute;
#else
#endif // BENCHMARKS_OFF

    // My type.
    using TMy = UInt32;

    /// <summary>
    /// Shift right logical benchmark - UInt32.
    /// </summary>
#if NETCOREAPP3_0_OR_GREATER && DRY_JOB
    [DryJob]
#endif // NETCOREAPP3_0_OR_GREATER && DRY_JOB
    public partial class ShiftRightLogicalConstBenchmark_UInt32 : AbstractSharedBenchmark_UInt32 {

        // -- var --
        private const int shiftAmount = 1;

        /// <summary>
        /// Sum shift right logical - base.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        public static TMy StaticSumSRLScalar(TMy[] src, int srcCount, int shiftAmount) {
            TMy rt = 0; // Result.
            for (int i = 0; i < srcCount; ++i) {
                rt += (TMy)(src[i] >> shiftAmount);
            }
            return rt;
        }

        [Benchmark(Baseline = true)]
        public void SumSRLScalar() {
            dstTMy = StaticSumSRLScalar(srcArray, srcArray.Length, shiftAmount);
            if (CheckMode) {
                baselineTMy = dstTMy;
                BenchmarkUtil.WriteItem("# SumSRLScalar", string.Format("{0}", baselineTMy));
            }
        }

#if NET7_0_OR_GREATER
        /// <summary>
        /// Sum shift right logical - VectorT - .NET Bcl - variate .
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumSRLNetBcl(TMy[] src, int srcCount, int shiftAmount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            int shiftAmount2 = Volatile.Read(ref shiftAmount);
            ref Vector<TMy> p0 = ref Unsafe.As<TMy, Vector<TMy>>(ref src[0]);
            // Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector<TMy> vtemp = Vector.ShiftRightLogical(p0, shiftAmount2);
                vrt += vtemp; // Add.
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // Remainder processs.
            ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMy)(Unsafe.Add(ref p, i) >> shiftAmount2);
            }
            // Reduce.
            rt += Vectors.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void SumSRLNetBcl() {
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSumSRLNetBcl(srcArray, srcArray.Length, shiftAmount);
            CheckResult("SumSRLNetBcl");
        }
        /// <summary>
        /// Sum shift right logical - VectorT - .NET Bcl - Const.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static TMy StaticSumSRLNetBcl_Const(TMy[] src, int srcCount) {
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
            // Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector<TMy> vtemp = Vector.ShiftRightLogical(p0, shiftAmount);
                vrt += vtemp; // Add.
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // Remainder processs.
            ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMy)(Unsafe.Add(ref p, i) >> shiftAmount);
            }
            // Reduce.
            rt += Vectors.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void SumSRLNetBcl_Const() {
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSumSRLNetBcl_Const(srcArray, srcArray.Length);
            CheckResult("SumSRLNetBcl_Const");
        }


#endif // NET7_0_OR_GREATER

        #region BENCHMARKS_ALGORITHM
#if BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum shift right logical - Base.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumSRL_Basic(TMy[] src, int srcCount, int shiftAmount) {
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
            // Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector<TMy> vtemp = VectorTraitsBase.Statics.ShiftRightLogical(p0, shiftAmount);
                vrt += vtemp; // Add.
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // Remainder processs.
            ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMy)(Unsafe.Add(ref p, i) >> shiftAmount);
            }
            // Reduce.
            rt += Vectors.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void SumSRL_Basic() {
            VectorTraitsBase.Statics.ThrowForUnsupported(true);
            dstTMy = StaticSumSRL_Basic(srcArray, srcArray.Length, shiftAmount);
            CheckResult("SumSRL_Base");
        }

        /// <summary>
        /// Sum shift right logical - Base - Core.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumSRL_Base_Core(TMy[] src, int srcCount, int shiftAmount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            var args0 = VectorTraitsBase.Statics.ShiftRightLogical_Args(vrt, shiftAmount, out var args1);
            ref Vector<TMy> p0 = ref Unsafe.As<TMy, Vector<TMy>>(ref src[0]);
            // Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector<TMy> vtemp = VectorTraitsBase.Statics.ShiftRightLogical_Core(p0, shiftAmount, args0, args1);
                vrt += vtemp; // Add.
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // Remainder processs.
            ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMy)(Unsafe.Add(ref p, i) >> shiftAmount);
            }
            // Reduce.
            rt += Vectors.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void SumSRL_Base_Core() {
            VectorTraitsBase.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSumSRL_Base_Core(srcArray, srcArray.Length, shiftAmount);
            CheckResult("SumSRL_Base_Core");
        }

#if NET5_0_OR_GREATER
        /// <summary>
        /// Sum shift right logical - Raw - AdvSimd.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumSRL_AdvSimd(TMy[] src, int srcCount, int shiftAmount) {
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
            // Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector<TMy> vtemp = VectorTraits128AdvSimd.Statics.ShiftRightLogical(p0, shiftAmount);
                vrt += vtemp; // Add.
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // Remainder processs.
            ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMy)(Unsafe.Add(ref p, i) >> shiftAmount);
            }
            // Reduce.
            rt += Vectors.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void SumSRL_AdvSimd() {
            VectorTraits128AdvSimd.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSumSRL_AdvSimd(srcArray, srcArray.Length, shiftAmount);
            CheckResult("SumSRL_AdvSimd");
        }
#endif // NET5_0_OR_GREATER

#if NETCOREAPP3_0_OR_GREATER
        /// <summary>
        /// Sum shift right logical - Raw - Avx.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumSRL_Avx2(TMy[] src, int srcCount, int shiftAmount) {
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
            // Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector<TMy> vtemp = VectorTraits256Avx2.Statics.ShiftRightLogical(p0, shiftAmount);
                vrt += vtemp; // Add.
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // Remainder processs.
            ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMy)(Unsafe.Add(ref p, i) >> shiftAmount);
            }
            // Reduce.
            rt += Vectors.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void SumSRL_Avx2() {
            VectorTraits256Avx2.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSumSRL_Avx2(srcArray, srcArray.Length, shiftAmount);
            CheckResult("SumSRL_Avx2");
        }
#endif // NETCOREAPP3_0_OR_GREATER

#endif // BENCHMARKS_ALGORITHM
        #endregion // BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum shift right logical - Traits static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumSRLTraits(TMy[] src, int srcCount, int shiftAmount) {
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
            // Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector<TMy> vtemp = Vectors.ShiftRightLogical(p0, shiftAmount);
                vrt += vtemp; // Add.
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // Remainder processs.
            ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMy)(Unsafe.Add(ref p, i) >> shiftAmount);
            }
            // Reduce.
            rt += Vectors.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void SumSRLTraits() {
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSumSRLTraits(srcArray, srcArray.Length, shiftAmount);
            CheckResult("SumSRLTraits");
        }

        /// <summary>
        /// Sum shift right logical - Traits static - Core.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumSRLTraits_Core(TMy[] src, int srcCount, int shiftAmount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            var args0 = Vectors.ShiftRightLogical_Args(vrt, shiftAmount, out var args1);
            ref Vector<TMy> p0 = ref Unsafe.As<TMy, Vector<TMy>>(ref src[0]);
            // Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector<TMy> vtemp = Vectors.ShiftRightLogical_Core(p0, shiftAmount, args0, args1);
                vrt += vtemp; // Add.
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // Remainder processs.
            ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMy)(Unsafe.Add(ref p, i) >> shiftAmount);
            }
            // Reduce.
            rt += Vectors.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void SumSRLTraits_Core() {
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSumSRLTraits_Core(srcArray, srcArray.Length, shiftAmount);
            CheckResult("SumSRLTraits_Core");
        }

        /// <summary>
        /// Sum shift right logical const - Traits static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumSRLConstTraits(TMy[] src, int srcCount) {
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
            // Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector<TMy> vtemp = Vectors.ShiftRightLogical_Const(p0, shiftAmount);
                vrt += vtemp; // Add.
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // Remainder processs.
            ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMy)(Unsafe.Add(ref p, i) >> shiftAmount);
            }
            // Reduce.
            rt += Vectors.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void SumSRLConstTraits() {
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSumSRLConstTraits(srcArray, srcArray.Length);
            CheckResult("SumSRLConstTraits");
        }

        /// <summary>
        /// Sum shift right logical - Traits static - ConstCore.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumSRLConstTraits_Core(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            var args0 = Vectors.ShiftRightLogical_Args(vrt, shiftAmount, out var args1);
            ref Vector<TMy> p0 = ref Unsafe.As<TMy, Vector<TMy>>(ref src[0]);
            // Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector<TMy> vtemp = Vectors.ShiftRightLogical_ConstCore(p0, shiftAmount, args0, args1);
                vrt += vtemp; // Add.
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // Remainder processs.
            ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMy)(Unsafe.Add(ref p, i) >> shiftAmount);
            }
            // Reduce.
            rt += Vectors.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void SumSRLConstTraits_Core() {
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSumSRLConstTraits_Core(srcArray, srcArray.Length);
            CheckResult("SumSRLConstTraits_Core");
        }

#if NETCOREAPP3_0_OR_GREATER

        /// <summary>
        /// Sum shift right logical - Traits static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumSRL128Traits(TMy[] src, int srcCount, int shiftAmount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector128 result.
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector128<TMy> vtemp = Vector128s.ShiftRightLogical(p0, shiftAmount);
                vrt = Vector128s.Add(vrt, vtemp); // Add.
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // Remainder processs.
            ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMy)(Unsafe.Add(ref p, i) << shiftAmount);
            }
            // Reduce.
            rt += Vector128s.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void SumSRL128Traits() {
            Vector128s.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSumSRL128Traits(srcArray, srcArray.Length, shiftAmount);
            CheckResult("SumSRL128Traits");
        }

        /// <summary>
        /// Sum shift right logical - Traits static - Core.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumSRL128Traits_Core(TMy[] src, int srcCount, int shiftAmount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector128 result.
            int i;
            // Body.
            var args0 = Vector128s.ShiftRightLogical_Args(vrt, shiftAmount, out var args1);
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector128<TMy> vtemp = Vector128s.ShiftRightLogical_Core(p0, shiftAmount, args0, args1);
                vrt = Vector128s.Add(vrt, vtemp); // Add.
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // Remainder processs.
            ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMy)(Unsafe.Add(ref p, i) << shiftAmount);
            }
            // Reduce.
            rt += Vector128s.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void SumSRL128Traits_Core() {
            Vector128s.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSumSRL128Traits_Core(srcArray, srcArray.Length, shiftAmount);
            CheckResult("SumSRL128Traits_Core");
        }

        /// <summary>
        /// Sum shift right logical const - Traits static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumSRL128ConstTraits(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector128 result.
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector128<TMy> vtemp = Vector128s.ShiftRightLogical_Const(p0, shiftAmount);
                vrt = Vector128s.Add(vrt, vtemp); // Add.
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // Remainder processs.
            ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMy)(Unsafe.Add(ref p, i) << shiftAmount);
            }
            // Reduce.
            rt += Vector128s.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void SumSRL128ConstTraits() {
            Vector128s.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSumSRL128ConstTraits(srcArray, srcArray.Length);
            CheckResult("SumSRL128ConstTraits");
        }

        /// <summary>
        /// Sum shift right logical - Traits static - ConstCore.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumSRL128ConstTraits_Core(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector128 result.
            int i;
            // Body.
            var args0 = Vector128s.ShiftRightLogical_Args(vrt, shiftAmount, out var args1);
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector128<TMy> vtemp = Vector128s.ShiftRightLogical_ConstCore(p0, shiftAmount, args0, args1);
                vrt = Vector128s.Add(vrt, vtemp); // Add.
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // Remainder processs.
            ref TMy p = ref Unsafe.As<Vector128<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMy)(Unsafe.Add(ref p, i) << shiftAmount);
            }
            // Reduce.
            rt += Vector128s.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void SumSRL128ConstTraits_Core() {
            Vector128s.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSumSRL128ConstTraits_Core(srcArray, srcArray.Length);
            CheckResult("SumSRL128ConstTraits_Core");
        }

#endif

        #region BENCHMARKS_ALGORITHM
#if BENCHMARKS_ALGORITHM

#if NET5_0_OR_GREATER
        /// <summary>
        /// Sum shift right logical fast - Raw - AdvSimd.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumSRLFast_AdvSimd(TMy[] src, int srcCount, int shiftAmount) {
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
            // Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector<TMy> vtemp = VectorTraits128AdvSimd.Statics.ShiftRightLogical_Fast(p0, shiftAmount);
                vrt += vtemp; // Add.
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // Remainder processs.
            ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMy)(Unsafe.Add(ref p, i) >> shiftAmount);
            }
            // Reduce.
            rt += Vectors.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void SumSRLFast_AdvSimd() {
            VectorTraits128AdvSimd.Statics.ThrowForUnsupported(true);
            //Debugger.Break();
            dstTMy = StaticSumSRLFast_AdvSimd(srcArray, srcArray.Length, shiftAmount);
            CheckResult("SumSRLFast_AdvSimd");
        }
#endif // NET5_0_OR_GREATER

#if NETCOREAPP3_0_OR_GREATER
        /// <summary>
        /// Sum shift right logical fast - Raw - Avx.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumSRLFast_Avx2(TMy[] src, int srcCount, int shiftAmount) {
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
            // Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector<TMy> vtemp = VectorTraits256Avx2.Statics.ShiftRightLogical_Fast(p0, shiftAmount);
                vrt += vtemp; // Add.
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // Remainder processs.
            ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMy)(Unsafe.Add(ref p, i) >> shiftAmount);
            }
            // Reduce.
            rt += Vectors.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void SumSRLFast_Avx2() {
            VectorTraits256Avx2.Statics.ThrowForUnsupported(true);
            //Debugger.Break();
            dstTMy = StaticSumSRLFast_Avx2(srcArray, srcArray.Length, shiftAmount);
            CheckResult("SumSRLFast_Avx2");
        }

#endif // NETCOREAPP3_0_OR_GREATER

#endif // BENCHMARKS_ALGORITHM
        #endregion // BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum shift right logical fast - Traits static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumSRLFastTraits(TMy[] src, int srcCount, int shiftAmount) {
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
            // Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector<TMy> vtemp = Vectors.ShiftRightLogical_Fast(p0, shiftAmount);
                vrt += vtemp; // Add.
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // Remainder processs.
            ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMy)(Unsafe.Add(ref p, i) >> shiftAmount);
            }
            // Reduce.
            rt += Vectors.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void SumSRLFastTraits() {
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSumSRLFastTraits(srcArray, srcArray.Length, shiftAmount);
            CheckResult("SumSRLFastTraits");
        }

    }
}
