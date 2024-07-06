#if NET7_0_OR_GREATER
#define BCL_TYPE_INT128
#endif // NET7_0_OR_GREATER

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Zyl.VectorTraits.ExTypes;
using Zyl.VectorTraits.Numerics;

namespace Zyl.VectorTraits {

    /// <summary>Specifies the type of an vector element (指定向量元素的类型). Reference from: https://learn.microsoft.com/en-us/dotnet/api/system.typecode </summary>
    public enum ElementTypeCode {
        /// <summary>A null reference (空引用).</summary>
        Empty = 0,
        // /// <summary>A general type representing any reference or value type not explicitly represented by another TypeCode.</summary>
        // Object = 1,
        // /// <summary>A database null (column) value.</summary>
        // DBNull = 2,
        // /// <summary>A simple type representing Boolean values of true or false.</summary>
        // Boolean = 3,
        // /// <summary>An integral type representing unsigned 16-bit integers with values between 0 and 65535. The set of possible values for the System.TypeCode.Char type corresponds to the Unicode character set.</summary>
        // Char = 4,
        /// <summary>An integral type representing signed 8-bit integers with values between -128 and 127 (整型，表示值介于 -128 到 127 之间的 8 位有符号整数). Related types: <see cref="System.SByte"/>.</summary>
        SByte = 5,
        /// <summary>An integral type representing unsigned 8-bit integers with values between 0 and 255 (整型，表示值介于 0 到 255 之间的无符号 8 位整数). Related types: <see cref="System.Byte"/>.</summary>
        Byte = 6,
        /// <summary>An integral type representing signed 16-bit integers with values between -32768 and 32767 (整型，表示值介于 -32768 到 32767 之间的有符号 16 位整数). Related types: <see cref="System.Int16"/>.</summary>
        Int16 = 7,
        /// <summary>An integral type representing unsigned 16-bit integers with values between 0 and 65535 (整型，表示值介于 0 到 65535 之间的 16 位无符号整数). Related types: <see cref="System.UInt16"/>.</summary>
        UInt16 = 8,
        /// <summary>An integral type representing signed 32-bit integers with values between -2147483648 and 2147483647 (整型，表示值介于 -2147483648 到 2147483647 之间的 32 位有符号整数). Related types: <see cref="System.Int32"/>.</summary>
        Int32 = 9,
        /// <summary>An integral type representing unsigned 32-bit integers with values between 0 and 4294967295 (整型，表示值介于 0 到 4294967295 之间的 32 位无符号整数). Related types: <see cref="System.UInt32"/>.</summary>
        UInt32 = 10,
        /// <summary>An integral type representing signed 64-bit integers with values between -9223372036854775808 and 9223372036854775807 (整型，表示值介于-9223372036854775808 和 9223372036854775807 之间的 64 位有符号整数). Related types: <see cref="System.Int64"/>.</summary>
        Int64 = 11,
        /// <summary>An integral type representing unsigned 64-bit integers with values between 0 and 18446744073709551615 (整型，表示值介于 0 到 18446744073709551615 之间的 64 位无符号整数). Related types: <see cref="System.UInt64"/>.</summary>
        UInt64 = 12,
        /// <summary>A floating point type representing values ranging from approximately 1.5 x 10^-45 to 3.4 x 10^38 with a precision of 7 digits (浮点型，表示从大约 1.5 x 10^-45 到 3.4 x 10^38 且精度为 7 位的值). Related types: <see cref="System.Single"/>.</summary>
        Single = 13,
        /// <summary>A floating point type representing values ranging from approximately 5.0 x 10^-324 to 1.7 x 10^308 with a precision of 15-16 digits (浮点型，表示从大约 5.0 x 10^-324 到 1.7 x 10^308 且精度为 15 到 16 位的值). Related types: <see cref="System.Double"/>.</summary>
        Double = 14,
        // /// <summary>A simple type representing values ranging from 1.0 x 10^-28 to approximately 7.9 x 10^28 with 28-29 significant digits.</summary>
        // Decimal = 15,
        // /// <summary>A type representing a date and time value.</summary>
        // DateTime = 16,
        // /// <summary>A sealed class type representing Unicode character strings.</summary>
        // String = 18
        /// <summary>An integral type representing signed 128-bit integers with values between -170141183460469231731687303715884105728 and 170141183460469231731687303715884105727 (整型，表示值介于-170141183460469231731687303715884105728 和 170141183460469231731687303715884105727 之间的 128 位有符号整数). Related types: <see cref="ExInt128"/>, <see cref="System.Int128"/>.</summary>
        Int128 = 28,
        /// <summary>An integral type representing unsigned 128-bit integers with values between 0 and 340282366920938463463374607431768211455 (整型，表示值介于 0 到 340282366920938463463374607431768211455 之间的 128 位无符号整数). Related types: <see cref="ExUInt128"/>, <see cref="System.UInt128"/>.</summary>
        UInt128 = 29,
    }

