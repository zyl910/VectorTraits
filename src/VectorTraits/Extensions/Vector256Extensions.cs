#if NET7_0_OR_GREATER
#define BCL_TYPE_INT128
#endif // NET7_0_OR_GREATER

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
using Zyl.VectorTraits.ExTypes;

namespace Zyl.VectorTraits.Extensions {
    /// <summary>
    /// <see cref="Vector256"/> extensions.
    /// </summary>
    public static partial class Vector256Extensions {
#if NETCOREAPP3_0_OR_GREATER

        /// <summary>
        /// Reinterprets a <see cref="Vector256{T}"/> as a new <see cref="Vector{T}"/> (将 <see cref="Vector256{T}"/> 重新解释为新的 <see cref="Vector{T}"/>).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="value">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>value reinterpreted as a new <see cref="Vector{T}"/> (重新解释后新的 <see cref="Vector{T}"/>)值.</returns>
        /// <seealso cref="Vector256.AsVector{T}(Vector256{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<T> AsVector<T>(
#if ALLOW_EXTENSION
            this
#endif
                Vector256<T> value) where T : struct {
            return Vectors.AsVector(value);
        }

        /// <summary>
        /// Reinterprets a <see cref="Vector{T}"/> as a new <see cref="Vector256{T}"/> (将 <see cref="Vector{T}"/> 重新解释为新的 <see cref="Vector256{T}"/>).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="value">The vector to reinterpret (要重新解释的向量).</param>
        /// <returns>value reinterpreted as a new <see cref="Vector256{T}"/> (重新解释后新的 <see cref="Vector256{T}"/>)值.</returns>
        /// <seealso cref="Vector256.AsVector256{T}(Vector{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<T> AsVector256<T>(
#if ALLOW_EXTENSION
            this
#endif
                Vector<T> value) where T : struct {
            return Vectors.AsVector256(value);
        }

        /// <summary>Reinterprets a unsigned integer vector as a new signed integer vector (将无符号整数向量, 重新解释为有符号整数向量).</summary>
        /// <param name="value">The vector to reinterpret (将被重新解释的向量).</param>
        /// <returns>Reinterpreted as a new vector (重新解释后的新向量).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector256<sbyte> value) {
            return value;
        }

        /// <inheritdoc cref="AsSigned(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector256<byte> value) {
            return value.AsSByte();
        }

        /// <inheritdoc cref="AsSigned(Vector256{sbyte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector256<short> value) {
            return value;
        }

        /// <inheritdoc cref="AsSigned(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector256<ushort> value) {
            return value.AsInt16();
        }

        /// <inheritdoc cref="AsSigned(Vector256{sbyte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector256<int> value) {
            return value;
        }

        /// <inheritdoc cref="AsSigned(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector256<uint> value) {
            return value.AsInt32();
        }

        /// <inheritdoc cref="AsSigned(Vector256{sbyte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector256<long> value) {
            return value;
        }

        /// <inheritdoc cref="AsSigned(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector256<ulong> value) {
            return value.AsInt64();
        }

        /// <inheritdoc cref="AsSigned(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ExInt128> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector256<ExInt128> value) {
            return value;
        }

        /// <inheritdoc cref="AsSigned(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ExInt128> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector256<ExUInt128> value) {
            return value.ExAsExInt128();
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="AsSigned(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<Int128> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector256<Int128> value) {
            return value;
        }

        /// <inheritdoc cref="AsSigned(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<Int128> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector256<UInt128> value) {
            return value.ExAsInt128();
        }

#endif // BCL_TYPE_INT128

        /// <summary>Reinterprets a signed integer vector as a new unsigned integer vector (将有符号整数向量, 重新解释为无符号整数向量).</summary>
        /// <param name="value">The vector to reinterpret (将被重新解释的向量).</param>
        /// <returns>Reinterpreted as a new vector (重新解释后的新向量).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector256<sbyte> value) {
            return value.AsByte();
        }

        /// <inheritdoc cref="AsUnsigned(Vector256{sbyte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector256<byte> value) {
            return value;
        }

        /// <inheritdoc cref="AsUnsigned(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector256<short> value) {
            return value.AsUInt16();
        }

        /// <inheritdoc cref="AsUnsigned(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector256<ushort> value) {
            return value;
        }

        /// <inheritdoc cref="AsUnsigned(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector256<int> value) {
            return value.AsUInt32();
        }

        /// <inheritdoc cref="AsUnsigned(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector256<uint> value) {
            return value;
        }

        /// <inheritdoc cref="AsUnsigned(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector256<long> value) {
            return value.AsUInt64();
        }

        /// <inheritdoc cref="AsUnsigned(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector256<ulong> value) {
            return value;
        }

        /// <inheritdoc cref="AsUnsigned(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ExUInt128> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector256<ExInt128> value) {
            return value.ExAsExUInt128();
        }

        /// <inheritdoc cref="AsUnsigned(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ExUInt128> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector256<ExUInt128> value) {
            return value;
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="AsUnsigned(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<UInt128> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector256<Int128> value) {
            return value.ExAsUInt128();
        }

        /// <inheritdoc cref="AsUnsigned(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<UInt128> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector256<UInt128> value) {
            return value;
        }

#endif // BCL_TYPE_INT128

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
