#if NETCOREAPP3_0_OR_GREATER
#if NET5_0_OR_GREATER
#else
#define ALLOW_EXTENSION
#endif // NET5_0_OR_GREATER

#if NETX_0_OR_GREATER
#else
#define ALLOW_EXTENSION_SIGNED
#endif // NETX_0_OR_GREATER

#endif // NETCOREAPP3_0_OR_GREATER

using System;
using System.Numerics;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif

namespace Zyl.VectorTraits.Extensions {
    /// <summary>
    /// <see cref="Vector128"/> extensions.
    /// </summary>
    public static class Vector128Extensions {
#if NETCOREAPP3_0_OR_GREATER

        /// <summary>Reinterprets a <see cref="Vector{T}" /> as a new <see cref="Vector128{T}" />.</summary>
        /// <typeparam name="T">The type of the vectors.</typeparam>
        /// <param name="value">The vector to reinterpret.</param>
        /// <returns><paramref name="value" /> reinterpreted as a new <see cref="Vector128{T}" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<T> AsVector128<T>(
#if ALLOW_EXTENSION
            this
#endif
                Vector<T> value) where T : struct {
            return Vectors.AsVector128(value);
        }

        /// <summary>Reinterprets a <see cref="Vector128{T}" /> as a new <see cref="Vector{T}" />.</summary>
        /// <typeparam name="T">The type of the vectors.</typeparam>
        /// <param name="value">The vector to reinterpret.</param>
        /// <returns><paramref name="value" /> reinterpreted as a new <see cref="Vector{T}" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<T> AsVector<T>(
#if ALLOW_EXTENSION
            this
#endif
                Vector128<T> value) where T : struct {
            return Vectors.AsVector(value);
        }


        /// <summary>Reinterprets a unsigned integer vector as a new signed integer vector (将无符号整数向量, 重新解释为有符号整数向量).</summary>
        /// <param name="value">The vector to reinterpret (将被重新解释的向量).</param>
        /// <returns>Reinterpreted as a new vector (重新解释后的新向量).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector128<sbyte> value) {
            return value;
        }

        /// <inheritdoc cref="AsSigned(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector128<byte> value) {
            return value.AsSByte();
        }

        /// <inheritdoc cref="AsSigned(Vector128{sbyte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector128<short> value) {
            return value;
        }

        /// <inheritdoc cref="AsSigned(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector128<ushort> value) {
            return value.AsInt16();
        }

        /// <inheritdoc cref="AsSigned(Vector128{sbyte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector128<int> value) {
            return value;
        }

        /// <inheritdoc cref="AsSigned(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector128<uint> value) {
            return value.AsInt32();
        }

        /// <inheritdoc cref="AsSigned(Vector128{sbyte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector128<long> value) {
            return value;
        }

        /// <inheritdoc cref="AsSigned(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector128<ulong> value) {
            return value.AsInt64();
        }

        /// <summary>Reinterprets a signed integer vector as a new unsigned integer vector (将有符号整数向量, 重新解释为无符号整数向量).</summary>
        /// <param name="value">The vector to reinterpret (将被重新解释的向量).</param>
        /// <returns>Reinterpreted as a new vector (重新解释后的新向量).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector128<sbyte> value) {
            return value.AsByte();
        }

        /// <inheritdoc cref="AsUnsigned(Vector128{sbyte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector128<byte> value) {
            return value;
        }

        /// <inheritdoc cref="AsUnsigned(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector128<short> value) {
            return value.AsUInt16();
        }

        /// <inheritdoc cref="AsUnsigned(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector128<ushort> value) {
            return value;
        }

        /// <inheritdoc cref="AsUnsigned(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector128<int> value) {
            return value.AsUInt32();
        }

        /// <inheritdoc cref="AsUnsigned(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector128<uint> value) {
            return value;
        }

        /// <inheritdoc cref="AsUnsigned(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector128<long> value) {
            return value.AsUInt64();
        }

        /// <inheritdoc cref="AsUnsigned(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector128<ulong> value) {
            return value;
        }

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
