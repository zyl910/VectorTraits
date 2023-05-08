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

namespace Zyl.VectorTraits.Benchmarks.AVector.S {
#if BENCHMARKS_OFF
    using BenchmarkAttribute = FakeBenchmarkAttribute;
#else
#endif // BENCHMARKS_OFF

    // My type.
    using TMy = SByte;

    /// <summary>
    /// Shuffle benchmark - SByte.
    /// </summary>
#if NETCOREAPP3_0_OR_GREATER && DRY_JOB
    [DryJob]
#endif // NETCOREAPP3_0_OR_GREATER && DRY_JOB
    public partial class ShuffleBenchmark_SByte : AbstractSharedBenchmark_SByte {

        // -- var --
        private static readonly Vector<TMy> indices = Vectors<TMy>.SerialDesc;


        /// <summary>
        /// Sum Shuffle - Scalar.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="indices">The indices.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumShuffleScalar(TMy[] src, int srcCount, Vector<TMy> indices) {
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
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector<TMy> vtemp = VectorTraitsBase.Statics.Shuffle_Base(p0, indices);
                vrt += vtemp; // Add.
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark(Baseline = true)]
        public void SumShuffleScalar() {
            //Debugger.Break();
            dstTMy = StaticSumShuffleScalar(srcArray, srcArray.Length, indices);
            if (CheckMode) {
                baselineTMy = dstTMy;
                BenchmarkUtil.WriteItem("# SumShuffleScalar", string.Format("{0}", baselineTMy));
            }
        }

        #region BENCHMARKS_RAW
#if BENCHMARKS_RAW

        /// <summary>
        /// Sum Shuffle - Vector - base.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="indices">The indices.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumShuffleVectorBase(TMy[] src, int srcCount, Vector<TMy> indices) {
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
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector<TMy> vtemp = VectorTraitsBase.Statics.Shuffle(p0, indices);
                vrt += vtemp; // Add.
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumShuffleVectorBase() {
            //Debugger.Break();
            dstTMy = StaticSumShuffleVectorBase(srcArray, srcArray.Length, indices);
            CheckResult("SumShuffleVectorBase");
        }

#endif // BENCHMARKS_RAW
        #endregion // BENCHMARKS_RAW

        /// <summary>
        /// Sum Shuffle - Vector Traits - static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="indices">The indices.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumShuffleVectorTraits(TMy[] src, int srcCount, Vector<TMy> indices) {
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
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector<TMy> vtemp = Vectors.Shuffle(p0, indices);
                vrt += vtemp; // Add.
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumShuffleVectorTraits() {
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSumShuffleVectorTraits(srcArray, srcArray.Length, indices);
            CheckResult("SumShuffleVectorTraits");
        }

        /// <summary>
        /// Sum Shuffle - Vector Traits - static - Args and Core.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="indices">The indices.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumShuffleVectorTraits_Args0(TMy[] src, int srcCount, Vector<TMy> indices) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            Vector<TMy> args0, args1;
            Vectors.Shuffle_Args(indices, out args0, out args1);
            int i;
            // Body.
            ref Vector<TMy> p0 = ref Unsafe.As<TMy, Vector<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector<TMy> vtemp = Vectors.Shuffle_Core(p0, args0, args1);
                vrt += vtemp; // Add.
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumShuffleVectorTraits_Args0() {
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSumShuffleVectorTraits_Args0(srcArray, srcArray.Length, indices);
            CheckResult("SumShuffleVectorTraits_Args0");
        }

        /// <summary>
        /// Sum Shuffle - Vector Traits - static - Args and Core with ValueTuple.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="indices">The indices.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumShuffleVectorTraits_Args(TMy[] src, int srcCount, Vector<TMy> indices) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            var args = Vectors.Shuffle_Args(indices);
            int i;
            // Body.
            ref Vector<TMy> p0 = ref Unsafe.As<TMy, Vector<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector<TMy> vtemp = Vectors.Shuffle_Core(p0, args);
                vrt += vtemp; // Add.
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumShuffleVectorTraits_Args() {
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSumShuffleVectorTraits_Args(srcArray, srcArray.Length, indices);
            CheckResult("SumShuffleVectorTraits_Args");
        }

#if !REDUCE_MEMORY_USAGE
        /// <summary>
        /// Sum Shuffle - Vector Traits - static if.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="indices">The indices.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumShuffleVectorTraitsIf(TMy[] src, int srcCount, Vector<TMy> indices) {
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
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
#pragma warning disable CS0618 // Type or member is obsolete
                Vector<TMy> vtemp = Vector_Shuffle.Shuffle(p0, indices);
#pragma warning restore CS0618 // Type or member is obsolete
                vrt += vtemp; // Add.
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumShuffleVectorTraitsIf() {
            //Debugger.Break();
            dstTMy = StaticSumShuffleVectorTraitsIf(srcArray, srcArray.Length, indices);
            CheckResult("SumShuffleVectorTraitsIf");
        }
#endif // !REDUCE_MEMORY_USAGE


#if NETCOREAPP3_0_OR_GREATER

