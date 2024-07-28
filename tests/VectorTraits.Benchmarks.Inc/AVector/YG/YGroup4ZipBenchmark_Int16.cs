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
    using TMy = Int16;

    /// <summary>
    /// YGroup4Zip benchmark - Int16.
    /// </summary>
#if NETCOREAPP3_0_OR_GREATER && DRY_JOB
    [DryJob]
#endif // NETCOREAPP3_0_OR_GREATER && DRY_JOB
    public partial class YGroup4ZipBenchmark_Int16 : AbstractSharedBenchmark_Int16 {

        // -- var --
        private static readonly Vector<TMy> vector1 = Vectors<TMy>.SerialNegative;
        private static readonly Vector<TMy> vector2 = Vectors<TMy>.SerialDesc;
        private static readonly Vector<TMy> vector3 = Vectors<TMy>.Serial;


        #region BENCHMARKS_128
#if BENCHMARKS_128 && NETCOREAPP3_0_OR_GREATER

        protected TMy dstOn128 = default, baselineOn128 = default;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected virtual void CheckResult128(string name) {
            CheckResult_Report(name, dstOn128 != baselineOn128, dstOn128, baselineOn128);
        }

        #region BENCHMARKS_ALGORITHM
#if BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum YGroup4Zip - Vector128 - base - basic.
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
            Vector128<TMy> vector3Used = vector3.AsVector128();
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector128 result.
            Vector128<TMy> vrt1 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt2 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt3 = Vector128<TMy>.Zero;
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector128 processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector128<TMy> vtemp = WVectorTraits128Base.Statics.YGroup4Zip_Basic(p0, vector1Used, vector2Used, vector3Used, out var vtemp1, out var vtemp2, out var vtemp3);
                vrt = WVectorTraits128Base.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits128Base.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits128Base.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits128Base.Statics.Add(vrt3, vtemp3);
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

#if VECTOR_HAS_METHOD

        /// <summary>
        /// Sum YGroup4Zip - Vector128 - base - Widen.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128Base_Widen(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vector1Used = vector1.AsVector128();
            Vector128<TMy> vector2Used = vector2.AsVector128();
            Vector128<TMy> vector3Used = vector3.AsVector128();
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector128 result.
            Vector128<TMy> vrt1 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt2 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt3 = Vector128<TMy>.Zero;
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector128 processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector128<TMy> vtemp = WVectorTraits128Base.Statics.YGroup4Zip_Widen(p0, vector1Used, vector2Used, vector3Used, out var vtemp1, out var vtemp2, out var vtemp3);
                vrt = WVectorTraits128Base.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits128Base.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits128Base.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits128Base.Statics.Add(vrt3, vtemp3);
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
            vrt = WVectorTraits128Base.Statics.Add(vrt, vrt2);
            rt = WVectorTraits128Base.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum128Base_Widen() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn128 = StaticSum128Base_Widen(srcArray, srcArray.Length);
            CheckResult128("Sum128Base_Widen");
        }

        /// <summary>
        /// Sum YGroup4Zip - Vector128 - base - Zip.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128Base_Zip(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vector1Used = vector1.AsVector128();
            Vector128<TMy> vector2Used = vector2.AsVector128();
            Vector128<TMy> vector3Used = vector3.AsVector128();
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector128 result.
            Vector128<TMy> vrt1 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt2 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt3 = Vector128<TMy>.Zero;
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector128 processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector128<TMy> vtemp = WVectorTraits128Base.Statics.YGroup4Zip_Zip(p0, vector1Used, vector2Used, vector3Used, out var vtemp1, out var vtemp2, out var vtemp3);
                vrt = WVectorTraits128Base.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits128Base.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits128Base.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits128Base.Statics.Add(vrt3, vtemp3);
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
            vrt = WVectorTraits128Base.Statics.Add(vrt, vrt2);
            rt = WVectorTraits128Base.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum128Base_Zip() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn128 = StaticSum128Base_Zip(srcArray, srcArray.Length);
            CheckResult128("Sum128Base_Zip");
        }

