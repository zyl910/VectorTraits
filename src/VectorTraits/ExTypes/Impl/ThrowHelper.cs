#if NET7_0_OR_GREATER
#define GENERICS_MATH
#endif // NET7_0_OR_GREATER

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using Zyl.VectorTraits;

namespace Zyl.VectorTraits.ExTypes.Impl {

    internal class ThrowHelper {

#if NETCOREAPP1_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        [DoesNotReturn]
#endif // NETCOREAPP1_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        internal static void ThrowDivideByZeroException() {
            throw new DivideByZeroException();
        }

#if NETCOREAPP1_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        [DoesNotReturn]
#endif // NETCOREAPP1_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        internal static void ThrowFormatException_BadFormatSpecifier() {
            throw new FormatException();
        }

#if NETCOREAPP1_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        [DoesNotReturn]
#endif // NETCOREAPP1_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        internal static void ThrowMinMaxException<T>(T min, T max) {
            throw new ArgumentException(string.Format(SR.Argument_MinMaxValue, min, max));
        }

#if NETCOREAPP1_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        [DoesNotReturn]
#endif // NETCOREAPP1_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        internal static void ThrowNegateTwosCompOverflow() {
            throw new OverflowException(SR.Overflow_NegateTwosCompNum);
        }

#if NETCOREAPP1_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        [DoesNotReturn]
#endif // NETCOREAPP1_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        internal static void ThrowOverflowException() {
            throw new OverflowException();
        }

#if NETCOREAPP1_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        [DoesNotReturn]
#endif // NETCOREAPP1_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        internal static void ThrowValueArgumentOutOfRange_NeedNonNegNumException() {
            throw new ArgumentOutOfRangeException("value", SR.ArgumentOutOfRange_NeedNonNegNum);
        }

#if NETCOREAPP1_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        [DoesNotReturn]
#endif // NETCOREAPP1_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        internal static void ThrowNegative<T>(T value, string? paramName) {
            throw new ArgumentOutOfRangeException(paramName, value, string.Format(SR.ArgumentOutOfRange_Generic_MustBeNonNegative, paramName, value));
        }

        /// <summary>Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is negative.</summary>
        /// <param name="value">The argument to validate as non-negative.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        public static void ThrowIfNegative<T>(T value,
#if NETCOREAPP3_0_OR_GREATER
                [CallerArgumentExpression(nameof(value))]
#endif // NETCOREAPP3_0_OR_GREATER
                string? paramName = null)
#if GENERICS_MATH
                where T : INumberBase<T>
#else
                where T : struct
#endif // GENERICS_MATH
                {
#if NET8_0_OR_GREATER
            ArgumentOutOfRangeException.ThrowIfNegative(value, paramName);
#else
#if GENERICS_MATH
            bool flag = T.IsNegative(value);
#else
            bool flag = Scalars.GetDoubleFrom(value) < 0;
#endif // GENERICS_MATH
            if (flag)
                ThrowNegative(value, paramName);
#endif // NET8_0_OR_GREATER
        }

    }
}
