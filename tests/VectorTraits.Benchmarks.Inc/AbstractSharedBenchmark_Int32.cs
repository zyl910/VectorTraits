using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zyl.VectorTraits.Benchmarks {

    // My type.
    using TMy = Int32;

    /// <summary>
    /// Abstract shared array benchmark.
    /// </summary>
    internal class AbstractSharedBenchmark_Int32 : AbstractSharedBenchmark {
        // -- TMy ref --
        protected static ref TMy dstTMy => ref dstInt32;
        protected static ref TMy baselineTMy => ref baselineInt32;
        protected static TMy[] srcArray => srcArrayInt32;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected void CheckResult(string name) {
            CheckResultInt32(name);
        }

        // -- Params --
        public static int ShiftCountMin {
            get {
                //return 1;
                return -1;
            }
        }
        public static int ShiftCountMax {
            get {
                //return 1;
                return Scalars<TMy>.BitSize + 1;
            }
        }


    }
}