#endif // VECTOR_HAS_METHOD

        /// <summary>
        /// Sum YGroup4Zip - Vector128 - base.
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
            Vector128<TMy> vector3Used = vector3.AsVector128();
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector128 result.
            Vector128<TMy> vrt1 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt2 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt3 = Vector128<TMy>.Zero;
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector128 processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector128<TMy> vtemp = WVectorTraits128Base.Statics.YGroup4Zip(p0, vector1Used, vector2Used, vector3Used, out var vtemp1, out var vtemp2, out var vtemp3);
                vrt = WVectorTraits128Base.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits128Base.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits128Base.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits128Base.Statics.Add(vrt3, vtemp3);
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
        /// <summary>
        /// Sum YGroup4Zip - Vector128 - AdvSimd - ShuffleX.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128AdvSimd_ShuffleX(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vector1Used = vector1.AsVector128();
            Vector128<TMy> vector2Used = vector2.AsVector128();
            Vector128<TMy> vector3Used = vector3.AsVector128();
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector128 result.
            Vector128<TMy> vrt1 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt2 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt3 = Vector128<TMy>.Zero;
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector128 processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector128<TMy> vtemp = WVectorTraits128AdvSimd.Statics.YGroup4Zip_ShuffleX(p0, vector1Used, vector2Used, vector3Used, out var vtemp1, out var vtemp2, out var vtemp3);
                vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits128AdvSimd.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits128AdvSimd.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits128AdvSimd.Statics.Add(vrt3, vtemp3);
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
        /// Sum YGroup4Zip - Vector128 - AdvSimd - Widen.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128AdvSimd_Widen(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vector1Used = vector1.AsVector128();
            Vector128<TMy> vector2Used = vector2.AsVector128();
            Vector128<TMy> vector3Used = vector3.AsVector128();
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector128 result.
            Vector128<TMy> vrt1 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt2 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt3 = Vector128<TMy>.Zero;
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector128 processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector128<TMy> vtemp = WVectorTraits128AdvSimd.Statics.YGroup4Zip_Widen(p0, vector1Used, vector2Used, vector3Used, out var vtemp1, out var vtemp2, out var vtemp3);
                vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits128AdvSimd.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits128AdvSimd.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits128AdvSimd.Statics.Add(vrt3, vtemp3);
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
            vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vrt2);
            rt = WVectorTraits128AdvSimd.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum128AdvSimd_Widen() {
            WVectorTraits128AdvSimd.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn128 = StaticSum128AdvSimd_Widen(srcArray, srcArray.Length);
            CheckResult128("Sum128AdvSimd_Widen");
        }

        /// <summary>
        /// Sum YGroup4Zip - Vector128 - AdvSimd - Unzip.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128AdvSimd_Zip(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vector1Used = vector1.AsVector128();
            Vector128<TMy> vector2Used = vector2.AsVector128();
            Vector128<TMy> vector3Used = vector3.AsVector128();
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector128 result.
            Vector128<TMy> vrt1 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt2 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt3 = Vector128<TMy>.Zero;
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector128 processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector128<TMy> vtemp = WVectorTraits128AdvSimd.Statics.YGroup4Zip_Zip(p0, vector1Used, vector2Used, vector3Used, out var vtemp1, out var vtemp2, out var vtemp3);
                vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits128AdvSimd.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits128AdvSimd.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits128AdvSimd.Statics.Add(vrt3, vtemp3);
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
            vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vrt2);
            rt = WVectorTraits128AdvSimd.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum128AdvSimd_Zip() {
            WVectorTraits128AdvSimd.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn128 = StaticSum128AdvSimd_Zip(srcArray, srcArray.Length);
            CheckResult128("Sum128AdvSimd_Zip");
        }

