using System;
using System.Collections.Generic;
using System.Text;

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// The constants of scalar (标量的常数).
    /// </summary>
    public static class ScalarConstants {

        // == BitDouble: Bit of Double ==
        /// <summary>BitDouble - `(double)0x0010000000000000 = pow(2, 52) = 4503599627370496`.</summary>
        public const long BitDouble_2Pow52 = 0x43300000_00000000; // BitConverter.DoubleToInt64Bits(Math.Pow(2, 52)).ToString("X")
        /// <summary>BitDouble - `(double)0x0018000000000000 = pow(2, 52) + pow(2, 51) = 1.5*pow(2, 52) = 6755399441055744`.</summary>
        public const long BitDouble_2Pow52_2Pow51 = 0x43380000_00000000L; // BitConverter.DoubleToInt64Bits(1.5*Math.Pow(2, 52)).ToString("X")

        // == BitSingle: Bit of Single ==
        /// <summary>BitSingle - `-pow(2, 31) = -2147483648`.</summary>
        public const int BitSingle_Negative2Pow31 = unchecked((int)0xCF000000U); // BitConverter.SingleToInt32Bits((float)-Math.Pow(2, 31)).ToString("X")
        /// <summary>BitSingle - `-pow(2, 32) = -4294967296`.</summary>
        public const int BitSingle_Negative2Pow32 = unchecked((int)0xCF800000U);

        /// <summary>BitSingle - `pow(2, 23) = 8388608`.</summary>
        public const int BitSingle_2Pow23 = 0x4B000000; // BitConverter.SingleToInt32Bits((float)Math.Pow(2, 23)).ToString("X")
        /// <summary>BitSingle - `pow(2, 31) = 2147483648`.</summary>
        public const int BitSingle_2Pow31 = 0x4F000000;
        /// <summary>BitSingle - `pow(2, 32) = 4294967296`.</summary>
        public const int BitSingle_2Pow32 = 0x4F800000;

    }
}
