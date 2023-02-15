using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zyl.VectorTraits.Benchmarks {

    // My type.
    using TMy = Single;
    using TMyOut = Double;

    /// <summary>
    /// Abstract shared array benchmark - Single to Double.
    /// </summary>
    public class AbstractSharedBenchmark_Single_Double : AbstractSharedBenchmark {
        // -- TMy ref --
        protected static ref TMyOut dstTMy => ref dstDouble;
        protected static ref TMyOut baselineTMy => ref baselineDouble;
        protected static TMy[] srcArray => srcArraySingle;

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
