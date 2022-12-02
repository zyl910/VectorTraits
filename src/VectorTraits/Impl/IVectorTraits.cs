using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// <see cref="Vector{T}"/> traits interface.
    /// </summary>
    public interface IVectorTraits : IBaseTraits {

        // SIMD有打包8、16位的移位需求，若也是扩展到32位，打包运算结果会不符。故应统一将掩码限制拓展到 8、16位. 发现.NET6仍然是扩展到32位, 而 .NET7 也统一将掩码限制拓展到 8、16位.
        // ---
        // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/bitwise-and-shift-operators
        // Left-shift operator <<
        // ...
        // Because the shift operators are defined only for the int, uint, long, and ulong types, the result of an operation always contains at least 32 bits. If the left-hand operand is of another integral type (sbyte, byte, short, ushort, or char), its value is converted to the int type, as the following example shows:
        // C#
        // byte a = 0b_1111_0001;
        // var b = a << 8;
        // ...
        // Shift count of the shift operators
        // For the built-in shift operators <<, >>, and >>>, the type of the right-hand operand must be int or a type that has a predefined implicit numeric conversion to int.
        // For the x << count, x >> count, and x >>> count expressions, the actual shift count depends on the type of x as follows:
        // If the type of x is int or uint, the shift count is defined by the low-order five bits of the right-hand operand. That is, the shift count is computed from count & 0x1F (or count & 0b_1_1111).
        // If the type of x is long or ulong, the shift count is defined by the low-order six bits of the right-hand operand. That is, the shift count is computed from count & 0x3F (or count & 0b_11_1111).

        /// <summary>
        /// Shifts each element of a vector left by the specified amount.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted.</param>
        /// <param name="shiftCount">The number of bits by which to shift each element.</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftCount"/>.</returns>
        /// <seealso cref="Vector.ShiftLeft(Vector256{short}, int)"/> // .NET 7
        Vector<short> ShiftLeft(Vector<short> value, int shiftCount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted.</param>
        /// <param name="shiftCount">The number of bits by which to shift each element.</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftCount"/>.</returns>
        /// <seealso cref="Vector.ShiftLeft(Vector256{int}, int)"/> // .NET 7
        Vector<int> ShiftLeft(Vector<int> value, int shiftCount);


        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted.</param>
        /// <param name="shiftCount">The number of bits by which to shift each element.</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftCount"/>.</returns>
        /// <seealso cref="Vector.ShiftRightArithmetic(Vector256{int}, int)"/> // .NET 7
        Vector<int> ShiftRightArithmetic(Vector<int> value, int shiftCount);

    }
}
