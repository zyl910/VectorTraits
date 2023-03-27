using System;
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
        /// Mnemonic: <c>rt[i] := ceiling(value[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its ceiling computed (将计算向上舍入的向量).</param>
        /// <returns>A vector whose elements are the ceiling of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的向上舍入).</returns>
        /// <seealso cref="Ceiling_AcceleratedTypes"/>
        /// <seealso cref="Vector.Ceiling(Vector{float})" />
        Vector<float> Ceiling(Vector<float> value);

        /// <summary>
        /// Computes the ceiling of each element in a vector (计算向量中每个元素的向上舍入).
        /// Mnemonic: <c>rt[i] := ceiling(value[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its ceiling computed (将计算向上舍入的向量).</param>
        /// <returns>A vector whose elements are the ceiling of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的向上舍入).</returns>
        /// <seealso cref="Ceiling_AcceleratedTypes"/>
        /// <seealso cref="Vector.Ceiling(Vector{double})" />
        Vector<double> Ceiling(Vector<double> value);


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
        /// <seealso cref="Vector.ConvertToDouble(Vector{long})" />
        Vector<double> ConvertToDouble(Vector<long> value);

        /// <summary>
        /// Convert to a vector whose elements are of type Double (转换为元素类型是Double的向量)..
        /// Mnemonic: <c>rt[i] := (Double)(value[i])</c>.
        /// </summary>
        /// <param name="value">The source vector (源向量).</param>
        /// <returns>The converted vector (转换后的向量).</returns>
        /// <seealso cref="ConvertToDouble_AcceleratedTypes"/>
        /// <seealso cref="Vector.ConvertToDouble(Vector{ulong})" />
        Vector<double> ConvertToDouble(Vector<ulong> value);


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
        /// <seealso cref="Vector.ConvertToInt32(Vector{float})" />
        Vector<int> ConvertToInt32(Vector<float> value);


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
        /// <seealso cref="Vector.ConvertToInt64(Vector{long})" />
        Vector<long> ConvertToInt64(Vector<double> value);


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
        /// <seealso cref="Vector.ConvertToSingle(Vector{int})" />
        Vector<float> ConvertToSingle(Vector<int> value);

        /// <summary>
        /// Convert to a vector whose elements are of type Single (转换为元素类型是Single的向量)..
        /// Mnemonic: <c>rt[i] := (Single)(value[i])</c>.
        /// </summary>
        /// <param name="value">The source vector (源向量).</param>
        /// <returns>The converted vector (转换后的向量).</returns>
        /// <seealso cref="ConvertToSingle_AcceleratedTypes"/>
        /// <seealso cref="Vector.ConvertToSingle(Vector{uint})" />
        Vector<float> ConvertToSingle(Vector<uint> value);


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
        /// <seealso cref="Vector.ConvertToUInt32(Vector{float})" />
        Vector<uint> ConvertToUInt32(Vector<float> value);


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
        /// <seealso cref="Vector.ConvertToUInt64(Vector{double})" />
        Vector<ulong> ConvertToUInt64(Vector<double> value);


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
        /// <seealso cref="Vector.ExtractMostSignificantBits{T}(Vector{T})" />
        ulong ExtractMostSignificantBits(Vector<float> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector.ExtractMostSignificantBits{T}(Vector{T})" />
        ulong ExtractMostSignificantBits(Vector<double> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector.ExtractMostSignificantBits{T}(Vector{T})" />
        ulong ExtractMostSignificantBits(Vector<sbyte> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector.ExtractMostSignificantBits{T}(Vector{T})" />
        ulong ExtractMostSignificantBits(Vector<byte> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector.ExtractMostSignificantBits{T}(Vector{T})" />
        ulong ExtractMostSignificantBits(Vector<short> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector.ExtractMostSignificantBits{T}(Vector{T})" />
        ulong ExtractMostSignificantBits(Vector<ushort> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector.ExtractMostSignificantBits{T}(Vector{T})" />
        ulong ExtractMostSignificantBits(Vector<int> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector.ExtractMostSignificantBits{T}(Vector{T})" />
        ulong ExtractMostSignificantBits(Vector<uint> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector.ExtractMostSignificantBits{T}(Vector{T})" />
        ulong ExtractMostSignificantBits(Vector<long> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector.ExtractMostSignificantBits{T}(Vector{T})" />
        ulong ExtractMostSignificantBits(Vector<ulong> vector);


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
        /// <seealso cref="Vector.Floor(Vector{float})" />
        Vector<float> Floor(Vector<float> value);

        /// <summary>
        /// Computes the floor of each element in a vector (计算向量中每个元素的向下舍入).
        /// Mnemonic: <c>rt[i] := floor(value[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its floor computed (将计算向下舍入的向量).</param>
        /// <returns>A vector whose elements are the floor of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的向下舍入).</returns>
        /// <seealso cref="Floor_AcceleratedTypes"/>
        /// <seealso cref="Vector.Floor(Vector{double})" />
        Vector<double> Floor(Vector<double> value);


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
        /// <seealso cref="Vector.Multiply{T}(Vector{T}, Vector{T})"/>
        Vector<float> Multiply(Vector<float> left, Vector<float> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector.Multiply{T}(Vector{T}, Vector{T})"/>
        Vector<double> Multiply(Vector<double> left, Vector<double> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector.Multiply{T}(Vector{T}, Vector{T})"/>
        Vector<sbyte> Multiply(Vector<sbyte> left, Vector<sbyte> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector.Multiply{T}(Vector{T}, Vector{T})"/>
        Vector<byte> Multiply(Vector<byte> left, Vector<byte> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector.Multiply{T}(Vector{T}, Vector{T})"/>
        Vector<short> Multiply(Vector<short> left, Vector<short> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector.Multiply{T}(Vector{T}, Vector{T})"/>
        Vector<ushort> Multiply(Vector<ushort> left, Vector<ushort> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector.Multiply{T}(Vector{T}, Vector{T})"/>
        Vector<int> Multiply(Vector<int> left, Vector<int> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector.Multiply{T}(Vector{T}, Vector{T})"/>
        Vector<uint> Multiply(Vector<uint> left, Vector<uint> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector.Multiply{T}(Vector{T}, Vector{T})"/>
        Vector<long> Multiply(Vector<long> left, Vector<long> right);

        /// <summary>
        /// Multiplies two vectors to compute their element-wise product (将两个向量相乘来计算它们的积).
        /// Mnemonic: <c>rt[i] := left[i] * right[i]</c>.
        /// </summary>
        /// <param name="left">The vector to multiply with <paramref name="right" /> (将会与<paramref name="right" />进行相乘的向量).</param>
        /// <param name="right">The vector to add with <paramref name="left" /> (将会与<paramref name="left" />进行相加的向量).</param>
        /// <returns>The element-wise product of  <paramref name="left" /> and <paramref name="right" /> (<paramref name="left" /> 与 <paramref name="right" />的各元素乘积).</returns>
        /// <seealso cref="Multiply_AcceleratedTypes"/>
        /// <seealso cref="Vector.Multiply{T}(Vector{T}, Vector{T})"/>
        Vector<ulong> Multiply(Vector<ulong> left, Vector<ulong> right);


        /// <summary>
        /// Types with hardware acceleration when running <c>Narrow</c> (运行 <c>Narrow</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Narrow"/>
        TypeCodeFlags Narrow_AcceleratedTypes { get; }

        /// <summary>
        /// Narrows two <seealso cref="Vector{T}"/> instances into one <seealso cref="Vector{T}"/>"  (将两个 <seealso cref="Vector{T}"/> 实例缩窄为一个 <seealso cref="Vector{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow(element_ref(i, lower, upper))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="Narrow_AcceleratedTypes"/>
        /// <seealso cref="Vector.Narrow(Vector{double}, Vector{double})" />
        Vector<float> Narrow(Vector<double> lower, Vector<double> upper);

        /// <summary>
        /// Narrows two <seealso cref="Vector{T}"/> instances into one <seealso cref="Vector{T}"/>"  (将两个 <seealso cref="Vector{T}"/> 实例缩窄为一个 <seealso cref="Vector{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow(element_ref(i, lower, upper))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="Narrow_AcceleratedTypes"/>
        /// <seealso cref="Vector.Narrow(Vector{short}, Vector{short})" />
        Vector<sbyte> Narrow(Vector<short> lower, Vector<short> upper);

        /// <summary>
        /// Narrows two <seealso cref="Vector{T}"/> instances into one <seealso cref="Vector{T}"/>"  (将两个 <seealso cref="Vector{T}"/> 实例缩窄为一个 <seealso cref="Vector{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow(element_ref(i, lower, upper))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="Narrow_AcceleratedTypes"/>
        /// <seealso cref="Vector.Narrow(Vector{ushort}, Vector{ushort})" />
        Vector<byte> Narrow(Vector<ushort> lower, Vector<ushort> upper);

        /// <summary>
        /// Narrows two <seealso cref="Vector{T}"/> instances into one <seealso cref="Vector{T}"/>"  (将两个 <seealso cref="Vector{T}"/> 实例缩窄为一个 <seealso cref="Vector{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow(element_ref(i, lower, upper))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="Narrow_AcceleratedTypes"/>
        /// <seealso cref="Vector.Narrow(Vector{int}, Vector{int})" />
        Vector<short> Narrow(Vector<int> lower, Vector<int> upper);

        /// <summary>
        /// Narrows two <seealso cref="Vector{T}"/> instances into one <seealso cref="Vector{T}"/>"  (将两个 <seealso cref="Vector{T}"/> 实例缩窄为一个 <seealso cref="Vector{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow(element_ref(i, lower, upper))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="Narrow_AcceleratedTypes"/>
        /// <seealso cref="Vector.Narrow(Vector{uint}, Vector{uint})" />
        Vector<ushort> Narrow(Vector<uint> lower, Vector<uint> upper);

        /// <summary>
        /// Narrows two <seealso cref="Vector{T}"/> instances into one <seealso cref="Vector{T}"/>"  (将两个 <seealso cref="Vector{T}"/> 实例缩窄为一个 <seealso cref="Vector{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow(element_ref(i, lower, upper))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="Narrow_AcceleratedTypes"/>
        /// <seealso cref="Vector.Narrow(Vector{long}, Vector{long})" />
        Vector<int> Narrow(Vector<long> lower, Vector<long> upper);

        /// <summary>
        /// Narrows two <seealso cref="Vector{T}"/> instances into one <seealso cref="Vector{T}"/>"  (将两个 <seealso cref="Vector{T}"/> 实例缩窄为一个 <seealso cref="Vector{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow(element_ref(i, lower, upper))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="Narrow_AcceleratedTypes"/>
        /// <seealso cref="Vector.Narrow(Vector{ulong}, Vector{ulong})" />
        Vector<uint> Narrow(Vector<ulong> lower, Vector<ulong> upper);


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
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
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
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
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
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
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
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
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
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
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
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
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
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
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
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
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
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
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
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
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
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
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
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
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
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
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
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
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
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
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
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
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
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
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
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
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
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
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
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
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
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
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
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
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
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
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
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
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
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
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
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
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
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
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
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
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
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
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
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
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
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
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
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
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
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
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
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
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
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
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
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
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
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
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
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
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
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
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
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted righ by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{ulong}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector{ulong}, int)"/> // Since: VectorTraits 1.0
        Vector<ulong> ShiftRightLogicalFast(Vector<ulong> value, int shiftAmount);


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
        /// <seealso cref="Vector.Sum{T}(Vector{T})" />
        float Sum(Vector<float> value);

        /// <summary>
        /// Computes the sum of all elements in a vector (计算向量中所有元素的总和).
        /// Mnemonic: <c>rt := value[0] + value[1] + value[2] + ... + value[Count-1]</c>.
        /// </summary>
        /// <param name="value">The vector whose elements will be summed (将对其元素求和的向量).</param>
        /// <returns>The sum of all elements in <paramref name="value" /> (<paramref name="value" /> 中所有元素的总和).</returns>
        /// <seealso cref="Sum_AcceleratedTypes"/>
        /// <seealso cref="Vector.Sum{T}(Vector{T})" />
        double Sum(Vector<double> value);

        /// <summary>
        /// Computes the sum of all elements in a vector (计算向量中所有元素的总和).
        /// Mnemonic: <c>rt := value[0] + value[1] + value[2] + ... + value[Count-1]</c>.
        /// </summary>
        /// <param name="value">The vector whose elements will be summed (将对其元素求和的向量).</param>
        /// <returns>The sum of all elements in <paramref name="value" /> (<paramref name="value" /> 中所有元素的总和).</returns>
        /// <seealso cref="Sum_AcceleratedTypes"/>
        /// <seealso cref="Vector.Sum{T}(Vector{T})" />
        sbyte Sum(Vector<sbyte> value);

        /// <summary>
        /// Computes the sum of all elements in a vector (计算向量中所有元素的总和).
        /// Mnemonic: <c>rt := value[0] + value[1] + value[2] + ... + value[Count-1]</c>.
        /// </summary>
        /// <param name="value">The vector whose elements will be summed (将对其元素求和的向量).</param>
        /// <returns>The sum of all elements in <paramref name="value" /> (<paramref name="value" /> 中所有元素的总和).</returns>
        /// <seealso cref="Sum_AcceleratedTypes"/>
        /// <seealso cref="Vector.Sum{T}(Vector{T})" />
        byte Sum(Vector<byte> value);

        /// <summary>
        /// Computes the sum of all elements in a vector (计算向量中所有元素的总和).
        /// Mnemonic: <c>rt := value[0] + value[1] + value[2] + ... + value[Count-1]</c>.
        /// </summary>
        /// <param name="value">The vector whose elements will be summed (将对其元素求和的向量).</param>
        /// <returns>The sum of all elements in <paramref name="value" /> (<paramref name="value" /> 中所有元素的总和).</returns>
        /// <seealso cref="Sum_AcceleratedTypes"/>
        /// <seealso cref="Vector.Sum{T}(Vector{T})" />
        short Sum(Vector<short> value);

        /// <summary>
        /// Computes the sum of all elements in a vector (计算向量中所有元素的总和).
        /// Mnemonic: <c>rt := value[0] + value[1] + value[2] + ... + value[Count-1]</c>.
        /// </summary>
        /// <param name="value">The vector whose elements will be summed (将对其元素求和的向量).</param>
        /// <returns>The sum of all elements in <paramref name="value" /> (<paramref name="value" /> 中所有元素的总和).</returns>
        /// <seealso cref="Sum_AcceleratedTypes"/>
        /// <seealso cref="Vector.Sum{T}(Vector{T})" />
        ushort Sum(Vector<ushort> value);

        /// <summary>
        /// Computes the sum of all elements in a vector (计算向量中所有元素的总和).
        /// Mnemonic: <c>rt := value[0] + value[1] + value[2] + ... + value[Count-1]</c>.
        /// </summary>
        /// <param name="value">The vector whose elements will be summed (将对其元素求和的向量).</param>
        /// <returns>The sum of all elements in <paramref name="value" /> (<paramref name="value" /> 中所有元素的总和).</returns>
        /// <seealso cref="Sum_AcceleratedTypes"/>
        /// <seealso cref="Vector.Sum{T}(Vector{T})" />
        int Sum(Vector<int> value);

        /// <summary>
        /// Computes the sum of all elements in a vector (计算向量中所有元素的总和).
        /// Mnemonic: <c>rt := value[0] + value[1] + value[2] + ... + value[Count-1]</c>.
        /// </summary>
        /// <param name="value">The vector whose elements will be summed (将对其元素求和的向量).</param>
        /// <returns>The sum of all elements in <paramref name="value" /> (<paramref name="value" /> 中所有元素的总和).</returns>
        /// <seealso cref="Sum_AcceleratedTypes"/>
        /// <seealso cref="Vector.Sum{T}(Vector{T})" />
        uint Sum(Vector<uint> value);

        /// <summary>
        /// Computes the sum of all elements in a vector (计算向量中所有元素的总和).
        /// Mnemonic: <c>rt := value[0] + value[1] + value[2] + ... + value[Count-1]</c>.
        /// </summary>
        /// <param name="value">The vector whose elements will be summed (将对其元素求和的向量).</param>
        /// <returns>The sum of all elements in <paramref name="value" /> (<paramref name="value" /> 中所有元素的总和).</returns>
        /// <seealso cref="Sum_AcceleratedTypes"/>
        /// <seealso cref="Vector.Sum{T}(Vector{T})" />
        long Sum(Vector<long> value);

        /// <summary>
        /// Computes the sum of all elements in a vector (计算向量中所有元素的总和).
        /// Mnemonic: <c>rt := value[0] + value[1] + value[2] + ... + value[Count-1]</c>.
        /// </summary>
        /// <param name="value">The vector whose elements will be summed (将对其元素求和的向量).</param>
        /// <returns>The sum of all elements in <paramref name="value" /> (<paramref name="value" /> 中所有元素的总和).</returns>
        /// <seealso cref="Sum_AcceleratedTypes"/>
        /// <seealso cref="Vector.Sum{T}(Vector{T})" />
        ulong Sum(Vector<ulong> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>Widen</c> (运行 <c>Widen</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Widen"/>
        TypeCodeFlags Widen_AcceleratedTypes { get; }

        /// <summary>
        /// Widens a <seealso cref="Vector{T}"/> into two <seealso cref="Vector{T}"/> instances (将一个 <seealso cref="Vector{T}"/> 扩宽为两个 <seealso cref="Vector{T}"/> 实例).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <param name="lower">When this method returns, contains the widened elements from lower indices in the source vector (当此方法返回时，包含源向量中来自较低下标的扩宽元素).</param>
        /// <param name="upper">When this method returns, contains the widened elements from upper indices in the source vector (当此方法返回时，包含源向量中来自较高下标的扩宽元素).</param>
        /// <seealso cref="Widen_AcceleratedTypes"/>
        /// <seealso cref="Vector.Widen(Vector{float}, out Vector{double}, out Vector{double})" />
        void Widen(Vector<float> source, out Vector<double> lower, out Vector<double> upper);

        /// <summary>
        /// Widens a <seealso cref="Vector{T}"/> into two <seealso cref="Vector{T}"/> instances (将一个 <seealso cref="Vector{T}"/> 扩宽为两个 <seealso cref="Vector{T}"/> 实例).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <param name="lower">When this method returns, contains the widened elements from lower indices in the source vector (当此方法返回时，包含源向量中来自较低下标的扩宽元素).</param>
        /// <param name="upper">When this method returns, contains the widened elements from upper indices in the source vector (当此方法返回时，包含源向量中来自较高下标的扩宽元素).</param>
        /// <seealso cref="Widen_AcceleratedTypes"/>
        /// <seealso cref="Vector.Widen(Vector{sbyte}, out Vector{short}, out Vector{short})" />
        void Widen(Vector<sbyte> source, out Vector<short> lower, out Vector<short> upper);

        /// <summary>
        /// Widens a <seealso cref="Vector{T}"/> into two <seealso cref="Vector{T}"/> instances (将一个 <seealso cref="Vector{T}"/> 扩宽为两个 <seealso cref="Vector{T}"/> 实例).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <param name="lower">When this method returns, contains the widened elements from lower indices in the source vector (当此方法返回时，包含源向量中来自较低下标的扩宽元素).</param>
        /// <param name="upper">When this method returns, contains the widened elements from upper indices in the source vector (当此方法返回时，包含源向量中来自较高下标的扩宽元素).</param>
        /// <seealso cref="Widen_AcceleratedTypes"/>
        /// <seealso cref="Vector.Widen(Vector{byte}, out Vector{ushort}, out Vector{ushort})" />
        void Widen(Vector<byte> source, out Vector<ushort> lower, out Vector<ushort> upper);

        /// <summary>
        /// Widens a <seealso cref="Vector{T}"/> into two <seealso cref="Vector{T}"/> instances (将一个 <seealso cref="Vector{T}"/> 扩宽为两个 <seealso cref="Vector{T}"/> 实例).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <param name="lower">When this method returns, contains the widened elements from lower indices in the source vector (当此方法返回时，包含源向量中来自较低下标的扩宽元素).</param>
        /// <param name="upper">When this method returns, contains the widened elements from upper indices in the source vector (当此方法返回时，包含源向量中来自较高下标的扩宽元素).</param>
        /// <seealso cref="Widen_AcceleratedTypes"/>
        /// <seealso cref="Vector.Widen(Vector{short}, out Vector{int}, out Vector{int})" />
        void Widen(Vector<short> source, out Vector<int> lower, out Vector<int> upper);

        /// <summary>
        /// Widens a <seealso cref="Vector{T}"/> into two <seealso cref="Vector{T}"/> instances (将一个 <seealso cref="Vector{T}"/> 扩宽为两个 <seealso cref="Vector{T}"/> 实例).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <param name="lower">When this method returns, contains the widened elements from lower indices in the source vector (当此方法返回时，包含源向量中来自较低下标的扩宽元素).</param>
        /// <param name="upper">When this method returns, contains the widened elements from upper indices in the source vector (当此方法返回时，包含源向量中来自较高下标的扩宽元素).</param>
        /// <seealso cref="Widen_AcceleratedTypes"/>
        /// <seealso cref="Vector.Widen(Vector{ushort}, out Vector{uint}, out Vector{uint})" />
        void Widen(Vector<ushort> source, out Vector<uint> lower, out Vector<uint> upper);

        /// <summary>
        /// Widens a <seealso cref="Vector{T}"/> into two <seealso cref="Vector{T}"/> instances (将一个 <seealso cref="Vector{T}"/> 扩宽为两个 <seealso cref="Vector{T}"/> 实例).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <param name="lower">When this method returns, contains the widened elements from lower indices in the source vector (当此方法返回时，包含源向量中来自较低下标的扩宽元素).</param>
        /// <param name="upper">When this method returns, contains the widened elements from upper indices in the source vector (当此方法返回时，包含源向量中来自较高下标的扩宽元素).</param>
        /// <seealso cref="Widen_AcceleratedTypes"/>
        /// <seealso cref="Vector.Widen(Vector{int}, out Vector{long}, out Vector{long})" />
        void Widen(Vector<int> source, out Vector<long> lower, out Vector<long> upper);

        /// <summary>
        /// Widens a <seealso cref="Vector{T}"/> into two <seealso cref="Vector{T}"/> instances (将一个 <seealso cref="Vector{T}"/> 扩宽为两个 <seealso cref="Vector{T}"/> 实例).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <param name="lower">When this method returns, contains the widened elements from lower indices in the source vector (当此方法返回时，包含源向量中来自较低下标的扩宽元素).</param>
        /// <param name="upper">When this method returns, contains the widened elements from upper indices in the source vector (当此方法返回时，包含源向量中来自较高下标的扩宽元素).</param>
        /// <seealso cref="Widen_AcceleratedTypes"/>
        /// <seealso cref="Vector.Widen(Vector{uint}, out Vector{ulong}, out Vector{ulong})" />
        void Widen(Vector<uint> source, out Vector<ulong> lower, out Vector<ulong> upper);

        #endregion // .NET_style

        // == mY style  ==
        #region mY_style

        /// <summary>
        /// Types with hardware acceleration when running <c>YClamp</c> (运行 <c>YClamp</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YClamp"/>
        TypeCodeFlags YClamp_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the numerical clamp of each element in a vector (计算向量中每个元素的数值限制).
        /// Mnemonic: <c>rt[i] := clamp(value[i], amin[i], amax[i]) = min(max(amin[i], value[i]), amax[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its clamp computed (将计算限制的向量).</param>
        /// <param name="amin">The lower bound of the value (值的下限).</param>
        /// <param name="amax">The upper bound of the value (值的上限).</param>
        /// <returns>A vector whose elements are the clamped to the inclusive range of <paramref name="amin" /> and <paramref name="amax" /> (一个向量，其元素是 限制在 <paramref name="amin" /> 和 <paramref name="amax" /> 范围内的).</returns>
        /// <seealso cref="YClamp_AcceleratedTypes"/>
        /// <seealso cref="BitMath.Clamp(float, float, float)"/>
        Vector<float> YClamp(Vector<float> value, Vector<float> amin, Vector<float> amax);

        /// <summary>
        /// Computes the numerical clamp of each element in a vector (计算向量中每个元素的数值限制).
        /// Mnemonic: <c>rt[i] := clamp(value[i], amin[i], amax[i]) = min(max(amin[i], value[i]), amax[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its clamp computed (将计算限制的向量).</param>
        /// <param name="amin">The lower bound of the value (值的下限).</param>
        /// <param name="amax">The upper bound of the value (值的上限).</param>
        /// <returns>A vector whose elements are the clamped to the inclusive range of <paramref name="amin" /> and <paramref name="amax" /> (一个向量，其元素是 限制在 <paramref name="amin" /> 和 <paramref name="amax" /> 范围内的).</returns>
        /// <seealso cref="YClamp_AcceleratedTypes"/>
        /// <seealso cref="BitMath.Clamp(double, double, double)"/>
        Vector<double> YClamp(Vector<double> value, Vector<double> amin, Vector<double> amax);

        /// <summary>
        /// Computes the numerical clamp of each element in a vector (计算向量中每个元素的数值限制).
        /// Mnemonic: <c>rt[i] := clamp(value[i], amin[i], amax[i]) = min(max(amin[i], value[i]), amax[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its clamp computed (将计算限制的向量).</param>
        /// <param name="amin">The lower bound of the value (值的下限).</param>
        /// <param name="amax">The upper bound of the value (值的上限).</param>
        /// <returns>A vector whose elements are the clamped to the inclusive range of <paramref name="amin" /> and <paramref name="amax" /> (一个向量，其元素是 限制在 <paramref name="amin" /> 和 <paramref name="amax" /> 范围内的).</returns>
        /// <seealso cref="YClamp_AcceleratedTypes"/>
        /// <seealso cref="BitMath.Clamp(sbyte, sbyte, sbyte)"/>
        Vector<sbyte> YClamp(Vector<sbyte> value, Vector<sbyte> amin, Vector<sbyte> amax);

        /// <summary>
        /// Computes the numerical clamp of each element in a vector (计算向量中每个元素的数值限制).
        /// Mnemonic: <c>rt[i] := clamp(value[i], amin[i], amax[i]) = min(max(amin[i], value[i]), amax[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its clamp computed (将计算限制的向量).</param>
        /// <param name="amin">The lower bound of the value (值的下限).</param>
        /// <param name="amax">The upper bound of the value (值的上限).</param>
        /// <returns>A vector whose elements are the clamped to the inclusive range of <paramref name="amin" /> and <paramref name="amax" /> (一个向量，其元素是 限制在 <paramref name="amin" /> 和 <paramref name="amax" /> 范围内的).</returns>
        /// <seealso cref="YClamp_AcceleratedTypes"/>
        /// <seealso cref="BitMath.Clamp(byte, byte, byte)"/>
        Vector<byte> YClamp(Vector<byte> value, Vector<byte> amin, Vector<byte> amax);

        /// <summary>
        /// Computes the numerical clamp of each element in a vector (计算向量中每个元素的数值限制).
        /// Mnemonic: <c>rt[i] := clamp(value[i], amin[i], amax[i]) = min(max(amin[i], value[i]), amax[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its clamp computed (将计算限制的向量).</param>
        /// <param name="amin">The lower bound of the value (值的下限).</param>
        /// <param name="amax">The upper bound of the value (值的上限).</param>
        /// <returns>A vector whose elements are the clamped to the inclusive range of <paramref name="amin" /> and <paramref name="amax" /> (一个向量，其元素是 限制在 <paramref name="amin" /> 和 <paramref name="amax" /> 范围内的).</returns>
        /// <seealso cref="YClamp_AcceleratedTypes"/>
        /// <seealso cref="BitMath.Clamp(short, short, short)"/>
        Vector<short> YClamp(Vector<short> value, Vector<short> amin, Vector<short> amax);

        /// <summary>
        /// Computes the numerical clamp of each element in a vector (计算向量中每个元素的数值限制).
        /// Mnemonic: <c>rt[i] := clamp(value[i], amin[i], amax[i]) = min(max(amin[i], value[i]), amax[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its clamp computed (将计算限制的向量).</param>
        /// <param name="amin">The lower bound of the value (值的下限).</param>
        /// <param name="amax">The upper bound of the value (值的上限).</param>
        /// <returns>A vector whose elements are the clamped to the inclusive range of <paramref name="amin" /> and <paramref name="amax" /> (一个向量，其元素是 限制在 <paramref name="amin" /> 和 <paramref name="amax" /> 范围内的).</returns>
        /// <seealso cref="YClamp_AcceleratedTypes"/>
        /// <seealso cref="BitMath.Clamp(ushort, ushort, ushort)"/>
        Vector<ushort> YClamp(Vector<ushort> value, Vector<ushort> amin, Vector<ushort> amax);

        /// <summary>
        /// Computes the numerical clamp of each element in a vector (计算向量中每个元素的数值限制).
        /// Mnemonic: <c>rt[i] := clamp(value[i], amin[i], amax[i]) = min(max(amin[i], value[i]), amax[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its clamp computed (将计算限制的向量).</param>
        /// <param name="amin">The lower bound of the value (值的下限).</param>
        /// <param name="amax">The upper bound of the value (值的上限).</param>
        /// <returns>A vector whose elements are the clamped to the inclusive range of <paramref name="amin" /> and <paramref name="amax" /> (一个向量，其元素是 限制在 <paramref name="amin" /> 和 <paramref name="amax" /> 范围内的).</returns>
        /// <seealso cref="YClamp_AcceleratedTypes"/>
        /// <seealso cref="BitMath.Clamp(int, int, int)"/>
        Vector<int> YClamp(Vector<int> value, Vector<int> amin, Vector<int> amax);

        /// <summary>
        /// Computes the numerical clamp of each element in a vector (计算向量中每个元素的数值限制).
        /// Mnemonic: <c>rt[i] := clamp(value[i], amin[i], amax[i]) = min(max(amin[i], value[i]), amax[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its clamp computed (将计算限制的向量).</param>
        /// <param name="amin">The lower bound of the value (值的下限).</param>
        /// <param name="amax">The upper bound of the value (值的上限).</param>
        /// <returns>A vector whose elements are the clamped to the inclusive range of <paramref name="amin" /> and <paramref name="amax" /> (一个向量，其元素是 限制在 <paramref name="amin" /> 和 <paramref name="amax" /> 范围内的).</returns>
        /// <seealso cref="YClamp_AcceleratedTypes"/>
        /// <seealso cref="BitMath.Clamp(uint, uint, uint)"/>
        Vector<uint> YClamp(Vector<uint> value, Vector<uint> amin, Vector<uint> amax);

        /// <summary>
        /// Computes the numerical clamp of each element in a vector (计算向量中每个元素的数值限制).
        /// Mnemonic: <c>rt[i] := clamp(value[i], amin[i], amax[i]) = min(max(amin[i], value[i]), amax[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its clamp computed (将计算限制的向量).</param>
        /// <param name="amin">The lower bound of the value (值的下限).</param>
        /// <param name="amax">The upper bound of the value (值的上限).</param>
        /// <returns>A vector whose elements are the clamped to the inclusive range of <paramref name="amin" /> and <paramref name="amax" /> (一个向量，其元素是 限制在 <paramref name="amin" /> 和 <paramref name="amax" /> 范围内的).</returns>
        /// <seealso cref="YClamp_AcceleratedTypes"/>
        /// <seealso cref="BitMath.Clamp(long, long, long)"/>
        Vector<long> YClamp(Vector<long> value, Vector<long> amin, Vector<long> amax);

        /// <summary>
        /// Computes the numerical clamp of each element in a vector (计算向量中每个元素的数值限制).
        /// Mnemonic: <c>rt[i] := clamp(value[i], amin[i], amax[i]) = min(max(amin[i], value[i]), amax[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its clamp computed (将计算限制的向量).</param>
        /// <param name="amin">The lower bound of the value (值的下限).</param>
        /// <param name="amax">The upper bound of the value (值的上限).</param>
        /// <returns>A vector whose elements are the clamped to the inclusive range of <paramref name="amin" /> and <paramref name="amax" /> (一个向量，其元素是 限制在 <paramref name="amin" /> 和 <paramref name="amax" /> 范围内的).</returns>
        /// <seealso cref="YClamp_AcceleratedTypes"/>
        /// <seealso cref="BitMath.Clamp(ulong, ulong, ulong)"/>
        Vector<ulong> YClamp(Vector<ulong> value, Vector<ulong> amin, Vector<ulong> amax);


        /// <summary>
        /// Types with hardware acceleration when running <c>YNarrowSaturate</c> (运行 <c>YNarrowSaturate</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YNarrowSaturate"/>
        /// <seealso cref="YNarrowSaturate_FullAcceleratedTypes"/>
        /// <seealso cref="Narrow_AcceleratedTypes"/>
        TypeCodeFlags YNarrowSaturate_AcceleratedTypes { get; }

        /// <summary>
        /// Types with full hardware acceleration when running <c>YNarrowSaturate</c> (运行 <c>YNarrowSaturate</c> 时具有完全硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>`AcceleratedTypes` only indicates the presence of hardware acceleration, possibly indirectly through some algorithm. And `FullAcceleratedTypes` means that dedicated instructions are used to achieve full hardware acceleration. (`AcceleratedTypes`仅表示存在硬件加速,有可能是通过一些算法间接实现的. 而 `FullAcceleratedTypes`意味着使用了专用指令，实现了完全的硬件加速)</para>
        /// </remarks>
        /// <seealso cref="YNarrowSaturate"/>
        /// <seealso cref="YNarrowSaturate_AcceleratedTypes"/>
        TypeCodeFlags YNarrowSaturate_FullAcceleratedTypes { get; }

        /// <summary>
        /// Saturate narrows two <seealso cref="Vector{T}"/> instances into one <seealso cref="Vector{T}"/>"  (将两个 <seealso cref="Vector{T}"/> 实例饱和缩窄为一个 <seealso cref="Vector{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), TOut.MinValue, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturate_AcceleratedTypes"/>
        Vector<sbyte> YNarrowSaturate(Vector<short> lower, Vector<short> upper);

        /// <summary>
        /// Saturate narrows two <seealso cref="Vector{T}"/> instances into one <seealso cref="Vector{T}"/>"  (将两个 <seealso cref="Vector{T}"/> 实例饱和缩窄为一个 <seealso cref="Vector{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), TOut.MinValue, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturate_AcceleratedTypes"/>
        Vector<byte> YNarrowSaturate(Vector<ushort> lower, Vector<ushort> upper);

        /// <summary>
        /// Saturate narrows two <seealso cref="Vector{T}"/> instances into one <seealso cref="Vector{T}"/>"  (将两个 <seealso cref="Vector{T}"/> 实例饱和缩窄为一个 <seealso cref="Vector{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), TOut.MinValue, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturate_AcceleratedTypes"/>
        Vector<short> YNarrowSaturate(Vector<int> lower, Vector<int> upper);

        /// <summary>
        /// Saturate narrows two <seealso cref="Vector{T}"/> instances into one <seealso cref="Vector{T}"/>"  (将两个 <seealso cref="Vector{T}"/> 实例饱和缩窄为一个 <seealso cref="Vector{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), TOut.MinValue, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturate_AcceleratedTypes"/>
        Vector<ushort> YNarrowSaturate(Vector<uint> lower, Vector<uint> upper);

        /// <summary>
        /// Saturate narrows two <seealso cref="Vector{T}"/> instances into one <seealso cref="Vector{T}"/>"  (将两个 <seealso cref="Vector{T}"/> 实例饱和缩窄为一个 <seealso cref="Vector{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), TOut.MinValue, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturate_AcceleratedTypes"/>
        Vector<int> YNarrowSaturate(Vector<long> lower, Vector<long> upper);

        /// <summary>
        /// Saturate narrows two <seealso cref="Vector{T}"/> instances into one <seealso cref="Vector{T}"/>"  (将两个 <seealso cref="Vector{T}"/> 实例饱和缩窄为一个 <seealso cref="Vector{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), TOut.MinValue, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturate_AcceleratedTypes"/>
        Vector<uint> YNarrowSaturate(Vector<ulong> lower, Vector<ulong> upper);


        /// <summary>
        /// Types with hardware acceleration when running <c>YNarrowSaturateUnsigned</c> (运行 <c>YNarrowSaturateUnsigned</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="YNarrowSaturateUnsigned"/>
        /// <seealso cref="YNarrowSaturateUnsigned_FullAcceleratedTypes"/>
        /// <seealso cref="Narrow_AcceleratedTypes"/>
        TypeCodeFlags YNarrowSaturateUnsigned_AcceleratedTypes { get; }

        /// <summary>
        /// Types with full hardware acceleration when running <c>YNarrowSaturateUnsigned</c> (运行 <c>YNarrowSaturateUnsigned</c> 时具有完全硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>`AcceleratedTypes` only indicates the presence of hardware acceleration, possibly indirectly through some algorithm. And `FullAcceleratedTypes` means that dedicated instructions are used to achieve full hardware acceleration. (`AcceleratedTypes`仅表示存在硬件加速,有可能是通过一些算法间接实现的. 而 `FullAcceleratedTypes`意味着使用了专用指令，实现了完全的硬件加速)</para>
        /// </remarks>
        /// <seealso cref="YNarrowSaturateUnsigned"/>
        /// <seealso cref="YNarrowSaturateUnsigned_AcceleratedTypes"/>
        TypeCodeFlags YNarrowSaturateUnsigned_FullAcceleratedTypes { get; }

        /// <summary>
        /// Saturate narrows two signed <seealso cref="Vector{T}"/> instances into one unsigned <seealso cref="Vector{T}"/>"  (将两个有符号 <seealso cref="Vector{T}"/> 实例饱和缩窄为一个无符号 <seealso cref="Vector{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), 0, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturateUnsigned_AcceleratedTypes"/>
        Vector<byte> YNarrowSaturateUnsigned(Vector<short> lower, Vector<short> upper);

        /// <summary>
        /// Saturate narrows two signed <seealso cref="Vector{T}"/> instances into one unsigned <seealso cref="Vector{T}"/>"  (将两个有符号 <seealso cref="Vector{T}"/> 实例饱和缩窄为一个无符号 <seealso cref="Vector{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), 0, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturateUnsigned_AcceleratedTypes"/>
        Vector<ushort> YNarrowSaturateUnsigned(Vector<int> lower, Vector<int> upper);

        /// <summary>
        /// Saturate narrows two signed <seealso cref="Vector{T}"/> instances into one unsigned <seealso cref="Vector{T}"/>"  (将两个有符号 <seealso cref="Vector{T}"/> 实例饱和缩窄为一个无符号 <seealso cref="Vector{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow_saturate(element_ref(i, lower, upper)) = narrow(clamp(element_ref(i, lower, upper), 0, TOut.MaxValue))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="YNarrowSaturateUnsigned_AcceleratedTypes"/>
        Vector<uint> YNarrowSaturateUnsigned(Vector<long> lower, Vector<long> upper);

        #endregion // mY_style

    }
}