        #region BENCHMARKS_128ALGORITHM
#if BENCHMARKS_128ALGORITHM

        #region BENCHMARKS_ALGORITHM
#if BENCHMARKS_ALGORITHM

#if NET7_0_OR_GREATER

        /// <summary>
        /// Sum Shuffle - Vector128 - Bcl.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="indices">The indices.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumShuffleVector128_Bcl(TMy[] src, int srcCount, Vector<TMy> indices) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector result.
            Vector128<TMy> indicesUsed = indices.AsVector128();
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector128<TMy> vtemp = Vector128.Shuffle(p0, indicesUsed);
                vrt += vtemp; // Add.
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt.GetElement(i);
            }
            return rt;
        }

        [Benchmark]
        public void SumShuffleVector128_Bcl() {
            if (Vector<byte>.Count != Vector128<byte>.Count) {
                throw new NotSupportedException(string.Format("Vector byte size mismatch({0}!={1}) !", Vector<byte>.Count, Vector128<byte>.Count));
            }
            //Debugger.Break();
            dstTMy = StaticSumShuffleVector128_Bcl(srcArray, srcArray.Length, indices);
            CheckResult("SumShuffleVector128_Bcl");
        }

#endif // NET7_0_OR_GREATER

#if NET5_0_OR_GREATER

        /// <summary>
        /// Sum Shuffle - Vector128 - Arm.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="indices">The indices.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumShuffleVector128_Arm(TMy[] src, int srcCount, Vector<TMy> indices) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector result.
            Vector128<TMy> indicesUsed = indices.AsVector128();
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector128<TMy> vtemp = WVectorTraits128AdvSimd.Statics.Shuffle(p0, indicesUsed);
                vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vtemp);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt.GetElement(i);
            }
            return rt;
        }

        [Benchmark]
        public void SumShuffleVector128_Arm() {
            WVectorTraits128AdvSimd.Statics.ThrowForUnsupported(true);
            if (Vector<byte>.Count != Vector128<byte>.Count) {
                throw new NotSupportedException(string.Format("Vector byte size mismatch({0}!={1}) !", Vector<byte>.Count, Vector128<byte>.Count));
            }
            //Debugger.Break();
            dstTMy = StaticSumShuffleVector128_Arm(srcArray, srcArray.Length, indices);
            CheckResult("SumShuffleVector128_Arm");
        }

#endif // NET5_0_OR_GREATER

#endif // BENCHMARKS_ALGORITHM
        #endregion // BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum Shuffle - Vector128 - Traits static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="indices">The indices.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumShuffleVector128Traits(TMy[] src, int srcCount, Vector<TMy> indices) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector result.
            Vector128<TMy> indicesUsed = indices.AsVector128();
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector128<TMy> vtemp = Vector128s.Shuffle(p0, indicesUsed);
                vrt = Vector128s.Add(vrt, vtemp);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt.GetElement(i);
            }
            return rt;
        }

        [Benchmark]
        public void SumShuffleVector128Traits() {
            Vector128s.ThrowForUnsupported(true);
            if (Vector<byte>.Count != Vector128<byte>.Count) {
                throw new NotSupportedException(string.Format("Vector byte size mismatch({0}!={1}) !", Vector<byte>.Count, Vector128<byte>.Count));
            }
            //Debugger.Break();
            dstTMy = StaticSumShuffleVector128Traits(srcArray, srcArray.Length, indices);
            CheckResult("SumShuffleVector128Traits");
        }

#endif // BENCHMARKS_128ALGORITHM
        #endregion // BENCHMARKS_128ALGORITHM

        #region BENCHMARKS_256ALGORITHM
