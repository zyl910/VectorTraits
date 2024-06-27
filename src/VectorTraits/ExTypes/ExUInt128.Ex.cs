#if NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
#define BCL_ATTR_NULL
#endif // NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
#if NET5_0_OR_GREATER
#define BCL_TYPE_HALF
#endif // NET5_0_OR_GREATER
#if NET7_0_OR_GREATER
#define BCL_TYPE_INT128
#endif // NET7_0_OR_GREATER

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zyl.VectorTraits.ExTypes {

    partial struct ExUInt128 {

#if BCL_TYPE_INT128

        /// <summary>Implicit converts a 128-bit unsigned integer to a <see cref="UInt128" /> value.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="UInt128" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt128(ExUInt128 value) {
            return value._data;
        }

        /// <summary>Implicit converts a <see cref="UInt128" /> value to a 128-bit unsigned integer.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit unsigned integer.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ExUInt128(UInt128 value) {
            return Unsafe.As<UInt128, ExUInt128>(ref value);
        }

#if BCL_TYPE_INT128

        /// <summary>Implicit converts a 128-bit unsigned integer to a <see cref="Int128" /> value.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="Int128" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int128(ExUInt128 value) {
            return Unsafe.As<ExUInt128, Int128>(ref value);
        }

        /// <summary>Implicit converts a <see cref="Int128" /> value to a 128-bit unsigned integer.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit unsigned integer.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ExUInt128(Int128 value) {
            return Unsafe.As<Int128, ExUInt128>(ref value);
        }

#endif // BCL_TYPE_INT128

#if BCL_TYPE_HALF

        /// <summary>Explicitly converts a <see cref="Half" /> value to a 128-bit unsigned integer.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit unsigned integer.</returns>
        public static explicit operator ExUInt128(Half value) {
#if BCL_TYPE_INT128
            return (UInt128)(value);
#else
            return (ExUInt128)(double)(value);
#endif
        }

        /// <summary>Explicitly converts a <see cref="Half" /> value to a 128-bit unsigned integer, throwing an overflow exception for any values that fall outside the representable range.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit unsigned integer.</returns>
        /// <exception cref="OverflowException"><paramref name="value" /> is not representable by <see cref="ExUInt128" />.</exception>
        public static explicit operator checked ExUInt128(Half value) {
#if BCL_TYPE_INT128
            return checked((UInt128)(value));
#else
            return checked((ExUInt128)(double)(value));
#endif
        }

#endif // BCL_TYPE_HALF

#endif

    }

}
