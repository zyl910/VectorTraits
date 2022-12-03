using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zyl.VectorTraits.Benchmarks {

    // My type.
    using TMy = Byte;

    /// <summary>
    /// Abstract shared array benchmark.
    /// </summary>
    internal class AbstractSharedBenchmark_Byte : AbstractSharedBenchmark {
        // -- TMy ref --
        protected static ref TMy dstTMy => ref dstByte;
        protected static ref TMy baselineTMy => ref baselineByte;
        protected static TMy[] srcArray => srcArrayByte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected void CheckResult(string name) {
            CheckResultByte(name);
        }


    }
}
