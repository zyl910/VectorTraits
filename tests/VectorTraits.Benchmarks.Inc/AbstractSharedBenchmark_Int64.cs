using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zyl.VectorTraits.Benchmarks {

    // My type.
    using TMy = Int64;

    /// <summary>
    /// Abstract shared array benchmark.
    /// </summary>
    internal class AbstractSharedBenchmark_Int64 : AbstractSharedBenchmark {
        // -- TMy ref --
        protected static ref TMy dstTMy => ref dstInt64;
        protected static ref TMy baselineTMy => ref baselineInt64;
        protected static TMy[] srcArray => srcArrayInt64;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected override void CheckResult(string name) {
            CheckResultInt64(name);
        }


        // -- Params --
        public override int ShiftCountMin {
            get {
                //return 1;
                return -1;
            }
        }
        public override int ShiftCountMax {
            get {
                //return 1;
                return Scalars<TMy>.BitSize + 1;
            }
        }


    }
}
