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
    /// <see cref="Vector64"/> extensions.
    /// </summary>
    public static partial class Vector64Extensions {
#if NETCOREAPP3_0_OR_GREATER

        /// <summary>Reinterprets a unsigned integer vector as a new signed integer vector (将无符号整数向量, 重新解释为有符号整数向量).</summary>
        /// <param name="value">The vector to reinterpret (将被重新解释的向量).</param>
        /// <returns>Reinterpreted as a new vector (重新解释后的新向量).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<sbyte> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector64<sbyte> value) {
            return value;
        }

        /// <inheritdoc cref="AsSigned(Vector64{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<sbyte> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector64<byte> value) {
            return value.AsSByte();
        }

        /// <inheritdoc cref="AsSigned(Vector64{sbyte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<short> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector64<short> value) {
            return value;
        }

        /// <inheritdoc cref="AsSigned(Vector64{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<short> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector64<ushort> value) {
            return value.AsInt16();
        }

        /// <inheritdoc cref="AsSigned(Vector64{sbyte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<int> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector64<int> value) {
            return value;
        }

        /// <inheritdoc cref="AsSigned(Vector64{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<int> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector64<uint> value) {
            return value.AsInt32();
        }

        /// <inheritdoc cref="AsSigned(Vector64{sbyte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<long> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector64<long> value) {
            return value;
        }

        /// <inheritdoc cref="AsSigned(Vector64{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<long> AsSigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector64<ulong> value) {
            return value.AsInt64();
        }

        /// <summary>Reinterprets a signed integer vector as a new unsigned integer vector (将有符号整数向量, 重新解释为无符号整数向量).</summary>
        /// <param name="value">The vector to reinterpret (将被重新解释的向量).</param>
        /// <returns>Reinterpreted as a new vector (重新解释后的新向量).</returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<byte> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector64<sbyte> value) {
            return value.AsByte();
        }

        /// <inheritdoc cref="AsUnsigned(Vector64{sbyte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<byte> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector64<byte> value) {
            return value;
        }

        /// <inheritdoc cref="AsUnsigned(Vector64{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<ushort> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector64<short> value) {
            return value.AsUInt16();
        }

        /// <inheritdoc cref="AsUnsigned(Vector64{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<ushort> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector64<ushort> value) {
            return value;
        }

        /// <inheritdoc cref="AsUnsigned(Vector64{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<uint> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector64<int> value) {
            return value.AsUInt32();
        }

        /// <inheritdoc cref="AsUnsigned(Vector64{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<uint> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector64<uint> value) {
            return value;
        }

        /// <inheritdoc cref="AsUnsigned(Vector64{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<ulong> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector64<long> value) {
            return value.AsUInt64();
        }

        /// <inheritdoc cref="AsUnsigned(Vector64{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector64<ulong> AsUnsigned(
#if ALLOW_EXTENSION_SIGNED
            this
#endif
                Vector64<ulong> value) {
            return value;
        }

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
