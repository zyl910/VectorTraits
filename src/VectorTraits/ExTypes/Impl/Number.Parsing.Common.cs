#undef THIS_HIDE
#define TARGET_64BIT
#if NET5_0_OR_GREATER
#define BCL_TYPE_HALF
#endif // NET5_0_OR_GREATER
#if NET7_0_OR_GREATER
#define BCL_TYPE_INT128
#define GENERICS_MATH
#endif // NET7_0_OR_GREATER

using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Zyl.VectorTraits.Impl.Util;
using Zyl.VectorTraits.Numerics;

namespace Zyl.VectorTraits.ExTypes.Impl {
    using BitConverter = MathBitConverter;
    //using IBinaryFloatParseAndFormatInfo = IComparable;
    //using IUtfChar = IEquatable;

    internal static partial class Number {
        //private static bool TryParseNumber<TChar>(scoped ref TChar* str, TChar* strEnd, NumberStyles styles, ref NumberBuffer number, NumberFormatInfo info)
        private static bool TryParseNumber<TChar>(ref TChar str, ref TChar strEnd, NumberStyles styles, ref NumberBuffer number, NumberFormatInfo info, out nint consumedCount)
            where TChar : unmanaged, IEquatable<TChar> {
            //Debug.Assert(str != null);
            //Debug.Assert(strEnd != null);
            Debug.Assert(UnsafeUtil.IsAddressLessThaOrEqual(ref str, ref strEnd));
            Debug.Assert((styles & (NumberStyles.AllowHexSpecifier
#if NET8_0_OR_GREATER
                | NumberStyles.AllowBinarySpecifier
#endif // NET8_0_OR_GREATER
                )) == 0);

            const int StateSign = 0x0001;
            const int StateParens = 0x0002;
            const int StateDigits = 0x0004;
            const int StateNonZero = 0x0008;
            const int StateDecimal = 0x0010;
            const int StateCurrency = 0x0020;

            Debug.Assert(number.DigitsCount == 0);
            Debug.Assert(number.Scale == 0);
            Debug.Assert(!number.IsNegative);
            Debug.Assert(!number.HasNonZeroTail);

            number.CheckConsistency();

            ReadOnlySpan<TChar> decSep;                                 // decimal separator from NumberFormatInfo.
            ReadOnlySpan<TChar> groupSep;                               // group separator from NumberFormatInfo.
            ReadOnlySpan<TChar> currSymbol = ReadOnlySpan<TChar>.Empty; // currency symbol from NumberFormatInfo.

            bool parsingCurrency = false;
            if ((styles & NumberStyles.AllowCurrencySymbol) != 0) {
                currSymbol = info.CurrencySymbolTChar<TChar>();

                // The idea here is to match the currency separators and on failure match the number separators to keep the perf of VB's IsNumeric fast.
                // The values of decSep are setup to use the correct relevant separator (currency in the if part and decimal in the else part).
                decSep = info.CurrencyDecimalSeparatorTChar<TChar>();
                groupSep = info.CurrencyGroupSeparatorTChar<TChar>();
                parsingCurrency = true;
            } else {
                decSep = info.NumberDecimalSeparatorTChar<TChar>();
                groupSep = info.NumberGroupSeparatorTChar<TChar>();
            }

            int state = 0;
            ref TChar p = ref str;
            // uint ch = (p < strEnd) ? TChar.CastToUInt32(*p) : '\0';
            uint ch = (Unsafe.IsAddressLessThan(ref p, ref strEnd)) ? CastToUInt32(p) : (uint)'\0';
            ref TChar next = ref p;

            while (true) {
                // Eat whitespace unless we've found a sign which isn't followed by a currency symbol.
                // "-Kr 1231.47" is legal but "- 1231.47" is not.
                if (!IsWhite(ch) || (styles & NumberStyles.AllowLeadingWhite) == 0 || ((state & StateSign) != 0 && (state & StateCurrency) == 0 && info.NumberNegativePattern != 2)) {
                    // if (((styles & NumberStyles.AllowLeadingSign) != 0) && (state & StateSign) == 0 && ((next = MatchChars(p, strEnd, info.PositiveSignTChar<TChar>())) != null || ((next = MatchNegativeSignChars(p, strEnd, info)) != null && (number.IsNegative = true)))) {
                    //     state |= StateSign;
                    //     p = next - 1;
                    // } else if (ch == '(' && ((styles & NumberStyles.AllowParentheses) != 0) && ((state & StateSign) == 0)) {
                    //     state |= StateSign | StateParens;
                    //     number.IsNegative = true;
                    // } else if (!currSymbol.IsEmpty && (next = MatchChars(p, strEnd, currSymbol)) != null) {
                    //     state |= StateCurrency;
                    //     currSymbol = ReadOnlySpan<TChar>.Empty;
                    //     // We already found the currency symbol. There should not be more currency symbols. Set
                    //     // currSymbol to NULL so that we won't search it again in the later code path.
                    //     p = next - 1;
                    // } else {
                    //     break;
                    // }
                    bool positiveSignDone = false;
                    bool currSymbolDone = false;
                    if (((styles & NumberStyles.AllowLeadingSign) != 0) && (state & StateSign) == 0) {
                        //  && ((next = MatchChars(p, strEnd, info.PositiveSignTChar<TChar>())) != null || ((next = MatchNegativeSignChars(p, strEnd, info)) != null && (number.IsNegative = true))
                        next = ref MatchChars(ref p, ref strEnd, info.PositiveSignTChar<TChar>());
                        if (UnsafeUtil.IsNullRef(ref next)) {
                            next = ref MatchNegativeSignChars(ref p, ref strEnd, info);
                            number.IsNegative = true;
                        }
                        if (!UnsafeUtil.IsNullRef(ref next)) {
                            state |= StateSign;
                            p = ref Unsafe.Subtract(ref next, 1);
                            positiveSignDone = true;
                        }
                    }
                    if (!positiveSignDone) {
                        if (ch == '(' && ((styles & NumberStyles.AllowParentheses) != 0) && ((state & StateSign) == 0)) {
                            state |= StateSign | StateParens;
                            number.IsNegative = true;
                        } else {
                            if (!currSymbol.IsEmpty) {
                                //  && (next = MatchChars(p, strEnd, currSymbol)) != null
                                next = ref MatchChars(ref p, ref strEnd, currSymbol);
                                if (!UnsafeUtil.IsNullRef(ref next)) {
                                    state |= StateCurrency;
                                    currSymbol = ReadOnlySpan<TChar>.Empty;
                                    // We already found the currency symbol. There should not be more currency symbols. Set
                                    // currSymbol to NULL so that we won't search it again in the later code path.
                                    p = ref Unsafe.Subtract(ref next, 1);
                                    currSymbolDone = true;
                                }
                            }
                            if (!currSymbolDone){
                                break;
                            }
                        }
                    }
                }
                // ch = ++p < strEnd ? TChar.CastToUInt32(*p) : '\0';
                p = ref Unsafe.Add(ref p, 1);
                ch = Unsafe.IsAddressLessThan(ref p, ref strEnd) ? CastToUInt32(p) : '\0';
            }

            int digCount = 0;
            int digEnd = 0;
            int maxDigCount = number.Digits.Length - 1;
            int numberOfTrailingZeros = 0;

            while (true) {
                bool decSepDone = false;
                bool groupSepDone = false;
                if (IsDigit(ch)) {
                    state |= StateDigits;

                    if (ch != '0' || (state & StateNonZero) != 0) {
                        if (digCount < maxDigCount) {
                            number.Digits[digCount] = (byte)ch;
                            if ((ch != '0') || (number.Kind != NumberBufferKind.Integer)) {
                                digEnd = digCount + 1;
                            }
                        } else if (ch != '0') {
                            // For decimal and binary floating-point numbers, we only
                            // need to store digits up to maxDigCount. However, we still
                            // need to keep track of whether any additional digits past
                            // maxDigCount were non-zero, as that can impact rounding
                            // for an input that falls evenly between two representable
                            // results.

                            number.HasNonZeroTail = true;
                        }

                        if ((state & StateDecimal) == 0) {
                            number.Scale++;
                        }

                        if (digCount < maxDigCount) {
                            // Handle a case like "53.0". We need to ignore trailing zeros in the fractional part for floating point numbers, so we keep a count of the number of trailing zeros and update digCount later
                            if (ch == '0') {
                                numberOfTrailingZeros++;
                            } else {
                                numberOfTrailingZeros = 0;
                            }
                        }
                        digCount++;
                        state |= StateNonZero;
                    } else if ((state & StateDecimal) != 0) {
                        number.Scale--;
                    }
                } else {
                    // } else if (((styles & NumberStyles.AllowDecimalPoint) != 0) && ((state & StateDecimal) == 0) && ((next = MatchChars(p, strEnd, decSep)) != null || (parsingCurrency && (state & StateCurrency) == 0 && (next = MatchChars(p, strEnd, info.NumberDecimalSeparatorTChar<TChar>())) != null))) {
                    if (((styles & NumberStyles.AllowDecimalPoint) != 0) && ((state & StateDecimal) == 0)) {
                        //  && ((next = MatchChars(p, strEnd, decSep)) != null || (parsingCurrency && (state & StateCurrency) == 0 && (next = MatchChars(p, strEnd, info.NumberDecimalSeparatorTChar<TChar>())) != null))
                        next = ref MatchChars(ref p, ref strEnd, decSep);
                        if (UnsafeUtil.IsNullRef(ref next) && (parsingCurrency && (state & StateCurrency) == 0)) {
                            next = ref MatchChars(ref p, ref strEnd, info.NumberDecimalSeparatorTChar<TChar>());
                        }
                        if (!UnsafeUtil.IsNullRef(ref next)) {
                            state |= StateDecimal;
                            p = ref Unsafe.Subtract(ref next, 1);
                            decSepDone = true;
                        }
                    }
                    if (!decSepDone) {
                        //} else if (((styles & NumberStyles.AllowThousands) != 0) && ((state & StateDigits) != 0) && ((state & StateDecimal) == 0) && ((next = MatchChars(p, strEnd, groupSep)) != null || (parsingCurrency && (state & StateCurrency) == 0 && (next = MatchChars(p, strEnd, info.NumberGroupSeparatorTChar<TChar>())) != null))) {
                        //    p = ref Unsafe.Subtract(ref next, 1);
                        //} else {
                        //    break;
                        //}
                        if (((styles & NumberStyles.AllowThousands) != 0) && ((state & StateDigits) != 0) && ((state & StateDecimal) == 0)) {
                            //  && ((next = MatchChars(p, strEnd, groupSep)) != null || (parsingCurrency && (state & StateCurrency) == 0 && (next = MatchChars(p, strEnd, info.NumberGroupSeparatorTChar<TChar>())) != null))
                            next = ref MatchChars(ref p, ref strEnd, groupSep);
                            if (UnsafeUtil.IsNullRef(ref next) && (parsingCurrency && (state & StateCurrency) == 0)) {
                                next = ref MatchChars(ref p, ref strEnd, info.NumberGroupSeparatorTChar<TChar>());
                            }
                            if (!UnsafeUtil.IsNullRef(ref next)) {
                                p = ref Unsafe.Subtract(ref next, 1);
                                groupSepDone = true;
                            }
                        }
                        if (!groupSepDone) {
                            break;
                        }
                    }
                }
                p = ref Unsafe.Add(ref p, 1);
                ch = Unsafe.IsAddressLessThan(ref p, ref strEnd) ? CastToUInt32(p) : '\0';
            }

            bool negExp = false;
            number.DigitsCount = digEnd;
            number.Digits[digEnd] = (byte)'\0';
            if ((state & StateDigits) != 0) {
                if ((ch == 'E' || ch == 'e') && ((styles & NumberStyles.AllowExponent) != 0)) {
                    ref TChar temp = ref p;
                    // ch = ++p < strEnd ? TChar.CastToUInt32(*p) : '\0';
                    // if ((next = MatchChars(p, strEnd, info.PositiveSignTChar<TChar>())) != null) {
                    //     ch = (p = next) < strEnd ? TChar.CastToUInt32(*p) : '\0';
                    // } else if ((next = MatchNegativeSignChars(p, strEnd, info)) != null) {
                    //     ch = (p = next) < strEnd ? TChar.CastToUInt32(*p) : '\0';
                    //     negExp = true;
                    // }
                    p = ref Unsafe.Add(ref p, 1);
                    ch = Unsafe.IsAddressLessThan(ref p, ref strEnd) ? CastToUInt32(p) : '\0';
                    next = ref MatchChars(ref p, ref strEnd, info.PositiveSignTChar<TChar>());
                    if (!UnsafeUtil.IsNullRef(ref next)) {
                        p = ref next;
                        ch = Unsafe.IsAddressLessThan(ref p, ref strEnd) ? CastToUInt32(p) : '\0';
                    } else {
                        next = ref MatchNegativeSignChars(ref p, ref strEnd, info);
                        if (!UnsafeUtil.IsNullRef(ref next)) {
                            p = ref next;
                            ch = Unsafe.IsAddressLessThan(ref p, ref strEnd) ? CastToUInt32(p) : '\0';
                            negExp = true;
                        }
                    }
                    if (IsDigit(ch)) {
                        int exp = 0;
                        do {
                            // Check if we are about to overflow past our limit of 9 digits
                            if (exp >= 100_000_000) {
                                // Set exp to Int.MaxValue to signify the requested exponent is too large. This will lead to an OverflowException later.
                                exp = int.MaxValue;
                                number.Scale = 0;

                                // Finish parsing the number, a FormatException could still occur later on.
                                while (IsDigit(ch)) {
                                    //ch = ++p < strEnd ? TChar.CastToUInt32(*p) : '\0';
                                    p = ref Unsafe.Add(ref p, 1);
                                    ch = Unsafe.IsAddressLessThan(ref p, ref strEnd) ? CastToUInt32(p) : '\0';
                                }
                                break;
                            }

                            exp = (exp * 10) + (int)(ch - '0');
                            // ch = ++p < strEnd ? TChar.CastToUInt32(*p) : '\0';
                            p = ref Unsafe.Add(ref p, 1);
                            ch = Unsafe.IsAddressLessThan(ref p, ref strEnd) ? CastToUInt32(p) : '\0';
                        } while (IsDigit(ch));
                        if (negExp) {
                            exp = -exp;
                        }
                        number.Scale += exp;
                    } else {
                        p = temp;
                        //ch = p < strEnd ? TChar.CastToUInt32(*p) : '\0';
                        ch = Unsafe.IsAddressLessThan(ref p, ref strEnd) ? CastToUInt32(p) : '\0';
                    }
                }

                if (number.Kind == NumberBufferKind.FloatingPoint && !number.HasNonZeroTail) {
                    // Adjust the number buffer for trailing zeros
                    int numberOfFractionalDigits = digEnd - number.Scale;
                    if (numberOfFractionalDigits > 0) {
                        numberOfTrailingZeros = Math.Min(numberOfTrailingZeros, numberOfFractionalDigits);
                        Debug.Assert(numberOfTrailingZeros >= 0);
                        number.DigitsCount = digEnd - numberOfTrailingZeros;
                        number.Digits[number.DigitsCount] = (byte)'\0';
                    }
                }

                while (true) {
                    if (!IsWhite(ch) || (styles & NumberStyles.AllowTrailingWhite) == 0) {
                        // if ((styles & NumberStyles.AllowTrailingSign) != 0 && ((state & StateSign) == 0) && ((next = MatchChars(p, strEnd, info.PositiveSignTChar<TChar>())) != null || (((next = MatchNegativeSignChars(p, strEnd, info)) != null) && (number.IsNegative = true)))) {
                        //     state |= StateSign;
                        //     p = next - 1;
                        // } else if (ch == ')' && ((state & StateParens) != 0)) {
                        //     state &= ~StateParens;
                        // } else if (!currSymbol.IsEmpty && (next = MatchChars(p, strEnd, currSymbol)) != null) {
                        //     currSymbol = ReadOnlySpan<TChar>.Empty;
                        //     p = next - 1;
                        // } else {
                        //     break;
                        // }
                        bool positiveSignDone = false;
                        bool currSymbolDone = false;
                        if ((styles & NumberStyles.AllowTrailingSign) != 0 && ((state & StateSign) == 0)) {
                            //  && ((next = MatchChars(p, strEnd, info.PositiveSignTChar<TChar>())) != null || (((next = MatchNegativeSignChars(p, strEnd, info)) != null) && (number.IsNegative = true)))
                            next = ref MatchChars(ref p, ref strEnd, info.PositiveSignTChar<TChar>());
                            if (UnsafeUtil.IsNullRef(ref next)) {
                                next = ref MatchNegativeSignChars(ref p, ref strEnd, info);
                                number.IsNegative = true;
                            }
                            if (!UnsafeUtil.IsNullRef(ref next)) {
                                state |= StateSign;
                                p = ref Unsafe.Subtract(ref next, 1);
                                positiveSignDone = true;
                            }
                        }
                        if (!positiveSignDone) {
                            if (ch == ')' && ((state & StateParens) != 0)) {
                                state &= ~StateParens;
                            } else {
                                if (!currSymbol.IsEmpty) {
                                    //  && (next = MatchChars(p, strEnd, currSymbol)) != null
                                    next = ref MatchChars(ref p, ref strEnd, currSymbol);
                                    if (!UnsafeUtil.IsNullRef(ref next)) {
                                        currSymbol = ReadOnlySpan<TChar>.Empty;
                                        p = ref Unsafe.Subtract(ref next, 1);
                                        currSymbolDone = true;
                                    }
                                }
                                if (!currSymbolDone) {
                                    break;
                                }
                            }

                        }
                    }
                    // ch = ++p < strEnd ? TChar.CastToUInt32(*p) : '\0';
                    p = ref Unsafe.Add(ref p, 1);
                    ch = Unsafe.IsAddressLessThan(ref p, ref strEnd) ? CastToUInt32(p) : '\0';
                }
                if ((state & StateParens) == 0) {
                    if ((state & StateNonZero) == 0) {
                        if (number.Kind != NumberBufferKind.Decimal) {
                            number.Scale = 0;
                        }
                        if ((number.Kind == NumberBufferKind.Integer) && (state & StateDecimal) == 0) {
                            number.IsNegative = false;
                        }
                    }
                    // str = p;
                    consumedCount = UnsafeUtil.GetOffset(ref str, ref p);
                    return true;
                }
            }
            //str = p;
            consumedCount = UnsafeUtil.GetOffset(ref str, ref p);
            return false;
        }

