using System;
using System.Collections.Generic;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// <see cref="Vector256{T}"/> traits interface (<see cref="Vector256{T}"/> 的特征接口).
    /// </summary>
    [CLSCompliant(false)]
    public interface IWVectorTraits256 : IWVectorTraits {
#if NETCOREAPP3_0_OR_GREATER

        // == .NET style  ==
        #region .NET_style

        /// <summary>
        /// Types with hardware acceleration when running <c>AndNot</c> (运行 <c>AndNot</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="AndNot"/>
        TypeCodeFlags AndNot_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the bitwise-and of a given vector and the ones complement of another vector (计算一个给定的向量和另一个向量反码的位与).
        /// Mnemonic: <c>rt[i] := left[i] &amp; ~right[i]</c>.
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="left">The vector to bitwise-and with <paramref name="right" /> (将会与<paramref name="right" />进行位与运算的向量).</param>
        /// <param name="right">The vector to that is ones-complemented before being bitwise-and with <paramref name="left" /> (将会与<paramref name="left" />进行位与运算, 并使用反码的向量).</param>
        /// <returns>The bitwise-and of <paramref name="left" /> and the ones-complement of <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />反码 的位与运算结果).</returns>
        /// <seealso cref="AndNot_AcceleratedTypes"/>
        /// <seealso cref="Vector256.AndNot{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<T> AndNot<T>(Vector256<T> left, Vector256<T> right) where T : struct;


        /// <summary>
        /// Types with hardware acceleration when running <c>BitwiseAnd</c> (运行 <c>BitwiseAnd</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="BitwiseAnd"/>
        TypeCodeFlags BitwiseAnd_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the bitwise-and of two vectors (计算两个向量的位与).
        /// Mnemonic: <c>rt[i] := left[i] &amp; right[i]</c>.
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="left">The vector to bitwise-and with <paramref name="right" /> (将会与<paramref name="right" />进行位与运算的向量).</param>
        /// <param name="right">The vector to bitwise-and with <paramref name="left" /> (将会与<paramref name="left" />进行位与运算的向量).</param>
        /// <returns>The bitwise-and of <paramref name="left" /> and <paramref name="right"/> (<paramref name="left" /> 与 <paramref name="right" /> 的位与运算结果).</returns>
        /// <seealso cref="BitwiseAnd_AcceleratedTypes"/>
        /// <seealso cref="Vector256.BitwiseAnd{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<T> BitwiseAnd<T>(Vector256<T> left, Vector256<T> right) where T : struct;


        /// <summary>
        /// Types with hardware acceleration when running <c>BitwiseOr</c> (运行 <c>BitwiseOr</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="BitwiseOr"/>
        TypeCodeFlags BitwiseOr_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the bitwise-or of two vectors (计算两个向量的位或).
        /// Mnemonic: <c>rt[i] := left[i] | right[i]</c>.
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="left">The vector to bitwise-or with <paramref name="right" /> (将会与<paramref name="right" />进行位或运算的向量).</param>
        /// <param name="right">The vector to bitwise-or with <paramref name="left" /> (将会与<paramref name="left" />进行位或运算的向量).</param>
        /// <returns>The bitwise-or of <paramref name="left" /> and <paramref name="right"/> (<paramref name="left" /> 与 <paramref name="right" /> 的位或运算结果).</returns>
        /// <seealso cref="BitwiseOr_AcceleratedTypes"/>
        /// <seealso cref="Vector256.BitwiseOr{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<T> BitwiseOr<T>(Vector256<T> left, Vector256<T> right) where T : struct;


        /// <summary>
        /// Types with hardware acceleration when running <c>Ceiling</c> (运行 <c>Ceiling</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Ceiling"/>
        TypeCodeFlags Ceiling_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the ceiling of each element in a vector (计算向量中每个元素的向上舍入).
        /// Mnemonic: <c>rt[i] := ceiling(value[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its ceiling computed (将计算向上舍入的向量).</param>
        /// <returns>A vector whose elements are the ceiling of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的向上舍入).</returns>
        /// <seealso cref="Ceiling_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Ceiling(Vector256{float})" />
        Vector256<float> Ceiling(Vector256<float> value);

        /// <summary>
        /// Computes the ceiling of each element in a vector (计算向量中每个元素的向上舍入).
        /// Mnemonic: <c>rt[i] := ceiling(value[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its ceiling computed (将计算向上舍入的向量).</param>
        /// <returns>A vector whose elements are the ceiling of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的向上舍入).</returns>
        /// <seealso cref="Ceiling_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Ceiling(Vector256{double})" />
        Vector256<double> Ceiling(Vector256<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>ConditionalSelect</c> (运行 <c>ConditionalSelect</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="ConditionalSelect"/>
        TypeCodeFlags ConditionalSelect_AcceleratedTypes { get; }

        /// <summary>
        /// Conditionally selects a value from two vectors on a bitwise basis (按条件从两个向量中按位选择值).
        /// Mnemonic: <c>rt[i] := (left[i] &amp; condition[i]) | (right[i] &amp; ~condition[i])</c>.
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The vector that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的向量).</param>
        /// <param name="right">The vector that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的向量).</param>
        /// <returns>A vector whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个向量，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        /// <seealso cref="ConditionalSelect_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ConditionalSelect{T}(Vector256{T}, Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<T> ConditionalSelect<T>(Vector256<T> condition, Vector256<T> left, Vector256<T> right) where T : struct;

        /// <summary>
        /// Conditionally selects a value from two vectors on a bitwise basis (按条件从两个向量中按位选择值).
        /// Mnemonic: <c>rt[i] := (left[i] &amp; condition[i]) | (right[i] &amp; ~condition[i])</c>.
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The vector that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的向量).</param>
        /// <param name="right">The vector that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的向量).</param>
        /// <returns>A vector whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个向量，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        /// <seealso cref="Vector256.ConditionalSelect{T}(Vector256{T}, Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<float> ConditionalSelect(Vector256<int> condition, Vector256<float> left, Vector256<float> right);

        /// <summary>
        /// Conditionally selects a value from two vectors on a bitwise basis (按条件从两个向量中按位选择值).
        /// Mnemonic: <c>rt[i] := (left[i] &amp; condition[i]) | (right[i] &amp; ~condition[i])</c>.
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The vector that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的向量).</param>
        /// <param name="right">The vector that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的向量).</param>
        /// <returns>A vector whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个向量，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        /// <seealso cref="Vector256.ConditionalSelect{T}(Vector256{T}, Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<double> ConditionalSelect(Vector256<long> condition, Vector256<double> left, Vector256<double> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>Floor</c> (运行 <c>Floor</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Floor"/>
        TypeCodeFlags Floor_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the floor of each element in a vector (计算向量中每个元素的向下舍入).
        /// Mnemonic: <c>rt[i] := floor(value[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its floor computed (将计算向下舍入的向量).</param>
        /// <returns>A vector whose elements are the floor of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的向下舍入).</returns>
        /// <seealso cref="Floor_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Floor(Vector256{float})" />
        Vector256<float> Floor(Vector256<float> value);

        /// <summary>
        /// Computes the floor of each element in a vector (计算向量中每个元素的向下舍入).
        /// Mnemonic: <c>rt[i] := floor(value[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its floor computed (将计算向下舍入的向量).</param>
        /// <returns>A vector whose elements are the floor of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的向下舍入).</returns>
        /// <seealso cref="Floor_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Floor(Vector256{double})" />
        Vector256<double> Floor(Vector256<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>Negate</c> (运行 <c>Negate</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Negate"/>
        TypeCodeFlags Negate_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the negate of a vector (计算向量的相反数).
        /// Mnemonic: <c>rt[i] := -vector[i]</c>.
        /// </summary>
        /// <param name="vector">The vector to negate (将计算相反数的向量).</param>
        /// <returns>A vector whose elements are the negate of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的相反数).</returns>
        /// <seealso cref="Negate_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Negate{T}(Vector256{T})" />
        Vector256<float> Negate(Vector256<float> vector);

        /// <summary>
        /// Computes the negate of a vector (计算向量的相反数).
        /// Mnemonic: <c>rt[i] := -vector[i]</c>.
        /// </summary>
        /// <param name="vector">The vector to negate (将计算相反数的向量).</param>
        /// <returns>A vector whose elements are the negate of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的相反数).</returns>
        /// <seealso cref="Negate_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Negate{T}(Vector256{T})" />
        Vector256<double> Negate(Vector256<double> vector);

        /// <summary>
        /// Computes the negate of a vector (计算向量的相反数).
        /// Mnemonic: <c>rt[i] := -vector[i]</c>.
        /// </summary>
        /// <param name="vector">The vector to negate (将计算相反数的向量).</param>
        /// <returns>A vector whose elements are the negate of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的相反数).</returns>
        /// <seealso cref="Negate_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Negate{T}(Vector256{T})" />
        Vector256<sbyte> Negate(Vector256<sbyte> vector);

        /// <summary>
        /// Computes the negate of a vector (计算向量的相反数).
        /// Mnemonic: <c>rt[i] := -vector[i]</c>.
        /// </summary>
        /// <param name="vector">The vector to negate (将计算相反数的向量).</param>
        /// <returns>A vector whose elements are the negate of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的相反数).</returns>
        /// <seealso cref="Negate_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Negate{T}(Vector256{T})" />
        Vector256<short> Negate(Vector256<short> vector);

        /// <summary>
        /// Computes the negate of a vector (计算向量的相反数).
        /// Mnemonic: <c>rt[i] := -vector[i]</c>.
        /// </summary>
        /// <param name="vector">The vector to negate (将计算相反数的向量).</param>
        /// <returns>A vector whose elements are the negate of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的相反数).</returns>
        /// <seealso cref="Negate_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Negate{T}(Vector256{T})" />
        Vector256<int> Negate(Vector256<int> vector);

        /// <summary>
        /// Computes the negate of a vector (计算向量的相反数).
        /// Mnemonic: <c>rt[i] := -vector[i]</c>.
        /// </summary>
        /// <param name="vector">The vector to negate (将计算相反数的向量).</param>
        /// <returns>A vector whose elements are the negate of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的相反数).</returns>
        /// <seealso cref="Negate_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Negate{T}(Vector256{T})" />
        Vector256<long> Negate(Vector256<long> vector);


        /// <summary>
        /// Types with hardware acceleration when running <c>OnesComplement</c> (运行 <c>OnesComplement</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="OnesComplement"/>
        TypeCodeFlags OnesComplement_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the ones-complement of a vector (计算向量的反码).
        /// Mnemonic: <c>rt[i] := ~vector[i]</c>.
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="vector">The vector whose ones-complement is to be computed (要计算其反码的向量).</param>
        /// <returns>A vector whose elements are the ones-complement of the corresponding elements in <paramref name="vector" /> (一个向量，其元素是<paramref name="vector" />相应元素的反码).</returns>
        /// <seealso cref="OnesComplement_AcceleratedTypes"/>
        /// <seealso cref="Vector256.OnesComplement{T}(Vector256{T})"/> // Since: .NET 7
        Vector256<T> OnesComplement<T>(Vector256<T> vector) where T : struct;


        /// <summary>
        /// Types with hardware acceleration when running <c>ShiftLeft</c> (运行 <c>ShiftLeft</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="ShiftLeft"/>
        TypeCodeFlags ShiftLeft_AcceleratedTypes { get; }

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ShiftLeft(Vector256{sbyte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeftFast(Vector256{sbyte}, int)"/> // Since: VectorTraits 1.0
        Vector256<sbyte> ShiftLeft(Vector256<sbyte> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ShiftLeft(Vector256{byte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeftFast(Vector256{byte}, int)"/> // Since: VectorTraits 1.0
        Vector256<byte> ShiftLeft(Vector256<byte> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ShiftLeft(Vector256{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeftFast(Vector256{short}, int)"/> // Since: VectorTraits 1.0
        Vector256<short> ShiftLeft(Vector256<short> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ShiftLeft(Vector256{ushort}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeftFast(Vector256{ushort}, int)"/> // Since: VectorTraits 1.0
        Vector256<ushort> ShiftLeft(Vector256<ushort> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ShiftLeft(Vector256{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeftFast(Vector256{int}, int)"/> // Since: VectorTraits 1.0
        Vector256<int> ShiftLeft(Vector256<int> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ShiftLeft(Vector256{uint}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeftFast(Vector256{uint}, int)"/> // Since: VectorTraits 1.0
        Vector256<uint> ShiftLeft(Vector256<uint> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ShiftLeft(Vector256{long}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeftFast(Vector256{long}, int)"/> // Since: VectorTraits 1.0
        Vector256<long> ShiftLeft(Vector256<long> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ShiftLeft(Vector256{ulong}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeftFast(Vector256{ulong}, int)"/> // Since: VectorTraits 1.0
        Vector256<ulong> ShiftLeft(Vector256<ulong> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ShiftLeft(Vector256{sbyte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector256{sbyte}, int)"/> // Since: VectorTraits 1.0
        Vector256<sbyte> ShiftLeftFast(Vector256<sbyte> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ShiftLeft(Vector256{byte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector256{byte}, int)"/> // Since: VectorTraits 1.0
        Vector256<byte> ShiftLeftFast(Vector256<byte> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ShiftLeft(Vector256{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector256{short}, int)"/> // Since: VectorTraits 1.0
        Vector256<short> ShiftLeftFast(Vector256<short> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ShiftLeft(Vector256{ushort}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector256{ushort}, int)"/> // Since: VectorTraits 1.0
        Vector256<ushort> ShiftLeftFast(Vector256<ushort> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ShiftLeft(Vector256{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector256{int}, int)"/> // Since: VectorTraits 1.0
        Vector256<int> ShiftLeftFast(Vector256<int> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ShiftLeft(Vector256{uint}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector256{uint}, int)"/> // Since: VectorTraits 1.0
        Vector256<uint> ShiftLeftFast(Vector256<uint> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ShiftLeft(Vector256{long}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector256{long}, int)"/> // Since: VectorTraits 1.0
        Vector256<long> ShiftLeftFast(Vector256<long> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ShiftLeft(Vector256{ulong}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector256{ulong}, int)"/> // Since: VectorTraits 1.0
        Vector256<ulong> ShiftLeftFast(Vector256<ulong> value, int shiftAmount);


        /// <summary>
        /// Types with hardware acceleration when running <c>ShiftRightArithmetic</c> (运行 <c>ShiftRightArithmetic</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="ShiftRightArithmetic"/>
        TypeCodeFlags ShiftRightArithmetic_AcceleratedTypes { get; }

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ShiftRightArithmetic(Vector256{sbyte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmeticFast(Vector256{sbyte}, int)"/> // Since: VectorTraits 1.0
        Vector256<sbyte> ShiftRightArithmetic(Vector256<sbyte> value, int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ShiftRightArithmetic(Vector256{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmeticFast(Vector256{short}, int)"/> // Since: VectorTraits 1.0
        Vector256<short> ShiftRightArithmetic(Vector256<short> value, int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ShiftRightArithmetic(Vector256{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmeticFast(Vector256{int}, int)"/> // Since: VectorTraits 1.0
        Vector256<int> ShiftRightArithmetic(Vector256<int> value, int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ShiftRightArithmetic(Vector256{long}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmeticFast(Vector256{long}, int)"/> // Since: VectorTraits 1.0
        Vector256<long> ShiftRightArithmetic(Vector256<long> value, int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount - Fast(将向量的每个有符号元素算术右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ShiftRightArithmetic(Vector256{sbyte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic(Vector256{sbyte}, int)"/> // Since: VectorTraits 1.0
        Vector256<sbyte> ShiftRightArithmeticFast(Vector256<sbyte> value, int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount - Fast(将向量的每个有符号元素算术右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ShiftRightArithmetic(Vector256{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic(Vector256{short}, int)"/> // Since: VectorTraits 1.0
        Vector256<short> ShiftRightArithmeticFast(Vector256<short> value, int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount - Fast(将向量的每个有符号元素算术右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ShiftRightArithmetic(Vector256{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic(Vector256{int}, int)"/> // Since: VectorTraits 1.0
        Vector256<int> ShiftRightArithmeticFast(Vector256<int> value, int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount - Fast(将向量的每个有符号元素算术右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ShiftRightArithmetic(Vector256{long}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic(Vector256{long}, int)"/> // Since: VectorTraits 1.0
        Vector256<long> ShiftRightArithmeticFast(Vector256<long> value, int shiftAmount);


        /// <summary>
        /// Types with hardware acceleration when running <c>ShiftRightLogical</c> (运行 <c>ShiftRightLogical</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="ShiftRightLogical"/>
        TypeCodeFlags ShiftRightLogical_AcceleratedTypes { get; }

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted righ by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ShiftRightLogical(Vector256{sbyte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogicalFast(Vector256{sbyte}, int)"/> // Since: VectorTraits 1.0
        Vector256<sbyte> ShiftRightLogical(Vector256<sbyte> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted righ by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ShiftRightLogical(Vector256{byte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogicalFast(Vector256{byte}, int)"/> // Since: VectorTraits 1.0
        Vector256<byte> ShiftRightLogical(Vector256<byte> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted righ by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ShiftRightLogical(Vector256{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogicalFast(Vector256{short}, int)"/> // Since: VectorTraits 1.0
        Vector256<short> ShiftRightLogical(Vector256<short> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted righ by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ShiftRightLogical(Vector256{ushort}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogicalFast(Vector256{ushort}, int)"/> // Since: VectorTraits 1.0
        Vector256<ushort> ShiftRightLogical(Vector256<ushort> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted righ by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ShiftRightLogical(Vector256{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogicalFast(Vector256{int}, int)"/> // Since: VectorTraits 1.0
        Vector256<int> ShiftRightLogical(Vector256<int> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted righ by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ShiftRightLogical(Vector256{uint}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogicalFast(Vector256{uint}, int)"/> // Since: VectorTraits 1.0
        Vector256<uint> ShiftRightLogical(Vector256<uint> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted righ by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ShiftRightLogical(Vector256{long}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogicalFast(Vector256{long}, int)"/> // Since: VectorTraits 1.0
        Vector256<long> ShiftRightLogical(Vector256<long> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted righ by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ShiftRightLogical(Vector256{ulong}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogicalFast(Vector256{ulong}, int)"/> // Since: VectorTraits 1.0
        Vector256<ulong> ShiftRightLogical(Vector256<ulong> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted righ by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ShiftRightLogical(Vector256{sbyte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector256{sbyte}, int)"/> // Since: VectorTraits 1.0
        Vector256<sbyte> ShiftRightLogicalFast(Vector256<sbyte> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted righ by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ShiftRightLogical(Vector256{byte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector256{byte}, int)"/> // Since: VectorTraits 1.0
        Vector256<byte> ShiftRightLogicalFast(Vector256<byte> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted righ by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ShiftRightLogical(Vector256{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector256{short}, int)"/> // Since: VectorTraits 1.0
        Vector256<short> ShiftRightLogicalFast(Vector256<short> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted righ by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ShiftRightLogical(Vector256{ushort}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector256{ushort}, int)"/> // Since: VectorTraits 1.0
        Vector256<ushort> ShiftRightLogicalFast(Vector256<ushort> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted righ by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ShiftRightLogical(Vector256{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector256{int}, int)"/> // Since: VectorTraits 1.0
        Vector256<int> ShiftRightLogicalFast(Vector256<int> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted righ by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ShiftRightLogical(Vector256{uint}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector256{uint}, int)"/> // Since: VectorTraits 1.0
        Vector256<uint> ShiftRightLogicalFast(Vector256<uint> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted righ by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ShiftRightLogical(Vector256{long}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector256{long}, int)"/> // Since: VectorTraits 1.0
        Vector256<long> ShiftRightLogicalFast(Vector256<long> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted righ by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ShiftRightLogical(Vector256{ulong}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector256{ulong}, int)"/> // Since: VectorTraits 1.0
        Vector256<ulong> ShiftRightLogicalFast(Vector256<ulong> value, int shiftAmount);


        /// <summary>
        /// Types with hardware acceleration when running <c>Xor</c> (运行 <c>Xor</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Xor"/>
        TypeCodeFlags Xor_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the exclusive-or of two vectors (计算两个向量的位异或).
        /// Mnemonic: <c>rt[i] := left[i] ^ right[i]</c>.
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="left">The vector to exclusive-or with <paramref name="right" /> (将会与<paramref name="right" />进行位异或运算的向量).</param>
        /// <param name="right">The vector to exclusive-or with <paramref name="left" /> (将会与<paramref name="left" />进行位异或运算的向量).</param>
        /// <returns>The exclusive-or of <paramref name="left" /> and <paramref name="right"/> (<paramref name="left" /> 与 <paramref name="right" /> 的位异或运算结果).</returns>
        /// <seealso cref="Xor_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Xor{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<T> Xor<T>(Vector256<T> left, Vector256<T> right) where T : struct;

        #endregion // .NET_style

        // == X86 style  ==
        #region X86_style
        #endregion // X86_style

        // == mY style  ==
        #region mY_style
        #endregion // mY_style

#endif
    }
}