#if NET8_0_OR_GREATER

        /// <summary>
        /// Sum YGroup4Zip - Vector128 - AdvSimdB64 - ShuffleX.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128AdvSimdB64_ShuffleX(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vector1Used = vector1.AsVector128();
            Vector128<TMy> vector2Used = vector2.AsVector128();
            Vector128<TMy> vector3Used = vector3.AsVector128();
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector128 result.
            Vector128<TMy> vrt1 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt2 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt3 = Vector128<TMy>.Zero;
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector128 processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector128<TMy> vtemp = WVectorTraits128AdvSimdB64.Statics.YGroup4Zip_ShuffleX(p0, vector1Used, vector2Used, vector3Used, out var vtemp1, out var vtemp2, out var vtemp3);
                vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits128AdvSimd.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits128AdvSimd.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits128AdvSimd.Statics.Add(vrt3, vtemp3);
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
            vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vrt2);
            rt = WVectorTraits128AdvSimd.Statics.Sum(vrt);
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

        /// <summary>
        /// Sum YGroup4Zip - Vector128 - AdvSimdB64 - Unzip.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128AdvSimdB64_Zip(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vector1Used = vector1.AsVector128();
            Vector128<TMy> vector2Used = vector2.AsVector128();
            Vector128<TMy> vector3Used = vector3.AsVector128();
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector128 result.
            Vector128<TMy> vrt1 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt2 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt3 = Vector128<TMy>.Zero;
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector128 processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector128<TMy> vtemp = WVectorTraits128AdvSimdB64.Statics.YGroup4Zip_Zip(p0, vector1Used, vector2Used, vector3Used, out var vtemp1, out var vtemp2, out var vtemp3);
                vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits128AdvSimd.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits128AdvSimd.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits128AdvSimd.Statics.Add(vrt3, vtemp3);
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
            vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vrt2);
            rt = WVectorTraits128AdvSimdB64.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum128AdvSimdB64_Zip() {
            WVectorTraits128AdvSimdB64.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn128 = StaticSum128AdvSimdB64_Zip(srcArray, srcArray.Length);
            CheckResult128("Sum128AdvSimdB64_Zip");
        }

#endif // NET5_0_OR_GREATER

#if NET8_0_OR_GREATER
        /// <summary>
        /// Sum YGroup4Zip - Vector128 - Sse - Permute.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128Sse_Permute(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vector1Used = vector1.AsVector128();
            Vector128<TMy> vector2Used = vector2.AsVector128();
            Vector128<TMy> vector3Used = vector3.AsVector128();
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector128 result.
            Vector128<TMy> vrt1 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt2 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt3 = Vector128<TMy>.Zero;
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector128 processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector128<TMy> vtemp = WVectorTraits128Sse.Statics.YGroup4Zip_PermuteLonger(p0, vector1Used, vector2Used, vector3Used, out var vtemp1, out var vtemp2, out var vtemp3);
                vrt = WVectorTraits128Sse.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits128Sse.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits128Sse.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits128Sse.Statics.Add(vrt3, vtemp3);
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
            vrt = WVectorTraits128Sse.Statics.Add(vrt, vrt2);
            rt = WVectorTraits128Sse.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum128Sse_Permute() {
            WVectorTraits128Sse.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn128 = StaticSum128Sse_Permute(srcArray, srcArray.Length);
            CheckResult128("Sum128Sse_Permute");
        }
#endif // NET8_0_OR_GREATER

        /// <summary>
        /// Sum YGroup4Zip - Vector128 - Sse - Widen.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128Sse_Widen(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vector1Used = vector1.AsVector128();
            Vector128<TMy> vector2Used = vector2.AsVector128();
            Vector128<TMy> vector3Used = vector3.AsVector128();
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector128 result.
            Vector128<TMy> vrt1 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt2 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt3 = Vector128<TMy>.Zero;
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector128 processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector128<TMy> vtemp = WVectorTraits128Sse.Statics.YGroup4Zip_Widen(p0, vector1Used, vector2Used, vector3Used, out var vtemp1, out var vtemp2, out var vtemp3);
                vrt = WVectorTraits128Sse.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits128Sse.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits128Sse.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits128Sse.Statics.Add(vrt3, vtemp3);
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
            vrt = WVectorTraits128Sse.Statics.Add(vrt, vrt2);
            rt = WVectorTraits128Sse.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum128Sse_Widen() {
            WVectorTraits128Sse.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn128 = StaticSum128Sse_Widen(srcArray, srcArray.Length);
            CheckResult128("Sum128Sse_Widen");
        }

        /// <summary>
        /// Sum YGroup4Zip - Vector128 - Sse - Zip.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum128Sse_Zip(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vector1Used = vector1.AsVector128();
            Vector128<TMy> vector2Used = vector2.AsVector128();
            Vector128<TMy> vector3Used = vector3.AsVector128();
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector128 result.
            Vector128<TMy> vrt1 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt2 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt3 = Vector128<TMy>.Zero;
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector128 processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector128<TMy> vtemp = WVectorTraits128Sse.Statics.YGroup4Zip_Zip(p0, vector1Used, vector2Used, vector3Used, out var vtemp1, out var vtemp2, out var vtemp3);
                vrt = WVectorTraits128Sse.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits128Sse.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits128Sse.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits128Sse.Statics.Add(vrt3, vtemp3);
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
            vrt = WVectorTraits128Sse.Statics.Add(vrt, vrt2);
            rt = WVectorTraits128Sse.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum128Sse_Zip() {
            WVectorTraits128Sse.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn128 = StaticSum128Sse_Zip(srcArray, srcArray.Length);
            CheckResult128("Sum128Sse_Zip");
        }