    /// <summary><see cref="ElementTypeCode"/> bit flags (元素类型代码位标识).</summary>
    [Flags]
    public enum TypeCodeFlags : Int32 {
        /// <summary>None (无).</summary>
        None = 0,
        /// <inheritdoc cref="ElementTypeCode.SByte"/>
        SByte = 1 << 5,
        /// <inheritdoc cref="ElementTypeCode.Byte"/>
        Byte = 1 << 6,
        /// <inheritdoc cref="ElementTypeCode.Int16"/>
        Int16 = 1 << 7,
        /// <inheritdoc cref="ElementTypeCode.UInt16"/>
        UInt16 = 1 << 8,
        /// <inheritdoc cref="ElementTypeCode.Int32"/>
        Int32 = 1 << 9,
        /// <inheritdoc cref="ElementTypeCode.UInt32"/>
        UInt32 = 1 << 10,
        /// <inheritdoc cref="ElementTypeCode.Int64"/>
        Int64 = 1 << 11,
        /// <inheritdoc cref="ElementTypeCode.UInt64"/>
        UInt64 = 1 << 12,
        /// <inheritdoc cref="ElementTypeCode.Single"/>
        Single = 1 << 13,
        /// <inheritdoc cref="ElementTypeCode.Double"/>
        Double = 1 << 14,
        /// <inheritdoc cref="ElementTypeCode.Int128"/>
        Int128 = 1 << 28,
        /// <inheritdoc cref="ElementTypeCode.UInt128"/>
        UInt128 = 1 << 29,
    }


    /// <summary>
    /// <see cref="TypeCodeFlags"/> util (类型代码位标识工具).
    /// </summary>
    public static class TypeCodeFlagsUtil {
        // -- n-Bit --
        /// <summary>TypeCodeFlags of 8-bits types (8位的类型). <c>Bit8Types = TypeCodeFlags.SByte | TypeCodeFlags.Byte</c>.</summary>
        public static TypeCodeFlags Bit8Types => TypeCodeFlags.SByte | TypeCodeFlags.Byte;
        /// <summary>TypeCodeFlags of 16-bits types (16位的类型). <c>Bit16Types = TypeCodeFlags.Int16 | TypeCodeFlags.UInt16</c>.</summary>
        public static TypeCodeFlags Bit16Types => TypeCodeFlags.Int16 | TypeCodeFlags.UInt16;
        /// <summary>TypeCodeFlags of 32-bits types (32位的类型). <c>Bit32Types = TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Single</c>.</summary>
        public static TypeCodeFlags Bit32Types => TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Single;
        /// <summary>TypeCodeFlags of 64-bits types (64位的类型). <c>Bit64Types = TypeCodeFlags.Int64 | TypeCodeFlags.UInt64 | TypeCodeFlags.Double</c>.</summary>
        public static TypeCodeFlags Bit64Types => TypeCodeFlags.Int64 | TypeCodeFlags.UInt64 | TypeCodeFlags.Double;
        /// <summary>TypeCodeFlags of 128-bits types (128位的类型). <c>Bit128Types = TypeCodeFlags.Int128 | TypeCodeFlags.UInt128</c>.</summary>
        public static TypeCodeFlags Bit128Types => TypeCodeFlags.Int128 | TypeCodeFlags.UInt128;

        // -- Standard --
        /// <summary>TypeCodeFlags of Standard float types (标准浮点类型).</summary>
        public const TypeCodeFlags FloatTypes = TypeCodeFlags.Single | TypeCodeFlags.Double;
        /// <summary>TypeCodeFlags of Standard integer types (标准整数类型).</summary>
        public const TypeCodeFlags IntTypes = TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
        /// <summary>TypeCodeFlags of Standard all types (标准所有类型). <c>AllTypes = TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64</c>.</summary>
        public const TypeCodeFlags AllTypes = FloatTypes | IntTypes;

        /// <summary>TypeCodeFlags of most32 float types.</summary>
        public const TypeCodeFlags Most32FloatTypes = TypeCodeFlags.Single;
        /// <summary>TypeCodeFlags of most32 integer types.</summary>
        public const TypeCodeFlags Most32IntTypes = TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
        /// <summary>TypeCodeFlags of most32 types. <c>Most32BaseTypes = TypeCodeFlags.Single | TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32</c>.</summary>
        public const TypeCodeFlags Most32Types = Most32FloatTypes | Most32IntTypes;

