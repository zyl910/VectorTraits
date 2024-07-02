using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Zyl.VectorTraits.ExTypes.Impl {
    /// <summary>
    /// Extensions of <see cref="NumberFormatInfo"/>
    /// </summary>
    internal static class NumberFormatInfoExtensions {

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static bool HasInvariantNumberSignsCheck(this NumberFormatInfo info) {
            return info.PositiveSign == "+" && info.NegativeSign == "-";
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static bool AllowHyphenDuringParsing(this NumberFormatInfo info) {
            // The list of the Minus characters are picked up from the CLDR parse lenient data.
            // e.g. https://github.com/unicode-org/cldr/blob/feb602b06bd18ba7333464bd648b68292e8aa54d/common/main/sw.xml#L1001
            string _negativeSign = info.NegativeSign;
            bool _allowHyphenDuringParsing = _negativeSign.Length == 1 &&
                                        _negativeSign[0] switch {
                                            '\u2012' or         // Figure Dash
                                            '\u207B' or         // Superscript Minus
                                            '\u208B' or         // Subscript Minus
                                            '\u2212' or         // Minus Sign
                                            '\u2796' or         // Heavy Minus Sign
                                            '\uFE63' or         // Small Hyphen-Minus
                                            '\uFF0D' => true,   // Fullwidth Hyphen-Minus
                                            _ => false
                                        };
            return _allowHyphenDuringParsing;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ReadOnlySpan<TChar> CurrencyDecimalSeparatorTChar<TChar>(this NumberFormatInfo info) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));
            string temp = info.CurrencyDecimalSeparator;
            if (typeof(TChar) == typeof(char)) {
                return MemoryMarshal.Cast<char, TChar>(temp.AsSpan());
            } else {
                byte[] tempUtf8 = Encoding.UTF8.GetBytes(temp);
                return MemoryMarshal.Cast<byte, TChar>((ReadOnlySpan<byte>)tempUtf8.AsSpan());
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ReadOnlySpan<TChar> CurrencyGroupSeparatorTChar<TChar>(this NumberFormatInfo info) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));
            string temp = info.CurrencyGroupSeparator;
            if (typeof(TChar) == typeof(char)) {
                return MemoryMarshal.Cast<char, TChar>(temp.AsSpan());
            } else {
                byte[] tempUtf8 = Encoding.UTF8.GetBytes(temp);
                return MemoryMarshal.Cast<byte, TChar>((ReadOnlySpan<byte>)tempUtf8.AsSpan());
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ReadOnlySpan<TChar> CurrencySymbolTChar<TChar>(this NumberFormatInfo info) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));
            string temp = info.CurrencySymbol;
            if (typeof(TChar) == typeof(char)) {
                return MemoryMarshal.Cast<char, TChar>(temp.AsSpan());
            } else {
                byte[] tempUtf8 = Encoding.UTF8.GetBytes(temp);
                return MemoryMarshal.Cast<byte, TChar>((ReadOnlySpan<byte>)tempUtf8.AsSpan());
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ReadOnlySpan<TChar> NaNSymbolTChar<TChar>(this NumberFormatInfo info) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));
            string temp = info.NaNSymbol;
            if (typeof(TChar) == typeof(char)) {
                return MemoryMarshal.Cast<char, TChar>(temp.AsSpan());
            } else {
                byte[] tempUtf8 = Encoding.UTF8.GetBytes(temp);
                return MemoryMarshal.Cast<byte, TChar>((ReadOnlySpan<byte>)tempUtf8.AsSpan());
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ReadOnlySpan<TChar> NegativeInfinitySymbolTChar<TChar>(this NumberFormatInfo info) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));
            string temp = info.NegativeInfinitySymbol;
            if (typeof(TChar) == typeof(char)) {
                return MemoryMarshal.Cast<char, TChar>(temp.AsSpan());
            } else {
                byte[] tempUtf8 = Encoding.UTF8.GetBytes(temp);
                return MemoryMarshal.Cast<byte, TChar>((ReadOnlySpan<byte>)tempUtf8.AsSpan());
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ReadOnlySpan<TChar> NegativeSignTChar<TChar>(this NumberFormatInfo info) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));
            string temp = info.NegativeSign;
            if (typeof(TChar) == typeof(char)) {
                return MemoryMarshal.Cast<char, TChar>(temp.AsSpan());
            } else {
                byte[] tempUtf8 = Encoding.UTF8.GetBytes(temp);
                return MemoryMarshal.Cast<byte, TChar>((ReadOnlySpan<byte>)tempUtf8.AsSpan());
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ReadOnlySpan<TChar> NumberDecimalSeparatorTChar<TChar>(this NumberFormatInfo info) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));
            string temp = info.NumberDecimalSeparator;
            if (typeof(TChar) == typeof(char)) {
                return MemoryMarshal.Cast<char, TChar>(temp.AsSpan());
            } else {
                byte[] tempUtf8 = Encoding.UTF8.GetBytes(temp);
                return MemoryMarshal.Cast<byte, TChar>((ReadOnlySpan<byte>)tempUtf8.AsSpan());
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ReadOnlySpan<TChar> NumberGroupSeparatorTChar<TChar>(this NumberFormatInfo info) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));
            string temp = info.NumberGroupSeparator;
            if (typeof(TChar) == typeof(char)) {
                return MemoryMarshal.Cast<char, TChar>(temp.AsSpan());
            } else {
                byte[] tempUtf8 = Encoding.UTF8.GetBytes(temp);
                return MemoryMarshal.Cast<byte, TChar>((ReadOnlySpan<byte>)tempUtf8.AsSpan());
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ReadOnlySpan<TChar> PerMilleSymbolTChar<TChar>(this NumberFormatInfo info) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));
            string temp = info.PerMilleSymbol;
            if (typeof(TChar) == typeof(char)) {
                return MemoryMarshal.Cast<char, TChar>(temp.AsSpan());
            } else {
                byte[] tempUtf8 = Encoding.UTF8.GetBytes(temp);
                return MemoryMarshal.Cast<byte, TChar>((ReadOnlySpan<byte>)tempUtf8.AsSpan());
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ReadOnlySpan<TChar> PercentDecimalSeparatorTChar<TChar>(this NumberFormatInfo info) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));
            string temp = info.PercentDecimalSeparator;
            if (typeof(TChar) == typeof(char)) {
                return MemoryMarshal.Cast<char, TChar>(temp.AsSpan());
            } else {
                byte[] tempUtf8 = Encoding.UTF8.GetBytes(temp);
                return MemoryMarshal.Cast<byte, TChar>((ReadOnlySpan<byte>)tempUtf8.AsSpan());
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ReadOnlySpan<TChar> PercentGroupSeparatorTChar<TChar>(this NumberFormatInfo info) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));
            string temp = info.PercentGroupSeparator;
            if (typeof(TChar) == typeof(char)) {
                return MemoryMarshal.Cast<char, TChar>(temp.AsSpan());
            } else {
                byte[] tempUtf8 = Encoding.UTF8.GetBytes(temp);
                return MemoryMarshal.Cast<byte, TChar>((ReadOnlySpan<byte>)tempUtf8.AsSpan());
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ReadOnlySpan<TChar> PercentSymbolTChar<TChar>(this NumberFormatInfo info) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));
            string temp = info.PercentSymbol;
            if (typeof(TChar) == typeof(char)) {
                return MemoryMarshal.Cast<char, TChar>(temp.AsSpan());
            } else {
                byte[] tempUtf8 = Encoding.UTF8.GetBytes(temp);
                return MemoryMarshal.Cast<byte, TChar>((ReadOnlySpan<byte>)tempUtf8.AsSpan());
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ReadOnlySpan<TChar> PositiveInfinitySymbolTChar<TChar>(this NumberFormatInfo info) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));
            string temp = info.PositiveInfinitySymbol;
            if (typeof(TChar) == typeof(char)) {
                return MemoryMarshal.Cast<char, TChar>(temp.AsSpan());
            } else {
                byte[] tempUtf8 = Encoding.UTF8.GetBytes(temp);
                return MemoryMarshal.Cast<byte, TChar>((ReadOnlySpan<byte>)tempUtf8.AsSpan());
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ReadOnlySpan<TChar> PositiveSignTChar<TChar>(this NumberFormatInfo info) where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(typeof(TChar) == typeof(char) || typeof(TChar) == typeof(byte));
            string temp = info.PositiveSign;
            if (typeof(TChar) == typeof(char)) {
                return MemoryMarshal.Cast<char, TChar>(temp.AsSpan());
            } else {
                byte[] tempUtf8 = Encoding.UTF8.GetBytes(temp);
                return MemoryMarshal.Cast<byte, TChar>((ReadOnlySpan<byte>)tempUtf8.AsSpan());
            }
        }

    }
}