#endif // BENCHMARKS_ALGORITHM
        #endregion // BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum YGroup4Zip - Vector128 - Traits.
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
            Vector128<TMy> vector3Used = vector3.AsVector128();
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector128 result.
            Vector128<TMy> vrt1 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt2 = Vector128<TMy>.Zero;
            Vector128<TMy> vrt3 = Vector128<TMy>.Zero;
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector128 processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector128<TMy> vtemp = Vector128s.YGroup4Zip(p0, vector1Used, vector2Used, vector3Used, out var vtemp1, out var vtemp2, out var vtemp3);
                vrt = Vector128s.Add(vrt, vtemp);
                vrt1 = Vector128s.Add(vrt1, vtemp1);
                vrt2 = Vector128s.Add(vrt2, vtemp2);
                vrt3 = Vector128s.Add(vrt3, vtemp3);
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

        /// <summary>
        /// Sum YGroup4Zip - Vector256 - base - basic.
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
                Vector256<TMy> vtemp = WVectorTraits256Base.Statics.YGroup4Zip_Basic(p0, vector1Used, vector2Used, vector3Used, out var vtemp1, out var vtemp2, out var vtemp3);
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
        /// Sum YGroup4Zip - Vector256 - base - Widen.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum256Base_Widen(TMy[] src, int srcCount) {
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
                Vector256<TMy> vtemp = WVectorTraits256Base.Statics.YGroup4Zip_Widen(p0, vector1Used, vector2Used, vector3Used, out var vtemp1, out var vtemp2, out var vtemp3);
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
        public void Sum256Base_Widen() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn256 = StaticSum256Base_Widen(srcArray, srcArray.Length);
            CheckResult256("Sum256Base_Widen");
        }

        /// <summary>
        /// Sum YGroup4Zip - Vector256 - base - Zip.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum256Base_Zip(TMy[] src, int srcCount) {
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
                Vector256<TMy> vtemp = WVectorTraits256Base.Statics.YGroup4Zip_Zip(p0, vector1Used, vector2Used, vector3Used, out var vtemp1, out var vtemp2, out var vtemp3);
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
        public void Sum256Base_Zip() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn256 = StaticSum256Base_Zip(srcArray, srcArray.Length);
            CheckResult256("Sum256Base_Zip");
        }

#endif // VECTOR_HAS_METHOD

        /// <summary>
        /// Sum YGroup4Zip - Vector256 - base.
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
                Vector256<TMy> vtemp = WVectorTraits256Base.Statics.YGroup4Zip(p0, vector1Used, vector2Used, vector3Used, out var vtemp1, out var vtemp2, out var vtemp3);
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
        /// Sum YGroup4Zip - Vector256 - Avx2 - Permute.
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
                Vector256<TMy> vtemp = WVectorTraits256Avx2.Statics.YGroup4Zip_PermuteLonger(p0, vector1Used, vector2Used, vector3Used, out var vtemp1, out var vtemp2, out var vtemp3);
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
        /// Sum YGroup4Zip - Vector256 - Avx2 - Widen.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum256Avx2_Widen(TMy[] src, int srcCount) {
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
                Vector256<TMy> vtemp = WVectorTraits256Avx2.Statics.YGroup4Zip_Widen(p0, vector1Used, vector2Used, vector3Used, out var vtemp1, out var vtemp2, out var vtemp3);
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
        public void Sum256Avx2_Widen() {
            WVectorTraits256Avx2.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn256 = StaticSum256Avx2_Widen(srcArray, srcArray.Length);
            CheckResult256("Sum256Avx2_Widen");
        }

        /// <summary>
        /// Sum YGroup4Zip - Vector256 - Avx2 - Unpack.
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
                Vector256<TMy> vtemp = WVectorTraits256Avx2.Statics.YGroup4Zip_Unpack(p0, vector1Used, vector2Used, vector3Used, out var vtemp1, out var vtemp2, out var vtemp3);
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
        /// Sum YGroup4Zip - Vector256 - Avx2 - Zip.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum256Avx2_Zip(TMy[] src, int srcCount) {
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
                Vector256<TMy> vtemp = WVectorTraits256Avx2.Statics.YGroup4Zip_Zip(p0, vector1Used, vector2Used, vector3Used, out var vtemp1, out var vtemp2, out var vtemp3);
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
        public void Sum256Avx2_Zip() {
            WVectorTraits256Avx2.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn256 = StaticSum256Avx2_Zip(srcArray, srcArray.Length);
            CheckResult256("Sum256Avx2_Zip");
        }

