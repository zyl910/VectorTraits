using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zyl.VectorTraits.Benchmarks {

    // My type.
    using TMy = Byte;

    /// <summary>
    /// Abstract shared array benchmark - Byte.
    /// </summary>
    internal class AbstractSharedBenchmark_Byte : AbstractSharedBenchmark {
        // -- TMy ref --
        protected static ref TMy dstTMy => ref dstByte;
        protected static ref TMy baselineTMy => ref baselineByte;
        protected static TMy[] srcArray => srcArrayByte;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected override void CheckResult(string name) {
            CheckResultByte(name);
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
