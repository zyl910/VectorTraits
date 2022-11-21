using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
#endif
#if NET5_0_OR_GREATER
using System.Runtime.Intrinsics.Arm;
#endif // NET5_0_OR_GREATER
using System.Text;
using Zyl.VectorTraits.Benchmarks;

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

    }
}
