using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Zyl.VectorTraits.ExTypes;

namespace Zyl.VectorTraits.Benchmarks {

    // My type.
    using TMy = ExInt128;

    /// <summary>
    /// Abstract shared array benchmark - Int128.
    /// </summary>
    public class AbstractSharedBenchmark_Int128 : AbstractSharedBenchmark {
        // -- TMy ref --
        protected static ref TMy dstTMy => ref dstInt128;
        protected static ref TMy baselineTMy => ref baselineInt128;
        protected static TMy[] srcArray => srcArrayInt128;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected override void CheckResult(string name) {
            CheckResultInt128(name);
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
