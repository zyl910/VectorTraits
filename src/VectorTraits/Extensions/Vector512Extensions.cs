#if NETCOREAPP3_0_OR_GREATER

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
    /// <see cref="Vector512"/> extensions.
    /// </summary>
    public static partial class Vector512Extensions {
#if NET8_0_OR_GREATER

        /// <summary>Reinterprets a unsigned integer vector as a new signed integer vector (将无符号整数向量, 重新解释为有符号整数向量).</summary>
        /// <param name="value">The vector to reinterpret (将被重新解释的向量).</param>
        /// <returns>Reinterpreted as a new vector (重新解释后的新向量).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector512<sbyte> value) {
            return value;
        }

        /// <inheritdoc cref="AsSigned(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector512<byte> value) {
            return value.AsSByte();
        }

        /// <inheritdoc cref="AsSigned(Vector512{sbyte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector512<short> value) {
            return value;
        }

        /// <inheritdoc cref="AsSigned(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector512<ushort> value) {
            return value.AsInt16();
        }

        /// <inheritdoc cref="AsSigned(Vector512{sbyte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector512<int> value) {
            return value;
        }

        /// <inheritdoc cref="AsSigned(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector512<uint> value) {
            return value.AsInt32();
        }

        /// <inheritdoc cref="AsSigned(Vector512{sbyte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector512<long> value) {
            return value;
        }

        /// <inheritdoc cref="AsSigned(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector512<ulong> value) {
            return value.AsInt64();
        }

        /// <summary>Reinterprets a signed integer vector as a new unsigned integer vector (将有符号整数向量, 重新解释为无符号整数向量).</summary>
        /// <param name="value">The vector to reinterpret (将被重新解释的向量).</param>
        /// <returns>Reinterpreted as a new vector (重新解释后的新向量).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector512<sbyte> value) {
            return value.AsByte();
        }

        /// <inheritdoc cref="AsUnsigned(Vector512{sbyte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector512<byte> value) {
            return value;
        }

        /// <inheritdoc cref="AsUnsigned(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector512<short> value) {
            return value.AsUInt16();
        }

        /// <inheritdoc cref="AsUnsigned(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector512<ushort> value) {
            return value;
        }

        /// <inheritdoc cref="AsUnsigned(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector512<int> value) {
            return value.AsUInt32();
        }

        /// <inheritdoc cref="AsUnsigned(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector512<uint> value) {
            return value;
        }

        /// <inheritdoc cref="AsUnsigned(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector512<long> value) {
            return value.AsUInt64();
        }

        /// <inheritdoc cref="AsUnsigned(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector512<ulong> value) {
            return value;
        }

#endif // NET8_0_OR_GREATER
    }
}
