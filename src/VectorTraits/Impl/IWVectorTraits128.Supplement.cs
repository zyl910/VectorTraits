using System;
using System.Collections.Generic;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
#if NET5_0_OR_GREATER
using System.Runtime.Intrinsics.Arm;
#endif

namespace Zyl.VectorTraits.Impl {
    partial interface IWVectorTraits128 {
#if NETCOREAPP3_0_OR_GREATER

        /// <summary>
        /// Types with hardware acceleration when running <c>Abs</c> (运行 <c>Abs</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Abs(Vector128{sbyte})"/>
        TypeCodeFlags Abs_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the absolute value of each element in a vector (计算向量中每个元素的绝对值).
        /// Mnemonic: <c>rt[i] := abs(vector[i])</c>.
        /// </summary>
        /// <param name="vector">The vector that will have its absolute value computed (将被计算其绝对值的向量).</param>
        /// <returns>A vector whose elements are the absolute value of the elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中各元素的绝对值).</returns>
        /// <seealso cref="Abs_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Abs{T}(Vector128{T})" />
        Vector128<float> Abs(Vector128<float> vector);

        /// <summary>
        /// Computes the absolute value of each element in a vector (计算向量中每个元素的绝对值).
        /// Mnemonic: <c>rt[i] := abs(vector[i])</c>.
        /// </summary>
        /// <param name="vector">The vector that will have its absolute value computed (将被计算其绝对值的向量).</param>
        /// <returns>A vector whose elements are the absolute value of the elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中各元素的绝对值).</returns>
        /// <seealso cref="Abs_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Abs{T}(Vector128{T})" />
        Vector128<double> Abs(Vector128<double> vector);

        /// <summary>
        /// Computes the absolute value of each element in a vector (计算向量中每个元素的绝对值).
        /// Mnemonic: <c>rt[i] := abs(vector[i])</c>.
        /// </summary>
        /// <param name="vector">The vector that will have its absolute value computed (将被计算其绝对值的向量).</param>
        /// <returns>A vector whose elements are the absolute value of the elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中各元素的绝对值).</returns>
        /// <seealso cref="Abs_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Abs{T}(Vector128{T})" />
        Vector128<sbyte> Abs(Vector128<sbyte> vector);

        /// <summary>
        /// Computes the absolute value of each element in a vector (计算向量中每个元素的绝对值).
        /// Mnemonic: <c>rt[i] := abs(vector[i])</c>.
        /// </summary>
        /// <param name="vector">The vector that will have its absolute value computed (将被计算其绝对值的向量).</param>
        /// <returns>A vector whose elements are the absolute value of the elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中各元素的绝对值).</returns>
        /// <seealso cref="Abs_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Abs{T}(Vector128{T})" />
        Vector128<short> Abs(Vector128<short> vector);

        /// <summary>
        /// Computes the absolute value of each element in a vector (计算向量中每个元素的绝对值).
        /// Mnemonic: <c>rt[i] := abs(vector[i])</c>.
        /// </summary>
        /// <param name="vector">The vector that will have its absolute value computed (将被计算其绝对值的向量).</param>
        /// <returns>A vector whose elements are the absolute value of the elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中各元素的绝对值).</returns>
        /// <seealso cref="Abs_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Abs{T}(Vector128{T})" />
        Vector128<int> Abs(Vector128<int> vector);

        /// <summary>
        /// Computes the absolute value of each element in a vector (计算向量中每个元素的绝对值).
        /// Mnemonic: <c>rt[i] := abs(vector[i])</c>.
        /// </summary>
        /// <param name="vector">The vector that will have its absolute value computed (将被计算其绝对值的向量).</param>
        /// <returns>A vector whose elements are the absolute value of the elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中各元素的绝对值).</returns>
        /// <seealso cref="Abs_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Abs{T}(Vector128{T})" />
        Vector128<long> Abs(Vector128<long> vector);


        /// <summary>
        /// Types with hardware acceleration when running <c>Add</c> (运行 <c>Add</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Add(Vector128{byte}, Vector128{byte})"/>
        TypeCodeFlags Add_AcceleratedTypes { get; }

        /// <summary>
        /// Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
        /// Mnemonic: <c>rt[i] := left[i] + right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to add with <paramref name="right" /> (将会与<paramref name="right" />进行相加的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The sum of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的和).</returns>
        /// <seealso cref="Add_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Add{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<float> Add(Vector128<float> left, Vector128<float> right);

        /// <summary>
        /// Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
        /// Mnemonic: <c>rt[i] := left[i] + right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to add with <paramref name="right" /> (将会与<paramref name="right" />进行相加的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The sum of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的和).</returns>
        /// <seealso cref="Add_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Add{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<double> Add(Vector128<double> left, Vector128<double> right);

        /// <summary>
        /// Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
        /// Mnemonic: <c>rt[i] := left[i] + right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to add with <paramref name="right" /> (将会与<paramref name="right" />进行相加的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The sum of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的和).</returns>
        /// <seealso cref="Add_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Add{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<sbyte> Add(Vector128<sbyte> left, Vector128<sbyte> right);

        /// <summary>
        /// Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
        /// Mnemonic: <c>rt[i] := left[i] + right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to add with <paramref name="right" /> (将会与<paramref name="right" />进行相加的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The sum of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的和).</returns>
        /// <seealso cref="Add_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Add{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<byte> Add(Vector128<byte> left, Vector128<byte> right);

        /// <summary>
        /// Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
        /// Mnemonic: <c>rt[i] := left[i] + right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to add with <paramref name="right" /> (将会与<paramref name="right" />进行相加的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The sum of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的和).</returns>
        /// <seealso cref="Add_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Add{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<short> Add(Vector128<short> left, Vector128<short> right);

        /// <summary>
        /// Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
        /// Mnemonic: <c>rt[i] := left[i] + right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to add with <paramref name="right" /> (将会与<paramref name="right" />进行相加的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The sum of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的和).</returns>
        /// <seealso cref="Add_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Add{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<ushort> Add(Vector128<ushort> left, Vector128<ushort> right);

        /// <summary>
        /// Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
        /// Mnemonic: <c>rt[i] := left[i] + right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to add with <paramref name="right" /> (将会与<paramref name="right" />进行相加的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The sum of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的和).</returns>
        /// <seealso cref="Add_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Add{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<int> Add(Vector128<int> left, Vector128<int> right);

        /// <summary>
        /// Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
        /// Mnemonic: <c>rt[i] := left[i] + right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to add with <paramref name="right" /> (将会与<paramref name="right" />进行相加的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The sum of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的和).</returns>
        /// <seealso cref="Add_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Add{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<uint> Add(Vector128<uint> left, Vector128<uint> right);

        /// <summary>
        /// Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
        /// Mnemonic: <c>rt[i] := left[i] + right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to add with <paramref name="right" /> (将会与<paramref name="right" />进行相加的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The sum of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的和).</returns>
        /// <seealso cref="Add_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Add{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<long> Add(Vector128<long> left, Vector128<long> right);

        /// <summary>
        /// Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
        /// Mnemonic: <c>rt[i] := left[i] + right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to add with <paramref name="right" /> (将会与<paramref name="right" />进行相加的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The sum of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的和).</returns>
        /// <seealso cref="Add_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Add{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<ulong> Add(Vector128<ulong> left, Vector128<ulong> right);


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
        /// <seealso cref="Vector128.AndNot{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<T> AndNot<T>(Vector128<T> left, Vector128<T> right) where T : struct;


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
        /// <seealso cref="Vector128.BitwiseAnd{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<T> BitwiseAnd<T>(Vector128<T> left, Vector128<T> right) where T : struct;


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
        /// <seealso cref="Vector128.BitwiseOr{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<T> BitwiseOr<T>(Vector128<T> left, Vector128<T> right) where T : struct;


        /// <summary>
        /// Types with hardware acceleration when running <c>ConditionalSelect</c> (运行 <c>ConditionalSelect</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="ConditionalSelect{T}(Vector128{T}, Vector128{T}, Vector128{T})"/>
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
        /// <seealso cref="Vector128.ConditionalSelect{T}(Vector128{T}, Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<T> ConditionalSelect<T>(Vector128<T> condition, Vector128<T> left, Vector128<T> right) where T : struct;

