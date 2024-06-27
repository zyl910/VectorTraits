using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Zyl.VectorTraits.ExTypes.Impl
{

    internal class ThrowHelper
    {

#if NETCOREAPP1_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        [DoesNotReturn]
#endif // NETCOREAPP1_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        internal static void ThrowDivideByZeroException()
        {
            throw new DivideByZeroException();
        }

#if NETCOREAPP1_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        [DoesNotReturn]
#endif // NETCOREAPP1_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        internal static void ThrowMinMaxException<T>(T min, T max)
        {
            throw new ArgumentException(string.Format(SR.Argument_MinMaxValue, min, max));
        }

#if NETCOREAPP1_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        [DoesNotReturn]
#endif // NETCOREAPP1_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        internal static void ThrowNegateTwosCompOverflow()
        {
            throw new OverflowException(SR.Overflow_NegateTwosCompNum);
        }

#if NETCOREAPP1_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        [DoesNotReturn]
#endif // NETCOREAPP1_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        internal static void ThrowOverflowException()
        {
            throw new OverflowException();
        }

#if NETCOREAPP1_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        [DoesNotReturn]
#endif // NETCOREAPP1_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        internal static void ThrowValueArgumentOutOfRange_NeedNonNegNumException()
        {
            throw new ArgumentOutOfRangeException("value", SR.ArgumentOutOfRange_NeedNonNegNum);
        }

    }
}
