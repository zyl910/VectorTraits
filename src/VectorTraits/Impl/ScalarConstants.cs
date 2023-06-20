using System;
using System.Collections.Generic;
using System.Text;

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// The constants of scalar (标量的常数).
    /// </summary>
    public static class ScalarConstants {

        // == BitSingle: Bit of Single ==
        /// <summary>BitSingle - `pow(2, 31) = 2147483648`.</summary>
        public const int BitSingle_Pow2_31 = 0x4F000000; // BitConverter.SingleToInt32Bits((float)Math.Pow(2, 31)).ToString("X")
        /// <summary>BitSingle - `pow(2, 32) = 4294967296`.</summary>
        public const int BitSingle_Pow2_32 = 0x4F800000;

    }
}