#endif // BENCHMARKS_ALGORITHM
        #endregion // BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum YGroup4Zip - Vector256 - Traits.
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
                Vector256<TMy> vtemp = Vector256s.YGroup4Zip(p0, vector1Used, vector2Used, vector3Used, out var vtemp1, out var vtemp2, out var vtemp3);
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


        #region BENCHMARKS_512
#if BENCHMARKS_512 && NET8_0_OR_GREATER

        protected TMy dstOn512 = default, baselineOn512 = default;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected virtual void CheckResult512(string name) {
            CheckResult_Report(name, dstOn512 != baselineOn512, dstOn512, baselineOn512);
        }

        #region BENCHMARKS_ALGORITHM
#if BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum YGroup4Zip - Vector512 - base - basic.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum512Base_Basic(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector512<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector512<TMy> vector1Used = vector1.AsVector512();
            Vector512<TMy> vector2Used = vector2.AsVector512();
            Vector512<TMy> vector3Used = vector3.AsVector512();
            Vector512<TMy> vrt = Vector512<TMy>.Zero; // Vector512 result.
            Vector512<TMy> vrt1 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt2 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt3 = Vector512<TMy>.Zero;
            int i;
            // Body.
            ref Vector512<TMy> p0 = ref Unsafe.As<TMy, Vector512<TMy>>(ref src[0]);
            // a) Vector512 processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector512<TMy> vtemp = WVectorTraits512Base.Statics.YGroup4Zip_Basic(p0, vector1Used, vector2Used, vector3Used, out var vtemp1, out var vtemp2, out var vtemp3);
                vrt = WVectorTraits512Base.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits512Base.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits512Base.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits512Base.Statics.Add(vrt3, vtemp3);
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

#if VECTOR_HAS_METHOD

        /// <summary>
        /// Sum YGroup4Zip - Vector512 - base - Widen.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum512Base_Widen(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector512<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector512<TMy> vector1Used = vector1.AsVector512();
            Vector512<TMy> vector2Used = vector2.AsVector512();
            Vector512<TMy> vector3Used = vector3.AsVector512();
            Vector512<TMy> vrt = Vector512<TMy>.Zero; // Vector512 result.
            Vector512<TMy> vrt1 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt2 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt3 = Vector512<TMy>.Zero;
            int i;
            // Body.
            ref Vector512<TMy> p0 = ref Unsafe.As<TMy, Vector512<TMy>>(ref src[0]);
            // a) Vector512 processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector512<TMy> vtemp = WVectorTraits512Base.Statics.YGroup4Zip_Widen(p0, vector1Used, vector2Used, vector3Used, out var vtemp1, out var vtemp2, out var vtemp3);
                vrt = WVectorTraits512Base.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits512Base.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits512Base.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits512Base.Statics.Add(vrt3, vtemp3);
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
            vrt = WVectorTraits512Base.Statics.Add(vrt, vrt2);
            rt = WVectorTraits512Base.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum512Base_Widen() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn512 = StaticSum512Base_Widen(srcArray, srcArray.Length);
            CheckResult512("Sum512Base_Widen");
        }

        /// <summary>
        /// Sum YGroup4Zip - Vector512 - base - Zip.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum512Base_Zip(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector512<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector512<TMy> vector1Used = vector1.AsVector512();
            Vector512<TMy> vector2Used = vector2.AsVector512();
            Vector512<TMy> vector3Used = vector3.AsVector512();
            Vector512<TMy> vrt = Vector512<TMy>.Zero; // Vector512 result.
            Vector512<TMy> vrt1 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt2 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt3 = Vector512<TMy>.Zero;
            int i;
            // Body.
            ref Vector512<TMy> p0 = ref Unsafe.As<TMy, Vector512<TMy>>(ref src[0]);
            // a) Vector512 processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector512<TMy> vtemp = WVectorTraits512Base.Statics.YGroup4Zip_Zip(p0, vector1Used, vector2Used, vector3Used, out var vtemp1, out var vtemp2, out var vtemp3);
                vrt = WVectorTraits512Base.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits512Base.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits512Base.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits512Base.Statics.Add(vrt3, vtemp3);
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
            vrt = WVectorTraits512Base.Statics.Add(vrt, vrt2);
            rt = WVectorTraits512Base.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum512Base_Zip() {
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn512 = StaticSum512Base_Zip(srcArray, srcArray.Length);
            CheckResult512("Sum512Base_Zip");
        }