        /// <summary>
        /// Conditionally selects a value from two vectors on a bitwise basis (按条件从两个向量中按位选择值).
        /// Mnemonic: <c>rt[i] := (left[i] &amp; condition[i]) | (right[i] &amp; ~condition[i])</c>.
        /// </summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The vector that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的向量).</param>
        /// <param name="right">The vector that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的向量).</param>
        /// <returns>A vector whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个向量，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        /// <seealso cref="Vector128.ConditionalSelect{T}(Vector128{T}, Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<float> ConditionalSelect(Vector128<int> condition, Vector128<float> left, Vector128<float> right);

        /// <summary>
        /// Conditionally selects a value from two vectors on a bitwise basis (按条件从两个向量中按位选择值).
        /// Mnemonic: <c>rt[i] := (left[i] &amp; condition[i]) | (right[i] &amp; ~condition[i])</c>.
        /// </summary>
        /// <param name="condition">The mask that is used to select a value from <paramref name="left" /> or <paramref name="right" /> (用于从 <paramref name="left" /> 或 <paramref name="right" />中选择值的掩码).</param>
        /// <param name="left">The vector that is selected when the corresponding bit in <paramref name="condition" /> is one (当 <paramref name="condition" /> 中的对应位为 1 时选择的向量).</param>
        /// <param name="right">The vector that is selected when the corresponding bit in <paramref name="condition" /> is zero (当 <paramref name="condition" /> 中的对应位为 0 时选择的向量).</param>
        /// <returns>A vector whose bits come from <paramref name="left" /> or <paramref name="right" /> based on the value of <paramref name="condition" /> (一个向量，其二进制位是根据 <paramref name="condition" /> 由 <paramref name="left" /> or <paramref name="right" /> 组合而成).</returns>
        /// <seealso cref="Vector128.ConditionalSelect{T}(Vector128{T}, Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<double> ConditionalSelect(Vector128<long> condition, Vector128<double> left, Vector128<double> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>Divide</c> (运行 <c>Divide</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Divide(Vector128{float}, Vector128{float})"/>
        TypeCodeFlags Divide_AcceleratedTypes { get; }

        /// <summary>
        /// Divides two vectors to compute their quotient (将两个向量相除来计算它们的商).
        /// Mnemonic: <c>rt[i] := left[i] / right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to divided with <paramref name="right" /> (将会与<paramref name="right" />进行相除的向量).</param>
        /// <param name="right">The vector that will divide left <paramref name="left" /> (将会与<paramref name="left" />进行相除的向量).</param>
        /// <returns>The quotient of <paramref name="left" /> divided <paramref name="right" /> (<paramref name="left" /> 除以 <paramref name="right" />的商).</returns>
        /// <seealso cref="Divide_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Divide{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<float> Divide(Vector128<float> left, Vector128<float> right);

        /// <summary>
        /// Divides two vectors to compute their quotient (将两个向量相除来计算它们的商).
        /// Mnemonic: <c>rt[i] := left[i] / right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to divided with <paramref name="right" /> (将会与<paramref name="right" />进行相除的向量).</param>
        /// <param name="right">The vector that will divide left <paramref name="left" /> (将会与<paramref name="left" />进行相除的向量).</param>
        /// <returns>The quotient of <paramref name="left" /> divided <paramref name="right" /> (<paramref name="left" /> 除以 <paramref name="right" />的商).</returns>
        /// <seealso cref="Divide_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Divide{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<double> Divide(Vector128<double> left, Vector128<double> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>Dot</c> (运行 <c>Dot</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Dot(Vector128{byte}, Vector128{byte})"/>
        TypeCodeFlags Dot_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the dot product of two vectors (计算两个向量的点积).
        /// Mnemonic: <c>rt := left[0]*right[0] + left[1]*right[1] + left[2]*right[2] + ... + left[Count-1]*right[Count-1]</c>.
        /// </summary>
        /// <param name="left">The vector that will be dotted with <paramref name="right" /> (将会与<paramref name="right" />进行点积的向量).</param>
        /// <param name="right">The vector that will be dotted with <paramref name="left" /> (将会与<paramref name="left" />进行点积的向量).</param>
        /// <returns>The dot product of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的点积).</returns>
        /// <seealso cref="Dot_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Dot{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        float Dot(Vector128<float> left, Vector128<float> right);

        /// <summary>
        /// Computes the dot product of two vectors (计算两个向量的点积).
        /// Mnemonic: <c>rt := left[0]*right[0] + left[1]*right[1] + left[2]*right[2] + ... + left[Count-1]*right[Count-1]</c>.
        /// </summary>
        /// <param name="left">The vector that will be dotted with <paramref name="right" /> (将会与<paramref name="right" />进行点积的向量).</param>
        /// <param name="right">The vector that will be dotted with <paramref name="left" /> (将会与<paramref name="left" />进行点积的向量).</param>
        /// <returns>The dot product of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的点积).</returns>
        /// <seealso cref="Dot_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Dot{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        double Dot(Vector128<double> left, Vector128<double> right);

        /// <summary>
        /// Computes the dot product of two vectors (计算两个向量的点积).
        /// Mnemonic: <c>rt := left[0]*right[0] + left[1]*right[1] + left[2]*right[2] + ... + left[Count-1]*right[Count-1]</c>.
        /// </summary>
        /// <param name="left">The vector that will be dotted with <paramref name="right" /> (将会与<paramref name="right" />进行点积的向量).</param>
        /// <param name="right">The vector that will be dotted with <paramref name="left" /> (将会与<paramref name="left" />进行点积的向量).</param>
        /// <returns>The dot product of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的点积).</returns>
        /// <seealso cref="Dot_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Dot{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        sbyte Dot(Vector128<sbyte> left, Vector128<sbyte> right);

        /// <summary>
        /// Computes the dot product of two vectors (计算两个向量的点积).
        /// Mnemonic: <c>rt := left[0]*right[0] + left[1]*right[1] + left[2]*right[2] + ... + left[Count-1]*right[Count-1]</c>.
        /// </summary>
        /// <param name="left">The vector that will be dotted with <paramref name="right" /> (将会与<paramref name="right" />进行点积的向量).</param>
        /// <param name="right">The vector that will be dotted with <paramref name="left" /> (将会与<paramref name="left" />进行点积的向量).</param>
        /// <returns>The dot product of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的点积).</returns>
        /// <seealso cref="Dot_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Dot{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        byte Dot(Vector128<byte> left, Vector128<byte> right);

        /// <summary>
        /// Computes the dot product of two vectors (计算两个向量的点积).
        /// Mnemonic: <c>rt := left[0]*right[0] + left[1]*right[1] + left[2]*right[2] + ... + left[Count-1]*right[Count-1]</c>.
        /// </summary>
        /// <param name="left">The vector that will be dotted with <paramref name="right" /> (将会与<paramref name="right" />进行点积的向量).</param>
        /// <param name="right">The vector that will be dotted with <paramref name="left" /> (将会与<paramref name="left" />进行点积的向量).</param>
        /// <returns>The dot product of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的点积).</returns>
        /// <seealso cref="Dot_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Dot{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        short Dot(Vector128<short> left, Vector128<short> right);

        /// <summary>
        /// Computes the dot product of two vectors (计算两个向量的点积).
        /// Mnemonic: <c>rt := left[0]*right[0] + left[1]*right[1] + left[2]*right[2] + ... + left[Count-1]*right[Count-1]</c>.
        /// </summary>
        /// <param name="left">The vector that will be dotted with <paramref name="right" /> (将会与<paramref name="right" />进行点积的向量).</param>
        /// <param name="right">The vector that will be dotted with <paramref name="left" /> (将会与<paramref name="left" />进行点积的向量).</param>
        /// <returns>The dot product of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的点积).</returns>
        /// <seealso cref="Dot_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Dot{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        ushort Dot(Vector128<ushort> left, Vector128<ushort> right);

        /// <summary>
        /// Computes the dot product of two vectors (计算两个向量的点积).
        /// Mnemonic: <c>rt := left[0]*right[0] + left[1]*right[1] + left[2]*right[2] + ... + left[Count-1]*right[Count-1]</c>.
        /// </summary>
        /// <param name="left">The vector that will be dotted with <paramref name="right" /> (将会与<paramref name="right" />进行点积的向量).</param>
        /// <param name="right">The vector that will be dotted with <paramref name="left" /> (将会与<paramref name="left" />进行点积的向量).</param>
        /// <returns>The dot product of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的点积).</returns>
        /// <seealso cref="Dot_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Dot{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        int Dot(Vector128<int> left, Vector128<int> right);

