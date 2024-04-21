﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
#endif

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// <see cref="Vector512{T}"/> traits interface (<see cref="Vector512{T}"/> 的特征接口).
    /// </summary>
    [CLSCompliant(false)]
    public partial interface IWVectorTraits512 : IWVectorTraits {
#if NET8_0_OR_GREATER

        // == .NET style  ==

        /// <summary>
        /// Types with hardware acceleration when running <c>Ceiling</c> (运行 <c>Ceiling</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Methods used to calculate rounding (用于计算舍入的方法):</para>
        /// <para>- <see cref="Ceiling(Vector512{float})"/>: Computes the ceiling of each element in a vector (计算向量中每个元素的向上取整). It is also known as round to positive infinity (它也被称作向正无穷舍入). See more: <see cref="MidpointRounding.ToPositiveInfinity"/>.</para>
        /// <para>- <see cref="Floor(Vector512{float})"/>: Computes the floor of each element in a vector (计算向量中每个元素的向下取整). It is also known as round to negative infinity (它也被称作向负无穷舍入). See more: <see cref="MidpointRounding.ToNegativeInfinity"/>.</para>
        /// <para>- <see cref="YRoundToEven(Vector512{float})"/>: Computes the round to even of each element in a vector (计算向量中每个元素的向偶数舍入). It is also known as `rounding half to even`/`round to nearest integer` (它也被称作`四舍六入五成双`/`舍入到最近整数`). See more: <see cref="MidpointRounding.ToEven"/>.</para>
        /// <para>- <see cref="YRoundToZero(Vector512{float})"/>: Computes the round to zero of each element in a vector (计算向量中每个元素的向零舍入). It is also known as truncate (它也被称作截断取整). See more: <see cref="MidpointRounding.ToZero"/>.</para>
        /// </remarks>
        /// <seealso cref="Ceiling(Vector512{float})"/>
        TypeCodeFlags Ceiling_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the ceiling of each element in a vector (计算向量中每个元素的向上取整). It is also known as round to positive infinity (它也被称作向正无穷舍入). See more: <see cref="MidpointRounding.ToPositiveInfinity"/>.
        /// Mnemonic: <c>rt[i] := ceiling(value[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its ceiling computed (将计算向上舍入的向量).</param>
        /// <returns>A vector whose elements are the ceiling of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的向上取整).</returns>
        /// <seealso cref="Ceiling_AcceleratedTypes"/>
        /// <seealso cref="Vector512.Ceiling(Vector512{float})" />
        Vector512<float> Ceiling(Vector512<float> value);

        /// <summary>
        /// Computes the ceiling of each element in a vector (计算向量中每个元素的向上取整). It is also known as round to positive infinity (它也被称作向正无穷舍入). See more: <see cref="MidpointRounding.ToPositiveInfinity"/>.
        /// Mnemonic: <c>rt[i] := ceiling(value[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its ceiling computed (将计算向上舍入的向量).</param>
        /// <returns>A vector whose elements are the ceiling of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的向上取整).</returns>
        /// <seealso cref="Ceiling_AcceleratedTypes"/>
        /// <seealso cref="Vector512.Ceiling(Vector512{double})" />
        Vector512<double> Ceiling(Vector512<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>ConvertToDouble</c> (运行 <c>ConvertToDouble</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规). Full 64-bit integer range (完全的64位整数范围).</para>
        /// <para>- Range52: Supports up to 52-bit integer range (最多支持52位整数范围).</para>
        /// </remarks>
        /// <seealso cref="ConvertToDouble(Vector512{long})"/>
        /// <seealso cref="ConvertToDouble_Range52(Vector512{long})"/>
        TypeCodeFlags ConvertToDouble_AcceleratedTypes { get; }

        /// <summary>
        /// Convert to a vector whose elements are of type Double (转换为元素类型是Double的向量)..
        /// Mnemonic: <c>rt[i] := (Double)(value[i])</c>.
        /// </summary>
        /// <param name="value">The source vector (源向量).</param>
        /// <returns>The converted vector (转换后的向量).</returns>
        /// <seealso cref="ConvertToDouble_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ConvertToDouble(Vector512{long})" />
        Vector512<double> ConvertToDouble(Vector512<long> value);

        /// <summary>
        /// Convert to a vector whose elements are of type Double (转换为元素类型是Double的向量)..
        /// Mnemonic: <c>rt[i] := (Double)(value[i])</c>.
        /// </summary>
        /// <param name="value">The source vector (源向量).</param>
        /// <returns>The converted vector (转换后的向量).</returns>
        /// <seealso cref="ConvertToDouble_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ConvertToDouble(Vector512{ulong})" />
        Vector512<double> ConvertToDouble(Vector512<ulong> value);

        /// <summary>
        /// Convert to a vector whose elements are of type Double (转换为元素类型是Double的向量). Works for inputs in the range: [-2^51, 2^51).
        /// Mnemonic: <c>rt[i] := (Double)(value[i])</c>.
        /// </summary>
        /// <param name="value">The source vector (源向量).</param>
        /// <returns>The converted vector (转换后的向量).</returns>
        /// <seealso cref="ConvertToDouble_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ConvertToDouble(Vector512{long})" />
        Vector512<double> ConvertToDouble_Range52(Vector512<long> value);

        /// <summary>
        /// Convert to a vector whose elements are of type Double (转换为元素类型是Double的向量). Works for inputs in the range: [0, 2^52).
        /// Mnemonic: <c>rt[i] := (Double)(value[i])</c>.
        /// </summary>
        /// <param name="value">The source vector (源向量).</param>
        /// <returns>The converted vector (转换后的向量).</returns>
        /// <seealso cref="ConvertToDouble_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ConvertToDouble(Vector512{ulong})" />
        Vector512<double> ConvertToDouble_Range52(Vector512<ulong> value);


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
        /// <seealso cref="Vector512.ConvertToInt32(Vector512{float})" />
        Vector512<int> ConvertToInt32(Vector512<float> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>ConvertToInt64</c> (运行 <c>ConvertToInt64</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规). Full 64-bit integer range (完全的64位整数范围). Rounding mode is truncate(round to zero) (舍入模式为截断(舍入到零)).</para>
        /// <para>- Range52: Supports up to 52-bit integer range (最多支持52位整数范围). Rounding mode is truncate(round to zero) (舍入模式为截断(舍入到零)).</para>
        /// <para>- Range52RoundToEven: Supports up to 52-bit integer range (最多支持52位整数范围). Rounding mode is round to even(round to nearest integer) (舍入模式为舍入到偶数(舍入到最近整数)).</para>
        /// </remarks>
        /// <seealso cref="ConvertToInt64"/>
        /// <seealso cref="ConvertToInt64_Range52"/>
        /// <seealso cref="ConvertToInt64_Range52RoundToEven"/>
        TypeCodeFlags ConvertToInt64_AcceleratedTypes { get; }

        /// <summary>
        /// Convert to a vector whose elements are of type Int64, rounding mode is truncate(round to zero) (转换为元素类型是Int64的向量, 舍入模式为截断(舍入到零)).
        /// Mnemonic: <c>rt[i] := (Int64)(value[i])</c>.
        /// </summary>
        /// <param name="value">The source vector (源向量).</param>
        /// <returns>The converted vector (转换后的向量).</returns>
        /// <seealso cref="ConvertToInt64_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ConvertToInt64(Vector512{double})" />
        Vector512<long> ConvertToInt64(Vector512<double> value);

        /// <summary>
        /// Convert to a vector whose elements are of type Int64, rounding mode is truncate(round to zero) (转换为元素类型是Int64的向量, 舍入模式为截断(舍入到零)). Works for inputs in the range: [-2^51, 2^51).
        /// Mnemonic: <c>rt[i] := (Int64)(value[i])</c>.
        /// </summary>
        /// <param name="value">The source vector (源向量).</param>
        /// <returns>The converted vector (转换后的向量).</returns>
        /// <seealso cref="ConvertToInt64_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ConvertToInt64(Vector512{double})" />
        Vector512<long> ConvertToInt64_Range52(Vector512<double> value);

        /// <summary>
        /// Convert to a vector whose elements are of type Int64, rounding mode is round to even(round to nearest integer) (转换为元素类型是Int64的向量, 舍入模式为舍入到偶数(舍入到最近整数)). Works for inputs in the range: [-2^51, 2^51).
        /// Mnemonic: <c>rt[i] := (Int64)(round_to_even(value[i]))</c>.
        /// </summary>
        /// <param name="value">The source vector (源向量).</param>
        /// <returns>The converted vector (转换后的向量).</returns>
        /// <seealso cref="ConvertToInt64_AcceleratedTypes"/>
        Vector512<long> ConvertToInt64_Range52RoundToEven(Vector512<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>ConvertToSingle</c> (运行 <c>ConvertToSingle</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="ConvertToSingle(Vector512{int})"/>
        TypeCodeFlags ConvertToSingle_AcceleratedTypes { get; }

        /// <summary>
        /// Convert to a vector whose elements are of type Single (转换为元素类型是Single的向量)..
        /// Mnemonic: <c>rt[i] := (Single)(value[i])</c>.
        /// </summary>
        /// <param name="value">The source vector (源向量).</param>
        /// <returns>The converted vector (转换后的向量).</returns>
        /// <seealso cref="ConvertToSingle_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ConvertToSingle(Vector512{int})" />
        Vector512<float> ConvertToSingle(Vector512<int> value);

        /// <summary>
        /// Convert to a vector whose elements are of type Single (转换为元素类型是Single的向量)..
        /// Mnemonic: <c>rt[i] := (Single)(value[i])</c>.
        /// </summary>
        /// <param name="value">The source vector (源向量).</param>
        /// <returns>The converted vector (转换后的向量).</returns>
        /// <seealso cref="ConvertToSingle_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ConvertToSingle(Vector512{uint})" />
        Vector512<float> ConvertToSingle(Vector512<uint> value);


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
        /// <seealso cref="Vector512.ConvertToUInt32(Vector512{float})" />
        Vector512<uint> ConvertToUInt32(Vector512<float> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>ConvertToUInt64</c> (运行 <c>ConvertToUInt64</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规). Full 64-bit integer range (完全的64位整数范围). Rounding mode is truncate(round to zero) (舍入模式为截断(舍入到零)).</para>
        /// <para>- Range52: Supports up to 52-bit integer range (最多支持52位整数范围). Rounding mode is truncate(round to zero) (舍入模式为截断(舍入到零)).</para>
        /// <para>- Range52RoundToEven: Supports up to 52-bit integer range (最多支持52位整数范围). Rounding mode is round to even(round to nearest integer) (舍入模式为舍入到偶数(舍入到最近整数)).</para>
        /// </remarks>
        /// <seealso cref="ConvertToUInt64"/>
        /// <seealso cref="ConvertToUInt64_Range52"/>
        /// <seealso cref="ConvertToUInt64_Range52RoundToEven"/>
        TypeCodeFlags ConvertToUInt64_AcceleratedTypes { get; }

        /// <summary>
        /// Convert to a vector whose elements are of type UInt64, rounding mode is truncate(round to zero) (转换为元素类型是UInt64的向量, 舍入模式为截断(舍入到零)).
        /// Mnemonic: <c>rt[i] := (UInt64)(value[i])</c>.
        /// </summary>
        /// <param name="value">The source vector (源向量).</param>
        /// <returns>The converted vector (转换后的向量).</returns>
        /// <seealso cref="ConvertToUInt64_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ConvertToUInt64(Vector512{double})" />
        Vector512<ulong> ConvertToUInt64(Vector512<double> value);

        /// <summary>
        /// Convert to a vector whose elements are of type UInt64, rounding mode is truncate(round to zero) (转换为元素类型是UInt64的向量, 舍入模式为截断(舍入到零)). Works for inputs in the range: [0, 2^52).
        /// Mnemonic: <c>rt[i] := (UInt64)(value[i])</c>.
        /// </summary>
        /// <param name="value">The source vector (源向量).</param>
        /// <returns>The converted vector (转换后的向量).</returns>
        /// <seealso cref="ConvertToUInt64_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ConvertToUInt64(Vector512{double})" />
        Vector512<ulong> ConvertToUInt64_Range52(Vector512<double> value);

        /// <summary>
        /// Convert to a vector whose elements are of type UInt64, rounding mode is round to even(round to nearest integer) (转换为元素类型是UInt64的向量, 舍入模式为舍入到偶数(舍入到最近整数)). Works for inputs in the range: [0, 2^52).
        /// Mnemonic: <c>rt[i] := (UInt64)(round_to_even(value[i]))</c>.
        /// </summary>
        /// <param name="value">The source vector (源向量).</param>
        /// <returns>The converted vector (转换后的向量).</returns>
        /// <seealso cref="ConvertToUInt64_AcceleratedTypes"/>
        Vector512<ulong> ConvertToUInt64_Range52RoundToEven(Vector512<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>ExtractMostSignificantBits</c> (运行 <c>ExtractMostSignificantBits</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Inverse function (反函数): <see cref="YBitToByte"/>, <see cref="YBitToInt16"/>, <see cref="YBitToInt32"/>, <see cref="YBitToInt64"/>.</para>
        /// </remarks>
        /// <seealso cref="ExtractMostSignificantBits(Vector512{byte})"/>
        TypeCodeFlags ExtractMostSignificantBits_AcceleratedTypes { get; }

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ExtractMostSignificantBits{T}(Vector512{T})" />
        ulong ExtractMostSignificantBits(Vector512<float> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ExtractMostSignificantBits{T}(Vector512{T})" />
        ulong ExtractMostSignificantBits(Vector512<double> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ExtractMostSignificantBits{T}(Vector512{T})" />
        ulong ExtractMostSignificantBits(Vector512<sbyte> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ExtractMostSignificantBits{T}(Vector512{T})" />
        ulong ExtractMostSignificantBits(Vector512<byte> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ExtractMostSignificantBits{T}(Vector512{T})" />
        ulong ExtractMostSignificantBits(Vector512<short> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ExtractMostSignificantBits{T}(Vector512{T})" />
        ulong ExtractMostSignificantBits(Vector512<ushort> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ExtractMostSignificantBits{T}(Vector512{T})" />
        ulong ExtractMostSignificantBits(Vector512<int> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ExtractMostSignificantBits{T}(Vector512{T})" />
        ulong ExtractMostSignificantBits(Vector512<uint> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ExtractMostSignificantBits{T}(Vector512{T})" />
        ulong ExtractMostSignificantBits(Vector512<long> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ExtractMostSignificantBits{T}(Vector512{T})" />
        ulong ExtractMostSignificantBits(Vector512<ulong> vector);


        /// <summary>
        /// Types with hardware acceleration when running <c>Floor</c> (运行 <c>Floor</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Methods used to calculate rounding (用于计算舍入的方法):</para>
        /// <para>- <see cref="Ceiling(Vector512{float})"/>: Computes the ceiling of each element in a vector (计算向量中每个元素的向上取整). It is also known as round to positive infinity (它也被称作向正无穷舍入). See more: <see cref="MidpointRounding.ToPositiveInfinity"/>.</para>
        /// <para>- <see cref="Floor(Vector512{float})"/>: Computes the floor of each element in a vector (计算向量中每个元素的向下取整). It is also known as round to negative infinity (它也被称作向负无穷舍入). See more: <see cref="MidpointRounding.ToNegativeInfinity"/>.</para>
        /// <para>- <see cref="YRoundToEven(Vector512{float})"/>: Computes the round to even of each element in a vector (计算向量中每个元素的向偶数舍入). It is also known as `rounding half to even`/`round to nearest integer` (它也被称作`四舍六入五成双`/`舍入到最近整数`). See more: <see cref="MidpointRounding.ToEven"/>.</para>
        /// <para>- <see cref="YRoundToZero(Vector512{float})"/>: Computes the round to zero of each element in a vector (计算向量中每个元素的向零舍入). It is also known as truncate (它也被称作截断取整). See more: <see cref="MidpointRounding.ToZero"/>.</para>
        /// </remarks>
        /// <seealso cref="Floor(Vector512{float})"/>
        TypeCodeFlags Floor_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the floor of each element in a vector (计算向量中每个元素的向下取整). It is also known as round to negative infinity (它也被称作向负无穷舍入). See more: <see cref="MidpointRounding.ToNegativeInfinity"/>.
        /// Mnemonic: <c>rt[i] := floor(value[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its floor computed (将计算向下舍入的向量).</param>
        /// <returns>A vector whose elements are the floor of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的向下取整).</returns>
        /// <seealso cref="Floor_AcceleratedTypes"/>
        /// <seealso cref="Vector512.Floor(Vector512{float})" />
        Vector512<float> Floor(Vector512<float> value);

        /// <summary>
        /// Computes the floor of each element in a vector (计算向量中每个元素的向下取整). It is also known as round to negative infinity (它也被称作向负无穷舍入). See more: <see cref="MidpointRounding.ToNegativeInfinity"/>.
        /// Mnemonic: <c>rt[i] := floor(value[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its floor computed (将计算向下舍入的向量).</param>
        /// <returns>A vector whose elements are the floor of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的向下取整).</returns>
        /// <seealso cref="Floor_AcceleratedTypes"/>
        /// <seealso cref="Vector512.Floor(Vector512{double})" />
        Vector512<double> Floor(Vector512<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>Narrow</c> (运行 <c>Narrow</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Narrow(Vector512{short}, Vector512{short})"/>
        TypeCodeFlags Narrow_AcceleratedTypes { get; }

        /// <summary>
        /// Narrows two <seealso cref="Vector512{T}"/> instances into one <seealso cref="Vector512{T}"/>"  (将两个 <seealso cref="Vector512{T}"/> 实例缩窄为一个 <seealso cref="Vector512{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow(element_ref(i, lower, upper))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector512{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="Narrow_AcceleratedTypes"/>
        /// <seealso cref="Vector512.Narrow(Vector512{double}, Vector512{double})" />
        Vector512<float> Narrow(Vector512<double> lower, Vector512<double> upper);

        /// <summary>
        /// Narrows two <seealso cref="Vector512{T}"/> instances into one <seealso cref="Vector512{T}"/>"  (将两个 <seealso cref="Vector512{T}"/> 实例缩窄为一个 <seealso cref="Vector512{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow(element_ref(i, lower, upper))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector512{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="Narrow_AcceleratedTypes"/>
        /// <seealso cref="Vector512.Narrow(Vector512{short}, Vector512{short})" />
        Vector512<sbyte> Narrow(Vector512<short> lower, Vector512<short> upper);

        /// <summary>
        /// Narrows two <seealso cref="Vector512{T}"/> instances into one <seealso cref="Vector512{T}"/>"  (将两个 <seealso cref="Vector512{T}"/> 实例缩窄为一个 <seealso cref="Vector512{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow(element_ref(i, lower, upper))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector512{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="Narrow_AcceleratedTypes"/>
        /// <seealso cref="Vector512.Narrow(Vector512{ushort}, Vector512{ushort})" />
        Vector512<byte> Narrow(Vector512<ushort> lower, Vector512<ushort> upper);

        /// <summary>
        /// Narrows two <seealso cref="Vector512{T}"/> instances into one <seealso cref="Vector512{T}"/>"  (将两个 <seealso cref="Vector512{T}"/> 实例缩窄为一个 <seealso cref="Vector512{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow(element_ref(i, lower, upper))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector512{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="Narrow_AcceleratedTypes"/>
        /// <seealso cref="Vector512.Narrow(Vector512{int}, Vector512{int})" />
        Vector512<short> Narrow(Vector512<int> lower, Vector512<int> upper);

        /// <summary>
        /// Narrows two <seealso cref="Vector512{T}"/> instances into one <seealso cref="Vector512{T}"/>"  (将两个 <seealso cref="Vector512{T}"/> 实例缩窄为一个 <seealso cref="Vector512{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow(element_ref(i, lower, upper))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector512{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="Narrow_AcceleratedTypes"/>
        /// <seealso cref="Vector512.Narrow(Vector512{uint}, Vector512{uint})" />
        Vector512<ushort> Narrow(Vector512<uint> lower, Vector512<uint> upper);

        /// <summary>
        /// Narrows two <seealso cref="Vector512{T}"/> instances into one <seealso cref="Vector512{T}"/>"  (将两个 <seealso cref="Vector512{T}"/> 实例缩窄为一个 <seealso cref="Vector512{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow(element_ref(i, lower, upper))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector512{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="Narrow_AcceleratedTypes"/>
        /// <seealso cref="Vector512.Narrow(Vector512{long}, Vector512{long})" />
        Vector512<int> Narrow(Vector512<long> lower, Vector512<long> upper);

        /// <summary>
        /// Narrows two <seealso cref="Vector512{T}"/> instances into one <seealso cref="Vector512{T}"/>"  (将两个 <seealso cref="Vector512{T}"/> 实例缩窄为一个 <seealso cref="Vector512{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow(element_ref(i, lower, upper))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector512{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="Narrow_AcceleratedTypes"/>
        /// <seealso cref="Vector512.Narrow(Vector512{ulong}, Vector512{ulong})" />
        Vector512<uint> Narrow(Vector512<ulong> lower, Vector512<ulong> upper);


        /// <summary>
        /// Types with hardware acceleration when running <c>ShiftLeft</c> (运行 <c>ShiftLeft</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Args: Arguments calculation. Provide arguments for ShiftLeft_Core (参数计算. 为 ShiftLeft_Core 提供参数).</para>
        /// <para>- Core. Core calculation. Its arguments are derived from ShiftLeft_Args (核心计算. 其参数来源于 ShiftLeft_Args).</para>
        /// <para>- Const: Constant version. This version can be used if you can ensure that the parameters are constants. It can take advantage of constants and make better use of hardware acceleration (常量版. 若能确保参数是常量, 可使用该版本. 它能利用常量, 更好的使用硬件加速).</para>
        /// <para>- ConstCore: Core calculation of constant version. Its arguments are derived from ShiftLeft_Args (常量版的核心计算. 其参数来源于 ShiftLeft_Args).</para>
        /// <para>- Fast: Fast version. This version can be used if you can ensure that the parameter variables are always in the valid range (快速版. 若能确保参数变量总是在有效范围内的, 可使用该版本).</para>
        /// </remarks>
        /// <seealso cref="ShiftLeft(Vector512{byte}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector512{byte}, int, out Vector512{byte})"/>
        /// <seealso cref="ShiftLeft_Core(Vector512{byte}, int, Vector512{byte}, Vector512{byte})"/>
        /// <seealso cref="ShiftLeft_Const(Vector512{byte}, int)"/>
        /// <seealso cref="ShiftLeft_ConstCore(Vector512{byte}, int, Vector512{byte}, Vector512{byte})"/>
        /// <seealso cref="ShiftLeft_Fast(Vector512{byte}, int)"/>
        TypeCodeFlags ShiftLeft_AcceleratedTypes { get; }

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{sbyte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft_Fast(Vector512{sbyte}, int)"/>
        Vector512<sbyte> ShiftLeft(Vector512<sbyte> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{byte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft_Fast(Vector512{byte}, int)"/>
        Vector512<byte> ShiftLeft(Vector512<byte> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft_Fast(Vector512{short}, int)"/>
        Vector512<short> ShiftLeft(Vector512<short> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{ushort}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft_Fast(Vector512{ushort}, int)"/>
        Vector512<ushort> ShiftLeft(Vector512<ushort> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft_Fast(Vector512{int}, int)"/>
        Vector512<int> ShiftLeft(Vector512<int> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{uint}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft_Fast(Vector512{uint}, int)"/>
        Vector512<uint> ShiftLeft(Vector512<uint> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{long}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft_Fast(Vector512{long}, int)"/>
        Vector512<long> ShiftLeft(Vector512<long> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{ulong}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft_Fast(Vector512{ulong}, int)"/>
        Vector512<ulong> ShiftLeft(Vector512<ulong> value, int shiftAmount);

        /// <summary>
        /// Arguments calculation for shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量的参数计算). Provide arguments for ShiftLeft_Core (为 ShiftLeft_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftLeft_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftLeft_Core .</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{sbyte}, int)"/>
        /// <seealso cref="ShiftLeft(Vector512{sbyte}, int)"/>
        /// <seealso cref="ShiftLeft_Core(Vector512{sbyte}, int, Vector512{sbyte}, Vector512{sbyte})"/>
        Vector512<sbyte> ShiftLeft_Args(Vector512<sbyte> dummy, int shiftAmount, out Vector512<sbyte> args1);

        /// <summary>
        /// Arguments calculation for shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量的参数计算). Provide arguments for ShiftLeft_Core (为 ShiftLeft_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftLeft_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftLeft_Core .</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{byte}, int)"/>
        /// <seealso cref="ShiftLeft(Vector512{byte}, int)"/>
        /// <seealso cref="ShiftLeft_Core(Vector512{byte}, int, Vector512{byte}, Vector512{byte})"/>
        Vector512<byte> ShiftLeft_Args(Vector512<byte> dummy, int shiftAmount, out Vector512<byte> args1);

        /// <summary>
        /// Arguments calculation for shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量的参数计算). Provide arguments for ShiftLeft_Core (为 ShiftLeft_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftLeft_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftLeft_Core .</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{short}, int)"/>
        /// <seealso cref="ShiftLeft(Vector512{short}, int)"/>
        /// <seealso cref="ShiftLeft_Core(Vector512{short}, int, Vector512{short}, Vector512{short})"/>
        Vector512<short> ShiftLeft_Args(Vector512<short> dummy, int shiftAmount, out Vector512<short> args1);

        /// <summary>
        /// Arguments calculation for shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量的参数计算). Provide arguments for ShiftLeft_Core (为 ShiftLeft_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftLeft_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftLeft_Core .</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{ushort}, int)"/>
        /// <seealso cref="ShiftLeft(Vector512{ushort}, int)"/>
        /// <seealso cref="ShiftLeft_Core(Vector512{ushort}, int, Vector512{ushort}, Vector512{ushort})"/>
        Vector512<ushort> ShiftLeft_Args(Vector512<ushort> dummy, int shiftAmount, out Vector512<ushort> args1);

        /// <summary>
        /// Arguments calculation for shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量的参数计算). Provide arguments for ShiftLeft_Core (为 ShiftLeft_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftLeft_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftLeft_Core .</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{int}, int)"/>
        /// <seealso cref="ShiftLeft(Vector512{int}, int)"/>
        /// <seealso cref="ShiftLeft_Core(Vector512{int}, int, Vector512{int}, Vector512{int})"/>
        Vector512<int> ShiftLeft_Args(Vector512<int> dummy, int shiftAmount, out Vector512<int> args1);

        /// <summary>
        /// Arguments calculation for shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量的参数计算). Provide arguments for ShiftLeft_Core (为 ShiftLeft_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftLeft_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftLeft_Core .</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{uint}, int)"/>
        /// <seealso cref="ShiftLeft(Vector512{uint}, int)"/>
        /// <seealso cref="ShiftLeft_Core(Vector512{uint}, int, Vector512{uint}, Vector512{uint})"/>
        Vector512<uint> ShiftLeft_Args(Vector512<uint> dummy, int shiftAmount, out Vector512<uint> args1);

        /// <summary>
        /// Arguments calculation for shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量的参数计算). Provide arguments for ShiftLeft_Core (为 ShiftLeft_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftLeft_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftLeft_Core .</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{long}, int)"/>
        /// <seealso cref="ShiftLeft(Vector512{long}, int)"/>
        /// <seealso cref="ShiftLeft_Core(Vector512{long}, int, Vector512{long}, Vector512{long})"/>
        Vector512<long> ShiftLeft_Args(Vector512<long> dummy, int shiftAmount, out Vector512<long> args1);

        /// <summary>
        /// Arguments calculation for shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量的参数计算). Provide arguments for ShiftLeft_Core (为 ShiftLeft_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftLeft_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftLeft_Core .</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{ulong}, int)"/>
        /// <seealso cref="ShiftLeft(Vector512{ulong}, int)"/>
        /// <seealso cref="ShiftLeft_Core(Vector512{ulong}, int, Vector512{ulong}, Vector512{ulong})"/>
        Vector512<ulong> ShiftLeft_Args(Vector512<ulong> dummy, int shiftAmount, out Vector512<ulong> args1);

        /// <summary>
        /// Core calculation for shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量的核心计算). Its arguments are derived from ShiftLeft_Args (其参数来源于 ShiftLeft_Args).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from ShiftLeft_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from ShiftLeft_Args .</param>
        /// <returns>A vector for each element after left shift (每个元素左移位后的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{sbyte}, int)"/>
        /// <seealso cref="ShiftLeft(Vector512{sbyte}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector512{sbyte}, int, out Vector512{sbyte})"/>
        Vector512<sbyte> ShiftLeft_Core(Vector512<sbyte> value, int shiftAmount, Vector512<sbyte> args0, Vector512<sbyte> args1);

        /// <summary>
        /// Core calculation for shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量的核心计算). Its arguments are derived from ShiftLeft_Args (其参数来源于 ShiftLeft_Args).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from ShiftLeft_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from ShiftLeft_Args .</param>
        /// <returns>A vector for each element after left shift (每个元素左移位后的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{byte}, int)"/>
        /// <seealso cref="ShiftLeft(Vector512{byte}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector512{byte}, int, out Vector512{byte})"/>
        Vector512<byte> ShiftLeft_Core(Vector512<byte> value, int shiftAmount, Vector512<byte> args0, Vector512<byte> args1);

        /// <summary>
        /// Core calculation for shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量的核心计算). Its arguments are derived from ShiftLeft_Args (其参数来源于 ShiftLeft_Args).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from ShiftLeft_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from ShiftLeft_Args .</param>
        /// <returns>A vector for each element after left shift (每个元素左移位后的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{short}, int)"/>
        /// <seealso cref="ShiftLeft(Vector512{short}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector512{short}, int, out Vector512{short})"/>
        Vector512<short> ShiftLeft_Core(Vector512<short> value, int shiftAmount, Vector512<short> args0, Vector512<short> args1);

        /// <summary>
        /// Core calculation for shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量的核心计算). Its arguments are derived from ShiftLeft_Args (其参数来源于 ShiftLeft_Args).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from ShiftLeft_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from ShiftLeft_Args .</param>
        /// <returns>A vector for each element after left shift (每个元素左移位后的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{ushort}, int)"/>
        /// <seealso cref="ShiftLeft(Vector512{ushort}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector512{ushort}, int, out Vector512{ushort})"/>
        Vector512<ushort> ShiftLeft_Core(Vector512<ushort> value, int shiftAmount, Vector512<ushort> args0, Vector512<ushort> args1);

        /// <summary>
        /// Core calculation for shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量的核心计算). Its arguments are derived from ShiftLeft_Args (其参数来源于 ShiftLeft_Args).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from ShiftLeft_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from ShiftLeft_Args .</param>
        /// <returns>A vector for each element after left shift (每个元素左移位后的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{int}, int)"/>
        /// <seealso cref="ShiftLeft(Vector512{int}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector512{int}, int, out Vector512{int})"/>
        Vector512<int> ShiftLeft_Core(Vector512<int> value, int shiftAmount, Vector512<int> args0, Vector512<int> args1);

        /// <summary>
        /// Core calculation for shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量的核心计算). Its arguments are derived from ShiftLeft_Args (其参数来源于 ShiftLeft_Args).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from ShiftLeft_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from ShiftLeft_Args .</param>
        /// <returns>A vector for each element after left shift (每个元素左移位后的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{uint}, int)"/>
        /// <seealso cref="ShiftLeft(Vector512{uint}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector512{uint}, int, out Vector512{uint})"/>
        Vector512<uint> ShiftLeft_Core(Vector512<uint> value, int shiftAmount, Vector512<uint> args0, Vector512<uint> args1);

        /// <summary>
        /// Core calculation for shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量的核心计算). Its arguments are derived from ShiftLeft_Args (其参数来源于 ShiftLeft_Args).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from ShiftLeft_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from ShiftLeft_Args .</param>
        /// <returns>A vector for each element after left shift (每个元素左移位后的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{long}, int)"/>
        /// <seealso cref="ShiftLeft(Vector512{long}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector512{long}, int, out Vector512{long})"/>
        Vector512<long> ShiftLeft_Core(Vector512<long> value, int shiftAmount, Vector512<long> args0, Vector512<long> args1);

        /// <summary>
        /// Core calculation for shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量的核心计算). Its arguments are derived from ShiftLeft_Args (其参数来源于 ShiftLeft_Args).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from ShiftLeft_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from ShiftLeft_Args .</param>
        /// <returns>A vector for each element after left shift (每个元素左移位后的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{ulong}, int)"/>
        /// <seealso cref="ShiftLeft(Vector512{ulong}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector512{ulong}, int, out Vector512{ulong})"/>
        Vector512<ulong> ShiftLeft_Core(Vector512<ulong> value, int shiftAmount, Vector512<ulong> args0, Vector512<ulong> args1);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Const (将向量的每个元素左移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~7 (有效范围是 1~7).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{sbyte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector512{sbyte}, int)"/>
        Vector512<sbyte> ShiftLeft_Const(Vector512<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Const (将向量的每个元素左移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~7 (有效范围是 1~7).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{byte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector512{byte}, int)"/>
        Vector512<byte> ShiftLeft_Const(Vector512<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Const (将向量的每个元素左移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~15 (有效范围是 1~15).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector512{short}, int)"/>
        Vector512<short> ShiftLeft_Const(Vector512<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Const (将向量的每个元素左移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~15 (有效范围是 1~15).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{ushort}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector512{ushort}, int)"/>
        Vector512<ushort> ShiftLeft_Const(Vector512<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Const (将向量的每个元素左移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~31 (有效范围是 1~31).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector512{int}, int)"/>
        Vector512<int> ShiftLeft_Const(Vector512<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Const (将向量的每个元素左移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~31 (有效范围是 1~31).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{uint}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector512{uint}, int)"/>
        Vector512<uint> ShiftLeft_Const(Vector512<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Const (将向量的每个元素左移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~63 (有效范围是 1~63).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{long}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector512{long}, int)"/>
        Vector512<long> ShiftLeft_Const(Vector512<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Const (将向量的每个元素左移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~63 (有效范围是 1~63).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{ulong}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector512{ulong}, int)"/>
        Vector512<ulong> ShiftLeft_Const(Vector512<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount);

        /// <summary>
        /// Core calculation for shifts each element of a vector left by the specified amount - Const (将向量的每个元素左移指定量的核心计算 - 常量). Its arguments are derived from ShiftLeft_Args (其参数来源于 ShiftLeft_Args).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~7 (有效范围是 1~7).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from ShiftLeft_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from ShiftLeft_Args .</param>
        /// <returns>A vector for each element after left shift (每个元素左移位后的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{sbyte}, int)"/>
        /// <seealso cref="ShiftLeft(Vector512{sbyte}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector512{sbyte}, int, out Vector512{sbyte})"/>
        Vector512<sbyte> ShiftLeft_ConstCore(Vector512<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector512<sbyte> args0, Vector512<sbyte> args1);

        /// <summary>
        /// Core calculation for shifts each element of a vector left by the specified amount - Const (将向量的每个元素左移指定量的核心计算 - 常量). Its arguments are derived from ShiftLeft_Args (其参数来源于 ShiftLeft_Args).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~7 (有效范围是 1~7).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from ShiftLeft_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from ShiftLeft_Args .</param>
        /// <returns>A vector for each element after left shift (每个元素左移位后的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{byte}, int)"/>
        /// <seealso cref="ShiftLeft(Vector512{byte}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector512{byte}, int, out Vector512{byte})"/>
        Vector512<byte> ShiftLeft_ConstCore(Vector512<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector512<byte> args0, Vector512<byte> args1);

        /// <summary>
        /// Core calculation for shifts each element of a vector left by the specified amount - Const (将向量的每个元素左移指定量的核心计算 - 常量). Its arguments are derived from ShiftLeft_Args (其参数来源于 ShiftLeft_Args).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~15 (有效范围是 1~15).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from ShiftLeft_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from ShiftLeft_Args .</param>
        /// <returns>A vector for each element after left shift (每个元素左移位后的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{short}, int)"/>
        /// <seealso cref="ShiftLeft(Vector512{short}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector512{short}, int, out Vector512{short})"/>
        Vector512<short> ShiftLeft_ConstCore(Vector512<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector512<short> args0, Vector512<short> args1);

        /// <summary>
        /// Core calculation for shifts each element of a vector left by the specified amount - Const (将向量的每个元素左移指定量的核心计算 - 常量). Its arguments are derived from ShiftLeft_Args (其参数来源于 ShiftLeft_Args).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~15 (有效范围是 1~15).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from ShiftLeft_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from ShiftLeft_Args .</param>
        /// <returns>A vector for each element after left shift (每个元素左移位后的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{ushort}, int)"/>
        /// <seealso cref="ShiftLeft(Vector512{ushort}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector512{ushort}, int, out Vector512{ushort})"/>
        Vector512<ushort> ShiftLeft_ConstCore(Vector512<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector512<ushort> args0, Vector512<ushort> args1);

        /// <summary>
        /// Core calculation for shifts each element of a vector left by the specified amount - Const (将向量的每个元素左移指定量的核心计算 - 常量). Its arguments are derived from ShiftLeft_Args (其参数来源于 ShiftLeft_Args).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~31 (有效范围是 1~31).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from ShiftLeft_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from ShiftLeft_Args .</param>
        /// <returns>A vector for each element after left shift (每个元素左移位后的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{int}, int)"/>
        /// <seealso cref="ShiftLeft(Vector512{int}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector512{int}, int, out Vector512{int})"/>
        Vector512<int> ShiftLeft_ConstCore(Vector512<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector512<int> args0, Vector512<int> args1);

        /// <summary>
        /// Core calculation for shifts each element of a vector left by the specified amount - Const (将向量的每个元素左移指定量的核心计算 - 常量). Its arguments are derived from ShiftLeft_Args (其参数来源于 ShiftLeft_Args).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~31 (有效范围是 1~31).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from ShiftLeft_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from ShiftLeft_Args .</param>
        /// <returns>A vector for each element after left shift (每个元素左移位后的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{uint}, int)"/>
        /// <seealso cref="ShiftLeft(Vector512{uint}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector512{uint}, int, out Vector512{uint})"/>
        Vector512<uint> ShiftLeft_ConstCore(Vector512<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector512<uint> args0, Vector512<uint> args1);

        /// <summary>
        /// Core calculation for shifts each element of a vector left by the specified amount - Const (将向量的每个元素左移指定量的核心计算 - 常量). Its arguments are derived from ShiftLeft_Args (其参数来源于 ShiftLeft_Args).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~63 (有效范围是 1~63).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from ShiftLeft_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from ShiftLeft_Args .</param>
        /// <returns>A vector for each element after left shift (每个元素左移位后的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{long}, int)"/>
        /// <seealso cref="ShiftLeft(Vector512{long}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector512{long}, int, out Vector512{long})"/>
        Vector512<long> ShiftLeft_ConstCore(Vector512<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector512<long> args0, Vector512<long> args1);

        /// <summary>
        /// Core calculation for shifts each element of a vector left by the specified amount - Const (将向量的每个元素左移指定量的核心计算 - 常量). Its arguments are derived from ShiftLeft_Args (其参数来源于 ShiftLeft_Args).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~63 (有效范围是 1~63).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from ShiftLeft_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from ShiftLeft_Args .</param>
        /// <returns>A vector for each element after left shift (每个元素左移位后的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{ulong}, int)"/>
        /// <seealso cref="ShiftLeft(Vector512{ulong}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector512{ulong}, int, out Vector512{ulong})"/>
        Vector512<ulong> ShiftLeft_ConstCore(Vector512<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector512<ulong> args0, Vector512<ulong> args1);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~7 (有效范围是 0~7).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{sbyte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector512{sbyte}, int)"/>
        Vector512<sbyte> ShiftLeft_Fast(Vector512<sbyte> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~7 (有效范围是 0~7).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{byte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector512{byte}, int)"/>
        Vector512<byte> ShiftLeft_Fast(Vector512<byte> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~15 (有效范围是 0~15).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector512{short}, int)"/>
        Vector512<short> ShiftLeft_Fast(Vector512<short> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~15 (有效范围是 0~15).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{ushort}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector512{ushort}, int)"/>
        Vector512<ushort> ShiftLeft_Fast(Vector512<ushort> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~31 (有效范围是 0~31).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector512{int}, int)"/>
        Vector512<int> ShiftLeft_Fast(Vector512<int> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~31 (有效范围是 0~31).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{uint}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector512{uint}, int)"/>
        Vector512<uint> ShiftLeft_Fast(Vector512<uint> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~63 (有效范围是 0~63).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{long}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector512{long}, int)"/>
        Vector512<long> ShiftLeft_Fast(Vector512<long> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~63 (有效范围是 0~63).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftLeft(Vector512{ulong}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector512{ulong}, int)"/>
        Vector512<ulong> ShiftLeft_Fast(Vector512<ulong> value, int shiftAmount);


        /// <summary>
        /// Types with hardware acceleration when running <c>ShiftRightArithmetic</c> (运行 <c>ShiftRightArithmetic</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Args: Arguments calculation. Provide arguments for ShiftRightArithmetic_Core (参数计算. 为 ShiftRightArithmetic_Core 提供参数).</para>
        /// <para>- Core. Core calculation. Its arguments are derived from ShiftRightArithmetic_Args (核心计算. 其参数来源于 ShiftRightArithmetic_Args).</para>
        /// <para>- Const: Constant version. This version can be used if you can ensure that the parameters are constants. It can take advantage of constants and make better use of hardware acceleration (常量版. 若能确保参数是常量, 可使用该版本. 它能利用常量, 更好的使用硬件加速).</para>
        /// <para>- ConstCore: Core calculation of constant version. Its arguments are derived from ShiftRightArithmetic_Args (常量版的核心计算. 其参数来源于 ShiftRightArithmetic_Args).</para>
        /// <para>- Fast: Fast version. This version can be used if you can ensure that the parameter variables are always in the valid range (快速版. 若能确保参数变量总是在有效范围内的, 可使用该版本).</para>
        /// </remarks>
        /// <seealso cref="ShiftRightArithmetic(Vector512{sbyte}, int)"/>
        /// <seealso cref="ShiftRightArithmetic_Args(Vector512{sbyte}, int, out Vector512{sbyte})"/>
        /// <seealso cref="ShiftRightArithmetic_Core(Vector512{sbyte}, int, Vector512{sbyte}, Vector512{sbyte})"/>
        /// <seealso cref="ShiftRightArithmetic_Const(Vector512{sbyte}, int)"/>
        /// <seealso cref="ShiftRightArithmetic_ConstCore(Vector512{sbyte}, int, Vector512{sbyte}, Vector512{sbyte})"/>
        /// <seealso cref="ShiftRightArithmetic_Fast(Vector512{sbyte}, int)"/>
        TypeCodeFlags ShiftRightArithmetic_AcceleratedTypes { get; }

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightArithmetic(Vector512{sbyte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic_Fast(Vector512{sbyte}, int)"/>
        Vector512<sbyte> ShiftRightArithmetic(Vector512<sbyte> value, int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightArithmetic(Vector512{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic_Fast(Vector512{short}, int)"/>
        Vector512<short> ShiftRightArithmetic(Vector512<short> value, int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightArithmetic(Vector512{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic_Fast(Vector512{int}, int)"/>
        Vector512<int> ShiftRightArithmetic(Vector512<int> value, int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightArithmetic(Vector512{long}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic_Fast(Vector512{long}, int)"/>
        Vector512<long> ShiftRightArithmetic(Vector512<long> value, int shiftAmount);

        /// <summary>
        /// Arguments calculation for shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量的参数计算). Provide arguments for ShiftRightArithmetic_Core (为 ShiftRightArithmetic_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftRightArithmetic_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftRightArithmetic_Core .</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightArithmetic(Vector512{sbyte}, int)"/>
        /// <seealso cref="ShiftRightArithmetic(Vector512{sbyte}, int)"/>
        /// <seealso cref="ShiftRightArithmetic_Core(Vector512{sbyte}, int, Vector512{sbyte}, Vector512{sbyte})"/>
        Vector512<sbyte> ShiftRightArithmetic_Args(Vector512<sbyte> dummy, int shiftAmount, out Vector512<sbyte> args1);

        /// <summary>
        /// Arguments calculation for shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量的参数计算). Provide arguments for ShiftRightArithmetic_Core (为 ShiftRightArithmetic_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftRightArithmetic_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftRightArithmetic_Core .</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightArithmetic(Vector512{short}, int)"/>
        /// <seealso cref="ShiftRightArithmetic(Vector512{short}, int)"/>
        /// <seealso cref="ShiftRightArithmetic_Core(Vector512{short}, int, Vector512{short}, Vector512{short})"/>
        Vector512<short> ShiftRightArithmetic_Args(Vector512<short> dummy, int shiftAmount, out Vector512<short> args1);

        /// <summary>
        /// Arguments calculation for shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量的参数计算). Provide arguments for ShiftRightArithmetic_Core (为 ShiftRightArithmetic_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftRightArithmetic_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftRightArithmetic_Core .</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightArithmetic(Vector512{int}, int)"/>
        /// <seealso cref="ShiftRightArithmetic(Vector512{int}, int)"/>
        /// <seealso cref="ShiftRightArithmetic_Core(Vector512{int}, int, Vector512{int}, Vector512{int})"/>
        Vector512<int> ShiftRightArithmetic_Args(Vector512<int> dummy, int shiftAmount, out Vector512<int> args1);

        /// <summary>
        /// Arguments calculation for shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量的参数计算). Provide arguments for ShiftRightArithmetic_Core (为 ShiftRightArithmetic_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftRightArithmetic_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftRightArithmetic_Core .</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightArithmetic(Vector512{long}, int)"/>
        /// <seealso cref="ShiftRightArithmetic(Vector512{long}, int)"/>
        /// <seealso cref="ShiftRightArithmetic_Core(Vector512{long}, int, Vector512{long}, Vector512{long})"/>
        Vector512<long> ShiftRightArithmetic_Args(Vector512<long> dummy, int shiftAmount, out Vector512<long> args1);

        /// <summary>
        /// Core calculation for shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量的核心计算). Its arguments are derived from ShiftRightArithmetic_Args (其参数来源于 ShiftRightArithmetic_Args).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from ShiftRightArithmetic_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from ShiftRightArithmetic_Args .</param>
        /// <returns>A vector for each element after shift right (每个元素右移位后的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightArithmetic(Vector512{sbyte}, int)"/>
        /// <seealso cref="ShiftRightArithmetic(Vector512{sbyte}, int)"/>
        /// <seealso cref="ShiftRightArithmetic_Args(Vector512{sbyte}, int, out Vector512{sbyte})"/>
        Vector512<sbyte> ShiftRightArithmetic_Core(Vector512<sbyte> value, int shiftAmount, Vector512<sbyte> args0, Vector512<sbyte> args1);

        /// <summary>
        /// Core calculation for shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量的核心计算). Its arguments are derived from ShiftRightArithmetic_Args (其参数来源于 ShiftRightArithmetic_Args).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from ShiftRightArithmetic_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from ShiftRightArithmetic_Args .</param>
        /// <returns>A vector for each element after shift right (每个元素右移位后的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightArithmetic(Vector512{short}, int)"/>
        /// <seealso cref="ShiftRightArithmetic(Vector512{short}, int)"/>
        /// <seealso cref="ShiftRightArithmetic_Args(Vector512{short}, int, out Vector512{short})"/>
        Vector512<short> ShiftRightArithmetic_Core(Vector512<short> value, int shiftAmount, Vector512<short> args0, Vector512<short> args1);

        /// <summary>
        /// Core calculation for shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量的核心计算). Its arguments are derived from ShiftRightArithmetic_Args (其参数来源于 ShiftRightArithmetic_Args).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from ShiftRightArithmetic_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from ShiftRightArithmetic_Args .</param>
        /// <returns>A vector for each element after shift right (每个元素右移位后的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightArithmetic(Vector512{int}, int)"/>
        /// <seealso cref="ShiftRightArithmetic(Vector512{int}, int)"/>
        /// <seealso cref="ShiftRightArithmetic_Args(Vector512{int}, int, out Vector512{int})"/>
        Vector512<int> ShiftRightArithmetic_Core(Vector512<int> value, int shiftAmount, Vector512<int> args0, Vector512<int> args1);

        /// <summary>
        /// Core calculation for shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量的核心计算). Its arguments are derived from ShiftRightArithmetic_Args (其参数来源于 ShiftRightArithmetic_Args).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from ShiftRightArithmetic_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from ShiftRightArithmetic_Args .</param>
        /// <returns>A vector for each element after shift right (每个元素右移位后的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightArithmetic(Vector512{long}, int)"/>
        /// <seealso cref="ShiftRightArithmetic(Vector512{long}, int)"/>
        /// <seealso cref="ShiftRightArithmetic_Args(Vector512{long}, int, out Vector512{long})"/>
        Vector512<long> ShiftRightArithmetic_Core(Vector512<long> value, int shiftAmount, Vector512<long> args0, Vector512<long> args1);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount - Const(将向量的每个有符号元素算术右移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~7 (有效范围是 1~7).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightArithmetic(Vector512{sbyte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic(Vector512{sbyte}, int)"/>
        Vector512<sbyte> ShiftRightArithmetic_Const(Vector512<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount - Const(将向量的每个有符号元素算术右移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~15 (有效范围是 1~15).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightArithmetic(Vector512{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic(Vector512{short}, int)"/>
        Vector512<short> ShiftRightArithmetic_Const(Vector512<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount - Const(将向量的每个有符号元素算术右移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~31 (有效范围是 1~31).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightArithmetic(Vector512{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic(Vector512{int}, int)"/>
        Vector512<int> ShiftRightArithmetic_Const(Vector512<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount - Const(将向量的每个有符号元素算术右移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~63 (有效范围是 1~63).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightArithmetic(Vector512{long}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic(Vector512{long}, int)"/>
        Vector512<long> ShiftRightArithmetic_Const(Vector512<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount);

        /// <summary>
        /// Core calculation for shifts (signed) each element of a vector right by the specified amount - Const (将向量的每个有符号元素算术右移指定量的核心计算 - 常量). Its arguments are derived from ShiftRightArithmetic_Args (其参数来源于 ShiftRightArithmetic_Args).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~7 (有效范围是 1~7).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from ShiftRightArithmetic_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from ShiftRightArithmetic_Args .</param>
        /// <returns>A vector for each element after shift right (每个元素右移位后的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightArithmetic(Vector512{sbyte}, int)"/>
        /// <seealso cref="ShiftRightArithmetic(Vector512{sbyte}, int)"/>
        /// <seealso cref="ShiftRightArithmetic_Args(Vector512{sbyte}, int, out Vector512{sbyte})"/>
        Vector512<sbyte> ShiftRightArithmetic_ConstCore(Vector512<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector512<sbyte> args0, Vector512<sbyte> args1);

        /// <summary>
        /// Core calculation for shifts (signed) each element of a vector right by the specified amount - Const (将向量的每个有符号元素算术右移指定量的核心计算 - 常量). Its arguments are derived from ShiftRightArithmetic_Args (其参数来源于 ShiftRightArithmetic_Args).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~15 (有效范围是 1~15).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from ShiftRightArithmetic_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from ShiftRightArithmetic_Args .</param>
        /// <returns>A vector for each element after shift right (每个元素右移位后的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightArithmetic(Vector512{short}, int)"/>
        /// <seealso cref="ShiftRightArithmetic(Vector512{short}, int)"/>
        /// <seealso cref="ShiftRightArithmetic_Args(Vector512{short}, int, out Vector512{short})"/>
        Vector512<short> ShiftRightArithmetic_ConstCore(Vector512<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector512<short> args0, Vector512<short> args1);

        /// <summary>
        /// Core calculation for shifts (signed) each element of a vector right by the specified amount - Const (将向量的每个有符号元素算术右移指定量的核心计算 - 常量). Its arguments are derived from ShiftRightArithmetic_Args (其参数来源于 ShiftRightArithmetic_Args).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~31 (有效范围是 1~31).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from ShiftRightArithmetic_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from ShiftRightArithmetic_Args .</param>
        /// <returns>A vector for each element after shift right (每个元素右移位后的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightArithmetic(Vector512{int}, int)"/>
        /// <seealso cref="ShiftRightArithmetic(Vector512{int}, int)"/>
        /// <seealso cref="ShiftRightArithmetic_Args(Vector512{int}, int, out Vector512{int})"/>
        Vector512<int> ShiftRightArithmetic_ConstCore(Vector512<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector512<int> args0, Vector512<int> args1);

        /// <summary>
        /// Core calculation for shifts (signed) each element of a vector right by the specified amount - Const (将向量的每个有符号元素算术右移指定量的核心计算 - 常量). Its arguments are derived from ShiftRightArithmetic_Args (其参数来源于 ShiftRightArithmetic_Args).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~63 (有效范围是 1~63).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from ShiftRightArithmetic_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from ShiftRightArithmetic_Args .</param>
        /// <returns>A vector for each element after shift right (每个元素右移位后的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightArithmetic(Vector512{long}, int)"/>
        /// <seealso cref="ShiftRightArithmetic(Vector512{long}, int)"/>
        /// <seealso cref="ShiftRightArithmetic_Args(Vector512{long}, int, out Vector512{long})"/>
        Vector512<long> ShiftRightArithmetic_ConstCore(Vector512<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector512<long> args0, Vector512<long> args1);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount - Fast(将向量的每个有符号元素算术右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~7 (有效范围是 0~7).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightArithmetic(Vector512{sbyte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic(Vector512{sbyte}, int)"/>
        Vector512<sbyte> ShiftRightArithmetic_Fast(Vector512<sbyte> value, int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount - Fast(将向量的每个有符号元素算术右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~15 (有效范围是 0~15).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightArithmetic(Vector512{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic(Vector512{short}, int)"/>
        Vector512<short> ShiftRightArithmetic_Fast(Vector512<short> value, int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount - Fast(将向量的每个有符号元素算术右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~31 (有效范围是 0~31).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightArithmetic(Vector512{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic(Vector512{int}, int)"/>
        Vector512<int> ShiftRightArithmetic_Fast(Vector512<int> value, int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount - Fast(将向量的每个有符号元素算术右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~63 (有效范围是 0~63).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightArithmetic(Vector512{long}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic(Vector512{long}, int)"/>
        Vector512<long> ShiftRightArithmetic_Fast(Vector512<long> value, int shiftAmount);


        /// <summary>
        /// Types with hardware acceleration when running <c>ShiftRightLogical</c> (运行 <c>ShiftRightLogical</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Args: Arguments calculation. Provide arguments for ShiftRightLogical_Core (参数计算. 为 ShiftRightLogical_Core 提供参数).</para>
        /// <para>- Core. Core calculation. Its arguments are derived from ShiftRightLogical_Args (核心计算. 其参数来源于 ShiftRightLogical_Args).</para>
        /// <para>- Const: Constant version. This version can be used if you can ensure that the parameters are constants. It can take advantage of constants and make better use of hardware acceleration (常量版. 若能确保参数是常量, 可使用该版本. 它能利用常量, 更好的使用硬件加速).</para>
        /// <para>- ConstCore: Core calculation of constant version. Its arguments are derived from ShiftRightLogical_Args (常量版的核心计算. 其参数来源于 ShiftRightLogical_Args).</para>
        /// <para>- Fast: Fast version. This version can be used if you can ensure that the parameter variables are always in the valid range (快速版. 若能确保参数变量总是在有效范围内的, 可使用该版本).</para>
        /// </remarks>
        /// <seealso cref="ShiftRightLogical(Vector512{byte}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector512{byte}, int, out Vector512{byte})"/>
        /// <seealso cref="ShiftRightLogical_Core(Vector512{byte}, int, Vector512{byte}, Vector512{byte})"/>
        /// <seealso cref="ShiftRightLogical_Const(Vector512{byte}, int)"/>
        /// <seealso cref="ShiftRightLogical_ConstCore(Vector512{byte}, int, Vector512{byte}, Vector512{byte})"/>
        /// <seealso cref="ShiftRightLogical_Fast(Vector512{byte}, int)"/>
        TypeCodeFlags ShiftRightLogical_AcceleratedTypes { get; }

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{sbyte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical_Fast(Vector512{sbyte}, int)"/>
        Vector512<sbyte> ShiftRightLogical(Vector512<sbyte> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{byte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical_Fast(Vector512{byte}, int)"/>
        Vector512<byte> ShiftRightLogical(Vector512<byte> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical_Fast(Vector512{short}, int)"/>
        Vector512<short> ShiftRightLogical(Vector512<short> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{ushort}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical_Fast(Vector512{ushort}, int)"/>
        Vector512<ushort> ShiftRightLogical(Vector512<ushort> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical_Fast(Vector512{int}, int)"/>
        Vector512<int> ShiftRightLogical(Vector512<int> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{uint}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical_Fast(Vector512{uint}, int)"/>
        Vector512<uint> ShiftRightLogical(Vector512<uint> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{long}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical_Fast(Vector512{long}, int)"/>
        Vector512<long> ShiftRightLogical(Vector512<long> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{ulong}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical_Fast(Vector512{ulong}, int)"/>
        Vector512<ulong> ShiftRightLogical(Vector512<ulong> value, int shiftAmount);

        /// <summary>
        /// Arguments calculation for shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量的参数计算). Provide arguments for ShiftRightLogical_Core (为 ShiftRightLogical_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftRightLogical_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftRightLogical_Core .</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{sbyte}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector512{sbyte}, int)"/>
        /// <seealso cref="ShiftRightLogical_Core(Vector512{sbyte}, int, Vector512{sbyte}, Vector512{sbyte})"/>
        Vector512<sbyte> ShiftRightLogical_Args(Vector512<sbyte> dummy, int shiftAmount, out Vector512<sbyte> args1);

        /// <summary>
        /// Arguments calculation for shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量的参数计算). Provide arguments for ShiftRightLogical_Core (为 ShiftRightLogical_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftRightLogical_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftRightLogical_Core .</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{byte}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector512{byte}, int)"/>
        /// <seealso cref="ShiftRightLogical_Core(Vector512{byte}, int, Vector512{byte}, Vector512{byte})"/>
        Vector512<byte> ShiftRightLogical_Args(Vector512<byte> dummy, int shiftAmount, out Vector512<byte> args1);

        /// <summary>
        /// Arguments calculation for shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量的参数计算). Provide arguments for ShiftRightLogical_Core (为 ShiftRightLogical_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftRightLogical_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftRightLogical_Core .</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{short}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector512{short}, int)"/>
        /// <seealso cref="ShiftRightLogical_Core(Vector512{short}, int, Vector512{short}, Vector512{short})"/>
        Vector512<short> ShiftRightLogical_Args(Vector512<short> dummy, int shiftAmount, out Vector512<short> args1);

        /// <summary>
        /// Arguments calculation for shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量的参数计算). Provide arguments for ShiftRightLogical_Core (为 ShiftRightLogical_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftRightLogical_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftRightLogical_Core .</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{ushort}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector512{ushort}, int)"/>
        /// <seealso cref="ShiftRightLogical_Core(Vector512{ushort}, int, Vector512{ushort}, Vector512{ushort})"/>
        Vector512<ushort> ShiftRightLogical_Args(Vector512<ushort> dummy, int shiftAmount, out Vector512<ushort> args1);

        /// <summary>
        /// Arguments calculation for shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量的参数计算). Provide arguments for ShiftRightLogical_Core (为 ShiftRightLogical_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftRightLogical_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftRightLogical_Core .</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{int}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector512{int}, int)"/>
        /// <seealso cref="ShiftRightLogical_Core(Vector512{int}, int, Vector512{int}, Vector512{int})"/>
        Vector512<int> ShiftRightLogical_Args(Vector512<int> dummy, int shiftAmount, out Vector512<int> args1);

        /// <summary>
        /// Arguments calculation for shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量的参数计算). Provide arguments for ShiftRightLogical_Core (为 ShiftRightLogical_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftRightLogical_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftRightLogical_Core .</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{uint}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector512{uint}, int)"/>
        /// <seealso cref="ShiftRightLogical_Core(Vector512{uint}, int, Vector512{uint}, Vector512{uint})"/>
        Vector512<uint> ShiftRightLogical_Args(Vector512<uint> dummy, int shiftAmount, out Vector512<uint> args1);

        /// <summary>
        /// Arguments calculation for shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量的参数计算). Provide arguments for ShiftRightLogical_Core (为 ShiftRightLogical_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftRightLogical_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftRightLogical_Core .</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{long}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector512{long}, int)"/>
        /// <seealso cref="ShiftRightLogical_Core(Vector512{long}, int, Vector512{long}, Vector512{long})"/>
        Vector512<long> ShiftRightLogical_Args(Vector512<long> dummy, int shiftAmount, out Vector512<long> args1);

        /// <summary>
        /// Arguments calculation for shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量的参数计算). Provide arguments for ShiftRightLogical_Core (为 ShiftRightLogical_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftRightLogical_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftRightLogical_Core .</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{ulong}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector512{ulong}, int)"/>
        /// <seealso cref="ShiftRightLogical_Core(Vector512{ulong}, int, Vector512{ulong}, Vector512{ulong})"/>
        Vector512<ulong> ShiftRightLogical_Args(Vector512<ulong> dummy, int shiftAmount, out Vector512<ulong> args1);

        /// <summary>
        /// Core calculation for shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量的核心计算). Its arguments are derived from ShiftRightLogical_Args (其参数来源于 ShiftRightLogical_Args).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from ShiftRightLogical_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from ShiftRightLogical_Args .</param>
        /// <returns>A vector for each element after shift right (每个元素右移位后的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{sbyte}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector512{sbyte}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector512{sbyte}, int, out Vector512{sbyte})"/>
        Vector512<sbyte> ShiftRightLogical_Core(Vector512<sbyte> value, int shiftAmount, Vector512<sbyte> args0, Vector512<sbyte> args1);

        /// <summary>
        /// Core calculation for shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量的核心计算). Its arguments are derived from ShiftRightLogical_Args (其参数来源于 ShiftRightLogical_Args).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from ShiftRightLogical_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from ShiftRightLogical_Args .</param>
        /// <returns>A vector for each element after shift right (每个元素右移位后的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{byte}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector512{byte}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector512{byte}, int, out Vector512{byte})"/>
        Vector512<byte> ShiftRightLogical_Core(Vector512<byte> value, int shiftAmount, Vector512<byte> args0, Vector512<byte> args1);

        /// <summary>
        /// Core calculation for shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量的核心计算). Its arguments are derived from ShiftRightLogical_Args (其参数来源于 ShiftRightLogical_Args).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from ShiftRightLogical_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from ShiftRightLogical_Args .</param>
        /// <returns>A vector for each element after shift right (每个元素右移位后的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{short}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector512{short}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector512{short}, int, out Vector512{short})"/>
        Vector512<short> ShiftRightLogical_Core(Vector512<short> value, int shiftAmount, Vector512<short> args0, Vector512<short> args1);

        /// <summary>
        /// Core calculation for shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量的核心计算). Its arguments are derived from ShiftRightLogical_Args (其参数来源于 ShiftRightLogical_Args).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from ShiftRightLogical_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from ShiftRightLogical_Args .</param>
        /// <returns>A vector for each element after shift right (每个元素右移位后的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{ushort}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector512{ushort}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector512{ushort}, int, out Vector512{ushort})"/>
        Vector512<ushort> ShiftRightLogical_Core(Vector512<ushort> value, int shiftAmount, Vector512<ushort> args0, Vector512<ushort> args1);

        /// <summary>
        /// Core calculation for shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量的核心计算). Its arguments are derived from ShiftRightLogical_Args (其参数来源于 ShiftRightLogical_Args).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from ShiftRightLogical_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from ShiftRightLogical_Args .</param>
        /// <returns>A vector for each element after shift right (每个元素右移位后的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{int}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector512{int}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector512{int}, int, out Vector512{int})"/>
        Vector512<int> ShiftRightLogical_Core(Vector512<int> value, int shiftAmount, Vector512<int> args0, Vector512<int> args1);

        /// <summary>
        /// Core calculation for shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量的核心计算). Its arguments are derived from ShiftRightLogical_Args (其参数来源于 ShiftRightLogical_Args).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from ShiftRightLogical_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from ShiftRightLogical_Args .</param>
        /// <returns>A vector for each element after shift right (每个元素右移位后的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{uint}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector512{uint}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector512{uint}, int, out Vector512{uint})"/>
        Vector512<uint> ShiftRightLogical_Core(Vector512<uint> value, int shiftAmount, Vector512<uint> args0, Vector512<uint> args1);

        /// <summary>
        /// Core calculation for shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量的核心计算). Its arguments are derived from ShiftRightLogical_Args (其参数来源于 ShiftRightLogical_Args).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from ShiftRightLogical_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from ShiftRightLogical_Args .</param>
        /// <returns>A vector for each element after shift right (每个元素右移位后的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{long}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector512{long}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector512{long}, int, out Vector512{long})"/>
        Vector512<long> ShiftRightLogical_Core(Vector512<long> value, int shiftAmount, Vector512<long> args0, Vector512<long> args1);

        /// <summary>
        /// Core calculation for shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量的核心计算). Its arguments are derived from ShiftRightLogical_Args (其参数来源于 ShiftRightLogical_Args).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from ShiftRightLogical_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from ShiftRightLogical_Args .</param>
        /// <returns>A vector for each element after shift right (每个元素右移位后的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{ulong}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector512{ulong}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector512{ulong}, int, out Vector512{ulong})"/>
        Vector512<ulong> ShiftRightLogical_Core(Vector512<ulong> value, int shiftAmount, Vector512<ulong> args0, Vector512<ulong> args1);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount - Const (将向量的每个无符号元素逻辑右移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~7 (有效范围是 1~7).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{sbyte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector512{sbyte}, int)"/>
        Vector512<sbyte> ShiftRightLogical_Const(Vector512<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount - Const (将向量的每个无符号元素逻辑右移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~7 (有效范围是 1~7).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{byte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector512{byte}, int)"/>
        Vector512<byte> ShiftRightLogical_Const(Vector512<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount - Const (将向量的每个无符号元素逻辑右移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~15 (有效范围是 1~15).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector512{short}, int)"/>
        Vector512<short> ShiftRightLogical_Const(Vector512<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount - Const (将向量的每个无符号元素逻辑右移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~15 (有效范围是 1~15).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{ushort}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector512{ushort}, int)"/>
        Vector512<ushort> ShiftRightLogical_Const(Vector512<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount - Const (将向量的每个无符号元素逻辑右移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~31 (有效范围是 1~31).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector512{int}, int)"/>
        Vector512<int> ShiftRightLogical_Const(Vector512<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount - Const (将向量的每个无符号元素逻辑右移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~31 (有效范围是 1~31).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{uint}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector512{uint}, int)"/>
        Vector512<uint> ShiftRightLogical_Const(Vector512<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount - Const (将向量的每个无符号元素逻辑右移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~63 (有效范围是 1~63).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{long}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector512{long}, int)"/>
        Vector512<long> ShiftRightLogical_Const(Vector512<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount - Const (将向量的每个无符号元素逻辑右移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~63 (有效范围是 1~63).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{ulong}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector512{ulong}, int)"/>
        Vector512<ulong> ShiftRightLogical_Const(Vector512<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount);

        /// <summary>
        /// Core calculation for shifts (unsigned) each element of a vector right by the specified amount - Const (将向量的每个无符号元素逻辑右移指定量的核心计算 - 常量). Its arguments are derived from ShiftRightLogical_Args (其参数来源于 ShiftRightLogical_Args).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~7 (有效范围是 1~7).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from ShiftRightLogical_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from ShiftRightLogical_Args .</param>
        /// <returns>A vector for each element after shift right (每个元素右移位后的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{sbyte}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector512{sbyte}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector512{sbyte}, int, out Vector512{sbyte})"/>
        Vector512<sbyte> ShiftRightLogical_ConstCore(Vector512<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector512<sbyte> args0, Vector512<sbyte> args1);

        /// <summary>
        /// Core calculation for shifts (unsigned) each element of a vector right by the specified amount - Const (将向量的每个无符号元素逻辑右移指定量的核心计算 - 常量). Its arguments are derived from ShiftRightLogical_Args (其参数来源于 ShiftRightLogical_Args).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~7 (有效范围是 1~7).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from ShiftRightLogical_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from ShiftRightLogical_Args .</param>
        /// <returns>A vector for each element after shift right (每个元素右移位后的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{byte}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector512{byte}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector512{byte}, int, out Vector512{byte})"/>
        Vector512<byte> ShiftRightLogical_ConstCore(Vector512<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector512<byte> args0, Vector512<byte> args1);

        /// <summary>
        /// Core calculation for shifts (unsigned) each element of a vector right by the specified amount - Const (将向量的每个无符号元素逻辑右移指定量的核心计算 - 常量). Its arguments are derived from ShiftRightLogical_Args (其参数来源于 ShiftRightLogical_Args).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~15 (有效范围是 1~15).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from ShiftRightLogical_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from ShiftRightLogical_Args .</param>
        /// <returns>A vector for each element after shift right (每个元素右移位后的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{short}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector512{short}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector512{short}, int, out Vector512{short})"/>
        Vector512<short> ShiftRightLogical_ConstCore(Vector512<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector512<short> args0, Vector512<short> args1);

        /// <summary>
        /// Core calculation for shifts (unsigned) each element of a vector right by the specified amount - Const (将向量的每个无符号元素逻辑右移指定量的核心计算 - 常量). Its arguments are derived from ShiftRightLogical_Args (其参数来源于 ShiftRightLogical_Args).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~15 (有效范围是 1~15).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from ShiftRightLogical_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from ShiftRightLogical_Args .</param>
        /// <returns>A vector for each element after shift right (每个元素右移位后的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{ushort}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector512{ushort}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector512{ushort}, int, out Vector512{ushort})"/>
        Vector512<ushort> ShiftRightLogical_ConstCore(Vector512<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector512<ushort> args0, Vector512<ushort> args1);

        /// <summary>
        /// Core calculation for shifts (unsigned) each element of a vector right by the specified amount - Const (将向量的每个无符号元素逻辑右移指定量的核心计算 - 常量). Its arguments are derived from ShiftRightLogical_Args (其参数来源于 ShiftRightLogical_Args).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~31 (有效范围是 1~31).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from ShiftRightLogical_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from ShiftRightLogical_Args .</param>
        /// <returns>A vector for each element after shift right (每个元素右移位后的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{int}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector512{int}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector512{int}, int, out Vector512{int})"/>
        Vector512<int> ShiftRightLogical_ConstCore(Vector512<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector512<int> args0, Vector512<int> args1);

        /// <summary>
        /// Core calculation for shifts (unsigned) each element of a vector right by the specified amount - Const (将向量的每个无符号元素逻辑右移指定量的核心计算 - 常量). Its arguments are derived from ShiftRightLogical_Args (其参数来源于 ShiftRightLogical_Args).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~31 (有效范围是 1~31).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from ShiftRightLogical_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from ShiftRightLogical_Args .</param>
        /// <returns>A vector for each element after shift right (每个元素右移位后的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{uint}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector512{uint}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector512{uint}, int, out Vector512{uint})"/>
        Vector512<uint> ShiftRightLogical_ConstCore(Vector512<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector512<uint> args0, Vector512<uint> args1);

        /// <summary>
        /// Core calculation for shifts (unsigned) each element of a vector right by the specified amount - Const (将向量的每个无符号元素逻辑右移指定量的核心计算 - 常量). Its arguments are derived from ShiftRightLogical_Args (其参数来源于 ShiftRightLogical_Args).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~63 (有效范围是 1~63).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from ShiftRightLogical_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from ShiftRightLogical_Args .</param>
        /// <returns>A vector for each element after shift right (每个元素右移位后的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{long}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector512{long}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector512{long}, int, out Vector512{long})"/>
        Vector512<long> ShiftRightLogical_ConstCore(Vector512<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector512<long> args0, Vector512<long> args1);

        /// <summary>
        /// Core calculation for shifts (unsigned) each element of a vector right by the specified amount - Const (将向量的每个无符号元素逻辑右移指定量的核心计算 - 常量). Its arguments are derived from ShiftRightLogical_Args (其参数来源于 ShiftRightLogical_Args).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~63 (有效范围是 1~63).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from ShiftRightLogical_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from ShiftRightLogical_Args .</param>
        /// <returns>A vector for each element after shift right (每个元素右移位后的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{ulong}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector512{ulong}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector512{ulong}, int, out Vector512{ulong})"/>
        Vector512<ulong> ShiftRightLogical_ConstCore(Vector512<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector512<ulong> args0, Vector512<ulong> args1);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~7 (有效范围是 0~7).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{sbyte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector512{sbyte}, int)"/>
        Vector512<sbyte> ShiftRightLogical_Fast(Vector512<sbyte> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~7 (有效范围是 0~7).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{byte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector512{byte}, int)"/>
        Vector512<byte> ShiftRightLogical_Fast(Vector512<byte> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~15 (有效范围是 0~15).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector512{short}, int)"/>
        Vector512<short> ShiftRightLogical_Fast(Vector512<short> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~15 (有效范围是 0~15).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{ushort}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector512{ushort}, int)"/>
        Vector512<ushort> ShiftRightLogical_Fast(Vector512<ushort> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~31 (有效范围是 0~31).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector512{int}, int)"/>
        Vector512<int> ShiftRightLogical_Fast(Vector512<int> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~31 (有效范围是 0~31).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{uint}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector512{uint}, int)"/>
        Vector512<uint> ShiftRightLogical_Fast(Vector512<uint> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~63 (有效范围是 0~63).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{long}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector512{long}, int)"/>
        Vector512<long> ShiftRightLogical_Fast(Vector512<long> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~63 (有效范围是 0~63).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector512.ShiftRightLogical(Vector512{ulong}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector512{ulong}, int)"/>
        Vector512<ulong> ShiftRightLogical_Fast(Vector512<ulong> value, int shiftAmount);


        /// <summary>
        /// Types with hardware acceleration when running <c>Shuffle</c> (运行 <c>Shuffle</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Args: Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数).</para>
        /// <para>- Core. Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="Shuffle(Vector512{byte}, Vector512{byte})"/>: If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).</para>
        /// <para>- <see cref="YShuffleInsert(Vector512{byte}, Vector512{byte}, Vector512{byte})"/>: If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).</para>
        /// <para>- <see cref="YShuffleKernel(Vector512{byte}, Vector512{byte})"/>: If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). It has the best performance, and is used when you are sure that the index value is not out of range (它的性能最好, 用于确信索引值不会超出范围时).</para>
        /// </remarks>
        /// <seealso cref="Shuffle(Vector512{byte}, Vector512{byte})"/>
        /// <seealso cref="Shuffle_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
        /// <seealso cref="Shuffle_Core(Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        TypeCodeFlags Shuffle_AcceleratedTypes { get; }

        /// <summary>
        /// Shuffle and clear (换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Vector512.Shuffle(Vector512{float}, Vector512{int})"/>
        /// <seealso cref="Avx2.PermuteVar8x32(Vector512{float}, Vector512{int})"/>
        Vector512<float> Shuffle(Vector512<float> vector, Vector512<int> indices);

        /// <summary>
        /// Shuffle and clear (换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Vector512.Shuffle(Vector512{double}, Vector512{long})"/>
        Vector512<double> Shuffle(Vector512<double> vector, Vector512<long> indices);

        /// <summary>
        /// Shuffle and clear (换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Vector512.Shuffle(Vector512{sbyte}, Vector512{sbyte})"/>
        /// <seealso cref="Avx2.Shuffle(Vector512{sbyte}, Vector512{sbyte})"/>
        Vector512<sbyte> Shuffle(Vector512<sbyte> vector, Vector512<sbyte> indices);

        /// <summary>
        /// Shuffle and clear (换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Vector512.Shuffle(Vector512{byte}, Vector512{byte})"/>
        /// <seealso cref="Avx2.Shuffle(Vector512{byte}, Vector512{byte})"/>
        Vector512<byte> Shuffle(Vector512<byte> vector, Vector512<byte> indices);

        /// <summary>
        /// Shuffle and clear (换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Vector512.Shuffle(Vector512{short}, Vector512{short})"/>
        Vector512<short> Shuffle(Vector512<short> vector, Vector512<short> indices);

        /// <summary>
        /// Shuffle and clear (换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Vector512.Shuffle(Vector512{ushort}, Vector512{ushort})"/>
        Vector512<ushort> Shuffle(Vector512<ushort> vector, Vector512<ushort> indices);

        /// <summary>
        /// Shuffle and clear (换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Vector512.Shuffle(Vector512{int}, Vector512{int})"/>
        /// <seealso cref="Avx2.PermuteVar8x32(Vector512{int}, Vector512{int})"/>
        Vector512<int> Shuffle(Vector512<int> vector, Vector512<int> indices);

        /// <summary>
        /// Shuffle and clear (换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Vector512.Shuffle(Vector512{uint}, Vector512{uint})"/>
        /// <seealso cref="Avx2.PermuteVar8x32(Vector512{uint}, Vector512{uint})"/>
        Vector512<uint> Shuffle(Vector512<uint> vector, Vector512<uint> indices);

        /// <summary>
        /// Shuffle and clear (换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Vector512.Shuffle(Vector512{long}, Vector512{long})"/>
        Vector512<long> Shuffle(Vector512<long> vector, Vector512<long> indices);

        /// <summary>
        /// Shuffle and clear (换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Vector512.Shuffle(Vector512{ulong}, Vector512{ulong})"/>
        Vector512<ulong> Shuffle(Vector512<ulong> vector, Vector512<ulong> indices);


        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for Shuffle_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for Shuffle_Core .</param>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        void Shuffle_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1);

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for Shuffle_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for Shuffle_Core .</param>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Core(Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        void Shuffle_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1);

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for Shuffle_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for Shuffle_Core .</param>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Core(Vector512{short}, Vector512{short}, Vector512{short})"/>
        void Shuffle_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1);

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for Shuffle_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for Shuffle_Core .</param>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        void Shuffle_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1);

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for Shuffle_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for Shuffle_Core .</param>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Core(Vector512{int}, Vector512{int}, Vector512{int})"/>
        void Shuffle_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1);

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for Shuffle_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for Shuffle_Core .</param>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Core(Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        void Shuffle_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1);

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for Shuffle_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for Shuffle_Core .</param>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Core(Vector512{long}, Vector512{long}, Vector512{long})"/>
        void Shuffle_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1);

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for Shuffle_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for Shuffle_Core .</param>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        void Shuffle_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1);


        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from Shuffle_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Args(Vector512{int}, out Vector512{int}, out Vector512{int})"/>
        /// <seealso cref="Avx2.PermuteVar8x32(Vector512{float}, Vector512{int})"/>
        Vector512<float> Shuffle_Core(Vector512<float> vector, Vector512<int> args0, Vector512<int> args1);

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from Shuffle_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Args(Vector512{long}, out Vector512{long}, out Vector512{long})"/>
        Vector512<double> Shuffle_Core(Vector512<double> vector, Vector512<long> args0, Vector512<long> args1);

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from Shuffle_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
        /// <seealso cref="Avx2.Shuffle(Vector512{sbyte}, Vector512{sbyte})"/>
        Vector512<sbyte> Shuffle_Core(Vector512<sbyte> vector, Vector512<sbyte> args0, Vector512<sbyte> args1);

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from Shuffle_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
        /// <seealso cref="Avx2.Shuffle(Vector512{byte}, Vector512{byte})"/>
        Vector512<byte> Shuffle_Core(Vector512<byte> vector, Vector512<byte> args0, Vector512<byte> args1);

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from Shuffle_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Args(Vector512{short}, out Vector512{short}, out Vector512{short})"/>
        Vector512<short> Shuffle_Core(Vector512<short> vector, Vector512<short> args0, Vector512<short> args1);

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from Shuffle_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
        Vector512<ushort> Shuffle_Core(Vector512<ushort> vector, Vector512<ushort> args0, Vector512<ushort> args1);

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from Shuffle_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Args(Vector512{int}, out Vector512{int}, out Vector512{int})"/>
        /// <seealso cref="Avx2.PermuteVar8x32(Vector512{int}, Vector512{int})"/>
        Vector512<int> Shuffle_Core(Vector512<int> vector, Vector512<int> args0, Vector512<int> args1);

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from Shuffle_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
        /// <seealso cref="Avx2.PermuteVar8x32(Vector512{uint}, Vector512{uint})"/>
        Vector512<uint> Shuffle_Core(Vector512<uint> vector, Vector512<uint> args0, Vector512<uint> args1);

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from Shuffle_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Args(Vector512{long}, out Vector512{long}, out Vector512{long})"/>
        Vector512<long> Shuffle_Core(Vector512<long> vector, Vector512<long> args0, Vector512<long> args1);

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from Shuffle_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
        Vector512<ulong> Shuffle_Core(Vector512<ulong> vector, Vector512<ulong> args0, Vector512<ulong> args1);


        /// <summary>
        /// Types with hardware acceleration when running <c>Sum</c> (运行 <c>Sum</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Sum(Vector512{byte})"/>
        TypeCodeFlags Sum_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the sum of all elements in a vector (计算向量中所有元素的总和).
        /// Mnemonic: <c>rt := value[0] + value[1] + value[2] + ... + value[Count-1]</c>.
        /// </summary>
        /// <param name="value">The vector whose elements will be summed (将对其元素求和的向量).</param>
        /// <returns>The sum of all elements in <paramref name="value" /> (<paramref name="value" /> 中所有元素的总和).</returns>
        /// <seealso cref="Sum_AcceleratedTypes"/>
        /// <seealso cref="Vector512.Sum{T}(Vector512{T})" />
        float Sum(Vector512<float> value);

        /// <summary>
        /// Computes the sum of all elements in a vector (计算向量中所有元素的总和).
        /// Mnemonic: <c>rt := value[0] + value[1] + value[2] + ... + value[Count-1]</c>.
        /// </summary>
        /// <param name="value">The vector whose elements will be summed (将对其元素求和的向量).</param>
        /// <returns>The sum of all elements in <paramref name="value" /> (<paramref name="value" /> 中所有元素的总和).</returns>
        /// <seealso cref="Sum_AcceleratedTypes"/>
        /// <seealso cref="Vector512.Sum{T}(Vector512{T})" />
        double Sum(Vector512<double> value);

        /// <summary>
        /// Computes the sum of all elements in a vector (计算向量中所有元素的总和).
        /// Mnemonic: <c>rt := value[0] + value[1] + value[2] + ... + value[Count-1]</c>.
        /// </summary>
        /// <param name="value">The vector whose elements will be summed (将对其元素求和的向量).</param>
        /// <returns>The sum of all elements in <paramref name="value" /> (<paramref name="value" /> 中所有元素的总和).</returns>
        /// <seealso cref="Sum_AcceleratedTypes"/>
        /// <seealso cref="Vector512.Sum{T}(Vector512{T})" />
        sbyte Sum(Vector512<sbyte> value);

        /// <summary>
        /// Computes the sum of all elements in a vector (计算向量中所有元素的总和).
        /// Mnemonic: <c>rt := value[0] + value[1] + value[2] + ... + value[Count-1]</c>.
        /// </summary>
        /// <param name="value">The vector whose elements will be summed (将对其元素求和的向量).</param>
        /// <returns>The sum of all elements in <paramref name="value" /> (<paramref name="value" /> 中所有元素的总和).</returns>
        /// <seealso cref="Sum_AcceleratedTypes"/>
        /// <seealso cref="Vector512.Sum{T}(Vector512{T})" />
        byte Sum(Vector512<byte> value);

        /// <summary>
        /// Computes the sum of all elements in a vector (计算向量中所有元素的总和).
        /// Mnemonic: <c>rt := value[0] + value[1] + value[2] + ... + value[Count-1]</c>.
        /// </summary>
        /// <param name="value">The vector whose elements will be summed (将对其元素求和的向量).</param>
        /// <returns>The sum of all elements in <paramref name="value" /> (<paramref name="value" /> 中所有元素的总和).</returns>
        /// <seealso cref="Sum_AcceleratedTypes"/>
        /// <seealso cref="Vector512.Sum{T}(Vector512{T})" />
        short Sum(Vector512<short> value);

        /// <summary>
        /// Computes the sum of all elements in a vector (计算向量中所有元素的总和).
        /// Mnemonic: <c>rt := value[0] + value[1] + value[2] + ... + value[Count-1]</c>.
        /// </summary>
        /// <param name="value">The vector whose elements will be summed (将对其元素求和的向量).</param>
        /// <returns>The sum of all elements in <paramref name="value" /> (<paramref name="value" /> 中所有元素的总和).</returns>
        /// <seealso cref="Sum_AcceleratedTypes"/>
        /// <seealso cref="Vector512.Sum{T}(Vector512{T})" />
        ushort Sum(Vector512<ushort> value);

        /// <summary>
        /// Computes the sum of all elements in a vector (计算向量中所有元素的总和).
        /// Mnemonic: <c>rt := value[0] + value[1] + value[2] + ... + value[Count-1]</c>.
        /// </summary>
        /// <param name="value">The vector whose elements will be summed (将对其元素求和的向量).</param>
        /// <returns>The sum of all elements in <paramref name="value" /> (<paramref name="value" /> 中所有元素的总和).</returns>
        /// <seealso cref="Sum_AcceleratedTypes"/>
        /// <seealso cref="Vector512.Sum{T}(Vector512{T})" />
        int Sum(Vector512<int> value);

        /// <summary>
        /// Computes the sum of all elements in a vector (计算向量中所有元素的总和).
        /// Mnemonic: <c>rt := value[0] + value[1] + value[2] + ... + value[Count-1]</c>.
        /// </summary>
        /// <param name="value">The vector whose elements will be summed (将对其元素求和的向量).</param>
        /// <returns>The sum of all elements in <paramref name="value" /> (<paramref name="value" /> 中所有元素的总和).</returns>
        /// <seealso cref="Sum_AcceleratedTypes"/>
        /// <seealso cref="Vector512.Sum{T}(Vector512{T})" />
        uint Sum(Vector512<uint> value);

        /// <summary>
        /// Computes the sum of all elements in a vector (计算向量中所有元素的总和).
        /// Mnemonic: <c>rt := value[0] + value[1] + value[2] + ... + value[Count-1]</c>.
        /// </summary>
        /// <param name="value">The vector whose elements will be summed (将对其元素求和的向量).</param>
        /// <returns>The sum of all elements in <paramref name="value" /> (<paramref name="value" /> 中所有元素的总和).</returns>
        /// <seealso cref="Sum_AcceleratedTypes"/>
        /// <seealso cref="Vector512.Sum{T}(Vector512{T})" />
        long Sum(Vector512<long> value);

        /// <summary>
        /// Computes the sum of all elements in a vector (计算向量中所有元素的总和).
        /// Mnemonic: <c>rt := value[0] + value[1] + value[2] + ... + value[Count-1]</c>.
        /// </summary>
        /// <param name="value">The vector whose elements will be summed (将对其元素求和的向量).</param>
        /// <returns>The sum of all elements in <paramref name="value" /> (<paramref name="value" /> 中所有元素的总和).</returns>
        /// <seealso cref="Sum_AcceleratedTypes"/>
        /// <seealso cref="Vector512.Sum{T}(Vector512{T})" />
        ulong Sum(Vector512<ulong> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>Widen</c> (运行 <c>Widen</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Widen(Vector512{byte}, out Vector512{ushort}, out Vector512{ushort})"/>
        TypeCodeFlags Widen_AcceleratedTypes { get; }

        /// <summary>
        /// Widens a <seealso cref="Vector512{T}"/> into two <seealso cref="Vector512{T}"/> instances (将一个 <seealso cref="Vector512{T}"/> 扩宽为两个 <seealso cref="Vector512{T}"/> 实例).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <param name="lower">When this method returns, contains the widened elements from lower indices in the source vector (当此方法返回时，包含源向量中来自较低下标的扩宽元素).</param>
        /// <param name="upper">When this method returns, contains the widened elements from upper indices in the source vector (当此方法返回时，包含源向量中来自较高下标的扩宽元素).</param>
        /// <seealso cref="Widen_AcceleratedTypes"/>
        /// <seealso cref="Vector512.Widen(Vector512{float})" />
        void Widen(Vector512<float> source, out Vector512<double> lower, out Vector512<double> upper);

        /// <summary>
        /// Widens a <seealso cref="Vector512{T}"/> into two <seealso cref="Vector512{T}"/> instances (将一个 <seealso cref="Vector512{T}"/> 扩宽为两个 <seealso cref="Vector512{T}"/> 实例).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <param name="lower">When this method returns, contains the widened elements from lower indices in the source vector (当此方法返回时，包含源向量中来自较低下标的扩宽元素).</param>
        /// <param name="upper">When this method returns, contains the widened elements from upper indices in the source vector (当此方法返回时，包含源向量中来自较高下标的扩宽元素).</param>
        /// <seealso cref="Widen_AcceleratedTypes"/>
        /// <seealso cref="Vector512.Widen(Vector512{sbyte})" />
        void Widen(Vector512<sbyte> source, out Vector512<short> lower, out Vector512<short> upper);

        /// <summary>
        /// Widens a <seealso cref="Vector512{T}"/> into two <seealso cref="Vector512{T}"/> instances (将一个 <seealso cref="Vector512{T}"/> 扩宽为两个 <seealso cref="Vector512{T}"/> 实例).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <param name="lower">When this method returns, contains the widened elements from lower indices in the source vector (当此方法返回时，包含源向量中来自较低下标的扩宽元素).</param>
        /// <param name="upper">When this method returns, contains the widened elements from upper indices in the source vector (当此方法返回时，包含源向量中来自较高下标的扩宽元素).</param>
        /// <seealso cref="Widen_AcceleratedTypes"/>
        /// <seealso cref="Vector512.Widen(Vector512{byte})" />
        void Widen(Vector512<byte> source, out Vector512<ushort> lower, out Vector512<ushort> upper);

        /// <summary>
        /// Widens a <seealso cref="Vector512{T}"/> into two <seealso cref="Vector512{T}"/> instances (将一个 <seealso cref="Vector512{T}"/> 扩宽为两个 <seealso cref="Vector512{T}"/> 实例).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <param name="lower">When this method returns, contains the widened elements from lower indices in the source vector (当此方法返回时，包含源向量中来自较低下标的扩宽元素).</param>
        /// <param name="upper">When this method returns, contains the widened elements from upper indices in the source vector (当此方法返回时，包含源向量中来自较高下标的扩宽元素).</param>
        /// <seealso cref="Widen_AcceleratedTypes"/>
        /// <seealso cref="Vector512.Widen(Vector512{short})" />
        void Widen(Vector512<short> source, out Vector512<int> lower, out Vector512<int> upper);

        /// <summary>
        /// Widens a <seealso cref="Vector512{T}"/> into two <seealso cref="Vector512{T}"/> instances (将一个 <seealso cref="Vector512{T}"/> 扩宽为两个 <seealso cref="Vector512{T}"/> 实例).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <param name="lower">When this method returns, contains the widened elements from lower indices in the source vector (当此方法返回时，包含源向量中来自较低下标的扩宽元素).</param>
        /// <param name="upper">When this method returns, contains the widened elements from upper indices in the source vector (当此方法返回时，包含源向量中来自较高下标的扩宽元素).</param>
        /// <seealso cref="Widen_AcceleratedTypes"/>
        /// <seealso cref="Vector512.Widen(Vector512{ushort})" />
        void Widen(Vector512<ushort> source, out Vector512<uint> lower, out Vector512<uint> upper);

        /// <summary>
        /// Widens a <seealso cref="Vector512{T}"/> into two <seealso cref="Vector512{T}"/> instances (将一个 <seealso cref="Vector512{T}"/> 扩宽为两个 <seealso cref="Vector512{T}"/> 实例).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <param name="lower">When this method returns, contains the widened elements from lower indices in the source vector (当此方法返回时，包含源向量中来自较低下标的扩宽元素).</param>
        /// <param name="upper">When this method returns, contains the widened elements from upper indices in the source vector (当此方法返回时，包含源向量中来自较高下标的扩宽元素).</param>
        /// <seealso cref="Widen_AcceleratedTypes"/>
        /// <seealso cref="Vector512.Widen(Vector512{int})" />
        void Widen(Vector512<int> source, out Vector512<long> lower, out Vector512<long> upper);

        /// <summary>
        /// Widens a <seealso cref="Vector512{T}"/> into two <seealso cref="Vector512{T}"/> instances (将一个 <seealso cref="Vector512{T}"/> 扩宽为两个 <seealso cref="Vector512{T}"/> 实例).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <param name="lower">When this method returns, contains the widened elements from lower indices in the source vector (当此方法返回时，包含源向量中来自较低下标的扩宽元素).</param>
        /// <param name="upper">When this method returns, contains the widened elements from upper indices in the source vector (当此方法返回时，包含源向量中来自较高下标的扩宽元素).</param>
        /// <seealso cref="Widen_AcceleratedTypes"/>
        /// <seealso cref="Vector512.Widen(Vector512{uint})" />
        void Widen(Vector512<uint> source, out Vector512<ulong> lower, out Vector512<ulong> upper);

        /// <summary>
        /// Types with hardware acceleration when running <c>WidenLower</c> (运行 <c>WidenLower</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="WidenLower(Vector512{float})" />
        TypeCodeFlags WidenLower_AcceleratedTypes { get; }

        /// <summary>
        /// Widens the lower half of a Vector into a Vector (将向量的低半部分扩宽为一个向量).
        /// Mnemonic: <c>rt[i] := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (欲扩宽其元素的向量).</param>
        /// <returns>A vector that contain the widened lower half of <paramref name="source" /> (包含 <paramref name="source" />的扩宽低半部分 的向量).</returns>
        /// <seealso cref="WidenLower_AcceleratedTypes"/>
        /// <seealso cref="Vector512.WidenLower(Vector512{float})" />
        Vector512<double> WidenLower(Vector512<float> source);

        /// <inheritdoc cref="WidenLower(Vector512{float})"/>
        /// <seealso cref="Vector512.WidenLower(Vector512{sbyte})" />
        Vector512<short> WidenLower(Vector512<sbyte> source);

        /// <inheritdoc cref="WidenLower(Vector512{float})"/>
        /// <seealso cref="Vector512.WidenLower(Vector512{byte})" />
        Vector512<ushort> WidenLower(Vector512<byte> source);

        /// <inheritdoc cref="WidenLower(Vector512{float})"/>
        /// <seealso cref="Vector512.WidenLower(Vector512{short})" />
        Vector512<int> WidenLower(Vector512<short> source);

        /// <inheritdoc cref="WidenLower(Vector512{float})"/>
        /// <seealso cref="Vector512.WidenLower(Vector512{ushort})" />
        Vector512<uint> WidenLower(Vector512<ushort> source);

        /// <inheritdoc cref="WidenLower(Vector512{float})"/>
        /// <seealso cref="Vector512.WidenLower(Vector512{int})" />
        Vector512<long> WidenLower(Vector512<int> source);

        /// <inheritdoc cref="WidenLower(Vector512{float})"/>
        /// <seealso cref="Vector512.WidenLower(Vector512{uint})" />
        Vector512<ulong> WidenLower(Vector512<uint> source);

#endif
    }
}