#endif // VECTOR_HAS_METHOD

        /// <summary>
        /// Sum YGroup4Zip - Vector512 - base.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum512Base(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector512<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector512<TMy> vector1Used = vector1.AsVector512();
            Vector512<TMy> vector2Used = vector2.AsVector512();
            Vector512<TMy> vector3Used = vector3.AsVector512();
            Vector512<TMy> vrt = Vector512<TMy>.Zero; // Vector512 result.
            Vector512<TMy> vrt1 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt2 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt3 = Vector512<TMy>.Zero;
            int i;
            // Body.
            ref Vector512<TMy> p0 = ref Unsafe.As<TMy, Vector512<TMy>>(ref src[0]);
            // a) Vector512 processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector512<TMy> vtemp = WVectorTraits512Base.Statics.YGroup4Zip(p0, vector1Used, vector2Used, vector3Used, out var vtemp1, out var vtemp2, out var vtemp3);
                vrt = WVectorTraits512Base.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits512Base.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits512Base.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits512Base.Statics.Add(vrt3, vtemp3);
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
        /// Sum YGroup4Zip - Vector512 - Avx512 - Widen.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum512Avx512_Widen(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector512<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector512<TMy> vector1Used = vector1.AsVector512();
            Vector512<TMy> vector2Used = vector2.AsVector512();
            Vector512<TMy> vector3Used = vector3.AsVector512();
            Vector512<TMy> vrt = Vector512<TMy>.Zero; // Vector512 result.
            Vector512<TMy> vrt1 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt2 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt3 = Vector512<TMy>.Zero;
            int i;
            // Body.
            ref Vector512<TMy> p0 = ref Unsafe.As<TMy, Vector512<TMy>>(ref src[0]);
            // a) Vector512 processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector512<TMy> vtemp = WVectorTraits512Avx512.Statics.YGroup4Zip_Widen(p0, vector1Used, vector2Used, vector3Used, out var vtemp1, out var vtemp2, out var vtemp3);
                vrt = WVectorTraits512Avx512.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits512Avx512.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits512Avx512.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits512Avx512.Statics.Add(vrt3, vtemp3);
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
            vrt = WVectorTraits512Avx512.Statics.Add(vrt, vrt2);
            rt = WVectorTraits512Avx512.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum512Avx512_Widen() {
            WVectorTraits512Avx512.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn512 = StaticSum512Avx512_Widen(srcArray, srcArray.Length);
            CheckResult512("Sum512Avx512_Widen");
        }

        /// <summary>
        /// Sum YGroup4Zip - Vector512 - Avx512 - Unpack.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum512Avx512_Unpack(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector512<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector512<TMy> vector1Used = vector1.AsVector512();
            Vector512<TMy> vector2Used = vector2.AsVector512();
            Vector512<TMy> vector3Used = vector3.AsVector512();
            Vector512<TMy> vrt = Vector512<TMy>.Zero; // Vector512 result.
            Vector512<TMy> vrt1 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt2 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt3 = Vector512<TMy>.Zero;
            int i;
            // Body.
            ref Vector512<TMy> p0 = ref Unsafe.As<TMy, Vector512<TMy>>(ref src[0]);
            // a) Vector512 processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector512<TMy> vtemp = WVectorTraits512Avx512.Statics.YGroup4Zip_Unpack(p0, vector1Used, vector2Used, vector3Used, out var vtemp1, out var vtemp2, out var vtemp3);
                vrt = WVectorTraits512Avx512.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits512Avx512.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits512Avx512.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits512Avx512.Statics.Add(vrt3, vtemp3);
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
            vrt = WVectorTraits512Avx512.Statics.Add(vrt, vrt2);
            rt = WVectorTraits512Avx512.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum512Avx512_Unpack() {
            WVectorTraits512Avx512.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn512 = StaticSum512Avx512_Unpack(srcArray, srcArray.Length);
            CheckResult512("Sum512Avx512_Unpack");
        }

        /// <summary>
        /// Sum YGroup4Zip - Vector512 - Avx512 - Zip.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum512Avx512_Zip(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector512<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector512<TMy> vector1Used = vector1.AsVector512();
            Vector512<TMy> vector2Used = vector2.AsVector512();
            Vector512<TMy> vector3Used = vector3.AsVector512();
            Vector512<TMy> vrt = Vector512<TMy>.Zero; // Vector512 result.
            Vector512<TMy> vrt1 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt2 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt3 = Vector512<TMy>.Zero;
            int i;
            // Body.
            ref Vector512<TMy> p0 = ref Unsafe.As<TMy, Vector512<TMy>>(ref src[0]);
            // a) Vector512 processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector512<TMy> vtemp = WVectorTraits512Avx512.Statics.YGroup4Zip_Zip(p0, vector1Used, vector2Used, vector3Used, out var vtemp1, out var vtemp2, out var vtemp3);
                vrt = WVectorTraits512Avx512.Statics.Add(vrt, vtemp);
                vrt1 = WVectorTraits512Avx512.Statics.Add(vrt1, vtemp1);
                vrt2 = WVectorTraits512Avx512.Statics.Add(vrt2, vtemp2);
                vrt3 = WVectorTraits512Avx512.Statics.Add(vrt3, vtemp3);
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
            vrt = WVectorTraits512Avx512.Statics.Add(vrt, vrt2);
            rt = WVectorTraits512Avx512.Statics.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void Sum512Avx512_Zip() {
            WVectorTraits512Avx512.Statics.ThrowForUnsupported(true);
            if (BenchmarkUtil.IsLastRun) {
                //Debugger.Break();
                Volatile.Write(ref dstTMy, 0);
            }
            dstOn512 = StaticSum512Avx512_Zip(srcArray, srcArray.Length);
            CheckResult512("Sum512Avx512_Zip");
        }

