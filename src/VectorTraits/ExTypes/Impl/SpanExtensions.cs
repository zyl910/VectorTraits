using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Zyl.VectorTraits.ExTypes.Impl {
    /// <summary>
    /// Extensions of <see cref="Span{T}"/>
    /// </summary>
    internal static partial class SpanExtensions {

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static bool EqualsOrdinalIgnoreCase(this ReadOnlySpan<char> span, ReadOnlySpan<char> value) {
            if (span.Length != value.Length)
                return false;
            if (value.Length == 0)  // span.Length == value.Length == 0
                return true;
            return Ordinal.EqualsIgnoreCase(ref MemoryMarshal.GetReference(span), ref MemoryMarshal.GetReference(value), span.Length);
        }

        /*
        /// <summary>
        /// Determines whether the beginning of the <paramref name="span"/> matches the specified <paramref name="value"/> when compared using the specified <paramref name="comparisonType"/> option.
        /// </summary>
        /// <param name="span">The source span.</param>
        /// <param name="value">The sequence to compare to the beginning of the source span.</param>
        /// <param name="comparisonType">One of the enumeration values that determines how the <paramref name="span"/> and <paramref name="value"/> are compared.</param>
        internal static bool StartsWithUtf8(this ReadOnlySpan<byte> span, ReadOnlySpan<byte> value, StringComparison comparisonType) {
            //string.CheckStringComparison(comparisonType);

            switch (comparisonType) {
                case StringComparison.CurrentCulture:
                case StringComparison.CurrentCultureIgnoreCase: {
                        return CultureInfo.CurrentCulture.CompareInfo.IsPrefixUtf8(span, value, string.GetCaseCompareOfComparisonCulture(comparisonType));
                    }

                case StringComparison.InvariantCulture:
                case StringComparison.InvariantCultureIgnoreCase: {
                        return CompareInfo.Invariant.IsPrefixUtf8(span, value, string.GetCaseCompareOfComparisonCulture(comparisonType));
                    }

                case StringComparison.Ordinal: {
                        return span.StartsWith(value);
                    }

                default: {
                        Debug.Assert(comparisonType == StringComparison.OrdinalIgnoreCase);
                        return span.StartsWithOrdinalIgnoreCaseUtf8(value);
                    }
            }
        }
        */

        internal static ReadOnlySpan<byte> TrimUtf8(this ReadOnlySpan<byte> span) {
            // Assume that in most cases input doesn't need trimming
            //
            // Since `DecodeFromUtf8` and `DecodeLastFromUtf8` return `Rune.ReplacementChar`
            // on failure and that is not whitespace, we can safely treat it as no trimming
            // and leave failure handling up to the caller instead

            if (span.Length == 0) {
                return span;
            }

#if NETCOREAPP3_0_OR_GREATER
            Debug.Assert(!Rune.IsWhiteSpace(Rune.ReplacementChar));

            _ = Rune.DecodeFromUtf8(span, out Rune first, out int firstBytesConsumed);

            if (Rune.IsWhiteSpace(first)) {
                span = span[firstBytesConsumed..];
                return TrimFallback(span);
            }

            _ = Rune.DecodeLastFromUtf8(span, out Rune last, out int lastBytesConsumed);

            if (Rune.IsWhiteSpace(last)) {
                span = span[..^lastBytesConsumed];
                return TrimFallback(span);
            }

            return span;

            [MethodImpl(MethodImplOptions.NoInlining)]
            static ReadOnlySpan<byte> TrimFallback(ReadOnlySpan<byte> span) {
                while (span.Length != 0) {
                    _ = Rune.DecodeFromUtf8(span, out Rune current, out int bytesConsumed);

                    if (!Rune.IsWhiteSpace(current)) {
                        break;
                    }

                    span = span[bytesConsumed..];
                }

                while (span.Length != 0) {
                    _ = Rune.DecodeLastFromUtf8(span, out Rune current, out int bytesConsumed);

                    if (!Rune.IsWhiteSpace(current)) {
                        break;
                    }

                    span = span[..^bytesConsumed];
                }

                return span;
            }
#else
            return TrimFallback_Ascii(span);

            static ReadOnlySpan<byte> TrimFallback_Ascii(ReadOnlySpan<byte> span) {
                // Fallback: Only support ASCII.
                while (span.Length != 0) {
                    byte cur = span[0];
                    if (!char.IsWhiteSpace((char)cur)) {
                        break;
                    }
                    span = span.Slice(1);
                }

                while (span.Length != 0) {
                    byte cur = span[span.Length - 1];
                    if (!char.IsWhiteSpace((char)cur)) {
                        break;
                    }
                    span = span.Slice(0, span.Length - 1);
                }

                return span;
            }
#endif // NETCOREAPP3_0_OR_GREATER
        }

    }

}