        internal static bool TryStringToNumber<TChar>(ReadOnlySpan<TChar> value, NumberStyles styles, ref NumberBuffer number, NumberFormatInfo info)
            where TChar : unmanaged, IEquatable<TChar> {
            Debug.Assert(info != null);

            if (true) {
                ref TChar stringPointer = ref MemoryMarshal.GetReference(value);
                ref TChar p = ref stringPointer;
                //if (!TryParseNumber(ref p, p + value.Length, styles, ref number, info)
                //    || ((int)(p - stringPointer) < value.Length && !TrailingZeros(value, (int)(p - stringPointer)))) {
                //    number.CheckConsistency();
                //    return false;
                //}
                bool tryDone = TryParseNumber(ref stringPointer, ref Unsafe.Add(ref p, value.Length), styles, ref number, info!, out nint consumedCount);
                int offset = (int)consumedCount;
                if (!tryDone
                    || (offset < value.Length && !TrailingZeros(value, offset))) {
                    number.CheckConsistency();
                    return false;
                }
            }

            number.CheckConsistency();
            return true;
        }

        [MethodImpl(MethodImplOptions.NoInlining)] // rare slow path that shouldn't impact perf of the main use case
        private static bool TrailingZeros<TChar>(ReadOnlySpan<TChar> value, int index)
            where TChar : unmanaged, IEquatable<TChar> {
            // For compatibility, we need to allow trailing zeros at the end of a number string
            //return !value.Slice(index).ContainsAnyExcept(TChar.CastFrom('\0'));
            return !ExBitUtil.ContainsAnyExcept(value.Slice(index), CastFrom<TChar>('\0'));
        }

