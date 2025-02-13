﻿#if NET7_0_OR_GREATER
#define BCL_TYPE_INT128
#endif // NET7_0_OR_GREATER

#if NETX_0_OR_GREATER
#else
#define ALLOW_EXTENSION_SIGNED
#endif // NETX_0_OR_GREATER

using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using Zyl.VectorTraits.Extensions.SameW;
using Zyl.VectorTraits.ExTypes;

namespace Zyl.VectorTraits.Extensions {
    /// <summary>
    /// <see cref="Vector"/> extensions.
    /// </summary>
    public static partial class VectorExtensions {

        /// <summary>Reinterprets a unsigned integer vector as a new signed integer vector (将无符号整数向量, 重新解释为有符号整数向量).</summary>
        /// <param name="value">The vector to reinterpret (将被重新解释的向量).</param>
        /// <returns>Reinterpreted as a new vector (重新解释后的新向量).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector<sbyte> value) {
            return value;
        }

        /// <inheritdoc cref="AsSigned(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector<byte> value) {
            return value.AsSByte();
        }

        /// <inheritdoc cref="AsSigned(Vector{sbyte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector<short> value) {
            return value;
        }

        /// <inheritdoc cref="AsSigned(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector<ushort> value) {
            return value.AsInt16();
        }

        /// <inheritdoc cref="AsSigned(Vector{sbyte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector<int> value) {
            return value;
        }

        /// <inheritdoc cref="AsSigned(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector<uint> value) {
            return value.AsInt32();
        }

        /// <inheritdoc cref="AsSigned(Vector{sbyte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector<long> value) {
            return value;
        }

        /// <inheritdoc cref="AsSigned(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector<ulong> value) {
            return value.AsInt64();
        }

        /// <inheritdoc cref="AsSigned(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ExInt128> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector<ExInt128> value) {
            return value;
        }

        /// <inheritdoc cref="AsSigned(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ExInt128> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector<ExUInt128> value) {
            return value.ExAsExInt128();
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="AsSigned(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<Int128> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector<Int128> value) {
            return value;
        }

        /// <inheritdoc cref="AsSigned(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<Int128> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector<UInt128> value) {
            return value.ExAsInt128();
        }

#endif // BCL_TYPE_INT128

        /// <summary>Reinterprets a signed integer vector as a new unsigned integer vector (将有符号整数向量, 重新解释为无符号整数向量).</summary>
        /// <param name="value">The vector to reinterpret (将被重新解释的向量).</param>
        /// <returns>Reinterpreted as a new vector (重新解释后的新向量).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector<sbyte> value) {
            return value.AsByte();
        }

        /// <inheritdoc cref="AsUnsigned(Vector{sbyte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector<byte> value) {
            return value;
        }

        /// <inheritdoc cref="AsUnsigned(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector<short> value) {
            return value.AsUInt16();
        }

        /// <inheritdoc cref="AsUnsigned(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector<ushort> value) {
            return value;
        }

        /// <inheritdoc cref="AsUnsigned(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector<int> value) {
            return value.AsUInt32();
        }

        /// <inheritdoc cref="AsUnsigned(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector<uint> value) {
            return value;
        }

        /// <inheritdoc cref="AsUnsigned(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector<long> value) {
            return value.AsUInt64();
        }

        /// <inheritdoc cref="AsUnsigned(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector<ulong> value) {
            return value;
        }

        /// <inheritdoc cref="AsUnsigned(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ExUInt128> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector<ExInt128> value) {
            return value.ExAsExUInt128();
        }

        /// <inheritdoc cref="AsUnsigned(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ExUInt128> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector<ExUInt128> value) {
            return value;
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="AsUnsigned(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<UInt128> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector<Int128> value) {
            return value.ExAsUInt128();
        }

        /// <inheritdoc cref="AsUnsigned(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<UInt128> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector<UInt128> value) {
            return value;
        }

#endif // BCL_TYPE_INT128

    }
}