#if BENCHMARKS_256ALGORITHM


#if NET7_0_OR_GREATER

        /// <summary>
        /// Sum Shuffle - Vector256 - Bcl.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="indices">The indices.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumShuffleVector256_Bcl(TMy[] src, int srcCount, Vector<TMy> indices) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> vrt = Vector256<TMy>.Zero; // Vector result.
            Vector256<TMy> indicesUsed = indices.AsVector256();
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256<TMy> vtemp = Vector256.Shuffle(p0, indicesUsed);
                vrt += vtemp; // Add.
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt.GetElement(i);
            }
            return rt;
        }

        [Benchmark]
        public void SumShuffleVector256_Bcl() {
            if (Vector<byte>.Count != Vector256<byte>.Count) {
                throw new NotSupportedException(string.Format("Vector byte size mismatch({0}!={1}) !", Vector<byte>.Count, Vector256<byte>.Count));
            }
            //Debugger.Break();
            dstTMy = StaticSumShuffleVector256_Bcl(srcArray, srcArray.Length, indices);
            CheckResult("SumShuffleVector256_Bcl");
        }

#endif // NET7_0_OR_GREATER

        /// <summary>
        /// Sum Shuffle - Vector256 - Avx2 - Add1.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="indices">The indices.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumShuffleVector256_Avx2_Add1(TMy[] src, int srcCount, Vector<TMy> indices) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> vrt = Vector256<TMy>.Zero; // Vector result.
            Vector256<TMy> back = Vector256<TMy>.Zero;
            Vector256<TMy> indicesUsed = indices.AsVector256();
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256<TMy> vtemp = WVectorTraits256Avx2.Statics.YShuffleInsert_Add1(back.AsByte(), p0.AsByte(), indicesUsed.AsByte()).AsSByte();
                vrt = WVectorTraits256Avx2.Statics.Add(vrt, vtemp);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt.GetElement(i);
            }
            return rt;
        }

        [Benchmark]
        public void SumShuffleVector256_Avx2_Add1() {
            WVectorTraits256Avx2.Statics.ThrowForUnsupported(true);
            if (Vector<byte>.Count != Vector256<byte>.Count) {
                throw new NotSupportedException(string.Format("Vector byte size mismatch({0}!={1}) !", Vector<byte>.Count, Vector256<byte>.Count));
            }
            //Debugger.Break();
            dstTMy = StaticSumShuffleVector256_Avx2_Add1(srcArray, srcArray.Length, indices);
            CheckResult("SumShuffleVector256_Avx2_Add1");
        }

        /// <summary>
        /// Sum Shuffle - Vector256 - Avx2 - Add2.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="indices">The indices.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumShuffleVector256_Avx2_Add2(TMy[] src, int srcCount, Vector<TMy> indices) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> vrt = Vector256<TMy>.Zero; // Vector result.
            Vector256<TMy> back = Vector256<TMy>.Zero;
            Vector256<TMy> indicesUsed = indices.AsVector256();
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256<TMy> vtemp = WVectorTraits256Avx2.Statics.YShuffleInsert_Add2(back.AsByte(), p0.AsByte(), indicesUsed.AsByte()).AsSByte();
                vrt = WVectorTraits256Avx2.Statics.Add(vrt, vtemp);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt.GetElement(i);
            }
            return rt;
        }

        [Benchmark]
        public void SumShuffleVector256_Avx2_Add2() {
            WVectorTraits256Avx2.Statics.ThrowForUnsupported(true);
            if (Vector<byte>.Count != Vector256<byte>.Count) {
                throw new NotSupportedException(string.Format("Vector byte size mismatch({0}!={1}) !", Vector<byte>.Count, Vector256<byte>.Count));
            }
            //Debugger.Break();
            dstTMy = StaticSumShuffleVector256_Avx2_Add2(srcArray, srcArray.Length, indices);
            CheckResult("SumShuffleVector256_Avx2_Add2");
        }

        /// <summary>
        /// Sum Shuffle - Vector256 - Avx2 - Cmp2.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="indices">The indices.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumShuffleVector256_Avx2_Cmp2(TMy[] src, int srcCount, Vector<TMy> indices) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> vrt = Vector256<TMy>.Zero; // Vector result.
            Vector256<TMy> back = Vector256<TMy>.Zero;
            Vector256<TMy> indicesUsed = indices.AsVector256();
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256<TMy> vtemp = WVectorTraits256Avx2.Statics.YShuffleInsert_Cmp2(back.AsByte(), p0.AsByte(), indicesUsed.AsByte()).AsSByte();
                vrt = WVectorTraits256Avx2.Statics.Add(vrt, vtemp);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt.GetElement(i);
            }
            return rt;
        }

        [Benchmark]
        public void SumShuffleVector256_Avx2_Cmp2() {
            WVectorTraits256Avx2.Statics.ThrowForUnsupported(true);
            if (Vector<byte>.Count != Vector256<byte>.Count) {
                throw new NotSupportedException(string.Format("Vector byte size mismatch({0}!={1}) !", Vector<byte>.Count, Vector256<byte>.Count));
            }
            //Debugger.Break();
            dstTMy = StaticSumShuffleVector256_Avx2_Cmp2(srcArray, srcArray.Length, indices);
            CheckResult("SumShuffleVector256_Avx2_Cmp2");
        }

        /// <summary>
        /// Sum Shuffle - Vector256 - Traits static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="indices">The indices.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumShuffleVector256Traits(TMy[] src, int srcCount, Vector<TMy> indices) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> vrt = Vector256<TMy>.Zero; // Vector result.
            Vector256<TMy> indicesUsed = indices.AsVector256();
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256<TMy> vtemp = Vector256s.Shuffle(p0, indicesUsed);
                vrt = Vector256s.Add(vrt, vtemp);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt.GetElement(i);
            }
            return rt;
        }

        [Benchmark]
        public void SumShuffleVector256Traits() {
            Vector256s.ThrowForUnsupported(true);
            if (Vector<byte>.Count != Vector256<byte>.Count) {
                throw new NotSupportedException(string.Format("Vector byte size mismatch({0}!={1}) !", Vector<byte>.Count, Vector256<byte>.Count));
            }
            //Debugger.Break();
            dstTMy = StaticSumShuffleVector256Traits(srcArray, srcArray.Length, indices);
            CheckResult("SumShuffleVector256Traits");
        }

