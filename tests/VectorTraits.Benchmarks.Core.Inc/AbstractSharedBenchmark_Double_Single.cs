using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zyl.VectorTraits.Benchmarks {

    // My type.
    using TMy = Double;
    using TMyOut = Single;

    /// <summary>
    /// Abstract shared array benchmark - Double to Single.
    /// </summary>
    public class AbstractSharedBenchmark_Double_Single : AbstractSharedBenchmark {
        // -- TMy ref --
        protected static ref TMyOut dstTMy => ref dstSingle;
        protected static ref TMyOut baselineTMy => ref baselineSingle;
        protected static TMy[] srcArray => srcArrayDouble;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected override void CheckResult(string name) {
            CheckResultSingle(name);
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
