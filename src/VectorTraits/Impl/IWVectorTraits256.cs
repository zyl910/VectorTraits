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
    public partial interface IWVectorTraits256 : IWVectorTraits {
#if NETCOREAPP3_0_OR_GREATER

        // == .NET style  ==

        /// <summary>
        /// Types with hardware acceleration when running <c>Abs</c> (运行 <c>Abs</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Abs"/>
        TypeCodeFlags Abs_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the absolute value of each element in a vector (计算向量中每个元素的绝对值).
        /// Mnemonic: <c>rt[i] := abs(vector[i])</c>.
        /// </summary>
        /// <param name="vector">The vector that will have its absolute value computed (将被计算其绝对值的向量).</param>
        /// <returns>A vector whose elements are the absolute value of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的绝对值).</returns>
        /// <seealso cref="Abs_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Abs{T}(Vector256{T})" />
        Vector256<float> Abs(Vector256<float> vector);

        /// <summary>
        /// Computes the absolute value of each element in a vector (计算向量中每个元素的绝对值).
        /// Mnemonic: <c>rt[i] := abs(vector[i])</c>.
        /// </summary>
        /// <param name="vector">The vector that will have its absolute value computed (将被计算其绝对值的向量).</param>
        /// <returns>A vector whose elements are the absolute value of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的绝对值).</returns>
        /// <seealso cref="Abs_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Abs{T}(Vector256{T})" />
        Vector256<double> Abs(Vector256<double> vector);

        /// <summary>
        /// Computes the absolute value of each element in a vector (计算向量中每个元素的绝对值).
        /// Mnemonic: <c>rt[i] := abs(vector[i])</c>.
        /// </summary>
        /// <param name="vector">The vector that will have its absolute value computed (将被计算其绝对值的向量).</param>
        /// <returns>A vector whose elements are the absolute value of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的绝对值).</returns>
        /// <seealso cref="Abs_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Abs{T}(Vector256{T})" />
        Vector256<sbyte> Abs(Vector256<sbyte> vector);

        /// <summary>
        /// Computes the absolute value of each element in a vector (计算向量中每个元素的绝对值).
        /// Mnemonic: <c>rt[i] := abs(vector[i])</c>.
        /// </summary>
        /// <param name="vector">The vector that will have its absolute value computed (将被计算其绝对值的向量).</param>
        /// <returns>A vector whose elements are the absolute value of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的绝对值).</returns>
        /// <seealso cref="Abs_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Abs{T}(Vector256{T})" />
        Vector256<short> Abs(Vector256<short> vector);

        /// <summary>
        /// Computes the absolute value of each element in a vector (计算向量中每个元素的绝对值).
        /// Mnemonic: <c>rt[i] := abs(vector[i])</c>.
        /// </summary>
        /// <param name="vector">The vector that will have its absolute value computed (将被计算其绝对值的向量).</param>
        /// <returns>A vector whose elements are the absolute value of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的绝对值).</returns>
        /// <seealso cref="Abs_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Abs{T}(Vector256{T})" />
        Vector256<int> Abs(Vector256<int> vector);

        /// <summary>
        /// Computes the absolute value of each element in a vector (计算向量中每个元素的绝对值).
        /// Mnemonic: <c>rt[i] := abs(vector[i])</c>.
        /// </summary>
        /// <param name="vector">The vector that will have its absolute value computed (将被计算其绝对值的向量).</param>
        /// <returns>A vector whose elements are the absolute value of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的绝对值).</returns>
        /// <seealso cref="Abs_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Abs{T}(Vector256{T})" />
        Vector256<long> Abs(Vector256<long> vector);


        /// <summary>
        /// Types with hardware acceleration when running <c>Add</c> (运行 <c>Add</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Add"/>
        TypeCodeFlags Add_AcceleratedTypes { get; }

        /// <summary>
        /// Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
        /// Mnemonic: <c>rt[i] := left[i] + right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to add with <paramref name="right" /> (将会与<paramref name="right" />进行相加的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The sum of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的和).</returns>
        /// <seealso cref="Add_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Add{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<float> Add(Vector256<float> left, Vector256<float> right);

        /// <summary>
        /// Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
        /// Mnemonic: <c>rt[i] := left[i] + right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to add with <paramref name="right" /> (将会与<paramref name="right" />进行相加的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The sum of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的和).</returns>
        /// <seealso cref="Add_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Add{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<double> Add(Vector256<double> left, Vector256<double> right);

        /// <summary>
        /// Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
        /// Mnemonic: <c>rt[i] := left[i] + right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to add with <paramref name="right" /> (将会与<paramref name="right" />进行相加的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The sum of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的和).</returns>
        /// <seealso cref="Add_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Add{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<sbyte> Add(Vector256<sbyte> left, Vector256<sbyte> right);

        /// <summary>
        /// Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
        /// Mnemonic: <c>rt[i] := left[i] + right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to add with <paramref name="right" /> (将会与<paramref name="right" />进行相加的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The sum of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的和).</returns>
        /// <seealso cref="Add_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Add{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<byte> Add(Vector256<byte> left, Vector256<byte> right);

        /// <summary>
        /// Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
        /// Mnemonic: <c>rt[i] := left[i] + right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to add with <paramref name="right" /> (将会与<paramref name="right" />进行相加的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The sum of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的和).</returns>
        /// <seealso cref="Add_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Add{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<short> Add(Vector256<short> left, Vector256<short> right);

        /// <summary>
        /// Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
        /// Mnemonic: <c>rt[i] := left[i] + right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to add with <paramref name="right" /> (将会与<paramref name="right" />进行相加的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The sum of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的和).</returns>
        /// <seealso cref="Add_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Add{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<ushort> Add(Vector256<ushort> left, Vector256<ushort> right);

        /// <summary>
        /// Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
        /// Mnemonic: <c>rt[i] := left[i] + right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to add with <paramref name="right" /> (将会与<paramref name="right" />进行相加的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The sum of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的和).</returns>
        /// <seealso cref="Add_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Add{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<int> Add(Vector256<int> left, Vector256<int> right);

        /// <summary>
        /// Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
        /// Mnemonic: <c>rt[i] := left[i] + right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to add with <paramref name="right" /> (将会与<paramref name="right" />进行相加的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The sum of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的和).</returns>
        /// <seealso cref="Add_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Add{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<uint> Add(Vector256<uint> left, Vector256<uint> right);

        /// <summary>
        /// Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
        /// Mnemonic: <c>rt[i] := left[i] + right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to add with <paramref name="right" /> (将会与<paramref name="right" />进行相加的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The sum of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的和).</returns>
        /// <seealso cref="Add_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Add{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<long> Add(Vector256<long> left, Vector256<long> right);

        /// <summary>
        /// Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
        /// Mnemonic: <c>rt[i] := left[i] + right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to add with <paramref name="right" /> (将会与<paramref name="right" />进行相加的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The sum of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的和).</returns>
        /// <seealso cref="Add_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Add{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<ulong> Add(Vector256<ulong> left, Vector256<ulong> right);


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
        /// Types with hardware acceleration when running <c>ConvertToDouble</c> (运行 <c>ConvertToDouble</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="ConvertToDouble"/>
        TypeCodeFlags ConvertToDouble_AcceleratedTypes { get; }

        /// <summary>
        /// Convert to a vector whose elements are of type Double (转换为元素类型是Double的向量)..
        /// Mnemonic: <c>rt[i] := (Double)(value[i])</c>.
        /// </summary>
        /// <param name="value">The source vector (源向量).</param>
        /// <returns>The converted vector (转换后的向量).</returns>
        /// <seealso cref="ConvertToDouble_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ConvertToDouble(Vector256{long})" />
        Vector256<double> ConvertToDouble(Vector256<long> value);

        /// <summary>
        /// Convert to a vector whose elements are of type Double (转换为元素类型是Double的向量)..
        /// Mnemonic: <c>rt[i] := (Double)(value[i])</c>.
        /// </summary>
        /// <param name="value">The source vector (源向量).</param>
        /// <returns>The converted vector (转换后的向量).</returns>
        /// <seealso cref="ConvertToDouble_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ConvertToDouble(Vector256{ulong})" />
        Vector256<double> ConvertToDouble(Vector256<ulong> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>ConvertToInt32</c> (运行 <c>ConvertToInt32</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="ConvertToInt32"/>
        TypeCodeFlags ConvertToInt32_AcceleratedTypes { get; }

        /// <summary>
        /// Convert to a vector whose elements are of type Int32 (转换为元素类型是Int32的向量)..
        /// Mnemonic: <c>rt[i] := (Int32)(value[i])</c>.
        /// </summary>
        /// <param name="value">The source vector (源向量).</param>
        /// <returns>The converted vector (转换后的向量).</returns>
        /// <seealso cref="ConvertToInt32_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ConvertToInt32(Vector256{float})" />
        Vector256<int> ConvertToInt32(Vector256<float> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>ConvertToInt64</c> (运行 <c>ConvertToInt64</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="ConvertToInt64"/>
        TypeCodeFlags ConvertToInt64_AcceleratedTypes { get; }

        /// <summary>
        /// Convert to a vector whose elements are of type Int64 (转换为元素类型是Int64的向量)..
        /// Mnemonic: <c>rt[i] := (Int64)(value[i])</c>.
        /// </summary>
        /// <param name="value">The source vector (源向量).</param>
        /// <returns>The converted vector (转换后的向量).</returns>
        /// <seealso cref="ConvertToInt64_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ConvertToInt64(Vector256{long})" />
        Vector256<long> ConvertToInt64(Vector256<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>ConvertToSingle</c> (运行 <c>ConvertToSingle</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="ConvertToSingle"/>
        TypeCodeFlags ConvertToSingle_AcceleratedTypes { get; }

        /// <summary>
        /// Convert to a vector whose elements are of type Single (转换为元素类型是Single的向量)..
        /// Mnemonic: <c>rt[i] := (Single)(value[i])</c>.
        /// </summary>
        /// <param name="value">The source vector (源向量).</param>
        /// <returns>The converted vector (转换后的向量).</returns>
        /// <seealso cref="ConvertToSingle_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ConvertToSingle(Vector256{int})" />
        Vector256<float> ConvertToSingle(Vector256<int> value);

        /// <summary>
        /// Convert to a vector whose elements are of type Single (转换为元素类型是Single的向量)..
        /// Mnemonic: <c>rt[i] := (Single)(value[i])</c>.
        /// </summary>
        /// <param name="value">The source vector (源向量).</param>
        /// <returns>The converted vector (转换后的向量).</returns>
        /// <seealso cref="ConvertToSingle_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ConvertToSingle(Vector256{uint})" />
        Vector256<float> ConvertToSingle(Vector256<uint> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>ConvertToUInt32</c> (运行 <c>ConvertToUInt32</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="ConvertToUInt32"/>
        TypeCodeFlags ConvertToUInt32_AcceleratedTypes { get; }

        /// <summary>
        /// Convert to a vector whose elements are of type UInt32 (转换为元素类型是UInt32的向量)..
        /// Mnemonic: <c>rt[i] := (UInt32)(value[i])</c>.
        /// </summary>
        /// <param name="value">The source vector (源向量).</param>
        /// <returns>The converted vector (转换后的向量).</returns>
        /// <seealso cref="ConvertToUInt32_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ConvertToUInt32(Vector256{float})" />
        Vector256<uint> ConvertToUInt32(Vector256<float> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>ConvertToUInt64</c> (运行 <c>ConvertToUInt64</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="ConvertToUInt64"/>
        TypeCodeFlags ConvertToUInt64_AcceleratedTypes { get; }

        /// <summary>
        /// Convert to a vector whose elements are of type UInt64 (转换为元素类型是UInt64的向量)..
        /// Mnemonic: <c>rt[i] := (UInt64)(value[i])</c>.
        /// </summary>
        /// <param name="value">The source vector (源向量).</param>
        /// <returns>The converted vector (转换后的向量).</returns>
        /// <seealso cref="ConvertToUInt64_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ConvertToUInt64(Vector256{double})" />
        Vector256<ulong> ConvertToUInt64(Vector256<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>Divide</c> (运行 <c>Divide</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Divide"/>
        TypeCodeFlags Divide_AcceleratedTypes { get; }

        /// <summary>
        /// Divides two vectors to compute their quotient (将两个向量相除来计算它们的商).
        /// Mnemonic: <c>rt[i] := left[i] / right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to divided with <paramref name="right" /> (将会与<paramref name="right" />进行相除的向量).</param>
        /// <param name="right">The vector that will divide left <paramref name="left" /> (将会与<paramref name="left" />进行相除的向量).</param>
        /// <returns>The quotient of <paramref name="left" /> divided <paramref name="right" /> (<paramref name="left" /> 除以 <paramref name="right" />的商).</returns>
        /// <seealso cref="Divide_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Divide{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<float> Divide(Vector256<float> left, Vector256<float> right);

        /// <summary>
        /// Divides two vectors to compute their quotient (将两个向量相除来计算它们的商).
        /// Mnemonic: <c>rt[i] := left[i] / right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to divided with <paramref name="right" /> (将会与<paramref name="right" />进行相除的向量).</param>
        /// <param name="right">The vector that will divide left <paramref name="left" /> (将会与<paramref name="left" />进行相除的向量).</param>
        /// <returns>The quotient of <paramref name="left" /> divided <paramref name="right" /> (<paramref name="left" /> 除以 <paramref name="right" />的商).</returns>
        /// <seealso cref="Divide_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Divide{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<double> Divide(Vector256<double> left, Vector256<double> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>ExtractMostSignificantBits</c> (运行 <c>ExtractMostSignificantBits</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="ExtractMostSignificantBits"/>
        TypeCodeFlags ExtractMostSignificantBits_AcceleratedTypes { get; }

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ExtractMostSignificantBits{T}(Vector256{T})" />
        uint ExtractMostSignificantBits(Vector256<float> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ExtractMostSignificantBits{T}(Vector256{T})" />
        uint ExtractMostSignificantBits(Vector256<double> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ExtractMostSignificantBits{T}(Vector256{T})" />
        uint ExtractMostSignificantBits(Vector256<sbyte> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ExtractMostSignificantBits{T}(Vector256{T})" />
        uint ExtractMostSignificantBits(Vector256<byte> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ExtractMostSignificantBits{T}(Vector256{T})" />
        uint ExtractMostSignificantBits(Vector256<short> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ExtractMostSignificantBits{T}(Vector256{T})" />
        uint ExtractMostSignificantBits(Vector256<ushort> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ExtractMostSignificantBits{T}(Vector256{T})" />
        uint ExtractMostSignificantBits(Vector256<int> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ExtractMostSignificantBits{T}(Vector256{T})" />
        uint ExtractMostSignificantBits(Vector256<uint> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ExtractMostSignificantBits{T}(Vector256{T})" />
        uint ExtractMostSignificantBits(Vector256<long> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector256.ExtractMostSignificantBits{T}(Vector256{T})" />
        uint ExtractMostSignificantBits(Vector256<ulong> vector);


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
        /// Types with hardware acceleration when running <c>GreaterThan</c> (运行 <c>GreaterThan</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="GreaterThan"/>
        TypeCodeFlags GreaterThan_AcceleratedTypes { get; }

        /// <summary>
        /// Compares two vectors to determine which is greater on a per-element basis. (比较两个向量，在每个元素的基础上确定哪个更大).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &gt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大).</returns>
        /// <seealso cref="GreaterThan_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThan{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<float> GreaterThan(Vector256<float> left, Vector256<float> right);

        /// <summary>
        /// Compares two vectors to determine which is greater on a per-element basis. (比较两个向量，在每个元素的基础上确定哪个更大).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &gt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大).</returns>
        /// <seealso cref="GreaterThan_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThan{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<double> GreaterThan(Vector256<double> left, Vector256<double> right);

        /// <summary>
        /// Compares two vectors to determine which is greater on a per-element basis. (比较两个向量，在每个元素的基础上确定哪个更大).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &gt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大).</returns>
        /// <seealso cref="GreaterThan_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThan{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<sbyte> GreaterThan(Vector256<sbyte> left, Vector256<sbyte> right);

        /// <summary>
        /// Compares two vectors to determine which is greater on a per-element basis. (比较两个向量，在每个元素的基础上确定哪个更大).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &gt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大).</returns>
        /// <seealso cref="GreaterThan_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThan{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<byte> GreaterThan(Vector256<byte> left, Vector256<byte> right);

        /// <summary>
        /// Compares two vectors to determine which is greater on a per-element basis. (比较两个向量，在每个元素的基础上确定哪个更大).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &gt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大).</returns>
        /// <seealso cref="GreaterThan_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThan{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<short> GreaterThan(Vector256<short> left, Vector256<short> right);

        /// <summary>
        /// Compares two vectors to determine which is greater on a per-element basis. (比较两个向量，在每个元素的基础上确定哪个更大).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &gt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大).</returns>
        /// <seealso cref="GreaterThan_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThan{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<ushort> GreaterThan(Vector256<ushort> left, Vector256<ushort> right);

        /// <summary>
        /// Compares two vectors to determine which is greater on a per-element basis. (比较两个向量，在每个元素的基础上确定哪个更大).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &gt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大).</returns>
        /// <seealso cref="GreaterThan_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThan{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<int> GreaterThan(Vector256<int> left, Vector256<int> right);

        /// <summary>
        /// Compares two vectors to determine which is greater on a per-element basis. (比较两个向量，在每个元素的基础上确定哪个更大).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &gt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大).</returns>
        /// <seealso cref="GreaterThan_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThan{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<uint> GreaterThan(Vector256<uint> left, Vector256<uint> right);

        /// <summary>
        /// Compares two vectors to determine which is greater on a per-element basis. (比较两个向量，在每个元素的基础上确定哪个更大).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &gt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大).</returns>
        /// <seealso cref="GreaterThan_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThan{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<long> GreaterThan(Vector256<long> left, Vector256<long> right);

        /// <summary>
        /// Compares two vectors to determine which is greater on a per-element basis. (比较两个向量，在每个元素的基础上确定哪个更大).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &gt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大).</returns>
        /// <seealso cref="GreaterThan_AcceleratedTypes"/>
        /// <seealso cref="Vector256.GreaterThan{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<ulong> GreaterThan(Vector256<ulong> left, Vector256<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>LessThan</c> (运行 <c>LessThan</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="LessThan"/>
        TypeCodeFlags LessThan_AcceleratedTypes { get; }

        /// <summary>
        /// Compares two vectors to determine which is less on a per-element basis. (比较两个向量，在每个元素的基础上确定哪个更小).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &lt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were less (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更小).</returns>
        /// <seealso cref="LessThan_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThan{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<float> LessThan(Vector256<float> left, Vector256<float> right);

        /// <summary>
        /// Compares two vectors to determine which is less on a per-element basis. (比较两个向量，在每个元素的基础上确定哪个更小).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &lt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were less (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更小).</returns>
        /// <seealso cref="LessThan_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThan{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<double> LessThan(Vector256<double> left, Vector256<double> right);

        /// <summary>
        /// Compares two vectors to determine which is less on a per-element basis. (比较两个向量，在每个元素的基础上确定哪个更小).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &lt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were less (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更小).</returns>
        /// <seealso cref="LessThan_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThan{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<sbyte> LessThan(Vector256<sbyte> left, Vector256<sbyte> right);

        /// <summary>
        /// Compares two vectors to determine which is less on a per-element basis. (比较两个向量，在每个元素的基础上确定哪个更小).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &lt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were less (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更小).</returns>
        /// <seealso cref="LessThan_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThan{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<byte> LessThan(Vector256<byte> left, Vector256<byte> right);

        /// <summary>
        /// Compares two vectors to determine which is less on a per-element basis. (比较两个向量，在每个元素的基础上确定哪个更小).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &lt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were less (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更小).</returns>
        /// <seealso cref="LessThan_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThan{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<short> LessThan(Vector256<short> left, Vector256<short> right);

        /// <summary>
        /// Compares two vectors to determine which is less on a per-element basis. (比较两个向量，在每个元素的基础上确定哪个更小).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &lt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were less (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更小).</returns>
        /// <seealso cref="LessThan_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThan{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<ushort> LessThan(Vector256<ushort> left, Vector256<ushort> right);

        /// <summary>
        /// Compares two vectors to determine which is less on a per-element basis. (比较两个向量，在每个元素的基础上确定哪个更小).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &lt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were less (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更小).</returns>
        /// <seealso cref="LessThan_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThan{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<int> LessThan(Vector256<int> left, Vector256<int> right);

        /// <summary>
        /// Compares two vectors to determine which is less on a per-element basis. (比较两个向量，在每个元素的基础上确定哪个更小).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &lt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were less (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更小).</returns>
        /// <seealso cref="LessThan_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThan{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<uint> LessThan(Vector256<uint> left, Vector256<uint> right);

        /// <summary>
        /// Compares two vectors to determine which is less on a per-element basis. (比较两个向量，在每个元素的基础上确定哪个更小).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &lt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were less (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更小).</returns>
        /// <seealso cref="LessThan_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThan{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<long> LessThan(Vector256<long> left, Vector256<long> right);

        /// <summary>
        /// Compares two vectors to determine which is less on a per-element basis. (比较两个向量，在每个元素的基础上确定哪个更小).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &lt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were less (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更小).</returns>
        /// <seealso cref="LessThan_AcceleratedTypes"/>
        /// <seealso cref="Vector256.LessThan{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<ulong> LessThan(Vector256<ulong> left, Vector256<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>Max</c> (运行 <c>Max</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Max"/>
        TypeCodeFlags Max_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the maximum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最大值).
        /// Mnemonic: <c>rt[i] := max(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the maximum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最大值).</returns>
        /// <seealso cref="Max_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Max{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<float> Max(Vector256<float> left, Vector256<float> right);

        /// <summary>
        /// Computes the maximum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最大值).
        /// Mnemonic: <c>rt[i] := max(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the maximum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最大值).</returns>
        /// <seealso cref="Max_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Max{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<double> Max(Vector256<double> left, Vector256<double> right);

        /// <summary>
        /// Computes the maximum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最大值).
        /// Mnemonic: <c>rt[i] := max(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the maximum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最大值).</returns>
        /// <seealso cref="Max_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Max{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<sbyte> Max(Vector256<sbyte> left, Vector256<sbyte> right);

        /// <summary>
        /// Computes the maximum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最大值).
        /// Mnemonic: <c>rt[i] := max(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the maximum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最大值).</returns>
        /// <seealso cref="Max_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Max{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<byte> Max(Vector256<byte> left, Vector256<byte> right);

        /// <summary>
        /// Computes the maximum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最大值).
        /// Mnemonic: <c>rt[i] := max(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the maximum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最大值).</returns>
        /// <seealso cref="Max_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Max{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<short> Max(Vector256<short> left, Vector256<short> right);

        /// <summary>
        /// Computes the maximum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最大值).
        /// Mnemonic: <c>rt[i] := max(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the maximum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最大值).</returns>
        /// <seealso cref="Max_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Max{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<ushort> Max(Vector256<ushort> left, Vector256<ushort> right);

        /// <summary>
        /// Computes the maximum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最大值).
        /// Mnemonic: <c>rt[i] := max(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the maximum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最大值).</returns>
        /// <seealso cref="Max_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Max{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<int> Max(Vector256<int> left, Vector256<int> right);

        /// <summary>
        /// Computes the maximum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最大值).
        /// Mnemonic: <c>rt[i] := max(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the maximum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最大值).</returns>
        /// <seealso cref="Max_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Max{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<uint> Max(Vector256<uint> left, Vector256<uint> right);

        /// <summary>
        /// Computes the maximum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最大值).
        /// Mnemonic: <c>rt[i] := max(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the maximum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最大值).</returns>
        /// <seealso cref="Max_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Max{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<long> Max(Vector256<long> left, Vector256<long> right);

        /// <summary>
        /// Computes the maximum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最大值).
        /// Mnemonic: <c>rt[i] := max(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the maximum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最大值).</returns>
        /// <seealso cref="Max_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Max{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<ulong> Max(Vector256<ulong> left, Vector256<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>Min</c> (运行 <c>Min</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Min"/>
        TypeCodeFlags Min_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the minimum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最小值).
        /// Mnemonic: <c>rt[i] := min(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the minimum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最小值).</returns>
        /// <seealso cref="Min_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Min{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<float> Min(Vector256<float> left, Vector256<float> right);

        /// <summary>
        /// Computes the minimum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最小值).
        /// Mnemonic: <c>rt[i] := min(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the minimum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最小值).</returns>
        /// <seealso cref="Min_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Min{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<double> Min(Vector256<double> left, Vector256<double> right);

        /// <summary>
        /// Computes the minimum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最小值).
        /// Mnemonic: <c>rt[i] := min(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the minimum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最小值).</returns>
        /// <seealso cref="Min_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Min{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<sbyte> Min(Vector256<sbyte> left, Vector256<sbyte> right);

        /// <summary>
        /// Computes the minimum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最小值).
        /// Mnemonic: <c>rt[i] := min(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the minimum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最小值).</returns>
        /// <seealso cref="Min_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Min{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<byte> Min(Vector256<byte> left, Vector256<byte> right);

        /// <summary>
        /// Computes the minimum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最小值).
        /// Mnemonic: <c>rt[i] := min(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the minimum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最小值).</returns>
        /// <seealso cref="Min_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Min{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<short> Min(Vector256<short> left, Vector256<short> right);

        /// <summary>
        /// Computes the minimum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最小值).
        /// Mnemonic: <c>rt[i] := min(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the minimum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最小值).</returns>
        /// <seealso cref="Min_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Min{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<ushort> Min(Vector256<ushort> left, Vector256<ushort> right);

        /// <summary>
        /// Computes the minimum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最小值).
        /// Mnemonic: <c>rt[i] := min(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the minimum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最小值).</returns>
        /// <seealso cref="Min_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Min{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<int> Min(Vector256<int> left, Vector256<int> right);

        /// <summary>
        /// Computes the minimum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最小值).
        /// Mnemonic: <c>rt[i] := min(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the minimum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最小值).</returns>
        /// <seealso cref="Min_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Min{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<uint> Min(Vector256<uint> left, Vector256<uint> right);

        /// <summary>
        /// Computes the minimum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最小值).
        /// Mnemonic: <c>rt[i] := min(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the minimum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最小值).</returns>
        /// <seealso cref="Min_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Min{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<long> Min(Vector256<long> left, Vector256<long> right);

        /// <summary>
        /// Computes the minimum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最小值).
        /// Mnemonic: <c>rt[i] := min(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the minimum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最小值).</returns>
        /// <seealso cref="Min_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Min{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<ulong> Min(Vector256<ulong> left, Vector256<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>Multiply</c> (运行 <c>Multiply</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Multiply"/>
        /// <seealso cref="Multiply_FullAcceleratedTypes"/>
        TypeCodeFlags Multiply_AcceleratedTypes { get; }

        /// <summary>
        /// Types with full hardware acceleration when running <c>Multiply</c> (运行 <c>Multiply</c> 时具有完全硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>`AcceleratedTypes` only indicates the presence of hardware acceleration, possibly indirectly through some algorithm. And `FullAcceleratedTypes` means that dedicated instructions are used to achieve full hardware acceleration. (`AcceleratedTypes`仅表示存在硬件加速,有可能是通过一些算法间接实现的. 而 `FullAcceleratedTypes`意味着使用了专用指令，实现了完全的硬件加速)</para>
        /// </remarks>
        /// <seealso cref="Multiply"/>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        TypeCodeFlags Multiply_FullAcceleratedTypes { get; }

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Multiply{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<float> Multiply(Vector256<float> left, Vector256<float> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Multiply{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<double> Multiply(Vector256<double> left, Vector256<double> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Multiply{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<sbyte> Multiply(Vector256<sbyte> left, Vector256<sbyte> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Multiply{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<byte> Multiply(Vector256<byte> left, Vector256<byte> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Multiply{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<short> Multiply(Vector256<short> left, Vector256<short> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Multiply{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<ushort> Multiply(Vector256<ushort> left, Vector256<ushort> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Multiply{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<int> Multiply(Vector256<int> left, Vector256<int> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Multiply{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<uint> Multiply(Vector256<uint> left, Vector256<uint> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Multiply{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<long> Multiply(Vector256<long> left, Vector256<long> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Multiply{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<ulong> Multiply(Vector256<ulong> left, Vector256<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>Narrow</c> (运行 <c>Narrow</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Narrow"/>
        TypeCodeFlags Narrow_AcceleratedTypes { get; }

        /// <summary>
        /// Narrows two <seealso cref="Vector256{T}"/> instances into one <seealso cref="Vector256{T}"/>"  (将两个 <seealso cref="Vector256{T}"/> 实例缩窄为一个 <seealso cref="Vector256{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow(element_ref(i, lower, upper))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector256{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="Narrow_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Narrow(Vector256{double}, Vector256{double})" />
        Vector256<float> Narrow(Vector256<double> lower, Vector256<double> upper);

        /// <summary>
        /// Narrows two <seealso cref="Vector256{T}"/> instances into one <seealso cref="Vector256{T}"/>"  (将两个 <seealso cref="Vector256{T}"/> 实例缩窄为一个 <seealso cref="Vector256{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow(element_ref(i, lower, upper))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector256{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="Narrow_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Narrow(Vector256{short}, Vector256{short})" />
        Vector256<sbyte> Narrow(Vector256<short> lower, Vector256<short> upper);

        /// <summary>
        /// Narrows two <seealso cref="Vector256{T}"/> instances into one <seealso cref="Vector256{T}"/>"  (将两个 <seealso cref="Vector256{T}"/> 实例缩窄为一个 <seealso cref="Vector256{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow(element_ref(i, lower, upper))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector256{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="Narrow_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Narrow(Vector256{ushort}, Vector256{ushort})" />
        Vector256<byte> Narrow(Vector256<ushort> lower, Vector256<ushort> upper);

        /// <summary>
        /// Narrows two <seealso cref="Vector256{T}"/> instances into one <seealso cref="Vector256{T}"/>"  (将两个 <seealso cref="Vector256{T}"/> 实例缩窄为一个 <seealso cref="Vector256{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow(element_ref(i, lower, upper))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector256{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="Narrow_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Narrow(Vector256{int}, Vector256{int})" />
        Vector256<short> Narrow(Vector256<int> lower, Vector256<int> upper);

        /// <summary>
        /// Narrows two <seealso cref="Vector256{T}"/> instances into one <seealso cref="Vector256{T}"/>"  (将两个 <seealso cref="Vector256{T}"/> 实例缩窄为一个 <seealso cref="Vector256{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow(element_ref(i, lower, upper))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector256{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="Narrow_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Narrow(Vector256{uint}, Vector256{uint})" />
        Vector256<ushort> Narrow(Vector256<uint> lower, Vector256<uint> upper);

        /// <summary>
        /// Narrows two <seealso cref="Vector256{T}"/> instances into one <seealso cref="Vector256{T}"/>"  (将两个 <seealso cref="Vector256{T}"/> 实例缩窄为一个 <seealso cref="Vector256{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow(element_ref(i, lower, upper))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector256{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="Narrow_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Narrow(Vector256{long}, Vector256{long})" />
        Vector256<int> Narrow(Vector256<long> lower, Vector256<long> upper);

        /// <summary>
        /// Narrows two <seealso cref="Vector256{T}"/> instances into one <seealso cref="Vector256{T}"/>"  (将两个 <seealso cref="Vector256{T}"/> 实例缩窄为一个 <seealso cref="Vector256{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow(element_ref(i, lower, upper))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector256{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="Narrow_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Narrow(Vector256{ulong}, Vector256{ulong})" />
        Vector256<uint> Narrow(Vector256<ulong> lower, Vector256<ulong> upper);


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
        /// Types with hardware acceleration when running <c>Shuffle</c> (运行 <c>Shuffle</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>- <see cref="YShuffleKernel"/>: If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). It has the best performance, and is used when you are sure that the index value is not out of range (它的性能最好, 用于确信索引值不会超出范围时).</para>
        /// <para>- <see cref="Shuffle"/>: If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).</para>
        /// <para>- <see cref="YShuffleInsert"/>: If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).</para>
        /// </remarks>
        /// <seealso cref="Shuffle"/>
        TypeCodeFlags Shuffle_AcceleratedTypes { get; }

        /// <summary>
        /// Shuffle and clear (换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Shuffle(Vector256{float}, Vector256{int})"/>
        Vector256<float> Shuffle(Vector256<float> vector, Vector256<int> indices);

        /// <summary>
        /// Shuffle and clear (换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Shuffle(Vector256{double}, Vector256{long})"/>
        Vector256<double> Shuffle(Vector256<double> vector, Vector256<long> indices);

        /// <summary>
        /// Shuffle and clear (换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Shuffle(Vector256{sbyte}, Vector256{sbyte})"/>
        Vector256<sbyte> Shuffle(Vector256<sbyte> vector, Vector256<sbyte> indices);

        /// <summary>
        /// Shuffle and clear (换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Shuffle(Vector256{byte}, Vector256{byte})"/>
        Vector256<byte> Shuffle(Vector256<byte> vector, Vector256<byte> indices);

        /// <summary>
        /// Shuffle and clear (换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Shuffle(Vector256{short}, Vector256{short})"/>
        Vector256<short> Shuffle(Vector256<short> vector, Vector256<short> indices);

        /// <summary>
        /// Shuffle and clear (换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Shuffle(Vector256{ushort}, Vector256{ushort})"/>
        Vector256<ushort> Shuffle(Vector256<ushort> vector, Vector256<ushort> indices);

        /// <summary>
        /// Shuffle and clear (换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Shuffle(Vector256{int}, Vector256{int})"/>
        Vector256<int> Shuffle(Vector256<int> vector, Vector256<int> indices);

        /// <summary>
        /// Shuffle and clear (换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Shuffle(Vector256{uint}, Vector256{uint})"/>
        Vector256<uint> Shuffle(Vector256<uint> vector, Vector256<uint> indices);

        /// <summary>
        /// Shuffle and clear (换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Shuffle(Vector256{long}, Vector256{long})"/>
        Vector256<long> Shuffle(Vector256<long> vector, Vector256<long> indices);

        /// <summary>
        /// Shuffle and clear (换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Shuffle(Vector256{ulong}, Vector256{ulong})"/>
        Vector256<ulong> Shuffle(Vector256<ulong> vector, Vector256<ulong> indices);


        /// <summary>
        /// Types with hardware acceleration when running <c>Subtract</c> (运行 <c>Subtract</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Subtract"/>
        TypeCodeFlags Subtract_AcceleratedTypes { get; }

        /// <summary>
        /// Subtracts two vectors to compute their difference (将两个向量相减来计算它们的差).
        /// Mnemonic: <c>rt[i] := left[i] - right[i]</c>.
        /// </summary>
        /// <param name="left">The vector from which <paramref name="right" /> will be subtracted (将被减去<paramref name="right" />的向量).</param>
        /// <param name="right">The vector to subtract from <paramref name="left" /> (要从<paramref name="left" />减去的向量).</param>
        /// <returns>The difference of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" />与<paramref name="right" />的差).</returns>
        /// <seealso cref="Subtract_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Subtract{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<float> Subtract(Vector256<float> left, Vector256<float> right);

        /// <summary>
        /// Subtracts two vectors to compute their difference (将两个向量相减来计算它们的差).
        /// Mnemonic: <c>rt[i] := left[i] - right[i]</c>.
        /// </summary>
        /// <param name="left">The vector from which <paramref name="right" /> will be subtracted (将被减去<paramref name="right" />的向量).</param>
        /// <param name="right">The vector to subtract from <paramref name="left" /> (要从<paramref name="left" />减去的向量).</param>
        /// <returns>The difference of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" />与<paramref name="right" />的差).</returns>
        /// <seealso cref="Subtract_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Subtract{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<double> Subtract(Vector256<double> left, Vector256<double> right);

        /// <summary>
        /// Subtracts two vectors to compute their difference (将两个向量相减来计算它们的差).
        /// Mnemonic: <c>rt[i] := left[i] - right[i]</c>.
        /// </summary>
        /// <param name="left">The vector from which <paramref name="right" /> will be subtracted (将被减去<paramref name="right" />的向量).</param>
        /// <param name="right">The vector to subtract from <paramref name="left" /> (要从<paramref name="left" />减去的向量).</param>
        /// <returns>The difference of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" />与<paramref name="right" />的差).</returns>
        /// <seealso cref="Subtract_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Subtract{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<sbyte> Subtract(Vector256<sbyte> left, Vector256<sbyte> right);

        /// <summary>
        /// Subtracts two vectors to compute their difference (将两个向量相减来计算它们的差).
        /// Mnemonic: <c>rt[i] := left[i] - right[i]</c>.
        /// </summary>
        /// <param name="left">The vector from which <paramref name="right" /> will be subtracted (将被减去<paramref name="right" />的向量).</param>
        /// <param name="right">The vector to subtract from <paramref name="left" /> (要从<paramref name="left" />减去的向量).</param>
        /// <returns>The difference of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" />与<paramref name="right" />的差).</returns>
        /// <seealso cref="Subtract_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Subtract{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<byte> Subtract(Vector256<byte> left, Vector256<byte> right);

        /// <summary>
        /// Subtracts two vectors to compute their difference (将两个向量相减来计算它们的差).
        /// Mnemonic: <c>rt[i] := left[i] - right[i]</c>.
        /// </summary>
        /// <param name="left">The vector from which <paramref name="right" /> will be subtracted (将被减去<paramref name="right" />的向量).</param>
        /// <param name="right">The vector to subtract from <paramref name="left" /> (要从<paramref name="left" />减去的向量).</param>
        /// <returns>The difference of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" />与<paramref name="right" />的差).</returns>
        /// <seealso cref="Subtract_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Subtract{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<short> Subtract(Vector256<short> left, Vector256<short> right);

        /// <summary>
        /// Subtracts two vectors to compute their difference (将两个向量相减来计算它们的差).
        /// Mnemonic: <c>rt[i] := left[i] - right[i]</c>.
        /// </summary>
        /// <param name="left">The vector from which <paramref name="right" /> will be subtracted (将被减去<paramref name="right" />的向量).</param>
        /// <param name="right">The vector to subtract from <paramref name="left" /> (要从<paramref name="left" />减去的向量).</param>
        /// <returns>The difference of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" />与<paramref name="right" />的差).</returns>
        /// <seealso cref="Subtract_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Subtract{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<ushort> Subtract(Vector256<ushort> left, Vector256<ushort> right);

        /// <summary>
        /// Subtracts two vectors to compute their difference (将两个向量相减来计算它们的差).
        /// Mnemonic: <c>rt[i] := left[i] - right[i]</c>.
        /// </summary>
        /// <param name="left">The vector from which <paramref name="right" /> will be subtracted (将被减去<paramref name="right" />的向量).</param>
        /// <param name="right">The vector to subtract from <paramref name="left" /> (要从<paramref name="left" />减去的向量).</param>
        /// <returns>The difference of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" />与<paramref name="right" />的差).</returns>
        /// <seealso cref="Subtract_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Subtract{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<int> Subtract(Vector256<int> left, Vector256<int> right);

        /// <summary>
        /// Subtracts two vectors to compute their difference (将两个向量相减来计算它们的差).
        /// Mnemonic: <c>rt[i] := left[i] - right[i]</c>.
        /// </summary>
        /// <param name="left">The vector from which <paramref name="right" /> will be subtracted (将被减去<paramref name="right" />的向量).</param>
        /// <param name="right">The vector to subtract from <paramref name="left" /> (要从<paramref name="left" />减去的向量).</param>
        /// <returns>The difference of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" />与<paramref name="right" />的差).</returns>
        /// <seealso cref="Subtract_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Subtract{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<uint> Subtract(Vector256<uint> left, Vector256<uint> right);

        /// <summary>
        /// Subtracts two vectors to compute their difference (将两个向量相减来计算它们的差).
        /// Mnemonic: <c>rt[i] := left[i] - right[i]</c>.
        /// </summary>
        /// <param name="left">The vector from which <paramref name="right" /> will be subtracted (将被减去<paramref name="right" />的向量).</param>
        /// <param name="right">The vector to subtract from <paramref name="left" /> (要从<paramref name="left" />减去的向量).</param>
        /// <returns>The difference of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" />与<paramref name="right" />的差).</returns>
        /// <seealso cref="Subtract_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Subtract{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<long> Subtract(Vector256<long> left, Vector256<long> right);

        /// <summary>
        /// Subtracts two vectors to compute their difference (将两个向量相减来计算它们的差).
        /// Mnemonic: <c>rt[i] := left[i] - right[i]</c>.
        /// </summary>
        /// <param name="left">The vector from which <paramref name="right" /> will be subtracted (将被减去<paramref name="right" />的向量).</param>
        /// <param name="right">The vector to subtract from <paramref name="left" /> (要从<paramref name="left" />减去的向量).</param>
        /// <returns>The difference of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" />与<paramref name="right" />的差).</returns>
        /// <seealso cref="Subtract_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Subtract{T}(Vector256{T}, Vector256{T})"/> // Since: .NET 7
        Vector256<ulong> Subtract(Vector256<ulong> left, Vector256<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>Sum</c> (运行 <c>Sum</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Sum"/>
        TypeCodeFlags Sum_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the sum of all elements in a vector (计算向量中所有元素的总和).
        /// Mnemonic: <c>rt := value[0] + value[1] + value[2] + ... + value[Count-1]</c>.
        /// </summary>
        /// <param name="value">The vector whose elements will be summed (将对其元素求和的向量).</param>
        /// <returns>The sum of all elements in <paramref name="value" /> (<paramref name="value" /> 中所有元素的总和).</returns>
        /// <seealso cref="Sum_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Sum{T}(Vector256{T})" />
        float Sum(Vector256<float> value);

        /// <summary>
        /// Computes the sum of all elements in a vector (计算向量中所有元素的总和).
        /// Mnemonic: <c>rt := value[0] + value[1] + value[2] + ... + value[Count-1]</c>.
        /// </summary>
        /// <param name="value">The vector whose elements will be summed (将对其元素求和的向量).</param>
        /// <returns>The sum of all elements in <paramref name="value" /> (<paramref name="value" /> 中所有元素的总和).</returns>
        /// <seealso cref="Sum_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Sum{T}(Vector256{T})" />
        double Sum(Vector256<double> value);

        /// <summary>
        /// Computes the sum of all elements in a vector (计算向量中所有元素的总和).
        /// Mnemonic: <c>rt := value[0] + value[1] + value[2] + ... + value[Count-1]</c>.
        /// </summary>
        /// <param name="value">The vector whose elements will be summed (将对其元素求和的向量).</param>
        /// <returns>The sum of all elements in <paramref name="value" /> (<paramref name="value" /> 中所有元素的总和).</returns>
        /// <seealso cref="Sum_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Sum{T}(Vector256{T})" />
        sbyte Sum(Vector256<sbyte> value);

        /// <summary>
        /// Computes the sum of all elements in a vector (计算向量中所有元素的总和).
        /// Mnemonic: <c>rt := value[0] + value[1] + value[2] + ... + value[Count-1]</c>.
        /// </summary>
        /// <param name="value">The vector whose elements will be summed (将对其元素求和的向量).</param>
        /// <returns>The sum of all elements in <paramref name="value" /> (<paramref name="value" /> 中所有元素的总和).</returns>
        /// <seealso cref="Sum_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Sum{T}(Vector256{T})" />
        byte Sum(Vector256<byte> value);

        /// <summary>
        /// Computes the sum of all elements in a vector (计算向量中所有元素的总和).
        /// Mnemonic: <c>rt := value[0] + value[1] + value[2] + ... + value[Count-1]</c>.
        /// </summary>
        /// <param name="value">The vector whose elements will be summed (将对其元素求和的向量).</param>
        /// <returns>The sum of all elements in <paramref name="value" /> (<paramref name="value" /> 中所有元素的总和).</returns>
        /// <seealso cref="Sum_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Sum{T}(Vector256{T})" />
        short Sum(Vector256<short> value);

        /// <summary>
        /// Computes the sum of all elements in a vector (计算向量中所有元素的总和).
        /// Mnemonic: <c>rt := value[0] + value[1] + value[2] + ... + value[Count-1]</c>.
        /// </summary>
        /// <param name="value">The vector whose elements will be summed (将对其元素求和的向量).</param>
        /// <returns>The sum of all elements in <paramref name="value" /> (<paramref name="value" /> 中所有元素的总和).</returns>
        /// <seealso cref="Sum_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Sum{T}(Vector256{T})" />
        ushort Sum(Vector256<ushort> value);

        /// <summary>
        /// Computes the sum of all elements in a vector (计算向量中所有元素的总和).
        /// Mnemonic: <c>rt := value[0] + value[1] + value[2] + ... + value[Count-1]</c>.
        /// </summary>
        /// <param name="value">The vector whose elements will be summed (将对其元素求和的向量).</param>
        /// <returns>The sum of all elements in <paramref name="value" /> (<paramref name="value" /> 中所有元素的总和).</returns>
        /// <seealso cref="Sum_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Sum{T}(Vector256{T})" />
        int Sum(Vector256<int> value);

        /// <summary>
        /// Computes the sum of all elements in a vector (计算向量中所有元素的总和).
        /// Mnemonic: <c>rt := value[0] + value[1] + value[2] + ... + value[Count-1]</c>.
        /// </summary>
        /// <param name="value">The vector whose elements will be summed (将对其元素求和的向量).</param>
        /// <returns>The sum of all elements in <paramref name="value" /> (<paramref name="value" /> 中所有元素的总和).</returns>
        /// <seealso cref="Sum_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Sum{T}(Vector256{T})" />
        uint Sum(Vector256<uint> value);

        /// <summary>
        /// Computes the sum of all elements in a vector (计算向量中所有元素的总和).
        /// Mnemonic: <c>rt := value[0] + value[1] + value[2] + ... + value[Count-1]</c>.
        /// </summary>
        /// <param name="value">The vector whose elements will be summed (将对其元素求和的向量).</param>
        /// <returns>The sum of all elements in <paramref name="value" /> (<paramref name="value" /> 中所有元素的总和).</returns>
        /// <seealso cref="Sum_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Sum{T}(Vector256{T})" />
        long Sum(Vector256<long> value);

        /// <summary>
        /// Computes the sum of all elements in a vector (计算向量中所有元素的总和).
        /// Mnemonic: <c>rt := value[0] + value[1] + value[2] + ... + value[Count-1]</c>.
        /// </summary>
        /// <param name="value">The vector whose elements will be summed (将对其元素求和的向量).</param>
        /// <returns>The sum of all elements in <paramref name="value" /> (<paramref name="value" /> 中所有元素的总和).</returns>
        /// <seealso cref="Sum_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Sum{T}(Vector256{T})" />
        ulong Sum(Vector256<ulong> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>Widen</c> (运行 <c>Widen</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Widen"/>
        TypeCodeFlags Widen_AcceleratedTypes { get; }

        /// <summary>
        /// Widens a <seealso cref="Vector256{T}"/> into two <seealso cref="Vector256{T}"/> instances (将一个 <seealso cref="Vector256{T}"/> 扩宽为两个 <seealso cref="Vector256{T}"/> 实例).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <param name="lower">When this method returns, contains the widened elements from lower indices in the source vector (当此方法返回时，包含源向量中来自较低下标的扩宽元素).</param>
        /// <param name="upper">When this method returns, contains the widened elements from upper indices in the source vector (当此方法返回时，包含源向量中来自较高下标的扩宽元素).</param>
        /// <seealso cref="Widen_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Widen(Vector256{float})" />
        void Widen(Vector256<float> source, out Vector256<double> lower, out Vector256<double> upper);

        /// <summary>
        /// Widens a <seealso cref="Vector256{T}"/> into two <seealso cref="Vector256{T}"/> instances (将一个 <seealso cref="Vector256{T}"/> 扩宽为两个 <seealso cref="Vector256{T}"/> 实例).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <param name="lower">When this method returns, contains the widened elements from lower indices in the source vector (当此方法返回时，包含源向量中来自较低下标的扩宽元素).</param>
        /// <param name="upper">When this method returns, contains the widened elements from upper indices in the source vector (当此方法返回时，包含源向量中来自较高下标的扩宽元素).</param>
        /// <seealso cref="Widen_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Widen(Vector256{sbyte})" />
        void Widen(Vector256<sbyte> source, out Vector256<short> lower, out Vector256<short> upper);

        /// <summary>
        /// Widens a <seealso cref="Vector256{T}"/> into two <seealso cref="Vector256{T}"/> instances (将一个 <seealso cref="Vector256{T}"/> 扩宽为两个 <seealso cref="Vector256{T}"/> 实例).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <param name="lower">When this method returns, contains the widened elements from lower indices in the source vector (当此方法返回时，包含源向量中来自较低下标的扩宽元素).</param>
        /// <param name="upper">When this method returns, contains the widened elements from upper indices in the source vector (当此方法返回时，包含源向量中来自较高下标的扩宽元素).</param>
        /// <seealso cref="Widen_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Widen(Vector256{byte})" />
        void Widen(Vector256<byte> source, out Vector256<ushort> lower, out Vector256<ushort> upper);

        /// <summary>
        /// Widens a <seealso cref="Vector256{T}"/> into two <seealso cref="Vector256{T}"/> instances (将一个 <seealso cref="Vector256{T}"/> 扩宽为两个 <seealso cref="Vector256{T}"/> 实例).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <param name="lower">When this method returns, contains the widened elements from lower indices in the source vector (当此方法返回时，包含源向量中来自较低下标的扩宽元素).</param>
        /// <param name="upper">When this method returns, contains the widened elements from upper indices in the source vector (当此方法返回时，包含源向量中来自较高下标的扩宽元素).</param>
        /// <seealso cref="Widen_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Widen(Vector256{short})" />
        void Widen(Vector256<short> source, out Vector256<int> lower, out Vector256<int> upper);

        /// <summary>
        /// Widens a <seealso cref="Vector256{T}"/> into two <seealso cref="Vector256{T}"/> instances (将一个 <seealso cref="Vector256{T}"/> 扩宽为两个 <seealso cref="Vector256{T}"/> 实例).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <param name="lower">When this method returns, contains the widened elements from lower indices in the source vector (当此方法返回时，包含源向量中来自较低下标的扩宽元素).</param>
        /// <param name="upper">When this method returns, contains the widened elements from upper indices in the source vector (当此方法返回时，包含源向量中来自较高下标的扩宽元素).</param>
        /// <seealso cref="Widen_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Widen(Vector256{ushort})" />
        void Widen(Vector256<ushort> source, out Vector256<uint> lower, out Vector256<uint> upper);

        /// <summary>
        /// Widens a <seealso cref="Vector256{T}"/> into two <seealso cref="Vector256{T}"/> instances (将一个 <seealso cref="Vector256{T}"/> 扩宽为两个 <seealso cref="Vector256{T}"/> 实例).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <param name="lower">When this method returns, contains the widened elements from lower indices in the source vector (当此方法返回时，包含源向量中来自较低下标的扩宽元素).</param>
        /// <param name="upper">When this method returns, contains the widened elements from upper indices in the source vector (当此方法返回时，包含源向量中来自较高下标的扩宽元素).</param>
        /// <seealso cref="Widen_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Widen(Vector256{int})" />
        void Widen(Vector256<int> source, out Vector256<long> lower, out Vector256<long> upper);

        /// <summary>
        /// Widens a <seealso cref="Vector256{T}"/> into two <seealso cref="Vector256{T}"/> instances (将一个 <seealso cref="Vector256{T}"/> 扩宽为两个 <seealso cref="Vector256{T}"/> 实例).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <param name="lower">When this method returns, contains the widened elements from lower indices in the source vector (当此方法返回时，包含源向量中来自较低下标的扩宽元素).</param>
        /// <param name="upper">When this method returns, contains the widened elements from upper indices in the source vector (当此方法返回时，包含源向量中来自较高下标的扩宽元素).</param>
        /// <seealso cref="Widen_AcceleratedTypes"/>
        /// <seealso cref="Vector256.Widen(Vector256{uint})" />
        void Widen(Vector256<uint> source, out Vector256<ulong> lower, out Vector256<ulong> upper);


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

#endif
    }
}
