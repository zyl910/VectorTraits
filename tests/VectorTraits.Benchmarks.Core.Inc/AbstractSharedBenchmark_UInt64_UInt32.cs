using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zyl.VectorTraits.Benchmarks {

    // My type.
    using TMy = UInt64;
    using TMyOut = UInt32;

    /// <summary>
    /// Abstract shared array benchmark - UInt64 to UInt32.
    /// </summary>
    public class AbstractSharedBenchmark_UInt64_UInt32 : AbstractSharedBenchmark {
        // -- TMy ref --
        protected static ref TMyOut dstTMy => ref dstUInt32;
        protected static ref TMyOut baselineTMy => ref baselineUInt32;
        protected static TMy[] srcArray => srcArrayUInt64;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected override void CheckResult(string name) {
            CheckResultUInt32(name);
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
