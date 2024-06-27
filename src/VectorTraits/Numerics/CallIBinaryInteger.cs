using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Zyl.VectorTraits.Numerics {
#if NET7_0_OR_GREATER

    /// <summary>
    /// Call <see cref="IBinaryInteger{TSelf}"/> (调用 <see cref="IBinaryInteger{TSelf}"/>).
    /// </summary>
    public static class CallIBinaryInteger {

        /// <inheritdoc cref="IBinaryInteger{TSelf}.TryReadBigEndian(ReadOnlySpan{byte}, bool, out TSelf)"/>
        /// <typeparam name="TSelf">Target type (目标类型).</typeparam>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBigEndian<TSelf>(ReadOnlySpan<byte> source, bool isUnsigned, out TSelf value) where TSelf : IBinaryInteger<TSelf> {
            return TSelf.TryReadBigEndian(source, isUnsigned, out value);
        }

        /// <inheritdoc cref="IBinaryInteger{TSelf}.TryReadLittleEndian(ReadOnlySpan{byte}, bool, out TSelf)"/>
        /// <typeparam name="TSelf">Target type (目标类型).</typeparam>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadLittleEndian<TSelf>(ReadOnlySpan<byte> source, bool isUnsigned, out TSelf value) where TSelf : IBinaryInteger<TSelf> {
            return TSelf.TryReadLittleEndian(source, isUnsigned, out value);
        }

        /// <inheritdoc cref="IBinaryInteger{TSelf}.GetShortestBitLength()"/>
        /// <typeparam name="TSelf">Target type (目标类型).</typeparam>
        /// <param name="value">The value (值).</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int GetShortestBitLength<TSelf>(TSelf value) where TSelf : IBinaryInteger<TSelf> {
            return value.GetShortestBitLength();
        }

        /// <inheritdoc cref="IBinaryInteger{TSelf}.TryWriteLittleEndian(Span{byte}, out int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLittleEndian<TSelf>(TSelf value, Span<byte> destination, out int bytesWritten) where TSelf : IBinaryInteger<TSelf> {
            return value.TryWriteLittleEndian(destination, out bytesWritten);
        }

        /// <inheritdoc cref="IBinaryInteger{TSelf}.TryWriteBigEndian(Span{byte}, out int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBigEndian<TSelf>(TSelf value, Span<byte> destination, out int bytesWritten) where TSelf : IBinaryInteger<TSelf> {
            return value.TryWriteBigEndian(destination, out bytesWritten);
        }

    }

#endif // NET7_0_OR_GREATER
}