        /// <summary>
        /// Computes the dot product of two vectors (计算两个向量的点积).
        /// Mnemonic: <c>rt := left[0]*right[0] + left[1]*right[1] + left[2]*right[2] + ... + left[Count-1]*right[Count-1]</c>.
        /// </summary>
        /// <param name="left">The vector that will be dotted with <paramref name="right" /> (将会与<paramref name="right" />进行点积的向量).</param>
        /// <param name="right">The vector that will be dotted with <paramref name="left" /> (将会与<paramref name="left" />进行点积的向量).</param>
        /// <returns>The dot product of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的点积).</returns>
        /// <seealso cref="Dot_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Dot{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        uint Dot(Vector128<uint> left, Vector128<uint> right);

        /// <summary>
        /// Computes the dot product of two vectors (计算两个向量的点积).
        /// Mnemonic: <c>rt := left[0]*right[0] + left[1]*right[1] + left[2]*right[2] + ... + left[Count-1]*right[Count-1]</c>.
        /// </summary>
        /// <param name="left">The vector that will be dotted with <paramref name="right" /> (将会与<paramref name="right" />进行点积的向量).</param>
        /// <param name="right">The vector that will be dotted with <paramref name="left" /> (将会与<paramref name="left" />进行点积的向量).</param>
        /// <returns>The dot product of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的点积).</returns>
        /// <seealso cref="Dot_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Dot{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        long Dot(Vector128<long> left, Vector128<long> right);

        /// <summary>
        /// Computes the dot product of two vectors (计算两个向量的点积).
        /// Mnemonic: <c>rt := left[0]*right[0] + left[1]*right[1] + left[2]*right[2] + ... + left[Count-1]*right[Count-1]</c>.
        /// </summary>
        /// <param name="left">The vector that will be dotted with <paramref name="right" /> (将会与<paramref name="right" />进行点积的向量).</param>
        /// <param name="right">The vector that will be dotted with <paramref name="left" /> (将会与<paramref name="left" />进行点积的向量).</param>
        /// <returns>The dot product of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的点积).</returns>
        /// <seealso cref="Dot_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Dot{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        ulong Dot(Vector128<ulong> left, Vector128<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>Equals</c> (运行 <c>Equals</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Equals(Vector128{byte}, Vector128{byte})"/>
        TypeCodeFlags Equals_AcceleratedTypes { get; }

        /// <summary>
        /// Compares two vectors to determine if they are equal on a per-element basis (比较两个向量，确定它们每个元素是否相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] == right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否相等).</returns>
        /// <seealso cref="Equals_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Equals{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<float> Equals(Vector128<float> left, Vector128<float> right);

        /// <summary>
        /// Compares two vectors to determine if they are equal on a per-element basis (比较两个向量，确定它们每个元素是否相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] == right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否相等).</returns>
        /// <seealso cref="Equals_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Equals{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<double> Equals(Vector128<double> left, Vector128<double> right);

        /// <summary>
        /// Compares two vectors to determine if they are equal on a per-element basis (比较两个向量，确定它们每个元素是否相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] == right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否相等).</returns>
        /// <seealso cref="Equals_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Equals{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<sbyte> Equals(Vector128<sbyte> left, Vector128<sbyte> right);

        /// <summary>
        /// Compares two vectors to determine if they are equal on a per-element basis (比较两个向量，确定它们每个元素是否相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] == right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否相等).</returns>
        /// <seealso cref="Equals_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Equals{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<byte> Equals(Vector128<byte> left, Vector128<byte> right);

        /// <summary>
        /// Compares two vectors to determine if they are equal on a per-element basis (比较两个向量，确定它们每个元素是否相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] == right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否相等).</returns>
        /// <seealso cref="Equals_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Equals{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<short> Equals(Vector128<short> left, Vector128<short> right);

        /// <summary>
        /// Compares two vectors to determine if they are equal on a per-element basis (比较两个向量，确定它们每个元素是否相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] == right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否相等).</returns>
        /// <seealso cref="Equals_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Equals{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<ushort> Equals(Vector128<ushort> left, Vector128<ushort> right);

        /// <summary>
        /// Compares two vectors to determine if they are equal on a per-element basis (比较两个向量，确定它们每个元素是否相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] == right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否相等).</returns>
        /// <seealso cref="Equals_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Equals{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<int> Equals(Vector128<int> left, Vector128<int> right);

        /// <summary>
        /// Compares two vectors to determine if they are equal on a per-element basis (比较两个向量，确定它们每个元素是否相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] == right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否相等).</returns>
        /// <seealso cref="Equals_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Equals{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<uint> Equals(Vector128<uint> left, Vector128<uint> right);

        /// <summary>
        /// Compares two vectors to determine if they are equal on a per-element basis (比较两个向量，确定它们每个元素是否相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] == right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否相等).</returns>
        /// <seealso cref="Equals_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Equals{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<long> Equals(Vector128<long> left, Vector128<long> right);

        /// <summary>
        /// Compares two vectors to determine if they are equal on a per-element basis (比较两个向量，确定它们每个元素是否相等).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] == right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were equal (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中是否相等).</returns>
        /// <seealso cref="Equals_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Equals{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<ulong> Equals(Vector128<ulong> left, Vector128<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>EqualsAll</c> (运行 <c>EqualsAll</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="EqualsAll(Vector128{byte}, Vector128{byte})"/>
        TypeCodeFlags EqualsAll_AcceleratedTypes { get; }

