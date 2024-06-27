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

    partial struct ExInt128 {

#if BCL_TYPE_INT128

        /// <summary>Implicit converts a 128-bit unsigned integer to a <see cref="UInt128" /> value.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="UInt128" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int128(ExInt128 value) {
            return value._data;
        }

        /// <summary>Implicit converts a <see cref="UInt128" /> value to a 128-bit unsigned integer.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit unsigned integer.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ExInt128(Int128 value) {
            return Unsafe.As<Int128, ExInt128>(ref value);
        }

#if BCL_TYPE_INT128

        /// <summary>Implicit converts a 128-bit unsigned integer to a <see cref="UUInt128" /> value.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a <see cref="UUInt128" />.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt128(ExInt128 value) {
            return Unsafe.As<ExInt128, UInt128>(ref value);
        }

        /// <summary>Implicit converts a <see cref="UUInt128" /> value to a 128-bit unsigned integer.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit unsigned integer.</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ExInt128(UInt128 value) {
            return Unsafe.As<UInt128, ExInt128>(ref value);
        }

#endif // BCL_TYPE_INT128

#if BCL_TYPE_HALF

        /// <summary>Explicitly converts a <see cref="Half" /> value to a 128-bit signed integer.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit signed integer.</returns>
        public static explicit operator ExInt128(Half value) {
#if BCL_TYPE_INT128
            return (Int128)(value);
#else
            return (ExInt128)(double)(value);
#endif
        }

        /// <summary>Explicitly converts a <see cref="Half" /> value to a 128-bit signed integer, throwing an overflow exception for any values that fall outside the representable range.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns><paramref name="value" /> converted to a 128-bit signed integer.</returns>
        /// <exception cref="OverflowException"><paramref name="value" /> is not representable by <see cref="ExInt128" />.</exception>
        public static explicit operator checked ExInt128(Half value) {
#if BCL_TYPE_INT128
            return checked((Int128)(value));
#else
            return checked((ExInt128)(double)(value));
#endif
        }

#endif // BCL_TYPE_HALF

#endif

    }

}
