using System;
using System.Collections.Generic;
using System.Text;

namespace Zyl.VectorTraits.ExTypes.Impl {

    /// <summary>
    /// Extensions of <see cref="Encoding"/>
    /// </summary>
    internal static class EncodingExtensions {

        /// <inheritdoc cref="Encoding.TryGetBytes(ReadOnlySpan{char}, Span{byte}, out int)"/>
        public static bool TryGetBytes(
#if !NET8_0_OR_GREATER
            this
#endif // NET8_0_OR_GREATER
            Encoding athis, ReadOnlySpan<char> chars, Span<byte> bytes, out int bytesWritten) {
#if NET8_0_OR_GREATER
            return athis.TryGetBytes(chars, bytes, out bytesWritten);
#elif  NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
            bytesWritten = athis.GetBytes(chars, bytes);
            return bytesWritten <= bytes.Length;
#else
            char[] charBuffer = chars.ToArray();
            int n = athis.GetByteCount(charBuffer);
            if (n > bytes.Length) {
                bytesWritten = 0;
                return false;
            }
            byte[] buffer = new byte[n + 1];
            bytesWritten = athis.GetBytes(charBuffer, 0, charBuffer.Length, buffer, 0);
            Span<byte> bufferCut = buffer.AsSpan().Slice(0, bytesWritten);
            bufferCut.CopyTo(bytes);
            return true;
#endif // NET8_0_OR_GREATER
        }

    }

}