        // -- PureEx --
        /// <summary>TypeCodeFlags of PureEx float types (纯扩展浮点类型). <c>PureExFloatTypes = TypeCodeFlags.None</c>.</summary>
        public static TypeCodeFlags PureExFloatTypes => TypeCodeFlags.None;
        /// <summary>TypeCodeFlags of PureEx integer types (纯扩展整数类型). <c>PureExIntTypes = TypeCodeFlags.Int128 | TypeCodeFlags.UInt128</c>.</summary>
        public static TypeCodeFlags PureExIntTypes => TypeCodeFlags.Int128 | TypeCodeFlags.UInt128;
        /// <summary>TypeCodeFlags of PureEx all types (纯扩展所有类型). <c>PureExAllTypes = TypeCodeFlags.Int128 | TypeCodeFlags.UInt128</c>.</summary>
        public static TypeCodeFlags PureExAllTypes => PureExFloatTypes | PureExIntTypes;

        // -- Ex --
        /// <summary>TypeCodeFlags of Ex float types (扩展浮点类型). <c>ExFloatTypes = TypeCodeFlags.Single | TypeCodeFlags.Double</c>.</summary>
        public static TypeCodeFlags ExFloatTypes => FloatTypes | PureExFloatTypes;
        /// <summary>TypeCodeFlags of Ex integer types (扩展整数类型). <c>ExIntTypes = TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64 | TypeCodeFlags.Int128 | TypeCodeFlags.UInt128</c>.</summary>
        public static TypeCodeFlags ExIntTypes => IntTypes | PureExIntTypes;
        /// <summary>TypeCodeFlags of Ex all types (扩展所有类型). <c>ExAllTypes = TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64 | TypeCodeFlags.Int128 | TypeCodeFlags.UInt128</c>.</summary>
        public static TypeCodeFlags ExAllTypes => AllTypes | PureExAllTypes;

        // -- IntPtr --
        /// <summary>ElementTypeCode of <see cref="IntPtr"/>.</summary>
        public static readonly ElementTypeCode IntPtrCode;
        /// <summary>ElementTypeCode of <see cref="UIntPtr"/>.</summary>
        public static readonly ElementTypeCode UIntPtrCode;
        /// <summary>TypeCodeFlags of <see cref="IntPtr"/>.</summary>
        public static readonly TypeCodeFlags IntPtrFlags;
        /// <summary>TypeCodeFlags of <see cref="UIntPtr"/>.</summary>
        public static readonly TypeCodeFlags UIntPtrFlags;

        static TypeCodeFlagsUtil() {
            if (sizeof(int) == IntPtr.Size) {
                IntPtrCode = ElementTypeCode.Int32;
                UIntPtrCode = ElementTypeCode.UInt32;
                IntPtrFlags = TypeCodeFlags.Int32;
                UIntPtrFlags = TypeCodeFlags.UInt32;
            } else {
                IntPtrCode = ElementTypeCode.Int64;
                UIntPtrCode = ElementTypeCode.UInt64;
                IntPtrFlags = TypeCodeFlags.Int64;
                UIntPtrFlags = TypeCodeFlags.UInt64;
            }
        }

#if NETSTANDARD1_2 || NETSTANDARD1_1 || NETSTANDARD1_0
#else
        /// <summary>
        /// Convert <c>TypeCode</c> to <c>ElementTypeCode</c> (将 <c>TypeCode</c> 转为 <c>ElementTypeCode</c>).
        /// </summary>
        /// <param name="code">Source code.</param>
        /// <returns>Returns a <c>ElementTypeCode</c>.</returns>
        public static ElementTypeCode FromTypeCode(TypeCode code) {
            ElementTypeCode rt = ElementTypeCode.Empty;
            switch (code) {
                case TypeCode.SByte:
                case TypeCode.Byte:
                case TypeCode.Int16:
                case TypeCode.UInt16:
                case TypeCode.Int32:
                case TypeCode.UInt32:
                case TypeCode.Int64:
                case TypeCode.UInt64:
                case TypeCode.Single:
                case TypeCode.Double:
                    rt = (ElementTypeCode)code;
                    break;
            }
            return rt;
        }