#endif // BENCHMARKS_256ALGORITHM
        #endregion // BENCHMARKS_256ALGORITHM

#endif

        /// <summary>
        /// Sum YShuffleKernel - Vector Traits - static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="indices">The indices.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumYShuffleKernelVectorTraits(TMy[] src, int srcCount, Vector<TMy> indices) {
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
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector<TMy> vtemp = Vectors.YShuffleKernel(p0, indices);
                vrt += vtemp; // Add.
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumYShuffleKernelVectorTraits() {
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSumYShuffleKernelVectorTraits(srcArray, srcArray.Length, indices);
            CheckResult("SumYShuffleKernelVectorTraits");
        }

        /// <summary>
        /// Sum YShuffleKernel - Vector Traits - static - Args and Core.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="indices">The indices.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumYShuffleKernelVectorTraits_Args0(TMy[] src, int srcCount, Vector<TMy> indices) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            Vector<TMy> args0, args1;
            Vectors.YShuffleKernel_Args(indices, out args0, out args1);
            int i;
            // Body.
            ref Vector<TMy> p0 = ref Unsafe.As<TMy, Vector<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector<TMy> vtemp = Vectors.YShuffleKernel_Core(p0, args0, args1);
                vrt += vtemp; // Add.
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumYShuffleKernelVectorTraits_Args0() {
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSumYShuffleKernelVectorTraits_Args0(srcArray, srcArray.Length, indices);
            CheckResult("SumYShuffleKernelVectorTraits_Args0");
        }

        /// <summary>
        /// Sum YShuffleKernel - Vector Traits - static - Args and Core with ValueTuple.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="indices">The indices.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumYShuffleKernelVectorTraits_Args(TMy[] src, int srcCount, Vector<TMy> indices) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            var args = Vectors.YShuffleKernel_Args(indices);
            int i;
            // Body.
            ref Vector<TMy> p0 = ref Unsafe.As<TMy, Vector<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector<TMy> vtemp = Vectors.YShuffleKernel_Core(p0, args);
                vrt += vtemp; // Add.
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        [Benchmark]
        public void SumYShuffleKernelVectorTraits_Args() {
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSumYShuffleKernelVectorTraits_Args(srcArray, srcArray.Length, indices);
            CheckResult("SumYShuffleKernelVectorTraits_Args");
        }


