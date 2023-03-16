using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zyl.VectorTraits.Benchmarks {

    // My type.
    using TMy = Int32;
    using TMyOut = UInt16;

    /// <summary>
    /// Abstract shared array benchmark - Int32 to UInt16.
    /// </summary>
    public class AbstractSharedBenchmark_Int32_UInt16 : AbstractSharedBenchmark {
        // -- TMy ref --
        protected static ref TMyOut dstTMy => ref dstUInt16;
        protected static ref TMyOut baselineTMy => ref baselineUInt16;
        protected static TMy[] srcArray => srcArrayInt32;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected override void CheckResult(string name) {
            CheckResultUInt16(name);
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