#endif // BENCHMARKS_ALGORITHM
        #endregion // BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum YGroup4Zip - Vector512 - Traits.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSum512Traits(TMy[] src, int srcCount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector512<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector512<TMy> vector1Used = vector1.AsVector512();
            Vector512<TMy> vector2Used = vector2.AsVector512();
            Vector512<TMy> vector3Used = vector3.AsVector512();
            Vector512<TMy> vrt = Vector512<TMy>.Zero; // Vector512 result.
            Vector512<TMy> vrt1 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt2 = Vector512<TMy>.Zero;
            Vector512<TMy> vrt3 = Vector512<TMy>.Zero;
            int i;
            // Body.
            ref Vector512<TMy> p0 = ref Unsafe.As<TMy, Vector512<TMy>>(ref src[0]);
            // a) Vector512 processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector512<TMy> vtemp = Vector512s.YGroup4Zip(p0, vector1Used, vector2Used, vector3Used, out var vtemp1, out var vtemp2, out var vtemp3);
                vrt = Vector512s.Add(vrt, vtemp);
                vrt1 = Vector512s.Add(vrt1, vtemp1);
                vrt2 = Vector512s.Add(vrt2, vtemp2);
                vrt3 = Vector512s.Add(vrt3, vtemp3);
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

#endif // BENCHMARKS_512 && NET8_0_OR_GREATER
        #endregion // BENCHMARKS_512


    }
}