        /// <summary>
        /// Convert <c>ElementTypeCode</c> to <c>TypeCode</c> (将 <c>ElementTypeCode</c> 转为 <c>TypeCode</c>).
        /// </summary>
        /// <param name="code">Source code.</param>
        /// <returns>Returns a <c>TypeCode</c>.</returns>
        public static TypeCode ToTypeCode(ElementTypeCode code) {
            TypeCode rt = TypeCode.Empty;
            switch (code) {
                case ElementTypeCode.SByte:
                case ElementTypeCode.Byte:
                case ElementTypeCode.Int16:
                case ElementTypeCode.UInt16:
                case ElementTypeCode.Int32:
                case ElementTypeCode.UInt32:
                case ElementTypeCode.Int64:
                case ElementTypeCode.UInt64:
                case ElementTypeCode.Single:
                case ElementTypeCode.Double:
                    rt = (TypeCode)code;
                    break;
            }
            return rt;
        }

#endif // #if NETSTANDARD1_2 || NETSTANDARD1_1 || NETSTANDARD1_0

        /// <summary>
        /// Convert <c>ElementTypeCode</c> to <c>TypeCodeFlags</c> (将 <c>ElementTypeCode</c> 转为 <c>TypeCodeFlags</c>).
        /// </summary>
        /// <param name="code">Source code.</param>
        /// <returns>Returns a <c>TypeCodeFlags</c>.</returns>
        public static TypeCodeFlags FlagsFromTypeCode(ElementTypeCode code) {
            return FlagsFromTypeCode((int)code);
        }

        /// <summary>
        /// Convert <c>ElementTypeCode</c> to <c>TypeCodeFlags</c> (将 <c>ElementTypeCode</c> 转为 <c>TypeCodeFlags</c>). The code is int value.
        /// </summary>
        /// <param name="code">Source code.</param>
        /// <returns>Returns a <c>TypeCodeFlags</c>.</returns>
        public static TypeCodeFlags FlagsFromTypeCode(int code) {
            return (TypeCodeFlags)(1 << code);
        }

        /// <summary>
        /// Performs the specified action on each element of the specified <see cref="TypeCodeFlags"/> (对指定 TypeCodeFlags 的每个元素执行指定动作).
        /// </summary>
        /// <param name="src">Source value.</param>
        /// <param name="action">The Action to perform on each element of <paramref name="src"/>.</param>
        public static void ForEach(TypeCodeFlags src, Action<ElementTypeCode> action) {
            int nsrc = (int)src;
            int cnt = sizeof(int) * 8;
            int mask = 1;
            for (int i = 0; i < cnt; ++i) {
                if ((nsrc & mask) != 0) {
                    action((ElementTypeCode)i);
                }
                // next.
                mask <<= 1;
            }
        }

        /// <summary>
        /// Mapping old flags to new flags (将旧标志映射为新标志).
        /// </summary>
        /// <param name="src">Source value (源值).</param>
        /// <param name="matchFlag">Flags to be matched (欲匹配的标志)</param>
        /// <param name="newFlag">New flag (新的标志).</param>
        /// <returns>Returns the mapped value(返回映射后的值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TypeCodeFlags MapFlags(TypeCodeFlags src, TypeCodeFlags matchFlag, TypeCodeFlags newFlag) {
            return (TypeCodeFlags)BitMathCore.MapFlags((int)src, (int)matchFlag, (int)newFlag);
        }

        /// <summary>
        /// Mapping 2 groups of old flags to new flags (将2组旧标志映射为新标志).
        /// </summary>
        /// <param name="src">Source value (源值).</param>
        /// <param name="matchFlag0">Flags to be matched 0 (欲匹配的标志0)</param>
        /// <param name="newFlag0">New flag 0 (新的标志0).</param>
        /// <param name="matchFlag1">Flags to be matched 1 (欲匹配的标志1)</param>
        /// <param name="newFlag1">New flag 1 (新的标志1).</param>
        /// <returns>Returns the mapped value(返回映射后的值).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TypeCodeFlags MapFlags(TypeCodeFlags src, TypeCodeFlags matchFlag0, TypeCodeFlags newFlag0, TypeCodeFlags matchFlag1, TypeCodeFlags newFlag1) {
            return (TypeCodeFlags)BitMathCore.MapFlags((int)src, (int)matchFlag0, (int)newFlag0, (int)matchFlag1, (int)newFlag1);
        }

        /// <summary>
        /// Convert to <see cref="IEnumerable{T}"/> (转为 <see cref="IEnumerable{T}"/>).
        /// </summary>
        /// <param name="src">Source value.</param>
        /// <returns>Returns a ElementTypeCode <c>IEnumerable</c>.</returns>
        public static IEnumerable<ElementTypeCode> ToEnumerable(TypeCodeFlags src) {
            int nsrc = (int)src;
            int cnt = sizeof(int) * 8;
            int mask = 1;
            for(int i=0; i<cnt; ++i) {
                if ((nsrc & mask) != 0) {
                    yield return (ElementTypeCode)i;
                }
                // next.
                mask <<= 1;
            }
        }

    }
}