        private static bool IsWhite(uint ch) => (ch == 0x20) || ((ch - 0x09) <= (0x0D - 0x09));

        private static bool IsDigit(uint ch) => (ch - '0') <= 9;

        internal enum ParsingStatus {
            OK,
            Failed,
            Overflow
        }

        private static bool IsSpaceReplacingChar(uint c) => (c == '\u00a0') || (c == '\u202f');

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static ref TChar MatchNegativeSignChars<TChar>(ref TChar p, ref TChar pEnd, NumberFormatInfo info)
            where TChar : unmanaged, IEquatable<TChar> {
            ref TChar ret = ref MatchChars(ref p, ref pEnd, info.NegativeSignTChar<TChar>());

            //  && info.AllowHyphenDuringParsing()
            if (UnsafeUtil.IsNullRef(ref ret) && Unsafe.IsAddressLessThan(ref p, ref pEnd) && (CastToUInt32<TChar>(p) == '-')) {
                ret = ref Unsafe.Add(ref p, 1);
            }

            return ref ret;
        }

        private static ref TChar MatchChars<TChar>(ref TChar p, ref TChar pEnd, ReadOnlySpan<TChar> value)
            where TChar : unmanaged, IEquatable<TChar> {
            //Debug.Assert((p != null) && (pEnd != null) && (p <= pEnd));
            Debug.Assert(UnsafeUtil.IsNullRef(ref p));
            Debug.Assert(UnsafeUtil.IsNullRef(ref pEnd));
            Debug.Assert(UnsafeUtil.IsAddressLessThaOrEqual(ref p, ref pEnd));

            if (true) {
                ref TChar stringPointer = ref MemoryMarshal.GetReference(value);
                ref TChar str = ref stringPointer;

                if (CastToUInt32(str) != '\0') {
                    // We only hurt the failure case
                    // This fix is for French or Kazakh cultures. Since a user cannot type 0xA0 or 0x202F as a
                    // space character we use 0x20 space character instead to mean the same.
                    while (true) {
                        uint cp = ( Unsafe.IsAddressLessThan(ref p, ref pEnd)) ? CastToUInt32(p) : '\0';
                        uint val = CastToUInt32(str);

                        if ((cp != val) && !(IsSpaceReplacingChar(val) && (cp == '\u0020'))) {
                            break;
                        }

                        p = ref Unsafe.Add(ref p, 1);
                        str = ref Unsafe.Add(ref str, 1);

                        if (CastToUInt32(str) == '\0') {
                            return ref p;
                        }
                    }
                }
            }

            return ref UnsafeUtil.NullRef<TChar>();
        }
    }

}
