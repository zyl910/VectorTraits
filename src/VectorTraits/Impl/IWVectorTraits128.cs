using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
#if NET5_0_OR_GREATER
using System.Runtime.Intrinsics.Arm;
#endif

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// <see cref="Vector128{T}"/> traits interface (<see cref="Vector128{T}"/> 的特征接口).
    /// </summary>
    [CLSCompliant(false)]
    public partial interface IWVectorTraits128 : IWVectorTraits {
#if NETCOREAPP3_0_OR_GREATER

        // == .NET style  ==

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
        /// <seealso cref="Vector128.Ceiling(Vector128{float})" />
        Vector128<float> Ceiling(Vector128<float> value);

        /// <summary>
        /// Computes the ceiling of each element in a vector (计算向量中每个元素的向上舍入).
        /// Mnemonic: <c>rt[i] := ceiling(value[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its ceiling computed (将计算向上舍入的向量).</param>
        /// <returns>A vector whose elements are the ceiling of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的向上舍入).</returns>
        /// <seealso cref="Ceiling_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Ceiling(Vector128{double})" />
        Vector128<double> Ceiling(Vector128<double> value);


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
        /// <seealso cref="Vector128.ConvertToDouble(Vector128{long})" />
        Vector128<double> ConvertToDouble(Vector128<long> value);

        /// <summary>
        /// Convert to a vector whose elements are of type Double (转换为元素类型是Double的向量)..
        /// Mnemonic: <c>rt[i] := (Double)(value[i])</c>.
        /// </summary>
        /// <param name="value">The source vector (源向量).</param>
        /// <returns>The converted vector (转换后的向量).</returns>
        /// <seealso cref="ConvertToDouble_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ConvertToDouble(Vector128{ulong})" />
        Vector128<double> ConvertToDouble(Vector128<ulong> value);


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
        /// <seealso cref="Vector128.ConvertToInt32(Vector128{float})" />
        Vector128<int> ConvertToInt32(Vector128<float> value);


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
        /// <seealso cref="Vector128.ConvertToInt64(Vector128{long})" />
        Vector128<long> ConvertToInt64(Vector128<double> value);


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
        /// <seealso cref="Vector128.ConvertToSingle(Vector128{int})" />
        Vector128<float> ConvertToSingle(Vector128<int> value);

        /// <summary>
        /// Convert to a vector whose elements are of type Single (转换为元素类型是Single的向量)..
        /// Mnemonic: <c>rt[i] := (Single)(value[i])</c>.
        /// </summary>
        /// <param name="value">The source vector (源向量).</param>
        /// <returns>The converted vector (转换后的向量).</returns>
        /// <seealso cref="ConvertToSingle_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ConvertToSingle(Vector128{uint})" />
        Vector128<float> ConvertToSingle(Vector128<uint> value);


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
        /// <seealso cref="Vector128.ConvertToUInt32(Vector128{float})" />
        Vector128<uint> ConvertToUInt32(Vector128<float> value);


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
        /// <seealso cref="Vector128.ConvertToUInt64(Vector128{double})" />
        Vector128<ulong> ConvertToUInt64(Vector128<double> value);


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
        /// <seealso cref="Vector128.ExtractMostSignificantBits{T}(Vector128{T})" />
        uint ExtractMostSignificantBits(Vector128<float> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ExtractMostSignificantBits{T}(Vector128{T})" />
        uint ExtractMostSignificantBits(Vector128<double> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ExtractMostSignificantBits{T}(Vector128{T})" />
        uint ExtractMostSignificantBits(Vector128<sbyte> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ExtractMostSignificantBits{T}(Vector128{T})" />
        uint ExtractMostSignificantBits(Vector128<byte> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ExtractMostSignificantBits{T}(Vector128{T})" />
        uint ExtractMostSignificantBits(Vector128<short> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ExtractMostSignificantBits{T}(Vector128{T})" />
        uint ExtractMostSignificantBits(Vector128<ushort> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ExtractMostSignificantBits{T}(Vector128{T})" />
        uint ExtractMostSignificantBits(Vector128<int> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ExtractMostSignificantBits{T}(Vector128{T})" />
        uint ExtractMostSignificantBits(Vector128<uint> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ExtractMostSignificantBits{T}(Vector128{T})" />
        uint ExtractMostSignificantBits(Vector128<long> vector);

        /// <summary>
        /// Extracts the most significant bit from each element in a vector (从向量的每个元素中提取最高有效位).
        /// Mnemonic: <c>rt |= getMostSignificantBit(vector[i]) &lt;&lt; i = ( vector[i] &gt;&gt;&gt; (sizeof(T)*8-1) ) &lt;&lt; i</c>.
        /// </summary>
        /// <param name="vector">The vector whose elements should have their most significant bit extracted (欲对所有元素提取最高有效位的向量).</param>
        /// <returns>The packed most significant bits extracted from the elements in <paramref name="vector" /> (从 <paramref name="vector" /> 中各元素中提取的最高有效位的紧缩值).</returns>
        /// <seealso cref="ExtractMostSignificantBits_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ExtractMostSignificantBits{T}(Vector128{T})" />
        uint ExtractMostSignificantBits(Vector128<ulong> vector);


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
        /// <seealso cref="Vector128.Floor(Vector128{float})" />
        Vector128<float> Floor(Vector128<float> value);

        /// <summary>
        /// Computes the floor of each element in a vector (计算向量中每个元素的向下舍入).
        /// Mnemonic: <c>rt[i] := floor(value[i])</c>.
        /// </summary>
        /// <param name="value">The vector that will have its floor computed (将计算向下舍入的向量).</param>
        /// <returns>A vector whose elements are the floor of the elements in <paramref name="value" /> (一个向量，其元素是 <paramref name="value" /> 中各元素的向下舍入).</returns>
        /// <seealso cref="Floor_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Floor(Vector128{double})" />
        Vector128<double> Floor(Vector128<double> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>Narrow</c> (运行 <c>Narrow</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Narrow"/>
        TypeCodeFlags Narrow_AcceleratedTypes { get; }

        /// <summary>
        /// Narrows two <seealso cref="Vector128{T}"/> instances into one <seealso cref="Vector128{T}"/>"  (将两个 <seealso cref="Vector128{T}"/> 实例缩窄为一个 <seealso cref="Vector128{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow(element_ref(i, lower, upper))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector128{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="Narrow_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Narrow(Vector128{double}, Vector128{double})" />
        Vector128<float> Narrow(Vector128<double> lower, Vector128<double> upper);

        /// <summary>
        /// Narrows two <seealso cref="Vector128{T}"/> instances into one <seealso cref="Vector128{T}"/>"  (将两个 <seealso cref="Vector128{T}"/> 实例缩窄为一个 <seealso cref="Vector128{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow(element_ref(i, lower, upper))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector128{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="Narrow_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Narrow(Vector128{short}, Vector128{short})" />
        Vector128<sbyte> Narrow(Vector128<short> lower, Vector128<short> upper);

        /// <summary>
        /// Narrows two <seealso cref="Vector128{T}"/> instances into one <seealso cref="Vector128{T}"/>"  (将两个 <seealso cref="Vector128{T}"/> 实例缩窄为一个 <seealso cref="Vector128{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow(element_ref(i, lower, upper))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector128{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="Narrow_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Narrow(Vector128{ushort}, Vector128{ushort})" />
        Vector128<byte> Narrow(Vector128<ushort> lower, Vector128<ushort> upper);

        /// <summary>
        /// Narrows two <seealso cref="Vector128{T}"/> instances into one <seealso cref="Vector128{T}"/>"  (将两个 <seealso cref="Vector128{T}"/> 实例缩窄为一个 <seealso cref="Vector128{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow(element_ref(i, lower, upper))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector128{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="Narrow_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Narrow(Vector128{int}, Vector128{int})" />
        Vector128<short> Narrow(Vector128<int> lower, Vector128<int> upper);

        /// <summary>
        /// Narrows two <seealso cref="Vector128{T}"/> instances into one <seealso cref="Vector128{T}"/>"  (将两个 <seealso cref="Vector128{T}"/> 实例缩窄为一个 <seealso cref="Vector128{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow(element_ref(i, lower, upper))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector128{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="Narrow_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Narrow(Vector128{uint}, Vector128{uint})" />
        Vector128<ushort> Narrow(Vector128<uint> lower, Vector128<uint> upper);

        /// <summary>
        /// Narrows two <seealso cref="Vector128{T}"/> instances into one <seealso cref="Vector128{T}"/>"  (将两个 <seealso cref="Vector128{T}"/> 实例缩窄为一个 <seealso cref="Vector128{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow(element_ref(i, lower, upper))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector128{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="Narrow_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Narrow(Vector128{long}, Vector128{long})" />
        Vector128<int> Narrow(Vector128<long> lower, Vector128<long> upper);

        /// <summary>
        /// Narrows two <seealso cref="Vector128{T}"/> instances into one <seealso cref="Vector128{T}"/>"  (将两个 <seealso cref="Vector128{T}"/> 实例缩窄为一个 <seealso cref="Vector128{T}"/> ). />.
        /// Mnemonic: <c>rt[i] := narrow(element_ref(i, lower, upper))</c>.
        /// </summary>
        /// <param name="lower">The vector that will be narrowed to the lower half of the result vector (构成缩窄结果向量的低半部分向量).</param>
        /// <param name="upper">The vector that will be narrowed to the upper half of the result vector (构成缩窄结果向量的高半部分向量).</param>
        /// <returns>A <seealso cref="Vector128{T}"/> containing elements narrowed from <paramref name="lower" /> and <paramref name="upper" /> (一个包含了来自 <paramref name="lower" /> 与 <paramref name="upper" /> 缩窄元素的向量).</returns>
        /// <seealso cref="Narrow_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Narrow(Vector128{ulong}, Vector128{ulong})" />
        Vector128<uint> Narrow(Vector128<ulong> lower, Vector128<ulong> upper);


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
        /// <seealso cref="ShiftLeft"/>
        /// <seealso cref="ShiftLeft_Args"/>
        /// <seealso cref="ShiftLeft_Core"/>
        /// <seealso cref="ShiftLeft_Const"/>
        /// <seealso cref="ShiftLeft_ConstCore"/>
        /// <seealso cref="ShiftLeft_Fast"/>
        TypeCodeFlags ShiftLeft_AcceleratedTypes { get; }

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftLeft(Vector128{sbyte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft_Fast(Vector128{sbyte}, int)"/>
        Vector128<sbyte> ShiftLeft(Vector128<sbyte> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftLeft(Vector128{byte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft_Fast(Vector128{byte}, int)"/>
        Vector128<byte> ShiftLeft(Vector128<byte> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftLeft(Vector128{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft_Fast(Vector128{short}, int)"/>
        Vector128<short> ShiftLeft(Vector128<short> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftLeft(Vector128{ushort}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft_Fast(Vector128{ushort}, int)"/>
        Vector128<ushort> ShiftLeft(Vector128<ushort> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftLeft(Vector128{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft_Fast(Vector128{int}, int)"/>
        Vector128<int> ShiftLeft(Vector128<int> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftLeft(Vector128{uint}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft_Fast(Vector128{uint}, int)"/>
        Vector128<uint> ShiftLeft(Vector128<uint> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftLeft(Vector128{long}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft_Fast(Vector128{long}, int)"/>
        Vector128<long> ShiftLeft(Vector128<long> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftLeft(Vector128{ulong}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft_Fast(Vector128{ulong}, int)"/>
        Vector128<ulong> ShiftLeft(Vector128<ulong> value, int shiftAmount);


        /// <summary>
        /// Arguments calculation for shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量的参数计算). Provide arguments for ShiftLeft_Core (为 ShiftLeft_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftLeft_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftLeft_Core .</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftLeft(Vector128{sbyte}, int)"/>
        /// <seealso cref="ShiftLeft(Vector128{sbyte}, int)"/>
        /// <seealso cref="ShiftLeft_Core(Vector128{sbyte}, int, Vector128{sbyte}, Vector128{sbyte})"/>
        Vector128<sbyte> ShiftLeft_Args(Vector128<sbyte> dummy, int shiftAmount, out Vector128<sbyte> args1);

        /// <summary>
        /// Arguments calculation for shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量的参数计算). Provide arguments for ShiftLeft_Core (为 ShiftLeft_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftLeft_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftLeft_Core .</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftLeft(Vector128{byte}, int)"/>
        /// <seealso cref="ShiftLeft(Vector128{byte}, int)"/>
        /// <seealso cref="ShiftLeft_Core(Vector128{byte}, int, Vector128{byte}, Vector128{byte})"/>
        Vector128<byte> ShiftLeft_Args(Vector128<byte> dummy, int shiftAmount, out Vector128<byte> args1);

        /// <summary>
        /// Arguments calculation for shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量的参数计算). Provide arguments for ShiftLeft_Core (为 ShiftLeft_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftLeft_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftLeft_Core .</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftLeft(Vector128{short}, int)"/>
        /// <seealso cref="ShiftLeft(Vector128{short}, int)"/>
        /// <seealso cref="ShiftLeft_Core(Vector128{short}, int, Vector128{short}, Vector128{short})"/>
        Vector128<short> ShiftLeft_Args(Vector128<short> dummy, int shiftAmount, out Vector128<short> args1);

        /// <summary>
        /// Arguments calculation for shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量的参数计算). Provide arguments for ShiftLeft_Core (为 ShiftLeft_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftLeft_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftLeft_Core .</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftLeft(Vector128{ushort}, int)"/>
        /// <seealso cref="ShiftLeft(Vector128{ushort}, int)"/>
        /// <seealso cref="ShiftLeft_Core(Vector128{ushort}, int, Vector128{ushort}, Vector128{ushort})"/>
        Vector128<ushort> ShiftLeft_Args(Vector128<ushort> dummy, int shiftAmount, out Vector128<ushort> args1);

        /// <summary>
        /// Arguments calculation for shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量的参数计算). Provide arguments for ShiftLeft_Core (为 ShiftLeft_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftLeft_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftLeft_Core .</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftLeft(Vector128{int}, int)"/>
        /// <seealso cref="ShiftLeft(Vector128{int}, int)"/>
        /// <seealso cref="ShiftLeft_Core(Vector128{int}, int, Vector128{int}, Vector128{int})"/>
        Vector128<int> ShiftLeft_Args(Vector128<int> dummy, int shiftAmount, out Vector128<int> args1);

        /// <summary>
        /// Arguments calculation for shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量的参数计算). Provide arguments for ShiftLeft_Core (为 ShiftLeft_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftLeft_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftLeft_Core .</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftLeft(Vector128{uint}, int)"/>
        /// <seealso cref="ShiftLeft(Vector128{uint}, int)"/>
        /// <seealso cref="ShiftLeft_Core(Vector128{uint}, int, Vector128{uint}, Vector128{uint})"/>
        Vector128<uint> ShiftLeft_Args(Vector128<uint> dummy, int shiftAmount, out Vector128<uint> args1);

        /// <summary>
        /// Arguments calculation for shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量的参数计算). Provide arguments for ShiftLeft_Core (为 ShiftLeft_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftLeft_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftLeft_Core .</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftLeft(Vector128{long}, int)"/>
        /// <seealso cref="ShiftLeft(Vector128{long}, int)"/>
        /// <seealso cref="ShiftLeft_Core(Vector128{long}, int, Vector128{long}, Vector128{long})"/>
        Vector128<long> ShiftLeft_Args(Vector128<long> dummy, int shiftAmount, out Vector128<long> args1);

        /// <summary>
        /// Arguments calculation for shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量的参数计算). Provide arguments for ShiftLeft_Core (为 ShiftLeft_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftLeft_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftLeft_Core .</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftLeft(Vector128{ulong}, int)"/>
        /// <seealso cref="ShiftLeft(Vector128{ulong}, int)"/>
        /// <seealso cref="ShiftLeft_Core(Vector128{ulong}, int, Vector128{ulong}, Vector128{ulong})"/>
        Vector128<ulong> ShiftLeft_Args(Vector128<ulong> dummy, int shiftAmount, out Vector128<ulong> args1);

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
        /// <seealso cref="Vector128.ShiftLeft(Vector128{sbyte}, int)"/>
        /// <seealso cref="ShiftLeft(Vector128{sbyte}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector128{sbyte}, int, out Vector128{sbyte})"/>
        Vector128<sbyte> ShiftLeft_Core(Vector128<sbyte> value, int shiftAmount, Vector128<sbyte> args0, Vector128<sbyte> args1);

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
        /// <seealso cref="Vector128.ShiftLeft(Vector128{byte}, int)"/>
        /// <seealso cref="ShiftLeft(Vector128{byte}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector128{byte}, int, out Vector128{byte})"/>
        Vector128<byte> ShiftLeft_Core(Vector128<byte> value, int shiftAmount, Vector128<byte> args0, Vector128<byte> args1);

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
        /// <seealso cref="Vector128.ShiftLeft(Vector128{short}, int)"/>
        /// <seealso cref="ShiftLeft(Vector128{short}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector128{short}, int, out Vector128{short})"/>
        Vector128<short> ShiftLeft_Core(Vector128<short> value, int shiftAmount, Vector128<short> args0, Vector128<short> args1);

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
        /// <seealso cref="Vector128.ShiftLeft(Vector128{ushort}, int)"/>
        /// <seealso cref="ShiftLeft(Vector128{ushort}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector128{ushort}, int, out Vector128{ushort})"/>
        Vector128<ushort> ShiftLeft_Core(Vector128<ushort> value, int shiftAmount, Vector128<ushort> args0, Vector128<ushort> args1);

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
        /// <seealso cref="Vector128.ShiftLeft(Vector128{int}, int)"/>
        /// <seealso cref="ShiftLeft(Vector128{int}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector128{int}, int, out Vector128{int})"/>
        Vector128<int> ShiftLeft_Core(Vector128<int> value, int shiftAmount, Vector128<int> args0, Vector128<int> args1);

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
        /// <seealso cref="Vector128.ShiftLeft(Vector128{uint}, int)"/>
        /// <seealso cref="ShiftLeft(Vector128{uint}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector128{uint}, int, out Vector128{uint})"/>
        Vector128<uint> ShiftLeft_Core(Vector128<uint> value, int shiftAmount, Vector128<uint> args0, Vector128<uint> args1);

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
        /// <seealso cref="Vector128.ShiftLeft(Vector128{long}, int)"/>
        /// <seealso cref="ShiftLeft(Vector128{long}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector128{long}, int, out Vector128{long})"/>
        Vector128<long> ShiftLeft_Core(Vector128<long> value, int shiftAmount, Vector128<long> args0, Vector128<long> args1);

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
        /// <seealso cref="Vector128.ShiftLeft(Vector128{ulong}, int)"/>
        /// <seealso cref="ShiftLeft(Vector128{ulong}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector128{ulong}, int, out Vector128{ulong})"/>
        Vector128<ulong> ShiftLeft_Core(Vector128<ulong> value, int shiftAmount, Vector128<ulong> args0, Vector128<ulong> args1);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Const (将向量的每个元素左移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~7 (有效范围是 1~7).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftLeft(Vector128{sbyte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector128{sbyte}, int)"/>
        Vector128<sbyte> ShiftLeft_Const(Vector128<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Const (将向量的每个元素左移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~7 (有效范围是 1~7).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftLeft(Vector128{byte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector128{byte}, int)"/>
        Vector128<byte> ShiftLeft_Const(Vector128<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Const (将向量的每个元素左移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~15 (有效范围是 1~15).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftLeft(Vector128{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector128{short}, int)"/>
        Vector128<short> ShiftLeft_Const(Vector128<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Const (将向量的每个元素左移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~15 (有效范围是 1~15).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftLeft(Vector128{ushort}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector128{ushort}, int)"/>
        Vector128<ushort> ShiftLeft_Const(Vector128<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Const (将向量的每个元素左移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~31 (有效范围是 1~31).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftLeft(Vector128{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector128{int}, int)"/>
        Vector128<int> ShiftLeft_Const(Vector128<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Const (将向量的每个元素左移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~31 (有效范围是 1~31).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftLeft(Vector128{uint}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector128{uint}, int)"/>
        Vector128<uint> ShiftLeft_Const(Vector128<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Const (将向量的每个元素左移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~63 (有效范围是 1~63).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftLeft(Vector128{long}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector128{long}, int)"/>
        Vector128<long> ShiftLeft_Const(Vector128<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Const (将向量的每个元素左移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~63 (有效范围是 1~63).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftLeft(Vector128{ulong}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector128{ulong}, int)"/>
        Vector128<ulong> ShiftLeft_Const(Vector128<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount);

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
        /// <seealso cref="Vector128.ShiftLeft(Vector128{sbyte}, int)"/>
        /// <seealso cref="ShiftLeft(Vector128{sbyte}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector128{sbyte}, int, out Vector128{sbyte})"/>
        Vector128<sbyte> ShiftLeft_ConstCore(Vector128<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector128<sbyte> args0, Vector128<sbyte> args1);

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
        /// <seealso cref="Vector128.ShiftLeft(Vector128{byte}, int)"/>
        /// <seealso cref="ShiftLeft(Vector128{byte}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector128{byte}, int, out Vector128{byte})"/>
        Vector128<byte> ShiftLeft_ConstCore(Vector128<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector128<byte> args0, Vector128<byte> args1);

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
        /// <seealso cref="Vector128.ShiftLeft(Vector128{short}, int)"/>
        /// <seealso cref="ShiftLeft(Vector128{short}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector128{short}, int, out Vector128{short})"/>
        Vector128<short> ShiftLeft_ConstCore(Vector128<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector128<short> args0, Vector128<short> args1);

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
        /// <seealso cref="Vector128.ShiftLeft(Vector128{ushort}, int)"/>
        /// <seealso cref="ShiftLeft(Vector128{ushort}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector128{ushort}, int, out Vector128{ushort})"/>
        Vector128<ushort> ShiftLeft_ConstCore(Vector128<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector128<ushort> args0, Vector128<ushort> args1);

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
        /// <seealso cref="Vector128.ShiftLeft(Vector128{int}, int)"/>
        /// <seealso cref="ShiftLeft(Vector128{int}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector128{int}, int, out Vector128{int})"/>
        Vector128<int> ShiftLeft_ConstCore(Vector128<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector128<int> args0, Vector128<int> args1);

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
        /// <seealso cref="Vector128.ShiftLeft(Vector128{uint}, int)"/>
        /// <seealso cref="ShiftLeft(Vector128{uint}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector128{uint}, int, out Vector128{uint})"/>
        Vector128<uint> ShiftLeft_ConstCore(Vector128<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector128<uint> args0, Vector128<uint> args1);

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
        /// <seealso cref="Vector128.ShiftLeft(Vector128{long}, int)"/>
        /// <seealso cref="ShiftLeft(Vector128{long}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector128{long}, int, out Vector128{long})"/>
        Vector128<long> ShiftLeft_ConstCore(Vector128<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector128<long> args0, Vector128<long> args1);

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
        /// <seealso cref="Vector128.ShiftLeft(Vector128{ulong}, int)"/>
        /// <seealso cref="ShiftLeft(Vector128{ulong}, int)"/>
        /// <seealso cref="ShiftLeft_Args(Vector128{ulong}, int, out Vector128{ulong})"/>
        Vector128<ulong> ShiftLeft_ConstCore(Vector128<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector128<ulong> args0, Vector128<ulong> args1);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~7 (有效范围是 0~7).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftLeft(Vector128{sbyte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector128{sbyte}, int)"/>
        Vector128<sbyte> ShiftLeft_Fast(Vector128<sbyte> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~7 (有效范围是 0~7).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftLeft(Vector128{byte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector128{byte}, int)"/>
        Vector128<byte> ShiftLeft_Fast(Vector128<byte> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~15 (有效范围是 0~15).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftLeft(Vector128{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector128{short}, int)"/>
        Vector128<short> ShiftLeft_Fast(Vector128<short> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~15 (有效范围是 0~15).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftLeft(Vector128{ushort}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector128{ushort}, int)"/>
        Vector128<ushort> ShiftLeft_Fast(Vector128<ushort> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~31 (有效范围是 0~31).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftLeft(Vector128{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector128{int}, int)"/>
        Vector128<int> ShiftLeft_Fast(Vector128<int> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~31 (有效范围是 0~31).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftLeft(Vector128{uint}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector128{uint}, int)"/>
        Vector128<uint> ShiftLeft_Fast(Vector128<uint> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~63 (有效范围是 0~63).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftLeft(Vector128{long}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector128{long}, int)"/>
        Vector128<long> ShiftLeft_Fast(Vector128<long> value, int shiftAmount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount - Fast (将向量的每个元素左移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first.
        /// Mnemonic: <c>rt[i] := value[i] &lt;&lt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~63 (有效范围是 0~63).</param>
        /// <returns>A vector whose elements where shifted left by <paramref name="shiftAmount" /> (每个元素的左移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftLeft_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftLeft(Vector128{ulong}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftLeft(Vector128{ulong}, int)"/>
        Vector128<ulong> ShiftLeft_Fast(Vector128<ulong> value, int shiftAmount);


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
        /// <seealso cref="ShiftRightArithmetic"/>
        /// <seealso cref="ShiftRightArithmetic_Args"/>
        /// <seealso cref="ShiftRightArithmetic_Core"/>
        /// <seealso cref="ShiftRightArithmetic_Const"/>
        /// <seealso cref="ShiftRightArithmetic_ConstCore"/>
        /// <seealso cref="ShiftRightArithmetic_Fast"/>
        TypeCodeFlags ShiftRightArithmetic_AcceleratedTypes { get; }

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightArithmetic(Vector128{sbyte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic_Fast(Vector128{sbyte}, int)"/>
        Vector128<sbyte> ShiftRightArithmetic(Vector128<sbyte> value, int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightArithmetic(Vector128{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic_Fast(Vector128{short}, int)"/>
        Vector128<short> ShiftRightArithmetic(Vector128<short> value, int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightArithmetic(Vector128{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic_Fast(Vector128{int}, int)"/>
        Vector128<int> ShiftRightArithmetic(Vector128<int> value, int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightArithmetic(Vector128{long}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic_Fast(Vector128{long}, int)"/>
        Vector128<long> ShiftRightArithmetic(Vector128<long> value, int shiftAmount);

        /// <summary>
        /// Arguments calculation for shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量的参数计算). Provide arguments for ShiftRightArithmetic_Core (为 ShiftRightArithmetic_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftRightArithmetic_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftRightArithmetic_Core .</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightArithmetic(Vector128{sbyte}, int)"/>
        /// <seealso cref="ShiftRightArithmetic(Vector128{sbyte}, int)"/>
        /// <seealso cref="ShiftRightArithmetic_Core(Vector128{sbyte}, int, Vector128{sbyte}, Vector128{sbyte})"/>
        Vector128<sbyte> ShiftRightArithmetic_Args(Vector128<sbyte> dummy, int shiftAmount, out Vector128<sbyte> args1);

        /// <summary>
        /// Arguments calculation for shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量的参数计算). Provide arguments for ShiftRightArithmetic_Core (为 ShiftRightArithmetic_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftRightArithmetic_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftRightArithmetic_Core .</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightArithmetic(Vector128{short}, int)"/>
        /// <seealso cref="ShiftRightArithmetic(Vector128{short}, int)"/>
        /// <seealso cref="ShiftRightArithmetic_Core(Vector128{short}, int, Vector128{short}, Vector128{short})"/>
        Vector128<short> ShiftRightArithmetic_Args(Vector128<short> dummy, int shiftAmount, out Vector128<short> args1);

        /// <summary>
        /// Arguments calculation for shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量的参数计算). Provide arguments for ShiftRightArithmetic_Core (为 ShiftRightArithmetic_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftRightArithmetic_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftRightArithmetic_Core .</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightArithmetic(Vector128{int}, int)"/>
        /// <seealso cref="ShiftRightArithmetic(Vector128{int}, int)"/>
        /// <seealso cref="ShiftRightArithmetic_Core(Vector128{int}, int, Vector128{int}, Vector128{int})"/>
        Vector128<int> ShiftRightArithmetic_Args(Vector128<int> dummy, int shiftAmount, out Vector128<int> args1);

        /// <summary>
        /// Arguments calculation for shifts (signed) each element of a vector right by the specified amount (将向量的每个有符号元素算术右移指定量的参数计算). Provide arguments for ShiftRightArithmetic_Core (为 ShiftRightArithmetic_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftRightArithmetic_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftRightArithmetic_Core .</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightArithmetic(Vector128{long}, int)"/>
        /// <seealso cref="ShiftRightArithmetic(Vector128{long}, int)"/>
        /// <seealso cref="ShiftRightArithmetic_Core(Vector128{long}, int, Vector128{long}, Vector128{long})"/>
        Vector128<long> ShiftRightArithmetic_Args(Vector128<long> dummy, int shiftAmount, out Vector128<long> args1);

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
        /// <seealso cref="Vector128.ShiftRightArithmetic(Vector128{sbyte}, int)"/>
        /// <seealso cref="ShiftRightArithmetic(Vector128{sbyte}, int)"/>
        /// <seealso cref="ShiftRightArithmetic_Args(Vector128{sbyte}, int, out Vector128{sbyte})"/>
        Vector128<sbyte> ShiftRightArithmetic_Core(Vector128<sbyte> value, int shiftAmount, Vector128<sbyte> args0, Vector128<sbyte> args1);

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
        /// <seealso cref="Vector128.ShiftRightArithmetic(Vector128{short}, int)"/>
        /// <seealso cref="ShiftRightArithmetic(Vector128{short}, int)"/>
        /// <seealso cref="ShiftRightArithmetic_Args(Vector128{short}, int, out Vector128{short})"/>
        Vector128<short> ShiftRightArithmetic_Core(Vector128<short> value, int shiftAmount, Vector128<short> args0, Vector128<short> args1);

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
        /// <seealso cref="Vector128.ShiftRightArithmetic(Vector128{int}, int)"/>
        /// <seealso cref="ShiftRightArithmetic(Vector128{int}, int)"/>
        /// <seealso cref="ShiftRightArithmetic_Args(Vector128{int}, int, out Vector128{int})"/>
        Vector128<int> ShiftRightArithmetic_Core(Vector128<int> value, int shiftAmount, Vector128<int> args0, Vector128<int> args1);

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
        /// <seealso cref="Vector128.ShiftRightArithmetic(Vector128{long}, int)"/>
        /// <seealso cref="ShiftRightArithmetic(Vector128{long}, int)"/>
        /// <seealso cref="ShiftRightArithmetic_Args(Vector128{long}, int, out Vector128{long})"/>
        Vector128<long> ShiftRightArithmetic_Core(Vector128<long> value, int shiftAmount, Vector128<long> args0, Vector128<long> args1);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount - Const(将向量的每个有符号元素算术右移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~7 (有效范围是 1~7).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightArithmetic(Vector128{sbyte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic(Vector128{sbyte}, int)"/>
        Vector128<sbyte> ShiftRightArithmetic_Const(Vector128<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount - Const(将向量的每个有符号元素算术右移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~15 (有效范围是 1~15).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightArithmetic(Vector128{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic(Vector128{short}, int)"/>
        Vector128<short> ShiftRightArithmetic_Const(Vector128<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount - Const(将向量的每个有符号元素算术右移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~31 (有效范围是 1~31).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightArithmetic(Vector128{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic(Vector128{int}, int)"/>
        Vector128<int> ShiftRightArithmetic_Const(Vector128<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount - Const(将向量的每个有符号元素算术右移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~63 (有效范围是 1~63).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightArithmetic(Vector128{long}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic(Vector128{long}, int)"/>
        Vector128<long> ShiftRightArithmetic_Const(Vector128<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount);

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
        /// <seealso cref="Vector128.ShiftRightArithmetic(Vector128{sbyte}, int)"/>
        /// <seealso cref="ShiftRightArithmetic(Vector128{sbyte}, int)"/>
        /// <seealso cref="ShiftRightArithmetic_Args(Vector128{sbyte}, int, out Vector128{sbyte})"/>
        Vector128<sbyte> ShiftRightArithmetic_ConstCore(Vector128<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector128<sbyte> args0, Vector128<sbyte> args1);

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
        /// <seealso cref="Vector128.ShiftRightArithmetic(Vector128{short}, int)"/>
        /// <seealso cref="ShiftRightArithmetic(Vector128{short}, int)"/>
        /// <seealso cref="ShiftRightArithmetic_Args(Vector128{short}, int, out Vector128{short})"/>
        Vector128<short> ShiftRightArithmetic_ConstCore(Vector128<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector128<short> args0, Vector128<short> args1);

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
        /// <seealso cref="Vector128.ShiftRightArithmetic(Vector128{int}, int)"/>
        /// <seealso cref="ShiftRightArithmetic(Vector128{int}, int)"/>
        /// <seealso cref="ShiftRightArithmetic_Args(Vector128{int}, int, out Vector128{int})"/>
        Vector128<int> ShiftRightArithmetic_ConstCore(Vector128<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector128<int> args0, Vector128<int> args1);

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
        /// <seealso cref="Vector128.ShiftRightArithmetic(Vector128{long}, int)"/>
        /// <seealso cref="ShiftRightArithmetic(Vector128{long}, int)"/>
        /// <seealso cref="ShiftRightArithmetic_Args(Vector128{long}, int, out Vector128{long})"/>
        Vector128<long> ShiftRightArithmetic_ConstCore(Vector128<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector128<long> args0, Vector128<long> args1);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount - Fast(将向量的每个有符号元素算术右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~7 (有效范围是 0~7).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightArithmetic(Vector128{sbyte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic(Vector128{sbyte}, int)"/>
        Vector128<sbyte> ShiftRightArithmetic_Fast(Vector128<sbyte> value, int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount - Fast(将向量的每个有符号元素算术右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~15 (有效范围是 0~15).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightArithmetic(Vector128{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic(Vector128{short}, int)"/>
        Vector128<short> ShiftRightArithmetic_Fast(Vector128<short> value, int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount - Fast(将向量的每个有符号元素算术右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~31 (有效范围是 0~31).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightArithmetic(Vector128{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic(Vector128{int}, int)"/>
        Vector128<int> ShiftRightArithmetic_Fast(Vector128<int> value, int shiftAmount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount - Fast(将向量的每个有符号元素算术右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~63 (有效范围是 0~63).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightArithmetic_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightArithmetic(Vector128{long}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightArithmetic(Vector128{long}, int)"/>
        Vector128<long> ShiftRightArithmetic_Fast(Vector128<long> value, int shiftAmount);


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
        /// <seealso cref="ShiftRightLogical"/>
        /// <seealso cref="ShiftRightLogical_Args"/>
        /// <seealso cref="ShiftRightLogical_Core"/>
        /// <seealso cref="ShiftRightLogical_Const"/>
        /// <seealso cref="ShiftRightLogical_ConstCore"/>
        /// <seealso cref="ShiftRightLogical_Fast"/>
        TypeCodeFlags ShiftRightLogical_AcceleratedTypes { get; }

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{sbyte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical_Fast(Vector128{sbyte}, int)"/>
        Vector128<sbyte> ShiftRightLogical(Vector128<sbyte> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{byte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical_Fast(Vector128{byte}, int)"/>
        Vector128<byte> ShiftRightLogical(Vector128<byte> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical_Fast(Vector128{short}, int)"/>
        Vector128<short> ShiftRightLogical(Vector128<short> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{ushort}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical_Fast(Vector128{ushort}, int)"/>
        Vector128<ushort> ShiftRightLogical(Vector128<ushort> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical_Fast(Vector128{int}, int)"/>
        Vector128<int> ShiftRightLogical(Vector128<int> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{uint}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical_Fast(Vector128{uint}, int)"/>
        Vector128<uint> ShiftRightLogical(Vector128<uint> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{long}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical_Fast(Vector128{long}, int)"/>
        Vector128<long> ShiftRightLogical(Vector128<long> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{ulong}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical_Fast(Vector128{ulong}, int)"/>
        Vector128<ulong> ShiftRightLogical(Vector128<ulong> value, int shiftAmount);

        /// <summary>
        /// Arguments calculation for shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量的参数计算). Provide arguments for ShiftRightLogical_Core (为 ShiftRightLogical_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftRightLogical_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftRightLogical_Core .</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{sbyte}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector128{sbyte}, int)"/>
        /// <seealso cref="ShiftRightLogical_Core(Vector128{sbyte}, int, Vector128{sbyte}, Vector128{sbyte})"/>
        Vector128<sbyte> ShiftRightLogical_Args(Vector128<sbyte> dummy, int shiftAmount, out Vector128<sbyte> args1);

        /// <summary>
        /// Arguments calculation for shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量的参数计算). Provide arguments for ShiftRightLogical_Core (为 ShiftRightLogical_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftRightLogical_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftRightLogical_Core .</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{byte}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector128{byte}, int)"/>
        /// <seealso cref="ShiftRightLogical_Core(Vector128{byte}, int, Vector128{byte}, Vector128{byte})"/>
        Vector128<byte> ShiftRightLogical_Args(Vector128<byte> dummy, int shiftAmount, out Vector128<byte> args1);

        /// <summary>
        /// Arguments calculation for shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量的参数计算). Provide arguments for ShiftRightLogical_Core (为 ShiftRightLogical_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftRightLogical_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftRightLogical_Core .</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{short}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector128{short}, int)"/>
        /// <seealso cref="ShiftRightLogical_Core(Vector128{short}, int, Vector128{short}, Vector128{short})"/>
        Vector128<short> ShiftRightLogical_Args(Vector128<short> dummy, int shiftAmount, out Vector128<short> args1);

        /// <summary>
        /// Arguments calculation for shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量的参数计算). Provide arguments for ShiftRightLogical_Core (为 ShiftRightLogical_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftRightLogical_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftRightLogical_Core .</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{ushort}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector128{ushort}, int)"/>
        /// <seealso cref="ShiftRightLogical_Core(Vector128{ushort}, int, Vector128{ushort}, Vector128{ushort})"/>
        Vector128<ushort> ShiftRightLogical_Args(Vector128<ushort> dummy, int shiftAmount, out Vector128<ushort> args1);

        /// <summary>
        /// Arguments calculation for shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量的参数计算). Provide arguments for ShiftRightLogical_Core (为 ShiftRightLogical_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftRightLogical_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftRightLogical_Core .</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{int}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector128{int}, int)"/>
        /// <seealso cref="ShiftRightLogical_Core(Vector128{int}, int, Vector128{int}, Vector128{int})"/>
        Vector128<int> ShiftRightLogical_Args(Vector128<int> dummy, int shiftAmount, out Vector128<int> args1);

        /// <summary>
        /// Arguments calculation for shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量的参数计算). Provide arguments for ShiftRightLogical_Core (为 ShiftRightLogical_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftRightLogical_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftRightLogical_Core .</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{uint}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector128{uint}, int)"/>
        /// <seealso cref="ShiftRightLogical_Core(Vector128{uint}, int, Vector128{uint}, Vector128{uint})"/>
        Vector128<uint> ShiftRightLogical_Args(Vector128<uint> dummy, int shiftAmount, out Vector128<uint> args1);

        /// <summary>
        /// Arguments calculation for shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量的参数计算). Provide arguments for ShiftRightLogical_Core (为 ShiftRightLogical_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftRightLogical_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftRightLogical_Core .</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{long}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector128{long}, int)"/>
        /// <seealso cref="ShiftRightLogical_Core(Vector128{long}, int, Vector128{long}, Vector128{long})"/>
        Vector128<long> ShiftRightLogical_Args(Vector128<long> dummy, int shiftAmount, out Vector128<long> args1);

        /// <summary>
        /// Arguments calculation for shifts (unsigned) each element of a vector right by the specified amount. (将向量的每个无符号元素逻辑右移指定量的参数计算). Provide arguments for ShiftRightLogical_Core (为 ShiftRightLogical_Core 提供参数).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="dummy">Not actually used, it is only used to distinguish overloaded methods (实际上没有使用, 它仅用于区分重载方法)..</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数).</param>
        /// <param name="args1">Returns arguments 1 (返回参数1). Used for ShiftRightLogical_Core .</param>
        /// <returns>Returns arguments 0 (返回参数0). Used for ShiftRightLogical_Core .</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{ulong}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector128{ulong}, int)"/>
        /// <seealso cref="ShiftRightLogical_Core(Vector128{ulong}, int, Vector128{ulong}, Vector128{ulong})"/>
        Vector128<ulong> ShiftRightLogical_Args(Vector128<ulong> dummy, int shiftAmount, out Vector128<ulong> args1);

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
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{sbyte}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector128{sbyte}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector128{sbyte}, int, out Vector128{sbyte})"/>
        Vector128<sbyte> ShiftRightLogical_Core(Vector128<sbyte> value, int shiftAmount, Vector128<sbyte> args0, Vector128<sbyte> args1);

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
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{byte}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector128{byte}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector128{byte}, int, out Vector128{byte})"/>
        Vector128<byte> ShiftRightLogical_Core(Vector128<byte> value, int shiftAmount, Vector128<byte> args0, Vector128<byte> args1);

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
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{short}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector128{short}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector128{short}, int, out Vector128{short})"/>
        Vector128<short> ShiftRightLogical_Core(Vector128<short> value, int shiftAmount, Vector128<short> args0, Vector128<short> args1);

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
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{ushort}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector128{ushort}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector128{ushort}, int, out Vector128{ushort})"/>
        Vector128<ushort> ShiftRightLogical_Core(Vector128<ushort> value, int shiftAmount, Vector128<ushort> args0, Vector128<ushort> args1);

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
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{int}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector128{int}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector128{int}, int, out Vector128{int})"/>
        Vector128<int> ShiftRightLogical_Core(Vector128<int> value, int shiftAmount, Vector128<int> args0, Vector128<int> args1);

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
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{uint}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector128{uint}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector128{uint}, int, out Vector128{uint})"/>
        Vector128<uint> ShiftRightLogical_Core(Vector128<uint> value, int shiftAmount, Vector128<uint> args0, Vector128<uint> args1);

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
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{long}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector128{long}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector128{long}, int, out Vector128{long})"/>
        Vector128<long> ShiftRightLogical_Core(Vector128<long> value, int shiftAmount, Vector128<long> args0, Vector128<long> args1);

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
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{ulong}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector128{ulong}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector128{ulong}, int, out Vector128{ulong})"/>
        Vector128<ulong> ShiftRightLogical_Core(Vector128<ulong> value, int shiftAmount, Vector128<ulong> args0, Vector128<ulong> args1);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount - Const (将向量的每个无符号元素逻辑右移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~7 (有效范围是 1~7).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{sbyte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector128{sbyte}, int)"/>
        Vector128<sbyte> ShiftRightLogical_Const(Vector128<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount - Const (将向量的每个无符号元素逻辑右移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~7 (有效范围是 1~7).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{byte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector128{byte}, int)"/>
        Vector128<byte> ShiftRightLogical_Const(Vector128<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount - Const (将向量的每个无符号元素逻辑右移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~15 (有效范围是 1~15).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector128{short}, int)"/>
        Vector128<short> ShiftRightLogical_Const(Vector128<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount - Const (将向量的每个无符号元素逻辑右移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~15 (有效范围是 1~15).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{ushort}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector128{ushort}, int)"/>
        Vector128<ushort> ShiftRightLogical_Const(Vector128<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount - Const (将向量的每个无符号元素逻辑右移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~31 (有效范围是 1~31).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector128{int}, int)"/>
        Vector128<int> ShiftRightLogical_Const(Vector128<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount - Const (将向量的每个无符号元素逻辑右移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~31 (有效范围是 1~31).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{uint}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector128{uint}, int)"/>
        Vector128<uint> ShiftRightLogical_Const(Vector128<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount - Const (将向量的每个无符号元素逻辑右移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~63 (有效范围是 1~63).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{long}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector128{long}, int)"/>
        Vector128<long> ShiftRightLogical_Const(Vector128<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount - Const (将向量的每个无符号元素逻辑右移指定量 - 常量).
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>, <c>shiftAmount &amp;= (T.BitSize-1)</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 1~63 (有效范围是 1~63).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{ulong}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector128{ulong}, int)"/>
        Vector128<ulong> ShiftRightLogical_Const(Vector128<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount);

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
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{sbyte}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector128{sbyte}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector128{sbyte}, int, out Vector128{sbyte})"/>
        Vector128<sbyte> ShiftRightLogical_ConstCore(Vector128<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector128<sbyte> args0, Vector128<sbyte> args1);

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
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{byte}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector128{byte}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector128{byte}, int, out Vector128{byte})"/>
        Vector128<byte> ShiftRightLogical_ConstCore(Vector128<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector128<byte> args0, Vector128<byte> args1);

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
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{short}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector128{short}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector128{short}, int, out Vector128{short})"/>
        Vector128<short> ShiftRightLogical_ConstCore(Vector128<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector128<short> args0, Vector128<short> args1);

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
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{ushort}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector128{ushort}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector128{ushort}, int, out Vector128{ushort})"/>
        Vector128<ushort> ShiftRightLogical_ConstCore(Vector128<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector128<ushort> args0, Vector128<ushort> args1);

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
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{int}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector128{int}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector128{int}, int, out Vector128{int})"/>
        Vector128<int> ShiftRightLogical_ConstCore(Vector128<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector128<int> args0, Vector128<int> args1);

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
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{uint}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector128{uint}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector128{uint}, int, out Vector128{uint})"/>
        Vector128<uint> ShiftRightLogical_ConstCore(Vector128<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector128<uint> args0, Vector128<uint> args1);

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
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{long}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector128{long}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector128{long}, int, out Vector128{long})"/>
        Vector128<long> ShiftRightLogical_ConstCore(Vector128<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector128<long> args0, Vector128<long> args1);

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
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{ulong}, int)"/>
        /// <seealso cref="ShiftRightLogical(Vector128{ulong}, int)"/>
        /// <seealso cref="ShiftRightLogical_Args(Vector128{ulong}, int, out Vector128{ulong})"/>
        Vector128<ulong> ShiftRightLogical_ConstCore(Vector128<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector128<ulong> args0, Vector128<ulong> args1);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~7 (有效范围是 0~7).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{sbyte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector128{sbyte}, int)"/>
        Vector128<sbyte> ShiftRightLogical_Fast(Vector128<sbyte> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~7 (有效范围是 0~7).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{byte}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector128{byte}, int)"/>
        Vector128<byte> ShiftRightLogical_Fast(Vector128<byte> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~15 (有效范围是 0~15).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{short}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector128{short}, int)"/>
        Vector128<short> ShiftRightLogical_Fast(Vector128<short> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~15 (有效范围是 0~15).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{ushort}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector128{ushort}, int)"/>
        Vector128<ushort> ShiftRightLogical_Fast(Vector128<ushort> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~31 (有效范围是 0~31).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{int}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector128{int}, int)"/>
        Vector128<int> ShiftRightLogical_Fast(Vector128<int> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~31 (有效范围是 0~31).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{uint}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector128{uint}, int)"/>
        Vector128<uint> ShiftRightLogical_Fast(Vector128<uint> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~63 (有效范围是 0~63).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{long}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector128{long}, int)"/>
        Vector128<long> ShiftRightLogical_Fast(Vector128<long> value, int shiftAmount);

        /// <summary>
        /// Shifts (unsigned) each element of a vector right by the specified amount. - Fast(将向量的每个无符号元素逻辑右移指定量 - 快速). No check <paramref name="shiftAmount"/>, please use <see cref="Scalars.LimitShiftAmount"/> first, and shiftAmount must not be 0 .
        /// Mnemonic: <c>rt[i] := value[i] &gt;&gt;&gt; shiftAmount</c>.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted (要移位其元素的向量).</param>
        /// <param name="shiftAmount">The number of bits by which to shift each element (每个元素的移位位数). The valid range is 0~63 (有效范围是 0~63).</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftAmount" /> (每个元素的右移 <paramref name="shiftAmount" /> 位的一个向量).</returns>
        /// <seealso cref="ShiftRightLogical_AcceleratedTypes"/>
        /// <seealso cref="Vector128.ShiftRightLogical(Vector128{ulong}, int)"/> // Since: .NET 7
        /// <seealso cref="ShiftRightLogical(Vector128{ulong}, int)"/>
        Vector128<ulong> ShiftRightLogical_Fast(Vector128<ulong> value, int shiftAmount);


        /// <summary>
        /// Types with hardware acceleration when running <c>Shuffle</c> (运行 <c>Shuffle</c> 时具有硬件加速的类型).
        /// </summary>
        /// <remarks>
        /// <para>Meaning of suffixes (后缀的含义).</para>
        /// <para>- (none): Normal (常规).</para>
        /// <para>- Args: Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数).</para>
        /// <para>- Core. Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).</para>
        /// <para>Similar methods (相似的方法).</para>
        /// <para>- <see cref="Shuffle"/>: If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).</para>
        /// <para>- <see cref="YShuffleInsert"/>: If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).</para>
        /// <para>- <see cref="YShuffleKernel"/>: If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). It has the best performance, and is used when you are sure that the index value is not out of range (它的性能最好, 用于确信索引值不会超出范围时).</para>
        /// </remarks>
        /// <seealso cref="Shuffle"/>
        /// <seealso cref="Shuffle_Args"/>
        /// <seealso cref="Shuffle_Core"/>
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
        Vector128<float> Shuffle(Vector128<float> vector, Vector128<int> indices);

        /// <summary>
        /// Shuffle and clear (换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{double}, Vector128{long})"/>
        Vector128<double> Shuffle(Vector128<double> vector, Vector128<long> indices);

        /// <summary>
        /// Shuffle and clear (换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{sbyte}, Vector128{sbyte})"/>
        /// <seealso cref="AdvSimd.VectorTableLookup(Vector128{sbyte}, Vector64{sbyte})"/>
        Vector128<sbyte> Shuffle(Vector128<sbyte> vector, Vector128<sbyte> indices);

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
        Vector128<byte> Shuffle(Vector128<byte> vector, Vector128<byte> indices);

        /// <summary>
        /// Shuffle and clear (换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{short}, Vector128{short})"/>
        Vector128<short> Shuffle(Vector128<short> vector, Vector128<short> indices);

        /// <summary>
        /// Shuffle and clear (换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{ushort}, Vector128{ushort})"/>
        Vector128<ushort> Shuffle(Vector128<ushort> vector, Vector128<ushort> indices);

        /// <summary>
        /// Shuffle and clear (换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{int}, Vector128{int})"/>
        Vector128<int> Shuffle(Vector128<int> vector, Vector128<int> indices);

        /// <summary>
        /// Shuffle and clear (换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{uint}, Vector128{uint})"/>
        Vector128<uint> Shuffle(Vector128<uint> vector, Vector128<uint> indices);

        /// <summary>
        /// Shuffle and clear (换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{long}, Vector128{long})"/>
        Vector128<long> Shuffle(Vector128<long> vector, Vector128<long> indices);

        /// <summary>
        /// Shuffle and clear (换位并清零). Creates a new vector by selecting values from an input vector using a set of indices (通过使用一组索引从输入向量中选择值，来创建一个新向量). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <paramref name="indices" /> (一个新向量，其中包含给定 <paramref name="indices" /> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Shuffle(Vector128{ulong}, Vector128{ulong})"/>
        Vector128<ulong> Shuffle(Vector128<ulong> vector, Vector128<ulong> indices);


        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for Shuffle_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for Shuffle_Core .</param>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        void Shuffle_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1);

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for Shuffle_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for Shuffle_Core .</param>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Core(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        void Shuffle_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1);

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for Shuffle_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for Shuffle_Core .</param>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Core(Vector128{short}, Vector128{short}, Vector128{short})"/>
        void Shuffle_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1);

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for Shuffle_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for Shuffle_Core .</param>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        void Shuffle_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1);

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for Shuffle_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for Shuffle_Core .</param>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Core(Vector128{int}, Vector128{int}, Vector128{int})"/>
        void Shuffle_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1);

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for Shuffle_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for Shuffle_Core .</param>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Core(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        void Shuffle_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1);

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for Shuffle_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for Shuffle_Core .</param>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Core(Vector128{long}, Vector128{long}, Vector128{long})"/>
        void Shuffle_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1);

        /// <summary>
        /// Arguments calculation for shuffle and clear (换位并清零的参数计算). Provide arguments for Shuffle_Core (为 Shuffle_Core 提供参数). If the index value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for Shuffle_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for Shuffle_Core .</param>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        void Shuffle_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1);


        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from Shuffle_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Args(Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        Vector128<float> Shuffle_Core(Vector128<float> vector, Vector128<int> args0, Vector128<int> args1);

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from Shuffle_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Args(Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        Vector128<double> Shuffle_Core(Vector128<double> vector, Vector128<long> args0, Vector128<long> args1);

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from Shuffle_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        /// <seealso cref="AdvSimd.VectorTableLookup(Vector128{sbyte}, Vector64{sbyte})"/>
        Vector128<sbyte> Shuffle_Core(Vector128<sbyte> vector, Vector128<sbyte> args0, Vector128<sbyte> args1);

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from Shuffle_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        /// <seealso cref="AdvSimd.VectorTableLookup(Vector128{byte}, Vector64{byte})"/>
        Vector128<byte> Shuffle_Core(Vector128<byte> vector, Vector128<byte> args0, Vector128<byte> args1);

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from Shuffle_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Args(Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        Vector128<short> Shuffle_Core(Vector128<short> vector, Vector128<short> args0, Vector128<short> args1);

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from Shuffle_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        Vector128<ushort> Shuffle_Core(Vector128<ushort> vector, Vector128<ushort> args0, Vector128<ushort> args1);

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from Shuffle_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Args(Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        Vector128<int> Shuffle_Core(Vector128<int> vector, Vector128<int> args0, Vector128<int> args1);

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from Shuffle_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        Vector128<uint> Shuffle_Core(Vector128<uint> vector, Vector128<uint> args0, Vector128<uint> args1);

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from Shuffle_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Args(Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        Vector128<long> Shuffle_Core(Vector128<long> vector, Vector128<long> args0, Vector128<long> args1);

        /// <summary>
        /// Core calculation for shuffle and clear (换位并清零的核心计算). Its arguments are derived from Shuffle_Args (其参数来源于 Shuffle_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):0</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args0">Arguments 0 (参数0). Derived from Shuffle_Args .</param>
        /// <param name="args1">Arguments 1 (参数1). Derived from Shuffle_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="Shuffle_AcceleratedTypes"/>
        /// <seealso cref="Shuffle_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        Vector128<ulong> Shuffle_Core(Vector128<ulong> vector, Vector128<ulong> args0, Vector128<ulong> args1);


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
        /// <seealso cref="Vector128.Sum{T}(Vector128{T})" />
        float Sum(Vector128<float> value);

        /// <summary>
        /// Computes the sum of all elements in a vector (计算向量中所有元素的总和).
        /// Mnemonic: <c>rt := value[0] + value[1] + value[2] + ... + value[Count-1]</c>.
        /// </summary>
        /// <param name="value">The vector whose elements will be summed (将对其元素求和的向量).</param>
        /// <returns>The sum of all elements in <paramref name="value" /> (<paramref name="value" /> 中所有元素的总和).</returns>
        /// <seealso cref="Sum_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Sum{T}(Vector128{T})" />
        double Sum(Vector128<double> value);

        /// <summary>
        /// Computes the sum of all elements in a vector (计算向量中所有元素的总和).
        /// Mnemonic: <c>rt := value[0] + value[1] + value[2] + ... + value[Count-1]</c>.
        /// </summary>
        /// <param name="value">The vector whose elements will be summed (将对其元素求和的向量).</param>
        /// <returns>The sum of all elements in <paramref name="value" /> (<paramref name="value" /> 中所有元素的总和).</returns>
        /// <seealso cref="Sum_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Sum{T}(Vector128{T})" />
        sbyte Sum(Vector128<sbyte> value);

        /// <summary>
        /// Computes the sum of all elements in a vector (计算向量中所有元素的总和).
        /// Mnemonic: <c>rt := value[0] + value[1] + value[2] + ... + value[Count-1]</c>.
        /// </summary>
        /// <param name="value">The vector whose elements will be summed (将对其元素求和的向量).</param>
        /// <returns>The sum of all elements in <paramref name="value" /> (<paramref name="value" /> 中所有元素的总和).</returns>
        /// <seealso cref="Sum_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Sum{T}(Vector128{T})" />
        byte Sum(Vector128<byte> value);

        /// <summary>
        /// Computes the sum of all elements in a vector (计算向量中所有元素的总和).
        /// Mnemonic: <c>rt := value[0] + value[1] + value[2] + ... + value[Count-1]</c>.
        /// </summary>
        /// <param name="value">The vector whose elements will be summed (将对其元素求和的向量).</param>
        /// <returns>The sum of all elements in <paramref name="value" /> (<paramref name="value" /> 中所有元素的总和).</returns>
        /// <seealso cref="Sum_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Sum{T}(Vector128{T})" />
        short Sum(Vector128<short> value);

        /// <summary>
        /// Computes the sum of all elements in a vector (计算向量中所有元素的总和).
        /// Mnemonic: <c>rt := value[0] + value[1] + value[2] + ... + value[Count-1]</c>.
        /// </summary>
        /// <param name="value">The vector whose elements will be summed (将对其元素求和的向量).</param>
        /// <returns>The sum of all elements in <paramref name="value" /> (<paramref name="value" /> 中所有元素的总和).</returns>
        /// <seealso cref="Sum_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Sum{T}(Vector128{T})" />
        ushort Sum(Vector128<ushort> value);

        /// <summary>
        /// Computes the sum of all elements in a vector (计算向量中所有元素的总和).
        /// Mnemonic: <c>rt := value[0] + value[1] + value[2] + ... + value[Count-1]</c>.
        /// </summary>
        /// <param name="value">The vector whose elements will be summed (将对其元素求和的向量).</param>
        /// <returns>The sum of all elements in <paramref name="value" /> (<paramref name="value" /> 中所有元素的总和).</returns>
        /// <seealso cref="Sum_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Sum{T}(Vector128{T})" />
        int Sum(Vector128<int> value);

        /// <summary>
        /// Computes the sum of all elements in a vector (计算向量中所有元素的总和).
        /// Mnemonic: <c>rt := value[0] + value[1] + value[2] + ... + value[Count-1]</c>.
        /// </summary>
        /// <param name="value">The vector whose elements will be summed (将对其元素求和的向量).</param>
        /// <returns>The sum of all elements in <paramref name="value" /> (<paramref name="value" /> 中所有元素的总和).</returns>
        /// <seealso cref="Sum_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Sum{T}(Vector128{T})" />
        uint Sum(Vector128<uint> value);

        /// <summary>
        /// Computes the sum of all elements in a vector (计算向量中所有元素的总和).
        /// Mnemonic: <c>rt := value[0] + value[1] + value[2] + ... + value[Count-1]</c>.
        /// </summary>
        /// <param name="value">The vector whose elements will be summed (将对其元素求和的向量).</param>
        /// <returns>The sum of all elements in <paramref name="value" /> (<paramref name="value" /> 中所有元素的总和).</returns>
        /// <seealso cref="Sum_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Sum{T}(Vector128{T})" />
        long Sum(Vector128<long> value);

        /// <summary>
        /// Computes the sum of all elements in a vector (计算向量中所有元素的总和).
        /// Mnemonic: <c>rt := value[0] + value[1] + value[2] + ... + value[Count-1]</c>.
        /// </summary>
        /// <param name="value">The vector whose elements will be summed (将对其元素求和的向量).</param>
        /// <returns>The sum of all elements in <paramref name="value" /> (<paramref name="value" /> 中所有元素的总和).</returns>
        /// <seealso cref="Sum_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Sum{T}(Vector128{T})" />
        ulong Sum(Vector128<ulong> value);


        /// <summary>
        /// Types with hardware acceleration when running <c>Widen</c> (运行 <c>Widen</c> 时具有硬件加速的类型).
        /// </summary>
        /// <seealso cref="Widen"/>
        TypeCodeFlags Widen_AcceleratedTypes { get; }

        /// <summary>
        /// Widens a <seealso cref="Vector128{T}"/> into two <seealso cref="Vector128{T}"/> instances (将一个 <seealso cref="Vector128{T}"/> 扩宽为两个 <seealso cref="Vector128{T}"/> 实例).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <param name="lower">When this method returns, contains the widened elements from lower indices in the source vector (当此方法返回时，包含源向量中来自较低下标的扩宽元素).</param>
        /// <param name="upper">When this method returns, contains the widened elements from upper indices in the source vector (当此方法返回时，包含源向量中来自较高下标的扩宽元素).</param>
        /// <seealso cref="Widen_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Widen(Vector128{float})" />
        void Widen(Vector128<float> source, out Vector128<double> lower, out Vector128<double> upper);

        /// <summary>
        /// Widens a <seealso cref="Vector128{T}"/> into two <seealso cref="Vector128{T}"/> instances (将一个 <seealso cref="Vector128{T}"/> 扩宽为两个 <seealso cref="Vector128{T}"/> 实例).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <param name="lower">When this method returns, contains the widened elements from lower indices in the source vector (当此方法返回时，包含源向量中来自较低下标的扩宽元素).</param>
        /// <param name="upper">When this method returns, contains the widened elements from upper indices in the source vector (当此方法返回时，包含源向量中来自较高下标的扩宽元素).</param>
        /// <seealso cref="Widen_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Widen(Vector128{sbyte})" />
        void Widen(Vector128<sbyte> source, out Vector128<short> lower, out Vector128<short> upper);

        /// <summary>
        /// Widens a <seealso cref="Vector128{T}"/> into two <seealso cref="Vector128{T}"/> instances (将一个 <seealso cref="Vector128{T}"/> 扩宽为两个 <seealso cref="Vector128{T}"/> 实例).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <param name="lower">When this method returns, contains the widened elements from lower indices in the source vector (当此方法返回时，包含源向量中来自较低下标的扩宽元素).</param>
        /// <param name="upper">When this method returns, contains the widened elements from upper indices in the source vector (当此方法返回时，包含源向量中来自较高下标的扩宽元素).</param>
        /// <seealso cref="Widen_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Widen(Vector128{byte})" />
        void Widen(Vector128<byte> source, out Vector128<ushort> lower, out Vector128<ushort> upper);

        /// <summary>
        /// Widens a <seealso cref="Vector128{T}"/> into two <seealso cref="Vector128{T}"/> instances (将一个 <seealso cref="Vector128{T}"/> 扩宽为两个 <seealso cref="Vector128{T}"/> 实例).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <param name="lower">When this method returns, contains the widened elements from lower indices in the source vector (当此方法返回时，包含源向量中来自较低下标的扩宽元素).</param>
        /// <param name="upper">When this method returns, contains the widened elements from upper indices in the source vector (当此方法返回时，包含源向量中来自较高下标的扩宽元素).</param>
        /// <seealso cref="Widen_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Widen(Vector128{short})" />
        void Widen(Vector128<short> source, out Vector128<int> lower, out Vector128<int> upper);

        /// <summary>
        /// Widens a <seealso cref="Vector128{T}"/> into two <seealso cref="Vector128{T}"/> instances (将一个 <seealso cref="Vector128{T}"/> 扩宽为两个 <seealso cref="Vector128{T}"/> 实例).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <param name="lower">When this method returns, contains the widened elements from lower indices in the source vector (当此方法返回时，包含源向量中来自较低下标的扩宽元素).</param>
        /// <param name="upper">When this method returns, contains the widened elements from upper indices in the source vector (当此方法返回时，包含源向量中来自较高下标的扩宽元素).</param>
        /// <seealso cref="Widen_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Widen(Vector128{ushort})" />
        void Widen(Vector128<ushort> source, out Vector128<uint> lower, out Vector128<uint> upper);

        /// <summary>
        /// Widens a <seealso cref="Vector128{T}"/> into two <seealso cref="Vector128{T}"/> instances (将一个 <seealso cref="Vector128{T}"/> 扩宽为两个 <seealso cref="Vector128{T}"/> 实例).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <param name="lower">When this method returns, contains the widened elements from lower indices in the source vector (当此方法返回时，包含源向量中来自较低下标的扩宽元素).</param>
        /// <param name="upper">When this method returns, contains the widened elements from upper indices in the source vector (当此方法返回时，包含源向量中来自较高下标的扩宽元素).</param>
        /// <seealso cref="Widen_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Widen(Vector128{int})" />
        void Widen(Vector128<int> source, out Vector128<long> lower, out Vector128<long> upper);

        /// <summary>
        /// Widens a <seealso cref="Vector128{T}"/> into two <seealso cref="Vector128{T}"/> instances (将一个 <seealso cref="Vector128{T}"/> 扩宽为两个 <seealso cref="Vector128{T}"/> 实例).
        /// Mnemonic: <c>element_ref(i, lower, upper) := widen(source[i])</c>.
        /// </summary>
        /// <param name="source">The vector whose elements are to be widened (要扩宽其元素的向量).</param>
        /// <param name="lower">When this method returns, contains the widened elements from lower indices in the source vector (当此方法返回时，包含源向量中来自较低下标的扩宽元素).</param>
        /// <param name="upper">When this method returns, contains the widened elements from upper indices in the source vector (当此方法返回时，包含源向量中来自较高下标的扩宽元素).</param>
        /// <seealso cref="Widen_AcceleratedTypes"/>
        /// <seealso cref="Vector128.Widen(Vector128{uint})" />
        void Widen(Vector128<uint> source, out Vector128<ulong> lower, out Vector128<ulong> upper);

#endif
    }
}
