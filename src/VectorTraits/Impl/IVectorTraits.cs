using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// <see cref="Vector{T}"/> traits interface.
    /// </summary>
    public interface IVectorTraits : IBaseTraits {

        // 对于8、16位的移位, C# 会扩展到32位来处理. 但对于SIMD的紧缩8、16位数据来说, 扩展到32位后的运算结果会不符, 故应该先对 shiftCount 做 bitwise-and 运算限制在合理范围内. 实测发现.NET6仍然是扩展到32位, 而 .NET7 也用掩码处理, 故本类库与 .NET7 保持了一致.
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
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>f({ value[i] }, shiftCount) = { value[i] &lt;&lt; shiftCount }</c>, <c>shiftCount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftCount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftCount" /> (每个元素的左移 <paramref name="shiftCount" /> 位的一个向量).</returns>
        /// <seealso cref="Vector.ShiftLeft(Vector{byte}, int)"/> // Since: .NET 7
        Vector<byte> ShiftLeft(Vector<byte> value, int shiftCount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>f({ value[i] }, shiftCount) = { value[i] &lt;&lt; shiftCount }</c>, <c>shiftCount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftCount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftCount" /> (每个元素的左移 <paramref name="shiftCount" /> 位的一个向量).</returns>
        /// <seealso cref="Vector.ShiftLeft(Vector{short}, int)"/> // Since: .NET 7
        Vector<short> ShiftLeft(Vector<short> value, int shiftCount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>f({ value[i] }, shiftCount) = { value[i] &lt;&lt; shiftCount }</c>, <c>shiftCount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftCount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftCount" /> (每个元素的左移 <paramref name="shiftCount" /> 位的一个向量).</returns>
        /// <seealso cref="Vector.ShiftLeft(Vector{int}, int)"/> // Since: .NET 7
        Vector<int> ShiftLeft(Vector<int> value, int shiftCount);


        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount (将向量的每个带符号元素算术右移指定量).
        /// Mnemonic: <c>f({ value[i] }, shiftCount) = { value[i] &gt;&gt; shiftCount }</c>, <c>shiftCount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftCount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftCount"/> (每个元素的右移 <paramref name="shiftCount" /> 位的一个向量).</returns>
        /// <seealso cref="Vector.ShiftRightArithmetic(Vector{int}, int)"/> // Since: .NET 7
        Vector<int> ShiftRightArithmetic(Vector<int> value, int shiftCount);

    }
}
