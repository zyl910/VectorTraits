using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Zyl.VectorTraits.Impl {
    partial interface IVectorTraits {

        /// <summary>
        /// Types with hardware acceleration when running <c>Add</c> (运行 <c>Add</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Add(Vector{byte}, Vector{byte})"/>
        TypeCodeFlags Add_AcceleratedTypes { get; }

        /// <summary>
        /// Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
        /// Mnemonic: <c>rt[i] := left[i] + right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to add with <paramref name="right" /> (将会与<paramref name="right" />进行相加的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The sum of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的和).</returns>
        /// <seealso cref="Add_AcceleratedTypes"/>
        /// <seealso cref="Vector.Add{T}(Vector{T}, Vector{T})"/> // Since: .NET 7
        Vector<float> Add(Vector<float> left, Vector<float> right);

        /// <summary>
        /// Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
        /// Mnemonic: <c>rt[i] := left[i] + right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to add with <paramref name="right" /> (将会与<paramref name="right" />进行相加的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The sum of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的和).</returns>
        /// <seealso cref="Add_AcceleratedTypes"/>
        /// <seealso cref="Vector.Add{T}(Vector{T}, Vector{T})"/> // Since: .NET 7
        Vector<double> Add(Vector<double> left, Vector<double> right);

        /// <summary>
        /// Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
        /// Mnemonic: <c>rt[i] := left[i] + right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to add with <paramref name="right" /> (将会与<paramref name="right" />进行相加的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The sum of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的和).</returns>
        /// <seealso cref="Add_AcceleratedTypes"/>
        /// <seealso cref="Vector.Add{T}(Vector{T}, Vector{T})"/> // Since: .NET 7
        Vector<sbyte> Add(Vector<sbyte> left, Vector<sbyte> right);

        /// <summary>
        /// Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
        /// Mnemonic: <c>rt[i] := left[i] + right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to add with <paramref name="right" /> (将会与<paramref name="right" />进行相加的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The sum of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的和).</returns>
        /// <seealso cref="Add_AcceleratedTypes"/>
        /// <seealso cref="Vector.Add{T}(Vector{T}, Vector{T})"/> // Since: .NET 7
        Vector<byte> Add(Vector<byte> left, Vector<byte> right);

        /// <summary>
        /// Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
        /// Mnemonic: <c>rt[i] := left[i] + right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to add with <paramref name="right" /> (将会与<paramref name="right" />进行相加的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The sum of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的和).</returns>
        /// <seealso cref="Add_AcceleratedTypes"/>
        /// <seealso cref="Vector.Add{T}(Vector{T}, Vector{T})"/> // Since: .NET 7
        Vector<short> Add(Vector<short> left, Vector<short> right);

        /// <summary>
        /// Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
        /// Mnemonic: <c>rt[i] := left[i] + right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to add with <paramref name="right" /> (将会与<paramref name="right" />进行相加的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The sum of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的和).</returns>
        /// <seealso cref="Add_AcceleratedTypes"/>
        /// <seealso cref="Vector.Add{T}(Vector{T}, Vector{T})"/> // Since: .NET 7
        Vector<ushort> Add(Vector<ushort> left, Vector<ushort> right);

        /// <summary>
        /// Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
        /// Mnemonic: <c>rt[i] := left[i] + right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to add with <paramref name="right" /> (将会与<paramref name="right" />进行相加的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The sum of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的和).</returns>
        /// <seealso cref="Add_AcceleratedTypes"/>
        /// <seealso cref="Vector.Add{T}(Vector{T}, Vector{T})"/> // Since: .NET 7
        Vector<int> Add(Vector<int> left, Vector<int> right);

        /// <summary>
        /// Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
        /// Mnemonic: <c>rt[i] := left[i] + right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to add with <paramref name="right" /> (将会与<paramref name="right" />进行相加的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The sum of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的和).</returns>
        /// <seealso cref="Add_AcceleratedTypes"/>
        /// <seealso cref="Vector.Add{T}(Vector{T}, Vector{T})"/> // Since: .NET 7
        Vector<uint> Add(Vector<uint> left, Vector<uint> right);

        /// <summary>
        /// Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
        /// Mnemonic: <c>rt[i] := left[i] + right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to add with <paramref name="right" /> (将会与<paramref name="right" />进行相加的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The sum of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的和).</returns>
        /// <seealso cref="Add_AcceleratedTypes"/>
        /// <seealso cref="Vector.Add{T}(Vector{T}, Vector{T})"/> // Since: .NET 7
        Vector<long> Add(Vector<long> left, Vector<long> right);

        /// <summary>
        /// Adds two vectors to compute their sum (将两个向量相加来计算它们的和).
        /// Mnemonic: <c>rt[i] := left[i] + right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to add with <paramref name="right" /> (将会与<paramref name="right" />进行相加的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The sum of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的和).</returns>
        /// <seealso cref="Add_AcceleratedTypes"/>
        /// <seealso cref="Vector.Add{T}(Vector{T}, Vector{T})"/> // Since: .NET 7
        Vector<ulong> Add(Vector<ulong> left, Vector<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>Dot</c> (运行 <c>Dot</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Dot(Vector{byte}, Vector{byte})"/>
        TypeCodeFlags Dot_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the dot product of two vectors (计算两个向量的点积).
        /// Mnemonic: <c>rt := left[0]*right[0] + left[1]*right[1] + left[2]*right[2] + ... + left[Count-1]*right[Count-1]</c>.
        /// </summary>
        /// <param name="left">The vector that will be dotted with <paramref name="right" /> (将会与<paramref name="right" />进行点积的向量).</param>
        /// <param name="right">The vector that will be dotted with <paramref name="left" /> (将会与<paramref name="left" />进行点积的向量).</param>
        /// <returns>The dot product of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的点积).</returns>
        /// <seealso cref="Dot_AcceleratedTypes"/>
        /// <seealso cref="Vector.Dot{T}(Vector{T}, Vector{T})"/>
        float Dot(Vector<float> left, Vector<float> right);

        /// <summary>
        /// Computes the dot product of two vectors (计算两个向量的点积).
        /// Mnemonic: <c>rt := left[0]*right[0] + left[1]*right[1] + left[2]*right[2] + ... + left[Count-1]*right[Count-1]</c>.
        /// </summary>
        /// <param name="left">The vector that will be dotted with <paramref name="right" /> (将会与<paramref name="right" />进行点积的向量).</param>
        /// <param name="right">The vector that will be dotted with <paramref name="left" /> (将会与<paramref name="left" />进行点积的向量).</param>
        /// <returns>The dot product of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的点积).</returns>
        /// <seealso cref="Dot_AcceleratedTypes"/>
        /// <seealso cref="Vector.Dot{T}(Vector{T}, Vector{T})"/>
        double Dot(Vector<double> left, Vector<double> right);

        /// <summary>
        /// Computes the dot product of two vectors (计算两个向量的点积).
        /// Mnemonic: <c>rt := left[0]*right[0] + left[1]*right[1] + left[2]*right[2] + ... + left[Count-1]*right[Count-1]</c>.
        /// </summary>
        /// <param name="left">The vector that will be dotted with <paramref name="right" /> (将会与<paramref name="right" />进行点积的向量).</param>
        /// <param name="right">The vector that will be dotted with <paramref name="left" /> (将会与<paramref name="left" />进行点积的向量).</param>
        /// <returns>The dot product of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的点积).</returns>
        /// <seealso cref="Dot_AcceleratedTypes"/>
        /// <seealso cref="Vector.Dot{T}(Vector{T}, Vector{T})"/>
        sbyte Dot(Vector<sbyte> left, Vector<sbyte> right);

        /// <summary>
        /// Computes the dot product of two vectors (计算两个向量的点积).
        /// Mnemonic: <c>rt := left[0]*right[0] + left[1]*right[1] + left[2]*right[2] + ... + left[Count-1]*right[Count-1]</c>.
        /// </summary>
        /// <param name="left">The vector that will be dotted with <paramref name="right" /> (将会与<paramref name="right" />进行点积的向量).</param>
        /// <param name="right">The vector that will be dotted with <paramref name="left" /> (将会与<paramref name="left" />进行点积的向量).</param>
        /// <returns>The dot product of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的点积).</returns>
        /// <seealso cref="Dot_AcceleratedTypes"/>
        /// <seealso cref="Vector.Dot{T}(Vector{T}, Vector{T})"/>
        byte Dot(Vector<byte> left, Vector<byte> right);

        /// <summary>
        /// Computes the dot product of two vectors (计算两个向量的点积).
        /// Mnemonic: <c>rt := left[0]*right[0] + left[1]*right[1] + left[2]*right[2] + ... + left[Count-1]*right[Count-1]</c>.
        /// </summary>
        /// <param name="left">The vector that will be dotted with <paramref name="right" /> (将会与<paramref name="right" />进行点积的向量).</param>
        /// <param name="right">The vector that will be dotted with <paramref name="left" /> (将会与<paramref name="left" />进行点积的向量).</param>
        /// <returns>The dot product of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的点积).</returns>
        /// <seealso cref="Dot_AcceleratedTypes"/>
        /// <seealso cref="Vector.Dot{T}(Vector{T}, Vector{T})"/>
        short Dot(Vector<short> left, Vector<short> right);

        /// <summary>
        /// Computes the dot product of two vectors (计算两个向量的点积).
        /// Mnemonic: <c>rt := left[0]*right[0] + left[1]*right[1] + left[2]*right[2] + ... + left[Count-1]*right[Count-1]</c>.
        /// </summary>
        /// <param name="left">The vector that will be dotted with <paramref name="right" /> (将会与<paramref name="right" />进行点积的向量).</param>
        /// <param name="right">The vector that will be dotted with <paramref name="left" /> (将会与<paramref name="left" />进行点积的向量).</param>
        /// <returns>The dot product of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的点积).</returns>
        /// <seealso cref="Dot_AcceleratedTypes"/>
        /// <seealso cref="Vector.Dot{T}(Vector{T}, Vector{T})"/>
        ushort Dot(Vector<ushort> left, Vector<ushort> right);

        /// <summary>
        /// Computes the dot product of two vectors (计算两个向量的点积).
        /// Mnemonic: <c>rt := left[0]*right[0] + left[1]*right[1] + left[2]*right[2] + ... + left[Count-1]*right[Count-1]</c>.
        /// </summary>
        /// <param name="left">The vector that will be dotted with <paramref name="right" /> (将会与<paramref name="right" />进行点积的向量).</param>
        /// <param name="right">The vector that will be dotted with <paramref name="left" /> (将会与<paramref name="left" />进行点积的向量).</param>
        /// <returns>The dot product of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的点积).</returns>
        /// <seealso cref="Dot_AcceleratedTypes"/>
        /// <seealso cref="Vector.Dot{T}(Vector{T}, Vector{T})"/>
        int Dot(Vector<int> left, Vector<int> right);

        /// <summary>
        /// Computes the dot product of two vectors (计算两个向量的点积).
        /// Mnemonic: <c>rt := left[0]*right[0] + left[1]*right[1] + left[2]*right[2] + ... + left[Count-1]*right[Count-1]</c>.
        /// </summary>
        /// <param name="left">The vector that will be dotted with <paramref name="right" /> (将会与<paramref name="right" />进行点积的向量).</param>
        /// <param name="right">The vector that will be dotted with <paramref name="left" /> (将会与<paramref name="left" />进行点积的向量).</param>
        /// <returns>The dot product of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的点积).</returns>
        /// <seealso cref="Dot_AcceleratedTypes"/>
        /// <seealso cref="Vector.Dot{T}(Vector{T}, Vector{T})"/>
        uint Dot(Vector<uint> left, Vector<uint> right);

        /// <summary>
        /// Computes the dot product of two vectors (计算两个向量的点积).
        /// Mnemonic: <c>rt := left[0]*right[0] + left[1]*right[1] + left[2]*right[2] + ... + left[Count-1]*right[Count-1]</c>.
        /// </summary>
        /// <param name="left">The vector that will be dotted with <paramref name="right" /> (将会与<paramref name="right" />进行点积的向量).</param>
        /// <param name="right">The vector that will be dotted with <paramref name="left" /> (将会与<paramref name="left" />进行点积的向量).</param>
        /// <returns>The dot product of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的点积).</returns>
        /// <seealso cref="Dot_AcceleratedTypes"/>
        /// <seealso cref="Vector.Dot{T}(Vector{T}, Vector{T})"/>
        long Dot(Vector<long> left, Vector<long> right);

        /// <summary>
        /// Computes the dot product of two vectors (计算两个向量的点积).
        /// Mnemonic: <c>rt := left[0]*right[0] + left[1]*right[1] + left[2]*right[2] + ... + left[Count-1]*right[Count-1]</c>.
        /// </summary>
        /// <param name="left">The vector that will be dotted with <paramref name="right" /> (将会与<paramref name="right" />进行点积的向量).</param>
        /// <param name="right">The vector that will be dotted with <paramref name="left" /> (将会与<paramref name="left" />进行点积的向量).</param>
        /// <returns>The dot product of <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的点积).</returns>
        /// <seealso cref="Dot_AcceleratedTypes"/>
        /// <seealso cref="Vector.Dot{T}(Vector{T}, Vector{T})"/>
        ulong Dot(Vector<ulong> left, Vector<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>Multiply</c> (运行 <c>Multiply</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Multiply(Vector{byte}, Vector{byte})"/>
        /// <seealso cref="Multiply_FullAcceleratedTypes"/>
        TypeCodeFlags Multiply_AcceleratedTypes { get; }

        /// <summary>
        /// Types with full hardware acceleration when running <c>Multiply</c> (运行 <c>Multiply</c> 时具有完全硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>`AcceleratedTypes` only indicates the presence of hardware acceleration, possibly indirectly through some algorithm. And `FullAcceleratedTypes` means that dedicated instructions are used to achieve full hardware acceleration. (`AcceleratedTypes`仅表示存在硬件加速,有可能是通过一些算法间接实现的. 而 `FullAcceleratedTypes`意味着使用了专用指令，实现了完全的硬件加速)</para>
        /// </remarks>
        /// <seealso cref="Multiply(Vector{byte}, Vector{byte})"/>
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
        /// <seealso cref="Vector.Multiply{T}(Vector{T}, Vector{T})"/>
        Vector<float> Multiply(Vector<float> left, Vector<float> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们各元素的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector.Multiply{T}(Vector{T}, Vector{T})"/>
        Vector<double> Multiply(Vector<double> left, Vector<double> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们各元素的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector.Multiply{T}(Vector{T}, Vector{T})"/>
        Vector<sbyte> Multiply(Vector<sbyte> left, Vector<sbyte> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们各元素的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector.Multiply{T}(Vector{T}, Vector{T})"/>
        Vector<byte> Multiply(Vector<byte> left, Vector<byte> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们各元素的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector.Multiply{T}(Vector{T}, Vector{T})"/>
        Vector<short> Multiply(Vector<short> left, Vector<short> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们各元素的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector.Multiply{T}(Vector{T}, Vector{T})"/>
        Vector<ushort> Multiply(Vector<ushort> left, Vector<ushort> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们各元素的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector.Multiply{T}(Vector{T}, Vector{T})"/>
        Vector<int> Multiply(Vector<int> left, Vector<int> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们各元素的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector.Multiply{T}(Vector{T}, Vector{T})"/>
        Vector<uint> Multiply(Vector<uint> left, Vector<uint> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们各元素的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector.Multiply{T}(Vector{T}, Vector{T})"/>
        Vector<long> Multiply(Vector<long> left, Vector<long> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们各元素的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector.Multiply{T}(Vector{T}, Vector{T})"/>
        Vector<ulong> Multiply(Vector<ulong> left, Vector<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>Sqrt</c> (运行 <c>Sqrt</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Sqrt(Vector{double})"/>
        /// <seealso cref="BitMath.Sqrt(double)"/>
        TypeCodeFlags Sqrt_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the square root of a vector on a per-element basis (计算向量中每个元素的平方根).
        /// Mnemonic: <c>rt[i] := sqrt(vector[i]) = pow(vector[i], 1.0/2)</c>. When x is less than 0, floating-point types return NaN, integer types return 0.
        /// </summary>
        /// <param name="vector">The vector whose square root is to be computed (将被计算其平方根的向量).</param>
        /// <returns>A vector whose elements are the square root of the corresponding elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中对应元素的平方根).</returns>
        /// <seealso cref="Sqrt_AcceleratedTypes"/>
        /// <seealso cref="Vector.SquareRoot{T}(Vector{T})" />
        Vector<float> Sqrt(Vector<float> vector);

        /// <summary>
        /// Computes the square root of a vector on a per-element basis (计算向量中每个元素的平方根).
        /// Mnemonic: <c>rt[i] := sqrt(vector[i]) = pow(vector[i], 1.0/2)</c>. When x is less than 0, floating-point types return NaN, integer types return 0.
        /// </summary>
        /// <param name="vector">The vector whose square root is to be computed (将被计算其平方根的向量).</param>
        /// <returns>A vector whose elements are the square root of the corresponding elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中对应元素的平方根).</returns>
        /// <seealso cref="Sqrt_AcceleratedTypes"/>
        /// <seealso cref="Vector.SquareRoot{T}(Vector{T})" />
        Vector<double> Sqrt(Vector<double> vector);

        /// <summary>
        /// Computes the square root of a vector on a per-element basis (计算向量中每个元素的平方根).
        /// Mnemonic: <c>rt[i] := sqrt(vector[i]) = pow(vector[i], 1.0/2)</c>. When x is less than 0, floating-point types return NaN, integer types return 0.
        /// </summary>
        /// <param name="vector">The vector whose square root is to be computed (将被计算其平方根的向量).</param>
        /// <returns>A vector whose elements are the square root of the corresponding elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中对应元素的平方根).</returns>
        /// <seealso cref="Sqrt_AcceleratedTypes"/>
        /// <seealso cref="Vector.SquareRoot{T}(Vector{T})" />
        Vector<sbyte> Sqrt(Vector<sbyte> vector);

        /// <summary>
        /// Computes the square root of a vector on a per-element basis (计算向量中每个元素的平方根).
        /// Mnemonic: <c>rt[i] := sqrt(vector[i]) = pow(vector[i], 1.0/2)</c>. When x is less than 0, floating-point types return NaN, integer types return 0.
        /// </summary>
        /// <param name="vector">The vector whose square root is to be computed (将被计算其平方根的向量).</param>
        /// <returns>A vector whose elements are the square root of the corresponding elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中对应元素的平方根).</returns>
        /// <seealso cref="Sqrt_AcceleratedTypes"/>
        /// <seealso cref="Vector.SquareRoot{T}(Vector{T})" />
        Vector<byte> Sqrt(Vector<byte> vector);

        /// <summary>
        /// Computes the square root of a vector on a per-element basis (计算向量中每个元素的平方根).
        /// Mnemonic: <c>rt[i] := sqrt(vector[i]) = pow(vector[i], 1.0/2)</c>. When x is less than 0, floating-point types return NaN, integer types return 0.
        /// </summary>
        /// <param name="vector">The vector whose square root is to be computed (将被计算其平方根的向量).</param>
        /// <returns>A vector whose elements are the square root of the corresponding elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中对应元素的平方根).</returns>
        /// <seealso cref="Sqrt_AcceleratedTypes"/>
        /// <seealso cref="Vector.SquareRoot{T}(Vector{T})" />
        Vector<short> Sqrt(Vector<short> vector);

        /// <summary>
        /// Computes the square root of a vector on a per-element basis (计算向量中每个元素的平方根).
        /// Mnemonic: <c>rt[i] := sqrt(vector[i]) = pow(vector[i], 1.0/2)</c>. When x is less than 0, floating-point types return NaN, integer types return 0.
        /// </summary>
        /// <param name="vector">The vector whose square root is to be computed (将被计算其平方根的向量).</param>
        /// <returns>A vector whose elements are the square root of the corresponding elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中对应元素的平方根).</returns>
        /// <seealso cref="Sqrt_AcceleratedTypes"/>
        /// <seealso cref="Vector.SquareRoot{T}(Vector{T})" />
        Vector<ushort> Sqrt(Vector<ushort> vector);

        /// <summary>
        /// Computes the square root of a vector on a per-element basis (计算向量中每个元素的平方根).
        /// Mnemonic: <c>rt[i] := sqrt(vector[i]) = pow(vector[i], 1.0/2)</c>. When x is less than 0, floating-point types return NaN, integer types return 0.
        /// </summary>
        /// <param name="vector">The vector whose square root is to be computed (将被计算其平方根的向量).</param>
        /// <returns>A vector whose elements are the square root of the corresponding elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中对应元素的平方根).</returns>
        /// <seealso cref="Sqrt_AcceleratedTypes"/>
        /// <seealso cref="Vector.SquareRoot{T}(Vector{T})" />
        Vector<int> Sqrt(Vector<int> vector);

        /// <summary>
        /// Computes the square root of a vector on a per-element basis (计算向量中每个元素的平方根).
        /// Mnemonic: <c>rt[i] := sqrt(vector[i]) = pow(vector[i], 1.0/2)</c>. When x is less than 0, floating-point types return NaN, integer types return 0.
        /// </summary>
        /// <param name="vector">The vector whose square root is to be computed (将被计算其平方根的向量).</param>
        /// <returns>A vector whose elements are the square root of the corresponding elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中对应元素的平方根).</returns>
        /// <seealso cref="Sqrt_AcceleratedTypes"/>
        /// <seealso cref="Vector.SquareRoot{T}(Vector{T})" />
        Vector<uint> Sqrt(Vector<uint> vector);

        /// <summary>
        /// Computes the square root of a vector on a per-element basis (计算向量中每个元素的平方根).
        /// Mnemonic: <c>rt[i] := sqrt(vector[i]) = pow(vector[i], 1.0/2)</c>. When x is less than 0, floating-point types return NaN, integer types return 0.
        /// </summary>
        /// <param name="vector">The vector whose square root is to be computed (将被计算其平方根的向量).</param>
        /// <returns>A vector whose elements are the square root of the corresponding elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中对应元素的平方根).</returns>
        /// <seealso cref="Sqrt_AcceleratedTypes"/>
        /// <seealso cref="Vector.SquareRoot{T}(Vector{T})" />
        Vector<long> Sqrt(Vector<long> vector);

        /// <summary>
        /// Computes the square root of a vector on a per-element basis (计算向量中每个元素的平方根).
        /// Mnemonic: <c>rt[i] := sqrt(vector[i]) = pow(vector[i], 1.0/2)</c>. When x is less than 0, floating-point types return NaN, integer types return 0.
        /// </summary>
        /// <param name="vector">The vector whose square root is to be computed (将被计算其平方根的向量).</param>
        /// <returns>A vector whose elements are the square root of the corresponding elements in <paramref name="vector" /> (一个向量，其元素是 <paramref name="vector" /> 中对应元素的平方根).</returns>
        /// <seealso cref="Sqrt_AcceleratedTypes"/>
        /// <seealso cref="Vector.SquareRoot{T}(Vector{T})" />
        Vector<ulong> Sqrt(Vector<ulong> vector);

    }
}