        /// <summary>
        /// Compares two vectors to determine if all elements are equal (比较两个向量以判定所有元素是否相等).
        /// Mnemonic: <c>rt := (left[0] == right[0]) &amp;&amp; (left[1] == right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] == right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素相等时返回<c>true</c>).</returns>
        /// <seealso cref="EqualsAll_AcceleratedTypes"/>
        /// <seealso cref="Vector128.EqualsAll{T}(Vector128{T}, Vector128{T})"/>
        bool EqualsAll(Vector128<float> left, Vector128<float> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are equal (比较两个向量以判定所有元素是否相等).
        /// Mnemonic: <c>rt := (left[0] == right[0]) &amp;&amp; (left[1] == right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] == right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素相等时返回<c>true</c>).</returns>
        /// <seealso cref="EqualsAll_AcceleratedTypes"/>
        /// <seealso cref="Vector128.EqualsAll{T}(Vector128{T}, Vector128{T})"/>
        bool EqualsAll(Vector128<double> left, Vector128<double> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are equal (比较两个向量以判定所有元素是否相等).
        /// Mnemonic: <c>rt := (left[0] == right[0]) &amp;&amp; (left[1] == right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] == right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素相等时返回<c>true</c>).</returns>
        /// <seealso cref="EqualsAll_AcceleratedTypes"/>
        /// <seealso cref="Vector128.EqualsAll{T}(Vector128{T}, Vector128{T})"/>
        bool EqualsAll(Vector128<sbyte> left, Vector128<sbyte> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are equal (比较两个向量以判定所有元素是否相等).
        /// Mnemonic: <c>rt := (left[0] == right[0]) &amp;&amp; (left[1] == right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] == right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素相等时返回<c>true</c>).</returns>
        /// <seealso cref="EqualsAll_AcceleratedTypes"/>
        /// <seealso cref="Vector128.EqualsAll{T}(Vector128{T}, Vector128{T})"/>
        bool EqualsAll(Vector128<byte> left, Vector128<byte> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are equal (比较两个向量以判定所有元素是否相等).
        /// Mnemonic: <c>rt := (left[0] == right[0]) &amp;&amp; (left[1] == right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] == right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素相等时返回<c>true</c>).</returns>
        /// <seealso cref="EqualsAll_AcceleratedTypes"/>
        /// <seealso cref="Vector128.EqualsAll{T}(Vector128{T}, Vector128{T})"/>
        bool EqualsAll(Vector128<short> left, Vector128<short> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are equal (比较两个向量以判定所有元素是否相等).
        /// Mnemonic: <c>rt := (left[0] == right[0]) &amp;&amp; (left[1] == right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] == right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素相等时返回<c>true</c>).</returns>
        /// <seealso cref="EqualsAll_AcceleratedTypes"/>
        /// <seealso cref="Vector128.EqualsAll{T}(Vector128{T}, Vector128{T})"/>
        bool EqualsAll(Vector128<ushort> left, Vector128<ushort> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are equal (比较两个向量以判定所有元素是否相等).
        /// Mnemonic: <c>rt := (left[0] == right[0]) &amp;&amp; (left[1] == right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] == right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素相等时返回<c>true</c>).</returns>
        /// <seealso cref="EqualsAll_AcceleratedTypes"/>
        /// <seealso cref="Vector128.EqualsAll{T}(Vector128{T}, Vector128{T})"/>
        bool EqualsAll(Vector128<int> left, Vector128<int> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are equal (比较两个向量以判定所有元素是否相等).
        /// Mnemonic: <c>rt := (left[0] == right[0]) &amp;&amp; (left[1] == right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] == right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素相等时返回<c>true</c>).</returns>
        /// <seealso cref="EqualsAll_AcceleratedTypes"/>
        /// <seealso cref="Vector128.EqualsAll{T}(Vector128{T}, Vector128{T})"/>
        bool EqualsAll(Vector128<uint> left, Vector128<uint> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are equal (比较两个向量以判定所有元素是否相等).
        /// Mnemonic: <c>rt := (left[0] == right[0]) &amp;&amp; (left[1] == right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] == right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素相等时返回<c>true</c>).</returns>
        /// <seealso cref="EqualsAll_AcceleratedTypes"/>
        /// <seealso cref="Vector128.EqualsAll{T}(Vector128{T}, Vector128{T})"/>
        bool EqualsAll(Vector128<long> left, Vector128<long> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are equal (比较两个向量以判定所有元素是否相等).
        /// Mnemonic: <c>rt := (left[0] == right[0]) &amp;&amp; (left[1] == right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] == right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素相等时返回<c>true</c>).</returns>
        /// <seealso cref="EqualsAll_AcceleratedTypes"/>
        /// <seealso cref="Vector128.EqualsAll{T}(Vector128{T}, Vector128{T})"/>
        bool EqualsAll(Vector128<ulong> left, Vector128<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>EqualsAny</c> (运行 <c>EqualsAny</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="EqualsAny(Vector128{byte}, Vector128{byte})"/>
        TypeCodeFlags EqualsAny_AcceleratedTypes { get; }

        /// <summary>
        /// Compares two vectors to determine if any elements are equal (比较两个向量以判定任一元素是否相等).
        /// Mnemonic: <c>rt := (left[0] == right[0]) || (left[1] == right[1]) || ... || (left[Count-1] == right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素相等时返回<c>true</c>).</returns>
        /// <seealso cref="EqualsAny_AcceleratedTypes"/>
        /// <seealso cref="Vector128.EqualsAny{T}(Vector128{T}, Vector128{T})"/>
        bool EqualsAny(Vector128<float> left, Vector128<float> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are equal (比较两个向量以判定任一元素是否相等).
        /// Mnemonic: <c>rt := (left[0] == right[0]) || (left[1] == right[1]) || ... || (left[Count-1] == right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素相等时返回<c>true</c>).</returns>
        /// <seealso cref="EqualsAny_AcceleratedTypes"/>
        /// <seealso cref="Vector128.EqualsAny{T}(Vector128{T}, Vector128{T})"/>
        bool EqualsAny(Vector128<double> left, Vector128<double> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are equal (比较两个向量以判定任一元素是否相等).
        /// Mnemonic: <c>rt := (left[0] == right[0]) || (left[1] == right[1]) || ... || (left[Count-1] == right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素相等时返回<c>true</c>).</returns>
        /// <seealso cref="EqualsAny_AcceleratedTypes"/>
        /// <seealso cref="Vector128.EqualsAny{T}(Vector128{T}, Vector128{T})"/>
        bool EqualsAny(Vector128<sbyte> left, Vector128<sbyte> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are equal (比较两个向量以判定任一元素是否相等).
        /// Mnemonic: <c>rt := (left[0] == right[0]) || (left[1] == right[1]) || ... || (left[Count-1] == right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素相等时返回<c>true</c>).</returns>
        /// <seealso cref="EqualsAny_AcceleratedTypes"/>
        /// <seealso cref="Vector128.EqualsAny{T}(Vector128{T}, Vector128{T})"/>
        bool EqualsAny(Vector128<byte> left, Vector128<byte> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are equal (比较两个向量以判定任一元素是否相等).
        /// Mnemonic: <c>rt := (left[0] == right[0]) || (left[1] == right[1]) || ... || (left[Count-1] == right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素相等时返回<c>true</c>).</returns>
        /// <seealso cref="EqualsAny_AcceleratedTypes"/>
        /// <seealso cref="Vector128.EqualsAny{T}(Vector128{T}, Vector128{T})"/>
        bool EqualsAny(Vector128<short> left, Vector128<short> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are equal (比较两个向量以判定任一元素是否相等).
        /// Mnemonic: <c>rt := (left[0] == right[0]) || (left[1] == right[1]) || ... || (left[Count-1] == right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素相等时返回<c>true</c>).</returns>
        /// <seealso cref="EqualsAny_AcceleratedTypes"/>
        /// <seealso cref="Vector128.EqualsAny{T}(Vector128{T}, Vector128{T})"/>
        bool EqualsAny(Vector128<ushort> left, Vector128<ushort> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are equal (比较两个向量以判定任一元素是否相等).
        /// Mnemonic: <c>rt := (left[0] == right[0]) || (left[1] == right[1]) || ... || (left[Count-1] == right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素相等时返回<c>true</c>).</returns>
        /// <seealso cref="EqualsAny_AcceleratedTypes"/>
        /// <seealso cref="Vector128.EqualsAny{T}(Vector128{T}, Vector128{T})"/>
        bool EqualsAny(Vector128<int> left, Vector128<int> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are equal (比较两个向量以判定任一元素是否相等).
        /// Mnemonic: <c>rt := (left[0] == right[0]) || (left[1] == right[1]) || ... || (left[Count-1] == right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素相等时返回<c>true</c>).</returns>
        /// <seealso cref="EqualsAny_AcceleratedTypes"/>
        /// <seealso cref="Vector128.EqualsAny{T}(Vector128{T}, Vector128{T})"/>
        bool EqualsAny(Vector128<uint> left, Vector128<uint> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are equal (比较两个向量以判定任一元素是否相等).
        /// Mnemonic: <c>rt := (left[0] == right[0]) || (left[1] == right[1]) || ... || (left[Count-1] == right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素相等时返回<c>true</c>).</returns>
        /// <seealso cref="EqualsAny_AcceleratedTypes"/>
        /// <seealso cref="Vector128.EqualsAny{T}(Vector128{T}, Vector128{T})"/>
        bool EqualsAny(Vector128<long> left, Vector128<long> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are equal (比较两个向量以判定任一元素是否相等).
        /// Mnemonic: <c>rt := (left[0] == right[0]) || (left[1] == right[1]) || ... || (left[Count-1] == right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were equal to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素相等时返回<c>true</c>).</returns>
        /// <seealso cref="EqualsAny_AcceleratedTypes"/>
        /// <seealso cref="Vector128.EqualsAny{T}(Vector128{T}, Vector128{T})"/>
        bool EqualsAny(Vector128<ulong> left, Vector128<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>GreaterThan</c> (运行 <c>GreaterThan</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="GreaterThan(Vector128{byte}, Vector128{byte})"/>
        TypeCodeFlags GreaterThan_AcceleratedTypes { get; }

        /// <summary>
        /// Compares two vectors to determine which is greater on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更大).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &gt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大).</returns>
        /// <seealso cref="GreaterThan_AcceleratedTypes"/>
        /// <seealso cref="Vector128.GreaterThan{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<float> GreaterThan(Vector128<float> left, Vector128<float> right);

        /// <summary>
        /// Compares two vectors to determine which is greater on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更大).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &gt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大).</returns>
        /// <seealso cref="GreaterThan_AcceleratedTypes"/>
        /// <seealso cref="Vector128.GreaterThan{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<double> GreaterThan(Vector128<double> left, Vector128<double> right);

        /// <summary>
        /// Compares two vectors to determine which is greater on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更大).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &gt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大).</returns>
        /// <seealso cref="GreaterThan_AcceleratedTypes"/>
        /// <seealso cref="Vector128.GreaterThan{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<sbyte> GreaterThan(Vector128<sbyte> left, Vector128<sbyte> right);

        /// <summary>
        /// Compares two vectors to determine which is greater on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更大).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &gt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大).</returns>
        /// <seealso cref="GreaterThan_AcceleratedTypes"/>
        /// <seealso cref="Vector128.GreaterThan{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<byte> GreaterThan(Vector128<byte> left, Vector128<byte> right);

        /// <summary>
        /// Compares two vectors to determine which is greater on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更大).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &gt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大).</returns>
        /// <seealso cref="GreaterThan_AcceleratedTypes"/>
        /// <seealso cref="Vector128.GreaterThan{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<short> GreaterThan(Vector128<short> left, Vector128<short> right);

        /// <summary>
        /// Compares two vectors to determine which is greater on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更大).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &gt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大).</returns>
        /// <seealso cref="GreaterThan_AcceleratedTypes"/>
        /// <seealso cref="Vector128.GreaterThan{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<ushort> GreaterThan(Vector128<ushort> left, Vector128<ushort> right);

        /// <summary>
        /// Compares two vectors to determine which is greater on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更大).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &gt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大).</returns>
        /// <seealso cref="GreaterThan_AcceleratedTypes"/>
        /// <seealso cref="Vector128.GreaterThan{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<int> GreaterThan(Vector128<int> left, Vector128<int> right);

        /// <summary>
        /// Compares two vectors to determine which is greater on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更大).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &gt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大).</returns>
        /// <seealso cref="GreaterThan_AcceleratedTypes"/>
        /// <seealso cref="Vector128.GreaterThan{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<uint> GreaterThan(Vector128<uint> left, Vector128<uint> right);

        /// <summary>
        /// Compares two vectors to determine which is greater on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更大).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &gt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大).</returns>
        /// <seealso cref="GreaterThan_AcceleratedTypes"/>
        /// <seealso cref="Vector128.GreaterThan{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<long> GreaterThan(Vector128<long> left, Vector128<long> right);

        /// <summary>
        /// Compares two vectors to determine which is greater on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更大).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &gt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were greater (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更大).</returns>
        /// <seealso cref="GreaterThan_AcceleratedTypes"/>
        /// <seealso cref="Vector128.GreaterThan{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<ulong> GreaterThan(Vector128<ulong> left, Vector128<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>GreaterThanAll</c> (运行 <c>GreaterThanAll</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="GreaterThanAll(Vector128{byte}, Vector128{byte})"/>
        TypeCodeFlags GreaterThanAll_AcceleratedTypes { get; }

        /// <summary>
        /// Compares two vectors to determine if all elements are greater (比较两个向量以判定所有元素是否大于).
        /// Mnemonic: <c>rt := (left[0] &gt; right[0]) &amp;&amp; (left[1] &gt; right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &gt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were greater to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素大于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanAll_AcceleratedTypes"/>
        /// <seealso cref="Vector128.GreaterThanAll{T}(Vector128{T}, Vector128{T})"/>
        bool GreaterThanAll(Vector128<float> left, Vector128<float> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are greater (比较两个向量以判定所有元素是否大于).
        /// Mnemonic: <c>rt := (left[0] &gt; right[0]) &amp;&amp; (left[1] &gt; right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &gt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were greater to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素大于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanAll_AcceleratedTypes"/>
        /// <seealso cref="Vector128.GreaterThanAll{T}(Vector128{T}, Vector128{T})"/>
        bool GreaterThanAll(Vector128<double> left, Vector128<double> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are greater (比较两个向量以判定所有元素是否大于).
        /// Mnemonic: <c>rt := (left[0] &gt; right[0]) &amp;&amp; (left[1] &gt; right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &gt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were greater to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素大于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanAll_AcceleratedTypes"/>
        /// <seealso cref="Vector128.GreaterThanAll{T}(Vector128{T}, Vector128{T})"/>
        bool GreaterThanAll(Vector128<sbyte> left, Vector128<sbyte> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are greater (比较两个向量以判定所有元素是否大于).
        /// Mnemonic: <c>rt := (left[0] &gt; right[0]) &amp;&amp; (left[1] &gt; right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &gt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were greater to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素大于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanAll_AcceleratedTypes"/>
        /// <seealso cref="Vector128.GreaterThanAll{T}(Vector128{T}, Vector128{T})"/>
        bool GreaterThanAll(Vector128<byte> left, Vector128<byte> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are greater (比较两个向量以判定所有元素是否大于).
        /// Mnemonic: <c>rt := (left[0] &gt; right[0]) &amp;&amp; (left[1] &gt; right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &gt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were greater to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素大于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanAll_AcceleratedTypes"/>
        /// <seealso cref="Vector128.GreaterThanAll{T}(Vector128{T}, Vector128{T})"/>
        bool GreaterThanAll(Vector128<short> left, Vector128<short> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are greater (比较两个向量以判定所有元素是否大于).
        /// Mnemonic: <c>rt := (left[0] &gt; right[0]) &amp;&amp; (left[1] &gt; right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &gt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were greater to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素大于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanAll_AcceleratedTypes"/>
        /// <seealso cref="Vector128.GreaterThanAll{T}(Vector128{T}, Vector128{T})"/>
        bool GreaterThanAll(Vector128<ushort> left, Vector128<ushort> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are greater (比较两个向量以判定所有元素是否大于).
        /// Mnemonic: <c>rt := (left[0] &gt; right[0]) &amp;&amp; (left[1] &gt; right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &gt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were greater to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素大于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanAll_AcceleratedTypes"/>
        /// <seealso cref="Vector128.GreaterThanAll{T}(Vector128{T}, Vector128{T})"/>
        bool GreaterThanAll(Vector128<int> left, Vector128<int> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are greater (比较两个向量以判定所有元素是否大于).
        /// Mnemonic: <c>rt := (left[0] &gt; right[0]) &amp;&amp; (left[1] &gt; right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &gt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were greater to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素大于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanAll_AcceleratedTypes"/>
        /// <seealso cref="Vector128.GreaterThanAll{T}(Vector128{T}, Vector128{T})"/>
        bool GreaterThanAll(Vector128<uint> left, Vector128<uint> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are greater (比较两个向量以判定所有元素是否大于).
        /// Mnemonic: <c>rt := (left[0] &gt; right[0]) &amp;&amp; (left[1] &gt; right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &gt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were greater to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素大于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanAll_AcceleratedTypes"/>
        /// <seealso cref="Vector128.GreaterThanAll{T}(Vector128{T}, Vector128{T})"/>
        bool GreaterThanAll(Vector128<long> left, Vector128<long> right);

        /// <summary>
        /// Compares two vectors to determine if all elements are greater (比较两个向量以判定所有元素是否大于).
        /// Mnemonic: <c>rt := (left[0] &gt; right[0]) &amp;&amp; (left[1] &gt; right[1]) &amp;&amp; ... &amp;&amp; (left[Count-1] &gt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if all elements in <paramref name="left" /> were greater to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的全部对应元素大于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanAll_AcceleratedTypes"/>
        /// <seealso cref="Vector128.GreaterThanAll{T}(Vector128{T}, Vector128{T})"/>
        bool GreaterThanAll(Vector128<ulong> left, Vector128<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>GreaterThanAny</c> (运行 <c>GreaterThanAny</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="GreaterThanAny(Vector128{byte}, Vector128{byte})"/>
        TypeCodeFlags GreaterThanAny_AcceleratedTypes { get; }

        /// <summary>
        /// Compares two vectors to determine if any elements are greater (比较两个向量以判定任一元素是否大于).
        /// Mnemonic: <c>rt := (left[0] &gt; right[0]) || (left[1] &gt; right[1]) || ... || (left[Count-1] &gt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were greater to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素大于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanAny_AcceleratedTypes"/>
        /// <seealso cref="Vector128.GreaterThanAny{T}(Vector128{T}, Vector128{T})"/>
        bool GreaterThanAny(Vector128<float> left, Vector128<float> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are greater (比较两个向量以判定任一元素是否大于).
        /// Mnemonic: <c>rt := (left[0] &gt; right[0]) || (left[1] &gt; right[1]) || ... || (left[Count-1] &gt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were greater to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素大于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanAny_AcceleratedTypes"/>
        /// <seealso cref="Vector128.GreaterThanAny{T}(Vector128{T}, Vector128{T})"/>
        bool GreaterThanAny(Vector128<double> left, Vector128<double> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are greater (比较两个向量以判定任一元素是否大于).
        /// Mnemonic: <c>rt := (left[0] &gt; right[0]) || (left[1] &gt; right[1]) || ... || (left[Count-1] &gt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were greater to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素大于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanAny_AcceleratedTypes"/>
        /// <seealso cref="Vector128.GreaterThanAny{T}(Vector128{T}, Vector128{T})"/>
        bool GreaterThanAny(Vector128<sbyte> left, Vector128<sbyte> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are greater (比较两个向量以判定任一元素是否大于).
        /// Mnemonic: <c>rt := (left[0] &gt; right[0]) || (left[1] &gt; right[1]) || ... || (left[Count-1] &gt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were greater to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素大于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanAny_AcceleratedTypes"/>
        /// <seealso cref="Vector128.GreaterThanAny{T}(Vector128{T}, Vector128{T})"/>
        bool GreaterThanAny(Vector128<byte> left, Vector128<byte> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are greater (比较两个向量以判定任一元素是否大于).
        /// Mnemonic: <c>rt := (left[0] &gt; right[0]) || (left[1] &gt; right[1]) || ... || (left[Count-1] &gt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were greater to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素大于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanAny_AcceleratedTypes"/>
        /// <seealso cref="Vector128.GreaterThanAny{T}(Vector128{T}, Vector128{T})"/>
        bool GreaterThanAny(Vector128<short> left, Vector128<short> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are greater (比较两个向量以判定任一元素是否大于).
        /// Mnemonic: <c>rt := (left[0] &gt; right[0]) || (left[1] &gt; right[1]) || ... || (left[Count-1] &gt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were greater to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素大于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanAny_AcceleratedTypes"/>
        /// <seealso cref="Vector128.GreaterThanAny{T}(Vector128{T}, Vector128{T})"/>
        bool GreaterThanAny(Vector128<ushort> left, Vector128<ushort> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are greater (比较两个向量以判定任一元素是否大于).
        /// Mnemonic: <c>rt := (left[0] &gt; right[0]) || (left[1] &gt; right[1]) || ... || (left[Count-1] &gt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were greater to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素大于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanAny_AcceleratedTypes"/>
        /// <seealso cref="Vector128.GreaterThanAny{T}(Vector128{T}, Vector128{T})"/>
        bool GreaterThanAny(Vector128<int> left, Vector128<int> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are greater (比较两个向量以判定任一元素是否大于).
        /// Mnemonic: <c>rt := (left[0] &gt; right[0]) || (left[1] &gt; right[1]) || ... || (left[Count-1] &gt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were greater to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素大于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanAny_AcceleratedTypes"/>
        /// <seealso cref="Vector128.GreaterThanAny{T}(Vector128{T}, Vector128{T})"/>
        bool GreaterThanAny(Vector128<uint> left, Vector128<uint> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are greater (比较两个向量以判定任一元素是否大于).
        /// Mnemonic: <c>rt := (left[0] &gt; right[0]) || (left[1] &gt; right[1]) || ... || (left[Count-1] &gt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were greater to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素大于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanAny_AcceleratedTypes"/>
        /// <seealso cref="Vector128.GreaterThanAny{T}(Vector128{T}, Vector128{T})"/>
        bool GreaterThanAny(Vector128<long> left, Vector128<long> right);

        /// <summary>
        /// Compares two vectors to determine if any elements are greater (比较两个向量以判定任一元素是否大于).
        /// Mnemonic: <c>rt := (left[0] &gt; right[0]) || (left[1] &gt; right[1]) || ... || (left[Count-1] &gt; right[Count-1])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>Return <c>true</c> if any elements in <paramref name="left" /> were greater to the corresponding element in <paramref name="right" /> (当<paramref name="left" />和<paramref name="right" />的任一对应元素大于时返回<c>true</c>).</returns>
        /// <seealso cref="GreaterThanAny_AcceleratedTypes"/>
        /// <seealso cref="Vector128.GreaterThanAny{T}(Vector128{T}, Vector128{T})"/>
        bool GreaterThanAny(Vector128<ulong> left, Vector128<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>LessThan</c> (运行 <c>LessThan</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="LessThan(Vector128{byte}, Vector128{byte})"/>
        TypeCodeFlags LessThan_AcceleratedTypes { get; }

        /// <summary>
        /// Compares two vectors to determine which is less on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更小).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &lt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were less (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更小).</returns>
        /// <seealso cref="LessThan_AcceleratedTypes"/>
        /// <seealso cref="Vector128.LessThan{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<float> LessThan(Vector128<float> left, Vector128<float> right);

        /// <summary>
        /// Compares two vectors to determine which is less on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更小).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &lt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were less (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更小).</returns>
        /// <seealso cref="LessThan_AcceleratedTypes"/>
        /// <seealso cref="Vector128.LessThan{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<double> LessThan(Vector128<double> left, Vector128<double> right);

        /// <summary>
        /// Compares two vectors to determine which is less on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更小).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &lt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were less (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更小).</returns>
        /// <seealso cref="LessThan_AcceleratedTypes"/>
        /// <seealso cref="Vector128.LessThan{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<sbyte> LessThan(Vector128<sbyte> left, Vector128<sbyte> right);

        /// <summary>
        /// Compares two vectors to determine which is less on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更小).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &lt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were less (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更小).</returns>
        /// <seealso cref="LessThan_AcceleratedTypes"/>
        /// <seealso cref="Vector128.LessThan{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<byte> LessThan(Vector128<byte> left, Vector128<byte> right);

        /// <summary>
        /// Compares two vectors to determine which is less on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更小).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &lt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were less (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更小).</returns>
        /// <seealso cref="LessThan_AcceleratedTypes"/>
        /// <seealso cref="Vector128.LessThan{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<short> LessThan(Vector128<short> left, Vector128<short> right);

        /// <summary>
        /// Compares two vectors to determine which is less on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更小).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &lt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were less (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更小).</returns>
        /// <seealso cref="LessThan_AcceleratedTypes"/>
        /// <seealso cref="Vector128.LessThan{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<ushort> LessThan(Vector128<ushort> left, Vector128<ushort> right);

        /// <summary>
        /// Compares two vectors to determine which is less on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更小).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &lt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were less (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更小).</returns>
        /// <seealso cref="LessThan_AcceleratedTypes"/>
        /// <seealso cref="Vector128.LessThan{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<int> LessThan(Vector128<int> left, Vector128<int> right);

        /// <summary>
        /// Compares two vectors to determine which is less on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更小).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &lt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were less (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更小).</returns>
        /// <seealso cref="LessThan_AcceleratedTypes"/>
        /// <seealso cref="Vector128.LessThan{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<uint> LessThan(Vector128<uint> left, Vector128<uint> right);

        /// <summary>
        /// Compares two vectors to determine which is less on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更小).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &lt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were less (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更小).</returns>
        /// <seealso cref="LessThan_AcceleratedTypes"/>
        /// <seealso cref="Vector128.LessThan{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<long> LessThan(Vector128<long> left, Vector128<long> right);

        /// <summary>
        /// Compares two vectors to determine which is less on a per-element basis (比较两个向量，在每个元素的基础上确定哪个更小).
        /// Mnemonic: <c>rt[i] := to_mask(left[i] &lt; right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are all-bits-set or zero, depending on if which of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> were less (一个向量，其元素是全位为1或0，取决于<paramref name="left" />和<paramref name="right" />的对应元素中哪个更小).</returns>
        /// <seealso cref="LessThan_AcceleratedTypes"/>
        /// <seealso cref="Vector128.LessThan{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<ulong> LessThan(Vector128<ulong> left, Vector128<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>Max</c> (运行 <c>Max</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Max(Vector128{byte}, Vector128{byte})"/>
        TypeCodeFlags Max_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the maximum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最大值).
        /// Mnemonic: <c>rt[i] := max(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the maximum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最大值).</returns>
        /// <seealso cref="Max_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Max{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<float> Max(Vector128<float> left, Vector128<float> right);

        /// <summary>
        /// Computes the maximum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最大值).
        /// Mnemonic: <c>rt[i] := max(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the maximum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最大值).</returns>
        /// <seealso cref="Max_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Max{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<double> Max(Vector128<double> left, Vector128<double> right);

        /// <summary>
        /// Computes the maximum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最大值).
        /// Mnemonic: <c>rt[i] := max(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the maximum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最大值).</returns>
        /// <seealso cref="Max_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Max{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<sbyte> Max(Vector128<sbyte> left, Vector128<sbyte> right);

        /// <summary>
        /// Computes the maximum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最大值).
        /// Mnemonic: <c>rt[i] := max(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the maximum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最大值).</returns>
        /// <seealso cref="Max_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Max{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<byte> Max(Vector128<byte> left, Vector128<byte> right);

        /// <summary>
        /// Computes the maximum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最大值).
        /// Mnemonic: <c>rt[i] := max(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the maximum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最大值).</returns>
        /// <seealso cref="Max_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Max{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<short> Max(Vector128<short> left, Vector128<short> right);

        /// <summary>
        /// Computes the maximum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最大值).
        /// Mnemonic: <c>rt[i] := max(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the maximum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最大值).</returns>
        /// <seealso cref="Max_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Max{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<ushort> Max(Vector128<ushort> left, Vector128<ushort> right);

        /// <summary>
        /// Computes the maximum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最大值).
        /// Mnemonic: <c>rt[i] := max(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the maximum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最大值).</returns>
        /// <seealso cref="Max_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Max{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<int> Max(Vector128<int> left, Vector128<int> right);

        /// <summary>
        /// Computes the maximum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最大值).
        /// Mnemonic: <c>rt[i] := max(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the maximum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最大值).</returns>
        /// <seealso cref="Max_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Max{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<uint> Max(Vector128<uint> left, Vector128<uint> right);

        /// <summary>
        /// Computes the maximum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最大值).
        /// Mnemonic: <c>rt[i] := max(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the maximum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最大值).</returns>
        /// <seealso cref="Max_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Max{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<long> Max(Vector128<long> left, Vector128<long> right);

        /// <summary>
        /// Computes the maximum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最大值).
        /// Mnemonic: <c>rt[i] := max(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the maximum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最大值).</returns>
        /// <seealso cref="Max_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Max{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<ulong> Max(Vector128<ulong> left, Vector128<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>Min</c> (运行 <c>Min</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Min(Vector128{byte}, Vector128{byte})"/>
        TypeCodeFlags Min_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the minimum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最小值).
        /// Mnemonic: <c>rt[i] := min(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the minimum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最小值).</returns>
        /// <seealso cref="Min_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Min{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<float> Min(Vector128<float> left, Vector128<float> right);

        /// <summary>
        /// Computes the minimum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最小值).
        /// Mnemonic: <c>rt[i] := min(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the minimum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最小值).</returns>
        /// <seealso cref="Min_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Min{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<double> Min(Vector128<double> left, Vector128<double> right);

        /// <summary>
        /// Computes the minimum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最小值).
        /// Mnemonic: <c>rt[i] := min(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the minimum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最小值).</returns>
        /// <seealso cref="Min_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Min{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<sbyte> Min(Vector128<sbyte> left, Vector128<sbyte> right);

        /// <summary>
        /// Computes the minimum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最小值).
        /// Mnemonic: <c>rt[i] := min(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the minimum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最小值).</returns>
        /// <seealso cref="Min_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Min{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<byte> Min(Vector128<byte> left, Vector128<byte> right);

        /// <summary>
        /// Computes the minimum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最小值).
        /// Mnemonic: <c>rt[i] := min(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the minimum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最小值).</returns>
        /// <seealso cref="Min_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Min{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<short> Min(Vector128<short> left, Vector128<short> right);

        /// <summary>
        /// Computes the minimum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最小值).
        /// Mnemonic: <c>rt[i] := min(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the minimum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最小值).</returns>
        /// <seealso cref="Min_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Min{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<ushort> Min(Vector128<ushort> left, Vector128<ushort> right);

        /// <summary>
        /// Computes the minimum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最小值).
        /// Mnemonic: <c>rt[i] := min(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the minimum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最小值).</returns>
        /// <seealso cref="Min_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Min{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<int> Min(Vector128<int> left, Vector128<int> right);

        /// <summary>
        /// Computes the minimum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最小值).
        /// Mnemonic: <c>rt[i] := min(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the minimum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最小值).</returns>
        /// <seealso cref="Min_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Min{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<uint> Min(Vector128<uint> left, Vector128<uint> right);

        /// <summary>
        /// Computes the minimum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最小值).
        /// Mnemonic: <c>rt[i] := min(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the minimum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最小值).</returns>
        /// <seealso cref="Min_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Min{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<long> Min(Vector128<long> left, Vector128<long> right);

        /// <summary>
        /// Computes the minimum of two vectors on a per-element basis (在每个元素的基础上计算两个向量的最小值).
        /// Mnemonic: <c>rt[i] := min(left[i], right[i])</c>.
        /// </summary>
        /// <param name="left">The vector to compare with <paramref name="right" /> (将会与<paramref name="right" />进行比较的向量).</param>
        /// <param name="right">The vector to compare with <paramref name="left" /> (将会与<paramref name="left" />进行比较的向量).</param>
        /// <returns>A vector whose elements are the minimum of the corresponding elements in <paramref name="left" /> and <paramref name="right" /> (一个向量，其元素是<paramref name="left" />和<paramref name="right" />的相应元素的最小值).</returns>
        /// <seealso cref="Min_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Min{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<ulong> Min(Vector128<ulong> left, Vector128<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>Multiply</c> (运行 <c>Multiply</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Multiply(Vector128{byte}, Vector128{byte})"/>
        /// <seealso cref="Multiply_FullAcceleratedTypes"/>
        TypeCodeFlags Multiply_AcceleratedTypes { get; }

        /// <summary>
        /// Types with full hardware acceleration when running <c>Multiply</c> (运行 <c>Multiply</c> 时具有完全硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>`AcceleratedTypes` only indicates the presence of hardware acceleration, possibly indirectly through some algorithm. And `FullAcceleratedTypes` means that dedicated instructions are used to achieve full hardware acceleration. (`AcceleratedTypes`仅表示存在硬件加速,有可能是通过一些算法间接实现的. 而 `FullAcceleratedTypes`意味着使用了专用指令，实现了完全的硬件加速)</para>
        /// </remarks>
        /// <seealso cref="Multiply(Vector128{byte}, Vector128{byte})"/>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        TypeCodeFlags Multiply_FullAcceleratedTypes { get; }

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们各元素的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Multiply{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<float> Multiply(Vector128<float> left, Vector128<float> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们各元素的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Multiply{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<double> Multiply(Vector128<double> left, Vector128<double> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们各元素的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Multiply{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<sbyte> Multiply(Vector128<sbyte> left, Vector128<sbyte> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们各元素的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Multiply{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<byte> Multiply(Vector128<byte> left, Vector128<byte> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们各元素的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Multiply{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<short> Multiply(Vector128<short> left, Vector128<short> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们各元素的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Multiply{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<ushort> Multiply(Vector128<ushort> left, Vector128<ushort> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们各元素的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Multiply{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<int> Multiply(Vector128<int> left, Vector128<int> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们各元素的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Multiply{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<uint> Multiply(Vector128<uint> left, Vector128<uint> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们各元素的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Multiply{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<long> Multiply(Vector128<long> left, Vector128<long> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们各元素的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Multiply{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<ulong> Multiply(Vector128<ulong> left, Vector128<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>Negate</c> (运行 <c>Negate</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Negate(Vector128{float})"/>
        TypeCodeFlags Negate_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the negate of a vector (计算向量的相反数).
        /// Mnemonic: <c>rt[i] := -vector[i]</c>.
        /// </summary>
        /// <param name="vector">The vector to negate (将计算相反数的向量).</param>
        /// <returns>A vector whose elements are the negate of the elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中各元素的相反数).</returns>
        /// <seealso cref="Negate_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Negate{T}(Vector128{T})" />
        Vector128<float> Negate(Vector128<float> vector);

        /// <summary>
        /// Computes the negate of a vector (计算向量的相反数).
        /// Mnemonic: <c>rt[i] := -vector[i]</c>.
        /// </summary>
        /// <param name="vector">The vector to negate (将计算相反数的向量).</param>
        /// <returns>A vector whose elements are the negate of the elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中各元素的相反数).</returns>
        /// <seealso cref="Negate_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Negate{T}(Vector128{T})" />
        Vector128<double> Negate(Vector128<double> vector);

        /// <summary>
        /// Computes the negate of a vector (计算向量的相反数).
        /// Mnemonic: <c>rt[i] := -vector[i]</c>.
        /// </summary>
        /// <param name="vector">The vector to negate (将计算相反数的向量).</param>
        /// <returns>A vector whose elements are the negate of the elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中各元素的相反数).</returns>
        /// <seealso cref="Negate_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Negate{T}(Vector128{T})" />
        Vector128<sbyte> Negate(Vector128<sbyte> vector);

        /// <summary>
        /// Computes the negate of a vector (计算向量的相反数).
        /// Mnemonic: <c>rt[i] := -vector[i]</c>.
        /// </summary>
        /// <param name="vector">The vector to negate (将计算相反数的向量).</param>
        /// <returns>A vector whose elements are the negate of the elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中各元素的相反数).</returns>
        /// <seealso cref="Negate_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Negate{T}(Vector128{T})" />
        Vector128<short> Negate(Vector128<short> vector);

        /// <summary>
        /// Computes the negate of a vector (计算向量的相反数).
        /// Mnemonic: <c>rt[i] := -vector[i]</c>.
        /// </summary>
        /// <param name="vector">The vector to negate (将计算相反数的向量).</param>
        /// <returns>A vector whose elements are the negate of the elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中各元素的相反数).</returns>
        /// <seealso cref="Negate_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Negate{T}(Vector128{T})" />
        Vector128<int> Negate(Vector128<int> vector);

        /// <summary>
        /// Computes the negate of a vector (计算向量的相反数).
        /// Mnemonic: <c>rt[i] := -vector[i]</c>.
        /// </summary>
        /// <param name="vector">The vector to negate (将计算相反数的向量).</param>
        /// <returns>A vector whose elements are the negate of the elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中各元素的相反数).</returns>
        /// <seealso cref="Negate_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Negate{T}(Vector128{T})" />
        Vector128<long> Negate(Vector128<long> vector);


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
        /// <seealso cref="Vector128.OnesComplement{T}(Vector128{T})"/> // Since: .NET 7
        Vector128<T> OnesComplement<T>(Vector128<T> vector) where T : struct;


        /// <summary>
        /// Types with hardware acceleration when running <c>Subtract</c> (运行 <c>Subtract</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Subtract(Vector128{byte}, Vector128{byte})"/>
        TypeCodeFlags Subtract_AcceleratedTypes { get; }

        /// <summary>
        /// Subtracts two vectors to compute their difference (将两个向量相减来计算它们的差).
        /// Mnemonic: <c>rt[i] := left[i] - right[i]</c>.
        /// </summary>
        /// <param name="left">The vector from which <paramref name="right" /> will be subtracted (将被减去<paramref name="right" />的向量).</param>
        /// <param name="right">The vector to subtract from <paramref name="left" /> (要从<paramref name="left" />减去的向量).</param>
        /// <returns>The difference of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" />与<paramref name="right" />的差).</returns>
        /// <seealso cref="Subtract_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Subtract{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<float> Subtract(Vector128<float> left, Vector128<float> right);

        /// <summary>
        /// Subtracts two vectors to compute their difference (将两个向量相减来计算它们的差).
        /// Mnemonic: <c>rt[i] := left[i] - right[i]</c>.
        /// </summary>
        /// <param name="left">The vector from which <paramref name="right" /> will be subtracted (将被减去<paramref name="right" />的向量).</param>
        /// <param name="right">The vector to subtract from <paramref name="left" /> (要从<paramref name="left" />减去的向量).</param>
        /// <returns>The difference of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" />与<paramref name="right" />的差).</returns>
        /// <seealso cref="Subtract_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Subtract{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<double> Subtract(Vector128<double> left, Vector128<double> right);

        /// <summary>
        /// Subtracts two vectors to compute their difference (将两个向量相减来计算它们的差).
        /// Mnemonic: <c>rt[i] := left[i] - right[i]</c>.
        /// </summary>
        /// <param name="left">The vector from which <paramref name="right" /> will be subtracted (将被减去<paramref name="right" />的向量).</param>
        /// <param name="right">The vector to subtract from <paramref name="left" /> (要从<paramref name="left" />减去的向量).</param>
        /// <returns>The difference of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" />与<paramref name="right" />的差).</returns>
        /// <seealso cref="Subtract_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Subtract{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<sbyte> Subtract(Vector128<sbyte> left, Vector128<sbyte> right);

        /// <summary>
        /// Subtracts two vectors to compute their difference (将两个向量相减来计算它们的差).
        /// Mnemonic: <c>rt[i] := left[i] - right[i]</c>.
        /// </summary>
        /// <param name="left">The vector from which <paramref name="right" /> will be subtracted (将被减去<paramref name="right" />的向量).</param>
        /// <param name="right">The vector to subtract from <paramref name="left" /> (要从<paramref name="left" />减去的向量).</param>
        /// <returns>The difference of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" />与<paramref name="right" />的差).</returns>
        /// <seealso cref="Subtract_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Subtract{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<byte> Subtract(Vector128<byte> left, Vector128<byte> right);

        /// <summary>
        /// Subtracts two vectors to compute their difference (将两个向量相减来计算它们的差).
        /// Mnemonic: <c>rt[i] := left[i] - right[i]</c>.
        /// </summary>
        /// <param name="left">The vector from which <paramref name="right" /> will be subtracted (将被减去<paramref name="right" />的向量).</param>
        /// <param name="right">The vector to subtract from <paramref name="left" /> (要从<paramref name="left" />减去的向量).</param>
        /// <returns>The difference of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" />与<paramref name="right" />的差).</returns>
        /// <seealso cref="Subtract_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Subtract{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<short> Subtract(Vector128<short> left, Vector128<short> right);

        /// <summary>
        /// Subtracts two vectors to compute their difference (将两个向量相减来计算它们的差).
        /// Mnemonic: <c>rt[i] := left[i] - right[i]</c>.
        /// </summary>
        /// <param name="left">The vector from which <paramref name="right" /> will be subtracted (将被减去<paramref name="right" />的向量).</param>
        /// <param name="right">The vector to subtract from <paramref name="left" /> (要从<paramref name="left" />减去的向量).</param>
        /// <returns>The difference of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" />与<paramref name="right" />的差).</returns>
        /// <seealso cref="Subtract_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Subtract{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<ushort> Subtract(Vector128<ushort> left, Vector128<ushort> right);

        /// <summary>
        /// Subtracts two vectors to compute their difference (将两个向量相减来计算它们的差).
        /// Mnemonic: <c>rt[i] := left[i] - right[i]</c>.
        /// </summary>
        /// <param name="left">The vector from which <paramref name="right" /> will be subtracted (将被减去<paramref name="right" />的向量).</param>
        /// <param name="right">The vector to subtract from <paramref name="left" /> (要从<paramref name="left" />减去的向量).</param>
        /// <returns>The difference of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" />与<paramref name="right" />的差).</returns>
        /// <seealso cref="Subtract_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Subtract{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<int> Subtract(Vector128<int> left, Vector128<int> right);

        /// <summary>
        /// Subtracts two vectors to compute their difference (将两个向量相减来计算它们的差).
        /// Mnemonic: <c>rt[i] := left[i] - right[i]</c>.
        /// </summary>
        /// <param name="left">The vector from which <paramref name="right" /> will be subtracted (将被减去<paramref name="right" />的向量).</param>
        /// <param name="right">The vector to subtract from <paramref name="left" /> (要从<paramref name="left" />减去的向量).</param>
        /// <returns>The difference of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" />与<paramref name="right" />的差).</returns>
        /// <seealso cref="Subtract_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Subtract{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<uint> Subtract(Vector128<uint> left, Vector128<uint> right);

        /// <summary>
        /// Subtracts two vectors to compute their difference (将两个向量相减来计算它们的差).
        /// Mnemonic: <c>rt[i] := left[i] - right[i]</c>.
        /// </summary>
        /// <param name="left">The vector from which <paramref name="right" /> will be subtracted (将被减去<paramref name="right" />的向量).</param>
        /// <param name="right">The vector to subtract from <paramref name="left" /> (要从<paramref name="left" />减去的向量).</param>
        /// <returns>The difference of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" />与<paramref name="right" />的差).</returns>
        /// <seealso cref="Subtract_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Subtract{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<long> Subtract(Vector128<long> left, Vector128<long> right);

        /// <summary>
        /// Subtracts two vectors to compute their difference (将两个向量相减来计算它们的差).
        /// Mnemonic: <c>rt[i] := left[i] - right[i]</c>.
        /// </summary>
        /// <param name="left">The vector from which <paramref name="right" /> will be subtracted (将被减去<paramref name="right" />的向量).</param>
        /// <param name="right">The vector to subtract from <paramref name="left" /> (要从<paramref name="left" />减去的向量).</param>
        /// <returns>The difference of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" />与<paramref name="right" />的差).</returns>
        /// <seealso cref="Subtract_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Subtract{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<ulong> Subtract(Vector128<ulong> left, Vector128<ulong> right);


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
        /// <seealso cref="Vector128.Xor{T}(Vector128{T}, Vector128{T})"/> // Since: .NET 7
        Vector128<T> Xor<T>(Vector128<T> left, Vector128<T> right) where T : struct;


#endif
    }
}
