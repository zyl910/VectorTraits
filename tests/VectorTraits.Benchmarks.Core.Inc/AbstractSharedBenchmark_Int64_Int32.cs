using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zyl.VectorTraits.Benchmarks {

    // My type.
    using TMy = Int64;
    using TMyOut = Int32;

    /// <summary>
    /// Abstract shared array benchmark - Int64 to Int32.
    /// </summary>
    public class AbstractSharedBenchmark_Int64_Int32 : AbstractSharedBenchmark {
        // -- TMy ref --
        protected static ref TMyOut dstTMy => ref dstInt32;
        protected static ref TMyOut baselineTMy => ref baselineInt32;
        protected static TMy[] srcArray => srcArrayInt64;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected override void CheckResult(string name) {
            CheckResultInt32(name);
        }


        // -- Params --
        public override int ShiftAmountMin {
            get {
                //return 1;
                return -1;
            }
        }
        public override int ShiftAmountMax {
            get {
                //return 1;
                return Scalars<TMy>.BitSize + 1;
            }
        }

    }
}
