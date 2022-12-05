#if NETCOREAPP3_0_OR_GREATER
#if NET5_0_OR_GREATER
#else
#define ALLOW_EXTENSION
#endif // NET5_0_OR_GREATER

#endif // NETCOREAPP3_0_OR_GREATER

using System;
using System.Numerics;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif

namespace Zyl.VectorTraits.Extensions {
    /// <summary>
    /// <see cref="Vector256"/> extensions.
    /// </summary>
    public static class Vector256Extensions {
#if NETCOREAPP3_0_OR_GREATER

        /// <summary>Reinterprets a <see cref="Vector{T}" /> as a new <see cref="Vector256{T}" />.</summary>
        /// <typeparam name="T">The type of the vectors.</typeparam>
        /// <param name="value">The vector to reinterpret.</param>
        /// <returns><paramref name="value" /> reinterpreted as a new <see cref="Vector256{T}" />.</returns>
        public static Vector256<T> AsVector256<T>(
#if ALLOW_EXTENSION
            this
#endif
                Vector<T> value) where T : struct {
            return value.AsVector256();
        }

        /// <summary>Reinterprets a <see cref="Vector256{T}" /> as a new <see cref="Vector{T}" />.</summary>
        /// <typeparam name="T">The type of the vectors.</typeparam>
        /// <param name="value">The vector to reinterpret.</param>
        /// <returns><paramref name="value" /> reinterpreted as a new <see cref="Vector{T}" />.</returns>
        public static Vector<T> AsVector<T>(
#if ALLOW_EXTENSION
            this
#endif
                Vector256<T> value) where T : struct {
            return Vectors.AsVector(value);
        }

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
