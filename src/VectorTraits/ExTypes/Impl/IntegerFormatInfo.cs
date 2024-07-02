#if NET7_0_OR_GREATER
#define BCL_TYPE_INT128
#define GENERICS_MATH
#endif // NET7_0_OR_GREATER

using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Zyl.VectorTraits.ExTypes.Impl {

    // Number.Parsing.cs
    // internal interface IBinaryIntegerParseAndFormatInfo<TSelf> : IBinaryInteger<TSelf>, IMinMaxValue<TSelf>
    //     where TSelf : unmanaged, IBinaryIntegerParseAndFormatInfo<TSelf>
    // {
    //     static bool IsSigned { get; }
    // 
    //     static int MaxDigitCount { get; }
    // 
    //     static int MaxHexDigitCount { get; }
    // 
    //     static TSelf MaxValueDiv10 { get; }
    // 
    //     static string OverflowMessage { get; }
    // 
    //     static bool IsGreaterThanAsUnsigned(TSelf left, TSelf right);
    // 
    //     static TSelf MultiplyBy10(TSelf value);
    // 
    //     static TSelf MultiplyBy16(TSelf value);
    // }

    /// <summary>
    /// Same IBinaryIntegerParseAndFormatInfo.
    /// </summary>
    /// <typeparam name="TSelf">Type of number (数值的类型).</typeparam>
    internal static class IntegerFormatInfo<TSelf> where TSelf : unmanaged
#if GENERICS_MATH
        , IBinaryInteger<TSelf>
#endif
        {
        public static TSelf Zero { get; private set; }
        public static TSelf MaxValue { get; private set; }

        public static bool IsSigned { get; private set; }

        public static int MaxDigitCount { get; private set; }

        public static int MaxHexDigitCount { get; private set; }

        public static TSelf MaxValueDiv10 { get; private set; }

        public static string OverflowMessage { get; private set; }

        static IntegerFormatInfo() {
            unchecked {
                if (typeof(TSelf) == typeof(sbyte)) {
                    Zero = (TSelf)(object)default(sbyte);
                    MaxValue = (TSelf)(object)sbyte.MaxValue;
                    IsSigned = true;
                    MaxDigitCount = 3; // 127
                    MaxHexDigitCount = 2; // 0x7F
                    MaxValueDiv10 = (TSelf)(object)(sbyte)(sbyte.MaxValue / 10);
                    //OverflowMessage = SR.Overflow_SByte;
                } else if (typeof(TSelf) == typeof(byte)) {
                    Zero = (TSelf)(object)default(byte);
                    MaxValue = (TSelf)(object)byte.MaxValue;
                    IsSigned = false;
                    MaxDigitCount = 3; // 255
                    MaxHexDigitCount = 2; // 0xFF
                    MaxValueDiv10 = (TSelf)(object)(byte)(byte.MaxValue / 10);
                } else if (typeof(TSelf) == typeof(short)) {
                    Zero = (TSelf)(object)default(short);
                    MaxValue = (TSelf)(object)sbyte.MaxValue;
                    IsSigned = true;
                    MaxDigitCount = 5; // 32_767
                    MaxHexDigitCount = 4; // 0x7FFF
                    MaxValueDiv10 = (TSelf)(object)(short)(short.MaxValue / 10);
                } else if (typeof(TSelf) == typeof(ushort)) {
                    Zero = (TSelf)(object)default(ushort);
                    MaxValue = (TSelf)(object)ushort.MaxValue;
                    IsSigned = false;
                    MaxDigitCount = 5; // 65_535
                    MaxHexDigitCount = 4; // 0xFFFF
                    MaxValueDiv10 = (TSelf)(object)(short)(short.MaxValue / 10);
                } else if (typeof(TSelf) == typeof(int)) {
                    Zero = (TSelf)(object)default(int);
                    MaxValue = (TSelf)(object)int.MaxValue;
                    IsSigned = true;
                    MaxDigitCount = 10; // 2_147_483_647
                    MaxHexDigitCount = 8; // 0x7FFF_FFFF
                    MaxValueDiv10 = (TSelf)(object)(int)(int.MaxValue / 10);
                } else if (typeof(TSelf) == typeof(uint)) {
                    Zero = (TSelf)(object)default(uint);
                    MaxValue = (TSelf)(object)uint.MaxValue;
                    IsSigned = false;
                    MaxDigitCount = 10; // 4_294_967_295
                    MaxHexDigitCount = 8; // 0xFFFF_FFFF
                    MaxValueDiv10 = (TSelf)(object)(uint)(uint.MaxValue / 10);
                } else if (typeof(TSelf) == typeof(long)) {
                    Zero = (TSelf)(object)default(long);
                    MaxValue = (TSelf)(object)long.MaxValue;
                    IsSigned = true;
                    MaxDigitCount = 19; // 9_223_372_036_854_775_807
                    MaxHexDigitCount = 16; // 0x7FFF_FFFF_FFFF_FFFF
                    MaxValueDiv10 = (TSelf)(object)(long)(long.MaxValue / 10);
                } else if (typeof(TSelf) == typeof(ulong)) {
                    Zero = (TSelf)(object)default(ulong);
                    MaxValue = (TSelf)(object)ulong.MaxValue;
                    IsSigned = false;
                    MaxDigitCount = 20; // 18_446_744_073_709_551_615
                    MaxHexDigitCount = 16; // 0xFFFF_FFFF_FFFF_FFFF
                    MaxValueDiv10 = (TSelf)(object)(ulong)(ulong.MaxValue / 10);
                } else if (typeof(TSelf) == typeof(nint)) {
                    Zero = (TSelf)(object)default(nint);
                    IsSigned = true;
                    if (sizeof(int) == IntPtr.Size) {
                        MaxDigitCount = 10; // 2_147_483_647
                        MaxHexDigitCount = 8; // 0x7FFF_FFFF
                    } else {
                        MaxDigitCount = 19; // 9_223_372_036_854_775_807
                        MaxHexDigitCount = 16; // 0x7FFF_FFFF_FFFF_FFFF
                    }
#if NET5_0_OR_GREATER
                    MaxValue = (TSelf)(object)nint.MaxValue;
                    MaxValueDiv10 = (TSelf)(object)(nint)(nint.MaxValue / 10);
#else
                    if (sizeof(int) == IntPtr.Size) {
                        MaxValue = (TSelf)(object)(nint)int.MaxValue;
                        MaxValueDiv10 = (TSelf)(object)(nint)(int.MaxValue / 10);
                    } else {
                        MaxValue = (TSelf)(object)(nint)long.MaxValue;
                        MaxValueDiv10 = (TSelf)(object)(nint)(long.MaxValue / 10);
                    }
#endif // NET5_0_OR_GREATER
                } else if (typeof(TSelf) == typeof(nuint)) {
                    Zero = (TSelf)(object)default(nuint);
                    IsSigned = false;
                    if (sizeof(int) == IntPtr.Size) {
                        MaxDigitCount = 10; // 4_294_967_295
                        MaxHexDigitCount = 8; // 0xFFFF_FFFF
                    } else {
                        MaxDigitCount = 20; // 18_446_744_073_709_551_615
                        MaxHexDigitCount = 16; // 0xFFFF_FFFF_FFFF_FFFF
                    }
#if NET5_0_OR_GREATER
                    MaxValue = (TSelf)(object)nuint.MaxValue;
                    MaxValueDiv10 = (TSelf)(object)(nuint)(nuint.MaxValue / 10);
#else
                    if (sizeof(uint) == UIntPtr.Size) {
                        MaxValue = (TSelf)(object)(nuint)uint.MaxValue;
                        MaxValueDiv10 = (TSelf)(object)(nuint)(uint.MaxValue / 10);
                    } else {
                        MaxValue = (TSelf)(object)(nuint)ulong.MaxValue;
                        MaxValueDiv10 = (TSelf)(object)(nuint)(ulong.MaxValue / 10);
                    }
#endif // NET5_0_OR_GREATER
                } else if (typeof(TSelf) == typeof(ExInt128)) {
                    Zero = (TSelf)(object)default(ExInt128);
                    MaxValue = (TSelf)(object)ExInt128.MaxValue;
                    IsSigned = true;
                    MaxDigitCount = 39; // 170_141_183_460_469_231_731_687_303_715_884_105_727
                    MaxHexDigitCount = 32; // 0x7FFF_FFFF_FFFF_FFFF_FFFF_FFFF_FFFF_FFFF
                    //MaxValueDiv10 = (TSelf)(object)(ExInt128)(ExInt128.MaxValue / 10);
                    MaxValueDiv10 = (TSelf)(object)new ExInt128(0x0CCC_CCCC_CCCC_CCCC, 0xCCCC_CCCC_CCCC_CCCC);
                } else if (typeof(TSelf) == typeof(ExUInt128)) {
                    Zero = (TSelf)(object)default(ExUInt128);
                    MaxValue = (TSelf)(object)ExUInt128.MaxValue;
                    IsSigned = false;
                    MaxDigitCount = 39; // 340_282_366_920_938_463_463_374_607_431_768_211_455
                    MaxHexDigitCount = 32; // 0xFFFF_FFFF_FFFF_FFFF_FFFF_FFFF_FFFF_FFFF
                    //MaxValueDiv10 = (TSelf)(object)(ExUInt128)(ExUInt128.MaxValue / 10);
                    MaxValueDiv10 = (TSelf)(object)new ExUInt128(0x1999_9999_9999_9999, 0x9999_9999_9999_9999);
#if BCL_TYPE_INT128
                } else if (typeof(TSelf) == typeof(Int128)) {
                    Zero = (TSelf)(object)default(Int128);
                    MaxValue = (TSelf)(object)Int128.MaxValue;
                    IsSigned = true;
                    MaxDigitCount = 39; // 170_141_183_460_469_231_731_687_303_715_884_105_727
                    MaxHexDigitCount = 32; // 0x7FFF_FFFF_FFFF_FFFF_FFFF_FFFF_FFFF_FFFF
                    MaxValueDiv10 = (TSelf)(object)new Int128(0x0CCC_CCCC_CCCC_CCCC, 0xCCCC_CCCC_CCCC_CCCC);
                } else if (typeof(TSelf) == typeof(UInt128)) {
                    Zero = (TSelf)(object)default(UInt128);
                    MaxValue = (TSelf)(object)UInt128.MaxValue;
                    IsSigned = false;
                    MaxDigitCount = 39; // 340_282_366_920_938_463_463_374_607_431_768_211_455
                    MaxHexDigitCount = 32; // 0xFFFF_FFFF_FFFF_FFFF_FFFF_FFFF_FFFF_FFFF
                    MaxValueDiv10 = (TSelf)(object)new UInt128(0x1999_9999_9999_9999, 0x9999_9999_9999_9999);
#endif // BCL_TYPE_INT128
                } else {
                    throw new NotSupportedException();
                }
                OverflowMessage = string.Format("Numeric overflow, out of range of {0} type.", typeof(TSelf).Name);
            }
        }

        public static bool IsGreaterThanAsUnsigned(TSelf left, TSelf right) {
            if (typeof(TSelf) == typeof(sbyte)) {
                return (byte)(sbyte)(object)left > (byte)(sbyte)(object)right;
            } else if (typeof(TSelf) == typeof(byte)) {
                return (byte)(object)left > (byte)(object)right;
            } else if (typeof(TSelf) == typeof(short)) {
                return (ushort)(short)(object)left > (ushort)(short)(object)right;
            } else if (typeof(TSelf) == typeof(ushort)) {
                return (ushort)(object)left > (ushort)(object)right;
            } else if (typeof(TSelf) == typeof(int)) {
                return (uint)(int)(object)left > (uint)(int)(object)right;
            } else if (typeof(TSelf) == typeof(uint)) {
                return (uint)(object)left > (uint)(object)right;
            } else if (typeof(TSelf) == typeof(long)) {
                return (ulong)(long)(object)left > (ulong)(long)(object)right;
            } else if (typeof(TSelf) == typeof(ulong)) {
                return (ulong)(object)left > (ulong)(object)right;
            } else if (typeof(TSelf) == typeof(nint)) {
                return (nuint)(nint)(object)left > (nuint)(nint)(object)right;
            } else if (typeof(TSelf) == typeof(nuint)) {
                return (nuint)(object)left > (nuint)(object)right;
            } else if (typeof(TSelf) == typeof(ExInt128)) {
                return (ExUInt128)(ExInt128)(object)left > (ExUInt128)(ExInt128)(object)right;
            } else if (typeof(TSelf) == typeof(ExUInt128)) {
                return (ExUInt128)(object)left > (ExUInt128)(object)right;
#if BCL_TYPE_INT128
            } else if (typeof(TSelf) == typeof(Int128)) {
                return (UInt128)(Int128)(object)left > (UInt128)(Int128)(object)right;
            } else if (typeof(TSelf) == typeof(UInt128)) {
                return (UInt128)(object)left > (UInt128)(object)right;
#endif // BCL_TYPE_INT128
            }
            throw new NotSupportedException();
        }

        public static TSelf MultiplyByInt(TSelf value, int right) {
#if GENERICS_MATH
            return value * TSelf.CreateTruncating(right);
#else
            if (typeof(TSelf) == typeof(sbyte)) {
                return (TSelf)(object)(sbyte)((sbyte)(object)value * right);
            } else if (typeof(TSelf) == typeof(byte)) {
                return (TSelf)(object)(byte)((byte)(object)value * right);
            } else if (typeof(TSelf) == typeof(short)) {
                return (TSelf)(object)(short)((short)(object)value * right);
            } else if (typeof(TSelf) == typeof(ushort)) {
                return (TSelf)(object)(ushort)((ushort)(object)value * right);
            } else if (typeof(TSelf) == typeof(int)) {
                return (TSelf)(object)(int)((int)(object)value * right);
            } else if (typeof(TSelf) == typeof(uint)) {
                return (TSelf)(object)(uint)((uint)(object)value * right);
            } else if (typeof(TSelf) == typeof(long)) {
                return (TSelf)(object)(long)((long)(object)value * right);
            } else if (typeof(TSelf) == typeof(ulong)) {
                return (TSelf)(object)(ulong)((ulong)(object)value * (ulong)right);
            } else if (typeof(TSelf) == typeof(nint)) {
                return (TSelf)(object)(nint)((nint)(object)value * right);
            } else if (typeof(TSelf) == typeof(nuint)) {
                return (TSelf)(object)(nuint)((nuint)(object)value * (nuint)right);
            } else if (typeof(TSelf) == typeof(ExInt128)) {
                return (TSelf)(object)(ExInt128)((ExInt128)(object)value * right);
            } else if (typeof(TSelf) == typeof(ExUInt128)) {
                return (TSelf)(object)(ExUInt128)((ExUInt128)(object)value * (ExUInt128)right);
#if BCL_TYPE_INT128
            } else if (typeof(TSelf) == typeof(Int128)) {
                return (TSelf)(object)(Int128)((Int128)(object)value * right);
            } else if (typeof(TSelf) == typeof(UInt128)) {
                return (TSelf)(object)(UInt128)((UInt128)(object)value * (UInt128)right);
#endif // BCL_TYPE_INT128
            }
            throw new NotSupportedException();
#endif
        }

        public static TSelf MultiplyBy10(TSelf value) {
            const int right = 10;
#if GENERICS_MATH
            return value * TSelf.CreateTruncating(right);
#else
            if (typeof(TSelf) == typeof(sbyte)) {
                return (TSelf)(object)(sbyte)((sbyte)(object)value * right);
            } else if (typeof(TSelf) == typeof(byte)) {
                return (TSelf)(object)(byte)((byte)(object)value * right);
            } else if (typeof(TSelf) == typeof(short)) {
                return (TSelf)(object)(short)((short)(object)value * right);
            } else if (typeof(TSelf) == typeof(ushort)) {
                return (TSelf)(object)(ushort)((ushort)(object)value * right);
            } else if (typeof(TSelf) == typeof(int)) {
                return (TSelf)(object)(int)((int)(object)value * right);
            } else if (typeof(TSelf) == typeof(uint)) {
                return (TSelf)(object)(uint)((uint)(object)value * right);
            } else if (typeof(TSelf) == typeof(long)) {
                return (TSelf)(object)(long)((long)(object)value * right);
            } else if (typeof(TSelf) == typeof(ulong)) {
                return (TSelf)(object)(ulong)((ulong)(object)value * right);
            } else if (typeof(TSelf) == typeof(nint)) {
                return (TSelf)(object)(nint)((nint)(object)value * right);
            } else if (typeof(TSelf) == typeof(nuint)) {
                return (TSelf)(object)(nuint)((nuint)(object)value * right);
            } else if (typeof(TSelf) == typeof(ExInt128)) {
                return (TSelf)(object)(ExInt128)((ExInt128)(object)value * right);
            } else if (typeof(TSelf) == typeof(ExUInt128)) {
                return (TSelf)(object)(ExUInt128)((ExUInt128)(object)value * right);
#if BCL_TYPE_INT128
            } else if (typeof(TSelf) == typeof(Int128)) {
                return (TSelf)(object)(Int128)((Int128)(object)value * right);
            } else if (typeof(TSelf) == typeof(UInt128)) {
                return (TSelf)(object)(UInt128)((UInt128)(object)value * right);
#endif // BCL_TYPE_INT128
            }
            throw new NotSupportedException();
#endif
        }

        public static TSelf MultiplyBy16(TSelf value) {
            const int right = 16;
#if GENERICS_MATH
            return value * TSelf.CreateTruncating(right);
#else
            if (typeof(TSelf) == typeof(sbyte)) {
                return (TSelf)(object)(sbyte)((sbyte)(object)value * right);
            } else if (typeof(TSelf) == typeof(byte)) {
                return (TSelf)(object)(byte)((byte)(object)value * right);
            } else if (typeof(TSelf) == typeof(short)) {
                return (TSelf)(object)(short)((short)(object)value * right);
            } else if (typeof(TSelf) == typeof(ushort)) {
                return (TSelf)(object)(ushort)((ushort)(object)value * right);
            } else if (typeof(TSelf) == typeof(int)) {
                return (TSelf)(object)(int)((int)(object)value * right);
            } else if (typeof(TSelf) == typeof(uint)) {
                return (TSelf)(object)(uint)((uint)(object)value * right);
            } else if (typeof(TSelf) == typeof(long)) {
                return (TSelf)(object)(long)((long)(object)value * right);
            } else if (typeof(TSelf) == typeof(ulong)) {
                return (TSelf)(object)(ulong)((ulong)(object)value * right);
            } else if (typeof(TSelf) == typeof(nint)) {
                return (TSelf)(object)(nint)((nint)(object)value * right);
            } else if (typeof(TSelf) == typeof(nuint)) {
                return (TSelf)(object)(nuint)((nuint)(object)value * right);
            } else if (typeof(TSelf) == typeof(ExInt128)) {
                return (TSelf)(object)(ExInt128)((ExInt128)(object)value * right);
            } else if (typeof(TSelf) == typeof(ExUInt128)) {
                return (TSelf)(object)(ExUInt128)((ExUInt128)(object)value * right);
#if BCL_TYPE_INT128
            } else if (typeof(TSelf) == typeof(Int128)) {
                return (TSelf)(object)(Int128)((Int128)(object)value * right);
            } else if (typeof(TSelf) == typeof(UInt128)) {
                return (TSelf)(object)(UInt128)((UInt128)(object)value * right);
#endif // BCL_TYPE_INT128
            }
            throw new NotSupportedException();
#endif
        }

        public static TSelf AddInt(TSelf left, int right) {
#if GENERICS_MATH
            return left + TSelf.CreateTruncating(right);
#else
            if (typeof(TSelf) == typeof(sbyte)) {
                return (TSelf)(object)(sbyte)((sbyte)(object)left + right);
            } else if (typeof(TSelf) == typeof(byte)) {
                return (TSelf)(object)(byte)((byte)(object)left + right);
            } else if (typeof(TSelf) == typeof(short)) {
                return (TSelf)(object)(short)((short)(object)left + right);
            } else if (typeof(TSelf) == typeof(ushort)) {
                return (TSelf)(object)(ushort)((ushort)(object)left + right);
            } else if (typeof(TSelf) == typeof(int)) {
                return (TSelf)(object)(int)((int)(object)left + right);
            } else if (typeof(TSelf) == typeof(uint)) {
                return (TSelf)(object)(uint)((uint)(object)left + right);
            } else if (typeof(TSelf) == typeof(long)) {
                return (TSelf)(object)(long)((long)(object)left + right);
            } else if (typeof(TSelf) == typeof(ulong)) {
                return (TSelf)(object)(ulong)((ulong)(object)left + (ulong)right);
            } else if (typeof(TSelf) == typeof(nint)) {
                return (TSelf)(object)(nint)((nint)(object)left + right);
            } else if (typeof(TSelf) == typeof(nuint)) {
                return (TSelf)(object)(nuint)((nuint)(object)left + (nuint)right);
            } else if (typeof(TSelf) == typeof(ExInt128)) {
                return (TSelf)(object)(ExInt128)((ExInt128)(object)left + right);
            } else if (typeof(TSelf) == typeof(ExUInt128)) {
                return (TSelf)(object)(ExUInt128)((ExUInt128)(object)left + (ExUInt128)right);
#if BCL_TYPE_INT128
            } else if (typeof(TSelf) == typeof(Int128)) {
                return (TSelf)(object)(Int128)((Int128)(object)left + right);
            } else if (typeof(TSelf) == typeof(UInt128)) {
                return (TSelf)(object)(UInt128)((UInt128)(object)left + (UInt128)right);
#endif // BCL_TYPE_INT128
            }
            throw new NotSupportedException();
#endif
        }

        public static TSelf AddInt(TSelf left, uint right) {
#if GENERICS_MATH
            return left + TSelf.CreateTruncating(right);
#else
            return AddInt(left, (int)right);
#endif
        }

        public static TSelf CreateTruncating(int value) {
#if GENERICS_MATH
            return TSelf.CreateTruncating(value);
#else
            return Number.CastFrom<TSelf>(value);
#endif
        }

        public static TSelf CreateTruncating(uint value) {
#if GENERICS_MATH
            return TSelf.CreateTruncating(value);
#else
            return CreateTruncating((int)value);
#endif
        }

        /// <inheritdoc cref="IUnaryNegationOperators{TSelf, TResult}.op_UnaryNegation(TSelf)" />
        public static TSelf UnaryNegation(TSelf value) {
#if GENERICS_MATH
            return -value;
#else
            return ExBitUtil.UnaryNegation<TSelf>(value);
#endif
        }

    }

}