#if NETCOREAPP3_0_OR_GREATER

        #region BENCHMARKS_128ALGORITHM
#if BENCHMARKS_128ALGORITHM

        #region BENCHMARKS_ALGORITHM
#if BENCHMARKS_ALGORITHM

#if NET5_0_OR_GREATER

        /// <summary>
        /// Sum YShuffleKernel - Vector128 - Arm.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="indices">The indices.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumYShuffleKernelVector128_Arm(TMy[] src, int srcCount, Vector<TMy> indices) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector result.
            Vector128<TMy> indicesUsed = indices.AsVector128();
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector128<TMy> vtemp = WVectorTraits128AdvSimd.Statics.YShuffleKernel(p0, indicesUsed);
                vrt = WVectorTraits128AdvSimd.Statics.Add(vrt, vtemp);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt.GetElement(i);
            }
            return rt;
        }

        [Benchmark]
        public void SumYShuffleKernelVector128_Arm() {
            WVectorTraits128AdvSimd.Statics.ThrowForUnsupported(true);
            if (Vector<byte>.Count != Vector128<byte>.Count) {
                throw new NotSupportedException(string.Format("Vector byte size mismatch({0}!={1}) !", Vector<byte>.Count, Vector128<byte>.Count));
            }
            //Debugger.Break();
            dstTMy = StaticSumYShuffleKernelVector128_Arm(srcArray, srcArray.Length, indices);
            CheckResult("SumYShuffleKernelVector128_Arm");
        }

#endif // NET5_0_OR_GREATER

#endif // BENCHMARKS_ALGORITHM
        #endregion // BENCHMARKS_ALGORITHM

        /// <summary>
        /// Sum YShuffleKernel - Vector128 - Traits static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="indices">The indices.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumYShuffleKernelVector128Traits(TMy[] src, int srcCount, Vector<TMy> indices) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector128<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector128<TMy> vrt = Vector128<TMy>.Zero; // Vector result.
            Vector128<TMy> indicesUsed = indices.AsVector128();
            int i;
            // Body.
            ref Vector128<TMy> p0 = ref Unsafe.As<TMy, Vector128<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector128<TMy> vtemp = Vector128s.YShuffleKernel(p0, indicesUsed);
                vrt = Vector128s.Add(vrt, vtemp);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt.GetElement(i);
            }
            return rt;
        }

        [Benchmark]
        public void SumYShuffleKernelVector128Traits() {
            Vector128s.ThrowForUnsupported(true);
            if (Vector<byte>.Count != Vector128<byte>.Count) {
                throw new NotSupportedException(string.Format("Vector byte size mismatch({0}!={1}) !", Vector<byte>.Count, Vector128<byte>.Count));
            }
            //Debugger.Break();
            dstTMy = StaticSumYShuffleKernelVector128Traits(srcArray, srcArray.Length, indices);
            CheckResult("SumYShuffleKernelVector128Traits");
        }

#endif // BENCHMARKS_128ALGORITHM
        #endregion // BENCHMARKS_128ALGORITHM

        #region BENCHMARKS_256ALGORITHM
