using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zyl.VectorTraits.Benchmarks {

    // My type.
    using TMy = Int16;
    using TMyOut = SByte;

    /// <summary>
    /// Abstract shared array benchmark - Int16 to SByte.
    /// </summary>
    public class AbstractSharedBenchmark_Int16_SByte : AbstractSharedBenchmark {
        // -- TMy ref --
        protected static ref TMyOut dstTMy => ref dstSByte;
        protected static ref TMyOut baselineTMy => ref baselineSByte;
        protected static TMy[] srcArray => srcArrayInt16;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected override void CheckResult(string name) {
            CheckResultSByte(name);
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
