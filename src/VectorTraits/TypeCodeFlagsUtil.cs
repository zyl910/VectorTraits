using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Zyl.VectorTraits.Numerics;

namespace Zyl.VectorTraits {

    /// <summary>Specifies the type of an vector element. Reference from: https://learn.microsoft.com/en-us/dotnet/api/system.typecode </summary>
    public enum ElementTypeCode {
        /// <summary>A null reference.</summary>
        Empty = 0,
        // /// <summary>A general type representing any reference or value type not explicitly represented by another TypeCode.</summary>
        // Object = 1,
        // /// <summary>A database null (column) value.</summary>
        // DBNull = 2,
        // /// <summary>A simple type representing Boolean values of true or false.</summary>
        // Boolean = 3,
        // /// <summary>An integral type representing unsigned 16-bit integers with values between 0 and 65535. The set of possible values for the System.TypeCode.Char type corresponds to the Unicode character set.</summary>
        // Char = 4,
        /// <summary>An integral type representing signed 8-bit integers with values between -128 and 127.</summary>
        SByte = 5,
        /// <summary>An integral type representing unsigned 8-bit integers with values between 0 and 255.</summary>
        Byte = 6,
        /// <summary>An integral type representing signed 16-bit integers with values between -32768 and 32767.</summary>
        Int16 = 7,
        /// <summary>An integral type representing unsigned 16-bit integers with values between 0 and 65535.</summary>
        UInt16 = 8,
        /// <summary>An integral type representing signed 32-bit integers with values between -2147483648 and 2147483647.</summary>
        Int32 = 9,
        /// <summary>An integral type representing unsigned 32-bit integers with values between 0 and 4294967295.</summary>
        UInt32 = 10,
        /// <summary>An integral type representing signed 64-bit integers with values between -9223372036854775808 and 9223372036854775807.</summary>
        Int64 = 11,
        /// <summary>An integral type representing unsigned 64-bit integers with values between 0 and 18446744073709551615.</summary>
        UInt64 = 12,
        /// <summary>A floating point type representing values ranging from approximately 1.5 x 10^-45 to 3.4 x 10^38 with a precision of 7 digits.</summary>
        Single = 13,
        /// <summary>A floating point type representing values ranging from approximately 5.0 x 10^-324 to 1.7 x 10^308 with a precision of 15-16 digits.</summary>
        Double = 14,
        // /// <summary>A simple type representing values ranging from 1.0 x 10^-28 to approximately 7.9 x 10^28 with 28-29 significant digits.</summary>
        // Decimal = 15,
        // /// <summary>A type representing a date and time value.</summary>
        // DateTime = 16,
        // /// <summary>A sealed class type representing Unicode character strings.</summary>
        // String = 18
    }

    /// <summary><see cref="ElementTypeCode"/> bit flags (元素类型代码位标识).</summary>
    [Flags]
    public enum TypeCodeFlags : Int32 {
        /// <summary>None.</summary>
        None = 0,
        /// <summary>An integral type representing signed 8-bit integers with values between -128 and 127.</summary>
        SByte = 1 << 5,
        /// <summary>An integral type representing unsigned 8-bit integers with values between 0 and 255.</summary>
        Byte = 1 << 6,
        /// <summary>An integral type representing signed 16-bit integers with values between -32768 and 32767.</summary>
        Int16 = 1 << 7,
        /// <summary>An integral type representing unsigned 16-bit integers with values between 0 and 65535.</summary>
        UInt16 = 1 << 8,
        /// <summary>An integral type representing signed 32-bit integers with values between -2147483648 and 2147483647.</summary>
        Int32 = 1 << 9,
        /// <summary>An integral type representing unsigned 32-bit integers with values between 0 and 4294967295.</summary>
        UInt32 = 1 << 10,
        /// <summary>An integral type representing signed 64-bit integers with values between -9223372036854775808 and 9223372036854775807.</summary>
        Int64 = 1 << 11,
        /// <summary>An integral type representing unsigned 64-bit integers with values between 0 and 18446744073709551615.</summary>
        UInt64 = 1 << 12,
        /// <summary>A floating point type representing values ranging from approximately 1.5 x 10^-45 to 3.4 x 10^38 with a precision of 7 digits.</summary>
        Single = 1 << 13,
        /// <summary>A floating point type representing values ranging from approximately 5.0 x 10^-324 to 1.7 x 10^308 with a precision of 15-16 digits.</summary>
        Double = 1 << 14,
    }


    /// <summary>
    /// <see cref="TypeCodeFlags"/> util (类型代码位标识工具).
    /// </summary>
    public static class TypeCodeFlagsUtil {
        /// <summary>TypeCodeFlags of float types.</summary>
        public const TypeCodeFlags FloatTypes = TypeCodeFlags.Single | TypeCodeFlags.Double;
        /// <summary>TypeCodeFlags of integer types.</summary>
        public const TypeCodeFlags IntTypes = TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
        /// <summary>TypeCodeFlags of all types. <c>AllTypes = TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64</c>.</summary>
        public const TypeCodeFlags AllTypes = FloatTypes | IntTypes;

        /// <summary>TypeCodeFlags of most32 float types.</summary>
        public const TypeCodeFlags Most32FloatTypes = TypeCodeFlags.Single;
        /// <summary>TypeCodeFlags of most32 integer types.</summary>
        public const TypeCodeFlags Most32IntTypes = TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
        /// <summary>TypeCodeFlags of most32 types. <c>Most32BaseTypes = TypeCodeFlags.Single | TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32</c>.</summary>
        public const TypeCodeFlags Most32Types = Most32FloatTypes | Most32IntTypes;

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
