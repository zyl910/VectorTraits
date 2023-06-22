using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zyl.VectorTraits.Benchmarks {

    // My type.
    using TMy = UInt64;
    using TMyOut = Double;

    /// <summary>
    /// Abstract shared array benchmark - UInt64 to Double.
    /// </summary>
    public class AbstractSharedBenchmark_UInt64_Double : AbstractSharedBenchmark {
        // -- TMy ref --
        protected static ref TMyOut dstTMy => ref dstDouble;
        protected static ref TMyOut baselineTMy => ref baselineDouble;
        protected static TMy[] srcArray => srcArrayUInt64;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected override void CheckResult(string name) {
            CheckResultDouble(name);
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
