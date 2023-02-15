using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zyl.VectorTraits.Benchmarks {

    // My type.
    using TMy = SByte;
    using TMyOut = Int16;

    /// <summary>
    /// Abstract shared array benchmark - SByte to Int16.
    /// </summary>
    public class AbstractSharedBenchmark_SByte_Int16 : AbstractSharedBenchmark {
        // -- TMy ref --
        protected static ref TMyOut dstTMy => ref dstInt16;
        protected static ref TMyOut baselineTMy => ref baselineInt16;
        protected static TMy[] srcArray => srcArraySByte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected override void CheckResult(string name) {
            CheckResultInt16(name);
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
