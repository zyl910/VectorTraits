using System;
using System.Collections.Generic;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// <see cref="Vector128{T}"/> traits interface.
    /// </summary>
    public interface IWVectorTraits128 : IWVectorTraits {
#if NETCOREAPP3_0_OR_GREATER
        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>f({ value[i] }, shiftCount) = { value[i] &lt;&lt; shiftCount }</c>, <c>shiftCount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftCount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftCount" /> (每个元素的左移 <paramref name="shiftCount" /> 位的一个向量).</returns>
        /// <seealso cref="Vector128.ShiftLeft(Vector128{byte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeftFast(Vector128{byte}, int)"/> // Since: VectorTraits 1.0
        Vector128<byte> ShiftLeft(Vector128<byte> value, int shiftCount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>f({ value[i] }, shiftCount) = { value[i] &lt;&lt; shiftCount }</c>, <c>shiftCount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftCount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftCount" /> (每个元素的左移 <paramref name="shiftCount" /> 位的一个向量).</returns>
        /// <seealso cref="Vector128.ShiftLeft(Vector128{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeftFast(Vector128{short}, int)"/> // Since: VectorTraits 1.0
        Vector128<short> ShiftLeft(Vector128<short> value, int shiftCount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>f({ value[i] }, shiftCount) = { value[i] &lt;&lt; shiftCount }</c>, <c>shiftCount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftCount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftCount" /> (每个元素的左移 <paramref name="shiftCount" /> 位的一个向量).</returns>
        /// <seealso cref="Vector128.ShiftLeft(Vector128{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeftFast(Vector128{int}, int)"/> // Since: VectorTraits 1.0
        Vector128<int> ShiftLeft(Vector128<int> value, int shiftCount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftCount"/>, please use <see cref="Scalars.LimitShiftCount"/> first.
        /// Mnemonic: <c>f({ value[i] }, shiftCount) = { value[i] &lt;&lt; shiftCount }</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftCount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftCount" /> (每个元素的左移 <paramref name="shiftCount" /> 位的一个向量).</returns>
        /// <seealso cref="Vector128.ShiftLeft(Vector128{byte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector128{byte}, int)"/> // Since: VectorTraits 1.0
        Vector128<byte> ShiftLeftFast(Vector128<byte> value, int shiftCount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftCount"/>, please use <see cref="Scalars.LimitShiftCount"/> first.
        /// Mnemonic: <c>f({ value[i] }, shiftCount) = { value[i] &lt;&lt; shiftCount }</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftCount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftCount" /> (每个元素的左移 <paramref name="shiftCount" /> 位的一个向量).</returns>
        /// <seealso cref="Vector128.ShiftLeft(Vector128{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector128{short}, int)"/> // Since: VectorTraits 1.0
        Vector128<short> ShiftLeftFast(Vector128<short> value, int shiftCount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftCount"/>, please use <see cref="Scalars.LimitShiftCount"/> first.
        /// Mnemonic: <c>f({ value[i] }, shiftCount) = { value[i] &lt;&lt; shiftCount }</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftCount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftCount" /> (每个元素的左移 <paramref name="shiftCount" /> 位的一个向量).</returns>
        /// <seealso cref="Vector128.ShiftLeft(Vector128{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector128{int}, int)"/> // Since: VectorTraits 1.0
        Vector128<int> ShiftLeftFast(Vector128<int> value, int shiftCount);


        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount (将向量的每个带符号元素算术右移指定量).
        /// Mnemonic: <c>f({ value[i] }, shiftCount) = { value[i] &gt;&gt; shiftCount }</c>, <c>shiftCount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftCount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftCount"/> (每个元素的右移 <paramref name="shiftCount" /> 位的一个向量).</returns>
        /// <seealso cref="Vector128.ShiftRightArithmetic(Vector128{int}, int)"/> // Since: .NET 7
        Vector128<int> ShiftRightArithmetic(Vector128<int> value, int shiftCount);

#endif
    }
}
