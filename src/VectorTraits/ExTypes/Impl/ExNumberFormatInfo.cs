using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zyl.VectorTraits.ExTypes.Impl {

    /// <summary>
    /// Improved <see cref="NumberFormatInfo"/> for ExType.
    /// </summary>
    internal class ExNumberFormatInfo
    {

        // private const NumberStyles InvalidNumberStyles = unchecked((NumberStyles) 0xFFFFFC00);
        private const NumberStyles InvalidNumberStyles = ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite
                                                           | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign
                                                           | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint
                                                           | NumberStyles.AllowThousands | NumberStyles.AllowExponent
                                                           | NumberStyles.AllowCurrencySymbol | NumberStyles.AllowHexSpecifier
#if NET8_0_OR_GREATER
                                                           | NumberStyles.AllowBinarySpecifier
#endif // NET8_0_OR_GREATER
            );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void ValidateParseStyleInteger(NumberStyles style)
        {
            // Check for undefined flags or using AllowHexSpecifier/AllowBinarySpecifier each with anything other than AllowLeadingWhite/AllowTrailingWhite.
            if ((style & (InvalidNumberStyles | NumberStyles.AllowHexSpecifier
#if NET8_0_OR_GREATER
                | NumberStyles.AllowBinarySpecifier
#endif // NET8_0_OR_GREATER
                )) != 0 &&
                (style & ~NumberStyles.HexNumber) != 0
#if NET8_0_OR_GREATER
                && (style & ~NumberStyles.BinaryNumber) != 0)
#endif // NET8_0_OR_GREATER
            {
                ThrowInvalid(style);

                static void ThrowInvalid(NumberStyles value)
                {
                    throw new ArgumentException(
                        (value & InvalidNumberStyles) != 0 ? SR.Argument_InvalidNumberStyles : SR.Arg_InvalidHexBinaryStyle,
                        nameof(style));
                }
            }
        }


    }

}