#if BENCHMARKS_256ALGORITHM


        /// <summary>
        /// Sum YShuffleKernel - Vector256 - Traits static.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="indices">The indices.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumYShuffleKernelVector256Traits(TMy[] src, int srcCount, Vector<TMy> indices) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> vrt = Vector256<TMy>.Zero; // Vector result.
            Vector256<TMy> indicesUsed = indices.AsVector256();
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256<TMy> vtemp = Vector256s.YShuffleKernel(p0, indicesUsed);
                vrt = Vector256s.Add(vrt, vtemp);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt.GetElement(i);
            }
            return rt;
        }

        [Benchmark]
        public void SumYShuffleKernelVector256Traits() {
            Vector256s.ThrowForUnsupported(true);
            if (Vector<byte>.Count != Vector256<byte>.Count) {
                throw new NotSupportedException(string.Format("Vector byte size mismatch({0}!={1}) !", Vector<byte>.Count, Vector256<byte>.Count));
            }
            //Debugger.Break();
            dstTMy = StaticSumYShuffleKernelVector256Traits(srcArray, srcArray.Length, indices);
            CheckResult("SumYShuffleKernelVector256Traits");
        }

        /// <summary>
        /// Sum YShuffleKernel - Vector256 - Traits static - Args and Core.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="indices">The indices.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumYShuffleKernelVector256Traits_Args0(TMy[] src, int srcCount, Vector<TMy> indices) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> vrt = Vector256<TMy>.Zero; // Vector result.
            Vector256<TMy> indicesUsed = indices.AsVector256();
            (var args0, var args1) = Vector256s.YShuffleKernel_Args(indicesUsed);
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256<TMy> vtemp = Vector256s.YShuffleKernel_Core(p0, args0, args1);
                vrt = Vector256s.Add(vrt, vtemp);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt.GetElement(i);
            }
            return rt;
        }

        [Benchmark]
        public void SumYShuffleKernelVector256Traits_Args0() {
            Vector256s.ThrowForUnsupported(true);
            if (Vector<byte>.Count != Vector256<byte>.Count) {
                throw new NotSupportedException(string.Format("Vector byte size mismatch({0}!={1}) !", Vector<byte>.Count, Vector256<byte>.Count));
            }
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSumYShuffleKernelVector256Traits_Args0(srcArray, srcArray.Length, indices);
            CheckResult("SumYShuffleKernelVector256Traits_Args0");
        }

        /// <summary>
        /// Sum YShuffleKernel - Vector256 - Traits static - Args and Core with ValueTuple.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="indices">The indices.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumYShuffleKernelVector256Traits_Args(TMy[] src, int srcCount, Vector<TMy> indices) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> vrt = Vector256<TMy>.Zero; // Vector result.
            Vector256<TMy> indicesUsed = indices.AsVector256();
            var args = Vector256s.YShuffleKernel_Args(indicesUsed);
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256<TMy> vtemp = Vector256s.YShuffleKernel_Core(p0, args);
                vrt = Vector256s.Add(vrt, vtemp);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt.GetElement(i);
            }
            return rt;
        }

        [Benchmark]
        public void SumYShuffleKernelVector256Traits_Args() {
            Vector256s.ThrowForUnsupported(true);
            if (Vector<byte>.Count != Vector256<byte>.Count) {
                throw new NotSupportedException(string.Format("Vector byte size mismatch({0}!={1}) !", Vector<byte>.Count, Vector256<byte>.Count));
            }
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSumYShuffleKernelVector256Traits_Args(srcArray, srcArray.Length, indices);
            CheckResult("SumYShuffleKernelVector256Traits_Args");
        }

        /// <summary>
        /// Sum YShuffleKernel - Vector256 - Traits static - ArgsX and Core.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="indices">The indices.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumYShuffleKernelVector256Traits_ArgsX(TMy[] src, int srcCount, Vector<TMy> indices) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector256<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector256<TMy> vrt = Vector256<TMy>.Zero; // Vector result.
            Vector256<TMy> indicesUsed = indices.AsVector256();
#pragma warning disable CS0618 // Type or member is obsolete
            var args = Vector256s.YShuffleKernel_ArgsX(indicesUsed);
            int i;
            // Body.
            ref Vector256<TMy> p0 = ref Unsafe.As<TMy, Vector256<TMy>>(ref src[0]);
            // a) Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector256<TMy> vtemp = Vector256s.YShuffleKernel_Core(p0, args);
                vrt = Vector256s.Add(vrt, vtemp);
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
#pragma warning restore CS0618 // Type or member is obsolete
            // b) Remainder processs.
            // ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            // for (i = 0; i < cntRem; ++i) {
            //     // Ignore
            // }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt.GetElement(i);
            }
            return rt;
        }

        [Benchmark]
        public void SumYShuffleKernelVector256Traits_ArgsX() {
            Vector256s.ThrowForUnsupported(true);
            if (Vector<byte>.Count != Vector256<byte>.Count) {
                throw new NotSupportedException(string.Format("Vector byte size mismatch({0}!={1}) !", Vector<byte>.Count, Vector256<byte>.Count));
            }
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSumYShuffleKernelVector256Traits_ArgsX(srcArray, srcArray.Length, indices);
            CheckResult("SumYShuffleKernelVector256Traits_ArgsX");
        }

#endif // BENCHMARKS_256ALGORITHM
        #endregion // BENCHMARKS_256ALGORITHM

#endif
    }
}
