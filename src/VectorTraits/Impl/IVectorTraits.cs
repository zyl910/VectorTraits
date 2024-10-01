using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Numerics;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
#endif
#if NET5_0_OR_GREATER
using System.Runtime.Intrinsics.Arm;
#endif
#if NET8_0_OR_GREATER
using System.Runtime.Intrinsics.Wasm;
#endif // NET8_0_OR_GREATER
using System.Text;

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// <see cref="Vector{T}"/> traits interface (<see cref="Vector{T}"/> 的特征接口).
    /// </summary>
    [CLSCompliant(false)]
    public partial interface IVectorTraits : IBaseTraits {

        // == .NET style  ==

        /// <summary>
        /// Types with hardware acceleration when running <c>Ceiling</c> (运行 <c>Ceiling</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Methods used to calculate rounding (用于计算舍入的方法):</para>
        /// <para>- <see cref="Ceiling(Vector{float})"/>: Computes the ceiling of each element in a vector (计算向量中每个元素的向上取整). It is also known as round to positive infinity (它也被称作向正无穷舍入). See more: <see cref="MidpointRounding.ToPositiveInfinity"/>.</para>
        /// <para>- <see cref="Floor(Vector{float})"/>: Computes the floor of each element in a vector (计算向量中每个元素的向下取整). It is also known as round to negative infinity (它也被称作向负无穷舍入). See more: <see cref="MidpointRounding.ToNegativeInfinity"/>.</para>
        /// <para>- <see cref="YRoundToEven(Vector{float})"/>: Computes the round to even of each element in a vector (计算向量中每个元素的向偶数舍入). It is also known as `rounding half to even`/`round to nearest integer` (它也被称作`四舍六入五成双`/`舍入到最近整数`). See more: <see cref="MidpointRounding.ToEven"/>.</para>
        /// <para>- <see cref="YRoundToZero(Vector{float})"/>: Computes the round to zero of each element in a vector (计算向量中每个元素的向零舍入). It is also known as truncate (它也被称作截断取整). See more: <see cref="MidpointRounding.ToZero"/>.</para>
        /// </remarks>
        /// <seealso cref="Ceiling(Vector{float})"/>
        TypeCodeFlags Ceiling_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the ceiling of each element in a vector (计算向量中每个元素的向上取整). It is also known as round to positive infinity (它也被称作向正无穷舍入). See more: <see cref="MidpointRounding.ToPositiveInfinity"/>.
        /// Mnemonic: <c>rt[i] := ceiling(value[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its ceiling computed (将计算向上舍入的向量).</param>
        /// <returns>A vector whose elements are the ceiling of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的向上取整).</returns>
        /// <seealso cref="Ceiling_AcceleratedTypes"/>
        /// <seealso cref="Vector.Ceiling(Vector{float})" />
        Vector<float> Ceiling(Vector<float> value);

        /// <summary>
        /// Computes the ceiling of each element in a vector (计算向量中每个元素的向上取整). It is also known as round to positive infinity (它也被称作向正无穷舍入). See more: <see cref="MidpointRounding.ToPositiveInfinity"/>.
        /// Mnemonic: <c>rt[i] := ceiling(value[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its ceiling computed (将计算向上舍入的向量).</param>
        /// <returns>A vector whose elements are the ceiling of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的向上取整).</returns>
        /// <seealso cref="Ceiling_AcceleratedTypes"/>
        /// <seealso cref="Vector.Ceiling(Vector{double})" />
        Vector<double> Ceiling(Vector<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>ConvertToDouble</c> (运行 <c>ConvertToDouble</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规). Full 64-bit integer range (完全的64位整数范围).</para>
        /// <para>- Range52: Supports up to 52-bit integer range (最多支持52位整数范围).</para>
        /// </remarks>
        /// <seealso cref="ConvertToDouble(Vector{long})"/>
        /// <seealso cref="ConvertToDouble_Range52(Vector{long})"/>
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
        /// Convert to a vector whose elements are of type Double (转换为元素类型是Double的向量). Works for inputs in the range: [-2^51, 2^51).
        /// Mnemonic: <c>rt[i] := (Double)(value[i])</c>.
        /// </summary>
        /// <param name="value">The source vector (源向量).</param>
        /// <returns>The converted vector (转换后的向量).</returns>
        /// <seealso cref="ConvertToDouble_AcceleratedTypes"/>
        /// <seealso cref="Vector.ConvertToDouble(Vector{long})" />
        Vector<double> ConvertToDouble_Range52(Vector<long> value);

        /// <summary>
        /// Convert to a vector whose elements are of type Double (转换为元素类型是Double的向量). Works for inputs in the range: [0, 2^52).
        /// Mnemonic: <c>rt[i] := (Double)(value[i])</c>.
        /// </summary>
        /// <param name="value">The source vector (源向量).</param>
        /// <returns>The converted vector (转换后的向量).</returns>
        /// <seealso cref="ConvertToDouble_AcceleratedTypes"/>
        /// <seealso cref="Vector.ConvertToDouble(Vector{ulong})" />
        Vector<double> ConvertToDouble_Range52(Vector<ulong> value);


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
        /// <seealso cref="Vector.ConvertToInt64(Vector{double})" />
        Vector<long> ConvertToInt64(Vector<double> value);

        /// <summary>
        /// Convert to a vector whose elements are of type Int64, rounding mode is truncate(round to zero) (转换为元素类型是Int64的向量, 舍入模式为截断(舍入到零)). Works for inputs in the range: [-2^51, 2^51).
        /// Mnemonic: <c>rt[i] := (Int64)(value[i])</c>.
        /// </summary>
        /// <param name="value">The source vector (源向量).</param>
        /// <returns>The converted vector (转换后的向量).</returns>
        /// <seealso cref="ConvertToInt64_AcceleratedTypes"/>
        /// <seealso cref="Vector.ConvertToInt64(Vector{double})" />
        Vector<long> ConvertToInt64_Range52(Vector<double> value);

        /// <summary>
        /// Convert to a vector whose elements are of type Int64, rounding mode is round to even(round to nearest integer) (转换为元素类型是Int64的向量, 舍入模式为舍入到偶数(舍入到最近整数)). Works for inputs in the range: [-2^51, 2^51).
        /// Mnemonic: <c>rt[i] := (Int64)(round_to_even(value[i]))</c>.
        /// </summary>
        /// <param name="value">The source vector (源向量).</param>
        /// <returns>The converted vector (转换后的向量).</returns>
        /// <seealso cref="ConvertToInt64_AcceleratedTypes"/>
        Vector<long> ConvertToInt64_Range52RoundToEven(Vector<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>ConvertToSingle</c> (运行 <c>ConvertToSingle</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="ConvertToSingle(Vector{int})"/>
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
        /// <seealso cref="Vector.ConvertToUInt64(Vector{double})" />
        Vector<ulong> ConvertToUInt64(Vector<double> value);

        /// <summary>
        /// Convert to a vector whose elements are of type UInt64, rounding mode is truncate(round to zero) (转换为元素类型是UInt64的向量, 舍入模式为截断(舍入到零)). Works for inputs in the range: [0, 2^52).
        /// Mnemonic: <c>rt[i] := (UInt64)(value[i])</c>.
        /// </summary>
        /// <param name="value">The source vector (源向量).</param>
        /// <returns>The converted vector (转换后的向量).</returns>
        /// <seealso cref="ConvertToUInt64_AcceleratedTypes"/>
        /// <seealso cref="Vector.ConvertToUInt64(Vector{double})" />
        Vector<ulong> ConvertToUInt64_Range52(Vector<double> value);

        /// <summary>
        /// Convert to a vector whose elements are of type UInt64, rounding mode is round to even(round to nearest integer) (转换为元素类型是UInt64的向量, 舍入模式为舍入到偶数(舍入到最近整数)). Works for inputs in the range: [0, 2^52).
        /// Mnemonic: <c>rt[i] := (UInt64)(round_to_even(value[i]))</c>.
        /// </summary>
        /// <param name="value">The source vector (源向量).</param>
        /// <returns>The converted vector (转换后的向量).</returns>
        /// <seealso cref="ConvertToUInt64_AcceleratedTypes"/>
        Vector<ulong> ConvertToUInt64_Range52RoundToEven(Vector<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>ExtractMostSignificantBits</c> (运行 <c>ExtractMostSignificantBits</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Inverse function (反函数): <see cref="YBitToByte"/>, <see cref="YBitToInt16"/>, <see cref="YBitToInt32"/>, <see cref="YBitToInt64"/>.</para>
        /// </remarks>
        /// <seealso cref="ExtractMostSignificantBits(Vector{byte})"/>
        TypeCodeFlags ExtractMostSignificantBits_AcceleratedTypes { get; }

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ExtractMostSignificantBits{T}(Vector128{T})" />
        ulong ExtractMostSignificantBits(Vector<float> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ExtractMostSignificantBits{T}(Vector128{T})" />
        ulong ExtractMostSignificantBits(Vector<double> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ExtractMostSignificantBits{T}(Vector128{T})" />
        ulong ExtractMostSignificantBits(Vector<sbyte> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ExtractMostSignificantBits{T}(Vector128{T})" />
        ulong ExtractMostSignificantBits(Vector<byte> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ExtractMostSignificantBits{T}(Vector128{T})" />
        ulong ExtractMostSignificantBits(Vector<short> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ExtractMostSignificantBits{T}(Vector128{T})" />
        ulong ExtractMostSignificantBits(Vector<ushort> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ExtractMostSignificantBits{T}(Vector128{T})" />
        ulong ExtractMostSignificantBits(Vector<int> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ExtractMostSignificantBits{T}(Vector128{T})" />
        ulong ExtractMostSignificantBits(Vector<uint> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ExtractMostSignificantBits{T}(Vector128{T})" />
        ulong ExtractMostSignificantBits(Vector<long> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ExtractMostSignificantBits{T}(Vector128{T})" />
        ulong ExtractMostSignificantBits(Vector<ulong> vector);


        /// <summary>
        /// Types with hardware acceleration when running <c>Floor</c> (运行 <c>Floor</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Methods used to calculate rounding (用于计算舍入的方法):</para>
        /// <para>- <see cref="Ceiling(Vector{float})"/>: Computes the ceiling of each element in a vector (计算向量中每个元素的向上取整). It is also known as round to positive infinity (它也被称作向正无穷舍入). See more: <see cref="MidpointRounding.ToPositiveInfinity"/>.</para>
        /// <para>- <see cref="Floor(Vector{float})"/>: Computes the floor of each element in a vector (计算向量中每个元素的向下取整). It is also known as round to negative infinity (它也被称作向负无穷舍入). See more: <see cref="MidpointRounding.ToNegativeInfinity"/>.</para>
        /// <para>- <see cref="YRoundToEven(Vector{float})"/>: Computes the round to even of each element in a vector (计算向量中每个元素的向偶数舍入). It is also known as `rounding half to even`/`round to nearest integer` (它也被称作`四舍六入五成双`/`舍入到最近整数`). See more: <see cref="MidpointRounding.ToEven"/>.</para>
        /// <para>- <see cref="YRoundToZero(Vector{float})"/>: Computes the round to zero of each element in a vector (计算向量中每个元素的向零舍入). It is also known as truncate (它也被称作截断取整). See more: <see cref="MidpointRounding.ToZero"/>.</para>
        /// </remarks>
        /// <seealso cref="Floor(Vector{float})"/>
        TypeCodeFlags Floor_AcceleratedTypes { get; }

        /// <summary>
        /// Computes the floor of each element in a vector (计算向量中每个元素的向下取整). It is also known as round to negative infinity (它也被称作向负无穷舍入). See more: <see cref="MidpointRounding.ToNegativeInfinity"/>.
        /// Mnemonic: <c>rt[i] := floor(value[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its floor computed (将计算向下舍入的向量).</param>
        /// <returns>A vector whose elements are the floor of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的向下取整).</returns>
        /// <seealso cref="Floor_AcceleratedTypes"/>
        /// <seealso cref="Vector.Floor(Vector{float})" />
        Vector<float> Floor(Vector<float> value);

        /// <summary>
        /// Computes the floor of each element in a vector (计算向量中每个元素的向下取整). It is also known as round to negative infinity (它也被称作向负无穷舍入). See more: <see cref="MidpointRounding.ToNegativeInfinity"/>.
        /// Mnemonic: <c>rt[i] := floor(value[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its floor computed (将计算向下舍入的向量).</param>
        /// <returns>A vector whose elements are the floor of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的向下取整).</returns>
        /// <seealso cref="Floor_AcceleratedTypes"/>
        /// <seealso cref="Vector.Floor(Vector{double})" />
        Vector<double> Floor(Vector<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>Narrow</c> (运行 <c>Narrow</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Narrow(Vector{short}, Vector{short})"/>
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


        // 对于8、16位的移位, C# 会扩展到32位来处理. 但对于SIMD的紧缩8、16位数据来说, 扩展到32位后的运算结果有时会不符. 故应该先对 shiftAmount 做 bitwise-and 运算, 使其限制在合理范围内. 实测发现.NET6仍然是扩展到32位, 而 .NET7 也用掩码处理, 故本类库与 .NET7 保持了一致.
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
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Args: Arguments calculation. Provide arguments for ShiftLeft_Core (参数计算. 为 ShiftLeft_Core 提供参数).</para>
        /// <para>- Core. Core calculation. Its arguments are derived from ShiftLeft_Args (核心计算. 其参数来源于 ShiftLeft_Args).</para>
        /// <para>- Const: Constant version. This version can be used if you can ensure that the parameters are constants. It can take advantage of constants and make better use of hardware acceleration (常量版. 若能确保参数是常量, 可使用该版本. 它能利用常量, 更好的使用硬件加速).</para>
        /// <para>- ConstCore: Core calculation of constant version. Its arguments are derived from ShiftLeft_Args (常量版的核心计算. 其参数来源于 ShiftLeft_Args).</para>
        /// <para>- Fast: Fast version. This version can be used if you can ensure that the parameter variables are always in the valid range (快速版. 若能确保参数变量总是在有效范围内的, 可使用该版本).</para>
        /// </remarks>
        /// <seealso cref="ShiftLeft(Vector{byte}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector{byte}, int, out Vector{byte})"/>
        /// <seealso cref="ShiftLeft_Core(Vector{byte}, int, Vector{byte}, Vector{byte})"/>
        /// <seealso cref="ShiftLeft_Const(Vector{byte}, int)"/>
        /// <seealso cref="ShiftLeft_ConstCore(Vector{byte}, int, Vector{byte}, Vector{byte})"/>
        /// <seealso cref="ShiftLeft_Fast(Vector{byte}, int)"/>
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
        /// <seealso cref="ShiftLeft_Fast(Vector{sbyte}, int)"/>
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
        /// <seealso cref="ShiftLeft_Fast(Vector{byte}, int)"/>
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
        /// <seealso cref="ShiftLeft_Fast(Vector{short}, int)"/>
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
        /// <seealso cref="ShiftLeft_Fast(Vector{ushort}, int)"/>
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
        /// <seealso cref="ShiftLeft_Fast(Vector{int}, int)"/>
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
        /// <seealso cref="ShiftLeft_Fast(Vector{uint}, int)"/>
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
        /// <seealso cref="ShiftLeft_Fast(Vector{long}, int)"/>
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
        /// <seealso cref="ShiftLeft_Fast(Vector{ulong}, int)"/>
        Vector<ulong> ShiftLeft(Vector<ulong> value, int shiftAmount);

        /// <summary>
        /// Arguments calculation for shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量的参数计算). Provide arguments for ShiftLeft_Core (为 ShiftLeft_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftLeft_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftLeft_Core .</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftLeft(Vector{sbyte}, int)"/>
        /// <seealso cref="ShiftLeft(Vector{sbyte}, int)"/>
        /// <seealso cref="ShiftLeft_Core(Vector{sbyte}, int, Vector{sbyte}, Vector{sbyte})"/>
        Vector<sbyte> ShiftLeft_Args(Vector<sbyte> dummy, int shiftAmount, out Vector<sbyte> args1);

        /// <summary>
        /// Arguments calculation for shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量的参数计算). Provide arguments for ShiftLeft_Core (为 ShiftLeft_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftLeft_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftLeft_Core .</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftLeft(Vector{byte}, int)"/>
        /// <seealso cref="ShiftLeft(Vector{byte}, int)"/>
        /// <seealso cref="ShiftLeft_Core(Vector{byte}, int, Vector{byte}, Vector{byte})"/>
        Vector<byte> ShiftLeft_Args(Vector<byte> dummy, int shiftAmount, out Vector<byte> args1);

        /// <summary>
        /// Arguments calculation for shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量的参数计算). Provide arguments for ShiftLeft_Core (为 ShiftLeft_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftLeft_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftLeft_Core .</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftLeft(Vector{short}, int)"/>
        /// <seealso cref="ShiftLeft(Vector{short}, int)"/>
        /// <seealso cref="ShiftLeft_Core(Vector{short}, int, Vector{short}, Vector{short})"/>
        Vector<short> ShiftLeft_Args(Vector<short> dummy, int shiftAmount, out Vector<short> args1);

        /// <summary>
        /// Arguments calculation for shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量的参数计算). Provide arguments for ShiftLeft_Core (为 ShiftLeft_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftLeft_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftLeft_Core .</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftLeft(Vector{ushort}, int)"/>
        /// <seealso cref="ShiftLeft(Vector{ushort}, int)"/>
        /// <seealso cref="ShiftLeft_Core(Vector{ushort}, int, Vector{ushort}, Vector{ushort})"/>
        Vector<ushort> ShiftLeft_Args(Vector<ushort> dummy, int shiftAmount, out Vector<ushort> args1);

        /// <summary>
        /// Arguments calculation for shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量的参数计算). Provide arguments for ShiftLeft_Core (为 ShiftLeft_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftLeft_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftLeft_Core .</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftLeft(Vector{int}, int)"/>
        /// <seealso cref="ShiftLeft(Vector{int}, int)"/>
        /// <seealso cref="ShiftLeft_Core(Vector{int}, int, Vector{int}, Vector{int})"/>
        Vector<int> ShiftLeft_Args(Vector<int> dummy, int shiftAmount, out Vector<int> args1);

        /// <summary>
        /// Arguments calculation for shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量的参数计算). Provide arguments for ShiftLeft_Core (为 ShiftLeft_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftLeft_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftLeft_Core .</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftLeft(Vector{uint}, int)"/>
        /// <seealso cref="ShiftLeft(Vector{uint}, int)"/>
        /// <seealso cref="ShiftLeft_Core(Vector{uint}, int, Vector{uint}, Vector{uint})"/>
        Vector<uint> ShiftLeft_Args(Vector<uint> dummy, int shiftAmount, out Vector<uint> args1);

        /// <summary>
        /// Arguments calculation for shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量的参数计算). Provide arguments for ShiftLeft_Core (为 ShiftLeft_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftLeft_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftLeft_Core .</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftLeft(Vector{long}, int)"/>
        /// <seealso cref="ShiftLeft(Vector{long}, int)"/>
        /// <seealso cref="ShiftLeft_Core(Vector{long}, int, Vector{long}, Vector{long})"/>
        Vector<long> ShiftLeft_Args(Vector<long> dummy, int shiftAmount, out Vector<long> args1);

        /// <summary>
        /// Arguments calculation for shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量的参数计算). Provide arguments for ShiftLeft_Core (为 ShiftLeft_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftLeft_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftLeft_Core .</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftLeft(Vector{ulong}, int)"/>
        /// <seealso cref="ShiftLeft(Vector{ulong}, int)"/>
        /// <seealso cref="ShiftLeft_Core(Vector{ulong}, int, Vector{ulong}, Vector{ulong})"/>
        Vector<ulong> ShiftLeft_Args(Vector<ulong> dummy, int shiftAmount, out Vector<ulong> args1);

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
        /// <seealso cref="Vector.ShiftLeft(Vector{sbyte}, int)"/>
        /// <seealso cref="ShiftLeft(Vector{sbyte}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector{sbyte}, int, out Vector{sbyte})"/>
        Vector<sbyte> ShiftLeft_Core(Vector<sbyte> value, int shiftAmount, Vector<sbyte> args0, Vector<sbyte> args1);

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
        /// <seealso cref="Vector.ShiftLeft(Vector{byte}, int)"/>
        /// <seealso cref="ShiftLeft(Vector{byte}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector{byte}, int, out Vector{byte})"/>
        Vector<byte> ShiftLeft_Core(Vector<byte> value, int shiftAmount, Vector<byte> args0, Vector<byte> args1);

        /// <inheritdoc cref="ShiftLeft_Core(Vector{short}, int, Vector{short}, Vector{short})"/>
        [Obsolete("This method is for testing purposes only. Please use `ShiftLeft_Core(Vector{short}, int, Vector{short}, Vector{short})` instead.")]
        Vector<short> ShiftLeft_Core(Vector<short> value, Vector<short> args0, Vector<short> args1);

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
        /// <seealso cref="Vector.ShiftLeft(Vector{short}, int)"/>
        /// <seealso cref="ShiftLeft(Vector{short}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector{short}, int, out Vector{short})"/>
        Vector<short> ShiftLeft_Core(Vector<short> value, int shiftAmount, Vector<short> args0, Vector<short> args1);

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
        /// <seealso cref="Vector.ShiftLeft(Vector{ushort}, int)"/>
        /// <seealso cref="ShiftLeft(Vector{ushort}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector{ushort}, int, out Vector{ushort})"/>
        Vector<ushort> ShiftLeft_Core(Vector<ushort> value, int shiftAmount, Vector<ushort> args0, Vector<ushort> args1);

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
        /// <seealso cref="Vector.ShiftLeft(Vector{int}, int)"/>
        /// <seealso cref="ShiftLeft(Vector{int}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector{int}, int, out Vector{int})"/>
        Vector<int> ShiftLeft_Core(Vector<int> value, int shiftAmount, Vector<int> args0, Vector<int> args1);

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
        /// <seealso cref="Vector.ShiftLeft(Vector{uint}, int)"/>
        /// <seealso cref="ShiftLeft(Vector{uint}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector{uint}, int, out Vector{uint})"/>
        Vector<uint> ShiftLeft_Core(Vector<uint> value, int shiftAmount, Vector<uint> args0, Vector<uint> args1);

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
        /// <seealso cref="Vector.ShiftLeft(Vector{long}, int)"/>
        /// <seealso cref="ShiftLeft(Vector{long}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector{long}, int, out Vector{long})"/>
        Vector<long> ShiftLeft_Core(Vector<long> value, int shiftAmount, Vector<long> args0, Vector<long> args1);

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
        /// <seealso cref="Vector.ShiftLeft(Vector{ulong}, int)"/>
        /// <seealso cref="ShiftLeft(Vector{ulong}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector{ulong}, int, out Vector{ulong})"/>
        Vector<ulong> ShiftLeft_Core(Vector<ulong> value, int shiftAmount, Vector<ulong> args0, Vector<ulong> args1);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Const (将向量的每个元素左移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~7 (有效范围是 1~7).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftLeft(Vector{sbyte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector{sbyte}, int)"/>
        Vector<sbyte> ShiftLeft_Const(Vector<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Const (将向量的每个元素左移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~7 (有效范围是 1~7).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftLeft(Vector{byte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector{byte}, int)"/>
        Vector<byte> ShiftLeft_Const(Vector<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Const (将向量的每个元素左移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~15 (有效范围是 1~15).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftLeft(Vector{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector{short}, int)"/>
        Vector<short> ShiftLeft_Const(Vector<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Const (将向量的每个元素左移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~15 (有效范围是 1~15).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftLeft(Vector{ushort}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector{ushort}, int)"/>
        Vector<ushort> ShiftLeft_Const(Vector<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Const (将向量的每个元素左移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~31 (有效范围是 1~31).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftLeft(Vector{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector{int}, int)"/>
        Vector<int> ShiftLeft_Const(Vector<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Const (将向量的每个元素左移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~31 (有效范围是 1~31).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftLeft(Vector{uint}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector{uint}, int)"/>
        Vector<uint> ShiftLeft_Const(Vector<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Const (将向量的每个元素左移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~63 (有效范围是 1~63).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftLeft(Vector{long}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector{long}, int)"/>
        Vector<long> ShiftLeft_Const(Vector<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Const (将向量的每个元素左移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~63 (有效范围是 1~63).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftLeft(Vector{ulong}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector{ulong}, int)"/>
        Vector<ulong> ShiftLeft_Const(Vector<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount);

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
        /// <seealso cref="Vector.ShiftLeft(Vector{sbyte}, int)"/>
        /// <seealso cref="ShiftLeft(Vector{sbyte}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector{sbyte}, int, out Vector{sbyte})"/>
        Vector<sbyte> ShiftLeft_ConstCore(Vector<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector<sbyte> args0, Vector<sbyte> args1);

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
        /// <seealso cref="Vector.ShiftLeft(Vector{byte}, int)"/>
        /// <seealso cref="ShiftLeft(Vector{byte}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector{byte}, int, out Vector{byte})"/>
        Vector<byte> ShiftLeft_ConstCore(Vector<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector<byte> args0, Vector<byte> args1);

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
        /// <seealso cref="Vector.ShiftLeft(Vector{short}, int)"/>
        /// <seealso cref="ShiftLeft(Vector{short}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector{short}, int, out Vector{short})"/>
        Vector<short> ShiftLeft_ConstCore(Vector<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector<short> args0, Vector<short> args1);

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
        /// <seealso cref="Vector.ShiftLeft(Vector{ushort}, int)"/>
        /// <seealso cref="ShiftLeft(Vector{ushort}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector{ushort}, int, out Vector{ushort})"/>
        Vector<ushort> ShiftLeft_ConstCore(Vector<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector<ushort> args0, Vector<ushort> args1);

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
        /// <seealso cref="Vector.ShiftLeft(Vector{int}, int)"/>
        /// <seealso cref="ShiftLeft(Vector{int}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector{int}, int, out Vector{int})"/>
        Vector<int> ShiftLeft_ConstCore(Vector<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector<int> args0, Vector<int> args1);

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
        /// <seealso cref="Vector.ShiftLeft(Vector{uint}, int)"/>
        /// <seealso cref="ShiftLeft(Vector{uint}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector{uint}, int, out Vector{uint})"/>
        Vector<uint> ShiftLeft_ConstCore(Vector<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector<uint> args0, Vector<uint> args1);

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
        /// <seealso cref="Vector.ShiftLeft(Vector{long}, int)"/>
        /// <seealso cref="ShiftLeft(Vector{long}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector{long}, int, out Vector{long})"/>
        Vector<long> ShiftLeft_ConstCore(Vector<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector<long> args0, Vector<long> args1);

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
        /// <seealso cref="Vector.ShiftLeft(Vector{ulong}, int)"/>
        /// <seealso cref="ShiftLeft(Vector{ulong}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector{ulong}, int, out Vector{ulong})"/>
        Vector<ulong> ShiftLeft_ConstCore(Vector<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector<ulong> args0, Vector<ulong> args1);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~7 (有效范围是 0~7).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftLeft(Vector{sbyte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector{sbyte}, int)"/>
        Vector<sbyte> ShiftLeft_Fast(Vector<sbyte> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~7 (有效范围是 0~7).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftLeft(Vector{byte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector{byte}, int)"/>
        Vector<byte> ShiftLeft_Fast(Vector<byte> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~15 (有效范围是 0~15).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftLeft(Vector{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector{short}, int)"/>
        Vector<short> ShiftLeft_Fast(Vector<short> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~15 (有效范围是 0~15).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftLeft(Vector{ushort}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector{ushort}, int)"/>
        Vector<ushort> ShiftLeft_Fast(Vector<ushort> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~31 (有效范围是 0~31).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftLeft(Vector{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector{int}, int)"/>
        Vector<int> ShiftLeft_Fast(Vector<int> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~31 (有效范围是 0~31).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftLeft(Vector{uint}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector{uint}, int)"/>
        Vector<uint> ShiftLeft_Fast(Vector<uint> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~63 (有效范围是 0~63).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftLeft(Vector{long}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector{long}, int)"/>
        Vector<long> ShiftLeft_Fast(Vector<long> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~63 (有效范围是 0~63).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftLeft(Vector{ulong}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector{ulong}, int)"/>
        Vector<ulong> ShiftLeft_Fast(Vector<ulong> value, int shiftAmount);


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
        /// <seealso cref="ShiftRightArithmetic(Vector{sbyte}, int)"/>
        /// <seealso cref="ShiftRightArithmetic_Args(Vector{sbyte}, int, out Vector{sbyte})"/>
        /// <seealso cref="ShiftRightArithmetic_Core(Vector{sbyte}, int, Vector{sbyte}, Vector{sbyte})"/>
        /// <seealso cref="ShiftRightArithmetic_Const(Vector{sbyte}, int)"/>
        /// <seealso cref="ShiftRightArithmetic_ConstCore(Vector{sbyte}, int, Vector{sbyte}, Vector{sbyte})"/>
        /// <seealso cref="ShiftRightArithmetic_Fast(Vector{sbyte}, int)"/>
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
        /// <seealso cref="ShiftRightArithmetic_Fast(Vector{sbyte}, int)"/>
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
        /// <seealso cref="ShiftRightArithmetic_Fast(Vector{short}, int)"/>
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
        /// <seealso cref="ShiftRightArithmetic_Fast(Vector{int}, int)"/>
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
        /// <seealso cref="ShiftRightArithmetic_Fast(Vector{long}, int)"/>
        Vector<long> ShiftRightArithmetic(Vector<long> value, int shiftAmount);

        /// <summary>
        /// Arguments calculation for shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量的参数计算). Provide arguments for ShiftRightArithmetic_Core (为 ShiftRightArithmetic_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftRightArithmetic_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftRightArithmetic_Core .</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightArithmetic(Vector{sbyte}, int)"/>
        /// <seealso cref="ShiftRightArithmetic(Vector{sbyte}, int)"/>
        /// <seealso cref="ShiftRightArithmetic_Core(Vector{sbyte}, int, Vector{sbyte}, Vector{sbyte})"/>
        Vector<sbyte> ShiftRightArithmetic_Args(Vector<sbyte> dummy, int shiftAmount, out Vector<sbyte> args1);

        /// <summary>
        /// Arguments calculation for shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量的参数计算). Provide arguments for ShiftRightArithmetic_Core (为 ShiftRightArithmetic_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftRightArithmetic_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftRightArithmetic_Core .</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightArithmetic(Vector{short}, int)"/>
        /// <seealso cref="ShiftRightArithmetic(Vector{short}, int)"/>
        /// <seealso cref="ShiftRightArithmetic_Core(Vector{short}, int, Vector{short}, Vector{short})"/>
        Vector<short> ShiftRightArithmetic_Args(Vector<short> dummy, int shiftAmount, out Vector<short> args1);

        /// <summary>
        /// Arguments calculation for shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量的参数计算). Provide arguments for ShiftRightArithmetic_Core (为 ShiftRightArithmetic_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftRightArithmetic_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftRightArithmetic_Core .</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightArithmetic(Vector{int}, int)"/>
        /// <seealso cref="ShiftRightArithmetic(Vector{int}, int)"/>
        /// <seealso cref="ShiftRightArithmetic_Core(Vector{int}, int, Vector{int}, Vector{int})"/>
        Vector<int> ShiftRightArithmetic_Args(Vector<int> dummy, int shiftAmount, out Vector<int> args1);

        /// <summary>
        /// Arguments calculation for shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量的参数计算). Provide arguments for ShiftRightArithmetic_Core (为 ShiftRightArithmetic_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftRightArithmetic_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftRightArithmetic_Core .</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightArithmetic(Vector{long}, int)"/>
        /// <seealso cref="ShiftRightArithmetic(Vector{long}, int)"/>
        /// <seealso cref="ShiftRightArithmetic_Core(Vector{long}, int, Vector{long}, Vector{long})"/>
        Vector<long> ShiftRightArithmetic_Args(Vector<long> dummy, int shiftAmount, out Vector<long> args1);

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
        /// <seealso cref="Vector.ShiftRightArithmetic(Vector{sbyte}, int)"/>
        /// <seealso cref="ShiftRightArithmetic(Vector{sbyte}, int)"/>
        /// <seealso cref="ShiftRightArithmetic_Args(Vector{sbyte}, int, out Vector{sbyte})"/>
        Vector<sbyte> ShiftRightArithmetic_Core(Vector<sbyte> value, int shiftAmount, Vector<sbyte> args0, Vector<sbyte> args1);

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
        /// <seealso cref="Vector.ShiftRightArithmetic(Vector{short}, int)"/>
        /// <seealso cref="ShiftRightArithmetic(Vector{short}, int)"/>
        /// <seealso cref="ShiftRightArithmetic_Args(Vector{short}, int, out Vector{short})"/>
        Vector<short> ShiftRightArithmetic_Core(Vector<short> value, int shiftAmount, Vector<short> args0, Vector<short> args1);

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
        /// <seealso cref="Vector.ShiftRightArithmetic(Vector{int}, int)"/>
        /// <seealso cref="ShiftRightArithmetic(Vector{int}, int)"/>
        /// <seealso cref="ShiftRightArithmetic_Args(Vector{int}, int, out Vector{int})"/>
        Vector<int> ShiftRightArithmetic_Core(Vector<int> value, int shiftAmount, Vector<int> args0, Vector<int> args1);

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
        /// <seealso cref="Vector.ShiftRightArithmetic(Vector{long}, int)"/>
        /// <seealso cref="ShiftRightArithmetic(Vector{long}, int)"/>
        /// <seealso cref="ShiftRightArithmetic_Args(Vector{long}, int, out Vector{long})"/>
        Vector<long> ShiftRightArithmetic_Core(Vector<long> value, int shiftAmount, Vector<long> args0, Vector<long> args1);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount - Const(将向量的每个有符号元素算术右移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~7 (有效范围是 1~7).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightArithmetic(Vector{sbyte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic(Vector{sbyte}, int)"/>
        Vector<sbyte> ShiftRightArithmetic_Const(Vector<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount - Const(将向量的每个有符号元素算术右移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~15 (有效范围是 1~15).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightArithmetic(Vector{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic(Vector{short}, int)"/>
        Vector<short> ShiftRightArithmetic_Const(Vector<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount - Const(将向量的每个有符号元素算术右移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~31 (有效范围是 1~31).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightArithmetic(Vector{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic(Vector{int}, int)"/>
        Vector<int> ShiftRightArithmetic_Const(Vector<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount - Const(将向量的每个有符号元素算术右移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~63 (有效范围是 1~63).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightArithmetic(Vector{long}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic(Vector{long}, int)"/>
        Vector<long> ShiftRightArithmetic_Const(Vector<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount);

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
        /// <seealso cref="Vector.ShiftRightArithmetic(Vector{sbyte}, int)"/>
        /// <seealso cref="ShiftRightArithmetic(Vector{sbyte}, int)"/>
        /// <seealso cref="ShiftRightArithmetic_Args(Vector{sbyte}, int, out Vector{sbyte})"/>
        Vector<sbyte> ShiftRightArithmetic_ConstCore(Vector<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector<sbyte> args0, Vector<sbyte> args1);

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
        /// <seealso cref="Vector.ShiftRightArithmetic(Vector{short}, int)"/>
        /// <seealso cref="ShiftRightArithmetic(Vector{short}, int)"/>
        /// <seealso cref="ShiftRightArithmetic_Args(Vector{short}, int, out Vector{short})"/>
        Vector<short> ShiftRightArithmetic_ConstCore(Vector<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector<short> args0, Vector<short> args1);

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
        /// <seealso cref="Vector.ShiftRightArithmetic(Vector{int}, int)"/>
        /// <seealso cref="ShiftRightArithmetic(Vector{int}, int)"/>
        /// <seealso cref="ShiftRightArithmetic_Args(Vector{int}, int, out Vector{int})"/>
        Vector<int> ShiftRightArithmetic_ConstCore(Vector<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector<int> args0, Vector<int> args1);

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
        /// <seealso cref="Vector.ShiftRightArithmetic(Vector{long}, int)"/>
        /// <seealso cref="ShiftRightArithmetic(Vector{long}, int)"/>
        /// <seealso cref="ShiftRightArithmetic_Args(Vector{long}, int, out Vector{long})"/>
        Vector<long> ShiftRightArithmetic_ConstCore(Vector<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector<long> args0, Vector<long> args1);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount - Fast(将向量的每个有符号元素算术右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~7 (有效范围是 0~7).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightArithmetic(Vector{sbyte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic(Vector{sbyte}, int)"/>
        Vector<sbyte> ShiftRightArithmetic_Fast(Vector<sbyte> value, int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount - Fast(将向量的每个有符号元素算术右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~15 (有效范围是 0~15).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightArithmetic(Vector{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic(Vector{short}, int)"/>
        Vector<short> ShiftRightArithmetic_Fast(Vector<short> value, int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount - Fast(将向量的每个有符号元素算术右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~31 (有效范围是 0~31).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightArithmetic(Vector{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic(Vector{int}, int)"/>
        Vector<int> ShiftRightArithmetic_Fast(Vector<int> value, int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount - Fast(将向量的每个有符号元素算术右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~63 (有效范围是 0~63).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightArithmetic(Vector{long}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic(Vector{long}, int)"/>
        Vector<long> ShiftRightArithmetic_Fast(Vector<long> value, int shiftAmount);


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
        /// <seealso cref="ShiftRightLogical(Vector{byte}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector{byte}, int, out Vector{byte})"/>
        /// <seealso cref="ShiftRightLogical_Core(Vector{byte}, int, Vector{byte}, Vector{byte})"/>
        /// <seealso cref="ShiftRightLogical_Const(Vector{byte}, int)"/>
        /// <seealso cref="ShiftRightLogical_ConstCore(Vector{byte}, int, Vector{byte}, Vector{byte})"/>
        /// <seealso cref="ShiftRightLogical_Fast(Vector{byte}, int)"/>
        TypeCodeFlags ShiftRightLogical_AcceleratedTypes { get; }

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{sbyte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical_Fast(Vector{sbyte}, int)"/>
        Vector<sbyte> ShiftRightLogical(Vector<sbyte> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{byte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical_Fast(Vector{byte}, int)"/>
        Vector<byte> ShiftRightLogical(Vector<byte> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical_Fast(Vector{short}, int)"/>
        Vector<short> ShiftRightLogical(Vector<short> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{ushort}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical_Fast(Vector{ushort}, int)"/>
        Vector<ushort> ShiftRightLogical(Vector<ushort> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical_Fast(Vector{int}, int)"/>
        Vector<int> ShiftRightLogical(Vector<int> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{uint}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical_Fast(Vector{uint}, int)"/>
        Vector<uint> ShiftRightLogical(Vector<uint> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{long}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical_Fast(Vector{long}, int)"/>
        Vector<long> ShiftRightLogical(Vector<long> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{ulong}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical_Fast(Vector{ulong}, int)"/>
        Vector<ulong> ShiftRightLogical(Vector<ulong> value, int shiftAmount);

        /// <summary>
        /// Arguments calculation for shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量的参数计算). Provide arguments for ShiftRightLogical_Core (为 ShiftRightLogical_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftRightLogical_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftRightLogical_Core .</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{sbyte}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector{sbyte}, int)"/>
        /// <seealso cref="ShiftRightLogical_Core(Vector{sbyte}, int, Vector{sbyte}, Vector{sbyte})"/>
        Vector<sbyte> ShiftRightLogical_Args(Vector<sbyte> dummy, int shiftAmount, out Vector<sbyte> args1);

        /// <summary>
        /// Arguments calculation for shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量的参数计算). Provide arguments for ShiftRightLogical_Core (为 ShiftRightLogical_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftRightLogical_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftRightLogical_Core .</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{byte}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector{byte}, int)"/>
        /// <seealso cref="ShiftRightLogical_Core(Vector{byte}, int, Vector{byte}, Vector{byte})"/>
        Vector<byte> ShiftRightLogical_Args(Vector<byte> dummy, int shiftAmount, out Vector<byte> args1);

        /// <summary>
        /// Arguments calculation for shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量的参数计算). Provide arguments for ShiftRightLogical_Core (为 ShiftRightLogical_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftRightLogical_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftRightLogical_Core .</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{short}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector{short}, int)"/>
        /// <seealso cref="ShiftRightLogical_Core(Vector{short}, int, Vector{short}, Vector{short})"/>
        Vector<short> ShiftRightLogical_Args(Vector<short> dummy, int shiftAmount, out Vector<short> args1);

        /// <summary>
        /// Arguments calculation for shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量的参数计算). Provide arguments for ShiftRightLogical_Core (为 ShiftRightLogical_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftRightLogical_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftRightLogical_Core .</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{ushort}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector{ushort}, int)"/>
        /// <seealso cref="ShiftRightLogical_Core(Vector{ushort}, int, Vector{ushort}, Vector{ushort})"/>
        Vector<ushort> ShiftRightLogical_Args(Vector<ushort> dummy, int shiftAmount, out Vector<ushort> args1);

        /// <summary>
        /// Arguments calculation for shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量的参数计算). Provide arguments for ShiftRightLogical_Core (为 ShiftRightLogical_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftRightLogical_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftRightLogical_Core .</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{int}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector{int}, int)"/>
        /// <seealso cref="ShiftRightLogical_Core(Vector{int}, int, Vector{int}, Vector{int})"/>
        Vector<int> ShiftRightLogical_Args(Vector<int> dummy, int shiftAmount, out Vector<int> args1);

        /// <summary>
        /// Arguments calculation for shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量的参数计算). Provide arguments for ShiftRightLogical_Core (为 ShiftRightLogical_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftRightLogical_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftRightLogical_Core .</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{uint}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector{uint}, int)"/>
        /// <seealso cref="ShiftRightLogical_Core(Vector{uint}, int, Vector{uint}, Vector{uint})"/>
        Vector<uint> ShiftRightLogical_Args(Vector<uint> dummy, int shiftAmount, out Vector<uint> args1);

        /// <summary>
        /// Arguments calculation for shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量的参数计算). Provide arguments for ShiftRightLogical_Core (为 ShiftRightLogical_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftRightLogical_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftRightLogical_Core .</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{long}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector{long}, int)"/>
        /// <seealso cref="ShiftRightLogical_Core(Vector{long}, int, Vector{long}, Vector{long})"/>
        Vector<long> ShiftRightLogical_Args(Vector<long> dummy, int shiftAmount, out Vector<long> args1);

        /// <summary>
        /// Arguments calculation for shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量的参数计算). Provide arguments for ShiftRightLogical_Core (为 ShiftRightLogical_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftRightLogical_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftRightLogical_Core .</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{ulong}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector{ulong}, int)"/>
        /// <seealso cref="ShiftRightLogical_Core(Vector{ulong}, int, Vector{ulong}, Vector{ulong})"/>
        Vector<ulong> ShiftRightLogical_Args(Vector<ulong> dummy, int shiftAmount, out Vector<ulong> args1);

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
        /// <seealso cref="Vector.ShiftRightLogical(Vector{sbyte}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector{sbyte}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector{sbyte}, int, out Vector{sbyte})"/>
        Vector<sbyte> ShiftRightLogical_Core(Vector<sbyte> value, int shiftAmount, Vector<sbyte> args0, Vector<sbyte> args1);

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
        /// <seealso cref="Vector.ShiftRightLogical(Vector{byte}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector{byte}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector{byte}, int, out Vector{byte})"/>
        Vector<byte> ShiftRightLogical_Core(Vector<byte> value, int shiftAmount, Vector<byte> args0, Vector<byte> args1);

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
        /// <seealso cref="Vector.ShiftRightLogical(Vector{short}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector{short}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector{short}, int, out Vector{short})"/>
        Vector<short> ShiftRightLogical_Core(Vector<short> value, int shiftAmount, Vector<short> args0, Vector<short> args1);

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
        /// <seealso cref="Vector.ShiftRightLogical(Vector{ushort}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector{ushort}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector{ushort}, int, out Vector{ushort})"/>
        Vector<ushort> ShiftRightLogical_Core(Vector<ushort> value, int shiftAmount, Vector<ushort> args0, Vector<ushort> args1);

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
        /// <seealso cref="Vector.ShiftRightLogical(Vector{int}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector{int}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector{int}, int, out Vector{int})"/>
        Vector<int> ShiftRightLogical_Core(Vector<int> value, int shiftAmount, Vector<int> args0, Vector<int> args1);

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
        /// <seealso cref="Vector.ShiftRightLogical(Vector{uint}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector{uint}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector{uint}, int, out Vector{uint})"/>
        Vector<uint> ShiftRightLogical_Core(Vector<uint> value, int shiftAmount, Vector<uint> args0, Vector<uint> args1);

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
        /// <seealso cref="Vector.ShiftRightLogical(Vector{long}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector{long}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector{long}, int, out Vector{long})"/>
        Vector<long> ShiftRightLogical_Core(Vector<long> value, int shiftAmount, Vector<long> args0, Vector<long> args1);

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
        /// <seealso cref="Vector.ShiftRightLogical(Vector{ulong}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector{ulong}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector{ulong}, int, out Vector{ulong})"/>
        Vector<ulong> ShiftRightLogical_Core(Vector<ulong> value, int shiftAmount, Vector<ulong> args0, Vector<ulong> args1);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount - Const (将向量的每个无符号元素逻辑右移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~7 (有效范围是 1~7).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{sbyte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector{sbyte}, int)"/>
        Vector<sbyte> ShiftRightLogical_Const(Vector<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount - Const (将向量的每个无符号元素逻辑右移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~7 (有效范围是 1~7).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{byte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector{byte}, int)"/>
        Vector<byte> ShiftRightLogical_Const(Vector<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount - Const (将向量的每个无符号元素逻辑右移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~15 (有效范围是 1~15).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector{short}, int)"/>
        Vector<short> ShiftRightLogical_Const(Vector<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount - Const (将向量的每个无符号元素逻辑右移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~15 (有效范围是 1~15).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{ushort}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector{ushort}, int)"/>
        Vector<ushort> ShiftRightLogical_Const(Vector<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount - Const (将向量的每个无符号元素逻辑右移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~31 (有效范围是 1~31).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector{int}, int)"/>
        Vector<int> ShiftRightLogical_Const(Vector<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount - Const (将向量的每个无符号元素逻辑右移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~31 (有效范围是 1~31).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{uint}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector{uint}, int)"/>
        Vector<uint> ShiftRightLogical_Const(Vector<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount - Const (将向量的每个无符号元素逻辑右移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~63 (有效范围是 1~63).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{long}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector{long}, int)"/>
        Vector<long> ShiftRightLogical_Const(Vector<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount - Const (将向量的每个无符号元素逻辑右移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~63 (有效范围是 1~63).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{ulong}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector{ulong}, int)"/>
        Vector<ulong> ShiftRightLogical_Const(Vector<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount);

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
        /// <seealso cref="Vector.ShiftRightLogical(Vector{sbyte}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector{sbyte}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector{sbyte}, int, out Vector{sbyte})"/>
        Vector<sbyte> ShiftRightLogical_ConstCore(Vector<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector<sbyte> args0, Vector<sbyte> args1);

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
        /// <seealso cref="Vector.ShiftRightLogical(Vector{byte}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector{byte}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector{byte}, int, out Vector{byte})"/>
        Vector<byte> ShiftRightLogical_ConstCore(Vector<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector<byte> args0, Vector<byte> args1);

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
        /// <seealso cref="Vector.ShiftRightLogical(Vector{short}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector{short}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector{short}, int, out Vector{short})"/>
        Vector<short> ShiftRightLogical_ConstCore(Vector<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector<short> args0, Vector<short> args1);

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
        /// <seealso cref="Vector.ShiftRightLogical(Vector{ushort}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector{ushort}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector{ushort}, int, out Vector{ushort})"/>
        Vector<ushort> ShiftRightLogical_ConstCore(Vector<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector<ushort> args0, Vector<ushort> args1);

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
        /// <seealso cref="Vector.ShiftRightLogical(Vector{int}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector{int}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector{int}, int, out Vector{int})"/>
        Vector<int> ShiftRightLogical_ConstCore(Vector<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector<int> args0, Vector<int> args1);

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
        /// <seealso cref="Vector.ShiftRightLogical(Vector{uint}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector{uint}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector{uint}, int, out Vector{uint})"/>
        Vector<uint> ShiftRightLogical_ConstCore(Vector<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector<uint> args0, Vector<uint> args1);

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
        /// <seealso cref="Vector.ShiftRightLogical(Vector{long}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector{long}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector{long}, int, out Vector{long})"/>
        Vector<long> ShiftRightLogical_ConstCore(Vector<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector<long> args0, Vector<long> args1);

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
        /// <seealso cref="Vector.ShiftRightLogical(Vector{ulong}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector{ulong}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector{ulong}, int, out Vector{ulong})"/>
        Vector<ulong> ShiftRightLogical_ConstCore(Vector<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector<ulong> args0, Vector<ulong> args1);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~7 (有效范围是 0~7).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{sbyte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector{sbyte}, int)"/>
        Vector<sbyte> ShiftRightLogical_Fast(Vector<sbyte> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~7 (有效范围是 0~7).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{byte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector{byte}, int)"/>
        Vector<byte> ShiftRightLogical_Fast(Vector<byte> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~15 (有效范围是 0~15).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector{short}, int)"/>
        Vector<short> ShiftRightLogical_Fast(Vector<short> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~15 (有效范围是 0~15).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{ushort}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector{ushort}, int)"/>
        Vector<ushort> ShiftRightLogical_Fast(Vector<ushort> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~31 (有效范围是 0~31).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector{int}, int)"/>
        Vector<int> ShiftRightLogical_Fast(Vector<int> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~31 (有效范围是 0~31).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{uint}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector{uint}, int)"/>
        Vector<uint> ShiftRightLogical_Fast(Vector<uint> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~63 (有效范围是 0~63).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{long}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector{long}, int)"/>
        Vector<long> ShiftRightLogical_Fast(Vector<long> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~63 (有效范围是 0~63).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector.ShiftRightLogical(Vector{ulong}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector{ulong}, int)"/>
        Vector<ulong> ShiftRightLogical_Fast(Vector<ulong> value, int shiftAmount);


        /// <summary>
        /// Types with hardware acceleration when running <c>Shuffle</c> (运行 <c>Shuffle</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Args: Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数).</para>
        /// <para>- Core. Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="Shuffle(Vector{byte}, Vector{byte})"/>: If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).</para>
        /// <para>- <see cref="YShuffleInsert(Vector{byte}, Vector{byte}, Vector{byte})"/>: If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).</para>
        /// <para>- <see cref="YShuffleKernel(Vector{byte}, Vector{byte})"/>: If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). It has the best performance, and is used when you are sure that the index value is not out of range (它的性能最好, 用于确信索引值不会超出范围时).</para>
        /// <para>Related hardware instructions (相关的硬件指令).</para>
        /// <list type="table">
        ///    <listheader>
        ///        <term>Architecture</term>
        ///        <description>8bit</description>
        ///        <description>16bit</description>
        ///        <description>32bit</description>
        ///        <description>64bit</description>
        ///    </listheader>
        ///    <item>
        ///        <term>Arm</term>
        ///        <description><see cref="AdvSimd.Arm64.VectorTableLookup(Vector128{byte}, Vector128{byte})">vqvtbl1q_u8</see></description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///    </item>
        ///    <item>
        ///        <term>Wasm</term>
        ///        <description><see cref="PackedSimd.Swizzle(Vector128{byte}, Vector128{byte})">i8x16.swizzle</see></description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///        <description>(None)</description>
        ///    </item>
        ///    <item>
        ///        <term>X86</term>
        ///        <description>Combine by <see cref="Ssse3.Shuffle(Vector128{byte}, Vector128{byte})">_mm_shuffle_epi8</see>(Ssse3)
        ///        /<see cref="Avx512Vbmi.VL.PermuteVar16x8(Vector128{byte}, Vector128{byte})">_mm_permutexvar_epi8</see>(Avx512Vbmi)</description>
        ///        <description>Combine by <see cref="Avx512BW.VL.PermuteVar8x16(Vector128{ushort}, Vector128{ushort})">_mm_permutexvar_epi16</see>(Avx512BW)</description>
        ///        <description>Same combine by <see cref="Avx2.PermuteVar8x32(Vector256{uint}, Vector256{uint})">_mm256_permutevar8x32_epi32</see>(Avx2)</description>
        ///        <description>Same combine by <see cref="Avx512F.VL.PermuteVar4x64(Vector256{ulong}, Vector256{ulong})">_mm256_permute4x64_pd</see>(Avx512F)</description>
        ///    </item>
        /// </list>
        /// </remarks>
        /// <seealso cref="Shuffle(Vector{byte}, Vector{byte})"/>
        /// <seealso cref="Shuffle_Args(Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        /// <seealso cref="Shuffle_Core(Vector{byte}, Vector{byte}, Vector{byte})"/>
        TypeCodeFlags Shuffle_AcceleratedTypes { get; }

        /// <summary>
        /// Shuffle and clear (换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{float}, Vector128{int})"/>
        /// <seealso cref="Avx2.PermuteVar8x32(Vector256{float}, Vector256{int})"/>
        Vector<float> Shuffle(Vector<float> vector, Vector<int> indices);

        /// <summary>
        /// Shuffle and clear (换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{double}, Vector128{long})"/>
        Vector<double> Shuffle(Vector<double> vector, Vector<long> indices);

        /// <summary>
        /// Shuffle and clear (换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{sbyte}, Vector128{sbyte})"/>
        /// <seealso cref="AdvSimd.VectorTableLookup(Vector128{byte}, Vector64{byte})"/>
        /// <seealso cref="Avx2.Shuffle(Vector256{sbyte}, Vector256{sbyte})"/>
        Vector<sbyte> Shuffle(Vector<sbyte> vector, Vector<sbyte> indices);

        /// <summary>
        /// Shuffle and clear (换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{byte}, Vector128{byte})"/>
        /// <seealso cref="AdvSimd.VectorTableLookup(Vector128{byte}, Vector64{byte})"/>
        /// <seealso cref="Avx2.Shuffle(Vector256{byte}, Vector256{byte})"/>
        Vector<byte> Shuffle(Vector<byte> vector, Vector<byte> indices);

        /// <summary>
        /// Shuffle and clear (换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{short}, Vector128{short})"/>
        Vector<short> Shuffle(Vector<short> vector, Vector<short> indices);

        /// <summary>
        /// Shuffle and clear (换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{ushort}, Vector128{ushort})"/>
        Vector<ushort> Shuffle(Vector<ushort> vector, Vector<ushort> indices);

        /// <summary>
        /// Shuffle and clear (换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{int}, Vector128{int})"/>
        /// <seealso cref="Avx2.PermuteVar8x32(Vector256{int}, Vector256{int})"/>
        Vector<int> Shuffle(Vector<int> vector, Vector<int> indices);

        /// <summary>
        /// Shuffle and clear (换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{uint}, Vector128{uint})"/>
        /// <seealso cref="Avx2.PermuteVar8x32(Vector256{uint}, Vector256{uint})"/>
        Vector<uint> Shuffle(Vector<uint> vector, Vector<uint> indices);

        /// <summary>
        /// Shuffle and clear (换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{long}, Vector128{long})"/>
        Vector<long> Shuffle(Vector<long> vector, Vector<long> indices);

        /// <summary>
        /// Shuffle and clear (换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{ulong}, Vector128{ulong})"/>
        Vector<ulong> Shuffle(Vector<ulong> vector, Vector<ulong> indices);


        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for Shuffle_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for Shuffle_Core .</param>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        void Shuffle_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1);

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for Shuffle_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for Shuffle_Core .</param>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Core(Vector{byte}, Vector{byte}, Vector{byte})"/>
        void Shuffle_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1);

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for Shuffle_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for Shuffle_Core .</param>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Core(Vector{short}, Vector{short}, Vector{short})"/>
        void Shuffle_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1);

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for Shuffle_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for Shuffle_Core .</param>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Core(Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        void Shuffle_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1);

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for Shuffle_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for Shuffle_Core .</param>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Core(Vector{int}, Vector{int}, Vector{int})"/>
        void Shuffle_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1);

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for Shuffle_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for Shuffle_Core .</param>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Core(Vector{uint}, Vector{uint}, Vector{uint})"/>
        void Shuffle_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1);

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for Shuffle_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for Shuffle_Core .</param>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Core(Vector{long}, Vector{long}, Vector{long})"/>
        void Shuffle_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1);

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for Shuffle_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for Shuffle_Core .</param>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Core(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        void Shuffle_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1);


        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from Shuffle_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Args(Vector{int}, out Vector{int}, out Vector{int})"/>
        /// <seealso cref="Avx2.PermuteVar8x32(Vector256{float}, Vector256{int})"/>
        Vector<float> Shuffle_Core(Vector<float> vector, Vector<int> args0, Vector<int> args1);

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from Shuffle_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Args(Vector{long}, out Vector{long}, out Vector{long})"/>
        Vector<double> Shuffle_Core(Vector<double> vector, Vector<long> args0, Vector<long> args1);

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from Shuffle_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        /// <seealso cref="AdvSimd.VectorTableLookup(Vector128{sbyte}, Vector64{sbyte})"/>
        /// <seealso cref="Avx2.Shuffle(Vector256{sbyte}, Vector256{sbyte})"/>
        Vector<sbyte> Shuffle_Core(Vector<sbyte> vector, Vector<sbyte> args0, Vector<sbyte> args1);

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from Shuffle_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Args(Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        /// <seealso cref="AdvSimd.VectorTableLookup(Vector128{byte}, Vector64{byte})"/>
        /// <seealso cref="Avx2.Shuffle(Vector256{byte}, Vector256{byte})"/>
        Vector<byte> Shuffle_Core(Vector<byte> vector, Vector<byte> args0, Vector<byte> args1);

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from Shuffle_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Args(Vector{short}, out Vector{short}, out Vector{short})"/>
        Vector<short> Shuffle_Core(Vector<short> vector, Vector<short> args0, Vector<short> args1);

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from Shuffle_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        Vector<ushort> Shuffle_Core(Vector<ushort> vector, Vector<ushort> args0, Vector<ushort> args1);

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from Shuffle_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Args(Vector{int}, out Vector{int}, out Vector{int})"/>
        /// <seealso cref="Avx2.PermuteVar8x32(Vector256{int}, Vector256{int})"/>
        Vector<int> Shuffle_Core(Vector<int> vector, Vector<int> args0, Vector<int> args1);

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from Shuffle_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Args(Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        /// <seealso cref="Avx2.PermuteVar8x32(Vector256{uint}, Vector256{uint})"/>
        Vector<uint> Shuffle_Core(Vector<uint> vector, Vector<uint> args0, Vector<uint> args1);

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from Shuffle_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Args(Vector{long}, out Vector{long}, out Vector{long})"/>
        Vector<long> Shuffle_Core(Vector<long> vector, Vector<long> args0, Vector<long> args1);

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from Shuffle_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        Vector<ulong> Shuffle_Core(Vector<ulong> vector, Vector<ulong> args0, Vector<ulong> args1);


        /// <summary>
        /// Types with hardware acceleration when running <c>Sum</c> (运行 <c>Sum</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Sum(Vector{byte})"/>
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
        /// <seealso cref="Widen(Vector{byte}, out Vector{ushort}, out Vector{ushort})"/>
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


        /// <summary>
        /// Types with hardware acceleration when running <c>WidenLower</c> (运行 <c>WidenLower</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="WidenLower(Vector{float})" />
        TypeCodeFlags WidenLower_AcceleratedTypes { get; }

        /// <summary>
        /// Widens the lower half of a Vector into a Vector (将向量的低半部分扩宽为一个向量).
        /// Mnemonic: <c>rt[i] := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (欲扩宽其元素的向量).</param>
        /// <returns>A vector that contain the widened lower half of <paramref name="source" /> (包含 <paramref name="source" />的扩宽低半部分 的向量).</returns>
        /// <seealso cref="WidenLower_AcceleratedTypes"/>
        /// <seealso cref="Vector.WidenLower(Vector{float})" />
        Vector<double> WidenLower(Vector<float> source);

        /// <inheritdoc cref="WidenLower(Vector{float})"/>
        /// <seealso cref="Vector.WidenLower(Vector{sbyte})" />
        Vector<short> WidenLower(Vector<sbyte> source);

        /// <inheritdoc cref="WidenLower(Vector{float})"/>
        /// <seealso cref="Vector.WidenLower(Vector{byte})" />
        Vector<ushort> WidenLower(Vector<byte> source);

        /// <inheritdoc cref="WidenLower(Vector{float})"/>
        /// <seealso cref="Vector.WidenLower(Vector{short})" />
        Vector<int> WidenLower(Vector<short> source);

        /// <inheritdoc cref="WidenLower(Vector{float})"/>
        /// <seealso cref="Vector.WidenLower(Vector{ushort})" />
        Vector<uint> WidenLower(Vector<ushort> source);

        /// <inheritdoc cref="WidenLower(Vector{float})"/>
        /// <seealso cref="Vector.WidenLower(Vector{int})" />
        Vector<long> WidenLower(Vector<int> source);

        /// <inheritdoc cref="WidenLower(Vector{float})"/>
        /// <seealso cref="Vector.WidenLower(Vector{uint})" />
        Vector<ulong> WidenLower(Vector<uint> source);


        /// <summary>
        /// Types with hardware acceleration when running <c>WidenUpper</c> (运行 <c>WidenUpper</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="WidenUpper(Vector{float})" />
        TypeCodeFlags WidenUpper_AcceleratedTypes { get; }

        /// <summary>
        /// Widens the upper half of a Vector into a Vector (将向量的高半部分扩宽为一个向量).
        /// Mnemonic: <c>rt[i] := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (欲扩宽其元素的向量).</param>
        /// <returns>A vector that contain the widened upper half of <paramref name="source" /> (包含 <paramref name="source" />的扩宽高半部分 的向量).</returns>
        /// <seealso cref="WidenUpper_AcceleratedTypes"/>
        /// <seealso cref="Vector.WidenUpper(Vector{float})" />
        Vector<double> WidenUpper(Vector<float> source);

        /// <inheritdoc cref="WidenUpper(Vector{float})"/>
        /// <seealso cref="Vector.WidenUpper(Vector{sbyte})" />
        Vector<short> WidenUpper(Vector<sbyte> source);

        /// <inheritdoc cref="WidenUpper(Vector{float})"/>
        /// <seealso cref="Vector.WidenUpper(Vector{byte})" />
        Vector<ushort> WidenUpper(Vector<byte> source);

        /// <inheritdoc cref="WidenUpper(Vector{float})"/>
        /// <seealso cref="Vector.WidenUpper(Vector{short})" />
        Vector<int> WidenUpper(Vector<short> source);

        /// <inheritdoc cref="WidenUpper(Vector{float})"/>
        /// <seealso cref="Vector.WidenUpper(Vector{ushort})" />
        Vector<uint> WidenUpper(Vector<ushort> source);

        /// <inheritdoc cref="WidenUpper(Vector{float})"/>
        /// <seealso cref="Vector.WidenUpper(Vector{int})" />
        Vector<long> WidenUpper(Vector<int> source);

        /// <inheritdoc cref="WidenUpper(Vector{float})"/>
        /// <seealso cref="Vector.WidenUpper(Vector{uint})" />
        Vector<ulong> WidenUpper(Vector<uint> source);

    }
}
