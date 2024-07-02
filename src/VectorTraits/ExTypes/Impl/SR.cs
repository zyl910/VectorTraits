using System;
using System.Collections.Generic;
using System.Text;

namespace Zyl.VectorTraits.ExTypes.Impl {
    internal static class SR {

        public static string Arg_MustBeExInt128 => "The parameter must be ExInt128.";
        public static string Arg_MustBeExUInt128 => "The parameter must be ExUInt128.";
        public static string Arg_InvalidHexBinaryStyle => "With the AllowHexSpecifier or AllowBinarySpecifier bit set in the enum bit field, the only other valid bits that can be combined into the enum value must be AllowLeadingWhite and AllowTrailingWhite.";

        public static string Argument_InvalidNumberStyles => "An undefined NumberStyles value is being used.";

        public static string Argument_MinMaxValue => "'{0}' cannot be greater than {1}.";

        public static string ArgumentOutOfRange_NeedNonNegNum => "value must be non-negative.";
        public static string ArgumentOutOfRange_Generic_MustBeNonNegative => "The parameter `{0}` value({1}) must be non-negative.";

        public static string Format_InvalidString => "Input string was not in a correct format.";
        public static string Format_InvalidStringWithValue => "The input string '{0}' was not in a correct format.";

        public static string Overflow_Byte => "Numeric overflow, out of range of Byte type.";
        public static string Overflow_Decimal => "Numeric overflow, out of range of Decimal type.";
        public static string Overflow_SByte => "Numeric overflow, out of range of SByte type.";

        public static string Overflow_NegateTwosCompNum => "Negating the minimum value of a twos complement number is invalid.";

    }
}
