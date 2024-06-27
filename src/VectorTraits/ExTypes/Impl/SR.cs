using System;
using System.Collections.Generic;
using System.Text;

namespace Zyl.VectorTraits.ExTypes.Impl {
    internal static class SR {

        public static string Arg_MustBeExInt128 => "The parameter must be ExInt128.";
        public static string Arg_MustBeExUInt128 => "The parameter must be ExUInt128.";
        public static string Arg_InvalidHexBinaryStyle => "Invalid hex binary style.";

        public static string Argument_InvalidNumberStyles => "Invalid number styles.";

        public static string Argument_MinMaxValue => "Parameter is out of range [{0}, {1}].";

        public static string ArgumentOutOfRange_NeedNonNegNum => "value must be non-negative.";

        public static string Overflow_Decimal => "Numeric overflow, out of range of Decimal type.";

        public static string Overflow_NegateTwosCompNum => "Negating the minimum value of a twos complement number is invalid.";

    }
}
