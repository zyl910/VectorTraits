using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zyl.VectorTraits.Benchmarks {

    // My type.
    using TMy = UInt16;
    using TMyOut = Byte;

    /// <summary>
    /// Abstract shared array benchmark - UInt16 to Byte.
    /// </summary>
    public class AbstractSharedBenchmark_UInt16_Byte : AbstractSharedBenchmark {
        // -- TMy ref --
        protected static ref TMyOut dstTMy => ref dstByte;
        protected static ref TMyOut baselineTMy => ref baselineByte;
        protected static TMy[] srcArray => srcArrayUInt16;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected override void CheckResult(string name) {
            CheckResultByte(name);
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
