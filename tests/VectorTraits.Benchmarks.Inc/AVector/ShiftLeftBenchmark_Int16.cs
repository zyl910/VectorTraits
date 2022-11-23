using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Benchmarks.AVector {
    //using BenchmarkAttribute = FakeBenchmarkAttribute;

    // My type.
    using TMy = Int16;

    /// <summary>
    /// Shift left benchmark - Int16.
    /// </summary>
    public partial class ShiftLeftBenchmark_Int16 : AbstractSharedBenchmark {
        // -- TMy ref --
        private static ref TMy dstTMy => ref dstInt16;
        private static ref TMy baselineTMy => ref baselineInt16;
        private static TMy[] srcArray => srcArrayInt16;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void CheckResult(string name) {
            CheckResultInt16(name);
        }



        // -- var --
        private const byte DefaultShiftCount = 4;

        /// <summary>
        /// Sum shift left logical for int array - base.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftCount">Shift count.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMy StaticSumSLLScalar(TMy[] src, int srcCount, int shiftCount) {
            TMy rt = 0; // Result.
            for (int i = 0; i < srcCount; ++i) {
                rt += (TMy)(src[i] << shiftCount);
            }
            return rt;
        }

        [Benchmark(Baseline = true)]
        public void SumSLLScalar() {
            dstTMy = StaticSumSLLScalar(srcArray, srcArray.Length, DefaultShiftCount);
            if (CheckMode) {
                baselineTMy = dstTMy;
                BenchmarkUtil.WriteLine(string.Format("# StaticSumSLLScalar:\t{0}", baselineTMy));
            }
        }

#if NET7_0_OR_GREATER
        /// <summary>
        /// Sum shift left logical for int array - VectorT - .NET7.
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
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                // Debugger.Break();
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
            dstTMy = StaticSumSLLNet7(srcArray, srcArray.Length, DefaultShiftCount);
            CheckResultInt32("SumSLLNet7");
        }
#endif // NET7_0_OR_GREATER

#if NETCOREAPP3_0_OR_GREATER
        /// <summary>
        /// Sum shift left logical for int array - VectorT - Avx.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftCount">Shift count.</param>
        /// <returns>Returns the sum.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe TMy StaticSumSLLAvx2(TMy[] src, int srcCount, int shiftCount) {
            TMy rt = 0; // Result.
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            fixed (TMy* p0 = &src[0]) {
                TMy* p = p0;
                // Vector processs.
                // Debugger.Break();
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
        public void SumSLLAvx2() {
            //Debugger.Break();
            dstTMy = StaticSumSLLAvx2(srcArray, srcArray.Length, DefaultShiftCount);
            CheckResultInt32("SumSLLAvx2");
        }
#endif // NETCOREAPP3_0_OR_GREATER

    }
}
