﻿using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// <see cref="Vector{T}"/> traits interface (<see cref="Vector{T}"/> 的特征接口).
    /// </summary>
    [CLSCompliant(false)]
    public interface IVectorTraits : IBaseTraits {

        // == .NET style  ==
        #region .NET_style

        /// <summary>
        /// Types with hardware acceleration when running <c>Ceiling</c> (运行 <c>Ceiling</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Ceiling"/>
        TypeCodeFlags Ceiling_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the ceiling of each element in a vector (计算向量中每个元素的向上舍入).
        /// Mnemonic: <c>r[i] := ceiling(value[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its ceiling computed (将计算向上舍入的向量).</param>
        /// <returns>A vector whose elements are the ceiling of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的向上舍入).</returns>
        /// <seealso cref="Ceiling_AcceleratedTypes"/>
        /// <seealso cref="Vector.Ceiling(Vector{float})" />
        Vector<float> Ceiling(Vector<float> value);

        /// <summary>
        /// Computes the ceiling of each element in a vector (计算向量中每个元素的向上舍入).
        /// Mnemonic: <c>r[i] := ceiling(value[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its ceiling computed (将计算向上舍入的向量).</param>
        /// <returns>A vector whose elements are the ceiling of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的向上舍入).</returns>
        /// <seealso cref="Ceiling_AcceleratedTypes"/>
        /// <seealso cref="Vector.Ceiling(Vector{double})" />
        Vector<double> Ceiling(Vector<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>Floor</c> (运行 <c>Floor</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Floor"/>
        TypeCodeFlags Floor_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the floor of each element in a vector (计算向量中每个元素的向下舍入).
        /// Mnemonic: <c>r[i] := floor(value[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its floor computed (将计算向下舍入的向量).</param>
        /// <returns>A vector whose elements are the floor of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的向下舍入).</returns>
        /// <seealso cref="Floor_AcceleratedTypes"/>
        /// <seealso cref="Vector.Floor(Vector{float})" />
        Vector<float> Floor(Vector<float> value);

        /// <summary>
        /// Computes the floor of each element in a vector (计算向量中每个元素的向下舍入).
        /// Mnemonic: <c>r[i] := floor(value[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its floor computed (将计算向下舍入的向量).</param>
        /// <returns>A vector whose elements are the floor of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的向下舍入).</returns>
        /// <seealso cref="Floor_AcceleratedTypes"/>
        /// <seealso cref="Vector.Floor(Vector{double})" />
        Vector<double> Floor(Vector<double> value);


        // 对于8、16位的移位, C# 会扩展到32位来处理. 但对于SIMD的紧缩8、16位数据来说, 扩展到32位后的运算结果会不符, 故应该先对 shiftAmount 做 bitwise-and 运算限制在合理范围内. 实测发现.NET6仍然是扩展到32位, 而 .NET7 也用掩码处理, 故本类库与 .NET7 保持了一致.
        // ---
        // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/bitwise-and-shift-operators
        // Left-shift operator <<
        // ...
        // Because the shift operators are defined only for the int, uint, long, and ulong types, the result of an operation always contains at least 32 bits. If the left-hand operand is of another integral type (sbyte, byte, short, ushort, or char), its value is converted to the int type, as the following example shows:
        // C#
        // byte a = 0b_1111_0001;
        // var b = a << 8;
        // ...
        // Shift amount of the shift operators
        // For the built-in shift operators <<, >>, and >>>, the type of the right-hand operand must be int or a type that has a predefined implicit numeric conversion to int.
        // For the x << count, x >> count, and x >>> count expressions, the actual shift amount depends on the type of x as follows:
        // If the type of x is int or uint, the shift amount is defined by the low-order five bits of the right-hand operand. That is, the shift amount is computed from count & 0x1F (or count & 0b_1_1111).
        // If the type of x is long or ulong, the shift amount is defined by the low-order six bits of the right-hand operand. That is, the shift amount is computed from count & 0x3F (or count & 0b_11_1111).

        /// <summary>
        /// Types with hardware acceleration when running <c>ShiftLeft</c> (运行 <c>ShiftLeft</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="ShiftLeft"/>
        TypeCodeFlags ShiftLeft_AcceleratedTypes { get; }

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>r[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftLeft(Vector{sbyte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeftFast(Vector{sbyte}, int)"/> // Since: VectorTraits 1.0
        Vector<sbyte> ShiftLeft(Vector<sbyte> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>r[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftLeft(Vector{byte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeftFast(Vector{byte}, int)"/> // Since: VectorTraits 1.0
        Vector<byte> ShiftLeft(Vector<byte> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>r[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftLeft(Vector{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeftFast(Vector{short}, int)"/> // Since: VectorTraits 1.0
        Vector<short> ShiftLeft(Vector<short> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>r[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftLeft(Vector{ushort}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeftFast(Vector{ushort}, int)"/> // Since: VectorTraits 1.0
        Vector<ushort> ShiftLeft(Vector<ushort> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>r[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftLeft(Vector{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeftFast(Vector{int}, int)"/> // Since: VectorTraits 1.0
        Vector<int> ShiftLeft(Vector<int> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>r[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftLeft(Vector{uint}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeftFast(Vector{uint}, int)"/> // Since: VectorTraits 1.0
        Vector<uint> ShiftLeft(Vector<uint> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>r[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftLeft(Vector{long}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeftFast(Vector{long}, int)"/> // Since: VectorTraits 1.0
        Vector<long> ShiftLeft(Vector<long> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>r[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftLeft(Vector{ulong}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeftFast(Vector{ulong}, int)"/> // Since: VectorTraits 1.0
        Vector<ulong> ShiftLeft(Vector<ulong> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>r[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftLeft(Vector{sbyte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector{sbyte}, int)"/> // Since: VectorTraits 1.0
        Vector<sbyte> ShiftLeftFast(Vector<sbyte> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>r[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftLeft(Vector{byte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector{byte}, int)"/> // Since: VectorTraits 1.0
        Vector<byte> ShiftLeftFast(Vector<byte> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>r[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftLeft(Vector{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector{short}, int)"/> // Since: VectorTraits 1.0
        Vector<short> ShiftLeftFast(Vector<short> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>r[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftLeft(Vector{ushort}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector{ushort}, int)"/> // Since: VectorTraits 1.0
        Vector<ushort> ShiftLeftFast(Vector<ushort> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>r[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftLeft(Vector{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector{int}, int)"/> // Since: VectorTraits 1.0
        Vector<int> ShiftLeftFast(Vector<int> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>r[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftLeft(Vector{uint}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector{uint}, int)"/> // Since: VectorTraits 1.0
        Vector<uint> ShiftLeftFast(Vector<uint> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>r[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftLeft(Vector{long}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector{long}, int)"/> // Since: VectorTraits 1.0
        Vector<long> ShiftLeftFast(Vector<long> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>r[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftLeft(Vector{ulong}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector{ulong}, int)"/> // Since: VectorTraits 1.0
        Vector<ulong> ShiftLeftFast(Vector<ulong> value, int shiftAmount);


        /// <summary>
        /// Types with hardware acceleration when running <c>ShiftRightArithmetic</c> (运行 <c>ShiftRightArithmetic</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="ShiftRightArithmetic"/>
        TypeCodeFlags ShiftRightArithmetic_AcceleratedTypes { get; }

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量).
        /// Mnemonic: <c>r[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightArithmetic(Vector{sbyte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmeticFast(Vector{sbyte}, int)"/> // Since: VectorTraits 1.0
        Vector<sbyte> ShiftRightArithmetic(Vector<sbyte> value, int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量).
        /// Mnemonic: <c>r[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightArithmetic(Vector{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmeticFast(Vector{short}, int)"/> // Since: VectorTraits 1.0
        Vector<short> ShiftRightArithmetic(Vector<short> value, int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量).
        /// Mnemonic: <c>r[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightArithmetic(Vector{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmeticFast(Vector{int}, int)"/> // Since: VectorTraits 1.0
        Vector<int> ShiftRightArithmetic(Vector<int> value, int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量).
        /// Mnemonic: <c>r[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightArithmetic(Vector{long}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmeticFast(Vector{long}, int)"/> // Since: VectorTraits 1.0
        Vector<long> ShiftRightArithmetic(Vector<long> value, int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount - Fast(将向量的每个有符号元素算术右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>r[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightArithmetic(Vector{sbyte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic(Vector{sbyte}, int)"/> // Since: VectorTraits 1.0
        Vector<sbyte> ShiftRightArithmeticFast(Vector<sbyte> value, int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount - Fast(将向量的每个有符号元素算术右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>r[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightArithmetic(Vector{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic(Vector{short}, int)"/> // Since: VectorTraits 1.0
        Vector<short> ShiftRightArithmeticFast(Vector<short> value, int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount - Fast(将向量的每个有符号元素算术右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>r[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightArithmetic(Vector{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic(Vector{int}, int)"/> // Since: VectorTraits 1.0
        Vector<int> ShiftRightArithmeticFast(Vector<int> value, int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount - Fast(将向量的每个有符号元素算术右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>r[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightArithmetic(Vector{long}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic(Vector{long}, int)"/> // Since: VectorTraits 1.0
        Vector<long> ShiftRightArithmeticFast(Vector<long> value, int shiftAmount);


        /// <summary>
        /// Types with hardware acceleration when running <c>ShiftRightLogical</c> (运行 <c>ShiftRightLogical</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="ShiftRightLogical"/>
        TypeCodeFlags ShiftRightLogical_AcceleratedTypes { get; }

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
        /// Mnemonic: <c>r[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted righ by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{sbyte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogicalFast(Vector{sbyte}, int)"/> // Since: VectorTraits 1.0
        Vector<sbyte> ShiftRightLogical(Vector<sbyte> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
        /// Mnemonic: <c>r[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted righ by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{byte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogicalFast(Vector{byte}, int)"/> // Since: VectorTraits 1.0
        Vector<byte> ShiftRightLogical(Vector<byte> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
        /// Mnemonic: <c>r[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted righ by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogicalFast(Vector{short}, int)"/> // Since: VectorTraits 1.0
        Vector<short> ShiftRightLogical(Vector<short> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
        /// Mnemonic: <c>r[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted righ by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{ushort}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogicalFast(Vector{ushort}, int)"/> // Since: VectorTraits 1.0
        Vector<ushort> ShiftRightLogical(Vector<ushort> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
        /// Mnemonic: <c>r[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted righ by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogicalFast(Vector{int}, int)"/> // Since: VectorTraits 1.0
        Vector<int> ShiftRightLogical(Vector<int> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
        /// Mnemonic: <c>r[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted righ by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{uint}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogicalFast(Vector{uint}, int)"/> // Since: VectorTraits 1.0
        Vector<uint> ShiftRightLogical(Vector<uint> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
        /// Mnemonic: <c>r[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted righ by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{long}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogicalFast(Vector{long}, int)"/> // Since: VectorTraits 1.0
        Vector<long> ShiftRightLogical(Vector<long> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
        /// Mnemonic: <c>r[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted righ by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{ulong}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogicalFast(Vector{ulong}, int)"/> // Since: VectorTraits 1.0
        Vector<ulong> ShiftRightLogical(Vector<ulong> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>r[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted righ by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{sbyte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector{sbyte}, int)"/> // Since: VectorTraits 1.0
        Vector<sbyte> ShiftRightLogicalFast(Vector<sbyte> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>r[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted righ by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{byte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector{byte}, int)"/> // Since: VectorTraits 1.0
        Vector<byte> ShiftRightLogicalFast(Vector<byte> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>r[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted righ by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector{short}, int)"/> // Since: VectorTraits 1.0
        Vector<short> ShiftRightLogicalFast(Vector<short> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>r[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted righ by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{ushort}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector{ushort}, int)"/> // Since: VectorTraits 1.0
        Vector<ushort> ShiftRightLogicalFast(Vector<ushort> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>r[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted righ by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector{int}, int)"/> // Since: VectorTraits 1.0
        Vector<int> ShiftRightLogicalFast(Vector<int> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>r[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted righ by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{uint}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector{uint}, int)"/> // Since: VectorTraits 1.0
        Vector<uint> ShiftRightLogicalFast(Vector<uint> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>r[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted righ by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{long}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector{long}, int)"/> // Since: VectorTraits 1.0
        Vector<long> ShiftRightLogicalFast(Vector<long> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>r[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted righ by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{ulong}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector{ulong}, int)"/> // Since: VectorTraits 1.0
        Vector<ulong> ShiftRightLogicalFast(Vector<ulong> value, int shiftAmount);

        #endregion // .NET_style

        // == X86 style  ==
        #region X86_style
        #endregion // X86_style

        // == mY style  ==
        #region mY_style
        #endregion // mY_style

    }
}
