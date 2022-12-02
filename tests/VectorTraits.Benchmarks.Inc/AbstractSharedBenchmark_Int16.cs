﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zyl.VectorTraits.Benchmarks {

    // My type.
    using TMy = Int16;

    /// <summary>
    /// Abstract shared array benchmark.
    /// </summary>
    internal class AbstractSharedBenchmark_Int16 : AbstractSharedBenchmark {
        // -- TMy ref --
        protected static ref TMy dstTMy => ref dstInt16;
        protected static ref TMy baselineTMy => ref baselineInt16;
        protected static TMy[] srcArray => srcArrayInt16;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected void CheckResult(string name) {
            CheckResultInt16(name);
        }


    }
}
